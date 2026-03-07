Imports System.Windows.Forms
Imports System.Data

Module UiThreadHelpers
    ' DataRow("ResimBytes") atamasını UI thread üstünden güvenle yapar
    Public Sub SetRowBytesThreadSafe(owner As Control, row As DataRow, bytes As Byte())
        If owner IsNot Nothing AndAlso owner.IsHandleCreated AndAlso owner.InvokeRequired Then
            owner.BeginInvoke(CType(Sub() row("ResimBytes") = bytes, MethodInvoker))
        Else
            row("ResimBytes") = bytes
        End If
    End Sub
End Module