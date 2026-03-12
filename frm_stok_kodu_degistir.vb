Imports Microsoft.Win32
Imports DevExpress.XtraEditors
Public Class frm_stok_kodu_degistir
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
        LabelControl3.Text = ""
        LabelControl4.Text = ""
        SimpleButton1.Enabled = False
        SimpleButton4.Enabled = False
        txt_sKisaAdi.Enabled = False
        TamamB.Enabled = False
        txt_eskiModel.Enabled = True
    End Sub
    Private Sub SimpleButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SimpleButton1.Click
        If XtraMessageBox.Show("Eski Stok Kodu: " & Trim(txt_eskiModel.Text) & "," & vbCrLf & "Yeni Stok Kodu: " & Trim(txt_sKisaAdi.Text) & vbCrLf & "Olarak Deðiþtirmek Ýstediðinize Eminmisiniz...?", Sorgu_sDil("Dikkat", sDil), MessageBoxButtons.YesNo, MessageBoxIcon.Question) = MsgBoxResult.Yes Then
            PanelControl2.Visible = True
            PanelControl2.BringToFront()
            Me.Enabled = False
            sorguC.sorgu_tam("Update tbStok Set sKodu = '" & Trim(txt_sKisaAdi.Text) & "' Where sKodu = '" & Trim(txt_eskiModel.Text) & "'")
            sorguC.sorgu_Destek("Stok Kodu Deðiþtirme", "Eski Stok Kodu: " & Trim(txt_eskiModel.Text) & ", Yeni Stok Kodu: " & Trim(txt_sKisaAdi.Text) & "", "SimpleButton1_Click()", "frm_stok_kodu_degistir.vb")
            temizle()
            MessageBox.Show("Stok kodu deðiþtirme iþlemi baþarýlý.", "Business Smart")
            PanelControl2.Visible = False
            Me.Enabled = True
        End If
    End Sub
    Private Sub SimpleButton2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SimpleButton2.Click
        temizle()
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
            txt_eskiModel.EditValue = Trim(dr1("sKodu"))
            dr1 = Nothing
        Else
            Try
                Me.Close()
            Catch ex As Exception
            End Try
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
            nStokID = sorguC.sorgu("Select nStokID From tbStok Where sKodu = '" & Trim(txt_eskiModel.Text) & "'")
            sAciklama = sorguC.sorgu("Select sAciklama From tbStok Where sKodu = '" & Trim(txt_eskiModel.Text) & "'")
        End If
        If Trim(nStokID) = "" Then
            MessageBox.Show("Bu kod numarasýna sahip bir kayýt bulunamadý.", "Business Smart")
        Else
            LabelControl3.Text = nStokID
            LabelControl4.Text = sAciklama
            txt_sKisaAdi.Enabled = True
            TamamB.Enabled = False
            txt_eskiModel.Enabled = False
        End If
    End Sub
    Private Sub txt_sKisaAdi_TextChanged(sender As System.Object, e As System.EventArgs) Handles txt_sKisaAdi.TextChanged
        SimpleButton1.Enabled = False
        If txt_sKisaAdi.Text.Length >= 1 Then
            SimpleButton4.Enabled = True
        Else
            SimpleButton4.Enabled = False
        End If
    End Sub
    Private Sub SimpleButton4_Click(sender As System.Object, e As System.EventArgs) Handles SimpleButton4.Click
        If Trim(sorguC.sorgu("Select Count(*) From tbStok Where sKodu = '" & Trim(txt_sKisaAdi.Text) & "'")) = "0" Then
            SimpleButton1.Enabled = True
        Else
            SimpleButton1.Enabled = False
            MessageBox.Show("Bu kod numarasý ile zaten bir kayýt var.", "Business Smart")
        End If
    End Sub
End Class