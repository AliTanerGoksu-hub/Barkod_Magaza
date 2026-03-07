Imports Microsoft.Win32
Imports DevExpress.XtraEditors
Public Class frm_depo_hareket_sil
    Dim kriter As String = ""
    Dim mesaj As String = ""
    Dim sorguC As SorguClass = New SorguClass
    Private Sub frm_fis_depo_kodu_degistir_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        PanelControl2.Visible = False
        depoKodu.Properties.DataSource = sorguC.sorgu_DS(sorgu_query("SELECT sDepo, sAciklama FROM tbDepo")).Tables(0)
        fisTipi.Properties.DataSource = sorguC.sorgu_DS(sorgu_query("SELECT sFisTipi, sAciklama FROM tbFisTipi")).Tables(0)
        fisTarih1.EditValue = Today
        fisTarih2.EditValue = Today
    End Sub
    Private Sub SimpleButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SimpleButton1.Click
        If CheckEdit1.Checked = True Then
            kriter = "(sDepo = '" & Trim(depoKodu.Text) & "')"
            mesaj = "Depo Kodu: " & Trim(depoKodu.Text)
            If fisTipiF.Checked = True Then
                If Trim(fisTipi.Text) <> "" Then
                    kriter += " AND (sFisTipi = '" & Trim(fisTipi.Text) & "')"
                    mesaj += "," & vbCrLf & "Fiþ Tipi: " & Trim(fisTipi.Text)
                End If
            End If
            If fisTarihiF.Checked = True Then
                kriter += " AND (dteFisTarihi Between '" & fisTarih1.Text & "' AND '" & fisTarih2.Text & "')"
                mesaj += "," & vbCrLf & "Fiþ Tarih Aralýðý: " & fisTarih1.Text & "-" & fisTarih2.Text
            End If
            If fisNoF.Checked = True Then
                kriter += " AND (lFisNo Between " & fisNoBas.Text & " AND " & fisNoBit.Text & ")"
                mesaj += "," & vbCrLf & "Fiþ Numarasý Aralýðý: " & fisNoBas.Text & "-" & fisNoBit.Text
            End If
            mesaj += vbCrLf & "Olan tüm hareketler silinecektir!" & vbCrLf & "Ýþlemi Onaylýyormusunuz...?"
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
                sorguC.sorgu_Destek("Depo Hareketleri Silme", "" & mesaj.Substring(0, mesaj.Length - 63) & " Olan tüm hareketler silindi.", "SimpleButton1_Click()", "frm_depo_hareket_sil.vb")
                MessageBox.Show("Depo hareketleri silem iþlemi baþarýlý.", "Business Smart")
                PanelControl2.Visible = False
                Me.Enabled = True
                Me.Close()
            End If
        Else
            If XtraMessageBox.Show("Depo Kodu: " & Trim(depoKodu.Text) & vbCrLf & "Olan tüm hareketler silinecektir!" & vbCrLf & "Ýþlemi Onaylýyormusunuz...?", Sorgu_sDil("Dikkat", sDil), MessageBoxButtons.YesNo, MessageBoxIcon.Question) = MsgBoxResult.Yes Then
                PanelControl2.Visible = True
                PanelControl2.BringToFront()
                Me.Enabled = False
                sorguC.sorgu_tam("IF EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_tbStokFisiDetayi_nStokFisiID]') AND parent_object_id = OBJECT_ID(N'[dbo].[tbStokFisiDetayi]')) ALTER TABLE [dbo].[tbStokFisiDetayi] DROP CONSTRAINT [FK_tbStokFisiDetayi_nStokFisiID]")
                sorguC.sorgu_tam("SET DATEFORMAT DMY delete tbStokFisiAciklamasi from tbStokFisiMaster where (tbStokFisiMaster.nStokFisiID = tbStokFisiAciklamasi.nStokFisiID) AND (sDepo = '" & Trim(depoKodu.Text) & "')")
                sorguC.sorgu_tam("SET DATEFORMAT DMY delete tbStokFisiMaster Where (sDepo = '" & Trim(depoKodu.Text) & "')")
                sorguC.sorgu_tam("SET DATEFORMAT DMY delete tbStokFisiSeriNo from tbStokFisiDetayi Where (tbStokFisiDetayi.nIslemID = tbStokFisiSeriNo.nIslemID) AND (sDepo = '" & Trim(depoKodu.Text) & "')")
                sorguC.sorgu_tam("SET DATEFORMAT DMY delete tbStokFisiDetayi Where (sDepo = '" & Trim(depoKodu.Text) & "')")
                sorguC.sorgu_tam("ALTER TABLE [dbo].[tbStokFisiDetayi] WITH NOCHECK ADD CONSTRAINT [FK_tbStokFisiDetayi_nStokFisiID] FOREIGN KEY([nStokFisiID]) REFERENCES [dbo].[tbStokFisiMaster] ([nStokFisiID]) ALTER TABLE [dbo].[tbStokFisiDetayi] CHECK CONSTRAINT [FK_tbStokFisiDetayi_nStokFisiID]")
                sorguC.sorgu_Destek("Depo Hareketleri Silme", "Depo Kodu: " & Trim(depoKodu.Text) & " Olan tüm hareketler silindi.", "SimpleButton1_Click()", "frm_depo_hareket_sil.vb")
                MessageBox.Show("Depo hareketleri silme iþlemi baþarýlý.", "Business Smart")
                PanelControl2.Visible = False
                Me.Enabled = True
                Me.Close()
            End If
        End If
    End Sub
    Private Sub SimpleButton2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SimpleButton2.Click
        Me.Close()
    End Sub
    Private Sub LookUpEdit1_EditValueChanged(sender As System.Object, e As System.EventArgs) Handles depoKodu.EditValueChanged
        depoAciklama.Text = depoKodu.Properties.GetDataSourceValue("sAciklama", depoKodu.ItemIndex)
    End Sub
    Private Sub CheckEdit1_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles CheckEdit1.CheckedChanged
        PanelControl1.Enabled = CheckEdit1.Checked
    End Sub
    Private Sub fisTipi_EditValueChanged(sender As System.Object, e As System.EventArgs) Handles fisTipi.EditValueChanged
        fisTipiAciklama.Text = fisTipi.Properties.GetDataSourceValue("sAciklama", fisTipi.ItemIndex)
    End Sub
    Private Sub fisTipiF_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles fisTipiF.CheckedChanged
        fisTipi.Enabled = fisTipiF.Checked
    End Sub
    Private Sub fisTarihiF_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles fisTarihiF.CheckedChanged
        fisTarih1.Enabled = fisTarihiF.Checked
        fisTarih2.Enabled = fisTarihiF.Checked
    End Sub
    Private Sub fisNoF_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles fisNoF.CheckedChanged
        fisNoBas.Enabled = fisNoF.Checked
        fisNoBit.Enabled = fisNoF.Checked
    End Sub
End Class