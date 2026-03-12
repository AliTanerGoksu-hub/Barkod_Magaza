Imports DevExpress.XtraEditors
Public Class frm_Perakende_VadeDuzenle
    Public firmano
    Public donemno
    Public connection
    Public nMusteriID As String
    Dim DR As DataRow
    Dim dr_taksit As DataRow
    Dim ds_taksit As DataSet
    Dim dr_hareket As DataRow
    Dim ds_taksit_info As DataSet
    Dim cmd As New OleDb.OleDbCommand
    Dim con As New OleDb.OleDbConnection
    Dim adapter As New OleDb.OleDbDataAdapter
    Dim lKalanTutar As Decimal = 0
    Dim lMaxTutar As Decimal = 0
    Dim dteFisTarihi As DateTime = "01/01/1900"
    Private Sub frm_Perakende_VadeDuzenle_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        dataload_taksit(nMusteriID)
    End Sub
    Private Sub degeryay(ByVal columnkriter As String)
        Dim durum
        Dim sayi = GridView1.RowCount  'kl.Count
        Dim satir = GridView1.FocusedRowHandle 'kl.Position
        Dim TOPLAM = sayi - GridView1.FocusedRowHandle 'kl.Position
        Dim t As Int64
        Dim Ý As Integer
        Ý = 0
        dr_hareket = GridView1.GetDataRow(GridView1.FocusedRowHandle)
        durum = dr_hareket("" & columnkriter & "")
        For Ý = 1 To TOPLAM
            'dr_hareket = GridView2.GetDataRow(GridView2.FocusedRowHandle)
            'dr_hareket.BeginEdit()
            'dr_hareket("" & columnkriter & "") = durum
            'dr_hareket.EndEdit()
            t += 1
            If columnkriter = "dteTarihi" Then
                GridView1.PostEditor()
                DR = GridView1.GetDataRow(GridView1.FocusedRowHandle)
                If t > 1 Then
                    durum = DateAdd(DateInterval.Month, 1, durum)
                Else
                    durum = durum
                End If
                DR("" & columnkriter & "") = durum
                DR.EndEdit()
            ElseIf columnkriter = "lTutari" Then
                GridView1.PostEditor()
                DR = GridView1.GetDataRow(GridView1.FocusedRowHandle)
                DR("" & columnkriter & "") = durum
                DR.EndEdit()
            End If
            tbTaksit_hesapla()
            'toplam_hesapla()
            GridView1.FocusedRowHandle += 1
        Next
        GridView1.FocusedRowHandle = satir
        GridView1.GetDataRow(satir)
        durum = Nothing
        sayi = Nothing
        satir = Nothing
        Ý = Nothing
    End Sub
    Private Sub taksit_satir_info()
        If GridView1.RowCount > 0 Then
            Dim dr As DataRow
            dr = GridView1.GetDataRow(GridView1.FocusedRowHandle)
            ds_taksit_info = sorgu(sorgu_query("SELECT *, (SELECT ISNULL(SUM(lOdemeTutar) , 0) FROM tbOdeme WHERE nTaksitID = tbTaksit.nTaksitID) AS Tahsilat FROM tbTaksit Where nTaksitID ='" & dr("nTaksitID") & "'"))
            dr = Nothing
            Dim dr_taksit As DataRow
            Try
                dr_taksit = ds_taksit_info.Tables(0).Rows(0)
                If dr_taksit("Tahsilat") <> 0 Then
                    coldteTarihi.OptionsColumn.AllowEdit = False
                    collTutari.OptionsColumn.AllowEdit = False
                    'MenuItem6.Enabled = False
                    'dr_taksit("Status") = 1
                Else
                    coldteTarihi.OptionsColumn.AllowEdit = True
                    collTutari.OptionsColumn.AllowEdit = True
                    'MenuItem6.Enabled = True
                    'dr_taksit("Status") = 0
                End If
                lblTaksit_info.Text = "TaksitTarihi: " & dr_taksit("dteTarihi") & " Taksit Tutarý: " & dr_taksit("lTutari") & " Tahsil Edilen: " & dr_taksit("Tahsilat") & " Kalan: " & dr_taksit("lTutari") - dr_taksit("Tahsilat")
                txt_lTutari.EditValue = dr_taksit("lTutari") - dr_taksit("Tahsilat")
                lMaxTutar = txt_lTutari.EditValue
            Catch ex As Exception
                lblTaksit_info.Text = "***"
            End Try
            dr_taksit = Nothing
            dr = Nothing
        End If
    End Sub
    Private Sub tbTaksit_hesapla()
        If GridView1.RowCount > 0 Then
            GridView1.PostEditor()
            DR = GridView1.GetDataRow(GridView1.FocusedRowHandle)
            Dim satir = GridView1.FocusedRowHandle
            If DR("lTutari") = 0 Then
                DR("lTutari") = 0.01
            End If
            If DR("dteTarihi") < dteFisTarihi Then
                DR("dteTarihi") = dteFisTarihi
            End If
            If GridView1.FocusedRowHandle = 0 Then
                'If dr("dteTarihi") > DateAdd(DateInterval.Day, 40, dteFisTarihi) Then
                '    dr("dteTarihi") = DateAdd(DateInterval.Day, 40, dteFisTarihi)
                'End If
            Else
                Dim dr_ilk As DataRow = GridView1.GetDataRow(0)
                Dim ilktarih As DateTime = dr_ilk("dteTarihi")
                'If dr("dteTarihi") > DateAdd(DateInterval.Month, (GridView1.FocusedRowHandle + 1), ilktarih) Then
                '    dr("dteTarihi") = DateAdd(DateInterval.Month, (GridView1.FocusedRowHandle + 1), ilktarih)
                'End If
                dr_ilk = Nothing
                ilktarih = Nothing
            End If
            DR.EndEdit()
            tbTaksit_kaydet_degistir(DR("nTaksitID"), DR("nAlisVerisID"), DR("dteTarihi"), DR("lTutari"))
            'toplam_hesapla()
            If lKalanTutar < 0 Then
                GridView1.FocusedRowHandle = GridView1.RowCount - 1
                GridView1.PostEditor()
                DR = GridView1.GetDataRow(GridView1.FocusedRowHandle)
                DR("lTutari") = lKalanTutar + DR("lTutari")
                DR.EndEdit()
                tbTaksit_kaydet_degistir(DR("nTaksitID"), DR("nAlisVerisID"), DR("dteTarihi"), DR("lTutari"))
            ElseIf lKalanTutar > 0 Then
                GridView1.FocusedRowHandle = GridView1.RowCount - 1
                GridView1.PostEditor()
                DR = GridView1.GetDataRow(GridView1.FocusedRowHandle)
                DR("lTutari") = lKalanTutar + DR("lTutari")
                DR.EndEdit()
                tbTaksit_kaydet_degistir(DR("nTaksitID"), DR("nAlisVerisID"), DR("dteTarihi"), DR("lTutari"))
            End If
            'toplam_hesapla()
            GridView1.FocusedRowHandle = satir
            satir = Nothing
        End If
    End Sub
    Private Sub dataload_taksit(ByVal nMusteriID As String)
        ds_taksit = sorgu(sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT ISNULL(SUM(tbTaksit.lTutari), 0) AS lTaksit, ISNULL(SUM(tbOdeme.odeme), 0) AS lTahsilat, ISNULL(ISNULL(SUM(tbTaksit.lTutari), 0) - ISNULL(SUM(tbOdeme.odeme), 0), 0) AS lTutari, tbTaksit.dteTarihi, tbTaksit.nTaksitID, ROUND(CAST(GETDATE() - (CAST(tbTaksit.dteTarihi AS INT) + 1) AS FLOAT), 0) AS nGecikme, tbTaksit.nAlisverisID,tbAlisVeris.sMagaza FROM (SELECT isnull(SUM(lOdemeTutar) , 0) AS odeme , nTaksitId FROM tbOdeme GROUP BY nTaksitId) tbOdeme RIGHT OUTER JOIN tbTaksit INNER JOIN tbAlisVeris ON tbTaksit.nAlisverisID = tbAlisVeris.nAlisverisID INNER JOIN tbMusteri ON tbAlisVeris.nMusteriID = tbMusteri.nMusteriID ON tbOdeme.nTaksitId = tbTaksit.nTaksitID WHERE (tbMusteri.nMusteriID = '" & nMusteriID & "') GROUP BY tbTaksit.dteTarihi, tbAlisVeris.sFisTipi, tbAlisVeris.sAlisverisYapanAdi, tbAlisVeris.sAlisverisYapanSoyadi, tbAlisVeris.sYaziIle, tbAlisVeris.sKasiyerRumuzu, tbMusteri.sAdi, tbMusteri.sSoyadi, tbAlisVeris.nAlisverisID, tbTaksit.nTaksitID, tbTaksit.nAlisverisID,tbAlisVeris.sMagaza HAVING (ISNULL(ISNULL(SUM(tbTaksit.lTutari), 0) - ISNULL(SUM(tbOdeme.odeme), 0), 0) <> 0) ORDER BY tbTaksit.dteTarihi "))
        GridControl1.DataMember = Nothing
        GridControl1.DataSource = ds_taksit.Tables(0)
    End Sub
    Private Sub tbTaksit_ekle_toplu(ByVal nAlisVerisID As String, ByVal sMagaza As String, ByVal dteBaslangic As DateTime, ByVal TaksitSayisi As Int64, ByVal TaksitTutari As Decimal)
        Dim i As Integer
        Dim dteTarihi As DateTime
        Dim nTaksitID As String = ""
        For i = 1 To TaksitSayisi
            DR = ds_taksit.Tables(0).NewRow
            If i > 1 Then
                dteTarihi = DateAdd(DateInterval.Month, 1, dteTarihi)
            Else
                dteTarihi = dteBaslangic
            End If
            nTaksitID = sorgu_nTaksitID(sMagaza)
            DR("nTaksitID") = sMagaza & nTaksitID
            DR("nAlisVerisID") = nAlisVerisID
            DR("dteTarihi") = dteTarihi
            DR("lTutari") = TaksitTutari
            tbTaksit_kaydet_yeni(DR("nTaksitID"), DR("nAlisVerisID"), DR("dteTarihi"), DR("lTutari"))
            'ds_taksit.Tables(0).Rows.Add(DR)
            tbAvSirano_degistir(3, nTaksitID, sMagaza)
            'toplam_hesapla()
        Next
        nTaksitID = Nothing
        i = Nothing
        dteTarihi = Nothing
    End Sub
    'Public Function sorgu_nTaksitID(ByVal sDepo As String) As Int64
    '    'kriter = "WHERE (sKodu = '" & kod & "')  "
    '    Dim conn As New OleDb.OleDbConnection
    '    Dim cmd As New OleDb.OleDbCommand
    '    Dim adapter As New OleDb.OleDbDataAdapter
    '    'MsgBox(connection_resmi)
    '    conn.ConnectionString = connection
    '    cmd.Connection = conn
    '    conn.Open()
    '    cmd.CommandText = sorgu_query("SET DATEFORMAT DMY SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT nSonID + 1 AS nSonID FROM tbAVSiraNo WHERE (sDepo = '" & sDepo & "') AND (nSiraIndex = 3)")
    '    Dim kayitsayisi = cmd.ExecuteScalar
    '    Return kayitsayisi
    'End Function
    Private Sub tbAvSirano_degistir(ByVal nSiraIndex As Integer, ByVal nSonID As Int64, ByVal sDepo As String)
        'kriter = "WHERE (sFisTipi = '" & sFistipi & "') and (dteFisTarihi = '" & dteFisTarihi & "') and (lFisNo = '" & lFisno & "') and (nFirmaID= '" & nFirmaID & "') and (nGirisCikis = '" & nGirisCikis & "')  "
        'sorgu(sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT     * FROM         tbFirmaHareketi " & kriter & ""))
        Dim conn As New OleDb.OleDbConnection
        Dim cmd As New OleDb.OleDbCommand
        Dim adapter As New OleDb.OleDbDataAdapter
        conn.ConnectionString = connection
        cmd.Connection = conn
        If conn.State = ConnectionState.Closed Then
            conn.Open()
        End If
        cmd.CommandText = sorgu_query("SET DATEFORMAT DMY SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED UPDATE    tbAvSiraNo SET              nSonID = '" & nSonID & "' where nSiraIndex = " & nSiraIndex & " and sDepo = '" & sDepo & "'")
        cmd.ExecuteNonQuery()
        conn.Close()
    End Sub
    'Private Sub tbTaksit_kaydet_yeni(ByVal nTaksitID As String, ByVal nAlisverisID As String, ByVal dteTarihi As String, ByVal lTutari As Decimal)
    '    cmd.Connection = con
    '    con.ConnectionString = connection
    '    If con.State = ConnectionState.Closed = True Then
    '        con.Open()
    '    End If
    '    cmd.CommandText = sorgu_query("SET DATEFORMAT DMY SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED INSERT INTO tbTaksit (nTaksitID, nAlisverisID, dteTarihi, lTutari) VALUES     ('" & nTaksitID & "', '" & nAlisverisID & "', '" & dteTarihi & "', " & lTutari & ")")
    '    cmd.ExecuteNonQuery()
    '    con.Close()
    'End Sub
    'Private Sub tbTaksit_kaydet_degistir(ByVal nTaksitID As String, ByVal nAlisverisID As String, ByVal dteTarihi As String, ByVal lTutari As Decimal)
    '    cmd.Connection = con
    '    con.ConnectionString = connection
    '    If con.State = ConnectionState.Closed = True Then
    '        con.Open()
    '    End If
    '    cmd.CommandText = sorgu_query("SET DATEFORMAT DMY SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED UPDATE    tbTaksit SET              dteTarihi = '" & dteTarihi & "', lTutari = " & lTutari & " Where nTaksitID = '" & nTaksitID & "' and nAlisVerisID = '" & nAlisverisID & "'")
    '    cmd.ExecuteNonQuery()
    '    con.Close()
    'End Sub
    Private Function sorgu(ByVal query As String) As DataSet
        Dim conn As New OleDb.OleDbConnection
        Dim cmd As New OleDb.OleDbCommand
        Dim adapter As New OleDb.OleDbDataAdapter
        conn.ConnectionString = connection
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
    Private Function sorgu_query(ByVal query As String) As String
        query = Replace(query, "*!F", "F0" + firmano.ToString)
        query = Replace(query, "!D", "D000" + donemno.ToString)
        Return query
    End Function
    Private Sub GridControl1_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles GridControl1.KeyDown
        If e.KeyCode = Keys.Escape Then
            Me.Close()
        ElseIf e.KeyCode = Keys.F9 Then
            If GridView1.RowCount > 0 Then
                If XtraMessageBox.Show(Sorgu_sDil("[" & GridView1.FocusedColumn().Caption & "] Kolonundaki verileri Aþaðý Doðru Yaymak istediðinize Emin misiniz...?", sDil), Sorgu_sDil("Dikkat", sDil), MessageBoxButtons.YesNo, MessageBoxIcon.Question) = MsgBoxResult.Yes Then
                    degeryay(GridView1.FocusedColumn().FieldName)
                End If
            End If
        ElseIf e.KeyCode = Keys.F8 Then
            If GridView1.RowCount > 0 Then
                If XtraMessageBox.Show(Sorgu_sDil("Taksit Parcalama Ýslemi Yapmak Ýstediginize Emin misiniz...?", sDil), Sorgu_sDil("Dikkat", sDil), MessageBoxButtons.YesNo, MessageBoxIcon.Question) = MsgBoxResult.Yes Then
                    Dim dr As DataRow = GridView1.GetDataRow(GridView1.FocusedRowHandle)
                    tbTaksit_ekle_toplu(dr("nAlisVerisID"), dr("sMagaza"), dr("dteTarihi"), 1, dr("lTutari"))
                    GridView1.PostEditor()
                    dr("lTutari") = dr("lTahsilat")
                    dr.EndEdit()
                    tbTaksit_hesapla()
                    dataload_taksit(nMusteriID)
                End If
            End If
        End If
    End Sub
    Private Sub GridView1_CellValueChanged(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs) Handles GridView1.CellValueChanged
        If GridView1.RowCount > 0 Then
            GridView1.PostEditor()
            DR = GridView1.GetDataRow(GridView1.FocusedRowHandle)
            DR.EndEdit()
            tbTaksit_hesapla()
        End If
    End Sub
    Private Sub SimpleButton2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SimpleButton2.Click
        Me.Close()
    End Sub
    Private Sub SimpleButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SimpleButton1.Click
        Me.Close()
    End Sub
    Private Sub GridView1_FocusedRowChanged(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs) Handles GridView1.FocusedRowChanged
        Try
            taksit_satir_info()
        Catch ex As Exception
        End Try
    End Sub
    Private Sub BarButtonItem1_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem1.ItemClick
        GridControl1.ShowPrintPreview()
    End Sub
    Private Sub SimpleButton3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SimpleButton3.Click
        GroupControl1.Visible = False
        GridControl1.Focus()
        GridControl1.Select()
    End Sub
    Public Function sorgu_nTaksitID(ByVal sDepo As String) As Int64
        Dim conn As New OleDb.OleDbConnection
        Dim cmd As New OleDb.OleDbCommand
        Dim adapter As New OleDb.OleDbDataAdapter
        conn.ConnectionString = connection
        cmd.Connection = conn
        conn.Open()
        cmd.CommandText = sorgu_query("SET DATEFORMAT DMY SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT nSonID + 1 AS nSonID FROM tbAVSiraNo WHERE (sDepo = '" & sDepo & "') AND (nSiraIndex = 3)")
        Dim kayitsayisi = cmd.ExecuteScalar
        Return kayitsayisi
    End Function
    Private Sub tbOdeme_kaydet_sil(ByVal nOdemeID As String)
        Dim con As New OleDb.OleDbConnection
        Dim cmd As New OleDb.OleDbCommand
        cmd.Connection = con
        con.ConnectionString = connection
        If con.State = ConnectionState.Closed = True Then
            con.Open()
        End If
        cmd.CommandText = sorgu_query("SET DATEFORMAT DMY SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED DELETE    tbOdeme  Where nOdemeID = '" & nOdemeID & "'")
        cmd.ExecuteNonQuery()
        con.Close()
        cmd = Nothing
        con = Nothing
    End Sub
    Private Sub tbTaksit_kaydet_yeni(ByVal nTaksitID As String, ByVal nAlisverisID As String, ByVal dteTarihi As String, ByVal lTutari As Decimal)
        Dim con As New OleDb.OleDbConnection
        Dim cmd As New OleDb.OleDbCommand
        cmd.Connection = con
        con.ConnectionString = connection
        If con.State = ConnectionState.Closed = True Then
            con.Open()
        End If
        cmd.CommandText = sorgu_query("SET DATEFORMAT DMY SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED INSERT INTO tbTaksit (nTaksitID, nAlisverisID, dteTarihi, lTutari) VALUES     ('" & nTaksitID & "', '" & nAlisverisID & "', '" & dteTarihi & "', " & lTutari & ")")
        cmd.ExecuteNonQuery()
        con.Close()
        cmd = Nothing
        con = Nothing
    End Sub
    Private Sub tbTaksit_kaydet_degistir(ByVal nTaksitID As String, ByVal nAlisverisID As String, ByVal dteTarihi As String, ByVal lTutari As Decimal)
        Dim con As New OleDb.OleDbConnection
        Dim cmd As New OleDb.OleDbCommand
        cmd.Connection = con
        con.ConnectionString = connection
        If con.State = ConnectionState.Closed = True Then
            con.Open()
        End If
        cmd.CommandText = sorgu_query("SET DATEFORMAT DMY SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED UPDATE    tbTaksit SET              dteTarihi = '" & dteTarihi & "', lTutari = " & lTutari & " Where nTaksitID = '" & nTaksitID & "' and nAlisVerisID = '" & nAlisverisID & "'")
        cmd.ExecuteNonQuery()
        con.Close()
        cmd = Nothing
        con = Nothing
    End Sub
    Private Sub tbTaksit_kaydet_sil(ByVal nTaksitID As String, ByVal nAlisverisID As String)
        Dim con As New OleDb.OleDbConnection
        Dim cmd As New OleDb.OleDbCommand
        cmd.Connection = con
        con.ConnectionString = connection
        If con.State = ConnectionState.Closed = True Then
            con.Open()
        End If
        Dim nKayit As Integer = sorgula_nStokID("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED Select COUNT(nTaksitID) from tbOdeme Where nTaksitID = '" & nTaksitID & "'")
        If nKayit = 0 Then
            cmd.CommandText = sorgu_query("SET DATEFORMAT DMY SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED DELETE    tbTaksit Where nTaksitID = '" & nTaksitID & "' and nAlisVerisID = '" & nAlisverisID & "'")
            cmd.ExecuteNonQuery()
        Else
            XtraMessageBox.Show("Ýþlem Görmüþ Taksit Kaydýný Silemezsiniz...!", Sorgu_sDil("Dikkat", sDil), MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If
        con.Close()
        cmd = Nothing
        con = Nothing
    End Sub
    Private Sub Taksit_parcala()
        Dim dr As DataRow
        dr = GridView1.GetDataRow(GridView1.FocusedRowHandle)
        tbTaksit_kaydet_degistir(dr("nTaksitID"), dr("nAlisVerisID"), dr("dteTarihi"), dr("lTutari") - txt_lTutari.EditValue)
        Dim nTaksitIDD As String
        nTaksitIDD = sorgu_nTaksitID(sDepo)
        tbTaksit_kaydet_yeni(sDepo & nTaksitIDD, dr("nAlisVerisID"), DateEdit1.EditValue, txt_lTutari.EditValue)
        tbAvSirano_degistir(3, nTaksitIDD, sDepo)
        dataload_taksit(nMusteriID)
        GroupControl1.Visible = False
        GridControl1.Select()
    End Sub
    Private Sub SimpleButton4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SimpleButton4.Click
        Taksit_parcala()
    End Sub
    Private Sub txt_lTutari_Validated(ByVal sender As Object, ByVal e As System.EventArgs) Handles txt_lTutari.Validated
        If txt_lTutari.EditValue > lMaxTutar Then
            txt_lTutari.EditValue = lMaxTutar
        End If
    End Sub
    Private Sub BarButtonItem2_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem2.ItemClick
        Dim dr As DataRow
        dr = GridView1.GetDataRow(GridView1.FocusedRowHandle)
        DateEdit1.EditValue = dr("dteTarihi")
        'txt_lTutari.EditValue = dr("lTutari")
        'lMaxTutar = txt_lTutari.EditValue
        GroupControl1.Visible = True
        DateEdit1.Focus()
        DateEdit1.Select()
    End Sub
End Class