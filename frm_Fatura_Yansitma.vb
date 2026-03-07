Imports Microsoft.Win32
Imports DevExpress.XtraEditors
Public Class frm_Fatura_Yansitma
    Public firmano
    Public donemno
    Public connection
    Public kullanici
    Public nKarsiID As Int64
    Public nKarsiIslemID As Int64 = 0
    Public lNetTutar As Decimal
    Public dteFisTarihi As DateTime = "01/01/1900"
    Public nStokFisiID As Int64 = 0
    Public bYansitilan As Boolean = False
    Dim dr As DataRow
    'Public lHarcanan As Integer = 0
    Private Sub frm_stok_pesin_puan_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
    End Sub
    Private Sub frm_stok_pesin_puan_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            gorunum_yukle()
        Catch ex As Exception
        End Try
        dataload(nKarsiID, nKarsiIslemID)
    End Sub

    Private Sub MenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem1.Click
        If nKarsiIslemID = 0 Then
            satir_ekle("FA ", 1)
        Else
        End If
    End Sub
    Private Sub gorunum_kaydet()
        GridView1.SaveLayoutToRegistry("SOFTWARE\BusinessSmart\VIEW\MAGAZA\" & Me.Name.ToString & "")
        XtraMessageBox.Show(Sorgu_sDil("Görünüm Kaydedildi", sDil), Sorgu_sDil("Dikkat", sDil), MessageBoxButtons.OK, MessageBoxIcon.Information)
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
        Dim itm
        For Each itm In ContextMenu1.MenuItems
            itm.text = Sorgu_sDil(itm.text, sDil)
        Next
        SimpleButton1.Text = Sorgu_sDil(SimpleButton1.Text, sDil)
        SimpleButton2.Text = Sorgu_sDil(SimpleButton2.Text, sDil)
        GridView1.RestoreLayoutFromRegistry("SOFTWARE\BusinessSmart\VIEW\MAGAZA\" & Me.Name.ToString & "")
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
    Private Function sorgu(ByVal query As String) As DataSet
        Dim conn As New OleDb.OleDbConnection
        Dim cmd As New OleDb.OleDbCommand
        Dim adapter As New OleDb.OleDbDataAdapter
        conn.ConnectionString = connection
        adapter.SelectCommand = cmd
        cmd.CommandText = query
        cmd.Connection = conn
        If conn.State = ConnectionState.Closed Then
            conn.Open()
        End If
        Dim DS As New DataSet
        Dim N As Integer = adapter.Fill(DS, "TABLE1")
        conn.Close()
        Return DS
        cmd = Nothing
        adapter = Nothing
    End Function
    Public Function tbStokFisiEkMaliyet(ByVal nKarsiID As Int64, ByVal nKarsiIslemID As Int64) As DataSet
        Dim kriter As String = ""
        If bYansitilan = True Then
            kriter = " WHERE tbStokFisiEkMaliyet.nStokFisiID = '" & nKarsiID & "' and tbStokFisiEkMaliyet.nIslemID = 0 "
        Else
            kriter = " WHERE tbStokFisiEkMaliyet.nKarsiID = '" & nKarsiID & "' and tbStokFisiEkMaliyet.nKarsiIslemID = " & nKarsiIslemID & " "
        End If
        Dim conn As New OleDb.OleDbConnection
        Dim cmd As New OleDb.OleDbCommand
        Dim adapter As New OleDb.OleDbDataAdapter
        conn.ConnectionString = connection
        cmd.CommandTimeout = False
        adapter.SelectCommand = cmd
        cmd.CommandText = sorgu_query("SET DATEFORMAT DMY SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT tbStokFisiEkMaliyet.nKarsiID,tbStokFisiEkMaliyet.nKarsiIslemID, tbStokFisiEkMaliyet.lNetTutar AS lYansiyanTutar, tbStokFisiEkMaliyet.nStokFisiID, tbStokFisiEkMaliyet.nIslemID, tbStokFisiEkMaliyet.lTutar, tbStokFisiEkMaliyet.nOran, tbStokFisiMaster.sFisTipi, tbStokFisiMaster.dteFisTarihi, tbStokFisiMaster.nGirisCikis, tbStokFisiMaster.lFisNo, tbFirma.nFirmaID, tbFirma.sKodu AS sFirmaKodu, tbFirma.sAciklama AS sFirmaAciklama, tbStokFisiMaster.lNetTutar, tbStok.sKodu AS sStokKodu, tbStok.sModel, tbStok.sAciklama AS sStokAciklama, tbStokFisiDetayi.lGirisMiktar1, tbStokFisiDetayi.lCikisMiktar1, tbStokFisiDetayi.lCikisFiyat, tbStokFisiDetayi.lGirisFiyat, tbStokFisiDetayi.lGirisTutar, tbStokFisiDetayi.lCikisTutar FROM tbStok INNER JOIN tbStokFisiDetayi ON tbStok.nStokID = tbStokFisiDetayi.nStokID RIGHT OUTER JOIN tbStokFisiEkMaliyet INNER JOIN tbStokFisiMaster ON tbStokFisiEkMaliyet.nStokFisiID = tbStokFisiMaster.nStokFisiID INNER JOIN tbFirma ON tbStokFisiMaster.nFirmaID = tbFirma.nFirmaID ON tbStokFisiDetayi.nIslemID = tbStokFisiEkMaliyet.nIslemID " & kriter & " ")
        cmd.Connection = conn
        conn.Open()
        Dim Datastoklar1 As New DataSet
        Dim N As Integer = adapter.Fill(Datastoklar1, "tbStokFisiEkMaliyet")
        conn.Close()
        Return Datastoklar1
    End Function
    Private Sub tbStokFisiEkMaliyet_kaydet_yeni(ByVal nKarsiID As Int64, ByVal nKarsiIslemID As Int64, ByVal lNetTutar As Int64, ByVal nStokFisiID As Int64, ByVal nIslemID As Int64, ByVal lTutar As Decimal, ByVal nOran As Decimal)
        Dim cmd As New OleDb.OleDbCommand
        Dim con As New OleDb.OleDbConnection
        cmd.Connection = con
        con.ConnectionString = connection
        If con.State = ConnectionState.Closed = True Then
            con.Open()
        End If
        cmd.CommandText = sorgu_query("SET DATEFORMAT DMY SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED INSERT INTO tbStokFisiEkMaliyet (nKarsiID, nKarsiIslemID,lNetTutar, nStokFisiID, nIslemID, lTutar, nOran) VALUES     (" & nKarsiID & ", " & nKarsiIslemID & "," & lNetTutar & ", " & nStokFisiID & ", " & nIslemID & ", " & lTutar & ", " & nOran & ") ")
        cmd.ExecuteNonQuery()
        con.Close()
        cmd = Nothing
        con = Nothing
    End Sub
    Private Sub tbStokFisiEkMaliyet_kaydet_duzelt(ByVal nKarsiID As Int64, ByVal nKarsiIslemID As Int64, ByVal lNetTutar As Int64, ByVal nStokFisiID As Int64, ByVal nIslemID As Int64, ByVal lTutar As Decimal, ByVal nOran As Decimal)
        Dim cmd As New OleDb.OleDbCommand
        Dim con As New OleDb.OleDbConnection
        cmd.Connection = con
        con.ConnectionString = connection
        If con.State = ConnectionState.Closed = True Then
            con.Open()
        End If
        cmd.CommandText = sorgu_query("SET DATEFORMAT DMY SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED UPDATE    tbStokFisiEkMaliyet SET               lTutar = " & lTutar & ", nOran = " & nOran & " WHERE nKarsiID = " & nKarsiID & " and nKarsiIslemID =" & nKarsiIslemID & " AND nStokFisiID = " & nStokFisiID & " and nIslemID = " & nIslemID & "")
        cmd.ExecuteNonQuery()
        con.Close()
        cmd = Nothing
        con = Nothing
    End Sub
    Private Sub tbStokFisiEkMaliyet_kaydet_sil(ByVal nKarsiID As Int64, ByVal nKarsiIslemID As Int64, ByVal nStokFisiID As Int64, ByVal nIslemID As Int64)
        Dim cmd As New OleDb.OleDbCommand
        Dim con As New OleDb.OleDbConnection
        cmd.Connection = con
        con.ConnectionString = connection
        If con.State = ConnectionState.Closed = True Then
            con.Open()
        End If
        cmd.CommandText = sorgu_query("SET DATEFORMAT DMY SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED DELETE FROM tbStokFisiEkMaliyet WHERE nKarsiID = " & nKarsiID & " and  nKarsiIslemID =" & nKarsiIslemID & "  AND nStokFisiID = " & nStokFisiID & " and nIslemID = " & nIslemID & "")
        cmd.ExecuteNonQuery()
        con.Close()
        cmd = Nothing
        con = Nothing
    End Sub
    Private Function sorgu_query(ByVal query As String) As String
        query = Replace(query, "*!F", "F0" + firmano.ToString)
        query = Replace(query, "!D", "D000" + donemno.ToString)
        Return query
    End Function
    Private Sub dataload(ByVal nKarsiID As Int64, ByVal nKarsiIslemID As Int64)
        DataSet1 = tbStokFisiEkMaliyet(nKarsiID, nKarsiIslemID)
        GridControl1.DataSource = DataSet1.Tables(0)
        GridControl1.DataMember = Nothing
        PanelControl3.Select()
        GridControl1.Focus()
        GridControl1.Select()
        GridView1.CollapseAllGroups()
    End Sub
    Private Sub satir_ekle(ByVal sFisTipi As String, ByVal nGirisCikis As Int64, Optional ByVal kapla As Boolean = False)
        Dim frm As New frm_fatura_liste
        frm.firmano = firmano
        frm.donemno = donemno
        frm.connection = connection
        frm.kullanici = kullanici
        frm.sFisTipi = sFisTipi
        frm.nGirisCikis = nGirisCikis
        frm.islemstatus = True
        If kapla = True Then
            frm.MdiParent = Me
            frm.WindowState = FormWindowState.Maximized
        Else
            frm.WindowState = FormWindowState.Normal
        End If
        frm.kapla = kapla
        'frm.MdiParent = Me
        'frm.WindowState = FormWindowState.Normal
        If yetki_kontrol(kullanici, frm.Name) = True Then
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
                        dr = DataSet1.Tables(0).NewRow
                        dr1 = frm.GridView1.GetDataRow(s)
                        dr = DataSet1.Tables(0).NewRow
                        dr("nKarsiID") = nKarsiID
                        dr("nKarsiIslemID") = nKarsiIslemID
                        dr("lNetTutar") = lNetTutar
                        dr("nStokFisiID") = dr1("nStokFisiID")
                        dr("nIslemID") = 0
                        dr("lTutar") = lNetTutar
                        dr("nOran") = 0
                        tbStokFisiEkMaliyet_kaydet_yeni(dr("nKarsiID"), dr("nKarsiIslemID"), dr("lNetTutar"), dr("nStokFisiID"), dr("nIslemID"), dr("lTutar"), dr("nOran"))
                        DataSet1.Tables(0).Rows.Add(dr)
                        dataload(nKarsiID, nKarsiIslemID)
                        GridControl1.Focus()
                        GridControl1.Select()
                    Next
                End If
            End If
        End If
    End Sub
    Private Sub satir_ekle_stok(ByVal sFisTipi As String, ByVal nGirisCikis As Int64, Optional ByVal kapla As Boolean = False)
        Dim frm As New frm_fatura_kalemleri
        frm.firmano = firmano
        frm.donemno = donemno
        frm.connection = connection
        frm.kullanici = kullanici
        frm.sFisTipi = sFisTipi
        frm.nGirisCikis = nGirisCikis
        frm.islemstatus = True
        If kapla = True Then
            frm.MdiParent = Me
            frm.WindowState = FormWindowState.Maximized
        Else
            frm.WindowState = FormWindowState.Normal
        End If
        frm.kapla = kapla
        'frm.MdiParent = Me
        'frm.WindowState = FormWindowState.Normal
        If nKarsiIslemID > 0 Then
            frm.nStokFisiID = nKarsiID
        End If
        If yetki_kontrol(kullanici, frm.Name) = True Then
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
                        dr = DataSet1.Tables(0).NewRow
                        dr1 = frm.GridView1.GetDataRow(s)
                        dr = DataSet1.Tables(0).NewRow
                        dr("nKarsiID") = nKarsiID
                        dr("nKarsiIslemID") = nKarsiIslemID
                        dr("lNetTutar") = lNetTutar
                        dr("nStokFisiID") = dr1("nStokFisiID")
                        dr("nIslemID") = dr1("nIslemID")
                        dr("lTutar") = lNetTutar
                        dr("nOran") = 0
                        tbStokFisiEkMaliyet_kaydet_yeni(dr("nKarsiID"), dr("nKarsiIslemID"), dr("lNetTutar"), dr("nStokFisiID"), dr("nIslemID"), dr("lTutar"), dr("nOran"))
                        DataSet1.Tables(0).Rows.Add(dr)
                        dataload(nKarsiID, nKarsiIslemID)
                        GridControl1.Focus()
                        GridControl1.Select()
                    Next
                End If
            End If
        End If
    End Sub
    Private Sub satir_sil()
        If GridView1.RowCount > 0 Then
            If XtraMessageBox.Show(Sorgu_sDil("Satýrý Silmek Ýstediðinize Emin misiniz...?", sDil), Sorgu_sDil("Dikkat", sDil), MessageBoxButtons.YesNo, MessageBoxIcon.Question) = MsgBoxResult.Yes Then
                Dim dr As DataRow
                dr = GridView1.GetDataRow(GridView1.FocusedRowHandle)
                tbStokFisiEkMaliyet_kaydet_sil(dr("nKarsiID"), dr("nKarsiIslemID"), dr("nStokFisiID"), dr("nIslemID"))
                'GridView1.DeleteRow(GridView1.FocusedRowHandle)
                Dim satir = GridView1.FocusedRowHandle
                dataload(nKarsiID, nKarsiIslemID)
                If GridView1.RowCount > 0 Then
                    GridView1.ClearSelection()
                    GridView1.SelectRow(satir)
                    PanelControl3.Focus()
                    GridControl1.Focus()
                End If
                satir = Nothing
            End If
        End If
    End Sub
    Private Sub fis_duzelt()
        If GridView1.RowCount > 0 Then
            Dim dr As DataRow = GridView1.GetDataRow(GridView1.FocusedRowHandle)
            Dim frm As New frm_fatura
            frm.firmano = firmano
            frm.donemno = donemno
            frm.connection = connection
            frm.lFisNo = dr("lFisNo")
            frm.dteFisTarihi = dr("dteFisTarihi")
            frm.sFisTipi = dr("sFisTipi")
            frm.nFirmaID = dr("nFirmaID")
            frm.nGirisCikis = dr("nGirisCikis")
            frm.nStokFisiID = dr("nStokFisiID")
            frm.kullanici = kullanici
            Dim satir = GridView1.FocusedRowHandle
            If yetki_kontrol(kullanici, frm.Name) = True Then
                Try
                    frm.ShowDialog()
                Catch ex As Exception
                End Try
            End If
            frm.Close()
            frm = Nothing
            dr = Nothing
            dataload(nKarsiID, nKarsiIslemID)
            GridView1.FocusedRowHandle = satir
            satir = Nothing
        End If
    End Sub
    Private Sub MenuItem3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem3.Click
        satir_sil()
    End Sub
    Private Sub MenuItem7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem7.Click
        GridView1.ColumnsCustomization()
    End Sub
    Private Sub MenuItem8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem8.Click
        gorunum_kaydet()
    End Sub
    Private Sub MenuItem25_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem25.Click
        If MenuItem25.Checked = False Then
            GridView1.OptionsView.ShowAutoFilterRow = True
            GridView1.OptionsView.ShowFilterPanelMode = DevExpress.XtraGrid.Views.Base.ShowFilterPanelMode.Default
            GridView1.OptionsCustomization.AllowFilter = True
            MenuItem25.Checked = True
        ElseIf MenuItem25.Checked = True Then
            GridView1.OptionsView.ShowAutoFilterRow = False
            GridView1.OptionsView.ShowFilterPanelMode = DevExpress.XtraGrid.Views.Base.ShowFilterPanelMode.Never
            GridView1.OptionsCustomization.AllowFilter = False
            MenuItem25.Checked = False
        End If
    End Sub
    Private Sub MenuItem10_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem10.Click
        If MenuItem10.Checked = False Then
            GridView1.OptionsView.ShowFilterPanelMode = DevExpress.XtraGrid.Views.Base.ShowFilterPanelMode.Default
            GridView1.OptionsCustomization.AllowFilter = True
            MenuItem10.Checked = True
        ElseIf MenuItem10.Checked = True Then
            GridView1.OptionsView.ShowFilterPanelMode = DevExpress.XtraGrid.Views.Base.ShowFilterPanelMode.Never
            GridView1.OptionsCustomization.AllowFilter = False
            MenuItem10.Checked = False
        End If
    End Sub
    Private Sub MenuItem11_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem11.Click
        If MenuItem11.Checked = False Then
            GridView1.OptionsView.ShowGroupPanel = True
            GridView1.OptionsCustomization.AllowGroup = True
            MenuItem11.Checked = True
        ElseIf MenuItem11.Checked = True Then
            GridView1.OptionsView.ShowGroupPanel = False
            GridView1.OptionsCustomization.AllowGroup = False
            MenuItem11.Checked = False
        End If
    End Sub
    Private Sub MenuItem17_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem17.Click
        If Me.WindowState = FormWindowState.Normal Then
            Me.WindowState = FormWindowState.Maximized
        ElseIf Me.WindowState = FormWindowState.Maximized Then
            Me.WindowState = FormWindowState.Normal
        End If
    End Sub
    Private Sub SimpleButton2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SimpleButton2.Click
        Me.DialogResult = Windows.Forms.DialogResult.OK
    End Sub
    Private Sub SimpleButton1_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles SimpleButton1.Click
        Me.DialogResult = Windows.Forms.DialogResult.OK
    End Sub
    Private Sub GridView1_CellValueChanged(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs) Handles GridView1.CellValueChanged
        If GridView1.RowCount > 0 Then
            GridView1.PostEditor()
            Dim dr As DataRow
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
            'MsgBox(GridView1.FocusedColumn.Name.ToString)
            If GridView1.FocusedColumn.Name = colnOran.Name.ToString Then
                If dr("nOran") <> 0 Then
                    dr("lTutar") = (lNetTutar * dr("nOran")) / 100
                End If
            ElseIf GridView1.FocusedColumn.Name = collTutar.Name.ToString Then
                dr("nOran") = (dr("lTutar") / lNetTutar) * 100
            End If
            If Trim(dr("sFisTipi")) = "HS" Or Trim(dr("sFisTipi")) = "FS" Then
                dr("lTutar") = -Math.Abs(dr("lTutar"))
            End If
            tbStokFisiEkMaliyet_kaydet_duzelt(dr("nKarsiID"), dr("nKarsiIslemID"), dr("lNetTutar"), dr("nStokFisiID"), dr("nIslemID"), dr("lTutar"), dr("nOran"))
            dr = Nothing
        End If
    End Sub
    Private Sub BarButtonItem4_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem4.ItemClick
        GridControl1.ShowPrintPreview()
    End Sub
    Private Sub MenuItem9_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem9.Click
        GridControl1.ShowPrintPreview()
    End Sub
    Private Sub BarButtonItem1_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem1.ItemClick
        If nKarsiIslemID = 0 Then
            satir_ekle("FA ", 1)
        Else
            satir_ekle_stok("FA ", 1)
        End If
    End Sub
    Private Sub BarButtonItem2_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem2.ItemClick
        satir_ekle_stok("FA ", 1)
    End Sub
    Private Sub BarButtonItem3_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem3.ItemClick
        satir_sil()
    End Sub
    Private Sub BarButtonItem5_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem5.ItemClick
        fis_duzelt()
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
    Private Sub degeryay(ByVal columnkriter As String, Optional ByVal bSatirDegistir As Boolean = True)
        Dim durum
        Dim sayi = GridView1.RowCount
        Dim satir = GridView1.FocusedRowHandle
        Dim TOPLAM = sayi - GridView1.FocusedRowHandle
        Dim Ý As Integer
        Ý = 0
        dr = GridView1.GetDataRow(GridView1.FocusedRowHandle)
        durum = dr("" & columnkriter & "")
        For Ý = 1 To TOPLAM
            If bSatirDegistir = True Then
                dr = GridView1.GetDataRow(GridView1.FocusedRowHandle)
                dr.BeginEdit()
                dr("" & columnkriter & "") = durum
                dr.EndEdit()
            End If
            tutar_hesapla()
            GridView1.FocusedRowHandle += 1
        Next
        GridView1.FocusedRowHandle = satir
        GridView1.GetDataRow(satir)
        durum = Nothing
        sayi = Nothing
        satir = Nothing
        Ý = Nothing
    End Sub
    Private Sub MenuItem4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem4.Click
        If GridView1.RowCount > 0 Then
            If XtraMessageBox.Show(Sorgu_sDil("Tutarý Satýrlara Eþit Oranda Daðýtmak Ýstediðinize Emin misiniz...?", sDil), Sorgu_sDil("Dikkat", sDil), MessageBoxButtons.YesNo, MessageBoxIcon.Question) = MsgBoxResult.Yes Then
                Dim dr As DataRow
                For Each dr In DataSet1.Tables(0).Rows
                    dr("nOran") = 100 / DataSet1.Tables(0).Rows.Count
                    If dr("nOran") <> 0 Then
                        dr("lTutar") = (lNetTutar * dr("nOran")) / 100
                    End If
                    tbStokFisiEkMaliyet_kaydet_duzelt(dr("nKarsiID"), dr("nKarsiIslemID"), dr("lNetTutar"), dr("nStokFisiID"), dr("nIslemID"), dr("lTutar"), dr("nOran"))
                Next
                XtraMessageBox.Show(Sorgu_sDil("Ýþlem Tamamlandý", sDil), Sorgu_sDil("Dikkat", sDil), MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        End If
    End Sub
    Private Sub MenuItem5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem5.Click
        If GridView1.RowCount > 0 Then
            If XtraMessageBox.Show(Sorgu_sDil("[" & GridView1.FocusedColumn().Caption & "] Kolonundaki verileri Aþaðý Doðru Yaymak istediðinize Emin misiniz...?", sDil), Sorgu_sDil("Dikkat", sDil), MessageBoxButtons.YesNo, MessageBoxIcon.Question) = MsgBoxResult.Yes Then
                degeryay(GridView1.FocusedColumn().FieldName)
            End If
        End If
    End Sub
    Private Sub MenuItem6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem6.Click
        If GridView1.FocusedColumn.Name = colnOran.Name.ToString Then
            Dim nOran = 100
            Dim dr1 As DataRow
            For Each dr1 In DataSet1.Tables(0).Rows
                nOran += dr1("nOran")
            Next
            Dim dr As DataRow = GridView1.GetDataRow(GridView1.FocusedRowHandle)
            dr("nOran") = dr("nOran") + nOran
            tutar_hesapla()
        ElseIf GridView1.FocusedColumn.Name = collTutar.Name.ToString Then
            Dim lTutar = lNetTutar
            Dim dr1 As DataRow
            For Each dr1 In DataSet1.Tables(0).Rows
                lTutar -= dr1("lTutar")
            Next
            Dim dr As DataRow = GridView1.GetDataRow(GridView1.FocusedRowHandle)
            dr("lTutar") = dr("lTutar") + lTutar
            tutar_hesapla()
        End If
    End Sub
End Class