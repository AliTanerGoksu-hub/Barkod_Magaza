Imports Microsoft.Win32
Imports DevExpress.XtraEditors
Public Class frm_Firma_bakiye
    Public firmano
    Public donemno
    Public connection
    Public kullanici
    Public bMuhasebe As Boolean = False
    Public sKodu As String
    Private Sub frm_Firma_bakiye_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dataload_tbBakiye(sKodu, sec_bDovizli.Checked)
        Dataload_tbVade(sKodu)
        Try
            gorunum_yukle()
        Catch ex As Exception
        End Try
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
    Private Function sorgu_query(ByVal query As String) As String
        query = Replace(query, "*!F", "F0" + firmano.ToString)
        query = Replace(query, "!D", "D000" + donemno.ToString)
        Return query
    End Function
    Public Sub Dataload_tbBakiye(ByVal sKodu As String, ByVal bDovizli As Boolean)
        Try
            ds_tbBakiye.Tables(0).Clear()
        Catch ex As Exception
        End Try
        Dim conn As New OleDb.OleDbConnection
        Dim cmd As New OleDb.OleDbCommand
        Dim adapter As New OleDb.OleDbDataAdapter
        conn.ConnectionString = connection
        adapter.SelectCommand = cmd
        If bMuhasebe = False Then
            If bDovizli = True Then
                cmd.CommandText = sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT sDovizCinsi1 sHareketTipi, SUM(lBorcTutar) lBorcTutar, SUM(lAlacakTutar) lAlacakTutar, SUM(lBakiye) lBakiye FROM (SELECT tbFirmaHareketi.sDovizCinsi1, tbFirma.nFirmaID, lBorcTutar = CASE WHEN tbFirmaHareketi.lBorcTutar > 0 AND tbFirmaHareketi.sDovizCinsi1 <> '' AND tbFirmaHareketi.lDovizKuru1 <>0 THEN tbFirmaHareketi.lBorcTutar / tbFirmaHareketi.lDovizKuru1 ELSE tbFirmaHareketi.lBorcTutar END, lAlacakTutar = CASE WHEN tbFirmaHareketi.lAlacakTutar > 0 AND tbFirmaHareketi.sDovizCinsi1 <> '' AND tbFirmaHareketi.lDovizKuru1 <>0 THEN tbFirmaHareketi.lAlacakTutar / tbFirmaHareketi.lDovizKuru1 ELSE tbFirmaHareketi.lAlacakTutar END, lBakiye = CASE WHEN tbFirmaHareketi.sDovizCinsi1 <> '' AND tbFirmaHareketi.lDovizKuru1 <>0 THEN (tbFirmaHareketi.lBorcTutar - tbFirmaHareketi.lAlacakTutar) / tbFirmaHareketi.lDovizKuru1 ELSE (tbFirmaHareketi.lBorcTutar - tbFirmaHareketi.lAlacakTutar) END FROM tbFirma INNER JOIN tbFirmaHareketi ON tbFirma.nFirmaID = tbFirmaHareketi.nFirmaID WHERE (tbFirmaHareketi.dteIslemTarihi <= '31/12/2078') AND (tbFirma.sKodu LIKE '" & Trim(sKodu) & "%')) TemDevir GROUP BY sDovizCinsi1 ")
            Else
                cmd.CommandText = sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT tbFirmaHareketi.sHareketTipi, tbHareketTipi.sAciklama, SUM(tbFirmaHareketi.lBorcTutar) AS lBorcTutar, SUM(tbFirmaHareketi.lAlacakTutar) AS lAlacakTutar, SUM(tbFirmaHareketi.lBorcTutar - tbFirmaHareketi.lAlacakTutar) AS lBakiye FROM tbFirmaHareketi INNER JOIN tbFirma ON tbFirmaHareketi.nFirmaID = tbFirma.nFirmaID INNER JOIN tbHareketTipi ON tbFirmaHareketi.sHareketTipi = tbHareketTipi.sHareketTipi WHERE (tbFirma.sKodu = '" & sKodu & "') GROUP BY tbFirmaHareketi.sHareketTipi, tbHareketTipi.sAciklama ORDER BY tbFirmaHareketi.sHareketTipi")
            End If
        ElseIf bMuhasebe = True Then
            If bDovizli = True Then
                cmd.CommandText = sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT sDovizCinsi1 sHareketTipi, SUM(lBorcTutar) lBorcTutar, SUM(lAlacakTutar) lAlacakTutar, SUM(lBakiye) lBakiye FROM (SELECT tbMuhasebeFisi.sDovizCinsi1, tbHesapPlani.nHesapID, lBorcTutar = CASE WHEN tbMuhasebeFisi.lBorcTutar > 0 AND tbMuhasebeFisi.sDovizCinsi1 <> '' AND tbMuhasebeFisi.lDovizKuru1 <>0 THEN tbMuhasebeFisi.lBorcTutar / tbMuhasebeFisi.lDovizKuru1 ELSE tbMuhasebeFisi.lBorcTutar END, lAlacakTutar = CASE WHEN tbMuhasebeFisi.lAlacakTutar > 0 AND tbMuhasebeFisi.sDovizCinsi1 <> '' AND tbMuhasebeFisi.lDovizKuru1 <>0 THEN tbMuhasebeFisi.lAlacakTutar / tbMuhasebeFisi.lDovizKuru1 ELSE tbMuhasebeFisi.lAlacakTutar END, lBakiye = CASE WHEN tbMuhasebeFisi.sDovizCinsi1 <> '' AND tbMuhasebeFisi.lDovizKuru1 <>0 THEN (tbMuhasebeFisi.lBorcTutar - tbMuhasebeFisi.lAlacakTutar) / tbMuhasebeFisi.lDovizKuru1 ELSE (tbMuhasebeFisi.lBorcTutar - tbMuhasebeFisi.lAlacakTutar) END FROM tbHesapPlani INNER JOIN tbMuhasebeFisi ON tbHesapPlani.nHesapID = tbMuhasebeFisi.nHesapID WHERE (tbMuhasebeFisi.dteFisTarihi <= '31/12/2078') AND (tbHesapPlani.sKodu LIKE '" & Trim(sKodu) & "%')) TemDevir GROUP BY sDovizCinsi1 ")
            Else
                cmd.CommandText = sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT '' as sHareketTipi, '' sAciklama, SUM(tbMuhasebeFisi.lBorcTutar) AS lBorcTutar, SUM(tbMuhasebeFisi.lAlacakTutar) AS lAlacakTutar, SUM(tbMuhasebeFisi.lBorcTutar - tbMuhasebeFisi.lAlacakTutar) AS lBakiye FROM tbMuhasebeFisi INNER JOIN tbHesapPlani ON tbMuhasebeFisi.nHesapID = tbHesapPlani.nHesapID WHERE (tbHesapPlani.sKodu = '" & sKodu & "') ")
            End If
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
        If bMuhasebe = False Then
            cmd.CommandText = sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT dateadd(day, CASE SUM(lBorcTutar) WHEN 0 THEN 0 ELSE round(SUM(Datediff(day, tbTempMinTarih.MinTarih, dteValorTarihi) * tbFirmaHareketi.lBorcTutar) / SUM(lBorcTutar), 0) END, MIN(dteValorTarihi)) AS dteVadeBorc, dateadd(day, CASE SUM(lAlacakTutar) WHEN 0 THEN 0 ELSE round(SUM(Datediff(day, tbTempMinTarih.MinTarih, dteValorTarihi) * tbFirmaHareketi.lAlacakTutar) / SUM(lAlacakTutar), 0) END, MIN(dteValorTarihi)) AS dteVadeAlacak, datediff(day, dateadd(day, CASE SUM(lBorctutar) WHEN 0 THEN 0 ELSE round(SUM(Datediff(day, tbTempMinTarih.MinTarih, dteValorTarihi) * tbFirmaHareketi.lBorcTutar) / SUM(lBorcTutar), 0) END, MIN(dteValorTarihi)), dateadd(day, CASE SUM(lAlacakTutar) WHEN 0 THEN 0 ELSE round(SUM(Datediff(day, tbTempMinTarih.MinTarih, dteValorTarihi) * tbFirmaHareketi.lAlacakTutar) / SUM(lAlacakTutar), 0) END, MIN(dteValorTarihi))) AS nGun, MAX(tbFirma.nVadeGun) AS nValor FROM tbFirma, tbFirmaHareketi FULL JOIN (SELECT MIN(dteValorTarihi) AS MinTarih, tbFirmaHareketi.nFirmaID FROM tbFirmaHareketi GROUP BY tbFirmaHareketi.nFirmaID) AS tbTempMinTarih ON tbFirmaHareketi.nFirmaID = tbTempMinTarih.nFirmaID WHERE tbFirma.sKodu = '" & sKodu & "' AND tbFirma.nFirmaID = tbFirmaHareketi.nFirmaID")
        ElseIf bMuhasebe = True Then
            cmd.CommandText = sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT dateadd(day, CASE SUM(lBorcTutar) WHEN 0 THEN 0 ELSE round(SUM(Datediff(day, tbTempMinTarih.MinTarih, dteFisTarihi) * tbMuhasebeFisi.lBorcTutar) / SUM(lBorcTutar), 0) END, MIN(dteFisTarihi)) AS dteVadeBorc, dateadd(day, CASE SUM(lAlacakTutar) WHEN 0 THEN 0 ELSE round(SUM(Datediff(day, tbTempMinTarih.MinTarih, dteFisTarihi) * tbMuhasebeFisi.lAlacakTutar) / SUM(lAlacakTutar), 0) END, MIN(dteFisTarihi)) AS dteVadeAlacak, datediff(day, dateadd(day, CASE SUM(lBorctutar) WHEN 0 THEN 0 ELSE round(SUM(Datediff(day, tbTempMinTarih.MinTarih, dteFisTarihi) * tbMuhasebeFisi.lBorcTutar) / SUM(lBorcTutar), 0) END, MIN(dteFisTarihi)), dateadd(day, CASE SUM(lAlacakTutar) WHEN 0 THEN 0 ELSE round(SUM(Datediff(day, tbTempMinTarih.MinTarih, dteFisTarihi) * tbMuhasebeFisi.lAlacakTutar) / SUM(lAlacakTutar), 0) END, MIN(dteFisTarihi))) AS nGun, MAX(0) AS nValor FROM tbHesapPlani, tbMuhasebeFisi FULL JOIN (SELECT MIN(dteFisTarihi) AS MinTarih, tbMuhasebeFisi.nHesapID FROM tbMuhasebeFisi GROUP BY tbMuhasebeFisi.nHesapID) AS tbTempMinTarih ON tbMuhasebeFisi.nHesapID = tbTempMinTarih.nHesapID WHERE tbHesapPlani.sKodu = '" & sKodu & "' AND tbHesapPlani.nHesapID = tbMuhasebeFisi.nHesapID")
        End If
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
    Private Sub sec_bDovizli_CheckStateChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles sec_bDovizli.CheckStateChanged
        Dataload_tbBakiye(sKodu, sec_bDovizli.Checked)
    End Sub
    Private Sub GridView1_CustomDrawRowIndicator(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Grid.RowIndicatorCustomDrawEventArgs) Handles GridView1.CustomDrawRowIndicator
        If e.RowHandle >= 0 Then
            e.Info.DisplayText = e.RowHandle + 1
        Else
            e.Info.DisplayText = ""
        End If
    End Sub
End Class