Imports Microsoft.Win32
Imports DevExpress.XtraEditors
Public Class frm_stok_pesin_puan
    Public firmano
    Public donemno
    Public connection
    Public kullanici
    Public nAlisVerisID As String
    Public nMusteriID As Int64 = 0
    Public lAlisVerisTutari As Decimal
    Public lPuanTutari As Decimal
    Public lKazanilanPuan As Decimal = 0
    'Public lHarcanan As Integer = 0
    Private Sub frm_stok_pesin_puan_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        lHarcama_Kontrol()
    End Sub
    Private Sub frm_stok_pesin_puan_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            gorunum_yukle()
        Catch ex As Exception
        End Try
        dataload(nAlisVerisID, lAlisVerisTutari)
        dataload_tbHediyeCekiTipi()
        puan_kontrol()
    End Sub
    Private Sub puan_kontrol()
        Label3.Text = sorgu_AvHediyeCeki_kontrol(nMusteriID) & " Puan"
    End Sub
    Private Sub dataload_tbHediyeCekiTipi()
        sec_tbHediyeCekiTipi.DataSource = sorgu(sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT     * FROM         tbHediyeCekiTipi ")).Tables(0)
    End Sub
    Private Sub MenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem1.Click
        satir_ekle()
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
    Public Function tbAVHediyeCeki(ByVal nAlisVerisID As String, ByVal lAlisVerisTutari As Decimal) As DataSet
        Dim kriter = " WHERE nAlisVerisID = '" & nAlisVerisID & "'"
        Dim conn As New OleDb.OleDbConnection
        Dim cmd As New OleDb.OleDbCommand
        Dim adapter As New OleDb.OleDbDataAdapter
        conn.ConnectionString = connection
        cmd.CommandTimeout = False
        adapter.SelectCommand = cmd
        cmd.CommandText = sorgu_query("SET DATEFORMAT DMY SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT nAlisverisID, sAlinanBasilan, sHediyeCekiSeriNo, sHediyeCekiTipi, lTutar, dteGecerliBaslangicTarih, dteGecerliBitisTarih, lUzerindekiTutar, " & lAlisVerisTutari & " AS lAlisVerisTutari, lTutar / " & lAlisVerisTutari & "   * 100 AS nOran FROM tbAVHediyeCeki " & kriter & " ")
        cmd.Connection = conn
        conn.Open()
        Dim Datastoklar1 As New DataSet
        Dim N As Integer = adapter.Fill(Datastoklar1, "Table1")
        conn.Close()
        Return Datastoklar1
    End Function
    Private Sub tbtbAVHediyeCeki_kaydet_yeni(ByVal nAlisverisID As String, ByVal sAlinanBasilan As String, ByVal sHediyeCekiSeriNo As String, ByVal sHediyeCekiTipi As String, ByVal lTutar As Decimal, ByVal dteGecerliBaslangicTarih As DateTime, ByVal dteGecerliBitisTarih As DateTime, ByVal lUzerindekiTutar As Decimal)
        Dim cmd As New OleDb.OleDbCommand
        Dim con As New OleDb.OleDbConnection
        cmd.Connection = con
        con.ConnectionString = connection
        If con.State = ConnectionState.Closed = True Then
            con.Open()
        End If
        cmd.CommandText = sorgu_query("SET DATEFORMAT DMY SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED INSERT INTO tbAVHediyeCeki (nAlisverisID, sAlinanBasilan, sHediyeCekiSeriNo, sHediyeCekiTipi, lTutar, dteGecerliBaslangicTarih, dteGecerliBitisTarih, lUzerindekiTutar) VALUES     ('" & nAlisverisID & "', '" & sAlinanBasilan & "', '" & sHediyeCekiSeriNo & "', '" & sHediyeCekiTipi & "', " & lTutar & ", '" & dteGecerliBaslangicTarih & "', '" & dteGecerliBitisTarih & "', " & lUzerindekiTutar & ") ")
        cmd.ExecuteNonQuery()
        con.Close()
        cmd = Nothing
        con = Nothing
    End Sub
    Private Sub tbtbAVHediyeCeki_kaydet_duzelt(ByVal nAlisverisID As String, ByVal sAlinanBasilan As String, ByVal sHediyeCekiSeriNo As String, ByVal sHediyeCekiTipi As String, ByVal lTutar As Decimal, ByVal dteGecerliBaslangicTarih As DateTime, ByVal dteGecerliBitisTarih As DateTime, ByVal lUzerindekiTutar As Decimal)
        Dim cmd As New OleDb.OleDbCommand
        Dim con As New OleDb.OleDbConnection
        cmd.Connection = con
        con.ConnectionString = connection
        If con.State = ConnectionState.Closed = True Then
            con.Open()
        End If
        cmd.CommandText = sorgu_query("SET DATEFORMAT DMY SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED UPDATE    tbAVHediyeCeki SET              sAlinanBasilan = '" & sAlinanBasilan & "', sHediyeCekiSeriNo = '" & sHediyeCekiSeriNo & "', sHediyeCekiTipi = '" & sHediyeCekiTipi & "',  lTutar = " & lTutar & ", dteGecerliBaslangicTarih = '" & dteGecerliBaslangicTarih & "', dteGecerliBitisTarih = '" & dteGecerliBitisTarih & "', lUzerindekiTutar = " & lUzerindekiTutar & " Where nAlisverisID = '" & nAlisverisID & "' and sHediyeCekiTipi ='" & sHediyeCekiTipi & "' ")
        cmd.ExecuteNonQuery()
        con.Close()
        cmd = Nothing
        con = Nothing
    End Sub
    Private Sub tbtbAVHediyeCeki_kaydet_sil(ByVal nAlisverisID As String, ByVal sAlinanBasilan As String, ByVal sHediyeCekiSeriNo As String, ByVal sHediyeCekiTipi As String)
        Dim cmd As New OleDb.OleDbCommand
        Dim con As New OleDb.OleDbConnection
        cmd.Connection = con
        con.ConnectionString = connection
        If con.State = ConnectionState.Closed = True Then
            con.Open()
        End If
        cmd.CommandText = sorgu_query("SET DATEFORMAT DMY SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED DELETE FROM    tbAVHediyeCeki         Where nAlisverisID = '" & nAlisverisID & "' AND sAlinanBasilan = '" & sAlinanBasilan & "' AND sHediyeCekiSeriNo = '" & sHediyeCekiSeriNo & "' AND sHediyeCekiTipi = '" & sHediyeCekiTipi & "'")
        cmd.ExecuteNonQuery()
        con.Close()
        cmd = Nothing
        con = Nothing
    End Sub
    Public Function sorgu_AvHediyeCeki_kontrol(ByVal nMusteriID As Int64) As Decimal
        Dim kriter
        Dim lHediyeCeki As Decimal = 0
        kriter = ""
        Dim conn As New OleDb.OleDbConnection
        Dim cmd As New OleDb.OleDbCommand
        Dim adapter As New OleDb.OleDbDataAdapter
        conn.ConnectionString = connection
        cmd.Connection = conn
        conn.Open()
        cmd.CommandText = sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT ISNULL(SUM(lKazanilanPuan - lHarcananPuan), 0) AS lKalanPuan FROM (SELECT tbMusteri.nMusteriID , tbMusteri.lKodu , SUM(tbAVHediyeCeki.lTutar) AS lKazanilanPuan , 0 AS lHarcananPuan FROM tbMusteri INNER JOIN tbAlisVeris ON tbMusteri.nMusteriID = tbAlisVeris.nMusteriID INNER JOIN tbAVHediyeCeki ON tbAlisVeris.nAlisverisID = tbAVHediyeCeki.nAlisverisID WHERE (tbAVHediyeCeki.sHediyeCekiTipi = 'ParaPU_KAZ') and tbMusteri.nMusteriID = " & nMusteriID & " GROUP BY tbMusteri.nMusteriID , tbMusteri.lKodu UNION ALL SELECT tbMusteri.nMusteriID , tbMusteri.lKodu , 0 AS lKazanilanPuan , SUM(tbAVHediyeCeki.lTutar) AS lHarcananPuan FROM tbMusteri INNER JOIN tbAlisVeris ON tbMusteri.nMusteriID = tbAlisVeris.nMusteriID INNER JOIN tbAVHediyeCeki ON tbAlisVeris.nAlisverisID = tbAVHediyeCeki.nAlisverisID WHERE (tbAVHediyeCeki.sHediyeCekiTipi IN ('ParaPU_HAR','ParaPU_AL')) and tbMusteri.nMusteriID = " & nMusteriID & " GROUP BY tbMusteri.nMusteriID , tbMusteri.lKodu) tbPuan Where (nMusteriID = " & nMusteriID & ") ")
        lHediyeCeki = cmd.ExecuteScalar
        Return lHediyeCeki
    End Function
    Private Function sorgu_query(ByVal query As String) As String
        query = Replace(query, "*!F", "F0" + firmano.ToString)
        query = Replace(query, "!D", "D000" + donemno.ToString)
        Return query
    End Function
    Private Sub dataload(ByVal nAlisVerisID As String, ByVal lAlisVerisTutari As Decimal)
        DataSet1 = tbAVHediyeCeki(nAlisVerisID, lAlisVerisTutari)
        GridControl1.DataSource = DataSet1.Tables(0)
        GridControl1.DataMember = Nothing
        PanelControl3.Select()
        GridControl1.Focus()
        GridControl1.Select()
        GridView1.CollapseAllGroups()
    End Sub
    Private Sub satir_ekle(Optional ByVal sHediyeCekiTipi As String = "ParaPU_KAZ")
        Dim dr As DataRow
        dr = DataSet1.Tables(0).NewRow
        dr("nAlisVerisID") = nAlisVerisID
        dr("sAlinanBasilan") = "A"
        dr("sHediyeCekiSeriNo") = ""
        dr("sHediyeCekiTipi") = sHediyeCekiTipi
        dr("lTutar") = 0
        dr("dteGecerliBaslangicTarih") = "01/01/1900"
        dr("dteGecerliBitisTarih") = "31/12/2078"
        dr("lUzerindekiTutar") = lAlisVerisTutari
        dr("lAlisVerisTutari") = lAlisVerisTutari
        dr("nOran") = 0
        tbtbAVHediyeCeki_kaydet_yeni(dr("nAlisVerisID"), dr("sAlinanBasilan"), dr("sHediyeCekiSeriNo"), dr("sHediyeCekiTipi"), dr("lTutar"), dr("dteGecerliBaslangicTarih"), dr("dteGecerliBitisTarih"), dr("lUzerindekiTutar"))
        DataSet1.Tables(0).Rows.Add(dr)
        puan_kontrol()
        GridControl1.Focus()
        GridControl1.Select()
    End Sub
    Private Sub satir_sil()
        If GridView1.RowCount > 0 Then
            If XtraMessageBox.Show(Sorgu_sDil("Satýrý Silmek Ýstediðinize Emin misiniz...?", sDil), Sorgu_sDil("Dikkat", sDil), MessageBoxButtons.YesNo, MessageBoxIcon.Question) = MsgBoxResult.Yes Then
                Dim dr As DataRow
                dr = GridView1.GetDataRow(GridView1.FocusedRowHandle)
                tbtbAVHediyeCeki_kaydet_sil(dr("nAlisVerisID"), dr("sAlinanBasilan"), dr("sHediyeCekiSeriNo"), dr("sHediyeCekiTipi"))
                'GridView1.DeleteRow(GridView1.FocusedRowHandle)
                Dim satir = GridView1.FocusedRowHandle
                dataload(nAlisVerisID, lAlisVerisTutari)
                If GridView1.RowCount > 0 Then
                    GridView1.ClearSelection()
                    GridView1.SelectRow(satir)
                    PanelControl3.Focus()
                    GridControl1.Focus()
                End If
                satir = Nothing
                puan_kontrol()
            End If
        End If
    End Sub
    Private Sub lHarcama_Kontrol()
        Dim dr As DataRow
        lPuanTutari = 0
        lKazanilanPuan = 0
        For Each dr In DataSet1.Tables(0).Rows
            If Trim(dr("sHediyeCekiTipi")) = "ParaPU_HAR" Then
                lPuanTutari += dr("lTutar")
            ElseIf Trim(dr("sHediyeCekiTipi")) = "ParaPU_KAZ" Then
                lKazanilanPuan += dr("lTutar")
            End If
        Next
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
                    dr("lTutar") = (lAlisVerisTutari * dr("nOran")) / 100
                End If
            ElseIf GridView1.FocusedColumn.Name = collTutar.Name.ToString Then
                dr("nOran") = (dr("lTutar") / lAlisVerisTutari) * 100
            End If
            dr("lUzerindekiTutar") = dr("lTutar")
            tbtbAVHediyeCeki_kaydet_duzelt(dr("nAlisVerisID"), dr("sAlinanBasilan"), dr("sHediyeCekiSeriNo"), dr("sHediyeCekiTipi"), dr("lTutar"), dr("dteGecerliBaslangicTarih"), dr("dteGecerliBitisTarih"), dr("lUzerindekiTutar"))
            dr = Nothing
            puan_kontrol()
        End If
    End Sub
    Private Sub BarButtonItem4_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem4.ItemClick
        GridControl1.ShowPrintPreview()
    End Sub
    Private Sub MenuItem9_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem9.Click
        GridControl1.ShowPrintPreview()
    End Sub
    Private Sub BarButtonItem1_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem1.ItemClick
        satir_ekle()
    End Sub
    Private Sub BarButtonItem2_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem2.ItemClick
        satir_ekle("ParaPU_HAR")
    End Sub
    Private Sub BarButtonItem3_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem3.ItemClick
        satir_sil()
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
    Private Sub MenuItem4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem4.Click
        satir_ekle("ParaPU_HAR")
    End Sub
End Class