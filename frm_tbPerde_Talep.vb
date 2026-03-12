Imports FastReport
Imports DevExpress.XtraGrid
Imports DevExpress.XtraEditors
Imports DevExpress.XtraGrid.Columns
Imports Microsoft.Win32
Imports System.IO
Public Class frm_tbPerde_Talep
    Public connection As String
    Public firmano As String
    Public donemno As String
    Public kullanici
    Public nPerdeTalepID As Int64 = 0
    Dim sFisTipi As String = "SK"
    Dim dr_baslik As DataRow
    Dim bKapat As Boolean = False
    Dim sSorgu_Baslik As String = ""
    Dim sSorgu_Hareket As String = ""
    Dim sSorgu_Toplam As String = ""
    Dim info As Boolean = True
    Dim mevcut As Decimal = 0.01
    Dim x As Integer = 0
    Dim okut As Boolean = False
    Dim nFontSize As Decimal = 8.25
    Dim bKilitli As Boolean = False
    Dim bKilitAcabilir As Boolean = False
    Public bYenidenHesapla As Boolean = False
    Public bResmi As Boolean = False
    Public ds_tbPerdeTalepDetayDuzelt As DataSet
    Dim ds_tbParamAlisVeris As DataSet
    Dim ds_tbDepo As DataSet
    Dim ds_tbSatici As DataSet
    Dim ds_Satici As DataSet
    Dim ds_tbFiyatTipi As DataSet
    Dim dr_param As DataRow
    Dim sFiyatTipi As String = ""
    Private Sub frm_tbPerde_Talep_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        If fis_kontrolleri() = True Then
        Else
            e.Cancel = True
        End If
    End Sub
    Private Function fis_kontrolleri() As Boolean
        Dim pass As Boolean = False
        Dim bCikisIptal As Integer = -1
        Try
            If dr_param("bSaticiRumuzuVarmi") = True Then
                Dim drs As DataRow
                Dim sayi As Integer = -1
                For Each drs In ds_tbPerdeTalepDetay.Tables(0).Rows
                    sayi += 1
                    If Trim(drs("sSaticiRumuzu")) = "" And bCikisIptal = -1 Then
                        bCikisIptal = sayi
                    End If
                Next
                drs = Nothing
                sayi = Nothing
            End If
        Catch ex As Exception
        End Try
        'Try
        '    If dr_param("bLimitAsimiIzinlimi") = False Then
        '        Dim ds_TaksitKalan As DataSet
        '        ds_TaksitKalan = sorgu(sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT * FROM (SELECT tbMusteri.nMusteriID AS FIRMANO, tbMusteri.lKodu AS FIRMAKODU, ISNULL(SUM(tbTaksit.lTutari), 0) AS TUTAR, ISNULL(SUM(tbOdeme.odeme), 0) AS TAHSILAT, ISNULL(ISNULL(SUM(tbTaksit.lTutari), 0) - ISNULL(SUM(tbOdeme.odeme), 0), 0) AS KALAN, tbTaksit.dteTarihi, YEAR(tbTaksit.dteTarihi) AS YIL,DATENAME([month],tbTaksit.dteTarihi) AS AY,ROUND(CAST(GETDATE() - (CAST(tbTaksit.dteTarihi AS INT) + 1) AS FLOAT), 0) AS GECIKME FROM (SELECT isnull(SUM(lOdemeTutar), 0) AS odeme, nTaksitId FROM tbOdeme GROUP BY nTaksitId) tbOdeme RIGHT OUTER JOIN tbTaksit INNER JOIN tbAlisVeris ON tbTaksit.nAlisverisID = tbAlisVeris.nAlisverisID INNER JOIN tbMusteri ON tbAlisVeris.nMusteriID = tbMusteri.nMusteriID ON tbOdeme.nTaksitId = tbTaksit.nTaksitID WHERE (tbMusteri.nMusteriID = " & dr_baslik("nMusteriID") & ") GROUP BY tbMusteri.nMusteriID, tbMusteri.lKodu, tbTaksit.dteTarihi) DERIVEDTBL WHERE (KALAN <> 0) ORDER BY dteTarihi "), "KalanTaksit")
        '        Dim drk As DataRow
        '        Dim lBakiye As Decimal = 0
        '        For Each drk In ds_TaksitKalan.Tables(0).Rows
        '            lBakiye += drk("KALAN")
        '        Next
        '        If lBakiye > dr_baslik("lKrediLimiti") And dr_baslik("lKrediLimiti") > 0 Then
        '            bCikisIptal = -2
        '        End If
        '        lBakiye = Nothing
        '        drk = Nothing
        '        ds_TaksitKalan = Nothing
        '    End If
        'Catch ex As Exception
        'End Try
        If bCikisIptal >= 0 Then
            XtraMessageBox.Show(Sorgu_sDil("Fişte Satıcı Bilgisini Boş Bırakamazsınız...!" & vbCrLf & "Lütfen Satıcı Bilgilerini Doldurunuz...", sDil), Sorgu_sDil("Dikkat", sDil), MessageBoxButtons.OK, MessageBoxIcon.Warning)
            GridControl1.Focus()
            GridControl1.Select()
            GridView1.FocusedColumn = colsSaticiRumuzu
            GridView1.FocusedRowHandle = bCikisIptal
            GridView1.ClearSelection()
            GridView1.SelectRow(bCikisIptal)
        ElseIf bCikisIptal = -2 Then
            XtraMessageBox.Show(Sorgu_sDil("Müşteri Kredi Limitini Aşamazsınız..." & vbCrLf & "Lütfen Sistem Yöneticinizle Görüşün!", sDil), Sorgu_sDil("Dikkat", sDil), MessageBoxButtons.OK, MessageBoxIcon.Warning)
        ElseIf bCikisIptal = -1 Then
            pass = True
        End If
        Return pass
    End Function
    Private Sub dataload_tbParamAlisVeris()
        ds_tbParamAlisVeris = sorgu("SET DATEFORMAT DMY SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED Select * from tbParamAlisVeris Where sMagazaKodu='" & sDepo & "' ")
        dr_param = ds_tbParamAlisVeris.Tables(0).Rows(0)

        If kullanici > 3 Then


            If dr_param("bTarihDegistirilebilsinmi") = False Then
                rowdteTalepTarihi.Properties.ReadOnly = True
            End If
            If dr_param("bEskilerIptalEdilsinmi") = False Then
                'btn_AltFisSil.Enabled = False
                btn_FisSil.Enabled = False
            End If

        End If

    End Sub
    Private Sub frm_tbPerde_Talep_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            gorunum_yukle()
        Catch ex As Exception
        End Try
        dataload_Depo()
        dataload_satici()
        dataload_FiyatTipi()
        baslik()
        If nPerdeTalepID <> 0 Then
            loaded()
        End If
    End Sub
    Private Sub baslik()
        If nPerdeTalepID = 0 Then
            Dim dr As DataRow = ds_tbPerdeTalepMaster.Tables(0).NewRow
            dr("dteTalepTarihi") = dteSistemTarihi
            dr("nMusteriID") = 0
            dr("lKodu") = 0
            dr("sAdi") = ""
            dr("sSoyadi") = ""
            dr("sAdres1") = ""
            dr("sAdres2") = ""
            dr("sYetkili") = ""
            dr("sTelefon") = ""
            dr("sEMail") = ""
            dr("sGSM") = ""
            dr("sYetkili") = ""
            dr("sAciklama1") = ""
            dr("sAciklama2") = ""
            dr("sAciklama3") = ""
            dr("sAciklama4") = ""
            dr("sAciklama5") = ""
            dr("lToplamMiktar") = 0
            dr("lToplamMalBedeli") = 0
            dr("lOdenen") = 0
            dr("sKullaniciAdi") = kullaniciadi
            dr("dteKayitTarihi") = Now
            dr("sSonuc") = "Bekliyor"
            nPerdeTalepID = tbPerdeTalepMaster_kaydet_yeni(dr("dteTalepTarihi"), dr("nMusteriID"), dr("lKodu").ToString, dr("sAdi").ToString, dr("sSoyadi").ToString, dr("sAdres1").ToString, dr("sAdres2").ToString, dr("sTelefon").ToString, dr("sGSM").ToString, dr("sEMail").ToString, dr("sYetkili").ToString, dr("sAciklama1").ToString, dr("sAciklama2").ToString, dr("sAciklama3").ToString, dr("sAciklama4").ToString, dr("sAciklama5").ToString, dr("lToplamMiktar"), dr("lToplamMalBedeli"), dr("lOdenen"), dr("sSonuc").ToString, dr("sKullaniciAdi").ToString, dr("dteKayitTarihi"))
            dr("nPerdeTalepID") = nPerdeTalepID
            ds_tbPerdeTalepMaster.Tables(0).Rows.Add(dr)
            dr = Nothing
            'Try
            '    tbFisKilit_ekle(nBordroID, sFisTipi, kullanici, Now)
            'Catch ex As Exception
            '    bKilitli = False
            'End Try
        ElseIf nPerdeTalepID <> 0 Then
            'If sorgu_nKilit(nBordroID, sFisTipi, kullanici) = 0 Then
            '    bKilitli = False
            '    Try
            '        tbFisKilit_ekle(nBordroID, sFisTipi, kullanici, Now)
            '    Catch ex As Exception
            '        bKilitli = True
            '    End Try
            'Else
            '    bKilitli = True
            'End If
        Else
            Me.Close()
        End If
    End Sub
    Private Sub gorunum_kaydet()
        If Trim(sDil) = "TR" Or Trim(sDil) = "" Then
            VGrid_baslik.SaveLayoutToRegistry("SOFTWARE\BusinessSmart\VIEW\PERDETALEP\" & Trim(sFisTipi) & "\BASLIK\" & Me.Name.ToString & "")
            GridView1.SaveLayoutToRegistry("SOFTWARE\BusinessSmart\VIEW\PERDETALEP\" & Trim(sFisTipi) & "\HAREKET\" & Me.Name.ToString & "")
        Else
            VGrid_baslik.SaveLayoutToRegistry("SOFTWARE\BusinessSmart\VIEW\PERDETALEP\" & sDil & "\" & Trim(sFisTipi) & "\BASLIK\" & Me.Name.ToString & "")
            GridView1.SaveLayoutToRegistry("SOFTWARE\BusinessSmart\VIEW\PERDETALEP\" & sDil & "\" & Trim(sFisTipi) & "\HAREKET\" & Me.Name.ToString & "")
        End If
        XtraMessageBox.Show(Sorgu_sDil("Görünüm Kaydedildi", sDil), Sorgu_sDil("Dikkat", sDil), MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub
    Private Sub gorunum_yukle()
        Try
        Catch ex As Exception
        End Try
        Try
            If nFontSize > 0 Then
                Dim sayi As Single = nFontSize
                GridView1.Appearance.Row.Font = New System.Drawing.Font("Tahoma", sayi, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
                GridView1.Appearance.FooterPanel.Font = New System.Drawing.Font("Tahoma", sayi, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
                GridView1.Appearance.HeaderPanel.Font = New System.Drawing.Font("Tahoma", sayi, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
                sayi = Nothing
            End If
        Catch ex As Exception
        End Try
        For Each btn As DevExpress.XtraBars.BarItem In BarManager1.Items
            btn.Caption = Sorgu_sDil(btn.Caption, sDil)
        Next
        For Each clmn As DevExpress.XtraGrid.Columns.GridColumn In GridView1.Columns
            clmn.Caption = Sorgu_sDil(clmn.Caption, sDil)
        Next
        For Each clmn As DevExpress.XtraGrid.Columns.GridColumn In GridView2.Columns
            clmn.Caption = Sorgu_sDil(clmn.Caption, sDil)
        Next
        Dim row
        For Each row In VGrid_baslik.Rows
            Try
                row.Properties.Caption = Sorgu_sDil(row.Properties.Caption, sDil)
            Catch ex As Exception
            End Try
        Next
        If Trim(sDil) = "TR" Or Trim(sDil) = "" Then
            'VGrid_baslik.RestoreLayoutFromRegistry("SOFTWARE\BusinessSmart\VIEW\BORDRO\" & Trim(sFisTipi) & "\BASLIK\" & Me.Name.ToString & "")
            GridView1.RestoreLayoutFromRegistry("SOFTWARE\BusinessSmart\VIEW\PERDETALEP\" & Trim(sFisTipi) & "\HAREKET\" & Me.Name.ToString & "")
        Else
            'VGrid_baslik.RestoreLayoutFromRegistry("SOFTWARE\BusinessSmart\VIEW\BORDRO\" & sDil & "\" & Trim(sFisTipi) & "\BASLIK\" & Me.Name.ToString & "")
            GridView1.RestoreLayoutFromRegistry("SOFTWARE\BusinessSmart\VIEW\PERDETALEP\" & sDil & "\" & Trim(sFisTipi) & "\HAREKET\" & Me.Name.ToString & "")
        End If
    End Sub
    Private Sub gorunum_yazdir()
        Dim kriter As String = ""
        kriter += Microsoft.VisualBasic.Left(dr_baslik("dteTalepTarihi"), 10) & " Tarihli  Sonuç:" & dr_baslik("sSonuc") & vbCrLf
        kriter += " FisNo = " & dr_baslik("nPerdeTalepID") & " Nolu BordroTipi: Perde Fişi Müşteri:" & dr_baslik("sAdi") & " " & dr_baslik("sSoyadi") & " Telefon: " & dr_baslik("sTelefon") & "/" & dr_baslik("sGSM")
        Me.printlink1.PageHeaderFooter = New DevExpress.XtraPrinting.PageHeaderFooter(New DevExpress.XtraPrinting.PageHeaderArea(New String() {"[User Name]", kriter, "[Date Printed][Time Printed]"}, New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte)), DevExpress.XtraPrinting.BrickAlignment.Center), New DevExpress.XtraPrinting.PageFooterArea(New String() {"Powered by www.barkodyazilimevi.com", "Finan Bordro Yönetimi", "[Page # of Pages #]"}, New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte)), DevExpress.XtraPrinting.BrickAlignment.Near))
        Printlink1.CreateDocument(ps)
        ps.PreviewRibbonFormEx.Show()
    End Sub
    Private Function sorgu(ByVal query As String, Optional ByVal sTable As String = "TABLE1") As DataSet
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
        Dim N As Integer = adapter.Fill(DS, sTable)
        con.Close()
        Return DS
    End Function
    Private Function sorgu_kriter_string(ByVal deger As String, ByVal kriter As String) As String
        Dim sorgu_kriter As String = ""
        If kriter = "Başlar" Then
            sorgu_kriter = " LIKE '" & deger & "%' "
        ElseIf kriter = "Biter" Then
            sorgu_kriter = " LIKE '%" & deger & "' "
        ElseIf kriter = "İçerir" Then
            sorgu_kriter = " LIKE '%" & deger & "%' "
        ElseIf kriter = "Boş" Then
            sorgu_kriter = " IS NULL "
        ElseIf kriter = "Dolu" Then
            sorgu_kriter = " <> '' "
        ElseIf kriter = "Farklı" Then
            sorgu_kriter = " <> '" & deger & "' "
        ElseIf kriter = "Büyük" Then
            sorgu_kriter = " >  '" & deger & "' "
        ElseIf kriter = "Küçük" Then
            sorgu_kriter = " < '" & deger & "' "
        ElseIf kriter = "Eşittir" Then
            sorgu_kriter = " = '" & deger & "' "
        End If
        Return sorgu_kriter
    End Function
    Private Sub loaded()
        dataload_baslik()
        dr_baslik = ds_tbPerdeTalepMaster.Tables(0).Rows(0)
        dataload_harekets()
        Dataload_tbYekun(dr_baslik("nPerdeTalepID"))
        Try
            dataload_tbParamAlisVeris()
        Catch ex As Exception
        End Try
    End Sub
    Private Sub dataload_baslik()
        ds_tbPerdeTalepMaster.Tables(0).Clear()
        ds_tbPerdeTalepMaster = sorgu_baslik(nPerdeTalepID)
        VGrid_baslik.DataSource = ds_tbPerdeTalepMaster
        VGrid_baslik.DataMember = "BASLIK"
        VGrid_baslik.Refresh()
    End Sub
    Private Function sorgu_baslik(ByVal nPerdeTalepID As String) As DataSet
        Dim cmd As New OleDb.OleDbCommand
        Dim con As New OleDb.OleDbConnection
        Dim adapter As New OleDb.OleDbDataAdapter
        con.ConnectionString = connection
        adapter.SelectCommand = cmd
        cmd.CommandText = sorgu_query("SET DATEFORMAT DMY SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED  SELECT     * from tbPerdeTalepMaster Where nPerdeTalepID ='" & nPerdeTalepID & "'")
        sSorgu_Baslik = cmd.CommandText
        cmd.Connection = con
        con.Open()
        Dim DS As New DataSet
        Dim N As Integer = adapter.Fill(DS, "BASLIK")
        con.Close()
        Return DS
        cmd = Nothing
        con = Nothing
        adapter = Nothing
    End Function
    Private Sub dataload_harekets()
        ds_tbPerdeTalepDetay = sorgu_harekets(nPerdeTalepID)
        GridControl1.DataSource = ds_tbPerdeTalepDetay.Tables(0)
        GridControl1.DataMember = Nothing
        GridControl1.RefreshDataSource()
        GridControl1.Refresh()
        GridControl1.Select()
    End Sub
    Private Sub dataload_Depo()
        ds_tbDepo = sorgu(sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT     sDepo, sAciklama FROM         tbDepo ORDER BY sDepo"))
        sec_sDepo.DataSource = ds_tbDepo.Tables(0)
        sec_sDepoRumuzu.DataSource = ds_tbDepo.Tables(0)
    End Sub
    Private Sub dataload_satici()
        ds_tbSatici = sorgu(sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT     sSaticiRumuzu, sAdi + ' ' + sSoyadi AS sSatici,nPrim  FROM         tbSatici Where (bAktif = 1)"))
        sec_sSatici.DataSource = ds_tbSatici.Tables(0)
        sec_sSaticiRumuzu.DataSource = ds_tbSatici.Tables(0)
        ds_Satici = sorgu(sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT     CAST('0' as bit) AS SEC, sSaticiRumuzu AS KOD, sAdi + ' ' + sSoyadi AS ACIKLAMA FROM         tbSatici where bAktif =1"))
    End Sub
    Private Sub dataload_FiyatTipi()
        ds_tbFiyatTipi = sorgu(sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT     * FROM         tbFiyatTipi where (aktif = 1) and (aktifDepo like '%" & Trim(sDepo) & "%')"))
        sec_sFiyatTipi.DataSource = ds_tbFiyatTipi.Tables(0)
    End Sub
    Private Sub dataload_hareket_detay()
        If GridView1.RowCount > 0 Then
            Dim dr As DataRow
            dr = GridView1.GetDataRow(GridView1.FocusedRowHandle)
            If dr("sTur") = "Fon" Or dr("sTur") = "Farbela" Or dr("sTur") = "Sistem" Then
                GroupControl3.Text = dr("nKayitID") & "/" & dr("sKodu") & "/" & dr("sAciklama")
                ds_tbPerdeTalepDetayDuzelt = sorgu_hareket_detay(nPerdeTalepID, dr("nKayitID"))
                GridControl2.DataSource = ds_tbPerdeTalepDetayDuzelt.Tables(0)
                GridControl2.DataMember = Nothing
                GridControl2.RefreshDataSource()
                GridControl2.Refresh()
                XtraTabControl1.SelectedTabPageIndex = 1
                GridControl2.Select()
            End If
        End If
    End Sub
    Private Function sorgu_harekets(ByVal nPerdeTalepID As String) As DataSet
        Dim cmd As New OleDb.OleDbCommand
        Dim con As New OleDb.OleDbConnection
        Dim adapter As New OleDb.OleDbDataAdapter
        con.ConnectionString = connection
        adapter.SelectCommand = cmd
        cmd.CommandText = sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT * from tbPerdeTalepDetay WHERE nPerdeTalepID =" & nPerdeTalepID & "  and nDetay = 0 Order by nKayitID ")
        sSorgu_Hareket = cmd.CommandText
        cmd.Connection = con
        con.Open()
        Dim DS As New DataSet
        Dim N As Integer = adapter.Fill(DS, "HAREKET")
        con.Close()
        Return DS
        cmd = Nothing
        con = Nothing
        adapter = Nothing
    End Function
    Private Function sorgu_hareket_detay(ByVal nPerdeTalepID As String, ByVal nKayitID As Int64) As DataSet
        Dim cmd As New OleDb.OleDbCommand
        Dim con As New OleDb.OleDbConnection
        Dim adapter As New OleDb.OleDbDataAdapter
        con.ConnectionString = connection
        adapter.SelectCommand = cmd
        cmd.CommandText = sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT * from tbPerdeTalepDetay WHERE nPerdeTalepID =" & nPerdeTalepID & " and nDetayID = " & nKayitID & "  Order by nKayitID ")
        sSorgu_Hareket = cmd.CommandText
        cmd.Connection = con
        con.Open()
        Dim DS As New DataSet
        Dim N As Integer = adapter.Fill(DS, "HAREKET")
        con.Close()
        Return DS
        cmd = Nothing
        con = Nothing
        adapter = Nothing
    End Function
    Public Sub Dataload_tbYekun(ByVal nPerdeTalepID As Integer)
        sSorgu_Toplam = sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT     sTur, COUNT(sTur) AS nKayit, SUM(lMiktar) AS lMiktar, SUM(lTutar) AS lTutar, SUM(lToplamUcret) AS lToplamUcret FROM         tbPerdeTalepDetay WHERE     (nPerdeTalepID = " & nPerdeTalepID & ") GROUP BY sTur ")
        ds_tbPerdeTalepToplam = sorgu(sSorgu_Toplam, "TOPLAM")
        GridControl3.DataSource = ds_tbPerdeTalepToplam.Tables(0)
        GridControl3.DataMember = Nothing
        Dim dr As DataRow
        Dim lMiktar As Decimal = 0
        Dim lMalBedeli As Decimal = 0
        For Each dr In ds_tbPerdeTalepToplam.Tables(0).Rows
            lMiktar += sorgu_sayi(dr("lMiktar"), 0)
            lMalBedeli += sorgu_sayi(dr("lTutar"), 0)
        Next
        dr_baslik("lToplamMiktar") = lMiktar
        dr_baslik("lToplamMalBedeli") = lMalBedeli
        baslik_degistir()
        lMiktar = Nothing
        lMalBedeli = Nothing
    End Sub
    Private Function tbPerdeTalepMaster_kaydet_yeni(ByVal dteTalepTarihi As DateTime, ByVal nMusteriID As Int64, ByVal lKodu As String, ByVal sAdi As String, ByVal sSoyadi As String, ByVal sAdres1 As String, ByVal sAdres2 As String, ByVal sTelefon As String, ByVal sGsm As String, ByVal sEMail As String, ByVal sYetkili As String, ByVal sAciklama1 As String, ByVal sAciklama2 As String, ByVal sAciklama3 As String, ByVal sAciklama4 As String, ByVal sAciklama5 As String, ByVal lToplamMiktar As Decimal, ByVal lToplamMalBedeli As Decimal, ByVal lOdenen As Decimal, ByVal sSonuc As String, ByVal sKullaniciAdi As String, ByVal dteKayitTarihi As DateTime) As Int64
        Dim cmd As New OleDb.OleDbCommand
        Dim con As New OleDb.OleDbConnection
        con.ConnectionString = connection
        cmd.Connection = con
        If con.State = ConnectionState.Closed Then
            con.Open()
        End If
        cmd.CommandText = sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED INSERT INTO tbPerdeTalepMaster (dteTalepTarihi, nMusteriID, lKodu, sAdi, sSoyadi, sAdres1, sAdres2, sTelefon, sGsm, sEMail, sYetkili, sAciklama1, sAciklama2, sAciklama3, sAciklama4, sAciklama5, lToplamMiktar, lToplamMalBedeli, lOdenen, sSonuc, sKullaniciAdi, dteKayitTarihi) VALUES     ('" & dteTalepTarihi & "', " & nMusteriID & ", '" & lKodu & "', '" & sAdi & "', '" & sSoyadi & "', '" & sAdres1 & "', '" & sAdres2 & "', '" & sTelefon & "', '" & sGsm & "', '" & sEMail & "', '" & sYetkili & "', '" & sAciklama1 & "', '" & sAciklama2 & "', '" & sAciklama3 & "', '" & sAciklama4 & "', '" & sAciklama5 & "', " & lToplamMiktar & ", " & lToplamMalBedeli & ", " & lOdenen & ", '" & sSonuc & "', '" & sKullaniciAdi & "', '" & dteKayitTarihi & "')")
        cmd.ExecuteNonQuery()
        cmd.CommandText = sorgu_query("SELECT SCOPE_IDENTITY()")
        Dim kayitno = cmd.ExecuteScalar
        Return kayitno
        con.Close()
        cmd = Nothing
        con = Nothing
    End Function
    Private Sub tbPerdeTalepMaster_kaydet_duzelt(ByVal nPerdeTalepID As Int64, ByVal dteTalepTarihi As DateTime, ByVal nMusteriID As Int64, ByVal lKodu As String, ByVal sAdi As String, ByVal sSoyadi As String, ByVal sAdres1 As String, ByVal sAdres2 As String, ByVal sTelefon As String, ByVal sGsm As String, ByVal sEMail As String, ByVal sYetkili As String, ByVal sAciklama1 As String, ByVal sAciklama2 As String, ByVal sAciklama3 As String, ByVal sAciklama4 As String, ByVal sAciklama5 As String, ByVal lToplamMiktar As Decimal, ByVal lToplamMalBedeli As Decimal, ByVal lOdenen As Decimal, ByVal sSonuc As String, ByVal sKullaniciAdi As String, ByVal dteKayitTarihi As DateTime)
        Dim cmd As New OleDb.OleDbCommand
        Dim con As New OleDb.OleDbConnection
        con.ConnectionString = connection
        cmd.Connection = con
        If con.State = ConnectionState.Closed Then
            con.Open()
        End If
        cmd.CommandText = sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED UPDATE    tbPerdeTalepMaster SET              dteTalepTarihi = '" & dteTalepTarihi & "', nMusteriID = " & nMusteriID & ", lKodu = '" & lKodu & "', sAdi = '" & sAdi & "', sSoyadi = '" & sSoyadi & "', sAdres1 = '" & sAdres1 & "', sAdres2 = '" & sAdres2 & "', sTelefon = '" & sTelefon & "',  sGsm = '" & sGsm & "', sEMail = '" & sEMail & "', sYetkili = '" & sYetkili & "', sAciklama1 = '" & sAciklama1 & "', sAciklama2 = '" & sAciklama2 & "', sAciklama3 = '" & sAciklama3 & "', sAciklama4 = '" & sAciklama4 & "',   sAciklama5 = '" & sAciklama5 & "', lToplamMiktar = " & lToplamMiktar & ", lToplamMalBedeli = " & lToplamMalBedeli & ", lOdenen = " & lOdenen & ", sSonuc = '" & sSonuc & "' Where nPerdeTalepID = " & nPerdeTalepID & "")
        cmd.ExecuteNonQuery()
        con.Close()
        cmd = Nothing
        con = Nothing
    End Sub
    Private Sub tbPerdeTalepMaster_kaydet_Sil(ByVal nPerdeTalepID As Int64)
        Dim cmd As New OleDb.OleDbCommand
        Dim con As New OleDb.OleDbConnection
        con.ConnectionString = connection
        cmd.Connection = con
        If con.State = ConnectionState.Closed Then
            con.Open()
        End If
        cmd.CommandText = sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED DELETE FROM    tbPerdeTalepDetay  Where nPerdeTalepID = " & nPerdeTalepID & "")
        cmd.ExecuteNonQuery()
        cmd.CommandText = sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED DELETE FROM    tbPerdeTalepMaster  Where nPerdeTalepID = " & nPerdeTalepID & "")
        cmd.ExecuteNonQuery()
        con.Close()
        cmd = Nothing
        con = Nothing
    End Sub
    Private Function tbPerdeTalepDetay_kaydet_yeni(ByVal nPerdeTalepID As Int64, ByVal sYer As String, ByVal sTur As String, ByVal sMagaza As String, ByVal sSaticiRumuzu As String, ByVal nDetay As Int64, ByVal nDetayID As Int64, ByVal nStokID As Int64, ByVal sKodu As String, ByVal sAciklama As String, ByVal nEn As Decimal, ByVal nBoy As Decimal, ByVal nPileOrani As Decimal, ByVal nPay As Decimal, ByVal lMiktar As Decimal, ByVal lBirimFiyat As Decimal, ByVal lTutar As Decimal, ByVal nIscilikMiktari As Decimal, ByVal lIscilikUcreti As Decimal, ByVal lToplamUcret As Decimal, ByVal sNot As String, ByVal sTerzi As String, ByVal sKullaniciAdi As String, ByVal dteKayitTarihi As DateTime, ByVal sSonKullaniciAdi As String, ByVal dteUpdateTarihi As DateTime) As Int64
        Dim cmd As New OleDb.OleDbCommand
        Dim con As New OleDb.OleDbConnection
        con.ConnectionString = connection
        cmd.Connection = con
        If con.State = ConnectionState.Closed Then
            con.Open()
        End If
        cmd.CommandText = sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED INSERT INTO tbPerdeTalepDetay (nPerdeTalepID, sYer, sTur,sMagaza,sSaticiRumuzu,nDetay, nDetayID, nStokID, sKodu, sAciklama, nEn, nBoy, nPileOrani, nPay,lMiktar, lBirimFiyat, lTutar, nIscilikMiktari, lIscilikUcreti, lToplamUcret, sNot, sTerzi, sKullaniciAdi, dteKayitTarihi, sSonKullaniciAdi, dteUpdateTarihi) VALUES     (" & nPerdeTalepID & ", '" & sYer & "','" & sTur & "', '" & sMagaza & "','" & sSaticiRumuzu & "'," & nDetay & ", " & nDetayID & ", " & nStokID & ", '" & sKodu & "', '" & sAciklama & "', " & nEn & ", " & nBoy & ", " & nPileOrani & ", " & nPay & "," & lMiktar & ", " & lBirimFiyat & ", " & lTutar & ", " & nIscilikMiktari & ", " & lIscilikUcreti & ", " & lToplamUcret & ", '" & sNot & "', '" & sTerzi & "', '" & sKullaniciAdi & "', '" & dteKayitTarihi & "', '" & sSonKullaniciAdi & "', '" & dteUpdateTarihi & "')")
        cmd.ExecuteNonQuery()
        cmd.CommandText = sorgu_query("SELECT SCOPE_IDENTITY()")
        Dim kayitno = cmd.ExecuteScalar
        Return kayitno
        con.Close()
        cmd = Nothing
        con = Nothing
    End Function
    Private Sub tbPerdeTalepDetay_kaydet_duzelt(ByVal nKayitID As Int64, ByVal nPerdeTalepID As Int64, ByVal sYer As String, ByVal sTur As String, ByVal sMagaza As String, ByVal sSaticiRumuzu As String, ByVal nDetay As Int64, ByVal nDetayID As Int64, ByVal nStokID As Int64, ByVal sKodu As String, ByVal sAciklama As String, ByVal nEn As Decimal, ByVal nBoy As Decimal, ByVal nPileOrani As Decimal, ByVal nPay As Decimal, ByVal lMiktar As Decimal, ByVal lBirimFiyat As Decimal, ByVal lTutar As Decimal, ByVal nIscilikMiktari As Decimal, ByVal lIscilikUcreti As Decimal, ByVal lToplamUcret As Decimal, ByVal sNot As String, ByVal sTerzi As String, ByVal sKullaniciAdi As String, ByVal dteKayitTarihi As DateTime, ByVal sSonKullaniciAdi As String, ByVal dteUpdateTarihi As DateTime)
        Dim cmd As New OleDb.OleDbCommand
        Dim con As New OleDb.OleDbConnection
        con.ConnectionString = connection
        cmd.Connection = con
        If con.State = ConnectionState.Closed Then
            con.Open()
        End If
        cmd.CommandText = sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED UPDATE    tbPerdeTalepDetay SET               sYer = '" & sYer & "', sTur = '" & sTur & "', sMagaza = '" & sMagaza & "',sSaticiRumuzu = '" & sSaticiRumuzu & "',nStokID = " & nStokID & ", sKodu = '" & sKodu & "', sAciklama = '" & sAciklama & "', nEn = " & nEn & ", nBoy = " & nBoy & ", nPileOrani = " & nPileOrani & ", nPay = " & nPay & ",lMiktar = " & lMiktar & ", lBirimFiyat = " & lBirimFiyat & ", lTutar = " & lTutar & ", nIscilikMiktari = " & nIscilikMiktari & ", lIscilikUcreti = " & lIscilikUcreti & ",  lToplamUcret = " & lToplamUcret & ", sNot = '" & sNot & "', sTerzi = '" & sTerzi & "', sSonKullaniciAdi = '" & sSonKullaniciAdi & "', dteUpdateTarihi = '" & dteUpdateTarihi & "' Where nKayitID = " & nKayitID & "")
        cmd.ExecuteNonQuery()
        cmd.CommandText = sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED UPDATE    tbPerdeTalepDetay SET sTur = '" & sTur & "' Where nDetayID = " & nKayitID & " and nDetay = 1")
        cmd.ExecuteNonQuery()
        con.Close()
        cmd = Nothing
        con = Nothing
    End Sub
    Private Sub tbPerdeTalepDetay_kaydet_sil(ByVal nKayitID As Int64)
        Dim cmd As New OleDb.OleDbCommand
        Dim con As New OleDb.OleDbConnection
        con.ConnectionString = connection
        cmd.Connection = con
        If con.State = ConnectionState.Closed Then
            con.Open()
        End If
        cmd.CommandText = sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED DELETE FROM  tbPerdeTalepDetay  Where nDetayID = " & nKayitID & "")
        cmd.ExecuteNonQuery()
        cmd.CommandText = sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED DELETE FROM  tbPerdeTalepDetay  Where nKayitID = " & nKayitID & "")
        cmd.ExecuteNonQuery()
        con.Close()
        cmd = Nothing
        con = Nothing
    End Sub
    Private Sub raporla(ByVal nIslem As Integer)
        Dim OpenFileDialog1 As New Windows.Forms.OpenFileDialog
        OpenFileDialog1.Title = "Rapor Seç..."
        OpenFileDialog1.Filter = "Rapor Dosyaları (Form*.frx) |Form*.frx"
        'OpenFileDialog1.FileName = "c:\Formlar\Raporlar\FirmaBordro\Form.frx"
        OpenFileDialog1.FileName = "c:\Formlar\Raporlar\Perde\Form_" & Trim(sFisTipi) & ".frx"
        OpenFileDialog1.InitialDirectory = "c:\Formlar\Raporlar\Perde"
        If OpenFileDialog1.ShowDialog = Windows.Forms.DialogResult.OK Then
            Dim sFile = OpenFileDialog1.FileName.ToString
            Dim report As New FastReport.Report
            report.Load(sFile)
            report.RegisterData(ds_tbPerdeTalepMaster)
            report.RegisterData(ds_tbPerdeTalepDetay)
            Dim ds_tbPerdeTalepDetaylar As DataSet = sorgu(sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT nKayitID, nPerdeTalepID, sYer, sTur, sMagaza, sSaticiRumuzu, nDetay, nKayitID AS nDetayID, nStokID, sKodu, sAciklama, nEn, nBoy, nPileOrani, nPay, lMiktar, lBirimFiyat, lTutar, nIscilikMiktari, lIscilikUcreti, lToplamUcret, sNot, sTerzi, sKullaniciAdi, dteKayitTarihi, sSonKullaniciAdi, dteUpdateTarihi FROM tbPerdeTalepDetay WHERE (nDetay = 0) AND (nPerdeTalepID = " & dr_baslik("nPerdeTalepID") & ") UNION ALL SELECT nDetayID AS nKayitID, nPerdeTalepID, sYer, sTur, sMagaza, sSaticiRumuzu, nDetay, nKayitID nDetayID, nStokID, sKodu, sAciklama, nEn, nBoy, nPileOrani, nPay, lMiktar, lBirimFiyat, lTutar, nIscilikMiktari, lIscilikUcreti, lToplamUcret, sNot, sTerzi, sKullaniciAdi, dteKayitTarihi, sSonKullaniciAdi, dteUpdateTarihi FROM tbPerdeTalepDetay WHERE (nDetay = 1) AND (nPerdeTalepID = " & dr_baslik("nPerdeTalepID") & ") ORDER BY nKayitID, nDetay,nDetayID"), "DETAY")
            report.RegisterData(ds_tbPerdeTalepDetaylar)
            report.RegisterData(ds_tbPerdeTalepToplam)
            report.RegisterData(ds_tbParamGenel)

            report.SetParameterValue("FisTipi", "PT")
            report.SetParameterValue("FisTipiAciklama", "PerdeTalep")
            report.SetParameterValue("FisTipiArabic", "تحصيلات")

            report.SetParameterValue("dteBordroTarihi", dr_baslik("dteTalepTarihi"))
            report.SetParameterValue("lBordroNo", dr_baslik("nPerdeTalepID"))
            report.ScriptLanguage = Language.Vb
            If nIslem = 0 Then
                report.Show()
            ElseIf nIslem = 1 Then
                report.Print()
            ElseIf nIslem = 2 Then
                report.Design()
            End If
            report.Dispose()
            report = Nothing
        End If
    End Sub
    Private Sub raporla1(ByVal rapor As Integer, ByVal islem As Integer)
        Dim file As String
        Dim kriter As String
        kriter = " WHERE BASLIK.IND > 0"
        OpenFileDialog1.Filter = "Rapor Dosyaları (*.fr3) |*.fr3"
        OpenFileDialog1.InitialDirectory = "c:\Formlar\Raporlar\FirmaBordro"
        OpenFileDialog1.FileName = "c:\Formlar\Raporlar\FirmaBordro\Form.fr3"
        If OpenFileDialog1.ShowDialog = Windows.Forms.DialogResult.OK Then
            file = OpenFileDialog1.FileName.ToString
            report_create_stok(file, kriter, islem)
        End If
        file = Nothing
        kriter = Nothing
    End Sub
    Private Sub report_create_stok(ByVal dosya As String, ByVal kriter As String, ByVal status As Integer)
        Dim stokno = 0
        Dim satir_line = "100"
        If IntPtr.Size = 4 Then
            '32 Bit
            Dim frx As New TfrxReportClass
            Dim qr_hareket As New TfrxADOQuery
            Dim qr_baslik As New TfrxADOQuery
            Dim qr_toplam As New TfrxADOQuery
            frx.Resources.LoadLanguageResourcesFromFile("C:\Program Files\FastReports\FastReport Studio\bin\turkish.frc")
            frx.LoadReportFromFile(dosya)
            frx.SetVariable("FIRMANO", "" & firmano & "")
            frx.SetVariable("DONEMNO", "" & donemno & "")
            frx.SetVariable("STOKNO", "" & stokno & "")
            frx.SetVariable("SATIRLINE", "'" & satir_line & "'")
            qr_hareket = frx.FindObject("qr_hareket")
            qr_hareket.Query = sSorgu_Hareket
            qr_baslik = frx.FindObject("qr_baslik")
            qr_baslik.Query = sSorgu_Baslik
            qr_toplam = frx.FindObject("qr_toplam")
            qr_toplam.Query = sSorgu_Toplam
            Dim qr_connection As New TfrxADODatabase
            qr_connection.ConnectionString = connection.ToString
            qr_connection.LoginPrompt = False
            qr_connection.CommandTimeout = Nothing
            qr_connection.Connected = True
            qr_baslik.DataBase = qr_connection
            qr_hareket.DataBase = qr_connection
            qr_toplam.DataBase = qr_connection
            If status = 0 Then
                frx.PrepareReport(True)
                frx.ShowReport()
            ElseIf status = 1 Then
                frx.PrepareReport(True)
                frx.PrintOptions.Collate = False
                frx.PrintOptions.Copies = 1
                frx.PrintReport()
            ElseIf status = 2 Then
                frx.PrepareReport(True)
                frx.DesignReport()
            ElseIf status = 3 Then
                frx.PrepareReport(True)
                frx.PrintOptions.Collate = False
                frx.PrintOptions.Copies = 1
                frx.PrintOptions.ShowDialog = False
                frx.PrintReport()
            End If
            qr_hareket = Nothing
            qr_connection = Nothing
        ElseIf IntPtr.Size = 8 Then
            '64 Bit
            Dim args(50) As String
            Dim processYol As String
            args(0) = "" & dosya & ""
            args(1) = "" & connection.ToString() & ""
            args(2) = "" & sSorgu_Hareket & "é" & sSorgu_Baslik & "é" & sSorgu_Toplam & ""
            args(3) = "qr_hareketéqr_baslikéqr_toplam"
            args(4) = "" & status.ToString() & ""
            args(5) = "4"
            args(6) = "FIRMANO"
            args(7) = "" & firmano.ToString() & ""
            args(8) = "DONEMNO"
            args(9) = "" & donemno.ToString() & ""
            args(10) = "STOKNO"
            args(11) = "" & stokno.ToString() & ""
            args(12) = "SATIRLINE"
            args(13) = "'" & satir_line.ToString() & "'"
            processYol = args(0)
            For i As Integer = 1 To 13
                processYol += "|" & args(i)
            Next
            Dim objReader As StreamWriter
            Dim yeniYol As String
            Dim Generator As System.Random = New System.Random()
            Try
                yeniYol = Directory.GetCurrentDirectory() & "\" & Generator.Next().ToString() & "_veriler.txt"
                objReader = New StreamWriter(yeniYol)
                objReader.Write(processYol)
                objReader.Close()
            Catch Ex As Exception
                MessageBox.Show("Raporlama İşlemi İçin LOG Oluşturulumadı!")
            End Try
            If File.Exists(Directory.GetCurrentDirectory() & "\RaporServis.exe") = True Then
                Dim sInfo As New ProcessStartInfo(Directory.GetCurrentDirectory() & "\RaporServis.exe ", """" & yeniYol & """")
                Process.Start(sInfo)
            Else
                MessageBox.Show("Lütfen 'RaporServis.exe' eklentisini uygulama dizinine kopyalayın.")
            End If
        End If
        stokno = Nothing
        satir_line = Nothing
    End Sub
    Private Sub degeryay(ByVal columnkriter As String, Optional ByVal bSatirDegistir As Boolean = True)
        Dim durum
        Dim sayi = GridView1.RowCount
        Dim satir = GridView1.FocusedRowHandle
        Dim TOPLAM = sayi - GridView1.FocusedRowHandle
        Dim İ As Integer
        Dim t As Int64 = 0
        İ = 0
        Dim dr As DataRow
        If columnkriter <> "SatirDegistir" Then
            dr = GridView1.GetDataRow(GridView1.FocusedRowHandle)
            durum = dr("" & columnkriter & "")
        End If
        For İ = 1 To TOPLAM
            t += 1
            If bSatirDegistir = True Then
                If columnkriter = "dteValorTarihi" Then
                    GridView1.PostEditor()
                    dr = GridView1.GetDataRow(GridView1.FocusedRowHandle)
                    If t > 1 Then
                        durum = DateAdd(DateInterval.Month, 1, durum)
                    Else
                        durum = durum
                    End If
                    dr("" & columnkriter & "") = durum
                    dr.EndEdit()
                Else
                    If columnkriter <> "SatirDegistir" Then
                        dr = GridView1.GetDataRow(GridView1.FocusedRowHandle)
                        dr.BeginEdit()
                        dr("" & columnkriter & "") = durum
                        dr.EndEdit()
                    End If
                End If
                tutar_hesapla()
                GridView1.FocusedRowHandle += 1
            End If
        Next
        GridView1.FocusedRowHandle = satir
        GridView1.GetDataRow(satir)
        durum = Nothing
        sayi = Nothing
        satir = Nothing
        İ = Nothing
    End Sub
    Private Sub tutar_hesapla(Optional ByVal nSatir As Int64 = -1)
        If GridView1.RowCount > 0 Then
            Dim dr As DataRow
            If XtraTabControl1.SelectedTabPageIndex = 1 Then
                If nSatir = -1 Then
                    dr = GridView2.GetDataRow(GridView2.FocusedRowHandle)
                Else
                    dr = GridView2.GetDataRow(nSatir)
                End If
            Else
                If nSatir = -1 Then
                    dr = GridView1.GetDataRow(GridView1.FocusedRowHandle)
                Else
                    dr = GridView1.GetDataRow(nSatir)
                End If
            End If

            If dr("nEn") = 0 Then
                dr("nEn") = 1
            End If
            If dr("nPileOrani") = 0 Then
                dr("nPileOrani") = 1
            End If
            If dr("nPay") < 0 Then
                dr("nPay") = 0
            End If
            If GridView1.FocusedColumn.Name.ToString = collMiktar.Name.ToString Then
                'dr("nEn") = dr("lMiktar") / dr("nPileOrani")
                dr("nPileOrani") = dr("lMiktar") / dr("nEn")
                'dr("lMiktar") = dr("nEn") * dr("nPileOrani")
            Else
                dr("lMiktar") = (dr("nEn") * dr("nPileOrani")) + dr("nPay")
            End If
            If GridView1.FocusedColumn.Name.ToString = collTutar.Name.ToString Then
                dr("lBirimFiyat") = dr("lTutar") / dr("lMiktar")
            Else
                dr("lTutar") = dr("lMiktar") * dr("lBirimFiyat")
            End If
            If dr("lIscilikUcreti") = 0 Then
                If dr("sTur") = "Perde" Then
                    dr("lIscilikUcreti") = 0.75
                    If dr("nIscilikMiktari") = 0 Then
                        dr("nIscilikMiktari") = dr("lMiktar")
                    End If
                ElseIf dr("sTur") = "Tul" Then
                    dr("lIscilikUcreti") = 15
                    If dr("nIscilikMiktari") = 0 Then
                        dr("nIscilikMiktari") = 1
                    End If
                ElseIf dr("sTur") = "Guneslik" Then
                    dr("lIscilikUcreti") = 0.75
                    If dr("nIscilikMiktari") = 0 Then
                        dr("nIscilikMiktari") = dr("lMiktar")
                    End If
                ElseIf dr("sTur") = "Fon" Then
                    dr("lIscilikUcreti") = 0.75
                    If dr("nIscilikMiktari") = 0 Then
                        dr("nIscilikMiktari") = dr("lMiktar")
                    End If
                ElseIf dr("sTur") = "Farbela" Then
                    dr("lIscilikUcreti") = 20
                    If dr("nIscilikMiktari") = 0 Then
                        dr("nIscilikMiktari") = 1
                    End If
                ElseIf dr("sTur") = "Sistem" Then
                    dr("lIscilikUcreti") = 20
                    If dr("nIscilikMiktari") = 0 Then
                        dr("nIscilikMiktari") = 1
                    End If
                End If
            End If
            If dr("sTur") = "Perde" Or dr("sTur") = "Guneslik" Or dr("sTur") = "Fon" Then
                dr("nIscilikMiktari") = dr("lMiktar")
            End If
            dr("lToplamUcret") = dr("nIscilikMiktari") * dr("lIscilikUcreti")
            tbPerdeTalepDetay_kaydet_duzelt(dr("nKayitID"), dr("nPerdeTalepID"), dr("sYer"), dr("sTur"), dr("sMagaza"), dr("sSaticiRumuzu"), dr("nDetay"), dr("nDetayID"), dr("nStokID"), dr("sKodu"), dr("sAciklama"), dr("nEn"), dr("nBoy"), dr("nPileOrani"), dr("nPay"), dr("lMiktar"), dr("lBirimFiyat"), dr("lTutar"), dr("nIscilikMiktari"), dr("lIscilikUcreti"), dr("lToplamUcret"), dr("sNot"), dr("sTerzi"), dr("sKullaniciAdi"), dr("dteKayitTarihi"), kullaniciadi, Now)
            Dataload_tbYekun(dr_baslik("nPerdeTalepID"))
        End If
    End Sub
    Private Sub satir_ekle(Optional ByVal bKopyala As Boolean = False)
        Dim dr As DataRow
        If bKopyala = False Then
            If XtraTabControl1.SelectedTabPageIndex = 1 And GridView1.RowCount > 0 Then
                dr = ds_tbPerdeTalepDetayDuzelt.Tables(0).NewRow
                dr("sYer") = "Boncuk"
                dr("nDetay") = 1
                Dim dr1 As DataRow = GridView1.GetDataRow(GridView1.FocusedRowHandle)
                dr("nDetayID") = dr1("nKayitID")
                dr("sTur") = dr1("sTur")
            Else
                dr = ds_tbPerdeTalepDetay.Tables(0).NewRow
                dr("sYer") = "Salon"
                dr("nDetay") = 0
                dr("nDetayID") = 0
                dr("sTur") = "Perde"
            End If
            dr("nPerdeTalepID") = dr_baslik("nPerdeTalepID")
            dr("sMagaza") = sDepo
            dr("sSaticiRumuzu") = ""
            dr("nStokID") = 0
            dr("sKodu") = ""
            dr("sAciklama") = ""
            dr("nEn") = 1
            dr("nBoy") = 1
            dr("nPileOrani") = 1
            dr("nPay") = 0
            dr("lMiktar") = 1
            dr("sFiyatTipi") = ""
            dr("lBirimFiyat") = 0
            dr("lTutar") = 0
            dr("nIscilikMiktari") = 0
            dr("lIscilikUcreti") = 0
            dr("lToplamUcret") = 0
            dr("sNot") = ""
            dr("sTerzi") = ""
            dr("sKullaniciAdi") = kullaniciadi
            dr("dteKayitTarihi") = Now
            dr("sSonKullaniciAdi") = kullaniciadi
            dr("dteUpdateTarihi") = Now
            dr("nKayitID") = tbPerdeTalepDetay_kaydet_yeni(dr("nPerdeTalepID"), dr("sYer"), dr("sTur"), dr("sMagaza"), dr("sSaticiRumuzu"), dr("nDetay"), dr("nDetayID"), dr("nStokID"), dr("sKodu"), dr("sAciklama"), dr("nEn"), dr("nBoy"), dr("nPileOrani"), dr("nPay"), dr("lMiktar"), dr("lBirimFiyat"), dr("lTutar"), dr("nIscilikMiktari"), dr("lIscilikUcreti"), dr("lToplamUcret"), dr("sNot"), dr("sTerzi"), dr("sKullaniciAdi"), dr("dteKayitTarihi"), dr("sSonKullaniciAdi"), dr("dteUpdateTarihi"))
        ElseIf bKopyala = True And GridView1.RowCount > 0 Then
            Dim dr1 As DataRow = GridView1.GetDataRow(GridView1.FocusedRowHandle)
            If XtraTabControl1.SelectedTabPageIndex = 1 And GridView1.RowCount > 0 Then
                dr = ds_tbPerdeTalepDetayDuzelt.Tables(0).NewRow
                dr1 = GridView2.GetDataRow(GridView2.FocusedRowHandle)
                dr("sYer") = dr1("sYer")
                dr("nDetay") = 1
                Dim dr2 As DataRow = GridView1.GetDataRow(GridView1.FocusedRowHandle)
                dr("nDetayID") = dr2("nKayitID")
                dr("sTur") = dr2("sTur")
            Else
                dr = ds_tbPerdeTalepDetay.Tables(0).NewRow
                dr1 = GridView1.GetDataRow(GridView1.FocusedRowHandle)
                dr("sYer") = dr1("sYer")
                dr("nDetay") = 0
                dr("nDetayID") = 0
                dr("sTur") = dr1("sTur")
            End If
            dr("nPerdeTalepID") = dr_baslik("nPerdeTalepID")
            dr("sMagaza") = dr1("sMagaza")
            dr("sSaticiRumuzu") = dr1("sSaticiRumuzu")
            dr("nStokID") = dr1("nStokID")
            dr("sKodu") = dr1("sKodu")
            dr("sAciklama") = dr1("sAciklama")
            dr("nEn") = dr1("nEn")
            dr("nBoy") = dr1("nBoy")
            dr("nPileOrani") = dr1("nPileOrani")
            dr("nPay") = dr1("nPay")
            dr("sFiyatTipi") = ""
            dr("lMiktar") = dr1("lMiktar")
            dr("lBirimFiyat") = dr1("lBirimFiyat")
            dr("lTutar") = dr1("lTutar")
            dr("nIscilikMiktari") = dr1("nIscilikMiktari")
            dr("lIscilikUcreti") = dr1("lIscilikUcreti")
            dr("lToplamUcret") = dr1("lToplamUcret")
            dr("sNot") = dr1("sNot")
            dr("sTerzi") = dr1("sTerzi")
            dr("sKullaniciAdi") = kullaniciadi
            dr("dteKayitTarihi") = Now
            dr("sSonKullaniciAdi") = kullaniciadi
            dr("dteUpdateTarihi") = Now
            dr("nKayitID") = tbPerdeTalepDetay_kaydet_yeni(dr("nPerdeTalepID"), dr("sYer"), dr("sTur"), dr("sMagaza"), dr("sSaticiRumuzu"), dr("nDetay"), dr("nDetayID"), dr("nStokID"), dr("sKodu"), dr("sAciklama"), dr("nEn"), dr("nBoy"), dr("nPileOrani"), dr("nPay"), dr("lMiktar"), dr("lBirimFiyat"), dr("lTutar"), dr("nIscilikMiktari"), dr("lIscilikUcreti"), dr("lToplamUcret"), dr("sNot"), dr("sTerzi"), dr("sKullaniciAdi"), dr("dteKayitTarihi"), dr("sSonKullaniciAdi"), dr("dteUpdateTarihi"))
        End If
        If XtraTabControl1.SelectedTabPageIndex = 1 And GridView1.RowCount > 0 Then
            ds_tbPerdeTalepDetayDuzelt.Tables(0).Rows.Add(dr)
            If GridView2.RowCount > 0 Then
                GridView2.ClearSelection()
                GridView2.SelectRow(GridView2.RowCount - 1)
                GridControl2.Focus()
            End If
        Else
            ds_tbPerdeTalepDetay.Tables(0).Rows.Add(dr)
            If GridView1.RowCount > 0 Then
                GridView1.ClearSelection()
                GridView1.SelectRow(GridView1.RowCount - 1)
                GridControl1.Focus()
            End If
        End If
        Dataload_tbYekun(dr_baslik("nPerdeTalepID"))
    End Sub
    Private Sub satir_sil()
        If GridView1.RowCount > 0 Then
            If XtraMessageBox.Show(Sorgu_sDil("Satırı Silmek İstediğinize Emin misiniz...?", sDil), Sorgu_sDil("Dikkat", sDil), MessageBoxButtons.YesNo, MessageBoxIcon.Question) = MsgBoxResult.Yes Then
                Dim dr As DataRow
                Dim bSatirSil As Boolean = True
                If XtraTabControl1.SelectedTabPageIndex = 1 Then
                    dr = GridView2.GetDataRow(GridView2.FocusedRowHandle)
                Else
                    dr = GridView1.GetDataRow(GridView1.FocusedRowHandle)
                End If
                If bSatirSil = True Then
                    tbPerdeTalepDetay_kaydet_sil(dr("nKayitID"))
                End If
                If XtraTabControl1.SelectedTabPageIndex = 1 Then
                    ds_tbPerdeTalepDetayDuzelt.Tables(0).Rows.Remove(dr)
                    GridControl2.Focus()
                    GridControl2.Select()
                    If GridView2.RowCount > 0 Then
                        GridView2.SelectRow(GridView2.FocusedRowHandle)
                    End If
                Else
                    ds_tbPerdeTalepDetay.Tables(0).Rows.Remove(dr)
                    GridControl1.Focus()
                    GridControl1.Select()
                    If GridView1.RowCount > 0 Then
                        GridView1.SelectRow(GridView1.FocusedRowHandle)
                    End If
                End If

                'GridView1.DeleteRow(GridView1.FocusedRowHandle)
                Dataload_tbYekun(dr_baslik("nPerdeTalepID"))
            End If
        End If
    End Sub

    Private Sub firma_sec(Optional ByVal islem As Integer = 0)
        Dim dr As DataRow
        dr = GridView1.GetDataRow(GridView1.FocusedRowHandle)
        Dim frm As New frm_musteri_liste
        frm.firmano = firmano
        frm.donemno = donemno
        frm.connection = connection
        frm.islemstatus = True
        frm.kullanici = kullanici
        If frm.ShowDialog(Me) = Windows.Forms.DialogResult.OK Then
            Dim dr1 As DataRow
            dr1 = frm.GridView1.GetDataRow(frm.GridView1.FocusedRowHandle)
            dr_baslik("nMusteriID") = dr1("nMusteriID")
            dr_baslik("lKodu") = dr1("lKodu")
            dr_baslik("sAdi") = dr1("sAdi")
            dr_baslik("sSoyadi") = dr1("sSoyadi")
            dr_baslik("sGSM") = dr1("sGSM")
            dr_baslik("sTelefon") = dr1("sEvTelefonu")
            dr_baslik("sEmail") = dr1("sEmail")
            dr_baslik("sAdres1") = dr1("sEvAdresi1")
            dr_baslik("sAdres2") = dr1("sEvAdresi2")
            dr1 = Nothing
            baslik_degistir()
        End If
    End Sub
    Private Sub stok_sec(Optional ByVal islem As Integer = 0)
        If GridView1.RowCount > 0 Then
            Dim dr As DataRow
            If XtraTabControl1.SelectedTabPageIndex = 1 Then
                dr = GridView2.GetDataRow(GridView2.FocusedRowHandle)
            Else
                dr = GridView1.GetDataRow(GridView1.FocusedRowHandle)
            End If
            Dim frm As New frm_stok
            frm.firmano = firmano
            frm.donemno = donemno
            frm.connection = connection
            frm.islemstatus = True
            frm.kullanici = kullanici
            If frm.ShowDialog(Me) = Windows.Forms.DialogResult.OK Then
                Dim dr1 As DataRow

                dr1 = frm.GridView1.GetDataRow(frm.GridView1.FocusedRowHandle)
                dr("nStokID") = dr1("nStokID")
                dr("sKodu") = dr1("sKodu")
                dr("sAciklama") = Trim(dr1("sAciklama").ToString)
                dr("lBirimFiyat") = sorgu_sayi(dr1("PESIN"), 0)
                tutar_hesapla()
            End If
        End If
    End Sub
    Private Sub GridView1_CellValueChanged(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs) Handles GridView1.CellValueChanged
        If GridView1.RowCount > 0 Then
            GridView1.PostEditor()
            Dim dr As DataRow
            dr = GridView1.GetDataRow(GridView1.FocusedRowHandle)
            dr.EndEdit()
            'Try
            tutar_hesapla()
            'Catch ex As Exception
            'End Try
        End If
    End Sub
    Private Sub GridView1_CustomDrawRowIndicator(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Grid.RowIndicatorCustomDrawEventArgs) Handles GridView1.CustomDrawRowIndicator
        If e.RowHandle >= 0 Then
            e.Info.DisplayText = e.RowHandle + 1
        Else
            e.Info.DisplayText = ""
        End If
    End Sub
    Private Sub GridView2_CellValueChanged(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs) Handles GridView2.CellValueChanged
        If GridView2.RowCount > 0 Then
            GridView2.PostEditor()
            Dim dr As DataRow
            dr = GridView2.GetDataRow(GridView2.FocusedRowHandle)
            dr.EndEdit()
            'Try
            tutar_hesapla()
            'Catch ex As Exception
            'End Try
        End If
    End Sub
    Private Sub GridView2_CustomDrawRowIndicator(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Grid.RowIndicatorCustomDrawEventArgs) Handles GridView2.CustomDrawRowIndicator
        If e.RowHandle >= 0 Then
            e.Info.DisplayText = e.RowHandle + 1
        Else
            e.Info.DisplayText = ""
        End If
    End Sub
    Private Sub BarButtonItem5_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem5.ItemClick
        If XtraMessageBox.Show(Sorgu_sDil("Talep Ekranından Çıkmak İstediğinize Emin misiniz...?", sDil), Sorgu_sDil("Dikkat", sDil), MessageBoxButtons.YesNo, MessageBoxIcon.Question) = MsgBoxResult.Yes Then
            Me.Close()
        End If
    End Sub
    Private Sub BarButtonItem8_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem8.ItemClick
        satir_sil()
    End Sub
    Private Sub BarButtonItem9_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem9.ItemClick
        If BarButtonItem9.Down = False Then
            GridView1.OptionsCustomization.AllowFilter = True
            GridView1.OptionsView.ShowFilterPanelMode = DevExpress.XtraGrid.Views.Base.ShowFilterPanelMode.Default
            GridView1.OptionsView.ShowAutoFilterRow = True
            BarButtonItem9.Down = True
        ElseIf BarButtonItem9.Down = True Then
            GridView1.OptionsCustomization.AllowFilter = False
            GridView1.OptionsView.ShowFilterPanelMode = DevExpress.XtraGrid.Views.Base.ShowFilterPanelMode.Never
            GridView1.OptionsView.ShowAutoFilterRow = False
            BarButtonItem9.Down = False
        End If
    End Sub
    Public Sub calc()
        Dim frm As New frm_calc
        If frm.ShowDialog = DialogResult.OK Then
            Dim dr As DataRow = GridView1.GetDataRow(GridView1.FocusedRowHandle)
            If GridView1.FocusedColumn.OptionsColumn.AllowEdit = True Then
                dr(GridView1.FocusedColumn().FieldName) = frm.CalcEdit1.EditValue
                tutar_hesapla()
            End If
        End If
        frm.Close()
        frm = Nothing
    End Sub
    Private Sub raporla_excel()
        If XtraMessageBox.Show(Sorgu_sDil("Sonuçları Excel Dosyası Oluşturmak İstediğinize Emin misiniz...?", sDil), Sorgu_sDil("Dikkat", sDil), MessageBoxButtons.YesNo, MessageBoxIcon.Question) = MsgBoxResult.Yes Then
            Dim SaveFileDialog1 As New Windows.Forms.SaveFileDialog
            SaveFileDialog1.Filter = "Excel Dosyaları(*.xls) |*.xls"
            SaveFileDialog1.InitialDirectory = "c:\"
            'SaveFileDialog1.FileName = Trim(dr_baslik("sFisTipi")) & "_" & dr_baslik("dteFisTarihi") & "_" & dr_baslik("lFisNo") & ".xls"
            SaveFileDialog1.FileName = Trim(dr_baslik("sFisTipi")) & "_" & dr_baslik("lBordroNo") & ".xls"
            If SaveFileDialog1.ShowDialog = Windows.Forms.DialogResult.OK Then
                GridView1.ExportToXls(SaveFileDialog1.FileName.ToString)
                If XtraMessageBox.Show(Sorgu_sDil("Kaydı Açmak İster misiniz...?", sDil), Sorgu_sDil("Dikkat", sDil), MessageBoxButtons.YesNo, MessageBoxIcon.Question) = MsgBoxResult.Yes Then
                    Process.Start(SaveFileDialog1.FileName.ToString)
                End If
            End If
            SaveFileDialog1 = Nothing
        End If
    End Sub
    Private Sub raporla_excel_csv()
        If XtraMessageBox.Show(Sorgu_sDil("Sonuçları Excel Csv Dosyası Oluşturmak İstediğinize Emin misiniz...?", sDil), Sorgu_sDil("Dikkat", sDil), MessageBoxButtons.YesNo, MessageBoxIcon.Question) = MsgBoxResult.Yes Then
            Dim SaveFileDialog1 As New Windows.Forms.SaveFileDialog
            SaveFileDialog1.Filter = "Excel Dosyaları(*.csv) |*.csv"
            SaveFileDialog1.InitialDirectory = "c:\"
            'SaveFileDialog1.FileName = Trim(dr_baslik("sFisTipi")) & "_" & dr_baslik("dteFisTarihi") & "_" & dr_baslik("lFisNo") & ".csv"
            SaveFileDialog1.FileName = Trim(dr_baslik("sFisTipi")) & "_" & dr_baslik("lBordroNo") & ".csv"
            If SaveFileDialog1.ShowDialog = Windows.Forms.DialogResult.OK Then
                'GridView1.ExportToExcelOld(SaveFileDialog1.FileName.ToString)
                printlink1.CreateDocument(ps)
                ps.ExportToCsv(SaveFileDialog1.FileName.ToString)
                'ps.PreviewRibbonFormEx.ShowDialog()
                If XtraMessageBox.Show(Sorgu_sDil("Kaydı Açmak İster misiniz...?", sDil), Sorgu_sDil("Dikkat", sDil), MessageBoxButtons.YesNo, MessageBoxIcon.Question) = MsgBoxResult.Yes Then
                    Process.Start(SaveFileDialog1.FileName.ToString)
                End If
            End If
            SaveFileDialog1 = Nothing
        End If
    End Sub
    Private Sub analiz_envanter()
        If GridView1.RowCount > 0 Then
            Dim dr As DataRow
            dr = GridView1.GetDataRow(GridView1.FocusedRowHandle)
            Dim frm As New frm_stok_envanter
            frm.firmano = firmano
            frm.donemno = donemno
            frm.connection = connection
            frm.stokno = dr("nStokID")
            frm.stokkodu = dr("sKodu")
            frm.kullanici = kullanici
            If yetki_kontrol(kullanici, frm.Name) = True Then
                frm.ShowDialog()
            End If
            frm.Close()
            frm.Dispose()
            frm = Nothing
        End If
    End Sub
    Private Sub analiz_stok_karti()
        If GridView1.RowCount > 0 Then
            Dim dr As DataRow
            dr = GridView1.GetDataRow(GridView1.FocusedRowHandle)
            Dim frm As New frm_stok_kart
            frm.firmano = firmano
            frm.donemno = donemno
            frm.connection = connection
            frm.nStokID = dr("nStokID")
            frm.sKodu = dr("sKodu")
            frm.sModel = dr("sKodu")
            frm.kullanici = kullanici
            If yetki_kontrol(kullanici, frm.Name) = True Then
                frm.ShowDialog()
            End If
            frm.Close()
            frm.Dispose()
            frm = Nothing
        End If
    End Sub

    Private Sub stok_fiyat()
        If GridView1.RowCount > 0 Then
            Dim dr As DataRow
            dr = GridView1.GetDataRow(GridView1.FocusedRowHandle)
            Dim frm As New frm_stok_fiyatlandir
            frm.firmano = firmano
            frm.donemno = donemno
            frm.connection = connection
            frm.nStokID = dr("nStokID")
            frm.sModel = dr("sKodu")
            frm.sKodu = dr("sKodu")
            'frm.sRenk = dr("sRenk")
            'frm.sBeden = dr("sBeden")
            frm.txt_musteriNo.Text = dr("sKodu")
            frm.kullanici = kullanici
            frm.nAST = 3
            If yetki_kontrol(kullanici, frm.Name) = True Then
                frm.ShowDialog()
            End If
            frm.Close()
            frm.Dispose()
            frm = Nothing
        End If
    End Sub
    Private Sub analiz_musteri_duzenle()
        If GridView1.RowCount > 0 Then
            Dim dr As DataRow = GridView1.GetDataRow(GridView1.FocusedRowHandle)
            Dim frm As New frm_musteri_kart
            frm.firmano = firmano
            frm.donemno = donemno
            frm.connection = connection
            frm.lKodu = dr_baslik("lKodu")
            frm.nMusteriID = dr_baslik("nMusteriID")
            frm.kullanici = kullanici
            If yetki_kontrol(kullanici, frm.Name) = True Then
                frm.ShowDialog()
                loaded()
            End If
            frm.Close()
            frm.Dispose()
            frm = Nothing
        End If
    End Sub
    Private Sub analiz_stok_hareket()
        If GridView1.RowCount > 0 Then
            Dim dr As DataRow = GridView1.GetDataRow(GridView1.FocusedRowHandle)
            Dim frm As New frm_stok_satis
            frm.firmano = firmano
            frm.donemno = donemno
            frm.connection = connection
            frm.nMusteriID = dr_baslik("nMusteriID")
            frm.nStokID = dr("nStokID")
            frm.kullanici = kullanici
            frm.islemstatus = True
            frm.DateEdit1.EditValue = "01/01/1900"
            frm.DateEdit2.EditValue = "31/12/2078"
            If frm.ShowDialog(Me) = Windows.Forms.DialogResult.OK Then

            End If
        End If
    End Sub
    Private Sub BarButtonItem6_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem6.ItemClick
        satir_ekle()
    End Sub
    Private Sub BarButtonItem21_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem21.ItemClick
        calc()
    End Sub
    Private Sub BarButtonItem1_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem1.ItemClick
        raporla(0)
    End Sub
    Private Sub BarButtonItem2_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem2.ItemClick
        raporla(2)
    End Sub
    Private Sub BarButtonItem3_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem3.ItemClick
        raporla(1)
    End Sub
    Private Sub BarButtonItem22_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem22.ItemClick
        gorunum_yazdir()
    End Sub
    Private Sub BarButtonItem23_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem23.ItemClick
        raporla_excel()
    End Sub
    Private Sub BarButtonItem20_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem20.ItemClick
        If Me.WindowState = FormWindowState.Normal Then
            Me.WindowState = FormWindowState.Maximized
        ElseIf Me.WindowState = FormWindowState.Maximized Then
            Me.WindowState = FormWindowState.Normal
        End If
    End Sub
    Private Sub VGrid_baslik_CellValueChanged(ByVal sender As Object, ByVal e As DevExpress.XtraVerticalGrid.Events.CellValueChangedEventArgs) Handles VGrid_baslik.CellValueChanged
        baslik_degistir()
    End Sub
    Private Sub baslik_degistir()
        Try
            'Vgrid_baslik.PostEditor()
            VGrid_baslik.UpdateFocusedRecord()
            VGrid_baslik.CloseEditor()
            'tbFirmaBordroMaster_kaydet_duzelt(dr_baslik("nBordroID"), dr_baslik("dteBordroTarihi"), dr_baslik("lBordroNo"), dr_baslik("sFisTipi"), dr_baslik("nGirisCikis"), dr_baslik("sSaticiRumuzu"), dr_baslik("nFirmaID"), dr_baslik("sAciklama1"), dr_baslik("sAciklama2"), dr_baslik("sAciklama3"), dr_baslik("sAciklama4"), dr_baslik("sAciklama5"), dr_baslik("sKullanici"), dr_baslik("dteKayitTarihi"), dr_baslik("bKilitli"), dr_baslik("sSubeMagaza"), dr_baslik("sHareketTipi"))
            tbPerdeTalepMaster_kaydet_duzelt(dr_baslik("nPerdeTalepID"), dr_baslik("dteTalepTarihi"), dr_baslik("nMusteriID"), dr_baslik("lKodu"), dr_baslik("sAdi"), dr_baslik("sSoyadi"), dr_baslik("sAdres1"), dr_baslik("sAdres2"), dr_baslik("sTelefon"), dr_baslik("sGSM"), dr_baslik("sEMail"), dr_baslik("sYetkili"), dr_baslik("sAciklama1"), dr_baslik("sAciklama2"), dr_baslik("sAciklama3"), dr_baslik("sAciklama4"), dr_baslik("sAciklama5"), dr_baslik("lToplamMiktar"), dr_baslik("lToplamMalBedeli"), dr_baslik("lOdenen"), dr_baslik("sSonuc"), dr_baslik("sKullaniciAdi"), dr_baslik("dteKayitTarihi"))
        Catch ex As Exception
        End Try
    End Sub
    Private Sub BarButtonItem15_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem15.ItemClick
        VGrid_baslik.RowsCustomization()
    End Sub
    Private Sub BarButtonItem16_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem16.ItemClick
        GridView1.ColumnsCustomization()
    End Sub
    Private Sub BarButtonItem17_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem17.ItemClick
        GridView2.ColumnsCustomization()
    End Sub
    Private Sub BarButtonItem18_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem18.ItemClick
        GridView3.ColumnsCustomization()
    End Sub
    Private Sub BarButtonItem19_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem19.ItemClick
        gorunum_kaydet()
    End Sub
    Private Sub GridView1_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles GridView1.KeyDown
        If e.KeyCode = Keys.Escape Then
            If XtraMessageBox.Show(Sorgu_sDil("Talep Ekranından Çıkmak İstediğinize Emin misiniz...?", sDil), Sorgu_sDil("Dikkat", sDil), MessageBoxButtons.YesNo, MessageBoxIcon.Question) = MsgBoxResult.Yes Then
                Me.Close()
            End If
        End If
    End Sub
    Private Sub BarButtonItem24_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem24.ItemClick
        firma_sec()
    End Sub
    Private Sub BarButtonItem25_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem25.ItemClick
        stok_sec()
    End Sub
    Private Sub GridView2_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles GridView2.KeyDown
        If e.KeyCode = Keys.Escape Then
            XtraTabControl1.SelectedTabPageIndex = 0
            GridControl1.Select()
        End If
    End Sub
    Private Sub BarButtonItem7_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem7.ItemClick
        satir_duzelt()
    End Sub
    Private Sub satir_duzelt()
        If XtraTabControl1.SelectedTabPageIndex = 0 Then
            dataload_hareket_detay()
        End If
    End Sub
    Private Sub BarButtonItem26_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem26.ItemClick
        If GridView1.RowCount > 0 Then
            If XtraMessageBox.Show(Sorgu_sDil("[" & GridView1.FocusedColumn().Caption & "] Kolonundaki verileri Aşağı Doğru Yaymak istediğinize Emin misiniz...?", sDil), Sorgu_sDil("Dikkat", sDil), MessageBoxButtons.YesNo, MessageBoxIcon.Question) = MsgBoxResult.Yes Then
                info = False
                Cursor.Current = Cursors.WaitCursor
                Cursor.Show()
                degeryay(GridView1.FocusedColumn().FieldName, True)
                Cursor.Current = Cursors.Default
                Cursor.Hide()
                info = True
            End If
        End If
    End Sub
    Private Sub XtraTabControl1_SelectedPageChanged(ByVal sender As Object, ByVal e As DevExpress.XtraTab.TabPageChangedEventArgs) Handles XtraTabControl1.SelectedPageChanged
        If XtraTabControl1.SelectedTabPageIndex = 1 Then
            dataload_hareket_detay()
            GridControl2.Select()
        ElseIf XtraTabControl1.SelectedTabPageIndex = 0 Then
            GridControl1.Select()
        End If
    End Sub
    Private Sub BarButtonItem27_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem27.ItemClick
        satir_ekle()
    End Sub
    Private Sub BarButtonItem28_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem28.ItemClick
        satir_duzelt()
    End Sub
    Private Sub BarButtonItem29_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem29.ItemClick
        satir_sil()
    End Sub
    Private Sub BarButtonItem30_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem30.ItemClick
        firma_sec()
    End Sub
    Private Sub BarButtonItem31_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem31.ItemClick
        stok_sec()
    End Sub
    Private Sub BarButtonItem4_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btn_FisSil.ItemClick
        fis_sil()
    End Sub
    Private Sub fis_sil()
        If XtraMessageBox.Show(Sorgu_sDil("Belgeyi İptal Etmek İstediğinize Emin misiniz...?", sDil), Sorgu_sDil("Dikkat", sDil), MessageBoxButtons.YesNo, MessageBoxIcon.Question) = MsgBoxResult.Yes Then
            tbPerdeTalepMaster_kaydet_Sil(dr_baslik("nPerdeTalepID"))
            'If Trim(dr_baslik("sFisTipi")) = "T" Then
            '    tbStokFisiMaster_kaydet_sil(dr_baslik("lTransferFisiID"), Trim(dr_baslik("sFisTipi")))
            'End If
            'Dim sFisNo = sorgu_lFisNo(dr_baslik("nFirmaID"), sFisTipi, nGirisCikis, sDepo, False)
            'If sFisNo = dr_baslik("lFisNo") + 1 Then
            '    sorgu_lFisNo(dr_baslik("nFirmaID"), sFisTipi, nGirisCikis, sDepo, True, "-")
            'End If
            bkapat = True
            Me.Close()
        End If
    End Sub
    Private Sub BarButtonItem11_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem11.ItemClick
        analiz_musteri_duzenle()
    End Sub
    Private Sub BarButtonItem10_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem10.ItemClick
        analiz_stok_karti()
    End Sub
    Private Sub BarButtonItem13_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem13.ItemClick
        analiz_envanter()
    End Sub
    Private Sub BarButtonItem14_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem14.ItemClick
        stok_fiyat()
    End Sub
    Private Sub BarButtonItem12_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem12.ItemClick
        analiz_stok_hareket()
    End Sub
    Private Sub BarButtonItem33_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem33.ItemClick
        satir_ekle(True)
    End Sub
    Private Sub sec_sFiyatTipi_EditValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles sec_sFiyatTipi.EditValueChanged
        If GridView1.RowCount > 0 Then
            Dim dr As DataRow
            GridView1.PostEditor()
            dr = GridView1.GetDataRow(GridView1.FocusedRowHandle)
            Dim lFiyat As Decimal = sorgu_stok_fiyat(dr("sFiyatTipi"), dr("nStokID"), "")
            If dr("sFiyatTipi") = sFiyatM Or dr("sFiyatTipi") = sFiyatA Then
                lFiyat = sorgu_sayi(lFiyat, 0)
            Else
                'If bFiyatKdvHaric = False Then
                '    lFiyat = lFiyat / ((100 + dr("nKdvOrani")) / 100)
                'Else
                lFiyat = sorgu_sayi(lFiyat, 0)
                'End If
            End If
            Dim lMiktar As Decimal = 1
            If lFiyat <> 0 Then
                'dr("sFiyatTipi") = frm.LookUpEdit1.EditValue
                'dr("lFiyat") = lFiyat
                'dr("lFiyat") = lFiyat * dr("lMiktar")
                dr("lBirimFiyat") = lFiyat
                lMiktar = dr("lMiktar")
                dr("lTutar") = lMiktar * dr("lBirimFiyat")
                tutar_hesapla()
                dr.EndEdit()
            End If
        End If
    End Sub
    Private Sub sFiyatTipi_toplu()
        Dim frm As New frm_tbKod
        frm.firmano = firmano
        frm.donemno = donemno
        frm.connection = connection
        frm.sText = "SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT     sFiyatTipi as sKod,sAciklama as sAciklama FROM         tbFiyatTipi where (aktif = 1) and (aktifDepo like '%" & Trim(sDepo) & "%')"
        frm.lbl_sKod.Text = "FiyatTipi:"
        If frm.ShowDialog() = Windows.Forms.DialogResult.OK Then
            If XtraMessageBox.Show(frm.LookUpEdit1.EditValue & Sorgu_sDil(" FiyatTipini Atamak İstediğinize Emin misiniz...?", sDil), Sorgu_sDil("Dikkat", sDil), MessageBoxButtons.YesNo, MessageBoxIcon.Question) = MsgBoxResult.Yes Then
                Dim sayi = 0
                Dim say As Integer = -1
                Dim Fiyat As Decimal = 0
                Dim lMiktar As Decimal = 0
                Dim dr As DataRow
                Dim lIskontoYuzdesi = 0
                Dim nMaxIskontoYuzdesi = 100
                Dim satir = GridView1.FocusedRowHandle
                For Each dr In ds_tbPerdeTalepDetay.Tables(0).Rows
                    say += 1
                    Fiyat = sorgu_stok_fiyat(frm.LookUpEdit1.EditValue, dr("nStokID"), "")
                    If frm.LookUpEdit1.EditValue = sFiyatM Or frm.LookUpEdit1.EditValue = sFiyatA Then
                        Fiyat = sorgu_sayi(Fiyat, 0)
                    Else
                        'If bFiyatKdvHaric = False Then
                        '    Fiyat = Fiyat / ((100 + dr("nKdvOrani")) / 100)
                        'Else
                        Fiyat = sorgu_sayi(Fiyat, 0)
                        'End If
                    End If
                    If Fiyat <> 0 Then
                        sayi += 1
                        dr("sFiyatTipi") = frm.LookUpEdit1.EditValue
                        dr("lBirimFiyat") = Fiyat
                        'dr("lFiyat") = Fiyat * dr("lBirimMiktar")
                        'If dr_baslik("nGirisCikis") = 1 Or dr_baslik("nGirisCikis") = 2 Then
                        '    lMiktar = dr("lGirisMiktar1")
                        'ElseIf dr_baslik("nGirisCikis") = 3 Or dr_baslik("nGirisCikis") = 4 Then
                        lMiktar = dr("lMiktar")
                        'End If
                        dr("lTutar") = lMiktar * dr("lBirimFiyat")
                        'dr("lDahilBrutFiyat") = Fiyat * ((dr("nKdvOrani") + 100) / 100)
                        'dr("lDahilFiyat") = dr("lDahilBrutFiyat")
                        'dr("lDahilBrutTutar") = dr("lDahilBrutFiyat") * lMiktar
                        'dr("lCikisFiyat") = dr("lBrutFiyat") / ((100 + dr("nKdvOrani")) / 100)
                        'dr("lCikisTutar") = dr("lBrutTutar") / ((100 + dr("nKdvOrani")) / 100)
                        'tbStokFisidetay_kaydet_degistir(dr("nIslemID"), dr("nStokID"), dr_baslik("dteFaturaTarihi"), dr("nFirmaID"), dr_baslik("nMusteriID"), dr_baslik("sFisTipi"), dr_baslik("dteFaturaTarihi"), dr("lFisNo"), dr("nGirisCikis"), dr("sDepo"), dr("lReyonFisNo"), dr("sStokIslem"), dr("sKasiyerRumuzu"), dr("sSaticiRumuzu"), dr("sOdemeKodu"), dr("dteIrsaliyeTarihi"), dr("lIrsaliyeNo"), dr("lGirisMiktar1"), dr("lGirisMiktar2"), dr("lGirisFiyat"), dr("lGirisTutar"), dr("lCikisMiktar1"), dr("lCikisMiktar2"), dr("lCikisFiyat"), dr("lCikisTutar"), dr("sFiyatTipi"), dr("lBrutFiyat"), dr("lBrutTutar"), dr("lMaliyetFiyat"), dr("lMaliyetTutar"), dr("lIlaveMaliyetTutar"), dr("nIskontoYuzdesi"), dr("lIskontoTutari"), dr("sDovizCinsi"), dr("lDovizFiyat"), dr("nSiparisID").ToString, dr("nReceteNo"), dr("nTransferID").ToString, dr("sTransferDepo").ToString, dr("nKdvOrani"), dr("nHesapID"), dr("sAciklama"), dr("sHareketTipi"), dr("bMuhasebeyeIslendimi"), dr("sKullaniciAdi"), dr("dteKayitTarihi"), dr("sDovizCinsi1"), dr("lDovizMiktari1"), dr("lDovizKuru1"), dr("sDovizCinsi2"), dr("lDovizMiktari2"), dr("lDovizKuru2"), dr("nOTVOrani"), dr("nTransferFirmaID").ToString, nAlisVerisID, 0, dr("nIrsaliyeFisiID").ToString, dr("sMasrafYontemi"), dr("sHangiUygulama"), dr("nEksaha1"), dr("nEkSaha2"), dr("bEkSoru1"), dr("bEkSoru2"), dr("sSonKullaniciAdi"), dr("dteSonUpdateTarihi"))
                        info = False
                        GridView1.FocusedRowHandle = say
                        tutar_hesapla()
                    End If
                Next
                info = True
                'İskonto Güncelle
                'If Trim("sFisTipi") = "K" Then
                '    dr_toplam("nDipIskontoYuzdesi") = lIskontoYuzdesi
                'ElseIf Trim("sFisTipi") = "P" Then
                '    dr_toplam("nDipIskontoYuzdesi") = lIskontoYuzdesi
                'End If
                'If dr_toplam("nDipIskontoYuzdesi") > nMaxIskontoYuzdesi Then
                '    dr_toplam("nDipIskontoYuzdesi") = nMaxIskontoYuzdesi
                'End If
                'toplam_hesapla()
                'tbStokFisiDetayi_DipIskonto_kaydet_duzelt(nAlisVerisID, dr_baslik("nGCT"), dr_toplam("nDipIskontoYuzdesi"), 0, 0, dr_toplam("lDipIskontoTutari"), dr_toplam("lMalBedeli"), dr_toplam("lMalIskontoTutari"), VGrid_toplam.FocusedRecordCellIndex.ToString)
                'Dim satir = GridView1.FocusedRowHandle
                dataload_harekets()
                GridView1.FocusedRowHandle = satir
                'toplam_hesapla()
                dr = Nothing
                sayi = Nothing
                If sayi > 0 Then
                    sFiyatTipi = frm.LookUpEdit1.EditValue
                End If
                XtraMessageBox.Show(Sorgu_sDil("İşlem Başarıyla Tamamlandı...", sDil), Sorgu_sDil("Dikkat", sDil), MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        End If
    End Sub
    Public Function sorgu_stok_fiyat(ByVal fiyattipi As String, ByVal stokno As Int64, ByVal sDovizCinsi As String) As Decimal
        Dim kriter
        kriter = "WHERE     (sFiyatTipi = '" & fiyattipi & "') AND (nStokID = " & stokno & ")"
        Dim con As New OleDb.OleDbConnection
        Dim cmd As New OleDb.OleDbCommand
        con.ConnectionString = connection
        cmd.Connection = con
        If con.State = ConnectionState.Closed Then
            con.Open()
        End If
        Dim lKur As Decimal = 1
        Dim sKur As String = "lAlisKuru"
        sDovizCinsi = sorgula_String("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED Select ISNULL(sDovizCinsi,'') from tbStok where nStokID = " & stokno & "")
        Dim dr As DataRow
        For Each dr In ds_tbFiyatTipi.Tables(0).Rows
            If Trim(dr("sFiyatTipi")) = Trim(fiyattipi) Then
                If Trim(dr("sDovizCinsi")) <> "" Then
                    sDovizCinsi = dr("sDovizCinsi")
                    If dr("sHangiKur") = "Alış" Then
                        sKur = "lAlisKuru"
                    ElseIf dr("sHangiKur") = "Satış" Then
                        sKur = "lSatisKuru"
                    ElseIf dr("sHangiKur") = "Efektif Alış" Then
                        sKur = "lEfektiAlisKuru"
                    ElseIf dr("sHangiKur") = "Efektif Satış" Then
                        sKur = "lEfektifSatisKuru"
                    ElseIf dr("sHangiKur") = "Merkez Bankası Alış" Then
                        sKur = "lMerkezBankasiAlisKuru"
                    ElseIf dr("sHangiKur") = "Merkez Bankası Satış" Then
                        sKur = "lMerkezBankasiSatisKuru"
                    Else
                        sKur = "lAlisKuru"
                    End If
                    lKur = sorgu_lDovizKuru(sDovizCinsi, sKur)
                End If
            End If
        Next
        If Trim(sDovizCinsi) <> "" Then
            lKur = sorgu_lDovizKuru(sDovizCinsi, sKur)
        End If
        cmd.CommandText = sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT     ISNULL(lFiyat * " & lKur & ", 0) AS FIYAT FROM         tbStokFiyati " & kriter & "")
        Dim kayitsayisi = cmd.ExecuteScalar
        Return kayitsayisi
        con.Dispose()
        cmd.Dispose()
        cmd = Nothing
    End Function
    Private Sub BarButtonItem34_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem34.ItemClick
        sFiyatTipi_toplu()
    End Sub
    Private Sub BarButtonItem35_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem35.ItemClick
        If dr_baslik("lKodu") = 0 Then
            tbMusteri_yeni()
        End If
    End Sub
    Private Sub tbMusteri_yeni()
        If KayitSiniri_kontrol("tbMusteri", "", nKayitSinir) = True Then
            Dim frm As New frm_musteri_kart_kisa
            frm.firmano = firmano
            frm.donemno = donemno
            frm.connection = connection
            frm.nMusteriID = 0
            frm.kullanici = kullanici
            frm.txt_sAdi.Text = dr_baslik("sAdi").ToString
            frm.txt_sSoyadi.Text = dr_baslik("sSoyadi").ToString
            frm.txt_sEvAdresi1.Text = dr_baslik("sAdres1").ToString
            frm.txt_sEvAdres2.Text = dr_baslik("sAdres2").ToString
            frm.txt_sEvTelefonu.Text = dr_baslik("sTelefon").ToString
            frm.txt_sGSM.Text = dr_baslik("sGSM").ToString
            frm.sMagaza = sDepo
            If yetki_kontrol(kullanici, frm.Name) = True Then
                If frm.ShowDialog = Windows.Forms.DialogResult.OK Then
                    dr_baslik("nMusteriID") = frm.nMusteriID
                    dr_baslik("lKodu") = frm.txt_musteriNo.Text
                    dr_baslik("sAdi") = frm.txt_sAdi.Text
                    dr_baslik("sSoyadi") = frm.txt_sSoyadi.Text
                    baslik_degistir()
                End If
            End If
        End If
    End Sub
    Private Sub Faturala(ByVal dteFisTarihi As DateTime, ByVal sFisTipi As String, ByVal sKasiyerRumuzu As String, ByVal nKasaNo As Integer, ByVal sMagaza As String)
        Dim nAlisVerisID As String = ""
        'Dim dteFisTarihi = dr_baslik("dteTalepTarihi")
        Dim lFaturaNo = 0
        Dim nMusteriID = 0
        Dim sAdi = dr_baslik("sAdi")
        Dim sSoyadi = dr_baslik("sSoyadi")
        '   Dim sMagaza = sDepo
        'Dim sKasiyerRumuzu = sKasiyerRumuzu
        'Dim sKasiyer = sKasiyer
        Dim sHareketTipi = ""
        '  Dim nKasaNo = 1
        Dim sAdres1 As String = dr_baslik("sAdres1")
        Dim sAdres2 As String = dr_baslik("sAdres2")
        nMusteriID = dr_baslik("nMusteriID") 'sorgu_nfirmaID(dr_baslik("lKodu"))
        If nAlisVerisID = "" Then
            nAlisVerisID = sorgu_nAlisVerisID(sMagaza)
            lFaturaNo = sorgu_lFaturaNo(sMagaza)
            sHareketTipi = sorgu_sHareketTipi(sMagaza)
            tbAlisVeris_kaydet_yeni(sMagaza & nAlisVerisID.ToString, sFisTipi, dteFisTarihi, 3, lFaturaNo, nMusteriID, sMagaza, sKasiyerRumuzu, sAdi, sSoyadi, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, "", 0, sHareketTipi, 0, nKasaNo, kullanici, Now, "")
            tbAvSirano_degistir(1, nAlisVerisID, sMagaza)
            lFaturaNo_degistir(lFaturaNo, sMagaza)
            nAlisVerisID = sMagaza & nAlisVerisID.ToString
            Dim kayitsayisi = sorgu_tbAlisVerisAdres_kontrol(nAlisVerisID)
            If kayitsayisi = 0 Then
                tbAlisVerisAdres_kaydet_yeni(nAlisVerisID, "", sAdres1, sAdres2, "", "", "Türkiye", "", "", "", "")
            Else
            End If
        End If
        Dim dr As DataRow
        Dim nSatir As Int64 = 0
        For Each dr In ds_tbPerdeTalepDetay.Tables(0).Rows
            Dim nStokID As Int64 = 0
            If dr("nStokID") = 0 Then
                Dim nSayi As Integer
                nSayi = sorgu_nStokID(dr("sKodu"))
                If nSayi = 0 Then
                    nStokID = tbStok_kaydet_yeni(dr("sKodu"), dr("sAciklama"), Microsoft.VisualBasic.Left(dr("sAciklama"), 16), 0, "", "", "", "", "", "", "", 0, "", 0, 0, 0, "", 0, dr("sKodu"), kullanici, Now, 1, "", 0, 0, "", 0, 0, 0, 0)
                    tbStokSinifi_kaydet_yeni(nStokID, "", "", "", "", "", "", "", "", "", "", "", "", "", "", "")
                    dr("nStokID") = nStokID
                Else
                    nStokID = nSayi
                End If
                dr("nStokID") = nStokID
                tutar_hesapla(nSatir)
            End If
            If dr("nStokID") <> 0 Then
                If Trim(sFisTipi) = "K" Or Trim(sFisTipi) = "P" Then
                    Dim nIslemID As Int64 = sorgu_nStokIslemID()
                    Dim sOdemeKodu As String = ""
                    If Trim(dr("sFiyatTipi")) = "6 AY" Then
                        sOdemeKodu = "6   "
                    ElseIf Trim(dr("sFiyatTipi")) = "10AY" Then
                        sOdemeKodu = "10  "
                    ElseIf Trim(dr("sFiyatTipi")) = "15AY" Then
                        sOdemeKodu = "15  "
                    ElseIf Trim(dr("sFiyatTipi")) = "PS" Then
                        sOdemeKodu = "0   "
                    ElseIf Trim(dr("sFiyatTipi")) = "HD" Then
                        sOdemeKodu = "0   "
                    End If
                    dr("sSaticiRumuzu") = sorgula_sSaticiRumuzu(dr("sSaticiRumuzu"))
                    nStokID = dr("nStokID")
                    nIslemID = tbStokFisidetay_kaydet_yeni(nIslemID, nStokID, dteFisTarihi, 0, nMusteriID, sFisTipi, dteFisTarihi, lFaturaNo, 3, sMagaza, 0, sFisTipi, sKasiyerRumuzu, dr("sSaticiRumuzu"), sOdemeKodu, dteFisTarihi, 0, 0, 0, 0, 0, dr("lGCMiktar"), 0, dr("lCikisFiyat"), dr("lCikisTutar"), dr("sFiyatTipi"), dr("lBrutFiyat"), dr("lBrutTutar"), 0, 0, 0, dr("nIskontoYuzdesiAV"), dr("lIskontoTutari"), "", 0, "", 0, "", "", dr("nKdvOrani"), 0, dr("sAciklama"), sHareketTipi, 0, kullanici, Now, "", 0, 0, "", 0, 0, 0, "", nAlisVerisID, 0, "", "", sFisTipi, 0, 0, 0, 0, kullanici, Now)
                    fis_detay_fisno_degistir(nIslemID)
                ElseIf Trim(sFisTipi) = "SK" Or Trim(sFisTipi) = "SP" Then
                    Dim nSiparisID As Int64 = sorgu_nSiparisID(sMagaza)
                    Dim sOdemeKodu As String = ""
                    If Trim(dr("sFiyatTipi")) = "6 AY" Then
                        sOdemeKodu = "6"
                    ElseIf Trim(dr("sFiyatTipi")) = "10AY" Then
                        sOdemeKodu = "10"
                    ElseIf Trim(dr("sFiyatTipi")) = "10AY" Then
                        sOdemeKodu = "15"
                    ElseIf Trim(dr("sFiyatTipi")) = "PS" Then
                        sOdemeKodu = "0"
                    ElseIf Trim(dr("sFiyatTipi")) = "HD" Then
                        sOdemeKodu = "0"
                    End If
                    dr("sSaticiRumuzu") = sorgula_sSaticiRumuzu(dr("sSaticiRumuzu"))
                    tbAlisVerisSiparis_kaydet_yeni(nAlisVerisID, sMagaza, nSiparisID, 3, dr("nStokID"), sKasiyerRumuzu, dr("sSaticiRumuzu"), sOdemeKodu, 0, dr("sFiyatTipi"), dr("lMiktar"), dr("lBirimFiyat"), dr("lTutar"), 0, 0, dr("lBirimFiyat"), dr("lTutar"), 0, "", 0, DateAdd(DateInterval.Day, 1, dteFisTarihi), "01/01/1900", 0, 0, dr("sNot").ToString, 0, 0, 0, "", 0, 0, kullanici, Now, "01/01/1900")
                    tbAvSirano_degistir(5, nSiparisID, sMagaza)
                End If
            End If
            nSatir = nSatir + 1
        Next
        dr_baslik("sAciklama5") = "Entegre: " & nAlisVerisID
        baslik_degistir()
        fatura_detay(nAlisVerisID, sFisTipi)
        'ara()
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
        conn.Close()
        Return kayitsayisi
    End Function
    Private Function tbStok_kaydet_yeni(ByVal sKodu As String, ByVal sAciklama As String, ByVal sKisaAdi As String, ByVal nStokTipi As Int64, ByVal sBedenTipi As String, ByVal sKavalaTipi As String, ByVal sRenk As String, ByVal sBeden As String, ByVal sKavala As String, ByVal sBirimCinsi1 As String, ByVal sBirimCinsi2 As String, ByVal nIskontoYuzdesi As Decimal, ByVal sKdvTipi As String, ByVal nTeminSuresi As Decimal, ByVal lAsgariMiktar As Decimal, ByVal lAzamiMiktar As Decimal, ByVal sOzelNot As String, ByVal nFiyatlandirma As Int64, ByVal sModel As String, ByVal sKullaniciAdi As String, ByVal dteKayitTarihi As DateTime, ByVal bEksiyeDusulebilirmi As Byte, ByVal sDefaultAsortiTipi As String, ByVal bEksideUyarsinmi As Byte, ByVal bOTVVar As Byte, ByVal sOTVTipi As String, ByVal nIskontoYuzdesiAV As Decimal, ByVal bEk1 As Byte, ByVal nEk2 As String, ByVal nAgirlik As Decimal) As Decimal
        Dim con As New OleDb.OleDbConnection
        Dim cmd As New OleDb.OleDbCommand
        cmd.Connection = con
        con.ConnectionString = connection
        If con.State = ConnectionState.Closed = True Then
            con.Open()
        End If
        cmd.CommandText = sorgu_query("SET DATEFORMAT DMY SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED INSERT INTO tbStok (sKodu, sAciklama, sKisaAdi, nStokTipi, sBedenTipi, sKavalaTipi, sRenk, sBeden, sKavala, sBirimCinsi1, sBirimCinsi2, nIskontoYuzdesi, sKdvTipi, nTeminSuresi, lAsgariMiktar, lAzamiMiktar, sOzelNot, nFiyatlandirma, sModel, sKullaniciAdi, dteKayitTarihi, bEksiyeDusulebilirmi, sDefaultAsortiTipi, bEksideUyarsinmi, bOTVVar, sOTVTipi, nIskontoYuzdesiAV, bEk1, nEk2,nAgirlik) VALUES     ('" & sKodu & "', N'" & sAciklama & "', '" & sKisaAdi & "', " & nStokTipi & ", '" & sBedenTipi & "', '" & sKavalaTipi & "', '" & sRenk & "', '" & sBeden & "', '" & sKavala & "', '" & sBirimCinsi1 & "', '" & sBirimCinsi1 & "', " & nIskontoYuzdesi & ", '" & sKdvTipi & "', " & nTeminSuresi & ", " & lAsgariMiktar & ", " & lAzamiMiktar & ", '" & sOzelNot & "', " & nFiyatlandirma & ", '" & sModel & "', '" & sKullaniciAdi & "', '" & dteKayitTarihi & "', " & bEksiyeDusulebilirmi & ", '" & sDefaultAsortiTipi & "', " & bEksideUyarsinmi & ", " & bOTVVar & ", '" & sOTVTipi & "', " & nIskontoYuzdesiAV & ", " & bEk1 & ", " & nEk2 & "," & nAgirlik & ")")
        cmd.ExecuteNonQuery()
        cmd.CommandText = "SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT @@identity"
        Dim kayitno = cmd.ExecuteScalar
        con.Close()
        Return kayitno
    End Function
    Private Sub tbStokSinifi_kaydet_yeni(ByVal nStokID As String, ByVal sSinifKodu1 As String, ByVal sSinifKodu2 As String, ByVal sSinifKodu3 As String, ByVal sSinifKodu4 As String, ByVal sSinifKodu5 As String, ByVal sSinifKodu6 As String, ByVal sSinifKodu7 As String, ByVal sSinifKodu8 As String, ByVal sSinifKodu9 As String, ByVal sSinifKodu10 As String, ByVal sSinifKodu11 As String, ByVal sSinifKodu12 As String, ByVal sSinifKodu13 As String, ByVal sSinifKodu14 As String, ByVal sSinifKodu15 As String)
        Dim con As New OleDb.OleDbConnection
        Dim cmd As New OleDb.OleDbCommand
        cmd.Connection = con
        con.ConnectionString = connection
        If con.State = ConnectionState.Closed = True Then
            con.Open()
        End If
        cmd.CommandText = sorgu_query("SET DATEFORMAT DMY SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED INSERT INTO tbStokSinifi (nStokID, sSinifKodu1, sSinifKodu2, sSinifKodu3, sSinifKodu4, sSinifKodu5, sSinifKodu6, sSinifKodu7, sSinifKodu8, sSinifKodu9, sSinifKodu10, sSinifKodu11, sSinifKodu12, sSinifKodu13, sSinifKodu14, sSinifKodu15) VALUES     (N'" & nStokID & "', N'" & sSinifKodu1 & "', N'" & sSinifKodu2 & "', N'" & sSinifKodu3 & "', N'" & sSinifKodu4 & "', N'" & sSinifKodu5 & "', N'" & sSinifKodu6 & "', N'" & sSinifKodu7 & "', N'" & sSinifKodu8 & "', N'" & sSinifKodu9 & "', N'" & sSinifKodu10 & "',  N'" & sSinifKodu11 & "', N'" & sSinifKodu12 & "', N'" & sSinifKodu13 & "', N'" & sSinifKodu14 & "', N'" & sSinifKodu15 & "')")
        cmd.ExecuteNonQuery()
        con.Close()
    End Sub
    Private Function sorgula_sSaticiRumuzu(ByVal Rumuz As String) As String
        Dim drs As DataRow
        Dim sSaticiRumuzu As String = "0"
        For Each drs In ds_Satici.Tables(0).Rows
            If Trim(Rumuz) = Trim(drs("KOD")) Then
                sSaticiRumuzu = Trim(drs("KOD"))
            End If
        Next
        Return sSaticiRumuzu
    End Function
    Private Sub fatura_detay(ByVal nAlisVerisID As String, ByVal sFisTipi As String)
        Dim frm As New frm_Perakende_Satis
        Dim dr As DataRow
        dr = GridView1.GetDataRow(GridView1.FocusedRowHandle)
        frm.status = True
        frm.firmano = 100
        frm.donemno = 1
        frm.connection = connection
        frm.islemstatus = True
        frm.aktarim = True
        frm.nAlisVerisID = nAlisVerisID
        frm.sFisTipi = Trim(sFisTipi.ToString)
        frm.kullanici = kullanici
        frm.bFisYenimi = True
        'If yetki_kontrol(kullanici, frm.Name) = True Then
        frm.ShowDialog()
        'End If
        dr = Nothing
    End Sub
    Public Function sorgu_nStokIslemID() As Int64
        Dim kriter As String = ""
        'kriter = "WHERE (sKodu = '" & kod & "')  "
        Dim conn As New OleDb.OleDbConnection
        Dim cmd As New OleDb.OleDbCommand
        Dim adapter As New OleDb.OleDbDataAdapter
        'MsgBox(connection_resmi)
        conn.ConnectionString = connection
        cmd.Connection = conn
        If conn.State = ConnectionState.Closed Then
            conn.Open()
        End If
        cmd.CommandText = sorgu_query("SET DATEFORMAT DMY SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT     TOP 1 ISNULL(nIslemID + 1, 0) AS nStokIslemID  FROM         tbStokFisiDetayi " & kriter & " ORDER BY nIslemID DESC")
        Dim kayitsayisi = cmd.ExecuteScalar
        Return kayitsayisi
        cmd = Nothing
        adapter = Nothing
    End Function
    Public Function sorgu_nSiparisID(ByVal sMagazaKodu As String) As Int64
        Dim kriter As String = ""
        'kriter = "WHERE (sKodu = '" & kod & "')  "
        Dim conn As New OleDb.OleDbConnection
        Dim cmd As New OleDb.OleDbCommand
        Dim adapter As New OleDb.OleDbDataAdapter
        'MsgBox(connection_resmi)
        conn.ConnectionString = connection
        cmd.Connection = conn
        If conn.State = ConnectionState.Closed Then
            conn.Open()
        End If
        cmd.CommandText = sorgu_query("SET DATEFORMAT DMY SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT     ISNULL(MAX(nSiparisID), 0) + 1 AS nSiparisID FROM         tbAlisverisSiparis Where sMagazaKodu ='" & sMagazaKodu & "'")
        Dim kayitsayisi = cmd.ExecuteScalar
        If kayitsayisi = 0 Then
            kayitsayisi = 1
        End If
        Return kayitsayisi
        cmd = Nothing
        adapter = Nothing
    End Function
    Public Function sorgu_nAlisVerisID(ByVal sDepo As String) As Int64
        'kriter = "WHERE (sKodu = '" & kod & "')  "
        Dim conn As New OleDb.OleDbConnection
        Dim cmd As New OleDb.OleDbCommand
        Dim adapter As New OleDb.OleDbDataAdapter
        'MsgBox(connection_resmi)
        conn.ConnectionString = connection
        cmd.Connection = conn
        If conn.State = ConnectionState.Closed Then
            conn.Open()
        End If
        'cmd.CommandText = sorgu_query("SET DATEFORMAT DMY SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT nSonID + 1 AS nSonID FROM tbAVSiraNo WHERE (sDepo = '" & sDepo & "') AND (nSiraIndex = 1)")
        cmd.CommandText = sorgu_query("SET DATEFORMAT DMY SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT     TOP 1 ISNULL(REPLACE(nAlisverisID, '" & sDepo & "', ''), 0) + 1 AS nSonID FROM         tbAlisVeris WHERE     (nAlisVerisID  like '" & sDepo & "%') ORDER BY CAST(ISNULL(REPLACE(nAlisverisID, '" & sDepo & "', ''), 0) AS DECIMAL) DESC")
        Dim kayitsayisi = cmd.ExecuteScalar
        Return kayitsayisi
        cmd = Nothing
        adapter = Nothing
    End Function
    Public Function sorgu_sHareketTipi(ByVal sDepo As String) As String
        Dim conn As New OleDb.OleDbConnection
        Dim cmd As New OleDb.OleDbCommand
        Dim adapter As New OleDb.OleDbDataAdapter
        conn.ConnectionString = connection
        cmd.Connection = conn
        If conn.State = ConnectionState.Closed Then
            conn.Open()
        End If
        cmd.CommandText = sorgu_query("SET DATEFORMAT DMY SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT     ISNULL(sDefaultHareketTipi,'') as sHareketTipi FROM         tbParamAlisVeris WHERE     (sMagazaKodu = '" & sDepo & "')")
        Dim kayitsayisi = cmd.ExecuteScalar
        Return kayitsayisi
        cmd = Nothing
        adapter = Nothing
    End Function
    Public Function sorgu_lFaturaNo(ByVal sDepo As String) As Int64
        Dim conn As New OleDb.OleDbConnection
        Dim cmd As New OleDb.OleDbCommand
        Dim adapter As New OleDb.OleDbDataAdapter
        conn.ConnectionString = connection
        cmd.Connection = conn
        If conn.State = ConnectionState.Closed Then
            conn.Open()
        End If
        cmd.CommandText = sorgu_query("SET DATEFORMAT DMY SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT     TOP 1 ISNULL(lFaturaNo, 0) + 1 AS nSonID FROM         tbAlisVeris WHERE     (sMagaza = '" & sDepo & "') AND (nGirisCikis = 3) AND (sFisTipi IN ('K', 'P')) ORDER BY lFaturaNo DESC")
        Dim kayitsayisi = cmd.ExecuteScalar
        Return kayitsayisi
        cmd = Nothing
        adapter = Nothing
    End Function
    Private Sub tbAvSirano_degistir(ByVal nSiraIndex As Integer, ByVal nSonID As Int64, ByVal sDepo As String)
        'kriter = "WHERE (sFisTipi = '" & sFistipi & "') and (dteFisTarihi = '" & dteFisTarihi & "') and (lFisNo = '" & lFisno & "') and (nFirmaID= '" & nFirmaID & "') and (nGirisCikis = '" & nGirisCikis & "')  "
        'sorgu(sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT     * FROM         tbFirmaHareketi " & kriter & ""))
        Dim conn As New OleDb.OleDbConnection
        Dim cmd As New OleDb.OleDbCommand
        Dim adapter As New OleDb.OleDbDataAdapter
        conn.ConnectionString = connection
        cmd.Connection = conn
        If conn.State = ConnectionState.Closed Then
            conn.Open()
        End If
        cmd.CommandText = sorgu_query("SET DATEFORMAT DMY SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED UPDATE    tbAvSiraNo SET              nSonID = '" & nSonID & "' where nSiraIndex = " & nSiraIndex & " and sDepo = '" & sDepo & "'")
        cmd.ExecuteNonQuery()
        conn.Close()
        cmd = Nothing
        adapter = Nothing
    End Sub
    Private Sub lFaturaNo_degistir(ByVal nSonID As Int64, ByVal sDepo As String)
        Dim conn As New OleDb.OleDbConnection
        Dim cmd As New OleDb.OleDbCommand
        Dim adapter As New OleDb.OleDbDataAdapter
        conn.ConnectionString = connection
        cmd.Connection = conn
        If conn.State = ConnectionState.Closed Then
            conn.Open()
        End If
        cmd.CommandText = sorgu_query("SET DATEFORMAT DMY SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED UPDATE    tbStokFisNolar SET              lPerakendeFatura1 ='" & nSonID & "' WHERE     (sDepo = '" & sDepo & "')")
        cmd.ExecuteNonQuery()
        conn.Close()
    End Sub
    Public Function sorgu_tbAlisVerisAdres_kontrol(ByVal nAlisVerisID As String) As Int64
        Dim kriter As String = ""
        kriter = "WHERE (nAlisVerisID = '" & nAlisVerisID & "')  "
        Dim conn As New OleDb.OleDbConnection
        Dim cmd As New OleDb.OleDbCommand
        Dim adapter As New OleDb.OleDbDataAdapter
        'MsgBox(connection_resmi)
        conn.ConnectionString = connection
        cmd.Connection = conn
        If conn.State = ConnectionState.Closed Then
            conn.Open()
        End If
        cmd.CommandText = sorgu_query("SET DATEFORMAT DMY SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT     ISNULL(COUNT(*), 0) AS KAYIT FROM         tbAlisVerisAdres " & kriter & "")
        Dim kayitsayisi = cmd.ExecuteScalar
        Return kayitsayisi
        cmd = Nothing
        adapter = Nothing
    End Function
    Private Sub tbAlisVeris_kaydet_yeni(ByVal nAlisverisID As String, ByVal sFisTipi As String, ByVal dteFaturaTarihi As DateTime, ByVal nGirisCikis As Int64, ByVal lFaturaNo As String, ByVal nMusteriID As Int64, ByVal sMagaza As String, ByVal sKasiyerRumuzu As String, ByVal sAlisverisYapanAdi As String, ByVal sAlisverisYapanSoyadi As String, ByVal lToplamMiktar As Decimal, ByVal lMalBedeli As Decimal, ByVal lMalIskontoTutari As Decimal, ByVal nDipIskontoYuzdesi As Decimal, ByVal lDipIskontoTutari As Decimal, ByVal nKdvOrani1 As Decimal, ByVal lKdvMatrahi1 As Decimal, ByVal lKdv1 As Decimal, ByVal nKdvOrani2 As Decimal, ByVal lKdvMatrahi2 As Decimal, ByVal lKdv2 As Decimal, ByVal nKdvOrani3 As Decimal, ByVal lKdvMatrahi3 As Decimal, ByVal lKdv3 As Decimal, ByVal nKdvOrani4 As Decimal, ByVal lKdvMatrahi4 As Decimal, ByVal lKdv4 As Decimal, ByVal nKdvOrani5 As Decimal, ByVal lKdvMatrahi5 As Decimal, ByVal lKdv5 As Decimal, ByVal lPesinat As Decimal, ByVal nVadeFarkiYuzdesi As Decimal, ByVal nVadeKdvOrani As Decimal, ByVal lVadeKdvMatrahi As Decimal, ByVal lVadeKdv As Decimal, ByVal lVadeFarki As Decimal, ByVal sOdemeKodu As String, ByVal lNetTutar As Decimal, ByVal sHareketTipi As String, ByVal bMuhasebeyeIslendimi As Integer, ByVal nKasaNo As Int64, ByVal sKullaniciAdi As String, ByVal dteKayitTarihi As DateTime, ByVal sYaziIle As String)
        Dim cmd As New OleDb.OleDbCommand
        Dim con As New OleDb.OleDbConnection
        cmd.Connection = con
        con.ConnectionString = connection
        If con.State = ConnectionState.Closed = True Then
            con.Open()
        End If
        cmd.CommandText = sorgu_query("SET DATEFORMAT DMY SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED INSERT INTO tbAlisVeris (nAlisverisID, sFisTipi, dteFaturaTarihi, nGirisCikis, lFaturaNo, nMusteriID, sMagaza, sKasiyerRumuzu, sAlisverisYapanAdi, sAlisverisYapanSoyadi, lToplamMiktar, lMalBedeli, lMalIskontoTutari, nDipIskontoYuzdesi, lDipIskontoTutari, nKdvOrani1, lKdvMatrahi1, lKdv1, nKdvOrani2, lKdvMatrahi2, lKdv2, nKdvOrani3, lKdvMatrahi3, lKdv3, nKdvOrani4, lKdvMatrahi4, lKdv4, nKdvOrani5, lKdvMatrahi5, lKdv5, lPesinat, nVadeFarkiYuzdesi, nVadeKdvOrani, lVadeKdvMatrahi, lVadeKdv, lVadeFarki, sOdemeKodu, lNetTutar, sHareketTipi, bMuhasebeyeIslendimi, nKasaNo, sKullaniciAdi, dteKayitTarihi, sYaziIle) VALUES     ('" & nAlisverisID & "', '" & sFisTipi & "', '" & dteFaturaTarihi & "', " & nGirisCikis & ", '" & lFaturaNo & "', " & nMusteriID & ", '" & sMagaza & "', '" & sKasiyerRumuzu & "', '" & sAlisverisYapanAdi & "', '" & sAlisverisYapanSoyadi & "', " & lToplamMiktar & ", " & lMalBedeli & ", " & lMalIskontoTutari & ", " & nDipIskontoYuzdesi & ", " & lDipIskontoTutari & ", " & nKdvOrani1 & ", " & lKdvMatrahi1 & ", " & lKdv1 & ", " & nKdvOrani2 & ", " & lKdvMatrahi2 & ", " & lKdv2 & ", " & nKdvOrani3 & ", " & lKdvMatrahi3 & ", " & lKdv3 & ", " & nKdvOrani4 & ", " & lKdvMatrahi4 & ", " & lKdv4 & ", " & nKdvOrani5 & ", " & lKdvMatrahi5 & ", " & lKdv5 & ", " & lPesinat & ", " & nVadeFarkiYuzdesi & ", " & nVadeKdvOrani & ", " & lVadeKdvMatrahi & ", " & lVadeKdv & ", " & lVadeFarki & ", '" & sOdemeKodu & "', " & lNetTutar & ", '" & sHareketTipi & "', " & bMuhasebeyeIslendimi & ", " & nKasaNo & ", '" & sKullaniciAdi & "',  '" & dteKayitTarihi & "', '" & sYaziIle & "')")
        cmd.ExecuteNonQuery()
        con.Close()
    End Sub
    Private Sub tbAlisVerisAdres_kaydet_yeni(ByVal nAlisVerisID As String, ByVal sAciklama As String, ByVal sAdres1 As String, ByVal sAdres2 As String, ByVal sSemt As String, ByVal sIl As String, ByVal sUlke As String, ByVal sPostaKodu As String, ByVal sVergiDairesi As String, ByVal sVergiNo As String, ByVal sSubeMagaza As String)
        Dim cmd As New OleDb.OleDbCommand
        Dim con As New OleDb.OleDbConnection
        cmd.Connection = con
        con.ConnectionString = connection
        If con.State = ConnectionState.Closed = True Then
            con.Open()
        End If
        cmd.CommandText = sorgu_query("SET DATEFORMAT DMY SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED INSERT INTO tbAlisVerisAdres (nAlisVerisID, sAciklama, sAdres1, sAdres2, sSemt, sIl, sUlke, sPostaKodu, sVergiDairesi, sVergiNo, sSubeMagaza) VALUES     ('" & nAlisVerisID & "', N'" & sAciklama & "', '" & sAdres1 & "', '" & sAdres2 & "', '" & sSemt & "', '" & sIl & "', '" & sUlke & "', '" & sPostaKodu & "', '" & sVergiDairesi & "', '" & sVergiNo & "', '" & sSubeMagaza & "')")
        cmd.ExecuteNonQuery()
        con.Close()
    End Sub
    Private Function tbStokFisidetay_kaydet_yeni(ByVal nIslemID As Int64, ByVal nStokID As Int64, ByVal dteIslemTarihi As DateTime, ByVal nFirmaID As Int64, ByVal nMusteriID As Int64, ByVal sFisTipi As String, ByVal dteFisTarihi As DateTime, ByVal lFisNo As String, ByVal nGirisCikis As Int64, ByVal sDepo As String, ByVal lReyonFisNo As String, ByVal sStokIslem As String, ByVal sKasiyerRumuzu As String, ByVal sSaticiRumuzu As String, ByVal sOdemeKodu As String, ByVal dteIrsaliyeTarihi As DateTime, ByVal lIrsaliyeNo As String, ByVal lGirisMiktar1 As Decimal, ByVal lGirisMiktar2 As Decimal, ByVal lGirisFiyat As Decimal, ByVal lGirisTutar As Decimal, ByVal lCikisMiktar1 As Decimal, ByVal lCikisMiktar2 As Decimal, ByVal lCikisFiyat As Decimal, ByVal lCikisTutar As Decimal, ByVal sFiyatTipi As String, ByVal lBrutFiyat As Decimal, ByVal lBrutTutar As Decimal, ByVal lMaliyetFiyat As Decimal, ByVal lMaliyetTutar As Decimal, ByVal lIlaveMaliyetTutar As Decimal, ByVal nIskontoYuzdesi As Decimal, ByVal lIskontoTutari As Decimal, ByVal sDovizCinsi As String, ByVal lDovizFiyat As Decimal, ByVal nSiparisID As String, ByVal nReceteNo As String, ByVal nTransferID As String, ByVal sTransferDepo As String, ByVal nKdvOrani As Decimal, ByVal nHesapID As Int64, ByVal sAciklama As String, ByVal sHareketTipi As String, ByVal bMuhasebeyeIslendimi As Byte, ByVal sKullaniciAdi As String, ByVal dteKayitTarihi As DateTime, ByVal sDovizCinsi1 As String, ByVal lDovizMiktari1 As Decimal, ByVal lDovizKuru1 As Decimal, ByVal sDovizCinsi2 As String, ByVal lDovizMiktari2 As Decimal, ByVal lDovizKuru2 As Decimal, ByVal nOTVOrani As Decimal, ByVal nTransferFirmaID As String, ByVal nAlisverisID As String, ByVal nStokFisiID As Int64, ByVal nIrsaliyeFisiID As String, ByVal sMasrafYontemi As String, ByVal sHangiUygulama As String, ByVal nEkSaha1 As Int64, ByVal nEkSaha2 As Int64, ByVal bEkSoru1 As Int64, ByVal bEkSoru2 As Int64, ByVal sSonKullaniciAdi As String, ByVal dteSonUpdateTarihi As DateTime) As Int64
        Dim cmd As New OleDb.OleDbCommand
        Dim con As New OleDb.OleDbConnection
        cmd.Connection = con
        con.ConnectionString = connection
        If con.State = ConnectionState.Closed = True Then
            con.Open()
        End If
        cmd.CommandText = sorgu_query("SET DATEFORMAT DMY SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED INSERT INTO tbStokFisiDetayi                       (nStokID, dteIslemTarihi, nFirmaID, nMusteriID, sFisTipi, dteFisTarihi, lFisNo, nGirisCikis, sDepo, lReyonFisNo, sStokIslem, sKasiyerRumuzu, sSaticiRumuzu, sOdemeKodu, dteIrsaliyeTarihi, lIrsaliyeNo, lGirisMiktar1, lGirisMiktar2, lGirisFiyat, lGirisTutar, lCikisMiktar1, lCikisMiktar2, lCikisFiyat, lCikisTutar, sFiyatTipi, lBrutFiyat, lBrutTutar, lMaliyetFiyat, lMaliyetTutar, lIlaveMaliyetTutar, nIskontoYuzdesi, lIskontoTutari, sDovizCinsi, lDovizFiyat, nSiparisID, nReceteNo, nTransferID, sTransferDepo, nKdvOrani, nHesapID, sAciklama, sHareketTipi, bMuhasebeyeIslendimi, sKullaniciAdi, dteKayitTarihi, sDovizCinsi1, lDovizMiktari1, lDovizKuru1, sDovizCinsi2, lDovizMiktari2, lDovizKuru2, nOTVOrani, nTransferFirmaID, nAlisverisID, nStokFisiID, nIrsaliyeFisiID, sMasrafYontemi, sHangiUygulama, nEkSaha1, nEkSaha2, bEkSoru1, bEkSoru2, sSonKullaniciAdi, dteSonUpdateTarihi) VALUES     ('" & nStokID & "', '" & dteIslemTarihi & "', '" & nFirmaID & "', '" & nMusteriID & "', '" & sFisTipi & "', '" & dteFisTarihi & "', '" & lFisNo & "', " & nGirisCikis & ", '" & sDepo & "', '" & lReyonFisNo & "', '" & sStokIslem & "', '" & sKasiyerRumuzu & "', '" & sSaticiRumuzu & "', '" & sOdemeKodu & "', '" & dteIrsaliyeTarihi & "', '" & lIrsaliyeNo & "', " & lGirisMiktar1 & ", " & lGirisMiktar2 & ", " & lGirisFiyat & ", " & lGirisTutar & ", " & lCikisMiktar1 & ", " & lCikisMiktar2 & " , " & lCikisFiyat & ", " & lCikisTutar & " , '" & sFiyatTipi & "' , " & lBrutFiyat & ", " & lBrutTutar & " , " & lMaliyetFiyat & ", " & lMaliyetTutar & ", " & lIlaveMaliyetTutar & ", " & nIskontoYuzdesi & ", " & lIskontoTutari & ", '" & sDovizCinsi & "', " & lDovizFiyat & ", NULL, '" & nReceteNo & "', NULL, NULL, " & nKdvOrani & ", '" & nHesapID & "', N'" & sAciklama & "', '" & sHareketTipi & "'," & bMuhasebeyeIslendimi & ", '" & sKullaniciAdi & "', '" & dteKayitTarihi & "', '" & sDovizCinsi1 & "', " & lDovizMiktari1 & ", " & lDovizKuru1 & ", '" & sDovizCinsi2 & "', " & lDovizMiktari2 & " , " & lDovizKuru2 & ", " & nOTVOrani & ", NULL,  '" & nAlisverisID & "', NULL, NULL, '" & sMasrafYontemi & "', '" & sHangiUygulama & "', " & nEkSaha1 & ", " & nEkSaha2 & ", " & bEkSoru1 & " , " & bEkSoru2 & ", '" & sSonKullaniciAdi & "', '" & dteSonUpdateTarihi & "')")
        cmd.ExecuteNonQuery()
        cmd.CommandText = "SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT @@identity"
        nIslemID = cmd.ExecuteScalar
        Return nIslemID
        con.Close()
    End Function
    Private Sub tbAlisVerisSiparis_kaydet_yeni(ByVal nAlisverisID As String, ByVal sMagazaKodu As String, ByVal nSiparisID As Int64, ByVal nGirisCikis As Int64, ByVal nStokID As Int64, ByVal sKasiyerRumuzu As String, ByVal sSaticiRumuzu As String, ByVal sOdemeKodu As String, ByVal lReyonFisNo As Int64, ByVal sFiyatTipi As String, ByVal lGCMiktar As Decimal, ByVal lBrutFiyat As Decimal, ByVal lBrutTutar As Decimal, ByVal nIskontoYuzdesi As Decimal, ByVal lIskontoTutari As Decimal, ByVal lFiyat As Decimal, ByVal lTutar As Decimal, ByVal nKdvOrani As Decimal, ByVal sIadeNedeni As String, ByVal nPartiID As Int64, ByVal dteTeslimEdilecek As DateTime, ByVal dteTeslimEdilen As DateTime, ByVal bTeslimEdildi As Byte, ByVal bMuhasebeyeIslendimi As Byte, ByVal sAciklama As String, ByVal bEkSoru As Byte, ByVal bEkAlan1 As Byte, ByVal bEkAlan2 As String, ByVal sDovizCinsi1 As String, ByVal lDovizMiktari1 As Decimal, ByVal lDovizKuru1 As Decimal, ByVal sSonKullaniciAdi As String, ByVal dteSonUpdateTarihi As DateTime, ByVal dteOnayTarihi As DateTime)
        Dim cmd As New OleDb.OleDbCommand
        Dim con As New OleDb.OleDbConnection
        cmd.Connection = con
        con.ConnectionString = connection
        If con.State = ConnectionState.Closed = True Then
            con.Open()
        End If
        cmd.CommandText = sorgu_query("SET DATEFORMAT DMY SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED INSERT INTO tbAlisverisSiparis (nAlisverisID, sMagazaKodu, nSiparisID, nGirisCikis, nStokID, sKasiyerRumuzu, sSaticiRumuzu, sOdemeKodu, lReyonFisNo, sFiyatTipi, lGCMiktar, lBrutFiyat, lBrutTutar, nIskontoYuzdesi, lIskontoTutari, lFiyat, lTutar, nKdvOrani, sIadeNedeni, nPartiID, dteTeslimEdilecek, dteTeslimEdilen, bTeslimEdildi, bMuhasebeyeIslendimi, sAciklama, bEkSoru, bEkAlan1, bEkAlan2, sDovizCinsi1, lDovizMiktari1, lDovizKuru1, sSonKullaniciAdi, dteSonUpdateTarihi, dteOnayTarihi) VALUES     ('" & nAlisverisID & "', '" & sMagazaKodu & "', " & nSiparisID & ", " & nGirisCikis & ", " & nStokID & ", '" & sKasiyerRumuzu & "', '" & sSaticiRumuzu & "', '" & sOdemeKodu & "', " & lReyonFisNo & ", '" & sFiyatTipi & "', " & lGCMiktar & ", " & lBrutFiyat & ", " & lBrutTutar & ", " & nIskontoYuzdesi & ", " & lIskontoTutari & ", " & lFiyat & ", " & lTutar & ", " & nKdvOrani & ", '" & sIadeNedeni & "', " & nPartiID & ", '" & dteTeslimEdilecek & "', '" & dteTeslimEdilen & "', " & bTeslimEdildi & ", " & bMuhasebeyeIslendimi & ", N'" & sAciklama & "', " & bEkSoru & ", " & bEkAlan1 & ", '" & bEkAlan2 & "', '" & sDovizCinsi1 & "', " & lDovizMiktari1 & ", " & lDovizKuru1 & ", '" & sSonKullaniciAdi & "', '" & dteSonUpdateTarihi & "', '" & dteOnayTarihi & "') ")
        cmd.ExecuteNonQuery()
        con.Close()
        cmd = Nothing
        con = Nothing
    End Sub
    Private Sub fis_detay_fisno_degistir(ByVal nstokIslemID As String)
        'kriter = "WHERE (sFisTipi = '" & sFistipi & "') and (dteFisTarihi = '" & dteFisTarihi & "') and (lFisNo = '" & lFisno & "') and (nFirmaID= '" & nFirmaID & "') and (nGirisCikis = '" & nGirisCikis & "')  "
        'sorgu(sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT     * FROM         tbFirmaHareketi " & kriter & ""))
        Dim conn As New OleDb.OleDbConnection
        Dim cmd As New OleDb.OleDbCommand
        Dim adapter As New OleDb.OleDbDataAdapter
        conn.ConnectionString = connection
        cmd.Connection = conn
        If conn.State = ConnectionState.Closed Then
            conn.Open()
        End If
        cmd.CommandText = sorgu_query("SET DATEFORMAT DMY SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED UPDATE    tbStokSiraNo SET              nSonID = '" & nstokIslemID & "' where nSiraIndex = 1")
        cmd.ExecuteNonQuery()
        conn.Close()
    End Sub
    Private Sub sSaticiRumuzu_toplu()
        Dim frm As New frm_tbKod
        frm.firmano = firmano
        frm.donemno = donemno
        frm.connection = connection
        frm.sText = "SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT     sSaticiRumuzu as sKod,sAdi as sAciklama FROM         tbSatici where bAktif =1"
        frm.lbl_sKod.Text = "Satici:"
        If frm.ShowDialog() = Windows.Forms.DialogResult.OK Then
            If XtraMessageBox.Show(frm.LookUpEdit1.EditValue & Sorgu_sDil(" Kodunu Satıcılara Atamak İstediğinize Emin misiniz...?", sDil), Sorgu_sDil("Dikkat", sDil), MessageBoxButtons.YesNo, MessageBoxIcon.Question) = MsgBoxResult.Yes Then
                Dim sayi = 0
                Dim dr As DataRow
                For Each dr In ds_tbPerdeTalepDetay.Tables(0).Rows
                    dr("sSaticiRumuzu") = frm.LookUpEdit1.EditValue
                    'dr("nPrim") = sSaticiRumuzu_nPrim(dr("sSaticiRumuzu"))
                    'dr("lPrimTutari") = (dr("lCikisTutar") * (dr("nPrim") / 100))
                    'If Trim(dr_baslik("sFisTipi")) = "SK" Or Trim(dr_baslik("sFisTipi")) = "SP" Then
                    '    tbAlisVerisSiparis_kaydet_duzelt(dr("nAlisVerisID"), dr("sMagazaKodu"), dr("nSiparisID"), dr("nGirisCikis"), dr("nStokID"), dr("sKasiyerRumuzu"), dr("sSaticiRumuzu"), dr("sOdemeKodu"), dr("lReyonFisNo"), dr("sFiyatTipi"), dr("lCikisMiktar1"), dr("lBrutFiyat"), dr("lBrutTutar"), dr("nIskontoYuzdesi"), dr("lIskontoTutari"), dr("lCikisFiyat"), dr("lCikisTutar"), dr("nKdvOrani"), dr("sIadeNedeni").ToString, dr("nPartiID"), dr("dteTeslimEdilecek"), dr("dteTeslimEdilen"), dr("bTeslimEdildi"), dr("bMuhasebeyeIslendimi"), dr("sAciklama").ToString, dr("bEkSoru"), dr("bEkAlan1"), dr("bEkAlan2"), dr("sDovizCinsi1"), dr("lDovizMiktari1"), dr("lDovizKuru1"), kullanici, Now, dr("dteOnayTarihi"), dr("nPrim"), dr("lPrimTutari"))
                    'Else
                    '    tbStokFisidetay_kaydet_degistir(dr("nIslemID"), dr("nStokID"), dr_baslik("dteFaturaTarihi"), dr("nFirmaID"), dr_baslik("nMusteriID"), dr_baslik("sFisTipi"), dr_baslik("dteFaturaTarihi"), dr("lFisNo"), dr("nGirisCikis"), dr("sDepo"), dr("lReyonFisNo"), dr("sStokIslem"), dr("sKasiyerRumuzu"), dr("sSaticiRumuzu"), dr("sOdemeKodu"), dr("dteIrsaliyeTarihi"), dr("lIrsaliyeNo"), dr("lGirisMiktar1"), dr("lGirisMiktar2"), dr("lGirisFiyat"), dr("lGirisTutar"), dr("lCikisMiktar1"), dr("lCikisMiktar2"), dr("lCikisFiyat"), dr("lCikisTutar"), dr("sFiyatTipi"), dr("lBrutFiyat"), dr("lBrutTutar"), dr("lMaliyetFiyat"), dr("lMaliyetTutar"), dr("lIlaveMaliyetTutar"), dr("nIskontoYuzdesi"), dr("lIskontoTutari"), dr("sDovizCinsi"), dr("lDovizFiyat"), dr("nSiparisID").ToString, dr("nReceteNo"), dr("nTransferID").ToString, dr("sTransferDepo").ToString, dr("nKdvOrani"), dr("nHesapID"), dr("sAciklama"), dr("sHareketTipi"), dr("bMuhasebeyeIslendimi"), dr("sKullaniciAdi"), dr("dteKayitTarihi"), dr("sDovizCinsi1"), dr("lDovizMiktari1"), dr("lDovizKuru1"), dr("sDovizCinsi2"), dr("lDovizMiktari2"), dr("lDovizKuru2"), dr("nOTVOrani"), dr("nTransferFirmaID").ToString, nAlisVerisID, 0, dr("nIrsaliyeFisiID").ToString, dr("sMasrafYontemi"), dr("sHangiUygulama"), dr("nEksaha1"), dr("nEkSaha2"), dr("bEkSoru1"), dr("bEkSoru2"), dr("sSonKullaniciAdi"), dr("dteSonUpdateTarihi"), dr("nPrim"), dr("lPrimTutari"))
                    'End If
                    tutar_hesapla(sayi)
                    sayi += 1
                Next
                dr = Nothing
                XtraMessageBox.Show(Sorgu_sDil("Tamamlandı", sDil), Sorgu_sDil("Dikkat", sDil), MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        End If
    End Sub
    Private Sub BarButtonItem36_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem36.ItemClick
        Dim fr As New frm_tbKasiyerSec
        fr.firmano = firmano
        fr.donemno = donemno
        fr.connection = connection
        fr.kullanici = kullanici
        If fr.ShowDialog(Me) = Windows.Forms.DialogResult.OK Then
            If XtraMessageBox.Show(Sorgu_sDil("Sipariş Entegrasyonu İşlemine Başlamak İstediğinize Emin misiniz...?", sDil), Sorgu_sDil("Dikkat", sDil), MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
                Faturala(fr.DateEdit1.EditValue, "SK", fr.sKasiyerRumuzu, fr.sec_kasa.EditValue, fr.sec_magaza.EditValue)
            End If
        End If
    End Sub
    Private Sub BarButtonItem4_ItemClick_1(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem4.ItemClick
        sSaticiRumuzu_toplu()
    End Sub
End Class