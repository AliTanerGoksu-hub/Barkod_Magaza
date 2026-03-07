''' <summary>
''' Audit Log Wrapper - ExecuteNonQuery işlemlerini otomatik loglar
''' </summary>
Public Module AuditLogWrapper
    
    ''' <summary>
    ''' ExecuteNonQuery wrapper - Otomatik audit log kaydeder
    ''' </summary>
    Public Function ExecuteNonQueryWithLog(cmd As Object, Optional modulAdi As String = "SIPARIS", Optional aciklama As String = "") As Integer
        Try
            Dim sonuc As Integer = 0
            Dim sqlKomut As String = ""
            
            ' SQL komutunu al
            If TypeOf cmd Is System.Data.OleDb.OleDbCommand Then
                sqlKomut = DirectCast(cmd, System.Data.OleDb.OleDbCommand).CommandText
                sonuc = DirectCast(cmd, System.Data.OleDb.OleDbCommand).ExecuteNonQuery()
            ElseIf TypeOf cmd Is System.Data.SqlClient.SqlCommand Then
                sqlKomut = DirectCast(cmd, System.Data.SqlClient.SqlCommand).CommandText
                sonuc = DirectCast(cmd, System.Data.SqlClient.SqlCommand).ExecuteNonQuery()
            Else
                Return 0
            End If
            
            ' INSERT, UPDATE, DELETE kontrolü
            Dim sqlUpper As String = sqlKomut.ToUpper()
            Dim islemTipi As String = ""
            Dim tabloAdi As String = ""
            Dim kayitID As Long = 0
            
            If sqlUpper.Contains("INSERT INTO") Then
                islemTipi = "YENI"
                tabloAdi = ExtractTableName(sqlKomut, "INSERT INTO")
            ElseIf sqlUpper.Contains("UPDATE") Then
                islemTipi = "GUNCELLE"
                tabloAdi = ExtractTableName(sqlKomut, "UPDATE")
            ElseIf sqlUpper.Contains("DELETE FROM") Then
                islemTipi = "SIL"
                tabloAdi = ExtractTableName(sqlKomut, "DELETE FROM")
            Else
                Return sonuc ' Log gerektirmeyen işlem
            End If
            
            ' tbSiparis işlemleri için log kaydet
            If tabloAdi.ToUpper().Contains("TBSIPARIS") And Not tabloAdi.ToUpper().Contains("ACIKLAMASI") Then
                Try
                    ' Açıklama oluştur
                    Dim logAciklama As String = aciklama
                    If String.IsNullOrEmpty(logAciklama) Then
                        logAciklama = islemTipi & " işlemi - " & tabloAdi
                    End If
                    
                    ' Miktar, fiyat gibi değerleri yakala
                    If sqlKomut.Contains("lMiktari") Then
                        logAciklama &= " [Miktar değişikliği]"
                    End If
                    If sqlKomut.Contains("lFiyati") Then
                        logAciklama &= " [Fiyat değişikliği]"
                    End If
                    If sqlKomut.Contains("nIskontoYuzdesi") Then
                        logAciklama &= " [İskonto değişikliği]"
                    End If
                    
                    LogSiparis(islemTipi, kayitID, "", logAciklama)
                Catch
                    ' Log hatası uygulamayı etkilemez
                End Try
            End If
            
            Return sonuc
            
        Catch ex As Exception
            Throw ex ' Orijinal hatayı fırlat
        End Try
    End Function
    
    ''' <summary>
    ''' SQL'den tablo adını çıkart
    ''' </summary>
    Private Function ExtractTableName(sql As String, keyword As String) As String
        Try
            Dim startIndex As Integer = sql.ToUpper().IndexOf(keyword) + keyword.Length
            Dim sqlPart As String = sql.Substring(startIndex).Trim()
            
            ' İlk kelimeyi al (tablo adı)
            Dim endIndex As Integer = sqlPart.IndexOf(" ")
            If endIndex > 0 Then
                Return sqlPart.Substring(0, endIndex).Trim()
            Else
                Return sqlPart
            End If
        Catch
            Return "Unknown"
        End Try
    End Function
    
End Module
