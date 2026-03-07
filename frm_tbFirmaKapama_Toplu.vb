Imports System.Threading
Imports DevExpress.XtraEditors
Public Class frm_tbFirmaKapama_Toplu
    Public firmano
    Public donemno
    Public connection
    Public nFirmaID
    Dim nHesapID
    Public sKodu
    Public kullanici
    Public bKapat As Boolean = False
    Dim conn As New OleDb.OleDbConnection
    Dim con As New OleDb.OleDbConnection
    Dim cmd As New OleDb.OleDbCommand
    Dim adapter As New OleDb.OleDbDataAdapter
    Dim DS As New DataSet
    Dim dataset1 As New DataSet
    Dim ds_cari As DataSet
    Public yeni As Boolean = False
    Public bBakiye As Boolean = False
    Dim ds_satici As New DataSet
    Public sFiyatTipi As String = ""
    Public sDepo As String = ""
    Dim sorgu_text As String = ""
    Dim gunes As DateTime = Now
    Dim lKalanSaat As DateTime
    Private _listBox As ListBox
    Private _searchCriteria As String
    Private _searching As Boolean
    Private _deferSearch As Boolean
    Private _searchThread As Thread
    Private _onSearchComplete As EventHandler
    Private Sub LabelControl2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LabelControl2.Click
    End Sub
    Private Sub SimpleButton2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SimpleButton2.Click
        Me.Close()
    End Sub
    Private Sub dataload_satici()
        'sec_Satici.DataSource = sorgu(sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT     sSaticiRumuzu , sAdi + ' ' + sSoyadi AS SATICI  FROM         tbSatici where bAktif =1")).Tables(0)
        ds_satici = sorgu(sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT     CAST('0' as bit) AS SEC, sSaticiRumuzu AS KOD, sAdi + ' ' + sSoyadi AS ACIKLAMA FROM         tbSatici where bAktif =1"))
        GridControl2.DataSource = ds_satici.Tables(0)
        GridControl2.DataMember = Nothing
        If sDepo <> "" Then
            sec_depo.Text = sDepo.ToString
            sec_depo.EditValue = sDepo.ToString
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
    Private Sub tbFirmaKapama_truncate()
        Dim cmd As New OleDb.OleDbCommand
        Dim con As New OleDb.OleDbConnection
        cmd.Connection = con
        con.ConnectionString = connection
        If con.State = ConnectionState.Closed = True Then
            con.Open()
        End If
        cmd.CommandText = sorgu_query("SET DATEFORMAT DMY SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED TRUNCATE TABLE       tbFirmaKapama")
        cmd.ExecuteNonQuery()
        con.Close()
        con.Dispose()
        cmd.Dispose()
        con = Nothing
        cmd = Nothing
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
        If sec_konum.Text = "Kodu" Then
            kriter += " AND ( tbFirma.sKodu " & sorgu_kriter_string(ara, ara_kriter) & " )"
        ElseIf sec_konum.Text = "Adý" Then
            kriter += " AND ( tbFirma.sAciklama " & sorgu_kriter_string(ara, ara_kriter) & " )"
        ElseIf sec_konum.Text = "Ýstihbarat" Then
            kriter += " AND (( tbFirmaAciklamasi.sAciklama1 + ' ' + tbFirmaAciklamasi.sAciklama2 + ' ' + tbFirmaAciklamasi.sAciklama3 + ' ' + tbFirmaAciklamasi.sAciklama4 + '  ' + tbFirmaAciklamasi.sAciklama5) " & sorgu_kriter_string(ara, ara_kriter) & " )"
        ElseIf sec_konum.Text = "Adres" Then
            kriter += " AND ( tbFirma.sAdres1 + ' ' + tbFirma.sAdres2 + ' ' + tbFirma.sSemt + ' ' + tbFirma.sIl + ' ' + tbFirma.sUlke + ' ' + tbFirma.sPostaKodu  " & sorgu_kriter_string(ara, ara_kriter) & " )"
        ElseIf sec_konum.Text = "Sýnýf1" Then
            'kriter += " AND (tbFSinif1.sAciklama " & sorgu_kriter_string(ara, ara_kriter) & " )"
            kriter += "AND tbFirma.nFirmaID IN (SELECT     tbFirmaSinifi.nFirmaID FROM         tbFirmaSinifi INNER JOIN tbFSinif1 ON tbFirmaSinifi.sSinifKodu1 = tbFSinif1.sSinifKodu WHERE tbFSinif1.sAciklama " & sorgu_kriter_string(ara, ara_kriter) & " )"
        ElseIf sec_konum.Text = "Sýnýf2" Then
            'kriter += " AND (tbFSinif2.sAciklama " & sorgu_kriter_string(ara, ara_kriter) & " )"
            kriter += "AND tbFirma.nFirmaID IN (SELECT     tbFirmaSinifi.nFirmaID FROM         tbFirmaSinifi INNER JOIN tbFSinif2 ON tbFirmaSinifi.sSinifKodu2 = tbFSinif2.sSinifKodu WHERE tbFSinif2.sAciklama " & sorgu_kriter_string(ara, ara_kriter) & " )"
        ElseIf sec_konum.Text = "Sýnýf3" Then
            'kriter += " AND (tbFSinif3.sAciklama " & sorgu_kriter_string(ara, ara_kriter) & " )"
            kriter += "AND tbFirma.nFirmaID IN (SELECT     tbFirmaSinifi.nFirmaID FROM         tbFirmaSinifi INNER JOIN tbFSinif3 ON tbFirmaSinifi.sSinifKodu3 = tbFSinif3.sSinifKodu WHERE tbFSinif3.sAciklama " & sorgu_kriter_string(ara, ara_kriter) & " )"
        ElseIf sec_konum.Text = "Sýnýf4" Then
            'kriter += " AND (tbFSinif4.sAciklama " & sorgu_kriter_string(ara, ara_kriter) & " )"
            kriter += "AND tbFirma.nFirmaID IN (SELECT     tbFirmaSinifi.nFirmaID FROM         tbFirmaSinifi INNER JOIN tbFSinif4 ON tbFirmaSinifi.sSinifKodu4 = tbFSinif4.sSinifKodu WHERE tbFSinif4.sAciklama " & sorgu_kriter_string(ara, ara_kriter) & " )"
        ElseIf sec_konum.Text = "Sýnýf5" Then
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
    Private Sub dataload_cari(ByVal kod As String)
        Dim kriter
        kriter = "WHERE (sKodu = '" & kod & "') "
        ds_cari = sorgu(sorgu_query("SELECT     nFirmaId,sKodu,sAciklama FROM         tbFirma " & kriter & ""))
    End Sub
    Private Sub dataload(ByVal ara As String, ByVal konum As String, ByVal ara_kriter As String, ByVal sSaticiRumuzu As String, ByVal nGrupla As Integer)
        dataset1 = stok(ara, konum, ara_kriter, DateEdit1.EditValue, sec_bakiye_kriter.Text, sSaticiRumuzu, nGrupla)
        'GridControl1.DataSource = DataSet1.Tables(0)
        'GridControl1.DataMember = Nothing
        'PanelControl3.Select()
        'GridControl1.Focus()
        'GridControl1.Select()
        'GridView1.CollapseAllGroups()
    End Sub
    Public Function stok(ByVal ara As String, ByVal konum As String, ByVal ara_kriter As String, ByVal tarih1 As DateTime, ByVal bakiye_kriter As String, ByVal sSaticiRumuzu As String, ByVal nGrupla As Integer) As DataSet
        Dim kriter = "Where tbFirma.nFirmaID > 0"
        Dim kriter2 = ""
        If sec_konum.Text = "Kodu" Then
            kriter += " AND ( tbFirma.sKodu " & sorgu_kriter_string(ara, ara_kriter) & " )"
        ElseIf sec_konum.Text = "Adý" Then
            kriter += " AND ( tbFirma.sAciklama " & sorgu_kriter_string(ara, ara_kriter) & " )"
        ElseIf sec_konum.Text = "Ýstihbarat" Then
            kriter += " AND (( tbFirmaAciklamasi.sAciklama1 + ' ' + tbFirmaAciklamasi.sAciklama2 + ' ' + tbFirmaAciklamasi.sAciklama3 + ' ' + tbFirmaAciklamasi.sAciklama4 + '  ' + tbFirmaAciklamasi.sAciklama5) " & sorgu_kriter_string(ara, ara_kriter) & " )"
        ElseIf sec_konum.Text = "Adres" Then
            kriter += " AND ( tbFirma.sAdres1 + ' ' + tbFirma.sAdres2 + ' ' + tbFirma.sSemt + ' ' + tbFirma.sIl + ' ' + tbFirma.sUlke + ' ' + tbFirma.sPostaKodu  " & sorgu_kriter_string(ara, ara_kriter) & " )"
        ElseIf sec_konum.Text = "Sýnýf1" Then
            'kriter += " AND (tbFSinif1.sAciklama " & sorgu_kriter_string(ara, ara_kriter) & " )"
            kriter += "AND tbFirma.nFirmaID IN (SELECT     tbFirmaSinifi.nFirmaID FROM         tbFirmaSinifi INNER JOIN tbFSinif1 ON tbFirmaSinifi.sSinifKodu1 = tbFSinif1.sSinifKodu WHERE tbFSinif1.sAciklama " & sorgu_kriter_string(ara, ara_kriter) & " )"
        ElseIf sec_konum.Text = "Sýnýf2" Then
            'kriter += " AND (tbFSinif2.sAciklama " & sorgu_kriter_string(ara, ara_kriter) & " )"
            kriter += "AND tbFirma.nFirmaID IN (SELECT     tbFirmaSinifi.nFirmaID FROM         tbFirmaSinifi INNER JOIN tbFSinif2 ON tbFirmaSinifi.sSinifKodu2 = tbFSinif2.sSinifKodu WHERE tbFSinif2.sAciklama " & sorgu_kriter_string(ara, ara_kriter) & " )"
        ElseIf sec_konum.Text = "Sýnýf3" Then
            'kriter += " AND (tbFSinif3.sAciklama " & sorgu_kriter_string(ara, ara_kriter) & " )"
            kriter += "AND tbFirma.nFirmaID IN (SELECT     tbFirmaSinifi.nFirmaID FROM         tbFirmaSinifi INNER JOIN tbFSinif3 ON tbFirmaSinifi.sSinifKodu3 = tbFSinif3.sSinifKodu WHERE tbFSinif3.sAciklama " & sorgu_kriter_string(ara, ara_kriter) & " )"
        ElseIf sec_konum.Text = "Sýnýf4" Then
            'kriter += " AND (tbFSinif4.sAciklama " & sorgu_kriter_string(ara, ara_kriter) & " )"
            kriter += "AND tbFirma.nFirmaID IN (SELECT     tbFirmaSinifi.nFirmaID FROM         tbFirmaSinifi INNER JOIN tbFSinif4 ON tbFirmaSinifi.sSinifKodu4 = tbFSinif4.sSinifKodu WHERE tbFSinif4.sAciklama " & sorgu_kriter_string(ara, ara_kriter) & " )"
        ElseIf sec_konum.Text = "Sýnýf5" Then
            'kriter += " AND (tbFSinif5.sAciklama " & sorgu_kriter_string(ara, ara_kriter) & " )"
            kriter += "AND tbFirma.nFirmaID IN (SELECT     tbFirmaSinifi.nFirmaID FROM         tbFirmaSinifi INNER JOIN tbFSinif5 ON tbFirmaSinifi.sSinifKodu5 = tbFSinif5.sSinifKodu WHERE tbFSinif5.sAciklama " & sorgu_kriter_string(ara, ara_kriter) & " )"
        ElseIf sec_konum.Text = "Adý+Soyadý" Then
            Dim adi As String = ""
            Dim soyadi As String = ""
            Dim x
            If CStr(ara.ToString) <> "" Then
                x = (ara).IndexOf(" ", 1, (ara.Length - 1))
                If x = -1 Then
                    adi = ara
                Else
                    adi = (ara).Substring(0, x)
                    soyadi = (ara).Substring((x + 1), (ara).Length - (x + 1))
                    If IsNumeric(ara) Then
                    Else
                    End If
                End If
            End If
            'MsgBox(Sorgu_sDil("Adi :" & vbTab & adi & vbCrLf & "Soyadi :" & vbTab & soyadi)
            If adi.ToString <> "" Then
                kriter += " AND ( tbMusteri.sAdi " & sorgu_kriter_string(adi, ara_kriter) & " )"
            End If
            If soyadi.ToString <> "" Then
                kriter += " AND ( tbMusteri.sSoyadi " & sorgu_kriter_string(soyadi, ara_kriter) & " )"
            End If
        Else
        End If
        If sSaticiRumuzu.ToString <> "" And sSaticiRumuzu <> "[Tümü]" Then
            kriter += " AND (tbFirma.sSaticiRumuzu IN (" & sSaticiRumuzu & " ))"
        End If
        If bakiye_kriter = "[Tümü]" Then
        ElseIf bakiye_kriter = "Bakiye Verenler" Then
            kriter2 = " WHERE Bakiye <> 0 "
        ElseIf bakiye_kriter = "Bakiyesizler" Then
            kriter2 = " WHERE Bakiye = 0 "
        ElseIf bakiye_kriter = "Borç Bakiyesi Verenler" Then
            kriter2 = " WHERE Bakiye > 0 "
        ElseIf bakiye_kriter = "Alacak Bakiyesi Verenler" Then
            kriter2 = " WHERE Bakiye < 0 "
        ElseIf bakiye_kriter = "Dövizli Bakiye Verenler" Then
            kriter2 = " WHERE Bakiye <> 0 "
        End If
        If nGrupla > 0 Then
            kriter += " AND LEN(tbFirma.sKodu) = " & nGrupla & " "
        End If
        'kriter = "WHERE tbMusteri.dteKayitTarihi between '" & Microsoft.VisualBasic.Left(tarih1.ToString, 10) + " 00:00:00" & "' and '" & Microsoft.VisualBasic.Left(tarih1.ToString, 10) + " 23:59:59" & "' "
        Dim conn As New OleDb.OleDbConnection
        Dim cmd As New OleDb.OleDbCommand
        Dim adapter As New OleDb.OleDbDataAdapter
        conn.ConnectionString = connection
        cmd.CommandTimeout = False
        adapter.SelectCommand = cmd
        'cmd.CommandText = sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT * FROM (SELECT tbFirma.nFirmaID , tbFirma.sKodu , tbFirma.sAciklama , tbFirma.nOzelIskontosu , tbFirma.lKrediLimiti , tbFirma.sSemt,tbFirma.sIl,tbFirma.sSaticiRumuzu,tbFirma.sUlke,tbFirma.sAdres1 + ' ' + tbFirma.sAdres2 + ' ' + tbFirma.sSemt + ' ' + tbFirma.sIl + ' ' + tbFirma.sUlke + ' ' + tbFirma.sPostaKodu AS Adres , tbFirma.sVergiDairesi , tbFirma.sVergiNo , tbFirmaAciklamasi.sAciklama1 + ' ' + tbFirmaAciklamasi.sAciklama2 + ' ' + tbFirmaAciklamasi.sAciklama3 + ' ' + tbFirmaAciklamasi.sAciklama4 + ' ' + tbFirmaAciklamasi.sAciklama5 AS ISTIHBARAT , tbFSinif1.sAciklama AS SINIF1 , tbFSinif2.sAciklama AS SINIF2 , tbFSinif3.sAciklama AS SINIF3 , tbFSinif4.sAciklama AS SINIF4 , tbFSinif5.sAciklama AS SINIF5 , (SELECT ISNULL(SUM(lBorcTutar - lAlacakTutar) , 0) FROM tbFirmaHareketi WHERE nFirmaID = tbFirma.nFirmaID and dteIslemTarihi < = '" & tarih1 & "' ) AS Bakiye,(SELECT     TOP 1 sIletisimAdresi FROM          tbFirmaIletisimi WHERE      nFirmaId = tbFirma.nFirmaID AND sIletisimAraci = 'E-Mail') AS [E-Mail],(SELECT     TOP 1 sIletisimAdresi FROM          tbFirmaIletisimi WHERE      nFirmaId = tbFirma.nFirmaID AND sIletisimAraci = 'Fax') AS [Fax],(SELECT     TOP 1 sIletisimAdresi FROM          tbFirmaIletisimi WHERE      nFirmaId = tbFirma.nFirmaID AND sIletisimAraci = 'Gsm') AS [Gsm],(SELECT     TOP 1 sIletisimAdresi FROM          tbFirmaIletisimi WHERE      nFirmaId = tbFirma.nFirmaID AND sIletisimAraci = 'Telefon') AS [Telefon],(SELECT     TOP 1 sIletisimAdresi FROM          tbFirmaIletisimi WHERE      nFirmaId = tbFirma.nFirmaID AND sIletisimAraci = 'Web') AS [Web],(SELECT     TOP 1 sIletisimAdresi FROM          tbFirmaIletisimi WHERE      nFirmaId = tbFirma.nFirmaID AND sIletisimAraci = 'Yetkili') AS [Yetkili] FROM tbFSinif1 INNER JOIN tbFirmaSinifi ON tbFSinif1.sSinifKodu = tbFirmaSinifi.sSinifKodu1 INNER JOIN tbFSinif2 ON tbFirmaSinifi.sSinifKodu2 = tbFSinif2.sSinifKodu INNER JOIN tbFSinif3 ON tbFirmaSinifi.sSinifKodu3 = tbFSinif3.sSinifKodu INNER JOIN tbFSinif4 ON tbFirmaSinifi.sSinifKodu4 = tbFSinif4.sSinifKodu INNER JOIN tbFSinif5 ON tbFirmaSinifi.sSinifKodu5 = tbFSinif5.sSinifKodu RIGHT OUTER JOIN tbFirma LEFT OUTER JOIN tbFirmaAciklamasi ON tbFirma.nFirmaID = tbFirmaAciklamasi.nFirmaID ON tbFirmaSinifi.nFirmaID = tbFirma.nFirmaID " & kriter & " ) DERIVEDTBL " & kriter2 & "  ORDER BY sKodu")
        cmd.CommandText = sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT * FROM (SELECT tbFirma.nFirmaID , tbFirma.sKodu , tbFirma.sAciklama ,  (SELECT ISNULL(SUM(lBorcTutar - lAlacakTutar) , 0) FROM tbFirmaHareketi WHERE nFirmaID = tbFirma.nFirmaID and dteIslemTarihi < = '" & tarih1 & "' ) AS Bakiye FROM  tbFirma  " & kriter & " ) DERIVEDTBL " & kriter2 & "  ORDER BY sKodu")
        sorgu_text = cmd.CommandText.ToString
        cmd.Connection = conn
        conn.Open()
        Dim Datastoklar1 As New DataSet
        Dim N As Integer = adapter.Fill(Datastoklar1, "Table1")
        conn.Close()
        Return Datastoklar1
    End Function
    Private Sub dataload_Firma(ByVal nFirmaID As String, ByVal sKodu As String, ByVal nGrupla As Integer)
        'Dataload_tbFirma(nFirmaID)
        'Dataload_tbFirmaBakiyesi(nFirmaID)
        Dataload_tbFirmaHesabi(nFirmaID, sKodu, sec_bKapanan.Checked, nGrupla)
        Dim nKapamaID As Int64 = 0
        Dim lOdenen As Decimal = 0
        Dim lTutar As Decimal = 0
        Dim dr As DataRow
        Dim dr1 As DataRow
        Bar_Satis.Maximum = ds_FirmaHesap.Tables(0).Rows.Count
        Bar_Satis.Value = 0
        Bar_Satis.Refresh()
        Dataload_tbKapatilacak(nFirmaID, 0, sKodu, nGrupla)
        If ds_tbKapatilacak.Tables(0).Rows.Count > 0 Then
            For Each dr In ds_FirmaHesap.Tables(0).Rows
                Bar_Satis.Value += 1
                Bar_Satis.Refresh()
                'Dataload_tbKapatilacak(nFirmaID, dr("nHareketID"))
                Bar_Odeme.Maximum = ds_tbKapatilacak.Tables(0).Rows.Count
                Bar_Odeme.Value = 0
                Bar_Odeme.Refresh()
                For Each dr1 In ds_tbKapatilacak.Tables(0).Rows
                    Bar_Odeme.Value += 1
                    Bar_Odeme.Refresh()
                    'nKapamaID = sorgu_sayi(sorgu_tbFirmaKapama_nkayit_kontrol(dr("nHareketID")), 0)
                    If dr1("lKalan") > 0 Then
                        If dr("lKalan") > 0 Then
                            nKapamaID = sorgu_sayi(sorgu_tbFirmaKapama_nkayit_kontrol(dr("nHareketID")), 0)
                            If dr("lKalan") > dr1("lKalan") Then
                                tbFirmaKapama_kaydet_yeni(0, dr("nHareketID"), dr1("nHareketID"), dr1("lKalan"), "")
                                dr("lKalan") = dr("lKalan") - dr1("lKalan")
                                dr1("lKalan") = 0
                            ElseIf dr("lKalan") <= dr1("lKalan") Then
                                tbFirmaKapama_kaydet_yeni(0, dr("nHareketID"), dr1("nHareketID"), dr("lKalan"), "")
                                lTutar = dr1("lKalan")
                                dr1("lKalan") = lTutar - dr("lKalan")
                                dr("lKalan") = 0
                            End If
                            If nKapamaID > 0 Then
                                lOdenen = sorgu_sayi(sorgu_tbFirmaKapama_lOdenen_kontrol(dr("nHareketID")), 0)
                                tbFirmaKapama_kaydet_duzelt(nKapamaID, dr("nHareketID"), 0, lOdenen, "")
                            ElseIf nKapamaID = 0 Then
                                lOdenen = sorgu_sayi(sorgu_tbFirmaKapama_lOdenen_kontrol(dr("nHareketID")), 0)
                                tbFirmaKapama_kaydet_yeni(0, dr("nHareketID"), 0, lOdenen, "")
                            End If
                        End If
                    End If
                Next
            Next
        End If
        dr = Nothing
        dr1 = Nothing
        Bar_Satis.Value = 0
        Bar_Odeme.Value = 0
        Bar_Satis.Refresh()
        Bar_Odeme.Refresh()
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
        conn = Nothing
        cmd = Nothing
        adapter = Nothing
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
        conn = Nothing
        cmd = Nothing
        adapter = Nothing
    End Sub
    Public Sub Dataload_tbFirmaHesabi(ByVal nFirmaID As String, ByVal sKodu As String, ByVal bKapanan As Boolean, ByVal nGrupla As Integer)
        Try
            ds_FirmaHesap.Tables(0).Clear()
        Catch ex As Exception
        End Try
        Dim conn As New OleDb.OleDbConnection
        Dim cmd As New OleDb.OleDbCommand
        Dim adapter As New OleDb.OleDbDataAdapter
        conn.ConnectionString = connection
        adapter.SelectCommand = cmd
        If bKapanan = True Then
            cmd.CommandText = sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT *, lTutar - lKapananTutar AS lKalan FROM (SELECT tbFirmaHareketi.dteIslemTarihi , tbFirmaHareketi.dteValorTarihi , tbFirmaHareketi.lBorcTutar AS lTutar , tbFirmaHareketi.sAciklama , tbFirmaHareketi.sEvrakNo , tbFirmaHareketi.sCariIslem ,tbFirmaHareketi.sDovizCinsi1,tbFirmaHareketi.lDovizMiktari1, tbFirmaHareketi.nHareketID , ISNULL((SELECT SUM(lTutar) FROM tbFirmaKapama WHERE nKarsilamaId = nHareketId AND nOdemeId = 0) , 0) AS lKapananTutar FROM tbFirmaHareketi INNER JOIN tbFirma ON tbFirmaHareketi.nFirmaID = tbFirma.nFirmaID WHERE (tbFirma.nFirmaID = '" & nFirmaID & "') AND (tbFirmaHareketi.lBorcTutar <> 0)) tbTemp Where lTutar-lKapanantutar = 0 ORDER BY dteIslemTarihi")
        ElseIf bKapanan = False Then
            'cmd.CommandText = sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT *, lTutar - lKapananTutar AS lKalan FROM (SELECT tbFirmaHareketi.dteIslemTarihi , tbFirmaHareketi.dteValorTarihi , tbFirmaHareketi.lBorcTutar AS lTutar , tbFirmaHareketi.sAciklama , tbFirmaHareketi.sEvrakNo , tbFirmaHareketi.sCariIslem , tbFirmaHareketi.sDovizCinsi1,tbFirmaHareketi.lDovizMiktari1,tbFirmaHareketi.nHareketID , ISNULL((SELECT SUM(lTutar) FROM tbFirmaKapama WHERE nKarsilamaId = nHareketId AND nOdemeId = 0) , 0) AS lKapananTutar FROM tbFirmaHareketi INNER JOIN tbFirma ON tbFirmaHareketi.nFirmaID = tbFirma.nFirmaID WHERE (tbFirma.nFirmaID = '" & nFirmaID & "') AND (tbFirmaHareketi.lBorcTutar <> 0)) tbTemp Where lTutar-lKapanantutar <> 0 ORDER BY dteIslemTarihi")
            If nGrupla > 0 Then
                cmd.CommandText = sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT *, lTutar - lKapananTutar AS lKalan FROM (SELECT tbFirmaHareketi.dteIslemTarihi ,tbFirmaHareketi.lBorcTutar AS lTutar,tbFirmaHareketi.sDovizCinsi1,tbFirmaHareketi.lDovizMiktari1,tbFirmaHareketi.nHareketID , ISNULL((SELECT SUM(lTutar) FROM tbFirmaKapama WHERE nKarsilamaId = nHareketId AND nOdemeId = 0) , 0) AS lKapananTutar FROM tbFirmaHareketi INNER JOIN tbFirma ON tbFirmaHareketi.nFirmaID = tbFirma.nFirmaID WHERE (tbFirma.sKodu  like  '" & sKodu & "%') AND (tbFirmaHareketi.lBorcTutar <> 0)) tbTemp Where lTutar-lKapanantutar <> 0 ORDER BY dteIslemTarihi")
            Else
                cmd.CommandText = sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT *, lTutar - lKapananTutar AS lKalan FROM (SELECT tbFirmaHareketi.dteIslemTarihi ,tbFirmaHareketi.lBorcTutar AS lTutar,tbFirmaHareketi.sDovizCinsi1,tbFirmaHareketi.lDovizMiktari1,tbFirmaHareketi.nHareketID , ISNULL((SELECT SUM(lTutar) FROM tbFirmaKapama WHERE nKarsilamaId = nHareketId AND nOdemeId = 0) , 0) AS lKapananTutar FROM tbFirmaHareketi INNER JOIN tbFirma ON tbFirmaHareketi.nFirmaID = tbFirma.nFirmaID WHERE (tbFirma.nFirmaID = '" & nFirmaID & "') AND (tbFirmaHareketi.lBorcTutar <> 0)) tbTemp Where lTutar-lKapanantutar <> 0 ORDER BY dteIslemTarihi")
            End If
        End If
        cmd.Connection = conn
        conn.Open()
        Dim N As Integer = adapter.Fill(ds_FirmaHesap, "Table1")
        conn.Close()
        conn = Nothing
        cmd = Nothing
        adapter = Nothing
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
        conn = Nothing
        cmd = Nothing
        adapter = Nothing
    End Sub
    Private Function sorgu_sayi(ByVal deger As Object, ByVal sonuc As Decimal) As Decimal
        If deger.ToString = "" Then
            deger = sonuc
        End If
        Return deger
    End Function
    Private Sub frm_tbFirmaKapama_Toplu_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        dataload_satici()
        DateEdit1.EditValue = dteSistemTarihi
        If bKapat = True Then
            ara()
        Else
            DateEdit1.EditValue = dteSistemTarihi
        End If
    End Sub
    Private Sub sec_depo_QueryPopUp(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles sec_depo.QueryPopUp
        sec_depo.Properties.PopupControl = sec_grid
        GridControl2.DataSource = ds_satici.Tables(0)
        GridControl2.DataMember = Nothing
    End Sub
    Private Sub sec_depo_QueryResultValue(ByVal sender As Object, ByVal e As DevExpress.XtraEditors.Controls.QueryResultValueEventArgs) Handles sec_depo.QueryResultValue
        Dim s As String = deger(ds_satici)
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
        Return s.ToString
    End Function
    Public Sub BeginSearch()
        If IsHandleCreated Then
            _searchThread = New Thread(New ThreadStart(AddressOf ara))
            '_searching = False
            _searchThread.Start()
        Else
            _deferSearch = True
        End If
    End Sub
    Private Sub ara()
        SimpleButton1.Enabled = False
        Label2.Text = Sorgu_sDil("Lütfen Bekleyiniz...", sDil)
        Label2.Refresh()
        dataload(txt_ara.EditValue, sec_konum.Text, sec_kriter.Text, sec_depo.Text, sec_nGrupla.EditValue)
        Dim dr As DataRow
        Bar_Cari.Properties.Maximum = dataset1.Tables(0).Rows.Count
        Bar_Cari.Position = 0
        Bar_Cari.Refresh()
        gunes = Now
        Dim lKalanSaat As DateTime
        'Timer1.Enabled = True
        If sec_bYenile.Checked = True Then
            tbFirmaKapama_truncate()
        End If
        If sec_bGuncelle.Checked = True Then
            tbFirmaKapama_guncelle(txt_ara.Text, sec_konum.Text, sec_kriter.Text)
        End If
        For Each dr In dataset1.Tables(0).Rows
            lbl_Firma.Text = "FirmaKodu:" & dr("sKodu") & vbTab & "FirmaAdi:" & dr("sAciklama")
            lbl_Firma.Refresh()
            dataload_Firma(dr("nFirmaID"), Trim(dr("sKodu").ToString), sec_nGrupla.EditValue)
            Bar_Cari.Position += 1
            Bar_Cari.Refresh()
            'lKalanSaat = TimeSerial(Now.Hour - gunes.Hour, Now.Minute - gunes.Minute, Now.Second - gunes.Second)
            'Label2.Text = "Lütfen Bekleyiniz...Geçen Süre: " & lKalanSaat
            'Label2.Refresh()
        Next
        dr = Nothing
        Timer1.Enabled = False
        lKalanSaat = TimeSerial(Now.Hour - gunes.Hour, Now.Minute - gunes.Minute, Now.Second - gunes.Second)
        Bar_Cari.Position = 0
        Bar_Cari.Refresh()
        If bKapat = True Then
            Me.Close()
        Else
            Dim sAciklama As String = "Ýþlem Baþarýyla Tamamlandý..." & vbCrLf & "Tamamlanma Süresi:" & lKalanSaat
            XtraMessageBox.Show(sAciklama, Sorgu_sDil("Dikkat", sDil), MessageBoxButtons.OK, MessageBoxIcon.Information)
            SimpleButton1.Enabled = True
            SimpleButton2.Focus()
            SimpleButton2.Select()
            Label2.Text = sAciklama
            Label2.Refresh()
        End If
    End Sub
    Public Sub Dataload_tbKapatilacak(ByVal nFirmaID As String, ByVal nHareketID As Integer, ByVal sKodu As String, ByVal nGrupla As Integer)
        Try
            ds_tbKapatilacak.Tables(0).Clear()
        Catch ex As Exception
        End Try
        Dim conn As New OleDb.OleDbConnection
        Dim cmd As New OleDb.OleDbCommand
        Dim adapter As New OleDb.OleDbDataAdapter
        conn.ConnectionString = connection
        adapter.SelectCommand = cmd
        'cmd.CommandText = sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT dteIslemTarihi, dteValorTarihi, lTutar, sAciklama, sEvrakNo, sCariIslem, sDovizCinsi1,lDovizKuru1,lDovizMiktari1,nHareketId, OnceOdemeTutar, lOdemeTutar, nSiralama = CASE WHEN lOdemeTutar = 0 THEN '0' ELSE '1' END, (lTutar - lOdemeTutar)-OnceOdemeTutar AS lKalan FROM (SELECT dteIslemtarihi, dtevalorTarihi, lAlacakTutar AS lTutar, tbFirmaHareketi.sAciklama, sEvrakNo, sCariIslem, sDovizCinsi1,lDovizMiktari1,lDovizKuru1,nHareketId, isnull ((SELECT SUM(lTutar) FROM tbFirmaKapama WHERE nOdemeId = nHareketId AND nKarsilamaId <> " & nHareketID & "), 0) AS OnceOdemeTutar, isnull ((SELECT SUM(lTutar) FROM tbFirmaKapama WHERE nOdemeId = nHareketId AND nKarsilamaId = " & nHareketID & "), 0) AS lOdemeTutar FROM tbFirmaHareketi, tbFirma WHERE tbFirmaHareketi.nFirmaID = tbFirma.nFirmaID AND tbFirma.nFirmaID = '" & nFirmaID & "' AND lAlacakTutar <> 0) AS tbTemp Where (lTutar - lOdemeTutar) - OnceOdemeTutar <> 0 and OnceOdemeTutar <> lTutar ORDER BY nSiralama, dteIslemTarihi, dteValorTarihi")
        'cmd.CommandText = sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT dteIslemTarihi, dteValorTarihi, lTutar, sAciklama, sEvrakNo, sCariIslem, sDovizCinsi1,lDovizKuru1,lDovizMiktari1,nHareketId, lOdemeTutar, nSiralama = CASE WHEN lOdemeTutar = 0 THEN '0' ELSE '1' END, (lTutar - lOdemeTutar) AS lKalan FROM (SELECT dteIslemtarihi, dtevalorTarihi, lAlacakTutar AS lTutar, tbFirmaHareketi.sAciklama, sEvrakNo, sCariIslem, sDovizCinsi1,lDovizMiktari1,lDovizKuru1,nHareketId, isnull ((SELECT SUM(lTutar) FROM tbFirmaKapama WHERE nOdemeId = nHareketId ), 0) AS lOdemeTutar FROM tbFirmaHareketi, tbFirma WHERE tbFirmaHareketi.nFirmaID = tbFirma.nFirmaID AND tbFirma.nFirmaID = '" & nFirmaID & "' AND lAlacakTutar <> 0) AS tbTemp Where (lTutar - lOdemeTutar)  <> 0 ORDER BY nSiralama, dteIslemTarihi, dteValorTarihi")
        If nGrupla > 0 Then
            cmd.CommandText = sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT dteIslemTarihi, dteValorTarihi, lTutar,  sDovizCinsi1,lDovizKuru1,lDovizMiktari1,nHareketId, lOdemeTutar, nSiralama = CASE WHEN lOdemeTutar = 0 THEN '0' ELSE '1' END, (lTutar - lOdemeTutar) AS lKalan FROM (SELECT dteIslemtarihi, dtevalorTarihi, lAlacakTutar AS lTutar, sDovizCinsi1,lDovizMiktari1,lDovizKuru1,nHareketId, isnull ((SELECT SUM(lTutar) FROM tbFirmaKapama WHERE nOdemeId = nHareketId ), 0) AS lOdemeTutar FROM tbFirmaHareketi, tbFirma WHERE tbFirmaHareketi.nFirmaID = tbFirma.nFirmaID AND tbFirma.sKodu like   '" & sKodu & "%' AND lAlacakTutar <> 0) AS tbTemp Where (lTutar - lOdemeTutar)  <> 0 ORDER BY nSiralama, dteIslemTarihi, dteValorTarihi")
        Else
            cmd.CommandText = sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT dteIslemTarihi, dteValorTarihi, lTutar,  sDovizCinsi1,lDovizKuru1,lDovizMiktari1,nHareketId, lOdemeTutar, nSiralama = CASE WHEN lOdemeTutar = 0 THEN '0' ELSE '1' END, (lTutar - lOdemeTutar) AS lKalan FROM (SELECT dteIslemtarihi, dtevalorTarihi, lAlacakTutar AS lTutar, sDovizCinsi1,lDovizMiktari1,lDovizKuru1,nHareketId, isnull ((SELECT SUM(lTutar) FROM tbFirmaKapama WHERE nOdemeId = nHareketId ), 0) AS lOdemeTutar FROM tbFirmaHareketi, tbFirma WHERE tbFirmaHareketi.nFirmaID = tbFirma.nFirmaID AND tbFirma.nFirmaID = '" & nFirmaID & "' AND lAlacakTutar <> 0) AS tbTemp Where (lTutar - lOdemeTutar)  <> 0 ORDER BY nSiralama, dteIslemTarihi, dteValorTarihi")
        End If
        cmd.Connection = conn
        conn.Open()
        Dim N As Integer = adapter.Fill(ds_tbKapatilacak, "Table1")
        conn.Close()
    End Sub
    Private Sub tbFirma_HesapKapat()
        'Dim dr As DataRow
        'Dim dr1 As DataRow
        'Dim nKapamaID As Int64 = 0
        'Dim lOdenen As Decimal = 0
        'Dim s As String
        'Dim arr As Integer()
        'Dim i As Integer
        'arr = GridView2.GetSelectedRows()
        'If arr Is Nothing Then
        'Else
        '    Array.Sort(arr)
        '    For Each i In arr
        '        s = i.ToString
        '        dr1 = GridView2.GetDataRow(s)
        '        nKapamaID = sorgu_sayi(sorgu_tbFirmaKapama_nkayit_kontrol(dr("nHareketID")), 0)
        '        If dr("lKalan") > dr1("lKalan") Then
        '            tbFirmaKapama_kaydet_yeni(0, dr("nHareketID"), dr1("nHareketID"), dr1("lKalan"), "")
        '        ElseIf dr("lKalan") <= dr1("lKalan") Then
        '            tbFirmaKapama_kaydet_yeni(0, dr("nHareketID"), dr1("nHareketID"), dr("lKalan"), "")
        '        End If
        '        If nKapamaID > 0 Then
        '            lOdenen = sorgu_sayi(sorgu_tbFirmaKapama_lOdenen_kontrol(dr("nHareketID")), 0)
        '            tbFirmaKapama_kaydet_duzelt(nKapamaID, dr("nHareketID"), 0, lOdenen, "")
        '        ElseIf nKapamaID = 0 Then
        '            lOdenen = sorgu_sayi(sorgu_tbFirmaKapama_lOdenen_kontrol(dr("nHareketID")), 0)
        '            tbFirmaKapama_kaydet_yeni(0, dr("nHareketID"), 0, lOdenen, "")
        '        End If
        '    Next
        'End If
        'lKapamaID = Nothing
        'lOdenen = Nothing
        'Dataload_tbFirmaHesabi(nFirmaID, sec_bKapanan.Checked)
    End Sub
    Private Sub SimpleButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SimpleButton1.Click
        baslat()
    End Sub
    Private Sub baslat()
        gunes = Now
        Timer1.Enabled = True
        BeginSearch()
    End Sub
    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        lKalanSaat = TimeSerial(Now.Hour - gunes.Hour, Now.Minute - gunes.Minute, Now.Second - gunes.Second)
        Label2.Text = "Lütfen Bekleyiniz...Geçen Süre: " & lKalanSaat
    End Sub
End Class