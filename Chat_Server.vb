Option Strict Off
Public Class Chat_Server
#Region " Error Received "
    Private Sub wsk_ErrorReceived(ByVal sender As System.Object, ByVal e As Winsock2007.WinsockErrorReceivedEventArgs) Handles wskServer.ErrorReceived, wskListen.ErrorReceived
        Dim name As String = ""
        If sender Is wskListen Then name = "wskListen"
        If sender Is wskServer Then name = "wskServer"
        If sender Is wskClient Then name = "wskClient"
        Dim msg As String = name & " - " & e.Function & "(" & e.ErrorCode.ToString & "): " & e.Message & vbCrLf & e.Details
        Select Case name
            Case "wskServer", "wskListen"
                LogServer(msg)
            Case Else
                'LogClient(msg)
        End Select
    End Sub
#End Region
#Region " State Changed "
    Private Sub wsk_StateChanged(ByVal sender As Object, ByVal e As Winsock2007.WinsockStateChangedEventArgs) Handles wskListen.StateChanged, wskServer.StateChanged
        Dim name As String = ""
        If sender Is wskListen Then name = "wskListen"
        If sender Is wskServer Then name = "wskServer"
        If sender Is wskClient Then name = "wskClient"
        Dim msg As String = name & "::StateChanged - " & e.New_State.ToString
        Select Case name
            Case "wskListen"
                If wskListen.Protocol = Winsock2007.WinsockProtocols.Tcp Then
                    Select Case wskListen.State
                        Case Winsock2007.WinsockStates.Listening
                            cmdListenerListen.Enabled = False
                            cmdListenerClose.Enabled = True
                        Case Else
                            cmdListenerListen.Enabled = True
                            cmdListenerClose.Enabled = False
                    End Select
                End If
                lblLSState.Text = String.Format("Istemciler Durumu: {0}", e.New_State.ToString)
                LogServer(msg)
            Case "wskServer"
                If wskListen.Protocol = Winsock2007.WinsockProtocols.Tcp Then
                    Select Case wskServer.State
                        Case Winsock2007.WinsockStates.Closed, Winsock2007.WinsockStates.Closing
                            cmdServerClose.Enabled = False
                            cmdServerSend.Enabled = False
                            cmdServerSendFile.Enabled = False
                        Case Else
                            cmdServerClose.Enabled = True
                            cmdServerSend.Enabled = True
                            cmdServerSendFile.Enabled = True
                    End Select
                Else
                    Select Case wskServer.State
                        Case Winsock2007.WinsockStates.Listening
                            cmdServerClose.Enabled = True
                        Case Else
                            cmdServerClose.Enabled = False
                    End Select
                End If
                lblServerState.Text = String.Format("Server Durum: {0}", e.New_State.ToString)
                LogServer(msg)
            Case "wskClient"
                'If wskClient.Protocol = Winsock2007.WinsockProtocols.Tcp Then
                '    Select Case wskClient.State
                '        Case Winsock2007.WinsockStates.Closed
                '            cmdClientConnect.Enabled = True
                '            cmdClientClose.Enabled = False
                '            cmdClientSend.Enabled = False
                '            cmdClientSendFile.Enabled = False
                '        Case Winsock2007.WinsockStates.Closing
                '            cmdClientConnect.Enabled = False
                '            cmdClientClose.Enabled = False
                '            cmdClientSend.Enabled = False
                '            cmdClientSendFile.Enabled = False
                '        Case Else
                '            cmdClientConnect.Enabled = False
                '            cmdClientClose.Enabled = True
                '            cmdClientSend.Enabled = True
                '            cmdClientSendFile.Enabled = True
                '    End Select
                'End If
                'lblClientState.Text = String.Format("Client State: {0}", e.New_State.ToString)
                'LogClient(msg)
        End Select
    End Sub
#End Region
#Region " Logging "
    Private Sub LogServer(ByVal str As String)
        txtServerLog.AppendText(str & vbCrLf)
        txtServerLog.Select(txtServerLog.TextLength - 1, 0)
        txtServerLog.ScrollToCaret()
    End Sub
#End Region
#Region " Listener "
    Private Sub cmdListenerListen_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdListenerListen.Click
        If wskListen.Protocol = Winsock2007.WinsockProtocols.Udp Then
            wskServer.Protocol = Winsock2007.WinsockProtocols.Udp
            wskServer.Listen()
        Else
            wskListen.Listen()
        End If
    End Sub
    Private Sub cmdListenerClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdListenerClose.Click
        If wskListen.Protocol = Winsock2007.WinsockProtocols.Udp Then
            wskServer.Close()
        Else
            wskListen.Close()
        End If
    End Sub
    Private Sub wskListen_ConnectionRequest(ByVal sender As Object, ByVal e As Winsock2007.WinsockConnectionRequestEventArgs) Handles wskListen.ConnectionRequest
        LogServer("Listener: Connection request (" & e.ClientIP & ")")
        If e.ClientIP = "bad IP" Then
            LogServer("Listener: bad IP connection - cancelling")
            e.Cancel = True
        Else
            wskServer.Accept(e.Client)
        End If
    End Sub
#End Region
#Region " Server "
    Private Sub txtServerSend_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtServerSend.GotFocus
        Me.AcceptButton = cmdServerSend
    End Sub
    Private Sub cmdServerClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdServerClose.Click
        wskServer.Close()
    End Sub
    Private Sub cmdServerSend_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdServerSend.Click
        If Trim(txtServerSend.Text) <> "" Then
            'LogServer("Server: Gonderilen Mesaj """ & txtServerSend.Text & """")
            LogServer("Gönderilen Mesaj Saat: " & Now.ToLongTimeString)
            LogServer("""" & txtServerSend.Text & """")
            mesaj(False, txtServerSend.Text, kullaniciadi)
            wskServer.Send(txtServerSend.Text)
            txtServerSend.Text = ""
            txtServerSend.Focus()
        End If
    End Sub
    Private Sub cmdServerSendFile_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdServerSendFile.Click
        If dlgOpen.ShowDialog(Me) = Windows.Forms.DialogResult.OK Then
            'LogServer("Server: Gonderilen Dosya """ & dlgOpen.FileName & """")
            LogServer("Gonderilen Dosya Saat:" & Now.ToLongTimeString)
            LogServer("""" & dlgOpen.FileName & """")
            wskServer.SendFile(dlgOpen.FileName)
        End If
    End Sub
    Private Sub wskServer_DataArrival(ByVal sender As Object, ByVal e As Winsock2007.WinsockDataArrivalEventArgs) Handles wskServer.DataArrival
        LogServer("Server:(" & e.SourceIP & ": " & e.TotalBytes & " bytes Saat: " & Now.ToLongTimeString & ") ")
        Dim obj As Object = wskServer.Get()
        If obj.GetType() Is GetType(String) Then
            'LogServer("Server Mesaj: " & CStr(obj))
            LogServer("Gelen Mesaj: " & CStr(obj))
            mesaj(True, CStr(obj), Me.Text)
        ElseIf obj.GetType() Is GetType(Winsock2007.WinsockFileData) Then
            Dim wfd As Winsock2007.WinsockFileData = obj
            dlgSave.FileName = wfd.FileName
            If dlgSave.ShowDialog(Me) = Windows.Forms.DialogResult.OK Then
                wfd.SaveFile(dlgSave.FileName)
            End If
        End If
        Me.TopMost = True
        If Me.WindowState = FormWindowState.Minimized Then
            Me.WindowState = FormWindowState.Normal
        End If
        Me.TopMost = True
        Me.TopMost = False
    End Sub
    Private Sub wskServer_SendProgress(ByVal sender As Object, ByVal e As Winsock2007.WinsockSendEventArgs) Handles wskServer.SendProgress
        pbServer.Maximum = e.BytesTotal
        pbServer.Value = e.BytesSent
    End Sub
    Private Sub wskServer_SendComplete(ByVal sender As Object, ByVal e As Winsock2007.WinsockSendEventArgs) Handles wskServer.SendComplete
        pbServer.Maximum = e.BytesTotal
        pbServer.Value = e.BytesSent
    End Sub
#End Region
    Public port As String = 8080
    Public remote_port As String = 8080
    Private Sub Chat_Server_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        Try
            wskServer.Send("Baðlantý Kapandý")
            wskServer.Close()
            If wskListen.Protocol = Winsock2007.WinsockProtocols.Udp Then
                wskServer.Close()
            Else
                wskListen.Close()
            End If
        Catch ex As Exception
        End Try
        Try
            wskListen.Close()
        Catch ex As Exception
        End Try

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
    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        cmdServerSendFile.Enabled = False
        cmdServerSend.Enabled = False
        cmdServerClose.Enabled = False
        cmdListenerClose.Enabled = False
        If wskListen.Protocol = Winsock2007.WinsockProtocols.Udp Then
            wskServer.Protocol = Winsock2007.WinsockProtocols.Udp
            wskServer.Listen()
        Else
            wskListen.Listen()
        End If
        Me.TopMost = True
        If Me.WindowState = FormWindowState.Minimized Then
            Me.WindowState = FormWindowState.Normal
        End If
        Me.TopMost = False
    End Sub
End Class
