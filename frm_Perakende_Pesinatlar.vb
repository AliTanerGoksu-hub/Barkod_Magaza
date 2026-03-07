Imports DevExpress.XtraEditors
Public Class frm_Perakende_Pesinatlar
    Public firmano
    Public donemno
    Public connection
    Public nMusteriID As Int64 = -1
    Public kullanici
    Public status As Boolean = False
    Dim dataset1 As New DataSet
    Private Sub frm_Perakende_Pesinatlar_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            gorunum_yukle()
        Catch ex As Exception
        End Try
        dataload()
    End Sub
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
    Public Function sorgu_lBekleyen_kontrol(ByVal nMusteriID As Int64) As Int64
        Dim kriter
        Dim lHediyeCeki As Decimal = 0
        kriter = ""
        Dim conn As New OleDb.OleDbConnection
        Dim cmd As New OleDb.OleDbCommand
        Dim adapter As New OleDb.OleDbDataAdapter
        conn.ConnectionString = connection
        cmd.Connection = conn
        conn.Open()
        cmd.CommandText = sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT ISNULL(COUNT(tbStok.sKodu),0) AS nKayit FROM tbAlisverisSiparis INNER JOIN tbAlisVeris ON tbAlisverisSiparis.nAlisverisID = tbAlisVeris.nAlisverisID INNER JOIN tbMusteri ON tbAlisVeris.nMusteriID = tbMusteri.nMusteriID INNER JOIN tbStok ON tbAlisverisSiparis.nStokID = tbStok.nStokID INNER JOIN tbDepo ON tbAlisverisSiparis.sMagazaKodu = tbDepo.sDepo WHERE (tbAlisverisSiparis.nGirisCikis = 3) AND (tbAlisverisSiparis.lGCMiktar <> tbAlisverisSiparis.bEkAlan1) AND (tbMusteri.lKodu BETWEEN 0 AND 999999999) AND (tbAlisVeris.dteFaturaTarihi BETWEEN '01/01/1900' AND '31/12/2048') AND (tbAlisVeris.sFisTipi = 'SP' OR tbAlisVeris.sFisTipi = 'SK') AND (tbAlisverisSiparis.dteOnayTarihi = '01/01/1900') AND (tbAlisverisSiparis.dteTeslimEdilecek BETWEEN '01/01/1900' AND '31/12/2048') ")
        lHediyeCeki = cmd.ExecuteScalar
        Return lHediyeCeki
    End Function
    Public Function stok() As DataSet
        Dim kriter
        If nMusteriID = -1 Then
            kriter = "WHERE (tbOdeme.dteOdemeTarihi BETWEEN '01/01/1900' AND '31/12/2078') AND (tbOdeme.nAlisverisID like '%') AND lNetTutar > lPesinat AND lNetTutar > lTutari"
        Else
            kriter = "WHERE (tbOdeme.dteOdemeTarihi BETWEEN '01/01/1900' AND '31/12/2078') AND (tbOdeme.nAlisverisID = '') and tbOdeme.sKartNo like '%'AND lNetTutar > lPesinat AND lNetTutar > lTutari"
        End If
        Dim conn As New OleDb.OleDbConnection
        Dim cmd As New OleDb.OleDbCommand
        Dim adapter As New OleDb.OleDbDataAdapter
        conn.ConnectionString = connection
        adapter.SelectCommand = cmd
        If sec_Teslimedilmeyen.Checked = True Then
            'cmd.CommandText = sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT tbMusteri.nMusteriID, tbMusteri.sGsm, tbAlisverisSiparis.bTeslimEdildi, tbMusteri.lKodu, ISNULL(SUM(tbTaksit.lTutari), 0) AS TUTAR, ISNULL(SUM(tbOdeme.odeme), 0) AS TAHSILAT, ISNULL(ISNULL(SUM(tbTaksit.lTutari), 0) - ISNULL(SUM(tbOdeme.odeme), 0), 0) AS KALAN,  tbAlisVeris.dteFaturaTarihi,tbAlisVeris.lToplamMiktar, tbAlisVeris.lPesinat, tbAlisVeris.lNetTutar,tbAlisVeris.dteKayitTarihi, tbAlisVeris.nAlisverisID, tbMusteri.sAdi + ' ' + tbMusteri.sSoyadi AS sAdi FROM (SELECT isnull(SUM(lOdemeTutar) , 0) AS odeme , nTaksitId FROM tbOdeme GROUP BY nTaksitId) tbOdeme RIGHT OUTER JOIN tbTaksit INNER JOIN tbAlisVeris ON tbTaksit.nAlisverisID = tbAlisVeris.nAlisverisID INNER JOIN tbAlisverisSiparis ON tbAlisveris.nAlisverisID = tbAlisverisSiparis.nAlisverisID INNER JOIN tbMusteri ON tbAlisVeris.nMusteriID = tbMusteri.nMusteriID ON tbOdeme.nTaksitId = tbTaksit.nTaksitID WHERE (tbMusteri.lKodu like '%') and lNetTutar > lPesinat and lNetTutar > lTutari and tbAlisverisSiparis.bTeslimEdildi = '0'   GROUP BY tbMusteri.nMusteriID, tbMusteri.lKodu, tbAlisVeris.dteFaturaTarihi,tbAlisverisSiparis.bTeslimEdildi, tbAlisVeris.lToplamMiktar, tbAlisVeris.lPesinat, tbAlisVeris.lNetTutar, tbAlisVeris.dteKayitTarihi, tbMusteri.sAdi  , tbMusteri.sSoyadi, tbMusteri.sGSM, tbAlisVeris.nAlisverisID HAVING (ISNULL(ISNULL(SUM(tbTaksit.lTutari), 0) - ISNULL(SUM(tbOdeme.odeme), 0), 0) <> 0)ORDER BY tbAlisVeris.dteFaturaTarihi  ")
            cmd.CommandText = sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT tbalisveris.nAlisverisID,tbalisveris.nMusteriID,tbalisveris.lNetTutar,tbalisveris.lPesinat,tbMusteri.lKodu,tbMusteri.sAdi + ' ' + tbMusteri.sSoyadi AS sAdi, ISNULL (tbAlisveris.lNetTutar - SUM (DISTINCT lOdemeTutar) ,0) as KALAN, ISNULL (ISNULL (SUM (DISTINCT lOdemeTutar),0)  ,0)  As TAKSIT from tbAlisVeris INNER JOIN tbMusteri ON tbalisveris.nMusteriID = tbMusteri.nMusteriID INNER JOIN tbAlisverisSiparis ON tbAlisVeris.nAlisverisID = tbAlisverisSiparis.nAlisverisID INNER JOIN tbOdeme ON tbAlisverisSiparis.nAlisverisID = tbOdeme.nAlisverisID where tbAlisverisSiparis.bTeslimEdildi = '0' group by tbalisveris.nAlisverisID,tbalisveris.nMusteriID,tbalisveris.lNetTutar,tbalisveris.lPesinat,tbMusteri.sAdi,tbMusteri.sSoyadi,tbMusteri.lKodu order by tbMusteri.sAdi + ' ' + tbMusteri.sSoyadi asc ")
            'cmd.CommandText = sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT tbOdeme.nOdemeID, tbOdeme.nAlisverisID, tbOdeme.sOdemeSekli, tbOdeme.nOdemeKodu, tbOdeme.sKasiyerRumuzu, tbOdeme.dteOdemeTarihi, tbOdeme.dteValorTarihi, tbOdeme.lOdemeTutar, tbOdeme.sDovizCinsi, tbOdeme.lDovizTutar, tbOdeme.lMakbuzNo, tbOdeme.lOdemeNo, tbOdeme.nTaksitID, tbOdeme.nIadeAlisverisID, tbOdeme.bMuhasebeyeIslendimi, tbOdeme.nKasaNo, tbOdeme.sKartNo, tbOdeme.sKullaniciAdi, tbOdeme.dteKayitTarihi, tbOdeme.sMagaza, tbMusteri.nMusteriID, tbMusteri.lKodu, tbMusteri.sAdi, tbMusteri.sSoyadi, tbMusteri.sEvAdresi1, tbMusteri.sEvAdresi2, tbMusteri.sEvSemt, tbMusteri.sEvPostaKodu, tbMusteri.sEvIl, tbMusteri.sEvTelefonu, tbMusteri.sGSM FROM tbOdeme INNER JOIN tbMusteri ON tbOdeme.sKartNo = tbMusteri.nMusteriID " & kriter & "")
            'cmd.CommandText = sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT tbMusteri.nMusteriID, tbMusteri.sGsm, tbMusteri.lKodu AS kodu, ISNULL(SUM(tbTaksit.lTutari), 0) AS TUTAR, ISNULL(SUM(tbOdeme.odeme), 0) AS TAHSILAT, ISNULL(ISNULL(SUM(tbTaksit.lTutari), 0) - ISNULL(SUM(tbOdeme.odeme), 0), 0) AS KALAN,  CAST(MONTH(dteTarihi) AS VARCHAR(2)) + '.' + DATENAME(month, dteTarihi) AS AY, YEAR(tbTaksit.dteTarihi) AS YIL, tbTaksit.dteTarihi, tbAlisVeris.sFisTipi, tbAlisVeris.dteFaturaTarihi, tbAlisVeris.lFaturaNo, tbAlisVeris.lToplamMiktar, tbAlisVeris.lPesinat, tbAlisVeris.lNetTutar, tbAlisVeris.sYaziIle, tbAlisVeris.nKasaNo, tbAlisVeris.sKasiyerRumuzu, tbAlisVeris.dteKayitTarihi, tbAlisVeris.nAlisverisID, tbMusteri.sAdi as Ad, tbMusteri.sAdi + ' ' + tbMusteri.sSoyadi AS sAdi, tbMusteri.sSoyadi FROM (SELECT isnull(SUM(lOdemeTutar) , 0) AS odeme , nTaksitId FROM tbOdeme GROUP BY nTaksitId) tbOdeme RIGHT OUTER JOIN tbTaksit INNER JOIN tbAlisVeris ON tbTaksit.nAlisverisID = tbAlisVeris.nAlisverisID INNER JOIN tbMusteri ON tbAlisVeris.nMusteriID = tbMusteri.nMusteriID ON tbOdeme.nTaksitId = tbTaksit.nTaksitID WHERE (tbMusteri.lKodu like '%') and lNetTutar > lPesinat and lNetTutar > lTutari   GROUP BY tbMusteri.nMusteriID, tbMusteri.lKodu, tbTaksit.dteTarihi, tbAlisVeris.sFisTipi, tbAlisVeris.dteFaturaTarihi, tbAlisVeris.lFaturaNo, tbAlisVeris.lToplamMiktar, tbAlisVeris.lPesinat, tbAlisVeris.lNetTutar, tbAlisVeris.sYaziIle, tbAlisVeris.nKasaNo, tbAlisVeris.sKasiyerRumuzu, tbAlisVeris.dteKayitTarihi, tbMusteri.sAdi  , tbMusteri.sSoyadi, tbMusteri.sEvAdresi1, tbMusteri.sEvAdresi2, tbMusteri.sEvSemt, tbMusteri.sEvPostaKodu, tbMusteri.sEvIl, tbMusteri.sEvTelefonu, tbMusteri.sGSM, tbAlisVeris.nAlisverisID, tbMusteri.sAdi, tbMusteri.sSoyadi HAVING (ISNULL(ISNULL(SUM(tbTaksit.lTutari), 0) - ISNULL(SUM(tbOdeme.odeme), 0), 0) <> 0)ORDER BY tbAlisVeris.dteFaturaTarihi, tbAlisVeris.lFaturaNo ")
        ElseIf sec_Odeme_Yapmayan.Checked = True Then
            cmd.CommandText = sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED Select tbMusteri.sAdi + ' ' + tbMusteri.sSoyadi AS sAdi, tbAlisVeris.lNetTutar, tbAlisVeris.lNetTutar AS KALAN,tbAlisVeris.lPesinat,tbMusteri.lKodu from tbAlisverisSiparis inner join tbAlisVeris ON tbAlisverisSiparis.nAlisverisID = tbAlisVeris.nAlisverisID inner join tbMusteri ON tbalisveris.nMusteriID = tbMusteri.nMusteriID where tbAlisverisSiparis.bTeslimEdildi = '1' and tbAlisverisSiparis.nAlisverisID NOT IN (SELECT tbOdeme.nAlisverisID FROM tbOdeme) group by tbAlisVeris.nAlisverisID, tbMusteri.sAdi, tbMusteri.sSoyadi,tbAlisVeris.lNetTutar,tbAlisVeris.lPesinat,tbMusteri.lKodu order by tbMusteri.sAdi + ' ' + tbMusteri.sSoyadi asc ")
        Else
            cmd.CommandText = sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT tbalisveris.nAlisverisID,tbalisveris.nMusteriID,tbalisveris.lNetTutar,tbalisveris.lPesinat,tbMusteri.lKodu,tbMusteri.sAdi + ' ' + tbMusteri.sSoyadi AS sAdi, ISNULL (tbAlisveris.lNetTutar - SUM (DISTINCT lOdemeTutar) ,0) as KALAN, ISNULL (ISNULL (SUM (DISTINCT lOdemeTutar),0)  ,0)  As TAKSIT from tbAlisVeris INNER JOIN tbMusteri ON tbalisveris.nMusteriID = tbMusteri.nMusteriID INNER JOIN tbAlisverisSiparis ON tbAlisVeris.nAlisverisID = tbAlisverisSiparis.nAlisverisID INNER JOIN tbOdeme ON tbAlisverisSiparis.nAlisverisID = tbOdeme.nAlisverisID where tbAlisverisSiparis.bTeslimEdildi = '1' group by tbalisveris.nAlisverisID,tbalisveris.nMusteriID,tbalisveris.lNetTutar,tbalisveris.lPesinat,tbMusteri.sAdi,tbMusteri.sSoyadi,tbMusteri.lKodu order by tbMusteri.sAdi + ' ' + tbMusteri.sSoyadi asc ")
        End If
        Dim lBekleyen As Int64 = sorgu_lBekleyen_kontrol(nMusteriID)
        If lBekleyen > 0 Then
            cmd.Connection = conn
            conn.Open()
            Dim Datastoklar1 As New DataSet
            Dim N As Integer = adapter.Fill(Datastoklar1, "Table1")
            conn.Close()
            Return Datastoklar1
        Else
        End If
    End Function
    Private Function sorgu_query(ByVal query As String) As String
        query = Replace(query, "*!F", "F0" + firmano.ToString)
        query = Replace(query, "!D", "D000" + donemno.ToString)
        Return query
    End Function
    Private Sub dataload()
        Dim dataset1 As New DataSet
        dataset1 = stok()
        GridControl1.DataSource = dataset1.Tables(0)
        GridControl1.DataMember = Nothing
        PanelControl3.Select()
        GridControl1.Focus()
        GridControl1.Select()
        GridView1.CollapseAllGroups()
    End Sub
    Private Sub analiz_musteri_karti()
        If GridView1.RowCount > 0 Then
            Dim dr As DataRow = GridView1.GetDataRow(GridView1.FocusedRowHandle)
            Dim frm As New frm_musteri_karti
            frm.firmano = firmano
            frm.donemno = donemno
            frm.connection = connection
            frm.musterino = dr("lKodu")
            frm.musteriID = dr("nMusteriID")
            frm.kullanici = kullanici
            If yetki_kontrol(kullanici, frm.Name) = True Then
                frm.ShowDialog()
            End If
            frm.Close()
            frm.Dispose()
            frm = Nothing
        End If
    End Sub
    Private Sub SimpleButton2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SimpleButton2.Click
        Me.Close()
    End Sub
    Private Sub MenuItem9_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem9.Click
        If Me.WindowState = FormWindowState.Normal Then
            Me.WindowState = FormWindowState.Maximized
        ElseIf Me.WindowState = FormWindowState.Maximized Then
            Me.WindowState = FormWindowState.Normal
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
            Label2.Text = Sorgu_sDil("Kayıt Sayısı :", sDil) & GridView1.RowCount & " / " & Sorgu_sDil("Satır :", sDil) & GridView1.FocusedRowHandle + 1 & " / " & Sorgu_sDil("Seçili :", sDil) & GridView1.SelectedRowsCount
        ElseIf GridView1.SelectedRowsCount = 1 Then
            Label2.Text = Sorgu_sDil("Kayıt Sayısı :", sDil) & GridView1.RowCount & " / " & Sorgu_sDil("Satır :", sDil) & GridView1.FocusedRowHandle + 1
        Else
            Label2.Text = ""
        End If
    End Sub
    Private Sub GridControl1_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles GridControl1.KeyDown
        If e.KeyCode = Keys.Escape Then
            'If XtraMessageBox.Show(Sorgu_sDil("Açık Faturalar Kontrol Ekranından Çıkmak İstediğinize Emin misiniz...?",sDil), MessageBoxButtons.YesNo, MessageBoxIcon.Question,sorgu_sDil("Dikkat",sDil)) = MsgBoxResult.Yes Then
            Me.Close()
            'End If
        End If
    End Sub
    Private Sub SimpleButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SimpleButton1.Click
        sorgula()
    End Sub
    Private Sub sorgula()
        If status = True Then
            Me.DialogResult = Windows.Forms.DialogResult.OK
            Me.Close()
        Else
            Me.Close()
        End If
    End Sub
    Private Sub MenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem1.Click
        GridView1.ColumnsCustomization()
    End Sub
    Private Sub MenuItem3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem3.Click
        gorunum_kaydet()
    End Sub
    Private Sub MenuItem4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem4.Click
        gorunum_yazdir()
    End Sub
    Private Sub MenuItem5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem5.Click
        If MenuItem5.Checked = False Then
            GridView1.OptionsView.ShowFilterPanelMode = DevExpress.XtraGrid.Views.Base.ShowFilterPanelMode.Default
            GridView1.OptionsCustomization.AllowFilter = True
            MenuItem5.Checked = True
        ElseIf MenuItem5.Checked = True Then
            GridView1.OptionsView.ShowFilterPanelMode = DevExpress.XtraGrid.Views.Base.ShowFilterPanelMode.Never
            GridView1.OptionsCustomization.AllowFilter = False
            MenuItem5.Checked = False
        End If
    End Sub
    Private Sub MenuItem6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem6.Click
        If MenuItem6.Checked = False Then
            GridView1.OptionsView.ShowGroupPanel = True
            GridView1.OptionsCustomization.AllowGroup = True
            MenuItem6.Checked = True
        ElseIf MenuItem6.Checked = True Then
            GridView1.OptionsView.ShowGroupPanel = False
            GridView1.OptionsCustomization.AllowGroup = False
            MenuItem6.Checked = False
        End If
    End Sub
    Private Sub MenuItem7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem7.Click
        GridView1.ExpandAllGroups()
    End Sub
    Private Sub MenuItem8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem8.Click
        GridView1.CollapseAllGroups()
    End Sub
    Private Sub MenuItem13_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem13.Click
        sorgula()
    End Sub
    Private Sub MenuItem14_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem14.Click
        Me.Close()
    End Sub
    Private Sub BarButtonItem2_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem2.ItemClick
        gorunum_yazdir()
    End Sub
    Private Sub BarButtonItem1_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem1.ItemClick
        analiz_musteri_karti()
    End Sub
    Private Sub MenuItem16_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem16.Click
        analiz_musteri_karti()
    End Sub
    Private Sub MenuItem17_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem17.Click
        If GridView1.RowCount > 0 Then
            Dim dr As DataRow = GridView1.GetDataRow(GridView1.FocusedRowHandle)
            If yetki_kontrol(kullanici, "frm_perakende_sil") = True Then
                If XtraMessageBox.Show(Sorgu_sDil("Satırı Silmek İstediğinize Emin misiniz...?", sDil), Sorgu_sDil("Dikkat", sDil), MessageBoxButtons.YesNo, MessageBoxIcon.Question) = MsgBoxResult.Yes Then
                    If tbOdeme_kaydet_sil(dr("nOdemeID")) = True Then
                        dataload()
                        XtraMessageBox.Show(Sorgu_sDil("İşlem Başarıyla Tamamlandı...!", sDil), Sorgu_sDil("Dikkat", sDil))
                    End If
                End If
            End If
        End If
    End Sub
    Private Function tbOdeme_kaydet_sil(ByVal nOdemeID As String) As Boolean
        Dim con As New OleDb.OleDbConnection
        Dim cmd As New OleDb.OleDbCommand
        cmd.Connection = con
        con.ConnectionString = connection
        If con.State = ConnectionState.Closed = True Then
            con.Open()
        End If
        Dim bDevam As Boolean = False
        Try
            cmd.CommandText = sorgu_query("SET DATEFORMAT DMY SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED DELETE    tbOdeme  Where nOdemeID = '" & nOdemeID & "'")
            cmd.ExecuteNonQuery()
            bDevam = True
            'If bFisYenimi = True Then
            '    cmd.CommandText = sorgu_query("SET DATEFORMAT DMY SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED DELETE FROM         auOdeme WHERE     (nOdemeID = '" & nOdemeID & "') AND (nKayitTipi = 3)")
            '    cmd.ExecuteNonQuery()
            'End If
            bDevam = True
        Catch ex As Exception
            XtraMessageBox.Show(ex.Message.ToString, Sorgu_sDil("Dikkat", sDil), MessageBoxButtons.OK, MessageBoxIcon.Warning)
            bDevam = False
        End Try
        con.Close()
        cmd = Nothing
        con = Nothing
        Return bDevam
    End Function
    Private Sub raporla_excel()
        If XtraMessageBox.Show(Sorgu_sDil("Sonuçları Excel Dosyası Oluşturmak İstediğinize Emin misiniz...?", sDil), Sorgu_sDil("Dikkat", sDil), MessageBoxButtons.YesNo, MessageBoxIcon.Question) = MsgBoxResult.Yes Then
            Dim SaveFileDialog1 As New Windows.Forms.SaveFileDialog
            SaveFileDialog1.Filter = "Excel Dosyaları(*.xls) |*.xls"
            SaveFileDialog1.InitialDirectory = "c:\"
            SaveFileDialog1.FileName = "Rapor.xls"
            If SaveFileDialog1.ShowDialog = Windows.Forms.DialogResult.OK Then
                GridView1.ExportToXls(SaveFileDialog1.FileName.ToString)
                If XtraMessageBox.Show(Sorgu_sDil("Kaydı Açmak İster misiniz...?", sDil), Sorgu_sDil("Dikkat", sDil), MessageBoxButtons.YesNo, MessageBoxIcon.Question) = MsgBoxResult.Yes Then
                    Process.Start(SaveFileDialog1.FileName.ToString)
                End If
            End If
            SaveFileDialog1 = Nothing
        End If
    End Sub
    Private Sub BarButtonItem3_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem3.ItemClick
        raporla_excel()
    End Sub


    Private Sub SimpleButton3_Click(sender As Object, e As EventArgs) Handles SimpleButton3.Click

        dataload()
    End Sub
    Private Sub sec_Teslimedilmeyen_CheckStateChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles sec_Teslimedilmeyen.CheckStateChanged
        If sec_Teslimedilmeyen.Checked = True Then
            sec_Odeme_Yapmayan.Checked = False
            dataload()
        End If
    End Sub
    Private Sub sec_Odeme_Yapmayan_CheckStateChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles sec_Odeme_Yapmayan.CheckStateChanged
        If sec_Odeme_Yapmayan.Checked = True Then
            sec_Teslimedilmeyen.Checked = False
            dataload()
        End If
    End Sub
End Class