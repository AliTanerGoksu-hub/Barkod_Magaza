' ============================================================================
' PARAMETRE SERVİSİ
' ============================================================================
' tbParamGenel tablosundan AI parametrelerini okur
' ============================================================================

Imports System.Data.OleDb
Imports System.Collections.Generic

Public Class ParameterService
    
    Private connectionString As String = connection
    Private parameters As Dictionary(Of String, Object)
    
    Public Sub New()
        LoadParameters()
    End Sub
    
    ''' <summary>
    ''' Parametreleri yükle
    ''' </summary>
    Public Sub LoadParameters()
        Try
            parameters = New Dictionary(Of String, Object)
            
            Using conn As New OleDbConnection(connectionString)
                conn.Open()
                
                Dim cmd As New OleDbCommand("SELECT TOP 1 * FROM tbParamGenel", conn)
                Dim reader As OleDbDataReader = cmd.ExecuteReader()
                
                If reader.Read() Then
                    ' Tüm alanları oku
                    For i As Integer = 0 To reader.FieldCount - 1
                        Dim fieldName As String = reader.GetName(i)
                        Dim fieldValue As Object = If(reader.IsDBNull(i), Nothing, reader.GetValue(i))
                        parameters(fieldName) = fieldValue
                    Next
                End If
                
                reader.Close()
            End Using
            
            Debug.WriteLine($"Parametreler yüklendi: {parameters.Count} adet")
        Catch ex As Exception
            Debug.WriteLine($"LoadParameters hatası: {ex.Message}")
            ' Varsayılan değerler
            parameters = New Dictionary(Of String, Object) From {
                {"bAIKullan", False},
                {"bBaslikOlustur", False},
                {"bAciklamaOlustur", False},
                {"bTalimatOlustur", False},
                {"bGorselBul", False},
                {"nGunlukAILimit", 100}
            }
        End Try
    End Sub
    
    ''' <summary>
    ''' AI aktif mi?
    ''' </summary>
    Public Function IsAIEnabled() As Boolean
        If parameters.ContainsKey("bAIKullan") AndAlso parameters("bAIKullan") IsNot Nothing Then
            Return Convert.ToBoolean(parameters("bAIKullan"))
        End If
        Return False
    End Function
    
    ''' <summary>
    ''' Özellik aktif mi?
    ''' </summary>
    Public Function IsFeatureEnabled(featureName As String) As Boolean
        If Not IsAIEnabled() Then Return False
        
        If parameters.ContainsKey(featureName) AndAlso parameters(featureName) IsNot Nothing Then
            Return Convert.ToBoolean(parameters(featureName))
        End If
        Return False
    End Function
    
    ''' <summary>
    ''' Parametre değeri al
    ''' </summary>
    Public Function GetParameter(paramName As String) As Object
        If parameters.ContainsKey(paramName) Then
            Return parameters(paramName)
        End If
        Return Nothing
    End Function
    
    ''' <summary>
    ''' Parametre kaydet
    ''' </summary>
    Public Function SetParameter(paramName As String, value As Object) As Boolean
        Try
            Using conn As New OleDbConnection(connectionString)
                conn.Open()
                
                ' Önce kolonun var olup olmadığını kontrol et
                Dim columnExists As Boolean = False
                Try
                    Dim checkCmd As New OleDbCommand($"SELECT TOP 1 [{paramName}] FROM tbParamGenel", conn)
                    checkCmd.ExecuteScalar()
                    columnExists = True
                Catch
                    columnExists = False
                End Try
                
                ' Kolon yoksa ekle
                If Not columnExists Then
                    Try
                        Dim dataType As String = "NVARCHAR(500)"
                        If paramName.StartsWith("b") Then
                            dataType = "BIT"
                        ElseIf paramName.StartsWith("n") Then
                            dataType = "INT"
                        ElseIf paramName.StartsWith("l") Then
                            dataType = "DECIMAL(18,2)"
                        End If
                        
                        Dim alterCmd As New OleDbCommand($"ALTER TABLE tbParamGenel ADD [{paramName}] {dataType}", conn)
                        alterCmd.ExecuteNonQuery()
                        Debug.WriteLine($"Kolon eklendi: {paramName} ({dataType})")
                    Catch alterEx As Exception
                        Debug.WriteLine($"Kolon eklenemedi: {paramName} - {alterEx.Message}")
                        Return False
                    End Try
                End If
                
                ' Şimdi güncelle (tek satırlık tablo)
                Dim cmd As New OleDbCommand($"UPDATE tbParamGenel SET [{paramName}] = ?", conn)
                If value Is Nothing OrElse (TypeOf value Is String AndAlso String.IsNullOrEmpty(value.ToString())) Then
                    cmd.Parameters.AddWithValue("?", DBNull.Value)
                Else
                    cmd.Parameters.AddWithValue("?", value)
                End If
                cmd.ExecuteNonQuery()
                
                ' Cache'i güncelle
                parameters(paramName) = value
                
                Return True
            End Using
        Catch ex As Exception
            Debug.WriteLine($"SetParameter hatası: {paramName} = {value} - {ex.Message}")
            MessageBox.Show($"Parametre kaydedilemedi: {paramName}" & vbCrLf & vbCrLf & ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
        End Try
    End Function
    
End Class
