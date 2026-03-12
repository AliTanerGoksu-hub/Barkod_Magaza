Imports Microsoft.Win32
Imports DevExpress.XtraEditors
Public Class frm_satici_seri_degistir
    Dim kriter As String = ""
    Dim mesaj As String = ""
    Dim sorguC As SorguClass = New SorguClass
    Private Sub frm_fis_depo_kodu_degistir_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        PanelControl2.Visible = False
        depoKodu.Properties.DataSource = sorguC.sorgu_DS(sorgu_query("SELECT sDepo, sAciklama FROM tbDepo")).Tables(0)
        fisTipi.Properties.DataSource = sorguC.sorgu_DS(sorgu_query("SELECT sFisTipi, sAciklama FROM tbFisTipi")).Tables(0)
        eskiSaticiKodu.Properties.DataSource = sorguC.sorgu_DS(sorgu_query("SELECT sSaticiRumuzu, (sAdi + ' ' + sSoyadi) as sAdi FROM tbSatici")).Tables(0)
        yeniSaticiKodu.Properties.DataSource = sorguC.sorgu_DS(sorgu_query("SELECT sSaticiRumuzu, (sAdi + ' ' + sSoyadi) as sAdi FROM tbSatici")).Tables(0)
        fisTarih1.EditValue = Today
        fisTarih2.EditValue = Today
    End Sub
    Private Sub SimpleButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SimpleButton1.Click
        If RadioButton1.Checked = True Then
            If CheckEdit1.Checked = True And CheckEdit2.Checked = False Then
                kriter = "(sSaticiRumuzu = '" & Trim(eskiSaticiKodu.Text) & "')"
                mesaj = "Eski Satýcý Kodu: " & Trim(eskiSaticiKodu.Text) & "," & vbCrLf & "Yeni Satýcý Kodu: " & Trim(yeniSaticiKodu.Text)
                If depoKoduF.Checked = True Then
                    kriter += " AND (sDepo = '" & Trim(depoKodu.Text) & "')"
                    mesaj += "," & vbCrLf & "Depo Kodu: " & Trim(depoKodu.Text)
                End If
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
                mesaj += vbCrLf & "Ýþlemi Onaylýyormusunuz...?"
                If XtraMessageBox.Show(mesaj, Sorgu_sDil("Dikkat", sDil), MessageBoxButtons.YesNo, MessageBoxIcon.Question) = MsgBoxResult.Yes Then
                    PanelControl2.Visible = True
                    PanelControl2.BringToFront()
                    Me.Enabled = False
                    sorguC.sorgu_tam("SET DATEFORMAT DMY Update tbStokFisiDetayi Set sSaticiRumuzu = '" & Trim(yeniSaticiKodu.Text) & "' Where " & kriter)
                    sorguC.sorgu_Destek("Satýcý Kodu Deðiþtirme", mesaj.Substring(0, mesaj.Length - 27), "SimpleButton1_Click()", "frm_satici_seri_degistir.vb")
                    MessageBox.Show("Satýcý kodu deðiþtirme iþlemi baþarýlý.", "Business Smart")
                    PanelControl2.Visible = False
                    Me.Enabled = True
                    Me.Close()
                End If
            ElseIf CheckEdit1.Checked = False And CheckEdit2.Checked = True Then
                If Trim(alisverisID.Text) <> "" And Trim(stokKodu.Text) <> "" Then
                    If XtraMessageBox.Show("Eski Satýcý Kodu: " & Trim(eskiSaticiKodu.Text) & "," & vbCrLf & "Yeni Satýcý Kodu: " & Trim(yeniSaticiKodu.Text) & "," & vbCrLf & "Alýþveri Numarasý: " & Trim(alisverisID.Text) & "," & vbCrLf & "Stok Kodu: " & Trim(stokKodu.Text) & vbCrLf & "Ýþlemi Onaylýyormusunuz...?", Sorgu_sDil("Dikkat", sDil), MessageBoxButtons.YesNo, MessageBoxIcon.Question) = MsgBoxResult.Yes Then
                        PanelControl2.Visible = True
                        PanelControl2.BringToFront()
                        Me.Enabled = False
                        sorguC.sorgu_tam("Update tbStokFisiDetayi Set sSaticiRumuzu = '" & Trim(yeniSaticiKodu.Text) & "' Where (sSaticiRumuzu = '" & Trim(eskiSaticiKodu.Text) & "') AND (nAlisverisID = '" & Trim(alisverisID.Text) & "') AND (nStokID = (Select Top 1 nStokID From tbStok Where sKodu = '" & Trim(stokKodu.Text) & "'))")
                        sorguC.sorgu_Destek("Satýcý Kodu Deðiþtirme", "Eski Satýcý Kodu: " & Trim(eskiSaticiKodu.Text) & ", Yeni Satýcý Kodu: " & Trim(yeniSaticiKodu.Text) & ", Alýþveri Numarasý: " & Trim(alisverisID.Text) & ", Stok Kodu: " & Trim(stokKodu.Text) & "", "SimpleButton1_Click()", "frm_satici_seri_degistir.vb")
                        MessageBox.Show("Satýcý kodu deðiþtirme iþlemi baþarýlý.", "Business Smart")
                        PanelControl2.Visible = False
                        Me.Enabled = True
                        Me.Close()
                    End If
                Else
                    MessageBox.Show("Lütfen Alýþveriþ numarasý girerek bir stok seçiniz.", "Business Smart")
                End If
            Else
                If XtraMessageBox.Show("Eski Satýcý Kodu: " & Trim(eskiSaticiKodu.Text) & "," & vbCrLf & "Yeni Satýcý Kodu: " & Trim(yeniSaticiKodu.Text) & vbCrLf & "Ýþlemi Onaylýyormusunuz...?", Sorgu_sDil("Dikkat", sDil), MessageBoxButtons.YesNo, MessageBoxIcon.Question) = MsgBoxResult.Yes Then
                    PanelControl2.Visible = True
                    PanelControl2.BringToFront()
                    Me.Enabled = False
                    sorguC.sorgu_tam("Update tbStokFisiDetayi Set sSaticiRumuzu = '" & Trim(yeniSaticiKodu.Text) & "' Where sSaticiRumuzu = '" & Trim(eskiSaticiKodu.Text) & "'")
                    sorguC.sorgu_Destek("Satýcý Kodu Deðiþtirme", "Eski Satýcý Kodu: " & Trim(eskiSaticiKodu.Text) & ", Yeni Satýcý Kodu: " & Trim(yeniSaticiKodu.Text) & "", "SimpleButton1_Click()", "frm_satici_seri_degistir.vb")
                    MessageBox.Show("Satýcý kodu deðiþtirme iþlemi baþarýlý.", "Business Smart")
                    PanelControl2.Visible = False
                    Me.Enabled = True
                    Me.Close()
                End If
            End If
        Else
            If Trim(alisverisID.Text) <> "" And Trim(stokKodu.Text) <> "" Then
                If XtraMessageBox.Show("Yeni Seri No: " & Trim(yeniSeriNo.Text) & "," & vbCrLf & "Alýþveri Numarasý: " & Trim(alisverisID.Text) & "," & vbCrLf & "Stok Kodu: " & Trim(stokKodu.Text) & vbCrLf & "Ýþlemi Onaylýyormusunuz...?", Sorgu_sDil("Dikkat", sDil), MessageBoxButtons.YesNo, MessageBoxIcon.Question) = MsgBoxResult.Yes Then
                    PanelControl2.Visible = True
                    PanelControl2.BringToFront()
                    Me.Enabled = False
                    sorguC.sorgu_tam("Update tbStokFisiSeriNo Set sSeri = '" & Trim(yeniSeriNo.Text) & "' Where nIslemID = (select nIslemID from tbStokFisiDetayi Where (nAlisverisID = '" & Trim(alisverisID.Text) & "') AND (nStokID = (Select Top 1 nStokID From tbStok Where sKodu = '" & Trim(stokKodu.Text) & "')))")
                    sorguC.sorgu_Destek("Seri No Deðiþtirme", "Yeni Seri No: " & Trim(yeniSeriNo.Text) & ", Alýþveri Numarasý: " & Trim(alisverisID.Text) & ", Stok Kodu: " & Trim(stokKodu.Text) & "", "SimpleButton1_Click()", "frm_satici_seri_degistir.vb")
                    MessageBox.Show("Seri no deðiþtirme iþlemi baþarýlý.", "Business Smart")
                    PanelControl2.Visible = False
                    Me.Enabled = True
                    Me.Close()
                End If
            Else
                MessageBox.Show("Lütfen Alýþveriþ numarasý girerek bir stok seçiniz.", "Business Smart")
            End If
        End If
    End Sub
    Private Sub SimpleButton2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SimpleButton2.Click
        Me.Close()
    End Sub
    Private Sub LookUpEdit1_EditValueChanged(sender As System.Object, e As System.EventArgs) Handles stokKodu.EditValueChanged
        stokAciklama.Text = stokKodu.Properties.GetDataSourceValue("sAciklama", stokKodu.ItemIndex)
    End Sub
    Private Sub LookUpEdit2_EditValueChanged(sender As System.Object, e As System.EventArgs) Handles depoKodu.EditValueChanged
        depoAciklama.Text = depoKodu.Properties.GetDataSourceValue("sAciklama", depoKodu.ItemIndex)
    End Sub
    Private Sub CheckEdit1_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles CheckEdit1.CheckedChanged
        cokluGroup.Enabled = CheckEdit1.Checked
        If CheckEdit1.Checked = False Then
            CheckEdit2.Enabled = True
        Else
            CheckEdit2.Checked = False
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
    Private Sub txt_sDepoKodu_KeyDown(sender As System.Object, e As System.Windows.Forms.KeyEventArgs) Handles alisverisID.KeyDown
        stokKodu.Properties.DataSource = sorgu(sorgu_query("SELECT (select sKodu from tbStok Where tbStok.nStokID = tbStokFisiDetayi.nStokID) as sKodu, (select sAciklama from tbStok Where tbStok.nStokID = tbStokFisiDetayi.nStokID) as sAciklama FROM tbStokFisiDetayi Where nAlisverisID = '" & Trim(alisverisID.Text) & "'")).Tables(0)
    End Sub
    Private Sub RadioButton1_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles RadioButton1.CheckedChanged
        If RadioButton1.Checked = True Then
            CheckEdit1.Enabled = True
            CheckEdit2.Enabled = True
            yeniSeriNo.Enabled = False
            eskiSaticiKodu.Enabled = True
            yeniSaticiKodu.Enabled = True
        Else
            CheckEdit1.Checked = False
            CheckEdit1.Enabled = False
            CheckEdit2.Checked = True
            CheckEdit2.Enabled = False
            yeniSeriNo.Enabled = True
            eskiSaticiKodu.Enabled = False
            yeniSaticiKodu.Enabled = False
        End If
    End Sub
    Private Sub RadioButton2_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles RadioButton2.CheckedChanged
        If RadioButton2.Checked = True Then
            CheckEdit1.Checked = False
            CheckEdit1.Enabled = False
            CheckEdit2.Checked = True
            CheckEdit2.Enabled = False
            yeniSeriNo.Enabled = True
            eskiSaticiKodu.Enabled = False
            yeniSaticiKodu.Enabled = False
        Else
            CheckEdit1.Enabled = True
            CheckEdit2.Enabled = True
            yeniSeriNo.Enabled = False
            eskiSaticiKodu.Enabled = True
            yeniSaticiKodu.Enabled = True
        End If
    End Sub
    Private Sub depoKoduF_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles depoKoduF.CheckedChanged
        depoKodu.Enabled = depoKoduF.Checked
    End Sub
    Private Sub CheckEdit2_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles CheckEdit2.CheckedChanged
        tekliGroup.Enabled = CheckEdit2.Checked
        If CheckEdit2.Checked = False Then
            CheckEdit1.Enabled = True
        Else
            CheckEdit1.Checked = False
        End If
    End Sub
End Class