Imports Microsoft.Win32
Imports FastReport
Imports business_smart.brkdutil
Imports System.IO
Imports System.Collections.Generic
Imports System.Net
Imports DevExpress.XtraEditors
Imports System.Windows.Forms
Public Class frm_market
    Public firmano
    Public donemno
    Public connection
    Public kullanici
    Public sKasaIletisim As String = ""
    Public sKasiyerRumuzu
    Dim ds_stok As DataSet
    Dim ds_Entegrasyon As DataSet
    Dim ds_tbFiyatTipi As DataSet
    Dim dr As DataRow
    Public frf_islem As String = "mektup"
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
    'Public sAktifFiyatTipi As String = sFiyat1
    ' Resim gösterme için deðiþkenler
    Private _imgCache As New Dictionary(Of String, Image)()
    
    Private Sub frm_market_Activated(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Activated
        txt_ara.Focus()
        txt_ara.SelectAll()
        lbl_sAktifFiyatTipi.Text = sAktifFiyatTipi
    End Sub
    Private Sub frm_market_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        e.Cancel = True
        Me.Hide()
    End Sub
    Private Sub frm_market_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'sKasaIletisim = "Ofline+Online"
        colFIYAT1.Caption = sFiyat1Aciklama
        colFIYAT2.Caption = sFiyat2Aciklama
        colFIYAT3.Caption = sFiyat3Aciklama
        colFIYAT4.Caption = sFiyat4Aciklama
        colFIYAT5.caption = sFiyat5Aciklama
        colFIYAT6.Caption = sFiyat6Aciklama
        colFIYAT7.Caption = sFiyat7Aciklama
        colFIYAT8.Caption = sFiyat8Aciklama
        colFIYAT9.Caption = sFiyat9Aciklama
        colFIYAT10.Caption = sFiyat10Aciklama
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
            If XtraMessageBox.Show(Sorgu_sDil("Market Islemleri Ekranindan Cikmak Istediginize Emin misiniz...?", sDil), Sorgu_sDil("Dikkat", sDil), MessageBoxButtons.YesNo, MessageBoxIcon.Question) = MsgBoxResult.Yes Then
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
            'kriter += " AND (tbSSinif1.sAciklama LIKE '" & kod1 & "%')"
            kriter += "AND tbStok.nStokID IN (SELECT tbStokSinifi.nStokID FROM tbStokSinifi INNER JOIN tbSSinif1 ON tbStokSinifi.sSinifKodu1 = tbSSinif1.sSinifKodu WHERE tbSSinif1.sAciklama LIKE '" & kod1 & "%')"

        End If
        If kod2 <> "" Then
            'kriter += " AND (tbSSinif2.sAciklama LIKE '" & kod2 & "%')"
            kriter += "AND tbStok.nStokID IN (SELECT tbStokSinifi.nStokID FROM tbStokSinifi INNER JOIN tbSSinif2 ON tbStokSinifi.sSinifKodu2 = tbSSinif2.sSinifKodu WHERE tbSSinif2.sAciklama LIKE '" & kod2 & "%')"

        End If
        If kod3 <> "" Then
            'kriter += " AND (tbSSinif3.sAciklama LIKE '" & kod3 & "%')"
            kriter += "AND tbStok.nStokID IN (SELECT tbStokSinifi.nStokID FROM tbStokSinifi INNER JOIN tbSSinif3 ON tbStokSinifi.sSinifKodu3 = tbSSinif3.sSinifKodu WHERE tbSSinif3.sAciklama LIKE '" & kod3 & "%')"

        End If
        If kod4 <> "" Then
            'kriter += " AND (tbSSinif4.sAciklama LIKE '" & kod4 & "%')"
            kriter += "AND tbStok.nStokID IN (SELECT tbStokSinifi.nStokID FROM tbStokSinifi INNER JOIN tbSSinif5 ON tbStokSinifi.sSinifKodu5 = tbSSinif5.sSinifKodu WHERE tbSSinif5.sAciklama LIKE '" & kod4 & "%')"

        End If
        If kod5 <> "" Then
            'kriter += " AND (tbSSinif5.sAciklama LIKE '" & kod5 & "%')"
            kriter += "AND tbStok.nStokID IN (SELECT tbStokSinifi.nStokID FROM tbStokSinifi INNER JOIN tbSSinif5 ON tbStokSinifi.sSinifKodu5 = tbSSinif5.sSinifKodu WHERE tbSSinif5.sAciklama LIKE '" & kod5 & "%')"

        End If
        If kod6 <> "" Then
            'kriter += " AND (tbSSinif6.sAciklama LIKE '" & kod6 & "%')"
            kriter += "AND tbStok.nStokID IN (SELECT tbStokSinifi.nStokID FROM tbStokSinifi INNER JOIN tbSSinif6 ON tbStokSinifi.sSinifKodu6 = tbSSinif6.sSinifKodu WHERE tbSSinif6.sAciklama LIKE '" & kod6 & "%')"

        End If
        If kod7 <> "" Then
            'kriter += " AND (tbSSinif7.sAciklama LIKE '" & kod7 & "%')"
            kriter += "AND tbStok.nStokID IN (SELECT tbStokSinifi.nStokID FROM tbStokSinifi INNER JOIN tbSSinif7 ON tbStokSinifi.sSinifKodu7 = tbSSinif7.sSinifKodu WHERE tbSSinif7.sAciklama LIKE '" & kod7 & "%')"

        End If
        If kod8 <> "" Then
            'kriter += " AND (tbSSinif8.sAciklama LIKE '" & kod8 & "%')"
            kriter += "AND tbStok.nStokID IN (SELECT tbStokSinifi.nStokID FROM tbStokSinifi INNER JOIN tbSSinif8 ON tbStokSinifi.sSinifKodu8 = tbSSinif8.sSinifKodu WHERE tbSSinif8.sAciklama LIKE '" & kod8 & "%')"

        End If
        If kod9 <> "" Then
            'kriter += " AND (tbSSinif9.sAciklama LIKE '" & kod9 & "%')"
            kriter += "AND tbStok.nStokID IN (SELECT tbStokSinifi.nStokID FROM tbStokSinifi INNER JOIN tbSSinif9 ON tbStokSinifi.sSinifKodu9 = tbSSinif9.sSinifKodu WHERE tbSSinif9.sAciklama LIKE '" & kod9 & "%')"

        End If
        If kod10 <> "" Then
            'kriter += " AND (tbSSinif10.sAciklama LIKE '" & kod10 & "%')"
            kriter += "AND tbStok.nStokID IN (SELECT tbStokSinifi.nStokID FROM tbStokSinifi INNER JOIN tbSSinif10 ON tbStokSinifi.sSinifKodu10 = tbSSinif10.sSinifKodu WHERE tbSSinif10.sAciklama LIKE '" & kod10 & "%')"

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
        
        ' Resim sorgusu: checkbox iþaretliyse SQL'e pResim ekle
        Dim sResim As String = ""
        If sec_bResimGoster.Checked = True Then
            sResim = " (SELECT TOP 1 pResim FROM tbStokResim WHERE " &
                     "(nStokID = tbStok.nStokID) OR " &
                     "(sModel = tbStok.sModel) " &
                     "ORDER BY CASE WHEN nStokID = tbStok.nStokID THEN 1 ELSE 2 END, nSira) AS pResim, "
        End If
        Dim conn As New OleDb.OleDbConnection
        Dim cmd As New OleDb.OleDbCommand
        Dim adapter As New OleDb.OleDbDataAdapter
        conn.ConnectionString = connection
        cmd.CommandTimeout = False
        adapter.SelectCommand = cmd
        cmd.Connection = conn
        conn.Open()
        cmd.CommandText = sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT " & count & " " & sResim & " tbStok.*, tbStokBarkodu.sBarkod, tbSSinif1.sAciklama AS Sinif1, tbSSinif2.sAciklama AS Sinif2, tbSSinif3.sAciklama AS Sinif3, tbSSinif4.sAciklama AS Sinif4, tbSSinif5.sAciklama AS Sinif5, tbSSinif6.sAciklama AS Sinif6, tbSSinif7.sAciklama AS Sinif7, tbSSinif8.sAciklama AS Sinif8, tbSSinif9.sAciklama AS Sinif9, tbSSinif10.sAciklama AS Sinif10, tbSSinif11.sAciklama AS Sinif11, tbSSinif12.sAciklama AS Sinif12, tbSSinif13.sAciklama AS Sinif13, tbSSinif14.sAciklama AS Sinif14, tbSSinif15.sAciklama AS Sinif15, ISNULL(tbStokAciklama.sAciklama1 + ' ' + tbStokAciklama.sAciklama2 + ' ' + tbStokAciklama.sAciklama3 + ' ' + tbStokAciklama.sAciklama4 + ' ' + tbStokAciklama.sAciklama5 + ' ' + tbStokAciklama.sAciklama6 + ' ' + tbStokAciklama.sAciklama7 + ' ' + tbStokAciklama.sAciklama8 + ' ' + tbStokAciklama.sAciklama9 + ' ' + tbStokAciklama.sAciklama10, '') AS ISTIHBARAT,(SELECT isnull(SUM(tbStokFisiDetayi.lGirisMiktar1 - tbStokFisiDetayi.lCikisMiktar1) , 0) FROM tbStokFisiDetayi WHERE tbStok.nStokID = tbStokFisiDetayi.nStokID) AS Mevcut,ISNULL((SELECT isnull(lfiyat , 0) FROM tbstokfiyati WHERE nStokId = tbStok.NstokId AND sFiyatTipi = '" & sFiyat1 & "'),0) AS FIYAT1, ISNULL((SELECT isnull(lfiyat , 0) FROM tbstokfiyati WHERE nStokId = tbStok.NstokId AND sFiyatTipi = '" & sFiyat2 & "'),0) AS FIYAT2,ISNULL((SELECT isnull(lfiyat , 0) FROM tbstokfiyati WHERE nStokId = tbStok.NstokId AND sFiyatTipi = '" & sFiyat3 & "'),0) AS FIYAT3,ISNULL((SELECT isnull(lfiyat , 0) FROM tbstokfiyati WHERE nStokId = tbStok.NstokId AND sFiyatTipi = '" & sFiyat4 & "'),0) AS FIYAT4,ISNULL((SELECT isnull(lfiyat , 0) FROM tbstokfiyati WHERE nStokId = tbStok.NstokId AND sFiyatTipi = '" & sFiyat5 & "'),0) AS FIYAT5,ISNULL((SELECT isnull(lfiyat , 0) FROM tbstokfiyati WHERE nStokId = tbStok.NstokId AND sFiyatTipi = '" & sFiyat6 & "'),0) AS FIYAT6,ISNULL((SELECT isnull(lfiyat , 0) FROM tbstokfiyati WHERE nStokId = tbStok.NstokId AND sFiyatTipi = '" & sFiyat7 & "'),0) AS FIYAT7,ISNULL((SELECT isnull(lfiyat , 0) FROM tbstokfiyati WHERE nStokId = tbStok.NstokId AND sFiyatTipi = '" & sFiyat8 & "'),0) AS FIYAT8,ISNULL((SELECT isnull(lfiyat , 0) FROM tbstokfiyati WHERE nStokId = tbStok.NstokId AND sFiyatTipi = '" & sFiyat9 & "'),0) AS FIYAT9,ISNULL((SELECT isnull(lfiyat , 0) FROM tbstokfiyati WHERE nStokId = tbStok.NstokId AND sFiyatTipi = '" & sFiyat10 & "'),0) AS FIYAT10,ISNULL((SELECT isnull(lfiyat , 0) FROM tbstokfiyati WHERE nStokId = tbStok.NstokId AND sFiyatTipi = '" & sFiyatA & "'),0) AS FIYATA,ISNULL((SELECT isnull(lfiyat , 0) FROM tbstokfiyati WHERE nStokId = tbStok.NstokId AND sFiyatTipi = '" & sFiyatM & "'),0) AS FIYATM,(SELECT     nKdvOrani FROM         tbKdv Where sKdvTipi = tbStok.sKdvTipi) as nKdvOrani,CAST(1 as Money) as lMiktar  FROM tbStok INNER JOIN tbStokBarkodu ON tbStok.nStokID = tbStokBarkodu.nStokID and tbStokBarkodu.nKisim = 0 INNER JOIN tbStokSinifi ON tbStok.nStokID = tbStokSinifi.nStokID INNER JOIN tbSSinif1 ON tbStokSinifi.sSinifKodu1 = tbSSinif1.sSinifKodu INNER JOIN tbSSinif2 ON tbStokSinifi.sSinifKodu2 = tbSSinif2.sSinifKodu INNER JOIN tbSSinif3 ON tbStokSinifi.sSinifKodu3 = tbSSinif3.sSinifKodu INNER JOIN tbSSinif4 ON tbStokSinifi.sSinifKodu4 = tbSSinif4.sSinifKodu INNER JOIN tbSSinif5 ON tbStokSinifi.sSinifKodu5 = tbSSinif5.sSinifKodu INNER JOIN tbSSinif6 ON tbStokSinifi.sSinifKodu6 = tbSSinif6.sSinifKodu INNER JOIN tbSSinif7 ON tbStokSinifi.sSinifKodu7 = tbSSinif7.sSinifKodu INNER JOIN tbSSinif8 ON tbStokSinifi.sSinifKodu8 = tbSSinif8.sSinifKodu INNER JOIN tbSSinif9 ON tbStokSinifi.sSinifKodu9 = tbSSinif9.sSinifKodu INNER JOIN tbSSinif10 ON tbStokSinifi.sSinifKodu10 = tbSSinif10.sSinifKodu INNER JOIN tbSSinif11 ON tbStokSinifi.sSinifKodu11 = tbSSinif11.sSinifKodu INNER JOIN tbSSinif12 ON tbStokSinifi.sSinifKodu12 = tbSSinif12.sSinifKodu INNER JOIN tbSSinif13 ON tbStokSinifi.sSinifKodu13 = tbSSinif13.sSinifKodu INNER JOIN tbSSinif14 ON tbStokSinifi.sSinifKodu14 = tbSSinif14.sSinifKodu INNER JOIN tbSSinif15 ON tbStokSinifi.sSinifKodu15 = tbSSinif15.sSinifKodu LEFT OUTER JOIN tbStokAciklama ON tbStok.nStokID = tbStokAciklama.nStokID " & kriter & " " & kriter2 & "")
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
        
        ' Resim sorgusu: checkbox iþaretliyse SQL'e pResim ekle
        Dim sResim As String = ""
        If sec_bResimGoster.Checked = True Then
            sResim = " (SELECT TOP 1 pResim FROM tbStokResim WHERE " &
                     "(nStokID = tbStok.nStokID) OR " &
                     "(sModel = tbStok.sModel) " &
                     "ORDER BY CASE WHEN nStokID = tbStok.nStokID THEN 1 ELSE 2 END, nSira) AS pResim, "
        End If
        Dim conn As New OleDb.OleDbConnection
        Dim cmd As New OleDb.OleDbCommand
        Dim adapter As New OleDb.OleDbDataAdapter
        conn.ConnectionString = connection
        cmd.CommandTimeout = False
        adapter.SelectCommand = cmd
        cmd.Connection = conn
        conn.Open()
        cmd.CommandText = sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT " & count & " " & sResim & " tbStok.*, tbStokBarkodu.sBarkod, tbSSinif1.sAciklama AS Sinif1, tbSSinif2.sAciklama AS Sinif2, tbSSinif3.sAciklama AS Sinif3, tbSSinif4.sAciklama AS Sinif4, tbSSinif5.sAciklama AS Sinif5, tbSSinif6.sAciklama AS Sinif6, tbSSinif7.sAciklama AS Sinif7, tbSSinif8.sAciklama AS Sinif8, tbSSinif9.sAciklama AS Sinif9, tbSSinif10.sAciklama AS Sinif10, tbSSinif11.sAciklama AS Sinif11, tbSSinif12.sAciklama AS Sinif12, tbSSinif13.sAciklama AS Sinif13, tbSSinif14.sAciklama AS Sinif14, tbSSinif15.sAciklama AS Sinif15, ISNULL(tbStokAciklama.sAciklama1 + ' ' + tbStokAciklama.sAciklama2 + ' ' + tbStokAciklama.sAciklama3 + ' ' + tbStokAciklama.sAciklama4 + ' ' + tbStokAciklama.sAciklama5 + ' ' + tbStokAciklama.sAciklama6 + ' ' + tbStokAciklama.sAciklama7 + ' ' + tbStokAciklama.sAciklama8 + ' ' + tbStokAciklama.sAciklama9 + ' ' + tbStokAciklama.sAciklama10, '') AS ISTIHBARAT,(SELECT isnull(SUM(tbStokFisiDetayi.lGirisMiktar1 - tbStokFisiDetayi.lCikisMiktar1) , 0) FROM tbStokFisiDetayi WHERE tbStok.nStokID = tbStokFisiDetayi.nStokID) AS Mevcut,ISNULL((SELECT isnull(lfiyat , 0) FROM tbstokfiyati WHERE nStokId = tbStok.NstokId AND sFiyatTipi = '" & sFiyat1 & "'),0) AS FIYAT1, ISNULL((SELECT isnull(lfiyat , 0) FROM tbstokfiyati WHERE nStokId = tbStok.NstokId AND sFiyatTipi = '" & sFiyat2 & "'),0) AS FIYAT2,ISNULL((SELECT isnull(lfiyat , 0) FROM tbstokfiyati WHERE nStokId = tbStok.NstokId AND sFiyatTipi = '" & sFiyat3 & "'),0) AS FIYAT3,ISNULL((SELECT isnull(lfiyat , 0) FROM tbstokfiyati WHERE nStokId = tbStok.NstokId AND sFiyatTipi = '" & sFiyatM & "'),0) AS FIYATM,ISNULL((SELECT isnull(lfiyat , 0) FROM tbstokfiyati WHERE nStokId = tbStok.NstokId AND sFiyatTipi = '" & sAktifFiyatTipi & "'),0) AS lFiyat,ISNULL((SELECT isnull(lfiyat , 0) FROM tbstokfiyati WHERE nStokId = tbStok.NstokId AND sFiyatTipi = '" & sFiyatA & "'),0) AS FIYATA,ISNULL((SELECT isnull(lfiyat , 0) FROM tbstokfiyati WHERE nStokId = tbStok.NstokId AND sFiyatTipi = '" & sFiyat4 & "'),0) AS FIYAT4,ISNULL((SELECT isnull(lfiyat , 0) FROM tbstokfiyati WHERE nStokId = tbStok.NstokId AND sFiyatTipi = '" & sFiyat5 & "'),0) AS FIYAT5,ISNULL((SELECT isnull(lfiyat , 0) FROM tbstokfiyati WHERE nStokId = tbStok.NstokId AND sFiyatTipi = '" & sFiyat6 & "'),0) AS FIYAT6,ISNULL((SELECT isnull(lfiyat , 0) FROM tbstokfiyati WHERE nStokId = tbStok.NstokId AND sFiyatTipi = '" & sFiyat7 & "'),0) AS FIYAT7,ISNULL((SELECT isnull(lfiyat , 0) FROM tbstokfiyati WHERE nStokId = tbStok.NstokId AND sFiyatTipi = '" & sFiyat8 & "'),0) AS FIYAT8,ISNULL((SELECT isnull(lfiyat , 0) FROM tbstokfiyati WHERE nStokId = tbStok.NstokId AND sFiyatTipi = '" & sFiyat9 & "'),0) AS FIYAT9,ISNULL((SELECT isnull(lfiyat , 0) FROM tbstokfiyati WHERE nStokId = tbStok.NstokId AND sFiyatTipi = '" & sFiyat10 & "'),0) AS FIYAT10,(SELECT     nKdvOrani FROM         tbKdv Where sKdvTipi = tbStok.sKdvTipi) as nKdvOrani,(Select ISNULL(sRenkAdi,'') from tbRenk Where sRenk = tbStok.sRenk) as sRenkAdi,ISNULL((SELECT ISNULL(lOran , 1) FROM tbStokBirimCevrimi WHERE nStokID = tbStok.nStokID AND sBirimCinsi = tbStok.sBirimCinsi2), 1) AS lBirimCarpan,CAST(1 as Money) as lMiktar,CAST(0 AS MONEY) nOran  FROM tbStok INNER JOIN tbStokBarkodu ON tbStok.nStokID = tbStokBarkodu.nStokID and tbStokBarkodu.nKisim = 0 INNER JOIN tbStokSinifi ON tbStok.nStokID = tbStokSinifi.nStokID INNER JOIN tbSSinif1 ON tbStokSinifi.sSinifKodu1 = tbSSinif1.sSinifKodu INNER JOIN tbSSinif2 ON tbStokSinifi.sSinifKodu2 = tbSSinif2.sSinifKodu INNER JOIN tbSSinif3 ON tbStokSinifi.sSinifKodu3 = tbSSinif3.sSinifKodu INNER JOIN tbSSinif4 ON tbStokSinifi.sSinifKodu4 = tbSSinif4.sSinifKodu INNER JOIN tbSSinif5 ON tbStokSinifi.sSinifKodu5 = tbSSinif5.sSinifKodu INNER JOIN tbSSinif6 ON tbStokSinifi.sSinifKodu6 = tbSSinif6.sSinifKodu INNER JOIN tbSSinif7 ON tbStokSinifi.sSinifKodu7 = tbSSinif7.sSinifKodu INNER JOIN tbSSinif8 ON tbStokSinifi.sSinifKodu8 = tbSSinif8.sSinifKodu INNER JOIN tbSSinif9 ON tbStokSinifi.sSinifKodu9 = tbSSinif9.sSinifKodu INNER JOIN tbSSinif10 ON tbStokSinifi.sSinifKodu10 = tbSSinif10.sSinifKodu INNER JOIN tbSSinif11 ON tbStokSinifi.sSinifKodu11 = tbSSinif11.sSinifKodu INNER JOIN tbSSinif12 ON tbStokSinifi.sSinifKodu12 = tbSSinif12.sSinifKodu INNER JOIN tbSSinif13 ON tbStokSinifi.sSinifKodu13 = tbSSinif13.sSinifKodu INNER JOIN tbSSinif14 ON tbStokSinifi.sSinifKodu14 = tbSSinif14.sSinifKodu INNER JOIN tbSSinif15 ON tbStokSinifi.sSinifKodu15 = tbSSinif15.sSinifKodu LEFT OUTER JOIN tbStokAciklama ON tbStok.nStokID = tbStokAciklama.nStokID " & kriter & " " & kriter2 & "")
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
        dr("FIYAT5") = dr1("FIYAT5")
        dr("FIYAT6") = dr1("FIYAT6")
        dr("FIYAT7") = dr1("FIYAT7")
        dr("FIYAT8") = dr1("FIYAT8")
        dr("FIYAT9") = dr1("FIYAT9")
        dr("FIYAT10") = dr1("FIYAT10")
        dr("FIYATA") = dr1("FIYATA")
        dr("FIYATM") = dr1("FIYATM")
        dr("lFiyat") = dr1("lFiyat")
        If dr("lFiyat") = 0 Then
        Else
            dr("FIYAT1") = dr1("lFiyat")
        End If
        dr("lBirimCarpan") = dr1("lBirimCarpan")
        dr("nKdvOrani") = dr1("nKdvOrani")
        dr("Mevcut") = 1
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
        frm.market = True
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
                    dr("FIYAT5") = dr1("FIYAT5")
                    dr("FIYAT6") = dr1("FIYAT6")
                    dr("FIYAT7") = dr1("FIYAT7")
                    dr("FIYAT8") = dr1("FIYAT8")
                    dr("FIYAT9") = dr1("FIYAT9")
                    dr("FIYAT10") = dr1("FIYAT10")
                    dr("FIYATA") = dr1("FIYATA")
                    dr("FIYATM") = dr1("FIYATM")
                    dr("lFiyat") = dr1("lFiyat")
                    If dr("lFiyat") = 0 Then
                    Else
                        dr("FIYAT1") = dr1("lFiyat")
                    End If
                    dr("lBirimCarpan") = dr1("lBirimCarpan")
                    dr("nKdvOrani") = dr1("nKdvOrani")
                    dr("sRenkAdi") = dr1("sRenkAdi")
                    dr("Mevcut") = 1
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
            
            ' Seçili satýrlarý kontrol et
            Dim arr As Integer() = GridView1.GetSelectedRows()
            If arr Is Nothing OrElse arr.Length = 0 Then
                XtraMessageBox.Show(Sorgu_sDil("Lütfen listeden en az bir satýr seçiniz...", sDil), Sorgu_sDil("Dikkat", sDil), MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Exit Sub
            End If
            
            ' Geçerli satýrlarý listeye al ve sýrala
            Dim validRows As New List(Of Integer)()
            For Each h As Integer In arr
                If h >= 0 Then validRows.Add(h)
            Next
            validRows.Sort()
            
            If validRows.Count = 0 Then
                XtraMessageBox.Show(Sorgu_sDil("Seçili geçerli satýr bulunamadý...", sDil), Sorgu_sDil("Dikkat", sDil), MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Exit Sub
            End If
            
            If XtraMessageBox.Show(Sorgu_sDil("Seçili " & validRows.Count & " Stokun " & nSinifNo & ".Sýnýf Kodlarýný [" & sSinifKod & "/" & sSinifAciklama & " ] olarak Deðiþtirmek Ýstediðinize Emin misiniz...?", sDil), Sorgu_sDil("Dikkat", sDil), MessageBoxButtons.YesNo, MessageBoxIcon.Question) = MsgBoxResult.Yes Then
                Dim dr As DataRow
                Dim con As New OleDb.OleDbConnection
                Dim cmd As New OleDb.OleDbCommand
                con.ConnectionString = connection
                con.Open()
                cmd.Connection = con
                
                bar.Properties.Maximum = validRows.Count
                panelstatus.Visible = True
                bar.Visible = True
                bar.Position = 0
                
                Dim processedCodes As New HashSet(Of String)()
                
                ' Sýralý satýrlarý iþle
                For Each rowHandle As Integer In validRows
                    dr = GridView1.GetDataRow(rowHandle)
                    If dr IsNot Nothing Then
                        Dim sKodu As String = dr("sKodu").ToString()
                        Dim sModel As String = dr("sModel").ToString()
                        ' Ayný stok kodunu tekrar iþleme
                        If Not processedCodes.Contains(sKodu) Then
                            processedCodes.Add(sKodu)
                            dr("Sinif" & nSinifNo & "") = sSinifAciklama
                            cmd.CommandText = sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED UPDATE tbStokSinifi set sSinifKodu" & nSinifNo & " = '" & sSinifKod & "'  where nStokID in ( select nStokID from tbStok where sModel = '" & sModel & "' )")
                            cmd.ExecuteNonQuery()
                        End If
                        bar.Position += 1
                        bar.Refresh()
                        Application.DoEvents()
                    End If
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
            ' Seçili satýrlarý al
            Dim arr As Integer() = GridView1.GetSelectedRows()
            If arr Is Nothing OrElse arr.Length = 0 Then
                XtraMessageBox.Show(Sorgu_sDil("Lütfen listeden en az bir satýr seçiniz...", sDil), Sorgu_sDil("Dikkat", sDil), MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Exit Sub
            End If
            
            ' Geçerli satýr sayýsýný hesapla (negatif handle'larý atla)
            Dim validCount As Integer = 0
            For Each h As Integer In arr
                If h >= 0 Then validCount += 1
            Next
            
            If validCount = 0 Then
                XtraMessageBox.Show(Sorgu_sDil("Seçili geçerli satýr bulunamadý...", sDil), Sorgu_sDil("Dikkat", sDil), MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Exit Sub
            End If
            
            If degistir = True Then
                sayi = validCount
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
                ' Sadece seçili satýrlarý iþle (negatif handle'larý atla)
                For Each rowHandle As Integer In arr
                    If rowHandle < 0 Then Continue For
                    dr = GridView1.GetDataRow(rowHandle)
                    If dr Is Nothing Then Continue For
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
            ' Seçili satýrlarý kontrol et
            Dim arr As Integer() = GridView1.GetSelectedRows()
            If arr Is Nothing OrElse arr.Length = 0 Then
                XtraMessageBox.Show(Sorgu_sDil("Lütfen listeden en az bir satýr seçiniz...", sDil), Sorgu_sDil("Dikkat", sDil), MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Exit Sub
            End If
            
            ' Geçerli satýr sayýsýný hesapla (negatif handle'larý atla)
            Dim validCount As Integer = 0
            For Each h As Integer In arr
                If h >= 0 Then validCount += 1
            Next
            
            If validCount = 0 Then
                XtraMessageBox.Show(Sorgu_sDil("Seçili geçerli satýr bulunamadý...", sDil), Sorgu_sDil("Dikkat", sDil), MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Exit Sub
            End If
            
            If XtraMessageBox.Show(frm.LookUpEdit1.EditValue & Sorgu_sDil(" Kodunu Seçili " & validCount & " Stoða Atamak Ýstediðinize Emin misiniz...?", sDil), Sorgu_sDil("Dikkat", sDil), MessageBoxButtons.YesNo, MessageBoxIcon.Question) = MsgBoxResult.Yes Then
                Dim dr As DataRow
                Dim con As New OleDb.OleDbConnection
                Dim cmd As New OleDb.OleDbCommand
                con.ConnectionString = connection
                con.Open()
                cmd.Connection = con
                Dim sKdvTipi
                
                ' Sadece seçili satýrlarý iþle (negatif handle'larý atla)
                For Each rowHandle As Integer In arr
                    If rowHandle < 0 Then Continue For
                    dr = GridView1.GetDataRow(rowHandle)
                    If dr IsNot Nothing Then
                        sKdvTipi = frm.LookUpEdit1.EditValue
                        dr("sKdvTipi") = sKdvTipi
                        'dr("nKdvOrani") = frm.LookUpEdit1.Text
                        cmd.CommandText = sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED UPDATE tbStok set sKdvTipi = '" & sKdvTipi & "'  where sModel = '" & dr("sModel") & "'")
                        cmd.ExecuteNonQuery()
                    End If
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
            SaveFileDialog1.FileName = "Market.xls"
            If SaveFileDialog1.ShowDialog = Windows.Forms.DialogResult.OK Then
                GridView1.ExportToXls(SaveFileDialog1.FileName.ToString)
            End If
        End If
    End Sub
    Private Sub BarButtonItem34_ItemClick(ByVal sender As Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem34.ItemClick
        If XtraMessageBox.Show(Sorgu_sDil("Sonuçlarý Text Dosyasý Oluþturmak Ýstediðinize Emin misiniz...?", sDil), Sorgu_sDil("Dikkat", sDil), MessageBoxButtons.YesNo, MessageBoxIcon.Question) = MsgBoxResult.Yes Then
            SaveFileDialog1.Filter = "Text Dosyalarý(*.txt) |*.txt"
            SaveFileDialog1.InitialDirectory = "c:\"
            SaveFileDialog1.FileName = "Market.txt"
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
            SaveFileDialog1.FileName = "Market.xls"
            If SaveFileDialog1.ShowDialog = Windows.Forms.DialogResult.OK Then
                GridView1.ExportToXls(SaveFileDialog1.FileName.ToString)
            End If
        End If
    End Sub
    Private Sub BarButtonItem36_ItemClick(ByVal sender As Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem36.ItemClick
        If XtraMessageBox.Show(Sorgu_sDil("Sonuçlarý Text Dosyasý Oluþturmak Ýstediðinize Emin misiniz...?", sDil), Sorgu_sDil("Dikkat", sDil), MessageBoxButtons.YesNo, MessageBoxIcon.Question) = MsgBoxResult.Yes Then
            SaveFileDialog1.Filter = "Text Dosyalarý(*.txt) |*.txt"
            SaveFileDialog1.InitialDirectory = "c:\"
            SaveFileDialog1.FileName = "Market.txt"
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
        frm_Market_yardim.ShowDialog()
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




    ' =============== RESÝM GÖSTERME ÖZELLÝÐÝ ===============
    Private Const MAX_CACHE_SIZE As Integer = 100
    Private thumbnailSize As New Size(80, 80)
    
    Private Sub sec_bResimGoster_CheckedChanged(sender As Object, e As EventArgs) Handles sec_bResimGoster.CheckedChanged
        colpResim.Visible = sec_bResimGoster.Checked
        If sec_bResimGoster.Checked Then
            GridView1.RowHeight = 80
            ' CustomUnboundColumnData event'ini baðla
            RemoveHandler GridView1.CustomUnboundColumnData, AddressOf GridView1_CustomUnboundColumnData_Resim
            AddHandler GridView1.CustomUnboundColumnData, AddressOf GridView1_CustomUnboundColumnData_Resim
            GridView1.RefreshData()
        Else
            GridView1.RowHeight = -1
            RemoveHandler GridView1.CustomUnboundColumnData, AddressOf GridView1_CustomUnboundColumnData_Resim
            GridView1.RefreshData()
        End If
    End Sub
    
    Private Sub GridView1_CustomUnboundColumnData_Resim(sender As Object, e As DevExpress.XtraGrid.Views.Base.CustomColumnDataEventArgs)
        If e.Column.FieldName <> "colpResim" OrElse Not e.IsGetData Then Return
        
        Try
            ' Önce SQL'den gelen pResim verisini kontrol et (bound data)
            Dim pResimData As Object = Nothing
            Try
                pResimData = GridView1.GetListSourceRowCellValue(e.ListSourceRowIndex, "pResim")
            Catch
                ' pResim kolonu yoksa devam et
            End Try
            
            ' Eðer SQL'den pResim verisi geldiyse direkt kullan
            If pResimData IsNot Nothing AndAlso Not IsDBNull(pResimData) Then
                Dim pResimStr As String = pResimData.ToString()
                If Not String.IsNullOrEmpty(pResimStr) Then
                    Dim img As Image = LoadImageOptimized(pResimStr)
                    If img IsNot Nothing Then
                        e.Value = img
                        Return
                    End If
                End If
            End If
            
            ' SQL'den veri gelmediyse alternatif arama yap
            Dim nStokID As Object = GridView1.GetListSourceRowCellValue(e.ListSourceRowIndex, "nStokID")
            Dim sModel As Object = GridView1.GetListSourceRowCellValue(e.ListSourceRowIndex, "sModel")
            
            If String.IsNullOrEmpty(sModel?.ToString()?.Trim()) Then
                e.Value = Nothing
                Return
            End If
            
            Dim nStokIDValue As Integer = 0
            If nStokID IsNot Nothing AndAlso Not IsDBNull(nStokID) Then
                nStokIDValue = Convert.ToInt32(nStokID)
            End If
            
            Dim cacheKey As String = If(nStokIDValue > 0, "stokid_" & nStokIDValue.ToString(), "model_" & sModel.ToString().Trim())
            
            If _imgCache.ContainsKey(cacheKey) Then
                e.Value = _imgCache(cacheKey)
                Return
            End If
            
            Dim imagePath As String = GetImageFromDatabase(nStokIDValue, sModel.ToString().Trim())
            
            If Not String.IsNullOrEmpty(imagePath) Then
                Dim thumb As Image = LoadImageOptimized(imagePath)
                If thumb IsNot Nothing Then
                    If Not _imgCache.ContainsKey(cacheKey) Then
                        _imgCache(cacheKey) = thumb
                    End If
                    e.Value = thumb
                End If
            End If
            
        Catch ex As Exception
            e.Value = Nothing
        End Try
    End Sub
    
    Private Function GetImageFromDatabase(nStokID As Integer, sModel As String) As String
        Try
            ' STRATEJI 1: nStokID ile exact match (pResim ve yol kontrol)
            If nStokID > 0 Then
                Dim query1 As String = "SELECT TOP 1 pResim, yol FROM tbStokResim WHERE nStokID = ? ORDER BY nSira ASC"
                Using tempConn As New OleDb.OleDbConnection(connection)
                    Using cmd As New OleDb.OleDbCommand(query1, tempConn)
                        cmd.Parameters.Add(New OleDb.OleDbParameter("nStokID", OleDb.OleDbType.Integer)).Value = nStokID
                        tempConn.Open()
                        Using reader As OleDb.OleDbDataReader = cmd.ExecuteReader()
                            If reader.Read() Then
                                ' Önce pResim kontrol
                                Dim pResim As String = If(reader.IsDBNull(0), "", reader.GetValue(0).ToString().Trim())
                                If Not String.IsNullOrEmpty(pResim) Then Return pResim
                                ' Sonra yol kontrol
                                Dim yol As String = If(reader.IsDBNull(1), "", reader.GetValue(1).ToString().Trim())
                                If Not String.IsNullOrEmpty(yol) Then Return yol
                            End If
                        End Using
                    End Using
                End Using
            End If
            
            ' STRATEJI 2: sModel ile (pResim ve yol kontrol)
            If Not String.IsNullOrEmpty(sModel) Then
                Dim query2 As String = "SELECT TOP 1 pResim, yol FROM tbStokResim WHERE sModel = ? ORDER BY nSira ASC"
                Using tempConn As New OleDb.OleDbConnection(connection)
                    Using cmd As New OleDb.OleDbCommand(query2, tempConn)
                        cmd.Parameters.Add(New OleDb.OleDbParameter("sModel", OleDb.OleDbType.VarChar, 50)).Value = sModel
                        tempConn.Open()
                        Using reader As OleDb.OleDbDataReader = cmd.ExecuteReader()
                            If reader.Read() Then
                                ' Önce pResim kontrol
                                Dim pResim As String = If(reader.IsDBNull(0), "", reader.GetValue(0).ToString().Trim())
                                If Not String.IsNullOrEmpty(pResim) Then Return pResim
                                ' Sonra yol kontrol
                                Dim yol As String = If(reader.IsDBNull(1), "", reader.GetValue(1).ToString().Trim())
                                If Not String.IsNullOrEmpty(yol) Then Return yol
                            End If
                        End Using
                    End Using
                End Using
            End If
            
        Catch ex As Exception
        End Try
        
        Return Nothing
    End Function
    
    Private Function LoadImageOptimized(imageData As Object) As Image
        If imageData Is Nothing Then Return Nothing
        
        Try
            ManageCacheSize()
            
            Dim s As String = TryCast(imageData, String)
            If Not String.IsNullOrEmpty(s) Then
                ' Dosya yolu kontrolü
                If IO.File.Exists(s) Then
                    Using fs As New IO.FileStream(s, IO.FileMode.Open, IO.FileAccess.Read, IO.FileShare.ReadWrite)
                        Using fullImage As Image = Image.FromStream(fs)
                            Return CreateThumbnailCompressed(fullImage)
                        End Using
                    End Using
                    
                ' URL kontrolü
                ElseIf s.StartsWith("http://", StringComparison.OrdinalIgnoreCase) OrElse s.StartsWith("https://", StringComparison.OrdinalIgnoreCase) Then
                    Dim localFolder As String = "C:/Eticaret/Stok Resim/"
                    If Not IO.Directory.Exists(localFolder) Then IO.Directory.CreateDirectory(localFolder)
                    
                    Dim fileName As String = IO.Path.GetFileName(New Uri(s).LocalPath)
                    Dim localPath As String = IO.Path.Combine(localFolder, fileName)
                    
                    If Not IO.File.Exists(localPath) Then
                        Using client As New WebClient()
                            client.DownloadFile(s, localPath)
                        End Using
                    End If
                    
                    Using fs As New IO.FileStream(localPath, IO.FileMode.Open, IO.FileAccess.Read, IO.FileShare.ReadWrite)
                        Using fullImage As Image = Image.FromStream(fs)
                            Return CreateThumbnailCompressed(fullImage)
                        End Using
                    End Using
                    
                ' Base64 kontrolü
                ElseIf s.Length > 100 Then
                    Dim base64Data As String = s
                    If s.Contains(",") Then
                        base64Data = s.Substring(s.IndexOf(",") + 1)
                    End If
                    
                    Dim imgBytes As Byte() = Convert.FromBase64String(base64Data)
                    Using ms As New IO.MemoryStream(imgBytes)
                        Using fullImage As Image = Image.FromStream(ms)
                            Return CreateThumbnailCompressed(fullImage)
                        End Using
                    End Using
                End If
            End If
            
        Catch ex As Exception
            Return Nothing
        End Try
        
        Return Nothing
    End Function
    
    Private Sub ManageCacheSize()
        Try
            If _imgCache.Count > MAX_CACHE_SIZE Then
                Dim keysToRemove As New List(Of String)()
                Dim count As Integer = 0
                For Each kvp As KeyValuePair(Of String, Image) In _imgCache
                    If count >= _imgCache.Count - MAX_CACHE_SIZE Then Exit For
                    keysToRemove.Add(kvp.Key)
                    If kvp.Value IsNot Nothing Then
                        kvp.Value.Dispose()
                    End If
                    count += 1
                Next
                For Each key As String In keysToRemove
                    _imgCache.Remove(key)
                Next
            End If
        Catch
        End Try
    End Sub
    
    Private Function CreateThumbnailCompressed(originalImage As Image) As Image
        If originalImage Is Nothing Then Return Nothing
        Try
            Dim ratioX As Double = CDbl(thumbnailSize.Width) / originalImage.Width
            Dim ratioY As Double = CDbl(thumbnailSize.Height) / originalImage.Height
            Dim ratio As Double = Math.Min(ratioX, ratioY)
            
            Dim newWidth As Integer = Math.Max(1, CInt(originalImage.Width * ratio))
            Dim newHeight As Integer = Math.Max(1, CInt(originalImage.Height * ratio))
            
            Dim thumbnail As New Bitmap(newWidth, newHeight, Imaging.PixelFormat.Format24bppRgb)
            
            Using g As Graphics = Graphics.FromImage(thumbnail)
                g.InterpolationMode = Drawing2D.InterpolationMode.Low
                g.SmoothingMode = Drawing2D.SmoothingMode.HighSpeed
                g.PixelOffsetMode = Drawing2D.PixelOffsetMode.HighSpeed
                g.CompositingQuality = Drawing2D.CompositingQuality.HighSpeed
                g.Clear(Color.White)
                g.DrawImage(originalImage, 0, 0, newWidth, newHeight)
            End Using
            
            Return thumbnail
        Catch ex As Exception
            Return Nothing
        End Try
    End Function
    ' =============== RESÝM GÖSTERME SONU ===============

End Class