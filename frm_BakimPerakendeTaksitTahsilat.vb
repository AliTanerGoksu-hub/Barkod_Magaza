Imports DevExpress.XtraEditors
Imports System.Threading
Public Class frm_BakimPerakendeTaksitTahsilat
    Public firmano
    Public donemno
    Public connection
    Public musterino
    Public kullanici
    Dim loaded As Boolean
    Dim dataset1 As New DataSet
    Dim ds_Tahsilatlar As New DataSet
    Dim ds_Taksitler As New DataSet
    Dim sMagaza As String = ""
    Dim lMakbuzNo As Int64 = 0
    Dim lToplamTutar As Decimal = 0
    Dim trd As Thread
    Private Sub dataload()
        MarqueeProgressBarControl1.Visible = True
        System.Windows.Forms.Control.CheckForIllegalCrossThreadCalls = False
        trd = New Threading.Thread(AddressOf dataload_thread)
        trd.IsBackground = True
        trd.Start()
    End Sub
    Private Sub dataload_thread()
        Try
            loaded = False
            dataset1 = stok()
            GridControl1.DataSource = dataset1.Tables(0)
            GridControl1.DataMember = Nothing
            PanelControl3.Select()
            GridControl1.Focus()
            GridControl1.Select()
            GridView1.CollapseAllGroups()
            loaded = True
            MarqueeProgressBarControl1.Visible = False
        Catch ex As Exception
        End Try
    End Sub
    Private Shared Function sorgu_kriter_string(ByVal deger As String, ByVal kriter As String) As String
        Dim sorgu_kriter As String = ""
        If kriter = "Başlar" Then
            sorgu_kriter = String.Format(" LIKE '{0}%' ", deger)
        ElseIf kriter = "Biter" Then
            sorgu_kriter = String.Format(" LIKE '%{0}' ", deger)
        ElseIf kriter = "İçerir" Then
            sorgu_kriter = String.Format(" LIKE '%{0}%' ", deger)
        ElseIf kriter = "Boş" Then
            sorgu_kriter = " IS NULL "
        ElseIf kriter = "Dolu" Then
            sorgu_kriter = " <> '' "
        ElseIf kriter = "Farklı" Then
            sorgu_kriter = String.Format(" <> '{0}' ", deger)
        ElseIf kriter = "Büyük" Then
            sorgu_kriter = String.Format(" >  '{0}' ", deger)
        ElseIf kriter = "Küçük" Then
            sorgu_kriter = String.Format(" < '{0}' ", deger)
        ElseIf kriter = "Eşittir" Then
            sorgu_kriter = String.Format(" = '{0}' ", deger)
        End If
        Return sorgu_kriter
    End Function
    Public Function stok() As DataSet
        Dim kriter As Object = ""
        Dim conn As New OleDb.OleDbConnection
        Dim cmd As New OleDb.OleDbCommand
        Dim adapter As New OleDb.OleDbDataAdapter
        conn.ConnectionString = connection
        cmd.CommandTimeout = False
        adapter.SelectCommand = cmd
        cmd.CommandText = sorgu_query("set dateformat dmy SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT SUM(tbOdeme.lOdemeTutar) AS lTahsilat, tbAlisVeris.nAlisverisID, tbOdeme.nTaksitID, tbTaksit.lTutari, tbMusteri.nMusteriID, tbMusteri.lKodu, (tbMusteri.sAdi + ' ' + tbMusteri.sSoyadi) as MusteriAdi, tbAlisVeris.dteFaturaTarihi, tbAlisVeris.sKullaniciAdi, tbAlisVeris.sKullaniciUpdate, tbAlisVeris.sKasiyerRumuzu, tbAlisVeris.sMagaza, SUM(tbOdeme.lOdemeTutar) - tbTaksit.lTutari AS lFazlaTahsilat FROM tbOdeme INNER JOIN tbTaksit ON tbOdeme.nTaksitID = tbTaksit.nTaksitID INNER JOIN tbAlisVeris ON tbOdeme.nAlisverisID = tbAlisVeris.nAlisverisID INNER JOIN tbMusteri ON tbAlisVeris.nMusteriID = tbMusteri.nMusteriID WHERE (tbOdeme.nOdemeKodu = 2) GROUP BY tbAlisVeris.nAlisverisID, tbOdeme.nTaksitID, tbTaksit.lTutari, tbMusteri.nMusteriID, tbMusteri.lKodu, tbMusteri.sAdi, tbMusteri.sSoyadi, tbAlisVeris.dteFaturaTarihi, tbAlisVeris.sKullaniciAdi, tbAlisVeris.sKullaniciUpdate, tbAlisVeris.sKasiyerRumuzu, tbAlisVeris.sMagaza HAVING (SUM(tbOdeme.lOdemeTutar) > tbTaksit.lTutari)")
        cmd.Connection = conn
        conn.Open()
        Dim Datastoklar1 As New DataSet
        Dim N As Integer = adapter.Fill(Datastoklar1, "Table1")
        conn.Close()
        Return Datastoklar1
    End Function
    Private Function sorgu_query(ByVal query As String) As String
        query = Replace(query, "*!F", "F0" + firmano.ToString)
        query = Replace(query, "!D", "D000" + donemno.ToString)
        Return query
    End Function
    Public Function tbTahsilatlar(ByVal nTaksitID As String) As DataSet
        Dim conn As New OleDb.OleDbConnection
        Dim cmd As New OleDb.OleDbCommand
        Dim adapter As New OleDb.OleDbDataAdapter
        conn.ConnectionString = connection
        adapter.SelectCommand = cmd
        cmd.CommandText = sorgu_query(String.Format("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT * FROM tbOdeme WHERE (nTaksitID = '{0}') and nOdemeKodu =2 ORDER BY dteKayitTarihi DESC", nTaksitID))
        cmd.Connection = conn
        conn.Open()
        Dim Datastoklar1 As New DataSet
        Dim N As Integer = adapter.Fill(Datastoklar1, "DATATABLE1")
        conn.Close()
        Return Datastoklar1
    End Function
    Public Function tbTaksit(ByVal nMusteriID As Int64) As DataSet
        Dim conn As New OleDb.OleDbConnection
        Dim cmd As New OleDb.OleDbCommand
        Dim adapter As New OleDb.OleDbDataAdapter
        conn.ConnectionString = connection
        adapter.SelectCommand = cmd
        cmd.CommandText = sorgu_query(String.Format("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT tbMusteri.nMusteriID, tbMusteri.lKodu AS kodu, ISNULL(SUM(tbTaksit.lTutari), 0) AS TUTAR, ISNULL(SUM(tbOdeme.odeme), 0) AS TAHSILAT, ISNULL(ISNULL(SUM(tbTaksit.lTutari), 0) - ISNULL(SUM(tbOdeme.odeme), 0), 0) AS KALAN, MONTH(tbTaksit.dteTarihi) AS AY, YEAR(tbTaksit.dteTarihi) AS YIL, tbTaksit.dteTarihi, tbAlisVeris.sFisTipi, tbAlisVeris.dteFaturaTarihi, tbAlisVeris.lFaturaNo, tbAlisVeris.lToplamMiktar, tbAlisVeris.lPesinat, tbAlisVeris.lNetTutar, tbAlisVeris.sYaziIle, tbAlisVeris.nKasaNo, tbAlisVeris.sKasiyerRumuzu, tbAlisVeris.dteKayitTarihi, tbAlisVeris.nAlisverisID, tbTaksit.nTaksitID,tbMusteri.sAdi, tbMusteri.sSoyadi,tbAlisVeris.sAlisverisYapanAdi, tbAlisVeris.sAlisverisYapanSoyadi,ROUND(CAST(GETDATE() - (CAST(tbTaksit.dteTarihi AS INT) + 1) AS FLOAT), 0) AS GECIKME FROM (SELECT isnull(SUM(lOdemeTutar) , 0) AS odeme , nTaksitId FROM tbOdeme GROUP BY nTaksitId) tbOdeme RIGHT OUTER JOIN tbTaksit INNER JOIN tbAlisVeris ON tbTaksit.nAlisverisID = tbAlisVeris.nAlisverisID INNER JOIN tbMusteri ON tbAlisVeris.nMusteriID = tbMusteri.nMusteriID ON tbOdeme.nTaksitId = tbTaksit.nTaksitID WHERE (tbMusteri.nMusteriID = {0}) GROUP BY tbMusteri.nMusteriID, tbMusteri.lKodu, tbTaksit.dteTarihi, tbAlisVeris.sFisTipi, tbAlisVeris.dteFaturaTarihi, tbAlisVeris.lFaturaNo,tbAlisVeris.sAlisverisYapanAdi, tbAlisVeris.sAlisverisYapanSoyadi, tbAlisVeris.lToplamMiktar, tbAlisVeris.lPesinat, tbAlisVeris.lNetTutar, tbAlisVeris.sYaziIle, tbAlisVeris.nKasaNo, tbAlisVeris.sKasiyerRumuzu, tbAlisVeris.dteKayitTarihi, tbMusteri.sAdi, tbMusteri.sSoyadi,  tbAlisVeris.nAlisverisID, tbTaksit.nTaksitID HAVING (ISNULL(ISNULL(SUM(tbTaksit.lTutari), 0) - ISNULL(SUM(tbOdeme.odeme), 0), 0) <> 0) ORDER BY tbTaksit.dteTarihi", nMusteriID))
        cmd.Connection = conn
        conn.Open()
        Dim Datastoklar1 As New DataSet
        Dim N As Integer = adapter.Fill(Datastoklar1, "DATATABLE1")
        conn.Close()
        Return Datastoklar1
    End Function
    Public Function sorgu_nOdemeID(ByVal sDepo As String) As Int64
        Dim conn As New OleDb.OleDbConnection
        Dim cmd As New OleDb.OleDbCommand
        Dim adapter As New OleDb.OleDbDataAdapter
        conn.ConnectionString = connection
        cmd.Connection = conn
        conn.Open()
        cmd.CommandText = sorgu_query(String.Format("SET DATEFORMAT DMY SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT nSonID + 1 AS nSonID FROM tbAVSiraNo WHERE (sDepo = '{0}') AND (nSiraIndex = 2)", sDepo))
        'cmd.CommandText = sorgu_query("SET DATEFORMAT DMY SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT TOP 1 ISNULL(REPLACE(nOdemeID, '" & sDepo & "', ''), 0) + 1 AS nOdemeID FROM         tbOdeme WHERE     (sMagaza = '" & sDepo & "') ORDER BY dteOdemeTarihi DESC, nOdemeID DESC")
        Dim kayitsayisi = cmd.ExecuteScalar
        Return kayitsayisi
    End Function
    Public Function sorgu_lMakbuzNo(ByVal sDepo As String) As Int64
        Dim conn As New OleDb.OleDbConnection
        Dim cmd As New OleDb.OleDbCommand
        Dim adapter As New OleDb.OleDbDataAdapter
        conn.ConnectionString = connection
        cmd.Connection = conn
        conn.Open()
        'cmd.CommandText = sorgu_query("SET DATEFORMAT DMY SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT TOP 1 ISNULL(lMakbuzNo, 0) + 1 lMakbuzNo FROM         tbOdeme WHERE     (sMagaza = '" & sDepo & "') and nOdemeKodu=2 ORDER BY lMakbuzNo DESC")
        'cmd.CommandText = sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT ISNULL(MAX(lMakbuzNo), 0) + 1 AS lMakbuzNo FROM tbOdeme WHERE     (sMagaza = '" & sDepo & "') and nOdemeKodu=2 ORDER BY lMakbuzNo DESC")
        cmd.CommandText = sorgu_query(String.Format("SET DATEFORMAT DMY SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT ISNULL(lOdemeNo1,0)+1 FROM         tbStokFisNolar WHERE     (sDepo = '{0}')", sDepo))
        Dim kayitsayisi = cmd.ExecuteScalar
        Return kayitsayisi
    End Function
    Private Sub tbAvSirano_degistir(ByVal nSiraIndex As Integer, ByVal nSonID As Int64, ByVal sDepo As String)
        'kriter = "WHERE (sFisTipi = '" & sFistipi & "') and (dteFisTarihi = '" & dteFisTarihi & "') and (lFisNo = '" & lFisno & "') and (nFirmaID= '" & nFirmaID & "') and (nGirisCikis = '" & nGirisCikis & "')  "
        'sorgu(sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT * FROM tbFirmaHareketi " & kriter & ""))
        Dim conn As New OleDb.OleDbConnection
        Dim cmd As New OleDb.OleDbCommand
        Dim adapter As New OleDb.OleDbDataAdapter
        conn.ConnectionString = connection
        cmd.Connection = conn
        If conn.State = ConnectionState.Closed Then
            conn.Open()
        End If
        cmd.CommandText = sorgu_query(String.Format("SET DATEFORMAT DMY SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED UPDATE tbAvSiraNo SET nSonID = '{0}' where nSiraIndex = {1} and sDepo = '{2}'", nSonID, nSiraIndex, sDepo))
        cmd.ExecuteNonQuery()
        conn.Close()
    End Sub
    Private Sub lMakbuzNo_degistir(ByVal nSonID As Int64, ByVal sDepo As String)
        Dim conn As New OleDb.OleDbConnection
        Dim cmd As New OleDb.OleDbCommand
        Dim adapter As New OleDb.OleDbDataAdapter
        conn.ConnectionString = connection
        cmd.Connection = conn
        If conn.State = ConnectionState.Closed Then
            conn.Open()
        End If
        cmd.CommandText = sorgu_query(String.Format("SET DATEFORMAT DMY SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED UPDATE tbStokFisNolar SET              lOdemeNo1 ='{0}' WHERE     (sDepo = '{1}')", nSonID, sDepo))
        cmd.ExecuteNonQuery()
        conn.Close()
    End Sub
    Private Sub tbOdeme_kaydet_yeni(ByVal nOdemeID As String, ByVal nAlisverisID As String, ByVal sOdemeSekli As String, ByVal nOdemeKodu As Int64, ByVal sKasiyerRumuzu As String, ByVal dteOdemeTarihi As DateTime, ByVal dteValorTarihi As DateTime, ByVal lOdemeTutar As Decimal, ByVal sDovizCinsi As String, ByVal lDovizTutar As Decimal, ByVal lMakbuzNo As String, ByVal lOdemeNo As String, ByVal nTaksitID As String, ByVal nIadeAlisverisID As String, ByVal bMuhasebeyeIslendimi As Byte, ByVal nKasaNo As Int64, ByVal sKartNo As String, ByVal sKullaniciAdi As String, ByVal dteKayitTarihi As DateTime, ByVal sMagaza As String)
        Dim cmd As New OleDb.OleDbCommand
        Dim con As New OleDb.OleDbConnection
        cmd.Connection = con
        con.ConnectionString = connection
        If con.State = ConnectionState.Closed = True Then
            con.Open()
        End If
        cmd.CommandText = sorgu_query(String.Format("SET DATEFORMAT DMY INSERT INTO tbOdeme (nOdemeID, nAlisverisID, sOdemeSekli, nOdemeKodu, sKasiyerRumuzu, dteOdemeTarihi, dteValorTarihi, lOdemeTutar, sDovizCinsi, lDovizTutar, lMakbuzNo, lOdemeNo, nTaksitID, nIadeAlisverisID, bMuhasebeyeIslendimi, nKasaNo, sKartNo, sKullaniciAdi, dteKayitTarihi, sMagaza) VALUES     ('{0}', '{1}', '{2}', {3}, '{4}', '{5}', '{6}', {7}, '{8}', {9}, {10}, {11}, '{12}', '{13}', {14}, {15}, '{16}', '{17}', '{18}', '{19}')", nOdemeID, nAlisverisID, sOdemeSekli, nOdemeKodu, sKasiyerRumuzu, dteOdemeTarihi, dteValorTarihi, lOdemeTutar, sDovizCinsi, lDovizTutar, lMakbuzNo, lOdemeNo, nTaksitID, nIadeAlisverisID, bMuhasebeyeIslendimi, nKasaNo, sKartNo, sKullaniciAdi, dteKayitTarihi, sMagaza))
        cmd.ExecuteNonQuery()
        con.Close()
    End Sub
    Private Sub tbOdeme_kaydet_duzelt(ByVal nOdemeID As String, ByVal lOdemeTutar As Decimal)
        Dim cmd As New OleDb.OleDbCommand
        Dim con As New OleDb.OleDbConnection
        cmd.Connection = con
        con.ConnectionString = connection
        If con.State = ConnectionState.Closed = True Then
            con.Open()
        End If
        cmd.CommandText = sorgu_query(String.Format("SET DATEFORMAT DMY UPDATE tbOdeme SET lOdemeTutar = lOdemeTutar - {0} Where nOdemeID = '{1}'", lOdemeTutar, nOdemeID))
        cmd.ExecuteNonQuery()
        con.Close()
    End Sub
    Private Sub tbOdeme_ekle()
        Dim s As String
        Dim arr As Integer()
        Dim i As Integer
        Dim tutar As Decimal = 0
        Dim dr As DataRow
        Dim dr1 As DataRow
        Dim lOdemeTutar As Decimal = 0
        Dim lKur As Decimal = 0
        Dim lDovizTutar As Decimal = 0
        Dim nOdemeID As Int64 = 0
        lMakbuzNo = sorgu_lMakbuzNo(sMagaza)
        lToplamTutar = 0
        'seçilenleri aktar 
        For Each dr1 In dataset1.Tables(0).Rows
            lOdemeTutar = dr1("lOdemeTutar")
            If Trim(dr1("sDovizCinsi")) <> "" Then
                lKur = dr1("lOdemeTutar") / dr1("lDovizTutar")
            Else
                lKur = 0
            End If
            arr = GridView1.GetSelectedRows()
            If arr Is Nothing Then
            Else
                Array.Sort(arr)
                For Each i In arr
                    s = i.ToString
                    dr = GridView1.GetDataRow(s)
                    If dr("KALAN") > 0 And lOdemeTutar > 0 Then
                        If lOdemeTutar > dr("KALAN") Then
                            tutar = dr("KALAN")
                            lOdemeTutar -= dr("KALAN")
                            dr("KALAN") = 0
                        ElseIf lOdemeTutar = dr("KALAN") Then
                            tutar = dr("KALAN")
                            lOdemeTutar -= dr("KALAN")
                            dr("KALAN") = 0
                        ElseIf lOdemeTutar < dr("KALAN") Then
                            tutar = lOdemeTutar 'dr("KALAN") - lOdemeTutar
                            lOdemeTutar = 0
                            dr("KALAN") = dr("KALAN") - lOdemeTutar
                        End If
                        lToplamTutar += tutar
                        nOdemeID = sorgu_nOdemeID(sMagaza)
                        dr1("dteKayitTarihi") = Now
                        If lKur <> 0 Then
                            lDovizTutar = tutar / lKur
                        Else
                            lDovizTutar = 0
                        End If
                        tbOdeme_kaydet_yeni(sMagaza & nOdemeID.ToString, dr("nAlisVerisID"), dr1("sOdemeSekli"), dr1("nOdemeKodu"), dr1("sKasiyerRumuzu"), dr1("dteOdemeTarihi"), dr1("dteValorTarihi"), tutar, dr1("sDovizCinsi"), lDovizTutar, lMakbuzNo, lMakbuzNo, dr("nTaksitID"), dr1("nIadeAlisVerisID"), dr1("bMuhasebeyeIslendimi"), dr1("nKasaNo"), dr1("sKartNo"), dr1("sKullaniciAdi"), dr1("dteKayitTarihi"), sMagaza)
                        tbAvSirano_degistir(2, nOdemeID, sMagaza)
                        lMakbuzNo_degistir(lMakbuzNo, sMagaza)
                    End If
                Next
            End If
        Next
        'If lOdemeTutar > 0 Then
        '    dr1 = GridView2.GetDataRow(GridView2.FocusedRowHandle)
        '    For Each dr In ds_taksit.Tables(0).Rows
        '        If dr("KALAN") > 0 And lOdemeTutar > 0 Then
        '            If lOdemeTutar > dr("KALAN") Then
        '                tutar = dr("KALAN")
        '                lOdemeTutar -= dr("KALAN")
        '                dr("KALAN") = 0
        '            ElseIf lOdemeTutar = dr("KALAN") Then
        '                tutar = dr("KALAN")
        '                lOdemeTutar -= dr("KALAN")
        '                dr("KALAN") = 0
        '            ElseIf lOdemeTutar < dr("KALAN") Then
        '                tutar = lOdemeTutar 'dr("KALAN") - lOdemeTutar
        '                lOdemeTutar = 0
        '                dr("KALAN") = dr("KALAN") - lOdemeTutar
        '            End If
        '            lToplamTutar += tutar
        '            nOdemeID = sorgu_nOdemeID(sMagaza)
        '            'dr1("dteKayitTarihi") = Now
        '            If lKur <> 0 Then
        '                lDovizTutar = tutar / lKur
        '            Else
        '                lDovizTutar = 0
        '            End If
        '            tbOdeme_kaydet_yeni(sMagaza & nOdemeID.ToString, dr("nAlisVerisID"), dr1("sOdemeSekli"), dr1("nOdemeKodu"), dr1("sKasiyerRumuzu"), dr1("dteOdemeTarihi"), dr1("dteValorTarihi"), tutar, dr1("sDovizCinsi"), lDovizTutar, lMakbuzno, lMakbuzno, dr("nTaksitID"), dr1("nIadeAlisVerisID"), dr1("bMuhasebeyeIslendimi"), dr1("nKasaNo"), dr1("sKartNo"), dr1("sKullaniciAdi"), dr1("dteKayitTarihi"), sMagaza)
        '            tbAvSirano_degistir(2, nOdemeID, sMagaza)
        '            lMakbuzNo_degistir(lMakbuzno, sMagaza)
        '        End If
        '    Next
        'End If
        If lOdemeTutar > 0 Then
            XtraMessageBox.Show(Sorgu_sDil("Para Üstü: ", sDil) & FormatNumber(lOdemeTutar, 2), Sorgu_sDil("Dikkat", sDil), MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
        dr = Nothing
        dr1 = Nothing
        lOdemeTutar = Nothing
        nOdemeID = Nothing
    End Sub
    Private Sub SimpleButton3_Click(ByVal sender As Object, ByVal e As EventArgs)
        If XtraMessageBox.Show(String.Format("Taksit Tahsilatı Servisini Başlatmak İstediğinize Emin misiniz...?{0}Yaptığınız İşlemin Geri Dönüşü Yoktur,Yedek Almayı Unutmayınız...!!!", vbCrLf), Sorgu_sDil("Dikkat", sDil), MessageBoxButtons.YesNo, MessageBoxIcon.Question) = MsgBoxResult.Yes Then
            servis_calistir()
            dataload()
        End If
    End Sub
    Private Sub servis_calistir()
        Dim dr As DataRow
        Dim dr1 As DataRow
        Dim dr2 As DataRow
        Dim lFazlaTahsilat As Decimal = 0
        Dim lOdemeTutar As Decimal = 0
        Dim lDovizTutar As Decimal = 0
        Const lKur As Decimal = 0
        Dim tutar As Decimal = 0
        Dim nOdemeID As String = ""
        For Each dr In dataset1.Tables(0).Rows
            lFazlaTahsilat = dr("lFazlaTahsilat")
            ds_Tahsilatlar = tbTahsilatlar(dr("nTaksitID"))
            ds_Taksitler = tbTaksit(dr("nMusteriID"))
            For Each dr1 In ds_Tahsilatlar.Tables(0).Rows
                If dr1("lOdemeTutar") > 0 And lFazlaTahsilat > 0 Then
                    If lFazlaTahsilat > dr1("lOdemeTutar") Then
                        tutar = dr1("lOdemeTutar")
                        lFazlaTahsilat -= dr1("lOdemeTutar")
                        dr1("lOdemeTutar") = 0
                    ElseIf lFazlaTahsilat = dr1("lOdemeTutar") Then
                        tutar = dr1("lOdemeTutar")
                        lFazlaTahsilat -= dr1("lOdemeTutar")
                        dr1("lOdemeTutar") = 0
                    ElseIf lFazlaTahsilat < dr1("lOdemeTutar") Then
                        tutar = lFazlaTahsilat 'dr1("KALAN") - lOdemeTutar
                        lFazlaTahsilat = 0
                        dr1("lOdemeTutar") = dr1("lOdemeTutar") - tutar
                    End If
                    lToplamTutar += tutar
                    sMagaza = dr1("sMagaza")
                    lMakbuzNo = dr1("lMakbuzNo")
                    lOdemeTutar = tutar
                    'Kalan Taksitlerden Düş
                    For Each dr2 In ds_Taksitler.Tables(0).Rows
                        If dr2("KALAN") > 0 And lOdemeTutar > 0 Then
                            If lOdemeTutar > dr2("KALAN") Then
                                tutar = dr2("KALAN")
                                lOdemeTutar -= dr2("KALAN")
                                dr2("KALAN") = 0
                            ElseIf lOdemeTutar = dr2("KALAN") Then
                                tutar = dr2("KALAN")
                                lOdemeTutar -= dr2("KALAN")
                                dr2("KALAN") = 0
                            ElseIf lOdemeTutar < dr2("KALAN") Then
                                tutar = lOdemeTutar 'dr2("KALAN") - lOdemeTutar
                                lOdemeTutar = 0
                                dr2("KALAN") = dr2("KALAN") - lOdemeTutar
                            End If
                            lToplamTutar += tutar
                            nOdemeID = sorgu_nOdemeID(sMagaza)
                            'dr1("dteKayitTarihi") = Now
                            If lKur <> 0 Then
                                lDovizTutar = tutar / lKur
                            Else
                                lDovizTutar = 0
                            End If
                            tbOdeme_kaydet_yeni(sMagaza & nOdemeID.ToString, dr2("nAlisVerisID"), dr1("sOdemeSekli"), dr1("nOdemeKodu"), dr1("sKasiyerRumuzu"), dr1("dteOdemeTarihi"), dr1("dteValorTarihi"), tutar, dr1("sDovizCinsi"), lDovizTutar, lMakbuzNo, lMakbuzNo, dr2("nTaksitID"), dr1("nIadeAlisVerisID"), dr1("bMuhasebeyeIslendimi"), dr1("nKasaNo"), dr1("sKartNo"), dr1("sKullaniciAdi"), dr1("dteKayitTarihi"), sMagaza)
                            'dr1("lOdemeTutar") = dr1("lOdemeTutar") - tutar
                            tbOdeme_kaydet_duzelt(dr1("nOdemeID"), tutar)
                            tbAvSirano_degistir(2, nOdemeID, sMagaza)
                            lMakbuzNo_degistir(lMakbuzNo, sMagaza)
                        End If
                    Next
                End If
            Next
        Next
        XtraMessageBox.Show("Servis İşlemi Tamamlandı...!", Sorgu_sDil("Dikkat", sDil), MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub
    Private Sub GridView1_CustomDrawRowIndicator(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Grid.RowIndicatorCustomDrawEventArgs) Handles GridView1.CustomDrawRowIndicator
        If e.RowHandle >= 0 Then
            e.Info.DisplayText = e.RowHandle + 1
        Else
            e.Info.DisplayText = ""
        End If
    End Sub
    Private Sub MenuItem1_Click(sender As System.Object, e As System.EventArgs) Handles MenuItem1.Click
        GridView1.ColumnsCustomization()
    End Sub
    Private Sub MenuItem3_Click(sender As System.Object, e As System.EventArgs) Handles MenuItem3.Click
        GridView1.SaveLayoutToRegistry("SOFTWARE\BusinessSmart\VIEW\Perakende\Tanımlar\TaksitTahsilat\" & Me.Name.ToString & "")
        XtraMessageBox.Show(Sorgu_sDil("Görünüm Kaydedildi", sDil), Sorgu_sDil("Dikkat", sDil), MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub
    Private Sub MenuItem14_Click(sender As System.Object, e As System.EventArgs) Handles MenuItem14.Click
        GridView1.OptionsView.ShowAutoFilterRow = True
        GridView1.OptionsView.ShowFilterPanelMode = DevExpress.XtraGrid.Views.Base.ShowFilterPanelMode.Default
        GridView1.OptionsCustomization.AllowFilter = True
    End Sub
    Private Sub MenuItem5_Click(sender As System.Object, e As System.EventArgs) Handles MenuItem5.Click
        GridView1.OptionsView.ShowFilterPanelMode = DevExpress.XtraGrid.Views.Base.ShowFilterPanelMode.Default
        GridView1.OptionsCustomization.AllowFilter = True
    End Sub
    Private Sub MenuItem6_Click(sender As System.Object, e As System.EventArgs) Handles MenuItem6.Click
        GridView1.OptionsView.ShowGroupPanel = True
        GridView1.OptionsCustomization.AllowGroup = True
    End Sub
    Private Sub MenuItem9_Click(sender As System.Object, e As System.EventArgs) Handles MenuItem9.Click
        If Me.WindowState = FormWindowState.Normal Then
            Me.WindowState = FormWindowState.Maximized
        ElseIf Me.WindowState = FormWindowState.Maximized Then
            Me.WindowState = FormWindowState.Normal
        End If
    End Sub
    Private Sub frm_BakimPerakendeTaksitTahsilat_Load_1(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Try
            dataload()
            GridView1.RestoreLayoutFromRegistry("SOFTWARE\BusinessSmart\VIEW\Perakende\Tanımlar\TaksitTahsilat\" & Me.Name.ToString & "")
        Catch ex As Exception
        End Try
    End Sub
    Private Sub SimpleButton1_Click_1(sender As System.Object, e As System.EventArgs) Handles SimpleButton1.Click
        Me.Close()
    End Sub
    Private Sub SimpleButton2_Click(sender As System.Object, e As System.EventArgs) Handles SimpleButton2.Click
        Me.Close()
    End Sub


End Class