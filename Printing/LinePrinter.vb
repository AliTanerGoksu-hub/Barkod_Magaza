Imports System
Imports System.Collections
Imports System.Drawing
Imports System.IO
Imports System.Data.Linq
Imports System.Runtime.InteropServices
Imports System.Text
Imports Microsoft.VisualBasic
Public Enum LineAlignment
    Left
    Center
    Right
    Justify
End Enum
Friend Class BitmapData
    Public Property Dots() As BitArray
        Get
            Return m_Dots
        End Get
        Set(ByVal value As BitArray)
            m_Dots = value
        End Set
    End Property
    Private m_Dots As BitArray
    Public Property Height() As Integer
        Get
            Return m_Height
        End Get
        Set(ByVal value As Integer)
            m_Height = value
        End Set
    End Property
    Private m_Height As Integer
    Public Property Width() As Integer
        Get
            Return m_Width
        End Get
        Set(ByVal value As Integer)
            m_Width = value
        End Set
    End Property
    Private m_Width As Integer
End Class
Public Class LinePrinter
    Private ReadOnly _printerName As String
    Private _hprinter As IntPtr = IntPtr.Zero
    Private ReadOnly _maxChars As Integer
    Private ReadOnly _codePage As Integer
    Public Sub New(ByVal printerName As String, ByVal maxChars As Integer, ByVal codepage As Integer)
        _maxChars = maxChars
        _codePage = codepage
        _printerName = printerName
    End Sub
    Public Sub Beep(Optional ByVal times As Char = ChrW(2), Optional ByVal duration As Char = ChrW(5))
        WriteData(CChar(ChrW(&H1B)) + "B" + times + duration)
    End Sub
    Public Sub EnableBold()
        WriteData(CChar(ChrW(&H1B)) + "G" + CChar(ChrW(1)))
    End Sub
    Public Sub DisableBold()
        WriteData(CChar(ChrW(&H1B)) + "G" + CChar(ChrW(0)))
    End Sub
    Public Sub SelectTurkishCodePage()
        WriteData(CChar(ChrW(&H1B)) + CChar(ChrW(&H1D)) + "t" + CChar(ChrW(12)))
    End Sub
    Public Sub Cut()
        WriteData(CChar(ChrW(&H1B)) + "d" + CChar(ChrW(1)))
        WriteData(CChar(ChrW(&H1D)) + "V" + CChar(ChrW(66)) + CChar(ChrW(0)))
    End Sub
    Public Sub WriteLine(ByVal line As String)
        WriteLine(line, 0, 0)
    End Sub
    Public Sub WriteLine(ByVal line As String, ByVal height As Integer, ByVal width As Integer)
        Dim h As Integer = height + (width * 16)
        WriteData(CChar(ChrW(&H1D)) + "!" + CChar(ChrW(h)))
        'if (alignment != LineAlignment.Justify)
        '    WriteData((char)0x1B + "a" + (char)((int)alignment));
        'else
        '{
        '    WriteData((char)0x1B + "a" + (char)0);
        '    line = PrinterHelper.AlignLine(_maxChars, width, line, alignment, true);
        '}
        WriteData(CChar(ChrW(&H1B)) + "a" + CChar(ChrW(0)))
        WriteData(line + CChar(ChrW(&HA)))
    End Sub
    Public Sub PrintWindow(ByVal line As String)
        'var chars = "▒▓";
        Const tl As String = "┌"
        Const tr As String = "┐"
        Const bl As String = "└"
        Const br As String = "┘"
        Const vl As String = "│"
        Const hl As String = "─"
        Const s As String = "░"
        WriteLine(tl + hl.PadLeft(_maxChars - 2, hl(0)) + tr, 1, 0)
        Dim text As String = vl + line.PadLeft((((_maxChars - 2) + line.Length) / 2), s(0))
        WriteLine(text + vl.PadLeft(_maxChars - text.Length, s(0)), 1, 0)
        WriteLine(bl + hl.PadLeft(_maxChars - 2, hl(0)) + br)
    End Sub
    Public Sub PrintFullLine(ByVal lineChar As Char)
        WriteLine(lineChar.ToString().PadLeft(_maxChars, lineChar))
    End Sub
    Public Sub PrintCenteredLabel(ByVal label As String, ByVal expandLabel__1 As Boolean)
        If expandLabel__1 Then
            label = ExpandLabel(label)
        End If
        Dim text As String = label.PadLeft((((_maxChars) + label.Length) / 2), "░"c)
        WriteLine(text + "░".PadLeft(_maxChars - text.Length, "░"c), 1, 0)
    End Sub
    Private Shared Function ExpandLabel(ByVal label As String) As String
        Dim result As String = ""
        For i As Integer = 0 To label.Length - 2
            result += label(i) + " "
        Next
        result += label(label.Length - 1)
        Return result
    End Function
    Public Sub StartDocument()
        If _hprinter = IntPtr.Zero Then
            _hprinter = PrinterHelper.GetPrinter(_printerName)
        End If
    End Sub
    Public Sub WriteData(ByVal data As Byte())
        If _hprinter <> IntPtr.Zero Then
            Dim dwWritten As Integer
            If Not PrinterHelper.WritePrinter(_hprinter, data, data.Length, dwWritten) Then
                BombWin32()
            End If
        End If
    End Sub
    Public Sub WriteData(ByVal data As String)
        Dim pBytes As Byte() = Encoding.GetEncoding(_codePage).GetBytes(data)
        WriteData(pBytes)
    End Sub
    Public Sub EndDocument()
        PrinterHelper.EndPrinter(_hprinter)
        _hprinter = IntPtr.Zero
    End Sub
    Private Shared Sub BombWin32()
        Throw New System.ComponentModel.Win32Exception(Marshal.GetLastWin32Error())
    End Sub
    Public Sub PrintBitmap(ByVal fileName As String)
        If File.Exists(fileName) Then
            Dim data As Byte() = GetDocument(fileName)
            WriteData(data)
        End If
    End Sub
    Private Shared Function GetBitmapData(ByVal bmpFileName As String) As BitmapData
        Using bitmap = DirectCast(Image.FromFile(bmpFileName), Bitmap)
            Const threshold As Integer = 127
            Dim index = 0
            Dim dimensions As Integer = bitmap.Width * bitmap.Height
            Dim dots = New BitArray(dimensions)
            Dim y
            Dim x
            For y = 0 To bitmap.Height - 1
                For x = 0 To bitmap.Width - 1
                    Dim color = bitmap.GetPixel(x, y)
                    Dim luminance = CInt(color.R * 0.3 + color.G * 0.59 + color.B * 0.11)
                    dots(index) = (luminance < threshold)
                    index += 1
                Next
            Next
            Return New BitmapData() With { _
             .Dots = dots, _
             .Height = bitmap.Height, _
             .Width = bitmap.Width _
            }
        End Using
    End Function
    Private Shared Sub RenderLogo(ByVal bw As BinaryWriter, ByVal fileName As String)
        Dim data = GetBitmapData(fileName)
        Dim dots = data.Dots
        Dim width = BitConverter.GetBytes(data.Width)
        bw.Write(AsciiControlChars.Escape)
        bw.Write("3"c)
        bw.Write(CByte(24))
        Dim offset As Integer = 0
        While offset < data.Height
            bw.Write(AsciiControlChars.Escape)
            bw.Write("*"c)
            ' bit-image mode
            bw.Write(CByte(33))
            ' 24-dot double-density
            bw.Write(width(0))
            ' width low byte
            bw.Write(width(1))
            ' width high byte
            For x As Integer = 0 To data.Width - 1
                For k As Integer = 0 To 2
                    Dim slice As Byte = 0
                    For b As Integer = 0 To 7
                        Dim y As Integer = (((offset / 8) + k) * 8) + b
                        Dim i As Integer = (y * data.Width) + x
                        Dim v As Boolean = False
                        If i < dots.Length Then
                            v = dots(i)
                        End If
                        slice = slice Or CByte((If(v, 1, 0)) << (7 - b))
                    Next
                    bw.Write(slice)
                Next
            Next
            offset += 24
            bw.Write(AsciiControlChars.Newline)
        End While
        bw.Write(AsciiControlChars.Escape)
        bw.Write("3"c)
        bw.Write(CByte(30))
    End Sub
    Private Shared Function GetDocument(ByVal fileName As String) As Byte()
        Using ms = New MemoryStream()
            Using bw = New BinaryWriter(ms)
                bw.Write(AsciiControlChars.Escape)
                bw.Write("@"c)
                RenderLogo(bw, fileName)
                bw.Flush()
                Return ms.ToArray()
            End Using
        End Using
    End Function
    Public Sub OpenCashDrawer()
        ' http://social.msdn.microsoft.com/forums/en-US/netfxbcl/thread/35575dd8-7593-4fe6-9b57-64ad6b5f7ae6/
        WriteData((CChar(ChrW(27)) + CChar(ChrW(112)) + CChar(ChrW(0)) + CChar(ChrW(25)) + CChar(ChrW(250))).ToString())
    End Sub
    Public Sub ExecCommand(ByVal command As String)
        If Not String.IsNullOrEmpty(command) Then
            Dim data = command.Trim().Split(",") '.[Select](Function(x) Convert.ToInt32(x)).Aggregate("", Function(current, i) current + CChar(i))
            '[Select](Function(x) Convert.ToInt32(x)).Aggregate("", Function(current, i) current + CChar(i))
            WriteData(data)
        End If
    End Sub
End Class
'=======================================================
'Service provided by Telerik (www.telerik.com)
'Conversion powered by NRefactory.
'Twitter: @telerik, @toddanglin
'Facebook: facebook.com/telerik
'=======================================================
