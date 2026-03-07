Imports DevExpress.XtraEditors
Public Class frm_stok_kart_kopyala
    Public firmano
    Public donemno
    Public connection
    Public nStokID
    Public sKodu
    Public sModel
    Public kullanici
    Dim conn As New OleDb.OleDbConnection
    Dim con As New OleDb.OleDbConnection
    Dim cmd As New OleDb.OleDbCommand
    Dim adapter As New OleDb.OleDbDataAdapter
    Dim DS As New DataSet
    Dim ds_stok As DataSet
    Dim ds_nStokID As DataSet
    Public sSinifKodu As String = ""
    Public sSinifKodu1 As String = ""
    Public sSinifKodu2 As String = ""
    Public sSinifKodu3 As String = ""
    Public sSinifKodu4 As String = ""
    Public sSinifKodu5 As String = ""
    Public sSinifKodu6 As String = ""
    Public sSinifKodu7 As String = ""
    Public sSinifKodu8 As String = ""
    Public sSinifKodu9 As String = ""
    Public sSinifKodu10 As String = ""
    Public sSinifKodu11 As String = ""
    Public sSinifKodu12 As String = ""
    Public sSinifKodu13 As String = ""
    Public sSinifKodu14 As String = ""
    Public sSinifKodu15 As String = ""
    Dim ds_tbFiyatTipi As DataSet
    Private Sub frm_stok_kart_kopyala_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        dataload_tbFiyatTipi(sModel)
        Try
            lbl_sKisaAdi.Text = sorgu_sKisaAdi_kontrol().ToString
        Catch ex As Exception
            lbl_sKisaAdi.Text = ""
        End Try
    End Sub
    Private Sub dataload_tbFiyatTipi(ByVal sModel As String)
        ds_tbFiyatTipi = sorgu(sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT DISTINCT tbStokFiyati.sFiyatTipi, tbFiyatTipi.sAciklama FROM tbStokFiyati INNER JOIN tbStok ON tbStokFiyati.nStokID = tbStok.nStokID INNER JOIN tbFiyatTipi ON tbStokFiyati.sFiyatTipi = tbFiyatTipi.sFiyatTipi WHERE (tbStok.sModel = '" & sModel & "') AND (tbStokFiyati.sFiyatTipi <> '')"))
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
    Private Function sorgu_query(ByVal query As String) As String
        query = Replace(query, "*!F", "F0" + firmano.ToString)
        query = Replace(query, "!D", "D000" + donemno.ToString)
        Return query
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
    Public Function sorgu_sKodu_kontrol(ByVal kod As String) As Boolean
        Dim kriter
        Dim pass As Boolean
        kriter = ""
        Dim conn As New OleDb.OleDbConnection
        Dim cmd As New OleDb.OleDbCommand
        Dim adapter As New OleDb.OleDbDataAdapter
        conn.ConnectionString = connection
        cmd.Connection = conn
        conn.Open()
        cmd.CommandText = sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT     ISNULL(COUNT(sKodu), 0) AS nKayit FROM         tbStok WHERE     (sKodu = '" & kod & "') ")
        Dim kayitsayisi = cmd.ExecuteScalar
        If kayitsayisi = 0 Then
            pass = True
        Else
            pass = False
        End If
        Return pass
    End Function
    Private Function tbSonKod(ByVal islem As String) As String
        Dim frm As New frm_tbSonKod
        frm.firmano = firmano
        frm.donemno = donemno
        frm.connection = connection
        frm.kullanici = kullanici
        frm.islem = islem
        Dim sKodu As String = ""
        If frm.ShowDialog(Me) = Windows.Forms.DialogResult.OK Then
            sKodu = frm.lbl_Kod.Text
        End If
        frm.Close()
        frm = Nothing
        Return sKodu
    End Function
    Public Function sorgu_sKisaAdi_kontrol() As Int64
        Dim kriter
        Dim sKisaAdi As Int64 = 0
        kriter = ""
        Dim conn As New OleDb.OleDbConnection
        Dim cmd As New OleDb.OleDbCommand
        Dim adapter As New OleDb.OleDbDataAdapter
        conn.ConnectionString = connection
        cmd.Connection = conn
        conn.Open()
        cmd.CommandText = sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT     ISNULL(MAX(CAST(sKisaAdi AS FLOAT)),0) AS sKisaAdi FROM         tbStok WHERE     (ISNUMERIC(sKisaAdi) = 1) ")
        sKisaAdi = cmd.ExecuteScalar
        sKisaAdi += 1
        Return sKisaAdi
    End Function
    Private Sub txt_sKodu_EditValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles txt_sKodu.EditValueChanged
        If Len(txt_sKodu.Text.ToString) <> 0 Then
            lbl_sKodu.Text = Len(txt_sKodu.EditValue.ToString)
            SimpleButton1.Enabled = True
            'SimpleButton3.Enabled = True
        Else
            lbl_sKodu.Text = "*"
            SimpleButton1.Enabled = False
            'SimpleButton3.Enabled = False
        End If
    End Sub
    Private Sub txt_sKodu_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txt_sKodu.KeyDown
        If e.KeyCode = Keys.Enter Then
            'txt_sBarkod.EditValue = Trim(txt_sKodu.EditValue)
        ElseIf e.KeyCode = Keys.F5 Then
            txt_sKodu.Text = tbSonKod("tbStok").ToString
        End If
    End Sub
    Private Sub txt_sKodu_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles txt_sKodu.Validating
        txt_sKodu.EditValue = Trim(txt_sKodu.EditValue)
        If sorgu_sKodu_kontrol(txt_sKodu.EditValue) = False Then
            txt_sKodu.ErrorText = txt_sKodu.Text & vbTab & "Kaydý Daha Önce Kullanýlmýþ"
            e.Cancel = True
            txt_sKodu.Focus()
            txt_sKodu.SelectAll()
        End If
    End Sub
    Private Function tbStok_kopyala(ByVal sModel As String, ByVal sKodu As String, ByVal sKisaAdi As String, ByVal bKisaKodArtsin As Boolean, ByVal bAciklamaDegis As Boolean) As Boolean
        Dim con As New OleDb.OleDbConnection
        Dim cmd As New OleDb.OleDbCommand
        Dim dr1 As DataRow
        Dim pass As Boolean = False
        sKodu = Trim(sKodu.ToString)
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
            If bKisaKodArtsin = True Then
                Dim sAciklama As String = Microsoft.VisualBasic.Left(txt_sAdi.Text, Len(txt_sAdi.Text) - Len(sKisaAdi)) & sKisaAdi
                If bAciklamaDegis = True Then
                    'cmd.CommandText = sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED INSERT INTO tbStok SELECT '" & sKodu & "' + sRenk + sBeden + sKavala, '" & sAciklama & "' as sAciklama, " & CType(sKisaAdi, Int64) & " as sKisaAdi, nStokTipi, sBedenTipi, sKavalaTipi, sRenk, sBeden, sKavala, sBirimCinsi1, sBirimCinsi2, nIskontoYuzdesi, sKdvTipi, nTeminSuresi, lAsgariMiktar, lAzamiMiktar, sOzelNot, nFiyatlandirma, '" & sKodu & "', 'sa', GETDATE(), bEksiyeDusulebilirmi, sDefaultAsortiTipi, bEksideUyarsinmi, bOTVVar, sOTVTipi, nIskontoYuzdesiAV, bEk1, nEk2 FROM tbStok WHERE (sModel = '" & sModel & "')")
                    cmd.CommandText = sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED INSERT INTO tbStok SELECT '" & sKodu & "' + sRenk + sBeden, '" & sAciklama & "' as sAciklama, " & CType(sKisaAdi, Int64) & " as sKisaAdi, nStokTipi, sBedenTipi, sKavalaTipi, sRenk, sBeden, sKavala, sBirimCinsi1, sBirimCinsi2, nIskontoYuzdesi, sKdvTipi, nTeminSuresi, lAsgariMiktar, lAzamiMiktar, sOzelNot, nFiyatlandirma, '" & sKodu & "', 'sa', GETDATE(), bEksiyeDusulebilirmi, sDefaultAsortiTipi, bEksideUyarsinmi, bOTVVar, sOTVTipi, nIskontoYuzdesiAV, bEk1, nEk2,nPrim, nEn, nBoy, nYukseklik, nHacim, nAgirlik, sDovizCinsi, sAlisKdvTipi, 0, 0, 0, 0, 0, GETDATE() FROM tbStok WHERE (sModel = '" & sModel & "')")
                Else
                    'cmd.CommandText = sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED INSERT INTO tbStok SELECT '" & sKodu & "' + sRenk + sBeden + sKavala, sAciklama, " & CType(sKisaAdi, Int64) & " as sKisaAdi, nStokTipi, sBedenTipi, sKavalaTipi, sRenk, sBeden, sKavala, sBirimCinsi1, sBirimCinsi2, nIskontoYuzdesi, sKdvTipi, nTeminSuresi, lAsgariMiktar, lAzamiMiktar, sOzelNot, nFiyatlandirma, '" & sKodu & "', 'sa', GETDATE(), bEksiyeDusulebilirmi, sDefaultAsortiTipi, bEksideUyarsinmi, bOTVVar, sOTVTipi, nIskontoYuzdesiAV, bEk1, nEk2 FROM tbStok WHERE (sModel = '" & sModel & "')")
                    cmd.CommandText = sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED INSERT INTO tbStok SELECT '" & sKodu & "' + sRenk + sBeden, sAciklama, " & CType(sKisaAdi, Int64) & " as sKisaAdi, nStokTipi, sBedenTipi, sKavalaTipi, sRenk, sBeden, sKavala, sBirimCinsi1, sBirimCinsi2, nIskontoYuzdesi, sKdvTipi, nTeminSuresi, lAsgariMiktar, lAzamiMiktar, sOzelNot, nFiyatlandirma, '" & sKodu & "', 'sa', GETDATE(), bEksiyeDusulebilirmi, sDefaultAsortiTipi, bEksideUyarsinmi, bOTVVar, sOTVTipi, nIskontoYuzdesiAV, bEk1, nEk2,0 as nPrim,nEn, nBoy, nYukseklik, nHacim, nAgirlik, sDovizCinsi, sAlisKdvTipi, 0, 0, 0, 0, 0, GETDATE() FROM tbStok WHERE (sModel = '" & sModel & "')")
                End If
            Else
                'cmd.CommandText = sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED INSERT INTO tbStok SELECT '" & sKodu & "' + sRenk + sBeden + sKavala, sAciklama, sKisaAdi, nStokTipi, sBedenTipi, sKavalaTipi, sRenk, sBeden, sKavala, sBirimCinsi1, sBirimCinsi2, nIskontoYuzdesi, sKdvTipi, nTeminSuresi, lAsgariMiktar, lAzamiMiktar, sOzelNot, nFiyatlandirma, '" & sKodu & "', 'sa', GETDATE(), bEksiyeDusulebilirmi, sDefaultAsortiTipi, bEksideUyarsinmi, bOTVVar, sOTVTipi, nIskontoYuzdesiAV, bEk1, nEk2 FROM tbStok WHERE (sModel = '" & sModel & "')")
                cmd.CommandText = sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED INSERT INTO tbStok SELECT '" & sKodu & "' + sRenk + sBeden , sAciklama, sKisaAdi, nStokTipi, sBedenTipi, sKavalaTipi, sRenk, sBeden, sKavala, sBirimCinsi1, sBirimCinsi2, nIskontoYuzdesi, sKdvTipi, nTeminSuresi, lAsgariMiktar, lAzamiMiktar, sOzelNot, nFiyatlandirma, '" & sKodu & "', 'sa', GETDATE(), bEksiyeDusulebilirmi, sDefaultAsortiTipi, bEksideUyarsinmi, bOTVVar, sOTVTipi, nIskontoYuzdesiAV, bEk1, nEk2,nPrim, nEn, nBoy, nYukseklik, nHacim, nAgirlik, sDovizCinsi, sAlisKdvTipi, 0, 0, 0, 0, 0, GETDATE() FROM tbStok WHERE (sModel = '" & sModel & "')")
            End If
            cmd.ExecuteNonQuery()
            If CheckEdit1.Checked = True Then
                cmd.CommandText = sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED INSERT INTO tbStokSinifi SELECT nStokID, '" & sSinifKodu1 & "', '" & sSinifKodu2 & "', '" & sSinifKodu3 & "', '" & sSinifKodu4 & "', '" & sSinifKodu5 & "', '" & sSinifKodu6 & "', '" & sSinifKodu7 & "', '" & sSinifKodu8 & "', '" & sSinifKodu9 & "', '" & sSinifKodu10 & "', '" & sSinifKodu11 & "', '" & sSinifKodu12 & "', '" & sSinifKodu13 & "', '" & sSinifKodu14 & "', '" & sSinifKodu15 & "' FROM tbStok WHERE (sModel = '" & sKodu & "')")
                cmd.ExecuteNonQuery()
            End If
            If CheckEdit2.Checked = True Then
                cmd.CommandText = sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED INSERT INTO tbStokMuhasebeEntegrasyon SELECT tbStok.nStokID, Hesaplar.sSubeMagaza, Hesaplar.nSubeMagazaHesapTipi, Hesaplar.sHareketTipi, Hesaplar.nHesapID FROM (SELECT DISTINCT sModel , sSubeMagaza , nSubeMagazaHesapTipi , sHareketTipi , nHesapID FROM tbStokMuhasebeEntegrasyon , tbStok WHERE tbStokMuhasebeEntegrasyon.nStokID = tbStok.nStokID AND tbStok.sModel = '" & sModel & "') Hesaplar CROSS JOIN tbStok WHERE (tbStok.sModel = '" & sKodu & "') AND (NOT EXISTS (SELECT * FROM tbStokMuhasebeEntegrasyon WHERE nStokID = tbStok.nStokID AND sSubeMagaza = Hesaplar.sSubeMagaza AND nSubeMagazaHesapTipi = Hesaplar.nSubeMagazaHesapTipi AND sHareketTipi = Hesaplar.sHareketTipi))")
                cmd.ExecuteNonQuery()
            End If
            If CheckEdit3.Checked = True Then
                For Each dr1 In ds_tbFiyatTipi.Tables(0).Rows
                    cmd.CommandText = sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED INSERT INTO tbStokFiyati SELECT nStokID, '" & dr1("sFiyatTipi") & "', ISNULL((SELECT lFiyat FROM tbStokFiyati WHERE sFiyatTipi = '" & dr1("sFiyatTipi") & "' AND nStokID = (SELECT nStokID FROM tbStok WHERE sKodu = '" & sModel & "')), 0), '" & Today & "', '" & kullanici & "', GETDATE() FROM tbStok WHERE (sModel = '" & sKodu & "')")
                    cmd.ExecuteNonQuery()
                Next
            End If
            cmd.CommandText = sorgu_query("IF @@TRANCOUNT > 0 COMMIT TRAN")
            cmd.ExecuteNonQuery()
            cmd.CommandText = sorgu_query("set implicit_transactions off ")
            cmd.ExecuteNonQuery()
            pass = True
        Catch ex As Exception
            XtraMessageBox.Show(Sorgu_sDil("Üzgünüm,Ýþlem Hatasý...!", sDil), Sorgu_sDil("Dikkat", sDil), MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            cmd.CommandText = sorgu_query("IF @@TRANCOUNT > 0 ROLLBACK TRAN")
            cmd.ExecuteNonQuery()
            cmd.CommandText = sorgu_query("set implicit_transactions off ")
            cmd.ExecuteNonQuery()
            pass = False
        End Try
        con.Close()
        Return pass
    End Function
    Private Sub SimpleButton2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SimpleButton2.Click
        Me.Close()
    End Sub
    Private Sub SimpleButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SimpleButton1.Click
        If XtraMessageBox.Show(sModel & Sorgu_sDil(" Nolu Stok Kartýný ", sDil) & vbCrLf & txt_sKodu.EditValue & Sorgu_sDil(" Olarak Kopyalamak Ýstediðinize Emin misiniz...?", sDil), Sorgu_sDil("Dikkat", sDil), MessageBoxButtons.YesNo, MessageBoxIcon.Question) = MsgBoxResult.Yes Then
            If tbStok_kopyala(Trim(sModel), Trim(txt_sKodu.EditValue.ToString), lbl_sKisaAdi.Text, bKisaNoArtsin.Checked, bAciklamaDegissin.Checked) = True Then
                sKodu = Trim(txt_sKodu.EditValue.ToString)
                Try
                    lbl_sKisaAdi.Text = sorgu_sKisaAdi_kontrol().ToString
                Catch ex As Exception
                    lbl_sKisaAdi.Text = ""
                End Try
                If XtraMessageBox.Show(Sorgu_sDil("Kopyalama Ýþlemi Baþarýyla Tamamlandý..." & vbCrLf & "Kopyalama Ýþlemine Devam Etmek Ýster misiniz...?", sDil), Sorgu_sDil("Dikkat", sDil), MessageBoxButtons.YesNo, MessageBoxIcon.Question) = MsgBoxResult.Yes Then
                    txt_sKodu.Focus()
                    txt_sKodu.SelectAll()
                Else
                    Me.DialogResult = Windows.Forms.DialogResult.OK
                    Me.Close()
                End If
            End If
        End If
    End Sub
End Class