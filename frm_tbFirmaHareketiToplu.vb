Imports FastReport
Imports Microsoft.Win32
Imports DevExpress.XtraEditors
Imports System.IO
Public Class frm_tbFirmaHareketiToplu
    
    Public firmano
    Public donemno
    Public connection
    Public kullanici
    Public sModul As String = "Cari"
    Dim nFirmaID As Int64 = 0
    Dim sKodu As String = ""
    Dim ds_tbsube As DataSet
    Dim ds_tbDovizCinsi As DataSet
    Dim ds_tbHareketTipi As DataSet
    Dim ds_tbCariIslem As DataSet
    Dim ds_cari As DataSet
    Dim ds_Firma As DataSet

    Dim mevcut As Decimal = 1
    Dim x As Integer = 0
    Dim okut As Boolean = False
    Private Sub frm_tbNakitKasa_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        txt_dteTarih1.EditValue = dteSistemTarihi
        txt_dteTarih2.EditValue = dteSistemTarihi
        dataload_tbDovizCinsi()
        dataload_tbHareketTipi()
        dataload_tbsCariIslem()
        'If sKodu = "" Then
        '    firma_sec()
        'End If
        Try
            gorunum_yukle()
        Catch ex As Exception
        End Try
    End Sub
    Private Sub dataload_tbDovizCinsi()
        ds_tbDovizCinsi = sorgu(sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT     sDovizCinsi,sAciklama FROM         tbDovizCinsi"))
        sec_sDovizCinsi.DataSource = ds_tbDovizCinsi.Tables(0)
    End Sub
    Private Sub dataload_tbHareketTipi()
        ds_tbHareketTipi = sorgu(sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT     CAST(sHareketTipi AS CHAR(4)) AS sHareketTipi, sAciklama FROM         tbHareketTipi where aktif = 1"))
        sec_sHareketTipi.DataSource = ds_tbHareketTipi.Tables(0)
    End Sub
    Private Sub dataload_tbsCariIslem()
        ds_tbCariIslem = sorgu(sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT     sCariIslem,sAciklama FROM         tbCariIslem"))
        sec_sCariIslem.DataSource = ds_tbCariIslem.Tables(0)
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
        GridView1.RestoreLayoutFromRegistry("SOFTWARE\BusinessSmart\VIEW\MAGAZA\" & Me.Name.ToString & "")
    End Sub
    Private Function sorgu_query(ByVal query As String) As String
        query = Replace(query, "*!F", "F0" + firmano.ToString)
        query = Replace(query, "!D", "D000" + donemno.ToString)
        Return query
    End Function
    Private Function KayitSiniri_kontrol(ByVal tbTable As String, ByVal kriter As String, ByVal nKayitSinir As Integer) As Boolean
        Dim pass As Boolean = False
        If nKayitSinir > 0 Then
            Dim yetki As Int64 = Sorgu_tbKayitSayisi(tbTable, kriter, nKayitSinir)
            If yetki = 0 Then
                XtraMessageBox.Show(Sorgu_sDil("Üzgünüm Kýsýtlý Kullaným.Maximum Kayýt Sýnýrýný Aþamazsýnýz...!" & vbCrLf & "Lütfen Yetkili Satýcýnýzla Görüþün...", sDil), Sorgu_sDil("Dikkat", sDil), MessageBoxButtons.OK, MessageBoxIcon.Information)
                pass = False
            ElseIf yetki = 1 Then
                pass = True
            End If
        Else
            pass = True
        End If
        Return pass
    End Function
    Private Function Sorgu_tbKayitSayisi(ByVal tbTable As String, ByVal kriter As String, ByVal nKayitSinir As Integer) As Int64
        Dim cmd As New OleDb.OleDbCommand
        Dim con As New OleDb.OleDbConnection
        cmd.Connection = con
        con.ConnectionString = connection
        If con.State = ConnectionState.Closed Then
            con.Open()
        End If
        Dim kayitsayisi As Int64 = 0
        Dim formkayitsayisi As Int64 = 0
        cmd.CommandText = sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT     ISNULL(COUNT(*), 0) AS Kayit FROM         " & tbTable & "  " & kriter & " ")
        formkayitsayisi = cmd.ExecuteScalar
        con.Close()
        If formkayitsayisi >= nKayitSinir Then
            kayitsayisi = 0
        Else
            kayitsayisi = 1
        End If
        Return kayitsayisi
        'kayitsayisi = Nothing
        formkayitsayisi = Nothing
        cmd = Nothing
        con = Nothing
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
    'Public Function sorgu_nCariHareketID() As Int64
    '    Dim kriter As String = ""
    '    'kriter = "WHERE (sKodu = '" & kod & "')  "
    '    Dim conn As New OleDb.OleDbConnection
    '    Dim cmd As New OleDb.OleDbCommand
    '    Dim adapter As New OleDb.OleDbDataAdapter
    '    'MsgBox(connection_resmi)
    '    conn.ConnectionString = connection
    '    cmd.Connection = conn
    '    conn.Open()
    '    cmd.CommandText = sorgu_query("SET DATEFORMAT DMY SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT     TOP 1 ISNULL(nHareketID + 1, 0) AS nCariHareketID  FROM         tbFirmaHareketi " & kriter & " ORDER BY nHareketID DESC")
    '    Dim kayitsayisi = cmd.ExecuteScalar
    '    Return kayitsayisi
    'End Function
    Public Function sorgu_nCariHareketID() As Int64
        Dim kriter As String = ""
        Dim con As New OleDb.OleDbConnection
        Dim cmd As New OleDb.OleDbCommand
        Dim adapter As New OleDb.OleDbDataAdapter
        con.ConnectionString = connection
        cmd.CommandTimeout = Nothing
        cmd.Connection = con
        con.Open()
        cmd.CommandText = sorgu_query("SET DATEFORMAT DMY SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT     ISNULL(MAX(nHareketID), 0) + 1 AS nCariHareketID FROM         tbFirmaHareketi")
        Dim kayitsayisi = cmd.ExecuteScalar
        Return kayitsayisi
        con.Dispose()
        cmd.Dispose()
        adapter.Dispose()
        cmd = Nothing
    End Function
    Public Function sorgu_nKasaIslemID() As Int64
        Dim kriter As String = ""
        'kriter = "WHERE (sKodu = '" & kod & "')  "
        Dim conn As New OleDb.OleDbConnection
        Dim cmd As New OleDb.OleDbCommand
        Dim adapter As New OleDb.OleDbDataAdapter
        'MsgBox(connection_resmi)
        conn.ConnectionString = connection
        cmd.Connection = conn
        conn.Open()
        cmd.CommandText = sorgu_query("SET DATEFORMAT DMY SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT     TOP 1 ISNULL(nKasaIslemID + 1, 0) AS nKasaIslemID  FROM         tbNakitKasa " & kriter & " ORDER BY nKasaIslemID DESC")
        Dim kayitsayisi = cmd.ExecuteScalar
        Return kayitsayisi
    End Function
    Public Sub Dataload_tbFirmaHareketi(ByVal nFirmaID As String, ByVal sKodu As String, ByVal dteTarih1 As DateTime, ByVal dteTarih2 As DateTime)
        Try
            ds_tbFirmaHareketi.Tables(0).Clear()
        Catch ex As Exception
        End Try
        Dim conn As New OleDb.OleDbConnection
        Dim cmd As New OleDb.OleDbCommand
        Dim adapter As New OleDb.OleDbDataAdapter
        conn.ConnectionString = connection
        adapter.SelectCommand = cmd
        cmd.CommandText = sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT tbFirmaHareketi.*, tbFirma.sKodu AS sFirmaKodu, tbFirma.sAciklama AS sFirmaAciklama FROM tbFirmaHareketi INNER JOIN tbFirma ON tbFirmaHareketi.nFirmaID = tbFirma.nFirmaID WHERE (tbFirmaHareketi.dteIslemTarihi BETWEEN '" & dteTarih1 & "' AND '" & dteTarih2 & "')  Order by tbFirmaHareketi.nHareketID ")
        cmd.Connection = conn
        conn.Open()
        Dim N As Integer = adapter.Fill(ds_tbFirmaHareketi, "Table1")
        conn.Close()
        Dataload_tbYekun(nFirmaID, sKodu, txt_dteTarih1.EditValue, txt_dteTarih2.EditValue)
        If GridView1.RowCount > 0 Then
            Dim dr As DataRow = GridView1.GetDataRow(GridView1.FocusedRowHandle)
            Dataload_tbFirma(dr("sFirmaKodu"))
            dr = Nothing
        End If
        GridControl1.Refresh()
        If GridView1.RowCount > 0 Then
            GridView1.ClearSelection()
            GridView1.SelectRow(GridView1.RowCount - 1)
            PanelControl3.Focus()
            GridControl1.Focus()
        End If
        GridView1.FocusedColumn = coldteIslemTarihi
    End Sub
    Public Sub Dataload_tbYekun(ByVal nFirmaID As String, ByVal sKodu As String, ByVal dteTarih1 As DateTime, ByVal dteTarih2 As DateTime)
        Try
            ds_tbNakitKasaToplam.Tables(0).Clear()
        Catch ex As Exception
        End Try
        Dim conn As New OleDb.OleDbConnection
        Dim cmd As New OleDb.OleDbCommand
        Dim adapter As New OleDb.OleDbDataAdapter
        conn.ConnectionString = connection
        adapter.SelectCommand = cmd
        cmd.CommandText = sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT 'Bugün' AS sAciklama, ISNULL(SUM(lBorcTutar), 0) AS lBorcTutar, ISNULL(SUM(lAlacakTutar), 0) AS lAlacakTutar, ISNULL(SUM(lBorcTutar - lAlacakTutar), 0) AS lBakiye FROM tbFirmaHareketi WHERE (dteIslemTarihi BETWEEN '" & dteTarih1 & "' AND '" & dteTarih2 & "') and nFirmaID = '" & nFirmaID & "' ")
        cmd.Connection = conn
        conn.Open()
        Dim N As Integer = adapter.Fill(ds_tbNakitKasaToplam, "TOPLAM")
        conn.Close()
    End Sub
    Public Sub Dataload_tbFirma(ByVal sFirmaKodu As String)
        Try
            ds_tbFirma.Tables(0).Clear()
        Catch ex As Exception
        End Try
        Dim conn As New OleDb.OleDbConnection
        Dim cmd As New OleDb.OleDbCommand
        Dim adapter As New OleDb.OleDbDataAdapter
        conn.ConnectionString = connection
        adapter.SelectCommand = cmd
        cmd.CommandText = sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT nFirmaID, sKodu, sAciklama, nOzelIskontosu, lKrediLimiti, nVadeGun, nHesapID, (SELECT ISNULL(SUM(lBorcTutar) , 0) AS lBorcTutar FROM tbFirmaHareketi WHERE nFirmaID = tbFirma.nFirmaID) AS lBorcTutar, (SELECT ISNULL(SUM(lAlacakTutar) , 0) AS lAlacakTutar FROM tbFirmaHareketi WHERE nFirmaID = tbFirma.nFirmaID) AS lAlacakTutar, (SELECT ISNULL(SUM(lBorcTutar - lAlacakTutar) , 0) AS lBakiye FROM tbFirmaHareketi WHERE nFirmaID = tbFirma.nFirmaID) AS lBakiye, (SELECT ISNULL(SUM(lTutar) , 0) AS Expr1 FROM tbCekSenet WHERE (nVerenID = tbFirma.nFirmaID) AND (sCekSenetTipi = 'AC' OR sCekSenetTipi = 'AS') AND (nSonCekSenetIslem <= 6) AND (nSonCekSenetIslem <> 2)) AS lRisk FROM tbFirma WHERE (sKodu = '" & sFirmaKodu & "') ")
        cmd.Connection = conn
        conn.Open()
        Dim N As Integer = adapter.Fill(ds_tbFirma, "Table1")
        conn.Close()
    End Sub
    Private Sub tbFirmaHareketi_kaydet_sil(ByVal nHareketID As String)
        Dim con As New OleDb.OleDbConnection
        Dim cmd As New OleDb.OleDbCommand
        cmd.Connection = con
        con.ConnectionString = connection
        If con.State = ConnectionState.Closed = True Then
            con.Open()
        End If
        cmd.CommandText = sorgu_query("set implicit_transactions on")
        cmd.ExecuteNonQuery()
        Try
            cmd.CommandText = sorgu_query("SET DATEFORMAT DMY SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED ")
            cmd.ExecuteNonQuery()
            cmd.CommandText = sorgu_query("DELETE FROM tbFirmaHareketi Where nHareketID = '" & nHareketID & "'")
            cmd.ExecuteNonQuery()
            cmd.CommandText = sorgu_query("IF @@TRANCOUNT > 0 COMMIT TRAN")
            cmd.ExecuteNonQuery()
        Catch ex As Exception
            cmd.CommandText = sorgu_query("IF @@TRANCOUNT > 0 COMMIT TRAN")
            cmd.ExecuteNonQuery()
            XtraMessageBox.Show(Sorgu_sDil("Ýþlem Hatasý Lütfen Tekrar Deneyiniz...!", sDil), Sorgu_sDil("Dikkat", sDil), MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End Try
        cmd.CommandText = sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED UPDATE tbCariSiraNo SET nSonID = (SELECT TOP 1 ISNULL(nHareketID + 1 , 1) AS nSonID FROM tbFirmaHareketi ORDER BY nHareketID DESC) WHERE (nSiraIndex = 1)")
        cmd.ExecuteNonQuery()
        con.Close()
    End Sub
    Private Function tbFirmaHareketi_kaydet_yeni(ByVal nHareketID As Int64, ByVal nFirmaID As Int64, ByVal dteIslemTarihi As DateTime, ByVal dteValorTarihi As DateTime, ByVal sCariIslem As String, ByVal sAciklama As String, ByVal lBorcTutar As Decimal, ByVal lAlacakTutar As Decimal, ByVal sEvrakNo As String, ByVal lVadeFarki As Decimal, ByVal sHangiUygulama As String, ByVal sHareketTipi As String, ByVal sKullaniciAdi As String, ByVal dteKayitTarihi As DateTime, ByVal sDovizCinsi1 As String, ByVal lDovizMiktari1 As Decimal, ByVal lDovizKuru1 As Decimal, ByVal sDovizCinsi2 As String, ByVal lDovizMiktari2 As Decimal, ByVal lDovizKuru2 As Decimal, ByVal sSonKullaniciAdi As String, ByVal dteSonUpdateTarihi As DateTime) As Int64
        Dim con As New OleDb.OleDbConnection
        Dim cmd As New OleDb.OleDbCommand
        cmd.Connection = con
        con.ConnectionString = connection
        If con.State = ConnectionState.Closed = True Then
            con.Open()
        End If
        cmd.CommandText = sorgu_query("SET DATEFORMAT DMY  INSERT INTO tbFirmaHareketi                       (nFirmaID, dteIslemTarihi, dteValorTarihi, sCariIslem, sAciklama, lBorcTutar, lAlacakTutar, sEvrakNo, lVadeFarki, sHangiUygulama, sHareketTipi, sKullaniciAdi, dteKayitTarihi, sDovizCinsi1, lDovizMiktari1, lDovizKuru1, sDovizCinsi2, lDovizMiktari2, lDovizKuru2, sSonKullaniciAdi, dteSonUpdateTarihi) VALUES     ('" & nFirmaID & "', '" & dteIslemTarihi & "', '" & dteValorTarihi & "', '" & sCariIslem & "', N'" & sAciklama & "', " & lBorcTutar & ", " & lAlacakTutar & " , '" & sEvrakNo & "', " & lVadeFarki & ", '" & sHangiUygulama & "', '" & sHareketTipi & "', '" & sKullaniciAdi & "', '" & dteKayitTarihi & "', '" & sDovizCinsi1 & "', " & lDovizMiktari1 & ", " & lDovizKuru1 & " , '" & sDovizCinsi2 & "', " & lDovizMiktari2 & ", " & lDovizKuru2 & " , '" & sSonKullaniciAdi & "', '" & dteSonUpdateTarihi & "')")
        cmd.ExecuteNonQuery()
        cmd.CommandText = "SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT @@identity"
        nHareketID = cmd.ExecuteScalar
        Return nHareketID
        con.Close()
    End Function
    Private Sub tbFirmaHareketi_kaydet_duzelt(ByVal nHareketID As Int64, ByVal nFirmaID As Int64, ByVal dteIslemTarihi As DateTime, ByVal dteValorTarihi As DateTime, ByVal sCariIslem As String, ByVal sAciklama As String, ByVal lBorcTutar As Decimal, ByVal lAlacakTutar As Decimal, ByVal sEvrakNo As String, ByVal lVadeFarki As Decimal, ByVal sHangiUygulama As String, ByVal sHareketTipi As String, ByVal sKullaniciAdi As String, ByVal dteKayitTarihi As DateTime, ByVal sDovizCinsi1 As String, ByVal lDovizMiktari1 As Decimal, ByVal lDovizKuru1 As Decimal, ByVal sDovizCinsi2 As String, ByVal lDovizMiktari2 As Decimal, ByVal lDovizKuru2 As Decimal, ByVal sSonKullaniciAdi As String, ByVal dteSonUpdateTarihi As DateTime)
        Dim con As New OleDb.OleDbConnection
        Dim cmd As New OleDb.OleDbCommand
        cmd.Connection = con
        con.ConnectionString = connection
        If con.State = ConnectionState.Closed = True Then
            con.Open()
        End If
        cmd.CommandText = sorgu_query("SET DATEFORMAT DMY  UPDATE    tbFirmaHareketi SET              nFirmaID = '" & nFirmaID & "', dteIslemTarihi = '" & dteIslemTarihi & "', dteValorTarihi = '" & dteValorTarihi & "', sCariIslem = '" & sCariIslem & "', sAciklama = N'" & sAciklama & "', lBorcTutar = " & lBorcTutar & ", lAlacakTutar = " & lAlacakTutar & ", sEvrakNo = '" & sEvrakNo & "', lVadeFarki = " & lVadeFarki & ", sHangiUygulama = '" & sHangiUygulama & "', sHareketTipi = '" & sHareketTipi & "', sDovizCinsi1 = '" & sDovizCinsi1 & "', lDovizMiktari1 = " & lDovizMiktari1 & ", lDovizKuru1 = " & lDovizKuru1 & ", sDovizCinsi2 = '" & sDovizCinsi2 & "', lDovizMiktari2 = " & lDovizMiktari2 & ", lDovizKuru2 = " & lDovizKuru2 & ", sSonKullaniciAdi = '" & sSonKullaniciAdi & "', dteSonUpdateTarihi = '" & dteSonUpdateTarihi & "'  WHERE     (nHareketID = " & nHareketID & ")")
        cmd.ExecuteNonQuery()
        con.Close()
    End Sub
    Private Sub nCariHareketID_degistir(ByVal nCariHareketID As String)
        Dim con As New OleDb.OleDbConnection
        Dim cmd As New OleDb.OleDbCommand
        Dim adapter As New OleDb.OleDbDataAdapter
        con.ConnectionString = connection
        cmd.Connection = con
        If con.State = ConnectionState.Closed Then
            con.Open()
        End If
        cmd.CommandText = sorgu_query("SET DATEFORMAT DMY SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED UPDATE    tbCariSiraNo SET              nSonID = '" & nCariHareketID & "' where nSiraIndex = 1")
        cmd.ExecuteNonQuery()
        con.Close()
    End Sub
    Private Sub nKasaIslemID_degistir(ByVal nKasaIslemID As String)
        Dim con As New OleDb.OleDbConnection
        Dim cmd As New OleDb.OleDbCommand
        Dim adapter As New OleDb.OleDbDataAdapter
        con.ConnectionString = connection
        cmd.Connection = con
        If con.State = ConnectionState.Closed Then
            con.Open()
        End If
        cmd.CommandText = sorgu_query("SET DATEFORMAT DMY SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED UPDATE    tbCariSiraNo SET              nSonID = '" & nKasaIslemID & "' where nSiraIndex = 2")
        cmd.ExecuteNonQuery()
        con.Close()
    End Sub
    Private Sub firma_sec()
        'Dim dr As DataRow
        'dr = GridView1.GetDataRow(GridView1.FocusedRowHandle)
        'Dim frm As New frm_firma_liste
        'frm.firmano = firmano
        'frm.donemno = donemno
        'frm.connection = connection
        'frm.islemstatus = True
        'frm.kullanici = kullanici
        'If frm.ShowDialog(Me) = Windows.Forms.DialogResult.OK Then
        '    Dim dr1 As DataRow
        '    dr1 = frm.GridView1.GetDataRow(frm.GridView1.FocusedRowHandle)
        '    nFirmaID = dr1("nFirmaID")
        '    sKodu = dr1("sKodu")
        '    lbl_Firma.Text = dr1("sAciklama")
        '    txt_musteriNo.EditValue = sKodu
        '    musteri_kontrol()
        '    dr1 = Nothing
        'End If
    End Sub
    Private Sub musteri_kontrol()
        'If Trim(txt_musteriNo.EditValue).ToString <> "" Then
        '    Dim kontrol = sorgu_cari_kontrol(txt_musteriNo.EditValue)
        '    If kontrol = 0 Then
        '        XtraMessageBox.Show(Sorgu_sDil("Kayýt Bulunumadý...",sDil),  MessageBoxIcon.Exclamation)
        '    ElseIf kontrol = 1 Then
        '        dataload_cari(txt_musteriNo.EditValue)
        '        Dim dr As DataRow
        '        For Each dr In ds_cari.Tables(0).Rows
        '            'txt_Musteri.EditValue = dr("MUSTERI")
        '            sKodu = dr("sKodu")
        '            nFirmaID = dr("nFirmaID")
        '        Next
        '        dr = Nothing
        '    End If
        'End If
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
    Private Sub dataload_cari(ByVal kod As String)
        Dim kriter
        kriter = "WHERE (sKodu = '" & kod & "') "
        ds_cari = sorgu(sorgu_query("SELECT     nFirmaId,sKodu,sAciklama FROM         tbFirma " & kriter & ""))
    End Sub
    Private Sub satir_ekle(Optional ByVal sAra As String = "", Optional ByVal sKriter As String = "Baþlar")
        If KayitSiniri_kontrol("tbFirmaHareketi", "", nKayitSinir) = True Then
            Dim frm As New frm_firma_liste
            frm.islemstatus = True
            frm.connection = connection
            frm.firmano = firmano
            frm.donemno = donemno
            frm.islemstatus = True
            frm.kullanici = kullanici
            frm.sModul = sModul
            If sAra <> "" Then
                frm.txt_ara.Text = sAra
                frm.sec_konum.Text = "Geliþmiþ"
                frm.sec_kriter.Text = sKriter
            End If
            If frm.ShowDialog(Me) = Windows.Forms.DialogResult.OK Then
                Dim s As String
                Dim arr As Integer()
                Dim i As Integer
                Dim dr As DataRow
                Dim dr1 As DataRow
                arr = frm.GridView1.GetSelectedRows()
                If arr Is Nothing Then
                Else
                    Array.Sort(arr)
                    For Each i In arr
                        s = i.ToString
                        dr = ds_tbFirmaHareketi.Tables(0).NewRow
                        dr1 = frm.GridView1.GetDataRow(s)
                        Dim nCariHareketID = sorgu_nCariHareketID()
                        dr("nHareketID") = nCariHareketID
                        dr("nFirmaID") = dr1("nFirmaID")
                        dr("dteIslemTarihi") = txt_dteTarih2.EditValue
                        dr("dteValorTarihi") = txt_dteTarih2.EditValue
                        dr("sCariIslem") = ""
                        dr("sAciklama") = dr1("sAciklama")
                        dr("lBorcTutar") = 0
                        dr("lAlacakTutar") = 0
                        dr("sEvrakNo") = ""
                        dr("lVadeFarki") = 0
                        dr("sHangiUygulama") = ""
                        dr("sHareketTipi") = ""
                        dr("sKullaniciAdi") = kullanici
                        dr("dteKayitTarihi") = Now
                        dr("sDovizCinsi1") = ""
                        dr("lDovizMiktari1") = 0
                        dr("lDovizKuru1") = 0
                        dr("sDovizCinsi2") = ""
                        dr("lDovizMiktari2") = 0
                        dr("lDovizKuru2") = 0
                        dr("sSonKullaniciAdi") = kullanici
                        dr("dteSonUpdateTarihi") = Now
                        dr("sFirmaKodu") = dr1("sKodu")
                        dr("sFirmaAciklama") = dr1("sAciklama")
                        dr("nHareketID") = tbFirmaHareketi_kaydet_yeni(dr("nHareketID"), dr("nFirmaID"), dr("dteIslemTarihi"), dr("dteIslemTarihi"), "", dr("sAciklama"), dr("lBorcTutar"), dr("lAlacakTutar"), dr("sEvrakNo"), dr("lVadeFarki"), dr("sHangiUygulama"), dr("sHareketTipi"), dr("sKullaniciAdi"), dr("dteKayitTarihi"), dr("sDovizCinsi1"), dr("lDovizMiktari1"), dr("lDovizKuru1"), dr("sDovizCinsi2"), dr("lDovizMiktari2"), dr("lDovizKuru2"), dr("sKullaniciAdi"), dr("dteSonUpdateTarihi"))
                        nCariHareketID_degistir(dr("nHareketID"))
                        ds_tbFirmaHareketi.Tables(0).Rows.Add(dr)
                    Next
                End If
            End If
            frm.Close()
            frm = Nothing
            If GridView1.RowCount > 0 Then
                GridView1.ClearSelection()
                GridView1.SelectRow(GridView1.RowCount - 1)
                PanelControl3.Focus()
                GridControl1.Focus()
            End If
            GridView1.FocusedColumn = collBorcTutar
        End If
    End Sub
    Private Sub satir_ekle_firma_tek()
        If KayitSiniri_kontrol("tbFirmaHareketi", "", nKayitSinir) = True Then
            Dim dr As DataRow
            Dim dr1 As DataRow
            dr = ds_tbFirmaHareketi.Tables(0).NewRow
            dr1 = ds_Firma.Tables(0).Rows(0)
            Dim nCariHareketID = sorgu_nCariHareketID()
            dr("nHareketID") = nCariHareketID
            dr("nFirmaID") = dr1("nFirmaID")
            dr("dteIslemTarihi") = txt_dteTarih2.EditValue
            dr("dteValorTarihi") = txt_dteTarih2.EditValue
            dr("sCariIslem") = ""
            dr("sAciklama") = dr1("sAciklama")
            dr("lBorcTutar") = 0
            dr("lAlacakTutar") = 0
            dr("sEvrakNo") = ""
            dr("lVadeFarki") = 0
            dr("sHangiUygulama") = ""
            dr("sHareketTipi") = ""
            dr("sKullaniciAdi") = kullanici
            dr("dteKayitTarihi") = Now
            dr("sDovizCinsi1") = ""
            dr("lDovizMiktari1") = 0
            dr("lDovizKuru1") = 0
            dr("sDovizCinsi2") = ""
            dr("lDovizMiktari2") = 0
            dr("lDovizKuru2") = 0
            dr("sSonKullaniciAdi") = kullanici
            dr("dteSonUpdateTarihi") = Now
            dr("sFirmaKodu") = dr1("sKodu")
            dr("sFirmaAciklama") = dr1("sAciklama")
            dr("nHareketID") = tbFirmaHareketi_kaydet_yeni(dr("nHareketID"), dr("nFirmaID"), dr("dteIslemTarihi"), dr("dteIslemTarihi"), "", dr("sAciklama"), dr("lBorcTutar"), dr("lAlacakTutar"), dr("sEvrakNo"), dr("lVadeFarki"), dr("sHangiUygulama"), dr("sHareketTipi"), dr("sKullaniciAdi"), dr("dteKayitTarihi"), dr("sDovizCinsi1"), dr("lDovizMiktari1"), dr("lDovizKuru1"), dr("sDovizCinsi2"), dr("lDovizMiktari2"), dr("lDovizKuru2"), dr("sKullaniciAdi"), dr("dteSonUpdateTarihi"))
            nCariHareketID_degistir(dr("nHareketID"))
            ds_tbFirmaHareketi.Tables(0).Rows.Add(dr)
            If GridView1.RowCount > 0 Then
                GridView1.ClearSelection()
                GridView1.SelectRow(GridView1.RowCount - 1)
                PanelControl3.Focus()
                GridControl1.Focus()
            End If
            GridView1.FocusedColumn = collBorcTutar
            txt_ara.Text = ""
            txt_ara.Focus()
            txt_ara.SelectAll()
        End If
    End Sub
    Private Sub satir_ekle_tek()
        If KayitSiniri_kontrol("tbFirmaHareketi", "", nKayitSinir) = True Then
            Dim dr As DataRow
            dr = ds_tbFirmaHareketi.Tables(0).NewRow
            Dim nCariHareketID = sorgu_nCariHareketID()
            dr("nHareketID") = nCariHareketID
            dr("nFirmaID") = nFirmaID
            dr("dteIslemTarihi") = txt_dteTarih2.EditValue
            dr("dteValorTarihi") = txt_dteTarih2.EditValue
            dr("sCariIslem") = ""
            dr("sAciklama") = ""
            dr("lBorcTutar") = 0
            dr("lAlacakTutar") = 0
            dr("sEvrakNo") = ""
            dr("lVadeFarki") = 0
            dr("sHangiUygulama") = ""
            dr("sHareketTipi") = ""
            dr("sKullaniciAdi") = kullanici
            dr("dteKayitTarihi") = Now
            dr("sDovizCinsi1") = ""
            dr("lDovizMiktari1") = 0
            dr("lDovizKuru1") = 0
            dr("sDovizCinsi2") = ""
            dr("lDovizMiktari2") = 0
            dr("lDovizKuru2") = 0
            dr("sSonKullaniciAdi") = kullanici
            dr("dteSonUpdateTarihi") = Now
            dr("sFirmaKodu") = sKodu
            dr("sFirmaAciklama") = ""
            dr("nHareketID") = tbFirmaHareketi_kaydet_yeni(dr("nHareketID"), dr("nFirmaID"), dr("dteIslemTarihi"), dr("dteIslemTarihi"), "", dr("sAciklama"), dr("lBorcTutar"), dr("lAlacakTutar"), dr("sEvrakNo"), dr("lVadeFarki"), dr("sHangiUygulama"), dr("sHareketTipi"), dr("sKullaniciAdi"), dr("dteKayitTarihi"), dr("sDovizCinsi1"), dr("lDovizMiktari1"), dr("lDovizKuru1"), dr("sDovizCinsi2"), dr("lDovizMiktari2"), dr("lDovizKuru2"), dr("sKullaniciAdi"), dr("dteSonUpdateTarihi"))
            nCariHareketID_degistir(dr("nHareketID"))
            ds_tbFirmaHareketi.Tables(0).Rows.Add(dr)
            If GridView1.RowCount > 0 Then
                GridView1.ClearSelection()
                GridView1.SelectRow(GridView1.RowCount - 1)
                PanelControl3.Focus()
                GridControl1.Focus()
            End If
            GridView1.FocusedColumn = colsCariIslem
        End If
    End Sub
    Private Sub satir_sil()
        If GridView1.RowCount > 0 Then
            If XtraMessageBox.Show(Sorgu_sDil("Satýrý Silmek Ýstediðinize Emin misiniz...?", sDil), Sorgu_sDil("Dikkat", sDil), MessageBoxButtons.YesNo, MessageBoxIcon.Question) = MsgBoxResult.Yes Then
                Dim dr As DataRow
                dr = GridView1.GetDataRow(GridView1.FocusedRowHandle)
                tbFirmaHareketi_kaydet_sil(dr("nHareketID"))
                ds_tbFirmaHareketi.Tables(0).Rows.Remove(dr)
                GridControl1.Focus()
                GridControl1.Select()
                If GridView1.RowCount > 0 Then
                    GridView1.SelectRow(GridView1.FocusedRowHandle)
                End If
                'GridView1.DeleteRow(GridView1.FocusedRowHandle)
            End If
        End If
    End Sub
    Private Sub tutar_hesapla()
        If GridView1.RowCount > 0 Then
            Dim dr As DataRow
            dr = GridView1.GetDataRow(GridView1.FocusedRowHandle)
            If Trim(dr("sDovizCinsi1")) = "" Then
                dr("lDovizKuru1") = 0
                dr("lDovizMiktari1") = 0
            End If
            If Trim(dr("sDovizCinsi2")) = "" Then
                dr("lDovizKuru2") = 0
                dr("lDovizMiktari2") = 0
            End If
            If GridView1.FocusedColumn.Name = collDovizMiktari1.Name.ToString Then
                If Trim(dr("sDovizCinsi1")) <> "" Then
                    If dr("lDovizKuru1") = 0 Then
                        dr("lDovizKuru1") = 1
                    End If
                    If dr("lBorcTutar") = 0 Then
                        dr("lAlacakTutar") = dr("lDovizMiktari1") * dr("lDovizKuru1")
                    ElseIf dr("lAlacakTutar") = 0 Then
                        dr("lBorcTutar") = dr("lDovizMiktari1") * dr("lDovizKuru1")
                    End If
                End If
            End If
            If dr("lBorcTutar") > 0 Then
                dr("lAlacakTutar") = 0
            ElseIf dr("lAlacakTutar") > 0 Then
                dr("lBorcTutar") = 0
            End If
            If Trim(dr("sDovizCinsi1")) <> "" Then
                If dr("lDovizKuru1") = 0 Then
                    dr("lDovizKuru1") = 1
                End If
                dr("lDovizMiktari1") = Math.Abs(dr("lBorcTutar") - dr("lAlacakTutar")) / dr("lDovizKuru1")
            End If
            tbFirmaHareketi_kaydet_duzelt(dr("nHareketID"), dr("nFirmaID"), dr("dteIslemTarihi"), dr("dteValorTarihi"), dr("sCariIslem"), dr("sAciklama").ToString, dr("lBorcTutar"), dr("lAlacakTutar"), dr("sEvrakNo"), dr("lVadeFarki"), dr("sHangiUygulama").ToString, dr("sHareketTipi").ToString, dr("sKullaniciAdi").ToString, dr("dteKayitTarihi"), dr("sDovizCinsi1"), dr("lDovizMiktari1"), dr("lDovizKuru1"), dr("sDovizCinsi1"), dr("lDovizMiktari2"), dr("lDovizKuru2"), kullanici, Now)
            Dataload_tbFirma(dr("sFirmaKodu"))
            Dataload_tbYekun(nFirmaID, sKodu, txt_dteTarih1.EditValue, txt_dteTarih2.EditValue)
            dr = Nothing
        End If
    End Sub
    Private Sub satir_kontrol()
        If GridView1.RowCount > 0 Then
            Dim dr As DataRow = GridView1.GetDataRow(GridView1.FocusedRowHandle)
            If Trim(dr("sHangiUygulama")) = "" Then
                GridView1.OptionsBehavior.Editable = True
                SilToolStripMenuItem.Enabled = True
            Else
                GridView1.OptionsBehavior.Editable = False
                SilToolStripMenuItem.Enabled = False
            End If
        End If
        If GridView1.RowCount > 0 Then
            Dim dr As DataRow = GridView1.GetDataRow(GridView1.FocusedRowHandle)
            Dataload_tbFirma(dr("sFirmaKodu"))
            dr = Nothing
        End If
    End Sub
    Private Sub analiz_cari_hareket()
        If GridView1.RowCount > 0 Then
            Dim dr As DataRow = GridView1.GetDataRow(GridView1.FocusedRowHandle)
            Dim frm As New frm_cari_hareketler_ozet
            frm.firmano = firmano
            frm.donemno = donemno
            frm.connection = connection
            frm.musterino = dr("sFirmaKodu")
            frm.kullanici = kullanici
            If yetki_kontrol(kullanici, frm.Name) = True Then
                If yetki_kontrol(kullanici, "frm_firma_liste_hesapTuru_" & Trim(CariHesapTuruSorgula(dr("sFirmaKodu")))) = True Then
                    frm.ShowDialog()
                End If
            End If
            frm.Close()
            frm.Dispose()
            frm = Nothing
        End If
    End Sub
    Private Sub analiz_Firma_karti()
        If GridView1.RowCount > 0 Then
            Dim dr As DataRow = GridView1.GetDataRow(GridView1.FocusedRowHandle)
            Dim frm As New frm_firma_kart
            frm.firmano = firmano
            frm.donemno = donemno
            frm.connection = connection
            frm.sKodu = dr("sFirmaKodu")
            frm.nFirmaID = dr("nFirmaID")
            frm.kullanici = kullanici
            If yetki_kontrol(kullanici, frm.Name) = True Then
                frm.ShowDialog()
            End If
            frm.Close()
            frm.Dispose()
            frm = Nothing
        End If
    End Sub
    Private Sub raporla(ByVal rapor As Integer, ByVal nislem As Integer, Optional ByVal bTumu As Boolean = False)
        Dim OpenFileDialog1 As New Windows.Forms.OpenFileDialog
        OpenFileDialog1.Title = "Rapor Seç..."
        OpenFileDialog1.Filter = "Rapor Dosyalarý (Form*.frx) |Form*.frx"
        OpenFileDialog1.FileName = "c:\Formlar\Raporlar\FirmaHareketi\Form.frx"
        OpenFileDialog1.InitialDirectory = "c:\Formlar\Raporlar\FirmaHareketi"
        If OpenFileDialog1.ShowDialog = Windows.Forms.DialogResult.OK Then
            Dim sFile = OpenFileDialog1.FileName.ToString
            Dim report As New FastReport.Report
            report.Load(sFile)
            Dim ds_table1 As DataSet
            Dim dr As DataRow
            dr = GridView1.GetDataRow(GridView1.FocusedRowHandle)
            Dim kriter As String = ""
            report.RegisterData(ds_tbFirmaHareketi)
            report.RegisterData(ds_tbNakitKasaToplam)
            report.RegisterData(ds_tbParamGenel)
            report.SetParameterValue("dteTarih1", txt_dteTarih1.EditValue)
            report.SetParameterValue("dteTarih2", txt_dteTarih2.EditValue)
            report.SetParameterValue("sKodu", sKodu)
            report.SetParameterValue("nFirmaID", nFirmaID)
            report.ScriptLanguage = Language.Vb
            If nislem = 0 Then
                report.Show()
            ElseIf nislem = 2 Then
                report.Design()
            ElseIf nislem = 1 Then
                report.Print()
            End If
            ds_table1 = Nothing
            report.Dispose()
            report = Nothing
        End If
    End Sub
    Private Sub raporla1(ByVal rapor As Integer, ByVal islem As Integer)
        If GridView1.RowCount > 0 Then
            Dim file As String = ""
            Dim kriter As String
            Dim dr As DataRow
            dr = GridView1.GetDataRow(GridView1.FocusedRowHandle)
            kriter = " WHERE nHareketID = " & dr("nHareketID") & ""
            OpenFileDialog1.Title = "Rapor Seç..."
            OpenFileDialog1.Filter = "Rapor Dosyalarý (Form*.fr3) |Form*.fr3"
            OpenFileDialog1.FileName = "c:\Formlar\Raporlar\FirmaHareketi\Form.fr3"
            OpenFileDialog1.InitialDirectory = "c:\Formlar\Raporlar\FirmaHareketi"
            If OpenFileDialog1.ShowDialog = Windows.Forms.DialogResult.OK Then
                file = OpenFileDialog1.FileName.ToString
                report_create_stok(file, kriter, islem, nFirmaID, sKodu, txt_dteTarih1.EditValue, txt_dteTarih2.EditValue, dr("lBorcTutar"), dr("lAlacakTutar"))
            End If
            file = Nothing
            kriter = Nothing
            dr = Nothing
        End If
    End Sub
    Private Sub report_create_stok(ByVal dosya As String, ByVal kriter As String, ByVal status As Integer, ByVal nFirmaID As String, ByVal sKodu As String, ByVal dteTarih1 As DateTime, ByVal dteTarih2 As DateTime, ByVal lBorcTutar As Decimal, ByVal lAlacakTutar As Decimal)
        Dim stokno = 0
        Dim satir_line = "100"
        If IntPtr.Size = 4 Then
            '32 Bit
            Dim frx As New TfrxReportClass
            Dim ds1 As New TfrxUserDataSetClass
            Dim qr_hareket As New TfrxADOQuery
            Dim qr_baslik As New TfrxADOQuery
            frx.Resources.LoadLanguageResourcesFromFile("C:\Program Files\FastReports\FastReport Studio\bin\turkish.frc")
            frx.LoadReportFromFile(dosya)
            frx.SetVariable("FIRMANO", "" & firmano & "")
            frx.SetVariable("DONEMNO", "" & donemno & "")
            frx.SetVariable("STOKNO", "" & stokno & "")
            frx.SetVariable("SATIRLINE", "'" & satir_line & "'")
            If lAlacakTutar = 0 Then
                frx.SetVariable("IZAHAT", "'Borç Dekontu'")
            ElseIf lBorcTutar = 0 Then
                frx.SetVariable("IZAHAT", "'Alacak Dekontu'")
            End If
            qr_hareket = frx.FindObject("qr_hareket")
            qr_hareket.Query = sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT tbFirmaHareketi.*, tbFirma.sKodu AS sFirmaKodu, tbFirma.sAciklama AS sFirmaAciklama,(SELECT ISNULL(SUM(lBorcTutar) , 0) AS lBorcTutar FROM tbFirmaHareketi WHERE nFirmaID = tbFirma.nFirmaID) AS lBorcTutar, (SELECT ISNULL(SUM(lAlacakTutar) , 0) AS lAlacakTutar FROM tbFirmaHareketi WHERE nFirmaID = tbFirma.nFirmaID) AS lAlacakTutar, (SELECT ISNULL(SUM(lBorcTutar - lAlacakTutar) , 0) AS lBakiye FROM tbFirmaHareketi WHERE nFirmaID = tbFirma.nFirmaID) AS lBakiye, (SELECT ISNULL(SUM(lTutar) , 0) AS Expr1 FROM tbCekSenet WHERE (nVerenID = tbFirma.nFirmaID) AND (sCekSenetTipi = 'AC' OR sCekSenetTipi = 'AS') AND (nSonCekSenetIslem <= 6) AND (nSonCekSenetIslem <> 2)) AS lRisk FROM tbFirmaHareketi INNER JOIN tbFirma ON tbFirmaHareketi.nFirmaID = tbFirma.nFirmaID WHERE (tbFirmaHareketi.dteIslemTarihi BETWEEN '" & dteTarih1 & "' AND '" & dteTarih2 & "') Order by tbFirmaHareketi.nHareketID")
            If status = 0 Then
                'frx.PrepareReport(True)
                frx.PreviewOptions.ZoomMode = frxZoomMode.zm_PageWidth
                frx.OldStyleProgress = True
                frx.ShowReport()
            ElseIf status = 1 Then
                frx.PrepareReport(True)
                frx.PrintOptions.Collate = False
                frx.PrintOptions.Copies = 1
                frx.PrintReport()
            ElseIf status = 2 Then
                frx.PrepareReport(True)
                frx.DesignReport()
            ElseIf status = 3 Then
                frx.PrepareReport(True)
                frx.PrintOptions.Collate = False
                frx.PrintOptions.Copies = 1
                frx.PrintOptions.ShowDialog = False
                frx.PrintReport()
            End If
            qr_hareket = Nothing
        ElseIf IntPtr.Size = 8 Then
            '64 Bit
            Dim args(50) As String
            Dim processYol As String
            args(0) = "" & dosya & ""
            args(1) = "" & connection.ToString() & ""
            args(2) = "" & sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT tbFirmaHareketi.*, tbFirma.sKodu AS sFirmaKodu, tbFirma.sAciklama AS sFirmaAciklama,(SELECT ISNULL(SUM(lBorcTutar) , 0) AS lBorcTutar FROM tbFirmaHareketi WHERE nFirmaID = tbFirma.nFirmaID) AS lBorcTutar, (SELECT ISNULL(SUM(lAlacakTutar) , 0) AS lAlacakTutar FROM tbFirmaHareketi WHERE nFirmaID = tbFirma.nFirmaID) AS lAlacakTutar, (SELECT ISNULL(SUM(lBorcTutar - lAlacakTutar) , 0) AS lBakiye FROM tbFirmaHareketi WHERE nFirmaID = tbFirma.nFirmaID) AS lBakiye, (SELECT ISNULL(SUM(lTutar) , 0) AS Expr1 FROM tbCekSenet WHERE (nVerenID = tbFirma.nFirmaID) AND (sCekSenetTipi = 'AC' OR sCekSenetTipi = 'AS') AND (nSonCekSenetIslem <= 6) AND (nSonCekSenetIslem <> 2)) AS lRisk FROM tbFirmaHareketi INNER JOIN tbFirma ON tbFirmaHareketi.nFirmaID = tbFirma.nFirmaID WHERE (tbFirmaHareketi.dteIslemTarihi BETWEEN '" & dteTarih1 & "' AND '" & dteTarih2 & "') Order by tbFirmaHareketi.nHareketID") & ""
            args(3) = "qr_hareket"
            args(4) = "" & status.ToString() & ""
            args(5) = "5"
            args(6) = "FIRMANO"
            args(7) = "" & firmano.ToString() & ""
            args(8) = "DONEMNO"
            args(9) = "" & donemno.ToString() & ""
            args(10) = "STOKNO"
            args(11) = "" & stokno.ToString() & ""
            args(12) = "SATIRLINE"
            args(13) = "'" & satir_line.ToString() & "'"
            If lAlacakTutar = 0 Then
                args(14) = "IZAHAT"
                args(15) = "'Borç Dekontu'"
            ElseIf lBorcTutar = 0 Then
                args(14) = "IZAHAT"
                args(15) = "'Alacak Dekontu'"
            End If
            processYol = args(0)
            For i As Integer = 1 To 15
                processYol += "|" & args(i)
            Next
            Dim objReader As StreamWriter
            Dim yeniYol As String
            Dim Generator As System.Random = New System.Random()
            Try
                yeniYol = Directory.GetCurrentDirectory() & "\" & Generator.Next().ToString() & "_veriler.txt"
                objReader = New StreamWriter(yeniYol)
                objReader.Write(processYol)
                objReader.Close()
            Catch Ex As Exception
                MessageBox.Show("Raporlama Ýþlemi Ýçin LOG Oluþturulumadý!")
            End Try
            If File.Exists(Directory.GetCurrentDirectory() & "\RaporServis.exe") = True Then
                Dim sInfo As New ProcessStartInfo(Directory.GetCurrentDirectory() & "\RaporServis.exe ", """" & yeniYol & """")
                Process.Start(sInfo)
            Else
                MessageBox.Show("Lütfen 'RaporServis.exe' eklentisini uygulama dizinine kopyalayýn.")
            End If
        End If
        stokno = Nothing
        satir_line = Nothing
    End Sub
    Private Sub btn_Goster_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Goster.Click
        Dataload_tbFirmaHareketi(nFirmaID, sKodu, txt_dteTarih1.EditValue, txt_dteTarih2.EditValue)
        GridControl1.Focus()
        GridControl1.Select()
    End Sub
    Private Sub GörünümüDüzenleToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GörünümüDüzenleToolStripMenuItem.Click
        GridView1.ColumnsCustomization()
    End Sub
    Private Sub GörünümüKaydetToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GörünümüKaydetToolStripMenuItem.Click
        gorunum_kaydet()
    End Sub
    Private Sub GörünümüYazdýrToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GörünümüYazdýrToolStripMenuItem.Click
        gorunum_yazdir()
    End Sub
    Private Sub gorunum_yazdir()
        Dim kriter As String = ""
        kriter += txt_dteTarih1.EditValue & " ve " & txt_dteTarih2.EditValue & " Tarihleri Arasýndaki Toplu Hareket Tablosu" & vbCrLf
        kriter += "Dovizli: " & txt_bDovizliIslem.Checked
        Printlink1.PageHeaderFooter = New DevExpress.XtraPrinting.PageHeaderFooter(New DevExpress.XtraPrinting.PageHeaderArea(New String() {"[User Name]", kriter, "[Date Printed][Time Printed]"}, New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte)), DevExpress.XtraPrinting.BrickAlignment.Far), New DevExpress.XtraPrinting.PageFooterArea(New String() {"Powered by www.barkodyazilimevi.com", "Finans Yönetimi", "[Page # of Pages #]"}, New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte)), DevExpress.XtraPrinting.BrickAlignment.Near))
        Printlink1.CreateDocument(ps)
        ps.PreviewRibbonFormEx.Show()
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
    Private Sub GridView1_CellValueChanged1(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs) Handles GridView1.CellValueChanged
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
    Private Sub GridView1_CustomDrawRowIndicator(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Grid.RowIndicatorCustomDrawEventArgs) Handles GridView1.CustomDrawRowIndicator
        If e.RowHandle >= 0 Then
            e.Info.DisplayText = e.RowHandle + 1
        Else
            e.Info.DisplayText = ""
        End If
    End Sub
    Private Sub GridView1_FocusedRowChanged(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs) Handles GridView1.FocusedRowChanged
        Try
            satir_kontrol()
        Catch ex As Exception
        End Try
    End Sub
    Private Sub GridView1_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles GridView1.KeyDown
        If e.KeyCode = Keys.Down Then
            If GridView1.FocusedRowHandle = GridView1.RowCount - 1 Then
                txt_ara.Focus()
                txt_ara.SelectAll()
            ElseIf GridView1.RowCount = 0 Then
                txt_ara.Focus()
                txt_ara.SelectAll()
            End If
        End If
    End Sub
    Private Sub GridView1_SelectionChanged(ByVal sender As Object, ByVal e As DevExpress.Data.SelectionChangedEventArgs) Handles GridView1.SelectionChanged
        If GridView1.SelectedRowsCount > 1 Then
            label2.Text = Sorgu_sDil("Kayýt Sayýsý :", sDil) & GridView1.RowCount & " / " & Sorgu_sDil("Satýr :", sDil) & GridView1.FocusedRowHandle + 1 & " / " & Sorgu_sDil("Seçili :", sDil) & GridView1.SelectedRowsCount
        ElseIf GridView1.SelectedRowsCount = 1 Then
            label2.Text = Sorgu_sDil("Kayýt Sayýsý :", sDil) & GridView1.RowCount & " / " & Sorgu_sDil("Satýr :", sDil) & GridView1.FocusedRowHandle + 1
        Else
            label2.Text = ""
        End If
    End Sub
    Private Sub EkleToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EkleToolStripMenuItem.Click
        satir_ekle()
    End Sub
    Private Sub SilToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SilToolStripMenuItem.Click
        satir_sil()
    End Sub
    Private Sub FirmaHareketleriToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FirmaHareketleriToolStripMenuItem.Click
        analiz_cari_hareket()
    End Sub
    Private Sub FirmaKartýToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FirmaKartýToolStripMenuItem.Click
        analiz_Firma_karti()
    End Sub
    Private Sub ÖnizleToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ÖnizleToolStripMenuItem.Click
        raporla(0, 0)
    End Sub
    Private Sub DizaynToolStripMenuItem_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles DizaynToolStripMenuItem.Click
        raporla(0, 2)
    End Sub
    Private Sub YazdýrToolStripMenuItem_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles YazdýrToolStripMenuItem.Click
        raporla(0, 1)
    End Sub
    Private Sub txt_musteriNo_ButtonClick(ByVal sender As Object, ByVal e As DevExpress.XtraEditors.Controls.ButtonPressedEventArgs)
        firma_sec()
    End Sub
    Private Sub txt_musteriNo_Validated(ByVal sender As Object, ByVal e As System.EventArgs)
        musteri_kontrol()
    End Sub
    Private Sub sec_lDovizTutar_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles sec_lDovizTutar.Validating
        'If GridView1.RowCount > 0 Then
        '    Dim dr As DataRow
        '    GridView1.PostEditor()
        '    dr = GridView1.GetDataRow(GridView1.FocusedRowHandle)
        '    dr.EndEdit()
        '    If Trim(dr("sDovizCinsi1")) <> "" Then
        '        If dr("lDovizKuru1") = 0 Then
        '            dr("lDovizKuru1") = 1
        '        End If
        '        If dr("lBorcTutar") = 0 Then
        '            dr("lAlacakTutar") = dr("lDovizMiktari1") * dr("lDovizKuru1")
        '        ElseIf dr("lAlacakTutar") = 0 Then
        '            dr("lBorcTutar") = dr("lDovizMiktari1") * dr("lDovizKuru1")
        '        End If
        '    End If
        'End If
    End Sub
    Private Sub GridControl1_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles GridControl1.KeyDown
        If e.KeyCode = Keys.Escape Then
            If XtraMessageBox.Show(Sorgu_sDil("Toplu Firma Hareketi Ekranýndan Çýkmak Ýstediðinize Emin misiniz...?", sDil), Sorgu_sDil("Dikkat", sDil), MessageBoxButtons.YesNo, MessageBoxIcon.Question) = MsgBoxResult.Yes Then
                Me.Close()
            End If
        End If
    End Sub
    Private Sub AraToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AraToolStripMenuItem.Click
        txt_dteTarih1.Focus()
        txt_dteTarih1.SelectAll()
    End Sub
    Private Sub BarButtonItem1_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem1.ItemClick
        satir_ekle()
    End Sub
    Private Sub BarButtonItem2_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem2.ItemClick
        satir_sil()
    End Sub
    Private Sub BarButtonItem3_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem3.ItemClick
        raporla(0, 0)
    End Sub
    Private Sub BarButtonItem4_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem4.ItemClick
        gorunum_yazdir()
    End Sub
    Private Sub txt_ara_EditValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles txt_ara.EditValueChanged
        If Len(txt_ara.EditValue.ToString) <> 0 Then
            lbl_ara.Text = Len(txt_ara.EditValue.ToString)
        Else
            lbl_ara.Text = "*"
        End If
    End Sub
    Private Sub txt_ara_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txt_ara.KeyDown
        If e.KeyCode = Keys.Enter Then
            If txt_ara.Text = "" Then
                satir_ekle()
            Else
                firma_ara()
            End If
        ElseIf e.KeyCode = Keys.Up Then
            GridView1.Focus()
            'GridView1.FocusedColumn = colsAciklama1
        ElseIf e.KeyCode = Keys.Escape Then
            If XtraMessageBox.Show(Sorgu_sDil("Muhasebe Fisi Ekranýný Kapatmak Ýstediðinize Emin misiniz...?", sDil), Sorgu_sDil("Dikkat", sDil), MessageBoxButtons.YesNo, MessageBoxIcon.Question) = MsgBoxResult.Yes Then
                Me.Close()
            End If
        End If
    End Sub
    Private Sub firma_ara()
        mevcut = 1
        If Trim(txt_ara.Text) <> "" Then
            Label4.Text = "Barkod Standardý Kontrol Ediliyor..."
            Label4.Refresh()
            If IsNumeric(Trim(txt_ara.Text)) = True Then
                If Len(Trim(txt_ara.Text).ToString) < 2 Then
                    txt_ara.Text = Trim(txt_ara.Text) + "  "
                End If
                If Trim((Trim(txt_ara.Text)).Substring(0, 2)) = sBarcodeStd Then
                    Dim deger = Trim(Trim(txt_ara.Text))
                    If IsNumeric(deger) = True Then
                        mevcut = CType((deger.substring(7, sBarcodeStd_KG) + "." + deger.substring(7 + sBarcodeStd_KG, sBarcodeStd_GR)), Decimal)
                        txt_ara.Text = deger.substring(2, 5)
                    End If
                Else
                    mevcut = 1
                End If
            Else
                If CStr(Trim(txt_ara.Text).ToString) <> "" Then
                    x = (Trim(txt_ara.Text)).IndexOf("*", 1, (Trim(txt_ara.Text)).Length - 1)
                    If x = -1 Then
                        mevcut = 1
                    Else
                        mevcut = (Trim(txt_ara.Text)).Substring(0, x)
                        txt_ara.Text = (Trim(txt_ara.Text)).Substring((x + 1), (Trim(txt_ara.Text)).Length - (x + 1))
                        If IsNumeric(Trim(txt_ara.Text)) Then
                        Else
                        End If
                    End If
                End If
            End If
            Label4.Text = "Barkod Standardý Kontrolü Tamamlandý..."
            Label4.Refresh()
            firma_kontrol()
        End If
    End Sub
    Private Sub firma_kontrol()
        If IsNumeric(Trim(txt_ara.Text)) = True Then
            okut = True
        Else
            okut = False
        End If
        Label4.Text = "Firma Kartý Kontrolü Yapýlýyor..."
        Label4.Refresh()
        Dim kontrol = sorgu_Firma_kontrol(txt_ara.EditValue, sec_kriter.Text)
        If kontrol = 0 Then
            Label4.Text = "Firma Kaydý Bulunamadý!!!.Tekrar Deneyiniz..."
            Label4.Refresh()
            txt_ara.Focus()
            txt_ara.SelectAll()
            'If XtraMessageBox.Show(Sorgu_sDil("Kayýt Bulunumadý..." & vbCrLf & "Yeni Kayýt Eklemek Ýster misiniz...?",sDil), MessageBoxButtons.YesNo + MessageBoxIcon.Warning) = MsgBoxResult.Yes Then
            '    stok_yeni(txt_ara.Text)
            'End If
        ElseIf kontrol = 1 Then
            Label4.Text = "Belge Firma Kaydý Kontrol Ediliyor... "
            Label4.Refresh()
            'MsgBox(Sorgu_sDil("Kayýt Tek...")
            Dataload_tbFirma(Trim(txt_ara.Text), sec_kriter.Text)
            Label4.Text = "Firma Bilgisi Yükleniyor... "
            Label4.Refresh()
            satir_ekle_firma_tek()
            Label4.Text = "Yeni Hesap Girin..."
        ElseIf kontrol > 1 Then
            satir_ekle(Trim(txt_ara.Text), sec_kriter.Text)
            Label4.Text = "Firma Hesabý Satýra Ýþlendi...Yeni Ürün Okutun..."
            Label4.Refresh()
            txt_ara.Text = ""
            txt_ara.Focus()
            txt_ara.SelectAll()
        End If
    End Sub
    Public Function sorgu_Firma_kontrol(ByVal ara As String, ByVal ara_kriter As String) As Int64
        Dim kriter
        kriter = "WHERE (tbFirma.sKodu  " & sorgu_kriter_string(ara, ara_kriter) & ") or (tbFirma.sAciklama " & sorgu_kriter_string(ara, ara_kriter) & ") "
        Dim conn As New OleDb.OleDbConnection
        Dim cmd As New OleDb.OleDbCommand
        Dim adapter As New OleDb.OleDbDataAdapter
        conn.ConnectionString = connection
        cmd.Connection = conn
        conn.Open()
        cmd.CommandText = sorgu_query("SET DATEFORMAT DMY SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT     ISNULL(COUNT(*), 0) AS KAYIT FROM         tbFirma " & kriter & "")
        Dim kayitsayisi = cmd.ExecuteScalar
        Return kayitsayisi
        conn.Dispose()
        cmd.Dispose()
        adapter.Dispose()
        cmd = Nothing
        adapter = Nothing
    End Function
    Private Sub dataload_tbFirma(ByVal ara As String, ByVal ara_kriter As String)
        Dim kriter
        kriter = "WHERE (tbFirma.sKodu  " & sorgu_kriter_string(ara, ara_kriter) & ") or (tbFirma.sAciklama " & sorgu_kriter_string(ara, ara_kriter) & ") "
        ds_Firma = sorgu(sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT tbFirma.nFirmaID, tbFirma.sKodu, tbFirma.sAciklama, tbFirma.sSaticiRumuzu,tbFirma.nOzelIskontosu,tbFirma.nOzelIskontosu2,tbFirma.nOzelIskontosu3,tbFirma.nOzelIskontosu4,tbFirma.sFiyatTipi, tbFirma.lKrediLimiti, tbFirma.sSemt,tbFirma.sIl,tbFirma.sUlke,tbFirma.sPostaKodu,tbFirma.nVadeGun,tbFirma.sAdres1,tbFirma.sAdres2,tbFirma.sAdres1 + ' ' + tbFirma.sAdres2 + ' ' + tbFirma.sSemt + ' ' + tbFirma.sIl + ' ' + tbFirma.sUlke + ' ' + tbFirma.sPostaKodu AS Adres, tbFirma.sVergiDairesi, tbFirma.sVergiNo, tbFirmaAciklamasi.sAciklama1 + ' ' + tbFirmaAciklamasi.sAciklama2 + ' ' + tbFirmaAciklamasi.sAciklama3 + ' ' + tbFirmaAciklamasi.sAciklama4 + ' ' + tbFirmaAciklamasi.sAciklama5 AS ISTIHBARAT, tbFSinif1.sAciklama AS SINIF1, tbFSinif2.sAciklama AS SINIF2, tbFSinif3.sAciklama AS SINIF3, tbFSinif4.sAciklama AS SINIF4, tbFSinif5.sAciklama AS SINIF5, (SELECT ISNULL(SUM(lBorcTutar - lAlacakTutar) , 0) AS lBakiye FROM tbFirmaHareketi WHERE nFirmaID = tbFirma.nFirmaID) AS lBakiye, tbHesapPlani.nHesapID, tbHesapPlani.sKodu AS sHesapKodu, tbHesapPlani.sAciklama AS sHesapAciklama,(SELECT     TOP 1 sIletisimAdresi FROM          tbFirmaIletisimi WHERE      nFirmaId = tbFirma.nFirmaID AND sIletisimAraci = 'E-Mail') AS [E-Mail],(SELECT     TOP 1 sIletisimAdresi FROM          tbFirmaIletisimi WHERE      nFirmaId = tbFirma.nFirmaID AND sIletisimAraci = 'Fax') AS [Fax],(SELECT     TOP 1 sIletisimAdresi FROM          tbFirmaIletisimi WHERE      nFirmaId = tbFirma.nFirmaID AND sIletisimAraci = 'Gsm') AS [Gsm],(SELECT     TOP 1 sIletisimAdresi FROM          tbFirmaIletisimi WHERE      nFirmaId = tbFirma.nFirmaID AND sIletisimAraci = 'Telefon') AS [Telefon],(SELECT     TOP 1 sIletisimAdresi FROM          tbFirmaIletisimi WHERE      nFirmaId = tbFirma.nFirmaID AND sIletisimAraci = 'Web') AS [Web],(SELECT     TOP 1 sIletisimAdresi FROM          tbFirmaIletisimi WHERE      nFirmaId = tbFirma.nFirmaID AND sIletisimAraci = 'Yetkili') AS [Yetkili] FROM tbFirmaAciklamasi RIGHT OUTER JOIN tbFirma INNER JOIN tbHesapPlani ON tbFirma.nHesapID = tbHesapPlani.nHesapID ON tbFirmaAciklamasi.nFirmaID = tbFirma.nFirmaID LEFT OUTER JOIN tbFSinif1 INNER JOIN tbFirmaSinifi ON tbFSinif1.sSinifKodu = tbFirmaSinifi.sSinifKodu1 INNER JOIN tbFSinif2 ON tbFirmaSinifi.sSinifKodu2 = tbFSinif2.sSinifKodu INNER JOIN tbFSinif3 ON tbFirmaSinifi.sSinifKodu3 = tbFSinif3.sSinifKodu INNER JOIN tbFSinif4 ON tbFirmaSinifi.sSinifKodu4 = tbFSinif4.sSinifKodu INNER JOIN tbFSinif5 ON tbFirmaSinifi.sSinifKodu5 = tbFSinif5.sSinifKodu ON tbFirma.nFirmaID = tbFirmaSinifi.nFirmaID " & kriter & " ORDER BY tbFirma.sKodu"))
    End Sub
    Private Sub frm_tbFirmaHareketiToplu_FormClosing(ByVal sender As System.Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles MyBase.FormClosing
        If sDatabaseGenel = "UGURLU" Then
            If GridView1.RowCount = 1 Then
                If Trim(GridView1.GetRowCellValue(0, "sHareketTipi")) = "" Then
                    e.Cancel = True
                    XtraMessageBox.Show(Sorgu_sDil("Lütfen bir hareket tipi seçiniz.", sDil), Sorgu_sDil("Dikkat", sDil), MessageBoxButtons.OK, MessageBoxIcon.Warning)
                End If
            ElseIf GridView1.RowCount <> 0 Then
                Dim hareketV As Integer = 0
                For i As Integer = 0 To GridView1.RowCount - 1
                    If Trim(GridView1.GetRowCellValue(i, "sHareketTipi")) = "" Then
                        hareketV = 1
                    End If
                Next
                If hareketV = 1 Then
                    e.Cancel = True
                    XtraMessageBox.Show(Sorgu_sDil("Lütfen bir hareket tipi seçiniz.", sDil), Sorgu_sDil("Dikkat", sDil), MessageBoxButtons.OK, MessageBoxIcon.Warning)
                End If
            End If
        End If
    End Sub
End Class