Imports DevExpress.XtraEditors
Public Class frm_tbKarpin_Sevkiyat
    Public firmano
    Public DonemNo
    Public Connection
    Public nKarpinID As Integer = 0
    Public dteFisTarihi As DateTime
    Public sSatici As String
    Public sDepo As String
    Public sFisTipi As String
    Public kullanici As String
    Dim nKayitSiniri As Integer = 0
    Dim mevcut As Decimal = 1
    Dim dataset1 As New DataSet
    Dim dr As DataRow
    Private Sub frm_tbKarpin_Sevkiyat_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        toplam_hesapla()
    End Sub
    Private Sub frm_tbKarpin_Sevkiyat_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        dataload()
    End Sub
    Private Sub dataload()
        dataset1 = query_sevkiyat(nKarpinID, dteFisTarihi, sSatici, sDepo)
        GridControl1.DataSource = dataset1.Tables(0)
        GridControl1.Select()
        GridControl1.Focus()
        dr = GridView1.GetDataRow(GridView1.FocusedRowHandle)
        If GridView1.RowCount = 0 Then
            txt_lIskonto.EditValue = 0
        Else
            txt_lIskonto.EditValue = dr("lIskonto")
        End If
        If GridView1.RowCount = 0 Then
            txt_lKdv.EditValue = 0
        Else
            txt_lKdv.EditValue = dr("lKdvTutari")
        End If
    End Sub
    Private Sub satir_sil()
        If GridView1.RowCount > 0 Then
            If XtraMessageBox.Show(Sorgu_sDil("Satýrý Silmek Ýstediðinize Emin misiniz...?", sDil), Sorgu_sDil("Dikkat", sDil), MessageBoxButtons.YesNo, MessageBoxIcon.Question) = MsgBoxResult.Yes Then
                dr = GridView1.GetDataRow(GridView1.FocusedRowHandle)
                tbKarpin_Sevkiyat_kaydet_sil(dr("nKayitID"), dr("nKarpinID"))
                'GridView1.DeleteRow(GridView1.FocusedRowHandle)
                dataset1.Tables(0).Rows.Remove(dr)
                GridControl1.Focus()
                GridControl1.Select()
                If GridView1.RowCount > 0 Then
                    GridView1.SelectRow(GridView1.FocusedRowHandle)
                End If
            End If
        End If
    End Sub
    Private Sub satir_ekle_stok(ByVal ara As String, Optional ByVal nSatir As Integer = 0)
        Dim frm As New frm_stok
        frm.islemstatus = True
        Dim dr As DataRow
        frm.connection = Connection
        frm.firmano = firmano
        frm.donemno = DonemNo
        frm.kullanici = kullanici
        If frm.ShowDialog(Me) = Windows.Forms.DialogResult.OK Then
            Dim s As String
            Dim arr As Integer()
            Dim i As Integer
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
                    dr("dteFisTarihi") = dteFisTarihi
                    dr("sSatici") = sSatici
                    dr("sDepo") = sDepo
                    dr("nStokID") = dr1("nStokId")
                    dr("sStokKodu") = dr1("sKodu")
                    dr("sStokAciklama") = dr1("sAciklama")
                    dr("lY1") = 1
                    dr("lY2") = 0
                    dr("lY3") = 0
                    dr("lMiktar") = 0
                    dr("lIade") = 0
                    dr("lSatis") = 0
                    Try
                        dr("lFiyat") = CType(dr1("PESIN"), Decimal)
                    Catch ex As Exception
                        dr("lFiyat") = 0
                    End Try
                    dr("lMiktar") = dr("lY1") + dr("lY2") + dr("lY3")
                    dr("lSatis") = dr("lMiktar") - dr("lIade")
                    dr("lTutar") = dr("lFiyat") * dr("lSatis")
                    dr("lIskonto") = txt_lIskonto.EditValue
                    dr("nKayitID") = tbKarpin_Sevkiyat_kaydet_yeni(0, dr("nKarpinID"), dr("dteFisTarihi"), dr("sSatici"), dr("sDepo"), dr("nStokID"), dr("sStokKodu"), dr("sStokAciklama"), dr("lY1"), dr("lY2"), dr("lY3"), dr("lMiktar"), dr("lIade"), dr("lSatis"), dr("lFiyat"), dr("lTutar"), dr("lIskonto"), txt_lKdv.EditValue, txt_lNetSatis.EditValue)
                    dataset1.Tables(0).Rows.Add(dr)
                Next
            End If
            Dim yeni = frm.yeni
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
            frm = Nothing
            If yeni = True Then
                satir_ekle_stok("")
            End If
            dr = Nothing
            dr1 = Nothing
            s = Nothing
            arr = Nothing
            i = Nothing
            If GridView1.RowCount > 0 Then
                GridView1.ClearSelection()
                GridView1.SelectRow(GridView1.RowCount - 1)
                PanelControl3.Focus()
                GridControl1.Focus()
            End If
            GridView1.FocusedColumn = collY1
        End If
    End Sub
    Private Sub satir_ekle_satistan()
        Dim frm As New frm_fatura_kalemleri_ozet
        frm.firmano = firmano
        frm.donemno = DonemNo
        frm.connection = Connection
        frm.kullanici = kullanici
        frm.sFisTipi = "FS "
        frm.nGirisCikis = 3
        frm.bAktar = True
        frm.islemstatus = True
        Dim lIskontoTutar As Decimal = 0
        Dim lKdvTutari As Decimal = 0
        If frm.ShowDialog(Me) = Windows.Forms.DialogResult.OK Then
            Dim s As String
            Dim arr As Integer()
            Dim i As Integer
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
                    dr("dteFisTarihi") = dteFisTarihi
                    dr("sSatici") = sSatici
                    dr("sDepo") = sDepo
                    dr("nStokID") = dr1("nStokId")
                    dr("sStokKodu") = dr1("sKodu")
                    dr("sStokAciklama") = dr1("sAciklama")
                    dr("lY1") = dr1("lMiktar")
                    dr("lY2") = 0
                    dr("lY3") = 0
                    dr("lMiktar") = dr1("lMiktar")
                    dr("lIade") = dr1("lIade")
                    dr("lSatis") = dr1("lSatis")
                    Try
                        dr("lFiyat") = CType(dr1("lDahilBrutFiyat"), Decimal)
                    Catch ex As Exception
                        dr("lFiyat") = 0
                    End Try
                    dr("lMiktar") = dr("lY1") + dr("lY2") + dr("lY3")
                    dr("lSatis") = dr("lMiktar") - dr("lIade")
                    dr("lTutar") = dr("lFiyat") * dr("lSatis")
                    'If dr("sStokKodu").ToString.Substring(0, 2) = "99" Then
                    '    dr("lFiyat") = 0
                    '    dr("lTutar") = 0
                    'End If
                    dr("lIskonto") = lIskontoTutar
                    dr("lKdvTutari") = lKdvTutari
                    lKdvTutari += dr1("lKdvTutari")
                    'lIskontoTutar += (dr1("lDahilBrutTutar") - dr1("lTutar"))
                    lIskontoTutar += dr1("lIskontoTutari")
                    dr("nKayitID") = tbKarpin_Sevkiyat_kaydet_yeni(0, dr("nKarpinID"), dr("dteFisTarihi"), dr("sSatici"), dr("sDepo"), dr("nStokID"), dr("sStokKodu"), dr("sStokAciklama"), dr("lY1"), dr("lY2"), dr("lY3"), dr("lMiktar"), dr("lIade"), dr("lSatis"), dr("lFiyat"), dr("lTutar"), dr("lIskonto"), txt_lKdv.EditValue, txt_lNetSatis.EditValue)
                    dataset1.Tables(0).Rows.Add(dr)
                Next
            End If
        End If
        txt_lIskonto.EditValue = lIskontoTutar
        txt_lKdv.EditValue = lKdvTutari
        lIskontoTutar = Nothing
        lKdvTutari = Nothing
        frm.Dispose()
        frm = Nothing
    End Sub
    Public Function query_sevkiyat(ByVal nKarpinID As Int64, ByVal dteFisTarihi As DateTime, ByVal sSatici As String, ByVal sDepo As String) As DataSet
        Dim conn As New OleDb.OleDbConnection
        Dim cmd As New OleDb.OleDbCommand
        Dim adapter As New OleDb.OleDbDataAdapter
        conn.ConnectionString = Connection
        adapter.SelectCommand = cmd
        cmd.CommandText = "SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT *,1 AS STATUS FROM         tbKarpinSevkiyat WHERE nKarpinID = " & nKarpinID & "   ORDER BY nKayitID"
        cmd.Connection = conn
        conn.Open()
        Dim ds As New DataSet
        Dim N As Integer = adapter.Fill(ds, "SEVKIYAT")
        conn.Close()
        Return ds
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
    Private Sub tbKarpin_Sevkiyat_kaydet_degistir(ByVal nKayitID As Int64, ByVal nKarpinID As Int64, ByVal dteFisTarihi As DateTime, ByVal sSatici As String, ByVal sDepo As String, ByVal nStokID As Integer, ByVal sStokKodu As String, ByVal sStokAciklama As String, ByVal lY1 As Decimal, ByVal lY2 As Decimal, ByVal lY3 As Decimal, ByVal lMiktar As Decimal, ByVal lIade As Decimal, ByVal lSatis As Decimal, ByVal lFiyat As Decimal, ByVal lTutar As Decimal, ByVal lIskonto As Decimal, ByVal lKdvTutari As Decimal, ByVal lNetTutar As Decimal)
        Dim con As New OleDb.OleDbConnection
        Dim cmd As New OleDb.OleDbCommand
        con.ConnectionString = Connection
        con.Open()
        cmd.Connection = con
        cmd.CommandText = "SET DATEFORMAT DMY SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED UPDATE    tbKarpinSevkiyat SET              dteFisTarihi = '" & dteFisTarihi & "', sSatici = '" & sSatici & "', sDepo = '" & sDepo & "', nStokID = " & nStokID & ", sStokKodu = '" & sStokKodu & "', sStokAciklama = '" & sStokAciklama & "', lY1 = " & lY1 & ", lY2 = " & lY2 & ", lY3 = " & lY3 & ", lMiktar = " & lMiktar & ", lIade = " & lIade & ", lSatis = " & lSatis & ", lFiyat = " & lFiyat & ", lTutar = " & lTutar & ", lIskonto = " & lIskonto & ",lKdvTutari = " & lKdvTutari & ",lNetTutar = " & lNetTutar & "  where nKayitID = " & nKayitID & " and  nKarpinID = " & nKarpinID & "  "
        cmd.ExecuteNonQuery()
        con.Close()
    End Sub
    Private Sub tbKarpin_Sevkiyat_kaydet_sil(ByVal nKayitID As Int64, ByVal nKarpinID As Int64)
        Dim con As New OleDb.OleDbConnection
        Dim cmd As New OleDb.OleDbCommand
        con.ConnectionString = Connection
        con.Open()
        cmd.Connection = con
        cmd.CommandText = "DELETE FROM tbKarpinSevkiyat WHERE nKayitID =" & nKayitID & " AND nKarpinID =" & nKarpinID & "  "
        cmd.ExecuteNonQuery()
        con.Close()
    End Sub
    Private Sub tutar_hesapla()
        If GridView1.RowCount > 0 Then
            Dim dr As DataRow
            dr = GridView1.GetDataRow(GridView1.FocusedRowHandle)
            dr("lMiktar") = dr("lY1") + dr("lY2") + dr("lY3")
            dr("lSatis") = dr("lMiktar") - dr("lIade")
            dr("lTutar") = dr("lFiyat") * dr("lSatis")
            tbKarpin_Sevkiyat_kaydet_degistir(dr("nKayitID"), dr("nKarpinID"), dteFisTarihi, sSatici, sDepo, dr("nStokID"), dr("sStokKodu"), dr("sStokAciklama"), dr("lY1"), dr("lY2"), dr("lY3"), dr("lMiktar"), dr("lIade"), dr("lSatis"), dr("lFiyat"), dr("lTutar"), txt_lIskonto.EditValue, txt_lKdv.EditValue, txt_lNetSatis.EditValue)
        End If
    End Sub
    Private Sub toplam_hesapla()
        Dim dr As DataRow
        If dataset1.Tables(0).Rows.Count > 0 Then
            For Each dr In dataset1.Tables(0).Rows
                dr("lMiktar") = dr("lY1") + dr("lY2") + dr("lY3")
                dr("lSatis") = dr("lMiktar") - dr("lIade")
                dr("lTutar") = dr("lFiyat") * dr("lSatis")
                tbKarpin_Sevkiyat_kaydet_degistir(dr("nKayitID"), dr("nKarpinID"), dteFisTarihi, sSatici, sDepo, dr("nStokID"), dr("sStokKodu"), dr("sStokAciklama"), dr("lY1"), dr("lY2"), dr("lY3"), dr("lMiktar"), dr("lIade"), dr("lSatis"), dr("lFiyat"), dr("lTutar"), txt_lIskonto.EditValue, txt_lKdv.EditValue, txt_lNetSatis.EditValue)
            Next
        End If
    End Sub
    Private Function sorgu_query(ByVal query As String) As String
        query = Replace(query, "*!F", "F0" + firmano.ToString)
        query = Replace(query, "!D", "D000" + DonemNo.ToString)
        Return query
    End Function
    Private Sub analiz_stok_karti()
        If GridView1.RowCount > 0 Then
            dr = GridView1.GetDataRow(GridView1.FocusedRowHandle)
            Dim frm As New frm_stok_kart
            frm.firmano = firmano
            frm.donemno = DonemNo
            frm.connection = Connection
            frm.nStokID = dr("nStokID")
            frm.sKodu = dr("sStokKodu")
            frm.sModel = dr("sStokKodu")
            frm.kullanici = kullanici
            If yetki_kontrol(kullanici, frm.Name) = True Then
                frm.ShowDialog()
            End If
            Dim satir = GridView1.FocusedRowHandle
            dataload()
            GridView1.FocusedRowHandle = satir
            satir = Nothing
            frm.Close()
            frm.Dispose()
            frm = Nothing
        End If
    End Sub
    Private Sub analiz_envanter()
        If GridView1.RowCount > 0 Then
            dr = GridView1.GetDataRow(GridView1.FocusedRowHandle)
            Dim frm As New frm_stok_envanter
            frm.firmano = firmano
            frm.donemno = DonemNo
            frm.connection = Connection
            frm.stokno = dr("nStokId")
            frm.stokkodu = dr("sStokKodu")
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
        If GridView1.RowCount > 0 Then
            Dim dr As DataRow = GridView1.GetDataRow(GridView1.FocusedRowHandle)
            Dim frm As New frm_stok_hareketleri
            frm.firmano = firmano
            frm.donemno = DonemNo
            frm.connection = Connection
            frm.musterino = dr("sStokKodu")
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
            frm.Label1.Text = dr("sStokAciklama") & vbCrLf & frm.Label1.Text
            frm.kullanici = kullanici
            If yetki_kontrol(kullanici, frm.Name) = True Then
                frm.ShowDialog()
            End If
            frm.Close()
            frm.Dispose()
            frm = Nothing
        End If
    End Sub
    Private Sub BarButtonItem1_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem1.ItemClick
        satir_ekle_stok("")
    End Sub
    Private Sub BarButtonItem2_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem2.ItemClick
        satir_sil()
    End Sub
    Private Sub BarButtonItem3_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem3.ItemClick
        printlink1.CreateDocument(ps)
        ps.PreviewRibbonFormEx.Show()
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
    Private Sub GridControl1_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles GridControl1.KeyDown
        If e.KeyCode = Keys.Escape Then
            Me.Close()
        End If
    End Sub
    Private Sub SimpleButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SimpleButton1.Click
        Me.Close()
    End Sub
    Private Sub SimpleButton2_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles SimpleButton2.Click
        Me.Close()
    End Sub
    Private Sub BarButtonItem4_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem4.ItemClick
        analiz_stok_karti()
    End Sub
    Private Sub BarButtonItem5_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem5.ItemClick
        analiz_envanter()
    End Sub
    Private Sub BarButtonItem6_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem6.ItemClick
        analiz_stok_hareket()
    End Sub
    Private Sub BarButtonItem7_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem7.ItemClick
        satir_ekle_satistan()
    End Sub
End Class