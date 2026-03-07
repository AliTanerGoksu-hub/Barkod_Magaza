Imports Microsoft.Win32
Imports DevExpress.XtraEditors
Public Class frm_tbKarpin_Tahsilat
    Public firmano
    Public DonemNo
    Public Connection
    Public nKarpinID As Integer = 0
    Public dteFisTarihi As DateTime
    Public sSatici As String
    Public sDepo As String
    Public sFisTipi As String
    Public kullanici As String = ""
    Dim dataset1 As DataSet
    Dim ds_firma As DataSet
    Dim ds_satir_firma As DataSet
    Dim dr As DataRow
    Dim loaded As Boolean = False
    Dim mevcut As Decimal = 1
    Dim x As Integer = 0
    Dim okut As Boolean = False
    Private Sub frm_tbKarpin_Tahsilat_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        GridControl1.Focus()
        GridControl1.Select()
        dataload_tbOdemeSekli()
        dataload()
        dr = GridView1.GetDataRow(GridView1.FocusedRowHandle)
        If sFisTipi = 1 Then
            lbl_istihbarat.Text = "Veresiyeden Tahsilatlar..."
        ElseIf sFisTipi = 2 Then
            lbl_istihbarat.Text = "Veresiyeler"
        ElseIf sFisTipi = 3 Then
            lbl_istihbarat.Text = "Peþin Tahsilatlarý..."
        ElseIf sFisTipi = 4 Then
            lbl_istihbarat.Text = "Rut Takibi..."
            colsOdemeSekli.Visible = False
            collTutar.Visible = False
            Label1.Text = "Rut Ziyaretleri"
        ElseIf sFisTipi = 5 Then
            lbl_istihbarat.Text = "Masraf Takibi..."
            Label1.Text = "Yapýlan Masraflar"
            Me.Text = "Masraf Takibi"
        End If
        Label1.Text += sSatici
    End Sub
    Private Sub dataload_tbOdemeSekli()
        sec_sOdemeSekli.DataSource = sorgu(sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT     * from tbOdemeSekli Order by sOdemeSekli ")).Tables(0)
    End Sub
    Private Function sorgu(ByVal query As String) As DataSet
        Dim conn As New OleDb.OleDbConnection
        Dim cmd As New OleDb.OleDbCommand
        Dim adapter As New OleDb.OleDbDataAdapter
        conn.ConnectionString = Connection
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
    Private Sub satir_firma_info()
        If loaded = True Then
            Try
                If GridView1.RowCount > 0 Then
                    dr = GridView1.GetDataRow(GridView1.FocusedRowHandle)
                    ds_satir_firma = sorgu_firma_info(dr("nFirmaID"))
                    Dim dr1 As DataRow = ds_satir_firma.Tables(0).Rows(0)
                    label3.Text = dr1("sAciklama") & vbTab & "    Iskontosu: " & dr1("nOzelIskontosu") & " Kredilimiti: " & dr1("lKrediLimiti") & "   Borç: " & FormatNumber(dr1("BORC"), 2) & "   Alacak: " & FormatNumber(dr1("ALACAK"), 2) & "   Bakiye: " & FormatNumber(dr1("BAKIYE"), 2)
                    label3.Refresh()
                    dr1 = Nothing
                End If
            Catch ex As Exception
                label3.Text = "*"
                label3.Refresh()
            End Try
        End If
    End Sub
    Private Sub analiz_Firma_karti()
        If GridView1.RowCount > 0 Then
            Dim dr As DataRow = GridView1.GetDataRow(GridView1.FocusedRowHandle)
            If Trim(dr("sFisTipi")) = "PF" Then
                Dim frm As New frm_musteri_karti
                frm.firmano = firmano
                frm.donemno = DonemNo
                frm.connection = Connection
                frm.musterino = dr("sFirmaKodu")
                frm.musteriID = dr("nFirmaID")
                frm.kullanici = kullanici
                If yetki_kontrol(kullanici, frm.Name) = True Then
                    frm.ShowDialog()
                End If
                frm.Close()
                frm.Dispose()
                frm = Nothing
            Else
                Dim frm As New frm_firma_kart
                frm.firmano = firmano
                frm.donemno = DonemNo
                frm.connection = Connection
                frm.sKodu = dr("sFirmaKodu")
                frm.nFirmaID = dr("nFirmaID")
                frm.kullanici = kullanici
                If yetki_kontrol(kullanici, frm.Name) = True Then
                    frm.ShowDialog()
                End If
                frm.Close()
                frm.Dispose()
                frm = Nothing
            End If
            dr = Nothing
        End If
    End Sub
    Private Sub analiz_cari_hareket()
        If GridView1.RowCount > 0 Then
            Dim dr As DataRow = GridView1.GetDataRow(GridView1.FocusedRowHandle)
            Dim frm As New frm_cari_hareketler_ozet
            frm.firmano = firmano
            frm.donemno = DonemNo
            frm.connection = Connection
            frm.musterino = dr("sFirmaKodu")
            frm.kullanici = kullanici
            If yetki_kontrol(kullanici, frm.Name) = True Then
                If yetki_kontrol(kullanici, "frm_firma_liste_hesapTuru_" & Trim(CariHesapTuruSorgula(dr("sFirmaKodu")))) = True Then
                    frm.ShowDialog()
                End If
            End If
            frm.Close()
            frm.Dispose()
            frm = Nothing
            dr = Nothing
        End If
    End Sub
    Private Sub analiz_cari_hareket_detayli()
        If GridView1.RowCount > 0 Then
            Dim dr As DataRow = GridView1.GetDataRow(GridView1.FocusedRowHandle)
            Dim frm As New frm_cari_hareketler_detayli
            frm.firmano = firmano
            frm.donemno = donemno
            frm.connection = connection
            frm.musterino = dr("sFirmaKodu")
            frm.kullanici = kullanici
            frm.DateEdit1.EditValue = "01/01/1900"
            frm.DateEdit2.EditValue = "31/12/2078"
            If yetki_kontrol(kullanici, frm.Name) = True Then
                If yetki_kontrol(kullanici, "frm_firma_liste_hesapTuru_" & Trim(CariHesapTuruSorgula(frm.musterino))) = True Then
                    frm.ShowDialog()
                End If
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
            'frm.musterino = dr("sStokKodu")
            frm.nFirmaID = dr("nFirmaID")
            frm.sec_firma.Checked = True
            frm.rStokCari = True
            frm.sec_giris.Text = "Çýkýþlar"
            frm.kullanici = kullanici
            frm.islemstatus = True
            If yetki_kontrol(kullanici, frm.Name) = True Then
                If frm.ShowDialog(Me) = Windows.Forms.DialogResult.OK Then
                End If
            End If
            frm.Close()
            frm.Dispose()
            frm = Nothing
        End If
    End Sub
    Private Sub analiz_iletisim()
        If GridView1.RowCount > 0 Then
            Dim dr As DataRow = GridView1.GetDataRow(GridView1.FocusedRowHandle)
            Dim frm As New frm_firma_iletisim
            frm.firmano = firmano
            frm.donemno = DonemNo
            frm.connection = Connection
            frm.musterino = dr("nFirmaID")
            frm.kullanici = kullanici
            If yetki_kontrol(kullanici, frm.Name) = True Then
                frm.ShowDialog()
            End If
            frm.Close()
            frm.Dispose()
            frm = Nothing
            dr = Nothing
        End If
    End Sub
    Private Sub analiz_cari_bakiye()
        If GridView1.RowCount > 0 Then
            Dim dr As DataRow = GridView1.GetDataRow(GridView1.FocusedRowHandle)
            Dim frm As New frm_Firma_bakiye
            frm.firmano = firmano
            frm.donemno = DonemNo
            frm.connection = Connection
            frm.sKodu = dr("sFirmaKodu")
            frm.txt_musteriNo.EditValue = dr("sFirmaKodu")
            frm.kullanici = kullanici
            If yetki_kontrol(kullanici, frm.Name) = True Then
                If yetki_kontrol(kullanici, "frm_firma_liste_hesapTuru_" & Trim(CariHesapTuruSorgula(frm.sKodu))) = True Then
                    frm.ShowDialog()
                End If
            End If
            frm.Close()
            frm.Dispose()
            frm = Nothing
            dr = Nothing
        End If
    End Sub
    Private Function sorgu_firma_info(ByVal nFirmaID As String) As DataSet
        Dim con As New OleDb.OleDbConnection
        Dim adapter As New OleDb.OleDbDataAdapter
        Dim cmd As New OleDb.OleDbCommand
        con.ConnectionString = Connection
        adapter.SelectCommand = cmd
        cmd.CommandText = sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT tbFirma.nFirmaID, tbFirma.sKodu, tbFirma.sAciklama, tbFirma.nOzelIskontosu, tbFirma.lKrediLimiti, SUM(tbFirmaHareketi.lBorcTutar) AS BORC, SUM(tbFirmaHareketi.lAlacakTutar) AS ALACAK, SUM(tbFirmaHareketi.lBorcTutar - tbFirmaHareketi.lAlacakTutar) AS BAKIYE FROM tbFirmaHareketi INNER JOIN tbFirma ON tbFirmaHareketi.nFirmaID = tbFirma.nFirmaID WHERE tbFirma.nFirmaID ='" & nFirmaID & "' GROUP BY tbFirma.nFirmaID, tbFirma.sKodu, tbFirma.sAciklama, tbFirma.nOzelIskontosu, tbFirma.lKrediLimiti")
        cmd.Connection = con
        con.Open()
        Dim DS As New DataSet
        Dim N As Integer = adapter.Fill(DS, "BASLIK")
        con.Close()
        con = Nothing
        cmd = Nothing
        adapter = Nothing
        Return DS
    End Function
    Private Sub dataload()
        dataset1 = query_tahsilat(nKarpinID, sFisTipi)
        GridControl1.DataSource = dataset1.Tables(0)
        GridControl1.Select()
        GridControl1.Focus()
        dr = GridView1.GetDataRow(GridView1.FocusedRowHandle)
        loaded = True
    End Sub
    Public Function query_tahsilat(ByVal nKarpinID As Int64, ByVal sFisTipi As String) As DataSet
        Dim conn As New OleDb.OleDbConnection
        Dim cmd As New OleDb.OleDbCommand
        Dim adapter As New OleDb.OleDbDataAdapter
        conn.ConnectionString = Connection
        adapter.SelectCommand = cmd
        cmd.CommandText = "SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT     *,1 AS STATUS FROM         tbKarpinTahsilat WHERE nKarpinID =" & nKarpinID & " AND sFisTipi =" & sFisTipi & " ORDER BY nKayitID"
        cmd.Connection = conn
        conn.Open()
        Dim ds As New DataSet
        Dim N As Integer = adapter.Fill(ds, "KARPIN")
        conn.Close()
        Return ds
    End Function
    Private Function tbKarpin_Tahsilat_kaydet_yeni(ByVal nKayitID As Int64, ByVal nKarpinID As Int64, ByVal dteFisTarihi As DateTime, ByVal sSatici As String, ByVal sDepo As String, ByVal sFisTipi As String, ByVal nFirmaID As Integer, ByVal sFirmaKodu As String, ByVal sFirmaAciklama As String, ByVal sAciklama As String, ByVal lTutar As Decimal, ByVal sOdemeSekli As String, ByVal dteKayitTarihi As DateTime) As Int64
        Dim con As New OleDb.OleDbConnection
        Dim cmd As New OleDb.OleDbCommand
        Dim kayitno As Integer
        con.ConnectionString = Connection
        con.Open()
        cmd.Connection = con
        cmd.CommandText = "SET DATEFORMAT DMY INSERT INTO tbKarpinTahsilat (nKarpinID, dteFisTarihi, sSatici, sDepo, sFisTipi, nFirmaID, sFirmaKodu, sFirmaAciklama, sAciklama, lTutar, sOdemeSekli, dteKayitTarihi) VALUES     ( " & nKarpinID & ", '" & dteFisTarihi & "', '" & sSatici & "', '" & sDepo & "', '" & sFisTipi & "', " & nFirmaID & ", '" & sFirmaKodu & "', '" & sFirmaAciklama & "', N'" & sAciklama & "', " & lTutar & ", '" & sOdemeSekli & "', '" & dteKayitTarihi & "')"
        cmd.ExecuteNonQuery()
        cmd.CommandText = "SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT @@identity"
        kayitno = cmd.ExecuteScalar
        con.Close()
        Return kayitno
    End Function
    Private Sub tbKarpin_Tahsilat_kaydet_degistir(ByVal nKayitID As Int64, ByVal nKarpinID As Int64, ByVal dteFisTarihi As DateTime, ByVal sSatici As String, ByVal sDepo As String, ByVal sFisTipi As String, ByVal nFirmaID As Integer, ByVal sFirmaKodu As String, ByVal sFirmaAciklama As String, ByVal sAciklama As String, ByVal lTutar As Decimal, ByVal sOdemeSekli As String, ByVal dteKayitTarihi As DateTime)
        Dim con As New OleDb.OleDbConnection
        Dim cmd As New OleDb.OleDbCommand
        con.ConnectionString = Connection
        con.Open()
        cmd.Connection = con
        cmd.CommandText = "SET DATEFORMAT DMY UPDATE    tbKarpinTahsilat SET              dteFisTarihi = '" & dteFisTarihi & "', sSatici = '" & sSatici & "', sDepo = '" & sDepo & "', sFisTipi = '" & sFisTipi & "', nFirmaID = " & nFirmaID & ", sFirmaKodu = '" & sFirmaKodu & "', sFirmaAciklama = '" & sFirmaAciklama & "', sAciklama = N'" & sAciklama & "', lTutar = " & lTutar & ", sOdemeSekli = '" & sOdemeSekli & "' where nKayitID = " & nKayitID & " and  nKarpinID = " & nKarpinID & " "
        cmd.ExecuteNonQuery()
        con.Close()
    End Sub
    Private Sub tbKarpin_tahsilat_kaydet_sil(ByVal nKayitID As Int64, ByVal nKarpinID As Int64)
        Dim con As New OleDb.OleDbConnection
        Dim cmd As New OleDb.OleDbCommand
        con.ConnectionString = Connection
        con.Open()
        cmd.Connection = con
        cmd.CommandText = "DELETE FROM tbKarpinTahsilat WHERE nKayitID =" & nKayitID & " AND nKarpinID =" & nKarpinID & ""
        cmd.ExecuteNonQuery()
        con.Close()
    End Sub
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
    Private Sub satir_ekle(Optional ByVal sAra As String = "", Optional ByVal sKriter As String = "Baþlar")
        If KayitSiniri_kontrol("tbKarpinTahsilat", "", nKayitSinir) = True Then
            Dim frm As New frm_firma_liste
            frm.islemstatus = True
            frm.connection = Connection
            frm.firmano = firmano
            frm.donemno = DonemNo
            frm.islemstatus = True
            frm.kullanici = kullanici
            If sAra <> "" Then
                frm.txt_ara.Text = sAra
                frm.sec_konum.Text = "Geliþmiþ"
                frm.sec_kriter.Text = sKriter
            End If
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
                        If sFisTipi = 1 Then
                            dr("sAciklama") = "Tahsilat"
                        ElseIf sFisTipi = 5 Then
                            dr("sAciklama") = dr1("sAciklama")
                        Else
                            dr("sAciklama") = ""
                        End If
                        dr("lTutar") = mevcut
                        dr("sOdemeSekli") = "N   "
                        dr("dteKayitTarihi") = Now
                        dr("nKayitID") = tbKarpin_Tahsilat_kaydet_yeni(0, dr("nKarpinID"), dr("dteFisTarihi"), dr("sSatici").ToString, dr("sDepo").ToString, dr("sFisTipi").ToString, dr("nFirmaID"), dr("sFirmaKodu").ToString, dr("sFirmaAciklama").ToString, dr("sAciklama").ToString, dr("lTutar"), dr("sOdemeSekli").ToString, dr("dteKayitTarihi"))
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
            txt_ara.Text = ""
            'txt_ara.Focus()
            'txt_ara.SelectAll()
            GridView1.FocusedColumn = collTutar
        End If
    End Sub
    Private Sub satir_ekle_tek()
        If KayitSiniri_kontrol("tbKarpinTahsilat", "", nKayitSinir) = True Then
            Dim dr As DataRow
            Dim dr1 As DataRow
            dr = dataset1.Tables(0).NewRow
            dr1 = ds_firma.Tables(0).Rows(0)
            dr("nKarpinID") = nKarpinID
            dr("nFirmaID") = dr1("nFirmaID")
            dr("sFirmaKodu") = dr1("sKodu")
            dr("sFirmaAciklama") = dr1("sAciklama")
            dr("dteFisTarihi") = dteFisTarihi
            dr("sSatici") = sSatici
            dr("sDepo") = sDepo
            dr("sFisTipi") = sFisTipi
            If sFisTipi = 1 Then
                dr("sAciklama") = "Tahsilat"
            ElseIf sFisTipi = 5 Then
                dr("sAciklama") = dr1("sAciklama")
            Else
                dr("sAciklama") = ""
            End If
            dr("lTutar") = mevcut
            dr("sOdemeSekli") = "N   "
            dr("dteKayitTarihi") = Now
            dr("nKayitID") = tbKarpin_Tahsilat_kaydet_yeni(0, dr("nKarpinID"), dr("dteFisTarihi"), dr("sSatici").ToString, dr("sDepo").ToString, dr("sFisTipi").ToString, dr("nFirmaID"), dr("sFirmaKodu").ToString, dr("sFirmaAciklama").ToString, dr("sAciklama").ToString, dr("lTutar"), dr("sOdemeSekli").ToString, dr("dteKayitTarihi"))
            dataset1.Tables(0).Rows.Add(dr)
            If GridView1.RowCount > 0 Then
                GridView1.FocusedRowHandle = GridView1.RowCount - 1
                GridView1.ClearSelection()
                GridView1.SelectRow(GridView1.RowCount - 1)
                PanelControl3.Focus()
                GridControl1.Focus()
            End If
            txt_ara.Text = ""
            'txt_ara.Focus()
            'txt_ara.SelectAll()
            GridView1.FocusedColumn = collTutar
        End If
    End Sub
    Private Sub satir_sil()
        'If GridView1.RowCount > 0 Then
        '    If XtraMessageBox.Show(Sorgu_sDil("Satýrý Silmek Ýstediðinize Emin misiniz...?", sDil), Sorgu_sDil("Dikkat", sDil), MessageBoxButtons.YesNo, MessageBoxIcon.Question) = MsgBoxResult.Yes Then
        '        dr = GridView1.GetDataRow(GridView1.FocusedRowHandle)
        '        tbKarpin_tahsilat_kaydet_sil(dr("nKayitID"), dr("nKarpinID"))
        '        'GridView1.DeleteRow(GridView1.FocusedRowHandle)
        '        dataset1.Tables(0).Rows.Remove(dr)
        '        GridControl1.Focus()
        '        GridControl1.Select()
        '        If GridView1.RowCount > 0 Then
        '            GridView1.SelectRow(GridView1.FocusedRowHandle)
        '        End If
        '    End If
        'End If
        If XtraMessageBox.Show(Sorgu_sDil("Seçili Kayýtlarý Silmek Ýstediðinize Emin misiniz...?", sDil), Sorgu_sDil("Dikkat", sDil), MessageBoxButtons.YesNo, MessageBoxIcon.Question) = MsgBoxResult.Yes Then
            Dim s As String
            Dim arr As Integer()
            Dim i As Integer
            Dim dr As DataRow
            arr = GridView1.GetSelectedRows()
            Dim satir = GridView1.FocusedRowHandle
            If arr Is Nothing Then
            Else
                Array.Sort(arr)
                For Each i In arr
                    s = i.ToString
                    dr = GridView1.GetDataRow(s)
                    tbKarpin_tahsilat_kaydet_sil(dr("nKayitID"), dr("nKarpinID"))
                Next
            End If
            dataload()
            GridView1.FocusedRowHandle = satir
            If GridView1.RowCount > 0 Then
                GridView1.SelectRow(GridView1.FocusedRowHandle)
            End If
            'XtraMessageBox.Show(Sorgu_sDil("Ýþlem Tamamlandý...!", sDil), Sorgu_sDil("Dikkat", sDil), MessageBoxButtons.OK, MessageBoxIcon.Information)
            s = Nothing
            arr = Nothing
            i = Nothing
            dr = Nothing
            satir = Nothing
        End If
    End Sub
    Private Sub yazdir()
        printlink1.CreateDocument(ps)
        ps.PreviewRibbonFormEx.Show()
    End Sub
    Private Sub BarButtonItem1_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem1.ItemClick
        satir_ekle()
    End Sub
    Private Sub BarButtonItem2_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem2.ItemClick
        satir_sil()
    End Sub
    Private Sub BarButtonItem3_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem3.ItemClick
        yazdir()
    End Sub
    Private Sub SimpleButton2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SimpleButton2.Click
        Me.Close()
    End Sub
    Private Sub SimpleButton1_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles SimpleButton1.Click
        Me.Close()
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
    Private Sub tutar_hesapla()
        If GridView1.RowCount > 0 Then
            Dim dr As DataRow
            dr = GridView1.GetDataRow(GridView1.FocusedRowHandle)
            tbKarpin_Tahsilat_kaydet_degistir(dr("nKayitID"), dr("nKarpinID"), dteFisTarihi, sSatici.ToString, sDepo.ToString, sFisTipi, dr("nFirmaID"), dr("sFirmaKodu").ToString, dr("sFirmaAciklama").ToString, dr("sAciklama").ToString, dr("lTutar"), dr("sOdemeSekli").ToString, dr("dteKayitTarihi"))
        End If
    End Sub
    Private Sub GridControl1_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles GridControl1.KeyDown
        If e.KeyCode = Keys.Escape Then
            Me.Close()
        End If
    End Sub
    Private Sub BarButtonItem4_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem4.ItemClick
        analiz_Firma_karti()
    End Sub
    Private Sub BarButtonItem5_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem5.ItemClick
        analiz_cari_hareket()
    End Sub
    Private Sub BarButtonItem6_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem6.ItemClick
        analiz_iletisim()
    End Sub
    Private Sub GridView1_CustomDrawRowIndicator(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Grid.RowIndicatorCustomDrawEventArgs) Handles GridView1.CustomDrawRowIndicator
        If e.RowHandle >= 0 Then
            e.Info.DisplayText = e.RowHandle + 1
        Else
            e.Info.DisplayText = ""
        End If
    End Sub
    Private Sub GridView1_FocusedRowChanged(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs) Handles GridView1.FocusedRowChanged
        satir_firma_info()
    End Sub
    Private Sub GridView1_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles GridView1.KeyDown
        If e.KeyCode = Keys.Down Then
            If GridView1.FocusedRowHandle = GridView1.RowCount - 1 Then
                txt_ara.Focus()
                txt_ara.SelectAll()
            ElseIf GridView1.RowCount = 0 Then
                txt_ara.Focus()
                txt_ara.SelectAll()
            End If
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
    Private Sub txt_ara_EditValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles txt_ara.EditValueChanged
        If Len(txt_ara.EditValue.ToString) <> 0 Then
            lbl_ara.Text = Len(txt_ara.EditValue.ToString)
        Else
            lbl_ara.Text = "*"
        End If
    End Sub
    Private Sub txt_ara_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txt_ara.KeyDown
        If e.KeyCode = Keys.Enter Then
            Try
                x = (Trim(txt_ara.Text)).IndexOf(",", 1, (Trim(txt_ara.Text)).Length - 1)
                If x = -1 Then
                Else
                    txt_ara.Text = Microsoft.VisualBasic.Replace(txt_ara.Text, ",", ".")
                    txt_ara.ScrollToCaret()
                End If
            Catch ex As Exception
            End Try
            If txt_ara.Text = "" Then
                satir_ekle()
            Else
                firma_ara()
            End If
        ElseIf e.KeyCode = Keys.Up Then
            GridView1.Focus()
            'GridView1.FocusedColumn = collTutar
        ElseIf e.KeyCode = Keys.Escape Then
            If XtraMessageBox.Show(Sorgu_sDil("Nakit Kasa Ekranýný Kapatmak Ýstediðinize Emin misiniz...?", sDil), Sorgu_sDil("Dikkat", sDil), MessageBoxButtons.YesNo, MessageBoxIcon.Question) = MsgBoxResult.Yes Then
                Me.Close()
            End If
        End If
    End Sub
    Private Sub firma_ara()
        mevcut = 1
        If Trim(txt_ara.Text) <> "" Then
            Label4.Text = "Barkod Standardý Kontrol Ediliyor..."
            Label4.Refresh()
            If IsNumeric(Trim(txt_ara.Text)) = True Then
                If Len(Trim(txt_ara.Text).ToString) < 2 Then
                    txt_ara.Text = Trim(txt_ara.Text) + "  "
                End If
                If Trim((Trim(txt_ara.Text)).Substring(0, 2)) = sBarcodeStd Then
                    Dim deger = Trim(Trim(txt_ara.Text))
                    If IsNumeric(deger) = True Then
                        mevcut = CType((deger.substring(7, sBarcodeStd_KG) + "." + deger.substring(7 + sBarcodeStd_KG, sBarcodeStd_GR)), Decimal)
                        txt_ara.Text = deger.substring(2, 5)
                    End If
                Else
                    mevcut = 1
                End If
            Else
                If CStr(Trim(txt_ara.Text).ToString) <> "" Then
                    x = (Trim(txt_ara.Text)).IndexOf("*", 1, (Trim(txt_ara.Text)).Length - 1)
                    If x = -1 Then
                        mevcut = 1
                    Else
                        mevcut = (Trim(txt_ara.Text)).Substring(0, x)
                        txt_ara.Text = (Trim(txt_ara.Text)).Substring((x + 1), (Trim(txt_ara.Text)).Length - (x + 1))
                        If IsNumeric(Trim(txt_ara.Text)) Then
                        Else
                        End If
                    End If
                End If
            End If
            Label4.Text = "Barkod Standardý Kontrolü Tamamlandý..."
            Label4.Refresh()
            firma_kontrol()
        End If
    End Sub
    Private Sub firma_kontrol()
        If IsNumeric(Trim(txt_ara.Text)) = True Then
            okut = True
        Else
            okut = False
        End If
        Label4.Text = "Firma Kartý Kontrolü Yapýlýyor..."
        Label4.Refresh()
        Dim kontrol = sorgu_Firma_kontrol(txt_ara.EditValue, sec_kriter.Text)
        If kontrol = 0 Then
            Label4.Text = "Firma Kaydý Bulunamadý!!!.Tekrar Deneyiniz..."
            Label4.Refresh()
            txt_ara.Focus()
            txt_ara.SelectAll()
            'If XtraMessageBox.Show(Sorgu_sDil("Kayýt Bulunumadý..." & vbCrLf & "Yeni Kayýt Eklemek Ýster misiniz...?",sDil), MessageBoxButtons.YesNo + MessageBoxIcon.Warning) = MsgBoxResult.Yes Then
            '    stok_yeni(txt_ara.Text)
            'End If
        ElseIf kontrol = 1 Then
            Label4.Text = "Belge Firma Kaydý Kontrol Ediliyor... "
            Label4.Refresh()
            'MsgBox(Sorgu_sDil("Kayýt Tek...")
            dataload_tbFirma(Trim(txt_ara.Text), sec_kriter.Text)
            Label4.Text = "Firma Bilgisi Yükleniyor... "
            Label4.Refresh()
            satir_ekle_tek()
            Label4.Text = "Yeni Hesap Girin..."
        ElseIf kontrol > 1 Then
            satir_ekle(Trim(txt_ara.Text), sec_kriter.Text)
            Label4.Text = "Firma Hesabý Satýra Ýþlendi...Yeni Ürün Okutun..."
            Label4.Refresh()
            txt_ara.Text = ""
            txt_ara.Focus()
            txt_ara.SelectAll()
        End If
    End Sub
    Public Function sorgu_Firma_kontrol(ByVal ara As String, ByVal ara_kriter As String) As Int64
        Dim kriter
        kriter = "WHERE (tbFirma.sKodu  " & sorgu_kriter_string(ara, ara_kriter) & ") or (tbFirma.sAciklama " & sorgu_kriter_string(ara, ara_kriter) & ") "
        Dim conn As New OleDb.OleDbConnection
        Dim cmd As New OleDb.OleDbCommand
        Dim adapter As New OleDb.OleDbDataAdapter
        conn.ConnectionString = Connection
        cmd.Connection = conn
        conn.Open()
        cmd.CommandText = sorgu_query("SET DATEFORMAT DMY SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT     ISNULL(COUNT(*), 0) AS KAYIT FROM         tbFirma " & kriter & "")
        Dim kayitsayisi = cmd.ExecuteScalar
        Return kayitsayisi
        conn.Dispose()
        cmd.Dispose()
        adapter.Dispose()
        cmd = Nothing
        adapter = Nothing
    End Function
    Private Sub dataload_tbFirma(ByVal ara As String, ByVal ara_kriter As String)
        Dim kriter
        kriter = "WHERE (tbFirma.sKodu  " & sorgu_kriter_string(ara, ara_kriter) & ") or (tbFirma.sAciklama " & sorgu_kriter_string(ara, ara_kriter) & ") "
        ds_firma = sorgu(sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT tbFirma.nFirmaID, tbFirma.sKodu, tbFirma.sAciklama, tbFirma.sSaticiRumuzu,tbFirma.nOzelIskontosu,tbFirma.nOzelIskontosu2,tbFirma.nOzelIskontosu3,tbFirma.nOzelIskontosu4,tbFirma.sFiyatTipi, tbFirma.lKrediLimiti, tbFirma.sSemt,tbFirma.sIl,tbFirma.sUlke,tbFirma.sPostaKodu,tbFirma.nVadeGun,tbFirma.sAdres1,tbFirma.sAdres2,tbFirma.sAdres1 + ' ' + tbFirma.sAdres2 + ' ' + tbFirma.sSemt + ' ' + tbFirma.sIl + ' ' + tbFirma.sUlke + ' ' + tbFirma.sPostaKodu AS Adres, tbFirma.sVergiDairesi, tbFirma.sVergiNo, tbFirmaAciklamasi.sAciklama1 + ' ' + tbFirmaAciklamasi.sAciklama2 + ' ' + tbFirmaAciklamasi.sAciklama3 + ' ' + tbFirmaAciklamasi.sAciklama4 + ' ' + tbFirmaAciklamasi.sAciklama5 AS ISTIHBARAT, tbFSinif1.sAciklama AS SINIF1, tbFSinif2.sAciklama AS SINIF2, tbFSinif3.sAciklama AS SINIF3, tbFSinif4.sAciklama AS SINIF4, tbFSinif5.sAciklama AS SINIF5, (SELECT ISNULL(SUM(lBorcTutar - lAlacakTutar) , 0) AS lBakiye FROM tbFirmaHareketi WHERE nFirmaID = tbFirma.nFirmaID) AS lBakiye, tbHesapPlani.nHesapID, tbHesapPlani.sKodu AS sHesapKodu, tbHesapPlani.sAciklama AS sHesapAciklama,(SELECT     TOP 1 sIletisimAdresi FROM          tbFirmaIletisimi WHERE      nFirmaId = tbFirma.nFirmaID AND sIletisimAraci = 'E-Mail') AS [E-Mail],(SELECT     TOP 1 sIletisimAdresi FROM          tbFirmaIletisimi WHERE      nFirmaId = tbFirma.nFirmaID AND sIletisimAraci = 'Fax') AS [Fax],(SELECT     TOP 1 sIletisimAdresi FROM          tbFirmaIletisimi WHERE      nFirmaId = tbFirma.nFirmaID AND sIletisimAraci = 'Gsm') AS [Gsm],(SELECT     TOP 1 sIletisimAdresi FROM          tbFirmaIletisimi WHERE      nFirmaId = tbFirma.nFirmaID AND sIletisimAraci = 'Telefon') AS [Telefon],(SELECT     TOP 1 sIletisimAdresi FROM          tbFirmaIletisimi WHERE      nFirmaId = tbFirma.nFirmaID AND sIletisimAraci = 'Web') AS [Web],(SELECT     TOP 1 sIletisimAdresi FROM          tbFirmaIletisimi WHERE      nFirmaId = tbFirma.nFirmaID AND sIletisimAraci = 'Yetkili') AS [Yetkili] FROM tbFirmaAciklamasi RIGHT OUTER JOIN tbFirma INNER JOIN tbHesapPlani ON tbFirma.nHesapID = tbHesapPlani.nHesapID ON tbFirmaAciklamasi.nFirmaID = tbFirma.nFirmaID LEFT OUTER JOIN tbFSinif1 INNER JOIN tbFirmaSinifi ON tbFSinif1.sSinifKodu = tbFirmaSinifi.sSinifKodu1 INNER JOIN tbFSinif2 ON tbFirmaSinifi.sSinifKodu2 = tbFSinif2.sSinifKodu INNER JOIN tbFSinif3 ON tbFirmaSinifi.sSinifKodu3 = tbFSinif3.sSinifKodu INNER JOIN tbFSinif4 ON tbFirmaSinifi.sSinifKodu4 = tbFSinif4.sSinifKodu INNER JOIN tbFSinif5 ON tbFirmaSinifi.sSinifKodu5 = tbFSinif5.sSinifKodu ON tbFirma.nFirmaID = tbFirmaSinifi.nFirmaID " & kriter & " ORDER BY tbFirma.sKodu"))
    End Sub
    Private Function sorgu_query(ByVal query As String) As String
        query = Replace(query, "*!F", "F0" + firmano.ToString)
        query = Replace(query, "!D", "D000" + DonemNo.ToString)
        Return query
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
    Private Sub BarButtonItem7_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem7.ItemClick
        analiz_stok_hareket()
    End Sub
    Private Sub BarButtonItem8_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem8.ItemClick
        analiz_cari_hareket_detayli()
    End Sub
    Private Sub BarButtonItem9_ItemClick(ByVal sender As Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem9.ItemClick
        analiz_detay()
    End Sub
    Private Sub analiz_detay()
        If GridView1.RowCount > 0 Then
            Dim dr As DataRow = GridView1.GetDataRow(GridView1.FocusedRowHandle)
            If dr("nBordroKayitID") <> 0 And Trim(dr("sOdemeSekli")) <> "KK" Then
                analiz_tbFirmaBordro(dr("nFirmaID"), dr("nBordroKayitID"))
            ElseIf dr("nBordroKayitID") <> 0 And Trim(dr("sOdemeSekli")) = "KK" Then
                Dim ds_tbMuhasebe As DataSet = sorgu(sorgu_query("Select nFisSiraID ,sMuhFisTipi,lFisNo,lYevmiyeNo,dteFisTarihi from tbMuhasebeFisi Where nFisSiraID = " & dr("nBordroKayitID") & " "))
                If ds_tbMuhasebe.Tables(0).Rows.Count <> 0 Then
                    Dim dr1 As DataRow = ds_tbMuhasebe.Tables(0).Rows(0)
                    Dim frm As New frm_tbMuhasebeFisi
                    frm.firmano = firmano
                    frm.donemno = DonemNo
                    frm.connection = Connection
                    frm.dteFisTarihi = dr1("dteFisTarihi")
                    frm.lFisNo = sorgu_sayi(dr1("lFisNo"), 0)
                    frm.sMuhFisTipi = dr1("sMuhFisTipi")
                    'frm.txt_lYevmiyeNo.EditValue = dr("lYevmiyeNo")
                    frm.kullanici = kullanici
                    If yetki_kontrol(kullanici, frm.Name) = True Then
                        frm.ShowDialog()
                    End If
                    frm.Close()
                    frm.Dispose()
                    frm = Nothing
                End If
            End If
        End If
    End Sub
    Private Sub analiz_tbFirmaBordro(ByVal nFirmaID As Int64, ByVal nKayitID As Int64)
        If GridView1.RowCount > 0 Then
            Dim dr As DataRow = GridView1.GetDataRow(GridView1.FocusedRowHandle)
            Dim dr1 As DataRow
            Dim ds_tbFirmaBordroMaster As DataSet = sorgu(sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT tbFirmaBordroMaster.nBordroID, tbFirmaBordroMaster.dteBordroTarihi, tbFirmaBordroMaster.lBordroNo, tbFirmaBordroMaster.sFisTipi, tbFirmaBordroMaster.nGirisCikis FROM tbFirmaBordroDetay INNER JOIN tbFirmaBordroMaster ON tbFirmaBordroDetay.nBordroID = tbFirmaBordroMaster.nBordroID WHERE (tbFirmaBordroDetay.nFirmaID = " & nFirmaID & ") and (tbFirmaBordroDetay.nKayitID = " & nKayitID & ")"))
            If ds_tbFirmaBordroMaster.Tables(0).Rows.Count > 0 Then
                dr1 = ds_tbFirmaBordroMaster.Tables(0).Rows(0)
                Dim frm As New frm_tbFirmaBordro
                frm.firmano = firmano
                frm.donemno = DonemNo
                frm.connection = Connection
                frm.kullanici = kullanici
                frm.sFisTipi = dr1("sFisTipi")
                frm.nGirisCikis = dr1("nGirisCikis")
                frm.nBordroID = dr1("nBordroID")
                frm.sFisTipi = dr1("sFisTipi")
                frm.nGirisCikis = dr1("nGirisCikis")
                frm.sKayitID = nKayitID
                If yetki_kontrol(kullanici, frm.Name) = True Then
                    frm.ShowDialog()
                End If
                frm.Close()
                frm.Dispose()
                frm = Nothing
                dr1 = Nothing
                ds_tbFirmaBordroMaster.Dispose()
                ds_tbFirmaBordroMaster = Nothing
            End If
        End If
    End Sub
End Class