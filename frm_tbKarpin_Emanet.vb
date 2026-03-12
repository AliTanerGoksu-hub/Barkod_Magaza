Imports DevExpress.XtraEditors
Public Class frm_tbKarpin_Emanet
    Public firmano
    Public DonemNo
    Public Connection
    Public nKarpinID As Integer = 0
    Public dteFisTarihi As DateTime
    Public sSatici As String
    Public sDepo As String
    Public sFisTipi As String
    Public kullanici As String
    Dim nKayitSinir As Integer = 0
    Dim dataset1 As New DataSet
    Dim dr As DataRow
    Private Sub SimpleButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SimpleButton1.Click
        Me.Close()
    End Sub
    Private Sub SimpleButton2_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles SimpleButton2.Click
        Me.Close()
    End Sub
    Private Sub frm_tbKarpin_Emanet_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        If sFisTipi = 1 Then
            lbl_istihbarat.Text = "Emanet Giriþleri......."
        ElseIf sFisTipi = 2 Then
            lbl_istihbarat.Text = "Emanet Çýkýþlarý......."
        ElseIf sFisTipi = 3 Then
            lbl_istihbarat.Text = "Emanet Ýadeleri........"
        End If
        dataload()
    End Sub
    Private Sub dataload()
        dataset1 = query_emanet(nKarpinID, dteFisTarihi, sSatici, sDepo, sFisTipi)
        GridControl1.DataSource = dataset1.Tables(0)
        GridControl1.Select()
        GridControl1.Focus()
        dr = GridView1.GetDataRow(GridView1.FocusedRowHandle)
    End Sub
    Public Function query_emanet(ByVal nKarpinID As Int64, ByVal dteFisTarihi As DateTime, ByVal sSatici As String, ByVal sDepo As String, ByVal sFisTipi As String) As DataSet
        Dim conn As New OleDb.OleDbConnection
        Dim cmd As New OleDb.OleDbCommand
        Dim adapter As New OleDb.OleDbDataAdapter
        conn.ConnectionString = Connection
        adapter.SelectCommand = cmd
        cmd.CommandText = "SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT *,1 AS STATUS FROM         tbKarpinEmanet WHERE nKarpinID = " & nKarpinID & "  AND sFisTipi ='" & sFisTipi & "' ORDER BY nKayitID"
        cmd.Connection = conn
        conn.Open()
        Dim ds As New DataSet
        Dim N As Integer = adapter.Fill(ds, "SEVKIYAT")
        conn.Close()
        Return ds
    End Function
    Private Function sorgu_query(ByVal query As String) As String
        query = Replace(query, "*!F", "F0" + firmano.ToString)
        query = Replace(query, "!D", "D000" + DonemNo.ToString)
        Return query
    End Function
    Private Function KayitSiniri_kontrol(ByVal tbTable, ByVal kriter, ByVal nKayitSinir) As Boolean
        Dim pass As Boolean = False
        If nKayitSinir > 0 Then
            Dim yetki As Int64 = Sorgu_tbKayitSayisi(tbTable, kriter, nKayitSinir)
            If yetki = 0 Then
                XtraMessageBox.Show(Sorgu_sDil("Üzgünüm Kýsýtlý Kullaným.Maximum Kayýt Sýnýrýný Aþamazsýnýz...!" & vbCrLf & "Lütfen Yetkili Satýcýnýzla Görüþün...", sDil), Sorgu_sDil("Dikkat", sDil), MessageBoxButtons.OK, MessageBoxIcon.Information)
                pass = False
            ElseIf yetki = 1 Then
                pass = True
            End If
        Else
            pass = True
        End If
        Return pass
    End Function
    Private Function Sorgu_tbKayitSayisi(ByVal tbTable As String, ByVal kriter As String, ByVal nKayitSinir As Integer) As Int64
        Dim cmd As New OleDb.OleDbCommand
        Dim con As New OleDb.OleDbConnection
        cmd.Connection = con
        con.ConnectionString = Connection
        If con.State = ConnectionState.Closed Then
            con.Open()
        End If
        Dim kayitsayisi As Int64 = 0
        Dim formkayitsayisi As Int64 = 0
        cmd.CommandText = sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT     ISNULL(COUNT(*), 0) AS Kayit FROM         " & tbTable & "  " & kriter & " ")
        formkayitsayisi = cmd.ExecuteScalar
        con.Close()
        If formkayitsayisi >= nKayitSinir Then
            kayitsayisi = 0
        Else
            kayitsayisi = 1
        End If
        Return kayitsayisi
        'kayitsayisi = Nothing
        formkayitsayisi = Nothing
        cmd = Nothing
        con = Nothing
    End Function
    Private Sub satir_ekle_cari()
        If KayitSiniri_kontrol("tbKarpinTahsilat", "", nKayitSinir) = True Then
            Dim frm As New frm_firma_liste
            frm.islemstatus = True
            frm.connection = Connection
            frm.firmano = firmano
            frm.donemno = DonemNo
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
                        dr = dataset1.Tables(0).NewRow
                        dr1 = frm.GridView1.GetDataRow(s)
                        dr("nKarpinID") = nKarpinID
                        dr("nFirmaID") = dr1("nFirmaID")
                        dr("sFirmaKodu") = dr1("sKodu")
                        dr("sFirmaAciklama") = dr1("sAciklama")
                        dr("dteFisTarihi") = dteFisTarihi
                        dr("sSatici") = sSatici
                        dr("sDepo") = sDepo
                        dr("sFisTipi") = sFisTipi
                        dr("nStokID") = 0
                        dr("sStokKodu") = ""
                        dr("sStokAciklama") = ""
                        dr("lMiktar") = 1
                        dr("lFiyat") = 0
                        dr("lTutar") = 0
                        dr("nKayitID") = tbKarpin_Emanet_kaydet_yeni(0, nKarpinID, sFisTipi, dteFisTarihi, sSatici, sDepo, dr("nStokID"), dr("sStokKodu"), dr("sStokAciklama"), dr("lMiktar"), dr("lFiyat"), dr("lTutar"), dr("nFirmaID"), dr("sFirmaKodu"), dr("sFirmaAciklama"))
                        dataset1.Tables(0).Rows.Add(dr)
                    Next
                End If
            End If
            frm.Close()
            frm = Nothing
            If GridView1.RowCount > 0 Then
                GridView1.FocusedRowHandle = GridView1.RowCount - 1
                GridView1.ClearSelection()
                GridView1.SelectRow(GridView1.RowCount - 1)
                PanelControl3.Focus()
                GridControl1.Focus()
            End If
        End If
    End Sub
    Private Sub stok_degistir()
        Dim frm As New frm_stok
        frm.islemstatus = True
        Dim dr As DataRow
        Dim dr1 As DataRow
        frm.connection = Connection
        frm.firmano = firmano
        frm.donemno = DonemNo
        frm.kullanici = kullanici
        If frm.ShowDialog(Me) = Windows.Forms.DialogResult.OK Then
            dr1 = frm.GridView1.GetDataRow(frm.GridView1.FocusedRowHandle)
            dr = GridView1.GetDataRow(GridView1.FocusedRowHandle)
            dr("nStokID") = dr1("nStokID")
            dr("sStokKodu") = dr1("sKodu")
            dr("sStokAciklama") = dr1("sAciklama")
            Try
                dr("lFiyat") = CType(dr1("PESIN"), Decimal)
            Catch ex As Exception
                dr("lFiyat") = 0
            End Try
            dr.EndEdit()
            tutar_hesapla()
        End If
    End Sub
    Private Sub satir_sil()
        If GridView1.RowCount > 0 Then
            If XtraMessageBox.Show(Sorgu_sDil("Satýrý Silmek Ýstediðinize Emin misiniz...?", sDil), Sorgu_sDil("Dikkat", sDil), MessageBoxButtons.YesNo, MessageBoxIcon.Question) = MsgBoxResult.Yes Then
                dr = GridView1.GetDataRow(GridView1.FocusedRowHandle)
                tbKarpin_Emanet_kaydet_sil(dr("nKayitID"), dr("nKarpinID"), dr("sFisTipi"))
                'GridView1.DeleteRow(GridView1.FocusedRowHandle)
                Dim satir = GridView1.FocusedRowHandle
                Dim nSonSatir As Boolean = False
                If satir = GridView1.RowCount Then
                    nSonSatir = True
                End If
                dataload()
                If nSonSatir = False Then
                    If GridView1.RowCount > 0 Then
                        GridView1.ClearSelection()
                        GridView1.SelectRow(satir)
                        PanelControl3.Focus()
                        GridControl1.Focus()
                    End If
                Else
                    GridView1.MoveLast()
                End If
                satir = Nothing
            End If
        End If
    End Sub
    Private Function tbKarpin_Emanet_kaydet_yeni(ByVal nKayitID As Int64, ByVal nKarpinID As Int64, ByVal sFisTipi As String, ByVal dteFisTarihi As DateTime, ByVal sSatici As String, ByVal sDepo As String, ByVal nStokID As Int64, ByVal sStokKodu As String, ByVal sStokAciklama As String, ByVal lMiktar As Decimal, ByVal lFiyat As Decimal, ByVal lTutar As Decimal, ByVal nFirmaID As Integer, ByVal sFirmaKodu As String, ByVal sFirmaAciklama As String) As Int64
        Dim con As New OleDb.OleDbConnection
        Dim cmd As New OleDb.OleDbCommand
        Dim kayitno As Integer
        con.ConnectionString = Connection
        con.Open()
        cmd.Connection = con
        cmd.CommandText = "SET DATEFORMAT DMY SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED INSERT INTO tbKarpinEmanet (nKarpinID, sFisTipi, dteFisTarihi, sSatici, sDepo, nStokID, sStokKodu, sStokAciklama, lMiktar, lFiyat, lTutar, nFirmaID, sFirmaKodu, sFirmaAciklama) VALUES     (" & nKarpinID & ", '" & sFisTipi & "', '" & dteFisTarihi & "', '" & sSatici & "', '" & sDepo & "', " & nStokID & ", '" & sStokKodu & "', '" & sStokAciklama & "', " & lMiktar & ", " & lFiyat & ", " & lTutar & ", " & nFirmaID & ", '" & sFirmaKodu & "', '" & sFirmaAciklama & "')"
        cmd.ExecuteNonQuery()
        cmd.CommandText = "SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT @@identity"
        kayitno = cmd.ExecuteScalar
        con.Close()
        Return kayitno
    End Function
    Private Sub tbKarpin_Emanet_kaydet_degistir(ByVal nKayitID As Int64, ByVal nKarpinID As Int64, ByVal sFisTipi As String, ByVal dteFisTarihi As DateTime, ByVal sSatici As String, ByVal sDepo As String, ByVal nStokID As Int64, ByVal sStokKodu As String, ByVal sStokAciklama As String, ByVal lMiktar As Decimal, ByVal lFiyat As Decimal, ByVal lTutar As Decimal, ByVal nFirmaID As Integer, ByVal sFirmaKodu As String, ByVal sFirmaAciklama As String)
        Dim con As New OleDb.OleDbConnection
        Dim cmd As New OleDb.OleDbCommand
        con.ConnectionString = Connection
        con.Open()
        cmd.Connection = con
        cmd.CommandText = "SET DATEFORMAT DMY SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED UPDATE    tbKarpinEmanet SET              dteFisTarihi = '" & dteFisTarihi & "', sSatici = '" & sSatici & "', sDepo = '" & sDepo & "', nStokID = " & nStokID & ", sStokKodu = '" & sStokKodu & "', sStokAciklama = '" & sStokAciklama & "', lMiktar = " & lMiktar & ", lFiyat = " & lFiyat & ", lTutar = " & lTutar & ", nFirmaID = " & nFirmaID & ", sFirmaKodu = '" & sFirmaKodu & "', sFirmaAciklama = '" & sFirmaAciklama & "' where nKayitID = " & nKayitID & " and  nKarpinID = " & nKarpinID & " and sFisTipi = '" & sFisTipi & "' "
        cmd.ExecuteNonQuery()
        con.Close()
    End Sub
    Private Sub tbKarpin_Emanet_kaydet_sil(ByVal nKayitID As Int64, ByVal nKarpinID As Int64, ByVal sFisTipi As String)
        Dim con As New OleDb.OleDbConnection
        Dim cmd As New OleDb.OleDbCommand
        con.ConnectionString = Connection
        con.Open()
        cmd.Connection = con
        cmd.CommandText = "DELETE FROM tbKarpinEmanet WHERE nKayitID =" & nKayitID & " AND nKarpinID =" & nKarpinID & " and sFisTipi ='" & sFisTipi & "' "
        cmd.ExecuteNonQuery()
        con.Close()
    End Sub
    Private Sub tutar_hesapla()
        If GridView1.RowCount > 0 Then
            Dim dr As DataRow
            dr = GridView1.GetDataRow(GridView1.FocusedRowHandle)
            If dr("lMiktar") = 0 Then
                dr("lMiktar") = 1
            End If
            dr("lTutar") = dr("lFiyat") * dr("lMiktar")
            tbKarpin_Emanet_kaydet_degistir(dr("nKayitID"), dr("nKarpinID"), sFisTipi, dteFisTarihi, sSatici.ToString, sDepo.ToString, dr("nStokID"), dr("sStokKodu"), dr("sStokAciklama"), dr("lMiktar"), dr("lFiyat"), dr("lTutar"), dr("nFirmaID"), dr("sFirmaKodu").ToString, dr("sFirmaAciklama").ToString)
        End If
    End Sub
    Private Sub GridView1_CellValueChanged(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs) Handles GridView1.CellValueChanged
        If GridView1.RowCount > 0 Then
            GridView1.PostEditor()
            dr = GridView1.GetDataRow(GridView1.FocusedRowHandle)
            dr.EndEdit()
            'Try
            tutar_hesapla()
            'Catch ex As Exception
            'End Try
        End If
    End Sub
    Private Sub BarButtonItem1_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem1.ItemClick
        satir_ekle_cari()
    End Sub
    Private Sub BarButtonItem2_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem2.ItemClick
        stok_degistir()
    End Sub
    Private Sub BarButtonItem3_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem3.ItemClick
        satir_sil()
    End Sub
    Private Sub BarButtonItem4_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem4.ItemClick
        printlink1.CreateDocument(ps)
        ps.PreviewRibbonFormEx.Show()
    End Sub
    Private Sub GridControl1_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles GridControl1.KeyDown
        If e.KeyCode = Keys.Escape Then
            Me.Close()
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
End Class