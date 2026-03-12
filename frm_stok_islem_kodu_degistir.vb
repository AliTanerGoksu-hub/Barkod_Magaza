Imports Microsoft.Win32
Imports DevExpress.XtraEditors
Public Class frm_stok_islem_kodu_degistir
    Dim kriter As String = ""
    Dim mesaj As String = ""
    Dim sorguC As SorguClass = New SorguClass
    Private Sub frm_stok_islem_kodu_degistir_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        PanelControl2.Visible = False
        eskiIslemKodu.Properties.DataSource = sorguC.sorgu_DS(sorgu_query("SELECT sStokIslem, sAciklama FROM tbStokIslem")).Tables(0)
        yeniIslemKodu.Properties.DataSource = sorguC.sorgu_DS(sorgu_query("SELECT sStokIslem, sAciklama FROM tbStokIslem")).Tables(0)
        fisTipi.Properties.DataSource = sorguC.sorgu_DS(sorgu_query("SELECT sFisTipi, sAciklama FROM tbFisTipi")).Tables(0)
        depoKodu.Properties.DataSource = sorguC.sorgu_DS(sorgu_query("SELECT sDepo, sAciklama FROM tbDepo")).Tables(0)
        fisTarih1.EditValue = Today
        fisTarih2.EditValue = Today
    End Sub
    Private Sub SimpleButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SimpleButton1.Click
        If CheckEdit1.Checked = True Then
            kriter = "(sStokIslem = '" & Trim(eskiIslemKodu.Text) & "')"
            mesaj = "Eski Ýþlem Kodu: " & Trim(eskiIslemKodu.Text) & "," & vbCrLf & "Yeni Ýþlem Kodu: " & Trim(yeniIslemKodu.Text)
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
            If depoKoduF.Checked = True Then
                kriter += " AND (sDepo = '" & Trim(depoKodu.Text) & "')"
                mesaj += "," & vbCrLf & "Depo Kodu: " & Trim(depoKodu.Text)
            End If
            mesaj += vbCrLf & "Ýþlemi Onaylýyormusunuz...?"
            If XtraMessageBox.Show(mesaj, Sorgu_sDil("Dikkat", sDil), MessageBoxButtons.YesNo, MessageBoxIcon.Question) = MsgBoxResult.Yes Then
                PanelControl2.Visible = True
                PanelControl2.BringToFront()
                Me.Enabled = False
                sorguC.sorgu_tam("SET DATEFORMAT DMY Update tbStokFisiDetayi Set sStokIslem = '" & Trim(yeniIslemKodu.Text) & "' Where " & kriter)
                sorguC.sorgu_Destek("Stok Ýþlem Kodu Deðiþtirme", mesaj.Substring(0, mesaj.Length - 27), "SimpleButton1_Click()", "frm_stok_islem_kodu_degistir.vb")
                MessageBox.Show("Stok iþlem kodu deðiþtirme iþlemi baþarýlý.", "Business Smart")
                PanelControl2.Visible = False
                Me.Enabled = True
                Me.Close()
            End If
        Else
            If XtraMessageBox.Show("Eski Ýþlem Kodu: " & Trim(eskiIslemKodu.Text) & "," & vbCrLf & "Yeni Ýþlem Kodu: " & Trim(yeniIslemKodu.Text) & vbCrLf & "Ýþlemi Onaylýyormusunuz...?", Sorgu_sDil("Dikkat", sDil), MessageBoxButtons.YesNo, MessageBoxIcon.Question) = MsgBoxResult.Yes Then
                PanelControl2.Visible = True
                PanelControl2.BringToFront()
                Me.Enabled = False
                sorguC.sorgu_tam("Update tbStokFisiDetayi Set sStokIslem = '" & Trim(yeniIslemKodu.Text) & "' Where sStokIslem = '" & Trim(eskiIslemKodu.Text) & "'")
                sorguC.sorgu_Destek("Stok Ýþlem Kodu Deðiþtirme", "Eski Ýþlem Kodu: " & Trim(eskiIslemKodu.Text) & ", Yeni Ýþlem Kodu: " & Trim(yeniIslemKodu.Text) & "", "SimpleButton1_Click()", "frm_stok_islem_kodu_degistir.vb")
                MessageBox.Show("Stok iþlem kodu deðiþtirme iþlemi baþarýlý.", "Business Smart")
                PanelControl2.Visible = False
                Me.Enabled = True
                Me.Close()
            End If
        End If
    End Sub
    Private Sub SimpleButton2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SimpleButton2.Click
        Me.Close()
    End Sub
    Private Sub LookUpEdit1_EditValueChanged(sender As System.Object, e As System.EventArgs) Handles eskiIslemKodu.EditValueChanged
        eskiIslemAciklama.Text = eskiIslemKodu.Properties.GetDataSourceValue("sAciklama", eskiIslemKodu.ItemIndex)
    End Sub
    Private Sub LookUpEdit2_EditValueChanged(sender As System.Object, e As System.EventArgs) Handles yeniIslemKodu.EditValueChanged
        yeniIslemAciklama.Text = yeniIslemKodu.Properties.GetDataSourceValue("sAciklama", yeniIslemKodu.ItemIndex)
    End Sub
    Private Sub depoKodu_EditValueChanged(sender As System.Object, e As System.EventArgs) Handles depoKodu.EditValueChanged
        depoAciklama.Text = depoKodu.Properties.GetDataSourceValue("sAciklama", depoKodu.ItemIndex)
    End Sub
    Private Sub CheckEdit1_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles CheckEdit1.CheckedChanged
        If CheckEdit1.Checked = True Then
            PanelControl1.Enabled = True
        Else
            PanelControl1.Enabled = False
        End If
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
    Private Sub depoKoduF_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles depoKoduF.CheckedChanged
        depoKodu.Enabled = depoKoduF.Checked
    End Sub
End Class