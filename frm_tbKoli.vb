Imports FastReport
Imports DevExpress.XtraEditors
Public Class frm_tbKoli
    Public firmano
    Public donemno
    Public connection
    Public kullanici
    Dim conn As New OleDb.OleDbConnection
    Dim con As New OleDb.OleDbConnection
    Dim cmd As New OleDb.OleDbCommand
    Dim adapter As New OleDb.OleDbDataAdapter
    Dim DS As New DataSet
    Dim dr As DataRow
    Dim dataset1 As New DataSet
    Dim ds_fiyattipi As DataSet
    Dim islem As String = ""
    Dim satir
    Private Sub frm_tbDepo_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dataload_tbKoli()
        'FiyatTipleri
        ds_fiyattipi = sorgu(sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT     * FROM         tbFiyatTipi where (aktif = 1) and (aktifDepo like '%" & Trim(sDepo) & "%')"))
        sec_sFiyatTipi.DataSource = ds_fiyattipi.Tables(0)
        Try
            gorunum_yukle()
        Catch ex As Exception
        End Try
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
    Public Sub Dataload_tbKoli()
        Try
            ds_tbKoli.Tables(0).Clear()
        Catch ex As Exception
        End Try
        Dim conn As New OleDb.OleDbConnection
        Dim cmd As New OleDb.OleDbCommand
        Dim adapter As New OleDb.OleDbDataAdapter
        conn.ConnectionString = connection
        adapter.SelectCommand = cmd
        cmd.CommandText = sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT * From tbKoli Where sKoliKodu <>'' ")
        cmd.Connection = conn
        conn.Open()
        Dim N As Integer = adapter.Fill(ds_tbKoli, "Table1")
        conn.Close()
        GridControl1.Focus()
        GridControl1.Select()
        If GridView1.RowCount > 0 Then
            dr = GridView1.GetDataRow(GridView1.FocusedRowHandle)
            Dataload_tbKoliDagilimi(dr("sKoliKodu"))
        End If
    End Sub
    Public Sub Dataload_tbKoliDagilimi(ByVal sKoliKodu As String)
        'Dim conn As New OleDb.OleDbConnection
        'Dim cmd As New OleDb.OleDbCommand
        'Dim adapter As New OleDb.OleDbDataAdapter
        'conn.ConnectionString = connection
        'adapter.SelectCommand = cmd
        dataset1 = sorgu(sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT tbKoliDagilimi.sKoliKodu, tbKoliDagilimi.nStokID, tbKoliDagilimi.lMiktar,tbKoliDagilimi.sBirimCinsi,tbKoliDagilimi.lBirimMiktar,tbKoliDagilimi.lFiyat,tbKoliDagilimi.sFiyatTipi, tbStok.sModel,tbStok.sKodu,tbStok.sAciklama, tbStok.sKisaAdi, tbStok.nStokTipi, tbStok.sRenk, (SELECT sRenkAdi FROM tbRenk WHERE sRenk = tbStok.sRenk) AS sRenkAdi,tbStok.sBeden, tbStok.sBirimCinsi1, tbStok.nIskontoYuzdesi, tbStok.sKdvTipi, tbStok.sOzelNot, tbStok.sModel, tbKoli.sAciklama AS sKoliAciklama FROM tbKoliDagilimi INNER JOIN tbStok ON tbKoliDagilimi.nStokID = tbStok.nStokID INNER JOIN tbKoli ON tbKoliDagilimi.sKoliKodu = tbKoli.sKoliKodu Where tbKoliDagilimi.sKoliKodu ='" & sKoliKodu & "' "))
        GridControl2.DataSource = dataset1.Tables(0)
        GridControl2.DataMember = Nothing
        'cmd.Connection = conn
        'conn.Open()
        'Dim N As Integer = adapter.Fill(ds_tbKoliDagilimi, "Table1")
        'conn.Close()
        'GridControl1.Focus()
        'GridControl1.Select()
    End Sub
    Private Sub tbKoli_kaydet_yeni(ByVal sKoliKodu As String, ByVal sAciklama As String)
        Dim cmd As New OleDb.OleDbCommand
        Dim con As New OleDb.OleDbConnection
        cmd.Connection = con
        con.ConnectionString = connection
        cmd.CommandTimeout = Nothing
        If con.State = ConnectionState.Closed = True Then
            con.Open()
        End If
        cmd.CommandText = sorgu_query("SET DATEFORMAT DMY SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED INSERT INTO tbKoli (sKoliKodu, sAciklama) VALUES     ('" & sKoliKodu & "', N'" & sAciklama & "')")
        cmd.ExecuteNonQuery()
        con.Close()
    End Sub
    Private Sub tbKoliDagilimi_kaydet_yeni(ByVal sKoliKodu As String, ByVal nStokID As Int64, ByVal lMiktar As Decimal, ByVal sBirimCinsi As String, ByVal lBirimMiktar As Decimal, ByVal lFiyat As Decimal, ByVal sFiyatTipi As String)
        Dim cmd As New OleDb.OleDbCommand
        Dim con As New OleDb.OleDbConnection
        cmd.Connection = con
        con.ConnectionString = connection
        cmd.CommandTimeout = Nothing
        If con.State = ConnectionState.Closed = True Then
            con.Open()
        End If
        cmd.CommandText = sorgu_query("SET DATEFORMAT DMY SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED INSERT INTO tbKoliDagilimi (sKoliKodu, nStokID,lMiktar,sBirimCinsi,lBirimMiktar,lFiyat,sFiyatTipi) VALUES     ('" & sKoliKodu & "', " & nStokID & "," & lMiktar & ",'" & sBirimCinsi & "'," & lBirimMiktar & "," & lFiyat & ",'" & sFiyatTipi & "')")
        cmd.ExecuteNonQuery()
        con.Close()
    End Sub
    Private Sub tbKoli_kaydet_duzelt(ByVal sKoliKodu As String, ByVal sAciklama As String)
        Dim cmd As New OleDb.OleDbCommand
        Dim con As New OleDb.OleDbConnection
        cmd.Connection = con
        con.ConnectionString = connection
        cmd.CommandTimeout = Nothing
        If con.State = ConnectionState.Closed = True Then
            con.Open()
        End If
        cmd.CommandText = sorgu_query("SET DATEFORMAT DMY SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED UPDATE    tbKoli SET              sAciklama = N'" & sAciklama & "' Where sKoliKodu = '" & sKoliKodu & "'")
        cmd.ExecuteNonQuery()
        con.Close()
    End Sub
    Private Sub tbKoliDagilimi_kaydet_duzelt(ByVal sKoliKodu As String, ByVal nStokID As Int64, ByVal lMiktar As Decimal, ByVal sBirimCinsi As String, ByVal lBirimMiktar As Decimal, ByVal lFiyat As Decimal, ByVal sFiyatTipi As String)
        Dim cmd As New OleDb.OleDbCommand
        Dim con As New OleDb.OleDbConnection
        cmd.Connection = con
        con.ConnectionString = connection
        cmd.CommandTimeout = Nothing
        If con.State = ConnectionState.Closed = True Then
            con.Open()
        End If
        cmd.CommandText = sorgu_query("SET DATEFORMAT DMY SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED UPDATE    tbKoliDagilimi SET              sKoliKodu ='" & sKoliKodu & "',nStokID =" & nStokID & " ,lMiktar =" & lMiktar & ",sBirimCinsi = '" & sBirimCinsi & "',lBirimMiktar = " & lBirimMiktar & ",lFiyat = " & lFiyat & ",sFiyatTipi = '" & sFiyatTipi & "' Where sKoliKodu = '" & sKoliKodu & "' and nStokID =" & nStokID & "")
        cmd.ExecuteNonQuery()
        con.Close()
    End Sub
    Private Sub tbKoli_kaydet_sil(ByVal sKoliKodu As String)
        Dim cmd As New OleDb.OleDbCommand
        Dim con As New OleDb.OleDbConnection
        cmd.Connection = con
        con.ConnectionString = connection
        cmd.CommandTimeout = Nothing
        If con.State = ConnectionState.Closed = True Then
            con.Open()
        End If
        cmd.CommandText = sorgu_query("SET DATEFORMAT DMY SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED DELETE FROM tbKoli Where sKoliKodu  ='" & sKoliKodu & "'")
        cmd.ExecuteNonQuery()
        con.Close()
    End Sub
    Private Sub tbKoliDagilimi_kaydet_sil(ByVal sKoliKodu As String, ByVal nStokID As Int64)
        Dim cmd As New OleDb.OleDbCommand
        Dim con As New OleDb.OleDbConnection
        cmd.Connection = con
        con.ConnectionString = connection
        cmd.CommandTimeout = Nothing
        If con.State = ConnectionState.Closed = True Then
            con.Open()
        End If
        cmd.CommandText = sorgu_query("SET DATEFORMAT DMY SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED DELETE FROM tbKoliDagilimi Where sKoliKodu  ='" & sKoliKodu & "' and nStokID =" & nStokID & "")
        cmd.ExecuteNonQuery()
        con.Close()
    End Sub
    Public Function sorgu_sKavala_kontrol(ByVal sKoliKodu As String) As Boolean
        Dim kriter
        Dim pass As Boolean
        kriter = ""
        Dim conn As New OleDb.OleDbConnection
        Dim cmd As New OleDb.OleDbCommand
        Dim adapter As New OleDb.OleDbDataAdapter
        conn.ConnectionString = connection
        cmd.Connection = conn
        conn.Open()
        cmd.CommandText = sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT     ISNULL(COUNT(sKoliKodu), 0) AS nKayit FROM         tbKoli WHERE     (sKoliKodu = '" & sKoliKodu & "') and sKoliKodu <>'' ")
        Dim kayitsayisi = cmd.ExecuteScalar
        If kayitsayisi = 0 Then
            cmd.CommandText = sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT     ISNULL(COUNT(sKodu), 0) AS nKayit FROM         tbStok WHERE     (sKodu = '" & sKoliKodu & "') and sKodu <>'' ")
            kayitsayisi = cmd.ExecuteScalar
        End If
        If kayitsayisi = 0 Then
            cmd.CommandText = sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT     ISNULL(COUNT(sBarkod), 0) AS nKayit FROM         tbStokBarkodu WHERE     (sBarkod = '" & sKoliKodu & "') and sBarkod <>'' ")
            kayitsayisi = cmd.ExecuteScalar
        End If
        If kayitsayisi = 0 Then
            pass = True
        Else
            pass = False
        End If
        Return pass
    End Function
    Public Function sorgu_ntbKoliDagilimi(ByVal sKoliKodu As String, ByVal nStokID As Int64) As Int64
        'kriter = "WHERE (sKodu = '" & kod & "')  "
        Dim conn As New OleDb.OleDbConnection
        Dim cmd As New OleDb.OleDbCommand
        Dim adapter As New OleDb.OleDbDataAdapter
        'MsgBox(connection_resmi)
        conn.ConnectionString = connection
        cmd.Connection = conn
        conn.Open()
        cmd.CommandText = sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT     COUNT(*) AS nKayit FROM         tbKoliDagilimi WHERE     (nStokID = " & nStokID & ") AND (sKoliKodu = '" & sKoliKodu & "')")
        Dim kayitsayisi = cmd.ExecuteScalar
        Return kayitsayisi
    End Function
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
            Dim dr1 As DataRow
            Dim dr As DataRow = GridView1.GetDataRow(GridView1.FocusedRowHandle)
            arr = frm.GridView1.GetSelectedRows()
            If arr Is Nothing Then
            Else
                Array.Sort(arr)
                For Each i In arr
                    s = i.ToString
                    dr1 = frm.GridView1.GetDataRow(s)
                    If sorgu_ntbKoliDagilimi(dr("sKoliKodu"), dr1("nStokID")) = 0 Then
                        tbKoliDagilimi_kaydet_yeni(dr("sKoliKodu"), dr1("nStokID"), 1, dr1("sBirimCinsi1"), 1, 0, "")
                    End If
                Next
            End If
            Dataload_tbKoliDagilimi(dr("sKoliKodu"))
        End If
    End Sub
    Private Sub kayit_ekle()
        XtraTabPage1.PageVisible = False
        XtraTabPage2.PageVisible = True
        txt_sKoliKodu.EditValue = ""
        txt_sAciklama.EditValue = ""
        txt_sKoliKodu.Enabled = True
        islem = "Ekle"
        txt_sKoliKodu.Focus()
        txt_sKoliKodu.Select()
    End Sub
    Private Sub kayit_duzelt()
        XtraTabPage1.PageVisible = False
        XtraTabPage2.PageVisible = True
        satir = GridView1.FocusedRowHandle
        Dim dr As DataRow = GridView1.GetDataRow(GridView1.FocusedRowHandle)
        txt_sKoliKodu.EditValue = dr("sKoliKodu")
        txt_sAciklama.EditValue = dr("sAciklama")
        txt_sKoliKodu.Enabled = False
        islem = "Düzelt"
        dr = Nothing
        txt_sAciklama.Focus()
        txt_sAciklama.SelectAll()
    End Sub
    Private Sub kayit_sil()
        If XtraMessageBox.Show(Sorgu_sDil("Kaydı Silmek İstediğinize Emin misiniz...?", sDil), Sorgu_sDil("Dikkat", sDil), MessageBoxButtons.YesNo, MessageBoxIcon.Question) = MsgBoxResult.Yes Then
            Dim dr As DataRow = GridView1.GetDataRow(GridView1.FocusedRowHandle)
            Dim satir = GridView1.FocusedRowHandle
            tbKoli_kaydet_sil(dr("sKoliKodu"))
            Dataload_tbKoli()
            GridView1.FocusedRowHandle = satir
            satir = Nothing
        End If
    End Sub
    Private Sub dagilim_kayit_sil()
        If XtraMessageBox.Show(Sorgu_sDil("Kaydı Silmek İstediğinize Emin misiniz...?", sDil), Sorgu_sDil("Dikkat", sDil), MessageBoxButtons.YesNo, MessageBoxIcon.Question) = MsgBoxResult.Yes Then
            Dim dr As DataRow = GridView2.GetDataRow(GridView2.FocusedRowHandle)
            Dim satir = GridView2.FocusedRowHandle
            tbKoliDagilimi_kaydet_sil(dr("sKoliKodu"), dr("nStokID"))
            Dataload_tbKoliDagilimi(dr("sKoliKodu"))
            GridView2.FocusedRowHandle = satir
            satir = Nothing
        End If
    End Sub
    Private Sub kaydet()
        If islem = "Ekle" Then
            tbKoli_kaydet_yeni(txt_sKoliKodu.EditValue, txt_sAciklama.EditValue)
            Dataload_tbKoli()
            GridView1.FocusedRowHandle = GridView1.RowCount - 1
        ElseIf islem = "Düzelt" Then
            tbKoli_kaydet_duzelt(txt_sKoliKodu.EditValue, txt_sAciklama.EditValue)
            Dataload_tbKoli()
            GridView1.FocusedRowHandle = satir
        End If
        XtraTabPage1.PageVisible = True
        XtraTabPage2.PageVisible = False
        GridControl1.Focus()
        GridControl1.Select()
    End Sub
    Private Sub analiz_envanter()
        If GridView2.RowCount > 0 Then
            dr = GridView2.GetDataRow(GridView2.FocusedRowHandle)
            Dim frm As New frm_stok_envanter
            frm.firmano = firmano
            frm.donemno = donemno
            frm.connection = connection
            frm.stokno = dr("nStokId")
            frm.stokkodu = dr("sKodu")
            frm.kullanici = kullanici
            If yetki_kontrol(kullanici, frm.Name) = True Then
                frm.ShowDialog()
            End If
            frm.Close()
            frm.Dispose()
            frm = Nothing
        End If
    End Sub
    Private Sub analiz_hareket_transfer()
        If GridView2.RowCount > 0 Then
            dr = GridView2.GetDataRow(GridView2.FocusedRowHandle)
            Dim frm As New frm_stok_hareketleri_transfer
            frm.firmano = firmano
            frm.donemno = donemno
            frm.connection = connection
            'frm.stokno = dr("nStokId")
            frm.stokkodu = Trim(dr("sKodu"))
            frm.kullanici = kullanici
            If yetki_kontrol(kullanici, frm.Name) = True Then
                frm.ShowDialog()
            End If
            frm.Close()
            frm.Dispose()
            frm = Nothing
        End If
    End Sub
    Private Sub analiz_stok_hareket()
        If GridView2.RowCount > 0 Then
            Dim dr As DataRow = GridView2.GetDataRow(GridView2.FocusedRowHandle)
            Dim frm As New frm_stok_hareketleri
            frm.firmano = firmano
            frm.donemno = donemno
            frm.connection = connection
            frm.musterino = dr("sKodu")
            frm.nFirmaID = 0
            frm.sec_firma.Checked = False
            frm.sec_giris.Text = "[Tümü]"
            frm.collGirisFiyat.Visible = False
            frm.collGirisFiyat.OptionsColumn.ShowInCustomizationForm = False
            frm.collCikisFiyat.Visible = False
            frm.collCikisFiyat.OptionsColumn.ShowInCustomizationForm = False
            frm.collBrutFiyat.Visible = False
            frm.collBrutFiyat.OptionsColumn.ShowInCustomizationForm = False
            frm.collBrutTutar.Visible = False
            frm.collBrutTutar.OptionsColumn.ShowInCustomizationForm = False
            frm.colnKdvOrani.Visible = False
            frm.colnKdvOrani.OptionsColumn.ShowInCustomizationForm = False
            frm.collIskontoTutari.Visible = False
            frm.collIskontoTutari.OptionsColumn.ShowInCustomizationForm = False
            frm.colnGirisCikis.Visible = False
            frm.MenuItem16.Enabled = False
            frm.MenuItem17.Enabled = False
            frm.MenuItem20.Enabled = False
            frm.Label1.Text = dr("sAciklama") & vbCrLf & frm.Label1.Text
            frm.kullanici = kullanici
            If yetki_kontrol(kullanici, frm.Name) = True Then
                frm.ShowDialog()
            End If
            frm.Close()
            frm.Dispose()
            frm = Nothing
        End If
    End Sub
    Private Sub analiz_envanter_model()
        If GridView2.RowCount > 0 Then
            dr = GridView2.GetDataRow(GridView2.FocusedRowHandle)
            Dim frm As New frm_stok_envanter_model
            frm.firmano = firmano
            frm.donemno = donemno
            frm.connection = connection
            frm.modelno = dr("sModel")
            frm.kullanici = kullanici
            If yetki_kontrol(kullanici, frm.Name) = True Then
                frm.ShowDialog()
            End If
            frm.Close()
            frm.Dispose()
            frm = Nothing
        End If
    End Sub
    Private Sub analiz_hareket()
        dr = GridView1.GetDataRow(GridView1.FocusedRowHandle)
        'stkdll.firmano = firmano
        'stkdll.donemno = donemno
        'stkdll.connection = connection
        'stkdll.stokno = dr("IND")
        'stkdll.rptfiyatanalizi(dr("IND"), 100, dr("MALINCINSI"), 2)
    End Sub
    Private Sub stok_fiyat()
        If GridView2.RowCount > 0 Then
            dr = GridView2.GetDataRow(GridView2.FocusedRowHandle)
            Dim frm As New frm_stok_fiyatlandir
            frm.firmano = firmano
            frm.donemno = donemno
            frm.connection = connection
            frm.nStokID = dr("nStokId")
            frm.sModel = dr("sModel")
            frm.sKodu = dr("sKodu")
            frm.sRenk = dr("sRenk")
            frm.sBeden = dr("sBeden")
            frm.txt_musteriNo.Text = dr("sModel")
            frm.kullanici = kullanici
            If yetki_kontrol(kullanici, frm.Name) = True Then
                frm.ShowDialog()
            End If
            frm.Close()
            frm.Dispose()
            frm = Nothing
        End If
    End Sub
    Private Sub stok_duzelt()
        If GridView2.RowCount > 0 Then
            dr = GridView2.GetDataRow(GridView2.FocusedRowHandle)
            Dim frm As New frm_stok_kart
            frm.firmano = firmano
            frm.donemno = donemno
            frm.connection = connection
            frm.nStokID = dr("nStokID")
            frm.sKodu = dr("sKodu")
            frm.sModel = dr("sModel")
            frm.kullanici = kullanici
            If yetki_kontrol(kullanici, frm.Name) = True Then
                frm.ShowDialog()
            End If
            frm.Close()
            frm.Dispose()
            frm = Nothing
        End If
    End Sub
    Private Sub EkleToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EkleToolStripMenuItem.Click
        kayit_ekle()
    End Sub
    Private Sub SimpleButton2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SimpleButton2.Click
        Me.Close()
    End Sub
    Private Sub SimpleButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SimpleButton1.Click
        Me.Close()
    End Sub
    Private Sub GörünümüDüzenleToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GörünümüDüzenleToolStripMenuItem.Click
        GridView1.ColumnsCustomization()
    End Sub
    Private Sub GörünümüKaydetToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GörünümüKaydetToolStripMenuItem.Click
        gorunum_kaydet()
    End Sub
    Private Sub GörünümüYazdırToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GörünümüYazdırToolStripMenuItem.Click
        gorunum_yazdir()
    End Sub
    Private Sub gorunum_yazdir()
        If GridControl1.Focused = True Then
            printlink1.CreateDocument(ps)
            ps.PreviewRibbonFormEx.Show()
        ElseIf GridControl2.Focused = True Then
            printlink2.CreateDocument(ps)
            ps.PreviewRibbonFormEx.Show()
        End If
    End Sub
    Private Sub raporla_excel()
        If XtraMessageBox.Show(Sorgu_sDil("Sonuçları Excel Dosyası Oluşturmak İstediğinize Emin misiniz...?", sDil), Sorgu_sDil("Dikkat", sDil), MessageBoxButtons.YesNo, MessageBoxIcon.Question) = MsgBoxResult.Yes Then
            Dim SaveFileDialog1 As New Windows.Forms.SaveFileDialog
            SaveFileDialog1.Filter = "Excel Dosyaları(*.xls) |*.xls"
            SaveFileDialog1.InitialDirectory = "c:\"
            SaveFileDialog1.FileName = "Ekstre.xls"
            If SaveFileDialog1.ShowDialog = Windows.Forms.DialogResult.OK Then
                GridView1.ExportToXls(SaveFileDialog1.FileName.ToString)
                If XtraMessageBox.Show(Sorgu_sDil("Kaydı Açmak İster misiniz...?", sDil), Sorgu_sDil("Dikkat", sDil), MessageBoxButtons.YesNo, MessageBoxIcon.Question) = MsgBoxResult.Yes Then
                    Process.Start(SaveFileDialog1.FileName.ToString)
                End If
            End If
            SaveFileDialog1 = Nothing
        End If
    End Sub
    Private Sub raporla_text()
        If XtraMessageBox.Show(Sorgu_sDil("Sonuçları Text Dosyası Oluşturmak İstediğinize Emin misiniz...?", sDil), Sorgu_sDil("Dikkat", sDil), MessageBoxButtons.YesNo, MessageBoxIcon.Question) = MsgBoxResult.Yes Then
            Dim SaveFileDialog1 As New Windows.Forms.SaveFileDialog
            SaveFileDialog1.Filter = "Text Dosyaları(*.txt) |*.txt"
            SaveFileDialog1.InitialDirectory = "c:\"
            SaveFileDialog1.FileName = "Ekstre.txt"
            If SaveFileDialog1.ShowDialog = Windows.Forms.DialogResult.OK Then
                GridView1.ExportToText(SaveFileDialog1.FileName.ToString)
                If XtraMessageBox.Show(Sorgu_sDil("Kaydı Açmak İster misiniz...?", sDil), Sorgu_sDil("Dikkat", sDil), MessageBoxButtons.YesNo, MessageBoxIcon.Question) = MsgBoxResult.Yes Then
                    Process.Start(SaveFileDialog1.FileName.ToString)
                End If
            End If
            SaveFileDialog1 = Nothing
        End If
    End Sub
    Private Sub raporla_pdf()
        If XtraMessageBox.Show(Sorgu_sDil("Sonuçları Metin Dosyası Oluşturmak İstediğinize Emin misiniz...?", sDil), Sorgu_sDil("Dikkat", sDil), MessageBoxButtons.YesNo, MessageBoxIcon.Question) = MsgBoxResult.Yes Then
            Dim SaveFileDialog1 As New Windows.Forms.SaveFileDialog
            SaveFileDialog1.Filter = "Metin Dosyaları(*.pdf) |*.pdf"
            SaveFileDialog1.InitialDirectory = "c:\"
            SaveFileDialog1.FileName = "Ekstre.pdf"
            If SaveFileDialog1.ShowDialog = Windows.Forms.DialogResult.OK Then
                GridView1.ExportToPdf(SaveFileDialog1.FileName.ToString)
                If XtraMessageBox.Show(Sorgu_sDil("Kaydı Açmak İster misiniz...?", sDil), Sorgu_sDil("Dikkat", sDil), MessageBoxButtons.YesNo, MessageBoxIcon.Question) = MsgBoxResult.Yes Then
                    Process.Start(SaveFileDialog1.FileName.ToString)
                End If
            End If
            SaveFileDialog1 = Nothing
        End If
    End Sub
    Private Sub HızlıFiltreToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles HızlıFiltreToolStripMenuItem.Click
        If HızlıFiltreToolStripMenuItem.Checked = False Then
            GridView1.OptionsCustomization.AllowFilter = True
            GridView1.OptionsView.ShowFilterPanelMode = DevExpress.XtraGrid.Views.Base.ShowFilterPanelMode.Default
            GridView1.OptionsView.ShowAutoFilterRow = True
            HızlıFiltreToolStripMenuItem.Checked = True
        ElseIf HızlıFiltreToolStripMenuItem.Checked = True Then
            GridView1.OptionsCustomization.AllowFilter = False
            GridView1.OptionsView.ShowFilterPanelMode = DevExpress.XtraGrid.Views.Base.ShowFilterPanelMode.Never
            GridView1.OptionsView.ShowAutoFilterRow = False
            HızlıFiltreToolStripMenuItem.Checked = False
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
    Private Sub DuzeltToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DuzeltToolStripMenuItem.Click
        kayit_duzelt()
    End Sub
    Private Sub SilToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SilToolStripMenuItem.Click
        kayit_sil()
    End Sub
    Private Sub btn_vazgec_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_vazgec.Click
        XtraTabPage1.PageVisible = True
        XtraTabPage2.PageVisible = False
        GridControl1.Focus()
        GridControl1.Select()
    End Sub
    Private Sub btn_kaydet_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_kaydet.Click
        kaydet()
    End Sub
    Private Sub txt_sKoliKodu_EditValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles txt_sKoliKodu.EditValueChanged
        If Len(txt_sKoliKodu.EditValue.ToString) <> 0 Then
            lbl_sBarkod.Text = Len(txt_sKoliKodu.Text.ToString)
        ElseIf Len(txt_sKoliKodu.EditValue.ToString) = 5 Then
            'txt_sBirimCinsi1.EditValue = "KG "
        Else
            lbl_sBarkod.Text = "*"
        End If
        If Len(txt_sKoliKodu.EditValue.ToString) >= 12 Then
            If IsNumeric(txt_sKoliKodu.Text) = True Then
                lbl_checkdigit.Text = Ean13_CheckSum(Microsoft.VisualBasic.Left(txt_sKoliKodu.Text, 12))
            End If
        ElseIf Len(txt_sKoliKodu.EditValue.ToString) >= 7 Then
            If IsNumeric(txt_sKoliKodu.Text) = True Then
                lbl_checkdigit.Text = EAN8_Checksum(Microsoft.VisualBasic.Left(txt_sKoliKodu.Text, 7))
            End If
        End If
        If Len(txt_sKoliKodu.EditValue.ToString) = 8 Then
            If Microsoft.VisualBasic.Right(txt_sKoliKodu.Text, 1) = lbl_checkdigit.Text Then
                lbl_barcodestd.Text = "Ean8"
            Else
                lbl_barcodestd.Text = "-"
            End If
        ElseIf Len(txt_sKoliKodu.EditValue.ToString) = 13 Then
            If Microsoft.VisualBasic.Right(txt_sKoliKodu.Text, 1) = lbl_checkdigit.Text Then
                lbl_barcodestd.Text = "Ean13"
            Else
                lbl_barcodestd.Text = "-"
            End If
        Else
            lbl_barcodestd.Text = "-"
        End If
    End Sub
    Private Function Ean13_CheckSum(ByVal barcode As String) As Integer
        Dim X As Integer = 0
        Dim Y As Integer = 0
        Dim j As Integer = 11
        Dim m_checksum As Integer = 0
        Try
            For i As Integer = 1 To 12
                If i Mod 2 = 0 Then
                    X += Val(barcode(j))
                Else
                    Y += Val(barcode(j))
                End If
                j -= 1
            Next
            Dim Z As Integer = X + (3 * Y)
            'first(way)
            'Dim m_CheckSum As Integer = ((10 - (Z Mod 10)) Mod 10)
            'second way
            Dim M As Integer = Z
            Do Until (M Mod 10 = 0)
                M += 1
            Loop
            m_checksum = M - Z
            Return m_checksum
        Catch ex As Exception
            DevExpress.XtraEditors.XtraMessageBox.Show(ex.Message)
            Return False
        End Try
    End Function
    Private Function EAN8_Checksum(ByVal EAN8_Barcode As String) As String
        'http://www.barcodeisland.com/ean8.phtml
        Dim ChecksumCalculation As Integer = 0
        Dim Position As Int32 = 1
        For i As Integer = EAN8_Barcode.Length - 1 To 0 Step -1
            If Position Mod 2 = 1 Then
                'odd position
                ChecksumCalculation += Convert.ToInt32(EAN8_Barcode.Substring(i, 1)) * 3
            Else
                'even position
                ChecksumCalculation += Convert.ToInt32(EAN8_Barcode.Substring(i, 1)) * 1
            End If
            Position += 1
        Next
        Dim Checksum As Integer = 10 - (ChecksumCalculation Mod 10)
        Return Microsoft.VisualBasic.Right(Convert.ToString(Checksum), 1)
    End Function
    Private Sub txt_sKoliKodu_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txt_sKoliKodu.KeyDown
        If e.KeyCode = Keys.F5 Then
            txt_sKoliKodu.Text = tbSonKod("tbKoli").ToString
        End If
    End Sub
    Private Function tbSonKod(ByVal islem As String) As String
        Dim frm As New frm_tbSonKod
        frm.firmano = firmano
        frm.donemno = donemno
        frm.connection = connection
        frm.kullanici = kullanici
        frm.islem = islem
        Dim sKodu As String = ""
        If frm.ShowDialog(Me) = Windows.Forms.DialogResult.OK Then
            sKodu = frm.lbl_Kod.Text
        End If
        frm.Close()
        frm = Nothing
        Return sKodu
    End Function
    Private Sub txt_sKoliKodu_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles txt_sKoliKodu.Validating
        If islem = "Ekle" Then
            If sorgu_sKavala_kontrol(Trim(txt_sKoliKodu.EditValue)) = False Then
                txt_sKoliKodu.ErrorText = txt_sKoliKodu.Text & vbTab & "Kaydı Daha Önce Kullanılmış"
                e.Cancel = True
                txt_sKoliKodu.Focus()
                txt_sKoliKodu.SelectAll()
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
    Private Sub GridView1_FocusedRowChanged(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs) Handles GridView1.FocusedRowChanged
        Try
            If GridView1.RowCount > 0 Then
                dr = GridView1.GetDataRow(GridView1.FocusedRowHandle)
                Dataload_tbKoliDagilimi(dr("sKoliKodu"))
            End If
        Catch ex As Exception
        End Try
    End Sub
    Private Sub GridView1_SelectionChanged(ByVal sender As Object, ByVal e As DevExpress.Data.SelectionChangedEventArgs) Handles GridView1.SelectionChanged
        If GridView1.SelectedRowsCount > 1 Then
            Label2.Text = Sorgu_sDil("Kayıt Sayısı :", sDil) & GridView1.RowCount & " / " & Sorgu_sDil("Satır :", sDil) & GridView1.FocusedRowHandle + 1 & " / " & Sorgu_sDil("Seçili :", sDil) & GridView1.SelectedRowsCount
        ElseIf GridView1.SelectedRowsCount = 1 Then
            Label2.Text = Sorgu_sDil("Kayıt Sayısı :", sDil) & GridView1.RowCount & " / " & Sorgu_sDil("Satır :", sDil) & GridView1.FocusedRowHandle + 1
        Else
            Label2.Text = ""
        End If
    End Sub
    Private Sub GridControl1_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles GridControl1.KeyDown
        If e.KeyCode = Keys.Escape Then
            If XtraMessageBox.Show(Sorgu_sDil("Editör Ekranını Kapatmak İstediğinize Emin misiniz...?", sDil), Sorgu_sDil("Dikkat", sDil), MessageBoxButtons.YesNo, MessageBoxIcon.Question) = MsgBoxResult.Yes Then
                Me.Close()
            End If
        End If
    End Sub
    Private Sub BarButtonItem1_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem1.ItemClick
        kayit_ekle()
    End Sub
    Private Sub BarButtonItem2_ItemClick(ByVal sender As Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem2.ItemClick
        kayit_duzelt()
    End Sub
    Private Sub BarButtonItem3_ItemClick(ByVal sender As Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem3.ItemClick
        kayit_sil()
    End Sub
    Private Sub BarButtonItem4_ItemClick(ByVal sender As Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem4.ItemClick
        gorunum_yazdir()
    End Sub
    Private Sub BarButtonItem5_ItemClick(ByVal sender As Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem5.ItemClick
        raporla_excel()
    End Sub
    Private Sub BarButtonItem6_ItemClick(ByVal sender As Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem6.ItemClick
        raporla_text()
    End Sub
    Private Sub BarButtonItem7_ItemClick(ByVal sender As Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem7.ItemClick
        raporla_pdf()
    End Sub
    Private Sub MenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem1.Click
        satir_ekle_stok()
    End Sub
    Private Sub GridView2_CellValueChanged(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs) Handles GridView2.CellValueChanged
        If GridView2.RowCount > 0 Then
            Dim dr As DataRow
            GridView2.PostEditor()
            dr = GridView2.GetDataRow(GridView2.FocusedRowHandle)
            dr("lMiktar") = sorgu_sayi(dr("lMiktar"), 1)
            dr.EndEdit()
            tutar_hesapla()
        End If
    End Sub
    Private Sub tutar_hesapla()
        Dim dr As DataRow
        GridView2.PostEditor()
        dr = GridView2.GetDataRow(GridView2.FocusedRowHandle)
        dr("lMiktar") = sorgu_sayi(dr("lMiktar"), 1)
        dr.EndEdit()
        tbKoliDagilimi_kaydet_duzelt(dr("sKoliKodu"), dr("nStokID"), dr("lMiktar"), dr("sBirimCinsi"), dr("lBirimMiktar"), dr("lFiyat"), dr("sFiyatTipi"))
    End Sub
    Private Sub MenuItem3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem3.Click
        dagilim_kayit_sil()
    End Sub
    Private Sub MenuItem4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem4.Click
        stok_fiyat()
    End Sub
    Private Sub MenuItem5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem5.Click
        analiz_envanter()
    End Sub
    Private Sub MenuItem11_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem11.Click
        analiz_envanter_model()
    End Sub
    Private Sub MenuItem21_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem21.Click
        analiz_hareket()
    End Sub
    Private Sub MenuItem19_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem19.Click
        analiz_hareket_transfer()
    End Sub
    Private Sub MenuItem14_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem14.Click
        GridView2.ColumnsCustomization()
    End Sub
    Private Sub MenuItem17_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem17.Click
        gorunum_kaydet()
    End Sub
    Private Sub MenuItem18_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem18.Click
        gorunum_yazdir()
    End Sub
    Private Sub MenuItem26_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem26.Click
    End Sub
    Private Sub MenuItem30_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem30.Click
        If Me.WindowState = FormWindowState.Normal Then
            Me.WindowState = FormWindowState.Maximized
        ElseIf Me.WindowState = FormWindowState.Maximized Then
            Me.WindowState = FormWindowState.Normal
        End If
    End Sub
    Private Sub raporla(ByVal rapor As Integer, ByVal nislem As Integer, Optional ByVal bTumu As Boolean = False)
        Dim OpenFileDialog1 As New Windows.Forms.OpenFileDialog
        OpenFileDialog1.Title = "Rapor Seç..."
        OpenFileDialog1.Filter = "Rapor Dosyaları (FormKoli*.fr*) |FormKoli*.fr*"
        OpenFileDialog1.FileName = "c:\Formlar\Etiket\FormKoli" & sRaporUzanti & ""
        OpenFileDialog1.InitialDirectory = "c:\Formlar\Etiket"
        If OpenFileDialog1.ShowDialog = Windows.Forms.DialogResult.OK Then
            Dim sFile = OpenFileDialog1.FileName.ToString
            Dim dr As DataRow
            dr = GridView1.GetDataRow(GridView1.FocusedRowHandle)
            If Microsoft.VisualBasic.Right(sFile, 3) = "frx" Then
                Dim report As New FastReport.Report
                report.Load(sFile)
                report.RegisterData(ds_tbParamGenel)
                report.RegisterData(dataset1)
                report.ScriptLanguage = Language.Vb
                If nislem = 0 Then
                    report.Show()
                ElseIf nislem = 2 Then
                    report.Design()
                ElseIf nislem = 1 Then
                    report.Print()
                End If
                report.Dispose()
                report = Nothing
            End If
        End If
    End Sub
    Private Sub sBirimCinsi_sec(Optional ByVal bAktar As Boolean = False)
        Dim frm As New frm_tbStokBirim
        Dim dr As DataRow = GridView2.GetDataRow(GridView2.FocusedRowHandle)
        frm.firmano = firmano
        frm.donemno = donemno
        frm.connection = connection
        frm.sModel = dr("sModel").ToString
        frm.sBirimCinsi = dr("sBirimCinsi").ToString
        frm.lMiktar = CType(dr("lMiktar"), Decimal)
        If frm.ShowDialog(Me) = Windows.Forms.DialogResult.OK Then
            Dim dr1 As DataRow
            dr1 = frm.GridView1.GetDataRow(frm.GridView1.FocusedRowHandle)
            dr("lFiyat") = dr("lFiyat") / dr("lBirimMiktar")
            If Integer.Parse(dr1("bTersOran").ToString()) = 1 Then
                dr("lBirimMiktar") = (1 / Double.Parse(dr1("lOran").ToString())).ToString()
            Else
                dr("lBirimMiktar") = dr1("lOran")
            End If
            dr("sBirimCinsi") = dr1("sBirimCinsi")
            dr("lFiyat") = dr("lFiyat") * dr("lBirimMiktar")
            dr1 = Nothing
            GridView2.UpdateCurrentRow()
            tutar_hesapla()
        End If
        frm.Close()
        frm = Nothing
    End Sub
    Private Sub MenuItem22_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem22.Click
        raporla(0, 0)
    End Sub
    Private Sub MenuItem23_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem23.Click
        raporla(0, 2)
    End Sub
    Private Sub MenuItem24_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem24.Click
        raporla(0, 1)
    End Sub
    Private Sub MenuItem2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem2.Click
        stok_duzelt()
    End Sub
    Private Sub GridView2_CustomDrawRowIndicator(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Grid.RowIndicatorCustomDrawEventArgs) Handles GridView2.CustomDrawRowIndicator
        If e.RowHandle >= 0 Then
            e.Info.DisplayText = e.RowHandle + 1
        Else
            e.Info.DisplayText = ""
        End If
    End Sub
    Private Sub sec_sBirimCinsi_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles sec_sBirimCinsi.KeyDown
        If e.KeyCode = Keys.Space Then
            sBirimCinsi_sec(True)
        ElseIf e.KeyCode = Keys.F6 Then
            sBirimCinsi_sec(True)
        End If
    End Sub
    Private Sub MenuItem31_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem31.Click
        sBirimCinsi_sec(True)
    End Sub
End Class