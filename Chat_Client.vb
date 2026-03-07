Option Strict Off
Imports DevExpress.XtraGrid.Views.Grid.ViewInfo
Imports DevExpress.XtraEditors.ViewInfo
Imports DevExpress.XtraGrid.Views.Base
Public Class Chat_Client
#Region " Error Received "
    Private Sub wsk_ErrorReceived(ByVal sender As Object, ByVal e As Winsock2007.WinsockErrorReceivedEventArgs) Handles wskClient.ErrorReceived
        Dim name As String
        If sender Is wskListen Then
            name = "wskListen"
        Else
            name = ""
        End If
        If sender Is wskServer Then name = "wskServer"
        If sender Is wskClient Then name = "wskClient"
        Dim msg As String = String.Format("{0} - {1}({2}): {3}{4}{5}", name, e.Function, e.ErrorCode, e.Message, vbCrLf, e.Details)
        Select Case name
            Case "wskServer", "wskListen"
                'LogServer(msg)
            Case Else
                LogClient(msg)
        End Select
    End Sub
#End Region
#Region " State Changed "
    Private Sub wsk_StateChanged(ByVal sender As Object, ByVal e As Winsock2007.WinsockStateChangedEventArgs) Handles wskClient.StateChanged
        Dim name As String
        If sender Is wskListen Then
            name = "wskListen"
        Else
            name = ""
        End If
        If sender Is wskServer Then name = "wskServer"
        If sender Is wskClient Then name = "wskClient"
        Dim msg As String = String.Format("{0}::Durum - {1}", name, e.New_State)
        Select Case name
            Case "wskListen"
                If wskListen.Protocol = Winsock2007.WinsockProtocols.Tcp Then
                    Select Case wskListen.State
                        Case Winsock2007.WinsockStates.Listening
                            'cmdListenerListen.Enabled = False
                            'cmdListenerClose.Enabled = True
                        Case Else
                            'cmdListenerListen.Enabled = True
                            'cmdListenerClose.Enabled = False
                    End Select
                End If
                'lblLSState.Text = String.Format("Listener State: {0}", e.New_State.ToString)
                'LogServer(msg)
            Case "wskServer"
                If wskListen.Protocol = Winsock2007.WinsockProtocols.Tcp Then
                    Select Case wskServer.State
                        Case Winsock2007.WinsockStates.Closed, Winsock2007.WinsockStates.Closing
                            'cmdServerClose.Enabled = False
                            'cmdServerSend.Enabled = False
                            'cmdServerSendFile.Enabled = False
                        Case Else
                            'cmdServerClose.Enabled = True
                            'cmdServerSend.Enabled = True
                            'cmdServerSendFile.Enabled = True
                    End Select
                Else
                    Select Case wskServer.State
                        Case Winsock2007.WinsockStates.Listening
                            'cmdServerClose.Enabled = True
                        Case Else
                            'cmdServerClose.Enabled = False
                    End Select
                End If
                'lblServerState.Text = String.Format("Server State: {0}", e.New_State.ToString)
                'LogServer(msg)
            Case "wskClient"
                If wskClient.Protocol = Winsock2007.WinsockProtocols.Tcp Then
                    Select Case wskClient.State
                        Case Winsock2007.WinsockStates.Closed
                            cmdClientConnect.Enabled = True
                            cmdClientClose.Enabled = False
                            cmdClientSend.Enabled = False
                            cmdClientSendFile.Enabled = False
                        Case Winsock2007.WinsockStates.Closing
                            cmdClientConnect.Enabled = False
                            cmdClientClose.Enabled = False
                            cmdClientSend.Enabled = False
                            cmdClientSendFile.Enabled = False
                        Case Else
                            cmdClientConnect.Enabled = False
                            cmdClientClose.Enabled = True
                            cmdClientSend.Enabled = True
                            cmdClientSendFile.Enabled = True
                    End Select
                End If
                lblClientState.Text = String.Format("Istemci Durumu: {0}", e.New_State.ToString)
                LogClient(msg)
        End Select
    End Sub
#End Region
#Region " Logging "
    Private Sub LogClient(ByVal str As String)
        txtClientLog.AppendText(str & vbCrLf)
        txtClientLog.Select(txtClientLog.TextLength - 1, 0)
        txtClientLog.ScrollToCaret()
    End Sub
#End Region
#Region " Listener "
    'Private Sub cmdListenerListen_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdListenerListen.Click
    '    If wskListen.Protocol = Winsock2007.WinsockProtocols.Udp Then
    '        wskServer.Protocol = Winsock2007.WinsockProtocols.Udp
    '        wskServer.Listen()
    '    Else
    '        wskListen.Listen()
    '    End If
    'End Sub
    'Private Sub cmdListenerClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdListenerClose.Click
    '    If wskListen.Protocol = Winsock2007.WinsockProtocols.Udp Then
    '        wskServer.Close()
    '    Else
    '        wskListen.Close()
    '    End If
    'End Sub
    Private Shared Sub wskListen_ConnectionRequest(ByVal e As Winsock2007.WinsockConnectionRequestEventArgs)
        'LogServer("Listener: Connection request (" & e.ClientIP & ")")
        If e.ClientIP = "bad IP" Then
            'LogServer("Listener: bad IP connection - cancelling")
            e.Cancel = True
        Else
            'wskServer.Accept(e.Client)
        End If
    End Sub
#End Region
#Region " Client "
    Private Sub txtClientSend_GotFocus(ByVal sender As Object, ByVal e As EventArgs) Handles txtClientSend.GotFocus
        AcceptButton = cmdClientSend
    End Sub
    Private Sub cmdClientConnect_Click(ByVal sender As Object, ByVal e As EventArgs) Handles cmdClientConnect.Click
        LogClient(String.Format("Istemci: Baglaniyor ({0})...", wskClient.RemoteHost))
        wskClient.Connect()
    End Sub
    Private Sub cmdClientClose_Click(ByVal sender As Object, ByVal e As EventArgs) Handles cmdClientClose.Click
        wskClient.Close()
    End Sub
    Private Sub cmdClientSend_Click(ByVal sender As Object, ByVal e As EventArgs) Handles cmdClientSend.Click
        If Trim(txtClientSend.Text) <> "" Then
            'LogClient("Istemci: Gonderilen Mesaj """ & txtClientSend.Text & """")
            LogClient("Gönderilen Mesaj Saat: " & Now.ToLongTimeString)
            LogClient(String.Format("""{0}""", txtClientSend.Text))
            mesaj(False, txtClientSend.Text, kullaniciadi)
            wskClient.Send(txtClientSend.Text)
            txtClientSend.Text = ""
            txtClientSend.Focus()
        End If
    End Sub
    Private Sub mesaj(ByVal bGelen As Boolean, ByVal sMessage As String, ByVal sKimden As String)
        sMessage = Now & vbTab & sKimden & " Diyor ki;" & vbCrLf & vbCrLf & sMessage
        Dim dr As DataRow = ds_tbMessage.Tables(0).NewRow
        dr("bGelen") = bGelen
        dr("nBoyut") = Len(sMessage)
        dr("sString") = sMessage
        dr("sKimden") = sKimden & " Diyor ki;"
        dr("dteTarih") = Now
        ds_tbMessage.Tables(0).Rows.Add(dr)
        GridView1.FocusedRowHandle = GridView1.RowCount - 1
    End Sub
    Private Sub cmdClientSendFile_Click(ByVal sender As Object, ByVal e As EventArgs) Handles cmdClientSendFile.Click
        If dlgOpen.ShowDialog(Me) = Windows.Forms.DialogResult.OK Then
            'LogClient("Istemci: Gonderilen Dosya """ & dlgOpen.FileName & """")
            LogClient("Gonderilen Dosya Saat:" & Now.ToLongTimeString)
            LogClient(String.Format("""{0}""", dlgOpen.FileName))
            wskClient.SendFile(dlgOpen.FileName)
        End If
    End Sub
    Private Sub wskClient_DataArrival(ByVal sender As Object, ByVal e As Winsock2007.WinsockDataArrivalEventArgs) Handles wskClient.DataArrival
        LogClient(String.Format("Istemci:({0}: {1} bytes Saat: {2})", e.SourceIP, e.TotalBytes, Now.ToLongTimeString))
        Dim obj As Object = wskClient.Get()
        If obj.GetType() Is GetType(String) Then
            LogClient("Gelen Mesaj: " & CStr(obj))
            mesaj(True, CStr(obj), Me.Text)
        ElseIf obj.GetType() Is GetType(Winsock2007.WinsockFileData) Then
            Dim wfd As Winsock2007.WinsockFileData = obj
            dlgSave.FileName = wfd.FileName
            If dlgSave.ShowDialog(Me) = Windows.Forms.DialogResult.OK Then
                wfd.SaveFile(dlgSave.FileName)
            End If
        End If
        TopMost = True
        If WindowState = FormWindowState.Minimized Then
            WindowState = FormWindowState.Normal
        End If
        TopMost = True
        TopMost = False
    End Sub
    Private Sub wskClient_SendProgress(ByVal sender As Object, ByVal e As Winsock2007.WinsockSendEventArgs) Handles wskClient.SendProgress
        pbClient.Maximum = e.BytesTotal
        pbClient.Value = e.BytesSent
    End Sub
    Private Sub wskClient_SendComplete(ByVal sender As Object, ByVal e As Winsock2007.WinsockSendEventArgs) Handles wskClient.SendComplete
        pbClient.Maximum = e.BytesTotal
        pbClient.Value = e.BytesSent
    End Sub
#End Region
    Public port As String = 8080
    Public remote_port As String = 8080
    Private Sub Chat_Client_FormClosing(ByVal sender As Object, ByVal e As FormClosingEventArgs) Handles Me.FormClosing
        wskClient.Close()
    End Sub
    Private Sub Form1_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
        If wskClient.Protocol = Winsock2007.WinsockProtocols.Udp Then
            cmdClientConnect.Enabled = False
            cmdClientClose.Enabled = False
        Else
            cmdClientClose.Enabled = False
            cmdClientSend.Enabled = False
            cmdClientSendFile.Enabled = False
        End If
        TopMost = True
        TopMost = False
        'cmdServerSendFile.Enabled = False
        'cmdServerSend.Enabled = False
        'cmdServerClose.Enabled = False
        'cmdListenerClose.Enabled = False
    End Sub
    Private Sub Timer1_Tick(ByVal e As EventArgs)
        If wskClient.State = Winsock2007.WinsockStates.Closed Then
            LogClient(String.Format("Istemci: Baglaniyor ({0})...", wskClient.RemoteHost))
            wskClient.Connect()
            'ElseIf wskClient.State = Winsock2007.WinsockStates.Closing Then
            '    LogClient("Client: Connecting (" & wskClient.RemoteHost & ")...")
            '    wskClient.Connect()
        End If
    End Sub
    Private Sub txtClientLog1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
    End Sub
    Private Sub GridView1_CustomDrawRowPreview(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Base.RowObjectCustomDrawEventArgs) Handles GridView1.CustomDrawRowPreview
        'Using vi As New RichTextEditViewInfo(RepositoryItemRichTextEdit1)
        '    'Dim info As ProductInfo = TryCast(GridView2.GetRow(e.RowHandle), ProductInfo)
        '    Dim dr As DataRow = GridView2.GetDataRow(e.RowHandle)
        '    vi.LoadText(dr("sString"))
        '    vi.UpdateAppearances()
        '    vi.CalcViewInfo(e.Graphics, System.Windows.Forms.MouseButtons.None, New Point(0, 0), e.Bounds)
        '    DevExpress.XtraEditors.Drawing.RichTextEditPainter.DrawRTF(vi, e.Cache)
        'End Using
        'e.Handled = True
    End Sub
End Class
