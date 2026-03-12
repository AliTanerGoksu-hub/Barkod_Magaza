Imports Microsoft.Win32
Imports DevExpress.XtraEditors
Public Class frm_fatura_depo
    Public firmano
    Public donemno
    Public connection
    Public sConnection As String
    Public musterino
    Public kullanici
    Public kasiyer As String = ""
    Public nFirmaID As Int64 = 0
    Public sKodu As String = ""
    Public bLogo As Boolean = False
    Dim ds_tbFisTipi As DataSet
    Dim ds_tbGirisCikis As DataSet
    Dim ds_cari As DataSet
    Dim ds_tbDepo As DataSet
    Dim ds_tbTDepo As DataSet
    Public sFisTipi As String = ""
    Public nGirisCikis As Int64 = 1
    Public bSiparis As Boolean = False
    Public bSatisYapilamaz As Boolean = False
    Public bAktar As Boolean = False
    Dim status As Boolean = False
    Public kapla As Boolean = False
    Private Sub frm_fatura_kopyala_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        If bAktar = False Then
            dataload_tbFisTipi()
            dataload_tbGirisCikis(nGirisCikis)
            sec_sFisTipi.EditValue = sFisTipi
            sec_nGirisCikis.EditValue = nGirisCikis.ToString
            If kapla = True Then
                sec_sFisTipi.Enabled = True
                sec_nGirisCikis.Enabled = True
            End If
            SimpleButton1.Enabled = True
        End If
        Try
            gorunum_yukle()
        Catch ex As Exception
        End Try
        dataload_tbdepo()
        dataload_tbTdepo(sDepo)
        txt_sTeslimEden.Text = Trim(kasiyer)
    End Sub
    Private Sub gorunum_yukle()
        Label1.Text = Sorgu_sDil(Label1.Text, sDil)
        LabelControl1.Text = Sorgu_sDil(LabelControl1.Text, sDil)
        LabelControl2.Text = Sorgu_sDil(LabelControl2.Text, sDil)
        LabelControl3.Text = Sorgu_sDil(LabelControl3.Text, sDil)
        LabelControl4.Text = Sorgu_sDil(LabelControl4.Text, sDil)
        SimpleButton1.Text = Sorgu_sDil(SimpleButton1.Text, sDil)
        SimpleButton2.Text = Sorgu_sDil(SimpleButton2.Text, sDil)
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
    Private Function sorgu_query(ByVal query As String) As String
        query = Replace(query, "*!F", "F0" + firmano.ToString)
        query = Replace(query, "!D", "D000" + donemno.ToString)
        Return query
    End Function
    Private Sub dataload_tbdepo()
        ds_tbDepo = sorgu(sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT     sDepo,sAciklama,nFirmaID FROM         tbDepo Where sDepo <> ''"))
        sec_sDepo.Properties.DataSource = ds_tbDepo.Tables(0)
        sec_sDepo.Text = sDepo
        'If Trim(sDepo) <> "D001" Then
        '    sec_sDepo.Text = sDepo
        '    'sec_sDepo.Properties.ReadOnly = True
        'Else
        '    If kullanici > 3 Then
        '        sec_sDepo.Text = sDepo
        '        sec_sDepo.Properties.ReadOnly = False
        '    Else
        '        'sec_sDepo.EditValue = sDepo
        '        sec_sDepo.Properties.ReadOnly = False
        '    End If
        '    'sec_sDepo.EditValue = sDepo
        '    'sec_sDepo.Properties.ReadOnly = False
        'End If
        'sec_sDepo.ItemIndex = 1
    End Sub
    Private Sub dataload_tbTdepo(ByVal sDepo As String)
        ds_tbTDepo = sorgu(sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT     sDepo,sAciklama,nFirmaID FROM         tbDepo Where sDepo <> '" & sDepo & "' and sDepo <> '' "))
        sec_sTDepo.Properties.DataSource = ds_tbTDepo.Tables(0)
        sec_sTDepo.ItemIndex = 0
    End Sub
    Private Sub dataload_tbFisTipi()
        If bSiparis = True Then
            ds_tbFisTipi = sorgu(sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT     nSiparisTipi as sFisTipi,sAciklama FROM         tbSiparisTipi Where nSiparisTipi IN (1,2,3)"))
        Else
            ds_tbFisTipi = sorgu(sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT     sFisTipi,sAciklama FROM         tbFisTipi Where sFisTipi IN ('T')"))
        End If
        sec_sFisTipi.Properties.DataSource = ds_tbFisTipi.Tables(0)
        'sec_sFisTipi.EditValue = sFisTipi
        sec_sFisTipi.ItemIndex = 0
    End Sub
    Private Sub dataload_tbGirisCikis(ByVal nGirisCikis As Int64)
        If kapla = False Then
            ds_tbGirisCikis = sorgu(sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT     nGirisCikis,sAciklama FROM         tbGirisCikis Where nGirisCikis = '" & nGirisCikis & "'"))
            sec_nGirisCikis.Properties.DataSource = ds_tbGirisCikis.Tables(0)
            sec_nGirisCikis.ItemIndex = 0
        ElseIf kapla = True Then
            If bSiparis = False Then
                If sec_sFisTipi.EditValue = "FS " Or sec_sFisTipi.EditValue = "HS " Or sec_sFisTipi.EditValue = "DC " Or sec_sFisTipi.EditValue = "IS " Then
                    ds_tbGirisCikis = sorgu(sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT     nGirisCikis,sAciklama FROM         tbGirisCikis Where nGirisCikis IN (3,4)"))
                ElseIf sec_sFisTipi.EditValue = "FA " Or sec_sFisTipi.EditValue = "HA " Or sec_sFisTipi.EditValue = "DG " Or sec_sFisTipi.EditValue = "IA " Then
                    ds_tbGirisCikis = sorgu(sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT     nGirisCikis,sAciklama FROM         tbGirisCikis Where nGirisCikis IN (1,2)"))
                End If
            Else
                ds_tbGirisCikis = sorgu(sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT     nGirisCikis,sAciklama FROM         tbGirisCikis Where nGirisCikis IN (1,3)"))
            End If
            sec_nGirisCikis.Properties.DataSource = ds_tbGirisCikis.Tables(0)
            sec_nGirisCikis.EditValue = nGirisCikis
            sec_nGirisCikis.ItemIndex = 0
        End If
    End Sub
    Private Sub firma_sec(Optional ByVal islem As Integer = 0)
        Dim frm As New frm_firma_liste
        frm.firmano = firmano
        frm.donemno = donemno
        frm.connection = connection
        frm.islemstatus = True
        frm.kullanici = kullanici
        frm.nGirisCikis = sec_nGirisCikis.EditValue
        frm.bFis = True
        frm.sModul = "Fatura"
        If frm.ShowDialog(Me) = Windows.Forms.DialogResult.OK Then
            Dim dr1 As DataRow
            dr1 = frm.GridView1.GetDataRow(frm.GridView1.FocusedRowHandle)
            nFirmaID = dr1("nFirmaID")
            sKodu = dr1("sKodu")
            'lbl_Firma.Text = dr1("sAciklama")
            bSatisYapilamaz = dr1("bSatisYapilamaz")
            txt_sTeslimEden.EditValue = sKodu
            musteri_kontrol()
            dr1 = Nothing
        End If
    End Sub
    Private Sub musteri_kontrol()
        If Trim(txt_sTeslimEden.EditValue).ToString <> "" Then
            Dim kontrol = sorgu_cari_kontrol(txt_sTeslimEden.EditValue)
            If kontrol = 0 Then
                XtraMessageBox.Show(Sorgu_sDil("Kayıt Bulunumadı...", sDil), Sorgu_sDil("Dikkat", sDil), MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            ElseIf kontrol = 1 Then
                dataload_cari(txt_sTeslimEden.EditValue)
                Dim dr As DataRow
                For Each dr In ds_cari.Tables(0).Rows
                    'txt_Musteri.EditValue = dr("MUSTERI")
                    sKodu = dr("sKodu")
                    nFirmaID = dr("nFirmaID")
                    'lbl_Firma.Text = dr("sAciklama")
                Next
                dr = Nothing
            End If
        End If
    End Sub
    Public Function sorgu_cari_kontrol(ByVal kod As String) As Int64
        Dim kriter
        If bLogo = False Then
            kriter = "WHERE (sKodu = '" & kod & "') "
        ElseIf bLogo = True Then
            kriter = "WHERE (sKodu = '" & kod & "') "
        End If
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
    Public Function sorgu_fis_kontrol(ByVal sFistipi As String, ByVal nGirisCikis As String, ByVal dteFisTarihi As DateTime, ByVal lFisno As String, ByVal nFirmaID As String, Optional ByVal resmi As Boolean = True, Optional ByVal sDatabase As String = "") As Int64
        Dim use As String = ""
        If sDatabase <> "" Then
            use = "USE " & sDatabase
        End If
        Dim kriter
        kriter = "WHERE (sFisTipi = '" & sFistipi & "') and (dteFisTarihi = '" & dteFisTarihi & "') and (lFisNo = '" & lFisno & "') and (nFirmaID= '" & nFirmaID & "') and (nGirisCikis = '" & nGirisCikis & "')  "
        Dim conn As New OleDb.OleDbConnection
        Dim cmd As New OleDb.OleDbCommand
        Dim adapter As New OleDb.OleDbDataAdapter
        'MsgBox(connection_resmi)
        conn.ConnectionString = connection
        cmd.Connection = conn
        conn.Open()
        cmd.CommandText = sorgu_query("" & use & " SET DATEFORMAT DMY SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT     ISNULL(nStokFisiID, 0) AS KAYIT FROM         tbStokFisiMaster " & kriter & "")
        Dim kayitsayisi = cmd.ExecuteScalar
        conn.Close()
        cmd = Nothing
        conn = Nothing
        adapter = Nothing
        Return kayitsayisi
        cmd = Nothing
        conn = Nothing
    End Function
    Private Sub txt_musteriNo_ButtonClick(ByVal sender As Object, ByVal e As DevExpress.XtraEditors.Controls.ButtonPressedEventArgs) Handles txt_sTeslimEden.ButtonClick
        firma_sec()
    End Sub
    Private Sub txt_musteriNo_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txt_sTeslimEden.KeyDown
        If e.KeyCode = Keys.F3 Then
            firma_sec()
        ElseIf e.KeyCode = Keys.Enter Then
            If Trim(txt_sTeslimEden.Text) = "" Then
                firma_sec()
            End If
        End If
    End Sub
    Private Sub sec_sFisTipi_EditValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles sec_sFisTipi.EditValueChanged
        dataload_tbGirisCikis(3)
    End Sub
    Private Sub SimpleButton2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SimpleButton2.Click
        Me.Close()
    End Sub
    Private Sub SimpleButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SimpleButton1.Click
        If sec_sDepo.Text = sec_sTDepo.Text Then
            XtraMessageBox.Show(Sorgu_sDil("Çıkış Deposu ile Giriş Deposu Aynı Olamaz..!", sDil), Sorgu_sDil("Dikkat", sDil), MessageBoxButtons.OK, MessageBoxIcon.Warning)
        Else
            If XtraMessageBox.Show(Sorgu_sDil("Çıkış Deposu: ", sDil) & vbTab & "[" & sec_sDepo.Text & "]" & vbCrLf & Sorgu_sDil("Giriş Deposu: ", sDil) & vbTab & "[" & sec_sTDepo.Text & "]" & vbCrLf & Sorgu_sDil("Tranfer Fişi Düzenlemek İstediğinize Emin misiniz...?", sDil), Sorgu_sDil("Dikkat", sDil), MessageBoxButtons.YesNo, MessageBoxIcon.Question) = MsgBoxResult.Yes Then
                tbStokFisi()
            End If
        End If
    End Sub
    Private Sub tbStokFisi()
        Dim nStokFisiID As Int64
        Dim lFisNo As Int64 = 0
        lFisNo = sorgu_lFisNo(sec_sDepo.EditValue, sec_sFisTipi.EditValue, 3, sec_sDepo.Text)
        'sHareketTipi = sorgu_sHareketTipi()
        'Çıkış
        nStokFisiID = tbStokFisiMaster_kaydet_yeni(sec_sFisTipi.EditValue, txt_dteFisTarihi1.EditValue, 3, lFisNo, sec_sTDepo.EditValue, sec_sDepo.Text, DateAdd(DateInterval.Day, 0, txt_dteFisTarihi1.EditValue), 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, "", "", "", "", "", sHareketTipi, 0, 0, nStokFisiID + 1, sec_sDepo.EditValue, sec_sTDepo.Text, 0, kullanici, Now, "", 0, 0, 0, 0, 0, 0, 0)
        tbStokFisiAciklamasi_kaydet_yeni(nStokFisiID, txt_sTeslimEden.Text, txt_sTeslimAlan.Text, "", "", "")
        tbStokFisiMaster_lFisno_degistir(nStokFisiID)
        'Giriş
        nStokFisiID = tbStokFisiMaster_kaydet_yeni(sec_sFisTipi.EditValue, txt_dteFisTarihi1.EditValue, 1, lFisNo, sec_sDepo.EditValue, sec_sTDepo.Text, DateAdd(DateInterval.Day, 0, txt_dteFisTarihi1.EditValue), 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, "", "", "", "", "", sHareketTipi, 0, 0, nStokFisiID, sec_sTDepo.EditValue, sec_sDepo.Text, 0, kullanici, Now, "", 0, 0, 0, 0, 0, 0, 0, True)
        'nStokFisiID = tbStokFisiMaster_kaydet_yeni(sec_sFisTipi.EditValue, txt_dteFisTarihi1.EditValue, 3, lFisNo, sec_sDepo.EditValue, sec_sTDepo.Text, DateAdd(DateInterval.Day, 0, txt_dteFisTarihi1.EditValue), 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, "", "", "", "", "", sHareketTipi, 0, 0, nStokFisiID, sec_sTDepo.EditValue, sec_sDepo.Text, 0, kullanici, Now, "", 0, 0, 0, 0, 0, 0, 0, True)
        tbStokFisiAciklamasi_kaydet_yeni(nStokFisiID, txt_sTeslimEden.Text, txt_sTeslimAlan.Text, "", "", "")
        tbStokFisiMaster_lFisno_degistir(nStokFisiID)
        fis_duzelt(lFisNo, txt_dteFisTarihi1.EditValue, sec_sFisTipi.EditValue, sec_sTDepo.EditValue, sec_nGirisCikis.EditValue, nStokFisiID)
    End Sub
    Private Sub fis_duzelt(ByVal lFisNo As Int64, ByVal dteFisTarihi As DateTime, ByVal sFisTipi As String, ByVal nFirmaID As Int64, ByVal nGirisCikis As Integer, ByVal nStokFisiID As Int64)
        Dim frm As New frm_fatura
        frm.firmano = firmano
        frm.donemno = donemno
        frm.connection = connection
        frm.lFisNo = lFisNo
        frm.dteFisTarihi = dteFisTarihi
        frm.sFisTipi = sFisTipi
        frm.nFirmaID = nFirmaID
        frm.nGirisCikis = nGirisCikis
        frm.nStokFisiID = nStokFisiID
        frm.kullanici = kullanici
        If yetki_kontrol(kullanici, frm.Name) = True Then
            Try
                Me.Hide()
                frm.Show()
            Catch ex As Exception
            End Try
        End If
    End Sub
    Public Function sorgu_nStokFisiID() As Int64
        Dim kriter As String = ""
        Dim con As New OleDb.OleDbConnection
        Dim cmd As New OleDb.OleDbCommand
        Dim adapter As New OleDb.OleDbDataAdapter
        con.ConnectionString = connection
        cmd.CommandTimeout = Nothing
        cmd.Connection = con
        con.Open()
        cmd.CommandText = sorgu_query("SET DATEFORMAT DMY SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT ISNULL(MAX(nStokFisiID), 1) + 1 AS nStokFisiID FROM tbStokFisiMaster")
        Dim kayitsayisi = cmd.ExecuteScalar
        Return kayitsayisi
        con.Dispose()
        cmd.Dispose()
        adapter.Dispose()
        cmd = Nothing
    End Function
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
                cmd.CommandText = sorgu_query("SET DATEFORMAT DMY SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT      ISNULL(MAX(lFisNo), 0) + 1 AS lFisNo FROM         tbStokFisiMaster  Where sFisTipi = '" & sFisTipi & "'  AND nStokFisiID IN (Select TOP 3 nStokFisiID from tbStokFisiMaster Where sFisTipi ='" & sFisTipi & "' and nFirmaID = " & nFirmaID & " and nGirisCikis =" & nGirisCikis & " Order by dteFisTarihi DESC)")
            ElseIf nGirisCikis = 3 Then
                Dim nCiktiSatirSayisi As Integer = 25
                If bKendiFisNo = True Then
                    If Trim(sFisTipi) = "FS" Then
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
                    ElseIf Trim(sFisTipi) = "IS" Then
                        nCiktiSatirSayisi = nIrsaliyeCiktiSatirSayisi
                        cmd.CommandText = sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT     ISNULL(lToptanIrsaliye1,0) + 1 AS lFisNo FROM         tbStokFisNolar WHERE     (sDepo = '" & sDepo & "')")
                    ElseIf Trim(sFisTipi) = "DC" Then
                        nCiktiSatirSayisi = nStokFisiCiktiSatirSayisi
                        cmd.CommandText = sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT     ISNULL(lSevkFaturasi1,0) + 1 AS lFisNo FROM         tbStokFisNolar WHERE     (sDepo = '" & sDepo & "')")
                    ElseIf Trim(sFisTipi) = "HS" Then
                        nCiktiSatirSayisi = nFaturaCiktiSatirSayisi
                        cmd.CommandText = sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT     ISNULL(lToptanFatura1,0) + 1 AS lFisNo FROM         tbStokFisNolar WHERE     (sDepo = '" & sDepo & "')")
                    ElseIf Trim(sFisTipi) = "T" Then
                        nCiktiSatirSayisi = nFaturaCiktiSatirSayisi
                        cmd.CommandText = sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT     ISNULL(lTransferFisi1,0) + 1 AS lFisNo FROM         tbStokFisNolar WHERE     (sDepo = '" & sDepo & "')")
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
                    ElseIf Trim(sFisTipi) = "IS" Then
                        cmd.CommandText = sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED UPDATE    tbStokFisNolar SET              lToptanIrsaliye2 = lToptanIrsaliye2 " & sOperator & " " & nSayfa & " WHERE     (sDepo = '" & sDepo & "')")
                    ElseIf Trim(sFisTipi) = "DC" Then
                        cmd.CommandText = sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED UPDATE    tbStokFisNolar SET              lSevkFaturasi2 = lSevkFaturasi2 " & sOperator & " " & nSayfa & " WHERE     (sDepo = '" & sDepo & "')")
                    ElseIf Trim(sFisTipi) = "HS" Then
                        cmd.CommandText = sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED UPDATE    tbStokFisNolar SET              lToptanFatura2 = lToptanFatura2 " & sOperator & " " & nSayfa & " WHERE     (sDepo = '" & sDepo & "')")
                    ElseIf Trim(sFisTipi) = "T" Then
                        cmd.CommandText = sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED UPDATE    tbStokFisNolar SET              lTransferFisi2 = lTransferFisi2 " & sOperator & " " & nSayfa & " WHERE     (sDepo = '" & sDepo & "')")
                    End If
                Else
                    If Trim(sFisTipi) = "FS" Then
                        cmd.CommandText = sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED UPDATE    tbStokFisNolar SET              lToptanFatura1 = lToptanFatura1 " & sOperator & " " & nSayfa & " WHERE     (sDepo = '" & sDepo & "')")
                    ElseIf Trim(sFisTipi) = "IS" Then
                        cmd.CommandText = sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED UPDATE    tbStokFisNolar SET              lToptanIrsaliye1 = lToptanIrsaliye1 " & sOperator & " " & nSayfa & " WHERE     (sDepo = '" & sDepo & "')")
                    ElseIf Trim(sFisTipi) = "DC" Then
                        cmd.CommandText = sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED UPDATE    tbStokFisNolar SET              lSevkFaturasi1 = lSevkFaturasi1 " & sOperator & " " & nSayfa & " WHERE     (sDepo = '" & sDepo & "')")
                    ElseIf Trim(sFisTipi) = "HS" Then
                        cmd.CommandText = sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED UPDATE    tbStokFisNolar SET              lToptanFatura1 = lToptanFatura1 " & sOperator & " " & nSayfa & " WHERE     (sDepo = '" & sDepo & "')")
                    ElseIf Trim(sFisTipi) = "T" Then
                        cmd.CommandText = sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED UPDATE    tbStokFisNolar SET              lTransferFisi1 = lTransferFisi1 " & sOperator & " " & nSayfa & " WHERE     (sDepo = '" & sDepo & "')")
                    End If
                End If
                cmd.ExecuteNonQuery()
            End If
        End If
        Return kayitsayisi
        con.Dispose()
        cmd.Dispose()
        adapter.Dispose()
        cmd = Nothing
    End Function
    Private Function tbStokFisiMaster_kaydet_yeni(ByVal sFisTipi As String, ByVal dteFisTarihi As DateTime, ByVal nGirisCikis As Int64, ByVal lFisNo As Int64, ByVal nFirmaID As Int64, ByVal sDepo As String, ByVal dteValorTarihi As DateTime, ByVal bPesinmi As Byte, ByVal bListelendimi As Byte, ByVal bHizmetFaturasimi As Byte, ByVal lToplamMiktar As Decimal, ByVal lMalBedeli As Decimal, ByVal lMalIskontoTutari As Decimal, ByVal nDipIskontoYuzdesi1 As Decimal, ByVal lDipIskontoTutari1 As Decimal, ByVal nDipIskontoYuzdesi2 As Decimal, ByVal lDipIskontoTutari2 As Decimal, ByVal lDipIskontoTutari3 As Decimal, ByVal lEkmaliyet1 As Decimal, ByVal lEkmaliyet2 As Decimal, ByVal lEkmaliyet3 As Decimal, ByVal nKdvOrani1 As Decimal, ByVal lKdvMatrahi1 As Decimal, ByVal lKdv1 As Decimal, ByVal nKdvOrani2 As Decimal, ByVal lKdvMatrahi2 As Decimal, ByVal lKdv2 As Decimal, ByVal nKdvOrani3 As Decimal, ByVal lKdvMatrahi3 As Decimal, ByVal lKdv3 As Decimal, ByVal nKdvOrani4 As Decimal, ByVal lKdvMatrahi4 As Decimal, ByVal lKdv4 As Decimal, ByVal nKdvOrani5 As Decimal, ByVal lKdvMatrahi5 As Decimal, ByVal lKdv5 As Decimal, ByVal lNetTutar As Decimal, ByVal nTevkifatKdvOrani As Decimal, ByVal lTevkifatKdvMatrahi As Decimal, ByVal lTevkifatKdv As Decimal, ByVal sCariIslem As String, ByVal nCariHareketID As String, ByVal nKasaIslemID As String, ByVal sCariKdvIslem As String, ByVal nCariKdvHareketID As String, ByVal sHareketTipi As String, ByVal bMuhasebeyeIslendimi As Byte, ByVal bFisTamamlandimi As Byte, ByVal lTransferFisiID As String, ByVal nTransferFirmaID As String, ByVal sTransferDepo As String, ByVal bFaturayaDonustumu As Byte, ByVal sKullaniciAdi As String, ByVal dteKayitTarihi As DateTime, ByVal sYaziIle As String, ByVal nOTVOrani1 As Decimal, ByVal lOTVMatrahi1 As Decimal, ByVal lOTV1 As Decimal, ByVal nOTVOrani2 As Decimal, ByVal lOTVMatrahi2 As Decimal, ByVal lOTV2 As Decimal, ByVal bKilitli As Byte, Optional ByVal bTransferGuncelle As Boolean = False) As Int64
        Dim cmd As New OleDb.OleDbCommand
        Dim con As New OleDb.OleDbConnection
        Dim nStokFisiID As Integer = 0
        cmd.Connection = con
        con.ConnectionString = connection
        cmd.CommandTimeout = Nothing
        If con.State = ConnectionState.Closed = True Then
            con.Open()
        End If
        'cmd.CommandText = sorgu_query("SET DATEFORMAT DMY INSERT INTO tbStokFisiMaster (sFisTipi, dteFisTarihi, nGirisCikis, lFisNo, nFirmaID, sDepo, dteValorTarihi, bPesinmi, bListelendimi, bHizmetFaturasimi, lToplamMiktar, lMalBedeli, lMalIskontoTutari, nDipIskontoYuzdesi1, lDipIskontoTutari1, nDipIskontoYuzdesi2, lDipIskontoTutari2, lDipIskontoTutari3, lEkmaliyet1, lEkmaliyet2, lEkmaliyet3, nKdvOrani1, lKdvMatrahi1, lKdv1, nKdvOrani2, lKdvMatrahi2, lKdv2, nKdvOrani3, lKdvMatrahi3, lKdv3, nKdvOrani4, lKdvMatrahi4, lKdv4, nKdvOrani5, lKdvMatrahi5, lKdv5, lNetTutar, nTevkifatKdvOrani, lTevkifatKdvMatrahi, lTevkifatKdv, sCariIslem, nCariHareketID, nKasaIslemID, sCariKdvIslem, nCariKdvHareketID, sHareketTipi, bMuhasebeyeIslendimi, bFisTamamlandimi, lTransferFisiID, nTransferFirmaID, sTransferDepo, bFaturayaDonustumu, sKullaniciAdi, dteKayitTarihi, sYaziIle, nOTVOrani1, lOTVMatrahi1, lOTV1, nOTVOrani2, lOTVMatrahi2, lOTV2) VALUES     ('" & sFisTipi & "', '" & dteFisTarihi & "', " & nGirisCikis & " , '" & lFisNo & "', " & nFirmaID & ", '" & sDepo & "', '" & dteValorTarihi & "', " & bPesinmi & " , " & bListelendimi & " , " & bHizmetFaturasimi & " , " & lToplamMiktar & " , " & lMalBedeli & ", " & lMalIskontoTutari & " , " & nDipIskontoYuzdesi1 & " , " & lDipIskontoTutari1 & " , " & nDipIskontoYuzdesi2 & " , " & lDipIskontoTutari2 & " , " & lDipIskontoTutari3 & " , " & lEkmaliyet1 & " , " & lEkmaliyet2 & " , " & lEkmaliyet3 & " , " & nKdvOrani1 & " , " & lKdvMatrahi1 & ", " & lKdv1 & " , " & nKdvOrani2 & ", " & lKdvMatrahi2 & " , " & lKdv2 & ", " & nKdvOrani3 & " , " & lKdvMatrahi3 & ", " & lKdv3 & " , " & nKdvOrani4 & ", " & lKdvMatrahi4 & " , " & lKdv4 & " , " & nKdvOrani5 & " , " & lKdvMatrahi5 & " , " & lKdv5 & " , " & lNetTutar & " , " & nTevkifatKdvOrani & " , " & lTevkifatKdvMatrahi & ", " & lTevkifatKdv & " , '" & sCariIslem & "', '" & nCariHareketID & "', '" & nKasaIslemID & "', '" & sCariKdvIslem & "', '" & nCariKdvHareketID & "', '" & sHareketTipi & "', " & bMuhasebeyeIslendimi & ", " & bFisTamamlandimi & ", '" & lTransferFisiID & "', '" & nTransferFirmaID & "', '" & sTransferDepo & "', " & bFaturayaDonustumu & " , '" & sKullaniciAdi & "', '" & dteKayitTarihi & "', '" & sYaziIle & "', " & nOTVOrani1 & ", " & lOTVMatrahi1 & ", " & lOTV1 & ", " & nOTVOrani2 & " , " & lOTVMatrahi2 & ", " & lOTV2 & ")")
        cmd.CommandText = sorgu_query("SET DATEFORMAT DMY INSERT INTO tbStokFisiMaster (sFisTipi, dteFisTarihi, nGirisCikis, lFisNo, nFirmaID, sDepo, dteValorTarihi, bPesinmi, bListelendimi, bHizmetFaturasimi, lToplamMiktar, lMalBedeli, lMalIskontoTutari, nDipIskontoYuzdesi1, lDipIskontoTutari1, nDipIskontoYuzdesi2, lDipIskontoTutari2, lDipIskontoTutari3, lEkmaliyet1, lEkmaliyet2, lEkmaliyet3, nKdvOrani1, lKdvMatrahi1, lKdv1, nKdvOrani2, lKdvMatrahi2, lKdv2, nKdvOrani3, lKdvMatrahi3, lKdv3, nKdvOrani4, lKdvMatrahi4, lKdv4, nKdvOrani5, lKdvMatrahi5, lKdv5, lNetTutar, nTevkifatKdvOrani, lTevkifatKdvMatrahi, lTevkifatKdv, sHareketTipi, bMuhasebeyeIslendimi, bFisTamamlandimi, lTransferFisiID,  nTransferFirmaID,sTransferDepo, bFaturayaDonustumu, sKullaniciAdi, dteKayitTarihi, sYaziIle, nOTVOrani1, lOTVMatrahi1, lOTV1, nOTVOrani2, lOTVMatrahi2, lOTV2,bKilitli) VALUES     ('" & sFisTipi & "', '" & dteFisTarihi & "', " & nGirisCikis & " , '" & lFisNo & "', " & nFirmaID & ", '" & sDepo & "', '" & dteValorTarihi & "', " & bPesinmi & " , " & bListelendimi & " , " & bHizmetFaturasimi & " , " & lToplamMiktar & " , " & lMalBedeli & ", " & lMalIskontoTutari & " , " & nDipIskontoYuzdesi1 & " , " & lDipIskontoTutari1 & " , " & nDipIskontoYuzdesi2 & " , " & lDipIskontoTutari2 & " , " & lDipIskontoTutari3 & " , " & lEkmaliyet1 & " , " & lEkmaliyet2 & " , " & lEkmaliyet3 & " , " & nKdvOrani1 & " , " & lKdvMatrahi1 & ", " & lKdv1 & " , " & nKdvOrani2 & ", " & lKdvMatrahi2 & " , " & lKdv2 & ", " & nKdvOrani3 & " , " & lKdvMatrahi3 & ", " & lKdv3 & " , " & nKdvOrani4 & ", " & lKdvMatrahi4 & " , " & lKdv4 & " , " & nKdvOrani5 & " , " & lKdvMatrahi5 & " , " & lKdv5 & " , " & lNetTutar & " , " & nTevkifatKdvOrani & " , " & lTevkifatKdvMatrahi & ", " & lTevkifatKdv & " ,  '" & sHareketTipi & "', " & bMuhasebeyeIslendimi & ", " & bFisTamamlandimi & ", '" & lTransferFisiID & "',  " & nTransferFirmaID & ",'" & sTransferDepo & "', " & bFaturayaDonustumu & " , '" & sKullaniciAdi & "', '" & dteKayitTarihi & "', '" & sYaziIle & "', " & nOTVOrani1 & ", " & lOTVMatrahi1 & ", " & lOTV1 & ", " & nOTVOrani2 & " , " & lOTVMatrahi2 & ", " & lOTV2 & "," & bKilitli & ")")
        cmd.ExecuteNonQuery()
        cmd.CommandText = "SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT @@identity"
        nStokFisiID = cmd.ExecuteScalar
        If bTransferGuncelle = True And Trim(sFisTipi) = "T" Then
            cmd.CommandText = "SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED Update tbStokFisiMaster Set lTransferFisiID = " & nStokFisiID & " Where nStokFisiID = " & lTransferFisiID & ""
            cmd.ExecuteNonQuery()
        End If
        Return nStokFisiID
        con.Close()
        con.Dispose()
        cmd.Dispose()
        con = Nothing
        cmd = Nothing
    End Function
    Private Sub tbStokFisiMaster_lFisno_degistir(ByVal nstokFisiID As String)
        Dim cmd As New OleDb.OleDbCommand
        Dim con As New OleDb.OleDbConnection
        con.ConnectionString = connection
        cmd.Connection = con
        cmd.CommandTimeout = Nothing
        If con.State = ConnectionState.Closed Then
            con.Open()
        End If
        cmd.CommandText = sorgu_query("SET DATEFORMAT DMY SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED UPDATE    tbStokSiraNo SET              nSonID = '" & nstokFisiID & "' where nSiraIndex = 2")
        cmd.ExecuteNonQuery()
        con.Close()
        con.Dispose()
        cmd.Dispose()
        con = Nothing
        cmd = Nothing
    End Sub
    Private Sub tbStokFisiAciklamasi_kaydet_yeni(ByVal nStokFisiID As String, ByVal sAciklama1 As String, ByVal sAciklama2 As String, ByVal sAciklama3 As String, ByVal sAciklama4 As String, ByVal sAciklama5 As String)
        Dim cmd As New OleDb.OleDbCommand
        Dim con As New OleDb.OleDbConnection
        cmd.Connection = con
        con.ConnectionString = connection
        cmd.CommandTimeout = Nothing
        If con.State = ConnectionState.Closed = True Then
            con.Open()
        End If
        cmd.CommandText = sorgu_query("SET DATEFORMAT DMY INSERT INTO tbStokFisiAciklamasi                       (nStokFisiID, sAciklama1, sAciklama2, sAciklama3, sAciklama4, sAciklama5) VALUES     ('" & nStokFisiID & "', '" & sAciklama1 & "', '" & sAciklama2 & "', '" & sAciklama3 & "', '" & sAciklama4 & "', '" & sAciklama5 & "')")
        cmd.ExecuteNonQuery()
        con.Close()
        con.Dispose()
        cmd.Dispose()
        con = Nothing
        cmd = Nothing
    End Sub
    Private Sub sec_sDepo_EditValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles sec_sDepo.EditValueChanged
        dataload_tbTdepo(Trim(sec_sDepo.Text))
    End Sub
    Private Sub sec_sDepo_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles sec_sDepo.TextChanged
        dataload_tbTdepo(Trim(sec_sDepo.Text))
    End Sub
End Class