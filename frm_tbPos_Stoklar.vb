Imports System.IO
Imports business_smart.brkdutil
Imports Microsoft.Win32
Imports DevExpress.XtraEditors
Public Class frm_tbPos_Stoklar
    Public firmano
    Public donemno
    Public kullanici
    Public connection
    Public kasa As String = ""
    Public sPath As String = ""
    Public sFile As String = ""
    Public sGramaj As String = "027"
    Dim dr As DataRow
    '
    Dim ds_stok As DataSet
    Private Sub frm_tbPos_Stoklar_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        If kasa = "inter" Then
            Dim dlg As New WaitDlgFrm("Dosyalar Okunuyor...")
            oku_inter(sPath, sFile)
            dlg.Close()
        ElseIf kasa = "Ibm" Then
            Dim dlg As New WaitDlgFrm("Dosyalar Okunuyor...")
            oku_IBM(sPath, sFile)
            dlg.Close()
        End If
    End Sub
    Private Sub oku_inter(ByVal sPath As String, ByVal sFile As String)
        Dim z As String = "" & sPath & ":" & sFile & "\posgenel\urun.dat"
        'dosyayý kontrol et
        Dim dosya As New FileInfo(z)
        If dosya.Exists = True Then
        Else
            dosya.Create()
        End If
        Dim sk As StreamReader = File.OpenText(z)
        Dim satir As String
        Dim sayi As Integer = 0
        Do While sk.Peek() > -1
            satir = sk.ReadLine
            sayi += 1
            dr = DataSet1.Tables(0).NewRow
            dr("sSatir") = sayiuzunlukkontrol(sayi, 6)
            dr("nStokID") = satir.Substring(1, 6)
            dr("sPlu") = satir.Substring(7, 20)
            dr("sAciklama") = satir.Substring(27, 20)
            dr("lFiyat") = satir.Substring(47, 9)
            dr("sKdvTipi") = satir.Substring(56, 2)
            dr("sBirimCinsi1") = satir.Substring(58, 4)
            dr("sStatus") = satir.Substring(62, 1)
            DataSet1.Tables(0).Rows.Add(dr)
        Loop
        sk.Close()
    End Sub
    Private Sub oku_IBM(ByVal sPath As String, ByVal sFile As String)
        Dim z As String = "" & sPath & ":" & sFile & ""
        'dosyayý kontrol et
        Dim dosya As New FileInfo(z)
        If dosya.Exists = True Then
        Else
            dosya.Create()
        End If
        Dim sk As StreamReader = File.OpenText(z)
        Dim satir As String
        Dim sayi As Integer = 0
        Dim plu As String
        Dim sKdvTipi As String = ""
        Dim sFiyat As String = 0
        Dim sBirimCinsi As String = ""
        Dim sAciklama As String = ""
        Dim s As String
        Dim barkodstn As Integer = 1
        Dim kod8 As String = ""
        Do While sk.Peek() > -1
            sayi += 1
            s = sk.ReadLine()
            If sayi >= 2 Then
                satir = Trim(s.Substring(0, 2))
                If satir = "01" Then
                    'sKdvTipi = Trim(s.Substring(515, 3))
                    sKdvTipi = "0" + Trim(s.Substring(525, 1))
                    sAciklama = Trim(s.Substring(53, 40))
                    'sFiyat = Trim(s.Substring(339, 8))
                    sFiyat = Trim(s.Substring(355, 8))
                    sFiyat = sFiyat.Replace(",", ".")
                    If sFiyat = "" Then
                        sFiyat = 0
                    End If
                ElseIf satir = "02" Then
                    plu = s.Substring(29, 14)
                    'MsgBox(Trim(plu.Substring(0, 3)))
                    If Trim(plu.Substring(0, 3)) <> sGramaj And Trim(plu.Substring(0, 3)) <> 100 And Trim(plu.Substring(0, 3)) <> 500 Then
                        plu = Trim(plu.Substring(0, 13))
                        barkodstn = 1
                        sBirimCinsi = "ADET"
                    ElseIf Trim(plu.Substring(0, 3)) = sGramaj Then
                        plu = Trim(plu.Substring(2, 5))
                        barkodstn = 8
                        sBirimCinsi = "KG"
                    ElseIf Trim(plu.Substring(0, 3)) = 500 Then
                        plu = Trim(plu.Substring(7, 6))
                        barkodstn = 5
                        sBirimCinsi = "ADET"
                        kod8 = ""
                    ElseIf Trim(plu.Substring(0, 3)) = 100 Then
                        plu = Trim(plu.Substring(5, 8))
                        barkodstn = 2
                        sBirimCinsi = "ADET"
                    ElseIf Trim(plu.Substring(0, 3)) = 4 Then
                        plu = Trim(plu.Substring(1, 12))
                        barkodstn = 3
                        sBirimCinsi = "ADET"
                    Else
                        barkodstn = 3
                        sBirimCinsi = "ADET"
                    End If
                    If Trim(plu.Length) = 1 Then
                        plu = "00000" + Trim(plu)
                    ElseIf Trim(plu.Length) = 2 Then
                        plu = "0000" + Trim(plu)
                    ElseIf Trim(plu.Length) = 3 Then
                        plu = "000" + Trim(plu)
                    ElseIf Trim(plu.Length) = 4 Then
                        plu = "00" + Trim(plu)
                    End If
                    'sFiyat = CType(sFiyat, Decimal) / 100
                    'Dim miktar = Trim(s.Substring(72, 5))
                    'Dim miktar2 = Trim(s.Substring(77, 3))
                    'Dim toplam = miktar
                    'toplam += "."
                    'toplam += miktar2
                    Dim toplam = 1
                    sAciklama = sAciklama.Replace("'", " ")
                    plu = plu.Replace("'", " ")
                    dr = DataSet1.Tables(0).NewRow
                    dr("sSatir") = sayi
                    dr("nStokID") = plu
                    dr("sPlu") = plu
                    dr("sAciklama") = sAciklama
                    dr("lFiyat") = CType(sFiyat, Decimal)
                    dr("sKdvTipi") = sKdvTipi
                    dr("sBirimCinsi1") = sBirimCinsi
                    dr("sStatus") = "H"
                    DataSet1.Tables(0).Rows.Add(dr)
                End If
            End If
        Loop
        sk.Close()
    End Sub
    Public Function sayiuzunlukkontrol(ByVal deger As String, ByVal uzunluk As String) As String
        Dim degeruzunluk As Integer = uzunluk
        Dim muzunluk = Len(deger)
        If Len(deger) < uzunluk Then
            Dim degerfark As Integer = degeruzunluk - muzunluk
            Dim i As Integer
            For i = 1 To degerfark
                deger = deger.Insert(0, "0")
            Next
        Else
            deger = Microsoft.VisualBasic.Left(deger, uzunluk)
        End If
        Return deger
    End Function
    Private Sub ekle_stok_PLU(ByVal nUzunluk As Integer)
        Dim nStokID = 0
        Dim nKayit = 0
        Dim sSinifKodu1 As String = ""
        Dim sSinifKodu2 As String = ""
        Dim sSinifKodu3 As String = ""
        Dim sSinifKodu4 As String = ""
        Dim sSinifKodu5 As String = ""
        Dim sSinifKodu6 As String = ""
        Dim sSinifKodu7 As String = ""
        Dim sSinifKodu8 As String = ""
        Dim sSinifKodu9 As String = ""
        Dim sSinifKodu10 As String = ""
        Dim sRenk As String = ""
        Dim sBeden As String = ""
        Dim sModel As String = ""
        Dim sBirimCinsi1 As String = ""
        Dim sKdvTipi As String = ""
        Dim sKisaAdi As String = ""
        Dim dr As DataRow
        bar3.Position = 0
        bar3.Properties.Maximum = DataSet1.Tables(0).Rows.Count
        bar3.Visible = True
        For Each dr In DataSet1.Tables(0).Rows
            nKayit = sorgu_nStokID(Microsoft.VisualBasic.Left(sorgu_telefon(dr("sPlu").ToString, ""), nUzunluk))
            If nKayit = 0 Then
                sModel = Microsoft.VisualBasic.Left(sorgu_telefon(dr("sPlu").ToString, ""), nUzunluk)
                sRenk = ""
                If Trim(dr("sBirimCinsi1").ToString) <> "" Then
                    sBirimCinsi1 = sorgu_sBirimCinsi1_kontrol(Microsoft.VisualBasic.Left(Trim(dr("sBirimCinsi1")), 3), Trim(dr("sBirimCinsi1")))
                    If Trim(sBirimCinsi1) = "" Then
                        sBirimCinsi1 = Microsoft.VisualBasic.Left(Trim(dr("sBirimCinsi1").ToString), 3)
                        Try
                            tbBirimCinsi_kaydet_yeni(sBirimCinsi1, dr("sBirimCinsi1").ToString, 3)
                        Catch ex As Exception
                            sBirimCinsi1 = ""
                        End Try
                    End If
                Else
                    sBirimCinsi1 = ""
                End If
                sKdvTipi = dr("sKdvTipi")

                nStokID = tbStok_kaydet_yeni(Microsoft.VisualBasic.Left(sorgu_telefon(dr("sPlu").ToString, ""), nUzunluk), Microsoft.VisualBasic.Left(sorgu_telefon(dr("sAciklama"), ""), 60), Microsoft.VisualBasic.Left(sorgu_telefon(dr("sAciklama"), ""), 16), 0, "", "", sRenk, "", "", sBirimCinsi1, "", 0, sKdvTipi, 0, 0, 0, "", 0, sModel, kullanici, Now, 1, "", 0, 0, "", 0, 0, 0)
                tbStokSinifi_kaydet_yeni(nStokID, sSinifKodu1, sSinifKodu2, sSinifKodu3, sSinifKodu4, sSinifKodu5, sSinifKodu6, sSinifKodu7, sSinifKodu8, sSinifKodu9, sSinifKodu10, "", "", "", "", "")
                dr("lFiyat") = sorgu_sayi(dr("lFiyat"), 0)
                If dr("lFiyat") > 0 Then
                    tbStokFiyati_ekle_yeni(0, sorgu_telefon(dr("sPlu").ToString, ""), "", "", sFiyat1, dr("lFiyat"), sorgu_tarih("01/01/1900", Today), kullaniciadi)
                End If
                Try
                    If Trim(dr("sPlu").ToString) <> "" Then
                        tbStokBarkodu_kaydet_yeni(nStokID, Trim(dr("sPlu").ToString), 0, 0, "", "")
                    End If
                Catch ex As Exception
                End Try
            End If
            bar3.Position += 1
            bar3.Refresh()
            lbl_info.Text = bar3.Position
            lbl_info.Refresh()
        Next
        bar3.Position = 0
        bar3.Refresh()
        XtraMessageBox.Show(Sorgu_sDil("Tamamlandý", sDil), Sorgu_sDil("Dikkat", sDil), MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub
    Public Function sorgu_sBirimCinsi1_kontrol(ByVal sBirimCinsi As String, ByVal sAciklama As String) As String
        Dim kriter
        kriter = ""
        Dim conn As New OleDb.OleDbConnection
        Dim cmd As New OleDb.OleDbCommand
        Dim adapter As New OleDb.OleDbDataAdapter
        conn.ConnectionString = connection
        cmd.Connection = conn
        conn.Open()
        cmd.CommandText = sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT     ISNULL(sBirimCinsi, '') AS sBirimCinsi FROM         tbBirimCinsi WHERE     (sBirimCinsi = '" & sBirimCinsi & "' ) AND (sAciklama = '" & sAciklama & "') ")
        Dim kayitsayisi = cmd.ExecuteScalar
        Return kayitsayisi
        cmd = Nothing
    End Function
    Private Sub tbBirimCinsi_kaydet_yeni(ByVal sBirimCinsi As String, ByVal sAciklama As String, ByVal nOndalik As Int64)
        Dim con As New OleDb.OleDbConnection
        Dim cmd As New OleDb.OleDbCommand
        cmd.Connection = con
        con.ConnectionString = connection
        If con.State = ConnectionState.Closed = True Then
            con.Open()
        End If
        cmd.CommandText = sorgu_query("SET DATEFORMAT DMY SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED INSERT INTO tbBirimCinsi (sBirimCinsi, sAciklama, nOndalik) VALUES     ('" & sBirimCinsi & "', N'" & sAciklama & "', " & nOndalik & ")")
        cmd.ExecuteNonQuery()
        con.Close()
        cmd = Nothing
        con = Nothing
    End Sub
    Public Function sorgu_nStokID(ByVal kod As String) As Int64
        Dim kriter
        kriter = "WHERE (sKodu = '" & kod & "') "
        Dim conn As New OleDb.OleDbConnection
        Dim cmd As New OleDb.OleDbCommand
        Dim adapter As New OleDb.OleDbDataAdapter
        conn.ConnectionString = connection
        cmd.Connection = conn
        conn.Open()
        cmd.CommandText = sorgu_query("SET DATEFORMAT DMY SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT     TOP 1 ISNULL(nStokID, 0) AS nStokID FROM         tbStok " & kriter & "")
        Dim kayitsayisi = cmd.ExecuteScalar
        Return kayitsayisi
        cmd = Nothing
    End Function
    Private Function tbStok_kaydet_yeni(ByVal sKodu As String, ByVal sAciklama As String, ByVal sKisaAdi As String, ByVal nStokTipi As Int64, ByVal sBedenTipi As String, ByVal sKavalaTipi As String, ByVal sRenk As String, ByVal sBeden As String, ByVal sKavala As String, ByVal sBirimCinsi1 As String, ByVal sBirimCinsi2 As String, ByVal nIskontoYuzdesi As Decimal, ByVal sKdvTipi As String, ByVal nTeminSuresi As Decimal, ByVal lAsgariMiktar As Decimal, ByVal lAzamiMiktar As Decimal, ByVal sOzelNot As String, ByVal nFiyatlandirma As Int64, ByVal sModel As String, ByVal sKullaniciAdi As String, ByVal dteKayitTarihi As DateTime, ByVal bEksiyeDusulebilirmi As Byte, ByVal sDefaultAsortiTipi As String, ByVal bEksideUyarsinmi As Byte, ByVal bOTVVar As Byte, ByVal sOTVTipi As String, ByVal nIskontoYuzdesiAV As Decimal, ByVal bEk1 As Byte, ByVal nEk2 As String) As Decimal
        Dim con As New OleDb.OleDbConnection
        Dim cmd As New OleDb.OleDbCommand
        cmd.Connection = con
        con.ConnectionString = connection
        If con.State = ConnectionState.Closed = True Then
            con.Open()
        End If
        cmd.CommandText = sorgu_query("SET DATEFORMAT DMY SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED INSERT INTO tbStok (sKodu, sAciklama, sKisaAdi, nStokTipi, sBedenTipi, sKavalaTipi, sRenk, sBeden, sKavala, sBirimCinsi1, sBirimCinsi2, nIskontoYuzdesi, sKdvTipi, nTeminSuresi, lAsgariMiktar, lAzamiMiktar, sOzelNot, nFiyatlandirma, sModel, sKullaniciAdi, dteKayitTarihi, bEksiyeDusulebilirmi, sDefaultAsortiTipi, bEksideUyarsinmi, bOTVVar, sOTVTipi, nIskontoYuzdesiAV, bEk1, nEk2) VALUES     ('" & sKodu & "', N'" & sAciklama & "', '" & sKisaAdi & "', " & nStokTipi & ", '" & sBedenTipi & "', '" & sKavalaTipi & "', '" & sRenk & "', '" & sBeden & "', '" & sKavala & "', '" & sBirimCinsi1 & "', '" & sBirimCinsi1 & "', " & nIskontoYuzdesi & ", '" & sKdvTipi & "', " & nTeminSuresi & ", " & lAsgariMiktar & ", " & lAzamiMiktar & ", '" & sOzelNot & "', " & nFiyatlandirma & ", '" & sModel & "', '" & sKullaniciAdi & "', '" & dteKayitTarihi & "', " & bEksiyeDusulebilirmi & ", '" & sDefaultAsortiTipi & "', " & bEksideUyarsinmi & ", " & bOTVVar & ", '" & sOTVTipi & "', " & nIskontoYuzdesiAV & ", " & bEk1 & ", " & nEk2 & ")")
        cmd.ExecuteNonQuery()
        cmd.CommandText = "SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT @@identity"
        Dim kayitno = cmd.ExecuteScalar
        con.Close()
        Return kayitno
        cmd = Nothing
        con = Nothing
    End Function
    Private Sub tbStokSinifi_kaydet_yeni(ByVal nStokID As String, ByVal sSinifKodu1 As String, ByVal sSinifKodu2 As String, ByVal sSinifKodu3 As String, ByVal sSinifKodu4 As String, ByVal sSinifKodu5 As String, ByVal sSinifKodu6 As String, ByVal sSinifKodu7 As String, ByVal sSinifKodu8 As String, ByVal sSinifKodu9 As String, ByVal sSinifKodu10 As String, ByVal sSinifKodu11 As String, ByVal sSinifKodu12 As String, ByVal sSinifKodu13 As String, ByVal sSinifKodu14 As String, ByVal sSinifKodu15 As String)
        Dim con As New OleDb.OleDbConnection
        Dim cmd As New OleDb.OleDbCommand
        cmd.Connection = con
        con.ConnectionString = connection
        If con.State = ConnectionState.Closed = True Then
            con.Open()
        End If
        cmd.CommandText = sorgu_query("SET DATEFORMAT DMY SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED INSERT INTO tbStokSinifi (nStokID, sSinifKodu1, sSinifKodu2, sSinifKodu3, sSinifKodu4, sSinifKodu5, sSinifKodu6, sSinifKodu7, sSinifKodu8, sSinifKodu9, sSinifKodu10, sSinifKodu11, sSinifKodu12, sSinifKodu13, sSinifKodu14, sSinifKodu15) VALUES     (" & nStokID & ", '" & sSinifKodu1 & "', '" & sSinifKodu2 & "', '" & sSinifKodu3 & "', '" & sSinifKodu4 & "', '" & sSinifKodu5 & "', '" & sSinifKodu6 & "', '" & sSinifKodu7 & "', '" & sSinifKodu8 & "', '" & sSinifKodu9 & "', '" & sSinifKodu10 & "',  '" & sSinifKodu11 & "', '" & sSinifKodu12 & "', '" & sSinifKodu13 & "', '" & sSinifKodu14 & "', '" & sSinifKodu15 & "')")
        cmd.ExecuteNonQuery()
        con.Close()
        cmd = Nothing
        con = Nothing
    End Sub
    Private Sub tbStokBarkodu_kaydet_yeni(ByVal nStokID As Int64, ByVal sBarkod As String, ByVal nKisim As Integer, ByVal nFirmaID As Integer, ByVal sKarsiStokKodu As String, ByVal sKarsiStokAciklama As String)
        Dim con As New OleDb.OleDbConnection
        Dim cmd As New OleDb.OleDbCommand
        cmd.Connection = con
        con.ConnectionString = connection
        If con.State = ConnectionState.Closed = True Then
            con.Open()
        End If
        cmd.CommandText = sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED INSERT INTO tbStokBarkodu (nStokID, sBarkod, nKisim, nFirmaID, sKarsiStokKodu, sKarsiStokAciklama) VALUES     (" & nStokID & ", '" & sBarkod & "', " & nKisim & ", " & nFirmaID & ", '" & sKarsiStokKodu & "', '" & sKarsiStokAciklama & "')")
        cmd.ExecuteNonQuery()
        con.Close()
        cmd = Nothing
        con = Nothing
    End Sub
    Private Sub tbStokFiyati_ekle_yeni(ByVal nFiyatlandirma As Int64, ByVal sModel As String, ByVal sRenk As String, ByVal sBeden As String, ByVal sFiyatTipi As String, ByVal lFiyat As Decimal, ByVal dteFiyatTespitTarihi As DateTime, ByVal sKullaniciAdi As String)
        Dim cmd As New OleDb.OleDbCommand
        Dim con As New OleDb.OleDbConnection
        con.ConnectionString = connection
        cmd.Connection = con
        If con.State = ConnectionState.Closed Then
            con.Open()
        End If
        cmd.CommandText = "set implicit_transactions on "
        cmd.ExecuteNonQuery()
        If nFiyatlandirma = 0 Then
            cmd.CommandText = "SET DATEFORMAT DMY SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED insert tbStokFiyati   select nStokID , '" & sFiyatTipi & "' , " & lFiyat & " , '" & dteFiyatTespitTarihi & "' , '" & sKullaniciAdi & "' , getdate ()  from tbStok where sModel = '" & sModel & "'"
        ElseIf nFiyatlandirma = 1 Then
            cmd.CommandText = "SET DATEFORMAT DMY SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED insert tbStokFiyati   select nStokID , '" & sFiyatTipi & "' , " & lFiyat & " , '" & dteFiyatTespitTarihi & "' , '" & sKullaniciAdi & "' , getdate ()  from tbStok where sModel = '" & sModel & "' and sRenk ='" & sRenk & "'"
        ElseIf nFiyatlandirma = 2 Then
            cmd.CommandText = "SET DATEFORMAT DMY SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED insert tbStokFiyati   select nStokID , '" & sFiyatTipi & "' , " & lFiyat & " , '" & dteFiyatTespitTarihi & "' , '" & sKullaniciAdi & "' , getdate ()  from tbStok where sModel = '" & sModel & "' and sRenk ='" & sRenk & "' and sBeden ='" & sBeden & "'"
        End If
        cmd.ExecuteNonQuery()
        cmd.CommandText = "IF @@TRANCOUNT > 0 COMMIT TRAN"
        cmd.ExecuteNonQuery()
        cmd.CommandText = "set implicit_transactions off "
        cmd.ExecuteNonQuery()
        con.Close()
        cmd = Nothing
        con = Nothing
    End Sub
    Private Function sorgu_sayi(ByVal deger As Object, ByVal sonuc As Int64) As Decimal
        If deger.ToString = "" Then
            deger = sonuc
        End If
        Return deger
    End Function
    Private Function sorgu_tarih(ByVal deger As Object, ByVal sonuc As DateTime) As DateTime
        If deger.ToString = "" Then
            deger = sonuc
        End If
        Return deger
    End Function
    Private Function sorgu_telefon(ByVal deger As Object, ByVal sonuc As String) As String
        If deger.ToString = "" Then
            deger = sonuc
        End If
        deger = deger.Replace("(", "")
        deger = deger.Replace(")", "")
        deger = deger.Replace("_", "")
        deger = deger.Replace(";", "")
        deger = deger.Replace("'", "")
        deger = deger.Replace(",", "")
        'deger = deger.Replace(".", "")
        Return deger
    End Function
    Private Function sorgu_query(ByVal query As String) As String
        query = Replace(query, "*!F", "F0" + firmano.ToString)
        query = Replace(query, "!D", "D000" + donemno.ToString)
        Return query
    End Function
    Private Function sorgu(ByVal query As String) As DataSet
        Dim conn As New OleDb.OleDbConnection
        Dim cmd As New OleDb.OleDbCommand
        Dim adapter As New OleDb.OleDbDataAdapter
        conn.ConnectionString = connection
        adapter.SelectCommand = cmd
        cmd.CommandText = query
        cmd.Connection = conn
        conn.Open()
        Dim DS As New DataSet
        Dim N As Integer = adapter.Fill(DS, "TABLE1")
        conn.Close()
        Return DS
        cmd = Nothing
        adapter = Nothing
    End Function
    Private Sub gorunum_yazdir()
        printlink1.CreateDocument(ps)
        ps.PreviewRibbonFormEx.Show()
    End Sub
    Private Sub raporla_excel()
        If XtraMessageBox.Show(Sorgu_sDil("Sonuçlarý Excel Dosyasý Oluþturmak Ýstediðinize Emin misiniz...?", sDil), Sorgu_sDil("Dikkat", sDil), MessageBoxButtons.YesNo, MessageBoxIcon.Question) = MsgBoxResult.Yes Then
            Dim SaveFileDialog1 As New Windows.Forms.SaveFileDialog
            SaveFileDialog1.Filter = "Excel Dosyalarý(*.xls) |*.xls"
            SaveFileDialog1.InitialDirectory = "c:\"
            SaveFileDialog1.FileName = "Ekstre.xls"
            If SaveFileDialog1.ShowDialog = Windows.Forms.DialogResult.OK Then
                GridView1.ExportToXls(SaveFileDialog1.FileName.ToString)
                If XtraMessageBox.Show(Sorgu_sDil("Kaydý Açmak Ýster misiniz...?", sDil), Sorgu_sDil("Dikkat", sDil), MessageBoxButtons.YesNo, MessageBoxIcon.Question) = MsgBoxResult.Yes Then
                    Process.Start(SaveFileDialog1.FileName.ToString)
                End If
            End If
            SaveFileDialog1 = Nothing
        End If
    End Sub
    Private Sub raporla_text()
        If XtraMessageBox.Show(Sorgu_sDil("Sonuçlarý Text Dosyasý Oluþturmak Ýstediðinize Emin misiniz...?", sDil), Sorgu_sDil("Dikkat", sDil), MessageBoxButtons.YesNo, MessageBoxIcon.Question) = MsgBoxResult.Yes Then
            Dim SaveFileDialog1 As New Windows.Forms.SaveFileDialog
            SaveFileDialog1.Filter = "Text Dosyalarý(*.txt) |*.txt"
            SaveFileDialog1.InitialDirectory = "c:\"
            SaveFileDialog1.FileName = "Ekstre.txt"
            If SaveFileDialog1.ShowDialog = Windows.Forms.DialogResult.OK Then
                GridView1.ExportToText(SaveFileDialog1.FileName.ToString)
                If XtraMessageBox.Show(Sorgu_sDil("Kaydý Açmak Ýster misiniz...?", sDil), Sorgu_sDil("Dikkat", sDil), MessageBoxButtons.YesNo, MessageBoxIcon.Question) = MsgBoxResult.Yes Then
                    Process.Start(SaveFileDialog1.FileName.ToString)
                End If
            End If
            SaveFileDialog1 = Nothing
        End If
    End Sub
    Private Sub raporla_pdf()
        If XtraMessageBox.Show(Sorgu_sDil("Sonuçlarý Metin Dosyasý Oluþturmak Ýstediðinize Emin misiniz...?", sDil), Sorgu_sDil("Dikkat", sDil), MessageBoxButtons.YesNo, MessageBoxIcon.Question) = MsgBoxResult.Yes Then
            Dim SaveFileDialog1 As New Windows.Forms.SaveFileDialog
            SaveFileDialog1.Filter = "Metin Dosyalarý(*.pdf) |*.pdf"
            SaveFileDialog1.InitialDirectory = "c:\"
            SaveFileDialog1.FileName = "Ekstre.pdf"
            If SaveFileDialog1.ShowDialog = Windows.Forms.DialogResult.OK Then
                GridView1.ExportToPdf(SaveFileDialog1.FileName.ToString)
                If XtraMessageBox.Show(Sorgu_sDil("Kaydý Açmak Ýster misiniz...?", sDil), Sorgu_sDil("Dikkat", sDil), MessageBoxButtons.YesNo, MessageBoxIcon.Question) = MsgBoxResult.Yes Then
                    Process.Start(SaveFileDialog1.FileName.ToString)
                End If
            End If
            SaveFileDialog1 = Nothing
        End If
    End Sub
    Private Sub GridControl1_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles GridControl1.KeyDown
        If e.KeyCode = Keys.Escape Then
            Me.Close()
        ElseIf e.KeyCode = Keys.F12 Then
            If Me.WindowState = FormWindowState.Normal Then
                Me.WindowState = FormWindowState.Maximized
            ElseIf Me.WindowState = FormWindowState.Maximized Then
                Me.WindowState = FormWindowState.Normal
            End If
        End If
    End Sub
    Private Sub SimpleButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SimpleButton1.Click
        Me.Close()
    End Sub
    Private Sub SimpleButton2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SimpleButton2.Click
        Me.Close()
    End Sub
    Private Sub GridView1_CustomDrawRowIndicator(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Grid.RowIndicatorCustomDrawEventArgs) Handles GridView1.CustomDrawRowIndicator
        If e.RowHandle >= 0 Then
            e.Info.DisplayText = e.RowHandle + 1
        Else
            e.Info.DisplayText = ""
        End If
    End Sub
    Private Sub GridView1_SelectionChanged(ByVal sender As Object, ByVal e As DevExpress.Data.SelectionChangedEventArgs) Handles GridView1.SelectionChanged
        If GridView1.SelectedRowsCount > 1 Then
            Label2.Text = Sorgu_sDil("Kayýt Sayýsý :", sDil) & GridView1.RowCount & " / " & Sorgu_sDil("Satýr :", sDil) & GridView1.FocusedRowHandle + 1 & " / " & Sorgu_sDil("Seçili :", sDil) & GridView1.SelectedRowsCount
        ElseIf GridView1.SelectedRowsCount = 1 Then
            Label2.Text = Sorgu_sDil("Kayýt Sayýsý :", sDil) & GridView1.RowCount & " / " & Sorgu_sDil("Satýr :", sDil) & GridView1.FocusedRowHandle + 1
        Else
            Label2.Text = ""
        End If
    End Sub
    Private Sub SimpleButton3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SimpleButton3.Click
        If XtraMessageBox.Show(Sorgu_sDil("Sistemdeki Stok Bilgilerini Guncellemek Istediginize Emin misiniz...?", sDil), Sorgu_sDil("Dikkat", sDil), MessageBoxButtons.YesNo, MessageBoxIcon.Question) = MsgBoxResult.Yes Then
            ekle_stok_PLU(20)
        End If
    End Sub
    Private Sub BarButtonItem1_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem1.ItemClick
        gorunum_yazdir()
    End Sub
    Private Sub BarButtonItem2_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem2.ItemClick
        raporla_excel()
    End Sub
    Private Sub BarButtonItem3_ItemClick(ByVal sender As Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem3.ItemClick
        raporla_text()
    End Sub
    Private Sub BarButtonItem4_ItemClick(ByVal sender As Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem4.ItemClick
        raporla_pdf()
    End Sub
    Private Sub SimpleButton4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SimpleButton4.Click
        If XtraMessageBox.Show(Sorgu_sDil("Satýþ Fiyatlarýnýzý Güncellemek Ýstediðinize Emin misiniz...?", sDil), Sorgu_sDil("Dikkat", sDil), MessageBoxButtons.YesNo, MessageBoxIcon.Question) = MsgBoxResult.Yes Then
            guncelle_satis()
        End If
    End Sub
    Private Sub guncelle_satis()
        Panelstatus.Visible = True
        Dim s As String
        Dim arr As Integer()
        Dim i As Integer
        Dim toplamsayi = GridView1.SelectedRowsCount
        Dim sayi = 0
        arr = GridView1.GetSelectedRows()
        bar.Properties.Maximum = toplamsayi
        barlabel.Text = "Toplam Satýr Sayýsý : " & toplamsayi
        bar.Position = 0
        Dim dr As DataRow
        Dim dr1 As DataRow
        If arr Is Nothing Then
        Else
            Array.Sort(arr)
            For Each i In arr
                s = i.ToString
                dr = GridView1.GetDataRow(s)
                dr("nStokID") = "-2147" & dr("nStokID")
                dataload_stok(dr("nStokID"))
                For Each dr1 In ds_stok.Tables(0).Rows
                    Dim fiyat As Decimal = 0
                    ''/////////////////////////////////////////////6 PEÞÝN
                    Try
                        fiyat = sorgu_stok_fiyat("" & sFiyat1 & "", dr("nStokID"))
                    Catch ex As Exception
                        fiyat = 0
                    End Try
                    If fiyat = 0 Then
                        ekle_fiyat(dr("nStokID"), "" & sFiyat1 & "", dr("lFiyat"))
                    ElseIf fiyat <> dr("lFiyat") Then
                        If dr1("nStokTipi") = 1 And dr1("nFiyatlandirma") = 0 Then
                            duzelt_fiyat_renk(dr("nStokID"), "" & sFiyat1 & "", dr("lFiyat"), dr1("sModel"))
                        ElseIf dr1("nStoktipi") = 1 And dr1("nFiyatlandirma") = 1 Then
                            duzelt_fiyat(dr("nStokID"), "" & sFiyat1 & "", dr("lFiyat"))
                        ElseIf dr1("nStokTipi") = 0 Then
                            duzelt_fiyat(dr("nStokID"), "" & sFiyat1 & "", dr("lFiyat"))
                        End If
                        'duzelt_fiyat(dr("nStokID"), "PS", dr("lFiyat"))
                    End If
                    fiyat = Nothing
                Next
                bar.Position = bar.Position + 1
                bar.Refresh()
            Next
        End If
        bar.Position = 0
        Panelstatus.Visible = False
        dr = Nothing
        XtraMessageBox.Show(Sorgu_sDil("Stok Fiyatlarý Baþarýyla Deðiþtirilmiþtir...", sDil), Sorgu_sDil("Dikkat", sDil), MessageBoxButtons.OK, MessageBoxIcon.Information)
        'dr_baslik("KOD3") = "Satýþ Fiyatlarý Deðiþtirildi..."
        'baslik_degistir()
    End Sub
    Private Sub dataload_stok(ByVal stokno As Int64)
        Dim kriter
        kriter = "WHERE (nStokID = " & stokno & ")  "
        ds_stok = sorgu(sorgu_query("SELECT     * FROM  tbStok " & kriter & ""))
    End Sub
    Private Sub ekle_fiyat(ByVal stokno As Int64, ByVal fiyattipi As String, ByVal fiyat As Decimal)
        Dim cmd As New OleDb.OleDbCommand
        Dim con As New OleDb.OleDbConnection
        cmd.Connection = con
        con.ConnectionString = connection
        If con.State = ConnectionState.Closed = True Then
            con.Open()
        End If
        'cmd.CommandText = sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED UPDATE    tbStokFiyati SET              lFiyat =" & fiyat & " where nStokID =" & stokno & " AND sFiyatTipi ='" & fiyattipi & "'")
        If fiyat = 0 Then
            cmd.CommandText = sorgu_query("DELETE FROM tbStokFiyati    Where sFiyatTipi ='" & fiyattipi & "' and nStokID = " & stokno & " ")
        Else
            cmd.CommandText = sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED INSERT INTO tbStokFiyati                       (nStokID, sFiyatTipi, lFiyat, dteFiyatTespitTarihi, sKullaniciAdi, dteKayitTarihi) VALUES     (" & stokno & ", '" & fiyattipi & "', " & fiyat & " ,'" & Today & "', " & kullanici & ", GETDATE())")
        End If
        'cmd.CommandText = sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED INSERT INTO tbStokFiyati                       (nStokID, sFiyatTipi, lFiyat, dteFiyatTespitTarihi, sKullaniciAdi, dteKayitTarihi) VALUES     (" & stokno & ", '" & fiyattipi & "', " & fiyat & " ,'" & Today & "', 'MUHASEBE', GETDATE())")
        cmd.ExecuteNonQuery()
        con.Close()
        cmd.Dispose()
        con.Dispose()
        cmd = Nothing
        con = Nothing
    End Sub
    Private Sub duzelt_fiyat(ByVal stokno As Int64, ByVal fiyattipi As String, ByVal fiyat As Decimal)
        Dim cmd As New OleDb.OleDbCommand
        Dim con As New OleDb.OleDbConnection
        cmd.Connection = con
        con.ConnectionString = connection
        If con.State = ConnectionState.Closed = True Then
            con.Open()
        End If
        cmd.CommandText = sorgu_query("SET DATEFORMAT DMY UPDATE    tbStokFiyati SET              lFiyat =" & fiyat & " , dteFiyatTespittarihi = '" & Today & "' where nStokID =" & stokno & " AND sFiyatTipi ='" & fiyattipi & "'")
        cmd.ExecuteNonQuery()
        con.Close()
        cmd.Dispose()
        con.Dispose()
        cmd = Nothing
        con = Nothing
    End Sub
    Private Sub duzelt_fiyat_renk(ByVal stokno As Int64, ByVal fiyattipi As String, ByVal fiyat As Decimal, ByVal modelno As String)
        Dim cmd As New OleDb.OleDbCommand
        Dim con As New OleDb.OleDbConnection
        cmd.Connection = con
        con.ConnectionString = connection
        If con.State = ConnectionState.Closed = True Then
            con.Open()
        End If
        cmd.CommandText = sorgu_query("SET DATEFORMAT DMY UPDATE    tbStokFiyati SET              lFiyat =" & fiyat & ", dteFiyatTespittarihi = '" & Today & "' where nStokID IN (Select nStokID from tbStok where sModel ='" & modelno & "') AND sFiyatTipi ='" & fiyattipi & "'")
        cmd.ExecuteNonQuery()
        con.Close()
        cmd.Dispose()
        con.Dispose()
        cmd = Nothing
        con = Nothing
    End Sub
    Public Function sorgu_stok_fiyat(ByVal fiyattipi As String, ByVal stokno As Int64) As Decimal
        Dim kriter
        kriter = "WHERE     (nStokID = " & stokno & ") and (sFiyatTipi= '" & fiyattipi & "') "
        Dim conn As New OleDb.OleDbConnection
        Dim cmd As New OleDb.OleDbCommand
        Dim adapter As New OleDb.OleDbDataAdapter
        conn.ConnectionString = connection
        cmd.Connection = conn
        conn.Open()
        cmd.CommandText = sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT     ISNULL(lFiyat,0) AS FIYAT FROM         tbStokFiyati " & kriter & "")
        Dim kayitsayisi = cmd.ExecuteScalar
        Return kayitsayisi
        conn.Dispose()
        cmd.Dispose()
        adapter.Dispose()
        cmd = Nothing
        adapter = Nothing
    End Function
End Class