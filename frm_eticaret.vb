Imports System.Data.OleDb
Imports System.IO
Imports System.Linq
Imports System.Net
Imports business_smart.brkdutil
Imports DevExpress.XtraEditors
Imports FastReport
Imports Microsoft.Win32
Imports Newtonsoft.Json
Imports Newtonsoft.Json.Linq
Imports System.Data
Imports System.Collections.Generic


Public Class frm_eticaret
    Public firmano
    Public donemno
    Public connection
    Public kullanici
    Public sKasaIletisim As String = ""
    Public sKasiyerRumuzu
    Dim ds_stok As DataSet
    Dim ds_Eticaret As DataSet
    Dim ds_Entegrasyon As DataSet
    Dim ds_tbFiyatTipi As DataSet
    Dim dr As DataRow
    Public frf_islem As String = "mektup"
    Dim rpl
    Dim kriter
    Dim kriter2
    Dim stokkodu
    Dim malincinsi
    Dim barkod
    Dim kod1
    Dim kod2
    Dim kod3
    Dim kod4
    Dim kod5
    Dim kod6
    Dim kod7
    Dim kod8
    Dim kod9
    Dim kod10
    Dim secfiyat
    Dim fiyat
    Dim stokkriter
    Dim tarih1
    Dim tarih2
    Dim secstatus
    Dim secsirala
    Dim kayitno
    Dim depo
    Dim aktif
    Dim qaktif
    Dim posdll As New AppYazarKasa
    Dim mevcut As Decimal = 0
    Dim x As Integer = 0
    Dim count As String = ""
    Dim okut As Boolean = True
    Dim sorgu_txt_hareket As String = ""
    Dim sAraKriter As String = ""
    Dim counter As Integer
    'Public sAktifFiyatTipi As String = sFiyat1
    Private Sub frm_eticaret_Activated(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Activated
        txt_ara.Focus()
        txt_ara.SelectAll()
        lbl_sAktifFiyatTipi.Text = sAktifFiyatTipi
    End Sub
    Private Sub frm_eticaret_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        e.Cancel = True
        Me.Hide()
    End Sub
    Private Sub frm_eticaret_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'sKasaIletisim = "Ofline+Online"
        colFIYAT1.Caption = sFiyat1Aciklama
        colFIYAT2.Caption = sFiyat2Aciklama
        colFIYAT3.Caption = sFiyat3Aciklama
        colFIYAT4.Caption = sFiyat4Aciklama
        'colTysalePrice.Caption = sFiyat5Aciklama
        'colN11salePrice.Caption = sFiyat6Aciklama
        'colGgsalePrice.Caption = sFiyat7Aciklama
        'colHbsalePrice.Caption = sFiyat8Aciklama
        'colCssalePrice.Caption = sFiyat9Aciklama
        'colAmzsalePrice.Caption = sFiyat10Aciklama
        colSinif1.Caption = sStokSinifTipi1
        colSinif2.Caption = sStokSinifTipi2
        colSinif3.Caption = sStokSinifTipi3
        colSinif4.Caption = sStokSinifTipi4
        colSinif5.Caption = sStokSinifTipi5
        colSinif6.Caption = sStokSinifTipi6
        colSinif7.Caption = sStokSinifTipi7
        colSinif8.Caption = sStokSinifTipi8
        colSinif9.Caption = sStokSinifTipi9
        colSinif10.Caption = sStokSinifTipi10
        lbl_sAktifFiyatTipi.Text = sAktifFiyatTipi
        txt_dteFisTarihi1.EditValue = dteSistemTarihi
        txt_dteFisTarihi2.EditValue = dteSistemTarihi
        dataload_tbFiyatTipi()
        Try
            gorunum_yukle()
        Catch ex As Exception
        End Try
        dataload_sRenk()
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
            If IsNumeric(Trim(txt_ara.Text)) = True And Len(txt_ara.Text) < 2 Then
                txt_ara.Text = sayiuzunlukkontrol(Trim(txt_ara.Text), 6)
            End If
            If txt_ara.Text = "" Then
                satir_ekle_stok("")
            Else
                stok_ara()
            End If
        ElseIf e.KeyCode = Keys.Up Then
            If GridView1.RowCount > 0 Then
                GridView1.Focus()
            End If
        ElseIf e.KeyCode = Keys.Escape Then
            If XtraMessageBox.Show(Sorgu_sDil("E-Ticaret Islemleri Ekranindan Cikmak Istediginize Emin misiniz...?", sDil), Sorgu_sDil("Dikkat", sDil), MessageBoxButtons.YesNo, MessageBoxIcon.Question) = MsgBoxResult.Yes Then
                Me.Close()
            End If
        End If
    End Sub
    Private Sub stok_ara()
        If Trim(txt_ara.Text) <> "" And Len(Trim(txt_ara.Text)) > 2 Then
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
                        If Len(Trim(txt_ara.Text)) < 3 Then
                            txt_ara.Text = sayiuzunlukkontrol(Trim(txt_ara.Text), 6)
                        End If
                        If IsNumeric(Trim(txt_ara.Text)) Then
                        Else
                        End If
                    End If
                End If
            End If
            Label4.Text = "Barkod Standardý Kontrolü Tamamlandý..."
            Label4.Refresh()
            stok_kontrol()
        Else
        End If
    End Sub
    Private Sub ara()
        Dim ara As New frm_stok_toplu
        If ara.ShowDialog(Me) = Windows.Forms.DialogResult.OK Then
            stokkodu = ara.stokkodu
            malincinsi = ara.malincinsi
            barkod = ara.barkod
            tarih1 = ara.tarih1
            tarih2 = ara.tarih2
            depo = ara.depo
            kod1 = ara.kod1
            kod2 = ara.kod2
            kod3 = ara.kod3
            kod4 = ara.kod4
            kod5 = ara.kod5
            kod6 = ara.kod6
            kod7 = ara.kod7
            kod8 = ara.kod8
            kod9 = ara.kod9
            kod10 = ara.kod10
            secsirala = ara.sirala
            secfiyat = ara.fiyat
            stokkriter = ara.kriter
            aktif = ara.aktif
            qaktif = ara.qaktif
            DataSet1.Clear()
            DataSet1.Dispose()
            sorgu()
            GridControl1.Select()
            GridControl1.Focus()
            ara.DataSet1.Clear()
            ara.DataSet1.Dispose()
            ara.DataSet1 = Nothing
            ara.VGridControl1.Dispose()
            ara.VGridControl1 = Nothing
            ara.Dispose()
            ara = Nothing
            'GridView1.SelectRow(0)
        End If
    End Sub
    Private Sub sorgu()
        kriter = "Where tbStok.sKodu <>'' and tbStok.nStokTipi <>5 "
        If stokkodu <> "" Then
            kriter += " AND (tbStok.sKodu LIKE '" & stokkodu & "%')"
        End If
        If malincinsi <> "" Then
            kriter += " AND (tbStok.sAciklama LIKE '" & malincinsi & "%')"
        End If
        If barkod <> "" Then
            kriter += " AND (tbStokBarkodu.sBarkod LIKE '" & barkod & "%')"
        End If
        If kod1 <> "" Then
            kriter += " AND (tbSSinif1.sAciklama LIKE '" & kod1 & "%')"
        End If
        If kod2 <> "" Then
            kriter += " AND (tbSSinif2.sAciklama LIKE '" & kod2 & "%')"
        End If
        If kod3 <> "" Then
            kriter += " AND (tbSSinif3.sAciklama LIKE '" & kod3 & "%')"
        End If
        If kod4 <> "" Then
            kriter += " AND (tbSSinif4.sAciklama LIKE '" & kod4 & "%')"
        End If
        If kod5 <> "" Then
            kriter += " AND (tbSSinif5.sAciklama LIKE '" & kod5 & "%')"
        End If
        If kod6 <> "" Then
            kriter += " AND (tbSSinif6.sAciklama LIKE '" & kod6 & "%')"
        End If
        If kod7 <> "" Then
            kriter += " AND (tbSSinif7.sAciklama LIKE '" & kod7 & "%')"
        End If
        If kod8 <> "" Then
            kriter += " AND (tbSSinif8.sAciklama LIKE '" & kod8 & "%')"
        End If
        If kod9 <> "" Then
            kriter += " AND (tbSSinif9.sAciklama LIKE '" & kod9 & "%')"
        End If
        If kod10 <> "" Then
            kriter += " AND (tbSSinif10.sAciklama LIKE '" & kod10 & "%')"
        End If
        'If aktif <> "" Then
        '    kriter += " AND (STK.STATUS " & sorgu_kriter_string(aktif, qaktif) & ")"
        'End If
        If secfiyat = "1. Satýþ Fiyatý" Then
            fiyat = 1
        ElseIf secfiyat = "2. Satýþ Fiyatý" Then
            fiyat = 2
        ElseIf secfiyat = "3. Satýþ Fiyatý" Then
            fiyat = 3
        End If
        If stokkriter = "1.Fiyatý Deðiþenler" Then
            'tarih2 = DateAdd(DateInterval.Day, 1, tarih2)
            kriter += " AND tbStok.nStokID IN (SELECT     nStokID FROM         tbStokFiyati WHERE     (dteFiyatTespitTarihi BETWEEN '" & Microsoft.VisualBasic.Left(tarih1, 10) & "' AND '" & Microsoft.VisualBasic.Left(tarih2, 10) & "') and (sFiyatTipi ='" & sFiyat1 & "')  ) "
            secstatus = 1
        ElseIf stokkriter = "2.Fiyatý Deðiþenler" Then
            'tarih2 = DateAdd(DateInterval.Day, 1, tarih2)
            kriter += " AND tbStok.nStokID IN (SELECT     nStokID FROM         tbStokFiyati WHERE     (dteFiyatTespitTarihi BETWEEN '" & Microsoft.VisualBasic.Left(tarih1, 10) & "' AND '" & Microsoft.VisualBasic.Left(tarih2, 10) & "') and (sFiyatTipi ='" & sFiyat2 & "')  ) "
            secstatus = 1
        ElseIf stokkriter = "3.Fiyatý Deðiþenler" Then
            'tarih2 = DateAdd(DateInterval.Day, 1, tarih2)
            kriter += " AND tbStok.nStokID IN (SELECT     nStokID FROM         tbStokFiyati WHERE     (dteFiyatTespitTarihi BETWEEN '" & Microsoft.VisualBasic.Left(tarih1, 10) & "' AND '" & Microsoft.VisualBasic.Left(tarih2, 10) & "') and (sFiyatTipi ='" & sFiyat3 & "')  ) "
            secstatus = 1
        ElseIf stokkriter = "Satýþ Fiyatý Deðiþenler" Then
            'tarih2 = DateAdd(DateInterval.Day, 1, tarih2)
            If fiyat = 1 Then
                kriter += " AND tbStok.nStokID IN (SELECT     nStokID FROM         tbStokFiyati WHERE     (dteFiyatTespitTarihi BETWEEN '" & Microsoft.VisualBasic.Left(tarih1, 10) & "' AND '" & Microsoft.VisualBasic.Left(tarih2, 10) & "') and (sFiyatTipi ='" & sFiyat1 & "')  ) "
            ElseIf fiyat = 2 Then
                kriter += " AND tbStok.nStokID IN (SELECT     nStokID FROM         tbStokFiyati WHERE     (dteFiyatTespitTarihi BETWEEN '" & Microsoft.VisualBasic.Left(tarih1, 10) & "' AND '" & Microsoft.VisualBasic.Left(tarih2, 10) & "') and (sFiyatTipi ='" & sFiyat2 & "')  ) "
            ElseIf fiyat = 3 Then
                kriter += " AND tbStok.nStokID IN (SELECT     nStokID FROM         tbStokFiyati WHERE     (dteFiyatTespitTarihi BETWEEN '" & Microsoft.VisualBasic.Left(tarih1, 10) & "' AND '" & Microsoft.VisualBasic.Left(tarih2, 10) & "') and (sFiyatTipi ='" & sFiyat3 & "')  ) "
            ElseIf fiyat = 3 Then
                kriter += " AND tbStok.nStokID IN (SELECT     nStokID FROM         tbStokFiyati WHERE     (dteFiyatTespitTarihi BETWEEN '" & Microsoft.VisualBasic.Left(tarih1, 10) & "' AND '" & Microsoft.VisualBasic.Left(tarih2, 10) & "') and (sFiyatTipi ='" & sFiyat4 & "')  ) "
            End If
            secstatus = 1
        ElseIf stokkriter = "Alýþ Fiyatý Deðiþenler" Then
            'tarih2 = DateAdd(DateInterval.Day, 1, tarih2)
            kriter += " AND tbStok.nStokID IN (SELECT     nStokID FROM         tbStokFiyati WHERE     (dteFiyatTespitTarihi BETWEEN '" & Microsoft.VisualBasic.Left(tarih1, 10) & "' AND '" & Microsoft.VisualBasic.Left(tarih2, 10) & "') and (sFiyatTipi ='" & sFiyatA & "') ) "
            secstatus = 1
        ElseIf stokkriter = "Maliyet Fiyatý Deðiþenler" Then
            'tarih2 = DateAdd(DateInterval.Day, 1, tarih2)
            kriter += " AND tbStok.nStokID IN (SELECT     nStokID FROM         tbStokFiyati WHERE     (dteFiyatTespitTarihi BETWEEN '" & Microsoft.VisualBasic.Left(tarih1, 10) & "' AND '" & Microsoft.VisualBasic.Left(tarih2, 10) & "') and (sFiyatTipi ='" & sFiyatM & "') ) "
            secstatus = 1
        ElseIf stokkriter = "Yeni Açýlan Stoklar" Then
            'tarih2 = DateAdd(DateInterval.Day, 1, tarih2)
            kriter += " AND tbStok.dteKayitTarihi between '" & Microsoft.VisualBasic.Left(tarih1.ToString, 10) + " 00:00:00" & "' and '" & Microsoft.VisualBasic.Left(tarih2.ToString, 10) + " 23:59:59" & "' "
            secstatus = 1
        ElseIf stokkriter = "Tüm Stoklar" Then
            kriter += ""
            secstatus = 1
        ElseIf stokkriter = "Tartýlý Stoklar" Then
            kriter += " AND (len(tbStokBarkodu.sBarkod) = 5)"
            secstatus = 1
        ElseIf stokkriter = "Plu Stoklar" Then
            kriter += " AND (len(tbStokBarkodu.sBarkod) = 6) and tbStokBarkodu.sBarkod like '000%'"
            secstatus = 1
        ElseIf stokkriter = "[Boþ Liste]" Then
            kriter += " AND (tbStok.nStokID=0)"
            secstatus = 1
        End If
        'DENEME YAP
        'kriter += " AND (birim.SATISFIYATI1 =0)"
        kriter2 = ""
        If secsirala = "STOKKODU" Then
            kriter2 += " ORDER BY tbStok.sKodu"
        ElseIf secsirala = "MALINCINSI" Then
            kriter2 += " ORDER BY tbStok.sAciklama"
        ElseIf secsirala = "BARKOD" Then
            kriter2 += " ORDER BY tbStokBarkodu.sBarkod"
        ElseIf secsirala = "OZELKOD" Then
            kriter2 += " ORDER BY tbSSinif1.sSinifkodu"
        End If
        If nKayitSinir > 0 Then
            count = " TOP " & nKayitSinir & " "
        Else
            count = ""
        End If
        Dim conn As New OleDb.OleDbConnection
        Dim cmd As New OleDb.OleDbCommand
        Dim adapter As New OleDb.OleDbDataAdapter
        conn.ConnectionString = connection
        cmd.CommandTimeout = False
        adapter.SelectCommand = cmd
        cmd.Connection = conn
        conn.Open()
        cmd.CommandText = sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT " & count & " tbStok.*, tbStokBarkodu.sBarkod, tbSSinif1.sAciklama AS Sinif1, tbSSinif2.sAciklama AS Sinif2, tbSSinif3.sAciklama AS Sinif3, tbSSinif4.sAciklama AS Sinif4, tbSSinif5.sAciklama AS Sinif5, tbSSinif6.sAciklama AS Sinif6, tbSSinif7.sAciklama AS Sinif7, tbSSinif8.sAciklama AS Sinif8, tbSSinif9.sAciklama AS Sinif9, tbSSinif10.sAciklama AS Sinif10, tbSSinif11.sAciklama AS Sinif11, tbSSinif12.sAciklama AS Sinif12, tbSSinif13.sAciklama AS Sinif13, tbSSinif14.sAciklama AS Sinif14, tbSSinif15.sAciklama AS Sinif15, ISNULL(tbStokAciklama.sAciklama1 + ' ' + tbStokAciklama.sAciklama2 + ' ' + tbStokAciklama.sAciklama3 + ' ' + tbStokAciklama.sAciklama4 + ' ' + tbStokAciklama.sAciklama5 + ' ' + tbStokAciklama.sAciklama6 + ' ' + tbStokAciklama.sAciklama7 + ' ' + tbStokAciklama.sAciklama8 + ' ' + tbStokAciklama.sAciklama9 + ' ' + tbStokAciklama.sAciklama10, '') AS ISTIHBARAT,(SELECT isnull(SUM(tbStokFisiDetayi.lGirisMiktar1 - tbStokFisiDetayi.lCikisMiktar1) , 0) FROM tbStokFisiDetayi WHERE tbStok.nStokID = tbStokFisiDetayi.nStokID) AS Mevcut,ISNULL((SELECT isnull(lfiyat , 0) FROM tbstokfiyati WHERE nStokId = tbStok.NstokId AND sFiyatTipi = '" & sFiyat1 & "'),0) AS FIYAT1, ISNULL((SELECT isnull(lfiyat , 0) FROM tbstokfiyati WHERE nStokId = tbStok.NstokId AND sFiyatTipi = '" & sFiyat2 & "'),0) AS FIYAT2,ISNULL((SELECT isnull(lfiyat , 0) FROM tbstokfiyati WHERE nStokId = tbStok.NstokId AND sFiyatTipi = '" & sFiyat3 & "'),0) AS FIYAT3,ISNULL((SELECT isnull(lfiyat , 0) FROM tbstokfiyati WHERE nStokId = tbStok.NstokId AND sFiyatTipi = '" & sFiyat4 & "'),0) AS FIYAT4,ISNULL((SELECT isnull(lfiyat , 0) FROM tbstokfiyati WHERE nStokId = tbStok.NstokId AND sFiyatTipi = '" & sFiyat5 & "'),0) AS FIYAT5,ISNULL((SELECT isnull(lfiyat , 0) FROM tbstokfiyati WHERE nStokId = tbStok.NstokId AND sFiyatTipi = '" & sFiyat6 & "'),0) AS FIYAT6,ISNULL((SELECT isnull(lfiyat , 0) FROM tbstokfiyati WHERE nStokId = tbStok.NstokId AND sFiyatTipi = '" & sFiyat7 & "'),0) AS FIYAT7,ISNULL((SELECT isnull(lfiyat , 0) FROM tbstokfiyati WHERE nStokId = tbStok.NstokId AND sFiyatTipi = '" & sFiyat8 & "'),0) AS FIYAT8,ISNULL((SELECT isnull(lfiyat , 0) FROM tbstokfiyati WHERE nStokId = tbStok.NstokId AND sFiyatTipi = '" & sFiyat9 & "'),0) AS FIYAT9,ISNULL((SELECT isnull(lfiyat , 0) FROM tbstokfiyati WHERE nStokId = tbStok.NstokId AND sFiyatTipi = '" & sFiyat10 & "'),0) AS FIYAT10,ISNULL((SELECT isnull(lfiyat , 0) FROM tbstokfiyati WHERE nStokId = tbStok.NstokId AND sFiyatTipi = '" & sFiyatA & "'),0) AS FIYATA,ISNULL((SELECT isnull(lfiyat , 0) FROM tbstokfiyati WHERE nStokId = tbStok.NstokId AND sFiyatTipi = '" & sFiyatM & "'),0) AS FIYATM,(SELECT     nKdvOrani FROM         tbKdv Where sKdvTipi = tbStok.sKdvTipi) as nKdvOrani,CAST(1 as Money) as lMiktar  FROM tbStok INNER JOIN tbStokBarkodu ON tbStok.nStokID = tbStokBarkodu.nStokID and tbStokBarkodu.nKisim = 0 INNER JOIN tbStokSinifi ON tbStok.nStokID = tbStokSinifi.nStokID INNER JOIN tbSSinif1 ON tbStokSinifi.sSinifKodu1 = tbSSinif1.sSinifKodu INNER JOIN tbSSinif2 ON tbStokSinifi.sSinifKodu2 = tbSSinif2.sSinifKodu INNER JOIN tbSSinif3 ON tbStokSinifi.sSinifKodu3 = tbSSinif3.sSinifKodu INNER JOIN tbSSinif4 ON tbStokSinifi.sSinifKodu4 = tbSSinif4.sSinifKodu INNER JOIN tbSSinif5 ON tbStokSinifi.sSinifKodu5 = tbSSinif5.sSinifKodu INNER JOIN tbSSinif6 ON tbStokSinifi.sSinifKodu6 = tbSSinif6.sSinifKodu INNER JOIN tbSSinif7 ON tbStokSinifi.sSinifKodu7 = tbSSinif7.sSinifKodu INNER JOIN tbSSinif8 ON tbStokSinifi.sSinifKodu8 = tbSSinif8.sSinifKodu INNER JOIN tbSSinif9 ON tbStokSinifi.sSinifKodu9 = tbSSinif9.sSinifKodu INNER JOIN tbSSinif10 ON tbStokSinifi.sSinifKodu10 = tbSSinif10.sSinifKodu INNER JOIN tbSSinif11 ON tbStokSinifi.sSinifKodu11 = tbSSinif11.sSinifKodu INNER JOIN tbSSinif12 ON tbStokSinifi.sSinifKodu12 = tbSSinif12.sSinifKodu INNER JOIN tbSSinif13 ON tbStokSinifi.sSinifKodu13 = tbSSinif13.sSinifKodu INNER JOIN tbSSinif14 ON tbStokSinifi.sSinifKodu14 = tbSSinif14.sSinifKodu INNER JOIN tbSSinif15 ON tbStokSinifi.sSinifKodu15 = tbSSinif15.sSinifKodu LEFT OUTER JOIN tbStokAciklama ON tbStok.nStokID = tbStokAciklama.nStokID " & kriter & " " & kriter2 & "")
        Dim N As Integer = adapter.Fill(DataSet1.Tables(0))
        conn.Close()
        N = Nothing
        cmd = Nothing
        adapter = Nothing
        If GridView1.RowCount > 0 Then
            GridView1.ClearSelection()
            GridView1.SelectRow(GridView1.RowCount - 1)
            PanelControl3.Focus()
            GridControl1.Focus()
        Else
            XtraMessageBox.Show(Sorgu_sDil("Kayýt Bulunamadý...", sDil), Sorgu_sDil("Dikkat", sDil), MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub
    Private Sub dataload(ByVal ara As String, ByVal konum As String, ByVal ara_kriter As String, ByVal dteTarih1 As DateTime, ByVal dteTarih2 As DateTime, ByVal sFiyat As String, ByVal sKriter As String, ByVal sSirala As String)
        tarih1 = dteTarih1
        tarih2 = dteTarih2
        kriter = "Where tbStok.sKodu <>'' and tbStok.nStokTipi < 5 "
        If Trim(ara).ToString <> "" Then
            If konum = "Kod" Then
                kriter += " AND( tbStok.sKodu " & sorgu_kriter_string(ara, ara_kriter) & " )"
            ElseIf konum = "Ad" Then
                kriter += " AND ( tbStok.sAciklama " & sorgu_kriter_string(ara, ara_kriter) & " )"
            ElseIf konum = "Barkod" Then
                kriter += " AND ( tbStokBarkodu.sBarkod " & sorgu_kriter_string(ara, ara_kriter) & " )"
            ElseIf konum = "Geliþmiþ" Then
                kriter += " AND ( tbStokBarkodu.sBarkod " & sorgu_kriter_string(ara, ara_kriter) & " ) or ( tbStok.sKodu " & sorgu_kriter_string(ara, ara_kriter) & " ) or ( tbStok.sAciklama " & sorgu_kriter_string(ara, ara_kriter) & " ) or ( tbStok.sKisaAdi " & sorgu_kriter_string(ara, ara_kriter) & " ) "
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
        'If aktif <> "" Then
        '    kriter += " AND (STK.STATUS " & sorgu_kriter_string(aktif, qaktif) & ")"
        'End If
        If sFiyat = "1. Satýþ Fiyatý" Then
            fiyat = sFiyat1
        ElseIf sFiyat = "2. Satýþ Fiyatý" Then
            fiyat = sFiyat2
        ElseIf sFiyat = "3. Satýþ Fiyatý" Then
            fiyat = sFiyat3
        ElseIf sFiyat = "4. Satýþ Fiyatý" Then
            fiyat = sFiyat4
        Else
            fiyat = sFiyat
        End If
        If sKriter = "1.Fiyatý Deðiþenler" Then
            'tarih2 = DateAdd(DateInterval.Day, 1, tarih2)
            kriter += " AND tbStok.nStokID IN (SELECT     nStokID FROM         tbStokFiyati WHERE     (dteFiyatTespitTarihi BETWEEN '" & Microsoft.VisualBasic.Left(tarih1, 10) & "' AND '" & Microsoft.VisualBasic.Left(tarih2, 10) & "') and (sFiyatTipi ='" & sFiyat1 & "')  ) "
            secstatus = 1
        ElseIf sKriter = "2.Fiyatý Deðiþenler" Then
            'tarih2 = DateAdd(DateInterval.Day, 1, tarih2)
            kriter += " AND tbStok.nStokID IN (SELECT     nStokID FROM         tbStokFiyati WHERE     (dteFiyatTespitTarihi BETWEEN '" & Microsoft.VisualBasic.Left(tarih1, 10) & "' AND '" & Microsoft.VisualBasic.Left(tarih2, 10) & "') and (sFiyatTipi ='" & sFiyat2 & "')  ) "
            secstatus = 1
        ElseIf sKriter = "3.Fiyatý Deðiþenler" Then
            'tarih2 = DateAdd(DateInterval.Day, 1, tarih2)
            kriter += " AND tbStok.nStokID IN (SELECT     nStokID FROM         tbStokFiyati WHERE     (dteFiyatTespitTarihi BETWEEN '" & Microsoft.VisualBasic.Left(tarih1, 10) & "' AND '" & Microsoft.VisualBasic.Left(tarih2, 10) & "') and (sFiyatTipi ='" & sFiyat3 & "')  ) "
            secstatus = 1
        ElseIf sKriter = "Satýþ Fiyatý Deðiþenler" Then
            'tarih2 = DateAdd(DateInterval.Day, 1, tarih2)
            If fiyat = "" Then
                kriter += " AND tbStok.nStokID IN (SELECT     nStokID FROM         tbStokFiyati WHERE     (dteFiyatTespitTarihi BETWEEN '" & Microsoft.VisualBasic.Left(tarih1, 10) & "' AND '" & Microsoft.VisualBasic.Left(tarih2, 10) & "') and (sFiyatTipi NOT IN ('" & sFiyatA & "','" & sFiyatM & "'))  ) "
            Else
                kriter += " AND tbStok.nStokID IN (SELECT     nStokID FROM         tbStokFiyati WHERE     (dteFiyatTespitTarihi BETWEEN '" & Microsoft.VisualBasic.Left(tarih1, 10) & "' AND '" & Microsoft.VisualBasic.Left(tarih2, 10) & "') and (sFiyatTipi ='" & fiyat & "')  ) "
            End If
            'If fiyat = 1 Then
            '    kriter += " AND tbStok.nStokID IN (SELECT     nStokID FROM         tbStokFiyati WHERE     (dteFiyatTespitTarihi BETWEEN '" & Microsoft.VisualBasic.Left(tarih1, 10) & "' AND '" & Microsoft.VisualBasic.Left(tarih2, 10) & "') and (sFiyatTipi ='" & sFiyat1 & "')  ) "
            'ElseIf fiyat = 2 Then
            '    kriter += " AND tbStok.nStokID IN (SELECT     nStokID FROM         tbStokFiyati WHERE     (dteFiyatTespitTarihi BETWEEN '" & Microsoft.VisualBasic.Left(tarih1, 10) & "' AND '" & Microsoft.VisualBasic.Left(tarih2, 10) & "') and (sFiyatTipi ='" & sFiyat2 & "')  ) "
            'ElseIf fiyat = 3 Then
            '    kriter += " AND tbStok.nStokID IN (SELECT     nStokID FROM         tbStokFiyati WHERE     (dteFiyatTespitTarihi BETWEEN '" & Microsoft.VisualBasic.Left(tarih1, 10) & "' AND '" & Microsoft.VisualBasic.Left(tarih2, 10) & "') and (sFiyatTipi ='" & sFiyat3 & "')  ) "
            'ElseIf fiyat = 4 Then
            '    kriter += " AND tbStok.nStokID IN (SELECT     nStokID FROM         tbStokFiyati WHERE     (dteFiyatTespitTarihi BETWEEN '" & Microsoft.VisualBasic.Left(tarih1, 10) & "' AND '" & Microsoft.VisualBasic.Left(tarih2, 10) & "') and (sFiyatTipi ='" & sFiyat4 & "')  ) "
            'Else
            '    kriter += " AND tbStok.nStokID IN (SELECT     nStokID FROM         tbStokFiyati WHERE     (dteFiyatTespitTarihi BETWEEN '" & Microsoft.VisualBasic.Left(tarih1, 10) & "' AND '" & Microsoft.VisualBasic.Left(tarih2, 10) & "') and (sFiyatTipi NOT IN ('" & sFiyatA & "','" & sFiyatM & "'))  ) "
            'End If
            secstatus = 1
        ElseIf sKriter = "Alýþ Fiyatý Deðiþenler" Then
            'tarih2 = DateAdd(DateInterval.Day, 1, tarih2)
            kriter += " AND tbStok.nStokID IN (SELECT     nStokID FROM         tbStokFiyati WHERE     (dteFiyatTespitTarihi BETWEEN '" & Microsoft.VisualBasic.Left(tarih1, 10) & "' AND '" & Microsoft.VisualBasic.Left(tarih2, 10) & "') and (sFiyatTipi ='" & sFiyatA & "') ) "
            secstatus = 1
        ElseIf sKriter = "Maliyet Fiyatý Deðiþenler" Then
            'tarih2 = DateAdd(DateInterval.Day, 1, tarih2)
            kriter += " AND tbStok.nStokID IN (SELECT     nStokID FROM         tbStokFiyati WHERE     (dteFiyatTespitTarihi BETWEEN '" & Microsoft.VisualBasic.Left(tarih1, 10) & "' AND '" & Microsoft.VisualBasic.Left(tarih2, 10) & "') and (sFiyatTipi ='" & sFiyatM & "') ) "
            secstatus = 1
        ElseIf sKriter = "Yeni Açýlan Stoklar" Then
            'tarih2 = DateAdd(DateInterval.Day, 1, tarih2)
            kriter += " AND tbStok.dteKayitTarihi between '" & Microsoft.VisualBasic.Left(tarih1.ToString, 10) + " 00:00:00" & "' and '" & Microsoft.VisualBasic.Left(tarih2.ToString, 10) + " 23:59:59" & "' "
            secstatus = 1
        ElseIf sKriter = "Tüm Stoklar" Then
            kriter += ""
            secstatus = 1
        ElseIf sKriter = "Tartýlý Stoklar" Then
            kriter += " AND (len(tbStokBarkodu.sBarkod) = 5)"
            secstatus = 1
        ElseIf stokkriter = "Plu Stoklar" Then
            kriter += " AND (len(tbStokBarkodu.sBarkod) = 6) and tbStokBarkodu.sBarkod like '000%'"
            secstatus = 1
        ElseIf sKriter = "[Boþ Liste]" Then
            kriter += " AND (tbStok.nStokID=0)"
            secstatus = 1
        End If
        'DENEME YAP
        'kriter += " AND (birim.SATISFIYATI1 =0)"
        kriter2 = ""
        If sSirala = "STOKKODU" Then
            kriter2 += " ORDER BY tbStok.sKodu"
        ElseIf sSirala = "MALINCINSI" Then
            kriter2 += " ORDER BY tbStok.sAciklama"
        ElseIf sSirala = "BARKOD" Then
            kriter2 += " ORDER BY tbStokBarkodu.sBarkod"
        ElseIf sSirala = "OZELKOD" Then
            kriter2 += " ORDER BY tbSSinif1.sSinifkodu"
        End If
        If nKayitSinir > 0 Then
            count = " TOP " & nKayitSinir & " "
        Else
            count = ""
        End If
        Dim conn As New OleDb.OleDbConnection
        Dim cmd As New OleDb.OleDbCommand
        Dim adapter As New OleDb.OleDbDataAdapter
        conn.ConnectionString = connection
        cmd.CommandTimeout = False
        adapter.SelectCommand = cmd
        cmd.Connection = conn
        conn.Open()
        cmd.CommandText = sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT " & count & " tbStok.*, tbStokBarkodu.sBarkod, tbSSinif1.sAciklama AS Sinif1, tbSSinif2.sAciklama AS Sinif2, tbSSinif3.sAciklama AS Sinif3, tbSSinif4.sAciklama AS Sinif4, tbSSinif5.sAciklama AS Sinif5, tbSSinif6.sAciklama AS Sinif6, tbSSinif7.sAciklama AS Sinif7, tbSSinif8.sAciklama AS Sinif8, tbSSinif9.sAciklama AS Sinif9, tbSSinif10.sAciklama AS Sinif10, tbSSinif11.sAciklama AS Sinif11, tbSSinif12.sAciklama AS Sinif12, tbSSinif13.sAciklama AS Sinif13, tbSSinif14.sAciklama AS Sinif14, tbSSinif15.sAciklama AS Sinif15, ISNULL(tbStokAciklama.sAciklama1 + ' ' + tbStokAciklama.sAciklama2 + ' ' + tbStokAciklama.sAciklama3 + ' ' + tbStokAciklama.sAciklama4 + ' ' + tbStokAciklama.sAciklama5 + ' ' + tbStokAciklama.sAciklama6 + ' ' + tbStokAciklama.sAciklama7 + ' ' + tbStokAciklama.sAciklama8 + ' ' + tbStokAciklama.sAciklama9 + ' ' + tbStokAciklama.sAciklama10, '') AS ISTIHBARAT,(SELECT isnull(SUM(tbStokFisiDetayi.lGirisMiktar1 - tbStokFisiDetayi.lCikisMiktar1) , 0) FROM tbStokFisiDetayi WHERE tbStok.nStokID = tbStokFisiDetayi.nStokID) AS Mevcut,ISNULL((SELECT isnull(lfiyat , 0) FROM tbstokfiyati WHERE nStokId = tbStok.NstokId AND sFiyatTipi = '" & sFiyat1 & "'),0) AS FIYAT1, ISNULL((SELECT isnull(lfiyat , 0) FROM tbstokfiyati WHERE nStokId = tbStok.NstokId AND sFiyatTipi = '" & sFiyat2 & "'),0) AS FIYAT2,ISNULL((SELECT isnull(lfiyat , 0) FROM tbstokfiyati WHERE nStokId = tbStok.NstokId AND sFiyatTipi = '" & sFiyat3 & "'),0) AS FIYAT3,ISNULL((SELECT isnull(lfiyat , 0) FROM tbstokfiyati WHERE nStokId = tbStok.NstokId AND sFiyatTipi = '" & sFiyatM & "'),0) AS FIYATM,ISNULL((SELECT isnull(lfiyat , 0) FROM tbstokfiyati WHERE nStokId = tbStok.NstokId AND sFiyatTipi = '" & sAktifFiyatTipi & "'),0) AS lFiyat,ISNULL((SELECT isnull(lfiyat , 0) FROM tbstokfiyati WHERE nStokId = tbStok.NstokId AND sFiyatTipi = '" & sFiyatA & "'),0) AS FIYATA,ISNULL((SELECT isnull(lfiyat , 0) FROM tbstokfiyati WHERE nStokId = tbStok.NstokId AND sFiyatTipi = '" & sFiyat4 & "'),0) AS FIYAT4,ISNULL((SELECT isnull(lfiyat , 0) FROM tbstokfiyati WHERE nStokId = tbStok.NstokId AND sFiyatTipi = '" & sFiyat5 & "'),0) AS FIYAT5,ISNULL((SELECT isnull(lfiyat , 0) FROM tbstokfiyati WHERE nStokId = tbStok.NstokId AND sFiyatTipi = '" & sFiyat6 & "'),0) AS FIYAT6,ISNULL((SELECT isnull(lfiyat , 0) FROM tbstokfiyati WHERE nStokId = tbStok.NstokId AND sFiyatTipi = '" & sFiyat7 & "'),0) AS FIYAT7,ISNULL((SELECT isnull(lfiyat , 0) FROM tbstokfiyati WHERE nStokId = tbStok.NstokId AND sFiyatTipi = '" & sFiyat8 & "'),0) AS FIYAT8,ISNULL((SELECT isnull(lfiyat , 0) FROM tbstokfiyati WHERE nStokId = tbStok.NstokId AND sFiyatTipi = '" & sFiyat9 & "'),0) AS FIYAT9,ISNULL((SELECT isnull(lfiyat , 0) FROM tbstokfiyati WHERE nStokId = tbStok.NstokId AND sFiyatTipi = '" & sFiyat10 & "'),0) AS FIYAT10,(SELECT     nKdvOrani FROM         tbKdv Where sKdvTipi = tbStok.sKdvTipi) as nKdvOrani,(Select ISNULL(sRenkAdi,'') from tbRenk Where sRenk = tbStok.sRenk) as sRenkAdi,ISNULL((SELECT ISNULL(lOran , 1) FROM tbStokBirimCevrimi WHERE nStokID = tbStok.nStokID AND sBirimCinsi = tbStok.sBirimCinsi2), 1) AS lBirimCarpan,CAST(1 as Money) as lMiktar,CAST(0 AS MONEY) nOran  FROM tbStok INNER JOIN tbStokBarkodu ON tbStok.nStokID = tbStokBarkodu.nStokID and tbStokBarkodu.nKisim = 0 INNER JOIN tbStokSinifi ON tbStok.nStokID = tbStokSinifi.nStokID INNER JOIN tbSSinif1 ON tbStokSinifi.sSinifKodu1 = tbSSinif1.sSinifKodu INNER JOIN tbSSinif2 ON tbStokSinifi.sSinifKodu2 = tbSSinif2.sSinifKodu INNER JOIN tbSSinif3 ON tbStokSinifi.sSinifKodu3 = tbSSinif3.sSinifKodu INNER JOIN tbSSinif4 ON tbStokSinifi.sSinifKodu4 = tbSSinif4.sSinifKodu INNER JOIN tbSSinif5 ON tbStokSinifi.sSinifKodu5 = tbSSinif5.sSinifKodu INNER JOIN tbSSinif6 ON tbStokSinifi.sSinifKodu6 = tbSSinif6.sSinifKodu INNER JOIN tbSSinif7 ON tbStokSinifi.sSinifKodu7 = tbSSinif7.sSinifKodu INNER JOIN tbSSinif8 ON tbStokSinifi.sSinifKodu8 = tbSSinif8.sSinifKodu INNER JOIN tbSSinif9 ON tbStokSinifi.sSinifKodu9 = tbSSinif9.sSinifKodu INNER JOIN tbSSinif10 ON tbStokSinifi.sSinifKodu10 = tbSSinif10.sSinifKodu INNER JOIN tbSSinif11 ON tbStokSinifi.sSinifKodu11 = tbSSinif11.sSinifKodu INNER JOIN tbSSinif12 ON tbStokSinifi.sSinifKodu12 = tbSSinif12.sSinifKodu INNER JOIN tbSSinif13 ON tbStokSinifi.sSinifKodu13 = tbSSinif13.sSinifKodu INNER JOIN tbSSinif14 ON tbStokSinifi.sSinifKodu14 = tbSSinif14.sSinifKodu INNER JOIN tbSSinif15 ON tbStokSinifi.sSinifKodu15 = tbSSinif15.sSinifKodu LEFT OUTER JOIN tbStokAciklama ON tbStok.nStokID = tbStokAciklama.nStokID " & kriter & " " & kriter2 & "")
        Dim N As Integer = adapter.Fill(DataSet1.Tables(0))
        conn.Close()
        N = Nothing
        For Each dr In DataSet1.Tables(0).Rows
            If dr("lFiyat") = 0 Then
            Else
                dr("FIYAT1") = dr("lFiyat")
            End If
            Try
                If dr("FIYAT1") <> 0 Then
                    dr("nOran") = ((dr("FIYAT1") - dr("FIYATM")) / dr("FIYATM")) * 100
                Else
                    dr("nOran") = 0
                End If
            Catch ex As Exception
            End Try
        Next
        cmd = Nothing
        adapter = Nothing
        If GridView1.RowCount > 0 Then
            GridView1.ClearSelection()
            GridView1.SelectRow(GridView1.RowCount - 1)
            PanelControl3.Focus()
            GridControl1.Focus()
        Else
            XtraMessageBox.Show(Sorgu_sDil("Kayýt Bulunamadý...", sDil), Sorgu_sDil("Dikkat", sDil), MessageBoxButtons.OK, MessageBoxIcon.Information)
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

    Private Sub stok_kontrol()
        If IsNumeric(Trim(txt_ara.Text)) = True Then
            okut = True
        Else
            okut = False
        End If
        Label4.Text = "Stok Kartý Kontrolü Yapýlýyor..."
        Label4.Refresh()
        Dim kontrol = sorgu_stok_kontrol(txt_ara.EditValue, sec_kriter.Text)
        If kontrol = 0 Then
            Label4.Text = "Stok Kaydý Bulunamadý!!!.Tekrar Deneyiniz..."
            Label4.Refresh()
            txt_ara.Focus()
            txt_ara.SelectAll()
            If XtraMessageBox.Show(Sorgu_sDil("Kayýt Bulunumadý..." & vbCrLf & "Yeni Kayýt Eklemek Ýster misiniz...?", sDil), Sorgu_sDil("Dikkat", sDil), MessageBoxButtons.YesNo, MessageBoxIcon.Question) = MsgBoxResult.Yes Then
                stok_yeni(txt_ara.Text)
            End If
        ElseIf kontrol = 1 Then
            Label4.Text = "Belge Stok Kaydý Kontrol Ediliyor... "
            Label4.Refresh()
            'MsgBox(Sorgu_sDil("Kayýt Tek...")
            'dataload_stok(Trim(txt_ara.Text), sec_kriter.Text)
            Label4.Text = "Stok Bilgisi Yükleniyor... "
            Label4.Refresh()
            satir_ekle_stok_tek(False)
        ElseIf kontrol > 1 Then
            satir_ekle_stok(Trim(txt_ara.Text), sAraKriter)
        End If
    End Sub
    Private Sub gorunum_kaydet()
        GridView1.SaveLayoutToRegistry("SOFTWARE\BusinessSmart\VIEW\STOK\" & Me.Name.ToString & "")
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
        For Each itm In kisayol.Items
            itm.text = Sorgu_sDil(itm.text, sDil)
        Next
        SimpleButton1.Text = Sorgu_sDil(SimpleButton1.Text, sDil)
        SimpleButton2.Text = Sorgu_sDil(SimpleButton2.Text, sDil)
        GridView1.RestoreLayoutFromRegistry("SOFTWARE\BusinessSmart\VIEW\STOK\" & Me.Name.ToString & "")
    End Sub
    Private Sub dataload_sRenk()
        sec_renk.DataSource = sorgu(sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT * FROM tbRenk")).Tables(0) 'DataSet2.Tables(0)
    End Sub
    Private Function sorgu(ByVal query As String, Optional ByVal sTable As String = "TABLE1") As DataSet
        Dim conn As New OleDb.OleDbConnection
        Dim adapter As New OleDb.OleDbDataAdapter
        Dim cmd As New OleDb.OleDbCommand
        conn.ConnectionString = connection
        cmd.CommandTimeout = False
        adapter.SelectCommand = cmd
        cmd.CommandText = query
        cmd.Connection = conn
        conn.Open()
        Dim DS As New DataSet
        Dim N As Integer = adapter.Fill(DS, sTable)
        conn.Close()
        Return DS
        cmd = Nothing
        adapter = Nothing
    End Function
    Private Function sorgu_query(ByVal query As String) As String
        query = Replace(query, "*!F", "F0" + firmano.ToString)
        query = Replace(query, "!D", "D000" + donemno.ToString)
        Return query
    End Function
    Public Function sorgu_queryJson(ByVal query As String) As String

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
            ds_stok = sorgu(sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT tbStok.*, tbStokBarkodu.sBarkod, tbSSinif1.sAciklama AS Sinif1, tbSSinif2.sAciklama AS Sinif2, tbSSinif3.sAciklama AS Sinif3, tbSSinif4.sAciklama AS Sinif4, tbSSinif5.sAciklama AS Sinif5, tbSSinif6.sAciklama AS Sinif6, tbSSinif7.sAciklama AS Sinif7, tbSSinif8.sAciklama AS Sinif8, tbSSinif9.sAciklama AS Sinif9, tbSSinif10.sAciklama AS Sinif10, tbSSinif11.sAciklama AS Sinif11, tbSSinif12.sAciklama AS Sinif12, tbSSinif13.sAciklama AS Sinif13, tbSSinif14.sAciklama AS Sinif14, tbSSinif15.sAciklama AS Sinif15, ISNULL(tbStokAciklama.sAciklama1 + ' ' + tbStokAciklama.sAciklama2 + ' ' + tbStokAciklama.sAciklama3 + ' ' + tbStokAciklama.sAciklama4 + ' ' + tbStokAciklama.sAciklama5 + ' ' + tbStokAciklama.sAciklama6 + ' ' + tbStokAciklama.sAciklama7 + ' ' + tbStokAciklama.sAciklama8 + ' ' + tbStokAciklama.sAciklama9 + ' ' + tbStokAciklama.sAciklama10, '') AS ISTIHBARAT,(SELECT isnull(SUM(tbStokFisiDetayi.lGirisMiktar1 - tbStokFisiDetayi.lCikisMiktar1) , 0) FROM tbStokFisiDetayi WHERE tbStok.nStokID = tbStokFisiDetayi.nStokID) AS Mevcut,ISNULL((SELECT isnull(lfiyat , 0) FROM tbstokfiyati WHERE nStokId = tbStok.NstokId AND sFiyatTipi = '" & sFiyat1 & "'),0) AS FIYAT1, ISNULL((SELECT isnull(lfiyat , 0) FROM tbstokfiyati WHERE nStokId = tbStok.NstokId AND sFiyatTipi = '" & sFiyat2 & "'),0) AS FIYAT2,ISNULL((SELECT isnull(lfiyat , 0) FROM tbstokfiyati WHERE nStokId = tbStok.NstokId AND sFiyatTipi = '" & sFiyat3 & "'),0) AS FIYAT3,ISNULL((SELECT isnull(lfiyat , 0) FROM tbstokfiyati WHERE nStokId = tbStok.NstokId AND sFiyatTipi = '" & sFiyatM & "'),0) AS FIYATM,ISNULL((SELECT isnull(lfiyat , 0) FROM tbstokfiyati WHERE nStokId = tbStok.NstokId AND sFiyatTipi = '" & sFiyatA & "'),0) AS FIYATA,ISNULL((SELECT isnull(lfiyat , 0) FROM tbstokfiyati WHERE nStokId = tbStok.NstokId AND sFiyatTipi = '" & sFiyat4 & "'),0) AS FIYAT4,ISNULL((SELECT isnull(lfiyat , 0) FROM tbstokfiyati WHERE nStokId = tbStok.NstokId AND sFiyatTipi = '" & sFiyat5 & "'),0) AS FIYAT5,ISNULL((SELECT isnull(lfiyat , 0) FROM tbstokfiyati WHERE nStokId = tbStok.NstokId AND sFiyatTipi = '" & sFiyat6 & "'),0) AS FIYAT6,ISNULL((SELECT isnull(lfiyat , 0) FROM tbstokfiyati WHERE nStokId = tbStok.NstokId AND sFiyatTipi = '" & sFiyat7 & "'),0) AS FIYAT7,ISNULL((SELECT isnull(lfiyat , 0) FROM tbstokfiyati WHERE nStokId = tbStok.NstokId AND sFiyatTipi = '" & sFiyat8 & "'),0) AS FIYAT8,ISNULL((SELECT isnull(lfiyat , 0) FROM tbstokfiyati WHERE nStokId = tbStok.NstokId AND sFiyatTipi = '" & sFiyat9 & "'),0) AS FIYAT9,ISNULL((SELECT isnull(lfiyat , 0) FROM tbstokfiyati WHERE nStokId = tbStok.NstokId AND sFiyatTipi = '" & sFiyat10 & "'),0) AS FIYAT10,ISNULL((SELECT isnull(lfiyat , 0) FROM tbstokfiyati WHERE nStokId = tbStok.NstokId AND sFiyatTipi = '" & sAktifFiyatTipi & "'),0) AS lFiyat,(SELECT     nKdvOrani FROM         tbKdv Where sKdvTipi = tbStok.sKdvTipi) as nKdvOrani,ISNULL((SELECT ISNULL(lOran , 1) FROM tbStokBirimCevrimi WHERE nStokID = tbStok.nStokID AND sBirimCinsi = tbStok.sBirimCinsi2), 1) AS lBirimCarpan,CAST(0 as Money) as lMiktar  FROM tbStok INNER JOIN tbStokBarkodu ON tbStok.nStokID = tbStokBarkodu.nStokID and tbStokBarkodu.nKisim = 0 INNER JOIN tbStokSinifi ON tbStok.nStokID = tbStokSinifi.nStokID INNER JOIN tbSSinif1 ON tbStokSinifi.sSinifKodu1 = tbSSinif1.sSinifKodu INNER JOIN tbSSinif2 ON tbStokSinifi.sSinifKodu2 = tbSSinif2.sSinifKodu INNER JOIN tbSSinif3 ON tbStokSinifi.sSinifKodu3 = tbSSinif3.sSinifKodu INNER JOIN tbSSinif4 ON tbStokSinifi.sSinifKodu4 = tbSSinif4.sSinifKodu INNER JOIN tbSSinif5 ON tbStokSinifi.sSinifKodu5 = tbSSinif5.sSinifKodu INNER JOIN tbSSinif6 ON tbStokSinifi.sSinifKodu6 = tbSSinif6.sSinifKodu INNER JOIN tbSSinif7 ON tbStokSinifi.sSinifKodu7 = tbSSinif7.sSinifKodu INNER JOIN tbSSinif8 ON tbStokSinifi.sSinifKodu8 = tbSSinif8.sSinifKodu INNER JOIN tbSSinif9 ON tbStokSinifi.sSinifKodu9 = tbSSinif9.sSinifKodu INNER JOIN tbSSinif10 ON tbStokSinifi.sSinifKodu10 = tbSSinif10.sSinifKodu INNER JOIN tbSSinif11 ON tbStokSinifi.sSinifKodu11 = tbSSinif11.sSinifKodu INNER JOIN tbSSinif12 ON tbStokSinifi.sSinifKodu12 = tbSSinif12.sSinifKodu INNER JOIN tbSSinif13 ON tbStokSinifi.sSinifKodu13 = tbSSinif13.sSinifKodu INNER JOIN tbSSinif14 ON tbStokSinifi.sSinifKodu14 = tbSSinif14.sSinifKodu INNER JOIN tbSSinif15 ON tbStokSinifi.sSinifKodu15 = tbSSinif15.sSinifKodu LEFT OUTER JOIN tbStokAciklama ON tbStok.nStokID = tbStokAciklama.nStokID " & kriter & " ORDER BY tbStok.sKodu"))
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
                ds_stok = sorgu(sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT tbStok.*, tbStokBarkodu.sBarkod, tbSSinif1.sAciklama AS Sinif1, tbSSinif2.sAciklama AS Sinif2, tbSSinif3.sAciklama AS Sinif3, tbSSinif4.sAciklama AS Sinif4, tbSSinif5.sAciklama AS Sinif5, tbSSinif6.sAciklama AS Sinif6, tbSSinif7.sAciklama AS Sinif7, tbSSinif8.sAciklama AS Sinif8, tbSSinif9.sAciklama AS Sinif9, tbSSinif10.sAciklama AS Sinif10, tbSSinif11.sAciklama AS Sinif11, tbSSinif12.sAciklama AS Sinif12, tbSSinif13.sAciklama AS Sinif13, tbSSinif14.sAciklama AS Sinif14, tbSSinif15.sAciklama AS Sinif15, ISNULL(tbStokAciklama.sAciklama1 + ' ' + tbStokAciklama.sAciklama2 + ' ' + tbStokAciklama.sAciklama3 + ' ' + tbStokAciklama.sAciklama4 + ' ' + tbStokAciklama.sAciklama5 + ' ' + tbStokAciklama.sAciklama6 + ' ' + tbStokAciklama.sAciklama7 + ' ' + tbStokAciklama.sAciklama8 + ' ' + tbStokAciklama.sAciklama9 + ' ' + tbStokAciklama.sAciklama10, '') AS ISTIHBARAT,(SELECT isnull(SUM(tbStokFisiDetayi.lGirisMiktar1 - tbStokFisiDetayi.lCikisMiktar1) , 0) FROM tbStokFisiDetayi WHERE tbStok.nStokID = tbStokFisiDetayi.nStokID) AS Mevcut,ISNULL((SELECT isnull(lfiyat , 0) FROM tbstokfiyati WHERE nStokId = tbStok.NstokId AND sFiyatTipi = '" & sFiyat1 & "'),0) AS FIYAT1, ISNULL((SELECT isnull(lfiyat , 0) FROM tbstokfiyati WHERE nStokId = tbStok.NstokId AND sFiyatTipi = '" & sFiyat2 & "'),0) AS FIYAT2,ISNULL((SELECT isnull(lfiyat , 0) FROM tbstokfiyati WHERE nStokId = tbStok.NstokId AND sFiyatTipi = '" & sFiyat3 & "'),0) AS FIYAT3,ISNULL((SELECT isnull(lfiyat , 0) FROM tbstokfiyati WHERE nStokId = tbStok.NstokId AND sFiyatTipi = '" & sFiyatM & "'),0) AS FIYATM,ISNULL((SELECT isnull(lfiyat , 0) FROM tbstokfiyati WHERE nStokId = tbStok.NstokId AND sFiyatTipi = '" & sFiyatA & "'),0) AS FIYATA,ISNULL((SELECT isnull(lfiyat , 0) FROM tbstokfiyati WHERE nStokId = tbStok.NstokId AND sFiyatTipi = '" & sFiyat4 & "'),0) AS FIYAT4,ISNULL((SELECT isnull(lfiyat , 0) FROM tbstokfiyati WHERE nStokId = tbStok.NstokId AND sFiyatTipi = '" & sFiyat5 & "'),0) AS FIYAT5,ISNULL((SELECT isnull(lfiyat , 0) FROM tbstokfiyati WHERE nStokId = tbStok.NstokId AND sFiyatTipi = '" & sFiyat6 & "'),0) AS FIYAT6,ISNULL((SELECT isnull(lfiyat , 0) FROM tbstokfiyati WHERE nStokId = tbStok.NstokId AND sFiyatTipi = '" & sFiyat7 & "'),0) AS FIYAT7,ISNULL((SELECT isnull(lfiyat , 0) FROM tbstokfiyati WHERE nStokId = tbStok.NstokId AND sFiyatTipi = '" & sFiyat8 & "'),0) AS FIYAT8,ISNULL((SELECT isnull(lfiyat , 0) FROM tbstokfiyati WHERE nStokId = tbStok.NstokId AND sFiyatTipi = '" & sFiyat9 & "'),0) AS FIYAT9,ISNULL((SELECT isnull(lfiyat , 0) FROM tbstokfiyati WHERE nStokId = tbStok.NstokId AND sFiyatTipi = '" & sFiyat10 & "'),0) AS FIYAT10,ISNULL((SELECT isnull(lfiyat , 0) FROM tbstokfiyati WHERE nStokId = tbStok.NstokId AND sFiyatTipi = '" & sAktifFiyatTipi & "'),0) AS lFiyat,(SELECT     nKdvOrani FROM         tbKdv Where sKdvTipi = tbStok.sKdvTipi) as nKdvOrani,ISNULL((SELECT ISNULL(lOran , 1) FROM tbStokBirimCevrimi WHERE nStokID = tbStok.nStokID AND sBirimCinsi = tbStok.sBirimCinsi2), 1) AS lBirimCarpan,CAST(0 as Money) as lMiktar  FROM tbStok INNER JOIN tbStokBarkodu ON tbStok.nStokID = tbStokBarkodu.nStokID and tbStokBarkodu.nKisim = 0 INNER JOIN tbStokSinifi ON tbStok.nStokID = tbStokSinifi.nStokID INNER JOIN tbSSinif1 ON tbStokSinifi.sSinifKodu1 = tbSSinif1.sSinifKodu INNER JOIN tbSSinif2 ON tbStokSinifi.sSinifKodu2 = tbSSinif2.sSinifKodu INNER JOIN tbSSinif3 ON tbStokSinifi.sSinifKodu3 = tbSSinif3.sSinifKodu INNER JOIN tbSSinif4 ON tbStokSinifi.sSinifKodu4 = tbSSinif4.sSinifKodu INNER JOIN tbSSinif5 ON tbStokSinifi.sSinifKodu5 = tbSSinif5.sSinifKodu INNER JOIN tbSSinif6 ON tbStokSinifi.sSinifKodu6 = tbSSinif6.sSinifKodu INNER JOIN tbSSinif7 ON tbStokSinifi.sSinifKodu7 = tbSSinif7.sSinifKodu INNER JOIN tbSSinif8 ON tbStokSinifi.sSinifKodu8 = tbSSinif8.sSinifKodu INNER JOIN tbSSinif9 ON tbStokSinifi.sSinifKodu9 = tbSSinif9.sSinifKodu INNER JOIN tbSSinif10 ON tbStokSinifi.sSinifKodu10 = tbSSinif10.sSinifKodu INNER JOIN tbSSinif11 ON tbStokSinifi.sSinifKodu11 = tbSSinif11.sSinifKodu INNER JOIN tbSSinif12 ON tbStokSinifi.sSinifKodu12 = tbSSinif12.sSinifKodu INNER JOIN tbSSinif13 ON tbStokSinifi.sSinifKodu13 = tbSSinif13.sSinifKodu INNER JOIN tbSSinif14 ON tbStokSinifi.sSinifKodu14 = tbSSinif14.sSinifKodu INNER JOIN tbSSinif15 ON tbStokSinifi.sSinifKodu15 = tbSSinif15.sSinifKodu LEFT OUTER JOIN tbStokAciklama ON tbStok.nStokID = tbStokAciklama.nStokID " & kriter & " ORDER BY tbStok.sKodu"))
                kayitsayisi = 1
            ElseIf nKodSayisi = 0 Then
                kriter = "Where (sAciklama " & sorgu_kriter_string(ara, ara_kriter) & ")"
                If sStokSinirla <> "" Then
                    kriter += " AND (sKodu like '" & sStokSinirla & "%') "
                End If
                nAciklamaSayisi = sorgula_nStokID("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT ISNULL(COUNT(nStokID),0) From tbStok " & kriter & "")
                If nAciklamaSayisi = 1 Then
                    kriter = "Where (tbStok.sAciklama " & sorgu_kriter_string(ara, ara_kriter) & ")"
                    If sStokSinirla <> "" Then
                        kriter += " AND (tbStok.sKodu like '" & sStokSinirla & "%') "
                    End If
                    ds_stok = sorgu(sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT tbStok.*, tbStokBarkodu.sBarkod, tbSSinif1.sAciklama AS Sinif1, tbSSinif2.sAciklama AS Sinif2, tbSSinif3.sAciklama AS Sinif3, tbSSinif4.sAciklama AS Sinif4, tbSSinif5.sAciklama AS Sinif5, tbSSinif6.sAciklama AS Sinif6, tbSSinif7.sAciklama AS Sinif7, tbSSinif8.sAciklama AS Sinif8, tbSSinif9.sAciklama AS Sinif9, tbSSinif10.sAciklama AS Sinif10, tbSSinif11.sAciklama AS Sinif11, tbSSinif12.sAciklama AS Sinif12, tbSSinif13.sAciklama AS Sinif13, tbSSinif14.sAciklama AS Sinif14, tbSSinif15.sAciklama AS Sinif15, ISNULL(tbStokAciklama.sAciklama1 + ' ' + tbStokAciklama.sAciklama2 + ' ' + tbStokAciklama.sAciklama3 + ' ' + tbStokAciklama.sAciklama4 + ' ' + tbStokAciklama.sAciklama5 + ' ' + tbStokAciklama.sAciklama6 + ' ' + tbStokAciklama.sAciklama7 + ' ' + tbStokAciklama.sAciklama8 + ' ' + tbStokAciklama.sAciklama9 + ' ' + tbStokAciklama.sAciklama10, '') AS ISTIHBARAT,(SELECT isnull(SUM(tbStokFisiDetayi.lGirisMiktar1 - tbStokFisiDetayi.lCikisMiktar1) , 0) FROM tbStokFisiDetayi WHERE tbStok.nStokID = tbStokFisiDetayi.nStokID) AS Mevcut,ISNULL((SELECT isnull(lfiyat , 0) FROM tbstokfiyati WHERE nStokId = tbStok.NstokId AND sFiyatTipi = '" & sFiyat1 & "'),0) AS FIYAT1, ISNULL((SELECT isnull(lfiyat , 0) FROM tbstokfiyati WHERE nStokId = tbStok.NstokId AND sFiyatTipi = '" & sFiyat2 & "'),0) AS FIYAT2,ISNULL((SELECT isnull(lfiyat , 0) FROM tbstokfiyati WHERE nStokId = tbStok.NstokId AND sFiyatTipi = '" & sFiyat3 & "'),0) AS FIYAT3,ISNULL((SELECT isnull(lfiyat , 0) FROM tbstokfiyati WHERE nStokId = tbStok.NstokId AND sFiyatTipi = '" & sFiyatM & "'),0) AS FIYATM,ISNULL((SELECT isnull(lfiyat , 0) FROM tbstokfiyati WHERE nStokId = tbStok.NstokId AND sFiyatTipi = '" & sFiyatA & "'),0) AS FIYATA,ISNULL((SELECT isnull(lfiyat , 0) FROM tbstokfiyati WHERE nStokId = tbStok.NstokId AND sFiyatTipi = '" & sFiyat4 & "'),0) AS FIYAT4,ISNULL((SELECT isnull(lfiyat , 0) FROM tbstokfiyati WHERE nStokId = tbStok.NstokId AND sFiyatTipi = '" & sFiyat5 & "'),0) AS FIYAT5,ISNULL((SELECT isnull(lfiyat , 0) FROM tbstokfiyati WHERE nStokId = tbStok.NstokId AND sFiyatTipi = '" & sFiyat6 & "'),0) AS FIYAT6,ISNULL((SELECT isnull(lfiyat , 0) FROM tbstokfiyati WHERE nStokId = tbStok.NstokId AND sFiyatTipi = '" & sFiyat7 & "'),0) AS FIYAT7,ISNULL((SELECT isnull(lfiyat , 0) FROM tbstokfiyati WHERE nStokId = tbStok.NstokId AND sFiyatTipi = '" & sFiyat8 & "'),0) AS FIYAT8,ISNULL((SELECT isnull(lfiyat , 0) FROM tbstokfiyati WHERE nStokId = tbStok.NstokId AND sFiyatTipi = '" & sFiyat9 & "'),0) AS FIYAT9,ISNULL((SELECT isnull(lfiyat , 0) FROM tbstokfiyati WHERE nStokId = tbStok.NstokId AND sFiyatTipi = '" & sFiyat10 & "'),0) AS FIYAT10,ISNULL((SELECT isnull(lfiyat , 0) FROM tbstokfiyati WHERE nStokId = tbStok.NstokId AND sFiyatTipi = '" & sAktifFiyatTipi & "'),0) AS lFiyat,(SELECT     nKdvOrani FROM         tbKdv Where sKdvTipi = tbStok.sKdvTipi) as nKdvOrani,ISNULL((SELECT ISNULL(lOran , 1) FROM tbStokBirimCevrimi WHERE nStokID = tbStok.nStokID AND sBirimCinsi = tbStok.sBirimCinsi2), 1) AS lBirimCarpan,CAST(0 as Money) as lMiktar  FROM tbStok INNER JOIN tbStokBarkodu ON tbStok.nStokID = tbStokBarkodu.nStokID and tbStokBarkodu.nKisim = 0 INNER JOIN tbStokSinifi ON tbStok.nStokID = tbStokSinifi.nStokID INNER JOIN tbSSinif1 ON tbStokSinifi.sSinifKodu1 = tbSSinif1.sSinifKodu INNER JOIN tbSSinif2 ON tbStokSinifi.sSinifKodu2 = tbSSinif2.sSinifKodu INNER JOIN tbSSinif3 ON tbStokSinifi.sSinifKodu3 = tbSSinif3.sSinifKodu INNER JOIN tbSSinif4 ON tbStokSinifi.sSinifKodu4 = tbSSinif4.sSinifKodu INNER JOIN tbSSinif5 ON tbStokSinifi.sSinifKodu5 = tbSSinif5.sSinifKodu INNER JOIN tbSSinif6 ON tbStokSinifi.sSinifKodu6 = tbSSinif6.sSinifKodu INNER JOIN tbSSinif7 ON tbStokSinifi.sSinifKodu7 = tbSSinif7.sSinifKodu INNER JOIN tbSSinif8 ON tbStokSinifi.sSinifKodu8 = tbSSinif8.sSinifKodu INNER JOIN tbSSinif9 ON tbStokSinifi.sSinifKodu9 = tbSSinif9.sSinifKodu INNER JOIN tbSSinif10 ON tbStokSinifi.sSinifKodu10 = tbSSinif10.sSinifKodu INNER JOIN tbSSinif11 ON tbStokSinifi.sSinifKodu11 = tbSSinif11.sSinifKodu INNER JOIN tbSSinif12 ON tbStokSinifi.sSinifKodu12 = tbSSinif12.sSinifKodu INNER JOIN tbSSinif13 ON tbStokSinifi.sSinifKodu13 = tbSSinif13.sSinifKodu INNER JOIN tbSSinif14 ON tbStokSinifi.sSinifKodu14 = tbSSinif14.sSinifKodu INNER JOIN tbSSinif15 ON tbStokSinifi.sSinifKodu15 = tbSSinif15.sSinifKodu LEFT OUTER JOIN tbStokAciklama ON tbStok.nStokID = tbStokAciklama.nStokID " & kriter & " ORDER BY tbStok.sKodu"))
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
    Private Sub dataload_stok(ByVal ara As String, ByVal ara_kriter As String)
        Dim kriter
        'kriter = "WHERE (tbStok.sKodu like  '" & kod & "%') or (tbStok.sAciklama like  '" & kod & "%') or (tbStokBarkodu.sBarkod like '" & kod & "%') "
        kriter = "WHERE (tbStok.sKodu " & sorgu_kriter_string(ara, ara_kriter) & ") or (tbStok.sAciklama " & sorgu_kriter_string(ara, ara_kriter) & ") or (tbStok.sKisaAdi " & sorgu_kriter_string(ara, ara_kriter) & ") OR tbStok.nStokID IN (Select nStokID from tbStokBarkodu where sBarkod " & sorgu_kriter_string(ara, ara_kriter) & ") "
        'ds_stok = sorgu(sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT     Stok.nStokID AS StokNo, Stok.sKodu AS StokKodu, Stok.sAciklama AS Malincinsi, Barcode.sBarkod AS Barcode FROM         tbStok Stok INNER JOIN                       tbStokBarkodu Barcode ON Stok.nStokID = Barcode.nStokID " & kriter & ""))
        'ds_stok = sorgu(sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT * FROM (SELECT stok.nStokID, stok.sKodu, stok.sAciklama, stok.sBeden, stok.sModel, barkod.sBarkod, (SELECT isnull(SUM(tbStokFisiDetayi.lGirisMiktar1 - tbStokFisiDetayi.lCikisMiktar1) , 0) FROM tbStokFisiDetayi WHERE Stok.nStokID = tbStokFisiDetayi.nStokID) AS Mevcut, (SELECT isnull(lfiyat , 0) FROM tbstokfiyati WHERE nStokId = stok.NstokId AND sFiyatTipi = '"& sFiyat1 &"') AS PESIN, (SELECT isnull(lfiyat , 0) FROM tbstokfiyati WHERE nStokId = stok.NstokId AND sFiyatTipi = '"& sFiyat3 &"') AS ONAY, (SELECT isnull(lfiyat , 0) FROM tbstokfiyati WHERE nStokId = stok.NstokId AND sFiyatTipi = '"& sFiyat2 &"') AS ALTIAY, tbRenk.sRenkAdi, stok.sRenk FROM tbStok stok INNER JOIN tbStokBarkodu barkod ON stok.nStokID = barkod.nStokID INNER JOIN tbRenk ON stok.sRenk = tbRenk.sRenk " & kriter & ") AS T  ORDER BY sKodu"))
        ds_stok = sorgu(sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT tbStok.*, tbStokBarkodu.sBarkod, tbSSinif1.sAciklama AS Sinif1, tbSSinif2.sAciklama AS Sinif2, tbSSinif3.sAciklama AS Sinif3, tbSSinif4.sAciklama AS Sinif4, tbSSinif5.sAciklama AS Sinif5, tbSSinif6.sAciklama AS Sinif6, tbSSinif7.sAciklama AS Sinif7, tbSSinif8.sAciklama AS Sinif8, tbSSinif9.sAciklama AS Sinif9, tbSSinif10.sAciklama AS Sinif10, tbSSinif11.sAciklama AS Sinif11, tbSSinif12.sAciklama AS Sinif12, tbSSinif13.sAciklama AS Sinif13, tbSSinif14.sAciklama AS Sinif14, tbSSinif15.sAciklama AS Sinif15, ISNULL(tbStokAciklama.sAciklama1 + ' ' + tbStokAciklama.sAciklama2 + ' ' + tbStokAciklama.sAciklama3 + ' ' + tbStokAciklama.sAciklama4 + ' ' + tbStokAciklama.sAciklama5 + ' ' + tbStokAciklama.sAciklama6 + ' ' + tbStokAciklama.sAciklama7 + ' ' + tbStokAciklama.sAciklama8 + ' ' + tbStokAciklama.sAciklama9 + ' ' + tbStokAciklama.sAciklama10, '') AS ISTIHBARAT,(SELECT isnull(SUM(tbStokFisiDetayi.lGirisMiktar1 - tbStokFisiDetayi.lCikisMiktar1) , 0) FROM tbStokFisiDetayi WHERE tbStok.nStokID = tbStokFisiDetayi.nStokID) AS Mevcut,ISNULL((SELECT isnull(lfiyat , 0) FROM tbstokfiyati WHERE nStokId = tbStok.NstokId AND sFiyatTipi = '" & sFiyat1 & "'),0) AS FIYAT1, ISNULL((SELECT isnull(lfiyat , 0) FROM tbstokfiyati WHERE nStokId = tbStok.NstokId AND sFiyatTipi = '" & sFiyat2 & "'),0) AS FIYAT2,ISNULL((SELECT isnull(lfiyat , 0) FROM tbstokfiyati WHERE nStokId = tbStok.NstokId AND sFiyatTipi = '" & sFiyat3 & "'),0) AS FIYAT3,ISNULL((SELECT isnull(lfiyat , 0) FROM tbstokfiyati WHERE nStokId = tbStok.NstokId AND sFiyatTipi = '" & sFiyatM & "'),0) AS FIYATM,ISNULL((SELECT isnull(lfiyat , 0) FROM tbstokfiyati WHERE nStokId = tbStok.NstokId AND sFiyatTipi = '" & sFiyatA & "'),0) AS FIYATA,ISNULL((SELECT isnull(lfiyat , 0) FROM tbstokfiyati WHERE nStokId = tbStok.NstokId AND sFiyatTipi = '" & sFiyat4 & "'),0) AS FIYAT4,ISNULL((SELECT isnull(lfiyat , 0) FROM tbstokfiyati WHERE nStokId = tbStok.NstokId AND sFiyatTipi = '" & sFiyat5 & "'),0) AS FIYAT5,ISNULL((SELECT isnull(lfiyat , 0) FROM tbstokfiyati WHERE nStokId = tbStok.NstokId AND sFiyatTipi = '" & sFiyat6 & "'),0) AS FIYAT6,ISNULL((SELECT isnull(lfiyat , 0) FROM tbstokfiyati WHERE nStokId = tbStok.NstokId AND sFiyatTipi = '" & sAktifFiyatTipi & "'),0) AS lFiyat,(SELECT     nKdvOrani FROM         tbKdv Where sKdvTipi = tbStok.sKdvTipi) as nKdvOrani,ISNULL((SELECT ISNULL(lOran , 1) FROM tbStokBirimCevrimi WHERE nStokID = tbStok.nStokID AND sBirimCinsi = tbStok.sBirimCinsi2), 1) AS lBirimCarpan,CAST(0 as Money) as lMiktar  FROM tbStok INNER JOIN tbStokBarkodu ON tbStok.nStokID = tbStokBarkodu.nStokID and tbStokBarkodu.nKisim = 0 INNER JOIN tbStokSinifi ON tbStok.nStokID = tbStokSinifi.nStokID INNER JOIN tbSSinif1 ON tbStokSinifi.sSinifKodu1 = tbSSinif1.sSinifKodu INNER JOIN tbSSinif2 ON tbStokSinifi.sSinifKodu2 = tbSSinif2.sSinifKodu INNER JOIN tbSSinif3 ON tbStokSinifi.sSinifKodu3 = tbSSinif3.sSinifKodu INNER JOIN tbSSinif4 ON tbStokSinifi.sSinifKodu4 = tbSSinif4.sSinifKodu INNER JOIN tbSSinif5 ON tbStokSinifi.sSinifKodu5 = tbSSinif5.sSinifKodu INNER JOIN tbSSinif6 ON tbStokSinifi.sSinifKodu6 = tbSSinif6.sSinifKodu INNER JOIN tbSSinif7 ON tbStokSinifi.sSinifKodu7 = tbSSinif7.sSinifKodu INNER JOIN tbSSinif8 ON tbStokSinifi.sSinifKodu8 = tbSSinif8.sSinifKodu INNER JOIN tbSSinif9 ON tbStokSinifi.sSinifKodu9 = tbSSinif9.sSinifKodu INNER JOIN tbSSinif10 ON tbStokSinifi.sSinifKodu10 = tbSSinif10.sSinifKodu INNER JOIN tbSSinif11 ON tbStokSinifi.sSinifKodu11 = tbSSinif11.sSinifKodu INNER JOIN tbSSinif12 ON tbStokSinifi.sSinifKodu12 = tbSSinif12.sSinifKodu INNER JOIN tbSSinif13 ON tbStokSinifi.sSinifKodu13 = tbSSinif13.sSinifKodu INNER JOIN tbSSinif14 ON tbStokSinifi.sSinifKodu14 = tbSSinif14.sSinifKodu INNER JOIN tbSSinif15 ON tbStokSinifi.sSinifKodu15 = tbSSinif15.sSinifKodu LEFT OUTER JOIN tbStokAciklama ON tbStok.nStokID = tbStokAciklama.nStokID " & kriter & " ORDER BY tbStok.sKodu"))
    End Sub
    Private Sub dataload_tbStokFiyat(ByVal nStokID As String)
        Dim kriter
        kriter = "WHERE (tbStok.nStokID ='" & nStokID & "') "
        ds_stok = sorgu(sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT nStokID,sKodu,sAciklama,ISNULL((SELECT isnull(lfiyat , 0) FROM tbstokfiyati WHERE nStokId = tbStok.NstokId AND sFiyatTipi = '" & sFiyat1 & "'),0) AS FIYAT1, ISNULL((SELECT isnull(lfiyat , 0) FROM tbstokfiyati WHERE nStokId = tbStok.NstokId AND sFiyatTipi = '" & sFiyat2 & "'),0) AS FIYAT2,ISNULL((SELECT isnull(lfiyat , 0) FROM tbstokfiyati WHERE nStokId = tbStok.NstokId AND sFiyatTipi = '" & sFiyat3 & "'),0) AS FIYAT3,ISNULL((SELECT isnull(lfiyat , 0) FROM tbstokfiyati WHERE nStokId = tbStok.NstokId AND sFiyatTipi = '" & sFiyatM & "'),0) AS FIYAT4,ISNULL((SELECT isnull(lfiyat , 0) FROM tbstokfiyati WHERE nStokId = tbStok.NstokId AND sFiyatTipi = '" & sFiyatA & "'),0) AS FIYATA,ISNULL((SELECT isnull(lfiyat , 0) FROM tbstokfiyati WHERE nStokId = tbStok.NstokId AND sFiyatTipi = '" & sFiyat4 & "'),0) AS FIYAT4 FROM tbStok " & kriter & " "))
    End Sub
    Private Sub dataload_tbFiyatTipi()
        ds_tbFiyatTipi = sorgu(sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT     sFiyatTipi, sAciklama FROM         tbFiyatTipi where (aktif = 1) and (aktifDepo like '%" & Trim(sDepo) & "%')"))
        sec_sFiyatTipi.Properties.DataSource = ds_tbFiyatTipi.Tables(0)
        sec_sFiyatTipi.EditValue = sAktifFiyatTipi
    End Sub
    Private Sub satir_ekle_stok_tek(ByVal yeni As Boolean)
        Dim dr As DataRow
        Dim dr1 As DataRow
        dr1 = ds_stok.Tables(0).Rows(0)
        dr = DataSet1.Tables(0).NewRow
        dr("nStokID") = dr1("nStokId")
        dr("sKodu") = dr1("sKodu")
        dr("sAciklama") = dr1("sAciklama")
        dr("sKisaAdi") = dr1("sKisaAdi")
        dr("nStokTipi") = dr1("nStokTipi")
        dr("sBedenTipi") = dr1("sBedenTipi")
        dr("sBeden") = dr1("sBeden")
        dr("sKavalaTipi") = dr1("sKavalaTipi")
        dr("sBarkod") = dr1("sBarkod")
        dr("sModel") = dr1("sModel")
        dr("sRenk") = dr1("sRenk")
        dr("sKavala") = dr1("sKavala")
        dr("sBirimCinsi1") = dr1("sBirimCinsi1")
        dr("sBirimCinsi2") = dr1("sBirimCinsi2")
        dr("nIskontoYuzdesi") = dr1("nIskontoYuzdesi")
        dr("sKdvTipi") = dr1("sKdvTipi")
        dr("nTeminSuresi") = dr1("nTeminSuresi")
        dr("lAsgariMiktar") = dr1("lAsgariMiktar")
        dr("lAzamiMiktar") = dr1("lAzamiMiktar")
        dr("sOzelNot") = dr1("sOzelNot")
        dr("nFiyatlandirma") = dr1("nFiyatlandirma")
        dr("sKullaniciAdi") = dr1("sKullaniciAdi")
        dr("dteKayitTarihi") = dr1("dteKayitTarihi")
        dr("bEksiyeDusulebilirmi") = dr1("bEksiyeDusulebilirmi")
        dr("sDefaultAsortiTipi") = dr1("sDefaultAsortiTipi")
        dr("bEksideUyarsinmi") = dr1("bEksideUyarsinmi")
        dr("bOTVVar") = dr1("bOTVVar")
        dr("sOTVTipi") = dr1("sOTVTipi")
        dr("nIskontoYuzdesiAV") = dr1("nIskontoYuzdesiAV")
        dr("bEk1") = dr1("bEk1")
        dr("nEk2") = dr1("nEk2")
        dr("Sinif1") = dr1("Sinif1")
        dr("Sinif2") = dr1("Sinif2")
        dr("Sinif3") = dr1("Sinif3")
        dr("Sinif4") = dr1("Sinif4")
        dr("Sinif5") = dr1("Sinif5")
        dr("Sinif6") = dr1("Sinif6")
        dr("Sinif7") = dr1("Sinif7")
        dr("Sinif8") = dr1("Sinif8")
        dr("Sinif9") = dr1("Sinif9")
        dr("Sinif10") = dr1("Sinif10")
        dr("Sinif11") = dr1("Sinif11")
        dr("Sinif12") = dr1("Sinif12")
        dr("Sinif13") = dr1("Sinif13")
        dr("Sinif14") = dr1("Sinif14")
        dr("Sinif15") = dr1("Sinif15")
        dr("ISTIHBARAT") = dr1("ISTIHBARAT")
        dr("Mevcut") = dr1("Mevcut")
        dr("FIYAT1") = dr1("FIYAT1")
        dr("FIYAT2") = dr1("FIYAT2")
        dr("FIYAT3") = dr1("FIYAT3")
        dr("FIYAT4") = dr1("FIYAT4")
        dr("WEBP") = dr1("WEBP")
        dr("WEBK") = dr1("WEBK")
        dr("TysalePrice") = dr1("TysalePrice")
        dr("N11salePrice") = dr1("N11salePrice")
        dr("GgsalePrice") = dr1("GgsalePrice")
        dr("HbsalePrice") = dr1("HbsalePrice")
        dr("CssalePrice") = dr1("CssalePrice")
        dr("AmzsalePrice") = dr1("AmzsalePrice")
        dr("EpttsalePrice") = dr1("EpttsalePrice")
        dr("NewsalePrice") = dr1("NewsalePrice")
        dr("FIYATA") = dr1("FIYATA")
        dr("FIYATM") = dr1("FIYATM")
        dr("lFiyat") = dr1("lFiyat")
        dr("Resim1") = dr1("Resim1")
        dr("Resim2") = dr1("Resim2")
        dr("Resim3") = dr1("Resim3")
        dr("Resim4") = dr1("Resim4")
        dr("Resim5") = dr1("Resim5")
        dr("Resim6") = dr1("Resim6")
        dr("Resim7") = dr1("Resim7")
        dr("Resim8") = dr1("Resim8")
        dr("Resim9") = dr1("Resim9")
        dr("Resim10") = dr1("Resim10")
        dr("Resim11") = dr1("Resim11")
        dr("Resim11") = dr1("Resim11")
        dr("bWebGoruntule") = dr1("bWebGoruntule")
        dr("bWebTavsiye") = dr1("bWebTavsiye")
        dr("sUzunNot") = dr1("sUzunNot")
        dr("sRenkAdi") = dr1("sRenkAdi")

        If dr("lFiyat") = 0 Then
        Else
            dr("FIYAT1") = dr1("lFiyat")
        End If
        dr("lBirimCarpan") = dr1("lBirimCarpan")
        dr("nKdvOrani") = dr1("nKdvOrani")
        'dr("Mevcut") = 1
        dr("lMiktar") = 1
        Try
            If dr("FIYAT1") <> 0 Then
                dr("nOran") = ((dr("FIYAT1") - dr("FIYATM")) / dr("FIYATM")) * 100
            Else
                dr("nOran") = 0
            End If
        Catch ex As Exception
        End Try
        DataSet1.Tables(0).Rows.Add(dr)
        Label4.Text = "Stok Satýra Ýþlendi...Yeni Ürün Okutun..."
        Label4.Refresh()
        Me.Refresh()
        dr = Nothing
        dr1 = Nothing
        If GridView1.RowCount > 0 Then
            GridView1.ClearSelection()
            GridView1.SelectRow(GridView1.RowCount - 1)
            PanelControl3.Focus()
            GridControl1.Focus()
        End If
        txt_ara.Text = ""
        txt_ara.Focus()
        txt_ara.SelectAll()
    End Sub
    Private Sub satir_ekle_stok(ByVal ara As String, Optional ByVal sKonum As String = "")
        Dim frm As New frm_stok_liste_fiyat
        frm.islemstatus = True
        frm.eticaret = True
        frm.connection = connection
        frm.firmano = firmano
        frm.donemno = donemno
        frm.islemstatus = True
        frm.kullanici = kullanici
        If Trim(ara) <> "" Then
            frm.txt_ara.Text = ara
            frm.sec_konum.Text = sKonum
            frm.sec_kriter.Text = sec_kriter.Text
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
                    dr = DataSet1.Tables(0).NewRow
                    dr1 = frm.GridView1.GetDataRow(s)
                    dr = DataSet1.Tables(0).NewRow
                    dr("nStokID") = dr1("nStokId")
                    dr("sKodu") = dr1("sKodu")
                    dr("sAciklama") = dr1("sAciklama")
                    dr("sBeden") = dr1("sBeden")
                    dr("sBarkod") = dr1("sBarkod")
                    dr("sModel") = dr1("sModel")
                    dr("sRenk") = dr1("sRenk")
                    dr("sKavala") = dr1("sKavala")
                    dr("sKdvTipi") = dr1("sKdvTipi")
                    'dr("nTeminSuresi") = dr1("nTeminSuresi")
                    'dr("lAsgariMiktar") = dr1("lAsgariMiktar")
                    'dr("lAzamiMiktar") = dr1("lAzamiMiktar")
                    dr("sOzelNot") = dr1("sOzelNot")
                    'dr("nFiyatlandirma") = dr1("nFiyatlandirma")
                    'dr("sKullaniciAdi") = dr1("sKullaniciAdi")
                    'dr("dteKayitTarihi") = dr1("dteKayitTarihi")
                    'dr("bEksiyeDusulebilirmi") = dr1("bEksiyeDusulebilirmi")
                    'dr("sDefaultAsortiTipi") = dr1("sDefaultAsortiTipi")
                    'dr("bEksideUyarsinmi") = dr1("bEksideUyarsinmi")
                    'dr("bOTVVar") = dr1("bOTVVar")
                    'dr("sOTVTipi") = dr1("sOTVTipi")
                    'dr("nIskontoYuzdesiAV") = dr1("nIskontoYuzdesiAV")
                    'dr("bEk1") = dr1("bEk1")
                    'dr("nEk2") = dr1("nEk2")
                    dr("Sinif1") = dr1("Sinif1")
                    dr("Sinif2") = dr1("Sinif2")
                    dr("Sinif3") = dr1("Sinif3")
                    dr("Sinif4") = dr1("Sinif4")
                    dr("Sinif5") = dr1("Sinif5")
                    dr("Sinif6") = dr1("Sinif6")
                    dr("Sinif7") = dr1("Sinif7")
                    dr("Sinif8") = dr1("Sinif8")
                    dr("Sinif9") = dr1("Sinif9")
                    dr("Sinif10") = dr1("Sinif10")
                    dr("Sinif11") = dr1("Sinif11")
                    dr("Sinif12") = dr1("Sinif12")
                    dr("Sinif13") = dr1("Sinif13")
                    dr("Sinif14") = dr1("Sinif14")
                    dr("Sinif15") = dr1("Sinif15")
                    'dr("ISTIHBARAT") = dr1("ISTIHBARAT")
                    dr("Mevcut") = dr1("Mevcut")
                    dr("FIYAT1") = dr1("FIYAT1")
                    dr("FIYAT2") = dr1("FIYAT2")
                    dr("FIYAT3") = dr1("FIYAT3")
                    'dr("FIYAT4") = dr1("FIYAT4")
                    dr("WEBP") = dr1("WEBP")
                    dr("WEBK") = dr1("WEBK")
                    dr("TysalePrice") = dr1("TysalePrice")
                    dr("N11salePrice") = dr1("N11salePrice")
                    dr("GgsalePrice") = dr1("GgsalePrice")
                    dr("HbsalePrice") = dr1("HbsalePrice")
                    dr("CssalePrice") = dr1("CssalePrice")
                    dr("AmzsalePrice") = dr1("AmzsalePrice")
                    dr("EpttsalePrice") = dr1("EpttsalePrice")
                    dr("NewsalePrice") = dr1("NewsalePrice")
                    dr("FIYATA") = dr1("FIYATA")
                    dr("FIYATM") = dr1("FIYATM")
                    dr("lFiyat") = dr1("lFiyat")
                    dr("Resim1") = dr1("Resim1")
                    dr("Resim2") = dr1("Resim2")
                    dr("Resim3") = dr1("Resim3")
                    dr("Resim4") = dr1("Resim4")
                    dr("Resim5") = dr1("Resim5")
                    dr("Resim6") = dr1("Resim6")
                    dr("Resim7") = dr1("Resim7")
                    dr("Resim8") = dr1("Resim8")
                    dr("Resim9") = dr1("Resim9")
                    dr("Resim10") = dr1("Resim10")
                    dr("Resim11") = dr1("Resim11")
                    dr("Resim11") = dr1("Resim11")
                    'dr("bWebGoruntule") = dr1("bWebGoruntule")
                    'dr("bWebTavsiye") = dr1("bWebTavsiye")
                    dr("sUzunNot") = dr1("sUzunNot")
                    dr("sRenkAdi") = dr1("sRenkAdi")
                    If dr("lFiyat") = 0 Then
                    Else
                        dr("FIYAT1") = dr1("lFiyat")
                    End If
                    dr("lBirimCarpan") = dr1("lBirimCarpan")
                    dr("nKdvOrani") = dr1("nKdvOrani")
                    dr("sRenkAdi") = dr1("sRenkAdi")
                    'dr("Mevcut") = 1
                    dr("lMiktar") = 1
                    Try
                        If dr("FIYAT1") <> 0 Then
                            dr("nOran") = ((dr("FIYAT1") - dr("FIYATM")) / dr("FIYATM")) * 100
                        Else
                            dr("nOran") = 0
                        End If
                    Catch ex As Exception
                    End Try
                    DataSet1.Tables(0).Rows.Add(dr)
                    Label4.Text = "Stok Satýra Ýþlendi...Yeni Ürün Okutun..."
                    Label4.Refresh()
                    Me.Refresh()
                Next
                frm.Close()
                frm.Dispose()
                frm = Nothing
                Me.Select()
                'If yeni = True Then
                '    satir_ekle_stok(False)
                'End If
                dr = Nothing
                dr1 = Nothing
                s = Nothing
                arr = Nothing
                i = Nothing
                If GridView1.RowCount > 0 Then
                    GridView1.ClearSelection()
                    GridView1.SelectRow(GridView1.RowCount - 1)
                    PanelControl3.Focus()
                    GridControl1.Focus()
                End If
            End If
        Else
        End If
        txt_ara.Text = ""
        txt_ara.Focus()
        txt_ara.SelectAll()
    End Sub
    Private Sub satir_sil()
        If GridView1.RowCount > 0 Then
            If XtraMessageBox.Show(Sorgu_sDil("Seçili Satýrlarý Silmek Ýstediðinize Emin misiniz...?", sDil), Sorgu_sDil("Dikkat", sDil), MessageBoxButtons.YesNo, MessageBoxIcon.Question) = MsgBoxResult.Yes Then
                GridView1.DeleteSelectedRows()
                Try
                    DataSet1.AcceptChanges()
                Catch ex As Exception
                End Try
                GridControl1.Focus()
                GridControl1.Select()
                If GridView1.RowCount > 0 Then
                    GridView1.SelectRow(GridView1.FocusedRowHandle)
                End If
            End If
        End If
    End Sub
    Private Sub satir_temizle()
        If XtraMessageBox.Show(Sorgu_sDil("Satýrlarýn Tümünü Silmek istediðinize Emin misiniz..?", sDil), Sorgu_sDil("Dikkat", sDil), MessageBoxButtons.YesNo, MessageBoxIcon.Question) = MsgBoxResult.Yes Then
            DataSet1.Clear()
            DataSet1.Dispose()
        Else
        End If
    End Sub
    Private Sub tbStokMetraj()
        Dim frm As New frm_tbStokMetraj
        frm.sconnection = connection
        frm.nfirmano = firmano
        frm.ndonemno = donemno
        frm.sKullanici = kullanici
        frm.ShowDialog()
    End Sub
    Private Sub etiket_yazdir()
        Dim frm As New frm_tbPrinter
        If frm.ShowDialog() = Windows.Forms.DialogResult.OK Then
            Dim dr1 As DataRow = frm.GridView1.GetDataRow(frm.GridView1.FocusedRowHandle)
            Dim miktar = frm.sec_miktar.EditValue
            Dim port = dr1("PORT")
            Dim logo = dr1("ACIKLAMA")
            AppYazarKasa.connection = connection
            AppYazarKasa.firmano = firmano
            AppYazarKasa.donemno = donemno
            posdll.dataset1 = DataSet1
            If dr1("PRINTER") = "ZEBRA" Then
                If dr1("DESIGN") = "Ürün Etiketi" Then
                    posdll.zebra_urunetiket_secili(miktar, port, dr1("ACIKLAMA"))
                ElseIf dr1("DESIGN") = "Ürün Etiketi-Fiyatlý" Then
                    posdll.zebra_urunetiket_secili(miktar, port, dr1("ACIKLAMA"))
                ElseIf dr1("DESIGN") = "Raf Etiketi" Then
                    posdll.zebra_rafetiket_secili(miktar, port, dr1("ACIKLAMA"))
                ElseIf dr1("DESIGN") = "10X10" Then
                    posdll.zebra_10X10_secili(miktar, port, dr1("ACIKLAMA"))
                End If
            Else
                If dr1("DESIGN") = "Ürün Etiketi" Then
                    posdll.urunetiket_secili(miktar, port, dr1("ACIKLAMA"))
                ElseIf dr1("DESIGN") = "Ürün Etiketi-Fiyatlý" Then
                    posdll.urunetiket_fiyatli_secili(miktar, port, dr1("ACIKLAMA"))
                ElseIf dr1("DESIGN") = "Raf Etiketi" Then
                    posdll.rafetiket_secili(miktar, port, dr1("ACIKLAMA"))
                ElseIf dr1("DESIGN") = "10X10" Then
                    posdll.rafetiket_secili_10X10(miktar, port, dr1("ACIKLAMA"))
                ElseIf dr1("DESIGN") = "10X15" Then
                    posdll.rafetiket_secili_10X15(miktar, port, dr1("ACIKLAMA"))
                End If
            End If
            dr1 = Nothing
            miktar = Nothing
            port = Nothing
        End If
        frm = Nothing
    End Sub
    Private Sub Transfer()
        Dim frm As New frm_tbPos
        frm.firmano = firmano
        frm.donemno = donemno
        frm.connection = connection
        frm.islem = "Transfer"
        frm.sKasaIletisim = sKasaIletisim
        Dim objProcess As System.Diagnostics.Process
        objProcess = New System.Diagnostics.Process()
        objProcess.StartInfo.WindowStyle = ProcessWindowStyle.Hidden
        If frm.ShowDialog(Me) = Windows.Forms.DialogResult.OK Then
            Dim dr As DataRow = frm.GridView1.GetDataRow(frm.GridView1.FocusedRowHandle)
            If dr("sCihaz") = "Ishida" Or dr("sCihaz") = "Bizerba" Or dr("sCihaz") = "Epelsa" Or dr("sCihaz") = "Toledo" Then
                AppYazarKasa.firmano = firmano
                AppYazarKasa.donemno = donemno
                AppYazarKasa.connection = connection
                AppYazarKasa.nKayitSinir = nKayitSinir
                posdll.dataset1 = DataSet1
                Dim bToledo As Boolean = False
                If dr("sCihaz") = "Toledo" Then
                    bToledo = True
                Else
                    bToledo = False
                End If
                posdll.ISHIDA_tumu(dr("sPath"), dr("sFile"), dr("sFiyatTipi"), dr("sGramaj").ToString, frm.sec_islem.SelectedIndex, dr("nSinif"), dr("sSinif"), bToledo)
                If dr("sRun").ToString <> "" Then
                    If XtraMessageBox.Show(Sorgu_sDil("Teraziye Göndermek Ýstiyormusunuz..?", sDil), Sorgu_sDil("Dikkat", sDil), MessageBoxButtons.YesNo, MessageBoxIcon.Question) = MsgBoxResult.Yes Then
                        objProcess.StartInfo.FileName = Trim(dr("sRun").ToString)
                        objProcess.StartInfo.Arguments = ""
                        Try
                            objProcess.Start()
                            objProcess.WaitForExit()
                            objProcess.Close()
                        Catch ex As Exception
                            DevExpress.XtraEditors.XtraMessageBox.Show("Islem Baslatilamiyor " & objProcess.StartInfo.FileName.ToString)
                            'MessageBox.Show(ex.ToString)
                        End Try
                    End If
                End If
            ElseIf dr("sCihaz") = "SharpErA495" Then
                If sKasaIletisim = "Ofline" Or sKasaIletisim = "Ofline+Online" Then
                    Dim sPort As String = "1"
                    AppYazarKasa.firmano = firmano
                    AppYazarKasa.donemno = donemno
                    AppYazarKasa.connection = connection
                    AppYazarKasa.nKayitSinir = nKayitSinir
                    posdll.dataset1 = DataSet1
                    'posdll.ISHIDA_tumu(dr("sPath").ToString & ":" & dr("sFile"), dr("sFiyatTipi"))
                    If dr("sPort") = "COM1" Then
                        sPort = "1"
                    ElseIf sPort = "COM2" Then
                        sPort = "2"
                    Else
                        sPort = dr("sPort")
                    End If
                    If frm.sec_islem.SelectedIndex = 0 Then
                        posdll.SHARP_yeni("(31-10000, 01:14, 02:14, 04:08, 05:16)", "000001020000 ", "", dr("sPath").ToString & ":" & dr("sFile"), dr("sFiyatTipi"), dr("sGramaj").ToString, dr("sAdetli").ToString)
                        objProcess.StartInfo.FileName = "C:\Persis\SharpCom.exe"
                        objProcess.StartInfo.Arguments = sPort & " 00000" & dr("lNo") & " 10 0 31 1 barkod.txt barkod.err"
                    ElseIf frm.sec_islem.SelectedIndex = 1 Then
                        posdll.SHARP_fiyat("(31-10000, 01:14, 04:08, 05:16)", "", "", dr("sPath").ToString & ":" & dr("sFile"), dr("sFiyatTipi"), dr("sGramaj").ToString, dr("sAdetli").ToString)
                        objProcess.StartInfo.FileName = "C:\persis\SharpCom.exe"
                        objProcess.StartInfo.Arguments = sPort & " 00000" & dr("lNo") & " 10 1 31 1 barkod.txt barkod.err"
                    ElseIf frm.sec_islem.SelectedIndex = 2 Then
                        posdll.SHARP_plu("(11-10000, 01:06, 02:16, 04:08, 05:16)", "00000102000000 ", "", dr("sPath").ToString & ":" & dr("sFile"), dr("sFiyatTipi"), dr("sGramaj").ToString, dr("sAdetli").ToString)
                        objProcess.StartInfo.FileName = "C:\persis\SharpCom.exe"
                        objProcess.StartInfo.Arguments = sPort & " 00000" & dr("lNo") & " 10 0 11 1 barkod.txt barkod.err"
                    End If
                    If posdll.sayi > 0 Then
                        Dim dlg As New WaitDlgFrm(posdll.sayi & " Urun icin Haberlesme Kuruluyor...")
                        Try
                            objProcess.Start()
                            objProcess.WaitForExit()
                            objProcess.Close()
                        Catch ex As Exception
                            DevExpress.XtraEditors.XtraMessageBox.Show("Islem Baslatilamiyor " & objProcess.StartInfo.FileName.ToString)
                            'MessageBox.Show(ex.ToString)
                        End Try
                        dlg.Close()
                    Else
                        XtraMessageBox.Show(Sorgu_sDil("Iletisim Kriterine Uygun Urun Bulunamadi", sDil), Sorgu_sDil("Dikkat", sDil), MessageBoxButtons.OK, MessageBoxIcon.Warning)
                    End If
                    'If frm.sec_islem.SelectedIndex = 0 Then
                    '    posdll.SHARP_plu("(11-10000, 01:06, 02:16, 04:08, 05:16)", "00000102000000 ", "", dr("sPath").ToString & ":" & dr("sFile"), dr("sFiyatTipi"), dr("sGramaj").ToString, dr("sAdetli").ToString)
                    '    objProcess.StartInfo.FileName = "C:\persis\SharpCom.exe"
                    '    objProcess.StartInfo.Arguments = sPort & " 00000" & dr("lNo") & " 10 0 11 1 barkod.txt barkod.err"
                    '    If posdll.sayi > 0 Then
                    '        Dim dlg As New WaitDlgFrm(posdll.sayi & " Urun icin Haberlesme Kuruluyor...")
                    '        Try
                    '            objProcess.Start()
                    '            objProcess.WaitForExit()
                    '            objProcess.Close()
                    '        Catch ex As Exception
                    '            DevExpress.XtraEditors.XtraMessageBox.Show("Islem Baslatilamiyor " & objProcess.StartInfo.FileName.ToString, sorgu_sDil("Dikkat",sDil))
                    '            'MessageBox.Show(ex.ToString)
                    '        End Try
                    '        dlg.Close()
                    '    Else
                    '        'MsgBox(Sorgu_sDil("Iletisim Kriterine Uygun Urun Bulunamadi",sDil), MessageBoxIcon.Warning, sorgu_sDil("Dikkat",sDil))
                    '    End If
                    'End If
                End If
            ElseIf dr("sCihaz") = "Hugin425TX" Then
                If sKasaIletisim = "Ofline" Or sKasaIletisim = "Ofline+Online" Then
                    Dim sPort As String = "1"
                    AppYazarKasa.firmano = firmano
                    AppYazarKasa.donemno = donemno
                    AppYazarKasa.connection = connection
                    AppYazarKasa.nKayitSinir = nKayitSinir
                    posdll.dataset1 = DataSet1
                    If dr("sPort") = "COM1" Then
                        sPort = "1"
                    ElseIf sPort = "COM2" Then
                        sPort = "2"
                    Else
                        sPort = dr("sPort")
                    End If
                    If frm.sec_islem.SelectedIndex = 0 Then
                        posdll.Hugin425TX_tumu(dr("sPath"), dr("sFile"), dr("sFiyatTipi"), dr("sGramaj"), sPort)
                    ElseIf frm.sec_islem.SelectedIndex = 1 Then
                        posdll.HUGIN425TX_secili(dr("sPath"), dr("sFile"), dr("sFiyatTipi"), dr("sGramaj"), sPort)
                    End If
                    If posdll.sayi > 0 Then
                        objProcess.StartInfo.FileName = "C:\HuginAlpha\Hugin.exe"
                        objProcess.StartInfo.Arguments = "" 'sPort & " 00000" & dr("lNo") & " 10 0 31 1 barkod.txt barkod.err"
                        Dim dlg As New WaitDlgFrm(posdll.sayi & " Urun icin Haberlesme Kuruluyor...")
                        Try
                            objProcess.Start()
                            objProcess.WaitForExit()
                            objProcess.Close()
                        Catch ex As Exception
                            DevExpress.XtraEditors.XtraMessageBox.Show("Islem Baslatilamiyor " & objProcess.StartInfo.FileName.ToString)
                            'MessageBox.Show(ex.ToString)
                        End Try
                        dlg.Close()
                    Else
                        XtraMessageBox.Show(Sorgu_sDil("Iletisim Kriterine Uygun Urun Bulunamadi", sDil), Sorgu_sDil("Dikkat", sDil), MessageBoxButtons.OK, MessageBoxIcon.Warning)
                    End If
                End If
            ElseIf dr("sCihaz") = "IbmEntry01-1" Then
                If sKasaIletisim = "Ofline" Or sKasaIletisim = "Ofline+Online" Then
                    Dim sPort As String = "1"
                    AppYazarKasa.firmano = firmano
                    AppYazarKasa.donemno = donemno
                    AppYazarKasa.connection = connection
                    AppYazarKasa.nKayitSinir = nKayitSinir
                    posdll.dataset1 = DataSet1
                    'posdll.ISHIDA_tumu(dr("sPath").ToString & ":" & dr("sFile"), dr("sFiyatTipi"))
                    If dr("sPort") = "COM1" Then
                        sPort = "1"
                    ElseIf sPort = "COM2" Then
                        sPort = "2"
                    Else
                        sPort = dr("sPort")
                    End If
                    If frm.sec_islem.SelectedIndex = 0 Then
                        posdll.Entry_tumu(dr("sPath"), dr("sFile"), dr("sFiyatTipi"), dr("sGramaj"))
                    ElseIf frm.sec_islem.SelectedIndex = 1 Then
                        posdll.Entry_secili_entry01(dr("sPath"), dr("sFile"), dr("sFiyatTipi"), dr("sGramaj"), sPort)
                    End If
                End If
            ElseIf dr("sCihaz") = "IbmEntry01-2" Then
                If sKasaIletisim = "Ofline" Or sKasaIletisim = "Ofline+Online" Then
                    Dim sPort As String = "1"
                    AppYazarKasa.firmano = firmano
                    AppYazarKasa.donemno = donemno
                    AppYazarKasa.connection = connection
                    AppYazarKasa.nKayitSinir = nKayitSinir
                    posdll.dataset1 = DataSet1
                    'posdll.ISHIDA_tumu(dr("sPath").ToString & ":" & dr("sFile"), dr("sFiyatTipi"))
                    If dr("sPort") = "COM1" Then
                        sPort = "1"
                    ElseIf sPort = "COM2" Then
                        sPort = "2"
                    Else
                        sPort = dr("sPort")
                    End If
                    If frm.sec_islem.SelectedIndex = 0 Then
                        posdll.Entry_tumu(dr("sPath"), dr("sFile"), dr("sFiyatTipi"), dr("sGramaj"))
                    ElseIf frm.sec_islem.SelectedIndex = 1 Then
                        posdll.Entry_secili_mdb(dr("sPath"), dr("sFile"), dr("sFiyatTipi"), dr("sGramaj"), sPort)
                    End If
                End If
            ElseIf dr("sCihaz") = "IbmEntry01-3" Then
                If sKasaIletisim = "Ofline" Or sKasaIletisim = "Ofline+Online" Then
                    Dim sPort As String = "1"
                    AppYazarKasa.firmano = firmano
                    AppYazarKasa.donemno = donemno
                    AppYazarKasa.connection = connection
                    AppYazarKasa.nKayitSinir = nKayitSinir
                    posdll.dataset1 = DataSet1
                    'posdll.ISHIDA_tumu(dr("sPath").ToString & ":" & dr("sFile"), dr("sFiyatTipi"))
                    If dr("sPort") = "COM1" Then
                        sPort = "1"
                    ElseIf sPort = "COM2" Then
                        sPort = "2"
                    Else
                        sPort = dr("sPort")
                    End If
                    If frm.sec_islem.SelectedIndex = 0 Then
                        posdll.Entry_tumu(dr("sPath"), dr("sFile"), dr("sFiyatTipi"), dr("sGramaj"))
                    ElseIf frm.sec_islem.SelectedIndex = 1 Then
                        posdll.Entry_secili_VEGA(dr("sPath"), dr("sFile"), dr("sFiyatTipi"), dr("sGramaj"), sPort)
                    End If
                End If
            ElseIf dr("sCihaz") = "SýemensPos-3" Then
                If sKasaIletisim = "Online" Or sKasaIletisim = "Ofline+Online" Then
                    Dim sPort As String = "1"
                    AppYazarKasa.firmano = firmano
                    AppYazarKasa.donemno = donemno
                    AppYazarKasa.connection = connection
                    AppYazarKasa.nKayitSinir = nKayitSinir
                    posdll.dataset1 = DataSet1
                    'posdll.ISHIDA_tumu(dr("sPath").ToString & ":" & dr("sFile"), dr("sFiyatTipi"))
                    If dr("sPort") = "COM1" Then
                        sPort = "1"
                    ElseIf sPort = "COM2" Then
                        sPort = "2"
                    Else
                        sPort = dr("sPort")
                    End If
                    If frm.sec_islem.SelectedIndex = 0 Then
                        posdll.Entry_tumu(dr("sPath"), dr("sFile"), dr("sFiyatTipi"), dr("sGramaj"))
                    ElseIf frm.sec_islem.SelectedIndex = 1 Then
                        posdll.Entry_secili_VEGA(dr("sPath"), dr("sFile"), dr("sFiyatTipi"), dr("sGramaj"), sPort)
                    End If
                End If
            ElseIf dr("sCihaz") = "CasLp15" Then
                AppYazarKasa.firmano = firmano
                AppYazarKasa.donemno = donemno
                AppYazarKasa.connection = connection
                AppYazarKasa.nKayitSinir = nKayitSinir
                posdll.dataset1 = DataSet1
                posdll.CASLP15R_tumu(dr("sPath"), dr("sFile"), dr("sFiyatTipi"), dr("sGramaj").ToString, frm.sec_islem.SelectedIndex, dr("nSinif"), dr("sSinif"))
                If dr("sRun").ToString <> "" Then
                    If XtraMessageBox.Show(Sorgu_sDil("Teraziye Göndermek Ýstiyormusunuz..?", sDil), Sorgu_sDil("Dikkat", sDil), MessageBoxButtons.YesNo, MessageBoxIcon.Question) = MsgBoxResult.Yes Then
                        objProcess.StartInfo.FileName = Trim(dr("sRun").ToString)
                        objProcess.StartInfo.Arguments = ""
                        Try
                            objProcess.Start()
                            'objProcess.WaitForExit()
                            'objProcess.Close()
                        Catch ex As Exception
                            DevExpress.XtraEditors.XtraMessageBox.Show("Islem Baslatilamiyor " & objProcess.StartInfo.FileName.ToString)
                            'MessageBox.Show(ex.ToString)
                        End Try
                    End If
                End If
            ElseIf dr("sCihaz") = "DigiSm80" Then
                AppYazarKasa.firmano = firmano
                AppYazarKasa.donemno = donemno
                AppYazarKasa.connection = connection
                AppYazarKasa.nKayitSinir = nKayitSinir
                posdll.dataset1 = DataSet1
                posdll.DIGISM80_tumu(dr("sPath"), dr("sFile"), dr("sFiyatTipi"), dr("sGramaj").ToString, frm.sec_islem.SelectedIndex, dr("nSinif"), dr("sSinif"))
                If dr("sRun").ToString <> "" Then
                    If XtraMessageBox.Show(Sorgu_sDil("Teraziye Göndermek Ýstiyormusunuz..?", sDil), Sorgu_sDil("Dikkat", sDil), MessageBoxButtons.YesNo, MessageBoxIcon.Question) = MsgBoxResult.Yes Then
                        objProcess.StartInfo.FileName = Trim(dr("sRun").ToString)
                        objProcess.StartInfo.Arguments = ""
                        Try
                            objProcess.Start()
                            'objProcess.WaitForExit()
                            'objProcess.Close()
                        Catch ex As Exception
                            DevExpress.XtraEditors.XtraMessageBox.Show("Islem Baslatilamiyor " & objProcess.StartInfo.FileName.ToString)
                            'MessageBox.Show(ex.ToString)
                        End Try
                    End If
                End If
            ElseIf dr("sCihaz") = "InterPos2001" Or dr("sCihaz") = "InterPos2000" Then
                If sKasaIletisim = "Online" Or sKasaIletisim = "Ofline+Online" Then
                    AppYazarKasa.firmano = firmano
                    AppYazarKasa.donemno = donemno
                    AppYazarKasa.connection = connection
                    AppYazarKasa.nKayitSinir = nKayitSinir
                    If frm.sec_islem.SelectedIndex = 0 Then
                        posdll.ds_Inter = ds_Inter
                        posdll.GridControl1 = GridControl2
                        posdll.GridView1 = GridView2
                        posdll.inter_tumu(dr("lNo"), dr("lSonNo"), dr("sPath"), dr("sFile"), dr("sFiyatTipi"), dr("sGramaj").ToString, Trim(dr("sDepo").ToString))
                    ElseIf frm.sec_islem.SelectedIndex = 1 Then
                        posdll.dataset1 = DataSet1
                        posdll.ds_Inter = ds_Inter
                        posdll.GridControl1 = GridControl2
                        posdll.GridView1 = GridView2
                        posdll.inter_secili(dr("lNo"), dr("lSonNo"), dr("sPath"), dr("sFile"), dr("sFiyatTipi"), dr("sGramaj").ToString, Trim(dr("sDepo").ToString))
                    ElseIf frm.sec_islem.SelectedIndex = 2 Then
                        posdll.ds_Inter = ds_Inter
                        posdll.GridControl1 = GridControl2
                        posdll.GridView1 = GridView2
                        posdll.inter_degisenler(dr("lNo"), dr("lSonNo"), dr("sPath"), dr("sFile"), dr("sFiyatTipi"), dr("sGramaj").ToString)
                    ElseIf frm.sec_islem.SelectedIndex = 3 Then
                        posdll.ds_Inter = ds_Inter
                        posdll.GridControl1 = GridControl2
                        posdll.GridView1 = GridView2
                        posdll.inter_cariler(dr("lNo"), dr("lSonNo"), dr("sPath"), dr("sFile"), dr("sFiyatTipi"))
                    ElseIf frm.sec_islem.SelectedIndex = 4 Then
                        posdll.ds_Inter = ds_Inter
                        posdll.GridControl1 = GridControl2
                        posdll.GridView1 = GridView2
                        posdll.inter_cariler2(dr("lNo"), dr("lSonNo"), dr("sPath"), dr("sFile"), dr("sFiyatTipi"))
                    ElseIf frm.sec_islem.SelectedIndex = 5 Then
                        Dim fm As New frm_tbPos_Inter_Promosyon
                        fm.firmano = firmano
                        fm.donemno = donemno
                        fm.connection = connection
                        fm.kullanici = kullanici
                        fm.sPath = dr("sPath")
                        fm.sFile = dr("sFile")
                        fm.nIlkKasa = dr("lNo")
                        fm.nSonKasa = dr("lSonNo")
                        fm.ShowDialog()
                    ElseIf frm.sec_islem.SelectedIndex = 6 Then
                        Dim fm As New frm_tbPos_Inter_Program
                        fm.firmano = firmano
                        fm.donemno = donemno
                        fm.connection = connection
                        fm.kullanici = kullanici
                        fm.sPath = dr("sPath")
                        fm.sFile = dr("sFile")
                        fm.nIlkKasa = dr("lNo")
                        fm.nSonKasa = dr("lSonNo")
                        fm.ShowDialog()
                    ElseIf frm.sec_islem.SelectedIndex = 7 Then
                        posdll.ds_Inter = ds_Inter
                        posdll.GridControl1 = GridControl2
                        posdll.GridView1 = GridView2
                        posdll.inter_tumu_uruntaksit(dr("lNo"), dr("lSonNo"), dr("sPath"), dr("sFile"), dr("sFiyatTipi"), dr("sGramaj").ToString)
                    ElseIf frm.sec_islem.SelectedIndex = 8 Then
                        posdll.ds_Inter = ds_Inter
                        posdll.GridControl1 = GridControl2
                        posdll.GridView1 = GridView2
                        posdll.inter_tumu_toptan(dr("lNo"), dr("lSonNo"), dr("sPath"), dr("sFile"), dr("sFiyatTipi"), dr("sGramaj").ToString, Trim(dr("sDepo").ToString))
                    End If
                End If
            ElseIf dr("sCihaz") = "EscortPos4000" Or dr("sCihaz") = "EscortPos3000" Or dr("sCihaz") = "HuginPos" Then
                If sKasaIletisim = "Online" Or sKasaIletisim = "Ofline+Online" Then
                    AppYazarKasa.firmano = firmano
                    AppYazarKasa.donemno = donemno
                    AppYazarKasa.connection = connection
                    AppYazarKasa.nKayitSinir = nKayitSinir
                    If frm.sec_islem.SelectedIndex = 0 Then
                        posdll.ds_Inter = ds_Inter
                        posdll.GridControl1 = GridControl2
                        posdll.GridView1 = GridView2
                        posdll.ESCORT_tumu(dr("lNo"), dr("lSonNo"), dr("sPath"), dr("sFile"), dr("sFiyatTipi"), dr("sGramaj").ToString)
                    ElseIf frm.sec_islem.SelectedIndex = 1 Then
                        posdll.ds_Inter = ds_Inter
                        posdll.GridControl1 = GridControl2
                        posdll.GridView1 = GridView2
                        posdll.dataset1 = DataSet1
                        posdll.ESCORT_secili(dr("lNo"), dr("lSonNo"), dr("sPath"), dr("sFile"), dr("sFiyatTipi"), dr("sGramaj").ToString)
                    ElseIf frm.sec_islem.SelectedIndex = 2 Then
                        posdll.ds_Inter = ds_Inter
                        posdll.GridControl1 = GridControl2
                        posdll.GridView1 = GridView2
                        posdll.ESCORT_degisenler(dr("lNo"), dr("lSonNo"), dr("sPath"), dr("sFile"), dr("sFiyatTipi"), dr("sGramaj").ToString)
                    ElseIf frm.sec_islem.SelectedIndex = 3 Then
                        posdll.ds_Inter = ds_Inter
                        posdll.GridControl1 = GridControl2
                        posdll.GridView1 = GridView2
                        posdll.ESCORT_cariler(dr("lNo"), dr("lSonNo"), dr("sPath"), dr("sFile"), dr("sFiyatTipi"))
                    End If
                End If
            ElseIf dr("sCihaz") = "IbmPos" Then
                If sKasaIletisim = "Online" Or sKasaIletisim = "Ofline+Online" Then
                    AppYazarKasa.firmano = firmano
                    AppYazarKasa.donemno = donemno
                    AppYazarKasa.connection = connection
                    AppYazarKasa.nKayitSinir = nKayitSinir
                    If frm.sec_islem.SelectedIndex = 0 Then
                        posdll.IBMgenius_tumu(dr("sPath"), dr("sFile"), dr("sFiyatTipi"), dr("sGramaj").ToString)
                    ElseIf frm.sec_islem.SelectedIndex = 1 Then
                        posdll.dataset1 = DataSet1
                        posdll.IBMgenius_Degisen(dr("sPath"), dr("sFile"), dr("sFiyatTipi"), dr("sGramaj").ToString)
                    ElseIf frm.sec_islem.SelectedIndex = 2 Then
                        posdll.dataset1 = DataSet1
                        posdll.IBMgenius_secili(dr("sPath"), dr("sFile"), dr("sFiyatTipi"), dr("sGramaj").ToString)
                    End If
                    If dr("sRun").ToString <> "" Then
                        If XtraMessageBox.Show(Sorgu_sDil("Pos Kasaya Göndermek Ýstiyormusunuz..?", sDil), Sorgu_sDil("Dikkat", sDil), MessageBoxButtons.YesNo, MessageBoxIcon.Question) = MsgBoxResult.Yes Then
                            'Genius noktalama ayarla
                            Registry.CurrentUser.CreateSubKey("Control Panel").CreateSubKey("International").SetValue("sDecimal", ",")
                            Registry.CurrentUser.CreateSubKey("Control Panel").CreateSubKey("International").SetValue("sThousand", ".")
                            Registry.CurrentUser.CreateSubKey("Control Panel").CreateSubKey("International").SetValue("sMonDecimalSep", ",")
                            Registry.CurrentUser.CreateSubKey("Control Panel").CreateSubKey("International").SetValue("sMonThousandSep", ".")
                            Registry.CurrentUser.CreateSubKey("Control Panel").CreateSubKey("International").SetValue("sDate", "/")
                            Registry.CurrentUser.CreateSubKey("Control Panel").CreateSubKey("International").SetValue("sShortDate", "dd/MM/yyyy")
                            objProcess.StartInfo.FileName = Trim(dr("sRun").ToString)
                            objProcess.StartInfo.Arguments = ""
                            Try
                                objProcess.Start()
                                'objProcess.WaitForExit()
                                'objProcess.Close()
                            Catch ex As Exception
                                DevExpress.XtraEditors.XtraMessageBox.Show("Islem Baslatilamiyor " & objProcess.StartInfo.FileName.ToString)
                                'MessageBox.Show(ex.ToString)
                            End Try
                        End If
                    End If
                End If
            ElseIf dr("sCihaz") = "NcrPos" Then
                If sKasaIletisim = "Online" Or sKasaIletisim = "Ofline+Online" Then
                    AppYazarKasa.firmano = firmano
                    AppYazarKasa.donemno = donemno
                    AppYazarKasa.connection = connection
                    AppYazarKasa.nKayitSinir = nKayitSinir
                    If frm.sec_islem.SelectedIndex = 0 Then
                        posdll.Ncr_TXT_tumu(dr("sPath"), dr("sFile"), dr("sFiyatTipi"), dr("sGramaj").ToString)
                    ElseIf frm.sec_islem.SelectedIndex = 1 Then
                        posdll.dataset1 = DataSet1
                        posdll.Ncr_TXT_secili(dr("sPath"), dr("sFile"), dr("sFiyatTipi"), dr("sGramaj").ToString)
                    End If
                    If dr("sRun").ToString <> "" Then
                        If XtraMessageBox.Show(Sorgu_sDil("Kasaya Göndermek Ýstiyormusunuz..?", sDil), Sorgu_sDil("Dikkat", sDil), MessageBoxButtons.YesNo, MessageBoxIcon.Question) = MsgBoxResult.Yes Then
                            objProcess.StartInfo.FileName = Trim(dr("sRun").ToString)
                            objProcess.StartInfo.Arguments = ""
                            Try
                                objProcess.Start()
                                'objProcess.WaitForExit()
                                'objProcess.Close()
                            Catch ex As Exception
                                DevExpress.XtraEditors.XtraMessageBox.Show("Islem Baslatilamiyor " & objProcess.StartInfo.FileName.ToString)
                                'MessageBox.Show(ex.ToString)
                            End Try
                        End If
                    End If
                End If
            ElseIf dr("sCihaz") = "SiemensPos-1" Then
                If sKasaIletisim = "Online" Or sKasaIletisim = "Ofline+Online" Then
                    AppYazarKasa.firmano = firmano
                    AppYazarKasa.donemno = donemno
                    AppYazarKasa.connection = connection
                    AppYazarKasa.nKayitSinir = nKayitSinir
                    If frm.sec_islem.SelectedIndex = 0 Then
                        posdll.SIEMENS_TXT_tumu(dr("sPath"), dr("sFile"), dr("sFiyatTipi"), dr("sGramaj").ToString)
                    ElseIf frm.sec_islem.SelectedIndex = 1 Then
                        posdll.dataset1 = DataSet1
                        posdll.SIEMENS_TXT_secili(dr("sPath"), dr("sFile"), dr("sFiyatTipi"), dr("sGramaj").ToString)
                    ElseIf frm.sec_islem.SelectedIndex = 2 Then
                        posdll.Siemens_TXT_musteriler(dr("sPath"), dr("sFile"), dr("sFiyatTipi"))
                    End If
                    If dr("sRun").ToString <> "" Then
                        If XtraMessageBox.Show(Sorgu_sDil("Kasaya Göndermek Ýstiyormusunuz..?", sDil), Sorgu_sDil("Dikkat", sDil), MessageBoxButtons.YesNo, MessageBoxIcon.Question) = MsgBoxResult.Yes Then
                            objProcess.StartInfo.FileName = Trim(dr("sRun").ToString)
                            objProcess.StartInfo.Arguments = ""
                            Try
                                objProcess.Start()
                                'objProcess.WaitForExit()
                                'objProcess.Close()
                            Catch ex As Exception
                                DevExpress.XtraEditors.XtraMessageBox.Show("Islem Baslatilamiyor " & objProcess.StartInfo.FileName.ToString)
                                'MessageBox.Show(ex.ToString)
                            End Try
                        End If
                    End If
                End If
            ElseIf dr("sCihaz") = "SiemensPos-2" Then
                If sKasaIletisim = "Online" Or sKasaIletisim = "Ofline+Online" Then
                    AppYazarKasa.firmano = firmano
                    AppYazarKasa.donemno = donemno
                    AppYazarKasa.connection = connection
                    AppYazarKasa.nKayitSinir = nKayitSinir
                    If frm.sec_islem.SelectedIndex = 0 Then
                        posdll.SIEMENS_MDB_tumu(dr("sPath"), dr("sFile"), dr("sFiyatTipi"), dr("sGramaj").ToString)
                    ElseIf frm.sec_islem.SelectedIndex = 1 Then
                        posdll.dataset1 = DataSet1
                        posdll.SIEMENS_TXT_secili(dr("sPath"), dr("sFile"), dr("sFiyatTipi"), dr("sGramaj").ToString)
                    End If
                    If dr("sRun").ToString <> "" Then
                        If XtraMessageBox.Show(Sorgu_sDil("Kasaya Göndermek Ýstiyormusunuz..?", sDil), Sorgu_sDil("Dikkat", sDil), MessageBoxButtons.YesNo, MessageBoxIcon.Question) = MsgBoxResult.Yes Then
                            objProcess.StartInfo.FileName = Trim(dr("sRun").ToString)
                            objProcess.StartInfo.Arguments = ""
                            Try
                                objProcess.Start()
                                'objProcess.WaitForExit()
                                'objProcess.Close()
                            Catch ex As Exception
                                DevExpress.XtraEditors.XtraMessageBox.Show("Islem Baslatilamiyor " & objProcess.StartInfo.FileName.ToString)
                                'MessageBox.Show(ex.ToString)
                            End Try
                        End If
                    End If
                End If
            ElseIf dr("sCihaz") = "CasLp1" Then
                AppYazarKasa.firmano = firmano
                AppYazarKasa.donemno = donemno
                AppYazarKasa.connection = connection
                AppYazarKasa.nKayitSinir = nKayitSinir
                posdll.dataset1 = DataSet1
                posdll.CASLP1_tumu(dr("sPath"), dr("sFile"), dr("sFiyatTipi"), dr("sGramaj").ToString, frm.sec_islem.SelectedIndex, dr("nSinif"), dr("sSinif"))
                If dr("sRun").ToString <> "" Then
                    If XtraMessageBox.Show(Sorgu_sDil("Teraziye Göndermek Ýstiyormusunuz..?", sDil), Sorgu_sDil("Dikkat", sDil), MessageBoxButtons.YesNo, MessageBoxIcon.Question) = MsgBoxResult.Yes Then
                        objProcess.StartInfo.FileName = Trim(dr("sRun").ToString)
                        objProcess.StartInfo.Arguments = ""
                        Try
                            objProcess.Start()
                            'objProcess.WaitForExit()
                            'objProcess.Close()
                        Catch ex As Exception
                            DevExpress.XtraEditors.XtraMessageBox.Show("Islem Baslatilamiyor " & objProcess.StartInfo.FileName.ToString)
                            'MessageBox.Show(ex.ToString)
                        End Try
                    End If
                End If
            ElseIf dr("sCihaz") = "CasLp1-1" Then
                AppYazarKasa.firmano = firmano
                AppYazarKasa.donemno = donemno
                AppYazarKasa.connection = connection
                AppYazarKasa.nKayitSinir = nKayitSinir
                posdll.dataset1 = DataSet1
                posdll.CASLP1_tumu(dr("sPath"), dr("sFile"), dr("sFiyatTipi"), dr("sGramaj").ToString, frm.sec_islem.SelectedIndex, dr("nSinif"), dr("sSinif"), True)
                If dr("sRun").ToString <> "" Then
                    If XtraMessageBox.Show(Sorgu_sDil("Teraziye Göndermek Ýstiyormusunuz..?", sDil), Sorgu_sDil("Dikkat", sDil), MessageBoxButtons.YesNo, MessageBoxIcon.Question) = MsgBoxResult.Yes Then
                        objProcess.StartInfo.FileName = Trim(dr("sRun").ToString)
                        objProcess.StartInfo.Arguments = ""
                        Try
                            objProcess.Start()
                            'objProcess.WaitForExit()
                            'objProcess.Close()
                        Catch ex As Exception
                            DevExpress.XtraEditors.XtraMessageBox.Show("Islem Baslatilamiyor " & objProcess.StartInfo.FileName.ToString)
                            'MessageBox.Show(ex.ToString)
                        End Try
                    End If
                End If
            ElseIf dr("sCihaz") = "CasLp2" Or dr("sCihaz") = "Densi" Then
                AppYazarKasa.firmano = firmano
                AppYazarKasa.donemno = donemno
                AppYazarKasa.connection = connection
                AppYazarKasa.nKayitSinir = nKayitSinir
                posdll.dataset1 = DataSet1
                posdll.CASLP1_tumu(dr("sPath"), dr("sFile"), dr("sFiyatTipi"), dr("sGramaj").ToString, frm.sec_islem.SelectedIndex, dr("nSinif"), dr("sSinif"))
                If dr("sRun").ToString <> "" Then
                    If XtraMessageBox.Show(Sorgu_sDil("Teraziye Göndermek Ýstiyormusunuz..?", sDil), Sorgu_sDil("Dikkat", sDil), MessageBoxButtons.YesNo, MessageBoxIcon.Question) = MsgBoxResult.Yes Then
                        objProcess.StartInfo.FileName = Trim(dr("sRun").ToString)
                        objProcess.StartInfo.Arguments = ""
                        Try
                            objProcess.Start()
                            'objProcess.WaitForExit()
                            'objProcess.Close()
                        Catch ex As Exception
                            DevExpress.XtraEditors.XtraMessageBox.Show("Islem Baslatilamiyor " & objProcess.StartInfo.FileName.ToString)
                            'MessageBox.Show(ex.ToString)
                        End Try
                    End If
                End If
            ElseIf dr("sCihaz") = "Dibal" Then
                AppYazarKasa.firmano = firmano
                AppYazarKasa.donemno = donemno
                AppYazarKasa.connection = connection
                AppYazarKasa.nKayitSinir = nKayitSinir
                posdll.dataset1 = DataSet1
                posdll.Dibal_tumu(dr("sPath"), dr("sFile"), dr("sFiyatTipi"), dr("sGramaj").ToString, frm.sec_islem.SelectedIndex, dr("nSinif"), dr("sSinif"))
                If dr("sRun").ToString <> "" Then
                    If XtraMessageBox.Show(Sorgu_sDil("Teraziye Göndermek Ýstiyormusunuz..?", sDil), Sorgu_sDil("Dikkat", sDil), MessageBoxButtons.YesNo, MessageBoxIcon.Question) = MsgBoxResult.Yes Then
                        objProcess.StartInfo.FileName = Trim(dr("sRun").ToString)
                        objProcess.StartInfo.Arguments = ""
                        Try
                            objProcess.Start()
                            'objProcess.WaitForExit()
                            'objProcess.Close()
                        Catch ex As Exception
                            DevExpress.XtraEditors.XtraMessageBox.Show("Islem Baslatilamiyor " & objProcess.StartInfo.FileName.ToString)
                            'MessageBox.Show(ex.ToString)
                        End Try
                    End If
                End If
            ElseIf dr("sCihaz") = "AveryBarkel" Then
                AppYazarKasa.firmano = firmano
                AppYazarKasa.donemno = donemno
                AppYazarKasa.connection = connection
                AppYazarKasa.nKayitSinir = nKayitSinir
                posdll.dataset1 = DataSet1
                posdll.AveryBarkel_tumu(dr("sPath"), dr("sFile"), dr("sFiyatTipi"), dr("sGramaj").ToString, frm.sec_islem.SelectedIndex, dr("nSinif"), dr("sSinif"))
                If dr("sRun").ToString <> "" Then
                    If XtraMessageBox.Show(Sorgu_sDil("Teraziye Göndermek Ýstiyormusunuz..?", sDil), Sorgu_sDil("Dikkat", sDil), MessageBoxButtons.YesNo, MessageBoxIcon.Question) = MsgBoxResult.Yes Then
                        objProcess.StartInfo.FileName = Trim(dr("sRun").ToString)
                        objProcess.StartInfo.Arguments = ""
                        Try
                            objProcess.Start()
                            'objProcess.WaitForExit()
                            'objProcess.Close()
                        Catch ex As Exception
                            DevExpress.XtraEditors.XtraMessageBox.Show("Islem Baslatilamiyor " & objProcess.StartInfo.FileName.ToString)
                            'MessageBox.Show(ex.ToString)
                        End Try
                    End If
                End If
            ElseIf dr("sCihaz") = "OlivettiLp15" Then
                AppYazarKasa.firmano = firmano
                AppYazarKasa.donemno = donemno
                AppYazarKasa.connection = connection
                AppYazarKasa.nKayitSinir = nKayitSinir
                posdll.dataset1 = DataSet1
                posdll.OLIVETTILP15_tumu(dr("sPath"), dr("sFile"), dr("sFiyatTipi"), dr("sGramaj").ToString, frm.sec_islem.SelectedIndex, dr("nSinif"), dr("sSinif"))
                If dr("sRun").ToString <> "" Then
                    If XtraMessageBox.Show(Sorgu_sDil("Teraziye Göndermek Ýstiyormusunuz..?", sDil), Sorgu_sDil("Dikkat", sDil), MessageBoxButtons.YesNo, MessageBoxIcon.Question) = MsgBoxResult.Yes Then
                        objProcess.StartInfo.FileName = Trim(dr("sRun").ToString)
                        objProcess.StartInfo.Arguments = ""
                        Try
                            objProcess.Start()
                            'objProcess.WaitForExit()
                            'objProcess.Close()
                        Catch ex As Exception
                            DevExpress.XtraEditors.XtraMessageBox.Show("Islem Baslatilamiyor " & objProcess.StartInfo.FileName.ToString)
                            'MessageBox.Show(ex.ToString)
                        End Try
                    End If
                End If
            ElseIf dr("sCihaz") = "Formula7400" Then
                AppYazarKasa.firmano = firmano
                AppYazarKasa.donemno = donemno
                AppYazarKasa.connection = connection
                AppYazarKasa.nKayitSinir = nKayitSinir
                posdll.dataset1 = DataSet1
                posdll.formula7400_sayim_secili(dr("sPath"), dr("sFile"), dr("sFiyatTipi"), dr("sGramaj").ToString)
                If dr("sRun").ToString <> "" Then
                    If XtraMessageBox.Show(Sorgu_sDil("Terminale Dosyayi Göndermek Ýstiyormusunuz..?", sDil), Sorgu_sDil("Dikkat", sDil), MessageBoxButtons.YesNo, MessageBoxIcon.Question) = MsgBoxResult.Yes Then
                        objProcess.StartInfo.FileName = Trim(dr("sRun").ToString)
                        objProcess.StartInfo.Arguments = ""
                        Try
                            objProcess.Start()
                            'objProcess.WaitForExit()
                            'objProcess.Close()
                        Catch ex As Exception
                            DevExpress.XtraEditors.XtraMessageBox.Show("Islem Baslatilamiyor " & objProcess.StartInfo.FileName.ToString)
                            'MessageBox.Show(ex.ToString)
                        End Try
                    End If
                End If
            ElseIf dr("sCihaz") = "BusinessMobile" Then
                AppYazarKasa.firmano = firmano
                AppYazarKasa.donemno = donemno
                AppYazarKasa.connection = connection
                AppYazarKasa.nKayitSinir = nKayitSinir
                If frm.sec_islem.SelectedIndex = 0 Then
                    posdll.BusinessMobile_TXT_tumu(dr("sPath"), dr("sFile"), dr("sFiyatTipi"), dr("sGramaj").ToString)
                ElseIf frm.sec_islem.SelectedIndex = 1 Then
                    posdll.dataset1 = DataSet1
                    posdll.BusinessMobile_TXT_secili(dr("sPath"), dr("sFile"), dr("sFiyatTipi"), dr("sGramaj").ToString)
                ElseIf frm.sec_islem.SelectedIndex = 2 Then
                    posdll.BusinessMobile_cariler(dr("sPath"), dr("sFile"), dr("sFiyatTipi"), dr("sGramaj").ToString)
                End If
                If dr("sRun").ToString <> "" Then
                    If XtraMessageBox.Show(Sorgu_sDil("Terminale Dosyayi Göndermek Ýstiyormusunuz..?", sDil), Sorgu_sDil("Dikkat", sDil), MessageBoxButtons.YesNo, MessageBoxIcon.Question) = MsgBoxResult.Yes Then
                        objProcess.StartInfo.FileName = Trim(dr("sRun").ToString)
                        objProcess.StartInfo.Arguments = ""
                        Try
                            objProcess.Start()
                            'objProcess.WaitForExit()
                            'objProcess.Close()
                        Catch ex As Exception
                            DevExpress.XtraEditors.XtraMessageBox.Show("Islem Baslatilamiyor " & objProcess.StartInfo.FileName.ToString)
                            'MessageBox.Show(ex.ToString)
                        End Try
                    End If
                End If
            ElseIf dr("sCihaz") = "SambaPos" Then
                AppYazarKasa.firmano = firmano
                AppYazarKasa.donemno = donemno
                AppYazarKasa.connection = connection
                AppYazarKasa.nKayitSinir = nKayitSinir
                If frm.sec_islem.SelectedIndex = 0 Then
                    posdll.SambaPos_Stoklar_tumu(dr("sPath"), dr("sFile"), dr("sFiyatTipi"), dr("sGramaj").ToString)
                ElseIf frm.sec_islem.SelectedIndex = 1 Then
                    posdll.dataset1 = DataSet1
                    posdll.SambaPos_Stoklar_secili(dr("sPath"), dr("sFile"), dr("sFiyatTipi"), dr("sGramaj").ToString)
                ElseIf frm.sec_islem.SelectedIndex = 2 Then
                    posdll.SambaPos_musteriler(dr("sPath"), dr("sFile"), dr("sFiyatTipi"), dr("sGramaj").ToString, dr("lNo"))
                End If
                If dr("sRun").ToString <> "" Then
                    If XtraMessageBox.Show(Sorgu_sDil("Terminale Dosyayi Göndermek Ýstiyormusunuz..?", sDil), Sorgu_sDil("Dikkat", sDil), MessageBoxButtons.YesNo, MessageBoxIcon.Question) = MsgBoxResult.Yes Then
                        objProcess.StartInfo.FileName = Trim(dr("sRun").ToString)
                        objProcess.StartInfo.Arguments = ""
                        Try
                            objProcess.Start()
                            'objProcess.WaitForExit()
                            'objProcess.Close()
                        Catch ex As Exception
                            DevExpress.XtraEditors.XtraMessageBox.Show("Islem Baslatilamiyor " & objProcess.StartInfo.FileName.ToString)
                            'MessageBox.Show(ex.ToString)
                        End Try
                    End If
                End If
            ElseIf dr("sCihaz") = "PscFalcon" Then
                AppYazarKasa.firmano = firmano
                AppYazarKasa.donemno = donemno
                AppYazarKasa.connection = connection
                AppYazarKasa.nKayitSinir = nKayitSinir
                posdll.dataset1 = DataSet1
                posdll.psc_falcon_secili(dr("sPath"), dr("sFile"), dr("sFiyatTipi"), dr("sGramaj").ToString)
                If dr("sRun").ToString <> "" Then
                    If XtraMessageBox.Show(Sorgu_sDil("Terminale Dosyayi Göndermek Ýstiyormusunuz..?", sDil), Sorgu_sDil("Dikkat", sDil), MessageBoxButtons.YesNo, MessageBoxIcon.Question) = MsgBoxResult.Yes Then
                        objProcess.StartInfo.FileName = Trim(dr("sRun").ToString)
                        objProcess.StartInfo.Arguments = ""
                        Try
                            objProcess.Start()
                            'objProcess.WaitForExit()
                            'objProcess.Close()
                        Catch ex As Exception
                            DevExpress.XtraEditors.XtraMessageBox.Show("Islem Baslatilamiyor " & objProcess.StartInfo.FileName.ToString)
                            'MessageBox.Show(ex.ToString)
                        End Try
                    End If
                End If
            End If
            dr = Nothing
        End If
        objProcess.Dispose()
        objProcess = Nothing
        frm.Close()
        frm = Nothing
    End Sub
    Private Sub Entegrasyon()
        Dim frm As New frm_tbPos
        frm.firmano = firmano
        frm.donemno = donemno
        frm.connection = connection
        frm.islem = "Entegrasyon"
        frm.sKasaIletisim = sKasaIletisim
        Dim objProcess As System.Diagnostics.Process
        objProcess = New System.Diagnostics.Process()
        objProcess.StartInfo.WindowStyle = ProcessWindowStyle.Hidden
        If frm.ShowDialog(Me) = Windows.Forms.DialogResult.OK Then
            Dim dr As DataRow = frm.GridView1.GetDataRow(frm.GridView1.FocusedRowHandle)
            If dr("sCihaz") = "SharpErA495" Then
                Dim sPort As String = "1"
                If dr("sPort") = "COM1" Then
                    sPort = "1"
                ElseIf dr("sPort") = "COM2" Then
                    sPort = "2"
                End If
                If frm.sec_islem.SelectedIndex = 0 Then
                    'Stok Kayýtlarýný Oku
                    objProcess.StartInfo.FileName = "C:\persis\SharpCom.exe"
                    objProcess.StartInfo.Arguments = sPort & " 00000" & dr("lNo") & " 20 0 31 1 Ean.txt Ean.Err"
                ElseIf frm.sec_islem.SelectedIndex = 1 Then
                    'Satýþlarý Oku /EAN
                    Dim z As String = "c:\persis\EanSatis" & dr("lNo") & ".txt"
                    Dim DOSYA As New FileInfo(z)
                    If DOSYA.Exists Then
                        DOSYA.Delete()
                    End If
                    objProcess.StartInfo.FileName = "C:\persis\SharpCom.exe"
                    objProcess.StartInfo.Arguments = sPort & " 00000" & dr("lNo") & " 20 2 31 1 EanSatis" & dr("lNo") & ".txt EanSatis.Err ////010000000000 "
                ElseIf frm.sec_islem.SelectedIndex = 2 Then
                    'Satýþlarý Oku/PLU
                    Dim z As String = "c:\persis\PluSatis" & dr("lNo") & ".txt"
                    Dim DOSYA As New FileInfo(z)
                    If DOSYA.Exists Then
                        DOSYA.Delete()
                    End If
                    objProcess.StartInfo.FileName = "C:\persis\SharpCom.exe"
                    objProcess.StartInfo.Arguments = sPort & " 00000" & dr("lNo") & " 20 2 11 1 PluSatis" & dr("lNo") & ".txt PluSatis.Err ////010000000000 "
                ElseIf frm.sec_islem.SelectedIndex = 3 Then
                    'Gün Sonu Ýþlemi
                ElseIf frm.sec_islem.SelectedIndex = 4 Then
                    'Satýþlarý Aktar
                ElseIf frm.sec_islem.SelectedIndex = 5 Then
                    'Satýþlarý Sil /EAN
                    objProcess.StartInfo.FileName = "C:\persis\SharpCom.exe"
                    objProcess.StartInfo.Arguments = sPort & " 00000" & dr("lNo") & " 32 - 01 1 * Hata.ERR 0109/  "
                ElseIf frm.sec_islem.SelectedIndex = 6 Then
                    'Satýþlarý Sil /PLU
                    objProcess.StartInfo.FileName = "C:\persis\SharpCom.exe"
                    objProcess.StartInfo.Arguments = sPort & " 00000" & dr("lNo") & " 32 - 01 1 * Hata.ERR 0120/  "
                ElseIf frm.sec_islem.SelectedIndex = 7 Then
                    'Genel Ciro Raporu
                    objProcess.StartInfo.FileName = "C:\persis\SharpCom.exe"
                    objProcess.StartInfo.Arguments = sPort & " 00000" & dr("lNo") & " 20 0 21 1 satis.txt satis.err"
                ElseIf frm.sec_islem.SelectedIndex = 8 Then
                    'Kasiyer Ciro Raporu
                    objProcess.StartInfo.FileName = "C:\persis\SharpCom.exe"
                    objProcess.StartInfo.Arguments = sPort & " 00000" & dr("lNo") & " 20 0 43 1 GunKasy.txt GunKasy.Err"
                ElseIf frm.sec_islem.SelectedIndex = 9 Then
                    'Departman Ciro Raporu
                    objProcess.StartInfo.FileName = "C:\persis\SharpCom.exe"
                    objProcess.StartInfo.Arguments = sPort & " 00000" & dr("lNo") & " 20 0 01 1 dep.txt dep.err"
                ElseIf frm.sec_islem.SelectedIndex = 10 Then
                    'Saatlik Ciro Raporu
                    objProcess.StartInfo.FileName = "C:\persis\SharpCom.exe"
                    objProcess.StartInfo.Arguments = sPort & " 00000" & dr("lNo") & " 20 0 61 1 SaatBilgi.txt SaatBilgi.Err"
                End If
                Dim dlg As New WaitDlgFrm("Haberlesme Kuruluyor...")
                Try
                    If frm.sec_islem.SelectedIndex = 3 Then
                    ElseIf frm.sec_islem.SelectedIndex = 4 Then
                    Else
                        objProcess.Start()
                        objProcess.WaitForExit()
                        objProcess.Close()
                    End If
                    If frm.sec_islem.SelectedIndex = 0 Then
                        If XtraMessageBox.Show(Sorgu_sDil("Stok Kayýtlarýný Güncellemek Ýstediðinize Emin misiniz...?", sDil), Sorgu_sDil("Dikkat", sDil), MessageBoxButtons.YesNo, MessageBoxIcon.Question) = MsgBoxResult.Yes Then
                            textdosyaaktarsharp("c:\Persis\Ean.txt", dr("sGramaj"))
                        End If
                    ElseIf frm.sec_islem.SelectedIndex = 1 Then
                        'Satislari Oku /EAN
                    ElseIf frm.sec_islem.SelectedIndex = 2 Then
                        'Satislari Oku /PLU
                    ElseIf frm.sec_islem.SelectedIndex = 3 Then
                        'Gun Sonu Islemi
                        Dim con As New OleDb.OleDbConnection
                        Dim cmd As New OleDb.OleDbCommand
                        cmd.Connection = con
                        con.ConnectionString = connection
                        If con.State = ConnectionState.Closed = True Then
                            con.Open()
                        End If
                        cmd.CommandText = "DELETE FROM BTBLINTERSATIS Where sKullanici= '" & kullanici & "'"
                        cmd.ExecuteNonQuery()
                        cmd.CommandText = "TRUNCATE TABLE BTBLINTERCIRO"
                        cmd.ExecuteNonQuery()
                        con.Close()
                        AppYazarKasa.firmano = firmano
                        AppYazarKasa.donemno = donemno
                        AppYazarKasa.connection = connection
                        dlg.Close()
                        If posdll.SHARP_GUNSONU("c:\Persis\EanSatis.txt", dr("lNo"), dr("sDepo"), 0, kullanici, frm.sec_islem.SelectedIndex, dr("sGramaj")) = True Then
                            Dim fr As New frm_tbPos_Satislar
                            fr.firmano = firmano
                            fr.donemno = donemno
                            fr.connection = connection
                            fr.kullanici = kullanici
                            fr.ShowDialog()
                        End If
                    ElseIf frm.sec_islem.SelectedIndex = 4 Then
                        'Satislari Aktar
                        If XtraMessageBox.Show(Sorgu_sDil("Yapýlan Satýþlarý Sisteme Aktarmak Ýstediðinize Emin misiniz...?", sDil), Sorgu_sDil("Dikkat", sDil), MessageBoxButtons.YesNo, MessageBoxIcon.Question) = MsgBoxResult.Yes Then
                            entegre()
                        End If
                    ElseIf frm.sec_islem.SelectedIndex = 5 Then
                        'Satislari Sil /EAN
                    ElseIf frm.sec_islem.SelectedIndex = 6 Then
                        'Satislari Sil /PLU
                    ElseIf frm.sec_islem.SelectedIndex = 7 Then
                        'Genel Ciro Raporu
                        posdll.SHARP_Ciro_Genel("C:\Persis\Satis.txt")
                    ElseIf frm.sec_islem.SelectedIndex = 8 Then
                        'Kasiyer Ciro Raporu
                    ElseIf frm.sec_islem.SelectedIndex = 9 Then
                        'Departman Ciro Raporu
                        posdll.SHARP_Ciro_Departman("C:\Persis\Dep.txt")
                    ElseIf frm.sec_islem.SelectedIndex = 10 Then
                        'Saatlik Ciro Raporu
                    End If
                Catch ex As Exception
                    DevExpress.XtraEditors.XtraMessageBox.Show("Islem Baslatilamiyor " & objProcess.StartInfo.FileName.ToString)
                    'MessageBox.Show(ex.ToString)
                End Try
                dlg.Close()
                frm = Nothing
            ElseIf dr("sCihaz") = "Hugin425TX" Then
                Dim sPort As String = "1"
                If dr("sPort") = "COM1" Then
                    sPort = "1"
                ElseIf dr("sPort") = "COM2" Then
                    sPort = "2"
                End If
                If frm.sec_islem.SelectedIndex = 0 Then
                    'Stok Kayýtlarýný Oku
                    objProcess.StartInfo.FileName = "C:\HuginAlpha\Hugin.exe"
                    'objProcess.StartInfo.Arguments = sPort & " 00000" & dr("lNo") & " 20 0 31 1 Ean.txt Ean.Err"
                ElseIf frm.sec_islem.SelectedIndex = 1 Then
                    'Satýþlarý Oku /EAN
                    Dim z As String = "c:\persis\EanSatis" & dr("lNo") & ".txt"
                    Dim DOSYA As New FileInfo(z)
                    If DOSYA.Exists Then
                        DOSYA.Delete()
                    End If
                    objProcess.StartInfo.FileName = "C:\HuginAlpha\Hugin.exe"
                    'objProcess.StartInfo.Arguments = sPort & " 00000" & dr("lNo") & " 20 2 31 1 EanSatis" & dr("lNo") & ".txt EanSatis.Err ////010000000000 "
                ElseIf frm.sec_islem.SelectedIndex = 2 Then
                    'Satýþlarý Oku/PLU
                    Dim z As String = "c:\persis\PluSatis" & dr("lNo") & ".txt"
                    Dim DOSYA As New FileInfo(z)
                    If DOSYA.Exists Then
                        DOSYA.Delete()
                    End If
                    objProcess.StartInfo.FileName = "C:\HuginAlpha\Hugin.exe"
                    'objProcess.StartInfo.Arguments = sPort & " 00000" & dr("lNo") & " 20 2 11 1 PluSatis" & dr("lNo") & ".txt PluSatis.Err ////010000000000 "
                ElseIf frm.sec_islem.SelectedIndex = 3 Then
                    'Gün Sonu Ýþlemi
                ElseIf frm.sec_islem.SelectedIndex = 4 Then
                    'Satýþlarý Aktar
                ElseIf frm.sec_islem.SelectedIndex = 5 Then
                    'Satýþlarý Sil /EAN
                    objProcess.StartInfo.FileName = "C:\HuginAlpha\Hugin.exe"
                    'objProcess.StartInfo.Arguments = sPort & " 00000" & dr("lNo") & " 32 - 01 1 * Hata.ERR 0109/  "
                ElseIf frm.sec_islem.SelectedIndex = 6 Then
                    'Satýþlarý Sil /PLU
                    objProcess.StartInfo.FileName = "C:\persis\SharpCom.exe"
                    objProcess.StartInfo.Arguments = sPort & " 00000" & dr("lNo") & " 32 - 01 1 * Hata.ERR 0120/  "
                ElseIf frm.sec_islem.SelectedIndex = 7 Then
                    'Genel Ciro Raporu
                    objProcess.StartInfo.FileName = "C:\HuginAlpha\Hugin.exe"
                    'objProcess.StartInfo.Arguments = sPort & " 00000" & dr("lNo") & " 20 0 21 1 satis.txt satis.err"
                ElseIf frm.sec_islem.SelectedIndex = 8 Then
                    'Kasiyer Ciro Raporu
                    objProcess.StartInfo.FileName = "C:\HuginAlpha\Hugin.exe"
                    'objProcess.StartInfo.Arguments = sPort & " 00000" & dr("lNo") & " 20 0 43 1 GunKasy.txt GunKasy.Err"
                ElseIf frm.sec_islem.SelectedIndex = 9 Then
                    'Departman Ciro Raporu
                    objProcess.StartInfo.FileName = "C:\HuginAlpha\Hugin.exe"
                    'objProcess.StartInfo.Arguments = sPort & " 00000" & dr("lNo") & " 20 0 01 1 dep.txt dep.err"
                ElseIf frm.sec_islem.SelectedIndex = 10 Then
                    'Saatlik Ciro Raporu
                    objProcess.StartInfo.FileName = "C:\HuginAlpha\Hugin.exe"
                    'objProcess.StartInfo.Arguments = sPort & " 00000" & dr("lNo") & " 20 0 61 1 SaatBilgi.txt SaatBilgi.Err"
                End If
                Dim dlg As New WaitDlgFrm("Haberlesme Kuruluyor...")
                Try
                    If frm.sec_islem.SelectedIndex = 3 Then
                    ElseIf frm.sec_islem.SelectedIndex = 4 Then
                    Else
                        objProcess.Start()
                        objProcess.WaitForExit()
                        objProcess.Close()
                    End If
                    If frm.sec_islem.SelectedIndex = 0 Then
                        If XtraMessageBox.Show(Sorgu_sDil("Stok Kayýtlarýný Güncellemek Ýstediðinize Emin misiniz...?", sDil), Sorgu_sDil("Dikkat", sDil), MessageBoxButtons.YesNo, MessageBoxIcon.Question) = MsgBoxResult.Yes Then
                            textdosyaaktarsharp("c:\HuginAlpha\Ean.txt", dr("sGramaj"))
                        End If
                    ElseIf frm.sec_islem.SelectedIndex = 1 Then
                        'Satislari Oku /EAN
                    ElseIf frm.sec_islem.SelectedIndex = 2 Then
                        'Satislari Oku /PLU
                    ElseIf frm.sec_islem.SelectedIndex = 3 Then
                        'Gun Sonu Islemi
                        Dim con As New OleDb.OleDbConnection
                        Dim cmd As New OleDb.OleDbCommand
                        cmd.Connection = con
                        con.ConnectionString = connection
                        If con.State = ConnectionState.Closed = True Then
                            con.Open()
                        End If
                        cmd.CommandText = "DELETE FROM BTBLINTERSATIS Where sKullanici= '" & kullanici & "'"
                        cmd.ExecuteNonQuery()
                        cmd.CommandText = "TRUNCATE TABLE BTBLINTERCIRO"
                        cmd.ExecuteNonQuery()
                        con.Close()
                        AppYazarKasa.firmano = firmano
                        AppYazarKasa.donemno = donemno
                        AppYazarKasa.connection = connection
                        dlg.Close()
                        If posdll.HUGIN_GUNSONU("c:\HuginAlpha\EanSatis.txt", dr("lNo"), dr("sDepo"), 0, kullanici, frm.sec_islem.SelectedIndex, dr("sGramaj")) = True Then
                            Dim fr As New frm_tbPos_Satislar
                            fr.firmano = firmano
                            fr.donemno = donemno
                            fr.connection = connection
                            fr.kullanici = kullanici
                            fr.ShowDialog()
                        End If
                    ElseIf frm.sec_islem.SelectedIndex = 4 Then
                        'Satislari Aktar
                        If XtraMessageBox.Show(Sorgu_sDil("Yapýlan Satýþlarý Sisteme Aktarmak Ýstediðinize Emin misiniz...?", sDil), Sorgu_sDil("Dikkat", sDil), MessageBoxButtons.YesNo, MessageBoxIcon.Question) = MsgBoxResult.Yes Then
                            entegre()
                        End If
                    ElseIf frm.sec_islem.SelectedIndex = 5 Then
                        'Satislari Sil /EAN
                    ElseIf frm.sec_islem.SelectedIndex = 6 Then
                        'Satislari Sil /PLU
                    ElseIf frm.sec_islem.SelectedIndex = 7 Then
                        'Genel Ciro Raporu
                        posdll.SHARP_Ciro_Genel("C:\HuginAlpha\Satis.txt")
                    ElseIf frm.sec_islem.SelectedIndex = 8 Then
                        'Kasiyer Ciro Raporu
                    ElseIf frm.sec_islem.SelectedIndex = 9 Then
                        'Departman Ciro Raporu
                        posdll.SHARP_Ciro_Departman("C:\HuginAlpha\Dep.txt")
                    ElseIf frm.sec_islem.SelectedIndex = 10 Then
                        'Saatlik Ciro Raporu
                    End If
                Catch ex As Exception
                    DevExpress.XtraEditors.XtraMessageBox.Show("Islem Baslatilamiyor " & objProcess.StartInfo.FileName.ToString)
                    'MessageBox.Show(ex.ToString)
                End Try
                dlg.Close()
                frm = Nothing
            ElseIf dr("sCihaz") = "IbmPos" Then
                If frm.sec_islem.SelectedIndex = 0 Then
                    Dim fm As New frm_tbPos_Stoklar
                    fm.firmano = firmano
                    fm.donemno = donemno
                    fm.connection = connection
                    fm.kasa = "Ibm"
                    fm.sPath = dr("sPath")
                    fm.sFile = dr("sFile")
                    fm.sGramaj = dr("sGramaj")
                    fm.Show()
                ElseIf frm.sec_islem.SelectedIndex > 0 Then
                    Dim con As New OleDb.OleDbConnection
                    Dim cmd As New OleDb.OleDbCommand
                    cmd.Connection = con
                    con.ConnectionString = connection
                    If con.State = ConnectionState.Closed = True Then
                        con.Open()
                    End If
                    cmd.CommandText = "DELETE FROM BTBLINTERSATIS Where sKullanici= '" & kullanici & "'"
                    cmd.ExecuteNonQuery()
                    cmd.CommandText = "TRUNCATE TABLE BTBLINTERCIRO"
                    cmd.ExecuteNonQuery()
                    con.Close()
                    Dim yil As String = ""
                    Dim gun As String = ""
                    Dim ay As String = ""
                    Dim sTarih As String = dr("dteTarih").ToString
                    Dim sFile As String = ""
                    Dim lKasaNo As Integer = dr("lNo")
                    Dim i As Integer = 0
                    For i = dr("lNo") To dr("lSonNo")
                        sFile = dr("sPath") & ":" & dr("sFile")
                        yil = sTarih.Substring(6, 4)
                        gun = sTarih.Substring(0, 2)
                        ay = sTarih.Substring(3, 2)
                        sFile += gun
                        sFile += ay
                        sFile += yil
                        sFile += ".GTF"
                        Dim sDosya As New FileInfo(sFile)
                        If sDosya.Exists Then
                            sDosya.CopyTo("" & sFile & "YDK", True)
                            AppYazarKasa.firmano = firmano
                            AppYazarKasa.donemno = donemno
                            AppYazarKasa.connection = connection
                            If frm.sec_islem.SelectedIndex = 1 Then
                                posdll.IBM_satisoku(sFile & "YDK", "Siemens", dr("sDepo"), 0, kullanici, frm.sec_islem.SelectedIndex, dr("sGramaj"))
                            ElseIf frm.sec_islem.SelectedIndex = 2 Then
                                posdll.IBM_satisoku(sFile & "YDK", "Siemens", dr("sDepo"), 0, kullanici, frm.sec_islem.SelectedIndex, dr("sGramaj"))
                            ElseIf frm.sec_islem.SelectedIndex > 2 Then
                                posdll.IBM_satisoku(sFile & "YDK", "Siemens", dr("sDepo"), 0, kullanici, frm.sec_islem.SelectedIndex, dr("sGramaj"))
                            End If
                        Else
                            XtraMessageBox.Show(Sorgu_sDil("Hareket Dosyasý Bulunamadý", sDil) & vbCrLf & Sorgu_sDil("Kasa No =", sDil) & lKasaNo & vbCrLf & "Path :" & sFile, Sorgu_sDil("Dikkat", sDil), MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                        End If
                        lKasaNo += 1
                    Next
                    yil = Nothing
                    gun = Nothing
                    ay = Nothing
                    sTarih = Nothing
                    sFile = Nothing
                    lKasaNo = Nothing
                    cmd = Nothing
                    con = Nothing
                    If frm.sec_islem.SelectedIndex = 1 Then
                        Dim fr As New frm_tbPos_Satislar
                        fr.firmano = firmano
                        fr.donemno = donemno
                        fr.connection = connection
                        fr.kullanici = kullanici
                        fr.ShowDialog()
                    ElseIf frm.sec_islem.SelectedIndex = 2 Then
                        If XtraMessageBox.Show(Sorgu_sDil("Yapýlan Satýþlarý Sisteme Aktarmak Ýstediðinize Emin misiniz...?", sDil), Sorgu_sDil("Dikkat", sDil), MessageBoxButtons.YesNo, MessageBoxIcon.Question) = MsgBoxResult.Yes Then
                            entegre()
                        End If
                    ElseIf frm.sec_islem.SelectedIndex > 2 Then
                        Dim fr As New frm_emir_kasa_kasiyer
                        fr.nPosIslem = frm.sec_islem.SelectedIndex
                        fr.DateEdit1.EditValue = dr("dteTarih")
                        fr.DateEdit1.Properties.ReadOnly = True
                        fr.DateEdit2.EditValue = dr("dteTarih")
                        fr.DateEdit2.Properties.ReadOnly = True
                        fr.firmano = firmano
                        fr.donemno = donemno
                        fr.connection = connection
                        fr.kullanici = kullanici
                        fr.pos = True
                        fr.islemstatus = True
                        fr.ShowDialog()
                    End If
                End If
            ElseIf dr("sCihaz") = "SiemensPos-1" Or dr("sCihaz") = "SiemensPos-2" Or dr("sCihaz") = "SiemensPos-3" Then
                If frm.sec_islem.SelectedIndex = 0 Then
                    Dim fm As New frm_tbPos_Stoklar
                    fm.firmano = firmano
                    fm.donemno = donemno
                    fm.connection = connection
                    fm.kasa = "inter"
                    fm.sPath = dr("sPath")
                    fm.sFile = dr("sFile")
                    fm.Show()
                ElseIf frm.sec_islem.SelectedIndex > 0 Then
                    Dim con As New OleDb.OleDbConnection
                    Dim cmd As New OleDb.OleDbCommand
                    cmd.Connection = con
                    con.ConnectionString = connection
                    If con.State = ConnectionState.Closed = True Then
                        con.Open()
                    End If
                    cmd.CommandText = "DELETE FROM BTBLINTERSATIS Where sKullanici= '" & kullanici & "'"
                    cmd.ExecuteNonQuery()
                    cmd.CommandText = "TRUNCATE TABLE BTBLINTERCIRO"
                    cmd.ExecuteNonQuery()
                    con.Close()
                    Dim yil As String = ""
                    Dim gun As String = ""
                    Dim ay As String = ""
                    Dim sTarih As String = dr("dteTarih").ToString
                    Dim sFile As String = ""
                    Dim lKasaNo As Integer = dr("lNo")
                    Dim i As Integer = 0
                    For i = dr("lNo") To dr("lSonNo")
                        sFile = dr("sPath") & ":" & dr("sFile") & "AS"
                        yil = sTarih.Substring(8, 2)
                        gun = sTarih.Substring(0, 2)
                        ay = sTarih.Substring(3, 2)
                        sFile += yil
                        sFile += ay
                        sFile += gun
                        sFile += ".DAT"
                        Dim sDosya As New FileInfo(sFile)
                        If sDosya.Exists Then
                            sDosya.CopyTo("" & sFile & "YDK", True)
                            AppYazarKasa.firmano = firmano
                            AppYazarKasa.donemno = donemno
                            AppYazarKasa.connection = connection
                            If frm.sec_islem.SelectedIndex = 1 Then
                                posdll.Simenes_satisoku(sFile & "YDK", "Siemens", dr("sDepo"), 0, kullanici, frm.sec_islem.SelectedIndex)
                            ElseIf frm.sec_islem.SelectedIndex = 2 Then
                                posdll.Simenes_satisoku(sFile & "YDK", "Siemens", dr("sDepo"), 0, kullanici, frm.sec_islem.SelectedIndex)
                            ElseIf frm.sec_islem.SelectedIndex > 2 Then
                                posdll.Simenes_satisoku(sFile & "YDK", "Siemens", dr("sDepo"), 0, kullanici, frm.sec_islem.SelectedIndex)
                                'posdll.ciro_INTER(sFile & "YDK", lKasaNo, "inter")
                            End If
                        Else
                            XtraMessageBox.Show(Sorgu_sDil("Hareket Dosyasý Bulunamadý", sDil) & vbCrLf & Sorgu_sDil("Kasa No =", sDil) & lKasaNo & vbCrLf & "Path :" & sFile, Sorgu_sDil("Dikkat", sDil), MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                        End If
                        lKasaNo += 1
                    Next
                    yil = Nothing
                    gun = Nothing
                    ay = Nothing
                    sTarih = Nothing
                    sFile = Nothing
                    lKasaNo = Nothing
                    cmd = Nothing
                    con = Nothing
                    If frm.sec_islem.SelectedIndex = 1 Then
                        Dim fr As New frm_tbPos_Satislar
                        fr.firmano = firmano
                        fr.donemno = donemno
                        fr.connection = connection
                        fr.kullanici = kullanici
                        fr.ShowDialog()
                    ElseIf frm.sec_islem.SelectedIndex = 2 Then
                        If XtraMessageBox.Show(Sorgu_sDil("Yapýlan Satýþlarý Sisteme Aktarmak Ýstediðinize Emin misiniz...?", sDil), Sorgu_sDil("Dikkat", sDil), MessageBoxButtons.YesNo, MessageBoxIcon.Question) = MsgBoxResult.Yes Then
                            entegre()
                        End If
                    ElseIf frm.sec_islem.SelectedIndex > 2 Then
                        Dim fr As New frm_emir_kasa_kasiyer
                        fr.nPosIslem = frm.sec_islem.SelectedIndex
                        fr.DateEdit1.EditValue = dr("dteTarih")
                        fr.DateEdit1.Properties.ReadOnly = True
                        fr.DateEdit2.EditValue = dr("dteTarih")
                        fr.DateEdit2.Properties.ReadOnly = True
                        fr.firmano = firmano
                        fr.donemno = donemno
                        fr.connection = connection
                        fr.kullanici = kullanici
                        fr.pos = True
                        fr.islemstatus = True
                        fr.ShowDialog()
                    End If
                End If
            ElseIf dr("sCihaz") = "SambaPos" Then
                If frm.sec_islem.SelectedIndex = 0 Then
                    If MessageBox.Show("SambaPostan Stok Kayýtlarýný Silmek Ýstediðinize Emin misiniz..?", Sorgu_sDil("Dikkat", sDil), MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
                        Dim cmd As New OleDb.OleDbCommand
                        Dim con As New OleDb.OleDbConnection
                        con.ConnectionString = "Provider=SQLOLEDB.1;Integrated Security=SSPI;Persist Security Info=False;Initial Catalog=SambaData2;" & dr("sFile") & ";Current Language=Türkçe;Application Name=SambaPos"
                        cmd.Connection = con
                        cmd.CommandTimeout = Nothing
                        If con.State = ConnectionState.Closed Then
                            con.Open()
                        End If
                        cmd.CommandText = "SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED Delete from MenuItems Where Id <> 0"
                        cmd.ExecuteNonQuery()
                        con.Close()
                        MessageBox.Show(Sorgu_sDil("Ýþlem Baþarýyla Tamamlandý...", sDil), Sorgu_sDil("Dikkat", sDil), MessageBoxButtons.OK, MessageBoxIcon.Information)
                    End If
                ElseIf frm.sec_islem.SelectedIndex = 1 Then
                    If MessageBox.Show("SambaPostan Müþteri Kayýtlarýný Silmek Ýstediðinize Emin misiniz..?", Sorgu_sDil("Dikkat", sDil), MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
                        Dim cmd As New OleDb.OleDbCommand
                        Dim con As New OleDb.OleDbConnection
                        con.ConnectionString = "Provider=SQLOLEDB.1;Integrated Security=SSPI;Persist Security Info=False;Initial Catalog=SambaData2;" & dr("sFile") & ";Current Language=Türkçe;Application Name=SambaPos"
                        cmd.Connection = con
                        cmd.CommandTimeout = Nothing
                        If con.State = ConnectionState.Closed Then
                            con.Open()
                        End If
                        cmd.CommandText = "SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED Delete from Customers Where Id > 0"
                        cmd.ExecuteNonQuery()
                        con.Close()
                        MessageBox.Show(Sorgu_sDil("Ýþlem Baþarýyla Tamamlandý...", sDil), Sorgu_sDil("Dikkat", sDil), MessageBoxButtons.OK, MessageBoxIcon.Information)
                    End If
                ElseIf frm.sec_islem.SelectedIndex = 2 Then
                    If MessageBox.Show("SambaPostan Menü Kayýtlarýný Silmek Ýstediðinize Emin misiniz..?", Sorgu_sDil("Dikkat", sDil), MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
                        Dim cmd As New OleDb.OleDbCommand
                        Dim con As New OleDb.OleDbConnection
                        con.ConnectionString = "Provider=SQLOLEDB.1;Integrated Security=SSPI;Persist Security Info=False;Initial Catalog=SambaData2;" & dr("sFile") & ";Current Language=Türkçe;Application Name=SambaPos"
                        cmd.Connection = con
                        cmd.CommandTimeout = Nothing
                        If con.State = ConnectionState.Closed Then
                            con.Open()
                        End If
                        cmd.CommandText = "SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED Delete from ScreenMenuItems Where Id > 0"
                        cmd.ExecuteNonQuery()
                        cmd.CommandText = "SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED Delete from ScreenMenuCategories Where Id > 0"
                        cmd.ExecuteNonQuery()
                        con.Close()
                        MessageBox.Show(Sorgu_sDil("Ýþlem Baþarýyla Tamamlandý...", sDil), Sorgu_sDil("Dikkat", sDil), MessageBoxButtons.OK, MessageBoxIcon.Information)
                    End If
                End If
            ElseIf dr("sCihaz") = "NcrPos" Then
                'If frm.sec_islem.SelectedIndex = 0 Then
                '    Dim fm As New frm_tbPos_Stoklar
                '    fm.firmano = firmano
                '    fm.donemno = donemno
                '    fm.connection = connection
                '    fm.kasa = "inter"
                '    fm.sPath = dr("sPath")
                '    fm.sFile = dr("sFile")
                '    fm.Show()
                'Else
                If frm.sec_islem.SelectedIndex > -1 Then
                    Dim con As New OleDb.OleDbConnection
                    Dim cmd As New OleDb.OleDbCommand
                    cmd.Connection = con
                    con.ConnectionString = connection
                    If con.State = ConnectionState.Closed = True Then
                        con.Open()
                    End If
                    cmd.CommandText = "DELETE FROM BTBLINTERSATIS Where sKullanici= '" & kullanici & "'"
                    cmd.ExecuteNonQuery()
                    cmd.CommandText = "TRUNCATE TABLE BTBLINTERCIRO"
                    cmd.ExecuteNonQuery()
                    con.Close()
                    Dim yil As String = ""
                    Dim gun As String = ""
                    Dim ay As String = ""
                    Dim sTarih As String = dr("dteTarih").ToString
                    Dim sFile As String = ""
                    Dim lKasaNo As Integer = dr("lNo")
                    Dim i As Integer = 0
                    For i = dr("lNo") To dr("lSonNo")
                        sFile = dr("sPath") & ":" & dr("sFile") & "." & sayiuzunlukkontrol(i, 3)
                        'yil = sTarih.Substring(8, 2)
                        'gun = sTarih.Substring(0, 2)
                        'ay = sTarih.Substring(3, 2)
                        'sFile += yil
                        'sFile += ay
                        'sFile += gun
                        'sFile += ".TXT"
                        Dim sDosya As New FileInfo(sFile)
                        If sDosya.Exists Then
                            sDosya.CopyTo("" & sFile & "YDK", True)
                            AppYazarKasa.firmano = firmano
                            AppYazarKasa.donemno = donemno
                            AppYazarKasa.connection = connection
                            If frm.sec_islem.SelectedIndex = 0 Then
                                posdll.NCR_satisoku(sFile & "YDK", "NcrPos", dr("sDepo"), 0, kullanici, frm.sec_islem.SelectedIndex, dr("sGramaj"))
                            ElseIf frm.sec_islem.SelectedIndex = 1 Then
                                posdll.NCR_satisoku(sFile & "YDK", "NcrPos", dr("sDepo"), 0, kullanici, frm.sec_islem.SelectedIndex, dr("sGramaj"))
                            ElseIf frm.sec_islem.SelectedIndex > 1 Then
                                posdll.NCR_satisoku(sFile & "YDK", "Ncr", dr("sDepo"), 0, kullanici, frm.sec_islem.SelectedIndex, dr("sGramaj"))
                                'posdll.ciro_INTER(sFile & "YDK", lKasaNo, "inter")
                            End If
                        Else
                            XtraMessageBox.Show(Sorgu_sDil("Hareket Dosyasý Bulunamadý", sDil) & vbCrLf & Sorgu_sDil("Kasa No =", sDil) & lKasaNo & vbCrLf & "Path :" & sFile, Sorgu_sDil("Dikkat", sDil), MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                        End If
                        lKasaNo += 1
                    Next
                    yil = Nothing
                    gun = Nothing
                    ay = Nothing
                    sTarih = Nothing
                    sFile = Nothing
                    lKasaNo = Nothing
                    cmd = Nothing
                    con = Nothing
                    If frm.sec_islem.SelectedIndex = 0 Then
                        Dim fr As New frm_tbPos_Satislar
                        fr.firmano = firmano
                        fr.donemno = donemno
                        fr.connection = connection
                        fr.kullanici = kullanici
                        fr.ShowDialog()
                    ElseIf frm.sec_islem.SelectedIndex = 1 Then
                        If XtraMessageBox.Show(Sorgu_sDil("Yapýlan Satýþlarý Sisteme Aktarmak Ýstediðinize Emin misiniz...?", sDil), Sorgu_sDil("Dikkat", sDil), MessageBoxButtons.YesNo, MessageBoxIcon.Question) = MsgBoxResult.Yes Then
                            entegre()
                        End If
                    ElseIf frm.sec_islem.SelectedIndex > 1 Then
                        Dim fr As New frm_emir_kasa_kasiyer
                        fr.nPosIslem = frm.sec_islem.SelectedIndex
                        fr.DateEdit1.EditValue = dr("dteTarih")
                        fr.DateEdit1.Properties.ReadOnly = True
                        fr.DateEdit2.EditValue = dr("dteTarih")
                        fr.DateEdit2.Properties.ReadOnly = True
                        fr.firmano = firmano
                        fr.donemno = donemno
                        fr.connection = connection
                        fr.kullanici = kullanici
                        fr.pos = True
                        fr.islemstatus = True
                        fr.ShowDialog()
                    End If
                End If
            ElseIf dr("sCihaz") = "InterPos2001" Or dr("sCihaz") = "InterPos2000" Then
                If frm.sec_islem.SelectedIndex = 0 Then
                    Dim fm As New frm_tbPos_Stoklar
                    fm.firmano = firmano
                    fm.donemno = donemno
                    fm.connection = connection
                    fm.kasa = "inter"
                    fm.sPath = dr("sPath")
                    fm.sFile = dr("sFile")
                    fm.Show()
                ElseIf frm.sec_islem.SelectedIndex = 8 Then
                    AppYazarKasa.firmano = firmano
                    AppYazarKasa.donemno = donemno
                    AppYazarKasa.connection = connection
                    posdll.dataset1 = DataSet1
                    posdll.INTER_ciro(2, "inter", dr("lNo"), dr("lSonNo"), dr("sPath"), dr("sFile"), dr("dteTarih"))
                ElseIf frm.sec_islem.SelectedIndex > 0 And frm.sec_islem.SelectedIndex < 8 Then
                    Dim con As New OleDb.OleDbConnection
                    Dim cmd As New OleDb.OleDbCommand
                    cmd.Connection = con
                    con.ConnectionString = connection
                    If con.State = ConnectionState.Closed = True Then
                        con.Open()
                    End If
                    cmd.CommandText = "DELETE FROM BTBLINTERSATIS Where sKullanici= '" & kullanici & "'"
                    cmd.ExecuteNonQuery()
                    cmd.CommandText = "TRUNCATE TABLE BTBLINTERCIRO"
                    cmd.ExecuteNonQuery()
                    con.Close()
                    Dim yil As String = ""
                    Dim gun As String = ""
                    Dim ay As String = ""
                    Dim sTarih As String = dr("dteTarih").ToString
                    Dim sFile As String = ""
                    Dim sFileIp As String = ""
                    Dim lKasaNo As Integer = dr("lNo")
                    Dim i As Integer = 0
                    For i = dr("lNo") To dr("lSonNo")
                        '"" & sPath & ":" & sFile & "\
                        sFile = dr("sPath") & ":" & dr("sFile") & "\POSGENEL\HR"
                        sFileIp = dr("sPath") & ":" & dr("sFile") & "\POSGENEL\IP"
                        yil = sTarih.Substring(8, 2)
                        gun = sTarih.Substring(0, 2)
                        ay = sTarih.Substring(3, 2)
                        sFile += gun
                        sFileIp += gun
                        sFile += ay
                        sFileIp += ay
                        sFile += yil
                        sFileIp += yil
                        sFile += "." & sayiuzunlukkontrol(lKasaNo, 3)
                        sFileIp += "." & sayiuzunlukkontrol(lKasaNo, 3)
                        Dim sDosya As New FileInfo(sFile)
                        Dim sDosyaIP As New FileInfo(sFileIp)
                        If sDosya.Exists Then
                            sDosya.CopyTo("" & sFile & "YDK", True)
                            AppYazarKasa.firmano = firmano
                            AppYazarKasa.donemno = donemno
                            AppYazarKasa.connection = connection
                            If frm.sec_islem.SelectedIndex = 1 Then
                                posdll.intersatisoku(sFile & "YDK", "inter", dr("sDepo"), 0, kullanici, frm.sec_islem.SelectedIndex)
                            ElseIf frm.sec_islem.SelectedIndex = 2 Then
                                posdll.intersatisoku(sFile & "YDK", "inter", dr("sDepo"), 0, kullanici, frm.sec_islem.SelectedIndex)
                            ElseIf frm.sec_islem.SelectedIndex > 2 Then
                                posdll.intersatisoku(sFile & "YDK", "inter", dr("sDepo"), 0, kullanici, frm.sec_islem.SelectedIndex)
                                'posdll.ciro_INTER(sFile & "YDK", lKasaNo, "inter")
                            End If
                        Else
                            XtraMessageBox.Show(Sorgu_sDil("Hareket Dosyasý Bulunamadý", sDil) & vbCrLf & Sorgu_sDil("Kasa No =", sDil) & lKasaNo & vbCrLf & "Path :" & sFile, Sorgu_sDil("Dikkat", sDil), MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                        End If
                        If sDosyaIP.Exists Then
                            sDosyaIP.CopyTo("" & sFileIp & "YDK", True)
                            AppYazarKasa.firmano = firmano
                            AppYazarKasa.donemno = donemno
                            AppYazarKasa.connection = connection
                            If frm.sec_islem.SelectedIndex = 1 Then
                                posdll.intersatisoku(sFileIp & "YDK", "inter", dr("sDepo"), 1, kullanici, frm.sec_islem.SelectedIndex)
                            ElseIf frm.sec_islem.SelectedIndex = 2 Then
                                posdll.intersatisoku(sFileIp & "YDK", "inter", dr("sDepo"), 1, kullanici, frm.sec_islem.SelectedIndex)
                            ElseIf frm.sec_islem.SelectedIndex > 2 Then
                                posdll.intersatisoku(sFileIp & "YDK", "inter", dr("sDepo"), 1, kullanici, frm.sec_islem.SelectedIndex)
                            End If
                        End If
                        lKasaNo += 1
                    Next
                    'yil = Nothing
                    'gun = Nothing
                    'ay = Nothing
                    'sTarih = Nothing
                    'sFile = Nothing
                    'lKasaNo = Nothing
                    cmd = Nothing
                    con = Nothing
                    If frm.sec_islem.SelectedIndex = 1 Then
                        Dim fr As New frm_tbPos_Satislar
                        fr.firmano = firmano
                        fr.donemno = donemno
                        fr.connection = connection
                        fr.kullanici = kullanici
                        fr.ShowDialog()
                    ElseIf frm.sec_islem.SelectedIndex = 2 Then
                        If XtraMessageBox.Show(Sorgu_sDil("Yapýlan Satýþlarý Sisteme Aktarmak Ýstediðinize Emin misiniz...?", sDil), Sorgu_sDil("Dikkat", sDil), MessageBoxButtons.YesNo, MessageBoxIcon.Question) = MsgBoxResult.Yes Then
                            entegre()
                            lKasaNo = dr("lNo")
                            i = 0
                            For i = dr("lNo") To dr("lSonNo")
                                sFile = dr("sPath") & ":" & dr("sFile") & "\POSGENEL\HR"
                                sFileIp = dr("sPath") & ":" & dr("sFile") & "\POSGENEL\IP"
                                yil = sTarih.Substring(8, 2)
                                gun = sTarih.Substring(0, 2)
                                ay = sTarih.Substring(3, 2)
                                sFile += gun
                                sFileIp += gun
                                sFile += ay
                                sFileIp += ay
                                sFile += yil
                                sFileIp += yil
                                sFile += "." & sayiuzunlukkontrol(lKasaNo, 3)
                                sFileIp += "." & sayiuzunlukkontrol(lKasaNo, 3)
                                Dim sDosya As New FileInfo(sFile)
                                Dim sDosyaIP As New FileInfo(sFileIp)
                                If sDosya.Exists = True Then
                                    sDosya.CopyTo("" & sFile & "ENT", True)
                                    sDosya.Delete()
                                End If
                                If sDosyaIP.Exists = True Then
                                    sDosyaIP.CopyTo("" & sFileIp & "ENT", True)
                                    sDosyaIP.Delete()
                                End If
                                sDosya = Nothing
                                sDosyaIP = Nothing
                                lKasaNo += 1
                            Next
                        End If
                    ElseIf frm.sec_islem.SelectedIndex > 2 Then
                        Dim fr As New frm_emir_kasa_kasiyer
                        fr.nPosIslem = frm.sec_islem.SelectedIndex
                        fr.DateEdit1.EditValue = dr("dteTarih")
                        fr.DateEdit1.Properties.ReadOnly = True
                        fr.DateEdit2.EditValue = dr("dteTarih")
                        fr.DateEdit2.Properties.ReadOnly = True
                        fr.firmano = firmano
                        fr.donemno = donemno
                        fr.connection = connection
                        fr.kullanici = kullanici
                        fr.pos = True
                        fr.islemstatus = True
                        fr.ShowDialog()
                    End If
                End If
            ElseIf dr("sCihaz") = "EscortPos4000" Then
                If frm.sec_islem.SelectedIndex = 0 Then
                    Dim fm As New frm_tbPos_Stoklar
                    fm.firmano = firmano
                    fm.donemno = donemno
                    fm.connection = connection
                    fm.kasa = "escort"
                    fm.sPath = dr("sPath")
                    fm.sFile = dr("sFile")
                    fm.Show()
                ElseIf frm.sec_islem.SelectedIndex = 8 Then
                    AppYazarKasa.firmano = firmano
                    AppYazarKasa.donemno = donemno
                    AppYazarKasa.connection = connection
                    posdll.dataset1 = DataSet1
                    posdll.INTER_ciro(2, "escort", dr("lNo"), dr("lSonNo"), dr("sPath"), dr("sFile"), dr("dteTarih"))
                ElseIf frm.sec_islem.SelectedIndex > 0 Then
                    Dim con As New OleDb.OleDbConnection
                    Dim cmd As New OleDb.OleDbCommand
                    cmd.Connection = con
                    con.ConnectionString = connection
                    If con.State = ConnectionState.Closed = True Then
                        con.Open()
                    End If
                    cmd.CommandText = "DELETE FROM BTBLINTERSATIS Where sKullanici= '" & kullanici & "'"
                    cmd.ExecuteNonQuery()
                    cmd.CommandText = "TRUNCATE TABLE BTBLINTERCIRO"
                    cmd.ExecuteNonQuery()
                    con.Close()
                    Dim yil As String = ""
                    Dim gun As String = ""
                    Dim ay As String = ""
                    Dim sTarih As String = dr("dteTarih").ToString
                    Dim sFile As String = ""
                    Dim sFileIp As String = ""
                    Dim sFileFt As String = ""
                    Dim lKasaNo As Integer = dr("lNo")
                    Dim i As Integer = 0
                    For i = dr("lNo") To dr("lSonNo")
                        sFile = dr("sPath") & ":\POSGENEL\HR"
                        sFileIp = dr("sPath") & ":\POSGENEL\HI"
                        sFileFt = dr("sPath") & ":\POSGENEL\HD"
                        yil = sTarih.Substring(8, 2)
                        gun = sTarih.Substring(0, 2)
                        ay = sTarih.Substring(3, 2)
                        sFile += gun
                        sFileIp += gun
                        sFileFt += gun
                        sFile += ay
                        sFileIp += ay
                        sFileFt += ay
                        sFile += yil
                        sFileIp += yil
                        sFileFt += yil
                        sFile += "." & sayiuzunlukkontrol(lKasaNo, 3)
                        sFileIp += "." & sayiuzunlukkontrol(lKasaNo, 3)
                        sFileFt += "." & sayiuzunlukkontrol(lKasaNo, 3)
                        Dim sDosya As New FileInfo(sFile)
                        Dim sDosyaIP As New FileInfo(sFileIp)
                        Dim sDosyaFt As New FileInfo(sFileFt)
                        If sDosya.Exists Then
                            sDosya.CopyTo("" & sFile & "YDK", True)
                            AppYazarKasa.firmano = firmano
                            AppYazarKasa.donemno = donemno
                            AppYazarKasa.connection = connection
                            If frm.sec_islem.SelectedIndex = 1 Then
                                posdll.intersatisoku(sFile & "YDK", "escort", dr("sDepo"), 0, kullanici, frm.sec_islem.SelectedIndex)
                            ElseIf frm.sec_islem.SelectedIndex = 2 Then
                                posdll.intersatisoku(sFile & "YDK", "escort", dr("sDepo"), 0, kullanici, frm.sec_islem.SelectedIndex)
                            ElseIf frm.sec_islem.SelectedIndex > 2 Then
                                posdll.intersatisoku(sFile & "YDK", "escort", dr("sDepo"), 0, kullanici, frm.sec_islem.SelectedIndex)
                                'posdll.ciro_INTER(sFile & "YDK", lKasaNo, "inter")
                            End If
                        Else
                            XtraMessageBox.Show(Sorgu_sDil("Hareket Dosyasý Bulunamadý", sDil) & vbCrLf & Sorgu_sDil("Kasa No =", sDil) & lKasaNo & vbCrLf & "Path :" & sFile, Sorgu_sDil("Dikkat", sDil), MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                        End If
                        If sDosyaIP.Exists Then
                            sDosyaIP.CopyTo("" & sFileIp & "YDK", True)
                            AppYazarKasa.firmano = firmano
                            AppYazarKasa.donemno = donemno
                            AppYazarKasa.connection = connection
                            If frm.sec_islem.SelectedIndex = 1 Then
                                posdll.intersatisoku(sFileIp & "YDK", "escort", dr("sDepo"), 1, kullanici, frm.sec_islem.SelectedIndex)
                            ElseIf frm.sec_islem.SelectedIndex = 2 Then
                                posdll.intersatisoku(sFileIp & "YDK", "escort", dr("sDepo"), 1, kullanici, frm.sec_islem.SelectedIndex)
                            ElseIf frm.sec_islem.SelectedIndex > 2 Then
                                posdll.intersatisoku(sFileIp & "YDK", "escort", dr("sDepo"), 1, kullanici, frm.sec_islem.SelectedIndex)
                            End If
                        End If
                        If sDosyaFt.Exists Then
                            sDosyaFt.CopyTo("" & sFileFt & "YDK", True)
                            AppYazarKasa.firmano = firmano
                            AppYazarKasa.donemno = donemno
                            AppYazarKasa.connection = connection
                            If frm.sec_islem.SelectedIndex = 1 Then
                                posdll.intersatisoku(sFileFt & "YDK", "escort", dr("sDepo"), 1, kullanici, frm.sec_islem.SelectedIndex)
                            ElseIf frm.sec_islem.SelectedIndex = 2 Then
                                posdll.intersatisoku(sFileFt & "YDK", "escort", dr("sDepo"), 1, kullanici, frm.sec_islem.SelectedIndex)
                            ElseIf frm.sec_islem.SelectedIndex > 2 Then
                                posdll.intersatisoku(sFileFt & "YDK", "escort", dr("sDepo"), 1, kullanici, frm.sec_islem.SelectedIndex)
                            End If
                        End If
                        lKasaNo += 1
                    Next
                    'yil = Nothing
                    'gun = Nothing
                    'ay = Nothing
                    'sTarih = Nothing
                    ''sFile = Nothing
                    ''lKasaNo = Nothing
                    cmd = Nothing
                    con = Nothing
                    If frm.sec_islem.SelectedIndex = 1 Then
                        Dim fr As New frm_tbPos_Satislar
                        fr.firmano = firmano
                        fr.donemno = donemno
                        fr.connection = connection
                        fr.kullanici = kullanici
                        fr.ShowDialog()
                    ElseIf frm.sec_islem.SelectedIndex = 2 Then
                        If XtraMessageBox.Show(Sorgu_sDil("Yapýlan Satýþlarý Sisteme Aktarmak Ýstediðinize Emin misiniz...?", sDil), Sorgu_sDil("Dikkat", sDil), MessageBoxButtons.YesNo, MessageBoxIcon.Question) = MsgBoxResult.Yes Then
                            entegre("Escort")
                            lKasaNo = dr("lNo")
                            i = 0
                            For i = dr("lNo") To dr("lSonNo")
                                sFile = dr("sPath") & ":\POSGENEL\HR"
                                sFileIp = dr("sPath") & ":\POSGENEL\HI"
                                sFileFt = dr("sPath") & ":\POSGENEL\HD"
                                yil = sTarih.Substring(8, 2)
                                gun = sTarih.Substring(0, 2)
                                ay = sTarih.Substring(3, 2)
                                sFile += gun
                                sFileIp += gun
                                sFileFt += gun
                                sFile += ay
                                sFileIp += ay
                                sFileFt += ay
                                sFile += yil
                                sFileIp += yil
                                sFileFt += yil
                                sFile += "." & sayiuzunlukkontrol(lKasaNo, 3)
                                sFileIp += "." & sayiuzunlukkontrol(lKasaNo, 3)
                                sFileFt += "." & sayiuzunlukkontrol(lKasaNo, 3)
                                Dim sDosya As New FileInfo(sFile)
                                Dim sDosyaIP As New FileInfo(sFileIp)
                                Dim sDosyaFt As New FileInfo(sFileFt)
                                If sDosya.Exists = True Then
                                    sDosya.CopyTo("" & sFile & "ENT", True)
                                    sDosya.Delete()
                                End If
                                If sDosyaIP.Exists = True Then
                                    sDosyaIP.CopyTo("" & sFileIp & "ENT", True)
                                    sDosyaIP.Delete()
                                End If
                                If sDosyaFt.Exists = True Then
                                    sDosyaFt.CopyTo("" & sFileFt & "ENT", True)
                                    sDosyaFt.Delete()
                                End If
                                sDosya = Nothing
                                sDosyaIP = Nothing
                                sDosyaFt = Nothing
                                lKasaNo += 1
                            Next
                        End If
                    ElseIf frm.sec_islem.SelectedIndex > 2 Then
                        Dim fr As New frm_emir_kasa_kasiyer
                        fr.nPosIslem = frm.sec_islem.SelectedIndex
                        fr.DateEdit1.EditValue = dr("dteTarih")
                        fr.DateEdit1.Properties.ReadOnly = True
                        fr.DateEdit2.EditValue = dr("dteTarih")
                        fr.DateEdit2.Properties.ReadOnly = True
                        fr.firmano = firmano
                        fr.donemno = donemno
                        fr.connection = connection
                        fr.kullanici = kullanici
                        fr.pos = True
                        fr.islemstatus = True
                        fr.ShowDialog()
                    End If
                End If
            End If
        End If
    End Sub
    Private Sub entegre(Optional ByVal sKasa As String = "")
        Dim dlg As New WaitDlgFrm("Fisler Okunuyor...")
        ds_Entegrasyon = sorgu(sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT Satis.nStokID,Satis.sSaticiRumuzu,Satis.lNetTutar, Satis.sKasiyerRumuzu, Stok.nStokNo, Stok.lMaliyet, Satis.nGirisCikis, SUM(Satis.lMiktar) AS lMiktar, SUM(Satis.lBrutTutar) AS lBrutTutar, SUM(Satis.lTutar) AS lTutar, SUM(Satis.lIskontoTutari) AS lIskontoTutari, SUM(Satis.nIskontoYuzdesi) AS nIskontoYuzdesi, Satis.bKapali, 0 AS nMusteriID, Satis.sKasaNo as nKasaNo,Satis.sMagazaKodu, Satis.dteFisTarihi, lFisNo, (SELECT ISNULL(SUM(c.lNetTutar) , 0) AS lNetTutar1 FROM BTBLINTERSATIS c LEFT OUTER JOIN (SELECT nAlisVerisID , sFisTipi , lFisNo , dteKayitTarihi , nMusteriID , bKapali , sKullanici FROM BTBLINTERSATIS WHERE nGirisCikis = 11 AND sKullanici = '" & kullanici & "') d ON c.nAlisVerisID = d.nAlisVerisID AND c.sFisTipi = d.sFisTipi AND c.lFisNo = d.lFisNo AND c.dteKayitTarihi = d.dteKayitTarihi AND c.sKullanici = d.sKullanici WHERE (d.bKapali = Satis.bKapali) AND c.sFisTipi = Satis.sFisTipi AND c.dteFisTarihi = Satis.dteFisTarihi AND nGirisCikis = 8 AND c.sKullanici = Satis.sKullanici AND c.sKasaNo = Satis.sKasaNo) AS lNetTutar1, (SELECT ISNULL(SUM(lIskontoTutari) , 0) FROM BTBLINTERSATIS WHERE sFisTipi = Satis.sFisTipi AND dteFisTarihi = Satis.dteFisTarihi AND nGirisCikis = 6 AND sKullanici = Satis.sKullanici AND sKasaNo = Satis.sKasaNo) AS lToplamIskonto, tbKdv.nKdvOrani, SUM(Satis.lTutar - Satis.lTutar / ((100 + tbKdv.nKdvOrani) / 100)) AS lKdvTutari, Satis.sOdemeKodu, SUM(Satis.lOdemeTutar) AS lOdemeTutar, Satis.sKullanici, (SELECT     ISNULL(sAdi,'') FROM          tbMusteri WHERE      CAST(lKodu AS NVARCHAR(20)) = Satis.nMusteriID) AS sAdi FROM BTBLINTERSATIS Satis LEFT OUTER JOIN tbKdv ON Satis.sKdvTipi = tbKdv.sKdvTipi LEFT OUTER JOIN (SELECT RIGHT (nStokID , 6) AS nStokID , nStokID AS nStokNo , sKodu , sModel , sAciklama , (SELECT ISNULL(lFiyat , 0) FROM tbStokFiyati WHERE sFiyatTipi = '" & sFiyatM & "' AND nStokID = tbStok.nStokID) AS lMaliyet FROM tbStok) Stok ON Satis.nStokID = Stok.nStokID WHERE (Satis.nGirisCikis NOT IN (6, 8, 11, 30)) AND (Satis.sKullanici = '" & kullanici & "') AND (Satis.nStatus = 0) AND (Satis.sFisTipi = 'P') AND (Satis.bKapali = 1) GROUP BY Satis.nGirisCikis, Satis.sKullanici, Satis.nStokID,Satis.sSaticiRumuzu,Satis.lNetTutar, Stok.nStokNo, Stok.lMaliyet, tbKdv.nKdvOrani, Satis.nMusteriID, Satis.bKapali, Satis.sFisTipi, Satis.sMagazaKodu, Satis.dteFisTarihi, Satis.sOdemeKodu, Satis.sKasaNo, Satis.sKasiyerRumuzu, lFisNo ORDER BY Satis.sKasaNo,Satis.lFisNo,Satis.nGirisCikis"))
        entegre_olustur("P", sKasa)
        dlg.Close()
        Dim dlg1 As New WaitDlgFrm("Acik Fisler Okunuyor...")
        ds_Entegrasyon = sorgu(sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT Satis.nStokID,Satis.sSaticiRumuzu, Stok.nStokNo, Stok.lMaliyet, Satis.nGirisCikis, SUM(Satis.lMiktar) AS lMiktar, SUM(Satis.lBrutTutar) AS lBrutTutar, SUM(Satis.lTutar) AS lTutar, SUM(Satis.lIskontoTutari) AS lIskontoTutari, Satis.bKapali, Satis.nMusteriID, Satis.sFisTipi, Satis.sKasaNo as nKasaNo,Satis.sMagazaKodu, Satis.dteFisTarihi, Satis.lFisNo, (SELECT ISNULL(SUM(c.lNetTutar) , 0) AS lNetTutar FROM BTBLINTERSATIS c LEFT OUTER JOIN (SELECT nAlisVerisID , sFisTipi , lFisNo , dteKayitTarihi , nMusteriID , bKapali , sKullanici FROM BTBLINTERSATIS WHERE nGirisCikis = 11 AND sKullanici = '" & kullanici & "') d ON c.nAlisVerisID = d.nAlisVerisID AND c.sFisTipi = d.sFisTipi AND c.lFisNo = d.lFisNo AND c.dteKayitTarihi = d.dteKayitTarihi AND c.sKullanici = d.sKullanici WHERE (d.bKapali = Satis.bKapali) AND c.sFisTipi = Satis.sFisTipi AND c.dteFisTarihi = Satis.dteFisTarihi AND nGirisCikis = 8 AND c.sKullanici = Satis.sKullanici AND c.sKasaNo = Satis.sKasaNo AND c.lFisNo = Satis.lFisNo) AS lNetTutar, (SELECT ISNULL(SUM(lIskontoTutari) , 0) FROM BTBLINTERSATIS WHERE sFisTipi = Satis.sFisTipi AND dteFisTarihi = Satis.dteFisTarihi AND nGirisCikis = 6 AND sKullanici = Satis.sKullanici AND sKasaNo = Satis.sKasaNo) AS lToplamIskonto, tbKdv.nKdvOrani, SUM(Satis.lTutar - Satis.lTutar / ((100 + tbKdv.nKdvOrani) / 100)) AS lKdvTutari, Satis.sOdemeKodu, SUM(Satis.lOdemeTutar) AS lOdemeTutar, Satis.sKullanici, (SELECT     ISNULL(sAdi,'') FROM          tbMusteri WHERE      CAST(lKodu AS NVARCHAR(20)) = Satis.nMusteriID) AS sAdi FROM BTBLINTERSATIS Satis LEFT OUTER JOIN tbKdv ON Satis.sKdvTipi = tbKdv.sKdvTipi LEFT OUTER JOIN (SELECT RIGHT (nStokID , 6) AS nStokID , nStokID AS nStokNo , sKodu , sModel , sAciklama , (SELECT ISNULL(lFiyat , 0) FROM tbStokFiyati WHERE sFiyatTipi = '" & sFiyatM & "' AND nStokID = tbStok.nStokID) AS lMaliyet FROM tbStok) Stok ON Satis.nStokID = Stok.nStokID WHERE (Satis.nGirisCikis NOT IN (6, 8, 11, 30)) AND (Satis.sKullanici = '" & kullanici & "') AND (Satis.nStatus = 0) AND (Satis.sFisTipi = 'P') AND (Satis.bKapali = 0) GROUP BY Satis.sKullanici, Satis.nStokID,Satis.sSaticiRumuzu, Stok.nStokNo, Stok.lMaliyet, Satis.nGirisCikis, tbKdv.nKdvOrani, Satis.nMusteriID, Satis.bKapali, Satis.sFisTipi, Satis.sKasaNo,Satis.sMagazaKodu, Satis.dteFisTarihi, Satis.lFisNo,Satis.sOdemeKodu, Satis.sKasaNo ORDER BY Satis.sKasaNo,Satis.nMusteriID,Satis.lFisNo,Satis.nGirisCikis "))
        entegre_olustur("K", sKasa)
        dlg1.Close()
        Dim dlg2 As New WaitDlgFrm("Faturalar Okunuyor...")
        ds_Entegrasyon = sorgu(sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT Satis.nStokID,Satis.sSaticiRumuzu, Stok.nStokNo, Stok.lMaliyet, Satis.nGirisCikis, SUM(Satis.lMiktar) AS lMiktar, SUM(Satis.lBrutTutar) AS lBrutTutar, SUM(Satis.lTutar) AS lTutar, SUM(Satis.lIskontoTutari) AS lIskontoTutari, Satis.bKapali, Satis.nMusteriID, Satis.sFisTipi, Satis.sKasaNo as nKasaNo,Satis.sMagazaKodu, Satis.dteFisTarihi, Satis.lFisNo, (SELECT ISNULL(SUM(c.lNetTutar) , 0) AS lNetTutar FROM BTBLINTERSATIS c LEFT OUTER JOIN (SELECT nAlisVerisID , sFisTipi , lFisNo , dteKayitTarihi , nMusteriID , bKapali , sKullanici FROM BTBLINTERSATIS WHERE nGirisCikis = 11 AND sKullanici = '" & kullanici & "') d ON c.nAlisVerisID = d.nAlisVerisID AND c.sFisTipi = d.sFisTipi AND c.lFisNo = d.lFisNo AND c.dteKayitTarihi = d.dteKayitTarihi AND c.sKullanici = d.sKullanici WHERE (d.bKapali = Satis.bKapali) AND c.sFisTipi = Satis.sFisTipi AND c.dteFisTarihi = Satis.dteFisTarihi AND nGirisCikis = 8 AND c.sKullanici = Satis.sKullanici AND c.sKasaNo = Satis.sKasaNo AND c.lFisNo = Satis.lFisNo) AS lNetTutar, (SELECT ISNULL(SUM(lIskontoTutari) , 0) FROM BTBLINTERSATIS WHERE sFisTipi = Satis.sFisTipi AND dteFisTarihi = Satis.dteFisTarihi AND nGirisCikis = 6 AND sKullanici = Satis.sKullanici AND sKasaNo = Satis.sKasaNo) AS lToplamIskonto, tbKdv.nKdvOrani, SUM(Satis.lTutar - Satis.lTutar / ((100 + tbKdv.nKdvOrani) / 100)) AS lKdvTutari, Satis.sOdemeKodu, SUM(Satis.lOdemeTutar) AS lOdemeTutar, Satis.sKullanici, (SELECT     ISNULL(sAdi,'') FROM          tbMusteri WHERE      CAST(lKodu AS NVARCHAR(20)) = Satis.nMusteriID) AS sAdi FROM BTBLINTERSATIS Satis LEFT OUTER JOIN tbKdv ON Satis.sKdvTipi = tbKdv.sKdvTipi LEFT OUTER JOIN (SELECT RIGHT (nStokID , 6) AS nStokID , nStokID AS nStokNo , sKodu , sModel , sAciklama , (SELECT ISNULL(lFiyat , 0) FROM tbStokFiyati WHERE sFiyatTipi = '" & sFiyatM & "' AND nStokID = tbStok.nStokID) AS lMaliyet FROM tbStok) Stok ON Satis.nStokID = Stok.nStokID WHERE (Satis.nGirisCikis NOT IN (6, 8, 11, 30)) AND (Satis.sKullanici = '" & kullanici & "') AND (Satis.nStatus = 0) AND (Satis.sFisTipi = 'K') AND (Satis.bKapali = 1) GROUP BY Satis.sKullanici, Satis.nStokID,Satis.sSaticiRumuzu, Stok.nStokNo, Stok.lMaliyet, Satis.nGirisCikis, tbKdv.nKdvOrani, Satis.nMusteriID, Satis.bKapali, Satis.sFisTipi, Satis.sKasaNo,Satis.sMagazaKodu, Satis.dteFisTarihi, Satis.lFisNo,Satis.sOdemeKodu, Satis.sKasaNo ORDER BY Satis.sKasaNo,Satis.nMusteriID,Satis.lFisNo,Satis.nGirisCikis"))
        entegre_olustur("K", sKasa)
        dlg2.Close()
        Dim dlg3 As New WaitDlgFrm("Acik Faturalar Okunuyor...")
        ds_Entegrasyon = sorgu(sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT Satis.nStokID,Satis.sSaticiRumuzu, Stok.nStokNo, Stok.lMaliyet, Satis.nGirisCikis, SUM(Satis.lMiktar) AS lMiktar, SUM(Satis.lBrutTutar) AS lBrutTutar, SUM(Satis.lTutar) AS lTutar, SUM(Satis.lIskontoTutari) AS lIskontoTutari, Satis.bKapali, Satis.nMusteriID, Satis.sFisTipi, Satis.sKasaNo as nKasaNo,Satis.sMagazaKodu, Satis.dteFisTarihi, Satis.lFisNo, (SELECT ISNULL(SUM(c.lNetTutar) , 0) AS lNetTutar FROM BTBLINTERSATIS c LEFT OUTER JOIN (SELECT nAlisVerisID , sFisTipi , lFisNo , dteKayitTarihi , nMusteriID , bKapali , sKullanici FROM BTBLINTERSATIS WHERE nGirisCikis = 11 AND sKullanici = '" & kullanici & "') d ON c.nAlisVerisID = d.nAlisVerisID AND c.sFisTipi = d.sFisTipi AND c.lFisNo = d.lFisNo AND c.dteKayitTarihi = d.dteKayitTarihi AND c.sKullanici = d.sKullanici WHERE (d.bKapali = Satis.bKapali) AND c.sFisTipi = Satis.sFisTipi AND c.dteFisTarihi = Satis.dteFisTarihi AND nGirisCikis = 8 AND c.sKullanici = Satis.sKullanici AND c.sKasaNo = Satis.sKasaNo AND c.lFisNo = Satis.lFisNo) AS lNetTutar, (SELECT ISNULL(SUM(lIskontoTutari) , 0) FROM BTBLINTERSATIS WHERE sFisTipi = Satis.sFisTipi AND dteFisTarihi = Satis.dteFisTarihi AND nGirisCikis = 6 AND sKullanici = Satis.sKullanici AND sKasaNo = Satis.sKasaNo) AS lToplamIskonto, tbKdv.nKdvOrani, SUM(Satis.lTutar - Satis.lTutar / ((100 + tbKdv.nKdvOrani) / 100)) AS lKdvTutari, Satis.sOdemeKodu, SUM(Satis.lOdemeTutar) AS lOdemeTutar, Satis.sKullanici, (SELECT     ISNULL(sAdi,'') FROM          tbMusteri WHERE      CAST(lKodu AS NVARCHAR(20)) = Satis.nMusteriID) AS sAdi FROM BTBLINTERSATIS Satis LEFT OUTER JOIN tbKdv ON Satis.sKdvTipi = tbKdv.sKdvTipi LEFT OUTER JOIN (SELECT RIGHT (nStokID , 6) AS nStokID , nStokID AS nStokNo , sKodu , sModel , sAciklama , (SELECT ISNULL(lFiyat , 0) FROM tbStokFiyati WHERE sFiyatTipi = '" & sFiyatM & "' AND nStokID = tbStok.nStokID) AS lMaliyet FROM tbStok) Stok ON Satis.nStokID = Stok.nStokID WHERE (Satis.nGirisCikis NOT IN (6, 8, 11, 30)) AND (Satis.sKullanici = '" & kullanici & "') AND (Satis.nStatus = 0) AND (Satis.sFisTipi = 'K') AND (Satis.bKapali = 0) GROUP BY Satis.sKullanici, Satis.nStokID,Satis.sSaticiRumuzu, Stok.nStokNo, Stok.lMaliyet, Satis.nGirisCikis, tbKdv.nKdvOrani, Satis.nMusteriID, Satis.bKapali, Satis.sFisTipi, Satis.sKasaNo,Satis.sMagazaKodu, Satis.dteFisTarihi, Satis.lFisNo,Satis.sOdemeKodu, Satis.sKasaNo ORDER BY Satis.sKasaNo,Satis.nMusteriID,Satis.lFisNo,Satis.nGirisCikis"))
        entegre_olustur("K", sKasa)
        dlg3.Close()
        XtraMessageBox.Show(Sorgu_sDil("Entegrasyon Baþarýyla Tamamlandý", sDil), Sorgu_sDil("Dikkat", sDil), MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub
    Private Sub entegre_olustur(ByVal sFisTipi As String, Optional ByVal sKasa As String = "")
        Dim nAlisVerisID As String = ""
        Dim satir = ""
        Dim lFaturaNo = ""
        Dim lMakbuzNo = 0
        Dim dteFisTarihi As DateTime
        Dim dteKayitTarihi As DateTime
        Dim sHareketTipi = ""
        Dim sMagaza = ""
        Dim sKasiyerRumuzu = "VC"
        Dim sSaticiRumuzu As String = ""

        Dim nKasaNo = 1
        Dim sAdi = ""
        Dim sSoyadi = ""
        Dim nIslemID As Int64 = 0
        Dim nTaksitID As String = 0
        Dim nOdemeId As String = 0
        Dim nMusteriID = 0
        Dim nStokID = 0
        Dim nKayit = 0
        Dim nKayitSayisi As Integer = 0
        Dim lNetTutar As Decimal = 0
        Dim lMiktar As Decimal = 0
        Dim lToplamIskonto As Decimal = 0
        Dim nIskontoYuzdesi As Decimal = 0
        Dim lIskontoTutari As Decimal = 0
        Dim lCikisFiyat As Decimal = 0
        Dim lBrutFiyat As Decimal = 0
        Dim lCikisTutar As Decimal = 0
        Dim lBrutTutar As Decimal = 0
        Dim nKdvOrani As Decimal = 0
        Dim nGirisCikis As Integer = 3
        Dim lMaliyet As Decimal = 0
        Dim lToplamMiktar As Decimal
        Dim lMalbedeli As Decimal
        Dim lMalIskontoTutari As Decimal
        Dim nDipIskontoYuzdesi As Decimal
        Dim lDipIskontoTutari As Decimal = 0
        Dim lPesinat As Decimal
        Dim sSinifKodu1 As String = ""
        Dim sSinifKodu2 As String = ""
        Dim sSinifKodu3 As String = ""
        Dim sSinifKodu4 As String = ""
        Dim sSinifKodu5 As String = ""
        Dim IndirimliFiyat As Decimal = "0.00"
        Dim IndirimliTutar As Decimal = "0.00"
        Dim lMalIskontoTutariT As Decimal = 0
        Dim dr As DataRow
        Dim nOdemeKodu As Integer = 1
        bar.Position = 0
        bar.Properties.Maximum = ds_Entegrasyon.Tables(0).Rows.Count
        bar.Visible = True
        For Each dr In ds_Entegrasyon.Tables(0).Rows
            If satir <> dr("lFisNo").ToString Then
                If bar.Position > 0 Then
                    entegre_toplamhesapla(nAlisVerisID, sFisTipi, sMagaza, lToplamMiktar, lMalbedeli, lMalIskontoTutari, lToplamIskonto, lDipIskontoTutari, lPesinat, lNetTutar)
                End If
                satir = dr("lFisNo").ToString
                nAlisVerisID = ""
                lNetTutar = 0
                lToplamMiktar = 0
                lMalbedeli = 0
                lMalIskontoTutari = "0.00"
                nDipIskontoYuzdesi = 0
                lDipIskontoTutari = 0
                sAdi = Microsoft.VisualBasic.Left(sorgu_telefon(dr("sAdi"), ""), 60)
                sSoyadi = ""
                lNetTutar = dr("lOdemeTutar")
                lPesinat = dr("lOdemeTutar")
                lMalIskontoTutari = dr("lIskontoTutari")
                'lDipIskontoTutari = dr("nIskontoYuzdesi")
                lDipIskontoTutari = 0
                'lMalIskontoTutariT = lMalIskontoTutariT + dr("lMalIskontoTutariT")
                'lMalIskontoTutari = lMalIskontoTutariT
                'lDipIskontoTutari = lDipIskontoTutari + lMalIskontoTutari
                'If lDipIskontoTutari > 0 Then
                '    nIskontoYuzdesi = (lMalbedeli - lMalIskontoTutari) * (nDipIskontoYuzdesi / 100)
                'Else
                '    nIskontoYuzdesi = 0
                'End If
                lCikisFiyat = lCikisFiyat
                lCikisTutar = lCikisFiyat * lMiktar
                If nMusteriID.ToString = "" Then
                    nMusteriID = "0"
                End If
                Try
                    nKayit = sorgu_musteri_kontrol(Microsoft.VisualBasic.Left(dr("nMusteriID").ToString, 20))
                Catch ex As Exception
                    nKayit = sorgu_musteri_kontrol(0)
                End Try
                'nKayitSayisi = sorgula_nStokID("SELECT     COUNT(nAlisverisID) AS nKayit FROM         tbAlisVeris WHERE     (sFisTipi = '" & sFisTipi & "') AND (dteFaturaTarihi = '" & dteFisTarihi & "') AND (nMusteriID = " & nMusteriID & " ) AND (lFaturaNo = " & lFaturaNo & ") AND (nGirisCikis = " & dr("nGirisCikis") & ") and (sMagaza = '" & sMagaza & "') and nKasaNo = '" & nKasaNo & "' ")
                'If nKayitSayisi = 0 Then
                '    nAlisVerisID = sorgula_String("SELECT     nAlisVerisID AS nKayit FROM         tbAlisVeris WHERE     (sFisTipi = '" & sFisTipi & "') AND (dteFaturaTarihi = '" & dr("dteFisTarihi") & "') AND (nMusteriID = " & nMusteriID & " ) AND (lFaturaNo = " & lFaturaNo & ") AND (nGirisCikis = " & dr("nGirisCikis") & ") and (sMagaza = '" & sMagaza & "') and nKasaNo = " & nKasaNo & " ")
                '    tbAlisVeris_kaydet_sil_sistem(nAlisVerisID)
                '    nKayit = 0
                'End If
                If Trim(dr("sOdemeKodu").ToString) = "N" Then
                    nOdemeKodu = 1
                Else
                    nOdemeKodu = 1
                End If
                If nKayit <> -1 Then
                    nMusteriID = nKayit
                    If nAlisVerisID = "" Then
                        sMagaza = dr("sMagazaKodu")
                        nAlisVerisID = sorgu_nAlisVerisID(sMagaza)
                        dteFisTarihi = dr("dteFisTarihi")
                        If Trim(sFisTipi) = "K" Then
                            lFaturaNo = dr("lFisNo")
                        Else
                            Try
                                lFaturaNo = sorgu_lFaturaNo(sMagaza, sFisTipi)
                            Catch ex As Exception
                                lFaturaNo = dteFisTarihi.Day
                            End Try
                            lFaturaNo = sorgu_lFaturaNo(sMagaza, sFisTipi)
                        End If
                        nKasaNo = CType(dr("nKasaNo"), Int64)
                        ' nKasaNo = dr("nKasaNo")
                        sHareketTipi = ""
                        dteKayitTarihi = Now
                        sKasiyerRumuzu = dr("sKasiyerRumuzu")

                        Try
                            tbAlisVeris_kaydet_yeni(sMagaza & nAlisVerisID.ToString, sFisTipi, dteFisTarihi, 3, lFaturaNo, nMusteriID, sMagaza, sKasiyerRumuzu, sAdi, sSoyadi, 1, lMalbedeli, lMalIskontoTutari, 0, lToplamIskonto, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, lPesinat, 0, 0, 0, 0, 0, nOdemeKodu, lPesinat, sHareketTipi, 0, nKasaNo, kullanici, Now, "")
                        Catch ex As Exception
                            lFaturaNo = sorgu_lFaturaNo(sMagaza, Trim(sFisTipi))
                            tbAlisVeris_kaydet_yeni(sMagaza & nAlisVerisID.ToString, sFisTipi, dteFisTarihi, 3, lFaturaNo, nMusteriID, sMagaza, sKasiyerRumuzu, sAdi, sSoyadi, 1, lMalbedeli, lMalIskontoTutari, 0, lToplamIskonto, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, lPesinat, 0, 0, 0, 0, 0, nOdemeKodu, lPesinat, sHareketTipi, 0, nKasaNo, kullanici, Now, "")
                        End Try
                        tbAvSirano_degistir(1, nAlisVerisID, sMagaza)
                        lFaturaNo_degistir(lFaturaNo, sMagaza)
                        nAlisVerisID = sMagaza & nAlisVerisID.ToString
                    End If
                    Dim kayitsayisi = sorgu_tbAlisVerisAdres_kontrol(nAlisVerisID)
                    If kayitsayisi = 0 Then
                        tbAlisVerisAdres_kaydet_yeni(nAlisVerisID, "", "", "", "", "", "", "", "", "", "")
                    Else
                    End If
                End If
            End If
            If dr("nGirisCikis") = 3 Or dr("nGirisCikis") = 4 Then
                nStokID = dr("nStokNo")
                nIslemID = sorgu_nStokIslemID()
                lMiktar = dr("lMiktar")
                lToplamMiktar += lMiktar
                lBrutTutar = dr("lBrutTutar")
                lMalbedeli += lBrutTutar
                Try
                    lBrutFiyat = lBrutTutar / lMiktar
                Catch ex As Exception
                    lBrutFiyat = 0
                End Try
                lCikisTutar = lCikisFiyat * lMiktar / ((100 + dr("nKdvOrani")) / 100)
                Try
                    lCikisFiyat = lBrutFiyat - dr("lIskontoTutari")
                    lCikisTutar = lCikisFiyat * lMiktar / ((100 + dr("nKdvOrani")) / 100)

                Catch ex As Exception
                    lCikisFiyat = 0
                End Try
                lMaliyet = sorgu_sayi(dr("lMaliyet"), 0)
                nKdvOrani = dr("nKdvOrani")
                nGirisCikis = dr("nGirisCikis")
                sSaticiRumuzu = dr("sSaticiRumuzu")
                'Try
                '    lFiyat = lTutar / lMiktar
                'Catch ex As Exception
                '    lFiyat = 0
                'End Try
                lMalIskontoTutariT = dr("lIskontoTutari")
                IndirimliFiyat = lCikisFiyat - dr("lIskontoTutari")
                lMalIskontoTutari = lMalIskontoTutari + dr("lIskontoTutari")
                nIskontoYuzdesi = dr("nIskontoYuzdesi")
                'If dr("lIskontoTutari") > 0 Then
                '    nIskontoYuzdesi = ((lCikisFiyat - IndirimliFiyat) / lCikisFiyat * 100)
                If lMiktar > 1 Then
                    nIskontoYuzdesi = nIskontoYuzdesi / lMiktar
                End If
                'Else
                '    nIskontoYuzdesi = 0
                'End If
                If nIskontoYuzdesi >= 100 Then
                    nIskontoYuzdesi = 99.99
                    lPesinat += 0.01
                    lNetTutar = lPesinat
                Else
                    nIskontoYuzdesi = nIskontoYuzdesi
                End If
                lIskontoTutari = sorgu_sayi(dr("lIskontoTutari"), 0)
                If sorgu_sayi(nStokID, 0) <> 0 Then
                    Try
                        nIslemID = tbStokFisidetay_kaydet_yeni(nIslemID, nStokID, dteFisTarihi, 0, nMusteriID, sFisTipi, dteFisTarihi, lFaturaNo, nGirisCikis, sMagaza, 0, "", sKasiyerRumuzu, sSaticiRumuzu, "", "01/01/1900", 0, 0, 0, 0, 0, lMiktar, 0, lCikisFiyat, lCikisTutar, "", lBrutFiyat, lBrutTutar, lMaliyet, lMaliyet * lMiktar, 0, nIskontoYuzdesi, lIskontoTutari, "", 0, "", 0, "", "", nKdvOrani, 0, "", sHareketTipi, 0, kullanici, dteKayitTarihi, "", 0, 0, "", 0, 0, 0, "", nAlisVerisID, 0, "", "", "", 0, 0, 0, 0, kullanici, dteKayitTarihi)
                        'nIslemID = tbStokFisidetay_kaydet_yeni(nIslemID, nStokID, dteFisTarihi, 0, nMusteriID, sFisTipi, dteFisTarihi, lFaturaNo, nGirisCikis, sMagaza, 0, "", sKasiyerRumuzu, sSaticiRumuzu, "", "01/01/1900", 0, 0, 0, 0, 0, lMiktar, 0, lCikisFiyat, lCikisTutar, "", lBrutFiyat, lBrutTutar, lMaliyet, lMaliyet * lMiktar, 0, nIskontoYuzdesi, 0, "", 0, "", 0, "", "", nKdvOrani, 0, "", sHareketTipi, 0, kullanici, dteKayitTarihi, "", 0, 0, "", 0, 0, 0, "", nAlisVerisID, 0, "", "", "", 0, 0, 0, 0, kullanici, dteKayitTarihi)
                        fis_detay_fisno_degistir(nIslemID)
                    Catch ex As Exception
                    End Try
                Else
                End If
            ElseIf dr("bKapali") = False Then
                nTaksitID = sorgu_nTaksitID(sMagaza)
                Dim dteTarihi As DateTime
                Dim dteFaturaTarihi As DateTime = dr("dteFisTarihi")
                Dim sGun As Integer = 15
                Dim sAy As Integer = dteFaturaTarihi.Month
                Dim sYil As String = dteFaturaTarihi.Year
                If sAy < 12 Then
                    sAy = sAy + 1
                Else
                    sAy = 1
                    sYil = sYil + 1
                End If
                If sKasa = "Escort" Then
                    dteTarihi = sGun & "/" & sAy & "/" & sYil
                    tbTaksit_kaydet_yeni(sMagaza & nTaksitID, nAlisVerisID, dteTarihi, dr("lOdemeTutar"))
                Else
                    tbTaksit_kaydet_yeni(sMagaza & nTaksitID, nAlisVerisID, dr("dteFisTarihi"), dr("lOdemeTutar"))
                End If
                tbAvSirano_degistir(3, nTaksitID, sMagaza)
                lPesinat += dr("lOdemeTutar")
            ElseIf dr("bKapali") = True Then
                Try
                    If lMakbuzNo = sorgu_lMakbuzNo_varmi(sMagaza, nAlisVerisID) = 0 Then
                        lMakbuzNo = sorgu_lMakbuzNo(sMagaza)
                        lMakbuzNo_degistir(lMakbuzNo, sMagaza)
                    End If
                    nOdemeId = sorgu_nOdemeID(sMagaza).ToString
                    lPesinat = dr("lOdemeTutar")
                    tbOdeme_kaydet_yeni(sMagaza & nOdemeId, nAlisVerisID, dr("sOdemeKodu"), nOdemeKodu, sKasiyerRumuzu, dteFisTarihi, dteFisTarihi, lPesinat, "", 0, lMakbuzNo, lMakbuzNo, "", "", 0, 1, "", kullanici, Now, sMagaza)
                    tbAvSirano_degistir(2, nOdemeId, sMagaza)
                Catch ex As Exception
                End Try
            End If
            bar.Position += 1
            bar.Refresh()
            Label2.Text = bar.Position
            Label2.Refresh()
        Next
        'lMalIskontoTutari = lIskontoTutari
        entegre_toplamhesapla(nAlisVerisID, sFisTipi, sMagaza, lToplamMiktar, lMalbedeli, lMalIskontoTutari, lToplamIskonto, lDipIskontoTutari, lPesinat, lPesinat)
        bar.Position = 0
        bar.Refresh()
        bar.Visible = False
        'MsgBox(Sorgu_sDil("Tamamlandý",sDil), MessageBoxIcon.Information, sorgu_sDil("Dikkat",sDil))
    End Sub
    Private Sub tbAlisVeris_kaydet_sil_sistem(ByVal nAlisverisID As String)
        Dim con As New OleDb.OleDbConnection
        Dim cmd As New OleDb.OleDbCommand
        Dim lOdemeTutar As Decimal = 0
        cmd.Connection = con
        con.ConnectionString = connection
        If con.State = ConnectionState.Closed = True Then
            con.Open()
        End If
        cmd.CommandText = sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT ISNULL(SUM(tbOdeme.lOdemeTutar), 0) AS lOdemeTutar FROM tbAlisVeris INNER JOIN tbOdeme ON tbAlisVeris.nAlisverisID = tbOdeme.nAlisverisID WHERE (tbOdeme.nOdemeKodu =2) and (tbAlisVeris.nAlisverisID = '" & nAlisverisID & "') OR (tbOdeme.nIadeAlisverisID = '" & nAlisverisID & "') ")
        lOdemeTutar = cmd.ExecuteScalar
        If lOdemeTutar = 0 Then
            Try
                cmd.CommandText = sorgu_query("SET DATEFORMAT DMY SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED ")
                cmd.ExecuteNonQuery()
                cmd.CommandText = sorgu_query("set implicit_transactions off")
                cmd.ExecuteNonQuery()
                cmd.CommandText = sorgu_query("delete tbAVPromosyonIndirim where nAlisverisID = '" & nAlisverisID & "' ")
                cmd.ExecuteNonQuery()
                cmd.CommandText = sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT count (a.nTaksitID) from tbTaksit a , tbOdeme b where a.nTaksitID=b.nTaksitID and a.nAlisverisID = '" & nAlisverisID & "'")
                cmd.ExecuteNonQuery()
                cmd.CommandText = sorgu_query("set implicit_transactions on")
                cmd.ExecuteNonQuery()
                cmd.CommandText = sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED UPDATE tbAlisverisSlip set bIptalmi = 0  where nAlisverisID =  ( Select top 1 nIadeAlisverisID from tbOdeme where nIadeAlisverisID <> ''    and nAlisverisID = '" & nAlisverisID & "')")
                cmd.ExecuteNonQuery()
                cmd.CommandText = sorgu_query("delete tbAVKartTaksit where nOdemeID in ( select nOdemeID from tbOdeme where nAlisverisID =  '" & nAlisverisID & "' )")
                cmd.ExecuteNonQuery()
                cmd.CommandText = sorgu_query("delete tbOdeme where nAlisverisID = '" & nAlisverisID & "'")
                cmd.ExecuteNonQuery()
                cmd.CommandText = sorgu_query("delete tbTaksit where nAlisverisID = '" & nAlisverisID & "'")
                cmd.ExecuteNonQuery()
                cmd.CommandText = sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED UPDATE tbMusteriPara set lPara = lPara - isnull(( select sum(lTutar) from tbAVHediyeCeki where nAlisverisID = '" & nAlisverisID & "' and sHediyeCekiTipi = 'ParaPU_KAZ'), 0)  + isnull(( select sum(lTutar) from tbAVHediyeCeki where nAlisverisID = '" & nAlisverisID & "' and sHediyeCekiTipi = 'ParaPU_HAR'), 0)  where nMusteriID in (select nMusteriID from tbAlisveris where nAlisverisID = '" & nAlisverisID & "')")
                cmd.ExecuteNonQuery()
                cmd.CommandText = sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED UPDATE tbAVIndirimKuponu set bKapandimi = 0 where sAlinanBasilan = 'B' and sKuponSeriNo in (select sKuponSeriNo from tbAVIndirimKuponu where sAlinanBasilan = 'A'  and nAlisverisID = '" & nAlisverisID & "')")
                cmd.ExecuteNonQuery()
                cmd.CommandText = sorgu_query("delete tbAVIndirimKuponu where nAlisverisID = '" & nAlisverisID & "'")
                cmd.ExecuteNonQuery()
                cmd.CommandText = sorgu_query("delete tbStokFisiDetayi where nAlisverisID = '" & nAlisverisID & "'")
                cmd.ExecuteNonQuery()
                cmd.CommandText = sorgu_query("delete tbAlisverisSiparis where nAlisverisID = '" & nAlisverisID & "'")
                cmd.ExecuteNonQuery()
                cmd.CommandText = sorgu_query("delete tbAVHediyeCeki where nAlisverisID = '" & nAlisverisID & "'")
                cmd.ExecuteNonQuery()
                cmd.CommandText = sorgu_query("delete tbAlisverisSlip where nAlisverisID = '" & nAlisverisID & "'")
                cmd.ExecuteNonQuery()
                cmd.CommandText = sorgu_query("delete tbAlisVerisAdres where nAlisverisID = '" & nAlisverisID & "'")
                cmd.ExecuteNonQuery()
                cmd.CommandText = sorgu_query("delete tbAlisVeris where nAlisverisID = '" & nAlisverisID & "'")
                cmd.ExecuteNonQuery()
                cmd.CommandText = sorgu_query("IF @@TRANCOUNT > 0 COMMIT TRAN")
                cmd.ExecuteNonQuery()
            Catch ex As Exception
                cmd.CommandText = sorgu_query("IF @@TRANCOUNT > 0 COMMIT TRAN")
                cmd.ExecuteNonQuery()
                XtraMessageBox.Show(Sorgu_sDil("Ýþlem Hatasý Lütfen Tekrar Deneyiniz...", sDil), Sorgu_sDil("Dikkat", sDil), MessageBoxButtons.OK, MessageBoxIcon.Warning)
            End Try
        Else
            XtraMessageBox.Show(Sorgu_sDil("Ödeme Alýnmýþ Belgeyi Silemezsiniz...", sDil), Sorgu_sDil("Dikkat", sDil), MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
        con.Close()
        'TermalYazdir_iptal()
    End Sub
    Private Sub entegre_toplamhesapla(ByVal nAlisVerisID As String, ByVal sFisTipi As String, ByVal sMagaza As String, ByVal lMiktar As Decimal, ByVal lMalbedeli As Decimal, ByVal lMalIskontoTutari As Decimal, ByVal nDipIskontoYuzdesi As Decimal, ByVal lDipIskontoTutari As Decimal, ByVal lPesinat As Decimal, ByVal lNetTutar As Decimal)
        Dim dr As DataRow
        Dim nGirisCikis As Integer = 3
        Dim sYaziIle As String = ""
        Dim ds_alislar_kdv As DataSet
        'lNetTutar = dr("lNetTutar")
        'If lDipIskontoTutari > 0 Then
        '    lDipIskontoTutari = (lMalbedeli - lMalIskontoTutari) * (nDipIskontoYuzdesi / 100)
        'Else
        '    lDipIskontoTutari = 0
        'End If
        'lNetTutar = lMalbedeli - lMalIskontoTutari - lDipIskontoTutari
        'lPesinat = sorgu_lPesinat_lTutari(nAlisVerisID)
        'dr_toplam("lNetTutar") = lNetTutar
        If lNetTutar < 0 Then
            nGirisCikis = 4
        ElseIf lNetTutar > 0 Then
            nGirisCikis = 3
        End If
        sYaziIle = ygeneltoplam(Math.Abs(lNetTutar))
        Dim nKdvOrani1 = 0
        Dim lKdvMatrahi1 = 0
        Dim lKdv1 = 0
        Dim nKdvOrani2 = 0
        Dim lKdvMatrahi2 = 0
        Dim lKdv2 = 0
        Dim nKdvOrani3 = 0
        Dim lKdvMatrahi3 = 0
        Dim lKdv3 = 0
        Dim nKdvOrani4 = 0
        Dim lKdvMatrahi4 = 0
        Dim lKdv4 = 0
        Dim nKdvOrani5 = 0
        Dim lKdvMatrahi5 = 0
        Dim lKdv5 = 0
        Dim nVadeFarkiYuzdesi = 0
        Dim nVadeKdvOrani = 0
        Dim lVadeKdvMatrahi = 0
        Dim lVadeKdv = 0
        Dim lVadeFarki = 0
        If Trim(sFisTipi) = "SK" Or Trim(sFisTipi) = "SP" Then
            ds_alislar_kdv = sorgu(sorgu_query("SET              TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT     TOP 5 nKdvOrani, SUM((lBrutTutar-lIskontoTutari) / ((100 + nKdvOrani) / 100)) AS lKdvMatrahi, SUM(lBrutTutar-lIskontoTutari) - SUM((lBrutTutar-lIskontoTutari) / ((100 + nKdvOrani) / 100)) AS lKdv, SUM(lBrutTutar-lIskontoTutari) AS lNetTutar FROM         tbAlisVerisSiparis WHERE     (nAlisverisID = '" & nAlisVerisID & "') GROUP BY nKdvOrani ORDER BY nKdvOrani"))
        Else
            ds_alislar_kdv = sorgu(sorgu_query("SET              TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT     TOP 5 nKdvOrani, SUM((lBrutTutar-lIskontoTutari) / ((100 + nKdvOrani) / 100)) AS lKdvMatrahi, SUM(lBrutTutar-lIskontoTutari) - SUM((lBrutTutar-lIskontoTutari) / ((100 + nKdvOrani) / 100)) AS lKdv, SUM(lBrutTutar-lIskontoTutari) AS lNetTutar FROM         tbStokFisiDetayi WHERE     (nAlisverisID = '" & nAlisVerisID & "') GROUP BY nKdvOrani ORDER BY nKdvOrani"))
        End If
        Dim dr1 As DataRow
        Dim sayi As Decimal = 0
        For Each dr1 In ds_alislar_kdv.Tables(0).Rows
            sayi += 1
            If sayi = 1 Then
                nKdvOrani1 = dr1("nKdvOrani")
                lKdvMatrahi1 = dr1("lKdvMatrahi")
                lKdv1 = dr1("lKdv")
            ElseIf sayi = 2 Then
                nKdvOrani2 = dr1("nKdvOrani")
                lKdvMatrahi2 = dr1("lKdvMatrahi")
                lKdv2 = dr1("lKdv")
            ElseIf sayi = 3 Then
                nKdvOrani3 = dr1("nKdvOrani")
                lKdvMatrahi3 = dr1("lKdvMatrahi")
                lKdv3 = dr1("lKdv")
            ElseIf sayi = 4 Then
                nKdvOrani4 = dr1("nKdvOrani")
                lKdvMatrahi4 = dr1("lKdvMatrahi")
                lKdv4 = dr1("lKdv")
            ElseIf sayi = 5 Then
                nKdvOrani5 = dr1("nKdvOrani")
                lKdvMatrahi5 = dr1("lKdvMatrahi")
                lKdv5 = dr1("lKdv")
            End If
        Next
        tbAlisVeris_toplam_kaydet_degistir(nAlisVerisID, nGirisCikis, lMiktar, lMalbedeli, lMalIskontoTutari, nDipIskontoYuzdesi, lDipIskontoTutari, nKdvOrani1, lKdvMatrahi1, lKdv1, nKdvOrani2, lKdvMatrahi2, lKdv2, nKdvOrani3, lKdvMatrahi3, lKdv3, nKdvOrani4, lKdvMatrahi4, lKdv4, nKdvOrani5, lKdvMatrahi5, lKdv5, lPesinat, nVadeFarkiYuzdesi, nVadeKdvOrani, lVadeKdvMatrahi, lVadeKdv, lVadeFarki, lPesinat, sYaziIle)
        dr = Nothing
        dr1 = Nothing
        lMiktar = Nothing
        lMalbedeli = Nothing
        lMalIskontoTutari = Nothing
        nDipIskontoYuzdesi = Nothing
        lDipIskontoTutari = Nothing
        'lPesinat = Nothing
        lNetTutar = Nothing
        ds_alislar_kdv = Nothing
    End Sub
#Region " Müþteri Bakiye "
    Public Function sorgu_musteri_kontrol(ByVal kod As String) As Int64
        Dim kriter
        kriter = "WHERE (lKodu = '" & kod & "')  "
        Dim conn As New OleDb.OleDbConnection
        Dim cmd As New OleDb.OleDbCommand
        Dim adapter As New OleDb.OleDbDataAdapter
        'MsgBox(connection_resmi)
        conn.ConnectionString = connection
        cmd.CommandTimeout = False
        cmd.Connection = conn
        conn.Open()
        cmd.CommandText = sorgu_query("SET DATEFORMAT DMY SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT     ISNULL(nMusteriID, 1) AS lKodu FROM         tbMusteri " & kriter & "")
        Dim kayitsayisi = cmd.ExecuteScalar
        Return kayitsayisi
        cmd = Nothing
    End Function
    Public Function sorgu_nAlisVerisID(ByVal sDepo As String) As Int64
        'kriter = "WHERE (sKodu = '" & kod & "')  "
        Dim conn As New OleDb.OleDbConnection
        Dim cmd As New OleDb.OleDbCommand
        Dim adapter As New OleDb.OleDbDataAdapter
        'MsgBox(connection_resmi)
        conn.ConnectionString = connection
        cmd.CommandTimeout = False
        cmd.Connection = conn
        If conn.State = ConnectionState.Closed Then
            conn.Open()
        End If
        cmd.CommandText = sorgu_query("SET DATEFORMAT DMY SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT nSonID + 1 AS nSonID FROM tbAVSiraNo WHERE (sDepo = '" & sDepo & "') AND (nSiraIndex = 1)")
        'cmd.CommandText = sorgu_query("SET DATEFORMAT DMY SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT     TOP 1 ISNULL(REPLACE(nAlisverisID, '" & sDepo & "', ''), 0) + 1 AS nSonID FROM         tbAlisVeris WHERE     (nAlisVerisID  like '" & sDepo & "%') ORDER BY CAST(ISNULL(REPLACE(nAlisverisID, '" & sDepo & "', ''), 0) AS DECIMAL) DESC")
        Dim kayitsayisi = cmd.ExecuteScalar
        Return kayitsayisi
        cmd = Nothing
        adapter = Nothing
    End Function
    Public Function sorgu_lFaturaNo(ByVal sDepo As String, ByVal sFisTipi As String) As Int64
        Dim conn As New OleDb.OleDbConnection
        Dim cmd As New OleDb.OleDbCommand
        Dim adapter As New OleDb.OleDbDataAdapter
        conn.ConnectionString = connection
        cmd.CommandTimeout = False
        cmd.Connection = conn
        If conn.State = ConnectionState.Closed Then
            conn.Open()
        End If
        'cmd.CommandText = sorgu_query("SET DATEFORMAT DMY SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT     ISNULL(MAX(lFaturaNo), 0) + 1 AS nSonID FROM         tbAlisVeris WHERE     (sMagaza = '" & sDepo & "') AND (nGirisCikis = 3) AND (sFisTipi IN ('" & sFisTipi & "'))")
        cmd.CommandText = sorgu_query("SET DATEFORMAT DMY SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT     ISNULL(MAX(lFaturaNo), 0) + 1 AS nSonID FROM         tbAlisVeris WHERE     (nGirisCikis = 3) AND (sFisTipi IN ('" & sFisTipi & "'))")
        Dim kayitsayisi = cmd.ExecuteScalar
        Return kayitsayisi
        cmd = Nothing
        adapter = Nothing
    End Function
    Private Sub lFaturaNo_degistir(ByVal nSonID As Int64, ByVal sDepo As String)
        Dim conn As New OleDb.OleDbConnection
        Dim cmd As New OleDb.OleDbCommand
        Dim adapter As New OleDb.OleDbDataAdapter
        conn.ConnectionString = connection
        cmd.CommandTimeout = False
        cmd.Connection = conn
        If conn.State = ConnectionState.Closed Then
            conn.Open()
        End If
        cmd.CommandText = sorgu_query("SET DATEFORMAT DMY SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED UPDATE    tbStokFisNolar SET              lPerakendeFatura1 ='" & nSonID & "' WHERE     (sDepo = '" & sDepo & "')")
        cmd.ExecuteNonQuery()
        conn.Close()
    End Sub
    Public Function sorgu_nOdemeID(ByVal sDepo As String) As Int64
        'kriter = "WHERE (sKodu = '" & kod & "')  "
        Dim conn As New OleDb.OleDbConnection
        Dim cmd As New OleDb.OleDbCommand
        Dim adapter As New OleDb.OleDbDataAdapter
        'MsgBox(connection_resmi)
        conn.ConnectionString = connection
        cmd.CommandTimeout = False
        cmd.Connection = conn
        conn.Open()
        cmd.CommandText = sorgu_query("SET DATEFORMAT DMY SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT nSonID + 1 AS nSonID FROM tbAVSiraNo WHERE (sDepo = '" & sDepo & "') AND (nSiraIndex = 2)")
        'cmd.CommandText = sorgu_query("SET DATEFORMAT DMY SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT     TOP 1 ISNULL(REPLACE(nOdemeID, '" & sDepo & "', ''), 0) + 1 AS nOdemeID FROM         tbOdeme WHERE     (sMagaza = '" & sDepo & "') ORDER BY dteOdemeTarihi DESC, nOdemeID DESC")
        Dim kayitsayisi = cmd.ExecuteScalar
        Return kayitsayisi
    End Function
    Public Function sorgu_lMakbuzNo(ByVal sDepo As String) As Int64
        Dim conn As New OleDb.OleDbConnection
        Dim cmd As New OleDb.OleDbCommand
        Dim adapter As New OleDb.OleDbDataAdapter
        conn.ConnectionString = connection
        cmd.CommandTimeout = False
        cmd.Connection = conn
        conn.Open()
        cmd.CommandText = sorgu_query("SET DATEFORMAT DMY SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT     TOP 1 ISNULL(lMakbuzNo,0) + 1 lMakbuzNo FROM         tbOdeme WHERE     (sMagaza = '" & sDepo & "') and nOdemeKodu=1 ORDER BY  lMakbuzNo DESC")
        'cmd.CommandText = sorgu_query("SET DATEFORMAT DMY SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT     TOP 1 ISNULL(lMakbuzNo,0) + 1 lMakbuzNo FROM         tbOdeme WHERE     (sMagaza = '" & sDepo & "') and nOdemeKodu=2 ORDER BY lMakbuzNo DESC")
        Dim kayitsayisi = cmd.ExecuteScalar
        Return kayitsayisi
    End Function
    Public Function sorgu_lMakbuzNo_varmi(ByVal sDepo As String, ByVal nAlisVerisID As String) As Int64
        Dim conn As New OleDb.OleDbConnection
        Dim cmd As New OleDb.OleDbCommand
        Dim adapter As New OleDb.OleDbDataAdapter
        conn.ConnectionString = connection
        cmd.CommandTimeout = False
        cmd.Connection = conn
        conn.Open()
        cmd.CommandText = sorgu_query("SET DATEFORMAT DMY SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT     COUNT(lMakbuzNo) AS lMakbuzNo FROM         tbOdeme WHERE     (sMagaza = '" & sDepo & "') and (nOdemeKodu = 1) AND (nAlisverisID = '" & nAlisVerisID & "')")
        Dim kayitsayisi As Integer = 0
        kayitsayisi = cmd.ExecuteScalar
        sorgu_sayi(kayitsayisi, 0)
        Return kayitsayisi
    End Function
    Private Sub lMakbuzNo_degistir(ByVal nSonID As Int64, ByVal sDepo As String)
        Dim conn As New OleDb.OleDbConnection
        Dim cmd As New OleDb.OleDbCommand
        Dim adapter As New OleDb.OleDbDataAdapter
        conn.ConnectionString = connection
        cmd.CommandTimeout = False
        cmd.Connection = conn
        If conn.State = ConnectionState.Closed Then
            conn.Open()
        End If
        nSonID += 1
        cmd.CommandText = sorgu_query("SET DATEFORMAT DMY SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED UPDATE    tbStokFisNolar SET              lPerakendeFatura1 ='" & nSonID & "' WHERE     (sDepo = '" & sDepo & "')")
        cmd.ExecuteNonQuery()
        conn.Close()
    End Sub
    Public Function sorgu_nTaksitID(ByVal sDepo As String) As Int64
        'kriter = "WHERE (sKodu = '" & kod & "')  "
        Dim conn As New OleDb.OleDbConnection
        Dim cmd As New OleDb.OleDbCommand
        Dim adapter As New OleDb.OleDbDataAdapter
        'MsgBox(connection_resmi)
        conn.ConnectionString = connection
        cmd.CommandTimeout = False
        cmd.Connection = conn
        conn.Open()
        cmd.CommandText = sorgu_query("SET DATEFORMAT DMY SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT nSonID + 1 AS nSonID FROM tbAVSiraNo WHERE (sDepo = '" & sDepo & "') AND (nSiraIndex = 3)")
        Dim kayitsayisi = cmd.ExecuteScalar
        Return kayitsayisi
        cmd = Nothing
    End Function
    Public Function sorgu_nStokID(ByVal kod As String) As Int64
        Dim kriter
        kriter = "WHERE (sKodu = '" & kod & "') "
        Dim conn As New OleDb.OleDbConnection
        Dim cmd As New OleDb.OleDbCommand
        Dim adapter As New OleDb.OleDbDataAdapter
        conn.ConnectionString = connection
        cmd.CommandTimeout = False
        cmd.Connection = conn
        conn.Open()
        cmd.CommandText = sorgu_query("SET DATEFORMAT DMY SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT     TOP 1 ISNULL(nStokID, 0) AS nStokID FROM         tbStok " & kriter & "")
        Dim kayitsayisi = cmd.ExecuteScalar
        Return kayitsayisi
        cmd = Nothing
    End Function
    Public Function sorgu_nStokIslemID() As Int64
        Dim kriter As String = ""
        'kriter = "WHERE (sKodu = '" & kod & "')  "
        Dim conn As New OleDb.OleDbConnection
        Dim cmd As New OleDb.OleDbCommand
        Dim adapter As New OleDb.OleDbDataAdapter
        'MsgBox(connection_resmi)
        conn.ConnectionString = connection
        cmd.CommandTimeout = False
        cmd.Connection = conn
        If conn.State = ConnectionState.Closed Then
            conn.Open()
        End If
        cmd.CommandText = sorgu_query("SET DATEFORMAT DMY SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT     ISNULL(MAX(nIslemID), 0) + 1 AS nStokIslemID FROM         tbStokFisiDetayi")
        Dim kayitsayisi = cmd.ExecuteScalar
        If kayitsayisi = 0 Then
            kayitsayisi = 1
        End If
        Return kayitsayisi
        cmd = Nothing
        adapter = Nothing
    End Function
    Public Function sorgu_sDepo_kontrol(ByVal sDepo As String) As Int64
        Dim kriter
        kriter = ""
        Dim conn As New OleDb.OleDbConnection
        Dim cmd As New OleDb.OleDbCommand
        Dim adapter As New OleDb.OleDbDataAdapter
        conn.ConnectionString = connection
        cmd.CommandTimeout = False
        cmd.Connection = conn
        conn.Open()
        cmd.CommandText = sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT     ISNULL(COUNT(sDepo), 0) AS nKayit FROM         tbDepo WHERE     (sDepo = '" & sDepo & "') ")
        Dim kayitsayisi = cmd.ExecuteScalar
        Return kayitsayisi
        cmd = Nothing
    End Function
    Private Function tbDepo_kaydet_yeni(ByVal sDepo As String, ByVal sAciklama As String, ByVal nFirmaID As Int64, ByVal sSube As String, ByVal sDepoTipi As String, ByVal sEmail As String, ByVal nKatSayisi As Int64, ByVal nMagazaM2 As Int64, ByVal nDepoM2 As Int64, ByVal sKiraDovizCinsi As String, ByVal lKiraBedeli As Decimal, ByVal dteAcilisTarihi As DateTime, ByVal dteSonDekorasyon As DateTime, ByVal sMudurAdiSoyadi As String, ByVal nPersonelAdeti As Int64) As String
        Dim con As New OleDb.OleDbConnection
        Dim cmd As New OleDb.OleDbCommand
        cmd.Connection = con
        con.ConnectionString = connection
        cmd.CommandTimeout = False
        If con.State = ConnectionState.Closed = True Then
            con.Open()
        End If
        cmd.CommandText = sorgu_query("SET DATEFORMAT DMY SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED INSERT INTO tbDepo (sDepo, sAciklama, nFirmaID, sSube, sDepoTipi, sEmail, nKatSayisi, nMagazaM2, nDepoM2, sKiraDovizCinsi, lKiraBedeli, dteAcilisTarihi,  dteSonDekorasyon, sMudurAdiSoyadi, nPersonelAdeti) VALUES     ('" & sDepo & "', N'" & sAciklama & "', " & nFirmaID & ", '" & sSube & "', '" & sDepoTipi & "', '" & sEmail & "', " & nKatSayisi & ", " & nMagazaM2 & ", " & nDepoM2 & ", '" & sKiraDovizCinsi & "', " & lKiraBedeli & ", '" & dteAcilisTarihi & "', '" & dteSonDekorasyon & "', '" & sMudurAdiSoyadi & "', " & nPersonelAdeti & ")")
        cmd.ExecuteNonQuery()
        cmd.CommandText = "SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT @@identity"
        Dim kayitno = cmd.ExecuteScalar
        con.Close()
        Return kayitno
        cmd = Nothing
        con = Nothing
    End Function
    Private Sub tbAlisVeris_kaydet_yeni(ByVal nAlisverisID As String, ByVal sFisTipi As String, ByVal dteFaturaTarihi As DateTime, ByVal nGirisCikis As Int64, ByVal lFaturaNo As String, ByVal nMusteriID As Int64, ByVal sMagaza As String, ByVal sKasiyerRumuzu As String, ByVal sAlisverisYapanAdi As String, ByVal sAlisverisYapanSoyadi As String, ByVal lToplamMiktar As Decimal, ByVal lMalBedeli As Decimal, ByVal lMalIskontoTutari As Decimal, ByVal nDipIskontoYuzdesi As Decimal, ByVal lDipIskontoTutari As Decimal, ByVal nKdvOrani1 As Decimal, ByVal lKdvMatrahi1 As Decimal, ByVal lKdv1 As Decimal, ByVal nKdvOrani2 As Decimal, ByVal lKdvMatrahi2 As Decimal, ByVal lKdv2 As Decimal, ByVal nKdvOrani3 As Decimal, ByVal lKdvMatrahi3 As Decimal, ByVal lKdv3 As Decimal, ByVal nKdvOrani4 As Decimal, ByVal lKdvMatrahi4 As Decimal, ByVal lKdv4 As Decimal, ByVal nKdvOrani5 As Decimal, ByVal lKdvMatrahi5 As Decimal, ByVal lKdv5 As Decimal, ByVal lPesinat As Decimal, ByVal nVadeFarkiYuzdesi As Decimal, ByVal nVadeKdvOrani As Decimal, ByVal lVadeKdvMatrahi As Decimal, ByVal lVadeKdv As Decimal, ByVal lVadeFarki As Decimal, ByVal sOdemeKodu As String, ByVal lNetTutar As Decimal, ByVal sHareketTipi As String, ByVal bMuhasebeyeIslendimi As Integer, ByVal nKasaNo As Int64, ByVal sKullaniciAdi As String, ByVal dteKayitTarihi As DateTime, ByVal sYaziIle As String)
        Dim con As New OleDb.OleDbConnection
        Dim cmd As New OleDb.OleDbCommand
        cmd.Connection = con
        con.ConnectionString = connection
        cmd.CommandTimeout = False
        If con.State = ConnectionState.Closed = True Then
            con.Open()
        End If
        cmd.CommandText = sorgu_query("SET DATEFORMAT DMY SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED INSERT INTO tbAlisVeris (nAlisverisID, sFisTipi, dteFaturaTarihi, nGirisCikis, lFaturaNo, nMusteriID, sMagaza, sKasiyerRumuzu, sAlisverisYapanAdi, sAlisverisYapanSoyadi, lToplamMiktar, lMalBedeli, lMalIskontoTutari, nDipIskontoYuzdesi, lDipIskontoTutari, nKdvOrani1, lKdvMatrahi1, lKdv1, nKdvOrani2, lKdvMatrahi2, lKdv2, nKdvOrani3, lKdvMatrahi3, lKdv3, nKdvOrani4, lKdvMatrahi4, lKdv4, nKdvOrani5, lKdvMatrahi5, lKdv5, lPesinat, nVadeFarkiYuzdesi, nVadeKdvOrani, lVadeKdvMatrahi, lVadeKdv, lVadeFarki, sOdemeKodu, lNetTutar, sHareketTipi, bMuhasebeyeIslendimi, nKasaNo, sKullaniciAdi, dteKayitTarihi, sYaziIle) VALUES     ('" & nAlisverisID & "', '" & sFisTipi & "', '" & dteFaturaTarihi & "', " & nGirisCikis & ", '" & lFaturaNo & "', " & nMusteriID & ", '" & sMagaza & "', '" & sKasiyerRumuzu & "', '" & sAlisverisYapanAdi & "', '" & sAlisverisYapanSoyadi & "', " & lToplamMiktar & ", " & lMalBedeli & ", " & lMalIskontoTutari & ", " & nDipIskontoYuzdesi & ", " & lDipIskontoTutari & ", " & nKdvOrani1 & ", " & lKdvMatrahi1 & ", " & lKdv1 & ", " & nKdvOrani2 & ", " & lKdvMatrahi2 & ", " & lKdv2 & ", " & nKdvOrani3 & ", " & lKdvMatrahi3 & ", " & lKdv3 & ", " & nKdvOrani4 & ", " & lKdvMatrahi4 & ", " & lKdv4 & ", " & nKdvOrani5 & ", " & lKdvMatrahi5 & ", " & lKdv5 & ", " & lPesinat & ", " & nVadeFarkiYuzdesi & ", " & nVadeKdvOrani & ", " & lVadeKdvMatrahi & ", " & lVadeKdv & ", " & lVadeFarki & ", '" & sOdemeKodu & "', " & lNetTutar & ", '" & sHareketTipi & "', " & bMuhasebeyeIslendimi & ", " & nKasaNo & ", '" & sKullaniciAdi & "',  '" & dteKayitTarihi & "', '" & sYaziIle & "')")
        cmd.ExecuteNonQuery()
        con.Close()
        cmd = Nothing
        con = Nothing
    End Sub
    Private Sub tbAlisVeris_toplam_kaydet_degistir(ByVal nAlisVerisID As String, ByVal nGirisCikis As Int64, ByVal lToplamMiktar As Decimal, ByVal lMalBedeli As Decimal, ByVal lMalIskontoTutari As Decimal, ByVal nDipIskontoYuzdesi As Decimal, ByVal lDipIskontoTutari As Decimal, ByVal nKdvOrani1 As Decimal, ByVal lKdvMatrahi1 As Decimal, ByVal lKdv1 As Decimal, ByVal nKdvOrani2 As Decimal, ByVal lKdvMatrahi2 As Decimal, ByVal lKdv2 As Decimal, ByVal nKdvOrani3 As Decimal, ByVal lKdvMatrahi3 As Decimal, ByVal lKdv3 As Decimal, ByVal nKdvOrani4 As Decimal, ByVal lKdvMatrahi4 As Decimal, ByVal lKdv4 As Decimal, ByVal nKdvOrani5 As Decimal, ByVal lKdvMatrahi5 As Decimal, ByVal lKdv5 As Decimal, ByVal lPesinat As Decimal, ByVal nVadeFarkiYuzdesi As Decimal, ByVal nVadeKdvOrani As Decimal, ByVal lVadeKdvMatrahi As Decimal, ByVal lVadeKdv As Decimal, ByVal lVadeFarki As Decimal, ByVal lNetTutar As Decimal, ByVal sYaziIle As String)
        Dim cmd As New OleDb.OleDbCommand
        Dim con As New OleDb.OleDbConnection
        cmd.Connection = con
        con.ConnectionString = connection
        cmd.CommandTimeout = False
        If con.State = ConnectionState.Closed = True Then
            con.Open()
        End If
        cmd.CommandText = sorgu_query("SET DATEFORMAT DMY SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED UPDATE    tbAlisVeris SET              nGirisCikis = " & nGirisCikis & ",lToplamMiktar = " & lToplamMiktar & ", lMalBedeli = " & lMalBedeli & ", lMalIskontoTutari = " & lMalIskontoTutari & ", nDipIskontoYuzdesi = " & nDipIskontoYuzdesi & ", lDipIskontoTutari = " & lDipIskontoTutari & ", nKdvOrani1 = " & nKdvOrani1 & ", lKdvMatrahi1 = " & lKdvMatrahi1 & ", lKdv1 = " & lKdv1 & ", nKdvOrani2 = " & nKdvOrani2 & ", lKdvMatrahi2 = " & lKdvMatrahi2 & ", lKdv2 = " & lKdv2 & ", nKdvOrani3 = " & nKdvOrani3 & ", lKdvMatrahi3 = " & lKdvMatrahi3 & ", lKdv3 = " & lKdv3 & ", nKdvOrani4 = " & nKdvOrani4 & ", lKdvMatrahi4 = " & lKdvMatrahi4 & ", lKdv4 = " & lKdv4 & ", nKdvOrani5 = " & nKdvOrani5 & ", lKdvMatrahi5 = " & lKdvMatrahi5 & ", lKdv5 = " & lKdv5 & ", lPesinat = " & lPesinat & ", nVadeFarkiYuzdesi = " & nVadeFarkiYuzdesi & ", nVadeKdvOrani = " & nVadeKdvOrani & ", lVadeKdvMatrahi = " & lVadeKdvMatrahi & ", lVadeKdv = " & lVadeKdv & ", lVadeFarki = " & lVadeFarki & ", lNetTutar = " & lNetTutar & ", sYaziIle = '" & sYaziIle & "'  WHERE nAlisVerisID = '" & nAlisVerisID & "'")
        cmd.ExecuteNonQuery()
        con.Close()
    End Sub
    Private Sub tbOdeme_kaydet_yeni(ByVal nOdemeID As String, ByVal nAlisverisID As String, ByVal sOdemeSekli As String, ByVal nOdemeKodu As Int64, ByVal sKasiyerRumuzu As String, ByVal dteOdemeTarihi As DateTime, ByVal dteValorTarihi As DateTime, ByVal lOdemeTutar As Decimal, ByVal sDovizCinsi As String, ByVal lDovizTutar As Decimal, ByVal lMakbuzNo As String, ByVal lOdemeNo As String, ByVal nTaksitID As String, ByVal nIadeAlisverisID As String, ByVal bMuhasebeyeIslendimi As Byte, ByVal nKasaNo As Int64, ByVal sKartNo As String, ByVal sKullaniciAdi As String, ByVal dteKayitTarihi As DateTime, ByVal sMagaza As String)
        Dim con As New OleDb.OleDbConnection
        Dim cmd As New OleDb.OleDbCommand
        cmd.Connection = con
        con.ConnectionString = connection
        cmd.CommandTimeout = False
        If con.State = ConnectionState.Closed = True Then
            con.Open()
        End If
        cmd.CommandText = sorgu_query("SET DATEFORMAT DMY SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED INSERT INTO tbOdeme                       (nOdemeID, nAlisverisID, sOdemeSekli, nOdemeKodu, sKasiyerRumuzu, dteOdemeTarihi, dteValorTarihi, lOdemeTutar, sDovizCinsi, lDovizTutar, lMakbuzNo, lOdemeNo, nTaksitID, nIadeAlisverisID, bMuhasebeyeIslendimi, nKasaNo, sKartNo, sKullaniciAdi, dteKayitTarihi, sMagaza) VALUES     ('" & nOdemeID & "', '" & nAlisverisID & "', '" & sOdemeSekli & "', " & nOdemeKodu & ", '" & sKasiyerRumuzu & "', '" & dteOdemeTarihi & "', '" & dteValorTarihi & "', " & lOdemeTutar & ", '" & sDovizCinsi & "', " & lDovizTutar & ", " & lMakbuzNo & ", " & lOdemeNo & ", '" & nTaksitID & "', '" & nIadeAlisverisID & "', " & bMuhasebeyeIslendimi & ", " & nKasaNo & ", '" & sKartNo & "', '" & sKullaniciAdi & "', '" & dteKayitTarihi & "', '" & sMagaza & "')")
        Try
            cmd.ExecuteNonQuery()
        Catch ex As Exception
            'MsgBox(Sorgu_sDil("sOdemeSekli:" & sOdemeSekli & vbTab & "Odeme Tiplerinizi Kontrol Ediniz...!",sDil), MessageBoxIcon.Warning, sorgu_sDil("Dikkat",sDil))
        End Try
        con.Close()
        cmd = Nothing
        con = Nothing
    End Sub
    Private Sub tbAvSirano_degistir(ByVal nSiraIndex As Integer, ByVal nSonID As Int64, ByVal sDepo As String)
        'kriter = "WHERE (sFisTipi = '" & sFistipi & "') and (dteFisTarihi = '" & dteFisTarihi & "') and (lFisNo = '" & lFisno & "') and (nFirmaID= '" & nFirmaID & "') and (nGirisCikis = '" & nGirisCikis & "')  "
        'sorgu(sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT     * FROM         tbFirmaHareketi " & kriter & ""))
        Dim conn As New OleDb.OleDbConnection
        Dim cmd As New OleDb.OleDbCommand
        Dim adapter As New OleDb.OleDbDataAdapter
        conn.ConnectionString = connection
        cmd.CommandTimeout = False
        cmd.Connection = conn
        If conn.State = ConnectionState.Closed Then
            conn.Open()
        End If
        cmd.CommandText = sorgu_query("SET DATEFORMAT DMY SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED UPDATE    tbAvSiraNo SET              nSonID = '" & nSonID & "' where nSiraIndex = " & nSiraIndex & " and sDepo = '" & sDepo & "'")
        cmd.ExecuteNonQuery()
        conn.Close()
        cmd = Nothing
        adapter = Nothing
    End Sub
    Public Function sorgu_tbAlisVerisAdres_kontrol(ByVal nAlisVerisID As String) As Int64
        Dim kriter
        kriter = "WHERE (nAlisVerisID = '" & nAlisVerisID & "')  "
        Dim conn As New OleDb.OleDbConnection
        Dim cmd As New OleDb.OleDbCommand
        Dim adapter As New OleDb.OleDbDataAdapter
        'MsgBox(connection_resmi)
        conn.ConnectionString = connection
        cmd.CommandTimeout = False
        cmd.Connection = conn
        If conn.State = ConnectionState.Closed Then
            conn.Open()
        End If
        cmd.CommandText = sorgu_query("SET DATEFORMAT DMY SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT     ISNULL(COUNT(*), 0) AS KAYIT FROM         tbAlisVerisAdres " & kriter & "")
        Dim kayitsayisi = cmd.ExecuteScalar
        Return kayitsayisi
        cmd = Nothing
        adapter = Nothing
    End Function
    Private Sub tbAlisVerisAdres_kaydet_yeni(ByVal nAlisVerisID As String, ByVal sAciklama As String, ByVal sAdres1 As String, ByVal sAdres2 As String, ByVal sSemt As String, ByVal sIl As String, ByVal sUlke As String, ByVal sPostaKodu As String, ByVal sVergiDairesi As String, ByVal sVergiNo As String, ByVal sSubeMagaza As String)
        Dim con As New OleDb.OleDbConnection
        Dim cmd As New OleDb.OleDbCommand
        cmd.Connection = con
        con.ConnectionString = connection
        cmd.CommandTimeout = False
        If con.State = ConnectionState.Closed = True Then
            con.Open()
        End If
        cmd.CommandText = sorgu_query("SET DATEFORMAT DMY SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED INSERT INTO tbAlisVerisAdres (nAlisVerisID, sAciklama, sAdres1, sAdres2, sSemt, sIl, sUlke, sPostaKodu, sVergiDairesi, sVergiNo, sSubeMagaza) VALUES     ('" & nAlisVerisID & "', N'" & sAciklama & "', '" & sAdres1 & "', '" & sAdres2 & "', '" & sSemt & "', '" & sIl & "', '" & sUlke & "', '" & sPostaKodu & "', '" & sVergiDairesi & "', '" & sVergiNo & "', '" & sSubeMagaza & "')")
        cmd.ExecuteNonQuery()
        con.Close()
        cmd = Nothing
        con = Nothing
    End Sub
    Private Function tbStokFisidetay_kaydet_yeni(ByVal nIslemID As Int64, ByVal nStokID As Int64, ByVal dteIslemTarihi As DateTime, ByVal nFirmaID As Int64, ByVal nMusteriID As Int64, ByVal sFisTipi As String, ByVal dteFisTarihi As DateTime, ByVal lFisNo As String, ByVal nGirisCikis As Int64, ByVal sDepo As String, ByVal lReyonFisNo As String, ByVal sStokIslem As String, ByVal sKasiyerRumuzu As String, ByVal sSaticiRumuzu As String, ByVal sOdemeKodu As String, ByVal dteIrsaliyeTarihi As DateTime, ByVal lIrsaliyeNo As String, ByVal lGirisMiktar1 As Decimal, ByVal lGirisMiktar2 As Decimal, ByVal lGirisFiyat As Decimal, ByVal lGirisTutar As Decimal, ByVal lCikisMiktar1 As Decimal, ByVal lCikisMiktar2 As Decimal, ByVal lCikisFiyat As Decimal, ByVal lCikisTutar As Decimal, ByVal sFiyatTipi As String, ByVal lBrutFiyat As Decimal, ByVal lBrutTutar As Decimal, ByVal lMaliyetFiyat As Decimal, ByVal lMaliyetTutar As Decimal, ByVal lIlaveMaliyetTutar As Decimal, ByVal nIskontoYuzdesi As Decimal, ByVal lIskontoTutari As Decimal, ByVal sDovizCinsi As String, ByVal lDovizFiyat As Decimal, ByVal nSiparisID As String, ByVal nReceteNo As String, ByVal nTransferID As String, ByVal sTransferDepo As String, ByVal nKdvOrani As Decimal, ByVal nHesapID As Int64, ByVal sAciklama As String, ByVal sHareketTipi As String, ByVal bMuhasebeyeIslendimi As Byte, ByVal sKullaniciAdi As String, ByVal dteKayitTarihi As DateTime, ByVal sDovizCinsi1 As String, ByVal lDovizMiktari1 As Decimal, ByVal lDovizKuru1 As Decimal, ByVal sDovizCinsi2 As String, ByVal lDovizMiktari2 As Decimal, ByVal lDovizKuru2 As Decimal, ByVal nOTVOrani As Decimal, ByVal nTransferFirmaID As String, ByVal nAlisverisID As String, ByVal nStokFisiID As Int64, ByVal nIrsaliyeFisiID As String, ByVal sMasrafYontemi As String, ByVal sHangiUygulama As String, ByVal nEkSaha1 As Int64, ByVal nEkSaha2 As Int64, ByVal bEkSoru1 As Int64, ByVal bEkSoru2 As Int64, ByVal sSonKullaniciAdi As String, ByVal dteSonUpdateTarihi As DateTime) As Int64
        Dim con As New OleDb.OleDbConnection
        Dim cmd As New OleDb.OleDbCommand
        cmd.Connection = con
        con.ConnectionString = connection
        cmd.CommandTimeout = False
        If con.State = ConnectionState.Closed = True Then
            con.Open()
        End If
        If sFiyatTipi = "" Then
            sFiyatTipi = 1
        Else

        End If
        cmd.CommandText = sorgu_query("SET DATEFORMAT DMY SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED INSERT INTO tbStokFisiDetayi                       (nStokID, dteIslemTarihi, nFirmaID, nMusteriID, sFisTipi, dteFisTarihi, lFisNo, nGirisCikis, sDepo, lReyonFisNo, sStokIslem, sKasiyerRumuzu, sSaticiRumuzu, sOdemeKodu, dteIrsaliyeTarihi, lIrsaliyeNo, lGirisMiktar1, lGirisMiktar2, lGirisFiyat, lGirisTutar, lCikisMiktar1, lCikisMiktar2, lCikisFiyat, lCikisTutar, sFiyatTipi, lBrutFiyat, lBrutTutar, lMaliyetFiyat, lMaliyetTutar, lIlaveMaliyetTutar, nIskontoYuzdesi, lIskontoTutari, sDovizCinsi, lDovizFiyat, nSiparisID, nReceteNo, nTransferID, sTransferDepo, nKdvOrani, nHesapID, sAciklama, sHareketTipi, bMuhasebeyeIslendimi, sKullaniciAdi, dteKayitTarihi, sDovizCinsi1, lDovizMiktari1, lDovizKuru1, sDovizCinsi2, lDovizMiktari2, lDovizKuru2, nOTVOrani, nTransferFirmaID, nAlisverisID, nStokFisiID, nIrsaliyeFisiID, sMasrafYontemi, sHangiUygulama, nEkSaha1, nEkSaha2, bEkSoru1, bEkSoru2, sSonKullaniciAdi, dteSonUpdateTarihi) VALUES     ('" & nStokID & "', '" & dteIslemTarihi & "', '" & nFirmaID & "', '" & nMusteriID & "', '" & sFisTipi & "', '" & dteFisTarihi & "', '" & lFisNo & "', " & nGirisCikis & ", '" & sDepo & "', '" & lReyonFisNo & "', '" & sStokIslem & "', '" & sKasiyerRumuzu & "', '" & sSaticiRumuzu & "', '" & sOdemeKodu & "', '" & dteIrsaliyeTarihi & "', '" & lIrsaliyeNo & "', " & lGirisMiktar1 & ", " & lGirisMiktar2 & ", " & lGirisFiyat & ", " & lGirisTutar & ", " & lCikisMiktar1 & ", " & lCikisMiktar2 & " , " & lCikisFiyat & ", " & lCikisTutar & " , '" & sFiyatTipi & "' , " & lBrutFiyat & ", " & lBrutTutar & " , " & lMaliyetFiyat & ", " & lMaliyetTutar & ", " & lIlaveMaliyetTutar & ", " & nIskontoYuzdesi & ", " & lIskontoTutari & ", '" & sDovizCinsi & "', " & lDovizFiyat & ", NULL, '" & nReceteNo & "', NULL, NULL, " & nKdvOrani & ", '" & nHesapID & "', N'" & sAciklama & "', '" & sHareketTipi & "'," & bMuhasebeyeIslendimi & ", '" & sKullaniciAdi & "', '" & dteKayitTarihi & "', '" & sDovizCinsi1 & "', " & lDovizMiktari1 & ", " & lDovizKuru1 & ", '" & sDovizCinsi2 & "', " & lDovizMiktari2 & " , " & lDovizKuru2 & ", " & nOTVOrani & ", NULL,  '" & nAlisverisID & "', NULL, NULL, '" & sMasrafYontemi & "', '" & sHangiUygulama & "', " & nEkSaha1 & ", " & nEkSaha2 & ", " & bEkSoru1 & " , " & bEkSoru2 & ", '" & sSonKullaniciAdi & "', '" & dteSonUpdateTarihi & "')")
        cmd.ExecuteNonQuery()
        cmd.CommandText = "SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT @@identity"
        nIslemID = cmd.ExecuteScalar
        Return nIslemID
        con.Close()
        cmd = Nothing
        con = Nothing
    End Function
    Private Sub tbStokFisidetay_fatura_kaydet_yeni(ByVal nIslemID As Int64, ByVal nStokID As Int64, ByVal dteIslemTarihi As DateTime, ByVal nFirmaID As Int64, ByVal nMusteriID As Int64, ByVal sFisTipi As String, ByVal dteFisTarihi As DateTime, ByVal lFisNo As String, ByVal nGirisCikis As Int64, ByVal sDepo As String, ByVal lReyonFisNo As String, ByVal sStokIslem As String, ByVal sKasiyerRumuzu As String, ByVal sSaticiRumuzu As String, ByVal sOdemeKodu As String, ByVal dteIrsaliyeTarihi As DateTime, ByVal lIrsaliyeNo As String, ByVal lGirisMiktar1 As Decimal, ByVal lGirisMiktar2 As Decimal, ByVal lGirisFiyat As Decimal, ByVal lGirisTutar As Decimal, ByVal lCikisMiktar1 As Decimal, ByVal lCikisMiktar2 As Decimal, ByVal lCikisFiyat As Decimal, ByVal lCikisTutar As Decimal, ByVal sFiyatTipi As String, ByVal lBrutFiyat As Decimal, ByVal lBrutTutar As Decimal, ByVal lMaliyetFiyat As Decimal, ByVal lMaliyetTutar As Decimal, ByVal lIlaveMaliyetTutar As Decimal, ByVal nIskontoYuzdesi As Decimal, ByVal lIskontoTutari As Decimal, ByVal sDovizCinsi As String, ByVal lDovizFiyat As Decimal, ByVal nSiparisID As String, ByVal nReceteNo As String, ByVal nTransferID As String, ByVal sTransferDepo As String, ByVal nKdvOrani As Decimal, ByVal nHesapID As Int64, ByVal sAciklama As String, ByVal sHareketTipi As String, ByVal bMuhasebeyeIslendimi As Byte, ByVal sKullaniciAdi As String, ByVal dteKayitTarihi As DateTime, ByVal sDovizCinsi1 As String, ByVal lDovizMiktari1 As Decimal, ByVal lDovizKuru1 As Decimal, ByVal sDovizCinsi2 As String, ByVal lDovizMiktari2 As Decimal, ByVal lDovizKuru2 As Decimal, ByVal nOTVOrani As Decimal, ByVal nTransferFirmaID As String, ByVal nAlisverisID As String, ByVal nStokFisiID As Int64, ByVal nIrsaliyeFisiID As String, ByVal sMasrafYontemi As String, ByVal sHangiUygulama As String, ByVal nEkSaha1 As Int64, ByVal nEkSaha2 As Int64, ByVal bEkSoru1 As Int64, ByVal bEkSoru2 As Int64, ByVal sSonKullaniciAdi As String, ByVal dteSonUpdateTarihi As DateTime)
        Dim con As New OleDb.OleDbConnection
        Dim cmd As New OleDb.OleDbCommand
        cmd.Connection = con
        con.ConnectionString = connection
        cmd.CommandTimeout = False
        If con.State = ConnectionState.Closed = True Then
            con.Open()
        End If
        cmd.CommandText = sorgu_query("SET DATEFORMAT DMY SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED INSERT INTO tbStokFisiDetayi                       (nIslemID,nStokID, dteIslemTarihi, nFirmaID, nMusteriID, sFisTipi, dteFisTarihi, lFisNo, nGirisCikis, sDepo, lReyonFisNo, sStokIslem, sKasiyerRumuzu, sSaticiRumuzu, sOdemeKodu, dteIrsaliyeTarihi, lIrsaliyeNo, lGirisMiktar1, lGirisMiktar2, lGirisFiyat, lGirisTutar, lCikisMiktar1, lCikisMiktar2, lCikisFiyat, lCikisTutar, sFiyatTipi, lBrutFiyat, lBrutTutar, lMaliyetFiyat, lMaliyetTutar, lIlaveMaliyetTutar, nIskontoYuzdesi, lIskontoTutari, sDovizCinsi, lDovizFiyat, nSiparisID, nReceteNo, nTransferID, sTransferDepo, nKdvOrani, nHesapID, sAciklama, sHareketTipi, bMuhasebeyeIslendimi, sKullaniciAdi, dteKayitTarihi, sDovizCinsi1, lDovizMiktari1, lDovizKuru1, sDovizCinsi2, lDovizMiktari2, lDovizKuru2, nOTVOrani, nTransferFirmaID, nAlisverisID, nStokFisiID, nIrsaliyeFisiID, sMasrafYontemi, sHangiUygulama, nEkSaha1, nEkSaha2, bEkSoru1, bEkSoru2, sSonKullaniciAdi, dteSonUpdateTarihi) VALUES     (" & nIslemID & " ,'" & nStokID & "', '" & dteIslemTarihi & "', '" & nFirmaID & "', '" & nMusteriID & "', '" & sFisTipi & "', '" & dteFisTarihi & "', '" & lFisNo & "', " & nGirisCikis & ", '" & sDepo & "', '" & lReyonFisNo & "', '" & sStokIslem & "', '" & sKasiyerRumuzu & "', '" & sSaticiRumuzu & "', '" & sOdemeKodu & "', '" & dteIrsaliyeTarihi & "', '" & lIrsaliyeNo & "', " & lGirisMiktar1 & ", " & lGirisMiktar2 & ", " & lGirisFiyat & ", " & lGirisTutar & ", " & lCikisMiktar1 & ", " & lCikisMiktar2 & " , " & lCikisFiyat & ", " & lCikisTutar & " , '" & sFiyatTipi & "' , " & lBrutFiyat & ", " & lBrutTutar & " , " & lMaliyetFiyat & ", " & lMaliyetTutar & ", " & lIlaveMaliyetTutar & ", " & nIskontoYuzdesi & ", " & lIskontoTutari & ", '" & sDovizCinsi & "', " & lDovizFiyat & ", NULL, '" & nReceteNo & "', NULL, NULL, " & nKdvOrani & ", '" & nHesapID & "', N'" & sAciklama & "', '" & sHareketTipi & "'," & bMuhasebeyeIslendimi & ", '" & sKullaniciAdi & "', '" & dteKayitTarihi & "', '" & sDovizCinsi1 & "', " & lDovizMiktari1 & ", " & lDovizKuru1 & ", '" & sDovizCinsi2 & "', " & lDovizMiktari2 & " , " & lDovizKuru2 & ", " & nOTVOrani & ", NULL,  NULL, '" & nStokFisiID & "', NULL, '" & sMasrafYontemi & "', '" & sHangiUygulama & "', " & nEkSaha1 & ", " & nEkSaha2 & ", " & bEkSoru1 & " , " & bEkSoru2 & ", '" & sSonKullaniciAdi & "', '" & dteSonUpdateTarihi & "')")
        cmd.ExecuteNonQuery()
        con.Close()
        con = Nothing
        cmd = Nothing
    End Sub
    Private Sub tbTaksit_kaydet_yeni(ByVal nTaksitID As String, ByVal nAlisverisID As String, ByVal dteTarihi As String, ByVal lTutari As Decimal)
        Dim con As New OleDb.OleDbConnection
        Dim cmd As New OleDb.OleDbCommand
        cmd.Connection = con
        con.ConnectionString = connection
        cmd.CommandTimeout = False
        If con.State = ConnectionState.Closed = True Then
            con.Open()
        End If
        cmd.CommandText = sorgu_query("SET DATEFORMAT DMY SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED INSERT INTO tbTaksit (nTaksitID, nAlisverisID, dteTarihi, lTutari) VALUES     ('" & nTaksitID & "', '" & nAlisverisID & "', '" & dteTarihi & "', " & lTutari & ")")
        cmd.ExecuteNonQuery()
        con.Close()
        cmd = Nothing
        con = Nothing
    End Sub
    Private Sub fis_detay_fisno_degistir(ByVal nstokIslemID As String)
        Dim conn As New OleDb.OleDbConnection
        Dim cmd As New OleDb.OleDbCommand
        Dim adapter As New OleDb.OleDbDataAdapter
        conn.ConnectionString = connection
        cmd.CommandTimeout = False
        cmd.Connection = conn
        If conn.State = ConnectionState.Closed Then
            conn.Open()
        End If
        cmd.CommandText = sorgu_query("SET DATEFORMAT DMY SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED UPDATE    tbStokSiraNo SET              nSonID = '" & nstokIslemID & "' where nSiraIndex = 1")
        cmd.ExecuteNonQuery()
        cmd = Nothing
    End Sub
#End Region
    Public Function sayiuzunlukkontrol(ByVal deger As String, ByVal uzunluk As String) As String
        Dim degeruzunluk As Integer = uzunluk
        Dim muzunluk = Len(deger)
        If Len(deger) < uzunluk Then
            Dim degerfark As Integer = degeruzunluk - muzunluk
            Dim i As Integer
            For i = 1 To degerfark
                deger = deger.Insert(0, "0")
            Next
        Else
            deger = Microsoft.VisualBasic.Left(deger, uzunluk)
        End If
        Return deger
    End Function
    Public Sub textdosyaaktarsharp(ByVal dosya As String, ByVal sGramaj As String)
        Dim z = dosya
        Dim s As String
        Dim sayi As Integer = 0
        FileOpen(1, dosya, OpenMode.Input)
        Dim oku() As Byte
        Dim nStokID = 0
        Dim nKayit = 0
        Dim sSinifKodu1 As String = ""
        Dim sSinifKodu2 As String = ""
        Dim sSinifKodu3 As String = ""
        Dim sSinifKodu4 As String = ""
        Dim sSinifKodu5 As String = ""
        Dim sSinifKodu6 As String = ""
        Dim sSinifKodu7 As String = ""
        Dim sSinifKodu8 As String = ""
        Dim sSinifKodu9 As String = ""
        Dim sSinifKodu10 As String = ""
        Dim sRenk As String = ""
        Dim sBeden As String = ""
        Dim sModel As String = ""
        Dim sBirimCinsi1 As String = ""
        Dim sKdvTipi As String = ""
        Dim barkodstn As Integer = 1
        Dim nUzunluk As Integer = 20
        Do Until EOF(1)
            sayi += 1
            s = LineInput(1)
            oku = System.Text.Encoding.UTF7.GetBytes(s)
            s = System.Text.Encoding.UTF7.GetString(oku)
            If sayi >= 2 Then
                Dim plu As String = Trim(s.Substring(0, 14))
                Dim departman = Trim(s.Substring(15, 2))
                Dim birimadi As String = ""
                If Trim(plu.Substring(0, 3)) <> sGramaj And Trim(plu.Substring(0, 3)) <> 100 And Trim(plu.Substring(0, 3)) <> 500 Then
                    plu = Trim(plu.Substring(1, 13))
                    barkodstn = 1
                    birimadi = "ADET"
                ElseIf Trim(plu.Substring(0, 3)) = sGramaj Then
                    plu = Trim(plu.Substring(3, 5))
                    barkodstn = 8
                    birimadi = "KG"
                ElseIf Trim(plu.Substring(0, 3)) = 500 Then
                    plu = Trim(plu.Substring(8, 6))
                    barkodstn = 5
                    birimadi = "ADET"
                ElseIf Trim(plu.Substring(0, 3)) = 100 Then
                    plu = Trim(plu.Substring(6, 8))
                    barkodstn = 2
                    birimadi = "ADET"
                ElseIf Trim(plu.Substring(0, 3)) = 4 Then
                    plu = Trim(plu.Substring(2, 12))
                    barkodstn = 3
                    birimadi = "ADET"
                End If
                Dim malincinsi As String = Trim(s.Substring(44, 16))
                Dim fiyat = Trim(s.Substring(35, 8))
                fiyat = CType(fiyat, Decimal) / 100
                malincinsi = malincinsi.Replace("'", " ")
                plu = plu.Replace("'", " ")
                If Trim(birimadi.ToString) <> "" Then
                    sBirimCinsi1 = sorgu_sBirimCinsi1_kontrol(Microsoft.VisualBasic.Left(Trim(birimadi), 3), Trim(birimadi))
                    If Trim(sBirimCinsi1) = "" Then
                        sBirimCinsi1 = Microsoft.VisualBasic.Left(Trim(birimadi.ToString), 3)
                        Try
                            tbBirimCinsi_kaydet_yeni(sBirimCinsi1, birimadi.ToString, 3)
                        Catch ex As Exception
                            sBirimCinsi1 = ""
                        End Try
                    End If
                Else
                    sBirimCinsi1 = ""
                End If
                If Trim(departman.ToString) <> "" Then
                    sKdvTipi = sorgu_sKdvTipi_kontrol(departman, True)
                    If Trim(sKdvTipi) = "" Then
                        sKdvTipi = columnuzunlukinteger_sifir(sorgu_sKdvTipi_kontrol_kayit(departman), 2)
                        tbKdv_kaydet_yeni(sKdvTipi, departman)
                    End If
                Else
                    sKdvTipi = ""
                End If
                Dim nKayitID As Integer = 0
                nKayitID = sorgu_nStokID(Microsoft.VisualBasic.Left(sorgu_telefon(plu.ToString, ""), nUzunluk))
                If nKayitID = 0 Then
                    nStokID = tbStok_kaydet_yeni(Microsoft.VisualBasic.Left(sorgu_telefon(plu.ToString, ""), nUzunluk), Microsoft.VisualBasic.Left(sorgu_telefon(malincinsi, ""), 60), malincinsi.ToString, 0, "", "", "", "", "", sBirimCinsi1, "", 0, sKdvTipi, 0, 0, 0, "", 0, Microsoft.VisualBasic.Left(sorgu_telefon(plu.ToString, ""), nUzunluk), kullanici, Now, 0, "", 0, 0, "", 0, 0, 0)
                    tbStokSinifi_kaydet_yeni(nStokID, "", "", "", "", "", "", "", "", "", "", "", "", "", "", "")
                    Try
                        If Trim(plu.ToString) <> "" Then
                            tbStokBarkodu_kaydet_yeni(nStokID, Trim(plu.ToString), 0, 0, "", "")
                        End If
                    Catch ex As Exception
                    End Try
                    If fiyat <> 0 Then
                        tbStokFiyati_ekle_yeni(0, sorgu_telefon(plu.ToString, ""), "", "", sFiyat1, fiyat, Now)
                    End If
                End If
                bar.Position = sayi
                bar.Refresh()
                bar.Show()
                Me.Refresh()
            End If
        Loop
        FileClose(1)
        panelstatus.Visible = False
        bar.Visible = False
        ' End If
    End Sub
    Public Function sorgu_sBirimCinsi1_kontrol(ByVal sBirimCinsi As String, ByVal sAciklama As String) As String
        Dim kriter
        kriter = ""
        Dim conn As New OleDb.OleDbConnection
        Dim cmd As New OleDb.OleDbCommand
        Dim adapter As New OleDb.OleDbDataAdapter
        conn.ConnectionString = connection
        cmd.CommandTimeout = False
        cmd.Connection = conn
        conn.Open()
        cmd.CommandText = sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT     ISNULL(sBirimCinsi, '') AS sBirimCinsi FROM         tbBirimCinsi WHERE     (sBirimCinsi = '" & sBirimCinsi & "' ) AND (sAciklama = '" & sAciklama & "') ")
        Dim kayitsayisi = cmd.ExecuteScalar
        Return kayitsayisi
        cmd = Nothing
    End Function
    Private Sub tbBirimCinsi_kaydet_yeni(ByVal sBirimCinsi As String, ByVal sAciklama As String, ByVal nOndalik As Int64)
        Dim con As New OleDb.OleDbConnection
        Dim cmd As New OleDb.OleDbCommand
        cmd.Connection = con
        con.ConnectionString = connection
        If con.State = ConnectionState.Closed = True Then
            con.Open()
        End If
        cmd.CommandText = sorgu_query("SET DATEFORMAT DMY SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED INSERT INTO tbBirimCinsi (sBirimCinsi, sAciklama, nOndalik) VALUES     ('" & sBirimCinsi & "', N'" & sAciklama & "', " & nOndalik & ")")
        cmd.ExecuteNonQuery()
        con.Close()
        cmd = Nothing
        con = Nothing
    End Sub
    Public Function sorgu_sKdvTipi_kontrol(ByVal nKdvOrani As String, Optional ByVal bKdv As Boolean = False) As String
        Dim kriter
        kriter = ""
        Dim conn As New OleDb.OleDbConnection
        Dim cmd As New OleDb.OleDbCommand
        Dim adapter As New OleDb.OleDbDataAdapter
        conn.ConnectionString = connection
        cmd.CommandTimeout = False
        cmd.Connection = conn
        conn.Open()
        If bKdv = False Then
            cmd.CommandText = sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT     sKdvTipi FROM         tbKdv WHERE     (nKdvOrani = " & nKdvOrani & ") AND (sKdvTipi <> '') ")
        Else
            cmd.CommandText = sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT     sKdvTipi FROM         tbKdv WHERE     (sKdvTipi like  '" & nKdvOrani & "%')")
        End If
        Dim kayitsayisi = cmd.ExecuteScalar
        Return kayitsayisi
        cmd = Nothing
    End Function
    Public Function sorgu_sKdvTipi_kontrol_kayit(ByVal nKdvOrani As String) As String
        Dim kriter
        kriter = ""
        Dim conn As New OleDb.OleDbConnection
        Dim cmd As New OleDb.OleDbCommand
        Dim adapter As New OleDb.OleDbDataAdapter
        conn.ConnectionString = connection
        cmd.CommandTimeout = False
        cmd.Connection = conn
        conn.Open()
        cmd.CommandText = sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT     COUNT(sKdvTipi) + 1 AS nKayit FROM         tbKdv WHERE     (sKdvTipi <> '') ")
        Dim kayitsayisi = cmd.ExecuteScalar
        If kayitsayisi = 0 Then
            kayitsayisi = 1
        End If
        Return kayitsayisi
        cmd = Nothing
    End Function
    Private Sub tbKdv_kaydet_yeni(ByVal sKdvTipi As String, ByVal nKdvOrani As Int64)
        Dim cmd As New OleDb.OleDbCommand
        Dim con As New OleDb.OleDbConnection
        cmd.Connection = con
        con.ConnectionString = connection
        cmd.CommandTimeout = False
        If con.State = ConnectionState.Closed = True Then
            con.Open()
        End If
        cmd.CommandText = sorgu_query("SET DATEFORMAT DMY SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED INSERT INTO tbKdv (sKdvTipi, nKdvOrani) VALUES     ('" & sKdvTipi & "', " & nKdvOrani & ")")
        cmd.ExecuteNonQuery()
        con.Close()
        cmd = Nothing
        con = Nothing
    End Sub
    Private Function tbStok_kaydet_yeni(ByVal sKodu As String, ByVal sAciklama As String, ByVal sKisaAdi As String, ByVal nStokTipi As Int64, ByVal sBedenTipi As String, ByVal sKavalaTipi As String, ByVal sRenk As String, ByVal sBeden As String, ByVal sKavala As String, ByVal sBirimCinsi1 As String, ByVal sBirimCinsi2 As String, ByVal nIskontoYuzdesi As Decimal, ByVal sKdvTipi As String, ByVal nTeminSuresi As Decimal, ByVal lAsgariMiktar As Decimal, ByVal lAzamiMiktar As Decimal, ByVal sOzelNot As String, ByVal nFiyatlandirma As Int64, ByVal sModel As String, ByVal sKullaniciAdi As String, ByVal dteKayitTarihi As DateTime, ByVal bEksiyeDusulebilirmi As Byte, ByVal sDefaultAsortiTipi As String, ByVal bEksideUyarsinmi As Byte, ByVal bOTVVar As Byte, ByVal sOTVTipi As String, ByVal nIskontoYuzdesiAV As Decimal, ByVal bEk1 As Byte, ByVal nEk2 As String) As Decimal
        Dim con As New OleDb.OleDbConnection
        Dim cmd As New OleDb.OleDbCommand
        cmd.Connection = con
        con.ConnectionString = connection
        cmd.CommandTimeout = False
        If con.State = ConnectionState.Closed = True Then
            con.Open()
        End If
        cmd.CommandText = sorgu_query("SET DATEFORMAT DMY SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED INSERT INTO tbStok (sKodu, sAciklama, sKisaAdi, nStokTipi, sBedenTipi, sKavalaTipi, sRenk, sBeden, sKavala, sBirimCinsi1, sBirimCinsi2, nIskontoYuzdesi, sKdvTipi, nTeminSuresi, lAsgariMiktar, lAzamiMiktar, sOzelNot, nFiyatlandirma, sModel, sKullaniciAdi, dteKayitTarihi, bEksiyeDusulebilirmi, sDefaultAsortiTipi, bEksideUyarsinmi, bOTVVar, sOTVTipi, nIskontoYuzdesiAV, bEk1, nEk2) VALUES     ('" & sKodu & "', N'" & sAciklama & "', '" & sKisaAdi & "', " & nStokTipi & ", '" & sBedenTipi & "', '" & sKavalaTipi & "', '" & sRenk & "', '" & sBeden & "', '" & sKavala & "', '" & sBirimCinsi1 & "', '" & sBirimCinsi1 & "', " & nIskontoYuzdesi & ", '" & sKdvTipi & "', " & nTeminSuresi & ", " & lAsgariMiktar & ", " & lAzamiMiktar & ", '" & sOzelNot & "', " & nFiyatlandirma & ", '" & sModel & "', '" & sKullaniciAdi & "', '" & dteKayitTarihi & "', " & bEksiyeDusulebilirmi & ", '" & sDefaultAsortiTipi & "', " & bEksideUyarsinmi & ", " & bOTVVar & ", '" & sOTVTipi & "', " & nIskontoYuzdesiAV & ", " & bEk1 & ", " & nEk2 & ")")
        cmd.ExecuteNonQuery()
        cmd.CommandText = "SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT @@identity"
        Dim kayitno = cmd.ExecuteScalar
        con.Close()
        Return kayitno
        cmd = Nothing
        con = Nothing
    End Function

    Private Sub tbStokSinifi_kaydet_yeni(ByVal nStokID As String, ByVal sSinifKodu1 As String, ByVal sSinifKodu2 As String, ByVal sSinifKodu3 As String, ByVal sSinifKodu4 As String, ByVal sSinifKodu5 As String, ByVal sSinifKodu6 As String, ByVal sSinifKodu7 As String, ByVal sSinifKodu8 As String, ByVal sSinifKodu9 As String, ByVal sSinifKodu10 As String, ByVal sSinifKodu11 As String, ByVal sSinifKodu12 As String, ByVal sSinifKodu13 As String, ByVal sSinifKodu14 As String, ByVal sSinifKodu15 As String)
        Dim con As New OleDb.OleDbConnection
        Dim cmd As New OleDb.OleDbCommand
        cmd.Connection = con
        con.ConnectionString = connection
        cmd.CommandTimeout = False
        If con.State = ConnectionState.Closed = True Then
            con.Open()
        End If
        cmd.CommandText = sorgu_query("SET DATEFORMAT DMY SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED INSERT INTO tbStokSinifi (nStokID, sSinifKodu1, sSinifKodu2, sSinifKodu3, sSinifKodu4, sSinifKodu5, sSinifKodu6, sSinifKodu7, sSinifKodu8, sSinifKodu9, sSinifKodu10, sSinifKodu11, sSinifKodu12, sSinifKodu13, sSinifKodu14, sSinifKodu15) VALUES     (" & nStokID & ", '" & sSinifKodu1 & "', '" & sSinifKodu2 & "', '" & sSinifKodu3 & "', '" & sSinifKodu4 & "', '" & sSinifKodu5 & "', '" & sSinifKodu6 & "', '" & sSinifKodu7 & "', '" & sSinifKodu8 & "', '" & sSinifKodu9 & "', '" & sSinifKodu10 & "',  '" & sSinifKodu11 & "', '" & sSinifKodu12 & "', '" & sSinifKodu13 & "', '" & sSinifKodu14 & "', '" & sSinifKodu15 & "')")
        cmd.ExecuteNonQuery()
        con.Close()
        cmd = Nothing
        con = Nothing
    End Sub
    Private Sub tbStokBarkodu_kaydet_yeni(ByVal nStokID As Int64, ByVal sBarkod As String, ByVal nKisim As Integer, ByVal nFirmaID As Integer, ByVal sKarsiStokKodu As String, ByVal sKarsiStokAciklama As String)
        Dim con As New OleDb.OleDbConnection
        Dim cmd As New OleDb.OleDbCommand
        cmd.Connection = con
        con.ConnectionString = connection
        cmd.CommandTimeout = False
        If con.State = ConnectionState.Closed = True Then
            con.Open()
        End If
        cmd.CommandText = sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED INSERT INTO tbStokBarkodu (nStokID, sBarkod, nKisim, nFirmaID, sKarsiStokKodu, sKarsiStokAciklama) VALUES     (" & nStokID & ", '" & sBarkod & "', " & nKisim & ", " & nFirmaID & ", '" & sKarsiStokKodu & "', '" & sKarsiStokAciklama & "')")
        cmd.ExecuteNonQuery()
        con.Close()
        cmd = Nothing
        con = Nothing
    End Sub
    Private Sub siniflandir()
        Dim frm As New frm_ozelkod_tanimla
        frm.firmano = firmano
        frm.donemno = donemno
        frm.connection = connection
        If frm.ShowDialog(Me) = Windows.Forms.DialogResult.OK Then
            Dim nSinifNo As Integer = 1
            Dim sSinifKod As String = ""
            Dim sSinifAciklama As String = ""
            nSinifNo = frm.sec_sinifno.Text
            sSinifKod = frm.sec_satici.EditValue
            sSinifAciklama = frm.sec_satici.Text
            If XtraMessageBox.Show(Sorgu_sDil("Seçili Stoklarýn " & nSinifNo & ".Sýnýf Kodlarýný [" & sSinifKod & "/" & sSinifAciklama & " ] olarak Deðiþtirmek Ýstediðinize Emin misiniz...?", sDil), Sorgu_sDil("Dikkat", sDil), MessageBoxButtons.YesNo, MessageBoxIcon.Question) = MsgBoxResult.Yes Then
                Dim dr As DataRow
                Dim con As New OleDb.OleDbConnection
                Dim cmd As New OleDb.OleDbCommand
                cmd.Connection = con
                con.ConnectionString = connection
                If con.State = ConnectionState.Closed = True Then
                    con.Open()
                End If
                bar.Properties.Maximum = GridView1.RowCount
                panelstatus.Visible = True
                bar.Visible = True
                bar.Position = 0
                For Each dr In DataSet1.Tables(0).Rows
                    dr("Sinif" & nSinifNo & "") = sSinifAciklama
                    cmd.CommandText = sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED UPDATE tbStokSinifi set sSinifKodu" & nSinifNo & " = '" & sSinifKod & "'  where nStokID in ( select nStokID from tbStok where sModel = '" & dr("sModel") & "' )")
                    cmd.ExecuteNonQuery()
                    bar.Position += 1
                    bar.Refresh()
                Next
                con.Close()
                con = Nothing
                cmd = Nothing
                dr = Nothing
                panelstatus.Visible = False
                bar.Visible = False
                XtraMessageBox.Show(Sorgu_sDil("Baþarýyla Tamamlandý...", sDil), Sorgu_sDil("Dikkat", sDil), MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        End If
    End Sub
    Private Sub fiyatlandir_toplu()
        Dim frm As New frm_stok_fiyatlandir_toplu
        Dim kaynak As String = ""
        Dim hedef As String = ""
        Dim oran As Decimal = 0
        Dim oran2 As Decimal = 0
        Dim oran3 As Decimal = 0
        Dim oran4 As Decimal = 0
        Dim isk1 As Decimal = 0
        Dim isk2 As Decimal = 0
        Dim isk3 As Decimal = 0
        Dim isk4 As Decimal = 0
        Dim isk5 As Decimal = 0
        Dim kdv As Decimal = 0
        Dim tutar As Decimal = 0
        Dim degistir As Boolean = False
        Dim sFiyatTipi As String = ""
        If frm.ShowDialog() = Windows.Forms.DialogResult.OK Then
            Dim dr As DataRow
            oran = CType(frm.txtoran.EditValue, Decimal)
            oran2 = CType(frm.txtoran2.EditValue, Decimal)
            oran3 = CType(frm.txtoran3.EditValue, Decimal)
            oran4 = CType(frm.txtoran4.EditValue, Decimal)
            kdv = CType(frm.txtKdv.EditValue, Decimal)
            tutar = CType(frm.txttutar.EditValue, Decimal)
            'kaynak = frm.seckaynak.EditValue
            'hedef = frm.sechedef.EditValue
            If frm.seckaynak.Text = sFiyat1 Then
                kaynak = "FIYAT1"
            ElseIf frm.seckaynak.Text = sFiyat2 Then
                kaynak = "FIYAT2"
            ElseIf frm.seckaynak.Text = sFiyat3 Then
                kaynak = "FIYAT3"
            ElseIf frm.seckaynak.Text = sFiyat4 Then
                kaynak = "FIYAT4"
            ElseIf frm.seckaynak.Text = sFiyat5 Then
                kaynak = "FIYAT5"
            ElseIf frm.seckaynak.Text = sFiyat6 Then
                kaynak = "FIYAT6"
            ElseIf frm.seckaynak.Text = sFiyat7 Then
                kaynak = "FIYAT7"
            ElseIf frm.seckaynak.Text = sFiyatA Then
                kaynak = "FIYATA"
            ElseIf frm.seckaynak.Text = sFiyatM Then
                kaynak = "FIYATM"
            End If
            If frm.sechedef.Text = sFiyat1 Then
                hedef = "FIYAT1"
                sFiyatTipi = sFiyat1
            ElseIf frm.sechedef.Text = sFiyat2 Then
                hedef = "FIYAT2"
                sFiyatTipi = sFiyat2
            ElseIf frm.sechedef.Text = sFiyat3 Then
                hedef = "FIYAT3"
                sFiyatTipi = sFiyat3
            ElseIf frm.sechedef.Text = sFiyat4 Then
                hedef = "FIYAT4"
                sFiyatTipi = sFiyat4
            ElseIf frm.sechedef.Text = sFiyat5 Then
                hedef = "FIYAT5"
                sFiyatTipi = sFiyat5
            ElseIf frm.sechedef.Text = sFiyat6 Then
                hedef = "FIYAT6"
                sFiyatTipi = sFiyat6
            ElseIf frm.sechedef.Text = sFiyat7 Then
                hedef = "FIYAT7"
                sFiyatTipi = sFiyat7
            ElseIf frm.sechedef.Text = sFiyatA Then
                hedef = "FIYATA"
                sFiyatTipi = sFiyatA
            ElseIf frm.sechedef.Text = sFiyatM Then
                hedef = "FIYATM"
                sFiyatTipi = sFiyatM
            End If
            If frm.seckriter.Text = "% olarak artýr" Then
                If XtraMessageBox.Show(Sorgu_sDil("Ürünlerin " & frm.sechedef.Text & ",  " & frm.seckaynak.Text & " üzerinden " & "% " & FormatNumber(oran, 2) & "+" & "% " & FormatNumber(oran2, 2) & "+" & "% " & FormatNumber(oran3, 2) & "+" & "% " & FormatNumber(oran4, 2) & "+" & kdv & " oranýnda artacaktýr..! Eminmisiniz ?", sDil), Sorgu_sDil("Dikkat", sDil), MessageBoxButtons.YesNo, MessageBoxIcon.Question) = MsgBoxResult.Yes Then
                    degistir = True
                Else
                    degistir = False
                End If
            ElseIf frm.seckriter.Text = "% olarak eksilt" Then
                If XtraMessageBox.Show(Sorgu_sDil("Ürünlerin " & frm.sechedef.Text & ",  " & frm.seckaynak.Text & " üzerinden " & "% " & FormatNumber(oran, 2) & "+" & "% " & FormatNumber(oran2, 2) & "+" & "% " & FormatNumber(oran3, 2) & "+" & "% " & FormatNumber(oran4, 2) & "+" & kdv & " oranýnda eksilecektir..! Eminmisiniz ?", sDil), Sorgu_sDil("Dikkat", sDil), MessageBoxButtons.YesNo, MessageBoxIcon.Question) = MsgBoxResult.Yes Then
                    degistir = True
                Else
                    degistir = False
                End If
            ElseIf frm.seckriter.Text = "tutar ile artýr" Then
                If XtraMessageBox.Show(Sorgu_sDil("Ürünlerin " & frm.sechedef.Text & ",  " & frm.seckaynak.Text & " üzerinden " & " " & FormatNumber(tutar, 2) & " tutarýnda artacaktýr..! Eminmisiniz ?", sDil), Sorgu_sDil("Dikkat", sDil), MessageBoxButtons.YesNo, MessageBoxIcon.Question) = MsgBoxResult.Yes Then
                    degistir = True
                Else
                    degistir = False
                End If
            ElseIf frm.seckriter.Text = "tutar ile deðiþtir" Then
                If XtraMessageBox.Show(Sorgu_sDil("Ürünlerin " & frm.sechedef.Text & " " & FormatNumber(tutar, 2) & " olarak deðiþecektir..! Eminmisiniz ?", sDil), Sorgu_sDil("Dikkat", sDil), MessageBoxButtons.YesNo, MessageBoxIcon.Question) = MsgBoxResult.Yes Then
                    degistir = True
                Else
                    degistir = False
                End If
            ElseIf frm.seckriter.Text = "YTL 'ye uyarla" Then
                If XtraMessageBox.Show(Sorgu_sDil("Ürünlerin " & frm.sechedef.Text & ",  1,000,000 'a bölünecektir..! Eminmisiniz ?", sDil), Sorgu_sDil("Dikkat", sDil), MessageBoxButtons.YesNo, MessageBoxIcon.Question) = MsgBoxResult.Yes Then
                    degistir = True
                Else
                    degistir = False
                End If
            ElseIf frm.seckriter.Text = "Eski Fiyatý ile deðiþtir" Then
                If XtraMessageBox.Show(Sorgu_sDil("Ürünlerin " & frm.sechedef.Text & ", Eski Fiyatýyla deðiþecektir..! Eminmisiniz ?", sDil), Sorgu_sDil("Dikkat", sDil), MessageBoxButtons.YesNo, MessageBoxIcon.Question) = MsgBoxResult.Yes Then
                    XtraMessageBox.Show(Sorgu_sDil("Fiyat deðiþim iþleminden sonra listeyi yeniden oluþturmanýz gerekmektedir..!", sDil), Sorgu_sDil("Dikkat", sDil), MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                    degistir = True
                Else
                    degistir = False
                End If
            End If
            Dim sayi As Integer = 0
            If degistir = True Then
                sayi = 0
                For Each dr In DataSet1.Tables(0).Rows
                    'If dr("SEC") = True Then
                    sayi += 1
                    'End If
                Next
                bar.Properties.Maximum = sayi
                'labelbar.Text = "Toplam Satýr Sayýsý : " & (sayi) & ""
                panelstatus.Visible = True
                bar.Visible = True
                Dim con As New OleDb.OleDbConnection
                Dim cmd As New OleDb.OleDbCommand
                con.ConnectionString = connection
                cmd.CommandTimeout = False
                cmd.Connection = con
                sayi = 0
                For Each dr In DataSet1.Tables(0).Rows
                    sayi += 1
                    If frm.seckriter.Text = "tutar ile deðiþtir" Then
                        tutar = frm.txttutar.EditValue
                        If dr("" & hedef & "") <> tutar Then
                            If tutar = 0 Then
                                tbStokFiyati_ekle_sil(dr("nFiyatlandirma"), dr("sModel").ToString, dr("sRenk").ToString, dr("sBeden").ToString, sFiyatTipi, tutar, Today)
                            ElseIf tutar > 0 Then
                                sayi = sorgu_tbStokFiyati_kontrol(dr("nFiyatlandirma"), dr("sModel").ToString, dr("sRenk").ToString, dr("sBeden").ToString, sFiyatTipi)
                                If sayi = 0 Then
                                    tbStokFiyati_ekle_yeni(dr("nFiyatlandirma"), dr("sModel").ToString, dr("sRenk").ToString, dr("sBeden").ToString, sFiyatTipi, tutar, Today)
                                ElseIf sayi = 1 Then
                                    tbStokFiyati_ekle_duzelt(dr("nFiyatlandirma"), dr("sModel").ToString, dr("sRenk").ToString, dr("sBeden").ToString, sFiyatTipi, tutar, Today)
                                End If
                            ElseIf tutar < 0 Then
                                tutar = 0
                                tbStokFiyati_ekle_sil(dr("nFiyatlandirma"), dr("sModel").ToString, dr("sRenk").ToString, dr("sBeden").ToString, sFiyatTipi, tutar, Today)
                            End If
                            dr("" & hedef & "") = tutar
                            Me.Refresh()
                            bar.Position = sayi
                            bar.Refresh()
                        End If
                    ElseIf frm.seckriter.Text = "% olarak artýr" Then
                        oran = frm.txtoran.EditValue
                        oran2 = frm.txtoran2.EditValue
                        oran3 = frm.txtoran3.EditValue
                        oran4 = frm.txtoran4.EditValue
                        kdv = frm.txtKdv.EditValue
                        Dim lFiyat As Decimal = dr("" & kaynak & "")
                        tutar = dr("" & kaynak & "") * ((oran + 100) / 100)
                        isk1 = lFiyat * ((100 + oran) / 100)
                        isk2 = isk1 * ((100 + oran2) / 100)
                        isk3 = isk2 * ((100 + oran3) / 100)
                        isk4 = isk3 * ((100 + oran4) / 100)
                        isk5 = isk4
                        'tutar = (isk5 * (kdv / 100))
                        tutar = (isk5 * ((kdv + 100) / 100))
                        If frm.CheckEdit1.Checked = True Then
                            tutar = Math.Round(tutar)
                        Else
                            tutar = tutar
                        End If
                        If dr("" & hedef & "") <> tutar Then
                            If tutar = 0 Then
                                tbStokFiyati_ekle_sil(dr("nFiyatlandirma"), dr("sModel").ToString, dr("sRenk").ToString, dr("sBeden").ToString, sFiyatTipi, tutar, Today)
                            ElseIf tutar > 0 Then
                                sayi = sorgu_tbStokFiyati_kontrol(dr("nFiyatlandirma"), dr("sModel").ToString, dr("sRenk").ToString, dr("sBeden").ToString, sFiyatTipi)
                                If sayi = 0 Then
                                    tbStokFiyati_ekle_yeni(dr("nFiyatlandirma"), dr("sModel").ToString, dr("sRenk").ToString, dr("sBeden").ToString, sFiyatTipi, tutar, Today)
                                ElseIf sayi = 1 Then
                                    tbStokFiyati_ekle_duzelt(dr("nFiyatlandirma"), dr("sModel").ToString, dr("sRenk").ToString, dr("sBeden").ToString, sFiyatTipi, tutar, Today)
                                End If
                            ElseIf tutar < 0 Then
                                tutar = 0
                                tbStokFiyati_ekle_sil(dr("nFiyatlandirma"), dr("sModel").ToString, dr("sRenk").ToString, dr("sBeden").ToString, sFiyatTipi, tutar, Today)
                            End If
                            bar.Position = sayi
                            bar.Refresh()
                        End If
                    ElseIf frm.seckriter.Text = "% olarak eksilt" Then
                        oran = frm.txtoran.EditValue
                        oran2 = frm.txtoran2.EditValue
                        oran3 = frm.txtoran3.EditValue
                        oran4 = frm.txtoran4.EditValue
                        kdv = frm.txtKdv.EditValue
                        Dim lFiyat As Decimal = dr("" & kaynak & "")
                        tutar = dr("" & kaynak & "") * ((oran + 100) / 100)
                        isk1 = lFiyat * ((100 - oran) / 100)
                        isk2 = isk1 * ((100 - oran2) / 100)
                        isk3 = isk2 * ((100 - oran3) / 100)
                        isk4 = isk3 * ((100 - oran4) / 100)
                        isk5 = isk4
                        'tutar = (isk5 * (kdv / 100))
                        tutar = (isk5 * ((kdv + 100) / 100))
                        If frm.CheckEdit1.Checked = True Then
                            tutar = Math.Round(tutar)
                        Else
                            tutar = tutar
                        End If
                        If dr("" & hedef & "") <> tutar Then
                            If tutar = 0 Then
                                tbStokFiyati_ekle_sil(dr("nFiyatlandirma"), dr("sModel").ToString, dr("sRenk").ToString, dr("sBeden").ToString, sFiyatTipi, tutar, Today)
                            ElseIf tutar > 0 Then
                                sayi = sorgu_tbStokFiyati_kontrol(dr("nFiyatlandirma"), dr("sModel").ToString, dr("sRenk").ToString, dr("sBeden").ToString, sFiyatTipi)
                                If sayi = 0 Then
                                    tbStokFiyati_ekle_yeni(dr("nFiyatlandirma"), dr("sModel").ToString, dr("sRenk").ToString, dr("sBeden").ToString, sFiyatTipi, tutar, Today)
                                ElseIf sayi = 1 Then
                                    tbStokFiyati_ekle_duzelt(dr("nFiyatlandirma"), dr("sModel").ToString, dr("sRenk").ToString, dr("sBeden").ToString, sFiyatTipi, tutar, Today)
                                End If
                            ElseIf tutar < 0 Then
                                tutar = 0
                                tbStokFiyati_ekle_sil(dr("nFiyatlandirma"), dr("sModel").ToString, dr("sRenk").ToString, dr("sBeden").ToString, sFiyatTipi, tutar, Today)
                            End If
                            bar.Position = sayi
                            bar.Refresh()
                        End If
                    ElseIf frm.seckriter.Text = "tutar ile artýr" Then
                        tutar = dr("" & kaynak & "") + frm.txttutar.EditValue
                        If dr("" & hedef & "") <> tutar Then
                            If tutar = 0 Then
                                tbStokFiyati_ekle_sil(dr("nFiyatlandirma"), dr("sModel").ToString, dr("sRenk").ToString, dr("sBeden").ToString, sFiyatTipi, tutar, Today)
                            ElseIf tutar > 0 Then
                                sayi = sorgu_tbStokFiyati_kontrol(dr("nFiyatlandirma"), dr("sModel").ToString, dr("sRenk").ToString, dr("sBeden").ToString, sFiyatTipi)
                                If sayi = 0 Then
                                    tbStokFiyati_ekle_yeni(dr("nFiyatlandirma"), dr("sModel").ToString, dr("sRenk").ToString, dr("sBeden").ToString, sFiyatTipi, tutar, Today)
                                ElseIf sayi = 1 Then
                                    tbStokFiyati_ekle_duzelt(dr("nFiyatlandirma"), dr("sModel").ToString, dr("sRenk").ToString, dr("sBeden").ToString, sFiyatTipi, tutar, Today)
                                End If
                            ElseIf tutar < 0 Then
                                tutar = 0
                                tbStokFiyati_ekle_sil(dr("nFiyatlandirma"), dr("sModel").ToString, dr("sRenk").ToString, dr("sBeden").ToString, sFiyatTipi, tutar, Today)
                            End If
                            dr("" & hedef & "") = tutar
                            Me.Refresh()
                            bar.Position = sayi
                            bar.Refresh()
                        End If
                    ElseIf frm.seckriter.Text = "YTL 'ye uyarla" Then
                        tutar = dr("" & hedef & "") / 1000000
                        If dr("" & hedef & "") <> tutar Then
                            If tutar = 0 Then
                                tbStokFiyati_ekle_sil(dr("nFiyatlandirma"), dr("sModel").ToString, dr("sRenk").ToString, dr("sBeden").ToString, sFiyatTipi, tutar, Today)
                            ElseIf tutar > 0 Then
                                sayi = sorgu_tbStokFiyati_kontrol(dr("nFiyatlandirma"), dr("sModel").ToString, dr("sRenk").ToString, dr("sBeden").ToString, sFiyatTipi)
                                If sayi = 0 Then
                                    tbStokFiyati_ekle_yeni(dr("nFiyatlandirma"), dr("sModel").ToString, dr("sRenk").ToString, dr("sBeden").ToString, sFiyatTipi, tutar, Today)
                                ElseIf sayi = 1 Then
                                    tbStokFiyati_ekle_duzelt(dr("nFiyatlandirma"), dr("sModel").ToString, dr("sRenk").ToString, dr("sBeden").ToString, sFiyatTipi, tutar, Today)
                                End If
                            ElseIf tutar < 0 Then
                                tutar = 0
                                tbStokFiyati_ekle_sil(dr("nFiyatlandirma"), dr("sModel").ToString, dr("sRenk").ToString, dr("sBeden").ToString, sFiyatTipi, tutar, Today)
                            End If
                            dr("" & hedef & "") = tutar
                            Me.Refresh()
                            bar.Position = sayi
                            bar.Refresh()
                        End If
                    ElseIf frm.seckriter.Text = "Eski Fiyatý ile deðiþtir" Then
                        'con.Open()
                        'cmd.CommandText = sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED UPDATE *!FTBLBIRIMLEREX SET SATISFIYATI" & fiyat & " = ESKIFIYAT" & fiyat & " WHERE IND =" & dr("BIRIMNO") & "")
                        'Dim sonuc = cmd.ExecuteNonQuery
                        'If sonuc < 0 Then XtraMessageBox.Show(Sorgu_sDil("Hata Oluþtu")
                        'cmd.CommandText = sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT SATISFIYATI" & fiyat & " FROM *!FTBLBIRIMLEREX WHERE IND =" & dr("BIRIMNO") & "")
                        'sonuc = cmd.ExecuteScalar
                        'con.Close()
                        'dr("" & hedef & "") = sonuc
                        Me.Refresh()
                        bar.Position = sayi
                        bar.Refresh()
                    End If
                    Me.Refresh()
                Next
            End If
            frm.Dispose()
            frm.Close()
            kaynak = Nothing
            hedef = Nothing
            oran = Nothing
            tutar = Nothing
            degistir = Nothing
            panelstatus.Visible = False
            bar.Visible = False
            sFiyatTipi = Nothing
        End If
    End Sub
    Private Sub sKdvTipi_toplu()
        Dim frm As New frm_tbKod
        frm.firmano = firmano
        frm.donemno = donemno
        frm.connection = connection
        frm.sText = "SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT     sKdvTipi as sKod,nKdvOrani as sAciklama FROM         tbKdv"
        frm.lbl_sKod.Text = "KdvTipi:"
        If frm.ShowDialog() = Windows.Forms.DialogResult.OK Then
            If XtraMessageBox.Show(frm.LookUpEdit1.EditValue & Sorgu_sDil(" Kodunu Stoklara Atamak Ýstediðinize Emin misiniz...?", sDil), Sorgu_sDil("Dikkat", sDil), MessageBoxButtons.YesNo, MessageBoxIcon.Question) = MsgBoxResult.Yes Then
                Dim dr As DataRow
                Dim con As New OleDb.OleDbConnection
                Dim cmd As New OleDb.OleDbCommand
                cmd.Connection = con
                con.ConnectionString = connection
                If con.State = ConnectionState.Closed = True Then
                    con.Open()
                End If
                Dim sKdvTipi
                For Each dr In DataSet1.Tables(0).Rows
                    sKdvTipi = frm.LookUpEdit1.EditValue
                    dr("sKdvTipi") = sKdvTipi
                    'dr("nKdvOrani") = frm.LookUpEdit1.Text
                    cmd.CommandText = sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED UPDATE tbStok set sKdvTipi = '" & sKdvTipi & "'  where sModel = '" & dr("sModel") & "'")
                    cmd.ExecuteNonQuery()
                Next
                con.Close()
                con = Nothing
                cmd = Nothing
                dr = Nothing
                XtraMessageBox.Show(Sorgu_sDil("Tamamlandý", sDil), Sorgu_sDil("Dikkat", sDil), MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        End If
    End Sub
    Private Sub adlandir()
        Dim ad As String = ""
        Dim dr As DataRow
        Dim liste As New System.Windows.Forms.ComboBox
        Dim sListe As String = ""
        Dim sinifno As String = ""
        If XtraMessageBox.Show(Sorgu_sDil("Stok Ýsimlerinin Ýlk Kelimelerini Sýnýf Kodu Olarak Atamak Ýstediðinize Emin misiniz...?", sDil), Sorgu_sDil("Dikkat", sDil), MessageBoxButtons.YesNo, MessageBoxIcon.Question) = MsgBoxResult.Yes Then
            sinifno = InputBox("SýnýfKodu Numarasý Belirtiniz..!", "SýnýfNo", 1, 1).ToString
            If sinifno <> "" Then
            End If
            Dim con As New OleDb.OleDbConnection
            Dim cmd As New OleDb.OleDbCommand
            cmd.Connection = con
            con.ConnectionString = connection
            If con.State = ConnectionState.Closed = True Then
                con.Open()
            End If
            bar.Properties.Maximum = GridView1.RowCount
            panelstatus.Visible = True
            bar.Visible = True
            bar.Position = 0
            For Each dr In DataSet1.Tables(0).Rows
                If CStr(Trim(dr("sAciklama")).ToString) <> "" Then
                    'x = (Trim(dr("sAciklama")).IndexOf(" ", 1, (Trim(dr("sAciklama"))).Length - 1)
                    x = (Trim(dr("sAciklama"))).IndexOf(" ", 1, (Trim(dr("sAciklama"))).Length - 1)
                    If x = -1 Then
                        ad = ""
                    Else
                        ad = (Trim(dr("sAciklama"))).Substring(0, x)
                        'txt_ara.Text = (Trim(dr("sAciklama"))).Substring((x + 1), (Trim(dr("sAciklama"))).Length - (x + 1))
                        If IsNumeric(Trim(dr("sAciklama"))) Then
                        Else
                        End If
                    End If
                    If liste.Items.Contains(ad) = False Then
                        liste.Items.Add(ad)
                        sListe += ad & vbCrLf
                    End If
                End If
                If Trim(dr("sAciklama").ToString) <> "" And ad.ToString <> "" Then
                    Dim sSinifkodu As String = ""
                    sSinifkodu = sorgu_Sinif_uret("", sorgu_telefon(ad.ToString, ""), sinifno, "S")
                    dr("Sinif" & sinifno & "") = ad
                    cmd.CommandText = sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED UPDATE tbStokSinifi set sSinifKodu" & sinifno & " = '" & sSinifkodu & "'  where nStokID in ( select nStokID from tbStok where sModel = '" & dr("sModel") & "' )")
                    cmd.ExecuteNonQuery()
                    bar.Position += 1
                    bar.Refresh()
                End If
            Next
            'MsgBox(sListe)
            con.Close()
            con = Nothing
            cmd = Nothing
            dr = Nothing
            panelstatus.Visible = False
            bar.Visible = False
        End If
        dr = Nothing
    End Sub
    Public Function sorgu_Sinif_kontrol_sayi(ByVal sSinifKodu As String, ByVal sinifno As Integer, ByVal t As String) As Int64
        Dim kriter
        kriter = "WHERE (sAciklama = '" & sSinifKodu & "')  "
        Dim conn As New OleDb.OleDbConnection
        Dim cmd As New OleDb.OleDbCommand
        Dim adapter As New OleDb.OleDbDataAdapter
        'MsgBox(connection_resmi)
        conn.ConnectionString = connection
        cmd.Connection = conn
        conn.Open()
        cmd.CommandText = sorgu_query("SET DATEFORMAT DMY SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT      ISNULL(COUNT(sSinifKodu), 0) + 1 AS nKayit FROM          tb" & t & "Sinif" & sinifno & "  Where sSinifKodu <>''")
        Dim kayitsayisi = cmd.ExecuteScalar
        If kayitsayisi = 0 Then
            kayitsayisi = 1
        End If
        Return kayitsayisi
    End Function
    Public Function sorgu_Sinif_kontrol(ByVal sSinifKodu As String, ByVal sinifno As Integer, ByVal t As String) As String
        Dim kriter
        kriter = "WHERE (sAciklama = '" & sSinifKodu & "')  "
        Dim conn As New OleDb.OleDbConnection
        Dim cmd As New OleDb.OleDbCommand
        Dim adapter As New OleDb.OleDbDataAdapter
        'MsgBox(connection_resmi)
        conn.ConnectionString = connection
        cmd.Connection = conn
        conn.Open()
        cmd.CommandText = sorgu_query("SET DATEFORMAT DMY SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT     sSinifKodu FROM          tb" & t & "Sinif" & sinifno & " " & kriter & "")
        Dim kayitsayisi = cmd.ExecuteScalar
        Return kayitsayisi
    End Function
    Public Function sorgu_Sinif_uret(ByVal sSinifKodu As String, ByVal sAciklama As String, ByVal sinifno As Integer, ByVal t As String) As String
        If Trim(sAciklama) <> "" Then
            sSinifKodu = sorgu_Sinif_kontrol(sAciklama, sinifno, t)
            If Trim(sSinifKodu) = "" Then
                sSinifKodu = columnuzunlukinteger_sifir(sorgu_Sinif_kontrol_sayi(sAciklama, sinifno, t), 5)
                stok_sinif_kaydet_yeni(sSinifKodu, sAciklama, sinifno, t)
            End If
        Else
            sSinifKodu = ""
        End If
        Return sSinifKodu
    End Function
    Private Function sorgu_telefon(ByVal deger As Object, ByVal sonuc As String) As String
        If deger.ToString = "" Then
            deger = sonuc
        End If
        deger = deger.Replace("(", "")
        deger = deger.Replace(")", "")
        deger = deger.Replace("_", "")
        deger = deger.Replace(";", "")
        deger = deger.Replace("'", "")
        deger = deger.Replace(",", "")
        'deger = deger.Replace(".", "")
        Return deger
    End Function
    Private Function columnuzunlukinteger_sifir(ByVal deger As String, ByVal uzunluk As Integer) As String
        Dim stringhedef = Trim(deger)
        Dim hedefuzunluk = Len(stringhedef)
        If Len(stringhedef) < uzunluk Then
            Dim fark = uzunluk - hedefuzunluk
            Dim i As Integer
            For i = 1 To fark
                stringhedef = stringhedef.Insert(0, "0")
            Next
            fark = Nothing
            i = Nothing
        Else
            stringhedef = Microsoft.VisualBasic.Left(stringhedef, uzunluk)
        End If
        Return stringhedef
    End Function
    Private Function sorgu_sayi(ByVal deger As Object, ByVal sonuc As Int64) As Decimal
        If deger.ToString = "" Then
            deger = sonuc
        End If
        Return deger
    End Function
    Private Sub stok_sinif_kaydet_yeni(ByVal sSinifKodu As String, ByVal sAciklama As String, ByVal sinifno As Integer, ByVal t As String)
        Dim con As New OleDb.OleDbConnection
        Dim cmd As New OleDb.OleDbCommand
        cmd.Connection = con
        con.ConnectionString = connection
        If con.State = ConnectionState.Closed = True Then
            con.Open()
        End If
        If t = "M" Then
            cmd.CommandText = sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED INSERT INTO tb" & t & "Sinif" & sinifno & "                       (sSinifKodu, sAciklama,bSatisYapilamaz) VALUES     ('" & sSinifKodu & "', N'" & sAciklama & "',0)")
        Else
            cmd.CommandText = sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED INSERT INTO tb" & t & "Sinif" & sinifno & "                       (sSinifKodu, sAciklama) VALUES     ('" & sSinifKodu & "', '" & sAciklama & "')")
        End If
        cmd.ExecuteNonQuery()
        con.Close()
        con = Nothing
        cmd = Nothing
    End Sub
    Private Function sorgu_tbStokFiyati_kontrol(ByVal nFiyatlandirma As Int64, ByVal sModel As String, ByVal sRenk As String, ByVal sBeden As String, ByVal sFiyatTipi As String) As Decimal
        Dim cmd As New OleDb.OleDbCommand
        Dim con As New OleDb.OleDbConnection
        Dim kayitsayisi As Int64
        con.ConnectionString = connection
        cmd.Connection = con
        If con.State = ConnectionState.Closed Then
            con.Open()
        End If
        If nFiyatlandirma = 0 Then
            cmd.CommandText = "SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT COUNT(*) AS Kayit FROM tbFiyatTipi INNER JOIN (SELECT DISTINCT (sFiyatTipi) AS sFiyatTipi , lFiyat , dteFiyatTespitTarihi FROM tbStokFiyati , tbStok WHERE tbStokFiyati.nStokID = tbStok.nStokID AND sFiyatTipi = '" & sFiyatTipi & "' AND tbStok.sModel = '" & sModel & "') Fiyat ON tbFiyatTipi.sFiyatTipi = Fiyat.sFiyatTipi WHERE (tbFiyatTipi.sFiyatTipi <> '') AND (tbFiyatTipi.sFiyatTipi = '" & sFiyatTipi & "')"
        ElseIf nFiyatlandirma = 1 Then
            cmd.CommandText = "SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT COUNT(*) AS Kayit FROM tbFiyatTipi INNER JOIN (SELECT DISTINCT (sFiyatTipi) AS sFiyatTipi , lFiyat , dteFiyatTespitTarihi FROM tbStokFiyati , tbStok WHERE tbStokFiyati.nStokID = tbStok.nStokID AND sFiyatTipi = '" & sFiyatTipi & "' AND tbStok.sModel = '" & sModel & "' and tbStok.sRenk = '" & sRenk & "') Fiyat ON tbFiyatTipi.sFiyatTipi = Fiyat.sFiyatTipi WHERE (tbFiyatTipi.sFiyatTipi <> '') AND (tbFiyatTipi.sFiyatTipi = '" & sFiyatTipi & "')"
        ElseIf nFiyatlandirma = 2 Then
            cmd.CommandText = "SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT COUNT(*) AS Kayit FROM tbFiyatTipi INNER JOIN (SELECT DISTINCT (sFiyatTipi) AS sFiyatTipi , lFiyat , dteFiyatTespitTarihi FROM tbStokFiyati , tbStok WHERE tbStokFiyati.nStokID = tbStok.nStokID AND sFiyatTipi = '" & sFiyatTipi & "' AND tbStok.sModel = '" & sModel & "'and tbStok.sRenk = '" & sRenk & "' and tbStok.sBeden = '" & sBeden & "') Fiyat ON tbFiyatTipi.sFiyatTipi = Fiyat.sFiyatTipi WHERE (tbFiyatTipi.sFiyatTipi <> '') AND (tbFiyatTipi.sFiyatTipi = '" & sFiyatTipi & "')"
        End If
        kayitsayisi = cmd.ExecuteScalar()
        con.Close()
        Return kayitsayisi
    End Function
    Private Sub tbStokFiyati_ekle_yeni(ByVal nFiyatlandirma As Int64, ByVal sModel As String, ByVal sRenk As String, ByVal sBeden As String, ByVal sFiyatTipi As String, ByVal lFiyat As Decimal, ByVal dteFiyatTespitTarihi As DateTime)
        Dim cmd As New OleDb.OleDbCommand
        Dim con As New OleDb.OleDbConnection
        con.ConnectionString = connection
        cmd.Connection = con
        If con.State = ConnectionState.Closed Then
            con.Open()
        End If
        cmd.CommandText = "set implicit_transactions on "
        cmd.ExecuteNonQuery()
        If nFiyatlandirma = 0 Then
            cmd.CommandText = "SET DATEFORMAT DMY SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED insert tbStokFiyati   select nStokID , '" & sFiyatTipi & "' , " & lFiyat & " , '" & dteFiyatTespitTarihi & "' , '" & kullanici & "' , getdate ()  from tbStok where sModel = '" & sModel & "'"
        ElseIf nFiyatlandirma = 1 Then
            cmd.CommandText = "SET DATEFORMAT DMY SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED insert tbStokFiyati   select nStokID , '" & sFiyatTipi & "' , " & lFiyat & " , '" & dteFiyatTespitTarihi & "' , '" & kullanici & "' , getdate ()  from tbStok where sModel = '" & sModel & "' and sRenk ='" & sRenk & "'"
        ElseIf nFiyatlandirma = 2 Then
            cmd.CommandText = "SET DATEFORMAT DMY SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED insert tbStokFiyati   select nStokID , '" & sFiyatTipi & "' , " & lFiyat & " , '" & dteFiyatTespitTarihi & "' , '" & kullanici & "' , getdate ()  from tbStok where sModel = '" & sModel & "' and sRenk ='" & sRenk & "' and sBeden ='" & sBeden & "'"
        End If
        Try
            cmd.ExecuteNonQuery()
        Catch ex As Exception
        End Try
        cmd.CommandText = "IF @@TRANCOUNT > 0 COMMIT TRAN"
        cmd.ExecuteNonQuery()
        cmd.CommandText = "set implicit_transactions off "
        cmd.ExecuteNonQuery()
        con.Close()
        cmd = Nothing
        con = Nothing
    End Sub
    Private Sub tbStokFiyati_ekle_duzelt(ByVal nFiyatlandirma As Int64, ByVal sModel As String, ByVal sRenk As String, ByVal sBeden As String, ByVal sFiyatTipi As String, ByVal lFiyat As Decimal, ByVal dteFiyatTespitTarihi As DateTime)
        Dim cmd As New OleDb.OleDbCommand
        Dim con As New OleDb.OleDbConnection
        con.ConnectionString = connection
        cmd.Connection = con
        If con.State = ConnectionState.Closed Then
            con.Open()
        End If
        cmd.CommandText = "set implicit_transactions on "
        cmd.ExecuteNonQuery()
        If nFiyatlandirma = 0 Then
            cmd.CommandText = "SET DATEFORMAT DMY SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED update tbStokFiyati set lFiyat = " & lFiyat & " , dteFiyatTespitTarihi = '" & dteFiyatTespitTarihi & "' , dteKayitTarihi = getdate() from tbStok where tbStok.nStokID = tbStokFiyati.nStokID and sFiyatTipi = '" & sFiyatTipi & "'       and sModel = '" & sModel & "'"
        ElseIf nFiyatlandirma = 1 Then
            cmd.CommandText = "SET DATEFORMAT DMY SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED update tbStokFiyati set lFiyat = " & lFiyat & " , dteFiyatTespitTarihi = '" & dteFiyatTespitTarihi & "' , dteKayitTarihi = getdate() from tbStok where tbStok.nStokID = tbStokFiyati.nStokID and sFiyatTipi = '" & sFiyatTipi & "'       and sModel = '" & sModel & "' and sRenk = '" & sRenk & "'"
        ElseIf nFiyatlandirma = 2 Then
            cmd.CommandText = "SET DATEFORMAT DMY SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED update tbStokFiyati set lFiyat = " & lFiyat & " , dteFiyatTespitTarihi = '" & dteFiyatTespitTarihi & "' , dteKayitTarihi = getdate() from tbStok where tbStok.nStokID = tbStokFiyati.nStokID and sFiyatTipi = '" & sFiyatTipi & "'       and sModel = '" & sModel & "' and sRenk = '" & sRenk & "' and sBeden = '" & sBeden & "' "
        End If
        cmd.ExecuteNonQuery()
        cmd.CommandText = "IF @@TRANCOUNT > 0 COMMIT TRAN"
        cmd.ExecuteNonQuery()
        cmd.CommandText = "set implicit_transactions off "
        cmd.ExecuteNonQuery()
        con.Close()
        cmd = Nothing
        con = Nothing
    End Sub
    Private Sub tbStokFiyati_ekle_sil(ByVal nFiyatlandirma As Int64, ByVal sModel As String, ByVal sRenk As String, ByVal sBeden As String, ByVal sFiyatTipi As String, ByVal lFiyat As Decimal, ByVal dteFiyatTespitTarihi As DateTime)
        Dim cmd As New OleDb.OleDbCommand
        Dim con As New OleDb.OleDbConnection
        con.ConnectionString = connection
        cmd.Connection = con
        If con.State = ConnectionState.Closed Then
            con.Open()
        End If
        cmd.CommandText = "set implicit_transactions on "
        cmd.ExecuteNonQuery()
        If nFiyatlandirma = 0 Then
            cmd.CommandText = "SET DATEFORMAT DMY SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED delete tbStokFiyati from tbStok where tbStok.nStokID = tbStokFiyati.nStokID       and sFiyatTipi = '" & sFiyatTipi & "'       and sModel = '" & sModel & "'"
        ElseIf nFiyatlandirma = 1 Then
            cmd.CommandText = "SET DATEFORMAT DMY SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED delete tbStokFiyati from tbStok where tbStok.nStokID = tbStokFiyati.nStokID       and sFiyatTipi = '" & sFiyatTipi & "'       and sModel = '" & sModel & "' and sRenk = '" & sRenk & "'"
        ElseIf nFiyatlandirma = 2 Then
            cmd.CommandText = "SET DATEFORMAT DMY SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED delete tbStokFiyati from tbStok where tbStok.nStokID = tbStokFiyati.nStokID       and sFiyatTipi = '" & sFiyatTipi & "'       and sModel = '" & sModel & "' and sRenk = '" & sRenk & "' and sBeden ='" & sBeden & "'"
        End If
        cmd.ExecuteNonQuery()
        cmd.CommandText = "IF @@TRANCOUNT > 0 COMMIT TRAN"
        cmd.ExecuteNonQuery()
        cmd.CommandText = "set implicit_transactions off "
        cmd.ExecuteNonQuery()
        con.Close()
        cmd = Nothing
        con = Nothing
    End Sub
    Private Sub raporla(ByVal nIslem As Integer, Optional ByVal bDirekt As Boolean = False, Optional ByVal bMiktarli As Integer = 1)
        Dim OpenFileDialog1 As New Windows.Forms.OpenFileDialog
        OpenFileDialog1.Title = "Rapor Seç..."
        OpenFileDialog1.Filter = "Rapor Dosyalarý (*.fr*) |*.fr*"
        OpenFileDialog1.FileName = "c:\Formlar\Etiket\Etiket" & sRaporUzanti & ""
        OpenFileDialog1.InitialDirectory = "c:\Formlar\Etiket"
        If OpenFileDialog1.ShowDialog = Windows.Forms.DialogResult.OK Then
            Dim sFile = OpenFileDialog1.FileName.ToString
            If Microsoft.VisualBasic.Right(sFile, 3) = "fr3" Then
                Dim dr As DataRow = GridView1.GetDataRow(GridView1.FocusedRowHandle)
                Dim kriter As String = ""
                If bDirekt = False Then
                    kriter = satir_kontrol()
                    report_create_stok(sFile, kriter, nIslem, sorgu_sayi(dr("lMiktar") * bMiktarli, 1), sorgu_sayi(dr("FIYAT1"), 0), sorgu_sayi(dr("FIYAT2"), 0), sorgu_sayi(dr("FIYAT3"), 0))
                Else
                    Dim dr1 As DataRow
                    For Each dr1 In DataSet1.Tables(0).Rows
                        report_create_stok(sFile, " WHERE stok.nStokId =" & dr1("nStokID") & "", nIslem, sorgu_sayi(dr1("lMiktar") * bMiktarli, 1), sorgu_sayi(dr1("FIYAT1"), 0), sorgu_sayi(dr1("FIYAT2"), 0), sorgu_sayi(dr1("FIYAT3"), 0))
                    Next
                End If
                sFile = Nothing
                kriter = Nothing
            ElseIf Microsoft.VisualBasic.Right(sFile, 3) = "frx" Then
                Dim dr As DataRow = GridView1.GetDataRow(GridView1.FocusedRowHandle)
                Dim kriter As String = ""
                If bDirekt = False Then
                    kriter = satir_kontrol()
                    report_create(nIslem, sFile, kriter, sorgu_sayi(dr("lMiktar") * bMiktarli, 1))
                Else
                    Dim dr1 As DataRow
                    For Each dr1 In DataSet1.Tables(0).Rows
                        report_create(nIslem, sFile, " WHERE stok.nStokId =" & dr1("nStokID") & "", sorgu_sayi(dr1("lMiktar") * bMiktarli, 1))
                    Next
                End If
                kriter = Nothing
            End If
            sFile = Nothing
        End If
    End Sub
    Private Sub report_create(ByVal nIslem As Integer, ByVal sFile As String, ByVal kriter As String, Optional ByVal bMiktarli As Integer = 1)
        Dim report As New FastReport.Report
        report.Load(sFile)
        Dim ds_etiket As DataSet
        'ds_etiket = sorgu(sorgu_query("set transaction isolation level read uncommitted SELECT (SELECT isnull(lfiyat , 0) FROM tbstokfiyati WHERE nStokId = stok.NstokId AND sFiyatTipi = '" & sFiyat1 & "') AS PESIN, (SELECT isnull(lfiyat , 0) FROM tbstokfiyati WHERE nStokId = stok.NstokId AND sFiyatTipi = '" & sFiyat3 & "') AS ONAY, (SELECT isnull(lfiyat , 0) FROM tbstokfiyati WHERE nStokId = stok.NstokId AND sFiyatTipi = '" & sFiyat2 & "') AS ALTIAY, barkod.sBarkod, stok.nStokID,stok.sKisaAdi,stok.sKodu AS STOKKODU, stok.sAciklama AS STOKADI, stok.sRenk, stok.sBeden, stok.lAsgariMiktar, stok.lAzamiMiktar, stok.sModel, tbRenk.sRenkAdi, tbSSinif1.sAciklama AS SINIF1, tbSSinif2.sAciklama AS SINIF2, tbSSinif3.sAciklama AS SINIF3, tbSSinif4.sAciklama AS SINIF4, tbSSinif5.sAciklama AS SINIF5, tbSSinif6.sAciklama AS SINIF6, tbSSinif7.sAciklama AS SINIF7, tbSSinif8.sAciklama AS SINIF8, tbSSinif9.sAciklama AS SINIF9, tbSSinif10.sAciklama AS SINIF10 FROM tbStok stok INNER JOIN tbStokBarkodu barkod ON stok.nStokID = barkod.nStokID and barkod.nKisim = 0 INNER JOIN tbStokSinifi ON stok.nStokID = tbStokSinifi.nStokID INNER JOIN tbSSinif1 ON tbStokSinifi.sSinifKodu1 = tbSSinif1.sSinifKodu INNER JOIN tbSSinif2 ON tbStokSinifi.sSinifKodu2 = tbSSinif2.sSinifKodu INNER JOIN tbSSinif3 ON tbStokSinifi.sSinifKodu3 = tbSSinif3.sSinifKodu INNER JOIN tbSSinif4 ON tbStokSinifi.sSinifKodu4 = tbSSinif4.sSinifKodu INNER JOIN tbSSinif5 ON tbStokSinifi.sSinifKodu5 = tbSSinif5.sSinifKodu INNER JOIN tbSSinif6 ON tbStokSinifi.sSinifKodu6 = tbSSinif6.sSinifKodu INNER JOIN tbSSinif7 ON tbStokSinifi.sSinifKodu7 = tbSSinif7.sSinifKodu INNER JOIN tbSSinif8 ON tbStokSinifi.sSinifKodu8 = tbSSinif8.sSinifKodu INNER JOIN tbSSinif9 ON tbStokSinifi.sSinifKodu9 = tbSSinif9.sSinifKodu INNER JOIN tbSSinif10 ON tbStokSinifi.sSinifKodu10 = tbSSinif10.sSinifKodu LEFT OUTER JOIN tbRenk ON stok.sRenk = tbRenk.sRenk " & kriter & " "), "Etiket")
        ds_etiket = sorgu(sorgu_query("set transaction isolation level read uncommitted SELECT PESIN = CASE WHEN FIYAT <> 0 THEN FIYAT ELSE FIYAT1 END, * FROM (SELECT (SELECT isnull(lfiyat , 0) FROM tbstokfiyati WHERE nStokId = stok.NstokId AND sFiyatTipi = '" & sFiyat1 & "') AS FIYAT1, (SELECT isnull(lfiyat , 0) FROM tbstokfiyati WHERE nStokId = stok.NstokId AND sFiyatTipi = '" & sFiyat3 & "') AS ONAY, (SELECT isnull(lfiyat , 0) FROM tbstokfiyati WHERE nStokId = stok.NstokId AND sFiyatTipi = '" & sFiyat2 & "') AS ALTIAY,(SELECT isnull(lfiyat , 0) FROM tbstokfiyati WHERE nStokId = stok.NstokId AND sFiyatTipi = '" & sAktifFiyatTipi & "') AS FIYAT, (SELECT isnull(lfiyat , 0) FROM tbstokfiyati WHERE nStokId = stok.NstokId AND sFiyatTipi = '" & sFiyat4 & "') AS FIYAT4,barkod.sBarkod, stok.nStokID,stok.sOzelNot,stok.sKodu AS STOKKODU, stok.sAciklama AS STOKADI,stok.sKisaAdi, stok.sRenk, stok.sKavala,stok.sBeden,stok.nEn, stok.nBoy, stok.nYukseklik, stok.nHacim, stok.nAgirlik, stok.lAsgariMiktar, stok.lAzamiMiktar, stok.sModel, tbRenk.sRenkAdi,stok.sBirimCinsi1,(SELECT     nKdvOrani FROM         tbKdv Where sKdvTipi = Stok.sKdvTipi) as nKdvOrani,tbStokAciklama.sAciklama1, tbStokAciklama.sAciklama2, tbStokAciklama.sAciklama3, tbStokAciklama.sAciklama4, tbStokAciklama.sAciklama5,tbStokAciklama.sAciklama6, tbStokAciklama.sAciklama7, tbStokAciklama.sAciklama8, tbStokAciklama.sAciklama9, tbStokAciklama.sAciklama10 FROM         tbStok stok INNER JOIN tbStokBarkodu barkod ON stok.nStokID = barkod.nStokID AND barkod.nKisim = 0 LEFT OUTER JOIN                       tbStokAciklama ON stok.nStokID = tbStokAciklama.nStokID LEFT OUTER JOIN                       tbRenk ON stok.sRenk = tbRenk.sRenk " & kriter & " ) tbStok"), "Etiket")
        report.RegisterData(ds_etiket)
        report.RegisterData(ds_tbParamGenel)
        report.ScriptLanguage = Language.Vb
        If nIslem = 0 Then
            report.Show()
        ElseIf nIslem = 2 Then
            report.Design()
        ElseIf nIslem = 1 Then
            report.PrintSettings.Copies = bMiktarli
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
    Private Sub raporla1(ByVal islem As Integer)
        Dim file As String
        Dim fiyat1 As Decimal = 0
        Dim fiyat2 As Decimal = 0
        Dim fiyat3 As Decimal = 0
        Dim miktar As Decimal = 0
        OpenFileDialog1.Filter = "EtiketDosyalarý(*.fr3) |*.fr3"
        OpenFileDialog1.FileName = "c:\Formlar\Etiket\Etiket.fr3"
        OpenFileDialog1.InitialDirectory = "c:\Formlar\Etiket"
        If OpenFileDialog1.ShowDialog = Windows.Forms.DialogResult.OK Then
            file = OpenFileDialog1.FileName.ToString
            dr = GridView1.GetDataRow(GridView1.FocusedRowHandle)
            fiyat1 = dr("FIYAT1")
            fiyat2 = dr("FIYAT2")
            fiyat3 = dr("FIYAT3")
            miktar = dr("lMiktar")
            report_create_stok(file, satir_kontrol, islem, miktar, fiyat1, fiyat2, fiyat3)
        End If
        fiyat1 = Nothing
        fiyat2 = Nothing
        fiyat3 = Nothing
        miktar = Nothing
        file = Nothing
    End Sub
    Private Function satir_kontrol()
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
    Private Sub report_create_stok(ByVal dosya As String, ByVal kriter As String, ByVal status As Integer, ByVal miktar As Decimal, ByVal fiyat1 As Decimal, ByVal fiyat2 As Decimal, ByVal fiyat3 As Decimal)
        Dim stokno = 0
        Dim satir_line = "100"
        If IntPtr.Size = 4 Then
            '32 Bit
            Dim frx As New TfrxReportClass
            Dim ds1 As New TfrxUserDataSetClass
            Dim qr_hareket As New TfrxADOQuery
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
            'qr_hareket.Query = sorgu_query("set transaction isolation level read uncommitted SELECT (SELECT isnull(lfiyat , 0) FROM tbstokfiyati WHERE nStokId = stok.NstokId AND sFiyatTipi = '" & sFiyat1 & "') AS PESIN, (SELECT isnull(lfiyat , 0) FROM tbstokfiyati WHERE nStokId = stok.NstokId AND sFiyatTipi = '" & sFiyat3 & "') AS ONAY, (SELECT isnull(lfiyat , 0) FROM tbstokfiyati WHERE nStokId = stok.NstokId AND sFiyatTipi = '" & sFiyat2 & "') AS ALTIAY, barkod.sBarkod, stok.sKodu AS STOKKODU, stok.sAciklama AS STOKADI,stok.sKisaAdi, stok.sRenk, stok.sBeden, stok.lAsgariMiktar, stok.lAzamiMiktar, stok.sModel, tbRenk.sRenkAdi FROM tbStok stok INNER JOIN tbStokBarkodu barkod ON stok.nStokID = barkod.nStokID LEFT OUTER JOIN tbRenk ON stok.sRenk = tbRenk.sRenk " & kriter & " GROUP BY stok.nStokID, barkod.sBarkod, stok.sKodu, stok.sKisaAdi,stok.sAciklama, stok.sRenk, stok.sBeden, stok.lAsgariMiktar, stok.lAzamiMiktar, stok.sModel, tbRenk.sRenkAdi")
            qr_hareket.Query = sorgu_query("set transaction isolation level read uncommitted SELECT PESIN = CASE WHEN FIYAT <>0 THEN FIYAT ELSE FIYAT1 END,* FROM (SELECT (SELECT isnull(lfiyat , 0) FROM tbstokfiyati WHERE nStokId = stok.NstokId AND sFiyatTipi = '" & sFiyat1 & "') AS FIYAT1, (SELECT isnull(lfiyat , 0) FROM tbstokfiyati WHERE nStokId = stok.NstokId AND sFiyatTipi = '" & sFiyat3 & "') AS ONAY, (SELECT isnull(lfiyat , 0) FROM tbstokfiyati WHERE nStokId = stok.NstokId AND sFiyatTipi = '" & sFiyat2 & "') AS ALTIAY,(SELECT isnull(lfiyat , 0) FROM tbstokfiyati WHERE nStokId = stok.NstokId AND sFiyatTipi = '" & sFiyat4 & "') AS FIYAT4, (SELECT isnull(lfiyat , 0) FROM tbstokfiyati WHERE nStokId = stok.NstokId AND sFiyatTipi = '" & sAktifFiyatTipi & "') AS FIYAT,ISNULL((SELECT ISNULL(lOran , 1) FROM tbStokBirimCevrimi WHERE nStokID = Stok.nStokID AND sBirimCinsi = Stok.sBirimCinsi2), 1) AS lBirimCarpan,barkod.sBarkod, stok.nStokID,stok.sOzelNot,stok.sKodu AS STOKKODU, stok.sAciklama AS STOKADI,stok.sKisaAdi, stok.sKavala,stok.sRenk, stok.sBeden, stok.nEn, stok.nBoy, stok.nYukseklik, stok.nHacim, stok.nAgirlik,stok.lAsgariMiktar, stok.lAzamiMiktar, stok.sModel, tbRenk.sRenkAdi,stok.sBirimCinsi1,(SELECT     nKdvOrani FROM         tbKdv Where sKdvTipi = Stok.sKdvTipi) as nKdvOrani,tbStokAciklama.sAciklama1, tbStokAciklama.sAciklama2, tbStokAciklama.sAciklama3, tbStokAciklama.sAciklama4, tbStokAciklama.sAciklama5,tbStokAciklama.sAciklama6, tbStokAciklama.sAciklama7, tbStokAciklama.sAciklama8, tbStokAciklama.sAciklama9, tbStokAciklama.sAciklama10 FROM tbStok stok INNER JOIN tbStokBarkodu barkod ON stok.nStokID = barkod.nStokID AND barkod.nKisim = 0 LEFT OUTER JOIN tbStokAciklama ON stok.nStokID = tbStokAciklama.nStokID LEFT OUTER JOIN tbRenk ON stok.sRenk = tbRenk.sRenk " & kriter & " ) tbStok ")
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
            args(2) = "" & sorgu_query("set transaction isolation level read uncommitted SELECT PESIN = CASE WHEN FIYAT <>0 THEN FIYAT ELSE FIYAT1 END,* FROM (SELECT (SELECT isnull(lfiyat , 0) FROM tbstokfiyati WHERE nStokId = stok.NstokId AND sFiyatTipi = '" & sFiyat1 & "') AS FIYAT1, (SELECT isnull(lfiyat , 0) FROM tbstokfiyati WHERE nStokId = stok.NstokId AND sFiyatTipi = '" & sFiyat3 & "') AS ONAY, (SELECT isnull(lfiyat , 0) FROM tbstokfiyati WHERE nStokId = stok.NstokId AND sFiyatTipi = '" & sFiyat2 & "') AS ALTIAY,(SELECT isnull(lfiyat , 0) FROM tbstokfiyati WHERE nStokId = stok.NstokId AND sFiyatTipi = '" & sFiyat4 & "') AS FIYAT4, (SELECT isnull(lfiyat , 0) FROM tbstokfiyati WHERE nStokId = stok.NstokId AND sFiyatTipi = '" & sAktifFiyatTipi & "') AS FIYAT,ISNULL((SELECT ISNULL(lOran , 1) FROM tbStokBirimCevrimi WHERE nStokID = Stok.nStokID AND sBirimCinsi = Stok.sBirimCinsi2), 1) AS lBirimCarpan,barkod.sBarkod, stok.nStokID,stok.sOzelNot,stok.sKodu AS STOKKODU, stok.sAciklama AS STOKADI,stok.sKisaAdi, stok.sKavala,stok.sRenk, stok.sBeden, stok.nEn, stok.nBoy, stok.nYukseklik, stok.nHacim, stok.nAgirlik,stok.lAsgariMiktar, stok.lAzamiMiktar, stok.sModel, tbRenk.sRenkAdi,stok.sBirimCinsi1,(SELECT     nKdvOrani FROM         tbKdv Where sKdvTipi = Stok.sKdvTipi) as nKdvOrani,tbStokAciklama.sAciklama1, tbStokAciklama.sAciklama2, tbStokAciklama.sAciklama3, tbStokAciklama.sAciklama4, tbStokAciklama.sAciklama5,tbStokAciklama.sAciklama6, tbStokAciklama.sAciklama7, tbStokAciklama.sAciklama8, tbStokAciklama.sAciklama9, tbStokAciklama.sAciklama10 FROM tbStok stok INNER JOIN tbStokBarkodu barkod ON stok.nStokID = barkod.nStokID AND barkod.nKisim = 0 LEFT OUTER JOIN tbStokAciklama ON stok.nStokID = tbStokAciklama.nStokID LEFT OUTER JOIN tbRenk ON stok.sRenk = tbRenk.sRenk " & kriter & " ) tbStok ") & ""
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
            args(15) = "" & fiyat1.ToString() & ""
            args(16) = "FIYAT2"
            args(17) = "" & fiyat2.ToString() & ""
            args(18) = "FIYAT3"
            args(19) = "" & fiyat3.ToString() & ""
            args(20) = "FIYAT"
            args(21) = "'" & fiyat_gizle_tumu(FormatNumber(fiyat1, 2), FormatNumber(fiyat2, 2), FormatNumber(fiyat3, 2)).ToString() & "'"
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
    Private Sub analiz_envanter()
        If GridView1.RowCount > 0 Then
            Dim dr As DataRow = GridView1.GetDataRow(GridView1.FocusedRowHandle)
            Dim frm As New frm_stok_envanter
            frm.firmano = firmano
            frm.donemno = donemno
            frm.connection = connection
            frm.stokno = dr("nStokID")
            frm.stokkodu = dr("sKodu")
            frm.kullanici = kullanici
            If yetki_kontrol(kullanici, frm.Name) = True Then
                frm.ShowDialog()
            End If
            frm.Close()
            frm.Dispose()
            frm = Nothing
            dr = Nothing
        End If
    End Sub
    Private Sub analiz_hareket_transfer()
        If GridView1.RowCount > 0 Then
            Dim dr As DataRow = GridView1.GetDataRow(GridView1.FocusedRowHandle)
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
            dr = Nothing
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
            frm.Label1.Text = dr("sAciklama")
            frm.kullanici = kullanici
            If yetki_kontrol(kullanici, frm.Name) = True Then
                frm.ShowDialog()
            End If
            frm.Close()
            frm.Dispose()
            frm = Nothing
            dr = Nothing
        End If
    End Sub
    Private Sub analiz_envanter_model()
        If GridView1.RowCount > 0 Then
            Dim dr As DataRow = GridView1.GetDataRow(GridView1.FocusedRowHandle)
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
            dr = Nothing
        End If
    End Sub
    Private Sub stok_fiyat()
        If GridView1.RowCount > 0 Then
            Dim dr As DataRow = GridView1.GetDataRow(GridView1.FocusedRowHandle)
            Dim frm As New frm_stok_fiyatlandir
            frm.firmano = firmano
            frm.donemno = donemno
            frm.connection = connection
            frm.nStokID = dr("nStokID")
            frm.sModel = dr("sModel")
            frm.sKodu = dr("sKodu")
            frm.txt_musteriNo.Text = dr("sModel")
            frm.kullanici = kullanici
            If yetki_kontrol(kullanici, frm.Name) = True Then
                frm.ShowDialog()
                dataload_tbStokFiyat(dr("nStokID"))
                Try
                    Dim dr1 As DataRow = ds_stok.Tables(0).Rows(0)
                    dr("nStokID") = dr1("nStokId")
                    dr("sKodu") = dr1("sKodu")
                    dr("sAciklama") = dr1("sAciklama")
                    dr("FIYAT1") = dr1("FIYAT1")
                    dr("FIYAT2") = dr1("FIYAT2")
                    dr("FIYAT3") = dr1("FIYAT3")
                    dr("FIYAT4") = dr1("FIYAT4")
                    dr("FIYAT5") = dr1("FIYAT5")
                    dr("FIYAT6") = dr1("FIYAT6")
                    Try
                        If dr("FIYAT1") <> 0 Then
                            dr("nOran") = ((dr("FIYAT1") - dr("FIYAT4")) / dr("FIYAT4")) * 100
                        Else
                            dr("nOran") = 0
                        End If
                    Catch ex As Exception
                    End Try
                    dr1 = Nothing
                Catch ex As Exception
                End Try
            End If
            frm.Close()
            frm.Dispose()
            frm = Nothing
            dr = Nothing
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
            GridView1.FocusedRowHandle = satir
            satir = Nothing
            frm.Close()
            frm.Dispose()
            frm = Nothing
        End If
    End Sub
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
                    If XtraMessageBox.Show(Sorgu_sDil("Yeni Stok Kartý Açmak Ýster misiniz...?", sDil), Sorgu_sDil("Dikkat", sDil), MessageBoxButtons.YesNo, MessageBoxIcon.Question) = MsgBoxResult.Yes Then
                        stok_yeni()
                    Else
                        txt_ara.Text = frm.sModel
                        stok_kontrol()
                    End If
                End If
            End If
            frm.Close()
            frm.Dispose()
            frm = Nothing
        End If
    End Sub
    Private Sub tbStok_sil(ByVal sModel As String, Optional ByVal uyari As Boolean = True)
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
            cmd.CommandText = sorgu_query("delete tbStokSinifi from tbStok where tbStok.nStokID = tbStokSinifi.nStokID and sModel = '" & sModel & "'")
            cmd.ExecuteNonQuery()
            cmd.CommandText = sorgu_query("delete tbStokBarkodu from tbStok where tbStok.nStokID = tbStokBarkodu.nStokID and sModel = '" & sModel & "'")
            cmd.ExecuteNonQuery()
            cmd.CommandText = sorgu_query("delete tbStokFiyati from tbStok  where tbStok.nStokID = tbStokFiyati.nStokID and sModel = '" & sModel & "'")
            cmd.ExecuteNonQuery()
            cmd.CommandText = sorgu_query("delete tbStokBirimCevrimi from tbStok where tbStok.nStokID = tbStokBirimCevrimi.nStokID and sModel = '" & sModel & "'")
            cmd.ExecuteNonQuery()
            cmd.CommandText = sorgu_query("delete tbStokMuhasebeEntegrasyon from tbStok where tbStok.nStokID = tbStokMuhasebeEntegrasyon.nStokID and sModel = '" & sModel & "'")
            cmd.ExecuteNonQuery()
            cmd.CommandText = sorgu_query("delete tbStokOdemePlani from tbStok  where tbStok.nStokID = tbStokOdemePlani.nStokID and sModel = '" & sModel & "'")
            cmd.ExecuteNonQuery()
            cmd.CommandText = sorgu_query("delete tbStokSayim from tbStok where tbStok.nStokID = tbStokSayim.nStokID and sModel = '" & sModel & "'")
            cmd.ExecuteNonQuery()
            cmd.CommandText = sorgu_query("delete tbStokDil from tbStok where tbStok.nStokID = tbStokDil.nStokID and sModel = '" & sModel & "'")
            cmd.ExecuteNonQuery()
            cmd.CommandText = sorgu_query("delete tbStokAciklama from tbStok where tbStok.nStokID = tbStokAciklama.nStokID and sModel = '" & sModel & "'")
            cmd.ExecuteNonQuery()
            cmd.CommandText = sorgu_query("delete tbStokUzunNot where sModel = '" & sModel & "'")
            cmd.ExecuteNonQuery()
            cmd.CommandText = sorgu_query("delete from tbStokResim where sModel = '" & sModel & "'")
            cmd.ExecuteNonQuery()
            cmd.CommandText = sorgu_query("delete from tbStokMuhasebeEntegrasyon where nStokID IN (Select nStokID from tbStok where sModel = N'" & sModel & "')")
            cmd.ExecuteNonQuery()
            cmd.CommandText = sorgu_query("delete from tbKoliDagilimi where nStokID IN (Select nStokID from tbStok where sModel = N'" & sModel & "')")
            cmd.ExecuteNonQuery()
            cmd.CommandText = sorgu_query("delete tbStok where sModel = '" & sModel & "'")
            cmd.ExecuteNonQuery()
            cmd.CommandText = sorgu_query("IF @@TRANCOUNT > 0 COMMIT TRAN")
            cmd.ExecuteNonQuery()
            'cmd.CommandText = sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT     TOP 1 ISNULL(sModel,'') as sModel FROM         tbStok WHERE     (sModel < '" & sModel & "' ) ORDER BY sModel DESC ")
            'sModel = cmd.ExecuteScalar
            'txt_musteriNo.EditValue = sModel
            If uyari = True Then
                XtraMessageBox.Show(Sorgu_sDil("Kayýt Baþarýyla Silindi...", sDil), Sorgu_sDil("Dikkat", sDil), MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
            'stok_kontrol()
        Catch ex As Exception
            XtraMessageBox.Show(Sorgu_sDil("Üzgünüm,Hareket Görmüþ Kaydý Silemezsiniz...!", sDil), Sorgu_sDil("Dikkat", sDil), MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            cmd.CommandText = sorgu_query("IF @@TRANCOUNT > 0 ROLLBACK TRAN")
            cmd.ExecuteNonQuery()
        End Try
        con.Close()
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
            stok_duzelt()
        ElseIf e.KeyCode = Keys.Down Then
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
            Label2.Text = Sorgu_sDil("Kayýt Sayýsý :", sDil) & GridView1.RowCount & " / " & Sorgu_sDil("Satýr :", sDil) & GridView1.FocusedRowHandle + 1 & " / " & Sorgu_sDil("Seçili :", sDil) & GridView1.SelectedRowsCount
        ElseIf GridView1.SelectedRowsCount = 1 Then
            Label2.Text = Sorgu_sDil("Kayýt Sayýsý :", sDil) & GridView1.RowCount & " / " & Sorgu_sDil("Satýr :", sDil) & GridView1.FocusedRowHandle + 1
        Else
            Label2.Text = ""
        End If
    End Sub
    Private Sub BarButtonItem1_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem1.ItemClick
        stok_yeni()
    End Sub
    Private Sub BarButtonItem2_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem2.ItemClick
        stok_duzelt()
    End Sub
    Private Sub BarButtonItem9_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem9.ItemClick
        stok_fiyat()
    End Sub
    Private Sub BarButtonItem3_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem3.ItemClick
        If GridView1.RowCount > 0 Then
            Dim dr As DataRow = GridView1.GetDataRow(GridView1.FocusedRowHandle)
            If XtraMessageBox.Show(dr("sKodu") & vbCrLf & dr("sAciklama") & vbCrLf & Sorgu_sDil("Kaydý Silmek Ýstediðinize Emin misiniz...?", sDil), Sorgu_sDil("Dikkat", sDil), MessageBoxButtons.YesNo, MessageBoxIcon.Question) = MsgBoxResult.Yes Then
                tbStok_sil(dr("sModel"))
            End If
            dr = Nothing
        End If
    End Sub
    Private Sub BarButtonItem5_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem5.ItemClick
        satir_ekle_stok("")
    End Sub
    Private Sub BarButtonItem7_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem7.ItemClick
        satir_sil()
    End Sub
    Private Sub BarButtonItem8_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem8.ItemClick
        satir_temizle()
    End Sub
    Private Sub BarButtonItem10_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem10.ItemClick
        raporla(0)
    End Sub
    Private Sub BarButtonItem11_ItemClick(ByVal sender As Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem11.ItemClick
        raporla(2)
    End Sub
    Private Sub BarButtonItem12_ItemClick(ByVal sender As Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem12.ItemClick
        raporla(1)
    End Sub
    Private Sub BarButtonItem13_ItemClick(ByVal sender As Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem13.ItemClick
        raporla(3)
    End Sub
    Private Sub BarButtonItem4_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem4.ItemClick
        ara()
    End Sub
    Private Sub YeniStokKartýToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles YeniStokKartýToolStripMenuItem.Click
        stok_yeni()
    End Sub
    Private Sub StokKartýDüzenleToolStripMenuItem_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles StokKartýDüzenleToolStripMenuItem.Click
        stok_duzelt()
    End Sub
    Private Sub StokAraToolStripMenuItem_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles StokAraToolStripMenuItem.Click
        ara()
    End Sub
    Private Sub ListeyiTemizleToolStripMenuItem_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles ListeyiTemizleToolStripMenuItem.Click
        satir_temizle()
    End Sub
    Private Sub SatýrSilToolStripMenuItem_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles SatýrSilToolStripMenuItem.Click
        satir_sil()
    End Sub
    Private Sub FiyatDüzenleToolStripMenuItem_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles FiyatDüzenleToolStripMenuItem.Click
        stok_fiyat()
    End Sub
    Private Sub ÖnizleToolStripMenuItem_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles ÖnizleToolStripMenuItem.Click
        raporla(0)
    End Sub
    Private Sub DizaynToolStripMenuItem_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles DizaynToolStripMenuItem.Click
        raporla(2)
    End Sub
    Private Sub YazdýrToolStripMenuItem_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles YazdýrToolStripMenuItem.Click
        raporla(1)
    End Sub
    Private Sub DirektYazdýrToolStripMenuItem_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles DirektYazdýrToolStripMenuItem.Click
        raporla(3)
    End Sub
    Private Sub YeniSatýrEkleToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles YeniSatýrEkleToolStripMenuItem.Click
        satir_ekle_stok("")
    End Sub
    Private Sub EtiketYazdýrToolStripMenuItem_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles EtiketYazdýrToolStripMenuItem.Click
        etiket_yazdir()
    End Sub
    Private Sub BarButtonItem15_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem15.ItemClick
        Transfer()
    End Sub
    Private Sub BarButtonItem16_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem16.ItemClick
        Entegrasyon()
    End Sub
    Private Sub BarButtonItem17_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem17.ItemClick
        Transfer()
    End Sub
    Private Sub BarButtonItem18_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem18.ItemClick
        siniflandir()
    End Sub
    Private Sub SimpleButton2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SimpleButton2.Click
        Me.Close()
    End Sub
    Private Sub SimpleButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SimpleButton1.Click
        Me.Close()
    End Sub
    Private Sub BarButtonItem19_ItemClick(ByVal sender As Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem19.ItemClick
        fiyatlandir_toplu()
    End Sub
    Private Sub BarButtonItem20_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem20.ItemClick
        GridView1.ColumnsCustomization()
    End Sub
    Private Sub BarButtonItem21_ItemClick(ByVal sender As Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem21.ItemClick
        gorunum_kaydet()
    End Sub
    Private Sub BarButtonItem22_ItemClick(ByVal sender As Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem22.ItemClick
        gorunumu_yazdir()
    End Sub
    Private Sub gorunumu_yazdir()
        printlink1.CreateDocument(ps)
        ps.PreviewRibbonFormEx.Show()
    End Sub
    Private Sub BarButtonItem23_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem23.ItemClick
        If GridView1.OptionsView.ShowAutoFilterRow = False Then
            GridView1.OptionsView.ShowAutoFilterRow = True
            GridView1.OptionsView.ShowFilterPanelMode = DevExpress.XtraGrid.Views.Base.ShowFilterPanelMode.Default
            GridView1.OptionsCustomization.AllowFilter = True
            BarButtonItem23.Down = True
        ElseIf GridView1.OptionsView.ShowAutoFilterRow = True Then
            GridView1.OptionsView.ShowAutoFilterRow = False
            GridView1.OptionsView.ShowFilterPanelMode = DevExpress.XtraGrid.Views.Base.ShowFilterPanelMode.Never
            GridView1.OptionsCustomization.AllowFilter = False
            BarButtonItem23.Down = False
        End If
    End Sub
    Private Sub BarButtonItem24_ItemClick(ByVal sender As Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem24.ItemClick
        If BarButtonItem24.Down = False Then
            GridView1.OptionsView.ShowFilterPanelMode = DevExpress.XtraGrid.Views.Base.ShowFilterPanelMode.Default
            GridView1.OptionsCustomization.AllowFilter = True
            BarButtonItem24.Down = True
        ElseIf BarButtonItem24.Down = True Then
            GridView1.OptionsView.ShowFilterPanelMode = DevExpress.XtraGrid.Views.Base.ShowFilterPanelMode.Never
            GridView1.OptionsCustomization.AllowFilter = False
            BarButtonItem24.Down = False
        End If
    End Sub
    Private Sub BarButtonItem25_ItemClick(ByVal sender As Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem25.ItemClick
        If GridView1.OptionsView.ShowGroupPanel = False Then
            GridView1.OptionsView.ShowGroupPanel = True
            GridView1.OptionsCustomization.AllowGroup = True
            BarButtonItem25.Down = True
        ElseIf GridView1.OptionsView.ShowGroupPanel = True Then
            GridView1.OptionsView.ShowGroupPanel = False
            GridView1.OptionsCustomization.AllowGroup = False
            BarButtonItem25.Down = False
        End If
    End Sub
    Private Sub BarButtonItem26_ItemClick(ByVal sender As Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem26.ItemClick
        GridView1.ExpandAllGroups()
    End Sub
    Private Sub BarButtonItem27_ItemClick(ByVal sender As Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem27.ItemClick
        GridView1.CollapseAllGroups()
    End Sub
    Private Sub BarButtonItem28_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem28.ItemClick
        sKdvTipi_toplu()
    End Sub
    Private Sub BarButtonItem29_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem29.ItemClick
        If GridView1.RowCount > 0 Then
            Dim dr As DataRow = GridView1.GetDataRow(GridView1.FocusedRowHandle)
            If XtraMessageBox.Show(Sorgu_sDil("Seçili Kayýtlarý Silmek Ýstediðinize Emin misiniz...?", sDil), Sorgu_sDil("Dikkat", sDil), MessageBoxButtons.YesNo, MessageBoxIcon.Question) = MsgBoxResult.Yes Then
                bar.Properties.Maximum = GridView1.RowCount
                panelstatus.Visible = True
                bar.Visible = True
                bar.Position = 0
                For Each dr In DataSet1.Tables(0).Rows
                    tbStok_sil(dr("sModel"), False)
                    bar.Position += 1
                    bar.Refresh()
                Next
                DataSet1.Clear()
                XtraMessageBox.Show(Sorgu_sDil("Ýþlem Baþarýyla Tamamlandý...", sDil), Sorgu_sDil("Dikkat", sDil), MessageBoxButtons.OK, MessageBoxIcon.Information)
                dr = Nothing
                panelstatus.Visible = False
                bar.Visible = False
            End If
            dr = Nothing
        End If
    End Sub
    Private Sub BarButtonItem30_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem30.ItemClick
        adlandir()
    End Sub
    Private Sub GridControl1_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles GridControl1.DoubleClick
        stok_duzelt()
    End Sub
    Private Sub GridControl1_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles GridControl1.KeyDown
        If e.KeyCode = Keys.Escape Then
            Me.Close()
        End If
    End Sub
    Private Sub TümünüSecToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TümünüSecToolStripMenuItem.Click
        GridView1.SelectAll()
    End Sub
    Private Sub BarButtonItem31_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem31.ItemClick
        GridView1.SelectAll()
    End Sub
    Private Sub BarButtonItem32_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem32.ItemClick
        tbStokMetraj()
    End Sub
    Private Sub BarButtonItem33_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem33.ItemClick
        If XtraMessageBox.Show(Sorgu_sDil("Sonuçlarý Excel Dosyasý Oluþturmak Ýstediðinize Emin misiniz...?", sDil), Sorgu_sDil("Dikkat", sDil), MessageBoxButtons.YesNo, MessageBoxIcon.Question) = MsgBoxResult.Yes Then
            SaveFileDialog1.Filter = "Excel Dosyalarý(*.xls) |*.xls"
            SaveFileDialog1.InitialDirectory = "c:\"
            SaveFileDialog1.FileName = "eticaret.xls"
            If SaveFileDialog1.ShowDialog = Windows.Forms.DialogResult.OK Then
                GridView1.ExportToXls(SaveFileDialog1.FileName.ToString)
            End If
        End If
    End Sub
    Private Sub BarButtonItem34_ItemClick(ByVal sender As Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem34.ItemClick
        If XtraMessageBox.Show(Sorgu_sDil("Sonuçlarý Text Dosyasý Oluþturmak Ýstediðinize Emin misiniz...?", sDil), Sorgu_sDil("Dikkat", sDil), MessageBoxButtons.YesNo, MessageBoxIcon.Question) = MsgBoxResult.Yes Then
            SaveFileDialog1.Filter = "Text Dosyalarý(*.txt) |*.txt"
            SaveFileDialog1.InitialDirectory = "c:\"
            SaveFileDialog1.FileName = "eticaret.txt"
            If SaveFileDialog1.ShowDialog = Windows.Forms.DialogResult.OK Then
                GridView1.ExportToXls(SaveFileDialog1.FileName.ToString)
            End If
        End If
    End Sub
    Private Sub SimpleButton4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        ara()
    End Sub
    Private Sub BarButtonItem35_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem35.ItemClick
        If XtraMessageBox.Show(Sorgu_sDil("Sonuçlarý Excel Dosyasý Oluþturmak Ýstediðinize Emin misiniz...?", sDil), Sorgu_sDil("Dikkat", sDil), MessageBoxButtons.YesNo, MessageBoxIcon.Question) = MsgBoxResult.Yes Then
            SaveFileDialog1.Filter = "Excel Dosyalarý(*.xls) |*.xls"
            SaveFileDialog1.InitialDirectory = "c:\"
            SaveFileDialog1.FileName = "eticaret.xls"
            If SaveFileDialog1.ShowDialog = Windows.Forms.DialogResult.OK Then
                GridView1.ExportToXls(SaveFileDialog1.FileName.ToString)
            End If
        End If
    End Sub
    Private Sub BarButtonItem36_ItemClick(ByVal sender As Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem36.ItemClick
        If XtraMessageBox.Show(Sorgu_sDil("Sonuçlarý Text Dosyasý Oluþturmak Ýstediðinize Emin misiniz...?", sDil), Sorgu_sDil("Dikkat", sDil), MessageBoxButtons.YesNo, MessageBoxIcon.Question) = MsgBoxResult.Yes Then
            SaveFileDialog1.Filter = "Text Dosyalarý(*.txt) |*.txt"
            SaveFileDialog1.InitialDirectory = "c:\"
            SaveFileDialog1.FileName = "eticaret.txt"
            If SaveFileDialog1.ShowDialog = Windows.Forms.DialogResult.OK Then
                GridView1.ExportToXls(SaveFileDialog1.FileName.ToString)
            End If
        End If
    End Sub
    Private Sub SimpleButton5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SimpleButton5.Click
        Label2.Text = Sorgu_sDil("Lütfen Bekleyiniz...", sDil)
        Label2.Refresh()
        Cursor.Current = Cursors.WaitCursor
        Cursor.Show()
        dataload(txt_sStokAra.Text, sec_konum.Text, sec_StokKriter.Text, txt_dteFisTarihi1.EditValue, txt_dteFisTarihi2.EditValue, Trim(sec_sFiyatTipi.EditValue.ToString), sec_sKriter.Text, "STOKKODU")
        Label2.Text = Sorgu_sDil("Tamamlandý...", sDil)
        Cursor.Current = Cursors.Default
        Cursor.Hide()
    End Sub
    Private Sub btnAra_ItemClick(ByVal sender As Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnAra.ItemClick
        ara()
    End Sub
    Private Sub BarButtonItem37_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnStokYeni.ItemClick
        stok_yeni("")
    End Sub
    Private Sub btnStokSil_ItemClick(ByVal sender As Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnStokSil.ItemClick
    End Sub
    Private Sub btnStokDuzelt_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnStokDuzelt.ItemClick
        stok_duzelt()
    End Sub
    Private Sub btnFiyatDuzelt_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnFiyatDuzelt.ItemClick
        stok_fiyat()
    End Sub
    Private Sub btnSatirEkle_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnSatirEkle.ItemClick
        satir_ekle_stok("")
    End Sub
    Private Sub btnSatirSil_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnSatirSil.ItemClick
        satir_sil()
    End Sub
    Private Sub btnSecTumu_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnSecTumu.ItemClick
        GridView1.SelectAll()
    End Sub
    Private Sub btnSatirSilTumu_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnSatirSilTumu.ItemClick
        satir_temizle()
    End Sub
    Private Sub BarButtonItem44_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnEtiketYazdir.ItemClick
        etiket_yazdir()
    End Sub
    Private Sub btnRaporla_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnRaporla.ItemClick
        raporla(0)
    End Sub
    Private Sub BarButtonItem37_ItemClick_1(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem37.ItemClick
        frm_eticaret_yardim.ShowDialog()
    End Sub
    Private Sub fatura_import_txt()
        Dim frm As New frm_fatura_import_txt
        frm.firmano = firmano
        frm.donemno = donemno
        frm.connection = connection
        frm.kullanici = kullanici
        Dim bImport As Boolean = True
        Dim bIFiyati As Decimal = 0
        Dim bITutari As Decimal = 0
        Dim bImport_Fiyat As Decimal = 0
        Dim bImport_Tutari As Decimal = 0
        If frm.ShowDialog = Windows.Forms.DialogResult.OK Then
            Dim ds_imports As New DataSet
            ds_imports = sorgu_imports(kullanici)
            Dim dri As DataRow
            For Each dri In ds_imports.Tables(0).Rows
                If dri("sKodu") <> "" Then
                    txt_ara.Text = Trim(dri("sKodu"))
                ElseIf dri("sBarkod") <> "" Then
                    txt_ara.Text = Trim(dri("sBarkod"))
                End If
                If dri("lMiktar") <> 0 Then
                    bImport = True
                    bIFiyati = dri("lFiyat")
                    bITutari = dri("lTutar")
                    If frm.txt_lFiyati_Sutun.Text <> -1 Then
                        bImport_Fiyat = True
                    End If
                    If frm.txt_lTutari_Sutun.Text <> -1 Then
                        bImport_Tutari = True
                    End If
                    mevcut = dri("lMiktar")
                    stok_kontrol()
                End If
            Next
        End If
    End Sub
    Private Function sorgu_imports(ByVal sKullanici As String) As DataSet
        Dim cmd As New OleDb.OleDbCommand
        Dim con As New OleDb.OleDbConnection
        Dim adapter As New OleDb.OleDbDataAdapter
        con.ConnectionString = connection
        adapter.SelectCommand = cmd
        cmd.CommandText = sorgu_query("SET DATEFORMAT DMY SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT     * FROM         tbFaturaImportTxt WHERE     (sKullanici = '" & sKullanici & "')")
        sorgu_txt_hareket = cmd.CommandText
        cmd.Connection = con
        con.Open()
        Dim DS As New DataSet
        Dim N As Integer = adapter.Fill(DS, "Imports")
        con.Close()
        cmd = Nothing
        con = Nothing
        Return DS
    End Function
    Private Sub BarButtonItem38_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem38.ItemClick
        fatura_import_txt()
    End Sub
    Private Sub BarButtonItem39_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem39.ItemClick
        If XtraMessageBox.Show(Sorgu_sDil("Hediye Fiyatý Tanýmlanmamýþ Stoklara Hediye Fiyatý Tanýmlamak Ýstediðinize Emin misiniz...?", sDil), Sorgu_sDil("Dikkat", sDil), MessageBoxButtons.YesNo, MessageBoxIcon.Question) = MsgBoxResult.Yes Then
            If yetki_kontrol(kullanici, "Frm_HediyeFiyatlariTanimla") = True Then
                Dim ds_HediyeFiyati As DataSet
                ds_HediyeFiyati = sorgu(sorgu_query("SELECT     nStokID,sKodu,sModel,sRenk,sBeden,nFiyatlandirma FROM         tbStok WHERE     (nStokID NOT IN                           (SELECT     nStokID                             FROM          tbStokFiyati                             WHERE      sFiyatTipi = 'HD'))"))
                Dim dr As DataRow
                bar.Properties.Maximum = ds_HediyeFiyati.Tables(0).Rows.Count
                panelstatus.Visible = True
                bar.Visible = True
                bar.Position = 0
                For Each dr In ds_HediyeFiyati.Tables(0).Rows
                    tbStokFiyati_ekle_yeni(dr("nFiyatlandirma"), dr("sModel"), dr("sRenk"), dr("sBeden"), "HD", 0.01, "01/01/1900")
                    bar.Position += 1
                    bar.Refresh()
                Next
                dr = Nothing
                ds_HediyeFiyati = Nothing
                panelstatus.Visible = False
                bar.Visible = False
                XtraMessageBox.Show(Sorgu_sDil("Ýþlem Baþarýyla Tamamlandý...!", sDil), Sorgu_sDil("Dikkat", sDil), MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        End If
    End Sub
    Private Sub lbl_sAktifFiyatTipi_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lbl_sAktifFiyatTipi.Click
        sAktifFiyatTipi_Toplu()
    End Sub
    Private Sub Sil()
        Dim cmd1 As New OleDb.OleDbCommand
        Dim con1 As New OleDb.OleDbConnection
        con1.ConnectionString = connection
        If con1.State = ConnectionState.Closed Then
            cmd1.Connection = con1
            con1.Open()
        End If
        cmd1.CommandText = "DELETE FROM tbStokEticaret "
        cmd1.ExecuteNonQuery()
        cmd1.CommandText = "DELETE FROM tbESiparisDetay "
        cmd1.ExecuteNonQuery()
        cmd1.CommandText = "DELETE FROM tbESiparisListe "
        cmd1.ExecuteNonQuery()
        con1.Close()
    End Sub
    Public Sub jsonRequest()
        Dim cmd1 As New OleDb.OleDbCommand
        Dim con1 As New OleDb.OleDbConnection
        Dim Url As String = ""
        Dim ProductUpdate As String = ""
        Dim ApiKey As String = ""
        Dim ApiSecret As String = ""
        Dim s As String
        Dim arr = GridView1.RowCount
        Dim i As Integer
        Dim TOPLAM = arr
        i = 0
        Dim Renk1 = ""
        Dim Renk2 = ""
        Dim Renk3 = ""
        Dim Renk4 = ""
        Dim Renk5 = ""
        Dim Renk6 = ""
        Dim Renk7 = ""
        Dim Renk8 = ""
        Dim Renk9 = ""
        Dim Renk10 = ""
        Dim Renk11 = ""
        Dim Renk12 = ""
        Dim Renk13 = ""
        Dim Renk14 = ""
        Dim Renk15 = ""
        Dim Renk16 = ""
        Dim Renk17 = ""
        Dim Renk18 = ""
        Dim Renk19 = ""
        Dim Renk20 = ""
        Dim Renk21 = ""
        Dim Renk22 = ""
        Dim Renk23 = ""
        Dim Renk24 = ""
        Dim Renk25 = ""
        Dim Renk26 = ""
        Dim Renk27 = ""
        Dim Renk28 = ""
        Dim Renk29 = ""
        Dim Renk30 = ""
        Dim Renk31 = ""
        Dim Renk32 = ""
        Dim Renk33 = ""
        Dim Renk34 = ""
        Dim Renk35 = ""
        Dim Renk36 = ""
        Dim Renk37 = ""
        Dim Renk38 = ""
        Dim Renk39 = ""
        Dim Renk40 = ""
        Dim Renk41 = ""
        Dim Renk42 = ""
        Dim Renk43 = ""
        Dim Renk44 = ""
        Dim Renk45 = ""
        Dim Renk46 = ""
        Dim Renk47 = ""
        Dim Renk48 = ""
        Dim Renk49 = ""
        Dim Renk50 = ""
        Dim Renk51 = ""
        Dim Renk52 = ""
        Dim Renk53 = ""
        Dim Renk54 = ""
        Dim Renk55 = ""
        Dim Renk56 = ""
        Dim Renk57 = ""
        Dim Renk58 = ""
        Dim Renk59 = ""
        Dim Renk60 = ""
        Dim Beden1 = ""
        Dim Beden2 = ""
        Dim Beden3 = ""
        Dim Beden4 = ""
        Dim Beden5 = ""
        Dim Beden6 = ""
        Dim Beden7 = ""
        Dim Beden8 = ""
        Dim Beden9 = ""
        Dim Beden10 = ""
        Dim Beden11 = ""
        Dim Beden12 = ""
        Dim Beden13 = ""
        Dim Beden14 = ""
        Dim Beden15 = ""
        Dim Beden16 = ""
        Dim Beden17 = ""
        Dim Beden18 = ""
        Dim Beden19 = ""
        Dim Beden20 = ""
        Dim Beden21 = ""
        Dim Beden22 = ""
        Dim Beden23 = ""
        Dim Beden24 = ""
        Dim Beden25 = ""
        Dim Beden26 = ""
        Dim Beden27 = ""
        Dim Beden28 = ""
        Dim Beden29 = ""
        Dim Beden30 = ""
        Dim Beden31 = ""
        Dim Beden32 = ""
        Dim Beden33 = ""
        Dim Beden34 = ""
        Dim Beden35 = ""
        Dim Beden36 = ""
        Dim Beden37 = ""
        Dim Beden38 = ""
        Dim Beden39 = ""
        Dim Beden40 = ""
        Dim Beden41 = ""
        Dim Beden42 = ""
        Dim Beden43 = ""
        Dim Beden44 = ""
        Dim Beden45 = ""
        Dim Beden46 = ""
        Dim Beden47 = ""
        Dim Beden48 = ""
        Dim Beden49 = ""
        Dim Beden50 = ""
        Dim Beden51 = ""
        Dim Beden52 = ""
        Dim Beden53 = ""
        Dim Beden54 = ""
        Dim Beden55 = ""
        Dim Beden56 = ""
        Dim Beden57 = ""
        Dim Beden58 = ""
        Dim Beden59 = ""
        Dim Beden60 = ""
        Dim barcode1 = ""
        Dim barcode2 = ""
        Dim barcode3 = ""
        Dim barcode4 = ""
        Dim barcode5 = ""
        Dim barcode6 = ""
        Dim barcode7 = ""
        Dim barcode8 = ""
        Dim barcode9 = ""
        Dim barcode10 = ""
        Dim barcode11 = ""
        Dim barcode12 = ""
        Dim barcode13 = ""
        Dim barcode14 = ""
        Dim barcode15 = ""
        Dim barcode16 = ""
        Dim barcode17 = ""
        Dim barcode18 = ""
        Dim barcode19 = ""
        Dim barcode20 = ""
        Dim barcode21 = ""
        Dim barcode22 = ""
        Dim barcode23 = ""
        Dim barcode24 = ""
        Dim barcode25 = ""
        Dim barcode26 = ""
        Dim barcode27 = ""
        Dim barcode28 = ""
        Dim barcode29 = ""
        Dim barcode30 = ""
        Dim barcode31 = ""
        Dim barcode32 = ""
        Dim barcode33 = ""
        Dim barcode34 = ""
        Dim barcode35 = ""
        Dim barcode36 = ""
        Dim barcode37 = ""
        Dim barcode38 = ""
        Dim barcode39 = ""
        Dim barcode40 = ""
        Dim barcode41 = ""
        Dim barcode42 = ""
        Dim barcode43 = ""
        Dim barcode44 = ""
        Dim barcode45 = ""
        Dim barcode46 = ""
        Dim barcode47 = ""
        Dim barcode48 = ""
        Dim barcode49 = ""
        Dim barcode50 = ""
        Dim barcode51 = ""
        Dim barcode52 = ""
        Dim barcode53 = ""
        Dim barcode54 = ""
        Dim barcode55 = ""
        Dim barcode56 = ""
        Dim barcode57 = ""
        Dim barcode58 = ""
        Dim barcode59 = ""
        Dim barcode60 = ""
        Dim barcode = "0"
        Dim name = ""
        Dim invoiceName = ""
        Dim status = ""
        Dim shortDescription = ""
        Dim brand = ""
        Dim category1 = ""
        Dim category2 = ""
        Dim category3 = ""
        Dim category4 = ""
        Dim category5 = ""
        Dim longDescription As String = "0"
        Dim seoTitle = ""
        Dim seoKeywords = ""
        Dim seoDescription As String = ""
        Dim taxRate = ""
        'Dim shipmentPayment = dr("Kargo")
        Dim buyPrice = ""
        Dim listPrice = ""
        Dim salePrice = ""
        Dim quantity = ""
        Dim variant1Name = "Renk"
        Dim variant2Name = "Beden"
        Dim imageUrl = ""
        Dim imageUrl1 = ""
        Dim imageUrl2 = ""
        Dim imageUrl3 = ""
        Dim imageUrl4 = ""
        Dim imageUrl5 = ""
        Dim imageUrl6 = ""
        Dim imageUrl7 = ""
        Dim imageUrl8 = ""
        Dim imageUrl9 = ""
        Dim imageUrl10 = ""
        Dim xx = ""
        Dim priceStatus = 0
        Dim price = 0
        Dim TysalePrice = ""
        Dim N11salePrice = ""
        Dim GgsalePrice = ""
        Dim HbsalePrice = ""
        Dim CssalePrice = ""
        Dim EpttsalePrice = ""
        Dim AmzsalePrice = ""
        Dim quantity1 As Decimal = -9999
        Dim quantity2 As Decimal = -9999
        Dim quantity3 As Decimal = -9999
        Dim quantity4 As Decimal = -9999
        Dim quantity5 As Decimal = -9999
        Dim quantity6 As Decimal = -9999
        Dim quantity7 As Decimal = -9999
        Dim quantity8 As Decimal = -9999
        Dim quantity9 As Decimal = -9999
        Dim quantity10 As Decimal = -9999
        Dim quantity11 As Decimal = -9999
        Dim quantity12 As Decimal = -9999
        Dim quantity13 As Decimal = -9999
        Dim quantity14 As Decimal = -9999
        Dim quantity15 As Decimal = -9999
        Dim quantity16 As Decimal = -9999
        Dim quantity17 As Decimal = -9999
        Dim quantity18 As Decimal = -9999
        Dim quantity19 As Decimal = -9999
        Dim quantity20 As Decimal = -9999
        Dim quantity21 As Decimal = -9999
        Dim quantity22 As Decimal = -9999
        Dim quantity23 As Decimal = -9999
        Dim quantity24 As Decimal = -9999
        Dim quantity25 As Decimal = -9999
        Dim quantity26 As Decimal = -9999
        Dim quantity27 As Decimal = -9999
        Dim quantity28 As Decimal = -9999
        Dim quantity29 As Decimal = -9999
        Dim quantity30 As Decimal = -9999
        Dim quantity31 As Decimal = -9999
        Dim quantity32 As Decimal = -9999
        Dim quantity33 As Decimal = -9999
        Dim quantity34 As Decimal = -9999
        Dim quantity35 As Decimal = -9999
        Dim quantity36 As Decimal = -9999
        Dim quantity37 As Decimal = -9999
        Dim quantity38 As Decimal = -9999
        Dim quantity39 As Decimal = -9999
        Dim quantity40 As Decimal = -9999
        Dim quantity41 As Decimal = -9999
        Dim quantity42 As Decimal = -9999
        Dim quantity43 As Decimal = -9999
        Dim quantity44 As Decimal = -9999
        Dim quantity45 As Decimal = -9999
        Dim quantity46 As Decimal = -9999
        Dim quantity47 As Decimal = -9999
        Dim quantity48 As Decimal = -9999
        Dim quantity49 As Decimal = -9999
        Dim quantity50 As Decimal = -9999
        Dim quantity51 As Decimal = -9999
        Dim quantity52 As Decimal = -9999
        Dim quantity53 As Decimal = -9999
        Dim quantity54 As Decimal = -9999
        Dim quantity55 As Decimal = -9999
        Dim quantity56 As Decimal = -9999
        Dim quantity57 As Decimal = -9999
        Dim quantity58 As Decimal = -9999
        Dim quantity59 As Decimal = -9999
        Dim quantity60 As Decimal = -9999
        Dim quantitys As Decimal = 0
        Dim Renk As String = ""
        Dim RenkVal As String = ""
        Dim Beden As String = ""
        Dim BedenVal As String = ""
        Dim Barkod As String = ""
        Dim BarkodVal As String = ""
        Dim quantityVal As String = ""
        Dim quantitysVal As String = ""
        Dim Fiyat As String = ""
        'con1.ConnectionString = connection
        'If con1.State = ConnectionState.Closed Then
        '    cmd1.Connection = con1
        '    con1.Open()
        'End If
        'cmd1.CommandText = "DELETE FROM tbStokEticaret "
        'cmd1.ExecuteNonQuery()
        'con1.Close()
        'Dim dr As DataRow = GridView1.GetDataRow(GridView1.FocusedRowHandle)



        For i = 1 To GridView1.RowCount

            Dim dr As DataRow = GridView1.GetDataRow(s)
            Dim code = Trim(dr("sModel"))
            Dim Model = Trim(dr("sKodu"))
            Dim nStokID = Trim(dr("nStokID"))
            Dim Sor As String = ""
            Dim R As String = Trim(dr("sRenkAdi"))
            Dim Bed As String = Trim(dr("sBeden"))
            Dim Bar As String = Trim(dr("sBarkod"))
            Dim Q As String = Trim(dr("Mevcut"))
            Dim Qs As String = Trim(dr("Mevcut"))
            con1.ConnectionString = connection
            If con1.State = ConnectionState.Closed Then
                cmd1.Connection = con1
                con1.Open()
            End If
            cmd1.CommandText = sorgu_queryJson("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT  COUNT (code) FROM tbStokEticaret where code = '" & code & "' ")
            Sor = cmd1.ExecuteScalar.ToString()
            s = i.ToString
            If xx <> code Then
                Renk1 = ""
                Renk2 = ""
                Renk3 = ""
                Renk4 = ""
                Renk5 = ""
                Renk6 = ""
                Renk7 = ""
                Renk8 = ""
                Renk9 = ""
                Renk10 = ""
                Renk11 = ""
                Renk12 = ""
                Renk13 = ""
                Renk14 = ""
                Renk15 = ""
                Renk16 = ""
                Renk17 = ""
                Renk18 = ""
                Renk19 = ""
                Renk20 = ""
                Renk21 = ""
                Renk22 = ""
                Renk23 = ""
                Renk24 = ""
                Renk25 = ""
                Renk26 = ""
                Renk27 = ""
                Renk28 = ""
                Renk29 = ""
                Renk30 = ""
                Renk31 = ""
                Renk32 = ""
                Renk33 = ""
                Renk34 = ""
                Renk35 = ""
                Renk36 = ""
                Renk37 = ""
                Renk38 = ""
                Renk39 = ""
                Renk40 = ""
                Renk41 = ""
                Renk42 = ""
                Renk43 = ""
                Renk44 = ""
                Renk45 = ""
                Renk46 = ""
                Renk47 = ""
                Renk48 = ""
                Renk49 = ""
                Renk50 = ""
                Renk51 = ""
                Renk52 = ""
                Renk53 = ""
                Renk54 = ""
                Renk55 = ""
                Renk56 = ""
                Renk57 = ""
                Renk58 = ""
                Renk59 = ""
                Renk60 = ""
                Beden1 = ""
                Beden2 = ""
                Beden3 = ""
                Beden4 = ""
                Beden5 = ""
                Beden6 = ""
                Beden7 = ""
                Beden8 = ""
                Beden9 = ""
                Beden10 = ""
                Beden11 = ""
                Beden12 = ""
                Beden13 = ""
                Beden14 = ""
                Beden15 = ""
                Beden16 = ""
                Beden17 = ""
                Beden18 = ""
                Beden19 = ""
                Beden20 = ""
                Beden21 = ""
                Beden22 = ""
                Beden23 = ""
                Beden24 = ""
                Beden25 = ""
                Beden26 = ""
                Beden27 = ""
                Beden28 = ""
                Beden29 = ""
                Beden30 = ""
                Beden31 = ""
                Beden32 = ""
                Beden33 = ""
                Beden34 = ""
                Beden35 = ""
                Beden36 = ""
                Beden37 = ""
                Beden38 = ""
                Beden39 = ""
                Beden40 = ""
                Beden41 = ""
                Beden42 = ""
                Beden43 = ""
                Beden44 = ""
                Beden45 = ""
                Beden46 = ""
                Beden47 = ""
                Beden48 = ""
                Beden49 = ""
                Beden50 = ""
                Beden51 = ""
                Beden52 = ""
                Beden53 = ""
                Beden54 = ""
                Beden55 = ""
                Beden56 = ""
                Beden57 = ""
                Beden58 = ""
                Beden59 = ""
                Beden60 = ""
                barcode1 = ""
                barcode2 = ""
                barcode3 = ""
                barcode4 = ""
                barcode5 = ""
                barcode6 = ""
                barcode7 = ""
                barcode8 = ""
                barcode9 = ""
                barcode10 = ""
                barcode11 = ""
                barcode12 = ""
                barcode13 = ""
                barcode14 = ""
                barcode15 = ""
                barcode16 = ""
                barcode17 = ""
                barcode18 = ""
                barcode19 = ""
                barcode20 = ""
                barcode21 = ""
                barcode22 = ""
                barcode23 = ""
                barcode24 = ""
                barcode25 = ""
                barcode26 = ""
                barcode27 = ""
                barcode28 = ""
                barcode29 = ""
                barcode30 = ""
                barcode31 = ""
                barcode32 = ""
                barcode33 = ""
                barcode34 = ""
                barcode35 = ""
                barcode36 = ""
                barcode37 = ""
                barcode38 = ""
                barcode39 = ""
                barcode40 = ""
                barcode41 = ""
                barcode42 = ""
                barcode43 = ""
                barcode44 = ""
                barcode45 = ""
                barcode46 = ""
                barcode47 = ""
                barcode48 = ""
                barcode49 = ""
                barcode50 = ""
                barcode51 = ""
                barcode52 = ""
                barcode53 = ""
                barcode54 = ""
                barcode55 = ""
                barcode56 = ""
                barcode57 = ""
                barcode58 = ""
                barcode59 = ""
                barcode60 = ""
                barcode = "0"
                name = ""
                invoiceName = ""
                status = ""
                shortDescription = ""
                brand = ""
                category1 = ""
                category2 = ""
                category3 = ""
                category4 = ""
                category5 = ""
                longDescription = ""
                seoTitle = ""
                seoKeywords = ""
                seoDescription = ""
                taxRate = ""
                ' shipmentPayment = dr("Kargo")
                buyPrice = ""
                listPrice = ""
                salePrice = ""
                quantity = ""
                variant1Name = "Renk"
                variant2Name = "Beden"
                imageUrl = ""
                imageUrl1 = ""
                imageUrl2 = ""
                imageUrl3 = ""
                imageUrl4 = ""
                imageUrl5 = ""
                imageUrl6 = ""
                imageUrl7 = ""
                imageUrl8 = ""
                imageUrl9 = ""
                imageUrl10 = ""
                xx = ""
                priceStatus = 0
                price = 0
                TysalePrice = ""
                N11salePrice = ""
                GgsalePrice = ""
                HbsalePrice = ""
                CssalePrice = ""
                EpttsalePrice = ""
                AmzsalePrice = ""
                quantity1 = -9999
                quantity2 = -9999
                quantity3 = -9999
                quantity4 = -9999
                quantity5 = -9999
                quantity6 = -9999
                quantity7 = -9999
                quantity8 = -9999
                quantity9 = -9999
                quantity10 = -9999
                quantity11 = -9999
                quantity12 = -9999
                quantity13 = -9999
                quantity14 = -9999
                quantity15 = -9999
                quantity16 = -9999
                quantity17 = -9999
                quantity18 = -9999
                quantity19 = -9999
                quantity20 = -9999
                quantity21 = -9999
                quantity22 = -9999
                quantity23 = -9999
                quantity24 = -9999
                quantity25 = -9999
                quantity26 = -9999
                quantity27 = -9999
                quantity28 = -9999
                quantity29 = -9999
                quantity30 = -9999
                quantity31 = -9999
                quantity32 = -9999
                quantity33 = -9999
                quantity34 = -9999
                quantity35 = -9999
                quantity36 = -9999
                quantity37 = -9999
                quantity38 = -9999
                quantity39 = -9999
                quantity40 = -9999
                quantity41 = -9999
                quantity42 = -9999
                quantity43 = -9999
                quantity44 = -9999
                quantity45 = -9999
                quantity46 = -9999
                quantity47 = -9999
                quantity48 = -9999
                quantity49 = -9999
                quantity50 = -9999
                quantity51 = -9999
                quantity52 = -9999
                quantity53 = -9999
                quantity54 = -9999
                quantity55 = -9999
                quantity56 = -9999
                quantity57 = -9999
                quantity58 = -9999
                quantity59 = -9999
                quantity60 = -9999
                quantitys = 0
                Renk = ""
                RenkVal = ""
                Beden = ""
                BedenVal = ""
                Barkod = ""
                BarkodVal = ""
                quantityVal = ""
                quantitysVal = ""
            End If

            If Sor <= 0 Then
                code = Trim(dr("sModel"))
                name = dr("sAciklama")
                invoiceName = dr("sAciklama")
                status = dr("bWebGoruntule")
                barcode = Trim(dr("sBarkod"))
                shortDescription = dr("sAciklama")
                brand = dr("Sinif4")
                category1 = dr("Sinif3")
                category2 = dr("Sinif2")
                category3 = dr("Sinif6")
                category4 = dr("Sinif5")
                category5 = dr("Sinif6")
                longDescription = Trim(dr("sUzunNot"))
                seoTitle = dr("Sinif3")
                seoKeywords = dr("Sinif3")
                seoDescription = dr("Sinif3")
                taxRate = dr("sKdvTipi")
                ' shipmentPayment = dr("Kargo")
                buyPrice = dr("FIYATA")
                listPrice = dr("WEBK")
                salePrice = dr("WEBP")
                quantity = dr("Mevcut")
                variant1Name = "Renk"
                variant2Name = "Beden"
                imageUrl = dr("Resim1")
                imageUrl1 = dr("Resim2")
                imageUrl2 = dr("Resim3")
                imageUrl3 = dr("Resim4")
                imageUrl4 = dr("Resim5")
                imageUrl5 = dr("Resim6")
                imageUrl6 = dr("Resim7")
                imageUrl7 = dr("Resim8")
                imageUrl8 = dr("Resim9")
                imageUrl9 = dr("Resim10")
                imageUrl10 = dr("Resim11")
                Renk1 = Trim(dr("sRenkAdi"))
                Beden1 = Trim(dr("sBeden"))
                TysalePrice = Trim(dr("TysalePrice"))
                N11salePrice = Trim(dr("N11salePrice"))
                GgsalePrice = Trim(dr("GgsalePrice"))
                HbsalePrice = Trim(dr("HbsalePrice"))
                CssalePrice = (dr("CssalePrice"))
                EpttsalePrice = (dr("EpttsalePrice"))
                AmzsalePrice = (dr("AmzsalePrice"))
                If TysalePrice <= 0 Then
                    TysalePrice = salePrice
                End If
                If N11salePrice <= 0 Then
                    N11salePrice = salePrice
                End If
                If GgsalePrice <= 0 Then
                    GgsalePrice = salePrice
                End If
                If HbsalePrice <= 0 Then
                    HbsalePrice = salePrice
                End If
                If CssalePrice <= 0 Then
                    CssalePrice = salePrice
                End If
                If EpttsalePrice <= 0 Then
                    EpttsalePrice = salePrice
                End If
                If AmzsalePrice <= 0 Then
                    AmzsalePrice = salePrice
                End If
                taxRate = 0
                If taxRate = 1 Then
                    taxRate = 0
                ElseIf taxRate = 2 Then
                    taxRate = 18
                ElseIf taxRate = 3 Then
                    taxRate = 8
                End If
                tbStok_kaydet_Eticaret(nStokID, code, name, Renk1, Beden1, barcode, brand, category1, category2, category3, category4, category5, longDescription, buyPrice, listPrice, salePrice, seoTitle, seoKeywords, taxRate, quantity, seoDescription, variant1Name, variant2Name, imageUrl, imageUrl1, imageUrl2, imageUrl3, imageUrl4, imageUrl5, imageUrl6, imageUrl7, imageUrl8, imageUrl9, imageUrl10, TysalePrice, N11salePrice, GgsalePrice, HbsalePrice, EpttsalePrice, CssalePrice, AmzsalePrice)

            Else
                Dim con As New OleDb.OleDbConnection
                Dim cmd As New OleDb.OleDbCommand
                cmd.Connection = con
                con.ConnectionString = connection
                cmd.CommandTimeout = False
                If con.State = ConnectionState.Closed = True Then
                    con.Open()
                End If

                'cmd.CommandText = "SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT @@identity"
                'Dim kayitno = cmd.ExecuteScalar
                con.Close()
                code = Trim(dr("sModel"))
                xx = Trim(dr("sModel"))
                name = dr("sAciklama")
                invoiceName = dr("sAciklama")
                status = dr("bWebGoruntule")
                barcode = Trim(dr("sBarkod"))
                shortDescription = dr("sAciklama")
                brand = dr("Sinif1")
                category1 = dr("Sinif2")
                category2 = dr("Sinif3")
                category3 = dr("Sinif4")
                category4 = dr("Sinif5")
                longDescription = Trim(dr("sUzunNot"))
                seoTitle = dr("Sinif2")
                seoKeywords = dr("Sinif2")
                seoDescription = dr("Sinif2")
                taxRate = dr("sKdvTipi")
                ' shipmentPayment = dr("Kargo")
                buyPrice = dr("FIYATA")
                listPrice = dr("WEBK")
                salePrice = dr("WEBP")
                quantity = dr("Mevcut")
                variant1Name = "Renk"
                variant2Name = "Beden"
                imageUrl = dr("Resim1")
                imageUrl1 = dr("Resim2")
                imageUrl2 = dr("Resim3")
                imageUrl3 = dr("Resim4")
                imageUrl4 = dr("Resim5")
                imageUrl5 = dr("Resim6")
                imageUrl6 = dr("Resim7")
                imageUrl7 = dr("Resim8")
                imageUrl8 = dr("Resim9")
                imageUrl9 = dr("Resim10")
                imageUrl10 = dr("Resim11")
                Renk1 = Trim(dr("sRenkAdi"))
                Beden1 = Trim(dr("sBeden"))
                taxRate = 0
                If taxRate = 1 Then
                    taxRate = 0
                ElseIf taxRate = 2 Then
                    taxRate = 18
                ElseIf taxRate = 3 Then
                    taxRate = 8
                End If

                If Renk2 = "" Then
                    Renk2 = R
                    Renk = "Renk2"
                    RenkVal = Renk2
                    tbStok_RenkUpdate_Eticaret(code, Renk, RenkVal)
                ElseIf Renk3 = "" Then
                    Renk3 = R
                    Renk = "Renk3"
                    RenkVal = Renk3
                    tbStok_RenkUpdate_Eticaret(code, Renk, RenkVal)
                ElseIf Renk4 = "" Then
                    Renk4 = R
                    Renk = "Renk4"
                    RenkVal = Renk4
                    tbStok_RenkUpdate_Eticaret(code, Renk, RenkVal)
                ElseIf Renk5 = "" Then
                    Renk5 = R
                    Renk = "Renk5"
                    RenkVal = Renk5
                    tbStok_RenkUpdate_Eticaret(code, Renk, RenkVal)
                ElseIf Renk6 = "" Then
                    Renk6 = R
                    Renk = "Renk6"
                    RenkVal = Renk6
                    tbStok_RenkUpdate_Eticaret(code, Renk, RenkVal)
                ElseIf Renk7 = "" Then
                    Renk7 = R
                    Renk = "Renk7"
                    RenkVal = Renk7
                    tbStok_RenkUpdate_Eticaret(code, Renk, RenkVal)
                ElseIf Renk8 = "" Then
                    Renk8 = R
                    Renk = "Renk8"
                    RenkVal = Renk8
                    tbStok_RenkUpdate_Eticaret(code, Renk, RenkVal)
                ElseIf Renk9 = "" Then
                    Renk9 = R
                    Renk = "Renk9"
                    RenkVal = Renk9
                    tbStok_RenkUpdate_Eticaret(code, Renk, RenkVal)
                ElseIf Renk10 = "" Then
                    Renk10 = R
                    Renk = "Renk10"
                    RenkVal = Renk10
                    tbStok_RenkUpdate_Eticaret(code, Renk, RenkVal)
                ElseIf Renk11 = "" Then
                    Renk11 = R
                    Renk = "Renk11"
                    RenkVal = Renk11
                    tbStok_RenkUpdate_Eticaret(code, Renk, RenkVal)
                ElseIf Renk12 = "" Then
                    Renk12 = R
                    Renk = "Renk12"
                    RenkVal = Renk12
                    tbStok_RenkUpdate_Eticaret(code, Renk, RenkVal)
                ElseIf Renk13 = "" Then
                    Renk13 = R
                    Renk = "Renk13"
                    RenkVal = Renk13
                    tbStok_RenkUpdate_Eticaret(code, Renk, RenkVal)
                ElseIf Renk14 = "" Then
                    Renk14 = R
                    Renk = "Renk14"
                    RenkVal = Renk14
                    tbStok_RenkUpdate_Eticaret(code, Renk, RenkVal)
                ElseIf Renk15 = "" Then
                    Renk15 = R
                    Renk = "Renk15"
                    RenkVal = Renk15
                    tbStok_RenkUpdate_Eticaret(code, Renk, RenkVal)
                ElseIf Renk16 = "" Then
                    Renk16 = R
                    Renk = "Renk16"
                    RenkVal = Renk16
                    tbStok_RenkUpdate_Eticaret(code, Renk, RenkVal)
                ElseIf Renk17 = "" Then
                    Renk17 = R
                    Renk = "Renk17"
                    RenkVal = Renk17
                    tbStok_RenkUpdate_Eticaret(code, Renk, RenkVal)
                ElseIf Renk18 = "" Then
                    Renk18 = R
                    Renk = "Renk18"
                    RenkVal = Renk18
                    tbStok_RenkUpdate_Eticaret(code, Renk, RenkVal)
                ElseIf Renk19 = "" Then
                    Renk19 = R
                    Renk = "Renk19"
                    RenkVal = Renk19
                    tbStok_RenkUpdate_Eticaret(code, Renk, RenkVal)
                ElseIf Renk20 = "" Then
                    Renk20 = R
                    Renk = "Renk20"
                    RenkVal = Renk20
                    tbStok_RenkUpdate_Eticaret(code, Renk, RenkVal)
                ElseIf Renk21 = "" Then
                    Renk21 = R
                    Renk = "Renk21"
                    RenkVal = Renk21
                    tbStok_RenkUpdate_Eticaret(code, Renk, RenkVal)
                ElseIf Renk22 = "" Then
                    Renk22 = R
                    Renk = "Renk22"
                    RenkVal = Renk22
                    tbStok_RenkUpdate_Eticaret(code, Renk, RenkVal)
                ElseIf Renk23 = "" Then
                    Renk23 = R
                    Renk = "Renk23"
                    RenkVal = Renk23
                    tbStok_RenkUpdate_Eticaret(code, Renk, RenkVal)
                ElseIf Renk24 = "" Then
                    Renk24 = R
                    Renk = "Renk24"
                    RenkVal = Renk24
                    tbStok_RenkUpdate_Eticaret(code, Renk, RenkVal)
                ElseIf Renk25 = "" Then
                    Renk25 = R
                    Renk = "Renk25"
                    RenkVal = Renk25
                    tbStok_RenkUpdate_Eticaret(code, Renk, RenkVal)
                ElseIf Renk26 = "" Then
                    Renk26 = R
                    Renk = "Renk26"
                    RenkVal = Renk26
                    tbStok_RenkUpdate_Eticaret(code, Renk, RenkVal)
                ElseIf Renk27 = "" Then
                    Renk27 = R
                    Renk = "Renk27"
                    RenkVal = Renk27
                    tbStok_RenkUpdate_Eticaret(code, Renk, RenkVal)
                ElseIf Renk28 = "" Then
                    Renk28 = R
                    Renk = "Renk28"
                    RenkVal = Renk28
                    tbStok_RenkUpdate_Eticaret(code, Renk, RenkVal)
                ElseIf Renk29 = "" Then
                    Renk29 = R
                    Renk = "Renk29"
                    RenkVal = Renk29
                    tbStok_RenkUpdate_Eticaret(code, Renk, RenkVal)
                ElseIf Renk30 = "" Then
                    Renk30 = R
                    Renk = "Renk30"
                    RenkVal = Renk30
                    tbStok_RenkUpdate_Eticaret(code, Renk, RenkVal)
                ElseIf Renk31 = "" Then
                    Renk31 = R
                    Renk = "Renk31"
                    RenkVal = Renk31
                    tbStok_RenkUpdate_Eticaret(code, Renk, RenkVal)
                ElseIf Renk32 = "" Then
                    Renk32 = R
                    Renk = "Renk32"
                    RenkVal = Renk32
                    tbStok_RenkUpdate_Eticaret(code, Renk, RenkVal)
                ElseIf Renk33 = "" Then
                    Renk33 = R
                    Renk = "Renk33"
                    RenkVal = Renk33
                    tbStok_RenkUpdate_Eticaret(code, Renk, RenkVal)
                ElseIf Renk34 = "" Then
                    Renk34 = R
                    Renk = "Renk34"
                    RenkVal = Renk34
                    tbStok_RenkUpdate_Eticaret(code, Renk, RenkVal)
                ElseIf Renk35 = "" Then
                    Renk35 = R
                    Renk = "Renk35"
                    RenkVal = Renk35
                    tbStok_RenkUpdate_Eticaret(code, Renk, RenkVal)
                ElseIf Renk36 = "" Then
                    Renk36 = R
                    Renk = "Renk36"
                    RenkVal = Renk36
                    tbStok_RenkUpdate_Eticaret(code, Renk, RenkVal)
                ElseIf Renk37 = "" Then
                    Renk37 = R
                    Renk = "Renk37"
                    RenkVal = Renk37
                    tbStok_RenkUpdate_Eticaret(code, Renk, RenkVal)
                ElseIf Renk38 = "" Then
                    Renk38 = R
                    Renk = "Renk38"
                    RenkVal = Renk38
                    tbStok_RenkUpdate_Eticaret(code, Renk, RenkVal)
                ElseIf Renk39 = "" Then
                    Renk39 = R
                    Renk = "Renk39"
                    RenkVal = Renk39
                    tbStok_RenkUpdate_Eticaret(code, Renk, RenkVal)
                ElseIf Renk40 = "" Then
                    Renk40 = R
                    Renk = "Renk40"
                    RenkVal = Renk40
                    tbStok_RenkUpdate_Eticaret(code, Renk, RenkVal)
                ElseIf Renk41 = "" Then
                    Renk41 = R
                    Renk = "Renk41"
                    RenkVal = Renk41
                    tbStok_RenkUpdate_Eticaret(code, Renk, RenkVal)
                ElseIf Renk42 = "" Then
                    Renk42 = R
                    Renk = "Renk42"
                    RenkVal = Renk42
                    tbStok_RenkUpdate_Eticaret(code, Renk, RenkVal)
                ElseIf Renk43 = "" Then
                    Renk43 = R
                    Renk = "Renk43"
                    RenkVal = Renk43
                    tbStok_RenkUpdate_Eticaret(code, Renk, RenkVal)
                ElseIf Renk44 = "" Then
                    Renk44 = R
                    Renk = "Renk44"
                    RenkVal = Renk44
                    tbStok_RenkUpdate_Eticaret(code, Renk, RenkVal)
                ElseIf Renk45 = "" Then
                    Renk45 = R
                    Renk = "Renk45"
                    RenkVal = Renk45
                    tbStok_RenkUpdate_Eticaret(code, Renk, RenkVal)
                ElseIf Renk46 = "" Then
                    Renk46 = R
                    Renk = "Renk46"
                    RenkVal = Renk46
                    tbStok_RenkUpdate_Eticaret(code, Renk, RenkVal)
                ElseIf Renk47 = "" Then
                    Renk47 = R
                    Renk = "Renk47"
                    RenkVal = Renk47
                    tbStok_RenkUpdate_Eticaret(code, Renk, RenkVal)
                ElseIf Renk48 = "" Then
                    Renk48 = R
                    Renk = "Renk48"
                    RenkVal = Renk48
                    tbStok_RenkUpdate_Eticaret(code, Renk, RenkVal)
                ElseIf Renk49 = "" Then
                    Renk49 = R
                    Renk = "Renk49"
                    RenkVal = Renk49
                    tbStok_RenkUpdate_Eticaret(code, Renk, RenkVal)
                ElseIf Renk50 = "" Then
                    Renk50 = R
                    Renk = "Renk50"
                    RenkVal = Renk50
                    tbStok_RenkUpdate_Eticaret(code, Renk, RenkVal)
                ElseIf Renk51 = "" Then
                    Renk51 = R
                    Renk = "Renk51"
                    RenkVal = Renk51
                    tbStok_RenkUpdate_Eticaret(code, Renk, RenkVal)
                ElseIf Renk52 = "" Then
                    Renk52 = R
                    Renk = "Renk52"
                    RenkVal = Renk52
                    tbStok_RenkUpdate_Eticaret(code, Renk, RenkVal)
                ElseIf Renk53 = "" Then
                    Renk53 = R
                    Renk = "Renk53"
                    RenkVal = Renk53
                    tbStok_RenkUpdate_Eticaret(code, Renk, RenkVal)
                ElseIf Renk54 = "" Then
                    Renk54 = R
                    Renk = "Renk54"
                    RenkVal = Renk54
                    tbStok_RenkUpdate_Eticaret(code, Renk, RenkVal)
                ElseIf Renk55 = "" Then
                    Renk55 = R
                    Renk = "Renk55"
                    RenkVal = Renk55
                    tbStok_RenkUpdate_Eticaret(code, Renk, RenkVal)
                ElseIf Renk56 = "" Then
                    Renk56 = R
                    Renk = "Renk56"
                    RenkVal = Renk56
                    tbStok_RenkUpdate_Eticaret(code, Renk, RenkVal)
                ElseIf Renk57 = "" Then
                    Renk57 = R
                    Renk = "Renk57"
                    RenkVal = Renk57
                    tbStok_RenkUpdate_Eticaret(code, Renk, RenkVal)
                ElseIf Renk58 = "" Then
                    Renk58 = R
                    Renk = "Renk58"
                    RenkVal = Renk58
                    tbStok_RenkUpdate_Eticaret(code, Renk, RenkVal)
                ElseIf Renk59 = "" Then
                    Renk59 = R
                    Renk = "Renk59"
                    RenkVal = Renk59
                    tbStok_RenkUpdate_Eticaret(code, Renk, RenkVal)
                ElseIf Renk60 = "" Then
                    Renk60 = R
                    Renk = "Renk60"
                    RenkVal = Renk60
                    tbStok_RenkUpdate_Eticaret(code, Renk, RenkVal)
                End If

                If Beden2 = "" Then
                    Beden2 = Bed
                    Beden = "Beden2"
                    BedenVal = Beden2
                    Fiyat = "Fiyat2"
                    tbStok_BedenUpdate_Eticaret(code, Beden, BedenVal, Fiyat, salePrice)
                ElseIf Beden3 = "" Then
                    Beden3 = Bed
                    Beden = "Beden3"
                    BedenVal = Beden3
                    Fiyat = "Fiyat3"
                    tbStok_BedenUpdate_Eticaret(code, Beden, BedenVal, Fiyat, salePrice)
                ElseIf Beden4 = "" Then
                    Beden4 = Bed
                    Beden = "Beden4"
                    BedenVal = Beden4
                    Fiyat = "Fiyat4"
                    tbStok_BedenUpdate_Eticaret(code, Beden, BedenVal, Fiyat, salePrice)
                ElseIf Beden5 = "" Then
                    Beden5 = Bed
                    Beden = "Beden5"
                    BedenVal = Beden5
                    Fiyat = "Fiyat5"
                    tbStok_BedenUpdate_Eticaret(code, Beden, BedenVal, Fiyat, salePrice)
                ElseIf Beden6 = "" Then
                    Beden6 = Bed
                    Beden = "Beden6"
                    BedenVal = Beden6
                    Fiyat = "Fiyat6"
                    tbStok_BedenUpdate_Eticaret(code, Beden, BedenVal, Fiyat, salePrice)
                ElseIf Beden7 = "" Then
                    Beden7 = Bed
                    Beden = "Beden7"
                    BedenVal = Beden7
                    Fiyat = "Fiyat7"
                    tbStok_BedenUpdate_Eticaret(code, Beden, BedenVal, Fiyat, salePrice)
                ElseIf Beden8 = "" Then
                    Beden8 = Bed
                    Beden = "Beden8"
                    BedenVal = Beden8
                    Fiyat = "Fiyat8"
                    tbStok_BedenUpdate_Eticaret(code, Beden, BedenVal, Fiyat, salePrice)
                ElseIf Beden9 = "" Then
                    Beden9 = Bed
                    Beden = "Beden9"
                    BedenVal = Beden9
                    Fiyat = "Fiyat9"
                    tbStok_BedenUpdate_Eticaret(code, Beden, BedenVal, Fiyat, salePrice)
                ElseIf Beden10 = "" Then
                    Beden10 = Bed
                    Beden = "Beden10"
                    BedenVal = Beden10
                    Fiyat = "Fiyat10"
                    tbStok_BedenUpdate_Eticaret(code, Beden, BedenVal, Fiyat, salePrice)
                ElseIf Beden11 = "" Then
                    Beden11 = Bed
                    Beden = "Beden11"
                    BedenVal = Beden11
                    Fiyat = "Fiyat11"
                    tbStok_BedenUpdate_Eticaret(code, Beden, BedenVal, Fiyat, salePrice)
                ElseIf Beden12 = "" Then
                    Beden12 = Bed
                    Beden = "Beden12"
                    BedenVal = Beden12
                    Fiyat = "Fiyat12"
                    tbStok_BedenUpdate_Eticaret(code, Beden, BedenVal, Fiyat, salePrice)
                ElseIf Beden13 = "" Then
                    Beden13 = Bed
                    Beden = "Beden13"
                    BedenVal = Beden13
                    Fiyat = "Fiyat13"
                    tbStok_BedenUpdate_Eticaret(code, Beden, BedenVal, Fiyat, salePrice)
                ElseIf Beden14 = "" Then
                    Beden14 = Bed
                    Beden = "Beden14"
                    BedenVal = Beden14
                    Fiyat = "Fiyat14"
                    tbStok_BedenUpdate_Eticaret(code, Beden, BedenVal, Fiyat, salePrice)
                ElseIf Beden15 = "" Then
                    Beden15 = Bed
                    Beden = "Beden15"
                    BedenVal = Beden15
                    Fiyat = "Fiyat15"
                    tbStok_BedenUpdate_Eticaret(code, Beden, BedenVal, Fiyat, salePrice)
                ElseIf Beden16 = "" Then
                    Beden16 = Bed
                    Beden = "Beden16"
                    BedenVal = Beden16
                    Fiyat = "Fiyat16"
                    tbStok_BedenUpdate_Eticaret(code, Beden, BedenVal, Fiyat, salePrice)
                ElseIf Beden17 = "" Then
                    Beden17 = Bed
                    Beden = "Beden17"
                    BedenVal = Beden17
                    Fiyat = "Fiyat17"
                    tbStok_BedenUpdate_Eticaret(code, Beden, BedenVal, Fiyat, salePrice)
                ElseIf Beden18 = "" Then
                    Beden18 = Bed
                    Beden = "Beden18"
                    BedenVal = Beden18
                    Fiyat = "Fiyat18"
                    tbStok_BedenUpdate_Eticaret(code, Beden, BedenVal, Fiyat, salePrice)
                ElseIf Beden19 = "" Then
                    Beden19 = Bed
                    Beden = "Beden19"
                    BedenVal = Beden19
                    Fiyat = "Fiyat19"
                    tbStok_BedenUpdate_Eticaret(code, Beden, BedenVal, Fiyat, salePrice)
                ElseIf Beden20 = "" Then
                    Beden20 = Bed
                    Beden = "Beden20"
                    BedenVal = Beden20
                    Fiyat = "Fiyat20"
                    tbStok_BedenUpdate_Eticaret(code, Beden, BedenVal, Fiyat, salePrice)
                ElseIf Beden21 = "" Then
                    Beden21 = Bed
                    Beden = "Beden21"
                    BedenVal = Beden21
                    Fiyat = "Fiyat21"
                    tbStok_BedenUpdate_Eticaret(code, Beden, BedenVal, Fiyat, salePrice)
                ElseIf Beden22 = "" Then
                    Beden22 = Bed
                    Beden = "Beden22"
                    BedenVal = Beden22
                    Fiyat = "Fiyat22"
                    tbStok_BedenUpdate_Eticaret(code, Beden, BedenVal, Fiyat, salePrice)
                ElseIf Beden23 = "" Then
                    Beden23 = Bed
                    Beden = "Beden23"
                    BedenVal = Beden23
                    Fiyat = "Fiyat23"
                    tbStok_BedenUpdate_Eticaret(code, Beden, BedenVal, Fiyat, salePrice)
                ElseIf Beden24 = "" Then
                    Beden24 = Bed
                    Beden = "Beden24"
                    BedenVal = Beden24
                    Fiyat = "Fiyat24"
                    tbStok_BedenUpdate_Eticaret(code, Beden, BedenVal, Fiyat, salePrice)
                ElseIf Beden25 = "" Then
                    Beden25 = Bed
                    Beden = "Beden25"
                    BedenVal = Beden25
                    Fiyat = "Fiyat25"
                    tbStok_BedenUpdate_Eticaret(code, Beden, BedenVal, Fiyat, salePrice)
                ElseIf Beden26 = "" Then
                    Beden26 = Bed
                    Beden = "Beden26"
                    BedenVal = Beden26
                    Fiyat = "Fiyat26"
                    tbStok_BedenUpdate_Eticaret(code, Beden, BedenVal, Fiyat, salePrice)
                ElseIf Beden27 = "" Then
                    Beden27 = Bed
                    Beden = "Beden27"
                    BedenVal = Beden27
                    Fiyat = "Fiyat27"
                    tbStok_BedenUpdate_Eticaret(code, Beden, BedenVal, Fiyat, salePrice)
                ElseIf Beden28 = "" Then
                    Beden28 = Bed
                    Beden = "Beden28"
                    BedenVal = Beden28
                    Fiyat = "Fiyat28"
                    tbStok_BedenUpdate_Eticaret(code, Beden, BedenVal, Fiyat, salePrice)
                ElseIf Beden29 = "" Then
                    Beden29 = Bed
                    Beden = "Beden29"
                    BedenVal = Beden29
                    Fiyat = "Fiyat29"
                    tbStok_BedenUpdate_Eticaret(code, Beden, BedenVal, Fiyat, salePrice)
                ElseIf Beden30 = "" Then
                    Beden30 = Bed
                    Beden = "Beden30"
                    BedenVal = Beden30
                    Fiyat = "Fiyat30"
                    tbStok_BedenUpdate_Eticaret(code, Beden, BedenVal, Fiyat, salePrice)
                ElseIf Beden31 = "" Then
                    Beden31 = Bed
                    Beden = "Beden31"
                    BedenVal = Beden31
                    Fiyat = "Fiyat31"
                    tbStok_BedenUpdate_Eticaret(code, Beden, BedenVal, Fiyat, salePrice)
                ElseIf Beden32 = "" Then
                    Beden32 = Bed
                    Beden = "Beden32"
                    BedenVal = Beden32
                    Fiyat = "Fiyat32"
                    tbStok_BedenUpdate_Eticaret(code, Beden, BedenVal, Fiyat, salePrice)
                ElseIf Beden33 = "" Then
                    Beden33 = Bed
                    Beden = "Beden33"
                    BedenVal = Beden33
                    Fiyat = "Fiyat33"
                    tbStok_BedenUpdate_Eticaret(code, Beden, BedenVal, Fiyat, salePrice)
                ElseIf Beden34 = "" Then
                    Beden34 = Bed
                    Beden = "Beden34"
                    BedenVal = Beden34
                    Fiyat = "Fiyat34"
                    tbStok_BedenUpdate_Eticaret(code, Beden, BedenVal, Fiyat, salePrice)
                ElseIf Beden35 = "" Then
                    Beden35 = Bed
                    Beden = "Beden35"
                    BedenVal = Beden35
                    Fiyat = "Fiyat35"
                    tbStok_BedenUpdate_Eticaret(code, Beden, BedenVal, Fiyat, salePrice)
                ElseIf Beden36 = "" Then
                    Beden36 = Bed
                    Beden = "Beden36"
                    BedenVal = Beden36
                    Fiyat = "Fiyat36"
                    tbStok_BedenUpdate_Eticaret(code, Beden, BedenVal, Fiyat, salePrice)
                ElseIf Beden37 = "" Then
                    Beden37 = Bed
                    Beden = "Beden37"
                    BedenVal = Beden37
                    Fiyat = "Fiyat37"
                    tbStok_BedenUpdate_Eticaret(code, Beden, BedenVal, Fiyat, salePrice)
                ElseIf Beden38 = "" Then
                    Beden38 = Bed
                    Beden = "Beden38"
                    BedenVal = Beden38
                    Fiyat = "Fiyat38"
                    tbStok_BedenUpdate_Eticaret(code, Beden, BedenVal, Fiyat, salePrice)
                ElseIf Beden39 = "" Then
                    Beden39 = Bed
                    Beden = "Beden39"
                    BedenVal = Beden39
                    Fiyat = "Fiyat39"
                    tbStok_BedenUpdate_Eticaret(code, Beden, BedenVal, Fiyat, salePrice)
                ElseIf Beden40 = "" Then
                    Beden40 = Bed
                    Beden = "Beden40"
                    BedenVal = Beden40
                    Fiyat = "Fiyat40"
                    tbStok_BedenUpdate_Eticaret(code, Beden, BedenVal, Fiyat, salePrice)
                ElseIf Beden41 = "" Then
                    Beden41 = Bed
                    Beden = "Beden41"
                    BedenVal = Beden41
                    Fiyat = "Fiyat41"
                    tbStok_BedenUpdate_Eticaret(code, Beden, BedenVal, Fiyat, salePrice)
                ElseIf Beden42 = "" Then
                    Beden42 = Bed
                    Beden = "Beden42"
                    BedenVal = Beden42
                    Fiyat = "Fiyat42"
                    tbStok_BedenUpdate_Eticaret(code, Beden, BedenVal, Fiyat, salePrice)
                ElseIf Beden43 = "" Then
                    Beden43 = Bed
                    Beden = "Beden43"
                    BedenVal = Beden43
                    Fiyat = "Fiyat43"
                    tbStok_BedenUpdate_Eticaret(code, Beden, BedenVal, Fiyat, salePrice)
                ElseIf Beden44 = "" Then
                    Beden44 = Bed
                    Beden = "Beden44"
                    BedenVal = Beden44
                    Fiyat = "Fiyat44"
                    tbStok_BedenUpdate_Eticaret(code, Beden, BedenVal, Fiyat, salePrice)
                ElseIf Beden45 = "" Then
                    Beden45 = Bed
                    Beden = "Beden45"
                    BedenVal = Beden45
                    Fiyat = "Fiyat45"
                    tbStok_BedenUpdate_Eticaret(code, Beden, BedenVal, Fiyat, salePrice)
                ElseIf Beden46 = "" Then
                    Beden46 = Bed
                    Beden = "Beden46"
                    BedenVal = Beden46
                    Fiyat = "Fiyat46"
                    tbStok_BedenUpdate_Eticaret(code, Beden, BedenVal, Fiyat, salePrice)
                ElseIf Beden47 = "" Then
                    Beden47 = Bed
                    Beden = "Beden47"
                    BedenVal = Beden47
                    Fiyat = "Fiyat47"
                    tbStok_BedenUpdate_Eticaret(code, Beden, BedenVal, Fiyat, salePrice)
                ElseIf Beden48 = "" Then
                    Beden48 = Bed
                    Beden = "Beden48"
                    BedenVal = Beden48
                    Fiyat = "Fiyat48"
                    tbStok_BedenUpdate_Eticaret(code, Beden, BedenVal, Fiyat, salePrice)
                ElseIf Beden49 = "" Then
                    Beden49 = Bed
                    Beden = "Beden49"
                    BedenVal = Beden49
                    Fiyat = "Fiyat49"
                    tbStok_BedenUpdate_Eticaret(code, Beden, BedenVal, Fiyat, salePrice)
                ElseIf Beden50 = "" Then
                    Beden50 = Bed
                    Beden = "Beden50"
                    BedenVal = Beden50
                    Fiyat = "Fiyat50"
                    tbStok_BedenUpdate_Eticaret(code, Beden, BedenVal, Fiyat, salePrice)
                ElseIf Beden51 = "" Then
                    Beden51 = Bed
                    Beden = "Beden51"
                    BedenVal = Beden51
                    Fiyat = "Fiyat51"
                    tbStok_BedenUpdate_Eticaret(code, Beden, BedenVal, Fiyat, salePrice)
                ElseIf Beden52 = "" Then
                    Beden52 = Bed
                    Beden = "Beden52"
                    BedenVal = Beden52
                    Fiyat = "Fiyat52"
                    tbStok_BedenUpdate_Eticaret(code, Beden, BedenVal, Fiyat, salePrice)
                ElseIf Beden53 = "" Then
                    Beden53 = Bed
                    Beden = "Beden53"
                    BedenVal = Beden53
                    Fiyat = "Fiyat53"
                    tbStok_BedenUpdate_Eticaret(code, Beden, BedenVal, Fiyat, salePrice)
                ElseIf Beden54 = "" Then
                    Beden54 = Bed
                    Beden = "Beden54"
                    BedenVal = Beden54
                    Fiyat = "Fiyat54"
                    tbStok_BedenUpdate_Eticaret(code, Beden, BedenVal, Fiyat, salePrice)
                ElseIf Beden55 = "" Then
                    Beden55 = Bed
                    Beden = "Beden55"
                    BedenVal = Beden55
                    Fiyat = "Fiyat55"
                    tbStok_BedenUpdate_Eticaret(code, Beden, BedenVal, Fiyat, salePrice)
                ElseIf Beden56 = "" Then
                    Beden56 = Bed
                    Beden = "Beden56"
                    BedenVal = Beden56
                    Fiyat = "Fiyat56"
                    tbStok_BedenUpdate_Eticaret(code, Beden, BedenVal, Fiyat, salePrice)
                ElseIf Beden57 = "" Then
                    Beden57 = Bed
                    Beden = "Beden57"
                    BedenVal = Beden57
                    Fiyat = "Fiyat57"
                    tbStok_BedenUpdate_Eticaret(code, Beden, BedenVal, Fiyat, salePrice)
                ElseIf Beden58 = "" Then
                    Beden58 = Bed
                    Beden = "Beden58"
                    BedenVal = Beden58
                    Fiyat = "Fiyat58"
                    tbStok_BedenUpdate_Eticaret(code, Beden, BedenVal, Fiyat, salePrice)
                ElseIf Beden59 = "" Then
                    Beden59 = Bed
                    Beden = "Beden59"
                    BedenVal = Beden59
                    Fiyat = "Fiyat59"
                    tbStok_BedenUpdate_Eticaret(code, Beden, BedenVal, Fiyat, salePrice)
                ElseIf Beden60 = "" Then
                    Beden60 = Bed
                    Beden = "Beden60"
                    BedenVal = Beden60
                    Fiyat = "Fiyat60"
                    tbStok_BedenUpdate_Eticaret(code, Beden, BedenVal, Fiyat, salePrice)
                End If


                If barcode2 = "" Then
                    barcode2 = Bar
                    Barkod = "Barcode2"
                    BarkodVal = barcode2
                    tbStok_BarkodUpdate_Eticaret(code, Barkod, BarkodVal)
                ElseIf barcode3 = "" Then
                    barcode3 = Bar
                    Barkod = "Barcode3"
                    BarkodVal = barcode3
                    tbStok_BarkodUpdate_Eticaret(code, Barkod, BarkodVal)
                ElseIf barcode4 = "" Then
                    barcode4 = Bar
                    Barkod = "Barcode4"
                    BarkodVal = barcode4
                    tbStok_BarkodUpdate_Eticaret(code, Barkod, BarkodVal)
                ElseIf barcode5 = "" Then
                    barcode5 = Bar
                    Barkod = "Barcode5"
                    BarkodVal = barcode5
                    tbStok_BarkodUpdate_Eticaret(code, Barkod, BarkodVal)
                ElseIf barcode6 = "" Then
                    barcode6 = Bar
                    Barkod = "Barcode6"
                    BarkodVal = barcode6
                    tbStok_BarkodUpdate_Eticaret(code, Barkod, BarkodVal)
                ElseIf barcode7 = "" Then
                    barcode7 = Bar
                    Barkod = "Barcode7"
                    BarkodVal = barcode7
                    tbStok_BarkodUpdate_Eticaret(code, Barkod, BarkodVal)
                ElseIf barcode8 = "" Then
                    barcode8 = Bar
                    Barkod = "Barcode8"
                    BarkodVal = barcode8
                    tbStok_BarkodUpdate_Eticaret(code, Barkod, BarkodVal)
                ElseIf barcode9 = "" Then
                    barcode9 = Bar
                    Barkod = "Barcode9"
                    BarkodVal = barcode9
                    tbStok_BarkodUpdate_Eticaret(code, Barkod, BarkodVal)
                ElseIf barcode10 = "" Then
                    barcode10 = Bar
                    Barkod = "Barcode10"
                    BarkodVal = barcode10
                    tbStok_BarkodUpdate_Eticaret(code, Barkod, BarkodVal)
                ElseIf barcode11 = "" Then
                    barcode11 = Bar
                    Barkod = "Barcode11"
                    BarkodVal = barcode11
                    tbStok_BarkodUpdate_Eticaret(code, Barkod, BarkodVal)
                ElseIf barcode12 = "" Then
                    barcode12 = Bar
                    Barkod = "Barcode12"
                    BarkodVal = barcode12
                    tbStok_BarkodUpdate_Eticaret(code, Barkod, BarkodVal)
                ElseIf barcode13 = "" Then
                    barcode13 = Bar
                    Barkod = "Barcode13"
                    BarkodVal = barcode13
                    tbStok_BarkodUpdate_Eticaret(code, Barkod, BarkodVal)
                ElseIf barcode14 = "" Then
                    barcode14 = Bar
                    Barkod = "Barcode14"
                    BarkodVal = barcode14
                    tbStok_BarkodUpdate_Eticaret(code, Barkod, BarkodVal)
                ElseIf barcode15 = "" Then
                    barcode15 = Bar
                    Barkod = "Barcode15"
                    BarkodVal = barcode15
                    tbStok_BarkodUpdate_Eticaret(code, Barkod, BarkodVal)
                ElseIf barcode16 = "" Then
                    barcode16 = Bar
                    Barkod = "Barcode16"
                    BarkodVal = barcode16
                    tbStok_BarkodUpdate_Eticaret(code, Barkod, BarkodVal)
                ElseIf barcode17 = "" Then
                    barcode17 = Bar
                    Barkod = "Barcode17"
                    BarkodVal = barcode17
                    tbStok_BarkodUpdate_Eticaret(code, Barkod, BarkodVal)
                ElseIf barcode18 = "" Then
                    barcode18 = Bar
                    Barkod = "Barcode18"
                    BarkodVal = barcode18
                    tbStok_BarkodUpdate_Eticaret(code, Barkod, BarkodVal)
                ElseIf barcode19 = "" Then
                    barcode19 = Bar
                    Barkod = "Barcode19"
                    BarkodVal = barcode19
                    tbStok_BarkodUpdate_Eticaret(code, Barkod, BarkodVal)
                ElseIf barcode20 = "" Then
                    barcode20 = Bar
                    Barkod = "Barcode20"
                    BarkodVal = barcode20
                    tbStok_BarkodUpdate_Eticaret(code, Barkod, BarkodVal)
                ElseIf barcode21 = "" Then
                    barcode21 = Bar
                    Barkod = "Barcode21"
                    BarkodVal = barcode21
                    tbStok_BarkodUpdate_Eticaret(code, Barkod, BarkodVal)
                ElseIf barcode22 = "" Then
                    barcode22 = Bar
                    Barkod = "Barcode22"
                    BarkodVal = barcode22
                    tbStok_BarkodUpdate_Eticaret(code, Barkod, BarkodVal)
                ElseIf barcode23 = "" Then
                    barcode23 = Bar
                    Barkod = "Barcode23"
                    BarkodVal = barcode23
                    tbStok_BarkodUpdate_Eticaret(code, Barkod, BarkodVal)
                ElseIf barcode24 = "" Then
                    barcode24 = Bar
                    Barkod = "Barcode24"
                    BarkodVal = barcode24
                    tbStok_BarkodUpdate_Eticaret(code, Barkod, BarkodVal)
                ElseIf barcode25 = "" Then
                    barcode25 = Bar
                    Barkod = "Barcode25"
                    BarkodVal = barcode25
                    tbStok_BarkodUpdate_Eticaret(code, Barkod, BarkodVal)
                ElseIf barcode26 = "" Then
                    barcode26 = Bar
                    Barkod = "Barcode26"
                    BarkodVal = barcode26
                    tbStok_BarkodUpdate_Eticaret(code, Barkod, BarkodVal)
                ElseIf barcode27 = "" Then
                    barcode27 = Bar
                    Barkod = "Barcode27"
                    BarkodVal = barcode27
                    tbStok_BarkodUpdate_Eticaret(code, Barkod, BarkodVal)
                ElseIf barcode28 = "" Then
                    barcode28 = Bar
                    Barkod = "Barcode28"
                    BarkodVal = barcode28
                    tbStok_BarkodUpdate_Eticaret(code, Barkod, BarkodVal)
                ElseIf barcode29 = "" Then
                    barcode29 = Bar
                    Barkod = "Barcode29"
                    BarkodVal = barcode29
                    tbStok_BarkodUpdate_Eticaret(code, Barkod, BarkodVal)
                ElseIf barcode30 = "" Then
                    barcode30 = Bar
                    Barkod = "Barcode30"
                    BarkodVal = barcode30
                    tbStok_BarkodUpdate_Eticaret(code, Barkod, BarkodVal)
                ElseIf barcode31 = "" Then
                    barcode31 = Bar
                    Barkod = "Barcode31"
                    BarkodVal = barcode31
                    tbStok_BarkodUpdate_Eticaret(code, Barkod, BarkodVal)
                ElseIf barcode32 = "" Then
                    barcode32 = Bar
                    Barkod = "Barcode32"
                    BarkodVal = barcode32
                    tbStok_BarkodUpdate_Eticaret(code, Barkod, BarkodVal)
                ElseIf barcode33 = "" Then
                    barcode33 = Bar
                    Barkod = "Barcode33"
                    BarkodVal = barcode33
                    tbStok_BarkodUpdate_Eticaret(code, Barkod, BarkodVal)
                ElseIf barcode34 = "" Then
                    barcode34 = Bar
                    Barkod = "Barcode34"
                    BarkodVal = barcode34
                    tbStok_BarkodUpdate_Eticaret(code, Barkod, BarkodVal)
                ElseIf barcode35 = "" Then
                    barcode35 = Bar
                    Barkod = "Barcode35"
                    BarkodVal = barcode35
                    tbStok_BarkodUpdate_Eticaret(code, Barkod, BarkodVal)
                ElseIf barcode36 = "" Then
                    barcode36 = Bar
                    Barkod = "Barcode36"
                    BarkodVal = barcode36
                    tbStok_BarkodUpdate_Eticaret(code, Barkod, BarkodVal)
                ElseIf barcode37 = "" Then
                    barcode37 = Bar
                    Barkod = "Barcode37"
                    BarkodVal = barcode37
                    tbStok_BarkodUpdate_Eticaret(code, Barkod, BarkodVal)
                ElseIf barcode38 = "" Then
                    barcode38 = Bar
                    Barkod = "Barcode38"
                    BarkodVal = barcode38
                    tbStok_BarkodUpdate_Eticaret(code, Barkod, BarkodVal)
                ElseIf barcode39 = "" Then
                    barcode39 = Bar
                    Barkod = "Barcode39"
                    BarkodVal = barcode39
                    tbStok_BarkodUpdate_Eticaret(code, Barkod, BarkodVal)
                ElseIf barcode40 = "" Then
                    barcode40 = Bar
                    Barkod = "Barcode40"
                    BarkodVal = barcode40
                    tbStok_BarkodUpdate_Eticaret(code, Barkod, BarkodVal)
                ElseIf barcode41 = "" Then
                    barcode41 = Bar
                    Barkod = "Barcode41"
                    BarkodVal = barcode41
                    tbStok_BarkodUpdate_Eticaret(code, Barkod, BarkodVal)
                ElseIf barcode42 = "" Then
                    barcode42 = Bar
                    Barkod = "Barcode42"
                    BarkodVal = barcode42
                    tbStok_BarkodUpdate_Eticaret(code, Barkod, BarkodVal)
                ElseIf barcode43 = "" Then
                    barcode43 = Bar
                    Barkod = "Barcode43"
                    BarkodVal = barcode43
                    tbStok_BarkodUpdate_Eticaret(code, Barkod, BarkodVal)
                ElseIf barcode44 = "" Then
                    barcode44 = Bar
                    Barkod = "Barcode44"
                    BarkodVal = barcode44
                    tbStok_BarkodUpdate_Eticaret(code, Barkod, BarkodVal)
                ElseIf barcode45 = "" Then
                    barcode45 = Bar
                    Barkod = "Barcode45"
                    BarkodVal = barcode45
                    tbStok_BarkodUpdate_Eticaret(code, Barkod, BarkodVal)
                ElseIf barcode46 = "" Then
                    barcode46 = Bar
                    Barkod = "Barcode46"
                    BarkodVal = barcode46
                    tbStok_BarkodUpdate_Eticaret(code, Barkod, BarkodVal)
                ElseIf barcode47 = "" Then
                    barcode47 = Bar
                    Barkod = "Barcode47"
                    BarkodVal = barcode47
                    tbStok_BarkodUpdate_Eticaret(code, Barkod, BarkodVal)
                ElseIf barcode48 = "" Then
                    barcode48 = Bar
                    Barkod = "Barcode48"
                    BarkodVal = barcode48
                    tbStok_BarkodUpdate_Eticaret(code, Barkod, BarkodVal)
                ElseIf barcode49 = "" Then
                    barcode49 = Bar
                    Barkod = "Barcode49"
                    BarkodVal = barcode49
                    tbStok_BarkodUpdate_Eticaret(code, Barkod, BarkodVal)
                ElseIf barcode50 = "" Then
                    barcode50 = Bar
                    Barkod = "Barcode50"
                    BarkodVal = barcode50
                    tbStok_BarkodUpdate_Eticaret(code, Barkod, BarkodVal)
                ElseIf barcode51 = "" Then
                    barcode51 = Bar
                    Barkod = "Barcode51"
                    BarkodVal = barcode51
                    tbStok_BarkodUpdate_Eticaret(code, Barkod, BarkodVal)
                ElseIf barcode52 = "" Then
                    barcode52 = Bar
                    Barkod = "Barcode52"
                    BarkodVal = barcode52
                    tbStok_BarkodUpdate_Eticaret(code, Barkod, BarkodVal)
                ElseIf barcode53 = "" Then
                    barcode53 = Bar
                    Barkod = "Barcode53"
                    BarkodVal = barcode53
                    tbStok_BarkodUpdate_Eticaret(code, Barkod, BarkodVal)
                ElseIf barcode54 = "" Then
                    barcode54 = Bar
                    Barkod = "Barcode54"
                    BarkodVal = barcode54
                    tbStok_BarkodUpdate_Eticaret(code, Barkod, BarkodVal)
                ElseIf barcode55 = "" Then
                    barcode55 = Bar
                    Barkod = "Barcode55"
                    BarkodVal = barcode55
                    tbStok_BarkodUpdate_Eticaret(code, Barkod, BarkodVal)
                ElseIf barcode56 = "" Then
                    barcode56 = Bar
                    Barkod = "Barcode56"
                    BarkodVal = barcode56
                    tbStok_BarkodUpdate_Eticaret(code, Barkod, BarkodVal)
                ElseIf barcode57 = "" Then
                    barcode57 = Bar
                    Barkod = "Barcode57"
                    BarkodVal = barcode57
                    tbStok_BarkodUpdate_Eticaret(code, Barkod, BarkodVal)
                ElseIf barcode58 = "" Then
                    barcode58 = Bar
                    Barkod = "Barcode58"
                    BarkodVal = barcode58
                    tbStok_BarkodUpdate_Eticaret(code, Barkod, BarkodVal)
                ElseIf barcode59 = "" Then
                    barcode59 = Bar
                    Barkod = "Barcode59"
                    BarkodVal = barcode59
                    tbStok_BarkodUpdate_Eticaret(code, Barkod, BarkodVal)
                ElseIf barcode60 = "" Then
                    barcode60 = Bar
                    Barkod = "Barcode60"
                    BarkodVal = barcode60
                    tbStok_BarkodUpdate_Eticaret(code, Barkod, BarkodVal)
                End If

                If quantity2 = "-9999" Then
                    If Q > 0 Then
                        quantity2 = Q
                    Else
                        quantity2 = 0
                    End If
                    quantity = "quantity2"
                    quantityVal = quantity2
                    tbStok_quantityUpdate_Eticaret(code, quantity, quantityVal)
                ElseIf quantity3 = "-9999" Then
                    If Q > 0 Then
                        quantity3 = Q
                    Else
                        quantity3 = 0
                    End If
                    quantity = "quantity3"
                    quantityVal = quantity3
                    tbStok_quantityUpdate_Eticaret(code, quantity, quantityVal)
                ElseIf quantity4 = "-9999" Then
                    If Q > 0 Then
                        quantity4 = Q
                    Else
                        quantity4 = 0
                    End If
                    quantity = "quantity4"
                    quantityVal = quantity4
                    tbStok_quantityUpdate_Eticaret(code, quantity, quantityVal)
                ElseIf quantity5 = "-9999" Then
                    If Q > 0 Then
                        quantity5 = Q
                    Else
                        quantity5 = 0
                    End If
                    quantity = "quantity5"
                    quantityVal = quantity5
                    tbStok_quantityUpdate_Eticaret(code, quantity, quantityVal)
                ElseIf quantity6 = "-9999" Then
                    If Q > 0 Then
                        quantity6 = Q
                    Else
                        quantity6 = 0
                    End If
                    quantity = "quantity6"
                    quantityVal = quantity6
                    tbStok_quantityUpdate_Eticaret(code, quantity, quantityVal)
                ElseIf quantity7 = "-9999" Then
                    If Q > 0 Then
                        quantity7 = Q
                    Else
                        quantity7 = 0
                    End If
                    quantity = "quantity7"
                    quantityVal = quantity7
                    tbStok_quantityUpdate_Eticaret(code, quantity, quantityVal)
                ElseIf quantity8 = "-9999" Then
                    If Q > 0 Then
                        quantity8 = Q
                    Else
                        quantity8 = 0
                    End If
                    quantity = "quantity8"
                    quantityVal = quantity8
                    tbStok_quantityUpdate_Eticaret(code, quantity, quantityVal)
                ElseIf quantity9 = "-9999" Then
                    If Q > 0 Then
                        quantity9 = Q
                    Else
                        quantity9 = 0
                    End If
                    quantity = "quantity9"
                    quantityVal = quantity9
                    tbStok_quantityUpdate_Eticaret(code, quantity, quantityVal)
                ElseIf quantity10 = "-9999" Then
                    If Q > 0 Then
                        quantity10 = Q
                    Else
                        quantity10 = 0
                    End If
                    quantity = "quantity10"
                    quantityVal = quantity10
                    tbStok_quantityUpdate_Eticaret(code, quantity, quantityVal)
                ElseIf quantity11 = "-9999" Then
                    If Q > 0 Then
                        quantity11 = Q
                    Else
                        quantity11 = 0
                    End If
                    quantity = "quantity11"
                    quantityVal = quantity11
                    tbStok_quantityUpdate_Eticaret(code, quantity, quantityVal)
                ElseIf quantity12 = "-9999" Then
                    If Q > 0 Then
                        quantity12 = Q
                    Else
                        quantity12 = 0
                    End If
                    quantity = "quantity12"
                    quantityVal = quantity12
                    tbStok_quantityUpdate_Eticaret(code, quantity, quantityVal)
                ElseIf quantity13 = "-9999" Then
                    If Q > 0 Then
                        quantity13 = Q
                    Else
                        quantity13 = 0
                    End If
                    quantity = "quantity13"
                    quantityVal = quantity13
                    tbStok_quantityUpdate_Eticaret(code, quantity, quantityVal)
                ElseIf quantity14 = "-9999" Then
                    If Q > 0 Then
                        quantity14 = Q
                    Else
                        quantity14 = 0
                    End If
                    quantity = "quantity14"
                    quantityVal = quantity14
                    tbStok_quantityUpdate_Eticaret(code, quantity, quantityVal)
                ElseIf quantity15 = "-9999" Then
                    If Q > 0 Then
                        quantity15 = Q
                    Else
                        quantity15 = 0
                    End If
                    quantity = "quantity15"
                    quantityVal = quantity15
                    tbStok_quantityUpdate_Eticaret(code, quantity, quantityVal)
                ElseIf quantity16 = "-9999" Then
                    If Q > 0 Then
                        quantity16 = Q
                    Else
                        quantity16 = 0
                    End If
                    quantity = "quantity16"
                    quantityVal = quantity16
                    tbStok_quantityUpdate_Eticaret(code, quantity, quantityVal)
                ElseIf quantity17 = "-9999" Then
                    If Q > 0 Then
                        quantity17 = Q
                    Else
                        quantity17 = 0
                    End If
                    quantity = "quantity17"
                    quantityVal = quantity17
                    tbStok_quantityUpdate_Eticaret(code, quantity, quantityVal)
                ElseIf quantity18 = "-9999" Then
                    If Q > 0 Then
                        quantity18 = Q
                    Else
                        quantity18 = 0
                    End If
                    quantity = "quantity18"
                    quantityVal = quantity18
                    tbStok_quantityUpdate_Eticaret(code, quantity, quantityVal)
                ElseIf quantity19 = "-9999" Then
                    If Q > 0 Then
                        quantity19 = Q
                    Else
                        quantity19 = 0
                    End If
                    quantity = "quantity19"
                    quantityVal = quantity19
                    tbStok_quantityUpdate_Eticaret(code, quantity, quantityVal)
                ElseIf quantity20 = "-9999" Then
                    If Q > 0 Then
                        quantity20 = Q
                    Else
                        quantity20 = 0
                    End If
                    quantity = "quantity20"
                    quantityVal = quantity20
                    tbStok_quantityUpdate_Eticaret(code, quantity, quantityVal)
                ElseIf quantity21 = "-9999" Then
                    If Q > 0 Then
                        quantity21 = Q
                    Else
                        quantity21 = 0
                    End If
                    quantity = "quantity21"
                    quantityVal = quantity21
                    tbStok_quantityUpdate_Eticaret(code, quantity, quantityVal)
                ElseIf quantity22 = "-9999" Then
                    If Q > 0 Then
                        quantity22 = Q
                    Else
                        quantity22 = 0
                    End If
                    quantity = "quantity22"
                    quantityVal = quantity22
                    tbStok_quantityUpdate_Eticaret(code, quantity, quantityVal)
                ElseIf quantity23 = "-9999" Then
                    If Q > 0 Then
                        quantity23 = Q
                    Else
                        quantity23 = 0
                    End If
                    quantity = "quantity23"
                    quantityVal = quantity23
                    tbStok_quantityUpdate_Eticaret(code, quantity, quantityVal)
                ElseIf quantity24 = "-9999" Then
                    If Q > 0 Then
                        quantity24 = Q
                    Else
                        quantity24 = 0
                    End If
                    quantity = "quantity24"
                    quantityVal = quantity24
                    tbStok_quantityUpdate_Eticaret(code, quantity, quantityVal)
                ElseIf quantity25 = "-9999" Then
                    If Q > 0 Then
                        quantity25 = Q
                    Else
                        quantity25 = 0
                    End If
                    quantity = "quantity25"
                    quantityVal = quantity25
                    tbStok_quantityUpdate_Eticaret(code, quantity, quantityVal)
                ElseIf quantity26 = "-9999" Then
                    If Q > 0 Then
                        quantity26 = Q
                    Else
                        quantity26 = 0
                    End If
                    quantity = "quantity26"
                    quantityVal = quantity26
                    tbStok_quantityUpdate_Eticaret(code, quantity, quantityVal)
                ElseIf quantity27 = "-9999" Then
                    If Q > 0 Then
                        quantity27 = Q
                    Else
                        quantity27 = 0
                    End If
                    quantity = "quantity27"
                    quantityVal = quantity27
                    tbStok_quantityUpdate_Eticaret(code, quantity, quantityVal)
                ElseIf quantity28 = "-9999" Then
                    If Q > 0 Then
                        quantity28 = Q
                    Else
                        quantity28 = 0
                    End If
                    quantity = "quantity28"
                    quantityVal = quantity28
                    tbStok_quantityUpdate_Eticaret(code, quantity, quantityVal)
                ElseIf quantity29 = "-9999" Then
                    If Q > 0 Then
                        quantity29 = Q
                    Else
                        quantity29 = 0
                    End If
                    quantity = "quantity29"
                    quantityVal = quantity29
                    tbStok_quantityUpdate_Eticaret(code, quantity, quantityVal)
                ElseIf quantity30 = "-9999" Then
                    If Q > 0 Then
                        quantity30 = Q
                    Else
                        quantity30 = 0
                    End If
                    quantity = "quantity30"
                    quantityVal = quantity30
                    tbStok_quantityUpdate_Eticaret(code, quantity, quantityVal)
                ElseIf quantity31 = "-9999" Then
                    If Q > 0 Then
                        quantity31 = Q
                    Else
                        quantity31 = 0
                    End If
                    quantity = "quantity31"
                    quantityVal = quantity31
                    tbStok_quantityUpdate_Eticaret(code, quantity, quantityVal)
                ElseIf quantity32 = "-9999" Then
                    If Q > 0 Then
                        quantity32 = Q
                    Else
                        quantity32 = 0
                    End If
                    quantity = "quantity32"
                    quantityVal = quantity32
                    tbStok_quantityUpdate_Eticaret(code, quantity, quantityVal)
                ElseIf quantity33 = "-9999" Then
                    If Q > 0 Then
                        quantity33 = Q
                    Else
                        quantity33 = 0
                    End If
                    quantity = "quantity33"
                    quantityVal = quantity33
                    tbStok_quantityUpdate_Eticaret(code, quantity, quantityVal)
                ElseIf quantity34 = "-9999" Then
                    If Q > 0 Then
                        quantity34 = Q
                    Else
                        quantity34 = 0
                    End If
                    quantity = "quantity34"
                    quantityVal = quantity34
                    tbStok_quantityUpdate_Eticaret(code, quantity, quantityVal)
                ElseIf quantity35 = "-9999" Then
                    If Q > 0 Then
                        quantity35 = Q
                    Else
                        quantity35 = 0
                    End If
                    quantity = "quantity35"
                    quantityVal = quantity35
                    tbStok_quantityUpdate_Eticaret(code, quantity, quantityVal)
                ElseIf quantity36 = "-9999" Then
                    If Q > 0 Then
                        quantity36 = Q
                    Else
                        quantity36 = 0
                    End If
                    quantity = "quantity36"
                    quantityVal = quantity36
                    tbStok_quantityUpdate_Eticaret(code, quantity, quantityVal)
                ElseIf quantity37 = "-9999" Then
                    If Q > 0 Then
                        quantity37 = Q
                    Else
                        quantity37 = 0
                    End If
                    quantity = "quantity37"
                    quantityVal = quantity37
                    tbStok_quantityUpdate_Eticaret(code, quantity, quantityVal)
                ElseIf quantity38 = "-9999" Then
                    If Q > 0 Then
                        quantity38 = Q
                    Else
                        quantity38 = 0
                    End If
                    quantity = "quantity38"
                    quantityVal = quantity38
                    tbStok_quantityUpdate_Eticaret(code, quantity, quantityVal)
                ElseIf quantity39 = "-9999" Then
                    If Q > 0 Then
                        quantity39 = Q
                    Else
                        quantity39 = 0
                    End If
                    quantity = "quantity39"
                    quantityVal = quantity39
                    tbStok_quantityUpdate_Eticaret(code, quantity, quantityVal)
                ElseIf quantity40 = "-9999" Then
                    If Q > 0 Then
                        quantity40 = Q
                    Else
                        quantity40 = 0
                    End If
                    quantity = "quantity40"
                    quantityVal = quantity40
                    tbStok_quantityUpdate_Eticaret(code, quantity, quantityVal)
                ElseIf quantity41 = "-9999" Then
                    If Q > 0 Then
                        quantity41 = Q
                    Else
                        quantity41 = 0
                    End If
                    quantity = "quantity41"
                    quantityVal = quantity41
                    tbStok_quantityUpdate_Eticaret(code, quantity, quantityVal)
                ElseIf quantity42 = "-9999" Then
                    If Q > 0 Then
                        quantity42 = Q
                    Else
                        quantity42 = 0
                    End If
                    quantity = "quantity42"
                    quantityVal = quantity42
                    tbStok_quantityUpdate_Eticaret(code, quantity, quantityVal)
                ElseIf quantity43 = "-9999" Then
                    If Q > 0 Then
                        quantity43 = Q
                    Else
                        quantity43 = 0
                    End If
                    quantity = "quantity43"
                    quantityVal = quantity43
                    tbStok_quantityUpdate_Eticaret(code, quantity, quantityVal)
                ElseIf quantity44 = "-9999" Then
                    If Q > 0 Then
                        quantity44 = Q
                    Else
                        quantity44 = 0
                    End If
                    quantity = "quantity44"
                    quantityVal = quantity44
                    tbStok_quantityUpdate_Eticaret(code, quantity, quantityVal)
                ElseIf quantity45 = "-9999" Then
                    If Q > 0 Then
                        quantity45 = Q
                    Else
                        quantity45 = 0
                    End If
                    quantity = "quantity45"
                    quantityVal = quantity45
                    tbStok_quantityUpdate_Eticaret(code, quantity, quantityVal)
                ElseIf quantity46 = "-9999" Then
                    If Q > 0 Then
                        quantity46 = Q
                    Else
                        quantity46 = 0
                    End If
                    quantity = "quantity46"
                    quantityVal = quantity46
                    tbStok_quantityUpdate_Eticaret(code, quantity, quantityVal)
                ElseIf quantity47 = "-9999" Then
                    If Q > 0 Then
                        quantity47 = Q
                    Else
                        quantity47 = 0
                    End If
                    quantity = "quantity47"
                    quantityVal = quantity47
                    tbStok_quantityUpdate_Eticaret(code, quantity, quantityVal)
                ElseIf quantity48 = "-9999" Then
                    If Q > 0 Then
                        quantity48 = Q
                    Else
                        quantity48 = 0
                    End If
                    quantity = "quantity48"
                    quantityVal = quantity48
                    tbStok_quantityUpdate_Eticaret(code, quantity, quantityVal)
                ElseIf quantity49 = "-9999" Then
                    If Q > 0 Then
                        quantity49 = Q
                    Else
                        quantity49 = 0
                    End If
                    quantity = "quantity49"
                    quantityVal = quantity49
                    tbStok_quantityUpdate_Eticaret(code, quantity, quantityVal)
                ElseIf quantity50 = "-9999" Then
                    If Q > 0 Then
                        quantity50 = Q
                    Else
                        quantity50 = 0
                    End If
                    quantity = "quantity50"
                    quantityVal = quantity50
                    tbStok_quantityUpdate_Eticaret(code, quantity, quantityVal)
                ElseIf quantity51 = "-9999" Then
                    If Q > 0 Then
                        quantity51 = Q
                    Else
                        quantity51 = 0
                    End If
                    quantity = "quantity51"
                    quantityVal = quantity51
                    tbStok_quantityUpdate_Eticaret(code, quantity, quantityVal)
                ElseIf quantity52 = "-9999" Then
                    If Q > 0 Then
                        quantity52 = Q
                    Else
                        quantity52 = 0
                    End If
                    quantity = "quantity52"
                    quantityVal = quantity52
                    tbStok_quantityUpdate_Eticaret(code, quantity, quantityVal)
                ElseIf quantity53 = "-9999" Then
                    If Q > 0 Then
                        quantity53 = Q
                    Else
                        quantity53 = 0
                    End If
                    quantity = "quantity53"
                    quantityVal = quantity53
                    tbStok_quantityUpdate_Eticaret(code, quantity, quantityVal)
                ElseIf quantity54 = "-9999" Then
                    If Q > 0 Then
                        quantity54 = Q
                    Else
                        quantity54 = 0
                    End If
                    quantity = "quantity54"
                    quantityVal = quantity54
                    tbStok_quantityUpdate_Eticaret(code, quantity, quantityVal)
                ElseIf quantity55 = "-9999" Then
                    If Q > 0 Then
                        quantity55 = Q
                    Else
                        quantity55 = 0
                    End If
                    quantity = "quantity55"
                    quantityVal = quantity55
                    tbStok_quantityUpdate_Eticaret(code, quantity, quantityVal)
                ElseIf quantity56 = "-9999" Then
                    If Q > 0 Then
                        quantity56 = Q
                    Else
                        quantity56 = 0
                    End If
                    quantity = "quantity56"
                    quantityVal = quantity56
                    tbStok_quantityUpdate_Eticaret(code, quantity, quantityVal)
                ElseIf quantity57 = "-9999" Then
                    If Q > 0 Then
                        quantity57 = Q
                    Else
                        quantity57 = 0
                    End If
                    quantity = "quantity57"
                    quantityVal = quantity57
                    tbStok_quantityUpdate_Eticaret(code, quantity, quantityVal)
                ElseIf quantity58 = "-9999" Then
                    If Q > 0 Then
                        quantity58 = Q
                    Else
                        quantity58 = 0
                    End If
                    quantity = "quantity58"
                    quantityVal = quantity58
                    tbStok_quantityUpdate_Eticaret(code, quantity, quantityVal)
                ElseIf quantity59 = "-9999" Then
                    If Q > 0 Then
                        quantity59 = Q
                    Else
                        quantity59 = 0
                    End If
                    quantity = "quantity59"
                    quantityVal = quantity59
                    tbStok_quantityUpdate_Eticaret(code, quantity, quantityVal)
                ElseIf quantity60 = "-9999" Then
                    If Q > 0 Then
                        quantity60 = Q
                    Else
                        quantity60 = 0
                    End If
                    quantity = "quantity60"
                    quantityVal = quantity60
                    tbStok_quantityUpdate_Eticaret(code, quantity, quantityVal)
                End If

                If quantity1 > "0" Then
                    quantitys += quantity1
                    tbStok_quantitysUpdate_Eticaret(code, quantitys)
                ElseIf quantity2 > "0" Then
                    quantitys += quantity2
                    tbStok_quantitysUpdate_Eticaret(code, quantitys)
                ElseIf quantity3 > "0" Then
                    quantitys += quantity3
                    tbStok_quantitysUpdate_Eticaret(code, quantitys)
                ElseIf quantity4 > "0" Then
                    quantitys += quantity4
                    tbStok_quantitysUpdate_Eticaret(code, quantitys)
                ElseIf quantity5 > "0" Then
                    quantitys += quantity5
                    tbStok_quantitysUpdate_Eticaret(code, quantitys)
                ElseIf quantity6 > "0" Then
                    quantitys += quantity6
                    tbStok_quantitysUpdate_Eticaret(code, quantitys)
                ElseIf quantity7 > "0" Then
                    quantitys += quantity7
                    tbStok_quantitysUpdate_Eticaret(code, quantitys)
                ElseIf quantity8 > "0" Then
                    quantitys += quantity8
                    tbStok_quantitysUpdate_Eticaret(code, quantitys)
                ElseIf quantity9 > "0" Then
                    quantitys += quantity9
                    tbStok_quantitysUpdate_Eticaret(code, quantitys)
                ElseIf quantity10 > "0" Then
                    quantitys += quantity10
                    tbStok_quantitysUpdate_Eticaret(code, quantitys)
                ElseIf quantity11 > "0" Then
                    quantitys += quantity11
                    tbStok_quantitysUpdate_Eticaret(code, quantitys)
                ElseIf quantity12 > "0" Then
                    quantitys += quantity12
                    tbStok_quantitysUpdate_Eticaret(code, quantitys)
                ElseIf quantity13 > "0" Then
                    quantitys += quantity13
                    tbStok_quantitysUpdate_Eticaret(code, quantitys)
                ElseIf quantity14 > "0" Then
                    quantitys += quantity14
                    tbStok_quantitysUpdate_Eticaret(code, quantitys)
                ElseIf quantity15 > "0" Then
                    quantitys += quantity15
                    tbStok_quantitysUpdate_Eticaret(code, quantitys)
                ElseIf quantity16 > "0" Then
                    quantitys += quantity16
                    tbStok_quantitysUpdate_Eticaret(code, quantitys)
                ElseIf quantity17 > "0" Then
                    quantitys += quantity17
                    tbStok_quantitysUpdate_Eticaret(code, quantitys)
                ElseIf quantity18 > "0" Then
                    quantitys += quantity18
                    tbStok_quantitysUpdate_Eticaret(code, quantitys)
                ElseIf quantity19 > "0" Then
                    quantitys += quantity19
                    tbStok_quantitysUpdate_Eticaret(code, quantitys)
                ElseIf quantity20 > "0" Then
                    quantitys += quantity20
                    tbStok_quantitysUpdate_Eticaret(code, quantitys)
                ElseIf quantity21 > "0" Then
                    quantitys += quantity21
                    tbStok_quantitysUpdate_Eticaret(code, quantitys)
                ElseIf quantity22 > "0" Then
                    quantitys += quantity22
                    tbStok_quantitysUpdate_Eticaret(code, quantitys)
                ElseIf quantity23 > "0" Then
                    quantitys += quantity23
                    tbStok_quantitysUpdate_Eticaret(code, quantitys)
                ElseIf quantity24 > "0" Then
                    quantitys += quantity24
                    tbStok_quantitysUpdate_Eticaret(code, quantitys)
                ElseIf quantity25 > "0" Then
                    quantitys += quantity25
                    tbStok_quantitysUpdate_Eticaret(code, quantitys)
                ElseIf quantity26 > "0" Then
                    quantitys += quantity26
                    tbStok_quantitysUpdate_Eticaret(code, quantitys)
                ElseIf quantity27 > "0" Then
                    quantitys += quantity27
                    tbStok_quantitysUpdate_Eticaret(code, quantitys)
                ElseIf quantity28 > "0" Then
                    quantitys += quantity28
                    tbStok_quantitysUpdate_Eticaret(code, quantitys)
                ElseIf quantity29 > "0" Then
                    quantitys += quantity29
                    tbStok_quantitysUpdate_Eticaret(code, quantitys)
                ElseIf quantity30 > "0" Then
                    quantitys += quantity30
                    tbStok_quantitysUpdate_Eticaret(code, quantitys)
                ElseIf quantity31 > "0" Then
                    quantitys += quantity31
                    tbStok_quantitysUpdate_Eticaret(code, quantitys)
                ElseIf quantity32 > "0" Then
                    quantitys += quantity32
                    tbStok_quantitysUpdate_Eticaret(code, quantitys)
                ElseIf quantity33 > "0" Then
                    quantitys += quantity33
                    tbStok_quantitysUpdate_Eticaret(code, quantitys)
                ElseIf quantity34 > "0" Then
                    quantitys += quantity34
                    tbStok_quantitysUpdate_Eticaret(code, quantitys)
                ElseIf quantity35 > "0" Then
                    quantitys += quantity35
                    tbStok_quantitysUpdate_Eticaret(code, quantitys)
                ElseIf quantity36 > "0" Then
                    quantitys += quantity36
                    tbStok_quantitysUpdate_Eticaret(code, quantitys)
                ElseIf quantity37 > "0" Then
                    quantitys += quantity37
                    tbStok_quantitysUpdate_Eticaret(code, quantitys)
                ElseIf quantity38 > "0" Then
                    quantitys += quantity38
                    tbStok_quantitysUpdate_Eticaret(code, quantitys)
                ElseIf quantity39 > "0" Then
                    quantitys += quantity39
                    tbStok_quantitysUpdate_Eticaret(code, quantitys)
                ElseIf quantity40 > "0" Then
                    quantitys += quantity40
                    tbStok_quantitysUpdate_Eticaret(code, quantitys)
                ElseIf quantity41 > "0" Then
                    quantitys += quantity41
                    tbStok_quantitysUpdate_Eticaret(code, quantitys)
                ElseIf quantity42 > "0" Then
                    quantitys += quantity42
                    tbStok_quantitysUpdate_Eticaret(code, quantitys)
                ElseIf quantity43 > "0" Then
                    quantitys += quantity43
                    tbStok_quantitysUpdate_Eticaret(code, quantitys)
                ElseIf quantity44 > "0" Then
                    quantitys += quantity44
                    tbStok_quantitysUpdate_Eticaret(code, quantitys)
                ElseIf quantity45 > "0" Then
                    quantitys += quantity45
                    tbStok_quantitysUpdate_Eticaret(code, quantitys)
                ElseIf quantity46 > "0" Then
                    quantitys += quantity46
                    tbStok_quantitysUpdate_Eticaret(code, quantitys)
                ElseIf quantity47 > "0" Then
                    quantitys += quantity47
                    tbStok_quantitysUpdate_Eticaret(code, quantitys)
                ElseIf quantity48 > "0" Then
                    quantitys += quantity48
                    tbStok_quantitysUpdate_Eticaret(code, quantitys)
                ElseIf quantity49 > "0" Then
                    quantitys += quantity49
                    tbStok_quantitysUpdate_Eticaret(code, quantitys)
                ElseIf quantity50 > "0" Then
                    quantitys += quantity50
                    tbStok_quantitysUpdate_Eticaret(code, quantitys)
                ElseIf quantity51 > "0" Then
                    quantitys += quantity51
                    tbStok_quantitysUpdate_Eticaret(code, quantitys)
                ElseIf quantity52 > "0" Then
                    quantitys += quantity52
                    tbStok_quantitysUpdate_Eticaret(code, quantitys)
                ElseIf quantity53 > "0" Then
                    quantitys += quantity53
                    tbStok_quantitysUpdate_Eticaret(code, quantitys)
                ElseIf quantity54 > "0" Then
                    quantitys += quantity54
                    tbStok_quantitysUpdate_Eticaret(code, quantitys)
                ElseIf quantity55 > "0" Then
                    quantitys += quantity55
                    tbStok_quantitysUpdate_Eticaret(code, quantitys)
                ElseIf quantity56 > "0" Then
                    quantitys += quantity56
                    tbStok_quantitysUpdate_Eticaret(code, quantitys)
                ElseIf quantity57 > "0" Then
                    quantitys += quantity57
                    tbStok_quantitysUpdate_Eticaret(code, quantitys)
                ElseIf quantity58 > "0" Then
                    quantitys += quantity58
                    tbStok_quantitysUpdate_Eticaret(code, quantitys)
                ElseIf quantity59 > "0" Then
                    quantitys += quantity59
                    tbStok_quantitysUpdate_Eticaret(code, quantitys)
                ElseIf quantity60 > "0" Then
                    quantitys += quantity60
                    tbStok_quantitysUpdate_Eticaret(code, quantitys)
                End If




                'tbStok_Update_Eticaret(code, buyPrice, salePrice, listPrice)

            End If
            con1.Close()
        Next


        ' JSON BAÞLANGIÇ


        Dim adapter As New OleDb.OleDbDataAdapter
        Dim cmd5 As New OleDb.OleDbCommand
        Dim con5 As New OleDb.OleDbConnection
        Dim dr4 As DataRow
        Dim DS4 As New DataSet

        con5.ConnectionString = connection
        con5.Open()
        cmd5.CommandText = "select nStokID, code, name, ISNULL(Renk1,0)as Renk1, ISNULL(Beden1,0) as Beden1,  ISNULL(barcode1,0) as barcode1,  ISNULL(Fiyat1,0) as Fiyat1,  ISNULL(quantity1,0) as quantity1,  ISNULL(Renk2,0) as Renk2,  ISNULL(Beden2,0) as Beden2,  ISNULL(barcode2,0) as barcode2,  ISNULL(Fiyat2,0) as Fiyat2,  ISNULL(quantity2,0) as quantity2,  ISNULL(Renk3,0) as Renk3,  ISNULL(Beden3,0) as Beden3,  ISNULL(barcode3,0) as barcode3,  ISNULL(Fiyat3,0) as Fiyat3,  ISNULL(quantity3,0) as quantity3,  ISNULL(Renk4,0) as Renk4,  ISNULL(Beden4,0) as Beden4,  ISNULL(barcode4,0) as barcode4,  ISNULL(Fiyat4,0) as Fiyat4,  ISNULL(quantity4,0) as quantity4,  ISNULL(Renk5,0) as Renk5, ISNULL(Beden5,0) as Beden5, ISNULL(barcode5,0) as barcode5, ISNULL(quantity5,0) as quantity5, ISNULL(Fiyat5,0) as Fiyat5, ISNULL(Renk6,0) as Renk6, ISNULL(Beden6,0) as Beden6, ISNULL(barcode6,0) as barcode6, ISNULL(Fiyat6,0) as Fiyat6, ISNULL(quantity6,0) as quantity6, ISNULL(Renk7,0) as Renk7, ISNULL(Beden7,0) as Beden7, ISNULL(barcode7,0) as barcode7, ISNULL(Fiyat7,0) as Fiyat7, ISNULL(quantity7,0) as quantity7, ISNULL(Renk8,0) as Renk8, ISNULL(Beden8,0) as Beden8, ISNULL(barcode8,0) as barcode8, ISNULL(Fiyat8,0) as Fiyat8, ISNULL(quantity8,0) as quantity8, ISNULL(Renk9,0) as Renk9, ISNULL(Beden9,0) as Beden9, ISNULL(barcode9,0) as barcode9, ISNULL(Fiyat9,0) as Fiyat9, ISNULL(quantity9,0) as quantity9, ISNULL(Renk10,0) as Renk10, ISNULL(Beden10,0) as Beden10, ISNULL(barcode10,0) as barcode10, ISNULL(Fiyat10,0) as Fiyat10, ISNULL(quantity10,0) as quantity10, ISNULL(Renk11,0) as Renk11, ISNULL(Beden11,0) as Beden11, ISNULL(barcode11,0) as barcode11, ISNULL(Fiyat11,0) as Fiyat11, ISNULL(quantity11,0) as quantity11, ISNULL(Renk12,0) as Renk12, ISNULL(Beden12,0) as Beden12, ISNULL(barcode12,0) as barcode12, ISNULL(Fiyat12,0) as Fiyat12, ISNULL(quantity12,0) as quantity12, ISNULL(Renk13,0) as Renk13, ISNULL(Beden13,0) as Beden13, ISNULL(barcode13,0) as barcode13, ISNULL(Fiyat13,0) as Fiyat13, ISNULL(quantity13,0) as quantity13, ISNULL(Renk14,0) as Renk14, ISNULL(Beden14,0) as Beden14, ISNULL(barcode14,0) as barcode14, ISNULL(Fiyat14,0) as Fiyat14, ISNULL(quantity14,0) as quantity14, ISNULL(Renk15,0) as Renk15, ISNULL(Beden15,0) as Beden15, ISNULL(barcode15,0) as barcode15, ISNULL(Fiyat15,0) as Fiyat15, ISNULL(quantity15,0) as quantity15, ISNULL(Renk16,0) as Renk16, ISNULL(Beden16,0) as Beden16, ISNULL(barcode16,0) as barcode16, ISNULL(Fiyat16,0) as Fiyat16, ISNULL(quantity16,0) as quantity16, ISNULL(Renk17,0) as Renk17, ISNULL(Beden17,0) as Beden17, ISNULL(barcode17,0) as barcode17, ISNULL(Fiyat17,0) as Fiyat17, ISNULL(quantity17,0) as quantity17, ISNULL(Renk18,0) as Renk18, ISNULL(Beden18,0) as Beden18, ISNULL(barcode18,0) as barcode18, ISNULL(Fiyat18,0) as Fiyat18, ISNULL(quantity18,0) as quantity18, ISNULL(Renk19,0) as Renk19, ISNULL(Beden19,0) as Beden19, ISNULL(barcode19,0) as barcode19, ISNULL(Fiyat19,0) as Fiyat19, ISNULL(quantity19,0) as quantity19, ISNULL(Renk20,0) as Renk20, ISNULL(Beden20,0) as Beden20, ISNULL(barcode20,0) as barcode20, ISNULL(Fiyat20,0) as Fiyat20, ISNULL(quantity20,0) as quantity20,ISNULL(Renk21,0) as Renk21, ISNULL(Beden21,0) as Beden21, ISNULL(barcode21,0) as barcode21, ISNULL(Fiyat21,0) as Fiyat21, ISNULL(quantity21,0) as quantity21,ISNULL(Renk22,0) as Renk22, ISNULL(Beden22,0) as Beden22, ISNULL(barcode22,0) as barcode22, ISNULL(Fiyat22,0) as Fiyat22, ISNULL(quantity22,0) as quantity22,ISNULL(Renk23,0) as Renk23, ISNULL(Beden23,0) as Beden23, ISNULL(barcode23,0) as barcode23, ISNULL(Fiyat23,0) as Fiyat23, ISNULL(quantity23,0) as quantity23, ISNULL(Renk24,0) as Renk24, ISNULL(Beden24,0) as Beden24, ISNULL(barcode24,0) as barcode24, ISNULL(Fiyat24,0) as Fiyat24, ISNULL(quantity24,0) as quantity24,ISNULL(Renk25,0) as Renk25, ISNULL(Beden25,0) as Beden25, ISNULL(barcode25,0) as barcode25, ISNULL(Fiyat25,0) as Fiyat25, ISNULL(quantity25,0) as quantity25,ISNULL(Renk26,0) as Renk26, ISNULL(Beden26,0) as Beden26, ISNULL(barcode26,0) as barcode26, ISNULL(Fiyat26,0) as Fiyat26, ISNULL(quantity26,0) as quantity26,ISNULL(Renk27,0) as Renk27, ISNULL(Beden27,0) as Beden27, ISNULL(barcode27,0) as barcode27, ISNULL(Fiyat27,0) as Fiyat27, ISNULL(quantity27,0) as quantity27,ISNULL(Renk28,0) as Renk28, ISNULL(Beden28,0) as Beden28, ISNULL(barcode28,0) as barcode28, ISNULL(Fiyat28,0) as Fiyat28, ISNULL(quantity28,0) as quantity28,ISNULL(Renk29,0) as Renk29, ISNULL(Beden29,0) as Beden29, ISNULL(barcode29,0) as barcode29, ISNULL(Fiyat29,0) as Fiyat29, ISNULL(quantity29,0) as quantity29,ISNULL(Renk30,0) as Renk30, ISNULL(Beden30,0) as Beden30, ISNULL(barcode30,0) as barcode30, ISNULL(Fiyat30,0) as Fiyat30, ISNULL(quantity30,0) as quantity30,ISNULL(Renk31,0) as Renk31, ISNULL(Beden31,0) as Beden31, ISNULL(barcode31,0) as barcode31, ISNULL(Fiyat31,0) as Fiyat31, ISNULL(quantity31,0) as quantity31,ISNULL(Renk32,0) as Renk32, ISNULL(Beden32,0) as Beden32, ISNULL(barcode32,0) as barcode32, ISNULL(Fiyat32,0) as Fiyat32, ISNULL(quantity32,0) as quantity32,ISNULL(Renk33,0) as Renk33, ISNULL(Beden33,0) as Beden33, ISNULL(barcode33,0) as barcode33, ISNULL(Fiyat33,0) as Fiyat33, ISNULL(quantity33,0) as quantity33,ISNULL(Renk34,0) as Renk34, ISNULL(Beden34,0) as Beden34, ISNULL(barcode34,0) as barcode34, ISNULL(Fiyat34,0) as Fiyat34, ISNULL(quantity34,0) as quantity34,ISNULL(Renk35,0) as Renk35, ISNULL(Beden35,0) as Beden35, ISNULL(barcode35,0) as barcode35, ISNULL(Fiyat35,0) as Fiyat35, ISNULL(quantity35,0) as quantity35,ISNULL(Renk36,0) as Renk36, ISNULL(Beden36,0) as Beden36, ISNULL(barcode36,0) as barcode36, ISNULL(Fiyat36,0) as Fiyat36, ISNULL(quantity36,0) as quantity36,ISNULL(Renk37,0) as Renk37, ISNULL(Beden37,0) as Beden37, ISNULL(barcode37,0) as barcode37, ISNULL(Fiyat37,0) as Fiyat37, ISNULL(quantity37,0) as quantity37,ISNULL(Renk38,0) as Renk38, ISNULL(Beden38,0) as Beden38, ISNULL(barcode38,0) as barcode38, ISNULL(Fiyat38,0) as Fiyat38, ISNULL(quantity38,0) as quantity38,ISNULL(Renk39,0) as Renk39, ISNULL(Beden39,0) as Beden39, ISNULL(barcode39,0) as barcode39, ISNULL(Fiyat39,0) as Fiyat39, ISNULL(quantity39,0) as quantity39,ISNULL(Renk40,0) as Renk40, ISNULL(Beden40,0) as Beden40, ISNULL(barcode40,0) as barcode40, ISNULL(Fiyat40,0) as Fiyat40, ISNULL(quantity40,0) as quantity40,ISNULL(Renk41,0) as Renk41, ISNULL(Beden41,0) as Beden41, ISNULL(barcode41,0) as barcode41, ISNULL(Fiyat41,0) as Fiyat41, ISNULL(quantity41,0) as quantity41,ISNULL(Renk42,0) as Renk42, ISNULL(Beden42,0) as Beden42, ISNULL(barcode42,0) as barcode42, ISNULL(Fiyat42,0) as Fiyat42, ISNULL(quantity42,0) as quantity42,ISNULL(Renk43,0) as Renk43, ISNULL(Beden43,0) as Beden43, ISNULL(barcode43,0) as barcode43, ISNULL(Fiyat43,0) as Fiyat43, ISNULL(quantity43,0) as quantity43,ISNULL(Renk44,0) as Renk44, ISNULL(Beden44,0) as Beden44, ISNULL(barcode44,0) as barcode44, ISNULL(Fiyat44,0) as Fiyat44, ISNULL(quantity44,0) as quantity44,ISNULL(Renk45,0) as Renk45, ISNULL(Beden45,0) as Beden45, ISNULL(barcode45,0) as barcode45, ISNULL(Fiyat45,0) as Fiyat45, ISNULL(quantity45,0) as quantity45,ISNULL(Renk46,0) as Renk46, ISNULL(Beden46,0) as Beden46, ISNULL(barcode46,0) as barcode46, ISNULL(Fiyat46,0) as Fiyat46, ISNULL(quantity46,0) as quantity46,ISNULL(Renk47,0) as Renk47, ISNULL(Beden47,0) as Beden47, ISNULL(barcode47,0) as barcode47, ISNULL(Fiyat47,0) as Fiyat47, ISNULL(quantity47,0) as quantity47,ISNULL(Renk48,0) as Renk48, ISNULL(Beden48,0) as Beden48, ISNULL(barcode48,0) as barcode48, ISNULL(Fiyat48,0) as Fiyat48, ISNULL(quantity48,0) as quantity48,ISNULL(Renk49,0) as Renk49, ISNULL(Beden49,0) as Beden49, ISNULL(barcode49,0) as barcode49, ISNULL(Fiyat49,0) as Fiyat49, ISNULL(quantity49,0) as quantity49,ISNULL(Renk50,0) as Renk50, ISNULL(Beden50,0) as Beden50, ISNULL(barcode50,0) as barcode50, ISNULL(Fiyat50,0) as Fiyat50, ISNULL(quantity50,0) as quantity50,ISNULL(Renk51,0) as Renk51, ISNULL(Beden51,0) as Beden51, ISNULL(barcode51,0) as barcode51, ISNULL(Fiyat51,0) as Fiyat51, ISNULL(quantity51,0) as quantity51,ISNULL(Renk52,0) as Renk52, ISNULL(Beden52,0) as Beden52, ISNULL(barcode52,0) as barcode52, ISNULL(Fiyat52,0) as Fiyat52, ISNULL(quantity52,0) as quantity52,ISNULL(Renk53,0) as Renk53, ISNULL(Beden53,0) as Beden53, ISNULL(barcode53,0) as barcode53, ISNULL(Fiyat53,0) as Fiyat53, ISNULL(quantity53,0) as quantity53,ISNULL(Renk54,0) as Renk54, ISNULL(Beden54,0) as Beden54, ISNULL(barcode54,0) as barcode54, ISNULL(Fiyat54,0) as Fiyat54, ISNULL(quantity54,0) as quantity54,ISNULL(Renk55,0) as Renk55, ISNULL(Beden55,0) as Beden55, ISNULL(barcode55,0) as barcode55, ISNULL(Fiyat55,0) as Fiyat55, ISNULL(quantity55,0) as quantity55,ISNULL(Renk56,0) as Renk56, ISNULL(Beden56,0) as Beden56, ISNULL(barcode56,0) as barcode56, ISNULL(Fiyat56,0) as Fiyat56, ISNULL(quantity56,0) as quantity56,ISNULL(Renk57,0) as Renk57, ISNULL(Beden57,0) as Beden57, ISNULL(barcode57,0) as barcode57, ISNULL(Fiyat57,0) as Fiyat57, ISNULL(quantity57,0) as quantity57,ISNULL(Renk58,0) as Renk58, ISNULL(Beden58,0) as Beden58, ISNULL(barcode58,0) as barcode58, ISNULL(Fiyat58,0) as Fiyat58, ISNULL(quantity58,0) as quantity58,ISNULL(Renk59,0) as Renk59, ISNULL(Beden59,0) as Beden59, ISNULL(barcode59,0) as barcode59, ISNULL(Fiyat59,0) as Fiyat59, ISNULL(quantity59,0) as quantity59,ISNULL(Renk60,0) as Renk60, ISNULL(Beden60,0) as Beden60, ISNULL(barcode60,0) as barcode60, ISNULL(Fiyat60,0) as Fiyat60, ISNULL(quantity60,0) as quantity60, ISNULL(brand,0) as brand, ISNULL(category1,0) as category1, ISNULL(category2,0) as category2, ISNULL(category3,0) as category3, ISNULL(category4,0) as category4, ISNULL(category5,0) as category5,ISNULL(longDescription,0) as longDescription, ISNULL(seoTitle,0) as seoTitle, ISNULL(seoKeywords,0) as seoKeywords, ISNULL(seoDescription,0) as seoDescription, ISNULL(variant1Name,0) as variant1Name, ISNULL(variant2Name,0) as variant2Name, ISNULL(taxRate,0) as taxRate, ISNULL(shipmentPayment,0) as shipmentPayment, ISNULL(buyPrice,0) as buyPrice, ISNULL(listPrice,0) as listPrice, ISNULL(salePrice,0) as salePrice, ISNULL(TysalePrice,0) as TysalePrice, ISNULL(N11salePrice,0) as N11salePrice, ISNULL(GgsalePrice,0) as GgsalePrice, ISNULL(HbsalePrice,0) as HbsalePrice, ISNULL(EpttsalePrice,0) as EpttsalePrice, ISNULL(CssalePrice,0) as CssalePrice, ISNULL(amzsalePrice,0) as amzsalePrice, ISNULL(NewsalePrice,0) as NewsalePrice, ISNULL(quantity,0) as quantity, ISNULL(imageUrl,0) as imageUrl, ISNULL(imageUrl1,0) as imageUrl1, ISNULL(imageUrl2,0) as imageUrl2, ISNULL(imageUrl3,0) as imageUrl3, ISNULL(imageUrl4,0) as imageUrl4, ISNULL(imageUrl5,0) as imageUrl5, ISNULL(imageUrl6,0) as imageUrl6, ISNULL(imageUrl7,0) as imageUrl7, ISNULL(imageUrl8,0) as imageUrl8, ISNULL(imageUrl9,0) as imageUrl9, ISNULL(imageUrl10,0) as imageUrl10, ISNULL(dteGuncelZaman,0) as dteGuncelZaman from tbStokEticaret where Guncel = '0'  "
        cmd5.Connection = con5
        adapter.SelectCommand = cmd5
        Dim N As Integer = adapter.Fill(DS4, "Table1")

        For Each dr4 In DS4.Tables(0).Rows

            dr4("nStokID") = dr4("nStokID").ToString
            dr4("code") = Trim(dr4("code").ToString)
            dr4("name") = dr4("name").ToString
            dr4("Renk1") = Trim(dr4("Renk1").ToString)
            dr4("Renk2") = Trim(dr4("Renk2").ToString)
            dr4("Renk3") = Trim(dr4("Renk3").ToString)
            dr4("Renk4") = Trim(dr4("Renk4").ToString)
            dr4("Renk5") = Trim(dr4("Renk5").ToString)
            dr4("Renk6") = Trim(dr4("Renk6").ToString)
            dr4("Renk7") = Trim(dr4("Renk7").ToString)
            dr4("Renk8") = Trim(dr4("Renk8").ToString)
            dr4("Renk9") = Trim(dr4("Renk9").ToString)
            dr4("Renk10") = Trim(dr4("Renk10").ToString)
            dr4("Renk11") = Trim(dr4("Renk11").ToString)
            dr4("Renk12") = Trim(dr4("Renk12").ToString)
            dr4("Renk13") = Trim(dr4("Renk13").ToString)
            dr4("Renk14") = Trim(dr4("Renk14").ToString)
            dr4("Renk15") = Trim(dr4("Renk15").ToString)
            dr4("Renk16") = Trim(dr4("Renk16").ToString)
            dr4("Renk17") = Trim(dr4("Renk17").ToString)
            dr4("Renk18") = Trim(dr4("Renk18").ToString)
            dr4("Renk19") = Trim(dr4("Renk19").ToString)
            dr4("Renk20") = Trim(dr4("Renk20").ToString)
            dr4("Renk21") = Trim(dr4("Renk21").ToString)
            dr4("Renk22") = Trim(dr4("Renk22").ToString)
            dr4("Renk23") = Trim(dr4("Renk23").ToString)
            dr4("Renk24") = Trim(dr4("Renk24").ToString)
            dr4("Renk25") = Trim(dr4("Renk25").ToString)
            dr4("Renk26") = Trim(dr4("Renk26").ToString)
            dr4("Renk27") = Trim(dr4("Renk27").ToString)
            dr4("Renk28") = Trim(dr4("Renk28").ToString)
            dr4("Renk29") = Trim(dr4("Renk29").ToString)
            dr4("Renk30") = Trim(dr4("Renk30").ToString)
            dr4("Renk31") = Trim(dr4("Renk31").ToString)
            dr4("Renk32") = Trim(dr4("Renk32").ToString)
            dr4("Renk33") = Trim(dr4("Renk33").ToString)
            dr4("Renk34") = Trim(dr4("Renk34").ToString)
            dr4("Renk35") = Trim(dr4("Renk35").ToString)
            dr4("Renk36") = Trim(dr4("Renk36").ToString)
            dr4("Renk37") = Trim(dr4("Renk37").ToString)
            dr4("Renk38") = Trim(dr4("Renk38").ToString)
            dr4("Renk39") = Trim(dr4("Renk39").ToString)
            dr4("Renk40") = Trim(dr4("Renk40").ToString)
            dr4("Renk41") = Trim(dr4("Renk41").ToString)
            dr4("Renk42") = Trim(dr4("Renk42").ToString)
            dr4("Renk43") = Trim(dr4("Renk43").ToString)
            dr4("Renk44") = Trim(dr4("Renk44").ToString)
            dr4("Renk45") = Trim(dr4("Renk45").ToString)
            dr4("Renk46") = Trim(dr4("Renk46").ToString)
            dr4("Renk47") = Trim(dr4("Renk47").ToString)
            dr4("Renk48") = Trim(dr4("Renk48").ToString)
            dr4("Renk49") = Trim(dr4("Renk49").ToString)
            dr4("Renk50") = Trim(dr4("Renk50").ToString)
            dr4("Renk51") = Trim(dr4("Renk51").ToString)
            dr4("Renk52") = Trim(dr4("Renk52").ToString)
            dr4("Renk53") = Trim(dr4("Renk53").ToString)
            dr4("Renk54") = Trim(dr4("Renk54").ToString)
            dr4("Renk55") = Trim(dr4("Renk55").ToString)
            dr4("Renk56") = Trim(dr4("Renk56").ToString)
            dr4("Renk57") = Trim(dr4("Renk57").ToString)
            dr4("Renk58") = Trim(dr4("Renk58").ToString)
            dr4("Renk59") = Trim(dr4("Renk59").ToString)
            dr4("Renk60") = Trim(dr4("Renk60").ToString)
            dr4("Beden1") = Trim(dr4("Beden1").ToString)
            dr4("Beden2") = Trim(dr4("Beden2").ToString)
            dr4("Beden3") = Trim(dr4("Beden3").ToString)
            dr4("Beden4") = Trim(dr4("Beden4").ToString)
            dr4("Beden5") = Trim(dr4("Beden5").ToString)
            dr4("Beden6") = Trim(dr4("Beden6").ToString)
            dr4("Beden7") = Trim(dr4("Beden7").ToString)
            dr4("Beden8") = Trim(dr4("Beden8").ToString)
            dr4("Beden9") = Trim(dr4("Beden9").ToString)
            dr4("Beden10") = Trim(dr4("Beden10").ToString)
            dr4("Beden11") = Trim(dr4("Beden11").ToString)
            dr4("Beden12") = Trim(dr4("Beden12").ToString)
            dr4("Beden13") = Trim(dr4("Beden13").ToString)
            dr4("Beden14") = Trim(dr4("Beden14").ToString)
            dr4("Beden15") = Trim(dr4("Beden15").ToString)
            dr4("Beden16") = Trim(dr4("Beden16").ToString)
            dr4("Beden17") = Trim(dr4("Beden17").ToString)
            dr4("Beden18") = Trim(dr4("Beden18").ToString)
            dr4("Beden19") = Trim(dr4("Beden19").ToString)
            dr4("Beden20") = Trim(dr4("Beden20").ToString)
            dr4("Beden21") = Trim(dr4("Beden21").ToString)
            dr4("Beden22") = Trim(dr4("Beden22").ToString)
            dr4("Beden23") = Trim(dr4("Beden23").ToString)
            dr4("Beden24") = Trim(dr4("Beden24").ToString)
            dr4("Beden25") = Trim(dr4("Beden25").ToString)
            dr4("Beden26") = Trim(dr4("Beden26").ToString)
            dr4("Beden27") = Trim(dr4("Beden27").ToString)
            dr4("Beden28") = Trim(dr4("Beden28").ToString)
            dr4("Beden29") = Trim(dr4("Beden29").ToString)
            dr4("Beden30") = Trim(dr4("Beden30").ToString)
            dr4("Beden31") = Trim(dr4("Beden31").ToString)
            dr4("Beden32") = Trim(dr4("Beden32").ToString)
            dr4("Beden33") = Trim(dr4("Beden33").ToString)
            dr4("Beden34") = Trim(dr4("Beden34").ToString)
            dr4("Beden35") = Trim(dr4("Beden35").ToString)
            dr4("Beden36") = Trim(dr4("Beden36").ToString)
            dr4("Beden37") = Trim(dr4("Beden37").ToString)
            dr4("Beden38") = Trim(dr4("Beden38").ToString)
            dr4("Beden39") = Trim(dr4("Beden39").ToString)
            dr4("Beden40") = Trim(dr4("Beden40").ToString)
            dr4("Beden41") = Trim(dr4("Beden41").ToString)
            dr4("Beden42") = Trim(dr4("Beden42").ToString)
            dr4("Beden43") = Trim(dr4("Beden43").ToString)
            dr4("Beden44") = Trim(dr4("Beden44").ToString)
            dr4("Beden45") = Trim(dr4("Beden45").ToString)
            dr4("Beden46") = Trim(dr4("Beden46").ToString)
            dr4("Beden47") = Trim(dr4("Beden47").ToString)
            dr4("Beden48") = Trim(dr4("Beden48").ToString)
            dr4("Beden49") = Trim(dr4("Beden49").ToString)
            dr4("Beden50") = Trim(dr4("Beden50").ToString)
            dr4("Beden51") = Trim(dr4("Beden51").ToString)
            dr4("Beden52") = Trim(dr4("Beden52").ToString)
            dr4("Beden53") = Trim(dr4("Beden53").ToString)
            dr4("Beden54") = Trim(dr4("Beden54").ToString)
            dr4("Beden55") = Trim(dr4("Beden55").ToString)
            dr4("Beden56") = Trim(dr4("Beden56").ToString)
            dr4("Beden57") = Trim(dr4("Beden57").ToString)
            dr4("Beden58") = Trim(dr4("Beden58").ToString)
            dr4("Beden59") = Trim(dr4("Beden59").ToString)
            dr4("Beden60") = Trim(dr4("Beden60").ToString)
            dr4("barcode1") = Trim(dr4("barcode1").ToString)
            dr4("barcode2") = Trim(dr4("barcode2").ToString)
            dr4("barcode3") = Trim(dr4("barcode3").ToString)
            dr4("barcode4") = Trim(dr4("barcode4").ToString)
            dr4("barcode5") = Trim(dr4("barcode5").ToString)
            dr4("barcode6") = Trim(dr4("barcode6").ToString)
            dr4("barcode7") = Trim(dr4("barcode7").ToString)
            dr4("barcode8") = Trim(dr4("barcode8").ToString)
            dr4("barcode9") = Trim(dr4("barcode9").ToString)
            dr4("barcode10") = Trim(dr4("barcode10").ToString)
            dr4("barcode11") = Trim(dr4("barcode11").ToString)
            dr4("barcode12") = Trim(dr4("barcode12").ToString)
            dr4("barcode13") = Trim(dr4("barcode13").ToString)
            dr4("barcode14") = Trim(dr4("barcode14").ToString)
            dr4("barcode15") = Trim(dr4("barcode15").ToString)
            dr4("barcode16") = Trim(dr4("barcode16").ToString)
            dr4("barcode17") = Trim(dr4("barcode17").ToString)
            dr4("barcode18") = Trim(dr4("barcode18").ToString)
            dr4("barcode19") = Trim(dr4("barcode19").ToString)
            dr4("barcode20") = Trim(dr4("barcode20").ToString)
            dr4("barcode21") = Trim(dr4("barcode21").ToString)
            dr4("barcode22") = Trim(dr4("barcode22").ToString)
            dr4("barcode23") = Trim(dr4("barcode23").ToString)
            dr4("barcode24") = Trim(dr4("barcode24").ToString)
            dr4("barcode25") = Trim(dr4("barcode25").ToString)
            dr4("barcode26") = Trim(dr4("barcode26").ToString)
            dr4("barcode27") = Trim(dr4("barcode27").ToString)
            dr4("barcode28") = Trim(dr4("barcode28").ToString)
            dr4("barcode29") = Trim(dr4("barcode29").ToString)
            dr4("barcode30") = Trim(dr4("barcode30").ToString)
            dr4("barcode31") = Trim(dr4("barcode31").ToString)
            dr4("barcode32") = Trim(dr4("barcode32").ToString)
            dr4("barcode33") = Trim(dr4("barcode33").ToString)
            dr4("barcode34") = Trim(dr4("barcode34").ToString)
            dr4("barcode35") = Trim(dr4("barcode35").ToString)
            dr4("barcode36") = Trim(dr4("barcode36").ToString)
            dr4("barcode37") = Trim(dr4("barcode37").ToString)
            dr4("barcode38") = Trim(dr4("barcode38").ToString)
            dr4("barcode39") = Trim(dr4("barcode39").ToString)
            dr4("barcode40") = Trim(dr4("barcode40").ToString)
            dr4("barcode41") = Trim(dr4("barcode41").ToString)
            dr4("barcode42") = Trim(dr4("barcode42").ToString)
            dr4("barcode43") = Trim(dr4("barcode43").ToString)
            dr4("barcode44") = Trim(dr4("barcode44").ToString)
            dr4("barcode45") = Trim(dr4("barcode45").ToString)
            dr4("barcode46") = Trim(dr4("barcode46").ToString)
            dr4("barcode47") = Trim(dr4("barcode47").ToString)
            dr4("barcode48") = Trim(dr4("barcode48").ToString)
            dr4("barcode49") = Trim(dr4("barcode49").ToString)
            dr4("barcode50") = Trim(dr4("barcode50").ToString)
            dr4("barcode51") = Trim(dr4("barcode51").ToString)
            dr4("barcode52") = Trim(dr4("barcode52").ToString)
            dr4("barcode53") = Trim(dr4("barcode53").ToString)
            dr4("barcode54") = Trim(dr4("barcode54").ToString)
            dr4("barcode55") = Trim(dr4("barcode55").ToString)
            dr4("barcode56") = Trim(dr4("barcode56").ToString)
            dr4("barcode57") = Trim(dr4("barcode57").ToString)
            dr4("barcode58") = Trim(dr4("barcode58").ToString)
            dr4("barcode59") = Trim(dr4("barcode59").ToString)
            dr4("barcode60") = Trim(dr4("barcode60").ToString)
            dr4("imageUrl") = dr4("imageUrl").ToString
            dr4("imageUrl2") = dr4("imageUrl2").ToString
            dr4("imageUrl3") = dr4("imageUrl3").ToString
            dr4("imageUrl4") = dr4("imageUrl4").ToString
            dr4("imageUrl5") = dr4("imageUrl5").ToString
            dr4("imageUrl6") = dr4("imageUrl6").ToString
            dr4("imageUrl7") = dr4("imageUrl7").ToString
            dr4("imageUrl8") = dr4("imageUrl8").ToString
            dr4("imageUrl9") = dr4("imageUrl9").ToString
            dr4("imageUrl10") = dr4("imageUrl10").ToString
            dr4("taxRate") = dr4("taxRate").ToString
            dr4("shipmentPayment") = dr4("shipmentPayment").ToString
            dr4("buyPrice") = dr4("buyPrice").ToString
            dr4("listPrice") = dr4("listPrice").ToString
            dr4("longDescription") = dr4("longDescription").ToString
            dr4("salePrice") = dr4("salePrice").ToString
            dr4("quantity") = dr4("quantity").ToString
            dr4("dteGuncelZaman") = dr4("dteGuncelZaman").ToString
            priceStatus = 1
            price = dr4("salePrice").ToString
            dr4("TysalePrice") = Trim(dr4("TysalePrice").ToString)
            dr4("N11salePrice") = Trim(dr4("N11salePrice").ToString)
            dr4("GgsalePrice") = Trim(dr4("GgsalePrice").ToString)
            dr4("HbsalePrice") = Trim(dr4("HbsalePrice").ToString)
            dr4("CssalePrice") = Trim(dr4("CssalePrice").ToString)
            dr4("EpttsalePrice") = Trim(dr4("EpttsalePrice").ToString)
            dr4("AmzsalePrice") = Trim(dr4("AmzsalePrice").ToString)
            dr4("quantity1") = Trim(dr4("quantity1").ToString)
            dr4("quantity2") = Trim(dr4("quantity2").ToString)
            dr4("quantity3") = Trim(dr4("quantity3").ToString)
            dr4("quantity4") = Trim(dr4("quantity4").ToString)
            dr4("quantity5") = Trim(dr4("quantity5").ToString)
            dr4("quantity6") = Trim(dr4("quantity6").ToString)
            dr4("quantity7") = Trim(dr4("quantity7").ToString)
            dr4("quantity8") = Trim(dr4("quantity8").ToString)
            dr4("quantity9") = Trim(dr4("quantity9").ToString)
            dr4("quantity10") = Trim(dr4("quantity10").ToString)
            dr4("quantity11") = Trim(dr4("quantity11").ToString)
            dr4("quantity12") = Trim(dr4("quantity12").ToString)
            dr4("quantity13") = Trim(dr4("quantity13").ToString)
            dr4("quantity14") = Trim(dr4("quantity14").ToString)
            dr4("quantity15") = Trim(dr4("quantity15").ToString)
            dr4("quantity16") = Trim(dr4("quantity16").ToString)
            dr4("quantity17") = Trim(dr4("quantity17").ToString)
            dr4("quantity18") = Trim(dr4("quantity18").ToString)
            dr4("quantity19") = Trim(dr4("quantity19").ToString)
            dr4("quantity20") = Trim(dr4("quantity20").ToString)
            dr4("quantity21") = Trim(dr4("quantity21").ToString)
            dr4("quantity22") = Trim(dr4("quantity22").ToString)
            dr4("quantity23") = Trim(dr4("quantity23").ToString)
            dr4("quantity24") = Trim(dr4("quantity24").ToString)
            dr4("quantity25") = Trim(dr4("quantity25").ToString)
            dr4("quantity26") = Trim(dr4("quantity26").ToString)
            dr4("quantity27") = Trim(dr4("quantity27").ToString)
            dr4("quantity28") = Trim(dr4("quantity28").ToString)
            dr4("quantity29") = Trim(dr4("quantity29").ToString)
            dr4("quantity30") = Trim(dr4("quantity30").ToString)
            dr4("quantity31") = Trim(dr4("quantity31").ToString)
            dr4("quantity32") = Trim(dr4("quantity32").ToString)
            dr4("quantity33") = Trim(dr4("quantity33").ToString)
            dr4("quantity34") = Trim(dr4("quantity34").ToString)
            dr4("quantity35") = Trim(dr4("quantity35").ToString)
            dr4("quantity36") = Trim(dr4("quantity36").ToString)
            dr4("quantity37") = Trim(dr4("quantity37").ToString)
            dr4("quantity38") = Trim(dr4("quantity38").ToString)
            dr4("quantity39") = Trim(dr4("quantity39").ToString)
            dr4("quantity40") = Trim(dr4("quantity40").ToString)
            dr4("quantity41") = Trim(dr4("quantity41").ToString)
            dr4("quantity42") = Trim(dr4("quantity42").ToString)
            dr4("quantity43") = Trim(dr4("quantity43").ToString)
            dr4("quantity44") = Trim(dr4("quantity44").ToString)
            dr4("quantity45") = Trim(dr4("quantity45").ToString)
            dr4("quantity46") = Trim(dr4("quantity46").ToString)
            dr4("quantity47") = Trim(dr4("quantity47").ToString)
            dr4("quantity48") = Trim(dr4("quantity48").ToString)
            dr4("quantity49") = Trim(dr4("quantity49").ToString)
            dr4("quantity50") = Trim(dr4("quantity50").ToString)
            dr4("quantity51") = Trim(dr4("quantity51").ToString)
            dr4("quantity52") = Trim(dr4("quantity52").ToString)
            dr4("quantity53") = Trim(dr4("quantity53").ToString)
            dr4("quantity54") = Trim(dr4("quantity54").ToString)
            dr4("quantity55") = Trim(dr4("quantity55").ToString)
            dr4("quantity56") = Trim(dr4("quantity56").ToString)
            dr4("quantity57") = Trim(dr4("quantity57").ToString)
            dr4("quantity58") = Trim(dr4("quantity58").ToString)
            dr4("quantity59") = Trim(dr4("quantity59").ToString)
            dr4("quantity60") = Trim(dr4("quantity60").ToString)
            dr4("brand") = Trim(dr4("brand").ToString)
            'If con1.State = ConnectionState.Closed Then
            '    con1.ConnectionString = connection
            '    cmd1.Connection = con1
            '    con1.Open()
            'End If
            'Dim Sor1 As String = ""
            'cmd1.CommandText = sorgu_queryJson("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT  COUNT (code) FROM tbStokEticaret where code = '" & dr4("code") & "' and Renk2 > '0' ")
            'Sor1 = cmd1.ExecuteScalar.ToString()

            'If Sor1 <= 0 Then
            If con1.State = ConnectionState.Closed Then
                con1.ConnectionString = connection
                cmd1.Connection = con1
                con1.Open()
            End If
            cmd1.CommandText = sorgu_queryJson("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT TOP 1 Product FROM tbParamGenel")
            Url = cmd1.ExecuteScalar.ToString()
            cmd1.CommandText = sorgu_queryJson("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT TOP 1 Product FROM tbParamGenel")
            ProductUpdate = cmd1.ExecuteScalar.ToString()
            con1.Close()
            ProductUpdate += "/product/save"
            If con1.State = ConnectionState.Closed Then
                con1.ConnectionString = connection
                cmd1.Connection = con1
                con1.Open()
            End If
            cmd1.CommandText = sorgu_queryJson("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT TOP 1 ApiKey FROM tbParamGenel")
            ApiKey = cmd1.ExecuteScalar.ToString()
            con1.Close()
            If con1.State = ConnectionState.Closed Then
                con1.ConnectionString = connection
                cmd1.Connection = con1
                con1.Open()
            End If
            cmd1.CommandText = sorgu_queryJson("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT TOP 1 ApiSecret FROM tbParamGenel")
            ApiSecret = cmd1.ExecuteScalar.ToString()
            con1.Close()


            Dim myReq As HttpWebRequest
            Dim myResp As HttpWebResponse
            Dim myReader As StreamReader
            myReq = HttpWebRequest.Create(ProductUpdate)
            myReq.Method = "POST"
            'myReq.ContentType = "application/json"
            'request.ContentType = "application/x-www-form-urlencoded"
            'request.ContentLength = Data.Length

            myReq.ContentType = "application/json"
            myReq.Accept = "application/json"
            myReq.Headers.Add("apikey", "" & ApiKey & "")
            myReq.Headers.Add("apisecret", "" & ApiSecret & "")

            'Full Data Resimler Var Dim Mydata As String = " {""products"": [{""code"": """ & dr4("code") & """,""name"": """ & dr4("name") & """,""invoiceName"": """ & dr4("name") & """,""status"": 1,""seq"": 0,""barcode"": """ & dr4("barcode1") & """,""mpn"": """",""shortDescription"": "" "",""brand"": """ & dr4("category1") & """,""category1"": """ & dr4("category1") & """,""category2"": """ & dr4("category2") & """,""category3"": """ & dr4("category3") & """,""category4"": """ & dr4("category4") & """,""longDescription"": """ & dr4("longDescription") & """,""seoTitle"": """ & dr4("seoTitle") & """,""seoKeywords"": """ & dr4("seoKeywords") & """,""seoDescription"": """ & dr4("seoDescription") & """,""taxRate"": """ & dr4("taxRate") & """,""shipmentPayment"": 1,""currency"": ""TL"",""buyPrice"": """ & dr4("buyPrice") & """,""listPrice"": """ & dr4("listPrice") & """,""salePrice"": """ & dr4("salePrice") & """,""fastSalePrice"": 0.00,""dealerPrice1"": 0.00,""dealerPrice2"": 0.00,""dealerPrice3"": 0.00,""dealerPrice4"": 0.00,""quantity"": """ & dr4("quantity") & """,""desi"": 15,""domestic"": 1,""specialCode1"": ""aa"",""specialCode2"": """",""specialCode3"": """",""specialCode4"": """",""variant1Name"": ""Renk"",""variant2Name"": ""Beden"",""variant3Name"": """",""marketplacePrices"": [{""type"": ""n11"",""currency"": ""TL"",""price"": """ & dr4("buyPrice") & """},{""type"": ""hb"",""currency"": ""TL"",""price"": """ & dr4("buyPrice") & """},{""type"": ""gg"",""currency"": ""TL"",""price"": """ & dr4("buyPrice") & """},{""type"": ""eptt"",""currency"": ""TL"",""price"": """ & dr4("buyPrice") & """},{""type"": ""amz"",""currency"": ""TL"",""price"": """ & dr4("buyPrice") & """},{""type"": ""ty"",""currency"": ""TL"",""price"": """ & dr4("buyPrice") & """},{""type"": ""cs"",""currency"": ""TL"",""price"": """ & dr4("buyPrice") & """}],""variants"": [{""value1"": """ & dr4("Renk1") & """,""value2"": """ & dr4("Beden1") & """,""barcode"": """ & dr4("barcode1") & """,""quantity"": """ & dr4("quantity") & """,""priceStatus"": """ & priceStatus & """,""price"":  """ & price & """},{""value1"": """ & dr4("Renk2") & """,""value2"": """ & dr4("Beden2") & """,""barcode"": """ & dr4("barcode2") & """,""quantity"": """ & dr4("quantity") & """,""priceStatus"": """ & priceStatus & """,""price"":  """ & price & """},{""value1"": """ & dr4("Renk3") & """,""value2"": """ & dr4("Beden3") & """,""barcode"": """ & dr4("barcode3") & """,""quantity"": """ & dr4("quantity") & """,""priceStatus"": """ & priceStatus & """,""price"":  """ & price & """},{""value1"": """ & dr4("Renk4") & """,""value2"": """ & dr4("Beden4") & """,""barcode"": """ & dr4("barcode4") & """,""quantity"": """ & dr4("quantity") & """,""priceStatus"": """ & priceStatus & """,""price"":  """ & price & """},{""value1"": """ & dr4("Renk5") & """,""value2"": """ & dr4("Beden5") & """,""barcode"": """ & dr4("barcode5") & """,""quantity"": """ & dr4("quantity") & """,""priceStatus"": """ & priceStatus & """,""price"":  """ & price & """},{""value1"": """ & dr4("Renk6") & """,""value2"": """ & dr4("Beden6") & """,""barcode"": """ & dr4("barcode6") & """,""quantity"": """ & dr4("quantity") & """,""priceStatus"": """ & priceStatus & """,""price"":  """ & price & """},{""value1"": """ & dr4("Renk7") & """,""value2"": """ & dr4("Beden7") & """,""barcode"": """ & dr4("barcode7") & """,""quantity"": """ & dr4("quantity") & """,""priceStatus"": """ & priceStatus & """,""price"":  """ & price & """},{""value1"": """ & dr4("Renk8") & """,""value2"": """ & dr4("Beden8") & """,""barcode"": """ & dr4("barcode8") & """,""quantity"": """ & dr4("quantity") & """,""priceStatus"": """ & priceStatus & """,""price"":  """ & price & """},{""value1"": """ & dr4("Renk9") & """,""value2"": """ & dr4("Beden9") & """,""barcode"": """ & dr4("barcode9") & """,""quantity"": """ & dr4("quantity") & """,""priceStatus"": """ & priceStatus & """,""price"":  """ & price & """},{""value1"": """ & dr4("Renk10") & """,""value2"": """ & dr4("Beden10") & """,""barcode"": """ & dr4("barcode10") & """,""quantity"": """ & dr4("quantity") & """,""priceStatus"": """ & priceStatus & """,""price"":  """ & price & """},{""value1"": """ & dr4("Renk11") & """,""value2"": """ & dr4("Beden11") & """,""barcode"": """ & dr4("barcode11") & """,""quantity"": """ & dr4("quantity") & """,""priceStatus"": """ & priceStatus & """,""price"":  """ & price & """},{""value1"": """ & dr4("Renk12") & """,""value2"": """ & dr4("Beden12") & """,""barcode"": """ & dr4("barcode12") & """,""quantity"": """ & dr4("quantity") & """,""priceStatus"": """ & priceStatus & """,""price"":  """ & price & """},{""value1"": """ & dr4("Renk13") & """,""value2"": """ & dr4("Beden13") & """,""barcode"": """ & dr4("barcode13") & """,""quantity"": """ & dr4("quantity") & """,""priceStatus"": """ & priceStatus & """,""price"":  """ & price & """},{""value1"": """ & dr4("Renk14") & """,""value2"": """ & dr4("Beden14") & """,""barcode"": """ & dr4("barcode14") & """,""quantity"": """ & dr4("quantity") & """,""priceStatus"": """ & priceStatus & """,""price"":  """ & price & """},{""value1"": """ & dr4("Renk15") & """,""value2"": """ & dr4("Beden15") & """,""barcode"": """ & dr4("barcode15") & """,""quantity"": """ & dr4("quantity") & """,""priceStatus"": """ & priceStatus & """,""price"":  """ & price & """},{""value1"": """ & dr4("Renk16") & """,""value2"": """ & dr4("Beden16") & """,""barcode"": """ & dr4("barcode16") & """,""quantity"": """ & dr4("quantity") & """,""priceStatus"": """ & priceStatus & """,""price"":  """ & price & """},{""value1"": """ & dr4("Renk17") & """,""value2"": """ & dr4("Beden17") & """,""barcode"": """ & dr4("barcode17") & """,""quantity"": """ & dr4("quantity") & """,""priceStatus"": """ & priceStatus & """,""price"":  """ & price & """},{""value1"": """ & dr4("Renk18") & """,""value2"": """ & dr4("Beden18") & """,""barcode"": """ & dr4("barcode18") & """,""quantity"": """ & dr4("quantity") & """,""priceStatus"": """ & priceStatus & """,""price"":  """ & price & """},{""value1"": """ & dr4("Renk19") & """,""value2"": """ & dr4("Beden19") & """,""barcode"": """ & dr4("barcode19") & """,""quantity"": """ & dr4("quantity") & """,""priceStatus"": """ & priceStatus & """,""price"":  """ & price & """},{""value1"": """ & dr4("Renk20") & """,""value2"": """ & dr4("Beden20") & """,""barcode"": """ & dr4("barcode20") & """,""quantity"": """ & dr4("quantity") & """,""priceStatus"": """ & priceStatus & """,""price"":  """ & price & """}],""images"": [{""imageUrl"": """ & dr4("imageUrl") & """},{""imageUrl"": """ & dr4("imageUrl1") & """},{""imageUrl"": """ & dr4("imageUrl2") & """},{""imageUrl"": """ & dr4("imageUrl3") & """},{""imageUrl"": """ & dr4("imageUrl4") & """},{""imageUrl"": """ & dr4("imageUrl5") & """},{""imageUrl"": """ & dr4("imageUrl5") & """},{""imageUrl"": """ & dr4("imageUrl6") & """},{""imageUrl"": """ & dr4("imageUrl7") & """},{""imageUrl"": """ & dr4("imageUrl7") & """},{""imageUrl"": """ & dr4("imageUrl8") & """},{""imageUrl"": """ & dr4("imageUrl9") & """},{""imageUrl"": """ & dr4("imageUrl10") & """}],""attributes"": [{""name"": ""Sezon"",""value"": ""2021""},{""name"": ""Cinsiyet"",""value"": ""Erkek""},{""name"": ""Cinsiyet"",""value"": ""Kadýn""}]}]}"
            'Dim Mydata As String = " {""products"": [{""code"": """ & dr4("code") & """,""name"": """ & dr4("name") & """,""invoiceName"": """ & dr4("name") & """,""status"": 1,""seq"": 0,""barcode"": """ & dr4("barcode1") & """,""mpn"": """",""shortDescription"": "" "",""brand"": """ & dr4("category1") & """,""category1"": """ & dr4("category1") & """,""category2"": """ & dr4("category2") & """,""category3"": """ & dr4("category3") & """,""category4"": """ & dr4("category4") & """,""longDescription"": """ & dr4("longDescription") & """,""seoTitle"": """ & dr4("seoTitle") & """,""seoKeywords"": """ & dr4("seoKeywords") & """,""seoDescription"": """ & dr4("seoDescription") & """,""taxRate"": """ & dr4("taxRate") & """,""shipmentPayment"": 1,""currency"": ""TL"",""buyPrice"": """ & dr4("buyPrice") & """,""listPrice"": """ & dr4("listPrice") & """,""salePrice"": """ & dr4("salePrice") & """,""quantity"": """ & dr4("quantity") & """,""desi"": 15,""domestic"": 1,""variant1Name"": ""Renk"",""variant2Name"": ""Beden"",""variant3Name"": """",""marketplacePrices"": [{""type"": ""n11"",""currency"": ""TL"",""price"": """ & dr4("N11salePrice") & """},{""type"": ""hb"",""currency"": ""TL"",""price"": """ & dr4("HbsalePrice") & """},{""type"": ""gg"",""currency"": ""TL"",""price"": """ & dr4("GgsalePrice") & """},{""type"": ""eptt"",""currency"": ""TL"",""price"": """ & dr4("EpttsalePrice") & """},{""type"": ""amz"",""currency"": ""TL"",""price"": """ & dr4("AmzsalePrice") & """},{""type"": ""ty"",""currency"": ""TL"",""price"": """ & dr4("TysalePrice") & """},{""type"": ""cs"",""currency"": ""TL"",""price"": """ & dr4("CssalePrice") & """}],""variants"": [{""value1"": """ & dr4("Renk1") & """,""value2"": """ & dr4("Beden1") & """,""barcode"": """ & dr4("barcode1") & """,""quantity"": """ & dr4("quantity1") & """,""priceStatus"": """ & priceStatus & """,""price"":  """ & price & """},{""value1"": """ & dr4("Renk2") & """,""value2"": """ & dr4("Beden2") & """,""barcode"": """ & dr4("barcode2") & """,""quantity"": """ & dr4("quantity2") & """,""priceStatus"": """ & priceStatus & """,""price"":  """ & price & """},{""value1"": """ & dr4("Renk3") & """,""value2"": """ & dr4("Beden3") & """,""barcode"": """ & dr4("barcode3") & """,""quantity"": """ & dr4("quantity3") & """,""priceStatus"": """ & priceStatus & """,""price"":  """ & price & """},{""value1"": """ & dr4("Renk4") & """,""value2"": """ & dr4("Beden4") & """,""barcode"": """ & dr4("barcode4") & """,""quantity"": """ & dr4("quantity4") & """,""priceStatus"": """ & priceStatus & """,""price"":  """ & price & """},{""value1"": """ & dr4("Renk5") & """,""value2"": """ & dr4("Beden5") & """,""barcode"": """ & dr4("barcode5") & """,""quantity"": """ & dr4("quantity5") & """,""priceStatus"": """ & priceStatus & """,""price"":  """ & price & """},{""value1"": """ & dr4("Renk6") & """,""value2"": """ & dr4("Beden6") & """,""barcode"": """ & dr4("barcode6") & """,""quantity"": """ & dr4("quantity6") & """,""priceStatus"": """ & priceStatus & """,""price"":  """ & price & """},{""value1"": """ & dr4("Renk7") & """,""value2"": """ & dr4("Beden7") & """,""barcode"": """ & dr4("barcode7") & """,""quantity7"": """ & dr4("quantity7") & """,""priceStatus"": """ & priceStatus & """,""price"":  """ & price & """},{""value1"": """ & dr4("Renk8") & """,""value2"": """ & dr4("Beden8") & """,""barcode"": """ & dr4("barcode8") & """,""quantity"": """ & dr4("quantity8") & """,""priceStatus"": """ & priceStatus & """,""price"":  """ & price & """},{""value1"": """ & dr4("Renk9") & """,""value2"": """ & dr4("Beden9") & """,""barcode"": """ & dr4("barcode9") & """,""quantity"": """ & dr4("quantity9") & """,""priceStatus"": """ & priceStatus & """,""price"":  """ & price & """},{""value1"": """ & dr4("Renk10") & """,""value2"": """ & dr4("Beden10") & """,""barcode"": """ & dr4("barcode10") & """,""quantity"": """ & dr4("quantity10") & """,""priceStatus"": """ & priceStatus & """,""price"":  """ & price & """},{""value1"": """ & dr4("Renk11") & """,""value2"": """ & dr4("Beden11") & """,""barcode"": """ & dr4("barcode11") & """,""quantity"": """ & dr4("quantity11") & """,""priceStatus"": """ & priceStatus & """,""price"":  """ & price & """},{""value1"": """ & dr4("Renk12") & """,""value2"": """ & dr4("Beden12") & """,""barcode"": """ & dr4("barcode12") & """,""quantity"": """ & dr4("quantity12") & """,""priceStatus"": """ & priceStatus & """,""price"":  """ & price & """},{""value1"": """ & dr4("Renk13") & """,""value2"": """ & dr4("Beden13") & """,""barcode"": """ & dr4("barcode13") & """,""quantity"": """ & dr4("quantity13") & """,""priceStatus"": """ & priceStatus & """,""price"":  """ & price & """},{""value1"": """ & dr4("Renk14") & """,""value2"": """ & dr4("Beden14") & """,""barcode"": """ & dr4("barcode14") & """,""quantity"": """ & dr4("quantity14") & """,""priceStatus"": """ & priceStatus & """,""price"":  """ & price & """},{""value1"": """ & dr4("Renk15") & """,""value2"": """ & dr4("Beden15") & """,""barcode"": """ & dr4("barcode15") & """,""quantity"": """ & dr4("quantity15") & """,""priceStatus"": """ & priceStatus & """,""price"":  """ & price & """},{""value1"": """ & dr4("Renk16") & """,""value2"": """ & dr4("Beden16") & """,""barcode"": """ & dr4("barcode16") & """,""quantity"": """ & dr4("quantity16") & """,""priceStatus"": """ & priceStatus & """,""price"":  """ & price & """},{""value1"": """ & dr4("Renk17") & """,""value2"": """ & dr4("Beden17") & """,""barcode"": """ & dr4("barcode17") & """,""quantity"": """ & dr4("quantity17") & """,""priceStatus"": """ & priceStatus & """,""price"":  """ & price & """},{""value1"": """ & dr4("Renk18") & """,""value2"": """ & dr4("Beden18") & """,""barcode"": """ & dr4("barcode18") & """,""quantity"": """ & dr4("quantity18") & """,""priceStatus"": """ & priceStatus & """,""price"":  """ & price & """},{""value1"": """ & dr4("Renk19") & """,""value2"": """ & dr4("Beden19") & """,""barcode"": """ & dr4("barcode19") & """,""quantity"": """ & dr4("quantity19") & """,""priceStatus"": """ & priceStatus & """,""price"":  """ & price & """},{""value1"": """ & dr4("Renk20") & """,""value2"": """ & dr4("Beden20") & """,""barcode"": """ & dr4("barcode20") & """,""quantity"": """ & dr4("quantity20") & """,""priceStatus"": """ & priceStatus & """,""price"":  """ & price & """}],""images"": [{""imageUrl"": """ & dr4("imageUrl") & """},{""imageUrl"": """ & dr4("imageUrl1") & """},{""imageUrl"": """ & dr4("imageUrl2") & """},{""imageUrl"": """ & dr4("imageUrl3") & """},{""imageUrl"": """ & dr4("imageUrl4") & """},{""imageUrl"": """ & dr4("imageUrl5") & """},{""imageUrl"": """ & dr4("imageUrl5") & """},{""imageUrl"": """ & dr4("imageUrl6") & """},{""imageUrl"": """ & dr4("imageUrl7") & """},{""imageUrl"": """ & dr4("imageUrl7") & """},{""imageUrl"": """ & dr4("imageUrl8") & """},{""imageUrl"": """ & dr4("imageUrl9") & """},{""imageUrl"": """ & dr4("imageUrl10") & """}],""attributes"": [{""name"": ""Sezon"",""value"": ""2021""},{""name"": ""Cinsiyet"",""value"": ""Erkek""},{""name"": ""Cinsiyet"",""value"": ""Kadýn""}]}]}"
            'Dim Mydata As String = " {""products"": [{""code"": """ & dr4("code") & """,""name"": """ & dr4("name") & """,""invoiceName"": """ & dr4("name") & """,""status"": 1,""seq"": 0,""barcode"": """ & dr4("barcode1") & """,""mpn"": """",""shortDescription"": "" "",""brand"": """ & dr4("category1") & """,""category1"": """ & dr4("category1") & """,""category2"": """ & dr4("category2") & """,""category3"": """ & dr4("category3") & """,""category4"": """ & dr4("category4") & """,""longDescription"": """ & dr4("longDescription") & """,""seoTitle"": """ & dr4("seoTitle") & """,""seoKeywords"": """ & dr4("seoKeywords") & """,""seoDescription"": """ & dr4("seoDescription") & """,""taxRate"": """ & dr4("taxRate") & """,""shipmentPayment"": 1,""currency"": ""TL"",""buyPrice"": """ & dr4("buyPrice") & """,""listPrice"": """ & dr4("listPrice") & """,""salePrice"": """ & dr4("salePrice") & """,""quantity"": """ & dr4("quantity") & """,""desi"": 15,""domestic"": 1,""variant1Name"": ""Renk"",""variant2Name"": ""Beden"",""variant3Name"": """",""marketplacePrices"": [{""type"": ""n11"",""currency"": ""TL"",""price"": """ & dr4("N11salePrice") & """},{""type"": ""hb"",""currency"": ""TL"",""price"": """ & dr4("HbsalePrice") & """},{""type"": ""gg"",""currency"": ""TL"",""price"": """ & dr4("GgsalePrice") & """},{""type"": ""eptt"",""currency"": ""TL"",""price"": """ & dr4("EpttsalePrice") & """},{""type"": ""amz"",""currency"": ""TL"",""price"": """ & dr4("AmzsalePrice") & """},{""type"": ""ty"",""currency"": ""TL"",""price"": """ & dr4("TysalePrice") & """},{""type"": ""cs"",""currency"": ""TL"",""price"": """ & dr4("CssalePrice") & """}],""variants"": [{""value1"": """ & dr4("Renk1") & """,""value2"": """ & dr4("Beden1") & """,""barcode"": """ & dr4("barcode1") & """,""quantity"": """ & dr4("quantity1") & """,""priceStatus"": """ & priceStatus & """,""price"":  """ & price & """},{""value1"": """ & dr4("Renk2") & """,""value2"": """ & dr4("Beden2") & """,""barcode"": """ & dr4("barcode2") & """,""quantity"": """ & dr4("quantity2") & """,""priceStatus"": """ & priceStatus & """,""price"":  """ & price & """},{""value1"": """ & dr4("Renk3") & """,""value2"": """ & dr4("Beden3") & """,""barcode"": """ & dr4("barcode3") & """,""quantity"": """ & dr4("quantity3") & """,""priceStatus"": """ & priceStatus & """,""price"":  """ & price & """},{""value1"": """ & dr4("Renk4") & """,""value2"": """ & dr4("Beden4") & """,""barcode"": """ & dr4("barcode4") & """,""quantity"": """ & dr4("quantity4") & """,""priceStatus"": """ & priceStatus & """,""price"":  """ & price & """},{""value1"": """ & dr4("Renk5") & """,""value2"": """ & dr4("Beden5") & """,""barcode"": """ & dr4("barcode5") & """,""quantity"": """ & dr4("quantity") & """,""priceStatus"": """ & priceStatus & """,""price"":  """ & price & """},{""value1"": """ & dr4("Renk6") & """,""value2"": """ & dr4("Beden6") & """,""barcode"": """ & dr4("barcode6") & """,""quantity"": """ & dr4("quantity") & """,""priceStatus"": """ & priceStatus & """,""price"":  """ & price & """},{""value1"": """ & dr4("Renk7") & """,""value2"": """ & dr4("Beden7") & """,""barcode"": """ & dr4("barcode7") & """,""quantity"": """ & dr4("quantity") & """,""priceStatus"": """ & priceStatus & """,""price"":  """ & price & """},{""value1"": """ & dr4("Renk8") & """,""value2"": """ & dr4("Beden8") & """,""barcode"": """ & dr4("barcode8") & """,""quantity"": """ & dr4("quantity") & """,""priceStatus"": """ & priceStatus & """,""price"":  """ & price & """},{""value1"": """ & dr4("Renk9") & """,""value2"": """ & dr4("Beden9") & """,""barcode"": """ & dr4("barcode9") & """,""quantity"": """ & dr4("quantity") & """,""priceStatus"": """ & priceStatus & """,""price"":  """ & price & """},{""value1"": """ & dr4("Renk10") & """,""value2"": """ & dr4("Beden10") & """,""barcode"": """ & dr4("barcode10") & """,""quantity"": """ & dr4("quantity") & """,""priceStatus"": """ & priceStatus & """,""price"":  """ & price & """},{""value1"": """ & dr4("Renk11") & """,""value2"": """ & dr4("Beden11") & """,""barcode"": """ & dr4("barcode11") & """,""quantity"": """ & dr4("quantity") & """,""priceStatus"": """ & priceStatus & """,""price"":  """ & price & """},{""value1"": """ & dr4("Renk12") & """,""value2"": """ & dr4("Beden12") & """,""barcode"": """ & dr4("barcode12") & """,""quantity"": """ & dr4("quantity") & """,""priceStatus"": """ & priceStatus & """,""price"":  """ & price & """},{""value1"": """ & dr4("Renk13") & """,""value2"": """ & dr4("Beden13") & """,""barcode"": """ & dr4("barcode13") & """,""quantity"": """ & dr4("quantity") & """,""priceStatus"": """ & priceStatus & """,""price"":  """ & price & """},{""value1"": """ & dr4("Renk14") & """,""value2"": """ & dr4("Beden14") & """,""barcode"": """ & dr4("barcode14") & """,""quantity"": """ & dr4("quantity") & """,""priceStatus"": """ & priceStatus & """,""price"":  """ & price & """},{""value1"": """ & dr4("Renk15") & """,""value2"": """ & dr4("Beden15") & """,""barcode"": """ & dr4("barcode15") & """,""quantity"": """ & dr4("quantity") & """,""priceStatus"": """ & priceStatus & """,""price"":  """ & price & """},{""value1"": """ & dr4("Renk16") & """,""value2"": """ & dr4("Beden16") & """,""barcode"": """ & dr4("barcode16") & """,""quantity"": """ & dr4("quantity") & """,""priceStatus"": """ & priceStatus & """,""price"":  """ & price & """},{""value1"": """ & dr4("Renk17") & """,""value2"": """ & dr4("Beden17") & """,""barcode"": """ & dr4("barcode17") & """,""quantity"": """ & dr4("quantity") & """,""priceStatus"": """ & priceStatus & """,""price"":  """ & price & """},{""value1"": """ & dr4("Renk18") & """,""value2"": """ & dr4("Beden18") & """,""barcode"": """ & dr4("barcode18") & """,""quantity"": """ & dr4("quantity") & """,""priceStatus"": """ & priceStatus & """,""price"":  """ & price & """},{""value1"": """ & dr4("Renk19") & """,""value2"": """ & dr4("Beden19") & """,""barcode"": """ & dr4("barcode19") & """,""quantity"": """ & dr4("quantity") & """,""priceStatus"": """ & priceStatus & """,""price"":  """ & price & """},{""value1"": """ & dr4("Renk20") & """,""value2"": """ & dr4("Beden20") & """,""barcode"": """ & dr4("barcode20") & """,""quantity"": """ & dr4("quantity") & """,""priceStatus"": """ & priceStatus & """,""price"":  """ & price & """}],""images"": [{""imageUrl"": """ & dr4("imageUrl") & """},{""imageUrl"": """ & dr4("imageUrl1") & """},{""imageUrl"": """ & dr4("imageUrl2") & """},{""imageUrl"": """ & dr4("imageUrl3") & """},{""imageUrl"": """ & dr4("imageUrl4") & """},{""imageUrl"": """ & dr4("imageUrl5") & """},{""imageUrl"": """ & dr4("imageUrl5") & """},{""imageUrl"": """ & dr4("imageUrl6") & """},{""imageUrl"": """ & dr4("imageUrl7") & """},{""imageUrl"": """ & dr4("imageUrl7") & """},{""imageUrl"": """ & dr4("imageUrl8") & """},{""imageUrl"": """ & dr4("imageUrl9") & """},{""imageUrl"": """ & dr4("imageUrl10") & """}],""attributes"": [{""name"": ""Sezon"",""value"": ""2021""},{""name"": ""Cinsiyet"",""value"": ""Erkek""},{""name"": ""Cinsiyet"",""value"": ""Kadýn""}]}]}"
            '29.04.2021 bedene göre fiyat öncesi Dim Mydata As String = " {""products"": [{""code"": """ & dr4("code") & """,""name"": """ & dr4("name") & """,""invoiceName"": """ & dr4("name") & """,""status"": 1,""seq"": 0,""barcode"": """ & dr4("barcode1") & """,""mpn"": """",""shortDescription"": "" "",""brand"": """ & dr4("brand") & """,""category1"": """ & dr4("category1") & """,""category2"": """ & dr4("category3") & """,""category3"": """ & dr4("category4") & """,""longDescription"": """ & dr4("longDescription") & """,""seoTitle"": """ & dr4("seoTitle") & """,""seoKeywords"": """ & dr4("seoKeywords") & """,""seoDescription"": """ & dr4("seoDescription") & """,""taxRate"": """ & dr4("taxRate") & """,""shipmentPayment"": 1,""currency"": ""TL"",""buyPrice"": """ & dr4("buyPrice") & """,""listPrice"": """ & dr4("listPrice") & """,""salePrice"": """ & dr4("salePrice") & """,""quantity"": """ & dr4("quantity") & """,""desi"": 15,""domestic"": 1,""variant1Name"": ""Renk"",""variant2Name"": ""Beden"",""variant3Name"": """",""marketplacePrices"": [{""type"": ""n11"",""currency"": ""TL"",""price"": """ & dr4("N11salePrice") & """},{""type"": ""hb"",""currency"": ""TL"",""price"": """ & dr4("HbsalePrice") & """},{""type"": ""gg"",""currency"": ""TL"",""price"": """ & dr4("GgsalePrice") & """},{""type"": ""eptt"",""currency"": ""TL"",""price"": """ & dr4("EpttsalePrice") & """},{""type"": ""amz"",""currency"": ""TL"",""price"": """ & dr4("AmzsalePrice") & """},{""type"": ""ty"",""currency"": ""TL"",""price"": """ & dr4("TysalePrice") & """},{""type"": ""cs"",""currency"": ""TL"",""price"": """ & dr4("CssalePrice") & """}],""variants"": [{""value1"": """ & dr4("Renk1") & """,""value2"": """ & dr4("Beden1") & """,""barcode"": """ & dr4("barcode1") & """,""quantity"": """ & dr4("quantity1") & """,""priceStatus"": """ & priceStatus & """,""price"":  """ & price & """},{""value1"": """ & dr4("Renk2") & """,""value2"": """ & dr4("Beden2") & """,""barcode"": """ & dr4("barcode2") & """,""quantity"": """ & dr4("quantity2") & """,""priceStatus"": """ & priceStatus & """,""price"":  """ & price & """},{""value1"": """ & dr4("Renk3") & """,""value2"": """ & dr4("Beden3") & """,""barcode"": """ & dr4("barcode3") & """,""quantity"": """ & dr4("quantity3") & """,""priceStatus"": """ & priceStatus & """,""price"":  """ & price & """},{""value1"": """ & dr4("Renk4") & """,""value2"": """ & dr4("Beden4") & """,""barcode"": """ & dr4("barcode4") & """,""quantity"": """ & dr4("quantity4") & """,""priceStatus"": """ & priceStatus & """,""price"":  """ & price & """},{""value1"": """ & dr4("Renk5") & """,""value2"": """ & dr4("Beden5") & """,""barcode"": """ & dr4("barcode5") & """,""quantity"": """ & dr4("quantity5") & """,""priceStatus"": """ & priceStatus & """,""price"":  """ & price & """},{""value1"": """ & dr4("Renk6") & """,""value2"": """ & dr4("Beden6") & """,""barcode"": """ & dr4("barcode6") & """,""quantity"": """ & dr4("quantity6") & """,""priceStatus"": """ & priceStatus & """,""price"":  """ & price & """},{""value1"": """ & dr4("Renk7") & """,""value2"": """ & dr4("Beden7") & """,""barcode"": """ & dr4("barcode7") & """,""quantity"": """ & dr4("quantity7") & """,""priceStatus"": """ & priceStatus & """,""price"":  """ & price & """},{""value1"": """ & dr4("Renk8") & """,""value2"": """ & dr4("Beden8") & """,""barcode"": """ & dr4("barcode8") & """,""quantity"": """ & dr4("quantity8") & """,""priceStatus"": """ & priceStatus & """,""price"":  """ & price & """},{""value1"": """ & dr4("Renk9") & """,""value2"": """ & dr4("Beden9") & """,""barcode"": """ & dr4("barcode9") & """,""quantity"": """ & dr4("quantity9") & """,""priceStatus"": """ & priceStatus & """,""price"":  """ & price & """},{""value1"": """ & dr4("Renk10") & """,""value2"": """ & dr4("Beden10") & """,""barcode"": """ & dr4("barcode10") & """,""quantity"": """ & dr4("quantity10") & """,""priceStatus"": """ & priceStatus & """,""price"":  """ & price & """},{""value1"": """ & dr4("Renk11") & """,""value2"": """ & dr4("Beden11") & """,""barcode"": """ & dr4("barcode11") & """,""quantity"": """ & dr4("quantity11") & """,""priceStatus"": """ & priceStatus & """,""price"":  """ & price & """},{""value1"": """ & dr4("Renk12") & """,""value2"": """ & dr4("Beden12") & """,""barcode"": """ & dr4("barcode12") & """,""quantity"": """ & dr4("quantity12") & """,""priceStatus"": """ & priceStatus & """,""price"":  """ & price & """},{""value1"": """ & dr4("Renk13") & """,""value2"": """ & dr4("Beden13") & """,""barcode"": """ & dr4("barcode13") & """,""quantity"": """ & dr4("quantity13") & """,""priceStatus"": """ & priceStatus & """,""price"":  """ & price & """},{""value1"": """ & dr4("Renk14") & """,""value2"": """ & dr4("Beden14") & """,""barcode"": """ & dr4("barcode14") & """,""quantity"": """ & dr4("quantity14") & """,""priceStatus"": """ & priceStatus & """,""price"":  """ & price & """},{""value1"": """ & dr4("Renk15") & """,""value2"": """ & dr4("Beden15") & """,""barcode"": """ & dr4("barcode15") & """,""quantity"": """ & dr4("quantity15") & """,""priceStatus"": """ & priceStatus & """,""price"":  """ & price & """},{""value1"": """ & dr4("Renk16") & """,""value2"": """ & dr4("Beden16") & """,""barcode"": """ & dr4("barcode16") & """,""quantity"": """ & dr4("quantity16") & """,""priceStatus"": """ & priceStatus & """,""price"":  """ & price & """},{""value1"": """ & dr4("Renk17") & """,""value2"": """ & dr4("Beden17") & """,""barcode"": """ & dr4("barcode17") & """,""quantity"": """ & dr4("quantity17") & """,""priceStatus"": """ & priceStatus & """,""price"":  """ & price & """},{""value1"": """ & dr4("Renk18") & """,""value2"": """ & dr4("Beden18") & """,""barcode"": """ & dr4("barcode18") & """,""quantity"": """ & dr4("quantity18") & """,""priceStatus"": """ & priceStatus & """,""price"":  """ & price & """},{""value1"": """ & dr4("Renk19") & """,""value2"": """ & dr4("Beden19") & """,""barcode"": """ & dr4("barcode19") & """,""quantity"": """ & dr4("quantity19") & """,""priceStatus"": """ & priceStatus & """,""price"":  """ & price & """},{""value1"": """ & dr4("Renk20") & """,""value2"": """ & dr4("Beden20") & """,""barcode"": """ & dr4("barcode20") & """,""quantity"": """ & dr4("quantity20") & """,""priceStatus"": """ & priceStatus & """,""price"":  """ & price & """}],""images"": [{""imageUrl"": """ & dr4("imageUrl") & """},{""imageUrl"": """ & dr4("imageUrl1") & """},{""imageUrl"": """ & dr4("imageUrl2") & """},{""imageUrl"": """ & dr4("imageUrl3") & """},{""imageUrl"": """ & dr4("imageUrl4") & """},{""imageUrl"": """ & dr4("imageUrl5") & """},{""imageUrl"": """ & dr4("imageUrl5") & """},{""imageUrl"": """ & dr4("imageUrl6") & """},{""imageUrl"": """ & dr4("imageUrl7") & """},{""imageUrl"": """ & dr4("imageUrl7") & """},{""imageUrl"": """ & dr4("imageUrl8") & """},{""imageUrl"": """ & dr4("imageUrl9") & """},{""imageUrl"": """ & dr4("imageUrl10") & """}],""attributes"": [{""name"": ""Sezon"",""value"": """ & dr4("category2") & """},{""name"": ""Cinsiyet"",""value"": """ & dr4("category1") & """}]}]}"
            Dim Mydata As String = " {""products"": [{""code"": """ & dr4("code") & """,""name"": """ & dr4("name") & """,""invoiceName"": """ & dr4("name") & """,""status"": 1,""seq"": 0,""barcode"": """ & dr4("barcode1") & """,""mpn"": """",""shortDescription"": "" "",""brand"": """ & dr4("brand") & """,""category1"": """ & dr4("category1") & """,""category2"": """ & dr4("category3") & """,""category3"": """ & dr4("category4") & """,""longDescription"": """ & dr4("longDescription") & """,""seoTitle"": """ & dr4("seoTitle") & """,""seoKeywords"": """ & dr4("seoKeywords") & """,""seoDescription"": """ & dr4("seoDescription") & """,""taxRate"": """ & dr4("taxRate") & """,""shipmentPayment"": 1,""currency"": ""TL"",""buyPrice"": """ & dr4("buyPrice") & """,""listPrice"": """ & dr4("listPrice") & """,""salePrice"": """ & dr4("salePrice") & """,""quantity"": """ & dr4("quantity") & """,""desi"": 15,""domestic"": 1,""variant1Name"": ""Renk"",""variant2Name"": ""Beden"",""variant3Name"": """",""marketplacePrices"": [{""type"": ""n11"",""currency"": ""TL"",""price"": """ & dr4("N11salePrice") & """},{""type"": ""hb"",""currency"": ""TL"",""price"": """ & dr4("HbsalePrice") & """},{""type"": ""gg"",""currency"": ""TL"",""price"": """ & dr4("GgsalePrice") & """},{""type"": ""eptt"",""currency"": ""TL"",""price"": """ & dr4("EpttsalePrice") & """},{""type"": ""amz"",""currency"": ""TL"",""price"": """ & dr4("AmzsalePrice") & """},{""type"": ""ty"",""currency"": ""TL"",""price"": """ & dr4("TysalePrice") & """},{""type"": ""cs"",""currency"": ""TL"",""price"": """ & dr4("CssalePrice") & """}],""variants"": [{""value1"": """ & dr4("Renk1") & """,""value2"": """ & dr4("Beden1") & """,""barcode"": """ & dr4("barcode1") & """,""quantity"": """ & dr4("quantity1") & """,""priceStatus"": """ & priceStatus & """,""price"":  """ & dr4("Fiyat1") & """},{""value1"": """ & dr4("Renk2") & """,""value2"": """ & dr4("Beden2") & """,""barcode"": """ & dr4("barcode2") & """,""quantity"": """ & dr4("quantity2") & """,""priceStatus"": """ & priceStatus & """,""price"":  """ & dr4("Fiyat2") & """},{""value1"": """ & dr4("Renk3") & """,""value2"": """ & dr4("Beden3") & """,""barcode"": """ & dr4("barcode3") & """,""quantity"": """ & dr4("quantity3") & """,""priceStatus"": """ & priceStatus & """,""price"":  """ & dr4("Fiyat3") & """},{""value1"": """ & dr4("Renk4") & """,""value2"": """ & dr4("Beden4") & """,""barcode"": """ & dr4("barcode4") & """,""quantity"": """ & dr4("quantity4") & """,""priceStatus"": """ & priceStatus & """,""price"":  """ & dr4("Fiyat4") & """},{""value1"": """ & dr4("Renk5") & """,""value2"": """ & dr4("Beden5") & """,""barcode"": """ & dr4("barcode5") & """,""quantity"": """ & dr4("quantity5") & """,""priceStatus"": """ & priceStatus & """,""price"":  """ & dr4("Fiyat5") & """},{""value1"": """ & dr4("Renk6") & """,""value2"": """ & dr4("Beden6") & """,""barcode"": """ & dr4("barcode6") & """,""quantity"": """ & dr4("quantity6") & """,""priceStatus"": """ & priceStatus & """,""price"":  """ & dr4("Fiyat6") & """},{""value1"": """ & dr4("Renk7") & """,""value2"": """ & dr4("Beden7") & """,""barcode"": """ & dr4("barcode7") & """,""quantity"": """ & dr4("quantity7") & """,""priceStatus"": """ & priceStatus & """,""price"":  """ & dr4("Fiyat7") & """},{""value1"": """ & dr4("Renk8") & """,""value2"": """ & dr4("Beden8") & """,""barcode"": """ & dr4("barcode8") & """,""quantity"": """ & dr4("quantity8") & """,""priceStatus"": """ & priceStatus & """,""price"":  """ & dr4("Fiyat8") & """},{""value1"": """ & dr4("Renk9") & """,""value2"": """ & dr4("Beden9") & """,""barcode"": """ & dr4("barcode9") & """,""quantity"": """ & dr4("quantity9") & """,""priceStatus"": """ & priceStatus & """,""price"":  """ & dr4("Fiyat9") & """},{""value1"": """ & dr4("Renk10") & """,""value2"": """ & dr4("Beden10") & """,""barcode"": """ & dr4("barcode10") & """,""quantity"": """ & dr4("quantity10") & """,""priceStatus"": """ & priceStatus & """,""price"":  """ & dr4("Fiyat10") & """},{""value1"": """ & dr4("Renk11") & """,""value2"": """ & dr4("Beden11") & """,""barcode"": """ & dr4("barcode11") & """,""quantity"": """ & dr4("quantity11") & """,""priceStatus"": """ & priceStatus & """,""price"":  """ & dr4("Fiyat11") & """},{""value1"": """ & dr4("Renk12") & """,""value2"": """ & dr4("Beden12") & """,""barcode"": """ & dr4("barcode12") & """,""quantity"": """ & dr4("quantity12") & """,""priceStatus"": """ & priceStatus & """,""price"":  """ & dr4("Fiyat12") & """},{""value1"": """ & dr4("Renk13") & """,""value2"": """ & dr4("Beden13") & """,""barcode"": """ & dr4("barcode13") & """,""quantity"": """ & dr4("quantity13") & """,""priceStatus"": """ & priceStatus & """,""price"":  """ & dr4("Fiyat13") & """},{""value1"": """ & dr4("Renk14") & """,""value2"": """ & dr4("Beden14") & """,""barcode"": """ & dr4("barcode14") & """,""quantity"": """ & dr4("quantity14") & """,""priceStatus"": """ & priceStatus & """,""price"":  """ & dr4("Fiyat14") & """},{""value1"": """ & dr4("Renk15") & """,""value2"": """ & dr4("Beden15") & """,""barcode"": """ & dr4("barcode15") & """,""quantity"": """ & dr4("quantity15") & """,""priceStatus"": """ & priceStatus & """,""price"":  """ & dr4("Fiyat15") & """},{""value1"": """ & dr4("Renk16") & """,""value2"": """ & dr4("Beden16") & """,""barcode"": """ & dr4("barcode16") & """,""quantity"": """ & dr4("quantity16") & """,""priceStatus"": """ & priceStatus & """,""price"":  """ & dr4("Fiyat16") & """},{""value1"": """ & dr4("Renk17") & """,""value2"": """ & dr4("Beden17") & """,""barcode"": """ & dr4("barcode17") & """,""quantity"": """ & dr4("quantity17") & """,""priceStatus"": """ & priceStatus & """,""price"":  """ & dr4("Fiyat17") & """},{""value1"": """ & dr4("Renk18") & """,""value2"": """ & dr4("Beden18") & """,""barcode"": """ & dr4("barcode18") & """,""quantity"": """ & dr4("quantity18") & """,""priceStatus"": """ & priceStatus & """,""price"":  """ & dr4("Fiyat18") & """},{""value1"": """ & dr4("Renk19") & """,""value2"": """ & dr4("Beden19") & """,""barcode"": """ & dr4("barcode19") & """,""quantity"": """ & dr4("quantity19") & """,""priceStatus"": """ & priceStatus & """,""price"":  """ & dr4("Fiyat19") & """},{""value1"": """ & dr4("Renk55") & """,""value2"": """ & dr4("Beden55") & """,""barcode"": """ & dr4("barcode55") & """,""quantity"": """ & dr4("quantity55") & """,""priceStatus"": """ & priceStatus & """,""price"":  """ & dr4("Fiyat55") & """},{""value1"": """ & dr4("Renk21") & """,""value2"": """ & dr4("Beden21") & """,""barcode"": """ & dr4("barcode21") & """,""quantity"": """ & dr4("quantity21") & """,""priceStatus"": """ & priceStatus & """,""price"":  """ & dr4("Fiyat21") & """},{""value1"": """ & dr4("Renk22") & """,""value2"": """ & dr4("Beden22") & """,""barcode"": """ & dr4("barcode22") & """,""quantity"": """ & dr4("quantity22") & """,""priceStatus"": """ & priceStatus & """,""price"":  """ & dr4("Fiyat22") & """},{""value1"": """ & dr4("Renk23") & """,""value2"": """ & dr4("Beden23") & """,""barcode"": """ & dr4("barcode23") & """,""quantity"": """ & dr4("quantity23") & """,""priceStatus"": """ & priceStatus & """,""price"":  """ & dr4("Fiyat23") & """},{""value1"": """ & dr4("Renk24") & """,""value2"": """ & dr4("Beden24") & """,""barcode"": """ & dr4("barcode24") & """,""quantity"": """ & dr4("quantity24") & """,""priceStatus"": """ & priceStatus & """,""price"":  """ & dr4("Fiyat24") & """},{""value1"": """ & dr4("Renk25") & """,""value2"": """ & dr4("Beden25") & """,""barcode"": """ & dr4("barcode25") & """,""quantity"": """ & dr4("quantity25") & """,""priceStatus"": """ & priceStatus & """,""price"":  """ & dr4("Fiyat25") & """},{""value1"": """ & dr4("Renk26") & """,""value2"": """ & dr4("Beden26") & """,""barcode"": """ & dr4("barcode26") & """,""quantity"": """ & dr4("quantity26") & """,""priceStatus"": """ & priceStatus & """,""price"":  """ & dr4("Fiyat26") & """},{""value1"": """ & dr4("Renk27") & """,""value2"": """ & dr4("Beden27") & """,""barcode"": """ & dr4("barcode27") & """,""quantity"": """ & dr4("quantity27") & """,""priceStatus"": """ & priceStatus & """,""price"":  """ & dr4("Fiyat27") & """},{""value1"": """ & dr4("Renk28") & """,""value2"": """ & dr4("Beden28") & """,""barcode"": """ & dr4("barcode28") & """,""quantity"": """ & dr4("quantity28") & """,""priceStatus"": """ & priceStatus & """,""price"":  """ & dr4("Fiyat28") & """},{""value1"": """ & dr4("Renk29") & """,""value2"": """ & dr4("Beden29") & """,""barcode"": """ & dr4("barcode29") & """,""quantity"": """ & dr4("quantity29") & """,""priceStatus"": """ & priceStatus & """,""price"":  """ & dr4("Fiyat29") & """},{""value1"": """ & dr4("Renk30") & """,""value2"": """ & dr4("Beden30") & """,""barcode"": """ & dr4("barcode30") & """,""quantity"": """ & dr4("quantity30") & """,""priceStatus"": """ & priceStatus & """,""price"":  """ & dr4("Fiyat30") & """},{""value1"": """ & dr4("Renk31") & """,""value2"": """ & dr4("Beden31") & """,""barcode"": """ & dr4("barcode31") & """,""quantity"": """ & dr4("quantity31") & """,""priceStatus"": """ & priceStatus & """,""price"":  """ & dr4("Fiyat31") & """},{""value1"": """ & dr4("Renk32") & """,""value2"": """ & dr4("Beden32") & """,""barcode"": """ & dr4("barcode32") & """,""quantity"": """ & dr4("quantity32") & """,""priceStatus"": """ & priceStatus & """,""price"":  """ & dr4("Fiyat32") & """},{""value1"": """ & dr4("Renk33") & """,""value2"": """ & dr4("Beden33") & """,""barcode"": """ & dr4("barcode33") & """,""quantity"": """ & dr4("quantity33") & """,""priceStatus"": """ & priceStatus & """,""price"":  """ & dr4("Fiyat33") & """},{""value1"": """ & dr4("Renk34") & """,""value2"": """ & dr4("Beden34") & """,""barcode"": """ & dr4("barcode34") & """,""quantity"": """ & dr4("quantity34") & """,""priceStatus"": """ & priceStatus & """,""price"":  """ & dr4("Fiyat34") & """},{""value1"": """ & dr4("Renk35") & """,""value2"": """ & dr4("Beden35") & """,""barcode"": """ & dr4("barcode35") & """,""quantity"": """ & dr4("quantity35") & """,""priceStatus"": """ & priceStatus & """,""price"":  """ & dr4("Fiyat35") & """},{""value1"": """ & dr4("Renk36") & """,""value2"": """ & dr4("Beden36") & """,""barcode"": """ & dr4("barcode36") & """,""quantity"": """ & dr4("quantity36") & """,""priceStatus"": """ & priceStatus & """,""price"":  """ & dr4("Fiyat36") & """},{""value1"": """ & dr4("Renk37") & """,""value2"": """ & dr4("Beden37") & """,""barcode"": """ & dr4("barcode37") & """,""quantity"": """ & dr4("quantity37") & """,""priceStatus"": """ & priceStatus & """,""price"":  """ & dr4("Fiyat37") & """},{""value1"": """ & dr4("Renk38") & """,""value2"": """ & dr4("Beden38") & """,""barcode"": """ & dr4("barcode38") & """,""quantity"": """ & dr4("quantity38") & """,""priceStatus"": """ & priceStatus & """,""price"":  """ & dr4("Fiyat38") & """},{""value1"": """ & dr4("Renk39") & """,""value2"": """ & dr4("Beden39") & """,""barcode"": """ & dr4("barcode39") & """,""quantity"": """ & dr4("quantity39") & """,""priceStatus"": """ & priceStatus & """,""price"":  """ & dr4("Fiyat39") & """},{""value1"": """ & dr4("Renk40") & """,""value2"": """ & dr4("Beden40") & """,""barcode"": """ & dr4("barcode40") & """,""quantity"": """ & dr4("quantity40") & """,""priceStatus"": """ & priceStatus & """,""price"":  """ & dr4("Fiyat40") & """},{""value1"": """ & dr4("Renk41") & """,""value2"": """ & dr4("Beden41") & """,""barcode"": """ & dr4("barcode41") & """,""quantity"": """ & dr4("quantity41") & """,""priceStatus"": """ & priceStatus & """,""price"":  """ & dr4("Fiyat41") & """},{""value1"": """ & dr4("Renk42") & """,""value2"": """ & dr4("Beden42") & """,""barcode"": """ & dr4("barcode42") & """,""quantity"": """ & dr4("quantity42") & """,""priceStatus"": """ & priceStatus & """,""price"":  """ & dr4("Fiyat42") & """},{""value1"": """ & dr4("Renk43") & """,""value2"": """ & dr4("Beden43") & """,""barcode"": """ & dr4("barcode43") & """,""quantity"": """ & dr4("quantity43") & """,""priceStatus"": """ & priceStatus & """,""price"":  """ & dr4("Fiyat43") & """},{""value1"": """ & dr4("Renk44") & """,""value2"": """ & dr4("Beden44") & """,""barcode"": """ & dr4("barcode44") & """,""quantity"": """ & dr4("quantity44") & """,""priceStatus"": """ & priceStatus & """,""price"":  """ & dr4("Fiyat44") & """},{""value1"": """ & dr4("Renk45") & """,""value2"": """ & dr4("Beden45") & """,""barcode"": """ & dr4("barcode45") & """,""quantity"": """ & dr4("quantity45") & """,""priceStatus"": """ & priceStatus & """,""price"":  """ & dr4("Fiyat45") & """},{""value1"": """ & dr4("Renk46") & """,""value2"": """ & dr4("Beden46") & """,""barcode"": """ & dr4("barcode46") & """,""quantity"": """ & dr4("quantity46") & """,""priceStatus"": """ & priceStatus & """,""price"":  """ & dr4("Fiyat46") & """},{""value1"": """ & dr4("Renk47") & """,""value2"": """ & dr4("Beden47") & """,""barcode"": """ & dr4("barcode47") & """,""quantity"": """ & dr4("quantity47") & """,""priceStatus"": """ & priceStatus & """,""price"":  """ & dr4("Fiyat47") & """},{""value1"": """ & dr4("Renk48") & """,""value2"": """ & dr4("Beden48") & """,""barcode"": """ & dr4("barcode48") & """,""quantity"": """ & dr4("quantity48") & """,""priceStatus"": """ & priceStatus & """,""price"":  """ & dr4("Fiyat48") & """},{""value1"": """ & dr4("Renk49") & """,""value2"": """ & dr4("Beden49") & """,""barcode"": """ & dr4("barcode49") & """,""quantity"": """ & dr4("quantity49") & """,""priceStatus"": """ & priceStatus & """,""price"":  """ & dr4("Fiyat49") & """},{""value1"": """ & dr4("Renk50") & """,""value2"": """ & dr4("Beden50") & """,""barcode"": """ & dr4("barcode50") & """,""quantity"": """ & dr4("quantity50") & """,""priceStatus"": """ & priceStatus & """,""price"":  """ & dr4("Fiyat50") & """},{""value1"": """ & dr4("Renk51") & """,""value2"": """ & dr4("Beden51") & """,""barcode"": """ & dr4("barcode51") & """,""quantity"": """ & dr4("quantity51") & """,""priceStatus"": """ & priceStatus & """,""price"":  """ & dr4("Fiyat51") & """},{""value1"": """ & dr4("Renk52") & """,""value2"": """ & dr4("Beden52") & """,""barcode"": """ & dr4("barcode52") & """,""quantity"": """ & dr4("quantity52") & """,""priceStatus"": """ & priceStatus & """,""price"":  """ & dr4("Fiyat52") & """},{""value1"": """ & dr4("Renk53") & """,""value2"": """ & dr4("Beden53") & """,""barcode"": """ & dr4("barcode53") & """,""quantity"": """ & dr4("quantity53") & """,""priceStatus"": """ & priceStatus & """,""price"":  """ & dr4("Fiyat53") & """},{""value1"": """ & dr4("Renk54") & """,""value2"": """ & dr4("Beden54") & """,""barcode"": """ & dr4("barcode54") & """,""quantity"": """ & dr4("quantity54") & """,""priceStatus"": """ & priceStatus & """,""price"":  """ & dr4("Fiyat54") & """},{""value1"": """ & dr4("Renk55") & """,""value2"": """ & dr4("Beden55") & """,""barcode"": """ & dr4("barcode55") & """,""quantity"": """ & dr4("quantity55") & """,""priceStatus"": """ & priceStatus & """,""price"":  """ & dr4("Fiyat55") & """},{""value1"": """ & dr4("Renk56") & """,""value2"": """ & dr4("Beden56") & """,""barcode"": """ & dr4("barcode56") & """,""quantity"": """ & dr4("quantity56") & """,""priceStatus"": """ & priceStatus & """,""price"":  """ & dr4("Fiyat56") & """},{""value1"": """ & dr4("Renk57") & """,""value2"": """ & dr4("Beden57") & """,""barcode"": """ & dr4("barcode57") & """,""quantity"": """ & dr4("quantity57") & """,""priceStatus"": """ & priceStatus & """,""price"":  """ & dr4("Fiyat57") & """},{""value1"": """ & dr4("Renk58") & """,""value2"": """ & dr4("Beden58") & """,""barcode"": """ & dr4("barcode58") & """,""quantity"": """ & dr4("quantity58") & """,""priceStatus"": """ & priceStatus & """,""price"":  """ & dr4("Fiyat58") & """},{""value1"": """ & dr4("Renk59") & """,""value2"": """ & dr4("Beden59") & """,""barcode"": """ & dr4("barcode59") & """,""quantity"": """ & dr4("quantity59") & """,""priceStatus"": """ & priceStatus & """,""price"":  """ & dr4("Fiyat59") & """},{""value1"": """ & dr4("Renk60") & """,""value2"": """ & dr4("Beden60") & """,""barcode"": """ & dr4("barcode60") & """,""quantity"": """ & dr4("quantity60") & """,""priceStatus"": """ & priceStatus & """,""price"":  """ & dr4("Fiyat60") & """}],""images"": [{""imageUrl"": """ & dr4("imageUrl") & """},{""imageUrl"": """ & dr4("imageUrl1") & """},{""imageUrl"": """ & dr4("imageUrl2") & """},{""imageUrl"": """ & dr4("imageUrl3") & """},{""imageUrl"": """ & dr4("imageUrl4") & """},{""imageUrl"": """ & dr4("imageUrl5") & """},{""imageUrl"": """ & dr4("imageUrl5") & """},{""imageUrl"": """ & dr4("imageUrl6") & """},{""imageUrl"": """ & dr4("imageUrl7") & """},{""imageUrl"": """ & dr4("imageUrl7") & """},{""imageUrl"": """ & dr4("imageUrl8") & """},{""imageUrl"": """ & dr4("imageUrl9") & """},{""imageUrl"": """ & dr4("imageUrl10") & """}],""attributes"": [{""name"": ""Cinsi"",""value"": """ & dr4("category2") & """},{""name"": ""Grubu"",""value"": """ & dr4("category1") & """}]}]}"

            'Dim Mydata As String = " {""products"": [{""code"": """ & dr4("code") & """,""name"": """ & dr4("name") & """,""invoiceName"": """ & dr4("name") & """,""status"": 1,""seq"": 0,""barcode"": """ & dr4("barcode1") & """,""mpn"": """",""shortDescription"": "" "",""brand"": """ & dr4("category1") & """,""category1"": """ & dr4("category1") & """,""category2"": """ & dr4("category2") & """,""category3"": """ & dr4("category3") & """,""category4"": """ & dr4("category4") & """,""longDescription"": """ & dr4("longDescription") & """,""seoTitle"": """ & dr4("seoTitle") & """,""seoKeywords"": """ & dr4("seoKeywords") & """,""seoDescription"": """ & dr4("seoDescription") & """,""taxRate"": """ & dr4("taxRate") & """,""shipmentPayment"": 1,""currency"": ""TL"",""buyPrice"": """ & dr4("buyPrice") & """,""listPrice"": """ & dr4("listPrice") & """,""salePrice"": """ & dr4("salePrice") & """,""fastSalePrice"": 0.00,""dealerPrice1"": 0.00,""dealerPrice2"": 0.00,""dealerPrice3"": 0.00,""dealerPrice4"": 0.00,""quantity"": """ & dr4("quantity") & """,""desi"": 15,""domestic"": 1,""specialCode1"": ""aa"",""specialCode2"": """",""specialCode3"": """",""specialCode4"": """",""variant1Name"": ""Renk"",""variant2Name"": ""Beden"",""variant3Name"": """",""marketplacePrices"": [{""type"": ""n11"",""currency"": ""TL"",""price"": 0.00},{""type"": ""hb"",""currency"": ""TL"",""price"": 0.00},{""type"": ""gg"",""currency"": ""TL"",""price"": 0.00},{""type"": ""eptt"",""currency"": ""TL"",""price"": 0.00},{""type"": ""amz"",""currency"": ""TL"",""price"": 0.00},{""type"": ""ty"",""currency"": ""TL"",""price"": 0.00},{""type"": ""cs"",""currency"": ""TL"",""price"": 0.00}],""variants"": [{""value1"": """ & dr4("Renk1") & """,""value2"": """ & dr4("Beden1") & """,""barcode"": """ & dr4("barcode1") & """,""quantity"": """ & dr4("quantity") & """,""priceStatus"": """ & priceStatus & """,""price"":  """ & price & """},{""value1"": """ & dr4("Renk2") & """,""value2"": """ & dr4("Beden2") & """,""barcode"": """ & dr4("barcode2") & """,""quantity"": """ & dr4("quantity") & """,""priceStatus"": """ & priceStatus & """,""price"":  """ & price & """},{""value1"": """ & dr4("Renk3") & """,""value2"": """ & dr4("Beden3") & """,""barcode"": """ & dr4("barcode3") & """,""quantity"": """ & dr4("quantity") & """,""priceStatus"": """ & priceStatus & """,""price"":  """ & price & """},{""value1"": """ & dr4("Renk4") & """,""value2"": """ & dr4("Beden4") & """,""barcode"": """ & dr4("barcode4") & """,""quantity"": """ & dr4("quantity") & """,""priceStatus"": """ & priceStatus & """,""price"":  """ & price & """},{""value1"": """ & dr4("Renk5") & """,""value2"": """ & dr4("Beden5") & """,""barcode"": """ & dr4("barcode5") & """,""quantity"": """ & dr4("quantity") & """,""priceStatus"": """ & priceStatus & """,""price"":  """ & price & """},{""value1"": """ & dr4("Renk6") & """,""value2"": """ & dr4("Beden6") & """,""barcode"": """ & dr4("barcode6") & """,""quantity"": """ & dr4("quantity") & """,""priceStatus"": """ & priceStatus & """,""price"":  """ & price & """},{""value1"": """ & dr4("Renk7") & """,""value2"": """ & dr4("Beden7") & """,""barcode"": """ & dr4("barcode7") & """,""quantity"": """ & dr4("quantity") & """,""priceStatus"": """ & priceStatus & """,""price"":  """ & price & """},{""value1"": """ & dr4("Renk8") & """,""value2"": """ & dr4("Beden8") & """,""barcode"": """ & dr4("barcode8") & """,""quantity"": """ & dr4("quantity") & """,""priceStatus"": """ & priceStatus & """,""price"":  """ & price & """},{""value1"": """ & dr4("Renk9") & """,""value2"": """ & dr4("Beden9") & """,""barcode"": """ & dr4("barcode9") & """,""quantity"": """ & dr4("quantity") & """,""priceStatus"": """ & priceStatus & """,""price"":  """ & price & """},{""value1"": """ & dr4("Renk10") & """,""value2"": """ & dr4("Beden10") & """,""barcode"": """ & dr4("barcode10") & """,""quantity"": """ & dr4("quantity") & """,""priceStatus"": """ & priceStatus & """,""price"":  """ & price & """},{""value1"": """ & dr4("Renk11") & """,""value2"": """ & dr4("Beden11") & """,""barcode"": """ & dr4("barcode11") & """,""quantity"": """ & dr4("quantity") & """,""priceStatus"": """ & priceStatus & """,""price"":  """ & price & """},{""value1"": """ & dr4("Renk12") & """,""value2"": """ & dr4("Beden12") & """,""barcode"": """ & dr4("barcode12") & """,""quantity"": """ & dr4("quantity") & """,""priceStatus"": """ & priceStatus & """,""price"":  """ & price & """},{""value1"": """ & dr4("Renk13") & """,""value2"": """ & dr4("Beden13") & """,""barcode"": """ & dr4("barcode13") & """,""quantity"": """ & dr4("quantity") & """,""priceStatus"": """ & priceStatus & """,""price"":  """ & price & """},{""value1"": """ & dr4("Renk14") & """,""value2"": """ & dr4("Beden14") & """,""barcode"": """ & dr4("barcode14") & """,""quantity"": """ & dr4("quantity") & """,""priceStatus"": """ & priceStatus & """,""price"":  """ & price & """},{""value1"": """ & dr4("Renk15") & """,""value2"": """ & dr4("Beden15") & """,""barcode"": """ & dr4("barcode15") & """,""quantity"": """ & dr4("quantity") & """,""priceStatus"": """ & priceStatus & """,""price"":  """ & price & """}],""images"": [{""imageUrl"": """ & dr4("imageUrl") & """},{""imageUrl"": """ & dr4("imageUrl1") & """},{""imageUrl"": """ & dr4("imageUrl2") & """},{""imageUrl"": """ & dr4("imageUrl3") & """},{""imageUrl"": """ & dr4("imageUrl4") & """},{""imageUrl"": """ & dr4("imageUrl5") & """},{""imageUrl"": """ & dr4("imageUrl5") & """},{""imageUrl"": """ & dr4("imageUrl6") & """},{""imageUrl"": """ & dr4("imageUrl7") & """},{""imageUrl"": """ & dr4("imageUrl7") & """},{""imageUrl"": """ & dr4("imageUrl8") & """},{""imageUrl"": """ & dr4("imageUrl9") & """},{""imageUrl"": """ & dr4("imageUrl10") & """}],""attributes"": [{""name"": ""Sezon"",""value"": ""2021""},{""name"": ""Cinsiyet"",""value"": ""Erkek""},{""name"": ""Cinsiyet"",""value"": ""Kadýn""}]}]}"
            ' Kuracalama varyant eksik çalýþýyor Dim Mydata As String = " {""products"": [{""code"": """ & dr4("code") & """,""name"": """ & dr4("name") & """,""invoiceName"": """ & dr4("name") & """,""status"": 1,""seq"": 0,""barcode"": """ & dr4("barcode1") & """,""mpn"": """",""shortDescription"": "" "",""brand"": """ & dr4("category1") & """,""category1"": """ & dr4("category1") & """,""category2"": """ & dr4("category2") & """,""category3"": """ & dr4("category3") & """,""category4"": """ & dr4("category4") & """,""longDescription"": """ & dr4("longDescription") & """,""seoTitle"": """ & dr4("seoTitle") & """,""seoKeywords"": """ & dr4("seoKeywords") & """,""seoDescription"": """ & dr4("seoDescription") & """,""taxRate"": """ & dr4("taxRate") & """,""shipmentPayment"": 1,""currency"": ""TL"",""buyPrice"": """ & dr4("buyPrice") & """,""listPrice"": """ & dr4("listPrice") & """,""salePrice"": """ & dr4("salePrice") & """,""quantity"": """ & dr4("quantity") & """,""variant1Name"": ""Renk"",""variant2Name"": ""Beden"",""marketplacePrices"": [{""type"": ""n11"",""currency"": ""TL"",""price"": 0.00},{""type"": ""hb"",""currency"": ""TL"",""price"": 0.00},{""type"": ""gg"",""currency"": ""TL"",""price"": 0.00},{""type"": ""eptt"",""currency"": ""TL"",""price"": 0.00},{""type"": ""amz"",""currency"": ""TL"",""price"": 0.00},{""type"": ""ty"",""currency"": ""TL"",""price"": 0.00},{""type"": ""cs"",""currency"": ""TL"",""price"": 0.00}],""variants"": [{""value1"": """ & dr4("Renk2") & """,""value2"": """ & dr4("Beden2") & """,""barcode"": """ & dr4("barcode2") & """,""quantity"": """ & dr4("quantity") & """,""priceStatus"": """ & priceStatus & """,""price"":  """ & price & """},{""value1"": """ & dr4("Renk3") & """,""value2"": """ & dr4("Beden3") & """,""barcode"": """ & dr4("barcode3") & """,""quantity"": """ & dr4("quantity") & """,""priceStatus"": """ & priceStatus & """,""price"":  """ & price & """}],""images"": [{""imageUrl"": """ & dr4("imageUrl") & """}],""attributes"": [{""name"": ""Sezon"",""value"": ""2021""},{""name"": ""Cinsiyet"",""value"": ""Erkek""},{""name"": ""Cinsiyet"",""value"": ""Kadýn""}]}]}"
            'Dim Mydata As String = " {""products"": [{""code"": """ & dr4("code") & """,""name"": """ & dr4("name") & """,""invoiceName"": """ & dr4("name") & """,""status"": 1,""seq"": 0,""barcode"": """ & dr4("barcode1") & """,""mpn"": """",""shortDescription"": "" "",""brand"": """ & dr4("category1") & """,""category1"": """ & dr4("category1") & """,""category2"": """ & dr4("category2") & """,""category3"": """ & dr4("category3") & """,""category4"": """ & dr4("category4") & """,""longDescription"": """ & dr4("longDescription") & """,""seoTitle"": """ & dr4("seoTitle") & """,""seoKeywords"": """ & dr4("seoKeywords") & """,""seoDescription"": """ & dr4("seoDescription") & """,""taxRate"": """ & dr4("taxRate") & """,""shipmentPayment"": 1,""currency"": ""TL"",""buyPrice"": """ & dr4("buyPrice") & """,""listPrice"": """ & dr4("listPrice") & """,""salePrice"": """ & dr4("salePrice") & """,""quantity"": """ & dr4("quantity") & """,""variant1Name"": ""Renk"",""variant2Name"": ""Beden"",""marketplacePrices"": [{""type"": ""n11"",""currency"": ""TL"",""price"": 0.00},{""type"": ""hb"",""currency"": ""TL"",""price"": 0.00},{""type"": ""gg"",""currency"": ""TL"",""price"": 0.00},{""type"": ""eptt"",""currency"": ""TL"",""price"": 0.00},{""type"": ""amz"",""currency"": ""TL"",""price"": 0.00},{""type"": ""ty"",""currency"": ""TL"",""price"": 0.00},{""type"": ""cs"",""currency"": ""TL"",""price"": 0.00}],""variants"": [{""value1"": """",""value2"": """",""barcode"": """",""quantity"": """",""priceStatus"": """",""price"":  """"}],""images"": [{""imageUrl"": """ & dr4("imageUrl") & """}],""attributes"": [{""name"": ""Sezon"",""value"": ""2021""},{""name"": ""Cinsiyet"",""value"": ""Erkek""},{""name"": ""Cinsiyet"",""value"": ""Kadýn""}]}]}"
            'Dim Mydata As String = " {""products"": [{""code"": """ & dr4("code") & """,""name"": """ & dr4("name") & """,""invoiceName"": """ & dr4("name") & """,""status"": 1,""seq"": 0,""barcode"": """ & dr4("barcode1") & """,""mpn"": """",""shortDescription"": "" "",""brand"": """ & dr4("category1") & """,""category1"": """ & dr4("category1") & """,""category2"": """ & dr4("category2") & """,""category3"": """ & dr4("category3") & """,""category4"": """ & dr4("category4") & """,""longDescription"": """ & dr4("longDescription") & """,""seoTitle"": """ & dr4("seoTitle") & """,""seoKeywords"": """ & dr4("seoKeywords") & """,""seoDescription"": """ & dr4("seoDescription") & """,""taxRate"": """ & dr4("taxRate") & """,""shipmentPayment"": 1,""currency"": ""TL"",""buyPrice"": """ & dr4("buyPrice") & """,""listPrice"": """ & dr4("listPrice") & """,""salePrice"": """ & dr4("salePrice") & """,""quantity"": """ & dr4("quantity") & """,""variant1Name"": ""Renk"",""variant2Name"": ""Beden"",""marketplacePrices"": [{""type"": ""n11"",""currency"": ""TL"",""price"": 0.00},{""type"": ""hb"",""currency"": ""TL"",""price"": 0.00},{""type"": ""gg"",""currency"": ""TL"",""price"": 0.00},{""type"": ""eptt"",""currency"": ""TL"",""price"": 0.00},{""type"": ""amz"",""currency"": ""TL"",""price"": 0.00},{""type"": ""ty"",""currency"": ""TL"",""price"": 0.00},{""type"": ""cs"",""currency"": ""TL"",""price"": 0.00}],""images"": [{""imageUrl"": """ & dr4("imageUrl") & """}],""attributes"": [{""name"": ""Sezon"",""value"": ""2021""},{""name"": ""Cinsiyet"",""value"": ""Erkek""},{""name"": ""Cinsiyet"",""value"": ""Kadýn""}]}]}"

            Try

                Dim stream As Stream = myReq.GetRequestStream()
                stream.Write(System.Text.Encoding.UTF8.GetBytes(Mydata), 0, System.Text.Encoding.UTF8.GetBytes(Mydata).Length)
                stream.Close()
                myResp = myReq.GetResponse
                myReader = New System.IO.StreamReader(myResp.GetResponseStream)
                Print(myReader.ReadToEnd)

            Catch ex As Exception

                If ex.Message Like "%SUCCESS%" Then
                    'MessageBox.Show("Cevap: " & ex.Message)
                    ' MessageBox.Show(String.Format("Aktarým Baþarý ile Tamamlandý", ex.Message))

                Else

                    If ex.Message.ToString = Chr(34) & "{" & Chr(34) & "code" & Chr(34) & ":" & Chr(34) & "AUTH001" & Chr(34) & "," & Chr(34) & "result" & Chr(34) & ":[]}" & Chr(34) & " dizesinden 'Integer' türüne yapýlan dönüþtürme geçerli deðil." Then
                        MessageBox.Show("Web servis aktif deðil")
                    End If
                    If ex.Message.ToString = Chr(34) & "{" & Chr(34) & "code" & Chr(34) & ":" & Chr(34) & "AUTH002" & Chr(34) & "," & Chr(34) & "result" & Chr(34) & ":[]}" & Chr(34) & " dizesinden 'Integer' türüne yapýlan dönüþtürme geçerli deðil." Then
                        MessageBox.Show("Geçersiz web servis kullanýcýsý ")
                    End If
                    If ex.Message.ToString = Chr(34) & "{" & Chr(34) & "code" & Chr(34) & ":" & Chr(34) & "AUTH003" & Chr(34) & "," & Chr(34) & "result" & Chr(34) & ":[]}" & Chr(34) & " dizesinden 'Integer' türüne yapýlan dönüþtürme geçerli deðil." Then
                        MessageBox.Show("Web servis kullanýcýsý aktif deðil")
                    End If
                    If ex.Message.ToString = Chr(34) & "{" & Chr(34) & "code" & Chr(34) & ":" & Chr(34) & "AUTH004" & Chr(34) & "," & Chr(34) & "result" & Chr(34) & ":[]}" & Chr(34) & " dizesinden 'Integer' türüne yapýlan dönüþtürme geçerli deðil." Then
                        MessageBox.Show("Dakikalýk eriþim limiti aþýldý")
                    End If
                    If ex.Message.ToString = Chr(34) & "{" & Chr(34) & "code" & Chr(34) & ":" & Chr(34) & "AUTH005" & Chr(34) & "," & Chr(34) & "result" & Chr(34) & ":[]}" & Chr(34) & " dizesinden 'Integer' türüne yapýlan dönüþtürme geçerli deðil." Then
                        MessageBox.Show("Geçersiz metod")
                    End If
                    If ex.Message.ToString = Chr(34) & "{" & Chr(34) & "code" & Chr(34) & ":" & Chr(34) & "AUTH006" & Chr(34) & "," & Chr(34) & "result" & Chr(34) & ":[]}" & Chr(34) & " dizesinden 'Integer' türüne yapýlan dönüþtürme geçerli deðil." Then
                        MessageBox.Show("Metota eriþim yetkisi bulunmamaktadýr")
                    End If
                    'If ex.Message.ToString = Chr(34) & "{" & Chr(34) & "code" & Chr(34) & ":" & Chr(34) & "SUCCESS" & Chr(34) & "," & Chr(34) & "result" & Chr(34) & ":{" & Chr(34) & "pro" & Chr(34) & " dizesinden 'Integer' türüne yapýlan dönüþtürme geçerli deðil." Then
                    '    MessageBox.Show("Aktarým Baþarýlý")
                    'End If

                    'MessageBox.Show("Cevap: " & ex.Message.ToString)
                End If
            End Try

            If con1.State = ConnectionState.Closed Then
                con1.ConnectionString = connection
                cmd1.Connection = con1
                con1.Open()
            End If
            cmd1.CommandText = sorgu_queryJson("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED Update tbStokEticaret Set Guncel = '1' where nStokID = " & dr4("nStokID") & "")
            cmd1.ExecuteNonQuery()
            con1.Close()
        Next


        '' JSON BÝTÝÞ 
        ''End If
    End Sub

    Public Sub jsonRequest_Stok_guncel()
        Dim cmd1 As New OleDb.OleDbCommand
        Dim con1 As New OleDb.OleDbConnection
        Dim Url As String = ""
        Dim ProductUpdate As String = ""
        Dim ApiKey As String = ""
        Dim ApiSecret As String = ""
        Dim s As String
        Dim arr = GridView1.RowCount
        Dim i As Integer
        Dim TOPLAM = arr
        i = 0
        Dim Renk1 = ""
        Dim Renk2 = ""
        Dim Renk3 = ""
        Dim Renk4 = ""
        Dim Renk5 = ""
        Dim Renk6 = ""
        Dim Renk7 = ""
        Dim Renk8 = ""
        Dim Renk9 = ""
        Dim Renk10 = ""
        Dim Renk11 = ""
        Dim Renk12 = ""
        Dim Renk13 = ""
        Dim Renk14 = ""
        Dim Renk15 = ""
        Dim Renk16 = ""
        Dim Renk17 = ""
        Dim Renk18 = ""
        Dim Renk19 = ""
        Dim Renk20 = ""
        Dim Renk21 = ""
        Dim Renk22 = ""
        Dim Renk23 = ""
        Dim Renk24 = ""
        Dim Renk25 = ""
        Dim Renk26 = ""
        Dim Renk27 = ""
        Dim Renk28 = ""
        Dim Renk29 = ""
        Dim Renk30 = ""
        Dim Renk31 = ""
        Dim Renk32 = ""
        Dim Renk33 = ""
        Dim Renk34 = ""
        Dim Renk35 = ""
        Dim Renk36 = ""
        Dim Renk37 = ""
        Dim Renk38 = ""
        Dim Renk39 = ""
        Dim Renk40 = ""
        Dim Renk41 = ""
        Dim Renk42 = ""
        Dim Renk43 = ""
        Dim Renk44 = ""
        Dim Renk45 = ""
        Dim Renk46 = ""
        Dim Renk47 = ""
        Dim Renk48 = ""
        Dim Renk49 = ""
        Dim Renk50 = ""
        Dim Renk51 = ""
        Dim Renk52 = ""
        Dim Renk53 = ""
        Dim Renk54 = ""
        Dim Renk55 = ""
        Dim Renk56 = ""
        Dim Renk57 = ""
        Dim Renk58 = ""
        Dim Renk59 = ""
        Dim Renk60 = ""
        Dim Beden1 = ""
        Dim Beden2 = ""
        Dim Beden3 = ""
        Dim Beden4 = ""
        Dim Beden5 = ""
        Dim Beden6 = ""
        Dim Beden7 = ""
        Dim Beden8 = ""
        Dim Beden9 = ""
        Dim Beden10 = ""
        Dim Beden11 = ""
        Dim Beden12 = ""
        Dim Beden13 = ""
        Dim Beden14 = ""
        Dim Beden15 = ""
        Dim Beden16 = ""
        Dim Beden17 = ""
        Dim Beden18 = ""
        Dim Beden19 = ""
        Dim Beden20 = ""
        Dim Beden21 = ""
        Dim Beden22 = ""
        Dim Beden23 = ""
        Dim Beden24 = ""
        Dim Beden25 = ""
        Dim Beden26 = ""
        Dim Beden27 = ""
        Dim Beden28 = ""
        Dim Beden29 = ""
        Dim Beden30 = ""
        Dim Beden31 = ""
        Dim Beden32 = ""
        Dim Beden33 = ""
        Dim Beden34 = ""
        Dim Beden35 = ""
        Dim Beden36 = ""
        Dim Beden37 = ""
        Dim Beden38 = ""
        Dim Beden39 = ""
        Dim Beden40 = ""
        Dim Beden41 = ""
        Dim Beden42 = ""
        Dim Beden43 = ""
        Dim Beden44 = ""
        Dim Beden45 = ""
        Dim Beden46 = ""
        Dim Beden47 = ""
        Dim Beden48 = ""
        Dim Beden49 = ""
        Dim Beden50 = ""
        Dim Beden51 = ""
        Dim Beden52 = ""
        Dim Beden53 = ""
        Dim Beden54 = ""
        Dim Beden55 = ""
        Dim Beden56 = ""
        Dim Beden57 = ""
        Dim Beden58 = ""
        Dim Beden59 = ""
        Dim Beden60 = ""
        Dim barcode1 = ""
        Dim barcode2 = ""
        Dim barcode3 = ""
        Dim barcode4 = ""
        Dim barcode5 = ""
        Dim barcode6 = ""
        Dim barcode7 = ""
        Dim barcode8 = ""
        Dim barcode9 = ""
        Dim barcode10 = ""
        Dim barcode11 = ""
        Dim barcode12 = ""
        Dim barcode13 = ""
        Dim barcode14 = ""
        Dim barcode15 = ""
        Dim barcode16 = ""
        Dim barcode17 = ""
        Dim barcode18 = ""
        Dim barcode19 = ""
        Dim barcode20 = ""
        Dim barcode21 = ""
        Dim barcode22 = ""
        Dim barcode23 = ""
        Dim barcode24 = ""
        Dim barcode25 = ""
        Dim barcode26 = ""
        Dim barcode27 = ""
        Dim barcode28 = ""
        Dim barcode29 = ""
        Dim barcode30 = ""
        Dim barcode31 = ""
        Dim barcode32 = ""
        Dim barcode33 = ""
        Dim barcode34 = ""
        Dim barcode35 = ""
        Dim barcode36 = ""
        Dim barcode37 = ""
        Dim barcode38 = ""
        Dim barcode39 = ""
        Dim barcode40 = ""
        Dim barcode41 = ""
        Dim barcode42 = ""
        Dim barcode43 = ""
        Dim barcode44 = ""
        Dim barcode45 = ""
        Dim barcode46 = ""
        Dim barcode47 = ""
        Dim barcode48 = ""
        Dim barcode49 = ""
        Dim barcode50 = ""
        Dim barcode51 = ""
        Dim barcode52 = ""
        Dim barcode53 = ""
        Dim barcode54 = ""
        Dim barcode55 = ""
        Dim barcode56 = ""
        Dim barcode57 = ""
        Dim barcode58 = ""
        Dim barcode59 = ""
        Dim barcode60 = ""
        Dim barcode = "0"
        Dim name = ""
        Dim invoiceName = ""
        Dim status = ""
        Dim shortDescription = ""
        Dim brand = ""
        Dim category1 = ""
        Dim category2 = ""
        Dim category3 = ""
        Dim category4 = ""
        Dim category5 = ""
        Dim longDescription As String = "0"
        Dim seoTitle = ""
        Dim seoKeywords = ""
        Dim seoDescription As String = ""
        Dim taxRate = ""
        'Dim shipmentPayment = dr("Kargo")
        Dim buyPrice = ""
        Dim listPrice = ""
        Dim salePrice = ""
        Dim quantity = ""
        Dim variant1Name = "Renk"
        Dim variant2Name = "Beden"
        Dim imageUrl = ""
        Dim imageUrl1 = ""
        Dim imageUrl2 = ""
        Dim imageUrl3 = ""
        Dim imageUrl4 = ""
        Dim imageUrl5 = ""
        Dim imageUrl6 = ""
        Dim imageUrl7 = ""
        Dim imageUrl8 = ""
        Dim imageUrl9 = ""
        Dim imageUrl10 = ""
        Dim xx = ""
        Dim priceStatus = 0
        Dim price = 0
        Dim TysalePrice = ""
        Dim N11salePrice = ""
        Dim GgsalePrice = ""
        Dim HbsalePrice = ""
        Dim CssalePrice = ""
        Dim EpttsalePrice = ""
        Dim AmzsalePrice = ""
        Dim quantity1 As Decimal = -9999
        Dim quantity2 As Decimal = -9999
        Dim quantity3 As Decimal = -9999
        Dim quantity4 As Decimal = -9999
        Dim quantity5 As Decimal = -9999
        Dim quantity6 As Decimal = -9999
        Dim quantity7 As Decimal = -9999
        Dim quantity8 As Decimal = -9999
        Dim quantity9 As Decimal = -9999
        Dim quantity10 As Decimal = -9999
        Dim quantity11 As Decimal = -9999
        Dim quantity12 As Decimal = -9999
        Dim quantity13 As Decimal = -9999
        Dim quantity14 As Decimal = -9999
        Dim quantity15 As Decimal = -9999
        Dim quantity16 As Decimal = -9999
        Dim quantity17 As Decimal = -9999
        Dim quantity18 As Decimal = -9999
        Dim quantity19 As Decimal = -9999
        Dim quantity20 As Decimal = -9999
        Dim quantity21 As Decimal = -9999
        Dim quantity22 As Decimal = -9999
        Dim quantity23 As Decimal = -9999
        Dim quantity24 As Decimal = -9999
        Dim quantity25 As Decimal = -9999
        Dim quantity26 As Decimal = -9999
        Dim quantity27 As Decimal = -9999
        Dim quantity28 As Decimal = -9999
        Dim quantity29 As Decimal = -9999
        Dim quantity30 As Decimal = -9999
        Dim quantity31 As Decimal = -9999
        Dim quantity32 As Decimal = -9999
        Dim quantity33 As Decimal = -9999
        Dim quantity34 As Decimal = -9999
        Dim quantity35 As Decimal = -9999
        Dim quantity36 As Decimal = -9999
        Dim quantity37 As Decimal = -9999
        Dim quantity38 As Decimal = -9999
        Dim quantity39 As Decimal = -9999
        Dim quantity40 As Decimal = -9999
        Dim quantity41 As Decimal = -9999
        Dim quantity42 As Decimal = -9999
        Dim quantity43 As Decimal = -9999
        Dim quantity44 As Decimal = -9999
        Dim quantity45 As Decimal = -9999
        Dim quantity46 As Decimal = -9999
        Dim quantity47 As Decimal = -9999
        Dim quantity48 As Decimal = -9999
        Dim quantity49 As Decimal = -9999
        Dim quantity50 As Decimal = -9999
        Dim quantity51 As Decimal = -9999
        Dim quantity52 As Decimal = -9999
        Dim quantity53 As Decimal = -9999
        Dim quantity54 As Decimal = -9999
        Dim quantity55 As Decimal = -9999
        Dim quantity56 As Decimal = -9999
        Dim quantity57 As Decimal = -9999
        Dim quantity58 As Decimal = -9999
        Dim quantity59 As Decimal = -9999
        Dim quantity60 As Decimal = -9999
        Dim quantitys As Decimal = 0
        Dim Renk As String = ""
        Dim RenkVal As String = ""
        Dim Beden As String = ""
        Dim BedenVal As String = ""
        Dim Barkod As String = ""
        Dim BarkodVal As String = ""
        Dim quantityVal As String = ""
        Dim quantitysVal As String = ""
        Dim Fiyat As String = ""
        'con1.ConnectionString = connection
        'If con1.State = ConnectionState.Closed Then
        '    cmd1.Connection = con1
        '    con1.Open()
        'End If
        'cmd1.CommandText = "DELETE FROM tbStokEticaret "
        'cmd1.ExecuteNonQuery()
        'con1.Close()
        'Dim dr As DataRow = GridView1.GetDataRow(GridView1.FocusedRowHandle)

        Dim adapter As New OleDb.OleDbDataAdapter
        Dim cmd7 As New OleDb.OleDbCommand
        Dim con7 As New OleDb.OleDbConnection
        Dim dr7 As DataRow
        Dim DS7 As New DataSet

        con7.ConnectionString = connection
        con7.Open()
        cmd7.CommandText = "SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT  tbStok.bWebGoruntule,tbStok.nStokID,tbStok.sModel,sRenk,sBeden,sKavala,tbStok.sKdvTipi,sOzelNot,sBarkod,isnull(sUzunNot, 0) as sUzunNot,tbStok.sAciklama,tbStok.sKodu,ISNULL((SELECT     ISNULL(lOran, 0) FROM         tbStokBirimCevrimi WHERE     nStokID = tbStok.nStokID And sBirimCinsi = tbStok.sBirimCinsi2), 1) AS nBirimCarpan,CAST((SELECT isnull(SUM(tbStokFisiDetayi.lGirisMiktar1 - tbStokFisiDetayi.lCikisMiktar1) , 0) FROM tbStokFisiDetayi WHERE tbStok.nStokID = tbStokFisiDetayi.nStokID) / ISNULL((SELECT     ISNULL(lOran, 0) FROM         tbStokBirimCevrimi WHERE     nStokID = tbStok.nStokID And sBirimCinsi = tbStok.sBirimCinsi2), 1) AS MONEY) as lMevcut2, tbStokBarkodu.sBarkod,ISNULL(YOL,0) as Resim1,ISNULL(YOL1,0) as Resim2,ISNULL(YOL2,0) as Resim3,ISNULL(YOL3,0) as Resim4,ISNULL(YOL4,0) as Resim5,ISNULL(YOL5,0) as Resim6,ISNULL(YOL6,0) as Resim7,ISNULL(YOL7,0) as Resim8,ISNULL(YOL8,0) as Resim9,ISNULL(YOL9,0) as Resim10,ISNULL(YOL10,0) as Resim11,tbStokUzunNot.sUzunNot, tbSSinif1.sAciklama AS Sinif1, tbSSinif2.sAciklama AS Sinif2, tbSSinif3.sAciklama AS Sinif3, tbSSinif4.sAciklama AS Sinif4, tbSSinif5.sAciklama AS Sinif5, tbSSinif6.sAciklama AS Sinif6, tbSSinif7.sAciklama AS Sinif7, tbSSinif8.sAciklama AS Sinif8, tbSSinif9.sAciklama AS Sinif9, tbSSinif10.sAciklama AS Sinif10, tbSSinif11.sAciklama AS Sinif11, tbSSinif12.sAciklama AS Sinif12, tbSSinif13.sAciklama AS Sinif13, tbSSinif14.sAciklama AS Sinif14, tbSSinif15.sAciklama AS Sinif15, ISNULL(tbStokAciklama.sAciklama1 + ' ' + tbStokAciklama.sAciklama2 + ' ' + tbStokAciklama.sAciklama3 + ' ' + tbStokAciklama.sAciklama4 + ' ' + tbStokAciklama.sAciklama5 + ' ' + tbStokAciklama.sAciklama6 + ' ' + tbStokAciklama.sAciklama7 + ' ' + tbStokAciklama.sAciklama8 + ' ' + tbStokAciklama.sAciklama9 + ' ' + tbStokAciklama.sAciklama10, '') AS ISTIHBARAT, (SELECT isnull(SUM(tbStokFisiDetayi.lGirisMiktar1 - tbStokFisiDetayi.lCikisMiktar1) , 0) FROM tbStokFisiDetayi WHERE tbStok.nStokID =tbStokFisiDetayi.nStokID) AS Mevcut, ISNULL((SELECT isnull(lfiyat , 0) FROM tbstokfiyati WHERE nStokId = tbStok.NstokId And sFiyatTipi = '1'),0) AS FIYAT1, ISNULL((SELECT isnull(lfiyat , 0) FROM tbstokfiyati WHERE nStokId = tbStok.NstokId And sFiyatTipi = '2'),0) AS FIYAT2,ISNULL((SELECT isnull(lfiyat, 0) FROM tbstokfiyati WHERE nStokId = tbStok.NstokId And sFiyatTipi = '3'),0) AS FIYAT3,ISNULL((SELECT isnull(lfiyat , 0) FROM tbstokfiyati WHERE nStokId = tbStok.NstokId And sFiyatTipi = 'M'),0) AS FIYATM,ISNULL((SELECT isnull(lfiyat , 0) FROM tbstokfiyati WHERE nStokId = tbStok.NstokId And sFiyatTipi = '4'), 0) AS FIYAT4,ISNULL((SELECT isnull(lfiyat , 0) FROM tbstokfiyati WHERE nStokId = tbStok.NstokId And sFiyatTipi = 'WEBP'), 0) AS WEBP,ISNULL((SELECT isnull(lfiyat , 0) FROM tbstokfiyati WHERE nStokId = tbStok.NstokId AND sFiyatTipi = 'WEBK'), 0) AS WEBK, ISNULL((SELECT isnull(lfiyat , 0) FROM tbstokfiyati WHERE nStokId = tbStok.NstokId And sFiyatTipi = 'ty'), 0) AS TysalePrice,ISNULL((SELECT isnull(lfiyat, 0) FROM tbstokfiyati WHERE nStokId = tbStok.NstokId And sFiyatTipi = 'N11'), 0) AS N11salePrice,ISNULL((SELECT isnull(lfiyat , 0) FROM tbstokfiyati WHERE nStokId = tbStok.NstokId And sFiyatTipi = 'GG'), 0) AS GgsalePrice,ISNULL((SELECT isnull(lfiyat , 0) FROM tbstokfiyati WHERE nStokId = tbStok.NstokId And sFiyatTipi = 'Hb'), 0) AS HbsalePrice,ISNULL((SELECT isnull(lfiyat , 0) FROM tbstokfiyati WHERE nStokId = tbStok.NstokId And sFiyatTipi = 'Eptt'), 0) AS EpttsalePrice,ISNULL((SELECT isnull(lfiyat , 0) FROM tbstokfiyati WHERE nStokId = tbStok.NstokId And sFiyatTipi = 'Cs'), 0) AS CssalePrice,ISNULL((SELECT isnull(lfiyat , 0) FROM tbstokfiyati WHERE nStokId = tbStok.NstokId And sFiyatTipi = 'Amz'), 0) AS AmzsalePrice,ISNULL((SELECT isnull(lfiyat , 0) FROM tbstokfiyati WHERE nStokId = tbStok.NstokId And sFiyatTipi = 'New'), 0) AS NewsalePrice,ISNULL((SELECT isnull(lfiyat, 0) FROM tbstokfiyati WHERE nStokId = tbStok.nStokId And sFiyatTipi = 'A'),0) AS FIYATA,ISNULL((SELECT isnull(lfiyat , 0) FROM tbstokfiyati WHERE nStokId = tbStok.NstokId AND sFiyatTipi = '1'),0) AS lFiyat, (SELECT     nKdvOrani FROM         tbKdv Where sKdvTipi = tbStok.sKdvTipi) as nKdvOrani,ISNULL((SELECT ISNULL(lOran , 1) FROM tbStokBirimCevrimi WHERE nStokID = tbStok.nStokID And sBirimCinsi = tbStok.sBirimCinsi2), 1) AS lBirimCarpan, (SELECT     sRenkAdi FROM          tbRenk WHERE      sRenk = tbStok.sRenk) AS sRenkAdi,(SELECT     COUNT(DISTINCT nStokID) AS nKayit FROM         tbStokFiyati WHERE     (dteFiyatTespitTarihi = '14/02/2021') AND (sFiyatTipi IN ('1', '2', '3')) and nStokID = tbStok.nStokID) bFiyatDegisti  FROM tbStok LEFT OUTER JOIN tbStokBarkodu ON tbStok.nStokID = tbStokBarkodu.nStokID and tbStokBarkodu.nKisim =0 INNER JOIN tbStokSinifi ON tbStok.nStokID = tbStokSinifi.nStokID LEFT OUTER JOIN tbStokEticaretResim ON tbStok.sModel = tbStokEticaretResim.sModel LEFT OUTER JOIN tbStokUzunNot ON tbStok.sModel = tbStokUzunNot.sModel INNER JOIN tbSSinif1 ON tbStokSinifi.sSinifKodu1 = tbSSinif1.sSinifKodu INNER JOIN tbSSinif2 ON tbStokSinifi.sSinifKodu2 = tbSSinif2.sSinifKodu INNER JOIN tbSSinif3 ON tbStokSinifi.sSinifKodu3 = tbSSinif3.sSinifKodu INNER JOIN tbSSinif4 ON tbStokSinifi.sSinifKodu4 = tbSSinif4.sSinifKodu INNER JOIN tbSSinif5 ON tbStokSinifi.sSinifKodu5 = tbSSinif5.sSinifKodu INNER JOIN tbSSinif6 ON tbStokSinifi.sSinifKodu6 = tbSSinif6.sSinifKodu INNER JOIN tbSSinif7 ON tbStokSinifi.sSinifKodu7 = tbSSinif7.sSinifKodu INNER JOIN tbSSinif8 ON tbStokSinifi.sSinifKodu8 = tbSSinif8.sSinifKodu INNER JOIN tbSSinif9 ON tbStokSinifi.sSinifKodu9 = tbSSinif9.sSinifKodu INNER JOIN tbSSinif10 ON tbStokSinifi.sSinifKodu10 = tbSSinif10.sSinifKodu INNER JOIN tbSSinif11 ON tbStokSinifi.sSinifKodu11 = tbSSinif11.sSinifKodu INNER JOIN tbSSinif12 ON tbStokSinifi.sSinifKodu12 = tbSSinif12.sSinifKodu INNER JOIN tbSSinif13 ON tbStokSinifi.sSinifKodu13 = tbSSinif13.sSinifKodu INNER JOIN tbSSinif14 ON tbStokSinifi.sSinifKodu14 = tbSSinif14.sSinifKodu INNER JOIN tbSSinif15 ON tbStokSinifi.sSinifKodu15 = tbSSinif15.sSinifKodu LEFT OUTER JOIN tbStokAciklama ON tbStok.nStokID = tbStokAciklama.nStokID WHERE  tbStok.nStokTipi <> 5 and tbStok.bWebGoruntule = 'True' and sRenk <> '' ORDER BY tbStok.sModel"
        cmd7.Connection = con7
        adapter.SelectCommand = cmd7
        Dim N As Integer = adapter.Fill(DS7, "Table1")

        For Each dr7 In DS7.Tables(0).Rows

            'Dim dr As DataRow = ds_stok.Tables(0).Rows(0)
            Dim code = Trim(dr7("sModel"))
            Dim Model = Trim(dr7("sKodu"))
            Dim nStokID = Trim(dr7("nStokID"))
            Dim Sor As String = ""
            Dim R As String = Trim(dr7("sRenkAdi"))
            Dim Bed As String = Trim(dr7("sBeden"))
            Dim Bar As String = Trim(dr7("sBarkod"))
            Dim Q As String = Trim(dr7("Mevcut"))
            Dim Qs As String = Trim(dr7("Mevcut"))
            con1.ConnectionString = connection
            If con1.State = ConnectionState.Closed Then
                cmd1.Connection = con1
                con1.Open()
            End If
            cmd1.CommandText = sorgu_queryJson("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT  COUNT (code) FROM tbStokEticaret where code = '" & code & "' ")
            Sor = cmd1.ExecuteScalar.ToString()
            s = i.ToString
            If xx <> code Then
                Renk1 = ""
                Renk2 = ""
                Renk3 = ""
                Renk4 = ""
                Renk5 = ""
                Renk6 = ""
                Renk7 = ""
                Renk8 = ""
                Renk9 = ""
                Renk10 = ""
                Renk11 = ""
                Renk12 = ""
                Renk13 = ""
                Renk14 = ""
                Renk15 = ""
                Renk16 = ""
                Renk17 = ""
                Renk18 = ""
                Renk19 = ""
                Renk20 = ""
                Renk21 = ""
                Renk22 = ""
                Renk23 = ""
                Renk24 = ""
                Renk25 = ""
                Renk26 = ""
                Renk27 = ""
                Renk28 = ""
                Renk29 = ""
                Renk30 = ""
                Renk31 = ""
                Renk32 = ""
                Renk33 = ""
                Renk34 = ""
                Renk35 = ""
                Renk36 = ""
                Renk37 = ""
                Renk38 = ""
                Renk39 = ""
                Renk40 = ""
                Renk41 = ""
                Renk42 = ""
                Renk43 = ""
                Renk44 = ""
                Renk45 = ""
                Renk46 = ""
                Renk47 = ""
                Renk48 = ""
                Renk49 = ""
                Renk50 = ""
                Renk51 = ""
                Renk52 = ""
                Renk53 = ""
                Renk54 = ""
                Renk55 = ""
                Renk56 = ""
                Renk57 = ""
                Renk58 = ""
                Renk59 = ""
                Renk60 = ""
                Beden1 = ""
                Beden2 = ""
                Beden3 = ""
                Beden4 = ""
                Beden5 = ""
                Beden6 = ""
                Beden7 = ""
                Beden8 = ""
                Beden9 = ""
                Beden10 = ""
                Beden11 = ""
                Beden12 = ""
                Beden13 = ""
                Beden14 = ""
                Beden15 = ""
                Beden16 = ""
                Beden17 = ""
                Beden18 = ""
                Beden19 = ""
                Beden20 = ""
                Beden21 = ""
                Beden22 = ""
                Beden23 = ""
                Beden24 = ""
                Beden25 = ""
                Beden26 = ""
                Beden27 = ""
                Beden28 = ""
                Beden29 = ""
                Beden30 = ""
                Beden31 = ""
                Beden32 = ""
                Beden33 = ""
                Beden34 = ""
                Beden35 = ""
                Beden36 = ""
                Beden37 = ""
                Beden38 = ""
                Beden39 = ""
                Beden40 = ""
                Beden41 = ""
                Beden42 = ""
                Beden43 = ""
                Beden44 = ""
                Beden45 = ""
                Beden46 = ""
                Beden47 = ""
                Beden48 = ""
                Beden49 = ""
                Beden50 = ""
                Beden51 = ""
                Beden52 = ""
                Beden53 = ""
                Beden54 = ""
                Beden55 = ""
                Beden56 = ""
                Beden57 = ""
                Beden58 = ""
                Beden59 = ""
                Beden60 = ""
                barcode1 = ""
                barcode2 = ""
                barcode3 = ""
                barcode4 = ""
                barcode5 = ""
                barcode6 = ""
                barcode7 = ""
                barcode8 = ""
                barcode9 = ""
                barcode10 = ""
                barcode11 = ""
                barcode12 = ""
                barcode13 = ""
                barcode14 = ""
                barcode15 = ""
                barcode16 = ""
                barcode17 = ""
                barcode18 = ""
                barcode19 = ""
                barcode20 = ""
                barcode21 = ""
                barcode22 = ""
                barcode23 = ""
                barcode24 = ""
                barcode25 = ""
                barcode26 = ""
                barcode27 = ""
                barcode28 = ""
                barcode29 = ""
                barcode30 = ""
                barcode31 = ""
                barcode32 = ""
                barcode33 = ""
                barcode34 = ""
                barcode35 = ""
                barcode36 = ""
                barcode37 = ""
                barcode38 = ""
                barcode39 = ""
                barcode40 = ""
                barcode41 = ""
                barcode42 = ""
                barcode43 = ""
                barcode44 = ""
                barcode45 = ""
                barcode46 = ""
                barcode47 = ""
                barcode48 = ""
                barcode49 = ""
                barcode50 = ""
                barcode51 = ""
                barcode52 = ""
                barcode53 = ""
                barcode54 = ""
                barcode55 = ""
                barcode56 = ""
                barcode57 = ""
                barcode58 = ""
                barcode59 = ""
                barcode60 = ""
                barcode = "0"
                name = ""
                invoiceName = ""
                status = ""
                shortDescription = ""
                brand = ""
                category1 = ""
                category2 = ""
                category3 = ""
                category4 = ""
                category5 = ""
                longDescription = ""
                seoTitle = ""
                seoKeywords = ""
                seoDescription = ""
                taxRate = ""
                ' shipmentPayment = dr("Kargo")
                buyPrice = ""
                listPrice = ""
                salePrice = ""
                quantity = ""
                variant1Name = "Renk"
                variant2Name = "Beden"
                imageUrl = ""
                imageUrl1 = ""
                imageUrl2 = ""
                imageUrl3 = ""
                imageUrl4 = ""
                imageUrl5 = ""
                imageUrl6 = ""
                imageUrl7 = ""
                imageUrl8 = ""
                imageUrl9 = ""
                imageUrl10 = ""
                xx = ""
                priceStatus = 0
                price = 0
                TysalePrice = ""
                N11salePrice = ""
                GgsalePrice = ""
                HbsalePrice = ""
                CssalePrice = ""
                EpttsalePrice = ""
                AmzsalePrice = ""
                quantity1 = -9999
                quantity2 = -9999
                quantity3 = -9999
                quantity4 = -9999
                quantity5 = -9999
                quantity6 = -9999
                quantity7 = -9999
                quantity8 = -9999
                quantity9 = -9999
                quantity10 = -9999
                quantity11 = -9999
                quantity12 = -9999
                quantity13 = -9999
                quantity14 = -9999
                quantity15 = -9999
                quantity16 = -9999
                quantity17 = -9999
                quantity18 = -9999
                quantity19 = -9999
                quantity20 = -9999
                quantity21 = -9999
                quantity22 = -9999
                quantity23 = -9999
                quantity24 = -9999
                quantity25 = -9999
                quantity26 = -9999
                quantity27 = -9999
                quantity28 = -9999
                quantity29 = -9999
                quantity30 = -9999
                quantity31 = -9999
                quantity32 = -9999
                quantity33 = -9999
                quantity34 = -9999
                quantity35 = -9999
                quantity36 = -9999
                quantity37 = -9999
                quantity38 = -9999
                quantity39 = -9999
                quantity40 = -9999
                quantity41 = -9999
                quantity42 = -9999
                quantity43 = -9999
                quantity44 = -9999
                quantity45 = -9999
                quantity46 = -9999
                quantity47 = -9999
                quantity48 = -9999
                quantity49 = -9999
                quantity50 = -9999
                quantity51 = -9999
                quantity52 = -9999
                quantity53 = -9999
                quantity54 = -9999
                quantity55 = -9999
                quantity56 = -9999
                quantity57 = -9999
                quantity58 = -9999
                quantity59 = -9999
                quantity60 = -9999
                quantitys = 0
                Renk = ""
                RenkVal = ""
                Beden = ""
                BedenVal = ""
                Barkod = ""
                BarkodVal = ""
                quantityVal = ""
                quantitysVal = ""
            End If

            If Sor <= 0 Then
                code = Trim(dr7("sModel"))
                name = dr7("sAciklama")
                invoiceName = dr7("sAciklama")
                status = dr7("bWebGoruntule")
                barcode = Trim(dr7("sBarkod"))
                shortDescription = dr7("sAciklama")
                brand = dr7("Sinif4")
                category1 = dr7("Sinif3")
                category2 = dr7("Sinif2")
                category3 = dr7("Sinif6")
                category4 = dr7("Sinif5")
                category5 = dr7("Sinif6")
                longDescription = Trim(dr7("sUzunNot"))
                seoTitle = dr7("Sinif3")
                seoKeywords = dr7("Sinif3")
                seoDescription = dr7("Sinif3")
                taxRate = dr7("sKdvTipi")
                ' shipmentPayment = dr7("Kargo")
                buyPrice = dr7("FIYATA")
                listPrice = dr7("WEBK")
                salePrice = dr7("WEBP")
                quantity = dr7("Mevcut")
                variant1Name = "Renk"
                variant2Name = "Beden"
                imageUrl = dr7("Resim1")
                imageUrl1 = dr7("Resim2")
                imageUrl2 = dr7("Resim3")
                imageUrl3 = dr7("Resim4")
                imageUrl4 = dr7("Resim5")
                imageUrl5 = dr7("Resim6")
                imageUrl6 = dr7("Resim7")
                imageUrl7 = dr7("Resim8")
                imageUrl8 = dr7("Resim9")
                imageUrl9 = dr7("Resim10")
                imageUrl10 = dr7("Resim11")
                Renk1 = Trim(dr7("sRenkAdi"))
                Beden1 = Trim(dr7("sBeden"))
                TysalePrice = Trim(dr7("TysalePrice"))
                N11salePrice = Trim(dr7("N11salePrice"))
                GgsalePrice = Trim(dr7("GgsalePrice"))
                HbsalePrice = Trim(dr7("HbsalePrice"))
                CssalePrice = (dr7("CssalePrice"))
                EpttsalePrice = (dr7("EpttsalePrice"))
                AmzsalePrice = (dr7("AmzsalePrice"))
                If TysalePrice <= 0 Then
                    TysalePrice = salePrice
                End If
                If N11salePrice <= 0 Then
                    N11salePrice = salePrice
                End If
                If GgsalePrice <= 0 Then
                    GgsalePrice = salePrice
                End If
                If HbsalePrice <= 0 Then
                    HbsalePrice = salePrice
                End If
                If CssalePrice <= 0 Then
                    CssalePrice = salePrice
                End If
                If EpttsalePrice <= 0 Then
                    EpttsalePrice = salePrice
                End If
                If AmzsalePrice <= 0 Then
                    AmzsalePrice = salePrice
                End If
                taxRate = 0
                If taxRate = 1 Then
                    taxRate = 0
                ElseIf taxRate = 2 Then
                    taxRate = 18
                ElseIf taxRate = 3 Then
                    taxRate = 8
                End If
                tbStok_kaydet_Eticaret(nStokID, code, name, Renk1, Beden1, barcode, brand, category1, category2, category3, category4, category5, longDescription, buyPrice, listPrice, salePrice, seoTitle, seoKeywords, taxRate, quantity, seoDescription, variant1Name, variant2Name, imageUrl, imageUrl1, imageUrl2, imageUrl3, imageUrl4, imageUrl5, imageUrl6, imageUrl7, imageUrl8, imageUrl9, imageUrl10, TysalePrice, N11salePrice, GgsalePrice, HbsalePrice, EpttsalePrice, CssalePrice, AmzsalePrice)

            Else
                Dim con As New OleDb.OleDbConnection
                Dim cmd As New OleDb.OleDbCommand
                cmd.Connection = con
                con.ConnectionString = connection
                cmd.CommandTimeout = False
                If con.State = ConnectionState.Closed = True Then
                    con.Open()
                End If

                'cmd.CommandText = "SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT @@identity"
                'Dim kayitno = cmd.ExecuteScalar
                con.Close()
                code = Trim(dr7("sModel"))
                xx = Trim(dr7("sModel"))
                name = dr7("sAciklama")
                invoiceName = dr7("sAciklama")
                status = dr7("bWebGoruntule")
                barcode = Trim(dr7("sBarkod"))
                shortDescription = dr7("sAciklama")
                brand = dr7("Sinif1")
                category1 = dr7("Sinif2")
                category2 = dr7("Sinif3")
                category3 = dr7("Sinif4")
                category4 = dr7("Sinif5")
                longDescription = Trim(dr7("sUzunNot"))
                seoTitle = dr7("Sinif2")
                seoKeywords = dr7("Sinif2")
                seoDescription = dr7("Sinif2")
                taxRate = dr7("sKdvTipi")
                ' shipmentPayment = dr7("Kargo")
                buyPrice = dr7("FIYATA")
                listPrice = dr7("WEBK")
                salePrice = dr7("WEBP")
                quantity = dr7("Mevcut")
                variant1Name = "Renk"
                variant2Name = "Beden"
                imageUrl = dr7("Resim1")
                imageUrl1 = dr7("Resim2")
                imageUrl2 = dr7("Resim3")
                imageUrl3 = dr7("Resim4")
                imageUrl4 = dr7("Resim5")
                imageUrl5 = dr7("Resim6")
                imageUrl6 = dr7("Resim7")
                imageUrl7 = dr7("Resim8")
                imageUrl8 = dr7("Resim9")
                imageUrl9 = dr7("Resim10")
                imageUrl10 = dr7("Resim11")
                Renk1 = Trim(dr7("sRenkAdi"))
                Beden1 = Trim(dr7("sBeden"))
                taxRate = 0
                If taxRate = 1 Then
                    taxRate = 0
                ElseIf taxRate = 2 Then
                    taxRate = 18
                ElseIf taxRate = 3 Then
                    taxRate = 8
                End If



                If quantity2 = "-9999" Then
                    If Q > 0 Then
                        quantity2 = Q
                    Else
                        quantity2 = 0
                    End If
                    quantity = "quantity2"
                    quantityVal = quantity2
                    tbStok_quantityUpdate_Eticaret(code, quantity, quantityVal)
                ElseIf quantity3 = "-9999" Then
                    If Q > 0 Then
                        quantity3 = Q
                    Else
                        quantity3 = 0
                    End If
                    quantity = "quantity3"
                    quantityVal = quantity3
                    tbStok_quantityUpdate_Eticaret(code, quantity, quantityVal)
                ElseIf quantity4 = "-9999" Then
                    If Q > 0 Then
                        quantity4 = Q
                    Else
                        quantity4 = 0
                    End If
                    quantity = "quantity4"
                    quantityVal = quantity4
                    tbStok_quantityUpdate_Eticaret(code, quantity, quantityVal)
                ElseIf quantity5 = "-9999" Then
                    If Q > 0 Then
                        quantity5 = Q
                    Else
                        quantity5 = 0
                    End If
                    quantity = "quantity5"
                    quantityVal = quantity5
                    tbStok_quantityUpdate_Eticaret(code, quantity, quantityVal)
                ElseIf quantity6 = "-9999" Then
                    If Q > 0 Then
                        quantity6 = Q
                    Else
                        quantity6 = 0
                    End If
                    quantity = "quantity6"
                    quantityVal = quantity6
                    tbStok_quantityUpdate_Eticaret(code, quantity, quantityVal)
                ElseIf quantity7 = "-9999" Then
                    If Q > 0 Then
                        quantity7 = Q
                    Else
                        quantity7 = 0
                    End If
                    quantity = "quantity7"
                    quantityVal = quantity7
                    tbStok_quantityUpdate_Eticaret(code, quantity, quantityVal)
                ElseIf quantity8 = "-9999" Then
                    If Q > 0 Then
                        quantity8 = Q
                    Else
                        quantity8 = 0
                    End If
                    quantity = "quantity8"
                    quantityVal = quantity8
                    tbStok_quantityUpdate_Eticaret(code, quantity, quantityVal)
                ElseIf quantity9 = "-9999" Then
                    If Q > 0 Then
                        quantity9 = Q
                    Else
                        quantity9 = 0
                    End If
                    quantity = "quantity9"
                    quantityVal = quantity9
                    tbStok_quantityUpdate_Eticaret(code, quantity, quantityVal)
                ElseIf quantity10 = "-9999" Then
                    If Q > 0 Then
                        quantity10 = Q
                    Else
                        quantity10 = 0
                    End If
                    quantity = "quantity10"
                    quantityVal = quantity10
                    tbStok_quantityUpdate_Eticaret(code, quantity, quantityVal)
                ElseIf quantity11 = "-9999" Then
                    If Q > 0 Then
                        quantity11 = Q
                    Else
                        quantity11 = 0
                    End If
                    quantity = "quantity11"
                    quantityVal = quantity11
                    tbStok_quantityUpdate_Eticaret(code, quantity, quantityVal)
                ElseIf quantity12 = "-9999" Then
                    If Q > 0 Then
                        quantity12 = Q
                    Else
                        quantity12 = 0
                    End If
                    quantity = "quantity12"
                    quantityVal = quantity12
                    tbStok_quantityUpdate_Eticaret(code, quantity, quantityVal)
                ElseIf quantity13 = "-9999" Then
                    If Q > 0 Then
                        quantity13 = Q
                    Else
                        quantity13 = 0
                    End If
                    quantity = "quantity13"
                    quantityVal = quantity13
                    tbStok_quantityUpdate_Eticaret(code, quantity, quantityVal)
                ElseIf quantity14 = "-9999" Then
                    If Q > 0 Then
                        quantity14 = Q
                    Else
                        quantity14 = 0
                    End If
                    quantity = "quantity14"
                    quantityVal = quantity14
                    tbStok_quantityUpdate_Eticaret(code, quantity, quantityVal)
                ElseIf quantity15 = "-9999" Then
                    If Q > 0 Then
                        quantity15 = Q
                    Else
                        quantity15 = 0
                    End If
                    quantity = "quantity15"
                    quantityVal = quantity15
                    tbStok_quantityUpdate_Eticaret(code, quantity, quantityVal)
                ElseIf quantity16 = "-9999" Then
                    If Q > 0 Then
                        quantity16 = Q
                    Else
                        quantity16 = 0
                    End If
                    quantity = "quantity16"
                    quantityVal = quantity16
                    tbStok_quantityUpdate_Eticaret(code, quantity, quantityVal)
                ElseIf quantity17 = "-9999" Then
                    If Q > 0 Then
                        quantity17 = Q
                    Else
                        quantity17 = 0
                    End If
                    quantity = "quantity17"
                    quantityVal = quantity17
                    tbStok_quantityUpdate_Eticaret(code, quantity, quantityVal)
                ElseIf quantity18 = "-9999" Then
                    If Q > 0 Then
                        quantity18 = Q
                    Else
                        quantity18 = 0
                    End If
                    quantity = "quantity18"
                    quantityVal = quantity18
                    tbStok_quantityUpdate_Eticaret(code, quantity, quantityVal)
                ElseIf quantity19 = "-9999" Then
                    If Q > 0 Then
                        quantity19 = Q
                    Else
                        quantity19 = 0
                    End If
                    quantity = "quantity19"
                    quantityVal = quantity19
                    tbStok_quantityUpdate_Eticaret(code, quantity, quantityVal)
                ElseIf quantity20 = "-9999" Then
                    If Q > 0 Then
                        quantity20 = Q
                    Else
                        quantity20 = 0
                    End If
                    quantity = "quantity20"
                    quantityVal = quantity20
                    tbStok_quantityUpdate_Eticaret(code, quantity, quantityVal)

                ElseIf quantity21 = "-9999" Then
                If Q > 0 Then
                    quantity21 = Q
                Else
                    quantity21 = 0
                End If
                quantity = "quantity21"
                quantityVal = quantity21
                tbStok_quantityUpdate_Eticaret(code, quantity, quantityVal)
                ElseIf quantity22 = "-9999" Then
                If Q > 0 Then
                    quantity22 = Q
                Else
                    quantity22 = 0
                End If
                quantity = "quantity22"
                quantityVal = quantity22
                tbStok_quantityUpdate_Eticaret(code, quantity, quantityVal)
                ElseIf quantity23 = "-9999" Then
                If Q > 0 Then
                    quantity23 = Q
                Else
                    quantity23 = 0
                End If
                quantity = "quantity23"
                quantityVal = quantity23
                tbStok_quantityUpdate_Eticaret(code, quantity, quantityVal)
                ElseIf quantity24 = "-9999" Then
                If Q > 0 Then
                    quantity24 = Q
                Else
                    quantity24 = 0
                End If
                quantity = "quantity24"
                quantityVal = quantity24
                tbStok_quantityUpdate_Eticaret(code, quantity, quantityVal)
                ElseIf quantity25 = "-9999" Then
                If Q > 0 Then
                    quantity25 = Q
                Else
                    quantity25 = 0
                End If
                quantity = "quantity25"
                quantityVal = quantity25
                tbStok_quantityUpdate_Eticaret(code, quantity, quantityVal)
                ElseIf quantity26 = "-9999" Then
                If Q > 0 Then
                    quantity26 = Q
                Else
                    quantity26 = 0
                End If
                quantity = "quantity26"
                quantityVal = quantity26
                tbStok_quantityUpdate_Eticaret(code, quantity, quantityVal)
                ElseIf quantity27 = "-9999" Then
                If Q > 0 Then
                    quantity27 = Q
                Else
                    quantity27 = 0
                End If
                quantity = "quantity27"
                quantityVal = quantity27
                tbStok_quantityUpdate_Eticaret(code, quantity, quantityVal)
                ElseIf quantity28 = "-9999" Then
                If Q > 0 Then
                    quantity28 = Q
                Else
                    quantity28 = 0
                End If
                quantity = "quantity28"
                quantityVal = quantity28
                tbStok_quantityUpdate_Eticaret(code, quantity, quantityVal)
                ElseIf quantity29 = "-9999" Then
                If Q > 0 Then
                    quantity29 = Q
                Else
                    quantity29 = 0
                End If
                quantity = "quantity29"
                quantityVal = quantity29
                tbStok_quantityUpdate_Eticaret(code, quantity, quantityVal)
                ElseIf quantity30 = "-9999" Then
                If Q > 0 Then
                    quantity30 = Q
                Else
                    quantity30 = 0
                End If
                quantity = "quantity30"
                quantityVal = quantity30
                tbStok_quantityUpdate_Eticaret(code, quantity, quantityVal)
                ElseIf quantity31 = "-9999" Then
                If Q > 0 Then
                    quantity31 = Q
                Else
                    quantity31 = 0
                End If
                quantity = "quantity31"
                quantityVal = quantity31
                tbStok_quantityUpdate_Eticaret(code, quantity, quantityVal)
                ElseIf quantity32 = "-9999" Then
                If Q > 0 Then
                    quantity32 = Q
                Else
                    quantity32 = 0
                End If
                quantity = "quantity32"
                quantityVal = quantity32
                tbStok_quantityUpdate_Eticaret(code, quantity, quantityVal)
                ElseIf quantity33 = "-9999" Then
                If Q > 0 Then
                    quantity33 = Q
                Else
                    quantity33 = 0
                End If
                quantity = "quantity33"
                quantityVal = quantity33
                tbStok_quantityUpdate_Eticaret(code, quantity, quantityVal)
                ElseIf quantity34 = "-9999" Then
                If Q > 0 Then
                    quantity34 = Q
                Else
                    quantity34 = 0
                End If
                quantity = "quantity34"
                quantityVal = quantity34
                tbStok_quantityUpdate_Eticaret(code, quantity, quantityVal)
                ElseIf quantity35 = "-9999" Then
                If Q > 0 Then
                    quantity35 = Q
                Else
                    quantity35 = 0
                End If
                quantity = "quantity35"
                quantityVal = quantity35
                tbStok_quantityUpdate_Eticaret(code, quantity, quantityVal)
                ElseIf quantity36 = "-9999" Then
                If Q > 0 Then
                    quantity36 = Q
                Else
                    quantity36 = 0
                End If
                quantity = "quantity36"
                quantityVal = quantity36
                tbStok_quantityUpdate_Eticaret(code, quantity, quantityVal)
                ElseIf quantity37 = "-9999" Then
                If Q > 0 Then
                    quantity37 = Q
                Else
                    quantity37 = 0
                End If
                quantity = "quantity37"
                quantityVal = quantity37
                tbStok_quantityUpdate_Eticaret(code, quantity, quantityVal)
                ElseIf quantity38 = "-9999" Then
                If Q > 0 Then
                    quantity38 = Q
                Else
                    quantity38 = 0
                End If
                quantity = "quantity38"
                quantityVal = quantity38
                tbStok_quantityUpdate_Eticaret(code, quantity, quantityVal)
                ElseIf quantity39 = "-9999" Then
                If Q > 0 Then
                    quantity39 = Q
                Else
                    quantity39 = 0
                End If
                quantity = "quantity39"
                quantityVal = quantity39
                tbStok_quantityUpdate_Eticaret(code, quantity, quantityVal)
                ElseIf quantity40 = "-9999" Then
                If Q > 0 Then
                    quantity40 = Q
                Else
                    quantity40 = 0
                End If
                quantity = "quantity40"
                quantityVal = quantity40
                tbStok_quantityUpdate_Eticaret(code, quantity, quantityVal)
                ElseIf quantity41 = "-9999" Then
                If Q > 0 Then
                    quantity41 = Q
                Else
                    quantity41 = 0
                End If
                quantity = "quantity41"
                quantityVal = quantity41
                tbStok_quantityUpdate_Eticaret(code, quantity, quantityVal)
                ElseIf quantity42 = "-9999" Then
                If Q > 0 Then
                    quantity42 = Q
                Else
                    quantity42 = 0
                End If
                quantity = "quantity42"
                quantityVal = quantity42
                tbStok_quantityUpdate_Eticaret(code, quantity, quantityVal)
                ElseIf quantity43 = "-9999" Then
                If Q > 0 Then
                    quantity43 = Q
                Else
                    quantity43 = 0
                End If
                quantity = "quantity43"
                quantityVal = quantity43
                tbStok_quantityUpdate_Eticaret(code, quantity, quantityVal)
                ElseIf quantity44 = "-9999" Then
                If Q > 0 Then
                    quantity44 = Q
                Else
                    quantity44 = 0
                End If
                quantity = "quantity44"
                quantityVal = quantity44
                tbStok_quantityUpdate_Eticaret(code, quantity, quantityVal)
                ElseIf quantity45 = "-9999" Then
                If Q > 0 Then
                    quantity45 = Q
                Else
                    quantity45 = 0
                End If
                quantity = "quantity45"
                quantityVal = quantity45
                tbStok_quantityUpdate_Eticaret(code, quantity, quantityVal)
                ElseIf quantity46 = "-9999" Then
                If Q > 0 Then
                    quantity46 = Q
                Else
                    quantity46 = 0
                End If
                quantity = "quantity46"
                quantityVal = quantity46
                tbStok_quantityUpdate_Eticaret(code, quantity, quantityVal)
                ElseIf quantity47 = "-9999" Then
                If Q > 0 Then
                    quantity47 = Q
                Else
                    quantity47 = 0
                End If
                quantity = "quantity47"
                quantityVal = quantity47
                tbStok_quantityUpdate_Eticaret(code, quantity, quantityVal)
                ElseIf quantity48 = "-9999" Then
                If Q > 0 Then
                    quantity48 = Q
                Else
                    quantity48 = 0
                End If
                quantity = "quantity48"
                quantityVal = quantity48
                tbStok_quantityUpdate_Eticaret(code, quantity, quantityVal)
                ElseIf quantity49 = "-9999" Then
                If Q > 0 Then
                    quantity49 = Q
                Else
                    quantity49 = 0
                End If
                quantity = "quantity49"
                quantityVal = quantity49
                tbStok_quantityUpdate_Eticaret(code, quantity, quantityVal)
                ElseIf quantity50 = "-9999" Then
                If Q > 0 Then
                    quantity50 = Q
                Else
                    quantity50 = 0
                End If
                quantity = "quantity50"
                quantityVal = quantity50
                tbStok_quantityUpdate_Eticaret(code, quantity, quantityVal)
                ElseIf quantity51 = "-9999" Then
                If Q > 0 Then
                    quantity51 = Q
                Else
                    quantity51 = 0
                End If
                quantity = "quantity51"
                quantityVal = quantity51
                tbStok_quantityUpdate_Eticaret(code, quantity, quantityVal)
                ElseIf quantity52 = "-9999" Then
                If Q > 0 Then
                    quantity52 = Q
                Else
                    quantity52 = 0
                End If
                quantity = "quantity52"
                quantityVal = quantity52
                tbStok_quantityUpdate_Eticaret(code, quantity, quantityVal)
                ElseIf quantity53 = "-9999" Then
                If Q > 0 Then
                    quantity53 = Q
                Else
                    quantity53 = 0
                End If
                quantity = "quantity53"
                quantityVal = quantity53
                tbStok_quantityUpdate_Eticaret(code, quantity, quantityVal)
                ElseIf quantity54 = "-9999" Then
                If Q > 0 Then
                    quantity54 = Q
                Else
                    quantity54 = 0
                End If
                quantity = "quantity54"
                quantityVal = quantity54
                tbStok_quantityUpdate_Eticaret(code, quantity, quantityVal)
                ElseIf quantity55 = "-9999" Then
                If Q > 0 Then
                    quantity55 = Q
                Else
                    quantity55 = 0
                End If
                quantity = "quantity55"
                quantityVal = quantity55
                tbStok_quantityUpdate_Eticaret(code, quantity, quantityVal)
                ElseIf quantity56 = "-9999" Then
                If Q > 0 Then
                    quantity56 = Q
                Else
                    quantity56 = 0
                End If
                quantity = "quantity56"
                quantityVal = quantity56
                tbStok_quantityUpdate_Eticaret(code, quantity, quantityVal)
                ElseIf quantity57 = "-9999" Then
                If Q > 0 Then
                    quantity57 = Q
                Else
                    quantity57 = 0
                End If
                quantity = "quantity57"
                quantityVal = quantity57
                tbStok_quantityUpdate_Eticaret(code, quantity, quantityVal)
                ElseIf quantity58 = "-9999" Then
                If Q > 0 Then
                    quantity58 = Q
                Else
                    quantity58 = 0
                End If
                quantity = "quantity58"
                quantityVal = quantity58
                tbStok_quantityUpdate_Eticaret(code, quantity, quantityVal)
                ElseIf quantity59 = "-9999" Then
                If Q > 0 Then
                    quantity59 = Q
                Else
                    quantity59 = 0
                End If
                quantity = "quantity59"
                quantityVal = quantity59
                tbStok_quantityUpdate_Eticaret(code, quantity, quantityVal)
                ElseIf quantity60 = "-9999" Then
                If Q > 0 Then
                    quantity60 = Q
                Else
                    quantity60 = 0
                End If
                quantity = "quantity60"
                quantityVal = quantity60
                tbStok_quantityUpdate_Eticaret(code, quantity, quantityVal)
            End If

            If quantity1 > "0" Then
                    quantitys += quantity1
                    tbStok_quantitysUpdate_Eticaret(code, quantitys)
                ElseIf quantity2 > "0" Then
                    quantitys += quantity2
                    tbStok_quantitysUpdate_Eticaret(code, quantitys)
                ElseIf quantity3 > "0" Then
                    quantitys += quantity3
                    tbStok_quantitysUpdate_Eticaret(code, quantitys)
                ElseIf quantity4 > "0" Then
                    quantitys += quantity4
                    tbStok_quantitysUpdate_Eticaret(code, quantitys)
                ElseIf quantity5 > "0" Then
                    quantitys += quantity5
                    tbStok_quantitysUpdate_Eticaret(code, quantitys)
                ElseIf quantity6 > "0" Then
                    quantitys += quantity6
                    tbStok_quantitysUpdate_Eticaret(code, quantitys)
                ElseIf quantity7 > "0" Then
                    quantitys += quantity7
                    tbStok_quantitysUpdate_Eticaret(code, quantitys)
                ElseIf quantity8 > "0" Then
                    quantitys += quantity8
                    tbStok_quantitysUpdate_Eticaret(code, quantitys)
                ElseIf quantity9 > "0" Then
                    quantitys += quantity9
                    tbStok_quantitysUpdate_Eticaret(code, quantitys)
                ElseIf quantity10 > "0" Then
                    quantitys += quantity10
                    tbStok_quantitysUpdate_Eticaret(code, quantitys)
                ElseIf quantity11 > "0" Then
                    quantitys += quantity11
                    tbStok_quantitysUpdate_Eticaret(code, quantitys)
                ElseIf quantity12 > "0" Then
                    quantitys += quantity12
                    tbStok_quantitysUpdate_Eticaret(code, quantitys)
                ElseIf quantity13 > "0" Then
                    quantitys += quantity13
                    tbStok_quantitysUpdate_Eticaret(code, quantitys)
                ElseIf quantity14 > "0" Then
                    quantitys += quantity14
                    tbStok_quantitysUpdate_Eticaret(code, quantitys)
                ElseIf quantity15 > "0" Then
                    quantitys += quantity15
                    tbStok_quantitysUpdate_Eticaret(code, quantitys)
                ElseIf quantity16 > "0" Then
                    quantitys += quantity16
                    tbStok_quantitysUpdate_Eticaret(code, quantitys)
                ElseIf quantity17 > "0" Then
                    quantitys += quantity17
                    tbStok_quantitysUpdate_Eticaret(code, quantitys)
                ElseIf quantity18 > "0" Then
                    quantitys += quantity18
                    tbStok_quantitysUpdate_Eticaret(code, quantitys)
                ElseIf quantity19 > "0" Then
                    quantitys += quantity19
                    tbStok_quantitysUpdate_Eticaret(code, quantitys)
                ElseIf quantity20 > "0" Then
                    quantitys += quantity20
                    tbStok_quantitysUpdate_Eticaret(code, quantitys)
                ElseIf quantity21 > "0" Then
                    quantitys += quantity21
                    tbStok_quantitysUpdate_Eticaret(code, quantitys)
                ElseIf quantity22 > "0" Then
                    quantitys += quantity22
                    tbStok_quantitysUpdate_Eticaret(code, quantitys)
                ElseIf quantity23 > "0" Then
                    quantitys += quantity23
                    tbStok_quantitysUpdate_Eticaret(code, quantitys)
                ElseIf quantity24 > "0" Then
                    quantitys += quantity24
                    tbStok_quantitysUpdate_Eticaret(code, quantitys)
                ElseIf quantity25 > "0" Then
                    quantitys += quantity25
                    tbStok_quantitysUpdate_Eticaret(code, quantitys)
                ElseIf quantity26 > "0" Then
                    quantitys += quantity26
                    tbStok_quantitysUpdate_Eticaret(code, quantitys)
                ElseIf quantity27 > "0" Then
                    quantitys += quantity27
                    tbStok_quantitysUpdate_Eticaret(code, quantitys)
                ElseIf quantity28 > "0" Then
                    quantitys += quantity28
                    tbStok_quantitysUpdate_Eticaret(code, quantitys)
                ElseIf quantity29 > "0" Then
                    quantitys += quantity29
                    tbStok_quantitysUpdate_Eticaret(code, quantitys)
                ElseIf quantity30 > "0" Then
                    quantitys += quantity30
                    tbStok_quantitysUpdate_Eticaret(code, quantitys)
                ElseIf quantity31 > "0" Then
                    quantitys += quantity31
                    tbStok_quantitysUpdate_Eticaret(code, quantitys)
                ElseIf quantity32 > "0" Then
                    quantitys += quantity32
                    tbStok_quantitysUpdate_Eticaret(code, quantitys)
                ElseIf quantity33 > "0" Then
                    quantitys += quantity33
                    tbStok_quantitysUpdate_Eticaret(code, quantitys)
                ElseIf quantity34 > "0" Then
                    quantitys += quantity34
                    tbStok_quantitysUpdate_Eticaret(code, quantitys)
                ElseIf quantity35 > "0" Then
                    quantitys += quantity35
                    tbStok_quantitysUpdate_Eticaret(code, quantitys)
                ElseIf quantity36 > "0" Then
                    quantitys += quantity36
                    tbStok_quantitysUpdate_Eticaret(code, quantitys)
                ElseIf quantity37 > "0" Then
                    quantitys += quantity37
                    tbStok_quantitysUpdate_Eticaret(code, quantitys)
                ElseIf quantity38 > "0" Then
                    quantitys += quantity38
                    tbStok_quantitysUpdate_Eticaret(code, quantitys)
                ElseIf quantity39 > "0" Then
                    quantitys += quantity39
                    tbStok_quantitysUpdate_Eticaret(code, quantitys)
                ElseIf quantity40 > "0" Then
                    quantitys += quantity40
                    tbStok_quantitysUpdate_Eticaret(code, quantitys)
                ElseIf quantity41 > "0" Then
                    quantitys += quantity41
                    tbStok_quantitysUpdate_Eticaret(code, quantitys)
                ElseIf quantity42 > "0" Then
                    quantitys += quantity42
                    tbStok_quantitysUpdate_Eticaret(code, quantitys)
                ElseIf quantity43 > "0" Then
                    quantitys += quantity43
                    tbStok_quantitysUpdate_Eticaret(code, quantitys)
                ElseIf quantity44 > "0" Then
                    quantitys += quantity44
                    tbStok_quantitysUpdate_Eticaret(code, quantitys)
                ElseIf quantity45 > "0" Then
                    quantitys += quantity45
                    tbStok_quantitysUpdate_Eticaret(code, quantitys)
                ElseIf quantity46 > "0" Then
                    quantitys += quantity46
                    tbStok_quantitysUpdate_Eticaret(code, quantitys)
                ElseIf quantity47 > "0" Then
                    quantitys += quantity47
                    tbStok_quantitysUpdate_Eticaret(code, quantitys)
                ElseIf quantity48 > "0" Then
                    quantitys += quantity48
                    tbStok_quantitysUpdate_Eticaret(code, quantitys)
                ElseIf quantity49 > "0" Then
                    quantitys += quantity49
                    tbStok_quantitysUpdate_Eticaret(code, quantitys)
                ElseIf quantity50 > "0" Then
                    quantitys += quantity50
                    tbStok_quantitysUpdate_Eticaret(code, quantitys)
                ElseIf quantity51 > "0" Then
                    quantitys += quantity51
                    tbStok_quantitysUpdate_Eticaret(code, quantitys)
                ElseIf quantity52 > "0" Then
                    quantitys += quantity52
                    tbStok_quantitysUpdate_Eticaret(code, quantitys)
                ElseIf quantity53 > "0" Then
                    quantitys += quantity53
                    tbStok_quantitysUpdate_Eticaret(code, quantitys)
                ElseIf quantity54 > "0" Then
                    quantitys += quantity54
                    tbStok_quantitysUpdate_Eticaret(code, quantitys)
                ElseIf quantity55 > "0" Then
                    quantitys += quantity55
                    tbStok_quantitysUpdate_Eticaret(code, quantitys)
                ElseIf quantity56 > "0" Then
                    quantitys += quantity56
                    tbStok_quantitysUpdate_Eticaret(code, quantitys)
                ElseIf quantity57 > "0" Then
                    quantitys += quantity57
                    tbStok_quantitysUpdate_Eticaret(code, quantitys)
                ElseIf quantity58 > "0" Then
                    quantitys += quantity58
                    tbStok_quantitysUpdate_Eticaret(code, quantitys)
                ElseIf quantity59 > "0" Then
                    quantitys += quantity59
                    tbStok_quantitysUpdate_Eticaret(code, quantitys)
                ElseIf quantity60 > "0" Then
                    quantitys += quantity60
                    tbStok_quantitysUpdate_Eticaret(code, quantitys)
                End If




                'tbStok_Update_Eticaret(code, buyPrice, salePrice, listPrice)

            End If
            con1.Close()

        Next

        ' JSON BAÞLANGIÇ


        'Dim adapter As New OleDb.OleDbDataAdapter
        Dim cmd5 As New OleDb.OleDbCommand
        Dim con5 As New OleDb.OleDbConnection
        Dim dr4 As DataRow
        Dim DS4 As New DataSet

        con5.ConnectionString = connection
        con5.Open()
        'cmd5.CommandText = "select nStokID, code, name, ISNULL(Renk1,0)as Renk1, ISNULL(Beden1,0) as Beden1,  ISNULL(barcode1,0) as barcode1,  ISNULL(Fiyat1,0) as Fiyat1,  ISNULL(quantity1,0) as quantity1,  ISNULL(Renk2,0) as Renk2,  ISNULL(Beden2,0) as Beden2,  ISNULL(barcode2,0) as barcode2,  ISNULL(Fiyat2,0) as Fiyat2,  ISNULL(quantity2,0) as quantity2,  ISNULL(Renk3,0) as Renk3,  ISNULL(Beden3,0) as Beden3,  ISNULL(barcode3,0) as barcode3,  ISNULL(Fiyat3,0) as Fiyat3,  ISNULL(quantity3,0) as quantity3,  ISNULL(Renk4,0) as Renk4,  ISNULL(Beden4,0) as Beden4,  ISNULL(barcode4,0) as barcode4,  ISNULL(Fiyat4,0) as Fiyat4,  ISNULL(quantity4,0) as quantity4,  ISNULL(Renk5,0) as Renk5, ISNULL(Beden5,0) as Beden5, ISNULL(barcode5,0) as barcode5, ISNULL(quantity5,0) as quantity5, ISNULL(Fiyat5,0) as Fiyat5, ISNULL(Renk6,0) as Renk6, ISNULL(Beden6,0) as Beden6, ISNULL(barcode6,0) as barcode6, ISNULL(Fiyat6,0) as Fiyat6, ISNULL(quantity6,0) as quantity6, ISNULL(Renk7,0) as Renk7, ISNULL(Beden7,0) as Beden7, ISNULL(barcode7,0) as barcode7, ISNULL(Fiyat7,0) as Fiyat7, ISNULL(quantity7,0) as quantity7, ISNULL(Renk8,0) as Renk8, ISNULL(Beden8,0) as Beden8, ISNULL(barcode8,0) as barcode8, ISNULL(Fiyat8,0) as Fiyat8, ISNULL(quantity8,0) as quantity8, ISNULL(Renk9,0) as Renk9, ISNULL(Beden9,0) as Beden9, ISNULL(barcode9,0) as barcode9, ISNULL(Fiyat9,0) as Fiyat9, ISNULL(quantity9,0) as quantity9, ISNULL(Renk10,0) as Renk10, ISNULL(Beden10,0) as Beden10, ISNULL(barcode10,0) as barcode10, ISNULL(Fiyat10,0) as Fiyat10, ISNULL(quantity10,0) as quantity10, ISNULL(Renk11,0) as Renk11, ISNULL(Beden11,0) as Beden11, ISNULL(barcode11,0) as barcode11, ISNULL(Fiyat11,0) as Fiyat11, ISNULL(quantity11,0) as quantity11, ISNULL(Renk12,0) as Renk12, ISNULL(Beden12,0) as Beden12, ISNULL(barcode12,0) as barcode12, ISNULL(Fiyat12,0) as Fiyat12, ISNULL(quantity12,0) as quantity12, ISNULL(Renk13,0) as Renk13, ISNULL(Beden13,0) as Beden13, ISNULL(barcode13,0) as barcode13, ISNULL(Fiyat13,0) as Fiyat13, ISNULL(quantity13,0) as quantity13, ISNULL(Renk14,0) as Renk14, ISNULL(Beden14,0) as Beden14, ISNULL(barcode14,0) as barcode14, ISNULL(Fiyat14,0) as Fiyat14, ISNULL(quantity14,0) as quantity14, ISNULL(Renk15,0) as Renk15, ISNULL(Beden15,0) as Beden15, ISNULL(barcode15,0) as barcode15, ISNULL(Fiyat15,0) as Fiyat15, ISNULL(quantity15,0) as quantity15, ISNULL(Renk16,0) as Renk16, ISNULL(Beden16,0) as Beden16, ISNULL(barcode16,0) as barcode16, ISNULL(Fiyat16,0) as Fiyat16, ISNULL(quantity16,0) as quantity16, ISNULL(Renk17,0) as Renk17, ISNULL(Beden17,0) as Beden17, ISNULL(barcode17,0) as barcode17, ISNULL(Fiyat17,0) as Fiyat17, ISNULL(quantity17,0) as quantity17, ISNULL(Renk18,0) as Renk18, ISNULL(Beden18,0) as Beden18, ISNULL(barcode18,0) as barcode18, ISNULL(Fiyat18,0) as Fiyat18, ISNULL(quantity18,0) as quantity18, ISNULL(Renk19,0) as Renk19, ISNULL(Beden19,0) as Beden19, ISNULL(barcode19,0) as barcode19, ISNULL(Fiyat19,0) as Fiyat19, ISNULL(quantity19,0) as quantity19, ISNULL(Renk20,0) as Renk20, ISNULL(Beden20,0) as Beden20, ISNULL(barcode20,0) as barcode20, ISNULL(Fiyat20,0) as Fiyat20, ISNULL(quantity20,0) as quantity20, ISNULL(brand,0) as brand, ISNULL(category1,0) as category1, ISNULL(category2,0) as category2, ISNULL(category3,0) as category3, ISNULL(category4,0) as category4, ISNULL(category5,0) as category5,ISNULL(longDescription,0) as longDescription, ISNULL(seoTitle,0) as seoTitle, ISNULL(seoKeywords,0) as seoKeywords, ISNULL(seoDescription,0) as seoDescription, ISNULL(variant1Name,0) as variant1Name, ISNULL(variant2Name,0) as variant2Name, ISNULL(taxRate,0) as taxRate, ISNULL(shipmentPayment,0) as shipmentPayment, ISNULL(buyPrice,0) as buyPrice, ISNULL(listPrice,0) as listPrice, ISNULL(salePrice,0) as salePrice, ISNULL(TysalePrice,0) as TysalePrice, ISNULL(N11salePrice,0) as N11salePrice, ISNULL(GgsalePrice,0) as GgsalePrice, ISNULL(HbsalePrice,0) as HbsalePrice, ISNULL(EpttsalePrice,0) as EpttsalePrice, ISNULL(CssalePrice,0) as CssalePrice, ISNULL(amzsalePrice,0) as amzsalePrice, ISNULL(NewsalePrice,0) as NewsalePrice, ISNULL(quantity,0) as quantity, ISNULL(imageUrl,0) as imageUrl, ISNULL(imageUrl1,0) as imageUrl1, ISNULL(imageUrl2,0) as imageUrl2, ISNULL(imageUrl3,0) as imageUrl3, ISNULL(imageUrl4,0) as imageUrl4, ISNULL(imageUrl5,0) as imageUrl5, ISNULL(imageUrl6,0) as imageUrl6, ISNULL(imageUrl7,0) as imageUrl7, ISNULL(imageUrl8,0) as imageUrl8, ISNULL(imageUrl9,0) as imageUrl9, ISNULL(imageUrl10,0) as imageUrl10, ISNULL(dteGuncelZaman,0) as dteGuncelZaman from tbStokEticaret where GUNCEL = '0'"
        cmd5.CommandText = "select nStokID, code, name, ISNULL(Renk1,0)as Renk1, ISNULL(Beden1,0) as Beden1,  ISNULL(barcode1,0) as barcode1,  ISNULL(Fiyat1,0) as Fiyat1,  ISNULL(quantity1,0) as quantity1,  ISNULL(Renk2,0) as Renk2,  ISNULL(Beden2,0) as Beden2,  ISNULL(barcode2,0) as barcode2,  ISNULL(Fiyat2,0) as Fiyat2,  ISNULL(quantity2,0) as quantity2,  ISNULL(Renk3,0) as Renk3,  ISNULL(Beden3,0) as Beden3,  ISNULL(barcode3,0) as barcode3,  ISNULL(Fiyat3,0) as Fiyat3,  ISNULL(quantity3,0) as quantity3,  ISNULL(Renk4,0) as Renk4,  ISNULL(Beden4,0) as Beden4,  ISNULL(barcode4,0) as barcode4,  ISNULL(Fiyat4,0) as Fiyat4,  ISNULL(quantity4,0) as quantity4,  ISNULL(Renk5,0) as Renk5, ISNULL(Beden5,0) as Beden5, ISNULL(barcode5,0) as barcode5, ISNULL(quantity5,0) as quantity5, ISNULL(Fiyat5,0) as Fiyat5, ISNULL(Renk6,0) as Renk6, ISNULL(Beden6,0) as Beden6, ISNULL(barcode6,0) as barcode6, ISNULL(Fiyat6,0) as Fiyat6, ISNULL(quantity6,0) as quantity6, ISNULL(Renk7,0) as Renk7, ISNULL(Beden7,0) as Beden7, ISNULL(barcode7,0) as barcode7, ISNULL(Fiyat7,0) as Fiyat7, ISNULL(quantity7,0) as quantity7, ISNULL(Renk8,0) as Renk8, ISNULL(Beden8,0) as Beden8, ISNULL(barcode8,0) as barcode8, ISNULL(Fiyat8,0) as Fiyat8, ISNULL(quantity8,0) as quantity8, ISNULL(Renk9,0) as Renk9, ISNULL(Beden9,0) as Beden9, ISNULL(barcode9,0) as barcode9, ISNULL(Fiyat9,0) as Fiyat9, ISNULL(quantity9,0) as quantity9, ISNULL(Renk10,0) as Renk10, ISNULL(Beden10,0) as Beden10, ISNULL(barcode10,0) as barcode10, ISNULL(Fiyat10,0) as Fiyat10, ISNULL(quantity10,0) as quantity10, ISNULL(Renk11,0) as Renk11, ISNULL(Beden11,0) as Beden11, ISNULL(barcode11,0) as barcode11, ISNULL(Fiyat11,0) as Fiyat11, ISNULL(quantity11,0) as quantity11, ISNULL(Renk12,0) as Renk12, ISNULL(Beden12,0) as Beden12, ISNULL(barcode12,0) as barcode12, ISNULL(Fiyat12,0) as Fiyat12, ISNULL(quantity12,0) as quantity12, ISNULL(Renk13,0) as Renk13, ISNULL(Beden13,0) as Beden13, ISNULL(barcode13,0) as barcode13, ISNULL(Fiyat13,0) as Fiyat13, ISNULL(quantity13,0) as quantity13, ISNULL(Renk14,0) as Renk14, ISNULL(Beden14,0) as Beden14, ISNULL(barcode14,0) as barcode14, ISNULL(Fiyat14,0) as Fiyat14, ISNULL(quantity14,0) as quantity14, ISNULL(Renk15,0) as Renk15, ISNULL(Beden15,0) as Beden15, ISNULL(barcode15,0) as barcode15, ISNULL(Fiyat15,0) as Fiyat15, ISNULL(quantity15,0) as quantity15, ISNULL(Renk16,0) as Renk16, ISNULL(Beden16,0) as Beden16, ISNULL(barcode16,0) as barcode16, ISNULL(Fiyat16,0) as Fiyat16, ISNULL(quantity16,0) as quantity16, ISNULL(Renk17,0) as Renk17, ISNULL(Beden17,0) as Beden17, ISNULL(barcode17,0) as barcode17, ISNULL(Fiyat17,0) as Fiyat17, ISNULL(quantity17,0) as quantity17, ISNULL(Renk18,0) as Renk18, ISNULL(Beden18,0) as Beden18, ISNULL(barcode18,0) as barcode18, ISNULL(Fiyat18,0) as Fiyat18, ISNULL(quantity18,0) as quantity18, ISNULL(Renk19,0) as Renk19, ISNULL(Beden19,0) as Beden19, ISNULL(barcode19,0) as barcode19, ISNULL(Fiyat19,0) as Fiyat19, ISNULL(quantity19,0) as quantity19, ISNULL(Renk20,0) as Renk20, ISNULL(Beden20,0) as Beden20, ISNULL(barcode20,0) as barcode20, ISNULL(Fiyat20,0) as Fiyat20, ISNULL(quantity20,0) as quantity20, ISNULL(Renk21,0) as Renk21, ISNULL(Beden21,0) as Beden21, ISNULL(barcode21,0) as barcode21, ISNULL(Fiyat21,0) as Fiyat21, ISNULL(quantity21,0) as quantity21, ISNULL(Renk22,0) as Renk22, ISNULL(Beden22,0) as Beden22, ISNULL(barcode22,0) as barcode22, ISNULL(Fiyat22,0) as Fiyat22, ISNULL(quantity22,0) as quantity22, ISNULL(Renk23,0) as Renk23, ISNULL(Beden23,0) as Beden23, ISNULL(barcode23,0) as barcode23, ISNULL(Fiyat23,0) as Fiyat23, ISNULL(quantity23,0) as quantity23, ISNULL(Renk24,0) as Renk24, ISNULL(Beden24,0) as Beden24, ISNULL(barcode24,0) as barcode24, ISNULL(Fiyat24,0) as Fiyat24, ISNULL(quantity24,0) as quantity24, ISNULL(Renk25,0) as Renk25, ISNULL(Beden25,0) as Beden25, ISNULL(barcode25,0) as barcode25, ISNULL(Fiyat25,0) as Fiyat25, ISNULL(quantity25,0) as quantity25, ISNULL(Renk26,0) as Renk26, ISNULL(Beden26,0) as Beden26, ISNULL(barcode26,0) as barcode26, ISNULL(Fiyat26,0) as Fiyat26, ISNULL(quantity26,0) as quantity26, ISNULL(Renk27,0) as Renk27, ISNULL(Beden27,0) as Beden27, ISNULL(barcode27,0) as barcode27, ISNULL(Fiyat27,0) as Fiyat27, ISNULL(quantity27,0) as quantity27, ISNULL(Renk28,0) as Renk28, ISNULL(Beden28,0) as Beden28, ISNULL(barcode28,0) as barcode28, ISNULL(Fiyat28,0) as Fiyat28, ISNULL(quantity28,0) as quantity28, ISNULL(Renk29,0) as Renk29, ISNULL(Beden29,0) as Beden29, ISNULL(barcode29,0) as barcode29, ISNULL(Fiyat29,0) as Fiyat29, ISNULL(quantity29,0) as quantity29, ISNULL(Renk30,0) as Renk30, ISNULL(Beden30,0) as Beden30, ISNULL(barcode30,0) as barcode30, ISNULL(Fiyat30,0) as Fiyat30, ISNULL(quantity30,0) as quantity30, ISNULL(Renk31,0) as Renk31, ISNULL(Beden31,0) as Beden31, ISNULL(barcode31,0) as barcode31, ISNULL(Fiyat31,0) as Fiyat31, ISNULL(quantity31,0) as quantity31, ISNULL(Renk32,0) as Renk32, ISNULL(Beden32,0) as Beden32, ISNULL(barcode32,0) as barcode32, ISNULL(Fiyat32,0) as Fiyat32, ISNULL(quantity32,0) as quantity32, ISNULL(Renk33,0) as Renk33, ISNULL(Beden33,0) as Beden33, ISNULL(barcode33,0) as barcode33, ISNULL(Fiyat33,0) as Fiyat33, ISNULL(quantity33,0) as quantity33, ISNULL(Renk34,0) as Renk34, ISNULL(Beden34,0) as Beden34, ISNULL(barcode34,0) as barcode34, ISNULL(Fiyat34,0) as Fiyat34, ISNULL(quantity34,0) as quantity34, ISNULL(Renk35,0) as Renk35, ISNULL(Beden35,0) as Beden35, ISNULL(barcode35,0) as barcode35, ISNULL(Fiyat35,0) as Fiyat35, ISNULL(quantity35,0) as quantity35, ISNULL(Renk36,0) as Renk36, ISNULL(Beden36,0) as Beden36, ISNULL(barcode36,0) as barcode36, ISNULL(Fiyat36,0) as Fiyat36, ISNULL(quantity36,0) as quantity36, ISNULL(Renk37,0) as Renk37, ISNULL(Beden37,0) as Beden37, ISNULL(barcode37,0) as barcode37, ISNULL(Fiyat37,0) as Fiyat37, ISNULL(quantity37,0) as quantity37, ISNULL(Renk38,0) as Renk38, ISNULL(Beden38,0) as Beden38, ISNULL(barcode38,0) as barcode38, ISNULL(Fiyat38,0) as Fiyat38, ISNULL(quantity38,0) as quantity38, ISNULL(Renk39,0) as Renk39, ISNULL(Beden39,0) as Beden39, ISNULL(barcode39,0) as barcode39, ISNULL(Fiyat39,0) as Fiyat39, ISNULL(quantity39,0) as quantity39, ISNULL(Renk40,0) as Renk40, ISNULL(Beden40,0) as Beden40, ISNULL(barcode40,0) as barcode40, ISNULL(Fiyat40,0) as Fiyat40, ISNULL(quantity40,0) as quantity40, ISNULL(Renk41,0) as Renk41, ISNULL(Beden41,0) as Beden41, ISNULL(barcode41,0) as barcode41, ISNULL(Fiyat41,0) as Fiyat41, ISNULL(quantity41,0) as quantity41, ISNULL(Renk42,0) as Renk42, ISNULL(Beden42,0) as Beden42, ISNULL(barcode42,0) as barcode42, ISNULL(Fiyat42,0) as Fiyat42, ISNULL(quantity42,0) as quantity42, ISNULL(Renk43,0) as Renk43, ISNULL(Beden43,0) as Beden43, ISNULL(barcode43,0) as barcode43, ISNULL(Fiyat43,0) as Fiyat43, ISNULL(quantity43,0) as quantity43, ISNULL(Renk44,0) as Renk44, ISNULL(Beden44,0) as Beden44, ISNULL(barcode44,0) as barcode44, ISNULL(Fiyat44,0) as Fiyat44, ISNULL(quantity44,0) as quantity44, ISNULL(Renk45,0) as Renk45, ISNULL(Beden45,0) as Beden45, ISNULL(barcode45,0) as barcode45, ISNULL(Fiyat45,0) as Fiyat45, ISNULL(quantity45,0) as quantity45, ISNULL(Renk46,0) as Renk46, ISNULL(Beden46,0) as Beden46, ISNULL(barcode46,0) as barcode46, ISNULL(Fiyat46,0) as Fiyat46, ISNULL(quantity46,0) as quantity46, ISNULL(Renk47,0) as Renk47, ISNULL(Beden47,0) as Beden47, ISNULL(barcode47,0) as barcode47, ISNULL(Fiyat47,0) as Fiyat47, ISNULL(quantity47,0) as quantity47, ISNULL(Renk48,0) as Renk48, ISNULL(Beden48,0) as Beden48, ISNULL(barcode48,0) as barcode48, ISNULL(Fiyat48,0) as Fiyat48, ISNULL(quantity48,0) as quantity48, ISNULL(Renk49,0) as Renk49, ISNULL(Beden49,0) as Beden49, ISNULL(barcode49,0) as barcode49, ISNULL(Fiyat49,0) as Fiyat49, ISNULL(quantity49,0) as quantity49, ISNULL(Renk50,0) as Renk50, ISNULL(Beden50,0) as Beden50, ISNULL(barcode50,0) as barcode50, ISNULL(Fiyat50,0) as Fiyat50, ISNULL(quantity50,0) as quantity50, ISNULL(Renk51,0) as Renk51, ISNULL(Beden51,0) as Beden51, ISNULL(barcode51,0) as barcode51, ISNULL(Fiyat51,0) as Fiyat51, ISNULL(quantity51,0) as quantity51, ISNULL(Renk52,0) as Renk52, ISNULL(Beden52,0) as Beden52, ISNULL(barcode52,0) as barcode52, ISNULL(Fiyat52,0) as Fiyat52, ISNULL(quantity52,0) as quantity52, ISNULL(Renk53,0) as Renk53, ISNULL(Beden53,0) as Beden53, ISNULL(barcode53,0) as barcode53, ISNULL(Fiyat53,0) as Fiyat53, ISNULL(quantity53,0) as quantity53, ISNULL(Renk54,0) as Renk54, ISNULL(Beden54,0) as Beden54, ISNULL(barcode54,0) as barcode54, ISNULL(Fiyat54,0) as Fiyat54, ISNULL(quantity54,0) as quantity54, ISNULL(Renk55,0) as Renk55, ISNULL(Beden55,0) as Beden55, ISNULL(barcode55,0) as barcode55, ISNULL(Fiyat55,0) as Fiyat55, ISNULL(quantity55,0) as quantity55, ISNULL(Renk56,0) as Renk56, ISNULL(Beden56,0) as Beden56, ISNULL(barcode56,0) as barcode56, ISNULL(Fiyat56,0) as Fiyat56, ISNULL(quantity56,0) as quantity56, ISNULL(Renk57,0) as Renk57, ISNULL(Beden57,0) as Beden57, ISNULL(barcode57,0) as barcode57, ISNULL(Fiyat57,0) as Fiyat57, ISNULL(quantity57,0) as quantity57, ISNULL(Renk58,0) as Renk58, ISNULL(Beden58,0) as Beden58, ISNULL(barcode58,0) as barcode58, ISNULL(Fiyat58,0) as Fiyat58, ISNULL(quantity58,0) as quantity58, ISNULL(Renk59,0) as Renk59, ISNULL(Beden59,0) as Beden59, ISNULL(barcode59,0) as barcode59, ISNULL(Fiyat59,0) as Fiyat59, ISNULL(quantity59,0) as quantity59, ISNULL(Renk60,0) as Renk60, ISNULL(Beden60,0) as Beden60, ISNULL(barcode60,0) as barcode60, ISNULL(Fiyat60,0) as Fiyat60, ISNULL(quantity60,0) as quantity60, ISNULL(brand,0) as brand, ISNULL(category1,0) as category1, ISNULL(category2,0) as category2, ISNULL(category3,0) as category3, ISNULL(category4,0) as category4, ISNULL(category5,0) as category5,ISNULL(longDescription,0) as longDescription, ISNULL(seoTitle,0) as seoTitle, ISNULL(seoKeywords,0) as seoKeywords, ISNULL(seoDescription,0) as seoDescription, ISNULL(variant1Name,0) as variant1Name, ISNULL(variant2Name,0) as variant2Name, ISNULL(taxRate,0) as taxRate, ISNULL(shipmentPayment,0) as shipmentPayment, ISNULL(buyPrice,0) as buyPrice, ISNULL(listPrice,0) as listPrice, ISNULL(salePrice,0) as salePrice, ISNULL(TysalePrice,0) as TysalePrice, ISNULL(N11salePrice,0) as N11salePrice, ISNULL(GgsalePrice,0) as GgsalePrice, ISNULL(HbsalePrice,0) as HbsalePrice, ISNULL(EpttsalePrice,0) as EpttsalePrice, ISNULL(CssalePrice,0) as CssalePrice, ISNULL(amzsalePrice,0) as amzsalePrice, ISNULL(NewsalePrice,0) as NewsalePrice, ISNULL(quantity,0) as quantity, ISNULL(imageUrl,0) as imageUrl, ISNULL(imageUrl1,0) as imageUrl1, ISNULL(imageUrl2,0) as imageUrl2, ISNULL(imageUrl3,0) as imageUrl3, ISNULL(imageUrl4,0) as imageUrl4, ISNULL(imageUrl5,0) as imageUrl5, ISNULL(imageUrl6,0) as imageUrl6, ISNULL(imageUrl7,0) as imageUrl7, ISNULL(imageUrl8,0) as imageUrl8, ISNULL(imageUrl9,0) as imageUrl9, ISNULL(imageUrl10,0) as imageUrl10, ISNULL(dteGuncelZaman,0) as dteGuncelZaman from tbStokEticaret where GUNCEL = '0'"
        cmd5.Connection = con5
        adapter.SelectCommand = cmd5
        N = adapter.Fill(DS4, "Table1")

        For Each dr4 In DS4.Tables(0).Rows

            dr4("nStokID") = dr4("nStokID").ToString
            dr4("code") = Trim(dr4("code").ToString)
            dr4("name") = dr4("name").ToString
            dr4("Renk1") = Trim(dr4("Renk1").ToString)
            dr4("Renk2") = Trim(dr4("Renk2").ToString)
            dr4("Renk3") = Trim(dr4("Renk3").ToString)
            dr4("Renk4") = Trim(dr4("Renk4").ToString)
            dr4("Renk5") = Trim(dr4("Renk5").ToString)
            dr4("Renk6") = Trim(dr4("Renk6").ToString)
            dr4("Renk7") = Trim(dr4("Renk7").ToString)
            dr4("Renk8") = Trim(dr4("Renk8").ToString)
            dr4("Renk9") = Trim(dr4("Renk9").ToString)
            dr4("Renk10") = Trim(dr4("Renk10").ToString)
            dr4("Renk11") = Trim(dr4("Renk11").ToString)
            dr4("Renk12") = Trim(dr4("Renk12").ToString)
            dr4("Renk13") = Trim(dr4("Renk13").ToString)
            dr4("Renk14") = Trim(dr4("Renk14").ToString)
            dr4("Renk15") = Trim(dr4("Renk15").ToString)
            dr4("Renk16") = Trim(dr4("Renk16").ToString)
            dr4("Renk17") = Trim(dr4("Renk17").ToString)
            dr4("Renk18") = Trim(dr4("Renk18").ToString)
            dr4("Renk19") = Trim(dr4("Renk19").ToString)
            dr4("Renk20") = Trim(dr4("Renk20").ToString)
            dr4("Renk21") = Trim(dr4("Renk21").ToString)
            dr4("Renk22") = Trim(dr4("Renk22").ToString)
            dr4("Renk23") = Trim(dr4("Renk23").ToString)
            dr4("Renk24") = Trim(dr4("Renk24").ToString)
            dr4("Renk25") = Trim(dr4("Renk25").ToString)
            dr4("Renk26") = Trim(dr4("Renk26").ToString)
            dr4("Renk27") = Trim(dr4("Renk27").ToString)
            dr4("Renk28") = Trim(dr4("Renk28").ToString)
            dr4("Renk29") = Trim(dr4("Renk29").ToString)
            dr4("Renk30") = Trim(dr4("Renk30").ToString)
            dr4("Renk31") = Trim(dr4("Renk31").ToString)
            dr4("Renk32") = Trim(dr4("Renk32").ToString)
            dr4("Renk33") = Trim(dr4("Renk33").ToString)
            dr4("Renk34") = Trim(dr4("Renk34").ToString)
            dr4("Renk35") = Trim(dr4("Renk35").ToString)
            dr4("Renk36") = Trim(dr4("Renk36").ToString)
            dr4("Renk37") = Trim(dr4("Renk37").ToString)
            dr4("Renk38") = Trim(dr4("Renk38").ToString)
            dr4("Renk39") = Trim(dr4("Renk39").ToString)
            dr4("Renk40") = Trim(dr4("Renk40").ToString)
            dr4("Renk41") = Trim(dr4("Renk41").ToString)
            dr4("Renk42") = Trim(dr4("Renk42").ToString)
            dr4("Renk43") = Trim(dr4("Renk43").ToString)
            dr4("Renk44") = Trim(dr4("Renk44").ToString)
            dr4("Renk45") = Trim(dr4("Renk45").ToString)
            dr4("Renk46") = Trim(dr4("Renk46").ToString)
            dr4("Renk47") = Trim(dr4("Renk47").ToString)
            dr4("Renk48") = Trim(dr4("Renk48").ToString)
            dr4("Renk49") = Trim(dr4("Renk49").ToString)
            dr4("Renk50") = Trim(dr4("Renk50").ToString)
            dr4("Renk51") = Trim(dr4("Renk51").ToString)
            dr4("Renk52") = Trim(dr4("Renk52").ToString)
            dr4("Renk53") = Trim(dr4("Renk53").ToString)
            dr4("Renk54") = Trim(dr4("Renk54").ToString)
            dr4("Renk55") = Trim(dr4("Renk55").ToString)
            dr4("Renk56") = Trim(dr4("Renk56").ToString)
            dr4("Renk57") = Trim(dr4("Renk57").ToString)
            dr4("Renk58") = Trim(dr4("Renk58").ToString)
            dr4("Renk59") = Trim(dr4("Renk59").ToString)
            dr4("Renk60") = Trim(dr4("Renk60").ToString)
            dr4("Beden1") = Trim(dr4("Beden1").ToString)
            dr4("Beden2") = Trim(dr4("Beden2").ToString)
            dr4("Beden3") = Trim(dr4("Beden3").ToString)
            dr4("Beden4") = Trim(dr4("Beden4").ToString)
            dr4("Beden5") = Trim(dr4("Beden5").ToString)
            dr4("Beden6") = Trim(dr4("Beden6").ToString)
            dr4("Beden7") = Trim(dr4("Beden7").ToString)
            dr4("Beden8") = Trim(dr4("Beden8").ToString)
            dr4("Beden9") = Trim(dr4("Beden9").ToString)
            dr4("Beden10") = Trim(dr4("Beden10").ToString)
            dr4("Beden11") = Trim(dr4("Beden11").ToString)
            dr4("Beden12") = Trim(dr4("Beden12").ToString)
            dr4("Beden13") = Trim(dr4("Beden13").ToString)
            dr4("Beden14") = Trim(dr4("Beden14").ToString)
            dr4("Beden15") = Trim(dr4("Beden15").ToString)
            dr4("Beden16") = Trim(dr4("Beden16").ToString)
            dr4("Beden17") = Trim(dr4("Beden17").ToString)
            dr4("Beden18") = Trim(dr4("Beden18").ToString)
            dr4("Beden19") = Trim(dr4("Beden19").ToString)
            dr4("Beden20") = Trim(dr4("Beden20").ToString)
            dr4("Beden21") = Trim(dr4("Beden21").ToString)
            dr4("Beden22") = Trim(dr4("Beden22").ToString)
            dr4("Beden23") = Trim(dr4("Beden23").ToString)
            dr4("Beden24") = Trim(dr4("Beden24").ToString)
            dr4("Beden25") = Trim(dr4("Beden25").ToString)
            dr4("Beden26") = Trim(dr4("Beden26").ToString)
            dr4("Beden27") = Trim(dr4("Beden27").ToString)
            dr4("Beden28") = Trim(dr4("Beden28").ToString)
            dr4("Beden29") = Trim(dr4("Beden29").ToString)
            dr4("Beden30") = Trim(dr4("Beden30").ToString)
            dr4("Beden31") = Trim(dr4("Beden31").ToString)
            dr4("Beden32") = Trim(dr4("Beden32").ToString)
            dr4("Beden33") = Trim(dr4("Beden33").ToString)
            dr4("Beden34") = Trim(dr4("Beden34").ToString)
            dr4("Beden35") = Trim(dr4("Beden35").ToString)
            dr4("Beden36") = Trim(dr4("Beden36").ToString)
            dr4("Beden37") = Trim(dr4("Beden37").ToString)
            dr4("Beden38") = Trim(dr4("Beden38").ToString)
            dr4("Beden39") = Trim(dr4("Beden39").ToString)
            dr4("Beden40") = Trim(dr4("Beden40").ToString)
            dr4("Beden41") = Trim(dr4("Beden41").ToString)
            dr4("Beden42") = Trim(dr4("Beden42").ToString)
            dr4("Beden43") = Trim(dr4("Beden43").ToString)
            dr4("Beden44") = Trim(dr4("Beden44").ToString)
            dr4("Beden45") = Trim(dr4("Beden45").ToString)
            dr4("Beden46") = Trim(dr4("Beden46").ToString)
            dr4("Beden47") = Trim(dr4("Beden47").ToString)
            dr4("Beden48") = Trim(dr4("Beden48").ToString)
            dr4("Beden49") = Trim(dr4("Beden49").ToString)
            dr4("Beden50") = Trim(dr4("Beden50").ToString)
            dr4("Beden51") = Trim(dr4("Beden51").ToString)
            dr4("Beden52") = Trim(dr4("Beden52").ToString)
            dr4("Beden53") = Trim(dr4("Beden53").ToString)
            dr4("Beden54") = Trim(dr4("Beden54").ToString)
            dr4("Beden55") = Trim(dr4("Beden55").ToString)
            dr4("Beden56") = Trim(dr4("Beden56").ToString)
            dr4("Beden57") = Trim(dr4("Beden57").ToString)
            dr4("Beden58") = Trim(dr4("Beden58").ToString)
            dr4("Beden59") = Trim(dr4("Beden59").ToString)
            dr4("Beden60") = Trim(dr4("Beden60").ToString)
            dr4("barcode1") = Trim(dr4("barcode1").ToString)
            dr4("barcode2") = Trim(dr4("barcode2").ToString)
            dr4("barcode3") = Trim(dr4("barcode3").ToString)
            dr4("barcode4") = Trim(dr4("barcode4").ToString)
            dr4("barcode5") = Trim(dr4("barcode5").ToString)
            dr4("barcode6") = Trim(dr4("barcode6").ToString)
            dr4("barcode7") = Trim(dr4("barcode7").ToString)
            dr4("barcode8") = Trim(dr4("barcode8").ToString)
            dr4("barcode9") = Trim(dr4("barcode9").ToString)
            dr4("barcode10") = Trim(dr4("barcode10").ToString)
            dr4("barcode11") = Trim(dr4("barcode11").ToString)
            dr4("barcode12") = Trim(dr4("barcode12").ToString)
            dr4("barcode13") = Trim(dr4("barcode13").ToString)
            dr4("barcode14") = Trim(dr4("barcode14").ToString)
            dr4("barcode15") = Trim(dr4("barcode15").ToString)
            dr4("barcode16") = Trim(dr4("barcode16").ToString)
            dr4("barcode17") = Trim(dr4("barcode17").ToString)
            dr4("barcode18") = Trim(dr4("barcode18").ToString)
            dr4("barcode19") = Trim(dr4("barcode19").ToString)
            dr4("barcode20") = Trim(dr4("barcode20").ToString)
            dr4("barcode21") = Trim(dr4("barcode21").ToString)
            dr4("barcode22") = Trim(dr4("barcode22").ToString)
            dr4("barcode23") = Trim(dr4("barcode23").ToString)
            dr4("barcode24") = Trim(dr4("barcode24").ToString)
            dr4("barcode25") = Trim(dr4("barcode25").ToString)
            dr4("barcode26") = Trim(dr4("barcode26").ToString)
            dr4("barcode27") = Trim(dr4("barcode27").ToString)
            dr4("barcode28") = Trim(dr4("barcode28").ToString)
            dr4("barcode29") = Trim(dr4("barcode29").ToString)
            dr4("barcode30") = Trim(dr4("barcode30").ToString)
            dr4("barcode31") = Trim(dr4("barcode31").ToString)
            dr4("barcode32") = Trim(dr4("barcode32").ToString)
            dr4("barcode33") = Trim(dr4("barcode33").ToString)
            dr4("barcode34") = Trim(dr4("barcode34").ToString)
            dr4("barcode35") = Trim(dr4("barcode35").ToString)
            dr4("barcode36") = Trim(dr4("barcode36").ToString)
            dr4("barcode37") = Trim(dr4("barcode37").ToString)
            dr4("barcode38") = Trim(dr4("barcode38").ToString)
            dr4("barcode39") = Trim(dr4("barcode39").ToString)
            dr4("barcode40") = Trim(dr4("barcode40").ToString)
            dr4("barcode41") = Trim(dr4("barcode41").ToString)
            dr4("barcode42") = Trim(dr4("barcode42").ToString)
            dr4("barcode43") = Trim(dr4("barcode43").ToString)
            dr4("barcode44") = Trim(dr4("barcode44").ToString)
            dr4("barcode45") = Trim(dr4("barcode45").ToString)
            dr4("barcode46") = Trim(dr4("barcode46").ToString)
            dr4("barcode47") = Trim(dr4("barcode47").ToString)
            dr4("barcode48") = Trim(dr4("barcode48").ToString)
            dr4("barcode49") = Trim(dr4("barcode49").ToString)
            dr4("barcode50") = Trim(dr4("barcode50").ToString)
            dr4("barcode51") = Trim(dr4("barcode51").ToString)
            dr4("barcode52") = Trim(dr4("barcode52").ToString)
            dr4("barcode53") = Trim(dr4("barcode53").ToString)
            dr4("barcode54") = Trim(dr4("barcode54").ToString)
            dr4("barcode55") = Trim(dr4("barcode55").ToString)
            dr4("barcode56") = Trim(dr4("barcode56").ToString)
            dr4("barcode57") = Trim(dr4("barcode57").ToString)
            dr4("barcode58") = Trim(dr4("barcode58").ToString)
            dr4("barcode59") = Trim(dr4("barcode59").ToString)
            dr4("barcode60") = Trim(dr4("barcode60").ToString)
        Next
        Dim adapter1 As New OleDb.OleDbDataAdapter
        Dim cmd6 As New OleDb.OleDbCommand
        Dim con6 As New OleDb.OleDbConnection
        Dim dr5 As DataRow
        Dim DS5 As New DataSet

        con6.ConnectionString = connection
        con6.Open()
        cmd6.CommandText = "select nStokID, code, name, ISNULL(Renk1,0)as Renk1, ISNULL(Beden1,0) as Beden1,  ISNULL(barcode1,0) as barcode1,  ISNULL(Fiyat1,0) as Fiyat1,  ISNULL(quantity1,0) as quantity1,  ISNULL(Renk2,0) as Renk2,  ISNULL(Beden2,0) as Beden2,  ISNULL(barcode2,0) as barcode2,  ISNULL(Fiyat2,0) as Fiyat2,  ISNULL(quantity2,0) as quantity2,  ISNULL(Renk3,0) as Renk3,  ISNULL(Beden3,0) as Beden3,  ISNULL(barcode3,0) as barcode3,  ISNULL(Fiyat3,0) as Fiyat3,  ISNULL(quantity3,0) as quantity3,  ISNULL(Renk4,0) as Renk4,  ISNULL(Beden4,0) as Beden4,  ISNULL(barcode4,0) as barcode4,  ISNULL(Fiyat4,0) as Fiyat4,  ISNULL(quantity4,0) as quantity4,  ISNULL(Renk5,0) as Renk5, ISNULL(Beden5,0) as Beden5, ISNULL(barcode5,0) as barcode5, ISNULL(quantity5,0) as quantity5, ISNULL(Fiyat5,0) as Fiyat5, ISNULL(Renk6,0) as Renk6, ISNULL(Beden6,0) as Beden6, ISNULL(barcode6,0) as barcode6, ISNULL(Fiyat6,0) as Fiyat6, ISNULL(quantity6,0) as quantity6, ISNULL(Renk7,0) as Renk7, ISNULL(Beden7,0) as Beden7, ISNULL(barcode7,0) as barcode7, ISNULL(Fiyat7,0) as Fiyat7, ISNULL(quantity7,0) as quantity7, ISNULL(Renk8,0) as Renk8, ISNULL(Beden8,0) as Beden8, ISNULL(barcode8,0) as barcode8, ISNULL(Fiyat8,0) as Fiyat8, ISNULL(quantity8,0) as quantity8, ISNULL(Renk9,0) as Renk9, ISNULL(Beden9,0) as Beden9, ISNULL(barcode9,0) as barcode9, ISNULL(Fiyat9,0) as Fiyat9, ISNULL(quantity9,0) as quantity9, ISNULL(Renk10,0) as Renk10, ISNULL(Beden10,0) as Beden10, ISNULL(barcode10,0) as barcode10, ISNULL(Fiyat10,0) as Fiyat10, ISNULL(quantity10,0) as quantity10, ISNULL(Renk11,0) as Renk11, ISNULL(Beden11,0) as Beden11, ISNULL(barcode11,0) as barcode11, ISNULL(Fiyat11,0) as Fiyat11, ISNULL(quantity11,0) as quantity11, ISNULL(Renk12,0) as Renk12, ISNULL(Beden12,0) as Beden12, ISNULL(barcode12,0) as barcode12, ISNULL(Fiyat12,0) as Fiyat12, ISNULL(quantity12,0) as quantity12, ISNULL(Renk13,0) as Renk13, ISNULL(Beden13,0) as Beden13, ISNULL(barcode13,0) as barcode13, ISNULL(Fiyat13,0) as Fiyat13, ISNULL(quantity13,0) as quantity13, ISNULL(Renk14,0) as Renk14, ISNULL(Beden14,0) as Beden14, ISNULL(barcode14,0) as barcode14, ISNULL(Fiyat14,0) as Fiyat14, ISNULL(quantity14,0) as quantity14, ISNULL(Renk15,0) as Renk15, ISNULL(Beden15,0) as Beden15, ISNULL(barcode15,0) as barcode15, ISNULL(Fiyat15,0) as Fiyat15, ISNULL(quantity15,0) as quantity15, ISNULL(Renk16,0) as Renk16, ISNULL(Beden16,0) as Beden16, ISNULL(barcode16,0) as barcode16, ISNULL(Fiyat16,0) as Fiyat16, ISNULL(quantity16,0) as quantity16, ISNULL(Renk17,0) as Renk17, ISNULL(Beden17,0) as Beden17, ISNULL(barcode17,0) as barcode17, ISNULL(Fiyat17,0) as Fiyat17, ISNULL(quantity17,0) as quantity17, ISNULL(Renk18,0) as Renk18, ISNULL(Beden18,0) as Beden18, ISNULL(barcode18,0) as barcode18, ISNULL(Fiyat18,0) as Fiyat18, ISNULL(quantity18,0) as quantity18, ISNULL(Renk19,0) as Renk19, ISNULL(Beden19,0) as Beden19, ISNULL(barcode19,0) as barcode19, ISNULL(Fiyat19,0) as Fiyat19, ISNULL(quantity19,0) as quantity19, ISNULL(Renk20,0) as Renk20, ISNULL(Beden20,0) as Beden20, ISNULL(barcode20,0) as barcode20, ISNULL(Fiyat20,0) as Fiyat20, ISNULL(quantity20,0) as quantity20, ISNULL(Renk21,0) as Renk21, ISNULL(Beden21,0) as Beden21, ISNULL(barcode21,0) as barcode21, ISNULL(Fiyat21,0) as Fiyat21, ISNULL(quantity21,0) as quantity21, ISNULL(Renk22,0) as Renk22, ISNULL(Beden22,0) as Beden22, ISNULL(barcode22,0) as barcode22, ISNULL(Fiyat22,0) as Fiyat22, ISNULL(quantity22,0) as quantity22, ISNULL(Renk23,0) as Renk23, ISNULL(Beden23,0) as Beden23, ISNULL(barcode23,0) as barcode23, ISNULL(Fiyat23,0) as Fiyat23, ISNULL(quantity23,0) as quantity23, ISNULL(Renk24,0) as Renk24, ISNULL(Beden24,0) as Beden24, ISNULL(barcode24,0) as barcode24, ISNULL(Fiyat24,0) as Fiyat24, ISNULL(quantity24,0) as quantity24, ISNULL(Renk25,0) as Renk25, ISNULL(Beden25,0) as Beden25, ISNULL(barcode25,0) as barcode25, ISNULL(Fiyat25,0) as Fiyat25, ISNULL(quantity25,0) as quantity25, ISNULL(Renk26,0) as Renk26, ISNULL(Beden26,0) as Beden26, ISNULL(barcode26,0) as barcode26, ISNULL(Fiyat26,0) as Fiyat26, ISNULL(quantity26,0) as quantity26, ISNULL(Renk27,0) as Renk27, ISNULL(Beden27,0) as Beden27, ISNULL(barcode27,0) as barcode27, ISNULL(Fiyat27,0) as Fiyat27, ISNULL(quantity27,0) as quantity27, ISNULL(Renk28,0) as Renk28, ISNULL(Beden28,0) as Beden28, ISNULL(barcode28,0) as barcode28, ISNULL(Fiyat28,0) as Fiyat28, ISNULL(quantity28,0) as quantity28, ISNULL(Renk29,0) as Renk29, ISNULL(Beden29,0) as Beden29, ISNULL(barcode29,0) as barcode29, ISNULL(Fiyat29,0) as Fiyat29, ISNULL(quantity29,0) as quantity29, ISNULL(Renk30,0) as Renk30, ISNULL(Beden30,0) as Beden30, ISNULL(barcode30,0) as barcode30, ISNULL(Fiyat30,0) as Fiyat30, ISNULL(quantity30,0) as quantity30, ISNULL(Renk31,0) as Renk31, ISNULL(Beden31,0) as Beden31, ISNULL(barcode31,0) as barcode31, ISNULL(Fiyat31,0) as Fiyat31, ISNULL(quantity31,0) as quantity31, ISNULL(Renk32,0) as Renk32, ISNULL(Beden32,0) as Beden32, ISNULL(barcode32,0) as barcode32, ISNULL(Fiyat32,0) as Fiyat32, ISNULL(quantity32,0) as quantity32, ISNULL(Renk33,0) as Renk33, ISNULL(Beden33,0) as Beden33, ISNULL(barcode33,0) as barcode33, ISNULL(Fiyat33,0) as Fiyat33, ISNULL(quantity33,0) as quantity33, ISNULL(Renk34,0) as Renk34, ISNULL(Beden34,0) as Beden34, ISNULL(barcode34,0) as barcode34, ISNULL(Fiyat34,0) as Fiyat34, ISNULL(quantity34,0) as quantity34, ISNULL(Renk35,0) as Renk35, ISNULL(Beden35,0) as Beden35, ISNULL(barcode35,0) as barcode35, ISNULL(Fiyat35,0) as Fiyat35, ISNULL(quantity35,0) as quantity35, ISNULL(Renk36,0) as Renk36, ISNULL(Beden36,0) as Beden36, ISNULL(barcode36,0) as barcode36, ISNULL(Fiyat36,0) as Fiyat36, ISNULL(quantity36,0) as quantity36, ISNULL(Renk37,0) as Renk37, ISNULL(Beden37,0) as Beden37, ISNULL(barcode37,0) as barcode37, ISNULL(Fiyat37,0) as Fiyat37, ISNULL(quantity37,0) as quantity37, ISNULL(Renk38,0) as Renk38, ISNULL(Beden38,0) as Beden38, ISNULL(barcode38,0) as barcode38, ISNULL(Fiyat38,0) as Fiyat38, ISNULL(quantity38,0) as quantity38, ISNULL(Renk39,0) as Renk39, ISNULL(Beden39,0) as Beden39, ISNULL(barcode39,0) as barcode39, ISNULL(Fiyat39,0) as Fiyat39, ISNULL(quantity39,0) as quantity39, ISNULL(Renk40,0) as Renk40, ISNULL(Beden40,0) as Beden40, ISNULL(barcode40,0) as barcode40, ISNULL(Fiyat40,0) as Fiyat40, ISNULL(quantity40,0) as quantity40, ISNULL(Renk41,0) as Renk41, ISNULL(Beden41,0) as Beden41, ISNULL(barcode41,0) as barcode41, ISNULL(Fiyat41,0) as Fiyat41, ISNULL(quantity41,0) as quantity41, ISNULL(Renk42,0) as Renk42, ISNULL(Beden42,0) as Beden42, ISNULL(barcode42,0) as barcode42, ISNULL(Fiyat42,0) as Fiyat42, ISNULL(quantity42,0) as quantity42, ISNULL(Renk43,0) as Renk43, ISNULL(Beden43,0) as Beden43, ISNULL(barcode43,0) as barcode43, ISNULL(Fiyat43,0) as Fiyat43, ISNULL(quantity43,0) as quantity43, ISNULL(Renk44,0) as Renk44, ISNULL(Beden44,0) as Beden44, ISNULL(barcode44,0) as barcode44, ISNULL(Fiyat44,0) as Fiyat44, ISNULL(quantity44,0) as quantity44, ISNULL(Renk45,0) as Renk45, ISNULL(Beden45,0) as Beden45, ISNULL(barcode45,0) as barcode45, ISNULL(Fiyat45,0) as Fiyat45, ISNULL(quantity45,0) as quantity45, ISNULL(Renk46,0) as Renk46, ISNULL(Beden46,0) as Beden46, ISNULL(barcode46,0) as barcode46, ISNULL(Fiyat46,0) as Fiyat46, ISNULL(quantity46,0) as quantity46, ISNULL(Renk47,0) as Renk47, ISNULL(Beden47,0) as Beden47, ISNULL(barcode47,0) as barcode47, ISNULL(Fiyat47,0) as Fiyat47, ISNULL(quantity47,0) as quantity47, ISNULL(Renk48,0) as Renk48, ISNULL(Beden48,0) as Beden48, ISNULL(barcode48,0) as barcode48, ISNULL(Fiyat48,0) as Fiyat48, ISNULL(quantity48,0) as quantity48, ISNULL(Renk49,0) as Renk49, ISNULL(Beden49,0) as Beden49, ISNULL(barcode49,0) as barcode49, ISNULL(Fiyat49,0) as Fiyat49, ISNULL(quantity49,0) as quantity49, ISNULL(Renk50,0) as Renk50, ISNULL(Beden50,0) as Beden50, ISNULL(barcode50,0) as barcode50, ISNULL(Fiyat50,0) as Fiyat50, ISNULL(quantity50,0) as quantity50, ISNULL(Renk51,0) as Renk51, ISNULL(Beden51,0) as Beden51, ISNULL(barcode51,0) as barcode51, ISNULL(Fiyat51,0) as Fiyat51, ISNULL(quantity51,0) as quantity51, ISNULL(Renk52,0) as Renk52, ISNULL(Beden52,0) as Beden52, ISNULL(barcode52,0) as barcode52, ISNULL(Fiyat52,0) as Fiyat52, ISNULL(quantity52,0) as quantity52, ISNULL(Renk53,0) as Renk53, ISNULL(Beden53,0) as Beden53, ISNULL(barcode53,0) as barcode53, ISNULL(Fiyat53,0) as Fiyat53, ISNULL(quantity53,0) as quantity53, ISNULL(Renk54,0) as Renk54, ISNULL(Beden54,0) as Beden54, ISNULL(barcode54,0) as barcode54, ISNULL(Fiyat54,0) as Fiyat54, ISNULL(quantity54,0) as quantity54, ISNULL(Renk55,0) as Renk55, ISNULL(Beden55,0) as Beden55, ISNULL(barcode55,0) as barcode55, ISNULL(Fiyat55,0) as Fiyat55, ISNULL(quantity55,0) as quantity55, ISNULL(Renk56,0) as Renk56, ISNULL(Beden56,0) as Beden56, ISNULL(barcode56,0) as barcode56, ISNULL(Fiyat56,0) as Fiyat56, ISNULL(quantity56,0) as quantity56, ISNULL(Renk57,0) as Renk57, ISNULL(Beden57,0) as Beden57, ISNULL(barcode57,0) as barcode57, ISNULL(Fiyat57,0) as Fiyat57, ISNULL(quantity57,0) as quantity57, ISNULL(Renk58,0) as Renk58, ISNULL(Beden58,0) as Beden58, ISNULL(barcode58,0) as barcode58, ISNULL(Fiyat58,0) as Fiyat58, ISNULL(quantity58,0) as quantity58, ISNULL(Renk59,0) as Renk59, ISNULL(Beden59,0) as Beden59, ISNULL(barcode59,0) as barcode59, ISNULL(Fiyat59,0) as Fiyat59, ISNULL(quantity59,0) as quantity59, ISNULL(Renk60,0) as Renk60, ISNULL(Beden60,0) as Beden60, ISNULL(barcode60,0) as barcode60, ISNULL(Fiyat60,0) as Fiyat60, ISNULL(quantity60,0) as quantity60, ISNULL(brand,0) as brand, ISNULL(category1,0) as category1, ISNULL(category2,0) as category2, ISNULL(category3,0) as category3, ISNULL(category4,0) as category4, ISNULL(category5,0) as category5,ISNULL(longDescription,0) as longDescription, ISNULL(seoTitle,0) as seoTitle, ISNULL(seoKeywords,0) as seoKeywords, ISNULL(seoDescription,0) as seoDescription, ISNULL(variant1Name,0) as variant1Name, ISNULL(variant2Name,0) as variant2Name, ISNULL(taxRate,0) as taxRate, ISNULL(shipmentPayment,0) as shipmentPayment, ISNULL(buyPrice,0) as buyPrice, ISNULL(listPrice,0) as listPrice, ISNULL(salePrice,0) as salePrice, ISNULL(TysalePrice,0) as TysalePrice, ISNULL(N11salePrice,0) as N11salePrice, ISNULL(GgsalePrice,0) as GgsalePrice, ISNULL(HbsalePrice,0) as HbsalePrice, ISNULL(EpttsalePrice,0) as EpttsalePrice, ISNULL(CssalePrice,0) as CssalePrice, ISNULL(amzsalePrice,0) as amzsalePrice, ISNULL(NewsalePrice,0) as NewsalePrice, ISNULL(quantity,0) as quantity, ISNULL(imageUrl,0) as imageUrl, ISNULL(imageUrl1,0) as imageUrl1, ISNULL(imageUrl2,0) as imageUrl2, ISNULL(imageUrl3,0) as imageUrl3, ISNULL(imageUrl4,0) as imageUrl4, ISNULL(imageUrl5,0) as imageUrl5, ISNULL(imageUrl6,0) as imageUrl6, ISNULL(imageUrl7,0) as imageUrl7, ISNULL(imageUrl8,0) as imageUrl8, ISNULL(imageUrl9,0) as imageUrl9, ISNULL(imageUrl10,0) as imageUrl10, ISNULL(dteGuncelZaman,0) as dteGuncelZaman from tbStokEticaret Where Guncel = '0'"
        cmd6.Connection = con6
        adapter1.SelectCommand = cmd6
        Dim Z As Integer = adapter1.Fill(DS5, "Table1")

        For Each dr5 In DS5.Tables(0).Rows
            dr5("quantity1") = Trim(dr5("quantity1").ToString)
            dr5("quantity2") = Trim(dr5("quantity2").ToString)
            dr5("quantity3") = Trim(dr5("quantity3").ToString)
            dr5("quantity4") = Trim(dr5("quantity4").ToString)
            dr5("quantity5") = Trim(dr5("quantity5").ToString)
            dr5("quantity6") = Trim(dr5("quantity6").ToString)
            dr5("quantity7") = Trim(dr5("quantity7").ToString)
            dr5("quantity8") = Trim(dr5("quantity8").ToString)
            dr5("quantity9") = Trim(dr5("quantity9").ToString)
            dr5("quantity10") = Trim(dr5("quantity10").ToString)
            dr5("quantity11") = Trim(dr5("quantity11").ToString)
            dr5("quantity12") = Trim(dr5("quantity12").ToString)
            dr5("quantity13") = Trim(dr5("quantity13").ToString)
            dr5("quantity14") = Trim(dr5("quantity14").ToString)
            dr5("quantity15") = Trim(dr5("quantity15").ToString)
            dr5("quantity16") = Trim(dr5("quantity16").ToString)
            dr5("quantity17") = Trim(dr5("quantity17").ToString)
            dr5("quantity18") = Trim(dr5("quantity18").ToString)
            dr5("quantity19") = Trim(dr5("quantity19").ToString)
            dr5("quantity20") = Trim(dr5("quantity20").ToString)
            dr5("quantity21") = Trim(dr5("quantity21").ToString)
            dr5("quantity22") = Trim(dr5("quantity22").ToString)
            dr5("quantity23") = Trim(dr5("quantity23").ToString)
            dr5("quantity24") = Trim(dr5("quantity24").ToString)
            dr5("quantity25") = Trim(dr5("quantity25").ToString)
            dr5("quantity26") = Trim(dr5("quantity26").ToString)
            dr5("quantity27") = Trim(dr5("quantity27").ToString)
            dr5("quantity28") = Trim(dr5("quantity28").ToString)
            dr5("quantity29") = Trim(dr5("quantity29").ToString)
            dr5("quantity30") = Trim(dr5("quantity30").ToString)
            dr5("quantity31") = Trim(dr5("quantity31").ToString)
            dr5("quantity32") = Trim(dr5("quantity32").ToString)
            dr5("quantity33") = Trim(dr5("quantity33").ToString)
            dr5("quantity34") = Trim(dr5("quantity34").ToString)
            dr5("quantity35") = Trim(dr5("quantity35").ToString)
            dr5("quantity36") = Trim(dr5("quantity36").ToString)
            dr5("quantity37") = Trim(dr5("quantity37").ToString)
            dr5("quantity38") = Trim(dr5("quantity38").ToString)
            dr5("quantity39") = Trim(dr5("quantity39").ToString)
            dr5("quantity40") = Trim(dr5("quantity40").ToString)
            dr5("quantity41") = Trim(dr5("quantity41").ToString)
            dr5("quantity42") = Trim(dr5("quantity42").ToString)
            dr5("quantity43") = Trim(dr5("quantity43").ToString)
            dr5("quantity44") = Trim(dr5("quantity44").ToString)
            dr5("quantity45") = Trim(dr5("quantity45").ToString)
            dr5("quantity46") = Trim(dr5("quantity46").ToString)
            dr5("quantity47") = Trim(dr5("quantity47").ToString)
            dr5("quantity48") = Trim(dr5("quantity48").ToString)
            dr5("quantity49") = Trim(dr5("quantity49").ToString)
            dr5("quantity50") = Trim(dr5("quantity50").ToString)
            dr5("quantity51") = Trim(dr5("quantity51").ToString)
            dr5("quantity52") = Trim(dr5("quantity52").ToString)
            dr5("quantity53") = Trim(dr5("quantity53").ToString)
            dr5("quantity54") = Trim(dr5("quantity54").ToString)
            dr5("quantity55") = Trim(dr5("quantity55").ToString)
            dr5("quantity56") = Trim(dr5("quantity56").ToString)
            dr5("quantity57") = Trim(dr5("quantity57").ToString)
            dr5("quantity58") = Trim(dr5("quantity58").ToString)
            dr5("quantity59") = Trim(dr5("quantity59").ToString)
            dr5("quantity60") = Trim(dr5("quantity60").ToString)
            dr5("brand") = Trim(dr5("brand").ToString)

            If con1.State = ConnectionState.Closed Then
                con1.ConnectionString = connection
                cmd1.Connection = con1
                con1.Open()
            End If

            cmd1.CommandText = sorgu_queryJson("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT TOP 1 Product FROM tbParamGenel")
            ProductUpdate = cmd1.ExecuteScalar.ToString()
            con1.Close()
            ProductUpdate += "/product/updateStocks"
            If con1.State = ConnectionState.Closed Then
                con1.ConnectionString = connection
                cmd1.Connection = con1
                con1.Open()
            End If
            cmd1.CommandText = sorgu_queryJson("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT TOP 1 ApiKey FROM tbParamGenel")
            ApiKey = cmd1.ExecuteScalar.ToString()
            con1.Close()
            If con1.State = ConnectionState.Closed Then
                con1.ConnectionString = connection
                cmd1.Connection = con1
                con1.Open()
            End If
            cmd1.CommandText = sorgu_queryJson("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT TOP 1 ApiSecret FROM tbParamGenel")
            ApiSecret = cmd1.ExecuteScalar.ToString()
            con1.Close()

            'Dim Mydata As String = " {""stocks"": [{""code"": """ & dr5("code") & """,""variants"": [{""value1"": """ & dr5("Renk1") & """,""value2"": """ & dr5("Beden1") & """,""barcode"": """ & dr5("barcode1") & """,""quantity"": """ & dr5("quantity1") & """},{""value1"": """ & dr5("Renk2") & """,""value2"": """ & dr5("Beden2") & """,""barcode"": """ & dr5("barcode2") & """,""quantity"": """ & dr5("quantity2") & """},{""value1"": """ & dr5("Renk3") & """,""value2"": """ & dr5("Beden3") & """,""barcode"": """ & dr5("barcode3") & """,""quantity"": """ & dr5("quantity3") & """},{""value1"": """ & dr5("Renk4") & """,""value2"": """ & dr5("Beden4") & """,""barcode"": """ & dr5("barcode4") & """,""quantity"": """ & dr5("quantity4") & """},{""value1"": """ & dr5("Renk5") & """,""value2"": """ & dr5("Beden5") & """,""barcode"": """ & dr5("barcode5") & """,""quantity"": """ & dr5("quantity5") & """},{""value1"": """ & dr5("Renk6") & """,""value2"": """ & dr5("Beden6") & """,""barcode"": """ & dr5("barcode6") & """,""quantity"": """ & dr5("quantity6") & """},{""value1"": """ & dr5("Renk7") & """,""value2"": """ & dr5("Beden7") & """,""barcode"": """ & dr5("barcode7") & """,""quantity"": """ & dr5("quantity7") & """},{""value1"": """ & dr5("Renk8") & """,""value2"": """ & dr5("Beden8") & """,""barcode"": """ & dr5("barcode8") & """,""quantity"": """ & dr5("quantity8") & """},{""value1"": """ & dr5("Renk9") & """,""value2"": """ & dr5("Beden9") & """,""barcode"": """ & dr5("barcode9") & """,""quantity"": """ & dr5("quantity9") & """},{""value1"": """ & dr5("Renk10") & """,""value2"": """ & dr5("Beden10") & """,""barcode"": """ & dr5("barcode10") & """,""quantity"": """ & dr5("quantity10") & """},{""value1"": """ & dr5("Renk11") & """,""value2"": """ & dr5("Beden11") & """,""barcode"": """ & dr5("barcode11") & """,""quantity"": """ & dr5("quantity11") & """},{""value1"": """ & dr5("Renk12") & """,""value2"": """ & dr5("Beden12") & """,""barcode"": """ & dr5("barcode12") & """,""quantity"": """ & dr5("quantity12") & """},{""value1"": """ & dr5("Renk13") & """,""value2"": """ & dr5("Beden13") & """,""barcode"": """ & dr5("barcode13") & """,""quantity"": """ & dr5("quantity13") & """},{""value1"": """ & dr5("Renk14") & """,""value2"": """ & dr5("Beden14") & """,""barcode"": """ & dr5("barcode14") & """,""quantity"": """ & dr5("quantity14") & """},{""value1"": """ & dr5("Renk15") & """,""value2"": """ & dr5("Beden15") & """,""barcode"": """ & dr5("barcode15") & """,""quantity"": """ & dr5("quantity15") & """},{""value1"": """ & dr5("Renk16") & """,""value2"": """ & dr5("Beden16") & """,""barcode"": """ & dr5("barcode16") & """,""quantity"": """ & dr5("quantity16") & """},{""value1"": """ & dr5("Renk17") & """,""value2"": """ & dr5("Beden17") & """,""barcode"": """ & dr5("barcode17") & """,""quantity"": """ & dr5("quantity17") & """},{""value1"": """ & dr5("Renk18") & """,""value2"": """ & dr5("Beden18") & """,""barcode"": """ & dr5("barcode18") & """,""quantity"": """ & dr5("quantity18") & """},{""value1"": """ & dr5("Renk19") & """,""value2"": """ & dr5("Beden19") & """,""barcode"": """ & dr5("barcode19") & """,""quantity"": """ & dr5("quantity19") & """},{""value1"": """ & dr5("Renk20") & """,""value2"": """ & dr5("Beden20") & """,""barcode"": """ & dr5("barcode20") & """,""quantity"": """ & dr5("quantity20") & """}]}]}"
            Dim Mydata As String = " {""stocks"": [{""code"": """ & dr5("code") & """,""variants"": [{""value1"": """ & dr5("Renk1") & """,""value2"": """ & dr5("Beden1") & """,""barcode"": """ & dr5("barcode1") & """,""quantity"": """ & dr5("quantity1") & """},{""value1"": """ & dr5("Renk2") & """,""value2"": """ & dr5("Beden2") & """,""barcode"": """ & dr5("barcode2") & """,""quantity"": """ & dr5("quantity2") & """},{""value1"": """ & dr5("Renk3") & """,""value2"": """ & dr5("Beden3") & """,""barcode"": """ & dr5("barcode3") & """,""quantity"": """ & dr5("quantity3") & """},{""value1"": """ & dr5("Renk4") & """,""value2"": """ & dr5("Beden4") & """,""barcode"": """ & dr5("barcode4") & """,""quantity"": """ & dr5("quantity4") & """},{""value1"": """ & dr5("Renk5") & """,""value2"": """ & dr5("Beden5") & """,""barcode"": """ & dr5("barcode5") & """,""quantity"": """ & dr5("quantity5") & """},{""value1"": """ & dr5("Renk6") & """,""value2"": """ & dr5("Beden6") & """,""barcode"": """ & dr5("barcode6") & """,""quantity"": """ & dr5("quantity6") & """},{""value1"": """ & dr5("Renk7") & """,""value2"": """ & dr5("Beden7") & """,""barcode"": """ & dr5("barcode7") & """,""quantity"": """ & dr5("quantity7") & """},{""value1"": """ & dr5("Renk8") & """,""value2"": """ & dr5("Beden8") & """,""barcode"": """ & dr5("barcode8") & """,""quantity"": """ & dr5("quantity8") & """},{""value1"": """ & dr5("Renk9") & """,""value2"": """ & dr5("Beden9") & """,""barcode"": """ & dr5("barcode9") & """,""quantity"": """ & dr5("quantity9") & """},{""value1"": """ & dr5("Renk10") & """,""value2"": """ & dr5("Beden10") & """,""barcode"": """ & dr5("barcode10") & """,""quantity"": """ & dr5("quantity10") & """},{""value1"": """ & dr5("Renk11") & """,""value2"": """ & dr5("Beden11") & """,""barcode"": """ & dr5("barcode11") & """,""quantity"": """ & dr5("quantity11") & """},{""value1"": """ & dr5("Renk12") & """,""value2"": """ & dr5("Beden12") & """,""barcode"": """ & dr5("barcode12") & """,""quantity"": """ & dr5("quantity12") & """},{""value1"": """ & dr5("Renk13") & """,""value2"": """ & dr5("Beden13") & """,""barcode"": """ & dr5("barcode13") & """,""quantity"": """ & dr5("quantity13") & """},{""value1"": """ & dr5("Renk14") & """,""value2"": """ & dr5("Beden14") & """,""barcode"": """ & dr5("barcode14") & """,""quantity"": """ & dr5("quantity14") & """},{""value1"": """ & dr5("Renk15") & """,""value2"": """ & dr5("Beden15") & """,""barcode"": """ & dr5("barcode15") & """,""quantity"": """ & dr5("quantity15") & """},{""value1"": """ & dr5("Renk16") & """,""value2"": """ & dr5("Beden16") & """,""barcode"": """ & dr5("barcode16") & """,""quantity"": """ & dr5("quantity16") & """},{""value1"": """ & dr5("Renk17") & """,""value2"": """ & dr5("Beden17") & """,""barcode"": """ & dr5("barcode17") & """,""quantity"": """ & dr5("quantity17") & """},{""value1"": """ & dr5("Renk18") & """,""value2"": """ & dr5("Beden18") & """,""barcode"": """ & dr5("barcode18") & """,""quantity"": """ & dr5("quantity18") & """},{""value1"": """ & dr5("Renk19") & """,""value2"": """ & dr5("Beden19") & """,""barcode"": """ & dr5("barcode19") & """,""quantity"": """ & dr5("quantity19") & """},{""value1"": """ & dr5("Renk20") & """,""value2"": """ & dr5("Beden20") & """,""barcode"": """ & dr5("barcode20") & """,""quantity"": """ & dr5("quantity20") & """},{""value1"": """ & dr5("Renk21") & """,""value2"": """ & dr5("Beden21") & """,""barcode"": """ & dr5("barcode21") & """,""quantity"": """ & dr5("quantity21") & """},{""value1"": """ & dr5("Renk22") & """,""value2"": """ & dr5("Beden22") & """,""barcode"": """ & dr5("barcode22") & """,""quantity"": """ & dr5("quantity22") & """},{""value1"": """ & dr5("Renk23") & """,""value2"": """ & dr5("Beden23") & """,""barcode"": """ & dr5("barcode23") & """,""quantity"": """ & dr5("quantity23") & """},{""value1"": """ & dr5("Renk24") & """,""value2"": """ & dr5("Beden24") & """,""barcode"": """ & dr5("barcode24") & """,""quantity"": """ & dr5("quantity24") & """},{""value1"": """ & dr5("Renk25") & """,""value2"": """ & dr5("Beden25") & """,""barcode"": """ & dr5("barcode25") & """,""quantity"": """ & dr5("quantity25") & """},{""value1"": """ & dr5("Renk26") & """,""value2"": """ & dr5("Beden26") & """,""barcode"": """ & dr5("barcode26") & """,""quantity"": """ & dr5("quantity26") & """},{""value1"": """ & dr5("Renk27") & """,""value2"": """ & dr5("Beden27") & """,""barcode"": """ & dr5("barcode27") & """,""quantity"": """ & dr5("quantity27") & """},{""value1"": """ & dr5("Renk28") & """,""value2"": """ & dr5("Beden28") & """,""barcode"": """ & dr5("barcode28") & """,""quantity"": """ & dr5("quantity28") & """},{""value1"": """ & dr5("Renk29") & """,""value2"": """ & dr5("Beden29") & """,""barcode"": """ & dr5("barcode29") & """,""quantity"": """ & dr5("quantity29") & """},{""value1"": """ & dr5("Renk30") & """,""value2"": """ & dr5("Beden30") & """,""barcode"": """ & dr5("barcode30") & """,""quantity"": """ & dr5("quantity30") & """},{""value1"": """ & dr5("Renk31") & """,""value2"": """ & dr5("Beden31") & """,""barcode"": """ & dr5("barcode31") & """,""quantity"": """ & dr5("quantity31") & """},{""value1"": """ & dr5("Renk32") & """,""value2"": """ & dr5("Beden32") & """,""barcode"": """ & dr5("barcode32") & """,""quantity"": """ & dr5("quantity32") & """},{""value1"": """ & dr5("Renk33") & """,""value2"": """ & dr5("Beden33") & """,""barcode"": """ & dr5("barcode33") & """,""quantity"": """ & dr5("quantity33") & """},{""value1"": """ & dr5("Renk34") & """,""value2"": """ & dr5("Beden34") & """,""barcode"": """ & dr5("barcode34") & """,""quantity"": """ & dr5("quantity34") & """},{""value1"": """ & dr5("Renk35") & """,""value2"": """ & dr5("Beden35") & """,""barcode"": """ & dr5("barcode35") & """,""quantity"": """ & dr5("quantity35") & """},{""value1"": """ & dr5("Renk36") & """,""value2"": """ & dr5("Beden36") & """,""barcode"": """ & dr5("barcode36") & """,""quantity"": """ & dr5("quantity36") & """},{""value1"": """ & dr5("Renk37") & """,""value2"": """ & dr5("Beden37") & """,""barcode"": """ & dr5("barcode37") & """,""quantity"": """ & dr5("quantity37") & """},{""value1"": """ & dr5("Renk38") & """,""value2"": """ & dr5("Beden38") & """,""barcode"": """ & dr5("barcode38") & """,""quantity"": """ & dr5("quantity38") & """},{""value1"": """ & dr5("Renk39") & """,""value2"": """ & dr5("Beden39") & """,""barcode"": """ & dr5("barcode39") & """,""quantity"": """ & dr5("quantity39") & """},{""value1"": """ & dr5("Renk40") & """,""value2"": """ & dr5("Beden40") & """,""barcode"": """ & dr5("barcode40") & """,""quantity"": """ & dr5("quantity40") & """},{""value1"": """ & dr5("Renk41") & """,""value2"": """ & dr5("Beden41") & """,""barcode"": """ & dr5("barcode41") & """,""quantity"": """ & dr5("quantity41") & """},{""value1"": """ & dr5("Renk42") & """,""value2"": """ & dr5("Beden42") & """,""barcode"": """ & dr5("barcode42") & """,""quantity"": """ & dr5("quantity42") & """},{""value1"": """ & dr5("Renk43") & """,""value2"": """ & dr5("Beden43") & """,""barcode"": """ & dr5("barcode43") & """,""quantity"": """ & dr5("quantity43") & """},{""value1"": """ & dr5("Renk44") & """,""value2"": """ & dr5("Beden44") & """,""barcode"": """ & dr5("barcode44") & """,""quantity"": """ & dr5("quantity44") & """},{""value1"": """ & dr5("Renk45") & """,""value2"": """ & dr5("Beden45") & """,""barcode"": """ & dr5("barcode45") & """,""quantity"": """ & dr5("quantity45") & """},{""value1"": """ & dr5("Renk46") & """,""value2"": """ & dr5("Beden46") & """,""barcode"": """ & dr5("barcode46") & """,""quantity"": """ & dr5("quantity46") & """},{""value1"": """ & dr5("Renk47") & """,""value2"": """ & dr5("Beden47") & """,""barcode"": """ & dr5("barcode47") & """,""quantity"": """ & dr5("quantity47") & """},{""value1"": """ & dr5("Renk48") & """,""value2"": """ & dr5("Beden48") & """,""barcode"": """ & dr5("barcode48") & """,""quantity"": """ & dr5("quantity48") & """},{""value1"": """ & dr5("Renk49") & """,""value2"": """ & dr5("Beden49") & """,""barcode"": """ & dr5("barcode49") & """,""quantity"": """ & dr5("quantity49") & """},{""value1"": """ & dr5("Renk50") & """,""value2"": """ & dr5("Beden50") & """,""barcode"": """ & dr5("barcode50") & """,""quantity"": """ & dr5("quantity50") & """},{""value1"": """ & dr5("Renk51") & """,""value2"": """ & dr5("Beden51") & """,""barcode"": """ & dr5("barcode51") & """,""quantity"": """ & dr5("quantity51") & """},{""value1"": """ & dr5("Renk52") & """,""value2"": """ & dr5("Beden52") & """,""barcode"": """ & dr5("barcode52") & """,""quantity"": """ & dr5("quantity52") & """},{""value1"": """ & dr5("Renk53") & """,""value2"": """ & dr5("Beden53") & """,""barcode"": """ & dr5("barcode53") & """,""quantity"": """ & dr5("quantity53") & """},{""value1"": """ & dr5("Renk54") & """,""value2"": """ & dr5("Beden54") & """,""barcode"": """ & dr5("barcode54") & """,""quantity"": """ & dr5("quantity54") & """},{""value1"": """ & dr5("Renk55") & """,""value2"": """ & dr5("Beden55") & """,""barcode"": """ & dr5("barcode55") & """,""quantity"": """ & dr5("quantity55") & """},{""value1"": """ & dr5("Renk56") & """,""value2"": """ & dr5("Beden56") & """,""barcode"": """ & dr5("barcode56") & """,""quantity"": """ & dr5("quantity56") & """},{""value1"": """ & dr5("Renk57") & """,""value2"": """ & dr5("Beden57") & """,""barcode"": """ & dr5("barcode57") & """,""quantity"": """ & dr5("quantity57") & """},{""value1"": """ & dr5("Renk58") & """,""value2"": """ & dr5("Beden58") & """,""barcode"": """ & dr5("barcode58") & """,""quantity"": """ & dr5("quantity58") & """},{""value1"": """ & dr5("Renk59") & """,""value2"": """ & dr5("Beden59") & """,""barcode"": """ & dr5("barcode59") & """,""quantity"": """ & dr5("quantity59") & """},{""value1"": """ & dr5("Renk60") & """,""value2"": """ & dr5("Beden60") & """,""barcode"": """ & dr5("barcode60") & """,""quantity"": """ & dr5("quantity60") & """}]}]}"

            Dim myReq1 As HttpWebRequest
            Dim myResp1 As HttpWebResponse
            Dim myReader1 As StreamReader

            myReq1 = HttpWebRequest.Create(ProductUpdate)
            myReq1.Method = "POST"

            myReq1.ContentType = "application/json"
            myReq1.Accept = "application/json"
            myReq1.Headers.Add("apikey", "" & ApiKey & "")
            myReq1.Headers.Add("apisecret", "" & ApiSecret & "")
            Try

                Dim stream1 As Stream = myReq1.GetRequestStream()
                stream1.Write(System.Text.Encoding.UTF8.GetBytes(Mydata), 0, System.Text.Encoding.UTF8.GetBytes(Mydata).Length)
                stream1.Close()
                myResp1 = myReq1.GetResponse
                myReader1 = New System.IO.StreamReader(myResp1.GetResponseStream)
                Print(myReader1.ReadToEnd)

            Catch ex As Exception
                'MessageBox.Show("Cevap: " & ex.Message)
                ' MessageBox.Show(String.Format("Aktarým Baþarý ile Tamamlandý", ex.Message))

            End Try
            If con1.State = ConnectionState.Closed Then
                con1.ConnectionString = connection
                cmd1.Connection = con1
                con1.Open()
            End If
            cmd1.CommandText = sorgu_queryJson("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED Update tbStokEticaret Set Guncel = '1' where nStokID = " & dr4("nStokID") & "")
            cmd1.ExecuteNonQuery()
            con1.Close()
        Next
        'MessageBox.Show(String.Format("Aktarým Baþarý ile Tamamlandý"))
        '' JSON BÝTÝÞ

        ''End If
    End Sub
    Public Sub Eticaret_Senkron()
        Dim conn As New OleDb.OleDbConnection
        Dim cmd As New OleDb.OleDbCommand
        Dim adapter As New OleDb.OleDbDataAdapter
        conn.ConnectionString = connection
        cmd.CommandTimeout = False
        adapter.SelectCommand = cmd
        cmd.Connection = conn
        'conn.Open()
        Dim ProductUpdate As String = ""
        Dim lists As String = "/order/lists"
        Dim show As String = "/order/show/"
        Dim TumSiparis As String = "?status=0"
        Dim YeniSiparis As String = "?status=1"
        Dim HazirlananSiparis As String = "?status=2"
        Dim KargolananSiparis As String = "?status=3"
        Dim Ipt_Deg_IadeSiparis As String = "?status=4"
        Dim IptalEdileiSiparis As String = "?status=5"
        Dim adapter1 As New OleDb.OleDbDataAdapter
        Dim odbCmd1 As New OleDb.OleDbCommand
        Dim odbCmd2 As New OleDb.OleDbCommand
        Dim odbCon1 As New OleDb.OleDbConnection
        Dim odbCon2 As New OleDb.OleDbConnection
        Dim apikey As String = ""
        Dim apisecret As String = ""
        Dim ids As String

        If odbCon1.State = ConnectionState.Closed Then
            odbCon1.ConnectionString = connection
            odbCmd1.Connection = odbCon1
            odbCon1.Open()
        End If

        odbCmd1.CommandText = sorgu_queryJson("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT TOP 1 Product FROM tbParamGenel")
        ProductUpdate = odbCmd1.ExecuteScalar.ToString()
        odbCon1.Close()

        If odbCon1.State = ConnectionState.Closed Then
            odbCon1.ConnectionString = connection
            odbCmd1.Connection = odbCon1
            odbCon1.Open()
        End If
        odbCmd1.CommandText = sorgu_queryJson("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT TOP 1 ApiKey FROM tbParamGenel")
        apikey = odbCmd1.ExecuteScalar.ToString()
        odbCon1.Close()
        If odbCon1.State = ConnectionState.Closed Then
            odbCon1.ConnectionString = connection
            odbCmd1.Connection = odbCon1
            odbCon1.Open()
        End If
        odbCmd1.CommandText = sorgu_queryJson("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT TOP 1 ApiSecret FROM tbParamGenel")
        apisecret = odbCmd1.ExecuteScalar.ToString()
        odbCon1.Close()

        ''''''''''''''''''''
        If odbCon2.State = ConnectionState.Closed Then
            odbCon2.ConnectionString = connection
            odbCmd2.Connection = odbCon2
            odbCon2.Open()
        End If

        odbCmd2.CommandText = sorgu_queryJson("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT TOP 1 Product FROM tbParamGenel")
        ProductUpdate = odbCmd2.ExecuteScalar.ToString()
        odbCon2.Close()

        If odbCon2.State = ConnectionState.Closed Then
            odbCon2.ConnectionString = connection
            odbCmd2.Connection = odbCon2
            odbCon2.Open()
        End If
        odbCmd2.CommandText = sorgu_queryJson("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT TOP 1 ApiKey FROM tbParamGenel")
        apikey = odbCmd2.ExecuteScalar.ToString()
        odbCon2.Close()
        If odbCon2.State = ConnectionState.Closed Then
            odbCon2.ConnectionString = connection
            odbCmd2.Connection = odbCon2
            odbCon2.Open()
        End If
        odbCmd2.CommandText = sorgu_queryJson("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT TOP 1 ApiSecret FROM tbParamGenel")
        apisecret = odbCmd2.ExecuteScalar.ToString()
        odbCon2.Close()

        Dim webRequest = CType(HttpWebRequest.Create(ProductUpdate & lists & "?pageStart=0&pageSize=1000&orderBy=id&sort=desc&status=1"), HttpWebRequest)
        webRequest.Method = "GET"
        webRequest.ContentType = "application/json;charset=utf-8"
        webRequest.Accept = "application/json"
        webRequest.Headers.Add("apikey", "" & apikey & "")
        webRequest.Headers.Add("apisecret", "" & apisecret & "")
        webRequest.UserAgent = "Mozilla/5.0 (Macintosh; Intel Mac OS X 10_14_3) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/76.0.3809.132 Safari/537.36"
        webRequest.ContentLength = 0
        Dim webResponse = CType(webRequest.GetResponse(), HttpWebResponse)


        Dim reader As StreamReader = New StreamReader(CType(webResponse.GetResponseStream(), Stream))
        Dim dataOrderList As String = reader.ReadToEnd()
        Dim i1 As Integer = dataOrderList.IndexOf("[")
        Dim f As String = dataOrderList.Substring(i1 + 1, dataOrderList.IndexOf("]", i1 + 1) - i1 - 1)
        reader.Close()
        webRequest.Abort()
        Dim orderList As String = "[" & f & "]"
        Dim json As String = "{" & Chr(34) & "list" & Chr(34) & ": [" & f & "]}"
        'File.WriteAllText("C:\Users\acer\Desktop\jeysýn.json", json)
        Dim dt As DataTable = JsonConvert.DeserializeObject(Of DataTable)(orderList)
        Dim dltOrderList As String = "DELETE FROM tbESiparisliste"
        odbCmd2 = New OleDbCommand(dltOrderList, odbCon2)
        odbCon2.Open()
        odbCmd2.ExecuteScalar()
        odbCon2.Close()
        Dim rssL As JObject
        Try
            rssL = JObject.Parse(json)
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

        ' For i As Integer = 0 To dt.Rows.Count
        Dim iList As Integer = 0
        While iList <= dt.Rows.Count - 1
            Dim dtId As Integer = CStr(rssL("list")(iList)("id"))
            Dim dtCode As String = CStr(rssL("list")(iList)("code"))
            Dim dtDealerId As Integer = CStr(rssL("list")(iList)("dealerId"))
            Dim dtShipmentFirmId As Integer = CStr(rssL("list")(iList)("shipmentFirmId"))
            Dim dtStatus As Integer = CStr(rssL("list")(iList)("status"))
            Dim dtCreatedAt As String = CStr(rssL("list")(iList)("createdAt"))
            Dim dtUpdatedAt As String = CStr(rssL("list")(iList)("updatedAt"))

            Dim dta As String = "            
        insert into tbESiparisliste  
        values (" & dtId & ",'" & dtCode & "'," & dtDealerId & "," & dtShipmentFirmId & "," & dtStatus & ",'" & dtCreatedAt & "','" & dtUpdatedAt & "')

"
            odbCmd2 = New OleDbCommand(dta, odbCon2)
            odbCon2.Open()
            odbCmd2.ExecuteNonQuery()
            odbCon2.Close()
            '  i = i + 1
            iList += 1
        End While
        '   Next

        Dim id As String = "SELECT nSiparisID FROM tbESiparisliste "
        Dim odbCmd7 As New OleDb.OleDbCommand
        Dim odbCon7 As New OleDb.OleDbConnection
        If odbCon7.State = ConnectionState.Closed Then
            odbCon7.ConnectionString = connection
            odbCmd7.Connection = odbCon7
            odbCon7.Open()
        End If
        Dim Kod As String = ""
        odbCmd7.CommandText = sorgu_queryJson("SELECT lSiparisNo FROM tbESiparisliste ")
        Kod = odbCmd7.ExecuteScalar.ToString()
        odbCon7.Close()
        Dim dataR As OleDb.OleDbDataReader
        odbCmd2 = New OleDbCommand(id, odbCon2)
        odbCon2.Open()
        dataR = odbCmd2.ExecuteReader()
        Dim dltTbProduct As String = "DELETE FROM tbESiparisProducts"
        odbCmd1 = New OleDbCommand(dltTbProduct, odbCon1)
        odbCon1.Open()
        odbCmd1.ExecuteScalar()
        odbCon1.Close()
        If odbCon7.State = ConnectionState.Closed Then
            odbCon7.ConnectionString = connection
            odbCmd7.Connection = odbCon7
            odbCon7.Open()
        End If
        odbCmd7.CommandText = sorgu_queryJson("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT  COUNT (Sipariscode) FROM tbESiparisDetay where Sipariscode = '" & Kod & "' ")
        Dim SorSiparis = odbCmd7.ExecuteScalar.ToString()
        If SorSiparis = 0 Then
            While dataR.Read

                ids = dataR("nSiparisID").ToString()
                Dim index As Integer = 0



                Dim webRequest2 = CType(HttpWebRequest.Create(ProductUpdate & show & ids), HttpWebRequest)
                webRequest2.Method = "GET"
                webRequest2.ContentType = "application/json;charset=utf-8"
                webRequest2.Headers.Add("apikey", "" & apikey & "")
                webRequest2.Headers.Add("apisecret", "" & apisecret & "")
                webRequest2.UserAgent = "Mozilla/5.0 (Macintosh; Intel Mac OS X 10_14_3) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/76.0.3809.132 Safari/537.36"
                webRequest2.ContentLength = 0
                Dim webResponse2 = CType(webRequest2.GetResponse(), HttpWebResponse)
                Dim readerOrderShow As StreamReader = New StreamReader(CType(webResponse2.GetResponseStream(), Stream))
                Dim veriOrderShow As String = readerOrderShow.ReadToEnd()
                Dim dataOrderShow As String = veriOrderShow
                Dim rss As JObject = JObject.Parse(dataOrderShow)
                Dim syi As Integer = 0
                Dim productLenght As Array = rss("result")("products").ToArray()
                While syi <= productLenght.Length - 1


                    Dim titleId As String = CStr(rss("result")("order")("id"))
                    Dim titleCode As String = CStr(rss("result")("order")("code"))
                    rpl = titleCode
                    replace1()
                    titleCode = rpl
                    Dim titleStatus As String = CStr(rss("result")("order")("status"))
                    Dim titleShipmentFirmId As String = CStr(rss("result")("order")("shipmentFirmId"))
                    Dim titleShipmentFirmName As String = CStr(rss("result")("order")("shipmentFirmName"))
                    rpl = titleShipmentFirmName
                    replace1()
                    titleShipmentFirmName = rpl
                    Dim titleShipmentFirmTax As String = CStr(rss("result")("order")("shipmentFirmTax"))
                    rpl = titleShipmentFirmTax
                    replace1()
                    titleShipmentFirmTax = rpl
                    Dim titleShipmentCode As String = CStr(rss("result")("order")("shipmentCode"))
                    Dim titleShipmentCode2 As String = CStr(rss("result")("order")("shipmentCode2"))
                    Dim titleShipmentUrl As String = CStr(rss("result")("order")("shipmentUrl"))
                    rpl = titleShipmentUrl
                    replace1()
                    titleShipmentUrl = rpl
                    Dim titleShipmentStatus As String = CStr(rss("result")("order")("shipmentStatus"))
                    Dim titleShipmentDate As String = CStr(rss("result")("order")("shipmentDate"))
                    Dim titleCreatedAt As String = CStr(rss("result")("order")("createdAt"))
                    Dim titleUpdatedAt As String = CStr(rss("result")("order")("updatedAt"))
                    Dim titleEinvoiceCode As String = CStr(rss("result")("order")("einvoiceCode"))
                    If CStr(rss("result")("order")("einvoiceCode")) = Nothing Then

                    Else

                        titleEinvoiceCode = CStr(rss("result")("order")("einvoiceCode")).ToArray()

                    End If
                    Dim titlePlatform As String = CStr(rss("result")("order")("platform"))
                    Dim titlePlatformUrl As String = CStr(rss("result")("order")("platformUrl"))
                    rpl = titlePlatformUrl
                    replace1()
                    titlePlatformUrl = rpl
                    Dim titlePaymentMethod As String = CStr(rss("result")("order")("paymentMethod"))
                    Dim titleName As String = CStr(rss("result")("customer")("name"))
                    rpl = titleName
                    replace1()
                    titleName = rpl
                    Dim titleTaxBranch As String = CStr(rss("result")("customer")("taxBranch"))
                    Dim titleTaxId As String = CStr(rss("result")("customer")("taxId"))
                    rpl = titleTaxId
                    replace1()
                    titleTaxId = rpl
                    Dim titlePhone As String = CStr(rss("result")("customer")("phone"))
                    rpl = titlePhone
                    replace1()
                    titlePhone = rpl
                    Dim titleTitle As String = CStr(rss("result")("customer")("title"))
                    rpl = titleTitle
                    replace1()
                    titleTitle = rpl
                    Dim titleEmail As String = CStr(rss("result")("customer")("email"))
                    Dim titleDeliveryAdress As String = CStr(rss("result")("customer")("delivery")("address"))
                    rpl = titleDeliveryAdress
                    replace1()
                    titleDeliveryAdress = rpl
                    Dim titleDeliveryDistrict As String = CStr(rss("result")("customer")("delivery")("district"))
                    rpl = titleDeliveryDistrict
                    replace1()
                    titleDeliveryDistrict = rpl
                    Dim titleDeliveryCity As String = CStr(rss("result")("customer")("delivery")("city"))
                    rpl = titleDeliveryCity
                    replace1()
                    titleDeliveryCity = rpl
                    Dim titleInvoiceAdress As String = CStr(rss("result")("customer")("invoice")("address"))
                    rpl = titleInvoiceAdress
                    replace1()
                    titleInvoiceAdress = rpl
                    Dim titleInvoiceDistrict As String = CStr(rss("result")("customer")("invoice")("district"))
                    rpl = titleInvoiceDistrict
                    replace1()
                    titleInvoiceDistrict = rpl
                    Dim titleInvoiceCity As String = CStr(rss("result")("customer")("invoice")("city"))
                    rpl = titleInvoiceCity
                    replace1()
                    titleInvoiceCity = rpl

                    Dim titleProductCode As String
                    If CStr(rss("result")("products")(syi)("code")) = Nothing Then
                        titleProductCode = "NULL"
                    Else

                        titleProductCode = CStr(rss("result")("products")(syi)("code")).ToArray()

                    End If
                    rpl = titleProductCode
                    replace1()
                    titleProductCode = rpl
                    Dim titleProductName As String = CStr(rss("result")("products")(syi)("name"))
                    rpl = titleProductName
                    replace1()
                    titleProductName = rpl
                    Dim titleProductBarcode As String
                    If CStr(rss("result")("products")(syi)("barcode")) = Nothing Then
                        titleProductBarcode = "NULL"
                    Else

                        titleProductBarcode = CStr(rss("result")("products")(syi)("barcode")).ToArray()

                    End If
                    rpl = titleProductBarcode
                    replace1()
                    titleProductBarcode = rpl
                    Dim titleprice As String
                    If CStr(rss("result")("products")(syi)("price")) = Nothing Then
                        titleprice = "NULL"
                    Else

                        titleprice = CStr(rss("result")("products")(syi)("price")).ToArray()

                    End If
                    rpl = titleprice
                    replace1()
                    titleprice = rpl
                    Dim titlequantity As String
                    If CStr(rss("result")("products")(syi)("quantity")) = Nothing Then
                        titlequantity = "NULL"
                    Else

                        titlequantity = CStr(rss("result")("products")(syi)("quantity")).ToArray()

                    End If
                    rpl = titlequantity
                    replace1()
                    titlequantity = rpl
                    Dim titleTotalPrice As String
                    If CStr(rss("result")("products")(syi)("totalPrice")) = Nothing Then
                        titleTotalPrice = "NULL"
                    Else

                        titleTotalPrice = CStr(rss("result")("products")(syi)("totalPrice")).ToArray()

                    End If
                    rpl = titleTotalPrice

                    replace1()
                    titleTotalPrice = rpl

                    Dim titleProductVariantsNameS As String
                    Dim titleProductVariantsValueS As String
                    Dim titleProducVariantsNameC As String
                    Dim titleProducVariantsValueC As String
                    Try

                        If CStr(rss("result")("products")(syi)("variants")(0)("name")) = Nothing Then
                            titleProductVariantsNameS = "NULL"
                        Else
                            titleProductVariantsNameS = CStr(rss("result")("products")(syi)("variants")(0)("name")).ToArray()
                        End If
                        rpl = titleProductVariantsNameS
                        replace1()
                        titleProductVariantsNameS = rpl

                        If CStr(rss("result")("products")(syi)("variants")(0)("value")) = Nothing Then
                            titleProductVariantsValueS = "NULL"
                        Else
                            titleProductVariantsValueS = CStr(rss("result")("products")(syi)("variants")(0)("value")).ToArray()
                        End If
                        rpl = titleProductVariantsValueS
                        replace1()
                        titleProductVariantsValueS = rpl

                        If CStr(rss("result")("products")(syi)("variants")(1)("name")) = Nothing Then
                            titleProducVariantsNameC = "NULL"
                        Else
                            titleProducVariantsNameC = CStr(rss("result")("products")(syi)("variants")(1)("name")).ToArray()
                        End If
                        rpl = titleProducVariantsNameC
                        replace1()
                        titleProducVariantsNameC = rpl

                        If CStr(rss("result")("products")(syi)("variants")(1)("value")) = Nothing Then
                            titleProducVariantsValueC = "NULL"
                        Else
                            titleProducVariantsValueC = CStr(rss("result")("products")(syi)("variants")(1)("value")).ToArray()
                        End If
                        rpl = titleProducVariantsValueC
                        replace1()
                        titleProducVariantsValueC = rpl

                    Catch ex As Exception
                        MessageBox.Show("hata" & ids)
                    End Try

                    Dim titleTotal As String = CStr(rss("result")("summary")("total"))
                    Dim titleDiscount As String = CStr(rss("result")("summary")("discount"))
                    Dim titleSubtotal As String = CStr(rss("result")("summary")("subTotal"))
                    Dim titleOverall As String = CStr(rss("result")("summary")("overall"))

                    Dim cmd1 As New OleDb.OleDbCommand
                    Dim con1 As New OleDb.OleDbConnection
                    con1.ConnectionString = connection
                    If con1.State = ConnectionState.Closed Then
                        con1.ConnectionString = connection
                        cmd1.Connection = con1
                        con1.Open()
                    End If



                    Dim sorgu As String = "
                        insert into tbESiparisDetay (Siparisid,Sipariscode,SiparisDurumu,KargofirmaID,Kargofirmaadi,Kargofirmaverginumarasi,Kargobarkodu,Kargotakipkodu,KargotakipURL,Kargodurumu,Kargotarihi,Siparistarihi,Siparisguncellenmetarihi,Siparisplatformu,SiparisplatformURL,Odemetipi,Musteriadisoyadi,Vergidairesi,Verginumarasi,Telefonnumarasi,MüþteriUnvani,Epostaadresi,Teslimatadresi,Teslimatilcesi,Teslimatili,Faturaadresi,Faturailcesi,Faturaili,Siparistutari,Indirimtutari,Siparisaratoplam,Siparisgeneltoplamtutari,Urunkodu,Urunadi,Urunbarkodu,Varyantadi,Varyantdegeri,VaryantadiC,VaryantdegeriC,UrunMiktari,UrunFiyati,UrunTutari,Guncel)
                        values (" & titleId & ",'" & titleCode & "'," & titleStatus & "," & titleShipmentFirmId & ",'" & titleShipmentFirmName & "','" & titleShipmentFirmTax & "','" & titleShipmentCode & "','" & titleShipmentCode2 & "','" & titleShipmentUrl & "','" & titleShipmentStatus & "','" & titleShipmentDate & "','" & titleCreatedAt & "','" & titleUpdatedAt & "','" & titlePlatform & "','" & titlePlatformUrl & "','" & titlePaymentMethod & "','" & titleName & "','" & titleTaxBranch & "','" & titleTaxId & "','" & titlePhone & "','" & titleTitle & "','" & titleEmail & "','" & titleDeliveryAdress & "','" & titleDeliveryDistrict & "','" & titleDeliveryCity & "','" & titleInvoiceAdress & "','" & titleInvoiceDistrict & "','" & titleInvoiceCity & "'," & titleTotal & "," & titleDiscount & "," & titleSubtotal & "," & titleOverall & ",'" & titleProductCode & "','" & titleProductName & "','" & titleProductBarcode & "','" & titleProductVariantsNameS & "','" & titleProductVariantsValueS & "','" & titleProducVariantsNameC & "','" & titleProducVariantsValueC & "','" & titlequantity & "','" & titleprice & "','" & titleTotalPrice & "','0')"
                    odbCmd1 = New OleDbCommand(sorgu, odbCon1)
                    odbCon1.Open()
                    odbCmd1.ExecuteNonQuery()
                    odbCon1.Close()
                    readerOrderShow.Close()
                    webRequest2.Abort()
                    syi += 1

                End While

                'Else
                '    Dim webRequest2 = CType(HttpWebRequest.Create(ProductUpdate & show & ids), HttpWebRequest)
                '    webRequest2.Method = "GET"
                '    webRequest2.ContentType = "application/json;charset=utf-8"
                '    webRequest2.Headers.Add("apikey", "" & apikey & "")
                '    webRequest2.Headers.Add("apisecret", "" & apisecret & "")
                '    webRequest2.UserAgent = "Mozilla/5.0 (Macintosh; Intel Mac OS X 10_14_3) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/76.0.3809.132 Safari/537.36"
                '    webRequest2.ContentLength = 0
                '    Dim webResponse2 = CType(webRequest2.GetResponse(), HttpWebResponse)
                '    Dim readerOrderShow As StreamReader = New StreamReader(CType(webResponse2.GetResponseStream(), Stream))
                '    Dim veriOrderShow As String = readerOrderShow.ReadToEnd()
                '    Dim dataOrderShow As String = veriOrderShow
                '    Dim rss As JObject = JObject.Parse(dataOrderShow)
                '    Dim syi As Integer = 0
                '    Dim productLenght As Array = rss("result")("products").ToArray()
                '    While syi <= productLenght.Length - 1


                '        Dim titleId As String = CStr(rss("result")("order")("id"))
                '        Dim titleCode As String = CStr(rss("result")("order")("code"))
                '        rpl = titleCode
                '        replace1()
                '        titleCode = rpl
                '        Dim titleStatus As String = CStr(rss("result")("order")("status"))
                '        Dim titleShipmentFirmId As String = CStr(rss("result")("order")("shipmentFirmId"))
                '        Dim titleShipmentFirmName As String = CStr(rss("result")("order")("shipmentFirmName"))
                '        rpl = titleShipmentFirmName
                '        replace1()
                '        titleShipmentFirmName = rpl
                '        Dim titleShipmentFirmTax As String = CStr(rss("result")("order")("shipmentFirmTax"))
                '        rpl = titleShipmentFirmTax
                '        replace1()
                '        titleShipmentFirmTax = rpl
                '        Dim titleShipmentCode As String = CStr(rss("result")("order")("shipmentCode"))
                '        Dim titleShipmentCode2 As String = CStr(rss("result")("order")("shipmentCode2"))
                '        Dim titleShipmentUrl As String = CStr(rss("result")("order")("shipmentUrl"))
                '        rpl = titleShipmentUrl
                '        replace1()
                '        titleShipmentUrl = rpl
                '        Dim titleShipmentStatus As String = CStr(rss("result")("order")("shipmentStatus"))
                '        Dim titleShipmentDate As String = CStr(rss("result")("order")("shipmentDate"))
                '        Dim titleCreatedAt As String = CStr(rss("result")("order")("createdAt"))
                '        Dim titleUpdatedAt As String = CStr(rss("result")("order")("updatedAt"))
                '        Dim titleEinvoiceCode As String = CStr(rss("result")("order")("einvoiceCode"))
                '        If CStr(rss("result")("order")("einvoiceCode")) = Nothing Then

                '        Else

                '            titleEinvoiceCode = CStr(rss("result")("order")("einvoiceCode")).ToArray()

                '        End If
                '        Dim titlePlatform As String = CStr(rss("result")("order")("platform"))
                '        Dim titlePlatformUrl As String = CStr(rss("result")("order")("platformUrl"))
                '        rpl = titlePlatformUrl
                '        replace1()
                '        titlePlatformUrl = rpl
                '        Dim titlePaymentMethod As String = CStr(rss("result")("order")("paymentMethod"))
                '        Dim titleName As String = CStr(rss("result")("customer")("name"))
                '        rpl = titleName
                '        replace1()
                '        titleName = rpl
                '        Dim titleTaxBranch As String = CStr(rss("result")("customer")("taxBranch"))
                '        Dim titleTaxId As String = CStr(rss("result")("customer")("taxId"))
                '        rpl = titleTaxId
                '        replace1()
                '        titleTaxId = rpl
                '        Dim titlePhone As String = CStr(rss("result")("customer")("phone"))
                '        rpl = titlePhone
                '        replace1()
                '        titlePhone = rpl
                '        Dim titleTitle As String = CStr(rss("result")("customer")("title"))
                '        rpl = titleTitle
                '        replace1()
                '        titleTitle = rpl
                '        Dim titleEmail As String = CStr(rss("result")("customer")("email"))
                '        Dim titleDeliveryAdress As String = CStr(rss("result")("customer")("delivery")("address"))
                '        rpl = titleDeliveryAdress
                '        replace1()
                '        titleDeliveryAdress = rpl
                '        Dim titleDeliveryDistrict As String = CStr(rss("result")("customer")("delivery")("district"))
                '        rpl = titleDeliveryDistrict
                '        replace1()
                '        titleDeliveryDistrict = rpl
                '        Dim titleDeliveryCity As String = CStr(rss("result")("customer")("delivery")("city"))
                '        rpl = titleDeliveryCity
                '        replace1()
                '        titleDeliveryCity = rpl
                '        Dim titleInvoiceAdress As String = CStr(rss("result")("customer")("invoice")("address"))
                '        rpl = titleInvoiceAdress
                '        replace1()
                '        titleInvoiceAdress = rpl
                '        Dim titleInvoiceDistrict As String = CStr(rss("result")("customer")("invoice")("district"))
                '        rpl = titleInvoiceDistrict
                '        replace1()
                '        titleInvoiceDistrict = rpl
                '        Dim titleInvoiceCity As String = CStr(rss("result")("customer")("invoice")("city"))
                '        rpl = titleInvoiceCity
                '        replace1()
                '        titleInvoiceCity = rpl

                '        Dim titleProductCode As String
                '        If CStr(rss("result")("products")(syi)("code")) = Nothing Then
                '            titleProductCode = "NULL"
                '        Else

                '            titleProductCode = CStr(rss("result")("products")(syi)("code")).ToArray()

                '        End If
                '        rpl = titleProductCode
                '        replace1()
                '        titleProductCode = rpl
                '        Dim titleProductName As String = CStr(rss("result")("products")(syi)("name"))
                '        rpl = titleProductName
                '        replace1()
                '        titleProductName = rpl
                '        Dim titleProductBarcode As String
                '        If CStr(rss("result")("products")(syi)("barcode")) = Nothing Then
                '            titleProductBarcode = "NULL"
                '        Else

                '            titleProductBarcode = CStr(rss("result")("products")(syi)("barcode")).ToArray()

                '        End If
                '        rpl = titleProductBarcode
                '        replace1()
                '        titleProductBarcode = rpl
                '        Dim titleprice As String
                '        If CStr(rss("result")("products")(syi)("price")) = Nothing Then
                '            titleprice = "NULL"
                '        Else

                '            titleprice = CStr(rss("result")("products")(syi)("price")).ToArray()

                '        End If
                '        rpl = titleprice
                '        replace1()
                '        titleprice = rpl
                '        Dim titlequantity As String
                '        If CStr(rss("result")("products")(syi)("quantity")) = Nothing Then
                '            titlequantity = "NULL"
                '        Else

                '            titlequantity = CStr(rss("result")("products")(syi)("quantity")).ToArray()

                '        End If
                '        rpl = titlequantity
                '        replace1()
                '        titlequantity = rpl
                '        Dim titleTotalPrice As String
                '        If CStr(rss("result")("products")(syi)("totalPrice")) = Nothing Then
                '            titleTotalPrice = "NULL"
                '        Else

                '            titleTotalPrice = CStr(rss("result")("products")(syi)("totalPrice")).ToArray()

                '        End If
                '        rpl = titleTotalPrice

                '        replace1()
                '        titleTotalPrice = rpl

                '        Dim titleProductVariantsNameS As String
                '        Dim titleProductVariantsValueS As String
                '        Dim titleProducVariantsNameC As String
                '        Dim titleProducVariantsValueC As String
                '        Try

                '            If CStr(rss("result")("products")(syi)("variants")(0)("name")) = Nothing Then
                '                titleProductVariantsNameS = "NULL"
                '            Else
                '                titleProductVariantsNameS = CStr(rss("result")("products")(syi)("variants")(0)("name")).ToArray()
                '            End If
                '            rpl = titleProductVariantsNameS
                '            replace1()
                '            titleProductVariantsNameS = rpl

                '            If CStr(rss("result")("products")(syi)("variants")(0)("value")) = Nothing Then
                '                titleProductVariantsValueS = "NULL"
                '            Else
                '                titleProductVariantsValueS = CStr(rss("result")("products")(syi)("variants")(0)("value")).ToArray()
                '            End If
                '            rpl = titleProductVariantsValueS
                '            replace1()
                '            titleProductVariantsValueS = rpl

                '            If CStr(rss("result")("products")(syi)("variants")(1)("name")) = Nothing Then
                '                titleProducVariantsNameC = "NULL"
                '            Else
                '                titleProducVariantsNameC = CStr(rss("result")("products")(syi)("variants")(1)("name")).ToArray()
                '            End If
                '            rpl = titleProducVariantsNameC
                '            replace1()
                '            titleProducVariantsNameC = rpl

                '            If CStr(rss("result")("products")(syi)("variants")(1)("value")) = Nothing Then
                '                titleProducVariantsValueC = "NULL"
                '            Else
                '                titleProducVariantsValueC = CStr(rss("result")("products")(syi)("variants")(1)("value")).ToArray()
                '            End If
                '            rpl = titleProducVariantsValueC
                '            replace1()
                '            titleProducVariantsValueC = rpl

                '        Catch ex As Exception
                '            MessageBox.Show("hata" & ids)
                '        End Try


                '        Dim titleTotal As String = CStr(rss("result")("summary")("total"))
                '        Dim titleDiscount As String = CStr(rss("result")("summary")("discount"))
                '        Dim titleSubtotal As String = CStr(rss("result")("summary")("subTotal"))
                '        Dim titleOverall As String = CStr(rss("result")("summary")("overall"))

                '        Dim cmd1 As New OleDb.OleDbCommand
                '        Dim con1 As New OleDb.OleDbConnection
                '        con1.ConnectionString = connection
                '        If con1.State = ConnectionState.Closed Then
                '            con1.ConnectionString = connection
                '            cmd1.Connection = con1
                '            con1.Open()
                '        End If

                '        If titleCreatedAt < titleUpdatedAt Then

                '            'Dim sorgu As String = "
                '            '    insert into tbESiparisDetay (Siparisid,Sipariscode,SiparisDurumu,KargofirmaID,Kargofirmaadi,Kargofirmaverginumarasi,Kargobarkodu,Kargotakipkodu,KargotakipURL,Kargodurumu,Kargotarihi,Siparistarihi,Siparisguncellenmetarihi,Siparisplatformu,SiparisplatformURL,Odemetipi,Musteriadisoyadi,Vergidairesi,Verginumarasi,Telefonnumarasi,MüþteriUnvani,Epostaadresi,Teslimatadresi,Teslimatilcesi,Teslimatili,Faturaadresi,Faturailcesi,Faturaili,Siparistutari,Indirimtutari,Siparisaratoplam,Siparisgeneltoplamtutari,Urunkodu,Urunadi,Urunbarkodu,Varyantadi,Varyantdegeri,VaryantadiC,VaryantdegeriC,UrunMiktari,UrunFiyati,UrunTutari,Guncel)
                '            '    values (" & titleId & ",'" & titleCode & "'," & titleStatus & "," & titleShipmentFirmId & ",'" & titleShipmentFirmName & "','" & titleShipmentFirmTax & "','" & titleShipmentCode & "','" & titleShipmentCode2 & "','" & titleShipmentUrl & "','" & titleShipmentStatus & "','" & titleShipmentDate & "','" & titleCreatedAt & "','" & titleUpdatedAt & "','" & titlePlatform & "','" & titlePlatformUrl & "','" & titlePaymentMethod & "','" & titleName & "','" & titleTaxBranch & "','" & titleTaxId & "','" & titlePhone & "','" & titleTitle & "','" & titleEmail & "','" & titleDeliveryAdress & "','" & titleDeliveryDistrict & "','" & titleDeliveryCity & "','" & titleInvoiceAdress & "','" & titleInvoiceDistrict & "','" & titleInvoiceCity & "'," & titleTotal & "," & titleDiscount & "," & titleSubtotal & "," & titleOverall & ",'" & titleProductCode & "','" & titleProductName & "','" & titleProductBarcode & "','" & titleProductVariantsNameS & "','" & titleProductVariantsValueS & "','" & titleProducVariantsNameC & "','" & titleProducVariantsValueC & "','" & titlequantity & "','" & titleprice & "','" & titleTotalPrice & "','0')"
                '            Dim sorgu As String = " Update tbESiparisDetay Set KargofirmaID = " & titleShipmentFirmId & ",Kargofirmaadi = '" & titleShipmentFirmName & "',Kargofirmaverginumarasi ='" & titleShipmentFirmTax & "',Kargobarkodu = '" & titleShipmentCode & "',Kargotakipkodu = '" & titleShipmentCode & "',KargotakipURL = '" & titleShipmentUrl & "',Kargodurumu ='" & titleShipmentStatus & "',Kargotarihi ='" & titleShipmentDate & "', Siparisguncellenmetarihi = '" & titleUpdatedAt & "',Siparisplatformu ='" & titlePlatform & "',SiparisplatformURL='" & titlePlatformUrl & "',Teslimatadresi = '" & titleDeliveryAdress & "',Teslimatilcesi ='" & titleDeliveryDistrict & "',Teslimatili = '" & titleDeliveryCity & "',Faturaadresi ='" & titleInvoiceAdress & "',Faturailcesi = '" & titleInvoiceDistrict & "',Faturaili = '" & titleInvoiceCity & "',Siparistutari =" & titleTotal & ",Indirimtutari=" & titleDiscount & ",Siparisaratoplam =" & titleSubtotal & ",Siparisgeneltoplamtutari =" & titleOverall & ",Urunkodu = '" & titleProductCode & "',Urunadi = '" & titleProductName & "',Urunbarkodu = '" & titleProductBarcode & "',Varyantadi = '" & titleProductVariantsNameS & "',Varyantdegeri = '" & titleProductVariantsValueS & "',VaryantadiC = '" & titleProducVariantsNameC & "',VaryantdegeriC = '" & titleProducVariantsValueC & "',UrunMiktari = '" & titlequantity & "',UrunFiyati'" & titleprice & "',UrunTutari='" & titleTotalPrice & "',Guncel = '0' Where Sipariscode = '" & titleCode & "'  "
                '            odbCmd1 = New OleDbCommand(sorgu, odbCon1)
                '            odbCon1.Open()
                '            odbCmd1.ExecuteNonQuery()
                '            odbCon1.Close()
                '            readerOrderShow.Close()
                '            webRequest2.Abort()
                '        End If
                '        syi += 1

                '    End While
                'End If

            End While
        End If
        'End While

        dataR.Close()

        counter = 0
        ' MessageBox.Show("Aktarma Gerçekeþti")
        Siparis_olustur()
    End Sub
    Private Sub replace1()
        rpl = rpl.Replace("'", "")
        rpl = rpl.Replace("(", "")
        rpl = rpl.Replace(")", "")
        rpl = rpl.Replace("_", "")
        rpl = rpl.Replace(";", "")
    End Sub
    Public Sub jsonRequest_Fiyat_guncel()
        Dim cmd1 As New OleDb.OleDbCommand
        Dim con1 As New OleDb.OleDbConnection
        Dim Url As String = ""
        Dim ProductUpdate As String = ""
        Dim ApiKey As String = ""
        Dim ApiSecret As String = ""
        Dim s As String
        Dim arr = GridView1.RowCount
        Dim i As Integer
        Dim TOPLAM = arr
        i = 0
        'Dim Mydata As String = ""
        'Dim myReq As HttpWebRequest
        'Dim myResp As HttpWebResponse
        'Dim myReader As StreamReader
        Dim Renk1 = ""
        Dim Renk2 = ""
        Dim Renk3 = ""
        Dim Renk4 = ""
        Dim Renk5 = ""
        Dim Renk6 = ""
        Dim Renk7 = ""
        Dim Renk8 = ""
        Dim Renk9 = ""
        Dim Renk10 = ""
        Dim Renk11 = ""
        Dim Renk12 = ""
        Dim Renk13 = ""
        Dim Renk14 = ""
        Dim Renk15 = ""
        Dim Renk16 = ""
        Dim Renk17 = ""
        Dim Renk18 = ""
        Dim Renk19 = ""
        Dim Renk20 = ""
        Dim Renk21 = ""
        Dim Renk22 = ""
        Dim Renk23 = ""
        Dim Renk24 = ""
        Dim Renk25 = ""
        Dim Renk26 = ""
        Dim Renk27 = ""
        Dim Renk28 = ""
        Dim Renk29 = ""
        Dim Renk30 = ""
        Dim Renk31 = ""
        Dim Renk32 = ""
        Dim Renk33 = ""
        Dim Renk34 = ""
        Dim Renk35 = ""
        Dim Renk36 = ""
        Dim Renk37 = ""
        Dim Renk38 = ""
        Dim Renk39 = ""
        Dim Renk40 = ""
        Dim Renk41 = ""
        Dim Renk42 = ""
        Dim Renk43 = ""
        Dim Renk44 = ""
        Dim Renk45 = ""
        Dim Renk46 = ""
        Dim Renk47 = ""
        Dim Renk48 = ""
        Dim Renk49 = ""
        Dim Renk50 = ""
        Dim Renk51 = ""
        Dim Renk52 = ""
        Dim Renk53 = ""
        Dim Renk54 = ""
        Dim Renk55 = ""
        Dim Renk56 = ""
        Dim Renk57 = ""
        Dim Renk58 = ""
        Dim Renk59 = ""
        Dim Renk60 = ""
        Dim Beden1 = ""
        Dim Beden2 = ""
        Dim Beden3 = ""
        Dim Beden4 = ""
        Dim Beden5 = ""
        Dim Beden6 = ""
        Dim Beden7 = ""
        Dim Beden8 = ""
        Dim Beden9 = ""
        Dim Beden10 = ""
        Dim Beden11 = ""
        Dim Beden12 = ""
        Dim Beden13 = ""
        Dim Beden14 = ""
        Dim Beden15 = ""
        Dim Beden16 = ""
        Dim Beden17 = ""
        Dim Beden18 = ""
        Dim Beden19 = ""
        Dim Beden20 = ""
        Dim Beden21 = ""
        Dim Beden22 = ""
        Dim Beden23 = ""
        Dim Beden24 = ""
        Dim Beden25 = ""
        Dim Beden26 = ""
        Dim Beden27 = ""
        Dim Beden28 = ""
        Dim Beden29 = ""
        Dim Beden30 = ""
        Dim Beden31 = ""
        Dim Beden32 = ""
        Dim Beden33 = ""
        Dim Beden34 = ""
        Dim Beden35 = ""
        Dim Beden36 = ""
        Dim Beden37 = ""
        Dim Beden38 = ""
        Dim Beden39 = ""
        Dim Beden40 = ""
        Dim Beden41 = ""
        Dim Beden42 = ""
        Dim Beden43 = ""
        Dim Beden44 = ""
        Dim Beden45 = ""
        Dim Beden46 = ""
        Dim Beden47 = ""
        Dim Beden48 = ""
        Dim Beden49 = ""
        Dim Beden50 = ""
        Dim Beden51 = ""
        Dim Beden52 = ""
        Dim Beden53 = ""
        Dim Beden54 = ""
        Dim Beden55 = ""
        Dim Beden56 = ""
        Dim Beden57 = ""
        Dim Beden58 = ""
        Dim Beden59 = ""
        Dim Beden60 = ""
        Dim barcode1 = ""
        Dim barcode2 = ""
        Dim barcode3 = ""
        Dim barcode4 = ""
        Dim barcode5 = ""
        Dim barcode6 = ""
        Dim barcode7 = ""
        Dim barcode8 = ""
        Dim barcode9 = ""
        Dim barcode10 = ""
        Dim barcode11 = ""
        Dim barcode12 = ""
        Dim barcode13 = ""
        Dim barcode14 = ""
        Dim barcode15 = ""
        Dim barcode16 = ""
        Dim barcode17 = ""
        Dim barcode18 = ""
        Dim barcode19 = ""
        Dim barcode20 = ""
        Dim barcode21 = ""
        Dim barcode22 = ""
        Dim barcode23 = ""
        Dim barcode24 = ""
        Dim barcode25 = ""
        Dim barcode26 = ""
        Dim barcode27 = ""
        Dim barcode28 = ""
        Dim barcode29 = ""
        Dim barcode30 = ""
        Dim barcode31 = ""
        Dim barcode32 = ""
        Dim barcode33 = ""
        Dim barcode34 = ""
        Dim barcode35 = ""
        Dim barcode36 = ""
        Dim barcode37 = ""
        Dim barcode38 = ""
        Dim barcode39 = ""
        Dim barcode40 = ""
        Dim barcode41 = ""
        Dim barcode42 = ""
        Dim barcode43 = ""
        Dim barcode44 = ""
        Dim barcode45 = ""
        Dim barcode46 = ""
        Dim barcode47 = ""
        Dim barcode48 = ""
        Dim barcode49 = ""
        Dim barcode50 = ""
        Dim barcode51 = ""
        Dim barcode52 = ""
        Dim barcode53 = ""
        Dim barcode54 = ""
        Dim barcode55 = ""
        Dim barcode56 = ""
        Dim barcode57 = ""
        Dim barcode58 = ""
        Dim barcode59 = ""
        Dim barcode60 = ""
        Dim barcode = "0"
        Dim name = ""
        Dim invoiceName = ""
        Dim status = ""
        Dim shortDescription = ""
        Dim brand = ""
        Dim category1 = ""
        Dim category2 = ""
        Dim category3 = ""
        Dim category4 = ""
        Dim category5 = ""
        Dim longDescription As String = "0"
        Dim seoTitle = ""
        Dim seoKeywords = ""
        Dim seoDescription As String = ""
        Dim taxRate = ""
        'Dim shipmentPayment = dr("Kargo")
        Dim buyPrice = ""
        Dim listPrice = ""
        Dim salePrice = ""
        Dim quantity = ""
        Dim variant1Name = "Renk"
        Dim variant2Name = "Beden"
        Dim imageUrl = ""
        Dim imageUrl1 = ""
        Dim imageUrl2 = ""
        Dim imageUrl3 = ""
        Dim imageUrl4 = ""
        Dim imageUrl5 = ""
        Dim imageUrl6 = ""
        Dim imageUrl7 = ""
        Dim imageUrl8 = ""
        Dim imageUrl9 = ""
        Dim imageUrl10 = ""
        Dim xx = ""
        Dim priceStatus = 0
        Dim price = 0
        Dim TysalePrice = ""
        Dim N11salePrice = ""
        Dim GgsalePrice = ""
        Dim HbsalePrice = ""
        Dim CssalePrice = ""
        Dim EpttsalePrice = ""
        Dim AmzsalePrice = ""
        Dim quantity1 As Decimal = -9999
        Dim quantity2 As Decimal = -9999
        Dim quantity3 As Decimal = -9999
        Dim quantity4 As Decimal = -9999
        Dim quantity5 As Decimal = -9999
        Dim quantity6 As Decimal = -9999
        Dim quantity7 As Decimal = -9999
        Dim quantity8 As Decimal = -9999
        Dim quantity9 As Decimal = -9999
        Dim quantity10 As Decimal = -9999
        Dim quantity11 As Decimal = -9999
        Dim quantity12 As Decimal = -9999
        Dim quantity13 As Decimal = -9999
        Dim quantity14 As Decimal = -9999
        Dim quantity15 As Decimal = -9999
        Dim quantity16 As Decimal = -9999
        Dim quantity17 As Decimal = -9999
        Dim quantity18 As Decimal = -9999
        Dim quantity19 As Decimal = -9999
        Dim quantity20 As Decimal = -9999
        Dim quantity21 As Decimal = -9999
        Dim quantity22 As Decimal = -9999
        Dim quantity23 As Decimal = -9999
        Dim quantity24 As Decimal = -9999
        Dim quantity25 As Decimal = -9999
        Dim quantity26 As Decimal = -9999
        Dim quantity27 As Decimal = -9999
        Dim quantity28 As Decimal = -9999
        Dim quantity29 As Decimal = -9999
        Dim quantity30 As Decimal = -9999
        Dim quantity31 As Decimal = -9999
        Dim quantity32 As Decimal = -9999
        Dim quantity33 As Decimal = -9999
        Dim quantity34 As Decimal = -9999
        Dim quantity35 As Decimal = -9999
        Dim quantity36 As Decimal = -9999
        Dim quantity37 As Decimal = -9999
        Dim quantity38 As Decimal = -9999
        Dim quantity39 As Decimal = -9999
        Dim quantity40 As Decimal = -9999
        Dim quantity41 As Decimal = -9999
        Dim quantity42 As Decimal = -9999
        Dim quantity43 As Decimal = -9999
        Dim quantity44 As Decimal = -9999
        Dim quantity45 As Decimal = -9999
        Dim quantity46 As Decimal = -9999
        Dim quantity47 As Decimal = -9999
        Dim quantity48 As Decimal = -9999
        Dim quantity49 As Decimal = -9999
        Dim quantity50 As Decimal = -9999
        Dim quantity51 As Decimal = -9999
        Dim quantity52 As Decimal = -9999
        Dim quantity53 As Decimal = -9999
        Dim quantity54 As Decimal = -9999
        Dim quantity55 As Decimal = -9999
        Dim quantity56 As Decimal = -9999
        Dim quantity57 As Decimal = -9999
        Dim quantity58 As Decimal = -9999
        Dim quantity59 As Decimal = -9999
        Dim quantity60 As Decimal = -9999
        Dim quantitys As Decimal = 0
        Dim Renk As String = ""
        Dim RenkVal As String = ""
        Dim Beden As String = ""
        Dim BedenVal As String = ""
        Dim Barkod As String = ""
        Dim BarkodVal As String = ""
        Dim quantityVal As String = ""
        Dim quantitysVal As String = ""
        Dim Fiyat As String = ""
        'con1.ConnectionString = connection
        'If con1.State = ConnectionState.Closed Then
        '    cmd1.Connection = con1
        '    con1.Open()
        'End If
        'cmd1.CommandText = "DELETE FROM tbStokEticaret "
        'cmd1.ExecuteNonQuery()
        'con1.Close()
        'Dim dr As DataRow = GridView1.GetDataRow(GridView1.FocusedRowHandle)

        Dim adapter As New OleDb.OleDbDataAdapter
        Dim cmd7 As New OleDb.OleDbCommand
        Dim con7 As New OleDb.OleDbConnection
        Dim dr7 As DataRow
        Dim DS7 As New DataSet

        con7.ConnectionString = connection
        con7.Open()
        cmd7.CommandText = "SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT  tbStok.bWebGoruntule,tbStok.nStokID,tbStok.sModel,sRenk,sBeden,sKavala,tbStok.sKdvTipi,sOzelNot,sBarkod,isnull(sUzunNot, 0) as sUzunNot,tbStok.sAciklama,tbStok.sKodu,ISNULL((SELECT     ISNULL(lOran, 0) FROM         tbStokBirimCevrimi WHERE     nStokID = tbStok.nStokID And sBirimCinsi = tbStok.sBirimCinsi2), 1) AS nBirimCarpan,CAST((SELECT isnull(SUM(tbStokFisiDetayi.lGirisMiktar1 - tbStokFisiDetayi.lCikisMiktar1) , 0) FROM tbStokFisiDetayi WHERE tbStok.nStokID = tbStokFisiDetayi.nStokID) / ISNULL((SELECT     ISNULL(lOran, 0) FROM         tbStokBirimCevrimi WHERE     nStokID = tbStok.nStokID And sBirimCinsi = tbStok.sBirimCinsi2), 1) AS MONEY) as lMevcut2, tbStokBarkodu.sBarkod,ISNULL(YOL,0) as Resim1,ISNULL(YOL1,0) as Resim2,ISNULL(YOL2,0) as Resim3,ISNULL(YOL3,0) as Resim4,ISNULL(YOL4,0) as Resim5,ISNULL(YOL5,0) as Resim6,ISNULL(YOL6,0) as Resim7,ISNULL(YOL7,0) as Resim8,ISNULL(YOL8,0) as Resim9,ISNULL(YOL9,0) as Resim10,ISNULL(YOL10,0) as Resim11,tbStokUzunNot.sUzunNot, tbSSinif1.sAciklama AS Sinif1, tbSSinif2.sAciklama AS Sinif2, tbSSinif3.sAciklama AS Sinif3, tbSSinif4.sAciklama AS Sinif4, tbSSinif5.sAciklama AS Sinif5, tbSSinif6.sAciklama AS Sinif6, tbSSinif7.sAciklama AS Sinif7, tbSSinif8.sAciklama AS Sinif8, tbSSinif9.sAciklama AS Sinif9, tbSSinif10.sAciklama AS Sinif10, tbSSinif11.sAciklama AS Sinif11, tbSSinif12.sAciklama AS Sinif12, tbSSinif13.sAciklama AS Sinif13, tbSSinif14.sAciklama AS Sinif14, tbSSinif15.sAciklama AS Sinif15, ISNULL(tbStokAciklama.sAciklama1 + ' ' + tbStokAciklama.sAciklama2 + ' ' + tbStokAciklama.sAciklama3 + ' ' + tbStokAciklama.sAciklama4 + ' ' + tbStokAciklama.sAciklama5 + ' ' + tbStokAciklama.sAciklama6 + ' ' + tbStokAciklama.sAciklama7 + ' ' + tbStokAciklama.sAciklama8 + ' ' + tbStokAciklama.sAciklama9 + ' ' + tbStokAciklama.sAciklama10, '') AS ISTIHBARAT, (SELECT isnull(SUM(tbStokFisiDetayi.lGirisMiktar1 - tbStokFisiDetayi.lCikisMiktar1) , 0) FROM tbStokFisiDetayi WHERE tbStok.nStokID =tbStokFisiDetayi.nStokID) AS Mevcut, ISNULL((SELECT isnull(lfiyat , 0) FROM tbstokfiyati WHERE nStokId = tbStok.NstokId And sFiyatTipi = '1'),0) AS FIYAT1, ISNULL((SELECT isnull(lfiyat , 0) FROM tbstokfiyati WHERE nStokId = tbStok.NstokId And sFiyatTipi = '2'),0) AS FIYAT2,ISNULL((SELECT isnull(lfiyat, 0) FROM tbstokfiyati WHERE nStokId = tbStok.NstokId And sFiyatTipi = '3'),0) AS FIYAT3,ISNULL((SELECT isnull(lfiyat , 0) FROM tbstokfiyati WHERE nStokId = tbStok.NstokId And sFiyatTipi = 'M'),0) AS FIYATM,ISNULL((SELECT isnull(lfiyat , 0) FROM tbstokfiyati WHERE nStokId = tbStok.NstokId And sFiyatTipi = '4'), 0) AS FIYAT4,ISNULL((SELECT isnull(lfiyat , 0) FROM tbstokfiyati WHERE nStokId = tbStok.NstokId And sFiyatTipi = 'WEBP'), 0) AS WEBP,ISNULL((SELECT isnull(lfiyat , 0) FROM tbstokfiyati WHERE nStokId = tbStok.NstokId AND sFiyatTipi = 'WEBK'), 0) AS WEBK, ISNULL((SELECT isnull(lfiyat , 0) FROM tbstokfiyati WHERE nStokId = tbStok.NstokId And sFiyatTipi = 'ty'), 0) AS TysalePrice,ISNULL((SELECT isnull(lfiyat, 0) FROM tbstokfiyati WHERE nStokId = tbStok.NstokId And sFiyatTipi = 'N11'), 0) AS N11salePrice,ISNULL((SELECT isnull(lfiyat , 0) FROM tbstokfiyati WHERE nStokId = tbStok.NstokId And sFiyatTipi = 'GG'), 0) AS GgsalePrice,ISNULL((SELECT isnull(lfiyat , 0) FROM tbstokfiyati WHERE nStokId = tbStok.NstokId And sFiyatTipi = 'Hb'), 0) AS HbsalePrice,ISNULL((SELECT isnull(lfiyat , 0) FROM tbstokfiyati WHERE nStokId = tbStok.NstokId And sFiyatTipi = 'Eptt'), 0) AS EpttsalePrice,ISNULL((SELECT isnull(lfiyat , 0) FROM tbstokfiyati WHERE nStokId = tbStok.NstokId And sFiyatTipi = 'Cs'), 0) AS CssalePrice,ISNULL((SELECT isnull(lfiyat , 0) FROM tbstokfiyati WHERE nStokId = tbStok.NstokId And sFiyatTipi = 'Amz'), 0) AS AmzsalePrice,ISNULL((SELECT isnull(lfiyat , 0) FROM tbstokfiyati WHERE nStokId = tbStok.NstokId And sFiyatTipi = 'New'), 0) AS NewsalePrice,ISNULL((SELECT isnull(lfiyat, 0) FROM tbstokfiyati WHERE nStokId = tbStok.nStokId And sFiyatTipi = 'A'),0) AS FIYATA,ISNULL((SELECT isnull(lfiyat , 0) FROM tbstokfiyati WHERE nStokId = tbStok.NstokId AND sFiyatTipi = '1'),0) AS lFiyat, (SELECT     nKdvOrani FROM         tbKdv Where sKdvTipi = tbStok.sKdvTipi) as nKdvOrani,ISNULL((SELECT ISNULL(lOran , 1) FROM tbStokBirimCevrimi WHERE nStokID = tbStok.nStokID And sBirimCinsi = tbStok.sBirimCinsi2), 1) AS lBirimCarpan, (SELECT     sRenkAdi FROM          tbRenk WHERE      sRenk = tbStok.sRenk) AS sRenkAdi,(SELECT     COUNT(DISTINCT nStokID) AS nKayit FROM         tbStokFiyati WHERE     (dteFiyatTespitTarihi = '14/02/2021') AND (sFiyatTipi IN ('1', '2', '3')) and nStokID = tbStok.nStokID) bFiyatDegisti  FROM tbStok LEFT OUTER JOIN tbStokBarkodu ON tbStok.nStokID = tbStokBarkodu.nStokID and tbStokBarkodu.nKisim =0 INNER JOIN tbStokSinifi ON tbStok.nStokID = tbStokSinifi.nStokID LEFT OUTER JOIN tbStokEticaretResim ON tbStok.sModel = tbStokEticaretResim.sModel LEFT OUTER JOIN tbStokUzunNot ON tbStok.sModel = tbStokUzunNot.sModel INNER JOIN tbSSinif1 ON tbStokSinifi.sSinifKodu1 = tbSSinif1.sSinifKodu INNER JOIN tbSSinif2 ON tbStokSinifi.sSinifKodu2 = tbSSinif2.sSinifKodu INNER JOIN tbSSinif3 ON tbStokSinifi.sSinifKodu3 = tbSSinif3.sSinifKodu INNER JOIN tbSSinif4 ON tbStokSinifi.sSinifKodu4 = tbSSinif4.sSinifKodu INNER JOIN tbSSinif5 ON tbStokSinifi.sSinifKodu5 = tbSSinif5.sSinifKodu INNER JOIN tbSSinif6 ON tbStokSinifi.sSinifKodu6 = tbSSinif6.sSinifKodu INNER JOIN tbSSinif7 ON tbStokSinifi.sSinifKodu7 = tbSSinif7.sSinifKodu INNER JOIN tbSSinif8 ON tbStokSinifi.sSinifKodu8 = tbSSinif8.sSinifKodu INNER JOIN tbSSinif9 ON tbStokSinifi.sSinifKodu9 = tbSSinif9.sSinifKodu INNER JOIN tbSSinif10 ON tbStokSinifi.sSinifKodu10 = tbSSinif10.sSinifKodu INNER JOIN tbSSinif11 ON tbStokSinifi.sSinifKodu11 = tbSSinif11.sSinifKodu INNER JOIN tbSSinif12 ON tbStokSinifi.sSinifKodu12 = tbSSinif12.sSinifKodu INNER JOIN tbSSinif13 ON tbStokSinifi.sSinifKodu13 = tbSSinif13.sSinifKodu INNER JOIN tbSSinif14 ON tbStokSinifi.sSinifKodu14 = tbSSinif14.sSinifKodu INNER JOIN tbSSinif15 ON tbStokSinifi.sSinifKodu15 = tbSSinif15.sSinifKodu LEFT OUTER JOIN tbStokAciklama ON tbStok.nStokID = tbStokAciklama.nStokID WHERE  tbStok.nStokTipi <> 5 and tbStok.bWebGoruntule = 'True' and sRenk <> '' ORDER BY tbStok.sModel"
        cmd7.Connection = con7
        adapter.SelectCommand = cmd7
        Dim N As Integer = adapter.Fill(DS7, "Table1")

        For Each dr7 In DS7.Tables(0).Rows

            'Dim dr As DataRow = ds_stok.Tables(0).Rows(0)
            Dim code = Trim(dr7("sModel"))
            Dim Model = Trim(dr7("sKodu"))
            Dim nStokID = Trim(dr7("nStokID"))
            Dim Sor As String = ""
            Dim R As String = Trim(dr7("sRenkAdi"))
            Dim Bed As String = Trim(dr7("sBeden"))
            Dim Bar As String = Trim(dr7("sBarkod"))
            Dim Q As String = Trim(dr7("Mevcut"))
            Dim Qs As String = Trim(dr7("Mevcut"))
            con1.ConnectionString = connection
            If con1.State = ConnectionState.Closed Then
                cmd1.Connection = con1
                con1.Open()
            End If
            cmd1.CommandText = sorgu_queryJson("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT  COUNT (code) FROM tbStokEticaret where code = '" & code & "' ")
            Sor = cmd1.ExecuteScalar.ToString()
            s = i.ToString
            If xx <> code Then
                Renk1 = ""
                Renk2 = ""
                Renk3 = ""
                Renk4 = ""
                Renk5 = ""
                Renk6 = ""
                Renk7 = ""
                Renk8 = ""
                Renk9 = ""
                Renk10 = ""
                Renk11 = ""
                Renk12 = ""
                Renk13 = ""
                Renk14 = ""
                Renk15 = ""
                Renk16 = ""
                Renk17 = ""
                Renk18 = ""
                Renk19 = ""
                Renk20 = ""
                Renk21 = ""
                Renk22 = ""
                Renk23 = ""
                Renk24 = ""
                Renk25 = ""
                Renk26 = ""
                Renk27 = ""
                Renk28 = ""
                Renk29 = ""
                Renk30 = ""
                Renk31 = ""
                Renk32 = ""
                Renk33 = ""
                Renk34 = ""
                Renk35 = ""
                Renk36 = ""
                Renk37 = ""
                Renk38 = ""
                Renk39 = ""
                Renk40 = ""
                Renk41 = ""
                Renk42 = ""
                Renk43 = ""
                Renk44 = ""
                Renk45 = ""
                Renk46 = ""
                Renk47 = ""
                Renk48 = ""
                Renk49 = ""
                Renk50 = ""
                Renk51 = ""
                Renk52 = ""
                Renk53 = ""
                Renk54 = ""
                Renk55 = ""
                Renk56 = ""
                Renk57 = ""
                Renk58 = ""
                Renk59 = ""
                Renk60 = ""
                Beden1 = ""
                Beden2 = ""
                Beden3 = ""
                Beden4 = ""
                Beden5 = ""
                Beden6 = ""
                Beden7 = ""
                Beden8 = ""
                Beden9 = ""
                Beden10 = ""
                Beden11 = ""
                Beden12 = ""
                Beden13 = ""
                Beden14 = ""
                Beden15 = ""
                Beden16 = ""
                Beden17 = ""
                Beden18 = ""
                Beden19 = ""
                Beden20 = ""
                Beden21 = ""
                Beden22 = ""
                Beden23 = ""
                Beden24 = ""
                Beden25 = ""
                Beden26 = ""
                Beden27 = ""
                Beden28 = ""
                Beden29 = ""
                Beden30 = ""
                Beden31 = ""
                Beden32 = ""
                Beden33 = ""
                Beden34 = ""
                Beden35 = ""
                Beden36 = ""
                Beden37 = ""
                Beden38 = ""
                Beden39 = ""
                Beden40 = ""
                Beden41 = ""
                Beden42 = ""
                Beden43 = ""
                Beden44 = ""
                Beden45 = ""
                Beden46 = ""
                Beden47 = ""
                Beden48 = ""
                Beden49 = ""
                Beden50 = ""
                Beden51 = ""
                Beden52 = ""
                Beden53 = ""
                Beden54 = ""
                Beden55 = ""
                Beden56 = ""
                Beden57 = ""
                Beden58 = ""
                Beden59 = ""
                Beden60 = ""
                barcode1 = ""
                barcode2 = ""
                barcode3 = ""
                barcode4 = ""
                barcode5 = ""
                barcode6 = ""
                barcode7 = ""
                barcode8 = ""
                barcode9 = ""
                barcode10 = ""
                barcode11 = ""
                barcode12 = ""
                barcode13 = ""
                barcode14 = ""
                barcode15 = ""
                barcode16 = ""
                barcode17 = ""
                barcode18 = ""
                barcode19 = ""
                barcode20 = ""
                barcode21 = ""
                barcode22 = ""
                barcode23 = ""
                barcode24 = ""
                barcode25 = ""
                barcode26 = ""
                barcode27 = ""
                barcode28 = ""
                barcode29 = ""
                barcode30 = ""
                barcode31 = ""
                barcode32 = ""
                barcode33 = ""
                barcode34 = ""
                barcode35 = ""
                barcode36 = ""
                barcode37 = ""
                barcode38 = ""
                barcode39 = ""
                barcode40 = ""
                barcode41 = ""
                barcode42 = ""
                barcode43 = ""
                barcode44 = ""
                barcode45 = ""
                barcode46 = ""
                barcode47 = ""
                barcode48 = ""
                barcode49 = ""
                barcode50 = ""
                barcode51 = ""
                barcode52 = ""
                barcode53 = ""
                barcode54 = ""
                barcode55 = ""
                barcode56 = ""
                barcode57 = ""
                barcode58 = ""
                barcode59 = ""
                barcode60 = ""
                barcode = "0"
                name = ""
                invoiceName = ""
                status = ""
                shortDescription = ""
                brand = ""
                category1 = ""
                category2 = ""
                category3 = ""
                category4 = ""
                category5 = ""
                longDescription = ""
                seoTitle = ""
                seoKeywords = ""
                seoDescription = ""
                taxRate = ""
                ' shipmentPayment = dr("Kargo")
                buyPrice = ""
                listPrice = ""
                salePrice = ""
                quantity = ""
                variant1Name = "Renk"
                variant2Name = "Beden"
                imageUrl = ""
                imageUrl1 = ""
                imageUrl2 = ""
                imageUrl3 = ""
                imageUrl4 = ""
                imageUrl5 = ""
                imageUrl6 = ""
                imageUrl7 = ""
                imageUrl8 = ""
                imageUrl9 = ""
                imageUrl10 = ""
                xx = ""
                priceStatus = 0
                price = 0
                TysalePrice = ""
                N11salePrice = ""
                GgsalePrice = ""
                HbsalePrice = ""
                CssalePrice = ""
                EpttsalePrice = ""
                AmzsalePrice = ""
                quantity1 = -9999
                quantity2 = -9999
                quantity3 = -9999
                quantity4 = -9999
                quantity5 = -9999
                quantity6 = -9999
                quantity7 = -9999
                quantity8 = -9999
                quantity9 = -9999
                quantity10 = -9999
                quantity11 = -9999
                quantity12 = -9999
                quantity13 = -9999
                quantity14 = -9999
                quantity15 = -9999
                quantity16 = -9999
                quantity17 = -9999
                quantity18 = -9999
                quantity19 = -9999
                quantity20 = -9999
                quantity21 = -9999
                quantity22 = -9999
                quantity23 = -9999
                quantity24 = -9999
                quantity25 = -9999
                quantity26 = -9999
                quantity27 = -9999
                quantity28 = -9999
                quantity29 = -9999
                quantity30 = -9999
                quantity31 = -9999
                quantity32 = -9999
                quantity33 = -9999
                quantity34 = -9999
                quantity35 = -9999
                quantity36 = -9999
                quantity37 = -9999
                quantity38 = -9999
                quantity39 = -9999
                quantity40 = -9999
                quantity41 = -9999
                quantity42 = -9999
                quantity43 = -9999
                quantity44 = -9999
                quantity45 = -9999
                quantity46 = -9999
                quantity47 = -9999
                quantity48 = -9999
                quantity49 = -9999
                quantity50 = -9999
                quantity51 = -9999
                quantity52 = -9999
                quantity53 = -9999
                quantity54 = -9999
                quantity55 = -9999
                quantity56 = -9999
                quantity57 = -9999
                quantity58 = -9999
                quantity59 = -9999
                quantity60 = -9999
                quantitys = 0
                Renk = ""
                RenkVal = ""
                Beden = ""
                BedenVal = ""
                Barkod = ""
                BarkodVal = ""
                quantityVal = ""
                quantitysVal = ""
            End If

            If Sor <= 0 Then
                code = Trim(dr7("sModel"))
                name = dr7("sAciklama")
                invoiceName = dr7("sAciklama")
                status = dr7("bWebGoruntule")
                barcode = Trim(dr7("sBarkod"))
                shortDescription = dr7("sAciklama")
                brand = dr7("Sinif4")
                category1 = dr7("Sinif3")
                category2 = dr7("Sinif2")
                category3 = dr7("Sinif6")
                category4 = dr7("Sinif5")
                category5 = dr7("Sinif6")
                longDescription = Trim(dr7("sUzunNot"))
                seoTitle = dr7("Sinif3")
                seoKeywords = dr7("Sinif3")
                seoDescription = dr7("Sinif3")
                taxRate = dr7("sKdvTipi")
                ' shipmentPayment = dr7("Kargo")
                buyPrice = dr7("FIYATA")
                listPrice = dr7("WEBK")
                salePrice = dr7("WEBP")
                quantity = dr7("Mevcut")
                variant1Name = "Renk"
                variant2Name = "Beden"
                imageUrl = dr7("Resim1")
                imageUrl1 = dr7("Resim2")
                imageUrl2 = dr7("Resim3")
                imageUrl3 = dr7("Resim4")
                imageUrl4 = dr7("Resim5")
                imageUrl5 = dr7("Resim6")
                imageUrl6 = dr7("Resim7")
                imageUrl7 = dr7("Resim8")
                imageUrl8 = dr7("Resim9")
                imageUrl9 = dr7("Resim10")
                imageUrl10 = dr7("Resim11")
                Renk1 = Trim(dr7("sRenkAdi"))
                Beden1 = Trim(dr7("sBeden"))
                TysalePrice = Trim(dr7("TysalePrice"))
                N11salePrice = Trim(dr7("N11salePrice"))
                GgsalePrice = Trim(dr7("GgsalePrice"))
                HbsalePrice = Trim(dr7("HbsalePrice"))
                CssalePrice = (dr7("CssalePrice"))
                EpttsalePrice = (dr7("EpttsalePrice"))
                AmzsalePrice = (dr7("AmzsalePrice"))
                If TysalePrice <= 0 Then
                    TysalePrice = salePrice
                End If
                If N11salePrice <= 0 Then
                    N11salePrice = salePrice
                End If
                If GgsalePrice <= 0 Then
                    GgsalePrice = salePrice
                End If
                If HbsalePrice <= 0 Then
                    HbsalePrice = salePrice
                End If
                If CssalePrice <= 0 Then
                    CssalePrice = salePrice
                End If
                If EpttsalePrice <= 0 Then
                    EpttsalePrice = salePrice
                End If
                If AmzsalePrice <= 0 Then
                    AmzsalePrice = salePrice
                End If
                taxRate = 0
                If taxRate = 1 Then
                    taxRate = 0
                ElseIf taxRate = 2 Then
                    taxRate = 18
                ElseIf taxRate = 3 Then
                    taxRate = 8
                End If
                tbStok_kaydet_Eticaret(nStokID, code, name, Renk1, Beden1, barcode, brand, category1, category2, category3, category4, category5, longDescription, buyPrice, listPrice, salePrice, seoTitle, seoKeywords, taxRate, quantity, seoDescription, variant1Name, variant2Name, imageUrl, imageUrl1, imageUrl2, imageUrl3, imageUrl4, imageUrl5, imageUrl6, imageUrl7, imageUrl8, imageUrl9, imageUrl10, TysalePrice, N11salePrice, GgsalePrice, HbsalePrice, EpttsalePrice, CssalePrice, AmzsalePrice)

            Else
                Dim con As New OleDb.OleDbConnection
                Dim cmd As New OleDb.OleDbCommand
                cmd.Connection = con
                con.ConnectionString = connection
                cmd.CommandTimeout = False
                If con.State = ConnectionState.Closed = True Then
                    con.Open()
                End If

                'cmd.CommandText = "SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT @@identity"
                'Dim kayitno = cmd.ExecuteScalar
                con.Close()
                code = Trim(dr7("sModel"))
                xx = Trim(dr7("sModel"))
                name = dr7("sAciklama")
                invoiceName = dr7("sAciklama")
                status = dr7("bWebGoruntule")
                barcode = Trim(dr7("sBarkod"))
                shortDescription = dr7("sAciklama")
                brand = dr7("Sinif1")
                category1 = dr7("Sinif2")
                category2 = dr7("Sinif3")
                category3 = dr7("Sinif4")
                category4 = dr7("Sinif5")
                longDescription = Trim(dr7("sUzunNot"))
                seoTitle = dr7("Sinif2")
                seoKeywords = dr7("Sinif2")
                seoDescription = dr7("Sinif2")
                taxRate = dr7("sKdvTipi")
                ' shipmentPayment = dr7("Kargo")
                buyPrice = dr7("FIYATA")
                listPrice = dr7("WEBK")
                salePrice = dr7("WEBP")
                quantity = dr7("Mevcut")
                variant1Name = "Renk"
                variant2Name = "Beden"
                imageUrl = dr7("Resim1")
                imageUrl1 = dr7("Resim2")
                imageUrl2 = dr7("Resim3")
                imageUrl3 = dr7("Resim4")
                imageUrl4 = dr7("Resim5")
                imageUrl5 = dr7("Resim6")
                imageUrl6 = dr7("Resim7")
                imageUrl7 = dr7("Resim8")
                imageUrl8 = dr7("Resim9")
                imageUrl9 = dr7("Resim10")
                imageUrl10 = dr7("Resim11")
                Renk1 = Trim(dr7("sRenkAdi"))
                Beden1 = Trim(dr7("sBeden"))
                taxRate = 0
                If taxRate = 1 Then
                    taxRate = 0
                ElseIf taxRate = 2 Then
                    taxRate = 18
                ElseIf taxRate = 3 Then
                    taxRate = 8
                End If

                'If Renk2 = "" Then
                '    Renk2 = R
                '    Renk = "Renk2"
                '    RenkVal = Renk2
                '    tbStok_RenkUpdate_Eticaret(code, Renk, RenkVal)
                'ElseIf Renk3 = "" Then
                '    Renk3 = R
                '    Renk = "Renk3"
                '    RenkVal = Renk3
                '    tbStok_RenkUpdate_Eticaret(code, Renk, RenkVal)
                'ElseIf Renk4 = "" Then
                '    Renk4 = R
                '    Renk = "Renk4"
                '    RenkVal = Renk4
                '    tbStok_RenkUpdate_Eticaret(code, Renk, RenkVal)
                'ElseIf Renk5 = "" Then
                '    Renk5 = R
                '    Renk = "Renk5"
                '    RenkVal = Renk5
                '    tbStok_RenkUpdate_Eticaret(code, Renk, RenkVal)
                'ElseIf Renk6 = "" Then
                '    Renk6 = R
                '    Renk = "Renk6"
                '    RenkVal = Renk6
                '    tbStok_RenkUpdate_Eticaret(code, Renk, RenkVal)
                'ElseIf Renk7 = "" Then
                '    Renk7 = R
                '    Renk = "Renk7"
                '    RenkVal = Renk7
                '    tbStok_RenkUpdate_Eticaret(code, Renk, RenkVal)
                'ElseIf Renk8 = "" Then
                '    Renk8 = R
                '    Renk = "Renk8"
                '    RenkVal = Renk8
                '    tbStok_RenkUpdate_Eticaret(code, Renk, RenkVal)
                'ElseIf Renk9 = "" Then
                '    Renk9 = R
                '    Renk = "Renk9"
                '    RenkVal = Renk9
                '    tbStok_RenkUpdate_Eticaret(code, Renk, RenkVal)
                'ElseIf Renk10 = "" Then
                '    Renk10 = R
                '    Renk = "Renk10"
                '    RenkVal = Renk10
                '    tbStok_RenkUpdate_Eticaret(code, Renk, RenkVal)
                'ElseIf Renk11 = "" Then
                '    Renk11 = R
                '    Renk = "Renk11"
                '    RenkVal = Renk11
                '    tbStok_RenkUpdate_Eticaret(code, Renk, RenkVal)
                'ElseIf Renk12 = "" Then
                '    Renk12 = R
                '    Renk = "Renk12"
                '    RenkVal = Renk12
                '    tbStok_RenkUpdate_Eticaret(code, Renk, RenkVal)
                'ElseIf Renk13 = "" Then
                '    Renk13 = R
                '    Renk = "Renk13"
                '    RenkVal = Renk13
                '    tbStok_RenkUpdate_Eticaret(code, Renk, RenkVal)
                'ElseIf Renk14 = "" Then
                '    Renk14 = R
                '    Renk = "Renk14"
                '    RenkVal = Renk14
                '    tbStok_RenkUpdate_Eticaret(code, Renk, RenkVal)
                'ElseIf Renk15 = "" Then
                '    Renk15 = R
                '    Renk = "Renk15"
                '    RenkVal = Renk15
                '    tbStok_RenkUpdate_Eticaret(code, Renk, RenkVal)
                'ElseIf Renk16 = "" Then
                '    Renk16 = R
                '    Renk = "Renk16"
                '    RenkVal = Renk16
                '    tbStok_RenkUpdate_Eticaret(code, Renk, RenkVal)
                'ElseIf Renk17 = "" Then
                '    Renk17 = R
                '    Renk = "Renk17"
                '    RenkVal = Renk17
                '    tbStok_RenkUpdate_Eticaret(code, Renk, RenkVal)
                'ElseIf Renk18 = "" Then
                '    Renk18 = R
                '    Renk = "Renk18"
                '    RenkVal = Renk18
                '    tbStok_RenkUpdate_Eticaret(code, Renk, RenkVal)
                'ElseIf Renk19 = "" Then
                '    Renk19 = R
                '    Renk = "Renk19"
                '    RenkVal = Renk19
                '    tbStok_RenkUpdate_Eticaret(code, Renk, RenkVal)
                'ElseIf Renk20 = "" Then
                '    Renk20 = R
                '    Renk = "Renk20"
                '    RenkVal = Renk20
                '    tbStok_RenkUpdate_Eticaret(code, Renk, RenkVal)
                'End If

                If Beden2 = "" Then
                    Beden2 = Bed
                    Beden = "Beden2"
                    BedenVal = Beden2
                    Fiyat = "Fiyat2"
                    tbStok_BedenUpdate_Eticaret(code, Beden, BedenVal, Fiyat, salePrice)
                ElseIf Beden3 = "" Then
                    Beden3 = Bed
                    Beden = "Beden3"
                    BedenVal = Beden3
                    Fiyat = "Fiyat3"
                    tbStok_BedenUpdate_Eticaret(code, Beden, BedenVal, Fiyat, salePrice)
                ElseIf Beden4 = "" Then
                    Beden4 = Bed
                    Beden = "Beden4"
                    BedenVal = Beden4
                    Fiyat = "Fiyat4"
                    tbStok_BedenUpdate_Eticaret(code, Beden, BedenVal, Fiyat, salePrice)
                ElseIf Beden5 = "" Then
                    Beden5 = Bed
                    Beden = "Beden5"
                    BedenVal = Beden5
                    Fiyat = "Fiyat5"
                    tbStok_BedenUpdate_Eticaret(code, Beden, BedenVal, Fiyat, salePrice)
                ElseIf Beden6 = "" Then
                    Beden6 = Bed
                    Beden = "Beden6"
                    BedenVal = Beden6
                    Fiyat = "Fiyat6"
                    tbStok_BedenUpdate_Eticaret(code, Beden, BedenVal, Fiyat, salePrice)
                ElseIf Beden7 = "" Then
                    Beden7 = Bed
                    Beden = "Beden7"
                    BedenVal = Beden7
                    Fiyat = "Fiyat7"
                    tbStok_BedenUpdate_Eticaret(code, Beden, BedenVal, Fiyat, salePrice)
                ElseIf Beden8 = "" Then
                    Beden8 = Bed
                    Beden = "Beden8"
                    BedenVal = Beden8
                    Fiyat = "Fiyat8"
                    tbStok_BedenUpdate_Eticaret(code, Beden, BedenVal, Fiyat, salePrice)
                ElseIf Beden9 = "" Then
                    Beden9 = Bed
                    Beden = "Beden9"
                    BedenVal = Beden9
                    Fiyat = "Fiyat9"
                    tbStok_BedenUpdate_Eticaret(code, Beden, BedenVal, Fiyat, salePrice)
                ElseIf Beden10 = "" Then
                    Beden10 = Bed
                    Beden = "Beden10"
                    BedenVal = Beden10
                    Fiyat = "Fiyat10"
                    tbStok_BedenUpdate_Eticaret(code, Beden, BedenVal, Fiyat, salePrice)
                ElseIf Beden11 = "" Then
                    Beden11 = Bed
                    Beden = "Beden11"
                    BedenVal = Beden11
                    Fiyat = "Fiyat11"
                    tbStok_BedenUpdate_Eticaret(code, Beden, BedenVal, Fiyat, salePrice)
                ElseIf Beden12 = "" Then
                    Beden12 = Bed
                    Beden = "Beden12"
                    BedenVal = Beden12
                    Fiyat = "Fiyat12"
                    tbStok_BedenUpdate_Eticaret(code, Beden, BedenVal, Fiyat, salePrice)
                ElseIf Beden13 = "" Then
                    Beden13 = Bed
                    Beden = "Beden13"
                    BedenVal = Beden13
                    Fiyat = "Fiyat13"
                    tbStok_BedenUpdate_Eticaret(code, Beden, BedenVal, Fiyat, salePrice)
                ElseIf Beden14 = "" Then
                    Beden14 = Bed
                    Beden = "Beden14"
                    BedenVal = Beden14
                    Fiyat = "Fiyat14"
                    tbStok_BedenUpdate_Eticaret(code, Beden, BedenVal, Fiyat, salePrice)
                ElseIf Beden15 = "" Then
                    Beden15 = Bed
                    Beden = "Beden15"
                    BedenVal = Beden15
                    Fiyat = "Fiyat15"
                    tbStok_BedenUpdate_Eticaret(code, Beden, BedenVal, Fiyat, salePrice)
                ElseIf Beden16 = "" Then
                    Beden16 = Bed
                    Beden = "Beden16"
                    BedenVal = Beden16
                    Fiyat = "Fiyat16"
                    tbStok_BedenUpdate_Eticaret(code, Beden, BedenVal, Fiyat, salePrice)
                ElseIf Beden17 = "" Then
                    Beden17 = Bed
                    Beden = "Beden17"
                    BedenVal = Beden17
                    Fiyat = "Fiyat17"
                    tbStok_BedenUpdate_Eticaret(code, Beden, BedenVal, Fiyat, salePrice)
                ElseIf Beden18 = "" Then
                    Beden18 = Bed
                    Beden = "Beden18"
                    BedenVal = Beden18
                    Fiyat = "Fiyat18"
                    tbStok_BedenUpdate_Eticaret(code, Beden, BedenVal, Fiyat, salePrice)
                ElseIf Beden19 = "" Then
                    Beden19 = Bed
                    Beden = "Beden19"
                    BedenVal = Beden19
                    Fiyat = "Fiyat19"
                    tbStok_BedenUpdate_Eticaret(code, Beden, BedenVal, Fiyat, salePrice)
                ElseIf Beden20 = "" Then
                    Beden20 = Bed
                    Beden = "Beden20"
                    BedenVal = Beden20
                    Fiyat = "Fiyat20"
                    tbStok_BedenUpdate_Eticaret(code, Beden, BedenVal, Fiyat, salePrice)
                End If


                'If barcode2 = "" Then
                '    barcode2 = Bar
                '    Barkod = "Barcode2"
                '    BarkodVal = barcode2
                '    tbStok_BarkodUpdate_Eticaret(code, Barkod, BarkodVal)
                'ElseIf barcode3 = "" Then
                '    barcode3 = Bar
                '    Barkod = "Barcode3"
                '    BarkodVal = barcode3
                '    tbStok_BarkodUpdate_Eticaret(code, Barkod, BarkodVal)
                'ElseIf barcode4 = "" Then
                '    barcode4 = Bar
                '    Barkod = "Barcode4"
                '    BarkodVal = barcode4
                '    tbStok_BarkodUpdate_Eticaret(code, Barkod, BarkodVal)
                'ElseIf barcode5 = "" Then
                '    barcode5 = Bar
                '    Barkod = "Barcode5"
                '    BarkodVal = barcode5
                '    tbStok_BarkodUpdate_Eticaret(code, Barkod, BarkodVal)
                'ElseIf barcode6 = "" Then
                '    barcode6 = Bar
                '    Barkod = "Barcode6"
                '    BarkodVal = barcode6
                '    tbStok_BarkodUpdate_Eticaret(code, Barkod, BarkodVal)
                'ElseIf barcode7 = "" Then
                '    barcode7 = Bar
                '    Barkod = "Barcode7"
                '    BarkodVal = barcode7
                '    tbStok_BarkodUpdate_Eticaret(code, Barkod, BarkodVal)
                'ElseIf barcode8 = "" Then
                '    barcode8 = Bar
                '    Barkod = "Barcode8"
                '    BarkodVal = barcode8
                '    tbStok_BarkodUpdate_Eticaret(code, Barkod, BarkodVal)
                'ElseIf barcode9 = "" Then
                '    barcode9 = Bar
                '    Barkod = "Barcode9"
                '    BarkodVal = barcode9
                '    tbStok_BarkodUpdate_Eticaret(code, Barkod, BarkodVal)
                'ElseIf barcode10 = "" Then
                '    barcode10 = Bar
                '    Barkod = "Barcode10"
                '    BarkodVal = barcode10
                '    tbStok_BarkodUpdate_Eticaret(code, Barkod, BarkodVal)
                'ElseIf barcode11 = "" Then
                '    barcode11 = Bar
                '    Barkod = "Barcode11"
                '    BarkodVal = barcode11
                '    tbStok_BarkodUpdate_Eticaret(code, Barkod, BarkodVal)
                'ElseIf barcode12 = "" Then
                '    barcode12 = Bar
                '    Barkod = "Barcode12"
                '    BarkodVal = barcode12
                '    tbStok_BarkodUpdate_Eticaret(code, Barkod, BarkodVal)
                'ElseIf barcode13 = "" Then
                '    barcode13 = Bar
                '    Barkod = "Barcode13"
                '    BarkodVal = barcode13
                '    tbStok_BarkodUpdate_Eticaret(code, Barkod, BarkodVal)
                'ElseIf barcode14 = "" Then
                '    barcode14 = Bar
                '    Barkod = "Barcode14"
                '    BarkodVal = barcode14
                '    tbStok_BarkodUpdate_Eticaret(code, Barkod, BarkodVal)
                'ElseIf barcode15 = "" Then
                '    barcode15 = Bar
                '    Barkod = "Barcode15"
                '    BarkodVal = barcode15
                '    tbStok_BarkodUpdate_Eticaret(code, Barkod, BarkodVal)
                'ElseIf barcode16 = "" Then
                '    barcode16 = Bar
                '    Barkod = "Barcode16"
                '    BarkodVal = barcode16
                '    tbStok_BarkodUpdate_Eticaret(code, Barkod, BarkodVal)
                'ElseIf barcode17 = "" Then
                '    barcode17 = Bar
                '    Barkod = "Barcode17"
                '    BarkodVal = barcode17
                '    tbStok_BarkodUpdate_Eticaret(code, Barkod, BarkodVal)
                'ElseIf barcode18 = "" Then
                '    barcode18 = Bar
                '    Barkod = "Barcode18"
                '    BarkodVal = barcode18
                '    tbStok_BarkodUpdate_Eticaret(code, Barkod, BarkodVal)
                'ElseIf barcode19 = "" Then
                '    barcode19 = Bar
                '    Barkod = "Barcode19"
                '    BarkodVal = barcode19
                '    tbStok_BarkodUpdate_Eticaret(code, Barkod, BarkodVal)
                'ElseIf barcode20 = "" Then
                '    barcode20 = Bar
                '    Barkod = "Barcode20"
                '    BarkodVal = barcode20
                '    tbStok_BarkodUpdate_Eticaret(code, Barkod, BarkodVal)
                'End If

                'If quantity2 = "-9999" Then
                '    quantity2 = Q
                '    quantity = "quantity2"
                '    quantityVal = quantity2
                '    tbStok_quantityUpdate_Eticaret(code, quantity, quantityVal)
                'ElseIf quantity3 = "-9999" Then
                '    quantity3 = Q
                '    quantity = "quantity3"
                '    quantityVal = quantity3
                '    tbStok_quantityUpdate_Eticaret(code, quantity, quantityVal)
                'ElseIf quantity4 = "-9999" Then
                '    quantity4 = Q
                '    quantity = "quantity4"
                '    quantityVal = quantity4
                '    tbStok_quantityUpdate_Eticaret(code, quantity, quantityVal)
                'ElseIf quantity5 = "-9999" Then
                '    quantity5 = Q
                '    quantity = "quantity5"
                '    quantityVal = quantity5
                '    tbStok_quantityUpdate_Eticaret(code, quantity, quantityVal)
                'ElseIf quantity6 = "-9999" Then
                '    quantity6 = Q
                '    quantity = "quantity6"
                '    quantityVal = quantity6
                '    tbStok_quantityUpdate_Eticaret(code, quantity, quantityVal)
                'ElseIf quantity7 = "-9999" Then
                '    quantity7 = Q
                '    quantity = "quantity7"
                '    quantityVal = quantity7
                '    tbStok_quantityUpdate_Eticaret(code, quantity, quantityVal)
                'ElseIf quantity8 = "-9999" Then
                '    quantity8 = Q
                '    quantity = "quantity8"
                '    quantityVal = quantity8
                '    tbStok_quantityUpdate_Eticaret(code, quantity, quantityVal)
                'ElseIf quantity9 = "-9999" Then
                '    quantity9 = Q
                '    quantity = "quantity9"
                '    quantityVal = quantity9
                '    tbStok_quantityUpdate_Eticaret(code, quantity, quantityVal)
                'ElseIf quantity10 = "-9999" Then
                '    quantity10 = Q
                '    quantity = "quantity10"
                '    quantityVal = quantity10
                '    tbStok_quantityUpdate_Eticaret(code, quantity, quantityVal)
                'ElseIf quantity11 = "-9999" Then
                '    quantity11 = Q
                '    quantity = "quantity11"
                '    quantityVal = quantity11
                '    tbStok_quantityUpdate_Eticaret(code, quantity, quantityVal)
                'ElseIf quantity12 = "-9999" Then
                '    quantity12 = Q
                '    quantity = "quantity12"
                '    quantityVal = quantity12
                '    tbStok_quantityUpdate_Eticaret(code, quantity, quantityVal)
                'ElseIf quantity13 = "-9999" Then
                '    quantity13 = Q
                '    quantity = "quantity13"
                '    quantityVal = quantity13
                '    tbStok_quantityUpdate_Eticaret(code, quantity, quantityVal)
                'ElseIf quantity14 = "-9999" Then
                '    quantity14 = Q
                '    quantity = "quantity14"
                '    quantityVal = quantity14
                '    tbStok_quantityUpdate_Eticaret(code, quantity, quantityVal)
                'ElseIf quantity15 = "-9999" Then
                '    quantity15 = Q
                '    quantity = "quantity15"
                '    quantityVal = quantity15
                '    tbStok_quantityUpdate_Eticaret(code, quantity, quantityVal)
                'ElseIf quantity16 = "-9999" Then
                '    quantity16 = Q
                '    quantity = "quantity16"
                '    quantityVal = quantity16
                '    tbStok_quantityUpdate_Eticaret(code, quantity, quantityVal)
                'ElseIf quantity17 = "-9999" Then
                '    quantity17 = Q
                '    quantity = "quantity17"
                '    quantityVal = quantity17
                '    tbStok_quantityUpdate_Eticaret(code, quantity, quantityVal)
                'ElseIf quantity18 = "-9999" Then
                '    quantity18 = Q
                '    quantity = "quantity18"
                '    quantityVal = quantity18
                '    tbStok_quantityUpdate_Eticaret(code, quantity, quantityVal)
                'ElseIf quantity19 = "-9999" Then
                '    quantity19 = Q
                '    quantity = "quantity19"
                '    quantityVal = quantity19
                '    tbStok_quantityUpdate_Eticaret(code, quantity, quantityVal)
                'ElseIf quantity20 = "-9999" Then
                '    quantity20 = Q
                '    quantity = "quantity20"
                '    quantityVal = quantity20
                '    tbStok_quantityUpdate_Eticaret(code, quantity, quantityVal)
                'End If

                'If quantity1 > "0" Then
                '    quantitys += quantity1
                '    tbStok_quantitysUpdate_Eticaret(code, quantitys)
                'ElseIf quantity2 > "0" Then
                '    quantitys += quantity2
                '    tbStok_quantitysUpdate_Eticaret(code, quantitys)
                'ElseIf quantity3 > "0" Then
                '    quantitys += quantity3
                '    tbStok_quantitysUpdate_Eticaret(code, quantitys)
                'ElseIf quantity4 > "0" Then
                '    quantitys += quantity4
                '    tbStok_quantitysUpdate_Eticaret(code, quantitys)
                'ElseIf quantity5 > "0" Then
                '    quantitys += quantity5
                '    tbStok_quantitysUpdate_Eticaret(code, quantitys)
                'ElseIf quantity6 > "0" Then
                '    quantitys += quantity6
                '    tbStok_quantitysUpdate_Eticaret(code, quantitys)
                'ElseIf quantity7 > "0" Then
                '    quantitys += quantity7
                '    tbStok_quantitysUpdate_Eticaret(code, quantitys)
                'ElseIf quantity8 > "0" Then
                '    quantitys += quantity8
                '    tbStok_quantitysUpdate_Eticaret(code, quantitys)
                'ElseIf quantity9 > "0" Then
                '    quantitys += quantity9
                '    tbStok_quantitysUpdate_Eticaret(code, quantitys)
                'ElseIf quantity10 > "0" Then
                '    quantitys += quantity10
                '    tbStok_quantitysUpdate_Eticaret(code, quantitys)
                'ElseIf quantity11 > "0" Then
                '    quantitys += quantity11
                '    tbStok_quantitysUpdate_Eticaret(code, quantitys)
                'ElseIf quantity12 > "0" Then
                '    quantitys += quantity12
                '    tbStok_quantitysUpdate_Eticaret(code, quantitys)
                'ElseIf quantity13 > "0" Then
                '    quantitys += quantity13
                '    tbStok_quantitysUpdate_Eticaret(code, quantitys)
                'ElseIf quantity14 > "0" Then
                '    quantitys += quantity14
                '    tbStok_quantitysUpdate_Eticaret(code, quantitys)
                'ElseIf quantity15 > "0" Then
                '    quantitys += quantity15
                '    tbStok_quantitysUpdate_Eticaret(code, quantitys)
                'ElseIf quantity16 > "0" Then
                '    quantitys += quantity16
                '    tbStok_quantitysUpdate_Eticaret(code, quantitys)
                'ElseIf quantity17 > "0" Then
                '    quantitys += quantity17
                '    tbStok_quantitysUpdate_Eticaret(code, quantitys)
                'ElseIf quantity18 > "0" Then
                '    quantitys += quantity18
                '    tbStok_quantitysUpdate_Eticaret(code, quantitys)
                'ElseIf quantity19 > "0" Then
                '    quantitys += quantity19
                '    tbStok_quantitysUpdate_Eticaret(code, quantitys)
                'ElseIf quantity20 > "0" Then
                '    quantitys += quantity20
                '    tbStok_quantitysUpdate_Eticaret(code, quantitys)
                'End If




                tbStok_Update_Eticaret(code, buyPrice, salePrice, listPrice)

            End If
            con1.Close()

        Next

        ' JSON BAÞLANGIÇ


        'Dim adapter As New OleDb.OleDbDataAdapter
        Dim cmd5 As New OleDb.OleDbCommand
        Dim con5 As New OleDb.OleDbConnection
        Dim dr4 As DataRow
        Dim DS4 As New DataSet

        con5.ConnectionString = connection
        con5.Open()
        cmd5.CommandText = "select nStokID, code, name, ISNULL(Renk1,0)as Renk1, ISNULL(Beden1,0) as Beden1,  ISNULL(barcode1,0) as barcode1,  ISNULL(Fiyat1,0) as Fiyat1,  ISNULL(quantity1,0) as quantity1,  ISNULL(Renk2,0) as Renk2,  ISNULL(Beden2,0) as Beden2,  ISNULL(barcode2,0) as barcode2,  ISNULL(Fiyat2,0) as Fiyat2,  ISNULL(quantity2,0) as quantity2,  ISNULL(Renk3,0) as Renk3,  ISNULL(Beden3,0) as Beden3,  ISNULL(barcode3,0) as barcode3,  ISNULL(Fiyat3,0) as Fiyat3,  ISNULL(quantity3,0) as quantity3,  ISNULL(Renk4,0) as Renk4,  ISNULL(Beden4,0) as Beden4,  ISNULL(barcode4,0) as barcode4,  ISNULL(Fiyat4,0) as Fiyat4,  ISNULL(quantity4,0) as quantity4,  ISNULL(Renk5,0) as Renk5, ISNULL(Beden5,0) as Beden5, ISNULL(barcode5,0) as barcode5, ISNULL(quantity5,0) as quantity5, ISNULL(Fiyat5,0) as Fiyat5, ISNULL(Renk6,0) as Renk6, ISNULL(Beden6,0) as Beden6, ISNULL(barcode6,0) as barcode6, ISNULL(Fiyat6,0) as Fiyat6, ISNULL(quantity6,0) as quantity6, ISNULL(Renk7,0) as Renk7, ISNULL(Beden7,0) as Beden7, ISNULL(barcode7,0) as barcode7, ISNULL(Fiyat7,0) as Fiyat7, ISNULL(quantity7,0) as quantity7, ISNULL(Renk8,0) as Renk8, ISNULL(Beden8,0) as Beden8, ISNULL(barcode8,0) as barcode8, ISNULL(Fiyat8,0) as Fiyat8, ISNULL(quantity8,0) as quantity8, ISNULL(Renk9,0) as Renk9, ISNULL(Beden9,0) as Beden9, ISNULL(barcode9,0) as barcode9, ISNULL(Fiyat9,0) as Fiyat9, ISNULL(quantity9,0) as quantity9, ISNULL(Renk10,0) as Renk10, ISNULL(Beden10,0) as Beden10, ISNULL(barcode10,0) as barcode10, ISNULL(Fiyat10,0) as Fiyat10, ISNULL(quantity10,0) as quantity10, ISNULL(Renk11,0) as Renk11, ISNULL(Beden11,0) as Beden11, ISNULL(barcode11,0) as barcode11, ISNULL(Fiyat11,0) as Fiyat11, ISNULL(quantity11,0) as quantity11, ISNULL(Renk12,0) as Renk12, ISNULL(Beden12,0) as Beden12, ISNULL(barcode12,0) as barcode12, ISNULL(Fiyat12,0) as Fiyat12, ISNULL(quantity12,0) as quantity12, ISNULL(Renk13,0) as Renk13, ISNULL(Beden13,0) as Beden13, ISNULL(barcode13,0) as barcode13, ISNULL(Fiyat13,0) as Fiyat13, ISNULL(quantity13,0) as quantity13, ISNULL(Renk14,0) as Renk14, ISNULL(Beden14,0) as Beden14, ISNULL(barcode14,0) as barcode14, ISNULL(Fiyat14,0) as Fiyat14, ISNULL(quantity14,0) as quantity14, ISNULL(Renk15,0) as Renk15, ISNULL(Beden15,0) as Beden15, ISNULL(barcode15,0) as barcode15, ISNULL(Fiyat15,0) as Fiyat15, ISNULL(quantity15,0) as quantity15, ISNULL(Renk16,0) as Renk16, ISNULL(Beden16,0) as Beden16, ISNULL(barcode16,0) as barcode16, ISNULL(Fiyat16,0) as Fiyat16, ISNULL(quantity16,0) as quantity16, ISNULL(Renk17,0) as Renk17, ISNULL(Beden17,0) as Beden17, ISNULL(barcode17,0) as barcode17, ISNULL(Fiyat17,0) as Fiyat17, ISNULL(quantity17,0) as quantity17, ISNULL(Renk18,0) as Renk18, ISNULL(Beden18,0) as Beden18, ISNULL(barcode18,0) as barcode18, ISNULL(Fiyat18,0) as Fiyat18, ISNULL(quantity18,0) as quantity18, ISNULL(Renk19,0) as Renk19, ISNULL(Beden19,0) as Beden19, ISNULL(barcode19,0) as barcode19, ISNULL(Fiyat19,0) as Fiyat19, ISNULL(quantity19,0) as quantity19, ISNULL(Renk20,0) as Renk20, ISNULL(Beden20,0) as Beden20, ISNULL(barcode20,0) as barcode20, ISNULL(Fiyat20,0) as Fiyat20, ISNULL(quantity20,0) as quantity20, ISNULL(brand,0) as brand, ISNULL(category1,0) as category1, ISNULL(category2,0) as category2, ISNULL(category3,0) as category3, ISNULL(category4,0) as category4, ISNULL(category5,0) as category5,ISNULL(longDescription,0) as longDescription, ISNULL(seoTitle,0) as seoTitle, ISNULL(seoKeywords,0) as seoKeywords, ISNULL(seoDescription,0) as seoDescription, ISNULL(variant1Name,0) as variant1Name, ISNULL(variant2Name,0) as variant2Name, ISNULL(taxRate,0) as taxRate, ISNULL(shipmentPayment,0) as shipmentPayment, ISNULL(buyPrice,0) as buyPrice, ISNULL(listPrice,0) as listPrice, ISNULL(salePrice,0) as salePrice, ISNULL(TysalePrice,0) as TysalePrice, ISNULL(N11salePrice,0) as N11salePrice, ISNULL(GgsalePrice,0) as GgsalePrice, ISNULL(HbsalePrice,0) as HbsalePrice, ISNULL(EpttsalePrice,0) as EpttsalePrice, ISNULL(CssalePrice,0) as CssalePrice, ISNULL(amzsalePrice,0) as amzsalePrice, ISNULL(NewsalePrice,0) as NewsalePrice, ISNULL(quantity,0) as quantity, ISNULL(imageUrl,0) as imageUrl, ISNULL(imageUrl1,0) as imageUrl1, ISNULL(imageUrl2,0) as imageUrl2, ISNULL(imageUrl3,0) as imageUrl3, ISNULL(imageUrl4,0) as imageUrl4, ISNULL(imageUrl5,0) as imageUrl5, ISNULL(imageUrl6,0) as imageUrl6, ISNULL(imageUrl7,0) as imageUrl7, ISNULL(imageUrl8,0) as imageUrl8, ISNULL(imageUrl9,0) as imageUrl9, ISNULL(imageUrl10,0) as imageUrl10, ISNULL(dteGuncelZaman,0) as dteGuncelZaman from tbStokEticaret where Guncel = '0'"
        cmd5.Connection = con5
        adapter.SelectCommand = cmd5
        N = adapter.Fill(DS4, "Table1")

        For Each dr4 In DS4.Tables(0).Rows

            dr4("nStokID") = dr4("nStokID").ToString
            dr4("code") = Trim(dr4("code").ToString)
            dr4("name") = dr4("name").ToString
            dr4("Renk1") = Trim(dr4("Renk1").ToString)
            dr4("Renk2") = Trim(dr4("Renk2").ToString)
            dr4("Renk3") = Trim(dr4("Renk3").ToString)
            dr4("Renk4") = Trim(dr4("Renk4").ToString)
            dr4("Renk5") = Trim(dr4("Renk5").ToString)
            dr4("Renk6") = Trim(dr4("Renk6").ToString)
            dr4("Renk7") = Trim(dr4("Renk7").ToString)
            dr4("Renk8") = Trim(dr4("Renk8").ToString)
            dr4("Renk9") = Trim(dr4("Renk9").ToString)
            dr4("Renk10") = Trim(dr4("Renk10").ToString)
            dr4("Renk11") = Trim(dr4("Renk11").ToString)
            dr4("Renk12") = Trim(dr4("Renk12").ToString)
            dr4("Renk13") = Trim(dr4("Renk13").ToString)
            dr4("Renk14") = Trim(dr4("Renk14").ToString)
            dr4("Renk15") = Trim(dr4("Renk15").ToString)
            dr4("Renk16") = Trim(dr4("Renk16").ToString)
            dr4("Renk17") = Trim(dr4("Renk17").ToString)
            dr4("Renk18") = Trim(dr4("Renk18").ToString)
            dr4("Renk19") = Trim(dr4("Renk19").ToString)
            dr4("Renk20") = Trim(dr4("Renk20").ToString)
            dr4("Beden1") = Trim(dr4("Beden1").ToString)
            dr4("Beden2") = Trim(dr4("Beden2").ToString)
            dr4("Beden3") = Trim(dr4("Beden3").ToString)
            dr4("Beden4") = Trim(dr4("Beden4").ToString)
            dr4("Beden5") = Trim(dr4("Beden5").ToString)
            dr4("Beden6") = Trim(dr4("Beden6").ToString)
            dr4("Beden7") = Trim(dr4("Beden7").ToString)
            dr4("Beden8") = Trim(dr4("Beden8").ToString)
            dr4("Beden9") = Trim(dr4("Beden9").ToString)
            dr4("Beden10") = Trim(dr4("Beden10").ToString)
            dr4("Beden11") = Trim(dr4("Beden11").ToString)
            dr4("Beden12") = Trim(dr4("Beden12").ToString)
            dr4("Beden13") = Trim(dr4("Beden13").ToString)
            dr4("Beden14") = Trim(dr4("Beden14").ToString)
            dr4("Beden15") = Trim(dr4("Beden15").ToString)
            dr4("Beden16") = Trim(dr4("Beden16").ToString)
            dr4("Beden17") = Trim(dr4("Beden17").ToString)
            dr4("Beden18") = Trim(dr4("Beden18").ToString)
            dr4("Beden19") = Trim(dr4("Beden19").ToString)
            dr4("Beden20") = Trim(dr4("Beden20").ToString)
            dr4("barcode1") = Trim(dr4("barcode1").ToString)
            dr4("barcode2") = Trim(dr4("barcode2").ToString)
            dr4("barcode3") = Trim(dr4("barcode3").ToString)
            dr4("barcode4") = Trim(dr4("barcode4").ToString)
            dr4("barcode5") = Trim(dr4("barcode5").ToString)
            dr4("barcode6") = Trim(dr4("barcode6").ToString)
            dr4("barcode7") = Trim(dr4("barcode7").ToString)
            dr4("barcode8") = Trim(dr4("barcode8").ToString)
            dr4("barcode9") = Trim(dr4("barcode9").ToString)
            dr4("barcode10") = Trim(dr4("barcode10").ToString)
            dr4("barcode11") = Trim(dr4("barcode11").ToString)
            dr4("barcode12") = Trim(dr4("barcode12").ToString)
            dr4("barcode13") = Trim(dr4("barcode13").ToString)
            dr4("barcode14") = Trim(dr4("barcode14").ToString)
            dr4("barcode15") = Trim(dr4("barcode15").ToString)
            dr4("barcode16") = Trim(dr4("barcode16").ToString)
            dr4("barcode17") = Trim(dr4("barcode17").ToString)
            dr4("barcode18") = Trim(dr4("barcode18").ToString)
            dr4("barcode19") = Trim(dr4("barcode19").ToString)
            dr4("barcode20") = Trim(dr4("barcode20").ToString)
        Next
        Dim adapter1 As New OleDb.OleDbDataAdapter
        Dim cmd6 As New OleDb.OleDbCommand
        Dim con6 As New OleDb.OleDbConnection
        Dim dr5 As DataRow
        Dim DS5 As New DataSet

        con6.ConnectionString = connection
        con6.Open()
        cmd6.CommandText = "select nStokID, code, name, ISNULL(Renk1,0)as Renk1, ISNULL(Beden1,0) as Beden1,  ISNULL(barcode1,0) as barcode1,  ISNULL(Fiyat1,0) as Fiyat1,  ISNULL(quantity1,0) as quantity1,  ISNULL(Renk2,0) as Renk2,  ISNULL(Beden2,0) as Beden2,  ISNULL(barcode2,0) as barcode2,  ISNULL(Fiyat2,0) as Fiyat2,  ISNULL(quantity2,0) as quantity2,  ISNULL(Renk3,0) as Renk3,  ISNULL(Beden3,0) as Beden3,  ISNULL(barcode3,0) as barcode3,  ISNULL(Fiyat3,0) as Fiyat3,  ISNULL(quantity3,0) as quantity3,  ISNULL(Renk4,0) as Renk4,  ISNULL(Beden4,0) as Beden4,  ISNULL(barcode4,0) as barcode4,  ISNULL(Fiyat4,0) as Fiyat4,  ISNULL(quantity4,0) as quantity4,  ISNULL(Renk5,0) as Renk5, ISNULL(Beden5,0) as Beden5, ISNULL(barcode5,0) as barcode5, ISNULL(quantity5,0) as quantity5, ISNULL(Fiyat5,0) as Fiyat5, ISNULL(Renk6,0) as Renk6, ISNULL(Beden6,0) as Beden6, ISNULL(barcode6,0) as barcode6, ISNULL(Fiyat6,0) as Fiyat6, ISNULL(quantity6,0) as quantity6, ISNULL(Renk7,0) as Renk7, ISNULL(Beden7,0) as Beden7, ISNULL(barcode7,0) as barcode7, ISNULL(Fiyat7,0) as Fiyat7, ISNULL(quantity7,0) as quantity7, ISNULL(Renk8,0) as Renk8, ISNULL(Beden8,0) as Beden8, ISNULL(barcode8,0) as barcode8, ISNULL(Fiyat8,0) as Fiyat8, ISNULL(quantity8,0) as quantity8, ISNULL(Renk9,0) as Renk9, ISNULL(Beden9,0) as Beden9, ISNULL(barcode9,0) as barcode9, ISNULL(Fiyat9,0) as Fiyat9, ISNULL(quantity9,0) as quantity9, ISNULL(Renk10,0) as Renk10, ISNULL(Beden10,0) as Beden10, ISNULL(barcode10,0) as barcode10, ISNULL(Fiyat10,0) as Fiyat10, ISNULL(quantity10,0) as quantity10, ISNULL(Renk11,0) as Renk11, ISNULL(Beden11,0) as Beden11, ISNULL(barcode11,0) as barcode11, ISNULL(Fiyat11,0) as Fiyat11, ISNULL(quantity11,0) as quantity11, ISNULL(Renk12,0) as Renk12, ISNULL(Beden12,0) as Beden12, ISNULL(barcode12,0) as barcode12, ISNULL(Fiyat12,0) as Fiyat12, ISNULL(quantity12,0) as quantity12, ISNULL(Renk13,0) as Renk13, ISNULL(Beden13,0) as Beden13, ISNULL(barcode13,0) as barcode13, ISNULL(Fiyat13,0) as Fiyat13, ISNULL(quantity13,0) as quantity13, ISNULL(Renk14,0) as Renk14, ISNULL(Beden14,0) as Beden14, ISNULL(barcode14,0) as barcode14, ISNULL(Fiyat14,0) as Fiyat14, ISNULL(quantity14,0) as quantity14, ISNULL(Renk15,0) as Renk15, ISNULL(Beden15,0) as Beden15, ISNULL(barcode15,0) as barcode15, ISNULL(Fiyat15,0) as Fiyat15, ISNULL(quantity15,0) as quantity15, ISNULL(Renk16,0) as Renk16, ISNULL(Beden16,0) as Beden16, ISNULL(barcode16,0) as barcode16, ISNULL(Fiyat16,0) as Fiyat16, ISNULL(quantity16,0) as quantity16, ISNULL(Renk17,0) as Renk17, ISNULL(Beden17,0) as Beden17, ISNULL(barcode17,0) as barcode17, ISNULL(Fiyat17,0) as Fiyat17, ISNULL(quantity17,0) as quantity17, ISNULL(Renk18,0) as Renk18, ISNULL(Beden18,0) as Beden18, ISNULL(barcode18,0) as barcode18, ISNULL(Fiyat18,0) as Fiyat18, ISNULL(quantity18,0) as quantity18, ISNULL(Renk19,0) as Renk19, ISNULL(Beden19,0) as Beden19, ISNULL(barcode19,0) as barcode19, ISNULL(Fiyat19,0) as Fiyat19, ISNULL(quantity19,0) as quantity19, ISNULL(Renk20,0) as Renk20, ISNULL(Beden20,0) as Beden20, ISNULL(barcode20,0) as barcode20, ISNULL(Fiyat20,0) as Fiyat20, ISNULL(quantity20,0) as quantity20, ISNULL(brand,0) as brand, ISNULL(category1,0) as category1, ISNULL(category2,0) as category2, ISNULL(category3,0) as category3, ISNULL(category4,0) as category4, ISNULL(category5,0) as category5,ISNULL(longDescription,0) as longDescription, ISNULL(seoTitle,0) as seoTitle, ISNULL(seoKeywords,0) as seoKeywords, ISNULL(seoDescription,0) as seoDescription, ISNULL(variant1Name,0) as variant1Name, ISNULL(variant2Name,0) as variant2Name, ISNULL(taxRate,0) as taxRate, ISNULL(shipmentPayment,0) as shipmentPayment, ISNULL(buyPrice,0) as buyPrice, ISNULL(listPrice,0) as listPrice, ISNULL(salePrice,0) as salePrice, ISNULL(TysalePrice,0) as TysalePrice, ISNULL(N11salePrice,0) as N11salePrice, ISNULL(GgsalePrice,0) as GgsalePrice, ISNULL(HbsalePrice,0) as HbsalePrice, ISNULL(EpttsalePrice,0) as EpttsalePrice, ISNULL(CssalePrice,0) as CssalePrice, ISNULL(amzsalePrice,0) as amzsalePrice, ISNULL(NewsalePrice,0) as NewsalePrice, ISNULL(quantity,0) as quantity, ISNULL(imageUrl,0) as imageUrl, ISNULL(imageUrl1,0) as imageUrl1, ISNULL(imageUrl2,0) as imageUrl2, ISNULL(imageUrl3,0) as imageUrl3, ISNULL(imageUrl4,0) as imageUrl4, ISNULL(imageUrl5,0) as imageUrl5, ISNULL(imageUrl6,0) as imageUrl6, ISNULL(imageUrl7,0) as imageUrl7, ISNULL(imageUrl8,0) as imageUrl8, ISNULL(imageUrl9,0) as imageUrl9, ISNULL(imageUrl10,0) as imageUrl10, ISNULL(dteGuncelZaman,0) as dteGuncelZaman from tbStokEticaret Where Guncel = '0'"
        cmd6.Connection = con6
        adapter1.SelectCommand = cmd6
        Dim Z As Integer = adapter1.Fill(DS5, "Table1")

        For Each dr5 In DS5.Tables(0).Rows
            dr5("quantity1") = Trim(dr5("quantity1").ToString)
            dr5("quantity2") = Trim(dr5("quantity2").ToString)
            dr5("quantity3") = Trim(dr5("quantity3").ToString)
            dr5("quantity4") = Trim(dr5("quantity4").ToString)
            dr5("quantity5") = Trim(dr5("quantity5").ToString)
            dr5("quantity6") = Trim(dr5("quantity6").ToString)
            dr5("quantity7") = Trim(dr5("quantity7").ToString)
            dr5("quantity8") = Trim(dr5("quantity8").ToString)
            dr5("quantity9") = Trim(dr5("quantity9").ToString)
            dr5("quantity10") = Trim(dr5("quantity10").ToString)
            dr5("quantity11") = Trim(dr5("quantity11").ToString)
            dr5("quantity12") = Trim(dr5("quantity12").ToString)
            dr5("quantity13") = Trim(dr5("quantity13").ToString)
            dr5("quantity14") = Trim(dr5("quantity14").ToString)
            dr5("quantity15") = Trim(dr5("quantity15").ToString)
            dr5("quantity16") = Trim(dr5("quantity16").ToString)
            dr5("quantity17") = Trim(dr5("quantity17").ToString)
            dr5("quantity18") = Trim(dr5("quantity18").ToString)
            dr5("quantity19") = Trim(dr5("quantity19").ToString)
            dr5("quantity20") = Trim(dr5("quantity20").ToString)
            dr4("quantity21") = Trim(dr4("quantity21").ToString)
            dr4("quantity22") = Trim(dr4("quantity22").ToString)
            dr4("quantity23") = Trim(dr4("quantity23").ToString)
            dr4("quantity24") = Trim(dr4("quantity24").ToString)
            dr4("quantity25") = Trim(dr4("quantity25").ToString)
            dr4("quantity26") = Trim(dr4("quantity26").ToString)
            dr4("quantity27") = Trim(dr4("quantity27").ToString)
            dr4("quantity28") = Trim(dr4("quantity28").ToString)
            dr4("quantity29") = Trim(dr4("quantity29").ToString)
            dr4("quantity30") = Trim(dr4("quantity30").ToString)
            dr4("quantity31") = Trim(dr4("quantity31").ToString)
            dr4("quantity32") = Trim(dr4("quantity32").ToString)
            dr4("quantity33") = Trim(dr4("quantity33").ToString)
            dr4("quantity34") = Trim(dr4("quantity34").ToString)
            dr4("quantity35") = Trim(dr4("quantity35").ToString)
            dr4("quantity36") = Trim(dr4("quantity36").ToString)
            dr4("quantity37") = Trim(dr4("quantity37").ToString)
            dr4("quantity38") = Trim(dr4("quantity38").ToString)
            dr4("quantity39") = Trim(dr4("quantity39").ToString)
            dr4("quantity40") = Trim(dr4("quantity40").ToString)
            dr4("quantity41") = Trim(dr4("quantity41").ToString)
            dr4("quantity42") = Trim(dr4("quantity42").ToString)
            dr4("quantity43") = Trim(dr4("quantity43").ToString)
            dr4("quantity44") = Trim(dr4("quantity44").ToString)
            dr4("quantity45") = Trim(dr4("quantity45").ToString)
            dr4("quantity46") = Trim(dr4("quantity46").ToString)
            dr4("quantity47") = Trim(dr4("quantity47").ToString)
            dr4("quantity48") = Trim(dr4("quantity48").ToString)
            dr4("quantity49") = Trim(dr4("quantity49").ToString)
            dr4("quantity50") = Trim(dr4("quantity50").ToString)
            dr4("quantity51") = Trim(dr4("quantity51").ToString)
            dr4("quantity52") = Trim(dr4("quantity52").ToString)
            dr4("quantity53") = Trim(dr4("quantity53").ToString)
            dr4("quantity54") = Trim(dr4("quantity54").ToString)
            dr4("quantity55") = Trim(dr4("quantity55").ToString)
            dr4("quantity56") = Trim(dr4("quantity56").ToString)
            dr4("quantity57") = Trim(dr4("quantity57").ToString)
            dr4("quantity58") = Trim(dr4("quantity58").ToString)
            dr4("quantity59") = Trim(dr4("quantity59").ToString)
            dr4("quantity60") = Trim(dr4("quantity60").ToString)
            dr5("brand") = Trim(dr5("brand").ToString)

            If con1.State = ConnectionState.Closed Then
                con1.ConnectionString = connection
                cmd1.Connection = con1
                con1.Open()
            End If

            cmd1.CommandText = sorgu_queryJson("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT TOP 1 Product FROM tbParamGenel")
            ProductUpdate = cmd1.ExecuteScalar.ToString()
            con1.Close()
            ProductUpdate += "/api/v2/product/updatePrices"
            If con1.State = ConnectionState.Closed Then
                con1.ConnectionString = connection
                cmd1.Connection = con1
                con1.Open()
            End If
            cmd1.CommandText = sorgu_queryJson("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT TOP 1 ApiKey FROM tbParamGenel")
            ApiKey = cmd1.ExecuteScalar.ToString()
            con1.Close()
            If con1.State = ConnectionState.Closed Then
                con1.ConnectionString = connection
                cmd1.Connection = con1
                con1.Open()
            End If
            cmd1.CommandText = sorgu_queryJson("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT TOP 1 ApiSecret FROM tbParamGenel")
            ApiSecret = cmd1.ExecuteScalar.ToString()
            con1.Close()

            ' Dim Mydata As String = " {""products"": [{""code"": """ & dr4("code") & """,""currency"": ""TL"",""salePrice"": """ & dr4("salePrice") & """,""marketplacePrices"": [{""type"": ""n11"",""currency"": ""TL"",""price"": """ & dr4("N11salePrice") & """},{""type"": ""hb"",""currency"": ""TL"",""price"": """ & dr4("HbsalePrice") & """},{""type"": ""gg"",""currency"": ""TL"",""price"": """ & dr4("GgsalePrice") & """},{""type"": ""eptt"",""currency"": ""TL"",""price"": """ & dr4("EpttsalePrice") & """},{""type"": ""amz"",""currency"": ""TL"",""price"": """ & dr4("AmzsalePrice") & """},{""type"": ""ty"",""currency"": ""TL"",""price"": """ & dr4("TysalePrice") & """},{""type"": ""cs"",""currency"": ""TL"",""price"": """ & dr4("CssalePrice") & """}],""variants"": [{""barcode"": """ & dr4("barcode1") & """,""priceStatus"": ""1"",""price"": """ & dr4("fiyat1") & """},{""barcode"": """ & dr4("barcode2") & """,""priceStatus"": ""1"",""price"": """ & dr4("fiyat2") & """},{""barcode"": """ & dr4("barcode3") & """,""priceStatus"": ""1"",""price"": """ & dr4("fiyat3") & """},{""barcode"": """ & dr4("barcode4") & """,""priceStatus"": ""1"",""price"": """ & dr4("fiyat4") & """},{""barcode"": """ & dr4("barcode5") & """,""priceStatus"": ""1"",""price"": """ & dr4("fiyat5") & """},{""barcode"": """ & dr4("barcode6") & """,""priceStatus"": ""1"",""price"": """ & dr4("fiyat6") & """},{""barcode"": """ & dr4("barcode7") & """,""priceStatus"": ""1"",""price"": """ & dr4("fiyat7") & """},{""barcode"": """ & dr4("barcode8") & """,""priceStatus"": ""1"",""price"": """ & dr4("fiyat8") & """},{""barcode"": """ & dr4("barcode9") & """,""priceStatus"": ""1"",""price"": """ & dr4("fiyat9") & """},{""barcode"": """ & dr4("barcode10") & """,""priceStatus"": ""1"",""price"": """ & dr4("fiyat10") & """},{""barcode"": """ & dr4("barcode11") & """,""priceStatus"": ""1"",""price"": """ & dr4("fiyat11") & """},{""barcode"": """ & dr4("barcode12") & """,""priceStatus"": ""1"",""price"": """ & dr4("fiyat12") & """},{""barcode"": """ & dr4("barcode13") & """,""priceStatus"": ""1"",""price"": """ & dr4("fiyat13") & """},{""barcode"": """ & dr4("barcode14") & """,""priceStatus"": ""1"",""price"": """ & dr4("fiyat14") & """},{""barcode"": """ & dr4("barcode15") & """,""priceStatus"": ""1"",""price"": """ & dr4("fiyat15") & """},{""barcode"": """ & dr4("barcode16") & """,""priceStatus"": ""1"",""price"": """ & dr4("fiyat16") & """},{""barcode"": """ & dr4("barcode17") & """,""priceStatus"": ""1"",""price"": """ & dr4("fiyat17") & """},{""barcode"": """ & dr4("barcode18") & """,""priceStatus"": ""1"",""price"": """ & dr4("fiyat18") & """},{""barcode"": """ & dr4("barcode19") & """,""priceStatus"": ""1"",""price"": """ & dr4("fiyat19") & """},{""barcode"": """ & dr4("barcode20") & """,""priceStatus"": ""1"",""price"": """ & dr4("fiyat20") & """}]}]}"
            Dim Mydata As String = " {""products"": [{""code"": """ & dr4("code") & """,""currency"": ""TL"",""salePrice"": """ & dr4("salePrice") & """,""marketplacePrices"": [{""type"": ""n11"",""currency"": ""TL"",""price"": """ & dr4("N11salePrice") & """},{""type"": ""hb"",""currency"": ""TL"",""price"": """ & dr4("HbsalePrice") & """},{""type"": ""gg"",""currency"": ""TL"",""price"": """ & dr4("GgsalePrice") & """},{""type"": ""eptt"",""currency"": ""TL"",""price"": """ & dr4("EpttsalePrice") & """},{""type"": ""amz"",""currency"": ""TL"",""price"": """ & dr4("AmzsalePrice") & """},{""type"": ""ty"",""currency"": ""TL"",""price"": """ & dr4("TysalePrice") & """},{""type"": ""cs"",""currency"": ""TL"",""price"": """ & dr4("CssalePrice") & """}],""variants"": [{""barcode"": """ & dr4("barcode1") & """,""priceStatus"": ""1"",""price"": """ & dr4("fiyat1") & """},{""barcode"": """ & dr4("barcode2") & """,""priceStatus"": ""1"",""price"": """ & dr4("fiyat2") & """},{""barcode"": """ & dr4("barcode3") & """,""priceStatus"": ""1"",""price"": """ & dr4("fiyat3") & """},{""barcode"": """ & dr4("barcode4") & """,""priceStatus"": ""1"",""price"": """ & dr4("fiyat4") & """},{""barcode"": """ & dr4("barcode5") & """,""priceStatus"": ""1"",""price"": """ & dr4("fiyat5") & """},{""barcode"": """ & dr4("barcode6") & """,""priceStatus"": ""1"",""price"": """ & dr4("fiyat6") & """},{""barcode"": """ & dr4("barcode7") & """,""priceStatus"": ""1"",""price"": """ & dr4("fiyat7") & """},{""barcode"": """ & dr4("barcode8") & """,""priceStatus"": ""1"",""price"": """ & dr4("fiyat8") & """},{""barcode"": """ & dr4("barcode9") & """,""priceStatus"": ""1"",""price"": """ & dr4("fiyat9") & """},{""barcode"": """ & dr4("barcode10") & """,""priceStatus"": ""1"",""price"": """ & dr4("fiyat10") & """},{""barcode"": """ & dr4("barcode11") & """,""priceStatus"": ""1"",""price"": """ & dr4("fiyat11") & """},{""barcode"": """ & dr4("barcode12") & """,""priceStatus"": ""1"",""price"": """ & dr4("fiyat12") & """},{""barcode"": """ & dr4("barcode13") & """,""priceStatus"": ""1"",""price"": """ & dr4("fiyat13") & """},{""barcode"": """ & dr4("barcode14") & """,""priceStatus"": ""1"",""price"": """ & dr4("fiyat14") & """},{""barcode"": """ & dr4("barcode15") & """,""priceStatus"": ""1"",""price"": """ & dr4("fiyat15") & """},{""barcode"": """ & dr4("barcode16") & """,""priceStatus"": ""1"",""price"": """ & dr4("fiyat16") & """},{""barcode"": """ & dr4("barcode17") & """,""priceStatus"": ""1"",""price"": """ & dr4("fiyat17") & """},{""barcode"": """ & dr4("barcode18") & """,""priceStatus"": ""1"",""price"": """ & dr4("fiyat18") & """},{""barcode"": """ & dr4("barcode19") & """,""priceStatus"": ""1"",""price"": """ & dr4("fiyat19") & """},{""barcode"": """ & dr4("barcode20") & """,""priceStatus"": ""1"",""price"": """ & dr4("fiyat20") & """},{""barcode"": """ & dr4("barcode21") & """,""priceStatus"": ""1"",""price"": """ & dr4("fiyat21") & """},{""barcode"": """ & dr4("barcode22") & """,""priceStatus"": ""1"",""price"": """ & dr4("fiyat22") & """},{""barcode"": """ & dr4("barcode23") & """,""priceStatus"": ""1"",""price"": """ & dr4("fiyat23") & """},{""barcode"": """ & dr4("barcode24") & """,""priceStatus"": ""1"",""price"": """ & dr4("fiyat24") & """},{""barcode"": """ & dr4("barcode25") & """,""priceStatus"": ""1"",""price"": """ & dr4("fiyat25") & """},{""barcode"": """ & dr4("barcode26") & """,""priceStatus"": ""1"",""price"": """ & dr4("fiyat26") & """},{""barcode"": """ & dr4("barcode27") & """,""priceStatus"": ""1"",""price"": """ & dr4("fiyat27") & """},{""barcode"": """ & dr4("barcode28") & """,""priceStatus"": ""1"",""price"": """ & dr4("fiyat28") & """},{""barcode"": """ & dr4("barcode29") & """,""priceStatus"": ""1"",""price"": """ & dr4("fiyat29") & """},{""barcode"": """ & dr4("barcode30") & """,""priceStatus"": ""1"",""price"": """ & dr4("fiyat30") & """},{""barcode"": """ & dr4("barcode31") & """,""priceStatus"": ""1"",""price"": """ & dr4("fiyat31") & """},{""barcode"": """ & dr4("barcode32") & """,""priceStatus"": ""1"",""price"": """ & dr4("fiyat32") & """},{""barcode"": """ & dr4("barcode33") & """,""priceStatus"": ""1"",""price"": """ & dr4("fiyat33") & """},{""barcode"": """ & dr4("barcode34") & """,""priceStatus"": ""1"",""price"": """ & dr4("fiyat34") & """},{""barcode"": """ & dr4("barcode35") & """,""priceStatus"": ""1"",""price"": """ & dr4("fiyat35") & """},{""barcode"": """ & dr4("barcode36") & """,""priceStatus"": ""1"",""price"": """ & dr4("fiyat36") & """},{""barcode"": """ & dr4("barcode37") & """,""priceStatus"": ""1"",""price"": """ & dr4("fiyat37") & """},{""barcode"": """ & dr4("barcode38") & """,""priceStatus"": ""1"",""price"": """ & dr4("fiyat38") & """},{""barcode"": """ & dr4("barcode39") & """,""priceStatus"": ""1"",""price"": """ & dr4("fiyat39") & """},{""barcode"": """ & dr4("barcode40") & """,""priceStatus"": ""1"",""price"": """ & dr4("fiyat40") & """},{""barcode"": """ & dr4("barcode41") & """,""priceStatus"": ""1"",""price"": """ & dr4("fiyat41") & """},{""barcode"": """ & dr4("barcode42") & """,""priceStatus"": ""1"",""price"": """ & dr4("fiyat42") & """},{""barcode"": """ & dr4("barcode43") & """,""priceStatus"": ""1"",""price"": """ & dr4("fiyat43") & """},{""barcode"": """ & dr4("barcode44") & """,""priceStatus"": ""1"",""price"": """ & dr4("fiyat44") & """},{""barcode"": """ & dr4("barcode45") & """,""priceStatus"": ""1"",""price"": """ & dr4("fiyat45") & """},{""barcode"": """ & dr4("barcode46") & """,""priceStatus"": ""1"",""price"": """ & dr4("fiyat46") & """},{""barcode"": """ & dr4("barcode47") & """,""priceStatus"": ""1"",""price"": """ & dr4("fiyat47") & """},{""barcode"": """ & dr4("barcode48") & """,""priceStatus"": ""1"",""price"": """ & dr4("fiyat48") & """},{""barcode"": """ & dr4("barcode49") & """,""priceStatus"": ""1"",""price"": """ & dr4("fiyat49") & """},{""barcode"": """ & dr4("barcode50") & """,""priceStatus"": ""1"",""price"": """ & dr4("fiyat50") & """},{""barcode"": """ & dr4("barcode51") & """,""priceStatus"": ""1"",""price"": """ & dr4("fiyat51") & """},{""barcode"": """ & dr4("barcode52") & """,""priceStatus"": ""1"",""price"": """ & dr4("fiyat52") & """},{""barcode"": """ & dr4("barcode53") & """,""priceStatus"": ""1"",""price"": """ & dr4("fiyat53") & """},{""barcode"": """ & dr4("barcode54") & """,""priceStatus"": ""1"",""price"": """ & dr4("fiyat54") & """},{""barcode"": """ & dr4("barcode55") & """,""priceStatus"": ""1"",""price"": """ & dr4("fiyat55") & """},{""barcode"": """ & dr4("barcode56") & """,""priceStatus"": ""1"",""price"": """ & dr4("fiyat56") & """},{""barcode"": """ & dr4("barcode57") & """,""priceStatus"": ""1"",""price"": """ & dr4("fiyat57") & """},{""barcode"": """ & dr4("barcode58") & """,""priceStatus"": ""1"",""price"": """ & dr4("fiyat58") & """},{""barcode"": """ & dr4("barcode59") & """,""priceStatus"": ""1"",""price"": """ & dr4("fiyat59") & """},{""barcode"": """ & dr4("barcode60") & """,""priceStatus"": ""1"",""price"": """ & dr4("fiyat60") & """}]}]}"
            Dim myReq1 As HttpWebRequest
            Dim myResp1 As HttpWebResponse
            Dim myReader1 As StreamReader

            myReq1 = HttpWebRequest.Create(ProductUpdate)
            myReq1.Method = "POST"

            myReq1.ContentType = "application/json"
            myReq1.Accept = "application/json"
            myReq1.Headers.Add("apikey", "" & ApiKey & "")
            myReq1.Headers.Add("apisecret", "" & ApiSecret & "")
            Try

                Dim stream1 As Stream = myReq1.GetRequestStream()
                stream1.Write(System.Text.Encoding.UTF8.GetBytes(Mydata), 0, System.Text.Encoding.UTF8.GetBytes(Mydata).Length)
                stream1.Close()
                myResp1 = myReq1.GetResponse
                myReader1 = New System.IO.StreamReader(myResp1.GetResponseStream)
                Print(myReader1.ReadToEnd)

            Catch ex As Exception
                'MessageBox.Show("Cevap: " & ex.Message)
                ' MessageBox.Show(String.Format("Aktarým Baþarý ile Tamamlandý", ex.Message))

            End Try
            If con1.State = ConnectionState.Closed Then
                con1.ConnectionString = connection
                cmd1.Connection = con1
                con1.Open()
            End If
            cmd1.CommandText = sorgu_queryJson("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED Update tbStokEticaret Set Guncel = '1' where nStokID = " & dr4("nStokID") & "")
            cmd1.ExecuteNonQuery()
            con1.Close()
        Next
        'MessageBox.Show(String.Format("Aktarým Baþarý ile Tamamlandý"))
        '' JSON BÝTÝÞ

        ''End If
    End Sub
    Private Function tbStok_kaydet_Eticaret1(ByVal nStokID As String, ByVal code As String, ByVal name1 As String, ByVal Renk1 As String, ByVal Beden1 As String, ByVal barcode As String, ByVal brand As String, ByVal category1 As String, ByVal category2 As String, ByVal category3 As String, ByVal category4 As String, ByVal category5 As String, ByVal longDescription As String, ByVal buyPrice As String, ByVal listPrice As String, ByVal salePrice As String, ByVal seoTitle As String, ByVal seoKeywords As String, ByVal taxRate As String, ByVal quantity As String, ByVal seoDescription As String, ByVal variant1Name As String, ByVal variant2Name As String, ByVal imageUrl As String, ByVal imageUrl1 As String, ByVal imageUrl2 As String, ByVal imageUrl3 As String, ByVal imageUrl4 As String, ByVal imageUrl5 As String, ByVal imageUrl6 As String, ByVal imageUrl7 As String, ByVal imageUrl8 As String, ByVal imageUrl9 As String, ByVal imageUrl10 As String, ByVal TysalePrice As String, ByVal N11salePrice As String, ByVal GgsalePrice As String, ByVal HbsalePrice As String, ByVal EpttsalePrice As String, ByVal CssalePrice As String, ByVal AmzsalePrice As String) As Decimal

        Dim con As New OleDb.OleDbConnection
        Dim cmd As New OleDb.OleDbCommand
        cmd.Connection = con
        con.ConnectionString = connection
        cmd.CommandTimeout = False
        If con.State = ConnectionState.Closed = True Then
            con.Open()
        End If
        cmd.CommandText = sorgu_queryJson("SET DATEFORMAT DMY SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED INSERT INTO tbStokEticaret (nStokID, code, name, Renk1, Beden1, barcode1,Fiyat1,quantity1, brand, category1, category2, category3, category4,category5,longDescription, buyPrice, listPrice, salePrice, seoTitle, seoKeywords, taxRate, quantity,seoDescription,variant1Name,variant2Name,imageUrl,imageUrl1,imageUrl2,imageUrl3,imageUrl4,imageUrl5,imageUrl6,imageUrl7,imageUrl8,imageUrl9,imageUrl10, TysalePrice, N11salePrice, GgsalePrice, HbsalePrice, EpttsalePrice, CssalePrice, AmzsalePrice,Guncel ) VALUES     ('" & nStokID & "', N'" & code & "', '" & name1 & "', '" & Renk1 & "', '" & Beden1 & "', '" & barcode & "','" & salePrice & "', " & quantity & ",'" & brand & "', '" & category1 & "', '" & category2 & "', '" & category3 & "', '" & category4 & "', '" & category5 & "','" & longDescription & "', '" & buyPrice & "','" & listPrice & "', '" & salePrice & "', '" & seoTitle & "','" & seoKeywords & "', '" & taxRate & "', '" & quantity & "', '" & seoDescription & "', '" & variant1Name & "', '" & variant2Name & "', '" & imageUrl & "', '" & imageUrl1 & "', '" & imageUrl2 & "', '" & imageUrl3 & "', '" & imageUrl4 & "', '" & imageUrl5 & "', '" & imageUrl6 & "', '" & imageUrl7 & "', '" & imageUrl8 & "', '" & imageUrl9 & "', '" & imageUrl10 & "', '" & TysalePrice & "', '" & N11salePrice & "', '" & GgsalePrice & "', '" & HbsalePrice & "', '" & EpttsalePrice & "', '" & CssalePrice & "', '" & AmzsalePrice & "','0')")
        cmd.ExecuteNonQuery()
        'cmd.CommandText = "SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT @@identity"
        'Dim kayitno = cmd.ExecuteScalar
        con.Close()
        Return kayitno
        cmd = Nothing
        con = Nothing
    End Function
    Public Sub Siparis_olustur()
        Dim cmd1 As New OleDb.OleDbCommand
        Dim con1 As New OleDb.OleDbConnection

        Dim SorSiparis = ""
        Dim SorMusteri = ""
        Dim MusteriNo = "120990001"
        Dim MusteriHesapID = ""

        Dim Siparisid = ""
        Dim Sipariscode = ""
        Dim SiparisDurumu = ""
        Dim KargoFirmaID = ""
        Dim KargoFirmaAdi = ""
        Dim Kargofirmaverginumarasi = ""
        Dim Kargobarkodu = ""
        Dim Kargotakipkodu = ""
        Dim KargotakipURL = ""
        Dim Kargodurumu = ""
        Dim Kargotarihi = ""
        Dim Siparistarihi As DateTime
        Dim Siparisguncellenmetarihi As DateTime
        Dim Efaturanumarasi = ""
        Dim Siparisplatformu = ""
        Dim SiparisplatformURL = ""
        Dim Odemetipi = ""
        Dim Musteriadisoyadi = ""
        Dim MüþteriUnvani = ""
        Dim Vergidairesi = ""
        Dim Verginumarasi = ""
        Dim Teslimatadresi = ""
        Dim Teslimatilcesi = ""
        Dim Teslimatili = ""
        Dim Faturaadresi = ""
        Dim Faturailcesi = ""
        Dim Faturaili = ""
        Dim Telefonnumarasi = ""
        Dim Epostaadresi = ""
        Dim Siparistutari = ""
        Dim Indirimtutari = ""
        Dim Siparisaratoplam = ""
        Dim KDVorani = ""
        Dim KDVtutar = ""
        Dim Siparisgeneltoplamtutari = ""
        Dim Urunkodu = ""
        Dim Urunadi = ""
        Dim Urunbarkodu = ""
        Dim Varyantadi = ""
        Dim Varyantdegeri = ""
        Dim VaryantadiC = ""
        Dim VaryantdegeriC = ""
        Dim UrunMiktari = ""
        Dim UrunFiyati = ""
        Dim UrunTutari = ""
        Dim adapter As New OleDb.OleDbDataAdapter
        Dim cmd5 As New OleDb.OleDbCommand
        Dim con5 As New OleDb.OleDbConnection
        Dim dr5 As DataRow
        Dim DS5 As New DataSet
        Dim KdwTipi = ""
        Dim Kdw = ""
        Dim StokID = ""
        Dim StokIsmi = ""

        con5.ConnectionString = connection
        con5.Open()
        cmd5.CommandText = "SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT * FROM tbESiparisDetay Where Guncel = '0'"
        cmd5.Connection = con5
        adapter.SelectCommand = cmd5
        Dim N As Integer = adapter.Fill(DS5, "Table1")

        For Each dr5 In DS5.Tables(0).Rows

            Siparisid = dr5("Siparisid")
            Sipariscode = dr5("Sipariscode")
            SiparisDurumu = dr5("SiparisDurumu")
            KargoFirmaID = dr5("KargoFirmaID")
            KargoFirmaAdi = dr5("KargoFirmaAdi")
            Kargofirmaverginumarasi = dr5("Kargofirmaverginumarasi")
            Kargobarkodu = dr5("Kargobarkodu")
            Kargotakipkodu = dr5("Kargotakipkodu")
            KargotakipURL = dr5("KargotakipURL")
            Kargodurumu = dr5("Kargodurumu")
            Kargotarihi = dr5("Kargotarihi")
            Siparistarihi = dr5("Siparistarihi")
            Siparisguncellenmetarihi = dr5("Siparisguncellenmetarihi")
            Efaturanumarasi = dr5("Efaturanumarasi")
            Siparisplatformu = dr5("Siparisplatformu")
            SiparisplatformURL = dr5("SiparisplatformURL")
            Odemetipi = dr5("Odemetipi")
            Musteriadisoyadi = dr5("Musteriadisoyadi")
            MüþteriUnvani = dr5("MüþteriUnvani")
            Vergidairesi = dr5("Vergidairesi")
            Verginumarasi = dr5("Verginumarasi")
            Teslimatadresi = dr5("Teslimatadresi")
            Teslimatilcesi = dr5("Teslimatilcesi")
            Teslimatili = dr5("Teslimatili")
            Faturaadresi = dr5("Faturaadresi")
            Faturailcesi = dr5("Faturailcesi")
            Faturaili = dr5("Faturaili")
            Telefonnumarasi = dr5("Telefonnumarasi")
            Epostaadresi = dr5("Epostaadresi")
            Siparistutari = dr5("Siparistutari")
            Indirimtutari = dr5("Indirimtutari")
            Siparisaratoplam = dr5("Siparisaratoplam")
            KDVorani = dr5("KDVorani")
            KDVtutar = dr5("KDVtutar")
            Siparisgeneltoplamtutari = dr5("Siparisgeneltoplamtutari")
            Urunkodu = dr5("Urunkodu")
            Urunadi = dr5("Urunadi")
            Urunbarkodu = dr5("Urunbarkodu")
            Varyantadi = dr5("Varyantadi")
            Varyantdegeri = dr5("Varyantdegeri")
            VaryantadiC = dr5("VaryantadiC")
            VaryantdegeriC = dr5("VaryantdegeriC")
            UrunMiktari = dr5("UrunMiktari")
            UrunFiyati = dr5("UrunFiyati")
            UrunTutari = dr5("UrunTutari")

            If con1.State = ConnectionState.Closed Then
                con1.ConnectionString = connection
                cmd1.Connection = con1
                con1.Open()
            End If
            cmd1.CommandText = sorgu_queryJson("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT ISNULL(COUNT(sIletisimAdresi), 0) AS nKayit FROM tbFirmaIletisimi WHERE (sIletisimAraci = 'E-Mail' and sIletisimAdresi = '" & Epostaadresi & "') and nFirmaID <> 0 ")
            SorMusteri = cmd1.ExecuteScalar.ToString()
            cmd1.CommandText = sorgu_queryJson("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT ISNULL (max(RTRIM(sKodu)),0) AS nKayit FROM tbFirma where sKodu Like '12099%'")
            MusteriNo = cmd1.ExecuteScalar.ToString()
            MusteriNo = Trim(MusteriNo)
            'If MusteriNo = "0" Then
            '    MusteriNo = Trim(MusteriNo) + 1
            'Else
            '    MusteriNo = "120990001"
            'End If
            cmd1.CommandText = sorgu_queryJson("SET DATEFORMAT DMY SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT     ISNULL(nHesapID, 0) AS nHesapID  FROM         tbHesapPlani Where sKodu = '0'")
            MusteriHesapID = cmd1.ExecuteScalar.ToString()
            If MusteriNo >= "120990001" And SorMusteri = 0 Then
                MusteriNo = Trim(MusteriNo) + 1
            ElseIf MusteriNo < "120990001" Then
                MusteriNo = "120990001"

            End If
            If SorMusteri = 0 Then
                'müþteri Kayýt
                cmd1.CommandText = sorgu_queryJson("SET DATEFORMAT DMY SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED INSERT INTO tbFirma (sKodu, sAciklama, TC, nOzelIskontosu, lKrediLimiti, dteMutabakatTarihi, nVadeGun, sHitap, sAdres1, sAdres2, sSemt, sIl, sUlke, sPostaKodu, sVergiDairesi, sVergiNo, nHesapID, sOzelNot, sKullaniciAdi, dteKayitTarihi, sFiyatTipi,sSaticiRumuzu,nOzelIskontosu2,nOzelIskontosu3,nOzelIskontosu4,bAktif,bSatisYapilamaz,bSipariseKapali, bTahsilatYapilamaz,sDovizCinsi,nEnlem,nBoylam,nZiyaret,nPeriyod,sDepo, sCariHesapTuru, sEfatura) VALUES ('" & MusteriNo & "', N'" & Musteriadisoyadi & "', '" & Verginumarasi & "', 0.00, 0.00, '" & DateTime.Now & "', 0, N'Sayýn', N'" & Faturaadresi & "', N' ', N'" & Faturailcesi & "', N'" & Faturaili & "', N' ', N'', N'" & Vergidairesi & "', N'" & Verginumarasi & "', '" & MusteriHesapID & "', N'0000000', 'sa', '" & DateTime.Now & "' , N'WEBP',N'    ',0.00,0.00,0.00,1,0, 0, 0,N'   ',0.00000000,0.00000000,0000000,0,N'D001', 'webCari','False')")
                cmd1.ExecuteNonQuery()
                cmd1.CommandText = sorgu_queryJson("SET DATEFORMAT DMY SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT     ISNULL(nFirmaID, 0) AS nFirmaID  FROM         tbFirma Where sKodu = '" & MusteriNo & "'")
                MusteriHesapID = cmd1.ExecuteScalar.ToString()
                cmd1.CommandText = sorgu_queryJson("SET DATEFORMAT DMY SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED INSERT INTO tbFirmaIletisimi (nFirmaID, sIletisimAraci, sIletisimAdresi) VALUES     ('" & MusteriHesapID & "', 'Telefon', '" & Telefonnumarasi & "')")
                cmd1.ExecuteNonQuery()
                cmd1.CommandText = sorgu_queryJson("SET DATEFORMAT DMY SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED INSERT INTO tbFirmaIletisimi (nFirmaID, sIletisimAraci, sIletisimAdresi) VALUES     ('" & MusteriHesapID & "', 'E-Mail','" & Epostaadresi & "' )")
                cmd1.ExecuteNonQuery()
                cmd1.CommandText = sorgu_queryJson("SET DATEFORMAT DMY SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED INSERT INTO tbFirmaAdresi (nFirmaID, sAciklama, sAdres1, sAdres2, sSemt, sIl, sUlke, sPostaKodu, sVergiDairesi, sVergiNo, sSubeMagaza,sTelefon1,sTelefon2,sTelefon3,sFaks,sMail) VALUES     ('" & MusteriHesapID & "', N'" & Musteriadisoyadi & "','" & Teslimatadresi & "','','" & Teslimatilcesi & "','" & Teslimatili & "', 'Turkey', '','" & Vergidairesi & "' ,'" & Verginumarasi & "', '', '" & Telefonnumarasi & "','','','','" & Epostaadresi & "')")
                cmd1.ExecuteNonQuery()
                cmd1.CommandText = sorgu_queryJson("SET DATEFORMAT DMY SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED INSERT INTO tbFirmaSinifi (nFirmaID, sSinifKodu1, sSinifKodu2, sSinifKodu3, sSinifKodu4, sSinifKodu5) VALUES     ('" & MusteriHesapID & "', '','','','','')")
                cmd1.ExecuteNonQuery()
            Else
                cmd1.CommandText = sorgu_queryJson("SET DATEFORMAT DMY SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT     ISNULL(nFirmaID, 0) AS nFirmaID  FROM         tbFirma Where sKodu = '" & MusteriNo & "'")
                MusteriHesapID = cmd1.ExecuteScalar.ToString()
            End If
            con5.Close()


            If con1.State = ConnectionState.Closed Then
                con1.ConnectionString = connection
                cmd1.Connection = con1
                con1.Open()
            End If
            cmd1.CommandText = sorgu_queryJson("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT  COUNT (lSiparisNo) FROM tbSiparis where lSiparisNo = '" & Sipariscode & "' ")
            SorSiparis = cmd1.ExecuteScalar.ToString()





            'If SorSiparis >= 0 Then
            Dim cmd6 As New OleDb.OleDbCommand
            Dim con6 As New OleDb.OleDbConnection
            Dim dr6 As DataRow
            Dim DS6 As New DataSet

            con6.ConnectionString = connection
            con6.Open()
            cmd6.CommandText = "SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT     *, lOzelFiyat = CASE WHEN lCariFiyat <> 0 THEN lCariFiyat WHEN lUstFiyat = 0 THEN lFiyat1 ELSE lUstFiyat END FROM         (SELECT tbStok.*, tbStokBarkodu.sBarkod AS sBarkod, ISNULL((SELECT isnull(lfiyat , 0) FROM tbstokfiyati WHERE nStokId = tbStok.NstokId And sFiyatTipi = '1'), 0) AS lFiyat1, ISNULL((SELECT isnull(lfiyat , 0) FROM tbstokfiyati WHERE nStokId = tbStok.NstokId AND sFiyatTipi = '2'), 0) AS lFiyat2, ISNULL((SELECT isnull(lfiyat , 0) FROM tbstokfiyati WHERE nStokId = tbStok.NstokId AND sFiyatTipi = '3'), 0) AS lFiyat3, ISNULL((SELECT isnull(lfiyat , 0) FROM tbstokfiyati WHERE nStokId = tbStok.NstokId AND sFiyatTipi = 'M'), 0) AS MALIYET, ISNULL((SELECT isnull(lfiyat , 0) FROM tbstokfiyati WHERE nStokId = tbstok.NstokId AND sFiyatTipi = ''),0) AS lAltFiyat,ISNULL((SELECT isnull(lfiyat , 0) FROM tbstokfiyati WHERE nStokId = tbStok.NstokId AND sFiyatTipi = 'A'), 0) AS ALISFIYATI,ISNULL((SELECT isnull(lfiyat , 0) FROM tbstokfiyati WHERE nStokId = tbStok.NstokId AND sFiyatTipi = '3'), 0) AS lCariFiyat,ISNULL((SELECT isnull(lfiyat , 0) FROM tbstokfiyati WHERE nStokId = tbStok.NstokId AND sFiyatTipi = '3'), 0) AS lUstFiyat,(SELECT nKdvOrani FROM tbKdv WHERE sKdvTipi = tbStok.sKdvTipi) AS nKdvOrani, ISNULL((SELECT     ISNULL(lOran, 0) FROM         tbStokBirimCevrimi WHERE     nStokID = tbStok.nStokID AND sBirimCinsi = tbStok.sBirimCinsi2), 1) AS nBirimCarpan,(SELECT sRenkAdi FROM tbRenk WHERE sRenk = tbStok.sRenk) AS sRenkAdi, (SELECT sSinifKodu1 FROM tbStokSinifi WHERE nStokID = tbStok.nStokID) AS sSinifKodu1,CAST(0 AS Money) AS lMiktar FROM tbStok INNER JOIN tbStokBarkodu ON tbStok.nStokID = tbStokBarkodu.nStokID AND tbStokBarkodu.nKisim =0  WHERE tbStok.nStokID IN (Select nStokID from tbStokBarkodu Where sBarkod  LIKE '" & Urunbarkodu & "%' )) tbStoklar ORDER BY sKodu "
            cmd6.Connection = con6
            adapter.SelectCommand = cmd6
            Dim X As Integer = adapter.Fill(DS6, "Table1")

            For Each dr6 In DS6.Tables(0).Rows

                StokID = dr6("nStokID")
                StokIsmi = dr6("sAciklama")
                KdwTipi = dr6("sKdvTipi")
                cmd1.CommandText = sorgu_queryJson("SELECT nKdvOrani from tbKdv where sKdvTipi = '" & KdwTipi & "'")
                Kdw = cmd1.ExecuteScalar.ToString()

            Next
            cmd1.CommandText = sorgu_queryJson("SET DATEFORMAT DMY SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED INSERT INTO tbSiparis ( nSiparisTipi, lSiparisNo, nFirmaID, nStokID, dteSiparisTarihi, dteTeslimTarihi, sSiparisIslem, nReceteNo, sSiparisiAlan, sSiparisiVeren,sFiyatTipi, lMiktari, lFiyati, lTutari, sAsortiTipi, sAsortiMiktari, nKdvOrani, nIskontoYuzdesi, lIskontosuzTutari, sKullaniciAdi, dteKayitTarihi, bKapandimi, lReserveMiktari, sHangiUygulama, nPartiID, sSatirAciklama, nValorGun, sDovizCinsi, lDovizFiyati, lDovizKuru,sSaticiRumuzu,sDepo,sBirimCinsi,lBirimMiktar,sAmbalaj) VALUES     ( 1,'" & Sipariscode & "' , '" & MusteriHesapID & "', '" & StokID & "', '" & DateTime.Today & "', '" & Siparistarihi & "', '', 0, '" & Siparisplatformu & "', 'E-Ticaret', 'WEBP', '" & UrunMiktari & "','" & UrunFiyati & "','" & UrunTutari & "', '', 0, '" & Kdw & "', 0, '" & UrunTutari & "', '" & Siparisplatformu & "', '" & Siparisguncellenmetarihi & "', 0, 0, '', 0, 'Isk1:00.00 Isk2:00.00 Isk3:00.00 Isk4:00.00', 0, '', 0, 0,'100','D001','AD ',1,'AD ')")
            cmd1.ExecuteNonQuery()
            'sipariþ insert
            'Else
            '    cmd1.CommandText = sorgu_query("SET DATEFORMAT DMY SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED INSERT INTO tbSiparis ( nSiparisTipi, lSiparisNo, nFirmaID, nStokID, dteSiparisTarihi, dteTeslimTarihi, sSiparisIslem, nReceteNo, sSiparisiAlan, sSiparisiVeren,sFiyatTipi, lMiktari, lFiyati, lTutari, sAsortiTipi, sAsortiMiktari, nKdvOrani, nIskontoYuzdesi, lIskontosuzTutari, sKullaniciAdi, dteKayitTarihi, bKapandimi, lReserveMiktari, sHangiUygulama, nPartiID, sSatirAciklama, nValorGun, sDovizCinsi, lDovizFiyati, lDovizKuru,sSaticiRumuzu,sDepo,sBirimCinsi,lBirimMiktar,sAmbalaj) VALUES     ( 1,'" & Sipariscode & "' , '" & MusteriHesapID & "', '" & StokID & "', '" & DateTime.Today & "', '" & Siparistarihi & "', '', 0, '" & Siparisplatformu & "', 'E-Ticaret', 'WEBP', '" & UrunMiktari & "','" & UrunFiyati & "','" & UrunTutari & "', '', 0, '" & Kdw & "', 0, '" & UrunTutari & "', '" & Siparisplatformu & "', '" & Siparisguncellenmetarihi & "', 0, 0, '', 0, 'Isk1:00.00 Isk2:00.00 Isk3:00.00 Isk4:00.00', 0, '', 0, 0,'100','D001','AD ',1,'AD ')")
            '    cmd1.ExecuteNonQuery()
            'End If
            cmd1.CommandText = sorgu_queryJson("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED Update tbESiparisDetay SET Guncel = '1' Where SiparisCode = '" & Sipariscode & "'")
            cmd1.ExecuteNonQuery()
            con1.Close()
        Next
    End Sub

    Public Sub jsonRequest2()
        Dim cmd1 As New OleDb.OleDbCommand
        Dim con1 As New OleDb.OleDbConnection
        Dim Url As String = ""
        Dim ProductUpdate As String = ""
        Dim ApiKey As String = ""
        Dim ApiSecret As String = ""
        Dim s As String
        Dim arr = GridView1.RowCount
        Dim i As Integer
        Dim TOPLAM = arr
        i = 0
        Dim Renk1 = ""
        Dim Renk2 = ""
        Dim Renk3 = ""
        Dim Renk4 = ""
        Dim Renk5 = ""
        Dim Renk6 = ""
        Dim Renk7 = ""
        Dim Renk8 = ""
        Dim Renk9 = ""
        Dim Renk10 = ""
        Dim Renk11 = ""
        Dim Renk12 = ""
        Dim Renk13 = ""
        Dim Renk14 = ""
        Dim Renk15 = ""
        Dim Renk16 = ""
        Dim Renk17 = ""
        Dim Renk18 = ""
        Dim Renk19 = ""
        Dim Renk20 = ""
        Dim Renk21 = ""
        Dim Renk22 = ""
        Dim Renk23 = ""
        Dim Renk24 = ""
        Dim Renk25 = ""
        Dim Renk26 = ""
        Dim Renk27 = ""
        Dim Renk28 = ""
        Dim Renk29 = ""
        Dim Renk30 = ""
        Dim Renk31 = ""
        Dim Renk32 = ""
        Dim Renk33 = ""
        Dim Renk34 = ""
        Dim Renk35 = ""
        Dim Renk36 = ""
        Dim Renk37 = ""
        Dim Renk38 = ""
        Dim Renk39 = ""
        Dim Renk40 = ""
        Dim Renk41 = ""
        Dim Renk42 = ""
        Dim Renk43 = ""
        Dim Renk44 = ""
        Dim Renk45 = ""
        Dim Renk46 = ""
        Dim Renk47 = ""
        Dim Renk48 = ""
        Dim Renk49 = ""
        Dim Renk50 = ""
        Dim Renk51 = ""
        Dim Renk52 = ""
        Dim Renk53 = ""
        Dim Renk54 = ""
        Dim Renk55 = ""
        Dim Renk56 = ""
        Dim Renk57 = ""
        Dim Renk58 = ""
        Dim Renk59 = ""
        Dim Renk60 = ""
        Dim Beden1 = ""
        Dim Beden2 = ""
        Dim Beden3 = ""
        Dim Beden4 = ""
        Dim Beden5 = ""
        Dim Beden6 = ""
        Dim Beden7 = ""
        Dim Beden8 = ""
        Dim Beden9 = ""
        Dim Beden10 = ""
        Dim Beden11 = ""
        Dim Beden12 = ""
        Dim Beden13 = ""
        Dim Beden14 = ""
        Dim Beden15 = ""
        Dim Beden16 = ""
        Dim Beden17 = ""
        Dim Beden18 = ""
        Dim Beden19 = ""
        Dim Beden20 = ""
        Dim Beden21 = ""
        Dim Beden22 = ""
        Dim Beden23 = ""
        Dim Beden24 = ""
        Dim Beden25 = ""
        Dim Beden26 = ""
        Dim Beden27 = ""
        Dim Beden28 = ""
        Dim Beden29 = ""
        Dim Beden30 = ""
        Dim Beden31 = ""
        Dim Beden32 = ""
        Dim Beden33 = ""
        Dim Beden34 = ""
        Dim Beden35 = ""
        Dim Beden36 = ""
        Dim Beden37 = ""
        Dim Beden38 = ""
        Dim Beden39 = ""
        Dim Beden40 = ""
        Dim Beden41 = ""
        Dim Beden42 = ""
        Dim Beden43 = ""
        Dim Beden44 = ""
        Dim Beden45 = ""
        Dim Beden46 = ""
        Dim Beden47 = ""
        Dim Beden48 = ""
        Dim Beden49 = ""
        Dim Beden50 = ""
        Dim Beden51 = ""
        Dim Beden52 = ""
        Dim Beden53 = ""
        Dim Beden54 = ""
        Dim Beden55 = ""
        Dim Beden56 = ""
        Dim Beden57 = ""
        Dim Beden58 = ""
        Dim Beden59 = ""
        Dim Beden60 = ""
        Dim barcode1 = ""
        Dim barcode2 = ""
        Dim barcode3 = ""
        Dim barcode4 = ""
        Dim barcode5 = ""
        Dim barcode6 = ""
        Dim barcode7 = ""
        Dim barcode8 = ""
        Dim barcode9 = ""
        Dim barcode10 = ""
        Dim barcode11 = ""
        Dim barcode12 = ""
        Dim barcode13 = ""
        Dim barcode14 = ""
        Dim barcode15 = ""
        Dim barcode16 = ""
        Dim barcode17 = ""
        Dim barcode18 = ""
        Dim barcode19 = ""
        Dim barcode20 = ""
        Dim barcode21 = ""
        Dim barcode22 = ""
        Dim barcode23 = ""
        Dim barcode24 = ""
        Dim barcode25 = ""
        Dim barcode26 = ""
        Dim barcode27 = ""
        Dim barcode28 = ""
        Dim barcode29 = ""
        Dim barcode30 = ""
        Dim barcode31 = ""
        Dim barcode32 = ""
        Dim barcode33 = ""
        Dim barcode34 = ""
        Dim barcode35 = ""
        Dim barcode36 = ""
        Dim barcode37 = ""
        Dim barcode38 = ""
        Dim barcode39 = ""
        Dim barcode40 = ""
        Dim barcode41 = ""
        Dim barcode42 = ""
        Dim barcode43 = ""
        Dim barcode44 = ""
        Dim barcode45 = ""
        Dim barcode46 = ""
        Dim barcode47 = ""
        Dim barcode48 = ""
        Dim barcode49 = ""
        Dim barcode50 = ""
        Dim barcode51 = ""
        Dim barcode52 = ""
        Dim barcode53 = ""
        Dim barcode54 = ""
        Dim barcode55 = ""
        Dim barcode56 = ""
        Dim barcode57 = ""
        Dim barcode58 = ""
        Dim barcode59 = ""
        Dim barcode60 = ""
        Dim barcode = "0"
        Dim name = ""
        Dim invoiceName = ""
        Dim status = ""
        Dim shortDescription = ""
        Dim brand = ""
        Dim category1 = ""
        Dim category2 = ""
        Dim category3 = ""
        Dim category4 = ""
        Dim category5 = ""
        Dim longDescription As String = "0"
        Dim seoTitle = ""
        Dim seoKeywords = ""
        Dim seoDescription As String = ""
        Dim taxRate = ""
        'Dim shipmentPayment = dr("Kargo")
        Dim buyPrice = ""
        Dim listPrice = ""
        Dim salePrice = ""
        Dim quantity = ""
        Dim variant1Name = "Renk"
        Dim variant2Name = "Beden"
        Dim imageUrl = ""
        Dim imageUrl1 = ""
        Dim imageUrl2 = ""
        Dim imageUrl3 = ""
        Dim imageUrl4 = ""
        Dim imageUrl5 = ""
        Dim imageUrl6 = ""
        Dim imageUrl7 = ""
        Dim imageUrl8 = ""
        Dim imageUrl9 = ""
        Dim imageUrl10 = ""
        Dim xx = ""
        Dim priceStatus = 0
        Dim price = 0
        Dim TysalePrice = ""
        Dim N11salePrice = ""
        Dim GgsalePrice = ""
        Dim HbsalePrice = ""
        Dim CssalePrice = ""
        Dim EpttsalePrice = ""
        Dim AmzsalePrice = ""
        Dim quantity1 As Decimal = -9999
        Dim quantity2 As Decimal = -9999
        Dim quantity3 As Decimal = -9999
        Dim quantity4 As Decimal = -9999
        Dim quantity5 As Decimal = -9999
        Dim quantity6 As Decimal = -9999
        Dim quantity7 As Decimal = -9999
        Dim quantity8 As Decimal = -9999
        Dim quantity9 As Decimal = -9999
        Dim quantity10 As Decimal = -9999
        Dim quantity11 As Decimal = -9999
        Dim quantity12 As Decimal = -9999
        Dim quantity13 As Decimal = -9999
        Dim quantity14 As Decimal = -9999
        Dim quantity15 As Decimal = -9999
        Dim quantity16 As Decimal = -9999
        Dim quantity17 As Decimal = -9999
        Dim quantity18 As Decimal = -9999
        Dim quantity19 As Decimal = -9999
        Dim quantity20 As Decimal = -9999
        Dim quantity21 As Decimal = -9999
        Dim quantity22 As Decimal = -9999
        Dim quantity23 As Decimal = -9999
        Dim quantity24 As Decimal = -9999
        Dim quantity25 As Decimal = -9999
        Dim quantity26 As Decimal = -9999
        Dim quantity27 As Decimal = -9999
        Dim quantity28 As Decimal = -9999
        Dim quantity29 As Decimal = -9999
        Dim quantity30 As Decimal = -9999
        Dim quantity31 As Decimal = -9999
        Dim quantity32 As Decimal = -9999
        Dim quantity33 As Decimal = -9999
        Dim quantity34 As Decimal = -9999
        Dim quantity35 As Decimal = -9999
        Dim quantity36 As Decimal = -9999
        Dim quantity37 As Decimal = -9999
        Dim quantity38 As Decimal = -9999
        Dim quantity39 As Decimal = -9999
        Dim quantity40 As Decimal = -9999
        Dim quantity41 As Decimal = -9999
        Dim quantity42 As Decimal = -9999
        Dim quantity43 As Decimal = -9999
        Dim quantity44 As Decimal = -9999
        Dim quantity45 As Decimal = -9999
        Dim quantity46 As Decimal = -9999
        Dim quantity47 As Decimal = -9999
        Dim quantity48 As Decimal = -9999
        Dim quantity49 As Decimal = -9999
        Dim quantity50 As Decimal = -9999
        Dim quantity51 As Decimal = -9999
        Dim quantity52 As Decimal = -9999
        Dim quantity53 As Decimal = -9999
        Dim quantity54 As Decimal = -9999
        Dim quantity55 As Decimal = -9999
        Dim quantity56 As Decimal = -9999
        Dim quantity57 As Decimal = -9999
        Dim quantity58 As Decimal = -9999
        Dim quantity59 As Decimal = -9999
        Dim quantity60 As Decimal = -9999
        Dim quantitys As Decimal = 0
        Dim Renk As String = ""
        Dim RenkVal As String = ""
        Dim Beden As String = ""
        Dim BedenVal As String = ""
        Dim Barkod As String = ""
        Dim BarkodVal As String = ""
        Dim quantityVal As String = ""
        Dim quantitysVal As String = ""
        Dim Fiyat As String = ""
        Dim qText As String = "set dateformat dmy
    SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT  tbStok.nStokID,tbStok.sModel,sRenk,sBeden,sKavala,tbStok.sKdvTipi,sOzelNot,sBarkod,isnull(sUzunNot, 0) as sUzunNot,tbStok.sAciklama,tbStok.sKodu,ISNULL((SELECT     ISNULL(lOran, 0) FROM         tbStokBirimCevrimi WHERE     nStokID = tbStok.nStokID And sBirimCinsi = tbStok.sBirimCinsi2), 1) AS nBirimCarpan,CAST((SELECT isnull(SUM(tbStokFisiDetayi.lGirisMiktar1 - 
    tbStokFisiDetayi.lCikisMiktar1) , 0) FROM tbStokFisiDetayi WHERE tbStok.nStokID = tbStokFisiDetayi.nStokID) / ISNULL((SELECT     ISNULL(lOran, 0) FROM         tbStokBirimCevrimi WHERE     nStokID = tbStok.nStokID And 
    sBirimCinsi = tbStok.sBirimCinsi2), 1) AS MONEY) as lMevcut2, tbStokBarkodu.sBarkod,ISNULL(YOL,0) as Resim1,ISNULL(YOL1,0) as Resim2,ISNULL(YOL2,0) as Resim3,ISNULL(YOL3,0) as Resim4,ISNULL(YOL4,0) as Resim5,ISNULL(YOL5,0) 
    as Resim6,ISNULL(YOL6,0) as Resim7,ISNULL(YOL7,0) as Resim8,ISNULL(YOL8,0) as Resim9,ISNULL(YOL9,0) as Resim10,ISNULL(YOL10,0) as Resim11,tbStokUzunNot.sUzunNot, tbSSinif1.sAciklama AS Sinif1, tbSSinif2.sAciklama AS Sinif2, 
    tbSSinif3.sAciklama AS Sinif3, tbSSinif4.sAciklama AS Sinif4, tbSSinif5.sAciklama AS Sinif5, tbSSinif6.sAciklama AS Sinif6, tbSSinif7.sAciklama AS Sinif7, tbSSinif8.sAciklama AS Sinif8, tbSSinif9.sAciklama AS Sinif9, 
    tbSSinif10.sAciklama AS Sinif10, tbSSinif11.sAciklama AS Sinif11, tbSSinif12.sAciklama AS Sinif12, tbSSinif13.sAciklama AS Sinif13, tbSSinif14.sAciklama AS Sinif14, tbSSinif15.sAciklama AS Sinif15, 
    ISNULL(tbStokAciklama.sAciklama1 + ' ' + tbStokAciklama.sAciklama2 + ' ' + tbStokAciklama.sAciklama3 + ' ' + tbStokAciklama.sAciklama4 + ' ' + tbStokAciklama.sAciklama5 + ' ' + tbStokAciklama.sAciklama6 + ' ' + 
    tbStokAciklama.sAciklama7 + ' ' + tbStokAciklama.sAciklama8 + ' ' + tbStokAciklama.sAciklama9 + ' ' + tbStokAciklama.sAciklama10, '') AS ISTIHBARAT, (SELECT isnull(SUM(tbStokFisiDetayi.lGirisMiktar1 - 
    tbStokFisiDetayi.lCikisMiktar1) , 0) FROM tbStokFisiDetayi WHERE tbStok.nStokID =tbStokFisiDetayi.nStokID) AS Mevcut, ISNULL((SELECT isnull(lfiyat , 0) FROM tbstokfiyati WHERE nStokId = tbStok.NstokId And sFiyatTipi = 
    '1'),0) AS FIYAT1, ISNULL((SELECT isnull(lfiyat , 0) FROM tbstokfiyati WHERE nStokId = tbStok.NstokId And sFiyatTipi = '2'),0) AS FIYAT2,ISNULL((SELECT isnull(lfiyat, 0) FROM tbstokfiyati WHERE nStokId = tbStok.NstokId And 
    sFiyatTipi = '3'),0) AS FIYAT3,ISNULL((SELECT isnull(lfiyat , 0) FROM tbstokfiyati WHERE nStokId = tbStok.NstokId And sFiyatTipi = 'M'),0) AS FIYATM,ISNULL((SELECT isnull(lfiyat , 0) FROM tbstokfiyati WHERE nStokId = 
    tbStok.NstokId And sFiyatTipi = '4'), 0) AS FIYAT4,ISNULL((SELECT isnull(lfiyat , 0) FROM tbstokfiyati WHERE nStokId = tbStok.NstokId And sFiyatTipi = 'WEBP'), 0) AS WEBP,ISNULL((SELECT isnull(lfiyat , 0) FROM tbstokfiyati 
    WHERE nStokId = tbStok.NstokId AND sFiyatTipi = 'WEBK'), 0) AS WEBK, ISNULL((SELECT isnull(lfiyat , 0) FROM tbstokfiyati WHERE nStokId = tbStok.NstokId And sFiyatTipi = 'ty'), 0) AS TysalePrice,ISNULL((SELECT isnull(lfiyat, 
    0) FROM tbstokfiyati WHERE nStokId = tbStok.NstokId And sFiyatTipi = 'N11'), 0) AS N11salePrice,ISNULL((SELECT isnull(lfiyat , 0) FROM tbstokfiyati WHERE nStokId = tbStok.NstokId And sFiyatTipi = 'GG'), 0) AS 
    GgsalePrice,ISNULL((SELECT isnull(lfiyat , 0) FROM tbstokfiyati WHERE nStokId = tbStok.NstokId And sFiyatTipi = 'Hb'), 0) AS HbsalePrice,ISNULL((SELECT isnull(lfiyat , 0) FROM tbstokfiyati WHERE nStokId = tbStok.NstokId And 
    sFiyatTipi = 'Eptt'), 0) AS EpttsalePrice,ISNULL((SELECT isnull(lfiyat , 0) FROM tbstokfiyati WHERE nStokId = tbStok.NstokId And sFiyatTipi = 'Cs'), 0) AS CssalePrice,ISNULL((SELECT isnull(lfiyat , 0) FROM tbstokfiyati 
    WHERE nStokId = tbStok.NstokId And sFiyatTipi = 'Amz'), 0) AS AmzsalePrice,ISNULL((SELECT isnull(lfiyat , 0) FROM tbstokfiyati WHERE nStokId = tbStok.NstokId And sFiyatTipi = 'New'), 0) AS NewsalePrice,ISNULL((SELECT 
    isnull(lfiyat, 0) FROM tbstokfiyati WHERE nStokId = tbStok.nStokId And sFiyatTipi = 'A'),0) AS FIYATA,ISNULL((SELECT isnull(lfiyat , 0) FROM tbstokfiyati WHERE nStokId = tbStok.NstokId AND sFiyatTipi = '1'),0) AS lFiyat, 
    (SELECT     nKdvOrani FROM         tbKdv Where sKdvTipi = tbStok.sKdvTipi) as nKdvOrani,ISNULL((SELECT ISNULL(lOran , 1) FROM tbStokBirimCevrimi WHERE nStokID = tbStok.nStokID And sBirimCinsi = tbStok.sBirimCinsi2), 1) AS 
    lBirimCarpan, (SELECT     sRenkAdi FROM          tbRenk WHERE      sRenk = tbStok.sRenk) AS sRenkAdi,(SELECT     COUNT(DISTINCT nStokID) AS nKayit FROM         tbStokFiyati WHERE     (dteFiyatTespitTarihi = '14/02/2021') AND 
    (sFiyatTipi IN ('1', '2', '3')) and nStokID = tbStok.nStokID) bFiyatDegisti  FROM tbStok LEFT OUTER JOIN tbStokBarkodu ON tbStok.nStokID = tbStokBarkodu.nStokID and tbStokBarkodu.nKisim =0 INNER JOIN tbStokSinifi ON tbStok.nStokID = tbStokSinifi.nStokID
    LEFT OUTER JOIN tbStokEticaretResim ON tbStok.sModel = tbStokEticaretResim.sModel LEFT OUTER JOIN tbStokUzunNot ON tbStok.sModel = tbStokUzunNot.sModel INNER JOIN tbSSinif1 ON tbStokSinifi.sSinifKodu1 = tbSSinif1.sSinifKodu INNER JOIN tbSSinif2 ON tbStokSinifi.sSinifKodu2 = tbSSinif2.sSinifKodu
    INNER JOIN tbSSinif3 ON tbStokSinifi.sSinifKodu3 = tbSSinif3.sSinifKodu INNER JOIN tbSSinif4 ON tbStokSinifi.sSinifKodu4 = tbSSinif4.sSinifKodu INNER JOIN tbSSinif5 ON tbStokSinifi.sSinifKodu5 = tbSSinif5.sSinifKodu INNER JOIN tbSSinif6 ON tbStokSinifi.sSinifKodu6 = tbSSinif6.sSinifKodu INNER JOIN tbSSinif7 ON tbStokSinifi.sSinifKodu7 = tbSSinif7.sSinifKodu
    INNER JOIN tbSSinif8 ON tbStokSinifi.sSinifKodu8 = tbSSinif8.sSinifKodu INNER JOIN tbSSinif9 ON tbStokSinifi.sSinifKodu9 = tbSSinif9.sSinifKodu INNER JOIN tbSSinif10 ON tbStokSinifi.sSinifKodu10 = tbSSinif10.sSinifKodu INNER JOIN tbSSinif11 ON tbStokSinifi.sSinifKodu11 = tbSSinif11.sSinifKodu INNER JOIN tbSSinif12 ON tbStokSinifi.sSinifKodu12 = tbSSinif12.sSinifKodu INNER JOIN tbSSinif13
    ON tbStokSinifi.sSinifKodu13 = tbSSinif13.sSinifKodu INNER JOIN tbSSinif14 ON tbStokSinifi.sSinifKodu14 = tbSSinif14.sSinifKodu INNER JOIN tbSSinif15 ON tbStokSinifi.sSinifKodu15 = tbSSinif15.sSinifKodu LEFT OUTER JOIN tbStokAciklama ON tbStok.nStokID = tbStokAciklama.nStokID WHERE tbStok.sKodu <> ''    and tbStok.nStokTipi < 5  and tbStok.bWebGoruntule = 'True' and tbStok.sRenk > '' ORDER BY tbStok.sModel"
        con1.ConnectionString = connection
        cmd1 = New OleDbCommand(qText, con1)
        con1.Open()
        cmd1.ExecuteNonQuery()
        con1.Close()
        Dim queryString As String = qText
        Dim dr As DataRow

        Dim adapternew As OleDbDataAdapter = New OleDbDataAdapter(queryString, con1)

        Dim DS37894 As DataSet = New DataSet

        Dim N As Integer = adapternew.Fill(DS37894)
        Dim stokEtic As String = "set dateformat dmy
    SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT  tbStok.nStokID,tbStok.sModel,sRenk,sBeden,sKavala,tbStok.sKdvTipi,sOzelNot,sBarkod,isnull(sUzunNot, 0) as sUzunNot,tbStok.sAciklama,tbStok.sKodu,ISNULL((SELECT     ISNULL(lOran, 0) FROM         tbStokBirimCevrimi WHERE     nStokID = tbStok.nStokID And sBirimCinsi = tbStok.sBirimCinsi2), 1) AS nBirimCarpan,CAST((SELECT isnull(SUM(tbStokFisiDetayi.lGirisMiktar1 - 
    tbStokFisiDetayi.lCikisMiktar1) , 0) FROM tbStokFisiDetayi WHERE tbStok.nStokID = tbStokFisiDetayi.nStokID) / ISNULL((SELECT     ISNULL(lOran, 0) FROM         tbStokBirimCevrimi WHERE     nStokID = tbStok.nStokID And 
    sBirimCinsi = tbStok.sBirimCinsi2), 1) AS MONEY) as lMevcut2, tbStokBarkodu.sBarkod,ISNULL(YOL,0) as Resim1,ISNULL(YOL1,0) as Resim2,ISNULL(YOL2,0) as Resim3,ISNULL(YOL3,0) as Resim4,ISNULL(YOL4,0) as Resim5,ISNULL(YOL5,0) 
    as Resim6,ISNULL(YOL6,0) as Resim7,ISNULL(YOL7,0) as Resim8,ISNULL(YOL8,0) as Resim9,ISNULL(YOL9,0) as Resim10,ISNULL(YOL10,0) as Resim11,tbStokUzunNot.sUzunNot, tbSSinif1.sAciklama AS Sinif1, tbSSinif2.sAciklama AS Sinif2, 
    tbSSinif3.sAciklama AS Sinif3, tbSSinif4.sAciklama AS Sinif4, tbSSinif5.sAciklama AS Sinif5, tbSSinif6.sAciklama AS Sinif6, tbSSinif7.sAciklama AS Sinif7, tbSSinif8.sAciklama AS Sinif8, tbSSinif9.sAciklama AS Sinif9, 
    tbSSinif10.sAciklama AS Sinif10, tbSSinif11.sAciklama AS Sinif11, tbSSinif12.sAciklama AS Sinif12, tbSSinif13.sAciklama AS Sinif13, tbSSinif14.sAciklama AS Sinif14, tbSSinif15.sAciklama AS Sinif15, 
    ISNULL(tbStokAciklama.sAciklama1 + ' ' + tbStokAciklama.sAciklama2 + ' ' + tbStokAciklama.sAciklama3 + ' ' + tbStokAciklama.sAciklama4 + ' ' + tbStokAciklama.sAciklama5 + ' ' + tbStokAciklama.sAciklama6 + ' ' + 
    tbStokAciklama.sAciklama7 + ' ' + tbStokAciklama.sAciklama8 + ' ' + tbStokAciklama.sAciklama9 + ' ' + tbStokAciklama.sAciklama10, '') AS ISTIHBARAT, (SELECT isnull(SUM(tbStokFisiDetayi.lGirisMiktar1 - 
    tbStokFisiDetayi.lCikisMiktar1) , 0) FROM tbStokFisiDetayi WHERE tbStok.nStokID =tbStokFisiDetayi.nStokID) AS Mevcut, ISNULL((SELECT isnull(lfiyat , 0) FROM tbstokfiyati WHERE nStokId = tbStok.NstokId And sFiyatTipi = 
    '1'),0) AS FIYAT1, ISNULL((SELECT isnull(lfiyat , 0) FROM tbstokfiyati WHERE nStokId = tbStok.NstokId And sFiyatTipi = '2'),0) AS FIYAT2,ISNULL((SELECT isnull(lfiyat, 0) FROM tbstokfiyati WHERE nStokId = tbStok.NstokId And 
    sFiyatTipi = '3'),0) AS FIYAT3,ISNULL((SELECT isnull(lfiyat , 0) FROM tbstokfiyati WHERE nStokId = tbStok.NstokId And sFiyatTipi = 'M'),0) AS FIYATM,ISNULL((SELECT isnull(lfiyat , 0) FROM tbstokfiyati WHERE nStokId = 
    tbStok.NstokId And sFiyatTipi = '4'), 0) AS FIYAT4,ISNULL((SELECT isnull(lfiyat , 0) FROM tbstokfiyati WHERE nStokId = tbStok.NstokId And sFiyatTipi = 'WEBP'), 0) AS WEBP,ISNULL((SELECT isnull(lfiyat , 0) FROM tbstokfiyati 
    WHERE nStokId = tbStok.NstokId AND sFiyatTipi = 'WEBK'), 0) AS WEBK, ISNULL((SELECT isnull(lfiyat , 0) FROM tbstokfiyati WHERE nStokId = tbStok.NstokId And sFiyatTipi = 'ty'), 0) AS TysalePrice,ISNULL((SELECT isnull(lfiyat, 
    0) FROM tbstokfiyati WHERE nStokId = tbStok.NstokId And sFiyatTipi = 'N11'), 0) AS N11salePrice,ISNULL((SELECT isnull(lfiyat , 0) FROM tbstokfiyati WHERE nStokId = tbStok.NstokId And sFiyatTipi = 'GG'), 0) AS 
    GgsalePrice,ISNULL((SELECT isnull(lfiyat , 0) FROM tbstokfiyati WHERE nStokId = tbStok.NstokId And sFiyatTipi = 'Hb'), 0) AS HbsalePrice,ISNULL((SELECT isnull(lfiyat , 0) FROM tbstokfiyati WHERE nStokId = tbStok.NstokId And 
    sFiyatTipi = 'Eptt'), 0) AS EpttsalePrice,ISNULL((SELECT isnull(lfiyat , 0) FROM tbstokfiyati WHERE nStokId = tbStok.NstokId And sFiyatTipi = 'Cs'), 0) AS CssalePrice,ISNULL((SELECT isnull(lfiyat , 0) FROM tbstokfiyati 
    WHERE nStokId = tbStok.NstokId And sFiyatTipi = 'Amz'), 0) AS AmzsalePrice,ISNULL((SELECT isnull(lfiyat , 0) FROM tbstokfiyati WHERE nStokId = tbStok.NstokId And sFiyatTipi = 'New'), 0) AS NewsalePrice,ISNULL((SELECT 
    isnull(lfiyat, 0) FROM tbstokfiyati WHERE nStokId = tbStok.nStokId And sFiyatTipi = 'A'),0) AS FIYATA,ISNULL((SELECT isnull(lfiyat , 0) FROM tbstokfiyati WHERE nStokId = tbStok.NstokId AND sFiyatTipi = '1'),0) AS lFiyat, 
    (SELECT     nKdvOrani FROM         tbKdv Where sKdvTipi = tbStok.sKdvTipi) as nKdvOrani,ISNULL((SELECT ISNULL(lOran , 1) FROM tbStokBirimCevrimi WHERE nStokID = tbStok.nStokID And sBirimCinsi = tbStok.sBirimCinsi2), 1) AS 
    lBirimCarpan, (SELECT     sRenkAdi FROM          tbRenk WHERE      sRenk = tbStok.sRenk) AS sRenkAdi,(SELECT     COUNT(DISTINCT nStokID) AS nKayit FROM         tbStokFiyati WHERE     (dteFiyatTespitTarihi = '14/02/2021') AND 
    (sFiyatTipi IN ('1', '2', '3')) and nStokID = tbStok.nStokID) bFiyatDegisti  FROM tbStok LEFT OUTER JOIN tbStokBarkodu ON tbStok.nStokID = tbStokBarkodu.nStokID and tbStokBarkodu.nKisim =0 INNER JOIN tbStokSinifi ON tbStok.nStokID = tbStokSinifi.nStokID
    LEFT OUTER JOIN tbStokEticaretResim ON tbStok.sModel = tbStokEticaretResim.sModel LEFT OUTER JOIN tbStokUzunNot ON tbStok.sModel = tbStokUzunNot.sModel INNER JOIN tbSSinif1 ON tbStokSinifi.sSinifKodu1 = tbSSinif1.sSinifKodu INNER JOIN tbSSinif2 ON tbStokSinifi.sSinifKodu2 = tbSSinif2.sSinifKodu
    INNER JOIN tbSSinif3 ON tbStokSinifi.sSinifKodu3 = tbSSinif3.sSinifKodu INNER JOIN tbSSinif4 ON tbStokSinifi.sSinifKodu4 = tbSSinif4.sSinifKodu INNER JOIN tbSSinif5 ON tbStokSinifi.sSinifKodu5 = tbSSinif5.sSinifKodu INNER JOIN tbSSinif6 ON tbStokSinifi.sSinifKodu6 = tbSSinif6.sSinifKodu INNER JOIN tbSSinif7 ON tbStokSinifi.sSinifKodu7 = tbSSinif7.sSinifKodu
    INNER JOIN tbSSinif8 ON tbStokSinifi.sSinifKodu8 = tbSSinif8.sSinifKodu INNER JOIN tbSSinif9 ON tbStokSinifi.sSinifKodu9 = tbSSinif9.sSinifKodu INNER JOIN tbSSinif10 ON tbStokSinifi.sSinifKodu10 = tbSSinif10.sSinifKodu INNER JOIN tbSSinif11 ON tbStokSinifi.sSinifKodu11 = tbSSinif11.sSinifKodu INNER JOIN tbSSinif12 ON tbStokSinifi.sSinifKodu12 = tbSSinif12.sSinifKodu INNER JOIN tbSSinif13
    ON tbStokSinifi.sSinifKodu13 = tbSSinif13.sSinifKodu INNER JOIN tbSSinif14 ON tbStokSinifi.sSinifKodu14 = tbSSinif14.sSinifKodu INNER JOIN tbSSinif15 ON tbStokSinifi.sSinifKodu15 = tbSSinif15.sSinifKodu LEFT OUTER JOIN tbStokAciklama ON tbStok.nStokID = tbStokAciklama.nStokID WHERE tbStok.sKodu <> ''    and tbStok.nStokTipi < 5  and tbStok.bWebGoruntule = 'True' and tbStok.sRenk > '' ORDER BY tbStok.sModel"
        cmd1 = New OleDbCommand(stokEtic, con1)
        con1.Open()
        cmd1.ExecuteNonQuery()
        con1.Close()


        Dim dr8 As DataRow

        Dim adapternew2 As OleDbDataAdapter = New OleDbDataAdapter(stokEtic, con1)

        Dim DSstokE As DataSet = New DataSet

        Dim NstkE As Integer = adapternew2.Fill(DSstokE, "tbStokEticaret")
        Dim nStokID2
        Dim FIYAT1_2 As String = ""
        Dim FIYAT1 As String = ""
        Dim quantity123456789
        For Each dr In DS37894.Tables(0).Rows




            'Dim dr As DataRow = dr8.Tables(0).Rows
            Dim code = Trim(dr("sModel"))
            Dim Model = Trim(dr("sKodu"))
            Dim nStokID = Trim(dr("nStokID"))
            Dim Sor As String = ""
            Dim R As String = Trim(dr("sRenkAdi"))
            Dim Bed As String = Trim(dr("sBeden"))
            Dim Bar As String = Trim(dr("sBarkod"))
            Dim Q As String = Trim(dr("Mevcut"))
            Dim Qs As String = Trim(dr("Mevcut"))
            con1.ConnectionString = connection
            If con1.State = ConnectionState.Closed Then
                cmd1.Connection = con1
                con1.Open()
            End If
            cmd1.CommandText = sorgu_queryJson("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT  COUNT (code) FROM tbStokEticaret where code = '" & code & "' ")
            Sor = cmd1.ExecuteScalar.ToString()
            s = i.ToString
            If xx <> code Then
                Renk1 = ""
                Renk2 = ""
                Renk3 = ""
                Renk4 = ""
                Renk5 = ""
                Renk6 = ""
                Renk7 = ""
                Renk8 = ""
                Renk9 = ""
                Renk10 = ""
                Renk11 = ""
                Renk12 = ""
                Renk13 = ""
                Renk14 = ""
                Renk15 = ""
                Renk16 = ""
                Renk17 = ""
                Renk18 = ""
                Renk19 = ""
                Renk20 = ""
                Renk21 = ""
                Renk22 = ""
                Renk23 = ""
                Renk24 = ""
                Renk25 = ""
                Renk26 = ""
                Renk27 = ""
                Renk28 = ""
                Renk29 = ""
                Renk30 = ""
                Renk31 = ""
                Renk32 = ""
                Renk33 = ""
                Renk34 = ""
                Renk35 = ""
                Renk36 = ""
                Renk37 = ""
                Renk38 = ""
                Renk39 = ""
                Renk40 = ""
                Renk41 = ""
                Renk42 = ""
                Renk43 = ""
                Renk44 = ""
                Renk45 = ""
                Renk46 = ""
                Renk47 = ""
                Renk48 = ""
                Renk49 = ""
                Renk50 = ""
                Renk51 = ""
                Renk52 = ""
                Renk53 = ""
                Renk54 = ""
                Renk55 = ""
                Renk56 = ""
                Renk57 = ""
                Renk58 = ""
                Renk59 = ""
                Renk60 = ""
                Beden1 = ""
                Beden2 = ""
                Beden3 = ""
                Beden4 = ""
                Beden5 = ""
                Beden6 = ""
                Beden7 = ""
                Beden8 = ""
                Beden9 = ""
                Beden10 = ""
                Beden11 = ""
                Beden12 = ""
                Beden13 = ""
                Beden14 = ""
                Beden15 = ""
                Beden16 = ""
                Beden17 = ""
                Beden18 = ""
                Beden19 = ""
                Beden20 = ""
                Beden21 = ""
                Beden22 = ""
                Beden23 = ""
                Beden24 = ""
                Beden25 = ""
                Beden26 = ""
                Beden27 = ""
                Beden28 = ""
                Beden29 = ""
                Beden30 = ""
                Beden31 = ""
                Beden32 = ""
                Beden33 = ""
                Beden34 = ""
                Beden35 = ""
                Beden36 = ""
                Beden37 = ""
                Beden38 = ""
                Beden39 = ""
                Beden40 = ""
                Beden41 = ""
                Beden42 = ""
                Beden43 = ""
                Beden44 = ""
                Beden45 = ""
                Beden46 = ""
                Beden47 = ""
                Beden48 = ""
                Beden49 = ""
                Beden50 = ""
                Beden51 = ""
                Beden52 = ""
                Beden53 = ""
                Beden54 = ""
                Beden55 = ""
                Beden56 = ""
                Beden57 = ""
                Beden58 = ""
                Beden59 = ""
                Beden60 = ""
                barcode1 = ""
                barcode2 = ""
                barcode3 = ""
                barcode4 = ""
                barcode5 = ""
                barcode6 = ""
                barcode7 = ""
                barcode8 = ""
                barcode9 = ""
                barcode10 = ""
                barcode11 = ""
                barcode12 = ""
                barcode13 = ""
                barcode14 = ""
                barcode15 = ""
                barcode16 = ""
                barcode17 = ""
                barcode18 = ""
                barcode19 = ""
                barcode20 = ""
                barcode21 = ""
                barcode22 = ""
                barcode23 = ""
                barcode24 = ""
                barcode25 = ""
                barcode26 = ""
                barcode27 = ""
                barcode28 = ""
                barcode29 = ""
                barcode30 = ""
                barcode31 = ""
                barcode32 = ""
                barcode33 = ""
                barcode34 = ""
                barcode35 = ""
                barcode36 = ""
                barcode37 = ""
                barcode38 = ""
                barcode39 = ""
                barcode40 = ""
                barcode41 = ""
                barcode42 = ""
                barcode43 = ""
                barcode44 = ""
                barcode45 = ""
                barcode46 = ""
                barcode47 = ""
                barcode48 = ""
                barcode49 = ""
                barcode50 = ""
                barcode51 = ""
                barcode52 = ""
                barcode53 = ""
                barcode54 = ""
                barcode55 = ""
                barcode56 = ""
                barcode57 = ""
                barcode58 = ""
                barcode59 = ""
                barcode60 = ""
                barcode = "0"
                name = ""
                invoiceName = ""
                status = ""
                shortDescription = ""
                brand = ""
                category1 = ""
                category2 = ""
                category3 = ""
                category4 = ""
                category5 = ""
                longDescription = ""
                seoTitle = ""
                seoKeywords = ""
                seoDescription = ""
                taxRate = ""
                ' shipmentPayment = dr("Kargo")
                buyPrice = ""
                listPrice = ""
                salePrice = ""
                quantity = ""
                variant1Name = "Renk"
                variant2Name = "Beden"
                imageUrl = ""
                imageUrl1 = ""
                imageUrl2 = ""
                imageUrl3 = ""
                imageUrl4 = ""
                imageUrl5 = ""
                imageUrl6 = ""
                imageUrl7 = ""
                imageUrl8 = ""
                imageUrl9 = ""
                imageUrl10 = ""
                xx = ""
                priceStatus = 0
                price = 0
                TysalePrice = ""
                N11salePrice = ""
                GgsalePrice = ""
                HbsalePrice = ""
                CssalePrice = ""
                EpttsalePrice = ""
                AmzsalePrice = ""
                quantity1 = -9999
                quantity2 = -9999
                quantity3 = -9999
                quantity4 = -9999
                quantity5 = -9999
                quantity6 = -9999
                quantity7 = -9999
                quantity8 = -9999
                quantity9 = -9999
                quantity10 = -9999
                quantity11 = -9999
                quantity12 = -9999
                quantity13 = -9999
                quantity14 = -9999
                quantity15 = -9999
                quantity16 = -9999
                quantity17 = -9999
                quantity18 = -9999
                quantity19 = -9999
                quantity20 = -9999
                quantity21 = -9999
                quantity22 = -9999
                quantity23 = -9999
                quantity24 = -9999
                quantity25 = -9999
                quantity26 = -9999
                quantity27 = -9999
                quantity28 = -9999
                quantity29 = -9999
                quantity30 = -9999
                quantity31 = -9999
                quantity32 = -9999
                quantity33 = -9999
                quantity34 = -9999
                quantity35 = -9999
                quantity36 = -9999
                quantity37 = -9999
                quantity38 = -9999
                quantity39 = -9999
                quantity40 = -9999
                quantity41 = -9999
                quantity42 = -9999
                quantity43 = -9999
                quantity44 = -9999
                quantity45 = -9999
                quantity46 = -9999
                quantity47 = -9999
                quantity48 = -9999
                quantity49 = -9999
                quantity50 = -9999
                quantity51 = -9999
                quantity52 = -9999
                quantity53 = -9999
                quantity54 = -9999
                quantity55 = -9999
                quantity56 = -9999
                quantity57 = -9999
                quantity58 = -9999
                quantity59 = -9999
                quantity60 = -9999
                quantitys = 0
                Renk = ""
                RenkVal = ""
                Beden = ""
                BedenVal = ""
                Barkod = ""
                BarkodVal = ""
                quantityVal = ""
                quantitysVal = ""
            End If

            If Sor <= 0 Then
                code = Trim(dr("sModel"))
                name = dr("sAciklama")
                invoiceName = dr("sAciklama")
                'status = dr("bWebGoruntule")
                barcode = Trim(dr("sBarkod"))
                shortDescription = dr("sAciklama")
                brand = dr("Sinif4")
                category1 = dr("Sinif3")
                category2 = dr("Sinif2")
                category3 = dr("Sinif6")
                category4 = dr("Sinif5")
                category5 = dr("Sinif6")
                longDescription = Trim(dr("sUzunNot"))
                seoTitle = dr("Sinif3")
                seoKeywords = dr("Sinif3")
                seoDescription = dr("Sinif3")
                taxRate = dr("sKdvTipi")
                ' shipmentPayment = dr("Kargo")
                buyPrice = dr("FIYATA")
                listPrice = dr("WEBK")
                salePrice = dr("WEBP")
                quantity = dr("Mevcut")
                variant1Name = "Renk"
                variant2Name = "Beden"
                imageUrl = dr("Resim1")
                imageUrl1 = dr("Resim2")
                imageUrl2 = dr("Resim3")
                imageUrl3 = dr("Resim4")
                imageUrl4 = dr("Resim5")
                imageUrl5 = dr("Resim6")
                imageUrl6 = dr("Resim7")
                imageUrl7 = dr("Resim8")
                imageUrl8 = dr("Resim9")
                imageUrl9 = dr("Resim10")
                imageUrl10 = dr("Resim11")
                Renk1 = Trim(dr("sRenkAdi"))
                Beden1 = Trim(dr("sBeden"))
                taxRate = 0
                If taxRate = 1 Then
                    taxRate = 0
                ElseIf taxRate = 2 Then
                    taxRate = 18
                ElseIf taxRate = 3 Then
                    taxRate = 8
                End If
                tbStok_kaydet_Eticaret1(nStokID, code, name, Renk1, Beden1, barcode, brand, category1, category2, category3, category4, category5, longDescription, buyPrice, listPrice, salePrice, seoTitle, seoKeywords, taxRate, quantity, seoDescription, variant1Name, variant2Name, imageUrl, imageUrl1, imageUrl2, imageUrl3, imageUrl4, imageUrl5, imageUrl6, imageUrl7, imageUrl8, imageUrl9, imageUrl10, TysalePrice, N11salePrice, GgsalePrice, HbsalePrice, EpttsalePrice, CssalePrice, AmzsalePrice)

            Else
                Dim con As New OleDb.OleDbConnection
                Dim cmd As New OleDb.OleDbCommand
                cmd.Connection = con
                con.ConnectionString = connection
                cmd.CommandTimeout = False
                If con.State = ConnectionState.Closed = True Then
                    con.Open()
                End If

                'cmd.CommandText = "SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT @@identity"
                'Dim kayitno = cmd.ExecuteScalar
                con.Close()
                code = Trim(dr("sModel"))
                xx = Trim(dr("sModel"))
                name = dr("sAciklama")
                invoiceName = dr("sAciklama")
                'status = dr("bWebGoruntule")
                barcode = Trim(dr("sBarkod"))
                shortDescription = dr("sAciklama")
                brand = dr("Sinif1")
                category1 = dr("Sinif2")
                category2 = dr("Sinif3")
                category3 = dr("Sinif4")
                category4 = dr("Sinif5")
                longDescription = Trim(dr("sUzunNot"))
                seoTitle = dr("Sinif2")
                seoKeywords = dr("Sinif2")
                seoDescription = dr("Sinif2")
                taxRate = dr("sKdvTipi")
                ' shipmentPayment = dr("Kargo")
                buyPrice = dr("FIYATA")
                listPrice = dr("WEBK")
                salePrice = dr("WEBP")
                quantity = dr("Mevcut")
                variant1Name = "Renk"
                variant2Name = "Beden"
                imageUrl = dr("Resim1")
                imageUrl1 = dr("Resim2")
                imageUrl2 = dr("Resim3")
                imageUrl3 = dr("Resim4")
                imageUrl4 = dr("Resim5")
                imageUrl5 = dr("Resim6")
                imageUrl6 = dr("Resim7")
                imageUrl7 = dr("Resim8")
                imageUrl8 = dr("Resim9")
                imageUrl9 = dr("Resim10")
                imageUrl10 = dr("Resim11")
                Renk1 = Trim(dr("sRenkAdi"))
                Beden1 = Trim(dr("sBeden"))
                taxRate = 0
                If taxRate = 1 Then
                    taxRate = 0
                ElseIf taxRate = 2 Then
                    taxRate = 18
                ElseIf taxRate = 3 Then
                    taxRate = 8
                End If

                If Renk2 = "" Then
                    Renk2 = R
                    Renk = "Renk2"
                    RenkVal = Renk2
                    tbStok_RenkUpdate_Eticaret(code, Renk, RenkVal)
                ElseIf Renk3 = "" Then
                    Renk3 = R
                    Renk = "Renk3"
                    RenkVal = Renk3
                    tbStok_RenkUpdate_Eticaret(code, Renk, RenkVal)
                ElseIf Renk4 = "" Then
                    Renk4 = R
                    Renk = "Renk4"
                    RenkVal = Renk4
                    tbStok_RenkUpdate_Eticaret(code, Renk, RenkVal)
                ElseIf Renk5 = "" Then
                    Renk5 = R
                    Renk = "Renk5"
                    RenkVal = Renk5
                    tbStok_RenkUpdate_Eticaret(code, Renk, RenkVal)
                ElseIf Renk6 = "" Then
                    Renk6 = R
                    Renk = "Renk6"
                    RenkVal = Renk6
                    tbStok_RenkUpdate_Eticaret(code, Renk, RenkVal)
                ElseIf Renk7 = "" Then
                    Renk7 = R
                    Renk = "Renk7"
                    RenkVal = Renk7
                    tbStok_RenkUpdate_Eticaret(code, Renk, RenkVal)
                ElseIf Renk8 = "" Then
                    Renk8 = R
                    Renk = "Renk8"
                    RenkVal = Renk8
                    tbStok_RenkUpdate_Eticaret(code, Renk, RenkVal)
                ElseIf Renk9 = "" Then
                    Renk9 = R
                    Renk = "Renk9"
                    RenkVal = Renk9
                    tbStok_RenkUpdate_Eticaret(code, Renk, RenkVal)
                ElseIf Renk10 = "" Then
                    Renk10 = R
                    Renk = "Renk10"
                    RenkVal = Renk10
                    tbStok_RenkUpdate_Eticaret(code, Renk, RenkVal)
                ElseIf Renk11 = "" Then
                    Renk11 = R
                    Renk = "Renk11"
                    RenkVal = Renk11
                    tbStok_RenkUpdate_Eticaret(code, Renk, RenkVal)
                ElseIf Renk12 = "" Then
                    Renk12 = R
                    Renk = "Renk12"
                    RenkVal = Renk12
                    tbStok_RenkUpdate_Eticaret(code, Renk, RenkVal)
                ElseIf Renk13 = "" Then
                    Renk13 = R
                    Renk = "Renk13"
                    RenkVal = Renk13
                    tbStok_RenkUpdate_Eticaret(code, Renk, RenkVal)
                ElseIf Renk14 = "" Then
                    Renk14 = R
                    Renk = "Renk14"
                    RenkVal = Renk14
                    tbStok_RenkUpdate_Eticaret(code, Renk, RenkVal)
                ElseIf Renk15 = "" Then
                    Renk15 = R
                    Renk = "Renk15"
                    RenkVal = Renk15
                    tbStok_RenkUpdate_Eticaret(code, Renk, RenkVal)
                ElseIf Renk16 = "" Then
                    Renk16 = R
                    Renk = "Renk16"
                    RenkVal = Renk16
                    tbStok_RenkUpdate_Eticaret(code, Renk, RenkVal)
                ElseIf Renk17 = "" Then
                    Renk17 = R
                    Renk = "Renk17"
                    RenkVal = Renk17
                    tbStok_RenkUpdate_Eticaret(code, Renk, RenkVal)
                ElseIf Renk18 = "" Then
                    Renk18 = R
                    Renk = "Renk18"
                    RenkVal = Renk18
                    tbStok_RenkUpdate_Eticaret(code, Renk, RenkVal)
                ElseIf Renk19 = "" Then
                    Renk19 = R
                    Renk = "Renk19"
                    RenkVal = Renk19
                    tbStok_RenkUpdate_Eticaret(code, Renk, RenkVal)
                ElseIf Renk20 = "" Then
                    Renk20 = R
                    Renk = "Renk20"
                    RenkVal = Renk20
                    tbStok_RenkUpdate_Eticaret(code, Renk, RenkVal)
                ElseIf Renk21 = "" Then
                    Renk21 = R
                    Renk = "Renk21"
                    RenkVal = Renk21
                    tbStok_RenkUpdate_Eticaret(code, Renk, RenkVal)
                ElseIf Renk22 = "" Then
                    Renk22 = R
                    Renk = "Renk22"
                    RenkVal = Renk22
                    tbStok_RenkUpdate_Eticaret(code, Renk, RenkVal)
                ElseIf Renk23 = "" Then
                    Renk23 = R
                    Renk = "Renk23"
                    RenkVal = Renk23
                    tbStok_RenkUpdate_Eticaret(code, Renk, RenkVal)
                ElseIf Renk24 = "" Then
                    Renk24 = R
                    Renk = "Renk24"
                    RenkVal = Renk24
                    tbStok_RenkUpdate_Eticaret(code, Renk, RenkVal)
                ElseIf Renk25 = "" Then
                    Renk25 = R
                    Renk = "Renk25"
                    RenkVal = Renk25
                    tbStok_RenkUpdate_Eticaret(code, Renk, RenkVal)
                ElseIf Renk26 = "" Then
                    Renk26 = R
                    Renk = "Renk26"
                    RenkVal = Renk26
                    tbStok_RenkUpdate_Eticaret(code, Renk, RenkVal)
                ElseIf Renk27 = "" Then
                    Renk27 = R
                    Renk = "Renk27"
                    RenkVal = Renk27
                    tbStok_RenkUpdate_Eticaret(code, Renk, RenkVal)
                ElseIf Renk28 = "" Then
                    Renk28 = R
                    Renk = "Renk28"
                    RenkVal = Renk28
                    tbStok_RenkUpdate_Eticaret(code, Renk, RenkVal)
                ElseIf Renk29 = "" Then
                    Renk29 = R
                    Renk = "Renk29"
                    RenkVal = Renk29
                    tbStok_RenkUpdate_Eticaret(code, Renk, RenkVal)
                ElseIf Renk30 = "" Then
                    Renk30 = R
                    Renk = "Renk30"
                    RenkVal = Renk30
                    tbStok_RenkUpdate_Eticaret(code, Renk, RenkVal)
                ElseIf Renk31 = "" Then
                    Renk31 = R
                    Renk = "Renk31"
                    RenkVal = Renk31
                    tbStok_RenkUpdate_Eticaret(code, Renk, RenkVal)
                ElseIf Renk32 = "" Then
                    Renk32 = R
                    Renk = "Renk32"
                    RenkVal = Renk32
                    tbStok_RenkUpdate_Eticaret(code, Renk, RenkVal)
                ElseIf Renk33 = "" Then
                    Renk33 = R
                    Renk = "Renk33"
                    RenkVal = Renk33
                    tbStok_RenkUpdate_Eticaret(code, Renk, RenkVal)
                ElseIf Renk34 = "" Then
                    Renk34 = R
                    Renk = "Renk34"
                    RenkVal = Renk34
                    tbStok_RenkUpdate_Eticaret(code, Renk, RenkVal)
                ElseIf Renk35 = "" Then
                    Renk35 = R
                    Renk = "Renk35"
                    RenkVal = Renk35
                    tbStok_RenkUpdate_Eticaret(code, Renk, RenkVal)
                ElseIf Renk36 = "" Then
                    Renk36 = R
                    Renk = "Renk36"
                    RenkVal = Renk36
                    tbStok_RenkUpdate_Eticaret(code, Renk, RenkVal)
                ElseIf Renk37 = "" Then
                    Renk37 = R
                    Renk = "Renk37"
                    RenkVal = Renk37
                    tbStok_RenkUpdate_Eticaret(code, Renk, RenkVal)
                ElseIf Renk38 = "" Then
                    Renk38 = R
                    Renk = "Renk38"
                    RenkVal = Renk38
                    tbStok_RenkUpdate_Eticaret(code, Renk, RenkVal)
                ElseIf Renk39 = "" Then
                    Renk39 = R
                    Renk = "Renk39"
                    RenkVal = Renk39
                    tbStok_RenkUpdate_Eticaret(code, Renk, RenkVal)
                ElseIf Renk40 = "" Then
                    Renk40 = R
                    Renk = "Renk40"
                    RenkVal = Renk40
                    tbStok_RenkUpdate_Eticaret(code, Renk, RenkVal)
                ElseIf Renk41 = "" Then
                    Renk41 = R
                    Renk = "Renk41"
                    RenkVal = Renk41
                    tbStok_RenkUpdate_Eticaret(code, Renk, RenkVal)
                ElseIf Renk42 = "" Then
                    Renk42 = R
                    Renk = "Renk42"
                    RenkVal = Renk42
                    tbStok_RenkUpdate_Eticaret(code, Renk, RenkVal)
                ElseIf Renk43 = "" Then
                    Renk43 = R
                    Renk = "Renk43"
                    RenkVal = Renk43
                    tbStok_RenkUpdate_Eticaret(code, Renk, RenkVal)
                ElseIf Renk44 = "" Then
                    Renk44 = R
                    Renk = "Renk44"
                    RenkVal = Renk44
                    tbStok_RenkUpdate_Eticaret(code, Renk, RenkVal)
                ElseIf Renk45 = "" Then
                    Renk45 = R
                    Renk = "Renk45"
                    RenkVal = Renk45
                    tbStok_RenkUpdate_Eticaret(code, Renk, RenkVal)
                ElseIf Renk46 = "" Then
                    Renk46 = R
                    Renk = "Renk46"
                    RenkVal = Renk46
                    tbStok_RenkUpdate_Eticaret(code, Renk, RenkVal)
                ElseIf Renk47 = "" Then
                    Renk47 = R
                    Renk = "Renk47"
                    RenkVal = Renk47
                    tbStok_RenkUpdate_Eticaret(code, Renk, RenkVal)
                ElseIf Renk48 = "" Then
                    Renk48 = R
                    Renk = "Renk48"
                    RenkVal = Renk48
                    tbStok_RenkUpdate_Eticaret(code, Renk, RenkVal)
                ElseIf Renk49 = "" Then
                    Renk49 = R
                    Renk = "Renk49"
                    RenkVal = Renk49
                    tbStok_RenkUpdate_Eticaret(code, Renk, RenkVal)
                ElseIf Renk50 = "" Then
                    Renk50 = R
                    Renk = "Renk50"
                    RenkVal = Renk50
                    tbStok_RenkUpdate_Eticaret(code, Renk, RenkVal)
                ElseIf Renk51 = "" Then
                    Renk51 = R
                    Renk = "Renk51"
                    RenkVal = Renk51
                    tbStok_RenkUpdate_Eticaret(code, Renk, RenkVal)
                ElseIf Renk52 = "" Then
                    Renk52 = R
                    Renk = "Renk52"
                    RenkVal = Renk52
                    tbStok_RenkUpdate_Eticaret(code, Renk, RenkVal)
                ElseIf Renk53 = "" Then
                    Renk53 = R
                    Renk = "Renk53"
                    RenkVal = Renk53
                    tbStok_RenkUpdate_Eticaret(code, Renk, RenkVal)
                ElseIf Renk54 = "" Then
                    Renk54 = R
                    Renk = "Renk54"
                    RenkVal = Renk54
                    tbStok_RenkUpdate_Eticaret(code, Renk, RenkVal)
                ElseIf Renk55 = "" Then
                    Renk55 = R
                    Renk = "Renk55"
                    RenkVal = Renk55
                    tbStok_RenkUpdate_Eticaret(code, Renk, RenkVal)
                ElseIf Renk56 = "" Then
                    Renk56 = R
                    Renk = "Renk56"
                    RenkVal = Renk56
                    tbStok_RenkUpdate_Eticaret(code, Renk, RenkVal)
                ElseIf Renk57 = "" Then
                    Renk57 = R
                    Renk = "Renk57"
                    RenkVal = Renk57
                    tbStok_RenkUpdate_Eticaret(code, Renk, RenkVal)
                ElseIf Renk58 = "" Then
                    Renk58 = R
                    Renk = "Renk58"
                    RenkVal = Renk58
                    tbStok_RenkUpdate_Eticaret(code, Renk, RenkVal)
                ElseIf Renk59 = "" Then
                    Renk59 = R
                    Renk = "Renk59"
                    RenkVal = Renk59
                    tbStok_RenkUpdate_Eticaret(code, Renk, RenkVal)
                ElseIf Renk60 = "" Then
                    Renk60 = R
                    Renk = "Renk60"
                    RenkVal = Renk60
                    tbStok_RenkUpdate_Eticaret(code, Renk, RenkVal)
                End If

                If Beden2 = "" Then
                    Beden2 = Bed
                    Beden = "Beden2"
                    BedenVal = Beden2
                    Fiyat = "Fiyat2"
                    tbStok_BedenUpdate_Eticaret(code, Beden, BedenVal, Fiyat, salePrice)
                ElseIf Beden3 = "" Then
                    Beden3 = Bed
                    Beden = "Beden3"
                    BedenVal = Beden3
                    Fiyat = "Fiyat3"
                    tbStok_BedenUpdate_Eticaret(code, Beden, BedenVal, Fiyat, salePrice)
                ElseIf Beden4 = "" Then
                    Beden4 = Bed
                    Beden = "Beden4"
                    BedenVal = Beden4
                    Fiyat = "Fiyat4"
                    tbStok_BedenUpdate_Eticaret(code, Beden, BedenVal, Fiyat, salePrice)
                ElseIf Beden5 = "" Then
                    Beden5 = Bed
                    Beden = "Beden5"
                    BedenVal = Beden5
                    Fiyat = "Fiyat5"
                    tbStok_BedenUpdate_Eticaret(code, Beden, BedenVal, Fiyat, salePrice)
                ElseIf Beden6 = "" Then
                    Beden6 = Bed
                    Beden = "Beden6"
                    BedenVal = Beden6
                    Fiyat = "Fiyat6"
                    tbStok_BedenUpdate_Eticaret(code, Beden, BedenVal, Fiyat, salePrice)
                ElseIf Beden7 = "" Then
                    Beden7 = Bed
                    Beden = "Beden7"
                    BedenVal = Beden7
                    Fiyat = "Fiyat7"
                    tbStok_BedenUpdate_Eticaret(code, Beden, BedenVal, Fiyat, salePrice)
                ElseIf Beden8 = "" Then
                    Beden8 = Bed
                    Beden = "Beden8"
                    BedenVal = Beden8
                    Fiyat = "Fiyat8"
                    tbStok_BedenUpdate_Eticaret(code, Beden, BedenVal, Fiyat, salePrice)
                ElseIf Beden9 = "" Then
                    Beden9 = Bed
                    Beden = "Beden9"
                    BedenVal = Beden9
                    Fiyat = "Fiyat9"
                    tbStok_BedenUpdate_Eticaret(code, Beden, BedenVal, Fiyat, salePrice)
                ElseIf Beden10 = "" Then
                    Beden10 = Bed
                    Beden = "Beden10"
                    BedenVal = Beden10
                    Fiyat = "Fiyat10"
                    tbStok_BedenUpdate_Eticaret(code, Beden, BedenVal, Fiyat, salePrice)
                ElseIf Beden11 = "" Then
                    Beden11 = Bed
                    Beden = "Beden11"
                    BedenVal = Beden11
                    Fiyat = "Fiyat11"
                    tbStok_BedenUpdate_Eticaret(code, Beden, BedenVal, Fiyat, salePrice)
                ElseIf Beden12 = "" Then
                    Beden12 = Bed
                    Beden = "Beden12"
                    BedenVal = Beden12
                    Fiyat = "Fiyat12"
                    tbStok_BedenUpdate_Eticaret(code, Beden, BedenVal, Fiyat, salePrice)
                ElseIf Beden13 = "" Then
                    Beden13 = Bed
                    Beden = "Beden13"
                    BedenVal = Beden13
                    Fiyat = "Fiyat13"
                    tbStok_BedenUpdate_Eticaret(code, Beden, BedenVal, Fiyat, salePrice)
                ElseIf Beden14 = "" Then
                    Beden14 = Bed
                    Beden = "Beden14"
                    BedenVal = Beden14
                    Fiyat = "Fiyat14"
                    tbStok_BedenUpdate_Eticaret(code, Beden, BedenVal, Fiyat, salePrice)
                ElseIf Beden15 = "" Then
                    Beden15 = Bed
                    Beden = "Beden15"
                    BedenVal = Beden15
                    Fiyat = "Fiyat15"
                    tbStok_BedenUpdate_Eticaret(code, Beden, BedenVal, Fiyat, salePrice)
                ElseIf Beden16 = "" Then
                    Beden16 = Bed
                    Beden = "Beden16"
                    BedenVal = Beden16
                    Fiyat = "Fiyat16"
                    tbStok_BedenUpdate_Eticaret(code, Beden, BedenVal, Fiyat, salePrice)
                ElseIf Beden17 = "" Then
                    Beden17 = Bed
                    Beden = "Beden17"
                    BedenVal = Beden17
                    Fiyat = "Fiyat17"
                    tbStok_BedenUpdate_Eticaret(code, Beden, BedenVal, Fiyat, salePrice)
                ElseIf Beden18 = "" Then
                    Beden18 = Bed
                    Beden = "Beden18"
                    BedenVal = Beden18
                    Fiyat = "Fiyat18"
                    tbStok_BedenUpdate_Eticaret(code, Beden, BedenVal, Fiyat, salePrice)
                ElseIf Beden19 = "" Then
                    Beden19 = Bed
                    Beden = "Beden19"
                    BedenVal = Beden19
                    Fiyat = "Fiyat19"
                    tbStok_BedenUpdate_Eticaret(code, Beden, BedenVal, Fiyat, salePrice)
                ElseIf Beden20 = "" Then
                    Beden20 = Bed
                    Beden = "Beden20"
                    BedenVal = Beden20
                    Fiyat = "Fiyat20"
                    tbStok_BedenUpdate_Eticaret(code, Beden, BedenVal, Fiyat, salePrice)
                ElseIf Beden21 = "" Then
                    Beden21 = Bed
                    Beden = "Beden21"
                    BedenVal = Beden21
                    Fiyat = "Fiyat21"
                    tbStok_BedenUpdate_Eticaret(code, Beden, BedenVal, Fiyat, salePrice)
                ElseIf Beden22 = "" Then
                    Beden22 = Bed
                    Beden = "Beden22"
                    BedenVal = Beden22
                    Fiyat = "Fiyat22"
                    tbStok_BedenUpdate_Eticaret(code, Beden, BedenVal, Fiyat, salePrice)
                ElseIf Beden23 = "" Then
                    Beden23 = Bed
                    Beden = "Beden23"
                    BedenVal = Beden23
                    Fiyat = "Fiyat23"
                    tbStok_BedenUpdate_Eticaret(code, Beden, BedenVal, Fiyat, salePrice)
                ElseIf Beden24 = "" Then
                    Beden24 = Bed
                    Beden = "Beden24"
                    BedenVal = Beden24
                    Fiyat = "Fiyat24"
                    tbStok_BedenUpdate_Eticaret(code, Beden, BedenVal, Fiyat, salePrice)
                ElseIf Beden25 = "" Then
                    Beden25 = Bed
                    Beden = "Beden25"
                    BedenVal = Beden25
                    Fiyat = "Fiyat25"
                    tbStok_BedenUpdate_Eticaret(code, Beden, BedenVal, Fiyat, salePrice)
                ElseIf Beden26 = "" Then
                    Beden26 = Bed
                    Beden = "Beden26"
                    BedenVal = Beden26
                    Fiyat = "Fiyat26"
                    tbStok_BedenUpdate_Eticaret(code, Beden, BedenVal, Fiyat, salePrice)
                ElseIf Beden27 = "" Then
                    Beden27 = Bed
                    Beden = "Beden27"
                    BedenVal = Beden27
                    Fiyat = "Fiyat27"
                    tbStok_BedenUpdate_Eticaret(code, Beden, BedenVal, Fiyat, salePrice)
                ElseIf Beden28 = "" Then
                    Beden28 = Bed
                    Beden = "Beden28"
                    BedenVal = Beden28
                    Fiyat = "Fiyat28"
                    tbStok_BedenUpdate_Eticaret(code, Beden, BedenVal, Fiyat, salePrice)
                ElseIf Beden29 = "" Then
                    Beden29 = Bed
                    Beden = "Beden29"
                    BedenVal = Beden29
                    Fiyat = "Fiyat29"
                    tbStok_BedenUpdate_Eticaret(code, Beden, BedenVal, Fiyat, salePrice)
                ElseIf Beden30 = "" Then
                    Beden30 = Bed
                    Beden = "Beden30"
                    BedenVal = Beden30
                    Fiyat = "Fiyat30"
                    tbStok_BedenUpdate_Eticaret(code, Beden, BedenVal, Fiyat, salePrice)
                ElseIf Beden31 = "" Then
                    Beden31 = Bed
                    Beden = "Beden31"
                    BedenVal = Beden31
                    Fiyat = "Fiyat31"
                    tbStok_BedenUpdate_Eticaret(code, Beden, BedenVal, Fiyat, salePrice)
                ElseIf Beden32 = "" Then
                    Beden32 = Bed
                    Beden = "Beden32"
                    BedenVal = Beden32
                    Fiyat = "Fiyat32"
                    tbStok_BedenUpdate_Eticaret(code, Beden, BedenVal, Fiyat, salePrice)
                ElseIf Beden33 = "" Then
                    Beden33 = Bed
                    Beden = "Beden33"
                    BedenVal = Beden33
                    Fiyat = "Fiyat33"
                    tbStok_BedenUpdate_Eticaret(code, Beden, BedenVal, Fiyat, salePrice)
                ElseIf Beden34 = "" Then
                    Beden34 = Bed
                    Beden = "Beden34"
                    BedenVal = Beden34
                    Fiyat = "Fiyat34"
                    tbStok_BedenUpdate_Eticaret(code, Beden, BedenVal, Fiyat, salePrice)
                ElseIf Beden35 = "" Then
                    Beden35 = Bed
                    Beden = "Beden35"
                    BedenVal = Beden35
                    Fiyat = "Fiyat35"
                    tbStok_BedenUpdate_Eticaret(code, Beden, BedenVal, Fiyat, salePrice)
                ElseIf Beden36 = "" Then
                    Beden36 = Bed
                    Beden = "Beden36"
                    BedenVal = Beden36
                    Fiyat = "Fiyat36"
                    tbStok_BedenUpdate_Eticaret(code, Beden, BedenVal, Fiyat, salePrice)
                ElseIf Beden37 = "" Then
                    Beden37 = Bed
                    Beden = "Beden37"
                    BedenVal = Beden37
                    Fiyat = "Fiyat37"
                    tbStok_BedenUpdate_Eticaret(code, Beden, BedenVal, Fiyat, salePrice)
                ElseIf Beden38 = "" Then
                    Beden38 = Bed
                    Beden = "Beden38"
                    BedenVal = Beden38
                    Fiyat = "Fiyat38"
                    tbStok_BedenUpdate_Eticaret(code, Beden, BedenVal, Fiyat, salePrice)
                ElseIf Beden39 = "" Then
                    Beden39 = Bed
                    Beden = "Beden39"
                    BedenVal = Beden39
                    Fiyat = "Fiyat39"
                    tbStok_BedenUpdate_Eticaret(code, Beden, BedenVal, Fiyat, salePrice)
                ElseIf Beden40 = "" Then
                    Beden40 = Bed
                    Beden = "Beden40"
                    BedenVal = Beden40
                    Fiyat = "Fiyat40"
                    tbStok_BedenUpdate_Eticaret(code, Beden, BedenVal, Fiyat, salePrice)
                ElseIf Beden41 = "" Then
                    Beden41 = Bed
                    Beden = "Beden41"
                    BedenVal = Beden41
                    Fiyat = "Fiyat41"
                    tbStok_BedenUpdate_Eticaret(code, Beden, BedenVal, Fiyat, salePrice)
                ElseIf Beden42 = "" Then
                    Beden42 = Bed
                    Beden = "Beden42"
                    BedenVal = Beden42
                    Fiyat = "Fiyat42"
                    tbStok_BedenUpdate_Eticaret(code, Beden, BedenVal, Fiyat, salePrice)
                ElseIf Beden43 = "" Then
                    Beden43 = Bed
                    Beden = "Beden43"
                    BedenVal = Beden43
                    Fiyat = "Fiyat43"
                    tbStok_BedenUpdate_Eticaret(code, Beden, BedenVal, Fiyat, salePrice)
                ElseIf Beden44 = "" Then
                    Beden44 = Bed
                    Beden = "Beden44"
                    BedenVal = Beden44
                    Fiyat = "Fiyat44"
                    tbStok_BedenUpdate_Eticaret(code, Beden, BedenVal, Fiyat, salePrice)
                ElseIf Beden45 = "" Then
                    Beden45 = Bed
                    Beden = "Beden45"
                    BedenVal = Beden45
                    Fiyat = "Fiyat45"
                    tbStok_BedenUpdate_Eticaret(code, Beden, BedenVal, Fiyat, salePrice)
                ElseIf Beden46 = "" Then
                    Beden46 = Bed
                    Beden = "Beden46"
                    BedenVal = Beden46
                    Fiyat = "Fiyat46"
                    tbStok_BedenUpdate_Eticaret(code, Beden, BedenVal, Fiyat, salePrice)
                ElseIf Beden47 = "" Then
                    Beden47 = Bed
                    Beden = "Beden47"
                    BedenVal = Beden47
                    Fiyat = "Fiyat47"
                    tbStok_BedenUpdate_Eticaret(code, Beden, BedenVal, Fiyat, salePrice)
                ElseIf Beden48 = "" Then
                    Beden48 = Bed
                    Beden = "Beden48"
                    BedenVal = Beden48
                    Fiyat = "Fiyat48"
                    tbStok_BedenUpdate_Eticaret(code, Beden, BedenVal, Fiyat, salePrice)
                ElseIf Beden49 = "" Then
                    Beden49 = Bed
                    Beden = "Beden49"
                    BedenVal = Beden49
                    Fiyat = "Fiyat49"
                    tbStok_BedenUpdate_Eticaret(code, Beden, BedenVal, Fiyat, salePrice)
                ElseIf Beden50 = "" Then
                    Beden50 = Bed
                    Beden = "Beden50"
                    BedenVal = Beden50
                    Fiyat = "Fiyat50"
                    tbStok_BedenUpdate_Eticaret(code, Beden, BedenVal, Fiyat, salePrice)
                ElseIf Beden51 = "" Then
                    Beden51 = Bed
                    Beden = "Beden51"
                    BedenVal = Beden51
                    Fiyat = "Fiyat51"
                    tbStok_BedenUpdate_Eticaret(code, Beden, BedenVal, Fiyat, salePrice)
                ElseIf Beden52 = "" Then
                    Beden52 = Bed
                    Beden = "Beden52"
                    BedenVal = Beden52
                    Fiyat = "Fiyat52"
                    tbStok_BedenUpdate_Eticaret(code, Beden, BedenVal, Fiyat, salePrice)
                ElseIf Beden53 = "" Then
                    Beden53 = Bed
                    Beden = "Beden53"
                    BedenVal = Beden53
                    Fiyat = "Fiyat53"
                    tbStok_BedenUpdate_Eticaret(code, Beden, BedenVal, Fiyat, salePrice)
                ElseIf Beden54 = "" Then
                    Beden54 = Bed
                    Beden = "Beden54"
                    BedenVal = Beden54
                    Fiyat = "Fiyat54"
                    tbStok_BedenUpdate_Eticaret(code, Beden, BedenVal, Fiyat, salePrice)
                ElseIf Beden55 = "" Then
                    Beden55 = Bed
                    Beden = "Beden55"
                    BedenVal = Beden55
                    Fiyat = "Fiyat55"
                    tbStok_BedenUpdate_Eticaret(code, Beden, BedenVal, Fiyat, salePrice)
                ElseIf Beden56 = "" Then
                    Beden56 = Bed
                    Beden = "Beden56"
                    BedenVal = Beden56
                    Fiyat = "Fiyat56"
                    tbStok_BedenUpdate_Eticaret(code, Beden, BedenVal, Fiyat, salePrice)
                ElseIf Beden57 = "" Then
                    Beden57 = Bed
                    Beden = "Beden57"
                    BedenVal = Beden57
                    Fiyat = "Fiyat57"
                    tbStok_BedenUpdate_Eticaret(code, Beden, BedenVal, Fiyat, salePrice)
                ElseIf Beden58 = "" Then
                    Beden58 = Bed
                    Beden = "Beden58"
                    BedenVal = Beden58
                    Fiyat = "Fiyat58"
                    tbStok_BedenUpdate_Eticaret(code, Beden, BedenVal, Fiyat, salePrice)
                ElseIf Beden59 = "" Then
                    Beden59 = Bed
                    Beden = "Beden59"
                    BedenVal = Beden59
                    Fiyat = "Fiyat59"
                    tbStok_BedenUpdate_Eticaret(code, Beden, BedenVal, Fiyat, salePrice)
                ElseIf Beden60 = "" Then
                    Beden60 = Bed
                    Beden = "Beden60"
                    BedenVal = Beden60
                    Fiyat = "Fiyat60"
                    tbStok_BedenUpdate_Eticaret(code, Beden, BedenVal, Fiyat, salePrice)
                End If


                If barcode2 = "" Then
                    barcode2 = Bar
                    Barkod = "Barcode2"
                    BarkodVal = barcode2
                    tbStok_BarkodUpdate_Eticaret(code, Barkod, BarkodVal)
                ElseIf barcode3 = "" Then
                    barcode3 = Bar
                    Barkod = "Barcode3"
                    BarkodVal = barcode3
                    tbStok_BarkodUpdate_Eticaret(code, Barkod, BarkodVal)
                ElseIf barcode4 = "" Then
                    barcode4 = Bar
                    Barkod = "Barcode4"
                    BarkodVal = barcode4
                    tbStok_BarkodUpdate_Eticaret(code, Barkod, BarkodVal)
                ElseIf barcode5 = "" Then
                    barcode5 = Bar
                    Barkod = "Barcode5"
                    BarkodVal = barcode5
                    tbStok_BarkodUpdate_Eticaret(code, Barkod, BarkodVal)
                ElseIf barcode6 = "" Then
                    barcode6 = Bar
                    Barkod = "Barcode6"
                    BarkodVal = barcode6
                    tbStok_BarkodUpdate_Eticaret(code, Barkod, BarkodVal)
                ElseIf barcode7 = "" Then
                    barcode7 = Bar
                    Barkod = "Barcode7"
                    BarkodVal = barcode7
                    tbStok_BarkodUpdate_Eticaret(code, Barkod, BarkodVal)
                ElseIf barcode8 = "" Then
                    barcode8 = Bar
                    Barkod = "Barcode8"
                    BarkodVal = barcode8
                    tbStok_BarkodUpdate_Eticaret(code, Barkod, BarkodVal)
                ElseIf barcode9 = "" Then
                    barcode9 = Bar
                    Barkod = "Barcode9"
                    BarkodVal = barcode9
                    tbStok_BarkodUpdate_Eticaret(code, Barkod, BarkodVal)
                ElseIf barcode10 = "" Then
                    barcode10 = Bar
                    Barkod = "Barcode10"
                    BarkodVal = barcode10
                    tbStok_BarkodUpdate_Eticaret(code, Barkod, BarkodVal)
                ElseIf barcode11 = "" Then
                    barcode11 = Bar
                    Barkod = "Barcode11"
                    BarkodVal = barcode11
                    tbStok_BarkodUpdate_Eticaret(code, Barkod, BarkodVal)
                ElseIf barcode12 = "" Then
                    barcode12 = Bar
                    Barkod = "Barcode12"
                    BarkodVal = barcode12
                    tbStok_BarkodUpdate_Eticaret(code, Barkod, BarkodVal)
                ElseIf barcode13 = "" Then
                    barcode13 = Bar
                    Barkod = "Barcode13"
                    BarkodVal = barcode13
                    tbStok_BarkodUpdate_Eticaret(code, Barkod, BarkodVal)
                ElseIf barcode14 = "" Then
                    barcode14 = Bar
                    Barkod = "Barcode14"
                    BarkodVal = barcode14
                    tbStok_BarkodUpdate_Eticaret(code, Barkod, BarkodVal)
                ElseIf barcode15 = "" Then
                    barcode15 = Bar
                    Barkod = "Barcode15"
                    BarkodVal = barcode15
                    tbStok_BarkodUpdate_Eticaret(code, Barkod, BarkodVal)
                ElseIf barcode16 = "" Then
                    barcode16 = Bar
                    Barkod = "Barcode16"
                    BarkodVal = barcode16
                    tbStok_BarkodUpdate_Eticaret(code, Barkod, BarkodVal)
                ElseIf barcode17 = "" Then
                    barcode17 = Bar
                    Barkod = "Barcode17"
                    BarkodVal = barcode17
                    tbStok_BarkodUpdate_Eticaret(code, Barkod, BarkodVal)
                ElseIf barcode18 = "" Then
                    barcode18 = Bar
                    Barkod = "Barcode18"
                    BarkodVal = barcode18
                    tbStok_BarkodUpdate_Eticaret(code, Barkod, BarkodVal)
                ElseIf barcode19 = "" Then
                    barcode19 = Bar
                    Barkod = "Barcode19"
                    BarkodVal = barcode19
                    tbStok_BarkodUpdate_Eticaret(code, Barkod, BarkodVal)
                ElseIf barcode20 = "" Then
                    barcode20 = Bar
                    Barkod = "Barcode20"
                    BarkodVal = barcode20
                    tbStok_BarkodUpdate_Eticaret(code, Barkod, BarkodVal)
                ElseIf barcode21 = "" Then
                    barcode21 = Bar
                    Barkod = "Barcode21"
                    BarkodVal = barcode21
                    tbStok_BarkodUpdate_Eticaret(code, Barkod, BarkodVal)
                ElseIf barcode22 = "" Then
                    barcode22 = Bar
                    Barkod = "Barcode22"
                    BarkodVal = barcode22
                    tbStok_BarkodUpdate_Eticaret(code, Barkod, BarkodVal)
                ElseIf barcode23 = "" Then
                    barcode23 = Bar
                    Barkod = "Barcode23"
                    BarkodVal = barcode23
                    tbStok_BarkodUpdate_Eticaret(code, Barkod, BarkodVal)
                ElseIf barcode24 = "" Then
                    barcode24 = Bar
                    Barkod = "Barcode24"
                    BarkodVal = barcode24
                    tbStok_BarkodUpdate_Eticaret(code, Barkod, BarkodVal)
                ElseIf barcode25 = "" Then
                    barcode25 = Bar
                    Barkod = "Barcode25"
                    BarkodVal = barcode25
                    tbStok_BarkodUpdate_Eticaret(code, Barkod, BarkodVal)
                ElseIf barcode26 = "" Then
                    barcode26 = Bar
                    Barkod = "Barcode26"
                    BarkodVal = barcode26
                    tbStok_BarkodUpdate_Eticaret(code, Barkod, BarkodVal)
                ElseIf barcode27 = "" Then
                    barcode27 = Bar
                    Barkod = "Barcode27"
                    BarkodVal = barcode27
                    tbStok_BarkodUpdate_Eticaret(code, Barkod, BarkodVal)
                ElseIf barcode28 = "" Then
                    barcode28 = Bar
                    Barkod = "Barcode28"
                    BarkodVal = barcode28
                    tbStok_BarkodUpdate_Eticaret(code, Barkod, BarkodVal)
                ElseIf barcode29 = "" Then
                    barcode29 = Bar
                    Barkod = "Barcode29"
                    BarkodVal = barcode29
                    tbStok_BarkodUpdate_Eticaret(code, Barkod, BarkodVal)
                ElseIf barcode30 = "" Then
                    barcode30 = Bar
                    Barkod = "Barcode30"
                    BarkodVal = barcode30
                    tbStok_BarkodUpdate_Eticaret(code, Barkod, BarkodVal)
                ElseIf barcode31 = "" Then
                    barcode31 = Bar
                    Barkod = "Barcode31"
                    BarkodVal = barcode31
                    tbStok_BarkodUpdate_Eticaret(code, Barkod, BarkodVal)
                ElseIf barcode32 = "" Then
                    barcode32 = Bar
                    Barkod = "Barcode32"
                    BarkodVal = barcode32
                    tbStok_BarkodUpdate_Eticaret(code, Barkod, BarkodVal)
                ElseIf barcode33 = "" Then
                    barcode33 = Bar
                    Barkod = "Barcode33"
                    BarkodVal = barcode33
                    tbStok_BarkodUpdate_Eticaret(code, Barkod, BarkodVal)
                ElseIf barcode34 = "" Then
                    barcode34 = Bar
                    Barkod = "Barcode34"
                    BarkodVal = barcode34
                    tbStok_BarkodUpdate_Eticaret(code, Barkod, BarkodVal)
                ElseIf barcode35 = "" Then
                    barcode35 = Bar
                    Barkod = "Barcode35"
                    BarkodVal = barcode35
                    tbStok_BarkodUpdate_Eticaret(code, Barkod, BarkodVal)
                ElseIf barcode36 = "" Then
                    barcode36 = Bar
                    Barkod = "Barcode36"
                    BarkodVal = barcode36
                    tbStok_BarkodUpdate_Eticaret(code, Barkod, BarkodVal)
                ElseIf barcode37 = "" Then
                    barcode37 = Bar
                    Barkod = "Barcode37"
                    BarkodVal = barcode37
                    tbStok_BarkodUpdate_Eticaret(code, Barkod, BarkodVal)
                ElseIf barcode38 = "" Then
                    barcode38 = Bar
                    Barkod = "Barcode38"
                    BarkodVal = barcode38
                    tbStok_BarkodUpdate_Eticaret(code, Barkod, BarkodVal)
                ElseIf barcode39 = "" Then
                    barcode39 = Bar
                    Barkod = "Barcode39"
                    BarkodVal = barcode39
                    tbStok_BarkodUpdate_Eticaret(code, Barkod, BarkodVal)
                ElseIf barcode40 = "" Then
                    barcode40 = Bar
                    Barkod = "Barcode40"
                    BarkodVal = barcode40
                    tbStok_BarkodUpdate_Eticaret(code, Barkod, BarkodVal)
                ElseIf barcode41 = "" Then
                    barcode41 = Bar
                    Barkod = "Barcode41"
                    BarkodVal = barcode41
                    tbStok_BarkodUpdate_Eticaret(code, Barkod, BarkodVal)
                ElseIf barcode42 = "" Then
                    barcode42 = Bar
                    Barkod = "Barcode42"
                    BarkodVal = barcode42
                    tbStok_BarkodUpdate_Eticaret(code, Barkod, BarkodVal)
                ElseIf barcode43 = "" Then
                    barcode43 = Bar
                    Barkod = "Barcode43"
                    BarkodVal = barcode43
                    tbStok_BarkodUpdate_Eticaret(code, Barkod, BarkodVal)
                ElseIf barcode44 = "" Then
                    barcode44 = Bar
                    Barkod = "Barcode44"
                    BarkodVal = barcode44
                    tbStok_BarkodUpdate_Eticaret(code, Barkod, BarkodVal)
                ElseIf barcode45 = "" Then
                    barcode45 = Bar
                    Barkod = "Barcode45"
                    BarkodVal = barcode45
                    tbStok_BarkodUpdate_Eticaret(code, Barkod, BarkodVal)
                ElseIf barcode46 = "" Then
                    barcode46 = Bar
                    Barkod = "Barcode46"
                    BarkodVal = barcode46
                    tbStok_BarkodUpdate_Eticaret(code, Barkod, BarkodVal)
                ElseIf barcode47 = "" Then
                    barcode47 = Bar
                    Barkod = "Barcode47"
                    BarkodVal = barcode47
                    tbStok_BarkodUpdate_Eticaret(code, Barkod, BarkodVal)
                ElseIf barcode48 = "" Then
                    barcode48 = Bar
                    Barkod = "Barcode48"
                    BarkodVal = barcode48
                    tbStok_BarkodUpdate_Eticaret(code, Barkod, BarkodVal)
                ElseIf barcode49 = "" Then
                    barcode49 = Bar
                    Barkod = "Barcode49"
                    BarkodVal = barcode49
                    tbStok_BarkodUpdate_Eticaret(code, Barkod, BarkodVal)
                ElseIf barcode50 = "" Then
                    barcode50 = Bar
                    Barkod = "Barcode50"
                    BarkodVal = barcode50
                    tbStok_BarkodUpdate_Eticaret(code, Barkod, BarkodVal)
                ElseIf barcode51 = "" Then
                    barcode51 = Bar
                    Barkod = "Barcode51"
                    BarkodVal = barcode51
                    tbStok_BarkodUpdate_Eticaret(code, Barkod, BarkodVal)
                ElseIf barcode52 = "" Then
                    barcode52 = Bar
                    Barkod = "Barcode52"
                    BarkodVal = barcode52
                    tbStok_BarkodUpdate_Eticaret(code, Barkod, BarkodVal)
                ElseIf barcode53 = "" Then
                    barcode53 = Bar
                    Barkod = "Barcode53"
                    BarkodVal = barcode53
                    tbStok_BarkodUpdate_Eticaret(code, Barkod, BarkodVal)
                ElseIf barcode54 = "" Then
                    barcode54 = Bar
                    Barkod = "Barcode54"
                    BarkodVal = barcode54
                    tbStok_BarkodUpdate_Eticaret(code, Barkod, BarkodVal)
                ElseIf barcode55 = "" Then
                    barcode55 = Bar
                    Barkod = "Barcode55"
                    BarkodVal = barcode55
                    tbStok_BarkodUpdate_Eticaret(code, Barkod, BarkodVal)
                ElseIf barcode56 = "" Then
                    barcode56 = Bar
                    Barkod = "Barcode56"
                    BarkodVal = barcode56
                    tbStok_BarkodUpdate_Eticaret(code, Barkod, BarkodVal)
                ElseIf barcode57 = "" Then
                    barcode57 = Bar
                    Barkod = "Barcode57"
                    BarkodVal = barcode57
                    tbStok_BarkodUpdate_Eticaret(code, Barkod, BarkodVal)
                ElseIf barcode58 = "" Then
                    barcode58 = Bar
                    Barkod = "Barcode58"
                    BarkodVal = barcode58
                    tbStok_BarkodUpdate_Eticaret(code, Barkod, BarkodVal)
                ElseIf barcode59 = "" Then
                    barcode59 = Bar
                    Barkod = "Barcode59"
                    BarkodVal = barcode59
                    tbStok_BarkodUpdate_Eticaret(code, Barkod, BarkodVal)
                ElseIf barcode60 = "" Then
                    barcode60 = Bar
                    Barkod = "Barcode60"
                    BarkodVal = barcode60
                    tbStok_BarkodUpdate_Eticaret(code, Barkod, BarkodVal)
                End If

                If quantity2 = "-9999" Then
                    If Q > 0 Then
                        quantity2 = Q
                    Else
                        quantity2 = 0
                    End If
                    quantity = "quantity2"
                    quantityVal = quantity2
                    tbStok_quantityUpdate_Eticaret(code, quantity, quantityVal)
                ElseIf quantity3 = "-9999" Then
                    If Q > 0 Then
                        quantity3 = Q
                    Else
                        quantity3 = 0
                    End If
                    quantity = "quantity3"
                    quantityVal = quantity3
                    tbStok_quantityUpdate_Eticaret(code, quantity, quantityVal)
                ElseIf quantity4 = "-9999" Then
                    If Q > 0 Then
                        quantity4 = Q
                    Else
                        quantity4 = 0
                    End If
                    quantity = "quantity4"
                    quantityVal = quantity4
                    tbStok_quantityUpdate_Eticaret(code, quantity, quantityVal)
                ElseIf quantity5 = "-9999" Then
                    If Q > 0 Then
                        quantity5 = Q
                    Else
                        quantity5 = 0
                    End If
                    quantity = "quantity5"
                    quantityVal = quantity5
                    tbStok_quantityUpdate_Eticaret(code, quantity, quantityVal)
                ElseIf quantity6 = "-9999" Then
                    If Q > 0 Then
                        quantity6 = Q
                    Else
                        quantity6 = 0
                    End If
                    quantity = "quantity6"
                    quantityVal = quantity6
                    tbStok_quantityUpdate_Eticaret(code, quantity, quantityVal)
                ElseIf quantity7 = "-9999" Then
                    If Q > 0 Then
                        quantity7 = Q
                    Else
                        quantity7 = 0
                    End If
                    quantity = "quantity7"
                    quantityVal = quantity7
                    tbStok_quantityUpdate_Eticaret(code, quantity, quantityVal)
                ElseIf quantity8 = "-9999" Then
                    If Q > 0 Then
                        quantity8 = Q
                    Else
                        quantity8 = 0
                    End If
                    quantity = "quantity8"
                    quantityVal = quantity8
                    tbStok_quantityUpdate_Eticaret(code, quantity, quantityVal)
                ElseIf quantity9 = "-9999" Then
                    If Q > 0 Then
                        quantity9 = Q
                    Else
                        quantity9 = 0
                    End If
                    quantity = "quantity9"
                    quantityVal = quantity9
                    tbStok_quantityUpdate_Eticaret(code, quantity, quantityVal)
                ElseIf quantity10 = "-9999" Then
                    If Q > 0 Then
                        quantity10 = Q
                    Else
                        quantity10 = 0
                    End If
                    quantity = "quantity10"
                    quantityVal = quantity10
                    tbStok_quantityUpdate_Eticaret(code, quantity, quantityVal)
                ElseIf quantity11 = "-9999" Then
                    If Q > 0 Then
                        quantity11 = Q
                    Else
                        quantity11 = 0
                    End If
                    quantity = "quantity11"
                    quantityVal = quantity11
                    tbStok_quantityUpdate_Eticaret(code, quantity, quantityVal)
                ElseIf quantity12 = "-9999" Then
                    If Q > 0 Then
                        quantity12 = Q
                    Else
                        quantity12 = 0
                    End If
                    quantity = "quantity12"
                    quantityVal = quantity12
                    tbStok_quantityUpdate_Eticaret(code, quantity, quantityVal)
                ElseIf quantity13 = "-9999" Then
                    If Q > 0 Then
                        quantity13 = Q
                    Else
                        quantity13 = 0
                    End If
                    quantity = "quantity13"
                    quantityVal = quantity13
                    tbStok_quantityUpdate_Eticaret(code, quantity, quantityVal)
                ElseIf quantity14 = "-9999" Then
                    If Q > 0 Then
                        quantity14 = Q
                    Else
                        quantity14 = 0
                    End If
                    quantity = "quantity14"
                    quantityVal = quantity14
                    tbStok_quantityUpdate_Eticaret(code, quantity, quantityVal)
                ElseIf quantity15 = "-9999" Then
                    If Q > 0 Then
                        quantity15 = Q
                    Else
                        quantity15 = 0
                    End If
                    quantity = "quantity15"
                    quantityVal = quantity15
                    tbStok_quantityUpdate_Eticaret(code, quantity, quantityVal)
                ElseIf quantity16 = "-9999" Then
                    If Q > 0 Then
                        quantity16 = Q
                    Else
                        quantity16 = 0
                    End If
                    quantity = "quantity16"
                    quantityVal = quantity16
                    tbStok_quantityUpdate_Eticaret(code, quantity, quantityVal)
                ElseIf quantity17 = "-9999" Then
                    If Q > 0 Then
                        quantity17 = Q
                    Else
                        quantity17 = 0
                    End If
                    quantity = "quantity17"
                    quantityVal = quantity17
                    tbStok_quantityUpdate_Eticaret(code, quantity, quantityVal)
                ElseIf quantity18 = "-9999" Then
                    If Q > 0 Then
                        quantity18 = Q
                    Else
                        quantity18 = 0
                    End If
                    quantity = "quantity18"
                    quantityVal = quantity18
                    tbStok_quantityUpdate_Eticaret(code, quantity, quantityVal)
                ElseIf quantity19 = "-9999" Then
                    If Q > 0 Then
                        quantity19 = Q
                    Else
                        quantity19 = 0
                    End If
                    quantity = "quantity19"
                    quantityVal = quantity19
                    tbStok_quantityUpdate_Eticaret(code, quantity, quantityVal)
                ElseIf quantity20 = "-9999" Then
                    If Q > 0 Then
                        quantity20 = Q
                    Else
                        quantity20 = 0
                    End If
                    quantity = "quantity20"
                    quantityVal = quantity20
                    tbStok_quantityUpdate_Eticaret(code, quantity, quantityVal)
                ElseIf quantity21 = "-9999" Then
                    If Q > 0 Then
                        quantity21 = Q
                    Else
                        quantity21 = 0
                    End If
                    quantity = "quantity21"
                    quantityVal = quantity21
                    tbStok_quantityUpdate_Eticaret(code, quantity, quantityVal)
                ElseIf quantity22 = "-9999" Then
                    If Q > 0 Then
                        quantity22 = Q
                    Else
                        quantity22 = 0
                    End If
                    quantity = "quantity22"
                    quantityVal = quantity22
                    tbStok_quantityUpdate_Eticaret(code, quantity, quantityVal)
                ElseIf quantity23 = "-9999" Then
                    If Q > 0 Then
                        quantity23 = Q
                    Else
                        quantity23 = 0
                    End If
                    quantity = "quantity23"
                    quantityVal = quantity23
                    tbStok_quantityUpdate_Eticaret(code, quantity, quantityVal)
                ElseIf quantity24 = "-9999" Then
                    If Q > 0 Then
                        quantity24 = Q
                    Else
                        quantity24 = 0
                    End If
                    quantity = "quantity24"
                    quantityVal = quantity24
                    tbStok_quantityUpdate_Eticaret(code, quantity, quantityVal)
                ElseIf quantity25 = "-9999" Then
                    If Q > 0 Then
                        quantity25 = Q
                    Else
                        quantity25 = 0
                    End If
                    quantity = "quantity25"
                    quantityVal = quantity25
                    tbStok_quantityUpdate_Eticaret(code, quantity, quantityVal)
                ElseIf quantity26 = "-9999" Then
                    If Q > 0 Then
                        quantity26 = Q
                    Else
                        quantity26 = 0
                    End If
                    quantity = "quantity26"
                    quantityVal = quantity26
                    tbStok_quantityUpdate_Eticaret(code, quantity, quantityVal)
                ElseIf quantity27 = "-9999" Then
                    If Q > 0 Then
                        quantity27 = Q
                    Else
                        quantity27 = 0
                    End If
                    quantity = "quantity27"
                    quantityVal = quantity27
                    tbStok_quantityUpdate_Eticaret(code, quantity, quantityVal)
                ElseIf quantity28 = "-9999" Then
                    If Q > 0 Then
                        quantity28 = Q
                    Else
                        quantity28 = 0
                    End If
                    quantity = "quantity28"
                    quantityVal = quantity28
                    tbStok_quantityUpdate_Eticaret(code, quantity, quantityVal)
                ElseIf quantity29 = "-9999" Then
                    If Q > 0 Then
                        quantity29 = Q
                    Else
                        quantity29 = 0
                    End If
                    quantity = "quantity29"
                    quantityVal = quantity29
                    tbStok_quantityUpdate_Eticaret(code, quantity, quantityVal)
                ElseIf quantity30 = "-9999" Then
                    If Q > 0 Then
                        quantity30 = Q
                    Else
                        quantity30 = 0
                    End If
                    quantity = "quantity30"
                    quantityVal = quantity30
                    tbStok_quantityUpdate_Eticaret(code, quantity, quantityVal)
                ElseIf quantity31 = "-9999" Then
                    If Q > 0 Then
                        quantity31 = Q
                    Else
                        quantity31 = 0
                    End If
                    quantity = "quantity31"
                    quantityVal = quantity31
                    tbStok_quantityUpdate_Eticaret(code, quantity, quantityVal)
                ElseIf quantity32 = "-9999" Then
                    If Q > 0 Then
                        quantity32 = Q
                    Else
                        quantity32 = 0
                    End If
                    quantity = "quantity32"
                    quantityVal = quantity32
                    tbStok_quantityUpdate_Eticaret(code, quantity, quantityVal)
                ElseIf quantity33 = "-9999" Then
                    If Q > 0 Then
                        quantity33 = Q
                    Else
                        quantity33 = 0
                    End If
                    quantity = "quantity33"
                    quantityVal = quantity33
                    tbStok_quantityUpdate_Eticaret(code, quantity, quantityVal)
                ElseIf quantity34 = "-9999" Then
                    If Q > 0 Then
                        quantity34 = Q
                    Else
                        quantity34 = 0
                    End If
                    quantity = "quantity34"
                    quantityVal = quantity34
                    tbStok_quantityUpdate_Eticaret(code, quantity, quantityVal)
                ElseIf quantity35 = "-9999" Then
                    If Q > 0 Then
                        quantity35 = Q
                    Else
                        quantity35 = 0
                    End If
                    quantity = "quantity35"
                    quantityVal = quantity35
                    tbStok_quantityUpdate_Eticaret(code, quantity, quantityVal)
                ElseIf quantity36 = "-9999" Then
                    If Q > 0 Then
                        quantity36 = Q
                    Else
                        quantity36 = 0
                    End If
                    quantity = "quantity36"
                    quantityVal = quantity36
                    tbStok_quantityUpdate_Eticaret(code, quantity, quantityVal)
                ElseIf quantity37 = "-9999" Then
                    If Q > 0 Then
                        quantity37 = Q
                    Else
                        quantity37 = 0
                    End If
                    quantity = "quantity37"
                    quantityVal = quantity37
                    tbStok_quantityUpdate_Eticaret(code, quantity, quantityVal)
                ElseIf quantity38 = "-9999" Then
                    If Q > 0 Then
                        quantity38 = Q
                    Else
                        quantity38 = 0
                    End If
                    quantity = "quantity38"
                    quantityVal = quantity38
                    tbStok_quantityUpdate_Eticaret(code, quantity, quantityVal)
                ElseIf quantity39 = "-9999" Then
                    If Q > 0 Then
                        quantity39 = Q
                    Else
                        quantity39 = 0
                    End If
                    quantity = "quantity39"
                    quantityVal = quantity39
                    tbStok_quantityUpdate_Eticaret(code, quantity, quantityVal)
                ElseIf quantity40 = "-9999" Then
                    If Q > 0 Then
                        quantity40 = Q
                    Else
                        quantity40 = 0
                    End If
                    quantity = "quantity40"
                    quantityVal = quantity40
                    tbStok_quantityUpdate_Eticaret(code, quantity, quantityVal)
                ElseIf quantity41 = "-9999" Then
                    If Q > 0 Then
                        quantity41 = Q
                    Else
                        quantity41 = 0
                    End If
                    quantity = "quantity41"
                    quantityVal = quantity41
                    tbStok_quantityUpdate_Eticaret(code, quantity, quantityVal)
                ElseIf quantity42 = "-9999" Then
                    If Q > 0 Then
                        quantity42 = Q
                    Else
                        quantity42 = 0
                    End If
                    quantity = "quantity42"
                    quantityVal = quantity42
                    tbStok_quantityUpdate_Eticaret(code, quantity, quantityVal)
                ElseIf quantity43 = "-9999" Then
                    If Q > 0 Then
                        quantity43 = Q
                    Else
                        quantity43 = 0
                    End If
                    quantity = "quantity43"
                    quantityVal = quantity43
                    tbStok_quantityUpdate_Eticaret(code, quantity, quantityVal)
                ElseIf quantity44 = "-9999" Then
                    If Q > 0 Then
                        quantity44 = Q
                    Else
                        quantity44 = 0
                    End If
                    quantity = "quantity44"
                    quantityVal = quantity44
                    tbStok_quantityUpdate_Eticaret(code, quantity, quantityVal)
                ElseIf quantity45 = "-9999" Then
                    If Q > 0 Then
                        quantity45 = Q
                    Else
                        quantity45 = 0
                    End If
                    quantity = "quantity45"
                    quantityVal = quantity45
                    tbStok_quantityUpdate_Eticaret(code, quantity, quantityVal)
                ElseIf quantity46 = "-9999" Then
                    If Q > 0 Then
                        quantity46 = Q
                    Else
                        quantity46 = 0
                    End If
                    quantity = "quantity46"
                    quantityVal = quantity46
                    tbStok_quantityUpdate_Eticaret(code, quantity, quantityVal)
                ElseIf quantity47 = "-9999" Then
                    If Q > 0 Then
                        quantity47 = Q
                    Else
                        quantity47 = 0
                    End If
                    quantity = "quantity47"
                    quantityVal = quantity47
                    tbStok_quantityUpdate_Eticaret(code, quantity, quantityVal)
                ElseIf quantity48 = "-9999" Then
                    If Q > 0 Then
                        quantity48 = Q
                    Else
                        quantity48 = 0
                    End If
                    quantity = "quantity48"
                    quantityVal = quantity48
                    tbStok_quantityUpdate_Eticaret(code, quantity, quantityVal)
                ElseIf quantity49 = "-9999" Then
                    If Q > 0 Then
                        quantity49 = Q
                    Else
                        quantity49 = 0
                    End If
                    quantity = "quantity49"
                    quantityVal = quantity49
                    tbStok_quantityUpdate_Eticaret(code, quantity, quantityVal)
                ElseIf quantity50 = "-9999" Then
                    If Q > 0 Then
                        quantity50 = Q
                    Else
                        quantity50 = 0
                    End If
                    quantity = "quantity50"
                    quantityVal = quantity50
                    tbStok_quantityUpdate_Eticaret(code, quantity, quantityVal)
                ElseIf quantity51 = "-9999" Then
                    If Q > 0 Then
                        quantity51 = Q
                    Else
                        quantity51 = 0
                    End If
                    quantity = "quantity51"
                    quantityVal = quantity51
                    tbStok_quantityUpdate_Eticaret(code, quantity, quantityVal)
                ElseIf quantity52 = "-9999" Then
                    If Q > 0 Then
                        quantity52 = Q
                    Else
                        quantity52 = 0
                    End If
                    quantity = "quantity52"
                    quantityVal = quantity52
                    tbStok_quantityUpdate_Eticaret(code, quantity, quantityVal)
                ElseIf quantity53 = "-9999" Then
                    If Q > 0 Then
                        quantity53 = Q
                    Else
                        quantity53 = 0
                    End If
                    quantity = "quantity53"
                    quantityVal = quantity53
                    tbStok_quantityUpdate_Eticaret(code, quantity, quantityVal)
                ElseIf quantity54 = "-9999" Then
                    If Q > 0 Then
                        quantity54 = Q
                    Else
                        quantity54 = 0
                    End If
                    quantity = "quantity54"
                    quantityVal = quantity54
                    tbStok_quantityUpdate_Eticaret(code, quantity, quantityVal)
                ElseIf quantity55 = "-9999" Then
                    If Q > 0 Then
                        quantity55 = Q
                    Else
                        quantity55 = 0
                    End If
                    quantity = "quantity55"
                    quantityVal = quantity55
                    tbStok_quantityUpdate_Eticaret(code, quantity, quantityVal)
                ElseIf quantity56 = "-9999" Then
                    If Q > 0 Then
                        quantity56 = Q
                    Else
                        quantity56 = 0
                    End If
                    quantity = "quantity56"
                    quantityVal = quantity56
                    tbStok_quantityUpdate_Eticaret(code, quantity, quantityVal)
                ElseIf quantity57 = "-9999" Then
                    If Q > 0 Then
                        quantity57 = Q
                    Else
                        quantity57 = 0
                    End If
                    quantity = "quantity57"
                    quantityVal = quantity57
                    tbStok_quantityUpdate_Eticaret(code, quantity, quantityVal)
                ElseIf quantity58 = "-9999" Then
                    If Q > 0 Then
                        quantity58 = Q
                    Else
                        quantity58 = 0
                    End If
                    quantity = "quantity58"
                    quantityVal = quantity58
                    tbStok_quantityUpdate_Eticaret(code, quantity, quantityVal)
                ElseIf quantity59 = "-9999" Then
                    If Q > 0 Then
                        quantity59 = Q
                    Else
                        quantity59 = 0
                    End If
                    quantity = "quantity59"
                    quantityVal = quantity59
                    tbStok_quantityUpdate_Eticaret(code, quantity, quantityVal)
                ElseIf quantity60 = "-9999" Then
                    If Q > 0 Then
                        quantity60 = Q
                    Else
                        quantity60 = 0
                    End If
                    quantity = "quantity60"
                    quantityVal = quantity60
                    tbStok_quantityUpdate_Eticaret(code, quantity, quantityVal)
                End If

                If quantity1 > "0" Then
                    quantitys += quantity1
                    tbStok_quantitysUpdate_Eticaret(code, quantitys)
                ElseIf quantity2 > "0" Then
                    quantitys += quantity2
                    tbStok_quantitysUpdate_Eticaret(code, quantitys)
                ElseIf quantity3 > "0" Then
                    quantitys += quantity3
                    tbStok_quantitysUpdate_Eticaret(code, quantitys)
                ElseIf quantity4 > "0" Then
                    quantitys += quantity4
                    tbStok_quantitysUpdate_Eticaret(code, quantitys)
                ElseIf quantity5 > "0" Then
                    quantitys += quantity5
                    tbStok_quantitysUpdate_Eticaret(code, quantitys)
                ElseIf quantity6 > "0" Then
                    quantitys += quantity6
                    tbStok_quantitysUpdate_Eticaret(code, quantitys)
                ElseIf quantity7 > "0" Then
                    quantitys += quantity7
                    tbStok_quantitysUpdate_Eticaret(code, quantitys)
                ElseIf quantity8 > "0" Then
                    quantitys += quantity8
                    tbStok_quantitysUpdate_Eticaret(code, quantitys)
                ElseIf quantity9 > "0" Then
                    quantitys += quantity9
                    tbStok_quantitysUpdate_Eticaret(code, quantitys)
                ElseIf quantity10 > "0" Then
                    quantitys += quantity10
                    tbStok_quantitysUpdate_Eticaret(code, quantitys)
                ElseIf quantity11 > "0" Then
                    quantitys += quantity11
                    tbStok_quantitysUpdate_Eticaret(code, quantitys)
                ElseIf quantity12 > "0" Then
                    quantitys += quantity12
                    tbStok_quantitysUpdate_Eticaret(code, quantitys)
                ElseIf quantity13 > "0" Then
                    quantitys += quantity13
                    tbStok_quantitysUpdate_Eticaret(code, quantitys)
                ElseIf quantity14 > "0" Then
                    quantitys += quantity14
                    tbStok_quantitysUpdate_Eticaret(code, quantitys)
                ElseIf quantity15 > "0" Then
                    quantitys += quantity15
                    tbStok_quantitysUpdate_Eticaret(code, quantitys)
                ElseIf quantity16 > "0" Then
                    quantitys += quantity16
                    tbStok_quantitysUpdate_Eticaret(code, quantitys)
                ElseIf quantity17 > "0" Then
                    quantitys += quantity17
                    tbStok_quantitysUpdate_Eticaret(code, quantitys)
                ElseIf quantity18 > "0" Then
                    quantitys += quantity18
                    tbStok_quantitysUpdate_Eticaret(code, quantitys)
                ElseIf quantity19 > "0" Then
                    quantitys += quantity19
                    tbStok_quantitysUpdate_Eticaret(code, quantitys)
                ElseIf quantity20 > "0" Then
                    quantitys += quantity20
                    tbStok_quantitysUpdate_Eticaret(code, quantitys)
                ElseIf quantity21 > "0" Then
                    quantitys += quantity21
                    tbStok_quantitysUpdate_Eticaret(code, quantitys)
                ElseIf quantity22 > "0" Then
                    quantitys += quantity22
                    tbStok_quantitysUpdate_Eticaret(code, quantitys)
                ElseIf quantity23 > "0" Then
                    quantitys += quantity23
                    tbStok_quantitysUpdate_Eticaret(code, quantitys)
                ElseIf quantity24 > "0" Then
                    quantitys += quantity24
                    tbStok_quantitysUpdate_Eticaret(code, quantitys)
                ElseIf quantity25 > "0" Then
                    quantitys += quantity25
                    tbStok_quantitysUpdate_Eticaret(code, quantitys)
                ElseIf quantity26 > "0" Then
                    quantitys += quantity26
                    tbStok_quantitysUpdate_Eticaret(code, quantitys)
                ElseIf quantity27 > "0" Then
                    quantitys += quantity27
                    tbStok_quantitysUpdate_Eticaret(code, quantitys)
                ElseIf quantity28 > "0" Then
                    quantitys += quantity28
                    tbStok_quantitysUpdate_Eticaret(code, quantitys)
                ElseIf quantity29 > "0" Then
                    quantitys += quantity29
                    tbStok_quantitysUpdate_Eticaret(code, quantitys)
                ElseIf quantity30 > "0" Then
                    quantitys += quantity30
                    tbStok_quantitysUpdate_Eticaret(code, quantitys)
                ElseIf quantity31 > "0" Then
                    quantitys += quantity31
                    tbStok_quantitysUpdate_Eticaret(code, quantitys)
                ElseIf quantity32 > "0" Then
                    quantitys += quantity32
                    tbStok_quantitysUpdate_Eticaret(code, quantitys)
                ElseIf quantity33 > "0" Then
                    quantitys += quantity33
                    tbStok_quantitysUpdate_Eticaret(code, quantitys)
                ElseIf quantity34 > "0" Then
                    quantitys += quantity34
                    tbStok_quantitysUpdate_Eticaret(code, quantitys)
                ElseIf quantity35 > "0" Then
                    quantitys += quantity35
                    tbStok_quantitysUpdate_Eticaret(code, quantitys)
                ElseIf quantity36 > "0" Then
                    quantitys += quantity36
                    tbStok_quantitysUpdate_Eticaret(code, quantitys)
                ElseIf quantity37 > "0" Then
                    quantitys += quantity37
                    tbStok_quantitysUpdate_Eticaret(code, quantitys)
                ElseIf quantity38 > "0" Then
                    quantitys += quantity38
                    tbStok_quantitysUpdate_Eticaret(code, quantitys)
                ElseIf quantity39 > "0" Then
                    quantitys += quantity39
                    tbStok_quantitysUpdate_Eticaret(code, quantitys)
                ElseIf quantity40 > "0" Then
                    quantitys += quantity40
                    tbStok_quantitysUpdate_Eticaret(code, quantitys)
                ElseIf quantity41 > "0" Then
                    quantitys += quantity41
                    tbStok_quantitysUpdate_Eticaret(code, quantitys)
                ElseIf quantity42 > "0" Then
                    quantitys += quantity42
                    tbStok_quantitysUpdate_Eticaret(code, quantitys)
                ElseIf quantity43 > "0" Then
                    quantitys += quantity43
                    tbStok_quantitysUpdate_Eticaret(code, quantitys)
                ElseIf quantity44 > "0" Then
                    quantitys += quantity44
                    tbStok_quantitysUpdate_Eticaret(code, quantitys)
                ElseIf quantity45 > "0" Then
                    quantitys += quantity45
                    tbStok_quantitysUpdate_Eticaret(code, quantitys)
                ElseIf quantity46 > "0" Then
                    quantitys += quantity46
                    tbStok_quantitysUpdate_Eticaret(code, quantitys)
                ElseIf quantity47 > "0" Then
                    quantitys += quantity47
                    tbStok_quantitysUpdate_Eticaret(code, quantitys)
                ElseIf quantity48 > "0" Then
                    quantitys += quantity48
                    tbStok_quantitysUpdate_Eticaret(code, quantitys)
                ElseIf quantity49 > "0" Then
                    quantitys += quantity49
                    tbStok_quantitysUpdate_Eticaret(code, quantitys)
                ElseIf quantity50 > "0" Then
                    quantitys += quantity50
                    tbStok_quantitysUpdate_Eticaret(code, quantitys)
                ElseIf quantity51 > "0" Then
                    quantitys += quantity51
                    tbStok_quantitysUpdate_Eticaret(code, quantitys)
                ElseIf quantity52 > "0" Then
                    quantitys += quantity52
                    tbStok_quantitysUpdate_Eticaret(code, quantitys)
                ElseIf quantity53 > "0" Then
                    quantitys += quantity53
                    tbStok_quantitysUpdate_Eticaret(code, quantitys)
                ElseIf quantity54 > "0" Then
                    quantitys += quantity54
                    tbStok_quantitysUpdate_Eticaret(code, quantitys)
                ElseIf quantity55 > "0" Then
                    quantitys += quantity55
                    tbStok_quantitysUpdate_Eticaret(code, quantitys)
                ElseIf quantity56 > "0" Then
                    quantitys += quantity56
                    tbStok_quantitysUpdate_Eticaret(code, quantitys)
                ElseIf quantity57 > "0" Then
                    quantitys += quantity57
                    tbStok_quantitysUpdate_Eticaret(code, quantitys)
                ElseIf quantity58 > "0" Then
                    quantitys += quantity58
                    tbStok_quantitysUpdate_Eticaret(code, quantitys)
                ElseIf quantity59 > "0" Then
                    quantitys += quantity59
                    tbStok_quantitysUpdate_Eticaret(code, quantitys)
                ElseIf quantity60 > "0" Then
                    quantitys += quantity60
                    tbStok_quantitysUpdate_Eticaret(code, quantitys)
                End If




                tbStok_Update_Eticaret(code, buyPrice, salePrice, listPrice)

            End If
            con1.Close()
        Next
        ' JSON BAÞLANGIÇ


        Dim adapter As New OleDb.OleDbDataAdapter
        Dim cmd5 As New OleDb.OleDbCommand
        Dim con5 As New OleDb.OleDbConnection
        Dim dr4 As DataRow
        Dim DS4 As New DataSet

        con5.ConnectionString = connection
        con5.Open()
        cmd5.CommandText = "select nStokID, code, name,Guncel, ISNULL(Renk1,0)as Renk1, ISNULL(Beden1,0) as Beden1,  ISNULL(barcode1,0) as barcode1,  ISNULL(Fiyat1,0) as Fiyat1,  ISNULL(quantity1,0) as quantity1,  ISNULL(Renk2,0) as Renk2,  ISNULL(Beden2,0) as Beden2,  ISNULL(barcode2,0) as barcode2,  ISNULL(Fiyat2,0) as Fiyat2,  ISNULL(quantity2,0) as quantity2,  ISNULL(Renk3,0) as Renk3,  ISNULL(Beden3,0) as Beden3,  ISNULL(barcode3,0) as barcode3,  ISNULL(Fiyat3,0) as Fiyat3,  ISNULL(quantity3,0) as quantity3,  ISNULL(Renk4,0) as Renk4,  ISNULL(Beden4,0) as Beden4,  ISNULL(barcode4,0) as barcode4,  ISNULL(Fiyat4,0) as Fiyat4,  ISNULL(quantity4,0) as quantity4,  ISNULL(Renk5,0) as Renk5, ISNULL(Beden5,0) as Beden5, ISNULL(barcode5,0) as barcode5, ISNULL(quantity5,0) as quantity5, ISNULL(Fiyat5,0) as Fiyat5, ISNULL(Renk6,0) as Renk6, ISNULL(Beden6,0) as Beden6, ISNULL(barcode6,0) as barcode6, ISNULL(Fiyat6,0) as Fiyat6, ISNULL(quantity6,0) as quantity6, ISNULL(Renk7,0) as Renk7, ISNULL(Beden7,0) as Beden7, ISNULL(barcode7,0) as barcode7, ISNULL(Fiyat7,0) as Fiyat7, ISNULL(quantity7,0) as quantity7, ISNULL(Renk8,0) as Renk8, ISNULL(Beden8,0) as Beden8, ISNULL(barcode8,0) as barcode8, ISNULL(Fiyat8,0) as Fiyat8, ISNULL(quantity8,0) as quantity8, ISNULL(Renk9,0) as Renk9, ISNULL(Beden9,0) as Beden9, ISNULL(barcode9,0) as barcode9, ISNULL(Fiyat9,0) as Fiyat9, ISNULL(quantity9,0) as quantity9, ISNULL(Renk10,0) as Renk10, ISNULL(Beden10,0) as Beden10, ISNULL(barcode10,0) as barcode10, ISNULL(Fiyat10,0) as Fiyat10, ISNULL(quantity10,0) as quantity10, ISNULL(Renk11,0) as Renk11, ISNULL(Beden11,0) as Beden11, ISNULL(barcode11,0) as barcode11, ISNULL(Fiyat11,0) as Fiyat11, ISNULL(quantity11,0) as quantity11, ISNULL(Renk12,0) as Renk12, ISNULL(Beden12,0) as Beden12, ISNULL(barcode12,0) as barcode12, ISNULL(Fiyat12,0) as Fiyat12, ISNULL(quantity12,0) as quantity12, ISNULL(Renk13,0) as Renk13, ISNULL(Beden13,0) as Beden13, ISNULL(barcode13,0) as barcode13, ISNULL(Fiyat13,0) as Fiyat13, ISNULL(quantity13,0) as quantity13, ISNULL(Renk14,0) as Renk14, ISNULL(Beden14,0) as Beden14, ISNULL(barcode14,0) as barcode14, ISNULL(Fiyat14,0) as Fiyat14, ISNULL(quantity14,0) as quantity14, ISNULL(Renk15,0) as Renk15, ISNULL(Beden15,0) as Beden15, ISNULL(barcode15,0) as barcode15, ISNULL(Fiyat15,0) as Fiyat15, ISNULL(quantity15,0) as quantity15, ISNULL(Renk16,0) as Renk16, ISNULL(Beden16,0) as Beden16, ISNULL(barcode16,0) as barcode16, ISNULL(Fiyat16,0) as Fiyat16, ISNULL(quantity16,0) as quantity16, ISNULL(Renk17,0) as Renk17, ISNULL(Beden17,0) as Beden17, ISNULL(barcode17,0) as barcode17, ISNULL(Fiyat17,0) as Fiyat17, ISNULL(quantity17,0) as quantity17, ISNULL(Renk18,0) as Renk18, ISNULL(Beden18,0) as Beden18, ISNULL(barcode18,0) as barcode18, ISNULL(Fiyat18,0) as Fiyat18, ISNULL(quantity18,0) as quantity18, ISNULL(Renk19,0) as Renk19, ISNULL(Beden19,0) as Beden19, ISNULL(barcode19,0) as barcode19, ISNULL(Fiyat19,0) as Fiyat19, ISNULL(quantity19,0) as quantity19, ISNULL(Renk20,0) as Renk20, ISNULL(Beden20,0) as Beden20, ISNULL(barcode20,0) as barcode20, ISNULL(Fiyat20,0) as Fiyat20, ISNULL(quantity20,0) as quantity20, ISNULL(brand,0) as brand, ISNULL(category1,0) as category1, ISNULL(category2,0) as category2, ISNULL(category3,0) as category3, ISNULL(category4,0) as category4, ISNULL(category5,0) as category5,ISNULL(longDescription,0) as longDescription, ISNULL(seoTitle,0) as seoTitle, ISNULL(seoKeywords,0) as seoKeywords, ISNULL(seoDescription,0) as seoDescription, ISNULL(variant1Name,0) as variant1Name, ISNULL(variant2Name,0) as variant2Name, ISNULL(taxRate,0) as taxRate, ISNULL(shipmentPayment,0) as shipmentPayment, ISNULL(buyPrice,0) as buyPrice, ISNULL(listPrice,0) as listPrice, ISNULL(salePrice,0) as salePrice, ISNULL(TysalePrice,0) as TysalePrice, ISNULL(N11salePrice,0) as N11salePrice, ISNULL(GgsalePrice,0) as GgsalePrice, ISNULL(HbsalePrice,0) as HbsalePrice, ISNULL(EpttsalePrice,0) as EpttsalePrice, ISNULL(CssalePrice,0) as CssalePrice, ISNULL(amzsalePrice,0) as amzsalePrice, ISNULL(NewsalePrice,0) as NewsalePrice, ISNULL(quantity,0) as quantity, ISNULL(imageUrl,0) as imageUrl, ISNULL(imageUrl1,0) as imageUrl1, ISNULL(imageUrl2,0) as imageUrl2, ISNULL(imageUrl3,0) as imageUrl3, ISNULL(imageUrl4,0) as imageUrl4, ISNULL(imageUrl5,0) as imageUrl5, ISNULL(imageUrl6,0) as imageUrl6, ISNULL(imageUrl7,0) as imageUrl7, ISNULL(imageUrl8,0) as imageUrl8, ISNULL(imageUrl9,0) as imageUrl9, ISNULL(imageUrl10,0) as imageUrl10, ISNULL(dteGuncelZaman,0) as dteGuncelZaman from tbStokEticaret where Guncel = '0' "
        cmd5.Connection = con5
        adapter.SelectCommand = cmd5
        N = adapter.Fill(DS4, "Table1")

        For Each dr4 In DS4.Tables(0).Rows

            dr4("nStokID") = dr4("nStokID").ToString
            dr4("code") = Trim(dr4("code").ToString)
            dr4("name") = dr4("name").ToString
            dr4("Renk1") = Trim(dr4("Renk1").ToString)
            dr4("Renk2") = Trim(dr4("Renk2").ToString)
            dr4("Renk3") = Trim(dr4("Renk3").ToString)
            dr4("Renk4") = Trim(dr4("Renk4").ToString)
            dr4("Renk5") = Trim(dr4("Renk5").ToString)
            dr4("Renk6") = Trim(dr4("Renk6").ToString)
            dr4("Renk7") = Trim(dr4("Renk7").ToString)
            dr4("Renk8") = Trim(dr4("Renk8").ToString)
            dr4("Renk9") = Trim(dr4("Renk9").ToString)
            dr4("Renk10") = Trim(dr4("Renk10").ToString)
            dr4("Renk11") = Trim(dr4("Renk11").ToString)
            dr4("Renk12") = Trim(dr4("Renk12").ToString)
            dr4("Renk13") = Trim(dr4("Renk13").ToString)
            dr4("Renk14") = Trim(dr4("Renk14").ToString)
            dr4("Renk15") = Trim(dr4("Renk15").ToString)
            dr4("Renk16") = Trim(dr4("Renk16").ToString)
            dr4("Renk17") = Trim(dr4("Renk17").ToString)
            dr4("Renk18") = Trim(dr4("Renk18").ToString)
            dr4("Renk19") = Trim(dr4("Renk19").ToString)
            dr4("Renk20") = Trim(dr4("Renk20").ToString)
            dr4("Renk21") = Trim(dr4("Renk21").ToString)
            dr4("Renk22") = Trim(dr4("Renk22").ToString)
            dr4("Renk23") = Trim(dr4("Renk23").ToString)
            dr4("Renk24") = Trim(dr4("Renk24").ToString)
            dr4("Renk25") = Trim(dr4("Renk25").ToString)
            dr4("Renk26") = Trim(dr4("Renk26").ToString)
            dr4("Renk27") = Trim(dr4("Renk27").ToString)
            dr4("Renk28") = Trim(dr4("Renk28").ToString)
            dr4("Renk29") = Trim(dr4("Renk29").ToString)
            dr4("Renk30") = Trim(dr4("Renk30").ToString)
            dr4("Renk31") = Trim(dr4("Renk31").ToString)
            dr4("Renk32") = Trim(dr4("Renk32").ToString)
            dr4("Renk33") = Trim(dr4("Renk33").ToString)
            dr4("Renk34") = Trim(dr4("Renk34").ToString)
            dr4("Renk35") = Trim(dr4("Renk35").ToString)
            dr4("Renk36") = Trim(dr4("Renk36").ToString)
            dr4("Renk37") = Trim(dr4("Renk37").ToString)
            dr4("Renk38") = Trim(dr4("Renk38").ToString)
            dr4("Renk39") = Trim(dr4("Renk39").ToString)
            dr4("Renk40") = Trim(dr4("Renk40").ToString)
            dr4("Renk41") = Trim(dr4("Renk41").ToString)
            dr4("Renk42") = Trim(dr4("Renk42").ToString)
            dr4("Renk43") = Trim(dr4("Renk43").ToString)
            dr4("Renk44") = Trim(dr4("Renk44").ToString)
            dr4("Renk45") = Trim(dr4("Renk45").ToString)
            dr4("Renk46") = Trim(dr4("Renk46").ToString)
            dr4("Renk47") = Trim(dr4("Renk47").ToString)
            dr4("Renk48") = Trim(dr4("Renk48").ToString)
            dr4("Renk49") = Trim(dr4("Renk49").ToString)
            dr4("Renk50") = Trim(dr4("Renk50").ToString)
            dr4("Renk51") = Trim(dr4("Renk51").ToString)
            dr4("Renk52") = Trim(dr4("Renk52").ToString)
            dr4("Renk53") = Trim(dr4("Renk53").ToString)
            dr4("Renk54") = Trim(dr4("Renk54").ToString)
            dr4("Renk55") = Trim(dr4("Renk55").ToString)
            dr4("Renk56") = Trim(dr4("Renk56").ToString)
            dr4("Renk57") = Trim(dr4("Renk57").ToString)
            dr4("Renk58") = Trim(dr4("Renk58").ToString)
            dr4("Renk59") = Trim(dr4("Renk59").ToString)
            dr4("Renk60") = Trim(dr4("Renk60").ToString)
            dr4("Beden1") = Trim(dr4("Beden1").ToString)
            dr4("Beden2") = Trim(dr4("Beden2").ToString)
            dr4("Beden3") = Trim(dr4("Beden3").ToString)
            dr4("Beden4") = Trim(dr4("Beden4").ToString)
            dr4("Beden5") = Trim(dr4("Beden5").ToString)
            dr4("Beden6") = Trim(dr4("Beden6").ToString)
            dr4("Beden7") = Trim(dr4("Beden7").ToString)
            dr4("Beden8") = Trim(dr4("Beden8").ToString)
            dr4("Beden9") = Trim(dr4("Beden9").ToString)
            dr4("Beden10") = Trim(dr4("Beden10").ToString)
            dr4("Beden11") = Trim(dr4("Beden11").ToString)
            dr4("Beden12") = Trim(dr4("Beden12").ToString)
            dr4("Beden13") = Trim(dr4("Beden13").ToString)
            dr4("Beden14") = Trim(dr4("Beden14").ToString)
            dr4("Beden15") = Trim(dr4("Beden15").ToString)
            dr4("Beden16") = Trim(dr4("Beden16").ToString)
            dr4("Beden17") = Trim(dr4("Beden17").ToString)
            dr4("Beden18") = Trim(dr4("Beden18").ToString)
            dr4("Beden19") = Trim(dr4("Beden19").ToString)
            dr4("Beden20") = Trim(dr4("Beden20").ToString)
            dr4("Beden21") = Trim(dr4("Beden21").ToString)
            dr4("Beden22") = Trim(dr4("Beden22").ToString)
            dr4("Beden23") = Trim(dr4("Beden23").ToString)
            dr4("Beden24") = Trim(dr4("Beden24").ToString)
            dr4("Beden25") = Trim(dr4("Beden25").ToString)
            dr4("Beden26") = Trim(dr4("Beden26").ToString)
            dr4("Beden27") = Trim(dr4("Beden27").ToString)
            dr4("Beden28") = Trim(dr4("Beden28").ToString)
            dr4("Beden29") = Trim(dr4("Beden29").ToString)
            dr4("Beden30") = Trim(dr4("Beden30").ToString)
            dr4("Beden31") = Trim(dr4("Beden31").ToString)
            dr4("Beden32") = Trim(dr4("Beden32").ToString)
            dr4("Beden33") = Trim(dr4("Beden33").ToString)
            dr4("Beden34") = Trim(dr4("Beden34").ToString)
            dr4("Beden35") = Trim(dr4("Beden35").ToString)
            dr4("Beden36") = Trim(dr4("Beden36").ToString)
            dr4("Beden37") = Trim(dr4("Beden37").ToString)
            dr4("Beden38") = Trim(dr4("Beden38").ToString)
            dr4("Beden39") = Trim(dr4("Beden39").ToString)
            dr4("Beden40") = Trim(dr4("Beden40").ToString)
            dr4("Beden41") = Trim(dr4("Beden41").ToString)
            dr4("Beden42") = Trim(dr4("Beden42").ToString)
            dr4("Beden43") = Trim(dr4("Beden43").ToString)
            dr4("Beden44") = Trim(dr4("Beden44").ToString)
            dr4("Beden45") = Trim(dr4("Beden45").ToString)
            dr4("Beden46") = Trim(dr4("Beden46").ToString)
            dr4("Beden47") = Trim(dr4("Beden47").ToString)
            dr4("Beden48") = Trim(dr4("Beden48").ToString)
            dr4("Beden49") = Trim(dr4("Beden49").ToString)
            dr4("Beden50") = Trim(dr4("Beden50").ToString)
            dr4("Beden51") = Trim(dr4("Beden51").ToString)
            dr4("Beden52") = Trim(dr4("Beden52").ToString)
            dr4("Beden53") = Trim(dr4("Beden53").ToString)
            dr4("Beden54") = Trim(dr4("Beden54").ToString)
            dr4("Beden55") = Trim(dr4("Beden55").ToString)
            dr4("Beden56") = Trim(dr4("Beden56").ToString)
            dr4("Beden57") = Trim(dr4("Beden57").ToString)
            dr4("Beden58") = Trim(dr4("Beden58").ToString)
            dr4("Beden59") = Trim(dr4("Beden59").ToString)
            dr4("Beden60") = Trim(dr4("Beden60").ToString)
            dr4("barcode1") = Trim(dr4("barcode1").ToString)
            dr4("barcode2") = Trim(dr4("barcode2").ToString)
            dr4("barcode3") = Trim(dr4("barcode3").ToString)
            dr4("barcode4") = Trim(dr4("barcode4").ToString)
            dr4("barcode5") = Trim(dr4("barcode5").ToString)
            dr4("barcode6") = Trim(dr4("barcode6").ToString)
            dr4("barcode7") = Trim(dr4("barcode7").ToString)
            dr4("barcode8") = Trim(dr4("barcode8").ToString)
            dr4("barcode9") = Trim(dr4("barcode9").ToString)
            dr4("barcode10") = Trim(dr4("barcode10").ToString)
            dr4("barcode11") = Trim(dr4("barcode11").ToString)
            dr4("barcode12") = Trim(dr4("barcode12").ToString)
            dr4("barcode13") = Trim(dr4("barcode13").ToString)
            dr4("barcode14") = Trim(dr4("barcode14").ToString)
            dr4("barcode15") = Trim(dr4("barcode15").ToString)
            dr4("barcode16") = Trim(dr4("barcode16").ToString)
            dr4("barcode17") = Trim(dr4("barcode17").ToString)
            dr4("barcode18") = Trim(dr4("barcode18").ToString)
            dr4("barcode19") = Trim(dr4("barcode19").ToString)
            dr4("barcode20") = Trim(dr4("barcode20").ToString)
            dr4("barcode21") = Trim(dr4("barcode21").ToString)
            dr4("barcode22") = Trim(dr4("barcode22").ToString)
            dr4("barcode23") = Trim(dr4("barcode23").ToString)
            dr4("barcode24") = Trim(dr4("barcode24").ToString)
            dr4("barcode25") = Trim(dr4("barcode25").ToString)
            dr4("barcode26") = Trim(dr4("barcode26").ToString)
            dr4("barcode27") = Trim(dr4("barcode27").ToString)
            dr4("barcode28") = Trim(dr4("barcode28").ToString)
            dr4("barcode29") = Trim(dr4("barcode29").ToString)
            dr4("barcode30") = Trim(dr4("barcode30").ToString)
            dr4("barcode31") = Trim(dr4("barcode31").ToString)
            dr4("barcode32") = Trim(dr4("barcode32").ToString)
            dr4("barcode33") = Trim(dr4("barcode33").ToString)
            dr4("barcode34") = Trim(dr4("barcode34").ToString)
            dr4("barcode35") = Trim(dr4("barcode35").ToString)
            dr4("barcode36") = Trim(dr4("barcode36").ToString)
            dr4("barcode37") = Trim(dr4("barcode37").ToString)
            dr4("barcode38") = Trim(dr4("barcode38").ToString)
            dr4("barcode39") = Trim(dr4("barcode39").ToString)
            dr4("barcode40") = Trim(dr4("barcode40").ToString)
            dr4("barcode41") = Trim(dr4("barcode41").ToString)
            dr4("barcode42") = Trim(dr4("barcode42").ToString)
            dr4("barcode43") = Trim(dr4("barcode43").ToString)
            dr4("barcode44") = Trim(dr4("barcode44").ToString)
            dr4("barcode45") = Trim(dr4("barcode45").ToString)
            dr4("barcode46") = Trim(dr4("barcode46").ToString)
            dr4("barcode47") = Trim(dr4("barcode47").ToString)
            dr4("barcode48") = Trim(dr4("barcode48").ToString)
            dr4("barcode49") = Trim(dr4("barcode49").ToString)
            dr4("barcode50") = Trim(dr4("barcode50").ToString)
            dr4("barcode51") = Trim(dr4("barcode51").ToString)
            dr4("barcode52") = Trim(dr4("barcode52").ToString)
            dr4("barcode53") = Trim(dr4("barcode53").ToString)
            dr4("barcode54") = Trim(dr4("barcode54").ToString)
            dr4("barcode55") = Trim(dr4("barcode55").ToString)
            dr4("barcode56") = Trim(dr4("barcode56").ToString)
            dr4("barcode57") = Trim(dr4("barcode57").ToString)
            dr4("barcode58") = Trim(dr4("barcode58").ToString)
            dr4("barcode59") = Trim(dr4("barcode59").ToString)
            dr4("barcode60") = Trim(dr4("barcode60").ToString)
            dr4("imageUrl") = dr4("imageUrl").ToString
            dr4("imageUrl2") = dr4("imageUrl2").ToString
            dr4("imageUrl3") = dr4("imageUrl3").ToString
            dr4("imageUrl4") = dr4("imageUrl4").ToString
            dr4("imageUrl5") = dr4("imageUrl5").ToString
            dr4("imageUrl6") = dr4("imageUrl6").ToString
            dr4("imageUrl7") = dr4("imageUrl7").ToString
            dr4("imageUrl8") = dr4("imageUrl8").ToString
            dr4("imageUrl9") = dr4("imageUrl9").ToString
            dr4("imageUrl10") = dr4("imageUrl10").ToString
            dr4("taxRate") = dr4("taxRate").ToString
            dr4("shipmentPayment") = dr4("shipmentPayment").ToString
            dr4("buyPrice") = dr4("buyPrice").ToString
            dr4("listPrice") = dr4("listPrice").ToString
            dr4("longDescription") = dr4("longDescription").ToString
            dr4("salePrice") = dr4("salePrice").ToString
            dr4("quantity") = dr4("quantity").ToString
            dr4("dteGuncelZaman") = dr4("dteGuncelZaman").ToString
            priceStatus = 1
            price = dr4("salePrice").ToString
            dr4("TysalePrice") = Trim(dr4("TysalePrice").ToString)
            dr4("N11salePrice") = Trim(dr4("N11salePrice").ToString)
            dr4("GgsalePrice") = Trim(dr4("GgsalePrice").ToString)
            dr4("HbsalePrice") = Trim(dr4("HbsalePrice").ToString)
            dr4("CssalePrice") = Trim(dr4("CssalePrice").ToString)
            dr4("EpttsalePrice") = Trim(dr4("EpttsalePrice").ToString)
            dr4("AmzsalePrice") = Trim(dr4("AmzsalePrice").ToString)
            dr4("quantity1") = Trim(dr4("quantity1").ToString)
            dr4("quantity2") = Trim(dr4("quantity2").ToString)
            dr4("quantity3") = Trim(dr4("quantity3").ToString)
            dr4("quantity4") = Trim(dr4("quantity4").ToString)
            dr4("quantity5") = Trim(dr4("quantity5").ToString)
            dr4("quantity6") = Trim(dr4("quantity6").ToString)
            dr4("quantity7") = Trim(dr4("quantity7").ToString)
            dr4("quantity8") = Trim(dr4("quantity8").ToString)
            dr4("quantity9") = Trim(dr4("quantity9").ToString)
            dr4("quantity10") = Trim(dr4("quantity10").ToString)
            dr4("quantity11") = Trim(dr4("quantity11").ToString)
            dr4("quantity12") = Trim(dr4("quantity12").ToString)
            dr4("quantity13") = Trim(dr4("quantity13").ToString)
            dr4("quantity14") = Trim(dr4("quantity14").ToString)
            dr4("quantity15") = Trim(dr4("quantity15").ToString)
            dr4("quantity16") = Trim(dr4("quantity16").ToString)
            dr4("quantity17") = Trim(dr4("quantity17").ToString)
            dr4("quantity18") = Trim(dr4("quantity18").ToString)
            dr4("quantity19") = Trim(dr4("quantity19").ToString)
            dr4("quantity20") = Trim(dr4("quantity20").ToString)
            dr4("quantity21") = Trim(dr4("quantity21").ToString)
            dr4("quantity22") = Trim(dr4("quantity22").ToString)
            dr4("quantity23") = Trim(dr4("quantity23").ToString)
            dr4("quantity24") = Trim(dr4("quantity24").ToString)
            dr4("quantity25") = Trim(dr4("quantity25").ToString)
            dr4("quantity26") = Trim(dr4("quantity26").ToString)
            dr4("quantity27") = Trim(dr4("quantity27").ToString)
            dr4("quantity28") = Trim(dr4("quantity28").ToString)
            dr4("quantity29") = Trim(dr4("quantity29").ToString)
            dr4("quantity30") = Trim(dr4("quantity30").ToString)
            dr4("quantity31") = Trim(dr4("quantity31").ToString)
            dr4("quantity32") = Trim(dr4("quantity32").ToString)
            dr4("quantity33") = Trim(dr4("quantity33").ToString)
            dr4("quantity34") = Trim(dr4("quantity34").ToString)
            dr4("quantity35") = Trim(dr4("quantity35").ToString)
            dr4("quantity36") = Trim(dr4("quantity36").ToString)
            dr4("quantity37") = Trim(dr4("quantity37").ToString)
            dr4("quantity38") = Trim(dr4("quantity38").ToString)
            dr4("quantity39") = Trim(dr4("quantity39").ToString)
            dr4("quantity40") = Trim(dr4("quantity40").ToString)
            dr4("quantity41") = Trim(dr4("quantity41").ToString)
            dr4("quantity42") = Trim(dr4("quantity42").ToString)
            dr4("quantity43") = Trim(dr4("quantity43").ToString)
            dr4("quantity44") = Trim(dr4("quantity44").ToString)
            dr4("quantity45") = Trim(dr4("quantity45").ToString)
            dr4("quantity46") = Trim(dr4("quantity46").ToString)
            dr4("quantity47") = Trim(dr4("quantity47").ToString)
            dr4("quantity48") = Trim(dr4("quantity48").ToString)
            dr4("quantity49") = Trim(dr4("quantity49").ToString)
            dr4("quantity50") = Trim(dr4("quantity50").ToString)
            dr4("quantity51") = Trim(dr4("quantity51").ToString)
            dr4("quantity52") = Trim(dr4("quantity52").ToString)
            dr4("quantity53") = Trim(dr4("quantity53").ToString)
            dr4("quantity54") = Trim(dr4("quantity54").ToString)
            dr4("quantity55") = Trim(dr4("quantity55").ToString)
            dr4("quantity56") = Trim(dr4("quantity56").ToString)
            dr4("quantity57") = Trim(dr4("quantity57").ToString)
            dr4("quantity58") = Trim(dr4("quantity58").ToString)
            dr4("quantity59") = Trim(dr4("quantity59").ToString)
            dr4("quantity60") = Trim(dr4("quantity60").ToString)
            dr4("brand") = Trim(dr4("brand").ToString)

            If con1.State = ConnectionState.Closed Then
                con1.ConnectionString = connection
                cmd1.Connection = con1
                con1.Open()
            End If
            cmd1.CommandText = sorgu_queryJson("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT TOP 1 Product FROM tbParamGenel")
            Url = cmd1.ExecuteScalar.ToString()
            cmd1.CommandText = sorgu_queryJson("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT TOP 1 Product FROM tbParamGenel")
            ProductUpdate = cmd1.ExecuteScalar.ToString()
            con1.Close()
            ProductUpdate += "/product/save"
            If con1.State = ConnectionState.Closed Then
                con1.ConnectionString = connection
                cmd1.Connection = con1
                con1.Open()
            End If
            cmd1.CommandText = sorgu_queryJson("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT TOP 1 ApiKey FROM tbParamGenel")
            ApiKey = cmd1.ExecuteScalar.ToString()
            con1.Close()
            If con1.State = ConnectionState.Closed Then
                con1.ConnectionString = connection
                cmd1.Connection = con1
                con1.Open()
            End If
            cmd1.CommandText = sorgu_queryJson("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT TOP 1 ApiSecret FROM tbParamGenel")
            ApiSecret = cmd1.ExecuteScalar.ToString()
            con1.Close()


            Dim myReq As HttpWebRequest
            Dim myResp As HttpWebResponse
            Dim myReader As StreamReader
            myReq = HttpWebRequest.Create(ProductUpdate)
            myReq.Method = "POST"

            myReq.ContentType = "application/json"
            myReq.Accept = "application/json"
            myReq.Headers.Add("apikey", "" & ApiKey & "")
            myReq.Headers.Add("apisecret", "" & ApiSecret & "")

            'Dim Mydata As String = " {""products"": [{""code"": """ & dr4("code") & """,""name"": """ & dr4("name") & """,""invoiceName"": """ & dr4("name") & """,""status"": 1,""seq"": 0,""barcode"": """ & dr4("barcode1") & """,""mpn"": """",""shortDescription"": "" "",""brand"": """ & dr4("brand") & """,""category1"": """ & dr4("category1") & """,""category2"": """ & dr4("category3") & """,""category3"": """ & dr4("category4") & """,""longDescription"": """ & dr4("longDescription") & """,""seoTitle"": """ & dr4("seoTitle") & """,""seoKeywords"": """ & dr4("seoKeywords") & """,""seoDescription"": """ & dr4("seoDescription") & """,""taxRate"": """ & dr4("taxRate") & """,""shipmentPayment"": 1,""currency"": ""TL"",""buyPrice"": """ & dr4("buyPrice") & """,""listPrice"": """ & dr4("listPrice") & """,""salePrice"": """ & dr4("salePrice") & """,""quantity"": """ & dr4("quantity") & """,""desi"": 15,""domestic"": 1,""variant1Name"": ""Renk"",""variant2Name"": ""Beden"",""variant3Name"": """",""marketplacePrices"": [{""type"": ""n11"",""currency"": ""TL"",""price"": """ & dr4("N11salePrice") & """},{""type"": ""hb"",""currency"": ""TL"",""price"": """ & dr4("HbsalePrice") & """},{""type"": ""gg"",""currency"": ""TL"",""price"": """ & dr4("GgsalePrice") & """},{""type"": ""eptt"",""currency"": ""TL"",""price"": """ & dr4("EpttsalePrice") & """},{""type"": ""amz"",""currency"": ""TL"",""price"": """ & dr4("AmzsalePrice") & """},{""type"": ""ty"",""currency"": ""TL"",""price"": """ & dr4("TysalePrice") & """},{""type"": ""cs"",""currency"": ""TL"",""price"": """ & dr4("CssalePrice") & """}],""variants"": [{""value1"": """ & dr4("Renk1") & """,""value2"": """ & dr4("Beden1") & """,""barcode"": """ & dr4("barcode1") & """,""quantity"": """ & dr4("quantity1") & """,""priceStatus"": """ & priceStatus & """,""price"":  """ & dr4("Fiyat1") & """},{""value1"": """ & dr4("Renk2") & """,""value2"": """ & dr4("Beden2") & """,""barcode"": """ & dr4("barcode2") & """,""quantity"": """ & dr4("quantity2") & """,""priceStatus"": """ & priceStatus & """,""price"":  """ & dr4("Fiyat2") & """},{""value1"": """ & dr4("Renk3") & """,""value2"": """ & dr4("Beden3") & """,""barcode"": """ & dr4("barcode3") & """,""quantity"": """ & dr4("quantity3") & """,""priceStatus"": """ & priceStatus & """,""price"":  """ & dr4("Fiyat3") & """},{""value1"": """ & dr4("Renk4") & """,""value2"": """ & dr4("Beden4") & """,""barcode"": """ & dr4("barcode4") & """,""quantity"": """ & dr4("quantity4") & """,""priceStatus"": """ & priceStatus & """,""price"":  """ & dr4("Fiyat4") & """},{""value1"": """ & dr4("Renk5") & """,""value2"": """ & dr4("Beden5") & """,""barcode"": """ & dr4("barcode5") & """,""quantity"": """ & dr4("quantity5") & """,""priceStatus"": """ & priceStatus & """,""price"":  """ & dr4("Fiyat5") & """},{""value1"": """ & dr4("Renk6") & """,""value2"": """ & dr4("Beden6") & """,""barcode"": """ & dr4("barcode6") & """,""quantity"": """ & dr4("quantity6") & """,""priceStatus"": """ & priceStatus & """,""price"":  """ & dr4("Fiyat6") & """},{""value1"": """ & dr4("Renk7") & """,""value2"": """ & dr4("Beden7") & """,""barcode"": """ & dr4("barcode7") & """,""quantity"": """ & dr4("quantity7") & """,""priceStatus"": """ & priceStatus & """,""price"":  """ & dr4("Fiyat7") & """},{""value1"": """ & dr4("Renk8") & """,""value2"": """ & dr4("Beden8") & """,""barcode"": """ & dr4("barcode8") & """,""quantity"": """ & dr4("quantity8") & """,""priceStatus"": """ & priceStatus & """,""price"":  """ & dr4("Fiyat8") & """},{""value1"": """ & dr4("Renk9") & """,""value2"": """ & dr4("Beden9") & """,""barcode"": """ & dr4("barcode9") & """,""quantity"": """ & dr4("quantity9") & """,""priceStatus"": """ & priceStatus & """,""price"":  """ & dr4("Fiyat9") & """},{""value1"": """ & dr4("Renk10") & """,""value2"": """ & dr4("Beden10") & """,""barcode"": """ & dr4("barcode10") & """,""quantity"": """ & dr4("quantity10") & """,""priceStatus"": """ & priceStatus & """,""price"":  """ & dr4("Fiyat10") & """},{""value1"": """ & dr4("Renk11") & """,""value2"": """ & dr4("Beden11") & """,""barcode"": """ & dr4("barcode11") & """,""quantity"": """ & dr4("quantity11") & """,""priceStatus"": """ & priceStatus & """,""price"":  """ & dr4("Fiyat11") & """},{""value1"": """ & dr4("Renk12") & """,""value2"": """ & dr4("Beden12") & """,""barcode"": """ & dr4("barcode12") & """,""quantity"": """ & dr4("quantity12") & """,""priceStatus"": """ & priceStatus & """,""price"":  """ & dr4("Fiyat12") & """},{""value1"": """ & dr4("Renk13") & """,""value2"": """ & dr4("Beden13") & """,""barcode"": """ & dr4("barcode13") & """,""quantity"": """ & dr4("quantity13") & """,""priceStatus"": """ & priceStatus & """,""price"":  """ & dr4("Fiyat13") & """},{""value1"": """ & dr4("Renk14") & """,""value2"": """ & dr4("Beden14") & """,""barcode"": """ & dr4("barcode14") & """,""quantity"": """ & dr4("quantity14") & """,""priceStatus"": """ & priceStatus & """,""price"":  """ & dr4("Fiyat14") & """},{""value1"": """ & dr4("Renk15") & """,""value2"": """ & dr4("Beden15") & """,""barcode"": """ & dr4("barcode15") & """,""quantity"": """ & dr4("quantity15") & """,""priceStatus"": """ & priceStatus & """,""price"":  """ & dr4("Fiyat15") & """},{""value1"": """ & dr4("Renk16") & """,""value2"": """ & dr4("Beden16") & """,""barcode"": """ & dr4("barcode16") & """,""quantity"": """ & dr4("quantity16") & """,""priceStatus"": """ & priceStatus & """,""price"":  """ & dr4("Fiyat16") & """},{""value1"": """ & dr4("Renk17") & """,""value2"": """ & dr4("Beden17") & """,""barcode"": """ & dr4("barcode17") & """,""quantity"": """ & dr4("quantity17") & """,""priceStatus"": """ & priceStatus & """,""price"":  """ & dr4("Fiyat17") & """},{""value1"": """ & dr4("Renk18") & """,""value2"": """ & dr4("Beden18") & """,""barcode"": """ & dr4("barcode18") & """,""quantity"": """ & dr4("quantity18") & """,""priceStatus"": """ & priceStatus & """,""price"":  """ & dr4("Fiyat18") & """},{""value1"": """ & dr4("Renk19") & """,""value2"": """ & dr4("Beden19") & """,""barcode"": """ & dr4("barcode19") & """,""quantity"": """ & dr4("quantity19") & """,""priceStatus"": """ & priceStatus & """,""price"":  """ & dr4("Fiyat19") & """},{""value1"": """ & dr4("Renk20") & """,""value2"": """ & dr4("Beden20") & """,""barcode"": """ & dr4("barcode20") & """,""quantity"": """ & dr4("quantity20") & """,""priceStatus"": """ & priceStatus & """,""price"":  """ & dr4("Fiyat20") & """}],""images"": [{""imageUrl"": """ & dr4("imageUrl") & """},{""imageUrl"": """ & dr4("imageUrl1") & """},{""imageUrl"": """ & dr4("imageUrl2") & """},{""imageUrl"": """ & dr4("imageUrl3") & """},{""imageUrl"": """ & dr4("imageUrl4") & """},{""imageUrl"": """ & dr4("imageUrl5") & """},{""imageUrl"": """ & dr4("imageUrl5") & """},{""imageUrl"": """ & dr4("imageUrl6") & """},{""imageUrl"": """ & dr4("imageUrl7") & """},{""imageUrl"": """ & dr4("imageUrl7") & """},{""imageUrl"": """ & dr4("imageUrl8") & """},{""imageUrl"": """ & dr4("imageUrl9") & """},{""imageUrl"": """ & dr4("imageUrl10") & """}],""attributes"": [{""name"": ""Sezon"",""value"": """ & dr4("category2") & """},{""name"": ""Cinsiyet"",""value"": """ & dr4("category1") & """}]}]}"
            Dim Mydata As String = " {""products"": [{""code"": """ & dr4("code") & """,""name"": """ & dr4("name") & """,""invoiceName"": """ & dr4("name") & """,""status"": 1,""seq"": 0,""barcode"": """ & dr4("barcode1") & """,""mpn"": """",""shortDescription"": "" "",""brand"": """ & dr4("brand") & """,""category1"": """ & dr4("category1") & """,""category2"": """ & dr4("category3") & """,""category3"": """ & dr4("category4") & """,""longDescription"": """ & dr4("longDescription") & """,""seoTitle"": """ & dr4("seoTitle") & """,""seoKeywords"": """ & dr4("seoKeywords") & """,""seoDescription"": """ & dr4("seoDescription") & """,""taxRate"": """ & dr4("taxRate") & """,""shipmentPayment"": 1,""currency"": ""TL"",""buyPrice"": """ & dr4("buyPrice") & """,""listPrice"": """ & dr4("listPrice") & """,""salePrice"": """ & dr4("salePrice") & """,""quantity"": """ & dr4("quantity") & """,""desi"": 15,""domestic"": 1,""variant1Name"": ""Renk"",""variant2Name"": ""Beden"",""variant3Name"": """",""marketplacePrices"": [{""type"": ""n11"",""currency"": ""TL"",""price"": """ & dr4("N11salePrice") & """},{""type"": ""hb"",""currency"": ""TL"",""price"": """ & dr4("HbsalePrice") & """},{""type"": ""gg"",""currency"": ""TL"",""price"": """ & dr4("GgsalePrice") & """},{""type"": ""eptt"",""currency"": ""TL"",""price"": """ & dr4("EpttsalePrice") & """},{""type"": ""amz"",""currency"": ""TL"",""price"": """ & dr4("AmzsalePrice") & """},{""type"": ""ty"",""currency"": ""TL"",""price"": """ & dr4("TysalePrice") & """},{""type"": ""cs"",""currency"": ""TL"",""price"": """ & dr4("CssalePrice") & """}],""variants"": [{""value1"": """ & dr4("Renk1") & """,""value2"": """ & dr4("Beden1") & """,""barcode"": """ & dr4("barcode1") & """,""quantity"": """ & dr4("quantity1") & """,""priceStatus"": """ & priceStatus & """,""price"":  """ & dr4("Fiyat1") & """},{""value1"": """ & dr4("Renk2") & """,""value2"": """ & dr4("Beden2") & """,""barcode"": """ & dr4("barcode2") & """,""quantity"": """ & dr4("quantity2") & """,""priceStatus"": """ & priceStatus & """,""price"":  """ & dr4("Fiyat2") & """},{""value1"": """ & dr4("Renk3") & """,""value2"": """ & dr4("Beden3") & """,""barcode"": """ & dr4("barcode3") & """,""quantity"": """ & dr4("quantity3") & """,""priceStatus"": """ & priceStatus & """,""price"":  """ & dr4("Fiyat3") & """},{""value1"": """ & dr4("Renk4") & """,""value2"": """ & dr4("Beden4") & """,""barcode"": """ & dr4("barcode4") & """,""quantity"": """ & dr4("quantity4") & """,""priceStatus"": """ & priceStatus & """,""price"":  """ & dr4("Fiyat4") & """},{""value1"": """ & dr4("Renk5") & """,""value2"": """ & dr4("Beden5") & """,""barcode"": """ & dr4("barcode5") & """,""quantity"": """ & dr4("quantity5") & """,""priceStatus"": """ & priceStatus & """,""price"":  """ & dr4("Fiyat5") & """},{""value1"": """ & dr4("Renk6") & """,""value2"": """ & dr4("Beden6") & """,""barcode"": """ & dr4("barcode6") & """,""quantity"": """ & dr4("quantity6") & """,""priceStatus"": """ & priceStatus & """,""price"":  """ & dr4("Fiyat6") & """},{""value1"": """ & dr4("Renk7") & """,""value2"": """ & dr4("Beden7") & """,""barcode"": """ & dr4("barcode7") & """,""quantity"": """ & dr4("quantity7") & """,""priceStatus"": """ & priceStatus & """,""price"":  """ & dr4("Fiyat7") & """},{""value1"": """ & dr4("Renk8") & """,""value2"": """ & dr4("Beden8") & """,""barcode"": """ & dr4("barcode8") & """,""quantity"": """ & dr4("quantity8") & """,""priceStatus"": """ & priceStatus & """,""price"":  """ & dr4("Fiyat8") & """},{""value1"": """ & dr4("Renk9") & """,""value2"": """ & dr4("Beden9") & """,""barcode"": """ & dr4("barcode9") & """,""quantity"": """ & dr4("quantity9") & """,""priceStatus"": """ & priceStatus & """,""price"":  """ & dr4("Fiyat9") & """},{""value1"": """ & dr4("Renk10") & """,""value2"": """ & dr4("Beden10") & """,""barcode"": """ & dr4("barcode10") & """,""quantity"": """ & dr4("quantity10") & """,""priceStatus"": """ & priceStatus & """,""price"":  """ & dr4("Fiyat10") & """},{""value1"": """ & dr4("Renk11") & """,""value2"": """ & dr4("Beden11") & """,""barcode"": """ & dr4("barcode11") & """,""quantity"": """ & dr4("quantity11") & """,""priceStatus"": """ & priceStatus & """,""price"":  """ & dr4("Fiyat11") & """},{""value1"": """ & dr4("Renk12") & """,""value2"": """ & dr4("Beden12") & """,""barcode"": """ & dr4("barcode12") & """,""quantity"": """ & dr4("quantity12") & """,""priceStatus"": """ & priceStatus & """,""price"":  """ & dr4("Fiyat12") & """},{""value1"": """ & dr4("Renk13") & """,""value2"": """ & dr4("Beden13") & """,""barcode"": """ & dr4("barcode13") & """,""quantity"": """ & dr4("quantity13") & """,""priceStatus"": """ & priceStatus & """,""price"":  """ & dr4("Fiyat13") & """},{""value1"": """ & dr4("Renk14") & """,""value2"": """ & dr4("Beden14") & """,""barcode"": """ & dr4("barcode14") & """,""quantity"": """ & dr4("quantity14") & """,""priceStatus"": """ & priceStatus & """,""price"":  """ & dr4("Fiyat14") & """},{""value1"": """ & dr4("Renk15") & """,""value2"": """ & dr4("Beden15") & """,""barcode"": """ & dr4("barcode15") & """,""quantity"": """ & dr4("quantity15") & """,""priceStatus"": """ & priceStatus & """,""price"":  """ & dr4("Fiyat15") & """},{""value1"": """ & dr4("Renk16") & """,""value2"": """ & dr4("Beden16") & """,""barcode"": """ & dr4("barcode16") & """,""quantity"": """ & dr4("quantity16") & """,""priceStatus"": """ & priceStatus & """,""price"":  """ & dr4("Fiyat16") & """},{""value1"": """ & dr4("Renk17") & """,""value2"": """ & dr4("Beden17") & """,""barcode"": """ & dr4("barcode17") & """,""quantity"": """ & dr4("quantity17") & """,""priceStatus"": """ & priceStatus & """,""price"":  """ & dr4("Fiyat17") & """},{""value1"": """ & dr4("Renk18") & """,""value2"": """ & dr4("Beden18") & """,""barcode"": """ & dr4("barcode18") & """,""quantity"": """ & dr4("quantity18") & """,""priceStatus"": """ & priceStatus & """,""price"":  """ & dr4("Fiyat18") & """},{""value1"": """ & dr4("Renk19") & """,""value2"": """ & dr4("Beden19") & """,""barcode"": """ & dr4("barcode19") & """,""quantity"": """ & dr4("quantity19") & """,""priceStatus"": """ & priceStatus & """,""price"":  """ & dr4("Fiyat19") & """},{""value1"": """ & dr4("Renk20") & """,""value2"": """ & dr4("Beden20") & """,""barcode"": """ & dr4("barcode20") & """,""quantity"": """ & dr4("quantity20") & """,""price"":  """ & dr4("Fiyat20") & """},{""value1"": """ & dr4("Renk21") & """,""value2"": """ & dr4("Beden21") & """,""barcode"": """ & dr4("barcode21") & """,""quantity"": """ & dr4("quantity21") & """,""price"":  """ & dr4("Fiyat21") & """},{""value1"": """ & dr4("Renk22") & """,""value2"": """ & dr4("Beden22") & """,""barcode"": """ & dr4("barcode22") & """,""quantity"": """ & dr4("quantity22") & """,""price"":  """ & dr4("Fiyat22") & """},{""value1"": """ & dr4("Renk23") & """,""value2"": """ & dr4("Beden23") & """,""barcode"": """ & dr4("barcode23") & """,""quantity"": """ & dr4("quantity23") & """,""price"":  """ & dr4("Fiyat23") & """},{""value1"": """ & dr4("Renk24") & """,""value2"": """ & dr4("Beden24") & """,""barcode"": """ & dr4("barcode24") & """,""quantity"": """ & dr4("quantity24") & """,""price"":  """ & dr4("Fiyat24") & """},{""value1"": """ & dr4("Renk25") & """,""value2"": """ & dr4("Beden25") & """,""barcode"": """ & dr4("barcode25") & """,""quantity"": """ & dr4("quantity25") & """,""price"":  """ & dr4("Fiyat25") & """},{""value1"": """ & dr4("Renk26") & """,""value2"": """ & dr4("Beden26") & """,""barcode"": """ & dr4("barcode26") & """,""quantity"": """ & dr4("quantity26") & """,""price"":  """ & dr4("Fiyat26") & """},{""value1"": """ & dr4("Renk27") & """,""value2"": """ & dr4("Beden27") & """,""barcode"": """ & dr4("barcode27") & """,""quantity"": """ & dr4("quantity27") & """,""price"":  """ & dr4("Fiyat27") & """},{""value1"": """ & dr4("Renk28") & """,""value2"": """ & dr4("Beden28") & """,""barcode"": """ & dr4("barcode28") & """,""quantity"": """ & dr4("quantity28") & """,""price"":  """ & dr4("Fiyat27") & """},{""value1"": """ & dr4("Renk29") & """,""value2"": """ & dr4("Beden29") & """,""barcode"": """ & dr4("barcode29") & """,""quantity"": """ & dr4("quantity29") & """,""price"":  """ & dr4("Fiyat29") & """},{""value1"": """ & dr4("Renk30") & """,""value2"": """ & dr4("Beden30") & """,""barcode"": """ & dr4("barcode30") & """,""quantity"": """ & dr4("quantity30") & """,""price"":  """ & dr4("Fiyat30") & """},{""value1"": """ & dr4("Renk31") & """,""value2"": """ & dr4("Beden31") & """,""barcode"": """ & dr4("barcode31") & """,""quantity"": """ & dr4("quantity31") & """,""price"":  """ & dr4("Fiyat31") & """},{""value1"": """ & dr4("Renk32") & """,""value2"": """ & dr4("Beden32") & """,""barcode"": """ & dr4("barcode32") & """,""quantity"": """ & dr4("quantity32") & """,""price"":  """ & dr4("Fiyat32") & """},{""value1"": """ & dr4("Renk33") & """,""value2"": """ & dr4("Beden33") & """,""barcode"": """ & dr4("barcode33") & """,""quantity"": """ & dr4("quantity33") & """,""price"":  """ & dr4("Fiyat33") & """},{""value1"": """ & dr4("Renk34") & """,""value2"": """ & dr4("Beden34") & """,""barcode"": """ & dr4("barcode34") & """,""quantity"": """ & dr4("quantity34") & """,""price"":  """ & dr4("Fiyat34") & """},{""value1"": """ & dr4("Renk35") & """,""value2"": """ & dr4("Beden35") & """,""barcode"": """ & dr4("barcode35") & """,""quantity"": """ & dr4("quantity35") & """,""price"":  """ & dr4("Fiyat35") & """},{""value1"": """ & dr4("Renk36") & """,""value2"": """ & dr4("Beden36") & """,""barcode"": """ & dr4("barcode36") & """,""quantity"": """ & dr4("quantity36") & """,""price"":  """ & dr4("Fiyat36") & """},{""value1"": """ & dr4("Renk37") & """,""value2"": """ & dr4("Beden37") & """,""barcode"": """ & dr4("barcode37") & """,""quantity"": """ & dr4("quantity37") & """,""price"":  """ & dr4("Fiyat37") & """},{""value1"": """ & dr4("Renk38") & """,""value2"": """ & dr4("Beden38") & """,""barcode"": """ & dr4("barcode38") & """,""quantity"": """ & dr4("quantity38") & """,""price"":  """ & dr4("Fiyat38") & """},{""value1"": """ & dr4("Renk39") & """,""value2"": """ & dr4("Beden39") & """,""barcode"": """ & dr4("barcode39") & """,""quantity"": """ & dr4("quantity39") & """,""price"":  """ & dr4("Fiyat39") & """},{""value1"": """ & dr4("Renk40") & """,""value2"": """ & dr4("Beden40") & """,""barcode"": """ & dr4("barcode40") & """,""quantity"": """ & dr4("quantity40") & """,""price"":  """ & dr4("Fiyat40") & """},{""value1"": """ & dr4("Renk41") & """,""value2"": """ & dr4("Beden41") & """,""barcode"": """ & dr4("barcode41") & """,""quantity"": """ & dr4("quantity41") & """,""price"":  """ & dr4("Fiyat41") & """},{""value1"": """ & dr4("Renk42") & """,""value2"": """ & dr4("Beden42") & """,""barcode"": """ & dr4("barcode42") & """,""quantity"": """ & dr4("quantity42") & """,""price"":  """ & dr4("Fiyat42") & """},{""value1"": """ & dr4("Renk43") & """,""value2"": """ & dr4("Beden43") & """,""barcode"": """ & dr4("barcode43") & """,""quantity"": """ & dr4("quantity43") & """,""price"":  """ & dr4("Fiyat43") & """},{""value1"": """ & dr4("Renk44") & """,""value2"": """ & dr4("Beden44") & """,""barcode"": """ & dr4("barcode44") & """,""quantity"": """ & dr4("quantity44") & """,""price"":  """ & dr4("Fiyat44") & """},{""value1"": """ & dr4("Renk45") & """,""value2"": """ & dr4("Beden45") & """,""barcode"": """ & dr4("barcode45") & """,""quantity"": """ & dr4("quantity45") & """,""price"":  """ & dr4("Fiyat45") & """},{""value1"": """ & dr4("Renk46") & """,""value2"": """ & dr4("Beden46") & """,""barcode"": """ & dr4("barcode46") & """,""quantity"": """ & dr4("quantity46") & """,""price"":  """ & dr4("Fiyat46") & """},{""value1"": """ & dr4("Renk47") & """,""value2"": """ & dr4("Beden47") & """,""barcode"": """ & dr4("barcode47") & """,""quantity"": """ & dr4("quantity47") & """,""price"":  """ & dr4("Fiyat47") & """},{""value1"": """ & dr4("Renk48") & """,""value2"": """ & dr4("Beden48") & """,""barcode"": """ & dr4("barcode48") & """,""quantity"": """ & dr4("quantity48") & """,""price"":  """ & dr4("Fiyat48") & """},{""value1"": """ & dr4("Renk49") & """,""value2"": """ & dr4("Beden49") & """,""barcode"": """ & dr4("barcode49") & """,""quantity"": """ & dr4("quantity49") & """,""price"":  """ & dr4("Fiyat49") & """},{""value1"": """ & dr4("Renk50") & """,""value2"": """ & dr4("Beden50") & """,""barcode"": """ & dr4("barcode50") & """,""quantity"": """ & dr4("quantity50") & """,""price"":  """ & dr4("Fiyat50") & """},{""value1"": """ & dr4("Renk51") & """,""value2"": """ & dr4("Beden51") & """,""barcode"": """ & dr4("barcode51") & """,""quantity"": """ & dr4("quantity51") & """,""price"":  """ & dr4("Fiyat51") & """},{""value1"": """ & dr4("Renk52") & """,""value2"": """ & dr4("Beden52") & """,""barcode"": """ & dr4("barcode52") & """,""quantity"": """ & dr4("quantity52") & """,""price"":  """ & dr4("Fiyat52") & """},{""value1"": """ & dr4("Renk53") & """,""value2"": """ & dr4("Beden53") & """,""barcode"": """ & dr4("barcode53") & """,""quantity"": """ & dr4("quantity53") & """,""price"":  """ & dr4("Fiyat53") & """},{""value1"": """ & dr4("Renk54") & """,""value2"": """ & dr4("Beden54") & """,""barcode"": """ & dr4("barcode54") & """,""quantity"": """ & dr4("quantity54") & """,""price"":  """ & dr4("Fiyat54") & """},{""value1"": """ & dr4("Renk55") & """,""value2"": """ & dr4("Beden55") & """,""barcode"": """ & dr4("barcode55") & """,""quantity"": """ & dr4("quantity55") & """,""price"":  """ & dr4("Fiyat55") & """},{""value1"": """ & dr4("Renk56") & """,""value2"": """ & dr4("Beden56") & """,""barcode"": """ & dr4("barcode56") & """,""quantity"": """ & dr4("quantity56") & """,""price"":  """ & dr4("Fiyat56") & """},{""value1"": """ & dr4("Renk57") & """,""value2"": """ & dr4("Beden57") & """,""barcode"": """ & dr4("barcode57") & """,""quantity"": """ & dr4("quantity57") & """,""price"":  """ & dr4("Fiyat57") & """},{""value1"": """ & dr4("Renk58") & """,""value2"": """ & dr4("Beden58") & """,""barcode"": """ & dr4("barcode58") & """,""quantity"": """ & dr4("quantity58") & """,""price"":  """ & dr4("Fiyat58") & """},{""value1"": """ & dr4("Renk59") & """,""value2"": """ & dr4("Beden59") & """,""barcode"": """ & dr4("barcode59") & """,""quantity"": """ & dr4("quantity59") & """,""price"":  """ & dr4("Fiyat59") & """},{""value1"": """ & dr4("Renk60") & """,""value2"": """ & dr4("Beden60") & """,""barcode"": """ & dr4("barcode60") & """,""quantity"": """ & dr4("quantity60") & """,""price"":  """ & dr4("Fiyat60") & """}],""priceStatus"": """ & priceStatus & """,""price"":  """ & dr4("Fiyat20") & """}],""images"": [{""imageUrl"": """ & dr4("imageUrl") & """},{""imageUrl"": """ & dr4("imageUrl1") & """},{""imageUrl"": """ & dr4("imageUrl2") & """},{""imageUrl"": """ & dr4("imageUrl3") & """},{""imageUrl"": """ & dr4("imageUrl4") & """},{""imageUrl"": """ & dr4("imageUrl5") & """},{""imageUrl"": """ & dr4("imageUrl5") & """},{""imageUrl"": """ & dr4("imageUrl6") & """},{""imageUrl"": """ & dr4("imageUrl7") & """},{""imageUrl"": """ & dr4("imageUrl7") & """},{""imageUrl"": """ & dr4("imageUrl8") & """},{""imageUrl"": """ & dr4("imageUrl9") & """},{""imageUrl"": """ & dr4("imageUrl10") & """}],""attributes"": [{""name"": ""Sezon"",""value"": """ & dr4("category2") & """},{""name"": ""Cinsiyet"",""value"": """ & dr4("category1") & """}]}]}"

            Try

                Dim stream As Stream = myReq.GetRequestStream()
                stream.Write(System.Text.Encoding.UTF8.GetBytes(Mydata), 0, System.Text.Encoding.UTF8.GetBytes(Mydata).Length)
                stream.Close()
                myResp = myReq.GetResponse
                myReader = New System.IO.StreamReader(myResp.GetResponseStream)
                Print(myReader.ReadToEnd)

            Catch ex As Exception

                If ex.Message Like "%SUCCESS%" Then


                Else

                    If ex.Message.ToString = Chr(34) & "{" & Chr(34) & "code" & Chr(34) & ":" & Chr(34) & "AUTH001" & Chr(34) & "," & Chr(34) & "result" & Chr(34) & ":[]}" & Chr(34) & " dizesinden 'Integer' türüne yapýlan dönüþtürme geçerli deðil." Then
                        MessageBox.Show("Web servis aktif deðil")
                    End If
                    If ex.Message.ToString = Chr(34) & "{" & Chr(34) & "code" & Chr(34) & ":" & Chr(34) & "AUTH002" & Chr(34) & "," & Chr(34) & "result" & Chr(34) & ":[]}" & Chr(34) & " dizesinden 'Integer' türüne yapýlan dönüþtürme geçerli deðil." Then
                        MessageBox.Show("Geçersiz web servis kullanýcýsý ")
                    End If
                    If ex.Message.ToString = Chr(34) & "{" & Chr(34) & "code" & Chr(34) & ":" & Chr(34) & "AUTH003" & Chr(34) & "," & Chr(34) & "result" & Chr(34) & ":[]}" & Chr(34) & " dizesinden 'Integer' türüne yapýlan dönüþtürme geçerli deðil." Then
                        MessageBox.Show("Web servis kullanýcýsý aktif deðil")
                    End If
                    If ex.Message.ToString = Chr(34) & "{" & Chr(34) & "code" & Chr(34) & ":" & Chr(34) & "AUTH004" & Chr(34) & "," & Chr(34) & "result" & Chr(34) & ":[]}" & Chr(34) & " dizesinden 'Integer' türüne yapýlan dönüþtürme geçerli deðil." Then
                        MessageBox.Show("Dakikalýk eriþim limiti aþýldý")
                    End If
                    If ex.Message.ToString = Chr(34) & "{" & Chr(34) & "code" & Chr(34) & ":" & Chr(34) & "AUTH005" & Chr(34) & "," & Chr(34) & "result" & Chr(34) & ":[]}" & Chr(34) & " dizesinden 'Integer' türüne yapýlan dönüþtürme geçerli deðil." Then
                        MessageBox.Show("Geçersiz metod")
                    End If
                    If ex.Message.ToString = Chr(34) & "{" & Chr(34) & "code" & Chr(34) & ":" & Chr(34) & "AUTH006" & Chr(34) & "," & Chr(34) & "result" & Chr(34) & ":[]}" & Chr(34) & " dizesinden 'Integer' türüne yapýlan dönüþtürme geçerli deðil." Then
                        MessageBox.Show("Metota eriþim yetkisi bulunmamaktadýr")
                    End If

                End If
            End Try

            If con1.State = ConnectionState.Closed Then
                con1.ConnectionString = connection
                cmd1.Connection = con1
                con1.Open()
            End If
            cmd1.CommandText = sorgu_queryJson("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED Update tbStokEticaret Set Guncel = '1' where nStokID = " & dr4("nStokID") & "")
            cmd1.ExecuteNonQuery()
            con1.Close()
        Next


        '' JSON BÝTÝÞ 
        ''End If
    End Sub
    Private Function tbStok_kaydet_Eticaret(ByVal nStokID As String, ByVal code As String, ByVal name As String, ByVal Renk1 As String, ByVal Beden1 As String, ByVal barcode As String, ByVal brand As String, ByVal category1 As String, ByVal category2 As String, ByVal category3 As String, ByVal category4 As String, ByVal category5 As String, ByVal longDescription As String, ByVal buyPrice As String, ByVal listPrice As String, ByVal salePrice As String, ByVal seoTitle As String, ByVal seoKeywords As String, ByVal taxRate As String, ByVal quantity As String, ByVal seoDescription As String, ByVal variant1Name As String, ByVal variant2Name As String, ByVal imageUrl As String, ByVal imageUrl1 As String, ByVal imageUrl2 As String, ByVal imageUrl3 As String, ByVal imageUrl4 As String, ByVal imageUrl5 As String, ByVal imageUrl6 As String, ByVal imageUrl7 As String, ByVal imageUrl8 As String, ByVal imageUrl9 As String, ByVal imageUrl10 As String, ByVal TysalePrice As String, ByVal N11salePrice As String, ByVal GgsalePrice As String, ByVal HbsalePrice As String, ByVal EpttsalePrice As String, ByVal CssalePrice As String, ByVal AmzsalePrice As String) As Decimal

        Dim con As New OleDb.OleDbConnection
        Dim cmd As New OleDb.OleDbCommand
        cmd.Connection = con
        con.ConnectionString = connection
        cmd.CommandTimeout = False
        If con.State = ConnectionState.Closed = True Then
            con.Open()
        End If
        cmd.CommandText = sorgu_query("SET DATEFORMAT DMY SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED INSERT INTO tbStokEticaret (nStokID, code, name, Renk1, Beden1, barcode1,Fiyat1,quantity1, brand, category1, category2, category3, category4,category5,longDescription, buyPrice, listPrice, salePrice, seoTitle, seoKeywords, taxRate, quantity,seoDescription,variant1Name,variant2Name,imageUrl,imageUrl1,imageUrl2,imageUrl3,imageUrl4,imageUrl5,imageUrl6,imageUrl7,imageUrl8,imageUrl9,imageUrl10, TysalePrice, N11salePrice, GgsalePrice, HbsalePrice, EpttsalePrice, CssalePrice, AmzsalePrice,GUNCEL ) VALUES     ('" & nStokID & "', N'" & code & "', '" & name & "', '" & Renk1 & "', '" & Beden1 & "', '" & barcode & "','" & salePrice & "', '" & quantity & "','" & brand & "', '" & category1 & "', '" & category2 & "', '" & category3 & "', '" & category4 & "', '" & category5 & "','" & longDescription & "', '" & buyPrice & "','" & listPrice & "', '" & salePrice & "', '" & seoTitle & "','" & seoKeywords & "', '" & taxRate & "', '" & quantity & "', '" & seoDescription & "', '" & variant1Name & "', '" & variant2Name & "', '" & imageUrl & "', '" & imageUrl1 & "', '" & imageUrl2 & "', '" & imageUrl3 & "', '" & imageUrl4 & "', '" & imageUrl5 & "', '" & imageUrl6 & "', '" & imageUrl7 & "', '" & imageUrl8 & "', '" & imageUrl9 & "', '" & imageUrl10 & "', '" & TysalePrice & "', '" & N11salePrice & "', '" & GgsalePrice & "', '" & HbsalePrice & "', '" & EpttsalePrice & "', '" & CssalePrice & "', '" & AmzsalePrice & "','0')")
        cmd.ExecuteNonQuery()
        'cmd.CommandText = "SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT @@identity"
        'Dim kayitno = cmd.ExecuteScalar
        con.Close()
        Return kayitno
        cmd = Nothing
        con = Nothing
    End Function
    Private Function tbStok_Update_Eticaret(ByVal code As String, ByVal buyPrice As String, ByVal salePrice As String, ByVal listPrice As String) As Decimal
        Dim con As New OleDb.OleDbConnection
        Dim cmd As New OleDb.OleDbCommand
        cmd.Connection = con
        con.ConnectionString = connection
        cmd.CommandTimeout = False
        If con.State = ConnectionState.Closed = True Then
            con.Open()
        End If
        cmd.CommandText = sorgu_queryJson("SET DATEFORMAT DMY SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED Update tbStokEticaret Set buyPrice = '" & buyPrice & "',salePrice = '" & salePrice & "',listPrice = '" & listPrice & "', Guncel = '0' Where code = '" & code & "'")
        cmd.ExecuteNonQuery()
        'cmd.CommandText = "SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT @@identity"
        'Dim kayitno = cmd.ExecuteScalar
        con.Close()
        Return kayitno
        cmd = Nothing
        con = Nothing
    End Function
    Private Function tbStok_RenkUpdate_Eticaret(ByVal code As String, ByVal Renk As String, ByVal RenkVal As String) As Decimal
        Dim con As New OleDb.OleDbConnection
        Dim cmd As New OleDb.OleDbCommand
        cmd.Connection = con
        con.ConnectionString = connection
        cmd.CommandTimeout = False
        If con.State = ConnectionState.Closed = True Then
            con.Open()
        End If
        cmd.CommandText = sorgu_queryJson("SET DATEFORMAT DMY SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED Update tbStokEticaret Set " & Renk & " = '" & RenkVal & "', Guncel = '0' Where code = '" & code & "'")
        cmd.ExecuteNonQuery()
        'cmd.CommandText = "SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT @@identity"
        'Dim kayitno = cmd.ExecuteScalar
        con.Close()
        Return kayitno
        cmd = Nothing
        con = Nothing
    End Function
    Private Function tbStok_BedenUpdate_Eticaret(ByVal code As String, ByVal Beden As String, ByVal BedenVal As String, ByVal Fiyat As String, ByVal saleprice As String) As Decimal
        Dim con As New OleDb.OleDbConnection
        Dim cmd As New OleDb.OleDbCommand
        cmd.Connection = con
        con.ConnectionString = connection
        cmd.CommandTimeout = False
        If con.State = ConnectionState.Closed = True Then
            con.Open()
        End If
        cmd.CommandText = sorgu_queryJson("SET DATEFORMAT DMY SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED Update tbStokEticaret Set " & Beden & " = '" & BedenVal & "' , " & Fiyat & " = '" & saleprice & "',Guncel = '0'  Where code = '" & code & "'")
        cmd.ExecuteNonQuery()
        'cmd.CommandText = "SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT @@identity"
        'Dim kayitno = cmd.ExecuteScalar
        con.Close()
        Return kayitno
        cmd = Nothing
        con = Nothing
    End Function
    Private Function tbStok_Mevcut_Eticaret(ByVal code As String, ByVal Beden As String, ByVal BedenVal As String, ByVal Fiyat As String) As Decimal
        Dim con As New OleDb.OleDbConnection
        Dim cmd As New OleDb.OleDbCommand
        cmd.Connection = con
        con.ConnectionString = connection
        cmd.CommandTimeout = False
        If con.State = ConnectionState.Closed = True Then
            con.Open()
        End If
        cmd.CommandText = sorgu_queryJson("SET DATEFORMAT DMY SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED Update tbStokEticaret Set " & Beden & " = '" & BedenVal & "', Guncel = '0'   Where code = '" & code & "'")
        cmd.ExecuteNonQuery()
        'cmd.CommandText = "SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT @@identity"
        'Dim kayitno = cmd.ExecuteScalar
        con.Close()
        Return kayitno
        cmd = Nothing
        con = Nothing
    End Function
    Private Function tbStok_BarkodUpdate_Eticaret(ByVal code As String, ByVal Barkod As String, ByVal BarkodVal As String) As Decimal
        Dim con As New OleDb.OleDbConnection
        Dim cmd As New OleDb.OleDbCommand
        cmd.Connection = con
        con.ConnectionString = connection
        cmd.CommandTimeout = False
        If con.State = ConnectionState.Closed = True Then
            con.Open()
        End If
        cmd.CommandText = sorgu_queryJson("SET DATEFORMAT DMY SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED Update tbStokEticaret Set " & Barkod & " = '" & BarkodVal & "', Guncel = '0' Where code = '" & code & "'")
        cmd.ExecuteNonQuery()
        'cmd.CommandText = "SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT @@identity"
        'Dim kayitno = cmd.ExecuteScalar
        con.Close()
        Return kayitno
        cmd = Nothing
        con = Nothing
    End Function
    Private Function tbStok_quantityUpdate_Eticaret(ByVal code As String, ByVal quantity As String, ByVal quantityVal As String) As Decimal
        Dim con As New OleDb.OleDbConnection
        Dim cmd As New OleDb.OleDbCommand
        cmd.Connection = con
        con.ConnectionString = connection
        cmd.CommandTimeout = False
        If con.State = ConnectionState.Closed = True Then
            con.Open()
        End If
        cmd.CommandText = sorgu_queryJson("SET DATEFORMAT DMY SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED Update tbStokEticaret Set " & quantity & " = '" & quantityVal & "', Guncel = '0' Where code = '" & code & "'")
        cmd.ExecuteNonQuery()
        'cmd.CommandText = "SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT @@identity"
        'Dim kayitno = cmd.ExecuteScalar
        con.Close()
        Return kayitno
        cmd = Nothing
        con = Nothing
    End Function
    Private Function tbStok_quantitysUpdate_Eticaret(ByVal code As String, ByVal quantitys As String) As Decimal
        Dim con As New OleDb.OleDbConnection
        Dim cmd As New OleDb.OleDbCommand
        cmd.Connection = con
        con.ConnectionString = connection
        cmd.CommandTimeout = False
        If con.State = ConnectionState.Closed = True Then
            con.Open()
        End If
        cmd.CommandText = sorgu_queryJson("SET DATEFORMAT DMY SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED Update tbStokEticaret Set  quantity  = '" & quantitys & "', Guncel = '0' Where code = '" & code & "'")
        cmd.ExecuteNonQuery()
        'cmd.CommandText = "SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT @@identity"
        'Dim kayitno = cmd.ExecuteScalar
        con.Close()
        Return kayitno
        cmd = Nothing
        con = Nothing
    End Function
    Private Sub sAktifFiyatTipi_Toplu()
        Dim frm As New frm_tbKod
        frm.firmano = firmano
        frm.donemno = donemno
        frm.connection = connection
        frm.sText = "SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT     sFiyatTipi as sKod,sAciklama as sAciklama FROM         tbFiyatTipi where (aktif = 1) and (aktifDepo like '%" & Trim(sDepo) & "%')"
        frm.lbl_sKod.Text = "AktifFiyatTipi:"
        If frm.ShowDialog() = Windows.Forms.DialogResult.OK Then
            If XtraMessageBox.Show(frm.LookUpEdit1.EditValue & Sorgu_sDil(" FiyatTipini Atamak Ýstediðinize Emin misiniz...?", sDil), Sorgu_sDil("Dikkat", sDil), MessageBoxButtons.YesNo, MessageBoxIcon.Question) = MsgBoxResult.Yes Then
                sAktifFiyatTipi = frm.LookUpEdit1.EditValue
                lbl_sAktifFiyatTipi.Text = sAktifFiyatTipi
            End If
        End If
    End Sub
    Private Sub BarButtonItem40_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem40.ItemClick
        sAktifFiyatTipi_Toplu()
    End Sub
    Private Sub BarButtonItem41_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem41.ItemClick
        Dim frm As New frm_Market_KasaTeslimat
        frm.firmano = firmano
        frm.donemno = donemno
        frm.connection = connection
        frm.kullanici = kullanici
        frm.Show()
    End Sub
    Private Sub GörünümüYazdýrToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GörünümüYazdýrToolStripMenuItem.Click
        gorunumu_yazdir()
    End Sub

    Private Function frm_eticaret_yardim() As Object
        Throw New NotImplementedException
    End Function

    Private Sub BarButtonItem42_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem42.ItemClick
        If GridView1.RowCount > 0 Then
            GridView1.Focus()
            'Sil()
            jsonRequest()

        Else
            If XtraMessageBox.Show(Sorgu_sDil("Kayýt Bulunumadý..." & vbCrLf & "Yeni Kayýt Eklemek Ýster misiniz...?", sDil), Sorgu_sDil("Dikkat", sDil), MessageBoxButtons.YesNo, MessageBoxIcon.Question) = MsgBoxResult.Yes Then
                satir_ekle_stok("")
            End If
        End If

    End Sub

    Private Sub BarButtonItem43_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem43.ItemClick
        'Sil()
        jsonRequest_Stok_guncel()
    End Sub

    Private Sub BarButtonItem44_ItemClick_1(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem44.ItemClick
        'Sil()
        jsonRequest_Fiyat_guncel()
    End Sub

    Private Sub BarButtonItem46_ItemClick_1(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem46.ItemClick
        Sil()
    End Sub

    Private Sub BarButtonItem47_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem47.ItemClick
        Eticaret_Senkron()
    End Sub

    Private Sub BarButtonItem48_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem48.ItemClick
        Siparis_olustur()
    End Sub
End Class