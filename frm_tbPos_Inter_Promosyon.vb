Imports System.IO
Imports DevExpress.XtraGrid
Imports DevExpress.XtraEditors
Imports DevExpress.XtraGrid.Columns
Public Class frm_tbPos_Inter_Promosyon
    Public sPath As String
    Public sFile As String
    Public nIlkKasa As Integer
    Public nSonKasa As Integer
    Public firmano As Integer
    Public donemno As Integer
    Public connection As String
    Public kullanici As String
    Public sIslem As String = "Ekle"
    Public islem As String = "Ekle"
    Public islemNo As String = "1"
    Private Sub SimpleButton2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SimpleButton2.Click
        Me.Close()
    End Sub
    Private Sub SimpleButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SimpleButton1.Click
        Me.Close()
    End Sub
    Private Sub Label2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label2.Click
    End Sub
    Private Sub frm_tbPos_Inter_Promosyon_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        dataload_Reyon()
        dataload_Grup()
        dataload_OzelKod()
        sec_sPromosyonKodu.EditValue = "1"
        sec_p1_dteTarih1.EditValue = "01/01/1900"
        sec_p1_dteTarih2.EditValue = "31/12/2078"
        sec_p2_dteTarih1.EditValue = "01/01/1900"
        sec_p2_dteTarih2.EditValue = "31/12/2078"
        sec_p3_dteTarih1.EditValue = "01/01/1900"
        sec_p3_dteTarih2.EditValue = "31/12/2078"
        sec_p4_dteTarih1.EditValue = "01/01/1900"
        sec_p4_dteTarih2.EditValue = "31/12/2078"
        sec_p5_dteTarih1.EditValue = "01/01/1900"
        sec_p5_dteTarih2.EditValue = "31/12/2078"
        sec_p6_dteTarih1.EditValue = "01/01/1900"
        sec_p6_dteTarih2.EditValue = "31/12/2078"
        sec_p7_dteTarih1.EditValue = "01/01/1900"
        sec_p7_dteTarih2.EditValue = "31/12/2078"
        sec_pk_dteTarih1.EditValue = "01/01/1900"
        sec_pk_dteTarih2.EditValue = "31/12/2078"
        ara()
    End Sub
    Private Sub ara()
        Label2.Text = Sorgu_sDil("Lütfen Bekleyiniz...", sDil)
        Label2.Refresh()
        dataload_tbPromosyon()
        GridControl1.Focus()
        GridControl1.Select()
        Label2.Text = Sorgu_sDil("Tamamlandý...", sDil)
    End Sub
    Private Sub gorunum_kaydet()
        GridView1.SaveLayoutToRegistry("SOFTWARE\BusinessSmart\VIEW\MAGAZA\" & Me.Name.ToString & "")
        XtraMessageBox.Show(Sorgu_sDil("Görünüm Kaydedildi", sDil), Sorgu_sDil("Dikkat", sDil), MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub
    Private Sub gorunum_yazdir()
        Dim kriter As String = ""
        kriter += "PromosyonKodu: " & sec_sPromosyonKodu.Text & " : " & lbl_sPromosyonAciklama.Text & vbCrLf
        kriter += "Ýnter Satýþ Promosyonlarý"
        Me.printlink1.PageHeaderFooter = New DevExpress.XtraPrinting.PageHeaderFooter(New DevExpress.XtraPrinting.PageHeaderArea(New String() {"[User Name]", kriter, "[Date Printed][Time Printed]"}, New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte)), DevExpress.XtraPrinting.BrickAlignment.Center), New DevExpress.XtraPrinting.PageFooterArea(New String() {"Powered by www.barkodyazilimevi.com", "Market Managment-Market Yönetimi", "[Page # of Pages #]"}, New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte)), DevExpress.XtraPrinting.BrickAlignment.Near))
        printlink1.CreateDocument(ps)
        ps.PreviewRibbonFormEx.Show()
    End Sub
    Private Sub gorunum_yukle()
        Try
        Catch ex As Exception
        End Try
        Try
            If nFontSize > 0 Then
                Dim sayi As Single = nFontSize
                GridView1.Appearance.Row.Font = New System.Drawing.Font("Tahoma", sayi, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
                GridView1.Appearance.FooterPanel.Font = New System.Drawing.Font("Tahoma", sayi, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
                GridView1.Appearance.HeaderPanel.Font = New System.Drawing.Font("Tahoma", sayi, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
                'VGrid_Baslik.Appearance.RecordValue.Font = New System.Drawing.Font("Tahoma", sayi, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
                sayi = Nothing
            End If
        Catch ex As Exception
        End Try
        For Each btn As DevExpress.XtraBars.BarItem In BarManager1.Items
            btn.Caption = Sorgu_sDil(btn.Caption, sDil)
        Next
        For Each clmn As DevExpress.XtraGrid.Columns.GridColumn In GridView1.Columns
            clmn.Caption = Sorgu_sDil(clmn.Caption, sDil)
        Next
        SimpleButton1.Text = Sorgu_sDil(SimpleButton1.Text, sDil)
        SimpleButton2.Text = Sorgu_sDil(SimpleButton2.Text, sDil)
        SimpleButton3.Text = Sorgu_sDil(SimpleButton3.Text, sDil)
        GridView1.RestoreLayoutFromRegistry("SOFTWARE\BusinessSmart\VIEW\MAGAZA\" & Me.Name.ToString & "")
    End Sub
    Private Sub dataload_Reyon()
        sec_p6_ReyonKodu.Properties.DataSource = sorgu(sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT     sSinifKodu, sAciklama FROM         tbSSinif5 ORDER BY sSinifKodu")).Tables(0) 'DataSet2.Tables(0)
    End Sub
    Private Sub dataload_Grup()
        sec_p7_GrupKodu.Properties.DataSource = sorgu(sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT     sSinifKodu, sAciklama FROM         tbSSinif6 ORDER BY sSinifKodu")).Tables(0) 'DataSet2.Tables(0)
    End Sub
    Private Sub dataload_OzelKod()
        sec_p9_OzelKodu.Properties.DataSource = sorgu(sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT     sSinifKodu, sAciklama FROM         tbSSinif7 ORDER BY sSinifKodu")).Tables(0) 'DataSet2.Tables(0)
    End Sub
    Private Sub dataload_tbPromosyon()
        Dim kriter = " AND (tbStok.sKodu <> '') "
        ds_Promosyon = sorgu(sorgu_query("SET DATEFORMAT DMY SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT Promosyon.*, KarsiStok.sKodu AS sKarsiStokKodu, KarsiStok.sAciklama AS sKarsiStokAciklama, Stok.sKodu AS sStokKodu, Stok.sAciklama AS sStokAciklama, Stok.sModel AS sModel, Stok.sRenk AS sRenk, tbRenk.sRenkAdi AS sRenkAdi, Stok.sBeden AS sBeden, Stok.sKavala AS sKavala FROM tbRenk INNER JOIN tbStok Stok ON tbRenk.sRenk = Stok.sRenk RIGHT OUTER JOIN BTBLINTERPROMOSYON Promosyon LEFT OUTER JOIN tbStok KarsiStok ON Promosyon.sKarsiPlu = RIGHT (KarsiStok.nStokID, 6) ON RIGHT (Stok.nStokID, 6) = Promosyon.sPlu ORDER BY Promosyon.sPromosyonKodu, Promosyon.sOdemeKodu,Promosyon.sMusteriTipi,Promosyon.sStokKodu, Promosyon.sOzelKod, Promosyon.lLimit DESC,Promosyon.bAktif DESC"))
        GridControl1.DataMember = Nothing
        GridControl1.DataSource = ds_Promosyon.Tables(0)
    End Sub
    Private Function sorgu(ByVal query As String) As DataSet
        Dim conn As New OleDb.OleDbConnection
        Dim cmd As New OleDb.OleDbCommand
        Dim adapter As New OleDb.OleDbDataAdapter
        conn.ConnectionString = connection
        adapter.SelectCommand = cmd
        cmd.CommandText = query
        cmd.Connection = conn
        conn.Open()
        Dim DS As New DataSet
        Dim N As Integer = adapter.Fill(DS, "TABLE1")
        conn.Close()
        Return DS
        cmd = Nothing
        adapter = Nothing
    End Function
    Private Function sorgu_kriter_string(ByVal deger As String, ByVal kriter As String) As String
        Dim sorgu_kriter As String = ""
        If kriter = "Baþlar" Then
            sorgu_kriter = " LIKE '" & deger & "%' "
        ElseIf kriter = "Biter" Then
            sorgu_kriter = " LIKE '%" & deger & "' "
        ElseIf kriter = "Ýçerir" Then
            sorgu_kriter = " LIKE '%" & deger & "%' "
        ElseIf kriter = "Boþ" Then
            sorgu_kriter = " IS NULL "
        ElseIf kriter = "Dolu" Then
            sorgu_kriter = " <> '' "
        ElseIf kriter = "Farklý" Then
            sorgu_kriter = " <> '" & deger & "' "
        ElseIf kriter = "Büyük" Then
            sorgu_kriter = " >  '" & deger & "' "
        ElseIf kriter = "Küçük" Then
            sorgu_kriter = " < '" & deger & "' "
        ElseIf kriter = "Eþittir" Then
            sorgu_kriter = " = '" & deger & "' "
        End If
        Return sorgu_kriter
    End Function
    Private Function sorgu_query(ByVal query As String) As String
        query = Replace(query, "*!F", "F0" + firmano.ToString)
        query = Replace(query, "!D", "D000" + donemno.ToString)
        Return query
    End Function
    Private Sub firma_sec(Optional ByVal islem As Integer = 0)
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
            dr1 = frm.GridView1.GetDataRow(frm.GridView1.FocusedRowHandle)
            'nFirmaID = dr1("nFirmaID")
            'sFirmaKodu = dr1("sKodu")
            'lbl_Firma.Text = Trim(dr1("sAciklama").ToString)
            'sFirmaAciklama = Trim(dr1("sAciklama").ToString)
            'txt_musteriNo.EditValue = sFirmaKodu
            dr1 = Nothing
        End If
    End Sub
    Private Sub stok_sec(Optional ByVal islem As Integer = 0)
        Dim dr As DataRow
        dr = GridView1.GetDataRow(GridView1.FocusedRowHandle)
        Dim frm As New frm_stok
        frm.firmano = firmano
        frm.donemno = donemno
        frm.connection = connection
        frm.islemstatus = True
        frm.kullanici = kullanici
        If frm.ShowDialog(Me) = Windows.Forms.DialogResult.OK Then
            Dim dr1 As DataRow
            dr1 = frm.GridView1.GetDataRow(frm.GridView1.FocusedRowHandle)
            If islem = 1 Then
            ElseIf islem = 2 Then
                sec_p2_sPlu.Text = Microsoft.VisualBasic.Right(dr1("nStokID"), 6)
                sec_p2_sPluAciklama.Text = Trim(dr1("sAciklama").ToString)
            ElseIf islem = 3 Then
                sec_p3_sPlu.Text = Microsoft.VisualBasic.Right(dr1("nStokID"), 6)
                sec_p3_sPluAciklama.Text = Trim(dr1("sAciklama").ToString)
            ElseIf islem = 4 Then
                sec_p3_sKarsiPlu.Text = Microsoft.VisualBasic.Right(dr1("nStokID"), 6)
                sec_p3_sKarsiPluAciklama.Text = Trim(dr1("sAciklama").ToString)
            ElseIf islem = 5 Then
                sec_p4_sPlu.Text = Microsoft.VisualBasic.Right(dr1("nStokID"), 6)
                sec_p4_sPluAciklama.Text = Trim(dr1("sAciklama").ToString)
            ElseIf islem = 6 Then
                sec_pk_sPlu.Text = Microsoft.VisualBasic.Right(dr1("nStokID"), 6)
                sec_pk_sPluAciklama.Text = Trim(dr1("sAciklama").ToString)
            ElseIf islem = 7 Then
                sec_p7_sKarsiPlu.Text = Microsoft.VisualBasic.Right(dr1("nStokID"), 6)
                sec_p7_sKarsiPluAciklama.Text = Trim(dr1("sAciklama").ToString)
            ElseIf islem = 8 Then
            End If
            'nStokID = dr1("nStokID")
            'sFirmaKodu = dr1("sKodu")
            'lbl_Firma.Text = Trim(dr1("sAciklama").ToString)
            'sFirmaAciklama = Trim(dr1("sAciklama").ToString)
            'txt_musteriNo.EditValue = sFirmaKodu
            dr1 = Nothing
        End If
    End Sub
    Private Sub tbPromosyon_kaydet_yeni(ByVal sPromosyonKodu As String, ByVal sAciklama As String, ByVal sMusteriTipi As String, ByVal sOdemeKodu As String, ByVal sKdvTipi As String, ByVal sPlu As String, ByVal sKarsiPlu As String, ByVal sMusteriKodu As String, ByVal sOzelKod As String, ByVal lMiktar As Decimal, ByVal lFiyat As Decimal, ByVal lTutar As Decimal, ByVal lLimit As Decimal, ByVal nIskontoYuzdesi As Decimal, ByVal lIskontoTutari As Decimal, ByVal dteTarih1 As DateTime, ByVal dteTarih2 As DateTime, ByVal bAktif As Int16)
        Dim cmd As New OleDb.OleDbCommand
        Dim con As New OleDb.OleDbConnection
        cmd.Connection = con
        con.ConnectionString = connection
        cmd.CommandTimeout = Nothing
        If con.State = ConnectionState.Closed = True Then
            con.Open()
        End If
        cmd.CommandText = sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED INSERT INTO BTBLINTERPROMOSYON                       (sPromosyonKodu, sAciklama, sMusteriTipi, sOdemeKodu, sKdvTipi, sPlu, sKarsiPlu, sMusteriKodu, sOzelKod, lMiktar, lFiyat, lTutar, lLimit, nIskontoYuzdesi, lIskontoTutari, dteTarih1, dteTarih2, bAktif) VALUES     ('" & sPromosyonKodu & "', '" & sAciklama & "', '" & sMusteriTipi & "', '" & sOdemeKodu & "', '" & sKdvTipi & "', '" & sPlu & "', '" & sKarsiPlu & "', '" & sMusteriKodu & "', '" & sOzelKod & "', " & lMiktar & ", " & lFiyat & ", " & lTutar & ", " & lLimit & ", " & nIskontoYuzdesi & ", " & lIskontoTutari & ", '" & dteTarih1 & "', '" & dteTarih2 & "', " & bAktif & ")")
        cmd.ExecuteNonQuery()
        con.Close()
    End Sub
    Private Sub tbStokTedarikcisi_kaydet_kopyala(ByVal nFirmaID As Int64, ByVal nYeniFirmaID As Int64, Optional ByVal bFirma As Boolean = True)
        Dim cmd As New OleDb.OleDbCommand
        Dim con As New OleDb.OleDbConnection
        cmd.Connection = con
        con.ConnectionString = connection
        cmd.CommandTimeout = Nothing
        If con.State = ConnectionState.Closed = True Then
            con.Open()
        End If
        If bFirma = True Then
            cmd.CommandText = sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED INSERT INTO tbProtokol SELECT " & nYeniFirmaID & " AS nFirmaID, nMusteriID, nStokID, sFiyatTipi, sDovizCinsi, sHangiKur, nKdvOrani, lFiyat, nIskontoYuzdesi1, nIskontoYuzdesi2, nIskontoYuzdesi3, nIskontoYuzdesi4 FROM tbProtokol WHERE (nFirmaID = " & nFirmaID & ") and nStokID NOT IN (Select nStokID from tbProtokol where nFirmaID = " & nYeniFirmaID & ")")
            cmd.ExecuteNonQuery()
        Else
            cmd.CommandText = sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED INSERT INTO tbProtokol SELECT nFirmaID, nMusteriID, " & nYeniFirmaID & ", sFiyatTipi, sDovizCinsi, sHangiKur, nKdvOrani, lFiyat, nIskontoYuzdesi1, nIskontoYuzdesi2, nIskontoYuzdesi3, nIskontoYuzdesi4 FROM tbProtokol WHERE (nStokID = " & nFirmaID & ") and nFirmaID NOT IN (Select nFirmaID from tbProtokol where nStokID = " & nYeniFirmaID & ")")
            cmd.ExecuteNonQuery()
        End If
        con.Close()
    End Sub
    Private Sub tbPromosyon_kaydet_degistir(ByVal nKayitID As Int64, ByVal sPromosyonKodu As String, ByVal sAciklama As String, ByVal sMusteriTipi As String, ByVal sOdemeKodu As String, ByVal sKdvTipi As String, ByVal sPlu As String, ByVal sKarsiPlu As String, ByVal sMusteriKodu As String, ByVal sOzelKod As String, ByVal lMiktar As Decimal, ByVal lFiyat As Decimal, ByVal lTutar As Decimal, ByVal lLimit As Decimal, ByVal nIskontoYuzdesi As Decimal, ByVal lIskontoTutari As Decimal, ByVal dteTarih1 As DateTime, ByVal dteTarih2 As DateTime, ByVal bAktif As Int16)
        Dim cmd As New OleDb.OleDbCommand
        Dim con As New OleDb.OleDbConnection
        cmd.Connection = con
        con.ConnectionString = connection
        cmd.CommandTimeout = Nothing
        If con.State = ConnectionState.Closed = True Then
            con.Open()
        End If
        cmd.CommandText = sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED UPDATE    BTBLINTERPROMOSYON SET                sMusteriTipi = '" & sMusteriTipi & "', sOdemeKodu = '" & sOdemeKodu & "', sKdvTipi = '" & sKdvTipi & "', sPlu = '" & sPlu & "', sKarsiPlu = '" & sKarsiPlu & "', sMusteriKodu = '" & sMusteriKodu & "', sOzelKod = '" & sOzelKod & "', lMiktar = " & lMiktar & ", lFiyat = " & lFiyat & ", lTutar = " & lTutar & ", lLimit = " & lLimit & ", nIskontoYuzdesi = " & nIskontoYuzdesi & ", lIskontoTutari = " & lIskontoTutari & ", dteTarih1 = '" & dteTarih1 & "', dteTarih2 = '" & dteTarih2 & "', bAktif = " & bAktif & "  Where nKayitID = " & nKayitID & " AND sPromosyonKodu = '" & sPromosyonKodu & "' ")
        cmd.ExecuteNonQuery()
        con.Close()
    End Sub
    Private Sub tbStokTedarikcisi_kaydet_sil(ByVal nKayitID As Int64, ByVal sPromosyonKodu As String)
        Dim cmd As New OleDb.OleDbCommand
        Dim con As New OleDb.OleDbConnection
        cmd.Connection = con
        con.ConnectionString = connection
        cmd.CommandTimeout = Nothing
        If con.State = ConnectionState.Closed = True Then
            con.Open()
        End If
        cmd.CommandText = sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED DELETE FROM BTBLINTERPROMOSYON Where nKayitID = '" & nKayitID & "' AND sPromosyonKodu = '" & sPromosyonKodu & "' ")
        cmd.ExecuteNonQuery()
        con.Close()
    End Sub
    Public Function sorgu_ntbStokTedarikcisi(ByVal nFirmaID As String, ByVal nStokID As String) As Int64
        'kriter = "WHERE (sKodu = '" & kod & "')  "
        Dim conn As New OleDb.OleDbConnection
        Dim cmd As New OleDb.OleDbCommand
        Dim adapter As New OleDb.OleDbDataAdapter
        'MsgBox(connection_resmi)
        conn.ConnectionString = connection
        cmd.Connection = conn
        conn.Open()
        cmd.CommandText = sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT     COUNT(*) AS nKayit FROM         tbProtokol WHERE     (nFirmaID = " & nFirmaID & ") AND (nStokID = " & nStokID & ")")
        Dim kayitsayisi = cmd.ExecuteScalar
        Return kayitsayisi
    End Function
    Private Sub GridView1_CustomDrawRowIndicator(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Grid.RowIndicatorCustomDrawEventArgs) Handles GridView1.CustomDrawRowIndicator
        If e.RowHandle >= 0 Then
            e.Info.DisplayText = e.RowHandle + 1
        Else
            e.Info.DisplayText = ""
        End If
    End Sub
    Private Sub SimpleButton3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SimpleButton3.Click
        XtraTabControl2.Visible = True
        XtraTabControl1.Visible = True
        XtraTabPage1.PageVisible = True
        XtraTabPage2.PageVisible = False
        XtraTabControl1.Focus()
        XtraTabControl1.Select()
        XtraTabControl1.SelectedTabPage = XtraTabPage1
        GridControl1.Focus()
        GridControl1.Select()
    End Sub
    Private Sub MenuItem13_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem13.Click
        satir_ekle(1)
    End Sub
    Private Sub satir_ekle(Optional ByVal iNo As String = "1", Optional ByVal islem As String = "Ekle")
        islemNo = iNo
        XtraTabControl1.Visible = True
        XtraTabControl2.Visible = True
        XtraTabPage1.PageVisible = False
        XtraTabPage2.PageVisible = True
        TabP1.PageVisible = False
        TabP2.PageVisible = False
        TabP3.PageVisible = False
        TabP6.PageVisible = False
        TabP5.PageVisible = False
        TabP4.PageVisible = False
        TabP7.PageVisible = False
        TabP8.PageVisible = False
        TabP9.PageVisible = False
        TabPK.PageVisible = False
        If iNo = "1" Then
            TabP1.PageVisible = True
            XtraTabControl2.SelectedTabPage = TabP1
        ElseIf iNo = "2" Then
            TabP2.PageVisible = True
            XtraTabControl2.SelectedTabPage = TabP2
        ElseIf iNo = "3" Then
            TabP3.PageVisible = True
            XtraTabControl2.SelectedTabPage = TabP3
        ElseIf iNo = "4" Then
            TabP4.PageVisible = True
            XtraTabControl2.SelectedTabPage = TabP4
        ElseIf iNo = "5" Then
            TabP5.PageVisible = True
            XtraTabControl2.SelectedTabPage = TabP5
        ElseIf iNo = "6" Then
            TabP6.PageVisible = True
            XtraTabControl2.SelectedTabPage = TabP6
        ElseIf iNo = "7" Then
            TabP7.PageVisible = True
            XtraTabControl2.SelectedTabPage = TabP7
        ElseIf iNo = "8" Then
            TabP8.PageVisible = True
            XtraTabControl2.SelectedTabPage = TabP8
        ElseIf iNo = "9" Then
            TabP9.PageVisible = True
            XtraTabControl2.SelectedTabPage = TabP9
        ElseIf iNo = "K" Then
            TabPK.PageVisible = True
            XtraTabControl2.SelectedTabPage = TabPK
        End If
    End Sub
    Private Sub MenuItem19_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem19.Click
        satir_ekle(2)
    End Sub
    Private Sub MenuItem30_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem30.Click
        satir_ekle(3)
    End Sub
    Private Sub MenuItem31_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem31.Click
        satir_ekle(4)
    End Sub
    Private Sub MenuItem32_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem32.Click
        satir_ekle(5)
    End Sub
    Private Sub MenuItem33_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem33.Click
        satir_ekle(6)
    End Sub
    Private Sub MenuItem34_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem34.Click
        satir_ekle(7)
    End Sub
    Private Sub MenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem1.Click
        GridView1.ColumnsCustomization()
    End Sub
    Private Sub MenuItem3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem3.Click
        gorunum_kaydet()
    End Sub
    Private Sub MenuItem4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem4.Click
        gorunum_yazdir()
    End Sub
    Private Sub MenuItem23_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem23.Click
        If MenuItem23.Checked = False Then
            GridView1.OptionsView.ShowAutoFilterRow = True
            GridView1.OptionsView.ShowFilterPanelMode = DevExpress.XtraGrid.Views.Base.ShowFilterPanelMode.Default
            GridView1.OptionsCustomization.AllowFilter = True
            MenuItem23.Checked = True
        ElseIf MenuItem23.Checked = True Then
            GridView1.OptionsView.ShowAutoFilterRow = False
            GridView1.OptionsView.ShowFilterPanelMode = DevExpress.XtraGrid.Views.Base.ShowFilterPanelMode.Never
            GridView1.OptionsCustomization.AllowFilter = False
            MenuItem23.Checked = True
        End If
    End Sub
    Private Sub MenuItem5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem5.Click
        GridView1.OptionsView.ShowFilterPanelMode = DevExpress.XtraGrid.Views.Base.ShowFilterPanelMode.Default
        GridView1.OptionsCustomization.AllowFilter = True
    End Sub
    Private Sub MenuItem6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem6.Click
        GridView1.OptionsView.ShowGroupPanel = True
        GridView1.OptionsCustomization.AllowGroup = True
    End Sub
    Private Sub MenuItem7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem7.Click
        GridView1.ExpandAllGroups()
    End Sub
    Private Sub MenuItem8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem8.Click
        GridView1.CollapseAllGroups()
    End Sub
    Private Sub MenuItem9_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem9.Click
        If Me.WindowState = FormWindowState.Normal Then
            Me.WindowState = FormWindowState.Maximized
        ElseIf Me.WindowState = FormWindowState.Maximized Then
            Me.WindowState = FormWindowState.Normal
        End If
    End Sub
    Private Sub kaydet()
        If islem = "Ekle" Then
            If islemNo = "1" Then
                tbPromosyon_kaydet_yeni("P1", "Tutar Ýndirimi", sec_p1_sMusteri.Text, sec_p1_sOdemeSekli.Text, "", "", "", sec_P1_Musteriler.Text, "", 0, 0, 0, sec_p1_lLimit.EditValue, sec_p1_nIskontoYuzdesi.EditValue, sec_p1_lIskontoTutari.EditValue, sec_p1_dteTarih1.EditValue, sec_p2_dteTarih2.EditValue, 1)
            ElseIf islemNo = "2" Then
                tbPromosyon_kaydet_yeni("P2", "Ürüne Tutar Ýndirimi", sec_p2_sMusteri.Text, "", "", sec_p2_sPlu.Text, "", sec_P2_Musteriler.Text, "", sec_p2_lMiktar.EditValue, 0, 0, sec_p2_lLimit.EditValue, sec_p2_nIskontoYuzdesi.EditValue, sec_p2_lIskontoTutari.EditValue, sec_p2_dteTarih1.EditValue, sec_p2_dteTarih2.EditValue, 1)
            ElseIf islemNo = "3" Then
                tbPromosyon_kaydet_yeni("P3", "Ürüne Ürün Ýndirimi", sec_p3_sMusteri.Text, "", "", sec_p3_sPlu.Text, sec_p3_sKarsiPlu.Text, sec_P3_Musteriler.Text, "", sec_p3_lMiktar.EditValue, sec_p3_lFiyat.EditValue, 0, sec_p3_lLimit.EditValue, 0, 0, sec_p3_dteTarih1.EditValue, sec_p3_dteTarih2.EditValue, 1)
            ElseIf islemNo = "6" Then
                tbPromosyon_kaydet_yeni("P4", "Tutara Ürün Ýndirimi", sec_p4_sMusteri.Text, "", "", "", "", sec_p4_Musteriler.Text, "", sec_p4_lMiktar.EditValue, sec_p4_lFiyat.EditValue, 0, sec_p4_lLimit.EditValue, 0, 0, sec_p4_dteTarih1.EditValue, sec_p4_dteTarih2.EditValue, 1)
            ElseIf islemNo = "5" Then
                tbPromosyon_kaydet_yeni("P5", "Tutara KDV Ýndirimi", sec_p5_sMusteri.Text, "", "", "", "", sec_p5_Musteriler.Text, "N/" + sec_p5_sNakit.Text + "." + "K/" + sec_p5_sKredili.Text, 0, 0, 0, sec_p5_lLimit.EditValue, 0, 0, sec_p5_dteTarih1.EditValue, sec_p5_dteTarih2.EditValue, 1)
            ElseIf islemNo = "6" Then
                tbPromosyon_kaydet_yeni("P6", "Reyon Ýndirimi", sec_p6_sMusteri.Text, "", "", "", "", sec_P6_Musteriler.Text, sec_p6_ReyonKodu.EditValue, 0, 0, 0, 0, sec_p6_nIskontoYuzdesi.EditValue, sec_p6_lIskontoTutari.EditValue, sec_p6_dteTarih1.EditValue, sec_p6_dteTarih2.EditValue, 1)
            ElseIf islemNo = "7" Then
                tbPromosyon_kaydet_yeni("P7", "Grup Ýndirimi", sec_p7_sMusteri.Text, "", "", "", sec_p7_sKarsiPlu.Text, sec_P7_Musteriler.Text, sec_p7_GrupKodu.EditValue, sec_p7_lMiktar.EditValue, sec_p7_lFiyat.EditValue, 0, sec_p7_lLimit.EditValue, sec_p7_nIskontoYuzdesi.EditValue, sec_p7_lIskontoTutari.EditValue, sec_p7_dteTarih1.EditValue, sec_p7_dteTarih2.EditValue, 1)
            ElseIf islemNo = "8" Then
            ElseIf islemNo = "9" Then
                tbPromosyon_kaydet_yeni("P9", sec_P9_sAciklama.Text, sec_p9_sMusteri.Text, sec_p9_sOdemeKodu.Text, "", "", "", sec_P9_Musteriler.Text, sec_p9_OzelKodu.EditValue, sec_p9_lMiktar.EditValue, 0, 0, sec_p9_lLimit.EditValue, 0, sec_p9_lIskontoTutari.EditValue, sec_p9_dteTarih1.EditValue, sec_p9_dteTarih2.EditValue, 1)
            ElseIf islemNo = "K" Then
                tbPromosyon_kaydet_yeni("PK", "Ürüne Ýskonto Ýndirimi", sec_pk_sMusteri.Text, "", "", sec_pk_sPlu.Text, "", sec_Pk_Musteriler.Text, "", 0, 0, 0, sec_pk_lLimit.EditValue, sec_pk_nIskontoYuzdesi.EditValue, sec_pk_lIskontoTutari.EditValue, sec_pk_dteTarih1.EditValue, sec_pk_dteTarih2.EditValue, 1)
            End If
            ara()
            GridView1.FocusedRowHandle = GridView1.RowCount - 1
        ElseIf islem = "Düzelt" Then
            Dim satir As String = GridView1.FocusedRowHandle
            Dim dr As DataRow = GridView1.GetDataRow(GridView1.FocusedRowHandle)
            Dim nKayitID = dr("nKayitID")
            If islemNo = "1" Then
                tbPromosyon_kaydet_degistir(nKayitID, "P1", "Tutar Ýndirimi", sec_p1_sMusteri.Text, sec_p1_sOdemeSekli.Text, "", "", "", sec_P1_Musteriler.Text, "", 0, 0, 0, sec_p1_lLimit.EditValue, sec_p1_nIskontoYuzdesi.EditValue, sec_p1_lIskontoTutari.EditValue, sec_p1_dteTarih1.EditValue, sec_p2_dteTarih2.EditValue, 1)
            ElseIf islemNo = "2" Then
                tbPromosyon_kaydet_degistir(nKayitID, "P2", "Ürüne Tutar Ýndirimi", sec_p2_sMusteri.Text, "", "", sec_p2_sPlu.Text, "", sec_P2_Musteriler.Text, "", sec_p2_lMiktar.EditValue, "", 0, sec_p2_lLimit.EditValue, sec_p2_nIskontoYuzdesi.EditValue, sec_p2_lIskontoTutari.EditValue, sec_p2_dteTarih1.EditValue, sec_p2_dteTarih2.EditValue, 1)
            ElseIf islemNo = "3" Then
                tbPromosyon_kaydet_degistir(nKayitID, "P3", "Ürüne Ürün Ýndirimi", sec_p3_sMusteri.Text, "", "", sec_p3_sPlu.Text, sec_p3_sKarsiPlu.Text, sec_P3_Musteriler.Text, "", sec_p3_lMiktar.EditValue, sec_p3_lFiyat.EditValue, 0, sec_p3_lLimit.EditValue, 0, 0, sec_p3_dteTarih1.EditValue, sec_p3_dteTarih2.EditValue, 1)
            ElseIf islemNo = "6" Then
                tbPromosyon_kaydet_degistir(nKayitID, "P4", "Tutara Ürün Ýndirimi", sec_p4_sMusteri.Text, "", "", "", "", sec_p4_Musteriler.Text, "", sec_p4_lMiktar.EditValue, sec_p4_lFiyat.EditValue, 0, sec_p4_lLimit.EditValue, 0, 0, sec_p4_dteTarih1.EditValue, sec_p4_dteTarih2.EditValue, 1)
            ElseIf islemNo = "5" Then
                tbPromosyon_kaydet_degistir(nKayitID, "P5", "Tutara KDV Ýndirimi", sec_p5_sMusteri.Text, "", "", "", "", sec_p5_Musteriler.Text, "N/" + sec_p5_sNakit.Text + "." + "K/" + sec_p5_sKredili.Text, 0, 0, 0, sec_p5_lLimit.EditValue, 0, 0, sec_p5_dteTarih1.EditValue, sec_p5_dteTarih2.EditValue, 1)
            ElseIf islemNo = "6" Then
                tbPromosyon_kaydet_degistir(nKayitID, "P6", "Reyon Ýndirimi", sec_p6_sMusteri.Text, "", "", "", "", sec_P6_Musteriler.Text, sec_p6_ReyonKodu.EditValue, 0, 0, 0, 0, sec_p6_nIskontoYuzdesi.EditValue, sec_p6_lIskontoTutari.EditValue, sec_p6_dteTarih1.EditValue, sec_p6_dteTarih2.EditValue, 1)
            ElseIf islemNo = "7" Then
                tbPromosyon_kaydet_degistir(nKayitID, "P7", "Grup Ýndirimi", sec_p7_sMusteri.Text, "", "", "", sec_p7_sKarsiPlu.Text, sec_P7_Musteriler.Text, sec_p7_GrupKodu.EditValue, sec_p7_lMiktar.EditValue, sec_p7_lFiyat.EditValue, 0, sec_p7_lLimit.EditValue, sec_p7_nIskontoYuzdesi.EditValue, sec_p7_lIskontoTutari.EditValue, sec_p7_dteTarih1.EditValue, sec_p7_dteTarih2.EditValue, 1)
            ElseIf islemNo = "8" Then
            ElseIf islemNo = "9" Then
                tbPromosyon_kaydet_degistir(nKayitID, "P9", sec_P9_sAciklama.Text, sec_p9_sMusteri.Text, sec_p9_sOdemeKodu.Text, "", "", "", sec_P9_Musteriler.Text, sec_p9_OzelKodu.EditValue, sec_p9_lMiktar.EditValue, 0, 0, sec_p9_lLimit.EditValue, 0, sec_p9_lIskontoTutari.EditValue, sec_p9_dteTarih1.EditValue, sec_p9_dteTarih2.EditValue, 1)
            ElseIf islemNo = "K" Then
                tbPromosyon_kaydet_degistir(nKayitID, "PK", "Ürüne Ýskonto Ýndirimi", sec_pk_sMusteri.Text, "", "", sec_pk_sPlu.Text, "", sec_Pk_Musteriler.Text, "", 0, 0, 0, sec_pk_lLimit.EditValue, sec_pk_nIskontoYuzdesi.EditValue, sec_pk_lIskontoTutari.EditValue, sec_pk_dteTarih1.EditValue, sec_pk_dteTarih2.EditValue, 1)
            End If
            ara()
            GridView1.FocusedRowHandle = satir
        End If
        XtraTabPage1.PageVisible = True
        XtraTabPage2.PageVisible = False
        GridControl1.Focus()
        GridControl1.Select()
    End Sub
    Private Sub SimpleButton4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SimpleButton4.Click
        kaydet()
    End Sub
    Private Sub sec_p2_sPlu_ButtonClick(ByVal sender As Object, ByVal e As DevExpress.XtraEditors.Controls.ButtonPressedEventArgs) Handles sec_p2_sPlu.ButtonClick
        stok_sec(2)
    End Sub
    Private Sub sec_p2_sPlu_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles sec_p2_sPlu.KeyDown
        If e.KeyCode = Keys.F6 Then
            stok_sec(2)
        ElseIf e.KeyCode = Keys.Enter And sec_p2_sPlu.Text = "" Then
            stok_sec(2)
        End If
    End Sub
    Private Sub sec_p3_sPlu_ButtonClick(ByVal sender As Object, ByVal e As DevExpress.XtraEditors.Controls.ButtonPressedEventArgs) Handles sec_p3_sPlu.ButtonClick
        stok_sec(3)
    End Sub
    Private Sub sec_p3_sPlu_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles sec_p3_sPlu.KeyDown
        If e.KeyCode = Keys.F6 Then
            stok_sec(3)
        ElseIf e.KeyCode = Keys.Enter And sec_p3_sPlu.Text = "" Then
            stok_sec(3)
        End If
    End Sub
    Private Sub sec_p3_sKarsiPlu_ButtonClick(ByVal sender As Object, ByVal e As DevExpress.XtraEditors.Controls.ButtonPressedEventArgs) Handles sec_p3_sKarsiPlu.ButtonClick
        stok_sec(4)
    End Sub
    Private Sub sec_p3_sKarsiPlu_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles sec_p3_sKarsiPlu.KeyDown
        If e.KeyCode = Keys.F6 Then
            stok_sec(4)
        ElseIf e.KeyCode = Keys.Enter And sec_p3_sKarsiPlu.Text = "" Then
            stok_sec(4)
        End If
    End Sub
    Private Sub sec_p4_sPlu_ButtonClick(ByVal sender As Object, ByVal e As DevExpress.XtraEditors.Controls.ButtonPressedEventArgs) Handles sec_p4_sPlu.ButtonClick
        stok_sec(5)
    End Sub
    Private Sub sec_p4_sPlu_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles sec_p4_sPlu.KeyDown
        If e.KeyCode = Keys.F6 Then
            stok_sec(5)
        ElseIf e.KeyCode = Keys.Enter And sec_p4_sPlu.Text = "" Then
            stok_sec(5)
        End If
    End Sub
    Private Sub SimpleButton5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SimpleButton5.Click
        If XtraMessageBox.Show("Promosyon Kayýtlarýný Kasaya Göndermek Ýstediðinize Emin misiniz...?", Sorgu_sDil("Dikkat", sDil), MessageBoxButtons.YesNo, MessageBoxIcon.Question) = MsgBoxResult.Yes Then
            promosyontransfer(sPath, sec_bTarihAraligiGonder.Checked)
            mesaj_create(sPath, nIlkKasa, nSonKasa, "1110000000000")
        End If
    End Sub
    Private Sub mesaj_create(ByVal sPath As String, ByVal nIlkKasa As Integer, ByVal nSonKasa As Integer, ByVal mesaj As String)
        Dim i As Integer
        Dim t As Integer = nIlkKasa - 1
        For i = nIlkKasa To nSonKasa
            t += 1
            Dim Z As String = "" & sPath & ":" & sFile & "\POSKON\MESAJ.00" & t & ""
            Dim sw As StreamWriter = File.CreateText(Z)
            sw.WriteLine(mesaj)
            sw.Close()
        Next
        XtraMessageBox.Show("Mesaj Dosyasý Baþarýyla Oluþturuldu...!", Sorgu_sDil("Dikkat", sDil), MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub
    Private Sub promosyontransfer(ByVal sPath As String, Optional ByVal bTarihGonder As Boolean = True)
        'If SAVE.ShowDialog = DialogResult.OK Then
        Dim z As String = "" & sPath & ":" & sFile & "\POSGENEL\PROMO.DAT" 'SAVE.FileName.ToString
        Dim DOSYA As New FileInfo(z)
        If DOSYA.Exists Then
            DOSYA.Delete()
        End If
        Dim sw As StreamWriter = File.AppendText(z)
        Dim dr As DataRow
        For Each dr In ds_Promosyon.Tables(0).Rows
            If dr("bAktif") = True Then
                Dim sPromosyonKodu As String = Trim(dr("sPromosyonKodu"))
                Dim sAciklama As String = degeruzunlukkontrol(Trim(dr("sAciklama")), 25)
                Dim sMusteriTipi As String = Trim(dr("sMusteriTipi"))
                Dim sOdemeKodu As String = Trim(dr("sOdemeKodu"))
                Dim sPlu As String = sayiuzunlukkontrol(dr("sPlu"), 6)
                Dim sKarsiPlu As String = sayiuzunlukkontrol(dr("sKarsiPlu"), 6)
                Dim sMusteriler As String = "*"
                If Trim(dr("sMusteriKodu")) = "" Then
                    sMusteriler = ""
                Else
                    sMusteriler = "," & Trim(dr("sMusteriKodu"))
                End If
                Dim sOzelKod As String = Replace(Trim(dr("sOzelKod")), ".", ",")
                Dim lMiktar As String = sayiuzunlukkontrol(CInt(dr("lMiktar")), 2)
                Dim lFiyat As String = sayiuzunlukkontrol(FormatNumber(dr("lFiyat"), 2).Replace(",", ""), 10)
                Dim lTutar As String = sayiuzunlukkontrol(FormatNumber(dr("lTutar"), 2).Replace(",", ""), 10)
                Dim lLimit As String = sayiuzunlukkontrol(FormatNumber(dr("lLimit"), 2).Replace(",", ""), 10)
                If Trim(dr("sPromosyonKodu")) = "P2" Or Trim(dr("sPromosyonKodu")) = "PK" Then
                    lLimit = sayiuzunlukkontrol(CInt(dr("lLimit")), 2)
                    If dr("lMiktar") = 0 Then
                        lMiktar = "--"
                    End If
                ElseIf Trim(dr("sPromosyonKodu")) = "P3" Then
                    lLimit = sayiuzunlukkontrol(CInt(dr("lLimit")), 2)
                End If
                Dim nIskontoYuzdesi As String = sayiuzunlukkontrol(CInt(dr("nIskontoYuzdesi")), 2)
                Dim lIskontoTutari As String = sayiuzunlukkontrol(FormatNumber(dr("lIskontoTutari"), 2).Replace(",", ""), 10)
                'Dim dteGecerlilikSuresi As String = "gg-aa-yyyy ss:dd:ss gg-aa-yyyy ss:dd:ss"
                Dim dteGecerlilikSuresi As String = ""
                If bTarihGonder = True Then
                    Dim dteTarih1 As DateTime = dr("dteTarih1")
                    Dim sGun = dteTarih1.Day
                    Dim sAy = dteTarih1.Month
                    Dim sYil = dteTarih1.Year
                    dteGecerlilikSuresi = "," & sayiuzunlukkontrol(sGun, 2) + "-" + sayiuzunlukkontrol(sAy, 2) + "-" + sayiuzunlukkontrol(sYil, 4) + " 00:00:00 "
                    Dim dteTarih2 As DateTime = dr("dteTarih2")
                    sGun = dteTarih2.Day
                    sAy = dteTarih2.Month
                    sYil = dteTarih2.Year
                    dteGecerlilikSuresi += sayiuzunlukkontrol(sGun, 2) + "-" + sayiuzunlukkontrol(sAy, 2) + "-" + sayiuzunlukkontrol(sYil, 4) + " 23:59:59"
                End If
                If Trim(dr("sPromosyonKodu")) = "P1" Then
                    sw.WriteLine("P1," & sMusteriTipi & "," & lLimit & "," & nIskontoYuzdesi & "," & lIskontoTutari & "," & Replace(sMusteriler, ",", "") & "," & sOdemeKodu & dteGecerlilikSuresi & "")
                ElseIf Trim(dr("sPromosyonKodu")) = "P2" Then
                    sw.WriteLine("P2," & sMusteriTipi & "," & lLimit & "," & sPlu & "," & nIskontoYuzdesi & "," & lIskontoTutari & "," & lMiktar & sMusteriler & dteGecerlilikSuresi & "")
                ElseIf Trim(dr("sPromosyonKodu")) = "P3" Then
                    sw.WriteLine("P3," & sMusteriTipi & "," & sPlu & "," & lLimit & "," & sKarsiPlu & "," & lMiktar & "," & lFiyat & sMusteriler & dteGecerlilikSuresi & "")
                ElseIf Trim(dr("sPromosyonKodu")) = "P4" Then
                    sw.WriteLine("P4," & sMusteriTipi & "," & lLimit & "," & lMiktar & "," & sPlu & "," & lFiyat & sMusteriler & dteGecerlilikSuresi & "")
                ElseIf Trim(dr("sPromosyonKodu")) = "P5" Then
                    sw.WriteLine("P5," & sMusteriTipi & "," & lLimit & "," & sOzelKod & sMusteriler & dteGecerlilikSuresi & "")
                ElseIf Trim(dr("sPromosyonKodu")) = "P6" Then
                    sw.WriteLine("P6," & sMusteriTipi & "," & sOzelKod & "," & nIskontoYuzdesi & "," & lIskontoTutari & ",H" & sMusteriler & dteGecerlilikSuresi & "")
                ElseIf Trim(dr("sPromosyonKodu")) = "P7" Then
                    If Trim(sKarsiPlu) = "" Or sKarsiPlu = "000000" Then
                        sKarsiPlu = "------"
                        lMiktar = "--"
                        lFiyat = "----------"
                    End If
                    sw.WriteLine("P7," & sMusteriTipi & "," & sOzelKod & "," & lLimit & "," & nIskontoYuzdesi & "," & lIskontoTutari & "," & sKarsiPlu & "," & lMiktar & "," & lFiyat & sMusteriler & dteGecerlilikSuresi & "")
                ElseIf Trim(dr("sPromosyonKodu")) = "P8" Then
                    sw.WriteLine("P8," & sMusteriTipi & "," & sOzelKod & "," & lLimit & "," & sKarsiPlu & "," & lMiktar & sMusteriler & dteGecerlilikSuresi & "")
                ElseIf Trim(dr("sPromosyonKodu")) = "P9" Then
                    sOdemeKodu = degeruzunlukkontrol(sOdemeKodu, 4)
                    sw.WriteLine("P9," & sMusteriTipi & "," & sOdemeKodu & "," & sAciklama & "," & sOzelKod & "," & lMiktar & "," & lLimit & "," & lIskontoTutari & sMusteriler & dteGecerlilikSuresi & "")
                ElseIf Trim(dr("sPromosyonKodu")) = "PK" Then
                    sw.WriteLine("PK," & sMusteriTipi & "," & sPlu & "," & lLimit & "," & nIskontoYuzdesi & "," & lIskontoTutari & sMusteriler & dteGecerlilikSuresi & "")
                End If
            End If
        Next
        sw.Close()
    End Sub
    Private Sub stok_sil()
        If XtraMessageBox.Show(Sorgu_sDil("Seçili Kayýtlarý Silmek Ýstediðinize Emin misiniz...?", sDil), Sorgu_sDil("Dikkat", sDil), MessageBoxButtons.YesNo, MessageBoxIcon.Question) = MsgBoxResult.Yes Then
            Dim s As String
            Dim arr As Integer()
            Dim i As Integer
            Dim dr1 As DataRow
            Dim satir As String = GridView1.FocusedRowHandle
            arr = GridView1.GetSelectedRows()
            If arr Is Nothing Then
            Else
                Array.Sort(arr)
                For Each i In arr
                    s = i.ToString
                    dr1 = GridView1.GetDataRow(s)
                    tbStokTedarikcisi_kaydet_sil(dr1("nKayitID"), dr1("sPromosyonKodu"))
                Next
            End If
            s = Nothing
            arr = Nothing
            i = Nothing
            dr1 = Nothing
            'MsgBox(Sorgu_sDil("Ýþlem Tamamlandý...", sDil), Sorgu_sDil("Dikkat", sDil), MessageBoxButtons.OK, MessageBoxIcon.Information)
            ara()
            GridView1.FocusedRowHandle = satir
            satir = Nothing
        End If
    End Sub
    Private Sub MenuItem26_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem26.Click
        stok_sil()
    End Sub
    Private Sub BarButtonItem3_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem3.ItemClick
        stok_sil()
    End Sub
    Private Sub BarButtonItem4_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem4.ItemClick
        gorunum_yazdir()
    End Sub
    Private Sub raporla_excel()
        If XtraMessageBox.Show(Sorgu_sDil("Sonuçlarý Excel Dosyasý Oluþturmak Ýstediðinize Emin misiniz...?", sDil), Sorgu_sDil("Dikkat", sDil), MessageBoxButtons.YesNo, MessageBoxIcon.Question) = MsgBoxResult.Yes Then
            Dim SaveFileDialog1 As New Windows.Forms.SaveFileDialog
            SaveFileDialog1.Filter = "Excel Dosyalarý(*.xls) |*.xls"
            SaveFileDialog1.InitialDirectory = "c:\"
            SaveFileDialog1.FileName = "Rapor.xls"
            If SaveFileDialog1.ShowDialog = Windows.Forms.DialogResult.OK Then
                GridView1.ExportToXls(SaveFileDialog1.FileName.ToString)
                If XtraMessageBox.Show(Sorgu_sDil("Kaydý Açmak Ýster misiniz...?", sDil), Sorgu_sDil("Dikkat", sDil), MessageBoxButtons.YesNo, MessageBoxIcon.Question) = MsgBoxResult.Yes Then
                    Process.Start(SaveFileDialog1.FileName.ToString)
                End If
            End If
            SaveFileDialog1 = Nothing
        End If
    End Sub
    Private Sub raporla_text()
        If XtraMessageBox.Show(Sorgu_sDil("Sonuçlarý Text Dosyasý Oluþturmak Ýstediðinize Emin misiniz...?", sDil), Sorgu_sDil("Dikkat", sDil), MessageBoxButtons.YesNo, MessageBoxIcon.Question) = MsgBoxResult.Yes Then
            Dim SaveFileDialog1 As New Windows.Forms.SaveFileDialog
            SaveFileDialog1.Filter = "Text Dosyalarý(*.txt) |*.txt"
            SaveFileDialog1.InitialDirectory = "c:\"
            SaveFileDialog1.FileName = "Rapor.txt"
            If SaveFileDialog1.ShowDialog = Windows.Forms.DialogResult.OK Then
                GridView1.ExportToText(SaveFileDialog1.FileName.ToString)
                If XtraMessageBox.Show(Sorgu_sDil("Kaydý Açmak Ýster misiniz...?", sDil), Sorgu_sDil("Dikkat", sDil), MessageBoxButtons.YesNo, MessageBoxIcon.Question) = MsgBoxResult.Yes Then
                    Process.Start(SaveFileDialog1.FileName.ToString)
                End If
            End If
            SaveFileDialog1 = Nothing
        End If
    End Sub
    Private Sub raporla_pdf()
        If XtraMessageBox.Show(Sorgu_sDil("Sonuçlarý Metin Dosyasý Oluþturmak Ýstediðinize Emin misiniz...?", sDil), Sorgu_sDil("Dikkat", sDil), MessageBoxButtons.YesNo, MessageBoxIcon.Question) = MsgBoxResult.Yes Then
            Dim SaveFileDialog1 As New Windows.Forms.SaveFileDialog
            SaveFileDialog1.Filter = "Metin Dosyalarý(*.pdf) |*.pdf"
            SaveFileDialog1.InitialDirectory = "c:\"
            SaveFileDialog1.FileName = "Rapor.pdf"
            If SaveFileDialog1.ShowDialog = Windows.Forms.DialogResult.OK Then
                GridView1.ExportToPdf(SaveFileDialog1.FileName.ToString)
                If XtraMessageBox.Show(Sorgu_sDil("Kaydý Açmak Ýster misiniz...?", sDil), Sorgu_sDil("Dikkat", sDil), MessageBoxButtons.YesNo, MessageBoxIcon.Question) = MsgBoxResult.Yes Then
                    Process.Start(SaveFileDialog1.FileName.ToString)
                End If
            End If
            SaveFileDialog1 = Nothing
        End If
    End Sub
    Private Sub BarButtonItem5_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem5.ItemClick
        raporla_excel()
    End Sub
    Private Sub BarButtonItem6_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem6.ItemClick
        raporla_text()
    End Sub
    Private Sub BarButtonItem7_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem7.ItemClick
        raporla_pdf()
    End Sub
    Private Sub BarButtonItem2_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem2.ItemClick
        islem = "Düzelt"
        satir_duzelt()
    End Sub
    Private Sub satir_duzelt()
        Dim dr As DataRow = GridView1.GetDataRow(GridView1.FocusedRowHandle)
        Dim iNo As Integer = 1
        If Trim(dr("sPromosyonKodu")) = "P1" Then
            sec_p1_dteTarih1.EditValue = dr("dteTarih1")
            sec_p1_dteTarih2.EditValue = dr("dteTarih2")
            sec_p1_lIskontoTutari.EditValue = dr("lIskontoTutari")
            sec_p1_lLimit.EditValue = dr("lLimit")
            sec_P1_Musteriler.Text = dr("sMusteriKodu")
            sec_p1_nIskontoYuzdesi.EditValue = dr("nIskontoYuzdesi")
            sec_p1_sMusteri.EditValue = dr("sMusteriTipi")
            sec_p1_sOdemeSekli.EditValue = dr("sOdemeKodu")
            iNo = 1
        ElseIf Trim(dr("sPromosyonKodu")) = "P2" Then
            sec_p2_dteTarih1.EditValue = dr("dteTarih1")
            sec_p2_dteTarih2.EditValue = dr("dteTarih2")
            sec_p2_lIskontoTutari.EditValue = dr("lIskontoTutari")
            sec_p2_lLimit.EditValue = dr("lLimit")
            sec_P2_Musteriler.Text = dr("sMusteriKodu")
            sec_p2_nIskontoYuzdesi.EditValue = dr("nIskontoYuzdesi")
            sec_p2_sMusteri.EditValue = dr("sMusteriTipi")
            sec_p2_lMiktar.EditValue = dr("lMiktar")
            sec_p2_sPlu.Text = dr("sPlu")
            sec_p2_sPluAciklama.Text = dr("sStokAciklama")
            iNo = 2
        ElseIf Trim(dr("sPromosyonKodu")) = "P3" Then
            sec_p3_dteTarih1.EditValue = dr("dteTarih1")
            sec_p3_dteTarih2.EditValue = dr("dteTarih2")
            sec_p3_lLimit.EditValue = dr("lLimit")
            sec_P3_Musteriler.Text = dr("sMusteriKodu")
            sec_p3_sMusteri.EditValue = dr("sMusteriTipi")
            sec_p3_lMiktar.EditValue = dr("lMiktar")
            sec_p3_sPlu.Text = dr("sPlu")
            sec_p3_sPluAciklama.Text = dr("sStokAciklama").ToString
            sec_p3_sKarsiPlu.Text = dr("sKarsiPlu").ToString
            sec_p3_sKarsiPluAciklama.Text = dr("sKarsiStokAciklama").ToString
            sec_p3_lFiyat.EditValue = dr("lFiyat")
            iNo = 3
        ElseIf Trim(dr("sPromosyonKodu")) = "P4" Then
            sec_p4_dteTarih1.EditValue = dr("dteTarih1")
            sec_p4_dteTarih2.EditValue = dr("dteTarih2")
            sec_p4_lLimit.EditValue = dr("lLimit")
            sec_p4_Musteriler.Text = dr("sMusteriKodu")
            sec_p4_sMusteri.EditValue = dr("sMusteriTipi")
            sec_p4_lMiktar.EditValue = dr("lMiktar")
            sec_p4_sPlu.Text = dr("sPlu").ToString
            sec_p4_sPluAciklama.Text = dr("sStokAciklama").ToString
            sec_p4_lFiyat.EditValue = dr("lFiyat")
            iNo = 4
        ElseIf Trim(dr("sPromosyonKodu")) = "P5" Then
            sec_p5_dteTarih1.EditValue = dr("dteTarih1")
            sec_p5_dteTarih2.EditValue = dr("dteTarih2")
            sec_p5_lLimit.EditValue = dr("lLimit")
            sec_p5_Musteriler.Text = dr("sMusteriKodu")
            sec_p5_sMusteri.EditValue = dr("sMusteriTipi")
            sec_p5_sNakit.Text = dr("sOzelKod").ToString.Substring(2, 1)
            sec_p5_sKredili.Text = dr("sOzelKod").ToString.Substring(6, 1)
            iNo = 5
        ElseIf Trim(dr("sPromosyonKodu")) = "P6" Then
            sec_p6_dteTarih1.EditValue = dr("dteTarih1")
            sec_p6_dteTarih2.EditValue = dr("dteTarih2")
            sec_p6_lIskontoTutari.EditValue = dr("lIskontoTutari")
            sec_P6_Musteriler.Text = dr("sMusteriKodu")
            sec_p6_nIskontoYuzdesi.EditValue = dr("nIskontoYuzdesi")
            sec_p6_sMusteri.EditValue = dr("sMusteriTipi")
            sec_p6_ReyonKodu.EditValue = dr("sOzelKod")
            iNo = 6
        ElseIf Trim(dr("sPromosyonKodu")) = "P7" Then
            sec_p7_dteTarih1.EditValue = dr("dteTarih1")
            sec_p7_dteTarih2.EditValue = dr("dteTarih2")
            sec_p7_lIskontoTutari.EditValue = dr("lIskontoTutari")
            sec_P7_Musteriler.Text = dr("sMusteriKodu")
            sec_p7_nIskontoYuzdesi.EditValue = dr("nIskontoYuzdesi")
            sec_p7_sMusteri.EditValue = dr("sMusteriTipi")
            sec_p7_GrupKodu.EditValue = dr("sOzelKod")
            sec_p7_sKarsiPlu.Text = dr("sKarsiPlu").ToString
            sec_p7_sKarsiPluAciklama.Text = dr("sKarsiStokAciklama").ToString
            sec_p7_lMiktar.EditValue = dr("lMiktar")
            sec_p7_lFiyat.EditValue = dr("lFiyat")
            sec_p7_lLimit.EditValue = dr("lLimit")
            iNo = 7
        ElseIf Trim(dr("sPromosyonKodu")) = "P8" Then
        ElseIf Trim(dr("sPromosyonKodu")) = "P9" Then
            sec_p9_dteTarih1.EditValue = dr("dteTarih1")
            sec_p9_dteTarih2.EditValue = dr("dteTarih2")
            sec_p9_lIskontoTutari.EditValue = dr("lIskontoTutari")
            sec_P9_Musteriler.Text = dr("sMusteriKodu")
            sec_p9_sMusteri.EditValue = dr("sMusteriTipi")
            sec_p9_OzelKodu.EditValue = dr("sOzelKod")
            sec_p9_lMiktar.EditValue = dr("lMiktar")
            sec_p9_lLimit.EditValue = dr("lLimit")
            sec_p9_sOdemeKodu.EditValue = dr("sOdemeKodu")
            sec_P9_sAciklama.Text = dr("sAciklama")
            iNo = 9
        End If
        islem = "Düzelt"
        satir_ekle(iNo, islem)
    End Sub
    Private Sub MenuItem27_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem27.Click
        satir_duzelt()
    End Sub
    Private Sub sec_sPromosyonKodu_SelectedValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles sec_sPromosyonKodu.SelectedValueChanged
        GridView1.ClearColumnsFilter()
        If sec_sPromosyonKodu.Text = "1" Then
            lbl_sPromosyonAciklama.Text = "TOPLAM TUTARA YÜZDE VEYA TUTAR ÜZERÝNDEN ÝNDÝRÝM"
        ElseIf sec_sPromosyonKodu.Text = "2" Then
            lbl_sPromosyonAciklama.Text = "ÜRÜNE UYGULANACAK YÜZDE VEYA TUTAR ÝNDÝRÝMÝ"
        ElseIf sec_sPromosyonKodu.Text = "3" Then
            lbl_sPromosyonAciklama.Text = "ÜRÜNE UYGULANACAK ADET PROMOSYONU"
        ElseIf sec_sPromosyonKodu.Text = "4" Then
            lbl_sPromosyonAciklama.Text = "TOPLAM TUTARA VERÝLECEK ÜRÜN PROMOSYONU "
        ElseIf sec_sPromosyonKodu.Text = "5" Then
            lbl_sPromosyonAciklama.Text = "TOPLAM TUTARA KDV ÝNDÝRÝMÝ "
        ElseIf sec_sPromosyonKodu.Text = "6" Then
            lbl_sPromosyonAciklama.Text = "REYON ÝNDÝRÝMÝ "
        ElseIf sec_sPromosyonKodu.Text = "7" Then
            lbl_sPromosyonAciklama.Text = "GRUP PROMOSYON "
        ElseIf sec_sPromosyonKodu.Text = "8" Then
            lbl_sPromosyonAciklama.Text = "ÖZELKOD ÝNDÝRÝM "
        ElseIf sec_sPromosyonKodu.Text = "9" Then
            lbl_sPromosyonAciklama.Text = "ÖZELKOD ÝNDÝRÝM "
        ElseIf sec_sPromosyonKodu.Text = "A" Then
            lbl_sPromosyonAciklama.Text = "ÜRÜNE UYGULANACAK ADET PROMOSYONU "
        ElseIf sec_sPromosyonKodu.Text = "B" Then
            lbl_sPromosyonAciklama.Text = "ÜRÜN ÖZEL KODUNA UYGULANACAK ÝNDÝRÝM PROMOSYONU "
        ElseIf sec_sPromosyonKodu.Text = "C" Then
            lbl_sPromosyonAciklama.Text = "TOPLAM TUTARA VERÝLECEK ÜRÜN PROMOSYONU "
        ElseIf sec_sPromosyonKodu.Text = "D" Then
            lbl_sPromosyonAciklama.Text = "TOPLAM TUTARDA AKTÝF OLACAK ÜRÜN FÝYAT PROMOSYONU "
        ElseIf sec_sPromosyonKodu.Text = "E" Then
            lbl_sPromosyonAciklama.Text = "TOPLAM TUTARA VERÝLECEK ÜRÜN PROMOSYONU "
        ElseIf sec_sPromosyonKodu.Text = "F" Then
            lbl_sPromosyonAciklama.Text = "TOPLAM TUTARA VERÝLECEK ÜRÜN PROMOSYONU "
        ElseIf sec_sPromosyonKodu.Text = "G" Then
            lbl_sPromosyonAciklama.Text = "ALIÞVERÝÞ TOPLAMINA VERÝLECEK KONTOR VEYA ÞÝFRE SABÝTÝ"
        ElseIf sec_sPromosyonKodu.Text = "H" Then
            lbl_sPromosyonAciklama.Text = "GRUP SATIÞ TOPLAMINA VERÝLECEK KONTOR VEYA ÞÝFRE "
        ElseIf sec_sPromosyonKodu.Text = "I" Then
            lbl_sPromosyonAciklama.Text = "ALIÞVERÝÞ TOPLAMINA VERÝLECEK ÜRÜN "
        ElseIf sec_sPromosyonKodu.Text = "J" Then
            lbl_sPromosyonAciklama.Text = "GRUP SATIÞ TOPLAMINA VERÝLECEK ÜRÜN "
        ElseIf sec_sPromosyonKodu.Text = "K" Then
            lbl_sPromosyonAciklama.Text = "ÜRÜNE UYGULANACAK YÜZDE VEYA TUTAR ÝNDÝRÝMÝ "
        End If
        If sec_sPromosyonKodu.Text = "" Then
        Else
            GridView1.Columns("sPromosyonKodu").FilterInfo = New ColumnFilterInfo("[sPromosyonKodu] LIKE 'P" & sec_sPromosyonKodu.Text & "%'")
        End If
        GridControl1.Focus()
        GridControl1.Select()
    End Sub
    Private Sub BarButtonItem1_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem1.ItemClick
        If sec_sPromosyonKodu.EditValue = "" Then
            sec_sPromosyonKodu.EditValue = "1"
        End If
        satir_ekle(sec_sPromosyonKodu.EditValue, "Ekle")
    End Sub
    Private Sub sec_p3_sKarsiPlu_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles sec_p3_sKarsiPlu.KeyUp
    End Sub
    Private Sub MenuItem35_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem35.Click
        satir_ekle("K", "Ekle")
    End Sub
    Private Sub sec_pk_sPlu_ButtonClick(ByVal sender As Object, ByVal e As DevExpress.XtraEditors.Controls.ButtonPressedEventArgs) Handles sec_pk_sPlu.ButtonClick
        stok_sec(6)
    End Sub
    Private Sub sec_pk_sPlu_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles sec_pk_sPlu.KeyDown
        If e.KeyCode = Keys.F6 Then
            stok_sec(6)
        ElseIf e.KeyCode = Keys.Enter And sec_pk_sPlu.Text = "" Then
            stok_sec(6)
        End If
    End Sub
    Private Sub sec_p7_sKarsiPlu_ButtonClick(ByVal sender As Object, ByVal e As DevExpress.XtraEditors.Controls.ButtonPressedEventArgs) Handles sec_p7_sKarsiPlu.ButtonClick
        stok_sec(7)
    End Sub
    Private Sub sec_p7_sKarsiPlu_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles sec_p7_sKarsiPlu.KeyDown
        If e.KeyCode = Keys.F6 Then
            stok_sec(7)
        ElseIf e.KeyCode = Keys.Enter And sec_p7_sKarsiPlu.Text = "" Then
            stok_sec(7)
        End If
    End Sub
    Private Sub MenuItem36_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem36.Click
        satir_ekle(8)
    End Sub
    Private Sub MenuItem37_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem37.Click
        satir_ekle(9)
    End Sub
End Class