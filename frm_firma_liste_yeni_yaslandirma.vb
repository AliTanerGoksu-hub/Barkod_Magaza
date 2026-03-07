Imports Microsoft.Win32
Imports DevExpress.XtraEditors
Public Class frm_firma_liste_yeni_yaslandirma
    Public firmano
    Public donemno
    Public connection
    Public musterino
    Public kullanici
    Public sModul As String = "Cari"
    Dim conn As New OleDb.OleDbConnection
    Dim cmd As New OleDb.OleDbCommand
    Dim adapter As New OleDb.OleDbDataAdapter
    Dim DS As New DataSet
    Dim ds_tbDepo As DataSet
    Dim ds_tbSatici As DataSet
    Public sFiyatTipi As String = ""
    'Public sDepo As String = ""
    Public islemstatus As Boolean = False
    Private Sub frm_cari_faturalar_acik_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            gorunum_yukle()
        Catch ex As Exception
        End Try
        'DateEdit1.EditValue = dteSistemTarihi
        'DateEdit2.EditValue = dteSistemTarihi
        PanelControl1.Focus()
        GroupControl1.Focus()
        GroupControl1.Select()
        txt_ara.EditValue = ""
        DateEdit1.Focus()
        DateEdit1.Select()
        dataload_tbdepo()
        dataload_tbSatici()
    End Sub
    Private Sub SimpleButton2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SimpleButton2.Click
        Me.Close()
    End Sub
    Private Sub MenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem1.Click
        GridControl1.FieldsCustomization()
    End Sub
    Private Sub MenuItem5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem5.Click
        'GridView1.OptionsView.ShowFilterPanelMode = DevExpress.XtraGrid.Views.Base.ShowFilterPanelMode.Default
        'GridView1.OptionsCustomization.AllowFilter = True
    End Sub
    Private Sub MenuItem6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem6.Click
        'GridView1.OptionsView.ShowGroupPanel = True
        'GridView1.OptionsCustomization.AllowGroup = True
    End Sub
    Private Sub MenuItem7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem7.Click
        'GridView1.ExpandAllGroups()
    End Sub
    Private Sub MenuItem8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem8.Click
        'GridView1.CollapseAllGroups()
    End Sub
    Private Sub MenuItem9_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem9.Click
        If Me.WindowState = FormWindowState.Normal Then
            Me.WindowState = FormWindowState.Maximized
        ElseIf Me.WindowState = FormWindowState.Maximized Then
            Me.WindowState = FormWindowState.Normal
        End If
    End Sub
    Private Sub MenuItem13_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem13.Click
        Me.Close()
    End Sub
    Private Sub MenuItem14_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem14.Click
        Me.Close()
    End Sub
    Private Sub MenuItem4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem4.Click
        Dim kriter As String = ""
        kriter += Microsoft.VisualBasic.Left(DateEdit1.EditValue.ToString, 10) & " ve " & Microsoft.VisualBasic.Left(DateEdit2.EditValue.ToString, 10) & " Tarihleri Arasındaki Acik Borc/Alacaklar" & vbCrLf
        kriter += "Bakiye : " & sec_bakiye.Text & " Listeleme : " & sec_islem.Text & " Satici: " & sec_sSatici.Text
        Me.printlink1.PageHeaderFooter = New DevExpress.XtraPrinting.PageHeaderFooter(New DevExpress.XtraPrinting.PageHeaderArea(New String() {"[User Name]", kriter, "[Date Printed][Time Printed]"}, New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte)), DevExpress.XtraPrinting.BrickAlignment.Center), New DevExpress.XtraPrinting.PageFooterArea(New String() {"Powered by www.barkodyazilimevi.com", "Financial Managment-Finans Yönetimi", "[Page # of Pages #]"}, New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte)), DevExpress.XtraPrinting.BrickAlignment.Near))
        printlink1.CreateDocument(ps)
        ps.PreviewRibbonFormEx.Show()
    End Sub
    Private Sub dataload_tbdepo()
        If Trim(sDepo) = "D012" Or Trim(sDepo) = "D013" Then
            ds_tbDepo = sorgu(sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT     CAST('0' as bit) AS SEC, sDepo AS KOD, sAciklama AS ACIKLAMA FROM         tbDepo Where sDepo IN ('D012','D013')"))
            'sec_sDepo.Properties.DataSource = ds_tbDepo.Tables(0)
        Else
            'ds_tbDepo = sorgu(sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT     CAST('0' as bit) AS SEC, sDepo AS KOD, sAciklama AS ACIKLAMA FROM         tbDepo WHERE sDepo <> '' ORDER BY sDepo"))
            ds_tbDepo = sorgu(sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT     CAST('0' as bit) AS SEC, sDepo AS KOD, sAciklama AS ACIKLAMA FROM         tbDepo  ORDER BY sDepo"))
            'sec_sDepo.Properties.DataSource = ds_tbDepo.Tables(0)
        End If
        If Trim(sDepo) = "D001" Or Trim(sDepo) = "D012" Or Trim(sDepo) = "D013" Then
            sec_sdepo.EditValue = "'" & sDepo & "'"
            If kullanici > 3 Then
                sec_sdepo.Properties.ReadOnly = False
            Else
                sec_sdepo.Properties.ReadOnly = False
            End If
        Else
            If kullanici > 3 Then
                sec_sdepo.EditValue = "'" & sDepo & "'"
                sec_sdepo.Properties.ReadOnly = True
            Else
                'sec_sDepo.EditValue = sDepo
                sec_sdepo.Properties.ReadOnly = False
            End If
            'sec_sDepo.EditValue = sDepo
            'sec_sDepo.Properties.ReadOnly = False
        End If
        'sec_sDepo.ItemIndex = 1
    End Sub
    Private Sub dataload_tbSatici()
        ds_tbSatici = sorgu(sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT     CAST('0' as bit) AS SEC, sSaticiRumuzu AS KOD, sAdi + ' ' + sSoyadi AS ACIKLAMA FROM         tbSatici where (bAktif = 1)"))
        'sec_sHareketTipi.ItemIndex = 1
        If Trim(sDepo) = "D001" Or Trim(sDepo) = "D012" Or Trim(sDepo) = "D013" Then
            'sec_sSatici.EditValue = "'" & sSaticiRumuzu & "'"
            If Trim(sSaticiRumuzu) = "" Then
                sec_sSatici.EditValue = "[Tümü]"
            Else
                sec_sSatici.EditValue = "'" & sSaticiRumuzu & "'"
            End If
            If kullanici > 3 Then
                sec_sSatici.Properties.ReadOnly = False
            Else
                sec_sSatici.Properties.ReadOnly = False
            End If
        Else
            If kullanici > 3 Then
                'sec_sSatici.EditValue = "'" & sSaticiRumuzu & "'"
                If Trim(sSaticiRumuzu) = "" Then
                    sec_sSatici.EditValue = "[Tümü]"
                Else
                    sec_sSatici.EditValue = "'" & sSaticiRumuzu & "'"
                End If
                sec_sSatici.Properties.ReadOnly = True
            Else
                'sec_sDepo.EditValue = sDepo
                sec_sSatici.Properties.ReadOnly = False
            End If
            'sec_sDepo.EditValue = sDepo
            'sec_sDepo.Properties.ReadOnly = False
        End If
    End Sub
    Private Function sorgu(ByVal query As String) As DataSet
        conn.ConnectionString = connection
        adapter.SelectCommand = cmd
        cmd.CommandText = query
        cmd.Connection = conn
        conn.Open()
        Dim DS As New DataSet
        Dim N As Integer = adapter.Fill(DS, "TABLE1")
        conn.Close()
        Return DS
    End Function
    Private Sub gorunum_kaydet()
        GridControl1.SaveLayoutToRegistry("SOFTWARE\BusinessSmart\VIEW\MAGAZA\" & Me.Name.ToString & "")
        XtraMessageBox.Show(Sorgu_sDil("Görünüm Kaydedildi", sDil), Sorgu_sDil("Dikkat", sDil), MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub
    Private Sub gorunum_yukle()
        Try
        Catch ex As Exception
        End Try
        Try
            If nFontSize > 0 Then
                Dim sayi As Single = nFontSize
                GridControl1.Appearance.FieldValue.Font = New System.Drawing.Font("Tahoma", sayi, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
                GridControl1.Appearance.FieldValueTotal.Font = New System.Drawing.Font("Tahoma", sayi, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
                GridControl1.Appearance.RowHeaderArea.Font = New System.Drawing.Font("Tahoma", sayi, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
                'VGrid_Baslik.Appearance.RecordValue.Font = New System.Drawing.Font("Tahoma", sayi, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
                sayi = Nothing
            End If
        Catch ex As Exception
        End Try
        For Each clmn As DevExpress.XtraPivotGrid.PivotGridField In GridControl1.Fields
            clmn.Caption = Sorgu_sDil(clmn.Caption, sDil)
        Next
        Dim itm
        For Each itm In ContextMenu1.MenuItems
            itm.text = Sorgu_sDil(itm.text, sDil)
        Next
        SimpleButton1.Text = Sorgu_sDil(SimpleButton1.Text, sDil)
        SimpleButton2.Text = Sorgu_sDil(SimpleButton2.Text, sDil)
        SimpleButton3.Text = Sorgu_sDil(SimpleButton3.Text, sDil)
        GridControl1.RestoreLayoutFromRegistry("SOFTWARE\BusinessSmart\VIEW\MAGAZA\" & Me.Name.ToString & "")
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
    Public Function stok(ByVal ara As String, ByVal konum As String, ByVal ara_kriter As String, ByVal tarih1 As DateTime, ByVal tarih2 As DateTime, ByVal sIslem As String, ByVal sBakiye As String, ByVal sSaticiRumuzu As String, ByVal lLimit1 As Decimal, ByVal lLimit2 As Decimal, ByVal nGun1 As Integer, ByVal nGun2 As Integer, ByVal nVadeFarki As Decimal) As DataSet
        Dim kriter As String = "Where (tbFirma.bAktif =1)"
        If ara <> "" Then
            If sec_konum.Text = "Kodu" Then
                kriter += " AND ( tbFirma.sKodu " & sorgu_kriter_string(ara, ara_kriter) & " )"
            ElseIf sec_konum.Text = "Adı" Then
                kriter += " AND ( tbFirma.sAciklama " & sorgu_kriter_string(ara, ara_kriter) & " )"
            ElseIf sec_konum.Text = "İstihbarat" Then
                kriter += " AND (( tbFirmaAciklamasi.sAciklama1 + ' ' + tbFirmaAciklamasi.sAciklama2 + ' ' + tbFirmaAciklamasi.sAciklama3 + ' ' + tbFirmaAciklamasi.sAciklama4 + '  ' + tbFirmaAciklamasi.sAciklama5) " & sorgu_kriter_string(ara, ara_kriter) & " )"
            ElseIf sec_konum.Text = "Adres" Then
                kriter += " AND ( tbFirma.sAdres1 + ' ' + tbFirma.sAdres2 + ' ' + tbFirma.sSemt + ' ' + tbFirma.sIl + ' ' + tbFirma.sUlke + ' ' + tbFirma.sPostaKodu  " & sorgu_kriter_string(ara, ara_kriter) & " )"
            ElseIf sec_konum.Text = "Sınıf1" Then
                kriter += " AND (tbFSinif1.sAciklama " & sorgu_kriter_string(ara, ara_kriter) & " )"
            ElseIf sec_konum.Text = "Sınıf2" Then
                kriter += " AND (tbFSinif2.sAciklama " & sorgu_kriter_string(ara, ara_kriter) & " )"
            ElseIf sec_konum.Text = "Sınıf3" Then
                kriter += " AND (tbFSinif3.sAciklama " & sorgu_kriter_string(ara, ara_kriter) & " )"
            ElseIf sec_konum.Text = "Sınıf4" Then
                kriter += " AND (tbFSinif4.sAciklama " & sorgu_kriter_string(ara, ara_kriter) & " )"
            ElseIf sec_konum.Text = "Sınıf5" Then
                kriter += " AND (tbFSinif5.sAciklama " & sorgu_kriter_string(ara, ara_kriter) & " )"
            ElseIf sec_konum.Text = "Adı+Soyadı" Then
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
        End If
        If sSaticiRumuzu.ToString <> "" And sSaticiRumuzu <> "[Tümü]" Then
            kriter += " AND (tbFirma.sSaticiRumuzu IN (" & sSaticiRumuzu & " ))"
        End If
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
        'kriter += " and (tbFirma.bAktif =1) "
        'kriter += " AND ROUND(CAST(GETDATE() - (CAST(tbFirmaHareketi.dteValorTarihi AS INT) + 1) AS FLOAT), 0) BETWEEN " & nGun1 & " and " & nGun2 & " "
        kriter += " AND tbFirma.dteKayitTarihi between '" & Microsoft.VisualBasic.Left(tarih1.ToString, 10) + " 00:00:00" & "' and '" & Microsoft.VisualBasic.Left(tarih2.ToString, 10) + " 23:59:59" & "' "
        'kriter = "WHERE tbMusteri.dteKayitTarihi between '" & Microsoft.VisualBasic.Left(tarih1.ToString, 10) + " 00:00:00" & "' and '" & Microsoft.VisualBasic.Left(tarih1.ToString, 10) + " 23:59:59" & "' "
        Dim conn As New OleDb.OleDbConnection
        Dim cmd As New OleDb.OleDbCommand
        Dim adapter As New OleDb.OleDbDataAdapter
        conn.ConnectionString = connection
        cmd.CommandTimeout = False
        adapter.SelectCommand = cmd
        If sBakiye = "Borclar" Then
            If sIslem = "Özet" Then
                cmd.CommandText = sorgu_query("SET DATEFORMAT DMY SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT CAST(ROUND(SUM(lTutarVade) / SUM(ISNULL(lKalan, 0)), 0) AS DATETIME) AS dteValorTarihi, nFirmaID, sKodu, sAciklama, nOzelIskontosu, lKrediLimiti, sSemt, sIl, sSaticiRumuzu, sUlke, Adres, sVergiDairesi, sVergiNo, ISTIHBARAT, SINIF1, SINIF2, SINIF3, SINIF4, SINIF5, lBakiye, SenetRisk, CekRisk, [E-Mail], Fax, Gsm, Telefon, Web, Yetkili, SUM(lTutar) AS lTutar, SUM(lKarsilananTutar) AS lKarsilananTutar, SUM(lKalan) AS lKalan,DATEDIFF(day,  CAST(ROUND(SUM(lTutarVade) / SUM(ISNULL(lKalan, 0)), 0) AS DATETIME),GETDATE()) AS nGecikme,sum(lVadeFarki) as lVadeFarki FROM (SELECT * , lTutar - lKarsilananTutar AS lKalan , (lTutar - lKarsilananTutar) * (ROUND(FLOOR(CAST(GETDATE() AS FLOAT)) - CAST(dteValorTarihi AS FLOAT), 0) * " & nVadeFarki & " / 3000) AS lVadeFarki,(lTutar - lKarsilananTutar) * CAST(dteValorTarihi AS INT) AS lTutarVade FROM (SELECT tbFirma.nFirmaID , tbFirma.sKodu , tbFirma.sAciklama , tbFirma.nOzelIskontosu , tbFirma.lKrediLimiti , tbFirma.sSemt , tbFirma.sIl , tbFirma.sSaticiRumuzu , tbFirma.sUlke , tbFirma.sAdres1 + ' ' + tbFirma.sAdres2 + ' ' + tbFirma.sSemt + ' ' + tbFirma.sIl + ' ' + tbFirma.sUlke + ' ' + tbFirma.sPostaKodu AS Adres , tbFirma.sVergiDairesi , tbFirma.sVergiNo , tbFirmaAciklamasi.sAciklama1 + ' ' + tbFirmaAciklamasi.sAciklama2 + ' ' + tbFirmaAciklamasi.sAciklama3 + ' ' + tbFirmaAciklamasi.sAciklama4 + ' ' + tbFirmaAciklamasi.sAciklama5 AS ISTIHBARAT , tbFSinif1.sAciklama AS SINIF1 , tbFSinif2.sAciklama AS SINIF2 , tbFSinif3.sAciklama AS SINIF3 , tbFSinif4.sAciklama AS SINIF4 , tbFSinif5.sAciklama AS SINIF5 , (SELECT ISNULL(SUM(lBorcTutar - lAlacakTutar) , 0) FROM tbFirmaHareketi WHERE nFirmaID = tbFirma.nFirmaID) AS lBakiye , (SELECT ISNULL(SUM(lTutar) , 0) AS SenetRisk FROM tbCekSenet WHERE (sCekSenetTipi = 'as') AND (nSonCekSenetIslem = 1 OR nSonCekSenetIslem = 3 OR nSonCekSenetIslem = 4 OR nSonCekSenetIslem = 5 OR nSonCekSenetIslem = 6) AND nVerenID = tbFirma.nFirmaID) AS SenetRisk , (SELECT ISNULL(SUM(lTutar) , 0) AS SenetRisk FROM tbCekSenet WHERE (sCekSenetTipi = 'ac') AND (nSonCekSenetIslem = 1 OR nSonCekSenetIslem = 3 OR nSonCekSenetIslem = 4 OR nSonCekSenetIslem = 5 OR nSonCekSenetIslem = 6) AND nVerenID = tbFirma.nFirmaID) AS CekRisk , (SELECT TOP 1 sIletisimAdresi FROM tbFirmaIletisimi WHERE nFirmaId = tbFirma.nFirmaID AND sIletisimAraci = 'E-Mail') AS [E-Mail] , (SELECT TOP 1 sIletisimAdresi FROM tbFirmaIletisimi WHERE nFirmaId = tbFirma.nFirmaID AND sIletisimAraci = 'Fax') AS Fax , (SELECT TOP 1 sIletisimAdresi FROM tbFirmaIletisimi WHERE nFirmaId = tbFirma.nFirmaID AND sIletisimAraci = 'Gsm') AS Gsm , (SELECT TOP 1 sIletisimAdresi FROM tbFirmaIletisimi WHERE nFirmaId = tbFirma.nFirmaID AND sIletisimAraci = 'Telefon') AS Telefon , (SELECT TOP 1 sIletisimAdresi FROM tbFirmaIletisimi WHERE nFirmaId = tbFirma.nFirmaID AND sIletisimAraci = 'Web') AS Web , (SELECT TOP 1 sIletisimAdresi FROM tbFirmaIletisimi WHERE nFirmaId = tbFirma.nFirmaID AND sIletisimAraci = 'Yetkili') AS Yetkili , tbFirmaHareketi.dteIslemTarihi , tbFirmaHareketi.dteValorTarihi , tbFirmaHareketi.sCariIslem , tbFirmaHareketi.sAciklama AS Aciklama , tbFirmaHareketi.sEvrakNo AS EvrakNo , tbFirmaHareketi.lAlacakTutar AS lTutar , ISNULL((SELECT SUM(lTutar) FROM tbFirmaKapama WHERE tbFirmaKapama.nOdemeId > 0 AND tbFirmaKapama.nKarsilamaId = tbFirmaHareketi.nHareketId) , 0) AS lKarsilananTutar ,  DATEDIFF(day , tbFirmaHareketi.dteIslemTarihi , tbFirmaHareketi.dteValorTarihi) AS nOpsiyon , ROUND(CAST(GETDATE() - (CAST(tbFirmaHareketi.dteValorTarihi AS INT) + 1) AS FLOAT) , 0) AS nGecikme FROM tbFirmaAciklamasi RIGHT OUTER JOIN tbFirma INNER JOIN tbFirmaHareketi ON tbFirma.nFirmaID = tbFirmaHareketi.nFirmaID ON tbFirmaAciklamasi.nFirmaID = tbFirma.nFirmaID LEFT OUTER JOIN tbFSinif1 INNER JOIN tbFirmaSinifi ON tbFSinif1.sSinifKodu = tbFirmaSinifi.sSinifKodu1 INNER JOIN tbFSinif2 ON tbFirmaSinifi.sSinifKodu2 = tbFSinif2.sSinifKodu INNER JOIN tbFSinif3 ON tbFirmaSinifi.sSinifKodu3 = tbFSinif3.sSinifKodu INNER JOIN tbFSinif4 ON tbFirmaSinifi.sSinifKodu4 = tbFSinif4.sSinifKodu INNER JOIN tbFSinif5 ON tbFirmaSinifi.sSinifKodu5 = tbFSinif5.sSinifKodu ON tbFirma.nFirmaID = tbFirmaSinifi.nFirmaID WHERE (tbFirmaHareketi.lAlacakTutar <> 0) AND tbFirmaHareketi.dteIslemTarihi BETWEEN '" & tarih1 & "' and '" & tarih2 & "' " & kriter & ") tbTemp WHERE (lTutar <> lKarsilananTutar) and lBakiye between " & lLimit1 & " and " & lLimit2 & " ) tbTempVade GROUP BY nFirmaID, sKodu, sAciklama, nOzelIskontosu, lKrediLimiti, sSemt, sIl, sSaticiRumuzu, sUlke, Adres, sVergiDairesi, sVergiNo, ISTIHBARAT, SINIF1, SINIF2, SINIF3, SINIF4, SINIF5, lBakiye, SenetRisk, CekRisk, [E-Mail], Fax, Gsm, Telefon, Web, Yetkili ")
            ElseIf sIslem = "Detaylı" Then
                'cmd.CommandText = sorgu_query("SET DATEFORMAT DMY SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT nFirmaID, sKodu, sAciklama, sUlke, sIl, sSemt, SINIF1, SINIF2, SINIF3, SINIF4, SINIF5, sSaticiRumuzu, lBakiye, CekRisk, SenetRisk, nGecikme, Count(nFirmaID) AS lKalan, YEAR(dteKayitTarihi) AS sYil, MONTH(dteKayitTarihi) AS sAy, { fn WEEK(dteKayitTarihi) } AS sHafta, DAY(dteKayitTarihi) AS sGun, (lTutar - lKarsilananTutar) * (ROUND(FLOOR(CAST(GETDATE() AS FLOAT)) - CAST(dteValorTarihi AS FLOAT), 0) * " & nVadeFarki & " / 3000) AS lVadeFarki FROM (SELECT tbFirma.nFirmaID , tbFirma.sKodu , tbFirma.sAciklama , tbFirma.nOzelIskontosu , tbFirma.lKrediLimiti , tbFirma.sSemt , tbFirma.sIl , tbFirma.sSaticiRumuzu , tbFirma.sUlke , tbFirma.sAdres1 + ' ' + tbFirma.sAdres2 + ' ' + tbFirma.sSemt + ' ' + tbFirma.sIl + ' ' + tbFirma.sUlke + ' ' + tbFirma.sPostaKodu AS Adres , tbFirma.sVergiDairesi , tbFirma.sVergiNo , tbFirmaAciklamasi.sAciklama1 + ' ' + tbFirmaAciklamasi.sAciklama2 + ' ' + tbFirmaAciklamasi.sAciklama3 + ' ' + tbFirmaAciklamasi.sAciklama4 + ' ' + tbFirmaAciklamasi.sAciklama5 AS ISTIHBARAT , tbFSinif1.sAciklama AS SINIF1 , tbFSinif2.sAciklama AS SINIF2 , tbFSinif3.sAciklama AS SINIF3 , tbFSinif4.sAciklama AS SINIF4 , tbFSinif5.sAciklama AS SINIF5 , tbFirma.dteKayitTarihi,(SELECT ISNULL(SUM(lBorcTutar - lAlacakTutar) , 0) FROM tbFirmaHareketi WHERE nFirmaID = tbFirma.nFirmaID ) AS lBakiye , (SELECT ISNULL(SUM(lTutar), 0) AS SenetRisk FROM tbCekSenet WHERE (sCekSenetTipi = 'as') AND (nSonCekSenetIslem = 1 OR nSonCekSenetIslem = 3 OR nSonCekSenetIslem = 4 OR nSonCekSenetIslem = 5 OR nSonCekSenetIslem = 6) AND nVerenID = tbFirma.nFirmaID) AS SenetRisk, (SELECT ISNULL(SUM(lTutar), 0) AS SenetRisk FROM tbCekSenet WHERE (sCekSenetTipi = 'ac') AND (nSonCekSenetIslem = 1 OR nSonCekSenetIslem = 3 OR nSonCekSenetIslem = 4 OR nSonCekSenetIslem = 5 OR nSonCekSenetIslem = 6) AND nVerenID = tbFirma.nFirmaID) AS CekRisk,(SELECT TOP 1 sIletisimAdresi FROM tbFirmaIletisimi WHERE nFirmaId = tbFirma.nFirmaID AND sIletisimAraci = 'E-Mail') AS [E-Mail] , (SELECT TOP 1 sIletisimAdresi FROM tbFirmaIletisimi WHERE nFirmaId = tbFirma.nFirmaID AND sIletisimAraci = 'Fax') AS Fax , (SELECT TOP 1 sIletisimAdresi FROM tbFirmaIletisimi WHERE nFirmaId = tbFirma.nFirmaID AND sIletisimAraci = 'Gsm') AS Gsm , (SELECT TOP 1 sIletisimAdresi FROM tbFirmaIletisimi WHERE nFirmaId = tbFirma.nFirmaID AND sIletisimAraci = 'Telefon') AS Telefon , (SELECT TOP 1 sIletisimAdresi FROM tbFirmaIletisimi WHERE nFirmaId = tbFirma.nFirmaID AND sIletisimAraci = 'Web') AS Web , (SELECT TOP 1 sIletisimAdresi FROM tbFirmaIletisimi WHERE nFirmaId = tbFirma.nFirmaID AND sIletisimAraci = 'Yetkili') AS Yetkili , tbFirmaHareketi.dteIslemTarihi , tbFirmaHareketi.dteValorTarihi , tbFirmaHareketi.sCariIslem , tbFirmaHareketi.sAciklama AS Aciklama , tbFirmaHareketi.sEvrakNo AS EvrakNo , tbFirmaHareketi.lAlacakTutar AS lTutar , ISNULL((SELECT SUM(lTutar) FROM tbFirmaKapama WHERE tbFirmaKapama.nOdemeId > 0 AND tbFirmaKapama.nKarsilamaId = tbFirmaHareketi.nHareketId) , 0) AS lKarsilananTutar ,   DATEDIFF(day, tbFirmaHareketi.dteIslemTarihi, tbFirmaHareketi.dteValorTarihi) as nOpsiyon , ROUND(CAST(GETDATE() - (CAST(tbFirmaHareketi.dteValorTarihi AS INT) + 1) AS FLOAT), 0) AS nGecikme FROM tbFirmaAciklamasi RIGHT OUTER JOIN tbFirma INNER JOIN tbFirmaHareketi ON tbFirma.nFirmaID = tbFirmaHareketi.nFirmaID ON tbFirmaAciklamasi.nFirmaID = tbFirma.nFirmaID LEFT OUTER JOIN tbFSinif1 INNER JOIN tbFirmaSinifi ON tbFSinif1.sSinifKodu = tbFirmaSinifi.sSinifKodu1 INNER JOIN tbFSinif2 ON tbFirmaSinifi.sSinifKodu2 = tbFSinif2.sSinifKodu INNER JOIN tbFSinif3 ON tbFirmaSinifi.sSinifKodu3 = tbFSinif3.sSinifKodu INNER JOIN tbFSinif4 ON tbFirmaSinifi.sSinifKodu4 = tbFSinif4.sSinifKodu INNER JOIN tbFSinif5 ON tbFirmaSinifi.sSinifKodu5 = tbFSinif5.sSinifKodu ON tbFirma.nFirmaID = tbFirmaSinifi.nFirmaID WHERE (tbFirmaHareketi.lAlacakTutar <> 0) and tbFirmaHareketi.dteIslemTarihi between '" & tarih1 & "' and '" & tarih2 & "' " & kriter & " ) tbTemp WHERE (lTutar <> lKarsilananTutar) and lBakiye between " & lLimit1 & " and " & lLimit2 & " ORDER BY sKodu, dteIslemTarihi ")
                cmd.CommandText = sorgu_query("SET DATEFORMAT DMY SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT nFirmaID, sKodu, sAciklama, sUlke, sIl, sSemt, SINIF1, SINIF2, SINIF3, SINIF4, SINIF5, sSaticiRumuzu, lBakiye, CekRisk, SenetRisk, 1 AS lKalan, YEAR(dteKayitTarihi) AS sYil, MONTH(dteKayitTarihi) AS sAy, { fn WEEK(dteKayitTarihi) } AS sHafta, DAY(dteKayitTarihi) AS sGun FROM (SELECT tbFirma.nFirmaID , tbFirma.sKodu , tbFirma.sAciklama , tbFirma.nOzelIskontosu , tbFirma.lKrediLimiti , tbFirma.sSemt , tbFirma.sIl , tbFirma.sSaticiRumuzu , tbFirma.sUlke , tbFirma.sAdres1 + ' ' + tbFirma.sAdres2 + ' ' + tbFirma.sSemt + ' ' + tbFirma.sIl + ' ' + tbFirma.sUlke + ' ' + tbFirma.sPostaKodu AS Adres , tbFirma.sVergiDairesi , tbFirma.sVergiNo , tbFirmaAciklamasi.sAciklama1 + ' ' + tbFirmaAciklamasi.sAciklama2 + ' ' + tbFirmaAciklamasi.sAciklama3 + ' ' + tbFirmaAciklamasi.sAciklama4 + ' ' + tbFirmaAciklamasi.sAciklama5 AS ISTIHBARAT , tbFSinif1.sAciklama AS SINIF1 , tbFSinif2.sAciklama AS SINIF2 , tbFSinif3.sAciklama AS SINIF3 , tbFSinif4.sAciklama AS SINIF4 , tbFSinif5.sAciklama AS SINIF5 ,tbFirma.dteKayitTarihi, (SELECT ISNULL(SUM(lBorcTutar - lAlacakTutar) , 0) FROM tbFirmaHareketi WHERE nFirmaID = tbFirma.nFirmaID ) AS lBakiye , (SELECT ISNULL(SUM(lTutar), 0) AS SenetRisk FROM tbCekSenet WHERE (sCekSenetTipi = 'as') AND (nSonCekSenetIslem = 1 OR nSonCekSenetIslem = 3 OR nSonCekSenetIslem = 4 OR nSonCekSenetIslem = 5 OR nSonCekSenetIslem = 6) AND nVerenID = tbFirma.nFirmaID) AS SenetRisk, (SELECT ISNULL(SUM(lTutar), 0) AS SenetRisk FROM tbCekSenet WHERE (sCekSenetTipi = 'ac') AND (nSonCekSenetIslem = 1 OR nSonCekSenetIslem = 3 OR nSonCekSenetIslem = 4 OR nSonCekSenetIslem = 5 OR nSonCekSenetIslem = 6) AND nVerenID = tbFirma.nFirmaID) AS CekRisk,(SELECT TOP 1 sIletisimAdresi FROM tbFirmaIletisimi WHERE nFirmaId = tbFirma.nFirmaID AND sIletisimAraci = 'E-Mail') AS [E-Mail] , (SELECT TOP 1 sIletisimAdresi FROM tbFirmaIletisimi WHERE nFirmaId = tbFirma.nFirmaID AND sIletisimAraci = 'Fax') AS Fax , (SELECT TOP 1 sIletisimAdresi FROM tbFirmaIletisimi WHERE nFirmaId = tbFirma.nFirmaID AND sIletisimAraci = 'Gsm') AS Gsm , (SELECT TOP 1 sIletisimAdresi FROM tbFirmaIletisimi WHERE nFirmaId = tbFirma.nFirmaID AND sIletisimAraci = 'Telefon') AS Telefon , (SELECT TOP 1 sIletisimAdresi FROM tbFirmaIletisimi WHERE nFirmaId = tbFirma.nFirmaID AND sIletisimAraci = 'Web') AS Web , (SELECT TOP 1 sIletisimAdresi FROM tbFirmaIletisimi WHERE nFirmaId = tbFirma.nFirmaID AND sIletisimAraci = 'Yetkili') AS Yetkili FROM tbFirmaAciklamasi RIGHT OUTER JOIN tbFirma ON  tbFirmaAciklamasi.nFirmaID = tbFirma.nFirmaID LEFT OUTER JOIN tbFSinif1 INNER JOIN tbFirmaSinifi ON tbFSinif1.sSinifKodu = tbFirmaSinifi.sSinifKodu1 INNER JOIN tbFSinif2 ON tbFirmaSinifi.sSinifKodu2 = tbFSinif2.sSinifKodu INNER JOIN tbFSinif3 ON tbFirmaSinifi.sSinifKodu3 = tbFSinif3.sSinifKodu INNER JOIN tbFSinif4 ON tbFirmaSinifi.sSinifKodu4 = tbFSinif4.sSinifKodu INNER JOIN tbFSinif5 ON tbFirmaSinifi.sSinifKodu5 = tbFSinif5.sSinifKodu ON tbFirma.nFirmaID = tbFirmaSinifi.nFirmaID  " & kriter & " ) tbTemp WHERE lBakiye between " & lLimit1 & " and " & lLimit2 & " ORDER BY sKodu ")
            End If
        ElseIf sBakiye = "Alacaklar" Then
            If sIslem = "Özet" Then
                cmd.CommandText = sorgu_query("SET DATEFORMAT DMY SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT CAST(ROUND(SUM(lTutarVade) / SUM(ISNULL(lKalan, 0)), 0) AS DATETIME) AS dteValorTarihi, nFirmaID, sKodu, sAciklama, nOzelIskontosu, lKrediLimiti, sSemt, sIl, sSaticiRumuzu, sUlke, Adres, sVergiDairesi, sVergiNo, ISTIHBARAT, SINIF1, SINIF2, SINIF3, SINIF4, SINIF5, lBakiye, SenetRisk, CekRisk, [E-Mail], Fax, Gsm, Telefon, Web, Yetkili, SUM(lTutar) AS lTutar, SUM(lKarsilananTutar) AS lKarsilananTutar, SUM(lKalan) AS lKalan,DATEDIFF(day, CAST(ROUND(SUM(lTutarVade) / SUM(ISNULL(lKalan, 0)), 0) AS DATETIME),GETDATE()) AS nGecikme,sum(lVadeFarki) as lVadeFarki FROM (SELECT * , lTutar - lKarsilananTutar AS lKalan , (lTutar - lKarsilananTutar) * (ROUND(FLOOR(CAST(GETDATE() AS FLOAT)) - CAST(dteValorTarihi AS FLOAT), 0) * " & nVadeFarki & " / 3000) AS lVadeFarki,(lTutar - lKarsilananTutar) * CAST(dteValorTarihi AS INT) AS lTutarVade FROM (SELECT tbFirma.nFirmaID , tbFirma.sKodu , tbFirma.sAciklama , tbFirma.nOzelIskontosu , tbFirma.lKrediLimiti , tbFirma.sSemt , tbFirma.sIl , tbFirma.sSaticiRumuzu , tbFirma.sUlke , tbFirma.sAdres1 + ' ' + tbFirma.sAdres2 + ' ' + tbFirma.sSemt + ' ' + tbFirma.sIl + ' ' + tbFirma.sUlke + ' ' + tbFirma.sPostaKodu AS Adres , tbFirma.sVergiDairesi , tbFirma.sVergiNo , tbFirmaAciklamasi.sAciklama1 + ' ' + tbFirmaAciklamasi.sAciklama2 + ' ' + tbFirmaAciklamasi.sAciklama3 + ' ' + tbFirmaAciklamasi.sAciklama4 + ' ' + tbFirmaAciklamasi.sAciklama5 AS ISTIHBARAT , tbFSinif1.sAciklama AS SINIF1 , tbFSinif2.sAciklama AS SINIF2 , tbFSinif3.sAciklama AS SINIF3 , tbFSinif4.sAciklama AS SINIF4 , tbFSinif5.sAciklama AS SINIF5 , (SELECT ISNULL(SUM(lBorcTutar - lAlacakTutar) , 0) FROM tbFirmaHareketi WHERE nFirmaID = tbFirma.nFirmaID) AS lBakiye , (SELECT ISNULL(SUM(lTutar) , 0) AS SenetRisk FROM tbCekSenet WHERE (sCekSenetTipi = 'as') AND (nSonCekSenetIslem = 1 OR nSonCekSenetIslem = 3 OR nSonCekSenetIslem = 4 OR nSonCekSenetIslem = 5 OR nSonCekSenetIslem = 6) AND nVerenID = tbFirma.nFirmaID) AS SenetRisk , (SELECT ISNULL(SUM(lTutar) , 0) AS SenetRisk FROM tbCekSenet WHERE (sCekSenetTipi = 'ac') AND (nSonCekSenetIslem = 1 OR nSonCekSenetIslem = 3 OR nSonCekSenetIslem = 4 OR nSonCekSenetIslem = 5 OR nSonCekSenetIslem = 6) AND nVerenID = tbFirma.nFirmaID) AS CekRisk , (SELECT TOP 1 sIletisimAdresi FROM tbFirmaIletisimi WHERE nFirmaId = tbFirma.nFirmaID AND sIletisimAraci = 'E-Mail') AS [E-Mail] , (SELECT TOP 1 sIletisimAdresi FROM tbFirmaIletisimi WHERE nFirmaId = tbFirma.nFirmaID AND sIletisimAraci = 'Fax') AS Fax , (SELECT TOP 1 sIletisimAdresi FROM tbFirmaIletisimi WHERE nFirmaId = tbFirma.nFirmaID AND sIletisimAraci = 'Gsm') AS Gsm , (SELECT TOP 1 sIletisimAdresi FROM tbFirmaIletisimi WHERE nFirmaId = tbFirma.nFirmaID AND sIletisimAraci = 'Telefon') AS Telefon , (SELECT TOP 1 sIletisimAdresi FROM tbFirmaIletisimi WHERE nFirmaId = tbFirma.nFirmaID AND sIletisimAraci = 'Web') AS Web , (SELECT TOP 1 sIletisimAdresi FROM tbFirmaIletisimi WHERE nFirmaId = tbFirma.nFirmaID AND sIletisimAraci = 'Yetkili') AS Yetkili , tbFirmaHareketi.dteIslemTarihi , tbFirmaHareketi.dteValorTarihi , tbFirmaHareketi.sCariIslem , tbFirmaHareketi.sAciklama AS Aciklama , tbFirmaHareketi.sEvrakNo AS EvrakNo , tbFirmaHareketi.lBorcTutar AS lTutar , ISNULL((SELECT SUM(lTutar) FROM tbFirmaKapama WHERE tbFirmaKapama.nOdemeId > 0 AND tbFirmaKapama.nKarsilamaId = tbFirmaHareketi.nHareketId) , 0) AS lKarsilananTutar ,  DATEDIFF(day , tbFirmaHareketi.dteIslemTarihi , tbFirmaHareketi.dteValorTarihi) AS nOpsiyon , ROUND(CAST(GETDATE() - (CAST(tbFirmaHareketi.dteValorTarihi AS INT) + 1) AS FLOAT) , 0) AS nGecikme FROM tbFirmaAciklamasi RIGHT OUTER JOIN tbFirma INNER JOIN tbFirmaHareketi ON tbFirma.nFirmaID = tbFirmaHareketi.nFirmaID ON tbFirmaAciklamasi.nFirmaID = tbFirma.nFirmaID LEFT OUTER JOIN tbFSinif1 INNER JOIN tbFirmaSinifi ON tbFSinif1.sSinifKodu = tbFirmaSinifi.sSinifKodu1 INNER JOIN tbFSinif2 ON tbFirmaSinifi.sSinifKodu2 = tbFSinif2.sSinifKodu INNER JOIN tbFSinif3 ON tbFirmaSinifi.sSinifKodu3 = tbFSinif3.sSinifKodu INNER JOIN tbFSinif4 ON tbFirmaSinifi.sSinifKodu4 = tbFSinif4.sSinifKodu INNER JOIN tbFSinif5 ON tbFirmaSinifi.sSinifKodu5 = tbFSinif5.sSinifKodu ON tbFirma.nFirmaID = tbFirmaSinifi.nFirmaID WHERE (tbFirmaHareketi.lBorcTutar <> 0) AND tbFirmaHareketi.dteIslemTarihi BETWEEN '" & tarih1 & "' and '" & tarih2 & "' " & kriter & ") tbTemp WHERE (lTutar <> lKarsilananTutar) and lBakiye between " & lLimit1 & " and " & lLimit2 & ") tbTempVade GROUP BY nFirmaID, sKodu, sAciklama, nOzelIskontosu, lKrediLimiti, sSemt, sIl, sSaticiRumuzu, sUlke, Adres, sVergiDairesi, sVergiNo, ISTIHBARAT, SINIF1, SINIF2, SINIF3, SINIF4, SINIF5, lBakiye, SenetRisk, CekRisk, [E-Mail], Fax, Gsm, Telefon, Web, Yetkili ")
            ElseIf sIslem = "Detaylı" Then
                cmd.CommandText = sorgu_query("SET DATEFORMAT DMY SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT nFirmaID, sKodu, sAciklama, sUlke, sIl, sSemt, SINIF1, SINIF2, SINIF3, SINIF4, SINIF5, sSaticiRumuzu, lBakiye, CekRisk, SenetRisk, 1 AS lKalan, YEAR(dteKayitTarihi) AS sYil, MONTH(dteKayitTarihi) AS sAy, { fn WEEK(dteKayitTarihi) } AS sHafta, DAY(dteKayitTarihi) AS sGun FROM (SELECT tbFirma.nFirmaID , tbFirma.sKodu , tbFirma.sAciklama , tbFirma.nOzelIskontosu , tbFirma.lKrediLimiti , tbFirma.sSemt , tbFirma.sIl , tbFirma.sSaticiRumuzu , tbFirma.sUlke , tbFirma.sAdres1 + ' ' + tbFirma.sAdres2 + ' ' + tbFirma.sSemt + ' ' + tbFirma.sIl + ' ' + tbFirma.sUlke + ' ' + tbFirma.sPostaKodu AS Adres , tbFirma.sVergiDairesi , tbFirma.sVergiNo , tbFirmaAciklamasi.sAciklama1 + ' ' + tbFirmaAciklamasi.sAciklama2 + ' ' + tbFirmaAciklamasi.sAciklama3 + ' ' + tbFirmaAciklamasi.sAciklama4 + ' ' + tbFirmaAciklamasi.sAciklama5 AS ISTIHBARAT , tbFSinif1.sAciklama AS SINIF1 , tbFSinif2.sAciklama AS SINIF2 , tbFSinif3.sAciklama AS SINIF3 , tbFSinif4.sAciklama AS SINIF4 , tbFSinif5.sAciklama AS SINIF5 ,tbFirma.dteKayitTarihi, (SELECT ISNULL(SUM(lBorcTutar - lAlacakTutar) , 0) FROM tbFirmaHareketi WHERE nFirmaID = tbFirma.nFirmaID ) AS lBakiye , (SELECT ISNULL(SUM(lTutar), 0) AS SenetRisk FROM tbCekSenet WHERE (sCekSenetTipi = 'as') AND (nSonCekSenetIslem = 1 OR nSonCekSenetIslem = 3 OR nSonCekSenetIslem = 4 OR nSonCekSenetIslem = 5 OR nSonCekSenetIslem = 6) AND nVerenID = tbFirma.nFirmaID) AS SenetRisk, (SELECT ISNULL(SUM(lTutar), 0) AS SenetRisk FROM tbCekSenet WHERE (sCekSenetTipi = 'ac') AND (nSonCekSenetIslem = 1 OR nSonCekSenetIslem = 3 OR nSonCekSenetIslem = 4 OR nSonCekSenetIslem = 5 OR nSonCekSenetIslem = 6) AND nVerenID = tbFirma.nFirmaID) AS CekRisk,(SELECT TOP 1 sIletisimAdresi FROM tbFirmaIletisimi WHERE nFirmaId = tbFirma.nFirmaID AND sIletisimAraci = 'E-Mail') AS [E-Mail] , (SELECT TOP 1 sIletisimAdresi FROM tbFirmaIletisimi WHERE nFirmaId = tbFirma.nFirmaID AND sIletisimAraci = 'Fax') AS Fax , (SELECT TOP 1 sIletisimAdresi FROM tbFirmaIletisimi WHERE nFirmaId = tbFirma.nFirmaID AND sIletisimAraci = 'Gsm') AS Gsm , (SELECT TOP 1 sIletisimAdresi FROM tbFirmaIletisimi WHERE nFirmaId = tbFirma.nFirmaID AND sIletisimAraci = 'Telefon') AS Telefon , (SELECT TOP 1 sIletisimAdresi FROM tbFirmaIletisimi WHERE nFirmaId = tbFirma.nFirmaID AND sIletisimAraci = 'Web') AS Web , (SELECT TOP 1 sIletisimAdresi FROM tbFirmaIletisimi WHERE nFirmaId = tbFirma.nFirmaID AND sIletisimAraci = 'Yetkili') AS Yetkili FROM tbFirmaAciklamasi RIGHT OUTER JOIN tbFirma ON  tbFirmaAciklamasi.nFirmaID = tbFirma.nFirmaID LEFT OUTER JOIN tbFSinif1 INNER JOIN tbFirmaSinifi ON tbFSinif1.sSinifKodu = tbFirmaSinifi.sSinifKodu1 INNER JOIN tbFSinif2 ON tbFirmaSinifi.sSinifKodu2 = tbFSinif2.sSinifKodu INNER JOIN tbFSinif3 ON tbFirmaSinifi.sSinifKodu3 = tbFSinif3.sSinifKodu INNER JOIN tbFSinif4 ON tbFirmaSinifi.sSinifKodu4 = tbFSinif4.sSinifKodu INNER JOIN tbFSinif5 ON tbFirmaSinifi.sSinifKodu5 = tbFSinif5.sSinifKodu ON tbFirma.nFirmaID = tbFirmaSinifi.nFirmaID  " & kriter & " ) tbTemp WHERE lBakiye between " & lLimit1 & " and " & lLimit2 & " ORDER BY sKodu ")
            End If
        End If
        'cmd.CommandText = sorgu_query("SET DATEFORMAT DMY SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT nFirmaID, sKodu, sAciklama, sUlke, sIl, sSemt, SINIF1, SINIF2, SINIF3, SINIF4, SINIF5, sSaticiRumuzu, lBakiye, CekRisk, SenetRisk, nGecikme, lTutar - lKarsilananTutar AS lKalan, YEAR(dteValorTarihi) AS sYil, MONTH(dteValorTarihi) AS sAy, { fn WEEK(dteValorTarihi) } AS sHafta, DAY(dteValorTarihi) AS sGun, (lTutar - lKarsilananTutar) * (ROUND(FLOOR(CAST(GETDATE() AS FLOAT)) - CAST(dteValorTarihi AS FLOAT), 0) * " & nVadeFarki & " / 3000) AS lVadeFarki FROM (SELECT tbFirma.nFirmaID , tbFirma.sKodu , tbFirma.sAciklama , tbFirma.nOzelIskontosu , tbFirma.lKrediLimiti , tbFirma.sSemt , tbFirma.sIl , tbFirma.sSaticiRumuzu , tbFirma.sUlke , tbFirma.sAdres1 + ' ' + tbFirma.sAdres2 + ' ' + tbFirma.sSemt + ' ' + tbFirma.sIl + ' ' + tbFirma.sUlke + ' ' + tbFirma.sPostaKodu AS Adres , tbFirma.sVergiDairesi , tbFirma.sVergiNo , tbFirmaAciklamasi.sAciklama1 + ' ' + tbFirmaAciklamasi.sAciklama2 + ' ' + tbFirmaAciklamasi.sAciklama3 + ' ' + tbFirmaAciklamasi.sAciklama4 + ' ' + tbFirmaAciklamasi.sAciklama5 AS ISTIHBARAT , tbFSinif1.sAciklama AS SINIF1 , tbFSinif2.sAciklama AS SINIF2 , tbFSinif3.sAciklama AS SINIF3 , tbFSinif4.sAciklama AS SINIF4 , tbFSinif5.sAciklama AS SINIF5 , (SELECT ISNULL(SUM(lBorcTutar - lAlacakTutar) , 0) FROM tbFirmaHareketi WHERE nFirmaID = tbFirma.nFirmaID ) AS lBakiye , (SELECT ISNULL(SUM(lTutar), 0) AS SenetRisk FROM tbCekSenet WHERE (sCekSenetTipi = 'as') AND (nSonCekSenetIslem = 1 OR nSonCekSenetIslem = 3 OR nSonCekSenetIslem = 4 OR nSonCekSenetIslem = 5 OR nSonCekSenetIslem = 6) AND nVerenID = tbFirma.nFirmaID) AS SenetRisk, (SELECT ISNULL(SUM(lTutar), 0) AS SenetRisk FROM tbCekSenet WHERE (sCekSenetTipi = 'ac') AND (nSonCekSenetIslem = 1 OR nSonCekSenetIslem = 3 OR nSonCekSenetIslem = 4 OR nSonCekSenetIslem = 5 OR nSonCekSenetIslem = 6) AND nVerenID = tbFirma.nFirmaID) AS CekRisk,(SELECT TOP 1 sIletisimAdresi FROM tbFirmaIletisimi WHERE nFirmaId = tbFirma.nFirmaID AND sIletisimAraci = 'E-Mail') AS [E-Mail] , (SELECT TOP 1 sIletisimAdresi FROM tbFirmaIletisimi WHERE nFirmaId = tbFirma.nFirmaID AND sIletisimAraci = 'Fax') AS Fax , (SELECT TOP 1 sIletisimAdresi FROM tbFirmaIletisimi WHERE nFirmaId = tbFirma.nFirmaID AND sIletisimAraci = 'Gsm') AS Gsm , (SELECT TOP 1 sIletisimAdresi FROM tbFirmaIletisimi WHERE nFirmaId = tbFirma.nFirmaID AND sIletisimAraci = 'Telefon') AS Telefon , (SELECT TOP 1 sIletisimAdresi FROM tbFirmaIletisimi WHERE nFirmaId = tbFirma.nFirmaID AND sIletisimAraci = 'Web') AS Web , (SELECT TOP 1 sIletisimAdresi FROM tbFirmaIletisimi WHERE nFirmaId = tbFirma.nFirmaID AND sIletisimAraci = 'Yetkili') AS Yetkili , tbFirmaHareketi.dteIslemTarihi , tbFirmaHareketi.dteValorTarihi , tbFirmaHareketi.sCariIslem , tbFirmaHareketi.sAciklama AS Aciklama , tbFirmaHareketi.sEvrakNo AS EvrakNo , tbFirmaHareketi.lBorcTutar AS lTutar , ISNULL((SELECT SUM(lTutar) FROM tbFirmaKapama WHERE tbFirmaKapama.nOdemeId > 0 AND tbFirmaKapama.nKarsilamaId = tbFirmaHareketi.nHareketId) , 0) AS lKarsilananTutar ,   DATEDIFF(day, tbFirmaHareketi.dteIslemTarihi, tbFirmaHareketi.dteValorTarihi) as nOpsiyon , ROUND(CAST(GETDATE() - (CAST(tbFirmaHareketi.dteValorTarihi AS INT) + 1) AS FLOAT), 0) AS nGecikme FROM tbFirmaAciklamasi RIGHT OUTER JOIN tbFirma INNER JOIN tbFirmaHareketi ON tbFirma.nFirmaID = tbFirmaHareketi.nFirmaID ON tbFirmaAciklamasi.nFirmaID = tbFirma.nFirmaID LEFT OUTER JOIN tbFSinif1 INNER JOIN tbFirmaSinifi ON tbFSinif1.sSinifKodu = tbFirmaSinifi.sSinifKodu1 INNER JOIN tbFSinif2 ON tbFirmaSinifi.sSinifKodu2 = tbFSinif2.sSinifKodu INNER JOIN tbFSinif3 ON tbFirmaSinifi.sSinifKodu3 = tbFSinif3.sSinifKodu INNER JOIN tbFSinif4 ON tbFirmaSinifi.sSinifKodu4 = tbFSinif4.sSinifKodu INNER JOIN tbFSinif5 ON tbFirmaSinifi.sSinifKodu5 = tbFSinif5.sSinifKodu ON tbFirma.nFirmaID = tbFirmaSinifi.nFirmaID WHERE (tbFirmaHareketi.lBorcTutar <> 0) and tbFirmaHareketi.dteIslemTarihi between '" & tarih1 & "' and '" & tarih2 & "' " & kriter & " ) tbTemp WHERE (lTutar <> lKarsilananTutar) and lBakiye between " & lLimit1 & " and " & lLimit2 & " ORDER BY sKodu, dteIslemTarihi ")
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
    Private Sub dataload(ByVal ara As String, ByVal konum As String, ByVal ara_kriter As String, ByVal tarih1 As DateTime, ByVal tarih2 As DateTime, ByVal sIslem As String, ByVal sBakiye As String, ByVal sSaticiRumuzu As String, ByVal lLimit1 As Decimal, ByVal lLimit2 As Decimal, ByVal nGun1 As Int64, ByVal nGun2 As Int64, ByVal nVadeFarki As Decimal)
        DataSet1 = stok(ara, konum, ara_kriter, tarih1, tarih2, sIslem, sBakiye, sSaticiRumuzu, lLimit1, lLimit2, nGun1, nGun2, nVadeFarki)
        GridControl1.DataSource = DataSet1.Tables(0)
        GridControl1.DataMember = Nothing
        PanelControl3.Select()
        GridControl1.Focus()
        GridControl1.Select()
        If sModul = "Banka" Then
            fieldsKodu.Caption = Sorgu_sDil("Banka Kodu", sDil)
            fieldsAciklama.Caption = Sorgu_sDil("Banka Adı", sDil)
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
    Private Sub MenuItem3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem3.Click
        gorunum_kaydet()
    End Sub
    Private Sub MenuItem16_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
    End Sub
    Private Sub GridControl1_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs)
        If e.KeyCode = Keys.Escape Then
            'If XtraMessageBox.Show(Sorgu_sDil("Açık Faturalar Kontrol Ekranından Çıkmak İstediğinize Emin misiniz...?",sDil), MessageBoxButtons.YesNo, MessageBoxIcon.Question,sorgu_sDil("Dikkat",sDil)) = MsgBoxResult.Yes Then
            Me.Close()
            'End If
        End If
    End Sub
    Private Sub SimpleButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SimpleButton1.Click
        If islemstatus = True Then
            Me.Close()
        Else
            Me.Close()
        End If
    End Sub
    Private Sub SimpleButton6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        ara()
    End Sub
    Private Sub SimpleButton3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SimpleButton3.Click
        ara()
    End Sub
    Private Sub ara()
        Label2.Text = Sorgu_sDil("Lütfen Bekleyiniz...", sDil)
        Label2.Refresh()
        Cursor.Current = Cursors.WaitCursor
        Cursor.Show()
        dataload(txt_ara.EditValue, sec_konum.Text, sec_kriter.Text, DateEdit1.EditValue, DateEdit2.EditValue, sec_islem.Text, sec_bakiye.Text, sec_sSatici.Text, txt_limit1.EditValue, txt_limit2.EditValue, txt_nGun1.EditValue, txt_nGun2.EditValue, txt_nVadeFarki.EditValue)
        Label2.Text = Sorgu_sDil("Tamamlandı...", sDil)
        Cursor.Current = Cursors.Default
        Cursor.Hide()
    End Sub
    Private Sub sec_depo_QueryPopUp(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles sec_sSatici.QueryPopUp
        sec_sSatici.Properties.PopupControl = sec_grid
        GridControl2.DataSource = ds_tbSatici.Tables(0)
        GridControl2.DataMember = Nothing
    End Sub
    Private Sub sec_depo_QueryResultValue(ByVal sender As Object, ByVal e As DevExpress.XtraEditors.Controls.QueryResultValueEventArgs) Handles sec_sSatici.QueryResultValue
        Dim s As String = deger(ds_tbSatici)
        If s.ToString <> "" Then
            e.Value = s.ToString
        Else
            e.Value = "[Tümü]"
        End If
    End Sub
    Private Sub GridControl1_KeyDown1(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles GridControl1.KeyDown
        If e.KeyCode = Keys.Escape Then
            Me.Close()
        End If
    End Sub
    Private Sub sec_sdepo_QueryPopUp(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles sec_sdepo.QueryPopUp
        sec_sdepo.Properties.PopupControl = sec_grid
        GridControl2.DataSource = ds_tbDepo.Tables(0)
        GridControl2.DataMember = Nothing
    End Sub
    Private Sub sec_sdepo_QueryResultValue(ByVal sender As Object, ByVal e As DevExpress.XtraEditors.Controls.QueryResultValueEventArgs) Handles sec_sdepo.QueryResultValue
        Dim s As String = deger(ds_tbDepo)
        If s.ToString <> "" Then
            e.Value = s.ToString
        Else
            e.Value = "[Tümü]"
        End If
    End Sub
End Class