Imports DevExpress.XtraEditors
Public Interface fihrist
    Sub kart_yeni()
    Sub kart_duzelt(ByVal ind As Int64)
    Sub kart_sil(ByVal ind As Int64)
End Interface
Public Class class_fihrist_islemleri
    Implements fihrist
    Public Shared connection
    Public Shared firmano As Int64 = 100
    Public Shared firma As String = ""
    Public Shared donemno As Int64 = 1
    Public Shared donem As String = ""
    Public Shared userno As Int64 = 100
    Public Shared username As String = ""
    Public Shared depono As Int64 = 1
    Dim cmd As New OleDb.OleDbCommand
    Dim con As New OleDb.OleDbConnection
    Public sonucstatus As Boolean
    Public fihristno As Int64
    Public Sub kart_duzelt(ByVal ind As Long) Implements fihrist.kart_duzelt
        Dim frm As New frm_fihrist_karti
        Dim cmd As New OleDb.OleDbCommand
        Dim con As New OleDb.OleDbConnection
        frm.status = 1
        frm.carino = ind
        frm.firmano = firmano
        frm.donemno = donemno
        frm.connection = connection
        sonucstatus = False
        If frm.ShowDialog() = DialogResult.OK Then
            Dim DR As DataRow = frm.DataSet1.Tables(0).Rows(0)
            Dim kodu = DR("KODU").ToString
            Dim adi = DR("ADI").ToString
            Dim soyadi = DR("SOYADI").ToString
            Dim firmaadi = DR("UZUNADI").ToString
            Dim unvan = DR("UNVANI").ToString
            Dim vergidairesi = DR("VERGIDAIRESI").ToString
            Dim vergino = DR("VERGINO").ToString
            Dim mail = DR("EMAIL").ToString
            Dim web = DR("WEB").ToString
            Dim telefon1 = DR("TELEFON1").ToString
            Dim telefon2 = DR("TELEFON2").ToString
            Dim telefon3 = DR("TELEFON3").ToString
            Dim telefon4 = DR("TELEFON4").ToString
            Dim telefon5 = DR("TELEFON5").ToString
            Dim fax1 = DR("FAX1").ToString
            Dim fax2 = DR("FAX2").ToString
            Dim postakodu = DR("POSTAKODU").ToString
            Dim cadde = DR("CADDE").ToString
            Dim sokak = DR("SOKAK").ToString
            Dim mahalle = DR("MAH").ToString
            Dim semt = DR("SEMT").ToString
            Dim daireno = DR("DAIRENO").ToString
            Dim kapino = DR("KAPINO").ToString
            Dim adres = DR("ADRES").ToString
            Dim ilgilikisi = DR("ILGILIKISI").ToString
            Dim ilgilikisigorevi = DR("ILGILIKISIGOREVI").ToString
            Dim aciklama = DR("ACIKLAMA").ToString
            Dim alan1 = DR("ALAN1").ToString
            Dim alan2 = DR("ALAN2").ToString
            Dim alan3 = DR("ALAN3").ToString
            Dim alan4 = DR("ALAN4").ToString
            Dim alan5 = DR("ALAN5").ToString
            Dim alan6 = DR("ALAN6").ToString
            Dim alan7 = sorgu_sayi(DR("ALAN7"), 0)
            Dim alan8 = sorgu_sayi(DR("ALAN8"), 0)
            Dim alan9 = sorgu_sayi(DR("ALAN9"), 0)
            Dim alan10 = sorgu_sayi(DR("ALAN10"), 0)
            Dim alan11
            Dim alan12
            Dim alan13
            Dim alan14
            Try
                alan11 = DR("ALAN11").ToString
            Catch ex As Exception
                alan11 = "Null"
            End Try
            Try
                alan12 = DR("ALAN12").ToString
            Catch ex As Exception
                alan12 = "Null"
            End Try
            Try
                alan13 = DR("ALAN13").ToString
            Catch ex As Exception
                alan13 = "Null"
            End Try
            Try
                alan14 = DR("ALAN14").ToString
            Catch ex As Exception
                alan14 = "Null"
            End Try
            Dim baslikalan1 = DR("BASLIKALAN1").ToString
            Dim baslikalan2 = DR("BASLIKALAN2").ToString
            Dim baslikalan3 = DR("BASLIKALAN3").ToString
            Dim baslikalan4 = DR("BASLIKALAN4").ToString
            Dim baslikalan5 = DR("BASLIKALAN5").ToString
            Dim baslikalan6 = DR("BASLIKALAN6").ToString
            Dim baslikalan7 = DR("BASLIKALAN7").ToString
            Dim baslikalan8 = DR("BASLIKALAN8").ToString
            Dim baslikalan9 = DR("BASLIKALAN9").ToString
            Dim baslikalan10 = DR("BASLIKALAN10").ToString
            Dim baslikalan11 = DR("BASLIKALAN11").ToString
            Dim baslikalan12 = DR("BASLIKALAN12").ToString
            Dim baslikalan13 = DR("BASLIKALAN13").ToString
            Dim baslikalan14 = DR("BASLIKALAN14").ToString
            Dim il = DR("IL").ToString
            Dim ilce = DR("ILCE").ToString
            con.ConnectionString = connection
            cmd.CommandTimeout = Nothing
            cmd.Connection = con
            con.Open()
            cmd.CommandText = sorgu_query("SET DATEFORMAT DMY UPDATE TBLAJNFIHRIST SET KODU = N'" & kodu & "' , ADI = N'" & adi & "', SOYADI = N'" & soyadi & "' , UNVANI = N'" & unvan & "' , UZUNADI = N'" & firmaadi & "' , VERGIDAIRESI = N'" & vergidairesi & "' , VERGINO = N'" & vergino & "' , TELEFON1 = N'" & telefon1 & "' , TELEFON2 = N'" & telefon2 & "' , TELEFON3 = N'" & telefon3 & "' , TELEFON4 = N'" & telefon4 & "' , TELEFON5 = N'" & telefon5 & "' , FAX1 = N'" & fax1 & "', FAX2 = N'" & fax2 & "' , POSTAKODU = N'" & postakodu & "' , CADDE = N'" & cadde & "' , SOKAK = N'" & sokak & "' , MAH = N'" & mahalle & "' , SEMT = N'" & semt & "' , DAIRENO = N'" & daireno & "' , KAPINO = N'" & kapino & "' , ADRES = N'" & adres & "' , EMAIL = N'" & mail & "' , ILGILIKISI = N'" & ilgilikisi & "' , ILGILIKISIGOREVI = N'" & ilgilikisigorevi & "' , ACIKLAMA = N'" & aciklama & "' , ALAN1 = N'" & alan1 & "' , ALAN2 = N'" & alan2 & "' , ALAN3 = N'" & alan3 & "' , ALAN4 = N'" & alan4 & "' , ALAN5 = N'" & alan5 & "', ALAN6 = N'" & alan6 & "' , ALAN7 = '" & alan7 & "' , ALAN8 = '" & alan8 & "' , ALAN9 = '" & alan9 & "' , ALAN10 = '" & alan10 & "' , ALAN11 = '" & alan11 & "' , ALAN12 = '" & alan12 & "' , ALAN13 = '" & alan13 & "' , ALAN14 = '" & alan14 & "' , BASLIKALAN1 = N'" & baslikalan1 & "' , BASLIKALAN2 = N'" & baslikalan2 & "' , BASLIKALAN3 = N'" & baslikalan3 & "' , BASLIKALAN4 = N'" & baslikalan4 & "' , BASLIKALAN5 = N'" & baslikalan5 & "' , BASLIKALAN6 = N'" & baslikalan6 & "' , BASLIKALAN7 = N'" & baslikalan7 & "' , BASLIKALAN8 = N'" & baslikalan8 & "' , BASLIKALAN9 = N'" & baslikalan9 & "' , BASLIKALAN10 = N'" & baslikalan10 & "' , BASLIKALAN11 = N'" & baslikalan11 & "' , BASLIKALAN12 = N'" & baslikalan12 & "' , BASLIKALAN13 = N'" & baslikalan13 & "' , BASLIKALAN14 = N'" & baslikalan14 & "' , IL = N'" & il & "' , ILCE = N'" & ilce & "' , WEB = N'" & web & "' WHERE IND =" & ind & "")
            Dim sonuc = cmd.ExecuteNonQuery
            sonuc = 1
            sonucstatus = True
            con.Close()
            DR = Nothing
        End If
    End Sub
    Public Sub kart_sil(ByVal ind As Long) Implements fihrist.kart_sil
        sonucstatus = False
        If XtraMessageBox.Show(ind & Sorgu_sDil("  :Nolu Kaydý Silmek Ýstediðinize Eminmisiniz", sDil), Sorgu_sDil("Dikkat", sDil), MessageBoxButtons.YesNo, MessageBoxIcon.Question) = MsgBoxResult.Yes Then
            con.ConnectionString = connection
            cmd.CommandTimeout = Nothing
            cmd.Connection = con
            con.Open()
            cmd.CommandText = sorgu_query("DELETE FROM TBLAJNFIHRIST WHERE IND= " & ind & "")
            Dim sonuc = cmd.ExecuteNonQuery
            XtraMessageBox.Show(ind & Sorgu_sDil(" :Nolu Kayýt Baþarý ile Silindi", sDil), Sorgu_sDil("Dikkat", sDil), MessageBoxButtons.OK, MessageBoxIcon.Information)
            sonucstatus = True
            con.Close()
        End If
    End Sub
    Public Sub kart_yeni() Implements fihrist.kart_yeni
        Dim frm As New frm_fihrist_karti
        Dim cmd As New OleDb.OleDbCommand
        Dim con As New OleDb.OleDbConnection
        frm.status = 0
        frm.firmano = firmano
        frm.donemno = donemno
        frm.connection = connection
        sonucstatus = False
        If frm.ShowDialog() = DialogResult.OK Then
            Dim DR As DataRow = frm.DataSet1.Tables(0).Rows(0)
            Dim kodu = DR("KODU").ToString
            Dim adi = DR("ADI").ToString
            Dim soyadi = DR("SOYADI").ToString
            Dim firmaadi = DR("UZUNADI").ToString
            Dim unvan = DR("UNVANI").ToString
            Dim vergidairesi = DR("VERGIDAIRESI").ToString
            Dim vergino = DR("VERGINO").ToString
            Dim mail = DR("EMAIL").ToString
            Dim web = DR("WEB").ToString
            Dim telefon1 = DR("TELEFON1").ToString
            Dim telefon2 = DR("TELEFON2").ToString
            Dim telefon3 = DR("TELEFON3").ToString
            Dim telefon4 = DR("TELEFON4").ToString
            Dim telefon5 = DR("TELEFON5").ToString
            Dim fax1 = DR("FAX1").ToString
            Dim fax2 = DR("FAX2").ToString
            Dim postakodu = DR("POSTAKODU").ToString
            Dim cadde = DR("CADDE").ToString
            Dim sokak = DR("SOKAK").ToString
            Dim mahalle = DR("MAH").ToString
            Dim semt = DR("SEMT").ToString
            Dim daireno = DR("DAIRENO").ToString
            Dim kapino = DR("KAPINO").ToString
            Dim adres = DR("ADRES").ToString
            Dim ilgilikisi = DR("ILGILIKISI").ToString
            Dim ilgilikisigorevi = DR("ILGILIKISIGOREVI").ToString
            Dim aciklama = DR("ACIKLAMA").ToString
            Dim alan1 = DR("ALAN1").ToString
            Dim alan2 = DR("ALAN2").ToString
            Dim alan3 = DR("ALAN3").ToString
            Dim alan4 = DR("ALAN4").ToString
            Dim alan5 = DR("ALAN5").ToString
            Dim alan6 = DR("ALAN6").ToString
            Dim alan7 = sorgu_sayi(DR("ALAN7"), 0)
            Dim alan8 = sorgu_sayi(DR("ALAN8"), 0)
            Dim alan9 = sorgu_sayi(DR("ALAN9"), 0)
            Dim alan10 = sorgu_sayi(DR("ALAN10"), 0)
            Dim alan11
            Dim alan12
            Dim alan13
            Dim alan14
            Try
                alan11 = DR("ALAN11").ToString
            Catch ex As Exception
                alan11 = "Null"
            End Try
            Try
                alan12 = DR("ALAN12").ToString
            Catch ex As Exception
                alan12 = "Null"
            End Try
            Try
                alan13 = DR("ALAN13").ToString
            Catch ex As Exception
                alan13 = "Null"
            End Try
            Try
                alan14 = DR("ALAN14").ToString
            Catch ex As Exception
                alan14 = "Null"
            End Try
            Dim baslikalan1 = DR("BASLIKALAN1").ToString
            Dim baslikalan2 = DR("BASLIKALAN2").ToString
            Dim baslikalan3 = DR("BASLIKALAN3").ToString
            Dim baslikalan4 = DR("BASLIKALAN4").ToString
            Dim baslikalan5 = DR("BASLIKALAN5").ToString
            Dim baslikalan6 = DR("BASLIKALAN6").ToString
            Dim baslikalan7 = DR("BASLIKALAN7").ToString
            Dim baslikalan8 = DR("BASLIKALAN8").ToString
            Dim baslikalan9 = DR("BASLIKALAN9").ToString
            Dim baslikalan10 = DR("BASLIKALAN10").ToString
            Dim baslikalan11 = DR("BASLIKALAN11").ToString
            Dim baslikalan12 = DR("BASLIKALAN12").ToString
            Dim baslikalan13 = DR("BASLIKALAN13").ToString
            Dim baslikalan14 = DR("BASLIKALAN14").ToString
            Dim il = DR("IL").ToString
            Dim ilce = DR("ILCE").ToString
            con.ConnectionString = connection
            cmd.CommandTimeout = Nothing
            cmd.Connection = con
            con.Open()
            cmd.CommandText = sorgu_query("SET DATEFORMAT DMY INSERT INTO TBLAJNFIHRIST(KODU, ADI, SOYADI, UNVANI, UZUNADI, VERGIDAIRESI, VERGINO, TELEFON1, TELEFON2, TELEFON3, TELEFON4, TELEFON5, FAX1, FAX2, POSTAKODU, CADDE, SOKAK, MAH, SEMT, DAIRENO, KAPINO, ADRES, EMAIL, ILGILIKISI, ILGILIKISIGOREVI, ACIKLAMA, ALAN1, ALAN2, ALAN3, ALAN4, ALAN5, ALAN6, ALAN7, ALAN8, ALAN9, ALAN10, ALAN11, ALAN12, ALAN13, ALAN14, BASLIKALAN1, BASLIKALAN2, BASLIKALAN3, BASLIKALAN4, BASLIKALAN5, BASLIKALAN6, BASLIKALAN7, BASLIKALAN8, BASLIKALAN9, BASLIKALAN10, BASLIKALAN11, BASLIKALAN12, BASLIKALAN13, BASLIKALAN14, IL, ILCE, WEB) VALUES (N'" & kodu & "', N'" & adi & "', N'" & soyadi & "', N'" & unvan & "', N'" & firmaadi & "', N'" & vergidairesi & "', N'" & vergino & "', N'" & telefon1 & "', N'" & telefon2 & "', N'" & telefon3 & "', N'" & telefon4 & "', N'" & telefon5 & "', N'" & fax1 & "', N'" & fax2 & "', N'" & postakodu & "', N'" & cadde & "', N'" & sokak & "', N'" & mahalle & "', N'" & semt & "', N'" & daireno & "',  N'" & kapino & "', N'" & adres & "' , N'" & mail & "', N'" & ilgilikisi & "' , N'" & ilgilikisigorevi & "' , N'" & aciklama & "', N'" & alan1 & "' , N'" & alan2 & "', N'" & alan3 & "', N'" & alan4 & "' , N'" & alan5 & "' , N'" & alan6 & "' , '" & alan7 & "' , '" & alan8 & "' , '" & alan9 & "' , '" & alan10 & "' , '" & alan11 & "' , '" & alan12 & "' , '" & alan13 & "' , '" & alan14 & "' , N'" & baslikalan1 & "',  N'" & baslikalan2 & "' , N'" & baslikalan3 & "' , N'" & baslikalan4 & "' , N'" & baslikalan5 & "', N'" & baslikalan6 & "' , N'" & baslikalan7 & "', N'" & baslikalan8 & "' , N'" & baslikalan9 & "' , N'" & baslikalan10 & "' , N'" & baslikalan11 & "' , N'" & baslikalan12 & "' , N'" & baslikalan13 & "' , N'" & baslikalan14 & "' , N'" & il & "' , N'" & ilce & "' , N'" & web & "')")
            Dim sonuc = cmd.ExecuteNonQuery
            cmd.CommandText = "SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT @@identity"
            fihristno = cmd.ExecuteScalar
            sonuc = 1
            sonucstatus = True
            con.Close()
            DR = Nothing
        End If
    End Sub
    Private Function sorgu_query(ByVal query As String) As String
        query = Replace(query, "*!F", "F0" + firmano.ToString)
        query = Replace(query, "!D", "D000" + donemno.ToString)
        Return query
    End Function
    Private Function sorgu_sayi(ByVal deger As Object, ByVal sonuc As Int64) As Int64
        If deger.ToString = "" Then
            deger = sonuc
        End If
        Return deger
    End Function
End Class
