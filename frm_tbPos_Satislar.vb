Imports Microsoft.Win32
Imports System.Windows.Forms
Imports DevExpress.XtraExport
Imports DevExpress.XtraGrid.Export
Imports DevExpress.XtraCharts
Imports DevExpress.XtraCharts.Wizard
Imports DevExpress.XtraCharts.Design
Imports Microsoft.VisualBasic
Imports DevExpress.XtraEditors
Public Class frm_tbPos_Satislar
    Public firmano
    Public donemno
    Public connection
    Public kullanici
    Private Sub frm_tbPos_Satislar_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            gorunum_yukle()
        Catch ex As Exception
        End Try
        ara()
        Me.WindowState = FormWindowState.Normal
    End Sub
    Private Sub gorunum_yazdir()
        If XtraTabControl1.SelectedTabPageIndex.ToString = 0 Then
            printlink1.CreateDocument(ps)
            ps.PreviewRibbonFormEx.Show()
        ElseIf XtraTabControl1.SelectedTabPageIndex.ToString = 1 Then
            If XtraTabControl2.SelectedTabPageIndex = 0 Then
                printlink2.CreateDocument(ps)
                ps.PreviewRibbonFormEx.Show()
            ElseIf XtraTabControl2.SelectedTabPageIndex = 1 Then
                printlink3.CreateDocument(ps)
                ps.PreviewRibbonFormEx.Show()
            End If
        End If
    End Sub
    Private Sub gorunum_kaydet()
        GridView1.SaveLayoutToRegistry("SOFTWARE\BusinessSmart\VIEW\POS\" & Me.Name.ToString & "")
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
        SimpleButton3.Text = Sorgu_sDil(SimpleButton3.Text, sDil)
        GridView1.RestoreLayoutFromRegistry("SOFTWARE\BusinessSmart\VIEW\POS\" & Me.Name.ToString & "")
    End Sub
    Private Sub ara()
        Label2.Text = Sorgu_sDil("Lütfen Bekleyiniz...", sDil)
        Label2.Refresh()
        dataload(kullanici, sec_sFisTipi.Text, sec_bKapali.Text, sec_iptal.Text, sec_nSinif.Text, txt_Sinif.Text)
        Label2.Text = Sorgu_sDil("Tamamlandý...", sDil)
    End Sub
    Private Sub ozet_ara()
        Label2.Text = Sorgu_sDil("Lütfen Bekleyiniz...", sDil)
        Label2.Refresh()
        dataload_ozet(kullanici)
        Label2.Text = Sorgu_sDil("Tamamlandý...", sDil)
    End Sub
    Private Sub dataload(ByVal sKullanici As String, ByVal sFisTipi As String, ByVal bKapali As String, ByVal bÝptal As String, ByVal nSinif As Integer, ByVal sSinif As String)
        DataSet1 = tbSatis(sKullanici, sFisTipi, bKapali, bÝptal, nSinif, sSinif)
        GridControl1.DataSource = DataSet1.Tables(0)
        GridControl1.DataMember = Nothing
        PanelControl3.Select()
        GridControl1.Focus()
        GridControl1.Select()
        GridView1.CollapseAllGroups()
        If GridView1.RowCount > 0 Then
            GridView1.ClearSelection()
            GridView1.FocusedRowHandle = GridView1.RowCount - 1
            GridView1.SelectRow(GridView1.FocusedRowHandle)
            GridControl1.Focus()
        End If
    End Sub
    Private Sub dataload_ozet(ByVal sKullanici As String)
        DataSet2 = tbSatisOzet(sKullanici, sec_sTop.Text, txt_nTop.EditValue, sec_nSinifNo.Text, txt_sSinif.Text, sec_Siralama.Text, txt_sKodu.Text, sec_konum.Text)
        GridControl2.DataSource = DataSet2.Tables(0)
        GridControl2.DataMember = Nothing
        GridControl2.Focus()
        GridControl2.Select()
        GridView2.CollapseAllGroups()
        ChartControl1.DataSource = Nothing
        ChartControl1.DataSource = DataSet2.Tables(0)
        ChartControl1.Refresh()
        'If GridView1.RowCount > 0 Then
        '    GridView1.ClearSelection()
        '    GridView1.FocusedRowHandle = GridView1.RowCount - 1
        '    GridView1.SelectRow(GridView1.FocusedRowHandle)
        '    GridControl1.Focus()
        'End If
    End Sub
    Public Function tbSatis(ByVal sKullanici As String, ByVal sFisTipi As String, ByVal bKapali As String, ByVal bÝptal As String, ByVal nSinif As Integer, ByVal sSinif As String) As DataSet
        Dim conn As New OleDb.OleDbConnection
        Dim cmd As New OleDb.OleDbCommand
        Dim adapter As New OleDb.OleDbDataAdapter
        conn.ConnectionString = connection
        cmd.CommandTimeout = False
        adapter.SelectCommand = cmd
        Dim kriter As String = ""
        kriter = " Where lFisNo > 0"
        If sFisTipi = "[Tümü]" Then
        ElseIf sFisTipi = "Fiþ" Then
            kriter += " and sFisTipi ='P' and nFisGC =0 "
        ElseIf sFisTipi = "Fatura" Then
            kriter += " and sFisTipi ='K' and nFisGC =0"
        ElseIf sFisTipi = "Ýade" Then
            'kriter += " and sFisTipi ='P' and nFisGC =1"
            kriter += " and nFisGC =1 "
            bÝptal = "[Tümü]"
        End If
        If bKapali = "[Tümü]" Then
        ElseIf bKapali = "Açýk" Then
            kriter += " and bKapali=0 "
        ElseIf bKapali = "Kapalý" Then
            kriter += " and bKapali=1 "
        End If
        If bÝptal = "[Tümü]" Then
        ElseIf bÝptal = "Normal" Then
            kriter += " and nStatus = 0 "
        ElseIf bÝptal = "Ýptal" Then
            kriter += " and nStatus = 1 "
        End If
        If sSinif <> "" Then
            kriter = " and sSinif like '" & sSinif & "%' "
        End If
        cmd.CommandText = sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT * FROM (SELECT Satis.nAlisVerisID, Satis.sFisTipi, Satis.nStatus,Satis.bIskonto,Satis.nFisGC, Satis.dteFisTarihi, Satis.lFisNo, Satis.sSatir,Satis.sMagazaKodu, Satis.nGirisCikis, Satis.nStokID,Satis.sSaticiRumuzu, Satis.sKodu AS Plu, Stok.sKodu, Stok.sModel, Stok.sAciklama, Stok.sSinif,Satis.sKasiyerRumuzu, Satis.sKasaNo, Satis.lMiktar, Satis.sIskontoTipi, Satis.nIskontoYuzdesi, Satis.lIskontoTutari, Satis.lFiyat, Satis.lTutar, Satis.sKdvTipi, Satis.sOdemeKodu, Satis.lOdemeTutar, Satis.dteKayitTarihi, Satis.lNetTutar, tbKdv.nKdvOrani, Satis.lTutar - Satis.lTutar / ((100 + tbKdv.nKdvOrani) / 100) AS lKdvTutari, Musteri.nMusteriNo, Musteri.sAdi,Satis.bKapali FROM (SELECT     RIGHT(tbStok.nStokID, 6) AS nStokID, tbStok.sKodu, tbStok.sModel, tbStok.sAciklama, tbSSinif" & nSinif & ".sAciklama AS sSinif FROM         tbSSinif" & nSinif & " INNER JOIN tbStokSinifi ON tbSSinif" & nSinif & ".sSinifKodu = tbStokSinifi.sSinifKodu" & nSinif & " RIGHT OUTER JOIN tbStok ON tbStokSinifi.nStokID = tbStok.nStokID) Stok RIGHT OUTER JOIN BTBLINTERSATIS Satis INNER JOIN tbKdv ON Satis.sKdvTipi = tbKdv.sKdvTipi LEFT OUTER JOIN (SELECT nMusteriID AS nMusteriNo , CAST(lKodu AS NVARCHAR(20)) AS nMusteriID , sAdi FROM tbMusteri) Musteri ON Satis.nMusteriID = Musteri.nMusteriID ON Stok.nStokID = Satis.nStokID WHERE (Satis.nGirisCikis NOT IN (8, 11, 30)) AND (Satis.sKullanici = " & sKullanici & ") ) tbSatis " & kriter & " ORDER BY nAlisVerisID,dteKayitTarihi,  sFisTipi,lFisNo, nGirisCikis, sSatir")
        cmd.Connection = conn
        conn.Open()
        Dim Datastoklar1 As New DataSet
        Dim N As Integer = adapter.Fill(Datastoklar1, "Table1")
        conn.Close()
        Return Datastoklar1
    End Function
    Public Function tbSatisOzet(ByVal sKullanici As String, ByVal Top As String, ByVal nTop As Integer, ByVal nSinifNo As Integer, ByVal sSinif As String, ByVal sSiralama As String, ByVal sKodu As String, ByVal sKonum As String) As DataSet
        Dim conn As New OleDb.OleDbConnection
        Dim cmd As New OleDb.OleDbCommand
        Dim adapter As New OleDb.OleDbDataAdapter
        conn.ConnectionString = connection
        cmd.CommandTimeout = False
        adapter.SelectCommand = cmd
        Dim kriter As String = ""
        Dim kriter_stok As String = ""
        Dim sTopkriter As String = ""
        If nTop > 0 Then
            sTopkriter = " TOP " & nTop & " "
        End If
        If sSinif <> "" Then
            kriter = " Where sSinif like '" & sSinif & "%' "
        End If
        If sKodu <> "" Then
            If sKonum = "Stok Kodu" Then
                kriter_stok = " AND Satis.lFisNo IN (SELECT BTBLINTERSATIS.lFisNo FROM BTBLINTERSATIS INNER JOIN tbStok ON BTBLINTERSATIS.nStokID = RIGHT (tbStok.nStokID, 6) WHERE (tbStok.sKodu LIKE '" & sKodu & "%')) "
            ElseIf sKonum = "Stok Adý" Then
                kriter_stok = " AND Satis.lFisNo IN (SELECT BTBLINTERSATIS.lFisNo FROM BTBLINTERSATIS INNER JOIN tbStok ON BTBLINTERSATIS.nStokID = RIGHT (tbStok.nStokID, 6) WHERE (tbStok.sAciklama LIKE '" & sKodu & "%')) "
            End If
        End If
        If Top = "Ýlk" Then
            If sSiralama = "Miktar" Then
                cmd.CommandText = sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT " & sTopkriter & " *,nOran = CASE WHEN lToplamMaliyet = 0 THEN 100 ELSE (lKar/lToplamMaliyet)*100 END FROM (SELECT  Satis.nStokID, Satis.sKodu AS Plu, Stok.sKodu, Stok.sModel, Stok.sAciklama, Stok.sSinif, SUM(Satis.lMiktar) AS lMiktar, lFiyat = CASE WHEN SUM(Satis.lMiktar) = 0  THEN 0 ELSE SUM(Satis.lTutar) / SUM(Satis.lMiktar) END,SUM(Satis.lIskontoTutari) AS lIskontoTutari, SUM(Satis.lTutar) AS lTutar, SUM(Satis.lMiktar * Stok.lMaliyet) as lToplamMaliyet,SUM(Satis.lTutar)- SUM(Satis.lMiktar * Stok.lMaliyet) as lKar,COUNT(DISTINCT lFisNo) as nFis,Satis.sKdvTipi, tbKdv.nKdvOrani, SUM(Satis.lTutar - Satis.lTutar / ((100 + tbKdv.nKdvOrani) / 100)) AS lKdvTutari FROM (SELECT RIGHT (tbStok.nStokID , 6) AS nStokID , tbStok.sKodu , tbStok.sModel , tbStok.sAciklama ,ISNULL((SELECT isnull(lfiyat , 0) FROM tbstokfiyati WHERE nStokId = tbStok.NstokId AND sFiyatTipi = '" & sFiyatM & "'),0) AS lMaliyet, (SELECT isnull(SUM(tbStokFisiDetayi.lGirisMiktar1 - tbStokFisiDetayi.lCikisMiktar1) , 0) FROM tbStokFisiDetayi WHERE tbStok.nStokID = tbStokFisiDetayi.nStokID ) AS Mevcut,tbSSinif" & nSinifNo & ".sAciklama AS sSinif FROM tbSSinif" & nSinifNo & " INNER JOIN tbStokSinifi ON tbSSinif" & nSinifNo & ".sSinifKodu = tbStokSinifi.sSinifKodu" & nSinifNo & " RIGHT OUTER JOIN tbStok ON tbStokSinifi.nStokID = tbStok.nStokID) Stok RIGHT OUTER JOIN BTBLINTERSATIS Satis INNER JOIN tbKdv ON Satis.sKdvTipi = tbKdv.sKdvTipi LEFT OUTER JOIN (SELECT nMusteriID AS nMusteriNo , CAST(lKodu AS NVARCHAR(20)) AS nMusteriID , sAdi FROM tbMusteri) Musteri ON Satis.nMusteriID = Musteri.nMusteriID ON Stok.nStokID = Satis.nStokID WHERE (Satis.nGirisCikis NOT IN (8, 11, 30)) AND (Satis.sKullanici = '" & sKullanici & "') AND (Stok.nStokID <> 0) and (Satis.nStatus = 0) " & kriter_stok & " GROUP BY Satis.nStokID, Satis.sKodu, Stok.sKodu, Stok.sModel, Stok.sAciklama, Stok.sSinif, Satis.sKdvTipi, tbKdv.nKdvOrani) tbSatis " & kriter & " ORDER BY lMiktar DESC ")
            ElseIf sSiralama = "Tutar" Then
                cmd.CommandText = sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT " & sTopkriter & " *,nOran = CASE WHEN lToplamMaliyet = 0 THEN 100 ELSE (lKar/lToplamMaliyet)*100 END FROM (SELECT  Satis.nStokID, Satis.sKodu AS Plu, Stok.sKodu, Stok.sModel, Stok.sAciklama, Stok.sSinif, SUM(Satis.lMiktar) AS lMiktar, lFiyat = CASE WHEN SUM(Satis.lMiktar) = 0  THEN 0 ELSE SUM(Satis.lTutar) / SUM(Satis.lMiktar) END,SUM(Satis.lIskontoTutari) AS lIskontoTutari, SUM(Satis.lTutar) AS lTutar, SUM(Satis.lMiktar * Stok.lMaliyet) as lToplamMaliyet,SUM(Satis.lTutar)- SUM(Satis.lMiktar * Stok.lMaliyet) as lKar,COUNT(DISTINCT lFisNo) as nFis,Satis.sKdvTipi, tbKdv.nKdvOrani, SUM(Satis.lTutar - Satis.lTutar / ((100 + tbKdv.nKdvOrani) / 100)) AS lKdvTutari FROM (SELECT RIGHT (tbStok.nStokID , 6) AS nStokID , tbStok.sKodu , tbStok.sModel , tbStok.sAciklama ,ISNULL((SELECT isnull(lfiyat , 0) FROM tbstokfiyati WHERE nStokId = tbStok.NstokId AND sFiyatTipi = '" & sFiyatM & "'),0) AS lMaliyet, (SELECT isnull(SUM(tbStokFisiDetayi.lGirisMiktar1 - tbStokFisiDetayi.lCikisMiktar1) , 0) FROM tbStokFisiDetayi WHERE tbStok.nStokID = tbStokFisiDetayi.nStokID ) AS Mevcut,tbSSinif" & nSinifNo & ".sAciklama AS sSinif FROM tbSSinif" & nSinifNo & " INNER JOIN tbStokSinifi ON tbSSinif" & nSinifNo & ".sSinifKodu = tbStokSinifi.sSinifKodu" & nSinifNo & " RIGHT OUTER JOIN tbStok ON tbStokSinifi.nStokID = tbStok.nStokID) Stok RIGHT OUTER JOIN BTBLINTERSATIS Satis INNER JOIN tbKdv ON Satis.sKdvTipi = tbKdv.sKdvTipi LEFT OUTER JOIN (SELECT nMusteriID AS nMusteriNo , CAST(lKodu AS NVARCHAR(20)) AS nMusteriID , sAdi FROM tbMusteri) Musteri ON Satis.nMusteriID = Musteri.nMusteriID ON Stok.nStokID = Satis.nStokID WHERE (Satis.nGirisCikis NOT IN (8, 11, 30)) AND (Satis.sKullanici = '" & sKullanici & "') AND (Stok.nStokID <> 0) and (Satis.nStatus = 0) " & kriter_stok & " GROUP BY Satis.nStokID, Satis.sKodu, Stok.sKodu, Stok.sModel, Stok.sAciklama, Stok.sSinif, Satis.sKdvTipi, tbKdv.nKdvOrani) tbSatis " & kriter & " ORDER BY lTutar DESC ")
            ElseIf sSiralama = "Musteri" Then
                cmd.CommandText = sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT " & sTopkriter & " *,nOran = CASE WHEN lToplamMaliyet = 0 THEN 100 ELSE (lKar/lToplamMaliyet)*100 END FROM (SELECT  Satis.nStokID, Satis.sKodu AS Plu, Stok.sKodu, Stok.sModel, Stok.sAciklama, Stok.sSinif, SUM(Satis.lMiktar) AS lMiktar, lFiyat = CASE WHEN SUM(Satis.lMiktar) = 0  THEN 0 ELSE SUM(Satis.lTutar) / SUM(Satis.lMiktar) END,SUM(Satis.lIskontoTutari) AS lIskontoTutari, SUM(Satis.lTutar) AS lTutar, SUM(Satis.lMiktar * Stok.lMaliyet) as lToplamMaliyet,SUM(Satis.lTutar)- SUM(Satis.lMiktar * Stok.lMaliyet) as lKar,COUNT(DISTINCT lFisNo) as nFis,Satis.sKdvTipi, tbKdv.nKdvOrani, SUM(Satis.lTutar - Satis.lTutar / ((100 + tbKdv.nKdvOrani) / 100)) AS lKdvTutari FROM (SELECT RIGHT (tbStok.nStokID , 6) AS nStokID , tbStok.sKodu , tbStok.sModel , tbStok.sAciklama ,ISNULL((SELECT isnull(lfiyat , 0) FROM tbstokfiyati WHERE nStokId = tbStok.NstokId AND sFiyatTipi = '" & sFiyatM & "'),0) AS lMaliyet, (SELECT isnull(SUM(tbStokFisiDetayi.lGirisMiktar1 - tbStokFisiDetayi.lCikisMiktar1) , 0) FROM tbStokFisiDetayi WHERE tbStok.nStokID = tbStokFisiDetayi.nStokID ) AS Mevcut,tbSSinif" & nSinifNo & ".sAciklama AS sSinif FROM tbSSinif" & nSinifNo & " INNER JOIN tbStokSinifi ON tbSSinif" & nSinifNo & ".sSinifKodu = tbStokSinifi.sSinifKodu" & nSinifNo & " RIGHT OUTER JOIN tbStok ON tbStokSinifi.nStokID = tbStok.nStokID) Stok RIGHT OUTER JOIN BTBLINTERSATIS Satis INNER JOIN tbKdv ON Satis.sKdvTipi = tbKdv.sKdvTipi LEFT OUTER JOIN (SELECT nMusteriID AS nMusteriNo , CAST(lKodu AS NVARCHAR(20)) AS nMusteriID , sAdi FROM tbMusteri) Musteri ON Satis.nMusteriID = Musteri.nMusteriID ON Stok.nStokID = Satis.nStokID WHERE (Satis.nGirisCikis NOT IN (8, 11, 30)) AND (Satis.sKullanici = '" & sKullanici & "') AND (Stok.nStokID <> 0) and (Satis.nStatus = 0) " & kriter_stok & " GROUP BY Satis.nStokID, Satis.sKodu, Stok.sKodu, Stok.sModel, Stok.sAciklama, Stok.sSinif, Satis.sKdvTipi, tbKdv.nKdvOrani) tbSatis " & kriter & " ORDER BY nFis DESC ")
            ElseIf sSiralama = "Kar" Then
                cmd.CommandText = sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT " & sTopkriter & " *,nOran = CASE WHEN lToplamMaliyet = 0 THEN 100 ELSE (lKar/lToplamMaliyet)*100 END FROM (SELECT  Satis.nStokID, Satis.sKodu AS Plu, Stok.sKodu, Stok.sModel, Stok.sAciklama, Stok.sSinif, SUM(Satis.lMiktar) AS lMiktar, lFiyat = CASE WHEN SUM(Satis.lMiktar) = 0  THEN 0 ELSE SUM(Satis.lTutar) / SUM(Satis.lMiktar) END,SUM(Satis.lIskontoTutari) AS lIskontoTutari, SUM(Satis.lTutar) AS lTutar, SUM(Satis.lMiktar * Stok.lMaliyet) as lToplamMaliyet,SUM(Satis.lTutar)- SUM(Satis.lMiktar * Stok.lMaliyet) as lKar,COUNT(DISTINCT lFisNo) as nFis,Satis.sKdvTipi, tbKdv.nKdvOrani, SUM(Satis.lTutar - Satis.lTutar / ((100 + tbKdv.nKdvOrani) / 100)) AS lKdvTutari FROM (SELECT RIGHT (tbStok.nStokID , 6) AS nStokID , tbStok.sKodu , tbStok.sModel , tbStok.sAciklama ,ISNULL((SELECT isnull(lfiyat , 0) FROM tbstokfiyati WHERE nStokId = tbStok.NstokId AND sFiyatTipi = '" & sFiyatM & "'),0) AS lMaliyet, (SELECT isnull(SUM(tbStokFisiDetayi.lGirisMiktar1 - tbStokFisiDetayi.lCikisMiktar1) , 0) FROM tbStokFisiDetayi WHERE tbStok.nStokID = tbStokFisiDetayi.nStokID ) AS Mevcut,tbSSinif" & nSinifNo & ".sAciklama AS sSinif FROM tbSSinif" & nSinifNo & " INNER JOIN tbStokSinifi ON tbSSinif" & nSinifNo & ".sSinifKodu = tbStokSinifi.sSinifKodu" & nSinifNo & " RIGHT OUTER JOIN tbStok ON tbStokSinifi.nStokID = tbStok.nStokID) Stok RIGHT OUTER JOIN BTBLINTERSATIS Satis INNER JOIN tbKdv ON Satis.sKdvTipi = tbKdv.sKdvTipi LEFT OUTER JOIN (SELECT nMusteriID AS nMusteriNo , CAST(lKodu AS NVARCHAR(20)) AS nMusteriID , sAdi FROM tbMusteri) Musteri ON Satis.nMusteriID = Musteri.nMusteriID ON Stok.nStokID = Satis.nStokID WHERE (Satis.nGirisCikis NOT IN (8, 11, 30)) AND (Satis.sKullanici = '" & sKullanici & "') AND (Stok.nStokID <> 0) and (Satis.nStatus = 0) " & kriter_stok & " GROUP BY Satis.nStokID, Satis.sKodu, Stok.sKodu, Stok.sModel, Stok.sAciklama, Stok.sSinif, Satis.sKdvTipi, tbKdv.nKdvOrani) tbSatis " & kriter & " ORDER BY lKar DESC ")
            End If
            'cmd.CommandText = sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT " & sTopkriter & " *,nOran = CASE WHEN lToplamMaliyet = 0 THEN 100 ELSE (lKar/lToplamMaliyet)*100 END FROM (SELECT  Satis.nStokID, Satis.sKodu AS Plu, Stok.sKodu, Stok.sModel, Stok.sAciklama, Stok.sSinif, SUM(Satis.lMiktar) AS lMiktar, lFiyat = CASE WHEN SUM(Satis.lMiktar) = 0  THEN 0 ELSE SUM(Satis.lTutar) / SUM(Satis.lMiktar) END,SUM(Satis.lIskontoTutari) AS lIskontoTutari, SUM(Satis.lTutar) AS lTutar, SUM(Satis.lMiktar * Stok.lMaliyet) as lToplamMaliyet,SUM(Satis.lTutar)- SUM(Satis.lMiktar * Stok.lMaliyet) as lKar,COUNT(DISTINCT lFisNo) as nFis,Satis.sKdvTipi, tbKdv.nKdvOrani, SUM(Satis.lTutar - Satis.lTutar / ((100 + tbKdv.nKdvOrani) / 100)) AS lKdvTutari FROM (SELECT RIGHT (tbStok.nStokID , 6) AS nStokID , tbStok.sKodu , tbStok.sModel , tbStok.sAciklama ,ISNULL((SELECT isnull(lfiyat , 0) FROM tbstokfiyati WHERE nStokId = tbStok.NstokId AND sFiyatTipi = '" & sFiyatM & "'),0) AS lMaliyet, (SELECT isnull(SUM(tbStokFisiDetayi.lGirisMiktar1 - tbStokFisiDetayi.lCikisMiktar1) , 0) FROM tbStokFisiDetayi WHERE tbStok.nStokID = tbStokFisiDetayi.nStokID ) AS Mevcut,tbSSinif" & nSinifNo & ".sAciklama AS sSinif FROM tbSSinif" & nSinifNo & " INNER JOIN tbStokSinifi ON tbSSinif" & nSinifNo & ".sSinifKodu = tbStokSinifi.sSinifKodu" & nSinifNo & " RIGHT OUTER JOIN tbStok ON tbStokSinifi.nStokID = tbStok.nStokID) Stok RIGHT OUTER JOIN BTBLINTERSATIS Satis INNER JOIN tbKdv ON Satis.sKdvTipi = tbKdv.sKdvTipi LEFT OUTER JOIN (SELECT nMusteriID AS nMusteriNo , CAST(lKodu AS NVARCHAR(20)) AS nMusteriID , sAdi FROM tbMusteri) Musteri ON Satis.nMusteriID = Musteri.nMusteriID ON Stok.nStokID = Satis.nStokID WHERE (Satis.nGirisCikis NOT IN (8, 11, 30)) AND (Satis.sKullanici = '" & sKullanici & "') AND (Stok.nStokID <> 0) and (Satis.nStatus = 0) GROUP BY Satis.nStokID, Satis.sKodu, Stok.sKodu, Stok.sModel, Stok.sAciklama, Stok.sSinif, Satis.sKdvTipi, tbKdv.nKdvOrani) tbSatis " & kriter & " ORDER BY lMiktar DESC ")
            'cmd.CommandText = sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT " & sTopkriter & " * FROM (SELECT  Satis.nStokID, Satis.sKodu AS Plu, Stok.sKodu, Stok.sModel, Stok.sAciklama, Stok.sSinif, SUM(Satis.lMiktar) AS lMiktar, lFiyat = CASE WHEN SUM(Satis.lMiktar) = 0  THEN 0 ELSE SUM(Satis.lTutar) / SUM(Satis.lMiktar) END,SUM(Satis.lIskontoTutari) AS lIskontoTutari, SUM(Satis.lTutar) AS lTutar, SUM(Satis.lMiktar * Stok.lMaliyet) as lToplamMaliyet,SUM(Satis.lTutar)- SUM(Satis.lMiktar * Stok.lMaliyet) as lKar,COUNT(DISTINCT lFisNo) as nFis,Satis.sKdvTipi, tbKdv.nKdvOrani, SUM(Satis.lTutar - Satis.lTutar / ((100 + tbKdv.nKdvOrani) / 100)) AS lKdvTutari FROM (SELECT RIGHT (tbStok.nStokID , 6) AS nStokID , tbStok.sKodu , tbStok.sModel , tbStok.sAciklama ,ISNULL((SELECT isnull(lfiyat , 0) FROM tbstokfiyati WHERE nStokId = tbStok.NstokId AND sFiyatTipi = '" & sFiyatM & "'),0) AS lMaliyet, tbSSinif" & nSinifNo & ".sAciklama AS sSinif FROM tbSSinif" & nSinifNo & " INNER JOIN tbStokSinifi ON tbSSinif" & nSinifNo & ".sSinifKodu = tbStokSinifi.sSinifKodu" & nSinifNo & " RIGHT OUTER JOIN tbStok ON tbStokSinifi.nStokID = tbStok.nStokID) Stok RIGHT OUTER JOIN BTBLINTERSATIS Satis INNER JOIN tbKdv ON Satis.sKdvTipi = tbKdv.sKdvTipi LEFT OUTER JOIN (SELECT nMusteriID AS nMusteriNo , CAST(lKodu AS NVARCHAR(20)) AS nMusteriID , sAdi FROM tbMusteri) Musteri ON Satis.nMusteriID = Musteri.nMusteriID ON Stok.nStokID = Satis.nStokID WHERE (Satis.nGirisCikis NOT IN (8, 11, 30)) AND (Satis.sKullanici = '" & sKullanici & "') AND (Stok.nStokID <> 0) GROUP BY Satis.nStokID, Satis.sKodu, Stok.sKodu, Stok.sModel, Stok.sAciklama, Stok.sSinif, Satis.sKdvTipi, tbKdv.nKdvOrani) tbSatis " & kriter & " ORDER BY lMiktar DESC ")
        ElseIf Top = "Son" Then
            If sSiralama = "Miktar" Then
                cmd.CommandText = sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT " & sTopkriter & " *,nOran = CASE WHEN lToplamMaliyet = 0 THEN 100 ELSE (lKar/lToplamMaliyet)*100 END FROM (SELECT  Satis.nStokID, Satis.sKodu AS Plu, Stok.sKodu, Stok.sModel, Stok.sAciklama, Stok.sSinif, SUM(Satis.lMiktar) AS lMiktar, lFiyat = CASE WHEN SUM(Satis.lMiktar) = 0  THEN 0 ELSE SUM(Satis.lTutar) / SUM(Satis.lMiktar) END,SUM(Satis.lIskontoTutari) AS lIskontoTutari, SUM(Satis.lTutar) AS lTutar, SUM(Satis.lMiktar * Stok.lMaliyet) as lToplamMaliyet,SUM(Satis.lTutar)- SUM(Satis.lMiktar * Stok.lMaliyet) as lKar,COUNT(DISTINCT lFisNo) as nFis,Satis.sKdvTipi, tbKdv.nKdvOrani, SUM(Satis.lTutar - Satis.lTutar / ((100 + tbKdv.nKdvOrani) / 100)) AS lKdvTutari FROM (SELECT RIGHT (tbStok.nStokID , 6) AS nStokID , tbStok.sKodu , tbStok.sModel , tbStok.sAciklama ,ISNULL((SELECT isnull(lfiyat , 0) FROM tbstokfiyati WHERE nStokId = tbStok.NstokId AND sFiyatTipi = '" & sFiyatM & "'),0) AS lMaliyet, (SELECT isnull(SUM(tbStokFisiDetayi.lGirisMiktar1 - tbStokFisiDetayi.lCikisMiktar1) , 0) FROM tbStokFisiDetayi WHERE tbStok.nStokID = tbStokFisiDetayi.nStokID ) AS Mevcut,tbSSinif" & nSinifNo & ".sAciklama AS sSinif FROM tbSSinif" & nSinifNo & " INNER JOIN tbStokSinifi ON tbSSinif" & nSinifNo & ".sSinifKodu = tbStokSinifi.sSinifKodu" & nSinifNo & " RIGHT OUTER JOIN tbStok ON tbStokSinifi.nStokID = tbStok.nStokID) Stok RIGHT OUTER JOIN BTBLINTERSATIS Satis INNER JOIN tbKdv ON Satis.sKdvTipi = tbKdv.sKdvTipi LEFT OUTER JOIN (SELECT nMusteriID AS nMusteriNo , CAST(lKodu AS NVARCHAR(20)) AS nMusteriID , sAdi FROM tbMusteri) Musteri ON Satis.nMusteriID = Musteri.nMusteriID ON Stok.nStokID = Satis.nStokID WHERE (Satis.nGirisCikis NOT IN (8, 11, 30)) AND (Satis.sKullanici = '" & sKullanici & "') AND (Stok.nStokID <> 0) and (Satis.nStatus = 0) " & kriter_stok & " GROUP BY Satis.nStokID, Satis.sKodu, Stok.sKodu, Stok.sModel, Stok.sAciklama, Stok.sSinif, Satis.sKdvTipi, tbKdv.nKdvOrani) tbSatis " & kriter & " ORDER BY lMiktar ASC ")
            ElseIf sSiralama = "Tutar" Then
                cmd.CommandText = sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT " & sTopkriter & " *,nOran = CASE WHEN lToplamMaliyet = 0 THEN 100 ELSE (lKar/lToplamMaliyet)*100 END FROM (SELECT  Satis.nStokID, Satis.sKodu AS Plu, Stok.sKodu, Stok.sModel, Stok.sAciklama, Stok.sSinif, SUM(Satis.lMiktar) AS lMiktar, lFiyat = CASE WHEN SUM(Satis.lMiktar) = 0  THEN 0 ELSE SUM(Satis.lTutar) / SUM(Satis.lMiktar) END,SUM(Satis.lIskontoTutari) AS lIskontoTutari, SUM(Satis.lTutar) AS lTutar, SUM(Satis.lMiktar * Stok.lMaliyet) as lToplamMaliyet,SUM(Satis.lTutar)- SUM(Satis.lMiktar * Stok.lMaliyet) as lKar,COUNT(DISTINCT lFisNo) as nFis,Satis.sKdvTipi, tbKdv.nKdvOrani, SUM(Satis.lTutar - Satis.lTutar / ((100 + tbKdv.nKdvOrani) / 100)) AS lKdvTutari FROM (SELECT RIGHT (tbStok.nStokID , 6) AS nStokID , tbStok.sKodu , tbStok.sModel , tbStok.sAciklama ,ISNULL((SELECT isnull(lfiyat , 0) FROM tbstokfiyati WHERE nStokId = tbStok.NstokId AND sFiyatTipi = '" & sFiyatM & "'),0) AS lMaliyet, (SELECT isnull(SUM(tbStokFisiDetayi.lGirisMiktar1 - tbStokFisiDetayi.lCikisMiktar1) , 0) FROM tbStokFisiDetayi WHERE tbStok.nStokID = tbStokFisiDetayi.nStokID ) AS Mevcut,tbSSinif" & nSinifNo & ".sAciklama AS sSinif FROM tbSSinif" & nSinifNo & " INNER JOIN tbStokSinifi ON tbSSinif" & nSinifNo & ".sSinifKodu = tbStokSinifi.sSinifKodu" & nSinifNo & " RIGHT OUTER JOIN tbStok ON tbStokSinifi.nStokID = tbStok.nStokID) Stok RIGHT OUTER JOIN BTBLINTERSATIS Satis INNER JOIN tbKdv ON Satis.sKdvTipi = tbKdv.sKdvTipi LEFT OUTER JOIN (SELECT nMusteriID AS nMusteriNo , CAST(lKodu AS NVARCHAR(20)) AS nMusteriID , sAdi FROM tbMusteri) Musteri ON Satis.nMusteriID = Musteri.nMusteriID ON Stok.nStokID = Satis.nStokID WHERE (Satis.nGirisCikis NOT IN (8, 11, 30)) AND (Satis.sKullanici = '" & sKullanici & "') AND (Stok.nStokID <> 0) and (Satis.nStatus = 0) " & kriter_stok & " GROUP BY Satis.nStokID, Satis.sKodu, Stok.sKodu, Stok.sModel, Stok.sAciklama, Stok.sSinif, Satis.sKdvTipi, tbKdv.nKdvOrani) tbSatis " & kriter & " ORDER BY lTutar ASC ")
            ElseIf sSiralama = "Musteri" Then
                cmd.CommandText = sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT " & sTopkriter & " *,nOran = CASE WHEN lToplamMaliyet = 0 THEN 100 ELSE (lKar/lToplamMaliyet)*100 END FROM (SELECT  Satis.nStokID, Satis.sKodu AS Plu, Stok.sKodu, Stok.sModel, Stok.sAciklama, Stok.sSinif, SUM(Satis.lMiktar) AS lMiktar, lFiyat = CASE WHEN SUM(Satis.lMiktar) = 0  THEN 0 ELSE SUM(Satis.lTutar) / SUM(Satis.lMiktar) END,SUM(Satis.lIskontoTutari) AS lIskontoTutari, SUM(Satis.lTutar) AS lTutar, SUM(Satis.lMiktar * Stok.lMaliyet) as lToplamMaliyet,SUM(Satis.lTutar)- SUM(Satis.lMiktar * Stok.lMaliyet) as lKar,COUNT(DISTINCT lFisNo) as nFis,Satis.sKdvTipi, tbKdv.nKdvOrani, SUM(Satis.lTutar - Satis.lTutar / ((100 + tbKdv.nKdvOrani) / 100)) AS lKdvTutari FROM (SELECT RIGHT (tbStok.nStokID , 6) AS nStokID , tbStok.sKodu , tbStok.sModel , tbStok.sAciklama ,ISNULL((SELECT isnull(lfiyat , 0) FROM tbstokfiyati WHERE nStokId = tbStok.NstokId AND sFiyatTipi = '" & sFiyatM & "'),0) AS lMaliyet, (SELECT isnull(SUM(tbStokFisiDetayi.lGirisMiktar1 - tbStokFisiDetayi.lCikisMiktar1) , 0) FROM tbStokFisiDetayi WHERE tbStok.nStokID = tbStokFisiDetayi.nStokID ) AS Mevcut,tbSSinif" & nSinifNo & ".sAciklama AS sSinif FROM tbSSinif" & nSinifNo & " INNER JOIN tbStokSinifi ON tbSSinif" & nSinifNo & ".sSinifKodu = tbStokSinifi.sSinifKodu" & nSinifNo & " RIGHT OUTER JOIN tbStok ON tbStokSinifi.nStokID = tbStok.nStokID) Stok RIGHT OUTER JOIN BTBLINTERSATIS Satis INNER JOIN tbKdv ON Satis.sKdvTipi = tbKdv.sKdvTipi LEFT OUTER JOIN (SELECT nMusteriID AS nMusteriNo , CAST(lKodu AS NVARCHAR(20)) AS nMusteriID , sAdi FROM tbMusteri) Musteri ON Satis.nMusteriID = Musteri.nMusteriID ON Stok.nStokID = Satis.nStokID WHERE (Satis.nGirisCikis NOT IN (8, 11, 30)) AND (Satis.sKullanici = '" & sKullanici & "') AND (Stok.nStokID <> 0) and (Satis.nStatus = 0) " & kriter_stok & " GROUP BY Satis.nStokID, Satis.sKodu, Stok.sKodu, Stok.sModel, Stok.sAciklama, Stok.sSinif, Satis.sKdvTipi, tbKdv.nKdvOrani) tbSatis " & kriter & " ORDER BY nFis ASC ")
            ElseIf sSiralama = "Kar" Then
                cmd.CommandText = sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT " & sTopkriter & " *,nOran = CASE WHEN lToplamMaliyet = 0 THEN 100 ELSE (lKar/lToplamMaliyet)*100 END FROM (SELECT  Satis.nStokID, Satis.sKodu AS Plu, Stok.sKodu, Stok.sModel, Stok.sAciklama, Stok.sSinif, SUM(Satis.lMiktar) AS lMiktar, lFiyat = CASE WHEN SUM(Satis.lMiktar) = 0  THEN 0 ELSE SUM(Satis.lTutar) / SUM(Satis.lMiktar) END,SUM(Satis.lIskontoTutari) AS lIskontoTutari, SUM(Satis.lTutar) AS lTutar, SUM(Satis.lMiktar * Stok.lMaliyet) as lToplamMaliyet,SUM(Satis.lTutar)- SUM(Satis.lMiktar * Stok.lMaliyet) as lKar,COUNT(DISTINCT lFisNo) as nFis,Satis.sKdvTipi, tbKdv.nKdvOrani, SUM(Satis.lTutar - Satis.lTutar / ((100 + tbKdv.nKdvOrani) / 100)) AS lKdvTutari FROM (SELECT RIGHT (tbStok.nStokID , 6) AS nStokID , tbStok.sKodu , tbStok.sModel , tbStok.sAciklama ,ISNULL((SELECT isnull(lfiyat , 0) FROM tbstokfiyati WHERE nStokId = tbStok.NstokId AND sFiyatTipi = '" & sFiyatM & "'),0) AS lMaliyet, (SELECT isnull(SUM(tbStokFisiDetayi.lGirisMiktar1 - tbStokFisiDetayi.lCikisMiktar1) , 0) FROM tbStokFisiDetayi WHERE tbStok.nStokID = tbStokFisiDetayi.nStokID ) AS Mevcut,tbSSinif" & nSinifNo & ".sAciklama AS sSinif FROM tbSSinif" & nSinifNo & " INNER JOIN tbStokSinifi ON tbSSinif" & nSinifNo & ".sSinifKodu = tbStokSinifi.sSinifKodu" & nSinifNo & " RIGHT OUTER JOIN tbStok ON tbStokSinifi.nStokID = tbStok.nStokID) Stok RIGHT OUTER JOIN BTBLINTERSATIS Satis INNER JOIN tbKdv ON Satis.sKdvTipi = tbKdv.sKdvTipi LEFT OUTER JOIN (SELECT nMusteriID AS nMusteriNo , CAST(lKodu AS NVARCHAR(20)) AS nMusteriID , sAdi FROM tbMusteri) Musteri ON Satis.nMusteriID = Musteri.nMusteriID ON Stok.nStokID = Satis.nStokID WHERE (Satis.nGirisCikis NOT IN (8, 11, 30)) AND (Satis.sKullanici = '" & sKullanici & "') AND (Stok.nStokID <> 0) and (Satis.nStatus = 0) " & kriter_stok & " GROUP BY Satis.nStokID, Satis.sKodu, Stok.sKodu, Stok.sModel, Stok.sAciklama, Stok.sSinif, Satis.sKdvTipi, tbKdv.nKdvOrani) tbSatis " & kriter & " ORDER BY lKar ASC ")
            End If
            'cmd.CommandText = sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT " & sTopkriter & " *,nOran = CASE WHEN lToplamMaliyet = 0 THEN 100 ELSE (lKar/lToplamMaliyet)*100 END FROM (SELECT  Satis.nStokID, Satis.sKodu AS Plu, Stok.sKodu, Stok.sModel, Stok.sAciklama, Stok.sSinif, SUM(Satis.lMiktar) AS lMiktar, lFiyat = CASE WHEN SUM(Satis.lMiktar) = 0  THEN 0 ELSE SUM(Satis.lTutar) / SUM(Satis.lMiktar) END,SUM(Satis.lIskontoTutari) AS lIskontoTutari, SUM(Satis.lTutar) AS lTutar, SUM(Satis.lMiktar * Stok.lMaliyet) as lToplamMaliyet,SUM(Satis.lTutar)- SUM(Satis.lMiktar * Stok.lMaliyet) as lKar,COUNT(DISTINCT lFisNo) as nFis,Satis.sKdvTipi, tbKdv.nKdvOrani, SUM(Satis.lTutar - Satis.lTutar / ((100 + tbKdv.nKdvOrani) / 100)) AS lKdvTutari FROM (SELECT RIGHT (tbStok.nStokID , 6) AS nStokID , tbStok.sKodu , tbStok.sModel , tbStok.sAciklama , ISNULL((SELECT isnull(lfiyat , 0) FROM tbstokfiyati WHERE nStokId = tbStok.NstokId AND sFiyatTipi = '" & sFiyatM & "'),0) AS lMaliyet,(SELECT isnull(SUM(tbStokFisiDetayi.lGirisMiktar1 - tbStokFisiDetayi.lCikisMiktar1) , 0) FROM tbStokFisiDetayi WHERE tbStok.nStokID = tbStokFisiDetayi.nStokID ) AS Mevcut,tbSSinif" & nSinifNo & ".sAciklama AS sSinif FROM tbSSinif" & nSinifNo & " INNER JOIN tbStokSinifi ON tbSSinif" & nSinifNo & ".sSinifKodu = tbStokSinifi.sSinifKodu" & nSinifNo & " RIGHT OUTER JOIN tbStok ON tbStokSinifi.nStokID = tbStok.nStokID) Stok RIGHT OUTER JOIN BTBLINTERSATIS Satis INNER JOIN tbKdv ON Satis.sKdvTipi = tbKdv.sKdvTipi LEFT OUTER JOIN (SELECT nMusteriID AS nMusteriNo , CAST(lKodu AS NVARCHAR(20)) AS nMusteriID , sAdi FROM tbMusteri) Musteri ON Satis.nMusteriID = Musteri.nMusteriID ON Stok.nStokID = Satis.nStokID WHERE (Satis.nGirisCikis NOT IN (8, 11, 30)) AND (Satis.sKullanici = '" & sKullanici & "') AND (Stok.nStokID <> 0) and (Satis.nStatus = 0) GROUP BY Satis.nStokID, Satis.sKodu, Stok.sKodu, Stok.sModel, Stok.sAciklama, Stok.sSinif, Satis.sKdvTipi, tbKdv.nKdvOrani) tbSatis " & kriter & " ORDER BY lMiktar ASC ")
            'cmd.CommandText = sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT " & sTopkriter & " * FROM (SELECT  Satis.nStokID, Satis.sKodu AS Plu, Stok.sKodu, Stok.sModel, Stok.sAciklama, Stok.sSinif, SUM(Satis.lMiktar) AS lMiktar, lFiyat = CASE WHEN SUM(Satis.lMiktar) = 0  THEN 0 ELSE SUM(Satis.lTutar) / SUM(Satis.lMiktar) END,SUM(Satis.lIskontoTutari) AS lIskontoTutari, SUM(Satis.lTutar) AS lTutar, SUM(Satis.lMiktar * Stok.lMaliyet) as lToplamMaliyet,SUM(Satis.lTutar)- SUM(Satis.lMiktar * Stok.lMaliyet) as lKar,COUNT(DISTINCT lFisNo) as nFis,Satis.sKdvTipi, tbKdv.nKdvOrani, SUM(Satis.lTutar - Satis.lTutar / ((100 + tbKdv.nKdvOrani) / 100)) AS lKdvTutari FROM (SELECT RIGHT (tbStok.nStokID , 6) AS nStokID , tbStok.sKodu , tbStok.sModel , tbStok.sAciklama , ISNULL((SELECT isnull(lfiyat , 0) FROM tbstokfiyati WHERE nStokId = tbStok.NstokId AND sFiyatTipi = '" & sFiyatM & "'),0) AS lMaliyet,tbSSinif" & nSinifNo & ".sAciklama AS sSinif FROM tbSSinif" & nSinifNo & " INNER JOIN tbStokSinifi ON tbSSinif" & nSinifNo & ".sSinifKodu = tbStokSinifi.sSinifKodu" & nSinifNo & " RIGHT OUTER JOIN tbStok ON tbStokSinifi.nStokID = tbStok.nStokID) Stok RIGHT OUTER JOIN BTBLINTERSATIS Satis INNER JOIN tbKdv ON Satis.sKdvTipi = tbKdv.sKdvTipi LEFT OUTER JOIN (SELECT nMusteriID AS nMusteriNo , CAST(lKodu AS NVARCHAR(20)) AS nMusteriID , sAdi FROM tbMusteri) Musteri ON Satis.nMusteriID = Musteri.nMusteriID ON Stok.nStokID = Satis.nStokID WHERE (Satis.nGirisCikis NOT IN (8, 11, 30)) AND (Satis.sKullanici = '" & sKullanici & "') AND (Stok.nStokID <> 0) GROUP BY Satis.nStokID, Satis.sKodu, Stok.sKodu, Stok.sModel, Stok.sAciklama, Stok.sSinif, Satis.sKdvTipi, tbKdv.nKdvOrani) tbSatis " & kriter & " ORDER BY lMiktar ASC ")
        End If
        cmd.Connection = conn
        conn.Open()
        Dim Datastoklar1 As New DataSet
        Dim N As Integer = adapter.Fill(Datastoklar1, "Table1")
        conn.Close()
        Return Datastoklar1
    End Function
    Private Function sorgu(ByVal query As String) As DataSet
        Dim conn As New OleDb.OleDbConnection
        Dim adapter As New OleDb.OleDbDataAdapter
        Dim cmd As New OleDb.OleDbCommand
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
    Private Sub analiz_envanter()
        If GridView1.RowCount > 0 Then
            Dim dr As DataRow
            dr = GridView1.GetDataRow(GridView1.FocusedRowHandle)
            If XtraTabControl1.SelectedTabPageIndex.ToString = 0 Then
                dr = GridView1.GetDataRow(GridView1.FocusedRowHandle)
            ElseIf XtraTabControl1.SelectedTabPageIndex.ToString = 1 Then
                dr = GridView2.GetDataRow(GridView2.FocusedRowHandle)
            End If
            Dim frm As New frm_stok_envanter
            frm.firmano = firmano
            frm.donemno = donemno
            frm.connection = connection
            frm.stokno = "-2147" & dr("nStokID")
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
            If XtraTabControl1.SelectedTabPageIndex.ToString = 0 Then
                dr = GridView1.GetDataRow(GridView1.FocusedRowHandle)
            ElseIf XtraTabControl1.SelectedTabPageIndex.ToString = 1 Then
                dr = GridView2.GetDataRow(GridView2.FocusedRowHandle)
            End If
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
    Private Sub stok_duzelt()
        If GridView1.RowCount > 0 Then
            Dim dr As DataRow
            dr = GridView1.GetDataRow(GridView1.FocusedRowHandle)
            If XtraTabControl1.SelectedTabPageIndex.ToString = 0 Then
                dr = GridView1.GetDataRow(GridView1.FocusedRowHandle)
            ElseIf XtraTabControl1.SelectedTabPageIndex.ToString = 1 Then
                dr = GridView2.GetDataRow(GridView2.FocusedRowHandle)
            End If
            Dim frm As New frm_stok_kart
            frm.firmano = firmano
            frm.donemno = donemno
            frm.connection = connection
            frm.nStokID = "-2147" & dr("nStokID")
            frm.sKodu = dr("sKodu")
            frm.sModel = dr("sModel")
            frm.kullanici = kullanici
            If yetki_kontrol(kullanici, frm.Name) = True Then
                frm.ShowDialog()
            End If
            Dim satir = GridView1.FocusedRowHandle
            'dataload()
            GridView1.FocusedRowHandle = satir
            satir = Nothing
            frm.Close()
            frm.Dispose()
            frm = Nothing
        End If
    End Sub
    Private Sub stok_fiyat()
        If GridView1.RowCount > 0 Then
            Dim dr As DataRow
            dr = GridView1.GetDataRow(GridView1.FocusedRowHandle)
            If XtraTabControl1.SelectedTabPageIndex.ToString = 0 Then
                dr = GridView1.GetDataRow(GridView1.FocusedRowHandle)
            ElseIf XtraTabControl1.SelectedTabPageIndex.ToString = 1 Then
                dr = GridView2.GetDataRow(GridView2.FocusedRowHandle)
            End If
            Dim frm As New frm_stok_fiyatlandir
            frm.firmano = firmano
            frm.donemno = donemno
            frm.connection = connection
            frm.nStokID = "-2147" & dr("nStokID")
            frm.sModel = dr("sModel")
            frm.sKodu = dr("sKodu")
            frm.sRenk = ""
            frm.sBeden = ""
            frm.txt_musteriNo.Text = dr("sModel")
            frm.kullanici = kullanici
            If yetki_kontrol(kullanici, frm.Name) = True Then
                frm.ShowDialog()
            End If
            frm.Close()
            frm.Dispose()
            frm = Nothing
            Dim satir = GridView1.FocusedRowHandle
            ara()
            GridView1.FocusedRowHandle = satir
            satir = Nothing
        End If
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
    Private Sub calculator()
        Dim frm As New frm_calc
        frm.ShowDialog()
        frm.Close()
        frm = Nothing
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
    Private Sub SimpleButton2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SimpleButton2.Click
        Me.Close()
    End Sub
    Private Sub SimpleButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SimpleButton1.Click
        Me.Close()
    End Sub
    Private Sub GridControl1_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles GridControl1.KeyDown
        If e.KeyCode = Keys.Escape Then
            Me.Close()
        End If
    End Sub
    Private Sub MenuItem13_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem13.Click
        Me.Close()
    End Sub
    Private Sub MenuItem14_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem14.Click
        Me.Close()
    End Sub
    Private Sub MenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem1.Click
        If XtraTabControl1.SelectedTabPageIndex = 0 Then
            GridView1.ColumnsCustomization()
        ElseIf XtraTabControl1.SelectedTabPageIndex = 1 Then
            If XtraTabControl2.SelectedTabPageIndex = 0 Then
                GridView2.ColumnsCustomization()
            ElseIf XtraTabControl2.SelectedTabPageIndex = 1 Then
                degistir_grafik()
            End If
        End If
    End Sub
    Private Sub MenuItem3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem3.Click
        gorunum_kaydet()
    End Sub
    Private Sub MenuItem4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem4.Click
        gorunum_yazdir()
    End Sub
    Private Sub MenuItem17_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem17.Click
        If MenuItem17.Checked = False Then
            If XtraTabControl1.SelectedTabPageIndex.ToString = 0 Then
                GridView1.OptionsView.ShowFilterPanelMode = DevExpress.XtraGrid.Views.Base.ShowFilterPanelMode.Default
                GridView1.OptionsCustomization.AllowFilter = True
                GridView1.OptionsView.ShowAutoFilterRow = True
            ElseIf XtraTabControl1.SelectedTabPageIndex.ToString = 1 Then
                GridView2.OptionsView.ShowFilterPanelMode = DevExpress.XtraGrid.Views.Base.ShowFilterPanelMode.Default
                GridView2.OptionsCustomization.AllowFilter = True
                GridView2.OptionsView.ShowAutoFilterRow = True
            End If
            MenuItem17.Checked = True
        ElseIf MenuItem17.Checked = True Then
            If XtraTabControl1.SelectedTabPageIndex.ToString = 0 Then
                GridView1.OptionsView.ShowFilterPanelMode = DevExpress.XtraGrid.Views.Base.ShowFilterPanelMode.Never
                GridView1.OptionsCustomization.AllowFilter = False
                GridView1.OptionsView.ShowAutoFilterRow = False
            ElseIf XtraTabControl1.SelectedTabPageIndex.ToString = 1 Then
                GridView2.OptionsView.ShowFilterPanelMode = DevExpress.XtraGrid.Views.Base.ShowFilterPanelMode.Never
                GridView2.OptionsCustomization.AllowFilter = False
                GridView2.OptionsView.ShowAutoFilterRow = False
            End If
            MenuItem17.Checked = False
        End If
    End Sub
    Private Sub MenuItem5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem5.Click
        If XtraTabControl1.SelectedTabPageIndex.ToString = 0 Then
            GridView1.OptionsView.ShowFilterPanelMode = DevExpress.XtraGrid.Views.Base.ShowFilterPanelMode.Default
            GridView1.OptionsCustomization.AllowFilter = True
        ElseIf XtraTabControl1.SelectedTabPageIndex.ToString = 1 Then
            GridView2.OptionsView.ShowFilterPanelMode = DevExpress.XtraGrid.Views.Base.ShowFilterPanelMode.Default
            GridView2.OptionsCustomization.AllowFilter = True
        End If
    End Sub
    Private Sub MenuItem6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem6.Click
        If XtraTabControl1.SelectedTabPageIndex.ToString = 0 Then
            GridView1.OptionsView.ShowGroupPanel = True
            GridView1.OptionsCustomization.AllowGroup = True
        ElseIf XtraTabControl1.SelectedTabPageIndex.ToString = 1 Then
            GridView2.OptionsView.ShowGroupPanel = True
            GridView2.OptionsCustomization.AllowGroup = True
        End If
    End Sub
    Private Sub MenuItem7_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles MenuItem7.Click
        If XtraTabControl1.SelectedTabPageIndex.ToString = 0 Then
            GridView1.ExpandAllGroups()
        ElseIf XtraTabControl1.SelectedTabPageIndex.ToString = 1 Then
            GridView2.ExpandAllGroups()
        End If
    End Sub
    Private Sub MenuItem8_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles MenuItem8.Click
        If XtraTabControl1.SelectedTabPageIndex.ToString = 0 Then
            GridView1.CollapseAllGroups()
        ElseIf XtraTabControl1.SelectedTabPageIndex.ToString = 1 Then
            GridView2.CollapseAllGroups()
        End If
    End Sub
    Private Sub MenuItem9_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles MenuItem9.Click
        If Me.WindowState = FormWindowState.Normal Then
            Me.WindowState = FormWindowState.Maximized
        ElseIf Me.WindowState = FormWindowState.Maximized Then
            Me.WindowState = FormWindowState.Normal
        End If
    End Sub
    Private Sub MenuItem16_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem16.Click
        analiz_envanter()
    End Sub
    Private Sub MenuItem19_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem19.Click
        stok_duzelt()
    End Sub
    Private Sub MenuItem18_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem18.Click
        analiz_stok_hareket()
    End Sub
    Private Sub MenuItem22_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem22.Click
        If XtraMessageBox.Show(Sorgu_sDil("Sonuçlarý Excel Dosyasý Oluþturmak Ýstediðinize Emin misiniz...?", sDil), Sorgu_sDil("Dikkat", sDil), MessageBoxButtons.YesNo, MessageBoxIcon.Question) = MsgBoxResult.Yes Then
            SaveFileDialog1.Filter = "Excel Dosyalarý(*.xls) |*.xls"
            SaveFileDialog1.InitialDirectory = "c:\"
            SaveFileDialog1.FileName = "Report.xls"
            If SaveFileDialog1.ShowDialog = Windows.Forms.DialogResult.OK Then
                If XtraTabControl1.SelectedTabPageIndex.ToString = 0 Then
                    GridView1.ExportToXls(SaveFileDialog1.FileName.ToString)
                ElseIf XtraTabControl1.SelectedTabPageIndex.ToString = 1 Then
                    GridView2.ExportToXls(SaveFileDialog1.FileName.ToString)
                End If
            End If
        End If
    End Sub
    Private Sub MenuItem23_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles MenuItem23.Click
        If XtraMessageBox.Show(Sorgu_sDil("Sonuçlarý Text Dosyasý Oluþturmak Ýstediðinize Emin misiniz...?", sDil), Sorgu_sDil("Dikkat", sDil), MessageBoxButtons.YesNo, MessageBoxIcon.Question) = MsgBoxResult.Yes Then
            SaveFileDialog1.Filter = "Text Dosyalarý(*.txt) |*.txt"
            SaveFileDialog1.InitialDirectory = "c:\"
            SaveFileDialog1.FileName = "Report.txt"
            If SaveFileDialog1.ShowDialog = Windows.Forms.DialogResult.OK Then
                If XtraTabControl1.SelectedTabPageIndex.ToString = 0 Then
                    GridView1.ExportToText(SaveFileDialog1.FileName.ToString)
                ElseIf XtraTabControl1.SelectedTabPageIndex.ToString = 1 Then
                    GridView2.ExportToText(SaveFileDialog1.FileName.ToString)
                End If
            End If
        End If
    End Sub
    Private Sub MenuItem24_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem24.Click
        calculator()
    End Sub
    Private Sub XtraTabControl1_SelectedPageChanged(ByVal sender As Object, ByVal e As DevExpress.XtraTab.TabPageChangedEventArgs) Handles XtraTabControl1.SelectedPageChanged
        Try
            If XtraTabControl1.SelectedTabPageIndex.ToString = 0 Then
                'txt_stokkodu.Focus()
                'txt_stokkodu.SelectAll()
            ElseIf XtraTabControl1.SelectedTabPageIndex.ToString = 1 Then
                If GridView2.RowCount = 0 Then
                    dataload_ozet(kullanici)
                End If
            End If
        Catch ex As Exception
        End Try
    End Sub
    Private Sub btn_ara_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_ara.Click
        ozet_ara()
    End Sub
    Private Sub MenuItem25_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem25.Click
        stok_fiyat()
    End Sub
    Private Sub SimpleButton3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SimpleButton3.Click
        ara()
    End Sub
    Private Sub BarButtonItem1_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem1.ItemClick
        gorunum_yazdir()
    End Sub
    Private Sub BarButtonItem2_ItemClick(ByVal sender As Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem2.ItemClick
        raporla_excel()
    End Sub
    Private Sub BarButtonItem3_ItemClick(ByVal sender As Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem3.ItemClick
        raporla_text()
    End Sub
    Private Sub BarButtonItem4_ItemClick(ByVal sender As Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem4.ItemClick
        raporla_pdf()
    End Sub
    Private Sub degistir_grafik()
        ' Create a chart.
        'Dim Chart As New ChartControl
        ' Set its datasource.
        ' Note that you can also set any other specific options for the chart here.
        'Chart.DataSource = DataSet1.Tables(0)
        ' Run the chart's wizard.
        'ChartControl1.SeriesTemplate.ChangeView(ViewType.Pie)
        'ChartWizard.Run(Me.ChartControl1, Nothing, True)
        Dim chartWizard_Renamed As ChartWizard = New ChartWizard(Me.ChartControl1)
        chartWizard_Renamed.ShowDialog()
        If TypeOf ChartControl1.Series(0).View Is SeriesViewColorEachSupportBase Then
            chColorEach.Enabled = True
            chColorEach.Checked = CType(ChartControl1.Series(0).View, SeriesViewColorEachSupportBase).ColorEach
        ElseIf TypeOf ChartControl1.Series(0).View Is SeriesView3DColorEachSupportBase Then
            chColorEach.Enabled = True
            chColorEach.Checked = CType(ChartControl1.Series(0).View, SeriesView3DColorEachSupportBase).ColorEach
        Else
            ChartControl1.Series(0).Label.PointOptions.ValueNumericOptions.Format = NumericFormat.Percent
            chColorEach.Enabled = False
            chColorEach.Checked = False
        End If
        ' Create a form, add the chart to it, and display the form.
        'Dim Form1 As New Form
        'Form1.Controls.Add(Chart)
        'Form1.Show()
    End Sub
    Private Sub chColorEach_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles chColorEach.CheckedChanged
        If chColorEach.Enabled Then
            Dim series As Series
            For Each series In ChartControl1.Series
                If TypeOf ChartControl1.Series(0).View Is SeriesViewColorEachSupportBase Then
                    CType(ChartControl1.Series(0).View, SeriesViewColorEachSupportBase).ColorEach = chColorEach.Checked
                ElseIf TypeOf ChartControl1.Series(0).View Is SeriesView3DColorEachSupportBase Then
                    CType(ChartControl1.Series(0).View, SeriesView3DColorEachSupportBase).ColorEach = chColorEach.Checked
                End If
            Next series
        End If
    End Sub
    Private Sub sec_baslik_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles sec_baslik.CheckedChanged
        If sec_baslik.Checked = True Then
            ChartControl1.Series(0).Label.PointOptions.PointView = PointView.ArgumentAndValues
        ElseIf sec_baslik.Checked = False Then
            ChartControl1.Series(0).Label.PointOptions.PointView = PointView.Values
        End If
    End Sub
    Private Sub sec_renk_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles sec_renk.CheckedChanged
        If sec_renk.Checked = True Then
            ChartControl1.Series(0).Label.PointOptions.ValueNumericOptions.Format = NumericFormat.Percent
        ElseIf sec_renk.Checked = False Then
            ChartControl1.Series(0).Label.PointOptions.ValueNumericOptions.Format = NumericFormat.Number
        End If
    End Sub
    Private Sub GridView2_CustomDrawRowIndicator(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Grid.RowIndicatorCustomDrawEventArgs) Handles GridView2.CustomDrawRowIndicator
        If e.RowHandle >= 0 Then
            e.Info.DisplayText = e.RowHandle + 1
        Else
            e.Info.DisplayText = ""
        End If
    End Sub
End Class