Imports System.ServiceModel
Imports System.Configuration
Imports business_smart.GibSorgula
Imports System.ServiceModel.Channels

Public Class QueryDocumentsClient
    Private ReadOnly serviceClient As New QueryDocumentsClient()
    'Private ReadOnly username As String = ConfigurationManager.AppSettings("admin_010033")
    'Private ReadOnly password As String = ConfigurationManager.AppSettings("Aa123456.")

    ''' <summary>
    ''' GÝB'e kayýtlý E-Fatura mükelleflerini VKN/TCKN ile sorgular.
    ''' </summary>
    ''' <param name="vkn_tckn">Sorgulanacak VKN veya TCKN</param>
    ''' <param name="startDate">Baþlangýç tarihi (yyyy-MM-dd, isteðe baðlý)</param>
    ''' <param name="finishDate">Bitiþ tarihi (yyyy-MM-dd, isteðe baðlý)</param>
    ''' <returns>UserQueryResponse nesnesi</returns>
    Public Function QueryUsers(vkn_tckn As String, Optional startDate As String = "", Optional finishDate As String = "") As GibSorgula.UserQueryResponse
        Try
            Using client As New GibSorgula.QueryDocumentWSClient()
                Using scope As New OperationContextScope(client.InnerChannel)
                    Dim prop As New HttpRequestMessageProperty()
                    'prop.Headers.Add("admin_010033", username)
                    'prop.Headers.Add("Aa123456.", password)
                    OperationContext.Current.OutgoingMessageProperties(HttpRequestMessageProperty.Name) = prop

                    Dim response = client.QueryUsers(vkn_tckn, startDate, finishDate)
                    Return response
                End Using
            End Using
        Catch ex As Exception
            Dim errorResponse As New GibSorgula.UserQueryResponse()
            errorResponse.queryState = "99"
            errorResponse.stateExplanation = "Servis hatasý: " & ex.Message
            Return errorResponse
        End Try
    End Function
End Class