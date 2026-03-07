Imports Microsoft.Win32
Imports DevExpress.XtraEditors
Imports System.Threading
Imports System.Globalization
Public Class frm_gir
    Public firmano
    Public donemno
    'Public SQLconnection
    Public sConnection As String = ""
    Public kasiyerad
    Public database As String = ""
    Public sSunucu As String = ""
    Dim ds_kasiyer As DataSet
    Dim ds_dataset As DataSet
    Dim dr As DataRow
    Dim conn As New OleDb.OleDbConnection
    Dim con As New OleDb.OleDbConnection
    Dim cmd As New OleDb.OleDbCommand
    Dim adapter As New OleDb.OleDbDataAdapter
    Public status As Boolean = False
    Public kullanici As String = ""
    Public kasiyer As String = ""
    Public islemstatus As Boolean = False
    Public oConnection
    Dim ds_database As DataSet
    Private Sub frm_gir_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Timer1.Start()
        Try
            sBilgisayar = Systemdaten(3)
        Catch ex As Exception
            sBilgisayar = ""
        End Try
        Try
            sOturum = Systemdaten(4)
        Catch ex As Exception
            sOturum = ""
        End Try
        Dim videoRentCI As CultureInfo = CType(Application.CurrentCulture.Clone(), CultureInfo)
        videoRentCI.NumberFormat.CurrencyDecimalSeparator = "."
        videoRentCI.NumberFormat.CurrencyGroupSeparator = ","
        videoRentCI.NumberFormat.NumberDecimalSeparator = "."
        videoRentCI.NumberFormat.NumberGroupSeparator = ","
        videoRentCI.DateTimeFormat.DateSeparator = "/"
        videoRentCI.DateTimeFormat.ShortDatePattern = "dd/MM/yyyy"
        Application.CurrentCulture = videoRentCI
        Try
            'Registry.CurrentUser.CreateSubKey("Control Panel").CreateSubKey("International").SetValue("sDecimal", ".")
            'Registry.CurrentUser.CreateSubKey("Control Panel").CreateSubKey("International").SetValue("sThousand", ",")
            'Registry.CurrentUser.CreateSubKey("Control Panel").CreateSubKey("International").SetValue("sMonDecimalSep", ".")
            'Registry.CurrentUser.CreateSubKey("Control Panel").CreateSubKey("International").SetValue("sMonThousandSep", ",")
            'Registry.CurrentUser.CreateSubKey("Control Panel").CreateSubKey("International").SetValue("sDate", "/")
            'Registry.CurrentUser.CreateSubKey("Control Panel").CreateSubKey("International").SetValue("sShortDate", "dd/MM/yyyy")
            If My.Application.Info.Title <> "" Then
                ApplicationTitle.Text = My.Application.Info.Title
                'Me.Text = "Easy,Fast and Quickly user"
                Me.Text = "KolayHızlıveSeriKullanım"
            Else
                'If the application title is missing, use the application name, without the extension
                ApplicationTitle.Text = System.IO.Path.GetFileNameWithoutExtension(My.Application.Info.AssemblyName)
            End If
            SimpleLabelItem1.Text = System.String.Format(SimpleLabelItem1.Text, My.Application.Info.Version.Major, My.Application.Info.Version.Minor, My.Application.Info.Version.Revision) & "X"
            'TileItem1.
            'TileItemElement4.Text = System.String.Format(TileItemElement4.Text, My.Application.Info.Version.Major, My.Application.Info.Version.Minor)
            LayoutControlItem1.Text = My.Application.Info.Copyright
            connection_kontrol()
            Try
                Registry.CurrentUser.CreateSubKey("Software").CreateSubKey("BusinessSmart").CreateSubKey("GlobalParams").SetValue("X", "True")
            Catch ex As Exception
            End Try
            'connection = Registry.LocalMachine.OpenSubKey("Software").OpenSubKey("Fast Reports").OpenSubKey("connections").GetValue("UGURLU")
            kasiyerad = Registry.CurrentUser.OpenSubKey("Software").OpenSubKey("BusinessSmart").OpenSubKey("GlobalParams").GetValue("PERSONEL")
            'If connection = "" Then
            '    connection = "Provider=SQLOLEDB.1;Persist Security Info=False;User ID=sa;Initial Catalog=BUSINESS;Data Source=(local)"
            '    Registry.LocalMachine.CreateSubKey("Software").CreateSubKey("Fast Reports").CreateSubKey("connections").SetValue("UGURLU", connection)
            'End If
            If kasiyerad = "" Then
                Registry.CurrentUser.CreateSubKey("Software").CreateSubKey("BusinessSmart").CreateSubKey("GlobalParams").SetValue("PERSONEL", "")
            End If
            firmano = 100
            donemno = 1
            'dataload_kasiyer()
            dataload_database()
            'If islemstatus = False Then
            '    lbl_veritabani.Visible = False
            '    sec_database.Visible = False
            'End If
            sec_personel.Text = kasiyerad
            txt_kod.Focus()
            txt_kod.Select()
        Catch ex As Exception
            XtraMessageBox.Show(e.ToString)
        End Try
    End Sub
    Private Sub dataload_kasiyer(Optional ByVal database As String = "")
        Try
            If database = "" Then
                'ds_kasiyer = sorgu(sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT     IND, PERSONELADI AS ACIKLAMA, SIFRE,sCariSinirla,sStokSinirla,sBankaSinirla,sFihristSinirla,sDepo,sSubeMagaza,sCariSinifKoduSinirla,sAltFiyatTipi FROM         APERSONEL WHERE KULLANICI=1 ORDER BY PERSONELADI"))
                ds_kasiyer = sorgu(sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT     *, PERSONELADI AS ACIKLAMA FROM         APERSONEL WHERE KULLANICI=1 ORDER BY PERSONELADI"))
            Else
                ds_kasiyer = sorgu(sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED USE " & database & " SELECT     *,PERSONELADI AS ACIKLAMA FROM         APERSONEL WHERE KULLANICI=1 ORDER BY PERSONELADI"))
            End If
            sec_personel.Properties.DataSource = ds_kasiyer.Tables(0)
            sec_personel.ItemIndex = 0
        Catch ex As Exception
            XtraMessageBox.Show(Sorgu_sDil("Seçili Veritabanı Business Veritabanı Değil...!", sDil), Sorgu_sDil("Dikkat", sDil), MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End Try
    End Sub
    Private Sub dataload_database()
        ds_database = sorgu(sorgu_query("use master select name from sysdatabases where name NOT IN ('master','model','msdb','tempdb')  order by Name"))
        sec_database.Properties.DataSource = ds_database.Tables(0)
        sec_database.EditValue = database
    End Sub
    Private Function sorgu(ByVal query As String) As DataSet
        Dim conn As New OleDb.OleDbConnection
        Dim adapter As New OleDb.OleDbDataAdapter
        Dim cmd As New OleDb.OleDbCommand
        conn.ConnectionString = sConnection
        adapter.SelectCommand = cmd
        cmd.CommandText = query
        cmd.Connection = conn
        conn.Open()
        Dim DS As New DataSet
        Try
            Dim N As Integer = adapter.Fill(DS, "TABLE1")
        Catch ex As Exception
            XtraMessageBox.Show(ex.Message)
        End Try
        conn.Close()
        Return DS
    End Function
    Private Function sorgu_query(ByVal query As String) As String
        query = Replace(query, "*!F", "F0" + firmano.ToString)
        query = Replace(query, "!D", "D000" + donemno.ToString)
        Return query
    End Function
    Private Sub kasiyer_kontrol()
        'tbStokMobileXml()
        Dim sonuc As Boolean = False
        For Each dr In ds_kasiyer.Tables(0).Rows
            If dr("IND") = sec_personel.EditValue Then
                If dr("SIFRE") = txt_kod.Text Then
                    kullaniciKodu = dr("PERSONELKODU")
                    kullanici = dr("IND")
                    kasiyer = dr("ACIKLAMA")
                    kullaniciadi = dr("ACIKLAMA")
                    sCariSinirla = Trim(dr("sCariSinirla").ToString)
                    sStokSinirla = Trim(dr("sStokSinirla").ToString)
                    sBankaSinirla = Trim(dr("sBankaSinirla").ToString)
                    sFihristSinirla = Trim(dr("sFihristSinirla").ToString)
                    sGiderSinirla = Trim(dr("sGiderSinirla").ToString)
                    sCariSinifKoduSinirla = Trim(dr("sCariSinifKoduSinirla").ToString)
                    sDepo = dr("sDepo").ToString
                    Registry.CurrentUser.CreateSubKey("Software").CreateSubKey("BusinessSmart").CreateSubKey("MAGAZA").SetValue("DEPOKODU", sDepo)
                    Registry.CurrentUser.CreateSubKey("Software").CreateSubKey("BusinessSmart").CreateSubKey("MAGAZA").SetValue("sSubeMagaza", sSubeMagaza)
                    sSubeMagaza = dr("sSubeMagaza")
                    sHareketTipi = dr("sHareketTipi")
                    sAltFiyatTipi = Trim(dr("sAltFiyatTipi"))
                    sFiyat1 = Trim(dr("sFiyat1"))
                    sFiyat2 = Trim(dr("sFiyat2"))
                    sFiyat3 = Trim(dr("sFiyat3"))
                    sFiyat4 = Trim(dr("sFiyat4"))
                    sFiyat5 = Trim(dr("sFiyat5"))
                    sFiyatA = Trim(dr("sFiyatA"))
                    sFiyatM = Trim(dr("sFiyatM"))
                    EsFiyat1 = Trim(dr("EsFiyat1"))
                    EsFiyat2 = Trim(dr("EsFiyat2"))
                    EsFiyat3 = Trim(dr("EsFiyat3"))
                    EsFiyat4 = Trim(dr("EsFiyat4"))
                    EsFiyat5 = Trim(dr("EsFiyat5"))
                    EsFiyatA = Trim(dr("EsFiyatA"))
                    EsFiyatM = Trim(dr("EsFiyatM"))
                    sAktifFiyatTipi = Trim(dr("sAktifFiyatTipi"))
                    bCalcVadeDagilim = dr("bCalcVadeDagilim")
                    bOtomatikTaksit = dr("bOtomatikTaksit")
                    bOtomatikPesinatDuzelt = dr("bOtomatikPesinatDuzelt")
                    bKdvKontrolluMaliyet = dr("bKdvKontrolluMaliyet")
                    bSatirKontrol = dr("bSatirKontrol")
                    bOtomatikMaliyetFiyati = dr("bOtomatikMaliyetFiyati")
                    'bAlisFatOtoMuh = dr("bAlisFatOtoMuh")
                    'bSatFatOtoMuh = dr("bSatFatOtoMuh")
                    bPerOtoMuh = dr("bPerOtoMuh")
                    bPerYerelMuh = dr("bPerYerelMuh")
                    bSatirKendiEnvanteri = dr("bSatirKendiEnvanteri")
                    bOtomatikAlisFiyati = dr("bOtomatikAlisFiyati")
                    bAlisFiyatiUyar = dr("bAlisFiyatiUyar")
                    dteSonFaturaTarihi = dr("dteSonFaturaTarihi")
                    dteSonIrsaliyeTarihi = dr("dteSonIrsaliyeTarihi")
                    dteSonStokFisiTarihi = dr("dteSonStokFisiTarihi")
                    dteSonNakitKasaTarihi = dr("dteSonNakitKasaTarihi")
                    nFirmaGrupKodUzunlugu = dr("nFirmaGrupKodUzunlugu")
                    nTaksitGun = dr("nTaksitGun")
                    nTaksitBaslangic = dr("nTaksitBaslangic")
                    nTaksitSayi = dr("nTaksitSayi")
                    sKrediliFiyatTipi = dr("sKrediliFiyatTipi")
                    sPesinFiyatTipi = dr("sPesinFiyatTipi")
                    bMessageCheck = dr("bMessageCheck")
                    bNamazVaktiGosterme = dr("bNamazVaktiGosterme")
                    bMagazalarChart = dr("bMagazalarChart")
                    sSaticiRumuzu = Trim(dr("sSaticiRumuzu"))
                    PrinterTermal = dr("PrinterTermal")
                    PrinterDepo = dr("PrinterDepo")
                    nFontSize = dr("FontSize")
                    bFiyatKdvHaric = dr("bFiyatKdvHaric")
                    bFaturaKdvDahil = dr("bFaturaKdvDahil")
                    bFaturaKdvSiz = dr("bFaturaKdvSiz")
                    bFaturaIskontosuz = dr("bFaturaIskontosuz")
                    nFaturaCiktiSatirSayisi = dr("nFaturaCiktiSatirSayisi")
                    bIrsaliyeKdvSiz = dr("bIrsaliyeKdvSiz")
                    bIrsaliyeIskontosuz = dr("bIrsaliyeIskontosuz")
                    nIrsaliyeCiktiSatirSayisi = dr("nIrsaliyeCiktiSatirSayisi")
                    bStokFisiKdvSiz = dr("bStokFisiKdvSiz")
                    bStokFisiIskontosuz = dr("bStokFisiIskontosuz")
                    nStokFisiCiktiSatirSayisi = dr("nStokFisiCiktiSatirSayisi")
                    bTransferEnvanterKontrol = dr("bTransferEnvanterKontrol")
                    sRaporUzanti = dr("sRaporUzanti")
                    sYaziIleGenelToplam = dr("sYaziIle")
                    sBarcodeStd = dr("sBacodeStd")
                    Try
                        sBarcodeStd_KG = Registry.LocalMachine.OpenSubKey("Software").OpenSubKey("BusinessSmart").OpenSubKey("FATURA").GetValue("BARCODESTD_KG")
                    Catch ex As Exception
                        sBarcodeStd_KG = "2"
                        Registry.LocalMachine.CreateSubKey("Software").CreateSubKey("BusinessSmart").CreateSubKey("FATURA").SetValue("BARCODESTD_KG", sBarcodeStd_KG)
                    End Try
                    Try
                        sBarcodeStd_GR = Registry.LocalMachine.OpenSubKey("Software").OpenSubKey("BusinessSmart").OpenSubKey("FATURA").GetValue("BARCODESTD_GR")
                    Catch ex As Exception
                        sBarcodeStd_KG = "3"
                        Registry.LocalMachine.CreateSubKey("Software").CreateSubKey("BusinessSmart").CreateSubKey("FATURA").SetValue("BARCODESTD_GR", sBarcodeStd_GR)
                    End Try
                    If sBarcodeStd_KG = 0 Then
                        sBarcodeStd_KG = 2
                    End If
                    If sBarcodeStd_GR = 0 Then
                        sBarcodeStd_GR = 3
                    End If
                    Try
                        bDovizliFatura = dr("bDovizliFatura")
                    Catch ex As Exception
                        connection = sConnection
                        sorgula_nStokID("ALTER TABLE APERSONEL ADD 	[bDovizliFatura] [bit] NOT NULL DEFAULT '0'")
                        bDovizliFatura = False
                    End Try
                    sDil = Trim(dr("sDil"))
                    If sDil = "Turkish" Then
                        sDil = "TR"
                    ElseIf sDil = "English" Then
                        sDil = "EN"
                    ElseIf sDil = "Arabic" Then
                        sDil = "AR"
                    ElseIf sDil = "" Then
                        sDil = "TR"
                    End If
                    bKendiFisNo = dr("bKendiFisNo")
                    Try
                        kullanici_kontrol(kullaniciadi, dr("SIFRE"), Trim(sec_database.Text))
                        sConnection = "Provider=SQLOLEDB.1;Password=" & dr("SIFRE") & ";Persist Security Info=True;User ID=" & kullaniciadi & ";Initial Catalog=" & database & ";Data Source=" & sSunucu & ";Current Language=Türkçe;Application Name=BusinessERP"
                        connection = sConnection
                    Catch ex As Exception
                    End Try
                    'Try
                    '    System.Threading.Thread.CurrentThread.CurrentCulture = New System.Globalization.CultureInfo(LCase(sDil).ToString & "-" & UCase(sDil).ToString)
                    '    System.Threading.Thread.CurrentThread.CurrentUICulture = New System.Globalization.CultureInfo(LCase(sDil).ToString & "-" & UCase(sDil).ToString)
                    'Catch ex As Exception
                    'End Try
                    'Try
                    '    System.Threading.Thread.CurrentThread.CurrentCulture = New System.Globalization.CultureInfo(LCase(sDil).ToString)
                    '    System.Threading.Thread.CurrentThread.CurrentUICulture = New System.Globalization.CultureInfo(LCase(sDil).ToString)
                    'Catch ex As Exception
                    'End Try
                    sonuc = True
                    Registry.CurrentUser.CreateSubKey("Software").CreateSubKey("BusinessSmart").CreateSubKey("GlobalParams").SetValue("PERSONEL", kasiyer)
                End If
            End If
        Next
        If sonuc = True Then
            txt_kod.Enabled = False
            status = True
            If islemstatus = False Then
                Me.WindowState = FormWindowState.Minimized
                Dim frm As New Form1
                frm.kasiyer = kasiyer
                frm.kullanici = kullanici
                'frm.SQLconnection = SQLconnection
                connection = sConnection
                sDatabaseGenel = database
                connection_kontrol()
                tema_yukle()
                frm.Show()
                Timer1.Stop()
                Me.Hide()
            Else
                Me.DialogResult = Windows.Forms.DialogResult.OK
            End If
        ElseIf sonuc = False Then
            'txt_kasiyer.EditValue = ""
            txt_kod.Enabled = True
            txt_kod.EditValue = ""
            txt_kod.Focus()
            txt_kod.SelectAll()
            status = False
            XtraMessageBox.Show("Şifre Hatalı Lütfen Tekrar Deneyiniz...!", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub
    Private Sub tema_yukle()
        Try
            Dim skinname As String = DevExpress.LookAndFeel.UserLookAndFeel.Default.ActiveSkinName
            Dim skinstyle As String = DevExpress.LookAndFeel.UserLookAndFeel.Default.ActiveStyle
            skinname = Registry.CurrentUser.OpenSubKey("Software").OpenSubKey("BusinessSmart").OpenSubKey("STYLE").GetValue("SKIN").ToString
            skinstyle = Registry.CurrentUser.OpenSubKey("Software").OpenSubKey("BusinessSmart").OpenSubKey("STYLE").GetValue("STYLE").ToString
            If Trim(skinstyle) = "Flat" Then
                DefaultLookAndFeel1.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.Flat
                'DefaultLookAndFeel1.LookAndFeel.SkinName = skinname
            ElseIf Trim(skinstyle) = "UltraFlat" Then
                DefaultLookAndFeel1.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.UltraFlat
                'DefaultLookAndFeel1.LookAndFeel.SkinName = skinname
            ElseIf Trim(skinstyle) = "Style3D" Then
                DefaultLookAndFeel1.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.Style3D
                'DefaultLookAndFeel1.LookAndFeel.SkinName = skinname
            ElseIf Trim(skinstyle) = "Skin" Then
                DevExpress.LookAndFeel.UserLookAndFeel.Default.SetSkinStyle(skinname)
                DefaultLookAndFeel1.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.Skin
                'DevExpress.LookAndFeel.UserLookAndFeel.Default.SetSkinStyle(skinname)
            ElseIf Trim(skinstyle) = "Office2003" Then
                DefaultLookAndFeel1.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.Office2003
                'DefaultLookAndFeel1.LookAndFeel.SkinName = skinname
            Else
                DefaultLookAndFeel1.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.Skin
                DevExpress.LookAndFeel.UserLookAndFeel.Default.SetSkinStyle(skinname)
            End If
        Catch ex As Exception
        End Try
    End Sub
    Private Sub connection_kontrol()
        'Try
        '    connection = Registry.LocalMachine.OpenSubKey("Software").OpenSubKey("Fast Reports").OpenSubKey("connections").GetValue("barkod")
        'Catch ex As Exception
        Registry.LocalMachine.CreateSubKey("Software").CreateSubKey("Fast Reports").CreateSubKey("connections").SetValue("UGURLU", GetConnection())
        'End Try
        'If connection = "" Then
        '    connection = "Provider=SQLOLEDB.1;Persist Security Info=False;User ID=sa;Initial Catalog=BARKOD;Data Source=(local)"
        '    Registry.LocalMachine.CreateSubKey("Software").CreateSubKey("Fast Reports").CreateSubKey("connections").SetValue("barkod", connection)
        'End If
    End Sub
    Private Function GetConnection(Optional ByVal sdatabase As String = "") As String
        oConnection = New cConnection("veri_baglanti.udl", sdatabase)
        sConnection = oConnection.GetSQLConnectionString()
        oConnection = New cConnection("veri_baglanti.udl", sdatabase)
        SQLconnection = oConnection.GetcSQLConnectionString()
        oConnection = New cConnection("veri_baglanti.udl", sdatabase)
        database = oConnection.GetDatabase()
        oConnection = New cConnection("veri_baglanti.udl", sdatabase)
        sSunucu = oConnection.GetSunucu()
        Return connection
    End Function
    Private Function UpdateConnection(Optional ByVal sdatabase As String = "") As String
        oConnection = New cConnection("veri_baglanti.udl", sdatabase)
        Me.Refresh()
        oConnection.UpdateUDLFile("veri_baglanti.udl")
        oConnection = New cConnection("veri_baglanti.udl", sdatabase)
        sConnection = oConnection.GetSQLConnectionString()
        oConnection = New cConnection("veri_baglanti.udl", sdatabase)
        SQLconnection = oConnection.GetcSQLConnectionString()
        Registry.LocalMachine.CreateSubKey("Software").CreateSubKey("Fast Reports").CreateSubKey("connections").SetValue("UGURLU", connection)
        Return connection
    End Function
    Private Sub kullanici_kontrol(ByVal sKullanici As String, ByVal sPassword As String, ByVal sDatabase As String)
        Dim cmd As New OleDb.OleDbCommand
        Dim con As New OleDb.OleDbConnection
        cmd.Connection = con
        con.ConnectionString = sConnection
        If con.State = ConnectionState.Closed = True Then
            con.Open()
        End If
        Dim nKayit As Integer = 0
        cmd.CommandText = sorgu_query("USE MASTER SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT     COUNT(name) AS nKayit FROM         sysxlogins WHERE     (name LIKE '" & sKullanici & "')")
        Try
            nKayit = cmd.ExecuteScalar
        Catch ex As Exception
            cmd.CommandText = sorgu_query("USE MASTER SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT     COUNT(name) AS nKayit FROM         sysusers WHERE     (name LIKE '" & sKullanici & "')")
            nKayit = cmd.ExecuteScalar
        End Try
        If nKayit = 0 Then
            cmd.CommandText = sorgu_query("USE MASTER EXEC sp_addlogin '" & sKullanici & "', '" & sPassword & "', '" & sDatabase & "', 'Turkish'")
            Try
                cmd.ExecuteNonQuery()
            Catch ex As Exception
                cmd.CommandText = sorgu_query("USE MASTER CREATE LOGIN '" & sKullanici & "'   WITH PASSWORD=N'" & sPassword & "',DEFAULT_DATABASE='" & sDatabase & "',CHECK_EXPIRATION=OFF, CHECK_POLICY=OFF")
                cmd.ExecuteNonQuery()
            End Try
            cmd.CommandText = sorgu_query("USE MASTER exec sp_addsrvrolemember '" & sKullanici & "','sysadmin'")
            Try
                cmd.ExecuteNonQuery()
            Catch ex As Exception
                cmd.CommandText = sorgu_query("USE MASTER exec sp_addrolemember '" & sKullanici & "','sysadmin'")
                cmd.ExecuteNonQuery()
            End Try
            cmd.CommandText = sorgu_query("USE MASTER exec sp_addsrvrolemember '" & sKullanici & "','securityadmin'")
            Try
                cmd.ExecuteNonQuery()
            Catch ex As Exception
                cmd.CommandText = sorgu_query("USE MASTER exec sp_addrolemember '" & sKullanici & "','securityadmin'")
                cmd.ExecuteNonQuery()
            End Try
            cmd.CommandText = sorgu_query("USE MASTER exec sp_addsrvrolemember '" & sKullanici & "','serveradmin'")
            Try
                cmd.ExecuteNonQuery()
            Catch ex As Exception
                cmd.CommandText = sorgu_query("USE MASTER exec sp_addrolemember '" & sKullanici & "','serveradmin'")
                cmd.ExecuteNonQuery()
            End Try
            cmd.CommandText = sorgu_query("USE MASTER exec sp_addsrvrolemember '" & sKullanici & "','setupadmin'")
            Try
                cmd.ExecuteNonQuery()
            Catch ex As Exception
                cmd.CommandText = sorgu_query("USE MASTER exec sp_addrolemember '" & sKullanici & "','setupadmin'")
                cmd.ExecuteNonQuery()
            End Try
            cmd.CommandText = sorgu_query("USE MASTER exec sp_addsrvrolemember '" & sKullanici & "','processadmin'")
            Try
                cmd.ExecuteNonQuery()
            Catch ex As Exception
                cmd.CommandText = sorgu_query("USE MASTER exec sp_addrolemember '" & sKullanici & "','processadmin'")
                cmd.ExecuteNonQuery()
            End Try
            cmd.CommandText = sorgu_query("USE MASTER exec sp_addsrvrolemember '" & sKullanici & "','diskadmin'")
            Try
                cmd.ExecuteNonQuery()
            Catch ex As Exception
                cmd.CommandText = sorgu_query("USE MASTER exec sp_addrolemember '" & sKullanici & "','diskadmin'")
                cmd.ExecuteNonQuery()
            End Try
            cmd.CommandText = sorgu_query("USE MASTER exec sp_addsrvrolemember '" & sKullanici & "','dbcreator'")
            Try
                cmd.ExecuteNonQuery()
            Catch ex As Exception
                cmd.CommandText = sorgu_query("USE MASTER exec sp_addrolemember '" & sKullanici & "','dbcreator'")
                cmd.ExecuteNonQuery()
            End Try
            'cmd.CommandText = sorgu_query("USE MASTER exec sp_addsrvrolemember '" & sKullanici & "','rlYetkiliKullanici'")
            'cmd.ExecuteNonQuery()
            'For Each dr In ds_database.Tables(0).Rows
            cmd.CommandText = sorgu_query("USE " & database & "  exec sp_grantdbaccess  '" & sKullanici & "','" & sKullanici & "'")
            cmd.ExecuteNonQuery()
            cmd.CommandText = sorgu_query("USE " & database & " exec sp_addrolemember N'db_owner', N'" & sKullanici & "'")
            cmd.ExecuteNonQuery()
            cmd.CommandText = sorgu_query("USE " & database & " exec sp_addrolemember N'rlYetkiliKullanici', N'" & sKullanici & "'")
            cmd.ExecuteNonQuery()
            cmd.CommandText = sorgu_query("USE MASTER  exec sp_grantdbaccess  '" & sKullanici & "','" & sKullanici & "'")
            cmd.ExecuteNonQuery()
            cmd.CommandText = sorgu_query("USE MASTER exec sp_addrolemember N'db_owner', N'" & sKullanici & "'")
            cmd.ExecuteNonQuery()
            'Next
        Else
            'cmd.CommandText = "USE MASTER EXEC sp_dropuser '" & sKullanici & "'"
            'cmd.ExecuteNonQuery()
            cmd.CommandText = sorgu_query("USE MASTER exec sp_password NULL, N'" & sPassword & "', N'" & sKullanici & "'")
            cmd.ExecuteNonQuery()
            cmd.CommandText = sorgu_query("USE MASTER ALTER LOGIN '" & sKullanici & "' WITH PASSWORD = N'" & sPassword & "'")
            Try
                cmd.ExecuteNonQuery()
            Catch ex As Exception
            End Try
            'For Each dr In ds_database.Tables(0).Rows
            '    cmd.CommandText = sorgu_query("USE " & dr("name") & " exec sp_grantdbaccess  '" & sKullanici & "','" & sKullanici & "'")
            '    cmd.ExecuteNonQuery()
            'Next
            'cmd.CommandText = sorgu_query("USE MASTER EXEC sp_addlogin '" & sKullanici & "', '" & sPassword & "', '" & sDatabase & "', 'Turkish'")
            'cmd.ExecuteNonQuery()
            'cmd.CommandText = sorgu_query("USE MASTER exec sp_addsrvrolemember '" & sKullanici & "','sysadmin'")
            'cmd.ExecuteNonQuery()
            'cmd.CommandText = sorgu_query("USE MASTER exec sp_addsrvrolemember '" & sKullanici & "','securityadmin'")
            'cmd.ExecuteNonQuery()
            'cmd.CommandText = sorgu_query("USE MASTER exec sp_addsrvrolemember '" & sKullanici & "','serveradmin'")
            'cmd.ExecuteNonQuery()
            'cmd.CommandText = sorgu_query("USE MASTER exec sp_addsrvrolemember '" & sKullanici & "','setupadmin'")
            'cmd.ExecuteNonQuery()
            'cmd.CommandText = sorgu_query("USE MASTER exec sp_addsrvrolemember '" & sKullanici & "','processadmin'")
            'cmd.ExecuteNonQuery()
            'cmd.CommandText = sorgu_query("USE MASTER exec sp_addsrvrolemember '" & sKullanici & "','diskadmin'")
            'cmd.ExecuteNonQuery()
            'cmd.CommandText = sorgu_query("USE MASTER exec sp_addsrvrolemember '" & sKullanici & "','dbcreator'")
            'cmd.ExecuteNonQuery()
        End If
        con.Close()
        cmd = Nothing
        con = Nothing
    End Sub
    Private Sub SimpleButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SimpleButton1.Click
        txt_kod.Text = txt_kod.Text & "1"
    End Sub
    Private Sub SimpleButton2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SimpleButton2.Click
        txt_kod.Text = txt_kod.Text & "2"
    End Sub
    Private Sub SimpleButton3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SimpleButton3.Click
        txt_kod.Text = txt_kod.Text & "3"
    End Sub
    Private Sub SimpleButton6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SimpleButton6.Click
        txt_kod.Text = txt_kod.Text & "4"
    End Sub
    Private Sub SimpleButton5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SimpleButton5.Click
        txt_kod.Text = txt_kod.Text & "5"
    End Sub
    Private Sub SimpleButton4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SimpleButton4.Click
        txt_kod.Text = txt_kod.Text & "6"
    End Sub
    Private Sub SimpleButton9_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SimpleButton9.Click
        txt_kod.Text = txt_kod.Text & "7"
    End Sub
    Private Sub SimpleButton8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SimpleButton8.Click
        txt_kod.Text = txt_kod.Text & "8"
    End Sub
    Private Sub SimpleButton7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SimpleButton7.Click
        txt_kod.Text = txt_kod.Text & "9"
    End Sub
    Private Sub SimpleButton12_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SimpleButton12.Click
        txt_kod.Text = ""
    End Sub
    Private Sub SimpleButton11_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SimpleButton11.Click
        txt_kod.Text = txt_kod.Text & "0"
    End Sub
    Private Sub SimpleButton10_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SimpleButton10.Click
        kasiyer_kontrol()
    End Sub
    Private Sub SimpleButton13_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SimpleButton13.Click
        Me.Close()
        If islemstatus = False Then
            Application.Exit()
        End If
    End Sub
    Private Sub txt_kod_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txt_kod.KeyDown
        If e.KeyCode = Keys.Enter Then
            kasiyer_kontrol()
        End If
    End Sub
    Private Sub sec_database_EditValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles sec_database.EditValueChanged
        dataload_kasiyer(sec_database.EditValue)
        GetConnection(sec_database.Text)
    End Sub
    Private Sub Timer1_Tick_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        LabelControl2.Text = Now.ToLongDateString & " " & Now.ToLongTimeString
    End Sub

    Private Sub ApplicationTitle_Click(sender As Object, e As EventArgs) Handles ApplicationTitle.Click

    End Sub
End Class