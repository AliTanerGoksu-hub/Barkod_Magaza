Imports DevExpress.XtraEditors
Imports System.Collections.Generic
Public Class frm_tbParamMusteri
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
    Private dtZorunlu As DataTable
    Private Function GetGercekZorunlumuAlanlar() As List(Of String)
        Return New List(Of String) From {
            "bAdiZorunlumu", "bSoyadiZorunlumu", "bCinsiyetZorunlumu", "bDogumTarihiZorunlumu", "bDogumYeriZorunlumu",
            "bEvlimiZorunlumu", "bEvlilikTarihiZorunlumu", "bVergiDairesiZorunlumu", "bVergiNoZorunlumu", "bEmailZorunlumu",
            "bEvAdres1Zorunlumu", "bEvSemtZorunlumu", "bEvIlZorunlumu", "bEvTelefonZorunlumu", "bIsAdresi1Zorunlumu",
            "bIsSemtZorunlumu", "bIsIlZorunlumu", "bIsTelefonZorunlumu", "bGSMZorunlumu", "bTCZorunlumu"
        }
    End Function
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
    Private Sub gorunum_yazdir()
        printlink1.CreateDocument(ps)
        ps.PreviewRibbonFormEx.Show()
    End Sub
    Private Sub gorunum_kaydet()
        GridView1.SaveLayoutToRegistry("SOFTWARE\BusinessSmart\VIEW\MAGAZA\" & Me.Name.ToString & "")
        XtraMessageBox.Show(Sorgu_sDil("Görünüm Kaydedildi", sDil), Sorgu_sDil("Dikkat", sDil), MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub
    Private Sub gorunum_yukle()
        ' ÖNCE görünüm restore edilir
        GridView1.RestoreLayoutFromRegistry("SOFTWARE\BusinessSmart\VIEW\MAGAZA\" & Me.Name.ToString & "")

        ' SONRA data ve kolonlar eklenir
        Dataload_tbParamMusteri()
        KolonlariEkle_Zorunlular()

        ' Diğer çeviriler
        For Each btn As DevExpress.XtraBars.BarItem In BarManager1.Items
            btn.Caption = Sorgu_sDil(btn.Caption, sDil)
        Next
        For Each clmn As DevExpress.XtraGrid.Columns.GridColumn In GridView1.Columns
            clmn.Caption = Sorgu_sDil(clmn.Caption, sDil)
        Next
        SimpleButton1.Text = Sorgu_sDil(SimpleButton1.Text, sDil)
        SimpleButton2.Text = Sorgu_sDil(SimpleButton2.Text, sDil)

        GridView1.OptionsBehavior.ImmediateUpdateRowPosition = True
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
    Public Sub Dataload_tbParamMusteri()
        Try
            ds_tbParamMusteri.Tables(0).Clear()
        Catch ex As Exception
        End Try

        Dim zorunluAlanlar = GetGercekZorunlumuAlanlar()

        Dim sabitAlanlar As New List(Of String) From {
        "bMusteriNoyuSistemVersin", "lMusteriNo", "sResimDosyalariPath",
        "sSinifTipi01", "sSinifTipi02", "sSinifTipi03", "sSinifTipi04", "sSinifTipi05",
        "sSinifTipi06", "sSinifTipi07", "sSinifTipi08", "sSinifTipi09", "sSinifTipi10",
        "sSinifTipi11", "sSinifTipi12", "sSinifTipi13", "sSinifTipi14", "sSinifTipi15",
        "bDefaultKrdLimVar", "lDefaultKrediLimiti", "lDefaultKrediLimitiSonGun",
        "bEkSoru1", "bEkSoru2", "nParametre1", "nParametre2"
    }

        Dim secilecekAlanlar As New List(Of String)(sabitAlanlar)
        secilecekAlanlar.AddRange(zorunluAlanlar)

        Dim sql As String = "
        SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED
        SELECT " & String.Join(", ", secilecekAlanlar) & " FROM tbParamMusteri
    "

        Dim conn As New OleDb.OleDbConnection(connection)
        Dim cmd As New OleDb.OleDbCommand(sorgu_query(sql), conn)
        Dim adapter As New OleDb.OleDbDataAdapter(cmd)

        Dim N As Integer = adapter.Fill(ds_tbParamMusteri, "Table1")
        conn.Close()

        GridControl1.Focus()
        GridControl1.Select()
    End Sub


    Private Sub dataload_tbIl()
        sec_sIl.DataSource = sorgu(sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT     sIl FROM         tbIl order by sIl"))
    End Sub
    Private Sub tbParamMusteri_kaydet_duzelt(
     ByVal bMusteriNoyuSistemVersin As Integer,
     ByVal lMusteriNo As Int64,
     ByVal sResimDosyalariPath As String,
     ByVal sSinifTipi01 As String, ByVal sSinifTipi02 As String, ByVal sSinifTipi03 As String, ByVal sSinifTipi04 As String, ByVal sSinifTipi05 As String,
     ByVal sSinifTipi06 As String, ByVal sSinifTipi07 As String, ByVal sSinifTipi08 As String, ByVal sSinifTipi09 As String, ByVal sSinifTipi10 As String,
     ByVal sSinifTipi11 As String, ByVal sSinifTipi12 As String, ByVal sSinifTipi13 As String, ByVal sSinifTipi14 As String, ByVal sSinifTipi15 As String,
     ByVal bDefaultKrdLimVar As Integer, ByVal lDefaultKrediLimiti As Decimal, ByVal lDefaultKrediLimitiSonGun As Integer,
     ByVal bEkSoru1 As Integer, ByVal bEkSoru2 As Integer, ByVal nParametre1 As Integer, ByVal nParametre2 As Integer,
     ByVal bAdiZorunlumu As Integer, ByVal bSoyadiZorunlumu As Integer, ByVal bCinsiyetZorunlumu As Integer,
     ByVal bDogumTarihiZorunlumu As Integer, ByVal bDogumYeriZorunlumu As Integer, ByVal bEvlimiZorunlumu As Integer,
     ByVal bEvlilikTarihiZorunlumu As Integer, ByVal bVergiDairesiZorunlumu As Integer, ByVal bVergiNoZorunlumu As Integer,
     ByVal bEmailZorunlumu As Integer, ByVal bEvAdres1Zorunlumu As Integer, ByVal bEvSemtZorunlumu As Integer,
     ByVal bEvIlZorunlumu As Integer, ByVal bEvTelefonZorunlumu As Integer, ByVal bIsAdresi1Zorunlumu As Integer,
     ByVal bIsSemtZorunlumu As Integer, ByVal bIsIlZorunlumu As Integer, ByVal bIsTelefonZorunlumu As Integer,
     ByVal bGSMZorunlumu As Integer, ByVal bTCZorunlumu As Integer
 )


        Dim sql As String = ""
        sql &= "UPDATE tbParamMusteri SET " & vbCrLf &
       "bMusteriNoyuSistemVersin = " & bMusteriNoyuSistemVersin & "," & vbCrLf &
       "lMusteriNo = " & lMusteriNo & "," & vbCrLf &
       "sResimDosyalariPath = '" & sResimDosyalariPath & "'," & vbCrLf &
       "sSinifTipi01 = '" & sSinifTipi01 & "'," & vbCrLf &
       "sSinifTipi02 = '" & sSinifTipi02 & "'," & vbCrLf &
       "sSinifTipi03 = '" & sSinifTipi03 & "'," & vbCrLf &
       "sSinifTipi04 = '" & sSinifTipi04 & "'," & vbCrLf &
       "sSinifTipi05 = '" & sSinifTipi05 & "'," & vbCrLf &
       "sSinifTipi06 = '" & sSinifTipi06 & "'," & vbCrLf &
       "sSinifTipi07 = '" & sSinifTipi07 & "'," & vbCrLf &
       "sSinifTipi08 = '" & sSinifTipi08 & "'," & vbCrLf &
       "sSinifTipi09 = '" & sSinifTipi09 & "'," & vbCrLf &
       "sSinifTipi10 = '" & sSinifTipi10 & "'," & vbCrLf &
       "sSinifTipi11 = '" & sSinifTipi11 & "'," & vbCrLf &
       "sSinifTipi12 = '" & sSinifTipi12 & "'," & vbCrLf &
       "sSinifTipi13 = '" & sSinifTipi13 & "'," & vbCrLf &
       "sSinifTipi14 = '" & sSinifTipi14 & "'," & vbCrLf &
       "sSinifTipi15 = '" & sSinifTipi15 & "'," & vbCrLf &
       "bDefaultKrdLimVar = " & bDefaultKrdLimVar & "," & vbCrLf &
       "lDefaultKrediLimiti = " & lDefaultKrediLimiti & "," & vbCrLf &
       "lDefaultKrediLimitiSonGun = " & lDefaultKrediLimitiSonGun & "," & vbCrLf &
       "bEkSoru1 = " & bEkSoru1 & "," & vbCrLf &
       "bEkSoru2 = " & bEkSoru2 & "," & vbCrLf &
       "nParametre1 = " & nParametre1 & "," & vbCrLf &
       "nParametre2 = " & nParametre2 & "," & vbCrLf &
       "bAdiZorunlumu = " & bAdiZorunlumu & "," & vbCrLf &
       "bSoyadiZorunlumu = " & bSoyadiZorunlumu & "," & vbCrLf &
       "bDogumTarihiZorunlumu = " & bDogumTarihiZorunlumu & "," & vbCrLf &
       "bDogumYeriZorunlumu = " & bDogumYeriZorunlumu & "," & vbCrLf &
       "bEvlimiZorunlumu = " & bEvlimiZorunlumu & "," & vbCrLf &
       "bEvlilikTarihiZorunlumu = " & bEvlilikTarihiZorunlumu & "," & vbCrLf &
       "bVergiDairesiZorunlumu = " & bVergiDairesiZorunlumu & "," & vbCrLf &
       "bVergiNoZorunlumu = " & bVergiNoZorunlumu & "," & vbCrLf &
       "bEmailZorunlumu = " & bEmailZorunlumu & "," & vbCrLf &
       "bEvAdres1Zorunlumu = " & bEvAdres1Zorunlumu & "," & vbCrLf &
       "bEvSemtZorunlumu = " & bEvSemtZorunlumu & "," & vbCrLf &
       "bEvIlZorunlumu = " & bEvIlZorunlumu & "," & vbCrLf &
       "bEvTelefonZorunlumu = " & bEvTelefonZorunlumu & "," & vbCrLf &
       "bIsAdresi1Zorunlumu = " & bIsAdresi1Zorunlumu & "," & vbCrLf &
       "bIsSemtZorunlumu = " & bIsSemtZorunlumu & "," & vbCrLf &
       "bIsIlZorunlumu = " & bIsIlZorunlumu & "," & vbCrLf &
       "bIsTelefonZorunlumu = " & bIsTelefonZorunlumu & "," & vbCrLf &
       "bGSMZorunlumu = " & bGSMZorunlumu & "," & vbCrLf &
       "bTCZorunlumu = " & bTCZorunlumu

        Dim cmd As New OleDb.OleDbCommand(sql, New OleDb.OleDbConnection(connection))
        cmd.Connection.Open()
        cmd.ExecuteNonQuery()
        cmd.Connection.Close()
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
        cmd.CommandText = sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT     ISNULL(COUNT(sKdvTipi), 0) AS nKayit FROM         tbKdv WHERE     (sKdvTipi = '" & sKdvTipi & "') and sKdvTipi <>'' ")
        Dim kayitsayisi = cmd.ExecuteScalar
        If kayitsayisi = 0 Then
            pass = True
        Else
            pass = False
        End If
        Return pass
    End Function
    Private Function Safe(dr As DataRow, columnName As String, Optional defaultValue As Object = Nothing) As Object
        If dr.Table.Columns.Contains(columnName) AndAlso Not IsDBNull(dr(columnName)) Then
            Return dr(columnName)
        Else
            Return defaultValue
        End If
    End Function
    Private Sub tutar_hesapla()
        Dim dr As DataRow
        dr = GridView1.GetDataRow(GridView1.FocusedRowHandle)
        tbParamMusteri_kaydet_duzelt(
     Safe(dr, "bMusteriNoyuSistemVersin", False), Safe(dr, "lMusteriNo", 0), Safe(dr, "sResimDosyalariPath", ""),
     Safe(dr, "sSinifTipi01", ""), Safe(dr, "sSinifTipi02", ""), Safe(dr, "sSinifTipi03", ""), Safe(dr, "sSinifTipi04", ""), Safe(dr, "sSinifTipi05", ""),
     Safe(dr, "sSinifTipi06", ""), Safe(dr, "sSinifTipi07", ""), Safe(dr, "sSinifTipi08", ""), Safe(dr, "sSinifTipi09", ""), Safe(dr, "sSinifTipi10", ""),
     Safe(dr, "sSinifTipi11", ""), Safe(dr, "sSinifTipi12", ""), Safe(dr, "sSinifTipi13", ""), Safe(dr, "sSinifTipi14", ""), Safe(dr, "sSinifTipi15", ""),
     Safe(dr, "bDefaultKrdLimVar", False), Safe(dr, "lDefaultKrediLimiti", 0), Safe(dr, "lDefaultKrediLimitiSonGun", 0),
     Safe(dr, "bEkSoru1", False), Safe(dr, "bEkSoru2", False), Safe(dr, "nParametre1", 0), Safe(dr, "nParametre2", 0),
     Safe(dr, "bAdiZorunlumu", False), Safe(dr, "bSoyadiZorunlumu", False), Safe(dr, "bCinsiyetZorunlumu", False),
     Safe(dr, "bDogumTarihiZorunlumu", False), Safe(dr, "bDogumYeriZorunlumu", False), Safe(dr, "bEvlimiZorunlumu", False),
     Safe(dr, "bEvlilikTarihiZorunlumu", False), Safe(dr, "bVergiDairesiZorunlumu", False), Safe(dr, "bVergiNoZorunlumu", False),
     Safe(dr, "bEmailZorunlumu", False), Safe(dr, "bEvAdres1Zorunlumu", False), Safe(dr, "bEvSemtZorunlumu", False),
     Safe(dr, "bEvIlZorunlumu", False), Safe(dr, "bEvTelefonZorunlumu", False), Safe(dr, "bIsAdresi1Zorunlumu", False),
     Safe(dr, "bIsSemtZorunlumu", False), Safe(dr, "bIsIlZorunlumu", False), Safe(dr, "bIsTelefonZorunlumu", False),
     Safe(dr, "bGSMZorunlumu", False), Safe(dr, "bTCZorunlumu", False)
 )
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
    Private Sub MenuItem4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem4.Click
        GridView1.ColumnsCustomization()
    End Sub
    Private Sub GörünümüKaydetToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GörünümüKaydetToolStripMenuItem.Click
        gorunum_kaydet()
    End Sub
    Private Sub MenuItem5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem5.Click
        gorunum_yazdir()
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
    Private Sub SimpleButton2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SimpleButton2.Click
        tbParamMusteri_kaydet_zorunlular()
        Me.Close()
    End Sub
    Private Sub SimpleButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SimpleButton1.Click
        GridView1.CloseEditor()
        GridView1.UpdateCurrentRow()
        tbParamMusteri_kaydet_zorunlular()
        Me.Close()
    End Sub
    Private Sub GridView1_CellValueChanged(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs) Handles GridView1.CellValueChanged
        GridView1.CloseEditor()
        GridView1.UpdateCurrentRow()
        tbParamMusteri_kaydet_zorunlular()
    End Sub
    Private Sub GridView1_ValidatingEditor(sender As Object, e As DevExpress.XtraEditors.Controls.BaseContainerValidateEditorEventArgs) Handles GridView1.ValidatingEditor
        If GridView1.FocusedColumn.ColumnEdit IsNot Nothing AndAlso TypeOf GridView1.FocusedColumn.ColumnEdit Is DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit Then
            GridView1.SetFocusedValue(e.Value)
        End If
    End Sub
    Private Sub GridView1_CustomDrawRowIndicator(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Grid.RowIndicatorCustomDrawEventArgs) Handles GridView1.CustomDrawRowIndicator
        If e.RowHandle >= 0 Then
            e.Info.DisplayText = e.RowHandle + 1
        Else
            e.Info.DisplayText = ""
        End If
    End Sub
    Private Sub GridView1_FocusedRowChanged(sender As Object, e As DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs) Handles GridView1.FocusedRowChanged
        Dim rowIndex As Integer = If(e.FocusedRowHandle >= 0, e.FocusedRowHandle + 1, 0)

        If GridView1.SelectedRowsCount > 1 Then
            Label2.Text = Sorgu_sDil("Kayıt Sayısı :", sDil) & GridView1.RowCount &
                      " / " & Sorgu_sDil("Satır :", sDil) & rowIndex &
                      " / " & Sorgu_sDil("Seçili :", sDil) & GridView1.SelectedRowsCount
        ElseIf GridView1.SelectedRowsCount = 1 Then
            Label2.Text = Sorgu_sDil("Kayıt Sayısı :", sDil) & GridView1.RowCount &
                      " / " & Sorgu_sDil("Satır :", sDil) & rowIndex
        Else
            Label2.Text = ""
        End If
    End Sub
    Private Sub frm_tbSinif_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
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
            If XtraMessageBox.Show(Sorgu_sDil("Editör Ekranını Kapatmak İstediğinize Emin misiniz...?", sDil), Sorgu_sDil("Dikkat", sDil), MessageBoxButtons.YesNo, MessageBoxIcon.Question) = MsgBoxResult.Yes Then
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
    Private Sub KolonlariEkle_Zorunlular()
        Dim zorunluAlanlar = GetGercekZorunlumuAlanlar()
        Dim captionMap As New Dictionary(Of String, String) From {
        {"bAdiZorunlumu", "Adı"},
        {"bSoyadiZorunlumu", "Soyadı"},
        {"bCinsiyetZorunlumu", "Cinsiyet"},
        {"bDogumTarihiZorunlumu", "Doğum Tarihi"},
        {"bDogumYeriZorunlumu", "Doğum Yeri"},
        {"bEvlimiZorunlumu", "Evli mi?"},
        {"bEvlilikTarihiZorunlumu", "Evlilik Tarihi"},
        {"bVergiDairesiZorunlumu", "Vergi Dairesi"},
        {"bVergiNoZorunlumu", "Vergi No"},
        {"bEmailZorunlumu", "E-Mail"},
        {"bEvAdres1Zorunlumu", "Ev Adresi"},
        {"bEvSemtZorunlumu", "Ev Semti"},
        {"bEvIlZorunlumu", "Ev İl"},
        {"bEvTelefonZorunlumu", "Ev Telefonu"},
        {"bIsAdresi1Zorunlumu", "İş Adresi"},
        {"bIsSemtZorunlumu", "İş Semti"},
        {"bIsIlZorunlumu", "İş İl"},
        {"bIsTelefonZorunlumu", "İş Telefonu"},
        {"bGSMZorunlumu", "GSM"},
        {"bTCZorunlumu", "T.C. Kimlik No"}
    }

        For Each fieldName As String In zorunluAlanlar
            Dim captionText As String = If(captionMap.ContainsKey(fieldName), captionMap(fieldName), fieldName)

            If GridView1.Columns.ColumnByFieldName(fieldName) Is Nothing Then
                Dim column As New DevExpress.XtraGrid.Columns.GridColumn()
                column.FieldName = fieldName
                column.Caption = captionText
                column.Visible = True
                column.VisibleIndex = GridView1.Columns.Count

                ' 🟢 Düzenlemeyi aç
                column.OptionsColumn.AllowEdit = True
                column.OptionsColumn.ReadOnly = False

                ' 🟢 CheckEdit ayarları
                Dim chkEdit As New DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit()
                chkEdit.ValueChecked = True
                chkEdit.ValueUnchecked = False
                chkEdit.NullStyle = DevExpress.XtraEditors.Controls.StyleIndeterminate.Unchecked
                GridControl1.RepositoryItems.Add(chkEdit)
                column.ColumnEdit = chkEdit

                AddHandler chkEdit.EditValueChanged, AddressOf CheckEdit_EditValueChanged
                AddHandler chkEdit.Click, AddressOf CheckEdit_Click

                GridView1.Columns.Add(column)
            End If
        Next
    End Sub
    Private Sub CheckEdit_EditValueChanged(sender As Object, e As EventArgs)
        GridView1.PostEditor()
        GridView1.UpdateCurrentRow()
    End Sub

    Private Sub CheckEdit_Click(sender As Object, e As EventArgs)
        GridView1.PostEditor()
        GridView1.UpdateCurrentRow()
    End Sub
    Private Sub tbParamMusteri_kaydet_zorunlular()
        Dim zorunluAlanlar As List(Of String) = GetGercekZorunlumuAlanlar()

        Dim dr As DataRow = GridView1.GetDataRow(GridView1.FocusedRowHandle)
        If dr Is Nothing Then Exit Sub

        Dim updateQuery As String = "SET DATEFORMAT DMY SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED UPDATE tbParamMusteri SET "
        Dim updateParts As New List(Of String)

        For Each fieldName As String In zorunluAlanlar
            Dim fieldValue As Boolean = False
            If dr.Table.Columns.Contains(fieldName) AndAlso Not IsDBNull(dr(fieldName)) Then
                fieldValue = Convert.ToBoolean(dr(fieldName))
            End If
            updateParts.Add(fieldName & " = " & If(fieldValue, "1", "0"))
        Next

        updateQuery &= String.Join(", ", updateParts)

        Using conn As New OleDb.OleDbConnection(connection)
            Using cmd As New OleDb.OleDbCommand(updateQuery, conn)
                conn.Open()
                cmd.ExecuteNonQuery()
            End Using
        End Using

        XtraMessageBox.Show("Zorunlu alan ayarları kaydedildi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub
End Class