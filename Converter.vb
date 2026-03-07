Imports System.Drawing.Imaging
Public Class Converter
    Public Enum enumImageTypes
        Bitmap
        Jpeg
        Gif
        Tiff
        Png
    End Enum
    Public m_ImagePath As String
    Public m_ImageType As enumImageTypes
    Public m_Quality As Integer
    Public Sub New()
        Me.m_Quality = 100
    End Sub
    Public Sub New(ByVal inImagePath As String, ByVal inImageType As enumImageTypes)
        Me.New(inImagePath, inImageType, 100)
    End Sub
    Public Sub New(ByVal inImagePath As String, ByVal inImageType As enumImageTypes, ByVal inQuality As Integer)
        Me.m_ImagePath = inImagePath
        Me.m_ImageType = inImageType
        Me.m_Quality = inQuality
    End Sub
    Public Sub Convert()
        Dim bitmap As New Bitmap(m_ImagePath)
        Dim imgCodecs As ImageCodecInfo() = ImageCodecInfo.GetImageEncoders()
        Dim imgParams As New EncoderParameters(1)
        Dim imgQuality As New EncoderParameter(System.Drawing.Imaging.Encoder.Quality, m_Quality)
        Dim imgExt As String
        imgParams.Param(0) = imgQuality
        imgExt = imgCodecs(CInt(m_ImageType)).FilenameExtension
        imgExt = imgExt.Substring(1, imgExt.Length - 1)
        Dim fullpath As String = m_ImagePath.Substring(0, m_ImagePath.Length - 4) & imgExt.Split(";"c)(0).ToLower().Replace("ı"c, "i"c)
        bitmap.Save(fullpath, imgCodecs(CInt(m_ImageType)), imgParams)
        bitmap.Dispose()
    End Sub
    Public Property imagePath() As String
        Get
            Return Me.m_ImagePath
        End Get
        Set(ByVal value As String)
            Me.m_ImagePath = value
        End Set
    End Property
    Public Property imageType() As enumImageTypes
        Get
            Return Me.m_ImageType
        End Get
        Set(ByVal value As enumImageTypes)
            Me.m_ImageType = value
        End Set
    End Property
    Public Property quality() As Integer
        Get
            Return Me.m_Quality
        End Get
        Set(ByVal value As Integer)
            Me.m_Quality = value
        End Set
    End Property
End Class
