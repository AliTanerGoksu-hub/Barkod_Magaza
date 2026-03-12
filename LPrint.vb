'
' *  LPrinter - A simple line printer class in C#
' *  ============================================
' *  
' *  Written by Antonino Porcino, iz8bly@yahoo.it
' *
' *  26-sep-2008, public domain.
' *
' * 
' *  some useful print codes:
' *  ========================
' *    12 = FF (form feed)
' *    14 = enlarged on
' *    20 = enlarged off
' *    15 = compress on
' *    18 = compress off
' *    ESC + "E" = bold on
' *    ESC + "F" = bold off
' *    
' * 
' 
Imports System.Drawing.Printing
Imports System.Windows.Forms
Imports System.Runtime.InteropServices
Namespace LPrinterTest
    Class LPrinter
        ' Structure and API declarions:
        <StructLayout(LayoutKind.Sequential, CharSet:=CharSet.Ansi)> _
        Public Class DOCINFOA
            <MarshalAs(UnmanagedType.LPStr)> _
            Public pDocName As String
            <MarshalAs(UnmanagedType.LPStr)> _
            Public pOutputFile As String
            <MarshalAs(UnmanagedType.LPStr)> _
            Public pDataType As String
        End Class
        <DllImport("winspool.Drv", EntryPoint:="OpenPrinterA", SetLastError:=True, CharSet:=CharSet.Ansi, ExactSpelling:=True, CallingConvention:=CallingConvention.StdCall)> _
        Public Shared Function OpenPrinter(<MarshalAs(UnmanagedType.LPStr)> ByVal szPrinter As String, ByRef hPrinter As IntPtr, ByVal pd As IntPtr) As Boolean
        End Function
        <DllImport("winspool.Drv", EntryPoint:="ClosePrinter", SetLastError:=True, ExactSpelling:=True, CallingConvention:=CallingConvention.StdCall)> _
        Public Shared Function ClosePrinter(ByVal hPrinter As IntPtr) As Boolean
        End Function
        <DllImport("winspool.Drv", EntryPoint:="StartDocPrinterA", SetLastError:=True, CharSet:=CharSet.Ansi, ExactSpelling:=True, CallingConvention:=CallingConvention.StdCall)> _
        Public Shared Function StartDocPrinter(ByVal hPrinter As IntPtr, ByVal level As Int32, <[In](), MarshalAs(UnmanagedType.LPStruct)> ByVal di As DOCINFOA) As Boolean
        End Function
        <DllImport("winspool.Drv", EntryPoint:="EndDocPrinter", SetLastError:=True, ExactSpelling:=True, CallingConvention:=CallingConvention.StdCall)> _
        Public Shared Function EndDocPrinter(ByVal hPrinter As IntPtr) As Boolean
        End Function
        <DllImport("winspool.Drv", EntryPoint:="StartPagePrinter", SetLastError:=True, ExactSpelling:=True, CallingConvention:=CallingConvention.StdCall)> _
        Public Shared Function StartPagePrinter(ByVal hPrinter As IntPtr) As Boolean
        End Function
        <DllImport("winspool.Drv", EntryPoint:="EndPagePrinter", SetLastError:=True, ExactSpelling:=True, CallingConvention:=CallingConvention.StdCall)> _
        Public Shared Function EndPagePrinter(ByVal hPrinter As IntPtr) As Boolean
        End Function
        <DllImport("winspool.Drv", EntryPoint:="WritePrinter", SetLastError:=True, ExactSpelling:=True, CallingConvention:=CallingConvention.StdCall)> _
        Public Shared Function WritePrinter(ByVal hPrinter As IntPtr, ByVal pBytes As IntPtr, ByVal dwCount As Int32, ByRef dwWritten As Int32) As Boolean
        End Function
        '=================================================
        Private HandlePrinter As IntPtr
        Private ps As PrinterSettings
        Public Sub New()
            HandlePrinter = IntPtr.Zero
            ps = New PrinterSettings()
        End Sub
        Public Property PrinterName() As String
            Get
                Return ps.PrinterName
            End Get
            Set(ByVal value As String)
                ps.PrinterName = value
            End Set
        End Property
        Public Function ChoosePrinter() As Boolean
            Dim pd As New PrintDialog()
            pd.PrinterSettings = ps
            If pd.ShowDialog() = DialogResult.OK Then
                ps = pd.PrinterSettings
                Return True
            Else
                Return False
            End If
        End Function
        Public Function Open(ByVal DocName As String) As Boolean
            ' see if printer is already open
            If HandlePrinter <> IntPtr.Zero Then
                Return False
            End If
            ' opens the printer
            Dim risp As Boolean = OpenPrinter(ps.PrinterName, HandlePrinter, IntPtr.Zero)
            If risp = False Then
                Return False
            End If
            ' starts a print job
            Dim MyDocInfo As New DOCINFOA()
            MyDocInfo.pDocName = DocName
            MyDocInfo.pOutputFile = Nothing
            MyDocInfo.pDataType = "RAW"
            If StartDocPrinter(HandlePrinter, 1, MyDocInfo) Then
                StartPagePrinter(HandlePrinter)
                'starts a page       
                Return True
            Else
                Return False
            End If
        End Function
        Public Function Close() As Boolean
            If HandlePrinter = IntPtr.Zero Then
                Return False
            End If
            If Not EndPagePrinter(HandlePrinter) Then
                Return False
            End If
            If Not EndDocPrinter(HandlePrinter) Then
                Return False
            End If
            If Not ClosePrinter(HandlePrinter) Then
                Return False
            End If
            HandlePrinter = IntPtr.Zero
            Return True
        End Function
        Public Function Print(ByVal outputstring As String) As Boolean
            If HandlePrinter = IntPtr.Zero Then
                Return False
            End If
            Dim buf As IntPtr = Marshal.StringToCoTaskMemAnsi(outputstring)
            Dim done As Int32 = 0
            Dim ok As Boolean = WritePrinter(HandlePrinter, buf, outputstring.Length, done)
            Marshal.FreeCoTaskMem(buf)
            If Not ok Then
                Return False
            Else
                Return True
            End If
        End Function
        '        If Not MyPrinter.Open("Test Page") Then
        '	Return
        'End If
        'MyPrinter.Print("This text is sent to a line printer" & vbCr & vbLf)
        'MyPrinter.Print("===================================" & vbCr & vbLf)
        'MyPrinter.Close()
    End Class
End Namespace
