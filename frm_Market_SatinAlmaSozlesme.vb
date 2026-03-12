Imports Microsoft.Win32
Imports DevExpress.XtraEditors
Public Class frm_Market_SatinAlmaSozlesme
    Public firmano As Integer = 100
    Public donemno As Integer = 1
    Public connection
    Public kullanici
    Public islem As String = ""
    Dim nFirmaID As Int64 = 0
    Dim conn As New OleDb.OleDbConnection
    Dim con As New OleDb.OleDbConnection
    Dim cmd As New OleDb.OleDbCommand
    Dim adapter As New OleDb.OleDbDataAdapter
    Dim DS As New DataSet
    Dim ds_tbMarketSozlesmeMaster As DataSet
    Dim ds_tbMarketSozlesmeDetayi As DataSet
    Dim ds_tbMarketSozlesmeDetayiTakip As DataSet
    Private Sub frm_Market_SatinAlmaSozlesme_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        dataload_tbMarketSozlesmeMaster()
    End Sub
    Private Function tbMarketSozlesmeMaster_kaydet_yeni(ByVal nFirmaID As Int64, ByVal sAciklama As String, ByVal dteBaslangic As DateTime, ByVal dteBitis As DateTime) As Int64
        Dim cmd As New OleDb.OleDbCommand
        Dim con As New OleDb.OleDbConnection
        cmd.Connection = con
        con.ConnectionString = connection
        cmd.CommandTimeout = Nothing
        If con.State = ConnectionState.Closed = True Then
            con.Open()
        End If
        cmd.CommandText = sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED INSERT INTO tbMarketSozlesmeMaster                       (nFirmaID, sAciklama, dteBaslangic, dteBitis) VALUES     (" & nFirmaID & ", '" & sAciklama & "', '" & dteBaslangic & "', '" & dteBitis & "')")
        cmd.ExecuteNonQuery()
        cmd.CommandText = "SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT @@identity"
        Dim hareketno = cmd.ExecuteScalar
        Return hareketno
    End Function
    Private Sub tbMarketSozlesmeMaster_kaydet_duzelt(ByVal nSozlesmeID As Int64, ByVal nFirmaID As String, ByVal sAciklama As String, ByVal dteBaslangic As DateTime, ByVal dteBitis As DateTime)
        Dim cmd As New OleDb.OleDbCommand
        Dim con As New OleDb.OleDbConnection
        cmd.Connection = con
        con.ConnectionString = connection
        cmd.CommandTimeout = Nothing
        If con.State = ConnectionState.Closed = True Then
            con.Open()
        End If
        cmd.CommandText = sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED UPDATE    tbMarketSozlesmeMaster SET               sAciklama = '" & sAciklama & "', dteBaslangic = '" & dteBaslangic & "', dteBitis = '" & dteBitis & "' where nSozlesmeID = " & nSozlesmeID & " ")
        cmd.ExecuteNonQuery()
        con.Close()
    End Sub
    Private Sub dataload_tbMarketSozlesmeDetayi(ByVal nSozlesmeID As Int64)
        Dim kriter = " "
        ds_tbMarketSozlesmeDetayi = sorgu(sorgu_query("SET DATEFORMAT DMY SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT tbTanim.nTip, tbTanim.nSira, tbTanim.sAciklama, tbTanim.sGrup, tbMarketSozlesmeDetayi.nKayitID, tbMarketSozlesmeDetayi.nSozlesmeID, tbMarketSozlesmeDetayi.sKod, tbMarketSozlesmeDetayi.nTaksit, tbMarketSozlesmeDetayi.lOran, tbMarketSozlesmeDetayi.nSinif, tbMarketSozlesmeDetayi.sSiniflandirma, tbMarketSozlesmeDetayi.sNot FROM tbMarketSozlesmeDetayi RIGHT OUTER JOIN (SELECT '01' AS nSira , 'Normal Iskonto %' AS sAciklama , 0 AS nTip , '0-Satinalma Kosulu' AS sGrup UNION ALL SELECT '02' AS nSira , 'Ozel Iskonto %' AS sAciklama , 0 AS nTip , '0-Satinalma Kosulu' AS sGrup UNION ALL SELECT '03' AS nSira , 'Pesin Iskonto %' AS sAciklama , 0 AS nTip , '0-Satinalma Kosulu' AS sGrup UNION ALL SELECT '04' AS nSira , 'Insert Iskonto %' AS sAciklama , 0 AS nTip , '0-Satinalma Kosulu' AS sGrup UNION ALL SELECT '05' AS nSira , 'Katilim Bedeli' AS sAciklama , 0 AS nTip , '0-Satinalma Kosulu' AS sGrup UNION ALL SELECT '06' AS nSira , 'Gondol Bedeli' AS sAciklama , 0 AS nTip , '0-Satinalma Kosulu' AS sGrup UNION ALL SELECT '07' AS nSira , 'Insert Bedeli' AS sAciklama , 0 AS nTip , '0-Satinalma Kosulu' AS sGrup UNION ALL SELECT '08' AS nSira , 'Palet Bedeli' AS sAciklama , 0 AS nTip , '0-Satinalma Kosulu' AS sGrup UNION ALL SELECT '09' AS nSira , 'Kasa Onu Bedeli' AS sAciklama , 0 AS nTip , '0-Satinalma Kosulu' AS sGrup UNION ALL SELECT '10' AS nSira , '1-Ciro Primi Aylik %' AS sAciklama , 1 AS nTip , '1-Ciro Primi' AS sGrup UNION ALL SELECT '11' AS nSira , '1-Ciro Primi 3 Aylik %' AS sAciklama , 1 AS nTip , '1-Ciro Primi' AS sGrup UNION ALL SELECT '12' AS nSira , '1-Ciro Primi Yillik %' AS sAciklama , 1 AS nTip , '1-Ciro Primi' AS sGrup UNION ALL SELECT '13' AS nSira , 'Acilis Iskontosu %' AS sAciklama , 2 AS nTip , '2-Acilis Uygulamalari' AS sGrup UNION ALL SELECT '14' AS nSira , 'Acilis Iskonto Suresi' AS sAciklama , 2 AS nTip , '2-Acilis Uygulamalari' AS sGrup UNION ALL SELECT '15' AS nSira , 'Acilis Iskonto Vadesi' AS sAciklama , 2 AS nTip , '2-Acilis Uygulamalari' AS sGrup UNION ALL SELECT '16' AS nSira , 'Acilis Katilim Bedeli' AS sAciklama , 2 AS nTip , '2-Acilis Uygulamalari' AS sGrup UNION ALL SELECT '17' AS nSira , 'Bedelsiz Urun' AS sAciklama , 3 AS nTip , '3-Promosyon' AS sGrup UNION ALL SELECT '18' AS nSira , '3-Promosyon Elemani' AS sAciklama , 3 AS nTip , '3-Promosyon' AS sGrup UNION ALL SELECT '19' AS nSira , 'Teslimat Suresi' AS sAciklama , 4 AS nTip , '4-Teslimat' AS sGrup UNION ALL SELECT '20' AS nSira , 'Iade Durumu' AS sAciklama , 4 AS nTip , '4-Teslimat' AS sGrup UNION ALL SELECT '21' AS nSira , 'Fiyat Listesi' AS sAciklama , 4 AS nTip , '4-Teslimat' AS sGrup UNION ALL SELECT '22' AS nSira , 'Fiyat Gecis Opsiyonu' AS sAciklama , 4 AS nTip , '4-Teslimat' AS sGrup) tbTanim ON tbMarketSozlesmeDetayi.nTip = tbTanim.nTip AND tbMarketSozlesmeDetayi.nSira = tbTanim.nSira AND tbMarketSozlesmeDetayi.nSozlesmeID = " & nSozlesmeID & " "))
        GridControl2.DataMember = Nothing
        GridControl2.DataSource = ds_tbMarketSozlesmeDetayi.Tables(0)
        GridView2.ExpandAllGroups()
    End Sub
    Private Sub dataload_tbMarketSozlesmeDetayiTakip(ByVal nDetayID As Int64)
        Dim kriter = " "
        ds_tbMarketSozlesmeDetayiTakip = sorgu(sorgu_query("SET DATEFORMAT DMY SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT     tbMarketSozlesmeDetayiTakip.*, tbAjanda.Tamamlandi FROM         tbMarketSozlesmeDetayiTakip LEFT OUTER JOIN                       aEmirAjanda tbAjanda ON tbMarketSozlesmeDetayiTakip.nGorevID = tbAjanda.ID Where tbMarketSozlesmeDetayiTakip.nDetayID = " & nDetayID & " "))
        GridControl3.DataMember = Nothing
        GridControl3.DataSource = ds_tbMarketSozlesmeDetayiTakip.Tables(0)
        GridView3.ExpandAllGroups()
    End Sub
    Private Sub dataload_tbMarketSozlesmeMaster()
        Dim kriter = " "
        ds_tbMarketSozlesmeMaster = sorgu(sorgu_query("SET DATEFORMAT DMY SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT tbMarketSozlesmeMaster.nSozlesmeID, tbMarketSozlesmeMaster.nFirmaID, tbFirma.sKodu AS sFirmaKodu, tbFirma.sAciklama AS sFirmaAciklama, tbMarketSozlesmeMaster.sAciklama, tbMarketSozlesmeMaster.dteBaslangic, tbMarketSozlesmeMaster.dteBitis FROM tbMarketSozlesmeMaster INNER JOIN tbFirma ON tbMarketSozlesmeMaster.nFirmaID = tbFirma.nFirmaID"))
        GridControl1.DataMember = Nothing
        GridControl1.DataSource = ds_tbMarketSozlesmeMaster.Tables(0)
        GridControl1.Focus()
        GridControl1.Select()
    End Sub
    Private Sub SimpleButton2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SimpleButton2.Click
        Me.Close()
    End Sub
    Private Sub SimpleButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SimpleButton1.Click
        If XtraTabControl1.SelectedTabPageIndex = 0 Then
            Me.Close()
        ElseIf XtraTabControl1.SelectedTabPageIndex = 1 Then
            XtraTabControl1.SelectedTabPageIndex = 0
            dataload_tbMarketSozlesmeMaster()
            GridControl1.Focus()
            GridControl1.Select()
        End If
    End Sub
    Private Sub BarButtonItem3_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem3.ItemClick
        gorunum_yazdir()
    End Sub
    Private Sub gorunum_yazdir()

        If XtraTabControl1.SelectedTabPageIndex = 0 Then
            printlink1.CreateDocument(ps)
            ps.PreviewRibbonFormEx.Show()
        ElseIf XtraTabControl1.SelectedTabPageIndex = 1 Then
            Dim kriter As String = ""
            kriter += "FirmaKodu: " & txt_musteriNo.Text & " \ Firma: " & lbl_Firma.Text & vbCrLf
            kriter += DateEdit1.EditValue.ToLongDateString & " ve " & DateEdit2.EditValue.ToLongDateString & " Tarihleri Arasındaki Satınalma Sözlesmesi" & vbCrLf
            kriter += txt_sAciklama.Text
            printlink2.PageHeaderFooter = New DevExpress.XtraPrinting.PageHeaderFooter(New DevExpress.XtraPrinting.PageHeaderArea(New String() {"[User Name]", kriter, "[Date Printed][Time Printed]"}, New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte)), DevExpress.XtraPrinting.BrickAlignment.Far), New DevExpress.XtraPrinting.PageFooterArea(New String() {"Powered by www.barkodyazilimevi.com", "Market Sözleşmeleri", "[Page # of Pages #]"}, New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte)), DevExpress.XtraPrinting.BrickAlignment.Near))
            printlink2.CreateDocument(ps)
            ps.PreviewRibbonFormEx.Show()
        End If
    End Sub
    Private Sub BarButtonItem1_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem1.ItemClick
        ekle()
    End Sub
    Private Sub ekle()
        Dim dr As DataRow
        dr = GridView1.GetDataRow(GridView1.FocusedRowHandle)
        Dim frm As New frm_firma_liste
        frm.firmano = firmano
        frm.donemno = donemno
        frm.connection = connection
        frm.islemstatus = True
        frm.kullanici = kullanici
        If frm.ShowDialog(Me) = Windows.Forms.DialogResult.OK Then
            Dim dr1 As DataRow
            'Dim nFirmaID As Int64
            Dim sFirmaKodu As String = ""
            Dim sFirmaAciklama As String = ""
            dr1 = frm.GridView1.GetDataRow(frm.GridView1.FocusedRowHandle)
            nFirmaID = dr1("nFirmaID")
            sFirmaKodu = dr1("sKodu")
            lbl_Firma.Text = Trim(dr1("sAciklama").ToString)
            sFirmaAciklama = Trim(dr1("sAciklama").ToString)
            txt_musteriNo.EditValue = sFirmaKodu
            DateEdit1.EditValue = Today
            DateEdit2.EditValue = Today
            txt_sAciklama.Text = ""
            Dim nSozlesmeID As Int64 = tbMarketSozlesmeMaster_kaydet_yeni(nFirmaID, "", Today, Today)
            txt_nSozlesmeID.Text = nSozlesmeID
            XtraTabControl1.SelectedTabPageIndex = 1
            dataload_tbMarketSozlesmeDetayi(nSozlesmeID)
            txt_musteriNo.Focus()
            txt_musteriNo.SelectAll()
            dr1 = Nothing
        End If
    End Sub
    Private Sub duzelt()
        If GridView1.RowCount > 0 Then
            Dim dr As DataRow
            dr = GridView1.GetDataRow(GridView1.FocusedRowHandle)
            txt_nSozlesmeID.Text = dr("nSozlesmeID")
            nFirmaID = dr("nFirmaID")
            txt_musteriNo.Text = dr("sFirmaKodu")
            txt_sAciklama.Text = dr("sAciklama")
            lbl_Firma.Text = dr("sFirmaAciklama")
            dataload_tbMarketSozlesmeDetayi(dr("nSozlesmeID"))
            DateEdit1.EditValue = dr("dteBaslangic")
            DateEdit2.EditValue = dr("dteBitis")
            XtraTabControl1.SelectedTabPageIndex = 1
        End If
    End Sub
    Private Sub BarButtonItem2_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem2.ItemClick
        duzelt()
    End Sub
    Private Sub GridControl1_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles GridControl1.DoubleClick
        duzelt()
    End Sub
    Private Sub GridView2_CellValueChanged(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs) Handles GridView2.CellValueChanged
        If GridView2.RowCount > 0 Then
            GridView2.PostEditor()
            Dim dr As DataRow
            dr = GridView2.GetDataRow(GridView2.FocusedRowHandle)
            dr.EndEdit()
            tutar_hesapla()
            Dim satir = GridView2.FocusedRowHandle
            dataload_tbMarketSozlesmeDetayi(txt_nSozlesmeID.Text)
            GridView2.FocusedRowHandle = satir
            satir = Nothing
        End If
    End Sub
    Private Sub baslik_degistir()
        tbMarketSozlesmeMaster_kaydet_duzelt(txt_nSozlesmeID.Text, txt_musteriNo.Text, txt_sAciklama.Text, DateEdit1.EditValue, DateEdit2.EditValue)
    End Sub
    Private Sub tutar_hesapla()
        If GridView2.RowCount > 0 Then
            Dim dr As DataRow = GridView2.GetDataRow(GridView2.FocusedRowHandle)
            dr("lOran") = sorgu_sayi(dr("lOran"), 0)
            dr("nTaksit") = sorgu_sayi(dr("nTaksit"), 0)
            If dr("lOran") <> 0 Or dr("nTaksit") <> 0 Then
                If sorgu_sDovizCinsi_kontrol(dr("nSira"), txt_nSozlesmeID.Text) = False Then
                    tbMarketSozlesmeDetayi_kaydet_duzelt(dr("nKayitID"), dr("nSozlesmeID"), dr("nTip"), dr("nSira"), dr("sKod"), dr("nTaksit"), dr("lOran"), dr("nSinif"), dr("sSiniflandirma"), dr("sNot"))
                Else
                    tbMarketSozlesmeDetayi_kaydet_yeni(txt_nSozlesmeID.Text, dr("nTip"), dr("nSira"), dr("sKod").ToString, sorgu_sayi(dr("nTaksit"), 0), sorgu_sayi(dr("lOran"), 0), sorgu_sayi(dr("nSinif"), 1), dr("sSiniflandirma").ToString, dr("sNot").ToString)
                End If
            Else
                If dr("nKayitID") > 0 Then
                    tbMarketSozlesmeDetayi_kaydet_sil(txt_nSozlesmeID.Text, dr("nKayitID"))
                End If
            End If
            'toplam_hesapla()
        End If
    End Sub
    Private Sub kayit_sil()
        If GridView1.RowCount > 0 Then
            If XtraMessageBox.Show(Sorgu_sDil("Kaydı Silmek İstediğinize Emin misiniz...?", sDil), Sorgu_sDil("Dikkat", sDil), MessageBoxButtons.YesNo, MessageBoxIcon.Question) = MsgBoxResult.Yes Then
                Dim dr As DataRow = GridView1.GetDataRow(GridView1.FocusedRowHandle)
                tbMarketSozlesmeMaster_kaydet_sil(dr("nSozlesmeID"))
                dataload_tbMarketSozlesmeMaster()
            End If
        End If
    End Sub
    Public Function sorgu_sDovizCinsi_kontrol(ByVal nSira As String, ByVal nSozlesmeID As Int64) As Boolean
        Dim kriter
        Dim pass As Boolean
        kriter = ""
        Dim conn As New OleDb.OleDbConnection
        Dim cmd As New OleDb.OleDbCommand
        Dim adapter As New OleDb.OleDbDataAdapter
        conn.ConnectionString = connection
        cmd.Connection = conn
        conn.Open()
        cmd.CommandText = sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT     COUNT(*) AS nKayit FROM         tbMarketSozlesmeDetayi WHERE     (nSira= '" & nSira & "') AND (nSozlesmeID = " & nSozlesmeID & ")")
        Dim kayitsayisi = cmd.ExecuteScalar
        If kayitsayisi = 0 Then
            pass = True
        Else
            pass = False
        End If
        Return pass
    End Function
    Private Function tbMarketSozlesmeDetayi_kaydet_yeni(ByVal nSozlesmeID As Int64, ByVal nTip As Integer, ByVal nSira As Integer, ByVal sKod As String, ByVal nTaksit As Int64, ByVal lOran As Decimal, ByVal nSinif As Integer, ByVal sSiniflandirma As String, ByVal sNot As String) As Int64
        Dim cmd As New OleDb.OleDbCommand
        Dim con As New OleDb.OleDbConnection
        cmd.Connection = con
        con.ConnectionString = connection
        If con.State = ConnectionState.Closed = True Then
            con.Open()
        End If
        cmd.CommandText = sorgu_query("SET DATEFORMAT DMY SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED INSERT INTO tbMarketSozlesmeDetayi                       (nSozlesmeID, nTip, nSira, sKod, nTaksit, lOran, nSinif, sSiniflandirma, sNot) VALUES     (" & nSozlesmeID & ", " & nTip & ", " & nSira & ", '" & sKod & "', " & nTaksit & ", " & lOran & ", " & nSinif & ", '" & sSiniflandirma & "', '" & sNot & "')")
        cmd.ExecuteNonQuery()
        cmd.CommandText = "SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT @@identity"
        Dim kayitno As Int64 = sorgu_sayi(cmd.ExecuteScalar, 0)
        cmd = Nothing
        con = Nothing
        Return kayitno
    End Function
    Private Sub tbMarketSozlesmeDetayi_kaydet_duzelt(ByVal nKayitID As Int64, ByVal nSozlesmeID As Int64, ByVal nTip As Integer, ByVal nSira As Integer, ByVal sKod As String, ByVal nTaksit As Int64, ByVal lOran As Decimal, ByVal nSinif As Integer, ByVal sSiniflandirma As String, ByVal sNot As String)
        Dim cmd As New OleDb.OleDbCommand
        Dim con As New OleDb.OleDbConnection
        cmd.Connection = con
        con.ConnectionString = connection
        If con.State = ConnectionState.Closed = True Then
            con.Open()
        End If
        cmd.CommandText = sorgu_query("SET DATEFORMAT DMY SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED UPDATE    tbMarketSozlesmeDetayi SET              sKod = '" & sKod & "', nTaksit = " & nTaksit & ", lOran = " & lOran & ", nSinif = " & nSinif & ", sSiniflandirma = '" & sSiniflandirma & "', sNot = '" & sNot & "' Where nSozlesmeID = " & nSozlesmeID & " and nKayitID = " & nKayitID & "")
        cmd.ExecuteNonQuery()
        con.Close()
        cmd = Nothing
        con = Nothing
    End Sub
    Private Sub tbMarketSozlesmeMaster_kaydet_sil(ByVal nSozlesmeID As Int64)
        Dim cmd As New OleDb.OleDbCommand
        Dim con As New OleDb.OleDbConnection
        cmd.Connection = con
        con.ConnectionString = connection
        If con.State = ConnectionState.Closed = True Then
            con.Open()
        End If
        cmd.CommandText = sorgu_query("SET DATEFORMAT DMY SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED DELETE FROM    tbMarketSozlesmeDetayi  Where nSozlesmeID = '" & nSozlesmeID & "'")
        cmd.ExecuteNonQuery()
        cmd.CommandText = sorgu_query("SET DATEFORMAT DMY SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED DELETE FROM    tbMarketSozlesmeMaster  Where nSozlesmeID = '" & nSozlesmeID & "'")
        cmd.ExecuteNonQuery()
        con.Close()
        cmd = Nothing
        con = Nothing
    End Sub
    Private Sub tbMarketSozlesmeDetayi_kaydet_sil(ByVal nSozlesmeID As Int64, ByVal nKayitID As Int64)
        Dim cmd As New OleDb.OleDbCommand
        Dim con As New OleDb.OleDbConnection
        cmd.Connection = con
        con.ConnectionString = connection
        If con.State = ConnectionState.Closed = True Then
            con.Open()
        End If
        cmd.CommandText = sorgu_query("SET DATEFORMAT DMY SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED DELETE FROM    tbMarketSozlesmeDetayi  Where nSozlesmeID = '" & nSozlesmeID & "' and nKayitID = '" & nKayitID & "'")
        cmd.ExecuteNonQuery()
        con.Close()
        cmd = Nothing
        con = Nothing
    End Sub
    Private Function tbMarketSozlesmeDetayiTakip_kaydet_yeni(ByVal nKayitID, ByVal nDetayID, ByVal nGorevID, ByVal dteTarihi, ByVal lTutar, ByVal sKullanici, ByVal dteSonUpdateTarihi) As Int64
        Dim cmd As New OleDb.OleDbCommand
        Dim con As New OleDb.OleDbConnection
        cmd.Connection = con
        con.ConnectionString = connection
        If con.State = ConnectionState.Closed = True Then
            con.Open()
        End If
        cmd.CommandText = sorgu_query("SET DATEFORMAT DMY SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED INSERT INTO tbMarketSozlesmeDetayiTakip                      ( nDetayID, nGorevID, dteTarihi, lTutar, sKullanici, dteSonUpdateTarihi) VALUES     ( " & nDetayID & ", " & nGorevID & ", '" & dteTarihi & "', " & lTutar & ",  '" & sKullanici & "',  '" & dteSonUpdateTarihi & "')")
        cmd.ExecuteNonQuery()
        cmd.CommandText = "SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT @@identity"
        Dim kayitno As Int64 = sorgu_sayi(cmd.ExecuteScalar, 0)
        cmd = Nothing
        con = Nothing
        Return kayitno
    End Function
    Private Sub tbMarketSozlesmeDetayiTakip_kaydet_duzelt(ByVal nKayitID As Int64, ByVal nDetayID As Int64, ByVal nGorevID As Int64, ByVal dteTarihi As DateTime, ByVal lTutar As Decimal, ByVal sKullanici As String, ByVal dteSonUpdateTarihi As DateTime)
        Dim cmd As New OleDb.OleDbCommand
        Dim con As New OleDb.OleDbConnection
        cmd.Connection = con
        con.ConnectionString = connection
        If con.State = ConnectionState.Closed = True Then
            con.Open()
        End If
        cmd.CommandText = sorgu_query("SET DATEFORMAT DMY SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED UPDATE    tbMarketSozlesmeDetayiTakip SET              dteTarihi = '" & dteTarihi & "', lTutar = " & lTutar & ",  sKullanici = '" & sKullanici & "',                        dteSonUpdateTarihi = '" & dteSonUpdateTarihi & "' Where  nKayitID = " & nKayitID & "")
        cmd.ExecuteNonQuery()
        con.Close()
        cmd = Nothing
        con = Nothing
    End Sub
    Private Sub tbMarketSozlesmeDetayiTakip_kaydet_sil(ByVal nDetayID As Int64, ByVal nKayitID As Int64)
        Dim cmd As New OleDb.OleDbCommand
        Dim con As New OleDb.OleDbConnection
        cmd.Connection = con
        con.ConnectionString = connection
        If con.State = ConnectionState.Closed = True Then
            con.Open()
        End If
        cmd.CommandText = sorgu_query("SET DATEFORMAT DMY SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED DELETE FROM    tbMarketSozlesmeDetayiTakip  Where nDetayID = '" & nDetayID & "' and nKayitID = '" & nKayitID & "'")
        cmd.ExecuteNonQuery()
        con.Close()
        cmd = Nothing
        con = Nothing
    End Sub
    Private Sub raporla_excel()
        If XtraMessageBox.Show(Sorgu_sDil("Sonuçları Excel Dosyası Oluşturmak İstediğinize Emin misiniz...?", sDil), Sorgu_sDil("Dikkat", sDil), MessageBoxButtons.YesNo, MessageBoxIcon.Question) = MsgBoxResult.Yes Then
            Dim SaveFileDialog1 As New Windows.Forms.SaveFileDialog
            SaveFileDialog1.Filter = "Excel Dosyaları(*.xls) |*.xls"
            SaveFileDialog1.InitialDirectory = "c:\"
            SaveFileDialog1.FileName = "Market_Sozlesme.xls"
            If SaveFileDialog1.ShowDialog = Windows.Forms.DialogResult.OK Then
                If XtraTabControl1.SelectedTabPageIndex = 0 Then
                    GridView1.ExportToXls(SaveFileDialog1.FileName.ToString)
                ElseIf XtraTabControl1.SelectedTabPageIndex = 1 Then
                    GridView2.ExportToXls(SaveFileDialog1.FileName.ToString)
                End If
                If XtraMessageBox.Show(Sorgu_sDil("Kaydı Açmak İster misiniz...?", sDil), Sorgu_sDil("Dikkat", sDil), MessageBoxButtons.YesNo, MessageBoxIcon.Question) = MsgBoxResult.Yes Then
                    Process.Start(SaveFileDialog1.FileName.ToString)
                End If
            End If
            SaveFileDialog1 = Nothing
        End If
    End Sub
    Private Sub raporla_pdf()
        If XtraMessageBox.Show(Sorgu_sDil("Sonuçları Mail Dosyası Oluşturmak İstediğinize Emin misiniz...?", sDil), Sorgu_sDil("Dikkat", sDil), MessageBoxButtons.YesNo, MessageBoxIcon.Question) = MsgBoxResult.Yes Then
            Dim SaveFileDialog1 As New Windows.Forms.SaveFileDialog
            SaveFileDialog1.Filter = "Mail Dosyaları(*.pdf) |*.pdf"
            SaveFileDialog1.InitialDirectory = "c:\"
            SaveFileDialog1.FileName = "Market_Sozlesme.pdf"
            If SaveFileDialog1.ShowDialog = Windows.Forms.DialogResult.OK Then
                If XtraTabControl1.SelectedTabPageIndex = 0 Then
                    GridView1.ExportToPdf(SaveFileDialog1.FileName.ToString)
                ElseIf XtraTabControl1.SelectedTabPageIndex = 1 Then
                    GridView2.ExportToPdf(SaveFileDialog1.FileName.ToString)
                End If
                If XtraMessageBox.Show(Sorgu_sDil("Kaydı Açmak İster misiniz...?", sDil), Sorgu_sDil("Dikkat", sDil), MessageBoxButtons.YesNo, MessageBoxIcon.Question) = MsgBoxResult.Yes Then
                    Process.Start(SaveFileDialog1.FileName.ToString)
                End If
            End If
            SaveFileDialog1 = Nothing
        End If
    End Sub
    Private Sub BarButtonItem5_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem5.ItemClick
        raporla_excel()
    End Sub
    Private Sub BarButtonItem4_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem4.ItemClick
        raporla_pdf()
    End Sub
    Private Sub txt_sAciklama_Validated(ByVal sender As Object, ByVal e As System.EventArgs) Handles txt_sAciklama.Validated
        baslik_degistir()
    End Sub
    Private Sub DateEdit1_Validated(ByVal sender As Object, ByVal e As System.EventArgs) Handles DateEdit1.Validated
        baslik_degistir()
    End Sub
    Private Sub DateEdit2_Validated(ByVal sender As Object, ByVal e As System.EventArgs) Handles DateEdit2.Validated
        baslik_degistir()
    End Sub
    Private Sub BarButtonItem6_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem6.ItemClick
        kayit_sil()
    End Sub
    Private Sub GroupControl3_Paint(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles GroupControl3.Paint
    End Sub
    Private Sub GridView2_FocusedRowChanged(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs) Handles GridView2.FocusedRowChanged
        If GridView2.RowCount > 0 Then
            Dim dr As DataRow = GridView2.GetDataRow(GridView2.FocusedRowHandle)
            dataload_tbMarketSozlesmeDetayiTakip(sorgu_sayi(dr("nKayitID"), 0))
            dr("nTaksit") = GridView3.RowCount
        End If
    End Sub
    Private Sub SimpleButton4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SimpleButton4.Click
        takip_ekle()
    End Sub
    Private Sub takip_ekle()
        If GridView2.RowCount > 0 Then
            Dim dr As DataRow = GridView2.GetDataRow(GridView2.FocusedRowHandle)
            If sorgu_sayi(dr("nKayitID"), 0) > 0 Then
                Dim nGorevID As Int64 = gorev_ekle(2, nFirmaID, lbl_Firma.Text, kullanici, 0, dr("sAciklama") & " " & FormatNumber(dr("lOran"), 2), lbl_Firma.Text & vbCrLf & dr("sAciklama") & " " & FormatNumber(dr("lOran"), 2) & vbCrLf & dr("sNot"), 1, dteSistemTarihi & " " & "08:00:00", dteSistemTarihi & " " & "09:00:00", "Market Sözleşmesi " & txt_nSozlesmeID.Value, 0, 0, "", "", 0, "", 0, 0, 0)
                tbMarketSozlesmeDetayiTakip_kaydet_yeni(0, dr("nKayitID"), nGorevID, dteSistemTarihi, 0, kullaniciadi, Now)
                dataload_tbMarketSozlesmeDetayiTakip(sorgu_sayi(dr("nKayitID"), 0))
            End If
        End If
    End Sub
    Private Function gorev_ekle(ByVal FirmaTipi As Integer, ByVal FirmaNo As String, ByVal Firma As String, ByVal PersonelNo As Int64, ByVal Status As Integer, ByVal Subject As String, ByVal Description As String, ByVal Label As Integer, ByVal StartTime As DateTime, ByVal EndTime As DateTime, ByVal Location As String, ByVal AllDay As Byte, ByVal EventType As Integer, ByVal RecurrenceInfo As String, ByVal ReminderInfo As String, ByVal Tutar As Decimal, ByVal Pb As String, ByVal Odendi As Byte, ByVal Gelecekmi As Byte, ByVal Tamamlandi As Byte) As Int64
        Dim cmd As New OleDb.OleDbCommand
        Dim con As New OleDb.OleDbConnection
        cmd.Connection = con
        con.ConnectionString = connection
        If con.State = ConnectionState.Closed = True Then
            con.Open()
        End If
        cmd.CommandText = sorgu_query("SET DATEFORMAT DMY INSERT INTO aEmirAjanda                       (FirmaTipi, FirmaNo, Firma, PersonelNo, Status, Subject, Description, Label, StartTime, EndTime, Location, AllDay, EventType, RecurrenceInfo, ReminderInfo, Tutar, Pb, Odendi, Gelecekmi, Tamamlandi) VALUES     (" & FirmaTipi & ", '" & FirmaNo & "', '" & Firma & "', '" & PersonelNo & "', " & Status & ", '" & Subject & "', '" & Description & "', " & Label & ", '" & StartTime & "', '" & EndTime & "', '" & Location & "', " & AllDay & ", " & EventType & ", NULL,NULL, " & Tutar & ", '" & Pb & "', " & Odendi & ", " & Gelecekmi & ", " & Tamamlandi & ")")
        cmd.ExecuteNonQuery()
        cmd.CommandText = "SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT @@identity"
        Dim kayitno As Int64 = sorgu_sayi(cmd.ExecuteScalar, 0)
        cmd = Nothing
        con = Nothing
        Return kayitno
    End Function
    Private Sub gorev_duzelt(ByVal ID As Int64, ByVal FirmaTipi As Integer, ByVal FirmaNo As String, ByVal Firma As String, ByVal PersonelNo As Int64, ByVal Status As Integer, ByVal Subject As String, ByVal Description As String, ByVal Label As Integer, ByVal StartTime As DateTime, ByVal EndTime As DateTime, ByVal Location As String, ByVal AllDay As Byte, ByVal EventType As Integer, ByVal RecurrenceInfo As String, ByVal ReminderInfo As String, ByVal Tutar As Decimal, ByVal Pb As String, ByVal Odendi As Byte, ByVal Gelecekmi As Byte, ByVal Tamamlandi As Byte)
        Dim cmd As New OleDb.OleDbCommand
        Dim con As New OleDb.OleDbConnection
        cmd.Connection = con
        con.ConnectionString = connection
        If con.State = ConnectionState.Closed = True Then
            con.Open()
        End If

        cmd.CommandText = sorgu_query("SET DATEFORMAT DMY UPDATE    aEmirAjanda SET              FirmaTipi = " & FirmaTipi & ", FirmaNo = '" & FirmaNo & "', Firma = '" & Firma & "', PersonelNo = " & PersonelNo & ", Status = " & Status & ", Subject = '" & Subject & "', Description = '" & Description & "', StartTime = '" & StartTime & "', EndTime = '" & EndTime & "', Location = '" & Location & "', AllDay = " & AllDay & ", EventType = " & EventType & ",   Tutar = " & Tutar & ", Pb = '" & Pb & "', Odendi = " & Odendi & ", Gelecekmi = " & Gelecekmi & "  WHERE ID= '" & ID & "'")
        cmd.ExecuteNonQuery()
        con.Close()
        cmd = Nothing
        con = Nothing
    End Sub
    Private Sub gorev_sil(ByVal ID As Int64)
        Dim cmd As New OleDb.OleDbCommand
        Dim con As New OleDb.OleDbConnection
        cmd.Connection = con
        con.ConnectionString = connection
        If con.State = ConnectionState.Closed = True Then
            con.Open()
        End If
        cmd.CommandText = sorgu_query("SET DATEFORMAT DMY Delete from FROM         tbMarketSozlesmeDetayiTakip WHERE     (nGorevID = 39)")
        cmd.ExecuteNonQuery()
        cmd.CommandText = sorgu_query("SET DATEFORMAT DMY DELETE FROM    aEmirAjanda  WHERE ID= '" & ID & "'")
        cmd.ExecuteNonQuery()
        con.Close()
        cmd = Nothing
        con = Nothing
    End Sub
    Private Sub GridView3_CellValueChanged(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs) Handles GridView3.CellValueChanged
        If GridView3.RowCount > 0 Then
            Dim dr As DataRow = GridView3.GetDataRow(GridView3.FocusedRowHandle)
            Dim dr1 As DataRow = GridView2.GetDataRow(GridView2.FocusedRowHandle)
            tbMarketSozlesmeDetayiTakip_kaydet_duzelt(dr("nKayitID"), dr("nDetayID"), dr("nGorevID"), dr("dteTarihi"), dr("lTutar"), dr("sKullanici"), Now)
            gorev_duzelt(dr("nGorevID"), 2, nFirmaID, lbl_Firma.Text, kullanici, 0, dr1("sAciklama") & " " & FormatNumber(dr1("lOran"), 2), lbl_Firma.Text & vbCrLf & dr1("sAciklama") & " " & FormatNumber(dr1("lOran"), 2) & vbCrLf & dr1("sNot"), 1, dr("dteTarihi") & " " & "08:00:00", dr("dteTarihi") & " " & "09:00:00", "Market Sözleşmesi " & txt_nSozlesmeID.Value, 0, 0, "", "", dr("lTutar"), "", 0, 0, 0)
        End If
    End Sub
    Private Sub SimpleButton3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SimpleButton3.Click
        If GridView3.RowCount > 0 Then
            Dim dr As DataRow = GridView3.GetDataRow(GridView3.FocusedRowHandle)
            Dim dr1 As DataRow = GridView2.GetDataRow(GridView2.FocusedRowHandle)
            gorev_sil(dr("nGorevID"))
            tbMarketSozlesmeDetayiTakip_kaydet_sil(dr("nDetayID"), dr("nKayitID"))
            dataload_tbMarketSozlesmeDetayiTakip(sorgu_sayi(dr1("nKayitID"), 0))
        End If
    End Sub
    Private Sub GridControl3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GridControl3.Click
    End Sub
End Class