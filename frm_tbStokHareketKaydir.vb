Imports Microsoft.Win32
Imports DevExpress.XtraEditors
Public Class frm_tbStokHareketKaydir
    Public firmano
    Public donemno
    Public kullanici
    Public connection
    Public sIslem As String = ""
    Public nFirmaID As Int64 = 0
    Public nStokID As Int64 = 0
    Public nYeniStokID As Int64 = 0
    Public sFirmaKodu As String
    Public sFirmaAciklama As String
    Public sYeniFirmaKodu As String
    Public sYeniFirmaAciklama As String
    Dim cmd As New OleDb.OleDbCommand
    Dim con As New OleDb.OleDbConnection
    Dim dr As DataRow
    Dim ds_tbStokTedarikcisi As DataSet
    Public bFirma As Boolean = False
    Private Sub frm_tbStokTedarik_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        txt_musteriNo.Focus()
        txt_musteriNo.SelectAll()
        DateEdit1.EditValue = "01/01/1900"
        DateEdit2.EditValue = "31/12/2078"
        Me.Text = sIslem
        Label1.Text = sIslem
        Try
            gorunum_yukle()
        Catch ex As Exception
        End Try
    End Sub
    Private Sub ara()
        Label2.Text = Sorgu_sDil("Lütfen Bekleyiniz...", sDil)
        Label2.Refresh()
        'dataload_tbStokTedarikcisi(nFirmaID, "", "Kodu", "Başlar")
        Label2.Text = Sorgu_sDil("Tamamlandı...", sDil)
    End Sub
    Private Sub gorunum_yukle()
        For Each btn As DevExpress.XtraBars.BarItem In BarManager1.Items
            btn.Caption = Sorgu_sDil(btn.Caption, sDil)
        Next
        SimpleButton1.Text = Sorgu_sDil(SimpleButton1.Text, sDil)
        SimpleButton2.Text = Sorgu_sDil(SimpleButton2.Text, sDil)
        SimpleButton3.Text = Sorgu_sDil(SimpleButton3.Text, sDil)
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
    Private Function sorgu_query(ByVal query As String) As String
        query = Replace(query, "*!F", "F0" + firmano.ToString)
        query = Replace(query, "!D", "D000" + donemno.ToString)
        Return query
    End Function
    Private Sub stok_sec(Optional ByVal islem As Integer = 0)
        Dim frm As New frm_stok
        frm.firmano = firmano
        frm.donemno = donemno
        frm.connection = connection
        frm.islemstatus = True
        frm.kullanici = kullanici
        If frm.ShowDialog(Me) = Windows.Forms.DialogResult.OK Then
            Dim dr1 As DataRow
            dr1 = frm.GridView1.GetDataRow(frm.GridView1.FocusedRowHandle)
            nStokID = dr1("nStokID")
            sFirmaKodu = dr1("sKodu")
            lbl_Firma.Text = Trim(dr1("sAciklama").ToString)
            sFirmaAciklama = Trim(dr1("sAciklama").ToString)
            txt_musteriNo.EditValue = sFirmaKodu
            dr1 = Nothing
        End If
    End Sub
    Private Sub firma_sec(Optional ByVal islem As Integer = 0)
        Dim frm As New frm_firma_liste
        frm.firmano = firmano
        frm.donemno = donemno
        frm.connection = connection
        frm.islemstatus = True
        frm.kullanici = kullanici
        If frm.ShowDialog(Me) = Windows.Forms.DialogResult.OK Then
            Dim dr1 As DataRow
            dr1 = frm.GridView1.GetDataRow(frm.GridView1.FocusedRowHandle)
            nStokID = dr1("nFirmaID")
            sFirmaKodu = dr1("sKodu")
            lbl_Firma.Text = Trim(dr1("sAciklama").ToString)
            sFirmaAciklama = Trim(dr1("sAciklama").ToString)
            txt_musteriNo.EditValue = sFirmaKodu
            dr1 = Nothing
        End If
    End Sub
    Private Sub musteri_sec(Optional ByVal islem As Integer = 0)
        Dim frm As New frm_musteri_liste
        frm.firmano = firmano
        frm.donemno = donemno
        frm.connection = connection
        frm.islemstatus = True
        frm.kullanici = kullanici
        If frm.ShowDialog(Me) = Windows.Forms.DialogResult.OK Then
            Dim dr1 As DataRow
            dr1 = frm.GridView1.GetDataRow(frm.GridView1.FocusedRowHandle)
            nStokID = dr1("nMusteriID")
            sFirmaKodu = dr1("lKodu")
            lbl_Firma.Text = Trim(dr1("Musteri").ToString)
            sFirmaAciklama = Trim(dr1("Musteri").ToString)
            txt_musteriNo.EditValue = sFirmaKodu
            dr1 = Nothing
        End If
    End Sub
    Private Sub stok_sec_yeni(Optional ByVal islem As Integer = 0)
        Dim frm As New frm_stok
        frm.firmano = firmano
        frm.donemno = donemno
        frm.connection = connection
        frm.islemstatus = True
        frm.kullanici = kullanici
        If frm.ShowDialog(Me) = Windows.Forms.DialogResult.OK Then
            Dim dr1 As DataRow
            dr1 = frm.GridView1.GetDataRow(frm.GridView1.FocusedRowHandle)
            nYeniStokID = dr1("nStokID")
            sYeniFirmaKodu = dr1("sKodu")
            lbl_sYeniFirma.Text = Trim(dr1("sAciklama").ToString)
            sYeniFirmaAciklama = Trim(dr1("sAciklama").ToString)
            txt_sYenimusteriNo.EditValue = sYeniFirmaKodu
            dr1 = Nothing
        End If
    End Sub
    Private Sub firma_sec_yeni(Optional ByVal islem As Integer = 0)
        Dim frm As New frm_firma_liste
        frm.firmano = firmano
        frm.donemno = donemno
        frm.connection = connection
        frm.islemstatus = True
        frm.kullanici = kullanici
        If frm.ShowDialog(Me) = Windows.Forms.DialogResult.OK Then
            Dim dr1 As DataRow
            dr1 = frm.GridView1.GetDataRow(frm.GridView1.FocusedRowHandle)
            nYeniStokID = dr1("nFirmaID")
            sYeniFirmaKodu = dr1("sKodu")
            lbl_sYeniFirma.Text = Trim(dr1("sAciklama").ToString)
            sYeniFirmaAciklama = Trim(dr1("sAciklama").ToString)
            txt_sYenimusteriNo.EditValue = sYeniFirmaKodu
            dr1 = Nothing
        End If
    End Sub
    Private Sub musteri_sec_yeni(Optional ByVal islem As Integer = 0)
        Dim frm As New frm_musteri_liste
        frm.firmano = firmano
        frm.donemno = donemno
        frm.connection = connection
        frm.islemstatus = True
        frm.kullanici = kullanici
        If frm.ShowDialog(Me) = Windows.Forms.DialogResult.OK Then
            Dim dr1 As DataRow
            dr1 = frm.GridView1.GetDataRow(frm.GridView1.FocusedRowHandle)
            nYeniStokID = dr1("nMusteriID")
            sYeniFirmaKodu = dr1("lKodu")
            lbl_sYeniFirma.Text = Trim(dr1("Musteri").ToString)
            sYeniFirmaAciklama = Trim(dr1("Musteri").ToString)
            txt_sYenimusteriNo.EditValue = sYeniFirmaKodu
            dr1 = Nothing
        End If
    End Sub
    Private Sub tbStokHareketleriKaydir_kaydet_yeni(ByVal nStokID As Int64, ByVal nYeniStokID As Int64)
        Dim cmd As New OleDb.OleDbCommand
        Dim con As New OleDb.OleDbConnection
        cmd.Connection = con
        con.ConnectionString = connection
        cmd.CommandTimeout = Nothing
        If con.State = ConnectionState.Closed = True Then
            con.Open()
        End If
        cmd.CommandText = sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED Update tbAlisVerisSiparis set nStokID = " & nYeniStokID & " Where nStokID = " & nStokID & "")
        cmd.ExecuteNonQuery()
        cmd.CommandText = sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED Update tbStokFisiDetayi set nStokID = " & nYeniStokID & " Where nStokID = " & nStokID & "")
        cmd.ExecuteNonQuery()
        cmd.CommandText = sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED Update tbSiparis set nStokID = " & nYeniStokID & " Where nStokID = " & nStokID & "")
        cmd.ExecuteNonQuery()
        cmd.CommandText = sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED Update tbProtokol set nStokID = " & nYeniStokID & " Where nStokID = " & nStokID & "")
        Try
            cmd.ExecuteNonQuery()
        Catch ex As Exception
            XtraMessageBox.Show(ex.ToString)
            cmd.CommandText = sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED Delete from tbProtokol Where nStokID = " & nStokID & "")
            cmd.ExecuteNonQuery()
        End Try
        con.Close()
    End Sub
    Private Sub tbFirmaHareketleriKaydir_kaydet_yeni(ByVal nFirmaID As Int64, ByVal nYeniFirmaID As Int64)
        Dim cmd As New OleDb.OleDbCommand
        Dim con As New OleDb.OleDbConnection
        cmd.Connection = con
        con.ConnectionString = connection
        cmd.CommandTimeout = Nothing
        If con.State = ConnectionState.Closed = True Then
            con.Open()
        End If
        cmd.CommandText = sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED Update tbFirmaBordroMaster set nFirmaID = " & nYeniFirmaID & " Where nFirmaID = " & nFirmaID & "")
        cmd.ExecuteNonQuery()
        cmd.CommandText = sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED Update tbFirmaBordroDetay set nFirmaID = " & nYeniFirmaID & " Where nFirmaID = " & nFirmaID & "")
        cmd.ExecuteNonQuery()
        cmd.CommandText = sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED Update tbFirmaHareketi set nFirmaID = " & nYeniFirmaID & " Where nFirmaID = " & nFirmaID & "")
        cmd.ExecuteNonQuery()
        cmd.CommandText = sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED Update tbStokFisiMaster set nFirmaID = " & nYeniFirmaID & " Where nFirmaID = " & nFirmaID & "")
        cmd.ExecuteNonQuery()
        cmd.CommandText = sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED Update tbStokFisiDetayi set nStokID = " & nYeniStokID & " Where nStokID = " & nStokID & "")
        cmd.ExecuteNonQuery()
        cmd.CommandText = sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED Update tbSiparis set nFirmaID = " & nYeniFirmaID & " Where nFirmaID = " & nFirmaID & "")
        cmd.ExecuteNonQuery()
        cmd.CommandText = sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED Update tbNakitKasa set nFirmaID = " & nYeniFirmaID & " Where nFirmaID = " & nFirmaID & "")
        cmd.ExecuteNonQuery()
        cmd.CommandText = sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED Update tbCekSenet set nVerenID = " & nYeniFirmaID & " Where nVerenID = " & nFirmaID & "")
        cmd.ExecuteNonQuery()
        cmd.CommandText = sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED Update tbCekSenetBordro set nFirmaID = " & nYeniFirmaID & " Where nFirmaID = " & nFirmaID & "")
        cmd.ExecuteNonQuery()
        cmd.CommandText = sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED Update tbCekSenetBordro set nBorcluFirmaID = " & nYeniFirmaID & " Where nBorcluFirmaID = " & nFirmaID & "")
        cmd.ExecuteNonQuery()
        cmd.CommandText = sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED Update tbProtokol set nFirmaID = " & nYeniFirmaID & " Where nFirmaID = " & nFirmaID & "")
        Try
            cmd.ExecuteNonQuery()
        Catch ex As Exception
            XtraMessageBox.Show(ex.ToString)
            cmd.CommandText = sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED Delete from  tbProtokol Where nFirmaID = " & nFirmaID & "")
            cmd.ExecuteNonQuery()
        End Try
        con.Close()
    End Sub
    Private Sub tbMusteriHareketleriKaydir_kaydet_yeni(ByVal nMusteriID As Int64, ByVal nYeniMusteriID As Int64)
        Dim cmd As New OleDb.OleDbCommand
        Dim con As New OleDb.OleDbConnection
        cmd.Connection = con
        con.ConnectionString = connection
        cmd.CommandTimeout = Nothing
        If con.State = ConnectionState.Closed = True Then
            con.Open()
        End If
        cmd.CommandText = sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED Update tbAlisVeris set nMusteriID = " & nYeniMusteriID & " Where nMusteriID = " & nMusteriID & "")
        cmd.ExecuteNonQuery()
        cmd.CommandText = sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED Update tbStokFisiDetayi set nMusteriID = " & nYeniMusteriID & " Where nMusteriID = " & nMusteriID & "")
        cmd.ExecuteNonQuery()
        con.Close()
    End Sub
    Private Sub tbDepoHareketleriKaydir_kaydet_yeni(ByVal sDepo As String, ByVal sYeniDepo As String)
        Dim cmd As New OleDb.OleDbCommand
        Dim con As New OleDb.OleDbConnection
        cmd.Connection = con
        con.ConnectionString = connection
        cmd.CommandTimeout = Nothing
        If con.State = ConnectionState.Closed = True Then
            con.Open()
        End If
        'cmd.CommandText = sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED Update tbAlisVeris set nMusteriID = " & nYeniMusteriID & " Where nMusteriID = " & nMusteriID & "")
        'cmd.ExecuteNonQuery()
        cmd.CommandText = sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED Update tbStokFisiDetayi set sDepo = '" & sYeniDepo & "' Where sDepo = '" & sDepo & "'")
        cmd.ExecuteNonQuery()
        con.Close()
    End Sub
    Private Sub tbStokTedarikcisi_kaydet_kopyala(ByVal nFirmaID As Int64, ByVal nYeniFirmaID As Int64, Optional ByVal bFirma As Boolean = True)
        Dim cmd As New OleDb.OleDbCommand
        Dim con As New OleDb.OleDbConnection
        cmd.Connection = con
        con.ConnectionString = connection
        cmd.CommandTimeout = Nothing
        If con.State = ConnectionState.Closed = True Then
            con.Open()
        End If
        If bFirma = True Then
            cmd.CommandText = sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED INSERT INTO tbProtokol SELECT " & nYeniFirmaID & " AS nFirmaID, nMusteriID, nStokID, sFiyatTipi, sDovizCinsi, sHangiKur, nKdvOrani, lFiyat, nIskontoYuzdesi1, nIskontoYuzdesi2, nIskontoYuzdesi3, nIskontoYuzdesi4 FROM tbProtokol WHERE (nFirmaID = " & nFirmaID & ") and nStokID NOT IN (Select nStokID from tbProtokol where nFirmaID = " & nYeniFirmaID & ")")
            cmd.ExecuteNonQuery()
        Else
            cmd.CommandText = sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED INSERT INTO tbProtokol SELECT nFirmaID, nMusteriID, " & nYeniFirmaID & ", sFiyatTipi, sDovizCinsi, sHangiKur, nKdvOrani, lFiyat, nIskontoYuzdesi1, nIskontoYuzdesi2, nIskontoYuzdesi3, nIskontoYuzdesi4 FROM tbProtokol WHERE (nStokID = " & nFirmaID & ") and nFirmaID NOT IN (Select nFirmaID from tbProtokol where nStokID = " & nYeniFirmaID & ")")
            cmd.ExecuteNonQuery()
        End If
        con.Close()
    End Sub
    Private Sub tbStokTedarikcisi_kaydet_degistir(ByVal nFirmaID As Int64, ByVal nStokID As Int64, ByVal sFiyatTipi As String, ByVal sDovizCinsi As String, ByVal sHangiKur As String, ByVal nKdvOrani As Decimal, ByVal lFiyat As Decimal, ByVal nIskontoYuzdesi1 As Decimal, ByVal nIskontoYuzdesi2 As Decimal, ByVal nIskontoYuzdesi3 As Decimal, ByVal nIskontoYuzdesi4 As Decimal)
        Dim cmd As New OleDb.OleDbCommand
        Dim con As New OleDb.OleDbConnection
        cmd.Connection = con
        con.ConnectionString = connection
        cmd.CommandTimeout = Nothing
        If con.State = ConnectionState.Closed = True Then
            con.Open()
        End If
        cmd.CommandText = sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED UPDATE    tbProtokol SET              sFiyatTipi = '" & sFiyatTipi & "', sDovizCinsi = '" & sDovizCinsi & "', sHangiKur = '" & sHangiKur & "', nKdvOrani = " & nKdvOrani & ",lFiyat = " & lFiyat & ", nIskontoYuzdesi1 = " & nIskontoYuzdesi1 & ", nIskontoYuzdesi2 = " & nIskontoYuzdesi2 & ", nIskontoYuzdesi3 = " & nIskontoYuzdesi3 & ", nIskontoYuzdesi4 = " & nIskontoYuzdesi4 & " Where nFirmaID = '" & nFirmaID & "' AND nStokID = '" & nStokID & "' ")
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
        cmd.CommandText = sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED DELETE FROM tbProtokol Where nFirmaID = '" & nFirmaID & "' AND nStokID = '" & nStokID & "' ")
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
        cmd.CommandText = sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT     COUNT(*) AS nKayit FROM         tbProtokol WHERE     (nFirmaID = " & nFirmaID & ") AND (nStokID = " & nStokID & ")")
        Dim kayitsayisi = cmd.ExecuteScalar
        Return kayitsayisi
    End Function
    Private Sub satir_ekle_stok_kopyala()
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
                    tbStokTedarikcisi_kaydet_kopyala(nStokID, dr1("nStokID"), False)
                Next
            End If
            dr1 = frm.GridView1.GetDataRow(frm.GridView1.FocusedRowHandle)
            nStokID = dr1("nStokID")
            sFirmaKodu = dr1("sKodu")
            lbl_Firma.Text = Trim(dr1("sAciklama").ToString)
            sFirmaAciklama = Trim(dr1("sAciklama").ToString)
            txt_musteriNo.EditValue = sFirmaKodu
            ara()
        End If
    End Sub
    Private Sub satir_ekle_firma_kopyala()
        Using frm As New frm_firma_liste()
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
                        tbStokTedarikcisi_kaydet_kopyala(nFirmaID, dr1("nFirmaID"))
                    Next
                End If
                dr1 = frm.GridView1.GetDataRow(frm.GridView1.FocusedRowHandle)
                nFirmaID = dr1("nFirmaID")
                sFirmaKodu = dr1("sKodu")
                lbl_Firma.Text = Trim(dr1("sAciklama").ToString)
                sFirmaAciklama = Trim(dr1("sAciklama").ToString)
                txt_musteriNo.EditValue = sFirmaKodu
                ara()
            End If
        End Using
    End Sub
    Private Sub txt_musteriNo_ButtonClick(ByVal sender As Object, ByVal e As DevExpress.XtraEditors.Controls.ButtonPressedEventArgs) Handles txt_musteriNo.ButtonClick
        If sIslem = "Stok Hareketleri" Then
            stok_sec()
        ElseIf sIslem = "Firma Hareketleri" Then
            firma_sec()
            'Destek Bölümünde Var.
            'ElseIf sIslem = "Müşteri Hareketleri" Then
            '    musteri_sec()
        End If
    End Sub
    Private Sub txt_musteriNo_KeyDown(ByVal sender As Object, ByVal e As KeyEventArgs) Handles txt_musteriNo.KeyDown
        If e.KeyCode = Keys.Space Then
            If sIslem = "Stok Hareketleri" Then
                stok_sec()
            ElseIf sIslem = "Firma Hareketleri" Then
                firma_sec()
                'Destek Bölümünde Var.
                'ElseIf sIslem = "Müşteri Hareketleri" Then
                '    musteri_sec()
            End If
        ElseIf e.KeyCode = Keys.Enter Then
            If Trim(txt_musteriNo.Text) = "" Then
                If sIslem = "Stok Hareketleri" Then
                    stok_sec()
                ElseIf sIslem = "Firma Hareketleri" Then
                    firma_sec()
                    'Destek Bölümünde Var.
                    'ElseIf sIslem = "Müşteri Hareketleri" Then
                    '    musteri_sec()
                End If
            End If
        End If
    End Sub
    Private Sub GridControl1_KeyDown(ByVal sender As Object, ByVal e As KeyEventArgs)
        If e.KeyCode = Keys.Escape Then
            If XtraMessageBox.Show(Sorgu_sDil("Ekranı Kapatmak İstediğinize Emin misiniz...?", sDil), Sorgu_sDil("Dikkat", sDil), MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
                Me.Close()
            End If
        End If
    End Sub
    Private Sub MenuItem17_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        txt_musteriNo.EditValue = ""
        txt_musteriNo.Focus()
        txt_musteriNo.SelectAll()
    End Sub
    Private Sub SimpleButton2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SimpleButton2.Click
        Me.Close()
    End Sub
    Private Sub SimpleButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SimpleButton1.Click
        Me.Close()
    End Sub
    Private Sub GridView1_CustomDrawRowIndicator(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Grid.RowIndicatorCustomDrawEventArgs)
        If e.RowHandle >= 0 Then
            e.Info.DisplayText = e.RowHandle + 1
        Else
            e.Info.DisplayText = ""
        End If
    End Sub
    Private Sub MenuItem27_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem27.Click
        txt_musteriNo.EditValue = ""
        txt_musteriNo.Focus()
        txt_musteriNo.SelectAll()
    End Sub
    Private Sub SimpleButton6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        ara()
    End Sub
    Private Sub MenuItem9_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem9.Click
        If Me.WindowState = FormWindowState.Normal Then
            Me.WindowState = FormWindowState.Maximized
        ElseIf Me.WindowState = FormWindowState.Maximized Then
            Me.WindowState = FormWindowState.Normal
        End If
    End Sub
    Private Sub MenuItem4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem4.Click
        printlink1.CreateDocument(ps)
        ps.PreviewRibbonFormEx.Show()
    End Sub
    Private Sub SimpleButton3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SimpleButton3.Click
        Dim bDevam As Boolean = True
        If txt_musteriNo.Text = "" Then
            bDevam = False
            XtraMessageBox.Show("Eski Kodu Boş Bırakamazsınız...", Sorgu_sDil("Dikkat", sDil), MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If
        If txt_sYenimusteriNo.Text = "" Then
            bDevam = False
            XtraMessageBox.Show("Yeni Kodu Boş Bırakamazsınız...", Sorgu_sDil("Dikkat", sDil), MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If
        If bDevam = True Then
            If XtraMessageBox.Show(sFirmaKodu & vbTab & "Kodlu Hesaba Ait Kayıt Hareketlerini " & vbCrLf & sYeniFirmaKodu & vbTab & "Kodlu Yeni Hesaba Kaydırmak İstediğinize Emin misiniz...?", Sorgu_sDil("Dikkat", sDil), MessageBoxButtons.YesNo, MessageBoxIcon.Question) = MsgBoxResult.Yes Then
                If sIslem = "Stok Hareketleri" Then
                    tbStokHareketleriKaydir_kaydet_yeni(nStokID, nYeniStokID)
                ElseIf sIslem = "Firma Hareketleri" Then
                    tbFirmaHareketleriKaydir_kaydet_yeni(nStokID, nYeniStokID)
                    'Destek Bölümünde Var.
                    'ElseIf sIslem = "Müşteri Hareketleri" Then
                    '    tbMusteriHareketleriKaydir_kaydet_yeni(nStokID, nYeniStokID)
                    'Destek Bölümünde Var.
                    'ElseIf sIslem = "Depo Hareketleri" Then
                    '    tbDepoHareketleriKaydir_kaydet_yeni(txt_musteriNo.Text, txt_sYenimusteriNo.Text)
                ElseIf sIslem = "Satici Hareketleri" Then
                    'tbMusteriHareketleriKaydir_kaydet_yeni(nStokID, nYeniStokID)
                    XtraMessageBox.Show("Hazır Değil...!", Sorgu_sDil("Dikkat", sDil), MessageBoxButtons.OK, MessageBoxIcon.Warning)
                ElseIf sIslem = "Hareket Tipi" Then
                    'tbMusteriHareketleriKaydir_kaydet_yeni(nStokID, nYeniStokID)
                    XtraMessageBox.Show("Hazır Değil...!", Sorgu_sDil("Dikkat", sDil), MessageBoxButtons.OK, MessageBoxIcon.Warning)
                ElseIf sIslem = "Sube Hareketleri" Then
                    'tbMusteriHareketleriKaydir_kaydet_yeni(nStokID, nYeniStokID)
                    XtraMessageBox.Show("Hazır Değil...!", Sorgu_sDil("Dikkat", sDil), MessageBoxButtons.OK, MessageBoxIcon.Warning)
                ElseIf sIslem = "Fiyat Tipi" Then
                    'tbMusteriHareketleriKaydir_kaydet_yeni(nStokID, nYeniStokID)
                    XtraMessageBox.Show("Hazır Değil...!", Sorgu_sDil("Dikkat", sDil), MessageBoxButtons.OK, MessageBoxIcon.Warning)
                End If
                XtraMessageBox.Show(Sorgu_sDil("İşlem Başarıyla Tamamlandı...!", sDil), Sorgu_sDil("Dikkat", sDil), MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        End If
    End Sub
    Private Sub BarButtonItem1_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnAra.ItemClick
        ara()
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
        cmd.CommandText = sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT TOP 1 ISNULL(nSiparisID + 1, 1) AS nSiparisID FROM tbSiparis ORDER BY nSiparisID DESC")
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
    Public Sub calc()
        Dim frm As New frm_calc
        If frm.ShowDialog = DialogResult.OK Then
        End If
        frm.Close()
        frm = Nothing
    End Sub
    Private Sub MenuItem25_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem25.Click
        calc()
    End Sub
    Private Sub MenuItem29_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem29.Click
        If bFirma = True Then
            satir_ekle_firma_kopyala()
        Else
            satir_ekle_stok_kopyala()
        End If
    End Sub
    Private Sub txt_sYenimusteriNo_ButtonClick(ByVal sender As Object, ByVal e As DevExpress.XtraEditors.Controls.ButtonPressedEventArgs) Handles txt_sYenimusteriNo.ButtonClick
        If sIslem = "Stok Hareketleri" Then
            stok_sec_yeni()
        ElseIf sIslem = "Firma Hareketleri" Then
            firma_sec_yeni()
            'Destek Bölümünde Var.
            'ElseIf sIslem = "Müşteri Hareketleri" Then
            '    musteri_sec_yeni()
        End If
    End Sub
    Private Sub txt_sYenimusteriNo_KeyDown(ByVal sender As Object, ByVal e As KeyEventArgs) Handles txt_sYenimusteriNo.KeyDown
        If e.KeyCode = Keys.Space Then
            If sIslem = "Stok Hareketleri" Then
                stok_sec_yeni()
            ElseIf sIslem = "Firma Hareketleri" Then
                firma_sec_yeni()
                'Destek Bölümünde Var.
                'ElseIf sIslem = "Müşteri Hareketleri" Then
                '    musteri_sec_yeni()
            End If
        ElseIf e.KeyCode = Keys.Enter Then
            If Trim(txt_sYenimusteriNo.Text) = "" Then
                If sIslem = "Stok Hareketleri" Then
                    stok_sec_yeni()
                ElseIf sIslem = "Firma Hareketleri" Then
                    firma_sec_yeni()
                    'Destek Bölümünde Var.
                    'ElseIf sIslem = "Müşteri Hareketleri" Then
                    '    musteri_sec_yeni()
                End If
            End If
        End If
    End Sub
End Class