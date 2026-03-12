Imports Microsoft.Win32
Imports DevExpress.XtraEditors
Public Class frm_pesin_satis_sil
    Dim kriter As String = ""
    Dim mesaj As String = ""
    Dim sorguC As SorguClass = New SorguClass
    Private Sub frm_fis_depo_kodu_degistir_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        PanelControl2.Visible = False
        depoKodu.Properties.DataSource = sorguC.sorgu_DS(sorgu_query("Select sDepo, sAciklama from tbDepo")).Tables(0)
        fisTarih1.EditValue = Today
        fisTarih2.EditValue = Today
    End Sub
    Private Sub SimpleButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SimpleButton1.Click
        kriter = "(sFisTipi = 'P') AND (sDepo = '" & Trim(depoKodu.Text) & "')"
        mesaj = "Depo Kodu: " & Trim(depoKodu.Text)
        If fisTarihiF.Checked = True Then
            kriter += " AND (dteFisTarihi Between '" & fisTarih1.Text & "' AND '" & fisTarih2.Text & "')"
            mesaj += "," & vbCrLf & "Fiþ Tarih Aralýðý: " & fisTarih1.Text & "-" & fisTarih2.Text
        End If
        mesaj += vbCrLf & "Olan tüm peþin satýþlar silinecektir!" & vbCrLf & "Ýþlemi Onaylýyormusunuz...?"
        If XtraMessageBox.Show(mesaj, Sorgu_sDil("Dikkat", sDil), MessageBoxButtons.YesNo, MessageBoxIcon.Question) = MsgBoxResult.Yes Then
            PanelControl2.Visible = True
            PanelControl2.BringToFront()
            Me.Enabled = False
            sorguC.sorgu_tam("IF EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_tbStokFisiDetayi_nStokFisiID]') AND parent_object_id = OBJECT_ID(N'[dbo].[tbStokFisiDetayi]')) ALTER TABLE [dbo].[tbStokFisiDetayi] DROP CONSTRAINT [FK_tbStokFisiDetayi_nStokFisiID]")
            sorguC.sorgu_tam("SET DATEFORMAT DMY delete tbStokFisiAciklamasi from tbStokFisiMaster where (tbStokFisiMaster.nStokFisiID = tbStokFisiAciklamasi.nStokFisiID) AND " & kriter)
            sorguC.sorgu_tam("SET DATEFORMAT DMY delete tbStokFisiMaster Where " & kriter)
            sorguC.sorgu_tam("SET DATEFORMAT DMY delete tbStokFisiSeriNo from tbStokFisiDetayi Where (tbStokFisiDetayi.nIslemID = tbStokFisiSeriNo.nIslemID) AND " & kriter)
            sorguC.sorgu_tam("SET DATEFORMAT DMY delete tbStokFisiDetayi Where " & kriter)
            sorguC.sorgu_tam("ALTER TABLE [dbo].[tbStokFisiDetayi] WITH NOCHECK ADD CONSTRAINT [FK_tbStokFisiDetayi_nStokFisiID] FOREIGN KEY([nStokFisiID]) REFERENCES [dbo].[tbStokFisiMaster] ([nStokFisiID]) ALTER TABLE [dbo].[tbStokFisiDetayi] CHECK CONSTRAINT [FK_tbStokFisiDetayi_nStokFisiID]")
            sorguC.sorgu_Destek("Peþin Satýþ Silme", "" & mesaj.Substring(0, mesaj.Length - 67) & " Olan tüm peþin satýþlar silindi.", "SimpleButton1_Click()", "frm_pesin_satis_sil.vb")
            MessageBox.Show("Peþin satýþ silme iþlemi baþarýlý.", "Business Smart")
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
    End Sub
    Private Sub fisTarihiF_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles fisTarihiF.CheckedChanged
        fisTarih1.Enabled = fisTarihiF.Checked
        fisTarih2.Enabled = fisTarihiF.Checked
    End Sub
End Class