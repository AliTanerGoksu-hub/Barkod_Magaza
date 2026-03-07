Imports DevExpress.XtraEditors
Public Class frm_tbParamStok
    Public firmano As Integer = 100
    Public donemno As Integer = 1
    Public connection
    Public kullanici
    Public islem As String = ""
    Dim conn As New OleDb.OleDbConnection
    Dim con As New OleDb.OleDbConnection
    Dim cmd As New OleDb.OleDbCommand
    Dim adapter As New OleDb.OleDbDataAdapter
    Dim DS As New DataSet
    Dim satir
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
    Private Sub gorunum_yazdir()
        printlink1.CreateDocument(ps)
        ps.PreviewRibbonFormEx.Show()
    End Sub
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
    Public Sub Dataload_tbParamStok()
        Try
            ds_tbParamStok.Tables(0).Clear()
        Catch ex As Exception
        End Try
        Dim conn As New OleDb.OleDbConnection
        Dim cmd As New OleDb.OleDbCommand
        Dim adapter As New OleDb.OleDbDataAdapter
        conn.ConnectionString = connection
        adapter.SelectCommand = cmd
        cmd.CommandText = sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT * From tbParamStok ")
        cmd.Connection = conn
        Dim N As Integer = adapter.Fill(ds_tbParamStok, "Table1")
        conn.Close()
        GridControl1.Focus()
        GridControl1.Select()
    End Sub
    Private Sub dataload_tbIl()
        sec_sIl.DataSource = sorgu(sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT sIl FROM tbIl order by sIl"))
    End Sub
    Private Sub tbParamStok_kaydet_duzelt(ByVal nStokUzunlugu As Integer, ByVal nAnaKodUzunlugu As Integer, ByVal nGrupUzunlugu As Integer, ByVal nDetayUzunlugu As Integer, ByVal bRenkVarmi As Integer, ByVal bBedenVarmi As Integer, ByVal bKavalaVarmi As Integer, ByVal bDepoVarmi As Integer, ByVal bEanVarmi As Integer, ByVal bOtomatikEanVarmi As Integer, ByVal nEanSabiti As Integer, ByVal nEanSonSiraNo As Integer, ByVal bAlisSiparisEntegre As Integer, ByVal bAlisReceteEntegre As Integer, ByVal sAlisFiyatYontemi As String, ByVal sAlisFirmaSinifTipi As String, ByVal sAlisFiyatTipi As String, ByVal sAlisFormu1 As String, ByVal bSatisSiparisEntegre As Integer, ByVal bSatisReceteEntegre As Integer, ByVal sSatisFiyatYontemi As String, ByVal sSatisFirmaSinifTipi As String, ByVal sSatisFiyatTipi As String, ByVal sSatisFormu1 As String, ByVal sSatisFormu2 As String, ByVal bFTTG As Integer, ByVal sTransferFormu1 As String, ByVal sTransferFormu2 As String, ByVal dteBaslangicTarih As DateTime, ByVal dteBitisTarih As DateTime, ByVal sResimDosyalariPath As String, ByVal sSinifTipi01 As String, ByVal sSinifTipi02 As String, ByVal sSinifTipi03 As String, ByVal sSinifTipi04 As String, ByVal sSinifTipi05 As String, ByVal sSinifTipi06 As String, ByVal sSinifTipi07 As String, ByVal sSinifTipi08 As String, ByVal sSinifTipi09 As String, ByVal sSinifTipi10 As String, ByVal sSinifTipi11 As String, ByVal sSinifTipi12 As String, ByVal sSinifTipi13 As String, ByVal sSinifTipi14 As String, ByVal sSinifTipi15 As String, ByVal bEksiyeDusulebilirmi As Integer, ByVal nIskontoSinifNo As Integer, ByVal sAciklamaBaslik1 As String, ByVal sAciklamaBaslik2 As String, ByVal sAciklamaBaslik3 As String, ByVal sAciklamaBaslik4 As String, ByVal sAciklamaBaslik5 As String, ByVal sAciklamaBaslik6 As String, ByVal sAciklamaBaslik7 As String, ByVal sAciklamaBaslik8 As String, ByVal sAciklamaBaslik9 As String, ByVal sAciklamaBaslik10 As String, ByVal bFiyatSifirGirilsin As Integer, ByVal bAlisPartiNoVar As Integer, ByVal bSatisPartiNoVar As Integer, ByVal bOTVVar As Integer, ByVal bIkinciMiktarVar As Integer, ByVal sDefaultKdvTipi As String, ByVal sDefaultBirimCinsi As String, ByVal sDefaultOtvTipi As String, ByVal sDefaultHareketTipi As String, ByVal bDovizliGirisVar As Integer, ByVal bEkSoru1 As Integer, ByVal bEkSoru2 As Integer, ByVal nParametre1 As Integer, ByVal nParametre2 As Integer)
        Dim cmd As New OleDb.OleDbCommand
        Dim con As New OleDb.OleDbConnection
        cmd.Connection = con
        con.ConnectionString = connection
        If con.State = ConnectionState.Closed = True Then
            con.Open()
        End If
        cmd.CommandText = sorgu_query("SET DATEFORMAT DMY SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED UPDATE tbParamStok SET nStokUzunlugu = " & nStokUzunlugu & ", nAnaKodUzunlugu = " & nAnaKodUzunlugu & ", nGrupUzunlugu = " & nGrupUzunlugu & ", nDetayUzunlugu = " & nDetayUzunlugu & ", bRenkVarmi = " & bRenkVarmi & ", bBedenVarmi = " & bBedenVarmi & ", bKavalaVarmi = " & bKavalaVarmi & ", bDepoVarmi = " & bDepoVarmi & ", bEanVarmi = " & bEanVarmi & ", bOtomatikEanVarmi = " & bOtomatikEanVarmi & ", nEanSabiti = " & nEanSabiti & ", nEanSonSiraNo = " & nEanSonSiraNo & ", bAlisSiparisEntegre = " & bAlisSiparisEntegre & ", bAlisReceteEntegre = " & bAlisReceteEntegre & ", sAlisFiyatYontemi = '" & sAlisFiyatYontemi & "', sAlisFirmaSinifTipi = '" & sAlisFirmaSinifTipi & "', sAlisFiyatTipi = '" & sAlisFiyatTipi & "', sAlisFormu1 = '" & sAlisFormu1 & "', bSatisSiparisEntegre = " & bSatisSiparisEntegre & ", bSatisReceteEntegre = " & bSatisReceteEntegre & ", sSatisFiyatYontemi = '" & sSatisFiyatYontemi & "', sSatisFirmaSinifTipi = '" & sSatisFirmaSinifTipi & "', sSatisFiyatTipi = '" & sSatisFiyatTipi & "', sSatisFormu1 = '" & sSatisFormu1 & "',sSatisFormu2 = '" & sSatisFormu2 & "', bFTTG = " & bFTTG & ", sTransferFormu1 = '" & sTransferFormu1 & "', sTransferFormu2 = '" & sTransferFormu2 & "', dteBaslangicTarih = '" & dteBaslangicTarih & "', dteBitisTarih = '" & dteBitisTarih & "', sResimDosyalariPath = '" & sResimDosyalariPath & "', sSinifTipi01 = '" & sSinifTipi01 & "', sSinifTipi02 = '" & sSinifTipi02 & "', sSinifTipi03 = '" & sSinifTipi03 & "', sSinifTipi04 = '" & sSinifTipi04 & "', sSinifTipi05 = '" & sSinifTipi05 & "', sSinifTipi06 = '" & sSinifTipi06 & "', sSinifTipi07 = '" & sSinifTipi07 & "', sSinifTipi08 = '" & sSinifTipi08 & "', sSinifTipi09 = '" & sSinifTipi09 & "', sSinifTipi10 = '" & sSinifTipi10 & "', sSinifTipi11 = '" & sSinifTipi11 & "', sSinifTipi12 = '" & sSinifTipi12 & "', sSinifTipi13 = '" & sSinifTipi13 & "',  sSinifTipi14 = '" & sSinifTipi14 & "', sSinifTipi15 = '" & sSinifTipi15 & "', bEksiyeDusulebilirmi = " & bEksiyeDusulebilirmi & ", nIskontoSinifNo = " & nIskontoSinifNo & ", sAciklamaBaslik1 = '" & sAciklamaBaslik1 & "', sAciklamaBaslik2 = '" & sAciklamaBaslik2 & "', sAciklamaBaslik3 = '" & sAciklamaBaslik3 & "', sAciklamaBaslik4 = '" & sAciklamaBaslik4 & "', sAciklamaBaslik5 = '" & sAciklamaBaslik5 & "', sAciklamaBaslik6 = '" & sAciklamaBaslik6 & "', sAciklamaBaslik7 = '" & sAciklamaBaslik7 & "', sAciklamaBaslik8 = '" & sAciklamaBaslik8 & "', sAciklamaBaslik9 = '" & sAciklamaBaslik9 & "', sAciklamaBaslik10 = '" & sAciklamaBaslik10 & "', bFiyatSifirGirilsin = " & bFiyatSifirGirilsin & ", bAlisPartiNoVar = " & bAlisPartiNoVar & ", bSatisPartiNoVar = " & bSatisPartiNoVar & ", bOTVVar = " & bOTVVar & ", bIkinciMiktarVar = " & bIkinciMiktarVar & ", sDefaultKdvTipi = '" & sDefaultKdvTipi & "', sDefaultBirimCinsi = '" & sDefaultBirimCinsi & "', sDefaultOtvTipi = '" & sDefaultOtvTipi & "', sDefaultHareketTipi = '" & sDefaultHareketTipi & "', bDovizliGirisVar = " & bDovizliGirisVar & ", bEkSoru1 = " & bEkSoru1 & ", bEkSoru2 = " & bEkSoru2 & ", nParametre1 = " & nParametre1 & ", nParametre2 = " & nParametre2 & " ")
        cmd.ExecuteNonQuery()
        con.Close()
    End Sub
    Public Function sorgu_sKdvTipi_kontrol(ByVal sKdvTipi As String) As Boolean
        Dim kriter
        Dim pass As Boolean
        kriter = ""
        Dim conn As New OleDb.OleDbConnection
        Dim cmd As New OleDb.OleDbCommand
        Dim adapter As New OleDb.OleDbDataAdapter
        conn.ConnectionString = connection
        cmd.Connection = conn
        conn.Open()
        cmd.CommandText = sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT ISNULL(COUNT(sKdvTipi), 0) AS nKayit FROM tbKdv WHERE     (sKdvTipi = '" & sKdvTipi & "') and sKdvTipi <>'' ")
        Dim kayitsayisi = cmd.ExecuteScalar
        If kayitsayisi = 0 Then
            pass = True
        Else
            pass = False
        End If
        Return pass
    End Function
    Private Sub tutar_hesapla()
        Dim dr As DataRow
        dr = GridView1.GetDataRow(GridView1.FocusedRowHandle)
        tbParamStok_kaydet_duzelt(dr("nStokUzunlugu"), dr("nAnaKodUzunlugu"), dr("nGrupUzunlugu"), dr("nDetayUzunlugu"), dr("bRenkVarmi"), dr("bBedenVarmi"), dr("bKavalaVarmi"), dr("bDepoVarmi"), dr("bEanVarmi"), dr("bOtomatikEanVarmi"), dr("nEanSabiti"), dr("nEanSonSiraNo"), dr("bAlisSiparisEntegre"), dr("bAlisReceteEntegre"), dr("sAlisFiyatYontemi"), dr("sAlisFirmaSinifTipi"), dr("sAlisFiyatTipi"), dr("sAlisFormu1"), dr("bSatisSiparisEntegre"), dr("bSatisReceteEntegre"), dr("sSatisFiyatYontemi"), dr("sSatisFirmaSinifTipi"), dr("sSatisFiyatTipi"), dr("sSatisFormu1"), dr("sSatisFormu2"), dr("bFTTG"), dr("sTransferFormu1"), dr("sTransferFormu2"), dr("dteBaslangicTarih"), dr("dteBitisTarih"), dr("sResimDosyalariPath"), dr("sSinifTipi01"), dr("sSinifTipi02"), dr("sSinifTipi03"), dr("sSinifTipi04"), dr("sSinifTipi05"), dr("sSinifTipi06"), dr("sSinifTipi07"), dr("sSinifTipi08"), dr("sSinifTipi09"), dr("sSinifTipi10"), dr("sSinifTipi11"), dr("sSinifTipi12"), dr("sSinifTipi13"), dr("sSinifTipi14"), dr("sSinifTipi15"), dr("bEksiyeDusulebilirmi"), dr("nIskontoSinifNo"), dr("sAciklamaBaslik1"), dr("sAciklamaBaslik2"), dr("sAciklamaBaslik3"), dr("sAciklamaBaslik4"), dr("sAciklamaBaslik5"), dr("sAciklamaBaslik6"), dr("sAciklamaBaslik7"), dr("sAciklamaBaslik8"), dr("sAciklamaBaslik9"), dr("sAciklamaBaslik10"), dr("bFiyatSifirGirilsin"), dr("bAlisPartiNoVar"), dr("bSatisPartiNoVar"), dr("bOTVVar"), dr("bIkinciMiktarVar"), dr("sDefaultKdvTipi"), dr("sDefaultBirimCinsi"), dr("sDefaultOtvTipi"), dr("sDefaultHareketTipi"), dr("bDovizliGirisVar"), dr("bEkSoru1"), dr("bEkSoru2"), dr("nParametre1"), dr("nParametre2"))
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
    Private Sub MenuItem4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem4.Click
        GridView1.ColumnsCustomization()
    End Sub
    Private Sub GörünümüKaydetToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GörünümüKaydetToolStripMenuItem.Click
        gorunum_kaydet()
    End Sub
    Private Sub MenuItem5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem5.Click
        gorunum_yazdir()
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
    Private Sub GridView1_CellValueChanged(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs) Handles GridView1.CellValueChanged
        tutar_hesapla()
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
        Dataload_tbParamStok()
        Try
            gorunum_yukle()
        Catch ex As Exception
        End Try
        dataload_tbIl()
        GridControl1.Focus()
        GridControl1.Select()
        GridView1.BestFitColumns()
    End Sub
    Private Sub GridControl1_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles GridControl1.KeyDown
        If e.KeyCode = Keys.Escape Then
            If XtraMessageBox.Show(Sorgu_sDil("Editör Ekranýný Kapatmak Ýstediðinize Emin misiniz...?", sDil), Sorgu_sDil("Dikkat", sDil), MessageBoxButtons.YesNo, MessageBoxIcon.Question) = MsgBoxResult.Yes Then
                Me.Close()
            End If
        End If
    End Sub
    Private Sub BarButtonItem5_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem5.ItemClick
        raporla_excel()
    End Sub
    Private Sub BarButtonItem6_ItemClick(ByVal sender As Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem6.ItemClick
        raporla_pdf()
    End Sub
    Private Sub BarButtonItem7_ItemClick(ByVal sender As Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem7.ItemClick
        raporla_text()
    End Sub
    Private Sub BarButtonItem4_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem4.ItemClick
        gorunum_yazdir()
    End Sub
End Class