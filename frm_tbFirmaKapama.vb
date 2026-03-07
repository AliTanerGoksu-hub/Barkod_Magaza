Imports DevExpress.XtraEditors
Public Class frm_tbFirmaKapama
    Public firmano
    Public donemno
    Public connection
    Public nFirmaID
    Dim nHesapID
    Public sKodu
    Public kullanici
    Dim conn As New OleDb.OleDbConnection
    Dim con As New OleDb.OleDbConnection
    Dim cmd As New OleDb.OleDbCommand
    Dim adapter As New OleDb.OleDbDataAdapter
    Dim DS As New DataSet
    Dim ds_cari As DataSet
    Public yeni As Boolean = False
    Public bBakiye As Boolean = False
    Private Sub frm_tbFirmaKapama_Activated(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Activated
        If yeni = True Then
            GridControl1.Focus()
            GridControl1.Select()
        End If
    End Sub
    Private Sub frm_tbFirmaKapama_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        Dispose()
    End Sub
    Private Sub frm_tbFirmaKapama_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        If nFirmaID = 0 Then
            If yeni = False Then
                firma_sec()
            ElseIf yeni = True Then
                dataload(nFirmaID)
                SimpleButton1.Text = "&Kaydet"
                XtraTabPage2.PageEnabled = False
            End If
        Else
            txt_musteriNo.EditValue = sKodu
            dataload(nFirmaID)
        End If
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
    Public Function sorgu_sKodu_kontrol(ByVal kod As String) As Boolean
        Dim kriter
        Dim pass As Boolean
        kriter = ""
        Dim conn As New OleDb.OleDbConnection
        Dim cmd As New OleDb.OleDbCommand
        Dim adapter As New OleDb.OleDbDataAdapter
        conn.ConnectionString = connection
        cmd.Connection = conn
        conn.Open()
        cmd.CommandText = sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT     ISNULL(COUNT(sKodu), 0) AS nKayit FROM         tbFirma WHERE     (sKodu = '" & kod & "') ")
        Dim kayitsayisi = cmd.ExecuteScalar
        If kayitsayisi = 0 Then
            pass = True
        Else
            pass = False
        End If
        Return pass
    End Function
    Private Sub firma_sec()
        Dim dr As DataRow
        dr = GridView1.GetDataRow(GridView1.FocusedRowHandle)
        Dim frm As New frm_firma_liste
        frm.firmano = firmano
        frm.donemno = donemno
        frm.connection = connection
        frm.islemstatus = True
        frm.kullanici = kullanici
        If frm.ShowDialog(Me) = Windows.Forms.DialogResult.OK Then
            yeni = False
            SimpleButton1.Text = "&Tamam"
            XtraTabPage2.PageEnabled = True
            Dim dr1 As DataRow
            dr1 = frm.GridView1.GetDataRow(frm.GridView1.FocusedRowHandle)
            nFirmaID = dr1("nFirmaID")
            sKodu = dr1("sKodu")
            txt_musteriNo.EditValue = sKodu
            musteri_kontrol()
            dr1 = Nothing
        End If
    End Sub
    Private Sub musteri_kontrol()
        If Trim(txt_musteriNo.EditValue).ToString <> "" Then
            Dim kontrol = sorgu_cari_kontrol(txt_musteriNo.EditValue)
            If kontrol = 0 Then
                XtraMessageBox.Show(Sorgu_sDil("Kayýt Bulunumadý...", sDil), Sorgu_sDil("Dikkat", sDil), MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            ElseIf kontrol = 1 Then
                dataload_cari(txt_musteriNo.EditValue)
                Dim dr As DataRow
                For Each dr In ds_cari.Tables(0).Rows
                    'txt_Musteri.EditValue = dr("MUSTERI")
                    sKodu = dr("sKodu")
                    nFirmaID = dr("nFirmaID")
                    dataload(nFirmaID)
                Next
                dr = Nothing
            End If
        End If
    End Sub
    Public Function sorgu_cari_kontrol(ByVal kod As String) As Int64
        Dim kriter
        kriter = "WHERE (sKodu = '" & kod & "') "
        Dim conn As New OleDb.OleDbConnection
        Dim cmd As New OleDb.OleDbCommand
        Dim adapter As New OleDb.OleDbDataAdapter
        conn.ConnectionString = connection
        cmd.Connection = conn
        conn.Open()
        cmd.CommandText = sorgu_query("SET DATEFORMAT DMY SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT     ISNULL(COUNT(*), 0) AS KAYIT  FROM         tbFirma " & kriter & "")
        Dim kayitsayisi = cmd.ExecuteScalar
        Return kayitsayisi
    End Function
    Public Function sorgu_tbFirmaKapama_nkayit_kontrol(ByVal nKarsilamaID As String) As Int64
        Dim kriter
        kriter = "WHERE (nKarsilamaID = '" & nKarsilamaID & "') and (nOdemeID=0) "
        Dim conn As New OleDb.OleDbConnection
        Dim cmd As New OleDb.OleDbCommand
        Dim adapter As New OleDb.OleDbDataAdapter
        conn.ConnectionString = connection
        cmd.Connection = conn
        conn.Open()
        cmd.CommandText = sorgu_query("SET DATEFORMAT DMY SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT     ISNULL(nKapamaID,0) nKapamID FROM         tbFirmaKapama  " & kriter & " ")
        Dim kayitsayisi = cmd.ExecuteScalar
        Return kayitsayisi
    End Function
    Public Function sorgu_tbFirmaKapama_lOdenen_kontrol(ByVal nKarsilamaID As String) As Decimal
        Dim kriter
        kriter = "WHERE (nKarsilamaID = '" & nKarsilamaID & "') and (nOdemeID <> 0) "
        Dim conn As New OleDb.OleDbConnection
        Dim cmd As New OleDb.OleDbCommand
        Dim adapter As New OleDb.OleDbDataAdapter
        conn.ConnectionString = connection
        cmd.Connection = conn
        conn.Open()
        cmd.CommandText = sorgu_query("SET DATEFORMAT DMY SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT     ISNULL(SUM(lTutar), 0) AS lOdenen FROM         tbFirmaKapama  " & kriter & " ")
        Dim kayitsayisi = cmd.ExecuteScalar
        Return kayitsayisi
    End Function
    Public Function sorgu_nkayit_kontrol(ByVal nFirmaID As String) As Int64
        Dim kriter
        kriter = "WHERE (nFirmaID = '" & nFirmaID & "') "
        Dim conn As New OleDb.OleDbConnection
        Dim cmd As New OleDb.OleDbCommand
        Dim adapter As New OleDb.OleDbDataAdapter
        conn.ConnectionString = connection
        cmd.Connection = conn
        conn.Open()
        cmd.CommandText = sorgu_query("SET DATEFORMAT DMY SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED Select ISNULL(count(nFirmaID),0) as nKayit from tbFirmaHareketi " & kriter & " ")
        Dim kayitsayisi = cmd.ExecuteScalar
        Return kayitsayisi
    End Function
    Private Sub tbFirmaKapama_kaydet_yeni(ByVal nKapamaID As Int64, ByVal nKarsilamaID As Int64, ByVal nOdemeID As Int64, ByVal lTutar As Decimal, ByVal sDovizCinsi As String)
        Dim cmd As New OleDb.OleDbCommand
        Dim con As New OleDb.OleDbConnection
        cmd.Connection = con
        con.ConnectionString = connection
        If con.State = ConnectionState.Closed = True Then
            con.Open()
        End If
        'cmd.CommandText = sorgu_query("SET DATEFORMAT DMY SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED INSERT INTO tbFirmaKapama (nKarsilamaID, nOdemeID, lTutar, sDovizCinsi) VALUES     (" & nKarsilamaID & ", " & nOdemeID & ", " & lTutar & ", '" & sDovizCinsi & "')")
        cmd.CommandText = sorgu_query("SET DATEFORMAT DMY SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED INSERT INTO tbFirmaKapama (nKarsilamaID, nOdemeID, lTutar) VALUES     (" & nKarsilamaID & ", " & nOdemeID & ", " & lTutar & ")")
        cmd.ExecuteNonQuery()
        con.Close()
        con.Dispose()
        cmd.Dispose()
        con = Nothing
        cmd = Nothing
    End Sub
    Private Sub tbFirmaKapama_kaydet_duzelt(ByVal nKapamaID As Int64, ByVal nKarsilamaID As Int64, ByVal nOdemeID As Int64, ByVal lTutar As Decimal, ByVal sDovizCinsi As String)
        Dim cmd As New OleDb.OleDbCommand
        Dim con As New OleDb.OleDbConnection
        cmd.Connection = con
        con.ConnectionString = connection
        If con.State = ConnectionState.Closed = True Then
            con.Open()
        End If
        'cmd.CommandText = sorgu_query("SET DATEFORMAT DMY SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED UPDATE    tbFirmaKapama SET               lTutar = " & lTutar & ", sDovizCinsi = '" & sDovizCinsi & "' Where nKapamaID = " & nKapamaID & ", nKarsilamaID = " & nKarsilamaID & ", nOdemeID = " & nOdemeID & "")
        cmd.CommandText = sorgu_query("SET DATEFORMAT DMY SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED UPDATE    tbFirmaKapama SET               lTutar = " & lTutar & " Where nKapamaID = " & nKapamaID & " and  nKarsilamaID = " & nKarsilamaID & " and  nOdemeID = " & nOdemeID & "")
        cmd.ExecuteNonQuery()
        con.Close()
        con.Dispose()
        cmd.Dispose()
        con = Nothing
        cmd = Nothing
    End Sub
    Private Sub tbFirmaKapama_kaydet_sil(ByVal nKapamaID As Int64, ByVal nKarsilamaID As Int64, ByVal nOdemeID As Int64, ByVal lTutar As Decimal, ByVal sDovizCinsi As String)
        Dim cmd As New OleDb.OleDbCommand
        Dim con As New OleDb.OleDbConnection
        cmd.Connection = con
        con.ConnectionString = connection
        If con.State = ConnectionState.Closed = True Then
            con.Open()
        End If
        cmd.CommandText = sorgu_query("SET DATEFORMAT DMY SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED DELETE FROM tbFirmaKapama Where nKarsilamaID = " & nKarsilamaID & " and  nOdemeID = " & nOdemeID & "")
        cmd.ExecuteNonQuery()
        con.Close()
        con.Dispose()
        cmd.Dispose()
        con = Nothing
        cmd = Nothing
    End Sub
    Private Sub dataload_cari(ByVal kod As String)
        Dim kriter
        kriter = "WHERE (sKodu = '" & kod & "') "
        ds_cari = sorgu(sorgu_query("SELECT     nFirmaId,sKodu,sAciklama FROM         tbFirma " & kriter & ""))
    End Sub
    Private Sub dataload(ByVal nFirmaID As String)
        Dataload_tbFirma(nFirmaID)
        ds_tbFirmaBakiyesi.Tables(0).Clear()
        ds_FirmaHesap.Tables(0).Clear()
        Dataload_tbFirmaBakiyesi(nFirmaID)
        Dataload_tbFirmaHesabi(nFirmaID, sec_bKapanan.Checked)
    End Sub
    Public Sub Dataload_tbFirma(ByVal nFirmaID As String)
        Try
            ds_tbFirma.Tables(0).Clear()
        Catch ex As Exception
        End Try
        Dim conn As New OleDb.OleDbConnection
        Dim cmd As New OleDb.OleDbCommand
        Dim adapter As New OleDb.OleDbDataAdapter
        conn.ConnectionString = connection
        adapter.SelectCommand = cmd
        cmd.CommandText = sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT     tbFirma.*, tbHesapPlani.sKodu AS sMuhasebeKodu FROM         tbFirma INNER JOIN                       tbHesapPlani ON tbFirma.nHesapID = tbHesapPlani.nHesapID WHERE tbFirma.nFirmaID ='" & nFirmaID & "'")
        cmd.Connection = conn
        conn.Open()
        Dim N As Integer = adapter.Fill(ds_tbFirma, "Table1")
        conn.Close()
    End Sub
    Public Sub Dataload_tbFirmaBakiyesi(ByVal nFirmaID As String)
        Try
            ds_tbFirmaBakiyesi.Tables(0).Clear()
        Catch ex As Exception
        End Try
        Dim conn As New OleDb.OleDbConnection
        Dim cmd As New OleDb.OleDbCommand
        Dim adapter As New OleDb.OleDbDataAdapter
        conn.ConnectionString = connection
        adapter.SelectCommand = cmd
        cmd.CommandText = sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT nFirmaID, ISNULL(SUM(lBorcTutar), 0) AS lBorc, ISNULL(SUM(lAlacakTutar), 0) AS lAlacak, ISNULL(SUM(lBorcTutar - lAlacakTutar), 0) AS lBakiye FROM tbFirmaHareketi WHERE (nFirmaID = '" & nFirmaID & "') GROUP BY nFirmaID")
        cmd.Connection = conn
        conn.Open()
        Dim N As Integer = adapter.Fill(ds_tbFirmaBakiyesi, "Table1")
        conn.Close()
    End Sub
    Public Sub Dataload_tbFirmaHesabi(ByVal nFirmaID As String, ByVal bKapanan As Boolean)
        Try
            ds_FirmaHesap.Tables(0).Clear()
        Catch ex As Exception
        End Try
        Dim conn As New OleDb.OleDbConnection
        Dim cmd As New OleDb.OleDbCommand
        Dim adapter As New OleDb.OleDbDataAdapter
        conn.ConnectionString = connection
        adapter.SelectCommand = cmd
        If bBakiye = False Then
            If bKapanan = True Then
                'cmd.CommandText = sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT *, lTutar - lKapananTutar AS lKalan FROM (SELECT tbFirmaHareketi.dteIslemTarihi , tbFirmaHareketi.dteValorTarihi , tbFirmaHareketi.lBorcTutar AS lTutar , tbFirmaHareketi.sAciklama , tbFirmaHareketi.sEvrakNo , tbFirmaHareketi.sCariIslem , tbFirmaHareketi.sDovizCinsi1,tbFirmaHareketi.lDovizMiktari1,tbFirmaHareketi.nHareketID , ISNULL((SELECT SUM(lTutar) FROM tbFirmaKapama WHERE nKarsilamaId = nHareketId AND nOdemeId = 0) , 0) AS lKapananTutar, (SELECT ISNULL(SUM(Kapama.lTutar / Hareket.lDovizKuru1) , 0) AS lDovizTutar FROM tbFirmaKapama Kapama INNER JOIN tbFirmaHareketi Hareket ON Kapama.nOdemeID = Hareket.nHareketID WHERE (Kapama.nOdemeID <> 0) AND (Kapama.nKarsilamaID = tbFirmaHareketi.nHareketID) AND (Hareket.sDovizCinsi1 = tbFirmaHareketi.sDovizCinsi1)) lDovizKapananTutar FROM tbFirmaHareketi INNER JOIN tbFirma ON tbFirmaHareketi.nFirmaID = tbFirma.nFirmaID WHERE (tbFirma.nFirmaID = '" & nFirmaID & "') AND (tbFirmaHareketi.lBorcTutar <> 0)) tbTemp Where lTutar-lKapanantutar = 0 ORDER BY dteIslemTarihi")
                cmd.CommandText = sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT *, lTutar - lKapananTutar AS lKalan FROM (SELECT tbFirmaHareketi.dteIslemTarihi , tbFirmaHareketi.dteValorTarihi , DATEDIFF([day], tbFirmaHareketi.dteIslemTarihi, tbFirmaHareketi.dteValorTarihi) AS nOpsiyon,tbFirmaHareketi.lBorcTutar AS lTutar , tbFirmaHareketi.sAciklama , tbFirmaHareketi.sEvrakNo , tbFirmaHareketi.sCariIslem , tbFirmaHareketi.sDovizCinsi1,tbFirmaHareketi.lDovizMiktari1,tbFirmaHareketi.nHareketID , ISNULL((SELECT SUM(lTutar) FROM tbFirmaKapama WHERE nKarsilamaId = nHareketId AND nOdemeId = 0) , 0) AS lKapananTutar, (SELECT ISNULL(SUM(Kapama.lTutar ) , 0) AS lDovizTutar FROM tbFirmaKapama Kapama INNER JOIN tbFirmaHareketi Hareket ON Kapama.nOdemeID = Hareket.nHareketID WHERE (Kapama.nOdemeID <> 0) AND (Kapama.nKarsilamaID = tbFirmaHareketi.nHareketID) AND (Hareket.sDovizCinsi1 = tbFirmaHareketi.sDovizCinsi1)) lDovizKapananTutar FROM tbFirmaHareketi INNER JOIN tbFirma ON tbFirmaHareketi.nFirmaID = tbFirma.nFirmaID WHERE (tbFirma.nFirmaID = '" & nFirmaID & "') AND (tbFirmaHareketi.lBorcTutar <> 0)) tbTemp Where lTutar-lKapanantutar = 0 ORDER BY dteIslemTarihi")
            ElseIf bKapanan = False Then
                'cmd.CommandText = sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT *, lTutar - lKapananTutar AS lKalan FROM (SELECT tbFirmaHareketi.dteIslemTarihi , tbFirmaHareketi.dteValorTarihi , tbFirmaHareketi.lBorcTutar AS lTutar , tbFirmaHareketi.sAciklama , tbFirmaHareketi.sEvrakNo , tbFirmaHareketi.sCariIslem , tbFirmaHareketi.sDovizCinsi1,tbFirmaHareketi.lDovizMiktari1,tbFirmaHareketi.nHareketID , ISNULL((SELECT SUM(lTutar) FROM tbFirmaKapama WHERE nKarsilamaId = nHareketId AND nOdemeId = 0) , 0) AS lKapananTutar, (SELECT ISNULL(SUM(Kapama.lTutar / Hareket.lDovizKuru1) , 0) AS lDovizTutar FROM tbFirmaKapama Kapama INNER JOIN tbFirmaHareketi Hareket ON Kapama.nOdemeID = Hareket.nHareketID WHERE (Kapama.nOdemeID <> 0) AND (Kapama.nKarsilamaID = tbFirmaHareketi.nHareketID) AND (Hareket.sDovizCinsi1 = tbFirmaHareketi.sDovizCinsi1)) lDovizKapananTutar FROM tbFirmaHareketi INNER JOIN tbFirma ON tbFirmaHareketi.nFirmaID = tbFirma.nFirmaID WHERE (tbFirma.nFirmaID = '" & nFirmaID & "') AND (tbFirmaHareketi.lBorcTutar <> 0)) tbTemp Where lTutar-lKapanantutar <> 0 ORDER BY dteIslemTarihi")
                cmd.CommandText = sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT *, lTutar - lKapananTutar AS lKalan FROM (SELECT tbFirmaHareketi.dteIslemTarihi , tbFirmaHareketi.dteValorTarihi , DATEDIFF([day], tbFirmaHareketi.dteIslemTarihi, tbFirmaHareketi.dteValorTarihi) AS nOpsiyon,tbFirmaHareketi.lBorcTutar AS lTutar , tbFirmaHareketi.sAciklama , tbFirmaHareketi.sEvrakNo , tbFirmaHareketi.sCariIslem , tbFirmaHareketi.sDovizCinsi1,tbFirmaHareketi.lDovizMiktari1,tbFirmaHareketi.nHareketID , ISNULL((SELECT SUM(lTutar) FROM tbFirmaKapama WHERE nKarsilamaId = nHareketId AND nOdemeId = 0) , 0) AS lKapananTutar, (SELECT ISNULL(SUM(Kapama.lTutar ) , 0) AS lDovizTutar FROM tbFirmaKapama Kapama INNER JOIN tbFirmaHareketi Hareket ON Kapama.nOdemeID = Hareket.nHareketID WHERE (Kapama.nOdemeID <> 0) AND (Kapama.nKarsilamaID = tbFirmaHareketi.nHareketID) AND (Hareket.sDovizCinsi1 = tbFirmaHareketi.sDovizCinsi1)) lDovizKapananTutar FROM tbFirmaHareketi INNER JOIN tbFirma ON tbFirmaHareketi.nFirmaID = tbFirma.nFirmaID WHERE (tbFirma.nFirmaID = '" & nFirmaID & "') AND (tbFirmaHareketi.lBorcTutar <> 0)) tbTemp Where lTutar-lKapanantutar <> 0 ORDER BY dteIslemTarihi")
            End If
        ElseIf bBakiye = True Then
            If bKapanan = True Then
                cmd.CommandText = sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT *, lTutar - lKapananTutar AS lKalan FROM (SELECT tbFirmaHareketi.dteIslemTarihi , tbFirmaHareketi.dteValorTarihi , DATEDIFF([day], tbFirmaHareketi.dteIslemTarihi, tbFirmaHareketi.dteValorTarihi) AS nOpsiyon,tbFirmaHareketi.lBorcTutar AS lTutar , tbFirmaHareketi.sAciklama , tbFirmaHareketi.sEvrakNo , tbFirmaHareketi.sCariIslem , tbFirmaHareketi.sDovizCinsi1,tbFirmaHareketi.lDovizMiktari1,tbFirmaHareketi.nHareketID , ISNULL((SELECT SUM(lTutar) FROM tbFirmaKapama WHERE nKarsilamaId = nHareketId AND nOdemeId = 0) , 0) AS lKapananTutar, (SELECT ISNULL(SUM(Kapama.lTutar ) , 0) AS lDovizTutar FROM tbFirmaKapama Kapama INNER JOIN tbFirmaHareketi Hareket ON Kapama.nOdemeID = Hareket.nHareketID WHERE (Kapama.nOdemeID <> 0) AND (Kapama.nOdemeID = tbFirmaHareketi.nHareketID) AND (Hareket.sDovizCinsi1 = tbFirmaHareketi.sDovizCinsi1)) lDovizKapananTutar FROM tbFirmaHareketi INNER JOIN tbFirma ON tbFirmaHareketi.nFirmaID = tbFirma.nFirmaID WHERE (tbFirma.nFirmaID = '" & nFirmaID & "') AND (tbFirmaHareketi.lBorcTutar <> 0)) tbTemp Where lTutar-lKapanantutar = 0 ORDER BY dteIslemTarihi")
            ElseIf bKapanan = False Then
                cmd.CommandText = sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT *, lTutar - lKapananTutar AS lKalan FROM (SELECT tbFirmaHareketi.dteIslemTarihi , tbFirmaHareketi.dteValorTarihi , DATEDIFF([day], tbFirmaHareketi.dteIslemTarihi, tbFirmaHareketi.dteValorTarihi) AS nOpsiyon,tbFirmaHareketi.lBorcTutar AS lTutar , tbFirmaHareketi.sAciklama , tbFirmaHareketi.sEvrakNo , tbFirmaHareketi.sCariIslem , tbFirmaHareketi.sDovizCinsi1,tbFirmaHareketi.lDovizMiktari1,tbFirmaHareketi.nHareketID , ISNULL((SELECT SUM(lTutar) FROM tbFirmaKapama WHERE nKarsilamaId = nHareketId AND nOdemeId = 0) , 0) AS lKapananTutar, (SELECT ISNULL(SUM(Kapama.lTutar ) , 0) AS lDovizTutar FROM tbFirmaKapama Kapama INNER JOIN tbFirmaHareketi Hareket ON Kapama.nOdemeID = Hareket.nHareketID WHERE (Kapama.nOdemeID <> 0) AND (Kapama.nOdemeID = tbFirmaHareketi.nHareketID) AND (Hareket.sDovizCinsi1 = tbFirmaHareketi.sDovizCinsi1)) lDovizKapananTutar FROM tbFirmaHareketi INNER JOIN tbFirma ON tbFirmaHareketi.nFirmaID = tbFirma.nFirmaID WHERE (tbFirma.nFirmaID = '" & nFirmaID & "') AND (tbFirmaHareketi.lBorcTutar <> 0)) tbTemp Where lTutar-lKapanantutar <> 0 ORDER BY dteIslemTarihi")
            End If
        End If
        cmd.Connection = conn
        conn.Open()
        Dim N As Integer = adapter.Fill(ds_FirmaHesap, "Table1")
        conn.Close()
    End Sub
    Public Sub Dataload_tbKapatilacak(ByVal nFirmaID As String, ByVal nHareketID As Integer)
        Try
            ds_tbKapatilacak.Tables(0).Clear()
        Catch ex As Exception
        End Try
        Dim conn As New OleDb.OleDbConnection
        Dim cmd As New OleDb.OleDbCommand
        Dim adapter As New OleDb.OleDbDataAdapter
        conn.ConnectionString = connection
        adapter.SelectCommand = cmd
        cmd.CommandText = sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT dteIslemTarihi, dteValorTarihi, nOpsiyon,lTutar, sAciklama, sEvrakNo, sCariIslem, sDovizCinsi1,lDovizKuru1,lDovizMiktari1,nHareketId, OnceOdemeTutar, lOdemeTutar, nSiralama = CASE WHEN lOdemeTutar = 0 THEN '0' ELSE '1' END, (lTutar - lOdemeTutar)-OnceOdemeTutar AS lKalan FROM (SELECT dteIslemtarihi, dtevalorTarihi, DATEDIFF([day],dteIslemTarihi, dteValorTarihi) AS nOpsiyon,lAlacakTutar AS lTutar, tbFirmaHareketi.sAciklama, sEvrakNo, sCariIslem, sDovizCinsi1,lDovizMiktari1,lDovizKuru1,nHareketId, isnull ((SELECT SUM(lTutar) FROM tbFirmaKapama WHERE nOdemeId = nHareketId AND nKarsilamaId <> " & nHareketID & "), 0) AS OnceOdemeTutar, isnull ((SELECT SUM(lTutar) FROM tbFirmaKapama WHERE nOdemeId = nHareketId AND nKarsilamaId = " & nHareketID & "), 0) AS lOdemeTutar FROM tbFirmaHareketi, tbFirma WHERE tbFirmaHareketi.nFirmaID = tbFirma.nFirmaID AND tbFirma.nFirmaID = '" & nFirmaID & "' AND lAlacakTutar <> 0) AS tbTemp Where (lTutar - lOdemeTutar) - OnceOdemeTutar <> 0 and OnceOdemeTutar <> lTutar ORDER BY nSiralama, dteIslemTarihi, dteValorTarihi")
        cmd.Connection = conn
        conn.Open()
        Dim N As Integer = adapter.Fill(ds_tbKapatilacak, "Table1")
        conn.Close()
    End Sub
    Public Sub Dataload_tbKapatilmis(ByVal nFirmaID As String, ByVal nHareketID As Integer)
        Try
            ds_tbKapatilmis.Tables(0).Clear()
        Catch ex As Exception
        End Try
        Dim conn As New OleDb.OleDbConnection
        Dim cmd As New OleDb.OleDbCommand
        Dim adapter As New OleDb.OleDbDataAdapter
        conn.ConnectionString = connection
        adapter.SelectCommand = cmd
        cmd.CommandText = sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT dteIslemTarihi, dteValorTarihi, lTutar, sAciklama, sEvrakNo, sCariIslem, nHareketId, OnceOdemeTutar, lOdemeTutar, nSiralama = CASE WHEN lOdemeTutar = 0 THEN '0' ELSE '1' END, lTutar - lOdemeTutar AS lKalan FROM (SELECT dteIslemtarihi, dtevalorTarihi, lAlacakTutar AS lTutar, tbFirmaHareketi.sAciklama, sEvrakNo, sCariIslem, nHareketId, isnull ((SELECT SUM(lTutar) FROM tbFirmaKapama WHERE nOdemeId = nHareketId AND nKarsilamaId <> " & nHareketID & "), 0) AS OnceOdemeTutar, isnull ((SELECT SUM(lTutar) FROM tbFirmaKapama WHERE nOdemeId = nHareketId AND nKarsilamaId = " & nHareketID & "), 0) AS lOdemeTutar FROM tbFirmaHareketi, tbFirma WHERE tbFirmaHareketi.nFirmaID = tbFirma.nFirmaID AND tbFirma.nFirmaID = '" & nFirmaID & "' AND lAlacakTutar <> 0) AS tbTemp Where lOdemeTutar <> 0  ORDER BY nSiralama, dteIslemTarihi, dteValorTarihi")
        cmd.Connection = conn
        conn.Open()
        Dim N As Integer = adapter.Fill(ds_tbKapatilmis, "Table1")
        conn.Close()
    End Sub
    Private Function sorgu_sayi(ByVal deger As Object, ByVal sonuc As Decimal) As Decimal
        If deger.ToString = "" Then
            deger = sonuc
        End If
        Return deger
    End Function
    Private Sub SimpleButton2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SimpleButton2.Click
        Me.Close()
    End Sub
    Private Sub SimpleButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SimpleButton1.Click
        Me.Close()
    End Sub
    Private Sub GridView1_FocusedRowChanged(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs) Handles GridView1.FocusedRowChanged
        If GridView1.RowCount > 0 Then
            Dim dr As DataRow
            dr = GridView1.GetDataRow(GridView1.FocusedRowHandle)
            Dataload_tbKapatilacak(nFirmaID, dr("nHareketID"))
            Dataload_tbKapatilmis(nFirmaID, dr("nHareketID"))
        End If
    End Sub
    Private Sub sec_bKapanan_CheckStateChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles sec_bKapanan.CheckStateChanged
        Dataload_tbFirmaHesabi(nFirmaID, sec_bKapanan.Checked)
    End Sub
    Private Sub tbFirma_HesapKapat()
        Dim dr As DataRow = GridView1.GetDataRow(GridView1.FocusedRowHandle)
        Dim dr1 As DataRow
        Dim nKapamaID As Int64 = 0
        Dim lOdenen As Decimal = 0
        Dim s As String
        Dim arr As Integer()
        Dim i As Integer
        arr = GridView2.GetSelectedRows()
        If arr Is Nothing Then
        Else
            Array.Sort(arr)
            For Each i In arr
                s = i.ToString
                dr1 = GridView2.GetDataRow(s)
                nKapamaID = sorgu_sayi(sorgu_tbFirmaKapama_nkayit_kontrol(dr("nHareketID")), 0)
                If dr("lKalan") > dr1("lKalan") Then
                    tbFirmaKapama_kaydet_yeni(0, dr("nHareketID"), dr1("nHareketID"), dr1("lKalan"), "")
                ElseIf dr("lKalan") <= dr1("lKalan") Then
                    tbFirmaKapama_kaydet_yeni(0, dr("nHareketID"), dr1("nHareketID"), dr("lKalan"), "")
                End If
                If nKapamaID > 0 Then
                    lOdenen = sorgu_sayi(sorgu_tbFirmaKapama_lOdenen_kontrol(dr("nHareketID")), 0)
                    tbFirmaKapama_kaydet_duzelt(nKapamaID, dr("nHareketID"), 0, lOdenen, "")
                ElseIf nKapamaID = 0 Then
                    lOdenen = sorgu_sayi(sorgu_tbFirmaKapama_lOdenen_kontrol(dr("nHareketID")), 0)
                    tbFirmaKapama_kaydet_yeni(0, dr("nHareketID"), 0, lOdenen, "")
                End If
            Next
        End If
        nKapamaID = Nothing
        lOdenen = Nothing
        Dim satir As Integer = GridView1.FocusedRowHandle
        Dataload_tbFirmaHesabi(nFirmaID, sec_bKapanan.Checked)
        GridView1.FocusedRowHandle = satir
    End Sub
    Private Sub tbFirma_HesapKapat_iptal()
        Dim dr As DataRow = GridView1.GetDataRow(GridView1.FocusedRowHandle)
        Dim dr1 As DataRow
        Dim nKapamaID As Int64 = 0
        Dim lOdenen As Decimal = 0
        Dim s As String
        Dim arr As Integer()
        Dim i As Integer
        arr = GridView3.GetSelectedRows()
        If arr Is Nothing Then
        Else
            Array.Sort(arr)
            For Each i In arr
                s = i.ToString
                dr1 = GridView3.GetDataRow(s)
                nKapamaID = sorgu_sayi(sorgu_tbFirmaKapama_nkayit_kontrol(dr("nHareketID")), 0)
                tbFirmaKapama_kaydet_sil(0, dr("nHareketID"), dr1("nHareketID"), 0, "")
                If nKapamaID > 0 Then
                    lOdenen = sorgu_sayi(sorgu_tbFirmaKapama_lOdenen_kontrol(dr("nHareketID")), 0)
                    If lOdenen = 0 Then
                        tbFirmaKapama_kaydet_sil(nKapamaID, dr("nHareketID"), 0, lOdenen, "")
                    Else
                        tbFirmaKapama_kaydet_duzelt(nKapamaID, dr("nHareketID"), 0, lOdenen, "")
                    End If
                ElseIf nKapamaID = 0 Then
                    'tbFirmaKapama_kaydet_yeni(0, dr("nHareketID"), 0, lOdenen, "")
                End If
            Next
        End If
        nKapamaID = Nothing
        lOdenen = Nothing
        Dim satir As Integer = GridView1.FocusedRowHandle
        Dataload_tbFirmaHesabi(nFirmaID, sec_bKapanan.Checked)
        GridView1.FocusedRowHandle = satir
    End Sub
    Private Sub giris_hesapla()
        Dim s As String
        Dim arr As Integer()
        Dim i As Integer
        Dim tutar = 0
        Dim vade
        Dim dr As DataRow
        Dim gun As Decimal = 0
        Dim tutarvade As Decimal = 0
        Dim ortvade As Decimal = 0
        Dim ortgun As Decimal = 0
        Dim dteFisTarihi As DateTime = Today
        Dim dr2 As DataRow = GridView1.GetDataRow(GridView1.FocusedRowHandle)
        'If GridView2.RowCount = 0 Then
        '    pesinat_satir_ekle(dr2("KALAN"))
        '    GridControl2.Focus()
        '    GridControl2.Select()
        '    GridView1.FocusedRowHandle = 1
        'End If
        'dr_odeme = GridView2.GetDataRow(GridView2.FocusedRowHandle)
        arr = GridView1.GetSelectedRows()
        If arr Is Nothing Then
        Else
            Array.Sort(arr)
            For Each i In arr
                s = i.ToString
                dr = GridView1.GetDataRow(s)
                tutar = tutar + dr("lKalan")
                Try
                    gun = DateDiff(DateInterval.Day, dteFisTarihi, dr("dteValorTarihi"))
                Catch ex As Exception
                    gun = 0
                End Try
                tutarvade = tutarvade + (dr("lKalan") * gun)
            Next
        End If
        Try
            ortvade = tutarvade / tutar
            lbl_secilenTutar_sayi.Text = GridView1.SelectedRowsCount
            lbl_secilenTutar.Text = FormatNumber(tutar, 2)
            'lbl_odenen.Text = FormatNumber(tutar, 2)
            'lbl_paraustu.Text = "0.00"o
            lbl_SecilenTutar_gun.Text = CInt(ortvade)
            lbl_SecilenTutar_ortvade.Text = DateAdd(DateInterval.Day, CInt(ortvade), dteFisTarihi)
        Catch ex As Exception
            ortvade = 0
            lbl_secilenTutar_sayi.Text = GridView1.SelectedRowsCount
            lbl_secilenTutar.Text = FormatNumber(tutar, 2)
            'lbl_odenen.Text = FormatNumber(tutar, 2)
            'lbl_paraustu.Text = "0.00"
            lbl_SecilenTutar_gun.Text = CInt(ortvade)
            lbl_SecilenTutar_ortvade.Text = ""
        End Try
        dr2 = Nothing
        dr = Nothing
        s = Nothing
        i = Nothing
        tutar = Nothing
        vade = Nothing
        gun = Nothing
    End Sub
    Private Sub giris_hesapla_karsilik()
        Dim s As String
        Dim arr As Integer()
        Dim i As Integer
        Dim tutar = 0
        Dim vade
        Dim dr As DataRow
        Dim gun As Decimal = 0
        Dim tutarvade As Decimal = 0
        Dim ortvade As Decimal = 0
        Dim ortgun As Decimal = 0
        Dim dteFisTarihi As DateTime = Today
        Dim dr2 As DataRow = GridView2.GetDataRow(GridView2.FocusedRowHandle)
        'If GridView2.RowCount = 0 Then
        '    pesinat_satir_ekle(dr2("KALAN"))
        '    GridControl2.Focus()
        '    GridControl2.Select()
        '    Gridview2.FocusedRowHandle = 1
        'End If
        'dr_odeme = GridView2.GetDataRow(GridView2.FocusedRowHandle)
        arr = GridView2.GetSelectedRows()
        If arr Is Nothing Then
        Else
            Array.Sort(arr)
            For Each i In arr
                s = i.ToString
                dr = GridView2.GetDataRow(s)
                tutar = tutar + dr("lKalan")
                Try
                    gun = DateDiff(DateInterval.Day, dteFisTarihi, dr("dteValorTarihi"))
                Catch ex As Exception
                    gun = 0
                End Try
                tutarvade = tutarvade + (dr("lKalan") * gun)
            Next
        End If
        Try
            ortvade = tutarvade / tutar
            lbl_secilen_sayi.Text = GridView2.SelectedRowsCount
            lbl_secilen.Text = FormatNumber(tutar, 2)
            'lbl_odenen.Text = FormatNumber(tutar, 2)
            'lbl_paraustu.Text = "0.00"o
            lbl_gun.Text = CInt(ortvade)
            lbl_ortvade.Text = DateAdd(DateInterval.Day, CInt(ortvade), dteFisTarihi)
        Catch ex As Exception
            ortvade = 0
            lbl_secilen_sayi.Text = GridView2.SelectedRowsCount
            lbl_secilen.Text = FormatNumber(tutar, 2)
            'lbl_odenen.Text = FormatNumber(tutar, 2)
            'lbl_paraustu.Text = "0.00"
            lbl_gun.Text = CInt(ortvade)
            lbl_ortvade.Text = ""
        End Try
        dr2 = Nothing
        dr = Nothing
        s = Nothing
        i = Nothing
        tutar = Nothing
        vade = Nothing
        gun = Nothing
    End Sub
    Private Sub SimpleButton3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SimpleButton3.Click
        If XtraMessageBox.Show(Sorgu_sDil("Seçili Kayýtlara Hesap Kapatma Ýþlemi Yapmak Ýstediðinize Emin misiniz...?", sDil), Sorgu_sDil("Dikkat", sDil), MessageBoxButtons.YesNo, MessageBoxIcon.Question) Then
            tbFirma_HesapKapat()
            txt_musteriNo.EditValue = sKodu
            dataload(nFirmaID)
        End If
    End Sub
    Private Sub SimpleButton4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SimpleButton4.Click
        If XtraMessageBox.Show(Sorgu_sDil("Seçili Kayýtlarýn Hesap Kapatma Ýþlemini Ýptal Etmek Ýstediðinize Emin misiniz...?", sDil), Sorgu_sDil("Dikkat", sDil), MessageBoxButtons.YesNo, MessageBoxIcon.Question) Then
            tbFirma_HesapKapat_iptal()
        End If
    End Sub
    Private Sub SimpleButton5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SimpleButton5.Click
        If XtraMessageBox.Show(Sorgu_sDil("Seçili Kayýtlarýn Hesap Kapatma Ýþlemlerinin Tümünü Ýptal Etmek Ýstediðinize Emin misiniz...?", sDil), Sorgu_sDil("Dikkat", sDil), MessageBoxButtons.YesNo, MessageBoxIcon.Question) Then
            tbFirmaKapama_guncelle(txt_musteriNo.Text, "Kodu", "Eþittir")
            txt_musteriNo.EditValue = sKodu
            dataload(nFirmaID)
        End If
    End Sub
    Private Sub tbFirmaKapama_guncelle(ByVal ara As String, ByVal konum As String, ByVal ara_kriter As String)
        Dim cmd As New OleDb.OleDbCommand
        Dim con As New OleDb.OleDbConnection
        cmd.Connection = con
        con.ConnectionString = connection
        If con.State = ConnectionState.Closed = True Then
            con.Open()
        End If
        Dim kriter As String = "Where tbFirma.nFirmaID >0 "
        If konum = "Kodu" Then
            kriter += " AND ( tbFirma.sKodu " & sorgu_kriter_string(ara, ara_kriter) & " )"
        ElseIf konum = "Adý" Then
            kriter += " AND ( tbFirma.sAciklama " & sorgu_kriter_string(ara, ara_kriter) & " )"
        ElseIf konum = "Ýstihbarat" Then
            kriter += " AND (( tbFirmaAciklamasi.sAciklama1 + ' ' + tbFirmaAciklamasi.sAciklama2 + ' ' + tbFirmaAciklamasi.sAciklama3 + ' ' + tbFirmaAciklamasi.sAciklama4 + '  ' + tbFirmaAciklamasi.sAciklama5) " & sorgu_kriter_string(ara, ara_kriter) & " )"
        ElseIf konum = "Adres" Then
            kriter += " AND ( tbFirma.sAdres1 + ' ' + tbFirma.sAdres2 + ' ' + tbFirma.sSemt + ' ' + tbFirma.sIl + ' ' + tbFirma.sUlke + ' ' + tbFirma.sPostaKodu  " & sorgu_kriter_string(ara, ara_kriter) & " )"
        ElseIf konum = "Sýnýf1" Then
            'kriter += " AND (tbFSinif1.sAciklama " & sorgu_kriter_string(ara, ara_kriter) & " )"
            kriter += "AND tbFirma.nFirmaID IN (SELECT     tbFirmaSinifi.nFirmaID FROM         tbFirmaSinifi INNER JOIN tbFSinif1 ON tbFirmaSinifi.sSinifKodu1 = tbFSinif1.sSinifKodu WHERE tbFSinif1.sAciklama " & sorgu_kriter_string(ara, ara_kriter) & " )"
        ElseIf konum = "Sýnýf2" Then
            'kriter += " AND (tbFSinif2.sAciklama " & sorgu_kriter_string(ara, ara_kriter) & " )"
            kriter += "AND tbFirma.nFirmaID IN (SELECT     tbFirmaSinifi.nFirmaID FROM         tbFirmaSinifi INNER JOIN tbFSinif2 ON tbFirmaSinifi.sSinifKodu2 = tbFSinif2.sSinifKodu WHERE tbFSinif2.sAciklama " & sorgu_kriter_string(ara, ara_kriter) & " )"
        ElseIf konum = "Sýnýf3" Then
            'kriter += " AND (tbFSinif3.sAciklama " & sorgu_kriter_string(ara, ara_kriter) & " )"
            kriter += "AND tbFirma.nFirmaID IN (SELECT     tbFirmaSinifi.nFirmaID FROM         tbFirmaSinifi INNER JOIN tbFSinif3 ON tbFirmaSinifi.sSinifKodu3 = tbFSinif3.sSinifKodu WHERE tbFSinif3.sAciklama " & sorgu_kriter_string(ara, ara_kriter) & " )"
        ElseIf konum = "Sýnýf4" Then
            'kriter += " AND (tbFSinif4.sAciklama " & sorgu_kriter_string(ara, ara_kriter) & " )"
            kriter += "AND tbFirma.nFirmaID IN (SELECT     tbFirmaSinifi.nFirmaID FROM         tbFirmaSinifi INNER JOIN tbFSinif4 ON tbFirmaSinifi.sSinifKodu4 = tbFSinif4.sSinifKodu WHERE tbFSinif4.sAciklama " & sorgu_kriter_string(ara, ara_kriter) & " )"
        ElseIf konum = "Sýnýf5" Then
            'kriter += " AND (tbFSinif5.sAciklama " & sorgu_kriter_string(ara, ara_kriter) & " )"
            kriter += "AND tbFirma.nFirmaID IN (SELECT     tbFirmaSinifi.nFirmaID FROM         tbFirmaSinifi INNER JOIN tbFSinif5 ON tbFirmaSinifi.sSinifKodu5 = tbFSinif5.sSinifKodu WHERE tbFSinif5.sAciklama " & sorgu_kriter_string(ara, ara_kriter) & " )"
        End If
        cmd.CommandText = sorgu_query("SET DATEFORMAT DMY SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED DELETE FROM tbFirmaKapama WHERE (nKarsilamaID IN (SELECT tbFirmaHareketi.nHareketID FROM tbFirmaHareketi INNER JOIN tbFirma ON tbFirmaHareketi.nFirmaID = tbFirma.nFirmaID " & kriter & "))")
        cmd.ExecuteNonQuery()
        con.Close()
        con.Dispose()
        cmd.Dispose()
        con = Nothing
        cmd = Nothing
    End Sub
    Private Sub GridView1_SelectionChanged(ByVal sender As Object, ByVal e As DevExpress.Data.SelectionChangedEventArgs) Handles GridView1.SelectionChanged
        giris_hesapla()
    End Sub
    Private Sub GridView2_SelectionChanged(ByVal sender As Object, ByVal e As DevExpress.Data.SelectionChangedEventArgs) Handles GridView2.SelectionChanged
        giris_hesapla_karsilik()
    End Sub
    Private Sub BarButtonItem1_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem1.ItemClick
        Me.Close()
    End Sub
    Private Sub BarButtonItem2_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem2.ItemClick
        Dim kriter As String = ""
        Dim kriter2 As String = Sorgu_sDil("Eþleþecek Hareketler", sDil) & vbCrLf
        Dim kriter3 As String = Sorgu_sDil("Eþleþmiþ Hareketler", sDil) & vbCrLf
        Dim sEvrakTipi As String = ""
        If bBakiye = False Then
            sEvrakTipi = Sorgu_sDil("Alacak Eþleþtir", sDil)
        ElseIf bBakiye = True Then
            sEvrakTipi = Sorgu_sDil("Borç Eþleþtir", sDil)
        End If
        kriter += "EvrakTipi = " & sEvrakTipi & vbCrLf
        kriter += "Secilen Evrak: " & lbl_secilenTutar_sayi.Text & " Secilen Tutar: " & lbl_secilenTutar.Text & " OrtGun:  " & lbl_SecilenTutar_gun.Text & " OrtVade: " & lbl_SecilenTutar_ortvade.Text
        kriter2 += "Secilen Evrak: " & lbl_secilen_sayi.Text & " Secilen Tutar: " & lbl_secilen.Text & " OrtGun:  " & lbl_gun.Text & " OrtVade: " & lbl_ortvade.Text
        Printlink1.PageHeaderFooter = New DevExpress.XtraPrinting.PageHeaderFooter(New DevExpress.XtraPrinting.PageHeaderArea(New String() {"[User Name]", kriter, "[Date Printed][Time Printed]"}, New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte)), DevExpress.XtraPrinting.BrickAlignment.Far), New DevExpress.XtraPrinting.PageFooterArea(New String() {"Powered by www.barkodyazilimevi.com", "Finans Yönetimi", "[Page # of Pages #]"}, New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte)), DevExpress.XtraPrinting.BrickAlignment.Near))
        Printlink2.PageHeaderFooter = New DevExpress.XtraPrinting.PageHeaderFooter(New DevExpress.XtraPrinting.PageHeaderArea(New String() {"[User Name]", kriter2, "[Date Printed][Time Printed]"}, New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte)), DevExpress.XtraPrinting.BrickAlignment.Far), New DevExpress.XtraPrinting.PageFooterArea(New String() {"Powered by www.barkodyazilimevi.com", "Finans Yönetimi", "[Page # of Pages #]"}, New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte)), DevExpress.XtraPrinting.BrickAlignment.Near))
        Printlink3.PageHeaderFooter = New DevExpress.XtraPrinting.PageHeaderFooter(New DevExpress.XtraPrinting.PageHeaderArea(New String() {"[User Name]", kriter3, "[Date Printed][Time Printed]"}, New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte)), DevExpress.XtraPrinting.BrickAlignment.Far), New DevExpress.XtraPrinting.PageFooterArea(New String() {"Powered by www.barkodyazilimevi.com", "Finans Yönetimi", "[Page # of Pages #]"}, New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte)), DevExpress.XtraPrinting.BrickAlignment.Near))
        If GridControl1.Focused = True Then
            Printlink1.CreateDocument(ps)
            ps.PreviewRibbonFormEx.Show()
        ElseIf GridControl2.Focused = True Then
            Printlink2.CreateDocument(ps)
            ps.PreviewRibbonFormEx.Show()
        ElseIf GridControl3.Focused = True Then
            Printlink3.CreateDocument(ps)
            ps.PreviewRibbonFormEx.Show()
        End If
    End Sub
End Class