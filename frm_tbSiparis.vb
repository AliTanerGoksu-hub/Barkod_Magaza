Imports FastReport
Imports Microsoft.Win32
Imports DevExpress.XtraEditors
Imports DevExpress.XtraGrid
Imports DevExpress.XtraGrid.Columns
Imports System.IO
Imports DevExpress.XtraPrinting
Imports DevExpress.Data
Imports DevExpress.XtraExport
Imports DevExpress.Utils
Imports DevExpress.XtraBars
Imports DevExpress.XtraEditors.Controls
Imports DevExpress.XtraEditors.Repository
Imports DevExpress.XtraGrid.Views.Base
Imports DevExpress.XtraGrid.Views.Grid
Imports DevExpress.XtraTab
Imports DevExpress.XtraVerticalGrid
Imports DevExpress.XtraVerticalGrid.Events
Imports DevExpress.XtraVerticalGrid.Rows
Imports Microsoft.VisualBasic
Imports Microsoft.VisualBasic.CompilerServices
Imports System
Imports System.Collections
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Data.OleDb
Imports System.Diagnostics
Imports System.Drawing
Imports System.Drawing.Printing
Imports System.Globalization
Imports System.Runtime.CompilerServices
Imports System.Runtime.InteropServices
Imports System.Text
Imports System.Windows.Forms
Imports System.Threading
Public Class frm_tbSiparis
    Public firmano
    Public donemno
    Public connection
    Public kullanici
    Dim sAraKriter As String = ""
    Public nFirmaID = 0
    Dim sKodu As String = ""
    Dim sFiyatTipi As String = "1"
    Public nSiparisTipi As String = ""
    Public dteSiparisTarihi As DateTime = Today
    Public lSiparisNo As Int64 = 0
    Public sSiparisiAlan As String = ""
    Public sSiparisiVeren As String = ""
    Dim ds_tbsube As DataSet
    Dim ds_tbDovizCinsi As DataSet
    Dim ds_tbBirimCinsi As DataSet
    Dim ds_tbSiparisTipi As DataSet
    Dim ds_sSiparissIslem As DataSet
    Dim ds_cari As DataSet
    Dim ds_satir_stok As DataSet
    Dim ds_FiyatTipi As DataSet
    Dim ds_stok As DataSet
    Dim ds_tbSiparisIslem As DataSet
    'Dim qr_hareket As New TfrxADOQuery
    'Dim qr_baslik As New TfrxADOQuery
    'Dim qr_toplam As New TfrxADOQuery
    'Dim qr_firma As New TfrxADOQuery
    Dim sorgu_txt_baslik As String = ""
    Dim sorgu_txt_hareket As String = ""
    Dim sorgu_txt_toplam As String = ""
    Dim sorgu_txt_firma As String = ""
    Dim sorgu_txt_adres As String = ""
    Public yeni As Boolean = False
    Dim status As Boolean = False
    Public islemstatus As Boolean = False
    Dim dr_baslik As DataRow
    Dim dr_hareket As DataRow
    Dim dr_toplam As DataRow
    Dim ds_Protokol As DataSet
    'Dim sDepo As String = ""
    Dim mevcut As Decimal = 1
    Dim x As Integer = 0
    Dim okut As Boolean = False
    Dim info As Boolean = False
    Dim bImport As Boolean = False
    Dim bImport_Fiyat As Boolean = False
    Dim bImport_Tutar As Boolean = False
    Dim bImport_Tutari As Boolean = False
    Dim bIFiyati As Decimal = 0
    Dim bITutari As Decimal = 0
    Dim bKilitli As Boolean = False
    Dim bKilitAcabilir As Boolean = False
    Dim bKapat As Boolean = False
    Dim nSiparisID As Int64 = sorgu_nSiparisID()
    Private Const CAT_NAME As String = "categoryAdres"
    Private Const ROW_NAME As String = "rowSevkAdresi"
    Private Shared ReadOnly TR As CultureInfo = New CultureInfo("tr-TR")
    Private Sub frm_tbMuhasebeFisi_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        Registry.CurrentUser.CreateSubKey("Software").CreateSubKey("BusinessSmart").CreateSubKey("VIEW").CreateSubKey("Perakende").CreateSubKey("Siparis").SetValue("Kriter", sec_kriter.Text)
        ' DÜZELTME: Form kapanırken counter ARTIRMAMALI!
        ' Counter sadece yeni sipariş oluşturulduğunda artırılır
        ' lSiparisNo_degistir(nSiparisTipi) ' KALDIRILDI
        If fis_kontrolleri() = True Then
        Else
            e.Cancel = True
        End If
        'If FormatNumber(sorgu_lBakiye(txt_dteFisTarihi.EditValue, 3, txt_lFisNo.EditValue), 2) <> "0.00" Then
        '    e.Cancel = True
        '    XtraMessageBox.Show(Sorgu_sDil("Fiş Borç Alacak Toplamının Eşit Olması Gerekmektedir..!",sDil), MessageBoxIcon.Warning)
        'End If
    End Sub
    Private Function fis_kontrolleri() As Boolean
        Dim pass As Boolean = False
        Dim bCikisIptal As Integer = -1
        Dim ds_tbParamAlisVeris As DataSet = sorgu(String.Format("Select * from tbParamAlisVeris Where sMagazaKodu='{0}' ", sDepo))
        Dim dr_param As DataRow = ds_tbParamAlisVeris.Tables(0).Rows(0)
        If bKapat = False Then
            Try
                If dr_param("bSaticiRumuzuVarmi") = True And dr_baslik("nSiparisTipi") = 1 Then
                    Dim drs As DataRow
                    Dim sayi As Integer = -1
                    For Each drs In ds_tbSiparis.Tables(0).Rows
                        sayi += 1
                        If Trim(drs("sSaticiRumuzu")) = "" And bCikisIptal = -1 Then
                            bCikisIptal = sayi
                        End If
                    Next
                    drs = Nothing
                    sayi = Nothing
                End If
            Catch ex As Exception
            End Try
            Try
                If dr_param("bLimitAsimiIzinlimi") = False Then
                    Dim ds_satir_firma As DataSet = sorgu_firma_info(dr_baslik("nFirmaID"))
                    Dim dr1 As DataRow
                    If ds_satir_firma.Tables(0).Rows.Count > 0 Then
                        dr1 = ds_satir_firma.Tables(0).Rows(0)
                        Dim BAKIYE As Decimal = Decimal.Parse(dr1("BAKIYE").ToString())
                        dr_toplam = ds_tbSiparisToplam.Tables(0).Rows(0)
                        BAKIYE += Decimal.Parse(dr_toplam("lNetTutar").ToString())
                        If dr1("lKrediLimiti") <> 0 Then
                            If BAKIYE = Decimal.Parse(dr1("lKrediLimiti").ToString()) Then
                                XtraMessageBox.Show(Sorgu_sDil("Cari Hesabın Kredi Limiti Doldu...!", sDil), Sorgu_sDil("Dikkat", sDil), MessageBoxButtons.OK, MessageBoxIcon.Information)
                                bCikisIptal = -1
                            ElseIf BAKIYE > Decimal.Parse(dr1("lKrediLimiti").ToString()) Then
                                bCikisIptal = -2
                            End If
                        End If
                    End If
                    Label2.Refresh()
                    dr1 = Nothing
                End If
            Catch ex As Exception
            End Try
            If bKilitli = True Or dr_baslik("bKilitli") = True Then
                bCikisIptal = -1
            End If
            If bCikisIptal >= 0 And dr_baslik("nSiparisTipi") = 1 Then
                XtraMessageBox.Show(Sorgu_sDil("Fişte Satıcı Bilgisini Boş Bırakamazsınız...!" & vbCrLf & "Lütfen Satıcı Bilgilerini Doldurunuz...", sDil), Sorgu_sDil("Dikkat", sDil), MessageBoxButtons.OK, MessageBoxIcon.Warning)
                GridControl1.Focus()
                GridControl1.Select()
                GridView1.FocusedColumn = colsSaticiRumuzu
                GridView1.FocusedRowHandle = bCikisIptal
                GridView1.ClearSelection()
                GridView1.SelectRow(bCikisIptal)
            ElseIf bCikisIptal = -2 And dr_baslik("nSiparisTipi") = 1 Then
                If XtraMessageBox.Show(Sorgu_sDil("Müşteri Kredi Limitini Aşamazsınız..." & vbCrLf & "Lütfen Sistem Yöneticinizle Görüşün!", sDil), Sorgu_sDil("Dikkat", sDil), MessageBoxButtons.YesNo, MessageBoxIcon.Question) = MsgBoxResult.No Then
                    satir_sil()
                End If
            ElseIf bCikisIptal = -1 Then
                pass = True
            End If
        Else
            pass = True
        End If
        Return pass

    End Function
    Private Sub frm_tbNakitKasa_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'Try
        '    sDepo = Registry.CurrentUser.OpenSubKey("Software").OpenSubKey("BusinessSmart").OpenSubKey("MAGAZA").GetValue("DEPOKODU").ToString
        'Catch ex As Exception
        '    sDepo = " "
        '    'dr("DEPO") = "1KAT"
        '    Registry.CurrentUser.CreateSubKey("Software").CreateSubKey("BusinessSmart").CreateSubKey("MAGAZA").SetValue("DEPOKODU", sDepo)
        'End Try
        Try
            sec_kriter.Text = Registry.CurrentUser.OpenSubKey("Software").OpenSubKey("BusinessSmart").OpenSubKey("VIEW").OpenSubKey("Perakende").OpenSubKey("Siparis").GetValue("Kriter").ToString
        Catch ex As Exception
            sec_kriter.Text = "Başlar"
        End Try
        Try
            loaded()
        Catch ex As Exception
            XtraMessageBox.Show(Sorgu_sDil("Hatalı Islem, Lütfen Tekrar Deneyiniz...!", sDil), Sorgu_sDil("Dikkat", sDil), MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End Try
        Try
            gorunum_yukle()
        Catch ex As Exception
        End Try
        status = True
        GridControl1.Focus()
        GridControl1.Select()
        If nSiparisTipi = 3 Then
            'colnKdvOrani.Caption = "Kar"
            colnKdvOrani.Caption = "Kdv"
            'rowlKdvTutari.Properties.Caption = "Kar Tutarı"
            rowlKdvTutari.Properties.Caption = "Kdv Tutarı"
            rowsSiparisiAlan.Properties.Caption = "Başlangıç"
            rowsSiparisiVeren.Properties.Caption = "Bitiş"
            coldteTeslimTarihi.Caption = "SonTarih"
            Text = "SatınAlma Şartı"
        ElseIf nSiparisTipi = 4 Then
            colnKdvOrani.Caption = "Kdv"
            rowlKdvTutari.Properties.Caption = "Kdv Tutarı"
            rowsSiparisiAlan.Properties.Caption = "TeklifiAlan"
            rowsSiparisiVeren.Properties.Caption = "TeklifiVeren"
            Text = "Proforma"
        Else
            colnKdvOrani.Caption = "Kdv"
            rowlKdvTutari.Properties.Caption = "Kdv Tutarı"
            rowsSiparisiAlan.Properties.Caption = "Siparişi Alan"
            rowsSiparisiVeren.Properties.Caption = "SiparisiVeren"
        End If
        If nSiparisTipi = 1 Then
            Text = "Alınan Sipariş"
            BarSubItem11.Visibility = DevExpress.XtraBars.BarItemVisibility.Always
            VGrid_baslik.BackColor = Color.GreenYellow
        ElseIf nSiparisTipi = 2 Then
            Text = "Verilen Sipariş"
            ' Verilen Siparis icin de sevkiyat/onay menusu gosterilecek
            BarSubItem11.Visibility = DevExpress.XtraBars.BarItemVisibility.Always
            VGrid_baslik.BackColor = Color.BlueViolet
        ElseIf nSiparisTipi = 3 Then
            Text = "SatınAlma Şartı"
            BarSubItem11.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
            VGrid_baslik.BackColor = Color.Red
        ElseIf nSiparisTipi = 4 Then
            Text = "Proforma"
            BarSubItem11.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
            VGrid_baslik.BackColor = Color.Magenta
        End If
    End Sub
    Private Sub loaded()

        dataload_tbDovizCinsi()
        dataload_tbBirimCinsi()
        dataload_tbHareketTipi(nSiparisTipi)
        dataload_satici()
        dataload_Depo()
        dataload_tbsSiparisIslem()
        dataload_tbFiyatTipi()
        dataload_baslik()
        dr_baslik = ds_baslik.Tables(0).Rows(0)
        dr_baslik("sSiparisiAlan") = sSiparisiAlan
        dr_baslik("sSiparisiVeren") = sSiparisiVeren
        Dataload_tbSiparis(dr_baslik("dteSiparisTarihi"), dr_baslik("nSiparisTipi"), dr_baslik("lSiparisNo"), dr_baslik("nFirmaID"))
        sorgu_tbStokFisiPesinAdres(dr_baslik("nSiparisTipi"), dr_baslik("lSiparisNo"))
        Dataload_tbFirma(dr_baslik("sKodu"))
        nSiparisTipi = dr_baslik("nSiparisTipi")

        ' === SESSIZ RISK BILDIRIMI (Sadece Alinan Siparis icin) ===
        Try
            If nSiparisTipi = 1 Then
                RiskBildirimModulu.RiskKontrolEkle(Me, connection, CLng(dr_baslik("nFirmaID")), 0, AddressOf sorgu_query)
            End If
        Catch : End Try
        ' Adres bilgisini kontrol et ve göster
        Dim kayitsayisi = sorgu_tbAlisVerisAdres_kontrol(dr_baslik("nSiparisTipi"), dr_baslik("lSiparisNo"))
        Debug.WriteLine("Kayıt Sayısı: " & kayitsayisi) ' Hata ayıkla
        goster_tbSiparisAdres1() ' Adresi göster
        ' Parametrik onay kontrolu - bOnayVar = TRUE ise kontrol yap
        Dim dtParamOnay1 As DataTable = SQLCalistir("SELECT ISNULL(bOnayVar, 0) AS bOnayVar FROM tbParamAlSiparis")
        Dim bOnayVarParam1 As Boolean = False
        If dtParamOnay1.Rows.Count > 0 Then
            bOnayVarParam1 = Convert.ToBoolean(dtParamOnay1.Rows(0)("bOnayVar"))
        End If
        
        Dim bSiparisOnayli As Boolean = False
        If bOnayVarParam1 Then
            Dim dtOnay As DataTable = SQLCalistir("SELECT ISNULL(bOnay, 0) FROM tbSiparis  WHERE lSiparisNo = " & lSiparisNo & " AND nFirmaID = " & nFirmaID)
            If dtOnay.Rows.Count > 0 AndAlso Convert.ToBoolean(dtOnay.Rows(0)(0)) Then
                bSiparisOnayli = True
            End If
        End If
        
        If bSiparisOnayli Then
            GridView1.OptionsBehavior.Editable = False
            EkleToolStripMenuItem.Enabled = False
            SilToolStripMenuItem.Enabled = False
            btn_SatirEkle.Enabled = False
            btn_SatirArayaEkle.Enabled = False
            btn_SatirDuzelt.Enabled = False
            btn_SatirSil.Enabled = False
            btn_SatirEkleIhtiyac.Enabled = False
            btn_DegerYay.Enabled = False
            btn_FisSil.Enabled = False
            btn_FiyatTipiBelirle.Enabled = False
            btn_SaticiBelirle.Enabled = False
            btn_Alt_SatirEkle.Enabled = False
            btn_Alt_SatirSil.Enabled = False
            btn_Alt_FisSil.Enabled = False
            rowdteSiparisTarihi.Properties.ReadOnly = True
            rowlSiparisNo.Properties.ReadOnly = True
            rowsSiparisiAlan.Properties.ReadOnly = True
            rowsSiparisiVeren.Properties.ReadOnly = True
            Panel_Ara.Enabled = False
        End If
        bKilitli = yetki_kontrol(kullanici, Trim(nSiparisTipi) & "_IslemYapamaz", False, 0)
        If dr_baslik("bKilitli") = True Or bKilitli = True Then
            GridView1.OptionsBehavior.Editable = False
            EkleToolStripMenuItem.Enabled = False
            SilToolStripMenuItem.Enabled = False
            btn_SatirEkle.Enabled = False
            btn_SatirArayaEkle.Enabled = False
            btn_SatirDuzelt.Enabled = False
            btn_SatirSil.Enabled = False
            btn_SatirEkleIhtiyac.Enabled = False
            btn_DegerYay.Enabled = False
            btn_FisSil.Enabled = False
            btn_FiyatTipiBelirle.Enabled = False
            btn_SaticiBelirle.Enabled = False
            btn_Alt_SatirEkle.Enabled = False
            btn_Alt_SatirSil.Enabled = False
            btn_Alt_FisSil.Enabled = False
            rowdteSiparisTarihi.Properties.ReadOnly = True
            rowlSiparisNo.Properties.ReadOnly = True
            rowsSiparisiAlan.Properties.ReadOnly = True
            rowsSiparisiVeren.Properties.ReadOnly = True
            Panel_Ara.Enabled = False
        End If
        If dr_baslik("bListelendimi") = True Then
            collBrutFiyat.FieldName = "lDahilFiyat"
            collBrutTutar.FieldName = "lDahilBrutTutar"
            collDovizFiyati.FieldName = "lDahilDovizFiyati"
            collDovizTutar.FieldName = "lDahilDovizTutar"
        Else
            collBrutFiyat.FieldName = "lFiyat"
            collBrutTutar.FieldName = "lBrutTutar"
            collDovizFiyati.FieldName = "lDovizFiyati"
            collDovizTutar.FieldName = "lDovizTutar"
        End If
        bKilitAcabilir = yetki_kontrol(kullanici, Trim(nSiparisTipi) & "_KilitAcabilir", False, 0)
        If kullanici > 3 And bKilitAcabilir = False Then
            rowbKilitli.Properties.ReadOnly = True
        Else
            rowbKilitli.Properties.ReadOnly = False
        End If
        ' Layout'ı yenile ve boyut ayarla
        VGrid_baslik.Width = 400 ' Daha geniş bir alan
        VGrid_baslik.Height = 300 ' Daha yüksek bir alan
        VGrid_baslik.Location = New Point(10, 10) ' Görünür konuma taşı
        VGrid_baslik.Refresh()
        With VGrid_baslik.Appearance
            .RecordValue.Options.UseForeColor = True
            .RecordValue.ForeColor = Color.Black

            .ReadOnlyRecordValue.Options.UseForeColor = True
            .ReadOnlyRecordValue.ForeColor = Color.Black

            .DisabledRecordValue.Options.UseForeColor = True
            .DisabledRecordValue.ForeColor = Color.Black

            ' (isteğe bağlı) sol başlıklar da siyah olsun
            .RowHeaderPanel.Options.UseForeColor = True
            .RowHeaderPanel.ForeColor = Color.Black
        End With
        AddHandler GridView1.CustomColumnDisplayText, AddressOf GridView1_CustomColumnDisplayText
    End Sub
    Private Sub dataload_baslik()
        If yeni = True Then
            lSiparisNo = sorgu_lSiparisNo()
            'tbSiparis_Aciklamasi_kaydet_yeni(nSiparisTipi, lSiparisNo, nFirmaID, "", "", "", "", "")
        End If
        ds_baslik.Tables(0).Clear()
        ds_baslik = sorgu_baslik(nFirmaID, nSiparisTipi, dteSiparisTarihi, lSiparisNo)
        VGrid_baslik.DataSource = ds_baslik
        VGrid_baslik.DataMember = "BASLIK"
        VGrid_baslik.Refresh()
    End Sub
    Private Function sorgu_baslik(ByVal nFirmaID As Int64, ByVal nSiparisTipi As Integer, ByVal dteSiparisTarihi As DateTime, ByVal lSiparisNo As Int64) As DataSet
        Dim cmd As New OleDb.OleDbCommand
        Dim con As New OleDb.OleDbConnection
        Dim adapter As New OleDb.OleDbDataAdapter
        con.ConnectionString = connection
        adapter.SelectCommand = cmd
        If yeni = True Then
            cmd.CommandText = sorgu_query(String.Format("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SET dateformat dmy SELECT TOP 1 tbSiparis.nSiparisTipi, tbSiparis.lSiparisNo, tbSiparis.dteSiparisTarihi, tbSiparis.sSiparisiAlan, tbSiparis.sSiparisiVeren, tbFirma.sKodu, tbFirma.sAciklama, tbFirma.nOzelIskontosu, tbFirma.lKrediLimiti, tbFirma.dteMutabakatTarihi, tbFirma.nVadeGun, tbFirma.sHitap, tbFirma.sAdres1, tbFirma.sAdres2, tbFirma.sSemt, tbFirma.sIl, tbFirma.sUlke, tbFirma.sPostaKodu, tbFirma.sVergiDairesi, tbFirma.sVergiNo, tbFirma.nHesapID, tbFirma.sOzelNot, tbFirma.sFiyatTipi,tbFirma.sSaticiRumuzu, (SELECT ISNULL(SUM(lBorcTutar - lAlacakTutar), 0) AS lBakiye FROM tbFirmaHareketi WHERE nFirmaID = tbFirma.nFirmaID) AS lBakiye, (SELECT TOP 1 sIletisimAdresi FROM tbFirmaIletisimi WHERE nFirmaId = tbFirma.nFirmaID AND sIletisimAraci = 'E-Mail') AS [E-Mail], (SELECT TOP 1 sIletisimAdresi FROM tbFirmaIletisimi WHERE nFirmaId = tbFirma.nFirmaID AND sIletisimAraci = 'Fax') AS Fax, (SELECT TOP 1 sIletisimAdresi FROM tbFirmaIletisimi WHERE nFirmaId = tbFirma.nFirmaID AND sIletisimAraci = 'Gsm') AS Gsm, (SELECT TOP 1 sIletisimAdresi FROM tbFirmaIletisimi WHERE nFirmaId = tbFirma.nFirmaID AND sIletisimAraci = 'Telefon') AS Telefon, (SELECT TOP 1 sIletisimAdresi FROM tbFirmaIletisimi WHERE nFirmaId = tbFirma.nFirmaID AND sIletisimAraci = 'Web') AS Web, (SELECT TOP 1 sIletisimAdresi FROM tbFirmaIletisimi WHERE nFirmaId = tbFirma.nFirmaID AND sIletisimAraci = 'Yetkili') AS Yetkili, tbFSinif1.sAciklama AS SINIF1, tbFSinif2.sAciklama AS SINIF2, tbFSinif3.sAciklama AS SINIF3, tbFSinif4.sAciklama AS SINIF4, tbFSinif5.sAciklama AS SINIF5, tbSiparisTipi.sAciklama AS sSiparisAciklama, tbSiparisAciklamasi.sAciklama1, tbSiparisAciklamasi.sAciklama2, tbSiparisAciklamasi.sAciklama3, tbSiparisAciklamasi.sAciklama4, tbSiparisAciklamasi.sAciklama5,ISNULL(tbSiparisAciklamasi.bKilitli,0) as bKilitli,ISNULL(tbSiparisAciklamasi.bListelendimi,0) as bListelendimi, tbFirma.nFirmaID FROM tbSiparisTipi INNER JOIN tbSiparis ON tbSiparisTipi.nSiparisTipi = tbSiparis.nSiparisTipi RIGHT OUTER JOIN tbFirmaSinifi INNER JOIN tbFirma ON tbFirmaSinifi.nFirmaID = tbFirma.nFirmaID INNER JOIN tbFSinif1 ON tbFirmaSinifi.sSinifKodu1 = tbFSinif1.sSinifKodu INNER JOIN tbFSinif5 ON tbFirmaSinifi.sSinifKodu5 = tbFSinif5.sSinifKodu INNER JOIN tbFSinif3 ON tbFirmaSinifi.sSinifKodu3 = tbFSinif3.sSinifKodu INNER JOIN tbFSinif2 ON tbFirmaSinifi.sSinifKodu2 = tbFSinif2.sSinifKodu INNER JOIN tbFSinif4 ON tbFirmaSinifi.sSinifKodu4 = tbFSinif4.sSinifKodu ON tbSiparis.nFirmaID = tbFirma.nFirmaID LEFT OUTER JOIN tbSiparisAciklamasi ON tbSiparis.nSiparisTipi = tbSiparisAciklamasi.nSiparisTipi AND tbSiparis.lSiparisNo = tbSiparisAciklamasi.lSiparisNo AND tbSiparis.nFirmaID = tbSiparisAciklamasi.nFirmaID WHERE tbFirma.nFirmaID = {0} ", nFirmaID))
            sorgu_txt_baslik = sorgu_query(String.Format("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SET dateformat dmy SELECT TOP 1 tbSiparis.nSiparisTipi, tbSiparis.lSiparisNo, tbSiparis.dteSiparisTarihi, tbSiparis.sSiparisiAlan, tbSiparis.sSiparisiVeren, tbFirma.sKodu, tbFirma.sAciklama, tbFirma.nOzelIskontosu, tbFirma.lKrediLimiti, tbFirma.dteMutabakatTarihi, tbFirma.nVadeGun, tbFirma.sHitap, tbFirma.sAdres1, tbFirma.sAdres2, tbFirma.sSemt, tbFirma.sIl, tbFirma.sUlke, tbFirma.sPostaKodu, tbFirma.sVergiDairesi, tbFirma.sVergiNo, tbFirma.nHesapID, tbFirma.sOzelNot, tbFirma.sFiyatTipi,tbFirma.sSaticiRumuzu, (SELECT ISNULL(SUM(lBorcTutar - lAlacakTutar), 0) AS lBakiye FROM tbFirmaHareketi WHERE nFirmaID = tbFirma.nFirmaID) AS lBakiye, (SELECT TOP 1 sIletisimAdresi FROM tbFirmaIletisimi WHERE nFirmaId = tbFirma.nFirmaID AND sIletisimAraci = 'E-Mail') AS [E-Mail], (SELECT TOP 1 sIletisimAdresi FROM tbFirmaIletisimi WHERE nFirmaId = tbFirma.nFirmaID AND sIletisimAraci = 'Fax') AS Fax, (SELECT TOP 1 sIletisimAdresi FROM tbFirmaIletisimi WHERE nFirmaId = tbFirma.nFirmaID AND sIletisimAraci = 'Gsm') AS Gsm, (SELECT TOP 1 sIletisimAdresi FROM tbFirmaIletisimi WHERE nFirmaId = tbFirma.nFirmaID AND sIletisimAraci = 'Telefon') AS Telefon, (SELECT TOP 1 sIletisimAdresi FROM tbFirmaIletisimi WHERE nFirmaId = tbFirma.nFirmaID AND sIletisimAraci = 'Web') AS Web, (SELECT TOP 1 sIletisimAdresi FROM tbFirmaIletisimi WHERE nFirmaId = tbFirma.nFirmaID AND sIletisimAraci = 'Yetkili') AS Yetkili, tbFSinif1.sAciklama AS SINIF1, tbFSinif2.sAciklama AS SINIF2, tbFSinif3.sAciklama AS SINIF3, tbFSinif4.sAciklama AS SINIF4, tbFSinif5.sAciklama AS SINIF5, tbSiparisTipi.sAciklama AS sSiparisAciklama, tbSiparisAciklamasi.sAciklama1, tbSiparisAciklamasi.sAciklama2, tbSiparisAciklamasi.sAciklama3, tbSiparisAciklamasi.sAciklama4, tbSiparisAciklamasi.sAciklama5,ISNULL(tbSiparisAciklamasi.bKilitli,0) as bKilitli, ISNULL(tbSiparisAciklamasi.bListelendimi,0) as bListelendimi,tbFirma.nFirmaID FROM tbSiparisTipi INNER JOIN tbSiparis ON tbSiparisTipi.nSiparisTipi = tbSiparis.nSiparisTipi RIGHT OUTER JOIN tbFirmaSinifi INNER JOIN tbFirma ON tbFirmaSinifi.nFirmaID = tbFirma.nFirmaID INNER JOIN tbFSinif1 ON tbFirmaSinifi.sSinifKodu1 = tbFSinif1.sSinifKodu INNER JOIN tbFSinif5 ON tbFirmaSinifi.sSinifKodu5 = tbFSinif5.sSinifKodu INNER JOIN tbFSinif3 ON tbFirmaSinifi.sSinifKodu3 = tbFSinif3.sSinifKodu INNER JOIN tbFSinif2 ON tbFirmaSinifi.sSinifKodu2 = tbFSinif2.sSinifKodu INNER JOIN tbFSinif4 ON tbFirmaSinifi.sSinifKodu4 = tbFSinif4.sSinifKodu ON tbSiparis.nFirmaID = tbFirma.nFirmaID LEFT OUTER JOIN tbSiparisAciklamasi ON tbSiparis.nSiparisTipi = tbSiparisAciklamasi.nSiparisTipi AND tbSiparis.lSiparisNo = tbSiparisAciklamasi.lSiparisNo AND tbSiparis.nFirmaID = tbSiparisAciklamasi.nFirmaID WHERE tbFirma.nFirmaID = {0} AND (tbSiparis.dteSiparisTarihi = '{1}') AND tbSiparis.nSiparisTipi = {2} AND tbSiparis.lSiparisNo = {3}", nFirmaID, dteSiparisTarihi, nSiparisTipi, lSiparisNo))
        Else
            cmd.CommandText = sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SET dateformat dmy SELECT TOP 1 tbSiparis.nSiparisTipi, tbSiparis.lSiparisNo, tbSiparis.dteSiparisTarihi, tbSiparis.sSiparisiAlan, tbSiparis.sSiparisiVeren, tbFirma.sKodu, tbFirma.sAciklama, tbFirma.nOzelIskontosu, tbFirma.lKrediLimiti, tbFirma.dteMutabakatTarihi, tbFirma.nVadeGun, tbFirma.sHitap, tbFirma.sAdres1, tbFirma.sAdres2, tbFirma.sSemt, tbFirma.sIl, tbFirma.sUlke, tbFirma.sPostaKodu, tbFirma.sVergiDairesi, tbFirma.sVergiNo, tbFirma.nHesapID, tbFirma.sOzelNot, tbFirma.sFiyatTipi, tbFirma.sSaticiRumuzu,(SELECT ISNULL(SUM(lBorcTutar - lAlacakTutar), 0) AS lBakiye FROM tbFirmaHareketi WHERE nFirmaID = tbFirma.nFirmaID) AS lBakiye, (SELECT TOP 1 sIletisimAdresi FROM tbFirmaIletisimi WHERE nFirmaId = tbFirma.nFirmaID AND sIletisimAraci = 'E-Mail') AS [E-Mail], (SELECT TOP 1 sIletisimAdresi FROM tbFirmaIletisimi WHERE nFirmaId = tbFirma.nFirmaID AND sIletisimAraci = 'Fax') AS Fax, (SELECT TOP 1 sIletisimAdresi FROM tbFirmaIletisimi WHERE nFirmaId = tbFirma.nFirmaID AND sIletisimAraci = 'Gsm') AS Gsm, (SELECT TOP 1 sIletisimAdresi FROM tbFirmaIletisimi WHERE nFirmaId = tbFirma.nFirmaID AND sIletisimAraci = 'Telefon') AS Telefon, (SELECT TOP 1 sIletisimAdresi FROM tbFirmaIletisimi WHERE nFirmaId = tbFirma.nFirmaID AND sIletisimAraci = 'Web') AS Web, (SELECT TOP 1 sIletisimAdresi FROM tbFirmaIletisimi WHERE nFirmaId = tbFirma.nFirmaID AND sIletisimAraci = 'Yetkili') AS Yetkili, tbFSinif1.sAciklama AS SINIF1, tbFSinif2.sAciklama AS SINIF2, tbFSinif3.sAciklama AS SINIF3, tbFSinif4.sAciklama AS SINIF4, tbFSinif5.sAciklama AS SINIF5, tbSiparisTipi.sAciklama AS sSiparisAciklama, tbSiparisAciklamasi.sAciklama1, tbSiparisAciklamasi.sAciklama2, tbSiparisAciklamasi.sAciklama3, tbSiparisAciklamasi.sAciklama4, tbSiparisAciklamasi.sAciklama5, ISNULL(tbSiparisAciklamasi.bKilitli,0) as bKilitli,ISNULL(tbSiparisAciklamasi.bListelendimi,0) as bListelendimi,tbFirma.nFirmaID FROM tbSiparisTipi INNER JOIN tbSiparis ON tbSiparisTipi.nSiparisTipi = tbSiparis.nSiparisTipi RIGHT OUTER JOIN tbFirmaSinifi INNER JOIN tbFirma ON tbFirmaSinifi.nFirmaID = tbFirma.nFirmaID INNER JOIN tbFSinif1 ON tbFirmaSinifi.sSinifKodu1 = tbFSinif1.sSinifKodu INNER JOIN tbFSinif5 ON tbFirmaSinifi.sSinifKodu5 = tbFSinif5.sSinifKodu INNER JOIN tbFSinif3 ON tbFirmaSinifi.sSinifKodu3 = tbFSinif3.sSinifKodu INNER JOIN tbFSinif2 ON tbFirmaSinifi.sSinifKodu2 = tbFSinif2.sSinifKodu INNER JOIN tbFSinif4 ON tbFirmaSinifi.sSinifKodu4 = tbFSinif4.sSinifKodu ON tbSiparis.nFirmaID = tbFirma.nFirmaID LEFT OUTER JOIN tbSiparisAciklamasi ON tbSiparis.nSiparisTipi = tbSiparisAciklamasi.nSiparisTipi AND tbSiparis.lSiparisNo = tbSiparisAciklamasi.lSiparisNo AND tbSiparis.nFirmaID = tbSiparisAciklamasi.nFirmaID WHERE tbFirma.nFirmaID = " & nFirmaID & " AND (tbSiparis.dteSiparisTarihi = '" & dteSiparisTarihi & "') AND tbSiparis.nSiparisTipi = " & nSiparisTipi & " AND tbSiparis.lSiparisNo = " & lSiparisNo & "")
            sorgu_txt_baslik = cmd.CommandText
        End If
        cmd.Connection = con
        con.Open()
        Dim DS As New DataSet
        Dim N As Integer = adapter.Fill(DS, "BASLIK")
        con.Close()
        cmd = Nothing
        con = Nothing
        If yeni = True Then
            Dim dr As DataRow = DS.Tables(0).Rows(0)
            dr("dteSiparisTarihi") = dteSiparisTarihi
            dr("sSiparisiVeren") = ""
            dr("sSiparisiAlan") = ""
            dr("lSiparisNo") = lSiparisNo
            dr("nSiparisTipi") = nSiparisTipi
            dr = Nothing
        End If
        Return DS
    End Function
    Private Sub dataload_tbDovizCinsi()
        ds_tbDovizCinsi = sorgu(sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT sDovizCinsi,sAciklama FROM tbDovizCinsi"))
        sec_sDovizCinsi.DataSource = ds_tbDovizCinsi.Tables(0)
    End Sub
    Private Sub dataload_tbBirimCinsi()
        ds_tbBirimCinsi = sorgu(sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT sBirimCinsi,sAciklama FROM tbBirimCinsi"))
        sec_sAmbalaj.DataSource = ds_tbBirimCinsi.Tables(0)
    End Sub
    Private Sub dataload_tbHareketTipi(ByVal nSiparisTipi As String)
        ds_tbSiparisTipi = sorgu(sorgu_query(String.Format("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT nSiparisTipi, sAciklama FROM tbSiparisTipi Where nSiparisTipi  ='{0}' ", nSiparisTipi)))
        'sec_sSiparisTipi.Properties.DataSource = ds_tbSiparisTipi.Tables(0)
        'sec_sSiparisTipi.ItemIndex = 0
    End Sub
    Private Sub dataload_satici()
        sec_sSaticiRumuzu.DataSource = sorgu(sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT sSaticiRumuzu, sAdi + ' ' + sSoyadi AS sSatici FROM tbSatici where bAktif =1")).Tables(0)
    End Sub
    Private Sub dataload_Depo()
        sec_sDepo.DataSource = sorgu(sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT sDepo, sAciklama FROM tbDepo ORDER BY sDepo")).Tables(0) 'DataSet2.Tables(0)
    End Sub
    Private Sub dataload_tbsSiparisIslem()
        ds_tbSiparisIslem = sorgu(sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT sSiparisIslem,sAciklama FROM tbSiparisIslem"))
        sec_sCariIslem.DataSource = ds_tbSiparisIslem.Tables(0)
    End Sub
    Private Sub dataload_tbFiyatTipi()
        ds_FiyatTipi = sorgu(sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT * FROM tbFiyatTipi where (aktif = 1) and (aktifDepo like '%" & Trim(sDepo) & "%')"))
        sec_sFiyatTipi.DataSource = ds_FiyatTipi.Tables(0)
    End Sub
    Private Sub gorunum_kaydet()
        If Trim(sDil) = "TR" Or Trim(sDil) = "" Then
            VGrid_baslik.SaveLayoutToRegistry("SOFTWARE\BusinessSmart\VIEW\Siparis\" & dr_baslik("nSiparisTipi") & "\BASLIK\" & Name.ToString & "")
            GridView1.SaveLayoutToRegistry("SOFTWARE\BusinessSmart\VIEW\Siparis\" & dr_baslik("nSiparisTipi") & "\HAREKET\" & Me.Name.ToString & "")
        Else
            VGrid_baslik.SaveLayoutToRegistry("SOFTWARE\BusinessSmart\VIEW\Siparis\" & sDil & "\" & dr_baslik("nSiparisTipi") & "\BASLIK\" & Me.Name.ToString & "")
            GridView1.SaveLayoutToRegistry("SOFTWARE\BusinessSmart\VIEW\Siparis\" & sDil & "\" & dr_baslik("nSiparisTipi") & "\HAREKET\" & Name.ToString & "")
        End If
        XtraMessageBox.Show(Sorgu_sDil("Görünüm Kaydedildi", sDil), Sorgu_sDil("Dikkat", sDil), MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub
    Private Sub gorunum_yukle()
        Try
        Catch ex As Exception
        End Try
        Try
            If nFontSize > 0 Then
                Dim sayi As Single = nFontSize
                GridView1.Appearance.Row.Font = New Font("Tahoma", sayi, FontStyle.Regular, GraphicsUnit.Point, CType(162, Byte))
                GridView1.Appearance.FooterPanel.Font = New Font("Tahoma", sayi, FontStyle.Regular, GraphicsUnit.Point, CType(162, Byte))
                GridView1.Appearance.HeaderPanel.Font = New Font("Tahoma", sayi, FontStyle.Regular, GraphicsUnit.Point, CType(162, Byte))
                sayi = Nothing
            End If
        Catch ex As Exception
        End Try
        For Each btn As DevExpress.XtraBars.BarItem In BarManager1.Items
            btn.Caption = Sorgu_sDil(btn.Caption, sDil)
        Next
        For Each clmn As GridColumn In GridView1.Columns
            clmn.Caption = Sorgu_sDil(clmn.Caption, sDil)
        Next
        Dim itm
        For Each itm In kisayol.Items
            itm.text = Sorgu_sDil(itm.text, sDil)
        Next
        Dim row
        For Each row In VGrid_Toplam.Rows
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
        For Each row In VGrid_baslik.Rows
            Try
                row.Properties.Caption = Sorgu_sDil(row.Properties.Caption, sDil)
            Catch ex As Exception
            End Try
        Next
        GroupControl2.Text = Sorgu_sDil(GroupControl2.Text, sDil)
        GroupControl3.Text = Sorgu_sDil(GroupControl3.Text, sDil)
        GroupControl4.Text = Sorgu_sDil(GroupControl4.Text, sDil)
        If Trim(sDil) = "TR" Or Trim(sDil) = "" Then
            'VGrid_baslik.RestoreLayoutFromRegistry("SOFTWARE\BusinessSmart\VIEW\Siparis\" & dr_baslik("nSiparisTipi") & "\BASLIK\" & Me.Name.ToString & "")
            GridView1.RestoreLayoutFromRegistry("SOFTWARE\BusinessSmart\VIEW\Siparis\" & dr_baslik("nSiparisTipi") & "\HAREKET\" & Name.ToString & "")
        Else
            'VGrid_baslik.RestoreLayoutFromRegistry("SOFTWARE\BusinessSmart\VIEW\Siparis\" & sDil & "\" & dr_baslik("nSiparisTipi") & "\BASLIK\" & Me.Name.ToString & "")
            GridView1.RestoreLayoutFromRegistry("SOFTWARE\BusinessSmart\VIEW\Siparis\" & sDil & "\" & dr_baslik("nSiparisTipi") & "\HAREKET\" & Me.Name.ToString & "")
        End If
    End Sub
    Private Function sorgu_query(ByVal query As String) As String
        query = Replace(query, "*!F", "F0" + firmano.ToString)
        query = Replace(query, "!D", "D000" + donemno.ToString)
        Return query
    End Function
    Private Function sorgu(ByVal query As String, Optional ByVal sTable As String = "TABLE1") As DataSet
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
        Dim N As Integer = adapter.Fill(DS, sTable)
        con.Close()
        Return DS
    End Function
    Public Function sorgu_nCariHareketID() As Int64
        Dim kriter As String = ""
        'kriter = "WHERE (sKodu = '" & kod & "')  "
        Dim conn As New OleDb.OleDbConnection
        Dim cmd As New OleDb.OleDbCommand
        Dim adapter As New OleDb.OleDbDataAdapter
        'MsgBox(connection_resmi)
        conn.ConnectionString = connection
        cmd.Connection = conn
        conn.Open()
        'cmd.CommandText = sorgu_query("SET DATEFORMAT DMY SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT     TOP 1 ISNULL(nHareketID + 1, 0) AS nCariHareketID  FROM         tbFirmaHareketi " & kriter & " ORDER BY nHareketID DESC")
        cmd.CommandText = sorgu_query("SET DATEFORMAT DMY SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT      ISNULL(MAX(nHareketID) + 1, 1) AS nCariHareketID  FROM         tbFirmaHareketi " & kriter & "")
        Dim kayitsayisi = cmd.ExecuteScalar
        If sorgu_sayi(kayitsayisi, 0) = 0 Then
            kayitsayisi = 1
        End If
        Return kayitsayisi
    End Function
    Public Function sorgu_nSiparisID() As Int64
        'Dim kriter As String = ""
        ''kriter = "WHERE (sKodu = '" & kod & "')  "
        'Dim conn As New OleDb.OleDbConnection
        'Dim cmd As New OleDb.OleDbCommand
        'Dim adapter As New OleDb.OleDbDataAdapter
        ''MsgBox(connection_resmi)
        'conn.ConnectionString = connection
        'cmd.Connection = conn
        'conn.Open()
        ''cmd.CommandText = sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT     TOP 1 ISNULL(nSiparisID + 1, 1) AS nSiparisID FROM         tbSiparis ORDER BY nSiparisID DESC")
        'cmd.CommandText = sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT      ISNULL(MAX(nSiparisID) + 1, 1) AS nSiparisID FROM         tbSiparis")
        'Dim kayitsayisi = cmd.ExecuteScalar
        'If sorgu_sayi(kayitsayisi, 0) = 0 Then
        '    kayitsayisi = 1
        'End If
        'Return 1
    End Function
    Public Function sorgu_lSiparisNo() As Int64
        ' DÜZELTME: Numara aldıktan sonra otomatik olarak +1 artır!
        ' Bu şekilde her çağrıda unique numara alınır
        Dim kriter As String = ""
        Dim conn As New OleDb.OleDbConnection
        Dim cmd As New OleDb.OleDbCommand
        Dim adapter As New OleDb.OleDbDataAdapter
        conn.ConnectionString = connection
        cmd.Connection = conn
        conn.Open()

        Dim currentNumber As Int64 = 1

        ' Mevcut counter değerini al (orijinal case yapısı korundu)
        If nSiparisTipi = 1 Then
            cmd.CommandText = sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT ISNULL(lSonSiparisNo,1) as lSiparisNo FROM tbParamAlSiparis")
        ElseIf nSiparisTipi = 2 Then
            cmd.CommandText = sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT ISNULL(lSonSiparisNo,1) as lSiparisNo FROM tbParamVerSiparis")
        ElseIf nSiparisTipi = 3 Then
            cmd.CommandText = sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT ISNULL(lSonSiparisNo,1) as lSiparisNo FROM tbParamVerSiparis")
        ElseIf nSiparisTipi = 4 Then
            cmd.CommandText = sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT ISNULL(lSonSiparisNo,1) as lSiparisNo FROM tbParamVerSiparis")
        Else
            cmd.CommandText = sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT ISNULL(lSonSiparisNo,1) as lSiparisNo FROM tbParamVerSiparis")
        End If

        Dim kayitsayisi = cmd.ExecuteScalar
        If kayitsayisi = 0 Then
            currentNumber = 1
        Else
            currentNumber = Convert.ToInt64(kayitsayisi)
        End If

        ' Counter'ı hemen +1 artır (aynı fonksiyon içinde!)
        ' Böylece bir sonraki çağrıda farklı numara alınır
        lSiparisNo_degistir(nSiparisTipi)

        conn.Close()
        Return currentNumber
    End Function
    Private Sub sorgu_tbProtokol(ByVal nFirmaID As Int64, ByVal nStokID As Int64)
        ds_Protokol = sorgu(sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT *  FROM tbProtokol WHERE nFirmaID = " & nFirmaID & " AND nStokID = " & nStokID & " "))
    End Sub
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
        cmd.CommandText = sorgu_query("SET DATEFORMAT DMY SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT ISNULL(SUM(lBorcTutar - lAlacakTutar), 0) AS lBakiye FROM tbMuhasebeFisi WHERE (dteFisTarihi = '" & dteFisTarihi & "') AND (sMuhFisTipi = " & sMuhFisTipi & ") AND (lFisno = " & lFisNo & ")")
        Dim kayitsayisi = cmd.ExecuteScalar
        Return kayitsayisi
    End Function
    Public Sub Dataload_tbSiparis(ByVal dteSiparisTarihi As DateTime, ByVal nSiparisTipi As Integer, ByVal lSiparisNo As Int64, ByVal nFirmaID As Int64)
        status = True
        Try
            ds_tbSiparis.Tables(0).Clear()
        Catch ex As Exception
        End Try
        Dim conn As New OleDb.OleDbConnection
        Dim cmd As New OleDb.OleDbCommand
        Dim adapter As New OleDb.OleDbDataAdapter
        conn.ConnectionString = connection
        adapter.SelectCommand = cmd
        ' (tbStokFisiDetayi.lBrutFiyat * tbStokFisiDetayi.lBirimMiktar) AS lFiyat,CAST( (tbStokFisiDetayi.lBrutFiyat*tbStokFisiDetayi.lBirimMiktar) * (100 + tbStokFisiDetayi.nKdvOrani) / 100 AS MONEY) AS lDahilFiyat
        cmd.CommandText = sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT tbSiparis.nSiparisID, tbSiparis.nSiparisTipi, tbSiparis.lSiparisNo, tbSiparis.nFirmaID, tbSiparis.sDepo,tbSiparis.nStokID, tbSiparis.dteSiparisTarihi, tbSiparis.dteTeslimTarihi, tbSiparis.sSiparisIslem, tbSiparis.nReceteNo, tbSiparis.sSiparisiAlan, tbSiparis.sSiparisiVeren, tbSiparis.sFiyatTipi, tbSiparis.lMiktari, tbSiparis.sAmbalaj,tbSiparis.sBirimCinsi,tbSiparis.lBirimMiktar, (tbSiparis.lMiktari / tbSiparis.lBirimMiktar) AS lMiktar, (tbSiparis.lFiyati * tbSiparis.lBirimMiktar) AS lFiyat,CAST( (tbSiparis.lFiyati*tbSiparis.lBirimMiktar) * (100 + tbSiparis.nKdvOrani) / 100 AS MONEY) AS lDahilFiyat,tbSiparis.lFiyati as lBrutFiyat,  (tbSiparis.lFiyati) AS lFiyat,tbSiparis.lFiyati,tbSiparis.lTutari, tbSiparis.sAsortiTipi, tbSiparis.sAsortiMiktari, tbSiparis.nKdvOrani, tbSiparis.nIskontoYuzdesi, tbSiparis.lIskontosuzTutari as lBrutTutar, CAST( (tbSiparis.lFiyati) * (100 + tbSiparis.nKdvOrani) / 100 AS MONEY) AS lDahilFiyat,CAST(tbSiparis.lFiyati * (100 + tbSiparis.nKdvOrani) / 100 AS MONEY) AS lDahilBrutFiyat,CAST(tbSiparis.lIskontosuzTutari * (100 + tbSiparis.nKdvOrani) / 100 AS MONEY) AS lDahilBrutTutar,tbSiparis.sSaticiRumuzu,tbStok.sModel, tbStok.sKodu, tbStok.sAciklama, (SELECT TOP 1 ISNULL(sBarkod , '') AS sBarkod FROM tbStokBarkodu WHERE nStokID = tbStok.nStokID and nKisim=0) AS sBarkod,(SELECT     sRenkAdi FROM          tbRenk WHERE      sRenk = tbStok.sRenk) AS sRenkAdi,tbStok.sBeden,tbStok.sKisaAdi,tbStok.nHacim,tbStok.nAgirlik,tbStok.sBirimCinsi1, tbStok.sBirimCinsi2,ISNULL((SELECT     ISNULL(lOran, 0) FROM         tbStokBirimCevrimi WHERE     nStokID = tbStok.nStokID AND sBirimCinsi = tbStok.sBirimCinsi2), 1) AS nBirimCarpan,tbSiparis.bKapandimi, tbSiparis.lReserveMiktari, tbSiparis.nPartiID,tbSiparis.sHangiUygulama, tbParti.nPartiID, tbParti.sKodu AS sKodu, tbSiparis.sSatirAciklama, tbSiparis.nValorGun, tbSiparis.sDovizCinsi, tbSiparis.lDovizFiyati, tbSiparis.lDovizKuru, CAST(SUBSTRING(tbSiparis.sSatirAciklama, 6, 5) AS MONEY) AS ISK1, CAST(SUBSTRING(tbSiparis.sSatirAciklama, 17, 5) AS MONEY) AS ISK2, CAST(SUBSTRING(tbSiparis.sSatirAciklama, 28, 5) AS MONEY) AS ISK3, CAST(SUBSTRING(tbSiparis.sSatirAciklama, 39, 5) AS MONEY) AS ISK4, CAST(0 AS MONEY) AS GERCEKFIYAT, CAST(0 AS MONEY) AS GERCEKTOPLAM, ISNULL(ABS(ROUND(tbSiparis.lTutari * (tbSiparis.nKdvOrani / 100), 2)), 0) AS lKdvTutari,tbSiparis.lIskontosuzTutari-tbSiparis.lTutari as lIskontoTutari, tbFirma.sKodu AS sFirmaKodu, tbFirma.sAciklama AS sFirmaAciklama,lDovizTutar = CASE WHEN tbSiparis.sDovizCinsi <> '' AND tbSiparis.lDovizKuru <> 0 THEN tbSiparis.lIskontosuzTutari / tbSiparis.lDovizKuru ELSE lIskontosuzTutari END, lDovizFiyati = CASE WHEN tbSiparis.sDovizCinsi <> '' AND tbSiparis.lDovizKuru <> 0 THEN  ((tbSiparis.lFiyati)) / tbSiparis.lDovizKuru ELSE  (tbSiparis.lFiyati) END,lDovizBrutFiyati = CASE WHEN tbSiparis.sDovizCinsi <> '' AND tbSiparis.lDovizKuru <> 0 THEN tbSiparis.lFiyati / tbSiparis.lDovizKuru ELSE tbSiparis.lFiyati END, lDahilDovizTutar = CASE WHEN tbSiparis.sDovizCinsi <> '' AND tbSiparis.lDovizKuru <> 0 THEN (tbSiparis.lIskontosuzTutari / tbSiparis.lDovizKuru) * (100 + tbSiparis.nKdvOrani) / 100 ELSE (tbSiparis.lIskontosuzTutari)* (100 + tbSiparis.nKdvOrani) / 100  END, lDahilDovizFiyati = CASE WHEN tbSiparis.sDovizCinsi <> '' AND tbSiparis.lDovizKuru <> 0 THEN ((tbSiparis.lFiyati) / tbSiparis.lDovizKuru)* (100 + tbSiparis.nKdvOrani) / 100 ELSE ((tbSiparis.lFiyati))* (100 + tbSiparis.nKdvOrani) / 100 END,lDahilDovizBrutFiyati = CASE WHEN tbSiparis.sDovizCinsi <> '' AND tbSiparis.lDovizKuru <> 0 THEN (tbSiparis.lFiyati / tbSiparis.lDovizKuru)* (100 + tbSiparis.nKdvOrani) / 100 ELSE (tbSiparis.lFiyati)* (100 + tbSiparis.nKdvOrani) / 100 END,(SELECT     ISNULL(SUM(MIKTAR),0) AS lYukleme FROM         ASTOKPAKETDETAY WHERE     (FISNO = tbSiparis.lSiparisNo) AND (FIRMANO = tbSiparis.nFirmaID) AND (IZAHAT = 'AS') AND (TARIH = tbSiparis.dteSiparisTarihi) AND (STOKNO = tbSiparis.nStokID)) as lYukleme,(SELECT     ABS(SUM(lGirisMiktar1) - SUM(lCikisMiktar1)) AS lSevkMiktari                            FROM          tbStokFisiDetayi                             WHERE      (nSiparisID IS NOT NULL) and tbStokFisiDetayi.nSiparisID = tbSiparis.nSiparisID) as lSevkiyat,ISNULL((SELECT isnull(lfiyat , 0) FROM tbstokfiyati WHERE nStokId = tbStok.NstokId AND sFiyatTipi = '" & sFiyat1 & "'),0) AS lFiyat1,ISNULL((SELECT isnull(lfiyat , 0) FROM tbstokfiyati WHERE nStokId = tbStok.NstokId AND sFiyatTipi = '" & sFiyat2 & "'),0) AS lFiyat2,ISNULL((SELECT isnull(lfiyat , 0) FROM tbstokfiyati WHERE nStokId = tbStok.NstokId AND sFiyatTipi = '" & sFiyat3 & "'),0) AS lFiyat3,ISNULL((SELECT isnull(lfiyat , 0) FROM tbstokfiyati WHERE nStokId = tbStok.NstokId AND sFiyatTipi = '" & sFiyat4 & "'),0) AS lFiyat4,ISNULL((SELECT isnull(lfiyat , 0) FROM tbstokfiyati WHERE nStokId = tbStok.NstokId AND sFiyatTipi = '" & sFiyatTipi & "'),0) AS lOzelFiyat,ISNULL((SELECT isnull(lfiyat , 0) FROM tbstokfiyati WHERE nStokId = tbStok.NstokId AND sFiyatTipi = '" & sFiyatM & "'),0) AS lMaliyet,ISNULL((SELECT isnull(lfiyat , 0) FROM tbstokfiyati WHERE nStokId = tbstok.NstokId AND sFiyatTipi = '" & sAltFiyatTipi & "'),0) AS lAltFiyat,ISNULL((SELECT isnull(lfiyat , 0) FROM tbstokfiyati WHERE nStokId = tbStok.NstokId AND sFiyatTipi = '" & sFiyatA & "'),0) AS lAlis,(tbSiparis.lTutari / tbSiparis.lMiktari) * (100 + tbSiparis.nKdvOrani) / 100 AS lNetFiyat FROM tbSiparis INNER JOIN tbStok ON tbSiparis.nStokID = tbStok.nStokID INNER JOIN tbParti ON tbSiparis.nPartiID = tbParti.nPartiID INNER JOIN tbFirma ON tbSiparis.nFirmaID = tbFirma.nFirmaID WHERE (tbSiparis.lSiparisNo = " & lSiparisNo & ") AND (tbSiparis.nSiparisTipi = " & nSiparisTipi & ") AND (tbSiparis.nFirmaID = " & nFirmaID & ") AND (tbSiparis.dteSiparisTarihi = '" & dteSiparisTarihi & "') ORDER BY tbSiparis.nSiparisTipi, tbSiparis.nFirmaID, tbSiparis.lSiparisNo, tbSiparis.nSiparisID")
        sorgu_txt_hareket = cmd.CommandText
        cmd.Connection = conn
        conn.Open()
        Dim N As Integer = adapter.Fill(ds_tbSiparis, "HAREKET")
        conn.Close()
        Dataload_tbYekun(dteSiparisTarihi, nSiparisTipi, lSiparisNo, nFirmaID)
        If GridView1.RowCount > 0 Then
            GridView1.ClearSelection()
            GridView1.SelectRow(GridView1.RowCount - 1)
            PanelControl3.Focus()
            GridControl1.Focus()
        End If
        If ds_tbSiparis.Tables(0).Rows.Count > 0 Then
            If sorgu_sAciklama_kontrol(dteSiparisTarihi, nSiparisTipi, lSiparisNo, nFirmaID) = True Then
                tbSiparis_Aciklamasi_kaydet_yeni(nSiparisTipi, lSiparisNo, nFirmaID, "", "", "", "", "", 0)
            End If
            'txt_sHareketTipi.EditValue = sorgu_sHareketTipi_kontrol(txt_dteFisTarihi.EditValue, sec_sMuhFisTipi.SelectedIndex + 1, txt_lFisNo.EditValue)
            'sec_sSubeMagaza.EditValue = sorgu_sSubeMagaza_kontrol(txt_dteFisTarihi.EditValue, sec_sMuhFisTipi.SelectedIndex + 1, txt_lFisNo.EditValue)
        End If
        status = False
        satir_kontrol()
    End Sub
    Private Function sorgu_tbStokFisiPesinAdres(ByVal nSiparisTipi As Integer, ByVal lSiparisNo As Int64) As DataSet
        Dim cmd As New OleDb.OleDbCommand
        Dim con As New OleDb.OleDbConnection
        Dim adapter As New OleDb.OleDbDataAdapter
        con.ConnectionString = connection
        cmd.CommandTimeout = Nothing
        adapter.SelectCommand = cmd
        cmd.CommandText = sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT * from tbSiparisPesinAdres Where nSiparisTipi = " & nSiparisTipi & " and lSiparisNo = " & lSiparisNo & " ")
        sorgu_txt_adres = cmd.CommandText
        cmd.Connection = con
        con.Open()
        Dim DS As New DataSet
        Dim N As Integer = adapter.Fill(DS, "tbStokFisiAdres")
        con.Close()
        con.Dispose()
        cmd.Dispose()
        con = Nothing
        cmd = Nothing
        Return DS
    End Function
    Private Function sorgu_siparis(ByVal dteSiparisTarihi As DateTime, ByVal nSiparisTipi As Integer, ByVal lSiparisNo As Int64, ByVal nFirmaID As Int64) As DataSet
        'Dim dsHareket As DataSet = sorgu(sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT tbSiparis.nSiparisID, tbSiparis.nSiparisTipi, tbSiparis.lSiparisNo, tbSiparis.nFirmaID, tbSiparis.sDepo,tbSiparis.nStokID, tbSiparis.dteSiparisTarihi, tbSiparis.dteTeslimTarihi, tbSiparis.sSiparisIslem, tbSiparis.nReceteNo, tbSiparis.sSiparisiAlan, tbSiparis.sSiparisiVeren, tbSiparis.sFiyatTipi, tbSiparis.lMiktari, tbSiparis.lFiyati, tbSiparis.lTutari, tbSiparis.sAsortiTipi, tbSiparis.sAsortiMiktari, tbSiparis.nKdvOrani, tbSiparis.nIskontoYuzdesi, tbSiparis.lIskontosuzTutari, tbSiparis.sSaticiRumuzu,tbStok.sModel, tbStok.sKodu, tbStok.sAciklama, (SELECT TOP 1 ISNULL(sBarkod , '') AS sBarkod FROM tbStokBarkodu WHERE nStokID = tbStok.nStokID) AS sBarkod,(SELECT     sRenkAdi FROM          tbRenk WHERE      sRenk = tbStok.sRenk) AS sRenkAdi,tbStok.sBeden,tbStok.sBirimCinsi1, ISNULL((SELECT     ISNULL(lOran, 0) FROM         tbStokBirimCevrimi WHERE     nStokID = tbStok.nStokID AND sBirimCinsi = tbStok.sBirimCinsi2), 1) AS nBirimCarpan,tbSiparis.bKapandimi, tbSiparis.lReserveMiktari, tbSiparis.nPartiID,tbSiparis.sHangiUygulama, tbParti.nPartiID, tbParti.sKodu AS sKodu, tbSiparis.sSatirAciklama, tbSiparis.nValorGun, tbSiparis.sDovizCinsi, tbSiparis.lDovizFiyati, tbSiparis.lDovizKuru, CAST(SUBSTRING(tbSiparis.sSatirAciklama, 6, 5) AS MONEY) AS ISK1, CAST(SUBSTRING(tbSiparis.sSatirAciklama, 17, 5) AS MONEY) AS ISK2, CAST(SUBSTRING(tbSiparis.sSatirAciklama, 28, 5) AS MONEY) AS ISK3, CAST(SUBSTRING(tbSiparis.sSatirAciklama, 39, 5) AS MONEY) AS ISK4, CAST(0 AS MONEY) AS GERCEKFIYAT, CAST(0 AS MONEY) AS GERCEKTOPLAM, ISNULL(ABS(ROUND(tbSiparis.lTutari * (tbSiparis.nKdvOrani / 100), 2)), 0) AS lKdvTutari,tbSiparis.lIskontosuzTutari-tbSiparis.lTutari as lIskontoTutari, tbFirma.sKodu AS sFirmaKodu, tbFirma.sAciklama AS sFirmaAciklama FROM tbSiparis INNER JOIN tbStok ON tbSiparis.nStokID = tbStok.nStokID INNER JOIN tbParti ON tbSiparis.nPartiID = tbParti.nPartiID INNER JOIN tbFirma ON tbSiparis.nFirmaID = tbFirma.nFirmaID WHERE (tbSiparis.lSiparisNo = " & lSiparisNo & ") AND (tbSiparis.nSiparisTipi = " & nSiparisTipi & ") AND (tbSiparis.nFirmaID = " & nFirmaID & ") AND (tbSiparis.dteSiparisTarihi = '" & dteSiparisTarihi & "') ORDER BY tbSiparis.nSiparisTipi, tbSiparis.nFirmaID, tbSiparis.lSiparisNo, tbSiparis.nSiparisID"), "HAREKET")
        Dim dsHareket As DataSet = sorgu(sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT tbSiparis.nSiparisID, tbSiparis.nSiparisTipi, tbSiparis.lSiparisNo, tbSiparis.nFirmaID, tbSiparis.sDepo,tbSiparis.nStokID, tbSiparis.dteSiparisTarihi, tbSiparis.dteTeslimTarihi, tbSiparis.sSiparisIslem, tbSiparis.nReceteNo, tbSiparis.sSiparisiAlan, tbSiparis.sSiparisiVeren, tbSiparis.sFiyatTipi, tbSiparis.lMiktari, tbSiparis.sAmbalaj,tbSiparis.sBirimCinsi,tbSiparis.lBirimMiktar, (tbSiparis.lMiktari / tbSiparis.lBirimMiktar) AS lMiktar, (tbSiparis.lFiyati * tbSiparis.lBirimMiktar) AS lFiyat,CAST( (tbSiparis.lFiyati*tbSiparis.lBirimMiktar) * (100 + tbSiparis.nKdvOrani) / 100 AS MONEY) AS lDahilFiyat,tbSiparis.lFiyati as lBrutFiyat,  (tbSiparis.lFiyati) AS lFiyat,tbSiparis.lFiyati,tbSiparis.lTutari, tbSiparis.sAsortiTipi, tbSiparis.sAsortiMiktari, tbSiparis.nKdvOrani, tbSiparis.nIskontoYuzdesi, tbSiparis.lIskontosuzTutari as lBrutTutar, CAST( (tbSiparis.lFiyati) * (100 + tbSiparis.nKdvOrani) / 100 AS MONEY) AS lDahilFiyat,CAST(tbSiparis.lFiyati * (100 + tbSiparis.nKdvOrani) / 100 AS MONEY) AS lDahilBrutFiyat,CAST(tbSiparis.lIskontosuzTutari * (100 + tbSiparis.nKdvOrani) / 100 AS MONEY) AS lDahilBrutTutar,tbSiparis.sSaticiRumuzu,tbStok.sModel, tbStok.sKodu, tbStok.sAciklama, (SELECT TOP 1 ISNULL(sBarkod , '') AS sBarkod FROM tbStokBarkodu WHERE nStokID = tbStok.nStokID and nKisim=0) AS sBarkod,(SELECT     sRenkAdi FROM          tbRenk WHERE      sRenk = tbStok.sRenk) AS sRenkAdi,tbStok.sBeden,tbStok.sKisaAdi,tbStok.nHacim,tbStok.nAgirlik,tbStok.sBirimCinsi1, tbStok.sBirimCinsi2,ISNULL((SELECT     ISNULL(lOran, 0) FROM         tbStokBirimCevrimi WHERE     nStokID = tbStok.nStokID AND sBirimCinsi = tbStok.sBirimCinsi2), 1) AS nBirimCarpan,tbSiparis.bKapandimi, tbSiparis.lReserveMiktari, tbSiparis.nPartiID,tbSiparis.sHangiUygulama, tbParti.nPartiID, tbParti.sKodu AS sKodu, tbSiparis.sSatirAciklama, tbSiparis.nValorGun, tbSiparis.sDovizCinsi, tbSiparis.lDovizFiyati, tbSiparis.lDovizKuru, CAST(SUBSTRING(tbSiparis.sSatirAciklama, 6, 5) AS MONEY) AS ISK1, CAST(SUBSTRING(tbSiparis.sSatirAciklama, 17, 5) AS MONEY) AS ISK2, CAST(SUBSTRING(tbSiparis.sSatirAciklama, 28, 5) AS MONEY) AS ISK3, CAST(SUBSTRING(tbSiparis.sSatirAciklama, 39, 5) AS MONEY) AS ISK4, CAST(0 AS MONEY) AS GERCEKFIYAT, CAST(0 AS MONEY) AS GERCEKTOPLAM, ISNULL(ABS(ROUND(tbSiparis.lTutari * (tbSiparis.nKdvOrani / 100), 2)), 0) AS lKdvTutari,tbSiparis.lIskontosuzTutari-tbSiparis.lTutari as lIskontoTutari, tbFirma.sKodu AS sFirmaKodu, tbFirma.sAciklama AS sFirmaAciklama,lDovizTutar = CASE WHEN tbSiparis.sDovizCinsi <> '' AND tbSiparis.lDovizKuru <> 0 THEN tbSiparis.lIskontosuzTutari / tbSiparis.lDovizKuru ELSE lIskontosuzTutari END, lDovizFiyati = CASE WHEN tbSiparis.sDovizCinsi <> '' AND tbSiparis.lDovizKuru <> 0 THEN  ((tbSiparis.lFiyati)) / tbSiparis.lDovizKuru ELSE  (tbSiparis.lFiyati) END,lDovizBrutFiyati = CASE WHEN tbSiparis.sDovizCinsi <> '' AND tbSiparis.lDovizKuru <> 0 THEN tbSiparis.lFiyati / tbSiparis.lDovizKuru ELSE tbSiparis.lFiyati END, lDahilDovizTutar = CASE WHEN tbSiparis.sDovizCinsi <> '' AND tbSiparis.lDovizKuru <> 0 THEN (tbSiparis.lIskontosuzTutari / tbSiparis.lDovizKuru) * (100 + tbSiparis.nKdvOrani) / 100 ELSE (tbSiparis.lIskontosuzTutari)* (100 + tbSiparis.nKdvOrani) / 100  END, lDahilDovizFiyati = CASE WHEN tbSiparis.sDovizCinsi <> '' AND tbSiparis.lDovizKuru <> 0 THEN ((tbSiparis.lFiyati) / tbSiparis.lDovizKuru)* (100 + tbSiparis.nKdvOrani) / 100 ELSE ((tbSiparis.lFiyati))* (100 + tbSiparis.nKdvOrani) / 100 END,lDahilDovizBrutFiyati = CASE WHEN tbSiparis.sDovizCinsi <> '' AND tbSiparis.lDovizKuru <> 0 THEN (tbSiparis.lFiyati / tbSiparis.lDovizKuru)* (100 + tbSiparis.nKdvOrani) / 100 ELSE (tbSiparis.lFiyati)* (100 + tbSiparis.nKdvOrani) / 100 END,(SELECT     ISNULL(SUM(MIKTAR),0) AS lYukleme FROM         ASTOKPAKETDETAY WHERE     (FISNO = tbSiparis.lSiparisNo) AND (FIRMANO = tbSiparis.nFirmaID) AND (IZAHAT = 'AS') AND (TARIH = tbSiparis.dteSiparisTarihi) AND (STOKNO = tbSiparis.nStokID)) as lYukleme,(SELECT     ABS(SUM(lGirisMiktar1) - SUM(lCikisMiktar1)) AS lSevkMiktari                            FROM          tbStokFisiDetayi                             WHERE      (nSiparisID IS NOT NULL) and tbStokFisiDetayi.nSiparisID = tbSiparis.nSiparisID) as lSevkiyat,ISNULL((SELECT isnull(lfiyat , 0) FROM tbstokfiyati WHERE nStokId = tbStok.NstokId AND sFiyatTipi = '" & sFiyat1 & "'),0) AS lFiyat1,ISNULL((SELECT isnull(lfiyat , 0) FROM tbstokfiyati WHERE nStokId = tbStok.NstokId AND sFiyatTipi = '" & sFiyat2 & "'),0) AS lFiyat2,ISNULL((SELECT isnull(lfiyat , 0) FROM tbstokfiyati WHERE nStokId = tbStok.NstokId AND sFiyatTipi = '" & sFiyat3 & "'),0) AS lFiyat3,ISNULL((SELECT isnull(lfiyat , 0) FROM tbstokfiyati WHERE nStokId = tbStok.NstokId AND sFiyatTipi = '" & sFiyat4 & "'),0) AS lFiyat4,ISNULL((SELECT isnull(lfiyat , 0) FROM tbstokfiyati WHERE nStokId = tbStok.NstokId AND sFiyatTipi = '" & sFiyatTipi & "'),0) AS lOzelFiyat,ISNULL((SELECT isnull(lfiyat , 0) FROM tbstokfiyati WHERE nStokId = tbStok.NstokId AND sFiyatTipi = '" & sFiyatM & "'),0) AS lMaliyet,ISNULL((SELECT isnull(lfiyat , 0) FROM tbstokfiyati WHERE nStokId = tbstok.NstokId AND sFiyatTipi = '" & sAltFiyatTipi & "'),0) AS lAltFiyat,ISNULL((SELECT isnull(lfiyat , 0) FROM tbstokfiyati WHERE nStokId = tbStok.NstokId AND sFiyatTipi = '" & sFiyatA & "'),0) AS lAlis,(tbSiparis.lTutari / tbSiparis.lMiktari) * (100 + tbSiparis.nKdvOrani) / 100 AS lNetFiyat,(SELECT     ISNULL(SUM(lGirisMiktar1 - lCikisMiktar1), 0) AS lMevcut FROM         tbStokFisiDetayi where tbStokFisiDetayi.nStokID = tbStok.nStokID) AS lMevcut FROM tbSiparis INNER JOIN tbStok ON tbSiparis.nStokID = tbStok.nStokID INNER JOIN tbParti ON tbSiparis.nPartiID = tbParti.nPartiID INNER JOIN tbFirma ON tbSiparis.nFirmaID = tbFirma.nFirmaID WHERE (tbSiparis.lSiparisNo = " & lSiparisNo & ") AND (tbSiparis.nSiparisTipi = " & nSiparisTipi & ") AND (tbSiparis.nFirmaID = " & nFirmaID & ") AND (tbSiparis.dteSiparisTarihi = '" & dteSiparisTarihi & "') ORDER BY tbSiparis.nSiparisTipi, tbSiparis.nFirmaID, tbSiparis.lSiparisNo, tbSiparis.nSiparisID"), "HAREKET")
        Return dsHareket
    End Function
    Public Sub Dataload_tbYekun(ByVal dteSiparisTarihi As DateTime, ByVal nSiparisTipi As Integer, ByVal lSiparisNo As Int64, ByVal nFirmaID As Int64)
        Try
            ds_tbSiparisToplam.Tables(0).Clear()
        Catch ex As Exception
        End Try
        Try
            Dim conn As New OleDb.OleDbConnection
            Dim cmd As New OleDb.OleDbCommand
            Dim adapter As New OleDb.OleDbDataAdapter
            conn.ConnectionString = connection
            adapter.SelectCommand = cmd
            cmd.CommandText = sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT SUM(tbSiparis.lMiktari) AS lMiktari, MAX(lDovizKuru) as lDovizKuru,SUM(tbSiparis.lIskontosuzTutari) AS lIskontosuzTutari, SUM(tbSiparis.lIskontosuzTutari - tbSiparis.lTutari) AS lIskonto,SUM(tbSiparis.lIskontosuzTutari - tbSiparis.lTutari) / SUM(tbSiparis.lIskontosuzTutari) AS nIsk, SUM(tbSiparis.lTutari)+SUM(ROUND(tbSiparis.lTutari * (tbSiparis.nKdvOrani / 100), 2))  AS lNetTutar,CAST(SUM(ROUND(tbSiparis.lTutari * (tbSiparis.nKdvOrani / 100), 2)) AS MONEY) AS lKdvTutari FROM tbSiparis INNER JOIN tbStok ON tbSiparis.nStokID = tbStok.nStokID INNER JOIN tbParti ON tbSiparis.nPartiID = tbParti.nPartiID WHERE (tbSiparis.lSiparisNo = " & lSiparisNo & ") AND (tbSiparis.nSiparisTipi = " & nSiparisTipi & ") AND (tbSiparis.nFirmaID = " & nFirmaID & ") AND (tbSiparis.dteSiparisTarihi = '" & dteSiparisTarihi & "') ")
            sorgu_txt_toplam = cmd.CommandText
            cmd.Connection = conn
            conn.Open()
            Dim N As Integer = adapter.Fill(ds_tbSiparisToplam, "TOPLAM")
            conn.Close()
            conn = Nothing
            cmd = Nothing
            adapter = Nothing
        Catch ex As Exception
        End Try
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
        sorgu_txt_firma = cmd.CommandText
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
    Public Function sorgu_sAciklama_kontrol(ByVal dteSiparisTarihi As DateTime, ByVal nSiparisTipi As Integer, ByVal lSiparisNo As Int64, ByVal nFirmaID As Int64) As Boolean
        Dim kriter
        Dim pass As Boolean
        kriter = ""
        Dim conn As New OleDb.OleDbConnection
        Dim cmd As New OleDb.OleDbCommand
        Dim adapter As New OleDb.OleDbDataAdapter
        conn.ConnectionString = connection
        cmd.Connection = conn
        conn.Open()
        cmd.CommandText = sorgu_query("SET DATEFORMAT DMY SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT ISNULL(COUNT(*),0) AS nKayit FROM tbSiparisAciklamasi WHERE (nSiparisTipi = " & nSiparisTipi & ") AND (lSiparisNo = " & lSiparisNo & ") and (nFirmaID = " & nFirmaID & ")")
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
    Private Function tbSiparis_kaydet_yeni(ByVal nSiparisID As Int64, ByVal nSiparisTipi As Int64, ByVal lSiparisNo As Int64, ByVal nFirmaID As Int64, ByVal nStokID As Int64, ByVal dteSiparisTarihi As DateTime, ByVal dteTeslimTarihi As DateTime, ByVal sSiparisIslem As String, ByVal nReceteNo As Int64, ByVal sSiparisiAlan As String, ByVal sSiparisiVeren As String, ByVal sFiyatTipi As String, ByVal lMiktari As Decimal, ByVal lFiyati As Decimal, ByVal lTutari As Decimal, ByVal sAsortiTipi As String, ByVal sAsortiMiktari As String, ByVal nKdvOrani As Int64, ByVal nIskontoYuzdesi As Int64, ByVal lIskontosuzTutari As Decimal, ByVal sKullaniciAdi As String, ByVal dteKayitTarihi As DateTime, ByVal bKapandimi As Integer, ByVal lReserveMiktari As Decimal, ByVal sHangiUygulama As String, ByVal nPartiID As Int64, ByVal sSatirAciklama As String, ByVal nValorGun As Int64, ByVal sDovizCinsi As String, ByVal lDovizFiyati As Decimal, ByVal lDovizKuru As Decimal, ByVal sSaticiRumuzu As String, ByVal sDepo As String, ByVal sBirimCinsi As String, ByVal lBirimMiktar As Decimal, ByVal sAmbalaj As String) As Int64
        Dim con As New OleDb.OleDbConnection
        Dim cmd As New OleDb.OleDbCommand
        cmd.Connection = con
        con.ConnectionString = connection
        If con.State = ConnectionState.Closed = True Then
            con.Open()
        End If
        'sSiparisiAlan = degeruzunlukkontrol(sSiparisiAlan, 30).ToString + degeruzunlukkontrol(sSiparisiVeren, 30).ToString
        cmd.CommandText = sorgu_query("SET DATEFORMAT DMY SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED INSERT INTO tbSiparis ( nSiparisTipi, lSiparisNo, nFirmaID, nStokID, dteSiparisTarihi, dteTeslimTarihi, sSiparisIslem, nReceteNo, sSiparisiAlan, sSiparisiVeren, sFiyatTipi, lMiktari, lFiyati, lTutari, sAsortiTipi, sAsortiMiktari, nKdvOrani, nIskontoYuzdesi, lIskontosuzTutari, sKullaniciAdi, dteKayitTarihi, bKapandimi, lReserveMiktari, sHangiUygulama, nPartiID, sSatirAciklama, nValorGun, sDovizCinsi, lDovizFiyati, lDovizKuru,sSaticiRumuzu,sDepo,sBirimCinsi,lBirimMiktar,sAmbalaj,bONAY) VALUES     ( " & nSiparisTipi & ", " & lSiparisNo & ", " & nFirmaID & ", " & nStokID & ", '" & dteSiparisTarihi & "', '" & dteTeslimTarihi & "', '" & sSiparisIslem & "', " & nReceteNo & ", '" & sSiparisiAlan & "', '" & sSiparisiVeren & "', '" & sFiyatTipi & "', " & lMiktari & ", " & lFiyati & ", " & lTutari & ", '" & sAsortiTipi & "', " & sAsortiMiktari & ", " & nKdvOrani & ", " & nIskontoYuzdesi & ", " & lIskontosuzTutari & ", '" & sKullaniciAdi & "', '" & dteKayitTarihi & "', " & bKapandimi & ", " & lReserveMiktari & ", '" & sHangiUygulama & "', " & nPartiID & ", '" & sSatirAciklama & "', " & nValorGun & ", '" & sDovizCinsi & "', " & lDovizFiyati & ", " & lDovizKuru & ",'" & sSaticiRumuzu & "','" & sDepo & "','" & sBirimCinsi & "'," & lBirimMiktar & ",'" & sAmbalaj & "',0)")
        cmd.ExecuteNonQuery()
        cmd.CommandText = "SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT @@identity"
        nSiparisID = cmd.ExecuteScalar

        ' AUDIT LOG: Sipariş satırı eklendi
        Try
            LogSiparis("YENI", nSiparisID, lSiparisNo.ToString(), "Sipariş satırı eklendi: Stok ID=" & nStokID & ", Miktar=" & lMiktari & ", Tutar=" & lTutari)
        Catch
        End Try

        Return nSiparisID
        con.Close()
        cmd = Nothing
        con = Nothing
    End Function
    Private Sub tbSiparis_kaydet_duzelt(ByVal nSiparisID As Int64, ByVal nSiparisTipi As Int64, ByVal lSiparisNo As Int64, ByVal nFirmaID As Int64, ByVal nStokID As Int64, ByVal dteSiparisTarihi As DateTime, ByVal dteTeslimTarihi As DateTime, ByVal sSiparisIslem As String, ByVal nReceteNo As Int64, ByVal sSiparisiAlan As String, ByVal sSiparisiVeren As String, ByVal sFiyatTipi As String, ByVal lMiktari As Decimal, ByVal lFiyati As Decimal, ByVal lTutari As Decimal, ByVal sAsortiTipi As String, ByVal sAsortiMiktari As String, ByVal nKdvOrani As Int64, ByVal nIskontoYuzdesi As Int64, ByVal lIskontosuzTutari As Decimal, ByVal sKullaniciAdi As String, ByVal dteKayitTarihi As DateTime, ByVal bKapandimi As Integer, ByVal lReserveMiktari As Decimal, ByVal sHangiUygulama As String, ByVal nPartiID As Int64, ByVal sSatirAciklama As String, ByVal nValorGun As Int64, ByVal sDovizCinsi As String, ByVal lDovizFiyati As Decimal, ByVal lDovizKuru As Decimal, ByVal sSaticiRumuzu As String, ByVal sDepo As String, ByVal sBirimCinsi As String, ByVal lBirimMiktar As Decimal, ByVal sAmbalaj As String)
        Dim con As New OleDb.OleDbConnection
        Dim cmd As New OleDb.OleDbCommand
        cmd.Connection = con
        con.ConnectionString = connection
        If con.State = ConnectionState.Closed = True Then
            con.Open()
        End If
        'If nSiparisTipi = 1 Or nSiparisTipi = 2 Then
        '    sSiparisiAlan = degeruzunlukkontrol(sSiparisiAlan, 30).ToString + degeruzunlukkontrol(sSiparisiVeren, 30).ToString
        'Else
        'End If
        ' AUDIT LOG: UPDATE öncesi eski değerleri al
        Dim eskiMiktar As String = ""
        Dim eskiFiyat As String = ""
        Dim eskiIskonto As String = ""
        Try
            Dim cmdLog As New OleDb.OleDbCommand("SELECT lMiktari, lFiyati, nIskontoYuzdesi FROM tbSiparis WHERE nSiparisID = " & nSiparisID, con)
            Dim drLog As OleDb.OleDbDataReader = cmdLog.ExecuteReader()
            If drLog.Read() Then
                eskiMiktar = If(IsDBNull(drLog("lMiktari")), "", drLog("lMiktari").ToString())
                eskiFiyat = If(IsDBNull(drLog("lFiyati")), "", drLog("lFiyati").ToString())
                eskiIskonto = If(IsDBNull(drLog("nIskontoYuzdesi")), "", drLog("nIskontoYuzdesi").ToString())
            End If
            drLog.Close()
        Catch
        End Try
        
        cmd.CommandText = sorgu_query("SET DATEFORMAT DMY SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED UPDATE tbSiparis SET lSiparisNo = " & lSiparisNo & ", nFirmaID = " & nFirmaID & ", nStokID = " & nStokID & ", dteSiparisTarihi = '" & dteSiparisTarihi & "', dteTeslimTarihi = '" & dteTeslimTarihi & "', sSiparisIslem = '" & sSiparisIslem & "', nReceteNo = " & nReceteNo & ", sSiparisiAlan = '" & sSiparisiAlan & "', sSiparisiVeren = '" & sSiparisiVeren & "', sFiyatTipi = '" & sFiyatTipi & "', lMiktari = " & lMiktari & ", lFiyati = " & lFiyati & ", lTutari = " & lTutari & ", sAsortiTipi = '" & sAsortiTipi & "', sAsortiMiktari = '" & sAsortiMiktari & "', nKdvOrani = " & nKdvOrani & ", nIskontoYuzdesi = " & nIskontoYuzdesi & ", lIskontosuzTutari = " & lIskontosuzTutari & ", bKapandimi = " & bKapandimi & ", lReserveMiktari = " & lReserveMiktari & ", sHangiUygulama = '" & sHangiUygulama & "', nPartiID = " & nPartiID & ", sSatirAciklama = '" & sSatirAciklama & "', nValorGun = " & nValorGun & ", sDovizCinsi = '" & sDovizCinsi & "', lDovizFiyati = " & lDovizFiyati & ", lDovizKuru = " & lDovizKuru & ",sSaticiRumuzu='" & sSaticiRumuzu & "',sDepo ='" & sDepo & "',sBirimCinsi = '" & sBirimCinsi & "',lBirimMiktar = " & lBirimMiktar & ",sAmbalaj = '" & sAmbalaj & "' Where nSiparisID = " & nSiparisID & " ")
        cmd.ExecuteNonQuery()

        ' AUDIT LOG: Her değişiklik için AYRI log kaydı - daha net!
        Try
            Dim yeniMiktar As String = lMiktari.ToString()
            Dim yeniFiyat As String = lFiyati.ToString()
            Dim yeniIskonto As String = nIskontoYuzdesi.ToString()
            
            ' Her alan için ayrı log yaz - karışıklık olmasın!
            If eskiMiktar <> yeniMiktar Then
                LogSiparis("GUNCELLE", nSiparisID, lSiparisNo.ToString(), "Miktar değiştirildi", eskiMiktar, yeniMiktar, "lMiktari")
            End If
            
            If eskiFiyat <> yeniFiyat Then
                LogSiparis("GUNCELLE", nSiparisID, lSiparisNo.ToString(), "Fiyat değiştirildi", eskiFiyat, yeniFiyat, "lFiyati")
            End If
            
            If eskiIskonto <> yeniIskonto Then
                LogSiparis("GUNCELLE", nSiparisID, lSiparisNo.ToString(), "İskonto değiştirildi", eskiIskonto, yeniIskonto, "nIskontoYuzdesi")
            End If
        Catch ex As Exception
            Debug.WriteLine("Audit log hatası: " & ex.Message)
        End Try

        con.Close()
        cmd = Nothing
        con = Nothing
    End Sub
    Private Sub tbSiparis_baslik_kaydet_duzelt(ByVal nFirmaID As Int64, ByVal nSiparisTipi As Int64, ByVal lSiparisNo As Int64, ByVal dteSiparisTarihi As DateTime, ByVal sSiparisiAlan As String, ByVal sSiparisiVeren As String, ByVal enSiparisTipi As Int64, ByVal elSiparisNo As Int64, ByVal edteSiparisTarihi As DateTime)
        Dim con As New OleDb.OleDbConnection
        Dim cmd As New OleDb.OleDbCommand
        cmd.Connection = con
        con.ConnectionString = connection
        If con.State = ConnectionState.Closed = True Then
            con.Open()
        End If
        sSiparisiAlan = degeruzunlukkontrol(sSiparisiAlan, 30).ToString + degeruzunlukkontrol(sSiparisiVeren, 30).ToString
        cmd.CommandText = sorgu_query("SET DATEFORMAT DMY SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED UPDATE    tbSiparis SET              lSiparisNo = " & lSiparisNo & ", dteSiparisTarihi = '" & dteSiparisTarihi & "', sSiparisiAlan = '" & sSiparisiAlan & "' Where nFirmaID = " & nFirmaID & " and nSiparisTipi = " & enSiparisTipi & " and dteSiparisTarihi = '" & edteSiparisTarihi & "' and lSiparisNo = " & elSiparisNo & " ")
        'cmd.CommandText = sorgu_query("SET DATEFORMAT DMY SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED UPDATE    tbSiparis SET              lSiparisNo = " & lSiparisNo & ", dteSiparisTarihi = '" & dteSiparisTarihi & "', sSiparisiAlan = '" & sSiparisiAlan & "', sSiparisiVeren = '" & sSiparisiVeren & "' Where nFirmaID = " & nFirmaID & " and nSiparisTipi = " & enSiparisTipi & " and dteSiparisTarihi = '" & edteSiparisTarihi & "' and lSiparisNo = " & elSiparisNo & " ")
        cmd.ExecuteNonQuery()
        con.Close()
        cmd = Nothing
        con = Nothing
    End Sub
    Private Sub tbSiparis_kaydet_sil(ByVal nSiparisID As String)
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
            cmd.CommandText = sorgu_query("DELETE FROM tbSiparis Where nSiparisID = '" & nSiparisID & "'")
            cmd.ExecuteNonQuery()

            ' AUDIT LOG: Sipariş satırı silindi
            Try
                LogSiparis("SIL", nSiparisID, "0", "Sipariş satırı silindi: ID=" & nSiparisID)
            Catch
            End Try

            cmd.CommandText = sorgu_query("IF @@TRANCOUNT > 0 COMMIT TRAN")
            cmd.ExecuteNonQuery()
        Catch ex As Exception
            cmd.CommandText = sorgu_query("IF @@TRANCOUNT > 0 COMMIT TRAN")
            cmd.ExecuteNonQuery()
            XtraMessageBox.Show(Sorgu_sDil("İşlem Hatası Lütfen Tekrar Deneyiniz...!", sDil), Sorgu_sDil("Dikkat", sDil), MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End Try
        cmd.CommandText = sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED UPDATE tbSiparisSiraNo SET nSonID = ISNULL((SELECT TOP 1 ISNULL(nSiparisID + 1 , 1) AS nSonID FROM tbSiparis ORDER BY nSiparisID DESC),1) WHERE (nSiraIndex = 1)")
        cmd.ExecuteNonQuery()
        con.Close()
        cmd = Nothing
        con = Nothing
    End Sub
    Private Sub tbSiparis_sil(ByVal dteSiparisTarihi As DateTime, ByVal nSiparisTipi As Integer, ByVal lSiparisNo As Int64, ByVal nFirmaID As Int64)
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
            cmd.CommandText = sorgu_query("delete tbSiparis Where lSiparisNo = " & lSiparisNo & " and  nSiparisTipi = " & nSiparisTipi & " and  nFirmaID = " & nFirmaID & "")
            cmd.ExecuteNonQuery()
            cmd.CommandText = sorgu_query("delete tbSiparisAciklamasi Where lSiparisNo = " & lSiparisNo & " and  nSiparisTipi = " & nSiparisTipi & " and  nFirmaID = " & nFirmaID & "")
            cmd.ExecuteNonQuery()
            cmd.CommandText = sorgu_query("delete tbSiparisPesinAdres Where lSiparisNo = " & lSiparisNo & " and  nSiparisTipi = " & nSiparisTipi & " ")
            cmd.ExecuteNonQuery()
            cmd.CommandText = sorgu_query("IF @@TRANCOUNT > 0 COMMIT TRAN")
            cmd.ExecuteNonQuery()
        Catch ex As Exception
            cmd.CommandText = sorgu_query("IF @@TRANCOUNT > 0 COMMIT TRAN")
            cmd.ExecuteNonQuery()
            XtraMessageBox.Show(Sorgu_sDil("İşlem Hatası Lütfen Tekrar Deneyiniz...!", sDil), Sorgu_sDil("Dikkat", sDil), MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End Try
        cmd.CommandText = sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED UPDATE tbSiparisSiraNo SET nSonID = ISNULL((SELECT TOP 1 ISNULL(nSiparisID + 1 , 1) AS nSonID FROM tbSiparis ORDER BY nSiparisID DESC),1) WHERE (nSiraIndex = 1)")
        cmd.ExecuteNonQuery()
        con.Close()
        cmd = Nothing
        con = Nothing
    End Sub
    Private Sub tbSiparis_Aciklamasi_kaydet_duzelt(ByVal nSiparisTipi As Int64, ByVal lSiparisNo As Int64, ByVal nFirmaID As Int64, ByVal sAciklama1 As String, ByVal sAciklama2 As String, ByVal sAciklama3 As String, ByVal sAciklama4 As String, ByVal sAciklama5 As String, ByVal bKilitli As Byte, ByVal bListelendimi As Byte)
        Dim con As New OleDb.OleDbConnection
        Dim cmd As New OleDb.OleDbCommand
        cmd.Connection = con
        con.ConnectionString = connection
        If con.State = ConnectionState.Closed = True Then
            con.Open()
        End If
        cmd.CommandText = sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT COUNT(*) from tbSiparisAciklamasi Where nSiparisTipi =" & nSiparisTipi & " and lSiparisNo =" & lSiparisNo & " and nFirmaID =" & nFirmaID & "")
        Dim sayi = cmd.ExecuteNonQuery
        If sayi = 0 Then
            cmd.CommandText = sorgu_query("SET DATEFORMAT DMY  INSERT INTO tbSiparisAciklamasi (nSiparisTipi, lSiparisNo, nFirmaID, sAciklama1, sAciklama2, sAciklama3, sAciklama4, sAciklama5,bKilitli,bListelendimi) VALUES     (" & nSiparisTipi & ", " & lSiparisNo & ", " & nFirmaID & ", '" & sAciklama1 & "', '" & sAciklama2 & "', '" & sAciklama3 & "', '" & sAciklama4 & "', '" & sAciklama5 & "'," & bKilitli & "," & bListelendimi & ")")
            cmd.ExecuteNonQuery()
        Else
            cmd.CommandText = sorgu_query("SET DATEFORMAT DMY  UPDATE    tbSiparisAciklamasi SET              sAciklama1 = '" & sAciklama1 & "', sAciklama2 = '" & sAciklama2 & "', sAciklama3 = '" & sAciklama3 & "', sAciklama4 = '" & sAciklama4 & "', sAciklama5 = '" & sAciklama5 & "',bKilitli= " & bKilitli & ",bListelendimi = " & bListelendimi & " Where nSiparisTipi = " & nSiparisTipi & " AND  lSiparisNo = " & lSiparisNo & " AND nFirmaID = " & nFirmaID & " ")
            cmd.ExecuteNonQuery()
        End If
        con.Close()
        cmd = Nothing
        con = Nothing
    End Sub
    Private Sub tbSiparis_Aciklamasi_kaydet_yeni(ByVal nSiparisTipi As Int64, ByVal lSiparisNo As Int64, ByVal nFirmaID As Int64, ByVal sAciklama1 As String, ByVal sAciklama2 As String, ByVal sAciklama3 As String, ByVal sAciklama4 As String, ByVal sAciklama5 As String, ByVal bKilitli As Byte)
        Dim con As New OleDb.OleDbConnection
        Dim cmd As New OleDb.OleDbCommand
        cmd.Connection = con
        con.ConnectionString = connection
        If con.State = ConnectionState.Closed = True Then
            con.Open()
        End If
        cmd.CommandText = sorgu_query("SET DATEFORMAT DMY  INSERT INTO tbSiparisAciklamasi (nSiparisTipi, lSiparisNo, nFirmaID, sAciklama1, sAciklama2, sAciklama3, sAciklama4, sAciklama5,bKilitli) VALUES     (" & nSiparisTipi & ", " & lSiparisNo & ", " & nFirmaID & ", '" & sAciklama1 & "', '" & sAciklama2 & "', '" & sAciklama3 & "', '" & sAciklama4 & "', '" & sAciklama5 & "'," & bKilitli & ")")
        Try
            cmd.ExecuteNonQuery()
        Catch ex As Exception
        End Try
        con.Close()
        cmd = Nothing
        con = Nothing
    End Sub
    Private Function tbFirmaHareketi_kaydet_yeni(ByVal nHareketID As Int64, ByVal nFirmaID As Int64, ByVal dteIslemTarihi As DateTime, ByVal dteValorTarihi As DateTime, ByVal sCariIslem As String, ByVal sAciklama As String, ByVal lBorcTutar As Decimal, ByVal lAlacakTutar As Decimal, ByVal sEvrakNo As String, ByVal lVadeFarki As Decimal, ByVal sHangiUygulama As String, ByVal sHareketTipi As String, ByVal sKullaniciAdi As String, ByVal dteKayitTarihi As DateTime, ByVal sDovizCinsi1 As String, ByVal lDovizMiktari1 As Decimal, ByVal lDovizKuru As Decimal, ByVal sDovizCinsi2 As String, ByVal lDovizMiktari2 As Decimal, ByVal lDovizKuru2 As Decimal, ByVal sSonKullaniciAdi As String, ByVal dteSonUpdateTarihi As DateTime) As Int64
        Dim con As New OleDb.OleDbConnection
        Dim cmd As New OleDb.OleDbCommand
        cmd.Connection = con
        con.ConnectionString = connection
        If con.State = ConnectionState.Closed = True Then
            con.Open()
        End If
        cmd.CommandText = sorgu_query("SET DATEFORMAT DMY  INSERT INTO tbFirmaHareketi                       (nFirmaID, dteIslemTarihi, dteValorTarihi, sCariIslem, sAciklama, lBorcTutar, lAlacakTutar, sEvrakNo, lVadeFarki, sHangiUygulama, sHareketTipi, sKullaniciAdi, dteKayitTarihi, sDovizCinsi1, lDovizMiktari1, lDovizKuru, sDovizCinsi2, lDovizMiktari2, lDovizKuru2, sSonKullaniciAdi, dteSonUpdateTarihi) VALUES     ('" & nFirmaID & "', '" & dteIslemTarihi & "', '" & dteValorTarihi & "', '" & sCariIslem & "', N'" & sAciklama & "', " & lBorcTutar & ", " & lAlacakTutar & " , '" & sEvrakNo & "', " & lVadeFarki & ", '" & sHangiUygulama & "', '" & sHareketTipi & "', '" & sKullaniciAdi & "', '" & dteKayitTarihi & "', '" & sDovizCinsi1 & "', " & lDovizMiktari1 & ", " & lDovizKuru & " , '" & sDovizCinsi2 & "', " & lDovizMiktari2 & ", " & lDovizKuru2 & " , '" & sSonKullaniciAdi & "', '" & dteSonUpdateTarihi & "')")
        cmd.ExecuteNonQuery()
        cmd.CommandText = "SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT @@identity"
        nHareketID = cmd.ExecuteScalar
        Return nHareketID
        con.Close()
        cmd = Nothing
        con = Nothing
    End Function
    Private Sub tbFirmaHareketi_kaydet_duzelt(ByVal nHareketID As Int64, ByVal nFirmaID As Int64, ByVal dteIslemTarihi As DateTime, ByVal dteValorTarihi As DateTime, ByVal sCariIslem As String, ByVal sAciklama As String, ByVal lBorcTutar As Decimal, ByVal lAlacakTutar As Decimal, ByVal sEvrakNo As String, ByVal lVadeFarki As Decimal, ByVal sHangiUygulama As String, ByVal sHareketTipi As String, ByVal sKullaniciAdi As String, ByVal dteKayitTarihi As DateTime, ByVal sDovizCinsi1 As String, ByVal lDovizMiktari1 As Decimal, ByVal lDovizKuru As Decimal, ByVal sDovizCinsi2 As String, ByVal lDovizMiktari2 As Decimal, ByVal lDovizKuru2 As Decimal, ByVal sSonKullaniciAdi As String, ByVal dteSonUpdateTarihi As DateTime)
        Dim con As New OleDb.OleDbConnection
        Dim cmd As New OleDb.OleDbCommand
        cmd.Connection = con
        con.ConnectionString = connection
        If con.State = ConnectionState.Closed = True Then
            con.Open()
        End If
        cmd.CommandText = sorgu_query("SET DATEFORMAT DMY  UPDATE    tbFirmaHareketi SET              nFirmaID = '" & nFirmaID & "', dteIslemTarihi = '" & dteIslemTarihi & "', dteValorTarihi = '" & dteValorTarihi & "', sCariIslem = '" & sCariIslem & "', sAciklama = N'" & sAciklama & "', lBorcTutar = " & lBorcTutar & ", lAlacakTutar = " & lAlacakTutar & ", sEvrakNo = '" & sEvrakNo & "', lVadeFarki = " & lVadeFarki & ", sHangiUygulama = '" & sHangiUygulama & "', sHareketTipi = '" & sHareketTipi & "', sDovizCinsi1 = '" & sDovizCinsi1 & "', lDovizMiktari1 = " & lDovizMiktari1 & ", lDovizKuru = " & lDovizKuru & ", sDovizCinsi2 = '" & sDovizCinsi2 & "', lDovizMiktari2 = " & lDovizMiktari2 & ", lDovizKuru2 = " & lDovizKuru2 & ", sSonKullaniciAdi = '" & sSonKullaniciAdi & "', dteSonUpdateTarihi = '" & dteSonUpdateTarihi & "'  WHERE     (nHareketID = " & nHareketID & ")")
        cmd.ExecuteNonQuery()
        con.Close()
        cmd = Nothing
        con = Nothing
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
        cmd = Nothing
        con = Nothing
    End Sub
    Private Sub nSiparisID_degistir(ByVal nSiparisID As String)
        Dim con As New OleDb.OleDbConnection
        Dim cmd As New OleDb.OleDbCommand
        Dim adapter As New OleDb.OleDbDataAdapter
        con.ConnectionString = connection
        cmd.Connection = con
        If con.State = ConnectionState.Closed Then
            con.Open()
        End If
        cmd.CommandText = sorgu_query("SET DATEFORMAT DMY SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED UPDATE    tbSiparisSiraNo SET              nSonID = '" & nSiparisID & "' where nSiraIndex = 1")
        cmd.ExecuteNonQuery()
        con.Close()
        cmd = Nothing
        con = Nothing
    End Sub
    Private Sub lSiparisNo_degistir(ByVal nSiparisTipi As Int64)
        ' DÜZELTME: Counter'ı basitçe +1 artır (MAX'e göre değil!)
        ' Bu şekilde race condition ve çakışma önlenir
        Dim con As New OleDb.OleDbConnection
        Dim cmd As New OleDb.OleDbCommand
        con.ConnectionString = connection
        cmd.Connection = con
        If con.State = ConnectionState.Closed Then
            con.Open()
        End If

        ' Basit INCREMENT yaklaşımı - daha güvenli!
        If nSiparisTipi = 1 Then
            ' Alış siparişi için tbParamAlSiparis
            cmd.CommandText = sorgu_query("UPDATE tbParamAlSiparis SET lSonSiparisNo = ISNULL(lSonSiparisNo, 0) + 1")
        Else
            ' Diğer sipariş tipleri için tbParamVerSiparis
            cmd.CommandText = sorgu_query("UPDATE tbParamVerSiparis SET lSonSiparisNo = ISNULL(lSonSiparisNo, 0) + 1")
        End If

        cmd.ExecuteNonQuery()
        con.Close()
        cmd = Nothing
        con = Nothing
    End Sub
    Private Sub satir_ekle(Optional ByVal ara As String = "", Optional ByVal sKonum As String = "")
        ' Parametrik onay kontrolu - bOnayVar = TRUE ise kontrol yap
        Dim dtParamOnay2 As DataTable = SQLCalistir("SELECT ISNULL(bOnayVar, 0) AS bOnayVar FROM tbParamAlSiparis")
        Dim bOnayVarParam2 As Boolean = False
        If dtParamOnay2.Rows.Count > 0 Then
            bOnayVarParam2 = Convert.ToBoolean(dtParamOnay2.Rows(0)("bOnayVar"))
        End If
        
        If bOnayVarParam2 Then
            Dim dtOnay As DataTable = SQLCalistir("SELECT ISNULL(bOnay, 0) FROM tbSiparis  WHERE lSiparisNo = " & lSiparisNo & " AND nFirmaID = " & nFirmaID)
            If dtOnay.Rows.Count > 0 AndAlso Convert.ToBoolean(dtOnay.Rows(0)(0)) Then
                MessageBox.Show("Sevk Onayı verilmiş Siparişte değişiklik yapamazsınız.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Exit Sub
            End If
        End If
        Dim frm As New frm_stok
        frm.islemstatus = True
        frm.connection = connection
        frm.firmano = firmano
        frm.donemno = donemno
        frm.islemstatus = True
        frm.kullanici = kullanici
        status = True
        If ara <> "" Then
            frm.qgelismis = sec_kriter.Text
            frm.gelismis = ara
            frm.status = True
            frm.mevcut = mevcut
        End If
        Dim lMiktar As Decimal = 0
        Dim lBrutFiyat As Decimal = 0
        Dim lBrutTutar As Decimal = 0
        Dim lFiyat As Decimal = 0
        Dim lGercekFiyat As Decimal = 0
        Dim lGercekToplam As Decimal = 0
        Dim lIsktutar As Decimal = 0
        Dim lkdvtutar As Decimal = 0
        Dim isk1 As Decimal = 0
        Dim isk2 As Decimal = 0
        Dim isk3 As Decimal = 0
        Dim isk4 As Decimal = 0
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
                    dr = ds_tbSiparis.Tables(0).NewRow
                    dr1 = frm.GridView1.GetDataRow(s)
                    Dim nSiparisID As Int64 = sorgu_nSiparisID()
                    dr("nSiparisID") = nSiparisID
                    dr("nSiparisTipi") = dr_baslik("nSiparisTipi")
                    dr("lSiparisNo") = dr_baslik("lSiparisNo")
                    dr("nFirmaID") = nFirmaID
                    dr("nStokID") = dr1("nStokID")
                    dr("dteSiparisTarihi") = dr_baslik("dteSiparisTarihi")
                    dr("dteTeslimTarihi") = dr_baslik("dteSiparisTarihi")
                    dr("sSiparisIslem") = ""
                    dr("nReceteNo") = 0
                    dr("sSiparisiAlan") = degeruzunlukkontrol(Trim(dr_baslik("sSiparisiAlan").ToString), 30)
                    dr("sSiparisiAlan") += degeruzunlukkontrol(Trim(dr_baslik("sSiparisiVeren").ToString), 30)
                    dr("sSiparisiVeren") = dr1("sAciklama") 'dr_baslik("sSiparisiVeren").ToString
                    dr("sFiyatTipi") = sFiyatTipi
                    dr1("lFiyat1") = sorgu_sayi(dr1("lFiyat1"), 0)
                    dr1("lFiyat2") = sorgu_sayi(dr1("lFiyat2"), 0)
                    dr1("lFiyat3") = sorgu_sayi(dr1("lFiyat3"), 0)
                    dr("sFiyatTipi") = sFiyatTipi.ToString
                    dr("lMiktari") = frm.mevcut
                    dr("lMiktar") = frm.mevcut
                    If Trim(dr1("sDovizCinsi")) <> "" Then
                        dr1("lFiyat1") = sorgu_sayi(dr1("lFiyat1"), 0) * sorgu_lDovizKuru(dr1("sDovizCinsi"))
                        dr1("lFiyat2") = sorgu_sayi(dr1("lFiyat2"), 0) * sorgu_lDovizKuru(dr1("sDovizCinsi"))
                        dr1("lFiyat3") = sorgu_sayi(dr1("lFiyat3"), 0) * sorgu_lDovizKuru(dr1("sDovizCinsi"))
                        dr1("lFiyat4") = sorgu_sayi(dr1("lFiyat4"), 0) * sorgu_lDovizKuru(dr1("sDovizCinsi"))
                        dr1("MALIYET") = sorgu_sayi(dr1("MALIYET"), 0) * sorgu_lDovizKuru(dr1("sDovizCinsi"))
                        dr1("ALISFIYATI") = sorgu_sayi(dr1("ALISFIYATI"), 0) * sorgu_lDovizKuru(dr1("sDovizCinsi"))
                        dr1("lAltFiyat") = sorgu_sayi(dr1("lAltFiyat"), 0) * sorgu_lDovizKuru(dr1("sDovizCinsi"))
                        'dr1("lUstFiyat") = sorgu_sayi(dr1("lUstFiyat"), 0) * sorgu_lDovizKuru(dr1("sDovizCinsi"))
                        'dr1("lOzelFiyat") = sorgu_sayi(dr1("lOzelFiyat"), 0) * sorgu_lDovizKuru(dr1("sDovizCinsi"))
                    End If
                    If dr_baslik("nSiparisTipi") = 2 Then
                        sFiyatTipi = sFiyatA
                        dr("sFiyatTipi") = sFiyatA
                        dr("lBrutFiyat") = sorgu_sayi(dr1("ALISFIYATI"), 0)
                        dr("lTutari") = dr("lMiktari") * sorgu_sayi(dr1("ALISFIYATI"), 0)
                        dr("lBrutTutar") = dr("lMiktari") * sorgu_sayi(dr1("ALISFIYATI"), 0)
                        lFiyat = sorgu_sayi(dr1("ALISFIYATI"), 0)
                    ElseIf dr_baslik("nSiparisTipi") = 1 Or dr_baslik("nSiparisTipi") = 4 Then
                        'dr("sFiyatTipi") = ""
                        dr1("lFiyat1") = sorgu_sayi(dr1("lFiyat1"), 0)
                        dr1("lFiyat2") = sorgu_sayi(dr1("lFiyat2"), 0)
                        dr1("lFiyat3") = sorgu_sayi(dr1("lFiyat3"), 0)
                        If Trim(dr_baslik("sFiyatTipi").ToString) <> "" Then
                            sFiyatTipi = Trim(dr_baslik("sFiyatTipi"))
                            dr("sFiyatTipi") = sFiyatTipi
                            If Trim(sFiyatTipi) = Trim(sFiyat1) Then
                                If bFiyatKdvHaric = False Then
                                    lBrutFiyat = dr1("lFiyat1") / ((100 + dr1("nKdvOrani")) / 100)
                                Else
                                    lBrutFiyat = dr1("lFiyat1")
                                End If
                                lBrutTutar = lBrutFiyat * frm.mevcut
                            ElseIf Trim(sFiyatTipi) = Trim(sFiyat2) Then
                                If bFiyatKdvHaric = False Then
                                    lBrutFiyat = dr1("lFiyat2") / ((100 + dr1("nKdvOrani")) / 100)
                                Else
                                    lBrutFiyat = dr1("lFiyat2")
                                End If
                                lBrutTutar = lBrutFiyat * frm.mevcut
                            ElseIf Trim(sFiyatTipi) = Trim(sFiyat3) Then
                                If bFiyatKdvHaric = False Then
                                    lBrutFiyat = dr1("lFiyat3") / ((100 + dr1("nKdvOrani")) / 100)
                                Else
                                    lBrutFiyat = dr1("lFiyat3")
                                End If
                                lBrutTutar = lBrutFiyat * frm.mevcut
                            ElseIf Trim(sFiyatTipi) = "PR" Then
                                lBrutFiyat = 0.01
                                lBrutTutar = 0.01 * frm.mevcut
                            Else
                                Dim llfiyat As Decimal = sorgu_stok_fiyat(dr_baslik("sFiyatTipi"), dr1("nStokID"))
                                If llfiyat = 0 Then
                                    llfiyat = dr1("lFiyat1")
                                End If
                                If bFiyatKdvHaric = False Then
                                    lBrutFiyat = llfiyat / ((100 + dr1("nKdvOrani")) / 100)
                                Else
                                    lBrutFiyat = sorgu_sayi(llfiyat, 0)
                                End If
                                lBrutTutar = lBrutFiyat * frm.mevcut
                                'If bFiyatKdvHaric = False Then
                                '    lBrutFiyat = dr1("lOzelFiyat") / ((100 + dr1("nKdvOrani")) / 100)
                                'Else
                                '    lBrutFiyat = sorgu_sayi(dr1("lOzelFiyat"), 0)
                                'End If
                                'lBrutTutar = lBrutFiyat * frm.mevcut
                            End If
                        Else
                            sFiyatTipi = sFiyat1
                            If bFiyatKdvHaric = False Then
                                lBrutFiyat = dr1("lFiyat1") / ((100 + dr1("nKdvOrani")) / 100)
                            Else
                                lBrutFiyat = dr1("lFiyat1")
                            End If
                            lBrutTutar = lBrutFiyat * frm.mevcut
                            dr("sFiyatTipi") = sFiyatTipi
                        End If
                    End If
                    dr("nKdvOrani") = dr1("nKdvOrani")
                    dr("ISK1") = sorgu_sayi(dr_baslik("nOzelIskontosu"), 0)
                    dr("ISK2") = 0
                    dr("ISK3") = 0
                    dr("ISK4") = 0
                    If sorgu_sayi(dr1("nIskontoYuzdesi"), 0) <> 0 Then
                        dr("ISK1") = sorgu_sayi(dr1("nIskontoYuzdesi"), 0)
                    End If
                    lMiktar = frm.mevcut
                    sorgu_tbProtokol(dr_baslik("nFirmaID"), dr("nStokID"))
                    If ds_Protokol.Tables(0).Rows.Count <> 0 Then
                        Dim dr2 As DataRow
                        dr2 = ds_Protokol.Tables(0).Rows(0)
                        'FiyatTipi
                        If Trim(dr2("sFiyatTipi")) <> "" And Trim(dr2("sFiyatTipi")) <> Trim(dr("sFiyatTipi")) Then
                            dr("sFiyatTipi") = dr2("sFiyatTipi")
                            If Trim(dr2("sFiyatTipi")) = Trim(sFiyat1) Then
                                If bFiyatKdvHaric = False Then
                                    lBrutFiyat = dr1("lFiyat1") / ((100 + dr1("nKdvOrani")) / 100)
                                Else
                                    lBrutFiyat = dr1("lFiyat1")
                                End If
                                lBrutTutar = lBrutFiyat * lMiktar
                            ElseIf Trim(dr2("sFiyatTipi")) = Trim(sFiyat2) Then
                                If bFiyatKdvHaric = False Then
                                    lBrutFiyat = dr1("lFiyat2") / ((100 + dr1("nKdvOrani")) / 100)
                                Else
                                    lBrutFiyat = dr1("lFiyat2")
                                End If
                                lBrutTutar = lBrutFiyat * lMiktar
                            ElseIf Trim(dr2("sFiyatTipi")) = Trim(sFiyat3) Then
                                If bFiyatKdvHaric = False Then
                                    lBrutFiyat = dr1("lFiyat3") / ((100 + dr1("nKdvOrani")) / 100)
                                Else
                                    lBrutFiyat = dr1("lFiyat3")
                                End If
                                lBrutTutar = lBrutFiyat * lMiktar
                            ElseIf Trim(dr2("sFiyatTipi")) = "PR" Then
                                lBrutFiyat = 0.01
                                lBrutTutar = 0.01 * lMiktar
                            Else
                                Dim llfiyat As Decimal = sorgu_stok_fiyat(dr2("sFiyatTipi"), dr1("nStokID"))
                                If llfiyat = 0 Then
                                    llfiyat = dr1("lFiyat1")
                                End If
                                If bFiyatKdvHaric = False Then
                                    lBrutFiyat = llfiyat / ((100 + dr1("nKdvOrani")) / 100)
                                Else
                                    lBrutFiyat = sorgu_sayi(llfiyat, 0)
                                End If
                                lBrutTutar = lBrutFiyat * lMiktar
                            End If
                            If lBrutFiyat = 0 Then
                                If bFiyatKdvHaric = False Then
                                    lBrutFiyat = dr1("lFiyat1") / ((100 + dr1("nKdvOrani")) / 100)
                                Else
                                    lBrutFiyat = dr1("lFiyat1")
                                End If
                            End If
                            lBrutTutar = lBrutFiyat * lMiktar
                            'dr("lBrutTutar") = lBrutTutar
                            'dr("lBrutFiyat") = lBrutFiyat
                            'dr("lFiyat") = lBrutFiyat
                            'dr("lDahilBrutFiyat") = lBrutFiyat * ((dr("nKdvOrani") + 100) / 100)
                            'dr("lDahilFiyat") = dr("lDahilBrutFiyat")
                            'dr("lDahilBrutTutar") = dr("lDahilBrutFiyat") * lMiktar
                        End If
                        'Kdv
                        If Trim(dr2("nKdvOrani")) <> -1 Then
                            dr("nKdvOrani") = dr2("nKdvOrani")
                        End If
                        'Fiyat
                        If Trim(dr2("lFiyat")) <> 0 Then
                            dr("lBrutFiyat") = dr2("lFiyat")
                            If bFiyatKdvHaric = False Then
                                lBrutFiyat = dr2("lFiyat") / ((100 + dr1("nKdvOrani")) / 100)
                            Else
                                lBrutFiyat = dr1("lFiyiat")
                            End If
                            lBrutTutar = lBrutFiyat * lMiktar
                            'dr("lBrutTutar") = lBrutTutar
                            'dr("lBrutFiyat") = lBrutFiyat
                            'dr("lFiyat") = lBrutFiyat
                            'dr("lDahilBrutFiyat") = lBrutFiyat * ((dr("nKdvOrani") + 100) / 100)
                            'dr("lDahilFiyat") = dr("lDahilBrutFiyat")
                            'dr("lDahilBrutTutar") = dr("lDahilBrutFiyat") * lMiktar
                        End If
                        dr("ISK1") = dr2("nIskontoYuzdesi1")
                        dr("ISK2") = dr2("nIskontoYuzdesi2")
                        dr("ISK3") = dr2("nIskontoYuzdesi3")
                        dr("ISK4") = dr2("nIskontoYuzdesi4")
                    End If
                    dr("sFiyatTipi") = Trim(sFiyatTipi)
                    If bImport = True And bImport_Fiyat = True Then
                        lBrutFiyat = bIFiyati
                    End If
                    If bImport = True And bImport_Tutar = True Then
                        lBrutFiyat = bITutari / mevcut
                        lBrutTutar = bITutari
                    End If
                    If lBrutFiyat = 0 Then
                        lBrutFiyat = 0.001
                        lBrutTutar = lBrutFiyat * frm.mevcut
                    End If
                    dr("lBrutTutar") = lBrutTutar
                    dr("lBrutFiyat") = lBrutFiyat
                    dr("lFiyat") = lBrutFiyat
                    dr("lFiyati") = lBrutFiyat
                    dr("lDahilBrutFiyat") = lBrutFiyat * ((dr("nKdvOrani") + 100) / 100)
                    dr("lDahilFiyat") = dr("lDahilBrutFiyat")
                    dr("lDahilBrutTutar") = dr("lDahilBrutFiyat") * lMiktar
                    lFiyat = dr("lBrutFiyat")
                    Dim lTutar As Decimal = 0
                    lFiyat = dr("lBrutFiyat")
                    isk1 = lFiyat * ((100 - dr("ISK1")) / 100)
                    isk2 = isk1 * ((100 - dr("ISK2")) / 100)
                    isk3 = isk2 * ((100 - dr("ISK3")) / 100)
                    isk4 = isk3 * ((100 - dr("ISK4")) / 100)
                    dr("nIskontoYuzdesi") = ((dr("lBrutFiyat") - isk4) / dr("lBrutFiyat")) * 100
                    dr("lNetFiyat") = (isk4 * ((dr("nKdvOrani") + 100) / 100))
                    lTutar = isk4 * dr("lMiktari")
                    dr("lTutari") = lTutar
                    dr("lIskontoTutari") = dr("lBrutTutar") - lTutar
                    dr("sAsortiTipi") = ""
                    dr("sAsortiMiktari") = 0
                    'dr("nKdvOrani") = dr1("nKdvOrani")
                    'dr("nIskontoYuzdesi") = dr_baslik("nOzelIskontosu")
                    dr("sKullaniciAdi") = kullaniciadi
                    dr("dteKayitTarihi") = Now
                    dr("bKapandimi") = 0
                    dr("lReserveMiktari") = 0
                    dr("sHangiUygulama") = ""
                    dr("nPartiID") = 0
                    dr("sSatirAciklama") = "Isk1:" & uzunluk_tamamla(FormatNumber(dr("ISK1"), 2), 5) & " Isk2:" & uzunluk_tamamla(FormatNumber(dr("ISK2"), 2), 5) & " Isk3:" & uzunluk_tamamla(FormatNumber(dr("ISK3"), 2), 5) & " Isk4:" & uzunluk_tamamla(FormatNumber(dr("ISK4"), 2), 5)
                    dr("nValorGun") = 0
                    dr("sDovizCinsi") = ""
                    dr("lDovizFiyati") = 0
                    dr("lDovizKuru") = 0
                    dr("sModel") = dr1("sModel")
                    dr("sKodu") = dr1("sKodu")
                    dr("sAciklama") = dr1("sAciklama")
                    dr("sFirmaKodu") = dr_baslik("sKodu")
                    dr("sFirmaAciklama") = dr_baslik("sAciklama")
                    dr("sSaticiRumuzu") = dr_baslik("sSaticiRumuzu")
                    dr("sKisaAdi") = dr1("sKisaAdi").ToString
                    dr("nHacim") = sorgu_sayi(dr1("nHacim"), 0)
                    dr("nAgirlik") = sorgu_sayi(dr1("nAgirlik"), 0)
                    dr("sBirimCinsi") = dr1("sBirimCinsi1").ToString
                    dr("sAmbalaj") = dr1("sBirimCinsi1").ToString
                    dr("sBirimCinsi1") = dr1("sBirimCinsi1").ToString
                    dr("lBirimMiktar") = 1
                    dr("nBirimCarpan") = sorgu_sayi(dr1("nBirimCarpan"), 1)
                    dr("sBarkod") = dr1("sBarkod")
                    dr("sDepo") = sDepo
                    dr("sRenkAdi") = dr1("sRenkAdi")
                    dr("sBeden") = dr1("sBeden")
                    dr("lDahilBrutFiyat") = dr("lBrutFiyat") * ((dr("nKdvOrani") + 100) / 100)
                    dr("lDahilFiyat") = dr("lDahilBrutFiyat")
                    dr("lDahilBrutTutar") = dr("lDahilBrutFiyat") * frm.mevcut
                    dr("lFiyat") = dr("lBrutFiyat")
                    'dr("nBirimCarpan") = sorgu_sayi(dr1("nBirimCarpan"), 1)
                    'Doviz Hesapla
                    If dr("sDovizCinsi").ToString <> "" And dr("lDovizKuru") <> 0 Then
                        dr("lDovizFiyati") = dr("lBrutFiyat") / dr("lDovizKuru")
                        dr("lDovizBrutFiyati") = dr("lBrutFiyat") / dr("lDovizKuru")
                        dr("lDovizTutar") = dr("lBrutTutar") / dr("lDovizKuru")
                        dr("lDahilDovizFiyati") = dr("lBrutFiyat")
                        dr("lDahilDovizBrutFiyati") = dr("lBrutFiyat")
                        dr("lDahilDovizTutar") = dr("lBrutTutar")
                    Else
                        dr("lDovizFiyati") = dr("lBrutFiyat")
                        dr("lDovizBrutFiyati") = dr("lBrutFiyat")
                        dr("lDovizTutar") = dr("lBrutTutar")
                        dr("lDahilDovizFiyati") = dr("lBrutFiyat")
                        dr("lDahilDovizBrutFiyati") = dr("lBrutFiyat")
                        dr("lDahilDovizTutar") = dr("lBrutTutar")
                    End If
                    'dr("lSevkiyat") = 0
                    dr("lYukleme") = 0
                    dr("nSiparisID") = tbSiparis_kaydet_yeni(dr("nSiparisID"), dr("nSiparisTipi"), dr("lSiparisNo"), dr("nFirmaID"), dr("nStokID"), dr("dteSiparisTarihi"), dr("dteTeslimTarihi"), dr("sSiparisIslem"), dr("nReceteNo"), dr("sSiparisiAlan"), dr("sSiparisiVeren"), dr("sFiyatTipi"), dr("lMiktari"), dr("lBrutFiyat"), dr("lTutari"), dr("sAsortiTipi"), dr("sAsortiMiktari"), dr("nKdvOrani"), dr("nIskontoYuzdesi"), dr("lBrutTutar"), kullaniciadi, Now, dr("bKapandimi"), dr("lReserveMiktari"), dr("sHangiUygulama"), dr("nPartiID"), dr("sSatirAciklama"), dr("nValorGun"), dr("sDovizCinsi"), dr("lDovizFiyati"), dr("lDovizKuru"), dr("sSaticiRumuzu"), dr("sDepo"), dr("sBirimCinsi"), dr("lBirimMiktar"), dr("sAmbalaj"))
                    nSiparisID_degistir(nSiparisID)
                    ds_tbSiparis.Tables(0).Rows.Add(dr)
                    lFiyat = Nothing
                    lTutar = Nothing
                    If yeni = True Then
                        Try
                            tbSiparis_Aciklamasi_kaydet_yeni(nSiparisTipi, lSiparisNo, nFirmaID, dr_baslik("sAciklama1").ToString, dr_baslik("sAciklama2").ToString, dr_baslik("sAciklama3").ToString, dr_baslik("sAciklama4").ToString, dr_baslik("sAciklama5").ToString, 0)
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
        Dataload_tbYekun(dr_baslik("dteSiparisTarihi"), dr_baslik("nSiparisTipi"), dr_baslik("lSiparisNo"), dr_baslik("nFirmaID"))
        If GridView1.RowCount > 0 Then
            GridView1.FocusedRowHandle = GridView1.RowCount - 1
            GridView1.ClearSelection()
            GridView1.SelectRow(GridView1.RowCount - 1)
            PanelControl3.Focus()
            GridControl1.Focus()
        End If
        GridView1.FocusedColumn = collMiktari
        satir_kontrol()
    End Sub
    Private Sub satir_araya_ekle()
        ' Parametrik onay kontrolu
        Dim dtParamOnay2 As DataTable = SQLCalistir("SELECT ISNULL(bOnayVar, 0) AS bOnayVar FROM tbParamAlSiparis")
        Dim bOnayVarParam2 As Boolean = False
        If dtParamOnay2.Rows.Count > 0 Then
            bOnayVarParam2 = Convert.ToBoolean(dtParamOnay2.Rows(0)("bOnayVar"))
        End If
        If bOnayVarParam2 Then
            Dim dtOnay As DataTable = SQLCalistir("SELECT ISNULL(bOnay, 0) FROM tbSiparis WHERE lSiparisNo = " & lSiparisNo & " AND nFirmaID = " & nFirmaID)
            If dtOnay.Rows.Count > 0 AndAlso Convert.ToBoolean(dtOnay.Rows(0)(0)) Then
                MessageBox.Show("Sevk Onayı verilmiş Siparişte değişiklik yapamazsınız.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Exit Sub
            End If
        End If
        If GridView1.RowCount = 0 Then
            satir_ekle()
            Exit Sub
        End If
        Dim nInsertHandle As Integer = GridView1.FocusedRowHandle
        If nInsertHandle < 0 Then nInsertHandle = 0
        ' Isaretli satirdan sonraki satirlarin nSiparisID degerlerini kaydir
        ' Hedef satirdan itibaren max nSiparisID + 1000000 ekle (bosluk ac)
        Dim con As New OleDb.OleDbConnection
        Dim cmd As New OleDb.OleDbCommand
        con.ConnectionString = connection
        cmd.Connection = con
        con.Open()
        ' Isaretli satirdan sonraki satirlarin nSiparisID degerlerini topla
        Dim drFocused As DataRow = GridView1.GetDataRow(nInsertHandle)
        Dim nFocusedID As Int64 = 0
        If drFocused IsNot Nothing Then
            nFocusedID = CType(drFocused("nSiparisID"), Int64)
        End If
        ' Isaretli satirdan buyuk ID'lere +2 ekle (araya yer ac)
        cmd.CommandText = sorgu_query("UPDATE tbSiparis SET nSiparisID = nSiparisID + 2 WHERE nSiparisID > " & nFocusedID & " AND lSiparisNo = " & lSiparisNo & " AND nFirmaID = " & nFirmaID & " AND nSiparisTipi = " & dr_baslik("nSiparisTipi"))
        Try
            cmd.ExecuteNonQuery()
        Catch ex As Exception
        End Try
        con.Close()
        con.Dispose()
        cmd.Dispose()
        ' Grid'i yeniden yukle (ID'ler degisti)
        Dataload_tbSiparis(dr_baslik("dteSiparisTarihi"), dr_baslik("nSiparisTipi"), dr_baslik("lSiparisNo"), dr_baslik("nFirmaID"))
        ' Simdi normal satir ekle - yeni satir nFocusedID + 1 civarinda olusacak
        satir_ekle()
        ' Grid'i tekrar yukle ve cursor'u konumla
        Dataload_tbSiparis(dr_baslik("dteSiparisTarihi"), dr_baslik("nSiparisTipi"), dr_baslik("lSiparisNo"), dr_baslik("nFirmaID"))
        ' Eklenen satiri bul (nFocusedID'den buyuk en kucuk ID)
        For idx As Integer = 0 To GridView1.RowCount - 1
            Dim drRow As DataRow = GridView1.GetDataRow(idx)
            If drRow IsNot Nothing Then
                If CType(drRow("nSiparisID"), Int64) > nFocusedID And CType(drRow("nSiparisID"), Int64) < nFocusedID + 2 Then
                    GridView1.ClearSelection()
                    GridView1.FocusedRowHandle = idx
                    GridView1.SelectRow(idx)
                    Exit For
                End If
            End If
        Next
    End Sub
    Private Sub satir_ekle_stok_tek()
        Dim dr As DataRow
        Dim dr1 As DataRow
        Dim lMiktar As Decimal = 0
        Dim lBrutFiyat As Decimal = 0
        Dim lBrutTutar As Decimal = 0
        Dim lFiyat As Decimal = 0
        Dim lGercekFiyat As Decimal = 0
        Dim lGercekToplam As Decimal = 0
        Dim lIsktutar As Decimal = 0
        Dim lkdvtutar As Decimal = 0
        Dim isk1 As Decimal = 0
        Dim isk2 As Decimal = 0
        Dim isk3 As Decimal = 0
        Dim isk4 As Decimal = 0
        dr = ds_tbSiparis.Tables(0).NewRow
        dr1 = ds_stok.Tables(0).Rows(0)
        Dim nSiparisID As Int64 = sorgu_nSiparisID()
        dr("nSiparisID") = nSiparisID
        dr("nSiparisTipi") = dr_baslik("nSiparisTipi")
        dr("lSiparisNo") = dr_baslik("lSiparisNo")
        dr("nFirmaID") = nFirmaID
        dr("nStokID") = dr1("nStokID")
        dr("dteSiparisTarihi") = dr_baslik("dteSiparisTarihi")
        dr("dteTeslimTarihi") = dr_baslik("dteSiparisTarihi")
        dr("sSiparisIslem") = ""
        dr("nReceteNo") = 0
        dr("sSiparisiAlan") = degeruzunlukkontrol(Trim(dr_baslik("sSiparisiAlan").ToString), 30)
        dr("sSiparisiAlan") += degeruzunlukkontrol(Trim(dr_baslik("sSiparisiVeren").ToString), 30)
        dr("sSiparisiVeren") = dr1("sAciklama") 'dr_baslik("sSiparisiVeren").ToString
        dr("sFiyatTipi") = sFiyatTipi
        dr1("lFiyat1") = sorgu_sayi(dr1("lFiyat1"), 0)
        dr1("lFiyat2") = sorgu_sayi(dr1("lFiyat2"), 0)
        dr1("lFiyat3") = sorgu_sayi(dr1("lFiyat3"), 0)
        dr("sFiyatTipi") = sFiyatTipi.ToString
        dr("lMiktari") = mevcut
        dr("lMiktar") = mevcut
        If Trim(dr1("sDovizCinsi")) <> "" Then
            dr1("lFiyat1") = sorgu_sayi(dr1("lFiyat1"), 0) * sorgu_lDovizKuru(dr1("sDovizCinsi"))
            dr1("lFiyat2") = sorgu_sayi(dr1("lFiyat2"), 0) * sorgu_lDovizKuru(dr1("sDovizCinsi"))
            dr1("lFiyat3") = sorgu_sayi(dr1("lFiyat3"), 0) * sorgu_lDovizKuru(dr1("sDovizCinsi"))
            'dr1("FIYAT4") = sorgu_sayi(dr1("FIYAT4"), 0) * sorgu_lDovizKuru(dr1("sDovizCinsi"))
            dr1("MALIYET") = sorgu_sayi(dr1("MALIYET"), 0) * sorgu_lDovizKuru(dr1("sDovizCinsi"))
            dr1("ALISFIYATI") = sorgu_sayi(dr1("ALISFIYATI"), 0) * sorgu_lDovizKuru(dr1("sDovizCinsi"))
            dr1("lAltFiyat") = sorgu_sayi(dr1("lAltFiyat"), 0) * sorgu_lDovizKuru(dr1("sDovizCinsi"))
            'dr1("lUstFiyat") = sorgu_sayi(dr1("lUstFiyat"), 0) * sorgu_lDovizKuru(dr1("sDovizCinsi"))
            'dr1("lOzelFiyat") = sorgu_sayi(dr1("lOzelFiyat"), 0) * sorgu_lDovizKuru(dr1("sDovizCinsi"))
        End If
        If nSiparisTipi = 2 Then
            sFiyatTipi = sFiyatA
            dr("sFiyatTipi") = sFiyatA
            dr("lBrutFiyat") = sorgu_sayi(dr1("ALISFIYATI"), 0)
            dr("lTutari") = dr("lMiktari") * sorgu_sayi(dr1("ALISFIYATI"), 0)
            dr("lBrutTutar") = dr("lMiktari") * sorgu_sayi(dr1("ALISFIYATI"), 0)
        ElseIf nSiparisTipi = 1 Or nSiparisTipi = 4 Then
            'dr("sFiyatTipi") = ""
            dr1("lFiyat1") = sorgu_sayi(dr1("lFiyat1"), 0)
            dr1("lFiyat2") = sorgu_sayi(dr1("lFiyat2"), 0)
            dr1("lFiyat3") = sorgu_sayi(dr1("lFiyat3"), 0)
            If Trim(dr_baslik("sFiyatTipi").ToString) <> "" Then
                sFiyatTipi = Trim(dr_baslik("sFiyatTipi"))
                dr("sFiyatTipi") = sFiyatTipi
                If Trim(sFiyatTipi) = Trim(sFiyat1) Then
                    If bFiyatKdvHaric = False Then
                        lBrutFiyat = dr1("lFiyat1") / ((100 + dr1("nKdvOrani")) / 100)
                    Else
                        lBrutFiyat = dr1("lFiyat1")
                    End If
                    lBrutTutar = lBrutFiyat * mevcut
                ElseIf Trim(sFiyatTipi) = Trim(sFiyat2) Then
                    If bFiyatKdvHaric = False Then
                        lBrutFiyat = dr1("lFiyat2") / ((100 + dr1("nKdvOrani")) / 100)
                    Else
                        lBrutFiyat = dr1("lFiyat2")
                    End If
                    lBrutTutar = lBrutFiyat * mevcut
                ElseIf Trim(sFiyatTipi) = Trim(sFiyat3) Then
                    If bFiyatKdvHaric = False Then
                        lBrutFiyat = dr1("lFiyat3") / ((100 + dr1("nKdvOrani")) / 100)
                    Else
                        lBrutFiyat = dr1("lFiyat3")
                    End If
                    lBrutTutar = lBrutFiyat * mevcut
                ElseIf Trim(sFiyatTipi) = "PR" Then
                    lBrutFiyat = 0.01
                    lBrutTutar = 0.01 * mevcut
                Else
                    'If bFiyatKdvHaric = False Then
                    '    lBrutFiyat = dr1("lOzelFiyat") / ((100 + dr1("nKdvOrani")) / 100)
                    'Else
                    '    lBrutFiyat = sorgu_sayi(dr1("lOzelFiyat"), 0)
                    'End If
                    'lBrutTutar = lBrutFiyat * mevcut
                    If bFiyatKdvHaric = False Then
                        lBrutFiyat = dr1("lOzelFiyat") / ((100 + dr1("nKdvOrani")) / 100)
                    Else
                        lBrutFiyat = sorgu_sayi(dr1("lOzelFiyat"), 0)
                    End If
                    lBrutTutar = lBrutFiyat * mevcut
                End If
            Else
                sFiyatTipi = sFiyat1
                If bFiyatKdvHaric = False Then
                    lBrutFiyat = dr1("lFiyat1") / ((100 + dr1("nKdvOrani")) / 100)
                Else
                    lBrutFiyat = dr1("lFiyat1")
                End If
                lBrutTutar = lBrutFiyat * mevcut
                dr("sFiyatTipi") = sFiyatTipi
            End If
        End If
        dr("nKdvOrani") = dr1("nKdvOrani")
        lMiktar = mevcut
        dr("ISK1") = sorgu_sayi(dr_baslik("nOzelIskontosu"), 0)
        dr("ISK2") = 0
        dr("ISK3") = 0
        dr("ISK4") = 0
        If sorgu_sayi(dr1("nIskontoYuzdesi"), 0) <> 0 Then
            dr("ISK1") = sorgu_sayi(dr1("nIskontoYuzdesi"), 0)
        End If
        sorgu_tbProtokol(dr_baslik("nFirmaID"), dr("nStokID"))
        If ds_Protokol.Tables(0).Rows.Count <> 0 Then
            Dim dr2 As DataRow = ds_Protokol.Tables(0).Rows(0)
            'FiyatTipi
            If Trim(dr2("sFiyatTipi")) <> "" And Trim(dr2("sFiyatTipi")) <> Trim(dr("sFiyatTipi")) Then
                dr("sFiyatTipi") = dr2("sFiyatTipi")
                If Trim(dr2("sFiyatTipi")) = Trim(sFiyat1) Then
                    If bFiyatKdvHaric = False Then
                        lBrutFiyat = dr1("lFiyat1") / ((100 + dr1("nKdvOrani")) / 100)
                    Else
                        lBrutFiyat = dr1("lFiyat1")
                    End If
                    lBrutTutar = lBrutFiyat * lMiktar
                ElseIf Trim(dr2("sFiyatTipi")) = Trim(sFiyat2) Then
                    If bFiyatKdvHaric = False Then
                        lBrutFiyat = dr1("lFiyat2") / ((100 + dr1("nKdvOrani")) / 100)
                    Else
                        lBrutFiyat = dr1("lFiyat2")
                    End If
                    lBrutTutar = lBrutFiyat * lMiktar
                ElseIf Trim(dr2("sFiyatTipi")) = Trim(sFiyat3) Then
                    If bFiyatKdvHaric = False Then
                        lBrutFiyat = dr1("lFiyat3") / ((100 + dr1("nKdvOrani")) / 100)
                    Else
                        lBrutFiyat = dr1("lFiyat3")
                    End If
                    lBrutTutar = lBrutFiyat * lMiktar
                ElseIf Trim(dr2("sFiyatTipi")) = "PR" Then
                    lBrutFiyat = 0.01
                    lBrutTutar = 0.01 * lMiktar
                Else
                    Dim llfiyat As Decimal = sorgu_stok_fiyat(dr2("sFiyatTipi"), dr1("nStokID"))
                    If llfiyat = 0 Then
                        llfiyat = dr1("FIYAT1")
                    End If
                    If bFiyatKdvHaric = False Then
                        lBrutFiyat = llfiyat / ((100 + dr1("nKdvOrani")) / 100)
                    Else
                        lBrutFiyat = sorgu_sayi(llfiyat, 0)
                    End If
                    lBrutTutar = lBrutFiyat * lMiktar
                End If
                If lBrutFiyat = 0 Then
                    If bFiyatKdvHaric = False Then
                        lBrutFiyat = dr1("lFiyat1") / ((100 + dr1("nKdvOrani")) / 100)
                    Else
                        lBrutFiyat = dr1("lFiyat1")
                    End If
                End If
                lBrutTutar = lBrutFiyat * lMiktar
                'dr("lBrutTutar") = lBrutTutar
                'dr("lBrutFiyat") = lBrutFiyat
                'dr("lFiyat") = lBrutFiyat
                'dr("lDahilBrutFiyat") = lBrutFiyat * ((dr("nKdvOrani") + 100) / 100)
                'dr("lDahilFiyat") = dr("lDahilBrutFiyat")
                'dr("lDahilBrutTutar") = dr("lDahilBrutFiyat") * lMiktar
            End If
            'Kdv
            If Trim(dr2("nKdvOrani")) <> -1 Then
                dr("nKdvOrani") = dr2("nKdvOrani")
            End If
            'Fiyat
            If Trim(dr2("lFiyat")) <> 0 Then
                dr("lBrutFiyat") = dr2("lFiyat")
                If bFiyatKdvHaric = False Then
                    lBrutFiyat = dr2("lFiyat") / ((100 + dr1("nKdvOrani")) / 100)
                Else
                    lBrutFiyat = dr1("lFiyiat")
                End If
                lBrutTutar = lBrutFiyat * lMiktar
                'dr("lBrutTutar") = lBrutTutar
                'dr("lBrutFiyat") = lBrutFiyat
                'dr("lFiyat") = lBrutFiyat
                'dr("lDahilBrutFiyat") = lBrutFiyat * ((dr("nKdvOrani") + 100) / 100)
                'dr("lDahilFiyat") = dr("lDahilBrutFiyat")
                'dr("lDahilBrutTutar") = dr("lDahilBrutFiyat") * lMiktar
            End If
            dr("ISK1") = dr2("nIskontoYuzdesi1")
            dr("ISK2") = dr2("nIskontoYuzdesi2")
            dr("ISK3") = dr2("nIskontoYuzdesi3")
            dr("ISK4") = dr2("nIskontoYuzdesi4")
        End If
        dr("sFiyatTipi") = Trim(sFiyatTipi)
        If bImport = True And bImport_Fiyat = True Then
            lBrutFiyat = bIFiyati
        End If
        If bImport = True And bImport_Tutar = True Then
            lBrutFiyat = bITutari / mevcut
            lBrutTutar = bITutari
        End If
        If lBrutFiyat = 0 Then
            lBrutFiyat = 0.001
            lBrutTutar = lBrutFiyat * mevcut
        End If
        dr("lBrutTutar") = lBrutTutar
        dr("lBrutFiyat") = lBrutFiyat
        dr("lFiyat") = lBrutFiyat
        dr("lFiyati") = lBrutFiyat
        dr("lDahilBrutFiyat") = lBrutFiyat * ((dr("nKdvOrani") + 100) / 100)
        dr("lDahilFiyat") = dr("lDahilBrutFiyat")
        dr("lDahilBrutTutar") = dr("lDahilBrutFiyat") * lMiktar
        lFiyat = dr("lBrutFiyat")
        Dim lTutar As Decimal = 0
        lFiyat = dr("lBrutFiyat")
        isk1 = lFiyat * ((100 - dr("ISK1")) / 100)
        isk2 = isk1 * ((100 - dr("ISK2")) / 100)
        isk3 = isk2 * ((100 - dr("ISK3")) / 100)
        isk4 = isk3 * ((100 - dr("ISK4")) / 100)
        dr("nIskontoYuzdesi") = ((dr("lBrutFiyat") - isk4) / dr("lBrutFiyat")) * 100
        dr("lNetFiyat") = (isk4 * ((dr("nKdvOrani") + 100) / 100))
        lTutar = lFiyat * dr("lMiktari")
        dr("lTutari") = lTutar
        dr("lIskontoTutari") = dr("lBrutTutar") - lTutar
        dr("sAsortiTipi") = ""
        dr("sAsortiMiktari") = 0
        'dr("nKdvOrani") = dr1("nKdvOrani")
        'dr("nIskontoYuzdesi") = dr_baslik("nOzelIskontosu")
        dr("sKullaniciAdi") = kullaniciadi
        dr("dteKayitTarihi") = Now
        dr("bKapandimi") = 0
        dr("lReserveMiktari") = 0
        dr("sHangiUygulama") = ""
        dr("nPartiID") = 0
        dr("sSatirAciklama") = "Isk1:" & uzunluk_tamamla(FormatNumber(dr("ISK1"), 2), 5) & " Isk2:" & uzunluk_tamamla(FormatNumber(dr("ISK2"), 2), 5) & " Isk3:" & uzunluk_tamamla(FormatNumber(dr("ISK3"), 2), 5) & " Isk4:" & uzunluk_tamamla(FormatNumber(dr("ISK4"), 2), 5)
        dr("nValorGun") = 0
        dr("sDovizCinsi") = ""
        dr("lDovizFiyati") = 0
        dr("lDovizKuru") = 0
        dr("sModel") = dr1("sModel")
        dr("sKodu") = dr1("sKodu")
        dr("sAciklama") = dr1("sAciklama")
        dr("sFirmaKodu") = dr_baslik("sKodu")
        dr("sFirmaAciklama") = dr_baslik("sAciklama")
        dr("sSaticiRumuzu") = dr_baslik("sSaticiRumuzu")
        dr("sKisaAdi") = dr1("sKisaAdi").ToString
        dr("nHacim") = sorgu_sayi(dr1("nHacim"), 0)
        dr("nAgirlik") = sorgu_sayi(dr1("nAgirlik"), 0)
        dr("sBirimCinsi") = dr1("sBirimCinsi1").ToString
        dr("sAmbalaj") = dr1("sBirimCinsi1").ToString
        dr("sBirimCinsi1") = dr1("sBirimCinsi1").ToString
        dr("lBirimMiktar") = 1
        dr("nBirimCarpan") = sorgu_sayi(dr1("nBirimCarpan"), 1)
        dr("sBarkod") = dr1("sBarkod")
        dr("sDepo") = sDepo
        dr("sRenkAdi") = dr1("sRenkAdi")
        dr("sBeden") = dr1("sBeden")
        dr("lFiyat") = dr("lBrutFiyat")
        'dr("lSevkiyat") = 0
        dr("lYukleme") = 0
        dr("nSiparisID") = tbSiparis_kaydet_yeni(dr("nSiparisID"), dr("nSiparisTipi"), dr("lSiparisNo"), dr("nFirmaID"), dr("nStokID"), dr("dteSiparisTarihi"), dr("dteTeslimTarihi"), dr("sSiparisIslem"), dr("nReceteNo"), dr("sSiparisiAlan"), dr("sSiparisiVeren"), dr("sFiyatTipi"), dr("lMiktari"), dr("lBrutFiyat"), dr("lTutari"), dr("sAsortiTipi"), dr("sAsortiMiktari"), dr("nKdvOrani"), dr("nIskontoYuzdesi"), dr("lBrutTutar"), kullaniciadi, Now, dr("bKapandimi"), dr("lReserveMiktari"), dr("sHangiUygulama"), dr("nPartiID"), dr("sSatirAciklama"), dr("nValorGun"), dr("sDovizCinsi"), dr("lDovizFiyati"), dr("lDovizKuru"), dr("sSaticiRumuzu"), dr("sDepo"), dr("sBirimCinsi"), dr("lBirimMiktar"), dr("sAmbalaj"))
        nSiparisID_degistir(nSiparisID)
        ds_tbSiparis.Tables(0).Rows.Add(dr)
        lFiyat = Nothing
        lTutar = Nothing
        If yeni = True Then
            Try
                tbSiparis_Aciklamasi_kaydet_yeni(nSiparisTipi, lSiparisNo, nFirmaID, dr_baslik("sAciklama1").ToString, dr_baslik("sAciklama2").ToString, dr_baslik("sAciklama3").ToString, dr_baslik("sAciklama4").ToString, dr_baslik("sAciklama5").ToString, 0)
                yeni = False
            Catch ex As Exception
            End Try
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
        Dataload_tbYekun(dr_baslik("dteSiparisTarihi"), dr_baslik("nSiparisTipi"), dr_baslik("lSiparisNo"), dr_baslik("nFirmaID"))
        GridView1.FocusedColumn = collMiktari
        satir_kontrol()
        txt_ara.Text = ""
        txt_ara.Focus()
        txt_ara.SelectAll()
    End Sub
    Private Sub satir_ekle_stok_koli(ByVal sKoliKodu As String)
        Dim dr As DataRow
        Dim dr1 As DataRow
        Dim lMiktar As Decimal = 0
        Dim lBrutFiyat As Decimal = 0
        Dim lBrutTutar As Decimal = 0
        Dim lFiyat As Decimal = 0
        Dim lGercekFiyat As Decimal = 0
        Dim lGercekToplam As Decimal = 0
        Dim lIsktutar As Decimal = 0
        Dim lkdvtutar As Decimal = 0
        Dim isk1 As Decimal = 0
        Dim isk2 As Decimal = 0
        Dim isk3 As Decimal = 0
        Dim isk4 As Decimal = 0
        Dim lMevcut As Decimal = mevcut
        Dim ds_tbKoliDagilim As DataSet = sorgu("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT tbStok.*, tbStokBarkodu.sBarkod AS sBarkod, ISNULL((SELECT isnull(lfiyat , 0) FROM tbstokfiyati WHERE nStokId = tbStok.NstokId AND sFiyatTipi = '" & sFiyat1 & "'), 0) AS PESIN, ISNULL((SELECT isnull(lfiyat , 0) FROM tbstokfiyati WHERE nStokId = tbStok.NstokId AND sFiyatTipi = '" & sFiyat2 & "'), 0) AS ALTIAY, ISNULL((SELECT isnull(lfiyat , 0) FROM tbstokfiyati WHERE nStokId = tbStok.NstokId AND sFiyatTipi = '" & sFiyat3 & "'), 0) AS ONAY, ISNULL((SELECT isnull(lfiyat , 0) FROM tbstokfiyati WHERE nStokId = tbStok.NstokId AND sFiyatTipi = '" & sFiyatM & "'), 0) AS MALIYET, ISNULL((SELECT isnull(lfiyat , 0) FROM tbstokfiyati WHERE nStokId = tbstok.NstokId AND sFiyatTipi = '" & sAltFiyatTipi & "'), 0) AS lAltFiyat, ISNULL((SELECT isnull(lfiyat , 0) FROM tbstokfiyati WHERE nStokId = tbStok.NstokId AND sFiyatTipi = '" & sFiyatA & "'), 0) AS ALISFIYATI, (SELECT nKdvOrani FROM tbKdv WHERE sKdvTipi = tbStok.sKdvTipi) AS nKdvOrani, ISNULL((SELECT ISNULL(lOran , 0) FROM tbStokBirimCevrimi WHERE nStokID = tbStok.nStokID AND sBirimCinsi = tbStok.sBirimCinsi2), 1) AS nBirimCarpan, (SELECT sRenkAdi FROM tbRenk WHERE sRenk = tbStok.sRenk) AS sRenkAdi, (SELECT sSinifKodu1 FROM tbStokSinifi WHERE nStokID = tbStok.nStokID) AS sSinifKodu1,tbKoliDagilimi.lMiktar AS lMiktar,tbKoliDagilimi.sBirimCinsi,tbKoliDagilimi.lBirimMiktar,tbKoliDagilimi.lFiyat,tbKoliDagilimi.sFiyatTipi FROM tbStok LEFT OUTER JOIN tbStokBarkodu ON tbStok.nStokID = tbStokBarkodu.nStokID AND tbStokBarkodu.nKisim = 0 INNER JOIN tbKoliDagilimi ON tbStok.nStokID = tbKoliDagilimi.nStokID WHERE (tbKoliDagilimi.sKoliKodu = N'" & sKoliKodu & "')")
        For Each dr1 In ds_tbKoliDagilim.Tables(0).Rows
            'mevcut = sorgu_sayi(dr1("lMiktar"), 1)
            mevcut = lMevcut * sorgu_sayi(dr1("lMiktar") * dr1("lBirimMiktar"), 1)
            dr = ds_tbSiparis.Tables(0).NewRow
            Dim nSiparisID As Int64 = sorgu_nSiparisID()
            dr("nSiparisID") = nSiparisID
            dr("nSiparisTipi") = dr_baslik("nSiparisTipi")
            dr("lSiparisNo") = dr_baslik("lSiparisNo")
            dr("nFirmaID") = nFirmaID
            dr("nStokID") = dr1("nStokID")
            dr("dteSiparisTarihi") = dr_baslik("dteSiparisTarihi")
            dr("dteTeslimTarihi") = dr_baslik("dteSiparisTarihi")
            dr("sSiparisIslem") = ""
            dr("nReceteNo") = 0
            dr("sSiparisiAlan") = degeruzunlukkontrol(Trim(dr_baslik("sSiparisiAlan").ToString), 30)
            dr("sSiparisiAlan") += degeruzunlukkontrol(Trim(dr_baslik("sSiparisiVeren").ToString), 30)
            dr("sSiparisiVeren") = dr1("sAciklama") 'dr_baslik("sSiparisiVeren").ToString
            dr("sFiyatTipi") = sFiyatTipi
            dr1("FIYAT1") = sorgu_sayi(dr1("FIYAT1"), 0)
            dr1("FIYAT2") = sorgu_sayi(dr1("FIYAT2"), 0)
            dr1("FIYAT3") = sorgu_sayi(dr1("FIYAT3"), 0)
            dr("sFiyatTipi") = sFiyatTipi.ToString
            dr("lMiktari") = mevcut
            dr("lMiktar") = mevcut / dr1("lBirimMiktar")
            If Trim(dr1("sDovizCinsi")) <> "" Then
                dr1("FIYAT1") = sorgu_sayi(dr1("FIYAT1"), 0) * sorgu_lDovizKuru(dr1("sDovizCinsi"))
                dr1("FIYAT2") = sorgu_sayi(dr1("FIYAT2"), 0) * sorgu_lDovizKuru(dr1("sDovizCinsi"))
                dr1("FIYAT3") = sorgu_sayi(dr1("FIYAT3"), 0) * sorgu_lDovizKuru(dr1("sDovizCinsi"))
                'dr1("FIYAT4") = sorgu_sayi(dr1("FIYAT4"), 0) * sorgu_lDovizKuru(dr1("sDovizCinsi"))
                dr1("MALIYET") = sorgu_sayi(dr1("MALIYET"), 0) * sorgu_lDovizKuru(dr1("sDovizCinsi"))
                dr1("ALISFIYATI") = sorgu_sayi(dr1("ALISFIYATI"), 0) * sorgu_lDovizKuru(dr1("sDovizCinsi"))
                dr1("lAltFiyat") = sorgu_sayi(dr1("lAltFiyat"), 0) * sorgu_lDovizKuru(dr1("sDovizCinsi"))
                'dr1("lUstFiyat") = sorgu_sayi(dr1("lUstFiyat"), 0) * sorgu_lDovizKuru(dr1("sDovizCinsi"))
                'dr1("lOzelFiyat") = sorgu_sayi(dr1("lOzelFiyat"), 0) * sorgu_lDovizKuru(dr1("sDovizCinsi"))
            End If
            If nSiparisTipi = 2 Then
                sFiyatTipi = sFiyatA
                dr("sFiyatTipi") = sFiyatA
                dr("lBrutFiyat") = sorgu_sayi(dr1("ALISFIYATI"), 0)
                dr("lTutari") = mevcut * sorgu_sayi(dr1("ALISFIYATI"), 0)
                dr("lBrutTutar") = mevcut * sorgu_sayi(dr1("ALISFIYATI"), 0)
            ElseIf nSiparisTipi = 1 Or nSiparisTipi = 4 Then
                'dr("sFiyatTipi") = ""
                dr1("FIYAT1") = sorgu_sayi(dr1("FIYAT1"), 0)
                dr1("FIYAT2") = sorgu_sayi(dr1("FIYAT2"), 0)
                dr1("FIYAT3") = sorgu_sayi(dr1("FIYAT3"), 0)
                If Trim(dr_baslik("sFiyatTipi").ToString) <> "" Then
                    sFiyatTipi = Trim(dr_baslik("sFiyatTipi"))
                    dr("sFiyatTipi") = sFiyatTipi
                    If Trim(sFiyatTipi) = Trim(sFiyat1) Then
                        If bFiyatKdvHaric = False Then
                            lBrutFiyat = dr1("FIYAT1") / ((100 + dr1("nKdvOrani")) / 100)
                        Else
                            lBrutFiyat = dr1("FIYAT1")
                        End If
                        lBrutTutar = lBrutFiyat * mevcut
                    ElseIf Trim(sFiyatTipi) = Trim(sFiyat2) Then
                        If bFiyatKdvHaric = False Then
                            lBrutFiyat = dr1("FIYAT2") / ((100 + dr1("nKdvOrani")) / 100)
                        Else
                            lBrutFiyat = dr1("FIYAT2")
                        End If
                        lBrutTutar = lBrutFiyat * mevcut
                    ElseIf Trim(sFiyatTipi) = Trim(sFiyat3) Then
                        If bFiyatKdvHaric = False Then
                            lBrutFiyat = dr1("FIYAT3") / ((100 + dr1("nKdvOrani")) / 100)
                        Else
                            lBrutFiyat = dr1("FIYAT3")
                        End If
                        lBrutTutar = lBrutFiyat * dr("lMiktari")
                    ElseIf Trim(sFiyatTipi) = "PR" Then
                        lBrutFiyat = 0.01
                        lBrutTutar = 0.01 * mevcut
                    Else
                        If bFiyatKdvHaric = False Then
                            lBrutFiyat = dr1("lOzelFiyat") / ((100 + dr1("nKdvOrani")) / 100)
                        Else
                            lBrutFiyat = sorgu_sayi(dr1("lOzelFiyat"), 0)
                        End If
                        lBrutTutar = lBrutFiyat * mevcut
                    End If
                Else
                    sFiyatTipi = sFiyat1
                    If bFiyatKdvHaric = False Then
                        lBrutFiyat = dr1("FIYAT1") / ((100 + dr1("nKdvOrani")) / 100)
                    Else
                        lBrutFiyat = dr1("FIYAT1")
                    End If
                    lBrutTutar = lBrutFiyat * mevcut
                    dr("sFiyatTipi") = sFiyatTipi
                End If
            End If
            dr("nKdvOrani") = dr1("nKdvOrani")
            lMiktar = dr("lMiktari")
            dr("ISK1") = sorgu_sayi(dr_baslik("nOzelIskontosu"), 0)
            dr("ISK2") = 0
            dr("ISK3") = 0
            dr("ISK4") = 0
            If sorgu_sayi(dr1("nIskontoYuzdesi"), 0) <> 0 Then
                dr("ISK1") = sorgu_sayi(dr1("nIskontoYuzdesi"), 0)
            End If
            sorgu_tbProtokol(dr_baslik("nFirmaID"), dr("nStokID"))
            If ds_Protokol.Tables(0).Rows.Count <> 0 Then
                Dim dr2 As DataRow
                dr2 = ds_Protokol.Tables(0).Rows(0)
                'FiyatTipi
                If Trim(dr2("sFiyatTipi")) <> "" And Trim(dr2("sFiyatTipi")) <> Trim(dr("sFiyatTipi")) Then
                    dr("sFiyatTipi") = dr2("sFiyatTipi")
                    If Trim(dr2("sFiyatTipi")) = Trim(sFiyat1) Then
                        If bFiyatKdvHaric = False Then
                            lBrutFiyat = dr1("FIYAT1") / ((100 + dr1("nKdvOrani")) / 100)
                        Else
                            lBrutFiyat = dr1("FIYAT1")
                        End If
                        lBrutTutar = lBrutFiyat * lMiktar
                    ElseIf Trim(dr2("sFiyatTipi")) = Trim(sFiyat2) Then
                        If bFiyatKdvHaric = False Then
                            lBrutFiyat = dr1("FIYAT2") / ((100 + dr1("nKdvOrani")) / 100)
                        Else
                            lBrutFiyat = dr1("FIYAT2")
                        End If
                        lBrutTutar = lBrutFiyat * lMiktar
                    ElseIf Trim(dr2("sFiyatTipi")) = Trim(sFiyat3) Then
                        If bFiyatKdvHaric = False Then
                            lBrutFiyat = dr1("FIYAT3") / ((100 + dr1("nKdvOrani")) / 100)
                        Else
                            lBrutFiyat = dr1("FIYAT3")
                        End If
                        lBrutTutar = lBrutFiyat * lMiktar
                    ElseIf Trim(dr2("sFiyatTipi")) = "PR" Then
                        lBrutFiyat = 0.01
                        lBrutTutar = 0.01 * lMiktar
                    Else
                        Dim llfiyat As Decimal = sorgu_stok_fiyat(dr2("sFiyatTipi"), dr1("nStokID"))
                        If llfiyat = 0 Then
                            llfiyat = dr1("FIYAT1")
                        End If
                        If bFiyatKdvHaric = False Then
                            lBrutFiyat = llfiyat / ((100 + dr1("nKdvOrani")) / 100)
                        Else
                            lBrutFiyat = sorgu_sayi(llfiyat, 0)
                        End If
                        lBrutTutar = lBrutFiyat * lMiktar
                    End If
                    If lBrutFiyat = 0 Then
                        If bFiyatKdvHaric = False Then
                            lBrutFiyat = dr1("FIYAT1") / ((100 + dr1("nKdvOrani")) / 100)
                        Else
                            lBrutFiyat = dr1("FIYAT1")
                        End If
                    End If
                    lBrutTutar = lBrutFiyat * lMiktar
                    'dr("lBrutTutar") = lBrutTutar
                    'dr("lBrutFiyat") = lBrutFiyat
                    'dr("lFiyat") = lBrutFiyat
                    'dr("lDahilBrutFiyat") = lBrutFiyat * ((dr("nKdvOrani") + 100) / 100)
                    'dr("lDahilFiyat") = dr("lDahilBrutFiyat")
                    'dr("lDahilBrutTutar") = dr("lDahilBrutFiyat") * lMiktar
                End If
                'Kdv
                If Trim(dr2("nKdvOrani")) <> -1 Then
                    dr("nKdvOrani") = dr2("nKdvOrani")
                End If
                'Fiyat
                If Trim(dr2("lFiyat")) <> 0 Then
                    dr("lBrutFiyat") = dr2("lFiyat")
                    If bFiyatKdvHaric = False Then
                        lBrutFiyat = dr2("lFiyat") / ((100 + dr1("nKdvOrani")) / 100)
                    Else
                        lBrutFiyat = dr1("lFiyat")
                    End If
                    lBrutTutar = lBrutFiyat * lMiktar
                    'dr("lBrutTutar") = lBrutTutar
                    'dr("lBrutFiyat") = lBrutFiyat
                    'dr("lFiyat") = lBrutFiyat
                    'dr("lDahilBrutFiyat") = lBrutFiyat * ((dr("nKdvOrani") + 100) / 100)
                    'dr("lDahilFiyat") = dr("lDahilBrutFiyat")
                    'dr("lDahilBrutTutar") = dr("lDahilBrutFiyat") * lMiktar
                End If
                dr("ISK1") = dr2("nIskontoYuzdesi1")
                dr("ISK2") = dr2("nIskontoYuzdesi2")
                dr("ISK3") = dr2("nIskontoYuzdesi3")
                dr("ISK4") = dr2("nIskontoYuzdesi4")
            End If
            dr("sFiyatTipi") = Trim(sFiyatTipi)
            If bImport = True And bImport_Fiyat = True Then
                lBrutFiyat = bIFiyati
            End If
            If bImport = True And bImport_Tutar = True Then
                lBrutFiyat = bITutari / mevcut
                lBrutTutar = bITutari
            End If
            If lBrutFiyat = 0 Then
                lBrutFiyat = 0.001
                lBrutTutar = lBrutFiyat * dr("lMiktari")
            End If
            dr("lBrutTutar") = lBrutTutar
            dr("lBrutFiyat") = lBrutFiyat
            dr("lFiyat") = lBrutFiyat * dr1("lBirimMiktar")
            dr("lFiyati") = lBrutFiyat
            dr("lDahilBrutFiyat") = lBrutFiyat * ((dr("nKdvOrani") + 100) / 100)
            dr("lDahilFiyat") = dr("lDahilBrutFiyat")
            dr("lDahilBrutTutar") = dr("lDahilBrutFiyat") * lMiktar
            lFiyat = dr("lBrutFiyat")
            Dim lTutar As Decimal = 0
            lFiyat = dr("lBrutFiyat")
            isk1 = lFiyat * ((100 - dr("ISK1")) / 100)
            isk2 = isk1 * ((100 - dr("ISK2")) / 100)
            isk3 = isk2 * ((100 - dr("ISK3")) / 100)
            isk4 = isk3 * ((100 - dr("ISK4")) / 100)
            dr("nIskontoYuzdesi") = ((dr("lBrutFiyat") - isk4) / dr("lBrutFiyat")) * 100
            dr("lNetFiyat") = (isk4 * ((dr("nKdvOrani") + 100) / 100))
            lTutar = lFiyat * dr("lMiktari")
            dr("lTutari") = lTutar
            dr("lIskontoTutari") = dr("lBrutTutar") - lTutar
            dr("sAsortiTipi") = ""
            dr("sAsortiMiktari") = 0
            'dr("nKdvOrani") = dr1("nKdvOrani")
            'dr("nIskontoYuzdesi") = dr_baslik("nOzelIskontosu")
            dr("sKullaniciAdi") = kullaniciadi
            dr("dteKayitTarihi") = Now
            dr("bKapandimi") = 0
            dr("lReserveMiktari") = 0
            dr("sHangiUygulama") = ""
            dr("nPartiID") = 0
            dr("sSatirAciklama") = "Isk1:" & uzunluk_tamamla(FormatNumber(dr("ISK1"), 2), 5) & " Isk2:" & uzunluk_tamamla(FormatNumber(dr("ISK2"), 2), 5) & " Isk3:" & uzunluk_tamamla(FormatNumber(dr("ISK3"), 2), 5) & " Isk4:" & uzunluk_tamamla(FormatNumber(dr("ISK4"), 2), 5)
            dr("nValorGun") = 0
            dr("sDovizCinsi") = ""
            dr("lDovizFiyati") = 0
            dr("lDovizKuru") = 0
            dr("sModel") = dr1("sModel")
            dr("sKodu") = dr1("sKodu")
            dr("sAciklama") = dr1("sAciklama")
            dr("sFirmaKodu") = dr_baslik("sKodu")
            dr("sFirmaAciklama") = dr_baslik("sAciklama")
            dr("sSaticiRumuzu") = dr_baslik("sSaticiRumuzu")
            dr("sKisaAdi") = dr1("sKisaAdi").ToString
            dr("nHacim") = sorgu_sayi(dr1("nHacim"), 0)
            dr("nAgirlik") = sorgu_sayi(dr1("nAgirlik"), 0)
            dr("sBirimCinsi") = dr1("sBirimCinsi").ToString
            dr("sAmbalaj") = dr1("sBirimCinsi").ToString
            dr("sBirimCinsi1") = dr1("sBirimCinsi").ToString
            dr("lBirimMiktar") = dr1("lBirimMiktar")
            dr("nBirimCarpan") = sorgu_sayi(dr1("nBirimCarpan"), 1)
            dr("sBarkod") = dr1("sBarkod")
            dr("sDepo") = sDepo
            dr("sRenkAdi") = dr1("sRenkAdi")
            dr("sBeden") = dr1("sBeden")
            dr("lFiyat") = dr("lBrutFiyat") * dr1("lBirimMiktar")
            'dr("nBirimCarpan") = sorgu_sayi(dr1("nBirimCarpan"), 1)
            'Doviz Hesapla
            If dr("sDovizCinsi").ToString <> "" And dr("lDovizKuru") <> 0 Then
                dr("lDovizFiyati") = dr("lBrutFiyat") / dr("lDovizKuru")
                dr("lDovizBrutFiyati") = dr("lBrutFiyat") / dr("lDovizKuru")
                dr("lDovizTutar") = dr("lBrutTutar") / dr("lDovizKuru")
                dr("lDahilDovizFiyati") = dr("lBrutFiyat")
                dr("lDahilDovizBrutFiyati") = dr("lBrutFiyat")
                dr("lDahilDovizTutar") = dr("lBrutTutar")
            Else
                dr("lDovizFiyati") = dr("lBrutFiyat")
                dr("lDovizBrutFiyati") = dr("lBrutFiyat")
                dr("lDovizTutar") = dr("lBrutTutar")
                dr("lDahilDovizFiyati") = dr("lBrutFiyat")
                dr("lDahilDovizBrutFiyati") = dr("lBrutFiyat")
                dr("lDahilDovizTutar") = dr("lBrutTutar")
            End If
            'dr("lSevkiyat") = 0
            dr("lYukleme") = 0
            dr("nSiparisID") = tbSiparis_kaydet_yeni(dr("nSiparisID"), dr("nSiparisTipi"), dr("lSiparisNo"), dr("nFirmaID"), dr("nStokID"), dr("dteSiparisTarihi"), dr("dteTeslimTarihi"), dr("sSiparisIslem"), dr("nReceteNo"), dr("sSiparisiAlan"), dr("sSiparisiVeren"), dr("sFiyatTipi"), dr("lMiktari"), dr("lBrutFiyat"), dr("lTutari"), dr("sAsortiTipi"), dr("sAsortiMiktari"), dr("nKdvOrani"), dr("nIskontoYuzdesi"), dr("lBrutTutar"), kullaniciadi, Now, dr("bKapandimi"), dr("lReserveMiktari"), dr("sHangiUygulama"), dr("nPartiID"), dr("sSatirAciklama"), dr("nValorGun"), dr("sDovizCinsi"), dr("lDovizFiyati"), dr("lDovizKuru"), dr("sSaticiRumuzu"), dr("sDepo"), dr("sBirimCinsi"), dr("lBirimMiktar"), dr("sAmbalaj"))
            nSiparisID_degistir(nSiparisID)
            ds_tbSiparis.Tables(0).Rows.Add(dr)
            'lFiyat = Nothing
            'lTutar = Nothing
        Next
        If yeni = True Then
            Try
                tbSiparis_Aciklamasi_kaydet_yeni(nSiparisTipi, lSiparisNo, nFirmaID, dr_baslik("sAciklama1").ToString, dr_baslik("sAciklama2").ToString, dr_baslik("sAciklama3").ToString, dr_baslik("sAciklama4").ToString, dr_baslik("sAciklama5").ToString, 0)
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
        Dataload_tbYekun(dr_baslik("dteSiparisTarihi"), dr_baslik("nSiparisTipi"), dr_baslik("lSiparisNo"), dr_baslik("nFirmaID"))
        GridView1.FocusedColumn = collMiktari
        satir_kontrol()
        txt_ara.Text = ""
        txt_ara.Focus()
        txt_ara.SelectAll()
    End Sub
    Private Sub satir_ekle_ihtiyac(Optional ByVal ara As String = "")
        Dim frm As New frm_tbSiparis_ihtiyac
        frm.islemstatus = True
        frm.connection = connection
        frm.firmano = firmano
        frm.donemno = donemno
        frm.islemstatus = True
        frm.kullanici = kullanici
        If dr_baslik("nSiparisTipi") = 1 Then
            frm.nSiparisTipi = 2
        ElseIf dr_baslik("nSiparisTipi") = 2 Then
            frm.nSiparisTipi = 1
        End If
        status = True
        Dim lMiktar As Decimal = 0
        Dim lBrutFiyat As Decimal = 0
        Dim lBrutTutar As Decimal = 0
        Dim lFiyat As Decimal = 0
        Dim lGercekFiyat As Decimal = 0
        Dim lGercekToplam As Decimal = 0
        Dim lIsktutar As Decimal = 0
        Dim lkdvtutar As Decimal = 0
        Dim isk1 As Decimal = 0
        Dim isk2 As Decimal = 0
        Dim isk3 As Decimal = 0
        Dim isk4 As Decimal = 0
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
                    dr = ds_tbSiparis.Tables(0).NewRow
                    dr1 = frm.GridView1.GetDataRow(s)
                    Dim nSiparisID As Int64 = sorgu_nSiparisID()
                    dr("nSiparisID") = nSiparisID
                    dr("nSiparisTipi") = dr_baslik("nSiparisTipi")
                    dr("lSiparisNo") = dr_baslik("lSiparisNo")
                    dr("nFirmaID") = nFirmaID
                    dr("nStokID") = dr1("nStokID")
                    dr("dteSiparisTarihi") = dr_baslik("dteSiparisTarihi")
                    dr("dteTeslimTarihi") = dr_baslik("dteSiparisTarihi")
                    dr("sSiparisIslem") = ""
                    dr("nReceteNo") = 0
                    dr("sSiparisiAlan") = degeruzunlukkontrol(Trim(dr_baslik("sSiparisiAlan").ToString), 30)
                    dr("sSiparisiAlan") += degeruzunlukkontrol(Trim(dr_baslik("sSiparisiVeren").ToString), 30)
                    dr("sSiparisiVeren") = dr1("sAciklama") 'dr_baslik("sSiparisiVeren").ToString
                    dr("sFiyatTipi") = sFiyatTipi
                    If Trim(dr1("sDovizCinsi")) <> "" Then
                        dr1("FIYAT1") = sorgu_sayi(dr1("FIYAT1"), 0) * sorgu_lDovizKuru(dr1("sDovizCinsi"))
                        dr1("FIYAT2") = sorgu_sayi(dr1("FIYAT2"), 0) * sorgu_lDovizKuru(dr1("sDovizCinsi"))
                        dr1("FIYAT3") = sorgu_sayi(dr1("FIYAT3"), 0) * sorgu_lDovizKuru(dr1("sDovizCinsi"))
                        'dr1("FIYAT4") = sorgu_sayi(dr1("FIYAT4"), 0) * sorgu_lDovizKuru(dr1("sDovizCinsi"))
                        dr1("MALIYET") = sorgu_sayi(dr1("MALIYET"), 0) * sorgu_lDovizKuru(dr1("sDovizCinsi"))
                        dr1("ALISFIYATI") = sorgu_sayi(dr1("ALISFIYATI"), 0) * sorgu_lDovizKuru(dr1("sDovizCinsi"))
                        dr1("lAltFiyat") = sorgu_sayi(dr1("lAltFiyat"), 0) * sorgu_lDovizKuru(dr1("sDovizCinsi"))
                        'dr1("lUstFiyat") = sorgu_sayi(dr1("lUstFiyat"), 0) * sorgu_lDovizKuru(dr1("sDovizCinsi"))
                        'dr1("lOzelFiyat") = sorgu_sayi(dr1("lOzelFiyat"), 0) * sorgu_lDovizKuru(dr1("sDovizCinsi"))
                    End If
                    dr1("FIYAT1") = sorgu_sayi(dr1("FIYAT1"), 0)
                    dr1("FIYAT2") = sorgu_sayi(dr1("FIYAT2"), 0)
                    dr1("FIYAT3") = sorgu_sayi(dr1("FIYAT3"), 0)
                    dr("sFiyatTipi") = sFiyatTipi.ToString
                    dr("lMiktari") = dr1("lIhtiyac")
                    dr("lMiktar") = dr1("lIhtiyac")
                    If nSiparisTipi = 2 Then
                        sFiyatTipi = sFiyatA
                        dr("sFiyatTipi") = sFiyatA
                        dr("lBrutFiyat") = sorgu_sayi(dr1("ALISFIYATI"), 0)
                        dr("lTutari") = dr("lMiktari") * sorgu_sayi(dr1("ALISFIYATI"), 0)
                        dr("lBrutTutar") = dr("lMiktari") * sorgu_sayi(dr1("ALISFIYATI"), 0)
                    ElseIf nSiparisTipi = 1 Or nSiparisTipi = 4 Then
                        'dr("sFiyatTipi") = ""
                        dr1("FIYAT1") = sorgu_sayi(dr1("FIYAT1"), 0)
                        dr1("FIYAT2") = sorgu_sayi(dr1("FIYAT2"), 0)
                        dr1("FIYAT3") = sorgu_sayi(dr1("FIYAT3"), 0)
                        If Trim(dr_baslik("sFiyatTipi").ToString) <> "" Then
                            sFiyatTipi = Trim(dr_baslik("sFiyatTipi"))
                            dr("sFiyatTipi") = sFiyatTipi
                            If Trim(sFiyatTipi) = Trim(sFiyat1) Then
                                If bFiyatKdvHaric = False Then
                                    lBrutFiyat = dr1("FIYAT1") / ((100 + dr1("nKdvOrani")) / 100)
                                Else
                                    lBrutFiyat = dr1("FIYAT1")
                                End If
                                lBrutTutar = lBrutFiyat * dr("lMiktari")
                            ElseIf Trim(sFiyatTipi) = Trim(sFiyat2) Then
                                If bFiyatKdvHaric = False Then
                                    lBrutFiyat = dr1("FIYAT2") / ((100 + dr1("nKdvOrani")) / 100)
                                Else
                                    lBrutFiyat = dr1("FIYAT2")
                                End If
                                lBrutTutar = lBrutFiyat * dr("lMiktari")
                            ElseIf Trim(sFiyatTipi) = Trim(sFiyat3) Then
                                If bFiyatKdvHaric = False Then
                                    lBrutFiyat = dr1("FIYAT3") / ((100 + dr1("nKdvOrani")) / 100)
                                Else
                                    lBrutFiyat = dr1("FIYAT3")
                                End If
                                lBrutTutar = lBrutFiyat * dr("lMiktari")
                            ElseIf Trim(sFiyatTipi) = "PR" Then
                                lBrutFiyat = 0.01
                                lBrutTutar = 0.01 * dr("lMiktari")
                            Else
                                If bFiyatKdvHaric = False Then
                                    lBrutFiyat = dr1("lOzelFiyat") / ((100 + dr1("nKdvOrani")) / 100)
                                Else
                                    lBrutFiyat = sorgu_sayi(dr1("lOzelFiyat"), 0)
                                End If
                                lBrutTutar = lBrutFiyat * dr("lMiktari")
                            End If
                        Else
                            sFiyatTipi = sFiyat1
                            If bFiyatKdvHaric = False Then
                                lBrutFiyat = dr1("FIYAT1") / ((100 + dr1("nKdvOrani")) / 100)
                            Else
                                lBrutFiyat = dr1("FIYAT1")
                            End If
                            lBrutTutar = lBrutFiyat * dr("lMiktari")
                            dr("sFiyatTipi") = sFiyatTipi
                        End If
                    End If
                    dr("nKdvOrani") = dr1("nKdvOrani")
                    lMiktar = dr("lMiktari")
                    dr("ISK1") = sorgu_sayi(dr_baslik("nOzelIskontosu"), 0)
                    dr("ISK2") = 0
                    dr("ISK3") = 0
                    dr("ISK4") = 0
                    If sorgu_sayi(dr1("nIskontoYuzdesi"), 0) <> 0 Then
                        dr("ISK1") = sorgu_sayi(dr1("nIskontoYuzdesi"), 0)
                    End If
                    sorgu_tbProtokol(dr_baslik("nFirmaID"), dr("nStokID"))
                    If ds_Protokol.Tables(0).Rows.Count <> 0 Then
                        Dim dr2 As DataRow
                        dr2 = ds_Protokol.Tables(0).Rows(0)
                        'FiyatTipi
                        If Trim(dr2("sFiyatTipi")) <> "" And Trim(dr2("sFiyatTipi")) <> Trim(dr("sFiyatTipi")) Then
                            dr("sFiyatTipi") = dr2("sFiyatTipi")
                            If Trim(dr2("sFiyatTipi")) = Trim(sFiyat1) Then
                                If bFiyatKdvHaric = False Then
                                    lBrutFiyat = dr1("FIYAT1") / ((100 + dr1("nKdvOrani")) / 100)
                                Else
                                    lBrutFiyat = dr1("FIYAT1")
                                End If
                                lBrutTutar = lBrutFiyat * lMiktar
                            ElseIf Trim(dr2("sFiyatTipi")) = Trim(sFiyat2) Then
                                If bFiyatKdvHaric = False Then
                                    lBrutFiyat = dr1("FIYAT2") / ((100 + dr1("nKdvOrani")) / 100)
                                Else
                                    lBrutFiyat = dr1("FIYAT2")
                                End If
                                lBrutTutar = lBrutFiyat * lMiktar
                            ElseIf Trim(dr2("sFiyatTipi")) = Trim(sFiyat3) Then
                                If bFiyatKdvHaric = False Then
                                    lBrutFiyat = dr1("FIYAT3") / ((100 + dr1("nKdvOrani")) / 100)
                                Else
                                    lBrutFiyat = dr1("FIYAT3")
                                End If
                                lBrutTutar = lBrutFiyat * lMiktar
                            ElseIf Trim(dr2("sFiyatTipi")) = "PR" Then
                                lBrutFiyat = 0.01
                                lBrutTutar = 0.01 * lMiktar
                            Else
                                Dim llfiyat As Decimal = sorgu_stok_fiyat(dr2("sFiyatTipi"), dr1("nStokID"))
                                If llfiyat = 0 Then
                                    llfiyat = dr1("FIYAT1")
                                End If
                                If bFiyatKdvHaric = False Then
                                    lBrutFiyat = llfiyat / ((100 + dr1("nKdvOrani")) / 100)
                                Else
                                    lBrutFiyat = sorgu_sayi(llfiyat, 0)
                                End If
                                lBrutTutar = lBrutFiyat * lMiktar
                            End If
                            If lBrutFiyat = 0 Then
                                If bFiyatKdvHaric = False Then
                                    lBrutFiyat = dr1("FIYAT1") / ((100 + dr1("nKdvOrani")) / 100)
                                Else
                                    lBrutFiyat = dr1("FIYAT1")
                                End If
                            End If
                            lBrutTutar = lBrutFiyat * lMiktar
                            'dr("lBrutTutar") = lBrutTutar
                            'dr("lBrutFiyat") = lBrutFiyat
                            'dr("lFiyat") = lBrutFiyat
                            'dr("lDahilBrutFiyat") = lBrutFiyat * ((dr("nKdvOrani") + 100) / 100)
                            'dr("lDahilFiyat") = dr("lDahilBrutFiyat")
                            'dr("lDahilBrutTutar") = dr("lDahilBrutFiyat") * lMiktar
                        End If
                        'Kdv
                        If Trim(dr2("nKdvOrani")) <> -1 Then
                            dr("nKdvOrani") = dr2("nKdvOrani")
                        End If
                        'Fiyat
                        If Trim(dr2("lFiyat")) <> 0 Then
                            dr("lBrutFiyat") = dr2("lFiyat")
                            If bFiyatKdvHaric = False Then
                                lBrutFiyat = dr2("lFiyat") / ((100 + dr1("nKdvOrani")) / 100)
                            Else
                                lBrutFiyat = dr1("lFiyiat")
                            End If
                            lBrutTutar = lBrutFiyat * lMiktar
                            'dr("lBrutTutar") = lBrutTutar
                            'dr("lBrutFiyat") = lBrutFiyat
                            'dr("lFiyat") = lBrutFiyat
                            'dr("lDahilBrutFiyat") = lBrutFiyat * ((dr("nKdvOrani") + 100) / 100)
                            'dr("lDahilFiyat") = dr("lDahilBrutFiyat")
                            'dr("lDahilBrutTutar") = dr("lDahilBrutFiyat") * lMiktar
                        End If
                        dr("ISK1") = dr2("nIskontoYuzdesi1")
                        dr("ISK2") = dr2("nIskontoYuzdesi2")
                        dr("ISK3") = dr2("nIskontoYuzdesi3")
                        dr("ISK4") = dr2("nIskontoYuzdesi4")
                    End If
                    dr("sFiyatTipi") = Trim(sFiyatTipi)
                    If bImport = True And bImport_Fiyat = True Then
                        lBrutFiyat = bIFiyati
                    End If
                    If bImport = True And bImport_Tutar = True Then
                        lBrutFiyat = bITutari / mevcut
                        lBrutTutar = bITutari
                    End If
                    If lBrutFiyat = 0 Then
                        lBrutFiyat = 0.001
                        lBrutTutar = lBrutFiyat * dr("lMiktari")
                    End If
                    dr("lBrutTutar") = lBrutTutar
                    dr("lBrutFiyat") = lBrutFiyat
                    dr("lFiyat") = lBrutFiyat
                    dr("lFiyati") = lBrutFiyat
                    dr("lDahilBrutFiyat") = lBrutFiyat * ((dr("nKdvOrani") + 100) / 100)
                    dr("lDahilFiyat") = dr("lDahilBrutFiyat")
                    dr("lDahilBrutTutar") = dr("lDahilBrutFiyat") * lMiktar
                    lFiyat = dr("lBrutFiyat")
                    Dim lTutar As Decimal = 0
                    lFiyat = dr("lBrutFiyat")
                    isk1 = lFiyat * ((100 - dr("ISK1")) / 100)
                    isk2 = isk1 * ((100 - dr("ISK2")) / 100)
                    isk3 = isk2 * ((100 - dr("ISK3")) / 100)
                    isk4 = isk3 * ((100 - dr("ISK4")) / 100)
                    dr("nIskontoYuzdesi") = ((dr("lBrutFiyat") - isk4) / dr("lBrutFiyat")) * 100
                    dr("lNetFiyat") = (isk4 * ((dr("nKdvOrani") + 100) / 100))
                    lTutar = lFiyat * dr("lMiktari")
                    dr("lTutari") = lTutar
                    dr("lIskontoTutari") = dr("lBrutTutar") - lTutar
                    dr("sAsortiTipi") = ""
                    dr("sAsortiMiktari") = 0
                    'dr("nKdvOrani") = dr1("nKdvOrani")
                    'dr("nIskontoYuzdesi") = dr_baslik("nOzelIskontosu")
                    dr("sKullaniciAdi") = kullaniciadi
                    dr("dteKayitTarihi") = Now
                    dr("bKapandimi") = 0
                    dr("lReserveMiktari") = 0
                    dr("sHangiUygulama") = ""
                    dr("nPartiID") = 0
                    dr("sSatirAciklama") = "Isk1:" & uzunluk_tamamla(FormatNumber(dr("ISK1"), 2), 5) & " Isk2:" & uzunluk_tamamla(FormatNumber(dr("ISK2"), 2), 5) & " Isk3:" & uzunluk_tamamla(FormatNumber(dr("ISK3"), 2), 5) & " Isk4:" & uzunluk_tamamla(FormatNumber(dr("ISK4"), 2), 5)
                    dr("nValorGun") = 0
                    dr("sDovizCinsi") = ""
                    dr("lDovizFiyati") = 0
                    dr("lDovizKuru") = 0
                    dr("sModel") = dr1("sModel")
                    dr("sKodu") = dr1("sKodu")
                    dr("sAciklama") = dr1("sAciklama")
                    dr("sFirmaKodu") = dr_baslik("sKodu")
                    dr("sFirmaAciklama") = dr_baslik("sAciklama")
                    dr("sSaticiRumuzu") = dr_baslik("sSaticiRumuzu")
                    dr("sKisaAdi") = dr1("sKisaAdi").ToString
                    dr("nHacim") = sorgu_sayi(dr1("nHacim"), 0)
                    dr("nAgirlik") = sorgu_sayi(dr1("nAgirlik"), 0)
                    dr("sDepo") = sDepo
                    dr("sRenkAdi") = dr1("sRenkAdi")
                    dr("sBeden") = dr1("sBeden")
                    dr("sBirimCinsi") = dr1("sBirimCinsi1").ToString
                    dr("sAmbalaj") = dr1("sBirimCinsi1").ToString
                    dr("sBirimCinsi1") = dr1("sBirimCinsi1").ToString
                    dr("lBirimMiktar") = 1
                    dr("lFiyat") = dr("lBrutFiyat")
                    'dr("nBirimCarpan") = sorgu_sayi(dr1("nBirimCarpan"), 1)
                    'Doviz Hesapla
                    If dr("sDovizCinsi").ToString <> "" And dr("lDovizKuru") <> 0 Then
                        dr("lDovizFiyati") = dr("lBrutFiyat") / dr("lDovizKuru")
                        dr("lDovizBrutFiyati") = dr("lBrutFiyat") / dr("lDovizKuru")
                        dr("lDovizTutar") = dr("lBrutTutar") / dr("lDovizKuru")
                        dr("lDahilDovizFiyati") = dr("lBrutFiyat")
                        dr("lDahilDovizBrutFiyati") = dr("lBrutFiyat")
                        dr("lDahilDovizTutar") = dr("lBrutTutar")
                    Else
                        dr("lDovizFiyati") = dr("lBrutFiyat")
                        dr("lDovizBrutFiyati") = dr("lBrutFiyat")
                        dr("lDovizTutar") = dr("lBrutTutar")
                        dr("lDahilDovizFiyati") = dr("lBrutFiyat")
                        dr("lDahilDovizBrutFiyati") = dr("lBrutFiyat")
                        dr("lDahilDovizTutar") = dr("lBrutTutar")
                    End If
                    'dr("lSevkiyat") = 0
                    dr("lYukleme") = 0
                    dr("nSiparisID") = tbSiparis_kaydet_yeni(dr("nSiparisID"), dr("nSiparisTipi"), dr("lSiparisNo"), dr("nFirmaID"), dr("nStokID"), dr("dteSiparisTarihi"), dr("dteTeslimTarihi"), dr("sSiparisIslem"), dr("nReceteNo"), dr("sSiparisiAlan"), dr("sSiparisiVeren"), dr("sFiyatTipi"), dr("lMiktari"), dr("lBrutFiyat"), dr("lTutari"), dr("sAsortiTipi"), dr("sAsortiMiktari"), dr("nKdvOrani"), dr("nIskontoYuzdesi"), dr("lBrutTutar"), kullaniciadi, Now, dr("bKapandimi"), dr("lReserveMiktari"), dr("sHangiUygulama"), dr("nPartiID"), dr("sSatirAciklama"), dr("nValorGun"), dr("sDovizCinsi"), dr("lDovizFiyati"), dr("lDovizKuru"), dr("sSaticiRumuzu"), dr("sDepo"), dr("sBirimCinsi"), dr("lBirimMiktar"), dr("sAmbalaj"))
                    nSiparisID_degistir(nSiparisID)
                    ds_tbSiparis.Tables(0).Rows.Add(dr)
                    lFiyat = Nothing
                    lTutar = Nothing
                    If yeni = True Then
                        Try
                            tbSiparis_Aciklamasi_kaydet_yeni(nSiparisTipi, lSiparisNo, nFirmaID, dr_baslik("sAciklama1").ToString, dr_baslik("sAciklama2").ToString, dr_baslik("sAciklama3").ToString, dr_baslik("sAciklama4").ToString, dr_baslik("sAciklama5").ToString, 0)
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
        Dataload_tbYekun(dr_baslik("dteSiparisTarihi"), dr_baslik("nSiparisTipi"), dr_baslik("lSiparisNo"), dr_baslik("nFirmaID"))
        If GridView1.RowCount > 0 Then
            GridView1.FocusedRowHandle = GridView1.RowCount - 1
            GridView1.ClearSelection()
            GridView1.SelectRow(GridView1.RowCount - 1)
            PanelControl3.Focus()
            GridControl1.Focus()
        End If
        GridView1.FocusedColumn = collMiktari
        satir_kontrol()
    End Sub
    Private Function sorgu_sayi(ByVal deger As Object, ByVal sonuc As Decimal) As Decimal
        Dim val As Decimal
        If deger Is Nothing OrElse deger Is DBNull.Value OrElse String.IsNullOrEmpty(deger.ToString()) Then
            Return sonuc
        End If
        If Decimal.TryParse(deger.ToString(), NumberStyles.Any, CultureInfo.InvariantCulture, val) Then
            Return val
        Else
            Return sonuc
        End If
    End Function
    Private Sub satir_sil()
        ' Parametrik onay kontrolu - bOnayVar = TRUE ise kontrol yap
        Dim dtParamOnay3 As DataTable = SQLCalistir("SELECT ISNULL(bOnayVar, 0) AS bOnayVar FROM tbParamAlSiparis")
        Dim bOnayVarParam3 As Boolean = False
        If dtParamOnay3.Rows.Count > 0 Then
            bOnayVarParam3 = Convert.ToBoolean(dtParamOnay3.Rows(0)("bOnayVar"))
        End If
        
        If bOnayVarParam3 Then
            Dim dtOnay As DataTable = SQLCalistir("SELECT ISNULL(bOnay, 0) FROM tbSiparis  WHERE lSiparisNo = " & lSiparisNo & " AND nFirmaID = " & nFirmaID)
            If dtOnay.Rows.Count > 0 AndAlso Convert.ToBoolean(dtOnay.Rows(0)(0)) Then
                MessageBox.Show("Sevk Onayı verilmiş Siparişte değişiklik yapamazsınız.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Exit Sub
            End If
        End If
        If GridView1.RowCount > 0 Then
            If XtraMessageBox.Show(Sorgu_sDil("Satırı Silmek İstediğinize Emin misiniz...?", sDil), Sorgu_sDil("Dikkat", sDil), MessageBoxButtons.YesNo, MessageBoxIcon.Question) = MsgBoxResult.Yes Then
                Dim dr As DataRow
                dr = GridView1.GetDataRow(GridView1.FocusedRowHandle)
                tbSiparis_kaydet_sil(dr("nSiparisID"))
                ds_tbSiparis.Tables(0).Rows.Remove(dr)
                GridControl1.Focus()
                GridControl1.Select()
                Dataload_tbYekun(dr_baslik("dteSiparisTarihi"), dr_baslik("nSiparisTipi"), dr_baslik("lSiparisNo"), dr_baslik("nFirmaID"))
                If GridView1.RowCount > 0 Then
                    GridView1.SelectRow(GridView1.FocusedRowHandle)
                End If
            End If
        End If
    End Sub
    Private Sub sFiyatTipi_toplu()
        Dim frm As New frm_tbKod
        frm.firmano = firmano
        frm.donemno = donemno
        frm.connection = connection
        frm.sText = "SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT     sFiyatTipi as sKod,sAciklama as sAciklama FROM         tbFiyatTipi where (aktif = 1) and (aktifDepo like '%" & Trim(sDepo) & "%')"
        frm.lbl_sKod.Text = "FiyatTipi:"
        If frm.ShowDialog() = Windows.Forms.DialogResult.OK Then
            If XtraMessageBox.Show(frm.LookUpEdit1.EditValue & Sorgu_sDil(" FiyatTipini Atamak İstediğinize Emin misiniz...?", sDil), Sorgu_sDil("Dikkat", sDil), MessageBoxButtons.YesNo, MessageBoxIcon.Question) = MsgBoxResult.Yes Then
                Dim sayi = 0
                Dim say As Integer = -1
                Dim Fiyat As Decimal = 0
                Dim lMiktar As Decimal = 0
                Dim dr As DataRow
                Dim satir = GridView1.FocusedRowHandle
                For Each dr In ds_tbSiparis.Tables(0).Rows
                    say += 1
                    Fiyat = sorgu_stok_fiyat(frm.LookUpEdit1.EditValue, dr("nStokID"))
                    If bFiyatKdvHaric = False Then
                        Fiyat = Fiyat / ((100 + dr("nKdvOrani")) / 100)
                    Else
                        Fiyat = sorgu_sayi(Fiyat, 0)
                    End If
                    If Fiyat <> 0 Then
                        sayi += 1
                        dr("sFiyatTipi") = frm.LookUpEdit1.EditValue
                        dr("lFiyat") = Fiyat * dr("lBirimMiktar")
                        dr("lFiyati") = Fiyat
                        'If dr_baslik("nGirisCikis") = 1 Or dr_baslik("nGirisCikis") = 2 Then
                        lMiktar = dr("lMiktari")
                        'ElseIf dr_baslik("nGirisCikis") = 3 Or dr_baslik("nGirisCikis") = 4 Then
                        lMiktar = dr("lMiktari")
                        'End If
                        dr("lTutari") = lMiktar * dr("lBrutFiyat")
                        dr("lBrutTutar") = lMiktar * dr("lBrutFiyat")
                        'dr("lCikisFiyat") = dr("lBrutFiyat") / ((100 + dr("nKdvOrani")) / 100)
                        'dr("lCikisTutar") = dr("lBrutTutar") / ((100 + dr("nKdvOrani")) / 100)
                        'tbStokFisidetay_kaydet_degistir(dr("nIslemID"), dr("nStokID"), dr_baslik("dteFaturaTarihi"), dr("nFirmaID"), dr_baslik("nMusteriID"), dr_baslik("sFisTipi"), dr_baslik("dteFaturaTarihi"), dr("lFisNo"), dr("nGirisCikis"), dr("sDepo"), dr("lReyonFisNo"), dr("sStokIslem"), dr("sKasiyerRumuzu"), dr("sSaticiRumuzu"), dr("sOdemeKodu"), dr("dteIrsaliyeTarihi"), dr("lIrsaliyeNo"), dr("lGirisMiktar1"), dr("lGirisMiktar2"), dr("lGirisFiyat"), dr("lGirisTutar"), dr("lCikisMiktar1"), dr("lCikisMiktar2"), dr("lCikisFiyat"), dr("lCikisTutar"), dr("sFiyatTipi"), dr("lBrutFiyat"), dr("lBrutTutar"), dr("lMaliyetFiyat"), dr("lMaliyetTutar"), dr("lIlaveMaliyetTutar"), dr("nIskontoYuzdesi"), dr("lIskontoTutari"), dr("sDovizCinsi"), dr("lDovizFiyat"), dr("nSiparisID").ToString, dr("nReceteNo"), dr("nTransferID").ToString, dr("sTransferDepo").ToString, dr("nKdvOrani"), dr("nHesapID"), dr("sAciklama"), dr("sHareketTipi"), dr("bMuhasebeyeIslendimi"), dr("sKullaniciAdi"), dr("dteKayitTarihi"), dr("sDovizCinsi"), dr("lDovizMiktari1"), dr("lDovizKuru"), dr("sDovizCinsi2"), dr("lDovizMiktari2"), dr("lDovizKuru2"), dr("nOTVOrani"), dr("nTransferFirmaID").ToString, nAlisVerisID, 0, dr("nIrsaliyeFisiID").ToString, dr("sMasrafYontemi"), dr("sHangiUygulama"), dr("nEksaha1"), dr("nEkSaha2"), dr("bEkSoru1"), dr("bEkSoru2"), dr("sSonKullaniciAdi"), dr("dteSonUpdateTarihi"))
                        info = False
                        GridView1.FocusedRowHandle = say
                        tutar_hesapla()
                    End If
                Next
                info = True
                'İskonto Güncelle
                'If Trim("sFisTipi") = "K" Then
                '    dr_toplam("nDipIskontoYuzdesi") = lIskontoYuzdesi
                'ElseIf Trim("sFisTipi") = "P" Then
                '    dr_toplam("nDipIskontoYuzdesi") = lIskontoYuzdesi
                'End If
                'If dr_toplam("nDipIskontoYuzdesi") > nMaxIskontoYuzdesi Then
                '    dr_toplam("nDipIskontoYuzdesi") = nMaxIskontoYuzdesi
                'End If
                'toplam_hesapla()
                'tbStokFisiDetayi_DipIskonto_kaydet_duzelt(nAlisVerisID, dr_baslik("nGCT"), dr_toplam("nDipIskontoYuzdesi"), 0, 0, dr_toplam("lDipIskontoTutari"), dr_toplam("lMalBedeli"), dr_toplam("lMalIskontoTutari"), VGrid_toplam.FocusedRecordCellIndex.ToString)
                'Dim satir = GridView1.FocusedRowHandle
                Dataload_tbSiparis(dr_baslik("dteSiparisTarihi"), dr_baslik("nSiparisTipi"), dr_baslik("lSiparisNo"), dr_baslik("nFirmaID"))
                GridView1.FocusedRowHandle = satir
                satir_kontrol()
                dr = Nothing
                sayi = Nothing
                If sayi > 0 Then
                    sFiyatTipi = frm.LookUpEdit1.EditValue
                End If
                XtraMessageBox.Show(Sorgu_sDil("İşlem Başarıyla Tamamlandı...", sDil), Sorgu_sDil("Dikkat", sDil), MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        End If
    End Sub
    '    Private Sub satir_birlestir()
    '        Dim row As DataRow
    '        Dim row2 As DataRow
    '        Dim _birlestir As frm_stok_etikettalep_birlestir
    '        Dim num As Long
    '        Dim enumerator As IEnumerator
    '        Dim enumerator2 As IEnumerator
    '        Dim flag As Boolean
    '        Dim flag2 As Boolean
    '        _birlestir = New frm_stok_etikettalep_birlestir
    '        _birlestir.firmano = RuntimeHelpers.GetObjectValue(Me.firmano)
    '        _birlestir.donemno = RuntimeHelpers.GetObjectValue(Me.donemno)
    '        _birlestir.connection = RuntimeHelpers.GetObjectValue(Me.connection)
    '        _birlestir.dteFisTarihi = Conversions.ToDate(Me.dr_baslik.Item("dteFisTarihi"))
    '        _birlestir.sFisTipi = Conversions.ToString(Me.dr_baslik.Item("sFisTipi"))
    '        _birlestir.nGirisCikis = Conversions.ToInteger(Me.dr_baslik.Item("nGirisCikis"))
    '        _birlestir.nStokFisiID = Conversions.ToString(Me.dr_baslik.Item("nStokFisiID"))
    '        _birlestir.fatura = 1
    '        _birlestir.islemstatus = 1
    '        num = 0
    '        If ((_birlestir.ShowDialog(Me) = 1) = Nothing) Then
    '            GoTo Label_0412
    '        End If
    'Label_00CB:
    '        Try
    '            enumerator = _birlestir.dataset1.Tables.Item(0).Rows.GetEnumerator
    '            GoTo Label_0399
    'Label_00ED:
    '            row2 = DirectCast(enumerator.Current, DataRow)
    '            If (Operators.ConditionalCompareObjectEqual(row2.Item("SEC"), CBool(1), 0) = Nothing) Then
    '                GoTo Label_0397
    '            End If
    '            num = 0
    'Label_011E:
    '            Try
    '                enumerator2 = Me.ds_hareket.Tables.Item(0).Rows.GetEnumerator
    '                GoTo Label_0362
    'Label_0140:
    '                row = DirectCast(enumerator2.Current, DataRow)
    '                If (Operators.ConditionalCompareObjectEqual(row.Item("nStokID"), row2.Item("IND"), 0) = Nothing) Then
    '                    GoTo Label_035B
    '                End If
    '                If (Operators.ConditionalCompareObjectEqual(row.Item("nIslemID"), row2.Item("nIslemID"), 0) = Nothing) Then
    '                    GoTo Label_0244
    '                End If
    '                row.BeginEdit()
    '                row.Item("lGirisMiktar1") = RuntimeHelpers.GetObjectValue(row2.Item("lGirisMiktar1"))
    '                row.Item("lCikisMiktar1") = RuntimeHelpers.GetObjectValue(row2.Item("lCikisMiktar1"))
    '                row.Item("lCikisMiktar") = Operators.DivideObject(row.Item("lCikisMiktar1"), row.Item("lBirimMiktar"))
    '                row.Item("lGirisMiktar") = Operators.DivideObject(row.Item("lGirisMiktar1"), row.Item("lBirimMiktar"))
    '                row.EndEdit()
    '                Me.tutar_hesapla(0, 0, 0, CInt(num))
    '                Me.toplam_hesapla(0)
    '                GoTo Label_035A
    'Label_0244:
    '                If (((((Operators.CompareString(Trim(Conversions.ToString(row.Item("sAciklama"))), Trim(Conversions.ToString(row2.Item("sAciklama"))), 0) = 0) And (Operators.CompareString(Trim(Conversions.ToString(row.Item("sDepo"))), Trim(Conversions.ToString(row2.Item("DEPO"))), 0) = 0)) And (Operators.CompareString(FormatNumber(RuntimeHelpers.GetObjectValue(row.Item("lGirisFiyat")), 4, -2, -2, -2), FormatNumber(RuntimeHelpers.GetObjectValue(row2.Item("lGirisFiyat")), 4, -2, -2, -2), 0) = 0)) And (Operators.CompareString(FormatNumber(RuntimeHelpers.GetObjectValue(row.Item("lCikisFiyat")), 4, -2, -2, -2), FormatNumber(RuntimeHelpers.GetObjectValue(row2.Item("lCikisFiyat")), 4, -2, -2, -2), 0) = 0)) = False) Then
    '                    GoTo Label_035A
    '                End If
    '                Me.tbStokFisidetay_kaydet_sil(Me.nStokFisiID, Conversions.ToLong(row.Item("nIslemID")))
    '                Me.toplam_hesapla(0)
    'Label_035A:
    'Label_035B:
    '                num = (num + 1)
    'Label_0362:
    '                If (Not enumerator2.MoveNext = Nothing) Then
    '                    GoTo Label_0140
    '                End If
    '                GoTo Label_0397
    '            Finally
    'Label_0375:
    '                If (((TryCast(enumerator2, IDisposable) Is Nothing) = 0) = Nothing) Then
    '                    GoTo Label_0395
    '                End If
    '                TryCast(enumerator2, IDisposable).Dispose()
    'Label_0395:
    '            End Try
    'Label_0397:
    'Label_0399:
    '            If (Not enumerator.MoveNext = Nothing) Then
    '                GoTo Label_00ED
    '            End If
    '            GoTo Label_03CE
    '        Finally
    'Label_03AC:
    '            If (((TryCast(enumerator, IDisposable) Is Nothing) = 0) = Nothing) Then
    '                GoTo Label_03CC
    '            End If
    '            TryCast(enumerator, IDisposable).Dispose()
    'Label_03CC:
    '        End Try
    'Label_03CE:
    '        Me.yuklendi = 0
    '        Me.dataload_harekets()
    '        Me.toplam_hesapla(0)
    '        Me.yuklendi = 1
    '        XtraMessageBox.Show(KeyCode.Sorgu_sDil("Satırlar Başarıyla Birleştirilmiştir...", sDil), Sorgu_sDil("Dikkat", sDil), MessageBoxButtons.OK)
    'Label_0412:
    '        row = Nothing
    '        Return
    '    End Sub
    Private Sub sSaticiRumuzu_toplu()
        Dim frm As New frm_tbKod
        frm.firmano = firmano
        frm.donemno = donemno
        frm.connection = connection
        frm.sText = "SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT     sSaticiRumuzu as sKod,sAdi as sAciklama FROM         tbSatici where bAktif =1"
        frm.lbl_sKod.Text = "Satici:"
        If frm.ShowDialog() = Windows.Forms.DialogResult.OK Then
            If XtraMessageBox.Show(frm.LookUpEdit1.EditValue & Sorgu_sDil(" Kodunu Satıcılara Atamak İstediğinize Emin misiniz...?", sDil), Sorgu_sDil("Dikkat", sDil), MessageBoxButtons.YesNo, MessageBoxIcon.Question) = MsgBoxResult.Yes Then
                Dim sayi As Integer = 0
                Dim dr As DataRow
                For Each dr In ds_tbSiparis.Tables(0).Rows
                    dr("sSaticiRumuzu") = frm.LookUpEdit1.EditValue
                    tutar_hesapla(sayi)
                    sayi += 1
                Next
                XtraMessageBox.Show(Sorgu_sDil("Tamamlandı", sDil), Sorgu_sDil("Dikkat", sDil), MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        End If
    End Sub
    Private Sub satir_degistir()
        If GridView1.RowCount > 0 Then
            Dim frm As New frm_stok
            Dim dr1 As DataRow
            Dim dr As DataRow
            'Dim dr As DataRow = GridView1.GetDataRow(GridView1.FocusedRowHandle)
            dr = GridView1.GetDataRow(GridView1.FocusedRowHandle)
            frm.connection = connection
            frm.firmano = firmano
            frm.donemno = donemno
            frm.islemstatus = True
            If frm.ShowDialog() = Windows.Forms.DialogResult.OK Then
                dr1 = frm.GridView1.GetDataRow(frm.GridView1.FocusedRowHandle)
                dr("nStokID") = dr1("nStokId")
                dr("sKodu") = dr1("sKodu")
                dr("sAciklama") = dr1("sAciklama")
                dr("sBarkod") = dr1("sBarkod")
                'dr("sRenk") = dr1("sRenk").ToString
                dr("sBeden") = dr1("sBeden")
                dr("sRenkAdi") = dr1("sRenkAdi")
                dr("sModel") = dr1("sModel")
                'dr("nStokTipi") = dr1("nStokTipi")
                'dr("nFiyatlandirma") = dr1("nFiyatlandirma")
                'dr("sAciklama") = dr1("sAciklama")
                tutar_hesapla(False)
            End If
            frm.Close()
            frm.Dispose()
            frm = Nothing
            dr1 = Nothing
        End If
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
            'frm.sRenk = dr("sRenk")
            'frm.sBeden = dr("sBeden")
            frm.txt_musteriNo.Text = dr("sModel")
            frm.kullanici = kullanici
            If yetki_kontrol(kullanici, frm.Name) = True Then
                frm.ShowDialog()
            End If
            frm.Close()
            frm.Dispose()
            frm = Nothing
        End If
    End Sub
    Private Function sorgu_firma_info(ByVal nFirmaID As String) As DataSet
        Dim cmd As New OleDb.OleDbCommand
        Dim con As New OleDb.OleDbConnection
        Dim adapter As New OleDb.OleDbDataAdapter
        con.ConnectionString = connection
        cmd.CommandTimeout = Nothing
        adapter.SelectCommand = cmd
        cmd.CommandText = sorgu_query("SET DATEFORMAT DMY SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT tbFirma.lKrediLimiti, SUM(tbFirmaHareketi.lBorcTutar - tbFirmaHareketi.lAlacakTutar) AS BAKIYE FROM tbFirmaHareketi INNER JOIN tbFirma ON tbFirmaHareketi.nFirmaID = tbFirma.nFirmaID WHERE tbFirma.nFirmaID ='" & nFirmaID & "' GROUP BY tbFirma.lKrediLimiti")
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
    Private Function GetDec(row As DataRow, col As String) As Decimal
        If row Is Nothing OrElse Not row.Table.Columns.Contains(col) Then Return 0D
        Dim v = row(col)
        If v Is Nothing OrElse v Is DBNull.Value Then Return 0D
        If TypeOf v Is Decimal OrElse TypeOf v Is Double OrElse TypeOf v Is Single OrElse TypeOf v Is Integer OrElse TypeOf v Is Long Then
            Return Convert.ToDecimal(v)
        End If
        Dim s As String = v.ToString().Trim()
        If s = "" Then Return 0D
        Dim d As Decimal
        If Decimal.TryParse(s, NumberStyles.Any, TR, d) Then Return d
        If Decimal.TryParse(s, NumberStyles.Any, CultureInfo.InvariantCulture, d) Then Return d
        If Decimal.TryParse(s, NumberStyles.Any, CultureInfo.CurrentCulture, d) Then Return d
        Return 0D
    End Function
    Private Sub satir_firma_info()
        Dim ds_satir_firma As DataSet = sorgu_firma_info(dr_baslik("nFirmaID"))
        If ds_satir_firma Is Nothing OrElse ds_satir_firma.Tables.Count = 0 OrElse ds_satir_firma.Tables(0).Rows.Count = 0 Then Exit Sub

        Dim dr1 As DataRow = ds_satir_firma.Tables(0).Rows(0)

        ' ds_tbSiparisToplam güvenli kontrol
        If ds_tbSiparisToplam Is Nothing OrElse ds_tbSiparisToplam.Tables.Count = 0 OrElse ds_tbSiparisToplam.Tables(0).Rows.Count = 0 Then Exit Sub
        dr_toplam = ds_tbSiparisToplam.Tables(0).Rows(0)

        Dim bakiye As Decimal = GetDec(dr1, "BAKIYE")
        Dim netTutar As Decimal = GetDec(dr_toplam, "lNetTutar")
        Dim limit As Decimal = GetDec(dr1, "lKrediLimiti")

        bakiye += netTutar

        If limit > 0D Then
            If bakiye >= limit Then
                Dim msj As String = If(bakiye = limit,
                Sorgu_sDil("Cari Hesabın Kredi Limiti Doldu...!", sDil),
                Sorgu_sDil("Cari Hesabın Kredi Limitini Aştınız..!", sDil))
                Dim ikon As MessageBoxIcon = If(bakiye = limit, MessageBoxIcon.Information, MessageBoxIcon.Warning)
                XtraMessageBox.Show(msj, Sorgu_sDil("Dikkat", sDil), MessageBoxButtons.OK, ikon)
                If bakiye > limit Then fis_kontrolleri()
            End If
        End If
    End Sub
    Private Sub satir_kontrol()
        'Try
        If status = True Then
            If GridView1.RowCount > 0 Then
                Dim dr As DataRow
                dr = GridView1.GetDataRow(GridView1.FocusedRowHandle)
                ds_satir_stok = sorgu_stok_info(dr("sKodu"))
                Dim dr1 As DataRow = ds_satir_stok.Tables(0).Rows(0)
                If dr1("sRenkAdi").ToString <> "" Then
                    lbl_StokInfo.Text = dr1("STOKADI") & " (Renk: " & dr1("sRenkAdi") & ") Giren: " & CType(sorgu_sayi(dr1("GIREN"), 0), Int64) & " Çıkan: " & CType(sorgu_sayi(dr1("CIKAN"), 0), Int64) & " Mevcut: " & CType(sorgu_sayi(dr1("KALAN"), 0), Int64) & " AS: " & CType(sorgu_sayi(dr1("lAlinan"), 0), Int64) & " VS: " & CType(sorgu_sayi(dr1("lVerilen"), 0), Int64)
                Else
                    lbl_StokInfo.Text = dr1("STOKADI") & " Giren: " & CType(sorgu_sayi(dr1("GIREN"), 0), Int64) & " Çıkan: " & CType(sorgu_sayi(dr1("CIKAN"), 0), Int64) & " Mevcut: " & CType(sorgu_sayi(dr1("KALAN"), 0), Int64) & " AS: " & CType(sorgu_sayi(dr1("AlinanSiparis"), 0), Int64) & " VS: " & CType(sorgu_sayi(dr1("VerilenSiparis"), 0), Int64)
                End If
                If dr1("KALAN") > 0 Then
                    Me.lbl_StokInfo.ForeColor = Color.Navy
                ElseIf dr1("KALAN") < 0 Then
                    Me.lbl_StokInfo.ForeColor = Color.Red
                ElseIf dr1("KALAN") = 0 Then
                    Me.lbl_StokInfo.ForeColor = Color.DarkGreen
                End If
                'Label2.Text = dr1("STOKADI") & " Renk: " & dr1("sRenkAdi") & " Giren: " & dr1("GIREN") & "Çıkan: " & dr1("CIKAN") & " Kalan: " & dr1("KALAN") & " Bekleyen: " & dr1("BEKLEYEN")
                lbl_StokInfo.Refresh()
                dr1 = Nothing
            End If
        End If
        'Catch ex As Exception
        '    lbl_StokInfo.Text = "*"
        'End Try
    End Sub
    Private Sub fis_sil()
        If XtraMessageBox.Show(Sorgu_sDil("Fişi Silmek İstediğinize Emin misiniz...?", sDil), Sorgu_sDil("Dikkat", sDil), MessageBoxButtons.YesNo, MessageBoxIcon.Question) = MsgBoxResult.Yes Then
            tbSiparis_sil(dr_baslik("dteSiparisTarihi"), dr_baslik("nSiparisTipi"), dr_baslik("lSiparisNo"), dr_baslik("nFirmaID"))
            ' DÜZELTME: Sipariş silindiğinde counter ARTIRMAMALI!
            ' Counter sadece yeni sipariş oluşturulduğunda artırılır
            ' lSiparisNo_degistir(dr_baslik("nSiparisTipi")) ' KALDIRILDI
            tutar_hesapla()
            Try
                ds_tbSiparis.Tables(0).Clear()
            Catch ex As Exception
            End Try
            'txt_dteSiparisTarihi.EditValue = dteSistemTarihi
            'txt_lSiparisNo.EditValue = 
            Me.Close()
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
            If dr("lBirimMiktar") = 0 Then
                dr("lBirimMiktar") = 1
            End If
            If dr("lMiktari") = 0 Then
                dr("lMiktari") = 1
            End If
            dr("lMiktari") = dr("lMiktar") * dr("lBirimMiktar")
            dr("lMiktari") = sorgu_sayi(dr("lMiktari"), 1)
            If GridView1.FocusedColumn.Name.ToString = colNetFiyat.Name.ToString Then
                If dr("lNetFiyat") = 0 Then
                    dr("lNetFiyat") = 0.01
                End If
                Dim lNetFiyat = 0
                Dim lFark As Decimal = 0
                Dim lFarkOran As Decimal = 0
                lNetFiyat = (dr("lTutari") / dr("lMiktari")) * ((dr("nKdvOrani") + 100) / 100)
                lFark = dr("lNetFiyat") - lNetFiyat
                lFark = (lFark / ((dr("nKdvOrani") + 100) / 100))
                lFiyat = 100
                isk1 = lFiyat * ((100 - dr("ISK1")) / 100)
                isk2 = isk1 * ((100 - dr("ISK2")) / 100)
                isk3 = isk2 * ((100 - dr("ISK3")) / 100)
                isk4 = isk3 * ((100 - dr("ISK4")) / 100)
                lFarkOran = lFark / isk4 * 100
                Dim nIskontoYuzdesi As Decimal = isk4
                lFarkOran = dr("lNetFiyat") * nIskontoYuzdesi / lNetFiyat
                If lFarkOran - nIskontoYuzdesi < 0 Then
                    iskonto_yuvarla(lFarkOran)
                ElseIf lFarkOran - nIskontoYuzdesi > 0 Then
                    iskonto_yuvarla(lFarkOran, 1)
                End If
            End If
            dr("lBrutFiyat") = sorgu_sayi(dr("lBrutFiyat"), 0.01)
            dr("lTutari") = sorgu_sayi(dr("lTutari"), 0.01)
            dr("lBrutTutar") = sorgu_sayi(dr("lBrutTutar"), 0.01)
            dr("ISK1") = sorgu_sayi(dr("ISK1"), 0)
            dr("ISK2") = sorgu_sayi(dr("ISK2"), 0)
            dr("ISK3") = sorgu_sayi(dr("ISK3"), 0)
            dr("ISK4") = sorgu_sayi(dr("ISK4"), 0)
            dr("sAsortiMiktari") = sorgu_sayi(dr("sAsortiMiktari"), 0)
            dr("nKdvOrani") = sorgu_sayi(dr("nKdvOrani"), 0)
            dr("nIskontoYuzdesi") = sorgu_sayi(dr("nIskontoYuzdesi"), 0)
            dr("bKapandimi") = sorgu_sayi(dr("bKapandimi"), 0)
            dr("lReserveMiktari") = sorgu_sayi(dr("lReserveMiktari"), 0)
            dr("nPartiID") = sorgu_sayi(dr("nPartiID"), 0)
            dr("nValorGun") = sorgu_sayi(dr("nValorGun"), 0)
            dr("lDovizFiyati") = sorgu_sayi(dr("lDovizFiyati"), 0)
            dr("lDovizKuru") = sorgu_sayi(dr("lDovizKuru"), 0)
            If dr("lBrutFiyat") = 0 Then
                dr("lBrutFiyat") = 0.01
            End If
            If GridView1.FocusedColumn.Name.ToString = collBirimFiyat.Name.ToString Then
                dr("lFiyat") = sorgu_sayi(dr("lFiyati"), 0) * sorgu_sayi(dr("lBirimMiktar"), 0)
            End If
            dr("lBrutFiyat") = dr("lFiyat") / dr("lBirimMiktar")
            dr("lDahilBrutFiyat") = dr("lDahilFiyat") / dr("lBirimMiktar")
            If GridView1.FocusedColumn.Name.ToString = collBrutTutar.Name.ToString Then
                If dr("lBrutTutar") = 0 Then
                    dr("lBrutTutar") = 0.001
                    dr("lBrutFiyat") = 0.001
                ElseIf dr("lBrutTutar") > 99000000 Then
                    dr("lBrutTutar") = 1
                    XtraMessageBox.Show(Sorgu_sDil("Yanlış Tutar Bilgisi, Lütfen Tutarı Kontrol Ediniz...!", sDil), Sorgu_sDil("Dikkat", sDil), MessageBoxButtons.OK, MessageBoxIcon.Warning)
                End If
            Else
                If dr("lFiyat") = 0 Then
                    dr("lFiyat") = 0.001
                ElseIf dr("lFiyat") > 99000000 Then
                    dr("lFiyat") = 1
                    XtraMessageBox.Show(Sorgu_sDil("Yanlış Fiyat Bilgisi, Lütfen Fiyatı Kontrol Ediniz...!", sDil), Sorgu_sDil("Dikkat", sDil), MessageBoxButtons.OK, MessageBoxIcon.Warning)
                End If
                If dr("lBrutFiyat") = 0 Then
                    dr("lBrutFiyat") = 0.001
                    dr("lBrutTutar") = 0.001
                ElseIf dr("lBrutFiyat") > 99000000 Then
                    dr("lBrutFiyat") = 1
                    dr("lBrutTutar") = 1
                    XtraMessageBox.Show(Sorgu_sDil("Yanlış Fiyat Bilgisi, Lütfen Fiyatı Kontrol Ediniz...!", sDil), Sorgu_sDil("Dikkat", sDil), MessageBoxButtons.OK, MessageBoxIcon.Warning)
                End If
            End If
            lMiktar = dr("lMiktari")
            'Dovizli
            If GridView1.FocusedColumn.Name.ToString = collDovizTutar.Name.ToString Then
                If dr_baslik("bListelendimi") = True Then
                    dr("lDovizTutar") = (dr("lDahilDovizTutar") / ((dr("nKdvOrani") + 100) / 100))
                    dr("lDovizFiyati") = dr("lDovizTutar") / lMiktar
                    dr("lDahilDovizFiyati") = dr("lDahilDovizTutar") / lMiktar
                    If dr("lDovizKuru") <> 0 Then
                        dr("lBrutFiyat") = (dr("lDahilDovizTutar") / lMiktar) * dr("lDovizKuru")
                        dr("lFiyat") = dr("lBrutFiyat") * dr("lBirimMiktar")
                    End If
                Else
                    dr("lDovizFiyati") = dr("lDovizTutar") / lMiktar
                    dr("lDahilDovizTutar") = lMiktar * (dr("lDovizFiyati") * ((dr("nKdvOrani") + 100) / 100))
                    dr("lDahilDovizFiyati") = dr("lDahilDovizTutar") / lMiktar
                    If dr("lDovizKuru") <> 0 Then
                        dr("lBrutFiyat") = (dr("lDovizTutar") / lMiktar) * dr("lDovizKuru")
                        dr("lFiyat") = dr("lBrutFiyat") * dr("lBirimMiktar")
                    End If
                End If
            ElseIf GridView1.FocusedColumn.Name.ToString = collDovizFiyati.Name.ToString Then
                If dr_baslik("bListelendimi") = True Then
                    dr("lDovizTutar") = lMiktar * (dr("lDahilDovizFiyati") / ((dr("nKdvOrani") + 100) / 100))
                    dr("lDovizFiyati") = dr("lDovizTutar") / lMiktar
                    dr("lDahilDovizTutar") = lMiktar * (dr("lDovizFiyati") * ((dr("nKdvOrani") + 100) / 100))
                    dr("lDahilDovizFiyati") = dr("lDahilDovizTutar") / lMiktar
                    If dr("lDovizKuru") <> 0 Then
                        dr("lBrutTutar") = (dr("lDahilDovizFiyati") * lMiktar) * dr("lDovizKuru")
                        dr("lBrutFiyat") = dr("lBrutTutar") / lMiktar
                        dr("lFiyat") = dr("lBrutFiyat") * dr("lBirimMiktar")
                    End If
                Else
                    dr("lDovizTutar") = lMiktar * dr("lDovizFiyati")
                    dr("lDahilDovizTutar") = lMiktar * (dr("lDovizFiyati") * ((dr("nKdvOrani") + 100) / 100))
                    dr("lDahilDovizFiyati") = dr("lDahilDovizTutar") / lMiktar
                    If dr("lDovizKuru") <> 0 Then
                        dr("lBrutTutar") = (dr("lDovizFiyati") * lMiktar) * dr("lDovizKuru")
                        dr("lBrutFiyat") = dr("lBrutTutar") / lMiktar
                        dr("lFiyat") = dr("lBrutFiyat") * dr("lBirimMiktar")
                    End If
                End If
            End If
            'If GridView1.FocusedColumn.Name.ToString = collBrutTutar.Name.ToString Then
            '    If dr_baslik("bListelendimi") = True Then
            '        dr("lBrutTutar") = (dr("lDahilBrutTutar") / ((dr("nKdvOrani") + 100) / 100))
            '        dr("lBrutFiyat") = dr("lBrutTutar") / lMiktar
            '        dr("lFiyat") = dr("lBrutFiyat") * dr("lBirimMiktar")
            '        dr("lDahilBrutFiyat") = dr("lDahilBrutTutar") / lMiktar
            '    Else
            '        dr("lBrutFiyat") = dr("lBrutTutar") / lMiktar
            '        dr("lFiyat") = dr("lBrutFiyat") * dr("lBirimMiktar")
            '        dr("lDahilBrutTutar") = lMiktar * (dr("lBrutFiyat") * ((dr("nKdvOrani") + 100) / 100))
            '        dr("lDahilBrutFiyat") = dr("lDahilBrutTutar") / lMiktar
            '    End If
            'ElseIf GridView1.FocusedColumn.Name.ToString = collBrutFiyat.Name.ToString Then
            '    If dr_baslik("bListelendimi") = True Then
            '        'MsgBox(dr("lDahilBrutFiyat"))
            '        dr("lBrutTutar") = lMiktar * (dr("lDahilBrutFiyat") / ((dr("nKdvOrani") + 100) / 100))
            '        dr("lBrutFiyat") = dr("lBrutTutar") / lMiktar
            '        dr("lFiyat") = dr("lBrutFiyat") * dr("lBirimMiktar")
            '        dr("lDahilBrutTutar") = lMiktar * (dr("lBrutFiyat") * ((dr("nKdvOrani") + 100) / 100))
            '        dr("lDahilBrutFiyat") = dr("lDahilBrutTutar") / lMiktar
            '        dr("lDahilFiyat") = dr("lDahilBrutFiyat") * dr("lBirimMiktar")
            '        'MsgBox(dr("lBrutFiyat"))
            '    Else
            '        dr("lBrutTutar") = lMiktar * dr("lBrutFiyat")
            '        dr("lFiyat") = dr("lBrutFiyat") * dr("lBirimMiktar")
            '        dr("lDahilBrutTutar") = lMiktar * (dr("lBrutFiyat") * ((dr("nKdvOrani") + 100) / 100))
            '        dr("lDahilBrutFiyat") = dr("lDahilBrutTutar") / lMiktar
            '        dr("lDahilFiyat") = dr("lDahilBrutFiyat") * dr("lBirimMiktar")
            '    End If
            'Else
            '    If dr_baslik("bListelendimi") = True Then
            '        dr("lBrutTutar") = lMiktar * (dr("lDahilBrutFiyat") / ((dr("nKdvOrani") + 100) / 100))
            '        dr("lBrutFiyat") = dr("lBrutTutar") / lMiktar
            '        dr("lFiyat") = dr("lBrutFiyat") * dr("lBirimMiktar")
            '        dr("lDahilBrutTutar") = lMiktar * (dr("lBrutFiyat") * ((dr("nKdvOrani") + 100) / 100))
            '        dr("lDahilBrutFiyat") = dr("lDahilBrutTutar") / lMiktar
            '        dr("lDahilFiyat") = dr("lDahilBrutFiyat") * dr("lBirimMiktar")
            '    Else
            '        dr("lBrutTutar") = lMiktar * dr("lBrutFiyat")
            '        dr("lFiyat") = dr("lBrutFiyat") * dr("lBirimMiktar")
            '        dr("lDahilBrutTutar") = lMiktar * (dr("lBrutFiyat") * ((dr("nKdvOrani") + 100) / 100))
            '        dr("lDahilBrutFiyat") = dr("lDahilBrutTutar") / lMiktar
            '        dr("lDahilFiyat") = dr("lDahilBrutFiyat") * dr("lBirimMiktar")
            '    End If
            'End If
            If GridView1.FocusedColumn.Name.ToString = collBrutTutar.Name.ToString Then
                If dr_baslik("bListelendimi") = True Then
                    dr("lBrutTutar") = (dr("lDahilBrutTutar") / ((dr("nKdvOrani") + 100) / 100))
                    dr("lBrutFiyat") = dr("lBrutTutar") / lMiktar
                    dr("lFiyat") = dr("lBrutFiyat") * dr("lBirimMiktar")
                    dr("lDahilBrutFiyat") = dr("lDahilBrutTutar") / lMiktar
                Else
                    dr("lBrutFiyat") = dr("lBrutTutar") / lMiktar
                    dr("lFiyat") = dr("lBrutFiyat") * dr("lBirimMiktar")
                    dr("lDahilBrutTutar") = lMiktar * (dr("lBrutFiyat") * ((dr("nKdvOrani") + 100) / 100))
                    dr("lDahilBrutFiyat") = dr("lDahilBrutTutar") / lMiktar
                End If
            ElseIf GridView1.FocusedColumn.Name.ToString = collBrutFiyat.Name.ToString Then
                If dr_baslik("bListelendimi") = True Then
                    dr("lBrutTutar") = lMiktar * (dr("lDahilBrutFiyat") / ((dr("nKdvOrani") + 100) / 100))
                    dr("lBrutFiyat") = dr("lBrutTutar") / lMiktar
                    dr("lFiyat") = dr("lBrutFiyat") * dr("lBirimMiktar")
                    dr("lDahilBrutTutar") = lMiktar * (dr("lBrutFiyat") * ((dr("nKdvOrani") + 100) / 100))
                    dr("lDahilBrutFiyat") = dr("lDahilBrutTutar") / lMiktar
                    dr("lDahilFiyat") = dr("lDahilBrutFiyat") * dr("lBirimMiktar")
                Else
                    dr("lBrutTutar") = lMiktar * dr("lBrutFiyat")
                    dr("lFiyat") = dr("lBrutFiyat") * dr("lBirimMiktar")
                    dr("lDahilBrutTutar") = lMiktar * (dr("lBrutFiyat") * ((dr("nKdvOrani") + 100) / 100))
                    dr("lDahilBrutFiyat") = dr("lDahilBrutTutar") / lMiktar
                    dr("lDahilFiyat") = dr("lDahilBrutFiyat") * dr("lBirimMiktar")
                End If
            Else
                If dr_baslik("bListelendimi") = True Then
                    dr("lBrutTutar") = lMiktar * (dr("lDahilBrutFiyat") / ((dr("nKdvOrani") + 100) / 100))
                    dr("lBrutFiyat") = dr("lBrutTutar") / lMiktar
                    dr("lFiyat") = dr("lBrutFiyat") * dr("lBirimMiktar")
                    dr("lDahilBrutTutar") = lMiktar * (dr("lBrutFiyat") * ((dr("nKdvOrani") + 100) / 100))
                    dr("lDahilBrutFiyat") = dr("lDahilBrutTutar") / lMiktar
                    dr("lDahilFiyat") = dr("lDahilBrutFiyat") * dr("lBirimMiktar")
                Else
                    dr("lBrutTutar") = lMiktar * dr("lBrutFiyat")
                    dr("lFiyat") = dr("lBrutFiyat") * dr("lBirimMiktar")
                    dr("lDahilBrutTutar") = lMiktar * (dr("lBrutFiyat") * ((dr("nKdvOrani") + 100) / 100))
                    dr("lDahilBrutFiyat") = dr("lDahilBrutTutar") / lMiktar
                    dr("lDahilFiyat") = dr("lDahilBrutFiyat") * dr("lBirimMiktar")
                End If
            End If
            dr("lBrutTutar") = lMiktar * dr("lBrutFiyat")
            dr("lDahilBrutFiyat") = (dr("lBrutFiyat") * ((dr("nKdvOrani") + 100) / 100))
            dr("lDahilFiyat") = dr("lDahilBrutFiyat") * dr("lBirimMiktar")
            dr("lDahilBrutTutar") = lMiktar * dr("lDahilBrutFiyat")
            'Doviz Hesapla
            If Trim(dr("sDovizCinsi").ToString) <> "" And dr("lDovizKuru") <> 0 Then
                dr("lDovizFiyati") = dr("lBrutFiyat") / dr("lDovizKuru")
                dr("lDovizTutar") = dr("lBrutTutar") / dr("lDovizKuru")
                dr("lDahilDovizFiyati") = dr("lDahilBrutFiyat") / dr("lDovizKuru")
                dr("lDahilDovizTutar") = dr("lDahilBrutTutar") / dr("lDovizKuru")
            Else
                dr("lDovizFiyati") = dr("lBrutFiyat")
                dr("lDahilDovizFiyati") = dr("lDahilBrutFiyat")
                dr("lDovizTutar") = dr("lBrutTutar")
                dr("lDahilDovizTutar") = dr("lDahilBrutTutar")
            End If
            lFiyat = dr("lBrutFiyat")
            lMiktar = dr("lMiktari")
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
            dr("sSatirAciklama") = "Isk1:" & uzunluk_tamamla(FormatNumber(dr("ISK1"), 2), 5) & " Isk2:" & uzunluk_tamamla(FormatNumber(dr("ISK2"), 2), 5) & " Isk3:" & uzunluk_tamamla(FormatNumber(dr("ISK3"), 2), 5) & " Isk4:" & uzunluk_tamamla(FormatNumber(dr("ISK4"), 2), 5)
            dr("lNetFiyat") = (lGercekFiyat * ((dr("nKdvOrani") + 100) / 100))
            dr("lTutari") = lGercekToplam
            dr("lIskontoTutari") = dr("lBrutTutar") - lGercekToplam
            dr("lKdvTutari") = lkdvtutar
            dr("sSiparisiAlan") = degeruzunlukkontrol(Trim(dr_baslik("sSiparisiAlan").ToString), 30)
            dr("sSiparisiAlan") += degeruzunlukkontrol(Trim(dr_baslik("sSiparisiVeren").ToString), 30)
            tbSiparis_kaydet_duzelt(dr("nSiparisID"), dr("nSiparisTipi"), dr("lSiparisNo"), dr("nFirmaID"), dr("nStokID"), dr("dteSiparisTarihi"), dr("dteTeslimTarihi"), dr("sSiparisIslem").ToString, dr("nReceteNo"), dr("sSiparisiAlan").ToString, dr("sSiparisiVeren").ToString, dr("sFiyatTipi").ToString, dr("lMiktari"), dr("lBrutFiyat"), dr("lTutari"), dr("sAsortiTipi").ToString, dr("sAsortiMiktari").ToString, dr("nKdvOrani"), dr("nIskontoYuzdesi"), dr("lBrutTutar"), kullaniciadi, Now, dr("bKapandimi"), dr("lReserveMiktari"), dr("sHangiUygulama").ToString, dr("nPartiID"), dr("sSatirAciklama").ToString, dr("nValorGun"), dr("sDovizCinsi").ToString, dr("lDovizFiyati"), dr("lDovizKuru"), dr("sSaticiRumuzu").ToString, dr("sDepo").ToString, dr("sBirimCinsi").ToString, dr("lBirimMiktar"), dr("sAmbalaj"))
            Dataload_tbFirma(dr("sFirmaKodu").ToString)
            Dataload_tbYekun(dr_baslik("dteSiparisTarihi"), dr_baslik("nSiparisTipi"), dr_baslik("lSiparisNo"), dr_baslik("nFirmaID"))
            dr = Nothing
            isk1 = Nothing
            isk2 = Nothing
            isk3 = Nothing
            isk4 = Nothing
            isk5 = Nothing
            isk6 = Nothing
            isk7 = Nothing
            isk8 = Nothing
            lMiktar = Nothing
            lFiyat = Nothing
            lGercekFiyat = Nothing
            lGercekToplam = Nothing
            lIsktutar = Nothing
            lkdvtutar = Nothing
            satir_firma_info()
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
    Private Sub degeryay(ByVal columnkriter As String)
        Dim durum
        Dim sayi = GridView1.RowCount
        Dim satir = GridView1.FocusedRowHandle
        Dim TOPLAM = sayi - GridView1.FocusedRowHandle
        Dim İ As Integer
        İ = 0
        Dim dr As DataRow
        dr = GridView1.GetDataRow(GridView1.FocusedRowHandle)
        durum = dr("" & columnkriter & "")
        For İ = 1 To TOPLAM
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
        İ = Nothing
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
    Private Sub analiz_envanter()
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
    End Sub
    Private Sub analiz_stok_karti()
        If GridView1.RowCount > 0 Then
            Dim dr As DataRow
            dr = GridView1.GetDataRow(GridView1.FocusedRowHandle)
            Dim frm As New frm_stok_kart
            frm.firmano = firmano
            frm.donemno = donemno
            frm.connection = connection
            frm.nStokID = dr("nStokId")
            frm.sKodu = dr("sKodu")
            frm.sModel = dr("sModel")
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
            frm.nFirmaID = dr("nFirmaID")
            frm.sec_firma.Checked = True
            frm.islemstatus = True
            If yetki_kontrol1(kullanici, "frm_stok_hareketleri_Sec") = False Then
                frm.sec_giris.Visible = False
                frm.sec_firma.Visible = False
                frm.sec_giris.Text = "Çıkışlar"
            Else
                frm.sec_giris.Visible = True
                frm.sec_firma.Visible = True
            End If
            If dr_baslik("nSiparisTipi") = 1 Or 3 Then
                frm.sec_giris.Text = "Çıkışlar"
            Else
                frm.sec_giris.Text = "Girişler"
            End If
            frm.kullanici = kullanici
            If yetki_kontrol(kullanici, frm.Name) = True Then
                If frm.ShowDialog(Me) = Windows.Forms.DialogResult.OK Then
                    Dim dr1 As DataRow = frm.GridView1.GetDataRow(frm.GridView1.FocusedRowHandle)
                    If dr_baslik("bListelendimi") = True Then
                        dr("lBrutFiyat") = (dr1("lBrut") * ((dr1("nKdvOrani") + 100) / 100))
                        dr("lFiyat") = dr("lBrutFiyat")
                    Else
                        dr("lBrutFiyat") = dr1("lBrut")
                        dr("lFiyat") = dr("lBrutFiyat")
                    End If
                    dr("ISK1") = dr1("ISK1")
                    dr("ISK2") = dr1("ISK2")
                    dr("ISK3") = dr1("ISK3")
                    dr("ISK4") = dr1("ISK4")
                    'dr("lMaliyetFiyat") = dr1("lMaliyetFiyat")
                    dr("nKdvOrani") = dr1("nKdvOrani")
                    'dr("sFiyatTipi") = dr1("sFiyatTipi")
                    dr1 = Nothing
                    tutar_hesapla()
                End If
            End If
            frm.Close()
            frm.Dispose()
            frm = Nothing
        End If
    End Sub
    Private Sub analiz_stok_Alternatif()
        If GridView1.RowCount > 0 Then
            Dim dr As DataRow
            dr = GridView1.GetDataRow(GridView1.FocusedRowHandle)
            Dim frm As New frm_stok
            frm.firmano = firmano
            frm.donemno = donemno
            frm.connection = connection
            frm.kullanici = kullanici
            frm.aktif = 1
            frm.alternatif = dr("sKodu")
            frm.qalternatif = "Eşittir"
            frm.status = True
            If yetki_kontrol(kullanici, "frm_Stok_Alternatif") = True Then
                frm.ShowDialog()
            End If
        End If
    End Sub
    Private Sub fis_sec()
        Dim frm As New frm_tbSiparis_liste
        frm.firmano = firmano
        frm.donemno = donemno
        frm.connection = connection
        frm.kullanici = kullanici
        frm.islemstatus = True
        frm.nSiparisTipi = dr_baslik("nSiparisTipi")
        If frm.ShowDialog(Me) = Windows.Forms.DialogResult.OK Then
            Dim dr1 As DataRow = frm.GridView1.GetDataRow(frm.GridView1.FocusedRowHandle)
            dteSiparisTarihi = dr1("dteSiparisTarihi")
            lSiparisNo = dr1("lSiparisNo")
            nFirmaID = dr1("nFirmaID")
            'txt_musteriNo.EditValue = dr1("sFirmaKodu")
            'txt_SiparisAlan.EditValue = dr1("sSiparisiAlan")
            'txt_SiparisVeren.EditValue = dr1("sSiparisiVeren")
            musteri_kontrol()
            dr1 = Nothing
            islemstatus = False
            loaded()
            'Dataload_tbSiparis(dr_baslik("dteSiparisTarihi"), dr_baslik("nSiparisTipi"), dr_baslik("lSiparisNo"), dr_baslik("nFirmaID"))
        End If
        frm.Close()
        frm.Dispose()
        frm = Nothing
    End Sub
    Private Sub fis_kopyala()
        Dim frm As New frm_fatura_kopyala
        frm.firmano = firmano
        frm.donemno = donemno
        frm.connection = connection
        frm.sFisTipi = nSiparisTipi
        If nSiparisTipi = 1 Then
            frm.nGirisCikis = 3
        ElseIf nSiparisTipi = 2 Then
            frm.nGirisCikis = 1
        End If
        frm.kapla = True
        frm.nFirmaID = dr_baslik("nFirmaID")
        frm.sKodu = dr_baslik("sKodu")
        frm.txt_musteriNo.EditValue = dr_baslik("sKodu")
        frm.lbl_Firma.Text = dr_baslik("sAciklama")
        frm.txt_dteFisTarihi1.EditValue = dr_baslik("dteSiparisTarihi")
        frm.bSiparis = True
        If frm.ShowDialog(Me) = Windows.Forms.DialogResult.OK Then
            If XtraMessageBox.Show(dr_baslik("lSiparisNo") & " Nolu Fişi " & frm.lbl_Firma.Text & Sorgu_sDil(" Hesabına Kopyalamaya Başlamak İstediğinize Emin misiniz...?", sDil), Sorgu_sDil("Dikkat", sDil), MessageBoxButtons.YesNo, MessageBoxIcon.Question) = MsgBoxResult.Yes Then
                Dim enSiparisTipi = nSiparisTipi
                Dim edteFisTarihi = dr_baslik("dteSiparisTarihi")
                Dim dteSiparisTarihi = dr_baslik("dteSiparisTarihi")
                Dim elSiparisNo = lSiparisNo
                Dim enFirmaID = nFirmaID
                nFirmaID = frm.nFirmaID
                lSiparisNo = sorgu_lSiparisNo()
                nSiparisTipi = frm.sec_sFisTipi.EditValue
                dteSiparisTarihi = frm.txt_dteFisTarihi1.EditValue
                Dim dr As DataRow
                For Each dr In ds_tbSiparis.Tables(0).Rows
                    Dim nSiparisID As Int64 = sorgu_nSiparisID()
                    'Bul
                    nSiparisID = tbSiparis_kaydet_yeni(nSiparisID, nSiparisTipi, lSiparisNo, nFirmaID, dr("nStokID"), dr("dteSiparisTarihi"), dr("dteTeslimTarihi"), dr("sSiparisIslem"), dr("nReceteNo"), dr("sSiparisiAlan"), dr("sSiparisiVeren"), dr("sFiyatTipi"), dr("lMiktari"), dr("lBrutFiyat"), dr("lTutari"), dr("sAsortiTipi"), dr("sAsortiMiktari"), dr("nKdvOrani"), dr("nIskontoYuzdesi"), dr("lBrutTutar"), kullaniciadi, Now, 0, dr("lReserveMiktari"), dr("sHangiUygulama"), dr("nPartiID"), dr("sSatirAciklama"), dr("nValorGun"), dr("sDovizCinsi"), dr("lDovizFiyati"), dr("lDovizKuru"), dr("sSaticiRumuzu"), dr("sDepo"), dr("sBirimCinsi"), dr("lBirimMiktar"), dr("sAmbalaj"))
                Next
                tbSiparis_Aciklamasi_kaydet_yeni(nSiparisTipi, lSiparisNo, nFirmaID, dr_baslik("sAciklama1").ToString, dr_baslik("sAciklama2").ToString, dr_baslik("sAciklama3").ToString, dr_baslik("sAciklama4").ToString, dr_baslik("sAciklama5").ToString, 0)
                dr = Nothing
                'Fişi Göster
                Dim fm As New frm_tbSiparis
                fm.firmano = firmano
                fm.donemno = donemno
                fm.connection = connection
                fm.dteSiparisTarihi = dteSiparisTarihi
                fm.lSiparisNo = lSiparisNo
                fm.nFirmaID = nFirmaID
                'frm.txt_musteriNo.EditValue = dr("sFirmaKodu")
                fm.sSiparisiAlan = ""
                fm.sSiparisiVeren = ""
                fm.nSiparisTipi = nSiparisTipi
                fm.kullanici = kullanici
                fm.islemstatus = True
                fm.Text = "Siparis#Kopya"
                If yetki_kontrol(kullanici, fm.Name) = True Then
                    fm.ShowDialog()
                End If
                fm.Close()
                fm.Dispose()
                fm = Nothing
                'Eski Tanımları Geri Getir
                nSiparisTipi = enSiparisTipi
                dteSiparisTarihi = edteFisTarihi
                lSiparisNo = elSiparisNo
                nFirmaID = enFirmaID
            End If
            frm.Close()
            frm = Nothing
        End If
    End Sub
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
            Dim dr1 As DataRow
            dr1 = frm.GridView1.GetDataRow(frm.GridView1.FocusedRowHandle)
            nFirmaID = dr1("nFirmaID")
            sKodu = dr1("sKodu")
            'lbl_Firma.Text = dr1("sAciklama")
            'txt_musteriNo.EditValue = sKodu
            musteri_kontrol()
            dr1 = Nothing
        End If
    End Sub
    Private Sub musteri_kontrol()
        'If Trim(txt_musteriNo.EditValue).ToString <> "" Then
        '    Dim kontrol = sorgu_cari_kontrol(txt_musteriNo.EditValue)
        '    If kontrol = 0 Then
        '        XtraMessageBox.Show(Sorgu_sDil("Kayıt Bulunumadı...",sDil),  MessageBoxIcon.Exclamation)
        '    ElseIf kontrol = 1 Then
        '        dataload_cari(txt_musteriNo.EditValue)
        '        Dim dr As DataRow
        '        For Each dr In ds_cari.Tables(0).Rows
        '            'txt_Musteri.EditValue = dr("MUSTERI")
        '            sKodu = dr("sKodu")
        '            nFirmaID = dr("nFirmaID")
        '            lbl_Firma.Text = dr("sAciklama")
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
    Private Sub analiz_Fis_Notu()
        If GridView1.RowCount > 0 Then
            Dim frm As New frm_musteri_karti_aciklama
            frm.firmano = firmano
            frm.donemno = donemno
            frm.connection = connection
            frm.kullanici = kullanici
            frm.tbSiparis = True
            frm.nSiparisTipi = dr_baslik("nSiparisTipi")
            frm.nFirmaID = nFirmaID
            frm.lSiparisNo = dr_baslik("lSiparisNo")
            frm.ShowDialog()
            frm.Close()
            frm.Dispose()
            frm = Nothing
        End If
    End Sub
    Public Function sorgu_stok_fiyat(ByVal fiyattipi As String, ByVal stokno As Int64) As Decimal
        Dim kriter
        kriter = "WHERE     (sFiyatTipi = '" & fiyattipi & "') AND (nStokID = " & stokno & ")"
        Dim conn As New OleDb.OleDbConnection
        Dim cmd As New OleDb.OleDbCommand
        Dim adapter As New OleDb.OleDbDataAdapter
        conn.ConnectionString = connection
        cmd.Connection = conn
        If conn.State = ConnectionState.Closed Then
            conn.Open()
        End If
        Dim lKur As Decimal = 1
        Dim sDovizCinsi As String = ""
        Dim sKur As String = "lAlisKuru"
        sDovizCinsi = sorgula_String("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED Select ISNULL(sDovizCinsi,'') from tbStok where nStokID = " & stokno & "")
        Dim dr As DataRow
        For Each dr In ds_FiyatTipi.Tables(0).Rows
            If Trim(dr("sFiyatTipi")) = Trim(fiyattipi) Then
                If Trim(dr("sDovizCinsi")) <> "" Then
                    sDovizCinsi = dr("sDovizCinsi")
                    If dr("sHangiKur") = "Alış" Then
                        sKur = "lAlisKuru"
                    ElseIf dr("sHangiKur") = "Satış" Then
                        sKur = "lSatisKuru"
                    ElseIf dr("sHangiKur") = "Efektif Alış" Then
                        sKur = "lEfektiAlisKuru"
                    ElseIf dr("sHangiKur") = "Efektif Satış" Then
                        sKur = "lEfektifSatisKuru"
                    ElseIf dr("sHangiKur") = "Merkez Bankası Alış" Then
                        sKur = "lMerkezBankasiAlisKuru"
                    ElseIf dr("sHangiKur") = "Merkez Bankası Satış" Then
                        sKur = "lMerkezBankasiSatisKuru"
                    Else
                        sKur = "lAlisKuru"
                    End If
                    lKur = sorgu_lDovizKuru(sDovizCinsi, sKur)
                End If
            End If
        Next
        If Trim(sDovizCinsi) <> "" Then
            lKur = sorgu_lDovizKuru(sDovizCinsi, sKur)
        End If
        cmd.CommandText = sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT     ISNULL(lFiyat * " & lKur & ", 0) AS FIYAT FROM         tbStokFiyati " & kriter & "")
        'cmd.CommandText = sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT     ISNULL(lFiyat, 0) AS FIYAT FROM         tbStokFiyati " & kriter & "")
        Dim kayitsayisi = cmd.ExecuteScalar
        Return kayitsayisi
        cmd = Nothing
        adapter = Nothing
    End Function
    Private Function sorgu_stok_info(ByVal stokkodu As String) As DataSet
        Dim con As New OleDb.OleDbConnection
        Dim adapter As New OleDb.OleDbDataAdapter
        Dim cmd As New OleDb.OleDbCommand
        con.ConnectionString = connection
        adapter.SelectCommand = cmd
        'cmd.CommandText = sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT CAST(ISNULL(SUM(hareket.lGirisMiktar1), 0) AS MONEY) AS  GIREN, CAST(ISNULL(SUM(hareket.lCikisMiktar1), 0) AS MONEY) AS CIKAN, CAST(ISNULL(SUM(hareket.lGirisMiktar1 - hareket.lCikisMiktar1), 0) AS MONEY) AS KALAN, stok.sKodu AS STOKKODU, stok.sAciklama AS STOKADI, stok.sRenk, stok.sBeden, stok.lAsgariMiktar, stok.lAzamiMiktar, stok.sModel, 0 AS BEKLEYEN, (SELECT sRenkAdi FROM tbRenk WHERE sRenk = Stok.sRenk) AS sRenkAdi FROM tbStok stok INNER JOIN tbStokFisiDetayi hareket ON stok.nStokID = hareket.nStokID WHERE (stok.sKodu = '" & stokkodu & "') AND (hareket.sFisTipi <> 'T') GROUP BY stok.nStokID, stok.sKodu, stok.sAciklama, stok.sRenk, stok.sBeden, stok.lAsgariMiktar, stok.lAzamiMiktar, stok.sModel")
        'cmd.CommandText = sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT CAST(ISNULL(SUM(hareket.lGirisMiktar1), 0) AS MONEY) AS GIREN, CAST(ISNULL(SUM(hareket.lCikisMiktar1), 0) AS MONEY) AS CIKAN, CAST(ISNULL(SUM(hareket.lGirisMiktar1 - hareket.lCikisMiktar1), 0) AS MONEY) AS KALAN, stok.sKodu AS STOKKODU, stok.sAciklama AS STOKADI, stok.sRenk, stok.sBeden, stok.lAsgariMiktar, stok.lAzamiMiktar, stok.sModel, 0 AS BEKLEYEN, (SELECT sRenkAdi FROM tbRenk WHERE sRenk = Stok.sRenk) AS sRenkAdi, CAST(Verilen.lVerilen AS MONEY) as lVerilen, CAST(Alinan.lAlinan AS MONEY) AS lAlinan FROM tbStok stok INNER JOIN tbStokFisiDetayi hareket ON stok.nStokID = hareket.nStokID LEFT OUTER JOIN (SELECT nStokID , ISNULL(LSiparis - lSevkiyat , 0) AS lAlinan FROM (SELECT tbStok.nStokID , tbStok.sModel , tbStok.sKodu , tbStok.sAciklama , SUM(tbSiparis.lMiktari) AS lSiparis , ISNULL(SUM(tbStokFisiDetayi.lCikisMiktar1) , 0) AS lSevkiyat FROM tbFirma INNER JOIN tbSiparis ON tbFirma.nFirmaID = tbSiparis.nFirmaID INNER JOIN tbStok ON tbSiparis.nStokID = tbStok.nStokID LEFT OUTER JOIN tbStokFisiDetayi WITH (INDEX (tbStokFisiDetayi_index12)) ON tbStokFisiDetayi.nSiparisID = tbSiparis.nSiparisID WHERE (tbSiparis.bKapandimi = 0) AND (tbSiparis.lSiparisNo BETWEEN 1 AND 999999999) AND (tbSiparis.dteSiparisTarihi BETWEEN '01/01/1900' AND '31/12/2078') AND (SUBSTRING(tbSiparis.sSiparisiAlan , 1 , 30) BETWEEN '' AND 'zzzzzzzzzzzzzzzzzzzz') AND (SUBSTRING(tbSiparis.sSiparisiAlan , 31 , 30) BETWEEN '' AND 'zzzzzzzzzzzzzzzzzzzz') AND (tbSiparis.nSiparisTipi = 1) and tbStok.sKodu ='" & stokkodu & "' GROUP BY tbStok.nStokID , tbStok.sAciklama , tbStok.sModel , tbStok.sKodu) tSiparis WHERE (ISNULL(lSiparis , 0) - ISNULL(lSevkiyat , 0) <> 0)) Alinan ON stok.nStokID = Alinan.nStokID LEFT OUTER JOIN (SELECT nStokID , ISNULL(LSiparis - lSevkiyat , 0) AS lVerilen FROM (SELECT tbStok.nStokID , tbStok.sModel , tbStok.sKodu , tbStok.sAciklama , SUM(tbSiparis.lMiktari) AS lSiparis , ISNULL(SUM(tbStokFisiDetayi.lCikisMiktar1) , 0) AS lSevkiyat FROM tbFirma INNER JOIN tbSiparis ON tbFirma.nFirmaID = tbSiparis.nFirmaID INNER JOIN tbStok ON tbSiparis.nStokID = tbStok.nStokID LEFT OUTER JOIN tbStokFisiDetayi WITH (INDEX (tbStokFisiDetayi_index12)) ON tbStokFisiDetayi.nSiparisID = tbSiparis.nSiparisID WHERE (tbSiparis.bKapandimi = 0) AND (tbSiparis.lSiparisNo BETWEEN 1 AND 999999999) AND (tbSiparis.dteSiparisTarihi BETWEEN '01/01/1900' AND '31/12/2078') AND (SUBSTRING(tbSiparis.sSiparisiAlan , 1 , 30) BETWEEN '' AND 'zzzzzzzzzzzzzzzzzzzz') AND (SUBSTRING(tbSiparis.sSiparisiAlan , 31 , 30) BETWEEN '' AND 'zzzzzzzzzzzzzzzzzzzz') AND (tbSiparis.nSiparisTipi = 2) and tbStok.sKodu = '" & stokkodu & "' GROUP BY tbStok.nStokID , tbStok.sAciklama , tbStok.sModel , tbStok.sKodu) tSiparis WHERE (ISNULL(lSiparis , 0) - ISNULL(lSevkiyat , 0) <> 0)) Verilen ON stok.nStokID = Verilen.nStokID WHERE (stok.sKodu = '" & stokkodu & "') AND (hareket.sFisTipi <> 'T') GROUP BY stok.nStokID, stok.sKodu, stok.sAciklama, stok.sRenk, stok.sBeden, stok.lAsgariMiktar, stok.lAzamiMiktar, stok.sModel, Verilen.lVerilen, Alinan.lAlinan")
        cmd.CommandText = sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT CAST(ISNULL(SUM(hareket.lGirisMiktar1), 0) AS MONEY) AS  GIREN, CAST(ISNULL(SUM(hareket.lCikisMiktar1), 0) AS MONEY) AS CIKAN, CAST(ISNULL(SUM(hareket.lGirisMiktar1 - hareket.lCikisMiktar1), 0) AS MONEY) AS KALAN, (SELECT SUM(tbSiparis.lMiktari - tbSevkiyat.lSevkMiktari) AS AlinanSiparis FROM tbStok INNER JOIN tbSiparis ON tbStok.nStokID = tbSiparis.nStokID LEFT OUTER JOIN (SELECT SUM(lCikisMiktar1) AS lSevkMiktari , nSiparisID FROM tbStokFisiDetayi WHERE (nSiparisID IS NOT NULL) GROUP BY nSiparisID) tbSevkiyat ON tbSiparis.nSiparisID = tbSevkiyat.nSiparisID WHERE (tbSiparis.nSiparisTipi = 1) AND (tbSiparis.bKapandimi = 0) and (tbSiparis.nStokID = Stok.nStokID)) AS AlinanSiparis,(SELECT SUM(tbSiparis.lMiktari - tbSevkiyat.lSevkMiktari) AS VS FROM tbStok INNER JOIN tbSiparis ON tbStok.nStokID = tbSiparis.nStokID LEFT OUTER JOIN (SELECT SUM(lGirisMiktar1) AS lSevkMiktari , nSiparisID FROM tbStokFisiDetayi WHERE (nSiparisID IS NOT NULL) GROUP BY nSiparisID) tbSevkiyat ON tbSiparis.nSiparisID = tbSevkiyat.nSiparisID WHERE (tbSiparis.nSiparisTipi = 2) AND (tbSiparis.bKapandimi = 0) and (tbSiparis.nStokID = Stok.nStokID)) AS VerilenSiparis,stok.sKodu AS STOKKODU, stok.sAciklama AS STOKADI, stok.sRenk, stok.sBeden, stok.lAsgariMiktar, stok.lAzamiMiktar, stok.sModel, 0 AS BEKLEYEN, (SELECT sRenkAdi FROM tbRenk WHERE sRenk = Stok.sRenk) AS sRenkAdi,Stok.bEksiyeDusulebilirmi, Stok.bEksideUyarsinmi,ISNULL((SELECT isnull(lfiyat , 0) FROM tbstokfiyati WHERE nStokId = Stok.NstokId AND sFiyatTipi = '" & sAltFiyatTipi & "'),0) AS lAlis FROM tbStok stok INNER JOIN tbStokFisiDetayi hareket ON stok.nStokID = hareket.nStokID WHERE (stok.sKodu = '" & stokkodu & "') AND (hareket.sFisTipi <> 'T') GROUP BY stok.nStokID, stok.sKodu, stok.sAciklama, stok.sRenk, stok.sBeden, stok.lAsgariMiktar, stok.lAzamiMiktar, stok.sModel,bEksiyeDusulebilirmi, bEksideUyarsinmi")
        cmd.Connection = con
        con.Open()
        Dim DS As New DataSet
        Dim N As Integer = adapter.Fill(DS, "BASLIK")
        con.Close()
        Return DS
    End Function
    Private Sub raporla(ByVal nIslem As Integer)
        Dim OpenFileDialog1 As New Windows.Forms.OpenFileDialog
        OpenFileDialog1.Title = "Rapor Seç..."
        OpenFileDialog1.Filter = "Rapor Dosyaları (Form*.fr*) |Form*.fr*"
        OpenFileDialog1.FileName = "c:\Formlar\Raporlar\Siparis\Form" & sRaporUzanti & ""
        OpenFileDialog1.InitialDirectory = "c:\Formlar\Raporlar\Siparis"
        If OpenFileDialog1.ShowDialog = Windows.Forms.DialogResult.OK Then
            Dim sFile = OpenFileDialog1.FileName.ToString
            If Microsoft.VisualBasic.Right(sFile, 3) = "fr3" Then
                Dim kriter = " WHERE (tbSiparis.lSiparisNo = " & dr_baslik("lSiparisNo") & ") AND (tbSiparis.nSiparisTipi = " & dr_baslik("nSiparisTipi") & ") AND (tbSiparis.nFirmaID = " & dr_baslik("nFirmaID") & ") AND (tbSiparis.dteSiparisTarihi = '" & dr_baslik("dteSiparisTarihi") & "') "
                report_create_stok(sFile, kriter, nIslem)
            Else
                report_create(sFile, "", nIslem)
            End If
        End If
    End Sub
    Private Sub raporla1(ByVal rapor As Integer, ByVal islem As Integer, ByVal dteSiparisTarihi As DateTime, ByVal nSiparisTipi As Integer, ByVal lSiparisNo As Int64, ByVal nFirmaID As Int64)
        Dim file As String = ""
        Dim kriter As String
        Dim dr As DataRow
        dr = GridView1.GetDataRow(GridView1.FocusedRowHandle)
        kriter = " WHERE (tbSiparis.lSiparisNo = " & lSiparisNo & ") AND (tbSiparis.nSiparisTipi = " & nSiparisTipi & ") AND (tbSiparis.nFirmaID = " & nFirmaID & ") AND (tbSiparis.dteSiparisTarihi = '" & dteSiparisTarihi & "') "
        OpenFileDialog1.Title = "Rapor Seç..."
        OpenFileDialog1.Filter = "Rapor Dosyaları (Form*.fr3) |Form*.fr3"
        OpenFileDialog1.FileName = "c:\Formlar\Raporlar\Siparis\Form.fr3"
        OpenFileDialog1.InitialDirectory = "c:\Formlar\Raporlar\Siparis"
        If OpenFileDialog1.ShowDialog = Windows.Forms.DialogResult.OK Then
            file = OpenFileDialog1.FileName.ToString
            report_create_stok(file, kriter, islem)
        End If
        file = Nothing
        kriter = Nothing
        dr = Nothing
    End Sub
    Private Sub report_create(ByVal sFile As String, ByVal kriter As String, ByVal nIslem As Integer)
        Dim report As New FastReport.Report
        report.Load(sFile)
        report.RegisterData(ds_baslik)
        Dim dsHareket As DataSet = sorgu_siparis(dr_baslik("dteSiparisTarihi"), dr_baslik("nSiparisTipi"), dr_baslik("lSiparisNo"), dr_baslik("nFirmaID"))
        Dim dsStokFisiAdres As DataSet = sorgu_tbStokFisiPesinAdres(dr_baslik("nSiparisTipi"), dr_baslik("lSiparisNo"))
        report.RegisterData(dsHareket)
        report.RegisterData(ds_tbSiparisToplam)
        report.RegisterData(ds_tbParamGenel)
        report.RegisterData(dsStokFisiAdres)
        If nSiparisTipi = 1 Then
            report.SetParameterValue("FisTipi", "Alınan Sipariş")
        ElseIf nSiparisTipi = 2 Then
            report.SetParameterValue("FisTipi", "Verilen Sipariş")
        ElseIf nSiparisTipi = 3 Then
            report.SetParameterValue("FisTipi", "SatınAlma Siparişi")
        End If
        'dr_baslik("dteSiparisTarihi"), dr_baslik("nSiparisTipi"), dr_baslik("lSiparisNo"), dr_baslik("nFirmaID"))
        report.SetParameterValue("dteSiparisTarihi", dr_baslik("dteSiparisTarihi"))
        report.SetParameterValue("lSiparisNo", dr_baslik("lSiparisNo"))
        report.SetParameterValue("nSiparisTipi", dr_baslik("nSiparisTipi"))
        report.ScriptLanguage = Language.Vb
        If nIslem = 0 Then
            report.Show()
        ElseIf nIslem = 1 Then
            report.Design()
        ElseIf nIslem = 2 Then
            'report.Prepare()
            report.Print()
        End If
        report.Dispose()
        report = Nothing
    End Sub
    Private Sub report_create_stok(ByVal dosya As String, ByVal kriter As String, ByVal status As Integer)
        Dim stokno = 0
        Dim satir_line = "100"
        If IntPtr.Size = 4 Then
            '32 Bit
            Dim frx As New TfrxReportClass
            Dim ds1 As New TfrxUserDataSetClass
            Dim qr_hareket As New TfrxADOQuery
            Dim qr_baslik As New TfrxADOQuery
            Dim qr_toplam As New TfrxADOQuery
            Dim qr_firma As New TfrxADOQuery
            Dim qr_adres As New TfrxADOQuery
            frx.Resources.LoadLanguageResourcesFromFile("C:\Program Files\FastReports\FastReport Studio\bin\turkish.frc")
            frx.LoadReportFromFile(dosya)
            frx.SetVariable("FIRMANO", "" & firmano & "")
            frx.SetVariable("DONEMNO", "" & donemno & "")
            frx.SetVariable("STOKNO", "" & stokno & "")
            frx.SetVariable("SATIRLINE", "'" & satir_line & "'")
            dr_toplam = ds_tbSiparisToplam.Tables(0).Rows(0)
            frx.SetVariable("yaziGenelToplam", "'" & ygeneltoplam(dr_toplam("lNetTutar")) & "'")
            'If sMuhFisTipi = 1 Then
            '    frx.SetVariable("IZAHAT", "'Tahsilat Fişi'")
            'ElseIf sMuhFisTipi = 2 Then
            '    frx.SetVariable("IZAHAT", "'Tediye Fişi'")
            'ElseIf sMuhFisTipi = 3 Then
            '    frx.SetVariable("IZAHAT", "'Mahsup Fişi'")
            'End If
            qr_baslik = frx.FindObject("qr_baslik")
            qr_baslik.Query = sorgu_txt_baslik
            qr_hareket = frx.FindObject("qr_hareket")
            qr_hareket.Query = sorgu_txt_hareket
            qr_toplam = frx.FindObject("qr_toplam")
            qr_toplam.Query = sorgu_txt_toplam
            qr_firma = frx.FindObject("qr_firma")
            qr_firma.Query = sorgu_txt_hareket
            qr_adres = frx.FindObject("qr_adres")
            qr_adres.Query = sorgu_txt_adres
            Dim qr_connection As New TfrxADODatabase
            qr_connection.ConnectionString = connection.ToString
            qr_connection.LoginPrompt = False
            qr_connection.CommandTimeout = Nothing
            qr_connection.Connected = True
            qr_baslik.DataBase = qr_connection
            qr_hareket.DataBase = qr_connection
            qr_toplam.DataBase = qr_connection
            qr_firma.DataBase = qr_connection
            Try
                qr_adres.DataBase = qr_connection
            Catch ex As Exception
            End Try
            If status = 0 Then
                'frx.PrepareReport(True)
                frx.PreviewOptions.ZoomMode = frxZoomMode.zm_PageWidth
                frx.OldStyleProgress = True
                frx.ShowReport()
            ElseIf status = 2 Then
                frx.PrepareReport(True)
                frx.PrintOptions.Collate = False
                frx.PrintOptions.Copies = 1
                frx.PrintReport()
            ElseIf status = 1 Then
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
            args(2) = ""
            args(3) = ""
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
            args(14) = "yaziGenelToplam"
            args(15) = "'" & ygeneltoplam(dr_toplam("lNetTutar")) & "'"
            dr_toplam = ds_tbSiparisToplam.Tables(0).Rows(0)
            args(2) = "" & sorgu_txt_baslik & "é" & sorgu_txt_hareket & "é" & sorgu_txt_toplam & "é" & sorgu_txt_hareket & "é" & sorgu_txt_adres & ""
            args(3) = "qr_baslikéqr_hareketéqr_toplaméqr_firmaéqr_adres"
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
                MessageBox.Show("Raporlama İşlemi İçin LOG Oluşturulumadı!")
            End Try
            If File.Exists(Directory.GetCurrentDirectory() & "\RaporServis.exe") = True Then
                Dim sInfo As New ProcessStartInfo(Directory.GetCurrentDirectory() & "\RaporServis.exe ", """" & yeniYol & """")
                Process.Start(sInfo)
            Else
                MessageBox.Show("Lütfen 'RaporServis.exe' eklentisini uygulama dizinine kopyalayın.")
            End If
        End If
        stokno = Nothing
        satir_line = Nothing
    End Sub
    Private Sub GörünümüDüzenleToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        GridView1.ColumnsCustomization()
    End Sub
    Private Sub GörünümüKaydetToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        gorunum_kaydet()
    End Sub
    Private Sub GörünümüYazdırToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
    End Sub
    Private Sub gorunum_yazdir()
        Dim kriter As String = ""
        kriter += Microsoft.VisualBasic.Left(dr_baslik("dteSiparisTarihi"), 10) & " Tarihindeki  " & vbCrLf
        kriter += " FisNo = " & dr_baslik("lSiparisNo") & " Nolu Siparis Siparisi Veren: " & dr_baslik("sAciklama") & " "
        Me.Printlink1.PageHeaderFooter = New DevExpress.XtraPrinting.PageHeaderFooter(New DevExpress.XtraPrinting.PageHeaderArea(New String() {"[User Name]", kriter, "[Date Printed][Time Printed]"}, New Font("Microsoft Sans Serif", 8.25!, FontStyle.Regular, GraphicsUnit.Point, CType(162, Byte)), DevExpress.XtraPrinting.BrickAlignment.Center), New DevExpress.XtraPrinting.PageFooterArea(New String() {"Powered by www.barkodyazilimevi.com", "Siparis Yonetimi", "[Page # of Pages #]"}, New Font("Microsoft Sans Serif", 8.25!, FontStyle.Regular, GraphicsUnit.Point, CType(162, Byte)), DevExpress.XtraPrinting.BrickAlignment.Near))
        Printlink1.CreateDocument(ps)
        ps.PreviewRibbonFormEx.Show()
    End Sub
    Private Sub HızlıFiltreToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles HızlıFiltreToolStripMenuItem.Click
        If HızlıFiltreToolStripMenuItem.Checked = False Then
            GridView1.OptionsCustomization.AllowFilter = True
            GridView1.OptionsView.ShowFilterPanelMode = DevExpress.XtraGrid.Views.Base.ShowFilterPanelMode.Default
            GridView1.OptionsView.ShowAutoFilterRow = True
            HızlıFiltreToolStripMenuItem.Checked = True
        ElseIf HızlıFiltreToolStripMenuItem.Checked = True Then
            GridView1.OptionsCustomization.AllowFilter = False
            GridView1.OptionsView.ShowFilterPanelMode = DevExpress.XtraGrid.Views.Base.ShowFilterPanelMode.Never
            GridView1.OptionsView.ShowAutoFilterRow = False
            HızlıFiltreToolStripMenuItem.Checked = False
        End If
    End Sub
    Private Sub MenuItem8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        GridView1.ExpandAllGroups()
    End Sub
    Private Sub MenuItem9_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
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
            
            ' AUDIT LOG: Sipariş satırı güncellendi
            Try
                Dim siparisID As Long = 0
                Dim sipNo As String = ""
                If dr IsNot Nothing Then
                    If Not IsDBNull(dr("nSiparisID")) Then siparisID = CLng(dr("nSiparisID"))
                    If Not IsDBNull(dr("lSiparisNo")) Then sipNo = dr("lSiparisNo").ToString()
                End If
                Dim kolonAdi As String = e.Column.FieldName
                
                ' DÜZELTME: DevExpress'te e.Value YENİ değerdir!
                ' Eski değeri almak için DataRow'un orijinal değerine bakmalıyız
                Dim eskiDeger As String = ""
                Dim yeniDeger As String = ""
                
                Try
                    ' DataRow.Item(kolonAdi, DataRowVersion.Original) eski değeri verir
                    If dr.HasVersion(DataRowVersion.Original) Then
                        Dim eskiVal = dr(kolonAdi, DataRowVersion.Original)
                        eskiDeger = If(eskiVal IsNot Nothing AndAlso Not IsDBNull(eskiVal), eskiVal.ToString(), "")
                    End If
                Catch
                    ' Orijinal versiyon yoksa boş bırak
                End Try
                
                ' Yeni değer - DataRow'daki güncel değer
                yeniDeger = If(dr(kolonAdi) IsNot Nothing AndAlso Not IsDBNull(dr(kolonAdi)), dr(kolonAdi).ToString(), "")
                
                ' Sadece gerçekten değiştiyse log yaz
                If eskiDeger <> yeniDeger Then
                    LogSiparis("GUNCELLE", siparisID, sipNo, "Alan güncellendi: " & kolonAdi, eskiDeger, yeniDeger)
                End If
            Catch ex As Exception
                Debug.WriteLine("Audit log hatası: " & ex.Message)
            End Try
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
            status = True
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
            Label2.Text = Sorgu_sDil("Kayıt Sayısı :", sDil) & GridView1.RowCount & " / " & Sorgu_sDil("Satır :", sDil) & GridView1.FocusedRowHandle + 1 & " / " & Sorgu_sDil("Seçili :", sDil) & GridView1.SelectedRowsCount
        ElseIf GridView1.SelectedRowsCount = 1 Then
            Label2.Text = Sorgu_sDil("Kayıt Sayısı :", sDil) & GridView1.RowCount & " / " & Sorgu_sDil("Satır :", sDil) & GridView1.FocusedRowHandle + 1
        Else
            Label2.Text = ""
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
    Private Sub FirmaKartıToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FirmaKartıToolStripMenuItem.Click
        analiz_Firma_karti()
    End Sub
    Private Sub ÖnizleToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ÖnizleToolStripMenuItem.Click
        'raporla(0, 0, dr_baslik("dteSiparisTarihi"), dr_baslik("nSiparisTipi"), dr_baslik("lSiparisNo"), dr_baslik("nFirmaID"))
        raporla(0)
    End Sub
    Private Sub DizaynToolStripMenuItem_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles DizaynToolStripMenuItem.Click
        'raporla(0, 2, dr_baslik("dteSiparisTarihi"), dr_baslik("nSiparisTipi"), dr_baslik("lSiparisNo"), dr_baslik("nFirmaID"))
        raporla(1)
    End Sub
    Private Sub YazdırToolStripMenuItem_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles YazdırToolStripMenuItem.Click
        'raporla(0, 1, dr_baslik("dteSiparisTarihi"), dr_baslik("nSiparisTipi"), dr_baslik("lSiparisNo"), dr_baslik("nFirmaID"))
        raporla(2)
    End Sub
    Private Sub GridControl1_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles GridControl1.KeyDown
        If e.KeyCode = Keys.Escape Then
            If XtraMessageBox.Show(Sorgu_sDil("Sipariş Fişi Ekranından Çıkmak İstediğinize Emin misiniz...?", sDil), Sorgu_sDil("Dikkat", sDil), MessageBoxButtons.YesNo, MessageBoxIcon.Question) = MsgBoxResult.Yes Then
                Me.Close()
            End If
        End If
    End Sub
    Private Sub FisSecToolStripMenuItem_Click(ByVal sender As Object, ByVal e As System.EventArgs)
        fis_sec()
    End Sub
    Private Sub FisNotuToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FisNotuToolStripMenuItem.Click
        analiz_Fis_Notu()
    End Sub
    Private Sub ToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        fis_sil()
    End Sub
    Private Sub txt_musteriNo_ButtonClick(ByVal sender As Object, ByVal e As DevExpress.XtraEditors.Controls.ButtonPressedEventArgs)
        firma_sec()
    End Sub
    Private Sub txt_musteriNo_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs)
        If e.KeyCode = Keys.Space Then
            firma_sec()
        End If
    End Sub
    Private Sub txt_musteriNo_Validated(ByVal sender As Object, ByVal e As System.EventArgs)
        musteri_kontrol()
    End Sub
    Private Sub sec_sFiyatTipi_EditValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles sec_sFiyatTipi.EditValueChanged
        If GridView1.RowCount > 0 Then
            GridView1.PostEditor()
            Dim dr As DataRow
            dr = GridView1.GetDataRow(GridView1.FocusedRowHandle)
            Dim lFiyati = sorgu_stok_fiyat(dr("sFiyatTipi"), dr("nStokID"))
            If bFiyatKdvHaric = False Then
                lFiyati = lFiyati / ((100 + dr("nKdvOrani")) / 100)
            Else
                lFiyati = sorgu_sayi(lFiyati, 0)
            End If
            If lFiyati <> 0 Then
                dr("lFiyat") = lFiyati * dr("lBirimMiktar")
                dr("lFiyati") = lFiyati
                Dim lMiktar As Decimal = dr("lMiktari")
                dr("lBrutTutar") = lMiktar * dr("lBrutFiyat")
                tutar_hesapla()
                dr.EndEdit()
            End If
        End If
    End Sub
    Private Sub StokKartiToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        analiz_stok_karti()
    End Sub
    Private Sub StokEnvanterToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        analiz_envanter()
    End Sub
    Private Sub StokHareketleriToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        analiz_stok_hareket()
    End Sub
    Private Sub BarButtonItem1_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem1.ItemClick
        'raporla(0, 0, dr_baslik("dteSiparisTarihi"), dr_baslik("nSiparisTipi"), dr_baslik("lSiparisNo"), dr_baslik("nFirmaID"))
        raporla(0)
    End Sub
    Private Sub BarButtonItem2_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem2.ItemClick
        'raporla(0, 2, dr_baslik("dteSiparisTarihi"), dr_baslik("nSiparisTipi"), dr_baslik("lSiparisNo"), dr_baslik("nFirmaID"))
        raporla(1)
    End Sub
    Private Sub BarButtonItem3_ItemClick(ByVal sender As Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem3.ItemClick
        yazdir()
    End Sub
    Private Sub yazdir()
        'raporla(0, 1, dr_baslik("dteSiparisTarihi"), dr_baslik("nSiparisTipi"), dr_baslik("lSiparisNo"), dr_baslik("nFirmaID"))
        raporla(2)
    End Sub
    Private Sub BarButtonItem4_ItemClick(ByVal sender As Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btn_FisSil.ItemClick
        fis_sil()
    End Sub
    Private Sub BarButtonItem5_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btn_SatirEkle.ItemClick
        satir_ekle()
    End Sub
    Private Sub btn_SatirArayaEkle_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btn_SatirArayaEkle.ItemClick
        satir_araya_ekle()
    End Sub
    Private Sub BarButtonItem7_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btn_SatirSil.ItemClick
        satir_sil()
    End Sub
    Private Sub BarButtonItem8_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btn_DegerYay.ItemClick
        degerleri_yay()
    End Sub
    Private Sub degerleri_yay()
        If GridView1.RowCount > 0 Then
            If XtraMessageBox.Show(Sorgu_sDil("[" & GridView1.FocusedColumn().Caption & "] Kolonundaki verileri Aşağı Doğru Yaymak istediğinize Emin misiniz...?", sDil), Sorgu_sDil("Dikkat", sDil), MessageBoxButtons.YesNo, MessageBoxIcon.Question) = MsgBoxResult.Yes Then
                info = False
                Cursor.Current = Cursors.WaitCursor
                Cursor.Show()
                degeryay(GridView1.FocusedColumn().FieldName)
                Cursor.Current = Cursors.Default
                Cursor.Hide()
                info = True
                'toplam_hesapla()
            End If
        End If
    End Sub
    Private Sub BarButtonItem9_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem9.ItemClick
        If BarButtonItem9.Down = False Then
            GridView1.OptionsCustomization.AllowFilter = True
            GridView1.OptionsView.ShowFilterPanelMode = DevExpress.XtraGrid.Views.Base.ShowFilterPanelMode.Default
            GridView1.OptionsView.ShowAutoFilterRow = True
            BarButtonItem9.Down = True
        ElseIf BarButtonItem9.Down = True Then
            GridView1.OptionsCustomization.AllowFilter = False
            GridView1.OptionsView.ShowFilterPanelMode = DevExpress.XtraGrid.Views.Base.ShowFilterPanelMode.Never
            GridView1.OptionsView.ShowAutoFilterRow = False
            BarButtonItem9.Down = False
        End If
    End Sub
    Private Sub BarButtonItem10_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btn_FiyatTipiBelirle.ItemClick
        sFiyatTipi_toplu()
    End Sub
    Private Sub BarButtonItem17_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem17.ItemClick
        stok_fiyat()
    End Sub
    Private Sub BarButtonItem18_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem18.ItemClick
        stok_yeni()
    End Sub
    Private Sub BarButtonItem19_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem19.ItemClick
        analiz_stok_karti()
    End Sub
    Private Sub BarButtonItem20_ItemClick(ByVal sender As Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem20.ItemClick
        analiz_Firma_karti()
    End Sub
    Private Sub BarButtonItem21_ItemClick(ByVal sender As Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem21.ItemClick
        analiz_envanter()
    End Sub
    Private Sub BarButtonItem22_ItemClick(ByVal sender As Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem22.ItemClick
        analiz_stok_hareket()
    End Sub
    Private Sub BarButtonItem23_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem23.ItemClick
        If Me.WindowState = FormWindowState.Normal Then
            Me.WindowState = FormWindowState.Maximized
        ElseIf Me.WindowState = FormWindowState.Maximized Then
            Me.WindowState = FormWindowState.Normal
        End If
    End Sub
    Private Sub VGrid_baslik_CellValueChanged(ByVal sender As Object, ByVal e As DevExpress.XtraVerticalGrid.Events.CellValueChangedEventArgs) Handles VGrid_baslik.CellValueChanged
        baslik_degistir()
    End Sub
    Private Sub baslik_degistir()
        Try
            'Vgrid_baslik.PostEditor()
            VGrid_baslik.UpdateFocusedRecord()
            VGrid_baslik.CloseEditor()
            tbSiparis_baslik_kaydet_duzelt(dr_baslik("nFirmaID"), dr_baslik("nSiparisTipi"), dr_baslik("lSiparisNo"), dr_baslik("dteSiparisTarihi"), dr_baslik("sSiparisiAlan"), dr_baslik("sSiparisiVeren"), nSiparisTipi, lSiparisNo, dteSiparisTarihi)
            tbSiparis_Aciklamasi_kaydet_yeni(dr_baslik("nSiparisTipi"), dr_baslik("lSiparisNo"), dr_baslik("nFirmaID"), dr_baslik("sAciklama1").ToString, dr_baslik("sAciklama2").ToString, dr_baslik("sAciklama3").ToString, dr_baslik("sAciklama4").ToString, dr_baslik("sAciklama5").ToString, dr_baslik("bKilitli"))
            tbSiparis_Aciklamasi_kaydet_duzelt(dr_baslik("nSiparisTipi"), dr_baslik("lSiparisNo"), dr_baslik("nFirmaID"), dr_baslik("sAciklama1").ToString, dr_baslik("sAciklama2").ToString, dr_baslik("sAciklama3").ToString, dr_baslik("sAciklama4").ToString, dr_baslik("sAciklama5").ToString, dr_baslik("bKilitli"), dr_baslik("bListelendimi"))
            dteSiparisTarihi = dr_baslik("dteSiparisTarihi")
            lSiparisNo = dr_baslik("lSiparisNo")
            Dim satir = GridView1.FocusedRowHandle
            Dataload_tbSiparis(dr_baslik("dteSiparisTarihi"), dr_baslik("nSiparisTipi"), dr_baslik("lSiparisNo"), dr_baslik("nFirmaID"))
            GridView1.FocusedRowHandle = satir
            satir = Nothing
        Catch ex As Exception
            XtraMessageBox.Show(Sorgu_sDil("İşlem Hatası Lütfen Bilgileri Kontrol Edip Tekrar Deneyiniz...!", sDil), Sorgu_sDil("Dikkat", sDil), MessageBoxButtons.OK, MessageBoxIcon.Information)
        End Try
    End Sub
    Public Function degeruzunlukkontrol(ByVal deger As String, ByVal uzunluk As String) As String
        Dim degeruzunluk As Integer = uzunluk
        Dim muzunluk = Len(deger)
        If Len(deger) < uzunluk Then
            Dim degerfark As Integer = degeruzunluk - muzunluk
            Dim i As Integer
            For i = 1 To degerfark
                deger = deger.Insert(muzunluk, " ")
            Next
        Else
            deger = Microsoft.VisualBasic.Left(deger, uzunluk)
        End If
        Return deger
    End Function
    Private Sub BarButtonItem13_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem13.ItemClick
        GridView1.ColumnsCustomization()
    End Sub
    Private Sub BarButtonItem12_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem12.ItemClick
        VGrid_baslik.RowsCustomization()
    End Sub
    Private Sub BarButtonItem24_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem24.ItemClick
        fis_kopyala()
    End Sub
    Private Sub BarButtonItem25_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btn_SatirEkleIhtiyac.ItemClick
        satir_ekle_ihtiyac()
    End Sub
    Private Sub BarButtonItem15_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem15.ItemClick
        gorunum_kaydet()
    End Sub
    Private Sub txt_ara_EditValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles txt_ara.EditValueChanged
        If Len(txt_ara.EditValue.ToString) <> 0 Then
            lbl_ara.Text = Len(txt_ara.EditValue.ToString)
        Else
            lbl_ara.Text = "*"
        End If
    End Sub
    Private Sub txt_ara_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txt_ara.KeyDown
        'If e.KeyCode = Keys.Enter Then
        '    mevcut = 1
        '    If txt_ara.Text = "" Then
        '        satir_ekle("")
        '    Else
        '        If Len(txt_ara.Text) > 1 Then
        '            If sorgula_nStokID("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED  SELECT     ISNULL(COUNT(sKoliKodu), 0) AS nKayit FROM         tbKoliDagilimi WHERE     (sKoliKodu = '" & txt_ara.Text & "')") = 0 Then
        '                stok_ara()
        '            Else
        '                satir_ekle_stok_koli(txt_ara.Text)
        '            End If
        '        End If
        '    End If
        'ElseIf e.KeyCode = Keys.Up Then
        '    GridView1.Focus()
        '    GridView1.FocusedColumn = collMiktari
        'ElseIf e.KeyCode = Keys.Escape Then
        '    If XtraMessageBox.Show(Sorgu_sDil("Siparis Ekranını Kapatmak İstediğinize Emin misiniz...?", sDil), Sorgu_sDil("Dikkat", sDil), MessageBoxButtons.YesNo, MessageBoxIcon.Question) = MsgBoxResult.Yes Then
        '        Me.Close()
        '    End If
        'End If
        If e.KeyCode = Keys.Enter Then
            txt_ara.Update()
            txt_ara.Refresh()
            Try
                x = (Trim(txt_ara.Text)).IndexOf(",", 1, (Trim(txt_ara.Text)).Length - 1)
                If x = -1 Then
                Else
                    txt_ara.Text = Microsoft.VisualBasic.Replace(txt_ara.Text, ",", ".")
                    txt_ara.ScrollToCaret()
                End If
            Catch ex As Exception
            End Try
            If txt_ara.Text = "" Then
                satir_ekle("")
            Else
                mevcut = 1
                Dim sAra As String = txt_ara.Text
                If CStr(Trim(sAra).ToString) <> "" Then
                    x = (Trim(sAra)).IndexOf("*", 1, (Trim(sAra)).Length - 1)
                    If x = -1 Then
                        mevcut = 1
                    Else
                        mevcut = (Trim(sAra)).Substring(0, x)
                        sAra = (Trim(sAra)).Substring((x + 1), (Trim(sAra)).Length - (x + 1))
                        If IsNumeric(Trim(sAra)) Then
                        Else
                        End If
                    End If
                End If
                If Len(sAra) > 1 Then
                    Dim sSeriID As String = sorgula_String("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED  SELECT DISTINCT ISNULL(tbStok.nStokID, '') AS nKayit FROM tbStokFisiSeriNo INNER JOIN tbStok ON tbStokFisiSeriNo.nStokID = tbStok.nStokID WHERE (tbStokFisiSeriNo.sSeri = '" & sAra & "') GROUP BY tbStok.nStokID HAVING (SUM(tbStokFisiSeriNo.nMiktar) > 0)")
                    If sSeriID <> "" Then
                        'sAra = sSeri
                        Dim kriter As String = ""
                        Dim ara As String = sSeriID
                        Dim ara_kriter As String = "Eşittir"
                        kriter = "Where (tbStok.nStokID " & sorgu_kriter_string(ara, ara_kriter) & ")"
                        If sStokSinirla <> "" Then
                            kriter += " AND (tbStok.sKodu like '" & sStokSinirla & "%') "
                        End If
                        If Trim(dr_baslik("sFiyatTipi").ToString) <> "" Then
                            ds_stok = sorgu(sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT     *, lOzelFiyat = CASE WHEN lCariFiyat <> 0 THEN lCariFiyat WHEN lUstFiyat = 0 THEN lFiyat1 ELSE lUstFiyat END FROM         (SELECT tbStok.*, tbStokBarkodu.sBarkod AS sBarkod, ISNULL((SELECT isnull(lfiyat , 0) FROM tbstokfiyati WHERE nStokId = tbStok.NstokId AND sFiyatTipi = '" & sFiyat1 & "'), 0) AS lFiyat1, ISNULL((SELECT isnull(lfiyat , 0) FROM tbstokfiyati WHERE nStokId = tbStok.NstokId AND sFiyatTipi = '" & sFiyat2 & "'), 0) AS lFiyat2, ISNULL((SELECT isnull(lfiyat , 0) FROM tbstokfiyati WHERE nStokId = tbStok.NstokId AND sFiyatTipi = '" & sFiyat3 & "'), 0) AS lFiyat3, ISNULL((SELECT isnull(lfiyat , 0) FROM tbstokfiyati WHERE nStokId = tbStok.NstokId AND sFiyatTipi = '" & sFiyatM & "'), 0) AS MALIYET, ISNULL((SELECT isnull(lfiyat , 0) FROM tbstokfiyati WHERE nStokId = tbstok.NstokId AND sFiyatTipi = '" & sAltFiyatTipi & "'),0) AS lAltFiyat,ISNULL((SELECT isnull(lfiyat , 0) FROM tbstokfiyati WHERE nStokId = tbStok.NstokId AND sFiyatTipi = '" & sFiyatA & "'), 0) AS ALISFIYATI,ISNULL((SELECT isnull(lfiyat , 0) FROM tbstokfiyati WHERE nStokId = tbStok.NstokId AND sFiyatTipi = '" & Trim(dr_baslik("sFiyatTipi").ToString) & "'), 0) AS lCariFiyat,ISNULL((SELECT isnull(lfiyat , 0) FROM tbstokfiyati WHERE nStokId = tbStok.NstokId AND sFiyatTipi = '" & Microsoft.VisualBasic.Left(Trim(dr_baslik("sFiyatTipi").ToString), 1) & "'), 0) AS lUstFiyat,(SELECT nKdvOrani FROM tbKdv WHERE sKdvTipi = tbStok.sKdvTipi) AS nKdvOrani, ISNULL((SELECT     ISNULL(lOran, 0) FROM         tbStokBirimCevrimi WHERE     nStokID = tbStok.nStokID AND sBirimCinsi = tbStok.sBirimCinsi2), 1) AS nBirimCarpan,(SELECT sRenkAdi FROM tbRenk WHERE sRenk = tbStok.sRenk) AS sRenkAdi, (SELECT sSinifKodu1 FROM tbStokSinifi WHERE nStokID = tbStok.nStokID) AS sSinifKodu1,CAST(0 AS Money) AS lMiktar FROM tbStok INNER JOIN tbStokBarkodu ON tbStok.nStokID = tbStokBarkodu.nStokID AND tbStokBarkodu.nKisim =0 " & kriter & ") tbStoklar ORDER BY sKodu"))
                        Else
                            ds_stok = sorgu(sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT tbStok.*, tbStokBarkodu.sBarkod AS sBarkod, ISNULL((SELECT isnull(lfiyat , 0) FROM tbstokfiyati WHERE nStokId = tbStok.NstokId AND sFiyatTipi = '" & sFiyat1 & "'), 0) AS lFiyat1, ISNULL((SELECT isnull(lfiyat , 0) FROM tbstokfiyati WHERE nStokId = tbStok.NstokId AND sFiyatTipi = '" & sFiyat2 & "'), 0) AS lFiyat2, ISNULL((SELECT isnull(lfiyat , 0) FROM tbstokfiyati WHERE nStokId = tbStok.NstokId AND sFiyatTipi = '" & sFiyat3 & "'), 0) AS lFiyat3, ISNULL((SELECT isnull(lfiyat , 0) FROM tbstokfiyati WHERE nStokId = tbStok.NstokId AND sFiyatTipi = '" & sFiyatM & "'), 0) AS MALIYET, ISNULL((SELECT isnull(lfiyat , 0) FROM tbstokfiyati WHERE nStokId = tbstok.NstokId AND sFiyatTipi = '" & sAltFiyatTipi & "'),0) AS lAltFiyat,ISNULL((SELECT isnull(lfiyat , 0) FROM tbstokfiyati WHERE nStokId = tbStok.NstokId AND sFiyatTipi = '" & sFiyatA & "'), 0) AS ALISFIYATI,(SELECT nKdvOrani FROM tbKdv WHERE sKdvTipi = tbStok.sKdvTipi) AS nKdvOrani,ISNULL((SELECT     ISNULL(lOran, 0) FROM         tbStokBirimCevrimi WHERE     nStokID = tbStok.nStokID AND sBirimCinsi = tbStok.sBirimCinsi2), 1) AS nBirimCarpan, (SELECT sRenkAdi FROM tbRenk WHERE sRenk = tbStok.sRenk) AS sRenkAdi, (SELECT sSinifKodu1 FROM tbStokSinifi WHERE nStokID = tbStok.nStokID) AS sSinifKodu1,CAST(0 AS Money) AS lMiktar FROM tbStok INNER JOIN tbStokBarkodu ON tbStok.nStokID = tbStokBarkodu.nStokID AND tbStokBarkodu.nKisim =0 " & kriter & " ORDER BY tbStok.sKodu"))
                        End If
                        satir_ekle_stok_tek()

                    Else
                        If sorgula_nStokID("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED  SELECT     ISNULL(COUNT(sKoliKodu), 0) AS nKayit FROM         tbKoliDagilimi WHERE     (sKoliKodu = '" & sAra & "')") = 0 Then
                            stok_ara()
                        Else
                            satir_ekle_stok_koli(sAra)
                        End If
                    End If
                ElseIf Len(txt_ara.Text) = 1 And UCase(txt_ara.Text) = "A" Then
                    If GridView1.RowCount > 0 Then
                        Dim dr As DataRow = GridView1.GetDataRow(GridView1.FocusedRowHandle)
                        txt_ara.Text = Trim(dr("sKodu").ToString)
                    End If
                End If
            End If
        ElseIf e.KeyCode = Keys.Up Then
            GridView1.Focus()
            GridView1.FocusedColumn = collMiktari
        ElseIf e.KeyCode = Keys.Escape Then
            If XtraMessageBox.Show(Sorgu_sDil("Ekranı Kapatmak İstediğinize Emin misiniz...?", sDil), Sorgu_sDil("Dikkat", sDil), MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
                Me.Close()
            End If
        End If
    End Sub
    Private Sub stok_ara()
        mevcut = 1
        If Trim(txt_ara.Text) <> "" Then
            Label4.Text = "Barkod Standardı Kontrol Ediliyor..."
            Label4.Refresh()
            If IsNumeric(Trim(txt_ara.Text)) = True Then
                If Len(Trim(txt_ara.Text).ToString) < 2 Then
                    txt_ara.Text = Trim(txt_ara.Text) + "  "
                End If
                If Len(txt_ara.Text) > 2 Then
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
            Label4.Text = "Barkod Standardı Kontrolü Tamamlandı..."
            Label4.Refresh()
            stok_kontrol()
        End If
    End Sub
    Private Sub stok_kontrol()
        If IsNumeric(Trim(txt_ara.Text)) = True Then
            okut = True
        Else
            okut = False
        End If
        Label4.Text = "Stok Kartı Kontrolü Yapılıyor..."
        Label4.Refresh()
        Dim kontrol = sorgu_stok_kontrol(txt_ara.EditValue, sec_kriter.Text)
        If kontrol = 0 Then
            Label4.Text = "Stok Kaydı Bulunamadı!!!.Tekrar Deneyiniz..."
            Label4.Refresh()
            txt_ara.Focus()
            txt_ara.SelectAll()
            If XtraMessageBox.Show(Sorgu_sDil("Kayıt Bulunumadı..." & vbCrLf & "Yeni Kayıt Eklemek İster misiniz...?", sDil), Sorgu_sDil("Dikkat", sDil), MessageBoxButtons.YesNo, MessageBoxIcon.Warning) = MsgBoxResult.Yes Then
                stok_yeni(txt_ara.Text)
            End If
        ElseIf kontrol = 1 Then
            Label4.Text = "Belge Stok Kaydı Kontrol Ediliyor... "
            Label4.Refresh()
            'MsgBox(Sorgu_sDil("Kayıt Tek...")
            'dataload_tbstok(Trim(txt_ara.Text), sec_kriter.Text)
            Label4.Text = "Stok Bilgisi Yükleniyor... "
            Label4.Refresh()
            satir_ekle_stok_tek()
            Label4.Text = "Stok Satıra İşlendi...Yeni Ürün Okutun..."
        ElseIf kontrol > 1 Then
            satir_ekle(Trim(txt_ara.Text), sAraKriter)
            Label4.Text = "Stok Satıra İşlendi...Yeni Ürün Okutun..."
            Label4.Refresh()
            txt_ara.Text = ""
            txt_ara.Focus()
            txt_ara.SelectAll()
        End If
    End Sub
    Public Function sorgu_stok_kontrol(ByVal ara As String, ByVal ara_kriter As String) As Int64
        Dim kriter As String
        Dim kayitsayisi As Integer = 0
        Dim nKayitSayisi As Integer = 0
        Dim nBarkodSayisi As Integer = 0
        Dim nKodSayisi As Integer = 0
        Dim nAciklamaSayisi As Integer = 0
        nBarkodSayisi = sorgula_nStokID("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED Select ISNULL(COUNT(nStokID),0) from tbStokBarkodu Where sBarkod " & sorgu_kriter_string(ara, ara_kriter) & "")
        If nBarkodSayisi = 1 Then
            kriter = " WHERE tbStok.nStokID IN (Select nStokID from tbStokBarkodu Where sBarkod " & sorgu_kriter_string(ara, ara_kriter) & ")"
            If Trim(dr_baslik("sFiyatTipi").ToString) <> "" Then
                ds_stok = sorgu(sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT     *, lOzelFiyat = CASE WHEN lCariFiyat <> 0 THEN lCariFiyat WHEN lUstFiyat = 0 THEN lFiyat1 ELSE lUstFiyat END FROM         (SELECT tbStok.*, tbStokBarkodu.sBarkod AS sBarkod, ISNULL((SELECT isnull(lfiyat , 0) FROM tbstokfiyati WHERE nStokId = tbStok.NstokId AND sFiyatTipi = '" & sFiyat1 & "'), 0) AS lFiyat1, ISNULL((SELECT isnull(lfiyat , 0) FROM tbstokfiyati WHERE nStokId = tbStok.NstokId AND sFiyatTipi = '" & sFiyat2 & "'), 0) AS lFiyat2, ISNULL((SELECT isnull(lfiyat , 0) FROM tbstokfiyati WHERE nStokId = tbStok.NstokId AND sFiyatTipi = '" & sFiyat3 & "'), 0) AS lFiyat3, ISNULL((SELECT isnull(lfiyat , 0) FROM tbstokfiyati WHERE nStokId = tbStok.NstokId AND sFiyatTipi = '" & sFiyatM & "'), 0) AS MALIYET, ISNULL((SELECT isnull(lfiyat , 0) FROM tbstokfiyati WHERE nStokId = tbstok.NstokId AND sFiyatTipi = '" & sAltFiyatTipi & "'),0) AS lAltFiyat,ISNULL((SELECT isnull(lfiyat , 0) FROM tbstokfiyati WHERE nStokId = tbStok.NstokId AND sFiyatTipi = '" & sFiyatA & "'), 0) AS ALISFIYATI,ISNULL((SELECT isnull(lfiyat , 0) FROM tbstokfiyati WHERE nStokId = tbStok.NstokId AND sFiyatTipi = '" & Trim(dr_baslik("sFiyatTipi").ToString) & "'), 0) AS lCariFiyat,ISNULL((SELECT isnull(lfiyat , 0) FROM tbstokfiyati WHERE nStokId = tbStok.NstokId AND sFiyatTipi = '" & Microsoft.VisualBasic.Left(Trim(dr_baslik("sFiyatTipi").ToString), 1) & "'), 0) AS lUstFiyat,(SELECT nKdvOrani FROM tbKdv WHERE sKdvTipi = tbStok.sKdvTipi) AS nKdvOrani, ISNULL((SELECT     ISNULL(lOran, 0) FROM         tbStokBirimCevrimi WHERE     nStokID = tbStok.nStokID AND sBirimCinsi = tbStok.sBirimCinsi2), 1) AS nBirimCarpan,(SELECT sRenkAdi FROM tbRenk WHERE sRenk = tbStok.sRenk) AS sRenkAdi, (SELECT sSinifKodu1 FROM tbStokSinifi WHERE nStokID = tbStok.nStokID) AS sSinifKodu1,CAST(0 AS Money) AS lMiktar FROM tbStok INNER JOIN tbStokBarkodu ON tbStok.nStokID = tbStokBarkodu.nStokID AND tbStokBarkodu.nKisim =0 " & kriter & ") tbStoklar ORDER BY sKodu"))
            Else
                ds_stok = sorgu(sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT tbStok.*, tbStokBarkodu.sBarkod AS sBarkod, ISNULL((SELECT isnull(lfiyat , 0) FROM tbstokfiyati WHERE nStokId = tbStok.NstokId AND sFiyatTipi = '" & sFiyat1 & "'), 0) AS lFiyat1, ISNULL((SELECT isnull(lfiyat , 0) FROM tbstokfiyati WHERE nStokId = tbStok.NstokId AND sFiyatTipi = '" & sFiyat2 & "'), 0) AS lFiyat2, ISNULL((SELECT isnull(lfiyat , 0) FROM tbstokfiyati WHERE nStokId = tbStok.NstokId AND sFiyatTipi = '" & sFiyat3 & "'), 0) AS lFiyat3, ISNULL((SELECT isnull(lfiyat , 0) FROM tbstokfiyati WHERE nStokId = tbStok.NstokId AND sFiyatTipi = '" & sFiyatM & "'), 0) AS MALIYET, ISNULL((SELECT isnull(lfiyat , 0) FROM tbstokfiyati WHERE nStokId = tbstok.NstokId AND sFiyatTipi = '" & sAltFiyatTipi & "'),0) AS lAltFiyat,ISNULL((SELECT isnull(lfiyat , 0) FROM tbstokfiyati WHERE nStokId = tbStok.NstokId AND sFiyatTipi = '" & sFiyatA & "'), 0) AS ALISFIYATI,(SELECT nKdvOrani FROM tbKdv WHERE sKdvTipi = tbStok.sKdvTipi) AS nKdvOrani,ISNULL((SELECT     ISNULL(lOran, 0) FROM         tbStokBirimCevrimi WHERE     nStokID = tbStok.nStokID AND sBirimCinsi = tbStok.sBirimCinsi2), 1) AS nBirimCarpan, (SELECT sRenkAdi FROM tbRenk WHERE sRenk = tbStok.sRenk) AS sRenkAdi, (SELECT sSinifKodu1 FROM tbStokSinifi WHERE nStokID = tbStok.nStokID) AS sSinifKodu1,CAST(0 AS Money) AS lMiktar FROM tbStok INNER JOIN tbStokBarkodu ON tbStok.nStokID = tbStokBarkodu.nStokID AND tbStokBarkodu.nKisim =0 " & kriter & " ORDER BY tbStok.sKodu"))
            End If
            kayitsayisi = 1
        ElseIf nBarkodSayisi = 0 Or nBarkodSayisi > 1 Then
            'kriter = "WHERE (Stok.sKodu " & sorgu_kriter_string(ara, ara_kriter) & ") or (Stok.sAciklama " & sorgu_kriter_string(ara, ara_kriter) & ") or (Stok.sKisaAdi " & sorgu_kriter_string(ara, ara_kriter) & ") "
            kriter = "Where (sKodu " & sorgu_kriter_string(ara, ara_kriter) & ")"
            If sStokSinirla <> "" Then
                kriter += " AND (sKodu like '" & sStokSinirla & "%') "
            End If
            nKodSayisi = sorgula_nStokID("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT ISNULL(COUNT(nStokID),0) From tbStok " & kriter & "")
            If nKodSayisi = 1 Then
                kriter = "Where (tbStok.sKodu " & sorgu_kriter_string(ara, ara_kriter) & ")"
                If sStokSinirla <> "" Then
                    kriter += " AND (tbStok.sKodu like '" & sStokSinirla & "%') "
                End If
                If Trim(dr_baslik("sFiyatTipi").ToString) <> "" Then
                    ds_stok = sorgu(sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT     *, lOzelFiyat = CASE WHEN lCariFiyat <> 0 THEN lCariFiyat WHEN lUstFiyat = 0 THEN lFiyat1 ELSE lUstFiyat END FROM         (SELECT tbStok.*, tbStokBarkodu.sBarkod AS sBarkod, ISNULL((SELECT isnull(lfiyat , 0) FROM tbstokfiyati WHERE nStokId = tbStok.NstokId AND sFiyatTipi = '" & sFiyat1 & "'), 0) AS lFiyat1, ISNULL((SELECT isnull(lfiyat , 0) FROM tbstokfiyati WHERE nStokId = tbStok.NstokId AND sFiyatTipi = '" & sFiyat2 & "'), 0) AS lFiyat2, ISNULL((SELECT isnull(lfiyat , 0) FROM tbstokfiyati WHERE nStokId = tbStok.NstokId AND sFiyatTipi = '" & sFiyat3 & "'), 0) AS lFiyat3, ISNULL((SELECT isnull(lfiyat , 0) FROM tbstokfiyati WHERE nStokId = tbStok.NstokId AND sFiyatTipi = '" & sFiyatM & "'), 0) AS MALIYET, ISNULL((SELECT isnull(lfiyat , 0) FROM tbstokfiyati WHERE nStokId = tbstok.NstokId AND sFiyatTipi = '" & sAltFiyatTipi & "'),0) AS lAltFiyat,ISNULL((SELECT isnull(lfiyat , 0) FROM tbstokfiyati WHERE nStokId = tbStok.NstokId AND sFiyatTipi = '" & sFiyatA & "'), 0) AS ALISFIYATI,ISNULL((SELECT isnull(lfiyat , 0) FROM tbstokfiyati WHERE nStokId = tbStok.NstokId AND sFiyatTipi = '" & Trim(dr_baslik("sFiyatTipi").ToString) & "'), 0) AS lCariFiyat,ISNULL((SELECT isnull(lfiyat , 0) FROM tbstokfiyati WHERE nStokId = tbStok.NstokId AND sFiyatTipi = '" & Microsoft.VisualBasic.Left(Trim(dr_baslik("sFiyatTipi").ToString), 1) & "'), 0) AS lUstFiyat,(SELECT nKdvOrani FROM tbKdv WHERE sKdvTipi = tbStok.sKdvTipi) AS nKdvOrani, ISNULL((SELECT     ISNULL(lOran, 0) FROM         tbStokBirimCevrimi WHERE     nStokID = tbStok.nStokID AND sBirimCinsi = tbStok.sBirimCinsi2), 1) AS nBirimCarpan,(SELECT sRenkAdi FROM tbRenk WHERE sRenk = tbStok.sRenk) AS sRenkAdi, (SELECT sSinifKodu1 FROM tbStokSinifi WHERE nStokID = tbStok.nStokID) AS sSinifKodu1,CAST(0 AS Money) AS lMiktar FROM tbStok INNER JOIN tbStokBarkodu ON tbStok.nStokID = tbStokBarkodu.nStokID AND tbStokBarkodu.nKisim =0 " & kriter & ") tbStoklar ORDER BY sKodu"))
                Else
                    ds_stok = sorgu(sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT tbStok.*, tbStokBarkodu.sBarkod AS sBarkod, ISNULL((SELECT isnull(lfiyat , 0) FROM tbstokfiyati WHERE nStokId = tbStok.NstokId AND sFiyatTipi = '" & sFiyat1 & "'), 0) AS lFiyat1, ISNULL((SELECT isnull(lfiyat , 0) FROM tbstokfiyati WHERE nStokId = tbStok.NstokId AND sFiyatTipi = '" & sFiyat2 & "'), 0) AS lFiyat2, ISNULL((SELECT isnull(lfiyat , 0) FROM tbstokfiyati WHERE nStokId = tbStok.NstokId AND sFiyatTipi = '" & sFiyat3 & "'), 0) AS lFiyat3, ISNULL((SELECT isnull(lfiyat , 0) FROM tbstokfiyati WHERE nStokId = tbStok.NstokId AND sFiyatTipi = '" & sFiyatM & "'), 0) AS MALIYET, ISNULL((SELECT isnull(lfiyat , 0) FROM tbstokfiyati WHERE nStokId = tbstok.NstokId AND sFiyatTipi = '" & sAltFiyatTipi & "'),0) AS lAltFiyat,ISNULL((SELECT isnull(lfiyat , 0) FROM tbstokfiyati WHERE nStokId = tbStok.NstokId AND sFiyatTipi = '" & sFiyatA & "'), 0) AS ALISFIYATI,(SELECT nKdvOrani FROM tbKdv WHERE sKdvTipi = tbStok.sKdvTipi) AS nKdvOrani,ISNULL((SELECT     ISNULL(lOran, 0) FROM         tbStokBirimCevrimi WHERE     nStokID = tbStok.nStokID AND sBirimCinsi = tbStok.sBirimCinsi2), 1) AS nBirimCarpan, (SELECT sRenkAdi FROM tbRenk WHERE sRenk = tbStok.sRenk) AS sRenkAdi, (SELECT sSinifKodu1 FROM tbStokSinifi WHERE nStokID = tbStok.nStokID) AS sSinifKodu1,CAST(0 AS Money) AS lMiktar FROM tbStok INNER JOIN tbStokBarkodu ON tbStok.nStokID = tbStokBarkodu.nStokID AND tbStokBarkodu.nKisim =0 " & kriter & " ORDER BY tbStok.sKodu"))
                End If
                kayitsayisi = 1
            ElseIf nKodSayisi = 0 Then
                kriter = "Where (sAciklama " & sorgu_kriter_string(ara, ara_kriter) & ") or (sOzelNot " & sorgu_kriter_string(ara, ara_kriter) & ")"
                If sStokSinirla <> "" Then
                    kriter += " AND (sKodu like '" & sStokSinirla & "%') "
                End If
                nAciklamaSayisi = sorgula_nStokID("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT ISNULL(COUNT(nStokID),0) From tbStok " & kriter & "")
                If nAciklamaSayisi = 1 Then
                    kriter = "Where (tbStok.sAciklama " & sorgu_kriter_string(ara, ara_kriter) & ") or (tbStok.sOzelNot " & sorgu_kriter_string(ara, ara_kriter) & ")"
                    If sStokSinirla <> "" Then
                        kriter += " AND (tbStok.sKodu like '" & sStokSinirla & "%') "
                    End If
                    If Trim(dr_baslik("sFiyatTipi").ToString) <> "" Then
                        ds_stok = sorgu(sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT     *, lOzelFiyat = CASE WHEN lCariFiyat <> 0 THEN lCariFiyat WHEN lUstFiyat = 0 THEN lFiyat1 ELSE lUstFiyat END FROM         (SELECT tbStok.*, tbStokBarkodu.sBarkod AS sBarkod, ISNULL((SELECT isnull(lfiyat , 0) FROM tbstokfiyati WHERE nStokId = tbStok.NstokId AND sFiyatTipi = '" & sFiyat1 & "'), 0) AS lFiyat1, ISNULL((SELECT isnull(lfiyat , 0) FROM tbstokfiyati WHERE nStokId = tbStok.NstokId AND sFiyatTipi = '" & sFiyat2 & "'), 0) AS lFiyat2, ISNULL((SELECT isnull(lfiyat , 0) FROM tbstokfiyati WHERE nStokId = tbStok.NstokId AND sFiyatTipi = '" & sFiyat3 & "'), 0) AS lFiyat3, ISNULL((SELECT isnull(lfiyat , 0) FROM tbstokfiyati WHERE nStokId = tbStok.NstokId AND sFiyatTipi = '" & sFiyatM & "'), 0) AS MALIYET, ISNULL((SELECT isnull(lfiyat , 0) FROM tbstokfiyati WHERE nStokId = tbstok.NstokId AND sFiyatTipi = '" & sAltFiyatTipi & "'),0) AS lAltFiyat,ISNULL((SELECT isnull(lfiyat , 0) FROM tbstokfiyati WHERE nStokId = tbStok.NstokId AND sFiyatTipi = '" & sFiyatA & "'), 0) AS ALISFIYATI,ISNULL((SELECT isnull(lfiyat , 0) FROM tbstokfiyati WHERE nStokId = tbStok.NstokId AND sFiyatTipi = '" & Trim(dr_baslik("sFiyatTipi").ToString) & "'), 0) AS lCariFiyat,ISNULL((SELECT isnull(lfiyat , 0) FROM tbstokfiyati WHERE nStokId = tbStok.NstokId AND sFiyatTipi = '" & Microsoft.VisualBasic.Left(Trim(dr_baslik("sFiyatTipi").ToString), 1) & "'), 0) AS lUstFiyat,(SELECT nKdvOrani FROM tbKdv WHERE sKdvTipi = tbStok.sKdvTipi) AS nKdvOrani, ISNULL((SELECT     ISNULL(lOran, 0) FROM         tbStokBirimCevrimi WHERE     nStokID = tbStok.nStokID AND sBirimCinsi = tbStok.sBirimCinsi2), 1) AS nBirimCarpan,(SELECT sRenkAdi FROM tbRenk WHERE sRenk = tbStok.sRenk) AS sRenkAdi, (SELECT sSinifKodu1 FROM tbStokSinifi WHERE nStokID = tbStok.nStokID) AS sSinifKodu1,CAST(0 AS Money) AS lMiktar FROM tbStok INNER JOIN tbStokBarkodu ON tbStok.nStokID = tbStokBarkodu.nStokID AND tbStokBarkodu.nKisim =0 " & kriter & ") tbStoklar ORDER BY sKodu"))
                    Else
                        ds_stok = sorgu(sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT tbStok.*, tbStokBarkodu.sBarkod AS sBarkod, ISNULL((SELECT isnull(lfiyat , 0) FROM tbstokfiyati WHERE nStokId = tbStok.NstokId AND sFiyatTipi = '" & sFiyat1 & "'), 0) AS lFiyat1, ISNULL((SELECT isnull(lfiyat , 0) FROM tbstokfiyati WHERE nStokId = tbStok.NstokId AND sFiyatTipi = '" & sFiyat2 & "'), 0) AS lFİyat2, ISNULL((SELECT isnull(lfiyat , 0) FROM tbstokfiyati WHERE nStokId = tbStok.NstokId AND sFiyatTipi = '" & sFiyat3 & "'), 0) AS lFiyat3, ISNULL((SELECT isnull(lfiyat , 0) FROM tbstokfiyati WHERE nStokId = tbStok.NstokId AND sFiyatTipi = '" & sFiyatM & "'), 0) AS MALIYET, ISNULL((SELECT isnull(lfiyat , 0) FROM tbstokfiyati WHERE nStokId = tbstok.NstokId AND sFiyatTipi = '" & sAltFiyatTipi & "'),0) AS lAltFiyat,ISNULL((SELECT isnull(lfiyat , 0) FROM tbstokfiyati WHERE nStokId = tbStok.NstokId AND sFiyatTipi = '" & sFiyatA & "'), 0) AS ALISFIYATI,(SELECT nKdvOrani FROM tbKdv WHERE sKdvTipi = tbStok.sKdvTipi) AS nKdvOrani, ISNULL((SELECT     ISNULL(lOran, 0) FROM         tbStokBirimCevrimi WHERE     nStokID = tbStok.nStokID AND sBirimCinsi = tbStok.sBirimCinsi2), 1) AS nBirimCarpan,(SELECT sRenkAdi FROM tbRenk WHERE sRenk = tbStok.sRenk) AS sRenkAdi, (SELECT sSinifKodu1 FROM tbStokSinifi WHERE nStokID = tbStok.nStokID) AS sSinifKodu1,CAST(0 AS Money) AS lMiktar FROM tbStok INNER JOIN tbStokBarkodu ON tbStok.nStokID = tbStokBarkodu.nStokID AND tbStokBarkodu.nKisim =0 " & kriter & " ORDER BY tbStok.sKodu"))
                    End If
                    kayitsayisi = 1
                ElseIf nAciklamaSayisi = 0 Then
                    kayitsayisi = 0
                ElseIf nAciklamaSayisi > 1 Then
                    kayitsayisi = nAciklamaSayisi
                    sAraKriter = "Ad"
                End If
            ElseIf nKodSayisi > 1 Then
                kayitsayisi = nKodSayisi
                sAraKriter = "Kod"
            End If
            If kayitsayisi = 0 Then
                If nKodSayisi = 0 And nAciklamaSayisi = 0 And nBarkodSayisi > 1 Then
                    kayitsayisi = nBarkodSayisi
                    sAraKriter = "Barkod"
                Else
                    kayitsayisi = 0
                End If
            End If
        End If
        'Dim conn As New OleDb.OleDbConnection
        'Dim cmd As New OleDb.OleDbCommand
        'Dim adapter As New OleDb.OleDbDataAdapter
        'conn.ConnectionString = connection
        'cmd.Connection = conn
        'conn.Open()
        'cmd.CommandText = sorgu_query("SET DATEFORMAT DMY SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT     ISNULL(COUNT(*), 0) AS KAYIT FROM         tbStok Stok INNER JOIN  tbStokBarkodu Barcode ON Stok.nStokID = Barcode.nStokID and Barcode.nKisim =0 " & kriter & "")
        'kayitsayisi = cmd.ExecuteScalar
        Return kayitsayisi
    End Function
    Private Sub dataload_tbstok(ByVal ara As String, ByVal ara_kriter As String)
        Dim kriter
        kriter = "WHERE (tbStok.sKodu  " & sorgu_kriter_string(ara, ara_kriter) & ") or (tbStok.sAciklama " & sorgu_kriter_string(ara, ara_kriter) & ") OR tbStok.nStokID IN (Select nStokID from tbStokBarkodu where sBarkod " & sorgu_kriter_string(ara, ara_kriter) & ") "
        If sStokSinirla <> "" Then
            kriter += " AND (tbStok.sKodu like '" & sStokSinirla & "%') "
        End If
        If Trim(dr_baslik("sFiyatTipi").ToString) <> "" Then
            ds_stok = sorgu(sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT     *, lOzelFiyat = CASE WHEN lCariFiyat <> 0 THEN lCariFiyat WHEN lUstFiyat = 0 THEN lFiyat1 ELSE lUstFiyat END FROM         (SELECT tbStok.*, tbStokBarkodu.sBarkod AS sBarkod, ISNULL((SELECT isnull(lfiyat , 0) FROM tbstokfiyati WHERE nStokId = tbStok.NstokId AND sFiyatTipi = '" & sFiyat1 & "'), 0) AS lFiyat1, ISNULL((SELECT isnull(lfiyat , 0) FROM tbstokfiyati WHERE nStokId = tbStok.NstokId AND sFiyatTipi = '" & sFiyat2 & "'), 0) AS lFiyat2, ISNULL((SELECT isnull(lfiyat , 0) FROM tbstokfiyati WHERE nStokId = tbStok.NstokId AND sFiyatTipi = '" & sFiyat3 & "'), 0) AS lFiyat3, ISNULL((SELECT isnull(lfiyat , 0) FROM tbstokfiyati WHERE nStokId = tbStok.NstokId AND sFiyatTipi = '" & sFiyatM & "'), 0) AS MALIYET, ISNULL((SELECT isnull(lfiyat , 0) FROM tbstokfiyati WHERE nStokId = tbStok.NstokId AND sFiyatTipi = '" & sFiyatA & "'), 0) AS ALISFIYATI,ISNULL((SELECT isnull(lfiyat , 0) FROM tbstokfiyati WHERE nStokId = tbStok.NstokId AND sFiyatTipi = '" & Trim(dr_baslik("sFiyatTipi").ToString) & "'), 0) AS lCariFiyat,ISNULL((SELECT isnull(lfiyat , 0) FROM tbstokfiyati WHERE nStokId = tbStok.NstokId AND sFiyatTipi = '" & Microsoft.VisualBasic.Left(Trim(dr_baslik("sFiyatTipi").ToString), 1) & "'), 0) AS lUstFiyat,(SELECT nKdvOrani FROM tbKdv WHERE sKdvTipi = tbStok.sKdvTipi) AS nKdvOrani, (SELECT sRenkAdi FROM tbRenk WHERE sRenk = tbStok.sRenk) AS sRenkAdi, (SELECT sSinifKodu1 FROM tbStokSinifi WHERE nStokID = tbStok.nStokID) AS sSinifKodu1,CAST(0 AS Money) AS lMiktar FROM tbStok INNER JOIN tbStokBarkodu ON tbStok.nStokID = tbStokBarkodu.nStokID AND tbStokBarkodu.nKisim =0 " & kriter & ") tbStoklar ORDER BY sKodu"))
        Else
            ds_stok = sorgu(sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT tbStok.*, tbStokBarkodu.sBarkod AS sBarkod, ISNULL((SELECT isnull(lfiyat , 0) FROM tbstokfiyati WHERE nStokId = tbStok.NstokId AND sFiyatTipi = '" & sFiyat1 & "'), 0) AS lFiyat1, ISNULL((SELECT isnull(lfiyat , 0) FROM tbstokfiyati WHERE nStokId = tbStok.NstokId AND sFiyatTipi = '" & sFiyat2 & "'), 0) AS lFiyat2, ISNULL((SELECT isnull(lfiyat , 0) FROM tbstokfiyati WHERE nStokId = tbStok.NstokId AND sFiyatTipi = '" & sFiyat3 & "'), 0) AS lFiyat3, ISNULL((SELECT isnull(lfiyat , 0) FROM tbstokfiyati WHERE nStokId = tbStok.NstokId AND sFiyatTipi = '" & sFiyatM & "'), 0) AS MALIYET, ISNULL((SELECT isnull(lfiyat , 0) FROM tbstokfiyati WHERE nStokId = tbStok.NstokId AND sFiyatTipi = '" & sFiyatA & "'), 0) AS ALISFIYATI,(SELECT nKdvOrani FROM tbKdv WHERE sKdvTipi = tbStok.sKdvTipi) AS nKdvOrani, (SELECT sRenkAdi FROM tbRenk WHERE sRenk = tbStok.sRenk) AS sRenkAdi, (SELECT sSinifKodu1 FROM tbStokSinifi WHERE nStokID = tbStok.nStokID) AS sSinifKodu1,CAST(0 AS Money) AS lMiktar FROM tbStok INNER JOIN tbStokBarkodu ON tbStok.nStokID = tbStokBarkodu.nStokID AND tbStokBarkodu.nKisim =0 " & kriter & " ORDER BY tbStok.sKodu"))
        End If
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
    Private Sub stok_yeni(Optional ByVal sBarkod As String = "")
        If KayitSiniri_kontrol("tbStok", "", nKayitSinir) = True Then
            Dim frm As New frm_stok_kart_kisa
            frm.firmano = firmano
            frm.donemno = donemno
            frm.connection = connection
            frm.kullanici = kullanici
            frm.sModel = ""
            frm.nStokID = 0
            frm.sKodu = ""
            frm.txt_sKodu.Text = sBarkod
            frm.txt_sBarkod.Text = sBarkod
            If yetki_kontrol(kullanici, frm.Name) = True Then
                If frm.ShowDialog(Me) = Windows.Forms.DialogResult.OK Then
                    txt_ara.Text = frm.sModel
                    stok_kontrol()
                End If
            End If
            frm.Close()
            frm.Dispose()
            frm = Nothing
        End If
    End Sub
    Private Sub raporla_etiket(ByVal islem As Integer, Optional ByVal carpan As Int64 = 1)
        Dim file As String
        Dim fiyat1 As Decimal = 0
        Dim fiyat2 As Decimal = 0
        Dim fiyat3 As Decimal = 0
        Dim miktar As Decimal = 0
        OpenFileDialog1.Filter = "EtiketDosyaları(*.fr*) |*.fr*"
        OpenFileDialog1.FileName = "c:\Formlar\Etiket\Etiket" & sRaporUzanti & ""
        OpenFileDialog1.InitialDirectory = "c:\Formlar\Etiket"
        If OpenFileDialog1.ShowDialog = Windows.Forms.DialogResult.OK Then
            Dim dr As DataRow
            If islem = 3 Then
                Dim s As String
                Dim arr As Integer()
                Dim i As Integer
                Dim toplamsayi = GridView1.SelectedRowsCount
                Dim sayi = 0
                arr = GridView1.GetSelectedRows()
                Dim dr1 As DataRow
                If arr Is Nothing Then
                Else
                    Array.Sort(arr)
                    For Each i In arr
                        s = i.ToString
                        dr1 = GridView1.GetDataRow(s)
                        file = OpenFileDialog1.FileName.ToString
                        fiyat1 = 0 'dr("FIYAT1")
                        fiyat2 = 0 'dr("FIYAT2")
                        fiyat3 = 0 'dr("FIYAT3")
                        miktar = Math.Abs(dr1("lMiktari")) * carpan
                        'report_create_etiketX(file, satir_kontrol_etiket, islem, miktar, fiyat1, fiyat2, fiyat3)
                        If Microsoft.VisualBasic.Right(file, 3) = "fr3" Then
                            report_create_etiket(file, satir_kontrol_etiket, islem, miktar, fiyat1, fiyat2, fiyat3)
                        ElseIf Microsoft.VisualBasic.Right(file, 3) = "frx" Then
                            report_create_etiketX(file, satir_kontrol_etiket, islem, miktar, fiyat1, fiyat2, fiyat3)
                        End If
                    Next
                End If
            Else
                file = OpenFileDialog1.FileName.ToString
                dr = GridView1.GetDataRow(GridView1.FocusedRowHandle)
                fiyat1 = 0 'dr("FIYAT1")
                fiyat2 = 0 'dr("FIYAT2")
                fiyat3 = 0 'dr("FIYAT3")
                miktar = Math.Abs(dr("lMiktari"))
                'report_create_etiketX(file, satir_kontrol_etiket, islem, miktar, fiyat1, fiyat2, fiyat3)
                If Microsoft.VisualBasic.Right(file, 3) = "fr3" Then
                    report_create_etiket(file, satir_kontrol_etiket, islem, miktar, fiyat1, fiyat2, fiyat3)
                ElseIf Microsoft.VisualBasic.Right(file, 3) = "frx" Then
                    report_create_etiketX(file, satir_kontrol_etiket, islem, miktar, fiyat1, fiyat2, fiyat3)
                End If
            End If
        End If
        fiyat1 = Nothing
        fiyat2 = Nothing
        fiyat3 = Nothing
        miktar = Nothing
        file = Nothing
    End Sub
    Private Function satir_kontrol_etiket()
        Dim satir As String = "WHERE stok.nStokId IN ("
        Dim s As String
        Dim arr As Integer()
        Dim i As Integer
        Dim toplamsayi = GridView1.SelectedRowsCount
        Dim sayi = 0
        arr = GridView1.GetSelectedRows()
        Dim dr1 As DataRow
        If arr Is Nothing Then
        Else
            Array.Sort(arr)
            For Each i In arr
                s = i.ToString
                dr1 = GridView1.GetDataRow(s)
                satir += dr1("nStokID").ToString
                sayi += 1
                If sayi < toplamsayi Then
                    satir += ","
                ElseIf sayi = toplamsayi Then
                    satir += ")"
                End If
            Next
        End If
        Return satir
    End Function
    Private Sub report_create_etiket(ByVal dosya As String, ByVal kriter As String, ByVal status As Integer, ByVal miktar As Decimal, ByVal fiyat1 As Decimal, ByVal fiyat2 As Decimal, ByVal fiyat3 As Decimal)
        Dim stokno = 0
        Dim satir_line = "100"
        If IntPtr.Size = 4 Then
            '32 Bit
            Dim frx As New TfrxReportClass
            Dim ds1 As New TfrxUserDataSetClass
            Dim qr_hareket As New TfrxADOQuery
            Dim qr_baslik As New TfrxADOQuery
            Dim qr_toplam As New TfrxADOQuery
            Dim qr_firma As New TfrxADOQuery
            frx.Resources.LoadLanguageResourcesFromFile("C:\Program Files\FastReports\FastReport Studio\bin\turkish.frc")
            frx.LoadReportFromFile(dosya)
            frx.SetVariable("FIRMANO", "" & firmano & "")
            frx.SetVariable("DONEMNO", "" & donemno & "")
            frx.SetVariable("STOKNO", "" & stokno & "")
            frx.SetVariable("SATIRLINE", "'" & satir_line & "'")
            frx.SetVariable("FIYAT1", "" & fiyat1 & "")
            frx.SetVariable("FIYAT2", "" & fiyat2 & "")
            frx.SetVariable("FIYAT3", "" & fiyat3 & "")
            frx.SetVariable("FIYAT", "'" & fiyat_gizle_tumu(FormatNumber(fiyat1, 2), FormatNumber(fiyat2, 2), FormatNumber(fiyat3, 2)) & "'")
            qr_hareket = frx.FindObject("qr_hareket")
            qr_hareket.Query = sorgu_query("set transaction isolation level read uncommitted SELECT (SELECT isnull(lfiyat , 0) FROM tbstokfiyati WHERE nStokId = stok.NstokId AND sFiyatTipi = '" & sFiyat1 & "') AS PESIN, (SELECT isnull(lfiyat , 0) FROM tbstokfiyati WHERE nStokId = stok.NstokId AND sFiyatTipi = '" & sFiyat3 & "') AS ONAY, (SELECT isnull(lfiyat , 0) FROM tbstokfiyati WHERE nStokId = stok.NstokId AND sFiyatTipi = '" & sFiyat2 & "') AS ALTIAY, barkod.sBarkod, stok.sKodu AS STOKKODU, stok.sAciklama AS STOKADI,stok.sKisaAdi, stok.sRenk, stok.sBeden, stok.lAsgariMiktar, stok.lAzamiMiktar, stok.sModel, tbRenk.sRenkAdi FROM tbStok stok INNER JOIN tbStokBarkodu barkod ON stok.nStokID = barkod.nStokID and barkod.nKisim = 0 LEFT OUTER JOIN tbRenk ON stok.sRenk = tbRenk.sRenk " & kriter & " ")
            Dim qr_connection As New TfrxADODatabase
            qr_connection.ConnectionString = connection.ToString
            qr_connection.LoginPrompt = False
            qr_connection.CommandTimeout = Nothing
            qr_connection.Connected = True
            qr_hareket.DataBase = qr_connection
            If status = 0 Then
                frx.PrepareReport(True)
                frx.ShowReport()
            ElseIf status = 1 Then
                frx.PrepareReport(True)
                frx.PrintOptions.Collate = False
                frx.PrintOptions.Copies = miktar
                frx.PrintReport()
            ElseIf status = 2 Then
                'frx.PrepareReport(True)
                frx.DesignReport()
            ElseIf status = 3 Then
                frx.PrepareReport(True)
                frx.PrintOptions.Collate = False
                frx.PrintOptions.Copies = miktar
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
            args(2) = "" & sorgu_query("set transaction isolation level read uncommitted SELECT (SELECT isnull(lfiyat , 0) FROM tbstokfiyati WHERE nStokId = stok.NstokId AND sFiyatTipi = '" & sFiyat1 & "') AS PESIN, (SELECT isnull(lfiyat , 0) FROM tbstokfiyati WHERE nStokId = stok.NstokId AND sFiyatTipi = '" & sFiyat3 & "') AS ONAY, (SELECT isnull(lfiyat , 0) FROM tbstokfiyati WHERE nStokId = stok.NstokId AND sFiyatTipi = '" & sFiyat2 & "') AS ALTIAY, barkod.sBarkod, stok.sKodu AS STOKKODU, stok.sAciklama AS STOKADI,stok.sKisaAdi, stok.sRenk, stok.sBeden, stok.lAsgariMiktar, stok.lAzamiMiktar, stok.sModel, tbRenk.sRenkAdi FROM tbStok stok INNER JOIN tbStokBarkodu barkod ON stok.nStokID = barkod.nStokID and barkod.nKisim = 0 LEFT OUTER JOIN tbRenk ON stok.sRenk = tbRenk.sRenk " & kriter & " ") & ""
            args(3) = "qr_hareket"
            args(4) = "" & status.ToString() & ""
            args(5) = "8"
            args(6) = "FIRMANO"
            args(7) = "" & firmano.ToString() & ""
            args(8) = "DONEMNO"
            args(9) = "" & donemno.ToString() & ""
            args(10) = "STOKNO"
            args(11) = "" & stokno.ToString() & ""
            args(12) = "SATIRLINE"
            args(13) = "'" & satir_line.ToString() & "'"
            args(14) = "FIYAT1"
            args(15) = "" & fiyat1 & ""
            args(16) = "FIYAT2"
            args(17) = "" & fiyat2 & ""
            args(18) = "FIYAT3"
            args(19) = "" & fiyat3 & ""
            args(20) = "FIYAT"
            args(21) = "'" & fiyat_gizle_tumu(FormatNumber(fiyat1, 2), FormatNumber(fiyat2, 2), FormatNumber(fiyat3, 2)) & "'"
            processYol = args(0)
            For i As Integer = 1 To 21
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
                MessageBox.Show("Raporlama İşlemi İçin LOG Oluşturulumadı!")
            End Try
            If File.Exists(Directory.GetCurrentDirectory() & "\RaporServis.exe") = True Then
                Dim sInfo As New ProcessStartInfo(Directory.GetCurrentDirectory() & "\RaporServis.exe ", """" & yeniYol & """")
                Process.Start(sInfo)
            Else
                MessageBox.Show("Lütfen 'RaporServis.exe' eklentisini uygulama dizinine kopyalayın.")
            End If
        End If
        stokno = Nothing
        satir_line = Nothing
    End Sub
    Private Sub report_create_etiketX(ByVal sFile As String, ByVal kriter As String, ByVal nIslem As Integer, ByVal bMiktarli As Decimal, ByVal fiyat1 As Decimal, ByVal fiyat2 As Decimal, ByVal fiyat3 As Decimal)
        Dim report As New FastReport.Report
        report.Load(sFile)
        Dim ds_etiket As DataSet
        ds_etiket = sorgu(sorgu_query("set transaction isolation level read uncommitted SELECT (SELECT isnull(lfiyat , 0) FROM tbstokfiyati WHERE nStokId = stok.NstokId AND sFiyatTipi = '" & sFiyat1 & "') AS PESIN, (SELECT isnull(lfiyat , 0) FROM tbstokfiyati WHERE nStokId = stok.NstokId AND sFiyatTipi = '" & sFiyat3 & "') AS ONAY, (SELECT isnull(lfiyat , 0) FROM tbstokfiyati WHERE nStokId = stok.NstokId AND sFiyatTipi = '" & sFiyat2 & "') AS ALTIAY, barkod.sBarkod, stok.nStokID,stok.sKisaAdi,stok.sKodu AS STOKKODU, stok.sAciklama AS STOKADI, stok.sRenk, stok.sBeden, stok.lAsgariMiktar, stok.lAzamiMiktar, stok.sModel, tbRenk.sRenkAdi, tbSSinif1.sAciklama AS SINIF1, tbSSinif2.sAciklama AS SINIF2, tbSSinif3.sAciklama AS SINIF3, tbSSinif4.sAciklama AS SINIF4, tbSSinif5.sAciklama AS SINIF5, tbSSinif6.sAciklama AS SINIF6, tbSSinif7.sAciklama AS SINIF7, tbSSinif8.sAciklama AS SINIF8, tbSSinif9.sAciklama AS SINIF9, tbSSinif10.sAciklama AS SINIF10 FROM tbStok stok INNER JOIN tbStokBarkodu barkod ON stok.nStokID = barkod.nStokID and barkod.nKisim = 0 INNER JOIN tbStokSinifi ON stok.nStokID = tbStokSinifi.nStokID INNER JOIN tbSSinif1 ON tbStokSinifi.sSinifKodu1 = tbSSinif1.sSinifKodu INNER JOIN tbSSinif2 ON tbStokSinifi.sSinifKodu2 = tbSSinif2.sSinifKodu INNER JOIN tbSSinif3 ON tbStokSinifi.sSinifKodu3 = tbSSinif3.sSinifKodu INNER JOIN tbSSinif4 ON tbStokSinifi.sSinifKodu4 = tbSSinif4.sSinifKodu INNER JOIN tbSSinif5 ON tbStokSinifi.sSinifKodu5 = tbSSinif5.sSinifKodu INNER JOIN tbSSinif6 ON tbStokSinifi.sSinifKodu6 = tbSSinif6.sSinifKodu INNER JOIN tbSSinif7 ON tbStokSinifi.sSinifKodu7 = tbSSinif7.sSinifKodu INNER JOIN tbSSinif8 ON tbStokSinifi.sSinifKodu8 = tbSSinif8.sSinifKodu INNER JOIN tbSSinif9 ON tbStokSinifi.sSinifKodu9 = tbSSinif9.sSinifKodu INNER JOIN tbSSinif10 ON tbStokSinifi.sSinifKodu10 = tbSSinif10.sSinifKodu LEFT OUTER JOIN tbRenk ON stok.sRenk = tbRenk.sRenk " & kriter & " "), "Etiket")
        report.RegisterData(ds_etiket)
        report.RegisterData(ds_tbParamGenel)
        report.ScriptLanguage = Language.Vb
        If nIslem = 0 Then
            report.Show()
        ElseIf nIslem = 2 Then
            report.Design()
        ElseIf nIslem = 1 Then
            report.Print()
        ElseIf nIslem = 3 Then
            report.PrintSettings.Copies = bMiktarli
            report.PrintSettings.ShowDialog = False
            report.Print()
        End If
        ds_etiket = Nothing
        report.Dispose()
        report = Nothing
    End Sub
    Private Function fiyat_gizle(ByVal deger As String) As String
        Dim x
        Dim mevcut
        Dim deger1 As String = ""
        Dim fiyat As String = FormatNumber(deger, 2)
        If CStr(fiyat) <> "" Then
            x = (fiyat).IndexOf(".", 1, (fiyat).Length - 1)
            If x = -1 Then
                mevcut = 1
            Else
                mevcut = (fiyat).Substring(0, x)
                deger1 = (fiyat).Substring((x + 1), (fiyat).Length - (x + 1)).ToString + "." + mevcut.ToString
            End If
        End If
        Return deger1.ToString
        x = Nothing
        mevcut = Nothing
        fiyat = Nothing
    End Function
    Private Function fiyat_gizle_tumu(ByVal fiyat1 As String, ByVal fiyat2 As String, ByVal fiyat3 As String)
        Dim deger1 As String = ""
        Dim deger2 As String = ""
        Dim deger3 As String = ""
        deger1 = fiyat_gizle(FormatNumber(fiyat1, 2)).ToString
        deger2 = fiyat_gizle(FormatNumber(fiyat2, 2)).ToString
        deger3 = fiyat_gizle(FormatNumber(fiyat3, 2)).ToString
        Return deger1 + "-" + deger2 + "-" + deger3
        deger1 = Nothing
        deger2 = Nothing
        deger3 = Nothing
    End Function
    Private Sub raporla_excel()
        If XtraMessageBox.Show(Sorgu_sDil("Sonuçları Excel Dosyası Oluşturmak İstediğinize Emin misiniz...?", sDil), Sorgu_sDil("Dikkat", sDil), MessageBoxButtons.YesNo, MessageBoxIcon.Question) = MsgBoxResult.Yes Then
            Dim SaveFileDialog1 As New Windows.Forms.SaveFileDialog
            SaveFileDialog1.Filter = "Excel Dosyaları(*.xls) |*.xls"
            SaveFileDialog1.InitialDirectory = "c:\"
            'SaveFileDialog1.FileName = Trim(dr_baslik("sFisTipi")) & "_" & dr_baslik("dteFisTarihi") & "_" & dr_baslik("lFisNo") & ".xls"
            SaveFileDialog1.FileName = Trim(dr_baslik("nSiparisTipi")) & "_" & dr_baslik("lSiparisNo") & ".xls"
            If SaveFileDialog1.ShowDialog = Windows.Forms.DialogResult.OK Then
                GridView1.ExportToXls(SaveFileDialog1.FileName.ToString)
                If XtraMessageBox.Show(Sorgu_sDil("Kaydı Açmak İster misiniz...?", sDil), Sorgu_sDil("Dikkat", sDil), MessageBoxButtons.YesNo, MessageBoxIcon.Question) = MsgBoxResult.Yes Then
                    Process.Start(SaveFileDialog1.FileName.ToString)
                End If
            End If
            SaveFileDialog1 = Nothing
        End If
    End Sub
    Private Sub raporla_excel_csv()
        If XtraMessageBox.Show(Sorgu_sDil("Sonuçları Excel Csv Dosyası Oluşturmak İstediğinize Emin misiniz...?", sDil), Sorgu_sDil("Dikkat", sDil), MessageBoxButtons.YesNo, MessageBoxIcon.Question) = MsgBoxResult.Yes Then
            Dim SaveFileDialog1 As New Windows.Forms.SaveFileDialog
            SaveFileDialog1.Filter = "Excel Dosyaları(*.csv) |*.csv"
            SaveFileDialog1.InitialDirectory = "c:\"
            'SaveFileDialog1.FileName = Trim(dr_baslik("sFisTipi")) & "_" & dr_baslik("dteFisTarihi") & "_" & dr_baslik("lFisNo") & ".csv"
            SaveFileDialog1.FileName = Trim(dr_baslik("nSiparisTipi")) & "_" & dr_baslik("lSiparisNo") & ".csv"
            If SaveFileDialog1.ShowDialog = Windows.Forms.DialogResult.OK Then
                'GridView1.ExportToExcelOld(SaveFileDialog1.FileName.ToString)
                Printlink1.CreateDocument(ps)
                ps.ExportToCsv(SaveFileDialog1.FileName.ToString)
                'ps.PreviewRibbonFormEx.ShowDialog()
                If XtraMessageBox.Show(Sorgu_sDil("Kaydı Açmak İster misiniz...?", sDil), Sorgu_sDil("Dikkat", sDil), MessageBoxButtons.YesNo, MessageBoxIcon.Question) = MsgBoxResult.Yes Then
                    Process.Start(SaveFileDialog1.FileName.ToString)
                End If
            End If
            SaveFileDialog1 = Nothing
        End If
    End Sub
    Private Sub BarButtonItem16_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btn_Alt_SatirEkle.ItemClick
        satir_ekle()
    End Sub
    Private Sub BarButtonItem26_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btn_Alt_SatirSil.ItemClick
        satir_sil()
    End Sub
    Private Sub BarButtonItem27_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btn_Alt_FisSil.ItemClick
        fis_sil()
    End Sub
    Private Sub BarButtonItem28_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem28.ItemClick
        yazdir()
    End Sub
    Private Sub BarButtonItem29_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem29.ItemClick
        analiz_envanter()
    End Sub
    Private Sub BarButtonItem30_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem30.ItemClick
        analiz_stok_hareket()
    End Sub
    Private Sub BarButtonItem31_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem31.ItemClick
        analiz_cari_hareket()
    End Sub
    Private Sub BarButtonItem32_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem32.ItemClick
        analiz_Firma_karti()
    End Sub
    Private Sub BarButtonItem33_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem33.ItemClick
        analiz_stok_karti()
    End Sub
    Private Sub BarButtonItem34_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem34.ItemClick
        analiz_Fis_Notu()
    End Sub
    Private Sub BarButtonItem35_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem35.ItemClick
        raporla_etiket(0)
    End Sub
    Private Sub BarButtonItem36_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem36.ItemClick
        Dim deger = ""
        deger = InputBox("Yazdırma Çarpanı", "Yazdırma Çarpanı", 1).ToString
        If deger.ToString <> "" Then
            raporla_etiket(3, deger)
        End If
    End Sub
    Private Sub BarButtonItem4_ItemClick_1(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem4.ItemClick
        raporla_excel()
    End Sub
    Private Sub BarButtonItem5_ItemClick_1(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem5.ItemClick
        raporla_excel_csv()
    End Sub
    Private Sub sec_bDahil_CheckStateChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles sec_bDahil.CheckStateChanged
        Try
            'Vgrid_baslik.PostEditor()
            VGrid_baslik.UpdateFocusedRecord()
            VGrid_baslik.CloseEditor()
            If dr_baslik("bListelendimi") = True Then
                collBrutFiyat.FieldName = "lDahilFiyat"
                collBrutTutar.FieldName = "lDahilBrutTutar"
                collDovizFiyati.FieldName = "lDahilDovizFiyati"
                collDovizTutar.FieldName = "lDahilDovizTutar"
            Else
                collBrutFiyat.FieldName = "lFiyat"
                collBrutTutar.FieldName = "lBrutTutar"
                collDovizFiyati.FieldName = "lDovizFiyati"
                collDovizTutar.FieldName = "lDovizTutar"
            End If
            'fis_Master_degistir(nStokFisiID, dr_baslik("nFirmaID"), dr_baslik("sDepo"), dr_baslik("lFisNo"), dr_baslik("dteFisTarihi"), dr_baslik("dteValorTarihi"), dr_baslik("sHareketTipi"), dr_baslik("bListelendimi"), dr_baslik("bPesinmi"), dr_baslik("nKasaIslemID").ToString, dr_baslik("bKilitli"))
            VGrid_baslik.UpdateFocusedRecord()
            VGrid_baslik.CloseEditor()
            tbSiparis_baslik_kaydet_duzelt(dr_baslik("nFirmaID"), dr_baslik("nSiparisTipi"), dr_baslik("lSiparisNo"), dr_baslik("dteSiparisTarihi"), dr_baslik("sSiparisiAlan"), dr_baslik("sSiparisiVeren"), nSiparisTipi, lSiparisNo, dteSiparisTarihi)
            tbSiparis_Aciklamasi_kaydet_duzelt(dr_baslik("nSiparisTipi"), dr_baslik("lSiparisNo"), dr_baslik("nFirmaID"), dr_baslik("sAciklama1").ToString, dr_baslik("sAciklama2").ToString, dr_baslik("sAciklama3").ToString, dr_baslik("sAciklama4").ToString, dr_baslik("sAciklama5").ToString, dr_baslik("bKilitli"), dr_baslik("bListelendimi"))
            dteSiparisTarihi = dr_baslik("dteSiparisTarihi")
            lSiparisNo = dr_baslik("lSiparisNo")
            Dim satir = GridView1.FocusedRowHandle
            Dataload_tbSiparis(dr_baslik("dteSiparisTarihi"), dr_baslik("nSiparisTipi"), dr_baslik("lSiparisNo"), dr_baslik("nFirmaID"))
            GridView1.FocusedRowHandle = satir
            satir = Nothing
        Catch ex As Exception
        End Try
    End Sub
    Private Sub AraToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AraToolStripMenuItem.Click
        degerleri_yay()
    End Sub
    Private Sub BarButtonItem10_ItemClick_1(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem10.ItemClick
        If XtraMessageBox.Show(Sorgu_sDil("Son Alış Şartlarını Uygulamak İstediğinize Emin misiniz...?", sDil), Sorgu_sDil("Dikkat", sDil), MessageBoxButtons.YesNo, MessageBoxIcon.Question) = MsgBoxResult.Yes Then
            If XtraMessageBox.Show(Sorgu_sDil("Seçili Firmanın Son Alış Şartlarını Uygulamak İster misiniz...?", sDil), Sorgu_sDil("Dikkat", sDil), MessageBoxButtons.YesNo, MessageBoxIcon.Question) = MsgBoxResult.Yes Then
                SonAlisSartlariniUygula(True)
            Else
                SonAlisSartlariniUygula()
            End If
            XtraMessageBox.Show(Sorgu_sDil("İşlem Tamamlandı...!", sDil), Sorgu_sDil("Dikkat", sDil), MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub
    Private Sub SonAlisSartlariniUygula(Optional ByVal bFirmaSecili As Boolean = False)
        Dim dr As DataRow
        Dim dr1 As DataRow
        Dim ds_Hareket As DataSet
        Dim sayi As Integer = 0
        For Each dr In ds_tbSiparis.Tables(0).Rows
            Dim kriter As String = ""
            If bFirmaSecili = True Then
                kriter = " AND tbStokFisiDetayi.nFirmaID = " & dr_baslik("nFirmaID") & " "
            End If
            If nSiparisTipi = 2 Then
                ds_Hareket = sorgu(sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED Select TOP 1 sFiyatTipi,lBrutFiyat,lBrutTutar,nKdvOrani,lGirisMiktar1,lGirisFiyat,lGirisTutar,lIlaveMaliyetTutar,nIskontoYuzdesi,lIskontoTutari,CAST(SUBSTRING(tbStokFisiDetayi.sAciklama, 6, 5) AS MONEY) AS ISK1, CAST(SUBSTRING(tbStokFisiDetayi.sAciklama, 17, 5) AS MONEY) AS ISK2, CAST(SUBSTRING(tbStokFisiDetayi.sAciklama, 28, 5) AS MONEY) AS ISK3, CAST(SUBSTRING(tbStokFisiDetayi.sAciklama, 39, 5) AS MONEY) AS ISK4, CAST(0 AS MONEY) AS ISK5,CAST(0 AS MONEY) AS ISK6,CAST(0 AS MONEY) AS ISK7,CAST(0 AS MONEY) AS ISK8,CAST(SUBSTRING(tbStokFisiDetayi.sAciklama, 50, 9) AS MONEY) AS nMasrafSatiri,CAST(0 AS MONEY) AS GERCEKFIYAT, CAST(0 AS MONEY) AS GERCEKTOPLAM, ISNULL((ROUND((tbStokFisiDetayi.lBrutTutar - tbStokFisiDetayi.lIskontoTutari) * (tbStokFisiDetayi.nKdvOrani / 100), 2)), 0) AS lKdvTutari, (tbStokFisiDetayi.lBrutFiyat * tbStokFisiDetayi.lBirimMiktar) AS lFiyat,CAST( (tbStokFisiDetayi.lBrutFiyat*tbStokFisiDetayi.lBirimMiktar) * (100 + tbStokFisiDetayi.nKdvOrani) / 100 AS MONEY) AS lDahilFiyat,CAST(tbStokFisiDetayi.lBrutFiyat * (100 + tbStokFisiDetayi.nKdvOrani) / 100 AS MONEY) AS lDahilBrutFiyat,CAST(tbStokFisiDetayi.lBrutTutar * (100 + tbStokFisiDetayi.nKdvOrani) / 100 AS MONEY) AS lDahilBrutTutar,lDovizTutar = CASE WHEN sDovizCinsi1 <> '' AND lDovizKuru1 <> 0 THEN lBrutTutar / lDovizKuru1 ELSE lBrutTutar END, lDovizFiyati = CASE WHEN sDovizCinsi1 <> '' AND lDovizKuru1 <> 0 THEN  ((lBrutFiyat*lBirimMiktar)) / lDovizKuru1 ELSE  (lBrutFiyat*lBirimMiktar) END,lDovizBrutFiyati = CASE WHEN sDovizCinsi1 <> '' AND lDovizKuru1 <> 0 THEN lBrutFiyat / lDovizKuru1 ELSE lBrutFiyat END, lDahilDovizTutar = CASE WHEN sDovizCinsi1 <> '' AND lDovizKuru1 <> 0 THEN (lBrutTutar / lDovizKuru1) * (100 + tbStokFisiDetayi.nKdvOrani) / 100 ELSE (lBrutTutar)* (100 + tbStokFisiDetayi.nKdvOrani) / 100  END, lDahilDovizFiyati = CASE WHEN sDovizCinsi1 <> '' AND lDovizKuru1 <> 0 THEN ((lBrutFiyat*lBirimMiktar) / lDovizKuru1)* (100 + tbStokFisiDetayi.nKdvOrani) / 100 ELSE ((lBrutFiyat*lBirimMiktar))* (100 + tbStokFisiDetayi.nKdvOrani) / 100 END,lDahilDovizBrutFiyati = CASE WHEN sDovizCinsi1 <> '' AND lDovizKuru1 <> 0 THEN (lBrutFiyat / lDovizKuru1)* (100 + tbStokFisiDetayi.nKdvOrani) / 100 ELSE (lBrutFiyat)* (100 + tbStokFisiDetayi.nKdvOrani) / 100 END from tbStokFisiDetayi Where sFisTipi ='FA' and nGirisCikis =1 and nStokID = " & dr("nStokID") & kriter & " Order by dteFisTarihi DESC,dteKayitTarihi DESC"))
            Else
                ds_Hareket = sorgu(sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED Select TOP 1 sFiyatTipi,lBrutFiyat,lBrutTutar,nKdvOrani,lCikisMiktar1,lCikisFiyat,lCikisTutar,lIlaveMaliyetTutar,nIskontoYuzdesi,lIskontoTutari,CAST(SUBSTRING(tbStokFisiDetayi.sAciklama, 6, 5) AS MONEY) AS ISK1, CAST(SUBSTRING(tbStokFisiDetayi.sAciklama, 17, 5) AS MONEY) AS ISK2, CAST(SUBSTRING(tbStokFisiDetayi.sAciklama, 28, 5) AS MONEY) AS ISK3, CAST(SUBSTRING(tbStokFisiDetayi.sAciklama, 39, 5) AS MONEY) AS ISK4, CAST(0 AS MONEY) AS ISK5,CAST(0 AS MONEY) AS ISK6,CAST(0 AS MONEY) AS ISK7,CAST(0 AS MONEY) AS ISK8,CAST(SUBSTRING(tbStokFisiDetayi.sAciklama, 50, 9) AS MONEY) AS nMasrafSatiri,CAST(0 AS MONEY) AS GERCEKFIYAT, CAST(0 AS MONEY) AS GERCEKTOPLAM, ISNULL((ROUND((tbStokFisiDetayi.lBrutTutar - tbStokFisiDetayi.lIskontoTutari) * (tbStokFisiDetayi.nKdvOrani / 100), 2)), 0) AS lKdvTutari, (tbStokFisiDetayi.lBrutFiyat * tbStokFisiDetayi.lBirimMiktar) AS lFiyat,CAST( (tbStokFisiDetayi.lBrutFiyat*tbStokFisiDetayi.lBirimMiktar) * (100 + tbStokFisiDetayi.nKdvOrani) / 100 AS MONEY) AS lDahilFiyat,CAST(tbStokFisiDetayi.lBrutFiyat * (100 + tbStokFisiDetayi.nKdvOrani) / 100 AS MONEY) AS lDahilBrutFiyat,CAST(tbStokFisiDetayi.lBrutTutar * (100 + tbStokFisiDetayi.nKdvOrani) / 100 AS MONEY) AS lDahilBrutTutar,lDovizTutar = CASE WHEN sDovizCinsi1 <> '' AND lDovizKuru1 <> 0 THEN lBrutTutar / lDovizKuru1 ELSE lBrutTutar END, lDovizFiyati = CASE WHEN sDovizCinsi1 <> '' AND lDovizKuru1 <> 0 THEN  ((lBrutFiyat*lBirimMiktar)) / lDovizKuru1 ELSE  (lBrutFiyat*lBirimMiktar) END,lDovizBrutFiyati = CASE WHEN sDovizCinsi1 <> '' AND lDovizKuru1 <> 0 THEN lBrutFiyat / lDovizKuru1 ELSE lBrutFiyat END, lDahilDovizTutar = CASE WHEN sDovizCinsi1 <> '' AND lDovizKuru1 <> 0 THEN (lBrutTutar / lDovizKuru1) * (100 + tbStokFisiDetayi.nKdvOrani) / 100 ELSE (lBrutTutar)* (100 + tbStokFisiDetayi.nKdvOrani) / 100  END, lDahilDovizFiyati = CASE WHEN sDovizCinsi1 <> '' AND lDovizKuru1 <> 0 THEN ((lBrutFiyat*lBirimMiktar) / lDovizKuru1)* (100 + tbStokFisiDetayi.nKdvOrani) / 100 ELSE ((lBrutFiyat*lBirimMiktar))* (100 + tbStokFisiDetayi.nKdvOrani) / 100 END,lDahilDovizBrutFiyati = CASE WHEN sDovizCinsi1 <> '' AND lDovizKuru1 <> 0 THEN (lBrutFiyat / lDovizKuru1)* (100 + tbStokFisiDetayi.nKdvOrani) / 100 ELSE (lBrutFiyat)* (100 + tbStokFisiDetayi.nKdvOrani) / 100 END from tbStokFisiDetayi Where sFisTipi ='FS' and nGirisCikis =3 and nStokID = " & dr("nStokID") & kriter & " Order by dteFisTarihi DESC,dteKayitTarihi DESC"))
            End If
            If ds_Hareket.Tables(0).Rows.Count = 1 Then
                dr1 = ds_Hareket.Tables(0).Rows(0)
                dr("sFiyatTipi") = dr1("sFiyatTipi")
                dr("ISK1") = dr1("ISK1")
                dr("ISK2") = dr1("ISK2")
                dr("ISK3") = dr1("ISK3")
                dr("ISK4") = dr1("ISK4")
                dr("nKdvOrani") = dr1("nKdvOrani")
                dr("nIskontoYuzdesi") = dr1("nIskontoYuzdesi")
                dr("lBrutFiyat") = dr1("lBrutFiyat")
                dr("lTutari") = dr("lBrutFiyat") * dr("lMiktari")
                dr("lIskontosuzTutari") = dr("lBrutFiyat") * dr("lMiktari")
                dr("lBrutTutar") = dr("lBrutFiyat") * dr("lMiktari")
                tutar_hesapla(sayi)
            End If
            sayi += 1
        Next
    End Sub
    Private Sub BarButtonItem11_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem11.ItemClick
        analiz_stok_Alternatif()
    End Sub
    Private Sub sec_sBirimCinsi_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles sec_sBirimCinsi.KeyDown
        If e.KeyCode = Keys.Space Then
            sBirimCinsi_sec(True)
        End If
    End Sub
    Private Sub sBirimCinsi_sec(Optional ByVal bAktar As Boolean = False)
        Dim frm As New frm_tbStokBirim
        Dim dr As DataRow = GridView1.GetDataRow(GridView1.FocusedRowHandle)
        frm.firmano = firmano
        frm.donemno = donemno
        frm.connection = connection
        frm.sModel = dr("sModel").ToString
        frm.sBirimCinsi = dr("sBirimCinsi1").ToString
        frm.lMiktar = CType(dr("lMiktari"), Decimal)
        If frm.ShowDialog(Me) = Windows.Forms.DialogResult.OK Then
            If dr_baslik("bKilitli") = False Then
                Dim dr1 As DataRow
                dr1 = frm.GridView1.GetDataRow(frm.GridView1.FocusedRowHandle)
                'If bAktar = False Then
                '    If dr_baslik("nGirisCikis") = 1 Or dr_baslik("nGirisCikis") = 2 Then
                '        dr("lGirisMiktar1") = dr1("lBol") * dr1("lOran")
                '    ElseIf dr_baslik("nGirisCikis") = 3 Or dr_baslik("nGirisCikis") = 4 Then
                '        dr("lCikisMiktar1") = dr1("lBol") * dr1("lOran")
                '    End If
                'Else
                dr("lFiyat") = dr("lBrutFiyat") / dr("lBirimMiktar")
                If Integer.Parse(dr1("bTersOran").ToString()) = 1 Then
                    dr("lBirimMiktar") = (1 / Double.Parse(dr1("lOran").ToString())).ToString()
                Else
                    dr("lBirimMiktar") = dr1("lOran")
                End If
                dr("sBirimCinsi") = dr1("sBirimCinsi")
                dr("lFiyat") = dr("lBrutFiyat") * dr("lBirimMiktar")
                'End If
                dr1 = Nothing
                GridView1.UpdateCurrentRow()
                tutar_hesapla()
            End If
        End If
        frm.Close()
        frm = Nothing
    End Sub
    Private Sub analiz_karlilik()
        Dim frm As New frm_stok_cari_alis_karlilik
        frm.firmano = firmano
        frm.donemno = donemno
        frm.connection = connection
        If dr_baslik("nSiparisTipi") = 1 Or dr_baslik("nSiparisTipi") = 3 Then
            frm.fistipi = "AS"
            frm.nGirisCikis = 3
        Else
            frm.fistipi = "VS"
            frm.nGirisCikis = 1
        End If
        frm.tarih = dr_baslik("dteSiparisTarihi")
        frm.firmaID = dr_baslik("nFirmaID")
        frm.fisno = dr_baslik("lSiparisNo")
        frm.sFiyatTipi = Trim(dr_baslik("sFiyatTipi"))
        frm.nSiparisTipi = dr_baslik("nSiparisTipi")
        frm.kullanici = kullanici
        frm.sAciklama = dr_baslik("sAciklama")
        frm.nStokFisiID = dr_baslik("lSiparisNo")
        'guncelle_nSatir()
        If yetki_kontrol(kullanici, frm.Name) = True Then
            frm.ShowDialog()
        End If
        frm.Close()
        frm.Dispose()
        frm = Nothing
    End Sub
    Private Sub analiz_tbSiparisAdres()
        Dim frm As New frm_tbAlisVerisAdres
        frm.firmano = firmano
        frm.donemno = donemno
        frm.connection = connection
        frm.bSiparis = True
        frm.nSiparisTipi = dr_baslik("nSiparisTipi")
        frm.nStokFisiID = dr_baslik("lSiparisNo")
        frm.nFirmaID = dr_baslik("nFirmaID")
        'Firma Açıklaması Kontrol
        Dim kayitsayisi = sorgu_tbAlisVerisAdres_kontrol(dr_baslik("nSiparisTipi"), dr_baslik("lSiparisNo"))
        If kayitsayisi = 0 Then
            tbAlisVerisAdres_kaydet_yeni(dr_baslik("nSiparisTipi"), dr_baslik("lSiparisNo"), dr_baslik("sAciklama"), dr_baslik("sAdres1"), dr_baslik("sAdres2"), dr_baslik("sSemt"), dr_baslik("sIl"), dr_baslik("sUlke"), dr_baslik("sPostaKodu"), dr_baslik("sVergiDairesi"), dr_baslik("sVergiNo"), "")
        Else
        End If
        If yetki_kontrol(kullanici, frm.Name) = True Then
            frm.ShowDialog()
        End If
        VGrid_baslik.Rows("rowSevkAdresi").Properties.Value = "Sevk Adresi Verisi"
    End Sub
    Private Function EnsureAndGetSevkRow() As DevExpress.XtraVerticalGrid.Rows.EditorRow
        Dim v As DevExpress.XtraVerticalGrid.VGridControl = VGrid_baslik
        v.BeginUpdate()
        Try
            ' Kategori
            Dim cat As DevExpress.XtraVerticalGrid.Rows.CategoryRow =
            TryCast(v.Rows(CAT_NAME), DevExpress.XtraVerticalGrid.Rows.CategoryRow)
            If cat Is Nothing Then
                cat = New DevExpress.XtraVerticalGrid.Rows.CategoryRow()
                cat.Name = CAT_NAME
                cat.Properties.Caption = "Adres Bilgileri"
                v.Rows.Add(cat)
            End If

            ' EditorRow'u bul
            Dim er As DevExpress.XtraVerticalGrid.Rows.EditorRow =
            TryCast(v.Rows(ROW_NAME), DevExpress.XtraVerticalGrid.Rows.EditorRow)
            If er Is Nothing Then
                ' child'larda ara
                Dim i As Integer, j As Integer
                For i = 0 To v.Rows.Count - 1
                    Dim r As DevExpress.XtraVerticalGrid.Rows.BaseRow = v.Rows(i)
                    For j = 0 To r.ChildRows.Count - 1
                        If String.Equals(r.ChildRows(j).Name, ROW_NAME, StringComparison.OrdinalIgnoreCase) Then
                            er = TryCast(r.ChildRows(j), DevExpress.XtraVerticalGrid.Rows.EditorRow)
                            Exit For
                        End If
                    Next
                    If er IsNot Nothing Then Exit For
                Next
            End If

            ' Yoksa oluştur ve stile hazırla
            If er Is Nothing Then
                er = New DevExpress.XtraVerticalGrid.Rows.EditorRow()
                er.Name = ROW_NAME
                er.Properties.Caption = "Sevk Adresi"
                er.Height = 85
                er.Properties.FieldName = Nothing
                er.Properties.UnboundType = DevExpress.Data.UnboundColumnType.[String]
                Dim rep As DevExpress.XtraEditors.Repository.RepositoryItemMemoEdit =
                New DevExpress.XtraEditors.Repository.RepositoryItemMemoEdit()
                rep.ReadOnly = True : rep.WordWrap = True : rep.ScrollBars = ScrollBars.Vertical
                Dim baseFont As System.Drawing.Font = v.Font
                rep.Appearance.Options.UseFont = True
                rep.Appearance.Font = New System.Drawing.Font(baseFont, System.Drawing.FontStyle.Bold)
                rep.AppearanceReadOnly.Options.UseFont = True
                rep.AppearanceReadOnly.Font = New System.Drawing.Font(baseFont, System.Drawing.FontStyle.Bold)
                er.Properties.RowEdit = rep
                cat.ChildRows.Add(er)
            Else
                ' Doğru kategori altında ve stil ayarlı olsun
                If er.ParentRow IsNot cat Then
                    If er.ParentRow IsNot Nothing Then er.ParentRow.ChildRows.Remove(er)
                    cat.ChildRows.Add(er)
                End If
                er.Properties.FieldName = Nothing
                er.Properties.UnboundType = DevExpress.Data.UnboundColumnType.[String]
                If er.Height < 85 Then er.Height = 85
                Dim rep2 As DevExpress.XtraEditors.Repository.RepositoryItemMemoEdit =
                TryCast(er.Properties.RowEdit, DevExpress.XtraEditors.Repository.RepositoryItemMemoEdit)
                If rep2 Is Nothing Then
                    rep2 = New DevExpress.XtraEditors.Repository.RepositoryItemMemoEdit()
                    er.Properties.RowEdit = rep2
                End If
                rep2.ReadOnly = True : rep2.WordWrap = True : rep2.ScrollBars = ScrollBars.Vertical
                Dim baseFont2 As System.Drawing.Font = v.Font
                rep2.Appearance.Options.UseFont = True
                rep2.Appearance.Font = New System.Drawing.Font(baseFont2, System.Drawing.FontStyle.Bold)
                rep2.AppearanceReadOnly.Options.UseFont = True
                rep2.AppearanceReadOnly.Font = New System.Drawing.Font(baseFont2, System.Drawing.FontStyle.Bold)
            End If

            Return er
        Finally
            v.EndUpdate()
        End Try
    End Function

    Private Sub goster_tbSiparisAdres1()
        Try
            Dim v As DevExpress.XtraVerticalGrid.VGridControl = VGrid_baslik
            Dim er As DevExpress.XtraVerticalGrid.Rows.EditorRow = EnsureAndGetSevkRow()

            ' 1) Adresi DB'den çek
            Dim sevkAdresi As String = ""
            Using con As New OleDb.OleDbConnection(connection)
                If con.State = ConnectionState.Closed Then con.Open()
                Dim sql As String =
                "SET DATEFORMAT DMY; " &
                "SELECT ISNULL(sAciklama,'') + ' ' + ISNULL(sAdres1,'') + ' ' + " &
                "ISNULL(sAdres2,'') + ' ' + ISNULL(sSemt,'') + ' ' + ISNULL(sIl,'') " &
                "FROM tbSiparisPesinAdres WHERE nSiparisTipi = ? AND lSiparisNo = ?"
                Using cmd As New OleDb.OleDbCommand(sql, con)
                    cmd.Parameters.Add("@p1", OleDb.OleDbType.Integer).Value =
                    If(IsDBNull(dr_baslik("nSiparisTipi")), 0, CInt(dr_baslik("nSiparisTipi")))
                    cmd.Parameters.Add("@p2", OleDb.OleDbType.Integer).Value =
                    If(IsDBNull(dr_baslik("lSiparisNo")), 0, CInt(dr_baslik("lSiparisNo")))
                    Dim obj As Object = cmd.ExecuteScalar()
                    If obj IsNot Nothing AndAlso obj IsNot DBNull.Value Then
                        sevkAdresi = CStr(obj).Trim()
                    End If
                End Using
            End Using
            Dim deger As String = If(String.IsNullOrWhiteSpace(sevkAdresi), "Adres Yok", sevkAdresi)

            ' 2) En az bir kayıt olsun
            If v.RecordCount = 0 Then
                v.AddNewRecord()
                v.PostEditor()
            End If
            Dim rec As Integer = If(v.FocusedRecord >= 0, v.FocusedRecord, 0)

            ' 3) Önce data-bound yazmayı dene
            Dim wrote As Boolean = False
            Dim recObj As Object = Nothing
            Try : recObj = v.GetRecordObject(rec) : Catch : recObj = Nothing : End Try
            Dim drv As Data.DataRowView = TryCast(recObj, Data.DataRowView)
            If drv IsNot Nothing Then
                Dim tbl As Data.DataTable = drv.DataView.Table
                If Not tbl.Columns.Contains("SevkAdresi") Then tbl.Columns.Add("SevkAdresi", GetType(String))
                If tbl.Columns("SevkAdresi").ReadOnly Then tbl.Columns("SevkAdresi").ReadOnly = False
                drv("SevkAdresi") = deger
                er.Properties.FieldName = "SevkAdresi"
                er.Properties.UnboundType = DevExpress.Data.UnboundColumnType.Bound
                wrote = True
            Else
                Dim dt As Data.DataTable = Nothing
                Dim bs As BindingSource = TryCast(v.DataSource, BindingSource)
                If bs IsNot Nothing Then
                    dt = TryCast(bs.DataSource, Data.DataTable)
                Else
                    dt = TryCast(v.DataSource, Data.DataTable)
                End If
                If dt IsNot Nothing Then
                    If Not dt.Columns.Contains("SevkAdresi") Then dt.Columns.Add("SevkAdresi", GetType(String))
                    If dt.Rows.Count = 0 Then dt.Rows.Add(dt.NewRow())
                    dt.Rows(Math.Min(rec, dt.Rows.Count - 1))("SevkAdresi") = deger
                    er.Properties.FieldName = "SevkAdresi"
                    er.Properties.UnboundType = DevExpress.Data.UnboundColumnType.Bound
                    wrote = True
                End If
            End If

            ' 4) Olmadıysa: unbound hücreye yaz (garanti)
            If Not wrote Then
                er.Properties.FieldName = Nothing
                er.Properties.UnboundType = DevExpress.Data.UnboundColumnType.[String]
                v.SetCellValue(er, rec, deger)
            End If

            ' 5) Görünümü güncelle (yükseklik + bold)
            If er.Height < 85 Then er.Height = 85

            Dim memo As DevExpress.XtraEditors.Repository.RepositoryItemMemoEdit =
    TryCast(er.Properties.RowEdit, DevExpress.XtraEditors.Repository.RepositoryItemMemoEdit)
            If memo Is Nothing Then
                memo = New DevExpress.XtraEditors.Repository.RepositoryItemMemoEdit()
                er.Properties.RowEdit = memo
            End If

            ' Grid’in read-only gri stilini tetiklememek için:
            er.Properties.ReadOnly = False     ' grid satırı read-only değil
            memo.ReadOnly = True               ' ama editor yine yazılamaz

            memo.WordWrap = True
            memo.ScrollBars = ScrollBars.Vertical

            ' Bold + siyah
            Dim baseFont As System.Drawing.Font = v.Font
            memo.Appearance.Options.UseFont = True
            memo.Appearance.Font = New System.Drawing.Font(baseFont, System.Drawing.FontStyle.Bold)

            memo.Appearance.Options.UseForeColor = True
            memo.Appearance.ForeColor = Color.Black
            memo.AppearanceReadOnly.Options.UseForeColor = True
            memo.AppearanceReadOnly.ForeColor = Color.Black
            memo.AppearanceDisabled.Options.UseForeColor = True
            memo.AppearanceDisabled.ForeColor = Color.Black

            v.PostEditor()
            v.Refresh()

        Catch ex As Exception
            MessageBox.Show("Adres yükleme hatası: " & ex.Message)
        End Try
    End Sub
    Public Function sorgu_tbAlisVerisAdres_kontrol(ByVal nSiparisTipi As Integer, ByVal lSiparisNo As Int64) As Int64
        Dim kriter
        kriter = "WHERE (nSiparisTipi = " & nSiparisTipi & ") and (lSiparisNo = " & lSiparisNo & ")  "
        Dim con As New OleDb.OleDbConnection
        Dim cmd As New OleDb.OleDbCommand
        Dim adapter As New OleDb.OleDbDataAdapter
        'MsgBox(connection_resmi)
        con.ConnectionString = connection
        cmd.Connection = con
        cmd.CommandTimeout = Nothing
        If con.State = ConnectionState.Closed Then
            con.Open()
        End If
        cmd.CommandText = sorgu_query("SET DATEFORMAT DMY SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT     ISNULL(COUNT(*), 0) AS KAYIT FROM         tbSiparisPesinAdres " & kriter & "")
        Dim kayitsayisi = cmd.ExecuteScalar
        Return kayitsayisi
        con.Dispose()
        cmd.Dispose()
        adapter.Dispose()
        con = Nothing
        cmd = Nothing
        adapter = Nothing
    End Function
    Private Sub tbAlisVerisAdres_kaydet_yeni(ByVal nSiparisTipi As Integer, ByVal lSiparisNo As Int64, ByVal sAciklama As String, ByVal sAdres1 As String, ByVal sAdres2 As String, ByVal sSemt As String, ByVal sIl As String, ByVal sUlke As String, ByVal sPostaKodu As String, ByVal sVergiDairesi As String, ByVal sVergiNo As String, ByVal sSubeMagaza As String)
        Dim cmd As New OleDb.OleDbCommand
        Dim con As New OleDb.OleDbConnection
        cmd.Connection = con
        con.ConnectionString = connection
        cmd.CommandTimeout = Nothing
        If con.State = ConnectionState.Closed = True Then
            con.Open()
        End If
        cmd.CommandText = sorgu_query("SET DATEFORMAT DMY SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED INSERT INTO tbSiparisPesinAdres (nSiparisTipi,lSiparisNo, sAciklama, sAdres1, sAdres2, sSemt, sIl, sUlke, sPostaKodu, sVergiDairesi, sVergiNo, sSubeMagaza) VALUES     (" & nSiparisTipi & "," & lSiparisNo & ", N'" & sAciklama & "', '" & sAdres1 & "', '" & sAdres2 & "', '" & sSemt & "', '" & sIl & "', '" & sUlke & "', '" & sPostaKodu & "', '" & sVergiDairesi & "', '" & sVergiNo & "', '" & sSubeMagaza & "')")
        cmd.ExecuteNonQuery()
        con.Close()
        con.Dispose()
        cmd.Dispose()
        con = Nothing
        cmd = Nothing
    End Sub
    Private Sub tbAlisVerisAdres_kaydet_degistir(ByVal nStokFisiID As String, ByVal sAciklama As String, ByVal sAdres1 As String, ByVal sAdres2 As String, ByVal sSemt As String, ByVal sIl As String, ByVal sUlke As String, ByVal sPostaKodu As String, ByVal sVergiDairesi As String, ByVal sVergiNo As String, ByVal sSubeMagaza As String)
        Dim cmd As New OleDb.OleDbCommand
        Dim con As New OleDb.OleDbConnection
        cmd.Connection = con
        con.ConnectionString = connection
        cmd.CommandTimeout = Nothing
        If con.State = ConnectionState.Closed = True Then
            con.Open()
        End If
        cmd.CommandText = sorgu_query("SET DATEFORMAT DMY SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED UPDATE    tbStokFisiPesinAdres SET              sAciklama = N'" & sAciklama & "', sAdres1 = '" & sAdres1 & "', sAdres2 = '" & sAdres2 & "', sSemt = '" & sSemt & "', sIl = '" & sIl & "', sUlke = '" & sUlke & "', sPostaKodu = '" & sPostaKodu & "', sVergiDairesi = '" & sVergiDairesi & "', sVergiNo = '" & sVergiNo & "', sSubeMagaza = '" & sSubeMagaza & "' WHERE nStokFisiID = '" & nStokFisiID & "'")
        cmd.ExecuteNonQuery()
        con.Close()
        con.Dispose()
        cmd.Dispose()
        con = Nothing
        cmd = Nothing
    End Sub
    Private Sub analiz_protokol_stok()
        'If sLicenseModule.Items.Contains("Protokol") = True Then
        If GridView1.RowCount > 0 Then
            Dim dr As DataRow = GridView1.GetDataRow(GridView1.FocusedRowHandle)
            Dim frm As New frm_tbStokCariProtokol
            frm.firmano = firmano
            frm.donemno = donemno
            frm.connection = connection
            frm.nStokID = dr("nStokID")
            frm.nFirmaID = dr_baslik("nFirmaID")
            frm.txt_musteriNo.Text = dr("sKodu")
            frm.lbl_Firma.Text = dr("sAciklama")
            frm.bFirma = False
            frm.kullanici = kullanici
            If yetki_kontrol(kullanici, frm.Name) = True Then
                frm.ShowDialog()
            End If
            frm.Close()
            frm.Dispose()
            frm = Nothing
        End If
        'End If
    End Sub
    Private Sub analiz_protokol_cari()
        'If sLicenseModule.Items.Contains("Protokol") = True Then
        Dim frm As New frm_tbStokCariProtokol
        frm.firmano = firmano
        frm.donemno = donemno
        frm.connection = connection
        frm.nStokID = 0
        frm.nFirmaID = dr_baslik("nFirmaID")
        frm.txt_musteriNo.Text = dr_baslik("sKodu")
        frm.lbl_Firma.Text = dr_baslik("sAciklama")
        frm.bFirma = True
        frm.kullanici = kullanici
        If yetki_kontrol(kullanici, frm.Name) = True Then
            frm.ShowDialog()
        End If
        frm.Close()
        frm.Dispose()
        frm = Nothing
        'End If
    End Sub
    Public Function sorgu_tbFirmaTablo_kontrol(ByVal nStokFisiID As String, ByVal Tablo As String) As Int64
        Dim kriter
        kriter = "WHERE (nStokFisiID = '" & nStokFisiID & "') "
        Dim conn As New OleDb.OleDbConnection
        Dim cmd As New OleDb.OleDbCommand
        Dim adapter As New OleDb.OleDbDataAdapter
        conn.ConnectionString = connection
        cmd.Connection = conn
        conn.Open()
        cmd.CommandText = sorgu_query("SET DATEFORMAT DMY SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT     ISNULL(COUNT(*), 0) AS KAYIT  FROM         " & Tablo & "  " & kriter & "")
        Dim kayitsayisi = cmd.ExecuteScalar
        Return kayitsayisi
    End Function
    Private Sub BarButtonItem27_ItemClick_1(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem27.ItemClick
        analiz_protokol_stok()
    End Sub
    Private Sub BarButtonItem37_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem37.ItemClick
        analiz_protokol_cari()
    End Sub
    Private Sub BarButtonItem38_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem38.ItemClick
        analiz_tbSiparisAdres()
    End Sub
    Private Sub BarButtonItem39_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem39.ItemClick
        calculator()
    End Sub
    Private Sub BarButtonItem40_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem40.ItemClick
        analiz_karlilik()
    End Sub
    Private Sub BarButtonItem41_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem41.ItemClick
        If BarButtonItem41.Down = False Then
            GridView1.ClearColumnsFilter()
            GridView1.Columns("lYukleme").FilterInfo = New ColumnFilterInfo("[lYukleme] > 0 ")
            BarButtonItem41.Down = True
        Else
            GridView1.ClearColumnsFilter()
            BarButtonItem41.Down = False
        End If
    End Sub
    Private Sub BarButtonItem42_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem42.ItemClick
        If BarButtonItem42.Down = False Then
            GridView1.ClearColumnsFilter()
            GridView1.Columns("lYukleme").FilterInfo = New ColumnFilterInfo("[lYukleme] <> [lMiktari] ")
            BarButtonItem42.Down = True
        Else
            GridView1.ClearColumnsFilter()
            BarButtonItem42.Down = False
        End If
    End Sub
    Private Function lSevkiyatHesapla() As Decimal
        Dim toplamSevkiyat As Decimal = 0

        ' Tabloya lSevkMiktari kolonu ekle
        If Not ds_tbSiparis.Tables(0).Columns.Contains("lSevkMiktari") Then
            ds_tbSiparis.Tables(0).Columns.Add("lSevkMiktari", GetType(Decimal))
        End If

        ' Sipariş satırlarını dolaş
        For Each dr As DataRow In ds_tbSiparis.Tables(0).Rows
            Dim lMiktar As Decimal = sorgu_sayi(dr("lMiktari"), 0) ' Sipariş edilen miktar
            Dim stokKodu As String = dr("sKodu").ToString().Trim() ' Stok kodu
            Dim SiparisID As String = sorgu_sayi(dr("nSiparisID"), 0)
            ' SQL sorgusu: stok bazlı sevkiyat miktarı
            Dim sql As String =
            "SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED " &
            "SELECT CAST(ISNULL(SUM(hareket.lCikisMiktar1), 0) AS MONEY) AS CIKAN " &
            "FROM tbStok stok " &
            "INNER JOIN tbStokFisiDetayi hareket ON stok.nStokID = hareket.nStokID " &
            "WHERE stok.sKodu = '" & stokKodu & "' AND hareket.nSiparisID = '" & SiparisID & "' " &
            "GROUP BY stok.nStokID, stok.sKodu, stok.sAciklama, stok.sRenk, stok.sBeden, stok.lAsgariMiktar, stok.lAzamiMiktar, stok.sModel, bEksiyeDusulebilirmi, bEksideUyarsinmi"

            ' SQL'i çalıştır
            Dim dt As DataTable = SQLCalistir(sql)

            ' Çıkan miktarı oku
            Dim cikanMiktar As Decimal = 0
            If dt.Rows.Count > 0 AndAlso Not IsDBNull(dt.Rows(0)("CIKAN")) Then
                cikanMiktar = Convert.ToDecimal(dt.Rows(0)("CIKAN"))
            End If

            ' Kalan sevk edilecek miktar
            Dim lKalanSevkiyat As Decimal = Math.Max(0, lMiktar - cikanMiktar)

            ' Kullanıcının talep ettiği sevkiyat miktarı
            Dim talepSevkiyat As Decimal = sorgu_sayi(dr("lSevkiyat"), 0)
            Dim lSevkMiktari As Decimal

            If talepSevkiyat > 0 Then
                lSevkMiktari = Math.Min(talepSevkiyat, lKalanSevkiyat)
            Else
                lSevkMiktari = lKalanSevkiyat
            End If

            ' Satırın sevk miktarını güncelle
            dr("lSevkMiktari") = lSevkMiktari

            ' Toplam sevkiyatı artır
            toplamSevkiyat += lSevkMiktari
        Next

        Return toplamSevkiyat
    End Function




    Private Sub BarButtonItem43_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem43.ItemClick

        Dim frm As New frm_stok_cari_alis_aciklama
        Dim sFisTipi As String = ""
        Dim nGirisCikis As String = ""
        If nSiparisTipi = 1 Then
            sFisTipi = "IS"
            nGirisCikis = "3"
        ElseIf nSiparisTipi = 2 Then
            sFisTipi = "IA"
            nGirisCikis = "1"
        ElseIf nSiparisTipi = 3 Then
            sFisTipi = "IA"
            nGirisCikis = "1"
        ElseIf nSiparisTipi = 4 Then
            sFisTipi = "IS"
            nGirisCikis = "3"
        End If
        frm.txt_tarih.EditValue = dteSistemTarihi
        frm.txt_belgeno.EditValue = sorgu_lFisNo(dr_baslik("nFirmaID"), sFisTipi, nGirisCikis, sDepo)
        If frm.ShowDialog(Me) = Windows.Forms.DialogResult.OK Then
            fis_faturala(sFisTipi, frm.txt_tarih.EditValue, nGirisCikis, frm.txt_belgeno.EditValue, dr_baslik("nFirmaID"), True)
        End If
    End Sub
    Private Sub fis_faturala(ByVal sFisTipi As String, ByVal dteFisTarihi As DateTime, ByVal nGirisCikis As Int64, ByVal lFisNo As Int64, ByVal nFirmaID As Int64, Optional ByVal bYukleme As Boolean = False)
        Dim nStokFisiID As String = ""
        nStokFisiID = sorgu_nStokFisiID()
        nStokFisiID = tbStokFisiMaster_kaydet_yeni(nStokFisiID, sFisTipi, dteFisTarihi, nGirisCikis, lFisNo, nFirmaID, "", dteFisTarihi, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, "", "", "", "", "", sHareketTipi, 0, 0, 0, "", "", 0, kullaniciadi, Now, "", 0, 0, 0, 0, 0, 0)
        Dim ds_tbStokFisiPesinAdres As DataSet = sorgu(sorgu_query("Select * from tbSiparisPesinAdres Where nSiparisTipi = " & dr_baslik("nSiparisTipi") & " and lSiparisNo = '" & dr_baslik("lSiparisNo") & "'"))
        If ds_tbStokFisiPesinAdres.Tables(0).Rows.Count = 1 Then
            Dim dr1 As DataRow = ds_tbStokFisiPesinAdres.Tables(0).Rows(0)
            tbStokFisiPesinAdres_kaydet_yeni(nStokFisiID, dr1("sAciklama").ToString, dr1("sAdres1").ToString, dr1("sAdres2").ToString, dr1("sSemt").ToString, dr1("sIl").ToString, dr1("sUlke").ToString, dr1("sPostaKodu").ToString, dr1("sVergiDairesi").ToString, dr1("sVergiNo").ToString, dr1("sSubeMagaza").ToString)
            dr1 = Nothing
        End If
        tbStokFisiMaster_lFisno_degistir(nStokFisiID)

        ' Siparis aciklamalarini dogrudan tbSiparisAciklamasi tablosundan al
        Dim sAciklama1 As String = ""
        Dim sAciklama2 As String = ""
        Dim sAciklama3 As String = ""
        Dim sAciklama4 As String = ""
        Dim sAciklama5 As String = ""
        Dim ds_tbSiparisAciklamasi As DataSet = sorgu(sorgu_query("Select * from tbSiparisAciklamasi Where nSiparisTipi = " & dr_baslik("nSiparisTipi") & " and lSiparisNo = " & dr_baslik("lSiparisNo") & " and nFirmaID = " & dr_baslik("nFirmaID")))
        If ds_tbSiparisAciklamasi.Tables(0).Rows.Count > 0 Then
            Dim drAciklama As DataRow = ds_tbSiparisAciklamasi.Tables(0).Rows(0)
            sAciklama1 = If(drAciklama("sAciklama1") IsNot DBNull.Value, drAciklama("sAciklama1").ToString, "")
            sAciklama2 = If(drAciklama("sAciklama2") IsNot DBNull.Value, drAciklama("sAciklama2").ToString, "")
            sAciklama3 = If(drAciklama("sAciklama3") IsNot DBNull.Value, drAciklama("sAciklama3").ToString, "")
            sAciklama4 = If(drAciklama("sAciklama4") IsNot DBNull.Value, drAciklama("sAciklama4").ToString, "")
            sAciklama5 = If(drAciklama("sAciklama5") IsNot DBNull.Value, drAciklama("sAciklama5").ToString, "")
        End If
        tbStokFisiAciklamasi_kaydet_yeni(nStokFisiID, sAciklama1, sAciklama2, sAciklama3, sAciklama4, sAciklama5)

        Dim dr As DataRow
        Dim dteIrsaliyeTarihi As DateTime = dteFisTarihi
        Dim lIrsaliyeNo As Int64 = 0
        Dim nIrsaliyeFisiID As String = ""
        If sFisTipi = "IS" Then
            dteIrsaliyeTarihi = dteFisTarihi
            lIrsaliyeNo = lFisNo
            nIrsaliyeFisiID = nStokFisiID
        End If
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
        For Each dr In ds_tbSiparis.Tables(0).Rows
            If sorgu_sayi(dr("lSevkMiktari"), 0) > 0 Then
                Dim nIslemID As Int64 = sorgu_nStokIslemID()
                Dim nStokID As Int64 = dr("nStokID")
                Dim sBirimCinsi As String = dr("sBirimCinsi").ToString
                Dim lBirimMiktar As Decimal = dr("lBirimMiktar")
                Dim lGirisMiktar1 As Decimal = 0
                Dim lGirisMiktar2 As Decimal = 0
                Dim lCikisMiktar1 As Decimal = 0
                Dim lCikisMiktar2 As Decimal = 0
                Dim lBrutFiyat As Decimal = dr("lFiyati")
                Dim lBrutTutar As Decimal = dr("lBrutFiyat") * dr("lSevkMiktari")
                Dim lGirisFiyat As Decimal = 0
                Dim lGirisTutar As Decimal = 0
                Dim lCikisFiyat As Decimal = 0
                Dim lCikisTutar As Decimal = 0
                Dim nIskontoYuzdesi As Decimal = dr("nIskontoYuzdesi")
                Dim lIskontoTutari As Decimal = dr("lIskontoTutari")
                Dim nKdvOrani As Decimal = dr("nKdvOrani")
                Dim sSaticiRumuzu As String = dr("sSaticiRumuzu")
                'Dim sDepo As String = dr("sDepo")
                Dim nSiparisID As Int64 = dr("nSiparisID")
                Dim sAciklama As String = ""
                Dim lMaliyetFiyat As Decimal = sorgu_sayi(dr("lMaliyet"), 0)
                Dim lMaliyetTutar As Decimal = lMaliyetFiyat * dr("lSevkMiktari")
                Dim sDovizCinsi As String = dr("sDovizCinsi")
                Dim lDovizFiyat As Decimal = dr("lDovizFiyati")
                Dim sDovizCinsi1 As String = dr("sDovizCinsi")
                Dim lDovizKuru1 As Decimal = dr("lDovizKuru")
                Dim lDovizMiktari1 As Decimal = dr("lDovizFiyati")
                If dr_baslik("nSiparisTipi") = 1 Or dr_baslik("nSiparisTipi") = 4 Then
                    'Cikis
                    lCikisMiktar1 = dr("lSevkMiktari")
                    lCikisMiktar2 = 0
                    lCikisFiyat = dr("lTutari") / dr("lMiktari")
                    lCikisTutar = lCikisFiyat * dr("lSevkMiktari")
                    'Giris
                    lGirisMiktar1 = 0
                    lGirisMiktar2 = 0
                    lGirisFiyat = 0
                    lGirisTutar = 0
                Else
                    'Cikis
                    lCikisMiktar1 = 0
                    lCikisMiktar2 = 0
                    lCikisFiyat = 0
                    lCikisTutar = 0
                    'Giris
                    lGirisMiktar1 = dr("lSevkMiktari")
                    lGirisMiktar2 = 0
                    lGirisFiyat = dr("lTutari") / dr("lMiktari")
                    lGirisTutar = lGirisFiyat * dr("lSevkMiktari")
                End If
                sAciklama = "Isk1:" & uzunluk_tamamla(FormatNumber(dr("ISK1"), 2), 5) & " Isk2:" & uzunluk_tamamla(FormatNumber(dr("ISK2"), 2), 5) & " Isk3:" & uzunluk_tamamla(FormatNumber(dr("ISK3"), 2), 5) & " Isk4:" & uzunluk_tamamla(FormatNumber(dr("ISK4"), 2), 5) & " Msrf:" & 0
                If bYukleme = True Then
                    dr("lYukleme") = sorgu_sayi(dr("lYukleme"), 0)
                    If sorgu_sayi(dr("lYukleme"), 0) > 0 Then
                        lFiyat = dr("lBrutFiyat")
                        lMiktar = dr("lYukleme")
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
                            nIskontoYuzdesi = ((dr("lBrutFiyat") - isk5) / dr("lBrutFiyat")) * 100
                        Catch ex As Exception
                            nIskontoYuzdesi = 0
                        End Try
                        lGercekFiyat = isk5
                        lGercekToplam = isk5 * lMiktar
                        lIsktutar = (lFiyat * lMiktar) - lGercekToplam
                        lkdvtutar = (lGercekToplam * (dr("nKdvOrani") / 100))
                        'dr("sSatirAciklama") = "Isk1:" & uzunluk_tamamla(FormatNumber(dr("ISK1"), 2), 5) & " Isk2:" & uzunluk_tamamla(FormatNumber(dr("ISK2"), 2), 5) & " Isk3:" & uzunluk_tamamla(FormatNumber(dr("ISK3"), 2), 5) & " Isk4:" & uzunluk_tamamla(FormatNumber(dr("ISK4"), 2), 5)
                        dr("lTutari") = lGercekToplam
                        lIskontoTutari = (dr("lFiyati") * lMiktar) - lGercekToplam
                        dr("lKdvTutari") = lkdvtutar
                        lCikisMiktar1 = dr("lYukleme")
                        lCikisFiyat = lGercekFiyat
                        lCikisTutar = lGercekToplam
                        lBrutTutar = lBrutFiyat * dr("lYukleme")
                        lMaliyetTutar = lMaliyetFiyat * dr("lYukleme")
                        nIslemID = tbStokFisidetay_kaydet_yeni(nIslemID, nStokID, dteFisTarihi, nFirmaID, 0, sFisTipi, dteFisTarihi, lFisNo, nGirisCikis, sDepo, 0, "", "", sSaticiRumuzu, "", dteIrsaliyeTarihi, lIrsaliyeNo, lGirisMiktar1, lGirisMiktar2, lGirisFiyat, lGirisTutar, lCikisMiktar1, lCikisMiktar2, lCikisFiyat, lCikisTutar, sFiyatTipi, sBirimCinsi, lBirimMiktar, lBrutFiyat, lBrutTutar, lMaliyetFiyat, lMaliyetTutar, 0, nIskontoYuzdesi, lIskontoTutari, sDovizCinsi, lDovizFiyat, nSiparisID, 0, "", "", nKdvOrani, 0, sAciklama, sHareketTipi, 0, dr("sSiparisiVeren").ToString, Now, sDovizCinsi1, lDovizMiktari1, lDovizKuru1, "", 0, 0, 0, "", "", nStokFisiID, nIrsaliyeFisiID, "", sFisTipi, 0, 0, 0, 0, kullaniciadi, Now, 0, 0)
                        fis_detay_fisno_degistir(nIslemID)
                    End If
                Else
                    lFiyat = dr("lBrutFiyat")
                    lMiktar = dr("lSevkMiktari")
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
                        nIskontoYuzdesi = ((dr("lBrutFiyat") - isk5) / dr("lBrutFiyat")) * 100
                    Catch ex As Exception
                        nIskontoYuzdesi = 0
                    End Try
                    lGercekFiyat = isk5
                    lGercekToplam = isk5 * lMiktar
                    lIsktutar = (lFiyat * lMiktar) - lGercekToplam
                    lkdvtutar = (lGercekToplam * (dr("nKdvOrani") / 100))
                    dr("sSatirAciklama") = "Isk1:" & uzunluk_tamamla(FormatNumber(dr("ISK1"), 2), 5) & " Isk2:" & uzunluk_tamamla(FormatNumber(dr("ISK2"), 2), 5) & " Isk3:" & uzunluk_tamamla(FormatNumber(dr("ISK3"), 2), 5) & " Isk4:" & uzunluk_tamamla(FormatNumber(dr("ISK4"), 2), 5)
                    dr("lTutari") = lGercekToplam
                    lIskontoTutari = (lBrutFiyat * lMiktar) - lGercekToplam
                    dr("lKdvTutari") = lkdvtutar
                    tbStokFisidetay_kaydet_yeni(nIslemID, nStokID, dteFisTarihi, nFirmaID, 0, sFisTipi, dteFisTarihi, lFisNo, nGirisCikis, sDepo, 0, "", "", sSaticiRumuzu, "", dteIrsaliyeTarihi, lIrsaliyeNo, lGirisMiktar1, lGirisMiktar2, lGirisFiyat, lGirisTutar, lCikisMiktar1, lCikisMiktar2, lCikisFiyat, lCikisTutar, sFiyatTipi, sBirimCinsi, lBirimMiktar, lBrutFiyat, lBrutTutar, lMaliyetFiyat, lMaliyetTutar, 0, nIskontoYuzdesi, lIskontoTutari, sDovizCinsi, lDovizFiyat, nSiparisID, 0, "", "", nKdvOrani, 0, sAciklama, sHareketTipi, 0, dr("sSiparisiVeren").ToString, Now, sDovizCinsi1, lDovizMiktari1, lDovizKuru1, "", 0, 0, 0, "", "", nStokFisiID, nIrsaliyeFisiID, "", sFisTipi, 0, 0, 0, 0, kullaniciadi, Now, 0, 0)
                    fis_detay_fisno_degistir(nIslemID)
                End If
            End If
        Next
        If Trim(sFisTipi) = "IS" Or Trim(sFisTipi) = "IA" Then
            dr_baslik("sAciklama5") = Sorgu_sDil("İrsaliyeye Aktarıldı", sDil)
        Else
            dr_baslik("sAciklama5") = Sorgu_sDil("Faturaya Aktarıldı", sDil)
        End If
        tbSiparis_Aciklamasi_kaydet_yeni(dr_baslik("nSiparisTipi"), dr_baslik("lSiparisNo"), dr_baslik("nFirmaID"), dr_baslik("sAciklama1").ToString, dr_baslik("sAciklama2").ToString, dr_baslik("sAciklama3").ToString, dr_baslik("sAciklama4").ToString, dr_baslik("sAciklama5").ToString, dr_baslik("bKilitli"))
        tbSiparis_Aciklamasi_kaydet_duzelt(dr_baslik("nSiparisTipi"), dr_baslik("lSiparisNo"), dr_baslik("nFirmaID"), dr_baslik("sAciklama1").ToString, dr_baslik("sAciklama2").ToString, dr_baslik("sAciklama3").ToString, dr_baslik("sAciklama4").ToString, dr_baslik("sAciklama5").ToString, dr_baslik("bKilitli"), dr_baslik("bListelendimi"))
        'Fişi Göster
        Dim fm As New frm_fatura
        fm.firmano = firmano
        fm.donemno = donemno
        fm.connection = connection
        fm.lFisNo = lFisNo
        fm.dteFisTarihi = dteFisTarihi
        fm.sFisTipi = sFisTipi
        fm.nFirmaID = nFirmaID
        fm.nGirisCikis = nGirisCikis
        fm.nStokFisiID = nStokFisiID
        fm.kullanici = kullanici
        fm.aktarim = True
        fm.Text = "Fis#Faturala"
        If yetki_kontrol(kullanici, fm.Name) = True Then
            fm.ShowDialog()
            Dataload_tbSiparis(dr_baslik("dteSiparisTarihi"), dr_baslik("nSiparisTipi"), dr_baslik("lSiparisNo"), dr_baslik("nFirmaID"))
        End If
        fm.Close()
        fm = Nothing
    End Sub
    Private Sub tbStokFisiPesinAdres_kaydet_yeni(ByVal nStokFisiID As String, ByVal sAciklama As String, ByVal sAdres1 As String, ByVal sAdres2 As String, ByVal sSemt As String, ByVal sIl As String, ByVal sUlke As String, ByVal sPostaKodu As String, ByVal sVergiDairesi As String, ByVal sVergiNo As String, ByVal sSubeMagaza As String)
        Dim cmd As New OleDb.OleDbCommand
        Dim con As New OleDb.OleDbConnection
        cmd.Connection = con
        con.ConnectionString = connection
        cmd.CommandTimeout = Nothing
        If con.State = ConnectionState.Closed = True Then
            con.Open()
        End If
        cmd.CommandText = sorgu_query("SET DATEFORMAT DMY SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED INSERT INTO tbStokFisiPesinAdres (nStokFisiID, sAciklama, sAdres1, sAdres2, sSemt, sIl, sUlke, sPostaKodu, sVergiDairesi, sVergiNo, sSubeMagaza) VALUES     ('" & nStokFisiID & "', N'" & sAciklama & "', '" & sAdres1 & "', '" & sAdres2 & "', '" & sSemt & "', '" & sIl & "', '" & sUlke & "', '" & sPostaKodu & "', '" & sVergiDairesi & "', '" & sVergiNo & "', '" & sSubeMagaza & "')")
        cmd.ExecuteNonQuery()
        con.Close()
        con.Dispose()
        cmd.Dispose()
        con = Nothing
        cmd = Nothing
    End Sub
    Public Function sorgu_lFisNo(ByVal nFirmaID As String, ByVal sFisTipi As String, ByVal nGirisCikis As Integer, ByVal sDepo As String, Optional ByVal bDegistir As Boolean = True, Optional ByVal sOperator As String = "+", Optional ByVal nSayfa As Integer = 1) As Int64
        Dim con As New OleDb.OleDbConnection
        Dim cmd As New OleDb.OleDbCommand
        Dim adapter As New OleDb.OleDbDataAdapter
        con.ConnectionString = connection
        cmd.CommandTimeout = Nothing
        cmd.Connection = con
        If con.State = ConnectionState.Closed Then
            con.Open()
        End If
        Dim kayitsayisi As Int64 = 0
        If sOperator = "+" And nSayfa = 1 Then
            If nGirisCikis = 1 Or nGirisCikis = 2 Or nGirisCikis = 4 Then
                If Trim(sFisTipi) = "MM" Then
                    cmd.CommandText = sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT     ISNULL(lSevkFaturasi2,0) + 1 AS lFisNo FROM         tbStokFisNolar WHERE     (sDepo = '" & sDepo & "')")
                Else
                    cmd.CommandText = sorgu_query("SET DATEFORMAT DMY SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT      ISNULL(MAX(lFisNo), 0) + 1 AS lFisNo FROM         tbStokFisiMaster  Where sFisTipi = '" & sFisTipi & "'  AND nStokFisiID IN (Select TOP 3 nStokFisiID from tbStokFisiMaster Where sFisTipi ='" & sFisTipi & "' and nFirmaID = " & nFirmaID & " and nGirisCikis =" & nGirisCikis & " Order by dteFisTarihi DESC)")
                End If
                'cmd.CommandText = sorgu_query("SET DATEFORMAT DMY SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT      ISNULL(MAX(lFisNo), 0) + 1 AS lFisNo FROM         tbStokFisiMaster  Where sFisTipi = '" & sFisTipi & "'  AND nStokFisiID IN (Select TOP 3 nStokFisiID from tbStokFisiMaster Where sFisTipi ='" & sFisTipi & "' and nFirmaID = " & nFirmaID & " and nGirisCikis =" & nGirisCikis & " Order by dteFisTarihi DESC)")
            ElseIf nGirisCikis = 3 Then
                Dim nCiktiSatirSayisi As Integer = 25
                If bKendiFisNo = True Then
                    If Trim(sFisTipi) = "FS" Then
                        nCiktiSatirSayisi = nFaturaCiktiSatirSayisi
                        cmd.CommandText = sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT     ISNULL(lToptanFatura2,0) + 1 AS lFisNo FROM         tbStokFisNolar WHERE     (sDepo = '" & sDepo & "') ")
                    ElseIf Trim(sFisTipi) = "FA" Then
                        nCiktiSatirSayisi = nFaturaCiktiSatirSayisi
                        cmd.CommandText = sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT     ISNULL(lToptanFatura2,0) + 1 AS lFisNo FROM         tbStokFisNolar WHERE     (sDepo = '" & sDepo & "') ")
                    ElseIf Trim(sFisTipi) = "IS" Then
                        nCiktiSatirSayisi = nIrsaliyeCiktiSatirSayisi
                        cmd.CommandText = sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT     ISNULL(lToptanIrsaliye2,0) + 1 AS lFisNo FROM         tbStokFisNolar WHERE     (sDepo = '" & sDepo & "')")
                    ElseIf Trim(sFisTipi) = "DC" Then
                        nCiktiSatirSayisi = nStokFisiCiktiSatirSayisi
                        cmd.CommandText = sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT     ISNULL(lSevkFaturasi2,0) + 1 AS lFisNo FROM         tbStokFisNolar WHERE     (sDepo = '" & sDepo & "')")
                    ElseIf Trim(sFisTipi) = "HS" Then
                        nCiktiSatirSayisi = nFaturaCiktiSatirSayisi
                        cmd.CommandText = sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT     ISNULL(lToptanFatura2,0) + 1 AS lFisNo FROM         tbStokFisNolar WHERE     (sDepo = '" & sDepo & "')")
                    End If
                Else
                    If Trim(sFisTipi) = "FS" Then
                        nCiktiSatirSayisi = nFaturaCiktiSatirSayisi
                        cmd.CommandText = sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT     ISNULL(lToptanFatura1,0) + 1 AS lFisNo FROM         tbStokFisNolar WHERE     (sDepo = '" & sDepo & "') ")
                    ElseIf Trim(sFisTipi) = "FA" Then
                        nCiktiSatirSayisi = nFaturaCiktiSatirSayisi
                        cmd.CommandText = sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT     ISNULL(lToptanFatura1,0) + 1 AS lFisNo FROM         tbStokFisNolar WHERE     (sDepo = '" & sDepo & "') ")
                    ElseIf Trim(sFisTipi) = "IS" Then
                        nCiktiSatirSayisi = nIrsaliyeCiktiSatirSayisi
                        cmd.CommandText = sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT     ISNULL(lToptanIrsaliye1,0) + 1 AS lFisNo FROM         tbStokFisNolar WHERE     (sDepo = '" & sDepo & "')")
                    ElseIf Trim(sFisTipi) = "DC" Then
                        nCiktiSatirSayisi = nStokFisiCiktiSatirSayisi
                        cmd.CommandText = sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT     ISNULL(lSevkFaturasi1,0) + 1 AS lFisNo FROM         tbStokFisNolar WHERE     (sDepo = '" & sDepo & "')")
                    ElseIf Trim(sFisTipi) = "HS" Then
                        nCiktiSatirSayisi = nFaturaCiktiSatirSayisi
                        cmd.CommandText = sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT     ISNULL(lToptanFatura1,0) + 1 AS lFisNo FROM         tbStokFisNolar WHERE     (sDepo = '" & sDepo & "')")
                    End If
                End If
            End If
            If cmd.CommandText <> "" Then
                kayitsayisi = cmd.ExecuteScalar
            End If
        End If
        If kayitsayisi = 0 Then
            kayitsayisi = 1
        End If
        If bDegistir = True Then
            If nGirisCikis = 3 Then
                If bKendiFisNo = True Then
                    If Trim(sFisTipi) = "FS" Then
                        cmd.CommandText = sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED UPDATE    tbStokFisNolar SET              lToptanFatura2 = lToptanFatura2 " & sOperator & " " & nSayfa & " WHERE     (sDepo = '" & sDepo & "')")
                    ElseIf Trim(sFisTipi) = "FA" Then
                        cmd.CommandText = sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED UPDATE    tbStokFisNolar SET              lToptanFatura2 = lToptanFatura2 " & sOperator & " " & nSayfa & " WHERE     (sDepo = '" & sDepo & "')")
                    ElseIf Trim(sFisTipi) = "IS" Then
                        cmd.CommandText = sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED UPDATE    tbStokFisNolar SET              lToptanIrsaliye2 = lToptanIrsaliye2 " & sOperator & " " & nSayfa & " WHERE     (sDepo = '" & sDepo & "')")
                    ElseIf Trim(sFisTipi) = "DC" Then
                        cmd.CommandText = sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED UPDATE    tbStokFisNolar SET              lSevkFaturasi2 = lSevkFaturasi2 " & sOperator & " " & nSayfa & " WHERE     (sDepo = '" & sDepo & "')")
                    ElseIf Trim(sFisTipi) = "HS" Then
                        cmd.CommandText = sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED UPDATE    tbStokFisNolar SET              lToptanFatura2 = lToptanFatura2 " & sOperator & " " & nSayfa & " WHERE     (sDepo = '" & sDepo & "')")
                    End If
                Else
                    If Trim(sFisTipi) = "FS" Then
                        cmd.CommandText = sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED UPDATE    tbStokFisNolar SET              lToptanFatura1 = lToptanFatura1 " & sOperator & " " & nSayfa & " WHERE     (sDepo = '" & sDepo & "')")
                    ElseIf Trim(sFisTipi) = "FA" Then
                        cmd.CommandText = sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED UPDATE    tbStokFisNolar SET              lToptanFatura1 = lToptanFatura1 " & sOperator & " " & nSayfa & " WHERE     (sDepo = '" & sDepo & "')")
                    ElseIf Trim(sFisTipi) = "IS" Then
                        cmd.CommandText = sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED UPDATE    tbStokFisNolar SET              lToptanIrsaliye1 = lToptanIrsaliye1 " & sOperator & " " & nSayfa & " WHERE     (sDepo = '" & sDepo & "')")
                    ElseIf Trim(sFisTipi) = "DC" Then
                        cmd.CommandText = sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED UPDATE    tbStokFisNolar SET              lSevkFaturasi1 = lSevkFaturasi1 " & sOperator & " " & nSayfa & " WHERE     (sDepo = '" & sDepo & "')")
                    ElseIf Trim(sFisTipi) = "HS" Then
                        cmd.CommandText = sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED UPDATE    tbStokFisNolar SET              lToptanFatura1 = lToptanFatura1 " & sOperator & " " & nSayfa & " WHERE     (sDepo = '" & sDepo & "')")
                    End If
                End If
                cmd.ExecuteNonQuery()
            ElseIf Trim(sFisTipi) = "MM" Then
                cmd.CommandText = sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED UPDATE    tbStokFisNolar SET              lSevkFaturasi2 = lSevkFaturasi2 " & sOperator & " " & nSayfa & " WHERE     (sDepo = '" & sDepo & "')")
                cmd.ExecuteNonQuery()
            End If
        End If
        Return kayitsayisi
        con.Dispose()
        cmd.Dispose()
        adapter.Dispose()
        cmd = Nothing
    End Function
    Private Sub fis_detay_fisno_degistir(ByVal nstokIslemID As String)
        Dim cmd As New OleDb.OleDbCommand
        Dim con As New OleDb.OleDbConnection
        con.ConnectionString = connection
        cmd.CommandTimeout = Nothing
        cmd.Connection = con
        If con.State = ConnectionState.Closed Then
            con.Open()
        End If
        cmd.CommandText = sorgu_query("SET DATEFORMAT DMY SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED UPDATE    tbStokSiraNo SET              nSonID = '" & nstokIslemID & "' where nSiraIndex = 1")
        cmd.ExecuteNonQuery()
        con.Close()
        con.Dispose()
        cmd.Dispose()
        cmd = Nothing
    End Sub
    Public Function sorgu_nStokIslemID() As Int64
        Dim kriter As String = ""
        'kriter = "WHERE (sKodu = '" & kod & "')  "
        Dim con As New OleDb.OleDbConnection
        Dim cmd As New OleDb.OleDbCommand
        Dim adapter As New OleDb.OleDbDataAdapter
        'MsgBox(connection_resmi)
        con.ConnectionString = connection
        cmd.CommandTimeout = Nothing
        cmd.Connection = con
        If con.State = ConnectionState.Closed Then
            con.Open()
        End If
        cmd.CommandText = sorgu_query("SET DATEFORMAT DMY SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT     ISNULL(MAX(nIslemID), 0) + 1 AS nStokIslemID FROM         tbStokFisiDetayi")
        Dim kayitsayisi = cmd.ExecuteScalar
        Return kayitsayisi
        con.Dispose()
        cmd.Dispose()
        adapter.Dispose()
        cmd = Nothing
        Return 1
    End Function
    Public Function sorgu_nStokFisiID() As Int64
        Dim kriter As String = ""
        Dim conn As New OleDb.OleDbConnection
        Dim cmd As New OleDb.OleDbCommand
        Dim adapter As New OleDb.OleDbDataAdapter
        conn.ConnectionString = connection
        cmd.Connection = conn
        conn.Open()
        cmd.CommandText = sorgu_query("SET DATEFORMAT DMY SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT     ISNULL(MAX(nStokFisiID), 1) + 1 AS nStokFisiID FROM         tbStokFisiMaster")
        Dim kayitsayisi = cmd.ExecuteScalar
        Return kayitsayisi
        Return 1
    End Function
    Private Function tbStokFisiMaster_kaydet_yeni(ByVal nStokFisiID As Int64, ByVal sFisTipi As String, ByVal dteFisTarihi As DateTime, ByVal nGirisCikis As Int64, ByVal lFisNo As Int64, ByVal nFirmaID As Int64, ByVal sDepo As String, ByVal dteValorTarihi As DateTime, ByVal bPesinmi As Byte, ByVal bListelendimi As Byte, ByVal bHizmetFaturasimi As Byte, ByVal lToplamMiktar As Decimal, ByVal lMalBedeli As Decimal, ByVal lMalIskontoTutari As Decimal, ByVal nDipIskontoYuzdesi1 As Decimal, ByVal lDipIskontoTutari1 As Decimal, ByVal nDipIskontoYuzdesi2 As Decimal, ByVal lDipIskontoTutari2 As Decimal, ByVal lDipIskontoTutari3 As Decimal, ByVal lEkmaliyet1 As Decimal, ByVal lEkmaliyet2 As Decimal, ByVal lEkmaliyet3 As Decimal, ByVal nKdvOrani1 As Decimal, ByVal lKdvMatrahi1 As Decimal, ByVal lKdv1 As Decimal, ByVal nKdvOrani2 As Decimal, ByVal lKdvMatrahi2 As Decimal, ByVal lKdv2 As Decimal, ByVal nKdvOrani3 As Decimal, ByVal lKdvMatrahi3 As Decimal, ByVal lKdv3 As Decimal, ByVal nKdvOrani4 As Decimal, ByVal lKdvMatrahi4 As Decimal, ByVal lKdv4 As Decimal, ByVal nKdvOrani5 As Decimal, ByVal lKdvMatrahi5 As Decimal, ByVal lKdv5 As Decimal, ByVal lNetTutar As Decimal, ByVal nTevkifatKdvOrani As Decimal, ByVal lTevkifatKdvMatrahi As Decimal, ByVal lTevkifatKdv As Decimal, ByVal sCariIslem As String, ByVal nCariHareketID As String, ByVal nKasaIslemID As String, ByVal sCariKdvIslem As String, ByVal nCariKdvHareketID As String, ByVal sHareketTipi As String, ByVal bMuhasebeyeIslendimi As Byte, ByVal bFisTamamlandimi As Byte, ByVal lTransferFisiID As String, ByVal nTransferFirmaID As String, ByVal sTransferDepo As String, ByVal bFaturayaDonustumu As Byte, ByVal sKullaniciAdi As String, ByVal dteKayitTarihi As DateTime, ByVal sYaziIle As String, ByVal nOTVOrani1 As Decimal, ByVal lOTVMatrahi1 As Decimal, ByVal lOTV1 As Decimal, ByVal nOTVOrani2 As Decimal, ByVal lOTVMatrahi2 As Decimal, ByVal lOTV2 As Decimal) As Int64
        Dim cmd As New OleDb.OleDbCommand
        Dim con As New OleDb.OleDbConnection
        cmd.Connection = con
        con.ConnectionString = connection
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
    Private Sub tbStokFisiMaster_lFisno_degistir(ByVal nstokFisiID As String)
        Dim cmd As New OleDb.OleDbCommand
        Dim con As New OleDb.OleDbConnection
        con.ConnectionString = connection
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
    Private Sub tbStokFisiAciklamasi_kaydet_yeni(ByVal nStokFisiID As String, ByVal sAciklama1 As String, ByVal sAciklama2 As String, ByVal sAciklama3 As String, ByVal sAciklama4 As String, ByVal sAciklama5 As String)
        Dim cmd As New OleDb.OleDbCommand
        Dim con As New OleDb.OleDbConnection
        cmd.Connection = con
        con.ConnectionString = connection
        If con.State = ConnectionState.Closed = True Then
            con.Open()
        End If
        cmd.CommandText = sorgu_query("SET DATEFORMAT DMY INSERT INTO tbStokFisiAciklamasi                       (nStokFisiID, sAciklama1, sAciklama2, sAciklama3, sAciklama4, sAciklama5) VALUES     ('" & nStokFisiID & "', '" & sAciklama1 & "', '" & sAciklama2 & "', '" & sAciklama3 & "', '" & sAciklama4 & "', '" & sAciklama5 & "')")
        cmd.ExecuteNonQuery()
        con.Close()
        cmd = Nothing
        con = Nothing
    End Sub
    Private Function tbStokFisidetay_kaydet_yeni(ByVal nIslemID As Int64, ByVal nStokID As Int64, ByVal dteIslemTarihi As DateTime, ByVal nFirmaID As Int64, ByVal nMusteriID As Int64, ByVal sFisTipi As String, ByVal dteFisTarihi As DateTime, ByVal lFisNo As String, ByVal nGirisCikis As Int64, ByVal sDepo As String, ByVal lReyonFisNo As String, ByVal sStokIslem As String, ByVal sKasiyerRumuzu As String, ByVal sSaticiRumuzu As String, ByVal sOdemeKodu As String, ByVal dteIrsaliyeTarihi As DateTime, ByVal lIrsaliyeNo As String, ByVal lGirisMiktar1 As Decimal, ByVal lGirisMiktar2 As Decimal, ByVal lGirisFiyat As Decimal, ByVal lGirisTutar As Decimal, ByVal lCikisMiktar1 As Decimal, ByVal lCikisMiktar2 As Decimal, ByVal lCikisFiyat As Decimal, ByVal lCikisTutar As Decimal, ByVal sFiyatTipi As String, ByVal sBirimCinsi As String, ByVal lBirimMiktar As Decimal, ByVal lBrutFiyat As Decimal, ByVal lBrutTutar As Decimal, ByVal lMaliyetFiyat As Decimal, ByVal lMaliyetTutar As Decimal, ByVal lIlaveMaliyetTutar As Decimal, ByVal nIskontoYuzdesi As Decimal, ByVal lIskontoTutari As Decimal, ByVal sDovizCinsi As String, ByVal lDovizFiyat As Decimal, ByVal nSiparisID As String, ByVal nReceteNo As String, ByVal nTransferID As String, ByVal sTransferDepo As String, ByVal nKdvOrani As Decimal, ByVal nHesapID As Int64, ByVal sAciklama As String, ByVal sHareketTipi As String, ByVal bMuhasebeyeIslendimi As Byte, ByVal sKullaniciAdi As String, ByVal dteKayitTarihi As DateTime, ByVal sDovizCinsi1 As String, ByVal lDovizMiktari1 As Decimal, ByVal lDovizKuru1 As Decimal, ByVal sDovizCinsi2 As String, ByVal lDovizMiktari2 As Decimal, ByVal lDovizKuru2 As Decimal, ByVal nOTVOrani As Decimal, ByVal nTransferFirmaID As String, ByVal nAlisverisID As String, ByVal nStokFisiID As Int64, ByVal nIrsaliyeFisiID As String, ByVal sMasrafYontemi As String, ByVal sHangiUygulama As String, ByVal nEkSaha1 As Int64, ByVal nEkSaha2 As Int64, ByVal bEkSoru1 As Int64, ByVal bEkSoru2 As Int64, ByVal sSonKullaniciAdi As String, ByVal dteSonUpdateTarihi As DateTime, ByVal nPrim As Decimal, ByVal lPrimTutari As Decimal) As Int64
        Dim con As New OleDb.OleDbConnection
        Dim cmd As New OleDb.OleDbCommand
        cmd.Connection = con
        con.ConnectionString = connection
        cmd.CommandTimeout = Nothing
        If con.State = ConnectionState.Closed = True Then
            con.Open()
        End If
        If Trim(sFisTipi) = "IS" Or Trim(sFisTipi) = "IA" Then
            nIrsaliyeFisiID = "'" & nStokFisiID & "'"
        Else
            nIrsaliyeFisiID = "NULL"
        End If
        If nSiparisID <> "" Then
            cmd.CommandText = sorgu_query("SET DATEFORMAT DMY SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED INSERT INTO tbStokFisiDetayi                       (nStokID, dteIslemTarihi, nFirmaID, nMusteriID, sFisTipi, dteFisTarihi, lFisNo, nGirisCikis, sDepo, lReyonFisNo, sStokIslem, sKasiyerRumuzu, sSaticiRumuzu, sOdemeKodu, dteIrsaliyeTarihi, lIrsaliyeNo, lGirisMiktar1, lGirisMiktar2, lGirisFiyat, lGirisTutar, lCikisMiktar1, lCikisMiktar2, lCikisFiyat, lCikisTutar, sFiyatTipi, sBirimCinsi,lBirimMiktar,lBrutFiyat, lBrutTutar, lMaliyetFiyat, lMaliyetTutar, lIlaveMaliyetTutar, nIskontoYuzdesi, lIskontoTutari, sDovizCinsi, lDovizFiyat, nSiparisID, nReceteNo, nTransferID, sTransferDepo, nKdvOrani, nHesapID, sAciklama, sHareketTipi, bMuhasebeyeIslendimi, sKullaniciAdi, dteKayitTarihi, sDovizCinsi1, lDovizMiktari1, lDovizKuru1, sDovizCinsi2, lDovizMiktari2, lDovizKuru2, nOTVOrani, nTransferFirmaID, nAlisverisID, nStokFisiID, nIrsaliyeFisiID, sMasrafYontemi, sHangiUygulama, nEkSaha1, nEkSaha2, bEkSoru1, bEkSoru2, sSonKullaniciAdi, dteSonUpdateTarihi,nPrim,lPrimTutari) VALUES     ('" & nStokID & "', '" & dteIslemTarihi & "', '" & nFirmaID & "', '" & nMusteriID & "', '" & sFisTipi & "', '" & dteFisTarihi & "', '" & lFisNo & "', " & nGirisCikis & ", '" & sDepo & "', '" & lReyonFisNo & "', '" & sStokIslem & "', '" & sKasiyerRumuzu & "', '" & sSaticiRumuzu & "', '" & sOdemeKodu & "', '" & dteIrsaliyeTarihi & "', '" & lIrsaliyeNo & "', " & lGirisMiktar1 & ", " & lGirisMiktar2 & ", " & lGirisFiyat & ", " & lGirisTutar & ", " & lCikisMiktar1 & ", " & lCikisMiktar2 & " , " & lCikisFiyat & ", " & lCikisTutar & " , '" & sFiyatTipi & "' , '" & sBirimCinsi & "'," & lBirimMiktar & "," & lBrutFiyat & ", " & lBrutTutar & " , " & lMaliyetFiyat & ", " & lMaliyetTutar & ", " & lIlaveMaliyetTutar & ", " & nIskontoYuzdesi & ", " & lIskontoTutari & ", '" & sDovizCinsi & "', " & lDovizFiyat & ", " & nSiparisID & ", '" & nReceteNo & "', NULL, NULL, " & nKdvOrani & ", '" & nHesapID & "', N'" & sAciklama & "', '" & sHareketTipi & "'," & bMuhasebeyeIslendimi & ", '" & sKullaniciAdi & "', '" & dteKayitTarihi & "', '" & sDovizCinsi1 & "', " & lDovizMiktari1 & ", " & lDovizKuru1 & ", '" & sDovizCinsi2 & "', " & lDovizMiktari2 & " , " & lDovizKuru2 & ", " & nOTVOrani & ", NULL,  NULL, '" & nStokFisiID & "', " & nIrsaliyeFisiID & ", '" & sMasrafYontemi & "', '" & sHangiUygulama & "', " & nEkSaha1 & ", " & nEkSaha2 & ", " & bEkSoru1 & " , " & bEkSoru2 & ", '" & sSonKullaniciAdi & "', '" & dteSonUpdateTarihi & "'," & nPrim & "," & lPrimTutari & ")")
        Else
            If Trim(sFisTipi) = "IA" Or Trim(sFisTipi) = "IS" Then
                cmd.CommandText = sorgu_query("SET DATEFORMAT DMY SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED INSERT INTO tbStokFisiDetayi                       (nStokID, dteIslemTarihi, nFirmaID, nMusteriID, sFisTipi, dteFisTarihi, lFisNo, nGirisCikis, sDepo, lReyonFisNo, sStokIslem, sKasiyerRumuzu, sSaticiRumuzu, sOdemeKodu, dteIrsaliyeTarihi, lIrsaliyeNo, lGirisMiktar1, lGirisMiktar2, lGirisFiyat, lGirisTutar, lCikisMiktar1, lCikisMiktar2, lCikisFiyat, lCikisTutar, sFiyatTipi, sBirimCinsi,lBirimMiktar,lBrutFiyat, lBrutTutar, lMaliyetFiyat, lMaliyetTutar, lIlaveMaliyetTutar, nIskontoYuzdesi, lIskontoTutari, sDovizCinsi, lDovizFiyat, nSiparisID, nReceteNo, nTransferID, sTransferDepo, nKdvOrani, nHesapID, sAciklama, sHareketTipi, bMuhasebeyeIslendimi, sKullaniciAdi, dteKayitTarihi, sDovizCinsi1, lDovizMiktari1, lDovizKuru1, sDovizCinsi2, lDovizMiktari2, lDovizKuru2, nOTVOrani, nTransferFirmaID, nAlisverisID, nStokFisiID, nIrsaliyeFisiID, sMasrafYontemi, sHangiUygulama, nEkSaha1, nEkSaha2, bEkSoru1, bEkSoru2, sSonKullaniciAdi, dteSonUpdateTarihi,nPrim,lPrimTutari) VALUES     ('" & nStokID & "', '" & dteIslemTarihi & "', '" & nFirmaID & "', '" & nMusteriID & "', '" & sFisTipi & "', '" & dteFisTarihi & "', '" & lFisNo & "', " & nGirisCikis & ", '" & sDepo & "', '" & lReyonFisNo & "', '" & sStokIslem & "', '" & sKasiyerRumuzu & "', '" & sSaticiRumuzu & "', '" & sOdemeKodu & "', '" & dteFisTarihi & "', '" & lFisNo & "', " & lGirisMiktar1 & ", " & lGirisMiktar2 & ", " & lGirisFiyat & ", " & lGirisTutar & ", " & lCikisMiktar1 & ", " & lCikisMiktar2 & " , " & lCikisFiyat & ", " & lCikisTutar & " , '" & sFiyatTipi & "' ,'" & sBirimCinsi & "'," & lBirimMiktar & ", " & lBrutFiyat & ", " & lBrutTutar & " , " & lMaliyetFiyat & ", " & lMaliyetTutar & ", " & lIlaveMaliyetTutar & ", " & nIskontoYuzdesi & ", " & lIskontoTutari & ", '" & sDovizCinsi & "', " & lDovizFiyat & ", NULL, '" & nReceteNo & "', NULL, NULL, " & nKdvOrani & ", '" & nHesapID & "', N'" & sAciklama & "', '" & sHareketTipi & "'," & bMuhasebeyeIslendimi & ", '" & sKullaniciAdi & "', '" & dteKayitTarihi & "', '" & sDovizCinsi1 & "', " & lDovizMiktari1 & ", " & lDovizKuru1 & ", '" & sDovizCinsi2 & "', " & lDovizMiktari2 & " , " & lDovizKuru2 & ", " & nOTVOrani & ", NULL,  NULL, '" & nStokFisiID & "', '" & nStokFisiID & "', '" & sMasrafYontemi & "', '" & sHangiUygulama & "', " & nEkSaha1 & ", " & nEkSaha2 & ", " & bEkSoru1 & " , " & bEkSoru2 & ", '" & sSonKullaniciAdi & "', '" & dteSonUpdateTarihi & "'," & nPrim & "," & lPrimTutari & ")")
            ElseIf Trim(sFisTipi) = "T" Then
                cmd.CommandText = sorgu_query("SET DATEFORMAT DMY SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED INSERT INTO tbStokFisiDetayi                       (nStokID, dteIslemTarihi, nFirmaID, nMusteriID, sFisTipi, dteFisTarihi, lFisNo, nGirisCikis, sDepo, lReyonFisNo, sStokIslem, sKasiyerRumuzu, sSaticiRumuzu, sOdemeKodu, dteIrsaliyeTarihi, lIrsaliyeNo, lGirisMiktar1, lGirisMiktar2, lGirisFiyat, lGirisTutar, lCikisMiktar1, lCikisMiktar2, lCikisFiyat, lCikisTutar, sFiyatTipi, sBirimCinsi,lBirimMiktar,lBrutFiyat, lBrutTutar, lMaliyetFiyat, lMaliyetTutar, lIlaveMaliyetTutar, nIskontoYuzdesi, lIskontoTutari, sDovizCinsi, lDovizFiyat, nSiparisID, nReceteNo, nTransferID, sTransferDepo, nKdvOrani, nHesapID, sAciklama, sHareketTipi, bMuhasebeyeIslendimi, sKullaniciAdi, dteKayitTarihi, sDovizCinsi1, lDovizMiktari1, lDovizKuru1, sDovizCinsi2, lDovizMiktari2, lDovizKuru2, nOTVOrani, nTransferFirmaID, nAlisverisID, nStokFisiID, nIrsaliyeFisiID, sMasrafYontemi, sHangiUygulama, nEkSaha1, nEkSaha2, bEkSoru1, bEkSoru2, sSonKullaniciAdi, dteSonUpdateTarihi,nPrim,lPrimTutari) VALUES     ('" & nStokID & "', '" & dteIslemTarihi & "', '" & nFirmaID & "', '" & nMusteriID & "', '" & sFisTipi & "', '" & dteFisTarihi & "', '" & lFisNo & "', " & nGirisCikis & ", '" & sDepo & "', '" & lReyonFisNo & "', '" & sStokIslem & "', '" & sKasiyerRumuzu & "', '" & sSaticiRumuzu & "', '" & sOdemeKodu & "', '" & dteIrsaliyeTarihi & "', '" & lIrsaliyeNo & "', " & lGirisMiktar1 & ", " & lGirisMiktar2 & ", " & lGirisFiyat & ", " & lGirisTutar & ", " & lCikisMiktar1 & ", " & lCikisMiktar2 & " , " & lCikisFiyat & ", " & lCikisTutar & " , '" & sFiyatTipi & "' ,'" & sBirimCinsi & "'," & lBirimMiktar & ", " & lBrutFiyat & ", " & lBrutTutar & " , " & lMaliyetFiyat & ", " & lMaliyetTutar & ", " & lIlaveMaliyetTutar & ", " & nIskontoYuzdesi & ", " & lIskontoTutari & ", '" & sDovizCinsi & "', " & lDovizFiyat & ", NULL, '" & nReceteNo & "', " & nTransferID & ", '" & sTransferDepo & "', " & nKdvOrani & ", '" & nHesapID & "', N'" & sAciklama & "', '" & sHareketTipi & "'," & bMuhasebeyeIslendimi & ", '" & sKullaniciAdi & "', '" & dteKayitTarihi & "', '" & sDovizCinsi1 & "', " & lDovizMiktari1 & ", " & lDovizKuru1 & ", '" & sDovizCinsi2 & "', " & lDovizMiktari2 & " , " & lDovizKuru2 & ", " & nOTVOrani & ", " & nTransferFirmaID & ",  NULL, '" & nStokFisiID & "', NULL, '" & sMasrafYontemi & "', '" & sHangiUygulama & "', " & nEkSaha1 & ", " & nEkSaha2 & ", " & bEkSoru1 & " , " & bEkSoru2 & ", '" & sSonKullaniciAdi & "', '" & dteSonUpdateTarihi & "'," & nPrim & "," & lPrimTutari & ")")
            Else
                cmd.CommandText = sorgu_query("SET DATEFORMAT DMY SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED INSERT INTO tbStokFisiDetayi                       (nStokID, dteIslemTarihi, nFirmaID, nMusteriID, sFisTipi, dteFisTarihi, lFisNo, nGirisCikis, sDepo, lReyonFisNo, sStokIslem, sKasiyerRumuzu, sSaticiRumuzu, sOdemeKodu, dteIrsaliyeTarihi, lIrsaliyeNo, lGirisMiktar1, lGirisMiktar2, lGirisFiyat, lGirisTutar, lCikisMiktar1, lCikisMiktar2, lCikisFiyat, lCikisTutar, sFiyatTipi, sBirimCinsi,lBirimMiktar,lBrutFiyat, lBrutTutar, lMaliyetFiyat, lMaliyetTutar, lIlaveMaliyetTutar, nIskontoYuzdesi, lIskontoTutari, sDovizCinsi, lDovizFiyat, nSiparisID, nReceteNo, nTransferID, sTransferDepo, nKdvOrani, nHesapID, sAciklama, sHareketTipi, bMuhasebeyeIslendimi, sKullaniciAdi, dteKayitTarihi, sDovizCinsi1, lDovizMiktari1, lDovizKuru1, sDovizCinsi2, lDovizMiktari2, lDovizKuru2, nOTVOrani, nTransferFirmaID, nAlisverisID, nStokFisiID, nIrsaliyeFisiID, sMasrafYontemi, sHangiUygulama, nEkSaha1, nEkSaha2, bEkSoru1, bEkSoru2, sSonKullaniciAdi, dteSonUpdateTarihi,nPrim,lPrimTutari) VALUES     ('" & nStokID & "', '" & dteIslemTarihi & "', '" & nFirmaID & "', '" & nMusteriID & "', '" & sFisTipi & "', '" & dteFisTarihi & "', '" & lFisNo & "', " & nGirisCikis & ", '" & sDepo & "', '" & lReyonFisNo & "', '" & sStokIslem & "', '" & sKasiyerRumuzu & "', '" & sSaticiRumuzu & "', '" & sOdemeKodu & "', '" & dteIrsaliyeTarihi & "', '" & lIrsaliyeNo & "', " & lGirisMiktar1 & ", " & lGirisMiktar2 & ", " & lGirisFiyat & ", " & lGirisTutar & ", " & lCikisMiktar1 & ", " & lCikisMiktar2 & " , " & lCikisFiyat & ", " & lCikisTutar & " , '" & sFiyatTipi & "' ,'" & sBirimCinsi & "'," & lBirimMiktar & ", " & lBrutFiyat & ", " & lBrutTutar & " , " & lMaliyetFiyat & ", " & lMaliyetTutar & ", " & lIlaveMaliyetTutar & ", " & nIskontoYuzdesi & ", " & lIskontoTutari & ", '" & sDovizCinsi & "', " & lDovizFiyat & ", NULL, '" & nReceteNo & "', NULL, NULL, " & nKdvOrani & ", '" & nHesapID & "', N'" & sAciklama & "', '" & sHareketTipi & "'," & bMuhasebeyeIslendimi & ", '" & sKullaniciAdi & "', '" & dteKayitTarihi & "', '" & sDovizCinsi1 & "', " & lDovizMiktari1 & ", " & lDovizKuru1 & ", '" & sDovizCinsi2 & "', " & lDovizMiktari2 & " , " & lDovizKuru2 & ", " & nOTVOrani & ", NULL,  NULL, '" & nStokFisiID & "', NULL, '" & sMasrafYontemi & "', '" & sHangiUygulama & "', " & nEkSaha1 & ", " & nEkSaha2 & ", " & bEkSoru1 & " , " & bEkSoru2 & ", '" & sSonKullaniciAdi & "', '" & dteSonUpdateTarihi & "'," & nPrim & "," & lPrimTutari & ")")
            End If
            'cmd.CommandText = sorgu_query("SET DATEFORMAT DMY SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED INSERT INTO tbStokFisiDetayi                       (nIslemID,nStokID, dteIslemTarihi, nFirmaID, nMusteriID, sFisTipi, dteFisTarihi, lFisNo, nGirisCikis, sDepo, lReyonFisNo, sStokIslem, sKasiyerRumuzu, sSaticiRumuzu, sOdemeKodu, dteIrsaliyeTarihi, lIrsaliyeNo, lGirisMiktar1, lGirisMiktar2, lGirisFiyat, lGirisTutar, lCikisMiktar1, lCikisMiktar2, lCikisFiyat, lCikisTutar, sFiyatTipi, lBrutFiyat, lBrutTutar, lMaliyetFiyat, lMaliyetTutar, lIlaveMaliyetTutar, nIskontoYuzdesi, lIskontoTutari, sDovizCinsi, lDovizFiyat, nSiparisID, nReceteNo, nTransferID, sTransferDepo, nKdvOrani, nHesapID, sAciklama, sHareketTipi, bMuhasebeyeIslendimi, sKullaniciAdi, dteKayitTarihi, sDovizCinsi1, lDovizMiktari1, lDovizKuru1, sDovizCinsi2, lDovizMiktari2, lDovizKuru2, nOTVOrani, nTransferFirmaID, nAlisverisID, nStokFisiID, nIrsaliyeFisiID, sMasrafYontemi, sHangiUygulama, nEkSaha1, nEkSaha2, bEkSoru1, bEkSoru2, sSonKullaniciAdi, dteSonUpdateTarihi) VALUES     (" & nIslemID & " ,'" & nStokID & "', '" & dteIslemTarihi & "', '" & nFirmaID & "', '" & nMusteriID & "', '" & sFisTipi & "', '" & dteFisTarihi & "', '" & lFisNo & "', " & nGirisCikis & ", '" & sDepo & "', '" & lReyonFisNo & "', '" & sStokIslem & "', '" & sKasiyerRumuzu & "', '" & sSaticiRumuzu & "', '" & sOdemeKodu & "', '" & dteIrsaliyeTarihi & "', '" & lIrsaliyeNo & "', " & lGirisMiktar1 & ", " & lGirisMiktar2 & ", " & lGirisFiyat & ", " & lGirisTutar & ", " & lCikisMiktar1 & ", " & lCikisMiktar2 & " , " & lCikisFiyat & ", " & lCikisTutar & " , '" & sFiyatTipi & "' , " & lBrutFiyat & ", " & lBrutTutar & " , " & lMaliyetFiyat & ", " & lMaliyetTutar & ", " & lIlaveMaliyetTutar & ", " & nIskontoYuzdesi & ", " & lIskontoTutari & ", '" & sDovizCinsi & "', " & lDovizFiyat & ", NULL, '" & nReceteNo & "', NULL, NULL, " & nKdvOrani & ", '" & nHesapID & "', N'" & sAciklama & "', '" & sHareketTipi & "'," & bMuhasebeyeIslendimi & ", '" & sKullaniciAdi & "', '" & dteKayitTarihi & "', '" & sDovizCinsi1 & "', " & lDovizMiktari1 & ", " & lDovizKuru1 & ", '" & sDovizCinsi2 & "', " & lDovizMiktari2 & " , " & lDovizKuru2 & ", " & nOTVOrani & ", NULL,  NULL, '" & nStokFisiID & "', NULL, '" & sMasrafYontemi & "', '" & sHangiUygulama & "', " & nEkSaha1 & ", " & nEkSaha2 & ", " & bEkSoru1 & " , " & bEkSoru2 & ", '" & sSonKullaniciAdi & "', '" & dteSonUpdateTarihi & "')")
        End If
        cmd.ExecuteNonQuery()
        cmd.CommandText = "SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT @@identity"
        nIslemID = cmd.ExecuteScalar
        Return nIslemID
        con.Close()
        con.Dispose()
        cmd.Dispose()
        con = Nothing
        cmd = Nothing
    End Function
    Private Sub BarButtonItem44_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem44.ItemClick
        ' Onaysiz siparis belgelestirilemez - tbParamAlSiparis.bOnayVar parametresine gore kontrol
        Try
            ' Onay zorunlulugu parametresini kontrol et
            Dim dtParamOnay As DataTable = SQLCalistir("SELECT ISNULL(bOnayVar, 0) AS bOnayVar FROM tbParamAlSiparis")
            Dim bOnayVar As Boolean = False
            
            If dtParamOnay.Rows.Count > 0 Then
                bOnayVar = Convert.ToBoolean(dtParamOnay.Rows(0)("bOnayVar"))
            End If
            
            ' Eger bOnayVar = TRUE ise onay kontrolu yap
            If bOnayVar Then
                Dim dtOnay As DataTable = SQLCalistir("SELECT ISNULL(bOnay, 0) AS bOnay FROM tbSiparis WHERE lSiparisNo = " & lSiparisNo & " AND nFirmaID = " & nFirmaID)
                If dtOnay.Rows.Count = 0 OrElse Convert.ToInt32(dtOnay.Rows(0)("bOnay")) = 0 Then
                    MessageBox.Show("Onay verilmeyen siparis belgelestirilemez." & vbCrLf & vbCrLf & _
                        "Siparis No: " & lSiparisNo & vbCrLf & _
                        "Lutfen once siparisi onaylayin.", "Onay Gerekli", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                    Exit Sub
                End If
            End If
            ' bOnayVar = FALSE ise onay kontrolu yapilmadan devam edilir
        Catch ex As Exception
            MessageBox.Show("Onay kontrolu hatasi: " & ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End Try
        If lSevkiyatHesapla() > 0 Then
            Dim frm As New frm_stok_cari_alis_aciklama
            frm.txt_tarih.EditValue = dteSistemTarihi
            frm.txt_belgeno.EditValue = sorgu_lFisNo(dr_baslik("nFirmaID"), "IS", 3, sDepo)
            Dim sFisTipi As String = ""
            If frm.ShowDialog(Me) = Windows.Forms.DialogResult.OK Then
                fis_faturala("IS", frm.txt_tarih.EditValue, 3, frm.txt_belgeno.EditValue, dr_baslik("nFirmaID"), True)
            End If
        Else
            XtraMessageBox.Show(Sorgu_sDil("Faturalaştırılacak Sipariş Bulunamadı...!", sDil), Sorgu_sDil("Dikkat", sDil))
        End If
    End Sub
    Private Sub BarButtonItem26_ItemClick_1(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem26.ItemClick
        ' Onaysiz siparis belgelestirilemez - tbParamAlSiparis.bOnayVar parametresine gore kontrol
        Try
            ' Onay zorunlulugu parametresini kontrol et
            Dim dtParamOnay As DataTable = SQLCalistir("SELECT ISNULL(bOnayVar, 0) AS bOnayVar FROM tbParamAlSiparis")
            Dim bOnayVar As Boolean = False
            
            If dtParamOnay.Rows.Count > 0 Then
                bOnayVar = Convert.ToBoolean(dtParamOnay.Rows(0)("bOnayVar"))
            End If
            
            ' Eger bOnayVar = TRUE ise onay kontrolu yap
            If bOnayVar Then
                Dim dtOnay As DataTable = SQLCalistir("SELECT ISNULL(bOnay, 0) AS bOnay FROM tbSiparis WHERE lSiparisNo = " & lSiparisNo & " AND nFirmaID = " & nFirmaID)
                If dtOnay.Rows.Count = 0 OrElse Convert.ToInt32(dtOnay.Rows(0)("bOnay")) = 0 Then
                    MessageBox.Show("Onay verilmeyen siparis belgelestirilemez." & vbCrLf & vbCrLf & _
                        "Siparis No: " & lSiparisNo & vbCrLf & _
                        "Lutfen once siparisi onaylayin.", "Onay Gerekli", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                    Exit Sub
                End If
            End If
            ' bOnayVar = FALSE ise onay kontrolu yapilmadan devam edilir
        Catch ex As Exception
            MessageBox.Show("Onay kontrolu hatasi: " & ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End Try
        If lSevkiyatHesapla() > 0 Then
            Dim frm As New frm_stok_cari_alis_aciklama
            Dim sFisTipi As String = ""
            Dim nGirisCikis As String = ""
            If nSiparisTipi = 1 Then
                sFisTipi = "FS"
                nGirisCikis = "3"
            ElseIf nSiparisTipi = 2 Then
                sFisTipi = "FA"
                nGirisCikis = "1"
            ElseIf nSiparisTipi = 3 Then
                sFisTipi = "FA"
                nGirisCikis = "1"
            ElseIf nSiparisTipi = 4 Then
                sFisTipi = "FS"
                nGirisCikis = "3"
            End If

            ' Form varsayılan değerlerini set et
            frm.txt_tarih.EditValue = dteSistemTarihi
            frm.txt_belgeno.EditValue = sorgu_lFisNo(dr_baslik("nFirmaID"), sFisTipi, nGirisCikis, sDepo)

            ' Formdan onay alınırsa fatura oluştur
            If frm.ShowDialog(Me) = Windows.Forms.DialogResult.OK Then
                fis_faturala(sFisTipi, frm.txt_tarih.EditValue, nGirisCikis, frm.txt_belgeno.EditValue, dr_baslik("nFirmaID"))
            End If
        Else
            XtraMessageBox.Show(Sorgu_sDil("Sevkedilecek Sipariş Bulunamadı...!", sDil), Sorgu_sDil("Dikkat", sDil))
        End If
    End Sub
    Private Sub BarButtonItem25_ItemClick_1(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem25.ItemClick
        ' Onaysiz siparis belgelestirilemez - tbParamAlSiparis.bOnayVar parametresine gore kontrol
        Try
            ' Onay zorunlulugu parametresini kontrol et
            Dim dtParamOnay As DataTable = SQLCalistir("SELECT ISNULL(bOnayVar, 0) AS bOnayVar FROM tbParamAlSiparis")
            Dim bOnayVar As Boolean = False
            
            If dtParamOnay.Rows.Count > 0 Then
                bOnayVar = Convert.ToBoolean(dtParamOnay.Rows(0)("bOnayVar"))
            End If
            
            ' Eger bOnayVar = TRUE ise onay kontrolu yap
            If bOnayVar Then
                Dim dtOnay As DataTable = SQLCalistir("SELECT ISNULL(bOnay, 0) AS bOnay FROM tbSiparis WHERE lSiparisNo = " & lSiparisNo & " AND nFirmaID = " & nFirmaID)
                If dtOnay.Rows.Count = 0 OrElse Convert.ToInt32(dtOnay.Rows(0)("bOnay")) = 0 Then
                    MessageBox.Show("Onay verilmeyen siparis belgelestirilemez." & vbCrLf & vbCrLf & _
                        "Siparis No: " & lSiparisNo & vbCrLf & _
                        "Lutfen once siparisi onaylayin.", "Onay Gerekli", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                    Exit Sub
                End If
            End If
            ' bOnayVar = FALSE ise onay kontrolu yapilmadan devam edilir
        Catch ex As Exception
            MessageBox.Show("Onay kontrolu hatasi: " & ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End Try
        If lSevkiyatHesapla() > 0 Then
            Dim frm As New frm_stok_cari_alis_aciklama
            Dim sFisTipi As String = ""
            Dim nGirisCikis As String = ""

            ' Sipariş tipine göre fiş tipi ve giriş/çıkış belirle
            If nSiparisTipi = 1 Then
                sFisTipi = "IS"
                nGirisCikis = "3"
            ElseIf nSiparisTipi = 2 Then
                sFisTipi = "IA"
                nGirisCikis = "1"
            ElseIf nSiparisTipi = 3 Then
                sFisTipi = "IA"
                nGirisCikis = "1"
            ElseIf nSiparisTipi = 4 Then
                sFisTipi = "IS"
                nGirisCikis = "3"
            End If

            ' Form varsayılan değerlerini set et
            frm.txt_tarih.EditValue = dteSistemTarihi
            frm.txt_belgeno.EditValue = sorgu_lFisNo(dr_baslik("nFirmaID"), sFisTipi, nGirisCikis, sDepo)

            ' Formdan onay alınırsa fatura oluştur
            If frm.ShowDialog(Me) = Windows.Forms.DialogResult.OK Then
                fis_faturala(sFisTipi, frm.txt_tarih.EditValue, nGirisCikis, frm.txt_belgeno.EditValue, dr_baslik("nFirmaID"))
            End If
        Else
            XtraMessageBox.Show(Sorgu_sDil("Sevkedilecek Sipariş Bulunamadı...!", sDil), Sorgu_sDil("Dikkat", sDil))
        End If
    End Sub
    Private Sub BarButtonItem16_ItemClick_1(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem16.ItemClick
        If XtraMessageBox.Show(dr_baslik("lSiparisNo") & " Nolu Fişi " & dr_baslik("sAciklama").ToString & Sorgu_sDil(" Hesabına Belgeleştirmeye Başlamak İstediğinize Emin misiniz...?", sDil), Sorgu_sDil("Dikkat", sDil), MessageBoxButtons.YesNo, MessageBoxIcon.Question) = MsgBoxResult.Yes Then
            Dim enSiparisTipi = nSiparisTipi
            Dim edteFisTarihi = dr_baslik("dteSiparisTarihi")
            Dim dteSiparisTarihi = dr_baslik("dteSiparisTarihi")
            Dim elSiparisNo = lSiparisNo
            Dim enFirmaID = nFirmaID
            nFirmaID = nFirmaID
            lSiparisNo = sorgu_lSiparisNo()
            If nSiparisTipi = 3 Or nSiparisTipi = 2 Or nSiparisTipi = 4 Then
                nSiparisTipi = 1
            ElseIf nSiparisTipi = 1 Then
                nSiparisTipi = 2
            End If
            'nSiparisTipi = frm.sec_sFisTipi.EditValue
            dteSiparisTarihi = Today
            Dim dr As DataRow
            For Each dr In ds_tbSiparis.Tables(0).Rows
                Dim nSiparisID As Int64 = sorgu_nSiparisID()
                'Bul
                nSiparisID = tbSiparis_kaydet_yeni(nSiparisID, nSiparisTipi, lSiparisNo, nFirmaID, dr("nStokID"), dr("dteSiparisTarihi"), dr("dteTeslimTarihi"), dr("sSiparisIslem"), dr("nReceteNo"), dr("sSiparisiAlan"), dr("sSiparisiVeren"), dr("sFiyatTipi"), dr("lMiktari"), dr("lBrutFiyat"), dr("lTutari"), dr("sAsortiTipi"), dr("sAsortiMiktari"), dr("nKdvOrani"), dr("nIskontoYuzdesi"), dr("lBrutTutar"), kullaniciadi, Now, 0, dr("lReserveMiktari"), dr("sHangiUygulama"), dr("nPartiID"), dr("sSatirAciklama"), dr("nValorGun"), dr("sDovizCinsi"), dr("lDovizFiyati"), dr("lDovizKuru"), dr("sSaticiRumuzu"), dr("sDepo"), dr("sBirimCinsi"), dr("lBirimMiktar"), dr("sAmbalaj"))
            Next
            tbSiparis_Aciklamasi_kaydet_yeni(nSiparisTipi, lSiparisNo, nFirmaID, dr_baslik("sAciklama1").ToString, dr_baslik("sAciklama2").ToString, dr_baslik("sAciklama3").ToString, dr_baslik("sAciklama4").ToString, dr_baslik("sAciklama5").ToString, 0)
            dr = Nothing
            dr_baslik("sAciklama5") = Sorgu_sDil("Siparişe Aktarıldı", sDil)
            tbSiparis_Aciklamasi_kaydet_yeni(dr_baslik("nSiparisTipi"), dr_baslik("lSiparisNo"), dr_baslik("nFirmaID"), dr_baslik("sAciklama1").ToString, dr_baslik("sAciklama2").ToString, dr_baslik("sAciklama3").ToString, dr_baslik("sAciklama4").ToString, dr_baslik("sAciklama5").ToString, dr_baslik("bKilitli"))
            tbSiparis_Aciklamasi_kaydet_duzelt(dr_baslik("nSiparisTipi"), dr_baslik("lSiparisNo"), dr_baslik("nFirmaID"), dr_baslik("sAciklama1").ToString, dr_baslik("sAciklama2").ToString, dr_baslik("sAciklama3").ToString, dr_baslik("sAciklama4").ToString, dr_baslik("sAciklama5").ToString, dr_baslik("bKilitli"), dr_baslik("bListelendimi"))
            'Fişi Göster
            Dim fm As New frm_tbSiparis
            fm.firmano = firmano
            fm.donemno = donemno
            fm.connection = connection
            fm.dteSiparisTarihi = dteSiparisTarihi
            fm.lSiparisNo = lSiparisNo
            fm.nFirmaID = nFirmaID
            'frm.txt_musteriNo.EditValue = dr("sFirmaKodu")
            fm.sSiparisiAlan = ""
            fm.sSiparisiVeren = ""
            fm.nSiparisTipi = nSiparisTipi
            fm.kullanici = kullanici
            fm.islemstatus = True
            fm.Text = "Siparis#Belgele"
            If yetki_kontrol(kullanici, fm.Name) = True Then
                fm.ShowDialog()
            End If
            fm.Close()
            fm.Dispose()
            fm = Nothing
            'Eski Tanımları Geri Getir
            nSiparisTipi = enSiparisTipi
            dteSiparisTarihi = edteFisTarihi
            lSiparisNo = elSiparisNo
            nFirmaID = enFirmaID
        End If
    End Sub
    Private Sub btn_SaticiBelirle_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btn_SaticiBelirle.ItemClick
        sSaticiRumuzu_toplu()
    End Sub
    Private Sub SatırDeğiştirToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SatırDeğiştirToolStripMenuItem.Click
        satir_degistir()
    End Sub
    Private Sub BarButtonItem46_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem46.ItemClick
        If BarButtonItem46.Down = False Then
            GridView1.ClearColumnsFilter()
            GridView1.Columns("lSevkiyat").FilterInfo = New ColumnFilterInfo("[lSevkiyat] > 0 ")
            BarButtonItem46.Down = True
        Else
            GridView1.ClearColumnsFilter()
            BarButtonItem46.Down = False
        End If
    End Sub
    Private Sub BarButtonItem47_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem47.ItemClick
        If BarButtonItem47.Down = False Then
            GridView1.ClearColumnsFilter()
            GridView1.Columns("lSevkiyat").FilterInfo = New ColumnFilterInfo("[lSevkiyat] = 0 ")
            BarButtonItem47.Down = True
        Else
            GridView1.ClearColumnsFilter()
            BarButtonItem47.Down = False
        End If
    End Sub
    Private Sub BarButtonItem48_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem48.ItemClick
        If BarButtonItem46.Down = False Then
            GridView1.ClearColumnsFilter()
            GridView1.Columns("lSevkiyat").FilterInfo = New ColumnFilterInfo("[lSevkiyat] <> [lMiktari] ")
            BarButtonItem46.Down = True
        Else
            GridView1.ClearColumnsFilter()
            BarButtonItem46.Down = False
        End If
    End Sub
    Private Sub BarButtonItem49_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem49.ItemClick
        Try
            loaded()
        Catch ex As Exception
            XtraMessageBox.Show(Sorgu_sDil("Hatalı Islem, Lütfen Tekrar Deneyiniz...!", sDil), Sorgu_sDil("Dikkat", sDil), MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End Try
    End Sub
    Private Sub BarButtonItem50_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem50.ItemClick
        gorunum_yazdir()
    End Sub
    Private Sub BarButtonItem51_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem51.ItemClick
        firma_degistir()
    End Sub
    Private Sub firma_degistir()
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
            Dim FirmaID As Int64 = dr1("nFirmaID")
            Dim cmd As New OleDb.OleDbCommand
            Dim con As New OleDb.OleDbConnection
            cmd.CommandTimeout = Nothing
            cmd.Connection = con
            con.ConnectionString = connection
            cmd.CommandTimeout = Nothing
            If con.State = ConnectionState.Closed = True Then
                con.Open()
            End If
            cmd.CommandText = sorgu_query("set implicit_transactions on")
            cmd.ExecuteNonQuery()
            Try
                cmd.CommandText = sorgu_query("SET DATEFORMAT DMY SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED Update tbSiparisAciklamasi set nFirmaID = " & FirmaID & " WHERE     nSiparisTipi = " & dr_baslik("nSiparisTipi") & " and lSiparisNo = " & dr_baslik("lSiparisNo") & " and nFirmaID = " & dr_baslik("nFirmaID") & "")
                cmd.ExecuteNonQuery()
                cmd.CommandText = sorgu_query("SET DATEFORMAT DMY SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED Update tbSiparis set nFirmaID = " & FirmaID & " WHERE     nSiparisTipi = " & dr_baslik("nSiparisTipi") & " and lSiparisNo = " & dr_baslik("lSiparisNo") & " and nFirmaID = " & dr_baslik("nFirmaID") & "")
                cmd.ExecuteNonQuery()
                cmd.CommandText = sorgu_query("IF @@TRANCOUNT > 0 COMMIT TRAN")
                cmd.ExecuteNonQuery()
                dr_baslik("nFirmaID") = nFirmaID
            Catch ex As Exception
                cmd.CommandText = sorgu_query("IF @@TRANCOUNT > 0 COMMIT TRAN")
                cmd.ExecuteNonQuery()
                nFirmaID = dr_baslik("nFirmaID")
                XtraMessageBox.Show(Sorgu_sDil("İşlem Hatası Lütfen Tekrar Deneyiniz...", sDil), Sorgu_sDil("Dikkat", sDil), MessageBoxButtons.OK, MessageBoxIcon.Warning)
            End Try
            cmd.CommandText = sorgu_query("set implicit_transactions off")
            cmd.ExecuteNonQuery()
            con.Close()
            con.Dispose()
            cmd.Dispose()
            con = Nothing
            cmd = Nothing
            dr1 = Nothing
            nSiparisTipi = dr_baslik("nSiparisTipi")
            lSiparisNo = dr_baslik("lSiparisNo")
            nFirmaID = FirmaID
            dteSiparisTarihi = dr_baslik("dteSiparisTarihi")
            loaded()
        End If
    End Sub
    Private Sub tutaragore_miktarhesapla()
        Dim frm As New frm_calc
        frm.Text = "Tutara Göre MiktarHesapla..."
        'frm.status = False
        If frm.ShowDialog() = Windows.Forms.DialogResult.OK Then
            If frm.CalcEdit1.EditValue <> 0 Then
                Dim dr As DataRow = GridView1.GetDataRow(GridView1.FocusedRowHandle)
                dr("lBrutTutar") = frm.CalcEdit1.EditValue
                dr("Miktar") = dr("lBrutTutar") / dr("lFiyat")
                dr = Nothing
                GridView1.FocusedColumn = collBrutFiyat
                tutar_hesapla()
            End If
        End If
        frm.Close()
        frm = Nothing
    End Sub
    Private Sub SiparisOnayla(ByVal nSiparisID As Integer, ByVal nFirmaID As Integer)
        ' =============================================
        ' SIPARIS ONAY AKISI - GUNCELLENMIS VERSIYON
        ' tbParamAlSiparis.bReceteVarmi = FALSE ise uretim kontrolleri atlanir
        ' bReceteVarmi = TRUE ise:
        ' 1. Stok yetersizse -> Uretim emri sor
        ' 2. Recete yoksa -> Bildirim gonder, ONAYLAMA
        ' 3. Yari mamul yetersizse -> Satin alma sor, URETIM EMRI OLUSTURMA
        ' 4. Yari mamul yeterliyse -> Uretim emri olustur
        ' 5. Uretim tamamlanmadan siparis ONAYLANMAZ
        ' =============================================
        
        ' ===== YETKI KONTROLU: frm_tbSiparis_Onay =====
        If yetki_kontrol(kullanici, "frm_tbSiparis_Onay") = False Then
            MessageBox.Show("Siparis onaylama yetkiniz bulunmamaktadir." & vbCrLf & vbCrLf & _
                "Gerekli Yetki: frm_tbSiparis_Onay", "Yetki Hatasi", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If
        
        ' ===== PARAMETRE KONTROLU: bReceteVarmi (EN BASTA) =====
        Dim dtParamRecete As DataTable = SQLCalistir("SELECT ISNULL(bReceteVarmi, 0) AS bReceteVarmi FROM tbParamAlSiparis")
        Dim bReceteVarmiParam As Boolean = False
        
        If dtParamRecete.Rows.Count > 0 Then
            bReceteVarmiParam = Convert.ToBoolean(dtParamRecete.Rows(0)("bReceteVarmi"))
        End If
        
        ' Eger bReceteVarmi = FALSE ise uretim kontrollerini atla, direkt onayla
        If Not bReceteVarmiParam Then
            ' Sadece temel kontroller (zaten onayli mi?)
            Dim dtOnayBasit As DataTable = SQLCalistir("SELECT ISNULL(bOnay, 0) AS bOnay FROM tbSiparis WHERE lSiparisNo = " & lSiparisNo & " AND nFirmaID = " & nFirmaID)
            If dtOnayBasit.Rows.Count > 0 AndAlso Convert.ToInt32(dtOnayBasit.Rows(0)("bOnay")) = 1 Then
                MessageBox.Show("Bu siparis daha once onaylanmis.", "Uyari", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Exit Sub
            End If
            
            ' Direkt siparisi onayla (uretim kontrolleri olmadan)
            SQLCalistir("UPDATE tbSiparis SET bOnay = 1, bOnaylandi = 1, bKilitli = 1, sDurum = 'Onaylandi', nOnaylayanID = " & kullanici & ", dteOnayTarihi = GETDATE() WHERE lSiparisNo = " & lSiparisNo & " AND nFirmaID = " & nFirmaID)
            MessageBox.Show("Siparis basariyla onaylandi." & vbCrLf & vbCrLf & _
                "Siparis No: " & lSiparisNo, _
                "Siparis Onaylandi", MessageBoxButtons.OK, MessageBoxIcon.Information)
            loaded()
            Exit Sub
        End If
        
        ' bReceteVarmi = TRUE - Normal uretim kontrollu akis devam eder
        
        ' 1. Zaten onayli mi veya islem yapilmis mi?
        Dim dtOnay As DataTable = SQLCalistir("SELECT ISNULL(bOnay, 0) AS bOnay, ISNULL(bKilitli, 0) AS bKilitli, ISNULL(sDurum, '') AS sDurum FROM tbSiparis WHERE lSiparisNo = " & lSiparisNo & " AND nFirmaID = " & nFirmaID)
        If dtOnay.Rows.Count > 0 Then
            If Convert.ToInt32(dtOnay.Rows(0)("bOnay")) = 1 Then
                MessageBox.Show("Bu siparis daha once onaylanmis.", "Uyari", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Exit Sub
            End If
            If Convert.ToInt32(dtOnay.Rows(0)("bKilitli")) = 1 Then
                MessageBox.Show("Bu siparis kilitli, degisiklik yapilamaz.", "Uyari", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Exit Sub
            End If
            
            ' DAHA ONCE URETIM EMRI VEYA SATINALMA YAPILDI MI?
            Dim sDurum As String = dtOnay.Rows(0)("sDurum").ToString()
            If sDurum = "UretimBekliyor" OrElse sDurum = "SatinAlmaBekliyor" OrElse sDurum = "ReceteEksik" Then
                MessageBox.Show("Bu siparis icin daha once islem yapildi:" & vbCrLf & vbCrLf & _
                    "Durum: " & sDurum & vbCrLf & vbCrLf & _
                    "Ayni siparis icin tekrar uretim emri veya satinalma siparisi olusturulamaz." & vbCrLf & _
                    "Siparis onaylanamaz, islemlerin tamamlanmasini bekleyin.", _
                    "Islem Zaten Yapildi", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Exit Sub
            End If
        End If
        
        Dim bTumStokYeterli As Boolean = True
        Dim bUretimEmriOlusturuldu As Boolean = False
        Dim bSatinAlmaOlusturuldu As Boolean = False
        Dim eksikYariMamulListesi As New List(Of String)
        
        ' 2. Siparis kalemleri
        Dim dtKalem As DataTable = SQLCalistir("SELECT nSiparisID, nStokID, lMiktari, sDepo FROM tbSiparis WHERE lSiparisNo = " & lSiparisNo & " AND nFirmaID = " & nFirmaID)
        
        For Each dr As DataRow In dtKalem.Rows
            Dim nStokID As Integer = Convert.ToInt32(dr("nStokID"))
            Dim sipMiktar As Decimal = Convert.ToDecimal(dr("lMiktari"))
            Dim sDepo As String = dr("sDepo").ToString()
            
            ' 3. Stok bilgisi al
            Dim dtStokBilgi As DataTable = SQLCalistir("SELECT sKodu, sAciklama FROM tbStok WHERE nStokID = " & nStokID)
            Dim sStokKodu As String = If(dtStokBilgi.Rows.Count > 0, dtStokBilgi.Rows(0)("sKodu").ToString(), "")
            Dim sStokAdi As String = If(dtStokBilgi.Rows.Count > 0, dtStokBilgi.Rows(0)("sAciklama").ToString(), "")
            
            ' 4. Fiziksel stok + Uretimdeki miktar
            Dim dtStok As DataTable = SQLCalistir("SELECT ISNULL(SUM(ISNULL(lGirisMiktar1,0)),0) - ISNULL(SUM(ISNULL(lCikisMiktar1,0)),0) AS Mevcut FROM tbStokFisiDetayi WHERE nStokID = " & nStokID & " AND sDepo = '" & sDepo & "'")
            Dim mevcutFiziksel As Decimal = If(dtStok.Rows.Count > 0, Convert.ToDecimal(dtStok.Rows(0)("Mevcut")), 0)
            
            Dim dtUretimde As DataTable = SQLCalistir("SELECT ISNULL(SUM(MIKTAR), 0) AS Uretimde FROM TBLUREURETIM WHERE STOKNO = " & nStokID & " AND DURUM IN ('Planlandi', 'Devam')")
            Dim mevcutUretimde As Decimal = If(dtUretimde.Rows.Count > 0, Convert.ToDecimal(dtUretimde.Rows(0)("Uretimde")), 0)
            
            Dim toplamMevcut As Decimal = mevcutFiziksel + mevcutUretimde
            
            ' ===== STOK YETERLI MI? =====
            If sipMiktar <= toplamMevcut Then
                Continue For ' Bu kalem icin stok yeterli, sonrakine gec
            End If
            
            ' STOK YETERSIZ!
            bTumStokYeterli = False
            Dim eksik As Decimal = sipMiktar - toplamMevcut
            
            ' ===== PARAMETRE KONTROLU: bReceteVarmi =====
            ' tbParamAlsiparis tablosundan parametre kontrolu
            Dim dtParam As DataTable = SQLCalistir("SELECT ISNULL(bReceteVarmi, 0) AS bReceteVarmi FROM tbParamAlsiparis")
            Dim bReceteVarmi As Boolean = False
            
            If dtParam.Rows.Count > 0 Then
                bReceteVarmi = Convert.ToBoolean(dtParam.Rows(0)("bReceteVarmi"))
            End If
            
            ' Eger bReceteVarmi = FALSE ise, uretim emri verme, direkt devam et
            If Not bReceteVarmi Then
                ' Recete kontrolu DEVRE DISI - Stok yetersiz ama devam ediliyor
                Debug.WriteLine("bReceteVarmi = FALSE - Uretim emri verilmiyor, siparis onaylanacak")
                MessageBox.Show( _
                    "BILGILENDIRME" & vbCrLf & vbCrLf & _
                    "Urun: " & sStokKodu & " - " & sStokAdi & vbCrLf & _
                    "Siparis Miktari: " & sipMiktar.ToString("N2") & vbCrLf & _
                    "Mevcut Toplam: " & toplamMevcut.ToString("N2") & vbCrLf & _
                    "Eksik Miktar: " & eksik.ToString("N2"), _
                    "Stok Yetersiz - Devam Ediliyor", MessageBoxButtons.OK, MessageBoxIcon.Information)
                
                Continue For ' Bu kalem icin uretim emri vermeden devam et
            End If
            
            ' bReceteVarmi = TRUE ise normal akis devam eder
            ' KULLANICIYA SOR: Uretim emri vermek istiyor musunuz?
            Dim sorUretim = MessageBox.Show( _
                "STOK YETERSIZ!" & vbCrLf & vbCrLf & _
                "Urun: " & sStokKodu & " - " & sStokAdi & vbCrLf & _
                "Siparis Miktari: " & sipMiktar.ToString("N2") & vbCrLf & _
                "Mevcut Toplam: " & toplamMevcut.ToString("N2") & vbCrLf & _
                "  - Fiziksel: " & mevcutFiziksel.ToString("N2") & vbCrLf & _
                "  - Uretimde: " & mevcutUretimde.ToString("N2") & vbCrLf & _
                "Eksik Miktar: " & eksik.ToString("N2") & vbCrLf & vbCrLf & _
                "URETIM EMRI VERMEK ISTIYOR MUSUNUZ?", _
                "Stok Yetersiz - Uretim Emri", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question)
            
            If sorUretim = DialogResult.Cancel Then
                MessageBox.Show("Siparis onayi iptal edildi.", "Iptal", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Exit Sub
            ElseIf sorUretim = DialogResult.No Then
                MessageBox.Show("Stok yetersiz oldugu icin bu kalem icin siparis onaylanamaz." & vbCrLf & _
                    "Urun: " & sStokKodu & " - " & sStokAdi, "Siparis Onaylanamaz", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Exit Sub ' SIPARIS ONAYLANMAZ
            End If
            
            ' Kullanici EVET dedi - RECETE KONTROLU
            ' Oncelikle TBLURERECETELIST'ten recete basligi kontrol et
            Dim dtReceteBaslik As DataTable = SQLCalistir("SELECT IND FROM TBLURERECETELIST WHERE STOKNO = " & nStokID)
            
            If dtReceteBaslik.Rows.Count = 0 Then
                ' RECETE YOK
                MessageBox.Show( _
                    "URETIM RECETESI BULUNAMADI!" & vbCrLf & vbCrLf & _
                    "Urun: " & sStokKodu & " - " & sStokAdi & vbCrLf & _
                    "Stok Kodu: " & sStokKodu & vbCrLf & vbCrLf & _
                    "Uretim emri olusturulamaz." & vbCrLf & _
                    "Uretim departmanina uretim recetesi olusturmasi icin bilgi veriniz." & vbCrLf & vbCrLf & _
                    "Uretim yetkilisine bildirim gonderilecek." & vbCrLf & _
                    "SIPARIS ONAYLANAMAZ!", _
                    "Recete Bulunamadi", MessageBoxButtons.OK, MessageBoxIcon.Error)
                
                ' DURUMU GUNCELLE - RECETE EKSIK
                SQLCalistir("UPDATE tbSiparis SET sDurum = 'ReceteEksik' WHERE lSiparisNo = " & lSiparisNo & " AND nFirmaID = " & nFirmaID)
                
                ' Uretim yetkililerine bildirim gonder
                Try
                    Dim sBildirimMesaj As String = "URETIM RECETESI EKSIK - ACIL OLUSTURULMALI!" & vbCrLf & vbCrLf & _
                        "Stok Kodu: " & sStokKodu & vbCrLf & _
                        "Stok Adi: " & sStokAdi & vbCrLf & _
                        "Siparis No: " & lSiparisNo & vbCrLf & _
                        "Gerekli Miktar: " & eksik.ToString("N2") & vbCrLf & vbCrLf & _
                        "Lutfen uretim recetesi olusturunuz!"
                    BildirimServisi.Broadcast("URETIM_RECETE_EKSIK", sBildirimMesaj, "Uretim Recetesi Eksik")
                Catch
                End Try
                
                Exit Sub ' SIPARIS ONAYLANMAZ
            End If
            
            ' Recete IND degerini al ve hammadde detaylarini getir
            Dim nReceteIND As Integer = Convert.ToInt32(dtReceteBaslik.Rows(0)("IND"))
            ' NOT: TBLURERECETE tablosunda hammadde stok ID'si STOKNO sutununda tutuluyor
            ' STOKNO <> 0 kontrolu - negatif degerler de olabilir (buyuk sayilar)
            Dim dtRecete As DataTable = SQLCalistir("SELECT STOKNO, MIKTAR FROM TBLURERECETE WHERE EVRAKNO = " & nReceteIND & " AND STOKNO IS NOT NULL AND STOKNO <> 0")
            
            ' DEBUG: Recete bilgisi
            If dtRecete.Rows.Count = 0 Then
                MessageBox.Show("UYARI: Recete detayi bos!" & vbCrLf & vbCrLf & _
                    "Recete IND: " & nReceteIND & vbCrLf & _
                    "TBLURERECETE tablosunda bu EVRAKNO icin hammadde kaydi bulunamadi." & vbCrLf & vbCrLf & _
                    "Lutfen uretim recetesinde hammadde/yari mamul tanimlayin.", "Recete Detayi Bos", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Exit Sub
            End If
            
            ' ===== RECETE VAR - YARI MAMUL KONTROLU =====
            Dim eksikYariMamullerBuKalem As New List(Of String)
            Dim bYariMamulYeterli As Boolean = True
            
            For Each rowHM As DataRow In dtRecete.Rows
                Dim hmStokID As Integer = Convert.ToInt32(rowHM("STOKNO"))
                Dim hmBirimMiktar As Decimal = Convert.ToDecimal(rowHM("MIKTAR"))
                Dim hmGerekli As Decimal = hmBirimMiktar * eksik
                
                ' Yari mamul stok kontrolu
                Dim dtHMStok As DataTable = SQLCalistir("SELECT ISNULL(SUM(ISNULL(lGirisMiktar1,0)),0) - ISNULL(SUM(ISNULL(lCikisMiktar1,0)),0) AS Mevcut FROM tbStokFisiDetayi WHERE nStokID = " & hmStokID)
                Dim hmMevcut As Decimal = If(dtHMStok.Rows.Count > 0, Convert.ToDecimal(dtHMStok.Rows(0)("Mevcut")), 0)
                
                If hmGerekli > hmMevcut Then
                    bYariMamulYeterli = False
                    Dim hmEksik As Decimal = hmGerekli - hmMevcut
                    
                    ' Yari mamul bilgisi - Renk, Beden, Kavala dahil
                    Dim dtHMBilgi As DataTable = SQLCalistir("SELECT s.sKodu, s.sAciklama, ISNULL(r.sRenkAdi, '') AS sRenkAdi, ISNULL(s.sBeden, '') AS sBeden, ISNULL(s.sKisaAdi, '') AS sKisaAdi FROM tbStok s LEFT JOIN tbRenk r ON s.sRenk = r.sRenk WHERE s.nStokID = " & hmStokID)
                    Dim hmKodu As String = If(dtHMBilgi.Rows.Count > 0, dtHMBilgi.Rows(0)("sKodu").ToString(), "")
                    Dim hmAdi As String = If(dtHMBilgi.Rows.Count > 0, dtHMBilgi.Rows(0)("sAciklama").ToString(), "")
                    Dim hmRenk As String = If(dtHMBilgi.Rows.Count > 0, dtHMBilgi.Rows(0)("sRenkAdi").ToString(), "")
                    Dim hmBeden As String = If(dtHMBilgi.Rows.Count > 0, dtHMBilgi.Rows(0)("sBeden").ToString(), "")
                    Dim hmKavala As String = If(dtHMBilgi.Rows.Count > 0, dtHMBilgi.Rows(0)("sKisaAdi").ToString(), "")
                    
                    ' Format: Kod|Ad|Mevcut|Gerekli|Eksik|StokID|Renk|Beden|Kavala
                    eksikYariMamullerBuKalem.Add(hmKodu & "|" & hmAdi & "|" & hmMevcut.ToString("N2") & "|" & hmGerekli.ToString("N2") & "|" & hmEksik.ToString("N2") & "|" & hmStokID.ToString() & "|" & hmRenk & "|" & hmBeden & "|" & hmKavala)
                    eksikYariMamulListesi.Add(hmKodu & " - " & hmAdi)
                End If
            Next
            
            If bYariMamulYeterli Then
                ' ===== YARI MAMUL YETERLI - URETIM EMRI OLUSTUR =====
                Debug.WriteLine("YARI MAMUL KONTROL: Tum yari mamuller yeterli - Uretim emri olusturuluyor")
                Debug.WriteLine("Urun: " & sStokKodu & " - " & sStokAdi)
                Debug.WriteLine("Eksik Miktar: " & eksik.ToString("N2"))
                
                Dim evrakNo As Integer = YeniEvrakNoUret()
                SQLCalistir("INSERT INTO TBLUREURETIM (EVRAKNO, STOKNO, TARIH, MIKTAR, DURUM, nSiparisID, dtePlanlananBaslangic) VALUES (" & evrakNo & ", " & nStokID & ", GETDATE(), " & eksik.ToString().Replace(",", ".") & ", 'Planlandi', " & lSiparisNo & ", GETDATE())")
                
                ' Recete hammaddelerini is emrine aktar
                For Each row As DataRow In dtRecete.Rows
                    Dim girdiStokID As Integer = Convert.ToInt32(row("STOKNO"))
                    Dim miktar As Decimal = Convert.ToDecimal(row("MIKTAR"))
                    SQLCalistir("INSERT INTO TBLUREURETIMLIST (EVRAKNO, STOKNO, MIKTAR) VALUES (" & evrakNo & ", " & girdiStokID & ", " & (miktar * eksik).ToString().Replace(",", ".") & ")")
                Next
                
                ' Cikti
                SQLCalistir("INSERT INTO TBLUREURETIMCIKTI (EVRAKNO, STOKNO, MIKTAR) VALUES (" & evrakNo & ", " & nStokID & ", " & eksik.ToString().Replace(",", ".") & ")")
                
                ' Uretim asamalarini olustur
                UretimAsamalariOlusturParametrik(evrakNo, eksik)
                bUretimEmriOlusturuldu = True
                
                ' Uretim yetkilisine bildirim
                Try
                    BildirimServisi.Broadcast("URETIM_EMRI_YENI", _
                        "YENI URETIM EMRI OLUSTURULDU" & vbCrLf & vbCrLf & _
                        "Evrak No: " & evrakNo & vbCrLf & _
                        "Stok Kodu: " & sStokKodu & vbCrLf & _
                        "Stok Adi: " & sStokAdi & vbCrLf & _
                        "Miktar: " & eksik.ToString("N2") & vbCrLf & _
                        "Siparis No: " & lSiparisNo, _
                        "Yeni Uretim Emri")
                Catch
                End Try
            Else
                ' ===== YARI MAMUL YETERSIZ - SATIN ALMA SOR =====
                Debug.WriteLine("YARI MAMUL KONTROL: Yari mamuller yetersiz!")
                Debug.WriteLine("Urun: " & sStokKodu & " - " & sStokAdi)
                Debug.WriteLine("Eksik Yari Mamul Sayisi: " & eksikYariMamullerBuKalem.Count)
                
                For Each hmDetay As String In eksikYariMamullerBuKalem
                    Dim parts() As String = hmDetay.Split("|"c)
                    Debug.WriteLine("  Eksik HM: " & parts(0) & " - " & parts(1) & " | Mevcut: " & parts(2) & " | Gerekli: " & parts(3) & " | Eksik: " & parts(4))
                Next
                
                Dim mesaj As String = "RECETEDEKI YARI MAMULLER YETERSIZ!" & vbCrLf & vbCrLf & _
                    "Urun: " & sStokKodu & " - " & sStokAdi & vbCrLf & vbCrLf & _
                    "Eksik Yari Mamuller:" & vbCrLf & vbCrLf
                
                For Each hmDetay As String In eksikYariMamullerBuKalem
                    Dim parts() As String = hmDetay.Split("|"c)
                    mesaj &= "  " & parts(0) & " - " & parts(1) & vbCrLf & _
                             "    Stok Mevcudu: " & parts(2) & vbCrLf & _
                             "    Gerekli: " & parts(3) & vbCrLf & _
                             "    Eksik: " & parts(4) & vbCrLf & vbCrLf
                Next
                
                mesaj &= "Bu urunlerden SATIN ALMA yapmak ister misiniz?"
                
                Dim sorSatinAlma = MessageBox.Show(mesaj, "Yari Mamul Yetersiz", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
                
                If sorSatinAlma = DialogResult.No Then
                    MessageBox.Show("Yari mamul yetersiz oldugu icin siparis onaylanamaz.", "Siparis Onaylanamaz", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                    Exit Sub ' SIPARIS ONAYLANMAZ
                End If
                
                ' EVET - Satin alma siparisleri olustur
                Dim satinAlinanUrunlerDetay As New List(Of String)
                
                For Each hmDetay As String In eksikYariMamullerBuKalem
                    Dim parts() As String = hmDetay.Split("|"c)
                    Dim hmStokID As Long = 0
                    Dim hmEksik As Decimal = 0
                    Dim hmKodu As String = parts(0)
                    Dim hmAdi As String = parts(1)
                    Dim hmMevcut As String = parts(2)
                    Dim hmGerekli As String = parts(3)
                    Dim hmRenk As String = If(parts.Length > 6, parts(6), "")
                    Dim hmBeden As String = If(parts.Length > 7, parts(7), "")
                    Dim hmKavala As String = If(parts.Length > 8, parts(8), "")
                    
                    ' Guvenli donusum
                    Long.TryParse(parts(5), hmStokID)
                    Decimal.TryParse(parts(4).Replace(".", ","), hmEksik)
                    
                    ' NOT: nStokID negatif olabilir (buyuk sayilar), sadece 0 kontrolu yap
                    If hmStokID = 0 OrElse hmEksik <= 0 Then
                        Continue For
                    End If
                    
                    ' Detayli bilgi olustur - TEDARIKCI OLSA DA OLMASA DA GOSTER
                    Dim detay As String = "Stok Kodu: " & hmKodu & vbCrLf & _
                        "Stok Adi: " & hmAdi
                    If Not String.IsNullOrEmpty(hmRenk) Then detay &= vbCrLf & "Renk: " & hmRenk
                    If Not String.IsNullOrEmpty(hmBeden) Then detay &= vbCrLf & "Beden: " & hmBeden
                    If Not String.IsNullOrEmpty(hmKavala) Then detay &= vbCrLf & "Kavala: " & hmKavala
                    detay &= vbCrLf & "Mevcut Stok: " & hmMevcut
                    detay &= vbCrLf & "Gerekli Miktar: " & hmGerekli
                    detay &= vbCrLf & "Eksik (Siparis) Miktar: " & hmEksik.ToString("N2")
                    
                    ' Tedarikci sec
                    Dim seciliTedarikciID As Integer = TedarikciSec(hmStokID)
                    
                    If seciliTedarikciID > 0 Then
                        Try
                            SatinAlmaSiparisiOlustur(hmStokID, hmEksik, seciliTedarikciID, lSiparisNo)
                            detay &= vbCrLf & "Durum: SIPARIS OLUSTURULDU (Tedarikci ID: " & seciliTedarikciID & ")"
                            bSatinAlmaOlusturuldu = True
                        Catch exSip As Exception
                            MessageBox.Show("Siparis olusturma hatasi: " & exSip.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error)
                            detay &= vbCrLf & "Durum: SIPARIS OLUSTURMA HATASI - " & exSip.Message
                        End Try
                    Else
                        detay &= vbCrLf & "Durum: TEDARIKCI SECILMEDI - Manuel siparis gerekli"
                    End If
                    
                    satinAlinanUrunlerDetay.Add(detay)
                Next
                
                ' Satin alma yetkilisine bildirim
                Try
                    Dim sbBildirim As New System.Text.StringBuilder()
                    sbBildirim.AppendLine("YARI MAMUL EKSIK - SATIN ALMA GEREKLI")
                    sbBildirim.AppendLine("")
                    sbBildirim.AppendLine("Siparis No: " & lSiparisNo)
                    sbBildirim.AppendLine("Ana Urun (Mamul): " & sStokKodu & " - " & sStokAdi)
                    sbBildirim.AppendLine("")
                    sbBildirim.AppendLine("EKSIK YARI MAMULLER:")
                    For Each urun As String In satinAlinanUrunlerDetay
                        sbBildirim.AppendLine("========================================")
                        sbBildirim.AppendLine(urun)
                    Next
                    BildirimServisi.Broadcast("SATINALMA_SIPARIS_OLUSTURULDU", sbBildirim.ToString(), "Satin Alma Siparisi")
                Catch
                End Try
                
                ' Kullaniciya mesaj goster - DETAYLI
                Dim sbMesaj As New System.Text.StringBuilder()
                sbMesaj.AppendLine("YARI MAMUL EKSIK - SATIN ALMA GEREKLI")
                sbMesaj.AppendLine("")
                sbMesaj.AppendLine("Siparis No: " & lSiparisNo)
                sbMesaj.AppendLine("Ana Urun (Mamul): " & sStokKodu & " - " & sStokAdi)
                sbMesaj.AppendLine("")
                sbMesaj.AppendLine("Recetede bulunan asagidaki YARI MAMULLER eksik oldugu icin")
                sbMesaj.AppendLine("satin alma departmanina siparis gecilmistir:")
                sbMesaj.AppendLine("")
                For Each urun As String In satinAlinanUrunlerDetay
                    sbMesaj.AppendLine("========================================")
                    sbMesaj.AppendLine(urun)
                Next
                sbMesaj.AppendLine("")
                sbMesaj.AppendLine("BU YARI MAMULLERIN STOK GIRISI YAPILMADAN")
                sbMesaj.AppendLine("URETIM IS EMRI OLUSMAYACAKTIR!")
                sbMesaj.AppendLine("")
                sbMesaj.AppendLine("Lutfen satin alma departmanina bilgi veriniz.")
                
                MessageBox.Show(sbMesaj.ToString(), "Yari Mamul Eksik - Satin Alma Gerekli", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                
                ' Siparisi BEKLEMEDE olarak isaretle (uretim emri OLUSTURMA)
                SQLCalistir("UPDATE tbSiparis SET sDurum = 'SatinAlmaBekliyor' WHERE lSiparisNo = " & lSiparisNo & " AND nFirmaID = " & nFirmaID)
                
                Exit Sub ' SIPARIS ONAYLANMAZ, URETIM EMRI OLUSTURULMAZ
            End If
        Next
        
        ' ===== TUM KONTROLLER GECTI =====
        If bUretimEmriOlusturuldu Then
            ' Uretim emri olusturuldu, siparis BEKLEMEDE kalsin
            SQLCalistir("UPDATE tbSiparis SET sDurum = 'UretimBekliyor', bKilitli = 1 WHERE lSiparisNo = " & lSiparisNo & " AND nFirmaID = " & nFirmaID)
            
            MessageBox.Show( _
                "URETIM EMRI OLUSTURULDU" & vbCrLf & vbCrLf & _
                "Siparis No: " & lSiparisNo & vbCrLf & vbCrLf & _
                "Uretim tamamlandiginda siparis otomatik olarak onaylanacaktir." & vbCrLf & _
                "Siparis simdilik BEKLEMEDE durumundadir.", _
                "Uretim Emri Olusturuldu", MessageBoxButtons.OK, MessageBoxIcon.Information)
            
            ' AUDIT LOG
            Try
                LogSiparis("URETIM_BEKLE", 0, lSiparisNo.ToString(), "Siparis uretim bekliyor - Siparis No: " & lSiparisNo & ", Firma: " & nFirmaID)
            Catch
            End Try
        ElseIf bTumStokYeterli Then
            ' Tum stoklar yeterli, SIPARISI ONAYLA
            ' Kullanici ID - guvenli donusum
            Dim nKullaniciID As Integer = 0
            Try
                If KeyCode.kullanici IsNot Nothing AndAlso Not String.IsNullOrEmpty(KeyCode.kullanici.ToString()) Then
                    Integer.TryParse(KeyCode.kullanici.ToString(), nKullaniciID)
                End If
            Catch
            End Try
            
            SQLCalistir("UPDATE tbSiparis SET bOnay = 1, bOnaylandi = 1, bKilitli = 1, sDurum = 'Onaylandi', nOnaylayanID = " & nKullaniciID & ", dteOnayTarihi = GETDATE() WHERE lSiparisNo = " & lSiparisNo & " AND nFirmaID = " & nFirmaID)
            
            MessageBox.Show("Siparis basariyla onaylandi ve kilitlendi.", "Siparis Onaylandi", MessageBoxButtons.OK, MessageBoxIcon.Information)
            
            ' AUDIT LOG
            Try
                LogSiparis("ONAYLA", 0, lSiparisNo.ToString(), "Siparis onaylandi - Siparis No: " & lSiparisNo & ", Firma: " & nFirmaID)
            Catch
            End Try
            
            ' Bildirim gonder
            Try
                BildirimServisi.Broadcast("SIPARIS_ONAYLANDI", _
                    "SIPARIS ONAYLANDI" & vbCrLf & vbCrLf & _
                    "Siparis No: " & lSiparisNo & vbCrLf & _
                    "Onaylayan: " & KeyCode.kullaniciadi, _
                    "Siparis Onaylandi")
            Catch
            End Try
        End If
    End Sub
    
    ''' <summary>
    ''' Onceki alimlardan tedarikci secer, birden fazla varsa kullaniciya sorar
    ''' Tedarikci bulunamazsa firma liste formunu acar
    ''' En uygun fiyatli tedarikciyi onerili olarak gosterir
    ''' </summary>
    Private Function TedarikciSec(ByVal nStokID As Long) As Integer
        Try
            ' Stok bilgisi al
            Dim dtStokBilgi As DataTable = SQLCalistir("SELECT sKodu, sAciklama FROM tbStok WHERE nStokID = " & nStokID)
            Dim sStokKodu As String = If(dtStokBilgi.Rows.Count > 0, dtStokBilgi.Rows(0)("sKodu").ToString(), "")
            Dim sStokAdi As String = If(dtStokBilgi.Rows.Count > 0, dtStokBilgi.Rows(0)("sAciklama").ToString(), "")
            
            ' Onceki alimlardan tedarikcileri bul - FIYATA GORE SIRALA (ucuzdan pahaliya)
            Dim dtTedarikci As DataTable = SQLCalistir("SELECT f.nFirmaID, f.sKodu, f.sAciklama, MAX(sf.dteFisTarihi) AS SonAlim, SUM(d.lGirisMiktar1) AS ToplamAlim, AVG(d.lGirisFiyat) AS OrtFiyat FROM tbStokFisiDetayi d INNER JOIN tbStokFisiMaster sf ON d.nStokFisiID = sf.nStokFisiID INNER JOIN tbFirma f ON sf.nFirmaID = f.nFirmaID WHERE d.nStokID = " & nStokID & " AND sf.sFisTipi IN ('AF', 'AI', '01', '02') AND d.lGirisMiktar1 > 0 GROUP BY f.nFirmaID, f.sKodu, f.sAciklama ORDER BY AVG(d.lGirisFiyat) ASC")
            
            If dtTedarikci.Rows.Count = 0 Then
                ' Tedarikci bulunamadi - Kullaniciya sor ve firma secim ekrani ac
                Dim cevap As DialogResult = MessageBox.Show( _
                    "Bu yari mamul icin onceki tedarikci bulunamadi:" & vbCrLf & vbCrLf & _
                    "Stok Kodu: " & sStokKodu & vbCrLf & _
                    "Stok Adi: " & sStokAdi & vbCrLf & vbCrLf & _
                    "Tedarikci secmek ister misiniz?", _
                    "Tedarikci Bulunamadi", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
                
                If cevap = DialogResult.Yes Then
                    ' Firma liste formunu ac
                    Try
                        Dim frm As New frm_firma_liste
                        frm.islemstatus = True
                        frm.connection = connection
                        frm.firmano = firmano
                        frm.donemno = donemno
                        frm.kullanici = kullanici
                        frm.sModul = "SatinAlma"
                        frm.Text = "Tedarikci Sec - " & sStokKodu
                        
                        Dim dialogSonuc As DialogResult = frm.ShowDialog()
                        
                        If dialogSonuc = DialogResult.OK Then
                            ' GridView'den secilen satirin nFirmaID degerini al
                            If frm.GridView1.RowCount > 0 Then
                                Dim drFirma As DataRow = frm.GridView1.GetDataRow(frm.GridView1.FocusedRowHandle)
                                If drFirma IsNot Nothing AndAlso drFirma.Table.Columns.Contains("nFirmaID") Then
                                    Dim nSeciliFirmaID As Integer = Convert.ToInt32(drFirma("nFirmaID"))
                                    If nSeciliFirmaID > 0 Then
                                        Return nSeciliFirmaID
                                    End If
                                End If
                            End If
                        End If
                    Catch ex As Exception
                        Debug.WriteLine("Firma liste acma hatasi: " & ex.Message)
                    End Try
                End If
                Return 0
            ElseIf dtTedarikci.Rows.Count = 1 Then
                ' Tek tedarikci var - OTOMATIK SEC
                Return Convert.ToInt32(dtTedarikci.Rows(0)("nFirmaID"))
            Else
                ' Birden fazla tedarikci var - en uygun fiyatliyi onerili olarak goster
                Dim secenekler As String = "TEDARIKCI SECIMI" & vbCrLf & vbCrLf & _
                    "Stok: " & sStokKodu & " - " & sStokAdi & vbCrLf & vbCrLf & _
                    "Daha once alinan tedarikciler (fiyata gore siralanmis):" & vbCrLf & _
                    "=============================================" & vbCrLf
                
                Dim i As Integer = 1
                Dim enUygunFiyat As Decimal = Decimal.MaxValue
                Dim enUygunIndex As Integer = 1
                
                For Each row As DataRow In dtTedarikci.Rows
                    Dim sonAlim As String = If(row("SonAlim") IsNot DBNull.Value, Convert.ToDateTime(row("SonAlim")).ToString("dd.MM.yyyy"), "-")
                    Dim ortFiyat As Decimal = If(row("OrtFiyat") IsNot DBNull.Value, Convert.ToDecimal(row("OrtFiyat")), 0)
                    Dim ortFiyatStr As String = ortFiyat.ToString("N2")
                    
                    ' En uygun fiyati bul
                    If ortFiyat > 0 AndAlso ortFiyat < enUygunFiyat Then
                        enUygunFiyat = ortFiyat
                        enUygunIndex = i
                    End If
                    
                    ' Onerilen tedarikciyi isaretle
                    Dim onerilen As String = If(i = 1, " *** EN UYGUN FIYAT ***", "")
                    
                    secenekler &= i.ToString() & ". " & row("sKodu").ToString() & " - " & row("sAciklama").ToString() & onerilen & vbCrLf & _
                        "   Ort. Fiyat: " & ortFiyatStr & " TL | Son Alim: " & sonAlim & vbCrLf
                    i += 1
                    If i > 10 Then Exit For ' En fazla 10 secenek goster
                Next
                
                secenekler &= "=============================================" & vbCrLf
                secenekler &= "0 = Listede olmayan YENI TEDARIKCI sec" & vbCrLf & vbCrLf
                secenekler &= "Numara girin (0-" & Math.Min(dtTedarikci.Rows.Count, 10) & "):" & vbCrLf
                secenekler &= "(Varsayilan: 1 - En uygun fiyatli)"
                
                Dim secim As String = InputBox(secenekler, "Tedarikci Sec - " & sStokKodu, "1")
                
                ' Iptal veya bos ise en uygun fiyatliyi sec
                If String.IsNullOrEmpty(secim) Then
                    Return Convert.ToInt32(dtTedarikci.Rows(0)("nFirmaID"))
                End If
                
                Dim secimNo As Integer = -1
                If Integer.TryParse(secim, secimNo) Then
                    If secimNo = 0 Then
                        ' Yeni tedarikci sec - Firma liste formunu ac
                        Try
                            Dim frm As New frm_firma_liste
                            frm.islemstatus = True
                            frm.connection = connection
                            frm.firmano = firmano
                            frm.donemno = donemno
                            frm.kullanici = kullanici
                            frm.sModul = "SatinAlma"
                            frm.Text = "Tedarikci Sec - " & sStokKodu
                            
                            If frm.ShowDialog() = DialogResult.OK Then
                                ' GridView'den secilen satirin nFirmaID degerini al
                                If frm.GridView1.RowCount > 0 Then
                                    Dim drFirma As DataRow = frm.GridView1.GetDataRow(frm.GridView1.FocusedRowHandle)
                                    If drFirma IsNot Nothing AndAlso drFirma.Table.Columns.Contains("nFirmaID") Then
                                        Dim nSeciliFirmaID As Integer = Convert.ToInt32(drFirma("nFirmaID"))
                                        If nSeciliFirmaID > 0 Then
                                            Return nSeciliFirmaID
                                        End If
                                    End If
                                End If
                            End If
                        Catch ex As Exception
                            Debug.WriteLine("Firma liste acma hatasi: " & ex.Message)
                        End Try
                    ElseIf secimNo >= 1 AndAlso secimNo <= Math.Min(dtTedarikci.Rows.Count, 10) Then
                        Return Convert.ToInt32(dtTedarikci.Rows(secimNo - 1)("nFirmaID"))
                    End If
                End If
            End If
        Catch ex As Exception
            Debug.WriteLine("TedarikciSec Hata: " & ex.Message)
        End Try
        Return 0
    End Function
    
    ''' <summary>
    ''' Satin alma siparisi olusturur - MEVCUT FONKSIYONLARI KULLANIR
    ''' </summary>
    Private Sub SatinAlmaSiparisiOlustur(ByVal nStokID As Long, ByVal lMiktar As Decimal, ByVal nTedarikciID As Integer, ByVal nAlinanSiparisNo As Long)
        Try
            ' Yeni siparis numarasi al - Verilen Siparis (nSiparisTipi = 2)
            Dim lYeniSiparisNo As Long = 1
            Try
                Dim dtMaxSiparis As DataTable = SQLCalistir("SELECT ISNULL(MAX(lSiparisNo), 0) + 1 AS YeniNo FROM tbSiparis WHERE nSiparisTipi = 2 AND nFirmaID = " & nTedarikciID)
                If dtMaxSiparis.Rows.Count > 0 AndAlso dtMaxSiparis.Rows(0)("YeniNo") IsNot DBNull.Value Then
                    lYeniSiparisNo = Convert.ToInt64(dtMaxSiparis.Rows(0)("YeniNo"))
                End If
            Catch
            End Try
            
            ' Stok bilgisi al - sBirimCinsi2 ve sAmbalaj icin
            Dim dtStok As DataTable = SQLCalistir("SELECT s.sKodu, s.sAciklama, ISNULL(k.nKdvOrani, 0) AS nKdvOrani, s.sBirimCinsi1, ISNULL(s.sBirimCinsi2, '') AS sBirimCinsi2 FROM tbStok s LEFT JOIN tbKdv k ON s.sKdvTipi = k.sKdvTipi WHERE s.nStokID = " & nStokID)
            Dim sStokKodu As String = ""
            Dim sStokAdi As String = ""
            Dim nKdvOrani As Integer = 0
            Dim sBirimCinsi As String = ""
            Dim sBirimCinsi2 As String = ""
            
            If dtStok.Rows.Count > 0 Then
                If dtStok.Rows(0)("sKodu") IsNot DBNull.Value Then sStokKodu = dtStok.Rows(0)("sKodu").ToString()
                If dtStok.Rows(0)("sAciklama") IsNot DBNull.Value Then sStokAdi = dtStok.Rows(0)("sAciklama").ToString()
                If dtStok.Rows(0)("nKdvOrani") IsNot DBNull.Value Then nKdvOrani = Convert.ToInt32(dtStok.Rows(0)("nKdvOrani"))
                If dtStok.Rows(0)("sBirimCinsi1") IsNot DBNull.Value Then sBirimCinsi = dtStok.Rows(0)("sBirimCinsi1").ToString()
                If dtStok.Rows(0)("sBirimCinsi2") IsNot DBNull.Value Then sBirimCinsi2 = dtStok.Rows(0)("sBirimCinsi2").ToString()
            End If
            
            ' sBirimCinsi ve sAmbalaj = sBirimCinsi2
            If String.IsNullOrEmpty(sBirimCinsi2) Then sBirimCinsi2 = "AD"
            
            ' Alis fiyati bul
            Dim lFiyat As Decimal = 0
            Try
                Dim dtFiyat As DataTable = SQLCalistir("SELECT TOP 1 lFiyat FROM tbStokFiyati WHERE nStokID = " & nStokID & " AND sFiyatTipi = '" & sFiyatA & "' ORDER BY dteFiyatTespitTarihi DESC")
                If dtFiyat.Rows.Count > 0 AndAlso dtFiyat.Rows(0)("lFiyat") IsNot DBNull.Value Then
                    lFiyat = Convert.ToDecimal(dtFiyat.Rows(0)("lFiyat"))
                End If
            Catch
            End Try
            
            ' Tutar hesapla
            Dim lTutar As Decimal = lMiktar * lFiyat
            
            ' Kullanici bilgisi
            Dim sKullanici As String = ""
            Try
                If KeyCode.kullaniciadi IsNot Nothing Then
                    sKullanici = KeyCode.kullaniciadi.ToString()
                End If
            Catch
            End Try
            If String.IsNullOrEmpty(sKullanici) Then sKullanici = "SISTEM"
            
            ' Kullanicinin deposunu al - form degiskeninden
            Dim sDepoKullanici As String = ""
            Try
                If Not String.IsNullOrEmpty(sDepo) Then
                    sDepoKullanici = sDepo
                End If
            Catch
            End Try
            
            ' sSaticiRumuzu = 099, yoksa ekle - TUM SUTUNLAR
            Dim sSaticiRumuzu As String = "099"
            Try
                Dim dtSatici As DataTable = SQLCalistir("SELECT COUNT(*) AS CNT FROM tbSatici WHERE sSaticiRumuzu = '099'")
                If dtSatici.Rows.Count > 0 AndAlso Convert.ToInt32(dtSatici.Rows(0)("CNT")) = 0 Then
                    SQLCalistir("INSERT INTO tbSatici (sSaticiRumuzu, sAdi, sSoyadi, nPrim, sAciklama, lSabitPrim, lPrim1Baslangic, lPrim1Bitis, lPrim1Oran, lPrim2Baslangic, lPrim2Bitis, lPrim2Oran, lPrim3Baslangic, lPrim3Bitis, lPrim3Oran, lPrim4Baslangic, lPrim4Bitis, lPrim4Oran, lPrim5Baslangic, lPrim5Bitis, lPrim5Oran, bAktif) VALUES ('099', 'Uretim', 'Siparis', 0, 'Uretim Siparisi', 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1)")
                End If
            Catch
            End Try
            
            ' sSatirAciklama = Isk1:40.00 Isk2:00.00 Isk3:00.00 Isk4:00.00
            Dim sSatirAciklama As String = "Isk1:40.00 Isk2:00.00 Isk3:00.00 Isk4:00.00"
            
            ' Tarihler - saat formatli
            Dim dteSiparisTarihi As DateTime = DateTime.Now.Date
            Dim dteTeslimTarihi As DateTime = DateTime.Now.AddDays(7).Date
            
            ' MEVCUT FONKSIYONU KULLAN: tbSiparis_kaydet_yeni
            Dim nYeniSiparisID As Int64 = tbSiparis_kaydet_yeni( _
                0, _                            ' nSiparisID
                2, _                            ' nSiparisTipi = 2 (Verilen Siparis)
                lYeniSiparisNo, _               ' lSiparisNo
                nTedarikciID, _                 ' nFirmaID
                nStokID, _                      ' nStokID
                dteSiparisTarihi, _             ' dteSiparisTarihi
                dteTeslimTarihi, _              ' dteTeslimTarihi
                "", _                           ' sSiparisIslem (bos)
                0, _                            ' nReceteNo
                sKullanici, _                   ' sSiparisiAlan
                sStokAdi, _                     ' sSiparisiVeren
                sFiyatA, _                      ' sFiyatTipi (Alis fiyati)
                lMiktar, _                      ' lMiktari
                lFiyat, _                       ' lFiyati
                lTutar, _                       ' lTutari
                "", _                           ' sAsortiTipi
                "0", _                          ' sAsortiMiktari
                nKdvOrani, _                    ' nKdvOrani
                0, _                            ' nIskontoYuzdesi
                lTutar, _                       ' lIskontosuzTutari
                sKullanici, _                   ' sKullaniciAdi
                DateTime.Now, _                 ' dteKayitTarihi
                0, _                            ' bKapandimi
                0, _                            ' lReserveMiktari
                "", _                           ' sHangiUygulama
                0, _                            ' nPartiID
                sSatirAciklama, _               ' sSatirAciklama (iskontolar)
                0, _                            ' nValorGun
                "", _                           ' sDovizCinsi
                0, _                            ' lDovizFiyati
                1, _                            ' lDovizKuru
                sSaticiRumuzu, _                ' sSaticiRumuzu = 099
                sDepoKullanici, _               ' sDepo (kullanici deposu)
                sBirimCinsi2, _                 ' sBirimCinsi = tbStok.sBirimCinsi2
                1, _                            ' lBirimMiktar
                sBirimCinsi2)                   ' sAmbalaj = tbStok.sBirimCinsi2
            
            ' sDurum = SatinAlmaBekliyor olarak guncelle
            Try
                SQLCalistir("UPDATE tbSiparis SET sDurum = 'SatinAlmaBekliyor' WHERE nSiparisID = " & nYeniSiparisID)
            Catch
            End Try
            
            ' MEVCUT FONKSIYONU KULLAN: tbSiparis_Aciklamasi_kaydet_yeni
            tbSiparis_Aciklamasi_kaydet_yeni(2, lYeniSiparisNo, nTedarikciID, "", "", "", "", "", 0)
            
            ' Basarili mesaji
            MessageBox.Show("Verilen Siparis olusturuldu!" & vbCrLf & vbCrLf & _
                "Siparis No: " & lYeniSiparisNo & vbCrLf & _
                "Tedarikci ID: " & nTedarikciID & vbCrLf & _
                "Stok: " & sStokKodu & " - " & sStokAdi & vbCrLf & _
                "Miktar: " & lMiktar.ToString("N2") & vbCrLf & _
                "Fiyat: " & lFiyat.ToString("N2") & " TL", _
                "Siparis Olusturuldu", MessageBoxButtons.OK, MessageBoxIcon.Information)
            
        Catch ex As Exception
            MessageBox.Show("SatinAlmaSiparisiOlustur Hata: " & ex.Message & vbCrLf & vbCrLf & ex.StackTrace, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
    
    ''' <summary>
    ''' Parametrik onaylarla uretim asamalari olusturur
    ''' </summary>
    Private Sub UretimAsamalariOlusturParametrik(ByVal nEvrakNo As Integer, ByVal lMiktar As Decimal)
        Try
            ' Tum aktif asamalari al
            Dim dtAsamalar As DataTable = SQLCalistir("SELECT nAsamaID, sAsamaAdi, nSiraNo, nGerekliOnay, sOnayTurleri, nStandartSure FROM tbUretimAsamaTanim WHERE bAktif = 1 ORDER BY nSiraNo")
            
            Dim ilkAsamaID As Integer = 0
            
            For Each row As DataRow In dtAsamalar.Rows
                Dim nAsamaID As Integer = Convert.ToInt32(row("nAsamaID"))
                Dim nStandartSure As Integer = If(row("nStandartSure") IsNot DBNull.Value, Convert.ToInt32(row("nStandartSure")), 0)
                Dim nGerekliOnay As Integer = If(row("nGerekliOnay") IsNot DBNull.Value, Convert.ToInt32(row("nGerekliOnay")), 1)
                Dim sOnayTurleri As String = If(row("sOnayTurleri") IsNot DBNull.Value, row("sOnayTurleri").ToString(), "URETIM_YETKILISI")
                
                ' Asama kaydini olustur
                SQLCalistir("INSERT INTO tbUretimEmriAsama (nUretimEmriID, nAsamaID, sAsamaAdi, nPlanlananSure, lPlanlananMiktar, sDurum) VALUES (" & nEvrakNo & ", " & nAsamaID & ", '" & row("sAsamaAdi").ToString().Replace("'", "''") & "', " & nStandartSure & ", " & lMiktar.ToString().Replace(",", ".") & ", 'Bekliyor')")
                
                ' Ilk asamayi kaydet
                If ilkAsamaID = 0 Then ilkAsamaID = nAsamaID
                
                ' Asama icin onay kayitlari olustur
                Dim dtAsamaID As DataTable = SQLCalistir("SELECT MAX(nID) AS nID FROM tbUretimEmriAsama WHERE nUretimEmriID = " & nEvrakNo & " AND nAsamaID = " & nAsamaID)
                If dtAsamaID.Rows.Count > 0 AndAlso dtAsamaID.Rows(0)("nID") IsNot DBNull.Value Then
                    Dim nAsamaKayitID As Integer = Convert.ToInt32(dtAsamaID.Rows(0)("nID"))
                    
                    ' Onay turlerini parcala
                    Dim onayTurleri() As String = sOnayTurleri.Split(","c)
                    Dim onayNo As Integer = 0
                    
                    For Each onayTur As String In onayTurleri
                        onayNo += 1
                        If onayNo > nGerekliOnay Then Exit For
                        
                        onayTur = onayTur.Trim()
                        Dim dtOnayTur As DataTable = SQLCalistir("SELECT nOnayTurID FROM tbOnayTurleri WHERE sOnayTurKodu = '" & onayTur & "' AND bAktif = 1")
                        If dtOnayTur.Rows.Count > 0 Then
                            Dim nOnayTurID As Integer = Convert.ToInt32(dtOnayTur.Rows(0)("nOnayTurID"))
                            SQLCalistir("INSERT INTO tbUretimEmriAsamaOnaylar (nUretimEmriAsamaID, nUretimEmriID, nAsamaID, nOnayTurID, nOnayNo, sOnayDurum) VALUES (" & nAsamaKayitID & ", " & nEvrakNo & ", " & nAsamaID & ", " & nOnayTurID & ", " & onayNo & ", 'Bekliyor')")
                        End If
                    Next
                End If
            Next
            
            ' Ilk asamayi baslat
            If ilkAsamaID > 0 Then
                SQLCalistir("UPDATE tbUretimEmriAsama SET sDurum = 'Devam', dteBaslangic = GETDATE() WHERE nUretimEmriID = " & nEvrakNo & " AND nAsamaID = " & ilkAsamaID)
                SQLCalistir("UPDATE TBLUREURETIM SET nMevcutAsamaID = " & ilkAsamaID & " WHERE EVRAKNO = " & nEvrakNo)
                
                ' Ilk asama yetkililerine bildirim gonder
                Try
                    Dim dtAsamaAdi As DataTable = SQLCalistir("SELECT sAsamaAdi FROM tbUretimAsamaTanim WHERE nAsamaID = " & ilkAsamaID)
                    Dim sAsamaAdi As String = If(dtAsamaAdi.Rows.Count > 0, dtAsamaAdi.Rows(0)("sAsamaAdi").ToString(), "")
                    BildirimServisi.UretimAsamaBildirimiGonder(nEvrakNo, sAsamaAdi, "Basladi")
                Catch
                End Try
            End If
        Catch ex As Exception
            Debug.WriteLine("UretimAsamalariOlusturParametrik Hata: " & ex.Message)
        End Try
    End Sub
    Private Sub SiparisOnay_Kaldir(ByVal nSiparisID As Integer, ByVal nFirmaID As Integer)
        ' ===== YETKI KONTROLU: frm_tbSiparis_Onay =====
        If yetki_kontrol(kullanici, "frm_tbSiparis_Onay") = False Then
            MessageBox.Show("Siparis onayi kaldirma yetkiniz bulunmamaktadir." & vbCrLf & vbCrLf & _
                "Gerekli Yetki: frm_tbSiparis_Onay", "Yetki Hatasi", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If
        
        ' 1. Zaten onaylı mı? (Parametrik kontrol - bOnayVar = TRUE ise kontrol yap)
        Dim dtParamOnay4 As DataTable = SQLCalistir("SELECT ISNULL(bOnayVar, 0) AS bOnayVar FROM tbParamAlSiparis")
        Dim bOnayVarParam4 As Boolean = False
        If dtParamOnay4.Rows.Count > 0 Then
            bOnayVarParam4 = Convert.ToBoolean(dtParamOnay4.Rows(0)("bOnayVar"))
        End If
        
        Dim bSiparisOnayli4 As Boolean = False
        If bOnayVarParam4 Then
            Dim dtOnay As DataTable = SQLCalistir("SELECT ISNULL(bOnay, 0) FROM tbSiparis  WHERE lSiparisNo = " & lSiparisNo & " AND nFirmaID = " & nFirmaID)
            If dtOnay.Rows.Count > 0 AndAlso Convert.ToBoolean(dtOnay.Rows(0)(0)) Then
                bSiparisOnayli4 = True
            End If
        End If
        
        If bSiparisOnayli4 Then
            ' 2. Parametre kontrolü (Üretim entegrasyonu açık mı?)
            Dim dtParam As DataTable = SQLCalistir("SELECT ISNULL(bReceteVarmi, 0) FROM tbParamAlSiparis")
            Dim ReceteKontrolEt As Boolean = Convert.ToBoolean(dtParam.Rows(0)(0))
            If dtParam.Rows.Count > 0 AndAlso Convert.ToBoolean(dtParam.Rows(0)(0)) Then

                ' 3. Sipariş kalemleri
                Dim dtKalem As DataTable = SQLCalistir("SELECT nStokID, lMiktari, sDepo FROM tbSiparis  WHERE lSiparisNo = " & lSiparisNo & " AND nFirmaID = " & nFirmaID)
                For Each dr As DataRow In dtKalem.Rows
                    Dim nStokID As Integer = Convert.ToInt32(dr("nStokID"))
                    Dim sipMiktar As Decimal = Convert.ToDecimal(dr("lMiktari"))
                    Dim sDepo As String = dr("sDepo").ToString()

                    ' 4. Depoya göre stok miktarı: Giriş - Çıkış
                    Dim dtStok As DataTable = SQLCalistir("
            SELECT 
                ISNULL(SUM(ISNULL(lGirisMiktar1,0)),0) - ISNULL(SUM(ISNULL(lCikisMiktar1,0)),0) AS Mevcut
            FROM tbStokFisiDetayi
            WHERE nStokID = " & nStokID & " AND sDepo = '" & sDepo & "'")

                    Dim mevcut As Decimal = If(dtStok.Rows.Count > 0, Convert.ToDecimal(dtStok.Rows(0)("Mevcut")), 0)


                    ' 7. Yeni evrak no oluştur ve başlık ekle
                    Dim evrakNo As Integer = YeniEvrakNoUret()
                    SQLCalistir("DELETE FROM  TBLUREURETIM WHERE EVRAKNO = " & evrakNo & " And  STOKNO = " & nStokID & " ")

                    ' 8. Reçete hammaddelerini iş emrine aktar
                    Dim dtReceteBaslik2 As DataTable = SQLCalistir("SELECT IND FROM TBLURERECETELIST WHERE STOKNO = " & nStokID)
                    If dtReceteBaslik2.Rows.Count > 0 Then
                        Dim nReceteIND2 As Integer = Convert.ToInt32(dtReceteBaslik2.Rows(0)("IND"))
                        Dim dtRecete As DataTable = SQLCalistir("SELECT STOKNO, MIKTAR FROM TBLURERECETE WHERE EVRAKNO = " & nReceteIND2 & " AND STOKNO IS NOT NULL AND STOKNO <> 0")
                        For Each row As DataRow In dtRecete.Rows
                            Dim girdiStokID As Integer = Convert.ToInt32(row("STOKNO"))
                            Dim miktar As Decimal = Convert.ToDecimal(row("MIKTAR"))
                            SQLCalistir("DELETE FROM TBLUREURETIMLIST WHERE EVRAKNO = " & evrakNo & " And STOKNO = " & girdiStokID & " ")
                        Next
                    End If

                    ' 9. Çıktı olarak ürünün kendisi
                    SQLCalistir("DELETE FROM TBLUREURETIMCIKTI WHERE EVRAKNO = " & evrakNo & " And STOKNO = " & nStokID & " ")

                Next
            End If
            ' 10. Sipariş onayını ve kilidini kaldır
            SQLCalistir("UPDATE tbSiparis SET bOnay = 0, bOnaylandi = 0, bKilitli = 0, nOnaylayanID = NULL, dteOnayTarihi = NULL WHERE lSiparisNo = " & lSiparisNo & " AND nFirmaID = " & nFirmaID)
            ' tbSiparisAciklamasi tablosundaki kilidi de kaldir
            SQLCalistir("UPDATE tbSiparisAciklamasi SET bKilitli = 0 WHERE lSiparisNo = " & lSiparisNo & " AND nFirmaID = " & nFirmaID)
            MessageBox.Show("Siparis sevk onayi kaldirildi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Try
                Debug.WriteLine("AUDIT LOG: Onay kaldirma cagrildi - SiparisID: " & nSiparisID & ", Firma: " & nFirmaID)
                ' Eski deger: True (onayliydi), Yeni deger: False (onay kaldirildi)
                LogSiparis("GUNCELLE", nSiparisID, nSiparisID.ToString(), "Sevk onayi kaldirildi - Siparis ID: " & nSiparisID & ", Firma: " & nFirmaID, "True", "False")
                Debug.WriteLine("AUDIT LOG: Log basariyla kaydedildi")
            Catch ex As Exception
                Debug.WriteLine("AUDIT LOG HATASI: " & ex.Message)
            End Try
        End If

    End Sub
    Private Function YeniEvrakNoUret() As Integer
        Dim dt As DataTable = SQLCalistir("SELECT ISNULL(MAX(EVRAKNO), 100) AS SonEvrakNo FROM TBLUREURETIM")
        Return Convert.ToInt32(dt.Rows(0)("SonEvrakNo")) + 1
    End Function

    Private Function SQLCalistir(sql As String) As DataTable
        Dim cmd As New OleDb.OleDbCommand
        Dim con As New OleDb.OleDbConnection
        Dim adapter As New OleDb.OleDbDataAdapter(cmd)
        con.ConnectionString = connection
        cmd.CommandText = sql
        cmd.CommandTimeout = Nothing
        cmd.Connection = con
        Dim dt As New DataTable()
        Try
            con.Open()
            adapter.Fill(dt)
        Catch ex As Exception
            LogYaz("SQLCalistir", ex.ToString())
            MessageBox.Show("SQL çalıştırma hatası: " & ex.Message)
        Finally
            con.Close()
        End Try
        Return dt
    End Function
    Private Sub BarButtonItem52_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem52.ItemClick
        tutaragore_miktarhesapla()
    End Sub

    Private Sub BarButtonItem54_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem54.ItemClick
        'satir_birlestir()
    End Sub

    Private Sub BarButtonItem55_ItemClick(sender As Object, e As ItemClickEventArgs) Handles BarButtonItem55.ItemClick
        Dim lSiparisNo As Decimal = Convert.ToDecimal(dr_baslik("lSiparisNo"))
        Dim nFirmaID As Integer = Convert.ToInt32(dr_baslik("nFirmaID"))

        Dim dt As DataTable = SQLCalistir("SELECT nSiparisID FROM tbSiparis WHERE lSiparisNo = " & lSiparisNo & " AND nFirmaID = " & nFirmaID)
        Dim nSiparisID As Integer = 0
        If dt.Rows.Count > 0 Then
            nSiparisID = Convert.ToInt32(dt.Rows(0)("nSiparisID"))
        End If
        
        ' Siparis tipine gore farkli onay mekanizmasi
        If nSiparisTipi = 2 Then
            ' VERILEN SIPARIS - Basit onay mekanizmasi
            VerilenSiparisOnayla(nSiparisID, nFirmaID)
        Else
            ' ALINAN SIPARIS - Karmasik onay mekanizmasi (uretim/recete kontrollu)
            SiparisOnayla(nSiparisID, nFirmaID)
        End If
    End Sub
    
    ''' <summary>
    ''' Verilen Siparis icin basit onay mekanizmasi
    ''' Onaylanmamis siparisler irsaliye/faturaya donusturulemez
    ''' </summary>
    Private Sub VerilenSiparisOnayla(ByVal nSiparisID As Integer, ByVal nFirmaID As Integer)
        Try
            ' ===== YETKI KONTROLU: frm_tbSiparis_Onay =====
            If yetki_kontrol(kullanici, "frm_tbSiparis_Onay") = False Then
                MessageBox.Show("Siparis onaylama yetkiniz bulunmamaktadir." & vbCrLf & vbCrLf & _
                    "Gerekli Yetki: frm_tbSiparis_Onay", "Yetki Hatasi", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Exit Sub
            End If
            
            ' 1. Zaten onayli mi kontrol et
            Dim dtOnay As DataTable = SQLCalistir("SELECT ISNULL(bOnay, 0) AS bOnay, ISNULL(bKilitli, 0) AS bKilitli FROM tbSiparis WHERE lSiparisNo = " & lSiparisNo & " AND nFirmaID = " & nFirmaID)
            
            If dtOnay.Rows.Count > 0 Then
                If Convert.ToInt32(dtOnay.Rows(0)("bOnay")) = 1 Then
                    MessageBox.Show("Bu sipariş daha önce onaylanmış.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                    Exit Sub
                End If
                If Convert.ToInt32(dtOnay.Rows(0)("bKilitli")) = 1 Then
                    MessageBox.Show("Bu sipariş kilitli, değişiklik yapılamaz.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                    Exit Sub
                End If
            End If
            
            ' 2. Kullanicidan onay al
            Dim onayMesaji As String = "Verilen Sipariş No: " & lSiparisNo & vbCrLf & vbCrLf & _
                "Bu siparişi onaylamak istiyor musunuz?" & vbCrLf & vbCrLf & _
                "NOT: Onaylanan sipariş kilitlenecek ve değişiklik yapılamayacaktır." & vbCrLf & _
                "Onaylanmamış siparişler irsaliye veya faturaya dönüştürülemez."
            
            If MessageBox.Show(onayMesaji, "Verilen Sipariş Onayı", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.No Then
                Exit Sub
            End If
            
            ' 3. Siparisi onayla ve kilitle
            SQLCalistir("UPDATE tbSiparis SET bOnay = 1, bOnaylandi = 1, bKilitli = 1, sDurum = 'Onaylandi', nOnaylayanID = " & kullanici & ", dteOnayTarihi = GETDATE() WHERE lSiparisNo = " & lSiparisNo & " AND nFirmaID = " & nFirmaID)
            SQLCalistir("UPDATE tbSiparisAciklamasi SET bKilitli = 1 WHERE lSiparisNo = " & lSiparisNo & " AND nFirmaID = " & nFirmaID)
            
            ' 4. Basarili mesaji
            MessageBox.Show("Verilen Sipariş başarıyla onaylandı ve kilitlendi." & vbCrLf & _
                "Sipariş No: " & lSiparisNo, "Sipariş Onaylandı", MessageBoxButtons.OK, MessageBoxIcon.Information)
            
            ' 5. Form'u yenile
            loaded()
            
            ' 6. Bildirim gonder
            Try
                BildirimServisi.Broadcast("SIPARIS_ONAYLANDI", _
                    "Verilen Sipariş Onaylandı" & vbCrLf & vbCrLf & _
                    "Sipariş No: " & lSiparisNo & vbCrLf & _
                    "Firma ID: " & nFirmaID & vbCrLf & _
                    "Onaylayan: " & KeyCode.kullaniciadi, _
                    "Verilen Siparis Onaylandi")
            Catch
            End Try
            
        Catch ex As Exception
            MessageBox.Show("Sipariş onaylama hatası: " & ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
    
    Private Sub BarButtonItem56_ItemClick(sender As Object, e As ItemClickEventArgs) Handles BarButtonItem56.ItemClick
        Dim lSiparisNo As Decimal = Convert.ToDecimal(dr_baslik("lSiparisNo"))
        Dim nFirmaID As Integer = Convert.ToInt32(dr_baslik("nFirmaID"))

        Dim dt As DataTable = SQLCalistir("SELECT nSiparisID FROM tbSiparis WHERE lSiparisNo = " & lSiparisNo & " AND nFirmaID = " & nFirmaID)
        Dim nSiparisID As Integer = 0
        If dt.Rows.Count > 0 Then
            nSiparisID = Convert.ToInt32(dt.Rows(0)("nSiparisID"))
        End If
        SiparisOnay_Kaldir(nSiparisID, nFirmaID)
    End Sub
    Private Sub GridView1_CustomColumnDisplayText(sender As Object, e As DevExpress.XtraGrid.Views.Base.CustomColumnDisplayTextEventArgs) _
Handles GridView1.CustomColumnDisplayText

        If e.Column Is colNetFiyat AndAlso e.Value IsNot Nothing AndAlso Not TypeOf e.Value Is DBNull Then
            Dim tr As CultureInfo = CultureInfo.GetCultureInfo("tr-TR")
            Dim v As Decimal
            Dim ok As Boolean = False

            ' 1) Zaten sayısal tipse direkt al
            If TypeOf e.Value Is Decimal Then
                v = CDec(e.Value) : ok = True
            ElseIf TypeOf e.Value Is Double Then
                v = CDec(CDbl(e.Value)) : ok = True
            Else
                ' 2) String ise önce Invariant, sonra TR dene
                Dim s As String = Convert.ToString(e.Value)
                ok = Decimal.TryParse(s, NumberStyles.Any, CultureInfo.InvariantCulture, v) _
             OrElse Decimal.TryParse(s, NumberStyles.Any, tr, v)
            End If

            If ok Then
                ' BURAYA YAZ
                Dim rounded As Decimal = Decimal.Round(v, 0, MidpointRounding.AwayFromZero)
                e.DisplayText = rounded.ToString("N0", tr)
            End If
        End If
    End Sub
    
    ''' <summary>
    ''' Uretim emri icin tum asamalari olusturur
    ''' </summary>
    Private Sub UretimAsamalariOlustur(ByVal evrakNo As Integer, ByVal miktar As Decimal)
        Try
            ' Aktif asamalari al
            Dim dtAsamalar As DataTable = SQLCalistir("SELECT nAsamaID, sAsamaAdi, nSiraNo FROM tbUretimAsamalar WHERE bAktif = 1 ORDER BY nSiraNo")
            
            If dtAsamalar.Rows.Count = 0 Then
                ' Tablo bos veya yoksa varsayilan asamalari ekle
                MessageBox.Show("Uretim asamalari tanimlari bulunamadi. Lutfen SQL scriptini calistirin.", "Uyari", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Exit Sub
            End If
            
            For Each dr As DataRow In dtAsamalar.Rows
                Dim nAsamaID As Integer = Convert.ToInt32(dr("nAsamaID"))
                SQLCalistir("INSERT INTO tbUretimEmriAsamalar (nUretimEmriID, nAsamaID, sDurum, lPlanlananMiktar, dteKayitTarihi) VALUES (" & evrakNo & ", " & nAsamaID & ", 'Bekliyor', " & miktar.ToString().Replace(",", ".") & ", GETDATE())")
            Next
            
            ' Ilk asamayi aktif yap
            Dim dtIlkAsama As DataTable = SQLCalistir("SELECT TOP 1 nAsamaID FROM tbUretimAsamalar WHERE bAktif = 1 ORDER BY nSiraNo")
            If dtIlkAsama.Rows.Count > 0 Then
                Dim ilkAsamaID As Integer = Convert.ToInt32(dtIlkAsama.Rows(0)("nAsamaID"))
                SQLCalistir("UPDATE tbUretimEmriAsamalar SET sDurum = 'Devam', dteBaslangic = GETDATE() WHERE nUretimEmriID = " & evrakNo & " AND nAsamaID = " & ilkAsamaID)
                SQLCalistir("UPDATE TBLUREURETIM SET nMevcutAsama = " & ilkAsamaID & " WHERE EVRAKNO = " & evrakNo)
            End If
            
        Catch ex As Exception
            ' Hata olursa sessizce devam et (tablo yoksa vb.)
            Debug.WriteLine("UretimAsamalariOlustur hatasi: " & ex.Message)
        End Try
    End Sub
    
    ''' <summary>
    ''' Uretim asamasini tamamlar ve sonraki asamaya gecer
    ''' </summary>
    Public Sub UretimAsamaTamamla(ByVal evrakNo As Integer, ByVal nAsamaID As Integer, ByVal gerceklesenMiktar As Decimal, ByVal fireMiktar As Decimal, ByVal onaylayanID As Integer, Optional ByVal aciklama As String = "")
        Try
            ' Mevcut asamayi tamamla
            SQLCalistir("UPDATE tbUretimEmriAsamalar SET sDurum = 'Tamamlandi', dteBitis = GETDATE(), nOnaylayanID = " & onaylayanID & ", dteOnayTarihi = GETDATE(), lGerceklesenMiktar = " & gerceklesenMiktar.ToString().Replace(",", ".") & ", lFireMiktar = " & fireMiktar.ToString().Replace(",", ".") & ", sAciklama = '" & aciklama.Replace("'", "''") & "' WHERE nUretimEmriID = " & evrakNo & " AND nAsamaID = " & nAsamaID)
            
            ' Fire varsa kaydet
            If fireMiktar > 0 Then
                SQLCalistir("INSERT INTO tbUretimFire (nUretimEmriID, nAsamaID, lFireMiktar, sFireNedeni, nKaydedenID) VALUES (" & evrakNo & ", " & nAsamaID & ", " & fireMiktar.ToString().Replace(",", ".") & ", '" & aciklama.Replace("'", "''") & "', " & onaylayanID & ")")
            End If
            
            ' Sonraki asamayi bul
            Dim dtSonraki As DataTable = SQLCalistir("SELECT TOP 1 a.nAsamaID FROM tbUretimAsamalar a INNER JOIN tbUretimEmriAsamalar e ON a.nAsamaID = e.nAsamaID WHERE e.nUretimEmriID = " & evrakNo & " AND e.sDurum = 'Bekliyor' ORDER BY a.nSiraNo")
            
            If dtSonraki.Rows.Count > 0 Then
                Dim sonrakiAsamaID As Integer = Convert.ToInt32(dtSonraki.Rows(0)("nAsamaID"))
                SQLCalistir("UPDATE tbUretimEmriAsamalar SET sDurum = 'Devam', dteBaslangic = GETDATE(), lPlanlananMiktar = " & gerceklesenMiktar.ToString().Replace(",", ".") & " WHERE nUretimEmriID = " & evrakNo & " AND nAsamaID = " & sonrakiAsamaID)
                SQLCalistir("UPDATE TBLUREURETIM SET nMevcutAsama = " & sonrakiAsamaID & " WHERE EVRAKNO = " & evrakNo)
            Else
                ' Tum asamalar tamamlandi
                SQLCalistir("UPDATE TBLUREURETIM SET DURUM = 'Tamamlandı', dteGercekBitis = GETDATE() WHERE EVRAKNO = " & evrakNo)
            End If
            
        Catch ex As Exception
            MessageBox.Show("Asama tamamlama hatasi: " & ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
    
    ''' <summary>
    ''' Uretim gecikme kaydeder
    ''' </summary>
    Public Sub UretimGecikmeKaydet(ByVal evrakNo As Integer, ByVal nAsamaID As Integer, ByVal gecikmeNedeni As String, ByVal gecikmeSuresi As Integer, ByVal kaydedenID As Integer)
        Try
            SQLCalistir("INSERT INTO tbUretimGecikme (nUretimEmriID, nAsamaID, sGecikmeNedeni, nGecikmeSuresi, dteGecikmeBaslangic, nKaydedenID) VALUES (" & evrakNo & ", " & nAsamaID & ", '" & gecikmeNedeni.Replace("'", "''") & "', " & gecikmeSuresi & ", GETDATE(), " & kaydedenID & ")")
        Catch ex As Exception
            MessageBox.Show("Gecikme kaydetme hatasi: " & ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
End Class