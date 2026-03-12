Imports System.Collections.Generic
Imports System.IO
Imports System.Data.Linq
Imports System.Runtime.InteropServices
Imports System.Text.RegularExpressions
Public NotInheritable Class AsciiControlChars
    Private Sub New()
    End Sub
    Public Const Nul As Char = CChar(ChrW(&H0))
    Public Const FormFeed As Char = CChar(ChrW(&HC))
    Public Const Escape As Char = CChar(ChrW(&H1B))
    Public Const Newline As Char = CChar(ChrW(&HA))
    Public Const GroupSeparator As Char = CChar(ChrW(&H1D))
    Public Const HorizontalTab As Char = CChar(ChrW(&H9))
    Public Const CarriageReturn As Char = CChar(ChrW(&HD))
    Public Const Cancel As Char = CChar(ChrW(&H18))
    Public Const DataLinkEscape As Char = CChar(ChrW(&H10))
    Public Const EndOfTransmission As Char = CChar(ChrW(&H4))
    Public Const FileSeparator As Char = CChar(ChrW(&H1C))
End Class
Public Class PrinterHelper
    Private Shared Function GetTag(ByVal line As String) As String
        If Regex.IsMatch(line, "<[^>]+>") Then
            Dim tag = Regex.Match(line, "<[^>]+>").Groups(0).Value
            Return tag
        End If
        Return ""
    End Function
    'Public Shared Function AlignLines(ByVal lines As IEnumerable(Of String), ByVal maxWidth As Integer, ByVal canBreak As Boolean) As IEnumerable(Of String)
    'Dim columnWidths = CalculateColumnWidths(lines)
    'Dim result = New List(Of String)()
    'Dim i As Integer
    'For i = 0 To lines.count() - 1
    'Dim line = lines.ElementAt(i)
    'Dim lastWidth = 0
    'If line.Length > 3 AndAlso [Char].IsNumber(line(3)) AndAlso [Char].IsNumber(line(2)) Then
    'lastWidth = Convert.ToInt32(line(3).ToString())
    'End If
    'If line.Length < 4 Then
    'result.Add(line)
    'ElseIf line.ToLower().StartsWith("<l") Then
    'result.Add(AlignLine(maxWidth, lastWidth, line, LineAlignment.Left, canBreak))
    'ElseIf line.ToLower().StartsWith("<r") Then
    'result.Add(AlignLine(maxWidth, lastWidth, line, LineAlignment.Right, canBreak))
    'ElseIf line.ToLower().StartsWith("<c") Then
    'result.Add(AlignLine(maxWidth, lastWidth, line, LineAlignment.Center, canBreak))
    'ElseIf line.ToLower().StartsWith("<j") Then
    'result.Add(AlignLine(maxWidth, lastWidth, line, LineAlignment.Justify, canBreak, columnWidths(0)))
    'If i < lines.Count() - 1 AndAlso columnWidths.Count > 0 AndAlso (Not lines.ElementAt(i + 1).ToLower().StartsWith("<j") OrElse lines.ElementAt(i + 1).Split("|"c).Length <> columnWidths(0).Length) Then
    'columnWidths.RemoveAt(0)
    'End If
    'ElseIf line.ToLower().StartsWith("<f>") Then
    'Dim c = If(line.Contains(">"), line.Substring(line.IndexOf(">") + 1).Trim(), line.Trim())
    'If c.Length = 1 Then
    'result.Add(c.PadLeft(maxWidth, c(0)))
    'End If
    'Else
    'result.Add(line)
    'End If
    'Next
    'Return result
    'End Function
    Private Shared Function CalculateColumnWidths(ByVal lines As IEnumerable(Of String)) As IList(Of Integer())
        Dim result = New List(Of Integer())()
        Dim tableNo = 0
        Dim line
        For Each line In lines
            If line.ToLower().StartsWith("<j") Then
                Dim parts = line.Split("|"c)
                If tableNo = 0 OrElse parts.Length <> result(tableNo - 1).Length Then
                    tableNo = result.Count + 1
                    result.Add(New Integer(parts.Length - 1) {})
                End If
                For i As Integer = 0 To parts.Length - 1
                    If result(tableNo - 1)(i) < parts(i).Length Then
                        result(tableNo - 1)(i) = parts(i).Length
                    End If
                Next
            Else
                tableNo = 0
            End If
        Next
        Return result
    End Function
    Public Shared Function AlignLine(ByVal maxWidth As Integer, ByVal width As Integer, ByVal line As String, ByVal alignment As LineAlignment, ByVal canBreak As Boolean, Optional ByVal columnWidths As Integer() = Nothing) As String
        maxWidth = maxWidth / (width + 1)
        Dim tag = GetTag(line)
        line = line.Replace(tag, "")
        Select Case alignment
            Case LineAlignment.Left
                Return tag & line.PadRight(maxWidth, " "c)
            Case LineAlignment.Right
                Return tag & line.PadLeft(maxWidth, " "c)
            Case LineAlignment.Center
                Return tag & line.PadLeft(((maxWidth + line.Length) / 2), " "c).PadRight(maxWidth, " "c)
            Case LineAlignment.Justify
                Return tag & JustifyText(maxWidth, line, canBreak, columnWidths)
            Case Else
                Return tag & line
        End Select
    End Function
    Private Shared Function JustifyText(ByVal maxWidth As Integer, ByVal line As String, ByVal canBreak As Boolean, Optional ByVal columnWidths As IList(Of Integer) = Nothing) As String
        Dim parts = line.Split("|"c)
        If parts.Length = 1 Then
            Return line
        End If
        Dim text = ""
        Dim i
        For i = parts.Length - 1 To 1 Step -1
            Dim l = If(columnWidths IsNot Nothing, columnWidths(i), parts(i).Length)
            parts(i) = parts(i).Trim().PadLeft(l)
            text = parts(i) & text
        Next
        If Not canBreak AndAlso parts(0).Length > maxWidth Then
            parts(0) = parts(0).Substring(0, maxWidth)
        End If
        If canBreak AndAlso parts(0).Length + text.Length > maxWidth Then
            Return parts(0).Trim() & vbLf & text.PadLeft(maxWidth)
        End If
        Return parts(0).PadRight(maxWidth - text.Length).Substring(0, maxWidth - text.Length) & text
    End Function
    Public Shared Function GetPrinter(ByVal szPrinterName As String) As IntPtr
        Dim di = New DOCINFOA() With {.pDocName = "Samba POS Document", .pDataType = "RAW"}
        Dim hPrinter As IntPtr
        If Not OpenPrinter(szPrinterName, hPrinter, IntPtr.Zero) Then
            BombWin32()
        End If
        If Not StartDocPrinter(hPrinter, 1, di) Then
            BombWin32()
        End If
        If Not StartPagePrinter(hPrinter) Then
            BombWin32()
        End If
        Return hPrinter
    End Function
    Public Shared Sub EndPrinter(ByVal hPrinter As IntPtr)
        EndPagePrinter(hPrinter)
        EndDocPrinter(hPrinter)
        ClosePrinter(hPrinter)
    End Sub
    Public Shared Sub SendBytesToPrinter(ByVal szPrinterName As String, ByVal pBytes As Byte())
        Dim hPrinter = GetPrinter(szPrinterName)
        Dim dwWritten As Integer
        If Not WritePrinter(hPrinter, pBytes, pBytes.Length, dwWritten) Then
            BombWin32()
        End If
        EndPrinter(hPrinter)
    End Sub
    Public Shared Sub SendFileToPrinter(ByVal szPrinterName As String, ByVal szFileName As String)
        Dim fs = New FileStream(szFileName, FileMode.Open)
        Dim len = CInt(fs.Length)
        Dim bytes = New [Byte](len - 1) {}
        fs.Read(bytes, 0, len)
        SendBytesToPrinter(szPrinterName, bytes)
    End Sub
    Private Shared Sub BombWin32()
        Throw New System.ComponentModel.Win32Exception(Marshal.GetLastWin32Error())
    End Sub
    <StructLayout(LayoutKind.Sequential)> _
    Public Class DOCINFOA
        Public pDocName As String
        Public pOutputFile As String
        Public pDataType As String
    End Class
    <DllImport("winspool.Drv", SetLastError:=True)> _
    Public Shared Function OpenPrinter(ByVal szPrinter As String, ByRef hPrinter As IntPtr, ByVal pd As IntPtr) As Boolean
    End Function
    <DllImport("winspool.Drv", SetLastError:=True)> _
    Public Shared Function ClosePrinter(ByVal hPrinter As IntPtr) As Boolean
    End Function
    <DllImport("winspool.Drv", SetLastError:=True)> _
    Public Shared Function StartDocPrinter(ByVal hPrinter As IntPtr, ByVal level As Int32, ByVal di As DOCINFOA) As Boolean
    End Function
    <DllImport("winspool.Drv", SetLastError:=True)> _
    Public Shared Function EndDocPrinter(ByVal hPrinter As IntPtr) As Boolean
    End Function
    <DllImport("winspool.Drv", SetLastError:=True)> _
    Public Shared Function StartPagePrinter(ByVal hPrinter As IntPtr) As Boolean
    End Function
    <DllImport("winspool.Drv", SetLastError:=True)> _
    Public Shared Function EndPagePrinter(ByVal hPrinter As IntPtr) As Boolean
    End Function
    <DllImport("winspool.Drv", SetLastError:=True)> _
    Public Shared Function WritePrinter(ByVal hPrinter As IntPtr, ByVal pBytes As Byte(), ByVal dwCount As Int32, ByRef dwWritten As Int32) As Boolean
    End Function
End Class
