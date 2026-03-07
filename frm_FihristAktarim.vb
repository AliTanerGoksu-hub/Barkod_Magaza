Imports DevExpress.XtraEditors
Public Class frm_FihristAktarim
    Public connection
    Public firmano
    Public donemno
    Dim sModul As String = "Cari"
    Dim count As String = ""
    Dim dataset1 As DataSet
    Private Sub frm_FihristAktarim_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
    End Sub
    Private Sub SimpleButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SimpleButton1.Click
        If sec_AktarimTipi.SelectedIndex = 0 Then
            sModul = "Cari"
        ElseIf sec_AktarimTipi.SelectedIndex = 1 Then
            sModul = "Banka"
        ElseIf sec_AktarimTipi.SelectedIndex = 2 Then
            sModul = "Musteri"
        End If
        ara()
    End Sub
    Private Sub SimpleButton2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SimpleButton2.Click
        Me.Close()
    End Sub
    Public Function stok(ByVal ara As String, ByVal konum As String, ByVal ara_kriter As String, ByVal bAktif As Integer) As DataSet
        Dim kriter As String = ""
        If konum = "Kodu" Then
            kriter += " WHERE ( tbFirma.sKodu " & sorgu_kriter_string(ara, ara_kriter) & " )"
        ElseIf konum = "Adı" Then
            kriter += " WHERE ( tbFirma.sAciklama " & sorgu_kriter_string(ara, ara_kriter) & " )"
        ElseIf konum = "Gelişmiş" Then
            kriter += " WHERE ( tbFirma.sKodu " & sorgu_kriter_string(ara, ara_kriter) & " ) or ( tbFirma.sAciklama " & sorgu_kriter_string(ara, ara_kriter) & " )"
        ElseIf konum = "İstihbarat" Then
            kriter += " WHERE (( tbFirmaAciklamasi.sAciklama1 + ' ' + tbFirmaAciklamasi.sAciklama2 + ' ' + tbFirmaAciklamasi.sAciklama3 + ' ' + tbFirmaAciklamasi.sAciklama4 + '  ' + tbFirmaAciklamasi.sAciklama5) " & sorgu_kriter_string(ara, ara_kriter) & " )"
        ElseIf konum = "Adres" Then
            kriter += " WHERE ( tbFirma.sAdres1 + ' ' + tbFirma.sAdres2 + ' ' + tbFirma.sSemt + ' ' + tbFirma.sIl + ' ' + tbFirma.sUlke + ' ' + tbFirma.sPostaKodu  " & sorgu_kriter_string(ara, ara_kriter) & " )"
        ElseIf konum = "Sınıf1" Then
            kriter += " WHERE (tbFSinif1.sAciklama " & sorgu_kriter_string(ara, ara_kriter) & " )"
        ElseIf konum = "Sınıf2" Then
            kriter += " WHERE (tbFSinif2.sAciklama " & sorgu_kriter_string(ara, ara_kriter) & " )"
        ElseIf konum = "Sınıf3" Then
            kriter += " WHERE (tbFSinif3.sAciklama " & sorgu_kriter_string(ara, ara_kriter) & " )"
        ElseIf konum = "Sınıf4" Then
            kriter += " WHERE (tbFSinif4.sAciklama " & sorgu_kriter_string(ara, ara_kriter) & " )"
        ElseIf konum = "Sınıf5" Then
            kriter += " WHERE (tbFSinif5.sAciklama " & sorgu_kriter_string(ara, ara_kriter) & " )"
        ElseIf konum = "Adı+Soyadı" Then
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
                kriter += " WHERE ( tbMusteri.sAdi " & sorgu_kriter_string(adi, ara_kriter) & " )"
            End If
            If soyadi.ToString <> "" Then
                kriter += " AND ( tbMusteri.sSoyadi " & sorgu_kriter_string(soyadi, ara_kriter) & " )"
            End If
        Else
        End If
        'kriter = "WHERE tbMusteri.dteKayitTarihi between '" & Microsoft.VisualBasic.Left(tarih1.ToString, 10) + " 00:00:00" & "' and '" & Microsoft.VisualBasic.Left(tarih1.ToString, 10) + " 23:59:59" & "' "
        kriter += " and tbFirma.sKodu <>'' "
        kriter += " and tbFirma.bAktif = " & bAktif & ""
        If sModul = "Cari" Then
            kriter += " and tbFirma.sKodu not like '102%' "
            If sCariSinirla <> "" Then
                kriter += " and tbFirma.sKodu like '" & sCariSinirla & "%' "
            End If
            If sCariSinifKoduSinirla <> "" Then
                kriter += " and tbFirma.nFirmaID IN (SELECT     nFirmaID FROM         tbFirmaSinifi WHERE     (sSinifKodu1 IN (" & sCariSinifKoduSinirla & ")))"
            End If
        ElseIf sModul = "Banka" Then
            kriter += " and tbFirma.sKodu like '102%' "
            If sBankaSinirla <> "" Then
                kriter += " and tbFirma.sKodu like '" & sBankaSinirla & "%' "
            End If
        End If
        kriter += " AND tbFirma.sKodu NOT IN (SELECT KODU FROM TBLAJNFIHRIST) "
        If nKayitSinir > 0 Then
            count = " TOP " & nKayitSinir & " "
        End If
        Dim conn As New OleDb.OleDbConnection
        Dim cmd As New OleDb.OleDbCommand
        Dim adapter As New OleDb.OleDbDataAdapter
        'If sModul = "Musteri" Then
        '    conn.ConnectionString = "Provider=SQLOLEDB.1;Password=1980;Persist Security Info=True;User ID=MUHASEBE;Initial Catalog=UGURLU;Data Source=88.249.28.14;Current Language=Türkçe;Application Name=BusinessERP"
        'Else
        conn.ConnectionString = connection
        'End If
        'conn.ConnectionString = connection
        cmd.CommandTimeout = False
        adapter.SelectCommand = cmd
        'cmd.CommandText = sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT " & count & " tbFirma.nFirmaID, tbFirma.sKodu, tbFirma.sAciklama, tbFirma.sSaticiRumuzu,tbFirma.nOzelIskontosu,tbFirma.nOzelIskontosu2,tbFirma.nOzelIskontosu3,tbFirma.nOzelIskontosu4,tbFirma.sFiyatTipi, tbFirma.lKrediLimiti, tbFirma.sSemt,tbFirma.sIl,tbFirma.sUlke,tbFirma.sPostaKodu,tbFirma.nVadeGun,tbFirma.sAdres1,tbFirma.sAdres2,tbFirma.sAdres1 + ' ' + tbFirma.sAdres2 + ' ' + tbFirma.sSemt + ' ' + tbFirma.sIl + ' ' + tbFirma.sUlke + ' ' + tbFirma.sPostaKodu AS Adres, tbFirma.sVergiDairesi, tbFirma.sVergiNo, tbFirmaAciklamasi.sAciklama1 + ' ' + tbFirmaAciklamasi.sAciklama2 + ' ' + tbFirmaAciklamasi.sAciklama3 + ' ' + tbFirmaAciklamasi.sAciklama4 + ' ' + tbFirmaAciklamasi.sAciklama5 AS ISTIHBARAT, tbFSinif1.sAciklama AS SINIF1, tbFSinif2.sAciklama AS SINIF2, tbFSinif3.sAciklama AS SINIF3, tbFSinif4.sAciklama AS SINIF4, tbFSinif5.sAciklama AS SINIF5, (SELECT ISNULL(SUM(lBorcTutar - lAlacakTutar) , 0) AS lBakiye FROM tbFirmaHareketi WHERE nFirmaID = tbFirma.nFirmaID) AS lBakiye, tbHesapPlani.nHesapID, tbHesapPlani.sKodu AS sHesapKodu, tbHesapPlani.sAciklama AS sHesapAciklama,(SELECT     TOP 1 sIletisimAdresi FROM          tbFirmaIletisimi WHERE      nFirmaId = tbFirma.nFirmaID AND sIletisimAraci = 'E-Mail') AS [E-Mail],(SELECT     TOP 1 sIletisimAdresi FROM          tbFirmaIletisimi WHERE      nFirmaId = tbFirma.nFirmaID AND sIletisimAraci = 'Fax') AS [Fax],(SELECT     TOP 1 sIletisimAdresi FROM          tbFirmaIletisimi WHERE      nFirmaId = tbFirma.nFirmaID AND sIletisimAraci = 'Gsm') AS [Gsm],(SELECT     TOP 1 sIletisimAdresi FROM          tbFirmaIletisimi WHERE      nFirmaId = tbFirma.nFirmaID AND sIletisimAraci = 'Telefon') AS [Telefon],(SELECT     TOP 1 sIletisimAdresi FROM          tbFirmaIletisimi WHERE      nFirmaId = tbFirma.nFirmaID AND sIletisimAraci = 'Web') AS [Web],(SELECT     TOP 1 sIletisimAdresi FROM          tbFirmaIletisimi WHERE      nFirmaId = tbFirma.nFirmaID AND sIletisimAraci = 'Yetkili') AS [Yetkili],tbFirma.bSatisYapilamaz,tbFirma.bTahsilatYapilamaz FROM tbFirmaAciklamasi RIGHT OUTER JOIN tbFirma INNER JOIN tbHesapPlani ON tbFirma.nHesapID = tbHesapPlani.nHesapID ON tbFirmaAciklamasi.nFirmaID = tbFirma.nFirmaID LEFT OUTER JOIN tbFSinif1 INNER JOIN tbFirmaSinifi ON tbFSinif1.sSinifKodu = tbFirmaSinifi.sSinifKodu1 INNER JOIN tbFSinif2 ON tbFirmaSinifi.sSinifKodu2 = tbFSinif2.sSinifKodu INNER JOIN tbFSinif3 ON tbFirmaSinifi.sSinifKodu3 = tbFSinif3.sSinifKodu INNER JOIN tbFSinif4 ON tbFirmaSinifi.sSinifKodu4 = tbFSinif4.sSinifKodu INNER JOIN tbFSinif5 ON tbFirmaSinifi.sSinifKodu5 = tbFSinif5.sSinifKodu ON tbFirma.nFirmaID = tbFirmaSinifi.nFirmaID " & kriter & " ORDER BY tbFirma.sKodu")
        If sModul = "Musteri" Then
            cmd.CommandText = sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT * from tbMusteri Order by lKodu")
            'cmd.CommandText = sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT * from tbMusteri Where sEvAdresi1 like 'Güvenevler%' Order by lKodu")
        Else
            cmd.CommandText = sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT " & count & " tbFirma.nFirmaID, tbFirma.sKodu, tbFirma.sAciklama, tbFirma.sSaticiRumuzu,tbFirma.nOzelIskontosu,tbFirma.nOzelIskontosu2,tbFirma.nOzelIskontosu3,tbFirma.nOzelIskontosu4,tbFirma.sFiyatTipi, tbFirma.lKrediLimiti, tbFirma.sSemt,tbFirma.sIl,tbFirma.sUlke,tbFirma.sPostaKodu,tbFirma.nVadeGun,tbFirma.sAdres1,tbFirma.sAdres2,tbFirma.sAdres1 + ' ' + tbFirma.sAdres2 + ' ' + tbFirma.sSemt + ' ' + tbFirma.sIl + ' ' + tbFirma.sUlke + ' ' + tbFirma.sPostaKodu AS Adres, tbFirma.sVergiDairesi, tbFirma.sVergiNo, tbFirmaAciklamasi.sAciklama1 + ' ' + tbFirmaAciklamasi.sAciklama2 + ' ' + tbFirmaAciklamasi.sAciklama3 + ' ' + tbFirmaAciklamasi.sAciklama4 + ' ' + tbFirmaAciklamasi.sAciklama5 AS ISTIHBARAT, tbFSinif1.sAciklama AS SINIF1, tbFSinif2.sAciklama AS SINIF2, tbFSinif3.sAciklama AS SINIF3, tbFSinif4.sAciklama AS SINIF4, tbFSinif5.sAciklama AS SINIF5, lBakiye = CASE WHEN tbFirma.sDovizCinsi = '   ' THEN (SELECT ISNULL(SUM(lBorcTutar - lAlacakTutar), 0) AS lBakiye FROM tbFirmaHareketi WHERE nFirmaID = tbFirma.nFirmaID) ELSE (SELECT ISNULL(SUM((lBorcTutar - lAlacakTutar)/lDovizKuru1) , 0) AS lBakiye FROM tbFirmaHareketi WHERE nFirmaID = tbFirma.nFirmaID AND sDovizCinsi1 = tbFirma.sDovizCinsi) END, tbFirma.sDovizCinsi, tbHesapPlani.nHesapID, tbHesapPlani.sKodu AS sHesapKodu, tbHesapPlani.sAciklama AS sHesapAciklama,(SELECT     TOP 1 sIletisimAdresi FROM          tbFirmaIletisimi WHERE      nFirmaId = tbFirma.nFirmaID AND sIletisimAraci = 'E-Mail') AS [E-Mail],(SELECT     TOP 1 sIletisimAdresi FROM          tbFirmaIletisimi WHERE      nFirmaId = tbFirma.nFirmaID AND sIletisimAraci = 'Fax') AS [Fax],(SELECT     TOP 1 sIletisimAdresi FROM          tbFirmaIletisimi WHERE      nFirmaId = tbFirma.nFirmaID AND sIletisimAraci = 'Gsm') AS [Gsm],(SELECT     TOP 1 sIletisimAdresi FROM          tbFirmaIletisimi WHERE      nFirmaId = tbFirma.nFirmaID AND sIletisimAraci = 'Telefon') AS [Telefon],(SELECT     TOP 1 sIletisimAdresi FROM          tbFirmaIletisimi WHERE      nFirmaId = tbFirma.nFirmaID AND sIletisimAraci = 'Web') AS [Web],(SELECT     TOP 1 sIletisimAdresi FROM          tbFirmaIletisimi WHERE      nFirmaId = tbFirma.nFirmaID AND sIletisimAraci = 'Yetkili') AS [Yetkili],tbFirma.bSatisYapilamaz,tbFirma.bTahsilatYapilamaz FROM tbFirmaAciklamasi RIGHT OUTER JOIN tbFirma INNER JOIN tbHesapPlani ON tbFirma.nHesapID = tbHesapPlani.nHesapID ON tbFirmaAciklamasi.nFirmaID = tbFirma.nFirmaID LEFT OUTER JOIN tbFSinif1 INNER JOIN tbFirmaSinifi ON tbFSinif1.sSinifKodu = tbFirmaSinifi.sSinifKodu1 INNER JOIN tbFSinif2 ON tbFirmaSinifi.sSinifKodu2 = tbFSinif2.sSinifKodu INNER JOIN tbFSinif3 ON tbFirmaSinifi.sSinifKodu3 = tbFSinif3.sSinifKodu INNER JOIN tbFSinif4 ON tbFirmaSinifi.sSinifKodu4 = tbFSinif4.sSinifKodu INNER JOIN tbFSinif5 ON tbFirmaSinifi.sSinifKodu5 = tbFSinif5.sSinifKodu ON tbFirma.nFirmaID = tbFirmaSinifi.nFirmaID " & kriter & " ORDER BY tbFirma.sKodu")
        End If
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
    Private Sub ara()
        Label2.Text = Sorgu_sDil("Lütfen Bekleyiniz...", sDil)
        Label2.Refresh()
        Cursor.Current = Cursors.WaitCursor
        Cursor.Show()
        dataload("", "Kodu", "Başlar", 1)
        Label2.Text = Sorgu_sDil("Tamamlandı...", sDil)
        Cursor.Current = Cursors.Default
        Cursor.Hide()
    End Sub
    Private Sub dataload(ByVal ara As String, ByVal konum As String, ByVal ara_kriter As String, ByVal bAktif As Integer)
        dataset1 = stok(ara, konum, ara_kriter, Math.Abs(bAktif))
        Dim dr As DataRow
        Bar1.Properties.Maximum = dataset1.Tables(0).Rows.Count
        Bar1.Position = 0
        Bar1.Refresh()
        Bar1.Visible = True
        For Each dr In dataset1.Tables(0).Rows
            If sModul = "Musteri" Then
                Label2.Text = "Kodu: " & dr("lKodu") & " Adı: " & dr("sAdi")
                Label2.Refresh()
                Try
                    TBLAJNFIHRIST_Ekle_yeni(Trim(dr("lKodu").ToString).ToString, Trim(dr("sAdi").ToString).ToString, Trim(dr("sSoyadi").ToString).ToString, Trim(dr("sAdi").ToString).ToString, "", Trim(dr("sVergiDairesi").ToString).ToString, Trim(dr("sVergiNo").ToString).ToString, Trim(dr("sEvTelefonu").ToString).ToString, Trim(dr("sGSM").ToString).ToString, Trim(dr("sIsTelefonu").ToString).ToString, "", "", Trim(dr("sFax").ToString).ToString, "", Trim(dr("sEvPostaKodu").ToString).ToString, Trim(dr("sEvAdresi1").ToString).ToString, Trim(dr("sEvAdresi2").ToString).ToString, "", Trim(dr("sEvSemt").ToString).ToString, "", "", Trim(dr("sIsAdresi1").ToString).ToString, Trim(dr("sEmail").ToString).ToString, Trim(dr("sAdi").ToString).ToString, "", Trim(dr("sAciklama1").ToString).ToString, "", "", "", "", "", "", 0, 0, 0, 0, "01/01/1900", "01/01/1900", "01/01/1900", "01/01/1900", "1. Ek Bilgi", "2. Ek Bilgi", "3. Ek Bilgi", "4. Ek Bilgi", "5. Ek Bilgi", "1. Parasal Bilgi", "2. Parasal Bilgi", "3. Parasal Bilgi", "4. Parasal Bilgi", "5. Parasal Bilgi", "1. Tarihsel Bilgi", "2. Tarihsel Bilgi", "3. Tarihsel Bilgi", "4. Tarihsel Bilgi", "5. Tarihsel Bilgi", dr("sEvIl").ToString, "")
                Catch ex As Exception
                    XtraMessageBox.Show(Sorgu_sDil("Kodu: " & dr("lKodu") & " Adı: " & dr("sAdi") & " Hesabını Kontrol Ediniz...!", sDil), Sorgu_sDil("Dikkat", sDil), MessageBoxButtons.OK, MessageBoxIcon.Warning)
                End Try
            Else
                Label2.Text = "Kodu: " & dr("sKodu") & " Adı: " & dr("sAciklama")
                Label2.Refresh()
                Try
                    TBLAJNFIHRIST_Ekle_yeni(Trim(dr("sKodu").ToString).ToString, Trim(dr("sAciklama").ToString).ToString, "", Trim(dr("sAciklama").ToString).ToString, "", Trim(dr("sVergiDairesi").ToString).ToString, Trim(dr("sVergiNo").ToString).ToString, Trim(dr("Telefon").ToString).ToString, Trim(dr("Gsm").ToString).ToString, "", "", "", Trim(dr("Fax").ToString).ToString, "", Trim(dr("sPostaKodu").ToString).ToString, Trim(dr("sAdres1").ToString).ToString, Trim(dr("sAdres2").ToString).ToString, "", Trim(dr("sSemt").ToString).ToString, "", "", Trim(dr("Adres").ToString).ToString, Trim(dr("E-Mail").ToString).ToString, Trim(dr("Yetkili").ToString).ToString, "", Trim(dr("ISTIHBARAT").ToString).ToString, "", "", "", "", "", "", 0, 0, 0, 0, "01/01/1900", "01/01/1900", "01/01/1900", "01/01/1900", "1. Ek Bilgi", "2. Ek Bilgi", "3. Ek Bilgi", "4. Ek Bilgi", "5. Ek Bilgi", "1. Parasal Bilgi", "2. Parasal Bilgi", "3. Parasal Bilgi", "4. Parasal Bilgi", "5. Parasal Bilgi", "1. Tarihsel Bilgi", "2. Tarihsel Bilgi", "3. Tarihsel Bilgi", "4. Tarihsel Bilgi", "5. Tarihsel Bilgi", dr("sIl").ToString, dr("Web").ToString)
                Catch ex As Exception
                    XtraMessageBox.Show(Sorgu_sDil("Kodu: " & dr("sKodu") & " Adı: " & dr("sAciklama") & " Hesabını Kontrol Ediniz...!", sDil), Sorgu_sDil("Dikkat", sDil), MessageBoxButtons.OK, MessageBoxIcon.Warning)
                End Try
            End If
            Bar1.Position = Bar1.Position + 1
            Bar1.Refresh()
        Next
        Bar1.Position = 0
        Bar1.Refresh()
        Bar1.Visible = False
        XtraMessageBox.Show(Sorgu_sDil("İşlem Başarıyla Tamamlandı...", sDil), Sorgu_sDil("Dikkat", sDil), MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub
    Public Sub TBLAJNFIHRIST_Ekle_yeni(ByVal KODU As String, ByVal ADI As String, ByVal SOYADI As String, ByVal UNVANI As String, ByVal UZUNADI As String, ByVal VERGIDAIRESI As String, ByVal VERGINO As String, ByVal TELEFON1 As String, ByVal TELEFON2 As String, ByVal TELEFON3 As String, ByVal TELEFON4 As String, ByVal TELEFON5 As String, ByVal FAX1 As String, ByVal FAX2 As String, ByVal POSTAKODU As String, ByVal CADDE As String, ByVal SOKAK As String, ByVal MAH As String, ByVal SEMT As String, ByVal DAIRENO As String, ByVal KAPINO As String, ByVal ADRES As String, ByVal EMAIL As String, ByVal ILGILIKISI As String, ByVal ILGILIKISIGOREVI As String, ByVal ACIKLAMA As String, ByVal ALAN1 As String, ByVal ALAN2 As String, ByVal ALAN3 As String, ByVal ALAN4 As String, ByVal ALAN5 As String, ByVal ALAN6 As String, ByVal ALAN7 As String, ByVal ALAN8 As String, ByVal ALAN9 As String, ByVal ALAN10 As String, ByVal ALAN11 As String, ByVal ALAN12 As String, ByVal ALAN13 As String, ByVal ALAN14 As String, ByVal BASLIKALAN1 As String, ByVal BASLIKALAN2 As String, ByVal BASLIKALAN3 As String, ByVal BASLIKALAN4 As String, ByVal BASLIKALAN5 As String, ByVal BASLIKALAN6 As String, ByVal BASLIKALAN7 As String, ByVal BASLIKALAN8 As String, ByVal BASLIKALAN9 As String, ByVal BASLIKALAN10 As String, ByVal BASLIKALAN11 As String, ByVal BASLIKALAN12 As String, ByVal BASLIKALAN13 As String, ByVal BASLIKALAN14 As String, ByVal IL As String, ByVal ILCE As String, ByVal WEB As String)
        Dim cmd As New OleDb.OleDbCommand
        Dim con As New OleDb.OleDbConnection
        con.ConnectionString = connection
        cmd.Connection = con
        con.Open()
        cmd.CommandText = sorgu_query("SET DATEFORMAT DMY INSERT INTO TBLAJNFIHRIST(KODU, ADI, SOYADI, UNVANI, UZUNADI, VERGIDAIRESI, VERGINO, TELEFON1, TELEFON2, TELEFON3, TELEFON4, TELEFON5, FAX1, FAX2, POSTAKODU, CADDE, SOKAK, MAH, SEMT, DAIRENO, KAPINO, ADRES, EMAIL, ILGILIKISI, ILGILIKISIGOREVI, ACIKLAMA, ALAN1, ALAN2, ALAN3, ALAN4, ALAN5, ALAN6, ALAN7, ALAN8, ALAN9, ALAN10, ALAN11, ALAN12, ALAN13, ALAN14, BASLIKALAN1, BASLIKALAN2, BASLIKALAN3, BASLIKALAN4, BASLIKALAN5, BASLIKALAN6, BASLIKALAN7, BASLIKALAN8, BASLIKALAN9, BASLIKALAN10, BASLIKALAN11, BASLIKALAN12, BASLIKALAN13, BASLIKALAN14, IL, ILCE, WEB) VALUES (N'" & KODU & "', N'" & ADI & "', N'" & SOYADI & "', N'" & UNVANI & "', N'" & ADI & "', N'" & VERGIDAIRESI & "', N'" & VERGINO & "', N'" & TELEFON1 & "', N'" & TELEFON2 & "', N'" & TELEFON3 & "', N'" & TELEFON4 & "', N'" & TELEFON5 & "', N'" & FAX1 & "', N'" & FAX2 & "', N'" & POSTAKODU & "', N'" & CADDE & "', N'" & SOKAK & "', N'" & MAH & "', N'" & SEMT & "', N'" & DAIRENO & "',  N'" & KAPINO & "', N'" & ADRES & "' , N'" & EMAIL & "', N'" & ILGILIKISI & "' , N'" & ILGILIKISIGOREVI & "' , N'" & ACIKLAMA & "', N'" & ALAN1 & "' , N'" & ALAN2 & "', N'" & ALAN3 & "', N'" & ALAN4 & "' , N'" & ALAN5 & "' , N'" & ALAN6 & "' , '" & ALAN7 & "' , '" & ALAN8 & "' , '" & ALAN9 & "' , '" & ALAN10 & "' , '" & ALAN11 & "' , '" & ALAN12 & "' , '" & ALAN13 & "' , '" & ALAN14 & "' , N'" & BASLIKALAN1 & "',  N'" & BASLIKALAN2 & "' , N'" & BASLIKALAN3 & "' , N'" & BASLIKALAN4 & "' , N'" & BASLIKALAN5 & "', N'" & BASLIKALAN6 & "' , N'" & BASLIKALAN7 & "', N'" & BASLIKALAN8 & "' , N'" & BASLIKALAN9 & "' , N'" & BASLIKALAN10 & "' , N'" & BASLIKALAN11 & "' , N'" & BASLIKALAN12 & "' , N'" & BASLIKALAN13 & "' , N'" & BASLIKALAN14 & "' , N'" & IL & "' , N'" & ILCE & "' , N'" & WEB & "')")
        Dim sonuc = cmd.ExecuteNonQuery
        con.Close()
        cmd = Nothing
        con = Nothing
    End Sub
End Class