Imports Microsoft.Win32
Imports DevExpress.XtraEditors
Public Class frm_personel_takip_toplam
    Public firmano
    Public donemno
    Public connection
    Public kullanici
    Public sKodu As String
    Public sKriter As String
    Dim ds_magaza As DataSet
    Dim ds_personel As DataSet
    Dim ds_mudur As DataSet
    Dim ds_sef As DataSet
    Dim ds_departman As DataSet
    Private Sub frm_Firma_bakiye_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        dataload_depo_pos()
        Try
            gorunum_yukle()
        Catch ex As Exception
        End Try
    End Sub
    Private Sub dataload_depo_pos()
        ds_magaza = sorgu(sorgu_query("SELECT     DISTINCT CAST('0' as bit) AS SEC, sdepo AS KOD, sAciklama AS ACIKLAMA FROM         tbDepo Order by sDepo"))
        ds_personel = sorgu(sorgu_query("SELECT     CAST('0' AS bit) AS SEC, PERSONELKODU AS KOD, PERSONELADI AS ACIKLAMA FROM         APERSONEL WHERE     (LEN(PERSONELKODU) <> 2) ORDER BY PERSONELKODU "))
        ds_mudur = sorgu(sorgu_query("SELECT     CAST('0' AS bit) AS SEC, PERSONELKODU AS KOD, PERSONELADI AS ACIKLAMA FROM         APERSONEL WHERE     (LEN(PERSONELKODU) = 3) ORDER BY PERSONELKODU"))
        ds_sef = sorgu(sorgu_query("SELECT     CAST('0' AS bit) AS SEC, PERSONELKODU AS KOD, PERSONELADI AS ACIKLAMA FROM         APERSONEL WHERE     (LEN(PERSONELKODU) =2) ORDER BY PERSONELKODU "))
        ds_departman = sorgu(sorgu_query("SELECT     CAST('0' AS bit) AS SEC, KOD, ACIKLAMA FROM         APERSONELDEPT"))
    End Sub
    Private Function sorgu(ByVal query As String) As DataSet
        Dim conn As New OleDb.OleDbConnection
        Dim adapter As New OleDb.OleDbDataAdapter
        Dim cmd As New OleDb.OleDbCommand
        conn.ConnectionString = connection
        adapter.SelectCommand = cmd
        cmd.CommandText = query
        cmd.Connection = conn
        conn.Open()
        Dim DS As New DataSet
        Dim N As Integer = adapter.Fill(DS, "TABLE1")
        conn.Close()
        Return DS
        adapter = Nothing
        cmd = Nothing
    End Function
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
        SimpleButton1.Text = Sorgu_sDil(SimpleButton1.Text, sDil)
        SimpleButton2.Text = Sorgu_sDil(SimpleButton2.Text, sDil)
        SimpleButton3.Text = Sorgu_sDil(SimpleButton3.Text, sDil)
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
    Private Function sorgu_query(ByVal query As String) As String
        query = Replace(query, "*!F", "F0" + firmano.ToString)
        query = Replace(query, "!D", "D000" + donemno.ToString)
        Return query
    End Function
    Public Sub Dataload_tbBakiye(ByVal tarih1 As DateTime, ByVal tarih2 As DateTime, ByVal sDepo As String, ByVal sPersonel As String, ByVal sSef As String, ByVal sDepartman As String, ByVal sGroup As String)
        Try
            ds_tbBakiye.Tables(0).Clear()
        Catch ex As Exception
        End Try
        Dim conn As New OleDb.OleDbConnection
        Dim cmd As New OleDb.OleDbCommand
        Dim adapter As New OleDb.OleDbDataAdapter
        conn.ConnectionString = connection
        adapter.SelectCommand = cmd
        Dim kriter As String = ""
        kriter = " Where TARIH BETWEEN '" & tarih1 & "' AND '" & tarih2 & "' "
        If sDepo <> "[Tümü]" Then
            kriter += " AND MAGAZA IN ( " & sDepo & " )"
        End If
        If sPersonel <> "[Tümü]" Then
            kriter += " AND PERSONELKODU IN ( " & sPersonel & " )"
        End If
        If sSef <> "[Tümü]" Then
            kriter += " AND SEF IN ( " & sSef & " )"
        End If
        If sDepartman <> "[Tümü]" Then
            kriter += " AND DEPARTMAN IN ( " & sDepartman & " )"
        End If
        'If sKriter = "" Then
        '    cmd.CommandText = sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT tbFirmaHareketi.sCariIslem, tbCariIslem.sAciklama, SUM(tbFirmaHareketi.lBorcTutar) AS lBorcTutar, SUM(tbFirmaHareketi.lAlacakTutar) AS lAlacakTutar, SUM(tbFirmaHareketi.lBorcTutar - tbFirmaHareketi.lAlacakTutar) AS lBakiye FROM tbFirmaHareketi INNER JOIN tbFirma ON tbFirmaHareketi.nFirmaID = tbFirma.nFirmaID INNER JOIN tbCariIslem ON tbFirmaHareketi.sCariIslem = tbCariIslem.sCariIslem WHERE (tbFirma.sKodu = '" & sKodu & " ') GROUP BY tbFirmaHareketi.sCariIslem, tbCariIslem.sAciklama Order by tbFirmaHareketi.sCariIslem")
        'Else
        '    cmd.CommandText = sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT SUM(tbFirmaHareketi.lBorcTutar) AS lBorcTutar, SUM(tbFirmaHareketi.lAlacakTutar) AS lAlacakTutar, SUM(tbFirmaHareketi.lAlacakTutar - tbFirmaHareketi.lBorcTutar) AS lBakiye, tbFirmaHareketi.sCariIslem, tbCariIslem.sAciklama FROM tbFirma INNER JOIN tbFirmaHareketi ON tbFirma.nFirmaID = tbFirmaHareketi.nFirmaID INNER JOIN tbFirmaSinifi ON tbFirma.nFirmaID = tbFirmaSinifi.nFirmaID INNER JOIN tbFSinif1 ON tbFirmaSinifi.sSinifKodu1 = tbFSinif1.sSinifKodu INNER JOIN tbFSinif2 ON tbFirmaSinifi.sSinifKodu2 = tbFSinif2.sSinifKodu INNER JOIN tbFSinif3 ON tbFirmaSinifi.sSinifKodu3 = tbFSinif3.sSinifKodu INNER JOIN tbFSinif4 ON tbFirmaSinifi.sSinifKodu4 = tbFSinif4.sSinifKodu INNER JOIN tbFSinif5 ON tbFirmaSinifi.sSinifKodu5 = tbFSinif5.sSinifKodu INNER JOIN tbCariIslem ON tbFirmaHareketi.sCariIslem = tbCariIslem.sCariIslem LEFT OUTER JOIN tbFirmaAciklamasi ON tbFirma.nFirmaID = tbFirmaAciklamasi.nFirmaID " & sKriter & " GROUP BY tbFirmaHareketi.sCariIslem, tbCariIslem.sAciklama Order by tbFirmaHareketi.sCariIslem")
        'End If
        If sGroup = "PERSONEL" Then
            cmd.CommandText = sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT PERSONELKODU AS sKodu, PERSONEL AS sAciklama, '' AS sPeriyod, COUNT(PERSONELKODU) AS nKayit, SUM(YEVMIYE) AS Yevmiye, SUM(MESAI) AS Mesai, SUM(MESAIUCRETI) AS MesaiUcreti, SUM(EKLENTI1) AS Eklenti1, SUM(EKLENTI2) AS Eklenti2, SUM(EKLENTI3) AS Eklenti3, SUM(EKLENTI4) AS Eklenti4, SUM(EKLENTI5) AS Eklenti5, SUM(KESINTI1) AS Kesinti1, SUM(KESINTI2) AS Kesinti2, SUM(KESINTI3) AS Kesinti3, SUM(KESINTI4) AS Kesinti4, SUM(KESINTI5) AS Kesinti5, SUM(NET) AS Net FROM APERSONELTAKIP " & kriter & " GROUP BY PERSONELKODU,PERSONEL")
        Else
            cmd.CommandText = sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT '' AS sKodu, " & sGroup & " AS sAciklama, '' AS sPeriyod, COUNT(PERSONELKODU) AS nKayit, SUM(YEVMIYE) AS Yevmiye, SUM(MESAI) AS Mesai, SUM(MESAIUCRETI) AS MesaiUcreti, SUM(EKLENTI1) AS Eklenti1, SUM(EKLENTI2) AS Eklenti2, SUM(EKLENTI3) AS Eklenti3, SUM(EKLENTI4) AS Eklenti4, SUM(EKLENTI5) AS Eklenti5, SUM(KESINTI1) AS Kesinti1, SUM(KESINTI2) AS Kesinti2, SUM(KESINTI3) AS Kesinti3, SUM(KESINTI4) AS Kesinti4, SUM(KESINTI5) AS Kesinti5, SUM(NET) AS Net FROM APERSONELTAKIP " & kriter & " GROUP BY " & sGroup & "")
        End If
        cmd.Connection = conn
        conn.Open()
        Dim N As Integer = adapter.Fill(ds_tbBakiye, "Table1")
        conn.Close()
    End Sub
    Public Sub Dataload_tbVade(ByVal sKodu As String)
        Try
            ds_tbVade.Tables(0).Clear()
        Catch ex As Exception
        End Try
        Dim conn As New OleDb.OleDbConnection
        Dim cmd As New OleDb.OleDbCommand
        Dim adapter As New OleDb.OleDbDataAdapter
        conn.ConnectionString = connection
        adapter.SelectCommand = cmd
        cmd.CommandText = sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT dateadd(day, CASE SUM(lBorcTutar) WHEN 0 THEN 0 ELSE round(SUM(Datediff(day, tbTempMinTarih.MinTarih, dteValorTarihi) * tbFirmaHareketi.lBorcTutar) / SUM(lBorcTutar), 0) END, MIN(dteValorTarihi)) AS dteVadeBorc, dateadd(day, CASE SUM(lAlacakTutar) WHEN 0 THEN 0 ELSE round(SUM(Datediff(day, tbTempMinTarih.MinTarih, dteValorTarihi) * tbFirmaHareketi.lAlacakTutar) / SUM(lAlacakTutar), 0) END, MIN(dteValorTarihi)) AS dteVadeAlacak, datediff(day, dateadd(day, CASE SUM(lBorctutar) WHEN 0 THEN 0 ELSE round(SUM(Datediff(day, tbTempMinTarih.MinTarih, dteValorTarihi) * tbFirmaHareketi.lBorcTutar) / SUM(lBorcTutar), 0) END, MIN(dteValorTarihi)), dateadd(day, CASE SUM(lAlacakTutar) WHEN 0 THEN 0 ELSE round(SUM(Datediff(day, tbTempMinTarih.MinTarih, dteValorTarihi) * tbFirmaHareketi.lAlacakTutar) / SUM(lAlacakTutar), 0) END, MIN(dteValorTarihi))) AS nGun, MAX(tbFirma.nVadeGun) AS nValor FROM tbFirma, tbFirmaHareketi FULL JOIN (SELECT MIN(dteValorTarihi) AS MinTarih, tbFirmaHareketi.nFirmaID FROM tbFirmaHareketi GROUP BY tbFirmaHareketi.nFirmaID) AS tbTempMinTarih ON tbFirmaHareketi.nFirmaID = tbTempMinTarih.nFirmaID WHERE tbFirma.sKodu = '" & sKodu & "' AND tbFirma.nFirmaID = tbFirmaHareketi.nFirmaID")
        cmd.Connection = conn
        conn.Open()
        Dim N As Integer = adapter.Fill(ds_tbVade, "Table1")
        conn.Close()
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
    Private Sub SimpleButton2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SimpleButton2.Click
        Me.Close()
    End Sub
    Private Sub SimpleButton1_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles SimpleButton1.Click
        Me.Close()
    End Sub
    Private Sub GridControl1_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles GridControl1.KeyDown
        If e.KeyCode = Keys.Escape Then
            Me.Close()
        End If
    End Sub
    Private Sub BarButtonItem1_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem1.ItemClick
        printlink1.CreateDocument(ps)
        ps.PreviewRibbonFormEx.Show()
    End Sub
    Private Sub BarButtonItem2_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem2.ItemClick
        raporla_excel()
    End Sub
    Private Sub BarButtonItem3_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem3.ItemClick
        raporla_text()
    End Sub
    Private Sub BarButtonItem4_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem4.ItemClick
        raporla_pdf()
    End Sub
    Private Sub sec_depo_QueryPopUp(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles sec_depo.QueryPopUp
        sec_departman.Properties.PopupControl = Nothing
        sec_Sef.Properties.PopupControl = Nothing
        sec_personel.Properties.PopupControl = Nothing
        sec_depo.Properties.PopupControl = sec_grid
        GridControl2.DataSource = ds_magaza.Tables(0)
        GridControl2.DataMember = Nothing
    End Sub
    Private Sub sec_departman_QueryPopUp(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles sec_departman.QueryPopUp
        sec_departman.Properties.PopupControl = sec_grid
        sec_Sef.Properties.PopupControl = Nothing
        sec_personel.Properties.PopupControl = Nothing
        sec_depo.Properties.PopupControl = Nothing
        GridControl2.DataSource = ds_departman.Tables(0)
        GridControl2.DataMember = Nothing
    End Sub
    Private Sub sec_personel_QueryPopUp(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles sec_personel.QueryPopUp
        sec_departman.Properties.PopupControl = Nothing
        sec_Sef.Properties.PopupControl = Nothing
        sec_personel.Properties.PopupControl = sec_grid
        sec_depo.Properties.PopupControl = Nothing
        If sec_kasatipi.Text = "Personel:" Then
            GridControl2.DataSource = ds_personel.Tables(0)
        ElseIf sec_kasatipi.Text = "Müdür:" Then
            GridControl2.DataSource = ds_mudur.Tables(0)
        End If
        'GridControl2.DataSource = ds_kasiyer.Tables(0)
        GridControl2.DataMember = Nothing
    End Sub
    Private Sub sec_Sef_QueryPopUp(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles sec_Sef.QueryPopUp
        sec_departman.Properties.PopupControl = Nothing
        sec_Sef.Properties.PopupControl = sec_grid
        sec_personel.Properties.PopupControl = Nothing
        sec_depo.Properties.PopupControl = Nothing
        GridControl2.DataSource = ds_sef.Tables(0)
        GridControl2.DataMember = Nothing
    End Sub
    Private Sub sec_depo_QueryResultValue(ByVal sender As Object, ByVal e As DevExpress.XtraEditors.Controls.QueryResultValueEventArgs) Handles sec_depo.QueryResultValue
        Dim s As String = deger(ds_magaza)
        If s.ToString <> "" Then
            e.Value = s.ToString
        Else
            e.Value = "[Tümü]"
        End If
    End Sub
    Private Function deger(ByVal ds As DataSet) As String
        Dim dr As DataRow
        Dim s As String = ""
        Dim satir As String = ""
        Dim sayi As Integer = 0
        Dim sayi1 As Integer = 0
        For Each dr In ds.Tables(0).Rows
            If dr("SEC") = True Then
                sayi += 1
            End If
        Next
        For Each dr In ds.Tables(0).Rows
            If dr("SEC") = True Then
                sayi1 += 1
                s += "'" + Trim(dr("KOD")).ToString + "'"
                satir += Trim(dr("ACIKLAMA"))
                If sayi1 < sayi Then
                    s += ","
                    satir += ","
                End If
            End If
        Next
        sayi1 = Nothing
        sayi = Nothing
        'If s.ToString <> "" Then
        '    e.Value = s.ToString
        'Else
        '    e.Value = "[Tümü]"
        'End If
        Return s.ToString
    End Function
    Private Sub sec_departman_QueryResultValue(ByVal sender As Object, ByVal e As DevExpress.XtraEditors.Controls.QueryResultValueEventArgs) Handles sec_departman.QueryResultValue
        Dim s As String = deger(ds_departman)
        If s.ToString <> "" Then
            e.Value = s.ToString
        Else
            e.Value = "[Tümü]"
        End If
    End Sub
    Private Sub sec_personel_QueryResultValue(ByVal sender As Object, ByVal e As DevExpress.XtraEditors.Controls.QueryResultValueEventArgs) Handles sec_personel.QueryResultValue
        Dim s As String = ""
        If sec_kasatipi.Text = "Personel:" Then
            s = deger(ds_personel)
        ElseIf sec_kasatipi.Text = "Müdür:" Then
            s = deger(ds_mudur)
        End If
        If s.ToString <> "" Then
            e.Value = s.ToString
        Else
            e.Value = "[Tümü]"
        End If
    End Sub
    Private Sub sec_Sef_QueryResultValue(ByVal sender As Object, ByVal e As DevExpress.XtraEditors.Controls.QueryResultValueEventArgs) Handles sec_Sef.QueryResultValue
        Dim s As String = deger(ds_sef)
        If s.ToString <> "" Then
            e.Value = s.ToString
        Else
            e.Value = "[Tümü]"
        End If
    End Sub
    Private Sub SimpleButton3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SimpleButton3.Click
        ara()
    End Sub
    Private Sub ara()
        Dataload_tbBakiye(DateEdit1.Text, DateEdit2.Text, sec_depo.Text, sec_personel.Text, sec_Sef.Text, sec_departman.Text, sec_sGroup.text)
    End Sub
    Private Sub GridView1_CustomDrawRowIndicator(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Grid.RowIndicatorCustomDrawEventArgs) Handles GridView1.CustomDrawRowIndicator
        If e.RowHandle >= 0 Then
            e.Info.DisplayText = e.RowHandle + 1
        Else
            e.Info.DisplayText = ""
        End If
    End Sub
End Class