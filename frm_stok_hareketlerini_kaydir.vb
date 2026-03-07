Imports Microsoft.Win32
Imports DevExpress.XtraEditors
Public Class frm_stok_hareketlerini_kaydir
    Dim nStokID As String = ""
    Dim sAciklama As String = ""
    Dim sorguC As SorguClass = New SorguClass
    Private Sub frm_stok_kodu_degistir_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        PanelControl2.Visible = False
    End Sub
    Private Sub temizle()
        nStokID = ""
        sAciklama = ""
        txt_eskiModel.Text = ""
        txt_sKisaAdi.Text = ""
        LabelControl4.Text = ""
        txt_sKisaAdi.Enabled = False
        TamamB.Enabled = False
        txt_eskiModel.Enabled = True
    End Sub
    Private Sub SimpleButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SimpleButton1.Click
        If XtraMessageBox.Show("Eski Stok ID: " & Trim(txt_eskiModel.Text) & " Numaralý Hareketleri, " & vbCrLf & "Yeni Stok ID: " & Trim(txt_sKisaAdi.Text) & vbCrLf & " Kayýt Numarasý ile Deðiþtirmek Ýstediðinize Eminmisiniz...?", Sorgu_sDil("Dikkat", sDil), MessageBoxButtons.YesNo, MessageBoxIcon.Question) = MsgBoxResult.Yes Then
            PanelControl2.Visible = True
            PanelControl2.BringToFront()
            Me.Enabled = False
            sorguC.sorgu_tam("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED Update tbAlisVerisSiparis set nStokID = " & Trim(txt_sKisaAdi.Text) & " Where nStokID = " & Trim(txt_eskiModel.Text) & "")
            sorguC.sorgu_tam("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED Update tbStokFisiDetayi set nStokID = " & Trim(txt_sKisaAdi.Text) & " Where nStokID = " & Trim(txt_eskiModel.Text) & "")
            sorguC.sorgu_tam("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED Update tbSiparis set nStokID = " & Trim(txt_sKisaAdi.Text) & " Where nStokID = " & Trim(txt_eskiModel.Text) & "")
            sorguC.sorgu_tam("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED Update tbProtokol set nStokID = " & Trim(txt_sKisaAdi.Text) & " Where nStokID = " & Trim(txt_eskiModel.Text) & "")
            sorguC.sorgu_Destek("Stok Hareketleri Kaydýrma", "Eski Stok ID: " & Trim(txt_eskiModel.Text) & ", Yeni Stok ID: " & Trim(txt_sKisaAdi.Text) & "", "SimpleButton1_Click()", "frm_stok_hareketlerini_kaydir.vb")
            temizle()
            MessageBox.Show("Stok Hareketleri Kaydýrma iþlemi baþarýlý.", "Business Smart")
            PanelControl2.Visible = False
            Me.Enabled = True
        End If
    End Sub
    Private Sub SimpleButton2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SimpleButton2.Click
        Me.Close()
    End Sub
    Private Sub txt_eskiModel_ButtonClick(sender As System.Object, e As DevExpress.XtraEditors.Controls.ButtonPressedEventArgs) Handles txt_eskiModel.ButtonClick
        Dim frm As New frm_stok_liste
        frm.firmano = firmano
        frm.donemno = donemno
        frm.connection = connection
        frm.islemstatus = True
        frm.kullanici = kullanici
        nStokID = ""
        sAciklama = ""
        If frm.ShowDialog(Me) = Windows.Forms.DialogResult.OK Then
            Dim dr1 As DataRow
            dr1 = frm.GridView1.GetDataRow(frm.GridView1.FocusedRowHandle)
            nStokID = Trim(dr1("nStokID"))
            sAciklama = Trim(dr1("sAciklama"))
            txt_eskiModel.EditValue = Trim(nStokID)
            dr1 = Nothing
        End If
    End Sub
    Private Sub txt_eskiModel_TextChanged(sender As System.Object, e As System.EventArgs) Handles txt_eskiModel.TextChanged
        If txt_eskiModel.Text.Length >= 1 Then
            TamamB.Enabled = True
        Else
            TamamB.Enabled = False
        End If
    End Sub
    Private Sub TamamB_Click(sender As System.Object, e As System.EventArgs) Handles TamamB.Click
        If Trim(nStokID) = "" Then
            sAciklama = sorguC.sorgu("Select sAciklama From tbStok Where nStokID = '" & Trim(txt_eskiModel.Text) & "'")
        End If
        If Trim(nStokID) = "" Then
            MessageBox.Show("Bu ID numarasýna sahip bir kayýt bulunamadý.", "Business Smart")
        Else
            LabelControl4.Text = sAciklama
            txt_sKisaAdi.Enabled = True
            SimpleButton3.Enabled = True
            TamamB.Enabled = False
            txt_eskiModel.Enabled = False
        End If
    End Sub
    Private Sub txt_sKisaAdi_ButtonClick(sender As System.Object, e As DevExpress.XtraEditors.Controls.ButtonPressedEventArgs) Handles txt_sKisaAdi.ButtonClick
        Dim frm As New frm_stok_liste
        frm.firmano = firmano
        frm.donemno = donemno
        frm.connection = connection
        frm.islemstatus = True
        frm.kullanici = kullanici
        nStokID = ""
        sAciklama = ""
        If frm.ShowDialog(Me) = Windows.Forms.DialogResult.OK Then
            Dim dr1 As DataRow
            dr1 = frm.GridView1.GetDataRow(frm.GridView1.FocusedRowHandle)
            sAciklama = Trim(dr1("sAciklama"))
            txt_sKisaAdi.EditValue = Trim(dr1("nStokID"))
            dr1 = Nothing
        End If
    End Sub
    Private Sub SimpleButton3_Click(sender As System.Object, e As System.EventArgs) Handles SimpleButton3.Click
        If Trim(txt_sKisaAdi.EditValue) = "" Then
            sAciklama = sorguC.sorgu("Select sAciklama From tbStok Where nStokID = '" & Trim(txt_sKisaAdi.Text) & "'")
        End If
        If Trim(Trim(txt_sKisaAdi.EditValue)) = "" Then
            MessageBox.Show("Bu ID numarasýna sahip bir kayýt bulunamadý.", "Business Smart")
        Else
            LabelControl2.Text = sAciklama
            txt_sKisaAdi.Enabled = False
            SimpleButton3.Enabled = False
            SimpleButton1.Enabled = True
        End If
    End Sub
End Class