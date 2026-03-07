Public Class SorguClass
    Dim yeniTarih As String = ""
    Dim dt As Date
    Dim ilkTarih As String = ""
    Dim silinebilir As Boolean = False
    Dim degisen As String = ""
    Public hata As Boolean = False
    Public Function sorgu(ByVal query As String) As String
        Try
            Dim cmd As New OleDb.OleDbCommand
            Dim con As New OleDb.OleDbConnection
            con.ConnectionString = connection
            cmd.Connection = con
            If con.State = ConnectionState.Closed Then
                con.Open()
            End If
            cmd.CommandText = sorgu_query(query)
            Return cmd.ExecuteScalar.ToString()
            con.Close()
        Catch ex As Exception
            MessageBox.Show("Veri Geri Dönüş Sorgusunda Hata Oluştu!", "Business Smart")
            sorgu_Destek("Veri Geri Dönüş Sorgusunda Hata", query, "sorgu()", "SorguClass.vb")
        End Try
    End Function
    Public Function sorgu_Web(ByVal query As String, Optional ByVal sConnection As String = "") As String
        Try
            Dim cmd As New OleDb.OleDbCommand
            Dim con As New OleDb.OleDbConnection
            If sConnection = "" Then
                con.ConnectionString = connection
            Else
                con.ConnectionString = sConnection
            End If
            cmd.Connection = con
            If con.State = ConnectionState.Closed Then
                con.Open()
            End If
            cmd.CommandText = sorgu_query(query)
            Return cmd.ExecuteScalar.ToString()
            con.Close()
        Catch ex As Exception
            MessageBox.Show("Veri Geri Dönüş Sorgusunda Hata Oluştu!", "Business Smart")
            sorgu_Destek("Veri Geri Dönüş Sorgusunda Hata", query, "sorgu()", "SorguClass.vb")
        End Try
    End Function
    Public Function sorgu_Destek(ByVal islem As String, ByVal gSorgu As String, ByVal functionAdi As String, ByVal formAdi As String)
        Try
            Dim cmd As New OleDb.OleDbCommand
            Dim con As New OleDb.OleDbConnection
            Dim query As String = ""
            con.ConnectionString = connection
            cmd.Connection = con
            If con.State = ConnectionState.Closed Then
                con.Open()
            End If
            query = "SET DATEFORMAT DMY INSERT INTO tbDestekLog VALUES('" & kullaniciadi & "', '" & islem & "', "
            query += "'" & guncelTarih() & "', '" & gSorgu & "', '" & functionAdi & "', '" & formAdi & "')"
            cmd.CommandText = sorgu_query(query)
            cmd.ExecuteNonQuery()
            con.Close()
        Catch ex As Exception
        End Try
    End Function
    Public Function sorgu_tam(ByVal query As String)
        Try
            Dim cmd As New OleDb.OleDbCommand
            Dim con As New OleDb.OleDbConnection
            If sConnection = "" Then
                con.ConnectionString = connection
            Else
                con.ConnectionString = sConnection
            End If
            cmd.Connection = con
            If con.State = ConnectionState.Closed Then
                con.Open()
            End If
            cmd.CommandText = sorgu_query(query)
            cmd.ExecuteNonQuery()
            con.Close()
        Catch ex As Exception
            hata = True
            MessageBox.Show("Kayıt İşlemi Başarısız!", "Business Smart")
            sorgu_Destek("Veri Kayıt Sorgusunda Hata", query, "sorgu_tam()", "SorguClass.vb")
        End Try
    End Function
    Public Function sorgu_tamWeb(ByVal query As String, Optional ByVal sConnection As String = "") As Boolean
        Dim OK As Boolean = False
        Try
            Dim cmd As New OleDb.OleDbCommand
            Dim con As New OleDb.OleDbConnection
            If sConnection = "" Then
                con.ConnectionString = connection
            Else
                con.ConnectionString = sConnection
            End If
            cmd.Connection = con
            If con.State = ConnectionState.Closed Then
                con.Open()
            End If
            cmd.CommandText = sorgu_query(query)
            cmd.ExecuteNonQuery()
            con.Close()
            OK = True
        Catch ex As Exception
            OK = False
            hata = True
            MessageBox.Show("Kayıt İşlemi Başarısız!", "Business Smart")
            sorgu_Destek("Veri Kayıt Sorgusunda Hata", query, "sorgu_tam()", "SorguClass.vb")
        End Try
        Return OK
    End Function
    Public Function sorgu_tamWebResim(ByVal ds_tbStokResmi As DataSet, Optional ByVal sConnection As String = "") As Boolean
        Dim OK As Boolean = False
        Try
            Dim da As New OleDb.OleDbDataAdapter
            Dim cmd As New OleDb.OleDbCommand
            Dim con As New OleDb.OleDbConnection
            da.InsertCommand = cmd
            cmd.Connection = con
            con.ConnectionString = connection
            cmd.CommandText = "SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED INSERT INTO tbStokResmi(sModel, pResim, sAciklama, nSira, sKullaniciAdi, dteKayitTarihi) VALUES(?, ?, ?, ?, ?, ?)"
            cmd.Parameters.AddRange(New System.Data.OleDb.OleDbParameter() {New System.Data.OleDb.OleDbParameter("sModel", System.Data.OleDb.OleDbType.[Char], 0, "sModel"), New System.Data.OleDb.OleDbParameter("pResim", System.Data.OleDb.OleDbType.VarBinary, 2147483647, "pResim"), New System.Data.OleDb.OleDbParameter("sAciklama", System.Data.OleDb.OleDbType.[Char], 0, "sAciklama"), New System.Data.OleDb.OleDbParameter("nSira", System.Data.OleDb.OleDbType.[Integer], 0, "nSira"), New System.Data.OleDb.OleDbParameter("sKullaniciAdi", System.Data.OleDb.OleDbType.[Char], 0, "sKullaniciAdi"), New System.Data.OleDb.OleDbParameter("dteKayitTarihi", System.Data.OleDb.OleDbType.DBTimeStamp, 0, "dteKayitTarihi")})
            da.Update(ds_tbStokResmi.Tables(0))
            da = Nothing
            OK = True
        Catch ex As Exception
            OK = False
            hata = True
            MessageBox.Show("Kayıt İşlemi Başarısız!", "Business Smart")
            sorgu_Destek("Veri Kayıt Sorgusunda Hata", "", "sorgu_tamWebResim()", "SorguClass.vb")
        End Try
        Return OK
    End Function
    Public Function sorgu_DS(ByVal query As String, Optional ByVal sTable As String = "TABLE1", Optional ByVal sConnection As String = "") As DataSet
        Try
            Dim con As New OleDb.OleDbConnection
            Dim cmd As New OleDb.OleDbCommand
            Dim adapter As New OleDb.OleDbDataAdapter
            If sConnection = "" Then
                con.ConnectionString = connection
            Else
                con.ConnectionString = sConnection
            End If
            cmd.CommandTimeout = Nothing
            adapter.SelectCommand = cmd
            cmd.CommandText = query
            cmd.Connection = con
            If con.State = ConnectionState.Closed Then
                con.Open()
            End If
            Dim DS As New DataSet
            adapter.Fill(DS, sTable)
            con.Close()
            Return DS
            cmd = Nothing
            adapter = Nothing
        Catch ex As Exception
            MessageBox.Show("Veri Dizisi Geri Dönüş Sorgusunda Hata Oluştu!!", "Business Smart")
            sorgu_Destek("Veri Dizisi Geri Dönüş Sorgusunda Hata", query, "sorgu_DS()", "SorguClass.vb")
        End Try
    End Function
    Public Function tbStokSilKontrol(ByVal nStokIDSon As String, ByVal turInd As Integer, ByVal surecAra As Integer) As Boolean
        yeniTarih = Now.Day & "." & Now.Month & "." & Now.Year
        dt = CDate(yeniTarih)
        ilkTarih = ""
        If turInd = 0 Then
            ilkTarih = dt.AddMonths(surecAra * -1)
        ElseIf turInd = 1 Then
            ilkTarih = dt.AddYears(surecAra * -1)
        End If
        silinebilir = False
        Try
            degisen = sorgu("set dateformat dmy select COUNT(*) from ASTOKETIKETTALEPBASLIK where (IND IN(select IND from ASTOKETIKETTALEPDETAY where STOKNO = " & nStokIDSon & ")) AND (TARIH between '" & ilkTarih & "' AND '" & yeniTarih & "')")
            If degisen = 0 Then
                degisen = sorgu("set dateformat dmy select COUNT(*) from ASTOKFIYATDEGISIMBASLIK where (IND IN (select IND from ASTOKFIYATDEGISIMDETAY where STOKNO = " & nStokIDSon & ")) AND (TARIH between '" & ilkTarih & "' AND '" & yeniTarih & "')")
                If degisen = 0 Then
                    degisen = sorgu("set dateformat dmy select COUNT(*) from ASTOKPAKETBASLIK where (FISNO IN (select FISNO from ASTOKPAKETDETAY where STOKNO = " & nStokIDSon & ")) AND (FISTARIHI between '" & ilkTarih & "' AND '" & yeniTarih & "')")
                    If degisen = 0 Then
                        degisen = sorgu("set dateformat dmy select COUNT(*) from tbSiparis where (nStokID = " & nStokIDSon & ") AND ((dteTeslimTarihi between '" & ilkTarih & "' AND '" & yeniTarih & "') OR (dteSiparisTarihi between '" & ilkTarih & "' AND '" & yeniTarih & "'))")
                        If degisen = 0 Then
                            degisen = sorgu("set dateformat dmy select COUNT(*) from tbStokFisiDetayi where (nStokID = " & nStokIDSon & ") AND ((dteIslemTarihi between '" & ilkTarih & "' AND '" & yeniTarih & "') OR (dteFisTarihi between '" & ilkTarih & "' AND '" & yeniTarih & "'))")
                            If degisen = 0 Then
                                degisen = sorgu("SELECT (SELECT isnull(SUM(tbStokFisiDetayi.lGirisMiktar1 - tbStokFisiDetayi.lCikisMiktar1), 0) FROM tbStokFisiDetayi WHERE tbStok.nStokID = tbStokFisiDetayi.nStokID) AS Mevcut FROM tbStok where nStokID = " & nStokIDSon & "")
                                If degisen = 0 Then
                                    silinebilir = True
                                End If
                            End If
                        End If
                    End If
                End If
            End If
        Catch ex As Exception
        End Try
        Return silinebilir
    End Function
    Public Function guncelTarih(Optional ByVal tur As String = "") As String
        If Trim(tur) = "tarih" Then
            Return Now.Date.Day.ToString() & "." & Now.Date.Month.ToString() & "." & Now.Date.Year.ToString()
        ElseIf Trim(tur) = "saat" Then
            Return Now.Hour.ToString() & ":" & Now.Minute.ToString() & ":" & Now.Second.ToString()
        Else
            Return Now.Date.Day.ToString() & "." & Now.Date.Month.ToString() & "." & Now.Date.Year.ToString() & " " & Now.Hour.ToString() & ":" & Now.Minute.ToString() & ":" & Now.Second.ToString()
        End If
    End Function
End Class
