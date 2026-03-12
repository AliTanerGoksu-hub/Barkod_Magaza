Module mod_MizanKirilim

    Public Function GetKirilimSeviyesi(sHesap As String) As Integer
        If String.IsNullOrWhiteSpace(sHesap) Then Return 0
        Return sHesap.Split("."c).Length
    End Function

    Public Function GetUstKirilim(sHesap As String, seviye As Integer) As String
        Dim parts() As String = sHesap.Split("."c)
        If parts.Length < seviye Then Return sHesap

        Dim result As String = ""
        For i As Integer = 0 To seviye - 1
            If i > 0 Then result &= "."
            result &= parts(i)
        Next
        Return result
    End Function

    Public Sub ToplamlariKirilimlaraUygula(ByRef dt As DataTable)
        ' 3 → 2 kırılım
        For Each drUst As DataRow In dt.Rows
            If GetKirilimSeviyesi(drUst("sHesap3").ToString()) = 2 Then
                Dim ustKod As String = drUst("sHesap3").ToString()
                Dim lBorc As Decimal = 0, lAlacak As Decimal = 0

                For Each drAlt As DataRow In dt.Rows
                    If GetKirilimSeviyesi(drAlt("sHesap3").ToString()) = 3 AndAlso
                       GetUstKirilim(drAlt("sHesap3").ToString(), 2) = ustKod Then

                        lBorc += Convert.ToDecimal(drAlt("lBorcTutar"))
                        lAlacak += Convert.ToDecimal(drAlt("lAlacakTutar"))
                    End If
                Next

                drUst("lBorcTutar") = lBorc
                drUst("lAlacakTutar") = lAlacak

                Dim net = lBorc - lAlacak
                drUst("lBorcBakiye") = If(net > 0, net, 0)
                drUst("lAlacakBakiye") = If(net < 0, Math.Abs(net), 0)
            End If
        Next

        ' 2 → 1 kırılım
        For Each drUst As DataRow In dt.Rows
            If GetKirilimSeviyesi(drUst("sHesap3").ToString()) = 1 Then
                Dim ustKod As String = drUst("sHesap3").ToString()
                Dim lBorc As Decimal = 0, lAlacak As Decimal = 0

                For Each drAlt As DataRow In dt.Rows
                    If GetKirilimSeviyesi(drAlt("sHesap3").ToString()) = 2 AndAlso
                       GetUstKirilim(drAlt("sHesap3").ToString(), 1) = ustKod Then

                        lBorc += Convert.ToDecimal(drAlt("lBorcTutar"))
                        lAlacak += Convert.ToDecimal(drAlt("lAlacakTutar"))
                    End If
                Next

                drUst("lBorcTutar") = lBorc
                drUst("lAlacakTutar") = lAlacak

                Dim net = lBorc - lAlacak
                drUst("lBorcBakiye") = If(net > 0, net, 0)
                drUst("lAlacakBakiye") = If(net < 0, Math.Abs(net), 0)
            End If
        Next
    End Sub

End Module
