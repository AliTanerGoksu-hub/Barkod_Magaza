''' <summary>
''' Bildirim Yardimci Modulu
''' Personel bildirim tercihlerini herhangi bir yerden acmak icin kullanilir
''' 
''' KULLANIM:
''' ---------
''' ' Personel ID ile bildirim tercihlerini ac
''' BildirimYardimci.PersonelBildirimTercihleriniAc(123, "Ali Veli")
''' 
''' ' GridView'dan secili personelin bildirimlerini ac
''' BildirimYardimci.GriddenPersonelBildirimAc(GridView1, "IND", "PERSONELADI")
''' </summary>
Public Module BildirimYardimci
    
    ''' <summary>
    ''' Personel bildirim tercihleri formunu acar
    ''' </summary>
    ''' <param name="nPersonelID">Personel ID (APERSONEL.IND)</param>
    ''' <param name="sPersonelAdi">Personel Adi (gosterim icin)</param>
    Public Sub PersonelBildirimTercihleriniAc(ByVal nPersonelID As Integer, ByVal sPersonelAdi As String)
        Try
            Dim frm As New frm_PersonelBildirimTercihleri()
            frm.PersonelID = nPersonelID
            frm.PersonelAdi = sPersonelAdi
            frm.ShowDialog()
        Catch ex As Exception
            MessageBox.Show("Bildirim tercihleri formu acilamadi: " & ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
    
    ''' <summary>
    ''' GridView'dan secili personelin bildirim tercihlerini acar
    ''' </summary>
    ''' <param name="view">GridView kontrolu</param>
    ''' <param name="sIDKolonu">ID kolonu adi (varsayilan: IND)</param>
    ''' <param name="sAdKolonu">Ad kolonu adi (varsayilan: PERSONELADI)</param>
    Public Sub GriddenPersonelBildirimAc(ByVal view As DevExpress.XtraGrid.Views.Grid.GridView, _
                                         Optional ByVal sIDKolonu As String = "IND", _
                                         Optional ByVal sAdKolonu As String = "PERSONELADI")
        Try
            If view.FocusedRowHandle >= 0 Then
                Dim nPersonelID As Integer = Convert.ToInt32(view.GetFocusedRowCellValue(sIDKolonu))
                Dim sPersonelAdi As String = view.GetFocusedRowCellValue(sAdKolonu).ToString()
                
                PersonelBildirimTercihleriniAc(nPersonelID, sPersonelAdi)
            Else
                MessageBox.Show("Lutfen bir personel secin.", "Uyari", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            End If
        Catch ex As Exception
            MessageBox.Show("Personel secimi hatasi: " & ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
    
End Module
