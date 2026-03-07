Imports Microsoft.Win32
Imports DevExpress.XtraEditors
Public Class frm_depo_firma_kodu_degistir
    Dim sorguC As SorguClass = New SorguClass
    Private Sub frm_fis_depo_kodu_degistir_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        PanelControl2.Visible = False
        depoKodu.Properties.DataSource = sorgu(sorgu_query("Select sDepo, sAciklama, nFirmaID, (Select sAciklama From tbFirma Where tbFirma.nFirmaID = tbDepo.nFirmaID) as sFirmaAciklama from tbDepo")).Tables(0)
    End Sub
    Private Sub SimpleButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SimpleButton1.Click
        If XtraMessageBox.Show("Depo Kodu: " & Trim(depoKodu.Text) & "," & vbCrLf & "Eski Firma Kodu: " & Trim(eskiFirmaKodu.Text) & "," & vbCrLf & "Yeni Firma Kodu: " & Trim(sec_tbFirma.Text) & vbCrLf & "Ýþlemi Onaylýyormusunuz...?", Sorgu_sDil("Dikkat", sDil), MessageBoxButtons.YesNo, MessageBoxIcon.Question) = MsgBoxResult.Yes Then
            PanelControl2.Visible = True
            PanelControl2.BringToFront()
            Me.Enabled = False
            sorguC.sorgu_tam("SET DATEFORMAT DMY Update tbDepo Set nFirmaID = '" & Trim(sec_tbFirma.Text) & "' Where sDepo = '" & Trim(depoKodu.Text) & "'")
            sorguC.sorgu_Destek("Depo Firma Kodu Deðiþtirme", "Depo Kodu: " & Trim(depoKodu.Text) & ", Eski Firma Kodu: " & Trim(eskiFirmaKodu.Text) & ", Yeni Firma Kodu: " & Trim(sec_tbFirma.Text), "SimpleButton1_Click()", "frm_depo_firma_kodu_degistir.vb")
            MessageBox.Show("Depo firma kodu deðiþtirme iþlemi baþarýlý.", "Business Smart")
            PanelControl2.Visible = False
            Me.Enabled = True
            Me.Close()
        End If
    End Sub
    Private Sub SimpleButton2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SimpleButton2.Click
        Me.Close()
    End Sub
    Private Sub LookUpEdit1_EditValueChanged(sender As System.Object, e As System.EventArgs) Handles depoKodu.EditValueChanged
        depoAciklama.Text = depoKodu.Properties.GetDataSourceValue("sAciklama", depoKodu.ItemIndex)
        eskiFirmaKodu.Text = depoKodu.Properties.GetDataSourceValue("nFirmaID", depoKodu.ItemIndex)
        eskiFirmaAciklama.Text = depoKodu.Properties.GetDataSourceValue("sFirmaAciklama", depoKodu.ItemIndex)
    End Sub
    Private Sub sec_tbFirma_ButtonClick(sender As System.Object, e As DevExpress.XtraEditors.Controls.ButtonPressedEventArgs) Handles sec_tbFirma.ButtonClick
        Dim frm As New frm_firma_liste
        frm.firmano = firmano
        frm.donemno = donemno
        frm.connection = connection
        frm.islemstatus = True
        frm.sModul = "Cari"
        If frm.ShowDialog(Me) = Windows.Forms.DialogResult.OK Then
            Dim dr1 As DataRow
            dr1 = frm.GridView1.GetDataRow(frm.GridView1.FocusedRowHandle)
            sec_tbFirma.Text = dr1("nFirmaID")
            yeniFirmaAciklama.Text = dr1("sAciklama")
            dr1 = Nothing
        End If
    End Sub
End Class