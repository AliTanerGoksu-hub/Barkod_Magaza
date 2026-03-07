''' <summary>
''' Exception indicating that an error occured while
''' saving or restoring user settings data.
''' </summary>
<Serializable()> _
Public Class UserSettingsException
    Inherits Exception
    ''' <summary>
    ''' Creates a new exception.
    ''' </summary>
    Public Sub New(ByVal message As String)
        MyBase.New(message)
    End Sub
    ''' <summary>
    ''' Creates a new exception with an inner exception.
    ''' </summary>
    Public Sub New(ByVal message As String, ByVal innerException As Exception)
        MyBase.New(message, innerException)
    End Sub
    ''' <summary>
    ''' Required because System.Exception implements ISerializable.
    ''' </summary>
    Protected Sub New(ByVal info As System.Runtime.Serialization.SerializationInfo, _
        ByVal context As System.Runtime.Serialization.StreamingContext)
        MyBase.New(info, context)
    End Sub
End Class
