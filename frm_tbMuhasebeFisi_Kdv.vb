Imports Microsoft.Win32
Imports DevExpress.XtraEditors
Public Class frm_tbMuhasebeFisi_Kdv
    Public firmano
    Public donemno
    Public connection
    Public kullanici
    Public nHesapID As Int64 = 0
    Public sKodu As String = ""
    Public sAciklama As String = ""
    Public lKdvMatrahi As Decimal = 0
    Public lKdvTutari As Decimal = 0
    Public nKdvOrani As Decimal = 0
    Public bAlacak As Boolean = False
    Dim bLoad As Boolean = False
    Dim ds_cari As DataSet
    Private Sub SimpleButton2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SimpleButton2.Click
        Me.Close()
    End Sub
    Private Sub SimpleButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SimpleButton1.Click
        kontrol()
    End Sub
    Private Sub kontrol()
        If nHesapID = 0 Then
        Else
            lKdvTutari = txt_lKdv.EditValue
            sAciklama = lbl_sAciklama.Text
            Me.DialogResult = Windows.Forms.DialogResult.OK
        End If
    End Sub
    Private Sub frm_tbMuhasebeFisi_Kdv_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        Registry.CurrentUser.CreateSubKey("Software").CreateSubKey("BusinessSmart").CreateSubKey("VIEW").CreateSubKey("MUHASEBE").CreateSubKey("Muhasebe_Kdv").CreateSubKey(bAlacak).SetValue("sKdvTipi", sec_sKdvTipi.Text)
        Registry.CurrentUser.CreateSubKey("Software").CreateSubKey("BusinessSmart").CreateSubKey("VIEW").CreateSubKey("MUHASEBE").CreateSubKey("Muhasebe_Kdv").CreateSubKey(bAlacak).SetValue("nKdvOrani", txt_nKdvOrani.Text)
        Registry.CurrentUser.CreateSubKey("Software").CreateSubKey("BusinessSmart").CreateSubKey("VIEW").CreateSubKey("MUHASEBE").CreateSubKey("Muhasebe_Kdv").CreateSubKey(bAlacak).SetValue("sKodu", txt_musterino.Text)
        Registry.CurrentUser.CreateSubKey("Software").CreateSubKey("BusinessSmart").CreateSubKey("VIEW").CreateSubKey("MUHASEBE").CreateSubKey("Muhasebe_Kdv").CreateSubKey(bAlacak).SetValue("nHesapID", nHesapID)
        Registry.CurrentUser.CreateSubKey("Software").CreateSubKey("BusinessSmart").CreateSubKey("VIEW").CreateSubKey("MUHASEBE").CreateSubKey("Muhasebe_Kdv").CreateSubKey(bAlacak).SetValue("sAciklama", lbl_sAciklama.Text)
    End Sub
    Private Sub frm_tbMuhasebeFisi_Kdv_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            sec_sKdvTipi.EditValue = Registry.CurrentUser.OpenSubKey("Software").OpenSubKey("BusinessSmart").OpenSubKey("VIEW").OpenSubKey("MUHASEBE").OpenSubKey("Muhasebe_Kdv").OpenSubKey(bAlacak).GetValue("sKdvTipi").ToString
        Catch ex As Exception
            sec_sKdvTipi.EditValue = "Hariç"
        End Try
        Try
            txt_nKdvOrani.EditValue = Registry.CurrentUser.OpenSubKey("Software").OpenSubKey("BusinessSmart").OpenSubKey("VIEW").OpenSubKey("MUHASEBE").OpenSubKey("Muhasebe_Kdv").OpenSubKey(bAlacak).GetValue("nKdvOrani").ToString
        Catch ex As Exception
            txt_nKdvOrani.EditValue = 8
        End Try
        Try
            txt_musterino.Text = Registry.CurrentUser.OpenSubKey("Software").OpenSubKey("BusinessSmart").OpenSubKey("VIEW").OpenSubKey("MUHASEBE").OpenSubKey("Muhasebe_Kdv").OpenSubKey(bAlacak).GetValue("sKodu").ToString
        Catch ex As Exception
            txt_musterino.Text = ""
        End Try
        Try
            nHesapID = Registry.CurrentUser.OpenSubKey("Software").OpenSubKey("BusinessSmart").OpenSubKey("VIEW").OpenSubKey("MUHASEBE").OpenSubKey("Muhasebe_Kdv").OpenSubKey(bAlacak).GetValue("nHesapID").ToString
        Catch ex As Exception
            nHesapID = 0
        End Try
        Try
            sAciklama = Registry.CurrentUser.OpenSubKey("Software").OpenSubKey("BusinessSmart").OpenSubKey("VIEW").OpenSubKey("MUHASEBE").OpenSubKey("Muhasebe_Kdv").OpenSubKey(bAlacak).GetValue("sAciklama").ToString
        Catch ex As Exception
            sAciklama = ""
        End Try
        txt_lKdvMatrahi.Text = lKdvMatrahi
        txt_lKdv.Text = lKdvTutari
        txt_nKdvOrani.Text = nKdvOrani
        If bAlacak = True Then
            If txt_musterino.Text = "" Then
                txt_musterino.Text = "391"
            End If
        Else
            If txt_musterino.Text = "" Then
                txt_musterino.Text = "191"
            End If
        End If
        txt_nKdvOrani.Focus()
        txt_nKdvOrani.Select()
        bLoad = True
    End Sub
    Private Sub txt_nKdvOrani_EditValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles txt_nKdvOrani.EditValueChanged
        oran_hesapla()
    End Sub
    Private Sub oran_hesapla()
        If bLoad = True Then
            If sec_sKdvTipi.Text = "Dahil" Then
                txt_lKdv.Text = txt_lKdvMatrahi.Text - (txt_lKdvMatrahi.Text / ((100 + txt_nKdvOrani.Text) / 100))
            ElseIf sec_sKdvTipi.Text = "Hariç" Then
                txt_lKdv.Text = txt_lKdvMatrahi.Text * ((txt_nKdvOrani.Text) / 100)
            End If
        End If
    End Sub
    Private Sub musteri_sec()
        Dim frm1 As New frm_HesapPlani_liste
        frm1.firmano = firmano
        frm1.donemno = donemno
        frm1.connection = connection
        frm1.islemstatus = True
        frm1.kullanici = kullanici
        frm1.txt_ara.Text = txt_musterino.Text
        'frm1.sModul = sModul
        If frm1.ShowDialog(Me) = Windows.Forms.DialogResult.OK Then
            Dim dr1 As DataRow = frm1.GridView1.GetDataRow(frm1.GridView1.FocusedRowHandle)
            txt_musterino.Text = dr1("sKodu")
            sKodu = dr1("sKodu")
            nHesapID = dr1("nHesapID")
        End If
        frm1.Close()
        frm1.Dispose()
        frm1 = Nothing
    End Sub
    Private Sub musteri_kontrol()
        If Trim(txt_musterino.EditValue).ToString <> "" Then
            Dim kontrol = sorgu_cari_kontrol(txt_musterino.EditValue)
            If kontrol = 0 Then
                XtraMessageBox.Show(Sorgu_sDil("Kayıt Bulunumadı...", sDil), Sorgu_sDil("Dikkat", sDil), MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            ElseIf kontrol = 1 Then
                dataload_cari(txt_musterino.EditValue)
                Dim dr As DataRow
                For Each dr In ds_cari.Tables(0).Rows
                    'txt_Musteri.EditValue = dr("MUSTERI")
                    sKodu = dr("sKodu")
                    nHesapID = dr("nHesapID")
                    lbl_sAciklama.Text = dr("sAciklama")
                    sAciklama = dr("sAciklama")
                Next
                dr = Nothing
            End If
        End If
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
        cmd.CommandText = sorgu_query("SET DATEFORMAT DMY SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT     ISNULL(COUNT(*), 0) AS KAYIT  FROM         tbHesapPlani " & kriter & "")
        Dim kayitsayisi = cmd.ExecuteScalar
        Return kayitsayisi
    End Function
    Private Sub dataload_cari(ByVal kod As String)
        Dim kriter
        kriter = "WHERE (sKodu = '" & kod & "') "
        ds_cari = sorgu(sorgu_query("SELECT     nHesapID,sKodu,sAciklama FROM         tbHesapPlani " & kriter & ""))
    End Sub
    Private Sub BarButtonItem2_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem2.ItemClick
        Me.Close()
    End Sub
    Private Sub BarButtonItem1_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem1.ItemClick
        kontrol()
    End Sub
    Private Sub txt_musterino_ButtonClick(ByVal sender As Object, ByVal e As DevExpress.XtraEditors.Controls.ButtonPressedEventArgs) Handles txt_musterino.ButtonClick
        musteri_sec()
    End Sub
    Private Sub txt_musterino_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txt_musterino.KeyDown
        If e.KeyCode = Keys.Space Then
            musteri_sec()
        ElseIf e.KeyCode = Keys.F4 Then
            musteri_sec()
        End If
    End Sub
    Private Sub txt_musterino_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles txt_musterino.Validating
        musteri_kontrol()
    End Sub
    Private Sub sec_sKdvTipi_SelectedValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles sec_sKdvTipi.SelectedValueChanged
        oran_hesapla()
    End Sub
End Class