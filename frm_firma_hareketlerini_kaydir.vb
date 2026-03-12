Imports Microsoft.Win32
Imports DevExpress.XtraEditors
Public Class frm_firma_hareketlerini_kaydir
    Dim sorguC As SorguClass = New SorguClass
    Dim sAciklama As String = ""
    Private Sub frm_stok_kodu_degistir_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        PanelControl2.Visible = False
    End Sub
    Private Sub temizle()
        txt_eskiModel.Text = ""
        txt_sKisaAdi.Text = ""
        LabelControl4.Text = ""
        txt_sKisaAdi.Enabled = False
        TamamB.Enabled = False
        txt_eskiModel.Enabled = True
    End Sub
    Private Sub SimpleButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SimpleButton1.Click
        If XtraMessageBox.Show("Eski Firma ID: " & Trim(txt_eskiModel.Text) & " Numaralý Hareketleri, " & vbCrLf & "Yeni Firma ID: " & Trim(txt_sKisaAdi.Text) & vbCrLf & " Kayýt Numarasý ile Deðiþtirmek Ýstediðinize Eminmisiniz...?", Sorgu_sDil("Dikkat", sDil), MessageBoxButtons.YesNo, MessageBoxIcon.Question) = MsgBoxResult.Yes Then
            PanelControl2.Visible = True
            PanelControl2.BringToFront()
            Me.Enabled = False
            sorguC.sorgu_tam("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED Update tbFirmaBordroMaster set nFirmaID = " & Trim(txt_sKisaAdi.Text) & " Where nFirmaID = " & Trim(txt_eskiModel.Text) & "")
            sorguC.sorgu_tam("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED Update tbFirmaBordroDetay set nFirmaID = " & Trim(txt_sKisaAdi.Text) & " Where nFirmaID = " & Trim(txt_eskiModel.Text) & "")
            sorguC.sorgu_tam("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED Update tbFirmaHareketi set nFirmaID = " & Trim(txt_sKisaAdi.Text) & " Where nFirmaID = " & Trim(txt_eskiModel.Text) & "")
            sorguC.sorgu_tam("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED Update tbStokFisiMaster set nFirmaID = " & Trim(txt_sKisaAdi.Text) & " Where nFirmaID = " & Trim(txt_eskiModel.Text) & "")
            sorguC.sorgu_tam("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED Update tbStokFisiDetayi set nFirmaID = " & Trim(txt_sKisaAdi.Text) & " Where nFirmaID = " & Trim(txt_eskiModel.Text) & "")
            sorguC.sorgu_tam("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED Update tbSiparis set nFirmaID = " & Trim(txt_sKisaAdi.Text) & " Where nFirmaID = " & Trim(txt_eskiModel.Text) & "")
            sorguC.sorgu_tam("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED Update tbNakitKasa set nFirmaID = " & Trim(txt_sKisaAdi.Text) & " Where nFirmaID = " & Trim(txt_eskiModel.Text) & "")
            sorguC.sorgu_tam("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED Update tbCekSenet set nVerenID = " & Trim(txt_sKisaAdi.Text) & " Where nVerenID = " & Trim(txt_eskiModel.Text) & "")
            sorguC.sorgu_tam("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED Update tbCekSenetBordro set nFirmaID = " & Trim(txt_sKisaAdi.Text) & " Where nFirmaID = " & Trim(txt_eskiModel.Text) & "")
            sorguC.sorgu_tam("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED Update tbCekSenetBordro set nBorcluFirmaID = " & Trim(txt_sKisaAdi.Text) & " Where nBorcluFirmaID = " & Trim(txt_eskiModel.Text) & "")
            sorguC.sorgu_tam("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED Update tbProtokol set nFirmaID = " & Trim(txt_sKisaAdi.Text) & " Where nFirmaID = " & Trim(txt_eskiModel.Text) & "")
            sorguC.sorgu_Destek("Firma Hareketleri Kaydýrma", "Eski Firma ID: " & Trim(txt_eskiModel.Text) & ", Yeni Firma ID: " & Trim(txt_sKisaAdi.Text) & "", "SimpleButton1_Click()", "frm_firma_hareketlerini_kaydir.vb")
            temizle()
            MessageBox.Show("Firma Hareketleri Kaydýrma iþlemi baþarýlý.", "Business Smart")
            PanelControl2.Visible = False
            Me.Enabled = True
        End If
    End Sub
    Private Sub SimpleButton2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SimpleButton2.Click
        Me.Close()
    End Sub
    Private Sub txt_eskiModel_ButtonClick(sender As System.Object, e As DevExpress.XtraEditors.Controls.ButtonPressedEventArgs) Handles txt_eskiModel.ButtonClick
        Dim frm As New frm_firma_liste
        frm.firmano = firmano
        frm.donemno = donemno
        frm.connection = connection
        frm.islemstatus = True
        frm.sModul = "Cari"
        sAciklama = ""
        If frm.ShowDialog(Me) = Windows.Forms.DialogResult.OK Then
            Dim dr1 As DataRow
            dr1 = frm.GridView1.GetDataRow(frm.GridView1.FocusedRowHandle)
            txt_eskiModel.EditValue = dr1("nFirmaID")
            sAciklama = dr1("sAciklama")
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
        If Trim(txt_eskiModel.Text) = "" Then
            LabelControl4.Text = sorguC.sorgu("Select sAciklama From tbFirma Where nFirmaID = '" & Trim(txt_eskiModel.Text) & "'")
        End If
        If Trim(txt_eskiModel.Text) = "" Then
            MessageBox.Show("Bu ID numarasýna sahip bir kayýt bulunamadý.", "Business Smart")
        Else
            LabelControl4.Text = sAciklama
            txt_sKisaAdi.Enabled = True
            TamamB.Enabled = False
            SimpleButton3.Enabled = True
            txt_eskiModel.Enabled = False
        End If
    End Sub
    Private Sub txt_sKisaAdi_ButtonClick(sender As System.Object, e As DevExpress.XtraEditors.Controls.ButtonPressedEventArgs) Handles txt_sKisaAdi.ButtonClick
        Dim frm As New frm_firma_liste
        frm.firmano = firmano
        frm.donemno = donemno
        frm.connection = connection
        frm.islemstatus = True
        frm.sModul = "Cari"
        sAciklama = ""
        If frm.ShowDialog(Me) = Windows.Forms.DialogResult.OK Then
            Dim dr1 As DataRow
            dr1 = frm.GridView1.GetDataRow(frm.GridView1.FocusedRowHandle)
            txt_sKisaAdi.EditValue = dr1("nFirmaID")
            sAciklama = dr1("sAciklama")
            dr1 = Nothing
        End If
    End Sub
    Private Sub SimpleButton3_Click(sender As System.Object, e As System.EventArgs) Handles SimpleButton3.Click
        If Trim(txt_sKisaAdi.Text) = "" Then
            LabelControl2.Text = sorguC.sorgu("Select sAciklama From tbFirma Where nFirmaID = '" & Trim(txt_sKisaAdi.Text) & "'")
        End If
        If Trim(txt_sKisaAdi.Text) = "" Then
            MessageBox.Show("Bu ID numarasýna sahip bir kayýt bulunamadý.", "Business Smart")
        Else
            LabelControl2.Text = sAciklama
            txt_sKisaAdi.Enabled = False
            SimpleButton3.Enabled = False
            SimpleButton1.Enabled = True
        End If
    End Sub
End Class