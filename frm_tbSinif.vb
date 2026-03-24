Imports DevExpress.XtraEditors
Public Class frm_tbSinif
    Public firmano As Integer = 100
    Public donemno As Integer = 1
    Public connection
    Public kullanici
    Public Table As String = "SSinif"
    Public islem As String = ""
    Public No As Integer = 1
    Dim conn As New OleDb.OleDbConnection
    Dim con As New OleDb.OleDbConnection
    Dim cmd As New OleDb.OleDbCommand
    Dim adapter As New OleDb.OleDbDataAdapter
    Dim DS As New DataSet
    Dim satir
    Private sLogoUrl As String = ""
    Private WithEvents OpenFileDialog1 As New OpenFileDialog()
    Private WithEvents btnLogoEkle As DevExpress.XtraEditors.SimpleButton
    Private WithEvents picLogo As DevExpress.XtraEditors.PictureEdit
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
    Private Sub gorunum_kaydet()
        GridView1.SaveLayoutToRegistry("SOFTWARE\BusinessSmart\VIEW\MAGAZA\" & Me.Name.ToString & "")
        XtraMessageBox.Show(Sorgu_sDil("Görünüm Kaydedildi", sDil), Sorgu_sDil("Dikkat", sDil), MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub
    Private Sub gorunum_yukle()
        For Each btn As DevExpress.XtraBars.BarItem In BarManager1.Items
            btn.Caption = Sorgu_sDil(btn.Caption, sDil)
        Next
        For Each clmn As DevExpress.XtraGrid.Columns.GridColumn In GridView1.Columns
            clmn.Caption = Sorgu_sDil(clmn.Caption, sDil)
        Next
        SimpleButton1.Text = Sorgu_sDil(SimpleButton1.Text, sDil)
        SimpleButton2.Text = Sorgu_sDil(SimpleButton2.Text, sDil)
        GridView1.RestoreLayoutFromRegistry("SOFTWARE\BusinessSmart\VIEW\MAGAZA\" & Me.Name.ToString & "")
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
    Public Sub Dataload_tbSinif(ByVal table As String, ByVal no As String)
        Try
            ds_tbSinif.Tables(0).Clear()
        Catch ex As Exception
        End Try
        Dim conn As New OleDb.OleDbConnection
        Dim cmd As New OleDb.OleDbCommand
        Dim adapter As New OleDb.OleDbDataAdapter
        table = table & no
        conn.ConnectionString = connection
        adapter.SelectCommand = cmd
        cmd.CommandText = sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT * From  " & table & "  Where sSinifKodu <>'' ")
        cmd.Connection = conn
        Dim N As Integer = adapter.Fill(ds_tbSinif, "Table1")
        conn.Close()
        GridControl1.Focus()
        GridControl1.Select()
    End Sub
    Private Sub tbSinif_kaydet_yeni(ByVal table As String, ByVal no As Integer, ByVal sSinifKodu As String, ByVal sAciklama As String, ByVal bSatisYapilamaz As Byte, Optional ByVal logoUrl As String = "")
        Dim cmd As New OleDb.OleDbCommand
        Dim con As New OleDb.OleDbConnection
        cmd.Connection = con
        con.ConnectionString = connection
        If con.State = ConnectionState.Closed = True Then
            con.Open()
        End If
        If table = "tbMSinif" Then
            cmd.CommandText = sorgu_query("SET DATEFORMAT DMY SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED INSERT INTO " & table & no & " (sSinifKodu, sAciklama, bSatisYapilamaz) VALUES     ('" & sSinifKodu & "', N'" & sAciklama & "', " & bSatisYapilamaz & ")")
            cmd.ExecuteNonQuery()
        Else
            cmd.CommandText = sorgu_query("SET DATEFORMAT DMY SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED INSERT INTO " & table & no & " (sSinifKodu, sAciklama, sLogoUrl) VALUES     ('" & sSinifKodu & "', '" & sAciklama & "', '" & logoUrl & "')")
            cmd.ExecuteNonQuery()
        End If
    End Sub
    Private Sub tbSinif_kaydet_duzelt(ByVal table As String, ByVal no As Integer, ByVal sSinifKodu As String, ByVal sAciklama As String, ByVal bSatisYapilamaz As Byte, Optional ByVal logoUrl As String = "")
        Dim cmd As New OleDb.OleDbCommand
        Dim con As New OleDb.OleDbConnection
        cmd.Connection = con
        con.ConnectionString = connection
        If con.State = ConnectionState.Closed = True Then
            con.Open()
        End If
        If table = "tbMSinif" Then
            cmd.CommandText = sorgu_query("SET DATEFORMAT DMY SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED UPDATE " & table & no & " SET sSinifKodu = '" & sSinifKodu & "', sAciklama = N'" & sAciklama & "', bSatisYapilamaz = " & bSatisYapilamaz & " Where sSinifKodu = '" & sSinifKodu & "'")
        ElseIf table = "tbSSinif" Then
            cmd.CommandText = sorgu_query("SET DATEFORMAT DMY SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED UPDATE " & table & no & " SET sSinifKodu = '" & sSinifKodu & "', " & sinif_iliski_sorgu_hazilar() & " sAciklama = '" & sAciklama & "', sLogoUrl = '" & logoUrl & "' Where sSinifKodu = '" & sSinifKodu & "'")
        Else
            cmd.CommandText = sorgu_query("SET DATEFORMAT DMY SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED UPDATE " & table & no & " SET sSinifKodu = '" & sSinifKodu & "', sAciklama = '" & sAciklama & "', sLogoUrl = '" & logoUrl & "' Where sSinifKodu = '" & sSinifKodu & "'")
        End If
        cmd.ExecuteNonQuery()
        con.Close()
    End Sub
    Private Sub tbSinif_kaydet_sil(ByVal table As String, ByVal no As Integer, ByVal sSinifKodu As String)
        Dim cmd As New OleDb.OleDbCommand
        Dim con As New OleDb.OleDbConnection
        cmd.Connection = con
        con.ConnectionString = connection
        If con.State = ConnectionState.Closed = True Then
            con.Open()
        End If
        cmd.CommandText = sorgu_query("SET DATEFORMAT DMY SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED DELETE FROM " & table & no & " Where sSinifKodu ='" & sSinifKodu & "'")
        Try
            cmd.ExecuteNonQuery()
        Catch ex As Exception
            XtraMessageBox.Show("Kullanýlmýþ Sýnýf Tanýmýný Silemizsiniz...!", Sorgu_sDil("Dikkat", sDil), MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End Try
        con.Close()
    End Sub
    Public Function sorgu_sSinifKodu_kontrol(ByVal table As String, ByVal No As Integer, ByVal sSinifKodu As String) As Boolean
        Dim kriter
        Dim pass As Boolean
        kriter = ""
        Dim conn As New OleDb.OleDbConnection
        Dim cmd As New OleDb.OleDbCommand
        Dim adapter As New OleDb.OleDbDataAdapter
        conn.ConnectionString = connection
        cmd.Connection = conn
        conn.Open()
        cmd.CommandText = sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT ISNULL(COUNT(sSinifKodu), 0) AS nKayit FROM " & table & No & " WHERE (sSinifKodu = '" & sSinifKodu & "') and sSinifKodu <> '' ")
        Dim kayitsayisi = cmd.ExecuteScalar
        If kayitsayisi = 0 Then
            pass = True
        Else
            pass = False
        End If
        Return pass
    End Function
    Public Function sorgu_sSinifTipi_kontrol(ByVal table As String, ByVal No As String) As String
        Dim kriter
        kriter = ""
        If table = "tbMSinif" Then
            table = "tbParamMusteri"
        ElseIf table = "tbFSinif" Then
            table = "tbParamCari"
        ElseIf table = "tbSSinif" Then
            table = "tbParamStok"
        End If
        If Len(No) = 1 Then
            No = "0" + No
        End If
        Dim conn As New OleDb.OleDbConnection
        Dim cmd As New OleDb.OleDbCommand
        Dim adapter As New OleDb.OleDbDataAdapter
        conn.ConnectionString = connection
        cmd.Connection = conn
        conn.Open()
        cmd.CommandText = sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT sSinifTipi" & No & " FROM " & table & " ")
        Dim kayitsayisi = cmd.ExecuteScalar
        Return kayitsayisi
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
    Private Sub kayit_ekle()
        XtraTabPage1.PageVisible = False
        XtraTabPage2.PageVisible = True
        XtraTabControl1.SelectedTabPage = XtraTabPage2
        sec_sSinifNo.Enabled = False
        txt_sSinifKodu.Enabled = True
        If Table = "tbMSinif" Then
            txt_bSatisYapilamaz.Visible = True
        Else
            txt_bSatisYapilamaz.Visible = False
        End If
        txt_sSinifKodu.EditValue = ""
        txt_sAciklama.EditValue = ""
        txt_bSatisYapilamaz.EditValue = 0
        sLogoUrl = ""
        ' Logo onizlemeyi temizle
        Try
            If picLogo IsNot Nothing Then picLogo.Image = Nothing
        Catch
        End Try
        islem = "Ekle"
        txt_sSinifKodu.Focus()
        txt_sSinifKodu.Select()
    End Sub
    Private Sub iliski_sinif_isim()
        sinif1.Enabled = True
        sinif2.Enabled = True
        sinif3.Enabled = True
        sinif4.Enabled = True
        sinif5.Enabled = True
        sinif6.Enabled = True
        sinif7.Enabled = True
        sinif8.Enabled = True
        sinif9.Enabled = True
        sinif10.Enabled = True
        sinif11.Enabled = True
        sinif12.Enabled = True
        sinif13.Enabled = True
        sinif14.Enabled = True
        sinif15.Enabled = True
        If Integer.Parse(Trim(sec_sSinifNo.Text)) = 1 Then
            sinif1.Enabled = False
        ElseIf Integer.Parse(Trim(sec_sSinifNo.Text)) = 2 Then
            sinif2.Enabled = False
        ElseIf Integer.Parse(Trim(sec_sSinifNo.Text)) = 3 Then
            sinif3.Enabled = False
        ElseIf Integer.Parse(Trim(sec_sSinifNo.Text)) = 4 Then
            sinif4.Enabled = False
        ElseIf Integer.Parse(Trim(sec_sSinifNo.Text)) = 5 Then
            sinif5.Enabled = False
        ElseIf Integer.Parse(Trim(sec_sSinifNo.Text)) = 6 Then
            sinif6.Enabled = False
        ElseIf Integer.Parse(Trim(sec_sSinifNo.Text)) = 7 Then
            sinif7.Enabled = False
        ElseIf Integer.Parse(Trim(sec_sSinifNo.Text)) = 8 Then
            sinif8.Enabled = False
        ElseIf Integer.Parse(Trim(sec_sSinifNo.Text)) = 9 Then
            sinif9.Enabled = False
        ElseIf Integer.Parse(Trim(sec_sSinifNo.Text)) = 10 Then
            sinif10.Enabled = False
        ElseIf Integer.Parse(Trim(sec_sSinifNo.Text)) = 11 Then
            sinif11.Enabled = False
        ElseIf Integer.Parse(Trim(sec_sSinifNo.Text)) = 12 Then
            sinif12.Enabled = False
        ElseIf Integer.Parse(Trim(sec_sSinifNo.Text)) = 13 Then
            sinif13.Enabled = False
        ElseIf Integer.Parse(Trim(sec_sSinifNo.Text)) = 14 Then
            sinif14.Enabled = False
        ElseIf Integer.Parse(Trim(sec_sSinifNo.Text)) = 15 Then
            sinif15.Enabled = False
        End If
    End Sub
    Private Function cevirNull(ByVal obj As Object) As String
        If IsDBNull(obj) Then
            obj = ""
        End If
        Return obj
    End Function
    Private Sub kayit_duzelt()
        iliski_sinif_isim()
        XtraTabPage1.PageVisible = False
        XtraTabPage2.PageVisible = True
        XtraTabControl1.SelectedTabPage = XtraTabPage2
        sec_sSinifNo.Enabled = False
        satir = GridView1.FocusedRowHandle
        Dim dr As DataRow = GridView1.GetDataRow(GridView1.FocusedRowHandle)
        txt_sSinifKodu.EditValue = dr("sSinifKodu")
        txt_sAciklama.EditValue = dr("sAciklama")
        Try
            sLogoUrl = If(IsDBNull(dr("sLogoUrl")), "", dr("sLogoUrl").ToString())
            ' Logo onizleme goster
            If Not String.IsNullOrEmpty(sLogoUrl) Then
                Try
                    picLogo.LoadAsync(sLogoUrl)
                Catch
                End Try
            Else
                picLogo.Image = Nothing
            End If
        Catch
            sLogoUrl = ""
        End Try
        txt_sSinifKodu.Enabled = False
        If Table = "tbMSinif" Then
            txt_bSatisYapilamaz.Visible = True
            txt_bSatisYapilamaz.EditValue = dr("bSatisYapilamaz")
        Else
            txt_bSatisYapilamaz.Visible = False
            sinif1.EditValue = cevirNull(dr("sSinifKodu1"))
            sinif2.EditValue = cevirNull(dr("sSinifKodu2"))
            sinif3.EditValue = cevirNull(dr("sSinifKodu3"))
            sinif4.EditValue = cevirNull(dr("sSinifKodu4"))
            sinif5.EditValue = cevirNull(dr("sSinifKodu5"))
            sinif6.EditValue = cevirNull(dr("sSinifKodu6"))
            sinif7.EditValue = cevirNull(dr("sSinifKodu7"))
            sinif8.EditValue = cevirNull(dr("sSinifKodu8"))
            sinif9.EditValue = cevirNull(dr("sSinifKodu9"))
            sinif10.EditValue = cevirNull(dr("sSinifKodu10"))
            sinif11.EditValue = cevirNull(dr("sSinifKodu11"))
            sinif12.EditValue = cevirNull(dr("sSinifKodu12"))
            sinif13.EditValue = cevirNull(dr("sSinifKodu13"))
            sinif14.EditValue = cevirNull(dr("sSinifKodu14"))
            sinif15.EditValue = cevirNull(dr("sSinifKodu15"))
        End If
        islem = "Düzelt"
        dr = Nothing
        txt_sAciklama.Focus()
        txt_sAciklama.SelectAll()
    End Sub
    Private Sub kayit_kaydir()
        XtraTabPage1.PageVisible = False
        XtraTabPage2.PageVisible = False
        XtraTabPage3.PageVisible = True
        XtraTabControl1.SelectedTabPage = XtraTabPage3
        dataload_tbSSinif(Table, No)
        sec_sSinifNo.Enabled = False
        satir = GridView1.FocusedRowHandle
        Dim dr As DataRow = GridView1.GetDataRow(GridView1.FocusedRowHandle)
        sec_sSinifKodu1.EditValue = dr("sSinifKodu")
        islem = "Kaydir"
        dr = Nothing
        sec_sSinifKodu1.Focus()
        sec_sSinifKodu1.Select()
    End Sub
    Private Sub dataload_tbSSinif(ByVal table As String, ByVal no As String)
        sec_sSinifKodu1.Properties.DataSource = sorgu(sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT     * FROM         " & table & no & " Order by sSinifKodu")).Tables(0)
        sec_sSinifKodu2.Properties.DataSource = sorgu(sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT     * FROM         " & table & no & " Order by sSinifKodu")).Tables(0)
        sec_sSinifKodu1.EditValue = ""
        sec_sSinifKodu2.EditValue = ""
    End Sub
    Private Sub satir_sil()
        If XtraMessageBox.Show(Sorgu_sDil("Kaydý Silmek Ýstediðinize Emin misiniz...?", sDil), Sorgu_sDil("Dikkat", sDil), MessageBoxButtons.YesNo, MessageBoxIcon.Question) = MsgBoxResult.Yes Then
            Dim dr As DataRow = GridView1.GetDataRow(GridView1.FocusedRowHandle)
            tbSinif_kaydet_sil(Table, No, dr("sSinifKodu"))
            Dataload_tbSinif(Table, No)
        
        ' Logo Ekle butonu dinamik olustur
        btnLogoEkle = New DevExpress.XtraEditors.SimpleButton()
        btnLogoEkle.Text = "Logo Ekle"
        btnLogoEkle.Size = New System.Drawing.Size(100, 23)
        btnLogoEkle.Location = New System.Drawing.Point(250, 93)
        AddHandler btnLogoEkle.Click, AddressOf btnLogoEkle_Click
        XtraTabPage2.Controls.Add(btnLogoEkle)
        
        ' Logo onizleme PictureEdit
        picLogo = New DevExpress.XtraEditors.PictureEdit()
        picLogo.Size = New System.Drawing.Size(80, 80)
        picLogo.Location = New System.Drawing.Point(250, 120)
        picLogo.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Zoom
        picLogo.Properties.ShowMenu = False
        XtraTabPage2.Controls.Add(picLogo)
        End If
    End Sub
    Private Sub kayit_sil()
        If GridView1.RowCount > 0 Then
            If XtraMessageBox.Show(Sorgu_sDil("Seçili Kayýtlarý Silmek Ýstediðinize Emin misiniz...?", sDil), Sorgu_sDil("Dikkat", sDil), MessageBoxButtons.YesNo, MessageBoxIcon.Question) = MsgBoxResult.Yes Then
                Dim s As String
                Dim arr As Integer()
                Dim i As Integer
                Dim toplamsayi = GridView1.SelectedRowsCount
                Dim sayi = 0
                arr = GridView1.GetSelectedRows()
                Dim dr1 As DataRow
                If arr Is Nothing Then
                Else
                    Array.Sort(arr)
                    bar.Properties.Maximum = GridView1.SelectedRowsCount
                    'panelstatus.Visible = True
                    bar.Visible = True
                    bar.Position = 0
                    For Each i In arr
                        s = i.ToString
                        dr1 = GridView1.GetDataRow(s)
                        tbSinif_kaydet_sil(Table, No, dr1("sSinifKodu"))
                        bar.Position += 1
                        bar.Refresh()
                    Next
                    XtraMessageBox.Show(Sorgu_sDil("Ýþlem Baþarýyla Tamamlandý...", sDil), Sorgu_sDil("Dikkat", sDil), MessageBoxButtons.OK, MessageBoxIcon.Information)
                    'panelstatus.Visible = False
                    bar.Visible = False
                End If
                dr1 = Nothing
                Dataload_tbSinif(Table, No)
        
        ' Logo Ekle butonu dinamik olustur
        btnLogoEkle = New DevExpress.XtraEditors.SimpleButton()
        btnLogoEkle.Text = "Logo Ekle"
        btnLogoEkle.Size = New System.Drawing.Size(100, 23)
        btnLogoEkle.Location = New System.Drawing.Point(250, 93)
        AddHandler btnLogoEkle.Click, AddressOf btnLogoEkle_Click
        XtraTabPage2.Controls.Add(btnLogoEkle)
        
        ' Logo onizleme PictureEdit
        picLogo = New DevExpress.XtraEditors.PictureEdit()
        picLogo.Size = New System.Drawing.Size(80, 80)
        picLogo.Location = New System.Drawing.Point(250, 120)
        picLogo.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Zoom
        picLogo.Properties.ShowMenu = False
        XtraTabPage2.Controls.Add(picLogo)
            End If
        End If
    End Sub
    Private Function sinif_iliski_sorgu_hazilar() As String
        Dim sinif_iliski_sorgu As String = ""
        sinif_iliskileri(0) = sinif1.Text
        sinif_iliskileri(1) = sinif2.Text
        sinif_iliskileri(2) = sinif3.Text
        sinif_iliskileri(3) = sinif4.Text
        sinif_iliskileri(4) = sinif5.Text
        sinif_iliskileri(5) = sinif6.Text
        sinif_iliskileri(6) = sinif7.Text
        sinif_iliskileri(7) = sinif8.Text
        sinif_iliskileri(8) = sinif9.Text
        sinif_iliskileri(9) = sinif10.Text
        sinif_iliskileri(10) = sinif11.Text
        sinif_iliskileri(11) = sinif12.Text
        sinif_iliskileri(12) = sinif13.Text
        sinif_iliskileri(13) = sinif14.Text
        sinif_iliskileri(14) = sinif15.Text
        For i As Integer = 1 To 15
            If i <> Integer.Parse(Trim(sec_sSinifNo.Text)) Then
                sinif_iliski_sorgu += "sSinifKodu" & i & " = '" & Trim(sinif_iliskileri(i - 1)) & "', "
            End If
        Next
        Return sinif_iliski_sorgu
    End Function
    Private Sub kaydet()
        If islem = "Ekle" Then
            tbSinif_kaydet_yeni(Table, No, txt_sSinifKodu.EditValue, txt_sAciklama.EditValue, txt_bSatisYapilamaz.EditValue, sLogoUrl)
            Dataload_tbSinif(Table, No)
        
        ' Logo Ekle butonu dinamik olustur
        btnLogoEkle = New DevExpress.XtraEditors.SimpleButton()
        btnLogoEkle.Text = "Logo Ekle"
        btnLogoEkle.Size = New System.Drawing.Size(100, 23)
        btnLogoEkle.Location = New System.Drawing.Point(250, 93)
        AddHandler btnLogoEkle.Click, AddressOf btnLogoEkle_Click
        XtraTabPage2.Controls.Add(btnLogoEkle)
        
        ' Logo onizleme PictureEdit
        picLogo = New DevExpress.XtraEditors.PictureEdit()
        picLogo.Size = New System.Drawing.Size(80, 80)
        picLogo.Location = New System.Drawing.Point(250, 120)
        picLogo.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Zoom
        picLogo.Properties.ShowMenu = False
        XtraTabPage2.Controls.Add(picLogo)
            GridView1.FocusedRowHandle = GridView1.RowCount - 1
        ElseIf islem = "Düzelt" Then
            tbSinif_kaydet_duzelt(Table, No, txt_sSinifKodu.EditValue, txt_sAciklama.EditValue, txt_bSatisYapilamaz.EditValue, sLogoUrl)
            Dataload_tbSinif(Table, No)
        
        ' Logo Ekle butonu dinamik olustur
        btnLogoEkle = New DevExpress.XtraEditors.SimpleButton()
        btnLogoEkle.Text = "Logo Ekle"
        btnLogoEkle.Size = New System.Drawing.Size(100, 23)
        btnLogoEkle.Location = New System.Drawing.Point(250, 93)
        AddHandler btnLogoEkle.Click, AddressOf btnLogoEkle_Click
        XtraTabPage2.Controls.Add(btnLogoEkle)
        
        ' Logo onizleme PictureEdit
        picLogo = New DevExpress.XtraEditors.PictureEdit()
        picLogo.Size = New System.Drawing.Size(80, 80)
        picLogo.Location = New System.Drawing.Point(250, 120)
        picLogo.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Zoom
        picLogo.Properties.ShowMenu = False
        XtraTabPage2.Controls.Add(picLogo)
            GridView1.FocusedRowHandle = satir
        End If
        XtraTabControl1.SelectedTabPageIndex = 0
        XtraTabPage1.PageVisible = True
        XtraTabPage2.PageVisible = False
        sec_sSinifNo.Enabled = True
        XtraTabControl1.SelectedTabPageIndex = 0
        GridControl1.Focus()
        GridControl1.Select()
    End Sub
    Private Sub raporla_excel()
        If XtraMessageBox.Show(Sorgu_sDil("Sonuçlarý Excel Dosyasý Oluþturmak Ýstediðinize Emin misiniz...?", sDil), Sorgu_sDil("Dikkat", sDil), MessageBoxButtons.YesNo, MessageBoxIcon.Question) = MsgBoxResult.Yes Then
            Dim SaveFileDialog1 As New Windows.Forms.SaveFileDialog
            SaveFileDialog1.Filter = "Excel Dosyalarý(*.xls) |*.xls"
            SaveFileDialog1.InitialDirectory = "c:\"
            SaveFileDialog1.FileName = "Ekstre.xls"
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
            SaveFileDialog1.FileName = "Ekstre.txt"
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
            SaveFileDialog1.FileName = "Ekstre.pdf"
            If SaveFileDialog1.ShowDialog = Windows.Forms.DialogResult.OK Then
                GridView1.ExportToPdf(SaveFileDialog1.FileName.ToString)
                If XtraMessageBox.Show(Sorgu_sDil("Kaydý Açmak Ýster misiniz...?", sDil), Sorgu_sDil("Dikkat", sDil), MessageBoxButtons.YesNo, MessageBoxIcon.Question) = MsgBoxResult.Yes Then
                    Process.Start(SaveFileDialog1.FileName.ToString)
                End If
            End If
            SaveFileDialog1 = Nothing
        End If
    End Sub
    Private Sub sec_sSinifNo_EditValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles sec_sSinifNo.EditValueChanged
        No = sec_sSinifNo.EditValue
        Try
            Dataload_tbSinif(Table, No)
        
        ' Logo Ekle butonu dinamik olustur
        btnLogoEkle = New DevExpress.XtraEditors.SimpleButton()
        btnLogoEkle.Text = "Logo Ekle"
        btnLogoEkle.Size = New System.Drawing.Size(100, 23)
        btnLogoEkle.Location = New System.Drawing.Point(250, 93)
        AddHandler btnLogoEkle.Click, AddressOf btnLogoEkle_Click
        XtraTabPage2.Controls.Add(btnLogoEkle)
        
        ' Logo onizleme PictureEdit
        picLogo = New DevExpress.XtraEditors.PictureEdit()
        picLogo.Size = New System.Drawing.Size(80, 80)
        picLogo.Location = New System.Drawing.Point(250, 120)
        picLogo.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Zoom
        picLogo.Properties.ShowMenu = False
        XtraTabPage2.Controls.Add(picLogo)
            dataload_tbSSinif(Table, No)
            lbl_sSinifKodu.Text = sorgu_sSinifTipi_kontrol(Table, No)
        Catch ex As Exception
        End Try
    End Sub
    Private Sub btn_vazgec_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_vazgec.Click
        XtraTabPage1.PageVisible = True
        XtraTabPage2.PageVisible = False
        sec_sSinifNo.Enabled = True
    End Sub
    Private Sub btn_kaydet_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_kaydet.Click
        kaydet()
    End Sub
    Private Sub MenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem1.Click
        kayit_ekle()
    End Sub
    Private Sub MenuItem2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem2.Click
        kayit_duzelt()
    End Sub
    Private Sub MenuItem3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem3.Click
        kayit_sil()
    End Sub
    Private Sub MenuItem4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem4.Click
        GridView1.ColumnsCustomization()
    End Sub
    Private Sub GörünümüKaydetToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GörünümüKaydetToolStripMenuItem.Click
        gorunum_kaydet()
    End Sub
    Private Sub MenuItem5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem5.Click
        gorunum_yazdir()
    End Sub
    Private Sub gorunum_yazdir()
        printlink1.CreateDocument(ps)
        ps.PreviewRibbonFormEx.Show()
    End Sub
    Private Sub HýzlýFiltreToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles HýzlýFiltreToolStripMenuItem.Click
        If HýzlýFiltreToolStripMenuItem.Checked = False Then
            GridView1.OptionsCustomization.AllowFilter = True
            GridView1.OptionsView.ShowFilterPanelMode = DevExpress.XtraGrid.Views.Base.ShowFilterPanelMode.Default
            GridView1.OptionsView.ShowAutoFilterRow = True
            HýzlýFiltreToolStripMenuItem.Checked = True
        ElseIf HýzlýFiltreToolStripMenuItem.Checked = True Then
            GridView1.OptionsCustomization.AllowFilter = False
            GridView1.OptionsView.ShowFilterPanelMode = DevExpress.XtraGrid.Views.Base.ShowFilterPanelMode.Never
            GridView1.OptionsView.ShowAutoFilterRow = False
            HýzlýFiltreToolStripMenuItem.Checked = False
        End If
    End Sub
    Private Sub MenuItem6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem6.Click
        If MenuItem6.Checked = False Then
            GridView1.OptionsCustomization.AllowFilter = True
            GridView1.OptionsView.ShowFilterPanelMode = DevExpress.XtraGrid.Views.Base.ShowFilterPanelMode.Default
            MenuItem6.Checked = True
        ElseIf MenuItem6.Checked = True Then
            GridView1.OptionsCustomization.AllowFilter = False
            GridView1.OptionsView.ShowFilterPanelMode = DevExpress.XtraGrid.Views.Base.ShowFilterPanelMode.Never
            MenuItem6.Checked = False
        End If
    End Sub
    Private Sub MenuItem7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem7.Click
        If MenuItem7.Checked = False Then
            GridView1.OptionsCustomization.AllowGroup = True
            GridView1.OptionsView.ShowGroupPanel = True
            MenuItem7.Checked = True
        ElseIf MenuItem7.Checked = True Then
            GridView1.OptionsCustomization.AllowGroup = False
            GridView1.OptionsView.ShowGroupPanel = False
            MenuItem7.Checked = False
        End If
    End Sub
    Private Sub MenuItem8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem8.Click
        GridView1.ExpandAllGroups()
    End Sub
    Private Sub MenuItem9_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem9.Click
        GridView1.CollapseAllGroups()
    End Sub
    Private Sub MenuItem10_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem10.Click
        If Me.WindowState = FormWindowState.Normal Then
            Me.WindowState = FormWindowState.Maximized
        ElseIf Me.WindowState = FormWindowState.Maximized Then
            Me.WindowState = FormWindowState.Normal
        End If
    End Sub
    Private Sub SimpleButton2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SimpleButton2.Click
        Me.Close()
    End Sub
    Private Sub SimpleButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SimpleButton1.Click
        Me.Close()
    End Sub
    Private Sub txt_sSinifKodu_EditValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles txt_sSinifKodu.EditValueChanged
        If Trim(txt_sSinifKodu.EditValue) <> "" Then
            btn_kaydet.Enabled = True
        Else
            btn_kaydet.Enabled = False
        End If
    End Sub
    Private Sub txt_sSinifKodu_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles txt_sSinifKodu.Validating
        If islem = "Ekle" Then
            If sorgu_sSinifKodu_kontrol(Table, No, Trim(txt_sSinifKodu.EditValue)) = False Then
                txt_sSinifKodu.ErrorText = txt_sSinifKodu.Text & vbTab & "Kaydý Daha Önce Kullanýlmýþ"
                e.Cancel = True
                txt_sSinifKodu.Focus()
                txt_sSinifKodu.SelectAll()
            End If
        End If
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
    End Sub
    Private Sub frm_tbSinif_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dataload_tbSinif(Table, No)
        
        ' Logo Ekle butonu dinamik olustur
        btnLogoEkle = New DevExpress.XtraEditors.SimpleButton()
        btnLogoEkle.Text = "Logo Ekle"
        btnLogoEkle.Size = New System.Drawing.Size(100, 23)
        btnLogoEkle.Location = New System.Drawing.Point(250, 93)
        AddHandler btnLogoEkle.Click, AddressOf btnLogoEkle_Click
        XtraTabPage2.Controls.Add(btnLogoEkle)
        
        ' Logo onizleme PictureEdit
        picLogo = New DevExpress.XtraEditors.PictureEdit()
        picLogo.Size = New System.Drawing.Size(80, 80)
        picLogo.Location = New System.Drawing.Point(250, 120)
        picLogo.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Zoom
        picLogo.Properties.ShowMenu = False
        XtraTabPage2.Controls.Add(picLogo)
        If Table = "tbMSinif" Then
            colbSatisYapilamaz.OptionsColumn.ShowInCustomizationForm = True
            colbSatisYapilamaz.Visible = True
            Me.Text = "Müþteri Sýnýf Tanýmlarý..."
            lbl_sSinifKodu.Text = sorgu_sSinifTipi_kontrol(Table, No)
        ElseIf Table = "tbFSinif" Then
            colbSatisYapilamaz.OptionsColumn.ShowInCustomizationForm = False
            colbSatisYapilamaz.Visible = False
            Me.Text = "Firma Sýnýf Tanýmlarý..."
            lbl_sSinifKodu.Text = sorgu_sSinifTipi_kontrol(Table, No)
        ElseIf Table = "tbSSinif" Then
            colbSatisYapilamaz.OptionsColumn.ShowInCustomizationForm = False
            colbSatisYapilamaz.Visible = False
            Me.Text = "Stok Sýnýf Tanýmlarý..."
            sinif1.Visible = True
            sinif2.Visible = True
            sinif3.Visible = True
            sinif4.Visible = True
            sinif5.Visible = True
            sinif6.Visible = True
            sinif7.Visible = True
            sinif8.Visible = True
            sinif9.Visible = True
            sinif10.Visible = True
            sinif11.Visible = True
            sinif12.Visible = True
            sinif13.Visible = True
            sinif14.Visible = True
            sinif15.Visible = True
            siniflab1.Visible = True
            siniflab2.Visible = True
            siniflab3.Visible = True
            siniflab4.Visible = True
            siniflab5.Visible = True
            siniflab6.Visible = True
            siniflab7.Visible = True
            siniflab8.Visible = True
            siniflab9.Visible = True
            siniflab10.Visible = True
            siniflab11.Visible = True
            siniflab12.Visible = True
            siniflab13.Visible = True
            siniflab14.Visible = True
            siniflab15.Visible = True
            sinif1.Properties.DataSource = sorgu(sorgu_query("SELECT RTRIM(sSinifKodu) AS sSinifKodu, sAciklama FROM tbSSinif1")).Tables(0)
            sinif2.Properties.DataSource = sorgu(sorgu_query("SELECT RTRIM(sSinifKodu) AS sSinifKodu, sAciklama FROM tbSSinif2")).Tables(0)
            sinif3.Properties.DataSource = sorgu(sorgu_query("SELECT RTRIM(sSinifKodu) AS sSinifKodu, sAciklama FROM tbSSinif3")).Tables(0)
            sinif4.Properties.DataSource = sorgu(sorgu_query("SELECT RTRIM(sSinifKodu) AS sSinifKodu, sAciklama FROM tbSSinif4")).Tables(0)
            sinif5.Properties.DataSource = sorgu(sorgu_query("SELECT RTRIM(sSinifKodu) AS sSinifKodu, sAciklama FROM tbSSinif5")).Tables(0)
            sinif6.Properties.DataSource = sorgu(sorgu_query("SELECT RTRIM(sSinifKodu) AS sSinifKodu, sAciklama FROM tbSSinif6")).Tables(0)
            sinif7.Properties.DataSource = sorgu(sorgu_query("SELECT RTRIM(sSinifKodu) AS sSinifKodu, sAciklama FROM tbSSinif7")).Tables(0)
            sinif8.Properties.DataSource = sorgu(sorgu_query("SELECT RTRIM(sSinifKodu) AS sSinifKodu, sAciklama FROM tbSSinif8")).Tables(0)
            sinif9.Properties.DataSource = sorgu(sorgu_query("SELECT RTRIM(sSinifKodu) AS sSinifKodu, sAciklama FROM tbSSinif9")).Tables(0)
            sinif10.Properties.DataSource = sorgu(sorgu_query("SELECT RTRIM(sSinifKodu) AS sSinifKodu, sAciklama FROM tbSSinif10")).Tables(0)
            sinif11.Properties.DataSource = sorgu(sorgu_query("SELECT RTRIM(sSinifKodu) AS sSinifKodu, sAciklama FROM tbSSinif11")).Tables(0)
            sinif12.Properties.DataSource = sorgu(sorgu_query("SELECT RTRIM(sSinifKodu) AS sSinifKodu, sAciklama FROM tbSSinif12")).Tables(0)
            sinif13.Properties.DataSource = sorgu(sorgu_query("SELECT RTRIM(sSinifKodu) AS sSinifKodu, sAciklama FROM tbSSinif13")).Tables(0)
            sinif14.Properties.DataSource = sorgu(sorgu_query("SELECT RTRIM(sSinifKodu) AS sSinifKodu, sAciklama FROM tbSSinif14")).Tables(0)
            sinif15.Properties.DataSource = sorgu(sorgu_query("SELECT RTRIM(sSinifKodu) AS sSinifKodu, sAciklama FROM tbSSinif15")).Tables(0)
            lbl_sSinifKodu.Text = sorgu_sSinifTipi_kontrol(Table, No)
        End If
    End Sub
    Private Sub txt_bSatisYapilamaz_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txt_bSatisYapilamaz.KeyDown
        If e.KeyCode = Keys.Enter Then
            btn_kaydet.Focus()
            btn_kaydet.Select()
        End If
    End Sub
    Private Sub GridControl1_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles GridControl1.KeyDown
        If e.KeyCode = Keys.Escape Then
            If XtraMessageBox.Show(Sorgu_sDil("Editör Ekranýný Kapatmak Ýstediðinize Emin misiniz...?", sDil), Sorgu_sDil("Dikkat", sDil), MessageBoxButtons.YesNo, MessageBoxIcon.Question) = MsgBoxResult.Yes Then
                Me.Close()
            End If
        End If
    End Sub
    Private Sub BarButtonItem1_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem1.ItemClick
        kayit_ekle()
    End Sub
    Private Sub BarButtonItem2_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem2.ItemClick
        kayit_duzelt()
    End Sub
    Private Sub BarButtonItem3_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem3.ItemClick
        kayit_sil()
    End Sub
    Private Sub BarButtonItem4_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem4.ItemClick
        gorunum_yazdir()
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
    Private Sub BarButtonItem8_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem8.ItemClick
        kayit_kaydir()
    End Sub
    Private Sub KaydirToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles KaydirToolStripMenuItem.Click
        kayit_kaydir()
    End Sub
    Private Sub SimpleButton4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SimpleButton4.Click
        XtraTabPage1.PageVisible = True
        XtraTabPage2.PageVisible = False
        XtraTabPage3.PageVisible = False
        sec_sSinifNo.Enabled = True
    End Sub
    Private Sub SimpleButton3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SimpleButton3.Click
        Dim bDevam As Boolean = True
        If sec_sSinifKodu1.EditValue = "" Then
            bDevam = False
            XtraMessageBox.Show("Eski Kodu Boþ Býrakamazsýnýz...", Sorgu_sDil("Dikkat", sDil), MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If
        If sec_sSinifKodu2.EditValue = "" Then
            bDevam = False
            XtraMessageBox.Show("Yeni Kodu Boþ Býrakamazsýnýz...", Sorgu_sDil("Dikkat", sDil), MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If
        If bDevam = True Then
            If XtraMessageBox.Show(sec_sSinifKodu1.EditValue & vbTab & "Kodlu SýnýfKodu Kayýtlarýný " & vbCrLf & sec_sSinifKodu2.EditValue & vbTab & "Kodlu Sýnýf Koduna Kaydýrmak Ýstediðinize Emin misiniz...?", Sorgu_sDil("Dikkat", sDil), MessageBoxButtons.YesNo, MessageBoxIcon.Question) = MsgBoxResult.Yes Then
                tbSinifKaydir(Table, No, sec_sSinifKodu1.EditValue, sec_sSinifKodu2.EditValue)
                XtraMessageBox.Show(Sorgu_sDil("Ýþlem Baþarýyla Tamamlandý...!", sDil), Sorgu_sDil("Dikkat", sDil), MessageBoxButtons.OK, MessageBoxIcon.Information)
                XtraTabPage1.PageVisible = True
                XtraTabPage2.PageVisible = False
                XtraTabPage3.PageVisible = False
                sec_sSinifNo.Enabled = True
            End If
        End If
    End Sub
    Private Sub tbSinifKaydir(ByVal table As String, ByVal no As Integer, ByVal sSinifKodu As String, ByVal sYeniSinifKodu As String)
        Dim cmd As New OleDb.OleDbCommand
        Dim con As New OleDb.OleDbConnection
        cmd.Connection = con
        con.ConnectionString = connection
        cmd.CommandTimeout = Nothing
        If table = "tbMSinif" Then
            table = "tbMusteri"
        ElseIf table = "tbFSinif" Then
            table = "tbFirmaSinifi"
        ElseIf table = "tbSSinif" Then
            table = "tbStokSinifi"
        End If
        If con.State = ConnectionState.Closed = True Then
            con.Open()
        End If
        cmd.CommandText = sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED Update " & table & " set sSinifKodu" & no & " = '" & sYeniSinifKodu & "' Where sSinifKodu" & no & " = '" & sSinifKodu & "'")
        Try
            cmd.ExecuteNonQuery()
        Catch ex As Exception
            XtraMessageBox.Show(ex.ToString)
        End Try
        con.Close()
    End Sub
    Dim sinif_iliskileri(15) As String
    Private Sub sinif1_EditValueChanged(sender As System.Object, e As System.EventArgs) Handles sinif1.EditValueChanged
        sinif_iliskileri(0) = sinif1.Text
    End Sub
    Private Sub sinif2_EditValueChanged(sender As System.Object, e As System.EventArgs) Handles sinif2.EditValueChanged
        sinif_iliskileri(1) = sinif2.Text
    End Sub
    Private Sub sinif3_EditValueChanged(sender As System.Object, e As System.EventArgs) Handles sinif3.EditValueChanged
        sinif_iliskileri(2) = sinif3.Text
    End Sub
    Private Sub sinif4_EditValueChanged(sender As System.Object, e As System.EventArgs) Handles sinif4.EditValueChanged
        sinif_iliskileri(3) = sinif4.Text
    End Sub
    Private Sub sinif5_EditValueChanged(sender As System.Object, e As System.EventArgs) Handles sinif5.EditValueChanged
        sinif_iliskileri(4) = sinif5.Text
    End Sub
    Private Sub sinif6_EditValueChanged(sender As System.Object, e As System.EventArgs) Handles sinif6.EditValueChanged
        sinif_iliskileri(5) = sinif6.Text
    End Sub
    Private Sub sinif7_EditValueChanged(sender As System.Object, e As System.EventArgs) Handles sinif7.EditValueChanged
        sinif_iliskileri(6) = sinif7.Text
    End Sub
    Private Sub sinif8_EditValueChanged(sender As System.Object, e As System.EventArgs) Handles sinif8.EditValueChanged
        sinif_iliskileri(7) = sinif8.Text
    End Sub
    Private Sub sinif9_EditValueChanged(sender As System.Object, e As System.EventArgs) Handles sinif9.EditValueChanged
        sinif_iliskileri(8) = sinif9.Text
    End Sub
    Private Sub sinif10_EditValueChanged(sender As System.Object, e As System.EventArgs) Handles sinif10.EditValueChanged
        sinif_iliskileri(9) = sinif10.Text
    End Sub
    Private Sub sinif11_EditValueChanged(sender As System.Object, e As System.EventArgs) Handles sinif11.EditValueChanged
        sinif_iliskileri(10) = sinif11.Text
    End Sub
    Private Sub sinif12_EditValueChanged(sender As System.Object, e As System.EventArgs) Handles sinif12.EditValueChanged
        sinif_iliskileri(11) = sinif12.Text
    End Sub
    Private Sub sinif13_EditValueChanged(sender As System.Object, e As System.EventArgs) Handles sinif13.EditValueChanged
        sinif_iliskileri(12) = sinif13.Text
    End Sub
    Private Sub sinif14_EditValueChanged(sender As System.Object, e As System.EventArgs) Handles sinif14.EditValueChanged
        sinif_iliskileri(13) = sinif14.Text
    End Sub
    Private Sub sinif15_EditValueChanged(sender As System.Object, e As System.EventArgs) Handles sinif15.EditValueChanged
        sinif_iliskileri(14) = sinif15.Text
    End Sub

    Private Sub btnLogoEkle_Click(sender As Object, e As EventArgs)
        ResimSecVeYukle()
    End Sub
    
    ' ========== R2 RESIM YUKLEME (sLogoUrl icin) ==========
    Public Async Sub ResimSecVeYukle()
        Try
            OpenFileDialog1.Filter = "Resim Dosyalarý|*.jpg;*.jpeg;*.png;*.gif;*.bmp|Tüm Dosyalar|*.*"
            OpenFileDialog1.Title = "Sýnýf Logo Resmi Seç"
            
            If OpenFileDialog1.ShowDialog() <> Windows.Forms.DialogResult.OK Then
                Exit Sub
            End If
            
            Dim sourcePath As String = OpenFileDialog1.FileName
            Dim sSinifKodu As String = Trim(txt_sSinifKodu.EditValue.ToString())
            
            If String.IsNullOrEmpty(sSinifKodu) Then
                XtraMessageBox.Show("Lütfen önce sýnýf kodu girin!", "Uyarý", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Exit Sub
            End If
            
            ' Resmi byte array'e çevir
            Dim imageBytes As Byte()
            Using fs As New System.IO.FileStream(sourcePath, System.IO.FileMode.Open, System.IO.FileAccess.Read)
                ReDim imageBytes(CInt(fs.Length) - 1)
                fs.Read(imageBytes, 0, imageBytes.Length)
            End Using
            
            ' Firma klasör adýný al
            Dim klasor As String = ""
            Try
                Dim sOnayKodu As String = ""
                Try
                    sOnayKodu = Microsoft.Win32.Registry.LocalMachine.OpenSubKey("Software").OpenSubKey("BusinessSmart").OpenSubKey("Key").GetValue("sOnayKodu").ToString()
                Catch
                    sOnayKodu = ""
                End Try
                
                If Not String.IsNullOrEmpty(sOnayKodu) AndAlso sOnayKodu <> "0" Then
                    Try
                        Dim licenseResult = ApiClient.VerifyLicense(sOnayKodu, "")
                        If licenseResult.IsValid AndAlso Not String.IsNullOrEmpty(licenseResult.OzelNot) Then
                            klasor = licenseResult.OzelNot.Trim()
                        End If
                    Catch
                    End Try
                End If
            Catch
                klasor = ""
            End Try
            
            ' R2'ye upload et
            Dim fileName As String = Table & No.ToString() & "_" & sSinifKodu.Replace(" ", "_").Replace("/", "_") & "_logo.jpg"
            Dim objectKey As String = If(String.IsNullOrEmpty(klasor),
                "sinif_logos/" & fileName,
                "sinif_logos/" & klasor & "/" & fileName)
            
            Dim uploadedUrl As String = Await R2Helpers.R2UploadFromBytesAsync(imageBytes, objectKey, "image/jpeg")
            
            If Not String.IsNullOrEmpty(uploadedUrl) Then
                sLogoUrl = uploadedUrl
                ' PictureEdit'i guncelle
                Try
                    picLogo.LoadAsync(uploadedUrl)
                Catch
                End Try
                XtraMessageBox.Show("Resim baþarýyla yüklendi!", "Baþarýlý", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else
                XtraMessageBox.Show("Resim yüklenemedi!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
            
        Catch ex As Exception
            XtraMessageBox.Show("Resim yükleme hatasý: " & ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

End Class