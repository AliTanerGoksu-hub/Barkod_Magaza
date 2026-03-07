Public Class frm_Perakende_VadeFarki 
    Public firmano
    Public donemno
    Public connection
    Public musterino
    Public kullanici
    Public sKasiyerRumuzu As String
    Public sKasiyer As String
    Public sMagaza As String
    Public nKasaNo As Integer
    Dim ds_kasiyer As DataSet
    Dim ds_tbMasrafTipi As DataSet
    Dim ds_tbHareketTipi As DataSet
    Dim loaded As Boolean = False
    Dim lFark As Decimal
    Dim lOran As Decimal
    Private Sub frm_Perakende_VadeFarki_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        toplam_hesapla()
        loaded = True
    End Sub
    Private Sub toplam_hesapla()
        Dim dr As DataRow
        Dim lTutar As Decimal = 0
        Dim lVadeFarki As Decimal = 0
        Dim lToplam As Decimal = 0
        For Each dr In DataSet1.Tables(0).Rows
            lTutar += dr(2)
            lVadeFarki += dr(4)
            lToplam += dr(5)
        Next
        txt_ToplamTutar.EditValue = lTutar
        txt_VadeFarki.EditValue = lVadeFarki
        txt_GenelToplam.EditValue = lToplam
        txt_Odenen.EditValue = lToplam
        txt_ParaUstu.EditValue = 0
        lFark = lVadeFarki
        dr = Nothing
        lTutar = Nothing
        lVadeFarki = Nothing
        lToplam = Nothing
    End Sub
    Private Sub hesapla(Optional ByVal oran As Decimal = 0)
        If loaded = True Then
            Dim dr As DataRow
            For Each dr In DataSet1.Tables(0).Rows
                dr("lVadeFarki") = ((dr("lTutar") * oran) / 100) * (dr("nGun") / 30)
                dr("lToplam") = dr("lTutar") + dr("lVadeFarki")
            Next
            toplam_hesapla()
        End If
    End Sub
    Private Sub txt_VadeOrani_EditValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles txt_VadeOrani.EditValueChanged
        If txt_VadeOrani.EditValue.ToString = "" Then
            txt_VadeOrani.EditValue = 0
        End If
        hesapla(txt_VadeOrani.EditValue)
    End Sub
    Private Sub SimpleButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SimpleButton1.Click
        Me.Close()
    End Sub
    Private Sub SimpleButton2_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles SimpleButton2.Click
        Me.Close()
    End Sub
    Private Sub txt_VadeFarki_EditValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles txt_VadeFarki.EditValueChanged
    End Sub
    Private Sub txt_VadeFarki_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles txt_VadeFarki.Validating
        If txt_VadeFarki.EditValue.ToString = "" Then
            txt_VadeFarki.EditValue = 0
        End If
        If loaded = True Then
            If lFark <> txt_VadeFarki.EditValue Then
                lOran = (txt_VadeFarki.EditValue * txt_VadeOrani.EditValue) / lFark
                lFark = txt_VadeFarki.EditValue
                txt_VadeOrani.EditValue = lOran
                hesapla(lOran)
            End If
        End If
    End Sub
    Private Sub SimpleButton3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SimpleButton3.Click
        printlink1.CreateDocument(ps)
        ps.PreviewRibbonFormEx.Show()
    End Sub
End Class