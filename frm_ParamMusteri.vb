Public Class frm_ParamMusteri 
    Public firmano
    Public donemno
    Public connection
    Public kullanici
    Dim conn As New OleDb.OleDbConnection
    Dim con As New OleDb.OleDbConnection
    Dim cmd As New OleDb.OleDbCommand
    Dim adapter As New OleDb.OleDbDataAdapter
    Dim DS As New DataSet
    Private Sub frm_ParamMusteri_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dataload_tbParamMusteri()
    End Sub
    Private Function sorgu_kriter_string(ByVal deger As String, ByVal kriter As String) As String
        Dim sorgu_kriter As String = ""
        If kriter = "Baþlar" Then
            sorgu_kriter = " LIKE '" & deger & "%' "
        ElseIf kriter = "Biter" Then
            sorgu_kriter = " LIKE '%" & deger & "' "
        ElseIf kriter = "Ýçerir" Then
            sorgu_kriter = " LIKE '%" & deger & "%' "
        ElseIf kriter = "Boþ" Then
            sorgu_kriter = " IS NULL "
        ElseIf kriter = "Dolu" Then
            sorgu_kriter = " <> '' "
        ElseIf kriter = "Farklý" Then
            sorgu_kriter = " <> '" & deger & "' "
        ElseIf kriter = "Büyük" Then
            sorgu_kriter = " >  '" & deger & "' "
        ElseIf kriter = "Küçük" Then
            sorgu_kriter = " < '" & deger & "' "
        ElseIf kriter = "Eþittir" Then
            sorgu_kriter = " = '" & deger & "' "
        End If
        Return sorgu_kriter
    End Function
    Private Function sorgu_query(ByVal query As String) As String
        query = Replace(query, "*!F", "F0" + firmano.ToString)
        query = Replace(query, "!D", "D000" + donemno.ToString)
        Return query
    End Function
    Private Function sorgu(ByVal query As String) As DataSet
        Dim con As New OleDb.OleDbConnection
        Dim cmd As New OleDb.OleDbCommand
        Dim adapter As New OleDb.OleDbDataAdapter
        con.ConnectionString = connection
        cmd.CommandTimeout = Nothing
        adapter.SelectCommand = cmd
        cmd.CommandText = query
        cmd.Connection = con
        con.Open()
        Dim DS As New DataSet
        Dim N As Integer = adapter.Fill(DS, "TABLE1")
        con.Close()
        Return DS
    End Function
    Public Sub Dataload_tbParamMusteri()
        Try
            ds_tbParamMusteri.Tables(0).Clear()
        Catch ex As Exception
        End Try
        Dim conn As New OleDb.OleDbConnection
        Dim cmd As New OleDb.OleDbCommand
        Dim adapter As New OleDb.OleDbDataAdapter
        conn.ConnectionString = connection
        adapter.SelectCommand = cmd
        cmd.CommandText = sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT TOP 1 * From tbParamMusteri")
        cmd.Connection = conn
        conn.Open()
        Dim N As Integer = adapter.Fill(ds_tbParamMusteri, "Table1")
        conn.Close()
    End Sub
    Private Function tbMusteri_kaydet_yeni(ByVal sMagaza As String, ByVal lKodu As String, ByVal sAdi As String, ByVal sSoyadi As String, ByVal nCinsiyet As Int64, ByVal lAylikGelir As Decimal, ByVal dteKartAcilisTarihi As DateTime, ByVal nIskontoPesin As Decimal, ByVal nIskontoKredili As Decimal, ByVal sUnvan As String, ByVal sVergiDairesi As String, ByVal sVergiNo As String, ByVal bYazismaEvAdresinemi As Integer, ByVal sEmail As String, ByVal sIsYeriAdi As String, ByVal sIsAdresi1 As String, ByVal sIsAdresi2 As String, ByVal sIsSemt As String, ByVal sIsIl As String, ByVal sIsPostaKodu As String, ByVal sIsTelefonu As String, ByVal sEvAdresi1 As String, ByVal sEvAdresi2 As String, ByVal sEvSemt As String, ByVal sEvPostaKodu As String, ByVal sEvIl As String, ByVal sEvTelefonu As String, ByVal sSigortaNo As String, ByVal bEvlimi As Int64, ByVal dteEvlilikTarihi As DateTime, ByVal dteDogumTarihi As DateTime, ByVal sDogumYeri As String, ByVal sEhliyetNo As String, ByVal sKanGrubu As String, ByVal sHitap As String, ByVal sKullaniciAdi As String, ByVal dteKayitTarihi As String, ByVal sAciklama1 As String, ByVal sAciklama2 As String, ByVal sAciklama3 As String, ByVal sAciklama4 As String, ByVal sAciklama5 As String, ByVal sGSM As String, ByVal sFax As String, ByVal sResimAdi As String) As Int64
        cmd.Connection = con
        con.ConnectionString = connection
        If con.State = ConnectionState.Closed = True Then
            con.Open()
        End If
        cmd.CommandText = sorgu_query("SET DATEFORMAT DMY SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED INSERT INTO tbMusteri (sMagaza, lKodu, sAdi, sSoyadi, nCinsiyet, lAylikGelir, dteKartAcilisTarihi, nIskontoPesin, nIskontoKredili, sUnvan, sVergiDairesi, sVergiNo, bYazismaEvAdresinemi, sEmail, sIsYeriAdi, sIsAdresi1, sIsAdresi2, sIsSemt, sIsIl, sIsPostaKodu, sIsTelefonu, sEvAdresi1, sEvAdresi2, sEvSemt, sEvPostaKodu, sEvIl, sEvTelefonu, sSigortaNo, bEvlimi, dteEvlilikTarihi, dteDogumTarihi, sDogumYeri, sEhliyetNo, sKanGrubu, sHitap, sKullaniciAdi, dteKayitTarihi, sAciklama1, sAciklama2, sAciklama3, sAciklama4, sAciklama5, sGSM, sFax, sResimAdi) VALUES     ('" & sMagaza & "', '" & lKodu & "', '" & sAdi & "', '" & sSoyadi & "', " & nCinsiyet & ", " & lAylikGelir & ", '" & dteKartAcilisTarihi & "', " & nIskontoPesin & ", " & nIskontoKredili & ", '" & sUnvan & "', '" & sVergiDairesi & "', '" & sVergiNo & "', " & bYazismaEvAdresinemi & ", '" & sEmail & "', '" & sIsYeriAdi & "', '" & sIsAdresi1 & "', '" & sIsAdresi2 & "', '" & sIsSemt & "', '" & sIsIl & "', '" & sIsPostaKodu & "', '" & sIsTelefonu & "', '" & sEvAdresi1 & "', '" & sEvAdresi2 & "', '" & sEvSemt & "', '" & sEvPostaKodu & "', '" & sEvIl & "', '" & sEvTelefonu & "', '" & sSigortaNo & "', " & bEvlimi & ", '" & dteEvlilikTarihi & "', '" & dteDogumTarihi & "', '" & sDogumYeri & "', '" & sEhliyetNo & "', '" & sKanGrubu & "', '" & sHitap & "', '" & sKullaniciAdi & "', '" & dteKayitTarihi & "', '" & sAciklama1 & "', '" & sAciklama2 & "', '" & sAciklama3 & "', '" & sAciklama4 & "', '" & sAciklama5 & "', '" & sGSM & "', '" & sFax & "', '" & sResimAdi & "')")
        cmd.ExecuteNonQuery()
        cmd.CommandText = "SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT @@identity"
        Dim kayitno = cmd.ExecuteScalar
        con.Close()
        Return kayitno
    End Function
    Private Sub tbParamMusteri_kaydet_duzelt(ByVal bMusteriNoyuSistemVersin As Byte, ByVal lMusteriNo As Int64, ByVal sResimDosyalariPath As String, ByVal sSinifTipi01 As String, ByVal sSinifTipi02 As String, ByVal sSinifTipi03 As String, ByVal sSinifTipi04 As String, ByVal sSinifTipi05 As String, ByVal sSinifTipi06 As String, ByVal sSinifTipi07 As String, ByVal sSinifTipi08 As String, ByVal sSinifTipi09 As String, ByVal sSinifTipi10 As String, ByVal sSinifTipi11 As String, ByVal sSinifTipi12 As String, ByVal sSinifTipi13 As String, ByVal sSinifTipi14 As String, ByVal sSinifTipi15 As String, ByVal bDefaultKrdLimVar As Byte, ByVal lDefaultKrediLimiti As Decimal, ByVal lDefaultKrediLimitiSonGun As Int64, ByVal bEkSoru1 As Byte, ByVal bEkSoru2 As Byte, ByVal nParametre1 As Int64, ByVal nParametre2 As Int64)
        cmd.Connection = con
        con.ConnectionString = connection
        If con.State = ConnectionState.Closed = True Then
            con.Open()
        End If
        cmd.CommandText = sorgu_query("SET DATEFORMAT DMY SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED UPDATE    tbParamMusteri SET              bMusteriNoyuSistemVersin = " & bMusteriNoyuSistemVersin & ", lMusteriNo = " & lMusteriNo & ", sResimDosyalariPath = '" & sResimDosyalariPath & "', sSinifTipi01 = '" & sSinifTipi01 & "', sSinifTipi02 = '" & sSinifTipi02 & "', sSinifTipi03 = '" & sSinifTipi03 & "', sSinifTipi04 = '" & sSinifTipi04 & "', sSinifTipi05 = '" & sSinifTipi05 & "',  sSinifTipi06 = '" & sSinifTipi06 & "', sSinifTipi07 = '" & sSinifTipi07 & "', sSinifTipi08 = '" & sSinifTipi08 & "', sSinifTipi09 = '" & sSinifTipi09 & "', sSinifTipi10 = '" & sSinifTipi10 & "',  sSinifTipi11 = '" & sSinifTipi11 & "', sSinifTipi12 = '" & sSinifTipi12 & "', sSinifTipi13 = '" & sSinifTipi13 & "', sSinifTipi14 = '" & sSinifTipi14 & "', sSinifTipi15 = '" & sSinifTipi15 & "', bDefaultKrdLimVar = " & bDefaultKrdLimVar & ", lDefaultKrediLimiti = " & lDefaultKrediLimiti & ", lDefaultKrediLimitiSonGun = " & lDefaultKrediLimitiSonGun & ", bEkSoru1 = " & bEkSoru1 & ", bEkSoru2 = " & bEkSoru2 & ", nParametre1 = " & nParametre1 & ", nParametre2 = " & nParametre2 & "")
        cmd.ExecuteNonQuery()
        con.Close()
    End Sub
    Private Sub kaydet_tumu()
        Dim dr As DataRow
        dr = ds_tbParamMusteri.Tables(0).Rows(0)
        tbParamMusteri_kaydet_duzelt(dr(0), dr(1), dr(2), dr(3), dr(4), dr(5), dr(6), dr(7), dr(8), dr(9), dr(10), dr(11), dr(12), dr(13), dr(14), dr(15), dr(16), dr(17), dr(18), dr(19), dr(20), dr(21), dr(22), dr(23), dr(24))
        Me.Close()
    End Sub
    Private Sub SimpleButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SimpleButton1.Click
        kaydet_tumu()
    End Sub
    Private Sub SimpleButton2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SimpleButton2.Click
        Me.Close()
    End Sub
End Class