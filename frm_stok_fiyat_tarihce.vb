Imports Microsoft.Win32
Imports DevExpress.XtraEditors
Public Class frm_stok_fiyat_tarihce
    Public firmano
    Public donemno
    Public connection
    Public nStokID
    Public sKodu
    Public sModel
    Public sRenk As String
    Public sBeden As String
    Public sFiyatTipi As String
    Public kullanici
    Dim conn As New OleDb.OleDbConnection
    Dim con As New OleDb.OleDbConnection
    Dim cmd As New OleDb.OleDbCommand
    Dim adapter As New OleDb.OleDbDataAdapter
    Dim DS As New DataSet
    Dim ds_stok As DataSet
    Dim ds_nStokID As DataSet
    Dim ds_tbFiyatTipi As DataSet
    Dim ds_tbFiyatlandirma As DataSet
    Dim ds_tbStokSonHareket As DataSet
    Dim yuklendi As Boolean = False
    Public nAST As Integer = 0
    Dim maliyet As Decimal = 0
    Private Sub frm_stok_fiyat_tarihce_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        If sModel = "" Then
            stok_sec()
        Else
            txt_musteriNo.EditValue = sModel
            dataload(sModel, sFiyatTipi)
        End If
        dataload_tbFiyatlandirma()
        dataload_tbFiyatTipi()
        'txt_dteFiyatTespitTarihi.EditValue = dteSistemTarihi
        GridControl2.Focus()
        GridControl2.Select()
        Try
            gorunum_yukle()
        Catch ex As Exception
        End Try
    End Sub
    Private Sub dataload_tbFiyatlandirma()
        ds_tbFiyatlandirma = sorgu(sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT     * FROM         tbFiyatlandirma"))
        txt_nFiyatlandirma.Properties.DataSource = ds_tbFiyatlandirma.Tables(0)
    End Sub
    Private Sub dataload_tbFiyatTipi()
        ds_tbFiyatTipi = sorgu(sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT     sFiyatTipi,sAciklama FROM         tbFiyatTipi Where nAST <> 4 and (aktif = 1) and (aktifDepo like '%" & Trim(sDepo) & "%') Order by sFiyatTipi"))
        'txt_sFiyatTipi.Properties.DataSource = ds_tbFiyatTipi.Tables(0)
    End Sub
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
    Private Sub gorunum_yazdir()
        printlink1.CreateDocument(ps)
        ps.PreviewRibbonFormEx.Show()
    End Sub
    Private Sub gorunum_kaydet()
        GridView2.SaveLayoutToRegistry("SOFTWARE\BusinessSmart\VIEW\STOK\" & Me.Name.ToString & "\Fiyat")
        XtraMessageBox.Show(Sorgu_sDil("Görünüm Kaydedildi", sDil), Sorgu_sDil("Dikkat", sDil), MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub
    Private Sub gorunum_yukle()
        For Each btn As DevExpress.XtraBars.BarItem In BarManager1.Items
            btn.Caption = Sorgu_sDil(btn.Caption, sDil)
        Next
        For Each clmn As DevExpress.XtraGrid.Columns.GridColumn In GridView2.Columns
            clmn.Caption = Sorgu_sDil(clmn.Caption, sDil)
        Next
        SimpleButton1.Text = Sorgu_sDil(SimpleButton1.Text, sDil)
        SimpleButton2.Text = Sorgu_sDil(SimpleButton2.Text, sDil)
        GridView2.RestoreLayoutFromRegistry("SOFTWARE\BusinessSmart\VIEW\STOK\" & Me.Name.ToString & "\Fiyat")
    End Sub
    Private Sub stok_sec()
        Dim frm As New frm_stok_liste
        frm.firmano = firmano
        frm.donemno = donemno
        frm.connection = connection
        frm.islemstatus = True
        frm.kullanici = kullanici
        If frm.ShowDialog(Me) = Windows.Forms.DialogResult.OK Then
            Dim dr1 As DataRow
            dr1 = frm.GridView1.GetDataRow(frm.GridView1.FocusedRowHandle)
            nStokID = dr1("nStokID")
            sKodu = dr1("sKodu")
            sModel = dr1("sModel")
            txt_musteriNo.EditValue = sModel
            stok_kontrol()
            dr1 = Nothing
        End If
    End Sub
    Private Sub dataload(ByVal sModel As String, ByVal sFiyatTipi As String)
        Dataload_tbStok(sModel)
        Dataload_tbStokFiyat(sModel, sFiyatTipi)
        yuklendi = True
    End Sub
    Public Sub Dataload_tbStok(ByVal sModel As String)
        Try
            ds_tbStok.Tables(0).Clear()
        Catch ex As Exception
        End Try
        Dim conn As New OleDb.OleDbConnection
        Dim cmd As New OleDb.OleDbCommand
        Dim adapter As New OleDb.OleDbDataAdapter
        conn.ConnectionString = connection
        adapter.SelectCommand = cmd
        cmd.CommandText = sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT TOP 1 * From tbStok WHERE sModel ='" & sModel & "'")
        cmd.Connection = conn
        conn.Open()
        Dim N As Integer = adapter.Fill(ds_tbStok, "Table1")
        conn.Close()
    End Sub
    Public Sub Dataload_tbStokAcilimi(ByVal sModel As String)
        Try
            ds_tbStokAcilim.Tables(0).Clear()
        Catch ex As Exception
        End Try
        Dim conn As New OleDb.OleDbConnection
        Dim cmd As New OleDb.OleDbCommand
        Dim adapter As New OleDb.OleDbDataAdapter
        conn.ConnectionString = connection
        adapter.SelectCommand = cmd
        cmd.CommandText = sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT nStokID, sModel, sKodu,sAciklama, sRenk, sBeden ,(SELECT     sRenkAdi FROM          tbRenk WHERE      sRenk = tbStok.sRenk) AS sRenkAdi FROM tbStok WHERE sModel = '" & sModel & "'")
        cmd.Connection = conn
        conn.Open()
        Dim N As Integer = adapter.Fill(ds_tbStokAcilim, "Table1")
        conn.Close()
    End Sub
    Public Sub Dataload_tbStokFiyat(ByVal sModel As String, ByVal sFiyatTipi As String, Optional ByVal nAST As Integer = 0)
        Try
            ds_tbStokFiyat.Tables(0).Clear()
        Catch ex As Exception
        End Try
        Dim kriter_nAST As String
        Dim conn As New OleDb.OleDbConnection
        Dim cmd As New OleDb.OleDbCommand
        Dim adapter As New OleDb.OleDbDataAdapter
        conn.ConnectionString = connection
        adapter.SelectCommand = cmd
        If nAST = 0 Then
            kriter_nAST = " AND (tbFiyatTipi.nAST <> 4)"
        Else
            kriter_nAST = " AND (tbFiyatTipi.nAST = " & nAST & ")"
        End If
        'cmd.CommandText = sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT DISTINCT tbFiyatTipi.sFiyatTipi, tbFiyatTipi.sAciklama, tbStokFiyatiHistory.dteFiyatTespitTarihi, tbStokFiyatiHistory.lFiyat, tbStokFiyatiHistory.dteKayitTarihi AS dteKayitTarihi, tbStokFiyatiHistory.sKullaniciAdi, CAST(0 AS Money) AS Oran FROM tbStokFiyatiHistory INNER JOIN tbFiyatTipi ON tbStokFiyatiHistory.sFiyatTipi = tbFiyatTipi.sFiyatTipi AND tbStokFiyatiHistory.nStokID IN (SELECT nStokID FROM tbStok WHERE sModel = '" & sModel & "') WHERE (tbFiyatTipi.sFiyatTipi = '" & sFiyatTipi & "') ORDER BY tbStokFiyatiHistory.dteFiyatTespitTarihi, tbStokFiyatiHistory.dteKayitTarihi DESC ")
        cmd.CommandText = sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT DISTINCT tbFiyatTipi.sFiyatTipi, tbFiyatTipi.sAciklama, auStokFiyati.dteFiyatTespitTarihi, auStokFiyati.lFiyat, auStokFiyati.dteKayitTarihi AS dteKayitTarihi, auStokFiyati.sKullaniciAdi, CAST(0 AS Money) AS Oran FROM auStokFiyati INNER JOIN tbFiyatTipi ON auStokFiyati.sFiyatTipi = tbFiyatTipi.sFiyatTipi AND auStokFiyati.nStokID IN (SELECT nStokID FROM tbStok WHERE sModel = '" & sModel & "') WHERE (tbFiyatTipi.sFiyatTipi = '" & sFiyatTipi & "') ORDER BY auStokFiyati.dteFiyatTespitTarihi, auStokFiyati.dteKayitTarihi DESC ")
        cmd.Connection = conn
        conn.Open()
        Dim N As Integer = adapter.Fill(ds_tbStokFiyat, "Table1")
        conn.Close()
    End Sub
    Public Sub Dataload_tbStokFiyat_sRenk(ByVal sModel As String, ByVal sRenk As String)
        Try
            ds_tbStokFiyat.Tables(0).Clear()
        Catch ex As Exception
        End Try
        Dim conn As New OleDb.OleDbConnection
        Dim cmd As New OleDb.OleDbCommand
        Dim adapter As New OleDb.OleDbDataAdapter
        conn.ConnectionString = connection
        adapter.SelectCommand = cmd
        cmd.CommandText = sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT DISTINCT RTRIM(tbFiyatTipi.sFiyatTipi) as sFiyatTipi, tbFiyatTipi.sAciklama,  ISNULL(tbStokFiyati.lFiyat, 0) AS lFiyat, tbStokFiyati.dteFiyatTespitTarihi,Cast(0 as Money) as Oran FROM tbFiyatTipi LEFT OUTER JOIN tbStokFiyati ON tbFiyatTipi.sFiyatTipi = tbStokFiyati.sFiyatTipi AND tbStokFiyati.nStokID IN (SELECT nStokID FROM tbStok WHERE sModel = '" & sModel & "' and sRenk = '" & sRenk & "') WHERE (tbFiyatTipi.sFiyatTipi <> '') AND (tbFiyatTipi.nAST <> 4) ORDER BY tbFiyatTipi.sFiyatTipi ")
        cmd.Connection = conn
        conn.Open()
        Dim N As Integer = adapter.Fill(ds_tbStokFiyat, "Table1")
        conn.Close()
    End Sub
    Public Sub Dataload_tbStokFiyat_sRenk_sBeden(ByVal sModel As String, ByVal sRenk As String, ByVal sBeden As String)
        Try
            ds_tbStokFiyat.Tables(0).Clear()
        Catch ex As Exception
        End Try
        Dim conn As New OleDb.OleDbConnection
        Dim cmd As New OleDb.OleDbCommand
        Dim adapter As New OleDb.OleDbDataAdapter
        conn.ConnectionString = connection
        adapter.SelectCommand = cmd
        cmd.CommandText = sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT DISTINCT RTRIM(tbFiyatTipi.sFiyatTipi) as sFiyatTipi, tbFiyatTipi.sAciklama,  ISNULL(tbStokFiyati.lFiyat, 0) AS lFiyat, tbStokFiyati.dteFiyatTespitTarihi,Cast(0 as Money) as Oran FROM tbFiyatTipi LEFT OUTER JOIN tbStokFiyati ON tbFiyatTipi.sFiyatTipi = tbStokFiyati.sFiyatTipi AND tbStokFiyati.nStokID IN (SELECT nStokID FROM tbStok WHERE sModel = '" & sModel & "' and sRenk ='" & sRenk & "' and sBeden = '" & sBeden & "') WHERE (tbFiyatTipi.sFiyatTipi <> '') AND (tbFiyatTipi.nAST <> 4) ORDER BY tbFiyatTipi.sFiyatTipi ")
        cmd.Connection = conn
        conn.Open()
        Dim N As Integer = adapter.Fill(ds_tbStokFiyat, "Table1")
        conn.Close()
        maliyet = 0
        Dim dr1 As DataRow
        For Each dr1 In ds_tbStokFiyat.Tables(0).Rows
            If Trim(dr1("sFiyatTipi").ToString) = Trim(sFiyatM.ToString) Then
                maliyet = dr1("lFiyat")
            End If
        Next
        dr1 = Nothing
    End Sub
    Private Function sorgu_tbStokFiyati_kontrol(ByVal nFiyatlandirma As Int64, ByVal sModel As String, ByVal sRenk As String, ByVal sBeden As String, ByVal sFiyatTipi As String) As Decimal
        Dim cmd As New OleDb.OleDbCommand
        Dim con As New OleDb.OleDbConnection
        Dim kayitsayisi As Int64
        con.ConnectionString = connection
        cmd.Connection = con
        If con.State = ConnectionState.Closed Then
            con.Open()
        End If
        If nFiyatlandirma = 0 Then
            cmd.CommandText = "SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT COUNT(*) AS Kayit FROM tbFiyatTipi INNER JOIN (SELECT DISTINCT (sFiyatTipi) AS sFiyatTipi , lFiyat , dteFiyatTespitTarihi FROM tbStokFiyati , tbStok WHERE tbStokFiyati.nStokID = tbStok.nStokID AND sFiyatTipi = '" & sFiyatTipi & "' AND tbStok.sModel = '" & sModel & "') Fiyat ON tbFiyatTipi.sFiyatTipi = Fiyat.sFiyatTipi WHERE (tbFiyatTipi.sFiyatTipi <> '') AND (tbFiyatTipi.sFiyatTipi = '" & sFiyatTipi & "')"
        ElseIf nFiyatlandirma = 1 Then
            cmd.CommandText = "SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT COUNT(*) AS Kayit FROM tbFiyatTipi INNER JOIN (SELECT DISTINCT (sFiyatTipi) AS sFiyatTipi , lFiyat , dteFiyatTespitTarihi FROM tbStokFiyati , tbStok WHERE tbStokFiyati.nStokID = tbStok.nStokID AND sFiyatTipi = '" & sFiyatTipi & "' AND tbStok.sModel = '" & sModel & "' and tbStok.sRenk = '" & sRenk & "') Fiyat ON tbFiyatTipi.sFiyatTipi = Fiyat.sFiyatTipi WHERE (tbFiyatTipi.sFiyatTipi <> '') AND (tbFiyatTipi.sFiyatTipi = '" & sFiyatTipi & "')"
        ElseIf nFiyatlandirma = 2 Then
            cmd.CommandText = "SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT COUNT(*) AS Kayit FROM tbFiyatTipi INNER JOIN (SELECT DISTINCT (sFiyatTipi) AS sFiyatTipi , lFiyat , dteFiyatTespitTarihi FROM tbStokFiyati , tbStok WHERE tbStokFiyati.nStokID = tbStok.nStokID AND sFiyatTipi = '" & sFiyatTipi & "' AND tbStok.sModel = '" & sModel & "'and tbStok.sRenk = '" & sRenk & "' and tbStok.sBeden = '" & sBeden & "') Fiyat ON tbFiyatTipi.sFiyatTipi = Fiyat.sFiyatTipi WHERE (tbFiyatTipi.sFiyatTipi <> '') AND (tbFiyatTipi.sFiyatTipi = '" & sFiyatTipi & "')"
        End If
        kayitsayisi = cmd.ExecuteScalar()
        con.Close()
        Return kayitsayisi
    End Function
    Private Sub stok_kontrol()
        If Trim(txt_musteriNo.EditValue).ToString <> "" Then
            Dim kontrol = sorgu_stok_kontrol(txt_musteriNo.EditValue)
            If kontrol = 0 Then
                XtraMessageBox.Show(Sorgu_sDil("Kayýt Bulunumadý...", sDil), Sorgu_sDil("Dikkat", sDil), MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            ElseIf kontrol = 1 Then
                dataload_stok(txt_musteriNo.EditValue)
                Dim dr As DataRow
                For Each dr In ds_stok.Tables(0).Rows
                    'txt_Musteri.EditValue = dr("MUSTERI")
                    sKodu = dr("sKodu")
                    nStokID = dr("nStokID")
                    sModel = dr("sModel")
                    dataload(sModel, sFiyatTipi)
                Next
                dr = Nothing
            End If
        End If
    End Sub
    Public Function sorgu_stok_kontrol(ByVal kod As String) As Int64
        Dim kriter
        kriter = "WHERE (sKodu like '" & kod & "%') "
        Dim conn As New OleDb.OleDbConnection
        Dim cmd As New OleDb.OleDbCommand
        Dim adapter As New OleDb.OleDbDataAdapter
        conn.ConnectionString = connection
        cmd.Connection = conn
        conn.Open()
        cmd.CommandText = sorgu_query("SET DATEFORMAT DMY SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT     ISNULL(COUNT(*), 0) AS KAYIT  FROM         tbStok " & kriter & "")
        Dim kayitsayisi = cmd.ExecuteScalar
        Return kayitsayisi
    End Function
    Private Sub dataload_stok(ByVal kod As String)
        Dim kriter
        kriter = "WHERE (sKodu like  '" & kod & "%') "
        ds_stok = sorgu(sorgu_query("SELECT     top 1 nStokID,sKodu,sAciklama,sModel,sRenk,sBeden FROM         tbStok " & kriter & ""))
    End Sub
    Private Sub SimpleButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SimpleButton1.Click
        Me.Close()
    End Sub
    Private Sub SimpleButton2_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles SimpleButton2.Click
        Me.Close()
    End Sub
    Private Sub GridControl2_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles GridControl2.KeyDown
        If e.KeyCode = Keys.Escape Then
            Me.Close()
        End If
    End Sub
    Private Sub BarButtonItem1_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem1.ItemClick
        gorunum_yazdir()
    End Sub
End Class