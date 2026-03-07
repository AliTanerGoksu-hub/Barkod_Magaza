Imports Microsoft.Win32
Imports FastReport
Imports DevExpress.XtraEditors
Imports System.IO
Public Class frm_tbFirinServis_Liste
    Public sConnection
    Public nFirmaNo
    Public nDonemNo
    Public sKullanici
    Dim ds_tbHareketTipi As DataSet
    Dim ds_tbSatici As DataSet
    Dim ds_tbStokSinifi As DataSet
    Dim ds_tbGirisCikis As DataSet
    Dim DataSet1 As dataset
    Dim kapla As Boolean = True
    Dim nGirisCikis = 3

    Dim sorgu_txt_baslik As String = ""
    Dim sorgu_txt_hareket As String = ""
    Dim sorgu_txt_toplam As String = ""
    Dim sorgu_txt_firma As String = ""
    Dim bInfo As Boolean = False
    Dim nFontSize As Decimal = 8.25
    Dim ds_tbFisTipi As DataSet
    Private Sub GridControl1_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles GridControl1.DoubleClick
        fis_duzelt()
    End Sub
    Private Sub GridControl1_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles GridControl1.KeyDown
        If e.KeyCode = Keys.Escape Then
            If XtraMessageBox.Show(Sorgu_sDil("Ekraný Kapatmak Ýstediðinize Emin misiniz...?", sDil), Sorgu_sDil("Dikkat", sDil), MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
                Me.Close()
            End If
        End If
    End Sub
    Private Sub SimpleButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SimpleButton1.Click
        Me.Close()
    End Sub
    Private Sub SimpleButton2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SimpleButton2.Click
        Me.Close()
    End Sub
    Private Sub frm_tbFirinServis_Liste_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        dataload_tbHareketTipi()
        dataload_tbSaticiRumuzu()
        txt_dteFisTarihi1.EditValue = dteSistemTarihi
        txt_dteFisTarihi2.EditValue = dteSistemTarihi
        dataload_tbFisTipi()
        dataload_tbGirisCikis(nGirisCikis)
        Dataload_tbStokSinifi(sec_sFisTipi.EditValue)
        Try
            gorunum_yukle()
        Catch ex As Exception
        End Try
        PanelControl1.Focus()
        GroupControl1.Focus()
        GroupControl1.Select()
        ara()
    End Sub
    Private Sub dataload_tbHareketTipi()
        ds_tbHareketTipi = sorgu(sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT 'S' AS sServis, 'Sabah' AS sAciklama UNION ALL SELECT 'O' AS sServis, 'Oglen' AS sAciklama UNION ALL SELECT 'A' AS sServis, 'Aksam' AS sAciklama UNION ALL SELECT 'D' AS sServis, 'ServisDýþý' AS sAciklama"))
        sec_sHareketTipi.Properties.DataSource = ds_tbHareketTipi.Tables(0)
        'sec_sHareketTipi.ItemIndex = 1
    End Sub
    Private Sub dataload_tbSaticiRumuzu()
        ds_tbSatici = sorgu(sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT     sSinifKodu,sAciklama FROM         tbFSinif1"))
        sec_sDepo.Properties.DataSource = ds_tbSatici.Tables(0)
        'sec_sHareketTipi.ItemIndex = 1
    End Sub
    Private Sub dataload_tbFisTipi()
        ds_tbFisTipi = sorgu(sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT 'U ' AS sFisTipi, 'Uretim' AS sAciklama,1 AS nGirisCikis UNION ALL SELECT 'C ' AS sFisTipi, 'Cikis' AS sAciklama,3 AS nGirisCikis UNION ALL SELECT 'S ' AS sFisTipi, 'Servis' AS sAciklama,3 AS nGirisCikis "))
        sec_sFisTipi.Properties.DataSource = ds_tbFisTipi.Tables(0)
        'sec_sFisTipi.EditValue = sFisTipi
        sec_sFisTipi.ItemIndex = 3
    End Sub
    Private Sub dataload_tbGirisCikis(ByVal nGirisCikis As Int64)
        If kapla = False Then
            ds_tbGirisCikis = sorgu(sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT     nGirisCikis,sAciklama FROM         tbGirisCikis Where nGirisCikis = '" & nGirisCikis & "'"))
            sec_nGirisCikis.Properties.DataSource = ds_tbGirisCikis.Tables(0)
            sec_nGirisCikis.ItemIndex = 0
        ElseIf kapla = True Then
            If sec_sFisTipi.EditValue = "C " Or sec_sFisTipi.EditValue = "S " Then
                ds_tbGirisCikis = sorgu(sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT      3 AS nGirisCikis,'Cikis' as sAciklama"))
            ElseIf sec_sFisTipi.EditValue = "U " Then
                ds_tbGirisCikis = sorgu(sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT      1 AS nGirisCikis,'Giris' as sAciklama"))
            End If
            sec_nGirisCikis.Properties.DataSource = ds_tbGirisCikis.Tables(0)
            sec_nGirisCikis.EditValue = nGirisCikis
            sec_nGirisCikis.ItemIndex = 0
        End If
    End Sub
    Private Sub Dataload_tbStokSinifi(ByVal sFisTipi As String)
        Dim kriter As String = ""
        kriter += " SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED "
        kriter += " SELECT TOP 1 1 AS nSatir, tbFirin.Param.sFisTipi, tbStok.nStokID, tbStok.sKodu, tbStok.sAciklama, tbStok.sRenk, tbStok.sBeden, tbStok.nFiyatlandirma, tbStok.sModel, (SELECT isnull(SUM(tbStokFisiDetayi.lGirisMiktar1 - tbStokFisiDetayi.lCikisMiktar1) , 0) FROM tbStokFisiDetayi WHERE tbStok.nStokID = tbStokFisiDetayi.nStokID) AS Mevcut, ISNULL((SELECT isnull(lfiyat , 0) FROM tbstokfiyati WHERE nStokId = tbStok.NstokId AND sFiyatTipi = '" & sFiyat1 & "'), 0) AS FIYAT1, ISNULL((SELECT isnull(lfiyat , 0) FROM tbstokfiyati WHERE nStokId = tbStok.NstokId AND sFiyatTipi = '" & sFiyat2 & "'), 0) AS FIYAT2, ISNULL((SELECT isnull(lfiyat , 0) FROM tbstokfiyati WHERE nStokId = tbStok.NstokId AND sFiyatTipi = '" & sFiyat3 & "'), 0) AS FIYAT3 FROM tbFirinParam LEFT OUTER JOIN tbStok ON tbFirinParam.nStokID1 = tbStok.nStokID WHERE (tbFirinParam.sFisTipi = '" & sFisTipi & "') "
        kriter += " UNION ALL"
        kriter += " SELECT TOP 1 2 AS nSatir,tbFirin.Param.sFisTipi, tbStok.nStokID, tbStok.sKodu, tbStok.sAciklama, tbStok.sRenk, tbStok.sBeden, tbStok.nFiyatlandirma, tbStok.sModel, (SELECT isnull(SUM(tbStokFisiDetayi.lGirisMiktar1 - tbStokFisiDetayi.lCikisMiktar1) , 0) FROM tbStokFisiDetayi WHERE tbStok.nStokID = tbStokFisiDetayi.nStokID) AS Mevcut, ISNULL((SELECT isnull(lfiyat , 0) FROM tbstokfiyati WHERE nStokId = tbStok.NstokId AND sFiyatTipi = '" & sFiyat1 & "'), 0) AS FIYAT1, ISNULL((SELECT isnull(lfiyat , 0) FROM tbstokfiyati WHERE nStokId = tbStok.NstokId AND sFiyatTipi = '" & sFiyat2 & "'), 0) AS FIYAT2, ISNULL((SELECT isnull(lfiyat , 0) FROM tbstokfiyati WHERE nStokId = tbStok.NstokId AND sFiyatTipi = '" & sFiyat3 & "'), 0) AS FIYAT3 FROM tbFirinParam LEFT OUTER JOIN tbStok ON tbFirinParam.nStokID2 = tbStok.nStokID WHERE (tbFirinParam.sFisTipi = '" & sFisTipi & "') "
        kriter += " UNION ALL"
        kriter += " SELECT TOP 1 3 AS nSatir,tbFirin.Param.sFisTipi, tbStok.nStokID, tbStok.sKodu, tbStok.sAciklama, tbStok.sRenk, tbStok.sBeden, tbStok.nFiyatlandirma, tbStok.sModel, (SELECT isnull(SUM(tbStokFisiDetayi.lGirisMiktar1 - tbStokFisiDetayi.lCikisMiktar1) , 0) FROM tbStokFisiDetayi WHERE tbStok.nStokID = tbStokFisiDetayi.nStokID) AS Mevcut, ISNULL((SELECT isnull(lfiyat , 0) FROM tbstokfiyati WHERE nStokId = tbStok.NstokId AND sFiyatTipi = '" & sFiyat1 & "'), 0) AS FIYAT1, ISNULL((SELECT isnull(lfiyat , 0) FROM tbstokfiyati WHERE nStokId = tbStok.NstokId AND sFiyatTipi = '" & sFiyat2 & "'), 0) AS FIYAT2, ISNULL((SELECT isnull(lfiyat , 0) FROM tbstokfiyati WHERE nStokId = tbStok.NstokId AND sFiyatTipi = '" & sFiyat3 & "'), 0) AS FIYAT3 FROM tbFirinParam LEFT OUTER JOIN tbStok ON tbFirinParam.nStokID3 = tbStok.nStokID WHERE (tbFirinParam.sFisTipi = '" & sFisTipi & "') "
        kriter += " UNION ALL"
        kriter += " SELECT TOP 1 4 AS nSatir,tbFirin.Param.sFisTipi, tbStok.nStokID, tbStok.sKodu, tbStok.sAciklama, tbStok.sRenk, tbStok.sBeden, tbStok.nFiyatlandirma, tbStok.sModel, (SELECT isnull(SUM(tbStokFisiDetayi.lGirisMiktar1 - tbStokFisiDetayi.lCikisMiktar1) , 0) FROM tbStokFisiDetayi WHERE tbStok.nStokID = tbStokFisiDetayi.nStokID) AS Mevcut, ISNULL((SELECT isnull(lfiyat , 0) FROM tbstokfiyati WHERE nStokId = tbStok.NstokId AND sFiyatTipi = '" & sFiyat1 & "'), 0) AS FIYAT1, ISNULL((SELECT isnull(lfiyat , 0) FROM tbstokfiyati WHERE nStokId = tbStok.NstokId AND sFiyatTipi = '" & sFiyat2 & "'), 0) AS FIYAT2, ISNULL((SELECT isnull(lfiyat , 0) FROM tbstokfiyati WHERE nStokId = tbStok.NstokId AND sFiyatTipi = '" & sFiyat3 & "'), 0) AS FIYAT3 FROM tbFirinParam LEFT OUTER JOIN tbStok ON tbFirinParam.nStokID4 = tbStok.nStokID WHERE (tbFirinParam.sFisTipi = '" & sFisTipi & "') "
        kriter += " UNION ALL"
        kriter += " SELECT TOP 1 5 AS nSatir,tbFirin.Param.sFisTipi, tbStok.nStokID, tbStok.sKodu, tbStok.sAciklama, tbStok.sRenk, tbStok.sBeden, tbStok.nFiyatlandirma, tbStok.sModel, (SELECT isnull(SUM(tbStokFisiDetayi.lGirisMiktar1 - tbStokFisiDetayi.lCikisMiktar1) , 0) FROM tbStokFisiDetayi WHERE tbStok.nStokID = tbStokFisiDetayi.nStokID) AS Mevcut, ISNULL((SELECT isnull(lfiyat , 0) FROM tbstokfiyati WHERE nStokId = tbStok.NstokId AND sFiyatTipi = '" & sFiyat1 & "'), 0) AS FIYAT1, ISNULL((SELECT isnull(lfiyat , 0) FROM tbstokfiyati WHERE nStokId = tbStok.NstokId AND sFiyatTipi = '" & sFiyat2 & "'), 0) AS FIYAT2, ISNULL((SELECT isnull(lfiyat , 0) FROM tbstokfiyati WHERE nStokId = tbStok.NstokId AND sFiyatTipi = '" & sFiyat3 & "'), 0) AS FIYAT3 FROM tbFirinParam LEFT OUTER JOIN tbStok ON tbFirinParam.nStokID5 = tbStok.nStokID WHERE (tbFirinParam.sFisTipi = '" & sFisTipi & "') "
        kriter += " UNION ALL"
        kriter += " SELECT TOP 1 6 AS nSatir,tbFirin.Param.sFisTipi, tbStok.nStokID, tbStok.sKodu, tbStok.sAciklama, tbStok.sRenk, tbStok.sBeden, tbStok.nFiyatlandirma, tbStok.sModel, (SELECT isnull(SUM(tbStokFisiDetayi.lGirisMiktar1 - tbStokFisiDetayi.lCikisMiktar1) , 0) FROM tbStokFisiDetayi WHERE tbStok.nStokID = tbStokFisiDetayi.nStokID) AS Mevcut, ISNULL((SELECT isnull(lfiyat , 0) FROM tbstokfiyati WHERE nStokId = tbStok.NstokId AND sFiyatTipi = '" & sFiyat1 & "'), 0) AS FIYAT1, ISNULL((SELECT isnull(lfiyat , 0) FROM tbstokfiyati WHERE nStokId = tbStok.NstokId AND sFiyatTipi = '" & sFiyat2 & "'), 0) AS FIYAT2, ISNULL((SELECT isnull(lfiyat , 0) FROM tbstokfiyati WHERE nStokId = tbStok.NstokId AND sFiyatTipi = '" & sFiyat3 & "'), 0) AS FIYAT3 FROM tbFirinParam LEFT OUTER JOIN tbStok ON tbFirinParam.nStokID6 = tbStok.nStokID WHERE (tbFirinParam.sFisTipi = '" & sFisTipi & "') "
        kriter += " UNION ALL"
        kriter += " SELECT TOP 1 7 AS nSatir,tbFirin.Param.sFisTipi, tbStok.nStokID, tbStok.sKodu, tbStok.sAciklama, tbStok.sRenk, tbStok.sBeden, tbStok.nFiyatlandirma, tbStok.sModel, (SELECT isnull(SUM(tbStokFisiDetayi.lGirisMiktar1 - tbStokFisiDetayi.lCikisMiktar1) , 0) FROM tbStokFisiDetayi WHERE tbStok.nStokID = tbStokFisiDetayi.nStokID) AS Mevcut, ISNULL((SELECT isnull(lfiyat , 0) FROM tbstokfiyati WHERE nStokId = tbStok.NstokId AND sFiyatTipi = '" & sFiyat1 & "'), 0) AS FIYAT1, ISNULL((SELECT isnull(lfiyat , 0) FROM tbstokfiyati WHERE nStokId = tbStok.NstokId AND sFiyatTipi = '" & sFiyat2 & "'), 0) AS FIYAT2, ISNULL((SELECT isnull(lfiyat , 0) FROM tbstokfiyati WHERE nStokId = tbStok.NstokId AND sFiyatTipi = '" & sFiyat3 & "'), 0) AS FIYAT3 FROM tbFirinParam LEFT OUTER JOIN tbStok ON tbFirinParam.nStokID7 = tbStok.nStokID WHERE (tbFirinParam.sFisTipi = '" & sFisTipi & "') "
        kriter += " UNION ALL"
        kriter += " SELECT TOP 1 8 AS nSatir,tbFirin.Param.sFisTipi, tbStok.nStokID, tbStok.sKodu, tbStok.sAciklama, tbStok.sRenk, tbStok.sBeden, tbStok.nFiyatlandirma, tbStok.sModel, (SELECT isnull(SUM(tbStokFisiDetayi.lGirisMiktar1 - tbStokFisiDetayi.lCikisMiktar1) , 0) FROM tbStokFisiDetayi WHERE tbStok.nStokID = tbStokFisiDetayi.nStokID) AS Mevcut, ISNULL((SELECT isnull(lfiyat , 0) FROM tbstokfiyati WHERE nStokId = tbStok.NstokId AND sFiyatTipi = '" & sFiyat1 & "'), 0) AS FIYAT1, ISNULL((SELECT isnull(lfiyat , 0) FROM tbstokfiyati WHERE nStokId = tbStok.NstokId AND sFiyatTipi = '" & sFiyat2 & "'), 0) AS FIYAT2, ISNULL((SELECT isnull(lfiyat , 0) FROM tbstokfiyati WHERE nStokId = tbStok.NstokId AND sFiyatTipi = '" & sFiyat3 & "'), 0) AS FIYAT3 FROM tbFirinParam LEFT OUTER JOIN tbStok ON tbFirinParam.nStokID8 = tbStok.nStokID WHERE (tbFirinParam.sFisTipi = '" & sFisTipi & "') "
        kriter += " UNION ALL"
        kriter += " SELECT TOP 1 9 AS nSatir,tbFirin.Param.sFisTipi, tbStok.nStokID, tbStok.sKodu, tbStok.sAciklama, tbStok.sRenk, tbStok.sBeden, tbStok.nFiyatlandirma, tbStok.sModel, (SELECT isnull(SUM(tbStokFisiDetayi.lGirisMiktar1 - tbStokFisiDetayi.lCikisMiktar1) , 0) FROM tbStokFisiDetayi WHERE tbStok.nStokID = tbStokFisiDetayi.nStokID) AS Mevcut, ISNULL((SELECT isnull(lfiyat , 0) FROM tbstokfiyati WHERE nStokId = tbStok.NstokId AND sFiyatTipi = '" & sFiyat1 & "'), 0) AS FIYAT1, ISNULL((SELECT isnull(lfiyat , 0) FROM tbstokfiyati WHERE nStokId = tbStok.NstokId AND sFiyatTipi = '" & sFiyat2 & "'), 0) AS FIYAT2, ISNULL((SELECT isnull(lfiyat , 0) FROM tbstokfiyati WHERE nStokId = tbStok.NstokId AND sFiyatTipi = '" & sFiyat3 & "'), 0) AS FIYAT3 FROM tbFirinParam LEFT OUTER JOIN tbStok ON tbFirinParam.nStokID9 = tbStok.nStokID WHERE (tbFirinParam.sFisTipi = '" & sFisTipi & "') "
        kriter += " UNION ALL"
        kriter += " SELECT TOP 1 10 AS nSatir,tbFirin.Param.sFisTipi, tbStok.nStokID, tbStok.sKodu, tbStok.sAciklama, tbStok.sRenk, tbStok.sBeden, tbStok.nFiyatlandirma, tbStok.sModel, (SELECT isnull(SUM(tbStokFisiDetayi.lGirisMiktar1 - tbStokFisiDetayi.lCikisMiktar1) , 0) FROM tbStokFisiDetayi WHERE tbStok.nStokID = tbStokFisiDetayi.nStokID) AS Mevcut, ISNULL((SELECT isnull(lfiyat , 0) FROM tbstokfiyati WHERE nStokId = tbStok.NstokId AND sFiyatTipi = '" & sFiyat1 & "'), 0) AS FIYAT1, ISNULL((SELECT isnull(lfiyat , 0) FROM tbstokfiyati WHERE nStokId = tbStok.NstokId AND sFiyatTipi = '" & sFiyat2 & "'), 0) AS FIYAT2, ISNULL((SELECT isnull(lfiyat , 0) FROM tbstokfiyati WHERE nStokId = tbStok.NstokId AND sFiyatTipi = '" & sFiyat3 & "'), 0) AS FIYAT3 FROM tbFirinParam LEFT OUTER JOIN tbStok ON tbFirinParam.nStokID10 = tbStok.nStokID WHERE (tbFirinParam.sFisTipi = '" & sFisTipi & "') "
        ds_tbStokSinifi = sorgu(sorgu_query("" & kriter & ""))
        Dim dr2 As DataRow = ds_tbStokSinifi.Tables(0).Rows(0)
        Try
            collMiktar1.Caption = Trim(dr2("sAciklama"))
            collIade1.Caption = Trim(dr2("sAciklama")) & " Ýade"
            collFiyat1.Caption = Trim(dr2("sAciklama")) & " Fiyat"
        Catch ex As Exception
            collMiktar1.Caption = "Miktar1"
            collIade1.Caption = "Miktar1" & " Ýade"
            collFiyat1.Caption = "Miktar1" & " Fiyat"
        End Try
        Try
            dr2 = ds_tbStokSinifi.Tables(0).Rows(1)
            collMiktar2.Caption = Trim(dr2("sAciklama"))
            collIade2.Caption = Trim(dr2("sAciklama")) & " Ýade"
            collFiyat2.Caption = Trim(dr2("sAciklama")) & " Fiyat"
        Catch ex As Exception
            collMiktar2.Caption = "Miktar2"
            collIade2.Caption = "Miktar2" & " Ýade"
            collFiyat2.Caption = "Miktar2" & " Fiyat"
        End Try
        Try
            dr2 = ds_tbStokSinifi.Tables(0).Rows(2)
            collMiktar3.Caption = Trim(dr2("sAciklama"))
            collIade3.Caption = Trim(dr2("sAciklama")) & " Ýade"
            collFiyat3.Caption = Trim(dr2("sAciklama")) & " Fiyat"
        Catch ex As Exception
            collMiktar3.Caption = "Miktar3"
            collIade3.Caption = "Miktar3" & " Ýade"
            collFiyat3.Caption = "Miktar3" & " Fiyat"
        End Try
        Try
            dr2 = ds_tbStokSinifi.Tables(0).Rows(3)
            collMiktar4.Caption = Trim(dr2("sAciklama"))
            collIade4.Caption = Trim(dr2("sAciklama")) & " Ýade"
            collFiyat4.Caption = Trim(dr2("sAciklama")) & " Fiyat"
        Catch ex As Exception
            collMiktar4.Caption = "Miktar4"
            collIade4.Caption = "Miktar4" & " Ýade"
            collFiyat4.Caption = "Miktar4" & " Fiyat"
        End Try
        Try
            dr2 = ds_tbStokSinifi.Tables(0).Rows(4)
            collMiktar5.Caption = Trim(dr2("sAciklama"))
            collIade5.Caption = Trim(dr2("sAciklama")) & " Ýade"
            collFiyat5.Caption = Trim(dr2("sAciklama")) & " Fiyat"
        Catch ex As Exception
            collMiktar5.Caption = "Miktar5"
            collIade5.Caption = "Miktar5" & " Ýade"
            collFiyat5.Caption = "Miktar5" & " Fiyat"
        End Try
        Try
            dr2 = ds_tbStokSinifi.Tables(0).Rows(5)
            collMiktar6.Caption = Trim(dr2("sAciklama"))
            collIade6.Caption = Trim(dr2("sAciklama")) & " Ýade"
            collFiyat6.Caption = Trim(dr2("sAciklama")) & " Fiyat"
        Catch ex As Exception
            collMiktar6.Caption = "Miktar6"
            collIade6.Caption = "Miktar6" & " Ýade"
            collFiyat6.Caption = "Miktar6" & " Fiyat"
        End Try
        Try
            dr2 = ds_tbStokSinifi.Tables(0).Rows(6)
            collMiktar7.Caption = Trim(dr2("sAciklama"))
            collIade7.Caption = Trim(dr2("sAciklama")) & " Ýade"
            collFiyat7.Caption = Trim(dr2("sAciklama")) & " Fiyat"
        Catch ex As Exception
            collMiktar7.Caption = "Miktar7"
            collIade7.Caption = "Miktar7" & " Ýade"
            collFiyat7.Caption = "Miktar7" & " Fiyat"
        End Try
        Try
            dr2 = ds_tbStokSinifi.Tables(0).Rows(7)
            collMiktar8.Caption = Trim(dr2("sAciklama"))
            collIade8.Caption = Trim(dr2("sAciklama")) & " Ýade"
            collFiyat8.Caption = Trim(dr2("sAciklama")) & " Fiyat"
        Catch ex As Exception
            collMiktar8.Caption = "Miktar8"
            collIade8.Caption = "Miktar8" & " Ýade"
            collFiyat8.Caption = "Miktar8" & " Fiyat"
        End Try
        Try
            dr2 = ds_tbStokSinifi.Tables(0).Rows(8)
            collMiktar9.Caption = Trim(dr2("sAciklama"))
            collIade9.Caption = Trim(dr2("sAciklama")) & " Ýade"
            collFiyat9.Caption = Trim(dr2("sAciklama")) & " Fiyat"
        Catch ex As Exception
            collMiktar9.Caption = "Miktar9"
            collIade9.Caption = "Miktar9" & " Ýade"
            collFiyat9.Caption = "Miktar9" & " Fiyat"
        End Try
        Try
            dr2 = ds_tbStokSinifi.Tables(0).Rows(9)
            collMiktar10.Caption = Trim(dr2("sAciklama"))
            collIade10.Caption = Trim(dr2("sAciklama")) & " Ýade"
            collFiyat10.Caption = Trim(dr2("sAciklama")) & " Fiyat"
        Catch ex As Exception
            collMiktar10.Caption = "Miktar10"
            collIade10.Caption = "Miktar10" & " Ýade"
            collFiyat10.Caption = "Miktar10" & " Fiyat"
        End Try
        dr2 = Nothing
    End Sub
    Private Sub ara(Optional ByVal bListele As Boolean = True)
        bInfo = False
        Label2.Text = Sorgu_sDil("Lütfen Bekleyiniz...", sDil)
        Label2.Refresh()
        dataload(sec_sFisTipi.EditValue, sec_nGirisCikis.EditValue, txt_dteFisTarihi1.EditValue, txt_dteFisTarihi2.EditValue, txt_lFisNo1.EditValue, txt_lFisNo2.EditValue, txt_lNetTutar1.EditValue, txt_lNetTutar2.EditValue, sec_sDepo.EditValue, sec_sHareketTipi.EditValue, bListele)
        Label2.Text = Sorgu_sDil("Tamamlandý...", sDil)
        bInfo = True
    End Sub
    Private Sub dataload(ByVal sFisTipi As String, ByVal nGirisCikis As String, ByVal dteFisTarihi1 As DateTime, ByVal dteFisTarihi2 As DateTime, ByVal lFisNo1 As Int64, ByVal lFisNo2 As Int64, ByVal lNetTutar1 As Decimal, ByVal lNetTutar2 As Decimal, ByVal sDepo As String, ByVal sHareketTipi As String, Optional ByVal bListele As Boolean = True)
        DataSet1 = stok(sFisTipi, nGirisCikis, dteFisTarihi1, dteFisTarihi2, lFisNo1, lFisNo2, lNetTutar1, lNetTutar2, sDepo, sHareketTipi)
        GridControl1.DataSource = DataSet1.Tables(0)
        GridControl1.DataMember = Nothing
        PanelControl3.Select()
        GridControl1.Focus()
        GridControl1.Select()
        GridView1.CollapseAllGroups()
        If bListele = True Then
            If GridView1.RowCount > 0 Then
                GridView1.ClearSelection()
                GridView1.FocusedRowHandle = GridView1.RowCount - 1
                GridView1.SelectRow(GridView1.FocusedRowHandle)
                GridControl1.Focus()
            End If
        End If
    End Sub
    Public Function stok(ByVal sFisTipi As String, ByVal nGirisCikis As String, ByVal dteFisTarihi1 As DateTime, ByVal dteFisTarihi2 As DateTime, ByVal lFisNo1 As Int64, ByVal lFisNo2 As Int64, ByVal lNetTutar1 As Decimal, ByVal lNetTutar2 As Decimal, ByVal sDepo As String, ByVal sHareketTipi As String) As DataSet
        Dim kriter As String = "WHERE (Master.sFisTipi = '" & sFisTipi & "')"
        kriter += " AND Master.dteFisTarihi between '" & dteFisTarihi1 & "' and '" & dteFisTarihi2 & "' "
        kriter += " and Master.lFisNo between '" & lFisNo1 & "' and '" & lFisNo2 & "'"
        kriter += " and Detay.lTutar between '" & lNetTutar1 & "' and '" & lNetTutar2 & "'"
        'If Trim(sDepo) <> "" Then
        '    kriter += " And tbStokFisiDetayi.sDepo = '" & sDepo & "' "
        'End If
        If Trim(sHareketTipi) <> "" Then
            kriter += " And Master.sServis = '" & sHareketTipi & "' "
        End If
        If nGirisCikis > 0 Then
            kriter += " and Master.nGirisCikis =" & nGirisCikis & " "
        End If
        Dim conn As New OleDb.OleDbConnection
        Dim cmd As New OleDb.OleDbCommand
        Dim adapter As New OleDb.OleDbDataAdapter
        conn.ConnectionString = sConnection
        cmd.CommandTimeout = False
        adapter.SelectCommand = cmd
        cmd.CommandText = sorgu_query("SET DATEFORMAT DMY SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT * FROM tbFirinServisMaster Master INNER JOIN (SELECT nServisID , SUM(lMiktar1 - lIade1) AS lMiktar1 , SUM(lMiktar2 - lIade2) AS lMiktar2 , SUM(lMiktar3 - lIade3) AS lMiktar3 , SUM(lMiktar4 - lIade4) AS lMiktar4 , SUM(lMiktar5 - lIade5) AS lMiktar5 , SUM(lMiktar6 - lIade6) AS lMiktar6 , SUM(lMiktar7 - lIade7) AS lMiktar7 , SUM(lMiktar8 - lIade8) AS lMiktar8 , SUM(lMiktar9 - lIade9) AS lMiktar9 , SUM(lMiktar10 - lIade10) AS lMiktar10 , SUM(lTutar) AS lTutar , SUM(lTahsilat) AS lTahsilat FROM tbFirinServisDetay GROUP BY nServisID) Detay ON Master.nServisID = Detay.nServisID " & kriter & " ")
        cmd.Connection = conn
        conn.Open()
        Dim Datastoklar1 As New DataSet
        Dim N As Integer = adapter.Fill(Datastoklar1, "Table1")
        conn.Close()
        Return Datastoklar1
    End Function
    Private Function sorgu_query(ByVal query As String) As String
        query = Replace(query, "*!F", "F0" + nFirmaNo.ToString)
        query = Replace(query, "!D", "D000" + nDonemNo.ToString)
        Return query
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
                sayi = Nothing
            End If
        Catch ex As Exception
        End Try
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
        GridView1.RestoreLayoutFromRegistry("SOFTWARE\BusinessSmart\VIEW\MAGAZA\" & Me.Name.ToString & "")
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
    Private Function sorgu(ByVal query As String) As DataSet
        Dim con As New OleDb.OleDbConnection
        Dim cmd As New OleDb.OleDbCommand
        Dim adapter As New OleDb.OleDbDataAdapter
        con.ConnectionString = sConnection
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
    Private Sub tbFirinParam(ByVal sFisTipi As String)
        Dim frm As New frm_tbFirinParam
        frm.sConnection = sConnection
        frm.nFirmano = 100
        frm.nDonemno = 1
        frm.sKullanici = sKullanici
        frm.sFisTipi = sFisTipi
        frm.ShowDialog()
        frm.Close()
        frm.Dispose()
        frm = Nothing
    End Sub
    Private Sub tbFirinMusteriFiyat()
        Dim frm As New frm_tbFirinMusteriFiyat
        frm.sConnection = sConnection
        frm.nFirmano = 100
        frm.nDonemno = 1
        frm.sKullanici = sKullanici
        frm.ShowDialog()
        frm.Close()
        frm.Dispose()
        frm = Nothing
    End Sub
    Private Sub Fis_ekle()
        Dim frm As New frm_tbFirinServis
        frm.nFirmaNo = nFirmaNo
        frm.nDonemNo = nDonemNo
        frm.sConnection = sConnection
        frm.sKullanici = sKullanici
        frm.nServisID = 0
        frm.dteFisTarihi = Today
        frm.sSaticiRumuzu = "001"
        frm.sServis = "1"
        frm.FisTipi = sec_sFisTipi.EditValue
        frm.GirisCikis = sec_nGirisCikis.EditValue
        frm.yeni = True
        frm.lFisNo = 0
        frm.dteFisTarihi = Today
        'If yetki_kontrol(kullanici, frm.Name) = True Then
        frm.ShowDialog()
        'End If
        frm.Close()
        frm.Dispose()
        frm = Nothing
        ara()
    End Sub
    Private Sub fis_duzelt()
        If GridView1.RowCount > 0 Then
            Dim dr As DataRow = GridView1.GetDataRow(GridView1.FocusedRowHandle)
            Dim frm As New frm_tbFirinServis
            frm.nFirmaNo = nFirmaNo
            frm.nDonemNo = nDonemNo
            frm.sConnection = sConnection
            frm.lFisNo = dr("lFisNo")
            frm.dteFisTarihi = dr("dteFisTarihi")
            frm.nServisID = dr("nServisID")
            frm.sSaticiRumuzu = dr("sSaticiRumuzu")
            frm.sServis = dr("sServis")
            frm.FisTipi = dr("sFisTipi")
            frm.GirisCikis = dr("nGirisCikis")
            frm.sKullanici = sKullanici
            Dim satir = GridView1.FocusedRowHandle
            'If yetki_kontrol(kullanici, frm.Name) = True Then
            frm.ShowDialog()
            'End If
            frm.Close()
            frm = Nothing
            dr = Nothing
            ara(False)
            GridView1.FocusedRowHandle = satir
            satir = Nothing
        End If
    End Sub
    Private Sub raporla(ByVal rapor As Integer, ByVal islem As Integer)
        Dim file As String
        Dim kriter As String
        OpenFileDialog1.Title = "Rapor Seç..."
        OpenFileDialog1.Filter = "Rapor Dosyalarý (Form*.fr3) |Form*.fr3"
        OpenFileDialog1.FileName = "c:\Formlar\Raporlar\Firin\Form.fr3"
        OpenFileDialog1.InitialDirectory = "c:\Formlar\Raporlar\Firin"
        kriter = ""
        If OpenFileDialog1.ShowDialog = Windows.Forms.DialogResult.OK Then
            file = OpenFileDialog1.FileName.ToString
            report_create_stok(file, kriter, islem)
        End If
        file = Nothing
        kriter = Nothing
    End Sub
    Private Sub report_create_stok(ByVal dosya As String, ByVal kriter As String, ByVal status As Integer)
        Dim stokno = 0
        Dim satir_line = "100"
        If IntPtr.Size = 4 Then
            '32 Bit
            Dim frx As New TfrxReportClass
            Dim qr_hareket As New TfrxADOQuery
            Dim qr_baslik As New TfrxADOQuery
            Dim qr_toplam As New TfrxADOQuery
            Dim qr_girdi As New TfrxADOQuery
            Dim qr_cikti As New TfrxADOQuery
            frx.Resources.LoadLanguageResourcesFromFile("C:\Program Files\FastReports\FastReport Studio\bin\turkish.frc")
            frx.LoadReportFromFile(dosya)
            frx.SetVariable("FIRMANO", "" & nFirmaNo & "")
            frx.SetVariable("DONEMNO", "" & nDonemNo & "")
            frx.SetVariable("STOKNO", "" & stokno & "")
            frx.SetVariable("SATIRLINE", "'" & satir_line & "'")
            frx.SetVariable("sMiktar1", "'" & collMiktar1.Caption & "'")
            frx.SetVariable("sMiktar2", "'" & collMiktar2.Caption & "'")
            frx.SetVariable("sMiktar3", "'" & collMiktar3.Caption & "'")
            frx.SetVariable("sMiktar4", "'" & collMiktar4.Caption & "'")
            frx.SetVariable("sMiktar5", "'" & collMiktar5.Caption & "'")
            frx.SetVariable("sMiktar6", "'" & collMiktar6.Caption & "'")
            frx.SetVariable("sMiktar7", "'" & collMiktar7.Caption & "'")
            frx.SetVariable("sMiktar8", "'" & collMiktar8.Caption & "'")
            frx.SetVariable("sMiktar9", "'" & collMiktar9.Caption & "'")
            frx.SetVariable("sMiktar10", "'" & collMiktar10.Caption & "'")
            frx.SetVariable("sFisTipi", "'" & Me.Text & "'")
            Dim skriter1 As String = "WHERE (Master.sFisTipi = 'U')"
            Dim skriter2 As String = "WHERE (Master.sFisTipi = 'C')"
            Dim skriter3 As String = "WHERE (Master.sFisTipi = 'S')"
            skriter1 += " AND Master.dteFisTarihi between '" & txt_dteFisTarihi1.EditValue & "' and '" & txt_dteFisTarihi2.EditValue & "' "
            skriter2 += " AND Master.dteFisTarihi between '" & txt_dteFisTarihi1.EditValue & "' and '" & txt_dteFisTarihi2.EditValue & "' "
            skriter3 += " AND Master.dteFisTarihi between '" & txt_dteFisTarihi1.EditValue & "' and '" & txt_dteFisTarihi2.EditValue & "' "
            qr_girdi = frx.FindObject("qr_girdi")
            qr_girdi.Query = sorgu_query("SET DATEFORMAT DMY SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT * FROM tbFirinServisMaster Master INNER JOIN (SELECT nServisID , SUM(lMiktar1 - lIade1) AS lMiktar1 , SUM(lMiktar2 - lIade2) AS lMiktar2 , SUM(lMiktar3 - lIade3) AS lMiktar3 , SUM(lMiktar4 - lIade4) AS lMiktar4 , SUM(lMiktar5 - lIade5) AS lMiktar5 , SUM(lMiktar6 - lIade6) AS lMiktar6 , SUM(lMiktar7 - lIade7) AS lMiktar7 , SUM(lMiktar8 - lIade8) AS lMiktar8 , SUM(lMiktar9 - lIade9) AS lMiktar9 , SUM(lMiktar10 - lIade10) AS lMiktar10 , SUM(lTutar) AS lTutar , SUM(lTahsilat) AS lTahsilat FROM tbFirinServisDetay GROUP BY nServisID) Detay ON Master.nServisID = Detay.nServisID " & skriter1 & " ")
            qr_cikti = frx.FindObject("qr_cikti")
            qr_cikti.Query = sorgu_query("SET DATEFORMAT DMY SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT * FROM tbFirinServisMaster Master INNER JOIN (SELECT nServisID , SUM(lMiktar1 - lIade1) AS lMiktar1 , SUM(lMiktar2 - lIade2) AS lMiktar2 , SUM(lMiktar3 - lIade3) AS lMiktar3 , SUM(lMiktar4 - lIade4) AS lMiktar4 , SUM(lMiktar5 - lIade5) AS lMiktar5 , SUM(lMiktar6 - lIade6) AS lMiktar6 , SUM(lMiktar7 - lIade7) AS lMiktar7 , SUM(lMiktar8 - lIade8) AS lMiktar8 , SUM(lMiktar9 - lIade9) AS lMiktar9 , SUM(lMiktar10 - lIade10) AS lMiktar10 , SUM(lTutar) AS lTutar , SUM(lTahsilat) AS lTahsilat FROM tbFirinServisDetay GROUP BY nServisID) Detay ON Master.nServisID = Detay.nServisID " & skriter2 & " ")
            qr_baslik = frx.FindObject("qr_baslik")
            qr_baslik.Query = sorgu_query("SET DATEFORMAT DMY SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT TOP 1 * FROM tbFirinServisMaster Master INNER JOIN (SELECT nServisID , SUM(lMiktar1 - lIade1) AS lMiktar1 , SUM(lMiktar2 - lIade2) AS lMiktar2 , SUM(lMiktar3 - lIade3) AS lMiktar3 , SUM(lMiktar4 - lIade4) AS lMiktar4 , SUM(lMiktar5 - lIade5) AS lMiktar5 , SUM(lMiktar6 - lIade6) AS lMiktar6 , SUM(lMiktar7 - lIade7) AS lMiktar7 , SUM(lMiktar8 - lIade8) AS lMiktar8 , SUM(lMiktar9 - lIade9) AS lMiktar9 , SUM(lMiktar10 - lIade10) AS lMiktar10 , SUM(lTutar) AS lTutar , SUM(lTahsilat) AS lTahsilat FROM tbFirinServisDetay GROUP BY nServisID) Detay ON Master.nServisID = Detay.nServisID " & skriter3 & " ")
            qr_hareket = frx.FindObject("qr_hareket")
            qr_hareket.Query = sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT Detay.sFisTipi, Detay.nFirmaID, Detay.sKodu, Detay.sAciklama, SUM(Detay.lMiktar1) AS lMiktar1, SUM(Detay.lIade1) AS lIade1, SUM(Detay.lMiktar2) AS lMiktar2, SUM(Detay.lIade2) AS lIade2, SUM(Detay.lMiktar3) AS lMiktar3, SUM(Detay.lIade3) AS lIade3, SUM(Detay.lMiktar4) AS lMiktar4, SUM(Detay.lIade4) AS lIade4, SUM(Detay.lMiktar5) AS lMiktar5, SUM(Detay.lIade5) AS lIade5, SUM(Detay.lMiktar6) AS lMiktar6, SUM(Detay.lIade6) AS lIade6, SUM(Detay.lMiktar7) AS lMiktar7, SUM(Detay.lIade7) AS lIade7, SUM(Detay.lMiktar8) AS lMiktar8, SUM(Detay.lIade8) AS lIade8, SUM(Detay.lMiktar9) AS lMiktar9, SUM(Detay.lIade9) AS lIade9, SUM(Detay.lMiktar10) AS lMiktar10, SUM(Detay.lIade10) AS lIade10, SUM(Detay.lTutar) AS lTutar, SUM(Detay.lTahsilat) AS lTahsilat, (SELECT ISNULL(SUM(lBorcTutar - lAlacakTutar) , 0) AS lBakiye FROM tbFirmaHareketi WHERE nFirmaID = Detay.nFirmaID) AS lBakiye FROM tbFirinServisDetay Detay INNER JOIN tbFirinServisMaster Master ON Detay.nServisID = Master.nServisID " & skriter3 & " GROUP BY Detay.sFisTipi, Detay.nFirmaID, Detay.sKodu, Detay.sAciklama ORDER BY Detay.sFisTipi, Detay.nFirmaID, Detay.sKodu, Detay.sAciklama")
            qr_toplam = frx.FindObject("qr_toplam")
            qr_toplam.Query = sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT * FROM (SELECT SUM(lMiktar1) AS lMiktar1 , SUM(lMiktar2) AS lMiktar2 , SUM(lMiktar3) AS lMiktar3 , SUM(lMiktar4) AS lMiktar4 , SUM(lMiktar5) AS lMiktar5 , SUM(lMiktar6) AS lMiktar6 , SUM(lMiktar7) AS lMiktar7 , SUM(lMiktar8) AS lMiktar8 , SUM(lMiktar9) AS lMiktar9 , SUM(lMiktar10) AS lMiktar10 ,SUM(lIade1) AS lIade1 , SUM(lIade2) AS lIade2 , SUM(lIade3) AS lIade3 , SUM(lIade4) AS lIade4 , SUM(lIade5) AS lIade5 , SUM(lIade6) AS lIade6 , SUM(lIade7) AS lIade7 , SUM(lIade8) AS lIade8 , SUM(lIade9) AS lIade9 , SUM(lIade10) AS lIade10,SUM((lMiktar1 - lIade1) * (lFiyat1 - lFiyat1 * (nIskontoYuzdesi / 100))) AS lTutar1,SUM((lMiktar2 - lIade2) * (lFiyat2 - lFiyat2 * (nIskontoYuzdesi / 100))) AS lTutar2, SUM((lMiktar3 - lIade3) * (lFiyat3 - lFiyat3 * (nIskontoYuzdesi / 100))) AS lTutar3,SUM((lMiktar4 - lIade4) * (lFiyat4 - lFiyat4 * (nIskontoYuzdesi / 100))) AS lTutar4,SUM((lMiktar5 - lIade5) * (lFiyat5 - lFiyat5 * (nIskontoYuzdesi / 100))) AS lTutar5,SUM((lMiktar6 - lIade6) * (lFiyat6 - lFiyat6 * (nIskontoYuzdesi / 100))) AS lTutar6,SUM((lMiktar7 - lIade7) * (lFiyat7 - lFiyat7 * (nIskontoYuzdesi / 100))) AS lTutar7,SUM((lMiktar8 - lIade8) * (lFiyat8 - lFiyat8 * (nIskontoYuzdesi / 100))) AS lTutar8,SUM((lMiktar9 - lIade9) * (lFiyat9 - lFiyat9 * (nIskontoYuzdesi / 100))) AS lTutar9,SUM((lMiktar10 - lIade10) * (lFiyat10 - lFiyat10 * (nIskontoYuzdesi / 100))) AS lTutar10,SUM(lTutar) AS lTutar , SUM(lTahsilat) AS lTahsilat FROM tbFirinServisDetay Detay INNER JOIN tbFirinServisMaster Master ON Detay.nServisID = Master.nServisID " & skriter3 & " ) tbFirinServisDetay ")
            Dim qr_connection As New TfrxADODatabase
            qr_connection.ConnectionString = sConnection.ToString
            qr_connection.LoginPrompt = False
            qr_connection.CommandTimeout = Nothing
            qr_connection.Connected = True
            qr_baslik.DataBase = qr_connection
            qr_hareket.DataBase = qr_connection
            qr_toplam.DataBase = qr_connection
            qr_girdi.DataBase = qr_connection
            qr_cikti.DataBase = qr_connection
            'qr_pesinat = frx.FindObject("qr_pesinat")
            'qr_pesinat.Query = sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT     * FROM         tbOdeme WHERE     (nAlisverisID = '" & nAlisVerisID & "') AND (nOdemeKodu = 1) ORDER BY nOdemeID ")
            'qr_taksit = frx.FindObject("qr_taksit")
            'qr_taksit.Query = sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT     * FROM         tbTaksit WHERE     (nAlisverisID = '" & nAlisVerisID & "') ORDER BY nTaksitID ")
            frx.OldStyleProgress = True
            If status = 0 Then
                frx.PreviewOptions.ZoomMode = frxZoomMode.zm_PageWidth
                frx.DisableDialogs = True
                frx.OldStyleProgress = True
                frx.ShowReport()
            ElseIf status = 1 Then
                frx.PrepareReport(True)
                frx.PrintOptions.Collate = False
                frx.PrintOptions.Copies = 1
                frx.PrintReport()
            ElseIf status = 2 Then
                frx.DesignReport()
            ElseIf status = 3 Then
            End If
            qr_hareket = Nothing
            qr_connection = Nothing
        ElseIf IntPtr.Size = 8 Then
            '64 Bit
            Dim args(50) As String
            Dim processYol As String
            args(0) = "" & dosya & ""
            args(1) = "" & connection.ToString() & ""
            args(4) = "" & status.ToString() & ""
            args(5) = "15"
            args(6) = "FIRMANO"
            args(7) = "" & nFirmaNo.ToString() & ""
            args(8) = "DONEMNO"
            args(9) = "" & nDonemNo.ToString() & ""
            args(10) = "STOKNO"
            args(11) = "" & stokno.ToString() & ""
            args(12) = "SATIRLINE"
            args(13) = "'" & satir_line.ToString() & "'"
            args(14) = "sMiktar1"
            args(15) = "'" & collMiktar1.Caption & "'"
            args(16) = "sMiktar2"
            args(17) = "'" & collMiktar2.Caption & "'"
            args(18) = "sMiktar3"
            args(19) = "'" & collMiktar3.Caption & "'"
            args(20) = "sMiktar4"
            args(21) = "'" & collMiktar4.Caption & "'"
            args(22) = "sMiktar5"
            args(23) = "'" & collMiktar5.Caption & "'"
            args(24) = "sMiktar6"
            args(25) = "'" & collMiktar6.Caption & "'"
            args(26) = "sMiktar7"
            args(27) = "'" & collMiktar7.Caption & "'"
            args(28) = "sMiktar8"
            args(29) = "'" & collMiktar8.Caption & "'"
            args(30) = "sMiktar9"
            args(31) = "'" & collMiktar9.Caption & "'"
            args(32) = "sMiktar10"
            args(33) = "'" & collMiktar10.Caption & "'"
            args(34) = "sFisTipi"
            args(35) = "'" & Me.Text & "'"
            Dim skriter1 As String = "WHERE (Master.sFisTipi = 'U')"
            Dim skriter2 As String = "WHERE (Master.sFisTipi = 'C')"
            Dim skriter3 As String = "WHERE (Master.sFisTipi = 'S')"
            skriter1 += " AND Master.dteFisTarihi between '" & txt_dteFisTarihi1.EditValue & "' and '" & txt_dteFisTarihi2.EditValue & "' "
            skriter2 += " AND Master.dteFisTarihi between '" & txt_dteFisTarihi1.EditValue & "' and '" & txt_dteFisTarihi2.EditValue & "' "
            skriter3 += " AND Master.dteFisTarihi between '" & txt_dteFisTarihi1.EditValue & "' and '" & txt_dteFisTarihi2.EditValue & "' "
            args(2) = "" & sorgu_query("SET DATEFORMAT DMY SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT * FROM tbFirinServisMaster Master INNER JOIN (SELECT nServisID , SUM(lMiktar1 - lIade1) AS lMiktar1 , SUM(lMiktar2 - lIade2) AS lMiktar2 , SUM(lMiktar3 - lIade3) AS lMiktar3 , SUM(lMiktar4 - lIade4) AS lMiktar4 , SUM(lMiktar5 - lIade5) AS lMiktar5 , SUM(lMiktar6 - lIade6) AS lMiktar6 , SUM(lMiktar7 - lIade7) AS lMiktar7 , SUM(lMiktar8 - lIade8) AS lMiktar8 , SUM(lMiktar9 - lIade9) AS lMiktar9 , SUM(lMiktar10 - lIade10) AS lMiktar10 , SUM(lTutar) AS lTutar , SUM(lTahsilat) AS lTahsilat FROM tbFirinServisDetay GROUP BY nServisID) Detay ON Master.nServisID = Detay.nServisID " & skriter1 & " ") & "é" & sorgu_query("SET DATEFORMAT DMY SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT * FROM tbFirinServisMaster Master INNER JOIN (SELECT nServisID , SUM(lMiktar1 - lIade1) AS lMiktar1 , SUM(lMiktar2 - lIade2) AS lMiktar2 , SUM(lMiktar3 - lIade3) AS lMiktar3 , SUM(lMiktar4 - lIade4) AS lMiktar4 , SUM(lMiktar5 - lIade5) AS lMiktar5 , SUM(lMiktar6 - lIade6) AS lMiktar6 , SUM(lMiktar7 - lIade7) AS lMiktar7 , SUM(lMiktar8 - lIade8) AS lMiktar8 , SUM(lMiktar9 - lIade9) AS lMiktar9 , SUM(lMiktar10 - lIade10) AS lMiktar10 , SUM(lTutar) AS lTutar , SUM(lTahsilat) AS lTahsilat FROM tbFirinServisDetay GROUP BY nServisID) Detay ON Master.nServisID = Detay.nServisID " & skriter2 & " ") & "é" & sorgu_query("SET DATEFORMAT DMY SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT TOP 1 * FROM tbFirinServisMaster Master INNER JOIN (SELECT nServisID , SUM(lMiktar1 - lIade1) AS lMiktar1 , SUM(lMiktar2 - lIade2) AS lMiktar2 , SUM(lMiktar3 - lIade3) AS lMiktar3 , SUM(lMiktar4 - lIade4) AS lMiktar4 , SUM(lMiktar5 - lIade5) AS lMiktar5 , SUM(lMiktar6 - lIade6) AS lMiktar6 , SUM(lMiktar7 - lIade7) AS lMiktar7 , SUM(lMiktar8 - lIade8) AS lMiktar8 , SUM(lMiktar9 - lIade9) AS lMiktar9 , SUM(lMiktar10 - lIade10) AS lMiktar10 , SUM(lTutar) AS lTutar , SUM(lTahsilat) AS lTahsilat FROM tbFirinServisDetay GROUP BY nServisID) Detay ON Master.nServisID = Detay.nServisID " & skriter3 & " ") & "é" & sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT Detay.sFisTipi, Detay.nFirmaID, Detay.sKodu, Detay.sAciklama, SUM(Detay.lMiktar1) AS lMiktar1, SUM(Detay.lIade1) AS lIade1, SUM(Detay.lMiktar2) AS lMiktar2, SUM(Detay.lIade2) AS lIade2, SUM(Detay.lMiktar3) AS lMiktar3, SUM(Detay.lIade3) AS lIade3, SUM(Detay.lMiktar4) AS lMiktar4, SUM(Detay.lIade4) AS lIade4, SUM(Detay.lMiktar5) AS lMiktar5, SUM(Detay.lIade5) AS lIade5, SUM(Detay.lMiktar6) AS lMiktar6, SUM(Detay.lIade6) AS lIade6, SUM(Detay.lMiktar7) AS lMiktar7, SUM(Detay.lIade7) AS lIade7, SUM(Detay.lMiktar8) AS lMiktar8, SUM(Detay.lIade8) AS lIade8, SUM(Detay.lMiktar9) AS lMiktar9, SUM(Detay.lIade9) AS lIade9, SUM(Detay.lMiktar10) AS lMiktar10, SUM(Detay.lIade10) AS lIade10, SUM(Detay.lTutar) AS lTutar, SUM(Detay.lTahsilat) AS lTahsilat, (SELECT ISNULL(SUM(lBorcTutar - lAlacakTutar) , 0) AS lBakiye FROM tbFirmaHareketi WHERE nFirmaID = Detay.nFirmaID) AS lBakiye FROM tbFirinServisDetay Detay INNER JOIN tbFirinServisMaster Master ON Detay.nServisID = Master.nServisID " & skriter3 & " GROUP BY Detay.sFisTipi, Detay.nFirmaID, Detay.sKodu, Detay.sAciklama ORDER BY Detay.sFisTipi, Detay.nFirmaID, Detay.sKodu, Detay.sAciklama") & "é" & sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT * FROM (SELECT SUM(lMiktar1) AS lMiktar1 , SUM(lMiktar2) AS lMiktar2 , SUM(lMiktar3) AS lMiktar3 , SUM(lMiktar4) AS lMiktar4 , SUM(lMiktar5) AS lMiktar5 , SUM(lMiktar6) AS lMiktar6 , SUM(lMiktar7) AS lMiktar7 , SUM(lMiktar8) AS lMiktar8 , SUM(lMiktar9) AS lMiktar9 , SUM(lMiktar10) AS lMiktar10 ,SUM(lIade1) AS lIade1 , SUM(lIade2) AS lIade2 , SUM(lIade3) AS lIade3 , SUM(lIade4) AS lIade4 , SUM(lIade5) AS lIade5 , SUM(lIade6) AS lIade6 , SUM(lIade7) AS lIade7 , SUM(lIade8) AS lIade8 , SUM(lIade9) AS lIade9 , SUM(lIade10) AS lIade10,SUM((lMiktar1 - lIade1) * (lFiyat1 - lFiyat1 * (nIskontoYuzdesi / 100))) AS lTutar1,SUM((lMiktar2 - lIade2) * (lFiyat2 - lFiyat2 * (nIskontoYuzdesi / 100))) AS lTutar2, SUM((lMiktar3 - lIade3) * (lFiyat3 - lFiyat3 * (nIskontoYuzdesi / 100))) AS lTutar3,SUM((lMiktar4 - lIade4) * (lFiyat4 - lFiyat4 * (nIskontoYuzdesi / 100))) AS lTutar4,SUM((lMiktar5 - lIade5) * (lFiyat5 - lFiyat5 * (nIskontoYuzdesi / 100))) AS lTutar5,SUM((lMiktar6 - lIade6) * (lFiyat6 - lFiyat6 * (nIskontoYuzdesi / 100))) AS lTutar6,SUM((lMiktar7 - lIade7) * (lFiyat7 - lFiyat7 * (nIskontoYuzdesi / 100))) AS lTutar7,SUM((lMiktar8 - lIade8) * (lFiyat8 - lFiyat8 * (nIskontoYuzdesi / 100))) AS lTutar8,SUM((lMiktar9 - lIade9) * (lFiyat9 - lFiyat9 * (nIskontoYuzdesi / 100))) AS lTutar9,SUM((lMiktar10 - lIade10) * (lFiyat10 - lFiyat10 * (nIskontoYuzdesi / 100))) AS lTutar10,SUM(lTutar) AS lTutar , SUM(lTahsilat) AS lTahsilat FROM tbFirinServisDetay Detay INNER JOIN tbFirinServisMaster Master ON Detay.nServisID = Master.nServisID " & skriter3 & " ) tbFirinServisDetay ") & ""
            args(3) = "qr_girdiéqr_ciktiéqr_baslikéqr_hareketéqr_toplam"
            processYol = args(0)
            For i As Integer = 1 To 35
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
    Private Sub MenuItem21_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem21.Click
        txt_dteFisTarihi1.Focus()
        txt_dteFisTarihi1.SelectAll()
    End Sub
    Private Sub MenuItem23_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem23.Click
        Fis_ekle()
    End Sub
    Private Sub MenuItem18_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem18.Click
        fis_duzelt()
    End Sub
    Private Sub MenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem1.Click
        GridView1.ColumnsCustomization()
    End Sub
    Private Sub MenuItem3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem3.Click
        gorunum_kaydet()
    End Sub
    Private Sub MenuItem4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem4.Click
        printlink1.CreateDocument(ps)
        ps.PreviewRibbonFormEx.Show()
    End Sub
    Private Sub MenuItem14_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem14.Click
        If MenuItem14.Checked = False Then
            GridView1.OptionsView.ShowAutoFilterRow = True
            GridView1.OptionsView.ShowFilterPanelMode = DevExpress.XtraGrid.Views.Base.ShowFilterPanelMode.Default
            GridView1.OptionsCustomization.AllowFilter = True
            MenuItem14.Checked = True
        ElseIf MenuItem14.Checked = True Then
            GridView1.OptionsView.ShowAutoFilterRow = False
            GridView1.OptionsView.ShowFilterPanelMode = DevExpress.XtraGrid.Views.Base.ShowFilterPanelMode.Never
            GridView1.OptionsCustomization.AllowFilter = False
            MenuItem14.Checked = False
        End If
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
    Private Sub MenuItem9_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem9.Click
        If Me.WindowState = FormWindowState.Normal Then
            Me.WindowState = FormWindowState.Maximized
        ElseIf Me.WindowState = FormWindowState.Maximized Then
            Me.WindowState = FormWindowState.Normal
        End If
    End Sub
    Private Sub SimpleButton3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SimpleButton3.Click
        ara()
    End Sub
    Private Sub GridView1_CustomDrawRowIndicator(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Grid.RowIndicatorCustomDrawEventArgs) Handles GridView1.CustomDrawRowIndicator
        If e.RowHandle >= 0 Then
            e.Info.DisplayText = e.RowHandle + 1
        Else
            e.Info.DisplayText = ""
        End If
    End Sub
    Private Sub GridView1_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles GridView1.KeyDown
        If e.KeyCode = Keys.Enter Then
            fis_duzelt()
        End If
    End Sub
    Private Sub MenuItem24_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem24.Click
        tbFirinParam("S")
    End Sub
    Private Sub MenuItem25_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles MenuItem25.Click
        tbFirinParam("U")
    End Sub
    Private Sub MenuItem26_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles MenuItem26.Click
        tbFirinParam("C")
    End Sub
    Private Sub sec_sFisTipi_EditValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles sec_sFisTipi.EditValueChanged
        dataload_tbGirisCikis(nGirisCikis)
        Dataload_tbStokSinifi(sec_sFisTipi.EditValue)
    End Sub
    Private Sub SimpleButton4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SimpleButton4.Click
        raporla(0, 0)
    End Sub
    Private Sub MenuItem27_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem27.Click
        tbFirinMusteriFiyat()
    End Sub
End Class