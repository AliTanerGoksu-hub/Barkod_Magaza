Imports FastReport
Imports Microsoft.Win32
Imports DevExpress.XtraEditors
Imports System.IO
Public Class frm_tbKarpin_Liste
    Public Connection As String = ""
    Public FirmaNo As Integer
    Public DonemNo As Integer
    Public Kullanici As String = ""
    Dim tarih As DateTime
    Dim sFisTipi As String = ""
    Private Sub frm_tbKarpin_Liste_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        tarih = dteSistemTarihi
        txt_dteFisTarihi1.EditValue = tarih
        txt_dteFisTarihi2.EditValue = tarih
        dataload_satici()
        dataload_depo()
        Try
            gorunum_yukle()
        Catch ex As Exception
        End Try
    End Sub
    Private Sub gorunum_kaydet()
        GridView1.SaveLayoutToRegistry("SOFTWARE\BusinessSmart\VIEW\CARI\" & Me.Name.ToString & "")
        XtraMessageBox.Show(Sorgu_sDil("Görünüm Kaydedildi", sDil), Sorgu_sDil("Dikkat", sDil), MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub
    Private Sub gorunum_yukle()
        For Each btn As DevExpress.XtraBars.BarItem In BarManager1.Items
            btn.Caption = Sorgu_sDil(btn.Caption, sDil)
        Next
        For Each clmn As DevExpress.XtraGrid.Columns.GridColumn In GridView1.Columns
            clmn.Caption = Sorgu_sDil(clmn.Caption, sDil)
        Next
        Dim itm
        For Each itm In ContextMenu1.MenuItems
            itm.text = Sorgu_sDil(itm.text, sDil)
        Next
        SimpleButton1.Text = Sorgu_sDil(SimpleButton1.Text, sDil)
        SimpleButton2.Text = Sorgu_sDil(SimpleButton2.Text, sDil)
        SimpleButton3.Text = Sorgu_sDil(SimpleButton3.Text, sDil)
        GridView1.RestoreLayoutFromRegistry("SOFTWARE\BusinessSmart\VIEW\CARI\" & Me.Name.ToString & "")
    End Sub
    Private Sub SimpleButton5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SimpleButton5.Click
        Karpin_yeni()
    End Sub
    Private Sub dataload_satici()
        sec_sSatici.Properties.DataSource = sorgu(sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT     sSaticiRumuzu , sAdi + ' ' + sSoyadi AS sSatici  FROM         tbSatici Order by sSaticiRumuzu ")).Tables(0)
        sec_sSatici.ItemIndex = 0
    End Sub
    Private Sub dataload_depo()
        sec_sDepo.Properties.DataSource = sorgu(sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT     sDepo , sAciklama  FROM         tbDepo Order by sDepo ")).Tables(0)
        sec_sDepo.ItemIndex = 0
    End Sub
    Private Function sorgu(ByVal query As String) As DataSet
        Dim conn As New OleDb.OleDbConnection
        Dim adapter As New OleDb.OleDbDataAdapter
        Dim cmd As New OleDb.OleDbCommand
        conn.ConnectionString = Connection
        adapter.SelectCommand = cmd
        cmd.CommandText = query
        cmd.Connection = conn
        conn.Open()
        Dim DS As New DataSet
        Dim N As Integer = adapter.Fill(DS, "TABLE1")
        conn.Close()
        Return DS
    End Function
    Public Sub dataload(ByVal dteFisTarihi1 As DateTime, ByVal dteFisTarihi2 As DateTime, ByVal lFisNo1 As Int64, ByVal lFisNo2 As Int64, ByVal lTutar1 As Decimal, ByVal lTutar2 As Decimal, ByVal sDepo As String, ByVal sSatici As String)
        Dim kriter As String = ""
        If Trim(sSatici) <> "" Then
            kriter += " AND sSatici = '" & sSatici & "' "
        End If
        If Trim(sDepo) <> "" Then
            kriter += " AND sDepo = '" & sDepo & "' "
        End If
        GridControl1.DataSource = sorgu(sorgu_query("SET DATEFORMAT DMY SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT *, ((lToplamSatis - lToplamIskonto)+lKdvTutari) AS lToplamTutar FROM (SELECT * , (SELECT SUM(lTutar) FROM tbKarpinSevkiyat WHERE nKarpinID = tbKarpin.nKarpinID) AS lToplamSatis , (SELECT TOP 1 lIskonto FROM tbKarpinSevkiyat WHERE nKarpinID = tbKarpin.nKarpinID) AS lToplamIskonto ,(SELECT TOP 1 lKdvTutari FROM tbKarpinSevkiyat WHERE nKarpinID = tbKarpin.nKarpinID) AS lKdvTutari, (SELECT SUM(lTutar) FROM tbKarpinTahsilat WHERE sFisTipi = 1 AND nKarpinID = tbKarpin.nKarpinID) AS lTahsilat , (SELECT SUM(lTutar) FROM tbKarpinTahsilat WHERE sFisTipi = 2 AND nKarpinID = tbKarpin.nKarpinID) AS lVeresiye , (SELECT SUM(lTutar) FROM tbKarpinTahsilat WHERE sFisTipi = 3 AND nKarpinID = tbKarpin.nKarpinID) AS lPesin , (SELECT COUNT(nFirmaID) FROM tbKarpinTahsilat WHERE sFisTipi = 4 AND nKarpinID = tbKarpin.nKarpinID) AS nZiyaret , (SELECT SUM(lTutar) FROM tbKarpinTahsilat WHERE sFisTipi = 5 AND nKarpinID = tbKarpin.nKarpinID) AS lMasraf FROM tbKarpin) T WHERE dteFisTarihi between '" & dteFisTarihi1 & "' and '" & dteFisTarihi2 & "' and nKarpinID between " & lFisNo1 & " and " & lFisNo2 & "  " & kriter & "  Order by dteFisTarihi")).Tables(0)
        GridControl1.DataMember = Nothing
        GridControl1.Select()
        GridControl1.Focus()
        kriter = Nothing
    End Sub
    Private Sub tbKarpin_Sevkiyat()
        If GridView1.RowCount > 0 Then
            Dim dr As DataRow = GridView1.GetDataRow(GridView1.FocusedRowHandle)
            If dr("nKarpinID").ToString <> "" Then
                Dim frm As New frm_tbKarpin_Sevkiyat
                frm.Label1.Text = dr("sSaticiAciklama")
                frm.firmano = FirmaNo
                frm.DonemNo = DonemNo
                frm.Connection = Connection
                frm.nKarpinID = dr("nKarpinID")
                frm.dteFisTarihi = dr("dteFisTarihi")
                frm.sSatici = dr("sSatici").ToString
                frm.sDepo = dr("sDepo").ToString
                frm.kullanici = Kullanici
                frm.ShowDialog()
                frm = Nothing
                Dim satir = GridView1.FocusedRowHandle
                ara()
                GridView1.FocusedRowHandle = satir
                satir = Nothing
            End If
        End If
    End Sub
    Private Sub tbKarpin_Emanet_Giris()
        If GridView1.RowCount > 0 Then
            Dim dr As DataRow = GridView1.GetDataRow(GridView1.FocusedRowHandle)
            If dr("nKarpinID").ToString <> "" Then
                Dim frm As New frm_tbKarpin_Emanet
                frm.firmano = FirmaNo
                frm.DonemNo = DonemNo
                frm.Connection = Connection
                frm.nKarpinID = dr("nKarpinID")
                frm.dteFisTarihi = dr("dteFisTarihi")
                frm.sSatici = dr("sSatici").ToString
                frm.sDepo = dr("sDepo").ToString
                frm.kullanici = Kullanici
                frm.sFisTipi = 1
                frm.ShowDialog()
                frm = Nothing
                Dim satir = GridView1.FocusedRowHandle
                ara()
                GridView1.FocusedRowHandle = satir
                satir = Nothing
            End If
        End If
    End Sub
    Private Sub tbKarpin_Emanet_Cikis()
        If GridView1.RowCount > 0 Then
            Dim dr As DataRow = GridView1.GetDataRow(GridView1.FocusedRowHandle)
            If dr("nKarpinID").ToString <> "" Then
                Dim frm As New frm_tbKarpin_Emanet
                frm.firmano = FirmaNo
                frm.DonemNo = DonemNo
                frm.Connection = Connection
                frm.nKarpinID = dr("nKarpinID")
                frm.dteFisTarihi = dr("dteFisTarihi")
                frm.sSatici = dr("sSatici").ToString
                frm.sDepo = dr("sDepo").ToString
                frm.kullanici = Kullanici
                frm.sFisTipi = 2
                frm.ShowDialog()
                frm = Nothing
                Dim satir = GridView1.FocusedRowHandle
                ara()
                GridView1.FocusedRowHandle = satir
                satir = Nothing
            End If
        End If
    End Sub
    Private Sub tbKarpin_Veresiye()
        If GridView1.RowCount > 0 Then
            Dim dr As DataRow = GridView1.GetDataRow(GridView1.FocusedRowHandle)
            If dr("nKarpinID").ToString <> "" Then
                Dim frm As New frm_tbKarpin_Tahsilat
                frm.firmano = FirmaNo
                frm.DonemNo = DonemNo
                frm.Connection = Connection
                frm.nKarpinID = dr("nKarpinID")
                frm.dteFisTarihi = dr("dteFisTarihi")
                frm.sSatici = dr("sSatici").ToString
                frm.sDepo = dr("sDepo").ToString
                frm.sFisTipi = 2
                frm.kullanici = Kullanici
                frm.ShowDialog()
                frm = Nothing
                Dim satir = GridView1.FocusedRowHandle
                ara()
                GridView1.FocusedRowHandle = satir
                satir = Nothing
            End If
        End If
    End Sub
    Private Sub tbKarpin_Tahsilat()
        If GridView1.RowCount > 0 Then
            Dim dr As DataRow = GridView1.GetDataRow(GridView1.FocusedRowHandle)
            If dr("nKarpinID").ToString <> "" Then
                Dim frm As New frm_tbKarpin_Tahsilat
                frm.firmano = FirmaNo
                frm.DonemNo = DonemNo
                frm.Connection = Connection
                frm.nKarpinID = dr("nKarpinID")
                frm.dteFisTarihi = dr("dteFisTarihi")
                frm.sSatici = dr("sSatici").ToString
                frm.sDepo = dr("sDepo").ToString
                frm.sFisTipi = 1
                frm.kullanici = Kullanici
                frm.ShowDialog()
                frm = Nothing
                Dim satir = GridView1.FocusedRowHandle
                ara()
                GridView1.FocusedRowHandle = satir
                satir = Nothing
            End If
        End If
    End Sub
    Private Sub tbKarpin_Pesin()
        If GridView1.RowCount > 0 Then
            Dim dr As DataRow = GridView1.GetDataRow(GridView1.FocusedRowHandle)
            If dr("nKarpinID").ToString <> "" Then
                Dim frm As New frm_tbKarpin_Tahsilat
                frm.firmano = FirmaNo
                frm.DonemNo = DonemNo
                frm.Connection = Connection
                frm.nKarpinID = dr("nKarpinID")
                frm.dteFisTarihi = dr("dteFisTarihi")
                frm.sSatici = dr("sSatici").ToString
                frm.sDepo = dr("sDepo").ToString
                frm.sFisTipi = 3
                frm.kullanici = Kullanici
                frm.ShowDialog()
                frm = Nothing
                Dim satir = GridView1.FocusedRowHandle
                ara()
                GridView1.FocusedRowHandle = satir
                satir = Nothing
            End If
        End If
    End Sub
    Private Sub tbKarpin_Rut()
        If GridView1.RowCount > 0 Then
            Dim dr As DataRow = GridView1.GetDataRow(GridView1.FocusedRowHandle)
            If dr("nKarpinID").ToString <> "" Then
                Dim frm As New frm_tbKarpin_Tahsilat
                frm.firmano = FirmaNo
                frm.DonemNo = DonemNo
                frm.Connection = Connection
                frm.nKarpinID = dr("nKarpinID")
                frm.dteFisTarihi = dr("dteFisTarihi")
                frm.sSatici = dr("sSatici").ToString
                frm.sDepo = dr("sDepo").ToString
                frm.sFisTipi = 4
                frm.kullanici = Kullanici
                frm.ShowDialog()
                frm = Nothing
                Dim satir = GridView1.FocusedRowHandle
                ara()
                GridView1.FocusedRowHandle = satir
                satir = Nothing
            End If
        End If
    End Sub
    Private Sub tbKarpin_Masraf()
        If GridView1.RowCount > 0 Then
            Dim dr As DataRow = GridView1.GetDataRow(GridView1.FocusedRowHandle)
            If dr("nKarpinID").ToString <> "" Then
                Dim frm As New frm_tbKarpin_Tahsilat
                frm.firmano = FirmaNo
                frm.DonemNo = DonemNo
                frm.Connection = Connection
                frm.nKarpinID = dr("nKarpinID")
                frm.dteFisTarihi = dr("dteFisTarihi")
                frm.sSatici = dr("sSatici").ToString
                frm.sDepo = dr("sDepo").ToString
                frm.sFisTipi = 5
                frm.kullanici = Kullanici
                frm.ShowDialog()
                frm = Nothing
                Dim satir = GridView1.FocusedRowHandle
                ara()
                GridView1.FocusedRowHandle = satir
                satir = Nothing
            End If
        End If
    End Sub
    Private Sub tbKarpin_ParaTeslimat()
        If GridView1.RowCount > 0 Then
            Dim dr As DataRow = GridView1.GetDataRow(GridView1.FocusedRowHandle)
            If dr("nKarpinID").ToString <> "" Then
                Dim frm As New frm_tbKarpin_ParaTeslimat
                frm.firmano = FirmaNo
                frm.DonemNo = DonemNo
                frm.Connection = Connection
                frm.nKarpinID = dr("nKarpinID")
                frm.dteFisTarihi = dr("dteFisTarihi")
                frm.sSatici = dr("sSatici").ToString
                frm.sDepo = dr("sDepo").ToString
                frm.ShowDialog()
                frm = Nothing
                Dim satir = GridView1.FocusedRowHandle
                ara()
                GridView1.FocusedRowHandle = satir
                satir = Nothing
            End If
        End If
    End Sub
    Private Sub Karpin_yeni()
        Dim frm As New frm_tbKarpin_Duzelt
        frm.FirmaNo = FirmaNo
        frm.DonemNo = DonemNo
        frm.Connection = Connection
        frm.Kullanici = Kullanici
        frm.dteFisTarihi.EditValue = txt_dteFisTarihi1.EditValue
        If frm.ShowDialog(Me) = Windows.Forms.DialogResult.OK Then
            tbKarpin_kaydet_yeni(0, frm.dteFisTarihi.EditValue, frm.sec_sSatici.Text, frm.sec_sSatici.EditValue, frm.sec_sDepo.EditValue, frm.txt_KmBaslangic.EditValue, frm.txt_KmBitis.EditValue, frm.txt_Km.EditValue, frm.txt_sAciklama1.Text, frm.txt_sAciklama2.Text, frm.txt_sAciklama3.Text, frm.txt_sAciklama4.Text, frm.txt_sAciklama5.Text, Now)
            ara()
            GridView1.MoveLast()
        End If
        frm = Nothing
    End Sub
    Private Sub Karpin_duzelt()
        If GridView1.RowCount > 0 Then
            Dim dr As DataRow = GridView1.GetDataRow(GridView1.FocusedRowHandle)
            Dim frm As New frm_tbKarpin_Duzelt
            frm.FirmaNo = FirmaNo
            frm.DonemNo = DonemNo
            frm.Connection = Connection
            frm.Kullanici = Kullanici
            frm.dteFisTarihi.EditValue = dr("dteFisTarihi")
            frm.sec_sSatici.EditValue = dr("sSatici")
            frm.sSaticiRumuzu = dr("sSatici")
            frm.sDepo = dr("sDepo")
            frm.sec_sDepo.EditValue = dr("sDepo")
            frm.txt_KmBaslangic.EditValue = dr("nKmBaslangic")
            frm.txt_KmBitis.EditValue = dr("nKmBitis")
            frm.txt_Km.EditValue = dr("nKmFark")
            frm.nKmBaslangic = dr("nKmBaslangic")
            frm.nKmBitis = dr("nKmBitis")
            frm.nKmFark = dr("nKmFark")
            frm.txt_sAciklama1.Text = dr("sAciklama1")
            frm.txt_sAciklama2.Text = dr("sAciklama2")
            frm.txt_sAciklama3.Text = dr("sAciklama3")
            frm.txt_sAciklama4.Text = dr("sAciklama4")
            frm.txt_sAciklama5.Text = dr("sAciklama5")
            frm.bIslemStatus = True
            If frm.ShowDialog(Me) = Windows.Forms.DialogResult.OK Then
                tbKarpin_kaydet_degistir(dr("nKarpinID"), frm.dteFisTarihi.EditValue, frm.sec_sSatici.Text, frm.sec_sSatici.EditValue, frm.sec_sDepo.EditValue, frm.txt_KmBaslangic.EditValue, frm.txt_KmBitis.EditValue, frm.txt_Km.EditValue, frm.txt_sAciklama1.Text, frm.txt_sAciklama2.Text, frm.txt_sAciklama3.Text, frm.txt_sAciklama4.Text, frm.txt_sAciklama5.Text, Now)
                ara()
                GridView1.MoveLast()
            End If
            frm = Nothing
        End If
    End Sub
    Private Sub rpt_karpin()
        If GridView1.RowCount > 0 Then
            Dim dr As DataRow = GridView1.GetDataRow(GridView1.FocusedRowHandle)
            If IntPtr.Size = 4 Then
                '32 Bit
                Dim frx As New TfrxReportClass
                Dim frf As New TfrxADOQuery
                Dim ds As New TfrxUserDataSetClass
                Dim data As New TfrxADODatabaseClass
                Dim qr_vtahsilat As New TfrxADOQuery
                Dim qr_tahsilat As New TfrxADOQuery
                Dim qr_sevkiyat As New TfrxADOQuery
                Dim qr_parateslimat As New TfrxADOQuery
                Dim qr_karpin As New TfrxADOQuery
                Dim qr_ptahsilat As New TfrxADOQuery
                Dim qr_satis As New TfrxADOQuery
                Dim qr_tahsilatlar As New TfrxADOQuery
                Dim qr_tahsilat_toplam As New TfrxADOQuery
                Dim qr_giris_emanet As New TfrxADOQuery
                Dim qr_cikis_emanet As New TfrxADOQuery
                Dim qr_vtahsilat_toplam As New TfrxADOQuery
                Dim qr_tbKarpinMasraf As New TfrxADOQuery
                Dim qr_ptahsilat_toplam As New TfrxADOQuery
                Dim qr_connection As New TfrxADODatabase
                Registry.LocalMachine.CreateSubKey("Software").CreateSubKey("Fast Reports").CreateSubKey("connections").SetValue("UGURLU", Connection)
                frx.Resources.LoadLanguageResourcesFromFile("C:\Program Files\FastReports\FastReport Studio\bin\turkish.frc")
                frx.LoadReportFromFile("C:\Formlar\karpin.fr3")
                frx.SetVariable("EVRAKNO", "" & dr("nKarpinID") & "")
                qr_connection.ConnectionString = Connection.ToString
                qr_connection.LoginPrompt = False
                qr_connection.CommandTimeout = Nothing
                qr_connection.Connected = True
                qr_vtahsilat = frx.FindObject("vtahsilat")
                qr_vtahsilat.DataBase = qr_connection
                qr_tahsilat = frx.FindObject("tahsilat")
                qr_tahsilat.DataBase = qr_connection
                qr_sevkiyat = frx.FindObject("sevkiyat")
                qr_sevkiyat.DataBase = qr_connection
                qr_parateslimat = frx.FindObject("parateslimat")
                qr_parateslimat.DataBase = qr_connection
                qr_karpin = frx.FindObject("karpin")
                qr_karpin.DataBase = qr_connection
                qr_ptahsilat = frx.FindObject("ptahsilat")
                qr_ptahsilat.DataBase = qr_connection
                qr_satis = frx.FindObject("satis")
                qr_satis.DataBase = qr_connection
                qr_tahsilatlar = frx.FindObject("tahsilatlar")
                qr_tahsilatlar.DataBase = qr_connection
                qr_tahsilat_toplam = frx.FindObject("tahsilat_toplam")
                qr_tahsilat_toplam.DataBase = qr_connection
                qr_giris_emanet = frx.FindObject("giris_emanet")
                qr_giris_emanet.DataBase = qr_connection
                qr_cikis_emanet = frx.FindObject("cikis_emanet")
                qr_cikis_emanet.DataBase = qr_connection
                qr_vtahsilat_toplam = frx.FindObject("vtahsilat_toplam")
                qr_vtahsilat_toplam.DataBase = qr_connection
                qr_ptahsilat_toplam = frx.FindObject("ptahsilat_toplam")
                qr_ptahsilat_toplam.DataBase = qr_connection
                qr_tbKarpinMasraf = frx.FindObject("tbKarpinMasraf")
                qr_tbKarpinMasraf.DataBase = qr_connection
                frx.ShowReport()
            ElseIf IntPtr.Size = 8 Then
                '64 Bit
                Dim args(50) As String
                Dim processYol As String
                args(0) = "C:\Formlar\karpin.fr3"
                args(1) = "" & Connection.ToString() & ""
                args(4) = "1"
                args(5) = "1"
                args(6) = "EVRAKNO"
                args(7) = "" & dr("nKarpinID") & ""
                args(2) = "ééééééééééééé"
                args(3) = "vtahsilatétahsilatésevkiyatéparateslimatékarpinéptahsilatésatisétahsilatlarétahsilat_toplamégiris_emanetécikis_emanetévtahsilat_toplaméptahsilat_toplamétbKarpinMasraf"
                processYol = args(0)
                For i As Integer = 1 To 7
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
            GridControl1.Select()
            GridControl1.Focus()
        End If
    End Sub
    Private Sub rpt_karpin_DUZELT()
        If GridView1.RowCount > 0 Then
            Dim dr As DataRow = GridView1.GetDataRow(GridView1.FocusedRowHandle)
            If IntPtr.Size = 4 Then
                '32 Bit
                Dim frx As New TfrxReportClass
                Dim frf As New TfrxADOQuery
                Dim ds As New TfrxUserDataSetClass
                Dim data As New TfrxADODatabaseClass
                frx.LoadReportFromFile("C:\Formlar\karpin.fr3")
                frx.SetVariable("EVRAKNO", "" & dr("nKarpinID") & "")
                frx.DesignReport()
            ElseIf IntPtr.Size = 8 Then
                '64 Bit
                Dim args(50) As String
                Dim processYol As String
                args(0) = "C:\Formlar\karpin.fr3"
                args(1) = "" & Connection.ToString() & ""
                args(2) = ""
                args(3) = ""
                args(4) = "2"
                args(5) = "1"
                args(6) = "EVRAKNO"
                args(7) = "" & dr("nKarpinID") & ""
                processYol = args(0)
                For i As Integer = 1 To 7
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
            GridControl1.Select()
            GridControl1.Focus()
        End If
    End Sub
    Private Sub tbKarpin_Aktarim()
        Dim frm As New frm_tbKarpin_Aktarim
        frm.firmano = FirmaNo
        frm.donemno = DonemNo
        frm.connection = Connection
        frm.ShowDialog()
    End Sub
    Private Function sorgu_query(ByVal query As String) As String
        query = Replace(query, "*!F", "F0" + FirmaNo.ToString)
        query = Replace(query, "!D", "D000" + DonemNo.ToString)
        Return query
    End Function
    Private Sub tbKarpin_kaydet_yeni(ByVal nKarpinID As Integer, ByVal dteFisTarihi As DateTime, ByVal sSaticiAciklama As String, ByVal sSatici As String, ByVal sDepo As String, ByVal nKmBaslangic As Int64, ByVal nKmBitis As Int64, ByVal nKmFark As Int64, ByVal sAciklama1 As String, ByVal sAciklama2 As String, ByVal sAciklama3 As String, ByVal sAciklama4 As String, ByVal sAciklama5 As String, ByVal dteKayitTarihi As DateTime)
        Dim con As New OleDb.OleDbConnection
        Dim cmd As New OleDb.OleDbCommand
        cmd.Connection = con
        con.ConnectionString = Connection
        If con.State = ConnectionState.Closed = True Then
            con.Open()
        End If
        cmd.CommandText = sorgu_query("SET DATEFORMAT DMY SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED INSERT INTO tbKarpin (dteFisTarihi, sSaticiAciklama, sSatici, sDepo, nKmBaslangic, nKmBitis, nKmFark, sAciklama1, sAciklama2, sAciklama3, sAciklama4, sAciklama5, dteKayitTarihi) VALUES     ('" & dteFisTarihi & "', '" & sSaticiAciklama & "', '" & sSatici & "', '" & sDepo & "', " & nKmBaslangic & ", " & nKmBitis & ", " & nKmFark & ", '" & sAciklama1 & "', '" & sAciklama2 & "', '" & sAciklama3 & "', '" & sAciklama4 & "', '" & sAciklama5 & "', '" & dteKayitTarihi & "')")
        cmd.ExecuteNonQuery()
        con.Close()
    End Sub
    Private Sub tbKarpin_kaydet_degistir(ByVal nKarpinID As Integer, ByVal dteFisTarihi As DateTime, ByVal sSaticiAciklama As String, ByVal sSatici As String, ByVal sDepo As String, ByVal nKmBaslangic As Int64, ByVal nKmBitis As Int64, ByVal nKmFark As Int64, ByVal sAciklama1 As String, ByVal sAciklama2 As String, ByVal sAciklama3 As String, ByVal sAciklama4 As String, ByVal sAciklama5 As String, ByVal dteKayitTarihi As DateTime)
        Dim con As New OleDb.OleDbConnection
        Dim cmd As New OleDb.OleDbCommand
        cmd.Connection = con
        con.ConnectionString = Connection
        If con.State = ConnectionState.Closed = True Then
            con.Open()
        End If
        cmd.CommandText = "SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED UPDATE    tbKarpin SET              dteFisTarihi = '" & dteFisTarihi & "', sSaticiAciklama = '" & sSaticiAciklama & "', sSatici = '" & sSatici & "', sDepo = '" & sDepo & "' , nKmBaslangic = " & nKmBaslangic & ", nKmBitis = " & nKmBitis & ", nKmFark = " & nKmFark & ", sAciklama1 = '" & sAciklama1 & "', sAciklama2 = '" & sAciklama2 & "', sAciklama3 = '" & sAciklama3 & "', sAciklama4 = '" & sAciklama4 & "', sAciklama5 = '" & sAciklama5 & "', dteKayitTarihi = '" & dteKayitTarihi & "' Where nKarpinID = " & nKarpinID & ""
        cmd.ExecuteNonQuery()
        con.Close()
    End Sub
    Private Sub karpin_sil_aktar(ByVal nKarpinID As Integer)
        Dim con As New OleDb.OleDbConnection
        Dim cmd As New OleDb.OleDbCommand
        cmd.Connection = con
        con.ConnectionString = Connection
        If con.State = ConnectionState.Closed = True Then
            con.Open()
        End If
        cmd.CommandText = "DELETE FROM tbKarpinTahsilat WHERE nKarpinID = " & nKarpinID & ""
        cmd.ExecuteNonQuery()
        cmd.CommandText = "DELETE FROM tbKarpinSevkiyat WHERE nKarpinID = " & nKarpinID & ""
        cmd.ExecuteNonQuery()
        cmd.CommandText = "DELETE FROM tbKarpinParaTeslimat WHERE nKarpinID = " & nKarpinID & ""
        cmd.ExecuteNonQuery()
        cmd.CommandText = "DELETE FROM tbKarpinEmanet WHERE nKarpinID = " & nKarpinID & ""
        cmd.ExecuteNonQuery()
        cmd.CommandText = "DELETE FROM tbKarpin WHERE nKarpinID = " & nKarpinID & ""
        cmd.ExecuteNonQuery()
        con.Close()
    End Sub
    Private Sub sil()
        If XtraMessageBox.Show(Sorgu_sDil("Satýrý Silmek Ýstediðinize Emin misiniz...?", sDil), Sorgu_sDil("Dikkat", sDil), MessageBoxButtons.YesNo, MessageBoxIcon.Question) = MsgBoxResult.Yes Then
            Dim dr As DataRow
            dr = GridView1.GetDataRow(GridView1.FocusedRowHandle)
            If dr("nKarpinID").ToString <> "" Then
                karpin_sil_aktar(dr("nKarpinID"))
            End If
            'DataTable1.Rows.RemoveAt(GridView1.FocusedRowHandle - 1)
            Dim satir = GridView1.FocusedRowHandle
            If GridView1.RowCount > 0 Then
                GridView1.ClearSelection()
                GridView1.SelectRow(satir)
                PanelControl3.Focus()
                GridControl1.Focus()
            End If
            satir = Nothing
        End If
    End Sub
    Private Sub ara()
        Label2.Text = Sorgu_sDil("Lütfen Bekleyiniz...", sDil)
        Label2.Refresh()
        Cursor.Current = Cursors.WaitCursor
        Cursor.Show()
        dataload(txt_dteFisTarihi1.EditValue, txt_dteFisTarihi2.EditValue, txt_lFisNo1.EditValue, txt_lFisNo2.EditValue, txt_lNetTutar1.EditValue, txt_lNetTutar2.EditValue, sec_sDepo.EditValue, sec_sSatici.EditValue)
        Label2.Text = Sorgu_sDil("Tamamlandý...", sDil)
        Cursor.Current = Cursors.Default
        Cursor.Hide()
    End Sub
    Private Sub SimpleButton3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SimpleButton3.Click
        ara()
    End Sub
    Private Sub SimpleButton4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SimpleButton4.Click
        sil()
    End Sub
    Private Sub btnSevkiyat_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnSevkiyat.ItemClick
        tbKarpin_Sevkiyat()
    End Sub
    Private Sub btnTahsilat_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnTahsilat.ItemClick
        tbKarpin_Tahsilat()
    End Sub
    Private Sub btnVeresiye_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnVeresiye.ItemClick
        tbKarpin_Veresiye()
    End Sub
    Private Sub btnPesin_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnPesin.ItemClick
        tbKarpin_Pesin()
    End Sub
    Private Sub btnParaTeslimat_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnParaTeslimat.ItemClick
        tbKarpin_ParaTeslimat()
    End Sub
    Private Sub btnRut_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnRut.ItemClick
        tbKarpin_Rut()
    End Sub
    Private Sub btnEmanetGiris_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnEmanetGiris.ItemClick
        tbKarpin_Emanet_Giris()
    End Sub
    Private Sub btnEmanetCikis_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnEmanetCikis.ItemClick
        tbKarpin_Emanet_Cikis()
    End Sub
    Private Sub btnMasraf_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnMasraf.ItemClick
        tbKarpin_Masraf()
    End Sub
    Private Sub GridView1_CustomDrawRowIndicator(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Grid.RowIndicatorCustomDrawEventArgs) Handles GridView1.CustomDrawRowIndicator
        If e.RowHandle >= 0 Then
            e.Info.DisplayText = e.RowHandle + 1
        Else
            e.Info.DisplayText = ""
        End If
    End Sub
    Private Sub GridView1_SelectionChanged(ByVal sender As Object, ByVal e As DevExpress.Data.SelectionChangedEventArgs) Handles GridView1.SelectionChanged
        If GridView1.SelectedRowsCount > 1 Then
            Label2.Text = Sorgu_sDil("Kayýt Sayýsý :", sDil) & GridView1.RowCount & " / " & Sorgu_sDil("Satýr :", sDil) & GridView1.FocusedRowHandle + 1 & " / " & Sorgu_sDil("Seçili :", sDil) & GridView1.SelectedRowsCount
        ElseIf GridView1.SelectedRowsCount = 1 Then
            Label2.Text = Sorgu_sDil("Kayýt Sayýsý :", sDil) & GridView1.RowCount & " / " & Sorgu_sDil("Satýr :", sDil) & GridView1.FocusedRowHandle + 1
        Else
            Label2.Text = ""
        End If
        Try
            If GridView1.RowCount > 0 Then
                Dim dr As DataRow
                dr = GridView1.GetDataRow(GridView1.FocusedRowHandle)
                lbl_istihbarat.Text = dr("sAciklama1").ToString & vbCrLf
                lbl_istihbarat.Text += dr("sAciklama2").ToString & vbCrLf
                lbl_istihbarat.Text += dr("sAciklama3").ToString & vbCrLf
                lbl_istihbarat.Text += dr("sAciklama4").ToString & vbCrLf
                lbl_istihbarat.Text += dr("sAciklama5").ToString & vbCrLf
                dr = Nothing
            End If
        Catch ex As Exception
        End Try
    End Sub
    Private Sub SimpleButton6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SimpleButton6.Click
        rpt_karpin()
    End Sub
    Private Sub SimpleButton7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SimpleButton7.Click
        rpt_karpin_DUZELT()
    End Sub
    Private Sub MenuItem21_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem21.Click
        txt_dteFisTarihi1.Focus()
        txt_dteFisTarihi1.SelectAll()
    End Sub
    Private Sub MenuItem23_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem23.Click
        Karpin_yeni()
    End Sub
    Private Sub MenuItem24_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem24.Click
        ara()
    End Sub
    Private Sub MenuItem13_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem13.Click
        sil()
    End Sub
    Private Sub MenuItem19_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem19.Click
        tbKarpin_Sevkiyat()
    End Sub
    Private Sub MenuItem16_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem16.Click
        tbKarpin_Emanet_Giris()
    End Sub
    Private Sub MenuItem17_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem17.Click
        tbKarpin_Emanet_Cikis()
    End Sub
    Private Sub MenuItem22_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem22.Click
        tbKarpin_Tahsilat()
    End Sub
    Private Sub MenuItem28_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem28.Click
        tbKarpin_Veresiye()
    End Sub
    Private Sub MenuItem29_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem29.Click
        tbKarpin_Pesin()
    End Sub
    Private Sub MenuItem30_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem30.Click
        tbKarpin_ParaTeslimat()
    End Sub
    Private Sub MenuItem31_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem31.Click
        tbKarpin_Rut()
    End Sub
    Private Sub MenuItem32_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem32.Click
        tbKarpin_Masraf()
    End Sub
    Private Sub MenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem1.Click
        GridView1.ColumnsCustomization()
    End Sub
    Private Sub MenuItem3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem3.Click
        gorunum_kaydet()
    End Sub
    Private Sub MenuItem4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem4.Click
        printlink1.CreateDocument(ps)
        ps.PreviewRibbonFormEx.Show()
    End Sub
    Private Sub MenuItem26_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem26.Click
        If XtraMessageBox.Show(Sorgu_sDil("Sonuçlarý Excel Dosyasý Oluþturmak Ýstediðinize Emin misiniz...?", sDil), Sorgu_sDil("Dikkat", sDil), MessageBoxButtons.YesNo, MessageBoxIcon.Question) = MsgBoxResult.Yes Then
            SaveFileDialog1.Filter = "Excel Dosyalarý(*.xls) |*.xls"
            SaveFileDialog1.InitialDirectory = "c:\"
            SaveFileDialog1.FileName = "Karpin.xls"
            If SaveFileDialog1.ShowDialog = Windows.Forms.DialogResult.OK Then
                GridView1.ExportToXls(SaveFileDialog1.FileName.ToString)
            End If
        End If
    End Sub
    Private Sub MenuItem27_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles MenuItem27.Click
        If XtraMessageBox.Show(Sorgu_sDil("Sonuçlarý Text Dosyasý Oluþturmak Ýstediðinize Emin misiniz...?", sDil), Sorgu_sDil("Dikkat", sDil), MessageBoxButtons.YesNo, MessageBoxIcon.Question) = MsgBoxResult.Yes Then
            SaveFileDialog1.Filter = "Text Dosyalarý(*.txt) |*.txt"
            SaveFileDialog1.InitialDirectory = "c:\"
            SaveFileDialog1.FileName = "Karpin.txt"
            If SaveFileDialog1.ShowDialog = Windows.Forms.DialogResult.OK Then
                GridView1.ExportToXls(SaveFileDialog1.FileName.ToString)
            End If
        End If
    End Sub
    Private Sub MenuItem14_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem14.Click
        If MenuItem14.Checked = False Then
            GridView1.OptionsView.ShowAutoFilterRow = True
            GridView1.OptionsView.ShowFilterPanelMode = DevExpress.XtraGrid.Views.Base.ShowFilterPanelMode.Default
            GridView1.OptionsCustomization.AllowFilter = True
            MenuItem14.Checked = True
        ElseIf MenuItem14.Checked = False Then
            GridView1.OptionsView.ShowAutoFilterRow = False
            GridView1.OptionsView.ShowFilterPanelMode = DevExpress.XtraGrid.Views.Base.ShowFilterPanelMode.Never
            GridView1.OptionsCustomization.AllowFilter = False
            MenuItem14.Checked = False
        End If
    End Sub
    Private Sub MenuItem5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem5.Click
        If MenuItem5.Checked = False Then
            GridView1.OptionsView.ShowFilterPanelMode = DevExpress.XtraGrid.Views.Base.ShowFilterPanelMode.Default
            GridView1.OptionsCustomization.AllowFilter = True
            MenuItem5.Checked = True
        ElseIf MenuItem5.Checked = True Then
            GridView1.OptionsView.ShowFilterPanelMode = DevExpress.XtraGrid.Views.Base.ShowFilterPanelMode.Never
            GridView1.OptionsCustomization.AllowFilter = False
            MenuItem5.Checked = False
        End If
    End Sub
    Private Sub MenuItem6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem6.Click
        If MenuItem6.Checked = False Then
            GridView1.OptionsView.ShowGroupPanel = True
            GridView1.OptionsCustomization.AllowGroup = True
            MenuItem6.Checked = True
        ElseIf MenuItem6.Checked = True Then
            GridView1.OptionsView.ShowGroupPanel = False
            GridView1.OptionsCustomization.AllowGroup = False
            MenuItem6.Checked = False
        End If
    End Sub
    Private Sub MenuItem7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem7.Click
        GridView1.ExpandAllGroups()
    End Sub
    Private Sub MenuItem8_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles MenuItem8.Click
        GridView1.CollapseAllGroups()
    End Sub
    Private Sub MenuItem18_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem18.Click
        Karpin_duzelt()
    End Sub
    Private Sub GridControl1_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles GridControl1.DoubleClick
        Karpin_duzelt()
    End Sub
    Private Sub BarButtonItem1_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem1.ItemClick
        tbKarpin_Aktarim()
    End Sub
    Private Sub SimpleButton8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SimpleButton8.Click
        GroupControl3.Visible = False
    End Sub
    Private Sub MenuItem9_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem9.Click
        If GridView1.RowCount > 0 Then
            DateEdit1.EditValue = txt_dteFisTarihi1.EditValue
            DateEdit2.EditValue = txt_dteFisTarihi2.EditValue
            GroupControl3.Visible = True
            DateEdit1.Focus()
            DateEdit1.SelectAll()
        End If
    End Sub
    Private Sub SimpleButton9_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SimpleButton9.Click
        If GridView1.RowCount > 0 Then
            Dim dr As DataRow = GridView1.GetDataRow(GridView1.FocusedRowHandle)
            Dim dr1 As DataRow
            If XtraMessageBox.Show(DateEdit1.EditValue & " ve " & DateEdit2.EditValue & " Tarihleri arasýndaki " & dr("sSatici") & " Satýcýsýna Ait Verileri Doldurmak Ýstediðinize Emin misiniz..?", Sorgu_sDil("Dikkat", sDil), MessageBoxButtons.YesNo, MessageBoxIcon.Question) = MsgBoxResult.Yes Then
                Dim ds_satislar As DataSet = sorgu(sorgu_query("SELECT tbFirma.nFirmaID, tbFirma.sKodu, tbFirma.sAciklama, tbStokFisiMaster.bPesinmi, SUM(tbStokFisiDetayi.lCikisMiktar1) AS lMiktar, SUM(CAST(tbStokFisiDetayi.lCikisTutar * (100 + tbStokFisiDetayi.nKdvOrani) / 100 AS FLOAT)) AS lTutar FROM tbStokFisiMaster INNER JOIN tbStokFisiDetayi ON tbStokFisiMaster.nStokFisiID = tbStokFisiDetayi.nStokFisiID INNER JOIN tbFirma ON tbStokFisiMaster.nFirmaID = tbFirma.nFirmaID WHERE (tbStokFisiDetayi.sFisTipi = 'FS') AND (tbStokFisiDetayi.dteFisTarihi BETWEEN '" & DateEdit1.EditValue & "' AND '" & DateEdit2.EditValue & "') AND (tbStokFisiDetayi.sSaticiRumuzu = '" & dr("sSatici") & "') GROUP BY tbFirma.nFirmaID, tbFirma.sKodu, tbFirma.sAciklama, tbStokFisiMaster.bPesinmi ORDER BY tbStokFisiMaster.bPesinmi"))
                Dim ds_tahsilatlar As DataSet = sorgu(sorgu_query("SELECT tbFirma.nFirmaID, tbFirma.sKodu, tbFirma.sAciklama, tbFirmaBordroDetay.nKayitID, tbFirmaBordroDetay.nBordroID,tbFirmaBordroMaster.sFisTipi, tbFirmaBordroMaster.nGirisCikis, COUNT(tbFirmaBordroDetay.nKayitID) AS lMiktar, SUM(tbFirmaBordroDetay.lAlacakTutar) AS lTutar,tbFirmaBordroDetay.sCariIslem FROM tbFirmaBordroMaster INNER JOIN tbFirmaBordroDetay ON tbFirmaBordroMaster.nBordroID = tbFirmaBordroDetay.nBordroID INNER JOIN tbFirma ON tbFirmaBordroDetay.nFirmaID = tbFirma.nFirmaID WHERE (tbFirmaBordroMaster.dteBordroTarihi BETWEEN '" & DateEdit1.EditValue & "' AND '" & DateEdit2.EditValue & "') AND (tbFirmaBordroMaster.sSaticiRumuzu = '" & dr("sSatici") & "') AND (tbFirmaBordroMaster.sFisTipi IN ('TCG', 'CG')) GROUP BY tbFirma.nFirmaID, tbFirma.sKodu, tbFirma.sAciklama, tbFirmaBordroDetay.nKayitID, tbFirmaBordroDetay.nBordroID,tbFirmaBordroMaster.sFisTipi, tbFirmaBordroMaster.nGirisCikis,tbFirmaBordroDetay.sCariIslem ORDER BY tbFirmaBordroMaster.sFisTipi, tbFirmaBordroMaster.nGirisCikis,tbFirmaBordroDetay.sCariIslem"))
                Dim ds_masraflar As DataSet = sorgu(sorgu_query("SELECT tbFirma.nFirmaID, tbFirma.sKodu, tbFirma.sAciklama,tbFirmaBordroDetay.sAciklama as sNot, tbFirmaBordroDetay.nKayitID, tbFirmaBordroDetay.nBordroID,tbFirmaBordroMaster.sFisTipi, tbFirmaBordroMaster.nGirisCikis, COUNT(tbFirmaBordroDetay.nKayitID) AS lMiktar, SUM(tbFirmaBordroDetay.lBorcTutar) AS lTutar,tbFirmaBordroDetay.sCariIslem FROM tbFirmaBordroMaster INNER JOIN tbFirmaBordroDetay ON tbFirmaBordroMaster.nBordroID = tbFirmaBordroDetay.nBordroID INNER JOIN tbFirma ON tbFirmaBordroDetay.nFirmaID = tbFirma.nFirmaID WHERE (tbFirmaBordroMaster.dteBordroTarihi BETWEEN '" & DateEdit1.EditValue & "' AND '" & DateEdit2.EditValue & "') AND (tbFirmaBordroMaster.sSaticiRumuzu = '" & dr("sSatici") & "') AND (tbFirmaBordroMaster.sFisTipi IN ('TCC', 'CC')) and tbFirma.sKodu like '800%' GROUP BY tbFirma.nFirmaID, tbFirma.sKodu, tbFirma.sAciklama, tbFirmaBordroDetay.nKayitID, tbFirmaBordroDetay.nBordroID,tbFirmaBordroMaster.sFisTipi, tbFirmaBordroMaster.nGirisCikis,tbFirmaBordroDetay.sCariIslem,tbFirmaBordroDetay.sAciklama ORDER BY tbFirmaBordroMaster.sFisTipi, tbFirmaBordroMaster.nGirisCikis,tbFirmaBordroDetay.sCariIslem"))
                Dim ds_sevkiyatlar As DataSet = sorgu(sorgu_query("SET DATEFORMAT DMY SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT nStokID, sKodu, sModel, sAciklama, sRenk,sRenkAdi, sBeden, sBirimCinsi1,nBirimCarpan,SUM(lMiktar) lMiktar, SUM(lIade) lIade, SUM(lMiktar - abs(lIade)) AS lSatis, SUM(lTutar) lTutar, lFiyat = Case When SUM(lMiktar - abs(lIade)) <> 0  Then sum(lTutar)/ SUM(lMiktar - abs(lIade)) Else 0 END,SUM(lIskontoTutari) lIskontoTutari, SUM(lKdvTutari) lKdvTutari,nPrim= CASE WHEN SUM(lPrimTutari) <> 0 THEN (SUM(lPrimTutari) / SUM(lBrutTutar)) ELSE 0 END,SUM(lPrimTutari) lPrimTutari, SUM(lDahilBrutTutar) as lDahilBrutTutar,lDahilBrutFiyat = Case When SUM(lMiktar - abs(lIade)) <> 0  Then sum(lDahilBrutTutar)/ SUM(lMiktar - abs(lIade)) Else 0 END, lFiyat1, lFiyat2, lFiyat3, lMaliyet, (SUM(lMiktar) - SUM(lIade)) * lMaliyet AS lMaliyetTutar, SUM((lTutar) - ((lMiktar - (abs(lIade))) * lMaliyet)) AS lKar,CAST(0 AS MONEY) as nOran FROM (SELECT tbStok.nStokID, tbStok.sKodu, tbStok.sModel, tbStok.sAciklama, tbStok.sRenk, tbRenk.sRenkAdi, tbStok.sBeden, tbStok.sBirimCinsi1, ISNULL ((SELECT ISNULL(lOran, 0) FROM tbStokBirimCevrimi WHERE nStokID = tbStok.nStokID AND sBirimCinsi = tbStok.sBirimCinsi2), 1) AS nBirimCarpan, tbStokFisiDetayi.nGirisCikis, lMiktar = CASE WHEN tbStokFisiDetayi.nGirisCikis = 3 THEN tbStokFisiDetayi.lCikisMiktar1 ELSE tbStokFisiDetayi.lGirisMiktar1 END, lIade = CASE WHEN tbStokFisiDetayi.nGirisCikis = 4 THEN abs(tbStokFisiDetayi.lCikisMiktar1) ELSE abs(tbStokFisiDetayi.lGirisMiktar1) END, lTutar = CASE WHEN tbStokFisiDetayi.nGirisCikis = 3 OR tbStokFisiDetayi.nGirisCikis = 4 THEN CAST(tbStokFisiDetayi.lCikisTutar * (100 + tbStokFisiDetayi.nKdvOrani) / 100 AS FLOAT) ELSE CAST(tbStokFisiDetayi.lGirisTutar * (100 + tbStokFisiDetayi.nKdvOrani) / 100 AS FLOAT) END, tbStokFisiDetayi.lIskontoTutari, ISNULL((ROUND((tbStokFisiDetayi.lBrutTutar - tbStokFisiDetayi.lIskontoTutari) * (tbStokFisiDetayi.nKdvOrani / 100), 2)), 0) AS lKdvTutari,ISNULL((tbStokFisiDetayi.lBrutTutar - tbStokFisiDetayi.lIskontoTutari) * (tbStokFisiDetayi.nPrim / 100), 0) AS lPrimTutari, ISNULL(ROUND((tbStokFisiDetayi.lBrutTutar - tbStokFisiDetayi.lIskontoTutari), 2), 0) AS lBrutTutar,CAST(tbStokFisiDetayi.lBrutTutar AS FLOAT) AS lDahilBrutTutar, ISNULL ((SELECT isnull(lfiyat, 0) FROM tbstokfiyati WHERE nStokId = tbStok.NstokId AND sFiyatTipi = '" & sFiyat1 & "'), 0) AS lFiyat1, ISNULL ((SELECT isnull(lfiyat, 0) FROM tbstokfiyati WHERE nStokId = tbStok.NstokId AND sFiyatTipi = '" & sFiyat2 & "'), 0) AS lFiyat2, ISNULL ((SELECT isnull(lfiyat, 0) FROM tbstokfiyati WHERE nStokId = tbStok.NstokId AND sFiyatTipi = '" & sFiyat3 & "'), 0) AS lFiyat3, ISNULL ((SELECT isnull(lfiyat, 0) FROM tbstokfiyati WHERE nStokId = tbStok.NstokId AND sFiyatTipi = '" & sFiyatM & "'), 0) AS lMaliyet, tbStokFisiDetayi.lMaliyetFiyat FROM tbRenk INNER JOIN tbStok ON tbRenk.sRenk = tbStok.sRenk INNER JOIN tbStokFisiDetayi ON tbStok.nStokID = tbStokFisiDetayi.nStokID INNER JOIN tbStokFisiMaster ON tbStokFisiDetayi.nStokFisiID = tbStokFisiMaster.nStokFisiID INNER JOIN tbFirma ON tbStokFisiMaster.nFirmaID = tbFirma.nFirmaID  Where  (tbStokFisiMaster.sFisTipi = 'FS ') AND tbStokFisiMaster.dteFisTarihi between '" & DateEdit1.EditValue & "' and '" & DateEdit2.EditValue & "'  and tbStokFisiMaster.lFisNo between '1' and '999999999' and tbStokFisiMaster.lNetTutar between '-999999999' and '999999999' And tbStokFisiDetayi.sSaticiRumuzu = '" & dr("sSatici") & "' ) tbFisDetay GROUP BY nStokID, sKodu, sModel, sAciklama, sRenk,sRenkAdi, sBeden,sBirimCinsi1,nBirimCarpan,  lFiyat1, lFiyat2, lFiyat3, lMaliyet, lMaliyetFiyat ORDER BY sKodu"))
                sorgula_nStokID("Delete from tbKarpinTahsilat Where nKarpinID = " & dr("nKarpinID") & "")
                sorgula_nStokID("Delete from tbKarpinSevkiyat Where nKarpinID = " & dr("nKarpinID") & "")
                For Each dr1 In ds_satislar.Tables(0).Rows
                    If dr1("bPesinmi") = False Then
                        tbKarpin_Tahsilat_kaydet_yeni(0, dr("nKarpinID"), dr("dteFisTarihi"), dr("sSatici").ToString, dr("sDepo").ToString, 2, dr1("nFirmaID"), dr1("sKodu").ToString, dr1("sAciklama").ToString, dr1("sAciklama").ToString, FormatNumber(dr1("lTutar"), 2), "N", Now, 0)
                    ElseIf dr1("bPesinmi") = True Then
                        tbKarpin_Tahsilat_kaydet_yeni(0, dr("nKarpinID"), dr("dteFisTarihi"), dr("sSatici").ToString, dr("sDepo").ToString, 3, dr1("nFirmaID"), dr1("sKodu").ToString, dr1("sAciklama").ToString, dr1("sAciklama").ToString, FormatNumber(dr1("lTutar"), 2), "N", Now, 0)
                    End If
                    If sorgula_nStokID("SELECT     COUNT(*) AS nKayit FROM         tbKarpinTahsilat WHERE     (sFisTipi = 4) AND (nFirmaID = " & dr1("nFirmaID") & ")") = 0 Then
                        tbKarpin_Tahsilat_kaydet_yeni(0, dr("nKarpinID"), dr("dteFisTarihi"), dr("sSatici").ToString, dr("sDepo").ToString, 4, dr1("nFirmaID"), dr1("sKodu").ToString, dr1("sAciklama").ToString, dr1("sAciklama").ToString, FormatNumber(dr1("lTutar"), 2), "N", Now, 0)
                    End If
                Next
                For Each dr1 In ds_tahsilatlar.Tables(0).Rows
                    tbKarpin_Tahsilat_kaydet_yeni(0, dr("nKarpinID"), dr("dteFisTarihi"), dr("sSatici").ToString, dr("sDepo").ToString, 1, dr1("nFirmaID"), dr1("sKodu").ToString, dr1("sAciklama").ToString, dr1("sAciklama").ToString, FormatNumber(dr1("lTutar"), 2), dr1("sCariIslem"), Now, dr1("nKayitID"))
                    If sorgula_nStokID("SELECT     COUNT(*) AS nKayit FROM         tbKarpinTahsilat WHERE     (sFisTipi = 4) AND (nFirmaID = " & dr1("nFirmaID") & ")") = 0 Then
                        tbKarpin_Tahsilat_kaydet_yeni(0, dr("nKarpinID"), dr("dteFisTarihi"), dr("sSatici").ToString, dr("sDepo").ToString, 4, dr1("nFirmaID"), dr1("sKodu").ToString, dr1("sAciklama").ToString, dr1("sAciklama").ToString, FormatNumber(dr1("lTutar"), 2), dr1("sCariIslem"), Now, dr1("nKayitID"))
                    End If
                Next
                For Each dr1 In ds_masraflar.Tables(0).Rows
                    tbKarpin_Tahsilat_kaydet_yeni(0, dr("nKarpinID"), dr("dteFisTarihi"), dr("sSatici").ToString, dr("sDepo").ToString, 5, dr1("nFirmaID"), dr1("sKodu").ToString, dr1("sAciklama").ToString, dr1("sNot").ToString, -FormatNumber(dr1("lTutar"), 2), dr1("sCariIslem"), Now, dr1("nKayitID"))
                Next
                Dim lIskontoTutari As Decimal = 0
                Dim lKdvTutari As Decimal = 0
                Dim lY1 As Decimal = 0
                Dim lY2 As Decimal = 0
                Dim lY3 As Decimal = 0
                Dim lMiktar As Decimal = 0
                Dim lIade As Decimal = 0
                Dim lSatis As Decimal = 0
                Dim lFiyat As Decimal = 0
                Dim lTutar As Decimal = 0
                Dim lIskonto As Decimal = 0
                For Each dr1 In ds_sevkiyatlar.Tables(0).Rows
                    lY1 = dr1("lMiktar")
                    lY2 = 0
                    lY3 = 0
                    lMiktar = dr1("lMiktar")
                    lIade = dr1("lIade")
                    lSatis = dr1("lSatis")
                    Try
                        lFiyat = CType(dr1("lDahilBrutFiyat"), Decimal)
                    Catch ex As Exception
                        lFiyat = 0
                    End Try
                    lMiktar = lY1 + lY2 + lY3
                    lMiktar = lMiktar - lIade
                    lTutar = lFiyat * lSatis
                    'If dr("sStokKodu").ToString.Substring(0, 2) = "99" Then
                    '    dr("lFiyat") = 0
                    '    dr("lTutar") = 0
                    'End If
                    lIskonto = lIskontoTutari
                    lKdvTutari += dr1("lKdvTutari")
                    lIskontoTutari += dr1("lIskontoTutari")
                    tbKarpin_Sevkiyat_kaydet_yeni(0, dr("nKarpinID"), dr("dteFisTarihi"), dr("sSatici"), dr("sDepo"), dr1("nStokID"), dr1("sKodu"), dr1("sAciklama"), lY1, lY2, lY3, lMiktar, lIade, lSatis, lFiyat, lTutar, lIskonto, lKdvTutari, lTutar)
                Next
                sorgula_nStokID("update  tbKarpinSevkiyat set lKdvTutari = " & lKdvTutari & " ,lIskonto = " & lIskontoTutari & " Where nKarpinID = " & dr("nKarpinID") & "")
            End If
            ara()
            XtraMessageBox.Show(Sorgu_sDil("Ýþlem Baþarýyla Tamamlandý...!", sDil), Sorgu_sDil("sDil", sDil), MessageBoxButtons.OK, MessageBoxIcon.Information)
            GroupControl3.Visible = False
        End If
    End Sub
    Private Function tbKarpin_Tahsilat_kaydet_yeni(ByVal nKayitID As Int64, ByVal nKarpinID As Int64, ByVal dteFisTarihi As DateTime, ByVal sSatici As String, ByVal sDepo As String, ByVal sFisTipi As String, ByVal nFirmaID As Integer, ByVal sFirmaKodu As String, ByVal sFirmaAciklama As String, ByVal sAciklama As String, ByVal lTutar As Decimal, ByVal sOdemeSekli As String, ByVal dteKayitTarihi As DateTime, ByVal nBordroKayitID As Int64) As Int64
        Dim con As New OleDb.OleDbConnection
        Dim cmd As New OleDb.OleDbCommand
        Dim kayitno As Integer
        con.ConnectionString = Connection
        con.Open()
        cmd.Connection = con
        cmd.CommandText = "SET DATEFORMAT DMY INSERT INTO tbKarpinTahsilat (nKarpinID, dteFisTarihi, sSatici, sDepo, sFisTipi, nFirmaID, sFirmaKodu, sFirmaAciklama, sAciklama, lTutar, sOdemeSekli, dteKayitTarihi,nBordroKayitID) VALUES     ( " & nKarpinID & ", '" & dteFisTarihi & "', '" & sSatici & "', '" & sDepo & "', '" & sFisTipi & "', " & nFirmaID & ", '" & sFirmaKodu & "', '" & sFirmaAciklama & "', N'" & sAciklama & "', " & lTutar & ", '" & sOdemeSekli & "', '" & dteKayitTarihi & "'," & nBordroKayitID & ")"
        cmd.ExecuteNonQuery()
        cmd.CommandText = "SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT @@identity"
        kayitno = cmd.ExecuteScalar
        con.Close()
        Return kayitno
    End Function
    Private Function tbKarpin_Sevkiyat_kaydet_yeni(ByVal nKayitID As Int64, ByVal nKarpinID As Int64, ByVal dteFisTarihi As DateTime, ByVal sSatici As String, ByVal sDepo As String, ByVal nStokID As Integer, ByVal sStokKodu As String, ByVal sStokAciklama As String, ByVal lY1 As Decimal, ByVal lY2 As Decimal, ByVal lY3 As Decimal, ByVal lMiktar As Decimal, ByVal lIade As Decimal, ByVal lSatis As Decimal, ByVal lFiyat As Decimal, ByVal lTutar As Decimal, ByVal lIskonto As Decimal, ByVal lKdvTutari As Decimal, ByVal lNetTutar As Decimal) As Int64
        Dim con As New OleDb.OleDbConnection
        Dim cmd As New OleDb.OleDbCommand
        Dim kayitno As Integer
        con.ConnectionString = Connection
        con.Open()
        cmd.Connection = con
        cmd.CommandText = "SET DATEFORMAT DMY SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED INSERT INTO tbKarpinSevkiyat (nKarpinID, dteFisTarihi, sSatici, sDepo, nStokID, sStokKodu, sStokAciklama, lY1, lY2, lY3, lMiktar, lIade, lSatis, lFiyat, lTutar, lIskonto,lKdvTutari,lNetTutar) VALUES     (" & nKarpinID & ", '" & dteFisTarihi & "', '" & sSatici & "', '" & sDepo & "', " & nStokID & ", '" & sStokKodu & "', '" & sStokAciklama & "', " & lY1 & ", " & lY2 & ", " & lY3 & ", " & lMiktar & ", " & lIade & ", " & lSatis & ", " & lFiyat & ", " & lTutar & ", " & lIskonto & "," & lKdvTutari & "," & lNetTutar & " )"
        cmd.ExecuteNonQuery()
        cmd.CommandText = "SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT @@identity"
        kayitno = cmd.ExecuteScalar
        con.Close()
        Return kayitno
    End Function
    Private Sub MenuItem12_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem12.Click
        If XtraMessageBox.Show("Girilmiþ Tahsilat ve Gider Verilerini Sisteme Aktarmak Ýstediðinize Emin misiniz...?", Sorgu_sDil("Dikkat", sDil), MessageBoxButtons.YesNo, MessageBoxIcon.Question) = MsgBoxResult.Yes Then
            aktar_tahsilat()
            aktar_masraf()
        End If
    End Sub
    Private Sub aktar_tahsilat()
        If GridView1.RowCount > 0 Then
            Dim ds_tbKarpinTahsilat As DataSet
            Dim dr As DataRow = GridView1.GetDataRow(GridView1.FocusedRowHandle)
            Dim dr1 As DataRow
            'ds_tbKarpinTahsilat = sorgu("SET DATEFORMAT DMY SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT     * FROM         tbKarpinTahsilat WHERE     (sFisTipi = 1) AND (nKarpinID = " & dr("nKarpinID") & ") ORDER BY sOdemeSekli")
            'veresiyeden tahsilat + peþin tahsilatlar
            ds_tbKarpinTahsilat = sorgu("SET DATEFORMAT DMY SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT     tbKarpinTahsilat.*, tbFirma.nHesapID AS nHesapID FROM         tbKarpinTahsilat INNER JOIN                       tbFirma ON tbKarpinTahsilat.nFirmaID = tbFirma.nFirmaID WHERE     (tbKarpinTahsilat.sFisTipi IN (1,3)) AND (tbKarpinTahsilat.nKarpinID = " & dr("nKarpinID") & ") ORDER BY tbKarpinTahsilat.sOdemeSekli")
            If ds_tbKarpinTahsilat.Tables(0).Rows.Count > 0 Then
                Dim nBordroID As Int64 = 0
                Dim sFisTipi As String = "TCG"
                Dim sMuhFisTipi As Integer = 3
                Dim nGirisCikis As Integer = 1
                Dim nFirmaID As Int64 = -1
                Dim lBordroNo As Int64 = sorgu_lFisNo(sFisTipi, nGirisCikis)
                Dim lFisNo As Int64 = sorgu_lMuhasebeFisNo()
                Dim dteBordroTarihi As DateTime = dr("dteFisTarihi")
                Dim sSaticiRumuzu As String = dr("sSatici")
                Dim nSayi As Integer = 0
                For Each dr1 In ds_tbKarpinTahsilat.Tables(0).Rows
                    If dr1("nBordroKayitID") <> 0 Then
                        nBordroID = sorgula_Decimal("SELECT tbFirmaBordroDetay.nBordroID FROM tbFirmaBordroDetay INNER JOIN tbFirmaBordroMaster ON tbFirmaBordroDetay.nBordroID = tbFirmaBordroMaster.nBordroID WHERE (tbFirmaBordroMaster.sFisTipi LIKE 'T%') AND (tbFirmaBordroDetay.nKayitID = " & dr1("nBordroKayitID") & ")")
                    Else
                        nSayi += 1
                    End If
                Next
                If nSayi > 0 Then
                    If nBordroID = 0 Then
                        nBordroID = tbFirmaBordroMaster_kaydet_yeni(dteBordroTarihi, lBordroNo, sFisTipi, nGirisCikis, sSaticiRumuzu, nFirmaID, dr("sAciklama1"), "KarpinEntegre", "", "", "", kullaniciadi, Now, 0, sSubeMagaza, sHareketTipi)
                    End If
                    For Each dr1 In ds_tbKarpinTahsilat.Tables(0).Rows
                        If dr1("nBordroKayitID") = 0 And Trim(dr1("sOdemeSekli")) <> "KK" Then
                            Dim nCariHareketID = sorgu_nCariHareketID()
                            Dim nHareketID As Int64 = nCariHareketID
                            Dim nKasaIslemID As String = ""
                            Dim nBordroSatirID As String = ""
                            Dim lBorcTutar As Decimal = 0
                            Dim lAlacakTutar As Decimal = dr1("lTutar")
                            Dim sDovizCinsi1 As String = ""
                            Dim lDovizMiktari1 As Decimal = 0
                            Dim lDovizKuru1 As Decimal = 0
                            Dim sDovizCinsi2 As String = ""
                            Dim lDovizMiktari2 As Decimal = 0
                            Dim lDovizKuru2 As Decimal = 0
                            Dim sEvrakNo As String = lBordroNo
                            Dim sHangiUygulama As String = sFisTipi
                            dr1("nBordroKayitID") = tbFirmaBordroDetay_kaydet_yeni(0, nBordroID, nHareketID, nKasaIslemID, nBordroSatirID, dr1("nFirmaID"), dteBordroTarihi, dteBordroTarihi, dr1("sOdemeSekli"), dr1("sAciklama"), lBorcTutar, lAlacakTutar, sEvrakNo, 0, sHangiUygulama, sHareketTipi, kullaniciadi, dr1("dteKayitTarihi"), sDovizCinsi1, lDovizMiktari1, lDovizKuru1, sDovizCinsi2, lDovizMiktari2, lDovizKuru2, kullaniciadi, Now)
                            nHareketID = tbFirmaHareketi_kaydet_yeni(nHareketID, dr1("nFirmaID"), dteBordroTarihi, dteBordroTarihi, dr1("sOdemeSekli"), dr1("sAciklama"), lBorcTutar, lAlacakTutar, sEvrakNo, 0, sHangiUygulama, sHareketTipi, kullaniciadi, dr1("dteKayitTarihi"), sDovizCinsi1, lDovizMiktari1, lDovizKuru1, sDovizCinsi2, lDovizMiktari2, lDovizKuru2, kullaniciadi, Now)
                            nCariHareketID = nHareketID
                            nCariHareketID_degistir(nCariHareketID)
                            tbKarpin_Tahsilat_kaydet_degistir(dr1("nKayitID"), dr1("nKarpinID"), dr("dteFisTarihi"), dr("sSatici"), dr("sDepo"), dr1("sFisTipi"), dr1("nFirmaID"), "", "", dr1("sAciklama").ToString, dr1("lTutar"), dr1("sOdemeSekli").ToString, dr1("dteKayitTarihi"), dr1("nBordroKayitID"))
                        ElseIf dr1("nBordroKayitID") = 0 And Trim(dr1("sOdemeSekli")) = "KK" Then
                            lFisNo = sorgu_lMuhasebeFisNo()
                            Dim nFisSiraID As Int64 = sorgu_nFisSiraID()
                            Dim nCariHareketID = sorgu_nCariHareketID()
                            Dim nHareketID As Int64 = nCariHareketID
                            Dim nKasaIslemID As String = ""
                            Dim nBordroSatirID As String = ""
                            Dim lBorcTutar As Decimal = 0
                            Dim lAlacakTutar As Decimal = dr1("lTutar")
                            Dim sDovizCinsi1 As String = ""
                            Dim lDovizMiktari1 As Decimal = 0
                            Dim lDovizKuru1 As Decimal = 0
                            Dim sDovizCinsi2 As String = ""
                            Dim lDovizMiktari2 As Decimal = 0
                            Dim lDovizKuru2 As Decimal = 0
                            Dim sEvrakNo As String = lBordroNo
                            Dim sHangiUygulama As String = sFisTipi
                            Dim nAlacakliFirmaID As Int64 = sorgula_nStokID("Select nFirmaID from aEmirOdemeSekliFirma Where sOdemeSekli = '" & dr1("sOdemeSekli") & "' ")
                            Dim nAlacakliHesapID As Int64 = sorgula_nStokID("Select nHesapID from tbFirma Where nFirmaID =" & nAlacakliFirmaID & " ")
                            Dim nVadeGun As Int64 = sorgula_nStokID("Select nVadeGun from tbFirma Where nFirmaID =" & nAlacakliFirmaID & " ")
                            'Borçlu Kaydet
                            nHareketID = tbFirmaHareketi_kaydet_yeni(nHareketID, dr1("nFirmaID"), dteBordroTarihi, DateAdd(DateInterval.Day, nVadeGun, dteBordroTarihi), dr1("sOdemeSekli"), dr1("sAciklama"), lBorcTutar, lAlacakTutar, sEvrakNo, 0, sHangiUygulama, sHareketTipi, kullaniciadi, dr1("dteKayitTarihi"), sDovizCinsi1, lDovizMiktari1, lDovizKuru1, sDovizCinsi2, lDovizMiktari2, lDovizKuru2, kullaniciadi, Now)
                            nCariHareketID = nHareketID
                            nCariHareketID_degistir(nCariHareketID)
                            nFisSiraID = tbMuhasebeFisi_kaydet_yeni(nFisSiraID, dteBordroTarihi, sMuhFisTipi, lFisNo, lFisNo, dr1("nHesapID"), dr1("sAciklama"), 0, 0, lBorcTutar, lAlacakTutar, "", 0, "CHS", sHareketTipi, nCariHareketID, kullaniciadi, dr1("dteKayitTarihi"), sDovizCinsi1, lDovizMiktari1, lDovizKuru1, sDovizCinsi2, lDovizMiktari2, lDovizKuru2, 0, sSubeMagaza, kullaniciadi, Now)
                            nFisSiraID_degistir(nFisSiraID)
                            dr1("nBordroKayitID") = nFisSiraID
                            'Alacaklý Kaydet
                            nCariHareketID = sorgu_nCariHareketID()
                            nHareketID = nCariHareketID
                            nFisSiraID = sorgu_nFisSiraID()
                            lBorcTutar = dr1("lTutar")
                            lAlacakTutar = 0
                            nHareketID = tbFirmaHareketi_kaydet_yeni(nHareketID, nAlacakliFirmaID, dteBordroTarihi, DateAdd(DateInterval.Day, nVadeGun, dteBordroTarihi), dr1("sOdemeSekli"), dr1("sAciklama"), lBorcTutar, lAlacakTutar, sEvrakNo, 0, sHangiUygulama, sHareketTipi, kullaniciadi, dr1("dteKayitTarihi"), sDovizCinsi1, lDovizMiktari1, lDovizKuru1, sDovizCinsi2, lDovizMiktari2, lDovizKuru2, kullaniciadi, Now)
                            nCariHareketID = nHareketID
                            nCariHareketID_degistir(nCariHareketID)
                            nFisSiraID = tbMuhasebeFisi_kaydet_yeni(nFisSiraID, dteBordroTarihi, sMuhFisTipi, lFisNo, lFisNo, nAlacakliHesapID, Microsoft.VisualBasic.Left(Microsoft.VisualBasic.Left(Trim(dr1("sFirmaAciklama")), 45) & "\" & Trim(dr1("sAciklama")), 59), 0, 0, lBorcTutar, lAlacakTutar, "", 0, "CHS", sHareketTipi, nCariHareketID, kullaniciadi, dr1("dteKayitTarihi"), sDovizCinsi1, lDovizMiktari1, lDovizKuru1, sDovizCinsi2, lDovizMiktari2, lDovizKuru2, 0, sSubeMagaza, kullaniciadi, Now)
                            nFisSiraID_degistir(nFisSiraID)
                            'Karpin Düzelt
                            tbKarpin_Tahsilat_kaydet_degistir(dr1("nKayitID"), dr1("nKarpinID"), dr("dteFisTarihi"), dr("sSatici"), dr("sDepo"), dr1("sFisTipi"), dr1("nFirmaID"), "", "", dr1("sAciklama").ToString, dr1("lTutar"), dr1("sOdemeSekli").ToString, dr1("dteKayitTarihi"), dr1("nBordroKayitID"))
                            lMuhasebeFisNo_degistir()
                            Try
                                tbMuhasebeFisi_Aciklamasi_kaydet_yeni(dteBordroTarihi, sMuhFisTipi, lFisNo, "", "KarpinEntegre", "", "", "", 0)
                            Catch ex As Exception
                            End Try
                        End If
                    Next
                    analiz_fis(nBordroID, sFisTipi, nGirisCikis)
                End If
            End If
        End If
    End Sub
    Private Sub aktar_masraf()
        If GridView1.RowCount > 0 Then
            Dim ds_tbKarpinTahsilat As DataSet
            Dim dr As DataRow = GridView1.GetDataRow(GridView1.FocusedRowHandle)
            Dim dr1 As DataRow
            ds_tbKarpinTahsilat = sorgu("SET DATEFORMAT DMY SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT     * FROM         tbKarpinTahsilat WHERE     (sFisTipi = 5) AND (nKarpinID = " & dr("nKarpinID") & ") ORDER BY sOdemeSekli")
            If ds_tbKarpinTahsilat.Tables(0).Rows.Count > 0 Then
                Dim nBordroID As Int64 = 0
                Dim sFisTipi As String = "TCC"
                Dim nGirisCikis As Integer = 3
                Dim nFirmaID As Int64 = -1
                Dim lBordroNo As Int64 = sorgu_lFisNo(sFisTipi, nGirisCikis)
                Dim dteBordroTarihi As DateTime = dr("dteFisTarihi")
                Dim sSaticiRumuzu As String = dr("sSatici")
                Dim nSayi As Integer = 0
                For Each dr1 In ds_tbKarpinTahsilat.Tables(0).Rows
                    If dr1("nBordroKayitID") <> 0 Then
                        nBordroID = sorgula_Decimal("SELECT tbFirmaBordroDetay.nBordroID FROM tbFirmaBordroDetay INNER JOIN tbFirmaBordroMaster ON tbFirmaBordroDetay.nBordroID = tbFirmaBordroMaster.nBordroID WHERE (tbFirmaBordroMaster.sFisTipi LIKE 'T%') AND (tbFirmaBordroDetay.nKayitID = " & dr1("nBordroKayitID") & ")")
                    Else
                        nSayi += 1
                    End If
                Next
                If nSayi > 0 Then
                    If nBordroID = 0 Then
                        nBordroID = tbFirmaBordroMaster_kaydet_yeni(dteBordroTarihi, lBordroNo, sFisTipi, nGirisCikis, sSaticiRumuzu, nFirmaID, dr("sAciklama1"), "KarpinEntegre", "", "", "", kullaniciadi, Now, 0, sSubeMagaza, sHareketTipi)
                    End If
                    For Each dr1 In ds_tbKarpinTahsilat.Tables(0).Rows
                        If dr1("nBordroKayitID") = 0 Then
                            Dim nCariHareketID = sorgu_nCariHareketID()
                            Dim nHareketID As Int64 = nCariHareketID
                            Dim nKasaIslemID As String = ""
                            Dim nBordroSatirID As String = ""
                            Dim lBorcTutar As Decimal = Math.Abs(dr1("lTutar"))
                            Dim lAlacakTutar As Decimal = 0
                            Dim sDovizCinsi1 As String = ""
                            Dim lDovizMiktari1 As Decimal = 0
                            Dim lDovizKuru1 As Decimal = 0
                            Dim sDovizCinsi2 As String = ""
                            Dim lDovizMiktari2 As Decimal = 0
                            Dim lDovizKuru2 As Decimal = 0
                            Dim sEvrakNo As String = lBordroNo
                            Dim sHangiUygulama As String = sFisTipi
                            dr1("nBordroKayitID") = tbFirmaBordroDetay_kaydet_yeni(0, nBordroID, nHareketID, nKasaIslemID, nBordroSatirID, dr1("nFirmaID"), dteBordroTarihi, dteBordroTarihi, dr1("sOdemeSekli"), dr1("sAciklama"), lBorcTutar, lAlacakTutar, sEvrakNo, 0, sHangiUygulama, sHareketTipi, kullaniciadi, dr1("dteKayitTarihi"), sDovizCinsi1, lDovizMiktari1, lDovizKuru1, sDovizCinsi2, lDovizMiktari2, lDovizKuru2, kullaniciadi, Now)
                            nHareketID = tbFirmaHareketi_kaydet_yeni(nHareketID, dr1("nFirmaID"), dteBordroTarihi, dteBordroTarihi, dr1("sOdemeSekli"), dr1("sAciklama"), lBorcTutar, lAlacakTutar, sEvrakNo, 0, sHangiUygulama, sHareketTipi, kullaniciadi, dr1("dteKayitTarihi"), sDovizCinsi1, lDovizMiktari1, lDovizKuru1, sDovizCinsi2, lDovizMiktari2, lDovizKuru2, kullaniciadi, Now)
                            nCariHareketID = nHareketID
                            nCariHareketID_degistir(nCariHareketID)
                            tbKarpin_Tahsilat_kaydet_degistir(dr1("nKayitID"), dr1("nKarpinID"), dr("dteFisTarihi"), dr("sSatici"), dr("sDepo"), dr1("sFisTipi"), dr1("nFirmaID"), "", "", dr1("sAciklama").ToString, dr1("lTutar"), dr1("sOdemeSekli").ToString, dr1("dteKayitTarihi"), dr1("nBordroKayitID"))
                        End If
                    Next
                    analiz_fis(nBordroID, sFisTipi, nGirisCikis)
                End If
            End If
        End If
    End Sub
    Private Sub analiz_fis(ByVal nBordroID As Int64, ByVal sFisTipi As String, ByVal nGirisCikis As Integer)
        Dim frm As New frm_tbFirmaBordro
        frm.firmano = FirmaNo
        frm.donemno = DonemNo
        frm.connection = Connection
        frm.kullanici = Kullanici
        frm.sFisTipi = sFisTipi
        frm.nGirisCikis = nGirisCikis
        frm.nBordroID = nBordroID
        frm.sFisTipi = sFisTipi
        frm.nGirisCikis = nGirisCikis
        frm.sModul = "Cari"
        frm.bYenidenHesapla = True
        If yetki_kontrol(Kullanici, frm.Name) = True Then
            frm.ShowDialog()
        End If
        frm.Close()
        frm.Dispose()
        frm = Nothing
    End Sub
    Private Sub tbKarpin_Tahsilat_kaydet_degistir(ByVal nKayitID As Int64, ByVal nKarpinID As Int64, ByVal dteFisTarihi As DateTime, ByVal sSatici As String, ByVal sDepo As String, ByVal sFisTipi As String, ByVal nFirmaID As Integer, ByVal sFirmaKodu As String, ByVal sFirmaAciklama As String, ByVal sAciklama As String, ByVal lTutar As Decimal, ByVal sOdemeSekli As String, ByVal dteKayitTarihi As DateTime, ByVal nBordroKayitID As Int64)
        Dim con As New OleDb.OleDbConnection
        Dim cmd As New OleDb.OleDbCommand
        con.ConnectionString = Connection
        con.Open()
        cmd.Connection = con
        cmd.CommandText = "SET DATEFORMAT DMY UPDATE    tbKarpinTahsilat SET              dteFisTarihi = '" & dteFisTarihi & "', sSatici = '" & sSatici & "', sDepo = '" & sDepo & "', sFisTipi = '" & sFisTipi & "', nFirmaID = " & nFirmaID & ", sAciklama = N'" & sAciklama & "', lTutar = " & lTutar & ", sOdemeSekli = '" & sOdemeSekli & "',nBordroKayitID = " & nBordroKayitID & " where nKayitID = " & nKayitID & " and  nKarpinID = " & nKarpinID & " "
        cmd.ExecuteNonQuery()
        con.Close()
    End Sub
    Public Function sorgu_lFisNo(ByVal sFisTipi As String, ByVal nGirisCikis As Integer) As Int64
        Dim con As New OleDb.OleDbConnection
        Dim cmd As New OleDb.OleDbCommand
        con.ConnectionString = Connection
        cmd.Connection = con
        con.Open()
        cmd.CommandText = sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT TOP 1 ISNULL(lBordroNo + 1, 1) AS lBordroNo FROM tbFirmaBordroMaster Where sFisTipi ='" & sFisTipi & "' and nGirisCikis =" & nGirisCikis & " ORDER BY lBordroNo DESC")
        Dim kayitsayisi = cmd.ExecuteScalar
        If kayitsayisi = 0 Then
            kayitsayisi = 1
        End If
        Return kayitsayisi
    End Function
    'Public Function sorgu_nCariHareketID() As Int64
    '    Dim kriter As String = ""
    '    'kriter = "WHERE (sKodu = '" & kod & "')  "
    '    Dim conn As New OleDb.OleDbConnection
    '    Dim cmd As New OleDb.OleDbCommand
    '    Dim adapter As New OleDb.OleDbDataAdapter
    '    'MsgBox(connection_resmi)
    '    conn.ConnectionString = connection
    '    cmd.Connection = conn
    '    conn.Open()
    '    cmd.CommandText = sorgu_query("SET DATEFORMAT DMY SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT     TOP 1 ISNULL(nHareketID + 1, 0) AS nCariHareketID  FROM         tbFirmaHareketi " & kriter & " ORDER BY nHareketID DESC")
    '    Dim kayitsayisi = cmd.ExecuteScalar
    '    Return kayitsayisi
    'End Function
    Public Function sorgu_nCariHareketID() As Int64
        Dim kriter As String = ""
        Dim con As New OleDb.OleDbConnection
        Dim cmd As New OleDb.OleDbCommand
        Dim adapter As New OleDb.OleDbDataAdapter
        con.ConnectionString = Connection
        cmd.CommandTimeout = Nothing
        cmd.Connection = con
        con.Open()
        cmd.CommandText = sorgu_query("SET DATEFORMAT DMY SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT     ISNULL(MAX(nHareketID), 0) + 1 AS nCariHareketID FROM         tbFirmaHareketi")
        Dim kayitsayisi = cmd.ExecuteScalar
        Return kayitsayisi
        con.Dispose()
        cmd.Dispose()
        adapter.Dispose()
        cmd = Nothing
    End Function
    Private Sub nCariHareketID_degistir(ByVal nCariHareketID As String)
        Dim con As New OleDb.OleDbConnection
        Dim cmd As New OleDb.OleDbCommand
        Dim adapter As New OleDb.OleDbDataAdapter
        con.ConnectionString = Connection
        cmd.Connection = con
        If con.State = ConnectionState.Closed Then
            con.Open()
        End If
        cmd.CommandText = sorgu_query("SET DATEFORMAT DMY SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED UPDATE    tbCariSiraNo SET              nSonID = '" & nCariHareketID & "' where nSiraIndex = 1")
        cmd.ExecuteNonQuery()
        con.Close()
    End Sub
    Private Function tbFirmaBordroMaster_kaydet_yeni(ByVal dteBordroTarihi As DateTime, ByVal lBordroNo As Int64, ByVal sFisTipi As String, ByVal nGirisCikis As Integer, ByVal sSaticiRumuzu As String, ByVal nFirmaID As Integer, ByVal sAciklama1 As String, ByVal sAciklama2 As String, ByVal sAciklama3 As String, ByVal sAciklama4 As String, ByVal sAciklama5 As String, ByVal sKullanici As String, ByVal dteKayitTarihi As DateTime, ByVal bKilitli As Byte, ByVal sSubeMagaza As String, ByVal sHareketTipi As String)
        Dim con As New OleDb.OleDbConnection
        Dim cmd As New OleDb.OleDbCommand
        Dim nKayitNo As Integer = 0
        cmd.Connection = con
        con.ConnectionString = Connection
        If con.State = ConnectionState.Closed = True Then
            con.Open()
        End If
        cmd.CommandText = sorgu_query("SET DATEFORMAT DMY SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED INSERT INTO tbFirmaBordroMaster (dteBordroTarihi, lBordroNo, sFisTipi, nGirisCikis, sSaticiRumuzu, nFirmaID, sAciklama1, sAciklama2, sAciklama3, sAciklama4, sAciklama5, sKullanici,  dteKayitTarihi,bKilitli,sSubeMagaza,sHareketTipi) VALUES     ('" & dteBordroTarihi & "', " & lBordroNo & ", '" & sFisTipi & "', " & nGirisCikis & ", '" & sSaticiRumuzu & "', " & nFirmaID & ", '" & sAciklama1 & "', '" & sAciklama2 & "', '" & sAciklama3 & "', '" & sAciklama4 & "', '" & sAciklama5 & "', '" & sKullanici & "', '" & dteKayitTarihi & "'," & bKilitli & ",'" & sSubeMagaza & "','" & sHareketTipi & "')")
        cmd.ExecuteNonQuery()
        cmd.CommandText = "SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT @@identity"
        nKayitNo = cmd.ExecuteScalar
        Return nKayitNo
        con.Close()
    End Function
    Private Function tbFirmaBordroDetay_kaydet_yeni(ByVal nKayitID As Int64, ByVal nBordroID As Int64, ByVal nHareketID As String, ByVal nKasaIslemID As String, ByVal nBordroSatirID As String, ByVal nFirmaID As Int64, ByVal dteIslemTarihi As DateTime, ByVal dteValorTarihi As DateTime, ByVal sCariIslem As String, ByVal sAciklama As String, ByVal lBorcTutar As Decimal, ByVal lAlacakTutar As Decimal, ByVal sEvrakNo As String, ByVal lVadeFarki As Decimal, ByVal sHangiUygulama As String, ByVal sHareketTipi As String, ByVal sKullaniciAdi As String, ByVal dteKayitTarihi As DateTime, ByVal sDovizCinsi1 As String, ByVal lDovizMiktari1 As Decimal, ByVal lDovizKuru1 As Decimal, ByVal sDovizCinsi2 As String, ByVal lDovizMiktari2 As Decimal, ByVal lDovizKuru2 As Decimal, ByVal sSonKullaniciAdi As String, ByVal dteSonUpdateTarihi As DateTime) As Int64
        Dim con As New OleDb.OleDbConnection
        Dim cmd As New OleDb.OleDbCommand
        Dim nKayitNo As Int64 = 0
        cmd.Connection = con
        con.ConnectionString = Connection
        If con.State = ConnectionState.Closed = True Then
            con.Open()
        End If
        cmd.CommandText = sorgu_query("SET DATEFORMAT DMY  INSERT INTO tbFirmaBordroDetay                       (nBordroID,nHareketID,nKasaIslemID,nBordroSatirID,nFirmaID, dteIslemTarihi, dteValorTarihi, sCariIslem, sAciklama, lBorcTutar, lAlacakTutar, sEvrakNo, lVadeFarki, sHangiUygulama, sHareketTipi, sKullaniciAdi, dteKayitTarihi, sDovizCinsi1, lDovizMiktari1, lDovizKuru1, sDovizCinsi2, lDovizMiktari2, lDovizKuru2, sSonKullaniciAdi, dteSonUpdateTarihi) VALUES     (" & nBordroID & ",'" & nHareketID & "' ,'" & nKasaIslemID & "','" & nBordroSatirID & "','" & nFirmaID & "', '" & dteIslemTarihi & "', '" & dteValorTarihi & "', '" & sCariIslem & "', N'" & sAciklama & "', " & lBorcTutar & ", " & lAlacakTutar & " , '" & sEvrakNo & "', " & lVadeFarki & ", '" & sHangiUygulama & "', '" & sHareketTipi & "', '" & sKullaniciAdi & "', '" & dteKayitTarihi & "', '" & sDovizCinsi1 & "', " & lDovizMiktari1 & ", " & lDovizKuru1 & " , '" & sDovizCinsi2 & "', " & lDovizMiktari2 & ", " & lDovizKuru2 & " , '" & sSonKullaniciAdi & "', '" & dteSonUpdateTarihi & "')")
        cmd.ExecuteNonQuery()
        cmd.CommandText = "SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT @@identity"
        nKayitNo = cmd.ExecuteScalar
        con.Close()
        Return nKayitNo
    End Function
    Private Function tbFirmaHareketi_kaydet_yeni(ByVal nHareketID As Int64, ByVal nFirmaID As Int64, ByVal dteIslemTarihi As DateTime, ByVal dteValorTarihi As DateTime, ByVal sCariIslem As String, ByVal sAciklama As String, ByVal lBorcTutar As Decimal, ByVal lAlacakTutar As Decimal, ByVal sEvrakNo As String, ByVal lVadeFarki As Decimal, ByVal sHangiUygulama As String, ByVal sHareketTipi As String, ByVal sKullaniciAdi As String, ByVal dteKayitTarihi As DateTime, ByVal sDovizCinsi1 As String, ByVal lDovizMiktari1 As Decimal, ByVal lDovizKuru1 As Decimal, ByVal sDovizCinsi2 As String, ByVal lDovizMiktari2 As Decimal, ByVal lDovizKuru2 As Decimal, ByVal sSonKullaniciAdi As String, ByVal dteSonUpdateTarihi As DateTime) As Int64
        Dim con As New OleDb.OleDbConnection
        Dim cmd As New OleDb.OleDbCommand
        cmd.Connection = con
        con.ConnectionString = Connection
        If con.State = ConnectionState.Closed = True Then
            con.Open()
        End If
        If Trim(sCariIslem) = "" Then
            sHangiUygulama = sFisTipi
        End If
        If Trim(sDovizCinsi2) <> "" Then
            If lDovizKuru2 = 0 Then
                lDovizKuru2 = 1
            End If
            sDovizCinsi1 = sDovizCinsi2
            lDovizKuru1 = lDovizKuru2
            lDovizMiktari1 = lDovizMiktari2
        End If
        cmd.CommandText = sorgu_query("SET DATEFORMAT DMY  INSERT INTO tbFirmaHareketi                       (nFirmaID, dteIslemTarihi, dteValorTarihi, sCariIslem, sAciklama, lBorcTutar, lAlacakTutar, sEvrakNo, lVadeFarki, sHangiUygulama, sHareketTipi, sKullaniciAdi, dteKayitTarihi, sDovizCinsi1, lDovizMiktari1, lDovizKuru1, sDovizCinsi2, lDovizMiktari2, lDovizKuru2, sSonKullaniciAdi, dteSonUpdateTarihi) VALUES     ('" & nFirmaID & "', '" & dteIslemTarihi & "', '" & dteValorTarihi & "', '" & sCariIslem & "', N'" & sAciklama & "', " & lBorcTutar & ", " & lAlacakTutar & " , '" & sEvrakNo & "', " & lVadeFarki & ", '" & sHangiUygulama & "', '" & sHareketTipi & "', '" & sKullaniciAdi & "', '" & dteKayitTarihi & "', '" & sDovizCinsi1 & "', " & lDovizMiktari1 & ", " & lDovizKuru1 & " , '" & sDovizCinsi2 & "', " & lDovizMiktari2 & ", " & lDovizKuru2 & " , '" & sSonKullaniciAdi & "', '" & dteSonUpdateTarihi & "')")
        cmd.ExecuteNonQuery()
        cmd.CommandText = "SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT @@identity"
        nHareketID = cmd.ExecuteScalar
        Return nHareketID
        con.Close()
    End Function
    Private Sub tbFirmaHareketi_nCariHareketID_degistir(ByVal nCariHareketID As String)
        Dim con As New OleDb.OleDbConnection
        Dim cmd As New OleDb.OleDbCommand
        con.ConnectionString = sConnection
        cmd.Connection = con
        If con.State = ConnectionState.Closed Then
            con.Open()
        End If
        cmd.CommandText = sorgu_query("SET DATEFORMAT DMY SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED UPDATE    tbCariSiraNo SET              nSonID = '" & nCariHareketID & "' where nSiraIndex = 1")
        cmd.ExecuteNonQuery()
        con.Close()
        cmd = Nothing
        con = Nothing
    End Sub
    Private Function tbNakitKasa_kaydet_yeni(ByVal nKasaIslemID As Int64, ByVal sSube As String, ByVal dteIslemTarihi As DateTime, ByVal lTahsilTutar As Decimal, ByVal lTediyeTutar As Decimal, ByVal sAciklama As String, ByVal nCariHareketID As String, ByVal nFirmaID As Int64, ByVal nHesapID As Int64, ByVal sHangiUygulama As String, ByVal sHareketTipi As String, ByVal sKullaniciAdi As String, ByVal dteKayitTarihi As DateTime, ByVal bMuhasebeyeIslendimi As Byte, ByVal sMasrafYontemi As String, ByVal sDovizCinsi1 As String, ByVal lDovizMiktari1 As Decimal, ByVal lDovizKuru1 As Decimal, ByVal sDovizCinsi2 As String, ByVal lDovizMiktari2 As Decimal, ByVal lDovizKuru2 As Decimal, ByVal sSonKullaniciAdi As String, ByVal dteSonUpdateTarihi As DateTime, Optional ByVal nCekSenetIslem As Integer = 1) As Int64
        Dim con As New OleDb.OleDbConnection
        Dim cmd As New OleDb.OleDbCommand
        cmd.Connection = con
        con.ConnectionString = sConnection
        If con.State = ConnectionState.Closed = True Then
            con.Open()
        End If
        If nCekSenetIslem = 11 Then
            nCariHareketID = "NULL"
        End If
        sAciklama = Microsoft.VisualBasic.Left(sAciklama, 59)
        cmd.CommandText = sorgu_query("SET DATEFORMAT DMY SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED INSERT INTO tbNakitKasa ( sSube, dteIslemTarihi, lTahsilTutar, lTediyeTutar, sAciklama, nCariHareketID, nFirmaID, nHesapID, sHangiUygulama, sHareketTipi, sKullaniciAdi, dteKayitTarihi, bMuhasebeyeIslendimi, sMasrafYontemi, sDovizCinsi1, lDovizMiktari1, lDovizKuru1, sDovizCinsi2, lDovizMiktari2, lDovizKuru2, sSonKullaniciAdi, dteSonUpdateTarihi) VALUES     ( '" & sSube & "', '" & dteIslemTarihi & "', " & lTahsilTutar & ", " & lTediyeTutar & ", N'" & sAciklama & "', " & nCariHareketID & ", " & nFirmaID & ", " & nHesapID & ", '" & sHangiUygulama & "', '" & sHareketTipi & "', '" & sKullaniciAdi & "', '" & dteKayitTarihi & "', " & bMuhasebeyeIslendimi & ", '" & sMasrafYontemi & "', '" & sDovizCinsi1 & "', " & lDovizMiktari1 & ", " & lDovizKuru1 & ", '" & sDovizCinsi2 & "', " & lDovizMiktari2 & ", " & lDovizKuru2 & ", '" & sSonKullaniciAdi & "', '" & dteSonUpdateTarihi & "')")
        cmd.ExecuteNonQuery()
        cmd.CommandText = "SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT @@identity"
        nKasaIslemID = cmd.ExecuteScalar
        Return nKasaIslemID
        con.Close()
    End Function
    Private Function tbCekSenet_kaydet_yeni(ByVal nCekSenetID As Int64, ByVal sCekSenetTipi As String, ByVal lCekSenetNo As Int64, ByVal sBankaKodu As String, ByVal lTutar As Decimal, ByVal dteVadeTarihi As DateTime, ByVal dteDuzenlemeTarihi As DateTime, ByVal sIl As String, ByVal sSemt As String, ByVal sOrjinalCekSenetNo As String, ByVal sKarsiTarafCekSenetNo As String, ByVal nVerenID As Int64, ByVal bKendineAit As Integer, ByVal sBorclusu As String, ByVal sBorcluVergiDairesi As String, ByVal sBorcluVergiNumarasi As String, ByVal sBankaHesapNo As String, ByVal sBankaSubeNo As String, ByVal nSonBordroSatirID As Int64, ByVal nSonCekSenetIslem As Int64, ByVal sHareketTipi As String, ByVal sNot As String, ByVal sKullaniciAdi As String, ByVal dteKayitTarihi As DateTime, ByVal sDovizCinsi1 As String, ByVal lDovizMiktari1 As Decimal, ByVal lDovizKuru1 As Decimal, ByVal sDovizCinsi2 As String, ByVal lDovizMiktari2 As Decimal, ByVal lDovizKuru2 As Decimal, ByVal sSonKullaniciAdi As String, ByVal dteSonUpdateTarihi As DateTime, ByVal sCekSenetKodu1 As String, ByVal sCekSenetKodu2 As String) As Int64
        Dim con As New OleDb.OleDbConnection
        Dim cmd As New OleDb.OleDbCommand
        cmd.Connection = con
        con.ConnectionString = Connection
        If con.State = ConnectionState.Closed = True Then
            con.Open()
        End If
        cmd.CommandText = sorgu_query("SET DATEFORMAT DMY SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED INSERT INTO tbCekSenet ( sCekSenetTipi, lCekSenetNo, sBankaKodu, lTutar, dteVadeTarihi, dteDuzenlemeTarihi, sIl, sSemt, sOrjinalCekSenetNo, sKarsiTarafCekSenetNo, nVerenID, bKendineAit, sBorclusu, sBorcluVergiDairesi, sBorcluVergiNumarasi, sBankaHesapNo, sBankaSubeNo, nSonBordroSatirID, nSonCekSenetIslem, sHareketTipi, sNot, sKullaniciAdi, dteKayitTarihi, sDovizCinsi1, lDovizMiktari1, lDovizKuru1, sDovizCinsi2, lDovizMiktari2, lDovizKuru2, sSonKullaniciAdi, dteSonUpdateTarihi, sCekSenetKodu1, sCekSenetKodu2) VALUES     ( '" & sCekSenetTipi & "', " & lCekSenetNo & ", '" & sBankaKodu & "', " & lTutar & ", '" & dteVadeTarihi & "', '" & dteDuzenlemeTarihi & "', '" & sIl & "', '" & sSemt & "', '" & sOrjinalCekSenetNo & "', '" & sKarsiTarafCekSenetNo & "', " & nVerenID & ", " & bKendineAit & ", '" & sBorclusu & "', '" & sBorcluVergiDairesi & "', '" & sBorcluVergiNumarasi & "', '" & sBankaHesapNo & "', '" & sBankaSubeNo & "', " & nSonBordroSatirID & ", " & nSonCekSenetIslem & ", '" & sHareketTipi & "', '" & sNot & "', '" & sKullaniciAdi & "', '" & dteKayitTarihi & "', '" & sDovizCinsi1 & "', " & lDovizMiktari1 & ", " & lDovizKuru1 & ", '" & sDovizCinsi2 & "', " & lDovizMiktari2 & ", " & lDovizKuru2 & ", '" & sSonKullaniciAdi & "', '" & dteSonUpdateTarihi & "', '" & sCekSenetKodu1 & "', '" & sCekSenetKodu2 & "')")
        cmd.ExecuteNonQuery()
        cmd.CommandText = "SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT @@identity"
        nCekSenetID = cmd.ExecuteScalar
        Return nCekSenetID
        con.Close()
    End Function
    Private Function tbCekSenetBordro_kaydet_yeni(ByVal nBordroSatirID As Int64, ByVal nCekSenetIslem As Int64, ByVal nFirmaID As Int64, ByVal dteBordroTarihi As DateTime, ByVal lBordroNo As Int64, ByVal nCekSenetID As Int64, ByVal nOncekiBordroSatirID As Int64, ByVal nOncekiCekSenetIslem As Int64, ByVal nCariHareketID As Int64, ByVal nKasaIslemID As String, ByVal nBorcluFirmaID As Int64, ByVal nBorcluCariHareketID As String, ByVal nProtestoMasrafiFirmaID As Int64, ByVal nProtestoMasrafiCariHareketID As String, ByVal lProtestoMasrafi As Decimal, ByVal dteValorTarihi As DateTime, ByVal bMuhasebeyeIslendimi As Integer, ByVal sKullaniciAdi As String, ByVal dteKayitTarihi As DateTime) As Int64
        Dim con As New OleDb.OleDbConnection
        Dim cmd As New OleDb.OleDbCommand
        If nProtestoMasrafiCariHareketID = "" Then
            nProtestoMasrafiCariHareketID = "NULL"
        End If
        If nKasaIslemID = "" Then
            nKasaIslemID = "NULL"
        End If
        cmd.Connection = con
        con.ConnectionString = Connection
        If con.State = ConnectionState.Closed = True Then
            con.Open()
        End If
        If nCekSenetIslem = 21 Then
            cmd.CommandText = sorgu_query("SET DATEFORMAT DMY SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED INSERT INTO tbCekSenetBordro ( nCekSenetIslem, nFirmaID, dteBordroTarihi, lBordroNo, nCekSenetID, nOncekiBordroSatirID, nOncekiCekSenetIslem, nCariHareketID, nBorcluFirmaID, nBorcluCariHareketID,nProtestoMasrafiFirmaID, lProtestoMasrafi, dteValorTarihi, bMuhasebeyeIslendimi, sKullaniciAdi, dteKayitTarihi) VALUES     ( " & nCekSenetIslem & ", " & nFirmaID & ", '" & dteBordroTarihi & "', " & lBordroNo & ", " & nCekSenetID & ", " & nOncekiBordroSatirID & ", " & nOncekiCekSenetIslem & ", NULL, " & nBorcluFirmaID & ", " & nBorcluCariHareketID & " ," & nProtestoMasrafiFirmaID & ", " & lProtestoMasrafi & ", '" & dteValorTarihi & "', " & bMuhasebeyeIslendimi & ", '" & sKullaniciAdi & "', '" & dteKayitTarihi & "')")
        Else
            cmd.CommandText = sorgu_query("SET DATEFORMAT DMY SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED INSERT INTO tbCekSenetBordro ( nCekSenetIslem, nFirmaID, dteBordroTarihi, lBordroNo, nCekSenetID, nOncekiBordroSatirID, nOncekiCekSenetIslem, nCariHareketID, nKasaIslemID,nBorcluFirmaID, nProtestoMasrafiFirmaID,nProtestoMasrafiCariHareketID, lProtestoMasrafi, dteValorTarihi, bMuhasebeyeIslendimi, sKullaniciAdi, dteKayitTarihi) VALUES     ( " & nCekSenetIslem & ", " & nFirmaID & ", '" & dteBordroTarihi & "', " & lBordroNo & ", " & nCekSenetID & ", " & nOncekiBordroSatirID & ", " & nOncekiCekSenetIslem & ", " & nCariHareketID & "," & nKasaIslemID & ", " & nBorcluFirmaID & ", " & nProtestoMasrafiFirmaID & ", " & nProtestoMasrafiCariHareketID & "," & lProtestoMasrafi & ", '" & dteValorTarihi & "', " & bMuhasebeyeIslendimi & ", '" & sKullaniciAdi & "', '" & dteKayitTarihi & "')")
        End If
        cmd.ExecuteNonQuery()
        cmd.CommandText = "SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT @@identity"
        nBordroSatirID = cmd.ExecuteScalar
        Return nBordroSatirID
        con.Close()
    End Function
    Private Sub nCekSenetID_degistir(ByVal nSonID As String)
        Dim con As New OleDb.OleDbConnection
        Dim cmd As New OleDb.OleDbCommand
        Dim adapter As New OleDb.OleDbDataAdapter
        con.ConnectionString = Connection
        cmd.Connection = con
        If con.State = ConnectionState.Closed Then
            con.Open()
        End If
        cmd.CommandText = sorgu_query("SET DATEFORMAT DMY SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED UPDATE    tbCekSenetSiraNo SET              nSonID =" & nSonID & " WHERE     (nSiraIndex = 1)")
        cmd.ExecuteNonQuery()
        con.Close()
    End Sub
    Private Sub nCekSenetID_degistir_otomatik()
        Dim con As New OleDb.OleDbConnection
        Dim cmd As New OleDb.OleDbCommand
        con.ConnectionString = Connection
        cmd.Connection = con
        If con.State = ConnectionState.Closed Then
            con.Open()
        End If
        cmd.CommandText = sorgu_query("SET DATEFORMAT DMY SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED UPDATE tbCekSenetSiraNo SET nSonID = ISNULL((SELECT TOP 1 ISNULL(nCekSenetID + 1 , 1) AS nSonID FROM tbCekSenet ORDER BY nCekSenetID DESC), 1) WHERE (nSiraIndex = 1)")
        cmd.ExecuteNonQuery()
        con.Close()
    End Sub
    Private Sub nCekSenetID_Odeme_degistir(ByVal nCekSenetID As String, ByVal nSonBordroSatirID As String, ByVal nSonCekSenetIslem As String)
        Dim con As New OleDb.OleDbConnection
        Dim cmd As New OleDb.OleDbCommand
        con.ConnectionString = Connection
        cmd.Connection = con
        If con.State = ConnectionState.Closed Then
            con.Open()
        End If
        cmd.CommandText = sorgu_query("SET DATEFORMAT DMY SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED UPDATE    tbCekSenet SET              nSonBordroSatirID = " & nSonBordroSatirID & ",nSonCekSenetIslem = " & nSonCekSenetIslem & " WHere nCekSenetID = " & nCekSenetID & " ")
        cmd.ExecuteNonQuery()
        con.Close()
    End Sub
    Private Sub nBordroSatirID_degistir(ByVal nSonID As String)
        Dim con As New OleDb.OleDbConnection
        Dim cmd As New OleDb.OleDbCommand
        con.ConnectionString = Connection
        cmd.Connection = con
        If con.State = ConnectionState.Closed Then
            con.Open()
        End If
        cmd.CommandText = sorgu_query("SET DATEFORMAT DMY SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED UPDATE    tbCekSenetSiraNo SET              nSonID =" & nSonID & " WHERE     (nSiraIndex = 2)")
        cmd.ExecuteNonQuery()
        con.Close()
    End Sub
    Private Sub nBordroSatirID_degistir_otomatik()
        Dim con As New OleDb.OleDbConnection
        Dim cmd As New OleDb.OleDbCommand
        Dim adapter As New OleDb.OleDbDataAdapter
        con.ConnectionString = Connection
        cmd.Connection = con
        If con.State = ConnectionState.Closed Then
            con.Open()
        End If
        cmd.CommandText = sorgu_query("SET DATEFORMAT DMY SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED UPDATE tbCekSenetSiraNo SET nSonID = ISNULL((SELECT TOP 1 ISNULL(nBordroSatirID + 1 , 1) AS nSonID FROM tbCekSenetBordro ORDER BY nBordroSatirID DESC), 1) WHERE (nSiraIndex = 2)")
        cmd.ExecuteNonQuery()
        con.Close()
    End Sub
    Public Function sorgu_nBordroSatirID() As Int64
        Dim kriter As String = ""
        'kriter = "WHERE (sKodu = '" & kod & "')  "
        Dim conn As New OleDb.OleDbConnection
        Dim cmd As New OleDb.OleDbCommand
        Dim adapter As New OleDb.OleDbDataAdapter
        'MsgBox(connection_resmi)
        conn.ConnectionString = Connection
        cmd.Connection = conn
        conn.Open()
        cmd.CommandText = sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT TOP 1 ISNULL(nBordroSatirID + 1, 1) AS nBordroSatirID FROM tbCekSenetBordro ORDER BY nBordroSatirID DESC")
        Dim kayitsayisi = cmd.ExecuteScalar
        If kayitsayisi = 0 Then
            kayitsayisi = 1
        End If
        Return kayitsayisi
    End Function
    Public Function sorgu_nCekSenetID() As Int64
        Dim kriter As String = ""
        'kriter = "WHERE (sKodu = '" & kod & "')  "
        Dim conn As New OleDb.OleDbConnection
        Dim cmd As New OleDb.OleDbCommand
        Dim adapter As New OleDb.OleDbDataAdapter
        'MsgBox(connection_resmi)
        conn.ConnectionString = Connection
        cmd.Connection = conn
        conn.Open()
        cmd.CommandText = sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT TOP 1 ISNULL(nCekSenetID + 1, 1) AS nCekSenetID FROM tbCekSenet ORDER BY nCekSenetID DESC")
        Dim kayitsayisi = cmd.ExecuteScalar
        If kayitsayisi = 0 Then
            kayitsayisi = 1
        End If
        Return kayitsayisi
    End Function
    Public Function sorgu_lCekSenetNo(ByVal sCekSenetTipi As String) As Int64
        Dim kriter As String = ""
        'kriter = "WHERE (sKodu = '" & kod & "')  "
        Dim conn As New OleDb.OleDbConnection
        Dim cmd As New OleDb.OleDbCommand
        Dim adapter As New OleDb.OleDbDataAdapter
        'MsgBox(connection_resmi)
        conn.ConnectionString = Connection
        cmd.Connection = conn
        conn.Open()
        cmd.CommandText = sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT TOP 1 ISNULL(lCekSenetNo + 1, 1) AS lCekSenetNo FROM tbCekSenet Where sCekSenetTipi = '" & sCekSenetTipi & "' ORDER BY lCekSenetNo DESC")
        Dim kayitsayisi = cmd.ExecuteScalar
        If kayitsayisi = 0 Then
            kayitsayisi = 1
        End If
        Return kayitsayisi
    End Function
    Public Function sorgu_lBordroNo() As Int64
        Dim kriter As String = ""
        'kriter = "WHERE (sKodu = '" & kod & "')  "
        Dim conn As New OleDb.OleDbConnection
        Dim cmd As New OleDb.OleDbCommand
        Dim adapter As New OleDb.OleDbDataAdapter
        'MsgBox(connection_resmi)
        conn.ConnectionString = Connection
        cmd.Connection = conn
        conn.Open()
        cmd.CommandText = sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT TOP 1 ISNULL(lBordroNo + 1, 1) AS lBordroNo FROM tbCekSenetBordro ORDER BY lBordroNo DESC")
        Dim kayitsayisi = cmd.ExecuteScalar
        If kayitsayisi = 0 Then
            kayitsayisi = 1
        End If
        Return kayitsayisi
    End Function
    Public Function sorgu_nKasaIslemID() As Int64
        Dim kriter As String = ""
        'kriter = "WHERE (sKodu = '" & kod & "')  "
        Dim conn As New OleDb.OleDbConnection
        Dim cmd As New OleDb.OleDbCommand
        Dim adapter As New OleDb.OleDbDataAdapter
        'MsgBox(connection_resmi)
        conn.ConnectionString = sConnection
        cmd.Connection = conn
        conn.Open()
        'cmd.CommandText = sorgu_query("SET DATEFORMAT DMY SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT     TOP 1 ISNULL(nKasaIslemID + 1, 0) AS nKasaIslemID  FROM         tbNakitKasa " & kriter & " ORDER BY nKasaIslemID DESC")
        'Dim kayitsayisi = cmd.ExecuteScalar
        cmd.CommandText = sorgu_query("SET DATEFORMAT DMY SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT     ISNULL(nSonID,0) + 1 AS nKasaIslemID FROM         tbCariSiraNo WHERE     (nSiraIndex = 2)")
        Dim kayitsayisi = cmd.ExecuteScalar
        If kayitsayisi = 0 Then
            kayitsayisi = 1
        End If
        Return kayitsayisi
    End Function
    Public Function sorgu_lBakiye(ByVal nFirmaID As Int64) As Decimal
        Dim kriter As String = ""
        'kriter = "WHERE (sKodu = '" & kod & "')  "
        Dim conn As New OleDb.OleDbConnection
        Dim cmd As New OleDb.OleDbCommand
        Dim adapter As New OleDb.OleDbDataAdapter
        'MsgBox(connection_resmi)
        conn.ConnectionString = sConnection
        cmd.Connection = conn
        conn.Open()
        cmd.CommandText = sorgu_query("SET DATEFORMAT DMY SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT     ISNULL(SUM(lBorcTutar - lAlacakTutar), 0) AS lBakiye FROM         tbFirmaHareketi WHERE     (nFirmaID = " & nFirmaID & ")")
        Dim kayitsayisi = cmd.ExecuteScalar
        Return kayitsayisi
    End Function
    Private Sub nKasaIslemID_degistir(ByVal nKasaIslemID As String)
        Dim con As New OleDb.OleDbConnection
        Dim cmd As New OleDb.OleDbCommand
        Dim adapter As New OleDb.OleDbDataAdapter
        con.ConnectionString = sConnection
        cmd.Connection = con
        If con.State = ConnectionState.Closed Then
            con.Open()
        End If
        cmd.CommandText = sorgu_query("SET DATEFORMAT DMY SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED UPDATE    tbCariSiraNo SET              nSonID = '" & nKasaIslemID & "' where nSiraIndex = 2")
        cmd.ExecuteNonQuery()
        con.Close()
    End Sub
    Private Function tbHesapPlani_kaydet_yeni(ByVal sKodu As String, ByVal sAciklama As String, ByVal sAlterneAciklama As String, ByVal lBilancoSatiri As Decimal, ByVal sAktifPasif As String, ByVal lKarZararSatiri As Decimal, ByVal sKarZararGelirGider As String, ByVal sMasrafYontemi As String, ByVal bMiktarVar As Integer, ByVal sKullaniciAdi As String, ByVal dteKayitTarihi As DateTime, Optional ByVal sDatabase As String = "") As Int64
        Dim use As String = ""
        If sDatabase <> "" Then
            use = "USE " & sDatabase
        End If
        Dim con As New OleDb.OleDbConnection
        Dim cmd As New OleDb.OleDbCommand
        cmd.Connection = con
        con.ConnectionString = Connection
        If con.State = ConnectionState.Closed = True Then
            con.Open()
        End If
        cmd.CommandText = sorgu_query("" & use & " SET DATEFORMAT DMY SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT     ISNULL(nHesapID, 0) AS nHesapID  FROM         tbHesapPlani Where sKodu = '" & sKodu & "' ")
        Dim kayitno = cmd.ExecuteScalar
        If Trim(kayitno) = "0" Or Trim(kayitno) = "" Then
            cmd.CommandText = sorgu_query("" & use & " SET DATEFORMAT DMY SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED INSERT INTO tbHesapPlani (sKodu, sAciklama, sAlterneAciklama, lBilancoSatiri, sAktifPasif, lKarZararSatiri, sKarZararGelirGider, sMasrafYontemi, bMiktarVar, sKullaniciAdi, dteKayitTarihi) VALUES     ('" & sKodu & "', '" & sAciklama & "', '" & sAlterneAciklama & "', " & lBilancoSatiri & ", '" & sAktifPasif & "', " & lKarZararSatiri & ", '" & sKarZararGelirGider & "', '" & sMasrafYontemi & "', " & bMiktarVar & ", '" & sKullaniciAdi & "', '" & dteKayitTarihi & "')")
            cmd.ExecuteNonQuery()
            cmd.CommandText = "select @@identity"
            kayitno = cmd.ExecuteScalar
        End If
        con.Close()
        Return kayitno
        cmd = Nothing
        con = Nothing
    End Function
    Private Function tbMuhasebeFisi_kaydet_yeni(ByVal nFisSiraID As String, ByVal dteFisTarihi As DateTime, ByVal sMuhFisTipi As Integer, ByVal lFisno As Int64, ByVal lYevmiyeNo As Int64, ByVal nHesapID As Int64, ByVal sAciklama As String, ByVal lGirenMiktar As Decimal, ByVal lCikanMiktar As Decimal, ByVal lBorcTutar As Decimal, ByVal lAlacakTutar As Decimal, ByVal sMasrafYontemi As String, ByVal nKasaID As Int64, ByVal sHangiUygulama As String, ByVal sHareketTipi As String, ByVal nCariHareketID As Int64, ByVal sKullaniciAdi As String, ByVal dteKayitTarihi As DateTime, ByVal sDovizCinsi1 As String, ByVal lDovizMiktari1 As Decimal, ByVal lDovizKuru1 As Decimal, ByVal sDovizCinsi2 As String, ByVal lDovizMiktari2 As Decimal, ByVal lDovizKuru2 As Decimal, ByVal nSatir As Int64, ByVal sSubeMagaza As String, ByVal sSonKullaniciAdi As String, ByVal dteSonUpdateTarihi As DateTime) As Int64
        Dim con As New OleDb.OleDbConnection
        Dim cmd As New OleDb.OleDbCommand
        cmd.Connection = con
        con.ConnectionString = Connection
        If con.State = ConnectionState.Closed = True Then
            con.Open()
        End If
        cmd.CommandText = sorgu_query("SET DATEFORMAT DMY SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED INSERT INTO tbMuhasebeFisi ( dteFisTarihi, sMuhFisTipi, lFisno, lYevmiyeNo, nHesapID, sAciklama, lGirenMiktar, lCikanMiktar, lBorcTutar, lAlacakTutar,sMasrafYontemi, nKasaID, sHangiUygulama, sHareketTipi, nCariHareketID, sKullaniciAdi, dteKayitTarihi, sDovizCinsi1, lDovizMiktari1, lDovizKuru1, sDovizCinsi2, lDovizMiktari2, lDovizKuru2, nSatir, sSubeMagaza, sSonKullaniciAdi, dteSonUpdateTarihi) VALUES     ( '" & dteFisTarihi & "', '" & sMuhFisTipi & "', " & lFisno & ", " & lYevmiyeNo & ", " & nHesapID & ", N'" & sAciklama & "', " & lGirenMiktar & ", " & lCikanMiktar & ", " & lBorcTutar & ", " & lAlacakTutar & ", '" & sMasrafYontemi & "', " & nKasaID & ", '" & sHangiUygulama & "', '" & sHareketTipi & "', " & nCariHareketID & ", '" & sKullaniciAdi & "', '" & dteKayitTarihi & "', '" & sDovizCinsi1 & "', " & lDovizMiktari1 & ", " & lDovizKuru1 & ", '" & sDovizCinsi2 & "', " & lDovizMiktari2 & ", " & lDovizKuru2 & ", " & nSatir & ", '" & sSubeMagaza & "', '" & sSonKullaniciAdi & "', '" & dteSonUpdateTarihi & "')")
        cmd.ExecuteNonQuery()
        cmd.CommandText = "SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT @@identity"
        nFisSiraID = cmd.ExecuteScalar
        Return nFisSiraID
        con.Close()
    End Function
    Public Function sorgu_lMuhasebeFisNo() As Int64
        Dim kriter As String = ""
        'kriter = "WHERE (sKodu = '" & kod & "')  "
        Dim conn As New OleDb.OleDbConnection
        Dim cmd As New OleDb.OleDbCommand
        Dim adapter As New OleDb.OleDbDataAdapter
        'MsgBox(connection_resmi)
        conn.ConnectionString = Connection
        cmd.Connection = conn
        conn.Open()
        cmd.CommandText = sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT     ISNULL(lSonMahsupNo1, 1) AS lFisNo FROM         tbMuhasebeFisNo")
        Dim kayitsayisi = cmd.ExecuteScalar
        If kayitsayisi = 1 Then
            kayitsayisi = 2
        End If
        Return kayitsayisi
    End Function
    Public Function sorgu_nFisSiraID() As Int64
        'Dim kriter As String = ""
        ''kriter = "WHERE (sKodu = '" & kod & "')  "
        'Dim conn As New OleDb.OleDbConnection
        'Dim cmd As New OleDb.OleDbCommand
        'Dim adapter As New OleDb.OleDbDataAdapter
        ''MsgBox(connection_resmi)
        'conn.ConnectionString = Connection
        'cmd.Connection = conn
        'conn.Open()
        'cmd.CommandText = sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT     TOP 1 ISNULL(nFisSiraID + 1, 1) AS nFisSiraID FROM         tbMuhasebeFisi ORDER BY nFisSiraID DESC")
        'Dim kayitsayisi = cmd.ExecuteScalar
        'Return kayitsayisi
        Return 1
    End Function
    Private Sub nFisSiraID_degistir(ByVal nFisSiraID As String)
        Dim con As New OleDb.OleDbConnection
        Dim cmd As New OleDb.OleDbCommand
        Dim adapter As New OleDb.OleDbDataAdapter
        con.ConnectionString = Connection
        cmd.Connection = con
        If con.State = ConnectionState.Closed Then
            con.Open()
        End If
        cmd.CommandText = sorgu_query("SET DATEFORMAT DMY SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED UPDATE    tbMuhasebeSiraNo SET              nSonID = '" & nFisSiraID & "' where nSiraIndex = 1")
        cmd.ExecuteNonQuery()
        con.Close()
    End Sub
    Private Sub lMuhasebeFisNo_degistir()
        Dim con As New OleDb.OleDbConnection
        Dim cmd As New OleDb.OleDbCommand
        Dim adapter As New OleDb.OleDbDataAdapter
        con.ConnectionString = Connection
        cmd.Connection = con
        If con.State = ConnectionState.Closed Then
            con.Open()
        End If
        cmd.CommandText = sorgu_query("SET DATEFORMAT DMY SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED UPDATE tbMuhasebeFisNo SET lSonMahsupNo1 = ISNULL((SELECT TOP 1 ISNULL(lFisno + 1 , 1) AS lFisNo FROM tbMuhasebeFisi WHERE (sMuhFisTipi = 3) Order by lFisNo desc),1)")
        cmd.ExecuteNonQuery()
        con.Close()
    End Sub
    Private Sub tbMuhasebeFisi_Aciklamasi_kaydet_yeni(ByVal dteFisTarihi As DateTime, ByVal sMuhFisTipi As String, ByVal lFisno As Int64, ByVal sAciklama1 As String, ByVal sAciklama2 As String, ByVal sAciklama3 As String, ByVal sAciklama4 As String, ByVal sAciklama5 As String, ByVal bKilitli As Byte)
        Dim con As New OleDb.OleDbConnection
        Dim cmd As New OleDb.OleDbCommand
        cmd.Connection = con
        con.ConnectionString = Connection
        If con.State = ConnectionState.Closed = True Then
            con.Open()
        End If
        cmd.CommandText = sorgu_query("SET DATEFORMAT DMY  INSERT INTO tbMuhasebeFisiAciklamasi (dteFisTarihi, sMuhFisTipi, lFisno, sAciklama1, sAciklama2, sAciklama3, sAciklama4, sAciklama5,bKilitli) VALUES     ('" & dteFisTarihi & "', '" & sMuhFisTipi & "', " & lFisno & ", '" & sAciklama1 & "', '" & sAciklama2 & "', '" & sAciklama3 & "', '" & sAciklama4 & "', '" & sAciklama5 & "'," & bKilitli & ")")
        cmd.ExecuteNonQuery()
        con.Close()
    End Sub
    Private Sub MenuItem34_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem34.Click
        Group_Muhasebelestir.Visible = True
        sec_sMuhasebeIslemTuru.Text = "Muhasebeleþtirme"
        txt_dteEntegreTarihi.EditValue = dteSistemTarihi
        sec_sMuhasebeEntegrasyonTuru.Focus()
        sec_sMuhasebeEntegrasyonTuru.Select()
    End Sub
    Private Sub SimpleButton11_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SimpleButton11.Click
        If XtraMessageBox.Show("Muhasebeleþtirme Ýþlemine Baþlamak Ýstediðinize Emin misiniz...?", Sorgu_sDil("Dikkat", sDil), MessageBoxButtons.YesNo, MessageBoxIcon.Question) = MsgBoxResult.Yes Then
            bar1.Visible = True
            Cursor.Current = Cursors.WaitCursor
            Cursor.Show()
            muhasebelestir(1)
            bar1.Visible = False
            Group_Muhasebelestir.Visible = False
            GridControl1.Focus()
            GridControl1.Select()
            Cursor.Current = Cursors.Default
            Cursor.Hide()
        End If
    End Sub
    Private Sub SimpleButton10_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SimpleButton10.Click
        Group_Muhasebelestir.Visible = False
        GridControl1.Focus()
        GridControl1.Select()
    End Sub
    Private Sub muhasebelestir(ByVal bKilitli As Byte)
        Dim arr As Integer()
        Dim i As Integer
        Dim sayi As Integer = 0
        Dim nFirmaID As String = ""
        Dim s As String = ""
        Dim dr As DataRow
        Dim dr1 As DataRow
        arr = GridView1.GetSelectedRows()
        Dim ds_Muhasebelestir As DataSet
        Dim lFisNo = sorgu_lMuhasebeFisNo()
        Dim lYevmiyeNo = lFisNo
        Dim nHesapID As Int64 = 0
        Dim nFisSiraID As Int64 = sorgu_nFisSiraID()
        Dim nCariHareketID = 0
        Dim nHareketID As Int64 = nCariHareketID
        Dim nKasaIslemID As String = ""
        Dim nBordroSatirID As String = ""
        Dim nSatir As Integer = 0
        Dim lGirenMiktar As Decimal = 0
        Dim lBorcTutar As Decimal = 0
        Dim lAlacakTutar As Decimal = 0
        Dim lCikanMiktar As Decimal = 0
        Dim sDovizCinsi1 As String = ""
        Dim lDovizMiktari1 As Decimal = 0
        Dim lDovizKuru1 As Decimal = 0
        Dim sDovizCinsi2 As String = ""
        Dim lDovizMiktari2 As Decimal = 0
        Dim lDovizKuru2 As Decimal = 0
        Dim sEvrakNo As String = ""
        Dim sHangiUygulama As String = "MUH"
        Dim sMasrafYontemi = ""
        Dim nKasaID As Int64 = 0
        Dim nAlacakliFirmaID As Int64 = 0
        Dim nAlacakliHesapID As Int64 = 0
        Dim sHesapKodu As String = ""
        Dim sHesapAciklama As String = ""
        Dim sStokKodu As String = ""
        Dim sStokAciklama As String = ""
        Dim sAciklama As String = ""
        Dim dteFisTarihi As DateTime = Today
        Dim sMuhFisTipi As Int64 = 3
        bar1.Properties.Maximum = GridView1.SelectedRowsCount
        bar1.Position = 0
        bar1.Refresh()
        If arr Is Nothing Then
        Else
            Array.Sort(arr)
            For Each i In arr
                s = i.ToString
                dr = GridView1.GetDataRow(s)
                bar1.Position += 1
                bar1.Refresh()
                'ds_Muhasebelestir = sorgu(sorgu_query("SELECT tbFirma.sKodu, tbFirma.sAciklama, tbStok.sKodu AS sStokKodu, tbStok.sAciklama AS sStokAciklama, tbStok.nStokTipi,tbStokFisiDetayi.dteFisTarihi,tbStokFisiDetayi.sFisTipi, tbStokFisiDetayi.lFisNo,tbStokFisiDetayi.nKdvOrani, tbStokFisiDetayi.lGirisMiktar1, tbStokFisiDetayi.lCikisMiktar1, tbStokFisiDetayi.lBrutFiyat, tbStokFisiDetayi.lBrutTutar, tbStokFisiDetayi.lCikisFiyat, tbStokFisiDetayi.lCikisTutar, tbStokFisiDetayi.lGirisFiyat, tbStokFisiDetayi.lGirisTutar, tbStokFisiDetayi.nIskontoYuzdesi, ROUND(tbStokFisiDetayi.lIskontoTutari,2) AS lIskontoTutari, (SELECT TOP 1 ISNULL(lGirisFiyat , 0) FROM tbStokFisiDetayi tbAlis WHERE sFisTipi = 'FA' AND nGirisCikis = 1  and tbAlis.nStokID = tbStokFisiDetayi.nStokID Order by dteFisTarihi DESC) AS lMaliyet, ROUND((tbStokFisiDetayi.lBrutTutar - tbStokFisiDetayi.lIskontoTutari) * tbStokFisiDetayi.nKdvOrani / 100, 2) AS lKdvTutari, tbStokFisiMaster.nStokFisiID, tbStokFisiMaster.lToplamMiktar, tbStokFisiMaster.lMalBedeli, tbStokFisiMaster.lMalIskontoTutari, tbStokFisiMaster.nDipIskontoYuzdesi1, tbStokFisiMaster.lDipIskontoTutari1, tbStokFisiMaster.nDipIskontoYuzdesi2, tbStokFisiMaster.lDipIskontoTutari2, tbStokFisiMaster.lDipIskontoTutari3, tbStokFisiMaster.nKdvOrani1, tbStokFisiMaster.lKdvMatrahi1, tbStokFisiMaster.lKdv1, tbStokFisiMaster.nKdvOrani2, tbStokFisiMaster.lKdvMatrahi2, tbStokFisiMaster.lKdv2, tbStokFisiMaster.nKdvOrani3, tbStokFisiMaster.lKdvMatrahi3, tbStokFisiMaster.lKdv3, tbStokFisiMaster.nKdvOrani4, tbStokFisiMaster.lKdvMatrahi4, tbStokFisiMaster.lKdv4, tbStokFisiMaster.nKdvOrani5, tbStokFisiMaster.lKdvMatrahi5, tbStokFisiMaster.lKdv5, tbStokFisiMaster.lNetTutar, tbStokFisiMaster.nTevkifatKdvOrani, tbStokFisiMaster.lTevkifatKdvMatrahi, tbStokFisiMaster.lTevkifatKdv, tbStokFisiMaster.bMuhasebeyeIslendimi,tbStokFisiAciklamasi.sAciklama1 FROM tbStokFisiDetayi INNER JOIN tbStokFisiMaster ON tbStokFisiDetayi.nStokFisiID = tbStokFisiMaster.nStokFisiID INNER JOIN tbStok ON tbStokFisiDetayi.nStokID = tbStok.nStokID INNER JOIN tbFirma ON tbStokFisiMaster.nFirmaID = tbFirma.nFirmaID LEFT OUTER JOIN                       tbStokFisiAciklamasi ON tbStokFisiMaster.nStokFisiID = tbStokFisiAciklamasi.nStokFisiID WHERE (tbStokFisiMaster.sFisTipi = '" & sec_sFisTipi.EditValue & "') and (tbStokFisiMaster.nGirisCikis = '" & sec_nGirisCikis.EditValue & "') AND (tbStokFisiMaster.nStokFisiID = '" & dr("nStokFisiID") & "') ORDER BY tbStokFisiDetayi.nGirisCikis,tbStokFisiDetayi.nIslemID"))
                ds_Muhasebelestir = sorgu("SET DATEFORMAT DMY SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT     tbKarpinTahsilat.*, tbFirma.nHesapID AS nHesapID FROM         tbKarpinTahsilat INNER JOIN                       tbFirma ON tbKarpinTahsilat.nFirmaID = tbFirma.nFirmaID WHERE     (tbKarpinTahsilat.sFisTipi IN (1,3)) AND (tbKarpinTahsilat.nKarpinID = " & dr("nKarpinID") & ") ORDER BY tbKarpinTahsilat.sOdemeSekli")
                'Baþlýk Kaydet
                If ds_Muhasebelestir.Tables(0).Rows.Count > 0 Then
                    dr1 = ds_Muhasebelestir.Tables(0).Rows(0)
                    If sec_sMuhasebeEntegrasyonTuru.Text = "Bire-Bir Muhasebeleþtirme" Then
                        lMuhasebeFisNo_degistir()
                        Try
                            tbMuhasebeFisi_Aciklamasi_kaydet_yeni(dteFisTarihi, sMuhFisTipi, lFisNo, "", "KarpinEntegre", "KarpinTahsilatlar", "", "", 0)
                        Catch ex As Exception
                        End Try
                        lFisNo = sorgu_lMuhasebeFisNo()
                        lYevmiyeNo = lFisNo
                        dteFisTarihi = dr1("dteFisTarihi")
                    ElseIf sec_sMuhasebeEntegrasyonTuru.Text = "Günlük Muhasebeleþtirme" Then
                        If dteFisTarihi <> dr1("dteFisTarihi") Then
                            lMuhasebeFisNo_degistir()
                            Try
                                tbMuhasebeFisi_Aciklamasi_kaydet_yeni(dteFisTarihi, sMuhFisTipi, lFisNo, "", "KarpinEntegre", "KarpinTahsilatlar", "", "", 0)
                            Catch ex As Exception
                            End Try
                            lFisNo = sorgu_lMuhasebeFisNo()
                            lYevmiyeNo = lFisNo
                            dteFisTarihi = dr1("dteFisTarihi")
                        End If
                    ElseIf sec_sMuhasebeEntegrasyonTuru.Text = "Toplu Muhasebeleþtirme" Then
                        dteFisTarihi = txt_dteEntegreTarihi.EditValue
                    End If
                    nSatir = 0
                End If
                'Hareketleri Kaydet
                For Each dr1 In ds_Muhasebelestir.Tables(0).Rows
                    nSatir += 1
                    'Borçlu Hesap Ýþle
                    If Trim(dr1("sOdemeSekli")) = "KK" Or Trim(dr1("sOdemeSekli")) = "V" Then
                        sHesapKodu = "108-0001-0000001"
                        sHesapAciklama = "Kredi Kartlý Tahsilatlar"
                        sAciklama = degeruzunlukkontrol(dr1("sFirmaAciklama"), 22) & "\" & dr1("dteFisTarihi") & "\Kredi Kartý ile Tahsilat"
                    Else
                        sHesapKodu = "100-0001-0000001"
                        sHesapAciklama = "Nakit Tahsilatlar"
                        sAciklama = degeruzunlukkontrol(dr1("sFirmaAciklama"), 22) & "\" & dr1("dteFisTarihi") & "\Nakit Tahsilat"
                    End If
                    nHesapID = sorgula_nStokID("Select nHesapID from tbHesapPlani Where sKodu = '" & sHesapKodu & "'")
                    If nHesapID = 0 Then
                        nHesapID = tbHesapPlani_kaydet_yeni(sHesapKodu, sHesapAciklama, "", 0, "", 0, "", "", 0, "SA", Now)
                    End If
                    nFisSiraID = sorgu_nFisSiraID()
                    lBorcTutar = dr1("lTutar")
                    lAlacakTutar = 0
                    sDovizCinsi1 = ""
                    lDovizKuru1 = 0
                    lDovizMiktari1 = 0
                    sDovizCinsi2 = ""
                    lDovizKuru2 = 0
                    lDovizMiktari2 = 0
                    lGirenMiktar = 0
                    lCikanMiktar = 0
                    nFisSiraID = tbMuhasebeFisi_kaydet_yeni(nFisSiraID, dteFisTarihi, sMuhFisTipi, lFisNo, lYevmiyeNo, nHesapID, sAciklama, lGirenMiktar, lCikanMiktar, lBorcTutar, lAlacakTutar, sMasrafYontemi, nKasaID, sHangiUygulama, sHareketTipi, nCariHareketID, kullaniciadi, Now, sDovizCinsi1, lDovizMiktari1, lDovizKuru1, sDovizCinsi2, lDovizMiktari2, lDovizKuru2, nSatir, sSubeMagaza, kullaniciadi, Now)
                    nFisSiraID_degistir(nFisSiraID)
                    'Alacaklý Hesap iþle
                    sHesapKodu = "120-0001-" & sayiuzunlukkontrol(Trim(dr1("sFirmaKodu")), 7)
                    sHesapAciklama = dr1("sFirmaAciklama")
                    nHesapID = sorgula_nStokID("Select nHesapID from tbHesapPlani Where sKodu = '" & sHesapKodu & "'")
                    If nHesapID = 0 Then
                        nHesapID = tbHesapPlani_kaydet_yeni(sHesapKodu, sHesapAciklama, "", 0, "", 0, "", "", 0, "SA", Now)
                    End If
                    nFisSiraID = sorgu_nFisSiraID()
                    lBorcTutar = 0
                    lAlacakTutar = dr1("lTutar")
                    sDovizCinsi1 = ""
                    lDovizKuru1 = 0
                    lDovizMiktari1 = 0
                    sDovizCinsi2 = ""
                    lDovizKuru2 = 0
                    lDovizMiktari2 = 0
                    lGirenMiktar = 0
                    lCikanMiktar = 0
                    nFisSiraID = tbMuhasebeFisi_kaydet_yeni(nFisSiraID, dteFisTarihi, sMuhFisTipi, lFisNo, lYevmiyeNo, nHesapID, sAciklama, lGirenMiktar, lCikanMiktar, lBorcTutar, lAlacakTutar, sMasrafYontemi, nKasaID, sHangiUygulama, sHareketTipi, nCariHareketID, kullaniciadi, Now, sDovizCinsi1, lDovizMiktari1, lDovizKuru1, sDovizCinsi2, lDovizMiktari2, lDovizKuru2, nSatir, sSubeMagaza, kullaniciadi, Now)
                    nFisSiraID_degistir(nFisSiraID)
                Next
            Next
        End If
        lMuhasebeFisNo_degistir()
        Try
            tbMuhasebeFisi_Aciklamasi_kaydet_yeni(dteFisTarihi, sMuhFisTipi, lFisNo, "", "KarpinEntegre", "KarpinTahsilatlar", "", "", 0)
        Catch ex As Exception
        End Try
        bar1.Position = 0
        bar1.Refresh()
        XtraMessageBox.Show(Sorgu_sDil("Ýþlem Baþarýyla Tamamlandý", sDil), Sorgu_sDil("Dikkat", sDil), MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub
End Class