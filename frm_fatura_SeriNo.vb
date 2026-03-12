Imports DevExpress.XtraEditors
Public Class frm_fatura_SeriNo
    Public firmano
    Public donemno
    Public kullanici
    Public connection
    Public nStokFisiID As String
    Public nIslemID As Integer
    Public nStokID As Integer
    Public sFisTipi As String
    Public nGirisCikis As Integer
    Private Sub frm_fatura_SeriNo_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dataload_tbStokFisiSeriNo(nStokFisiID, nIslemID)
        Try
            gorunum_yukle()
        Catch ex As Exception
        End Try
        GroupControl1.Focus()
        GroupControl1.Select()
        txt_sSeri.Text = ""
        txt_sSeri.Focus()
        txt_sSeri.SelectAll()
    End Sub
    Private Function sorgu_kriter_string(ByVal deger As String, ByVal kriter As String) As String
        Dim sorgu_kriter As String = ""
        If kriter = "Baþlar" Then
            sorgu_kriter = String.Format(" LIKE '{0}%' ", deger)
        ElseIf kriter = "Biter" Then
            sorgu_kriter = String.Format(" LIKE '%{0}' ", deger)
        ElseIf kriter = "Ýçerir" Then
            sorgu_kriter = String.Format(" LIKE '%{0}%' ", deger)
        ElseIf kriter = "Boþ" Then
            sorgu_kriter = " IS NULL "
        ElseIf kriter = "Dolu" Then
            sorgu_kriter = " <> '' "
        ElseIf kriter = "Farklý" Then
            sorgu_kriter = String.Format(" <> '{0}' ", deger)
        ElseIf kriter = "Büyük" Then
            sorgu_kriter = String.Format(" >  '{0}' ", deger)
        ElseIf kriter = "Küçük" Then
            sorgu_kriter = String.Format(" < '{0}' ", deger)
        ElseIf kriter = "Eþittir" Then
            sorgu_kriter = String.Format(" = '{0}' ", deger)
        End If
        Return sorgu_kriter
    End Function
    Private Sub gorunum_kaydet()
        GridView1.SaveLayoutToRegistry(String.Format("SOFTWARE\BusinessSmart\VIEW\MAGAZA\{0}", Name))
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
        SimpleButton3.Text = Sorgu_sDil(SimpleButton3.Text, sDil)
        SimpleButton4.Text = Sorgu_sDil(SimpleButton4.Text, sDil)
        SimpleButton5.Text = Sorgu_sDil(SimpleButton5.Text, sDil)
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
    Public Sub Dataload_tbStokFisiSeriNo(ByVal nStokFisiID As String, ByVal nIslemID As Integer)
        Try
            DataSet1.Tables(0).Clear()
        Catch ex As Exception
        End Try
        Dim conn As New OleDb.OleDbConnection
        Dim cmd As New OleDb.OleDbCommand
        Dim adapter As New OleDb.OleDbDataAdapter
        conn.ConnectionString = connection
        adapter.SelectCommand = cmd
        cmd.CommandText = sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT     tbStokFisiSeriNo.*, tbStok.sKodu, tbStok.sAciklama, tbStok.sModel FROM         tbStokFisiSeriNo INNER JOIN                       tbStok ON tbStokFisiSeriNo.nStokID = tbStok.nStokID WHERE     (tbStokFisiSeriNo.nStokFisiID = '" & nStokFisiID & "') AND (tbStokFisiSeriNo.nIslemID = " & nIslemID & ") ")
        cmd.Connection = conn
        Dim N As Integer = adapter.Fill(DataSet1, "Table1")
        conn.Close()
        GridControl1.Focus()
        GridControl1.Select()
    End Sub
    Private Sub tbStokFisiSeriNo_kaydet_yeni(ByVal nStokFisiID As String, ByVal nIslemID As Integer, ByVal nStokID As Integer, ByVal sSeri As String, ByVal sSeriAciklama As String, ByVal nMiktar As Decimal)
        Dim cmd As New OleDb.OleDbCommand
        Dim con As New OleDb.OleDbConnection
        cmd.Connection = con
        con.ConnectionString = connection
        If con.State = ConnectionState.Closed = True Then
            con.Open()
        End If
        cmd.CommandText = sorgu_query(String.Format("SET DATEFORMAT DMY SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED INSERT INTO tbStokFisiSeriNo (nStokFisiID, nIslemID, nStokID, sSeri, sSeriAciklama, nMiktar) VALUES ('{0}', {1}, {2}, '{3}', '{4}', {5})", nStokFisiID, nIslemID, nStokID, sSeri, sSeriAciklama, nMiktar))
        cmd.ExecuteNonQuery()
        con.Close()
    End Sub
    Private Sub tbStokFisiSeriNo_kaydet_duzelt(ByVal nStokFisiID As Integer, ByVal nIslemID As Integer, ByVal nStokID As Integer, ByVal sSeri As String, ByVal sSeriAciklama As String, ByVal nMiktar As Decimal)
        Dim cmd As New OleDb.OleDbCommand
        Dim con As New OleDb.OleDbConnection
        cmd.Connection = con
        con.ConnectionString = connection
        If con.State = ConnectionState.Closed = True Then
            con.Open()
        End If
        cmd.CommandText = sorgu_query(String.Format("SET DATEFORMAT DMY SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED UPDATE    tbStokFisiSeriNo SET               sSeri = '{0}', sSeriAciklama = '{1}', nMiktar = {2} WHERE nStokFisiID = '{3}' AND nIslemID = {4} AND nStokID = {5}", sSeri, sSeriAciklama, nMiktar, nStokFisiID, nIslemID, nStokID))
        cmd.ExecuteNonQuery()
        con.Close()
    End Sub
    Private Sub tbStokFisiSeriNo_kaydet_sil(ByVal nStokFisiID As String, ByVal nIslemID As Integer, ByVal nStokID As Integer, ByVal sSeri As String)
        Dim cmd As New OleDb.OleDbCommand
        Dim con As New OleDb.OleDbConnection
        cmd.Connection = con
        con.ConnectionString = connection
        If con.State = ConnectionState.Closed = True Then
            con.Open()
        End If
        cmd.CommandText = sorgu_query(String.Format("SET DATEFORMAT DMY SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED DELETE FROM tbStokFisiSeriNo WHERE nStokFisiID = '{0}' AND nIslemID = {1} AND nStokID = {2} and sSeri ='{3}'", nStokFisiID, nIslemID, nStokID, sSeri))
        cmd.ExecuteNonQuery()
        con.Close()
    End Sub
    Public Function sorgu_sSeri_kontrol(ByVal nStokID As Integer, ByVal sSeri As String, ByVal nMiktar As Decimal, Optional ByVal nGirisCikis As Integer = 1) As Boolean
        Dim kriter As String = ""
        Dim pass As Boolean
        If nGirisCikis = 4 Or nGirisCikis = 2 Then
            kriter += " and nMiktar = -1 "
        End If
        Dim conn As New OleDb.OleDbConnection
        Dim cmd As New OleDb.OleDbCommand
        Dim adapter As New OleDb.OleDbDataAdapter
        conn.ConnectionString = connection
        cmd.Connection = conn
        conn.Open()
        cmd.CommandText = sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT     ISNULL(SUM(nMiktar),0) AS nKayit FROM         tbStokFisiSeriNo WHERE     (sSeri = '" & sSeri & "') and nStokID =" & nStokID & " " & kriter & " ")
        Dim kayitsayisi As Decimal = cmd.ExecuteScalar
        If nGirisCikis = 1 Or nGirisCikis = 2 Then
            If kayitsayisi = 0 Then
                pass = True
            Else
                pass = False
            End If
        ElseIf nGirisCikis = 3 Or nGirisCikis = 4 Then
            'If kayitsayisi = 1 Then
            '    pass = True
            'Else
            '    pass = False
            'End If
            If kayitsayisi = 0 Then
                pass = False
            ElseIf kayitsayisi >= nMiktar Then
                pass = True
            Else
                pass = False
            End If
        End If
        Return pass
    End Function
    Private Sub SimpleButton2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SimpleButton2.Click
        Me.Close()
    End Sub
    Private Sub SimpleButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SimpleButton1.Click
        Me.Close()
    End Sub
    Private Sub SimpleButton3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SimpleButton3.Click
        kaydet_tumu()
    End Sub
    Private Sub kaydet_tumu()
        If Trim(txt_sSeri.Text) <> "" Then
            If nGirisCikis = 1 Then
                If sorgu_sSeri_kontrol(nStokID, txt_sSeri.Text, txt_nMiktar.EditValue, nGirisCikis) = True Then
                    tbStokFisiSeriNo_kaydet_yeni(nStokFisiID, nIslemID, nStokID, txt_sSeri.Text, txt_sSeriAciklama.Text, txt_nMiktar.Value)
                    Dataload_tbStokFisiSeriNo(nStokFisiID, nIslemID)
                    txt_sSeri.Text = ""
                    txt_sSeri.Focus()
                    txt_sSeri.SelectAll()
                Else
                    XtraMessageBox.Show(Sorgu_sDil(String.Format("[{0}] Seri No Önceden Kullanýlmýþ...!", txt_sSeri.Text), sDil), Sorgu_sDil("Dikkat", sDil), MessageBoxButtons.OK, MessageBoxIcon.Warning)
                    'txt_sSeri.Text = ""
                    txt_sSeri.Focus()
                    txt_sSeri.SelectAll()
                End If
            ElseIf nGirisCikis = 2 Then
                If sorgu_sSeri_kontrol(nStokID, txt_sSeri.Text, txt_nMiktar.EditValue, nGirisCikis) = True Then
                    tbStokFisiSeriNo_kaydet_yeni(nStokFisiID, nIslemID, nStokID, txt_sSeri.Text, txt_sSeriAciklama.Text, -txt_nMiktar.Value)
                    Dataload_tbStokFisiSeriNo(nStokFisiID, nIslemID)
                    txt_sSeri.Text = ""
                    txt_sSeri.Focus()
                    txt_sSeri.SelectAll()
                Else
                    XtraMessageBox.Show(Sorgu_sDil(String.Format("[{0}] Seri No Kaydý Yok veya Teslim Edilmiþ", txt_sSeri.Text), sDil), Sorgu_sDil("Dikkat", sDil), MessageBoxButtons.OK, MessageBoxIcon.Warning)
                    'txt_sSeri.Text = ""
                    txt_sSeri.Focus()
                    txt_sSeri.SelectAll()
                End If
            ElseIf nGirisCikis = 3 Then
                If sorgu_sSeri_kontrol(nStokID, txt_sSeri.Text, txt_nMiktar.EditValue, nGirisCikis) = True Then
                    tbStokFisiSeriNo_kaydet_yeni(nStokFisiID, nIslemID, nStokID, txt_sSeri.Text, txt_sSeriAciklama.Text, -txt_nMiktar.Value)
                    Dataload_tbStokFisiSeriNo(nStokFisiID, nIslemID)
                    txt_sSeri.Text = ""
                    txt_sSeri.Focus()
                    txt_sSeri.SelectAll()
                Else
                    XtraMessageBox.Show(Sorgu_sDil(String.Format("[{0}] Seri No Kaydý Yok veya Teslim Edilmiþ", txt_sSeri.Text), sDil), Sorgu_sDil("Dikkat", sDil), MessageBoxButtons.OK, MessageBoxIcon.Warning)
                    'txt_sSeri.Text = ""
                    txt_sSeri.Focus()
                    txt_sSeri.SelectAll()
                End If
            ElseIf nGirisCikis = 4 Then
                If sorgu_sSeri_kontrol(nStokID, txt_sSeri.Text, txt_nMiktar.EditValue, nGirisCikis) = True Then
                    tbStokFisiSeriNo_kaydet_yeni(nStokFisiID, nIslemID, nStokID, txt_sSeri.Text, txt_sSeriAciklama.Text, txt_nMiktar.Value)
                    Dataload_tbStokFisiSeriNo(nStokFisiID, nIslemID)
                    txt_sSeri.Text = ""
                    txt_sSeri.Focus()
                    txt_sSeri.SelectAll()
                Else
                    XtraMessageBox.Show(Sorgu_sDil(String.Format("[{0}] Seri Nosunun Çýkýþ Kaydý Yok...!", txt_sSeri.Text), sDil), Sorgu_sDil("Dikkat", sDil), MessageBoxButtons.OK, MessageBoxIcon.Warning)
                    'txt_sSeri.Text = ""
                    txt_sSeri.Focus()
                    txt_sSeri.SelectAll()
                End If
            End If
        End If
    End Sub
    Private Sub satirs_sil()
        If GridView1.RowCount > 0 Then
            If XtraMessageBox.Show(Sorgu_sDil("Satýrý Silmek Ýstediðinize Emin misiniz...?", sDil), Sorgu_sDil("Dikkat", sDil), MessageBoxButtons.YesNo, MessageBoxIcon.Question) = MsgBoxResult.Yes Then
                Dim dr As DataRow
                dr = GridView1.GetDataRow(GridView1.FocusedRowHandle)
                tbStokFisiSeriNo_kaydet_sil(nStokFisiID, nIslemID, nStokID, dr("sSeri"))
                DataSet1.Tables(0).Rows.Remove(dr)
                'GridView1.DeleteRow(GridView1.FocusedRowHandle)
                GridControl1.Focus()
                GridControl1.Select()
                If GridView1.RowCount > 0 Then
                    GridView1.SelectRow(GridView1.FocusedRowHandle)
                End If
            End If
        End If
    End Sub
    Private Sub satir_sil()
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
                        tbStokFisiSeriNo_kaydet_sil(nStokFisiID, nIslemID, nStokID, dr1("sSeri"))
                        bar.Position += 1
                        bar.Refresh()
                    Next
                    DataSet1.Clear()
                    XtraMessageBox.Show(Sorgu_sDil("Ýþlem Baþarýyla Tamamlandý...", sDil), Sorgu_sDil("Dikkat", sDil), MessageBoxButtons.OK, MessageBoxIcon.Information)
                    'panelstatus.Visible = False
                    bar.Visible = False
                End If
                dr1 = Nothing
                Dataload_tbStokFisiSeriNo(nStokFisiID, nIslemID)
            End If
        End If
    End Sub
    Private Sub raporla_excel()
        If XtraMessageBox.Show(Sorgu_sDil("Sonuçlarý Excel Dosyasý Oluþturmak Ýstediðinize Emin misiniz...?", sDil), Sorgu_sDil("Dikkat", sDil), MessageBoxButtons.YesNo, MessageBoxIcon.Question) = MsgBoxResult.Yes Then
            Dim SaveFileDialog1 As New Windows.Forms.SaveFileDialog() With {.Filter = "Excel Dosyalarý(*.xls) |*.xls", .InitialDirectory = "c:\", .FileName = "Rapor.xls"}
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
            Dim SaveFileDialog1 As New Windows.Forms.SaveFileDialog() With {.Filter = "Text Dosyalarý(*.txt) |*.txt", .InitialDirectory = "c:\", .FileName = "Rapor.txt"}
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
            Dim SaveFileDialog1 As New Windows.Forms.SaveFileDialog() With {.Filter = "Metin Dosyalarý(*.pdf) |*.pdf", .InitialDirectory = "c:\", .FileName = "Rapor.pdf"}
            If SaveFileDialog1.ShowDialog = Windows.Forms.DialogResult.OK Then
                GridView1.ExportToPdf(SaveFileDialog1.FileName.ToString)
                If XtraMessageBox.Show(Sorgu_sDil("Kaydý Açmak Ýster misiniz...?", sDil), Sorgu_sDil("Dikkat", sDil), MessageBoxButtons.YesNo, MessageBoxIcon.Question) = MsgBoxResult.Yes Then
                    Process.Start(SaveFileDialog1.FileName.ToString)
                End If
            End If
            SaveFileDialog1 = Nothing
        End If
    End Sub
    Private Sub raporla_xml()
        If XtraMessageBox.Show(Sorgu_sDil("Sonuçlarý XML Dosyasý Oluþturmak Ýstediðinize Emin misiniz...?", sDil), Sorgu_sDil("Dikkat", sDil), MessageBoxButtons.YesNo, MessageBoxIcon.Question) = MsgBoxResult.Yes Then
            Dim SaveFileDialog1 As New Windows.Forms.SaveFileDialog
            SaveFileDialog1.Filter = "Þablon Dosyalarý(*.xml) |*.xml"
            SaveFileDialog1.InitialDirectory = "c:\"
            SaveFileDialog1.FileName = nStokFisiID & ".xml"
            If SaveFileDialog1.ShowDialog = Windows.Forms.DialogResult.OK Then
                DataSet1.WriteXml(SaveFileDialog1.FileName.ToString)
                If XtraMessageBox.Show(Sorgu_sDil("Kaydý Açmak Ýster misiniz...?", sDil), Sorgu_sDil("Dikkat", sDil), MessageBoxButtons.YesNo, MessageBoxIcon.Question) = MsgBoxResult.Yes Then
                    Process.Start(SaveFileDialog1.FileName.ToString)
                End If
            End If
            SaveFileDialog1 = Nothing
        End If
    End Sub
    Private Sub analiz_StokSeriNo()
        Dim frm As New frm_Stok_SeriNo() With {.firmano = firmano, .donemno = donemno, .connection = connection, .nStokID = nStokID}
        If yetki_kontrol(kullanici, frm.Name) = True Then
            If frm.ShowDialog(Me) = Windows.Forms.DialogResult.OK Then
                If nGirisCikis = 3 Then
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
                            dr1 = frm.GridView1.GetDataRow(s)
                            txt_sSeri.Text = dr1("sSeri")
                            kaydet_tumu()
                        Next
                    End If
                End If
            End If
        End If
        frm.Close()
        frm.Dispose()
        frm = Nothing
    End Sub
    Private Sub BarButtonItem1_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem1.ItemClick
        satir_sil()
    End Sub
    Private Sub BarButtonItem2_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem2.ItemClick
        GridControl1.ShowPrintPreview()
    End Sub
    Private Sub BarButtonItem3_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem3.ItemClick
        raporla_excel()
    End Sub
    Private Sub BarButtonItem4_ItemClick(ByVal sender As Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem4.ItemClick
        raporla_text()
    End Sub
    Private Sub BarButtonItem5_ItemClick(ByVal sender As Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem5.ItemClick
        raporla_pdf()
    End Sub
    Private Sub BarButtonItem6_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem6.ItemClick
        Close()
    End Sub
    Private Sub BarButtonItem7_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem7.ItemClick
        analiz_StokSeriNo()
    End Sub
    Private Sub BarButtonItem9_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem9.ItemClick
        GroupSeri.Visible = True
        txt_sAnaGrup.Focus()
        txt_sAnaGrup.SelectAll()
    End Sub
    Private Sub SimpleButton4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SimpleButton4.Click
        GroupSeri.Visible = False
        GridControl1.Focus()
        GridControl1.Select()
    End Sub
    Private Sub otomatikKod(ByVal sAnaHesap As String, ByVal sAltHesap As String, ByVal nSeriMiktar As Integer, ByVal bGuid As Boolean, ByVal nGuidHane As Integer, ByVal bCheckDigit As Boolean)
        Dim sUzunluk As String = Len(sAltHesap)
        Dim sayi = GridView1.RowCount
        Dim satir = GridView1.FocusedRowHandle
        Dim TOPLAM = sayi - GridView1.FocusedRowHandle
        Dim Ý As Integer = 0
        'Dim dr_hareket As DataRow
        'dr_hareket = GridView1.GetDataRow(GridView1.FocusedRowHandle)
        ''durum = dr_hareket("sKodu")
        Dim sSeri As String = ""
        'kl.Position += 1
        bar.Properties.Maximum = nSeriMiktar
        bar.Visible = True
        bar.Position = 0
        For Ý = 1 To nSeriMiktar
            If bGuid = False Then
                sAltHesap = CType(sAltHesap, Integer) + 1
                sSeri = sAnaHesap.ToString & sayiuzunlukkontrol(sAltHesap, sUzunluk).ToString
                If bCheckDigit = True Then
                    sSeri += check(sSeri).ToString
                End If
                If sorgu_sSeri_kontrol(nStokID, sSeri, nGirisCikis) = True Then
                    tbStokFisiSeriNo_kaydet_yeni(nStokFisiID, nIslemID, nStokID, sSeri, txt_sSeriAciklama.Text, 1)
                End If
            Else
                sSeri = sorgu_sGuid(nGuidHane)
                If bCheckDigit = True Then
                    sSeri += check(sSeri).ToString
                End If
                If sorgu_sSeri_kontrol(nStokID, sSeri, nGirisCikis) = True Then
                    tbStokFisiSeriNo_kaydet_yeni(nStokFisiID, nIslemID, nStokID, sSeri, txt_sSeriAciklama.Text, 1)
                End If
            End If
            bar.Position += 1
            bar.Refresh()
        Next
        bar.Properties.Maximum = 0
        bar.Position = 0
        bar.Refresh()
        bar.Visible = False
        'kl.Position = satir
        GridView1.FocusedRowHandle = satir
        GridView1.GetDataRow(satir)
        sayi = Nothing
        satir = Nothing
        Ý = Nothing
    End Sub
    Public Shared Function sayiuzunlukkontrol(ByVal deger As String, ByVal uzunluk As String) As String
        Dim degeruzunluk As Integer = uzunluk
        Dim muzunluk As Int64 = Len(deger)
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
    Public Function sorgu_sGuid(ByVal nGuidHane As Integer) As String
        Dim kriter As String = ""
        Dim con As New OleDb.OleDbConnection
        Dim cmd As New OleDb.OleDbCommand
        con.ConnectionString = connection
        cmd.Connection = con
        con.Open()
        cmd.CommandText = sorgu_query(String.Format("SET DATEFORMAT DMY SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT     REPLACE(RIGHT(NEWID(), {0}), '-', '') AS sGuiD", nGuidHane))
        Dim kayitsayisi = cmd.ExecuteScalar
        Return kayitsayisi
        con.Dispose()
        cmd.Dispose()
        cmd = Nothing
    End Function
    Private Sub SimpleButton5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SimpleButton5.Click
        If XtraMessageBox.Show(Sorgu_sDil("Sýra Seri Oluþturmak Ýstediðinize Emin misiniz...?", sDil), Sorgu_sDil("Dikkat", sDil), MessageBoxButtons.YesNo, MessageBoxIcon.Question) = MsgBoxResult.Yes Then
            label2.Text = "Lütfen Bekleyiniz...!"
            label2.Refresh()
            Cursor.Current = Cursors.WaitCursor
            Cursor.Show()
            otomatikKod(txt_sAnaGrup.Text, txt_sAltGrup.Text, txt_nSeriMiktar.Text, sec_sGuid.Checked, txt_nGuidHane.Text, sec_bCheckDigit.Checked)
            Dataload_tbStokFisiSeriNo(nStokFisiID, nIslemID)
            GroupSeri.Visible = False
            GridControl1.Focus()
            GridControl1.Select()
            label2.Text = Sorgu_sDil("Tamamlandý...", sDil)
            label2.Refresh()
            Cursor.Current = Cursors.Default
            Cursor.Hide()
        End If
    End Sub
    Private Shared Function check(ByVal sSeri As String) As Integer
        Dim nCheckDigit As Integer = 0
        If Len(sSeri) >= 12 Then
            If IsNumeric(sSeri) = True Then
                nCheckDigit = Ean13_CheckSum(Microsoft.VisualBasic.Left(sSeri, 12))
            End If
        ElseIf Len(sSeri) >= 7 Then
            If IsNumeric(sSeri) = True Then
                nCheckDigit = EAN8_Checksum(Microsoft.VisualBasic.Left(sSeri, 7))
            End If
        End If
        Return nCheckDigit
    End Function
    Private Shared Function Ean13_CheckSum(ByVal barcode As String) As Integer
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
    Private Shared Function EAN8_Checksum(ByVal EAN8_Barcode As String) As String
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
    Private Sub raporla(ByVal nIslem As Integer)
        Dim OpenFileDialog1 As New Windows.Forms.OpenFileDialog() With {.Title = "Rapor Seç...", .Filter = "Rapor Dosyalarý (SeriNo*.frx) |SeriNo*.frx", .FileName = "c:\Formlar\Raporlar\SeriNo\SeriNo.frx", .InitialDirectory = "c:\Formlar\Raporlar\SeriNo\"}
        If OpenFileDialog1.ShowDialog = Windows.Forms.DialogResult.OK Then
            Dim sFile = OpenFileDialog1.FileName.ToString
            Dim report As New FastReport.Report
            report.Load(sFile)
            report.RegisterData(DataSet1, "TABLE1")
            report.RegisterData(ds_tbParamGenel)
            report.GetDataSource("Table1").Enabled = True
            report.ScriptLanguage = FastReport.Language.Vb
            If nIslem = 0 Then
                report.Show()
            ElseIf nIslem = 1 Then
                report.Design()
            ElseIf nIslem = 2 Then
                'report.Prepare()
                report.Print()
            End If
            report.Dispose()
            report = Nothing
        End If
    End Sub
    Private Sub BarButtonItem10_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem10.ItemClick
        raporla(0)
    End Sub
    Private Sub BarButtonItem11_ItemClick(ByVal sender As Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem11.ItemClick
        raporla(1)
    End Sub
    Private Sub BarButtonItem12_ItemClick(ByVal sender As Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem12.ItemClick
        raporla(2)
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
            label2.Text = Sorgu_sDil("Kayýt Sayýsý :", sDil) & GridView1.RowCount & " / " & Sorgu_sDil("Satýr :", sDil) & GridView1.FocusedRowHandle + 1 & " / " & Sorgu_sDil("Seçili :", sDil) & GridView1.SelectedRowsCount
        ElseIf GridView1.SelectedRowsCount = 1 Then
            label2.Text = Sorgu_sDil("Kayýt Sayýsý :", sDil) & GridView1.RowCount & " / " & Sorgu_sDil("Satýr :", sDil) & GridView1.FocusedRowHandle + 1
        Else
            label2.Text = ""
        End If
    End Sub
    Private Sub txt_sSeri_EditValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles txt_sSeri.EditValueChanged
        If Len(txt_sSeri.Text.ToString) <> 0 Then
            lbl_sKodu.Text = Len(txt_sSeri.EditValue.ToString)
        Else
            lbl_sKodu.Text = "*"
        End If
    End Sub
    Private Sub txt_sSeri_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txt_sSeri.KeyDown
        If e.KeyCode = Keys.Enter Then
            kaydet_tumu()
        End If
    End Sub
    Private Sub BarButtonItem13_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem13.ItemClick
        raporla_xml()
    End Sub
End Class