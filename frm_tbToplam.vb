Imports Microsoft.Win32
Imports DevExpress.XtraEditors
Public Class frm_tbToplam
    Public firmano
    Public donemno
    Public connection
    Public kullanici
    Public islemstatus As Boolean = False
    Public tarih1 As DateTime
    Public tarih2 As DateTime
    Public sKodu As String = ""
    Public sKriter As String = ""
    Public sIslem As String = ""
    Public nGirisCikis As Integer = 0
    Private Sub frm_Firma_bakiye_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dataload_tbBakiye(sKodu)
        'Dataload_tbVade(sKodu)
        'Try
        '    gorunum_yukle()
        'Catch ex As Exception
        'End Try
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
    Public Sub Dataload_tbBakiye(ByVal sKodu As String)
        Try
            ds_tbBakiye.Tables(0).Clear()
        Catch ex As Exception
        End Try
        Dim conn As New OleDb.OleDbConnection
        Dim cmd As New OleDb.OleDbCommand
        Dim adapter As New OleDb.OleDbDataAdapter
        conn.ConnectionString = connection
        adapter.SelectCommand = cmd
        If sIslem = "FaturaGunToplamlarý" Then
            cmd.CommandText = sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT tbStokFisiMaster.dteFisTarihi AS sAciklama, SUM(tbStokFisiMaster.lNetTutar) AS NetTutar, SUM(tbStokFisiMaster.lKdv1 + tbStokFisiMaster.lKdv2 + tbStokFisiMaster.lKdv3 + tbStokFisiMaster.lKdv4 + tbStokFisiMaster.lKdv5) AS KdvTutari, SUM(tbStokFisiMaster.lKdvMatrahi1 + tbStokFisiMaster.lKdvMatrahi2 + tbStokFisiMaster.lKdvMatrahi3 + tbStokFisiMaster.lKdvMatrahi4 + tbStokFisiMaster.lKdvMatrahi5) AS KdvMatrahi, SUM(tbStokFisiMaster.lEkmaliyet1 + tbStokFisiMaster.lEkmaliyet2 + tbStokFisiMaster.lEkmaliyet3) AS EkMaliyet, SUM(tbStokFisiMaster.lMalIskontoTutari) AS MalIskontoTutari, SUM(tbStokFisiMaster.lMalIskontoTutari + tbStokFisiMaster.lDipIskontoTutari1 + tbStokFisiMaster.lDipIskontoTutari2 + tbStokFisiMaster.lDipIskontoTutari3) AS IskontoTutari, SUM(tbStokFisiMaster.lMalBedeli) AS MalBedeli, SUM(tbStokFisiMaster.lMalBedeli - tbStokFisiMaster.lMalIskontoTutari) AS AraToplam, SUM(tbStokFisiMaster.lDipIskontoTutari1 + tbStokFisiMaster.lDipIskontoTutari2 + tbStokFisiMaster.lDipIskontoTutari3) AS DipIskontoTutari FROM tbStokFisiMaster INNER JOIN tbFirma ON tbStokFisiMaster.nFirmaID = tbFirma.nFirmaID " & sKriter & " GROUP BY tbStokFisiMaster.dteFisTarihi")
        ElseIf sIslem = "FaturaDepoToplamlarý" Then
            cmd.CommandText = sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT tbStokFisiMaster.sDepo AS sAciklama, SUM(tbStokFisiMaster.lNetTutar) AS NetTutar, SUM(tbStokFisiMaster.lKdv1 + tbStokFisiMaster.lKdv2 + tbStokFisiMaster.lKdv3 + tbStokFisiMaster.lKdv4 + tbStokFisiMaster.lKdv5) AS KdvTutari, SUM(tbStokFisiMaster.lKdvMatrahi1 + tbStokFisiMaster.lKdvMatrahi2 + tbStokFisiMaster.lKdvMatrahi3 + tbStokFisiMaster.lKdvMatrahi4 + tbStokFisiMaster.lKdvMatrahi5) AS KdvMatrahi, SUM(tbStokFisiMaster.lEkmaliyet1 + tbStokFisiMaster.lEkmaliyet2 + tbStokFisiMaster.lEkmaliyet3) AS EkMaliyet, SUM(tbStokFisiMaster.lMalIskontoTutari) AS MalIskontoTutari, SUM(tbStokFisiMaster.lMalIskontoTutari + tbStokFisiMaster.lDipIskontoTutari1 + tbStokFisiMaster.lDipIskontoTutari2 + tbStokFisiMaster.lDipIskontoTutari3) AS IskontoTutari, SUM(tbStokFisiMaster.lMalBedeli) AS MalBedeli, SUM(tbStokFisiMaster.lMalBedeli - tbStokFisiMaster.lMalIskontoTutari) AS AraToplam, SUM(tbStokFisiMaster.lDipIskontoTutari1 + tbStokFisiMaster.lDipIskontoTutari2 + tbStokFisiMaster.lDipIskontoTutari3) AS DipIskontoTutari FROM tbStokFisiMaster INNER JOIN tbFirma ON tbStokFisiMaster.nFirmaID = tbFirma.nFirmaID " & sKriter & " GROUP BY tbStokFisiMaster.sDepo")
        ElseIf sIslem = "FirmaBordroListe" Then
            If nGirisCikis = 3 Then
                cmd.CommandText = sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT tbFirmaBordroDetay.sCariIslem, tbCariIslem.sAciklama, SUM(tbFirmaBordroDetay.lBorcTutar) AS lToplamTutar, COUNT(tbFirmaBordroDetay.nKayitID) AS nToplamKayit, CAST(ROUND(SUM(ISNULL(tbFirmaBordroDetay.lBorcTutar, 0) * CAST(tbFirmaBordroDetay.dteValorTarihi AS FLOAT)) / SUM(tbFirmaBordroDetay.lBorcTutar), 0) AS DATETIME) AS dteOrtVade FROM tbFirmaBordroDetay INNER JOIN tbFirmaBordroMaster a ON tbFirmaBordroDetay.nBordroID = a.nBordroID INNER JOIN tbFirma ON tbFirmaBordroDetay.nFirmaID = tbFirma.nFirmaID INNER JOIN tbCariIslem ON tbFirmaBordroDetay.sCariIslem = tbCariIslem.sCariIslem " & sKriter & " GROUP BY tbFirmaBordroDetay.sCariIslem, tbCariIslem.sAciklama UNION ALL SELECT 'Toplam' AS sCariIslem, 'Toplam' sAciklama, SUM(tbFirmaBordroDetay.lBorcTutar) AS lToplamTutar, COUNT(tbFirmaBordroDetay.nKayitID) AS nToplamKayit, CAST(ROUND(SUM(ISNULL(tbFirmaBordroDetay.lBorcTutar, 0) * CAST(tbFirmaBordroDetay.dteValorTarihi AS FLOAT)) / SUM(tbFirmaBordroDetay.lBorcTutar), 0) AS DATETIME) AS dteOrtVade FROM tbFirmaBordroDetay INNER JOIN tbFirmaBordroMaster a ON tbFirmaBordroDetay.nBordroID = a.nBordroID INNER JOIN tbFirma ON tbFirmaBordroDetay.nFirmaID = tbFirma.nFirmaID " & sKriter & "  ")
            ElseIf nGirisCikis = 1 Then
                cmd.CommandText = sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT tbFirmaBordroDetay.sCariIslem, tbCariIslem.sAciklama, SUM(tbFirmaBordroDetay.lAlacakTutar) AS lToplamTutar, COUNT(tbFirmaBordroDetay.nKayitID) AS nToplamKayit, CAST(ROUND(SUM(ISNULL(tbFirmaBordroDetay.lAlacakTutar, 0) * CAST(tbFirmaBordroDetay.dteValorTarihi AS FLOAT)) / SUM(tbFirmaBordroDetay.lAlacakTutar), 0) AS DATETIME) AS dteOrtVade FROM tbFirmaBordroDetay INNER JOIN tbFirmaBordroMaster a ON tbFirmaBordroDetay.nBordroID = a.nBordroID INNER JOIN tbFirma ON tbFirmaBordroDetay.nFirmaID = tbFirma.nFirmaID INNER JOIN tbCariIslem ON tbFirmaBordroDetay.sCariIslem = tbCariIslem.sCariIslem " & sKriter & " GROUP BY tbFirmaBordroDetay.sCariIslem, tbCariIslem.sAciklama UNION ALL SELECT 'Toplam' AS sCariIslem, 'Toplam' sAciklama, SUM(tbFirmaBordroDetay.lAlacakTutar) AS lToplamTutar, COUNT(tbFirmaBordroDetay.nKayitID) AS nToplamKayit, CAST(ROUND(SUM(ISNULL(tbFirmaBordroDetay.lAlacakTutar, 0) * CAST(tbFirmaBordroDetay.dteValorTarihi AS FLOAT)) / SUM(tbFirmaBordroDetay.lAlacakTutar), 0) AS DATETIME) AS dteOrtVade FROM tbFirmaBordroDetay INNER JOIN tbFirmaBordroMaster a ON tbFirmaBordroDetay.nBordroID = a.nBordroID INNER JOIN tbFirma ON tbFirmaBordroDetay.nFirmaID = tbFirma.nFirmaID " & sKriter & "  ")
            End If
        ElseIf sIslem = "Modul" Then
            cmd.CommandText = sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT     sModul FROM         tbModul WHERE     (sModul NOT IN                           (SELECT     sModul                            FROM          tbFirmaModulu                             WHERE      nFirmaID = " & sKodu & ")) Order by nModulID ")
            Me.Text = "Modüller"
            Me.Label1.Text = "Modüller Listesi"
        ElseIf sIslem = "FinansFaaliyet" Then
            cmd.CommandText = sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT     * FROM         tbModul WHERE     (sModul NOT IN                           (SELECT     sModul                            FROM          tbFirmaModulu                             WHERE      nFirmaID = " & sKodu & "))  ")
        ElseIf sIslem = "NakitKasaToplamlari" Then
            Dim sKod = "100"
            Dim sAciklama = Sorgu_sDil("Kasa", sDil)
            Dim sAciklamaTR = "Kasa"
            cmd.CommandText = sorgu_query("SET dateformat dmy SELECT '" & sKod & "' AS sHesap,'" & sKod & "' AS sKodu, N'" & sAciklamaTR & "'  sAciklamaTR,N'" & sAciklama & "'  sAciklama, SUM(tbNakitKasa.lTahsilTutar) AS lBorcTutar, SUM(tbNakitKasa.lTediyeTutar) AS lAlacakTutar, SUM(tbNakitKasa.lTahsilTutar - tbNakitKasa.lTediyeTutar) AS lBakiye, SUM(tbNakitKasa.lTahsilTutar - tbNakitKasa.lTediyeTutar) AS lTutar, 1 AS nDurum FROM tbNakitKasa INNER JOIN tbSubeMagaza ON tbNakitKasa.sSube = tbSubeMagaza.sSubeMagaza WHERE tbNakitKasa.dteIslemTarihi BETWEEN '" & tarih1 & "' AND '" & tarih2 & "' UNION ALL SELECT '100-' + tbNakitKasa.sSube AS sHesap,'100-' + tbNakitKasa.sSube AS sKodu, tbSubeMagaza.sAciklama sAciklamaTR, N'" & sAciklama & "'  sAciklama,SUM(tbNakitKasa.lTahsilTutar) AS lBorcTutar, SUM(tbNakitKasa.lTediyeTutar) AS lAlacakTutar, SUM(tbNakitKasa.lTahsilTutar - tbNakitKasa.lTediyeTutar) AS lBakiye, 0 AS lTutar, 2 AS nDurum FROM tbNakitKasa INNER JOIN tbSubeMagaza ON tbNakitKasa.sSube = tbSubeMagaza.sSubeMagaza WHERE tbNakitKasa.dteIslemTarihi BETWEEN '" & tarih1 & "' AND '" & tarih2 & "' GROUP BY tbNakitKasa.sSube,tbSubeMagaza.sAciklama ORDER BY sKodu, sAciklama")
        Else
            cmd.CommandText = sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT tbStokFisiMaster.dteFisTarihi AS sAciklama, SUM(tbStokFisiMaster.lNetTutar) AS NetTutar, SUM(tbStokFisiMaster.lKdv1 + tbStokFisiMaster.lKdv2 + tbStokFisiMaster.lKdv3 + tbStokFisiMaster.lKdv4 + tbStokFisiMaster.lKdv5) AS KdvTutari, SUM(tbStokFisiMaster.lKdvMatrahi1 + tbStokFisiMaster.lKdvMatrahi2 + tbStokFisiMaster.lKdvMatrahi3 + tbStokFisiMaster.lKdvMatrahi4 + tbStokFisiMaster.lKdvMatrahi5) AS KdvMatrahi, SUM(tbStokFisiMaster.lEkmaliyet1 + tbStokFisiMaster.lEkmaliyet2 + tbStokFisiMaster.lEkmaliyet3) AS EkMaliyet, SUM(tbStokFisiMaster.lMalIskontoTutari) AS MalIskontoTutari, SUM(tbStokFisiMaster.lMalIskontoTutari + tbStokFisiMaster.lDipIskontoTutari1 + tbStokFisiMaster.lDipIskontoTutari2 + tbStokFisiMaster.lDipIskontoTutari3) AS IskontoTutari, SUM(tbStokFisiMaster.lMalBedeli) AS MalBedeli, SUM(tbStokFisiMaster.lMalBedeli - tbStokFisiMaster.lMalIskontoTutari) AS AraToplam, SUM(tbStokFisiMaster.lDipIskontoTutari1 + tbStokFisiMaster.lDipIskontoTutari2 + tbStokFisiMaster.lDipIskontoTutari3) AS DipIskontoTutari FROM tbStokFisiMaster INNER JOIN tbFirma ON tbStokFisiMaster.nFirmaID = tbFirma.nFirmaID " & sKriter & " GROUP BY tbStokFisiMaster.dteFisTarihi")
        End If
        cmd.Connection = conn
        conn.Open()
        Dim N As Integer = adapter.Fill(ds_tbBakiye, "Table1")
        conn.Close()
        GridView1.Columns.Clear()
        GridControl1.DataMember = Nothing
        GridControl1.DataSource = ds_tbBakiye.Tables(0)
        GridView1.BestFitColumns()
        If sIslem = "FirmaBordroListe" Then
            GridView1.Columns(0).Caption = "ÝþlemTipi"
            GridView1.Columns(1).Caption = "Açýklama"
            GridView1.Columns(2).Caption = "Tutar"
            GridView1.Columns(3).Caption = "KayýtSayýsý"
            GridView1.Columns(4).Caption = "Ortalama Vade"
        ElseIf sIslem = "NakitKasaToplamlari" Then
            GridView1.Columns(0).Visible = False
            GridView1.Columns(3).Visible = False
            GridView1.Columns(8).Visible = False
            GridView1.Columns(4).Caption = "Gelir"
            GridView1.Columns(4).DisplayFormat.FormatString = "#,0.00"
            GridView1.Columns(4).DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
            GridView1.Columns(5).Caption = "Gider"
            GridView1.Columns(5).DisplayFormat.FormatString = "#,0.00"
            GridView1.Columns(5).DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
            GridView1.Columns(6).Caption = "Kalan"
            GridView1.Columns(6).DisplayFormat.FormatString = "#,0.00"
            GridView1.Columns(6).DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
            GridView1.Columns(7).Caption = "Tutar"
            GridView1.Columns(7).DisplayFormat.FormatString = "#,0.00"
            GridView1.Columns(7).DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
            GridControl1.DataMember = Nothing
            GridControl1.DataSource = Nothing
            GridControl1.DataSource = ds_tbBakiye.Tables(0)
            GridView1.BestFitColumns()
            GridControl1.Refresh()
            GridControl1.Update()
        End If
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
        If islemstatus = True Then
            Me.DialogResult = Windows.Forms.DialogResult.OK
        Else
            Me.Close()
        End If
    End Sub
    Private Sub GridControl1_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles GridControl1.DoubleClick
        If islemstatus = True Then
            Me.DialogResult = Windows.Forms.DialogResult.OK
        End If
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
    Private Sub GridView1_CustomDrawRowIndicator(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Grid.RowIndicatorCustomDrawEventArgs) Handles GridView1.CustomDrawRowIndicator
        If e.RowHandle >= 0 Then
            e.Info.DisplayText = e.RowHandle + 1
        Else
            e.Info.DisplayText = ""
        End If
    End Sub
    Private Sub GridView1_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles GridView1.KeyDown
        If e.KeyCode = Keys.Enter Then
            If islemstatus = True Then
                Me.DialogResult = Windows.Forms.DialogResult.OK
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
End Class