Imports System.Runtime.InteropServices
Public Class ClKeyboard
#Region "Constants"
    Private Const GWL_STYLE As Integer = (-16)
    Private Const WS_BORDER As Integer = &H800000
    Private Const WS_CHILD As Integer = &H40000000
    Private Const HWND_BOTTOM As Integer = &H1
    Private Const HWND_TOP As Integer = &H0
    Private Const SWP_NOSIZE As Integer = &H1
    Private Const SWP_NOMOVE As Integer = &H2
    Private Const SWP_NOZORDER As Integer = &H4
    Private Const SWP_NOREDRAW As Integer = &H8
    Private Const SWP_NOACTIVATE As Integer = &H10
    Private Const SWP_FRAMECHANGED As Integer = &H20
    Private Const SWP_SHOWWINDOW As Integer = &H40
    Private Const SWP_HIDEWINDOW As Integer = &H80
    Private Const SWP_NOCOPYBITS As Integer = &H100
    Private Const SWP_NOOWNERZORDER As Integer = &H200
    Private Const SWP_NOSENDCHANGING As Integer = &H400
#End Region
    Private Shared OskProcess As Process
    <DllImport("user32.dll", EntryPoint:="SetWindowPos")> _
    Private Shared Function SetWindowPos(ByVal hWnd As IntPtr, ByVal hWndInsertAfter As Integer, ByVal X As Integer, ByVal Y As Integer, ByVal cx As Integer, ByVal cy As Integer, ByVal flags As Integer) As Boolean
    End Function
    <DllImport("user32.dll", EntryPoint:="SetWindowLong")> _
    Private Shared Function SetWindowLong(ByVal hWnd As IntPtr, ByVal index As Integer, ByVal value As Integer) As Integer
    End Function
    Public Shared Sub Show()
        'If OskProcess Is Nothing Then
        OskProcess = New Process()
        OskProcess.StartInfo.UseShellExecute = False
        OskProcess.StartInfo.RedirectStandardOutput = True
        OskProcess.StartInfo.RedirectStandardError = True
        OskProcess.StartInfo.CreateNoWindow = True
        OskProcess.StartInfo.FileName = String.Format("{0}{1}osk.exe", Environment.GetFolderPath(Environment.SpecialFolder.System), IO.Path.DirectorySeparatorChar)
        OskProcess.StartInfo.Arguments = ""
        OskProcess.StartInfo.WorkingDirectory = Application.StartupPath
        OskProcess.Start()
        OskProcess.WaitForInputIdle()
        SetWindowLong(OskProcess.MainWindowHandle, GWL_STYLE, WS_BORDER Or WS_CHILD)
        'End If
        SetWindowPos(OskProcess.MainWindowHandle, HWND_BOTTOM, 0, My.Computer.Screen.WorkingArea.Height - 350, My.Computer.Screen.WorkingArea.Width, 350, SWP_SHOWWINDOW Or SWP_NOZORDER Or SWP_FRAMECHANGED)
    End Sub
    Public Shared Sub Hide()
        Try
            'SetWindowPos(OskProcess.MainWindowHandle, HWND_BOTTOM, 0, My.Computer.Screen.WorkingArea.Height - 350, My.Computer.Screen.WorkingArea.Width, 350, SWP_HIDEWINDOW Or SWP_NOZORDER)
        Catch ex As Exception
        End Try
    End Sub
    Public Shared Sub Kill()
        If OskProcess Is Nothing Then
            Return
        End If
        If OskProcess.HasExited = False Then
            OskProcess.Kill()
        End If
        OskProcess = Nothing
    End Sub
End Class
