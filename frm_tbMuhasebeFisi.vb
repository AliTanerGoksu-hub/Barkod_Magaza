Imports FastReport
Imports DevExpress.XtraGrid
Imports DevExpress.XtraEditors
Imports DevExpress.XtraGrid.Columns
Imports Microsoft.Win32
Imports System.IO
Public Class frm_tbMuhasebeFisi
    Public firmano
    Public donemno
    Public connection
    Public kullanici
    Public bMuhasabe As Boolean = False
    Public sModul As String = "Cari"
    Public dteFisTarihi As DateTime
    Public sMuhFisTipi As Integer = 3
    Public sFisAciklama As String = ""
    Public lFisNo As Int64 = 0
    Public lYevmiyeNo As Int64 = 0
    Public sKodu As String = ""
    Dim ds_tbsube As DataSet
    Dim ds_tbDovizCinsi As DataSet
    Dim ds_tbHareketTipi As DataSet
    Dim ds_sCarisIslem As DataSet
    Dim ds_Firma As DataSet
    Dim ds_tbCariIslem As DataSet
    Dim ds_tbMasrafMerkezi As DataSet
    Public yeni As Boolean = False
    Dim status As Boolean = False
    Dim sAciklama As String = ""
    Dim mevcut As Decimal = 1
    Dim x As Integer = 0
    Dim okut As Boolean = False
    Dim dr_baslik As DataRow
    Dim sSorguHareket As String = ""
    Dim bKilitli As Boolean = False
    Dim bKilitAcabilir As Boolean = False
    Dim bKopya As Boolean = False
    Public nFirmaID As String = ""
    Public txt_sKodu As ButtonEdit
    Public sDovizCinsi As String = ""
    Public bResmi As Boolean = False
    Public MuhsFisTipi As String = ""
    Public MuhnFirmaID As Integer = 0
    Public MuhnGirisCikis As Integer = 0
    Public MuhnStokFisiID As Integer = 0
    Public PerakendeMi As Boolean = False
    Private Sub frm_tbMuhasebeFisi_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        Registry.CurrentUser.CreateSubKey("Software").CreateSubKey("BusinessSmart").CreateSubKey("VIEW").CreateSubKey("Perakende").CreateSubKey("MuhasebeFisi").SetValue("Kriter", sec_kriter.Text)
        Try
            tbFisKilit_sil(dr_baslik("lFisNo"), dr_baslik("sMuhFisTipi"), kullanici)
        Catch ex As Exception
        End Try
        If GridView1.RowCount >= 2 Then
            lFisNo_degistir()
            tbMuhasebeFisi_Aciklamasi_degistir()
            If dr_baslik("bKilitli") = False Or bKilitli = False Then
                tutarlar_hesapla()
            End If
            If FormatNumber(sorgu_lBakiye(dr_baslik("dteFisTarihi"), dr_baslik("sMuhFisTipi"), dr_baslik("lFisNo")), 2) <> "0.00" Then
                e.Cancel = True
                XtraMessageBox.Show(Sorgu_sDil("Fiþ Borç Alacak Toplamýnýn Eþit Olmasý Gerekmektedir..!", sDil), Sorgu_sDil("Dikkat", sDil), MessageBoxButtons.OK, MessageBoxIcon.Warning)
            End If
            SonYevmiyeKaydet(sMuhFisTipi, Integer.Parse(dr_baslik("lYevmiyeNo").ToString()))
        ElseIf dr_baslik("lFisNo") > 0 And GridView1.RowCount = 1 And bKilitli = False Then
            If XtraMessageBox.Show(Sorgu_sDil("Boþ Fiþ Kaydedemezsiniz, Fiþi Silmek Ýster misiniz...?", sDil), Sorgu_sDil("Dikkat", sDil), MessageBoxButtons.YesNo, MessageBoxIcon.Question) = MsgBoxResult.Yes Then
                tbMuhasebeFisi_sil(dr_baslik("dteFisTarihi"), dr_baslik("sMuhFisTipi"), dr_baslik("lFisNo"))
                lFisNo_degistir()
                Try
                    ds_tbMuhasebeFisi.Tables(0).Clear()
                Catch ex As Exception
                End Try
                dr_baslik("dteFisTarihi") = Today
                dr_baslik("lFisNo") = 0
                dr_baslik("lYevmiyeNo") = 0
                SonYevmiyeKaydet(sMuhFisTipi, (SonYevmiyeNoBul(sMuhFisTipi) - 1))
                Me.Close()
            Else
                SonYevmiyeKaydet(sMuhFisTipi, Integer.Parse(dr_baslik("lYevmiyeNo").ToString()))
                dr_baslik("lFisNo") = 0
                Me.Close()
            End If
        End If
    End Sub
    Private Sub MuhasebeFisiBaslangic()
        Try
            sec_kriter.Text = Registry.CurrentUser.OpenSubKey("Software").OpenSubKey("BusinessSmart").OpenSubKey("VIEW").OpenSubKey("Perakende").OpenSubKey("MuhasebeFisi").GetValue("Kriter").ToString
        Catch ex As Exception
            sec_kriter.Text = "Baþlar"
        End Try
        dataload_tbSube()
        dataload_tbDovizCinsi()
        dataload_tbHareketTipi()
        dataload_tbMasrafMerkezi()
        dataload_tbsCariIslem()
        If lFisNo > 0 Then
            Try
                If sorgu_nMuhasebeFisiAciklamasiKaydi(dteFisTarihi, sMuhFisTipi, lFisNo) = 0 Then
                    tbMuhasebeFisi_Aciklamasi_kaydet_yeni(dteFisTarihi, sMuhFisTipi, lFisNo, "", "", "", "", "", 0)
                End If
            Catch ex As Exception
            End Try
            ds_baslik = sorgu_baslik(dteFisTarihi, sMuhFisTipi, lFisNo)
            VGrid_Baslik.DataSource = ds_baslik.Tables(0)
            If ds_baslik.Tables(0).Rows.Count > 0 Then
                dr_baslik = ds_baslik.Tables(0).Rows(0)
                Dataload_tbMuhasebeFisi(dr_baslik("dteFisTarihi"), dr_baslik("sMuhFisTipi"), dr_baslik("lFisNo"))
            End If
            'GroupControl1.Enabled = False
            'GroupControl2.Enabled = False
            GridControl1.Focus()
            GridControl1.Select()
            If sorgu_nKilit(lFisNo, sMuhFisTipi, kullanici) = 0 Then
                bKilitli = False
                Try
                    tbFisKilit_ekle(lFisNo, sMuhFisTipi, kullanici, Now)
                Catch ex As Exception
                    bKilitli = True
                End Try
            Else
                bKilitli = True
            End If
        Else
            If sFisAciklama = "Açýlýþ Fiþi" Then
                lFisNo = 1
            Else
                lFisNo = sorgu_lFisNo()
            End If
            Dim dr As DataRow = ds_baslik.Tables(0).NewRow
            dr("dteFisTarihi") = dteFisTarihi
            dr("sMuhFisTipi") = sMuhFisTipi
            dr("lFisNo") = lFisNo
            dr("lYevmiyeNo") = SonYevmiyeNoBul(sMuhFisTipi)
            SonYevmiyeKaydet(sMuhFisTipi, Integer.Parse(dr("lYevmiyeNo").ToString()))
            dr("sHareketTipi") = sSubeMagaza
            dr("sSubeMagaza") = sSubeMagaza
            dr("bKilitli") = 0
            dr("sAciklama") = ""
            dr("sAciklama1") = ""
            dr("sAciklama2") = ""
            dr("sAciklama3") = ""
            dr("sAciklama4") = ""
            dr("sAciklama5") = ""
            dr("sKullaniciAdi") = kullaniciadi
            dr("dteKayitTarihi") = Now
            ds_baslik.Tables(0).Rows.Add(dr)
            dr_baslik = ds_baslik.Tables(0).Rows(0)
            Dataload_tbFirma(sKodu, "Eþittir", True)
            If bMuhasabe = False Then
                satir_ekle_firma_tek()
            ElseIf bMuhasabe = True Then
                muhasebe_satir_ekle_firma_tek()
            End If
            Try
                tbMuhasebeFisi_Aciklamasi_kaydet_yeni(dteFisTarihi, sMuhFisTipi, lFisNo, "", "", "", "", "", 0)
            Catch ex As Exception
            End Try
            ds_baslik = sorgu_baslik(dteFisTarihi, sMuhFisTipi, lFisNo)
            VGrid_Baslik.DataSource = ds_baslik.Tables(0)
            If ds_baslik.Tables(0).Rows.Count > 0 Then
                dr_baslik = ds_baslik.Tables(0).Rows(0)
                If sMuhFisTipi = 1 Or sMuhFisTipi = 2 Then
                    Dim nHesapID As Int64 = sorgu_nKasaHesapID()
                    Dim nFisSiraID As Int64 = sorgu_nFisSiraID()
                    nFisSiraID = tbMuhasebeFisi_kaydet_yeni(nFisSiraID, dr_baslik("dteFisTarihi"), dr_baslik("sMuhFisTipi"), dr_baslik("lFisNo"), dr_baslik("lYevmiyeNo"), nHesapID, "", 0, 0, 0, 0, "", 0, "MUH", dr_baslik("sHareketTipi"), 0, kullaniciadi, Now, "", 0, 0, "", 0, 0, 0, dr_baslik("sSubeMagaza"), kullaniciadi, Now)
                    nFisSiraID_degistir(nFisSiraID)
                End If
                Dataload_tbMuhasebeFisi(dr_baslik("dteFisTarihi"), dr_baslik("sMuhFisTipi"), dr_baslik("lFisNo"))
            End If
            Try
                tbFisKilit_ekle(lFisNo, sMuhFisTipi, kullanici, Now)
            Catch ex As Exception
                bKilitli = False
            End Try
        End If
        Try
            lFisNo_degistir()
        Catch ex As Exception
        End Try
        Try
            gorunum_yukle()
        Catch ex As Exception
        End Try
        'If yeni = True Then
        '    If btn_Goster.Text = "&Göster" Then
        '        Dataload_tbMuhasebeFisi(dr_baslik("dteFisTarihi"), dr_baslik("sMuhFisTipi"), dr_baslik("lFisNo"))
        '    ElseIf btn_Goster.Text = "&Yeni" Then
        '        dr_baslik("lFisNo") = sorgu_lFisNo()
        '        Try
        '            ds_tbMuhasebeFisi.Tables(0).Clear()
        '        Catch ex As Exception
        '        End Try
        '        yeni = True
        '    End If
        'End If
        GridControl1.Focus()
        GridControl1.Select()
        If sMuhFisTipi = 3 Then
            collBorcTutar.OptionsColumn.AllowFocus = True
            collAlacakTutar.OptionsColumn.AllowFocus = True
        ElseIf sMuhFisTipi = 1 Then
            collBorcTutar.OptionsColumn.AllowFocus = False
            collAlacakTutar.OptionsColumn.AllowFocus = True
        ElseIf sMuhFisTipi = 2 Then
            collBorcTutar.OptionsColumn.AllowFocus = True
            collAlacakTutar.OptionsColumn.AllowFocus = False
        End If
        bKilitAcabilir = yetki_kontrol(kullanici, Trim(sMuhFisTipi) & "_KilitAcabilir", False, 0)
        If kullanici > 2 And bKilitAcabilir = False Then
            rowbKilitli.Properties.ReadOnly = True
        Else
            rowbKilitli.Properties.ReadOnly = False
        End If
        Me.Text = dr_baslik("sAciklama")
        bKilitli = yetki_kontrol(kullanici, Me.Name.ToString & "_IslemYapamaz", False, 0)
        If dr_baslik("bKilitli") = True Or bKilitli = True Then
            btn_AltFisSil.Enabled = False
            btn_AltSatirEkle.Enabled = False
            btn_AltSatirSil.Enabled = False
            btn_BakiyeKapat.Enabled = False
            btn_DegerYay.Enabled = False
            btn_FisSil.Enabled = False
            btn_SatirDuzelt.Enabled = False
            btn_SatirEkle.Enabled = False
            btn_SatirSil.Enabled = False
            btn_Taksitlendir.Enabled = False
            GridView1.OptionsBehavior.Editable = False
            GridView1.OptionsBehavior.ReadOnly = True
            EkleToolStripMenuItem.Enabled = False
            SilToolStripMenuItem.Enabled = False
            FisSilToolStripMenuItem1.Enabled = False
            Panel_ara.Enabled = False
            Me.Text += Sorgu_sDil(Sorgu_sDil(" ( Salt Okunur )", sDil), sDil)
            If bKilitli = True Then
                Me.Text += Sorgu_sDil(" (Belge Kullanimda)", sDil)
            End If
        Else
            If txt_ara.Text <> "" Then
                firma_ara()
            End If
        End If
        If Trim(sSubeMagaza) = "001" Then
            rowsSubeMagaza.Properties.ReadOnly = False
        ElseIf Trim(sSubeMagaza) = "" Then
            rowsSubeMagaza.Properties.ReadOnly = False
        Else
            rowsSubeMagaza.Properties.ReadOnly = True
        End If
        If bKopya = True Then
            Me.Text += "Fis#Kopya"
        End If
        If bMuhasabe = True Then
            colsFirmaAciklama.Visible = False
            colsHesapAciklama.Visible = True
            colsHesapAciklama.VisibleIndex = 1
            coldteValorTarihi.Visible = False
            colnOpsiyon.Visible = False
            colsCariIslem.Visible = False
            Group_Cari.Visible = False
            VGrid_Baslik.BackColor = Color.Transparent
        Else
            VGrid_Baslik.BackColor = Color.BlueViolet
        End If
    End Sub
    Private Sub frm_tbNakitKasa_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        MuhasebeFisiBaslangic()
    End Sub
    Private Function sorgu_baslik(ByVal dteFisTarihi As DateTime, ByVal sMuhFisTipi As Int64, ByVal lFisNo As Int64) As DataSet
        Dim cmd As New OleDb.OleDbCommand
        Dim con As New OleDb.OleDbConnection
        Dim adapter As New OleDb.OleDbDataAdapter
        con.ConnectionString = connection
        adapter.SelectCommand = cmd
        'cmd.CommandText = "SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SET DATEFORMAT DMY SELECT DISTINCT tbMuhasebeFisiAciklamasi.dteFisTarihi, tbMuhasebeFisiAciklamasi.sMuhFisTipi, tbMuhasebeFisiAciklamasi.dteFisTarihi as FisTarihi,tbMuhasebeFisiAciklamasi.lFisno, tbMuhasebeFisiAciklamasi.sAciklama1, tbMuhasebeFisiAciklamasi.sAciklama2, tbMuhasebeFisiAciklamasi.sAciklama3, tbMuhasebeFisiAciklamasi.sAciklama4, tbMuhasebeFisiAciklamasi.sAciklama5, tbMuhFisTipi.sAciklama, ISNULL(tbMuhasebeFisi.lYevmiyeNo, 0) AS lYevmiyeNo,ISNULL(tbMuhasebeFisi.sHareketTipi, '') AS sHareketTipi,ISNULL(tbMuhasebeFisi.sSubeMagaza, '') AS sSubeMagaza,ISNULL(tbMuhasebeFisiAciklamasi.bKilitli,0) bKilitli FROM tbMuhasebeFisiAciklamasi INNER JOIN tbMuhFisTipi ON tbMuhasebeFisiAciklamasi.sMuhFisTipi = tbMuhFisTipi.sMuhFisTipi LEFT OUTER JOIN tbMuhasebeFisi ON tbMuhasebeFisiAciklamasi.dteFisTarihi = tbMuhasebeFisi.dteFisTarihi AND tbMuhasebeFisiAciklamasi.sMuhFisTipi = tbMuhasebeFisi.sMuhFisTipi AND tbMuhasebeFisiAciklamasi.lFisno = tbMuhasebeFisi.lFisno WHERE (tbMuhasebeFisiAciklamasi.dteFisTarihi = '" & dteFisTarihi & "') AND (tbMuhasebeFisiAciklamasi.lFisno = " & lFisNo & ") AND (tbMuhasebeFisiAciklamasi.sMuhFisTipi = " & sMuhFisTipi & ")"
        'cmd.CommandText = "SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SET DATEFORMAT DMY SELECT DISTINCT tbMuhasebeFisiAciklamasi.dteFisTarihi, tbMuhasebeFisiAciklamasi.sMuhFisTipi, tbMuhasebeFisiAciklamasi.dteFisTarihi AS FisTarihi, tbMuhasebeFisiAciklamasi.lFisno, tbMuhasebeFisiAciklamasi.sAciklama1, tbMuhasebeFisiAciklamasi.sAciklama2, tbMuhasebeFisiAciklamasi.sAciklama3, tbMuhasebeFisiAciklamasi.sAciklama4, tbMuhasebeFisiAciklamasi.sAciklama5, tbMuhFisTipi.sAciklama, ISNULL(tbMuhasebeFisi.lYevmiyeNo, 0) AS lYevmiyeNo, ISNULL(tbMuhasebeFisi.sHareketTipi, '') AS sHareketTipi, ISNULL(tbMuhasebeFisi.sSubeMagaza, '') AS sSubeMagaza, ISNULL(tbMuhasebeFisiAciklamasi.bKilitli, 0) AS bKilitli FROM tbMuhasebeFisiAciklamasi INNER JOIN tbMuhFisTipi ON tbMuhasebeFisiAciklamasi.sMuhFisTipi = tbMuhFisTipi.sMuhFisTipi RIGHT OUTER JOIN tbMuhasebeFisi ON tbMuhasebeFisiAciklamasi.dteFisTarihi = tbMuhasebeFisi.dteFisTarihi AND tbMuhasebeFisiAciklamasi.sMuhFisTipi = tbMuhasebeFisi.sMuhFisTipi AND tbMuhasebeFisiAciklamasi.lFisno = tbMuhasebeFisi.lFisno WHERE (tbMuhasebeFisiAciklamasi.dteFisTarihi = '" & dteFisTarihi & "') AND (tbMuhasebeFisiAciklamasi.lFisno = " & lFisNo & ") AND (tbMuhasebeFisiAciklamasi.sMuhFisTipi = " & sMuhFisTipi & ")"
        If PerakendeMi = True Then
            cmd.CommandText = "SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SET DATEFORMAT DMY SELECT DISTINCT tbMuhasebeFisi.dteFisTarihi, tbMuhasebeFisi.sMuhFisTipi, tbMuhasebeFisi.dteFisTarihi AS FisTarihi, tbMuhasebeFisi.lFisno, tbMuhasebeFisi.nEvrakNo, ISNULL(tbMuhasebeFisiAciklamasi.sAciklama1, '') as sAciklama1, ISNULL(tbMuhasebeFisiAciklamasi.sAciklama2, '') as sAciklama2, ISNULL(tbMuhasebeFisiAciklamasi.sAciklama3, '') as sAciklama3, ISNULL(tbMuhasebeFisiAciklamasi.sAciklama4, '') AS sAciklama4, ISNULL(tbMuhasebeFisiAciklamasi.sAciklama5, '') AS sAciklama5, tbMuhFisTipi.sAciklama, ISNULL(tbMuhasebeFisi.lYevmiyeNo, 0) AS lYevmiyeNo, ISNULL(tbMuhasebeFisi.sHareketTipi, '') AS sHareketTipi, ISNULL(tbMuhasebeFisi.sSubeMagaza, '') AS sSubeMagaza, ISNULL(tbMuhasebeFisiAciklamasi.bKilitli, 0) AS bKilitli FROM tbMuhasebeFisiAciklamasi INNER JOIN tbMuhFisTipi ON tbMuhasebeFisiAciklamasi.sMuhFisTipi = tbMuhFisTipi.sMuhFisTipi RIGHT OUTER JOIN tbMuhasebeFisi ON tbMuhasebeFisiAciklamasi.dteFisTarihi = tbMuhasebeFisi.dteFisTarihi AND tbMuhasebeFisiAciklamasi.sMuhFisTipi = tbMuhasebeFisi.sMuhFisTipi AND tbMuhasebeFisiAciklamasi.lFisno = tbMuhasebeFisi.lFisno WHERE (tbMuhasebeFisi.dteFisTarihi = '" & dteFisTarihi & "') AND (tbMuhasebeFisi.nEvrakNo = " & lFisNo & ") AND (tbMuhasebeFisi.sMuhFisTipi = " & sMuhFisTipi & ")"
        Else
            cmd.CommandText = "SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SET DATEFORMAT DMY SELECT DISTINCT tbMuhasebeFisi.dteFisTarihi, tbMuhasebeFisi.sMuhFisTipi, tbMuhasebeFisi.dteFisTarihi AS FisTarihi, tbMuhasebeFisi.lFisno, tbMuhasebeFisi.nEvrakNo, ISNULL(tbMuhasebeFisiAciklamasi.sAciklama1, '') as sAciklama1, ISNULL(tbMuhasebeFisiAciklamasi.sAciklama2, '') as sAciklama2, ISNULL(tbMuhasebeFisiAciklamasi.sAciklama3, '') as sAciklama3, ISNULL(tbMuhasebeFisiAciklamasi.sAciklama4, '') AS sAciklama4, ISNULL(tbMuhasebeFisiAciklamasi.sAciklama5, '') AS sAciklama5, tbMuhFisTipi.sAciklama, ISNULL(tbMuhasebeFisi.lYevmiyeNo, 0) AS lYevmiyeNo, ISNULL(tbMuhasebeFisi.sHareketTipi, '') AS sHareketTipi, ISNULL(tbMuhasebeFisi.sSubeMagaza, '') AS sSubeMagaza, ISNULL(tbMuhasebeFisiAciklamasi.bKilitli, 0) AS bKilitli FROM tbMuhasebeFisiAciklamasi INNER JOIN tbMuhFisTipi ON tbMuhasebeFisiAciklamasi.sMuhFisTipi = tbMuhFisTipi.sMuhFisTipi RIGHT OUTER JOIN tbMuhasebeFisi ON tbMuhasebeFisiAciklamasi.dteFisTarihi = tbMuhasebeFisi.dteFisTarihi AND tbMuhasebeFisiAciklamasi.sMuhFisTipi = tbMuhasebeFisi.sMuhFisTipi AND tbMuhasebeFisiAciklamasi.lFisno = tbMuhasebeFisi.lFisno WHERE (tbMuhasebeFisi.dteFisTarihi = '" & dteFisTarihi & "') AND (tbMuhasebeFisi.lFisno = " & lFisNo & ") AND (tbMuhasebeFisi.sMuhFisTipi = " & sMuhFisTipi & ")"
        End If
        'sorgu_txt_baslik = cmd.CommandText
        cmd.Connection = con
        con.Open()
        Dim DS As New DataSet
        Dim N As Integer = adapter.Fill(DS, "BASLIK")
        con.Close()
        con.Dispose()
        cmd.Dispose()
        con = Nothing
        cmd = Nothing
        Return DS
    End Function
    Private Sub dataload_tbSube()
        ds_tbsube = sorgu(sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT     sSubeMagaza,sAciklama FROM         tbSubeMagaza"))
        sec_sSubeMagaza.DataSource = ds_tbsube.Tables(0)
    End Sub
    Private Sub dataload_tbDovizCinsi()
        ds_tbDovizCinsi = sorgu(sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT     sDovizCinsi,sAciklama FROM         tbDovizCinsi"))
        sec_sDovizCinsi.DataSource = ds_tbDovizCinsi.Tables(0)
    End Sub
    Private Sub dataload_tbHareketTipi()
        ds_tbHareketTipi = sorgu(sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT     CAST(sHareketTipi AS CHAR(4)) AS sHareketTipi, sAciklama FROM         tbHareketTipi where aktif = 1"))
        sec_sHareketTipi.DataSource = ds_tbHareketTipi.Tables(0)
        sec_HareketTipi.DataSource = ds_tbHareketTipi.Tables(0)
    End Sub
    Private Sub dataload_tbMasrafMerkezi()
        ds_tbMasrafMerkezi = sorgu(sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT     sMasrafYontemi,sAciklama FROM         tbMasrafMerkezi"))
        sec_sMasrafMerkezi.DataSource = ds_tbMasrafMerkezi.Tables(0)
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
    Private Sub gorunum_dil_degistir(ByVal dil As String)
        'Fiþi Göster
        Dim esDil As String
        esDil = sDil
        sDil = dil
        Dim frm As New frm_tbMuhasebeFisi
        frm.firmano = firmano
        frm.donemno = donemno
        frm.connection = connection
        frm.dteFisTarihi = dr_baslik("dteFisTarihi")
        frm.lFisNo = dr_baslik("lFisNo")
        frm.lYevmiyeNo = dr_baslik("lYevmiyeNo")
        frm.bMuhasabe = bMuhasabe
        frm.sMuhFisTipi = dr_baslik("sMuhFisTipi")
        frm.kullanici = kullanici
        frm.sModul = sModul
        If yetki_kontrol(kullanici, frm.Name) = True Then
            frm.Show()
        End If
        sDil = esDil
    End Sub
    Private Sub gorunum_kaydet()
        If Trim(sDil) = "TR" Or Trim(sDil) = "" Then
            GridView1.SaveLayoutToRegistry("SOFTWARE\BusinessSmart\VIEW\MAGAZA\" & Me.Name.ToString & "\'" & sMuhFisTipi & "'\" & bMuhasabe & "")
        Else
            GridView1.SaveLayoutToRegistry("SOFTWARE\BusinessSmart\VIEW\MAGAZA\" & Me.Name.ToString & "\'" & sMuhFisTipi & "'\" & sDil & "\" & bMuhasabe & "")
        End If
        XtraMessageBox.Show(Sorgu_sDil("Görünüm Kaydedildi", sDil), Sorgu_sDil("Dikkat", sDil), MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub
    Private Sub gorunum_yukle()
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
        Dim row
        For Each row In categoryTanýmlar.ChildRows
            Try
                row.Properties.Caption = Sorgu_sDil(row.Properties.Caption, sDil)
            Catch ex As Exception
            End Try
        Next
        For Each row In categoryNotlar.ChildRows
            Try
                row.Properties.Caption = Sorgu_sDil(row.Properties.Caption, sDil)
            Catch ex As Exception
            End Try
        Next
        For Each row In VGrid_Fima.Rows
            Try
                row.Properties.Caption = Sorgu_sDil(row.Properties.Caption, sDil)
            Catch ex As Exception
            End Try
        Next
        For Each row In VGrid_Muhasebe.Rows
            Try
                row.Properties.Caption = Sorgu_sDil(row.Properties.Caption, sDil)
            Catch ex As Exception
            End Try
        Next
        For Each row In VGrid_Toplam.Rows
            Try
                row.Properties.Caption = Sorgu_sDil(row.Properties.Caption, sDil)
            Catch ex As Exception
            End Try
        Next
        For Each row In VGrid_Baslik.Rows
            Try
                row.Properties.Caption = Sorgu_sDil(row.Properties.Caption, sDil)
            Catch ex As Exception
            End Try
        Next
        Group_Yekun.Text = Sorgu_sDil(Group_Yekun.Text, sDil)
        Group_Cari.Text = Sorgu_sDil(Group_Cari.Text, sDil)
        Group_Muhasebe.Text = Sorgu_sDil(Group_Muhasebe.Text, sDil)
        If Trim(sDil) = "TR" Or Trim(sDil) = "" Then
            GridView1.RestoreLayoutFromRegistry("SOFTWARE\BusinessSmart\VIEW\MAGAZA\" & Me.Name.ToString & "\'" & sMuhFisTipi & "'\" & bMuhasabe & "")
        Else
            GridView1.RestoreLayoutFromRegistry("SOFTWARE\BusinessSmart\VIEW\MAGAZA\" & Me.Name.ToString & "\'" & sMuhFisTipi & "'\" & sDil & "\" & bMuhasabe & "")
        End If
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
                status = True
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
    Public Function sorgu_nMuhasebeFisiAciklamasiKaydi(ByVal dteFisTarihi As DateTime, ByVal sMuhFisTipi As Integer, ByVal lFisNo As Int64) As Int64
        Dim kriter As String = ""
        'kriter = "WHERE (sKodu = '" & kod & "')  "
        Dim conn As New OleDb.OleDbConnection
        Dim cmd As New OleDb.OleDbCommand
        Dim adapter As New OleDb.OleDbDataAdapter
        'MsgBox(connection_resmi)
        conn.ConnectionString = connection
        cmd.Connection = conn
        conn.Open()
        If PerakendeMi = True Then
            cmd.CommandText = sorgu_query("SET DATEFORMAT DMY SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT ISNULL(COUNT(*), 0) AS nKayit FROM tbMuhasebeFisiAciklamasi WHERE (dteFisTarihi = '" & dteFisTarihi & "') AND (sMuhFisTipi = " & sMuhFisTipi & ") AND (lFisno = (Select top 1 lFisNo From tbMuhasebeFisi where nEvrakNo = " & lFisNo & "))")
        Else
            cmd.CommandText = sorgu_query("SET DATEFORMAT DMY SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT ISNULL(COUNT(*), 0) AS nKayit FROM tbMuhasebeFisiAciklamasi WHERE (dteFisTarihi = '" & dteFisTarihi & "') AND (sMuhFisTipi = " & sMuhFisTipi & ") AND (lFisno = " & lFisNo & ")")
        End If
        Dim kayitsayisi = cmd.ExecuteScalar
        Return kayitsayisi
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
    Public Function sorgu_nKasaHesapID() As Int64
        Dim kriter As String = ""
        'kriter = "WHERE (sKodu = '" & kod & "')  "
        Dim conn As New OleDb.OleDbConnection
        Dim cmd As New OleDb.OleDbCommand
        Dim adapter As New OleDb.OleDbDataAdapter
        'MsgBox(connection_resmi)
        conn.ConnectionString = connection
        cmd.Connection = conn
        conn.Open()
        cmd.CommandText = sorgu_query("SET DATEFORMAT DMY SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT     TOP 1 ISNULL(nHesapID, 0) AS nHesapID  FROM         tbHesapPlani Where sKodu ='100'")
        Dim kayitsayisi = cmd.ExecuteScalar
        Return kayitsayisi
    End Function
    Public Function sorgu_nFisSiraID() As Int64
        'Dim kriter As String = ""
        ''kriter = "WHERE (sKodu = '" & kod & "')  "
        'Dim conn As New OleDb.OleDbConnection
        'Dim cmd As New OleDb.OleDbCommand
        'Dim adapter As New OleDb.OleDbDataAdapter
        ''MsgBox(connection_resmi)
        'conn.ConnectionString = connection
        'cmd.Connection = conn
        'conn.Open()
        'cmd.CommandText = sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT     TOP 1 ISNULL(nFisSiraID + 1, 1) AS nFisSiraID FROM         tbMuhasebeFisi ORDER BY nFisSiraID DESC")
        'Dim kayitsayisi = cmd.ExecuteScalar
        'Return kayitsayisi
        Return 1
    End Function
    Public Function sorgu_lFisNo() As Int64
        Dim kriter As String = ""
        'kriter = "WHERE (sKodu = '" & kod & "')  "
        Dim conn As New OleDb.OleDbConnection
        Dim cmd As New OleDb.OleDbCommand
        Dim adapter As New OleDb.OleDbDataAdapter
        'MsgBox(connection_resmi)
        conn.ConnectionString = connection
        cmd.Connection = conn
        conn.Open()
        cmd.CommandText = sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT     ISNULL(lSonMahsupNo1, 1) AS lFisNo FROM         tbMuhasebeFisNo")
        Dim kayitsayisi = cmd.ExecuteScalar
        If kayitsayisi = 1 Then
            kayitsayisi = 2
        End If
        Return kayitsayisi
    End Function
    Public Function sorgu_lBakiye(ByVal dteFisTarihi As DateTime, ByVal sMuhFisTipi As Integer, ByVal lFisNo As Int64) As Decimal
        Dim kriter As String = ""
        'kriter = "WHERE (sKodu = '" & kod & "')  "
        Dim conn As New OleDb.OleDbConnection
        Dim cmd As New OleDb.OleDbCommand
        Dim adapter As New OleDb.OleDbDataAdapter
        'MsgBox(connection_resmi)
        conn.ConnectionString = connection
        cmd.Connection = conn
        conn.Open()
        cmd.CommandText = sorgu_query("SET DATEFORMAT DMY SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT     ISNULL(SUM(lBorcTutar - lAlacakTutar),0) AS lBakiye FROM         tbMuhasebeFisi WHERE (dteFisTarihi = '" & dteFisTarihi & "') AND (sMuhFisTipi = " & sMuhFisTipi & ") AND (lFisno = " & lFisNo & ")")
        Dim kayitsayisi = cmd.ExecuteScalar
        Return kayitsayisi
    End Function
    Public Function sorgu_lBorcTutar(ByVal dteFisTarihi As DateTime, ByVal sMuhFisTipi As Integer, ByVal lFisNo As Int64) As Decimal
        Dim kriter As String = ""
        'kriter = "WHERE (sKodu = '" & kod & "')  "
        Dim conn As New OleDb.OleDbConnection
        Dim cmd As New OleDb.OleDbCommand
        Dim adapter As New OleDb.OleDbDataAdapter
        'MsgBox(connection_resmi)
        conn.ConnectionString = connection
        cmd.Connection = conn
        conn.Open()
        cmd.CommandText = sorgu_query("SET DATEFORMAT DMY SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT     ISNULL(SUM(lBorcTutar ),0) AS lBakiye FROM         tbMuhasebeFisi WHERE (dteFisTarihi = '" & dteFisTarihi & "') AND (sMuhFisTipi = " & sMuhFisTipi & ") AND (lFisno = " & lFisNo & ")")
        Dim kayitsayisi = cmd.ExecuteScalar
        Return kayitsayisi
    End Function
    Public Function sorgu_lAlacakTutar(ByVal dteFisTarihi As DateTime, ByVal sMuhFisTipi As Integer, ByVal lFisNo As Int64) As Decimal
        Dim kriter As String = ""
        'kriter = "WHERE (sKodu = '" & kod & "')  "
        Dim conn As New OleDb.OleDbConnection
        Dim cmd As New OleDb.OleDbCommand
        Dim adapter As New OleDb.OleDbDataAdapter
        'MsgBox(connection_resmi)
        conn.ConnectionString = connection
        cmd.Connection = conn
        conn.Open()
        cmd.CommandText = sorgu_query("SET DATEFORMAT DMY SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT     ISNULL(SUM(lAlacakTutar),0) AS lBakiye FROM         tbMuhasebeFisi WHERE (dteFisTarihi = '" & dteFisTarihi & "') AND (sMuhFisTipi = " & sMuhFisTipi & ") AND (lFisno = " & lFisNo & ")")
        Dim kayitsayisi = cmd.ExecuteScalar
        Return kayitsayisi
    End Function
    Public Sub Dataload_tbMuhasebeFisi(ByVal dteFisTarihi As DateTime, ByVal sMuhFisTipi As Integer, ByVal lFisNo As Int64)
        status = True
        Try
            ds_tbMuhasebeFisi.Tables(0).Clear()
        Catch ex As Exception
        End Try
        Dim conn As New OleDb.OleDbConnection
        Dim cmd As New OleDb.OleDbCommand
        Dim adapter As New OleDb.OleDbDataAdapter
        conn.ConnectionString = connection
        adapter.SelectCommand = cmd
        'cmd.CommandText = sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT tbMuhasebeFisi.*, tbFirma.nFirmaID as nFirmaID,tbFirma.sKodu AS sFirmaKodu, tbFirma.sAciklama AS sFirmaAciklama, tbHesapPlani.sKodu AS sHesapKodu, tbHesapPlani.sAciklama AS sHesapAciklama, tbFirmaHareketi.dteValorTarihi AS dteValorTarihi, tbFirmaHareketi.sCariIslem AS sCariIslem, tbFirmaHareketi.sEvrakNo AS sEvrakNo FROM tbMuhasebeFisi INNER JOIN tbFirma ON tbMuhasebeFisi.nHesapID = tbFirma.nHesapID INNER JOIN tbHesapPlani ON tbMuhasebeFisi.nHesapID = tbHesapPlani.nHesapID INNER JOIN tbFirmaHareketi ON tbMuhasebeFisi.nCariHareketID = tbFirmaHareketi.nHareketID WHERE (tbMuhasebeFisi.sMuhFisTipi = " & sMuhFisTipi & ") AND (tbMuhasebeFisi.lFisno = " & lFisNo & ") AND (tbMuhasebeFisi.dteFisTarihi = '" & dteFisTarihi & "') ORDER BY nFisSiraID")
        cmd.CommandText = sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT tbMuhasebeFisi.*, tbFirma.nFirmaID AS nFirmaID, tbFirma.sKodu AS sFirmaKodu, tbFirma.sAciklama AS sFirmaAciklama, tbHesapPlani.sKodu AS sHesapKodu, tbHesapPlani.sAciklama AS sHesapAciklama, tbFirmaHareketi.dteValorTarihi AS dteValorTarihi, tbFirmaHareketi.sCariIslem AS sCariIslem, tbFirmaHareketi.sEvrakNo AS sEvrakNo,DATEDIFF(day, tbMuhasebeFisi.dteFisTarihi,tbFirmaHareketi.dteValorTarihi) AS nOpsiyon FROM tbMuhasebeFisi INNER JOIN tbHesapPlani ON tbMuhasebeFisi.nHesapID = tbHesapPlani.nHesapID LEFT OUTER JOIN tbFirmaHareketi ON tbMuhasebeFisi.nCariHareketID = tbFirmaHareketi.nHareketID LEFT OUTER JOIN tbFirma ON tbMuhasebeFisi.nHesapID = tbFirma.nHesapID WHERE (tbMuhasebeFisi.sMuhFisTipi = " & sMuhFisTipi & ") AND (tbMuhasebeFisi.lFisno = " & lFisNo & ") AND (tbMuhasebeFisi.dteFisTarihi = '" & dteFisTarihi & "') ORDER BY tbMuhasebeFisi.nFisSiraID,tbMuhasebeFisi.nSatir")
        sSorguHareket = cmd.CommandText
        cmd.Connection = conn
        conn.Open()
        Dim N As Integer = adapter.Fill(ds_tbMuhasebeFisi, "Hareket")
        conn.Close()
        Dataload_tbYekun(dr_baslik("dteFisTarihi"), dr_baslik("sMuhFisTipi"), dr_baslik("lFisNo"))
        If GridView1.RowCount > 0 Then
            GridView1.ClearSelection()
            GridView1.SelectRow(GridView1.RowCount - 1)
            PanelControl3.Focus()
            GridControl1.Focus()
        End If
        If ds_tbMuhasebeFisi.Tables(0).Rows.Count > 0 Then
            If sorgu_sAciklama_kontrol(dr_baslik("dteFisTarihi"), dr_baslik("sMuhFisTipi"), dr_baslik("lFisNo")) = True Then
                tbMuhasebeFisi_Aciklamasi_kaydet_yeni(dr_baslik("dteFisTarihi"), dr_baslik("sMuhFisTipi"), dr_baslik("lFisNo"), "", "", "", "", "", 0)
            End If
            dr_baslik("sHareketTipi") = sorgu_sHareketTipi_kontrol(dr_baslik("dteFisTarihi"), dr_baslik("sMuhFisTipi"), dr_baslik("lFisNo"))
            dr_baslik("sSubeMagaza") = sorgu_sSubeMagaza_kontrol(dr_baslik("dteFisTarihi"), dr_baslik("sMuhFisTipi"), dr_baslik("lFisNo"))
        End If
        status = False
        satir_kontrol()
    End Sub
    Public Sub Dataload_tbYekun(ByVal dteFisTarihi As DateTime, ByVal sMuhFisTipi As String, ByVal lFisNo As Int64)
        Try
            ds_tbMuhasebeFisiToplam.Tables(0).Clear()
        Catch ex As Exception
        End Try
        Dim conn As New OleDb.OleDbConnection
        Dim cmd As New OleDb.OleDbCommand
        Dim adapter As New OleDb.OleDbDataAdapter
        conn.ConnectionString = connection
        adapter.SelectCommand = cmd
        cmd.CommandText = sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT '" & Sorgu_sDil("MuhasebeFiþiYekun", sDil) & "' AS sAciklama, SUM(lBorcTutar) AS lBorcTutar, SUM(lAlacakTutar) AS lAlacakTutar, SUM(lBorcTutar - lAlacakTutar) AS lBakiye, SUM(lGirenMiktar) AS lGirenMiktar, SUM(lCikanMiktar) AS lCikanMiktar, SUM(lGirenMiktar - lCikanMiktar) AS lKalan FROM tbMuhasebeFisi WHERE (sMuhFisTipi = " & sMuhFisTipi & ") AND (lFisno = " & lFisNo & ") AND (dteFisTarihi = '" & dteFisTarihi & "') ")
        cmd.Connection = conn
        conn.Open()
        Dim N As Integer = adapter.Fill(ds_tbMuhasebeFisiToplam, "Toplam")
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
        'cmd.CommandText = sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT nFirmaID, sKodu, sAciklama, nOzelIskontosu, lKrediLimiti, nVadeGun, nHesapID, (SELECT ISNULL(SUM(lBorcTutar) , 0) AS lBorcTutar FROM tbFirmaHareketi WHERE nFirmaID = tbFirma.nFirmaID) AS lBorcTutar, (SELECT ISNULL(SUM(lAlacakTutar) , 0) AS lAlacakTutar FROM tbFirmaHareketi WHERE nFirmaID = tbFirma.nFirmaID) AS lAlacakTutar, (SELECT ISNULL(SUM(lBorcTutar - lAlacakTutar) , 0) AS lBakiye FROM tbFirmaHareketi WHERE nFirmaID = tbFirma.nFirmaID) AS lBakiye, (SELECT ISNULL(SUM(lTutar) , 0) AS Expr1 FROM tbCekSenet WHERE (nVerenID = tbFirma.nFirmaID) AND (sCekSenetTipi = 'AC' OR sCekSenetTipi = 'AS') AND (nSonCekSenetIslem <= 6) AND (nSonCekSenetIslem <> 2)) AS lRisk FROM tbFirma WHERE (sKodu = '" & sFirmaKodu & "') ")
        cmd.CommandText = sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT nFirmaID, sKodu, sAciklama, nOzelIskontosu, lKrediLimiti, nVadeGun, nHesapID, sDovizCinsi,lBorcTutar = CASE WHEN tbFirma.sDovizCinsi = '   ' THEN (SELECT ISNULL(SUM(lBorcTutar ), 0) AS lBorcTutar FROM tbFirmaHareketi WHERE nFirmaID = tbFirma.nFirmaID) ELSE (SELECT ISNULL(SUM((lBorcTutar )/lDovizKuru1) , 0) AS lBorcTutar FROM tbFirmaHareketi WHERE nFirmaID = tbFirma.nFirmaID AND sDovizCinsi1 = tbFirma.sDovizCinsi) END, lAlacakTutar = CASE WHEN tbFirma.sDovizCinsi = '   ' THEN (SELECT ISNULL(SUM(lAlacakTutar), 0) AS lAlacakTutar FROM tbFirmaHareketi WHERE nFirmaID = tbFirma.nFirmaID) ELSE (SELECT ISNULL(SUM((lAlacakTutar)/lDovizKuru1) , 0) AS lAlacakTutar FROM tbFirmaHareketi WHERE nFirmaID = tbFirma.nFirmaID AND sDovizCinsi1 = tbFirma.sDovizCinsi) END, lBakiye = CASE WHEN tbFirma.sDovizCinsi = '   ' THEN (SELECT ISNULL(SUM(lBorcTutar - lAlacakTutar), 0) AS lBakiye FROM tbFirmaHareketi WHERE nFirmaID = tbFirma.nFirmaID) ELSE (SELECT ISNULL(SUM((lBorcTutar - lAlacakTutar)/lDovizKuru1) , 0) AS lBakiye FROM tbFirmaHareketi WHERE nFirmaID = tbFirma.nFirmaID AND sDovizCinsi1 = tbFirma.sDovizCinsi) END, (SELECT ISNULL(SUM(lTutar) , 0) AS Expr1 FROM tbCekSenet WHERE (nVerenID = tbFirma.nFirmaID) AND (sCekSenetTipi = 'AC' OR sCekSenetTipi = 'AS') AND (nSonCekSenetIslem <= 6) AND (nSonCekSenetIslem <> 2)) AS lRisk FROM tbFirma WHERE (sKodu = '" & sFirmaKodu & "') ")
        cmd.Connection = conn
        conn.Open()
        Dim N As Integer = adapter.Fill(ds_tbFirma, "Table1")
        conn.Close()
    End Sub
    Public Sub Dataload_tbHesap(ByVal nHesapID As String)
        Try
            ds_tbHesapPlani.Tables(0).Clear()
        Catch ex As Exception
        End Try
        Dim conn As New OleDb.OleDbConnection
        Dim cmd As New OleDb.OleDbCommand
        Dim adapter As New OleDb.OleDbDataAdapter
        conn.ConnectionString = connection
        adapter.SelectCommand = cmd
        cmd.CommandText = sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT tbHesapPlani.nHesapID, tbHesapPlani.sKodu, tbHesapPlani.sAciklama, ISNULL(SUM(tbMuhasebeFisi.lBorcTutar), 0) AS lBorcTutar, ISNULL(SUM(tbMuhasebeFisi.lAlacakTutar), 0) AS lAlacakTutar, ISNULL(SUM(tbMuhasebeFisi.lBorcTutar - tbMuhasebeFisi.lAlacakTutar), 0) AS lBakiye, ISNULL(SUM(tbMuhasebeFisi.lGirenMiktar), 0) AS lGirenMiktar, ISNULL(SUM(tbMuhasebeFisi.lCikanMiktar), 0) AS lCikanMiktar, ISNULL(SUM(tbMuhasebeFisi.lGirenMiktar - tbMuhasebeFisi.lCikanMiktar), 0) AS lKalan FROM tbMuhasebeFisi WITH (INDEX (tbMuhasebeFisi_index2)) INNER JOIN tbHesapPlani ON tbMuhasebeFisi.nHesapID = tbHesapPlani.nHesapID WHERE (tbMuhasebeFisi.nHesapID = " & nHesapID & ") GROUP BY tbHesapPlani.nHesapID, tbHesapPlani.sKodu, tbHesapPlani.sAciklama ")
        cmd.Connection = conn
        conn.Open()
        Dim N As Integer = adapter.Fill(ds_tbHesapPlani, "Table1")
        conn.Close()
    End Sub
    Public Function sorgu_sAciklama_kontrol(ByVal dteFisTarihi As DateTime, ByVal sMuhFisTipi As String, ByVal lFisNo As Int64) As Boolean
        Dim kriter
        Dim pass As Boolean
        kriter = ""
        Dim conn As New OleDb.OleDbConnection
        Dim cmd As New OleDb.OleDbCommand
        Dim adapter As New OleDb.OleDbDataAdapter
        conn.ConnectionString = connection
        cmd.Connection = conn
        conn.Open()
        cmd.CommandText = sorgu_query("SET DATEFORMAT DMY SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT ISNULL(COUNT(*),0) AS nKayit FROM tbMuhasebeFisiAciklamasi WHERE (dteFisTarihi = '" & dteFisTarihi & "') AND (sMuhFisTipi = " & sMuhFisTipi & ") AND (lFisno = " & lFisNo & ")")
        Dim kayitsayisi = cmd.ExecuteScalar
        If kayitsayisi = 0 Then
            pass = True
        Else
            pass = False
        End If
        Return pass
    End Function
    Public Function sorgu_sHareketTipi_kontrol(ByVal dteFisTarihi As DateTime, ByVal sMuhFisTipi As String, ByVal lFisNo As Int64) As String
        Dim kriter
        kriter = ""
        Dim conn As New OleDb.OleDbConnection
        Dim cmd As New OleDb.OleDbCommand
        Dim adapter As New OleDb.OleDbDataAdapter
        conn.ConnectionString = connection
        cmd.Connection = conn
        conn.Open()
        cmd.CommandText = sorgu_query("SET DATEFORMAT DMY SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT DISTINCT ISNULL(sHareketTipi,'') as sHareketTipi FROM         tbMuhasebeFisi WHERE (dteFisTarihi = '" & dteFisTarihi & "') AND (sMuhFisTipi = " & sMuhFisTipi & ") AND (lFisno = " & lFisNo & ")")
        Dim kayitsayisi = cmd.ExecuteScalar
        Return kayitsayisi
    End Function
    Public Function sorgu_sSubeMagaza_kontrol(ByVal dteFisTarihi As DateTime, ByVal sMuhFisTipi As String, ByVal lFisNo As Int64) As String
        Dim kriter
        kriter = ""
        Dim conn As New OleDb.OleDbConnection
        Dim cmd As New OleDb.OleDbCommand
        Dim adapter As New OleDb.OleDbDataAdapter
        conn.ConnectionString = connection
        cmd.Connection = conn
        conn.Open()
        cmd.CommandText = sorgu_query("SET DATEFORMAT DMY SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT DISTINCT ISNULL(sSubeMagaza,'') as sSubeMagaza FROM         tbMuhasebeFisi WHERE (dteFisTarihi = '" & dteFisTarihi & "') AND (sMuhFisTipi = " & sMuhFisTipi & ") AND (lFisno = " & lFisNo & ")")
        Dim kayitsayisi = cmd.ExecuteScalar
        Return kayitsayisi
    End Function
    Private Function tbMuhasebeFisi_kaydet_yeni(ByVal nFisSiraID As String, ByVal dteFisTarihi As DateTime, ByVal sMuhFisTipi As Integer, ByVal lFisno As Int64, ByVal lYevmiyeNo As Int64, ByVal nHesapID As Int64, ByVal sAciklama As String, ByVal lGirenMiktar As Decimal, ByVal lCikanMiktar As Decimal, ByVal lBorcTutar As Decimal, ByVal lAlacakTutar As Decimal, ByVal sMasrafYontemi As String, ByVal nKasaID As Int64, ByVal sHangiUygulama As String, ByVal sHareketTipi As String, ByVal nCariHareketID As Int64, ByVal sKullaniciAdi As String, ByVal dteKayitTarihi As DateTime, ByVal sDovizCinsi1 As String, ByVal lDovizMiktari1 As Decimal, ByVal lDovizKuru1 As Decimal, ByVal sDovizCinsi2 As String, ByVal lDovizMiktari2 As Decimal, ByVal lDovizKuru2 As Decimal, ByVal nSatir As Int64, ByVal sSubeMagaza As String, ByVal sSonKullaniciAdi As String, ByVal dteSonUpdateTarihi As DateTime) As Int64
        Dim con As New OleDb.OleDbConnection
        Dim cmd As New OleDb.OleDbCommand
        cmd.Connection = con
        con.ConnectionString = connection
        If con.State = ConnectionState.Closed = True Then
            con.Open()
        End If
        cmd.CommandText = sorgu_query("SET DATEFORMAT DMY SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED INSERT INTO tbMuhasebeFisi ( dteFisTarihi, sMuhFisTipi, lFisno, lYevmiyeNo, nHesapID, sAciklama, lGirenMiktar, lCikanMiktar, lBorcTutar, lAlacakTutar,sMasrafYontemi, nKasaID, sHangiUygulama, sHareketTipi, nCariHareketID, sKullaniciAdi, dteKayitTarihi, sDovizCinsi1, lDovizMiktari1, lDovizKuru1, sDovizCinsi2, lDovizMiktari2, lDovizKuru2, nSatir, sSubeMagaza, sSonKullaniciAdi, dteSonUpdateTarihi, nEvrakNo) VALUES     ( '" & dteFisTarihi & "', '" & sMuhFisTipi & "', " & lFisno & ", " & lYevmiyeNo & ", " & nHesapID & ", N'" & sAciklama & "', " & lGirenMiktar & ", " & lCikanMiktar & ", " & lBorcTutar & ", " & lAlacakTutar & ", '" & sMasrafYontemi & "', " & nKasaID & ", '" & sHangiUygulama & "', '" & sHareketTipi & "', " & nCariHareketID & ", '" & sKullaniciAdi & "', '" & dteKayitTarihi & "', '" & sDovizCinsi1 & "', " & lDovizMiktari1 & ", " & lDovizKuru1 & ", '" & sDovizCinsi2 & "', " & lDovizMiktari2 & ", " & lDovizKuru2 & ", " & nSatir & ", '" & sSubeMagaza & "', '" & sSonKullaniciAdi & "', '" & dteSonUpdateTarihi & "', " & lFisno & ")")
        cmd.ExecuteNonQuery()
        cmd.CommandText = "SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT @@identity"
        nFisSiraID = cmd.ExecuteScalar
        Return nFisSiraID
        con.Close()
    End Function
    Private Sub tbMuhasebeFisi_kaydet_duzelt(ByVal nFisSiraID As String, ByVal dteFisTarihi As DateTime, ByVal sMuhFisTipi As Integer, ByVal lFisno As Int64, ByVal lYevmiyeNo As Int64, ByVal nHesapID As Int64, ByVal sAciklama As String, ByVal lGirenMiktar As Decimal, ByVal lCikanMiktar As Decimal, ByVal lBorcTutar As Decimal, ByVal lAlacakTutar As Decimal, ByVal sMasrafYontemi As String, ByVal nKasaID As Int64, ByVal sHangiUygulama As String, ByVal sHareketTipi As String, ByVal nCariHareketID As Int64, ByVal sKullaniciAdi As String, ByVal dteKayitTarihi As DateTime, ByVal sDovizCinsi1 As String, ByVal lDovizMiktari1 As Decimal, ByVal lDovizKuru1 As Decimal, ByVal sDovizCinsi2 As String, ByVal lDovizMiktari2 As Decimal, ByVal lDovizKuru2 As Decimal, ByVal nSatir As Int64, ByVal sSubeMagaza As String, ByVal sSonKullaniciAdi As String, ByVal dteSonUpdateTarihi As DateTime)
        Dim con As New OleDb.OleDbConnection
        Dim cmd As New OleDb.OleDbCommand
        cmd.Connection = con
        con.ConnectionString = connection
        If con.State = ConnectionState.Closed = True Then
            con.Open()
        End If
        cmd.CommandText = sorgu_query("SET DATEFORMAT DMY SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED UPDATE    tbMuhasebeFisi SET              dteFisTarihi ='" & dteFisTarihi & "',sAciklama = N'" & sAciklama & "', lGirenMiktar = " & lGirenMiktar & ", lCikanMiktar = " & lCikanMiktar & ", lBorcTutar = " & lBorcTutar & ", lAlacakTutar = " & lAlacakTutar & ", sMasrafYontemi = '" & sMasrafYontemi & "', nKasaID = " & nKasaID & ", sHareketTipi = '" & sHareketTipi & "', sDovizCinsi1 = '" & sDovizCinsi1 & "', lDovizMiktari1 = " & lDovizMiktari1 & ", lDovizKuru1 = " & lDovizKuru1 & ", sDovizCinsi2 = '" & sDovizCinsi2 & "', lDovizMiktari2 = " & lDovizMiktari2 & ", lDovizKuru2 = " & lDovizKuru2 & ", nSatir = " & nSatir & ", sSubeMagaza = '" & sSubeMagaza & "', sSonKullaniciAdi = '" & sSonKullaniciAdi & "', dteSonUpdateTarihi = '" & dteSonUpdateTarihi & "',nHesapID =" & nHesapID & " Where nFisSiraID = " & nFisSiraID & "")
        cmd.ExecuteNonQuery()
        con.Close()
    End Sub
    Private Sub tbMuhasebeFisi_satir_kaydet_duzelt(ByVal nFisSiraID As String, ByVal nSatir As Int64)
        Dim con As New OleDb.OleDbConnection
        Dim cmd As New OleDb.OleDbCommand
        cmd.Connection = con
        con.ConnectionString = connection
        If con.State = ConnectionState.Closed = True Then
            con.Open()
        End If
        cmd.CommandText = sorgu_query("SET DATEFORMAT DMY SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED UPDATE    tbMuhasebeFisi SET               nSatir = " & nSatir & " Where nFisSiraID = " & nFisSiraID & "")
        cmd.ExecuteNonQuery()
        con.Close()
    End Sub
    Private Sub tbMuhasebeFisi_kaydet_sil(ByVal nFisSiraID As String, ByVal nCariHareketID As String)
        Dim con As New OleDb.OleDbConnection
        Dim cmd As New OleDb.OleDbCommand
        cmd.Connection = con
        con.ConnectionString = connection
        cmd.CommandTimeout = Nothing
        If con.State = ConnectionState.Closed = True Then
            con.Open()
        End If
        cmd.CommandText = sorgu_query("set implicit_transactions on")
        cmd.ExecuteNonQuery()
        Try
            cmd.CommandText = sorgu_query("SET DATEFORMAT DMY SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED ")
            cmd.ExecuteNonQuery()
            cmd.CommandText = sorgu_query("DELETE FROM tbMuhasebeFisi Where nFisSiraID = '" & nFisSiraID & "'")
            cmd.ExecuteNonQuery()
            If bMuhasabe = False Then
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
        cmd.CommandText = sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED UPDATE tbMuhasebeSiraNo SET nSonID = ISNULL((SELECT TOP 1 ISNULL(nFisSiraID + 1 , 1) AS nSonID FROM tbMuhasebeFisi ORDER BY nFisSiraID DESC),1) WHERE (nSiraIndex = 1)")
        cmd.ExecuteNonQuery()
        cmd.CommandText = sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED UPDATE tbCariSiraNo SET nSonID = ISNULL((SELECT TOP 1 ISNULL(nHareketID + 1 , 1) AS nSonID FROM tbFirmaHareketi ORDER BY nHareketID DESC),1) WHERE (nSiraIndex = 1)")
        cmd.ExecuteNonQuery()
        con.Close()
    End Sub
    Private Sub tbMuhasebeFisi_sil(ByVal dteFisTarihi As DateTime, ByVal sMuhFisTipi As String, ByVal lFisno As Int64)
        Dim con As New OleDb.OleDbConnection
        Dim cmd As New OleDb.OleDbCommand
        cmd.Connection = con
        cmd.CommandTimeout = Nothing
        con.ConnectionString = connection
        If con.State = ConnectionState.Closed = True Then
            con.Open()
        End If
        cmd.CommandText = sorgu_query("set implicit_transactions on")
        cmd.ExecuteNonQuery()
        Try
            cmd.CommandText = sorgu_query("SET DATEFORMAT DMY SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED ")
            cmd.ExecuteNonQuery()
            cmd.CommandText = sorgu_query("delete tbFirmaHareketi  from tbMuhasebeFisi, tbFirmaHareketi where nHareketID=nCariHareketID and   ( nCariHareketID is not null and nCariHareketID <> 0 ) and    dtefisTarihi = '" & dteFisTarihi & "' and    sMuhFisTipi = '" & sMuhFisTipi & "' and         lFisNo = " & lFisno & "")
            cmd.ExecuteNonQuery()
            cmd.CommandText = sorgu_query("delete from tbMuhasebeFisi where dtefisTarihi = '" & dteFisTarihi & "' and    sMuhFisTipi = '" & sMuhFisTipi & "' and         lFisNo = " & lFisno & "")
            cmd.ExecuteNonQuery()
            cmd.CommandText = sorgu_query("delete from tbMuhasebeFisiAciklamasi where dtefisTarihi = '" & dteFisTarihi & "' and    sMuhFisTipi = '" & sMuhFisTipi & "' and         lFisNo = " & lFisno & "")
            cmd.ExecuteNonQuery()
            cmd.CommandText = sorgu_query("IF @@TRANCOUNT > 0 COMMIT TRAN")
            cmd.ExecuteNonQuery()
        Catch ex As Exception
            cmd.CommandText = sorgu_query("IF @@TRANCOUNT > 0 COMMIT TRAN")
            cmd.ExecuteNonQuery()
            XtraMessageBox.Show(Sorgu_sDil("Ýþlem Hatasý Lütfen Tekrar Deneyiniz...!", sDil), Sorgu_sDil("Dikkat", sDil), MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End Try
        cmd.CommandText = sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED UPDATE tbMuhasebeSiraNo SET nSonID = ISNULL((SELECT TOP 1 ISNULL(nFisSiraID + 1 , 1) AS nSonID FROM tbMuhasebeFisi ORDER BY nFisSiraID DESC),1) WHERE (nSiraIndex = 1)")
        cmd.ExecuteNonQuery()
        cmd.CommandText = sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED UPDATE tbCariSiraNo SET nSonID = ISNULL((SELECT TOP 1 ISNULL(nHareketID + 1 , 1) AS nSonID FROM tbFirmaHareketi ORDER BY nHareketID DESC),1) WHERE (nSiraIndex = 1)")
        cmd.ExecuteNonQuery()
        con.Close()
    End Sub
    Private Sub tbMuhasebeFisi_Aciklamasi_kaydet_yeni(ByVal dteFisTarihi As DateTime, ByVal sMuhFisTipi As String, ByVal lFisno As Int64, ByVal sAciklama1 As String, ByVal sAciklama2 As String, ByVal sAciklama3 As String, ByVal sAciklama4 As String, ByVal sAciklama5 As String, ByVal bKilitli As Byte)
        Dim con As New OleDb.OleDbConnection
        Dim cmd As New OleDb.OleDbCommand
        cmd.Connection = con
        con.ConnectionString = connection
        If con.State = ConnectionState.Closed = True Then
            con.Open()
        End If
        cmd.CommandText = sorgu_query("SET DATEFORMAT DMY INSERT INTO tbMuhasebeFisiAciklamasi(dteFisTarihi, sMuhFisTipi, lFisno, sAciklama1, sAciklama2, sAciklama3, sAciklama4, sAciklama5, bKilitli) VALUES('" & dteFisTarihi & "', '" & sMuhFisTipi & "', " & lFisno & ", '" & sAciklama1 & "', '" & sAciklama2 & "', '" & sAciklama3 & "', '" & sAciklama4 & "', '" & sAciklama5 & "'," & bKilitli & ")")
        cmd.ExecuteNonQuery()
        con.Close()
    End Sub
    Private Sub tbMuhasebeFisi_Aciklamasi_kaydet_duzelt(ByVal dteFisTarihi As DateTime, ByVal sMuhFisTipi As String, ByVal lFisno As Int64, ByVal sAciklama1 As String, ByVal sAciklama2 As String, ByVal sAciklama3 As String, ByVal sAciklama4 As String, ByVal sAciklama5 As String, ByVal FisTarihi As DateTime, ByVal bKilitli As Byte)
        Dim con As New OleDb.OleDbConnection
        Dim cmd As New OleDb.OleDbCommand
        cmd.Connection = con
        con.ConnectionString = connection
        If con.State = ConnectionState.Closed = True Then
            con.Open()
        End If
        If dteFisTarihi <> FisTarihi Then
            cmd.CommandText = sorgu_query("SET DATEFORMAT DMY  UPDATE    tbMuhasebeFisiAciklamasi SET              dteFisTarihi='" & dteFisTarihi & "',sAciklama1 = '" & sAciklama1 & "', sAciklama2 = '" & sAciklama2 & "' , sAciklama3 = '" & sAciklama3 & "',  sAciklama4 = '" & sAciklama4 & "', sAciklama5 = '" & sAciklama5 & "',bKilitli =" & bKilitli & " where dteFisTarihi = '" & FisTarihi & "'  and sMuhFisTipi = '" & sMuhFisTipi & "' AND lFisno = " & lFisno & " ")
        Else
            cmd.CommandText = sorgu_query("SET DATEFORMAT DMY  UPDATE    tbMuhasebeFisiAciklamasi SET              sAciklama1 = '" & sAciklama1 & "', sAciklama2 = '" & sAciklama2 & "' , sAciklama3 = '" & sAciklama3 & "',  sAciklama4 = '" & sAciklama4 & "', sAciklama5 = '" & sAciklama5 & "',bKilitli =" & bKilitli & " where dteFisTarihi = '" & dteFisTarihi & "'  and sMuhFisTipi = '" & sMuhFisTipi & "' AND lFisno = " & lFisno & " ")
        End If
        'cmd.CommandText = sorgu_query("SET DATEFORMAT DMY  UPDATE    tbMuhasebeFisiAciklamasi SET              sAciklama5 = '" & sAciklama5 & "' where dteFisTarihi = '" & dteFisTarihi & "'  and sMuhFisTipi = '" & sMuhFisTipi & "' AND lFisno = " & lFisno & " ")
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
        If Trim(sDovizCinsi2) <> "" Then
            If lDovizKuru2 = 0 Then
                lDovizKuru2 = 1
            End If
            sDovizCinsi1 = sDovizCinsi2
            lDovizKuru1 = lDovizKuru2
            lDovizMiktari1 = lDovizMiktari2
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
        If Trim(sDovizCinsi2) <> "" Then
            If lDovizKuru2 = 0 Then
                lDovizKuru2 = 1
            End If
            sDovizCinsi1 = sDovizCinsi2
            lDovizKuru1 = lDovizKuru2
            lDovizMiktari1 = lDovizMiktari2
        End If
        cmd.CommandText = sorgu_query("SET DATEFORMAT DMY  UPDATE    tbFirmaHareketi SET              nFirmaID= " & nFirmaID & " , dteIslemTarihi = '" & dteIslemTarihi & "', dteValorTarihi = '" & dteValorTarihi & "', sCariIslem = '" & sCariIslem & "', sAciklama = N'" & sAciklama & "', lBorcTutar = " & lBorcTutar & ", lAlacakTutar = " & lAlacakTutar & ", sEvrakNo = '" & sEvrakNo & "', lVadeFarki = " & lVadeFarki & ", sHangiUygulama = '" & sHangiUygulama & "', sHareketTipi = '" & sHareketTipi & "', sDovizCinsi1 = '" & sDovizCinsi1 & "', lDovizMiktari1 = " & lDovizMiktari1 & ", lDovizKuru1 = " & lDovizKuru1 & ", sDovizCinsi2 = '" & sDovizCinsi2 & "', lDovizMiktari2 = " & lDovizMiktari2 & ", lDovizKuru2 = " & lDovizKuru2 & ", sSonKullaniciAdi = '" & sSonKullaniciAdi & "', dteSonUpdateTarihi = '" & dteSonUpdateTarihi & "'  WHERE     (nHareketID = " & nHareketID & ")")
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
    Private Sub nFisSiraID_degistir(ByVal nFisSiraID As String)
        Dim con As New OleDb.OleDbConnection
        Dim cmd As New OleDb.OleDbCommand
        Dim adapter As New OleDb.OleDbDataAdapter
        con.ConnectionString = connection
        cmd.Connection = con
        If con.State = ConnectionState.Closed Then
            con.Open()
        End If
        cmd.CommandText = sorgu_query("SET DATEFORMAT DMY SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED UPDATE    tbMuhasebeSiraNo SET              nSonID = '" & nFisSiraID & "' where nSiraIndex = 1")
        cmd.ExecuteNonQuery()
        con.Close()
    End Sub
    Private Sub lFisNo_degistir()
        Dim con As New OleDb.OleDbConnection
        Dim cmd As New OleDb.OleDbCommand
        Dim adapter As New OleDb.OleDbDataAdapter
        con.ConnectionString = connection
        cmd.Connection = con
        If con.State = ConnectionState.Closed Then
            con.Open()
        End If
        cmd.CommandText = sorgu_query("SET DATEFORMAT DMY SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED UPDATE tbMuhasebeFisNo SET lSonMahsupNo1 = ISNULL((SELECT TOP 1 ISNULL(lFisno + 1 , 1) AS lFisNo FROM tbMuhasebeFisi WHERE (sMuhFisTipi = " & sMuhFisTipi & ") Order by lFisNo desc),1)")
        cmd.ExecuteNonQuery()
        con.Close()
    End Sub
    Private Sub tbMuhasebeFisi_Aciklamasi_degistir()
        If ds_tbMuhasebeFisi.Tables(0).Rows.Count = 2 Then
            Dim dr As DataRow
            Dim sNotAciklama As String = ""
            Dim sayi As Integer = 0
            For Each dr In ds_tbMuhasebeFisi.Tables(0).Rows
                sayi += 1
                Try
                    sNotAciklama += Microsoft.VisualBasic.Left(dr("sFirmaAciklama").ToString, 25)
                Catch ex As Exception
                    sNotAciklama += ""
                End Try
                If sayi = 1 Then
                    sNotAciklama += "<-->"
                End If
            Next
            dr_baslik("sAciklama5") = sNotAciklama
            tbMuhasebeFisi_Aciklamasi_kaydet_duzelt(dr_baslik("dteFisTarihi"), dr_baslik("sMuhFisTipi"), dr_baslik("lFisNo"), dr_baslik("sAciklama1"), dr_baslik("sAciklama2"), dr_baslik("sAciklama3"), dr_baslik("sAciklama4"), sNotAciklama, dr_baslik("FisTarihi"), dr_baslik("bKilitli"))
        End If
    End Sub
    Private Sub degeryay(ByVal columnkriter As String, Optional ByVal bSatirDegistir As Boolean = True)
        Dim durum
        Dim sayi = GridView1.RowCount
        Dim satir = GridView1.FocusedRowHandle
        Dim TOPLAM = sayi - GridView1.FocusedRowHandle
        Dim Ý As Integer
        Dim t As Int64 = 0
        Ý = 0
        Dim dr As DataRow
        dr = GridView1.GetDataRow(GridView1.FocusedRowHandle)
        durum = dr("" & columnkriter & "")
        For Ý = 1 To TOPLAM
            t += 1
            If bSatirDegistir = True Then
                If columnkriter = "dteValorTarihi" Then
                    GridView1.PostEditor()
                    dr = GridView1.GetDataRow(GridView1.FocusedRowHandle)
                    If t > 1 Then
                        durum = DateAdd(DateInterval.Month, 1, durum)
                    Else
                        durum = durum
                    End If
                    dr("" & columnkriter & "") = durum
                    dr.EndEdit()
                Else
                    dr = GridView1.GetDataRow(GridView1.FocusedRowHandle)
                    dr.BeginEdit()
                    dr("" & columnkriter & "") = durum
                    dr.EndEdit()
                End If
                tutar_hesapla()
                GridView1.FocusedRowHandle += 1
            End If
        Next
        GridView1.FocusedRowHandle = satir
        GridView1.GetDataRow(satir)
        durum = Nothing
        sayi = Nothing
        satir = Nothing
        Ý = Nothing
    End Sub
    Private Sub satir_ekle(Optional ByVal sAra As String = "", Optional ByVal sKriter As String = "Baþlar", Optional ByVal nSatir As Integer = -1)
        If KayitSiniri_kontrol("tbMuhasebeFisi", "", nKayitSinir) = True Then
            Dim frm As New frm_firma_liste
            frm.islemstatus = True
            frm.connection = connection
            frm.firmano = firmano
            frm.donemno = donemno
            frm.islemstatus = True
            frm.kullanici = kullanici
            status = True
            If sAra <> "" Then
                frm.txt_ara.Text = sAra
                frm.sec_konum.Text = "Geliþmiþ"
                frm.sec_kriter.Text = sKriter
            End If
            If sModul = "Cari" Then
                frm.sModul = "MuhasebeCari"
            ElseIf sModul = "Banka" Then
                frm.sModul = "MuhasebeBanka"
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
                        dr = ds_tbMuhasebeFisi.Tables(0).NewRow
                        dr1 = frm.GridView1.GetDataRow(s)
                        Dim nFisSiraID As Int64 = sorgu_nFisSiraID()
                        Dim nCariHareketID = sorgu_nCariHareketID()
                        dr("nCariHareketID") = nCariHareketID
                        dr("nFisSiraID") = nFisSiraID
                        dr("dteFisTarihi") = dr_baslik("dteFisTarihi")
                        dr("dteValorTarihi") = dr_baslik("dteFisTarihi")
                        dr("sMuhFisTipi") = dr_baslik("sMuhFisTipi")
                        dr("lFisno") = dr_baslik("lFisNo")
                        dr("lYevmiyeNo") = dr_baslik("lYevmiyeNo")
                        dr("nHesapID") = dr1("nHesapID")
                        dr("nFirmaID") = dr1("nFirmaID")
                        'If GridView1.RowCount > 0 Then
                        '    Dim dr3 As DataRow = GridView1.GetDataRow(GridView1.FocusedRowHandle)
                        '    dr3("sAciklama") = dr1("sAciklama")
                        'End If
                        'If sAciklama = "" Then
                        '    sAciklama = dr1("sAciklama")
                        'End If
                        dr("sAciklama") = "" 'sAciklama
                        dr("lGirenMiktar") = 0
                        dr("lCikanMiktar") = 0
                        dr("lBorcTutar") = 0
                        dr("lAlacakTutar") = 0
                        dr("sMasrafYontemi") = ""
                        dr("nKasaID") = 0
                        dr("sHangiUygulama") = "CHS"
                        dr("sHareketTipi") = dr_baslik("sHareketTipi")
                        dr("sKullaniciAdi") = kullaniciadi
                        dr("dteKayitTarihi") = Now
                        dr("sDovizCinsi1") = ""
                        dr("lDovizMiktari1") = 0
                        dr("lDovizKuru1") = 0
                        If Trim(dr1("sDovizCinsi")) <> "" Then
                            dr("sDovizCinsi2") = Trim(dr1("sDovizCinsi").ToString)
                            dr("lDovizKuru2") = sorgu_lDovizKuru(Trim(dr1("sDovizCinsi").ToString))
                            dr("lDovizMiktari2") = Math.Abs(dr("lBorcTutar") - dr("lAlacakTutar")) / dr("lDovizKuru2")
                        Else
                            dr("sDovizCinsi2") = ""
                            dr("lDovizMiktari2") = 0
                            dr("lDovizKuru2") = 0
                        End If
                        If nSatir = -1 Then
                            dr("nSatir") = ds_tbMuhasebeFisi.Tables(0).Rows.Count
                        Else
                            dr("nSatir") = nSatir
                        End If
                        dr("sSubeMagaza") = dr_baslik("sSubeMagaza")
                        dr("sSonKullaniciAdi") = kullaniciadi
                        dr("dteSonUpdateTarihi") = Now
                        dr("sFirmaKodu") = dr1("sKodu")
                        dr("sFirmaAciklama") = dr1("sAciklama")
                        dr("sHesapKodu") = dr1("sHesapKodu")
                        dr("sHesapAciklama") = dr1("sHesapAciklama")
                        dr("sCariIslem") = ""
                        dr("sEvrakNo") = dr_baslik("lFisNo")
                        dr("nCariHareketID") = tbFirmaHareketi_kaydet_yeni(dr("nCariHareketID"), dr("nFirmaID"), dr("dteFisTarihi"), dr("dteFisTarihi"), "", Microsoft.VisualBasic.Left(dr("sAciklama"), 50) + "-FNo:" + (dr_baslik("lFisNo")).ToString, dr("lBorcTutar"), dr("lAlacakTutar"), dr_baslik("lFisNo"), 0, "MUH", dr("sHareketTipi"), dr("sKullaniciAdi"), dr("dteKayitTarihi"), "", 0, 0, "", 0, 0, dr("sKullaniciAdi"), dr("dteSonUpdateTarihi"))
                        nCariHareketID_degistir(dr("nCariHareketID"))
                        dr("nFisSiraID") = tbMuhasebeFisi_kaydet_yeni(dr("nFisSiraID"), dr("dteFisTarihi"), dr("sMuhFisTipi"), dr("lFisNo"), dr("lYevmiyeNo"), dr("nHesapID"), dr("sAciklama"), dr("lGirenMiktar"), dr("lCikanMiktar"), dr("lBorcTutar"), dr("lAlacakTutar"), dr("sMasrafYontemi"), dr("nKasaID"), dr("sHangiUygulama"), dr("sHareketTipi"), dr("nCariHareketID"), dr("sKullaniciAdi"), dr("dteKayitTarihi"), dr("sDovizCinsi1"), dr("lDovizMiktari1"), dr("lDovizKuru1"), dr("sDovizCinsi2"), dr("lDovizMiktari2"), dr("lDovizKuru2"), dr("nSatir"), dr("sSubeMagaza"), dr("sSonKullaniciAdi"), dr("dteSonUpdateTarihi"))
                        nFisSiraID_degistir(dr("nFisSiraID"))
                        ds_tbMuhasebeFisi.Tables(0).Rows.Add(dr)
                        If yeni = True Then
                            Try
                                tbMuhasebeFisi_Aciklamasi_kaydet_yeni(dr("dteFisTarihi"), dr("sMuhFisTipi"), dr("lFisNo"), "", "", "", "", "", 0)
                                yeni = False
                            Catch ex As Exception
                            End Try
                        Else
                        End If
                        yeni = False
                    Next
                End If
            End If
            frm.Close()
            frm = Nothing
            status = False
            If GridView1.RowCount > 0 Then
                GridView1.FocusedRowHandle = GridView1.RowCount - 1
                GridView1.ClearSelection()
                GridView1.SelectRow(GridView1.RowCount - 1)
                PanelControl3.Focus()
                GridControl1.Focus()
            End If
            GridView1.FocusedColumn = collBorcTutar
            satir_kontrol()
        End If
    End Sub
    Private Sub muhasebe_Kdv_satir_ekle(Optional ByVal sAra As String = "", Optional ByVal sKriter As String = "Baþlar")
        If KayitSiniri_kontrol("tbMuhasebeFisi", "", nKayitSinir) = True Then
            Dim frm As New frm_tbMuhasebeFisi_Kdv
            frm.connection = connection
            frm.firmano = firmano
            frm.donemno = donemno
            If GridView1.RowCount > 0 Then
                Dim dr As DataRow = GridView1.GetDataRow(GridView1.FocusedRowHandle)
                If dr("lAlacakTutar") = 0 Then
                    frm.lKdvMatrahi = dr("lBorcTutar")
                Else
                    frm.lKdvMatrahi = dr("lAlacakTutar")
                    frm.bAlacak = True
                End If
            End If
            If frm.ShowDialog(Me) = Windows.Forms.DialogResult.OK Then
                Dim dr As DataRow
                dr = ds_tbMuhasebeFisi.Tables(0).NewRow
                Dim nFisSiraID As Int64 = sorgu_nFisSiraID()
                dr("nCariHareketID") = 0
                dr("nFisSiraID") = nFisSiraID
                dr("dteFisTarihi") = dr_baslik("dteFisTarihi")
                dr("dteValorTarihi") = dr_baslik("dteFisTarihi")
                dr("sMuhFisTipi") = dr_baslik("sMuhFisTipi")
                dr("lFisno") = dr_baslik("lFisNo")
                dr("lYevmiyeNo") = dr_baslik("lYevmiyeNo")
                dr("nHesapID") = frm.nHesapID
                dr("nFirmaID") = 0
                dr("sAciklama") = "" 'sAciklama
                dr("lGirenMiktar") = 0
                dr("lCikanMiktar") = 0
                If frm.bAlacak = True Then
                    dr("lBorcTutar") = 0
                    dr("lAlacakTutar") = frm.lKdvTutari
                Else
                    dr("lBorcTutar") = frm.lKdvTutari
                    dr("lAlacakTutar") = 0
                End If
                dr("sMasrafYontemi") = ""
                dr("nKasaID") = 0
                dr("sHangiUygulama") = "MUH"
                dr("sHareketTipi") = dr_baslik("sHareketTipi")
                dr("sKullaniciAdi") = kullaniciadi
                dr("dteKayitTarihi") = Now
                dr("sDovizCinsi1") = ""
                dr("lDovizMiktari1") = 0
                dr("lDovizKuru1") = 0
                dr("sDovizCinsi2") = ""
                dr("lDovizMiktari2") = 0
                dr("lDovizKuru2") = 0
                dr("nSatir") = ds_tbMuhasebeFisi.Tables(0).Rows.Count
                dr("sSubeMagaza") = dr_baslik("sSubeMagaza")
                dr("sSonKullaniciAdi") = kullaniciadi
                dr("dteSonUpdateTarihi") = Now
                dr("sFirmaKodu") = ""
                dr("sFirmaAciklama") = ""
                dr("sHesapKodu") = frm.sKodu
                dr("sHesapAciklama") = frm.sAciklama
                dr("sCariIslem") = ""
                dr("sEvrakNo") = dr_baslik("lFisNo")
                'tbFirmaHareketi_kaydet_yeni(dr("nCariHareketID"), dr("nFirmaID"), dr("dteFisTarihi"), dr("dteFisTarihi"), "", Microsoft.VisualBasic.Left(dr("sAciklama"), 50) + "-FNo:" + (dr_baslik("lFisNo")).ToString, dr("lBorcTutar"), dr("lAlacakTutar"), dr_baslik("lFisNo"), 0, "MUH", dr("sHareketTipi"), dr("sKullaniciAdi"), dr("dteKayitTarihi"), "", 0, 0, "", 0, 0, dr("sKullaniciAdi"), dr("dteSonUpdateTarihi"))
                'nCariHareketID_degistir(nCariHareketID)
                dr("nFisSiraID") = tbMuhasebeFisi_kaydet_yeni(dr("nFisSiraID"), dr("dteFisTarihi"), dr("sMuhFisTipi"), dr("lFisNo"), dr("lYevmiyeNo"), dr("nHesapID"), dr("sAciklama"), dr("lGirenMiktar"), dr("lCikanMiktar"), dr("lBorcTutar"), dr("lAlacakTutar"), dr("sMasrafYontemi"), dr("nKasaID"), dr("sHangiUygulama"), dr("sHareketTipi"), dr("nCariHareketID"), dr("sKullaniciAdi"), dr("dteKayitTarihi"), dr("sDovizCinsi1"), dr("lDovizMiktari1"), dr("lDovizKuru1"), dr("sDovizCinsi2"), dr("lDovizMiktari2"), dr("lDovizKuru2"), dr("nSatir"), dr("sSubeMagaza"), dr("sSonKullaniciAdi"), dr("dteSonUpdateTarihi"))
                nFisSiraID_degistir(dr("nFisSiraID"))
                ds_tbMuhasebeFisi.Tables(0).Rows.Add(dr)
                If yeni = True Then
                    Try
                        tbMuhasebeFisi_Aciklamasi_kaydet_yeni(dr("dteFisTarihi"), dr("sMuhFisTipi"), dr("lFisNo"), "", "", "", "", "", 0)
                        yeni = False
                    Catch ex As Exception
                    End Try
                Else
                End If
                yeni = False
            End If
            frm.Close()
            frm = Nothing
            status = False
            If GridView1.RowCount > 0 Then
                GridView1.FocusedRowHandle = GridView1.RowCount - 1
                GridView1.ClearSelection()
                GridView1.SelectRow(GridView1.RowCount - 1)
                PanelControl3.Focus()
                GridControl1.Focus()
            End If
            GridView1.FocusedColumn = collBorcTutar
            satir_kontrol()
        End If
    End Sub
    Private Sub muhasebe_satir_ekle(Optional ByVal sAra As String = "", Optional ByVal sKriter As String = "Baþlar")
        If KayitSiniri_kontrol("tbMuhasebeFisi", "", nKayitSinir) = True Then
            Dim frm As New frm_HesapPlani_liste
            frm.islemstatus = True
            frm.connection = connection
            frm.firmano = firmano
            frm.donemno = donemno
            frm.islemstatus = True
            frm.kullanici = kullanici
            status = True
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
                        dr = ds_tbMuhasebeFisi.Tables(0).NewRow
                        dr1 = frm.GridView1.GetDataRow(s)
                        Dim nFisSiraID As Int64 = sorgu_nFisSiraID()
                        dr("nCariHareketID") = 0
                        dr("nFisSiraID") = nFisSiraID
                        dr("dteFisTarihi") = dr_baslik("dteFisTarihi")
                        dr("dteValorTarihi") = dr_baslik("dteFisTarihi")
                        dr("sMuhFisTipi") = dr_baslik("sMuhFisTipi")
                        dr("lFisno") = dr_baslik("lFisNo")
                        dr("lYevmiyeNo") = dr_baslik("lYevmiyeNo")
                        dr("nHesapID") = dr1("nHesapID")
                        'dr("nFirmaID") = dr1("nFirmaID")
                        'If GridView1.RowCount > 0 Then
                        '    Dim dr3 As DataRow = GridView1.GetDataRow(GridView1.FocusedRowHandle)
                        '    dr3("sAciklama") = dr1("sAciklama")
                        'End If
                        'If sAciklama = "" Then
                        '    sAciklama = dr1("sAciklama")
                        'End If
                        dr("sAciklama") = "" 'sAciklama
                        dr("lGirenMiktar") = 0
                        dr("lCikanMiktar") = 0
                        dr("lBorcTutar") = 0
                        dr("lAlacakTutar") = 0
                        dr("sMasrafYontemi") = ""
                        dr("nKasaID") = 0
                        dr("sHangiUygulama") = "MUH"
                        dr("sHareketTipi") = dr_baslik("sHareketTipi")
                        dr("sKullaniciAdi") = kullaniciadi
                        dr("dteKayitTarihi") = Now
                        dr("sDovizCinsi1") = ""
                        dr("lDovizMiktari1") = 0
                        dr("lDovizKuru1") = 0
                        dr("sDovizCinsi2") = ""
                        dr("lDovizMiktari2") = 0
                        dr("lDovizKuru2") = 0
                        dr("nSatir") = ds_tbMuhasebeFisi.Tables(0).Rows.Count
                        dr("sSubeMagaza") = dr_baslik("sSubeMagaza")
                        dr("sSonKullaniciAdi") = kullaniciadi
                        dr("dteSonUpdateTarihi") = Now
                        'dr("sFirmaKodu") = dr1("sFirmaKodu")
                        'dr("sFirmaAciklama") = dr1("sFirmaAciklama")
                        dr("sHesapKodu") = dr1("sKodu")
                        dr("sHesapAciklama") = dr1("sAciklama")
                        dr("sCariIslem") = ""
                        dr("sEvrakNo") = dr_baslik("lFisNo")
                        'tbFirmaHareketi_kaydet_yeni(dr("nCariHareketID"), dr("nFirmaID"), dr("dteFisTarihi"), dr("dteFisTarihi"), "", Microsoft.VisualBasic.Left(dr("sAciklama"), 50) + "-FNo:" + (dr_baslik("lFisNo")).ToString, dr("lBorcTutar"), dr("lAlacakTutar"), dr_baslik("lFisNo"), 0, "MUH", dr("sHareketTipi"), dr("sKullaniciAdi"), dr("dteKayitTarihi"), "", 0, 0, "", 0, 0, dr("sKullaniciAdi"), dr("dteSonUpdateTarihi"))
                        'nCariHareketID_degistir(nCariHareketID)
                        dr("nFisSiraID") = tbMuhasebeFisi_kaydet_yeni(dr("nFisSiraID"), dr("dteFisTarihi"), dr("sMuhFisTipi"), dr("lFisNo"), dr("lYevmiyeNo"), dr("nHesapID"), dr("sAciklama"), dr("lGirenMiktar"), dr("lCikanMiktar"), dr("lBorcTutar"), dr("lAlacakTutar"), dr("sMasrafYontemi"), dr("nKasaID"), dr("sHangiUygulama"), dr("sHareketTipi"), dr("nCariHareketID"), dr("sKullaniciAdi"), dr("dteKayitTarihi"), dr("sDovizCinsi1"), dr("lDovizMiktari1"), dr("lDovizKuru1"), dr("sDovizCinsi2"), dr("lDovizMiktari2"), dr("lDovizKuru2"), dr("nSatir"), dr("sSubeMagaza"), dr("sSonKullaniciAdi"), dr("dteSonUpdateTarihi"))
                        nFisSiraID_degistir(dr("nFisSiraID"))
                        ds_tbMuhasebeFisi.Tables(0).Rows.Add(dr)
                        If yeni = True Then
                            Try
                                tbMuhasebeFisi_Aciklamasi_kaydet_yeni(dr("dteFisTarihi"), dr("sMuhFisTipi"), dr("lFisNo"), "", "", "", "", "", 0)
                                yeni = False
                            Catch ex As Exception
                            End Try
                        Else
                        End If
                        yeni = False
                    Next
                End If
            End If
            frm.Close()
            frm = Nothing
            status = False
            If GridView1.RowCount > 0 Then
                GridView1.FocusedRowHandle = GridView1.RowCount - 1
                GridView1.ClearSelection()
                GridView1.SelectRow(GridView1.RowCount - 1)
                PanelControl3.Focus()
                GridControl1.Focus()
            End If
            GridView1.FocusedColumn = collBorcTutar
            satir_kontrol()
        End If
    End Sub
    Private Sub satir_ekle_firma_tek()
        If KayitSiniri_kontrol("tbMuhasebeFisi", "", nKayitSinir) = True Then
            Dim dr As DataRow
            Dim dr1 As DataRow
            dr = ds_tbMuhasebeFisi.Tables(0).NewRow
            dr1 = ds_Firma.Tables(0).Rows(0)
            Dim nFisSiraID As Int64 = sorgu_nFisSiraID()
            Dim nCariHareketID = sorgu_nCariHareketID()
            dr("nCariHareketID") = sorgu_nCariHareketID()
            dr("nFisSiraID") = nFisSiraID
            dr("dteFisTarihi") = dr_baslik("dteFisTarihi")
            dr("dteValorTarihi") = dr_baslik("dteFisTarihi")
            dr("sMuhFisTipi") = dr_baslik("sMuhFisTipi")
            dr("lFisno") = dr_baslik("lFisNo")
            dr("lYevmiyeNo") = dr_baslik("lYevmiyeNo")
            dr("nHesapID") = dr1("nHesapID")
            dr("nFirmaID") = dr1("nFirmaID")
            'If GridView1.RowCount > 0 Then
            '    Dim dr3 As DataRow = GridView1.GetDataRow(GridView1.FocusedRowHandle)
            '    dr3("sAciklama") = dr1("sAciklama")
            'End If
            'If sAciklama = "" Then
            '    sAciklama = dr1("sAciklama")
            'End If
            dr("sAciklama") = "" 'sAciklama
            dr("lGirenMiktar") = 0
            dr("lCikanMiktar") = 0
            dr("lBorcTutar") = 0
            dr("lAlacakTutar") = 0
            dr("sMasrafYontemi") = ""
            dr("nKasaID") = 0
            dr("sHangiUygulama") = "CHS"
            dr("sHareketTipi") = dr_baslik("sHareketTipi")
            dr("sKullaniciAdi") = kullaniciadi
            dr("dteKayitTarihi") = Now
            dr("sDovizCinsi1") = ""
            dr("lDovizMiktari1") = 0
            dr("lDovizKuru1") = 0
            If Trim(dr1("sDovizCinsi")) <> "" Then
                dr("sDovizCinsi2") = Trim(dr1("sDovizCinsi").ToString)
                dr("lDovizKuru2") = sorgu_lDovizKuru(Trim(dr1("sDovizCinsi").ToString))
                dr("lDovizMiktari2") = Math.Abs(dr("lBorcTutar") - dr("lAlacakTutar")) / dr("lDovizKuru2")
            Else
                dr("sDovizCinsi2") = ""
                dr("lDovizMiktari2") = 0
                dr("lDovizKuru2") = 0
            End If
            dr("nSatir") = ds_tbMuhasebeFisi.Tables(0).Rows.Count
            dr("sSubeMagaza") = dr_baslik("sSubeMagaza")
            dr("sSonKullaniciAdi") = kullaniciadi
            dr("dteSonUpdateTarihi") = Now
            dr("sFirmaKodu") = dr1("sKodu")
            dr("sFirmaAciklama") = dr1("sAciklama")
            dr("sHesapKodu") = dr1("sHesapKodu")
            dr("sHesapAciklama") = dr1("sHesapAciklama")
            dr("sCariIslem") = ""
            dr("sEvrakNo") = dr_baslik("lFisNo")
            dr("nCariHareketID") = tbFirmaHareketi_kaydet_yeni(dr("nCariHareketID"), dr("nFirmaID"), dr("dteFisTarihi"), dr("dteFisTarihi"), "", Microsoft.VisualBasic.Left(dr("sAciklama"), 50) + "-FNo:" + (dr_baslik("lFisNo")).ToString, dr("lBorcTutar"), dr("lAlacakTutar"), dr_baslik("lFisNo"), 0, "MUH", dr("sHareketTipi"), dr("sKullaniciAdi"), dr("dteKayitTarihi"), "", 0, 0, "", 0, 0, dr("sKullaniciAdi"), dr("dteSonUpdateTarihi"))
            nCariHareketID_degistir(dr("nCariHareketID"))
            dr("nFisSiraID") = tbMuhasebeFisi_kaydet_yeni(dr("nFisSiraID"), dr("dteFisTarihi"), dr("sMuhFisTipi"), dr("lFisNo"), dr("lYevmiyeNo"), dr("nHesapID"), dr("sAciklama"), dr("lGirenMiktar"), dr("lCikanMiktar"), dr("lBorcTutar"), dr("lAlacakTutar"), dr("sMasrafYontemi"), dr("nKasaID"), dr("sHangiUygulama"), dr("sHareketTipi"), dr("nCariHareketID"), dr("sKullaniciAdi"), dr("dteKayitTarihi"), dr("sDovizCinsi1"), dr("lDovizMiktari1"), dr("lDovizKuru1"), dr("sDovizCinsi2"), dr("lDovizMiktari2"), dr("lDovizKuru2"), dr("nSatir"), dr("sSubeMagaza"), dr("sSonKullaniciAdi"), dr("dteSonUpdateTarihi"))
            nFisSiraID_degistir(dr("nFisSiraID"))
            ds_tbMuhasebeFisi.Tables(0).Rows.Add(dr)
            If yeni = True Then
                Try
                    tbMuhasebeFisi_Aciklamasi_kaydet_yeni(dr("dteFisTarihi"), dr("sMuhFisTipi"), dr("lFisNo"), "", "", "", "", "", 0)
                    yeni = False
                Catch ex As Exception
                End Try
            Else
            End If
            yeni = False
            status = False
            If GridView1.RowCount > 0 Then
                GridView1.FocusedRowHandle = GridView1.RowCount - 1
                GridView1.ClearSelection()
                GridView1.SelectRow(GridView1.RowCount - 1)
                PanelControl3.Focus()
                GridControl1.Focus()
            End If
            GridView1.FocusedColumn = collBorcTutar
            satir_kontrol()
            txt_ara.Text = ""
            txt_ara.Focus()
            txt_ara.SelectAll()
        End If
    End Sub
    Private Sub muhasebe_satir_ekle_firma_tek()
        If KayitSiniri_kontrol("tbMuhasebeFisi", "", nKayitSinir) = True Then
            Dim dr As DataRow
            Dim dr1 As DataRow
            dr = ds_tbMuhasebeFisi.Tables(0).NewRow
            dr1 = ds_Firma.Tables(0).Rows(0)
            Dim nFisSiraID As Int64 = sorgu_nFisSiraID()
            'Dim nCariHareketID = sorgu_nCariHareketID()
            dr("nCariHareketID") = 0
            dr("nFisSiraID") = nFisSiraID
            dr("dteFisTarihi") = dr_baslik("dteFisTarihi")
            dr("dteValorTarihi") = dr_baslik("dteFisTarihi")
            dr("sMuhFisTipi") = dr_baslik("sMuhFisTipi")
            dr("lFisno") = dr_baslik("lFisNo")
            dr("lYevmiyeNo") = dr_baslik("lYevmiyeNo")
            dr("nHesapID") = dr1("nHesapID")
            dr("nFirmaID") = dr1("nFirmaID")
            'If GridView1.RowCount > 0 Then
            '    Dim dr3 As DataRow = GridView1.GetDataRow(GridView1.FocusedRowHandle)
            '    dr3("sAciklama") = dr1("sAciklama")
            'End If
            'If sAciklama = "" Then
            '    sAciklama = dr1("sAciklama")
            'End If
            dr("sAciklama") = "" 'sAciklama
            dr("lGirenMiktar") = 0
            dr("lCikanMiktar") = 0
            dr("lBorcTutar") = 0
            dr("lAlacakTutar") = 0
            dr("sMasrafYontemi") = ""
            dr("nKasaID") = 0
            dr("sHangiUygulama") = "MUH"
            dr("sHareketTipi") = dr_baslik("sHareketTipi")
            dr("sKullaniciAdi") = kullaniciadi
            dr("dteKayitTarihi") = Now
            dr("sDovizCinsi1") = ""
            dr("lDovizMiktari1") = 0
            dr("lDovizKuru1") = 0
            dr("sDovizCinsi2") = ""
            dr("lDovizMiktari2") = 0
            dr("lDovizKuru2") = 0
            dr("nSatir") = ds_tbMuhasebeFisi.Tables(0).Rows.Count
            dr("sSubeMagaza") = dr_baslik("sSubeMagaza")
            dr("sSonKullaniciAdi") = kullaniciadi
            dr("dteSonUpdateTarihi") = Now
            dr("sFirmaKodu") = dr1("sFirmaKodu")
            dr("sFirmaAciklama") = dr1("sFirmaAciklama")
            dr("sHesapKodu") = dr1("sKodu")
            dr("sHesapAciklama") = dr1("sAciklama")
            dr("sCariIslem") = ""
            dr("sEvrakNo") = dr_baslik("lFisNo")
            'tbFirmaHareketi_kaydet_yeni(dr("nCariHareketID"), dr("nFirmaID"), dr("dteFisTarihi"), dr("dteFisTarihi"), "", Microsoft.VisualBasic.Left(dr("sAciklama"), 50) + "-FNo:" + (dr_baslik("lFisNo")).ToString, dr("lBorcTutar"), dr("lAlacakTutar"), dr_baslik("lFisNo"), 0, "MUH", dr("sHareketTipi"), dr("sKullaniciAdi"), dr("dteKayitTarihi"), "", 0, 0, "", 0, 0, dr("sKullaniciAdi"), dr("dteSonUpdateTarihi"))
            'nCariHareketID_degistir(nCariHareketID)
            dr("nFisSiraID") = tbMuhasebeFisi_kaydet_yeni(dr("nFisSiraID"), dr("dteFisTarihi"), dr("sMuhFisTipi"), dr("lFisNo"), dr("lYevmiyeNo"), dr("nHesapID"), dr("sAciklama"), dr("lGirenMiktar"), dr("lCikanMiktar"), dr("lBorcTutar"), dr("lAlacakTutar"), dr("sMasrafYontemi"), dr("nKasaID"), dr("sHangiUygulama"), dr("sHareketTipi"), dr("nCariHareketID"), dr("sKullaniciAdi"), dr("dteKayitTarihi"), dr("sDovizCinsi1"), dr("lDovizMiktari1"), dr("lDovizKuru1"), dr("sDovizCinsi2"), dr("lDovizMiktari2"), dr("lDovizKuru2"), dr("nSatir"), dr("sSubeMagaza"), dr("sSonKullaniciAdi"), dr("dteSonUpdateTarihi"))
            nFisSiraID_degistir(dr("nFisSiraID"))
            ds_tbMuhasebeFisi.Tables(0).Rows.Add(dr)
            If yeni = True Then
                Try
                    tbMuhasebeFisi_Aciklamasi_kaydet_yeni(dr("dteFisTarihi"), dr("sMuhFisTipi"), dr("lFisNo"), "", "", "", "", "", 0)
                    yeni = False
                Catch ex As Exception
                End Try
            Else
            End If
            yeni = False
            status = False
            If GridView1.RowCount > 0 Then
                GridView1.FocusedRowHandle = GridView1.RowCount - 1
                GridView1.ClearSelection()
                GridView1.SelectRow(GridView1.RowCount - 1)
                PanelControl3.Focus()
                GridControl1.Focus()
            End If
            GridView1.FocusedColumn = collBorcTutar
            satir_kontrol()
            txt_ara.Text = ""
            txt_ara.Focus()
            txt_ara.SelectAll()
        End If
    End Sub
    Private Sub satir_sil(Optional ByVal bIlkSatir As Boolean = False)
        If GridView1.RowCount > 1 Then
            Dim bSil As Boolean = False
            If dr_baslik("sMuhFisTipi") = 3 Then
                bSil = True
            ElseIf dr_baslik("sMuhFisTipi") = 1 And GridView1.FocusedRowHandle > 0 Then
                bSil = True
            ElseIf dr_baslik("sMuhFisTipi") = 2 And GridView1.FocusedRowHandle > 0 Then
                bSil = True
            End If
            If bSil = True Then
                If XtraMessageBox.Show(Sorgu_sDil("Satýrý Silmek Ýstediðinize Emin misiniz...?", sDil), Sorgu_sDil("Dikkat", sDil), MessageBoxButtons.YesNo, MessageBoxIcon.Question) = MsgBoxResult.Yes Then
                    Dim dr As DataRow
                    dr = GridView1.GetDataRow(GridView1.FocusedRowHandle)
                    tbMuhasebeFisi_kaydet_sil(dr("nFisSiraID"), dr("nCariHareketID"))
                    ds_tbMuhasebeFisi.Tables(0).Rows.Remove(dr)
                    GridControl1.Focus()
                    GridControl1.Select()
                    Dataload_tbYekun(dr_baslik("dteFisTarihi"), dr_baslik("sMuhFisTipi"), dr_baslik("lFisNo"))
                    If GridView1.RowCount > 0 Then
                        GridView1.SelectRow(GridView1.FocusedRowHandle)
                    End If
                End If
            End If
        ElseIf GridView1.RowCount = 1 Then
            XtraMessageBox.Show(Sorgu_sDil("Ilk Satýrý Silemezsiniz, Fisi Ýptal Ediniz...!", sDil), Sorgu_sDil("Dikkat", sDil), MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If
    End Sub
    Private Sub satir_kontrol()
        If status = False Then
            If GridView1.RowCount > 0 Then
                Dim dr As DataRow = GridView1.GetDataRow(GridView1.FocusedRowHandle)
                Dataload_tbFirma(dr("sFirmaKodu").ToString)
                Dataload_tbHesap(dr("nHesapID"))
                dr = Nothing
            End If
        End If
    End Sub
    Private Sub fis_sil()
        If XtraMessageBox.Show(Sorgu_sDil("Fiþi Silmek Ýstediðinize Emin misiniz...?", sDil), Sorgu_sDil("Dikkat", sDil), MessageBoxButtons.YesNo, MessageBoxIcon.Question) = MsgBoxResult.Yes Then
            Dim bSil As Boolean = True
            If bSil = True Then
                If GridView1.ActiveFilter.Count = 0 Then
                    bSil = True
                Else
                    bSil = False
                    XtraMessageBox.Show(Sorgu_sDil("Silmek Ýstediðiniz Belgede Filtre Mevcut Toplu Silme Ýþlemi Yapamazsýnýz.Filtre Ýptal Edildi Lütfen Kontrol Ederek Tekrar Deneyiniz...!", sDil), Sorgu_sDil("Dikkat", sDil), MessageBoxButtons.OK, MessageBoxIcon.Warning)
                    GridView1.ClearColumnsFilter()
                End If
            End If
            If bSil = True Then
                Dim dr As DataRow
                For Each dr In ds_tbMuhasebeFisi.Tables(0).Rows
                    PerakendeNotMuhasebelestir(dr("lFisNo").ToString(), dr("nAlisverisID").ToString(), "", 1)
                Next
                dr = Nothing
                tbMuhasebeFisi_sil(dr_baslik("dteFisTarihi"), dr_baslik("sMuhFisTipi"), dr_baslik("lFisNo"))
                lFisNo_degistir()
                Try
                    tbFisKilit_sil(dr_baslik("lFisNo"), dr_baslik("sMuhFisTipi"), kullanici)
                Catch ex As Exception
                End Try
                Try
                    ds_tbMuhasebeFisi.Tables(0).Clear()
                Catch ex As Exception
                End Try
                dr_baslik("dteFisTarihi") = Today
                dr_baslik("lFisNo") = 0
                dr_baslik("lYevmiyeNo") = 0
                SonYevmiyeKaydet(sMuhFisTipi, (SonYevmiyeNoBul(sMuhFisTipi) - 1))
                Me.Close()
            End If
        End If
    End Sub
    Private Sub tutar_hesapla(Optional ByVal nSatir As Integer = -1, Optional ByVal bLoad As Boolean = True)
        If GridView1.RowCount > 0 Then
            Dim dr As DataRow
            If nSatir = -1 Then
                dr = GridView1.GetDataRow(GridView1.FocusedRowHandle)
            Else
                dr = GridView1.GetDataRow(nSatir)
            End If
            dr("lBorcTutar") = sorgu_sayi(dr("lBorcTutar"), 0)
            dr("lAlacakTutar") = sorgu_sayi(dr("lAlacakTutar"), 0)
            Try
                dr("nOpsiyon") = sorgu_sayi(dr("nOpsiyon"), 0)
            Catch ex As Exception
                dr("nOpsiyon") = 0
            End Try
            dr("lDovizMiktari2") = sorgu_sayi(dr("lDovizMiktari2"), 0)
            dr("lDovizMiktari1") = sorgu_sayi(dr("lDovizMiktari1"), 0)
            dr("lDovizKuru1") = sorgu_sayi(dr("lDovizKuru1"), 0)
            dr("lDovizKuru2") = sorgu_sayi(dr("lDovizKuru2"), 0)
            If Trim(dr("sDovizCinsi1")) = "" Then
                dr("lDovizKuru1") = 0
                dr("lDovizMiktari1") = 0
            End If
            If Trim(dr("sDovizCinsi2")) = "" Then
                dr("lDovizKuru2") = 0
                dr("lDovizMiktari2") = 0
            End If
            If GridView1.FocusedColumn.Name = colnOpsiyon.Name.ToString Then
                Try
                    dr("dteValorTarihi") = DateAdd(DateInterval.Day, dr("nOpsiyon"), dr("dteFisTarihi"))
                Catch ex As Exception
                    dr("dteValorTarihi") = dr("dteFisTarihi")
                End Try
            Else 'If GridView1.FocusedColumn.Name = colnOpsiyon.Name.ToString Then
                Try
                    dr("nOpsiyon") = DateDiff(DateInterval.Day, dr("dteFisTarihi"), dr("dteValorTarihi"))
                Catch ex As Exception
                    dr("nOpsiyon") = 0
                End Try
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
            If GridView1.FocusedColumn.Name = collDovizMiktari2.Name.ToString Then
                If Trim(dr("sDovizCinsi2")) <> "" Then
                    If dr("lDovizKuru2") = 0 Then
                        dr("lDovizKuru2") = 1
                    End If
                    If dr("lBorcTutar") = 0 Then
                        dr("lAlacakTutar") = dr("lDovizMiktari2") * dr("lDovizKuru2")
                    ElseIf dr("lAlacakTutar") = 0 Then
                        dr("lBorcTutar") = dr("lDovizMiktari2") * dr("lDovizKuru2")
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
            If Trim(dr("sDovizCinsi2")) <> "" Then
                If dr("lDovizKuru2") = 0 Then
                    dr("lDovizKuru2") = 1
                End If
                dr("lDovizMiktari2") = Math.Abs(dr("lBorcTutar") - dr("lAlacakTutar")) / dr("lDovizKuru2")
            End If
            If GridView1.RowCount > 0 Then
                'GroupControl1.Enabled = False
                'GroupControl2.Enabled = False
            Else
                'GroupControl1.Enabled = True
                'GroupControl2.Enabled = True
            End If
            tbMuhasebeFisi_kaydet_duzelt(dr("nFisSiraID"), dr("dteFisTarihi"), dr("sMuhFisTipi"), dr("lFisNo"), dr("lYevmiyeNo"), dr("nHesapID"), dr("sAciklama"), dr("lGirenMiktar"), dr("lCikanMiktar"), dr("lBorcTutar"), dr("lAlacakTutar"), dr("sMasrafYontemi"), dr("nKasaID"), dr("sHangiUygulama"), dr("sHareketTipi"), dr("nCariHareketID"), dr("sKullaniciAdi"), dr("dteKayitTarihi"), dr("sDovizCinsi1"), dr("lDovizMiktari1"), dr("lDovizKuru1"), dr("sDovizCinsi2"), dr("lDovizMiktari2"), dr("lDovizKuru2"), dr("nSatir"), dr("sSubeMagaza"), kullaniciadi, Now)
            If bMuhasabe = False Then
                tbFirmaHareketi_kaydet_duzelt(dr("nCariHareketID"), dr("nFirmaID"), dr("dteFisTarihi"), dr("dteValorTarihi"), dr("sCariIslem"), Microsoft.VisualBasic.Left(dr("sAciklama"), 50) + "-FNo:" + (dr_baslik("lFisNo")).ToString, dr("lBorcTutar"), dr("lAlacakTutar"), dr_baslik("lFisNo"), 0, "MUH", dr("sHareketTipi").ToString, dr("sKullaniciAdi").ToString, dr("dteKayitTarihi"), dr("sDovizCinsi1"), dr("lDovizMiktari1"), dr("lDovizKuru1"), dr("sDovizCinsi2"), dr("lDovizMiktari2"), dr("lDovizKuru2"), kullaniciadi, Now)
            End If
            If bLoad = True Then
                Dataload_tbFirma(dr("sFirmaKodu").ToString)
                Dataload_tbHesap(dr("nHesapID"))
                Dataload_tbYekun(dr_baslik("dteFisTarihi"), dr_baslik("sMuhFisTipi"), dr_baslik("lFisNo"))
                dr = Nothing
                If dr_baslik("sMuhFisTipi") = 2 And nSatir = -1 Then
                    Dim lBorcTutar As Decimal = sorgu_lBorcTutar(dr_baslik("dteFisTarihi"), dr_baslik("sMuhFisTipi"), dr_baslik("lFisNo"))
                    Dim dr1 As DataRow = GridView1.GetDataRow(0)
                    dr1("lAlacakTutar") = lBorcTutar
                    tutar_hesapla(0)
                    dr1 = Nothing
                ElseIf dr_baslik("sMuhFisTipi") = 1 And nSatir = -1 Then
                    Dim lAlacakTutar As Decimal = sorgu_lAlacakTutar(dr_baslik("dteFisTarihi"), dr_baslik("sMuhFisTipi"), dr_baslik("lFisNo"))
                    Dim dr1 As DataRow = GridView1.GetDataRow(0)
                    dr1("lBorcTutar") = lAlacakTutar
                    tutar_hesapla(0)
                    dr1 = Nothing
                End If
                Try
                    If sorgu_nMuhasebeFisiAciklamasiKaydi(dr_baslik("dteFisTarihi"), dr_baslik("sMuhFisTipi"), dr_baslik("lFisNo")) = 0 Then
                        tbMuhasebeFisi_Aciklamasi_kaydet_yeni(dr_baslik("dteFisTarihi"), dr_baslik("sMuhFisTipi"), dr("lFisNo"), dr_baslik("sAciklama1"), dr_baslik("sAciklama2"), dr_baslik("sAciklama3"), dr_baslik("sAciklama4"), dr_baslik("sAciklama5"), dr_baslik("bKilitli"))
                    End If
                Catch ex As Exception
                End Try
            End If
        End If
    End Sub
    Private Sub tutarlar_hesapla(Optional ByVal bTarihDegistir As Boolean = False)
        Dim dr As DataRow
        Dim dr1 As DataRow
        If ds_tbMuhasebeFisi.Tables(0).Rows.Count > 0 Then
            Dim sSatirAciklama As String = ""
            Dim sayi As Integer = 0
            For Each dr In ds_tbMuhasebeFisi.Tables(0).Rows
                Try
                    sayi += 1
                    If sayi = 1 Then
                        dr1 = ds_tbMuhasebeFisi.Tables(0).Rows(1)
                        Try
                            sSatirAciklama = dr1("sFirmaAciklama").ToString
                        Catch ex As Exception
                            sSatirAciklama = ""
                        End Try
                    ElseIf sayi = 2 Then
                        dr1 = ds_tbMuhasebeFisi.Tables(0).Rows(0)
                        Try
                            sSatirAciklama = dr1("sFirmaAciklama").ToString
                        Catch ex As Exception
                            sSatirAciklama = ""
                        End Try
                    End If
                    If dr("sAciklama").ToString = "" Then
                        dr("sAciklama") = sSatirAciklama
                    End If
                    If bTarihDegistir = True Then
                        If bMuhasabe = False Then
                            If dr("dteFisTarihi") = dr("dteValorTarihi") Then
                                dr("dteValorTarihi") = dr_baslik("dteFisTarihi")
                            End If
                        End If
                        dr("dteFisTarihi") = dr_baslik("dteFisTarihi")
                    End If
                    If GridView1.FocusedColumn.Name = colnOpsiyon.Name.ToString Then
                        Try
                            dr("dteValorTarihi") = DateAdd(DateInterval.Day, dr("nOpsiyon"), dr("dteFisTarihi"))
                        Catch ex As Exception
                            dr("dteValorTarihi") = dr("dteFisTarihi")
                        End Try
                    Else 'If GridView1.FocusedColumn.Name = colnOpsiyon.Name.ToString Then
                        Try
                            dr("nOpsiyon") = sorgu_sayi(DateDiff(DateInterval.Day, dr("dteFisTarihi"), dr("dteValorTarihi")), 0)
                        Catch ex As Exception
                            dr("nOpsiyon") = 0
                        End Try
                    End If
                    dr("sHareketTipi") = dr_baslik("sHareketTipi")
                    dr("sSubeMagaza") = dr_baslik("sSubeMagaza")
                    tbMuhasebeFisi_kaydet_duzelt(dr("nFisSiraID"), dr("dteFisTarihi"), dr("sMuhFisTipi"), dr("lFisNo"), dr("lYevmiyeNo"), dr("nHesapID"), dr("sAciklama"), dr("lGirenMiktar"), dr("lCikanMiktar"), dr("lBorcTutar"), dr("lAlacakTutar"), dr("sMasrafYontemi"), dr("nKasaID"), dr("sHangiUygulama"), dr("sHareketTipi"), dr("nCariHareketID"), dr("sKullaniciAdi"), dr("dteKayitTarihi"), dr("sDovizCinsi1"), dr("lDovizMiktari1"), dr("lDovizKuru1"), dr("sDovizCinsi2"), dr("lDovizMiktari2"), dr("lDovizKuru2"), dr("nSatir"), dr("sSubeMagaza"), kullaniciadi, Now)
                    If bMuhasabe = False Then
                        'tbFirmaHareketi_kaydet_duzelt(dr("nCariHareketID"), dr("nFirmaID"), dr("dteFisTarihi"), dr("dteValorTarihi"), dr("sCariIslem"), Microsoft.VisualBasic.Left(sSatirAciklama, 50) + "-FNo:" + (dr_baslik("lFisNo")).ToString, dr("lBorcTutar"), dr("lAlacakTutar"), dr_baslik("lFisNo"), 0, "MUH", dr("sHareketTipi").ToString, dr("sKullaniciAdi").ToString, dr("dteKayitTarihi"), dr("sDovizCinsi1"), dr("lDovizMiktari1"), dr("lDovizKuru1"), dr("sDovizCinsi2"), dr("lDovizMiktari2"), dr("lDovizKuru2"), kullaniciadi, Now)
                        tbFirmaHareketi_kaydet_duzelt(dr("nCariHareketID"), dr("nFirmaID"), dr("dteFisTarihi"), dr("dteValorTarihi"), dr("sCariIslem"), Microsoft.VisualBasic.Left(dr("sAciklama"), 50) + "-FNo:" + (dr_baslik("lFisNo")).ToString, dr("lBorcTutar"), dr("lAlacakTutar"), dr_baslik("lFisNo"), 0, "MUH", dr("sHareketTipi").ToString, dr("sKullaniciAdi").ToString, dr("dteKayitTarihi"), dr("sDovizCinsi1"), dr("lDovizMiktari1"), dr("lDovizKuru1"), dr("sDovizCinsi2"), dr("lDovizMiktari2"), dr("lDovizKuru2"), kullaniciadi, Now)
                    End If
                    Try
                        If sorgu_nMuhasebeFisiAciklamasiKaydi(dr_baslik("dteFisTarihi"), dr_baslik("sMuhFisTipi"), dr_baslik("lFisNo")) = 0 Then
                            tbMuhasebeFisi_Aciklamasi_kaydet_yeni(dr_baslik("dteFisTarihi"), dr_baslik("sMuhFisTipi"), dr("lFisNo"), dr_baslik("sAciklama1"), dr_baslik("sAciklama2"), dr_baslik("sAciklama3"), dr_baslik("sAciklama4"), dr_baslik("sAciklama5"), dr_baslik("bKilitli"))
                        End If
                    Catch ex As Exception
                    End Try
                Catch ex As Exception
                End Try
            Next
        End If
    End Sub
    Private Sub analiz_cari_hareket()
        If GridView1.RowCount > 0 Then
            Dim dr As DataRow = GridView1.GetDataRow(GridView1.FocusedRowHandle)
            Dim frm As New frm_cari_hareketler_ozet
            frm.firmano = firmano
            frm.donemno = donemno
            frm.connection = connection
            If bMuhasabe = False Then
                frm.musterino = dr("sFirmaKodu")
            ElseIf bMuhasabe = True Then
                frm.musterino = dr("sHesapKodu")
            End If
            frm.kullanici = kullanici
            frm.bMuhasebe = bMuhasabe
            If yetki_kontrol(kullanici, frm.Name) = True Then
                If yetki_kontrol(kullanici, "frm_firma_liste_hesapTuru_" & Trim(CariHesapTuruSorgula(frm.musterino))) = True Then
                    frm.ShowDialog()
                End If
            End If
            frm.Close()
            frm.Dispose()
            frm = Nothing
        End If
    End Sub
    Private Sub analiz_Firma_karti(Optional ByVal nPage As Int16 = 0)
        If GridView1.RowCount > 0 Then
            Dim dr As DataRow = GridView1.GetDataRow(GridView1.FocusedRowHandle)
            If bMuhasabe = False Then
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
            Else
                Dim frm As New frm_HesapPlani_kart
                frm.firmano = firmano
                frm.donemno = donemno
                frm.connection = connection
                frm.sKodu = dr("sHesapKodu")
                frm.nHesapID = dr("nHesapID")
                frm.kullanici = kullanici
                frm.nPage = nPage
                If yetki_kontrol(kullanici, frm.Name) = True Then
                    frm.ShowDialog()
                End If
                frm.Close()
                frm.Dispose()
                frm = Nothing
            End If
        End If
    End Sub
    Private Sub fis_sec()
        Dim frm As New frm_tbMuhasebeFisi_liste
        frm.firmano = firmano
        frm.donemno = donemno
        frm.connection = connection
        frm.kullanici = kullanici
        frm.islemstatus = True
        If frm.ShowDialog(Me) = Windows.Forms.DialogResult.OK Then
            Dim dr1 As DataRow = frm.GridView1.GetDataRow(frm.GridView1.FocusedRowHandle)
            dr_baslik("dteFisTarihi") = dr1("dtefisTarihi")
            dr_baslik("lYevmiyeNo") = dr1("lYevmiyeNo")
            dr_baslik("lFisNo") = dr1("lFisNo")
            dr1 = Nothing
            Dataload_tbMuhasebeFisi(dr_baslik("dteFisTarihi"), dr_baslik("sMuhFisTipi"), dr_baslik("lFisNo"))
        End If
        frm.Close()
        frm.Dispose()
        frm = Nothing
    End Sub
    Private Sub analiz_Fis_Notu()
        If GridView1.RowCount > 0 Then
            Dim frm As New frm_musteri_karti_aciklama
            frm.firmano = firmano
            frm.donemno = donemno
            frm.connection = connection
            frm.kullanici = kullanici
            frm.tbMuhasebeFisi = True
            frm.sMuhFisTipi = dr_baslik("sMuhFisTipi")
            frm.dteFisTarihi = dr_baslik("dteFisTarihi")
            frm.lFisNo = dr_baslik("lFisNo")
            frm.ShowDialog()
            frm.Close()
            frm.Dispose()
            frm = Nothing
        End If
    End Sub
    Private Sub raporla(ByVal nIslem As Integer)
        Dim OpenFileDialog1 As New Windows.Forms.OpenFileDialog
        OpenFileDialog1.Title = "Rapor Seç..."
        OpenFileDialog1.Filter = "Rapor Dosyalarý (Form*.frx) |Form*.frx"
        OpenFileDialog1.FileName = "c:\Formlar\Raporlar\MuhasebeFisi\Form.frx"
        OpenFileDialog1.InitialDirectory = "c:\Formlar\Raporlar\MuhasebeFisi"
        If OpenFileDialog1.ShowDialog = Windows.Forms.DialogResult.OK Then
            Dim sFile = OpenFileDialog1.FileName.ToString
            Dim report As New FastReport.Report
            report.Load(sFile)
            ds_baslik = sorgu_baslik(dteFisTarihi, sMuhFisTipi, lFisNo)
            VGrid_Baslik.DataSource = ds_baslik.Tables(0)
            If ds_baslik.Tables(0).Rows.Count > 0 Then
                dr_baslik = ds_baslik.Tables(0).Rows(0)
                Dataload_tbMuhasebeFisi(dr_baslik("dteFisTarihi"), dr_baslik("sMuhFisTipi"), dr_baslik("lFisNo"))
            End If
            report.RegisterData(ds_baslik)
            report.RegisterData(ds_tbMuhasebeFisi)
            report.RegisterData(ds_tbMuhasebeFisiToplam)
            report.RegisterData(ds_tbParamGenel)
            report.SetParameterValue("dteFisTarihi", dr_baslik("dteFisTarihi"))
            report.SetParameterValue("lFisNo", dr_baslik("lFisNo"))
            report.SetParameterValue("sMuhFisTipi", dr_baslik("sMuhFisTipi"))
            'report.GetDataSource("BASLIK").Enabled = True
            'report.GetDataSource("Hareket").Enabled = True
            'report.GetDataSource("TOPLAM").Enabled = True
            report.ScriptLanguage = Language.Vb
            If nIslem = 0 Then
                report.Show()
            ElseIf nIslem = 1 Then
                report.Design()
            ElseIf nIslem = 2 Then
                'report.Prepare()
                report.Print()
            ElseIf nIslem = 3 Then
                'report.Prepare()
                report.ScriptLanguage = Language.Vb
                'FastReport.Export.Html.HTMLExport export = new FastReport.Export.Html.HTMLExport();
                'Dim export As New FastReport.Export.Text.TextExportPrinterType
                'export.Active = True
                'If report.Show Then
                '    report.Export(export, "result.txt")
                'End If
            End If
            report.Dispose()
            report = Nothing
        End If
    End Sub
    Private Sub raporla1(ByVal rapor As Integer, ByVal islem As Integer, ByVal dteFisTarihi As DateTime, ByVal sMuhFisTipi As String, ByVal lFisNo As Int64)
        Dim file As String = ""
        Dim kriter As String
        Dim dr As DataRow
        dr = GridView1.GetDataRow(GridView1.FocusedRowHandle)
        kriter = " WHERE (tbMuhasebeFisi.sMuhFisTipi = " & sMuhFisTipi & ") AND (tbMuhasebeFisi.lFisno = " & lFisNo & ") AND (tbMuhasebeFisi.dteFisTarihi = '" & dteFisTarihi & "') "
        OpenFileDialog1.Title = "Rapor Seç..."
        OpenFileDialog1.Filter = "Rapor Dosyalarý (Form*.fr3) |Form*.fr3"
        OpenFileDialog1.FileName = "c:\Formlar\Raporlar\MuhasebeFisi\Form.fr3"
        OpenFileDialog1.InitialDirectory = "c:\Formlar\Raporlar\MuhasebeFisi"
        If OpenFileDialog1.ShowDialog = Windows.Forms.DialogResult.OK Then
            file = OpenFileDialog1.FileName.ToString
            report_create_stok(file, kriter, islem, sMuhFisTipi)
        End If
        file = Nothing
        kriter = Nothing
        dr = Nothing
    End Sub
    Private Sub report_create_stok(ByVal dosya As String, ByVal kriter As String, ByVal status As Integer, ByVal sMuhFisTipi As String)
        Dim stokno = 0
        Dim satir_line = "100"
        If IntPtr.Size = 4 Then
            '32 Bit
            Dim frx As New TfrxReportClass
            Dim qr_hareket As New TfrxADOQuery
            Dim qr_baslik As New TfrxADOQuery
            frx.Resources.LoadLanguageResourcesFromFile("C:\Program Files\FastReports\FastReport Studio\bin\turkish.frc")
            frx.LoadReportFromFile(dosya)
            frx.SetVariable("FIRMANO", "" & firmano & "")
            frx.SetVariable("DONEMNO", "" & donemno & "")
            frx.SetVariable("STOKNO", "" & stokno & "")
            frx.SetVariable("SATIRLINE", "'" & satir_line & "'")
            If sMuhFisTipi = 1 Then
                frx.SetVariable("IZAHAT", "'Tahsilat Fiþi'")
            ElseIf sMuhFisTipi = 2 Then
                frx.SetVariable("IZAHAT", "'Tediye Fiþi'")
            ElseIf sMuhFisTipi = 3 Then
                frx.SetVariable("IZAHAT", "'Mahsup Fiþi'")
            End If
            qr_hareket = frx.FindObject("qr_hareket")
            qr_hareket.Query = sSorguHareket 'sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT tbMuhasebeFisi.*, tbFirma.nFirmaID,tbFirma.sKodu AS sFirmaKodu, tbFirma.sAciklama AS sFirmaAciklama, tbHesapPlani.sKodu AS sHesapKodu, tbHesapPlani.sAciklama AS sHesapAciklama, tbFirmaHareketi.dteValorTarihi AS dteValorTarihi, tbFirmaHareketi.sCariIslem AS sCariIslem, tbFirmaHareketi.sEvrakNo AS sEvrakNo FROM tbMuhasebeFisi INNER JOIN tbFirma ON tbMuhasebeFisi.nHesapID = tbFirma.nHesapID INNER JOIN tbHesapPlani ON tbMuhasebeFisi.nHesapID = tbHesapPlani.nHesapID INNER JOIN tbFirmaHareketi ON tbMuhasebeFisi.nCariHareketID = tbFirmaHareketi.nHareketID " & kriter & " ORDER BY tbMuhasebeFisi.nFisSiraID")
            Dim qr_connection As New TfrxADODatabase
            qr_connection.ConnectionString = connection.ToString
            qr_connection.LoginPrompt = False
            qr_connection.CommandTimeout = Nothing
            qr_connection.Connected = True
            qr_baslik.DataBase = qr_connection
            qr_hareket.DataBase = qr_connection
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
            qr_connection = Nothing
        ElseIf IntPtr.Size = 8 Then
            '64 Bit
            Dim args(50) As String
            Dim processYol As String
            args(0) = "" & dosya & ""
            args(1) = "" & connection.ToString() & ""
            args(2) = "" & sSorguHareket & ""
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
            If sMuhFisTipi = 1 Then
                args(14) = "IZAHAT"
                args(15) = "'Tahsilat Fiþi'"
            ElseIf sMuhFisTipi = 2 Then
                args(14) = "IZAHAT"
                args(15) = "'Tediye Fiþi'"
            ElseIf sMuhFisTipi = 3 Then
                args(14) = "IZAHAT"
                args(15) = "'Mahsup Fiþi'"
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
        kriter += Sorgu_sDil("Muhasebe Fiþi: ", sDil) & dr_baslik("sMuhFisTipi") & vbCrLf
        kriter += Sorgu_sDil("Tarih:", sDil) & dr_baslik("dteFisTarihi") & vbTab
        kriter += Sorgu_sDil("Fiþ No:", sDil) & dr_baslik("lFisNo")
        Printlink1.PageHeaderFooter = New DevExpress.XtraPrinting.PageHeaderFooter(New DevExpress.XtraPrinting.PageHeaderArea(New String() {"[User Name]", kriter, "[Date Printed][Time Printed]"}, New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte)), DevExpress.XtraPrinting.BrickAlignment.Far), New DevExpress.XtraPrinting.PageFooterArea(New String() {"Powered by www.barkodyazilimevi.com", "Muhasebe Yönetimi - Account Manager", "[Page # of Pages #]"}, New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte)), DevExpress.XtraPrinting.BrickAlignment.Near))
        If GridView1.SelectedRowsCount > 1 Then
            GridView1.OptionsPrint.PrintSelectedRowsOnly = True
            Printlink1.CreateDocument(ps)
            ps.PreviewRibbonFormEx.Show()
        Else
            Me.GridView1.OptionsPrint.PrintSelectedRowsOnly = False
            Printlink1.CreateDocument(ps)
            ps.PreviewRibbonFormEx.Show()
        End If
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
    Private Sub GridView1_FocusedColumnChanged(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Base.FocusedColumnChangedEventArgs) Handles GridView1.FocusedColumnChanged
        If sMuhFisTipi = 1 Or sMuhFisTipi = 2 Then
            If GridView1.FocusedRowHandle = 0 Then
                collBorcTutar.OptionsColumn.AllowEdit = False
                collAlacakTutar.OptionsColumn.AllowEdit = False
            Else
                collBorcTutar.OptionsColumn.AllowEdit = True
                collAlacakTutar.OptionsColumn.AllowEdit = True
            End If
        Else
            collBorcTutar.OptionsColumn.AllowEdit = True
            collAlacakTutar.OptionsColumn.AllowEdit = True
        End If
    End Sub
    Private Sub GridView1_FocusedRowChanged(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs) Handles GridView1.FocusedRowChanged
        Try
            satir_kontrol()
        Catch ex As Exception
        End Try
        If sMuhFisTipi = 1 Or sMuhFisTipi = 2 Then
            If GridView1.FocusedRowHandle = 0 Then
                collBorcTutar.OptionsColumn.AllowEdit = False
                collAlacakTutar.OptionsColumn.AllowEdit = False
            Else
                collBorcTutar.OptionsColumn.AllowEdit = True
                collAlacakTutar.OptionsColumn.AllowEdit = True
            End If
        Else
            collBorcTutar.OptionsColumn.AllowEdit = True
            collAlacakTutar.OptionsColumn.AllowEdit = True
        End If
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
        If bMuhasabe = False Then
            satir_ekle()
        ElseIf bMuhasabe = True Then
            muhasebe_satir_ekle()
        End If
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
        raporla(0)
    End Sub
    Private Sub DizaynToolStripMenuItem_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles DizaynToolStripMenuItem.Click
        raporla(1)
    End Sub
    Private Sub YazdýrToolStripMenuItem_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles YazdýrToolStripMenuItem.Click
        raporla(2)
    End Sub
    Private Sub GridControl1_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles GridControl1.KeyDown
        If e.KeyCode = Keys.Escape Then
            If XtraMessageBox.Show(Sorgu_sDil("Muhasebe Fiþi Ekranýndan Çýkmak Ýstediðinize Emin misiniz...?", sDil), Sorgu_sDil("Dikkat", sDil), MessageBoxButtons.YesNo, MessageBoxIcon.Question) = MsgBoxResult.Yes Then
                Me.Close()
            End If
        End If
    End Sub
    Private Sub FisSecToolStripMenuItem_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles FisSecToolStripMenuItem.Click
        fis_sec()
    End Sub
    Private Sub FisNotuToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FisNotuToolStripMenuItem.Click
        analiz_Fis_Notu()
    End Sub
    Private Sub ToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FisSilToolStripMenuItem1.Click
        fis_sil()
    End Sub
    Private Sub BarButtonItem1_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btn_AltSatirEkle.ItemClick
        If bMuhasabe = False Then
            satir_ekle()
        ElseIf bMuhasabe = True Then
            muhasebe_satir_ekle()
        End If
    End Sub
    Private Sub BarButtonItem2_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btn_AltSatirSil.ItemClick
        satir_sil()
    End Sub
    Private Sub BarButtonItem3_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btn_AltFisSil.ItemClick
        fis_sil()
    End Sub
    Private Sub BarButtonItem4_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem4.ItemClick
        analiz_Fis_Notu()
    End Sub
    Private Sub BarButtonItem5_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem5.ItemClick
        raporla(0)
    End Sub
    Private Sub BarButtonItem6_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem6.ItemClick
        gorunum_yazdir()
    End Sub
    Private Sub BarButtonItem7_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem7.ItemClick
        analiz_Firma_karti()
    End Sub
    Private Sub BarButtonItem8_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem8.ItemClick
        analiz_cari_hareket()
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
                If bMuhasabe = True Then
                    muhasebe_satir_ekle()
                Else
                    satir_ekle()
                End If
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
            If bMuhasabe = False Then
                satir_ekle_firma_tek()
            ElseIf bMuhasabe = True Then
                muhasebe_satir_ekle_firma_tek()
            End If
            Label4.Text = "Yeni Hesap Girin..."
        ElseIf kontrol > 1 Then
            If bMuhasabe = False Then
                satir_ekle(Trim(txt_ara.Text), sec_kriter.Text)
            ElseIf bMuhasabe = True Then
                muhasebe_satir_ekle(Trim(txt_ara.Text), sec_kriter.Text)
            End If
            Label4.Text = "Firma Hesabý Satýra Ýþlendi...Yeni Ürün Okutun..."
            Label4.Refresh()
            txt_ara.Text = ""
            txt_ara.Focus()
            txt_ara.SelectAll()
        End If
    End Sub
    Public Function sorgu_Firma_kontrol(ByVal ara As String, ByVal ara_kriter As String) As Int64
        Dim kriter
        If bMuhasabe = True Then
            kriter = "WHERE (tbHesapPlani.sKodu  " & sorgu_kriter_string(ara, ara_kriter) & ") or (tbHesapPlani.sAciklama " & sorgu_kriter_string(ara, ara_kriter) & ") "
        Else
            kriter = "WHERE (tbFirma.sKodu  " & sorgu_kriter_string(ara, ara_kriter) & ") or (tbFirma.sAciklama " & sorgu_kriter_string(ara, ara_kriter) & ") "
        End If
        Dim conn As New OleDb.OleDbConnection
        Dim cmd As New OleDb.OleDbCommand
        Dim adapter As New OleDb.OleDbDataAdapter
        conn.ConnectionString = connection
        cmd.Connection = conn
        conn.Open()
        If bMuhasabe = True Then
            cmd.CommandText = sorgu_query("SET DATEFORMAT DMY SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT     ISNULL(COUNT(*), 0) AS KAYIT FROM         tbHesapPlani " & kriter & "")
        Else
            cmd.CommandText = sorgu_query("SET DATEFORMAT DMY SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT     ISNULL(COUNT(*), 0) AS KAYIT FROM         tbFirma " & kriter & "")
        End If
        Dim kayitsayisi = cmd.ExecuteScalar
        Return kayitsayisi
        conn.Dispose()
        cmd.Dispose()
        adapter.Dispose()
        cmd = Nothing
        adapter = Nothing
    End Function
    Private Sub dataload_tbFirma(ByVal ara As String, ByVal ara_kriter As String, Optional ByVal bKodu As Boolean = False)
        Dim kriter
        If bMuhasabe = False Then
            If bKodu = True Then
                kriter = "WHERE (tbFirma.sKodu  " & sorgu_kriter_string(ara, ara_kriter) & ")  "
            Else
                kriter = "WHERE (tbFirma.sKodu  " & sorgu_kriter_string(ara, ara_kriter) & ") or (tbFirma.sAciklama " & sorgu_kriter_string(ara, ara_kriter) & ") "
            End If
            ds_Firma = sorgu(sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT tbFirma.nFirmaID, tbFirma.sKodu, tbFirma.sAciklama, tbFirma.sSaticiRumuzu,tbFirma.nOzelIskontosu,tbFirma.nOzelIskontosu2,tbFirma.nOzelIskontosu3,tbFirma.nOzelIskontosu4,tbFirma.sFiyatTipi, tbFirma.sDovizCinsi,tbFirma.lKrediLimiti, tbFirma.sSemt,tbFirma.sIl,tbFirma.sUlke,tbFirma.sPostaKodu,tbFirma.nVadeGun,tbFirma.sAdres1,tbFirma.sAdres2,tbFirma.sAdres1 + ' ' + tbFirma.sAdres2 + ' ' + tbFirma.sSemt + ' ' + tbFirma.sIl + ' ' + tbFirma.sUlke + ' ' + tbFirma.sPostaKodu AS Adres, tbFirma.sVergiDairesi, tbFirma.sVergiNo, tbFirmaAciklamasi.sAciklama1 + ' ' + tbFirmaAciklamasi.sAciklama2 + ' ' + tbFirmaAciklamasi.sAciklama3 + ' ' + tbFirmaAciklamasi.sAciklama4 + ' ' + tbFirmaAciklamasi.sAciklama5 AS ISTIHBARAT, tbFSinif1.sAciklama AS SINIF1, tbFSinif2.sAciklama AS SINIF2, tbFSinif3.sAciklama AS SINIF3, tbFSinif4.sAciklama AS SINIF4, tbFSinif5.sAciklama AS SINIF5, (SELECT ISNULL(SUM(lBorcTutar - lAlacakTutar) , 0) AS lBakiye FROM tbFirmaHareketi WHERE nFirmaID = tbFirma.nFirmaID) AS lBakiye, tbHesapPlani.nHesapID, tbHesapPlani.sKodu AS sHesapKodu, tbHesapPlani.sAciklama AS sHesapAciklama,(SELECT     TOP 1 sIletisimAdresi FROM          tbFirmaIletisimi WHERE      nFirmaId = tbFirma.nFirmaID AND sIletisimAraci = 'E-Mail') AS [E-Mail],(SELECT     TOP 1 sIletisimAdresi FROM          tbFirmaIletisimi WHERE      nFirmaId = tbFirma.nFirmaID AND sIletisimAraci = 'Fax') AS [Fax],(SELECT     TOP 1 sIletisimAdresi FROM          tbFirmaIletisimi WHERE      nFirmaId = tbFirma.nFirmaID AND sIletisimAraci = 'Gsm') AS [Gsm],(SELECT     TOP 1 sIletisimAdresi FROM          tbFirmaIletisimi WHERE      nFirmaId = tbFirma.nFirmaID AND sIletisimAraci = 'Telefon') AS [Telefon],(SELECT     TOP 1 sIletisimAdresi FROM          tbFirmaIletisimi WHERE      nFirmaId = tbFirma.nFirmaID AND sIletisimAraci = 'Web') AS [Web],(SELECT     TOP 1 sIletisimAdresi FROM          tbFirmaIletisimi WHERE      nFirmaId = tbFirma.nFirmaID AND sIletisimAraci = 'Yetkili') AS [Yetkili] FROM tbFirmaAciklamasi RIGHT OUTER JOIN tbFirma INNER JOIN tbHesapPlani ON tbFirma.nHesapID = tbHesapPlani.nHesapID ON tbFirmaAciklamasi.nFirmaID = tbFirma.nFirmaID LEFT OUTER JOIN tbFSinif1 INNER JOIN tbFirmaSinifi ON tbFSinif1.sSinifKodu = tbFirmaSinifi.sSinifKodu1 INNER JOIN tbFSinif2 ON tbFirmaSinifi.sSinifKodu2 = tbFSinif2.sSinifKodu INNER JOIN tbFSinif3 ON tbFirmaSinifi.sSinifKodu3 = tbFSinif3.sSinifKodu INNER JOIN tbFSinif4 ON tbFirmaSinifi.sSinifKodu4 = tbFSinif4.sSinifKodu INNER JOIN tbFSinif5 ON tbFirmaSinifi.sSinifKodu5 = tbFSinif5.sSinifKodu ON tbFirma.nFirmaID = tbFirmaSinifi.nFirmaID " & kriter & " ORDER BY tbFirma.sKodu"))
        ElseIf bMuhasabe = True Then
            If bKodu = True Then
                kriter = "WHERE (tbHesapPlani.sKodu  " & sorgu_kriter_string(ara, ara_kriter) & ") "
            Else
                kriter = "WHERE (tbHesapPlani.sKodu  " & sorgu_kriter_string(ara, ara_kriter) & ") or (tbHesapPlani.sAciklama " & sorgu_kriter_string(ara, ara_kriter) & ") "
            End If
            ds_Firma = sorgu(sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT tbHesapPlani.nHesapID, tbHesapPlani.sKodu, tbHesapPlani.sAciklama, tbHesapPlani.sAlterneAciklama, (SELECT ISNULL(SUM(lBorcTutar - lAlacakTutar) , 0) AS lBakiye FROM tbMuhasebeFisi WHERE nHesapID = tbHesapPlani.nHesapID) AS lBakiye, ISNULL(tbFirma.nFirmaID, 0) AS nFirmaID, ISNULL(tbFirma.sKodu, '') AS sFirmaKodu, ISNULL(tbFirma.sAciklama, '') AS sFirmaAciklama FROM tbFirma RIGHT OUTER JOIN tbHesapPlani ON tbFirma.nHesapID = tbHesapPlani.nHesapID " & kriter & " ORDER BY tbHesapPlani.sKodu"))
        End If
    End Sub
    Private Sub hesap_sec(Optional ByVal bkasa As Boolean = False)
        Dim frm As New frm_HesapPlani_liste
        frm.firmano = firmano
        frm.donemno = donemno
        frm.connection = connection
        'frm.sKodu = dr_baslik("FIRMAKODU")
        frm.islemstatus = True
        frm.kullanici = kullanici
        If bkasa = True Then
            frm.txt_ara.Text = "100"
            frm.sec_konum.Text = "Kodu"
            frm.sec_kriter.Text = "Baþlar"
        End If
        If frm.ShowDialog(Me) = Windows.Forms.DialogResult.OK Then
            Dim dr1 As DataRow
            Dim dr As DataRow
            dr1 = frm.GridView1.GetDataRow(frm.GridView1.FocusedRowHandle)
            dr = GridView1.GetDataRow(GridView1.FocusedRowHandle)
            dr("nHesapID") = dr1("nHesapID")
            dr("nFirmaID") = dr1("nFirmaID")
            dr("sFirmaKodu") = dr1("sFirmaKodu")
            dr("sFirmaAciklama") = dr1("sFirmaAciklama")
            dr("sHesapKodu") = dr1("sKodu")
            dr("sHesapAciklama") = dr1("sAciklama")
            tutar_hesapla()
        Else
        End If
    End Sub
    Private Sub firma_sec(ByVal sAra As String)
        Dim frm As New frm_firma_liste
        frm.islemstatus = True
        frm.connection = connection
        frm.firmano = firmano
        frm.donemno = donemno
        frm.islemstatus = True
        frm.kullanici = kullanici
        status = True
        If sModul = "Cari" Then
            frm.sModul = "MuhasebeCari"
        ElseIf sModul = "Banka" Then
            frm.sModul = "MuhasebeBanka"
        End If
        If frm.ShowDialog(Me) = Windows.Forms.DialogResult.OK Then
            Dim dr1 As DataRow
            Dim dr As DataRow
            dr1 = frm.GridView1.GetDataRow(frm.GridView1.FocusedRowHandle)
            dr = GridView1.GetDataRow(GridView1.FocusedRowHandle)
            dr("nHesapID") = dr1("nHesapID")
            dr("nFirmaID") = dr1("nFirmaID")
            dr("sFirmaKodu") = dr1("sKodu")
            dr("sFirmaAciklama") = dr1("sAciklama")
            dr("sHesapKodu") = dr1("sKodu")
            dr("sHesapAciklama") = dr1("sAciklama")
            dr("sAciklama") = dr1("sAciklama")
            tutar_hesapla()
        End If
    End Sub
    Private Sub VGrid_Baslik_CellValueChanged(ByVal sender As Object, ByVal e As DevExpress.XtraVerticalGrid.Events.CellValueChangedEventArgs) Handles VGrid_Baslik.CellValueChanged
        Try
            VGrid_Baslik.UpdateFocusedRecord()
            VGrid_Baslik.CloseEditor()
            Try
                If sorgu_nMuhasebeFisiAciklamasiKaydi(dr_baslik("dteFisTarihi"), dr_baslik("sMuhFisTipi"), dr_baslik("lFisNo")) = 0 Then
                    tbMuhasebeFisi_Aciklamasi_kaydet_yeni(dr_baslik("dteFisTarihi"), dr_baslik("sMuhFisTipi"), dr_baslik("lFisNo"), dr_baslik("sAciklama1"), dr_baslik("sAciklama2"), dr_baslik("sAciklama3"), dr_baslik("sAciklama4"), dr_baslik("sAciklama5"), dr_baslik("bKilitli"))
                End If
            Catch ex As Exception
            End Try
            If dr_baslik("dteFisTarihi") <> dr_baslik("FisTarihi") Then
                tbMuhasebeFisi_Aciklamasi_kaydet_duzelt(dr_baslik("dteFisTarihi"), dr_baslik("sMuhFisTipi"), dr_baslik("lFisNo"), dr_baslik("sAciklama1"), dr_baslik("sAciklama2"), dr_baslik("sAciklama3"), dr_baslik("sAciklama4"), dr_baslik("sAciklama5"), dr_baslik("FisTarihi"), dr_baslik("bKilitli"))
                dr_baslik("FisTarihi") = dr_baslik("dteFisTarihi")
                tutarlar_hesapla(True)
            End If
            tbMuhasebeFisi_Aciklamasi_kaydet_duzelt(dr_baslik("dteFisTarihi"), dr_baslik("sMuhFisTipi"), dr_baslik("lFisNo"), dr_baslik("sAciklama1"), dr_baslik("sAciklama2"), dr_baslik("sAciklama3"), dr_baslik("sAciklama4"), dr_baslik("sAciklama5"), dr_baslik("FisTarihi"), dr_baslik("bKilitli"))
            tutarlar_hesapla()
        Catch ex As Exception
            XtraMessageBox.Show(Sorgu_sDil("Ýþlem Hatasý Lütfen Bilgileri Kontrol Edip Tekrar Deneyiniz...!", sDil), Sorgu_sDil("Dikkat", sDil), MessageBoxButtons.OK, MessageBoxIcon.Information)
        End Try
    End Sub
    Private Sub BarButtonItem11_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem11.ItemClick
        raporla(0)
    End Sub
    Private Sub BarButtonItem12_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem12.ItemClick
        raporla(1)
    End Sub
    Private Sub BarButtonItem13_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem13.ItemClick
        raporla(2)
    End Sub
    Private Sub BarButtonItem14_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btn_FisSil.ItemClick
        fis_sil()
    End Sub
    Private Sub BarButtonItem15_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btn_SatirEkle.ItemClick
        If bMuhasabe = True Then
            muhasebe_satir_ekle()
        Else
            satir_ekle()
        End If
    End Sub
    Private Sub BarButtonItem17_ItemClick(ByVal sender As Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btn_SatirSil.ItemClick
        satir_sil()
    End Sub
    Private Sub BarButtonItem18_ItemClick(ByVal sender As Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btn_DegerYay.ItemClick
        If GridView1.RowCount > 0 Then
            If XtraMessageBox.Show(Sorgu_sDil("[" & GridView1.FocusedColumn().Caption & "] Kolonundaki verileri Aþaðý Doðru Yaymak istediðinize Emin misiniz...?", sDil), Sorgu_sDil("Dikkat", sDil), MessageBoxButtons.YesNo, MessageBoxIcon.Question) = MsgBoxResult.Yes Then
                Cursor.Current = Cursors.WaitCursor
                Cursor.Show()
                degeryay(GridView1.FocusedColumn().FieldName, True)
                Cursor.Current = Cursors.Default
                Cursor.Hide()
            End If
        End If
    End Sub
    Private Sub BarButtonItem19_ItemClick(ByVal sender As Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btn_BakiyeKapat.ItemClick
        Dim lBakiye As Decimal = 0
        lBakiye = sorgu_lBakiye(dr_baslik("dteFisTarihi"), dr_baslik("sMuhFisTipi"), dr_baslik("lFisNo"))
        If lBakiye <> 0 Then
            Dim dr1 As DataRow = ds_tbMuhasebeFisiToplam.Tables(0).Rows(0)
            Dim dr As DataRow = GridView1.GetDataRow(GridView1.FocusedRowHandle)
            If dr("lBorcTutar") - dr("lAlacakTutar") = 0 Then
                If lBakiye > 0 Then
                    dr("lAlacakTutar") = dr("lAlacakTutar") + lBakiye
                Else
                    dr("lBorcTutar") = dr("lBorcTutar") + Math.Abs(lBakiye)
                End If
            ElseIf dr("lBorcTutar") - dr("lAlacakTutar") < 0 Then
                If lBakiye < 0 Then
                    dr("lAlacakTutar") = dr("lAlacakTutar") + lBakiye
                Else
                    dr("lBorcTutar") = dr("lBorcTutar") + lBakiye
                End If
            ElseIf dr("lBorcTutar") - dr("lAlacakTutar") > 0 Then
                If lBakiye > 0 Then
                    dr("lAlacakTutar") = dr("lAlacakTutar") + lBakiye
                Else
                    dr("lBorcTutar") = dr("lBorcTutar") - lBakiye
                End If
            End If
            tutar_hesapla()
        End If
    End Sub
    Private Sub BarButtonItem20_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btn_Taksitlendir.ItemClick
        Dim nTaksit As String = InputBox("Taksit Sayýsýný Gir", "Taksit Sayýsý", 1)
        If nTaksit = "" Then
            nTaksit = 0
        End If
        If nTaksit > 1 Then
            If XtraMessageBox.Show(Sorgu_sDil("Satýrý " & nTaksit & " Taksite Bölmek Ýstediðinize Emin misiniz...?", sDil), Sorgu_sDil("Dikkat", sDil), MessageBoxButtons.YesNo, MessageBoxIcon.Question) = MsgBoxResult.Yes Then
                Satir_Kopyala(nTaksit)
            End If
        End If
    End Sub
    Private Sub Satir_Kopyala(ByVal nTaksit As Integer)
        Dim i As Integer = 1
        Dim dr As DataRow = GridView1.GetDataRow(GridView1.FocusedRowHandle)
        If dr("lBorcTutar") <> 0 Then
        ElseIf dr("lAlacakTutar") <> 0 Then
        End If
        For i = 1 To nTaksit
            Dim nFisSiraID As Int64 = sorgu_nFisSiraID()
            Dim nCariHareketID = sorgu_nCariHareketID()
            If bMuhasabe = False Then
                nCariHareketID = tbFirmaHareketi_kaydet_yeni(nCariHareketID, dr("nFirmaID"), dr("dteFisTarihi"), dr("dteFisTarihi"), "", Microsoft.VisualBasic.Left(dr("sAciklama"), 50) + "-FNo:" + (dr_baslik("lFisNo")).ToString, dr("lBorcTutar"), dr("lAlacakTutar"), dr_baslik("lFisNo"), 0, "MUH", dr("sHareketTipi"), dr("sKullaniciAdi"), dr("dteKayitTarihi"), "", 0, 0, "", 0, 0, dr("sKullaniciAdi"), dr("dteSonUpdateTarihi"))
                nCariHareketID_degistir(nCariHareketID)
                nFisSiraID = tbMuhasebeFisi_kaydet_yeni(nFisSiraID, dr("dteFisTarihi"), dr("sMuhFisTipi"), dr("lFisNo"), dr("lYevmiyeNo"), dr("nHesapID"), dr("sAciklama"), dr("lGirenMiktar"), dr("lCikanMiktar"), dr("lBorcTutar"), dr("lAlacakTutar"), dr("sMasrafYontemi"), dr("nKasaID"), dr("sHangiUygulama"), dr("sHareketTipi"), nCariHareketID, dr("sKullaniciAdi"), dr("dteKayitTarihi"), dr("sDovizCinsi1"), dr("lDovizMiktari1"), dr("lDovizKuru1"), dr("sDovizCinsi2"), dr("lDovizMiktari2"), dr("lDovizKuru2"), dr("nSatir"), dr("sSubeMagaza"), dr("sSonKullaniciAdi"), dr("dteSonUpdateTarihi"))
                nFisSiraID_degistir(nFisSiraID)
            ElseIf bMuhasabe = True Then
                nFisSiraID = tbMuhasebeFisi_kaydet_yeni(nFisSiraID, dr("dteFisTarihi"), dr("sMuhFisTipi"), dr("lFisNo"), dr("lYevmiyeNo"), dr("nHesapID"), dr("sAciklama"), dr("lGirenMiktar"), dr("lCikanMiktar"), dr("lBorcTutar"), dr("lAlacakTutar"), dr("sMasrafYontemi"), dr("nKasaID"), dr("sHangiUygulama"), dr("sHareketTipi"), dr("nCariHareketID"), dr("sKullaniciAdi"), dr("dteKayitTarihi"), dr("sDovizCinsi1"), dr("lDovizMiktari1"), dr("lDovizKuru1"), dr("sDovizCinsi2"), dr("lDovizMiktari2"), dr("lDovizKuru2"), dr("nSatir"), dr("sSubeMagaza"), dr("sSonKullaniciAdi"), dr("dteSonUpdateTarihi"))
                nFisSiraID_degistir(nFisSiraID)
            End If
        Next
        Dataload_tbMuhasebeFisi(dr_baslik("dteFisTarihi"), dr_baslik("sMuhFisTipi"), dr_baslik("lFisNo"))
        XtraMessageBox.Show(Sorgu_sDil("Baþarýyla Tamamlandý...", sDil), Sorgu_sDil("Dikkat", sDil), MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub
    Private Sub BarButtonItem16_ItemClick(ByVal sender As Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btn_SatirDuzelt.ItemClick
        satir_degistir()
    End Sub
    Private Sub satir_degistir()
        If sMuhFisTipi = 1 Or sMuhFisTipi = 2 Then
            If GridView1.FocusedRowHandle = 0 Then
                hesap_sec(True)
            Else
                hesap_sec(False)
            End If
        ElseIf sMuhFisTipi = 3 Then
            If bMuhasabe = False Then
                firma_sec("")
            Else
                hesap_sec(False)
            End If
        End If
    End Sub
    Private Sub BarButtonItem21_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem21.ItemClick
        VGrid_Baslik.RowsCustomization()
    End Sub
    Private Sub BarButtonItem22_ItemClick(ByVal sender As Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem22.ItemClick
        GridView1.ColumnsCustomization()
    End Sub
    Private Sub BarButtonItem23_ItemClick(ByVal sender As Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem23.ItemClick
        VGrid_Toplam.RowsCustomization()
    End Sub
    Private Sub BarButtonItem24_ItemClick(ByVal sender As Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem24.ItemClick
        gorunum_kaydet()
    End Sub
    Private Sub BarButtonItem25_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem25.ItemClick
        raporla(3)
    End Sub
    Private Sub BarButtonItem1_ItemClick_1(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem1.ItemClick
        calc()
    End Sub
    Public Sub calc()
        Dim frm As New frm_calc
        If frm.ShowDialog = DialogResult.OK Then
            Dim dr As DataRow = GridView1.GetDataRow(GridView1.FocusedRowHandle)
            If GridView1.FocusedColumn.OptionsColumn.AllowEdit = True Then
                dr(GridView1.FocusedColumn().FieldName) = frm.CalcEdit1.EditValue
                tutar_hesapla()
            End If
        End If
        frm.Close()
        frm = Nothing
    End Sub
    Private Sub fis_kopyala()
        Dim frm As New frm_fatura_kopyala
        frm.firmano = firmano
        frm.donemno = donemno
        frm.connection = connection
        frm.sFisTipi = sMuhFisTipi
        frm.nGirisCikis = 3
        frm.kapla = True
        'frm.nFirmaID = dr_baslik("nFirmaID")
        'frm.sKodu = dr_baslik("sKodu")
        'frm.txt_musteriNo.EditValue = dr_baslik("sKodu")
        frm.lbl_Firma.Text = Sorgu_sDil("Mahsup Fiþi", sDil)
        frm.txt_dteFisTarihi1.EditValue = dr_baslik("dteFisTarihi")
        frm.txt_lFisNo.Text = dr_baslik("lFisNo")
        If frm.ShowDialog(Me) = Windows.Forms.DialogResult.OK Then
            If XtraMessageBox.Show(dr_baslik("lFisNo") & Sorgu_sDil(" Nolu Fiþi ", sDil) & Sorgu_sDil(" Kopyalamaya Baþlamak Ýstediðinize Emin misiniz...?", sDil), Sorgu_sDil("Dikkat", sDil), MessageBoxButtons.YesNo, MessageBoxIcon.Question) = MsgBoxResult.Yes Then
                Dim enlFisno = dr_baslik("lFisNo")
                Dim esMuhFisTipi = sMuhFisTipi
                Dim esYevmiyeNo = dr_baslik("lYevmiyeNo")
                Dim edteFisTarihi = dr_baslik("dteFisTarihi")
                Dim dr As DataRow
                lFisNo = sorgu_lFisNo()
                lYevmiyeNo = sorgu_lFisNo()
                dteFisTarihi = frm.txt_dteFisTarihi1.EditValue
                Dim sHangiUygulama As String = ""
                For Each dr In ds_tbMuhasebeFisi.Tables(0).Rows
                    Dim nCariHareketID = sorgu_nCariHareketID()
                    Dim nFisSiraID = sorgu_nFisSiraID()
                    sHangiUygulama = Trim(dr("sHangiUygulama"))
                    If sHangiUygulama = "CHS" Then
                        nCariHareketID = tbFirmaHareketi_kaydet_yeni(nCariHareketID, dr("nFirmaID"), dteFisTarihi, dteFisTarihi, "", Microsoft.VisualBasic.Left(dr("sAciklama"), 50) + "-FNo:" + (lFisNo).ToString, dr("lBorcTutar"), dr("lAlacakTutar"), lFisNo, 0, "MUH", dr("sHareketTipi"), kullaniciadi, Now, "", 0, 0, "", 0, 0, kullaniciadi, Now)
                        nCariHareketID_degistir(nCariHareketID)
                    Else
                    End If
                    nFisSiraID = tbMuhasebeFisi_kaydet_yeni(nFisSiraID, dteFisTarihi, sMuhFisTipi, lFisNo, lYevmiyeNo, dr("nHesapID"), dr("sAciklama"), dr("lGirenMiktar"), dr("lCikanMiktar"), dr("lBorcTutar"), dr("lAlacakTutar"), dr("sMasrafYontemi"), dr("nKasaID"), dr("sHangiUygulama"), dr("sHareketTipi"), nCariHareketID, kullaniciadi, Now, dr("sDovizCinsi1"), dr("lDovizMiktari1"), dr("lDovizKuru1"), dr("sDovizCinsi2"), dr("lDovizMiktari2"), dr("lDovizKuru2"), dr("nSatir"), dr("sSubeMagaza"), kullaniciadi, Now)
                    nFisSiraID_degistir(nFisSiraID)
                Next
                Try
                    tbMuhasebeFisi_Aciklamasi_kaydet_yeni(dteFisTarihi, sMuhFisTipi, lFisNo, dr_baslik("sAciklama1"), dr_baslik("sAciklama2"), dr_baslik("sAciklama3"), dr_baslik("sAciklama4"), dr_baslik("sAciklama5"), 0)
                Catch ex As Exception
                End Try
                analiz_fis(dteFisTarihi, lFisNo, lYevmiyeNo, sHangiUygulama, sMuhFisTipi)
                dteFisTarihi = edteFisTarihi
                lFisNo = enlFisno
                lYevmiyeNo = esYevmiyeNo
                'Dim enConnection = connection
            End If
        End If
    End Sub
    Private Sub analiz_fis(ByVal dteFisTarihi As DateTime, ByVal lFisNo As Int64, ByVal lYevmiyeNo As Int64, ByVal sHangiUygulama As String, ByVal sMuhFisTipi As String)
        Dim frm As New frm_tbMuhasebeFisi
        frm.firmano = firmano
        frm.donemno = donemno
        frm.connection = connection
        frm.dteFisTarihi = dteFisTarihi
        frm.lFisNo = lFisNo
        frm.lYevmiyeNo = lYevmiyeNo
        If sHangiUygulama = "MUH" Then
            frm.bMuhasabe = True
        ElseIf sHangiUygulama = "CHS" Then
            frm.bMuhasabe = False
        End If
        frm.sMuhFisTipi = sMuhFisTipi
        frm.kullanici = kullanici
        frm.sModul = sModul
        frm.Text = "Fis#Kopya"
        If yetki_kontrol(kullanici, frm.Name) = True Then
            frm.ShowDialog()
        End If
        frm.Close()
        frm.Dispose()
        frm = Nothing
    End Sub
    Private Sub raporla_excel()
        If XtraMessageBox.Show(Sorgu_sDil("Sonuçlarý Excel Dosyasý Oluþturmak Ýstediðinize Emin misiniz...?", sDil), Sorgu_sDil("Dikkat", sDil), MessageBoxButtons.YesNo, MessageBoxIcon.Question) = MsgBoxResult.Yes Then
            Dim SaveFileDialog1 As New Windows.Forms.SaveFileDialog
            SaveFileDialog1.Filter = "Excel Dosyalarý(*.xls) |*.xls"
            SaveFileDialog1.InitialDirectory = "c:\"
            'SaveFileDialog1.FileName = Trim(dr_baslik("sFisTipi")) & "_" & dr_baslik("dteFisTarihi") & "_" & dr_baslik("lFisNo") & ".xls"
            SaveFileDialog1.FileName = Trim(dr_baslik("sMuhFisTipi")) & "_" & dr_baslik("lFisNo") & ".xls"
            If SaveFileDialog1.ShowDialog = Windows.Forms.DialogResult.OK Then
                GridView1.ExportToXls(SaveFileDialog1.FileName.ToString)
                If XtraMessageBox.Show(Sorgu_sDil("Kaydý Açmak Ýster misiniz...?", sDil), Sorgu_sDil("Dikkat", sDil), MessageBoxButtons.YesNo, MessageBoxIcon.Question) = MsgBoxResult.Yes Then
                    Process.Start(SaveFileDialog1.FileName.ToString)
                End If
            End If
            SaveFileDialog1 = Nothing
        End If
    End Sub
    Private Sub raporla_excel_csv()
        If XtraMessageBox.Show(Sorgu_sDil("Sonuçlarý Excel Csv Dosyasý Oluþturmak Ýstediðinize Emin misiniz...?", sDil), Sorgu_sDil("Dikkat", sDil), MessageBoxButtons.YesNo, MessageBoxIcon.Question) = MsgBoxResult.Yes Then
            Dim SaveFileDialog1 As New Windows.Forms.SaveFileDialog
            SaveFileDialog1.Filter = "Excel Dosyalarý(*.csv) |*.csv"
            SaveFileDialog1.InitialDirectory = "c:\"
            'SaveFileDialog1.FileName = Trim(dr_baslik("sFisTipi")) & "_" & dr_baslik("dteFisTarihi") & "_" & dr_baslik("lFisNo") & ".csv"
            SaveFileDialog1.FileName = Trim(dr_baslik("sMuhFisTipi")) & "_" & dr_baslik("lFisNo") & ".csv"
            If SaveFileDialog1.ShowDialog = Windows.Forms.DialogResult.OK Then
                'GridView1.ExportToExcelOld(SaveFileDialog1.FileName.ToString)
                Printlink1.CreateDocument(ps)
                ps.ExportToCsv(SaveFileDialog1.FileName.ToString)
                'ps.PreviewRibbonFormEx.ShowDialog()
                If XtraMessageBox.Show(Sorgu_sDil("Kaydý Açmak Ýster misiniz...?", sDil), Sorgu_sDil("Dikkat", sDil), MessageBoxButtons.YesNo, MessageBoxIcon.Question) = MsgBoxResult.Yes Then
                    Process.Start(SaveFileDialog1.FileName.ToString)
                End If
            End If
            SaveFileDialog1 = Nothing
        End If
    End Sub
    Private Sub BarButtonItem15_ItemClick_1(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem15.ItemClick
        raporla_excel()
    End Sub
    Private Sub BarButtonItem16_ItemClick_1(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem16.ItemClick
        raporla_excel_csv()
    End Sub
    Private Sub BarButtonItem2_ItemClick_1(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem2.ItemClick
        gorunum_dil_degistir("AR")
    End Sub
    Private Sub BarButtonItem3_ItemClick_1(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem3.ItemClick
        gorunum_dil_degistir("EN")
    End Sub
    Private Sub BarButtonItem14_ItemClick_1(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem14.ItemClick
        gorunum_dil_degistir("TR")
    End Sub
    Private Sub BarButtonItem17_ItemClick_1(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem17.ItemClick
        fis_kopyala()
    End Sub
    Private Sub frm_tbMuhasebeFisi_LocationChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.LocationChanged
    End Sub
    Private Sub BarButtonItem18_ItemClick_1(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem18.ItemClick
        muhasebe_Kdv_satir_ekle()
    End Sub
    Private Sub BarButtonItem19_ItemClick_1(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem19.ItemClick
        Dim frm As New frm_tbMuhasebeFisi_Yardim
        frm.Show()
    End Sub
    Private Sub BarButtonItem20_ItemClick_1(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem20.ItemClick
        analiz_Firma_karti(5)
    End Sub
    Private Sub BarButtonItem26_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem26.ItemClick
        analiz_Firma_karti(4)
    End Sub
    Private Sub BarButtonItem27_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem27.ItemClick
        analiz_eksik_satirlar()
    End Sub
    Private Sub analiz_eksik_satirlar()
        Dim ds_EksikSatir As DataSet = sorgu(sorgu_query("SET DATEFORMAT DMY SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT sAciklama, SUM(lBorcTutar - lAlacakTutar) AS lBakiye FROM tbMuhasebeFisi WHERE (lFisno = " & lFisNo & ") AND (sMuhFisTipi = " & sMuhFisTipi & ") and (dteFisTarihi = '" & dteFisTarihi & "') GROUP BY sAciklama HAVING (SUM(lBorcTutar - lAlacakTutar) <> 0)"))
        Dim dr1 As DataRow
        Dim s As String = ""
        Dim s1 As String = ""
        Dim nSayi As Integer = 0
        For Each dr1 In ds_EksikSatir.Tables(0).Rows
            nSayi += 1
            s1 = dr1("sAciklama")
            s += nSayi & "-" & dr1("sAciklama") & vbCrLf
        Next
        XtraMessageBox.Show("Hatalý/Eksik Satýrlar;" & vbCrLf & s, Sorgu_sDil("Dikkat", sDil), MessageBoxButtons.OK, MessageBoxIcon.Warning)
        If Trim(s1) <> "" Then
            GridView1.ClearColumnsFilter()
            GridView1.Columns("sAciklama").FilterInfo = New ColumnFilterInfo("[sAciklama] LIKE '" & s1 & "%'")
            GridView1.FocusedRowHandle = 0
            GridView1.Focus()
            GridView1.FocusedColumn = colsCariIslem
        Else
            GridView1.ClearColumnsFilter()
        End If
    End Sub
    Private Sub fis_al()
        Dim frm As New frm_fatura_kopyala
        frm.firmano = firmano
        frm.donemno = donemno
        frm.connection = connection
        frm.sFisTipi = sMuhFisTipi
        frm.nGirisCikis = 3
        frm.kapla = True
        frm.nFirmaID = 0
        frm.sKodu = ""
        frm.txt_musteriNo.EditValue = ""
        frm.lbl_Firma.Text = ""
        frm.txt_dteFisTarihi1.EditValue = dteFisTarihi
        frm.txt_lFisNo.Text = lFisNo
        frm.bAktar = True
        frm.bMuhasebe = True
        Dim enConnection = connection
        If frm.ShowDialog(Me) = Windows.Forms.DialogResult.OK Then
            If XtraMessageBox.Show(Sorgu_sDil("Aktarým Ýþlemine Baþlamak Ýstediðinize Emin misiniz...?", sDil), Sorgu_sDil("Dikkat", sDil), MessageBoxButtons.YesNo, MessageBoxIcon.Question) = MsgBoxResult.Yes Then
                connection = frm.sUzakConnection
                firmano = frm.txt_nFirmaNo.Text
                donemno = frm.txt_nDonemNo.Text
                Dim ds_MuhasebeAktarim As DataSet = sorgu(sorgu_query("SET DATEFORMAT DMY SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED  SELECT     * FROM         F0115D0006TBLISLEM WHERE     (TARIH = '" & frm.txt_dteFisTarihi1.EditValue & "') AND (YEVMIYE = " & frm.txt_lFisNo.Text & ")"))
                connection = enConnection
                Dim nHesapID As Int64 = 0
                Dim sKodu As String = ""
                Dim sFirmaAciklama As String = ""
                Dim sAciklama As String = ""
                Dim lGirenMiktar As Decimal = 0
                Dim lCikanMiktar As Decimal = 0
                Dim lBorcTutar As Decimal = 0
                Dim lAlacakTutar As Decimal = 0
                Dim nFisSiraID As Int64 = 0
                Dim nSatir As Integer = 0
                Dim dr As DataRow
                For Each dr In ds_MuhasebeAktarim.Tables(0).Rows
                    sKodu = Replace(dr("HESAPKODU"), "XX", "-")
                    sKodu = Replace(sKodu, "X", "-")
                    sFirmaAciklama = dr("HESAPADI")
                    Dim sAyrac As String = ""
                    If sKodu.Contains(".") = True Then
                        sAyrac = "."
                    ElseIf sKodu.Contains("-") = True Then
                        sAyrac = "-"
                    End If
                    Dim strArr() As String
                    Dim str As String
                    Dim count As Integer
                    Dim kod As String = ""
                    Dim kod1 As String = ""
                    Dim kod2 As String = ""
                    Dim kod3 As String = ""
                    Dim kod4 As String = ""
                    Dim kod5 As String = ""
                    str = sKodu
                    strArr = str.Split(sAyrac)
                    Dim i As Integer = 0
                    For count = 0 To strArr.Length - 1
                        If count = 0 Then
                            kod1 += Trim(strArr(count))
                        ElseIf count = 1 Then
                            kod2 += Trim(strArr(count))
                        ElseIf count = 2 Then
                            kod3 += sayiuzunlukkontrol(Trim(strArr(count)), 7)
                        ElseIf count = 3 Then
                            kod4 += Trim(strArr(count))
                        ElseIf count = 4 Then
                            kod5 += Trim(strArr(count))
                        End If
                        i += 1
                    Next
                    sKodu = kod1 + sAyrac + kod2 + sAyrac + kod3
                    'dteFisTarihi = dr("TARIH")
                    'lFisNo = dr("FISNO")
                    'lYevmiyeNo = dr("YEVMIYE")
                    nSatir = dr("IND")
                    sAciklama = Replace(dr("ACIKLAMA").ToString, "'", " ")
                    sAciklama = Replace(sAciklama, ",", " ")
                    lGirenMiktar = sorgu_sayi(dr("BMIKTAR"), 0)
                    lCikanMiktar = sorgu_sayi(dr("AMIKTAR"), 0)
                    lBorcTutar = sorgu_sayi(dr("BORC"), 0)
                    lAlacakTutar = sorgu_sayi(dr("ALACAK"), 0)
                    nHesapID = sorgula_Decimal("Select nHesapID from tbHesapPlani Where sKodu = '" & sKodu & "'")
                    If nHesapID = 0 Then
                        nHesapID = tbHesapPlani_kaydet_yeni(sKodu, sFirmaAciklama, sFirmaAciklama, 0, 0, 0, 0, "", 0, "MUHASEBE", dteFisTarihi)
                    End If
                    If nHesapID <> 0 Then
                        nFisSiraID = sorgu_nFisSiraID()
                        nFisSiraID = tbMuhasebeFisi_kaydet_yeni(nFisSiraID, dteFisTarihi, sMuhFisTipi, lFisNo, lYevmiyeNo, nHesapID, sAciklama, lGirenMiktar, lCikanMiktar, lBorcTutar, lAlacakTutar, "", 0, "MUH", "", 0, "MUHASEBE", dteFisTarihi, "", 0, 0, "", 0, 0, nSatir, "", "MUHASEBE", Now)
                        nFisSiraID_degistir(nFisSiraID)
                    End If
                Next
                Dataload_tbMuhasebeFisi(dteFisTarihi, sMuhFisTipi, lFisNo)
            End If
        End If
    End Sub
    Private Function tbHesapPlani_kaydet_yeni(ByVal sKodu As String, ByVal sAciklama As String, ByVal sAlterneAciklama As String, ByVal lBilancoSatiri As Decimal, ByVal sAktifPasif As String, ByVal lKarZararSatiri As Decimal, ByVal sKarZararGelirGider As String, ByVal sMasrafYontemi As String, ByVal bMiktarVar As Integer, ByVal sKullaniciAdi As String, ByVal dteKayitTarihi As DateTime, Optional ByVal sDatabase As String = "") As Int64
        Dim use As String = ""
        If sDatabase <> "" Then
            use = "USE " & sDatabase
        End If
        Dim con As New OleDb.OleDbConnection
        Dim cmd As New OleDb.OleDbCommand
        cmd.Connection = con
        con.ConnectionString = connection
        If con.State = ConnectionState.Closed = True Then
            con.Open()
        End If
        cmd.CommandText = sorgu_query("" & use & " SET DATEFORMAT DMY SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT     ISNULL(nHesapID, 0) AS nHesapID  FROM         tbHesapPlani Where sKodu = '" & sKodu & "' ")
        Dim kayitno = cmd.ExecuteScalar
        If Trim(kayitno) = "0" Or Trim(kayitno) = "" Then
            cmd.CommandText = sorgu_query("" & use & " SET DATEFORMAT DMY SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED INSERT INTO tbHesapPlani (sKodu, sAciklama, sAlterneAciklama, lBilancoSatiri, sAktifPasif, lKarZararSatiri, sKarZararGelirGider, sMasrafYontemi, bMiktarVar, sKullaniciAdi, dteKayitTarihi) VALUES     ('" & sKodu & "', '" & sAciklama & "', '" & sAlterneAciklama & "', " & lBilancoSatiri & ", '" & sAktifPasif & "', " & lKarZararSatiri & ", '" & sKarZararGelirGider & "', '" & sMasrafYontemi & "', " & bMiktarVar & ", '" & sKullaniciAdi & "', '" & dteKayitTarihi & "')")
            cmd.ExecuteNonQuery()
            cmd.CommandText = "select @@identity"
            kayitno = cmd.ExecuteScalar
        End If
        con.Close()
        Return kayitno
        cmd = Nothing
        con = Nothing
    End Function
    Private Sub BarButtonItem28_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem28.ItemClick
        fis_al()
    End Sub
    Private Sub BarButtonItem29_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem29.ItemClick
        Dim frm As New frm_ParaTeslim
        frm.Show()
    End Sub
    Private Sub BarButtonItem30_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem30.ItemClick
        tbDovizKuru()
    End Sub
    Private Sub ToolStripMenuItem1_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem1.Click
        satir_degistir()
    End Sub
    Private Sub BarButtonItem31_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem31.ItemClick
        If Me.WindowState = FormWindowState.Normal Then
            Me.WindowState = FormWindowState.Maximized
        ElseIf Me.WindowState = FormWindowState.Maximized Then
            Me.WindowState = FormWindowState.Normal
        End If
    End Sub
    Private Sub BarButtonItem32_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem32.ItemClick
        satir_ekle_araya()
    End Sub
    Private Sub satir_ekle_araya()
        If GridView1.RowCount > 0 Then
            Dim dr As DataRow = GridView1.GetDataRow(GridView1.FocusedRowHandle)
            Dim nSatir = dr("nSatir")
            guncelle_nSatir(nSatir)
            satir_ekle("", "Baþlar", nSatir)
            dr = Nothing
            nSatir = Nothing
        End If
    End Sub
    Private Sub guncelle_nSatir(ByVal nSatir As Integer)
        Dim dr As DataRow
        Dim sayi As Integer = 0
        For Each dr In ds_tbMuhasebeFisi.Tables(0).Rows
            If dr("nSatir") >= nSatir Then
                dr("nSatir") = dr("nSatir") + 1
                tbMuhasebeFisi_satir_kaydet_duzelt(dr("nFisSiraID"), dr("nSatir"))
            End If
            sayi += 1
        Next
    End Sub
    Private Sub ToolStripMenuItem2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem2.Click
        satir_ekle_araya()
    End Sub
    Private Sub BarButtonItem34_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem34.ItemClick
        If MuhnStokFisiID > 0 Then
            Dim frm As New frm_fatura
            frm.firmano = firmano
            frm.donemno = donemno
            frm.connection = connection
            frm.lFisNo = lFisNo
            frm.dteFisTarihi = dteFisTarihi
            frm.sFisTipi = MuhsFisTipi
            frm.nFirmaID = MuhnFirmaID
            frm.nGirisCikis = MuhnGirisCikis
            frm.nStokFisiID = MuhnStokFisiID
            frm.kullanici = kullanici
            If yetki_kontrol(kullanici, frm.Name) = True Then
                Try
                    frm.ShowDialog()
                Catch ex As Exception
                End Try
            End If
            frm.Close()
            frm.Dispose()
            frm = Nothing
            MuhasebeFisiBaslangic()
        Else
            XtraMessageBox.Show(Sorgu_sDil("Kayýt Bulunamadý...!", sDil), Sorgu_sDil("Dikkat", sDil), MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If
    End Sub
End Class