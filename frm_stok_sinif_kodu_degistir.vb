Imports Microsoft.Win32
Imports DevExpress.XtraEditors
Public Class frm_stok_sinif_kodu_degistir
    Dim nStokID As String = ""
    Dim mesaj As String = ""
    Dim query As String = ""
    Dim sorguC As SorguClass = New SorguClass
    Dim kriter As String = ""
    Private Sub frm_stok_kodu_degistir_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        PanelControl2.Visible = False
        sinif1.Properties.DataSource = sorguC.sorgu_DS(sorgu_query("SELECT sSinifKodu, sAciklama FROM tbSSinif1")).Tables(0)
        sinif2.Properties.DataSource = sorguC.sorgu_DS(sorgu_query("SELECT sSinifKodu, sAciklama FROM tbSSinif2")).Tables(0)
        sinif3.Properties.DataSource = sorguC.sorgu_DS(sorgu_query("SELECT sSinifKodu, sAciklama FROM tbSSinif3")).Tables(0)
        sinif4.Properties.DataSource = sorguC.sorgu_DS(sorgu_query("SELECT sSinifKodu, sAciklama FROM tbSSinif4")).Tables(0)
        sinif5.Properties.DataSource = sorguC.sorgu_DS(sorgu_query("SELECT sSinifKodu, sAciklama FROM tbSSinif5")).Tables(0)
        sinif6.Properties.DataSource = sorguC.sorgu_DS(sorgu_query("SELECT sSinifKodu, sAciklama FROM tbSSinif6")).Tables(0)
        sinif7.Properties.DataSource = sorguC.sorgu_DS(sorgu_query("SELECT sSinifKodu, sAciklama FROM tbSSinif7")).Tables(0)
        sinif8.Properties.DataSource = sorguC.sorgu_DS(sorgu_query("SELECT sSinifKodu, sAciklama FROM tbSSinif8")).Tables(0)
        sinif9.Properties.DataSource = sorguC.sorgu_DS(sorgu_query("SELECT sSinifKodu, sAciklama FROM tbSSinif9")).Tables(0)
        sinif10.Properties.DataSource = sorguC.sorgu_DS(sorgu_query("SELECT sSinifKodu, sAciklama FROM tbSSinif10")).Tables(0)
        sinif11.Properties.DataSource = sorguC.sorgu_DS(sorgu_query("SELECT sSinifKodu, sAciklama FROM tbSSinif11")).Tables(0)
        sinif12.Properties.DataSource = sorguC.sorgu_DS(sorgu_query("SELECT sSinifKodu, sAciklama FROM tbSSinif12")).Tables(0)
        sinif13.Properties.DataSource = sorguC.sorgu_DS(sorgu_query("SELECT sSinifKodu, sAciklama FROM tbSSinif13")).Tables(0)
        sinif14.Properties.DataSource = sorguC.sorgu_DS(sorgu_query("SELECT sSinifKodu, sAciklama FROM tbSSinif14")).Tables(0)
        sinif15.Properties.DataSource = sorguC.sorgu_DS(sorgu_query("SELECT sSinifKodu, sAciklama FROM tbSSinif15")).Tables(0)
    End Sub
    Private Sub SimpleButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SimpleButton1.Click
        Dim iptal As Boolean = True
        If RadioButton1.Checked = True Then
            iptal = False
            mesaj = "Stok Kodu: " & Trim(txt_eskiModel.Text) & "," & vbCrLf
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
        ElseIf RadioButton2.Checked = True Then
            mesaj = "Stok Kodu: " & kriter.Substring(0, kriter.Length - 2) & "," & vbCrLf
            If Trim(sinif1.Text) <> "" Then
                iptal = False
                mesaj += "Sinif 1: " & Trim(sinif1.Text) & "," & vbCrLf
            End If
            If Trim(sinif2.Text) <> "" Then
                iptal = False
                mesaj += "Sinif 2: " & Trim(sinif2.Text) & "," & vbCrLf
            End If
            If Trim(sinif3.Text) <> "" Then
                iptal = False
                mesaj += "Sinif 3: " & Trim(sinif3.Text) & "," & vbCrLf
            End If
            If Trim(sinif4.Text) <> "" Then
                iptal = False
                mesaj += "Sinif 4: " & Trim(sinif4.Text) & "," & vbCrLf
            End If
            If Trim(sinif5.Text) <> "" Then
                iptal = False
                mesaj += "Sinif 5: " & Trim(sinif5.Text) & "," & vbCrLf
            End If
            If Trim(sinif6.Text) <> "" Then
                iptal = False
                mesaj += "Sinif 6: " & Trim(sinif6.Text) & "," & vbCrLf
            End If
            If Trim(sinif7.Text) <> "" Then
                iptal = False
                mesaj += "Sinif 7: " & Trim(sinif7.Text) & "," & vbCrLf
            End If
            If Trim(sinif8.Text) <> "" Then
                iptal = False
                mesaj += "Sinif 8: " & Trim(sinif8.Text) & "," & vbCrLf
            End If
            If Trim(sinif9.Text) <> "" Then
                iptal = False
                mesaj += "Sinif 9: " & Trim(sinif9.Text) & "," & vbCrLf
            End If
            If Trim(sinif10.Text) <> "" Then
                iptal = False
                mesaj += "Sinif 10: " & Trim(sinif10.Text) & "," & vbCrLf
            End If
            If Trim(sinif11.Text) <> "" Then
                iptal = False
                mesaj += "Sinif 11: " & Trim(sinif11.Text) & "," & vbCrLf
            End If
            If Trim(sinif12.Text) <> "" Then
                iptal = False
                mesaj += "Sinif 12: " & Trim(sinif12.Text) & "," & vbCrLf
            End If
            If Trim(sinif13.Text) <> "" Then
                iptal = False
                mesaj += "Sinif 13: " & Trim(sinif13.Text) & "," & vbCrLf
            End If
            If Trim(sinif14.Text) <> "" Then
                iptal = False
                mesaj += "Sinif 14: " & Trim(sinif14.Text) & "," & vbCrLf
            End If
            If Trim(sinif15.Text) <> "" Then
                iptal = False
                mesaj += "Sinif 15: " & Trim(sinif15.Text) & vbCrLf
            End If
        End If
        If iptal = False Then
            If XtraMessageBox.Show(mesaj & "Olarak Deðiþtirmek Ýstediðinize Eminmisiniz...?", Sorgu_sDil("Dikkat", sDil), MessageBoxButtons.YesNo, MessageBoxIcon.Question) = MsgBoxResult.Yes Then
                PanelControl2.Visible = True
                PanelControl2.BringToFront()
                Me.Enabled = False
                If RadioButton1.Checked = True Then
                    query = "Update tbStokSinifi Set "
                    If Trim(sinif1.Text) <> "" Then
                        query += "sSinifKodu1 = '" & Trim(sinif1.Text) & "', "
                    End If
                    If Trim(sinif2.Text) <> "" Then
                        query += "sSinifKodu2 = '" & Trim(sinif2.Text) & "', "
                    End If
                    If Trim(sinif3.Text) <> "" Then
                        query += "sSinifKodu3 = '" & Trim(sinif3.Text) & "', "
                    End If
                    If Trim(sinif4.Text) <> "" Then
                        query += "sSinifKodu4 = '" & Trim(sinif4.Text) & "', "
                    End If
                    If Trim(sinif5.Text) <> "" Then
                        query += "sSinifKodu5 = '" & Trim(sinif5.Text) & "', "
                    End If
                    If Trim(sinif6.Text) <> "" Then
                        query += "sSinifKodu6 = '" & Trim(sinif6.Text) & "', "
                    End If
                    If Trim(sinif7.Text) <> "" Then
                        query += "sSinifKodu7 = '" & Trim(sinif7.Text) & "', "
                    End If
                    If Trim(sinif8.Text) <> "" Then
                        query += "sSinifKodu8 = '" & Trim(sinif8.Text) & "', "
                    End If
                    If Trim(sinif9.Text) <> "" Then
                        query += "sSinifKodu9 = '" & Trim(sinif9.Text) & "', "
                    End If
                    If Trim(sinif10.Text) <> "" Then
                        query += "sSinifKodu10 = '" & Trim(sinif10.Text) & "', "
                    End If
                    If Trim(sinif11.Text) <> "" Then
                        query += "sSinifKodu11 = '" & Trim(sinif11.Text) & "', "
                    End If
                    If Trim(sinif12.Text) <> "" Then
                        query += "sSinifKodu12 = '" & Trim(sinif12.Text) & "', "
                    End If
                    If Trim(sinif13.Text) <> "" Then
                        query += "sSinifKodu13 = '" & Trim(sinif13.Text) & "', "
                    End If
                    If Trim(sinif14.Text) <> "" Then
                        query += "sSinifKodu14 = '" & Trim(sinif14.Text) & "', "
                    End If
                    If Trim(sinif15.Text) <> "" Then
                        query += "sSinifKodu15 = '" & Trim(sinif15.Text) & "' "
                    End If
                ElseIf RadioButton2.Checked = True Then
                    query = "Update tbStokSinifi Set sSinifKodu1 = '" & Trim(sinif1.Text) & "', "
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
                End If
                If RadioButton1.Checked = True Then
                    query += "Where nStokID = '" & Trim(nStokID) & "'"
                ElseIf RadioButton2.Checked = True Then
                    query += "Where nStokID = '" & kriter.Substring(0, kriter.Length - 2) & "'"
                End If
                sorguC.sorgu_tam(query)
                sorguC.sorgu_Destek("Stok Sýnýf Kodu Deðiþtirme", mesaj, "SimpleButton1_Click()", "frm_stok_sinif_kodu_degistir.vb")
                MessageBox.Show("Stok sýnýf kodu deðiþtirme iþlemi baþarýlý.", "Business Smart")
                PanelControl2.Visible = False
                Me.Enabled = True
                Me.Close()
            End If
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
        If frm.ShowDialog(Me) = Windows.Forms.DialogResult.OK Then
            Dim dr1 As DataRow
            If RadioButton1.Checked = True Then
                dr1 = frm.GridView1.GetDataRow(frm.GridView1.FocusedRowHandle)
                nStokID = Trim(dr1("nStokID"))
                txt_eskiModel.EditValue = Trim(dr1("sKodu"))
                StokAdi.Text = sorguC.sorgu("Select sAciklama from tbStok where nStokID = '" & Trim(nStokID) & "'")
                goster()
                dr1 = Nothing
            ElseIf RadioButton2.Checked = True Then
                Dim i As Integer = 0
                Dim row As Integer = 0
                For i = 0 To frm.GridView1.SelectedRowsCount - 1
                    row = (frm.GridView1.GetSelectedRows()(i))
                    dr1 = frm.GridView1.GetDataRow(row)
                    kriter += Trim(dr1("nStokID").ToString()) & ", "
                Next i
                txt_eskiModel.EditValue = kriter.Substring(0, kriter.Length - 2)
                StokAdi.Text = "Çoklu Seçim"
                sinif1.EditValue = ""
                sinif2.EditValue = ""
                sinif3.EditValue = ""
                sinif4.EditValue = ""
                sinif5.EditValue = ""
                sinif6.EditValue = ""
                sinif7.EditValue = ""
                sinif8.EditValue = ""
                sinif9.EditValue = ""
                sinif10.EditValue = ""
                sinif11.EditValue = ""
                sinif12.EditValue = ""
                sinif13.EditValue = ""
                sinif14.EditValue = ""
                sinif15.EditValue = ""
                dr1 = Nothing
            End If
        Else
            Try
                Me.Close()
            Catch ex As Exception
            End Try
        End If
    End Sub
    Private Sub goster()
        nStokID = sorguC.sorgu("Select nStokID From tbStok Where sKodu = '" & Trim(txt_eskiModel.Text) & "'")
        If Trim(nStokID) = "" Then
            MessageBox.Show("Bu kod numarasýna sahip bir kayýt bulunamadý.", "Business Smart")
        Else
            If sorguC.sorgu("Select count(*) From tbStokSinifi Where nStokID = '" & nStokID & "'") > 0 Then
                sinif1.EditValue = sorguC.sorgu("Select sSinifKodu1 From tbStokSinifi Where nStokID = '" & nStokID & "'")
                sinif2.EditValue = sorguC.sorgu("Select sSinifKodu2 From tbStokSinifi Where nStokID = '" & nStokID & "'")
                sinif3.EditValue = sorguC.sorgu("Select sSinifKodu3 From tbStokSinifi Where nStokID = '" & nStokID & "'")
                sinif4.EditValue = sorguC.sorgu("Select sSinifKodu4 From tbStokSinifi Where nStokID = '" & nStokID & "'")
                sinif5.EditValue = sorguC.sorgu("Select sSinifKodu5 From tbStokSinifi Where nStokID = '" & nStokID & "'")
                sinif6.EditValue = sorguC.sorgu("Select sSinifKodu6 From tbStokSinifi Where nStokID = '" & nStokID & "'")
                sinif7.EditValue = sorguC.sorgu("Select sSinifKodu7 From tbStokSinifi Where nStokID = '" & nStokID & "'")
                sinif8.EditValue = sorguC.sorgu("Select sSinifKodu8 From tbStokSinifi Where nStokID = '" & nStokID & "'")
                sinif9.EditValue = sorguC.sorgu("Select sSinifKodu9 From tbStokSinifi Where nStokID = '" & nStokID & "'")
                sinif10.EditValue = sorguC.sorgu("Select sSinifKodu10 From tbStokSinifi Where nStokID = '" & nStokID & "'")
                sinif11.EditValue = sorguC.sorgu("Select sSinifKodu11 From tbStokSinifi Where nStokID = '" & nStokID & "'")
                sinif12.EditValue = sorguC.sorgu("Select sSinifKodu12 From tbStokSinifi Where nStokID = '" & nStokID & "'")
                sinif13.EditValue = sorguC.sorgu("Select sSinifKodu13 From tbStokSinifi Where nStokID = '" & nStokID & "'")
                sinif14.EditValue = sorguC.sorgu("Select sSinifKodu14 From tbStokSinifi Where nStokID = '" & nStokID & "'")
                sinif15.EditValue = sorguC.sorgu("Select sSinifKodu15 From tbStokSinifi Where nStokID = '" & nStokID & "'")
                SimpleButton1.Enabled = True
            Else
                query = "Insert Into tbStokSinifi Values('" & nStokID & "', '" & Trim(sinif1.Text) & "', "
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