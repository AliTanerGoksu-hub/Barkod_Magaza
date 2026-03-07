Imports FastReport
Imports Microsoft.Win32
Imports DevExpress.XtraEditors
Imports System.IO
Public Class frm_tbFirinServis
    Public sConnection
    Public nFirmaNo
    Public nDonemNo
    Public sKullanici
    Public nServisID
    Public dteFisTarihi
    Public sSaticiRumuzu
    Public sServis
    Public lFisNo
    Dim sHareketTipi As String = ""
    Dim sFisTipi As String = "FS "
    Dim nGirisCikis As Integer = 3
    Public FisTipi As String
    Public GirisCikis As Integer

    Dim sorgu_txt_baslik As String = ""
    Dim sorgu_txt_hareket As String = ""
    Dim sorgu_txt_toplam As String = ""
    Dim sorgu_txt_firma As String = ""
    Public yeni As Boolean = False
    Dim status As Boolean = False
    Public islemstatus As Boolean = False
    Dim dr_baslik As DataRow
    Dim dr_hareket As DataRow
    Dim dr_toplam As DataRow
    Dim sDepo As String = "D001"
    Dim ds_tbFirinServisToplam As DataSet
    Dim ds_tbFirma As New DataSet
    Dim ds_tbSatici As DataSet
    Dim ds_toplam As DataSet
    Dim ds_tbFirinMusteriFiyat As DataSet
    Dim ds_satir_stok As DataSet
    Dim ds_tbHareketTipi As DataSet
    Dim yuklendi As Boolean = False
    Dim ds_tbStokSinifi As DataSet
    Dim s_nIslemID As String = ""
    Dim sDovizCinsi1 As String = ""
    Dim lDovizKuru1 As Decimal = 0
    Dim info As Boolean = False
    Private Sub EkleToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EkleToolStripMenuItem.Click
        If Trim(FisTipi) = "S" Then
            satir_ekle()
        Else
            satir_ekle_direkt()
        End If
    End Sub
    Private Sub dataload_tbOdemeSekli()
        sec_sOdemeSekli.DataSource = sorgu(sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT     sOdemeSekli,sAciklama from tbOdemeSekli Order by sOdemeSekli ")).Tables(0)
    End Sub
    Private Function sorgu(ByVal query As String) As DataSet
        Dim conn As New OleDb.OleDbConnection
        Dim cmd As New OleDb.OleDbCommand
        Dim adapter As New OleDb.OleDbDataAdapter
        conn.ConnectionString = sConnection
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
        query = Replace(query, "*!F", "F0" + nFirmaNo.ToString)
        query = Replace(query, "!D", "D000" + nDonemNo.ToString)
        Return query
    End Function
    Private Sub satir_ekle()
        Dim frm_firma As New frm_firma_liste
        frm_firma.firmano = nFirmaNo
        frm_firma.donemno = nDonemNo
        frm_firma.connection = sConnection
        frm_firma.islemstatus = True
        frm_firma.kullanici = sKullanici
        uretim_kontrol()
        If frm_firma.ShowDialog(Me) = Windows.Forms.DialogResult.OK Then
            Dim s As String
            Dim arr As Integer()
            Dim i As Integer
            Dim dr As DataRow
            Dim dr1 As DataRow
            Dim dr2 As DataRow
            Dim dr3 As DataRow
            arr = frm_firma.GridView1.GetSelectedRows()
            If arr Is Nothing Then
            Else
                Array.Sort(arr)
                For Each i In arr
                    s = i.ToString
                    dr = ds_hareket.Tables(0).NewRow
                    dr1 = frm_firma.GridView1.GetDataRow(s)
                    ds_tbFirinMusteriFiyat = tbFirinMusteriFiyat(dr1("nFirmaID"))
                    Dim bFiyat As Boolean = False
                    If ds_tbFirinMusteriFiyat.Tables(0).Rows.Count = 1 Then
                        bFiyat = True
                        dr3 = ds_tbFirinMusteriFiyat.Tables(0).Rows(0)
                    Else
                        dr3 = ds_tbStokSinifi.Tables(0).Rows(0)
                    End If
                    dr("nHareketID") = 0
                    dr("nServisID") = nServisID
                    dr("dteFisTarihi") = dteFisTarihi
                    dr("sFisTipi") = FisTipi
                    dr("nGirisCikis") = GirisCikis
                    dr("lFisNo") = lFisNo
                    dr("sSaticiRumuzu") = "001"
                    dr("sServis") = "1"
                    dr("nSatir") = GridView1.RowCount + 1
                    dr("bStatus") = 1
                    dr("nFirmaID") = dr1("nFirmaID")
                    dr("sKodu") = dr1("sKodu")
                    dr("sAciklama") = dr1("sAciklama")
                    dr("nIskontoYuzdesi") = sorgu_sayi(dr1("nOzelIskontosu"), 0)
                    dr("sFiyatTipi") = dr1("sFiyatTipi").ToString
                    If dr("sFiyatTipi").ToString = "" Then
                        dr("sFiyatTipi") = sFiyat1
                    End If
                    dr("nStokFisiID") = ""
                    dr2 = ds_tbStokSinifi.Tables(0).Rows(0)
                    dr("nStokID1") = sorgu_sayi(dr2("nStokID"), 0)
                    dr("nKdvOrani1") = sorgu_sayi(dr2("nKdvOrani"), 0)
                    dr("lMiktar1") = 0
                    dr("lIade1") = 0
                    If Trim(dr("sFiyatTipi").ToString) = "" Then
                        If bFiyat = True Then
                            dr("lFiyat1") = dr3("lFiyat1")
                        Else
                            dr("lFiyat1") = dr2("FIYAT1")
                        End If
                    Else
                        dr("lFiyat1") = sorgu_stok_fiyat(dr("sFiyatTipi"), dr("nStokID1"))
                    End If
                    dr("nIslemID1") = 0
                    dr2 = ds_tbStokSinifi.Tables(0).Rows(1)
                    dr("nStokID2") = sorgu_sayi(dr2("nStokID"), 0)
                    dr("nKdvOrani2") = sorgu_sayi(dr2("nKdvOrani"), 0)
                    dr("lMiktar2") = 0
                    dr("lIade2") = 0
                    If Trim(dr("sFiyatTipi").ToString) = "" Then
                        If bFiyat = True Then
                            dr("lFiyat2") = dr3("lFiyat2")
                        Else
                            dr("lFiyat2") = dr2("FIYAT1")
                        End If
                    Else
                        dr("lFiyat2") = sorgu_stok_fiyat(dr("sFiyatTipi"), dr("nStokID2"))
                    End If
                    dr("nIslemID2") = 0
                    dr2 = ds_tbStokSinifi.Tables(0).Rows(2)
                    dr("nStokID3") = sorgu_sayi(dr2("nStokID"), 0)
                    dr("nKdvOrani3") = sorgu_sayi(dr2("nKdvOrani"), 0)
                    dr("lMiktar3") = 0
                    dr("lIade3") = 0
                    If Trim(dr("sFiyatTipi").ToString) = "" Then
                        If bFiyat = True Then
                            dr("lFiyat3") = dr3("lFiyat3")
                        Else
                            dr("lFiyat3") = dr2("FIYAT1")
                        End If
                    Else
                        dr("lFiyat3") = sorgu_stok_fiyat(dr("sFiyatTipi"), dr("nStokID3"))
                    End If
                    dr("nIslemID3") = 0
                    dr2 = ds_tbStokSinifi.Tables(0).Rows(3)
                    dr("nStokID4") = sorgu_sayi(dr2("nStokID"), 0)
                    dr("nKdvOrani4") = sorgu_sayi(dr2("nKdvOrani"), 0)
                    dr("lMiktar4") = 0
                    dr("lIade4") = 0
                    If Trim(dr("sFiyatTipi").ToString) = "" Then
                        If bFiyat = True Then
                            dr("lFiyat4") = dr3("lFiyat4")
                        Else
                            dr("lFiyat4") = dr2("FIYAT1")
                        End If
                    Else
                        dr("lFiyat4") = sorgu_stok_fiyat(dr("sFiyatTipi"), dr("nStokID4"))
                    End If
                    dr("nIslemID4") = 0
                    dr2 = ds_tbStokSinifi.Tables(0).Rows(4)
                    dr("nStokID5") = sorgu_sayi(dr2("nStokID"), 0)
                    dr("nKdvOrani5") = sorgu_sayi(dr2("nKdvOrani"), 0)
                    dr("lMiktar5") = 0
                    dr("lIade5") = 0
                    If Trim(dr("sFiyatTipi").ToString) = "" Then
                        If bFiyat = True Then
                            dr("lFiyat5") = dr3("lFiyat5")
                        Else
                            dr("lFiyat5") = dr2("FIYAT1")
                        End If
                    Else
                        dr("lFiyat5") = sorgu_stok_fiyat(dr("sFiyatTipi"), dr("nStokID5"))
                    End If
                    dr("nIslemID5") = 0
                    dr2 = ds_tbStokSinifi.Tables(0).Rows(5)
                    dr("nStokID6") = sorgu_sayi(dr2("nStokID"), 0)
                    dr("nKdvOrani6") = sorgu_sayi(dr2("nKdvOrani"), 0)
                    dr("lMiktar6") = 0
                    dr("lIade6") = 0
                    If Trim(dr("sFiyatTipi").ToString) = "" Then
                        If bFiyat = True Then
                            dr("lFiyat6") = dr3("lFiyat6")
                        Else
                            dr("lFiyat6") = dr2("FIYAT1")
                        End If
                    Else
                        dr("lFiyat6") = sorgu_stok_fiyat(dr("sFiyatTipi"), dr("nStokID6"))
                    End If
                    dr("nIslemID6") = 0
                    dr2 = ds_tbStokSinifi.Tables(0).Rows(6)
                    dr("nStokID7") = sorgu_sayi(dr2("nStokID"), 0)
                    dr("nKdvOrani7") = sorgu_sayi(dr2("nKdvOrani"), 0)
                    dr("lMiktar7") = 0
                    dr("lIade7") = 0
                    If Trim(dr("sFiyatTipi").ToString) = "" Then
                        If bFiyat = True Then
                            dr("lFiyat7") = dr3("lFiyat7")
                        Else
                            dr("lFiyat7") = dr2("FIYAT1")
                        End If
                    Else
                        dr("lFiyat7") = sorgu_stok_fiyat(dr("sFiyatTipi"), dr("nStokID7"))
                    End If
                    dr("nIslemID7") = 0
                    dr2 = ds_tbStokSinifi.Tables(0).Rows(7)
                    dr("nStokID8") = sorgu_sayi(dr2("nStokID"), 0)
                    dr("nKdvOrani8") = sorgu_sayi(dr2("nKdvOrani"), 0)
                    dr("lMiktar8") = 0
                    dr("lIade8") = 0
                    If Trim(dr("sFiyatTipi").ToString) = "" Then
                        If bFiyat = True Then
                            dr("lFiyat8") = dr3("lFiyat8")
                        Else
                            dr("lFiyat8") = dr2("FIYAT1")
                        End If
                    Else
                        dr("lFiyat8") = sorgu_stok_fiyat(dr("sFiyatTipi"), dr("nStokID8"))
                    End If
                    dr("nIslemID8") = 0
                    dr2 = ds_tbStokSinifi.Tables(0).Rows(8)
                    dr("nStokID9") = sorgu_sayi(dr2("nStokID"), 0)
                    dr("nKdvOrani9") = sorgu_sayi(dr2("nKdvOrani"), 0)
                    dr("lMiktar9") = 0
                    dr("lIade9") = 0
                    If Trim(dr("sFiyatTipi").ToString) = "" Then
                        If bFiyat = True Then
                            dr("lFiyat9") = dr3("lFiyat9")
                        Else
                            dr("lFiyat9") = dr2("FIYAT1")
                        End If
                    Else
                        dr("lFiyat9") = sorgu_stok_fiyat(dr("sFiyatTipi"), dr("nStokID9"))
                    End If
                    dr("nIslemID9") = 0
                    dr2 = ds_tbStokSinifi.Tables(0).Rows(9)
                    dr("nStokID10") = sorgu_sayi(dr2("nStokID"), 0)
                    dr("nKdvOrani10") = sorgu_sayi(dr2("nKdvOrani"), 0)
                    dr("lMiktar10") = 0
                    dr("lIade10") = 0
                    If Trim(dr("sFiyatTipi").ToString) = "" Then
                        If bFiyat = True Then
                            dr("lFiyat10") = dr3("lFiyat10")
                        Else
                            dr("lFiyat10") = dr2("FIYAT1")
                        End If
                    Else
                        dr("lFiyat10") = sorgu_stok_fiyat(dr("sFiyatTipi"), dr("nStokID10"))
                    End If
                    dr("nIslemID10") = 0
                    dr("lTutar") = 0
                    dr("lTahsilat") = 0
                    dr("sOdemeSekli") = "N   "
                    dr("nKasaIslemID") = ""
                    dr("dteKayitTarihi") = Now
                    dr("sKullanici") = sKullanici
                    If sorgu_ntbFirinServisDetayi(nServisID, dr("nFirmaID")) = 0 Then
                        Dim nHareketID As Int64 = tbFirinServis_kaydet_yeni(dr("nHareketID"), nServisID, dr("dteFisTarihi"), dr("sFisTipi"), dr("nGirisCikis"), dr("lFisNo"), dr("sSaticiRumuzu").ToString, dr("sServis").ToString, dr("nSatir"), dr("bStatus"), dr("nFirmaID"), dr("sKodu").ToString, dr("sAciklama").ToString, dr("nIskontoYuzdesi"), dr("sFiyatTipi").ToString, dr("nStokFisiID"), dr("nStokID1"), dr("lMiktar1"), dr("lIade1"), dr("lFiyat1"), dr("nIslemID1"), dr("nStokID2"), dr("lMiktar2"), dr("lIade2"), dr("lFiyat2"), dr("nIslemID2"), dr("nStokID3"), dr("lMiktar3"), dr("lIade3"), dr("lFiyat3"), dr("nIslemID3"), dr("nStokID4"), dr("lMiktar4"), dr("lIade4"), dr("lFiyat4"), dr("nIslemID4"), dr("nStokID5"), dr("lMiktar5"), dr("lIade5"), dr("lFiyat5"), dr("nIslemID5"), dr("nStokID6"), dr("lMiktar6"), dr("lIade6"), dr("lFiyat6"), dr("nIslemID6"), dr("nStokID7"), dr("lMiktar7"), dr("lIade7"), dr("lFiyat7"), dr("nIslemID7"), dr("nStokID8"), dr("lMiktar8"), dr("lIade8"), dr("lFiyat8"), dr("nIslemID8"), dr("nStokID9"), dr("lMiktar9"), dr("lIade9"), dr("lFiyat9"), dr("nIslemID9"), dr("nStokID10"), dr("lMiktar10"), dr("lIade10"), dr("lFiyat10"), dr("nIslemID10"), dr("lTutar"), dr("lTahsilat"), dr("sOdemeSekli"), dr("nKasaIslemID"), dr("dteKayitTarihi"), dr("sKullanici").ToString, dr("nKdvOrani1"), dr("nKdvOrani2"), dr("nKdvOrani3"), dr("nKdvOrani4"), dr("nKdvOrani5"), dr("nKdvOrani6"), dr("nKdvOrani7"), dr("nKdvOrani8"), dr("nKdvOrani9"), dr("nKdvOrani10"))
                        dr("nHareketID") = nHareketID
                        ds_hareket.Tables(0).Rows.Add(dr)
                    Else
                    End If
                Next
            End If
            dr = Nothing
            dr1 = Nothing
            dr2 = Nothing
            dr3 = Nothing
            s = Nothing
            arr = Nothing
            i = Nothing
            If GridView1.RowCount > 0 Then
                GridView1.ClearSelection()
                GridView1.SelectRow(GridView1.RowCount - 1)
                PanelControl3.Focus()
                GridControl1.Focus()
            End If
            GridView1.FocusedColumn = collMiktar1
        End If
    End Sub
    Private Sub satir_ekle_direkt()
        Dim nFirmaID As Int64 = 0
        Dim dr2 As DataRow
        nFirmaID = uretim_kontrol()
        Dim dr As DataRow
        dr = ds_hareket.Tables(0).NewRow
        dr("nHareketID") = 0
        dr("nServisID") = nServisID
        dr("dteFisTarihi") = dteFisTarihi
        dr("sFisTipi") = FisTipi
        dr("nGirisCikis") = GirisCikis
        dr("lFisNo") = lFisNo
        dr("sSaticiRumuzu") = "001"
        dr("sServis") = "1"
        dr("nSatir") = GridView1.RowCount + 1
        dr("bStatus") = 1
        dr("nFirmaID") = nFirmaID
        dr("sKodu") = "URETIM"
        dr("sAciklama") = "URETIM"
        dr("nIskontoYuzdesi") = 0
        dr("sFiyatTipi") = ""
        If dr("sFiyatTipi").ToString = "" Then
            dr("sFiyatTipi") = sFiyat1
        End If
        dr("nStokFisiID") = ""
        dr2 = ds_tbStokSinifi.Tables(0).Rows(0)
        dr("nStokID1") = sorgu_sayi(dr2("nStokID"), 0)
        dr("nKdvOrani1") = sorgu_sayi(dr2("nKdvOrani"), 0)
        dr("lMiktar1") = 0
        dr("lIade1") = 0
        If Trim(dr("sFiyatTipi").ToString) = "" Then
            dr("lFiyat1") = dr2("FIYAT1")
        Else
            dr("lFiyat1") = sorgu_stok_fiyat(dr("sFiyatTipi"), dr("nStokID1"))
        End If
        dr("nIslemID1") = 0
        dr2 = ds_tbStokSinifi.Tables(0).Rows(1)
        dr("nStokID2") = sorgu_sayi(dr2("nStokID"), 0)
        dr("nKdvOrani2") = sorgu_sayi(dr2("nKdvOrani"), 0)
        dr("lMiktar2") = 0
        dr("lIade2") = 0
        If Trim(dr("sFiyatTipi").ToString) = "" Then
            dr("lFiyat2") = dr2("FIYAT1")
        Else
            dr("lFiyat2") = sorgu_stok_fiyat(dr("sFiyatTipi"), dr("nStokID2"))
        End If
        dr("nIslemID2") = 0
        dr2 = ds_tbStokSinifi.Tables(0).Rows(2)
        dr("nStokID3") = sorgu_sayi(dr2("nStokID"), 0)
        dr("nKdvOrani3") = sorgu_sayi(dr2("nKdvOrani"), 0)
        dr("lMiktar3") = 0
        dr("lIade3") = 0
        If Trim(dr("sFiyatTipi").ToString) = "" Then
            dr("lFiyat3") = dr2("FIYAT1")
        Else
            dr("lFiyat3") = sorgu_stok_fiyat(dr("sFiyatTipi"), dr("nStokID3"))
        End If
        dr("nIslemID3") = 0
        dr2 = ds_tbStokSinifi.Tables(0).Rows(3)
        dr("nStokID4") = sorgu_sayi(dr2("nStokID"), 0)
        dr("nKdvOrani4") = sorgu_sayi(dr2("nKdvOrani"), 0)
        dr("lMiktar4") = 0
        dr("lIade4") = 0
        If Trim(dr("sFiyatTipi").ToString) = "" Then
            dr("lFiyat4") = dr2("FIYAT1")
        Else
            dr("lFiyat4") = sorgu_stok_fiyat(dr("sFiyatTipi"), dr("nStokID4"))
        End If
        dr("nIslemID4") = 0
        dr2 = ds_tbStokSinifi.Tables(0).Rows(4)
        dr("nStokID5") = sorgu_sayi(dr2("nStokID"), 0)
        dr("nKdvOrani5") = sorgu_sayi(dr2("nKdvOrani"), 0)
        dr("lMiktar5") = 0
        dr("lIade5") = 0
        If Trim(dr("sFiyatTipi").ToString) = "" Then
            dr("lFiyat5") = dr2("FIYAT1")
        Else
            dr("lFiyat5") = sorgu_stok_fiyat(dr("sFiyatTipi"), dr("nStokID5"))
        End If
        dr("nIslemID5") = 0
        dr2 = ds_tbStokSinifi.Tables(0).Rows(5)
        dr("nStokID6") = sorgu_sayi(dr2("nStokID"), 0)
        dr("nKdvOrani6") = sorgu_sayi(dr2("nKdvOrani"), 0)
        dr("lMiktar6") = 0
        dr("lIade6") = 0
        If Trim(dr("sFiyatTipi").ToString) = "" Then
            dr("lFiyat6") = dr2("FIYAT1")
        Else
            dr("lFiyat6") = sorgu_stok_fiyat(dr("sFiyatTipi"), dr("nStokID6"))
        End If
        dr("nIslemID6") = 0
        dr2 = ds_tbStokSinifi.Tables(0).Rows(6)
        dr("nStokID7") = sorgu_sayi(dr2("nStokID"), 0)
        dr("nKdvOrani7") = sorgu_sayi(dr2("nKdvOrani"), 0)
        dr("lMiktar7") = 0
        dr("lIade7") = 0
        If Trim(dr("sFiyatTipi").ToString) = "" Then
            dr("lFiyat7") = dr2("FIYAT1")
        Else
            dr("lFiyat7") = sorgu_stok_fiyat(dr("sFiyatTipi"), dr("nStokID7"))
        End If
        dr("nIslemID7") = 0
        dr2 = ds_tbStokSinifi.Tables(0).Rows(7)
        dr("nStokID8") = sorgu_sayi(dr2("nStokID"), 0)
        dr("nKdvOrani8") = sorgu_sayi(dr2("nKdvOrani"), 0)
        dr("lMiktar8") = 0
        dr("lIade8") = 0
        If Trim(dr("sFiyatTipi").ToString) = "" Then
            dr("lFiyat8") = dr2("FIYAT1")
        Else
            dr("lFiyat8") = sorgu_stok_fiyat(dr("sFiyatTipi"), dr("nStokID8"))
        End If
        dr("nIslemID8") = 0
        dr2 = ds_tbStokSinifi.Tables(0).Rows(8)
        dr("nStokID9") = sorgu_sayi(dr2("nStokID"), 0)
        dr("nKdvOrani9") = sorgu_sayi(dr2("nKdvOrani"), 0)
        dr("lMiktar9") = 0
        dr("lIade9") = 0
        If Trim(dr("sFiyatTipi").ToString) = "" Then
            dr("lFiyat9") = dr2("FIYAT1")
        Else
            dr("lFiyat9") = sorgu_stok_fiyat(dr("sFiyatTipi"), dr("nStokID9"))
        End If
        dr("nIslemID9") = 0
        dr2 = ds_tbStokSinifi.Tables(0).Rows(9)
        dr("nStokID10") = sorgu_sayi(dr2("nStokID"), 0)
        dr("nKdvOrani10") = sorgu_sayi(dr2("nKdvOrani"), 0)
        dr("lMiktar10") = 0
        dr("lIade10") = 0
        If Trim(dr("sFiyatTipi").ToString) = "" Then
            dr("lFiyat10") = dr2("FIYAT1")
        Else
            dr("lFiyat10") = sorgu_stok_fiyat(dr("sFiyatTipi"), dr("nStokID10"))
        End If
        dr("nIslemID10") = 0
        dr("lTutar") = 0
        dr("lTahsilat") = 0
        dr("sOdemeSekli") = "N   "
        dr("nKasaIslemID") = ""
        dr("dteKayitTarihi") = Now
        dr("sKullanici") = sKullanici
        If sorgu_ntbFirinServisDetayi(nServisID, dr("nFirmaID")) = 0 Then
            Dim nHareketID As Int64 = tbFirinServis_kaydet_yeni(dr("nHareketID"), nServisID, dr("dteFisTarihi"), dr("sFisTipi"), dr("nGirisCikis"), dr("lFisNo"), dr("sSaticiRumuzu").ToString, dr("sServis").ToString, dr("nSatir"), dr("bStatus"), dr("nFirmaID"), dr("sKodu").ToString, dr("sAciklama").ToString, dr("nIskontoYuzdesi"), dr("sFiyatTipi").ToString, dr("nStokFisiID"), dr("nStokID1"), dr("lMiktar1"), dr("lIade1"), dr("lFiyat1"), dr("nIslemID1"), dr("nStokID2"), dr("lMiktar2"), dr("lIade2"), dr("lFiyat2"), dr("nIslemID2"), dr("nStokID3"), dr("lMiktar3"), dr("lIade3"), dr("lFiyat3"), dr("nIslemID3"), dr("nStokID4"), dr("lMiktar4"), dr("lIade4"), dr("lFiyat4"), dr("nIslemID4"), dr("nStokID5"), dr("lMiktar5"), dr("lIade5"), dr("lFiyat5"), dr("nIslemID5"), dr("nStokID6"), dr("lMiktar6"), dr("lIade6"), dr("lFiyat6"), dr("nIslemID6"), dr("nStokID7"), dr("lMiktar7"), dr("lIade7"), dr("lFiyat7"), dr("nIslemID7"), dr("nStokID8"), dr("lMiktar8"), dr("lIade8"), dr("lFiyat8"), dr("nIslemID8"), dr("nStokID9"), dr("lMiktar9"), dr("lIade9"), dr("lFiyat9"), dr("nIslemID9"), dr("nStokID10"), dr("lMiktar10"), dr("lIade10"), dr("lFiyat10"), dr("nIslemID10"), dr("lTutar"), dr("lTahsilat"), dr("sOdemeSekli"), dr("nKasaIslemID"), dr("dteKayitTarihi"), dr("sKullanici").ToString, dr("nKdvOrani1"), dr("nKdvOrani2"), dr("nKdvOrani3"), dr("nKdvOrani4"), dr("nKdvOrani5"), dr("nKdvOrani6"), dr("nKdvOrani7"), dr("nKdvOrani8"), dr("nKdvOrani9"), dr("nKdvOrani10"))
            dr("nHareketID") = nHareketID
            ds_hareket.Tables(0).Rows.Add(dr)
        Else
        End If
        dr = Nothing
        If GridView1.RowCount > 0 Then
            GridView1.ClearSelection()
            GridView1.SelectRow(GridView1.RowCount - 1)
            PanelControl3.Focus()
            GridControl1.Focus()
        End If
        GridView1.FocusedColumn = collMiktar1
    End Sub
    Private Function uretim_kontrol() As Integer
        Dim nFirmaID As Integer
        Dim cari_kayit_sayisi = sorgu_TBfirma_kontrol("URETIM")
        If cari_kayit_sayisi = 0 Then
            'MsgBox(dr_baslik("sKodu") & " Kodlu Firma Kaydý Bulunamadý",sDil), MessageBoxIcon.Warning)
            nFirmaID = firma_kaydet_yeni("URETIM", "URETIM", 0, 0, "01/01/1900", 0, "", "", "", "", "", "", "", "", "", 0, "", kullanici, Now, "")
            firma_siniflari_kaydet_yeni(nFirmaID, "", "", "", "", "")
        Else
            nFirmaID = cari_kayit_sayisi
        End If
        Return nFirmaID
    End Function
    Public Function sorgu_TBfirma_kontrol(ByVal kod As String) As Int64
        Dim kriter
        kriter = "WHERE (sKodu = '" & kod & "')  "
        Dim conn As New OleDb.OleDbConnection
        Dim cmd As New OleDb.OleDbCommand
        Dim adapter As New OleDb.OleDbDataAdapter
        'MsgBox(connection_resmi)
        conn.ConnectionString = sConnection
        cmd.Connection = conn
        conn.Open()
        cmd.CommandText = sorgu_query("SET DATEFORMAT DMY SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT     ISNULL(nFirmaID, 0) AS KAYIT FROM         tbFirma " & kriter & "")
        Dim kayitsayisi = cmd.ExecuteScalar
        conn.Close()
        cmd = Nothing
        adapter = Nothing
        Return kayitsayisi
        cmd = Nothing
    End Function
    Private Function firma_kaydet_yeni(ByVal sKodu As String, ByVal sAciklama As String, ByVal nOzelIskontosu As Decimal, ByVal lKrediLimiti As Decimal, ByVal dteMutabakatTarihi As DateTime, ByVal nVadeGun As Int64, ByVal sHitap As String, ByVal sAdres1 As String, ByVal sAdres2 As String, ByVal sSemt As String, ByVal sIl As String, ByVal sUlke As String, ByVal sPostaKodu As String, ByVal sVergiDairesi As String, ByVal sVergiNo As String, ByVal nHesapID As Int64, ByVal sOzelNot As String, ByVal sKullaniciAdi As String, ByVal dteKayitTarihi As DateTime, ByVal sFiyatTipi As String) As Int64
        Dim cmd As New OleDb.OleDbCommand
        Dim con As New OleDb.OleDbConnection
        cmd.Connection = con
        con.ConnectionString = sConnection
        If con.State = ConnectionState.Closed = True Then
            con.Open()
        End If
        cmd.CommandText = sorgu_query("SET DATEFORMAT DMY INSERT INTO tbFirma                       (sKodu, sAciklama, nOzelIskontosu, lKrediLimiti, dteMutabakatTarihi, nVadeGun, sHitap, sAdres1, sAdres2, sSemt, sIl, sUlke, sPostaKodu, sVergiDairesi, sVergiNo, nHesapID, sOzelNot, sKullaniciAdi, dteKayitTarihi, sFiyatTipi) VALUES     ('" & sKodu & "', N'" & sAciklama & "', " & nOzelIskontosu & ", " & lKrediLimiti & ", '" & dteMutabakatTarihi & "', " & nVadeGun & " , '" & sHitap & "', '" & sAdres1 & "', '" & sAdres2 & "', '" & sSemt & "', '" & sIl & "', '" & sUlke & "', '" & sPostaKodu & "',  '" & sVergiDairesi & "', '" & sVergiNo & "', " & nHesapID & " , '" & sOzelNot & "', '" & sKullaniciAdi & "', '" & dteKayitTarihi & "', '" & sFiyatTipi & "')")
        cmd.ExecuteNonQuery()
        cmd.CommandText = "SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT @@identity"
        Dim hareketno = cmd.ExecuteScalar
        con.Close()
        cmd = Nothing
        con = Nothing
        Return hareketno
        cmd = Nothing
        con = Nothing
    End Function
    Private Sub firma_siniflari_kaydet_yeni(ByVal nFirmaID As String, ByVal sSinifKodu1 As String, ByVal sSinifKodu2 As String, ByVal sSinifKodu3 As String, ByVal sSinifKodu4 As String, ByVal sSinifKodu5 As String)
        Dim cmd As New OleDb.OleDbCommand
        Dim con As New OleDb.OleDbConnection
        cmd.Connection = con
        con.ConnectionString = sConnection
        If con.State = ConnectionState.Closed = True Then
            con.Open()
        End If
        cmd.CommandText = sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED INSERT INTO tbFirmaSinifi                       (nFirmaID, sSinifKodu1, sSinifKodu2, sSinifKodu3, sSinifKodu4, sSinifKodu5) VALUES     ('" & nFirmaID & "', '" & sSinifKodu1 & "', '" & sSinifKodu2 & "', '" & sSinifKodu3 & "', '" & sSinifKodu4 & "', '" & sSinifKodu5 & "')")
        cmd.ExecuteNonQuery()
        con.Close()
        cmd = Nothing
        con = Nothing
    End Sub
    Public Function sorgu_stok_fiyat(ByVal fiyattipi As String, ByVal stokno As Int64) As Decimal
        Dim kriter
        kriter = "WHERE     (sFiyatTipi = '" & fiyattipi & "') AND (nStokID = " & stokno & ")"
        Dim conn As New OleDb.OleDbConnection
        Dim cmd As New OleDb.OleDbCommand
        Dim adapter As New OleDb.OleDbDataAdapter
        conn.ConnectionString = sConnection
        cmd.Connection = conn
        If conn.State = ConnectionState.Closed Then
            conn.Open()
        End If
        cmd.CommandText = sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT     ISNULL(lFiyat, 0) AS FIYAT FROM         tbStokFiyati " & kriter & "")
        Dim kayitsayisi = cmd.ExecuteScalar
        Return kayitsayisi
        cmd = Nothing
        adapter = Nothing
    End Function
    Private Sub satir_sil()
        If GridView1.RowCount > 0 Then
            If XtraMessageBox.Show(Sorgu_sDil("Satýrý Silmek Ýstediðinize Emin misiniz...?", sDil), Sorgu_sDil("Dikkat", sDil), MessageBoxButtons.YesNo, MessageBoxIcon.Question) = MsgBoxResult.Yes Then
                dr_hareket = GridView1.GetDataRow(GridView1.FocusedRowHandle)
                Dim bPesinmi As Boolean = False
                If Trim(dr_hareket("sOdemeSekli")) = "N" Then
                    bPesinmi = True
                End If
                If bPesinmi = False Then
                    If dr_hareket("nKasaIslemID").ToString <> "" Then
                        tbFirmaHareket_kaydet_sil(dr_hareket("nKasaIslemID"))
                        dr_hareket("nKasaIslemID") = ""
                    End If
                Else
                    If dr_hareket("nKasaIslemID").ToString <> "" Then
                        tbNakitKasa_kaydet_sil(dr_hareket("nKasaIslemID").ToString, 0)
                        'dr_baslik("nKasaIslemID") = ""
                    End If
                End If
                bPesinmi = Nothing
                tbFirinServis_kaydet_sil(dr_hareket("nHareketID"), nServisID)
                If tbStokFisiMaster_kaydet_sil(dr_hareket("nStokFisiID"), sFisTipi) = True Then
                    dr_hareket("nStokFisiID") = ""
                    dr_hareket("nIslemID1") = 0
                    dr_hareket("nIslemID2") = 0
                    dr_hareket("nIslemID3") = 0
                    dr_hareket("nIslemID4") = 0
                    dr_hareket("nIslemID5") = 0
                    dr_hareket("nIslemID6") = 0
                    dr_hareket("nIslemID7") = 0
                    dr_hareket("nIslemID8") = 0
                    dr_hareket("nIslemID9") = 0
                    dr_hareket("nIslemID10") = 0
                End If
                ds_hareket.Tables(0).Rows.Remove(dr_hareket)
                'GridView1.DeleteRow(GridView1.FocusedRowHandle)
                GridControl1.Focus()
                GridControl1.Select()
                If GridView1.RowCount > 0 Then
                    GridView1.SelectRow(GridView1.FocusedRowHandle)
                End If
                Dataload_tbYekun(nServisID)
            End If
        End If
    End Sub
    Private Function sorgu_sayi(ByVal deger As Object, ByVal sonuc As Int64) As Decimal
        If deger.ToString = "" Then
            deger = sonuc
        End If
        Return deger
    End Function
    Private Function tbFirinServisMaster_kaydet_yeni(ByVal nServisID As Int64, ByVal dteFisTarihi As DateTime, ByVal sFisTipi As String, ByVal nGirisCikis As Integer, ByVal lFisNo As Int64, ByVal sSaticiRumuzu As String, ByVal sServis As String, ByVal sKullanici As String, ByVal dteKayitTarihi As DateTime, ByVal sAciklama1 As String, ByVal sAciklama2 As String, ByVal sAciklama3 As String, ByVal sAciklama4 As String, ByVal sAciklama5 As String) As Int64
        Dim cmd As New OleDb.OleDbCommand
        Dim con As New OleDb.OleDbConnection
        cmd.Connection = con
        con.ConnectionString = sConnection
        If con.State = ConnectionState.Closed = True Then
            con.Open()
        End If
        cmd.CommandText = sorgu_query("SET DATEFORMAT DMY INSERT INTO tbFirinServisMaster ( dteFisTarihi, sFisTipi,nGirisCikis,lFisNo, sSaticiRumuzu, sServis, sKullanici, dteKayitTarihi, sAciklama1, sAciklama2, sAciklama3, sAciklama4, sAciklama5) VALUES     ( '" & dteFisTarihi & "','" & sFisTipi & "'," & nGirisCikis & ", " & lFisNo & ", '" & sSaticiRumuzu & "', '" & sServis & "', '" & sKullanici & "', '" & dteKayitTarihi & "', '" & sAciklama1 & "', '" & sAciklama2 & "', '" & sAciklama3 & "', '" & sAciklama4 & "', '" & sAciklama5 & "')")
        cmd.ExecuteNonQuery()
        cmd.CommandText = "SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT @@identity"
        Dim kayitno = cmd.ExecuteScalar
        con.Close()
        cmd = Nothing
        con = Nothing
        Return kayitno
    End Function
    Private Sub tbFirinServisMaster_kaydet_duzelt(ByVal nServisID As Int64, ByVal dteFisTarihi As DateTime, ByVal sFisTipi As String, ByVal nGirisCikis As Integer, ByVal lFisNo As Int64, ByVal sSaticiRumuzu As String, ByVal sServis As String, ByVal sKullanici As String, ByVal dteKayitTarihi As DateTime, ByVal sAciklama1 As String, ByVal sAciklama2 As String, ByVal sAciklama3 As String, ByVal sAciklama4 As String, ByVal sAciklama5 As String)
        Dim cmd As New OleDb.OleDbCommand
        Dim con As New OleDb.OleDbConnection
        cmd.Connection = con
        con.ConnectionString = sConnection
        If con.State = ConnectionState.Closed = True Then
            con.Open()
        End If
        cmd.CommandText = sorgu_query("SET DATEFORMAT DMY UPDATE    tbFirinServisMaster SET               dteFisTarihi = '" & dteFisTarihi & "',sFisTipi ='" & sFisTipi & "', nGirisCikis = " & nGirisCikis & ",lFisNo = " & lFisNo & ", sSaticiRumuzu = '" & sSaticiRumuzu & "', sServis = '" & sServis & "', sKullanici = '" & sKullanici & "', dteKayitTarihi = '" & dteKayitTarihi & "', sAciklama1 = '" & sAciklama1 & "', sAciklama2 = '" & sAciklama2 & "', sAciklama3 = '" & sAciklama3 & "', sAciklama4 = '" & sAciklama4 & "',  sAciklama5 = '" & sAciklama5 & "' Where nServisID = " & nServisID & "")
        cmd.ExecuteNonQuery()
        con.Close()
        cmd = Nothing
        con = Nothing
    End Sub
    Private Sub tbFirinServisMaster_kaydet_sil(ByVal nServisID As Int64)
        Dim cmd As New OleDb.OleDbCommand
        Dim con As New OleDb.OleDbConnection
        cmd.Connection = con
        con.ConnectionString = sConnection
        If con.State = ConnectionState.Closed = True Then
            con.Open()
        End If
        cmd.CommandText = sorgu_query("SET DATEFORMAT DMY DELETE FROM     tbFirinServisMaster  Where nServisID = " & nServisID & "")
        cmd.ExecuteNonQuery()
        con.Close()
        cmd = Nothing
        con = Nothing
    End Sub
    Private Sub tbFirinServisMasterDetay_kaydet_duzelt(ByVal nServisID As Int64, ByVal dteFisTarihi As DateTime, ByVal lFisNo As Int64, ByVal sSaticiRumuzu As String, ByVal sServis As String, ByVal sKullanici As String, ByVal dteKayitTarihi As DateTime, ByVal sAciklama1 As String, ByVal sAciklama2 As String, ByVal sAciklama3 As String, ByVal sAciklama4 As String, ByVal sAciklama5 As String)
        Dim cmd As New OleDb.OleDbCommand
        Dim con As New OleDb.OleDbConnection
        cmd.Connection = con
        con.ConnectionString = sConnection
        If con.State = ConnectionState.Closed = True Then
            con.Open()
        End If
        cmd.CommandText = sorgu_query("SET DATEFORMAT DMY UPDATE    tbFirinServisDetay SET               dteFisTarihi = '" & dteFisTarihi & "', sFisTipi = '" & sFisTipi & "',lFisNo = " & lFisNo & ", sSaticiRumuzu = '" & sSaticiRumuzu & "', sServis = '" & sServis & "' Where nServisID = " & nServisID & "")
        cmd.ExecuteNonQuery()
        con.Close()
        cmd = Nothing
        con = Nothing
    End Sub
    Private Function tbFirinServis_kaydet_yeni(ByVal nHareketID As Int64, ByVal nServisID As Int64, ByVal dteFisTarihi As DateTime, ByVal sFisTipi As String, ByVal nGirisCikis As Integer, ByVal lFisNo As Int64, ByVal sSaticiRumuzu As String, ByVal sServis As String, ByVal nSatir As Integer, ByVal bStatus As Integer, ByVal nFirmaID As Integer, ByVal sKodu As String, ByVal sAciklama As String, ByVal nIskontoYuzdesi As Decimal, ByVal sFiyatTipi As String, ByVal nStokFisiID As String, ByVal nStokID1 As Integer, ByVal lMiktar1 As Decimal, ByVal lIade1 As Decimal, ByVal lFiyat1 As Decimal, ByVal nIslemID1 As Int64, ByVal nStokID2 As Integer, ByVal lMiktar2 As Decimal, ByVal lIade2 As Decimal, ByVal lFiyat2 As Decimal, ByVal nIslemID2 As Int64, ByVal nStokID3 As Integer, ByVal lMiktar3 As Decimal, ByVal lIade3 As Decimal, ByVal lFiyat3 As Decimal, ByVal nIslemID3 As Int64, ByVal nStokID4 As Integer, ByVal lMiktar4 As Decimal, ByVal lIade4 As Decimal, ByVal lFiyat4 As Decimal, ByVal nIslemID4 As Int64, ByVal nStokID5 As Integer, ByVal lMiktar5 As Decimal, ByVal lIade5 As Decimal, ByVal lFiyat5 As Decimal, ByVal nIslemID5 As Int64, ByVal nStokID6 As Integer, ByVal lMiktar6 As Decimal, ByVal lIade6 As Decimal, ByVal lFiyat6 As Decimal, ByVal nIslemID6 As Int64, ByVal nStokID7 As Integer, ByVal lMiktar7 As Decimal, ByVal lIade7 As Decimal, ByVal lFiyat7 As Decimal, ByVal nIslemID7 As Int64, ByVal nStokID8 As Integer, ByVal lMiktar8 As Decimal, ByVal lIade8 As Decimal, ByVal lFiyat8 As Decimal, ByVal nIslemID8 As Int64, ByVal nStokID9 As Integer, ByVal lMiktar9 As Decimal, ByVal lIade9 As Decimal, ByVal lFiyat9 As Decimal, ByVal nIslemID9 As Int64, ByVal nStokID10 As Integer, ByVal lMiktar10 As Decimal, ByVal lIade10 As Decimal, ByVal lFiyat10 As Decimal, ByVal nIslemID10 As Int64, ByVal lTutar As Decimal, ByVal lTahsilat As Decimal, ByVal sOdemeSekli As String, ByVal nKasaIslemID As String, ByVal dteKayitTarihi As DateTime, ByVal sKullanici As String, ByVal nKdvOrani1 As Decimal, ByVal nKdvOrani2 As Decimal, ByVal nKdvOrani3 As Decimal, ByVal nKdvOrani4 As Decimal, ByVal nKdvOrani5 As Decimal, ByVal nKdvOrani6 As Decimal, ByVal nKdvOrani7 As Decimal, ByVal nKdvOrani8 As Decimal, ByVal nKdvOrani9 As Decimal, ByVal nKdvOrani10 As Decimal) As Int64
        Dim con As New OleDb.OleDbConnection
        Dim cmd As New OleDb.OleDbCommand
        cmd.Connection = con
        con.ConnectionString = sConnection
        If con.State = ConnectionState.Closed = True Then
            con.Open()
        End If
        cmd.CommandText = sorgu_query("SET DATEFORMAT DMY SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED INSERT INTO tbFirinServisDetay (nServisID, dteFisTarihi, sFisTipi ,nGirisCikis,lFisNo, sSaticiRumuzu, sServis, nSatir, bStatus, nFirmaID, sKodu, sAciklama, nIskontoYuzdesi, sFiyatTipi,  nStokFisiID, nStokID1, lMiktar1, lIade1, lFiyat1, nIslemID1, nStokID2, lMiktar2, lIade2, lFiyat2, nIslemID2, nStokID3, lMiktar3, lIade3, lFiyat3, nIslemID3, nStokID4, lMiktar4, lIade4, lFiyat4, nIslemID4, nStokID5, lMiktar5, lIade5, lFiyat5, nIslemID5, nStokID6, lMiktar6, lIade6, lFiyat6, nIslemID6, nStokID7, lMiktar7, lIade7, lFiyat7, nIslemID7, nStokID8, lMiktar8, lIade8, lFiyat8, nIslemID8, nStokID9, lMiktar9, lIade9, lFiyat9, nIslemID9, nStokID10, lMiktar10, lIade10, lFiyat10, nIslemID10, lTutar, lTahsilat, sOdemeSekli, nKasaIslemID, dteKayitTarihi, sKullanici,nKdvOrani1,nKdvOrani2,nKdvOrani3,nKdvOrani4,nKdvOrani5,nKdvOrani6,nKdvOrani7,nKdvOrani8,nKdvOrani9,nKdvOrani10) VALUES     (" & nServisID & ", '" & dteFisTarihi & "', '" & sFisTipi & "'," & nGirisCikis & "," & lFisNo & ", '" & sSaticiRumuzu & "', '" & sServis & "', " & nSatir & ", " & bStatus & ", " & nFirmaID & ", '" & sKodu & "', N'" & sAciklama & "', " & nIskontoYuzdesi & ", '" & sFiyatTipi & "', '" & nStokFisiID & "', " & nStokID1 & ", " & lMiktar1 & ", " & lIade1 & ", " & lFiyat1 & ", " & nIslemID1 & ", " & nStokID2 & ", " & lMiktar2 & ", " & lIade2 & ", " & lFiyat2 & ", " & nIslemID2 & ", " & nStokID3 & ", " & lMiktar3 & ", " & lIade3 & ", " & lFiyat3 & ", " & nIslemID3 & ", " & nStokID4 & ", " & lMiktar4 & ", " & lIade4 & ", " & lFiyat4 & ", " & nIslemID4 & ", " & nStokID5 & ", " & lMiktar5 & ", " & lIade5 & ", " & lFiyat5 & ", " & nIslemID5 & " , " & nStokID6 & ", " & lMiktar6 & ", " & lIade6 & ", " & lFiyat6 & ", " & nIslemID6 & ", " & nStokID7 & ",  " & lMiktar7 & ", " & lIade7 & ", " & lFiyat7 & ", " & nIslemID7 & ", " & nStokID8 & ", " & lMiktar8 & ", " & lIade8 & ", " & lFiyat8 & ", " & nIslemID8 & ", " & nStokID9 & ", " & lMiktar9 & ", " & lIade9 & ", " & lFiyat9 & ", " & nIslemID9 & ", " & nStokID10 & ", " & lMiktar10 & ",  " & lIade10 & ", " & lFiyat10 & ", " & nIslemID10 & ", " & lTutar & ", " & lTahsilat & ", '" & sOdemeSekli & "', '" & nKasaIslemID & "', '" & dteKayitTarihi & "', '" & sKullanici & "'," & nKdvOrani1 & "," & nKdvOrani2 & "," & nKdvOrani3 & "," & nKdvOrani4 & "," & nKdvOrani5 & "," & nKdvOrani6 & "," & nKdvOrani7 & "," & nKdvOrani8 & "," & nKdvOrani9 & "," & nKdvOrani10 & " )")
        cmd.ExecuteNonQuery()
        cmd.CommandText = "SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT @@identity"
        Dim kayitno = cmd.ExecuteScalar
        con.Close()
        Return kayitno
    End Function
    Private Sub tbFirinServis_kaydet_duzelt(ByVal nHareketID As Int64, ByVal nServisID As Int64, ByVal dteFisTarihi As DateTime, ByVal sFisTipi As String, ByVal nGirisCikis As Integer, ByVal lFisNo As Int64, ByVal sSaticiRumuzu As String, ByVal sServis As String, ByVal nSatir As Integer, ByVal bStatus As Integer, ByVal nFirmaID As Integer, ByVal sKodu As String, ByVal sAciklama As String, ByVal nIskontoYuzdesi As Decimal, ByVal sFiyatTipi As String, ByVal nStokFisiID As String, ByVal nStokID1 As Integer, ByVal lMiktar1 As Decimal, ByVal lIade1 As Decimal, ByVal lFiyat1 As Decimal, ByVal nIslemID1 As Int64, ByVal nStokID2 As Integer, ByVal lMiktar2 As Decimal, ByVal lIade2 As Decimal, ByVal lFiyat2 As Decimal, ByVal nIslemID2 As Int64, ByVal nStokID3 As Integer, ByVal lMiktar3 As Decimal, ByVal lIade3 As Decimal, ByVal lFiyat3 As Decimal, ByVal nIslemID3 As Int64, ByVal nStokID4 As Integer, ByVal lMiktar4 As Decimal, ByVal lIade4 As Decimal, ByVal lFiyat4 As Decimal, ByVal nIslemID4 As Int64, ByVal nStokID5 As Integer, ByVal lMiktar5 As Decimal, ByVal lIade5 As Decimal, ByVal lFiyat5 As Decimal, ByVal nIslemID5 As Int64, ByVal nStokID6 As Integer, ByVal lMiktar6 As Decimal, ByVal lIade6 As Decimal, ByVal lFiyat6 As Decimal, ByVal nIslemID6 As Int64, ByVal nStokID7 As Integer, ByVal lMiktar7 As Decimal, ByVal lIade7 As Decimal, ByVal lFiyat7 As Decimal, ByVal nIslemID7 As Int64, ByVal nStokID8 As Integer, ByVal lMiktar8 As Decimal, ByVal lIade8 As Decimal, ByVal lFiyat8 As Decimal, ByVal nIslemID8 As Int64, ByVal nStokID9 As Integer, ByVal lMiktar9 As Decimal, ByVal lIade9 As Decimal, ByVal lFiyat9 As Decimal, ByVal nIslemID9 As Int64, ByVal nStokID10 As Integer, ByVal lMiktar10 As Decimal, ByVal lIade10 As Decimal, ByVal lFiyat10 As Decimal, ByVal nIslemID10 As Int64, ByVal lTutar As Decimal, ByVal lTahsilat As Decimal, ByVal sOdemeSekli As String, ByVal nKasaIslemID As String, ByVal dteKayitTarihi As DateTime, ByVal sKullanici As String, ByVal nKdvOrani1 As Decimal, ByVal nKdvOrani2 As Decimal, ByVal nKdvOrani3 As Decimal, ByVal nKdvOrani4 As Decimal, ByVal nKdvOrani5 As Decimal, ByVal nKdvOrani6 As Decimal, ByVal nKdvOrani7 As Decimal, ByVal nKdvOrani8 As Decimal, ByVal nKdvOrani9 As Decimal, ByVal nKdvOrani10 As Decimal)
        Dim con As New OleDb.OleDbConnection
        Dim cmd As New OleDb.OleDbCommand
        cmd.Connection = con
        con.ConnectionString = sConnection
        If con.State = ConnectionState.Closed = True Then
            con.Open()
        End If
        cmd.CommandText = sorgu_query("SET DATEFORMAT DMY SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED UPDATE    tbFirinServisDetay SET             nSatir = " & nSatir & ", bStatus = " & bStatus & ", nIskontoYuzdesi = " & nIskontoYuzdesi & ", sFiyatTipi = '" & sFiyatTipi & "', nStokFisiID = '" & nStokFisiID & "', nStokID1 = " & nStokID1 & ", lMiktar1 = " & lMiktar1 & ", lIade1 = " & lIade1 & ", lFiyat1 = " & lFiyat1 & ", nIslemID1 = " & nIslemID1 & ", nStokID2 = " & nStokID2 & ", lMiktar2 = " & lMiktar2 & ", lIade2 = " & lIade2 & ", lFiyat2 = " & lFiyat2 & ", nIslemID2 = " & nIslemID2 & ", nStokID3 = " & nStokID3 & ", lMiktar3 = " & lMiktar3 & ", lIade3 = " & lIade3 & ", lFiyat3 = " & lFiyat3 & ", nIslemID3 = " & nIslemID3 & ", nStokID4 = " & nStokID4 & ", lMiktar4 = " & lMiktar4 & ", lIade4 = " & lIade4 & ", lFiyat4 = " & lFiyat4 & ", nIslemID4 = " & nIslemID4 & ", nStokID5 = " & nStokID5 & ", lMiktar5 = " & lMiktar5 & ", lIade5 = " & lIade5 & ", lFiyat5 = " & lFiyat5 & ", nIslemID5 = " & nIslemID5 & ", nStokID6 = " & nStokID6 & ", lMiktar6 = " & lMiktar6 & ", lIade6 = " & lIade6 & ", lFiyat6 = " & lFiyat6 & ", nIslemID6 = " & nIslemID6 & ", nStokID7 = " & nStokID7 & ", lMiktar7 = " & lMiktar7 & ", lIade7 = " & lIade7 & ", lFiyat7 = " & lFiyat7 & ", nIslemID7 = " & nIslemID7 & ", nStokID8 = " & nStokID8 & ", lMiktar8 =" & lMiktar8 & ", lIade8 = " & lIade8 & ", lFiyat8 = " & lFiyat8 & ", nIslemID8 = " & nIslemID8 & ", nStokID9 = " & nStokID9 & ", lMiktar9 = " & lMiktar9 & ", lIade9 = " & lIade9 & ", lFiyat9 = " & lFiyat9 & ", nIslemID9 = " & nIslemID9 & ", nStokID10 = " & nStokID10 & ", lMiktar10 = " & lMiktar10 & ", lIade10 = " & lIade10 & ", lFiyat10 = " & lFiyat10 & ", nIslemID10 = " & nIslemID10 & ", lTutar = " & lTutar & ", lTahsilat = " & lTahsilat & ", sOdemeSekli = '" & sOdemeSekli & "', nKasaIslemID = '" & nKasaIslemID & "',nKdvOrani1 = " & nKdvOrani1 & ",nKdvOrani2 = " & nKdvOrani2 & ",nKdvOrani3 = " & nKdvOrani3 & ",nKdvOrani4 = " & nKdvOrani4 & ",nKdvOrani5 = " & nKdvOrani5 & ",nKdvOrani6 = " & nKdvOrani6 & ",nKdvOrani7 = " & nKdvOrani7 & ",nKdvOrani8 = " & nKdvOrani8 & ",nKdvOrani9 = " & nKdvOrani9 & ",nKdvOrani10 = " & nKdvOrani10 & " Where  nHareketID = " & nHareketID & " AND  nServisID = " & nServisID & "")
        cmd.ExecuteNonQuery()
        con.Close()
    End Sub
    Private Sub tbFirinServis_kaydet_sil(ByVal nHareketID As Int64, ByVal nServisID As Int64)
        Dim con As New OleDb.OleDbConnection
        Dim cmd As New OleDb.OleDbCommand
        cmd.Connection = con
        con.ConnectionString = sConnection
        If con.State = ConnectionState.Closed = True Then
            con.Open()
        End If
        cmd.CommandText = sorgu_query("SET DATEFORMAT DMY SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED DELETE FROM tbFirinServisDetay  Where  nHareketID = " & nHareketID & " AND  nServisID = " & nServisID & "")
        cmd.ExecuteNonQuery()
        con.Close()
    End Sub
    Public Function sorgu_ntbFirinServisDetayi(ByVal nServisID As String, ByVal nFirmaID As String) As Int64
        'kriter = "WHERE (sKodu = '" & kod & "')  "
        Dim conn As New OleDb.OleDbConnection
        Dim cmd As New OleDb.OleDbCommand
        Dim adapter As New OleDb.OleDbDataAdapter
        'MsgBox(connection_resmi)
        conn.ConnectionString = sConnection
        cmd.Connection = conn
        conn.Open()
        cmd.CommandText = sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT     COUNT(*) AS nKayit FROM         tbFirinServisDetay WHERE     (nFirmaID = " & nFirmaID & ") AND (nServisID = " & nServisID & ")")
        Dim kayitsayisi = cmd.ExecuteScalar
        Return kayitsayisi
    End Function
    Public Function sorgu_nKasaIslemID() As Int64
        'Dim kriter As String = ""
        ''kriter = "WHERE (sKodu = '" & kod & "')  "
        'Dim conn As New OleDb.OleDbConnection
        'Dim cmd As New OleDb.OleDbCommand
        'Dim adapter As New OleDb.OleDbDataAdapter
        ''MsgBox(connection_resmi)
        'conn.ConnectionString = sConnection
        'cmd.Connection = conn
        'conn.Open()
        'cmd.CommandText = sorgu_query("SET DATEFORMAT DMY SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT     TOP 1 ISNULL(nKasaIslemID + 1, 0) AS nKasaIslemID  FROM         tbNakitKasa " & kriter & " ORDER BY nKasaIslemID DESC")
        'Dim kayitsayisi = cmd.ExecuteScalar
        'Return kayitsayisi
        Return 1
    End Function
    Private Sub nKasaIslemID_degistir(ByVal nKasaIslemID As String)
        Dim con As New OleDb.OleDbConnection
        Dim cmd As New OleDb.OleDbCommand
        Dim adapter As New OleDb.OleDbDataAdapter
        con.ConnectionString = sConnection
        cmd.Connection = con
        If con.State = ConnectionState.Closed Then
            con.Open()
        End If
        cmd.CommandText = sorgu_query("SET DATEFORMAT DMY SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED UPDATE    tbCariSiraNo SET              nSonID = '" & nKasaIslemID & "' where nSiraIndex = 2")
        cmd.ExecuteNonQuery()
        con.Close()
    End Sub
    Private Function tbNakitKasa_kaydet_yeni(ByVal nKasaIslemID As Int64, ByVal sSube As String, ByVal dteIslemTarihi As DateTime, ByVal lTahsilTutar As Decimal, ByVal lTediyeTutar As Decimal, ByVal sAciklama As String, ByVal nCariHareketID As Int64, ByVal nFirmaID As Int64, ByVal nHesapID As Int64, ByVal sHangiUygulama As String, ByVal sHareketTipi As String, ByVal sKullaniciAdi As String, ByVal dteKayitTarihi As DateTime, ByVal bMuhasebeyeIslendimi As Byte, ByVal sMasrafYontemi As String, ByVal sDovizCinsi1 As String, ByVal lDovizMiktari1 As Decimal, ByVal lDovizKuru1 As Decimal, ByVal sDovizCinsi2 As String, ByVal lDovizMiktari2 As Decimal, ByVal lDovizKuru2 As Decimal, ByVal sSonKullaniciAdi As String, ByVal dteSonUpdateTarihi As DateTime) As Int64
        Dim con As New OleDb.OleDbConnection
        Dim cmd As New OleDb.OleDbCommand
        cmd.Connection = con
        con.ConnectionString = sConnection
        If con.State = ConnectionState.Closed = True Then
            con.Open()
        End If
        cmd.CommandText = sorgu_query("SET DATEFORMAT DMY SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED INSERT INTO tbNakitKasa ( sSube, dteIslemTarihi, lTahsilTutar, lTediyeTutar, sAciklama, nCariHareketID, nFirmaID, nHesapID, sHangiUygulama, sHareketTipi, sKullaniciAdi, dteKayitTarihi, bMuhasebeyeIslendimi, sMasrafYontemi, sDovizCinsi1, lDovizMiktari1, lDovizKuru1, sDovizCinsi2, lDovizMiktari2, lDovizKuru2, sSonKullaniciAdi, dteSonUpdateTarihi) VALUES     ( '" & sSube & "', '" & dteIslemTarihi & "', " & lTahsilTutar & ", " & lTediyeTutar & ", N'" & sAciklama & "', " & nCariHareketID & ", " & nFirmaID & ", " & nHesapID & ", '" & sHangiUygulama & "', '" & sHareketTipi & "', '" & sKullaniciAdi & "', '" & dteKayitTarihi & "', " & bMuhasebeyeIslendimi & ", '" & sMasrafYontemi & "', '" & sDovizCinsi1 & "', " & lDovizMiktari1 & ", " & lDovizKuru1 & ", '" & sDovizCinsi2 & "', " & lDovizMiktari2 & ", " & lDovizKuru2 & ", '" & sSonKullaniciAdi & "', '" & dteSonUpdateTarihi & "')")
        cmd.ExecuteNonQuery()
        cmd.CommandText = "SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT @@identity"
        nKasaIslemID = cmd.ExecuteScalar
        Return nKasaIslemID
        con.Close()
    End Function
    Private Sub tbNakitKasa_kaydet_duzelt(ByVal nKasaIslemID As Int64, ByVal sSube As String, ByVal dteIslemTarihi As DateTime, ByVal lTahsilTutar As Decimal, ByVal lTediyeTutar As Decimal, ByVal sAciklama As String, ByVal nCariHareketID As Int64, ByVal nFirmaID As Int64, ByVal nHesapID As Int64, ByVal sHangiUygulama As String, ByVal sHareketTipi As String, ByVal sKullaniciAdi As String, ByVal dteKayitTarihi As DateTime, ByVal bMuhasebeyeIslendimi As Byte, ByVal sMasrafYontemi As String, ByVal sDovizCinsi1 As String, ByVal lDovizMiktari1 As Decimal, ByVal lDovizKuru1 As Decimal, ByVal sDovizCinsi2 As String, ByVal lDovizMiktari2 As Decimal, ByVal lDovizKuru2 As Decimal, ByVal sSonKullaniciAdi As String, ByVal dteSonUpdateTarihi As DateTime)
        Dim con As New OleDb.OleDbConnection
        Dim cmd As New OleDb.OleDbCommand
        cmd.Connection = con
        con.ConnectionString = sConnection
        If con.State = ConnectionState.Closed = True Then
            con.Open()
        End If
        cmd.CommandText = sorgu_query("SET DATEFORMAT DMY SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED UPDATE    tbNakitKasa SET              lTahsilTutar = " & lTahsilTutar & ", lTediyeTutar = " & lTediyeTutar & ", sAciklama = N'" & sAciklama & "', sHareketTipi = '" & sHareketTipi & "', sHangiUygulama = '" & sHangiUygulama & "',bMuhasebeyeIslendimi = " & bMuhasebeyeIslendimi & ", sMasrafYontemi = '" & sMasrafYontemi & "', sDovizCinsi1 = '" & sDovizCinsi1 & "', lDovizMiktari1 = " & lDovizMiktari1 & ", lDovizKuru1 = " & lDovizKuru1 & ", sDovizCinsi2 = '" & sDovizCinsi2 & "', lDovizMiktari2 = " & lDovizMiktari2 & ", lDovizKuru2 = " & lDovizKuru2 & ", sSonKullaniciAdi = '" & sSonKullaniciAdi & "', dteSonUpdateTarihi = '" & dteSonUpdateTarihi & "',dteIslemTarihi ='" & dteIslemTarihi & "' Where nKasaIslemID  ='" & nKasaIslemID & "'")
        cmd.ExecuteNonQuery()
        con.Close()
    End Sub
    Private Sub tbNakitKasa_kaydet_sil(ByVal nKasaIslemID As String, ByVal nCariHareketID As String)
        Dim con As New OleDb.OleDbConnection
        Dim cmd As New OleDb.OleDbCommand
        cmd.Connection = con
        con.ConnectionString = sConnection
        If con.State = ConnectionState.Closed = True Then
            con.Open()
        End If
        cmd.CommandText = sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED Select TOP 1 ISNULL(nCariHareketID,0) From tbNakitKasa Where nKasaIslemID = '" & nKasaIslemID & "' ")
        nCariHareketID = cmd.ExecuteScalar
        cmd.CommandText = sorgu_query("set implicit_transactions on")
        cmd.ExecuteNonQuery()
        Try
            cmd.CommandText = sorgu_query("SET DATEFORMAT DMY SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED ")
            cmd.ExecuteNonQuery()
            cmd.CommandText = sorgu_query("DELETE FROM tbNakitKasa Where nKasaIslemID = '" & nKasaIslemID & "'")
            cmd.ExecuteNonQuery()
            If nCariHareketID > 0 Then
                cmd.CommandText = sorgu_query("DELETE FROM tbFirmaHareketi Where nHareketID = '" & nCariHareketID & "'")
                cmd.ExecuteNonQuery()
            End If
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
    Private Function tbFirmaHareketi_kaydet_yeni(ByVal nHareketID As Int64, ByVal nFirmaID As Int64, ByVal dteIslemTarihi As DateTime, ByVal dteValorTarihi As DateTime, ByVal sCariIslem As String, ByVal sAciklama As String, ByVal lBorcTutar As Decimal, ByVal lAlacakTutar As Decimal, ByVal sEvrakNo As String, ByVal lVadeFarki As Decimal, ByVal sHangiUygulama As String, ByVal sHareketTipi As String, ByVal sKullaniciAdi As String, ByVal dteKayitTarihi As DateTime, ByVal sDovizCinsi1 As String, ByVal lDovizMiktari1 As Decimal, ByVal lDovizKuru1 As Decimal, ByVal sDovizCinsi2 As String, ByVal lDovizMiktari2 As Decimal, ByVal lDovizKuru2 As Decimal, ByVal sSonKullaniciAdi As String, ByVal dteSonUpdateTarihi As DateTime, ByVal bPesinmi As Boolean, Optional ByVal nKasaIslemID As String = "0") As Int64
        Dim cmd As New OleDb.OleDbCommand
        Dim con As New OleDb.OleDbConnection
        cmd.Connection = con
        con.ConnectionString = sConnection
        If con.State = ConnectionState.Closed = True Then
            con.Open()
        End If
        cmd.CommandText = sorgu_query("SET DATEFORMAT DMY  INSERT INTO tbFirmaHareketi                       (nFirmaID, dteIslemTarihi, dteValorTarihi, sCariIslem, sAciklama, lBorcTutar, lAlacakTutar, sEvrakNo, lVadeFarki, sHangiUygulama, sHareketTipi, sKullaniciAdi, dteKayitTarihi, sDovizCinsi1, lDovizMiktari1, lDovizKuru1, sDovizCinsi2, lDovizMiktari2, lDovizKuru2, sSonKullaniciAdi, dteSonUpdateTarihi) VALUES     ('" & nFirmaID & "', '" & dteIslemTarihi & "', '" & dteValorTarihi & "', '" & sCariIslem & "', N'" & sAciklama & "', " & lBorcTutar & ", " & lAlacakTutar & " , '" & sEvrakNo & "', " & lVadeFarki & ", '" & sHangiUygulama & "', '" & sHareketTipi & "', '" & sKullaniciAdi & "', '" & dteKayitTarihi & "', '" & sDovizCinsi1 & "', " & lDovizMiktari1 & ", " & lDovizKuru1 & " , '" & sDovizCinsi2 & "', " & lDovizMiktari2 & ", " & lDovizKuru2 & " , '" & sSonKullaniciAdi & "', '" & dteSonUpdateTarihi & "')")
        cmd.ExecuteNonQuery()
        cmd.CommandText = "SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT @@identity"
        nHareketID = cmd.ExecuteScalar
        Return nHareketID
        con.Close()
        If bPesinmi = True Then
            Dim dr As DataRow
            dr = GridView1.GetDataRow(GridView1.FocusedRowHandle)
            nKasaIslemID = sorgu_nKasaIslemID()
            nKasaIslemID = tbNakitKasa_kaydet_yeni(nKasaIslemID, "001", dteIslemTarihi, lAlacakTutar, lBorcTutar, "Tahsilat No :" & sEvrakNo & " - " & Microsoft.VisualBasic.Left(Trim(dr("sAciklama").ToString), 20), nHareketID, nFirmaID, 0, sHangiUygulama, sHareketTipi, sKullanici, Now, 0, "", sDovizCinsi1, lDovizMiktari1, lDovizKuru1, sDovizCinsi2, lDovizMiktari2, lDovizKuru2, sKullanici, Now)
            nKasaIslemID_degistir(nKasaIslemID)
            dr("nKasaIslemID") = nKasaIslemID.ToString
        End If
        cmd = Nothing
        con = Nothing
    End Function
    Private Sub tbFirmaHareketi_kaydet_duzelt(ByVal nStokFisiID As String, ByVal nHareketID As Int64, ByVal nFirmaID As Int64, ByVal dteIslemTarihi As DateTime, ByVal dteValorTarihi As DateTime, ByVal sCariIslem As String, ByVal sAciklama As String, ByVal lBorcTutar As Decimal, ByVal lAlacakTutar As Decimal, ByVal sEvrakNo As String, ByVal lVadeFarki As Decimal, ByVal sHangiUygulama As String, ByVal sHareketTipi As String, ByVal sKullaniciAdi As String, ByVal dteKayitTarihi As DateTime, ByVal sDovizCinsi1 As String, ByVal lDovizMiktari1 As Decimal, ByVal lDovizKuru1 As Decimal, ByVal sDovizCinsi2 As String, ByVal lDovizMiktari2 As Decimal, ByVal lDovizKuru2 As Decimal, ByVal sSonKullaniciAdi As String, ByVal dteSonUpdateTarihi As DateTime, ByVal bPesinmi As Boolean, Optional ByVal nKasaIslemID As String = "0")
        Dim cmd As New OleDb.OleDbCommand
        Dim con As New OleDb.OleDbConnection
        cmd.Connection = con
        con.ConnectionString = sConnection
        If con.State = ConnectionState.Closed = True Then
            con.Open()
        End If
        cmd.CommandText = sorgu_query("SET DATEFORMAT DMY  UPDATE    tbFirmaHareketi SET              nFirmaID = '" & nFirmaID & "', dteIslemTarihi = '" & dteIslemTarihi & "', dteValorTarihi = '" & dteValorTarihi & "', sCariIslem = '" & sCariIslem & "', sAciklama = 'Evrak No: " & sEvrakNo & "', lBorcTutar = " & lBorcTutar & ", lAlacakTutar = " & lAlacakTutar & ", sEvrakNo = '" & sEvrakNo & "', lVadeFarki = " & lVadeFarki & ", sHangiUygulama = '" & sHangiUygulama & "', sHareketTipi = '" & sHareketTipi & "', sDovizCinsi1 = '" & sDovizCinsi1 & "', lDovizMiktari1 = " & lDovizMiktari1 & ", lDovizKuru1 = " & lDovizKuru1 & ", sDovizCinsi2 = '" & sDovizCinsi2 & "', lDovizMiktari2 = " & lDovizMiktari2 & ", lDovizKuru2 = " & lDovizKuru2 & ", sSonKullaniciAdi = '" & sSonKullaniciAdi & "', dteSonUpdateTarihi = '" & dteSonUpdateTarihi & "'  WHERE     (nHareketID IN  (SELECT     nCariHareketID FROM          tbStokFisiOdemePlani WHERE      (nStokFisiID = '" & nStokFisiID & "' )))")
        cmd.ExecuteNonQuery()
        If bPesinmi = True Then
            Dim dr As DataRow
            dr = GridView1.GetDataRow(GridView1.FocusedRowHandle)
            If nKasaIslemID <> "" Then
                tbNakitKasa_kaydet_duzelt(nKasaIslemID, "001", dteIslemTarihi, lBorcTutar, lAlacakTutar, "Tahsilat No :" & sEvrakNo & " - " & Microsoft.VisualBasic.Left(Trim(dr("sAciklama").ToString), 20), nHareketID, nFirmaID, 0, sHangiUygulama, sHareketTipi, sKullanici, dr_baslik("dteKayitTarihi"), 0, "", sDovizCinsi1, lDovizMiktari1, lDovizKuru1, sDovizCinsi2, lDovizMiktari2, lDovizKuru2, sKullanici, Now)
                cmd.CommandText = sorgu_query("SET DATEFORMAT DMY  UPDATE    tbFirmaHareketi SET              nFirmaID = '" & nFirmaID & "', dteIslemTarihi = '" & dteIslemTarihi & "', dteValorTarihi = '" & dteValorTarihi & "', sCariIslem = 'N', sAciklama = '" & "Tahsilat :" & sEvrakNo & " - " & Microsoft.VisualBasic.Left(Trim(dr("sAciklama").ToString), 20) & "', lBorcTutar = " & lAlacakTutar & ", lAlacakTutar = " & lBorcTutar & ", sEvrakNo = '" & lFisNo & "', lVadeFarki = " & lVadeFarki & ", sHangiUygulama = 'KASA', sHareketTipi = '" & sHareketTipi & "', sDovizCinsi1 = '" & sDovizCinsi1 & "', lDovizMiktari1 = " & lDovizMiktari1 & ", lDovizKuru1 = " & lDovizKuru1 & ", sDovizCinsi2 = '" & sDovizCinsi2 & "', lDovizMiktari2 = " & lDovizMiktari2 & ", lDovizKuru2 = " & lDovizKuru2 & ", sSonKullaniciAdi = '" & sSonKullaniciAdi & "', dteSonUpdateTarihi = '" & dteSonUpdateTarihi & "'  WHERE     (nHareketID IN  (SELECT     nCariHareketID FROM          tbNakitKasa WHERE      (nKasaIslemID = '" & nKasaIslemID & "' )))")
                cmd.ExecuteNonQuery()
            End If
        End If
        con.Close()
        cmd = Nothing
        con = Nothing
    End Sub
    Private Sub tbFirmaHareketi_nCariHareketID_degistir(ByVal nCariHareketID As String)
        Dim con As New OleDb.OleDbConnection
        Dim cmd As New OleDb.OleDbCommand
        con.ConnectionString = sConnection
        cmd.Connection = con
        If con.State = ConnectionState.Closed Then
            con.Open()
        End If
        cmd.CommandText = sorgu_query("SET DATEFORMAT DMY SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED UPDATE    tbCariSiraNo SET              nSonID = '" & nCariHareketID & "' where nSiraIndex = 1")
        cmd.ExecuteNonQuery()
        con.Close()
        cmd = Nothing
        con = Nothing
    End Sub
    Private Sub BarButtonItem12_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem12.ItemClick
        If Me.WindowState = FormWindowState.Normal Then
            Me.WindowState = FormWindowState.Maximized
        ElseIf Me.WindowState = FormWindowState.Maximized Then
            Me.WindowState = FormWindowState.Normal
        End If
    End Sub
    Private Sub frm_tbFirinServis_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'Try
        '    sDepo = Registry.CurrentUser.OpenSubKey("Software").OpenSubKey("BusinessSmart").OpenSubKey("MAGAZA").GetValue("DEPOKODU").ToString
        'Catch ex As Exception
        '    sDepo = " "
        '    Registry.CurrentUser.CreateSubKey("Software").CreateSubKey("BusinessSmart").CreateSubKey("MAGAZA").SetValue("DEPOKODU", sDepo)
        'End Try
        Try
            gorunum_yukle()
        Catch ex As Exception
        End Try
        If Trim(FisTipi) = "S" Then
            sFisTipi = "FS "
            nGirisCikis = GirisCikis
            Me.Text = "Servis Fiþi"
        ElseIf Trim(FisTipi) = "U" Then
            sFisTipi = "DG "
            nGirisCikis = GirisCikis
            sFiyat1 = sFiyatM
            Me.Text = "Üretim Çýktýlarý"
            Me.collTutar.Visible = False
            Me.collTahsilat.Visible = False
            Me.colsOdemeSekli.Visible = False
        ElseIf Trim(FisTipi) = "C" Then
            sFisTipi = "DC "
            nGirisCikis = GirisCikis
            Me.Text = "Hammadde Çýkýþý"
            Me.collTutar.Visible = False
            Me.collTahsilat.Visible = False
            Me.colsOdemeSekli.Visible = False
        End If
        Dataload_tbStokSinifi(FisTipi)
        dataload_tbOdemeSekli()
        dataload_tbHareketTipi()
        dataload_tbSaticiRumuzu()
        'Try
        loaded()
        'Catch ex As Exception
        '    XtraMessageBox.Show(Sorgu_sDil("Hatalý Islem, Lütfen Tekrar Deneyiniz...!",sDil), MessageBoxIcon.Warning, sorgu_sDil("Dikkat",sDil))
        'End Try
        yuklendi = True
        status = True
        GridControl1.Focus()
        GridControl1.Select()
        Dim dr2 As DataRow = ds_tbStokSinifi.Tables(0).Rows(0)
        Try
            collMiktar1.Caption = Trim(dr2("sAciklama"))
            collIade1.Caption = Trim(dr2("sAciklama")) & " Ýade"
            collFiyat1.Caption = Trim(dr2("sAciklama")) & " Fiyat"
            rowMiktar1.Properties.Caption = collMiktar1.Caption
        Catch ex As Exception
            collMiktar1.Caption = "Miktar1"
            collMiktar1.Visible = False
            collIade1.Caption = "Miktar1" & " Ýade"
            collIade1.Visible = False
            collFiyat1.Caption = "Miktar1" & " Fiyat"
            collFiyat1.Visible = False
        End Try
        Try
            dr2 = ds_tbStokSinifi.Tables(0).Rows(1)
            collMiktar2.Caption = Trim(dr2("sAciklama"))
            collIade2.Caption = Trim(dr2("sAciklama")) & " Ýade"
            collFiyat2.Caption = Trim(dr2("sAciklama")) & " Fiyat"
            rowMiktar2.Properties.Caption = collMiktar2.Caption
        Catch ex As Exception
            collMiktar2.Caption = "Miktar2"
            collMiktar2.Visible = False
            collIade2.Caption = "Miktar2" & " Ýade"
            collIade2.Visible = False
            collFiyat2.Caption = "Miktar2" & " Fiyat"
            collFiyat2.Visible = False
        End Try
        Try
            dr2 = ds_tbStokSinifi.Tables(0).Rows(2)
            collMiktar3.Caption = Trim(dr2("sAciklama"))
            collIade3.Caption = Trim(dr2("sAciklama")) & " Ýade"
            collFiyat3.Caption = Trim(dr2("sAciklama")) & " Fiyat"
            rowMiktar3.Properties.Caption = collMiktar3.Caption
        Catch ex As Exception
            collMiktar3.Caption = "Miktar3"
            collMiktar3.Visible = False
            collIade3.Caption = "Miktar3" & " Ýade"
            collIade3.Visible = False
            collFiyat3.Caption = "Miktar3" & " Fiyat"
            collFiyat3.Visible = False
        End Try
        Try
            dr2 = ds_tbStokSinifi.Tables(0).Rows(3)
            collMiktar4.Caption = Trim(dr2("sAciklama"))
            collIade4.Caption = Trim(dr2("sAciklama")) & " Ýade"
            collFiyat4.Caption = Trim(dr2("sAciklama")) & " Fiyat"
            rowMiktar4.Properties.Caption = collMiktar4.Caption
        Catch ex As Exception
            collMiktar4.Caption = "Miktar4"
            collMiktar4.Visible = False
            collIade4.Caption = "Miktar4" & " Ýade"
            collIade4.Visible = False
            collFiyat4.Caption = "Miktar4" & " Fiyat"
            collFiyat4.Visible = False
        End Try
        Try
            dr2 = ds_tbStokSinifi.Tables(0).Rows(4)
            collMiktar5.Caption = Trim(dr2("sAciklama"))
            collIade5.Caption = Trim(dr2("sAciklama")) & " Ýade"
            collFiyat5.Caption = Trim(dr2("sAciklama")) & " Fiyat"
            rowMiktar5.Properties.Caption = collMiktar5.Caption
        Catch ex As Exception
            collMiktar5.Caption = "Miktar5"
            collMiktar5.Visible = False
            collIade5.Caption = "Miktar5" & " Ýade"
            collIade5.Visible = False
            collFiyat5.Caption = "Miktar5" & " Fiyat"
            collFiyat5.Visible = False
        End Try
        Try
            dr2 = ds_tbStokSinifi.Tables(0).Rows(5)
            collMiktar6.Caption = Trim(dr2("sAciklama"))
            collIade6.Caption = Trim(dr2("sAciklama")) & " Ýade"
            collFiyat6.Caption = Trim(dr2("sAciklama")) & " Fiyat"
            rowMiktar6.Properties.Caption = collMiktar6.Caption
        Catch ex As Exception
            collMiktar6.Caption = "Miktar6"
            collMiktar6.Visible = False
            collIade6.Caption = "Miktar6" & " Ýade"
            collIade6.Visible = False
            collFiyat6.Caption = "Miktar6" & " Fiyat"
            collFiyat6.Visible = False
        End Try
        Try
            dr2 = ds_tbStokSinifi.Tables(0).Rows(6)
            collMiktar7.Caption = Trim(dr2("sAciklama"))
            collIade7.Caption = Trim(dr2("sAciklama")) & " Ýade"
            collFiyat7.Caption = Trim(dr2("sAciklama")) & " Fiyat"
            rowMiktar7.Properties.Caption = collMiktar7.Caption
        Catch ex As Exception
            collMiktar7.Caption = "Miktar7"
            collMiktar7.Visible = False
            collIade7.Caption = "Miktar7" & " Ýade"
            collIade7.Visible = False
            collFiyat7.Caption = "Miktar7" & " Fiyat"
            collFiyat7.Visible = False
        End Try
        Try
            dr2 = ds_tbStokSinifi.Tables(0).Rows(7)
            collMiktar8.Caption = Trim(dr2("sAciklama"))
            collIade8.Caption = Trim(dr2("sAciklama")) & " Ýade"
            collFiyat8.Caption = Trim(dr2("sAciklama")) & " Fiyat"
            rowMiktar8.Properties.Caption = collMiktar8.Caption
        Catch ex As Exception
            collMiktar8.Caption = "Miktar8"
            collMiktar8.Visible = False
            collIade8.Caption = "Miktar8" & " Ýade"
            collIade8.Visible = False
            collFiyat8.Caption = "Miktar8" & " Fiyat"
            collFiyat8.Visible = False
        End Try
        Try
            dr2 = ds_tbStokSinifi.Tables(0).Rows(8)
            collMiktar9.Caption = Trim(dr2("sAciklama"))
            collIade9.Caption = Trim(dr2("sAciklama")) & " Ýade"
            collFiyat9.Caption = Trim(dr2("sAciklama")) & " Fiyat"
            rowMiktar9.Properties.Caption = collMiktar9.Caption
        Catch ex As Exception
            collMiktar9.Caption = "Miktar9"
            collMiktar9.Visible = False
            collIade9.Caption = "Miktar9" & " Ýade"
            collIade9.Visible = False
            collFiyat9.Caption = "Miktar9" & " Fiyat"
            collFiyat9.Visible = False
        End Try
        Try
            dr2 = ds_tbStokSinifi.Tables(0).Rows(9)
            collMiktar10.Caption = Trim(dr2("sAciklama"))
            collIade10.Caption = Trim(dr2("sAciklama")) & " Ýade"
            collFiyat10.Caption = Trim(dr2("sAciklama")) & " Fiyat"
            rowMiktar10.Properties.Caption = collMiktar10.Caption
        Catch ex As Exception
            collMiktar10.Caption = "Miktar10"
            collMiktar10.Visible = False
            collIade10.Caption = "Miktar10" & " Ýade"
            collIade10.Visible = False
            collFiyat10.Caption = "Miktar10" & " Fiyat"
            collFiyat10.Visible = False
        End Try
        dr2 = Nothing
        If GridView1.RowCount = 0 Then
            If Trim(FisTipi) <> "S" Then
                satir_ekle_direkt()
            End If
        Else
        End If
    End Sub
    Private Sub loaded()
        dataload_baslik()
        dr_baslik = ds_baslik.Tables(0).Rows(0)
        Dataload_tbFirinServis(dr_baslik("nServisID"))
    End Sub
    Private Sub dataload_tbHareketTipi()
        ds_tbHareketTipi = sorgu(sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT 'S ' AS sServis, 'Sabah' AS sAciklama UNION ALL SELECT 'O ' AS sServis, 'Oglen' AS sAciklama UNION ALL SELECT 'A ' AS sServis, 'Aksam' AS sAciklama UNION ALL SELECT 'D ' AS sServis, 'ServisDýþý' AS sAciklama"))
        sec_sHareketTipi.DataSource = ds_tbHareketTipi.Tables(0)
        'sec_sHareketTipi.ItemIndex = 1
    End Sub
    Private Sub dataload_tbSaticiRumuzu()
        ds_tbSatici = sorgu(sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT     sSinifKodu,sAciklama FROM         tbFSinif1"))
        sec_sSaticiRumuzu.DataSource = ds_tbSatici.Tables(0)
        'sec_sHareketTipi.ItemIndex = 1
    End Sub
    Private Sub Dataload_tbStokSinifi(ByVal sFisTipi As String)
        Dim kriter As String = ""
        kriter += " SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED "
        kriter += " SELECT TOP 1 1 AS nSatir, tbFirin.Param.sFisTipi, tbStok.nStokID, tbStok.sKodu, tbStok.sAciklama, tbStok.sRenk, tbStok.sBeden, tbStok.nFiyatlandirma, tbStok.sModel, (SELECT isnull(SUM(tbStokFisiDetayi.lGirisMiktar1 - tbStokFisiDetayi.lCikisMiktar1) , 0) FROM tbStokFisiDetayi WHERE tbStok.nStokID = tbStokFisiDetayi.nStokID) AS Mevcut, ISNULL((SELECT isnull(lfiyat , 0) FROM tbstokfiyati WHERE nStokId = tbStok.NstokId AND sFiyatTipi = '" & sFiyat1 & "'), 0) AS FIYAT1, ISNULL((SELECT isnull(lfiyat , 0) FROM tbstokfiyati WHERE nStokId = tbStok.NstokId AND sFiyatTipi = '" & sFiyat2 & "'), 0) AS FIYAT2, ISNULL((SELECT isnull(lfiyat , 0) FROM tbstokfiyati WHERE nStokId = tbStok.NstokId AND sFiyatTipi = '" & sFiyat3 & "'), 0) AS FIYAT3,(SELECT     nKdvOrani FROM         tbKdv Where sKdvTipi = tbStok.sKdvTipi) as nKdvOrani FROM tbFirinParam LEFT OUTER JOIN tbStok ON tbFirinParam.nStokID1 = tbStok.nStokID WHERE (tbFirinParam.sFisTipi = '" & sFisTipi & "') "
        kriter += " UNION ALL"
        kriter += " SELECT TOP 1 2 AS nSatir,tbFirin.Param.sFisTipi, tbStok.nStokID, tbStok.sKodu, tbStok.sAciklama, tbStok.sRenk, tbStok.sBeden, tbStok.nFiyatlandirma, tbStok.sModel, (SELECT isnull(SUM(tbStokFisiDetayi.lGirisMiktar1 - tbStokFisiDetayi.lCikisMiktar1) , 0) FROM tbStokFisiDetayi WHERE tbStok.nStokID = tbStokFisiDetayi.nStokID) AS Mevcut, ISNULL((SELECT isnull(lfiyat , 0) FROM tbstokfiyati WHERE nStokId = tbStok.NstokId AND sFiyatTipi = '" & sFiyat1 & "'), 0) AS FIYAT1, ISNULL((SELECT isnull(lfiyat , 0) FROM tbstokfiyati WHERE nStokId = tbStok.NstokId AND sFiyatTipi = '" & sFiyat2 & "'), 0) AS FIYAT2, ISNULL((SELECT isnull(lfiyat , 0) FROM tbstokfiyati WHERE nStokId = tbStok.NstokId AND sFiyatTipi = '" & sFiyat3 & "'), 0) AS FIYAT3,(SELECT     nKdvOrani FROM         tbKdv Where sKdvTipi = tbStok.sKdvTipi) as nKdvOrani FROM tbFirinParam LEFT OUTER JOIN tbStok ON tbFirinParam.nStokID2 = tbStok.nStokID WHERE (tbFirinParam.sFisTipi = '" & sFisTipi & "') "
        kriter += " UNION ALL"
        kriter += " SELECT TOP 1 3 AS nSatir,tbFirin.Param.sFisTipi, tbStok.nStokID, tbStok.sKodu, tbStok.sAciklama, tbStok.sRenk, tbStok.sBeden, tbStok.nFiyatlandirma, tbStok.sModel, (SELECT isnull(SUM(tbStokFisiDetayi.lGirisMiktar1 - tbStokFisiDetayi.lCikisMiktar1) , 0) FROM tbStokFisiDetayi WHERE tbStok.nStokID = tbStokFisiDetayi.nStokID) AS Mevcut, ISNULL((SELECT isnull(lfiyat , 0) FROM tbstokfiyati WHERE nStokId = tbStok.NstokId AND sFiyatTipi = '" & sFiyat1 & "'), 0) AS FIYAT1, ISNULL((SELECT isnull(lfiyat , 0) FROM tbstokfiyati WHERE nStokId = tbStok.NstokId AND sFiyatTipi = '" & sFiyat2 & "'), 0) AS FIYAT2, ISNULL((SELECT isnull(lfiyat , 0) FROM tbstokfiyati WHERE nStokId = tbStok.NstokId AND sFiyatTipi = '" & sFiyat3 & "'), 0) AS FIYAT3,(SELECT     nKdvOrani FROM         tbKdv Where sKdvTipi = tbStok.sKdvTipi) as nKdvOrani FROM tbFirinParam LEFT OUTER JOIN tbStok ON tbFirinParam.nStokID3 = tbStok.nStokID WHERE (tbFirinParam.sFisTipi = '" & sFisTipi & "') "
        kriter += " UNION ALL"
        kriter += " SELECT TOP 1 4 AS nSatir,tbFirin.Param.sFisTipi, tbStok.nStokID, tbStok.sKodu, tbStok.sAciklama, tbStok.sRenk, tbStok.sBeden, tbStok.nFiyatlandirma, tbStok.sModel, (SELECT isnull(SUM(tbStokFisiDetayi.lGirisMiktar1 - tbStokFisiDetayi.lCikisMiktar1) , 0) FROM tbStokFisiDetayi WHERE tbStok.nStokID = tbStokFisiDetayi.nStokID) AS Mevcut, ISNULL((SELECT isnull(lfiyat , 0) FROM tbstokfiyati WHERE nStokId = tbStok.NstokId AND sFiyatTipi = '" & sFiyat1 & "'), 0) AS FIYAT1, ISNULL((SELECT isnull(lfiyat , 0) FROM tbstokfiyati WHERE nStokId = tbStok.NstokId AND sFiyatTipi = '" & sFiyat2 & "'), 0) AS FIYAT2, ISNULL((SELECT isnull(lfiyat , 0) FROM tbstokfiyati WHERE nStokId = tbStok.NstokId AND sFiyatTipi = '" & sFiyat3 & "'), 0) AS FIYAT3,(SELECT     nKdvOrani FROM         tbKdv Where sKdvTipi = tbStok.sKdvTipi) as nKdvOrani FROM tbFirinParam LEFT OUTER JOIN tbStok ON tbFirinParam.nStokID4 = tbStok.nStokID WHERE (tbFirinParam.sFisTipi = '" & sFisTipi & "') "
        kriter += " UNION ALL"
        kriter += " SELECT TOP 1 5 AS nSatir,tbFirin.Param.sFisTipi, tbStok.nStokID, tbStok.sKodu, tbStok.sAciklama, tbStok.sRenk, tbStok.sBeden, tbStok.nFiyatlandirma, tbStok.sModel, (SELECT isnull(SUM(tbStokFisiDetayi.lGirisMiktar1 - tbStokFisiDetayi.lCikisMiktar1) , 0) FROM tbStokFisiDetayi WHERE tbStok.nStokID = tbStokFisiDetayi.nStokID) AS Mevcut, ISNULL((SELECT isnull(lfiyat , 0) FROM tbstokfiyati WHERE nStokId = tbStok.NstokId AND sFiyatTipi = '" & sFiyat1 & "'), 0) AS FIYAT1, ISNULL((SELECT isnull(lfiyat , 0) FROM tbstokfiyati WHERE nStokId = tbStok.NstokId AND sFiyatTipi = '" & sFiyat2 & "'), 0) AS FIYAT2, ISNULL((SELECT isnull(lfiyat , 0) FROM tbstokfiyati WHERE nStokId = tbStok.NstokId AND sFiyatTipi = '" & sFiyat3 & "'), 0) AS FIYAT3,(SELECT     nKdvOrani FROM         tbKdv Where sKdvTipi = tbStok.sKdvTipi) as nKdvOrani FROM tbFirinParam LEFT OUTER JOIN tbStok ON tbFirinParam.nStokID5 = tbStok.nStokID WHERE (tbFirinParam.sFisTipi = '" & sFisTipi & "') "
        kriter += " UNION ALL"
        kriter += " SELECT TOP 1 6 AS nSatir,tbFirin.Param.sFisTipi, tbStok.nStokID, tbStok.sKodu, tbStok.sAciklama, tbStok.sRenk, tbStok.sBeden, tbStok.nFiyatlandirma, tbStok.sModel, (SELECT isnull(SUM(tbStokFisiDetayi.lGirisMiktar1 - tbStokFisiDetayi.lCikisMiktar1) , 0) FROM tbStokFisiDetayi WHERE tbStok.nStokID = tbStokFisiDetayi.nStokID) AS Mevcut, ISNULL((SELECT isnull(lfiyat , 0) FROM tbstokfiyati WHERE nStokId = tbStok.NstokId AND sFiyatTipi = '" & sFiyat1 & "'), 0) AS FIYAT1, ISNULL((SELECT isnull(lfiyat , 0) FROM tbstokfiyati WHERE nStokId = tbStok.NstokId AND sFiyatTipi = '" & sFiyat2 & "'), 0) AS FIYAT2, ISNULL((SELECT isnull(lfiyat , 0) FROM tbstokfiyati WHERE nStokId = tbStok.NstokId AND sFiyatTipi = '" & sFiyat3 & "'), 0) AS FIYAT3,(SELECT     nKdvOrani FROM         tbKdv Where sKdvTipi = tbStok.sKdvTipi) as nKdvOrani FROM tbFirinParam LEFT OUTER JOIN tbStok ON tbFirinParam.nStokID6 = tbStok.nStokID WHERE (tbFirinParam.sFisTipi = '" & sFisTipi & "') "
        kriter += " UNION ALL"
        kriter += " SELECT TOP 1 7 AS nSatir,tbFirin.Param.sFisTipi, tbStok.nStokID, tbStok.sKodu, tbStok.sAciklama, tbStok.sRenk, tbStok.sBeden, tbStok.nFiyatlandirma, tbStok.sModel, (SELECT isnull(SUM(tbStokFisiDetayi.lGirisMiktar1 - tbStokFisiDetayi.lCikisMiktar1) , 0) FROM tbStokFisiDetayi WHERE tbStok.nStokID = tbStokFisiDetayi.nStokID) AS Mevcut, ISNULL((SELECT isnull(lfiyat , 0) FROM tbstokfiyati WHERE nStokId = tbStok.NstokId AND sFiyatTipi = '" & sFiyat1 & "'), 0) AS FIYAT1, ISNULL((SELECT isnull(lfiyat , 0) FROM tbstokfiyati WHERE nStokId = tbStok.NstokId AND sFiyatTipi = '" & sFiyat2 & "'), 0) AS FIYAT2, ISNULL((SELECT isnull(lfiyat , 0) FROM tbstokfiyati WHERE nStokId = tbStok.NstokId AND sFiyatTipi = '" & sFiyat3 & "'), 0) AS FIYAT3,(SELECT     nKdvOrani FROM         tbKdv Where sKdvTipi = tbStok.sKdvTipi) as nKdvOrani FROM tbFirinParam LEFT OUTER JOIN tbStok ON tbFirinParam.nStokID7 = tbStok.nStokID WHERE (tbFirinParam.sFisTipi = '" & sFisTipi & "') "
        kriter += " UNION ALL"
        kriter += " SELECT TOP 1 8 AS nSatir,tbFirin.Param.sFisTipi, tbStok.nStokID, tbStok.sKodu, tbStok.sAciklama, tbStok.sRenk, tbStok.sBeden, tbStok.nFiyatlandirma, tbStok.sModel, (SELECT isnull(SUM(tbStokFisiDetayi.lGirisMiktar1 - tbStokFisiDetayi.lCikisMiktar1) , 0) FROM tbStokFisiDetayi WHERE tbStok.nStokID = tbStokFisiDetayi.nStokID) AS Mevcut, ISNULL((SELECT isnull(lfiyat , 0) FROM tbstokfiyati WHERE nStokId = tbStok.NstokId AND sFiyatTipi = '" & sFiyat1 & "'), 0) AS FIYAT1, ISNULL((SELECT isnull(lfiyat , 0) FROM tbstokfiyati WHERE nStokId = tbStok.NstokId AND sFiyatTipi = '" & sFiyat2 & "'), 0) AS FIYAT2, ISNULL((SELECT isnull(lfiyat , 0) FROM tbstokfiyati WHERE nStokId = tbStok.NstokId AND sFiyatTipi = '" & sFiyat3 & "'), 0) AS FIYAT3,(SELECT     nKdvOrani FROM         tbKdv Where sKdvTipi = tbStok.sKdvTipi) as nKdvOrani FROM tbFirinParam LEFT OUTER JOIN tbStok ON tbFirinParam.nStokID8 = tbStok.nStokID WHERE (tbFirinParam.sFisTipi = '" & sFisTipi & "') "
        kriter += " UNION ALL"
        kriter += " SELECT TOP 1 9 AS nSatir,tbFirin.Param.sFisTipi, tbStok.nStokID, tbStok.sKodu, tbStok.sAciklama, tbStok.sRenk, tbStok.sBeden, tbStok.nFiyatlandirma, tbStok.sModel, (SELECT isnull(SUM(tbStokFisiDetayi.lGirisMiktar1 - tbStokFisiDetayi.lCikisMiktar1) , 0) FROM tbStokFisiDetayi WHERE tbStok.nStokID = tbStokFisiDetayi.nStokID) AS Mevcut, ISNULL((SELECT isnull(lfiyat , 0) FROM tbstokfiyati WHERE nStokId = tbStok.NstokId AND sFiyatTipi = '" & sFiyat1 & "'), 0) AS FIYAT1, ISNULL((SELECT isnull(lfiyat , 0) FROM tbstokfiyati WHERE nStokId = tbStok.NstokId AND sFiyatTipi = '" & sFiyat2 & "'), 0) AS FIYAT2, ISNULL((SELECT isnull(lfiyat , 0) FROM tbstokfiyati WHERE nStokId = tbStok.NstokId AND sFiyatTipi = '" & sFiyat3 & "'), 0) AS FIYAT3,(SELECT     nKdvOrani FROM         tbKdv Where sKdvTipi = tbStok.sKdvTipi) as nKdvOrani FROM tbFirinParam LEFT OUTER JOIN tbStok ON tbFirinParam.nStokID9 = tbStok.nStokID WHERE (tbFirinParam.sFisTipi = '" & sFisTipi & "') "
        kriter += " UNION ALL"
        kriter += " SELECT TOP 1 10 AS nSatir,tbFirin.Param.sFisTipi, tbStok.nStokID, tbStok.sKodu, tbStok.sAciklama, tbStok.sRenk, tbStok.sBeden, tbStok.nFiyatlandirma, tbStok.sModel, (SELECT isnull(SUM(tbStokFisiDetayi.lGirisMiktar1 - tbStokFisiDetayi.lCikisMiktar1) , 0) FROM tbStokFisiDetayi WHERE tbStok.nStokID = tbStokFisiDetayi.nStokID) AS Mevcut, ISNULL((SELECT isnull(lfiyat , 0) FROM tbstokfiyati WHERE nStokId = tbStok.NstokId AND sFiyatTipi = '" & sFiyat1 & "'), 0) AS FIYAT1, ISNULL((SELECT isnull(lfiyat , 0) FROM tbstokfiyati WHERE nStokId = tbStok.NstokId AND sFiyatTipi = '" & sFiyat2 & "'), 0) AS FIYAT2, ISNULL((SELECT isnull(lfiyat , 0) FROM tbstokfiyati WHERE nStokId = tbStok.NstokId AND sFiyatTipi = '" & sFiyat3 & "'), 0) AS FIYAT3,(SELECT     nKdvOrani FROM         tbKdv Where sKdvTipi = tbStok.sKdvTipi) as nKdvOrani FROM tbFirinParam LEFT OUTER JOIN tbStok ON tbFirinParam.nStokID10 = tbStok.nStokID WHERE (tbFirinParam.sFisTipi = '" & sFisTipi & "') "
        ds_tbStokSinifi = sorgu(sorgu_query("" & kriter & ""))
    End Sub
    Private Sub dataload_baslik()
        If yeni = True Then
            lFisNo = sorgu_lFisNo(FisTipi)
            nServisID = tbFirinServisMaster_kaydet_yeni(0, Today, FisTipi, GirisCikis, lFisNo, "", "D", sKullanici, Now, "", "", "", "", "")
            yeni = False
            'tbSiparis_Aciklamasi_kaydet_yeni(nSiparisTipi, lSiparisNo, nFirmaID, "", "", "", "", "")
        End If
        ds_baslik.Tables(0).Clear()
        ds_baslik = sorgu_baslik(nServisID)
        VGrid_baslik.DataSource = ds_baslik
        VGrid_baslik.DataMember = "BASLIK"
        VGrid_baslik.Refresh()
    End Sub
    Private Function sorgu_baslik(ByVal nServisID As Int64) As DataSet
        Dim cmd As New OleDb.OleDbCommand
        Dim con As New OleDb.OleDbConnection
        Dim adapter As New OleDb.OleDbDataAdapter
        con.ConnectionString = sConnection
        adapter.SelectCommand = cmd
        If yeni = True Then
            cmd.CommandText = sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SET dateformat dmy SELECT     * FROM         tbFirinServisMaster WHERE     (nServisID = " & nServisID & ") ")
            sorgu_txt_baslik = sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SET dateformat dmy SELECT     * FROM         tbFirinServisMaster WHERE     (nServisID = " & nServisID & ")")
        Else
            cmd.CommandText = sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SET dateformat dmy SELECT     * FROM         tbFirinServisMaster WHERE     (nServisID = " & nServisID & ")")
            sorgu_txt_baslik = cmd.CommandText
        End If
        cmd.Connection = con
        con.Open()
        Dim DS As New DataSet
        Dim N As Integer = adapter.Fill(DS, "BASLIK")
        con.Close()
        cmd = Nothing
        con = Nothing
        Return DS
    End Function
    Private Function sorgu_baslik_fis(ByVal nStokFisiID As String) As DataSet
        Dim cmd As New OleDb.OleDbCommand
        Dim con As New OleDb.OleDbConnection
        Dim adapter As New OleDb.OleDbDataAdapter
        con.ConnectionString = sConnection
        adapter.SelectCommand = cmd
        If Trim(sFisTipi) = "PF" Then
            cmd.CommandText = sorgu_query("SET DATEFORMAT DMY SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT tbStokFisiMaster.*, tbStokFisiAciklamasi.sAciklama1, tbStokFisiAciklamasi.sAciklama2, tbStokFisiAciklamasi.sAciklama3, tbStokFisiAciklamasi.sAciklama4, tbStokFisiAciklamasi.sAciklama5, (SELECT nGCT FROM tbFisTipi WHERE sFisTipi = tbStokFisiMaster.sFisTipi) AS nGCT, tbMusteri.nMusteriID, tbMusteri.lKodu as sKodu, tbMusteri.sAdi + ' ' + tbMusteri.sSoyadi as sAciklama,tbMusteri.sAdi, tbMusteri.sSoyadi, tbMusteri.nIskontoPesin, tbMusteri.nIskontoKredili, tbMusteri.sUnvan, tbMusteri.sVergiDairesi, tbMusteri.sVergiNo, tbMusteri.bYazismaEvAdresinemi, tbMusteri.sEmail, tbMusteri.sIsYeriAdi, tbMusteri.sIsAdresi1, tbMusteri.sIsAdresi2, tbMusteri.sIsSemt, tbMusteri.sIsIl, tbMusteri.sIsPostaKodu, tbMusteri.sIsTelefonu, tbMusteri.sEvAdresi1 as sAdres1, tbMusteri.sEvAdresi2 as sAdres2, tbMusteri.sEvSemt as sSemt, tbMusteri.sEvPostaKodu as sPostaKodu, tbMusteri.sEvIl as sIl, tbMusteri.sEvTelefonu, tbMusteri.sSigortaNo, tbMusteri.bEvlimi, tbMusteri.dteEvlilikTarihi, tbMusteri.dteDogumTarihi, tbMusteri.sDogumYeri, tbMusteri.sEhliyetNo, tbMusteri.sKanGrubu, tbMusteri.sHitap, tbMusteri.sAciklama1 AS sMusteriAciklama1, tbMusteri.sAciklama2 AS sMusteriAciklama2, tbMusteri.sAciklama3 AS sMusteriAciklama3, tbMusteri.sAciklama4 AS sMusteriAciklama4, tbMusteri.sAciklama5 AS sMusteriAciklama5, tbMusteri.sGSM, tbMusteri.sFax, 0 as lBakiye FROM tbStokFisiMaster INNER JOIN tbStokFisiAciklamasi ON tbStokFisiMaster.nStokFisiID = tbStokFisiAciklamasi.nStokFisiID INNER JOIN tbMusteri ON tbStokFisiMaster.lFisNo = tbMusteri.lKodu WHERE (tbStokFisiMaster.nStokFisiID = '" & nStokFisiID & "')")
        Else
            cmd.CommandText = sorgu_query("SET DATEFORMAT DMY SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT tbStokFisiMaster.*, tbFirma.sKodu, tbFirma.sAciklama, tbFirma.nOzelIskontosu, tbFirma.lKrediLimiti, tbFirma.dteMutabakatTarihi, tbFirma.nVadeGun, tbFirma.sHitap, tbFirma.sAdres1, tbFirma.sAdres2, tbFirma.sSemt, tbFirma.sIl, tbFirma.sUlke, tbFirma.sPostaKodu, tbFirma.sVergiDairesi, tbFirma.sVergiNo, tbFirma.sFiyatTipi, tbStokFisiAciklamasi.sAciklama1, tbStokFisiAciklamasi.sAciklama2, tbStokFisiAciklamasi.sAciklama3, tbStokFisiAciklamasi.sAciklama4, tbStokFisiAciklamasi.sAciklama5,(Select nGCT from tbFisTipi Where sFisTipi = tbStokFisiMaster.sFisTipi) as nGCT,(Select ISNULL(SUM(lBorcTutar-lAlacakTutar),0) as lBakiye from tbFirmaHareketi where nFirmaID = tbFirma.nFirmaID) as lBakiye,(SELECT     TOP 1 sIletisimAdresi FROM          tbFirmaIletisimi WHERE      nFirmaId = tbFirma.nFirmaID AND sIletisimAraci = 'E-Mail') AS [E-Mail],(SELECT     TOP 1 sIletisimAdresi FROM          tbFirmaIletisimi WHERE      nFirmaId = tbFirma.nFirmaID AND sIletisimAraci = 'Fax') AS [Fax],(SELECT     TOP 1 sIletisimAdresi FROM          tbFirmaIletisimi WHERE      nFirmaId = tbFirma.nFirmaID AND sIletisimAraci = 'Gsm') AS [Gsm],(SELECT     TOP 1 sIletisimAdresi FROM          tbFirmaIletisimi WHERE      nFirmaId = tbFirma.nFirmaID AND sIletisimAraci = 'Telefon') AS [Telefon],(SELECT     TOP 1 sIletisimAdresi FROM          tbFirmaIletisimi WHERE      nFirmaId = tbFirma.nFirmaID AND sIletisimAraci = 'Web') AS [Web],(SELECT     TOP 1 sIletisimAdresi FROM          tbFirmaIletisimi WHERE      nFirmaId = tbFirma.nFirmaID AND sIletisimAraci = 'Yetkili') AS [Yetkili],tbDoviz.sDovizCinsi1,tbDoviz.lDovizKuru1  FROM tbStokFisiMaster INNER JOIN tbFirma ON tbStokFisiMaster.nFirmaID = tbFirma.nFirmaID INNER JOIN tbStokFisiAciklamasi ON tbStokFisiMaster.nStokFisiID = tbStokFisiAciklamasi.nStokFisiID LEFT OUTER JOIN (SELECT     TOP 1 nStokFisiID, sDovizCinsi1, lDovizKuru1 FROM          tbStokFisiDetayi WHERE (nStokFisiID = '" & nStokFisiID & "') GROUP BY nStokFisiID, sDovizCinsi1, lDovizKuru1 ORDER BY sDovizCinsi1 DESC) tbDoviz ON tbStokFisiMaster.nStokFisiID = tbDoviz.nStokFisiID WHERE (tbStokFisiMaster.nStokFisiID = '" & nStokFisiID & "')")
        End If
        'sorgu_txt_baslik = cmd.CommandText
        cmd.Connection = con
        con.Open()
        Dim DS As New DataSet
        Dim N As Integer = adapter.Fill(DS, "BASLIK")
        con.Close()
        cmd = Nothing
        con = Nothing
        Return DS
    End Function
    Private Function sorgu_hareket_fis(ByVal sFisTipi As String, ByVal nStokFisiID As String) As DataSet
        Dim cmd As New OleDb.OleDbCommand
        Dim con As New OleDb.OleDbConnection
        Dim adapter As New OleDb.OleDbDataAdapter
        con.ConnectionString = sConnection
        adapter.SelectCommand = cmd
        If Trim(sFisTipi) = "PF" Then
            If s_nIslemID <> "" Then
                cmd.CommandText = sorgu_query("SET DATEFORMAT DMY SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT tbStokFisiDetayi.*, tbStok.sKodu AS sStokKodu, tbStok.sAciklama AS sStokAciklama,tbStok.sBirimCinsi1,tbStok.sModel,tbStok.sBeden, tbStok.nFiyatlandirma,tbStok.nStokTipi,(Select sRenkAdi from tbRenk where sRenk = tbStok.sRenk) as sRenkAdi,(SELECT TOP 1 ISNULL(sBarkod , '') AS sBarkod FROM tbStokBarkodu WHERE nStokID = tbStok.nStokID) AS sBarkod, ISNULL((SELECT isnull(lfiyat , 0) FROM tbstokfiyati WHERE nStokId = tbStok.NstokId AND sFiyatTipi = '" & sFiyatM & "'),0) AS lMaliyet,ISNULL((SELECT isnull(lfiyat , 0) FROM tbstokfiyati WHERE nStokId = tbStok.NstokId AND sFiyatTipi = '" & sFiyatA & "'),0) AS lAlis,CAST(0 AS MONEY) AS ISK1, CAST(0 AS MONEY) AS ISK2, CAST(0 AS MONEY) AS ISK3, CAST(0 AS MONEY) AS ISK4, CAST(SUBSTRING(tbStokFisiDetayi.sAciklama, 50, 9) AS MONEY) AS nMasrafSatiri,CAST(0 AS MONEY) AS GERCEKFIYAT, CAST(0 AS MONEY) AS GERCEKTOPLAM, ISNULL(ABS(ROUND((tbStokFisiDetayi.lBrutTutar - tbStokFisiDetayi.lIskontoTutari) * (tbStokFisiDetayi.nKdvOrani / 100), 2)), 0) AS lKdvTutari,lDovizTutar = CASE WHEN sDovizCinsi1 <> '' AND lDovizKuru1 <> 0 THEN lBrutTutar / lDovizKuru1 ELSE lBrutTutar END, lDovizFiyat = CASE WHEN sDovizCinsi1 <> '' AND lDovizKuru1 <> 0 THEN lBrutFiyat / lDovizKuru1 ELSE lBrutFiyat END FROM tbStokFisiDetayi INNER JOIN tbStok ON tbStokFisiDetayi.nStokID = tbStok.nStokID  WHERE     (tbStokFisiDetayi.nStokFisiID = '" & nStokFisiID & "') " & s_nIslemID & " ORDER BY tbStokFisiDetayi.nIslemID")
            Else
                cmd.CommandText = sorgu_query("SET DATEFORMAT DMY SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT tbStokFisiDetayi.*, tbStok.sKodu AS sStokKodu, tbStok.sAciklama AS sStokAciklama,tbStok.sBirimCinsi1,tbStok.sModel,tbStok.sBeden, tbStok.nFiyatlandirma,tbStok.nStokTipi,(Select sRenkAdi from tbRenk where sRenk = tbStok.sRenk) as sRenkAdi,(SELECT TOP 1 ISNULL(sBarkod , '') AS sBarkod FROM tbStokBarkodu WHERE nStokID = tbStok.nStokID) AS sBarkod, ISNULL((SELECT isnull(lfiyat , 0) FROM tbstokfiyati WHERE nStokId = tbStok.NstokId AND sFiyatTipi = '" & sFiyatM & "'),0) AS lMaliyet,ISNULL((SELECT isnull(lfiyat , 0) FROM tbstokfiyati WHERE nStokId = tbStok.NstokId AND sFiyatTipi = '" & sFiyatA & "'),0) AS lAlis,CAST(0 AS MONEY) AS ISK1, CAST(0 AS MONEY) AS ISK2, CAST(0 AS MONEY) AS ISK3, CAST(0 AS MONEY) AS ISK4, CAST(SUBSTRING(tbStokFisiDetayi.sAciklama, 50, 9) AS MONEY) AS nMasrafSatiri,CAST(0 AS MONEY) AS GERCEKFIYAT, CAST(0 AS MONEY) AS GERCEKTOPLAM, ISNULL(ABS(ROUND((tbStokFisiDetayi.lBrutTutar - tbStokFisiDetayi.lIskontoTutari) * (tbStokFisiDetayi.nKdvOrani / 100), 2)), 0) AS lKdvTutari,lDovizTutar = CASE WHEN sDovizCinsi1 <> '' AND lDovizKuru1 <> 0 THEN lBrutTutar / lDovizKuru1 ELSE lBrutTutar END, lDovizFiyat = CASE WHEN sDovizCinsi1 <> '' AND lDovizKuru1 <> 0 THEN lBrutFiyat / lDovizKuru1 ELSE lBrutFiyat END FROM tbStokFisiDetayi INNER JOIN tbStok ON tbStokFisiDetayi.nStokID = tbStok.nStokID  WHERE     (tbStokFisiDetayi.nStokFisiID = '" & nStokFisiID & "') ORDER BY tbStokFisiDetayi.nIslemID")
            End If
        ElseIf Trim(sFisTipi) = "IS" Or Trim(sFisTipi) = "IA" Then
            cmd.CommandText = sorgu_query("SET DATEFORMAT DMY SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT tbStokFisiDetayi.*, tbStok.sKodu AS sStokKodu, tbStok.sAciklama AS sStokAciklama,tbStok.sBirimCinsi1,tbStok.sModel, tbStok.sBeden,tbStok.nFiyatlandirma,tbStok.nStokTipi,(Select sRenkAdi from tbRenk where sRenk = tbStok.sRenk) as sRenkAdi,(SELECT TOP 1 ISNULL(sBarkod , '') AS sBarkod FROM tbStokBarkodu WHERE nStokID = tbStok.nStokID) AS sBarkod, ISNULL((SELECT isnull(lfiyat , 0) FROM tbstokfiyati WHERE nStokId = tbStok.NstokId AND sFiyatTipi = '" & sFiyatM & "'),0) AS lMaliyet,ISNULL((SELECT isnull(lfiyat , 0) FROM tbstokfiyati WHERE nStokId = tbStok.NstokId AND sFiyatTipi = '" & sFiyatA & "'),0) AS lAlis,CAST(SUBSTRING(tbStokFisiDetayi.sAciklama, 6, 5) AS MONEY) AS ISK1, CAST(SUBSTRING(tbStokFisiDetayi.sAciklama, 17, 5) AS MONEY) AS ISK2, CAST(SUBSTRING(tbStokFisiDetayi.sAciklama, 28, 5) AS MONEY) AS ISK3, CAST(SUBSTRING(tbStokFisiDetayi.sAciklama, 39, 5) AS MONEY) AS ISK4, CAST(SUBSTRING(tbStokFisiDetayi.sAciklama, 50, 9) AS MONEY) AS nMasrafSatiri,CAST(0 AS MONEY) AS GERCEKFIYAT, CAST(0 AS MONEY) AS GERCEKTOPLAM, ISNULL(ABS(ROUND((tbStokFisiDetayi.lBrutTutar - tbStokFisiDetayi.lIskontoTutari) * (tbStokFisiDetayi.nKdvOrani / 100), 2)), 0) AS lKdvTutari,CAST(tbStokFisiDetayi.lBrutFiyat * (100 + tbStokFisiDetayi.nKdvOrani) / 100 AS FLOAT) AS lDahilBrutFiyat,CAST(tbStokFisiDetayi.lBrutTutar * (100 + tbStokFisiDetayi.nKdvOrani) / 100 AS FLOAT) AS lDahilBrutTutar,lDovizTutar = CASE WHEN sDovizCinsi1 <> '' AND lDovizKuru1 <> 0 THEN lBrutTutar / lDovizKuru1 ELSE lBrutTutar END, lDovizFiyati = CASE WHEN sDovizCinsi1 <> '' AND lDovizKuru1 <> 0 THEN lBrutFiyat / lDovizKuru1 ELSE lBrutFiyat END, lDahilDovizTutar = CASE WHEN sDovizCinsi1 <> '' AND lDovizKuru1 <> 0 THEN (lBrutTutar / lDovizKuru1) * (100 + tbStokFisiDetayi.nKdvOrani) / 100 ELSE (lBrutTutar)* (100 + tbStokFisiDetayi.nKdvOrani) / 100  END, lDahilDovizFiyati = CASE WHEN sDovizCinsi1 <> '' AND lDovizKuru1 <> 0 THEN (lBrutFiyat / lDovizKuru1)* (100 + tbStokFisiDetayi.nKdvOrani) / 100 ELSE (lBrutFiyat)* (100 + tbStokFisiDetayi.nKdvOrani) / 100 END FROM tbStokFisiDetayi INNER JOIN tbStok ON tbStokFisiDetayi.nStokID = tbStok.nStokID  WHERE     (tbStokFisiDetayi.nIrsaliyeFisiID = '" & nStokFisiID & "') ORDER BY tbStokFisiDetayi.nIslemID")
        Else
            cmd.CommandText = sorgu_query("SET DATEFORMAT DMY SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT tbStokFisiDetayi.*, tbStok.sKodu AS sStokKodu, tbStok.sAciklama AS sStokAciklama,tbStok.sBirimCinsi1,tbStok.sModel, tbStok.sBeden,tbStok.nFiyatlandirma,tbStok.nStokTipi,(Select sRenkAdi from tbRenk where sRenk = tbStok.sRenk) as sRenkAdi,(SELECT TOP 1 ISNULL(sBarkod , '') AS sBarkod FROM tbStokBarkodu WHERE nStokID = tbStok.nStokID) AS sBarkod,ISNULL((SELECT isnull(lfiyat , 0) FROM tbstokfiyati WHERE nStokId = tbStok.NstokId AND sFiyatTipi = '" & sFiyatM & "'),0) AS lMaliyet,ISNULL((SELECT isnull(lfiyat , 0) FROM tbstokfiyati WHERE nStokId = tbStok.NstokId AND sFiyatTipi = '" & sFiyatA & "'),0) AS lAlis, CAST(SUBSTRING(tbStokFisiDetayi.sAciklama, 6, 5) AS MONEY) AS ISK1, CAST(SUBSTRING(tbStokFisiDetayi.sAciklama, 17, 5) AS MONEY) AS ISK2, CAST(SUBSTRING(tbStokFisiDetayi.sAciklama, 28, 5) AS MONEY) AS ISK3, CAST(SUBSTRING(tbStokFisiDetayi.sAciklama, 39, 5) AS MONEY) AS ISK4, CAST(SUBSTRING(tbStokFisiDetayi.sAciklama, 50, 9) AS MONEY) AS nMasrafSatiri,CAST(0 AS MONEY) AS GERCEKFIYAT, CAST(0 AS MONEY) AS GERCEKTOPLAM, ISNULL(ABS(ROUND((tbStokFisiDetayi.lBrutTutar - tbStokFisiDetayi.lIskontoTutari) * (tbStokFisiDetayi.nKdvOrani / 100), 2)), 0) AS lKdvTutari,CAST(tbStokFisiDetayi.lBrutFiyat * (100 + tbStokFisiDetayi.nKdvOrani) / 100 AS FLOAT) AS lDahilBrutFiyat,CAST(tbStokFisiDetayi.lBrutTutar * (100 + tbStokFisiDetayi.nKdvOrani) / 100 AS FLOAT) AS lDahilBrutTutar,lDovizTutar = CASE WHEN sDovizCinsi1 <> '' AND lDovizKuru1 <> 0 THEN lBrutTutar / lDovizKuru1 ELSE lBrutTutar END, lDovizFiyati = CASE WHEN sDovizCinsi1 <> '' AND lDovizKuru1 <> 0 THEN lBrutFiyat / lDovizKuru1 ELSE lBrutFiyat END, lDahilDovizTutar = CASE WHEN sDovizCinsi1 <> '' AND lDovizKuru1 <> 0 THEN (lBrutTutar / lDovizKuru1) * (100 + tbStokFisiDetayi.nKdvOrani) / 100 ELSE (lBrutTutar)* (100 + tbStokFisiDetayi.nKdvOrani) / 100  END, lDahilDovizFiyati = CASE WHEN sDovizCinsi1 <> '' AND lDovizKuru1 <> 0 THEN (lBrutFiyat / lDovizKuru1)* (100 + tbStokFisiDetayi.nKdvOrani) / 100 ELSE (lBrutFiyat)* (100 + tbStokFisiDetayi.nKdvOrani) / 100 END FROM tbStokFisiDetayi INNER JOIN tbStok ON tbStokFisiDetayi.nStokID = tbStok.nStokID  WHERE     (tbStokFisiDetayi.nStokFisiID = '" & nStokFisiID & "') ORDER BY tbStokFisiDetayi.nIslemID")
        End If
        cmd.Connection = con
        con.Open()
        Dim DS As New DataSet
        Dim N As Integer = adapter.Fill(DS, "HAREKET")
        con.Close()
        cmd = Nothing
        con = Nothing
        Return DS
    End Function
    Public Function sorgu_lFisNo(ByVal sFisTipi As String) As Int64
        Dim kriter As String = ""
        'kriter = "WHERE (sKodu = '" & kod & "')  "
        Dim conn As New OleDb.OleDbConnection
        Dim cmd As New OleDb.OleDbCommand
        Dim adapter As New OleDb.OleDbDataAdapter
        'MsgBox(connection_resmi)
        conn.ConnectionString = sConnection
        cmd.Connection = conn
        conn.Open()
        cmd.CommandText = sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT     ISNULL(MAX(lFisNo), 0) + 1 AS lFisNo FROM         tbFirinServisMaster where sFisTipi ='" & sFisTipi & "' ")
        Dim kayitsayisi = cmd.ExecuteScalar
        If kayitsayisi = 0 Then
            kayitsayisi = 1
        End If
        Return kayitsayisi
    End Function
    Public Function sorgu_lStokFisNo(ByVal nFirmaID As String, ByVal sFisTipi As String) As Int64
        Dim conn As New OleDb.OleDbConnection
        Dim cmd As New OleDb.OleDbCommand
        Dim adapter As New OleDb.OleDbDataAdapter
        conn.ConnectionString = sConnection
        cmd.Connection = conn
        If conn.State = ConnectionState.Closed Then
            conn.Open()
        End If
        'cmd.CommandText = sorgu_query("SET DATEFORMAT DMY SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT      ISNULL(MAX(lFisNo), 0) + 1 AS lFisNo FROM         tbStokFisiMaster  Where nFirmaID = '" & nFirmaID & "' ")
        'cmd.CommandText = sorgu_query("SET DATEFORMAT DMY SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT      ISNULL(MAX(lFisNo), 0) + 1 AS lFisNo FROM         tbStokFisiMaster  Where sFisTipi = '" & sFisTipi & "'  ")
        cmd.CommandText = sorgu_query("SET DATEFORMAT DMY SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT      ISNULL(MAX(lFisNo), 0) + 1 AS lFisNo FROM         tbStokFisiMaster  Where sFisTipi = '" & sFisTipi & "'  AND nStokFisiID IN (Select TOP 10 nStokFisiID from tbStokFisiMaster Where sFisTipi ='" & sFisTipi & "' Order by dteFisTarihi DESC)")
        Dim kayitsayisi = cmd.ExecuteScalar
        If kayitsayisi = 0 Then
            kayitsayisi = 1
        End If
        Return kayitsayisi
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
    Private Sub gorunum_kaydet()
        VGrid_baslik.SaveLayoutToRegistry("SOFTWARE\BusinessSmart\VIEW\Firin\" & sFisTipi & "\BASLIK\" & Me.Name.ToString & "")
        VGrid_Toplam.SaveLayoutToRegistry("SOFTWARE\BusinessSmart\VIEW\Firin\" & sFisTipi & "\TOPLAM\" & Me.Name.ToString & "")
        GridView1.SaveLayoutToRegistry("SOFTWARE\BusinessSmart\VIEW\Firin\" & sFisTipi & "\HAREKET\" & Me.Name.ToString & "")
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
        For Each btn As DevExpress.XtraBars.BarItem In BarManager1.Items
            btn.Caption = Sorgu_sDil(btn.Caption, sDil)
        Next
        For Each clmn As DevExpress.XtraGrid.Columns.GridColumn In GridView1.Columns
            clmn.Caption = Sorgu_sDil(clmn.Caption, sDil)
        Next
        Dim itm
        For Each itm In kisayol.Items
            itm.text = Sorgu_sDil(itm.text, sDil)
        Next
        'VGrid_baslik.RestoreLayoutFromRegistry("SOFTWARE\BusinessSmart\VIEW\Firin\" & sFisTipi & "\BASLIK\" & Me.Name.ToString & "")
        'VGrid_Toplam.RestoreLayoutFromRegistry("SOFTWARE\BusinessSmart\VIEW\Firin\" & sFisTipi & "\TOPLAM\" & Me.Name.ToString & "")
        GridView1.RestoreLayoutFromRegistry("SOFTWARE\BusinessSmart\VIEW\Firin\" & sFisTipi & "\HAREKET\" & Me.Name.ToString & "")
    End Sub
    Public Sub Dataload_tbFirinServis(ByVal nServisID As Int64)
        status = True
        Try
            ds_hareket.Tables(0).Clear()
        Catch ex As Exception
        End Try
        Dim conn As New OleDb.OleDbConnection
        Dim cmd As New OleDb.OleDbCommand
        Dim adapter As New OleDb.OleDbDataAdapter
        conn.ConnectionString = sConnection
        adapter.SelectCommand = cmd
        cmd.CommandText = sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT     *,(SELECT ISNULL(SUM(lBorcTutar - lAlacakTutar) , 0) AS lBakiye FROM tbFirmaHareketi WHERE nFirmaID = tbFirinServisDetay.nFirmaID) AS lBakiye FROM         tbFirinServisDetay WHERE     (nServisID = " & nServisID & ")")
        sorgu_txt_hareket = cmd.CommandText
        cmd.Connection = conn
        conn.Open()
        Dim N As Integer = adapter.Fill(ds_hareket, "Table1")
        conn.Close()
        Dataload_tbYekun(nServisID)
        If GridView1.RowCount > 0 Then
            GridView1.ClearSelection()
            GridView1.SelectRow(GridView1.RowCount - 1)
            PanelControl3.Focus()
            GridControl1.Focus()
        End If
        status = False
        satir_kontrol()
    End Sub
    Public Sub Dataload_tbYekun(ByVal nServisID As Int64)
        Dim dataset1 As New DataSet
        Dim conn As New OleDb.OleDbConnection
        Dim cmd As New OleDb.OleDbCommand
        Dim adapter As New OleDb.OleDbDataAdapter
        conn.ConnectionString = sConnection
        adapter.SelectCommand = cmd
        cmd.CommandText = sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT * FROM (SELECT nServisID , SUM(lMiktar1) AS lMiktar1 , SUM(lMiktar2) AS lMiktar2 , SUM(lMiktar3) AS lMiktar3 , SUM(lMiktar4) AS lMiktar4 , SUM(lMiktar5) AS lMiktar5 , SUM(lMiktar6) AS lMiktar6 , SUM(lMiktar7) AS lMiktar7 , SUM(lMiktar8) AS lMiktar8 , SUM(lMiktar9) AS lMiktar9 , SUM(lMiktar10) AS lMiktar10 ,SUM(lIade1) AS lIade1 , SUM(lIade2) AS lIade2 , SUM(lIade3) AS lIade3 , SUM(lIade4) AS lIade4 , SUM(lIade5) AS lIade5 , SUM(lIade6) AS lIade6 , SUM(lIade7) AS lIade7 , SUM(lIade8) AS lIade8 , SUM(lIade9) AS lIade9 , SUM(lIade10) AS lIade10,SUM((lMiktar1 - lIade1) * (lFiyat1 - lFiyat1 * (nIskontoYuzdesi / 100))) AS lTutar1,SUM((lMiktar2 - lIade2) * (lFiyat2 - lFiyat2 * (nIskontoYuzdesi / 100))) AS lTutar2, SUM((lMiktar3 - lIade3) * (lFiyat3 - lFiyat3 * (nIskontoYuzdesi / 100))) AS lTutar3,SUM((lMiktar4 - lIade4) * (lFiyat4 - lFiyat4 * (nIskontoYuzdesi / 100))) AS lTutar4,SUM((lMiktar5 - lIade5) * (lFiyat5 - lFiyat5 * (nIskontoYuzdesi / 100))) AS lTutar5,SUM((lMiktar6 - lIade6) * (lFiyat6 - lFiyat6 * (nIskontoYuzdesi / 100))) AS lTutar6,SUM((lMiktar7 - lIade7) * (lFiyat7 - lFiyat7 * (nIskontoYuzdesi / 100))) AS lTutar7,SUM((lMiktar8 - lIade8) * (lFiyat8 - lFiyat8 * (nIskontoYuzdesi / 100))) AS lTutar8,SUM((lMiktar9 - lIade9) * (lFiyat9 - lFiyat9 * (nIskontoYuzdesi / 100))) AS lTutar9,SUM((lMiktar10 - lIade10) * (lFiyat10 - lFiyat10 * (nIskontoYuzdesi / 100))) AS lTutar10,SUM(lTutar) AS lTutar , SUM(lTahsilat) AS lTahsilat FROM tbFirinServisDetay Where nServisID = " & nServisID & " GROUP BY nServisID) tbFirinServisDetay ")
        sorgu_txt_toplam = cmd.CommandText
        cmd.Connection = conn
        conn.Open()
        Dim ds As New DataSet
        Dim N As Integer = adapter.Fill(ds, "Table1")
        conn.Close()
        ds_toplam = ds
        VGrid_Toplam.DataMember = Nothing
        VGrid_Toplam.DataSource = ds_toplam.Tables(0)
    End Sub
    Public Sub Dataload_tbFirma(ByVal sFirmaKodu As String)
        Try
            ds_tbFirma.Tables(0).Clear()
        Catch ex As Exception
        End Try
        Dim conn As New OleDb.OleDbConnection
        Dim cmd As New OleDb.OleDbCommand
        Dim adapter As New OleDb.OleDbDataAdapter
        conn.ConnectionString = sConnection
        adapter.SelectCommand = cmd
        cmd.CommandText = sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT nFirmaID, sKodu, sAciklama, nOzelIskontosu, lKrediLimiti, nVadeGun, nHesapID, (SELECT ISNULL(SUM(lBorcTutar) , 0) AS lBorcTutar FROM tbFirmaHareketi WHERE nFirmaID = tbFirma.nFirmaID) AS lBorcTutar, (SELECT ISNULL(SUM(lAlacakTutar) , 0) AS lAlacakTutar FROM tbFirmaHareketi WHERE nFirmaID = tbFirma.nFirmaID) AS lAlacakTutar, (SELECT ISNULL(SUM(lBorcTutar - lAlacakTutar) , 0) AS lBakiye FROM tbFirmaHareketi WHERE nFirmaID = tbFirma.nFirmaID) AS lBakiye, (SELECT ISNULL(SUM(lTutar) , 0) AS Expr1 FROM tbCekSenet WHERE (nVerenID = tbFirma.nFirmaID) AND (sCekSenetTipi = 'AC' OR sCekSenetTipi = 'AS') AND (nSonCekSenetIslem <= 6) AND (nSonCekSenetIslem <> 2)) AS lRisk FROM tbFirma WHERE (sKodu = '" & sFirmaKodu & "') ")
        sorgu_txt_firma = cmd.CommandText
        cmd.Connection = conn
        conn.Open()
        Dim N As Integer = adapter.Fill(ds_tbFirma, "Table1")
        conn.Close()
        VGrid_Firma.DataMember = Nothing
        VGrid_Firma.DataSource = ds_tbFirma.Tables(0)
    End Sub
    Private Function sorgu_stok_info(ByVal stokkodu As String) As DataSet
        Dim con As New OleDb.OleDbConnection
        Dim adapter As New OleDb.OleDbDataAdapter
        Dim cmd As New OleDb.OleDbCommand
        con.ConnectionString = sConnection
        adapter.SelectCommand = cmd
        'cmd.CommandText = sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT CAST(ISNULL(SUM(hareket.lGirisMiktar1), 0) AS MONEY) AS  GIREN, CAST(ISNULL(SUM(hareket.lCikisMiktar1), 0) AS MONEY) AS CIKAN, CAST(ISNULL(SUM(hareket.lGirisMiktar1 - hareket.lCikisMiktar1), 0) AS MONEY) AS KALAN, stok.sKodu AS STOKKODU, stok.sAciklama AS STOKADI, stok.sRenk, stok.sBeden, stok.lAsgariMiktar, stok.lAzamiMiktar, stok.sModel, 0 AS BEKLEYEN, (SELECT sRenkAdi FROM tbRenk WHERE sRenk = Stok.sRenk) AS sRenkAdi FROM tbStok stok INNER JOIN tbStokFisiDetayi hareket ON stok.nStokID = hareket.nStokID WHERE (stok.sKodu = '" & stokkodu & "') AND (hareket.sFisTipi <> 'T') GROUP BY stok.nStokID, stok.sKodu, stok.sAciklama, stok.sRenk, stok.sBeden, stok.lAsgariMiktar, stok.lAzamiMiktar, stok.sModel")
        cmd.CommandText = sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT CAST(ISNULL(SUM(hareket.lGirisMiktar1), 0) AS MONEY) AS GIREN, CAST(ISNULL(SUM(hareket.lCikisMiktar1), 0) AS MONEY) AS CIKAN, CAST(ISNULL(SUM(hareket.lGirisMiktar1 - hareket.lCikisMiktar1), 0) AS MONEY) AS KALAN, stok.sKodu AS STOKKODU, stok.sAciklama AS STOKADI, stok.sRenk, stok.sBeden, stok.lAsgariMiktar, stok.lAzamiMiktar, stok.sModel, 0 AS BEKLEYEN, (SELECT sRenkAdi FROM tbRenk WHERE sRenk = Stok.sRenk) AS sRenkAdi, CAST(Verilen.lVerilen AS MONEY) as lVerilen, CAST(Alinan.lAlinan AS MONEY) AS lAlinan FROM tbStok stok INNER JOIN tbStokFisiDetayi hareket ON stok.nStokID = hareket.nStokID LEFT OUTER JOIN (SELECT nStokID , ISNULL(LSiparis - lSevkiyat , 0) AS lAlinan FROM (SELECT tbStok.nStokID , tbStok.sModel , tbStok.sKodu , tbStok.sAciklama , SUM(tbSiparis.lMiktari) AS lSiparis , ISNULL(SUM(tbStokFisiDetayi.lCikisMiktar1) , 0) AS lSevkiyat FROM tbFirma INNER JOIN tbSiparis ON tbFirma.nFirmaID = tbSiparis.nFirmaID INNER JOIN tbStok ON tbSiparis.nStokID = tbStok.nStokID LEFT OUTER JOIN tbStokFisiDetayi WITH (INDEX (tbStokFisiDetayi_index12)) ON tbStokFisiDetayi.nSiparisID = tbSiparis.nSiparisID WHERE (tbSiparis.bKapandimi = 0) AND (tbSiparis.lSiparisNo BETWEEN 1 AND 999999999) AND (tbSiparis.dteSiparisTarihi BETWEEN '01/01/1900' AND '31/12/2078') AND (SUBSTRING(tbSiparis.sSiparisiAlan , 1 , 30) BETWEEN '' AND 'zzzzzzzzzzzzzzzzzzzz') AND (SUBSTRING(tbSiparis.sSiparisiAlan , 31 , 30) BETWEEN '' AND 'zzzzzzzzzzzzzzzzzzzz') AND (tbSiparis.nSiparisTipi = 1) and tbStok.sKodu ='" & stokkodu & "' GROUP BY tbStok.nStokID , tbStok.sAciklama , tbStok.sModel , tbStok.sKodu) tSiparis WHERE (ISNULL(lSiparis , 0) - ISNULL(lSevkiyat , 0) <> 0)) Alinan ON stok.nStokID = Alinan.nStokID LEFT OUTER JOIN (SELECT nStokID , ISNULL(LSiparis - lSevkiyat , 0) AS lVerilen FROM (SELECT tbStok.nStokID , tbStok.sModel , tbStok.sKodu , tbStok.sAciklama , SUM(tbSiparis.lMiktari) AS lSiparis , ISNULL(SUM(tbStokFisiDetayi.lCikisMiktar1) , 0) AS lSevkiyat FROM tbFirma INNER JOIN tbSiparis ON tbFirma.nFirmaID = tbSiparis.nFirmaID INNER JOIN tbStok ON tbSiparis.nStokID = tbStok.nStokID LEFT OUTER JOIN tbStokFisiDetayi WITH (INDEX (tbStokFisiDetayi_index12)) ON tbStokFisiDetayi.nSiparisID = tbSiparis.nSiparisID WHERE (tbSiparis.bKapandimi = 0) AND (tbSiparis.lSiparisNo BETWEEN 1 AND 999999999) AND (tbSiparis.dteSiparisTarihi BETWEEN '01/01/1900' AND '31/12/2078') AND (SUBSTRING(tbSiparis.sSiparisiAlan , 1 , 30) BETWEEN '' AND 'zzzzzzzzzzzzzzzzzzzz') AND (SUBSTRING(tbSiparis.sSiparisiAlan , 31 , 30) BETWEEN '' AND 'zzzzzzzzzzzzzzzzzzzz') AND (tbSiparis.nSiparisTipi = 2) and tbStok.sKodu = '" & stokkodu & "' GROUP BY tbStok.nStokID , tbStok.sAciklama , tbStok.sModel , tbStok.sKodu) tSiparis WHERE (ISNULL(lSiparis , 0) - ISNULL(lSevkiyat , 0) <> 0)) Verilen ON stok.nStokID = Verilen.nStokID WHERE (stok.sKodu = '" & stokkodu & "') AND (hareket.sFisTipi <> 'T') GROUP BY stok.nStokID, stok.sKodu, stok.sAciklama, stok.sRenk, stok.sBeden, stok.lAsgariMiktar, stok.lAzamiMiktar, stok.sModel, Verilen.lVerilen, Alinan.lAlinan")
        cmd.Connection = con
        con.Open()
        Dim DS As New DataSet
        Dim N As Integer = adapter.Fill(DS, "BASLIK")
        con.Close()
        Return DS
    End Function
    Private Function tbFirinMusteriFiyat(ByVal nFirmaID As Integer) As DataSet
        Dim con As New OleDb.OleDbConnection
        Dim adapter As New OleDb.OleDbDataAdapter
        Dim cmd As New OleDb.OleDbCommand
        con.ConnectionString = sConnection
        adapter.SelectCommand = cmd
        cmd.CommandText = sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT     * FROM         tbFirinMusteriFiyat WHERE     (nFirmaID = " & nFirmaID & ")")
        cmd.Connection = con
        con.Open()
        Dim DS As New DataSet
        Dim N As Integer = adapter.Fill(DS, "BASLIK")
        con.Close()
        Return DS
    End Function
    Private Sub satir_kontrol()
        Try
            If status = True Then
                If GridView1.RowCount > 0 Then
                    Dim dr As DataRow
                    dr = GridView1.GetDataRow(GridView1.FocusedRowHandle)
                    ds_satir_stok = sorgu_stok_info(dr("sKodu"))
                    Dim dr1 As DataRow = ds_satir_stok.Tables(0).Rows(0)
                    If dr1("sRenkAdi").ToString <> "" Then
                        Label1.Text = dr1("STOKADI") & " (Renk: " & dr1("sRenkAdi") & ") Giren: " & dr1("GIREN") & " Çýkan: " & dr1("CIKAN") & " Mevcut: " & dr1("KALAN") & " AS: " & dr1("lAlinan") & " VS: " & dr1("lVerilen")
                    Else
                        Label1.Text = dr1("STOKADI") & " Giren: " & dr1("GIREN") & " Çýkan: " & dr1("CIKAN") & " Mevcut: " & dr1("KALAN") & " AS: " & dr1("lAlinan") & " VS: " & dr1("lVerilen")
                    End If
                    'Label2.Text = dr1("STOKADI") & " Renk: " & dr1("sRenkAdi") & " Giren: " & dr1("GIREN") & "Çýkan: " & dr1("CIKAN") & " Kalan: " & dr1("KALAN") & " Bekleyen: " & dr1("BEKLEYEN")
                    Label1.Refresh()
                    dr1 = Nothing
                End If
            End If
        Catch ex As Exception
        End Try
    End Sub
    Private Sub tutar_hesapla()
        If GridView1.RowCount > 0 Then
            Dim dr As DataRow
            dr = GridView1.GetDataRow(GridView1.FocusedRowHandle)
            Dim lTutar1 As Decimal = 0
            Dim lTutar2 As Decimal = 0
            Dim lTutar3 As Decimal = 0
            Dim lTutar4 As Decimal = 0
            Dim lTutar5 As Decimal = 0
            Dim lTutar6 As Decimal = 0
            Dim lTutar7 As Decimal = 0
            Dim lTutar8 As Decimal = 0
            Dim lTutar9 As Decimal = 0
            Dim lTutar10 As Decimal = 0
            Dim lTutar As Decimal = 0
            Dim lBrutTutar As Decimal = 0
            Dim lMiktar As Decimal = 0
            Dim lIade As Decimal = 0
            lTutar1 = ((dr("lMiktar1") - dr("lIade1")) * (dr("lFiyat1")) * ((100 - dr("nIskontoYuzdesi")) / 100))
            lTutar2 = ((dr("lMiktar2") - dr("lIade2")) * (dr("lFiyat2")) * ((100 - dr("nIskontoYuzdesi")) / 100))
            lTutar3 = ((dr("lMiktar3") - dr("lIade3")) * (dr("lFiyat3")) * ((100 - dr("nIskontoYuzdesi")) / 100))
            lTutar4 = ((dr("lMiktar4") - dr("lIade4")) * (dr("lFiyat4")) * ((100 - dr("nIskontoYuzdesi")) / 100))
            lTutar5 = ((dr("lMiktar5") - dr("lIade5")) * (dr("lFiyat5")) * ((100 - dr("nIskontoYuzdesi")) / 100))
            lTutar6 = ((dr("lMiktar6") - dr("lIade6")) * (dr("lFiyat6")) * ((100 - dr("nIskontoYuzdesi")) / 100))
            lTutar7 = ((dr("lMiktar7") - dr("lIade7")) * (dr("lFiyat7")) * ((100 - dr("nIskontoYuzdesi")) / 100))
            lTutar8 = ((dr("lMiktar8") - dr("lIade8")) * (dr("lFiyat8")) * ((100 - dr("nIskontoYuzdesi")) / 100))
            lTutar9 = ((dr("lMiktar9") - dr("lIade9")) * (dr("lFiyat9")) * ((100 - dr("nIskontoYuzdesi")) / 100))
            lTutar10 = ((dr("lMiktar10") - dr("lIade10")) * (dr("lFiyat10")) * ((100 - dr("nIskontoYuzdesi")) / 100))
            dr("lTutar") = lTutar1 + lTutar2 + lTutar3 + lTutar4 + lTutar5 + lTutar6 + lTutar7 + lTutar8 + lTutar9 + lTutar10
            Dim lAlacakTutar As Decimal = 0
            Dim lBorcTutar As Decimal = 0
            lBorcTutar = dr("lTahsilat")
            lAlacakTutar = 0
            If dr("lTahsilat") <> 0 Then
                Dim bPesinmi As Boolean = False
                If Trim(dr("sOdemeSekli")) = "N" Then
                    bPesinmi = True
                End If
                If bPesinmi = False Then
                    If dr("nKasaIslemID").ToString <> "" Then
                        tbNakitKasa_kaydet_sil(dr("nKasaIslemID").ToString, 0)
                        tbFirmaHareket_kaydet_sil(dr("nKasaIslemID"))
                        dr("nKasaIslemID") = ""
                    End If
                End If
                If dr("nKasaIslemID").ToString = "" Then
                    If bPesinmi = True Then
                        Dim nHareketID As Int64
                        nHareketID = sorgu_nCariHareketID()
                        nHareketID = tbFirmaHareketi_kaydet_yeni(nHareketID, dr("nFirmaID"), dr_baslik("dteFisTarihi"), dr_baslik("dteFisTarihi"), "N", "Tahsilat :" & dr_baslik("lFisNo") & " - " & Microsoft.VisualBasic.Left(Trim(dr("sAciklama").ToString), 20), lAlacakTutar, lBorcTutar, dr_baslik("lFisNo"), 0, "KASA", "", sKullanici, Now, "", 0, 0, "", 0, 0, sKullanici, Now, bPesinmi, 0)
                        tbFirmaHareketi_nCariHareketID_degistir(nHareketID)
                    ElseIf bPesinmi = False Then
                        If dr("nKasaIslemID").ToString <> "" Then
                            tbNakitKasa_kaydet_sil(dr("nKasaIslemID").ToString, 0)
                            dr("nKasaIslemID") = ""
                        End If
                        Dim nHareketID As Int64
                        nHareketID = sorgu_nCariHareketID()
                        tbFirmaHareket_kaydet_yeni(nHareketID, dr("nFirmaID"), dr_baslik("dteFisTarihi"), dr_baslik("dteFisTarihi"), dr("sOdemeSekli"), "Tahsilat :" & dr_baslik("lFisNo") & " - " & Microsoft.VisualBasic.Left(Trim(dr("sAciklama").ToString), 20), lAlacakTutar, lBorcTutar, dr_baslik("lFisNo"), 0, "", "", sKullanici, Now, "", 0, 0, "", 0, 0, sKullanici, Now)
                        tbFirmaHareketi_nCariHareketID_degistir(nHareketID)
                        dr("nKasaIslemID") = nHareketID
                    End If
                Else
                    If bPesinmi = True Then
                        tbFirmaHareketi_kaydet_duzelt(dr("nStokFisiID"), dr("nKasaIslemID"), dr("nFirmaID"), dr_baslik("dteFisTarihi"), dr_baslik("dteFisTarihi"), "FS", "Tahsilat :" & dr_baslik("lFisNo") & " - " & Microsoft.VisualBasic.Left(Trim(dr("sAciklama").ToString), 20), lBorcTutar, lAlacakTutar, dr_baslik("lFisNo"), 0, "", "", sKullanici, Today, "", 0, 0, "", 0, 0, sKullanici, Now, bPesinmi, dr("nKasaIslemID").ToString)
                    ElseIf bPesinmi = False Then
                        tbFirmaHareket_kaydet_duzelt(dr("nKasaIslemID"), dr("nFirmaID"), dr_baslik("dteFisTarihi"), dr_baslik("dteFisTarihi"), dr("sOdemeSekli"), "Tahsilat :" & dr_baslik("lFisNo") & " - " & Microsoft.VisualBasic.Left(Trim(dr("sAciklama").ToString), 20), lBorcTutar, lAlacakTutar, dr_baslik("lFisNo"), 0, "", "", sKullanici, Today, "", 0, 0, "", 0, 0, sKullanici, Now)
                    End If
                End If
            Else
                If dr("nKasaIslemID").ToString <> "" Then
                    tbNakitKasa_kaydet_sil(dr("nKasaIslemID").ToString, 0)
                    tbFirmaHareket_kaydet_sil(dr("nKasaIslemID"))
                    dr("nKasaIslemID") = ""
                End If
            End If
            lMiktar = dr("lMiktar1") + dr("lMiktar2") + dr("lMiktar3") + dr("lMiktar4") + dr("lMiktar5") + dr("lMiktar6") + dr("lMiktar7") + dr("lMiktar8") + dr("lMiktar9") + dr("lMiktar10")
            lIade = dr("lIade1") + dr("lIade2") + dr("lIade3") + dr("lIade4") + dr("lIade5") + dr("lIade6") + dr("lIade7") + dr("lIade8") + dr("lIade9") + dr("lIade10")
            If lMiktar + lIade <> 0 Then
                If dr("nStokFisiID") = "" Then
                    Dim nStokFisiID As String = ""
                    nStokFisiID = sorgu_nStokFisiID()
                    If Trim(FisTipi) = "S" Then
                        lFisNo = dr_baslik("lFisNo")
                    Else
                        lFisNo = sorgu_lStokFisNo(dr("nFirmaID"), sFisTipi)
                    End If
                    sHareketTipi = ""
                    nStokFisiID = tbStokFisiMaster_kaydet_yeni(nStokFisiID, sFisTipi, dteFisTarihi, nGirisCikis, dr_baslik("lFisNo"), dr("nFirmaID"), "", dr_baslik("dteFisTarihi"), 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, "", "", "", "", "", sHareketTipi, 0, 0, 0, "", "", 0, sKullanici, Now, "", 0, 0, 0, 0, 0, 0)
                    tbStokFisiAciklamasi_kaydet_yeni(nStokFisiID, "", "", "", "", "")
                    'tbStokFisiMaster_lFisno_degistir(nStokFisiID)
                    dr("nStokFisiID") = nStokFisiID
                    If Trim(sFisTipi) = "FS" Or Trim(sFisTipi) = "FA" Or Trim(sFisTipi) = "DG" Or Trim(sFisTipi) = "DC" Or Trim(sFisTipi) = "HA" Or Trim(sFisTipi) = "HS" Then
                        If sorgu_tbStokFisiTablo_kontrol(nStokFisiID, "tbStokFisiOdemePlani") = 0 Then
                            Dim nHareketID As Int64
                            nHareketID = sorgu_nCariHareketID()
                            nHareketID = tbFirmaHareketi_kaydet_yeni(nHareketID, dr("nFirmaID"), dr_baslik("dteFisTarihi"), dr_baslik("dteFisTarihi"), sFisTipi, "Evrak No: " & dr_baslik("lFisNo"), 0, 0, dr_baslik("lFisNo"), 0, sFisTipi, "", sKullanici, Now, "", 0, 0, "", 0, 0, sKullanici, Now, False, 0)
                            tbStokFisiOdemePlani_kaydet_yeni(nStokFisiID, dr_baslik("dteFisTarihi"), 0, sFisTipi, nHareketID)
                            tbFirmaHareketi_nCariHareketID_degistir(nHareketID)
                        End If
                    Else
                    End If
                    fis_kontrol(1)
                    fis_kontrol(2)
                    fis_kontrol(3)
                    fis_kontrol(4)
                    fis_kontrol(5)
                    fis_kontrol(6)
                    fis_kontrol(7)
                    fis_kontrol(8)
                    fis_kontrol(9)
                    fis_kontrol(10)
                Else
                    fis_kontrol(1)
                    fis_kontrol(2)
                    fis_kontrol(3)
                    fis_kontrol(4)
                    fis_kontrol(5)
                    fis_kontrol(6)
                    fis_kontrol(7)
                    fis_kontrol(8)
                    fis_kontrol(9)
                    fis_kontrol(10)
                End If
                lTutar1 = dr("lFiyat1") * (dr("lMiktar1") - dr("lIade1"))
                lTutar2 = dr("lFiyat2") * (dr("lMiktar2") - dr("lIade2"))
                lTutar3 = dr("lFiyat3") * (dr("lMiktar3") - dr("lIade3"))
                lTutar4 = dr("lFiyat4") * (dr("lMiktar4") - dr("lIade4"))
                lTutar5 = dr("lFiyat5") * (dr("lMiktar5") - dr("lIade5"))
                lTutar6 = dr("lFiyat6") * (dr("lMiktar6") - dr("lIade6"))
                lTutar7 = dr("lFiyat7") * (dr("lMiktar7") - dr("lIade7"))
                lTutar8 = dr("lFiyat8") * (dr("lMiktar8") - dr("lIade8"))
                lTutar8 = dr("lFiyat9") * (dr("lMiktar9") - dr("lIade9"))
                lTutar10 = dr("lFiyat10") * (dr("lMiktar10") - dr("lIade10"))
                lBrutTutar = lTutar1 + lTutar2 + lTutar3 + lTutar4 + lTutar5 + lTutar6 + lTutar7 + lTutar8 + lTutar9 + lTutar10
                lTutar = lBrutTutar * ((100 - dr("nIskontoYuzdesi")) / 100)
                Fis_toplam_hesapla(dr("nStokFisiID"))
                dr_baslik = ds_baslik.Tables(0).Rows(0)
            Else
                If tbStokFisiMaster_kaydet_sil(dr("nStokFisiID"), sFisTipi) = True Then
                    dr("nStokFisiID") = ""
                    dr("nIslemID1") = 0
                    dr("nIslemID2") = 0
                    dr("nIslemID3") = 0
                    dr("nIslemID4") = 0
                    dr("nIslemID5") = 0
                    dr("nIslemID6") = 0
                    dr("nIslemID7") = 0
                    dr("nIslemID8") = 0
                    dr("nIslemID9") = 0
                    dr("nIslemID10") = 0
                End If
            End If
            tbFirinServis_kaydet_duzelt(dr("nHareketID"), nServisID, dr("dteFisTarihi"), dr("sFisTipi"), dr("nGirisCikis"), dr("lFisNo"), dr("sSaticiRumuzu").ToString, dr("sServis").ToString, dr("nSatir"), dr("bStatus"), dr("nFirmaID"), dr("sKodu").ToString, dr("sAciklama").ToString, dr("nIskontoYuzdesi"), dr("sFiyatTipi").ToString, dr("nStokFisiID"), dr("nStokID1"), dr("lMiktar1"), dr("lIade1"), dr("lFiyat1"), dr("nIslemID1"), dr("nStokID2"), dr("lMiktar2"), dr("lIade2"), dr("lFiyat2"), dr("nIslemID2"), dr("nStokID3"), dr("lMiktar3"), dr("lIade3"), dr("lFiyat3"), dr("nIslemID3"), dr("nStokID4"), dr("lMiktar4"), dr("lIade4"), dr("lFiyat4"), dr("nIslemID4"), dr("nStokID5"), dr("lMiktar5"), dr("lIade5"), dr("lFiyat5"), dr("nIslemID5"), dr("nStokID6"), dr("lMiktar6"), dr("lIade6"), dr("lFiyat6"), dr("nIslemID6"), dr("nStokID7"), dr("lMiktar7"), dr("lIade7"), dr("lFiyat7"), dr("nIslemID7"), dr("nStokID8"), dr("lMiktar8"), dr("lIade8"), dr("lFiyat8"), dr("nIslemID8"), dr("nStokID9"), dr("lMiktar9"), dr("lIade9"), dr("lFiyat9"), dr("nIslemID9"), dr("nStokID10"), dr("lMiktar10"), dr("lIade10"), dr("lFiyat10"), dr("nIslemID10"), dr("lTutar"), dr("lTahsilat"), dr("sOdemeSekli"), dr("nKasaIslemID"), dr("dteKayitTarihi"), dr("sKullanici").ToString, dr("nKdvOrani1"), dr("nKdvOrani2"), dr("nKdvOrani3"), dr("nKdvOrani4"), dr("nKdvOrani5"), dr("nKdvOrani6"), dr("nKdvOrani7"), dr("nKdvOrani8"), dr("nKdvOrani9"), dr("nKdvOrani10"))
            Dataload_tbFirma(dr("sKodu").ToString)
            Dataload_tbYekun(nServisID)
            dr = Nothing
            lTutar1 = Nothing
            lTutar2 = Nothing
            lTutar3 = Nothing
            lTutar4 = Nothing
            lTutar5 = Nothing
            lTutar6 = Nothing
            lTutar7 = Nothing
            lTutar8 = Nothing
            lTutar9 = Nothing
            lTutar10 = Nothing
        End If
    End Sub
    Private Sub tbFirmaHareket_kaydet_yeni(ByVal nHareketID As Int64, ByVal nFirmaID As Int64, ByVal dteIslemTarihi As DateTime, ByVal dteValorTarihi As DateTime, ByVal sCariIslem As String, ByVal sAciklama As String, ByVal lBorcTutar As Decimal, ByVal lAlacakTutar As Decimal, ByVal sEvrakNo As String, ByVal lVadeFarki As Decimal, ByVal sHangiUygulama As String, ByVal sHareketTipi As String, ByVal sKullaniciAdi As String, ByVal dteKayitTarihi As DateTime, ByVal sDovizCinsi1 As String, ByVal lDovizMiktari1 As Decimal, ByVal lDovizKuru1 As Decimal, ByVal sDovizCinsi2 As String, ByVal lDovizMiktari2 As Decimal, ByVal lDovizKuru2 As Decimal, ByVal sSonKullaniciAdi As String, ByVal dteSonUpdateTarihi As DateTime)
        Dim con As New OleDb.OleDbConnection
        Dim cmd As New OleDb.OleDbCommand
        cmd.Connection = con
        con.ConnectionString = sConnection
        If con.State = ConnectionState.Closed = True Then
            con.Open()
        End If
        cmd.CommandText = sorgu_query("SET DATEFORMAT DMY  INSERT INTO tbFirmaHareketi                       (nHareketID,nFirmaID, dteIslemTarihi, dteValorTarihi, sCariIslem, sAciklama, lBorcTutar, lAlacakTutar, sEvrakNo, lVadeFarki, sHangiUygulama, sHareketTipi, sKullaniciAdi, dteKayitTarihi, sDovizCinsi1, lDovizMiktari1, lDovizKuru1, sDovizCinsi2, lDovizMiktari2, lDovizKuru2, sSonKullaniciAdi, dteSonUpdateTarihi) VALUES     (" & nHareketID & " ,'" & nFirmaID & "', '" & dteIslemTarihi & "', '" & dteValorTarihi & "', '" & sCariIslem & "', N'" & sAciklama & "', " & lBorcTutar & ", " & lAlacakTutar & " , '" & sEvrakNo & "', " & lVadeFarki & ", '" & sHangiUygulama & "', '" & sHareketTipi & "', '" & sKullaniciAdi & "', '" & dteKayitTarihi & "', '" & sDovizCinsi1 & "', " & lDovizMiktari1 & ", " & lDovizKuru1 & " , '" & sDovizCinsi2 & "', " & lDovizMiktari2 & ", " & lDovizKuru2 & " , '" & sSonKullaniciAdi & "', '" & dteSonUpdateTarihi & "')")
        cmd.ExecuteNonQuery()
        con.Close()
    End Sub
    Private Sub tbFirmaHareket_kaydet_duzelt(ByVal nHareketID As Int64, ByVal nFirmaID As Int64, ByVal dteIslemTarihi As DateTime, ByVal dteValorTarihi As DateTime, ByVal sCariIslem As String, ByVal sAciklama As String, ByVal lBorcTutar As Decimal, ByVal lAlacakTutar As Decimal, ByVal sEvrakNo As String, ByVal lVadeFarki As Decimal, ByVal sHangiUygulama As String, ByVal sHareketTipi As String, ByVal sKullaniciAdi As String, ByVal dteKayitTarihi As DateTime, ByVal sDovizCinsi1 As String, ByVal lDovizMiktari1 As Decimal, ByVal lDovizKuru1 As Decimal, ByVal sDovizCinsi2 As String, ByVal lDovizMiktari2 As Decimal, ByVal lDovizKuru2 As Decimal, ByVal sSonKullaniciAdi As String, ByVal dteSonUpdateTarihi As DateTime)
        Dim con As New OleDb.OleDbConnection
        Dim cmd As New OleDb.OleDbCommand
        cmd.Connection = con
        con.ConnectionString = sConnection
        If con.State = ConnectionState.Closed = True Then
            con.Open()
        End If
        cmd.CommandText = sorgu_query("SET DATEFORMAT DMY  UPDATE    tbFirmaHareketi SET              nFirmaID = '" & nFirmaID & "', dteIslemTarihi = '" & dteIslemTarihi & "', dteValorTarihi = '" & dteValorTarihi & "', sCariIslem = '" & sCariIslem & "', sAciklama = N'" & sAciklama & "', lBorcTutar = " & lBorcTutar & ", lAlacakTutar = " & lAlacakTutar & ", sEvrakNo = '" & sEvrakNo & "', lVadeFarki = " & lVadeFarki & ", sHangiUygulama = '" & sHangiUygulama & "', sHareketTipi = '" & sHareketTipi & "', sDovizCinsi1 = '" & sDovizCinsi1 & "', lDovizMiktari1 = " & lDovizMiktari1 & ", lDovizKuru1 = " & lDovizKuru1 & ", sDovizCinsi2 = '" & sDovizCinsi2 & "', lDovizMiktari2 = " & lDovizMiktari2 & ", lDovizKuru2 = " & lDovizKuru2 & ", sSonKullaniciAdi = '" & sSonKullaniciAdi & "', dteSonUpdateTarihi = '" & dteSonUpdateTarihi & "'  WHERE     (nHareketID = " & nHareketID & ")")
        cmd.ExecuteNonQuery()
        con.Close()
    End Sub
    Private Sub tbFirmaHareket_kaydet_sil(ByVal nHareketID As String)
        Dim con As New OleDb.OleDbConnection
        Dim cmd As New OleDb.OleDbCommand
        cmd.Connection = con
        con.ConnectionString = sConnection
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
    Public Function sorgu_tbStokFisiTablo_kontrol(ByVal nStokFisiID As String, ByVal Tablo As String) As Int64
        Dim kriter
        kriter = "WHERE (nStokFisiID = '" & nStokFisiID & "') "
        Dim conn As New OleDb.OleDbConnection
        Dim cmd As New OleDb.OleDbCommand
        Dim adapter As New OleDb.OleDbDataAdapter
        conn.ConnectionString = sConnection
        cmd.Connection = conn
        conn.Open()
        cmd.CommandText = sorgu_query("SET DATEFORMAT DMY SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT     ISNULL(COUNT(*), 0) AS KAYIT  FROM         " & Tablo & "  " & kriter & "")
        Dim kayitsayisi = cmd.ExecuteScalar
        Return kayitsayisi
    End Function
    Private Sub fis_kontrol(ByVal sayi As Integer)
        Dim dr As DataRow
        dr = GridView1.GetDataRow(GridView1.FocusedRowHandle)
        Dim lBrutFiyat As Decimal = 0
        Dim lBrutTutar As Decimal = 0
        Dim lFiyat As Decimal = 0
        Dim lTutar As Decimal = 0
        Dim Miktar As Decimal = 0
        Dim lGirisMiktar1 As Decimal = 0
        Dim lCikisMiktar1 As Decimal = 0
        Dim lGirisFiyat As Decimal = 0
        Dim lGirisTutar As Decimal = 0
        Dim lCikisFiyat As Decimal = 0
        Dim lCikisTutar As Decimal = 0
        Dim nKdvOrani As Decimal = 0
        Dim sAciklama As String = ""
        Dim nIslemID As Int64
        If dr("lMiktar" & sayi & "") Or dr("lIade" & sayi & "") <> 0 Then
            If dr("nIslemID" & sayi & "") = 0 Then
                nIslemID = sorgu_nStokIslemID()
                Miktar = dr("lMiktar" & sayi & "") - dr("lIade" & sayi & "")
                lBrutFiyat = dr("lFiyat" & sayi & "")
                lBrutTutar = dr("lFiyat" & sayi & "") * Miktar
                lFiyat = dr("lFiyat" & sayi & "") * ((100 - dr("nIskontoYuzdesi")) / 100)
                lTutar = lFiyat * Miktar
                nKdvOrani = dr("nKdvOrani" & sayi & "")
                lBrutFiyat = lBrutFiyat / ((100 + nKdvOrani) / 100)
                lBrutTutar = lBrutTutar / ((100 + nKdvOrani) / 100)
                lFiyat = lFiyat / ((100 + nKdvOrani) / 100)
                lTutar = lTutar / ((100 + nKdvOrani) / 100)
                sAciklama = "Isk1:" & uzunluk_tamamla(FormatNumber(dr("nIskontoYuzdesi"), 2), 5) & " Isk2:" & uzunluk_tamamla(FormatNumber(0, 2), 5) & " Isk3:" & uzunluk_tamamla(FormatNumber(0, 2), 5) & " Isk4:" & uzunluk_tamamla(FormatNumber(0, 2), 5) & " Msrf:" & 0
                If nGirisCikis = 3 Then
                    lGirisMiktar1 = 0
                    lCikisMiktar1 = Miktar
                    lGirisFiyat = 0
                    lGirisTutar = 0
                    lCikisFiyat = lFiyat
                    lCikisTutar = lTutar
                ElseIf nGirisCikis = 1 Then
                    lGirisMiktar1 = Miktar
                    lCikisMiktar1 = 0
                    lGirisFiyat = lFiyat
                    lGirisTutar = lTutar
                    lCikisFiyat = 0
                    lCikisTutar = 0
                End If
                nIslemID = tbStokFisidetay_kaydet_yeni(nIslemID, dr("nStokID" & sayi & ""), dr_baslik("dteFisTarihi"), dr("nFirmaID"), 0, sFisTipi, dr_baslik("dteFisTarihi"), dr_baslik("lFisNo"), nGirisCikis, sDepo, 0, "", "", "", "", "01/01/1900", 0, lGirisMiktar1, 0, lGirisFiyat, lGirisTutar, lCikisMiktar1, 0, lCikisFiyat, lCikisTutar, dr("sFiyatTipi"), lBrutFiyat, lBrutTutar, 0, 0, 0, dr("nIskontoYuzdesi"), lBrutTutar - lTutar, "", 0, "", 0, "", "", nKdvOrani, 0, sAciklama, sHareketTipi, 0, sKullanici, Now, "", 0, 0, "", 0, 0, 0, "", "", dr("nStokFisiID"), "", "", "", 0, 0, 0, 0, sKullanici, Now)
                dr("nIslemID" & sayi & "") = nIslemID
            Else
                Miktar = dr("lMiktar" & sayi & "") - dr("lIade" & sayi & "")
                lBrutFiyat = dr("lFiyat" & sayi & "")
                lBrutTutar = dr("lFiyat" & sayi & "") * Miktar
                lFiyat = dr("lFiyat" & sayi & "") * ((100 - dr("nIskontoYuzdesi")) / 100)
                lTutar = lFiyat * Miktar
                nKdvOrani = dr("nKdvOrani" & sayi & "")
                lBrutFiyat = lBrutFiyat / ((100 + nKdvOrani) / 100)
                lBrutTutar = lBrutTutar / ((100 + nKdvOrani) / 100)
                lFiyat = lFiyat / ((100 + nKdvOrani) / 100)
                lTutar = lTutar / ((100 + nKdvOrani) / 100)
                sAciklama = "Isk1:" & uzunluk_tamamla(FormatNumber(dr("nIskontoYuzdesi"), 2), 5) & " Isk2:" & uzunluk_tamamla(FormatNumber(0, 2), 5) & " Isk3:" & uzunluk_tamamla(FormatNumber(0, 2), 5) & " Isk4:" & uzunluk_tamamla(FormatNumber(0, 2), 5) & " Msrf:" & 0
                If nGirisCikis = 3 Then
                    lGirisMiktar1 = 0
                    lCikisMiktar1 = Miktar
                    lGirisFiyat = 0
                    lGirisTutar = 0
                    lCikisFiyat = lFiyat
                    lCikisTutar = lTutar
                ElseIf nGirisCikis = 1 Then
                    lGirisMiktar1 = Miktar
                    lCikisMiktar1 = 0
                    lGirisFiyat = lFiyat
                    lGirisTutar = lTutar
                    lCikisFiyat = 0
                    lCikisTutar = 0
                End If
                tbStokFisidetay_kaydet_degistir(dr("nIslemID" & sayi & ""), dr("nStokID" & sayi & ""), dr_baslik("dteFisTarihi"), dr("nFirmaID"), 0, sFisTipi, dr_baslik("dteFisTarihi"), dr_baslik("lFisNo"), nGirisCikis, sDepo, 0, "", "", "", "", "01/01/1900", 0, lGirisMiktar1, 0, lGirisFiyat, lGirisTutar, lCikisMiktar1, 0, lCikisFiyat, lCikisTutar, dr("sFiyatTipi"), lBrutFiyat, lBrutTutar, 0, 0, 0, dr("nIskontoYuzdesi"), lBrutTutar - lTutar, "", 0, "", 0, "", "", nKdvOrani, 0, sAciklama, sHareketTipi, 0, sKullanici, Now, "", 0, 0, "", 0, 0, 0, "", "", dr("nStokFisiID"), "", "", "", 0, 0, 0, 0, sKullanici, Now)
            End If
        Else
            If dr("nIslemID" & sayi & "") <> 0 Then
                tbStokFisidetay_kaydet_sil(dr("nStokFisiID"), dr("nIslemID" & sayi & ""))
                dr("nIslemID" & sayi & "") = 0
            End If
        End If
    End Sub
    Private Sub Fis_toplam_hesapla(ByVal nStokFisiID As String)
        Dim dr As DataRow
        Dim lMiktar As Decimal
        Dim lMalbedeli As Decimal
        Dim lMalIskontoTutari As Decimal
        Dim nDipIskontoYuzdesi As Decimal
        Dim lDipIskontoTutari As Decimal
        Dim lPesinat As Decimal
        Dim lNetTutar As Decimal
        Dim dr_baslik As DataRow
        Dim dr_toplam As DataRow
        Dim ds_FisBaslik As DataSet
        Dim ds_FisHareket As DataSet
        ds_FisBaslik = sorgu_baslik_fis(nStokFisiID)
        ds_FisHareket = sorgu_hareket_fis(sFisTipi, nStokFisiID)
        dr_baslik = ds_FisBaslik.Tables(0).Rows(0)
        For Each dr In ds_FisHareket.Tables(0).Rows
            If dr_baslik("nGirisCikis") = 1 Or dr_baslik("nGirisCikis") = 2 Then
                lMiktar += dr("lGirisMiktar1")
            ElseIf dr_baslik("nGirisCikis") = 3 Or dr_baslik("nGirisCikis") = 4 Then
                lMiktar += dr("lCikisMiktar1")
            End If
            lMalbedeli += dr("lBrutTutar")
            lMalIskontoTutari += dr("lBrutTutar") * (dr("nIskontoYuzdesi") / 100)
        Next
        ds_toplam = sorgu_toplam(nStokFisiID)
        dr_toplam = ds_toplam.Tables(0).Rows(0)
        dr_toplam("lToplamMiktar") = lMiktar
        dr_toplam("lMalBedeli") = lMalbedeli
        dr_toplam("lMalIskontoTutari") = lMalIskontoTutari
        If dr_toplam("nDipIskontoYuzdesi1") > 0 Then
            dr_toplam("lDipIskontoTutari1") = (lMalbedeli - lMalIskontoTutari) * (dr_toplam("nDipIskontoYuzdesi1") / 100)
        Else
            dr_toplam("lDipIskontoTutari1") = 0
        End If
        If dr_toplam("nDipIskontoYuzdesi2") > 0 Then
            dr_toplam("lDipIskontoTutari2") = (lMalbedeli - lMalIskontoTutari - dr_toplam("lDipIskontoTutari1")) * (dr_toplam("nDipIskontoYuzdesi2") / 100)
        Else
            dr_toplam("lDipIskontoTutari2") = 0
        End If
        If dr_toplam("lDipIskontoTutari3") > 0 Then
            dr_toplam("nDipIskontoYuzdesi3") = dr_toplam("lDipIskontoTutari3") / (lMalbedeli - lMalIskontoTutari - dr_toplam("lDipIskontoTutari1") - dr_toplam("lDipIskontoTutari2")) * 100
        Else
            dr_toplam("nDipIskontoYuzdesi3") = 0
        End If
        dr_toplam("lDipIskontoTutari") = dr_toplam("lDipIskontoTutari1") + dr_toplam("lDipIskontoTutari2") + dr_toplam("lDipIskontoTutari3")
        Try
            dr_toplam("nDipIskontoYuzdesi") = dr_toplam("lDipIskontoTutari") / (lMalbedeli - lMalIskontoTutari)
        Catch ex As Exception
            dr_toplam("nDipIskontoYuzdesi") = 0
        End Try
        dr_toplam("lEkmaliyet") = dr_toplam("lEkmaliyet1") + dr_toplam("lEkmaliyet2") + dr_toplam("lEkmaliyet3")
        If dr_toplam("lEkmaliyet") > 0 Then
            dr_toplam("nEkmaliyetYuzdesi") = CType(dr_toplam("lEkmaliyet"), Decimal) / CType((lMalbedeli - lMalIskontoTutari - dr_toplam("lDipIskontoTutari")), Decimal)
        Else
            dr_toplam("nEkmaliyetYuzdesi") = 0
        End If
        dr_toplam("lEkmaliyet2") = 0
        dr_toplam("lEkmaliyet3") = 0
        dr_toplam("nKdvOrani1") = 0
        dr_toplam("lKdvMatrahi1") = 0
        dr_toplam("lKdv1") = 0
        dr_toplam("nKdvOrani2") = 0
        dr_toplam("lKdvMatrahi2") = 0
        dr_toplam("lKdv2") = 0
        dr_toplam("nKdvOrani3") = 0
        dr_toplam("lKdvMatrahi3") = 0
        dr_toplam("lKdv3") = 0
        dr_toplam("nKdvOrani4") = 0
        dr_toplam("lKdvMatrahi4") = 0
        dr_toplam("lKdv4") = 0
        dr_toplam("nKdvOrani5") = 0
        dr_toplam("lKdvMatrahi5") = 0
        dr_toplam("lKdv5") = 0
        dr_toplam("nTevkifatKdvOrani") = 0
        dr_toplam("lTevkifatKdvMatrahi") = 0
        dr_toplam("lTevkifatKdv") = 0
        dr_toplam("nOTVOrani1") = 0
        dr_toplam("lOTVMatrahi1") = 0
        dr_toplam("lOTV1") = 0
        dr_toplam("nOTVOrani2") = 0
        dr_toplam("lOTVMatrahi2") = 0
        dr_toplam("lOTV2") = 0
        Dim ds_alislar_kdv As DataSet
        If s_nIslemID <> "" Then
            ds_alislar_kdv = sorgu(sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT TOP 5 nKdvOrani, ISNULL(ROUND(SUM(lBrutTutar - lIskontoTutari), 2), 0) AS lKdvMatrahi, ISNULL(ROUND(SUM(lBrutTutar - lIskontoTutari) * nKdvOrani / 100, 2), 0) AS lKdv, ISNULL(ROUND(SUM(lBrutTutar), 2), 0) AS lNetTutar FROM tbStokFisiDetayi WHERE (nStokFisiID = '" & nStokFisiID & "') " & s_nIslemID & " GROUP BY nKdvOrani ORDER BY nKdvOrani"))
        Else
            ds_alislar_kdv = sorgu(sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT TOP 5 nKdvOrani, ISNULL(ROUND(SUM(lBrutTutar - lIskontoTutari), 2), 0) AS lKdvMatrahi, ISNULL(ROUND(SUM(lBrutTutar - lIskontoTutari) * nKdvOrani / 100, 2), 0) AS lKdv, ISNULL(ROUND(SUM(lBrutTutar), 2), 0) AS lNetTutar FROM tbStokFisiDetayi WHERE (nStokFisiID = '" & nStokFisiID & "') GROUP BY nKdvOrani ORDER BY nKdvOrani"))
        End If
        Dim dr1 As DataRow
        Dim sayi As Decimal = 0
        For Each dr1 In ds_alislar_kdv.Tables(0).Rows
            sayi += 1
            dr_toplam("nKdvOrani" & sayi & "") = dr1("nKdvOrani")
            dr_toplam("lKdvMatrahi" & sayi & "") = dr1("lKdvMatrahi")
            dr_toplam("lKdv" & sayi & "") = dr1("lKdv")
        Next
        dr1 = Nothing
        Dim ds_dovizler As DataSet
        Dim dr2 As DataRow
        ds_dovizler = sorgu(sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT     TOP 1 sDovizCinsi1, lDovizKuru1 FROM         tbStokFisiDetayi WHERE (nStokFisiID = '" & nStokFisiID & "') GROUP BY sDovizCinsi1, lDovizKuru1 ORDER BY sDovizCinsi1 DESC"))
        For Each dr2 In ds_dovizler.Tables(0).Rows
            sDovizCinsi1 = Trim(dr2("sDovizCinsi1"))
            lDovizKuru1 = dr2("lDovizKuru1")
        Next
        dr2 = Nothing
        ds_dovizler = Nothing
        dr_toplam("lKdv") = dr_toplam("lKdv1") + dr_toplam("lKdv2") + dr_toplam("lKdv3") + dr_toplam("lKdv4") + dr_toplam("lKdv5")
        lNetTutar = (lMalbedeli - lMalIskontoTutari - dr_toplam("lDipIskontoTutari1") - dr_toplam("lDipIskontoTutari2") - dr_toplam("lDipIskontoTutari3")) + (dr_toplam("lEkMaliyet1") + dr_toplam("lEkMaliyet2") + dr_toplam("lEkMaliyet3") + dr_toplam("lKdv"))
        dr_toplam("lNetTutar") = lNetTutar
        dr_toplam("sYaziIle") = ygeneltoplam(Math.Abs(lNetTutar))
        tbStokFisiMaster_toplam_kaydet_degistir(nStokFisiID, dr_toplam("lToplamMiktar"), dr_toplam("lMalBedeli"), dr_toplam("lMalIskontoTutari"), dr_toplam("nDipIskontoYuzdesi1"), dr_toplam("lDipIskontoTutari1"), dr_toplam("nDipIskontoYuzdesi2"), dr_toplam("lDipIskontoTutari2"), dr_toplam("lDipIskontoTutari3"), dr_toplam("lEkmaliyet1"), dr_toplam("lEkmaliyet2"), dr_toplam("lEkmaliyet3"), dr_toplam("nKdvOrani1"), dr_toplam("lKdvMatrahi1"), dr_toplam("lKdv1"), dr_toplam("nKdvOrani2"), dr_toplam("lKdvMatrahi2"), dr_toplam("lKdv2"), dr_toplam("nKdvOrani3"), dr_toplam("lKdvMatrahi3"), dr_toplam("lKdv3"), dr_toplam("nKdvOrani4"), dr_toplam("lKdvMatrahi4"), dr_toplam("lKdv4"), dr_toplam("nKdvOrani5"), dr_toplam("lKdvMatrahi5"), dr_toplam("lKdv5"), dr_toplam("lNetTutar"), dr_toplam("nTevkifatKdvOrani"), dr_toplam("lTevkifatKdvMatrahi"), dr_toplam("lTevkifatKdv"), dr_toplam("nOTVOrani1"), dr_toplam("lOTVMatrahi1"), dr_toplam("lOTV1"), dr_toplam("nOTVOrani2"), dr_toplam("lOTVMatrahi2"), dr_toplam("lOTV2"), dr_toplam("sYaziIle"))
        tbStokFisiOdemePlani_kaydet_duzelt(nStokFisiID, dr_baslik("dteValorTarihi"), dr_toplam("lNetTutar"), dr_baslik("sFisTipi"), "0")
        Dim lBorcTutar = 0
        Dim lAlacakTutar = 0
        Dim lDovizMiktar1 As Decimal = 0
        If nGirisCikis = 1 Then
            lBorcTutar = 0
            lAlacakTutar = Math.Abs(lNetTutar)
        ElseIf nGirisCikis = 2 Then
            lBorcTutar = Math.Abs(lNetTutar)
            lAlacakTutar = 0
        ElseIf nGirisCikis = 3 Then
            lBorcTutar = Math.Abs(lNetTutar)
            lAlacakTutar = 0
        ElseIf nGirisCikis = 4 Then
            lBorcTutar = 0
            lAlacakTutar = Math.Abs(lNetTutar)
        End If
        If sDovizCinsi1 <> "" And lDovizKuru1 <> 0 Then
            lDovizMiktar1 = Math.Abs(lNetTutar / lDovizKuru1)
            dr_baslik("sDovizCinsi1") = sDovizCinsi1
            dr_baslik("lDovizKuru1") = lDovizKuru1
            dr_baslik("sAciklama5") = sDovizCinsi1.ToString + " - " + "Toplam:" & FormatNumber(lDovizMiktar1, 2)
            tbStokFisiAciklamasi_kaydet_duzelt(nStokFisiID, dr_baslik("sAciklama1"), dr_baslik("sAciklama2"), dr_baslik("sAciklama3"), dr_baslik("sAciklama4"), dr_baslik("sAciklama5"))
        End If
        If Trim(sFisTipi) = "IA" Or Trim(sFisTipi) = "IS" Then
            'If dr_baslik("bFaturayaDonustumu") = False Then
            '    tbFirmaHareketi_kaydet_duzelt(nStokFisiID, dr_baslik("nFirmaID"), dr_baslik("dteFisTarihi"), dr_baslik("dteValorTarihi"), dr_baslik("sFisTipi"), "", lBorcTutar, lAlacakTutar, dr_baslik("lFisNo"), 0, dr_baslik("sFisTipi"), dr_baslik("sHareketTipi"), kullanici, Today, "", 0, 0, "", 0, 0, kullanici, Now)
            'End If
        Else
            'tbStokFisiOdemePlani_kaydet_duzelt(nStokFisiID, dr_baslik("dteValorTarihi"), dr_toplam("lNetTutar"), dr_baslik("sFisTipi"), "0")
            tbFirmaHareketi_kaydet_duzelt(nStokFisiID, nStokFisiID, dr_baslik("nFirmaID"), dr_baslik("dteFisTarihi"), dr_baslik("dteValorTarihi"), dr_baslik("sFisTipi"), "", lBorcTutar, lAlacakTutar, dr_baslik("lFisNo"), 0, dr_baslik("sFisTipi"), dr_baslik("sHareketTipi"), sKullanici, Today, sDovizCinsi1, 0, lDovizKuru1, "", 0, 0, sKullanici, Now, dr_baslik("bPesinmi"), dr_baslik("nKasaIslemID").ToString)
            tbStokFisiOdemePlani_kaydet_duzelt(nStokFisiID, dr_baslik("dteValorTarihi"), dr_toplam("lNetTutar"), dr_baslik("sFisTipi"), "0")
        End If
        fis_Master_degistir(nStokFisiID, dr_baslik("nFirmaID"), lFisNo, dteFisTarihi, dr_baslik("dteValorTarihi"), dr_baslik("sHareketTipi"), dr_baslik("bListelendimi"), dr_baslik("bPesinmi"), dr_baslik("nKasaIslemID").ToString)
        fis_detay_degistir(nStokFisiID, dr_baslik("nFirmaID"), lFisNo, dteFisTarihi)
        tbFirmaHareketi_kaydet_degistir(nStokFisiID, dr_baslik("sFisTipi"), dteFisTarihi, lFisNo, dr_baslik("nFirmaID"), dr_baslik("sHareketTipi"))
        dr = Nothing
        dr1 = Nothing
        lMiktar = Nothing
        lMalbedeli = Nothing
        lMalIskontoTutari = Nothing
        nDipIskontoYuzdesi = Nothing
        lDipIskontoTutari = Nothing
        lPesinat = Nothing
        lNetTutar = Nothing
        lBorcTutar = Nothing
        lAlacakTutar = Nothing
    End Sub
    Private Sub fis_Master_degistir(ByVal nStokFisiID As String, ByVal nFirmaID As String, ByVal lFisno As String, ByVal dteFisTarihi As DateTime, ByVal dteValortarihi As DateTime, ByVal sHareketTipi As String, ByVal bListelendimi As Byte, ByVal bPesinmi As Byte, ByVal nKasaIslemID As String)
        Dim cmd As New OleDb.OleDbCommand
        Dim con As New OleDb.OleDbConnection
        Dim kriter
        kriter = "WHERE nStokFisiID = '" & nStokFisiID & "'  "
        con.ConnectionString = sConnection
        cmd.Connection = con
        If con.State = ConnectionState.Closed Then
            con.Open()
        End If
        If nKasaIslemID <> "" Then
            cmd.CommandText = sorgu_query("SET DATEFORMAT DMY SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED UPDATE tbStokFisiMaster SET lFisNo= '" & lFisno & "',dteFisTarihi = '" & dteFisTarihi & "',dteValorTarihi= '" & dteValortarihi & "',sHareketTipi = '" & sHareketTipi & "',bListelendimi = " & bListelendimi & ", bPesinmi = " & bPesinmi & ", nKasaIslemID = '" & nKasaIslemID & "'           " & kriter & "")
        Else
            cmd.CommandText = sorgu_query("SET DATEFORMAT DMY SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED UPDATE tbStokFisiMaster SET lFisNo= '" & lFisno & "',dteFisTarihi = '" & dteFisTarihi & "',dteValorTarihi= '" & dteValortarihi & "',sHareketTipi = '" & sHareketTipi & "',bListelendimi = " & bListelendimi & ", bPesinmi = " & bPesinmi & " , nKasaIslemID = NULL          " & kriter & "")
        End If
        cmd.ExecuteNonQuery()
        con.Close()
        cmd = Nothing
        con = Nothing
    End Sub
    Private Sub fis_detay_degistir(ByVal nStokFisiID As String, ByVal nFirmaID As String, ByVal lFisno As String, ByVal dteFisTarihi As DateTime)
        Dim kriter
        kriter = "WHERE nStokFisiID = '" & nStokFisiID & "'  "
        'sorgu(sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT     * FROM         tbFirmaHareketi " & kriter & ""))
        Dim conn As New OleDb.OleDbConnection
        Dim cmd As New OleDb.OleDbCommand
        Dim adapter As New OleDb.OleDbDataAdapter
        conn.ConnectionString = sConnection
        cmd.Connection = conn
        If conn.State = ConnectionState.Closed Then
            conn.Open()
        End If
        If Trim(sFisTipi) = "IA" Or Trim(sFisTipi) = "IS" Then
            kriter = "WHERE nIrsaliyeFisiID = '" & nStokFisiID & "'  "
            cmd.CommandText = sorgu_query("SET DATEFORMAT DMY SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED UPDATE tbStokFisiDetayi SET lIrsaliyeNo= '" & lFisno & "',dteIslemTarihi = '" & dteFisTarihi & "',dteIrsaliyeTarihi= '" & dteFisTarihi & "'          " & kriter & "")
        Else
            kriter = "WHERE nStokFisiID = '" & nStokFisiID & "'  "
            cmd.CommandText = sorgu_query("SET DATEFORMAT DMY SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED UPDATE tbStokFisiDetayi SET lFisNo= '" & lFisno & "',dteIslemTarihi = '" & dteFisTarihi & "',dteFisTarihi= '" & dteFisTarihi & "'          " & kriter & "")
        End If
        cmd.ExecuteNonQuery()
        conn.Close()
    End Sub
    Private Sub tbFirmaHareketi_kaydet_degistir(ByVal nStokFisiID As String, ByVal sFistipi As String, ByVal dteFisTarihi As DateTime, ByVal lFisno As String, ByVal nFirmaID As String, ByVal sHareketTipi As String)
        Dim kriter
        kriter = "WHERE     (nFirmaID = " & nFirmaID & ") AND (nHareketID IN (SELECT     nCariHareketID FROM          tbStokFisiOdemePlani WHERE      (nStokFisiID = '" & nStokFisiID & "')))"
        Dim conn As New OleDb.OleDbConnection
        Dim cmd As New OleDb.OleDbCommand
        Dim adapter As New OleDb.OleDbDataAdapter
        conn.ConnectionString = sConnection
        cmd.Connection = conn
        If conn.State = ConnectionState.Closed Then
            conn.Open()
        End If
        cmd.CommandText = sorgu_query("SET DATEFORMAT DMY SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED UPDATE tbFirmaHareketi SET sEvrakNo= '" & lFisno & "',sAciklama= 'Evrak No: " & lFisno & "',dteIslemTarihi = '" & dteFisTarihi & "',dteValorTarihi= '" & dteFisTarihi & "',sHareketTipi = '" & sHareketTipi & "'          " & kriter & "")
        cmd.ExecuteNonQuery()
        conn.Close()
    End Sub
    Private Function sorgu_toplam(ByVal nStokFisiID As String) As DataSet
        Dim cmd As New OleDb.OleDbCommand
        Dim con As New OleDb.OleDbConnection
        Dim adapter As New OleDb.OleDbDataAdapter
        con.ConnectionString = sConnection
        adapter.SelectCommand = cmd
        cmd.CommandText = sorgu_query("SET DATEFORMAT DMY SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT nStokFisiID, lToplamMiktar, lMalBedeli, lMalIskontoTutari,CAST(0 AS money) AS nMalIskontoYuzdesi, nDipIskontoYuzdesi1, lDipIskontoTutari1, nDipIskontoYuzdesi2, lDipIskontoTutari2, lDipIskontoTutari3, CAST(0 AS money) AS nDipIskontoYuzdesi3, lDipIskontoTutari1+lDipIskontoTutari2+lDipIskontoTutari3 as lDipIskontoTutari,CAST(0 AS money) AS nDipIskontoYuzdesi,lEkmaliyet1, lEkmaliyet2, lEkmaliyet3,lEkmaliyet1+lEkmaliyet2+lEkmaliyet3 as lEkmaliyet,CAST(0 AS money) AS nEkmaliyetYuzdesi, nKdvOrani1, lKdvMatrahi1, lKdv1, nKdvOrani2, lKdvMatrahi2, lKdv2, nKdvOrani3, lKdvMatrahi3, lKdv3, nKdvOrani4, lKdvMatrahi4, lKdv4, nKdvOrani5, lKdvMatrahi5, lKdv5, lNetTutar, nTevkifatKdvOrani, lTevkifatKdvMatrahi, lTevkifatKdv, sYaziIle, nOTVOrani1, lOTVMatrahi1, lOTV1, nOTVOrani2, lOTVMatrahi2, lOTV2, lKdv1 + lKdv2 + lKdv3 + lKdv4 + lKdv5 AS lKdv FROM tbStokFisiMaster WHERE (nStokFisiID =  '" & nStokFisiID & "')")
        sorgu_txt_toplam = cmd.CommandText
        cmd.Connection = con
        con.Open()
        Dim DS As New DataSet
        Dim N As Integer = adapter.Fill(DS, "BASLIK")
        con.Close()
        cmd = Nothing
        con = Nothing
        Return DS
    End Function
    Private Function tbStokFisiMaster_kaydet_yeni(ByVal nStokFisiID As Int64, ByVal sFisTipi As String, ByVal dteFisTarihi As DateTime, ByVal nGirisCikis As Int64, ByVal lFisNo As Int64, ByVal nFirmaID As Int64, ByVal sDepo As String, ByVal dteValorTarihi As DateTime, ByVal bPesinmi As Byte, ByVal bListelendimi As Byte, ByVal bHizmetFaturasimi As Byte, ByVal lToplamMiktar As Decimal, ByVal lMalBedeli As Decimal, ByVal lMalIskontoTutari As Decimal, ByVal nDipIskontoYuzdesi1 As Decimal, ByVal lDipIskontoTutari1 As Decimal, ByVal nDipIskontoYuzdesi2 As Decimal, ByVal lDipIskontoTutari2 As Decimal, ByVal lDipIskontoTutari3 As Decimal, ByVal lEkmaliyet1 As Decimal, ByVal lEkmaliyet2 As Decimal, ByVal lEkmaliyet3 As Decimal, ByVal nKdvOrani1 As Decimal, ByVal lKdvMatrahi1 As Decimal, ByVal lKdv1 As Decimal, ByVal nKdvOrani2 As Decimal, ByVal lKdvMatrahi2 As Decimal, ByVal lKdv2 As Decimal, ByVal nKdvOrani3 As Decimal, ByVal lKdvMatrahi3 As Decimal, ByVal lKdv3 As Decimal, ByVal nKdvOrani4 As Decimal, ByVal lKdvMatrahi4 As Decimal, ByVal lKdv4 As Decimal, ByVal nKdvOrani5 As Decimal, ByVal lKdvMatrahi5 As Decimal, ByVal lKdv5 As Decimal, ByVal lNetTutar As Decimal, ByVal nTevkifatKdvOrani As Decimal, ByVal lTevkifatKdvMatrahi As Decimal, ByVal lTevkifatKdv As Decimal, ByVal sCariIslem As String, ByVal nCariHareketID As String, ByVal nKasaIslemID As String, ByVal sCariKdvIslem As String, ByVal nCariKdvHareketID As String, ByVal sHareketTipi As String, ByVal bMuhasebeyeIslendimi As Byte, ByVal bFisTamamlandimi As Byte, ByVal lTransferFisiID As String, ByVal nTransferFirmaID As String, ByVal sTransferDepo As String, ByVal bFaturayaDonustumu As Byte, ByVal sKullaniciAdi As String, ByVal dteKayitTarihi As DateTime, ByVal sYaziIle As String, ByVal nOTVOrani1 As Decimal, ByVal lOTVMatrahi1 As Decimal, ByVal lOTV1 As Decimal, ByVal nOTVOrani2 As Decimal, ByVal lOTVMatrahi2 As Decimal, ByVal lOTV2 As Decimal) As Int64
        Dim cmd As New OleDb.OleDbCommand
        Dim con As New OleDb.OleDbConnection
        cmd.Connection = con
        con.ConnectionString = sConnection
        If con.State = ConnectionState.Closed = True Then
            con.Open()
        End If
        'cmd.CommandText = sorgu_query("SET DATEFORMAT DMY INSERT INTO tbStokFisiMaster (sFisTipi, dteFisTarihi, nGirisCikis, lFisNo, nFirmaID, sDepo, dteValorTarihi, bPesinmi, bListelendimi, bHizmetFaturasimi, lToplamMiktar, lMalBedeli, lMalIskontoTutari, nDipIskontoYuzdesi1, lDipIskontoTutari1, nDipIskontoYuzdesi2, lDipIskontoTutari2, lDipIskontoTutari3, lEkmaliyet1, lEkmaliyet2, lEkmaliyet3, nKdvOrani1, lKdvMatrahi1, lKdv1, nKdvOrani2, lKdvMatrahi2, lKdv2, nKdvOrani3, lKdvMatrahi3, lKdv3, nKdvOrani4, lKdvMatrahi4, lKdv4, nKdvOrani5, lKdvMatrahi5, lKdv5, lNetTutar, nTevkifatKdvOrani, lTevkifatKdvMatrahi, lTevkifatKdv, sCariIslem, nCariHareketID, nKasaIslemID, sCariKdvIslem, nCariKdvHareketID, sHareketTipi, bMuhasebeyeIslendimi, bFisTamamlandimi, lTransferFisiID, nTransferFirmaID, sTransferDepo, bFaturayaDonustumu, sKullaniciAdi, dteKayitTarihi, sYaziIle, nOTVOrani1, lOTVMatrahi1, lOTV1, nOTVOrani2, lOTVMatrahi2, lOTV2) VALUES     ('" & sFisTipi & "', '" & dteFisTarihi & "', " & nGirisCikis & " , '" & lFisNo & "', " & nFirmaID & ", '" & sDepo & "', '" & dteValorTarihi & "', " & bPesinmi & " , " & bListelendimi & " , " & bHizmetFaturasimi & " , " & lToplamMiktar & " , " & lMalBedeli & ", " & lMalIskontoTutari & " , " & nDipIskontoYuzdesi1 & " , " & lDipIskontoTutari1 & " , " & nDipIskontoYuzdesi2 & " , " & lDipIskontoTutari2 & " , " & lDipIskontoTutari3 & " , " & lEkmaliyet1 & " , " & lEkmaliyet2 & " , " & lEkmaliyet3 & " , " & nKdvOrani1 & " , " & lKdvMatrahi1 & ", " & lKdv1 & " , " & nKdvOrani2 & ", " & lKdvMatrahi2 & " , " & lKdv2 & ", " & nKdvOrani3 & " , " & lKdvMatrahi3 & ", " & lKdv3 & " , " & nKdvOrani4 & ", " & lKdvMatrahi4 & " , " & lKdv4 & " , " & nKdvOrani5 & " , " & lKdvMatrahi5 & " , " & lKdv5 & " , " & lNetTutar & " , " & nTevkifatKdvOrani & " , " & lTevkifatKdvMatrahi & ", " & lTevkifatKdv & " , '" & sCariIslem & "', '" & nCariHareketID & "', '" & nKasaIslemID & "', '" & sCariKdvIslem & "', '" & nCariKdvHareketID & "', '" & sHareketTipi & "', " & bMuhasebeyeIslendimi & ", " & bFisTamamlandimi & ", '" & lTransferFisiID & "', '" & nTransferFirmaID & "', '" & sTransferDepo & "', " & bFaturayaDonustumu & " , '" & sKullaniciAdi & "', '" & dteKayitTarihi & "', '" & sYaziIle & "', " & nOTVOrani1 & ", " & lOTVMatrahi1 & ", " & lOTV1 & ", " & nOTVOrani2 & " , " & lOTVMatrahi2 & ", " & lOTV2 & ")")
        cmd.CommandText = sorgu_query("SET DATEFORMAT DMY INSERT INTO tbStokFisiMaster (sFisTipi, dteFisTarihi, nGirisCikis, lFisNo, nFirmaID, sDepo, dteValorTarihi, bPesinmi, bListelendimi, bHizmetFaturasimi, lToplamMiktar, lMalBedeli, lMalIskontoTutari, nDipIskontoYuzdesi1, lDipIskontoTutari1, nDipIskontoYuzdesi2, lDipIskontoTutari2, lDipIskontoTutari3, lEkmaliyet1, lEkmaliyet2, lEkmaliyet3, nKdvOrani1, lKdvMatrahi1, lKdv1, nKdvOrani2, lKdvMatrahi2, lKdv2, nKdvOrani3, lKdvMatrahi3, lKdv3, nKdvOrani4, lKdvMatrahi4, lKdv4, nKdvOrani5, lKdvMatrahi5, lKdv5, lNetTutar, nTevkifatKdvOrani, lTevkifatKdvMatrahi, lTevkifatKdv, sHareketTipi, bMuhasebeyeIslendimi, bFisTamamlandimi, lTransferFisiID,  sTransferDepo, bFaturayaDonustumu, sKullaniciAdi, dteKayitTarihi, sYaziIle, nOTVOrani1, lOTVMatrahi1, lOTV1, nOTVOrani2, lOTVMatrahi2, lOTV2) VALUES     ('" & sFisTipi & "', '" & dteFisTarihi & "', " & nGirisCikis & " , '" & lFisNo & "', " & nFirmaID & ", '" & sDepo & "', '" & dteValorTarihi & "', " & bPesinmi & " , " & bListelendimi & " , " & bHizmetFaturasimi & " , " & lToplamMiktar & " , " & lMalBedeli & ", " & lMalIskontoTutari & " , " & nDipIskontoYuzdesi1 & " , " & lDipIskontoTutari1 & " , " & nDipIskontoYuzdesi2 & " , " & lDipIskontoTutari2 & " , " & lDipIskontoTutari3 & " , " & lEkmaliyet1 & " , " & lEkmaliyet2 & " , " & lEkmaliyet3 & " , " & nKdvOrani1 & " , " & lKdvMatrahi1 & ", " & lKdv1 & " , " & nKdvOrani2 & ", " & lKdvMatrahi2 & " , " & lKdv2 & ", " & nKdvOrani3 & " , " & lKdvMatrahi3 & ", " & lKdv3 & " , " & nKdvOrani4 & ", " & lKdvMatrahi4 & " , " & lKdv4 & " , " & nKdvOrani5 & " , " & lKdvMatrahi5 & " , " & lKdv5 & " , " & lNetTutar & " , " & nTevkifatKdvOrani & " , " & lTevkifatKdvMatrahi & ", " & lTevkifatKdv & " ,  '" & sHareketTipi & "', " & bMuhasebeyeIslendimi & ", " & bFisTamamlandimi & ", '" & lTransferFisiID & "',  '" & sTransferDepo & "', " & bFaturayaDonustumu & " , '" & sKullaniciAdi & "', '" & dteKayitTarihi & "', '" & sYaziIle & "', " & nOTVOrani1 & ", " & lOTVMatrahi1 & ", " & lOTV1 & ", " & nOTVOrani2 & " , " & lOTVMatrahi2 & ", " & lOTV2 & ")")
        cmd.ExecuteNonQuery()
        cmd.CommandText = "SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT @@identity"
        nStokFisiID = cmd.ExecuteScalar
        Return nStokFisiID
        con.Close()
        cmd = Nothing
        con = Nothing
    End Function
    Private Function tbStokFisiMaster_kaydet_sil(ByVal nStokFisiID As String, ByVal sFisTipi As String) As Boolean
        Dim sonuc As Boolean = False
        Dim cmd As New OleDb.OleDbCommand
        Dim con As New OleDb.OleDbConnection
        cmd.CommandTimeout = Nothing
        cmd.Connection = con
        con.ConnectionString = sConnection
        If con.State = ConnectionState.Closed = True Then
            con.Open()
        End If
        cmd.CommandText = sorgu_query("set implicit_transactions on")
        cmd.ExecuteNonQuery()
        Try
            cmd.CommandText = sorgu_query("SET DATEFORMAT DMY SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED DELETE FROM tbFirmaHareketi WHERE     (nHareketID IN (SELECT     nCariHareketID FROM          tbStokFisiOdemePlani WHERE      (nStokFisiID = '" & nStokFisiID & "')))")
            cmd.ExecuteNonQuery()
            cmd.CommandText = sorgu_query("SET DATEFORMAT DMY SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED DELETE FROM tbStokFisiOdemePlani WHERE     (nStokFisiID = '" & nStokFisiID & "')")
            cmd.ExecuteNonQuery()
            cmd.CommandText = sorgu_query("SET DATEFORMAT DMY SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED DELETE FROM tbStokFisiPesinAdres WHERE     (nStokFisiID = '" & nStokFisiID & "')")
            cmd.ExecuteNonQuery()
            If sFisTipi = "PF" Then
                cmd.CommandText = sorgu_query("SET DATEFORMAT DMY SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED UPDATE    tbAlisverisSiparis SET              nStokIslemID = NULL, dteTeslimEdilen = '01/01/1900',dteOnayTarihi = '01/01/1900', bTeslimEdildi = 0 WHERE     (nStokIslemID IN (SELECT     nIslemID FROM          tbStokFisiDetayi WHERE      nStokFisiID = '" & nStokFisiID & "' ))")
                cmd.ExecuteNonQuery()
                'cmd.CommandText = sorgu_query("SET DATEFORMAT DMY SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED UPDATE tbAlisverisSiparis SET nStokIslemID = NULL , dteTeslimEdilen = '01/01/1900' ,dteOnayTarihi = '01/01/1900', bTeslimEdildi = 0 WHERE nStokIslemID IN ( SELECT nIslemID FROM tbStokFisiDetayi WHERE nStokFisiID = '" & nStokFisiID & "') SELECT DISTINCT nStokFisiID INTO #tempSilTrans FROM tbStokFisiDetayi , ( SELECT DISTINCT dteFistarihi , lFisno FROM tbStokFisiMaster , ( SELECT DISTINCT nIrsaliyeFisiID FROM tbStokFisiDetayi WHERE nStokFisiID = '" & nStokFisiID & "' ) AS Irsaliye WHERE Irsaliye.nIrsaliyeFisiID =tbStokFisiMaster.nStokFisiID ) AS TempIrs WHERE tbStokFisiDetayi.sFisTipi= 'T' AND tbStokFisiDetayi.dteFisTarihi = TempIrs.dteFisTarihi AND tbStokFisiDetayi.lFisno = TempIrs.lFisno AND tbStokFisiDetayi.sHangiUygulama = 'PI' DELETE tbStokFisiAciklamasi WHERE nStokFisiID IN ( SELECT * FROM #tempSilTrans) DELETE tbStokFisiDetayi WHERE nStokFisiID IN ( SELECT * FROM #tempSilTrans) DELETE tbStokFisiMaster WHERE nStokFisiID IN ( SELECT * FROM #tempSilTrans) DROP TABLE #tempSilTrans SELECT DISTINCT nStokFisiID INTO #tempSilTrans1 FROM tbStokFisiDetayi , ( SELECT DISTINCT dteFistarihi , lFisno FROM tbStokFisiMaster WHERE nStokFisiID = '" & nStokFisiID & "' ) AS TempIrs WHERE tbStokFisiDetayi.sFisTipi= 'T' AND tbStokFisiDetayi.dteFisTarihi = TempIrs.dteFisTarihi AND tbStokFisiDetayi.lFisno = TempIrs.lFisno AND tbStokFisiDetayi.sHangiUygulama = 'PI' DELETE tbStokFisiAciklamasi WHERE nStokFisiID IN ( SELECT * FROM #tempSilTrans1) DELETE tbStokFisiDetayi WHERE nStokFisiID IN ( SELECT * FROM #tempSilTrans1) DELETE tbStokFisiMaster WHERE nStokFisiID IN ( SELECT * FROM #tempSilTrans1) DROP TABLE #tempSilTrans1 DELETE tbRafHareketi FROM tbStokFisidetayi WHERE tbRafHareketi.nIslemID = tbStokFisidetayi.nIslemID AND nStokFisiID = '" & nStokFisiID & "' SELECT DISTINCT nIrsaliyeFisiID INTO #temp1 FROM tbStokFisiDetayi WHERE nStokFisiID = '" & nStokFisiID & "' DELETE tbStokFisiDetayi WHERE nStokFisiID = '" & nStokFisiID & "' DELETE tbStokFisiOdemePlani WHERE nStokFisiID IN ( SELECT * FROM #temp1 WHERE nIrsaliyeFisiID IS NOT NULL) DELETE tbStokFisiAciklamasi WHERE nStokFisiID IN ( SELECT * FROM #temp1 WHERE nIrsaliyeFisiID IS NOT NULL) DELETE tbStokFisiMaster WHERE nStokFisiID IN ( SELECT * FROM #temp1 WHERE nIrsaliyeFisiID IS NOT NULL) DROP TABLE #Temp1 ")
                'cmd.ExecuteNonQuery()
            End If
            cmd.CommandText = sorgu_query("SET DATEFORMAT DMY SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED DELETE FROM tbStokFisiAciklamasi WHERE     (nStokFisiID = '" & nStokFisiID & "')")
            cmd.ExecuteNonQuery()
            If Trim(sFisTipi) <> "IA" Or Trim(sFisTipi) <> "IS" Then
                cmd.CommandText = sorgu_query("SET DATEFORMAT DMY SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED DELETE FROM tbStokFisiDetayi WHERE     (nStokFisiID = '" & nStokFisiID & "') AND (nIrsaliyeFisiID IS NULL)")
                cmd.ExecuteNonQuery()
                cmd.CommandText = sorgu_query("SET DATEFORMAT DMY SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED UPDATE    tbStokFisiMaster SET              bFaturayaDonustumu = 0 WHERE     (nStokFisiID IN (SELECT DISTINCT nIrsaliyeFisiID FROM          tbStokFisiDetayi WHERE      nStokFisiID = '" & nStokFisiID & "'))")
                cmd.ExecuteNonQuery()
                cmd.CommandText = sorgu_query("SET DATEFORMAT DMY SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED UPDATE    tbStokFisiDetayi SET              sFisTipi = 'IA', dteFisTarihi = dteIrsaliyeTarihi, lFisNo = lIrsaliyeNo, nStokFisiID = nIrsaliyeFisiID WHERE     (nStokFisiID = '" & nStokFisiID & "')")
                cmd.ExecuteNonQuery()
            ElseIf Trim(sFisTipi) = "IA" Or Trim(sFisTipi) = "IS" Then
                'cmd.CommandText = sorgu_query("SET DATEFORMAT DMY SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED DELETE FROM tbStokFisiDetayi WHERE     (nStokFisiID = '" & nStokFisiID & "')")
                'cmd.ExecuteNonQuery()
            End If
            cmd.CommandText = sorgu_query("SET DATEFORMAT DMY SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED DELETE FROM tbStokFisiDetayi WHERE     (nStokFisiID = '" & nStokFisiID & "')")
            cmd.ExecuteNonQuery()
            cmd.CommandText = sorgu_query("SET DATEFORMAT DMY SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED DELETE FROM tbStokFisiMaster WHERE     (nStokFisiID = '" & nStokFisiID & "')")
            cmd.ExecuteNonQuery()
            cmd.CommandText = sorgu_query("IF @@TRANCOUNT > 0 COMMIT TRAN")
            cmd.ExecuteNonQuery()
            sonuc = True
        Catch ex As Exception
            cmd.CommandText = sorgu_query("IF @@TRANCOUNT > 0 COMMIT TRAN")
            cmd.ExecuteNonQuery()
            XtraMessageBox.Show(Sorgu_sDil("Ýþlem Hatasý Lütfen Tekrar Deneyiniz...", sDil), Sorgu_sDil("Dikkat", sDil), MessageBoxButtons.OK, MessageBoxIcon.Warning)
            sonuc = False
        End Try
        cmd.CommandText = sorgu_query("set implicit_transactions off")
        cmd.ExecuteNonQuery()
        con.Close()
        Return sonuc
    End Function
    Private Sub tbStokFisiMaster_toplam_kaydet_degistir(ByVal nStokFisiID As String, ByVal lToplamMiktar As Decimal, ByVal lMalBedeli As Decimal, ByVal lMalIskontoTutari As Decimal, ByVal nDipIskontoYuzdesi1 As Decimal, ByVal lDipIskontoTutari1 As Decimal, ByVal nDipIskontoYuzdesi2 As Decimal, ByVal lDipIskontoTutari2 As Decimal, ByVal lDipIskontoTutari3 As Decimal, ByVal lEkmaliyet1 As Decimal, ByVal lEkmaliyet2 As Decimal, ByVal lEkmaliyet3 As Decimal, ByVal nKdvOrani1 As Decimal, ByVal lKdvMatrahi1 As Decimal, ByVal lKdv1 As Decimal, ByVal nKdvOrani2 As Decimal, ByVal lKdvMatrahi2 As Decimal, ByVal lKdv2 As Decimal, ByVal nKdvOrani3 As Decimal, ByVal lKdvMatrahi3 As Decimal, ByVal lKdv3 As Decimal, ByVal nKdvOrani4 As Decimal, ByVal lKdvMatrahi4 As Decimal, ByVal lKdv4 As Decimal, ByVal nKdvOrani5 As Decimal, ByVal lKdvMatrahi5 As Decimal, ByVal lKdv5 As Decimal, ByVal lNetTutar As Decimal, ByVal nTevkifatKdvOrani As Decimal, ByVal lTevkifatKdvMatrahi As Decimal, ByVal lTevkifatKdv As Decimal, ByVal nOTVOrani1 As Decimal, ByVal lOTVMatrahi1 As Decimal, ByVal lOTV1 As Decimal, ByVal nOTVOrani2 As Decimal, ByVal lOTVMatrahi2 As Decimal, ByVal lOTV2 As Decimal, ByVal sYaziIle As String)
        Dim cmd As New OleDb.OleDbCommand
        Dim con As New OleDb.OleDbConnection
        cmd.Connection = con
        con.ConnectionString = sConnection
        If con.State = ConnectionState.Closed = True Then
            con.Open()
        End If
        cmd.CommandText = sorgu_query("SET DATEFORMAT DMY SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED UPDATE    tbStokFisiMaster SET              lToplamMiktar = " & lToplamMiktar & ", lMalBedeli = " & lMalBedeli & ", lMalIskontoTutari = " & lMalIskontoTutari & ", nDipIskontoYuzdesi1 = " & nDipIskontoYuzdesi1 & ", lDipIskontoTutari1 = " & lDipIskontoTutari1 & ", nDipIskontoYuzdesi2 = " & nDipIskontoYuzdesi2 & ", lDipIskontoTutari2 = " & lDipIskontoTutari2 & ", lDipIskontoTutari3 = " & lDipIskontoTutari3 & ", lEkmaliyet1 = " & lEkmaliyet1 & ", lEkmaliyet2 = " & lEkmaliyet2 & ", lEkmaliyet3 = " & lEkmaliyet3 & ", nKdvOrani1 = " & nKdvOrani1 & ", lKdvMatrahi1 = " & lKdvMatrahi1 & ", lKdv1 = " & lKdv1 & ", nKdvOrani2 = " & nKdvOrani2 & ", lKdvMatrahi2 = " & lKdvMatrahi2 & ", lKdv2 = " & lKdv2 & ", nKdvOrani3 = " & nKdvOrani3 & ", lKdvMatrahi3 = " & lKdvMatrahi3 & ", lKdv3 = " & lKdv3 & ", nKdvOrani4 = " & nKdvOrani4 & ", lKdvMatrahi4 = " & lKdvMatrahi4 & ", lKdv4 = " & lKdv4 & ", nKdvOrani5 = " & nKdvOrani5 & ", lKdvMatrahi5 = " & lKdvMatrahi5 & ", lKdv5 = " & lKdv5 & ", lNetTutar = " & lNetTutar & ", nTevkifatKdvOrani = " & nTevkifatKdvOrani & ", lTevkifatKdvMatrahi = " & lTevkifatKdvMatrahi & ", lTevkifatKdv = " & lTevkifatKdv & ", nOTVOrani1 = " & nOTVOrani1 & ", lOTVMatrahi1 = " & lOTVMatrahi1 & ", lOTV1 = " & lOTV1 & ", nOTVOrani2 = " & nOTVOrani2 & ",lOTVMatrahi2 = " & lOTVMatrahi2 & ", lOTV2 = " & lOTV2 & ",sYaziIle= '" & sYaziIle & "',bFisTamamlandimi=1  WHERE nStokFisiID = '" & nStokFisiID & "'")
        cmd.ExecuteNonQuery()
        con.Close()
        cmd = Nothing
        con = Nothing
    End Sub
    Private Sub tbStokFisiAciklamasi_kaydet_duzelt(ByVal nStokFisiID As String, ByVal sAciklama1 As String, ByVal sAciklama2 As String, ByVal sAciklama3 As String, ByVal sAciklama4 As String, ByVal sAciklama5 As String)
        Dim cmd As New OleDb.OleDbCommand
        Dim con As New OleDb.OleDbConnection
        cmd.Connection = con
        con.ConnectionString = sConnection
        If con.State = ConnectionState.Closed = True Then
            con.Open()
        End If
        cmd.CommandText = sorgu_query("SET DATEFORMAT DMY UPDATE    tbStokFisiAciklamasi SET              sAciklama1 = '" & sAciklama1 & "', sAciklama2 = '" & sAciklama2 & "', sAciklama3 = '" & sAciklama3 & "', sAciklama4 = '" & sAciklama4 & "', sAciklama5 = '" & sAciklama5 & "'  Where nStokFisiID = '" & nStokFisiID & "'")
        cmd.ExecuteNonQuery()
        con.Close()
        cmd = Nothing
        con = Nothing
    End Sub
    Private Sub tbStokFisiOdemePlani_kaydet_yeni(ByVal nStokFisiID As String, ByVal dteVadeTarihi As DateTime, ByVal lTutari As Decimal, ByVal sCariIslem As String, ByVal nCariHareketID As String)
        Dim cmd As New OleDb.OleDbCommand
        Dim con As New OleDb.OleDbConnection
        cmd.Connection = con
        con.ConnectionString = sConnection
        If con.State = ConnectionState.Closed = True Then
            con.Open()
        End If
        cmd.CommandText = sorgu_query("SET DATEFORMAT DMY  INSERT INTO tbStokFisiOdemePlani                       (nStokFisiID, dteVadeTarihi, lTutari, sCariIslem, nCariHareketID) VALUES     ('" & nStokFisiID & "', '" & dteVadeTarihi & "', " & lTutari & ", '" & sCariIslem & "', '" & nCariHareketID & "')")
        cmd.ExecuteNonQuery()
        con.Close()
        cmd = Nothing
        con = Nothing
    End Sub
    Private Sub tbStokFisiOdemePlani_kaydet_duzelt(ByVal nStokFisiID As String, ByVal dteVadeTarihi As DateTime, ByVal lTutari As Decimal, ByVal sCariIslem As String, ByVal nCariHareketID As String)
        Dim cmd As New OleDb.OleDbCommand
        Dim con As New OleDb.OleDbConnection
        cmd.Connection = con
        con.ConnectionString = sConnection
        If con.State = ConnectionState.Closed = True Then
            con.Open()
        End If
        cmd.CommandText = sorgu_query("SET DATEFORMAT DMY  UPDATE    tbStokFisiOdemePlani SET              dteVadeTarihi = '" & dteVadeTarihi & "', lTutari = '" & lTutari & "', sCariIslem = '" & sCariIslem & "' WHERE     (nStokFisiID = '" & nStokFisiID & "') ")
        cmd.ExecuteNonQuery()
        con.Close()
        cmd = Nothing
        con = Nothing
    End Sub
    Private Sub tbStokFisiAciklamasi_kaydet_yeni(ByVal nStokFisiID As String, ByVal sAciklama1 As String, ByVal sAciklama2 As String, ByVal sAciklama3 As String, ByVal sAciklama4 As String, ByVal sAciklama5 As String)
        Dim cmd As New OleDb.OleDbCommand
        Dim con As New OleDb.OleDbConnection
        cmd.Connection = con
        con.ConnectionString = sConnection
        If con.State = ConnectionState.Closed = True Then
            con.Open()
        End If
        cmd.CommandText = sorgu_query("SET DATEFORMAT DMY INSERT INTO tbStokFisiAciklamasi                       (nStokFisiID, sAciklama1, sAciklama2, sAciklama3, sAciklama4, sAciklama5) VALUES     ('" & nStokFisiID & "', '" & sAciklama1 & "', '" & sAciklama2 & "', '" & sAciklama3 & "', '" & sAciklama4 & "', '" & sAciklama5 & "')")
        cmd.ExecuteNonQuery()
        con.Close()
        cmd = Nothing
        con = Nothing
    End Sub
    Private Sub tbStokFisiMaster_lFisno_degistir(ByVal nstokFisiID As String)
        Dim cmd As New OleDb.OleDbCommand
        Dim con As New OleDb.OleDbConnection
        con.ConnectionString = sConnection
        cmd.Connection = con
        If con.State = ConnectionState.Closed Then
            con.Open()
        End If
        cmd.CommandText = sorgu_query("SET DATEFORMAT DMY SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED UPDATE    tbStokSiraNo SET              nSonID = '" & nstokFisiID & "' where nSiraIndex = 2")
        cmd.ExecuteNonQuery()
        con.Close()
        cmd = Nothing
        con = Nothing
    End Sub
    Private Function tbStokFisidetay_kaydet_yeni(ByVal nIslemID As Int64, ByVal nStokID As Int64, ByVal dteIslemTarihi As DateTime, ByVal nFirmaID As Int64, ByVal nMusteriID As Int64, ByVal sFisTipi As String, ByVal dteFisTarihi As DateTime, ByVal lFisNo As String, ByVal nGirisCikis As Int64, ByVal sDepo As String, ByVal lReyonFisNo As String, ByVal sStokIslem As String, ByVal sKasiyerRumuzu As String, ByVal sSaticiRumuzu As String, ByVal sOdemeKodu As String, ByVal dteIrsaliyeTarihi As DateTime, ByVal lIrsaliyeNo As String, ByVal lGirisMiktar1 As Decimal, ByVal lGirisMiktar2 As Decimal, ByVal lGirisFiyat As Decimal, ByVal lGirisTutar As Decimal, ByVal lCikisMiktar1 As Decimal, ByVal lCikisMiktar2 As Decimal, ByVal lCikisFiyat As Decimal, ByVal lCikisTutar As Decimal, ByVal sFiyatTipi As String, ByVal lBrutFiyat As Decimal, ByVal lBrutTutar As Decimal, ByVal lMaliyetFiyat As Decimal, ByVal lMaliyetTutar As Decimal, ByVal lIlaveMaliyetTutar As Decimal, ByVal nIskontoYuzdesi As Decimal, ByVal lIskontoTutari As Decimal, ByVal sDovizCinsi As String, ByVal lDovizFiyat As Decimal, ByVal nSiparisID As String, ByVal nReceteNo As String, ByVal nTransferID As String, ByVal sTransferDepo As String, ByVal nKdvOrani As Decimal, ByVal nHesapID As Int64, ByVal sAciklama As String, ByVal sHareketTipi As String, ByVal bMuhasebeyeIslendimi As Byte, ByVal sKullaniciAdi As String, ByVal dteKayitTarihi As DateTime, ByVal sDovizCinsi1 As String, ByVal lDovizMiktari1 As Decimal, ByVal lDovizKuru1 As Decimal, ByVal sDovizCinsi2 As String, ByVal lDovizMiktari2 As Decimal, ByVal lDovizKuru2 As Decimal, ByVal nOTVOrani As Decimal, ByVal nTransferFirmaID As String, ByVal nAlisverisID As String, ByVal nStokFisiID As Int64, ByVal nIrsaliyeFisiID As String, ByVal sMasrafYontemi As String, ByVal sHangiUygulama As String, ByVal nEkSaha1 As Int64, ByVal nEkSaha2 As Int64, ByVal bEkSoru1 As Int64, ByVal bEkSoru2 As Int64, ByVal sSonKullaniciAdi As String, ByVal dteSonUpdateTarihi As DateTime) As Int64
        Dim con As New OleDb.OleDbConnection
        Dim cmd As New OleDb.OleDbCommand
        cmd.Connection = con
        con.ConnectionString = sConnection
        If con.State = ConnectionState.Closed = True Then
            con.Open()
        End If
        If nSiparisID <> "" Then
            cmd.CommandText = sorgu_query("SET DATEFORMAT DMY SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED INSERT INTO tbStokFisiDetayi                       (nStokID, dteIslemTarihi, nFirmaID, nMusteriID, sFisTipi, dteFisTarihi, lFisNo, nGirisCikis, sDepo, lReyonFisNo, sStokIslem, sKasiyerRumuzu, sSaticiRumuzu, sOdemeKodu, dteIrsaliyeTarihi, lIrsaliyeNo, lGirisMiktar1, lGirisMiktar2, lGirisFiyat, lGirisTutar, lCikisMiktar1, lCikisMiktar2, lCikisFiyat, lCikisTutar, sFiyatTipi, lBrutFiyat, lBrutTutar, lMaliyetFiyat, lMaliyetTutar, lIlaveMaliyetTutar, nIskontoYuzdesi, lIskontoTutari, sDovizCinsi, lDovizFiyat, nSiparisID, nReceteNo, nTransferID, sTransferDepo, nKdvOrani, nHesapID, sAciklama, sHareketTipi, bMuhasebeyeIslendimi, sKullaniciAdi, dteKayitTarihi, sDovizCinsi1, lDovizMiktari1, lDovizKuru1, sDovizCinsi2, lDovizMiktari2, lDovizKuru2, nOTVOrani, nTransferFirmaID, nAlisverisID, nStokFisiID, nIrsaliyeFisiID, sMasrafYontemi, sHangiUygulama, nEkSaha1, nEkSaha2, bEkSoru1, bEkSoru2, sSonKullaniciAdi, dteSonUpdateTarihi) VALUES     ('" & nStokID & "', '" & dteIslemTarihi & "', '" & nFirmaID & "', '" & nMusteriID & "', '" & sFisTipi & "', '" & dteFisTarihi & "', '" & lFisNo & "', " & nGirisCikis & ", '" & sDepo & "', '" & lReyonFisNo & "', '" & sStokIslem & "', '" & sKasiyerRumuzu & "', '" & sSaticiRumuzu & "', '" & sOdemeKodu & "', '" & dteIrsaliyeTarihi & "', '" & lIrsaliyeNo & "', " & lGirisMiktar1 & ", " & lGirisMiktar2 & ", " & lGirisFiyat & ", " & lGirisTutar & ", " & lCikisMiktar1 & ", " & lCikisMiktar2 & " , " & lCikisFiyat & ", " & lCikisTutar & " , '" & sFiyatTipi & "' , " & lBrutFiyat & ", " & lBrutTutar & " , " & lMaliyetFiyat & ", " & lMaliyetTutar & ", " & lIlaveMaliyetTutar & ", " & nIskontoYuzdesi & ", " & lIskontoTutari & ", '" & sDovizCinsi & "', " & lDovizFiyat & ", " & nSiparisID & ", '" & nReceteNo & "', NULL, NULL, " & nKdvOrani & ", '" & nHesapID & "', N'" & sAciklama & "', '" & sHareketTipi & "'," & bMuhasebeyeIslendimi & ", '" & sKullaniciAdi & "', '" & dteKayitTarihi & "', '" & sDovizCinsi1 & "', " & lDovizMiktari1 & ", " & lDovizKuru1 & ", '" & sDovizCinsi2 & "', " & lDovizMiktari2 & " , " & lDovizKuru2 & ", " & nOTVOrani & ", NULL,  NULL, '" & nStokFisiID & "', NULL, '" & sMasrafYontemi & "', '" & sHangiUygulama & "', " & nEkSaha1 & ", " & nEkSaha2 & ", " & bEkSoru1 & " , " & bEkSoru2 & ", '" & sSonKullaniciAdi & "', '" & dteSonUpdateTarihi & "')")
        Else
            If Trim(sFisTipi) = "IA" Or Trim(sFisTipi) = "IS" Then
                cmd.CommandText = sorgu_query("SET DATEFORMAT DMY SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED INSERT INTO tbStokFisiDetayi                       (nStokID, dteIslemTarihi, nFirmaID, nMusteriID, sFisTipi, dteFisTarihi, lFisNo, nGirisCikis, sDepo, lReyonFisNo, sStokIslem, sKasiyerRumuzu, sSaticiRumuzu, sOdemeKodu, dteIrsaliyeTarihi, lIrsaliyeNo, lGirisMiktar1, lGirisMiktar2, lGirisFiyat, lGirisTutar, lCikisMiktar1, lCikisMiktar2, lCikisFiyat, lCikisTutar, sFiyatTipi, lBrutFiyat, lBrutTutar, lMaliyetFiyat, lMaliyetTutar, lIlaveMaliyetTutar, nIskontoYuzdesi, lIskontoTutari, sDovizCinsi, lDovizFiyat, nSiparisID, nReceteNo, nTransferID, sTransferDepo, nKdvOrani, nHesapID, sAciklama, sHareketTipi, bMuhasebeyeIslendimi, sKullaniciAdi, dteKayitTarihi, sDovizCinsi1, lDovizMiktari1, lDovizKuru1, sDovizCinsi2, lDovizMiktari2, lDovizKuru2, nOTVOrani, nTransferFirmaID, nAlisverisID, nStokFisiID, nIrsaliyeFisiID, sMasrafYontemi, sHangiUygulama, nEkSaha1, nEkSaha2, bEkSoru1, bEkSoru2, sSonKullaniciAdi, dteSonUpdateTarihi) VALUES     ('" & nStokID & "', '" & dteIslemTarihi & "', '" & nFirmaID & "', '" & nMusteriID & "', '" & sFisTipi & "', '" & dteFisTarihi & "', '" & lFisNo & "', " & nGirisCikis & ", '" & sDepo & "', '" & lReyonFisNo & "', '" & sStokIslem & "', '" & sKasiyerRumuzu & "', '" & sSaticiRumuzu & "', '" & sOdemeKodu & "', '" & dteFisTarihi & "', '" & lFisNo & "', " & lGirisMiktar1 & ", " & lGirisMiktar2 & ", " & lGirisFiyat & ", " & lGirisTutar & ", " & lCikisMiktar1 & ", " & lCikisMiktar2 & " , " & lCikisFiyat & ", " & lCikisTutar & " , '" & sFiyatTipi & "' , " & lBrutFiyat & ", " & lBrutTutar & " , " & lMaliyetFiyat & ", " & lMaliyetTutar & ", " & lIlaveMaliyetTutar & ", " & nIskontoYuzdesi & ", " & lIskontoTutari & ", '" & sDovizCinsi & "', " & lDovizFiyat & ", NULL, '" & nReceteNo & "', NULL, NULL, " & nKdvOrani & ", '" & nHesapID & "', N'" & sAciklama & "', '" & sHareketTipi & "'," & bMuhasebeyeIslendimi & ", '" & sKullaniciAdi & "', '" & dteKayitTarihi & "', '" & sDovizCinsi1 & "', " & lDovizMiktari1 & ", " & lDovizKuru1 & ", '" & sDovizCinsi2 & "', " & lDovizMiktari2 & " , " & lDovizKuru2 & ", " & nOTVOrani & ", NULL,  NULL, '" & nStokFisiID & "', '" & nStokFisiID & "', '" & sMasrafYontemi & "', '" & sHangiUygulama & "', " & nEkSaha1 & ", " & nEkSaha2 & ", " & bEkSoru1 & " , " & bEkSoru2 & ", '" & sSonKullaniciAdi & "', '" & dteSonUpdateTarihi & "')")
            Else
                cmd.CommandText = sorgu_query("SET DATEFORMAT DMY SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED INSERT INTO tbStokFisiDetayi                       (nStokID, dteIslemTarihi, nFirmaID, nMusteriID, sFisTipi, dteFisTarihi, lFisNo, nGirisCikis, sDepo, lReyonFisNo, sStokIslem, sKasiyerRumuzu, sSaticiRumuzu, sOdemeKodu, dteIrsaliyeTarihi, lIrsaliyeNo, lGirisMiktar1, lGirisMiktar2, lGirisFiyat, lGirisTutar, lCikisMiktar1, lCikisMiktar2, lCikisFiyat, lCikisTutar, sFiyatTipi, lBrutFiyat, lBrutTutar, lMaliyetFiyat, lMaliyetTutar, lIlaveMaliyetTutar, nIskontoYuzdesi, lIskontoTutari, sDovizCinsi, lDovizFiyat, nSiparisID, nReceteNo, nTransferID, sTransferDepo, nKdvOrani, nHesapID, sAciklama, sHareketTipi, bMuhasebeyeIslendimi, sKullaniciAdi, dteKayitTarihi, sDovizCinsi1, lDovizMiktari1, lDovizKuru1, sDovizCinsi2, lDovizMiktari2, lDovizKuru2, nOTVOrani, nTransferFirmaID, nAlisverisID, nStokFisiID, nIrsaliyeFisiID, sMasrafYontemi, sHangiUygulama, nEkSaha1, nEkSaha2, bEkSoru1, bEkSoru2, sSonKullaniciAdi, dteSonUpdateTarihi) VALUES     ('" & nStokID & "', '" & dteIslemTarihi & "', '" & nFirmaID & "', '" & nMusteriID & "', '" & sFisTipi & "', '" & dteFisTarihi & "', '" & lFisNo & "', " & nGirisCikis & ", '" & sDepo & "', '" & lReyonFisNo & "', '" & sStokIslem & "', '" & sKasiyerRumuzu & "', '" & sSaticiRumuzu & "', '" & sOdemeKodu & "', '" & dteIrsaliyeTarihi & "', '" & lIrsaliyeNo & "', " & lGirisMiktar1 & ", " & lGirisMiktar2 & ", " & lGirisFiyat & ", " & lGirisTutar & ", " & lCikisMiktar1 & ", " & lCikisMiktar2 & " , " & lCikisFiyat & ", " & lCikisTutar & " , '" & sFiyatTipi & "' , " & lBrutFiyat & ", " & lBrutTutar & " , " & lMaliyetFiyat & ", " & lMaliyetTutar & ", " & lIlaveMaliyetTutar & ", " & nIskontoYuzdesi & ", " & lIskontoTutari & ", '" & sDovizCinsi & "', " & lDovizFiyat & ", NULL, '" & nReceteNo & "', NULL, NULL, " & nKdvOrani & ", '" & nHesapID & "', N'" & sAciklama & "', '" & sHareketTipi & "'," & bMuhasebeyeIslendimi & ", '" & sKullaniciAdi & "', '" & dteKayitTarihi & "', '" & sDovizCinsi1 & "', " & lDovizMiktari1 & ", " & lDovizKuru1 & ", '" & sDovizCinsi2 & "', " & lDovizMiktari2 & " , " & lDovizKuru2 & ", " & nOTVOrani & ", NULL,  NULL, '" & nStokFisiID & "', NULL, '" & sMasrafYontemi & "', '" & sHangiUygulama & "', " & nEkSaha1 & ", " & nEkSaha2 & ", " & bEkSoru1 & " , " & bEkSoru2 & ", '" & sSonKullaniciAdi & "', '" & dteSonUpdateTarihi & "')")
            End If
            'cmd.CommandText = sorgu_query("SET DATEFORMAT DMY SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED INSERT INTO tbStokFisiDetayi                       (nIslemID,nStokID, dteIslemTarihi, nFirmaID, nMusteriID, sFisTipi, dteFisTarihi, lFisNo, nGirisCikis, sDepo, lReyonFisNo, sStokIslem, sKasiyerRumuzu, sSaticiRumuzu, sOdemeKodu, dteIrsaliyeTarihi, lIrsaliyeNo, lGirisMiktar1, lGirisMiktar2, lGirisFiyat, lGirisTutar, lCikisMiktar1, lCikisMiktar2, lCikisFiyat, lCikisTutar, sFiyatTipi, lBrutFiyat, lBrutTutar, lMaliyetFiyat, lMaliyetTutar, lIlaveMaliyetTutar, nIskontoYuzdesi, lIskontoTutari, sDovizCinsi, lDovizFiyat, nSiparisID, nReceteNo, nTransferID, sTransferDepo, nKdvOrani, nHesapID, sAciklama, sHareketTipi, bMuhasebeyeIslendimi, sKullaniciAdi, dteKayitTarihi, sDovizCinsi1, lDovizMiktari1, lDovizKuru1, sDovizCinsi2, lDovizMiktari2, lDovizKuru2, nOTVOrani, nTransferFirmaID, nAlisverisID, nStokFisiID, nIrsaliyeFisiID, sMasrafYontemi, sHangiUygulama, nEkSaha1, nEkSaha2, bEkSoru1, bEkSoru2, sSonKullaniciAdi, dteSonUpdateTarihi) VALUES     (" & nIslemID & " ,'" & nStokID & "', '" & dteIslemTarihi & "', '" & nFirmaID & "', '" & nMusteriID & "', '" & sFisTipi & "', '" & dteFisTarihi & "', '" & lFisNo & "', " & nGirisCikis & ", '" & sDepo & "', '" & lReyonFisNo & "', '" & sStokIslem & "', '" & sKasiyerRumuzu & "', '" & sSaticiRumuzu & "', '" & sOdemeKodu & "', '" & dteIrsaliyeTarihi & "', '" & lIrsaliyeNo & "', " & lGirisMiktar1 & ", " & lGirisMiktar2 & ", " & lGirisFiyat & ", " & lGirisTutar & ", " & lCikisMiktar1 & ", " & lCikisMiktar2 & " , " & lCikisFiyat & ", " & lCikisTutar & " , '" & sFiyatTipi & "' , " & lBrutFiyat & ", " & lBrutTutar & " , " & lMaliyetFiyat & ", " & lMaliyetTutar & ", " & lIlaveMaliyetTutar & ", " & nIskontoYuzdesi & ", " & lIskontoTutari & ", '" & sDovizCinsi & "', " & lDovizFiyat & ", NULL, '" & nReceteNo & "', NULL, NULL, " & nKdvOrani & ", '" & nHesapID & "', N'" & sAciklama & "', '" & sHareketTipi & "'," & bMuhasebeyeIslendimi & ", '" & sKullaniciAdi & "', '" & dteKayitTarihi & "', '" & sDovizCinsi1 & "', " & lDovizMiktari1 & ", " & lDovizKuru1 & ", '" & sDovizCinsi2 & "', " & lDovizMiktari2 & " , " & lDovizKuru2 & ", " & nOTVOrani & ", NULL,  NULL, '" & nStokFisiID & "', NULL, '" & sMasrafYontemi & "', '" & sHangiUygulama & "', " & nEkSaha1 & ", " & nEkSaha2 & ", " & bEkSoru1 & " , " & bEkSoru2 & ", '" & sSonKullaniciAdi & "', '" & dteSonUpdateTarihi & "')")
        End If
        cmd.ExecuteNonQuery()
        cmd.CommandText = "SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT @@identity"
        nIslemID = cmd.ExecuteScalar
        Return nIslemID
        con.Close()
        con = Nothing
        cmd = Nothing
    End Function
    Private Sub tbStokFisidetay_kaydet_degistir(ByVal nIslemID As Int64, ByVal nStokID As Int64, ByVal dteIslemTarihi As DateTime, ByVal nFirmaID As Int64, ByVal nMusteriID As Int64, ByVal sFisTipi As String, ByVal dteFisTarihi As DateTime, ByVal lFisNo As String, ByVal nGirisCikis As Int64, ByVal sDepo As String, ByVal lReyonFisNo As String, ByVal sStokIslem As String, ByVal sKasiyerRumuzu As String, ByVal sSaticiRumuzu As String, ByVal sOdemeKodu As String, ByVal dteIrsaliyeTarihi As DateTime, ByVal lIrsaliyeNo As String, ByVal lGirisMiktar1 As Decimal, ByVal lGirisMiktar2 As Decimal, ByVal lGirisFiyat As Decimal, ByVal lGirisTutar As Decimal, ByVal lCikisMiktar1 As Decimal, ByVal lCikisMiktar2 As Decimal, ByVal lCikisFiyat As Decimal, ByVal lCikisTutar As Decimal, ByVal sFiyatTipi As String, ByVal lBrutFiyat As Decimal, ByVal lBrutTutar As Decimal, ByVal lMaliyetFiyat As Decimal, ByVal lMaliyetTutar As Decimal, ByVal lIlaveMaliyetTutar As Decimal, ByVal nIskontoYuzdesi As Decimal, ByVal lIskontoTutari As Decimal, ByVal sDovizCinsi As String, ByVal lDovizFiyat As Decimal, ByVal nSiparisID As String, ByVal nReceteNo As String, ByVal nTransferID As String, ByVal sTransferDepo As String, ByVal nKdvOrani As Decimal, ByVal nHesapID As Int64, ByVal sAciklama As String, ByVal sHareketTipi As String, ByVal bMuhasebeyeIslendimi As Byte, ByVal sKullaniciAdi As String, ByVal dteKayitTarihi As DateTime, ByVal sDovizCinsi1 As String, ByVal lDovizMiktari1 As Decimal, ByVal lDovizKuru1 As Decimal, ByVal sDovizCinsi2 As String, ByVal lDovizMiktari2 As Decimal, ByVal lDovizKuru2 As Decimal, ByVal nOTVOrani As Decimal, ByVal nTransferFirmaID As String, ByVal nAlisverisID As String, ByVal nStokFisiID As Int64, ByVal nIrsaliyeFisiID As String, ByVal sMasrafYontemi As String, ByVal sHangiUygulama As String, ByVal nEkSaha1 As Int64, ByVal nEkSaha2 As Int64, ByVal bEkSoru1 As Int64, ByVal bEkSoru2 As Int64, ByVal sSonKullaniciAdi As String, ByVal dteSonUpdateTarihi As DateTime)
        Dim con As New OleDb.OleDbConnection
        Dim cmd As New OleDb.OleDbCommand
        cmd.Connection = con
        con.ConnectionString = sConnection
        If con.State = ConnectionState.Closed = True Then
            con.Open()
        End If
        If Trim(sFisTipi) = "IA" Or Trim(sFisTipi) = "IS" Then
            cmd.CommandText = sorgu_query("SET DATEFORMAT DMY SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED UPDATE    tbStokFisiDetayi SET               nStokID = '" & nStokID & "', dteIslemTarihi = '" & dteIslemTarihi & "', nFirmaID = " & nFirmaID & ", nMusteriID = " & nMusteriID & ", sFisTipi = '" & sFisTipi & "', dteFisTarihi = '" & dteFisTarihi & "', lFisNo = '" & lFisNo & "', nGirisCikis = " & nGirisCikis & ", sDepo = '" & sDepo & "', lReyonFisNo = " & lReyonFisNo & ", sStokIslem = '" & sStokIslem & "', sKasiyerRumuzu = '" & sKasiyerRumuzu & "', sSaticiRumuzu = '" & sSaticiRumuzu & "', sOdemeKodu = '" & sOdemeKodu & "', dteIrsaliyeTarihi = '" & dteFisTarihi & "', lIrsaliyeNo = '" & lFisNo & "', lGirisMiktar1 = " & lGirisMiktar1 & ", lGirisMiktar2 = " & lGirisMiktar2 & ", lGirisFiyat = " & lGirisFiyat & ", lGirisTutar = " & lGirisTutar & ", lCikisMiktar1 = " & lCikisMiktar1 & ", lCikisMiktar2 = " & lCikisMiktar2 & ", lCikisFiyat = " & lCikisFiyat & ", lCikisTutar = " & lCikisTutar & ", sFiyatTipi = '" & sFiyatTipi & "', lBrutFiyat = " & lBrutFiyat & ", lBrutTutar = " & lBrutTutar & ", lMaliyetFiyat = " & lMaliyetFiyat & ", lMaliyetTutar = " & lMaliyetTutar & ", lIlaveMaliyetTutar = " & lIlaveMaliyetTutar & ", nIskontoYuzdesi = " & nIskontoYuzdesi & ", lIskontoTutari = " & lIskontoTutari & ", sDovizCinsi = '" & sDovizCinsi & "', lDovizFiyat = " & lDovizFiyat & ", nReceteNo = " & nReceteNo & ", nKdvOrani = " & nKdvOrani & ", nHesapID = " & nHesapID & ", sAciklama = N'" & sAciklama & "', sHareketTipi = '" & sHareketTipi & "' , bMuhasebeyeIslendimi = " & bMuhasebeyeIslendimi & ", sKullaniciAdi = '" & sKullaniciAdi & "', dteKayitTarihi = '" & dteKayitTarihi & "', sDovizCinsi1 = '" & sDovizCinsi1 & "', lDovizMiktari1 = " & lDovizMiktari1 & ", lDovizKuru1 = " & lDovizKuru1 & ", sDovizCinsi2 = '" & sDovizCinsi2 & "', lDovizMiktari2 = " & lDovizMiktari2 & ", lDovizKuru2 = " & lDovizKuru2 & ", nOTVOrani = " & nOTVOrani & ", sMasrafYontemi = '" & sMasrafYontemi & "', sHangiUygulama = '" & sHangiUygulama & "', nEkSaha1 = " & nEkSaha1 & ", nEkSaha2 = " & nEkSaha2 & ", bEkSoru1 = " & bEkSoru1 & ", bEkSoru2 = " & bEkSoru2 & ", sSonKullaniciAdi = '" & sSonKullaniciAdi & "', dteSonUpdateTarihi = '" & dteSonUpdateTarihi & "' Where nStokFisiID = '" & nStokFisiID & "' and nIslemID = '" & nIslemID & "'")
        Else
            cmd.CommandText = sorgu_query("SET DATEFORMAT DMY SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED UPDATE    tbStokFisiDetayi SET               nStokID = '" & nStokID & "', dteIslemTarihi = '" & dteIslemTarihi & "', nFirmaID = " & nFirmaID & ", nMusteriID = " & nMusteriID & ", sFisTipi = '" & sFisTipi & "', dteFisTarihi = '" & dteFisTarihi & "', lFisNo = '" & lFisNo & "', nGirisCikis = " & nGirisCikis & ", sDepo = '" & sDepo & "', lReyonFisNo = " & lReyonFisNo & ", sStokIslem = '" & sStokIslem & "', sKasiyerRumuzu = '" & sKasiyerRumuzu & "', sSaticiRumuzu = '" & sSaticiRumuzu & "', sOdemeKodu = '" & sOdemeKodu & "', dteIrsaliyeTarihi = '" & dteIrsaliyeTarihi & "', lIrsaliyeNo = '" & lIrsaliyeNo & "', lGirisMiktar1 = " & lGirisMiktar1 & ", lGirisMiktar2 = " & lGirisMiktar2 & ", lGirisFiyat = " & lGirisFiyat & ", lGirisTutar = " & lGirisTutar & ", lCikisMiktar1 = " & lCikisMiktar1 & ", lCikisMiktar2 = " & lCikisMiktar2 & ", lCikisFiyat = " & lCikisFiyat & ", lCikisTutar = " & lCikisTutar & ", sFiyatTipi = '" & sFiyatTipi & "', lBrutFiyat = " & lBrutFiyat & ", lBrutTutar = " & lBrutTutar & ", lMaliyetFiyat = " & lMaliyetFiyat & ", lMaliyetTutar = " & lMaliyetTutar & ", lIlaveMaliyetTutar = " & lIlaveMaliyetTutar & ", nIskontoYuzdesi = " & nIskontoYuzdesi & ", lIskontoTutari = " & lIskontoTutari & ", sDovizCinsi = '" & sDovizCinsi & "', lDovizFiyat = " & lDovizFiyat & ", nReceteNo = " & nReceteNo & ", nKdvOrani = " & nKdvOrani & ", nHesapID = " & nHesapID & ", sAciklama = N'" & sAciklama & "', sHareketTipi = '" & sHareketTipi & "' , bMuhasebeyeIslendimi = " & bMuhasebeyeIslendimi & ", sKullaniciAdi = '" & sKullaniciAdi & "', dteKayitTarihi = '" & dteKayitTarihi & "', sDovizCinsi1 = '" & sDovizCinsi1 & "', lDovizMiktari1 = " & lDovizMiktari1 & ", lDovizKuru1 = " & lDovizKuru1 & ", sDovizCinsi2 = '" & sDovizCinsi2 & "', lDovizMiktari2 = " & lDovizMiktari2 & ", lDovizKuru2 = " & lDovizKuru2 & ", nOTVOrani = " & nOTVOrani & ", sMasrafYontemi = '" & sMasrafYontemi & "', sHangiUygulama = '" & sHangiUygulama & "', nEkSaha1 = " & nEkSaha1 & ", nEkSaha2 = " & nEkSaha2 & ", bEkSoru1 = " & bEkSoru1 & ", bEkSoru2 = " & bEkSoru2 & ", sSonKullaniciAdi = '" & sSonKullaniciAdi & "', dteSonUpdateTarihi = '" & dteSonUpdateTarihi & "' Where nStokFisiID = '" & nStokFisiID & "' and nIslemID = '" & nIslemID & "'")
        End If
        'cmd.CommandText = sorgu_query("SET DATEFORMAT DMY SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED UPDATE    tbStokFisiDetayi SET               nStokID = '" & nStokID & "', dteIslemTarihi = '" & dteIslemTarihi & "', nFirmaID = " & nFirmaID & ", nMusteriID = " & nMusteriID & ", sFisTipi = '" & sFisTipi & "', dteFisTarihi = '" & dteFisTarihi & "', lFisNo = '" & lFisNo & "', nGirisCikis = " & nGirisCikis & ", sDepo = '" & sDepo & "', lReyonFisNo = " & lReyonFisNo & ", sStokIslem = '" & sStokIslem & "', sKasiyerRumuzu = '" & sKasiyerRumuzu & "', sSaticiRumuzu = '" & sSaticiRumuzu & "', sOdemeKodu = '" & sOdemeKodu & "', dteIrsaliyeTarihi = '" & dteIrsaliyeTarihi & "', lIrsaliyeNo = '" & lIrsaliyeNo & "', lGirisMiktar1 = " & lGirisMiktar1 & ", lGirisMiktar2 = " & lGirisMiktar2 & ", lGirisFiyat = " & lGirisFiyat & ", lGirisTutar = " & lGirisTutar & ", lCikisMiktar1 = " & lCikisMiktar1 & ", lCikisMiktar2 = " & lCikisMiktar2 & ", lCikisFiyat = " & lCikisFiyat & ", lCikisTutar = " & lCikisTutar & ", sFiyatTipi = '" & sFiyatTipi & "', lBrutFiyat = " & lBrutFiyat & ", lBrutTutar = " & lBrutTutar & ", lMaliyetFiyat = " & lMaliyetFiyat & ", lMaliyetTutar = " & lMaliyetTutar & ", lIlaveMaliyetTutar = " & lIlaveMaliyetTutar & ", nIskontoYuzdesi = " & nIskontoYuzdesi & ", lIskontoTutari = " & lIskontoTutari & ", sDovizCinsi = '" & sDovizCinsi & "', lDovizFiyat = " & lDovizFiyat & ", nReceteNo = " & nReceteNo & ", nKdvOrani = " & nKdvOrani & ", nHesapID = " & nHesapID & ", sAciklama = N'" & sAciklama & "', sHareketTipi = '" & sHareketTipi & "' , bMuhasebeyeIslendimi = " & bMuhasebeyeIslendimi & ", sKullaniciAdi = '" & sKullaniciAdi & "', dteKayitTarihi = '" & dteKayitTarihi & "', sDovizCinsi1 = '" & sDovizCinsi1 & "', lDovizMiktari1 = " & lDovizMiktari1 & ", lDovizKuru1 = " & lDovizKuru1 & ", sDovizCinsi2 = '" & sDovizCinsi2 & "', lDovizMiktari2 = " & lDovizMiktari2 & ", lDovizKuru2 = " & lDovizKuru2 & ", nOTVOrani = " & nOTVOrani & ", sMasrafYontemi = '" & sMasrafYontemi & "', sHangiUygulama = '" & sHangiUygulama & "', nEkSaha1 = " & nEkSaha1 & ", nEkSaha2 = " & nEkSaha2 & ", bEkSoru1 = " & bEkSoru1 & ", bEkSoru2 = " & bEkSoru2 & ", sSonKullaniciAdi = '" & sSonKullaniciAdi & "', dteSonUpdateTarihi = '" & dteSonUpdateTarihi & "' Where nStokFisiID = '" & nStokFisiID & "' and nIslemID = '" & nIslemID & "'")
        cmd.ExecuteNonQuery()
        con.Close()
        con = Nothing
        cmd = Nothing
    End Sub
    Private Sub tbStokFisidetay_kaydet_sil(ByVal nStokFisiID As String, ByVal nIslemID As Int64)
        Dim cmd As New OleDb.OleDbCommand
        Dim con As New OleDb.OleDbConnection
        cmd.Connection = con
        con.ConnectionString = sConnection
        If con.State = ConnectionState.Closed = True Then
            con.Open()
        End If
        If Trim(sFisTipi) = "IA" Or Trim(sFisTipi) = "IS" Then
            cmd.CommandText = sorgu_query("SET DATEFORMAT DMY SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED DELETE    tbStokFisiDetayi  Where nIrsaliyeFisiID = '" & nStokFisiID & "' and nIslemID = '" & nIslemID & "'")
            cmd.ExecuteNonQuery()
        Else
            cmd.CommandText = sorgu_query("SET DATEFORMAT DMY SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED DELETE FROM tbStokFisiDetayi WHERE     (nStokFisiID = '" & nStokFisiID & "') AND (nIrsaliyeFisiID IS NULL) and nIslemID = '" & nIslemID & "' ")
            cmd.ExecuteNonQuery()
            'cmd.CommandText = sorgu_query("SET DATEFORMAT DMY SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED UPDATE    tbStokFisiMaster SET              bFaturayaDonustumu = 0 WHERE     (nStokFisiID IN (SELECT DISTINCT nIrsaliyeFisiID FROM          tbStokFisiDetayi WHERE      nStokFisiID = '" & nStokFisiID & "'))")
            'cmd.ExecuteNonQuery()
            cmd.CommandText = sorgu_query("SET DATEFORMAT DMY SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED UPDATE    tbStokFisiDetayi SET              sFisTipi = 'IA', dteFisTarihi = dteIrsaliyeTarihi, lFisNo = lIrsaliyeNo, nStokFisiID = nIrsaliyeFisiID WHERE     (nStokFisiID = '" & nStokFisiID & "') and (nIslemID = '" & nIslemID & "')")
            cmd.ExecuteNonQuery()
            'cmd.CommandText = sorgu_query("SET DATEFORMAT DMY SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED DELETE    tbStokFisiDetayi  Where nStokFisiID = '" & nStokFisiID & "' and nIslemID = '" & nIslemID & "'")
        End If
        'cmd.CommandText = sorgu_query("SET DATEFORMAT DMY SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED DELETE    tbStokFisiDetayi  Where nStokFisiID = '" & nStokFisiID & "' and nIslemID = '" & nIslemID & "'")
        'cmd.ExecuteNonQuery()
        con.Close()
        cmd = Nothing
        con = Nothing
    End Sub
    Public Function sorgu_nStokIslemID() As Int64
        Dim kriter As String = ""
        'kriter = "WHERE (sKodu = '" & kod & "')  "
        Dim conn As New OleDb.OleDbConnection
        Dim cmd As New OleDb.OleDbCommand
        Dim adapter As New OleDb.OleDbDataAdapter
        'MsgBox(connection_resmi)
        conn.ConnectionString = sConnection
        cmd.Connection = conn
        If conn.State = ConnectionState.Closed Then
            conn.Open()
        End If
        cmd.CommandText = sorgu_query("SET DATEFORMAT DMY SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT     ISNULL(MAX(nIslemID), 0) + 1 AS nStokIslemID FROM         tbStokFisiDetayi")
        Dim kayitsayisi = cmd.ExecuteScalar
        Return kayitsayisi
        cmd = Nothing
        adapter = Nothing
    End Function
    Public Function sorgu_nStokFisiID() As Int64
        Dim kriter As String = ""
        Dim conn As New OleDb.OleDbConnection
        Dim cmd As New OleDb.OleDbCommand
        conn.ConnectionString = sConnection
        cmd.Connection = conn
        conn.Open()
        cmd.CommandText = sorgu_query("SET DATEFORMAT DMY SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT     ISNULL(MAX(nStokFisiID), 1) + 1 AS nStokFisiID FROM         tbStokFisiMaster")
        Dim kayitsayisi = cmd.ExecuteScalar
        conn.Close()
        cmd = Nothing
        Return kayitsayisi
    End Function
    Public Function sorgu_nCariHareketID() As Int64
        Dim kriter As String = ""
        Dim conn As New OleDb.OleDbConnection
        Dim cmd As New OleDb.OleDbCommand
        Dim adapter As New OleDb.OleDbDataAdapter
        conn.ConnectionString = sConnection
        cmd.Connection = conn
        conn.Open()
        cmd.CommandText = sorgu_query("SET DATEFORMAT DMY SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT     ISNULL(MAX(nHareketID), 0) + 1 AS nCariHareketID FROM         tbFirmaHareketi")
        Dim kayitsayisi = cmd.ExecuteScalar
        Return kayitsayisi
    End Function
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
    Private Sub degeryay(ByVal columnkriter As String)
        Dim durum
        Dim sayi = GridView1.RowCount
        Dim satir = GridView1.FocusedRowHandle
        Dim TOPLAM = sayi - GridView1.FocusedRowHandle
        Dim Ý As Integer
        Ý = 0
        Dim dr As DataRow
        dr = GridView1.GetDataRow(GridView1.FocusedRowHandle)
        durum = dr("" & columnkriter & "")
        For Ý = 1 To TOPLAM
            dr = GridView1.GetDataRow(GridView1.FocusedRowHandle)
            dr.BeginEdit()
            dr("" & columnkriter & "") = durum
            dr.EndEdit()
            tutar_hesapla()
            GridView1.FocusedRowHandle += 1
        Next
        GridView1.FocusedRowHandle = satir
        GridView1.GetDataRow(satir)
        durum = Nothing
        sayi = Nothing
        satir = Nothing
        Ý = Nothing
    End Sub
    Private Sub fis_sil()
        If XtraMessageBox.Show(Sorgu_sDil("Fiþi Silmek Ýstediðinize Emin misiniz...?", sDil), Sorgu_sDil("Dikkat", sDil), MessageBoxButtons.YesNo, MessageBoxIcon.Question) = MsgBoxResult.Yes Then
            Dim dr_hareket As DataRow
            For Each dr_hareket In ds_hareket.Tables(0).Rows
                Dim bPesinmi As Boolean = False
                If Trim(dr_hareket("sOdemeSekli")) = "N" Then
                    bPesinmi = True
                End If
                If bPesinmi = False Then
                    If dr_hareket("nKasaIslemID").ToString <> "" Then
                        tbFirmaHareket_kaydet_sil(dr_hareket("nKasaIslemID"))
                        'dr_hareket("nKasaIslemID") = ""
                    End If
                Else
                    If dr_hareket("nKasaIslemID").ToString <> "" Then
                        tbNakitKasa_kaydet_sil(dr_hareket("nKasaIslemID").ToString, 0)
                        'dr_baslik("nKasaIslemID") = ""
                    End If
                End If
                bPesinmi = False
                tbFirinServis_kaydet_sil(dr_hareket("nHareketID"), nServisID)
                If tbStokFisiMaster_kaydet_sil(dr_hareket("nStokFisiID"), sFisTipi) = True Then
                    dr_hareket("nStokFisiID") = ""
                    dr_hareket("nIslemID1") = 0
                    dr_hareket("nIslemID2") = 0
                    dr_hareket("nIslemID3") = 0
                    dr_hareket("nIslemID4") = 0
                    dr_hareket("nIslemID5") = 0
                    dr_hareket("nIslemID6") = 0
                    dr_hareket("nIslemID7") = 0
                    dr_hareket("nIslemID8") = 0
                    dr_hareket("nIslemID9") = 0
                    dr_hareket("nIslemID10") = 0
                End If
            Next
            tbFirinServisMaster_kaydet_sil(dr_baslik("nServisID"))
            Me.Close()
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
            qr_baslik = frx.FindObject("qr_baslik")
            qr_baslik.Query = sorgu_txt_baslik
            qr_hareket = frx.FindObject("qr_hareket")
            qr_hareket.Query = sorgu_txt_hareket
            qr_toplam = frx.FindObject("qr_toplam")
            qr_toplam.Query = sorgu_txt_toplam
            Dim skriter1 As String = "WHERE (Master.sFisTipi = 'U')"
            Dim skriter2 As String = "WHERE (Master.sFisTipi = 'C')"
            skriter1 += " AND Master.dteFisTarihi between '" & dr_baslik("dteFisTarihi") & "' and '" & dr_baslik("dteFisTarihi") & "' "
            skriter2 += " AND Master.dteFisTarihi between '" & dr_baslik("dteFisTarihi") & "' and '" & dr_baslik("dteFisTarihi") & "' "
            qr_girdi = frx.FindObject("qr_girdi")
            qr_girdi.Query = sorgu_query("SET DATEFORMAT DMY SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT * FROM tbFirinServisMaster Master INNER JOIN (SELECT nServisID , SUM(lMiktar1 - lIade1) AS lMiktar1 , SUM(lMiktar2 - lIade2) AS lMiktar2 , SUM(lMiktar3 - lIade3) AS lMiktar3 , SUM(lMiktar4 - lIade4) AS lMiktar4 , SUM(lMiktar5 - lIade5) AS lMiktar5 , SUM(lMiktar6 - lIade6) AS lMiktar6 , SUM(lMiktar7 - lIade7) AS lMiktar7 , SUM(lMiktar8 - lIade8) AS lMiktar8 , SUM(lMiktar9 - lIade9) AS lMiktar9 , SUM(lMiktar10 - lIade10) AS lMiktar10 , SUM(lTutar) AS lTutar , SUM(lTahsilat) AS lTahsilat FROM tbFirinServisDetay GROUP BY nServisID) Detay ON Master.nServisID = Detay.nServisID " & skriter1 & " ")
            qr_cikti = frx.FindObject("qr_cikti")
            qr_cikti.Query = sorgu_query("SET DATEFORMAT DMY SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT * FROM tbFirinServisMaster Master INNER JOIN (SELECT nServisID , SUM(lMiktar1 - lIade1) AS lMiktar1 , SUM(lMiktar2 - lIade2) AS lMiktar2 , SUM(lMiktar3 - lIade3) AS lMiktar3 , SUM(lMiktar4 - lIade4) AS lMiktar4 , SUM(lMiktar5 - lIade5) AS lMiktar5 , SUM(lMiktar6 - lIade6) AS lMiktar6 , SUM(lMiktar7 - lIade7) AS lMiktar7 , SUM(lMiktar8 - lIade8) AS lMiktar8 , SUM(lMiktar9 - lIade9) AS lMiktar9 , SUM(lMiktar10 - lIade10) AS lMiktar10 , SUM(lTutar) AS lTutar , SUM(lTahsilat) AS lTahsilat FROM tbFirinServisDetay GROUP BY nServisID) Detay ON Master.nServisID = Detay.nServisID " & skriter2 & " ")
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
            skriter1 += " AND Master.dteFisTarihi between '" & dr_baslik("dteFisTarihi") & "' and '" & dr_baslik("dteFisTarihi") & "' "
            skriter2 += " AND Master.dteFisTarihi between '" & dr_baslik("dteFisTarihi") & "' and '" & dr_baslik("dteFisTarihi") & "' "
            args(2) = "" & sorgu_txt_baslik & "é" & sorgu_txt_hareket & "é" & sorgu_txt_toplam & "é" & sorgu_query("SET DATEFORMAT DMY SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT * FROM tbFirinServisMaster Master INNER JOIN (SELECT nServisID , SUM(lMiktar1 - lIade1) AS lMiktar1 , SUM(lMiktar2 - lIade2) AS lMiktar2 , SUM(lMiktar3 - lIade3) AS lMiktar3 , SUM(lMiktar4 - lIade4) AS lMiktar4 , SUM(lMiktar5 - lIade5) AS lMiktar5 , SUM(lMiktar6 - lIade6) AS lMiktar6 , SUM(lMiktar7 - lIade7) AS lMiktar7 , SUM(lMiktar8 - lIade8) AS lMiktar8 , SUM(lMiktar9 - lIade9) AS lMiktar9 , SUM(lMiktar10 - lIade10) AS lMiktar10 , SUM(lTutar) AS lTutar , SUM(lTahsilat) AS lTahsilat FROM tbFirinServisDetay GROUP BY nServisID) Detay ON Master.nServisID = Detay.nServisID " & skriter1 & " ") & "é" & sorgu_query("SET DATEFORMAT DMY SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT * FROM tbFirinServisMaster Master INNER JOIN (SELECT nServisID , SUM(lMiktar1 - lIade1) AS lMiktar1 , SUM(lMiktar2 - lIade2) AS lMiktar2 , SUM(lMiktar3 - lIade3) AS lMiktar3 , SUM(lMiktar4 - lIade4) AS lMiktar4 , SUM(lMiktar5 - lIade5) AS lMiktar5 , SUM(lMiktar6 - lIade6) AS lMiktar6 , SUM(lMiktar7 - lIade7) AS lMiktar7 , SUM(lMiktar8 - lIade8) AS lMiktar8 , SUM(lMiktar9 - lIade9) AS lMiktar9 , SUM(lMiktar10 - lIade10) AS lMiktar10 , SUM(lTutar) AS lTutar , SUM(lTahsilat) AS lTahsilat FROM tbFirinServisDetay GROUP BY nServisID) Detay ON Master.nServisID = Detay.nServisID " & skriter2 & " ") & ""
            args(3) = "qr_baslikéqr_hareketéqr_toplaméqr_girdiéqr_cikti"
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
    Private Sub analiz_Firma_karti()
        If GridView1.RowCount > 0 Then
            Dim dr As DataRow = GridView1.GetDataRow(GridView1.FocusedRowHandle)
            Dim frm As New frm_firma_kart
            frm.firmano = nFirmaNo
            frm.donemno = nDonemNo
            frm.connection = sConnection
            frm.sKodu = dr("sKodu")
            frm.nFirmaID = dr("nFirmaID")
            frm.kullanici = sKullanici
            If yetki_kontrol(sKullanici, frm.Name) = True Then
                frm.ShowDialog()
            End If
            frm.Close()
            frm.Dispose()
            frm = Nothing
        End If
    End Sub
    Private Sub analiz_cari_hareket()
        If GridView1.RowCount > 0 Then
            Dim dr As DataRow = GridView1.GetDataRow(GridView1.FocusedRowHandle)
            Dim frm As New frm_cari_hareketler_ozet
            frm.firmano = nFirmaNo
            frm.donemno = nDonemNo
            frm.connection = sConnection
            frm.musterino = dr("sKodu")
            frm.kullanici = sKullanici
            If yetki_kontrol(sKullanici, frm.Name) = True Then
                If yetki_kontrol(kullanici, "frm_firma_liste_hesapTuru_" & Trim(CariHesapTuruSorgula(dr("sKodu")))) = True Then
                    frm.ShowDialog()
                End If
            End If
            frm.Close()
            frm.Dispose()
            frm = Nothing
        End If
    End Sub
    Private Sub analiz_cari_bakiye()
        If GridView1.RowCount > 0 Then
            Dim dr As DataRow = GridView1.GetDataRow(GridView1.FocusedRowHandle)
            Dim frm As New frm_Firma_bakiye
            frm.firmano = nFirmaNo
            frm.donemno = nDonemNo
            frm.connection = sConnection
            frm.sKodu = dr("sKodu")
            frm.txt_musteriNo.EditValue = dr("sKodu")
            frm.kullanici = sKullanici
            If yetki_kontrol(sKullanici, frm.Name) = True Then
                If yetki_kontrol(kullanici, "frm_firma_liste_hesapTuru_" & Trim(CariHesapTuruSorgula(frm.sKodu))) = True Then
                    frm.ShowDialog()
                End If
            End If
            frm.Close()
            frm.Dispose()
            frm = Nothing
        End If
    End Sub
    Private Sub analiz_envanter()
        Dim dr As DataRow
        dr = GridView1.GetDataRow(GridView1.FocusedRowHandle)
        Dim dr2 As DataRow
        Dim frm As New frm_stok_envanter
        frm.firmano = nFirmaNo
        frm.donemno = nDonemNo
        frm.connection = sConnection
        If GridView1.FocusedColumn.Name = collMiktar1.Name Or GridView1.FocusedColumn.Name = collIade1.Name Then
            dr2 = ds_tbStokSinifi.Tables(0).Rows(0)
            frm.stokno = dr2("nStokID")
            frm.stokkodu = dr2("sKodu")
        ElseIf GridView1.FocusedColumn.Name = collMiktar2.Name Or GridView1.FocusedColumn.Name = collIade2.Name Then
            dr2 = ds_tbStokSinifi.Tables(0).Rows(1)
            frm.stokno = dr2("nStokID")
            frm.stokkodu = dr2("sKodu")
        ElseIf GridView1.FocusedColumn.Name = collMiktar3.Name Or GridView1.FocusedColumn.Name = collIade3.Name Then
            dr2 = ds_tbStokSinifi.Tables(0).Rows(2)
            frm.stokno = dr2("nStokID")
            frm.stokkodu = dr2("sKodu")
        ElseIf GridView1.FocusedColumn.Name = collMiktar4.Name Or GridView1.FocusedColumn.Name = collIade4.Name Then
            dr2 = ds_tbStokSinifi.Tables(0).Rows(3)
            frm.stokno = dr2("nStokID")
            frm.stokkodu = dr2("sKodu")
        ElseIf GridView1.FocusedColumn.Name = collMiktar5.Name Or GridView1.FocusedColumn.Name = collIade5.Name Then
            dr2 = ds_tbStokSinifi.Tables(0).Rows(4)
            frm.stokno = dr2("nStokID")
            frm.stokkodu = dr2("sKodu")
        ElseIf GridView1.FocusedColumn.Name = collMiktar6.Name Or GridView1.FocusedColumn.Name = collIade6.Name Then
            dr2 = ds_tbStokSinifi.Tables(0).Rows(5)
            frm.stokno = dr2("nStokID")
            frm.stokkodu = dr2("sKodu")
        ElseIf GridView1.FocusedColumn.Name = collMiktar7.Name Or GridView1.FocusedColumn.Name = collIade7.Name Then
            dr2 = ds_tbStokSinifi.Tables(0).Rows(6)
            frm.stokno = dr2("nStokID")
            frm.stokkodu = dr2("sKodu")
        ElseIf GridView1.FocusedColumn.Name = collMiktar8.Name Or GridView1.FocusedColumn.Name = collIade8.Name Then
            dr2 = ds_tbStokSinifi.Tables(0).Rows(7)
            frm.stokno = dr2("nStokID")
            frm.stokkodu = dr2("sKodu")
        ElseIf GridView1.FocusedColumn.Name = collMiktar9.Name Or GridView1.FocusedColumn.Name = collIade9.Name Then
            dr2 = ds_tbStokSinifi.Tables(0).Rows(8)
            frm.stokno = dr2("nStokID")
            frm.stokkodu = dr2("sKodu")
        ElseIf GridView1.FocusedColumn.Name = collMiktar10.Name Or GridView1.FocusedColumn.Name = collIade10.Name Then
            dr2 = ds_tbStokSinifi.Tables(0).Rows(9)
            frm.stokno = dr2("nStokID")
            frm.stokkodu = dr2("sKodu")
        End If
        frm.kullanici = sKullanici
        If yetki_kontrol(sKullanici, frm.Name) = True Then
            frm.ShowDialog()
        End If
        frm.Close()
        frm.Dispose()
        frm = Nothing
        dr2 = Nothing
    End Sub
    Private Sub analiz_stok_hareket()
        If GridView1.RowCount > 0 Then
            Dim dr As DataRow = GridView1.GetDataRow(GridView1.FocusedRowHandle)
            Dim dr2 As DataRow
            Dim frm As New frm_stok_hareketleri
            frm.firmano = nFirmaNo
            frm.donemno = nDonemNo
            frm.connection = sConnection
            If GridView1.FocusedColumn.Name = collMiktar1.Name Or GridView1.FocusedColumn.Name = collIade1.Name Then
                dr2 = ds_tbStokSinifi.Tables(0).Rows(0)
                frm.musterino = dr2("sKodu")
                frm.Label1.Text = dr2("sAciklama") & vbCrLf & frm.Label1.Text
            ElseIf GridView1.FocusedColumn.Name = collMiktar2.Name Or GridView1.FocusedColumn.Name = collIade2.Name Then
                dr2 = ds_tbStokSinifi.Tables(0).Rows(1)
                frm.musterino = dr2("sKodu")
                frm.Label1.Text = dr2("sAciklama") & vbCrLf & frm.Label1.Text
            ElseIf GridView1.FocusedColumn.Name = collMiktar3.Name Or GridView1.FocusedColumn.Name = collIade3.Name Then
                dr2 = ds_tbStokSinifi.Tables(0).Rows(2)
                frm.musterino = dr2("sKodu")
                frm.Label1.Text = dr2("sAciklama") & vbCrLf & frm.Label1.Text
            ElseIf GridView1.FocusedColumn.Name = collMiktar4.Name Or GridView1.FocusedColumn.Name = collIade4.Name Then
                dr2 = ds_tbStokSinifi.Tables(0).Rows(3)
                frm.musterino = dr2("sKodu")
                frm.Label1.Text = dr2("sAciklama") & vbCrLf & frm.Label1.Text
            ElseIf GridView1.FocusedColumn.Name = collMiktar5.Name Or GridView1.FocusedColumn.Name = collIade5.Name Then
                dr2 = ds_tbStokSinifi.Tables(0).Rows(4)
                frm.musterino = dr2("sKodu")
                frm.Label1.Text = dr2("sAciklama") & vbCrLf & frm.Label1.Text
            ElseIf GridView1.FocusedColumn.Name = collMiktar6.Name Or GridView1.FocusedColumn.Name = collIade6.Name Then
                dr2 = ds_tbStokSinifi.Tables(0).Rows(5)
                frm.musterino = dr2("sKodu")
                frm.Label1.Text = dr2("sAciklama") & vbCrLf & frm.Label1.Text
            ElseIf GridView1.FocusedColumn.Name = collMiktar7.Name Or GridView1.FocusedColumn.Name = collIade7.Name Then
                dr2 = ds_tbStokSinifi.Tables(0).Rows(6)
                frm.musterino = dr2("sKodu")
                frm.Label1.Text = dr2("sAciklama") & vbCrLf & frm.Label1.Text
            ElseIf GridView1.FocusedColumn.Name = collMiktar8.Name Or GridView1.FocusedColumn.Name = collIade8.Name Then
                dr2 = ds_tbStokSinifi.Tables(0).Rows(7)
                frm.musterino = dr2("sKodu")
                frm.Label1.Text = dr2("sAciklama") & vbCrLf & frm.Label1.Text
            ElseIf GridView1.FocusedColumn.Name = collMiktar9.Name Or GridView1.FocusedColumn.Name = collIade9.Name Then
                dr2 = ds_tbStokSinifi.Tables(0).Rows(8)
                frm.musterino = dr2("sKodu")
                frm.Label1.Text = dr2("sAciklama") & vbCrLf & frm.Label1.Text
            ElseIf GridView1.FocusedColumn.Name = collMiktar10.Name Or GridView1.FocusedColumn.Name = collIade10.Name Then
                dr2 = ds_tbStokSinifi.Tables(0).Rows(9)
                frm.musterino = dr2("sKodu")
                frm.Label1.Text = dr2("sAciklama") & vbCrLf & frm.Label1.Text
            End If
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
            frm.kullanici = sKullanici
            If yetki_kontrol(sKullanici, frm.Name) = True Then
                frm.ShowDialog()
            End If
            frm.Close()
            frm.Dispose()
            frm = Nothing
        End If
    End Sub
    Private Sub analiz_stok_karti()
        If GridView1.RowCount > 0 Then
            Dim dr As DataRow
            Dim dr2 As DataRow
            dr = GridView1.GetDataRow(GridView1.FocusedRowHandle)
            Dim frm As New frm_stok_kart
            frm.firmano = nFirmaNo
            frm.donemno = nDonemNo
            frm.connection = sConnection
            If GridView1.FocusedColumn.Name = collMiktar1.Name Or GridView1.FocusedColumn.Name = collIade1.Name Then
                dr2 = ds_tbStokSinifi.Tables(0).Rows(0)
                frm.nStokID = dr2("nStokId")
                frm.sKodu = dr2("sKodu")
                frm.sModel = dr2("sModel")
            ElseIf GridView1.FocusedColumn.Name = collMiktar2.Name Or GridView1.FocusedColumn.Name = collIade2.Name Then
                dr2 = ds_tbStokSinifi.Tables(0).Rows(1)
                frm.nStokID = dr2("nStokId")
                frm.sKodu = dr2("sKodu")
                frm.sModel = dr2("sModel")
            ElseIf GridView1.FocusedColumn.Name = collMiktar3.Name Or GridView1.FocusedColumn.Name = collIade3.Name Then
                dr2 = ds_tbStokSinifi.Tables(0).Rows(2)
                frm.nStokID = dr2("nStokId")
                frm.sKodu = dr2("sKodu")
                frm.sModel = dr2("sModel")
            ElseIf GridView1.FocusedColumn.Name = collMiktar4.Name Or GridView1.FocusedColumn.Name = collIade4.Name Then
                dr2 = ds_tbStokSinifi.Tables(0).Rows(3)
                frm.nStokID = dr2("nStokId")
                frm.sKodu = dr2("sKodu")
                frm.sModel = dr2("sModel")
            ElseIf GridView1.FocusedColumn.Name = collMiktar5.Name Or GridView1.FocusedColumn.Name = collIade5.Name Then
                dr2 = ds_tbStokSinifi.Tables(0).Rows(4)
                frm.nStokID = dr2("nStokId")
                frm.sKodu = dr2("sKodu")
                frm.sModel = dr2("sModel")
            ElseIf GridView1.FocusedColumn.Name = collMiktar6.Name Or GridView1.FocusedColumn.Name = collIade6.Name Then
                dr2 = ds_tbStokSinifi.Tables(0).Rows(5)
                frm.nStokID = dr2("nStokId")
                frm.sKodu = dr2("sKodu")
                frm.sModel = dr2("sModel")
            ElseIf GridView1.FocusedColumn.Name = collMiktar7.Name Or GridView1.FocusedColumn.Name = collIade7.Name Then
                dr2 = ds_tbStokSinifi.Tables(0).Rows(6)
                frm.nStokID = dr2("nStokId")
                frm.sKodu = dr2("sKodu")
                frm.sModel = dr2("sModel")
            ElseIf GridView1.FocusedColumn.Name = collMiktar8.Name Or GridView1.FocusedColumn.Name = collIade8.Name Then
                dr2 = ds_tbStokSinifi.Tables(0).Rows(7)
                frm.nStokID = dr2("nStokId")
                frm.sKodu = dr2("sKodu")
                frm.sModel = dr2("sModel")
            ElseIf GridView1.FocusedColumn.Name = collMiktar9.Name Or GridView1.FocusedColumn.Name = collIade9.Name Then
                dr2 = ds_tbStokSinifi.Tables(0).Rows(8)
                frm.nStokID = dr2("nStokId")
                frm.sKodu = dr2("sKodu")
                frm.sModel = dr2("sModel")
            ElseIf GridView1.FocusedColumn.Name = collMiktar10.Name Or GridView1.FocusedColumn.Name = collIade10.Name Then
                dr2 = ds_tbStokSinifi.Tables(0).Rows(9)
                frm.nStokID = dr2("nStokId")
                frm.sKodu = dr2("sKodu")
                frm.sModel = dr2("sModel")
            End If
            frm.kullanici = sKullanici
            If yetki_kontrol(sKullanici, frm.Name) = True Then
                frm.ShowDialog()
            End If
            frm.Close()
            frm.Dispose()
            frm = Nothing
        End If
    End Sub
    Private Sub GridView1_CellValueChanged(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs) Handles GridView1.CellValueChanged
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
    Private Sub SilToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SilToolStripMenuItem.Click
        satir_sil()
    End Sub
    Private Sub GridControl1_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles GridControl1.KeyDown
        If e.KeyCode = Keys.Escape Then
            If XtraMessageBox.Show(Sorgu_sDil("Ekraný Kapatmak Ýstediðinize Emin misiniz...?", sDil), Sorgu_sDil("Dikkat", sDil), MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
                Me.Close()
            End If
        End If
    End Sub
    Private Sub GridView1_FocusedRowChanged(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs) Handles GridView1.FocusedRowChanged
        If yuklendi = True Then
            If GridView1.RowCount > 0 Then
                Dim dr As DataRow = GridView1.GetDataRow(GridView1.FocusedRowHandle)
                Dataload_tbFirma(dr("sKodu").ToString)
                dr = Nothing
            End If
        End If
    End Sub
    Private Sub BarButtonItem11_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem11.ItemClick
        If GridView1.RowCount > 0 Then
            If XtraMessageBox.Show(Sorgu_sDil("[" & GridView1.FocusedColumn().Caption & "] Kolonundaki verileri Aþaðý Doðru Yaymak istediðinize Emin misiniz...?", sDil), Sorgu_sDil("Dikkat", sDil), MessageBoxButtons.YesNo, MessageBoxIcon.Question) = MsgBoxResult.Yes Then
                info = False
                degeryay(GridView1.FocusedColumn().FieldName)
                info = True
                'toplam_hesapla()
            End If
        End If
    End Sub
    Private Sub VGrid_baslik_CellValueChanged(ByVal sender As Object, ByVal e As DevExpress.XtraVerticalGrid.Events.CellValueChangedEventArgs) Handles VGrid_baslik.CellValueChanged
        Try
            'Vgrid_baslik.PostEditor()
            VGrid_baslik.UpdateFocusedRecord()
            VGrid_baslik.CloseEditor()
            tbFirinServisMaster_kaydet_duzelt(dr_baslik("nServisID"), dr_baslik("dteFisTarihi"), dr_baslik("sFisTipi"), dr_baslik("nGirisCikis"), dr_baslik("lFisNo"), dr_baslik("sSaticiRumuzu"), dr_baslik("sServis"), dr_baslik("sKullanici"), dr_baslik("dteKayitTarihi"), dr_baslik("sAciklama1"), dr_baslik("sAciklama2"), dr_baslik("sAciklama3"), dr_baslik("sAciklama4"), dr_baslik("sAciklama5"))
            tbFirinServisMasterDetay_kaydet_duzelt(dr_baslik("nServisID"), dr_baslik("dteFisTarihi"), dr_baslik("lFisNo"), dr_baslik("sSaticiRumuzu"), dr_baslik("sServis"), dr_baslik("sKullanici"), dr_baslik("dteKayitTarihi"), dr_baslik("sAciklama1"), dr_baslik("sAciklama2"), dr_baslik("sAciklama3"), dr_baslik("sAciklama4"), dr_baslik("sAciklama5"))
            Dim satir = GridView1.FocusedRowHandle
            Dim sayi As Integer = 0
            Dim dr As DataRow
            dteFisTarihi = dr_baslik("dteFisTarihi")
            lFisNo = dr_baslik("lFisNo")
            For Each dr In ds_hareket.Tables(0).Rows
                dr.BeginEdit()
                GridView1.FocusedRowHandle = sayi
                dr("dteFisTarihi") = dr_baslik("dteFisTarihi")
                dr("lFisNo") = dr_baslik("lFisNo")
                dr("sSaticiRumuzu") = dr_baslik("sSaticiRumuzu")
                dr("sServis") = dr_baslik("sServis")
                dr.EndEdit()
                tutar_hesapla()
                sayi += 1
            Next
            Dataload_tbFirinServis(dr_baslik("nServisID"))
            GridView1.FocusedRowHandle = satir
            satir = Nothing
            sayi = Nothing
        Catch ex As Exception
            XtraMessageBox.Show(Sorgu_sDil("Ýþlem Hatasý Lütfen Bilgileri Kontrol Edip Tekrar Deneyiniz...!", sDil), Sorgu_sDil("Dikkat", sDil), MessageBoxButtons.OK, MessageBoxIcon.Information)
        End Try
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
    Private Sub BarButtonItem9_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem9.ItemClick
        satir_sil()
    End Sub
    Private Sub BarButtonItem7_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem7.ItemClick
        If Trim(FisTipi) = "S" Then
            satir_ekle()
        Else
            satir_ekle_direkt()
        End If
    End Sub
    Private Sub BarButtonItem10_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem10.ItemClick
        If BarButtonItem10.Down = False Then
            GridView1.OptionsView.ShowAutoFilterRow = True
            GridView1.OptionsView.ShowFilterPanelMode = DevExpress.XtraGrid.Views.Base.ShowFilterPanelMode.Default
            GridView1.OptionsCustomization.AllowFilter = True
            BarButtonItem10.Down = True
        ElseIf BarButtonItem10.Down = True Then
            GridView1.OptionsView.ShowAutoFilterRow = False
            GridView1.OptionsView.ShowFilterPanelMode = DevExpress.XtraGrid.Views.Base.ShowFilterPanelMode.Never
            GridView1.OptionsCustomization.AllowFilter = False
            BarButtonItem10.Down = False
        End If
    End Sub
    Private Sub BarButtonItem17_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem17.ItemClick
        VGrid_baslik.RowsCustomization()
    End Sub
    Private Sub BarButtonItem18_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem18.ItemClick
        GridView1.ColumnsCustomization()
    End Sub
    Private Sub BarButtonItem19_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem19.ItemClick
        VGrid_Toplam.RowsCustomization()
    End Sub
    Private Sub BarButtonItem20_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem20.ItemClick
        gorunum_kaydet()
    End Sub
    Private Sub BarButtonItem3_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem3.ItemClick
        raporla(0, 0)
    End Sub
    Private Sub BarButtonItem4_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem4.ItemClick
        raporla(0, 2)
    End Sub
    Private Sub BarButtonItem5_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem5.ItemClick
        raporla(0, 1)
    End Sub
    Private Sub BarButtonItem6_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem6.ItemClick
        fis_sil()
    End Sub
    Private Sub ToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem1.Click
        fis_sil()
    End Sub
    Private Sub FirmaKartýToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FirmaKartýToolStripMenuItem.Click
        analiz_Firma_karti()
    End Sub
    Private Sub FirmaHareketleriToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FirmaHareketleriToolStripMenuItem.Click
        analiz_cari_hareket()
    End Sub
    Private Sub BakiyeAnaliziToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BakiyeAnaliziToolStripMenuItem.Click
        analiz_cari_bakiye()
    End Sub
    Private Sub StokKartiToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles StokKartiToolStripMenuItem.Click
        analiz_stok_karti()
    End Sub
    Private Sub StokEnvanterToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles StokEnvanterToolStripMenuItem.Click
        analiz_envanter()
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
    Private Sub GörünümüDüzenleToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GörünümüDüzenleToolStripMenuItem.Click
        GridView1.ColumnsCustomization()
    End Sub
    Private Sub GörünümüYazdýrToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GörünümüYazdýrToolStripMenuItem.Click
        printlink1.CreateDocument(ps)
        ps.PreviewRibbonFormEx.Show()
    End Sub

End Class