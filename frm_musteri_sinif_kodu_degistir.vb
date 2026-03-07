Imports Microsoft.Win32
Imports DevExpress.XtraEditors
Public Class frm_musteri_sinif_kodu_degistir
    Dim mesaj As String = ""
    Dim query As String = ""
    Dim nMusteriID As String = ""
    Dim sorguC As SorguClass = New SorguClass
    Private Sub frm_stok_kodu_degistir_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        PanelControl2.Visible = False
        sinif1.Properties.DataSource = sorguC.sorgu_DS(sorgu_query("SELECT * FROM tbMSinif1")).Tables(0)
        sinif2.Properties.DataSource = sorguC.sorgu_DS(sorgu_query("SELECT * FROM tbMSinif2")).Tables(0)
        sinif3.Properties.DataSource = sorguC.sorgu_DS(sorgu_query("SELECT * FROM tbMSinif3")).Tables(0)
        sinif4.Properties.DataSource = sorguC.sorgu_DS(sorgu_query("SELECT * FROM tbMSinif4")).Tables(0)
        sinif5.Properties.DataSource = sorguC.sorgu_DS(sorgu_query("SELECT * FROM tbMSinif5")).Tables(0)
        sinif6.Properties.DataSource = sorguC.sorgu_DS(sorgu_query("SELECT * FROM tbMSinif6")).Tables(0)
        sinif7.Properties.DataSource = sorguC.sorgu_DS(sorgu_query("SELECT * FROM tbMSinif7")).Tables(0)
        sinif8.Properties.DataSource = sorguC.sorgu_DS(sorgu_query("SELECT * FROM tbMSinif8")).Tables(0)
        sinif9.Properties.DataSource = sorguC.sorgu_DS(sorgu_query("SELECT * FROM tbMSinif9")).Tables(0)
        sinif10.Properties.DataSource = sorguC.sorgu_DS(sorgu_query("SELECT * FROM tbMSinif10")).Tables(0)
        sinif11.Properties.DataSource = sorguC.sorgu_DS(sorgu_query("SELECT * FROM tbMSinif11")).Tables(0)
        sinif12.Properties.DataSource = sorguC.sorgu_DS(sorgu_query("SELECT * FROM tbMSinif12")).Tables(0)
        sinif13.Properties.DataSource = sorguC.sorgu_DS(sorgu_query("SELECT * FROM tbMSinif13")).Tables(0)
        sinif14.Properties.DataSource = sorguC.sorgu_DS(sorgu_query("SELECT * FROM tbMSinif14")).Tables(0)
        sinif15.Properties.DataSource = sorguC.sorgu_DS(sorgu_query("SELECT * FROM tbMSinif15")).Tables(0)
    End Sub
    Private Sub SimpleButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SimpleButton1.Click
        mesaj = "Müþteri Kodu: " & Trim(txt_eskiModel.Text) & "," & vbCrLf
        mesaj += "Sinif 1: " & Trim(sinif1.Text) & "," & vbCrLf
        mesaj += "Sinif 2: " & Trim(sinif2.Text) & "," & vbCrLf
        mesaj += "Sinif 3: " & Trim(sinif3.Text) & "," & vbCrLf
        mesaj += "Sinif 4: " & Trim(sinif4.Text) & "," & vbCrLf
        mesaj += "Sinif 5: " & Trim(sinif5.Text) & "," & vbCrLf
        mesaj += "Sinif 6: " & Trim(sinif6.Text) & "," & vbCrLf
        mesaj += "Sinif 7: " & Trim(sinif7.Text) & "," & vbCrLf
        mesaj += "Sinif 8: " & Trim(sinif8.Text) & "," & vbCrLf
        mesaj += "Sinif 9: " & Trim(sinif9.Text) & "," & vbCrLf
        mesaj += "Sinif 10: " & Trim(sinif10.Text) & "," & vbCrLf
        mesaj += "Sinif 11: " & Trim(sinif11.Text) & "," & vbCrLf
        mesaj += "Sinif 12: " & Trim(sinif12.Text) & "," & vbCrLf
        mesaj += "Sinif 13: " & Trim(sinif13.Text) & "," & vbCrLf
        mesaj += "Sinif 14: " & Trim(sinif14.Text) & "," & vbCrLf
        mesaj += "Sinif 15: " & Trim(sinif15.Text) & vbCrLf
        If XtraMessageBox.Show(mesaj & "Olarak Deðiþtirmek Ýstediðinize Eminmisiniz...?", Sorgu_sDil("Dikkat", sDil), MessageBoxButtons.YesNo, MessageBoxIcon.Question) = MsgBoxResult.Yes Then
            PanelControl2.Visible = True
            PanelControl2.BringToFront()
            Me.Enabled = False
            query = "Update tbMusteriSinifi Set sSinifKodu1 = '" & Trim(sinif1.Text) & "', "
            query += "sSinifKodu2 = '" & Trim(sinif2.Text) & "', "
            query += "sSinifKodu3 = '" & Trim(sinif3.Text) & "', "
            query += "sSinifKodu4 = '" & Trim(sinif4.Text) & "', "
            query += "sSinifKodu5 = '" & Trim(sinif5.Text) & "', "
            query += "sSinifKodu6 = '" & Trim(sinif6.Text) & "', "
            query += "sSinifKodu7 = '" & Trim(sinif7.Text) & "', "
            query += "sSinifKodu8 = '" & Trim(sinif8.Text) & "', "
            query += "sSinifKodu9 = '" & Trim(sinif9.Text) & "', "
            query += "sSinifKodu10 = '" & Trim(sinif10.Text) & "', "
            query += "sSinifKodu11 = '" & Trim(sinif11.Text) & "', "
            query += "sSinifKodu12 = '" & Trim(sinif12.Text) & "', "
            query += "sSinifKodu13 = '" & Trim(sinif13.Text) & "', "
            query += "sSinifKodu14 = '" & Trim(sinif14.Text) & "', "
            query += "sSinifKodu15 = '" & Trim(sinif15.Text) & "' "
            query += "Where nMusteriID = '" & Trim(nMusteriID) & "'"
            sorguC.sorgu_tam(query)
            sorguC.sorgu_Destek("Müþteri Sýnýf Kodu Deðiþtirme", mesaj, "SimpleButton1_Click()", "frm_musteri_sinif_kodu_degistir.vb")
            MessageBox.Show("Müþteri sýnýf kodu deðiþtirme iþlemi baþarýlý.", "Business Smart")
            PanelControl2.Visible = False
            Me.Enabled = True
            Me.Close()
        End If
    End Sub
    Private Sub SimpleButton2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SimpleButton2.Click
        Me.Close()
    End Sub
    Private Sub txt_eskiModel_ButtonClick(sender As System.Object, e As DevExpress.XtraEditors.Controls.ButtonPressedEventArgs) Handles txt_eskiModel.ButtonClick
        Dim frm As New frm_musteri_liste
        frm.firmano = firmano
        frm.donemno = donemno
        frm.connection = connection
        frm.islemstatus = True
        frm.kullanici = kullanici
        If frm.ShowDialog(Me) = Windows.Forms.DialogResult.OK Then
            Dim dr1 As DataRow
            dr1 = frm.GridView1.GetDataRow(frm.GridView1.FocusedRowHandle)
            nMusteriID = dr1("nMusteriID")
            txt_eskiModel.EditValue = dr1("lKodu")
            musteriAdi.Text = sorguC.sorgu("Select (sAdi + ' ' + sSoyadi) as sAdi from tbMusteri where nMusteriID = '" & Trim(nMusteriID) & "'")
            goster()
        End If
    End Sub
    Private Sub goster()
        If Trim(nMusteriID) = "" Then
            MessageBox.Show("Bu kod numarasýna sahip bir kayýt bulunamadý.", "Business Smart")
        Else
            If sorguC.sorgu("Select count(*) From tbMusteriSinifi Where nMusteriID = '" & Trim(nMusteriID) & "'") > 0 Then
                sinif1.EditValue = sorguC.sorgu("Select sSinifKodu1 From tbMusteriSinifi Where nMusteriID = '" & Trim(nMusteriID) & "'")
                sinif2.EditValue = sorguC.sorgu("Select sSinifKodu2 From tbMusteriSinifi Where nMusteriID = '" & Trim(nMusteriID) & "'")
                sinif3.EditValue = sorguC.sorgu("Select sSinifKodu3 From tbMusteriSinifi Where nMusteriID = '" & Trim(nMusteriID) & "'")
                sinif4.EditValue = sorguC.sorgu("Select sSinifKodu4 From tbMusteriSinifi Where nMusteriID = '" & Trim(nMusteriID) & "'")
                sinif5.EditValue = sorguC.sorgu("Select sSinifKodu5 From tbMusteriSinifi Where nMusteriID = '" & Trim(nMusteriID) & "'")
                sinif6.EditValue = sorguC.sorgu("Select sSinifKodu6 From tbMusteriSinifi Where nMusteriID = '" & Trim(nMusteriID) & "'")
                sinif7.EditValue = sorguC.sorgu("Select sSinifKodu7 From tbMusteriSinifi Where nMusteriID = '" & Trim(nMusteriID) & "'")
                sinif8.EditValue = sorguC.sorgu("Select sSinifKodu8 From tbMusteriSinifi Where nMusteriID = '" & Trim(nMusteriID) & "'")
                sinif9.EditValue = sorguC.sorgu("Select sSinifKodu9 From tbMusteriSinifi Where nMusteriID = '" & Trim(nMusteriID) & "'")
                sinif10.EditValue = sorguC.sorgu("Select sSinifKodu10 From tbMusteriSinifi Where nMusteriID = '" & Trim(nMusteriID) & "'")
                sinif11.EditValue = sorguC.sorgu("Select sSinifKodu11 From tbMusteriSinifi Where nMusteriID = '" & Trim(nMusteriID) & "'")
                sinif12.EditValue = sorguC.sorgu("Select sSinifKodu12 From tbMusteriSinifi Where nMusteriID = '" & Trim(nMusteriID) & "'")
                sinif13.EditValue = sorguC.sorgu("Select sSinifKodu13 From tbMusteriSinifi Where nMusteriID = '" & Trim(nMusteriID) & "'")
                sinif14.EditValue = sorguC.sorgu("Select sSinifKodu14 From tbMusteriSinifi Where nMusteriID = '" & Trim(nMusteriID) & "'")
                sinif15.EditValue = sorguC.sorgu("Select sSinifKodu15 From tbMusteriSinifi Where nMusteriID = '" & Trim(nMusteriID) & "'")
                SimpleButton1.Enabled = True
            Else
                query = "Insert Into tbMusteriSinifi Values('" & Trim(nMusteriID) & "', '" & Trim(sinif1.Text) & "', "
                query += "'" & Trim(sinif2.Text) & "', '" & Trim(sinif3.Text) & "', '" & Trim(sinif4.Text) & "', "
                query += "'" & Trim(sinif5.Text) & "', '" & Trim(sinif6.Text) & "', '" & Trim(sinif7.Text) & "', "
                query += "'" & Trim(sinif8.Text) & "', '" & Trim(sinif9.Text) & "', '" & Trim(sinif10.Text) & "', "
                query += "'" & Trim(sinif11.Text) & "', '" & Trim(sinif12.Text) & "', '" & Trim(sinif13.Text) & "', "
                query += "'" & Trim(sinif14.Text) & "', '" & Trim(sinif15.Text) & "')"
                sorguC.sorgu_tam(query)
                goster()
            End If
        End If
    End Sub
    Private Sub TamamB_Click(sender As System.Object, e As System.EventArgs) Handles TamamB.Click
        nMusteriID = sorguC.sorgu("Select nMusteriID from tbMusteri where lKodu = '" & Trim(txt_eskiModel.Text) & "'")
        goster()
    End Sub
    Private Sub txt_eskiModel_KeyDown(sender As System.Object, e As System.Windows.Forms.KeyEventArgs) Handles txt_eskiModel.KeyDown
        If txt_eskiModel.Text.Length >= 3 Then
            TamamB.Enabled = True
        Else
            TamamB.Enabled = False
        End If
    End Sub
End Class