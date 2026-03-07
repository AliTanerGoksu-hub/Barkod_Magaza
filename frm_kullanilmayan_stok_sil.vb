Imports Microsoft.Win32
Imports DevExpress.XtraEditors
Public Class frm_kullanilmayan_stok_sil
    Dim nStokIDSon As String = ""
    Dim silDS As DataSet
    Dim sayi As Integer = 0
    Dim trd As Threading.Thread
    Dim islem As Boolean = False
    Dim query As String = ""
    Dim i As Integer = 0
    Dim hareket As Boolean = False
    Dim silinenStokID As String = ""
    Dim silinemeyenStokID As String = ""
    Dim silClass As SorguClass = New SorguClass
    Private Sub frm_stok_kodu_degistir_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        PanelControl2.Visible = False
    End Sub
    Private Sub SimpleButton2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SimpleButton2.Click
        Me.Close()
    End Sub
    Private Sub SimpleButton4_Click(sender As System.Object, e As System.EventArgs) Handles SimpleButton4.Click
        islem = True
        PanelControl2.Visible = True
        PanelControl3.Enabled = False
        silKontrolBasla()
        islem = False
        SimpleButton3.Enabled = True
        PanelControl3.Enabled = True
        PanelControl2.Visible = False
    End Sub
    Private Sub silKontrolBasla()
        hareket = CheckEdit1.Checked
        sayi = silClass.sorgu("SELECT count(*) FROM tbStok")
        bar.Properties.Maximum = sayi
        silDS = silClass.sorgu_DS("SELECT nStokID, sKodu, sAciklama FROM tbStok").Tables(0).DataSet
        Dim dr As DataRow
        i = 1
        If hareket = True Then
            query = "SELECT nStokID, sKodu, sAciklama, sModel, 'Kayýtlý' as Durum FROM tbStok"
            GridControl1.DataSource = silClass.sorgu_DS(sorgu_query(query)).Tables(0)
            LabelControl3.Text = sayi
            LabelControl3.Refresh()
        Else
            query = "SELECT nStokID, sKodu, sAciklama, sModel, 'Kayýtlý' as Durum FROM tbStok where nStokID IN ("
            For Each dr In silDS.Tables(0).Rows
                If silClass.tbStokSilKontrol(dr("nStokID").ToString(), ComboBoxEdit1.SelectedIndex, SpinEdit1.Value) = True Then
                    query += dr("nStokID").ToString() & ", "
                End If
                bar.Position += 1
                bar.Refresh()
                LabelControl3.Text = i
                LabelControl3.Refresh()
                i += 1
            Next
            If query.Length > 95 Then
                query = query.Substring(0, query.Length - 2) & ")"
                GridControl1.DataSource = silClass.sorgu_DS(sorgu_query(query)).Tables(0)
            End If
        End If
    End Sub
    Private Sub satir_sil()
        If GridView1.RowCount > 0 Then
            silinenStokID = ""
            silinemeyenStokID = ""
            If XtraMessageBox.Show(Sorgu_sDil("Seçili Stok Kayýtlarýný Silmek Ýstediðinize Emin misiniz...?", sDil), Sorgu_sDil("Dikkat", sDil), MessageBoxButtons.YesNo, MessageBoxIcon.Question) = MsgBoxResult.Yes Then
                Dim s As String
                Dim arr As Integer()
                arr = GridView1.GetSelectedRows()
                Dim dr1 As DataRow
                If arr Is Nothing Then
                Else
                    Array.Sort(arr)
                    bar.Properties.Maximum = GridView1.SelectedRowsCount
                    bar.Position = 0
                    For Each i In arr
                        s = i.ToString
                        dr1 = GridView1.GetDataRow(s)
                        tbStok_sil(dr1("sModel"), s, False)
                        bar.Position += 1
                        bar.Refresh()
                    Next
                    If hareket = True Then
                        silClass.sorgu_Destek("Hareketli Stok Silme Ýþlemi", "Silinen Stok ID:(" & silinenStokID.Substring(0, silinenStokID.Length - 2) & "), Silinemeyen Stok ID:(" & silinemeyenStokID.Substring(0, silinemeyenStokID.Length - 2) & ")", "satir_sil()", "frm_kullanilmayan_stok_sil.vb")
                    Else
                        silClass.sorgu_Destek("Stok Silme Ýþlemi", "Silinen Stok ID:(" & silinenStokID.Substring(0, silinenStokID.Length - 2) & "), Silinemeyen Stok ID:(" & silinemeyenStokID.Substring(0, silinemeyenStokID.Length - 2) & ")", "satir_sil()", "frm_kullanilmayan_stok_sil.vb")
                    End If
                    XtraMessageBox.Show(Sorgu_sDil("Ýþlem Baþarýyla Tamamlandý...", sDil), Sorgu_sDil("Dikkat", sDil), MessageBoxButtons.OK, MessageBoxIcon.Information)
                End If
                dr1 = Nothing
            End If
        End If
    End Sub
    Private Sub tbStok_sil(ByVal sModel As String, ByVal satir As Integer, Optional ByVal uyari As Boolean = True)
        Dim con As New OleDb.OleDbConnection
        Dim cmd As New OleDb.OleDbCommand
        cmd.Connection = con
        con.ConnectionString = connection
        If con.State = ConnectionState.Closed = True Then
            con.Open()
        End If
        cmd.CommandText = sorgu_query("set implicit_transactions on")
        cmd.ExecuteNonQuery()
        Try
            cmd.CommandText = sorgu_query("SET DATEFORMAT DMY SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED ")
            cmd.ExecuteNonQuery()
            cmd.CommandText = sorgu_query("delete tbStokSinifi from tbStok where tbStok.nStokID = tbStokSinifi.nStokID and sModel = '" & sModel & "'")
            cmd.ExecuteNonQuery()
            cmd.CommandText = sorgu_query("delete tbStokBarkodu from tbStok where tbStok.nStokID = tbStokBarkodu.nStokID and sModel = '" & sModel & "'")
            cmd.ExecuteNonQuery()
            cmd.CommandText = sorgu_query("delete tbStokFiyati from tbStok  where tbStok.nStokID = tbStokFiyati.nStokID and sModel = '" & sModel & "'")
            cmd.ExecuteNonQuery()
            cmd.CommandText = sorgu_query("delete tbStokBirimCevrimi from tbStok where tbStok.nStokID = tbStokBirimCevrimi.nStokID and sModel = '" & sModel & "'")
            cmd.ExecuteNonQuery()
            cmd.CommandText = sorgu_query("delete tbStokMuhasebeEntegrasyon from tbStok where tbStok.nStokID = tbStokMuhasebeEntegrasyon.nStokID and sModel = '" & sModel & "'")
            cmd.ExecuteNonQuery()
            cmd.CommandText = sorgu_query("delete tbStokOdemePlani from tbStok  where tbStok.nStokID = tbStokOdemePlani.nStokID and sModel = '" & sModel & "'")
            cmd.ExecuteNonQuery()
            cmd.CommandText = sorgu_query("delete tbStokSayim from tbStok where tbStok.nStokID = tbStokSayim.nStokID and sModel = '" & sModel & "'")
            cmd.ExecuteNonQuery()
            cmd.CommandText = sorgu_query("delete tbStokDil from tbStok where tbStok.nStokID = tbStokDil.nStokID and sModel = '" & sModel & "'")
            cmd.ExecuteNonQuery()
            cmd.CommandText = sorgu_query("delete tbStokAciklama from tbStok where tbStok.nStokID = tbStokAciklama.nStokID and sModel = '" & sModel & "'")
            cmd.ExecuteNonQuery()
            cmd.CommandText = sorgu_query("delete tbStokUzunNot where sModel = '" & sModel & "'")
            cmd.ExecuteNonQuery()
            cmd.CommandText = sorgu_query("delete from tbStokResim where sModel = '" & sModel & "'")
            cmd.ExecuteNonQuery()
            cmd.CommandText = sorgu_query("delete from tbStokMuhasebeEntegrasyon where nStokID IN (Select nStokID from tbStok where sModel = N'" & sModel & "')")
            cmd.ExecuteNonQuery()
            cmd.CommandText = sorgu_query("delete from tbKoliDagilimi where nStokID IN (Select nStokID from tbStok where sModel = N'" & sModel & "')")
            cmd.ExecuteNonQuery()
            cmd.CommandText = sorgu_query("delete tbStok where sModel = '" & sModel & "'")
            cmd.ExecuteNonQuery()
            cmd.CommandText = sorgu_query("IF @@TRANCOUNT > 0 COMMIT TRAN")
            cmd.ExecuteNonQuery()
            If hareket = True Then
                cmd.CommandText = sorgu_query("delete from ASTOKETIKETTALEPBASLIK where (IND IN (select IND from ASTOKETIKETTALEPDETAY where STOKNO = " & nStokIDSon & "))")
                cmd.ExecuteNonQuery()
                cmd.CommandText = sorgu_query("delete from ASTOKFIYATDEGISIMBASLIK where (IND IN (select IND from ASTOKFIYATDEGISIMDETAY where STOKNO = " & nStokIDSon & "))")
                cmd.ExecuteNonQuery()
                cmd.CommandText = sorgu_query("delete from ASTOKPAKETBASLIK where (FISNO IN (select FISNO from ASTOKPAKETDETAY where STOKNO = " & nStokIDSon & "))")
                cmd.ExecuteNonQuery()
                cmd.CommandText = sorgu_query("delete from tbSiparis where (nStokID = " & nStokIDSon & ")")
                cmd.ExecuteNonQuery()
                cmd.CommandText = sorgu_query("delete from tbStokFisiMaster where lFisNo IN (select lFisNo from tbStokFisiDetayi where nStokID = " & nStokIDSon & ")")
                cmd.ExecuteNonQuery()
                cmd.CommandText = sorgu_query("delete from tbStokFisiDetayi where (nStokID = " & nStokIDSon & ")")
                cmd.ExecuteNonQuery()
            End If
            GridView1.SetRowCellValue(satir, "Durum", "Silindi")
            silinenStokID += nStokIDSon & ", "
            If uyari = True Then
                XtraMessageBox.Show(Sorgu_sDil("Model Kodu: " & sModel & " olan stok kaydý baþarýyla silindi...", sDil), Sorgu_sDil("Dikkat", sDil), MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        Catch ex As Exception
            GridView1.SetRowCellValue(satir, "Durum", "Silinemedi!")
            silinemeyenStokID += nStokIDSon & ", "
            If uyari = True Then
                XtraMessageBox.Show(Sorgu_sDil("Model Kodu: " & sModel & " olan stoða ait, " & vbCrLf & " Hareketler bulunmaktadýr. Silemezsiniz...!", sDil), Sorgu_sDil("Dikkat", sDil), MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            End If
            cmd.CommandText = sorgu_query("IF @@TRANCOUNT > 0 ROLLBACK TRAN")
            cmd.ExecuteNonQuery()
        End Try
        con.Close()
    End Sub
    Private Sub frm_kullanilmayan_stok_sil_FormClosing(sender As System.Object, e As System.Windows.Forms.FormClosingEventArgs) Handles MyBase.FormClosing
        If islem = True Then
            e.Cancel = True
        End If
    End Sub
    Private Sub SimpleButton1_Click(sender As System.Object, e As System.EventArgs) Handles SimpleButton1.Click
        Me.Close()
    End Sub
    Private Sub SimpleButton3_Click(sender As System.Object, e As System.EventArgs) Handles SimpleButton3.Click
        satir_sil()
    End Sub
End Class