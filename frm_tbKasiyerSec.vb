Imports Microsoft.Win32
Imports DevExpress.XtraEditors
Public Class frm_tbKasiyerSec
    Public firmano
    Public donemno
    Public connection
    Public kullanici
    Public sKasiyerRumuzu As String = ""
    Public sKasiyer As String
    Public sMagaza As String
    Public nMusteriID As Int64 = 0
    Public lKodu As String = 0
    Public sAdi As String = ""
    Public sSoyadi As String = ""
    Public sAdres1 As String = ""
    Public sAdres2 As String = ""
    Dim sIstihbarat As String = ""
    Dim ds_kasiyer As DataSet
    Dim ds_cari As DataSet
    Public sKrediliFiyat As String
    Public sPesinFiyat As String
    Public bIptalYapabilirmi As Boolean = False
    Public bVadeFarksizOdemeAlirmi As Boolean = False
    Public nMaxIskontoYuzdesi As Decimal = 100
    Private Sub SimpleButton2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SimpleButton2.Click
        Me.Close()
    End Sub
    Private Sub frm_tbKasiyerSec_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

        Try
            sKrediliFiyat = Registry.CurrentUser.OpenSubKey("Software").OpenSubKey("BusinessSmart").OpenSubKey("VIEW").OpenSubKey("STOK").OpenSubKey("YENIKART").GetValue("sKrediliFiyatTipi").ToString
        Catch ex As Exception
            sKrediliFiyat = ""
        End Try
        Try
            sPesinFiyat = Registry.CurrentUser.OpenSubKey("Software").OpenSubKey("BusinessSmart").OpenSubKey("VIEW").OpenSubKey("STOK").OpenSubKey("YENIKART").GetValue("sPesinFiyatTipi").ToString
        Catch ex As Exception
            sPesinFiyat = ""
        End Try
        DateEdit1.EditValue = dteSistemTarihi
        DateEdit1.Enabled = False
        dataload_kasa()
        dataload_kasiyer()
        dataload_depo()
        txt_kasiyer_kod.Focus()
        txt_kasiyer_kod.SelectAll()
    End Sub
    Private Sub dataload_kasa()
        sec_kasa.Properties.DataSource = sorgu(sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT     nKasaNo,sAciklama  FROM         tbParekendeKasa ")).Tables(0)
        sec_kasa.ItemIndex = 0
    End Sub
    Private Sub dataload_kasiyer()
        ds_kasiyer = sorgu(sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT     sKasiyerRumuzu AS IND, sAdi + ' ' + sSoyadi AS KASIYER, sSifresi AS SIFRE, sDepo AS DEPO,bIptalYapabilirmi, bVadeFarksizOdemeAlirmi, nMaxIskontoYuzdesi FROM         tbKasiyer WHERE     (sKasiyerRumuzu <> '')"))
    End Sub
    Private Sub dataload_depo()
        sec_magaza.Properties.DataSource = sorgu(sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT     sDepo, sAciklama FROM         tbDepo Where sDepo <> '' ")).Tables(0)
        sec_magaza.ItemIndex = 0
    End Sub
    Private Function sorgu(ByVal query As String) As DataSet
        Dim con As New OleDb.OleDbConnection
        Dim cmd As New OleDb.OleDbCommand
        Dim adapter As New OleDb.OleDbDataAdapter
        con.ConnectionString = connection
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
    Private Sub kasiyer_kontrol()
        Dim sonuc As Boolean = False
        Dim dr As DataRow
        For Each dr In ds_kasiyer.Tables(0).Rows
            If dr("SIFRE") = txt_kasiyer_kod.Text Then
                sKasiyerRumuzu = dr("IND")
                sKasiyer = dr("KASIYER")
                sMagaza = dr("DEPO")
                bIptalYapabilirmi = dr("bIptalYapabilirmi")
                bVadeFarksizOdemeAlirmi = dr("bVadeFarksizOdemeAlirmi")
                nMaxIskontoYuzdesi = dr("nMaxIskontoYuzdesi")
                sonuc = True
            End If
        Next
        If sonuc = True Then
            lbl_kasiyer.Text = sKasiyer
            sec_magaza.EditValue = sMagaza
            txt_kasiyer_kod.Enabled = False
            SimpleButton1.Enabled = True
            PanelControl2.Enabled = True
        ElseIf sonuc = False Then
            lbl_kasiyer.Text = ""
            txt_kasiyer_kod.Enabled = True
            txt_kasiyer_kod.EditValue = ""
            SimpleButton1.Enabled = False
            PanelControl2.Enabled = False
            If XtraMessageBox.Show(Sorgu_sDil("Þifre Hatalý Lütfen Tekrar Deneyiniz...!", sDil), Sorgu_sDil("Dikkat", sDil), MessageBoxButtons.OK, MessageBoxIcon.Information) Then
                txt_kasiyer_kod.Focus()
                txt_kasiyer_kod.SelectAll()
            End If
        End If
        dr = Nothing
        sonuc = Nothing
    End Sub
    Private Sub musteri_kontrol()
        If Trim(txt_musterino.Text).ToString <> "" And IsNumeric(Trim(txt_musterino.Text)) = True Then
            Dim kontrol = sorgu_cari_kontrol(txt_musterino.EditValue)
            If kontrol = 0 Then
                XtraMessageBox.Show(Sorgu_sDil("Kayýt Bulunumadý...", sDil), Sorgu_sDil("Dikkat", sDil), MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            ElseIf kontrol = 1 Then
                dataload_cari(txt_musterino.EditValue)
                Dim dr As DataRow
                For Each dr In ds_cari.Tables(0).Rows
                    'txt_Musteri.EditValue = dr("MUSTERI")
                    lKodu = dr("MUSTERIKODU")
                    nMusteriID = dr("IND")
                    lbl_musteri_adi.Text = dr("MUSTERI")
                    sAdi = dr("sAdi")
                    sSoyadi = dr("sSoyadi")
                    sAdres1 = dr("sAdres1")
                    sAdres2 = dr("sAdres2")
                    'dataload(nMusteriID)
                Next
                dr = Nothing
            End If
        Else
            XtraMessageBox.Show(Sorgu_sDil("Lütfen Sayýsal Veri Giriniz...!", sDil), Sorgu_sDil("Dikkat", sDil), MessageBoxButtons.OK, MessageBoxIcon.Information)
            txt_musterino.Focus()
            txt_musterino.SelectAll()
        End If
    End Sub
    Private Sub dataload_cari(ByVal kod As String)
        Dim kriter
        kriter = "WHERE (lKodu = '" & kod & "') "
        ds_cari = sorgu(sorgu_query("SELECT     nMusteriID AS IND, lKodu AS MUSTERIKODU,sAdi,sSoyadi, sAdi + ' ' + sSoyadi AS MUSTERI,sEvAdresi1 as sAdres1, sEvAdresi2 as sAdres2 FROM         tbMusteri " & kriter & ""))
    End Sub
    Private Sub musteri_sec()
        If Trim(sKasiyerRumuzu.ToString) <> "" Then
            Dim frm As New frm_musteri_liste
            frm.firmano = firmano
            frm.donemno = donemno
            frm.connection = connection
            'frm.musterino = dr_baslik("FIRMAKODU")
            frm.islemstatus = True
            frm.kullanici = kullanici
            If frm.ShowDialog(Me) = Windows.Forms.DialogResult.OK Then
                Dim dr1 As DataRow
                dr1 = frm.GridView1.GetDataRow(frm.GridView1.FocusedRowHandle)
                nMusteriID = dr1("nMusteriID")
                lKodu = dr1("lKodu")
                'lbl_musteri_adi.Text = dr1("Musteri")
                txt_musterino.EditValue = lKodu
                musteri_kontrol()
            End If
        Else
            XtraMessageBox.Show(Sorgu_sDil("Lütfen Kasiyer Bilgilerinizi Giriniz...!", sDil), Sorgu_sDil("Dikkat", sDil), MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txt_kasiyer_kod.Focus()
            txt_kasiyer_kod.SelectAll()
        End If
    End Sub
    Public Function sorgu_cari_kontrol(ByVal kod As String) As Int64
        Dim kriter
        kriter = "WHERE (lKodu = '" & kod & "') "
        Dim conn As New OleDb.OleDbConnection
        Dim cmd As New OleDb.OleDbCommand
        Dim adapter As New OleDb.OleDbDataAdapter
        conn.ConnectionString = connection
        cmd.Connection = conn
        conn.Open()
        cmd.CommandText = sorgu_query("SET DATEFORMAT DMY SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT     ISNULL(COUNT(*), 0) AS KAYIT  FROM         tbMusteri " & kriter & "")
        Dim kayitsayisi = cmd.ExecuteScalar
        Return kayitsayisi
    End Function
    Private Sub txt_kasiyer_kod_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txt_kasiyer_kod.KeyDown
        If e.KeyCode = Keys.Enter Then
            kasiyer_kontrol()
        End If
    End Sub
    Private Sub SimpleButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SimpleButton1.Click
        Me.DialogResult = Windows.Forms.DialogResult.OK
    End Sub
    Private Sub txt_musterino_ButtonPressed(ByVal sender As Object, ByVal e As DevExpress.XtraEditors.Controls.ButtonPressedEventArgs) Handles txt_musterino.ButtonPressed
        musteri_sec()
    End Sub
    Private Sub txt_musterino_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txt_musterino.KeyDown
        If e.KeyCode = Keys.Enter Then
            musteri_kontrol()
            SimpleButton1.Focus()
            SimpleButton1.Select()
        ElseIf e.KeyCode = Keys.F6 Then
            musteri_sec()
        ElseIf e.KeyCode = Keys.Space Then
            Dim deger = ""
            deger = InputBox("MüþteriNumarasýný Okutun", "MüþteriKartOkut", "").ToString
            If deger.ToString <> "" Then
                txt_musterino.Text = CType(Microsoft.VisualBasic.Left(deger, Len(deger) - 1), Decimal)
                musteri_kontrol()
            End If
            deger = Nothing
        End If
    End Sub
    Private Sub BarButtonItem1_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem1.ItemClick
        musteri_sec()
    End Sub
    Private Sub BarButtonItem2_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem2.ItemClick
        Me.Close()
    End Sub
    Private Sub SimpleButton17_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        SendKeys.Send("7")
    End Sub
    Private Sub SimpleButton3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        SendKeys.Send("8")
    End Sub
    Private Sub SimpleButton4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        SendKeys.Send("9")
    End Sub
    Private Sub SimpleButton5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        SendKeys.Send("{BACKSPACE}")
    End Sub
    Private Sub SimpleButton8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        SendKeys.Send("4")
    End Sub
    Private Sub SimpleButton7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        SendKeys.Send("5")
    End Sub
    Private Sub SimpleButton6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        SendKeys.Send("6")
    End Sub
    Private Sub SimpleButton15_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        SendKeys.Send("{ESCAPE}")
    End Sub
    Private Sub SimpleButton11_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        SendKeys.Send("1")
    End Sub
    Private Sub SimpleButton10_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        SendKeys.Send("2")
    End Sub
    Private Sub SimpleButton9_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        SendKeys.Send("3")
    End Sub
    Private Sub SimpleButton14_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        SendKeys.Send("0")
    End Sub
    Private Sub SimpleButton13_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        SendKeys.Send("*")
    End Sub
    Private Sub SimpleButton12_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        SendKeys.Send(".")
    End Sub
    Private Sub SimpleButton16_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        SendKeys.Send("{ENTER}")
    End Sub
    Private Sub LabelControl3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lbl_7.Click
        SendKeys.Send("7")
    End Sub
    Private Sub lbl_8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lbl_8.Click
        SendKeys.Send("8")
    End Sub
    Private Sub lbl_9_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lbl_9.Click
        SendKeys.Send("9")
    End Sub
    Private Sub lbl_BACKSPACE_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lbl_BACKSPACE.Click
        SendKeys.Send("{BACKSPACE}")
    End Sub
    Private Sub lbl_4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lbl_4.Click
        SendKeys.Send("4")
    End Sub
    Private Sub lbl_5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lbl_5.Click
        SendKeys.Send("5")
    End Sub
    Private Sub lbl_6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lbl_6.Click
        SendKeys.Send("6")
    End Sub
    Private Sub lbl_1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lbl_1.Click
        SendKeys.Send("1")
    End Sub
    Private Sub lbl_2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lbl_2.Click
        SendKeys.Send("2")
    End Sub
    Private Sub lbl_3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lbl_3.Click
        SendKeys.Send("3")
    End Sub
    Private Sub lbl_0_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lbl_0.Click
        SendKeys.Send("0")
    End Sub
    Private Sub lbl_x_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lbl_x.Click
        SendKeys.Send("x")
    End Sub
    Private Sub lbl_Dot_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lbl_Dot.Click
        SendKeys.Send(".")
    End Sub
    Private Sub lbl_Clear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lbl_Clear.Click
        SendKeys.Send("{ESCAPE}")
    End Sub
    Private Sub lbl_Enter_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lbl_Enter.Click
        SendKeys.Send("{ENTER}")
    End Sub
End Class