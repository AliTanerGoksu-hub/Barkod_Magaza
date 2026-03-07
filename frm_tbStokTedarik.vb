Imports Microsoft.Win32
Imports DevExpress.XtraEditors
Imports DevExpress.XtraGrid
Imports DevExpress.XtraGrid.Columns
Public Class frm_tbStokTedarik
    Public firmano
    Public donemno
    Public kullanici
    Public connection
    Public nFirmaID = 0
    Public sFirmaKodu As String
    Public sFirmaAciklama As String
    Dim cmd As New OleDb.OleDbCommand
    Dim con As New OleDb.OleDbConnection
    Dim dr As DataRow
    Dim ds_tbStokTedarikcisi As DataSet
    Public bIhtiyac As Boolean = False
    Private Sub frm_tbStokTedarik_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        txt_musteriNo.Focus()
        txt_musteriNo.SelectAll()
        txt_ara.EditValue = ""
        Try
            gorunum_yukle()
        Catch ex As Exception
        End Try
        If nFirmaID > 0 Then
            ara()
        End If
    End Sub
    Private Sub ara()
        If bIhtiyac = True Then
            Label2.Text = Sorgu_sDil(Sorgu_sDil("Lütfen Bekleyiniz...", sDil), sDil)
            Label2.Refresh()
            dataload_tbStokTedarikcisi(nFirmaID, txt_ara.EditValue.ToString, sec_konum.Text, sec_kriter.Text)
            GridControl1.Focus()
            GridControl1.Select()
            Label2.Text = Sorgu_sDil("Tamamlandý...", sDil)
        Else
            If nFirmaID > 0 Then
                Label2.Text = Sorgu_sDil("Lütfen Bekleyiniz...", sDil)
                Label2.Refresh()
                dataload_tbStokTedarikcisi(nFirmaID, txt_ara.EditValue.ToString, sec_konum.Text, sec_kriter.Text)
                GridControl1.Focus()
                GridControl1.Select()
                Label2.Text = Sorgu_sDil("Tamamlandý...", sDil)
            End If
        End If
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
        SimpleButton3.Text = Sorgu_sDil(SimpleButton3.Text, sDil)
        GridView1.RestoreLayoutFromRegistry("SOFTWARE\BusinessSmart\VIEW\MAGAZA\" & Me.Name.ToString & "")
    End Sub
    Private Sub dataload_tbStokTedarikcisi(ByVal nFirmaID As String, ByVal ara As String, ByVal konum As String, ByVal ara_kriter As String)
        Dim kriter = " WHERE (tbStok.sKodu <> '') "
        Dim kriter_depo_siparis As String = ""
        If Trim(ara).ToString <> "" Then
            If konum = "Kod" Then
                kriter += " AND( tbStok.sKodu " & sorgu_kriter_string(ara, ara_kriter) & " )"
            ElseIf konum = "Ad" Then
                kriter += " AND ( tbStok.sAciklama " & sorgu_kriter_string(ara, ara_kriter) & " )"
            ElseIf konum = "Barkod" Then
                kriter += " AND ( tbStokBarkodu.sBarkod " & sorgu_kriter_string(ara, ara_kriter) & " )"
            ElseIf konum = "Sýnýf1" Then
                kriter += " AND ( tbSSinif1.sAciklama " & sorgu_kriter_string(ara, ara_kriter) & " )"
            ElseIf konum = "Sýnýf2" Then
                kriter += " AND ( tbSSinif2.sAciklama " & sorgu_kriter_string(ara, ara_kriter) & " )"
            ElseIf konum = "Sýnýf3" Then
                kriter += " AND ( tbSSinif3.sAciklama " & sorgu_kriter_string(ara, ara_kriter) & " )"
            ElseIf konum = "Sýnýf4" Then
                kriter += " AND ( tbSSinif4.sAciklama " & sorgu_kriter_string(ara, ara_kriter) & " )"
            ElseIf konum = "Sýnýf5" Then
                kriter += " AND ( tbSSinif5.sAciklama " & sorgu_kriter_string(ara, ara_kriter) & " )"
            ElseIf konum = "Sýnýf6" Then
                kriter += " AND ( tbSSinif6.sAciklama " & sorgu_kriter_string(ara, ara_kriter) & " )"
            ElseIf konum = "Sýnýf7" Then
                kriter += " AND ( tbSSinif7.sAciklama " & sorgu_kriter_string(ara, ara_kriter) & " )"
            ElseIf konum = "Sýnýf8" Then
                kriter += " AND ( tbSSinif8.sAciklama " & sorgu_kriter_string(ara, ara_kriter) & " )"
            ElseIf konum = "Sýnýf9" Then
                kriter += " AND ( tbSSinif9.sAciklama " & sorgu_kriter_string(ara, ara_kriter) & " )"
            ElseIf konum = "Sýnýf10" Then
                kriter += " AND ( tbSSinif10.sAciklama " & sorgu_kriter_string(ara, ara_kriter) & " )"
            ElseIf konum = "Sýnýf11" Then
                kriter += " AND ( tbSSinif11.sAciklama " & sorgu_kriter_string(ara, ara_kriter) & " )"
            ElseIf konum = "Sýnýf12" Then
                kriter += " AND ( tbSSinif12.sAciklama " & sorgu_kriter_string(ara, ara_kriter) & " )"
            ElseIf konum = "Sýnýf13" Then
                kriter += " AND ( tbSSinif13.sAciklama " & sorgu_kriter_string(ara, ara_kriter) & " )"
            ElseIf konum = "Sýnýf14" Then
                kriter += " AND ( tbSSinif14.sAciklama " & sorgu_kriter_string(ara, ara_kriter) & " )"
            ElseIf konum = "Sýnýf15" Then
                kriter += " AND ( tbSSinif15.sAciklama " & sorgu_kriter_string(ara, ara_kriter) & " )"
            End If
        End If
        If bIhtiyac = True Then
            ds_tbStokTedarikcisi = sorgu(sorgu_query("SET DATEFORMAT DMY SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT *, '' sNot,CAST(0 as Money) AS lHedefFiyat,CAST(0 AS MONEY) AS lFiyatFarki,CAST(0 AS MONEY) as lMiktari,CAST(1 AS MONEY) as lBirimMiktar,CAST(0 AS MONEY) as lBrutFiyat,Cast(0 as Money) as lBrutTutar,CAST(0 AS MONEY) AS lTutari,CAST(0 AS MONEY) AS lKdvTutari,CAST(0 AS MONEY) AS lIskontoTutari,CAST(0 AS MONEY) as lNetFiyat,CAST(0 AS MONEY) as lNetFiyatDahil,0 as nFirmaID,CAST(0 AS MONEY) as nIskontoYuzdesi,CAST(0 AS MONEY) as ISK1,CAST(0 AS MONEY) as ISK2,CAST(0 AS MONEY) as ISK3,CAST(0 AS MONEY) as ISK4,nBitisGun = CASE WHEN ISNULL(lMevcut, 0) > 0 AND ISNULL(lSatilan, 0) > 0 THEN lMevcut * ISNULL(nGun, 1) / lSatilan WHEN ISNULL(lMevcut, 0) = 0 AND ISNULL(lSatilan, 0) > 0 THEN ROUND(CAST(dteSonSatisTarihi - (CAST(dteSonAlisTarihi AS INT) + 1) AS FLOAT), 0) ELSE '0' END FROM (SELECT *, ROUND(CAST(GETDATE() - (CAST(dteSonAlisTarihi AS INT) + 1) AS FLOAT), 0) AS nGun, CAST(0 AS Money) AS lIhtiyac, CAST(0 AS Money) AS lIhtiyac2, (SELECT ISNULL(SUM(tbStokFisiDetayi.lCikisMiktar1), 0) AS lGirisMiktar1 FROM tbStokFisiDetayi INNER JOIN tbFisTipi ON tbStokFisiDetayi.sFisTipi = tbFisTipi.sFisTipi WHERE (tbStokFisiDetayi.sFisTipi NOT IN ('T', 'DC')) AND (tbFisTipi.bSatismi = 1) AND tbStokFisiDetayi.nGirisCikis = 3 AND tbStokFisiDetayi.nStokID = Stoklar.nStokID AND tbStokFisiDetayi.dteFisTarihi > Stoklar.dteSonAlisTarihi) AS lSatilan, (SELECT SUM(lGirisMiktar1 - lCikisMiktar1) FROM tbStokFisiDetayi WHERE dteIslemTarihi < Stoklar.dteSonAlisTarihi AND nStokID = stoklar.nStokID) AS lAlisGunMevcut FROM (SELECT tbStok.*,(SELECT     nKdvOrani FROM          tbKdv WHERE      sKdvTipi = tbStok.sKdvTipi) AS nKdvOrani, ISNULL ((SELECT TOP 1 ISNULL(lOran, 0) FROM tbStokBirimCevrimi WHERE nStokID = tbStok.nStokID AND sBirimCinsi = tbStok.sBirimCinsi2), 1) AS nBirimCarpan, ISNULL((SELECT isnull(lfiyat , 0) FROM tbstokfiyati WHERE nStokId = tbStok.NstokId AND sFiyatTipi = '" & sFiyat1 & "'),0) AS lFiyat1, ISNULL((SELECT isnull(lfiyat , 0) FROM tbstokfiyati WHERE nStokId = tbStok.NstokId AND sFiyatTipi = '" & sFiyat2 & "'),0) AS lFiyat2,ISNULL((SELECT isnull(lfiyat , 0) FROM tbstokfiyati WHERE nStokId = tbStok.NstokId AND sFiyatTipi = '" & sFiyat3 & "'),0) AS lFiyat3,ISNULL((SELECT isnull(lfiyat , 0) FROM tbstokfiyati WHERE nStokId = tbStok.NstokId AND sFiyatTipi = '" & sFiyatA & "'),0) AS lFiyatA,ISNULL((SELECT isnull(lfiyat , 0) FROM tbstokfiyati WHERE nStokId = tbStok.NstokId AND sFiyatTipi = '" & sFiyat4 & "'), 0) AS lFiyat4,ISNULL((SELECT isnull(lfiyat , 0) FROM tbstokfiyati WHERE nStokId = tbStok.NstokId AND sFiyatTipi = '" & sFiyatM & "'),0) AS lFiyatM,tbSSinif1.sAciklama AS Sinif1, tbSSinif2.sAciklama AS Sinif2, tbSSinif3.sAciklama AS Sinif3, tbSSinif4.sAciklama AS Sinif4, tbSSinif5.sAciklama AS Sinif5, tbSSinif6.sAciklama AS Sinif6, tbSSinif7.sAciklama AS Sinif7, tbSSinif8.sAciklama AS Sinif8, tbSSinif9.sAciklama AS Sinif9, tbSSinif10.sAciklama AS Sinif10, tbSSinif11.sAciklama AS Sinif11, tbSSinif12.sAciklama AS Sinif12, tbSSinif13.sAciklama AS Sinif13, tbSSinif14.sAciklama AS Sinif14, tbSSinif15.sAciklama AS Sinif15, ISNULL(tbStokAciklama.sAciklama1 + ' ' + tbStokAciklama.sAciklama2 + ' ' + tbStokAciklama.sAciklama3 + ' ' + tbStokAciklama.sAciklama4 + ' ' + tbStokAciklama.sAciklama5 + ' ' + tbStokAciklama.sAciklama6 + ' ' + tbStokAciklama.sAciklama7 + ' ' + tbStokAciklama.sAciklama8 + ' ' + tbStokAciklama.sAciklama9 + ' ' + tbStokAciklama.sAciklama10, '') AS ISTIHBARAT, (SELECT isnull(SUM(tbStokFisiDetayi.lGirisMiktar1 - tbStokFisiDetayi.lCikisMiktar1), 0) FROM tbStokFisiDetayi WHERE tbStok.nStokID = tbStokFisiDetayi.nStokID) AS lMevcut, (SELECT TOP 1 ISNULL(SUM(tbAlisverisSiparis.lGCMiktar - tbAlisverisSiparis.bEkAlan1), 0) AS BEKLEYEN FROM tbAlisverisSiparis INNER JOIN tbAlisVeris ON tbAlisverisSiparis.nAlisverisID = tbAlisVeris.nAlisverisID INNER JOIN tbStok ON tbAlisverisSiparis.nStokID = tbStok.nStokID WHERE (tbAlisverisSiparis.nGirisCikis = 3) AND (tbAlisverisSiparis.lGCMiktar <> tbAlisverisSiparis.bEkAlan1) AND (tbAlisVeris.sFisTipi = 'SP' OR tbAlisVeris.sFisTipi = 'SK') AND (tbAlisverisSiparis.dteOnayTarihi = '01/01/1900') AND (tbAlisverisSiparis.dteTeslimEdilecek BETWEEN '01/01/1900' AND '31/12/2048') AND (tbStok.nStokID = tbStok.nStokID) AND (tbAlisVeris.dteFaturaTarihi BETWEEN '01/01/1900' AND '31/12/2048') " & kriter_depo_siparis & " GROUP BY tbStok.sKodu) AS BEKLEYEN,SiparisVerilen.lVerilen AS lVerilen, SiparisAlinan.lAlinan AS lAlinan, (SELECT TOP 1 tbStokFisiDetayi.dteFisTarihi FROM tbStokFisiDetayi INNER JOIN tbFisTipi ON tbStokFisiDetayi.sFisTipi = tbFisTipi.sFisTipi WHERE (tbStokFisiDetayi.sFisTipi <> 'T') AND (tbStokFisiDetayi.sFisTipi = 'FA') AND (tbFisTipi.bSatismi = 0) AND tbStokFisiDetayi.nGirisCikis = 1 AND tbStokFisiDetayi.nStokID = tbStok.nStokID ORDER BY tbStokFisiDetayi.dteFisTarihi DESC) AS dteSonAlisTarihi, (SELECT TOP 1 ISNULL(SUM(tbStokFisiDetayi.lGirisMiktar1), 0) AS lGirisMiktar1 FROM tbStokFisiDetayi INNER JOIN tbFisTipi ON tbStokFisiDetayi.sFisTipi = tbFisTipi.sFisTipi WHERE (tbStokFisiDetayi.sFisTipi <> 'T') AND (tbStokFisiDetayi.sFisTipi = 'FA') AND (tbFisTipi.bSatismi = 0) AND tbStokFisiDetayi.nGirisCikis = 1 AND tbStokFisiDetayi.nStokID = tbStok.nStokID GROUP BY tbStokFisiDetayi.dteFisTarihi ORDER BY tbStokFisiDetayi.dteFisTarihi DESC) AS lSonAlisMiktari, (SELECT TOP 1 tbStokFisiDetayi.dteFisTarihi FROM tbStokFisiDetayi INNER JOIN tbFisTipi ON tbStokFisiDetayi.sFisTipi = tbFisTipi.sFisTipi WHERE (tbStokFisiDetayi.sFisTipi NOT IN ('T', 'DC')) AND (tbFisTipi.bSatismi = 1) AND tbStokFisiDetayi.nGirisCikis = 3 AND tbStokFisiDetayi.nStokID = tbStok.nStokID ORDER BY tbStokFisiDetayi.dteFisTarihi DESC) AS dteSonSatisTarihi, (SELECT TOP 1 ISNULL(SUM(tbStokFisiDetayi.lCikisMiktar1), 0) AS lGirisMiktar1 FROM tbStokFisiDetayi INNER JOIN tbFisTipi ON tbStokFisiDetayi.sFisTipi = tbFisTipi.sFisTipi WHERE (tbStokFisiDetayi.sFisTipi NOT IN ('T', 'DC')) AND (tbFisTipi.bSatismi = 1) AND tbStokFisiDetayi.nGirisCikis = 3 AND tbStokFisiDetayi.nStokID = tbStok.nStokID GROUP BY tbStokFisiDetayi.dteFisTarihi ORDER BY tbStokFisiDetayi.dteFisTarihi DESC) AS lSonSatisMiktari FROM tbStok INNER JOIN tbStokSinifi ON tbStok.nStokID = tbStokSinifi.nStokID INNER JOIN tbSSinif1 ON tbStokSinifi.sSinifKodu1 = tbSSinif1.sSinifKodu INNER JOIN tbSSinif2 ON tbStokSinifi.sSinifKodu2 = tbSSinif2.sSinifKodu INNER JOIN tbSSinif3 ON tbStokSinifi.sSinifKodu3 = tbSSinif3.sSinifKodu INNER JOIN tbSSinif4 ON tbStokSinifi.sSinifKodu4 = tbSSinif4.sSinifKodu INNER JOIN tbSSinif5 ON tbStokSinifi.sSinifKodu5 = tbSSinif5.sSinifKodu INNER JOIN tbSSinif6 ON tbStokSinifi.sSinifKodu6 = tbSSinif6.sSinifKodu INNER JOIN tbSSinif7 ON tbStokSinifi.sSinifKodu7 = tbSSinif7.sSinifKodu INNER JOIN tbSSinif8 ON tbStokSinifi.sSinifKodu8 = tbSSinif8.sSinifKodu INNER JOIN tbSSinif9 ON tbStokSinifi.sSinifKodu9 = tbSSinif9.sSinifKodu INNER JOIN tbSSinif10 ON tbStokSinifi.sSinifKodu10 = tbSSinif10.sSinifKodu INNER JOIN tbSSinif11 ON tbStokSinifi.sSinifKodu11 = tbSSinif11.sSinifKodu INNER JOIN tbSSinif12 ON tbStokSinifi.sSinifKodu12 = tbSSinif12.sSinifKodu INNER JOIN tbSSinif13 ON tbStokSinifi.sSinifKodu13 = tbSSinif13.sSinifKodu INNER JOIN tbSSinif14 ON tbStokSinifi.sSinifKodu14 = tbSSinif14.sSinifKodu INNER JOIN tbSSinif15 ON tbStokSinifi.sSinifKodu15 = tbSSinif15.sSinifKodu LEFT OUTER JOIN (SELECT nStokID, CAST(ISNULL(lSiparis - lSevkiyat, 0) AS MONEY) AS lAlinan FROM (SELECT tbStok.nStokID, tbStok.sModel, tbStok.sKodu, tbStok.sAciklama, SUM(tbSiparis.lMiktari) AS lSiparis, ISNULL(SUM(tbStokFisiDetayi.lCikisMiktar1), 0) AS lSevkiyat FROM tbFirma INNER JOIN tbSiparis ON tbFirma.nFirmaID = tbSiparis.nFirmaID INNER JOIN tbStok ON tbSiparis.nStokID = tbStok.nStokID LEFT OUTER JOIN tbStokFisiDetayi WITH(INDEX (tbStokFisiDetayi_index12)) ON tbStokFisiDetayi.nSiparisID = tbSiparis.nSiparisID WHERE (tbSiparis.bKapandimi = 0) AND (tbSiparis.lSiparisNo BETWEEN 1 AND 999999999) AND (tbSiparis.dteSiparisTarihi BETWEEN '01/01/1900' AND '31/12/2078') AND (SUBSTRING(tbSiparis.sSiparisiAlan, 1, 30) BETWEEN '' AND 'zzzzzzzzzzzzzzzzzzzz') AND (SUBSTRING(tbSiparis.sSiparisiAlan, 31, 30) BETWEEN '' AND 'zzzzzzzzzzzzzzzzzzzz') AND (tbSiparis.nSiparisTipi = 1) GROUP BY tbStok.nStokID, tbStok.sAciklama, tbStok.sModel, tbStok.sKodu) SiparisVerilen WHERE (ISNULL(lSiparis, 0) - ISNULL(lSevkiyat, 0) <> 0)) SiparisAlinan ON tbStok.nStokID = SiparisAlinan.nStokID LEFT OUTER JOIN (SELECT nStokID, CAST(ISNULL(lSiparis - lSevkiyat, 0) AS MONEY) AS lVerilen FROM (SELECT tbStok.nStokID, tbStok.sModel, tbStok.sKodu, tbStok.sAciklama, SUM(tbSiparis.lMiktari) AS lSiparis, ISNULL(SUM(tbStokFisiDetayi.lCikisMiktar1), 0) AS lSevkiyat FROM tbFirma INNER JOIN tbSiparis ON tbFirma.nFirmaID = tbSiparis.nFirmaID INNER JOIN tbStok ON tbSiparis.nStokID = tbStok.nStokID LEFT OUTER JOIN tbStokFisiDetayi WITH(INDEX (tbStokFisiDetayi_index12)) ON tbStokFisiDetayi.nSiparisID = tbSiparis.nSiparisID WHERE (tbSiparis.bKapandimi = 0) AND (tbSiparis.lSiparisNo BETWEEN 1 AND 999999999) AND (tbSiparis.dteSiparisTarihi BETWEEN '01/01/1900' AND '31/12/2078') AND (SUBSTRING(tbSiparis.sSiparisiAlan, 1, 30) BETWEEN '' AND 'zzzzzzzzzzzzzzzzzzzz') AND (SUBSTRING(tbSiparis.sSiparisiAlan, 31, 30) BETWEEN '' AND 'zzzzzzzzzzzzzzzzzzzz') AND (tbSiparis.nSiparisTipi = 2) GROUP BY tbStok.nStokID, tbStok.sAciklama, tbStok.sModel, tbStok.sKodu) SiparisVerilen WHERE (ISNULL(lSiparis, 0) - ISNULL(lSevkiyat, 0) <> 0)) SiparisVerilen ON tbStok.nStokID = SiparisVerilen.nStokID LEFT OUTER JOIN tbStokAciklama ON tbStok.nStokID = tbStokAciklama.nStokID " & kriter & " ) Stoklar) tbSatinAlma ORDER BY sKodu"))
        Else
            ds_tbStokTedarikcisi = sorgu(sorgu_query("SET DATEFORMAT DMY SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT *, '' sNot,CAST(0 as Money) AS lHedefFiyat,CAST(0 AS MONEY) AS lFiyatFarki,CAST(0 AS MONEY) as lMiktari,CAST(1 AS MONEY) as lBirimMiktar,CAST(0 AS MONEY) as lBrutFiyat,Cast(0 as Money) as lBrutTutar,CAST(0 AS MONEY) AS lTutari,CAST(0 AS MONEY) AS lKdvTutari,CAST(0 AS MONEY) AS lIskontoTutari,CAST(0 AS MONEY) as nIskontoYuzdesi,CAST(0 AS MONEY) as lNetFiyat,CAST(0 AS MONEY) as lNetFiyatDahil,nBitisGun = CASE WHEN ISNULL(lMevcut, 0) > 0 AND ISNULL(lSatilan, 0) > 0 THEN lMevcut * ISNULL(nGun, 1) / lSatilan WHEN ISNULL(lMevcut,0) = 0 AND ISNULL(lSatilan, 0) > 0 THEN ROUND(CAST(dteSonSatisTarihi - (CAST(dteSonAlisTarihi AS INT) + 1) AS FLOAT), 0) ELSE '0' END FROM (SELECT *, ROUND(CAST(GETDATE() - (CAST(dteSonAlisTarihi AS INT) + 1) AS FLOAT), 0) AS nGun,CAST(0 as Money) as lIhtiyac,CAST(0 as Money) as lIhtiyac2, (SELECT ISNULL(SUM(tbStokFisiDetayi.lCikisMiktar1), 0) AS lGirisMiktar1 FROM tbStokFisiDetayi INNER JOIN tbFisTipi ON tbStokFisiDetayi.sFisTipi = tbFisTipi.sFisTipi WHERE (tbStokFisiDetayi.sFisTipi NOT IN ('T', 'DC')) AND (tbFisTipi.bSatismi = 1) AND tbStokFisiDetayi.nGirisCikis = 3 AND tbStokFisiDetayi.nStokID = Stoklar.nStokID AND tbStokFisiDetayi.dteFisTarihi > Stoklar.dteSonAlisTarihi ) AS lSatilan, (SELECT SUM(lGirisMiktar1 - lCikisMiktar1) FROM tbStokFisiDetayi WHERE dteIslemTarihi < Stoklar.dteSonAlisTarihi AND nStokID = stoklar.nStokID) AS lAlisGunMevcut FROM (SELECT tbStok.*, (SELECT     nKdvOrani FROM          tbKdv WHERE      sKdvTipi = tbStok.sKdvTipi) AS nKdvOrani,ISNULL((SELECT     TOP 1 ISNULL(lOran, 0) FROM         tbStokBirimCevrimi WHERE     nStokID = tbStok.nStokID AND sBirimCinsi = tbStok.sBirimCinsi2), 1) AS nBirimCarpan,ISNULL((SELECT isnull(lfiyat , 0) FROM tbstokfiyati WHERE nStokId = tbStok.NstokId AND sFiyatTipi = '" & sFiyat1 & "'),0) AS lFiyat1, ISNULL((SELECT isnull(lfiyat , 0) FROM tbstokfiyati WHERE nStokId = tbStok.NstokId AND sFiyatTipi = '" & sFiyat2 & "'),0) AS lFiyat2,ISNULL((SELECT isnull(lfiyat , 0) FROM tbstokfiyati WHERE nStokId = tbStok.NstokId AND sFiyatTipi = '" & sFiyat3 & "'),0) AS lFiyat3,ISNULL((SELECT isnull(lfiyat , 0) FROM tbstokfiyati WHERE nStokId = tbStok.NstokId AND sFiyatTipi = '" & sFiyatA & "'),0) AS lFiyatA,ISNULL((SELECT isnull(lfiyat , 0) FROM tbstokfiyati WHERE nStokId = tbStok.NstokId AND sFiyatTipi = '" & sFiyat4 & "'), 0) AS lFiyat4,ISNULL((SELECT isnull(lfiyat , 0) FROM tbstokfiyati WHERE nStokId = tbStok.NstokId AND sFiyatTipi = '" & sFiyatM & "'),0) AS lFiyatM,tbSSinif1.sAciklama AS Sinif1, tbSSinif2.sAciklama AS Sinif2, tbSSinif3.sAciklama AS Sinif3, tbSSinif4.sAciklama AS Sinif4, tbSSinif5.sAciklama AS Sinif5, tbSSinif6.sAciklama AS Sinif6, tbSSinif7.sAciklama AS Sinif7, tbSSinif8.sAciklama AS Sinif8, tbSSinif9.sAciklama AS Sinif9, tbSSinif10.sAciklama AS Sinif10, tbSSinif11.sAciklama AS Sinif11, tbSSinif12.sAciklama AS Sinif12, tbSSinif13.sAciklama AS Sinif13, tbSSinif14.sAciklama AS Sinif14, tbSSinif15.sAciklama AS Sinif15, ISNULL(tbStokAciklama.sAciklama1 + ' ' + tbStokAciklama.sAciklama2 + ' ' + tbStokAciklama.sAciklama3 + ' ' + tbStokAciklama.sAciklama4 + ' ' + tbStokAciklama.sAciklama5 + ' ' + tbStokAciklama.sAciklama6 + ' ' + tbStokAciklama.sAciklama7 + ' ' + tbStokAciklama.sAciklama8 + ' ' + tbStokAciklama.sAciklama9 + ' ' + tbStokAciklama.sAciklama10, '') AS ISTIHBARAT, (SELECT isnull(SUM(tbStokFisiDetayi.lGirisMiktar1 - tbStokFisiDetayi.lCikisMiktar1), 0) FROM tbStokFisiDetayi WHERE tbStok.nStokID = tbStokFisiDetayi.nStokID) AS lMevcut, (SELECT TOP 1 ISNULL(SUM(tbAlisverisSiparis.lGCMiktar - tbAlisverisSiparis.bEkAlan1), 0) AS BEKLEYEN FROM tbAlisverisSiparis INNER JOIN tbAlisVeris ON tbAlisverisSiparis.nAlisverisID = tbAlisVeris.nAlisverisID INNER JOIN tbStok ON tbAlisverisSiparis.nStokID = tbStok.nStokID WHERE (tbAlisverisSiparis.nGirisCikis = 3) AND (tbAlisverisSiparis.lGCMiktar <> tbAlisverisSiparis.bEkAlan1) AND (tbAlisVeris.sFisTipi = 'SP' OR tbAlisVeris.sFisTipi = 'SK') AND (tbAlisverisSiparis.dteOnayTarihi = '01/01/1900') AND (tbAlisverisSiparis.dteTeslimEdilecek BETWEEN '01/01/1900' AND '31/12/2048') AND (tbStok.nStokID = tbStok.nStokID) AND (tbAlisVeris.dteFaturaTarihi BETWEEN '01/01/1900' AND '31/12/2048') " & kriter_depo_siparis & " GROUP BY tbStok.sKodu) AS BEKLEYEN,tbStokTedarikcisi.nFirmaID AS nFirmaID, tbFirma.sKodu AS sFirmaKodu, tbFirma.sAciklama AS sFirmaAciklama, tbFirma.nOzelIskontosu ISK1,tbFirma.nOzelIskontosu2 ISK2,tbFirma.nOzelIskontosu3 ISK3,tbFirma.nOzelIskontosu4 ISK4,tbStokTedarikcisi.nFirmaIskontosu AS nFirmaIskontosu, tbStokTedarikcisi.nStokIskontosu AS nStokIskontosu, tbStokTedarikcisi.nVadeGun AS nVadeGun, SiparisVerilen.lVerilen AS lVerilen, SiparisAlinan.lAlinan AS lAlinan, (SELECT TOP 1 tbStokFisiDetayi.dteFisTarihi FROM tbStokFisiDetayi INNER JOIN tbFisTipi ON tbStokFisiDetayi.sFisTipi = tbFisTipi.sFisTipi WHERE (tbStokFisiDetayi.sFisTipi <> 'T') AND (tbStokFisiDetayi.sFisTipi = 'FA') AND (tbFisTipi.bSatismi = 0) AND tbStokFisiDetayi.nGirisCikis = 1 AND tbStokFisiDetayi.nStokID = tbStok.nStokID ORDER BY tbStokFisiDetayi.dteFisTarihi DESC) AS dteSonAlisTarihi, (SELECT TOP 1 ISNULL(SUM(tbStokFisiDetayi.lGirisMiktar1), 0) AS lGirisMiktar1 FROM tbStokFisiDetayi INNER JOIN tbFisTipi ON tbStokFisiDetayi.sFisTipi = tbFisTipi.sFisTipi WHERE (tbStokFisiDetayi.sFisTipi <> 'T') AND (tbStokFisiDetayi.sFisTipi = 'FA') AND (tbFisTipi.bSatismi = 0) AND tbStokFisiDetayi.nGirisCikis = 1 AND tbStokFisiDetayi.nStokID = tbStok.nStokID GROUP BY tbStokFisiDetayi.dteFisTarihi ORDER BY tbStokFisiDetayi.dteFisTarihi DESC) AS lSonAlisMiktari, (SELECT TOP 1 tbStokFisiDetayi.dteFisTarihi FROM tbStokFisiDetayi INNER JOIN tbFisTipi ON tbStokFisiDetayi.sFisTipi = tbFisTipi.sFisTipi WHERE (tbStokFisiDetayi.sFisTipi NOT IN ('T', 'DC')) AND (tbFisTipi.bSatismi = 1) AND tbStokFisiDetayi.nGirisCikis = 3 AND tbStokFisiDetayi.nStokID = tbStok.nStokID ORDER BY tbStokFisiDetayi.dteFisTarihi DESC) AS dteSonSatisTarihi, (SELECT TOP 1 ISNULL(SUM(tbStokFisiDetayi.lCikisMiktar1), 0) AS lGirisMiktar1 FROM tbStokFisiDetayi INNER JOIN tbFisTipi ON tbStokFisiDetayi.sFisTipi = tbFisTipi.sFisTipi WHERE (tbStokFisiDetayi.sFisTipi NOT IN ('T', 'DC')) AND (tbFisTipi.bSatismi = 1) AND tbStokFisiDetayi.nGirisCikis = 3 AND tbStokFisiDetayi.nStokID = tbStok.nStokID GROUP BY tbStokFisiDetayi.dteFisTarihi ORDER BY tbStokFisiDetayi.dteFisTarihi DESC) AS lSonSatisMiktari FROM tbStok INNER JOIN tbStokSinifi ON tbStok.nStokID = tbStokSinifi.nStokID INNER JOIN tbSSinif1 ON tbStokSinifi.sSinifKodu1 = tbSSinif1.sSinifKodu INNER JOIN tbSSinif2 ON tbStokSinifi.sSinifKodu2 = tbSSinif2.sSinifKodu INNER JOIN tbSSinif3 ON tbStokSinifi.sSinifKodu3 = tbSSinif3.sSinifKodu INNER JOIN tbSSinif4 ON tbStokSinifi.sSinifKodu4 = tbSSinif4.sSinifKodu INNER JOIN tbSSinif5 ON tbStokSinifi.sSinifKodu5 = tbSSinif5.sSinifKodu INNER JOIN tbSSinif6 ON tbStokSinifi.sSinifKodu6 = tbSSinif6.sSinifKodu INNER JOIN tbSSinif7 ON tbStokSinifi.sSinifKodu7 = tbSSinif7.sSinifKodu INNER JOIN tbSSinif8 ON tbStokSinifi.sSinifKodu8 = tbSSinif8.sSinifKodu INNER JOIN tbSSinif9 ON tbStokSinifi.sSinifKodu9 = tbSSinif9.sSinifKodu INNER JOIN tbSSinif10 ON tbStokSinifi.sSinifKodu10 = tbSSinif10.sSinifKodu INNER JOIN tbSSinif11 ON tbStokSinifi.sSinifKodu11 = tbSSinif11.sSinifKodu INNER JOIN tbSSinif12 ON tbStokSinifi.sSinifKodu12 = tbSSinif12.sSinifKodu INNER JOIN tbSSinif13 ON tbStokSinifi.sSinifKodu13 = tbSSinif13.sSinifKodu INNER JOIN tbSSinif14 ON tbStokSinifi.sSinifKodu14 = tbSSinif14.sSinifKodu INNER JOIN tbSSinif15 ON tbStokSinifi.sSinifKodu15 = tbSSinif15.sSinifKodu INNER JOIN tbStokTedarikcisi ON tbStok.nStokID = tbStokTedarikcisi.nStokID INNER JOIN tbFirma ON tbStokTedarikcisi.nFirmaID = tbFirma.nFirmaID LEFT OUTER JOIN (SELECT nStokID, CAST(ISNULL(lSiparis - lSevkiyat, 0) AS MONEY) AS lAlinan FROM (SELECT tbStok.nStokID, tbStok.sModel, tbStok.sKodu, tbStok.sAciklama, SUM(tbSiparis.lMiktari) AS lSiparis, ISNULL(SUM(tbStokFisiDetayi.lCikisMiktar1), 0) AS lSevkiyat FROM tbFirma INNER JOIN tbSiparis ON tbFirma.nFirmaID = tbSiparis.nFirmaID INNER JOIN tbStok ON tbSiparis.nStokID = tbStok.nStokID LEFT OUTER JOIN tbStokFisiDetayi WITH(INDEX (tbStokFisiDetayi_index12)) ON tbStokFisiDetayi.nSiparisID = tbSiparis.nSiparisID WHERE (tbSiparis.bKapandimi = 0) AND (tbSiparis.lSiparisNo BETWEEN 1 AND 999999999) AND (tbSiparis.dteSiparisTarihi BETWEEN '01/01/1900' AND '31/12/2078') AND (SUBSTRING(tbSiparis.sSiparisiAlan, 1, 30) BETWEEN '' AND 'zzzzzzzzzzzzzzzzzzzz') AND (SUBSTRING(tbSiparis.sSiparisiAlan, 31, 30) BETWEEN '' AND 'zzzzzzzzzzzzzzzzzzzz') AND (tbSiparis.nSiparisTipi = 1) GROUP BY tbStok.nStokID, tbStok.sAciklama, tbStok.sModel, tbStok.sKodu) SiparisVerilen WHERE (ISNULL(lSiparis, 0) - ISNULL(lSevkiyat, 0) <> 0)) SiparisAlinan ON tbStok.nStokID = SiparisAlinan.nStokID LEFT OUTER JOIN (SELECT nStokID, CAST(ISNULL(lSiparis - lSevkiyat, 0) AS MONEY) AS lVerilen FROM (SELECT tbStok.nStokID, tbStok.sModel, tbStok.sKodu, tbStok.sAciklama, SUM(tbSiparis.lMiktari) AS lSiparis, ISNULL(SUM(tbStokFisiDetayi.lCikisMiktar1), 0) AS lSevkiyat FROM tbFirma INNER JOIN tbSiparis ON tbFirma.nFirmaID = tbSiparis.nFirmaID INNER JOIN tbStok ON tbSiparis.nStokID = tbStok.nStokID LEFT OUTER JOIN tbStokFisiDetayi WITH(INDEX (tbStokFisiDetayi_index12)) ON tbStokFisiDetayi.nSiparisID = tbSiparis.nSiparisID WHERE (tbSiparis.bKapandimi = 0) AND (tbSiparis.lSiparisNo BETWEEN 1 AND 999999999) AND (tbSiparis.dteSiparisTarihi BETWEEN '01/01/1900' AND '31/12/2078') AND (SUBSTRING(tbSiparis.sSiparisiAlan, 1, 30) BETWEEN '' AND 'zzzzzzzzzzzzzzzzzzzz') AND (SUBSTRING(tbSiparis.sSiparisiAlan, 31, 30) BETWEEN '' AND 'zzzzzzzzzzzzzzzzzzzz') AND (tbSiparis.nSiparisTipi = 2) GROUP BY tbStok.nStokID, tbStok.sAciklama, tbStok.sModel, tbStok.sKodu) SiparisVerilen WHERE (ISNULL(lSiparis, 0) - ISNULL(lSevkiyat, 0) <> 0)) SiparisVerilen ON tbStok.nStokID = SiparisVerilen.nStokID LEFT OUTER JOIN tbStokAciklama ON tbStok.nStokID = tbStokAciklama.nStokID " & kriter & " and tbStokTedarikcisi.nFirmaID = '" & nFirmaID & "') Stoklar) tbSatinAlma Order by sKodu"))
        End If
        GridControl1.DataMember = Nothing
        GridControl1.DataSource = ds_tbStokTedarikcisi.Tables(0)
    End Sub
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
    Private Sub firma_sec(Optional ByVal islem As Integer = 0)
        Dim dr As DataRow
        dr = GridView1.GetDataRow(GridView1.FocusedRowHandle)
        Dim frm As New frm_firma_liste
        frm.firmano = firmano
        frm.donemno = donemno
        frm.connection = connection
        frm.islemstatus = True
        frm.kullanici = kullanici
        If frm.ShowDialog(Me) = Windows.Forms.DialogResult.OK Then
            Dim dr1 As DataRow
            dr1 = frm.GridView1.GetDataRow(frm.GridView1.FocusedRowHandle)
            nFirmaID = dr1("nFirmaID")
            sFirmaKodu = dr1("sKodu")
            lbl_Firma.Text = Trim(dr1("sAciklama").ToString)
            sFirmaAciklama = Trim(dr1("sAciklama").ToString)
            txt_musteriNo.EditValue = sFirmaKodu
            dr1 = Nothing
        End If
    End Sub
    Private Sub tbStokTedarikcisi_kaydet_yeni(ByVal nFirmaID As String, ByVal nStokID As String, ByVal nFirmaIskontosu As Decimal, ByVal nStokIskontosu As Decimal, ByVal nVadeGun As Int64)
        Dim cmd As New OleDb.OleDbCommand
        Dim con As New OleDb.OleDbConnection
        cmd.Connection = con
        con.ConnectionString = connection
        cmd.CommandTimeout = Nothing
        If con.State = ConnectionState.Closed = True Then
            con.Open()
        End If
        cmd.CommandText = sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED INSERT INTO tbStokTedarikcisi                       (nFirmaID, nStokID, nFirmaIskontosu, nStokIskontosu, nVadeGun) VALUES     ('" & nFirmaID & "', '" & nStokID & "', " & nFirmaIskontosu & ", " & nStokIskontosu & ", " & nVadeGun & ")")
        cmd.ExecuteNonQuery()
        con.Close()
    End Sub
    Private Sub tbStokTedarikcisi_kaydet_degistir(ByVal nFirmaID As String, ByVal nStokID As String, ByVal nFirmaIskontosu As Decimal, ByVal nStokIskontosu As Decimal, ByVal nVadeGun As Int64)
        Dim cmd As New OleDb.OleDbCommand
        Dim con As New OleDb.OleDbConnection
        cmd.Connection = con
        con.ConnectionString = connection
        cmd.CommandTimeout = Nothing
        If con.State = ConnectionState.Closed = True Then
            con.Open()
        End If
        cmd.CommandText = sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED UPDATE    tbStokTedarikcisi SET    nFirmaIskontosu = " & nFirmaIskontosu & ", nStokIskontosu = " & nStokIskontosu & ", nVadeGun = " & nVadeGun & " Where nFirmaID = '" & nFirmaID & "' AND nStokID = '" & nStokID & "' ")
        cmd.ExecuteNonQuery()
        con.Close()
    End Sub
    Private Sub tbStokTedarikcisi_kaydet_sil(ByVal nFirmaID As String, ByVal nStokID As String)
        Dim cmd As New OleDb.OleDbCommand
        Dim con As New OleDb.OleDbConnection
        cmd.Connection = con
        con.ConnectionString = connection
        cmd.CommandTimeout = Nothing
        If con.State = ConnectionState.Closed = True Then
            con.Open()
        End If
        cmd.CommandText = sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED DELETE FROM tbStokTedarikcisi Where nFirmaID = '" & nFirmaID & "' AND nStokID = '" & nStokID & "' ")
        cmd.ExecuteNonQuery()
        con.Close()
    End Sub
    Public Function sorgu_ntbStokTedarikcisi(ByVal nFirmaID As String, ByVal nStokID As String) As Int64
        'kriter = "WHERE (sKodu = '" & kod & "')  "
        Dim conn As New OleDb.OleDbConnection
        Dim cmd As New OleDb.OleDbCommand
        Dim adapter As New OleDb.OleDbDataAdapter
        'MsgBox(connection_resmi)
        conn.ConnectionString = connection
        cmd.Connection = conn
        conn.Open()
        cmd.CommandText = sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT     COUNT(*) AS nKayit FROM         tbStokTedarikcisi WHERE     (nFirmaID = " & nFirmaID & ") AND (nStokID = " & nStokID & ")")
        Dim kayitsayisi = cmd.ExecuteScalar
        Return kayitsayisi
    End Function
    Private Sub satir_ekle_stok()
        Dim frm As New frm_stok
        frm.islemstatus = True
        frm.connection = connection
        frm.firmano = firmano
        frm.donemno = donemno
        frm.islemstatus = True
        frm.kullanici = kullanici
        If frm.ShowDialog(Me) = Windows.Forms.DialogResult.OK Then
            Dim s As String
            Dim arr As Integer()
            Dim i As Integer
            Dim dr1 As DataRow
            arr = frm.GridView1.GetSelectedRows()
            If arr Is Nothing Then
            Else
                Array.Sort(arr)
                For Each i In arr
                    s = i.ToString
                    dr1 = frm.GridView1.GetDataRow(s)
                    If sorgu_ntbStokTedarikcisi(nFirmaID, dr1("nStokID")) = 0 Then
                        tbStokTedarikcisi_kaydet_yeni(nFirmaID, dr1("nStokID"), 0, 0, 0)
                    End If
                Next
            End If
            ara()
        End If
    End Sub
    Private Sub stok_sil()
        If XtraMessageBox.Show(Sorgu_sDil("Seçili Kayýtlarý Silmek Ýstediðinize Emin misiniz...?", sDil), Sorgu_sDil("Dikkat", sDil), MessageBoxButtons.YesNo, MessageBoxIcon.Question) = MsgBoxResult.Yes Then
            Dim s As String
            Dim arr As Integer()
            Dim i As Integer
            Dim dr1 As DataRow
            arr = GridView1.GetSelectedRows()
            If arr Is Nothing Then
            Else
                Array.Sort(arr)
                For Each i In arr
                    s = i.ToString
                    dr1 = GridView1.GetDataRow(s)
                    If bIhtiyac = False Then
                        tbStokTedarikcisi_kaydet_sil(dr1("nFirmaID"), dr1("nStokID"))
                    End If
                Next
            End If
            s = Nothing
            arr = Nothing
            i = Nothing
            dr1 = Nothing
            XtraMessageBox.Show(Sorgu_sDil("Ýþlem Tamamlandý...", sDil), Sorgu_sDil("Dikkat", sDil), MessageBoxButtons.OK, MessageBoxIcon.Information)
            ara()
        End If
    End Sub
    Private Sub degeryay(ByVal columnkriter As String)
        Dim durum
        Dim sayi = GridView1.RowCount  'kl.Count
        Dim satir = GridView1.FocusedRowHandle 'kl.Position
        Dim TOPLAM = sayi - GridView1.FocusedRowHandle 'kl.Position
        Dim t As Int64
        Dim Ý As Integer
        Ý = 0
        Dim dr_hareket As DataRow
        Dim dr As DataRow
        dr_hareket = GridView1.GetDataRow(GridView1.FocusedRowHandle)
        durum = dr_hareket("" & columnkriter & "")
        For Ý = 1 To TOPLAM
            'dr_hareket = GridView2.GetDataRow(GridView2.FocusedRowHandle)
            'dr_hareket.BeginEdit()
            'dr_hareket("" & columnkriter & "") = durum
            'dr_hareket.EndEdit()
            t += 1
            If columnkriter = "nFirmaIskontosu" Then
                GridView1.PostEditor()
                dr = GridView1.GetDataRow(GridView1.FocusedRowHandle)
                dr("" & columnkriter & "") = durum
                dr.EndEdit()
            ElseIf columnkriter = "nStokIskontosu" Then
                GridView1.PostEditor()
                dr = GridView1.GetDataRow(GridView1.FocusedRowHandle)
                dr("" & columnkriter & "") = durum
                dr.EndEdit()
            ElseIf columnkriter = "nVadeGun" Then
                GridView1.PostEditor()
                dr = GridView1.GetDataRow(GridView1.FocusedRowHandle)
                dr("" & columnkriter & "") = durum
                dr.EndEdit()
            End If
            tbStokTedarik_hesapla()
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
    Private Sub tbStokTedarik_hesapla()
        If GridView1.RowCount > 0 Then
            GridView1.PostEditor()
            Dim dr As DataRow
            dr = GridView1.GetDataRow(GridView1.FocusedRowHandle)
            dr.EndEdit()
            If bIhtiyac = False Then
                tbStokTedarikcisi_kaydet_degistir(dr("nFirmaID"), dr("nStokID"), dr("nFirmaIskontosu"), dr("nStokIskontosu"), dr("nVadeGun"))
            End If
        End If
    End Sub
    Private Sub stok_duzelt()
        If GridView1.RowCount > 0 Then
            dr = GridView1.GetDataRow(GridView1.FocusedRowHandle)
            Dim frm As New frm_stok_kart
            frm.firmano = firmano
            frm.donemno = donemno
            frm.connection = connection
            frm.nStokID = dr("nStokID")
            frm.sKodu = dr("sKodu")
            frm.sModel = dr("sModel")
            frm.kullanici = kullanici
            If yetki_kontrol(kullanici, frm.Name) = True Then
                frm.ShowDialog()
            End If
            Dim satir = GridView1.FocusedRowHandle
            'ara()
            GridView1.FocusedRowHandle = satir
            satir = Nothing
            frm.Close()
            frm.Dispose()
            frm = Nothing
        End If
    End Sub
    Private Sub analiz_envanter()
        If GridView1.RowCount > 0 Then
            Dim dr As DataRow
            dr = GridView1.GetDataRow(GridView1.FocusedRowHandle)
            Dim frm As New frm_stok_envanter
            frm.firmano = firmano
            frm.donemno = donemno
            frm.connection = connection
            frm.stokno = dr("nStokId")
            frm.stokkodu = dr("sKodu")
            frm.kullanici = kullanici
            If yetki_kontrol(kullanici, frm.Name) = True Then
                frm.ShowDialog()
            End If
            frm.Close()
            frm.Dispose()
            frm = Nothing
        End If
    End Sub
    Private Sub analiz_hareket_transfer()
        If GridView1.RowCount > 0 Then
            Dim dr As DataRow
            dr = GridView1.GetDataRow(GridView1.FocusedRowHandle)
            Dim frm As New frm_stok_hareketleri_transfer
            frm.firmano = firmano
            frm.donemno = donemno
            frm.connection = connection
            'frm.stokno = dr("nStokId")
            frm.stokkodu = dr("sKodu")
            frm.kullanici = kullanici
            If yetki_kontrol(kullanici, frm.Name) = True Then
                frm.ShowDialog()
            End If
            frm.Close()
            frm.Dispose()
            frm = Nothing
        End If
    End Sub
    Private Sub analiz_stok_hareket()
        If GridView1.RowCount > 0 Then
            Dim dr As DataRow = GridView1.GetDataRow(GridView1.FocusedRowHandle)
            Dim frm As New frm_stok_hareketleri
            frm.firmano = firmano
            frm.donemno = donemno
            frm.connection = connection
            frm.musterino = dr("sKodu")
            frm.nFirmaID = 0
            frm.sec_firma.Checked = False
            frm.sec_giris.Text = "[Tümü]"
            frm.collGirisFiyat.Visible = False
            frm.collGirisFiyat.OptionsColumn.ShowInCustomizationForm = False
            frm.collCikisFiyat.Visible = False
            frm.collCikisFiyat.OptionsColumn.ShowInCustomizationForm = False
            frm.collBrutFiyat.Visible = False
            frm.collBrutFiyat.OptionsColumn.ShowInCustomizationForm = False
            frm.collBrutTutar.Visible = False
            frm.collBrutTutar.OptionsColumn.ShowInCustomizationForm = False
            frm.colnKdvOrani.Visible = False
            frm.colnKdvOrani.OptionsColumn.ShowInCustomizationForm = False
            frm.collIskontoTutari.Visible = False
            frm.collIskontoTutari.OptionsColumn.ShowInCustomizationForm = False
            frm.colnGirisCikis.Visible = False
            frm.MenuItem16.Enabled = False
            frm.MenuItem17.Enabled = False
            frm.MenuItem20.Enabled = False
            frm.Label1.Text = dr("sAciklama") & vbCrLf & frm.Label1.Text
            frm.kullanici = kullanici
            If yetki_kontrol(kullanici, frm.Name) = True Then
                frm.ShowDialog()
            End If
            frm.Close()
            frm.Dispose()
            frm = Nothing
        End If
    End Sub
    Private Sub analiz_envanter_model()
        If GridView1.RowCount > 0 Then
            Dim dr As DataRow
            dr = GridView1.GetDataRow(GridView1.FocusedRowHandle)
            Dim frm As New frm_stok_envanter_model
            frm.firmano = firmano
            frm.donemno = donemno
            frm.connection = connection
            frm.modelno = dr("sModel")
            frm.kullanici = kullanici
            If yetki_kontrol(kullanici, frm.Name) = True Then
                frm.ShowDialog()
            End If
            frm.Close()
            frm.Dispose()
            frm = Nothing
        End If
    End Sub
    Private Sub analiz_hareket()
        Dim dr As DataRow
        dr = GridView1.GetDataRow(GridView1.FocusedRowHandle)
        'stkdll.firmano = firmano
        'stkdll.donemno = donemno
        'stkdll.connection = connection
        'stkdll.stokno = dr("IND")
        'stkdll.rptfiyatanalizi(dr("IND"), 100, dr("MALINCINSI"), 2)
    End Sub
    Private Sub stok_fiyat()
        If GridView1.RowCount > 0 Then
            Dim dr As DataRow
            dr = GridView1.GetDataRow(GridView1.FocusedRowHandle)
            Dim frm As New frm_stok_fiyatlandir
            frm.firmano = firmano
            frm.donemno = donemno
            frm.connection = connection
            frm.nStokID = dr("nStokId")
            frm.sModel = dr("sModel")
            frm.sKodu = dr("sKodu")
            frm.sRenk = dr("sRenk")
            frm.sBeden = dr("sBeden")
            frm.txt_musteriNo.Text = dr("sModel")
            frm.kullanici = kullanici
            If yetki_kontrol(kullanici, frm.Name) = True Then
                frm.ShowDialog()
            End If
            frm.Close()
            frm.Dispose()
            frm = Nothing
            Dim satir = GridView1.FocusedRowHandle
            'ara()
            GridView1.FocusedRowHandle = satir
            satir = Nothing
        End If
    End Sub
    Private Sub stok_satis_detay()
        If GridView1.RowCount > 0 Then
            Dim frm As New frm_stok_cari_satis
            Dim dr As DataRow
            dr = GridView1.GetDataRow(GridView1.FocusedRowHandle)
            frm.status = True
            frm.firmano = 100
            frm.donemno = 1
            frm.connection = connection
            frm.islemstatus = True
            frm.stokno = dr("nAlisverisID")
            frm.fistipi = Trim(dr("sFisTipi").ToString)
            frm.kullanici = kullanici
            If yetki_kontrol(kullanici, frm.Name) = True Then
                frm.ShowDialog()
            End If
            frm.Close()
            dr = Nothing
        End If
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
    Private Sub analiz_acik_faturalar_analiz()
        If GridView1.RowCount > 0 Then
            Dim dr As DataRow = GridView1.GetDataRow(GridView1.FocusedRowHandle)
            Dim frm As New frm_cari_faturalar_acik_analiz
            frm.firmano = firmano
            frm.donemno = donemno
            frm.connection = connection
            frm.musterino = dr("nMusteriID")
            frm.kullanici = kullanici
            If yetki_kontrol(kullanici, frm.Name) = True Then
                frm.ShowDialog()
            End If
            frm.Close()
            frm.Dispose()
            frm = Nothing
        End If
    End Sub
    Private Sub analiz_acik_faturalar()
        If GridView1.RowCount > 0 Then
            Dim dr As DataRow = GridView1.GetDataRow(GridView1.FocusedRowHandle)
            Dim frm As New frm_cari_faturalar_acik
            frm.firmano = firmano
            frm.donemno = donemno
            frm.connection = connection
            frm.musterino = dr("nMusteriID")
            frm.kullanici = kullanici
            If yetki_kontrol(kullanici, frm.Name) = True Then
                frm.ShowDialog()
            End If
            frm.Close()
            frm.Dispose()
            frm = Nothing
        End If
    End Sub
    Private Sub analiz_iletisim()
        If GridView1.RowCount > 0 Then
            Dim dr As DataRow = GridView1.GetDataRow(GridView1.FocusedRowHandle)
            Dim frm As New frm_firma_iletisim
            frm.firmano = firmano
            frm.donemno = donemno
            frm.connection = connection
            frm.musterino = dr("nFirmaID")
            frm.kullanici = kullanici
            If yetki_kontrol(kullanici, frm.Name) = True Then
                frm.ShowDialog()
            End If
            frm.Close()
            frm.Dispose()
            frm = Nothing
        End If
    End Sub
    Private Sub analiz_musteri_satislar()
        If GridView1.RowCount > 0 Then
            Dim dr As DataRow = GridView1.GetDataRow(GridView1.FocusedRowHandle)
            Dim frm As New frm_cari_faturalar_kapatma
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
    Private Sub analiz_musteri_hareket_ekstre()
        If GridView1.RowCount > 0 Then
            Dim dr As DataRow = GridView1.GetDataRow(GridView1.FocusedRowHandle)
            Dim frm As New frm_cari_ekstre
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
    Private Sub lIhtiyac_belirle()
        'If ds_tbStokTedarikcisi.Tables(0).Rows.Count > 0 Then
        Dim dr As DataRow
        Dim lIhtiyac As Integer = 0
        For Each dr In ds_tbStokTedarikcisi.Tables(0).Rows
            If dr("lSatilan") > 0 Then
                lIhtiyac = (txt_nGun.EditValue * dr("lSatilan")) / dr("nGun")
                dr("lIhtiyac") = (lIhtiyac - dr("lMevcut"))
                dr("lIhtiyac2") = ((lIhtiyac - dr("lMevcut"))) / dr("nBirimCarpan")
            End If
        Next
        dr = Nothing
        lIhtiyac = Nothing
        XtraMessageBox.Show(Sorgu_sDil("Tamamlandý...", sDil), Sorgu_sDil("Dikkat", sDil), MessageBoxButtons.OK, MessageBoxIcon.Information)
        'End If
    End Sub
    Private Sub txt_musteriNo_ButtonClick(ByVal sender As Object, ByVal e As DevExpress.XtraEditors.Controls.ButtonPressedEventArgs) Handles txt_musteriNo.ButtonClick
        firma_sec()
    End Sub
    Private Sub txt_musteriNo_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txt_musteriNo.KeyDown
        If e.KeyCode = Keys.Space Then
            firma_sec()
        ElseIf e.KeyCode = Keys.Enter Then
            If Trim(txt_musteriNo.Text) = "" Then
                firma_sec()
            End If
        End If
    End Sub
    Private Sub GridControl1_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles GridControl1.KeyDown
        If e.KeyCode = Keys.Escape Then
            Me.Close()
        End If
    End Sub
    Private Sub MenuItem17_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        txt_musteriNo.EditValue = ""
        txt_musteriNo.Focus()
        txt_musteriNo.SelectAll()
    End Sub
    Private Sub MenuItem16_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        satir_ekle_stok()
    End Sub
    Private Sub GridView1_CellValueChanged(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs) Handles GridView1.CellValueChanged
        If GridView1.RowCount > 0 Then
            GridView1.PostEditor()
            dr = GridView1.GetDataRow(GridView1.FocusedRowHandle)
            dr.EndEdit()
            If GridView1.FocusedColumn.Name.ToString = collIhtiyac.Name.ToString Then
                dr("lIhtiyac2") = dr("lIhtiyac") / dr("nBirimCarpan")
            ElseIf GridView1.FocusedColumn.Name.ToString = collIhtiyac2.Name.ToString Then
                dr("lIhtiyac") = dr("lIhtiyac2") * dr("nBirimCarpan")
            End If
            tutar_hesapla()
            tbStokTedarik_hesapla()
        End If
    End Sub
    Private Sub iskonto_yuvarla(ByVal nIskontoYuzdesi As Decimal, Optional ByVal nIslem As Integer = 0)
        Dim isk1 As Decimal = 0
        Dim isk2 As Decimal = 0
        Dim isk3 As Decimal = 0
        Dim isk4 As Decimal = 0
        Dim isk5 As Decimal = 0
        Dim lFiyat As Decimal = 0
        Dim lFarkOran As Decimal = 0.001
        Dim dr As DataRow
        dr = GridView1.GetDataRow(GridView1.FocusedRowHandle)
        lFiyat = 100
        Dim i As Integer = 0
        For i = 1 To 1000000
            isk1 = lFiyat * ((100 - dr("ISK1")) / 100)
            isk2 = isk1 * ((100 - dr("ISK2")) / 100)
            isk3 = isk2 * ((100 - dr("ISK3")) / 100)
            isk4 = isk3 * ((100 - dr("ISK4")) / 100)
            If nIslem = 0 Then
                If nIskontoYuzdesi >= isk4 Then
                    Exit For
                Else
                    If dr("ISK4") <> 0 Then
                        dr("ISK4") = dr("ISK4") + lFarkOran
                    ElseIf dr("ISK3") <> 0 Then
                        dr("ISK3") = dr("ISK3") + lFarkOran
                    ElseIf dr("ISK2") <> 0 Then
                        dr("ISK2") = dr("ISK2") + lFarkOran
                    ElseIf dr("ISK1") <> 0 Then
                        dr("ISK1") = dr("ISK1") + lFarkOran
                    Else
                        dr("ISK1") = dr("ISK1") + lFarkOran
                    End If
                End If
            Else
                If isk4 >= nIskontoYuzdesi Then
                    Exit For
                Else
                    If dr("ISK4") <> 0 Then
                        dr("ISK4") = dr("ISK4") - lFarkOran
                    ElseIf dr("ISK3") <> 0 Then
                        dr("ISK3") = dr("ISK3") - lFarkOran
                    ElseIf dr("ISK2") <> 0 Then
                        dr("ISK2") = dr("ISK2") - lFarkOran
                    ElseIf dr("ISK1") <> 0 Then
                        dr("ISK1") = dr("ISK1") - lFarkOran
                    Else
                        dr("ISK1") = dr("ISK1") - lFarkOran
                    End If
                End If
            End If
        Next
    End Sub
    Private Sub tutar_hesapla(Optional ByVal nSatirIndex As Integer = -1)
        If GridView1.RowCount > 0 Then
            Dim isk1 As Decimal = 0
            Dim isk2 As Decimal = 0
            Dim isk3 As Decimal = 0
            Dim isk4 As Decimal = 0
            Dim isk5 As Decimal = 0
            Dim isk6 As Decimal = 0
            Dim isk7 As Decimal = 0
            Dim isk8 As Decimal = 0
            Dim lMiktar As Decimal = 0
            Dim lFiyat As Decimal = 0
            Dim lGercekFiyat As Decimal = 0
            Dim lGercekToplam As Decimal = 0
            Dim lIsktutar As Decimal = 0
            Dim lkdvtutar As Decimal = 0
            Dim dr As DataRow
            If nSatirIndex = -1 Then
                dr = GridView1.GetDataRow(GridView1.FocusedRowHandle)
            Else
                dr = GridView1.GetDataRow(nSatirIndex)
            End If
            dr("lMiktari") = dr("lIhtiyac") * dr("lBirimMiktar")
            dr("lMiktari") = sorgu_sayi(dr("lMiktari"), 1)
            dr("lBrutFiyat") = sorgu_sayi(dr("lFiyatA"), 0.01)
            dr("lTutari") = sorgu_sayi(dr("lTutari"), 0.01)
            dr("lBrutTutar") = sorgu_sayi(dr("lBrutTutar"), 0.01)
            dr("ISK1") = sorgu_sayi(dr("ISK1"), 0)
            dr("ISK2") = sorgu_sayi(dr("ISK2"), 0)
            dr("ISK3") = sorgu_sayi(dr("ISK3"), 0)
            dr("ISK4") = sorgu_sayi(dr("ISK4"), 0)
            lFiyat = dr("lBrutFiyat")
            lMiktar = dr("lIhtiyac")
            If dr("ISK1") > 100 Then
                dr("ISK1") = 100
            ElseIf dr("ISK1") < 0 Then
                dr("ISK1") = 0
            End If
            If dr("ISK2") > 100 Then
                dr("ISK2") = 100
            ElseIf dr("ISK2") < 0 Then
                dr("ISK2") = 0
            End If
            If dr("ISK3") > 100 Then
                dr("ISK3") = 100
            ElseIf dr("ISK3") < 0 Then
                dr("ISK3") = 0
            End If
            If dr("ISK4") > 100 Then
                dr("ISK4") = 100
            ElseIf dr("ISK4") < 0 Then
                dr("ISK4") = 0
            End If
            isk1 = lFiyat * ((100 - dr("ISK1")) / 100)
            isk2 = isk1 * ((100 - dr("ISK2")) / 100)
            isk3 = isk2 * ((100 - dr("ISK3")) / 100)
            isk4 = isk3 * ((100 - dr("ISK4")) / 100)
            isk5 = isk4
            Try
                dr("nIskontoYuzdesi") = ((dr("lBrutFiyat") - isk5) / dr("lBrutFiyat")) * 100
            Catch ex As Exception
                dr("nIskontoYuzdesi") = 0
            End Try
            lGercekFiyat = isk5
            lGercekToplam = isk5 * lMiktar
            lIsktutar = (lFiyat * lMiktar) - lGercekToplam
            lkdvtutar = (lGercekToplam * (dr("nKdvOrani") / 100))
            'dr("sSatirAciklama") = "Isk1:" & uzunluk_tamamla(FormatNumber(dr("ISK1"), 2), 5) & " Isk2:" & uzunluk_tamamla(FormatNumber(dr("ISK2"), 2), 5) & " Isk3:" & uzunluk_tamamla(FormatNumber(dr("ISK3"), 2), 5) & " Isk4:" & uzunluk_tamamla(FormatNumber(dr("ISK4"), 2), 5)
            dr("lBrutTutar") = lMiktar * dr("lBrutFiyat")
            dr("lNetFiyat") = (lGercekFiyat)
            dr("lNetFiyatDahil") = (lGercekFiyat * ((dr("nKdvOrani") + 100) / 100))
            dr("lTutari") = lGercekToplam
            dr("lIskontoTutari") = dr("lBrutTutar") - lGercekToplam
            dr("lKdvTutari") = lkdvtutar
            If dr("lHedefFiyat") = 0 Then
                dr("lFiyatFarki") = 0
            Else
                dr("lFiyatFarki") = dr("lNetFiyatDahil") - dr("lHedefFiyat")
            End If
        End If
    End Sub
    Private Sub SimpleButton2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SimpleButton2.Click
        Me.Close()
    End Sub
    Private Sub SimpleButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SimpleButton1.Click
        Me.Close()
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
            Label2.Text = Sorgu_sDil("Kayýt Sayýsý :", sDil) & GridView1.RowCount & " / " & Sorgu_sDil("Satýr :", sDil) & GridView1.FocusedRowHandle + 1 & " / " & Sorgu_sDil("Seçili :", sDil) & GridView1.SelectedRowsCount
        ElseIf GridView1.SelectedRowsCount = 1 Then
            Label2.Text = Sorgu_sDil("Kayýt Sayýsý :", sDil) & GridView1.RowCount & " / " & Sorgu_sDil("Satýr :", sDil) & GridView1.FocusedRowHandle + 1
        Else
            Label2.Text = ""
        End If
    End Sub
    Private Sub MenuItem24_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem24.Click
        satir_ekle_stok()
    End Sub
    Private Sub MenuItem27_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem27.Click
        txt_musteriNo.EditValue = ""
        txt_musteriNo.Focus()
        txt_musteriNo.SelectAll()
    End Sub
    Private Sub SimpleButton6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        ara()
    End Sub
    Private Sub MenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem1.Click
        GridView1.ColumnsCustomization()
    End Sub
    Private Sub MenuItem23_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem23.Click
        If MenuItem23.Checked = False Then
            GridView1.OptionsView.ShowAutoFilterRow = True
            GridView1.OptionsView.ShowFilterPanelMode = DevExpress.XtraGrid.Views.Base.ShowFilterPanelMode.Default
            GridView1.OptionsCustomization.AllowFilter = True
            MenuItem23.Checked = True
        ElseIf MenuItem23.Checked = True Then
            GridView1.OptionsView.ShowAutoFilterRow = False
            GridView1.OptionsView.ShowFilterPanelMode = DevExpress.XtraGrid.Views.Base.ShowFilterPanelMode.Never
            GridView1.OptionsCustomization.AllowFilter = False
            MenuItem23.Checked = True
        End If
    End Sub
    Private Sub MenuItem16_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem16.Click
        analiz_envanter()
    End Sub
    Private Sub MenuItem17_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem17.Click
        stok_duzelt()
    End Sub
    Private Sub MenuItem18_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem18.Click
        analiz_stok_hareket()
    End Sub
    Private Sub MenuItem21_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem21.Click
        analiz_hareket_transfer()
    End Sub
    Private Sub MenuItem22_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem22.Click
        stok_fiyat()
    End Sub
    Private Sub MenuItem3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem3.Click
        gorunum_kaydet()
    End Sub
    Private Sub MenuItem5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem5.Click
        GridView1.OptionsView.ShowFilterPanelMode = DevExpress.XtraGrid.Views.Base.ShowFilterPanelMode.Default
        GridView1.OptionsCustomization.AllowFilter = True
    End Sub
    Private Sub MenuItem6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem6.Click
        GridView1.OptionsView.ShowGroupPanel = True
        GridView1.OptionsCustomization.AllowGroup = True
    End Sub
    Private Sub MenuItem7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem7.Click
        GridView1.ExpandAllGroups()
    End Sub
    Private Sub MenuItem8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem8.Click
        GridView1.CollapseAllGroups()
    End Sub
    Private Sub MenuItem9_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem9.Click
        If Me.WindowState = FormWindowState.Normal Then
            Me.WindowState = FormWindowState.Maximized
        ElseIf Me.WindowState = FormWindowState.Maximized Then
            Me.WindowState = FormWindowState.Normal
        End If
    End Sub
    Private Sub MenuItem26_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem26.Click
        stok_sil()
    End Sub
    Private Sub MenuItem4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem4.Click
        printlink1.CreateDocument(ps)
        ps.PreviewRibbonFormEx.Show()
    End Sub
    Private Sub SimpleButton3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SimpleButton3.Click
        ara()
    End Sub
    Private Sub BarButtonItem1_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnAra.ItemClick
        ara()
    End Sub
    Private Sub BarButtonItem2_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem2.ItemClick
        satir_ekle_stok()
    End Sub
    Private Sub BarButtonItem4_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem4.ItemClick
        stok_duzelt()
    End Sub
    Private Sub BarButtonItem3_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem3.ItemClick
        stok_sil()
    End Sub
    Private Sub BarButtonItem5_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem5.ItemClick
        analiz_envanter()
    End Sub
    Private Sub BarButtonItem6_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem6.ItemClick
        analiz_stok_hareket()
    End Sub
    Private Sub BarButtonItem7_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem7.ItemClick
        analiz_hareket_transfer()
    End Sub
    Private Sub BarButtonItem8_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem8.ItemClick
        stok_fiyat()
    End Sub
    Private Sub btn_IhtiyacAra_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_IhtiyacAra.Click
        Label2.Text = Sorgu_sDil("Lütfen Bekleyiniz...", sDil)
        Label2.Refresh()
        lIhtiyac_belirle()
        Label2.Text = Sorgu_sDil("Tamamlandý...", sDil)
    End Sub
    Private Sub BarButtonItem9_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem9.ItemClick
        tbSiparisVer(2)
    End Sub
    Private Sub tbSiparisVer(ByVal nSiparisTipi As Integer)
        Dim dr As DataRow
        Dim dr1 As DataRow
        dr = GridView1.GetDataRow(GridView1.FocusedRowHandle)
        Dim frm As New frm_firma_liste
        frm.firmano = firmano
        frm.donemno = donemno
        frm.connection = connection
        frm.islemstatus = True
        frm.kullanici = kullanici
        Dim nFirmaID As Int64
        Dim sKodu As String = ""
        Dim lSiparisNo As Int64 = 0
        Dim sSatirAciklama As String = ""
        If frm.ShowDialog(Me) = Windows.Forms.DialogResult.OK Then
            dr1 = frm.GridView1.GetDataRow(frm.GridView1.FocusedRowHandle)
            nFirmaID = dr1("nFirmaID")
            sKodu = dr1("sKodu")
            lSiparisNo = sorgu_lSiparisNo(nSiparisTipi)
            'lbl_Firma.Text = dr1("sAciklama")
            'txt_musteriNo.EditValue = sKodu
            dr1 = Nothing
            Dim sayi As Integer = 0
            For Each dr In ds_tbStokTedarikcisi.Tables(0).Rows
                If dr("lIhtiyac") > 0 Then
                    Dim nSiparisID As Int64 = sorgu_nSiparisID()
                    sSatirAciklama = "Isk1:" & uzunluk_tamamla(FormatNumber(dr("ISK1"), 2), 5) & " Isk2:" & uzunluk_tamamla(FormatNumber(dr("ISK2"), 2), 5) & " Isk3:" & uzunluk_tamamla(FormatNumber(dr("ISK3"), 2), 5) & " Isk4:" & uzunluk_tamamla(FormatNumber(dr("ISK4"), 2), 5)
                    tbSiparis_kaydet_yeni(nSiparisID, nSiparisTipi, lSiparisNo, nFirmaID, dr("nStokID"), Today, Today, "", 0, "", dr("sNot"), "", dr("lIhtiyac"), dr("lBrutFiyat"), dr("lTutari"), "", 0, dr("nKdvOrani"), dr("nIskontoYuzdesi"), dr("lBrutTutar"), kullaniciadi, Now, 0, 0, "", 0, sSatirAciklama, 0, "", 0, 0, "")
                    sayi += 1
                End If
            Next
            If sayi > 0 Then
                Dim frm1 As New frm_tbSiparis
                frm1.firmano = firmano
                frm1.donemno = donemno
                frm1.connection = connection
                frm1.dteSiparisTarihi = Today
                frm1.lSiparisNo = lSiparisNo
                frm1.nFirmaID = nFirmaID
                'frm.txt_musteriNo.EditValue = dr("sFirmaKodu")
                frm1.sSiparisiAlan = ""
                frm1.sSiparisiVeren = ""
                frm1.nSiparisTipi = nSiparisTipi
                frm1.kullanici = kullanici
                frm1.islemstatus = True
                If yetki_kontrol(kullanici, frm1.Name) = True Then
                    frm1.ShowDialog()
                End If
                frm1.Close()
                frm1.Dispose()
                frm1 = Nothing
            End If
        End If
    End Sub
    Private Function uzunluk_tamamla(ByVal deger As String, ByVal uzunluk As Int64, Optional ByVal simge As String = "0") As String
        deger = FormatNumber(deger, 2)
        If Len(deger) < uzunluk Then
            Dim fark As Integer = uzunluk - Len(deger)
            Dim i As Integer
            For i = 1 To fark
                deger = deger.Insert(0, simge)
            Next
        End If
        Return deger
    End Function
    Public Function sorgu_nSiparisID() As Int64
        Dim kriter As String = ""
        'kriter = "WHERE (sKodu = '" & kod & "')  "
        Dim conn As New OleDb.OleDbConnection
        Dim cmd As New OleDb.OleDbCommand
        Dim adapter As New OleDb.OleDbDataAdapter
        'MsgBox(connection_resmi)
        conn.ConnectionString = connection
        cmd.Connection = conn
        conn.Open()
        cmd.CommandText = sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT     TOP 1 ISNULL(nSiparisID + 1, 1) AS nSiparisID FROM         tbSiparis ORDER BY nSiparisID DESC")
        Dim kayitsayisi = cmd.ExecuteScalar
        Return kayitsayisi
    End Function
    Public Function sorgu_lSiparisNo(ByVal nSiparisTipi As Integer) As Int64
        Dim kriter As String = ""
        'kriter = "WHERE (sKodu = '" & kod & "')  "
        Dim conn As New OleDb.OleDbConnection
        Dim cmd As New OleDb.OleDbCommand
        Dim adapter As New OleDb.OleDbDataAdapter
        'MsgBox(connection_resmi)
        conn.ConnectionString = connection
        cmd.Connection = conn
        conn.Open()
        If nSiparisTipi = 1 Then
            cmd.CommandText = sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT     ISNULL(lSonSiparisNo,1) as lSiparisNo FROM         tbParamAlSiparis")
        ElseIf nSiparisTipi = 2 Then
            cmd.CommandText = sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT     ISNULL(lSonSiparisNo,1) as lSiparisNo FROM         tbParamVerSiparis")
        ElseIf nSiparisTipi = 3 Then
            cmd.CommandText = sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT     ISNULL(lSonSiparisNo,1) as lSiparisNo FROM         tbParamVerSiparis")
        ElseIf nSiparisTipi = 4 Then
            cmd.CommandText = sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT     ISNULL(lSonSiparisNo,1) as lSiparisNo FROM         tbParamVerSiparis")
        Else
            cmd.CommandText = sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT     ISNULL(lSonSiparisNo,1) as lSiparisNo FROM         tbParamVerSiparis")
        End If
        Dim kayitsayisi = cmd.ExecuteScalar
        If kayitsayisi = 0 Then
            kayitsayisi = 1
        End If
        Return kayitsayisi
    End Function
    Private Sub tbSiparis_kaydet_yeni(ByVal nSiparisID As Int64, ByVal nSiparisTipi As Int64, ByVal lSiparisNo As Int64, ByVal nFirmaID As Int64, ByVal nStokID As Int64, ByVal dteSiparisTarihi As DateTime, ByVal dteTeslimTarihi As DateTime, ByVal sSiparisIslem As String, ByVal nReceteNo As Int64, ByVal sSiparisiAlan As String, ByVal sSiparisiVeren As String, ByVal sFiyatTipi As String, ByVal lMiktari As Decimal, ByVal lFiyati As Decimal, ByVal lTutari As Decimal, ByVal sAsortiTipi As String, ByVal sAsortiMiktari As String, ByVal nKdvOrani As Int64, ByVal nIskontoYuzdesi As Int64, ByVal lIskontosuzTutari As Decimal, ByVal sKullaniciAdi As String, ByVal dteKayitTarihi As DateTime, ByVal bKapandimi As Integer, ByVal lReserveMiktari As Decimal, ByVal sHangiUygulama As String, ByVal nPartiID As Int64, ByVal sSatirAciklama As String, ByVal nValorGun As Int64, ByVal sDovizCinsi As String, ByVal lDovizFiyati As Decimal, ByVal lDovizKuru As Decimal, ByVal sSaticiRumuzu As String)
        Dim con As New OleDb.OleDbConnection
        Dim cmd As New OleDb.OleDbCommand
        cmd.Connection = con
        con.ConnectionString = connection
        If con.State = ConnectionState.Closed = True Then
            con.Open()
        End If
        'sSiparisiAlan = degeruzunlukkontrol(sSiparisiAlan, 30).ToString + degeruzunlukkontrol(sSiparisiVeren, 30).ToString
        'cmd.CommandText = sorgu_query("SET DATEFORMAT DMY SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED INSERT INTO tbSiparis (nSiparisID, nSiparisTipi, lSiparisNo, nFirmaID, nStokID, dteSiparisTarihi, dteTeslimTarihi, sSiparisIslem, nReceteNo, sSiparisiAlan, sSiparisiVeren, sFiyatTipi, lMiktari, lFiyati, lTutari, sAsortiTipi, sAsortiMiktari, nKdvOrani, nIskontoYuzdesi, lIskontosuzTutari, sKullaniciAdi, dteKayitTarihi, bKapandimi, lReserveMiktari, sHangiUygulama, nPartiID, sSatirAciklama, nValorGun, sDovizCinsi, lDovizFiyati, lDovizKuru,sSaticiRumuzu) VALUES (" & nSiparisID & ", " & nSiparisTipi & ", " & lSiparisNo & ", " & nFirmaID & ", " & nStokID & ", '" & dteSiparisTarihi & "', '" & dteTeslimTarihi & "', '" & sSiparisIslem & "', " & nReceteNo & ", '" & sSiparisiAlan & "', '" & sSiparisiVeren & "', '" & sFiyatTipi & "', " & lMiktari & ", " & lFiyati & ", " & lTutari & ", '" & sAsortiTipi & "', " & sAsortiMiktari & ", " & nKdvOrani & ", " & nIskontoYuzdesi & ", " & lIskontosuzTutari & ", '" & sKullaniciAdi & "', '" & dteKayitTarihi & "', " & bKapandimi & ", " & lReserveMiktari & ", '" & sHangiUygulama & "', " & nPartiID & ", '" & sSatirAciklama & "', " & nValorGun & ", '" & sDovizCinsi & "', " & lDovizFiyati & ", " & lDovizKuru & ",'" & sSaticiRumuzu & "')")
        cmd.CommandText = sorgu_query("SET DATEFORMAT DMY SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED INSERT INTO tbSiparis (nSiparisTipi, lSiparisNo, nFirmaID, nStokID, dteSiparisTarihi, dteTeslimTarihi, sSiparisIslem, nReceteNo, sSiparisiAlan, sSiparisiVeren, sFiyatTipi, lMiktari, lFiyati, lTutari, sAsortiTipi, sAsortiMiktari, nKdvOrani, nIskontoYuzdesi, lIskontosuzTutari, sKullaniciAdi, dteKayitTarihi, bKapandimi, lReserveMiktari, sHangiUygulama, nPartiID, sSatirAciklama, nValorGun, sDovizCinsi, lDovizFiyati, lDovizKuru,sSaticiRumuzu) VALUES (" & nSiparisTipi & ", " & lSiparisNo & ", " & nFirmaID & ", " & nStokID & ", '" & dteSiparisTarihi & "', '" & dteTeslimTarihi & "', '" & sSiparisIslem & "', " & nReceteNo & ", '" & sSiparisiAlan & "', '" & sSiparisiVeren & "', '" & sFiyatTipi & "', " & lMiktari & ", " & lFiyati & ", " & lTutari & ", '" & sAsortiTipi & "', " & sAsortiMiktari & ", " & nKdvOrani & ", " & nIskontoYuzdesi & ", " & lIskontosuzTutari & ", '" & sKullaniciAdi & "', '" & dteKayitTarihi & "', " & bKapandimi & ", " & lReserveMiktari & ", '" & sHangiUygulama & "', " & nPartiID & ", '" & sSatirAciklama & "', " & nValorGun & ", '" & sDovizCinsi & "', " & lDovizFiyati & ", " & lDovizKuru & ",'" & sSaticiRumuzu & "')")
        cmd.ExecuteNonQuery()
        con.Close()
        cmd = Nothing
        con = Nothing
    End Sub
    Private Sub BarButtonItem10_ItemClick(ByVal sender As Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem10.ItemClick
        tbSiparisVer(1)
    End Sub
    Private Sub sec_bIhtiyac_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles sec_bIhtiyac.CheckedChanged
        If sec_bIhtiyac.Checked = True Then
            GridView1.ClearColumnsFilter()
            GridView1.Columns("lIhtiyac").FilterInfo = New ColumnFilterInfo("[lIhtiyac] > 0 ")
        Else
            GridView1.ClearColumnsFilter()
        End If
    End Sub
End Class