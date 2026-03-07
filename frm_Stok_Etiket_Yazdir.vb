Imports System
Imports System.Runtime.InteropServices
Imports FastReport
Imports System.IO
Imports Microsoft.Win32
Imports DevExpress.XtraEditors
Public Class frm_Stok_Etiket_Yazdir
    Public firmano
    Public donemno
    Public connection
    Public kullanici
    Dim mevcut As Decimal = 1
    Dim okut As Boolean = False
    Public islem_status As Boolean = False
    Public bAra As Boolean = False
    Public sAra As String = ""
    Dim ds_stok As DataSet
    Public dataset1 As DataSet
    Dim ds_tbBirimCinsi As DataSet
    Dim DS_tbKdv As DataSet
    Dim sPrint As String = ""
    Private Sub SimpleButton2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SimpleButton2.Click
        Me.Close()
    End Sub
    Private Sub SimpleButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SimpleButton1.Click
        Me.Close()
    End Sub
    Private Sub frm_Stok_Etiket_Yazdir_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        If islem_status = False Then
            Registry.CurrentUser.CreateSubKey("Software").CreateSubKey("BusinessSmart").CreateSubKey("VIEW").CreateSubKey("STOK").CreateSubKey("EtiketYazdir").SetValue("bYazdir", sec_bYazdir.Checked)
        End If
        Registry.CurrentUser.CreateSubKey("Software").CreateSubKey("BusinessSmart").CreateSubKey("VIEW").CreateSubKey("STOK").CreateSubKey("EtiketYazdir").SetValue("sFile", txt_sDosya.Text)
    End Sub
    Private Sub frm_Stok_Etiket_Yazdir_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        dataload_tbBirimCinsi()
        dataload_tbKdv()
        txt_sAra.Focus()
        txt_sAra.Select()
        print_ara()
        If islem_status = True Then
            sec_bYazdir.Checked = False
            If bAra = True Then
                satir_ekle_stok(sAra, True)
            Else
                stok_ara()
            End If
        End If
    End Sub
    Private Sub print_ara()
        Dim ara As String = ""
        Try
            ara = Registry.CurrentUser.OpenSubKey("Software").OpenSubKey("Microsoft").OpenSubKey("Windows NT").OpenSubKey("CurrentVersion").OpenSubKey("Windows").GetValue("Device").ToString()
        Catch ex As Exception
            ara = ""
        End Try
        Try
            txt_sDosya.Text = Registry.CurrentUser.OpenSubKey("Software").OpenSubKey("BusinessSmart").OpenSubKey("VIEW").OpenSubKey("STOK").OpenSubKey("EtiketYazdir").GetValue("sFile").ToString
        Catch ex As Exception
            txt_sDosya.Text = "c:\Formlar\Raporlar\Etiket\Etiket.frx"
        End Try
        If islem_status = False Then
            Try
                sec_bYazdir.Checked = Registry.CurrentUser.OpenSubKey("Software").OpenSubKey("BusinessSmart").OpenSubKey("VIEW").OpenSubKey("STOK").OpenSubKey("EtiketYazdir").GetValue("bYazdir").ToString
            Catch ex As Exception
                sec_bYazdir.Checked = True
            End Try
        End If
        'MsgBox(ara)
        Dim adi As String = ""
        Dim soyadi As String = ""
        Dim x
        If CStr(ara.ToString) <> "" Then
            x = (ara).IndexOf(",", 1, (ara.Length - 1))
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
        'MsgBox(adi)
        sPrint = adi
        sec_sPrint.Text = sPrint
    End Sub
    Private Sub satir_ekle_stok(ByVal sAra As String, Optional ByVal status As Boolean = False)
        Dim frm As New frm_stok
        frm.connection = connection
        frm.firmano = firmano
        frm.donemno = donemno
        frm.islemstatus = True
        frm.kullanici = kullanici
        frm.status = status
        If sAra <> "" Then
            frm.qgelismis = "Başlar"
            frm.gelismis = sAra
            frm.status = True
            frm.mevcut = mevcut
        Else
        End If
        If frm.ShowDialog() = Windows.Forms.DialogResult.OK Then
            Dim dr1 As DataRow
            dr1 = frm.GridView1.GetDataRow(frm.GridView1.FocusedRowHandle)
            txt_sAra.Text = Trim(dr1("sBarkod").ToString)
            ara()
            'ınputPanel1.Visible = False
        End If
    End Sub
    Private Sub ara()
        Dim sKriter As String = ""
        If txt_sAra.Text <> "" Then
            'sKriter = " AND tbStokBarkodu.sBarkod like '" & txt_sAra.Text & "%' or tbStok.sKodu like '" & txt_sAra.Text & "%'"
            Dim gelismis As String = txt_sAra.Text
            Dim qgelismis As String = "Eşittir"
            sKriter = " AND (tbStok.skodu " & sorgu_kriter_string(gelismis, qgelismis) & ") OR  (tbStok.sAciklama " & sorgu_kriter_string(gelismis, qgelismis) & ") OR  (tbStok.sOzelNot " & sorgu_kriter_string(gelismis, qgelismis) & ")OR  (tbStok.sKisaAdi " & sorgu_kriter_string(gelismis, qgelismis) & ") OR tbStok.nStokID IN (Select nStokID from tbStokBarkodu where sBarkod " & sorgu_kriter_string(gelismis, qgelismis) & ")  OR (tbStok.sRenk " & sorgu_kriter_string(gelismis, qgelismis) & ") OR (tbStok.sBeden " & sorgu_kriter_string(gelismis, qgelismis) & ") "
            dataset1 = sorgu("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT tbStok.*, tbRenk.sRenkAdi AS sRenkAdi, ISNULL(tbStokBarkodu.sBarkod,'') AS sBarkod, ISNULL((SELECT isnull(lfiyat , 0) FROM tbstokfiyati WHERE nStokId = tbStok.NstokId AND sFiyatTipi = '" & sFiyat1 & "'), 0) AS lFiyat1, ISNULL((SELECT isnull(lfiyat , 0) FROM tbstokfiyati WHERE nStokId = tbStok.NstokId AND sFiyatTipi = '" & sFiyat2 & "'), 0) AS lFiyat2, ISNULL((SELECT isnull(lfiyat , 0) FROM tbstokfiyati WHERE nStokId = tbStok.NstokId AND sFiyatTipi = '" & sFiyat3 & "'), 0) AS lFiyat3,ISNULL((SELECT isnull(lfiyat , 0) FROM tbstokfiyati WHERE nStokId = tbStok.NstokId AND sFiyatTipi = '" & sFiyat4 & "'), 0) AS lFiyat4, (SELECT ISNULL(SUM(lGirisMiktar1 - lCikisMiktar1) , 0) FROM tbStokFisiDetayi WHERE nStokID = tbStok.nStokID) AS lMevcut,(SELECT ISNULL(SUM(tbAlisverisSiparis.lGCMiktar - tbAlisverisSiparis.bEkAlan1), 0) AS BEKLEYEN FROM tbAlisverisSiparis INNER JOIN tbAlisVeris ON tbAlisverisSiparis.nAlisverisID = tbAlisVeris.nAlisverisID WHERE (tbAlisverisSiparis.nGirisCikis = 3) AND (tbAlisverisSiparis.lGCMiktar <> tbAlisverisSiparis.bEkAlan1) AND (tbAlisVeris.sFisTipi = 'SP' OR tbAlisVeris.sFisTipi = 'SK') AND (tbAlisverisSiparis.dteOnayTarihi = '01/01/1900') AND (tbAlisverisSiparis.dteTeslimEdilecek BETWEEN '01/01/1900' AND '31/12/2048') AND (tbAlisVeris.dteFaturaTarihi BETWEEN '01/01/1900' AND '31/12/2048') AND tbAlisVerisSiparis.nStokID = tbStok.nStokID) AS lBekleyen FROM tbStok INNER JOIN tbRenk ON tbStok.sRenk = tbRenk.sRenk LEFT OUTER JOIN                       tbStokBarkodu ON tbStok.nStokID = tbStokBarkodu.nStokID AND tbStokBarkodu.nKisim = 0 WHERE (tbStokBarkodu.nKisim = 0) " & sKriter & " ")
            If dataset1.Tables(0).Rows.Count = 1 Then
                Dim dr As DataRow = dataset1.Tables(0).Rows(0)
                txt_nStokID.Text = Trim(dr("nStokID"))
                txt_sKodu.Text = Trim(dr("sKodu"))
                txt_sModel.Text = Trim(dr("sModel"))
                txt_sAciklama.Text = Trim(dr("sAciklama"))
                txt_sKisaAdi.Text = Trim(dr("sKisaAdi"))
                txt_sBarkod.Text = Trim(dr("sBarkod").ToString)
                txt_sRenkAdi.Text = Trim(dr("sRenkAdi"))
                txt_sRenk.Text = Trim(dr("sRenk").ToString)
                txt_sBeden.Text = Trim(dr("sBeden").ToString)
                txt_sKavala.Text = Trim(dr("sKavala").ToString)
                sec_sBirimCinsi.EditValue = Trim(dr("sBirimCinsi1").ToString)
                sec_sKdvTipi.EditValue = Trim(dr("sKdvTipi").ToString)
                txt_lFiyat1.Text = FormatNumber(dr("lFiyat1"), 2)
                txt_lFiyat2.Text = FormatNumber(dr("lFiyat2"), 2)
                txt_lFiyat3.Text = FormatNumber(dr("lFiyat3"), 2)
                txt_lFiyat4.Text = FormatNumber(dr("lFiyat4"), 2)
                txt_lMevcut.Text = Microsoft.VisualBasic.Format(dr("lMevcut"), "#,0.##")
                txt_lBekleyen.Text = Microsoft.VisualBasic.Format(dr("lBekleyen"), "#,0.##")
                txt_lNet.Text = Microsoft.VisualBasic.Format(dr("lMevcut") - dr("lBekleyen"), "#,0.##")
                txt_nMiktar.EditValue = mevcut
                If sec_bYazdir.Checked = True Then
                    raporla(3, True)
                End If
            ElseIf dataset1.Tables(0).Rows.Count > 1 Then
                txt_nStokID.Text = 0
                txt_sKodu.Text = "*"
                txt_sModel.Text = "*"
                txt_sAciklama.Text = "*"
                txt_sKisaAdi.Text = "*"
                txt_sBarkod.Text = "*"
                txt_sRenkAdi.Text = "*"
                txt_sRenk.Text = "*"
                txt_sBeden.Text = "*"
                txt_sKavala.Text = "*"
                sec_sBirimCinsi.Text = "*"
                sec_sKdvTipi.Text = "*"
                txt_lFiyat1.Text = "*"
                txt_lFiyat2.Text = "*"
                txt_lFiyat3.Text = "*"
                txt_lFiyat4.Text = "*"
                txt_lMevcut.Text = "*"
                txt_lBekleyen.Text = "*"
                txt_lNet.Text = "*"
                txt_nMiktar.EditValue = 1
                MsgBox("Birden Fazla Kayıt Bulunmuştur" & vbCrLf & "Lütfen Yeniden Sorgulayınız..", MsgBoxStyle.Critical, "Uyarı")
            ElseIf dataset1.Tables(0).Rows.Count = 0 Then
                txt_nStokID.Text = 0
                txt_sKodu.Text = "*"
                txt_sAciklama.Text = "*"
                txt_sKisaAdi.Text = "*"
                txt_sBarkod.Text = "*"
                txt_sRenkAdi.Text = "*"
                txt_sRenk.Text = "*"
                txt_sBeden.Text = "*"
                txt_sKavala.Text = "*"
                sec_sBirimCinsi.Text = "*"
                sec_sKdvTipi.Text = "*"
                txt_lFiyat1.Text = "*"
                txt_lFiyat2.Text = "*"
                txt_lFiyat3.Text = "*"
                txt_lFiyat4.Text = "*"
                txt_lMevcut.Text = "*"
                txt_lBekleyen.Text = "*"
                txt_lNet.Text = "*"
                txt_nMiktar.EditValue = 1
                If MsgBox("Kayıt Bulunamadı...!" & vbCrLf & "Yeni Kayıt Eklemek İstermisiniz...?", MsgBoxStyle.YesNo, "Soru") = MsgBoxResult.Yes Then
                    Stok_Yeni()
                End If
            End If
        End If
        txt_sAra.Focus()
        txt_sAra.SelectAll()
        sKriter = Nothing
    End Sub
    Private Function sorgu_kriter_string(ByVal deger As String, ByVal kriter As String) As String
        Dim sorgu_kriter As String = ""
        If kriter = "Başlar" Then
            sorgu_kriter = " LIKE '" & deger & "%' "
        ElseIf kriter = "Biter" Then
            sorgu_kriter = " LIKE N'%" & deger & "' "
        ElseIf kriter = "İçerir" Then
            sorgu_kriter = " LIKE N'%" & deger & "%' "
        ElseIf kriter = "Boş" Then
            sorgu_kriter = " IS NULL "
        ElseIf kriter = "Dolu" Then
            sorgu_kriter = " <> '' "
        ElseIf kriter = "Farklı" Then
            sorgu_kriter = " <> N'" & deger & "' "
        ElseIf kriter = "Büyük" Then
            sorgu_kriter = " >  N'" & deger & "' "
        ElseIf kriter = "Küçük" Then
            sorgu_kriter = " < N'" & deger & "' "
        ElseIf kriter = "Eşittir" Then
            sorgu_kriter = " = N'" & deger & "' "
        End If
        Return sorgu_kriter
    End Function
    Private Sub dataload_tbBirimCinsi()
        ds_tbBirimCinsi = sorgu(sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT     * FROM         tbBirimCinsi"))
        sec_sBirimCinsi.Properties.DataSource = ds_tbBirimCinsi.Tables(0)
        'sec_sBirimCinsi.DisplayMember = "sAciklama"
        'sec_sBirimCinsi.ValueMember = "sBirimCinsi"
        'txt_sBirimCinsi2.Properties.DataSource = ds_tbBirimCinsi.Tables(0)
    End Sub
    Private Sub dataload_tbKdv()
        DS_tbKdv = sorgu(sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT     * FROM         tbKdv"))
        sec_sKdvTipi.Properties.DataSource = DS_tbKdv.Tables(0)
        'sec_sKdvTipi.DisplayMember = "nKdvOrani"
        'sec_sKdvTipi.ValueMember = "sKdvTipi"
    End Sub
    Private Function sorgu_query(ByVal query As String) As String
        query = Replace(query, "*!F", "F0" + firmano.ToString)
        query = Replace(query, "!D", "D000" + donemno.ToString)
        Return query
    End Function
    Private Function sorgu(ByVal query As String, Optional ByVal sTable As String = "TABLE1") As DataSet
        Dim cmd As New OleDb.OleDbCommand
        Dim adapter As New OleDb.OleDbDataAdapter
        Dim conn As New OleDb.OleDbConnection
        conn.ConnectionString = connection
        cmd.CommandTimeout = False
        adapter.SelectCommand = cmd
        cmd.CommandText = query
        cmd.Connection = conn
        If conn.State = ConnectionState.Closed Then
            conn.Open()
        End If
        Dim DS As New DataSet
        Dim N As Integer = adapter.Fill(DS, sTable)
        conn.Close()
        Return DS
        cmd = Nothing
        conn = Nothing
        adapter = Nothing
    End Function
    Private Sub Stok_Yeni()
        If KayitSiniri_kontrol("tbStok", "", nKayitSinir) = True Then
            Dim frm As New frm_stok_kart_kisa
            frm.firmano = firmano
            frm.donemno = donemno
            frm.connection = connection
            frm.kullanici = kullanici
            frm.sModel = ""
            frm.nStokID = 0
            frm.sKodu = ""
            frm.islem_status = True
            frm.txt_sKodu.Text = txt_sAra.Text
            frm.txt_sBarkod.Text = txt_sAra.Text
            If yetki_kontrol(kullanici, frm.Name) = True Then
                frm.Show()
            End If
        End If
    End Sub
    Private Sub txt_sAra_EditValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles txt_sAra.EditValueChanged
        If Len(txt_sAra.EditValue.ToString) <> 0 Then
            lbl_ara.Text = Len(txt_sAra.EditValue.ToString)
        Else
            lbl_ara.Text = "*"
        End If
    End Sub
    Private Sub txt_sAra_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txt_sAra.KeyDown
        If e.KeyCode = Keys.Enter Then
            Try
                stok_ara()
            Catch ex As Exception
                mevcut = 1
                stok_kontrol()
            End Try
        End If
    End Sub
    Public Sub stok_ara()
        If Trim(txt_sAra.Text) <> "" Then
            Dim X As String
            lbl_ara.Text = "Barkod Standardı Kontrol Ediliyor..."
            lbl_ara.Refresh()
            If IsNumeric(Trim(txt_sAra.Text)) = True Then
                If Len(Trim(txt_sAra.Text).ToString) < 2 Then
                    txt_sAra.Text = Trim(txt_sAra.Text) + "  "
                End If
                If Trim((Trim(txt_sAra.Text)).Substring(0, 2)) = sBarcodeStd Then
                    Dim deger As String = Trim(Trim(txt_sAra.Text))
                    If IsNumeric(deger) = True Then
                        mevcut = CType((deger.Substring(7, sBarcodeStd_KG) + "." + deger.Substring(7 + sBarcodeStd_KG, sBarcodeStd_GR)), Decimal)
                        txt_sAra.Text = deger.Substring(2, 5)
                    End If
                Else
                    mevcut = 1
                End If
            Else
                If CStr(Trim(txt_sAra.Text).ToString) <> "" Then
                    X = (Trim(txt_sAra.Text)).IndexOf("*", 1, (Trim(txt_sAra.Text)).Length - 1)
                    If X = -1 Then
                        mevcut = 1
                    Else
                        mevcut = (Trim(txt_sAra.Text)).Substring(0, X)
                        txt_sAra.Text = (Trim(txt_sAra.Text)).Substring((X + 1), (Trim(txt_sAra.Text)).Length - (X + 1))
                        If IsNumeric(Trim(txt_sAra.Text)) Then
                        Else
                        End If
                    End If
                End If
            End If
            lbl_ara.Text = "Barkod Standardı Kontrolü Tamamlandı..."
            lbl_ara.Refresh()
            stok_kontrol()
        End If
    End Sub
    Private Sub stok_kontrol()
        If IsNumeric(Trim(txt_sAra.Text)) = True Then
            okut = True
        Else
            okut = False
        End If
        lbl_ara.Text = "Stok Kartı Kontrolü Yapılıyor..."
        lbl_ara.Refresh()
        Dim kontrol = sorgu_stok_kontrol(txt_sAra.Text)
        If kontrol = 0 Then
            If MsgBox("Kayıt Bulunumadı..." & vbCrLf & "Yeni Stok Kaydetmek İstermisiniz...?", MsgBoxStyle.YesNo + MsgBoxStyle.Question, "Stok Kontrol") = MsgBoxResult.Yes Then
                Stok_Yeni()
            End If
            lbl_ara.Text = "Stok Kaydı Bulunamadı!!!.Tekrar Deneyiniz..."
            lbl_ara.Refresh()
            txt_sAra.Focus()
            txt_sAra.SelectAll()
        ElseIf kontrol = 1 Then
            lbl_ara.Text = "Belge Stok Kaydı Kontrol Ediliyor... "
            lbl_ara.Refresh()
            'MsgBox("Kayıt Tek...")
            dataload_stok(Trim(txt_sAra.Text))
            lbl_ara.Text = "Stok Bilgisi Yükleniyor... "
            lbl_ara.Refresh()
            ara()
            lbl_ara.Text = "Barkod"
            txt_sAra.Focus()
            txt_sAra.SelectAll()
        ElseIf kontrol > 1 Then
            MsgBox("Birden Fazla Kayıt Bulunmuştur" & vbCrLf & "Lütfen Yeniden Sorgulayınız..", MsgBoxStyle.Critical, "Uyarı")
            lbl_ara.Refresh()
            txt_sAra.Text = ""
            txt_sAra.Focus()
            txt_sAra.SelectAll()
        End If
    End Sub
    Public Function sorgu_stok_kontrol(ByVal kod As String) As Int64
        Dim kriter
        Dim gelismis As String = kod
        Dim qgelismis As String = "Eşittir"
        'kriter = "WHERE (Stok.sKodu like  '" & kod & "%') or (Stok.sAciklama like  '" & kod & "%') or (Stok.sKisaAdi like  '" & kod & "%') or (Barcode.sBarkod like '" & kod & "%') "
        kriter = " Where (tbStok.skodu " & sorgu_kriter_string(gelismis, qgelismis) & ") OR  (tbStok.sAciklama " & sorgu_kriter_string(gelismis, qgelismis) & ") OR  (tbStok.sOzelNot " & sorgu_kriter_string(gelismis, qgelismis) & ")OR  (tbStok.sKisaAdi " & sorgu_kriter_string(gelismis, qgelismis) & ") OR tbStok.nStokID IN (Select nStokID from tbStokBarkodu where sBarkod " & sorgu_kriter_string(gelismis, qgelismis) & ")  OR (tbStok.sRenk " & sorgu_kriter_string(gelismis, qgelismis) & ") OR (tbStok.sBeden " & sorgu_kriter_string(gelismis, qgelismis) & ") "
        Dim con As New OleDb.OleDbConnection
        Dim cmd As New OleDb.OleDbCommand
        con.ConnectionString = connection
        cmd.CommandTimeout = False
        cmd.Connection = con
        If con.State = ConnectionState.Closed = True Then
            con.Open()
        End If
        cmd.CommandText = sorgu_query("SET DATEFORMAT DMY SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT     ISNULL(COUNT(*), 0) AS KAYIT FROM         tbStok INNER JOIN  tbStokBarkodu ON tbStok.nStokID = tbStokBarkodu.nStokID and tbStokBarkodu.nKisim = 0 " & kriter & "")
        Dim kayitsayisi = cmd.ExecuteScalar
        con.Close()
        con = Nothing
        cmd = Nothing
        Return kayitsayisi
    End Function
    Private Sub dataload_stok(ByVal kod As String)
        Dim kriter
        'kriter = "WHERE (tbStok.sKodu like '" & kod & "%') or (tbStok.sAciklama like '" & kod & "%') or (tbStok.sKisaAdi like  '" & kod & "%') or  (tbStokBarkodu.sBarkod like '" & kod & "%') "
        Dim gelismis As String = kod
        Dim qgelismis As String = "Eşittir"
        kriter = " Where (tbStok.skodu " & sorgu_kriter_string(gelismis, qgelismis) & ") OR  (tbStok.sAciklama " & sorgu_kriter_string(gelismis, qgelismis) & ") OR  (tbStok.sOzelNot " & sorgu_kriter_string(gelismis, qgelismis) & ")OR  (tbStok.sKisaAdi " & sorgu_kriter_string(gelismis, qgelismis) & ") OR tbStok.nStokID IN (Select nStokID from tbStokBarkodu where sBarkod " & sorgu_kriter_string(gelismis, qgelismis) & ")  OR (tbStok.sRenk " & sorgu_kriter_string(gelismis, qgelismis) & ") OR (tbStok.sBeden " & sorgu_kriter_string(gelismis, qgelismis) & ") "
        ds_stok = sorgu(sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT tbStok.*, tbStokBarkodu.sBarkod AS sBarkod, ISNULL((SELECT isnull(lfiyat , 0) FROM tbstokfiyati WHERE nStokId = tbStok.NstokId AND sFiyatTipi = '" & sFiyat1 & "'), 0) AS lFiyat1, ISNULL((SELECT isnull(lfiyat , 0) FROM tbstokfiyati WHERE nStokId = tbStok.NstokId AND sFiyatTipi = '" & sFiyat2 & "'), 0) AS lFiyat2, ISNULL((SELECT isnull(lfiyat , 0) FROM tbstokfiyati WHERE nStokId = tbStok.NstokId AND sFiyatTipi = '" & sFiyat3 & "'), 0) AS lFiyat3, ISNULL((SELECT isnull(lfiyat , 0) FROM tbstokfiyati WHERE nStokId = tbStok.NstokId AND sFiyatTipi = '" & sFiyatA & "'), 0) AS lAlis,ISNULL((SELECT isnull(lfiyat , 0) FROM tbstokfiyati WHERE nStokId = tbStok.NstokId AND sFiyatTipi = '" & sFiyatA & "'), 0) AS lMaliyet, (SELECT nKdvOrani FROM tbKdv WHERE sKdvTipi = tbStok.sKdvTipi) AS nKdvOrani, (SELECT sRenkAdi FROM tbRenk WHERE sRenk = tbStok.sRenk) AS sRenkAdi, CAST(0 AS Money) AS lMiktar FROM tbStok LEFT OUTER JOIN                       tbStokBarkodu ON tbStok.nStokID = tbStokBarkodu.nStokID AND tbStokBarkodu.nKisim = 0 " & kriter & " ORDER BY tbStok.sKodu"))
    End Sub
    Private Sub Stok_Envanter()
        If dataset1.Tables(0).Rows.Count > 0 Then
            Dim dr As DataRow = dataset1.Tables(0).Rows(0)
            Dim frm As New frm_stok_envanter
            frm.firmano = firmano
            frm.donemno = donemno
            frm.connection = connection
            frm.stokkodu = dr("sKodu")
            frm.lbl_sKodu.Text = dr("sKodu")
            frm.lbl_sAciklama.Text = dr("sAciklama")
            frm.ShowDialog()
            frm.Close()
            frm.Dispose()
            frm = Nothing
        End If
    End Sub
    Private Sub analiz_bekleyen()
        If dataset1.Tables(0).Rows.Count > 0 Then
            Dim dr As DataRow = dataset1.Tables(0).Rows(0)
            Dim frm As New frm_satis_bekleyen_onaysiz
            frm.firmano = firmano
            frm.donemno = donemno
            frm.connection = connection
            frm.stokkodu = dr("sKodu")
            frm.tarih1 = "01/01/1900"
            frm.tarih2 = "31/12/2048"
            frm.kullanici = kullanici
            frm.ShowDialog()
            dr = Nothing
            frm = Nothing
        End If
    End Sub
    Private Sub Stok_Fiyatlandir()
        If dataset1.Tables(0).Rows.Count > 0 Then
            Dim dr As DataRow = dataset1.Tables(0).Rows(0)
            Dim frm As New frm_stok_fiyatlandir
            frm.firmano = firmano
            frm.donemno = donemno
            frm.connection = connection
            frm.sModel = dr("sModel")
            frm.sRenk = dr("sRenk")
            frm.sBeden = dr("sBeden")
            frm.sKodu = dr("sKodu")
            If yetki_kontrol(kullanici, frm.Name) = True Then
                frm.ShowDialog()
            End If
            frm.Close()
            frm.Dispose()
            frm = Nothing
            txt_sAra.Text = dr("sBarkod")
            dr = Nothing
            ara()
        End If
    End Sub
    Private Sub raporla(ByVal nIslem As Integer, Optional ByVal bDirekt As Boolean = False, Optional ByVal bMiktarli As Integer = 1)
        Dim sFile = txt_sDosya.Text
        If Microsoft.VisualBasic.Right(sFile, 3) = "fr3" Then
            Dim kriter As String = ""
            If bDirekt = False Then
                kriter = satir_kontrol()
                report_create_stok(sFile, kriter, nIslem, sorgu_sayi(txt_nMiktar.EditValue * bMiktarli, 1), sorgu_sayi(txt_lFiyat1.EditValue, 0), sorgu_sayi(txt_lFiyat2.EditValue, 0), sorgu_sayi(txt_lFiyat3.EditValue, 0), sorgu_sayi(txt_lFiyat3.EditValue, 0), txt_sKodu.Text, txt_sModel.Text, txt_sAciklama.Text, txt_sBarkod.Text, txt_sRenk.Text, txt_sBeden.Text, sorgu_sayi(txt_nMiktar.EditValue * bMiktarli, 1))
            Else
                report_create_stok(sFile, " WHERE stok.nStokId =" & txt_nStokID.Text & "", nIslem, sorgu_sayi(txt_nMiktar.EditValue * bMiktarli, 1), sorgu_sayi(txt_lFiyat1.EditValue, 0), sorgu_sayi(txt_lFiyat2.EditValue, 0), sorgu_sayi(txt_lFiyat3.EditValue, 0), sorgu_sayi(txt_lFiyat4.EditValue, 0), txt_sKodu.Text, txt_sModel.Text, txt_sAciklama.Text, txt_sBarkod.Text, txt_sRenkAdi.Text, txt_sBeden.Text, sorgu_sayi(txt_nMiktar.EditValue * bMiktarli, 1))
            End If
            sFile = Nothing
            kriter = Nothing
        ElseIf Microsoft.VisualBasic.Right(sFile, 3) = "frx" Then
            Dim kriter As String = ""
            If bDirekt = False Then
                kriter = satir_kontrol()
                report_create(nIslem, sFile, kriter, sorgu_sayi(txt_nMiktar.EditValue * bMiktarli, 1))
            Else
                report_create(nIslem, sFile, " WHERE stok.nStokId =" & txt_nStokID.Text & "", sorgu_sayi(txt_nMiktar.EditValue * bMiktarli, 1))
            End If
            sFile = Nothing
            kriter = Nothing
        End If
    End Sub
    Private Function satir_kontrol() As String
        Dim satir As String = "WHERE stok.nStokId IN ( " & txt_nStokID.Text & ")"
        Return satir
    End Function
    Private Sub report_create_stok(ByVal dosya As String, ByVal kriter As String, ByVal status As Integer, ByVal miktar As Decimal, ByVal fiyat1 As Decimal, ByVal fiyat2 As Decimal, ByVal fiyat3 As Decimal, ByVal fiyat4 As Decimal, ByVal sKodu As String, ByVal sModel As String, ByVal sAciklama As String, ByVal sBarkod As String, ByVal sRenk As String, ByVal sBeden As String, ByVal lMiktar As String)
        Dim stokno = 0
        Dim satir_line = "100"
        If IntPtr.Size = 4 Then
            '32 Bit
            Dim frx As New FastReport.TfrxReport
            Dim qr_hareket As New FastReport.TfrxADOQuery
            frx.Resources.LoadLanguageResourcesFromFile("C:\Program Files\FastReports\FastReport Studio\bin\turkish.frc")
            frx.LoadReportFromFile(dosya)
            frx.SetVariable("FIRMANO", "" & firmano & "")
            frx.SetVariable("DONEMNO", "" & donemno & "")
            frx.SetVariable("STOKNO", "" & stokno & "")
            frx.SetVariable("SATIRLINE", "'" & satir_line & "'")
            frx.SetVariable("PESIN", "" & fiyat1 & "")
            frx.SetVariable("ALTIAY", "" & fiyat2 & "")
            frx.SetVariable("ONAY", "" & fiyat3 & "")
            frx.SetVariable("FIYAT1", "" & fiyat1 & "")
            frx.SetVariable("FIYAT2", "" & fiyat2 & "")
            frx.SetVariable("FIYAT3", "" & fiyat3 & "")
            frx.SetVariable("FIYAT4", "" & fiyat4 & "")
            frx.SetVariable("sKodu", "'" & sKodu & "'")
            frx.SetVariable("sAciklama", "'" & sAciklama & "'")
            frx.SetVariable("sBarkod", "'" & sBarkod & "'")
            frx.SetVariable("sRenk", "'" & sRenk & "'")
            frx.SetVariable("sBeden", "'" & sBeden & "'")
            frx.SetVariable("lMiktar", "" & lMiktar & "")
            frx.SetVariable("FIYAT", "'" & fiyat_gizle_tumu(FormatNumber(fiyat1, 2), FormatNumber(fiyat2, 2), FormatNumber(fiyat3, 2)) & "'")
            'frx.SetVariable("HD_PESIN_tl", "" & fiyat_gizle(FormatNumber(fiyat1, 2)).ToString & "")
            'frx.SetVariable("HD_ALTIAY_tl", "" & fiyat_gizle_tl(FormatNumber(fiyat2, 2)).ToString & "")
            'frx.SetVariable("HD_ONAY_tl", "" & fiyat_gizle_tl(FormatNumber(fiyat3, 2)).ToString & "")
            qr_hareket = frx.FindObject("qr_hareket")
            qr_hareket.Query = sorgu_query("set transaction isolation level read uncommitted SELECT 0 as sPartiNo,(SELECT isnull(lfiyat , 0) FROM tbstokfiyati WHERE nStokId = stok.NstokId AND sFiyatTipi = '" & sFiyat1 & "') AS PESIN, (SELECT isnull(lfiyat , 0) FROM tbstokfiyati WHERE nStokId = stok.NstokId AND sFiyatTipi = '" & sFiyat3 & "') AS ONAY, (SELECT isnull(lfiyat , 0) FROM tbstokfiyati WHERE nStokId = stok.NstokId AND sFiyatTipi = '" & sFiyat2 & "') AS ALTIAY,(SELECT isnull(lfiyat , 0) FROM tbstokfiyati WHERE nStokId = stok.NstokId AND sFiyatTipi = '" & sFiyat4 & "') AS FIYAT4, ISNULL((SELECT ISNULL(lOran , 1) FROM tbStokBirimCevrimi WHERE nStokID = Stok.nStokID AND sBirimCinsi = Stok.sBirimCinsi2), 1) AS lBirimCarpan,barkod.sBarkod, stok.nStokID,stok.sKisaAdi,stok.sKodu AS STOKKODU, stok.sAciklama AS STOKADI, stok.sRenk, stok.sBeden, stok.sKavala,stok.lAsgariMiktar, stok.lAzamiMiktar, stok.sModel, tbRenk.sRenkAdi, stok.nEn, stok.nBoy, stok.nYukseklik, stok.nHacim, stok.nAgirlik,(SELECT     nKdvOrani FROM         tbKdv Where sKdvTipi = Stok.sKdvTipi) as nKdvOrani,stok.sBirimCinsi1,stok.sBirimCinsi2,tbSSinif1.sAciklama AS SINIF1, tbSSinif2.sAciklama AS SINIF2, tbSSinif3.sAciklama AS SINIF3, tbSSinif4.sAciklama AS SINIF4, tbSSinif5.sAciklama AS SINIF5, tbSSinif6.sAciklama AS SINIF6, tbSSinif7.sAciklama AS SINIF7, tbSSinif8.sAciklama AS SINIF8, tbSSinif9.sAciklama AS SINIF9, tbSSinif10.sAciklama AS SINIF10 FROM tbStok stok INNER JOIN tbStokBarkodu barkod ON stok.nStokID = barkod.nStokID and barkod.nKisim = 0 INNER JOIN tbStokSinifi ON stok.nStokID = tbStokSinifi.nStokID INNER JOIN tbSSinif1 ON tbStokSinifi.sSinifKodu1 = tbSSinif1.sSinifKodu INNER JOIN tbSSinif2 ON tbStokSinifi.sSinifKodu2 = tbSSinif2.sSinifKodu INNER JOIN tbSSinif3 ON tbStokSinifi.sSinifKodu3 = tbSSinif3.sSinifKodu INNER JOIN tbSSinif4 ON tbStokSinifi.sSinifKodu4 = tbSSinif4.sSinifKodu INNER JOIN tbSSinif5 ON tbStokSinifi.sSinifKodu5 = tbSSinif5.sSinifKodu INNER JOIN tbSSinif6 ON tbStokSinifi.sSinifKodu6 = tbSSinif6.sSinifKodu INNER JOIN tbSSinif7 ON tbStokSinifi.sSinifKodu7 = tbSSinif7.sSinifKodu INNER JOIN tbSSinif8 ON tbStokSinifi.sSinifKodu8 = tbSSinif8.sSinifKodu INNER JOIN tbSSinif9 ON tbStokSinifi.sSinifKodu9 = tbSSinif9.sSinifKodu INNER JOIN tbSSinif10 ON tbStokSinifi.sSinifKodu10 = tbSSinif10.sSinifKodu LEFT OUTER JOIN tbRenk ON stok.sRenk = tbRenk.sRenk " & kriter & " ")
            Dim qr_connection As New FastReport.TfrxADODatabase
            qr_connection.ConnectionString = connection.ToString
            qr_connection.LoginPrompt = False
            qr_connection.CommandTimeout = Nothing
            qr_connection.Connected = True
            qr_hareket.DataBase = qr_connection
            frx.PrintOptions.Collate = False
            If sec_sPrint.Checked = True Then
                frx.PrintOptions.Printer = sPrint
            Else
            End If
            If status = 0 Then
                frx.PrepareReport(True)
                frx.ShowReport()
            ElseIf status = 1 Then
                frx.PrepareReport(True)
                frx.PrintOptions.Collate = False
                frx.PrintOptions.Copies = miktar
                frx.PrintReport()
            ElseIf status = 2 Then
                frx.PrepareReport(True)
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
            args(2) = "" & sorgu_query("set transaction isolation level read uncommitted SELECT 0 as sPartiNo,(SELECT isnull(lfiyat , 0) FROM tbstokfiyati WHERE nStokId = stok.NstokId AND sFiyatTipi = '" & sFiyat1 & "') AS PESIN, (SELECT isnull(lfiyat , 0) FROM tbstokfiyati WHERE nStokId = stok.NstokId AND sFiyatTipi = '" & sFiyat3 & "') AS ONAY, (SELECT isnull(lfiyat , 0) FROM tbstokfiyati WHERE nStokId = stok.NstokId AND sFiyatTipi = '" & sFiyat2 & "') AS ALTIAY,(SELECT isnull(lfiyat , 0) FROM tbstokfiyati WHERE nStokId = stok.NstokId AND sFiyatTipi = '" & sFiyat4 & "') AS FIYAT4, ISNULL((SELECT ISNULL(lOran , 1) FROM tbStokBirimCevrimi WHERE nStokID = Stok.nStokID AND sBirimCinsi = Stok.sBirimCinsi2), 1) AS lBirimCarpan,barkod.sBarkod, stok.nStokID,stok.sKisaAdi,stok.sKodu AS STOKKODU, stok.sAciklama AS STOKADI, stok.sRenk, stok.sBeden, stok.sKavala,stok.lAsgariMiktar, stok.lAzamiMiktar, stok.sModel, tbRenk.sRenkAdi, stok.nEn, stok.nBoy, stok.nYukseklik, stok.nHacim, stok.nAgirlik,(SELECT     nKdvOrani FROM         tbKdv Where sKdvTipi = Stok.sKdvTipi) as nKdvOrani,stok.sBirimCinsi1,stok.sBirimCinsi2,tbSSinif1.sAciklama AS SINIF1, tbSSinif2.sAciklama AS SINIF2, tbSSinif3.sAciklama AS SINIF3, tbSSinif4.sAciklama AS SINIF4, tbSSinif5.sAciklama AS SINIF5, tbSSinif6.sAciklama AS SINIF6, tbSSinif7.sAciklama AS SINIF7, tbSSinif8.sAciklama AS SINIF8, tbSSinif9.sAciklama AS SINIF9, tbSSinif10.sAciklama AS SINIF10 FROM tbStok stok INNER JOIN tbStokBarkodu barkod ON stok.nStokID = barkod.nStokID and barkod.nKisim = 0 INNER JOIN tbStokSinifi ON stok.nStokID = tbStokSinifi.nStokID INNER JOIN tbSSinif1 ON tbStokSinifi.sSinifKodu1 = tbSSinif1.sSinifKodu INNER JOIN tbSSinif2 ON tbStokSinifi.sSinifKodu2 = tbSSinif2.sSinifKodu INNER JOIN tbSSinif3 ON tbStokSinifi.sSinifKodu3 = tbSSinif3.sSinifKodu INNER JOIN tbSSinif4 ON tbStokSinifi.sSinifKodu4 = tbSSinif4.sSinifKodu INNER JOIN tbSSinif5 ON tbStokSinifi.sSinifKodu5 = tbSSinif5.sSinifKodu INNER JOIN tbSSinif6 ON tbStokSinifi.sSinifKodu6 = tbSSinif6.sSinifKodu INNER JOIN tbSSinif7 ON tbStokSinifi.sSinifKodu7 = tbSSinif7.sSinifKodu INNER JOIN tbSSinif8 ON tbStokSinifi.sSinifKodu8 = tbSSinif8.sSinifKodu INNER JOIN tbSSinif9 ON tbStokSinifi.sSinifKodu9 = tbSSinif9.sSinifKodu INNER JOIN tbSSinif10 ON tbStokSinifi.sSinifKodu10 = tbSSinif10.sSinifKodu LEFT OUTER JOIN tbRenk ON stok.sRenk = tbRenk.sRenk " & kriter & " ") & ""
            args(3) = "qr_hareket"
            args(4) = "" & status.ToString() & ""
            args(5) = "18"
            args(6) = "FIRMANO"
            args(7) = "" & firmano.ToString() & ""
            args(8) = "DONEMNO"
            args(9) = "" & donemno.ToString() & ""
            args(10) = "STOKNO"
            args(11) = "" & stokno.ToString() & ""
            args(12) = "SATIRLINE"
            args(13) = "'" & satir_line.ToString() & "'"
            args(14) = "PESIN"
            args(15) = "" & fiyat1.ToString() & ""
            args(16) = "ALTIAY"
            args(17) = "" & fiyat2.ToString() & ""
            args(18) = "ONAY"
            args(19) = "" & fiyat3.ToString() & ""
            args(20) = "FIYAT1"
            args(21) = "" & fiyat1.ToString() & ""
            args(22) = "FIYAT2"
            args(23) = "" & fiyat2.ToString() & ""
            args(24) = "FIYAT3"
            args(25) = "" & fiyat3.ToString() & ""
            args(26) = "FIYAT4"
            args(27) = "" & fiyat4.ToString() & ""
            args(28) = "sKodu"
            args(29) = "'" & sKodu.ToString() & "'"
            args(30) = "sAciklama"
            args(31) = "'" & sAciklama.ToString() & "'"
            args(32) = "sBarkod"
            args(33) = "'" & sBarkod.ToString() & "'"
            args(34) = "sRenk"
            args(35) = "'" & sRenk.ToString() & "'"
            args(36) = "sBeden"
            args(37) = "'" & sBeden.ToString() & "'"
            args(38) = "lMiktar"
            args(39) = "" & lMiktar.ToString() & ""
            args(40) = "FIYAT"
            args(41) = "'" & fiyat_gizle_tumu(FormatNumber(fiyat1, 2), FormatNumber(fiyat2, 2), FormatNumber(fiyat3, 2)).ToString() & "'"
            processYol = args(0)
            For i As Integer = 1 To 41
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
    Private Sub report_create(ByVal nIslem As Integer, ByVal sFile As String, ByVal kriter As String, Optional ByVal bMiktarli As Integer = 1)
        Dim report As New FastReport.Report
        report.Load(sFile)
        Dim ds_etiket As DataSet
        'ds_etiket = sorgu(sorgu_query("set transaction isolation level read uncommitted SELECT (SELECT isnull(lfiyat , 0) FROM tbstokfiyati WHERE nStokId = stok.NstokId AND sFiyatTipi = '" & sFiyat1 & "') AS PESIN, (SELECT isnull(lfiyat , 0) FROM tbstokfiyati WHERE nStokId = stok.NstokId AND sFiyatTipi = '" & sFiyat3 & "') AS ONAY, (SELECT isnull(lfiyat , 0) FROM tbstokfiyati WHERE nStokId = stok.NstokId AND sFiyatTipi = '" & sFiyat2 & "') AS ALTIAY,(SELECT isnull(lfiyat , 0) FROM tbstokfiyati WHERE nStokId = stok.NstokId AND sFiyatTipi = '" & sFiyat2 & "') AS FIYAT4, barkod.sBarkod, stok.nStokID,stok.sKisaAdi,stok.sKodu AS STOKKODU, stok.sAciklama AS STOKADI, stok.sRenk, stok.sBeden, stok.sKavala,stok.nEn, stok.nBoy, stok.nYukseklik, stok.nHacim, stok.nAgirlik,stok.lAsgariMiktar, stok.lAzamiMiktar, stok.sModel, tbRenk.sRenkAdi, tbSSinif1.sAciklama AS SINIF1, tbSSinif2.sAciklama AS SINIF2, tbSSinif3.sAciklama AS SINIF3, tbSSinif4.sAciklama AS SINIF4, tbSSinif5.sAciklama AS SINIF5, tbSSinif6.sAciklama AS SINIF6, tbSSinif7.sAciklama AS SINIF7, tbSSinif8.sAciklama AS SINIF8, tbSSinif9.sAciklama AS SINIF9, tbSSinif10.sAciklama AS SINIF10 FROM tbStok stok INNER JOIN tbStokBarkodu barkod ON stok.nStokID = barkod.nStokID and barkod.nKisim = 0 INNER JOIN tbStokSinifi ON stok.nStokID = tbStokSinifi.nStokID INNER JOIN tbSSinif1 ON tbStokSinifi.sSinifKodu1 = tbSSinif1.sSinifKodu INNER JOIN tbSSinif2 ON tbStokSinifi.sSinifKodu2 = tbSSinif2.sSinifKodu INNER JOIN tbSSinif3 ON tbStokSinifi.sSinifKodu3 = tbSSinif3.sSinifKodu INNER JOIN tbSSinif4 ON tbStokSinifi.sSinifKodu4 = tbSSinif4.sSinifKodu INNER JOIN tbSSinif5 ON tbStokSinifi.sSinifKodu5 = tbSSinif5.sSinifKodu INNER JOIN tbSSinif6 ON tbStokSinifi.sSinifKodu6 = tbSSinif6.sSinifKodu INNER JOIN tbSSinif7 ON tbStokSinifi.sSinifKodu7 = tbSSinif7.sSinifKodu INNER JOIN tbSSinif8 ON tbStokSinifi.sSinifKodu8 = tbSSinif8.sSinifKodu INNER JOIN tbSSinif9 ON tbStokSinifi.sSinifKodu9 = tbSSinif9.sSinifKodu INNER JOIN tbSSinif10 ON tbStokSinifi.sSinifKodu10 = tbSSinif10.sSinifKodu LEFT OUTER JOIN tbRenk ON stok.sRenk = tbRenk.sRenk " & kriter & " "), "Etiket")
        ds_etiket = sorgu(sorgu_query("set transaction isolation level read uncommitted SELECT 0 as sPartiNo,(SELECT isnull(lfiyat , 0) FROM tbstokfiyati WHERE nStokId = stok.NstokId AND sFiyatTipi = '" & sFiyat1 & "') AS PESIN, (SELECT isnull(lfiyat , 0) FROM tbstokfiyati WHERE nStokId = stok.NstokId AND sFiyatTipi = '" & sFiyat3 & "') AS ONAY, (SELECT isnull(lfiyat , 0) FROM tbstokfiyati WHERE nStokId = stok.NstokId AND sFiyatTipi = '" & sFiyat2 & "') AS ALTIAY,(SELECT isnull(lfiyat , 0) FROM tbstokfiyati WHERE nStokId = stok.NstokId AND sFiyatTipi = '" & sFiyat2 & "') AS FIYAT4, barkod.sBarkod, stok.nStokID,stok.sKisaAdi,stok.sKodu AS STOKKODU, stok.sAciklama AS STOKADI, stok.sRenk, stok.sBeden, stok.sKavala,stok.nEn, stok.nBoy, stok.nYukseklik, stok.nHacim, stok.nAgirlik,(SELECT     nKdvOrani FROM         tbKdv Where sKdvTipi = Stok.sKdvTipi) as nKdvOrani,stok.sBirimCinsi1,stok.sBirimCinsi2,stok.lAsgariMiktar, stok.lAzamiMiktar, stok.sModel, tbRenk.sRenkAdi, tbSSinif1.sAciklama AS SINIF1, tbSSinif2.sAciklama AS SINIF2, tbSSinif3.sAciklama AS SINIF3, tbSSinif4.sAciklama AS SINIF4, tbSSinif5.sAciklama AS SINIF5, tbSSinif6.sAciklama AS SINIF6, tbSSinif7.sAciklama AS SINIF7, tbSSinif8.sAciklama AS SINIF8, tbSSinif9.sAciklama AS SINIF9, tbSSinif10.sAciklama AS SINIF10 FROM tbStok stok INNER JOIN tbStokBarkodu barkod ON stok.nStokID = barkod.nStokID and barkod.nKisim = 0 INNER JOIN tbStokSinifi ON stok.nStokID = tbStokSinifi.nStokID INNER JOIN tbSSinif1 ON tbStokSinifi.sSinifKodu1 = tbSSinif1.sSinifKodu INNER JOIN tbSSinif2 ON tbStokSinifi.sSinifKodu2 = tbSSinif2.sSinifKodu INNER JOIN tbSSinif3 ON tbStokSinifi.sSinifKodu3 = tbSSinif3.sSinifKodu INNER JOIN tbSSinif4 ON tbStokSinifi.sSinifKodu4 = tbSSinif4.sSinifKodu INNER JOIN tbSSinif5 ON tbStokSinifi.sSinifKodu5 = tbSSinif5.sSinifKodu INNER JOIN tbSSinif6 ON tbStokSinifi.sSinifKodu6 = tbSSinif6.sSinifKodu INNER JOIN tbSSinif7 ON tbStokSinifi.sSinifKodu7 = tbSSinif7.sSinifKodu INNER JOIN tbSSinif8 ON tbStokSinifi.sSinifKodu8 = tbSSinif8.sSinifKodu INNER JOIN tbSSinif9 ON tbStokSinifi.sSinifKodu9 = tbSSinif9.sSinifKodu INNER JOIN tbSSinif10 ON tbStokSinifi.sSinifKodu10 = tbSSinif10.sSinifKodu LEFT OUTER JOIN tbRenk ON stok.sRenk = tbRenk.sRenk " & kriter & " "), "Etiket")
        report.RegisterData(ds_etiket)
        report.RegisterData(ds_tbParamGenel)
        report.ScriptLanguage = FastReport.Language.Vb
        report.PrintSettings.Collate = False
        If sec_sPrint.Checked = True Then
            report.PrintSettings.Printer = sPrint
        Else
        End If
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
    Private Sub btn_Ara_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Ara.Click
        If txt_sAra.Text = "" Then
            satir_ekle_stok("")
        Else
            ara()
        End If
    End Sub
    Private Sub txt_sDosya_ButtonPressed(ByVal sender As Object, ByVal e As DevExpress.XtraEditors.Controls.ButtonPressedEventArgs) Handles txt_sDosya.ButtonPressed
        dosya_ara()
    End Sub
    Private Sub txt_sDosya_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txt_sDosya.KeyDown
        If e.KeyCode = Keys.F4 Then
            dosya_ara()
        End If
    End Sub
    Private Sub dosya_ara()
        Dim OpenFileDialog1 As New Windows.Forms.OpenFileDialog
        OpenFileDialog1.Title = "Rapor Seç..."
        OpenFileDialog1.Filter = "Rapor Dosyaları (*.fr*) |*.fr*"
        OpenFileDialog1.FileName = "c:\Formlar\Etiket\Etiket" & sRaporUzanti & ""
        OpenFileDialog1.InitialDirectory = "c:\Formlar\Etiket"
        If OpenFileDialog1.ShowDialog = Windows.Forms.DialogResult.OK Then
            txt_sDosya.Text = OpenFileDialog1.FileName.ToString
        End If
    End Sub
    Private Sub SimpleButton3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SimpleButton3.Click
        raporla(1)
    End Sub
End Class