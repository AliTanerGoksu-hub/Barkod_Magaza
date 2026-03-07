Imports System.Xml
Imports FastReport
Imports DevExpress.XtraGrid
Imports DevExpress.XtraEditors
Imports DevExpress.XtraGrid.Columns
Imports Microsoft.Win32
Public Class frm_Market_KasaTeslimat 
    Public firmano As Integer = 100
    Public donemno As Integer = 1
    Public connection As String = ""
    Public kullanici As String = ""
    Dim ds_tbDepo As DataSet
    Dim ds_tbKasiyer As DataSet
    Dim ds_tbParekendeKasa As DataSet
    Dim ds_tbMarketKasaTeslimat As DataSet
    Dim ds_tbMarketKasaTeslimatDetay As DataSet
    Dim ds_OdemeSekli As DataSet
    Dim ds_SubeMagaza As DataSet
    Dim nTeslimatID As Int64 = 0
    Dim sIslem As String = "Ekle"
    Dim bLoad As Boolean = False
    Dim nakit As Decimal = 0
    Dim masraf As Decimal = 0
    Public pos As Boolean = False
    Public nPosIslem As Integer = 0
    Dim nOdemeTipi As Int64 = 0
    Dim nBankaFirmaID As Int64 = 0
    Dim nKesintiFirmaID As Int64 = 0
    Dim nKesintiHesapID As Int64 = 0
    Dim bKilitAcabilir As Boolean = False
    Public sPos1 As String = ""
    Public sPos2 As String = ""
    Public sPos3 As String = ""
    Public sPos4 As String = ""
    Public sPos5 As String = ""
    Private Sub frm_Market_KasaTeslimat_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        txt_dteFisTarihi1.EditValue = Today
        txt_dteFisTarihi2.EditValue = Today
        dataload_tbDepo()
        dataload_tbKasiyer()
        dataload_tbParekendeKasa()
        ara()
        If kullanici > 3 Then
            bKilitAcabilir = False
        Else
            bKilitAcabilir = True
        End If
        If kullanici > 3 And bKilitAcabilir = False Then
            sec_bKilitli.Properties.ReadOnly = True
        Else
            sec_bKilitli.Properties.ReadOnly = False
        End If
        sPos1 = sorgula_String("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED Select ISNULL(sAciklama,'') sAciklama from tbOdemeSekli Where sOdemeSekli = '1'")
        sPos2 = sorgula_String("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED Select ISNULL(sAciklama,'') sAciklama from tbOdemeSekli Where sOdemeSekli = '2'")
        sPos3 = sorgula_String("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED Select ISNULL(sAciklama,'') sAciklama from tbOdemeSekli Where sOdemeSekli = '3'")
        sPos4 = sorgula_String("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED Select ISNULL(sAciklama,'') sAciklama from tbOdemeSekli Where sOdemeSekli = '4'")
        sPos5 = sorgula_String("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED Select ISNULL(sAciklama,'') sAciklama from tbOdemeSekli Where sOdemeSekli = '5'")
    End Sub
    Private Sub ara()
        ds_tbMarketKasaTeslimat = Dataload_tbMarketKasaTeslimat(txt_dteFisTarihi1.EditValue, txt_dteFisTarihi2.EditValue, sec_Depolar.EditValue)
        GridControl1.DataSource = ds_tbMarketKasaTeslimat.Tables(0)
        GridControl1.DataMember = Nothing
        GridControl1.Focus()
        GridControl1.Select()
    End Sub
    Private Sub ara_detay(ByVal nTeslimatID As Int64)
        ds_tbMarketKasaTeslimatDetay = Dataload_tbMarketKasaTeslimatDetay(nTeslimatID)
        Dim dr As DataRow
        For Each dr In ds_tbMarketKasaTeslimatDetay.Tables(0).Rows
            If dr("nOdemeTipi") = 2 Then
                If dr("sAciklama") = "" And dr("sDovizCinsi") = "POS1" Then
                    dr("sAciklama") = sPos1
                ElseIf dr("sAciklama") = "" And dr("sDovizCinsi") = "POS2" Then
                    dr("sAciklama") = sPos2
                ElseIf dr("sAciklama") = "" And dr("sDovizCinsi") = "POS3" Then
                    dr("sAciklama") = sPos3
                ElseIf dr("sAciklama") = "" And dr("sDovizCinsi") = "POS4" Then
                    dr("sAciklama") = sPos4
                ElseIf dr("sAciklama") = "" And dr("sDovizCinsi") = "POS5" Then
                    dr("sAciklama") = sPos5
                End If
            End If
        Next
        GridControl2.DataSource = ds_tbMarketKasaTeslimatDetay.Tables(0)
        GridControl2.DataMember = Nothing
    End Sub
    Private Sub dataload_tbDepo()
        ds_tbDepo = sorgu(sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT     sDepo,sAciklama FROM         tbDepo"))
        sec_sDepo.Properties.DataSource = ds_tbDepo.Tables(0)
        sec_Depolar.Properties.DataSource = ds_tbDepo.Tables(0)
        ds_SubeMagaza = sorgu(sorgu_query(" SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT     sSubeMagaza, sAciklama  FROM         tbSubeMagaza"))
        sec_sSubeMagaza.Properties.DataSource = ds_SubeMagaza.Tables(0)
        sec_sSubeMagaza.EditValue = sSubeMagaza
        If kullanici > 3 And Trim(sDepo) <> "D001" Then
            sec_Depolar.EditValue = sDepo
            sec_Depolar.Properties.ReadOnly = True
            DateEdit1.Properties.ReadOnly = True
        Else
            'sec_sDepo.EditValue = sDepo
            DateEdit1.Properties.ReadOnly = False
            sec_sDepo.Properties.ReadOnly = False
        End If

    End Sub
    Private Sub dataload_tbKasiyer()
        ds_tbKasiyer = sorgu(sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT     sKasiyerRumuzu,sAdi,sSoyadi FROM         tbKasiyer"))
        sec_sKasiyerRumuzu.Properties.DataSource = ds_tbKasiyer.Tables(0)
    End Sub
    Private Sub dataload_tbParekendeKasa()
        ds_tbParekendeKasa = sorgu(sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT     nKasaNo,sAciklama FROM         tbParekendeKasa"))
        sec_nKasaNo.Properties.DataSource = ds_tbParekendeKasa.Tables(0)
    End Sub
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
    Private Sub gorunum_yazdir()
        Dim kriter As String = ""
        kriter += txt_dteFisTarihi1.EditValue.ToLongDateString & " ve " & txt_dteFisTarihi2.EditValue.ToLongDateString & " Tarihleri Arasındaki Kasa Teslim Föyleri" & vbCrLf
        kriter += "Mağaza: " & sec_Depolar.Text & "Period: " & sec_sPeriod.Text
        printlink1.PageHeaderFooter = New DevExpress.XtraPrinting.PageHeaderFooter(New DevExpress.XtraPrinting.PageHeaderArea(New String() {"[User Name]", kriter, "[Date Printed][Time Printed]"}, New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte)), DevExpress.XtraPrinting.BrickAlignment.Far), New DevExpress.XtraPrinting.PageFooterArea(New String() {"Powered by www.barkodyazilimevi.com", "Finans Yönetimi-Financial Managment", "[Page # of Pages #]"}, New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte)), DevExpress.XtraPrinting.BrickAlignment.Near))
        printlink1.CreateDocument(ps)
        ps.PreviewRibbonFormEx.Show()
    End Sub
    Private Sub gorunum_yazdir_detay()
        Dim kriter As String = ""
        kriter += txt_dteFisTarihi1.EditValue.ToLongDateString & " Tarihli Kasa Teslim Föyü" & vbCrLf
        kriter += "Mağaza: " & sec_sDepo.Text & " Kasa: " & sec_nKasaNo.Text & " Kasiyer: " & sec_sKasiyerRumuzu.Text & " Aciklama: " & txt_sAciklama.Text
        printlink2.PageHeaderFooter = New DevExpress.XtraPrinting.PageHeaderFooter(New DevExpress.XtraPrinting.PageHeaderArea(New String() {"[User Name]", kriter, "[Date Printed][Time Printed]"}, New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte)), DevExpress.XtraPrinting.BrickAlignment.Far), New DevExpress.XtraPrinting.PageFooterArea(New String() {"Powered by www.barkodyazilimevi.com", "Finans Yönetimi-Financial Managment", "[Page # of Pages #]"}, New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte)), DevExpress.XtraPrinting.BrickAlignment.Near))
        GridView2.Columns("lTutar").FilterInfo = New ColumnFilterInfo("[lTutar] <> 0")
        printlink2.CreateDocument(ps)
        ps.PreviewRibbonFormEx.Show()
        GridView2.ClearColumnsFilter()
    End Sub
    Private Sub gorunum_kaydet()
        GridView1.SaveLayoutToRegistry("SOFTWARE\BusinessSmart\VIEW\MAGAZA\" & Me.Name.ToString & "")
        XtraMessageBox.Show(Sorgu_sDil("Görünüm Kaydedildi", sDil), Sorgu_sDil("Dikkat", sDil), MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub
    Private Sub gorunum_yukle()
        For Each btn As DevExpress.XtraBars.BarItem In BarManager1.Items
            btn.Caption = Sorgu_sDil(btn.Caption, sDil)
        Next
        For Each clmn As DevExpress.XtraGrid.Columns.GridColumn In GridView1.Columns
            clmn.Caption = Sorgu_sDil(clmn.Caption, sDil)
        Next
        SimpleButton1.Text = Sorgu_sDil(SimpleButton1.Text, sDil)
        SimpleButton2.Text = Sorgu_sDil(SimpleButton2.Text, sDil)
        GridView1.RestoreLayoutFromRegistry("SOFTWARE\BusinessSmart\VIEW\MAGAZA\" & Me.Name.ToString & "")
    End Sub
    Private Function sorgu_query(ByVal query As String) As String
        query = Replace(query, "*!F", "F0" + firmano.ToString)
        query = Replace(query, "!D", "D000" + donemno.ToString)
        Return query
    End Function
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
    Public Function Dataload_tbMarketKasaTeslimat(ByVal tarih1 As DateTime, ByVal tarih2 As DateTime, ByVal sDepo As String) As DataSet
        Dim kriter As String = ""
        If Trim(sDepo) <> "" Then
            kriter += " AND tbMarketKasaTeslimat.sDepo = '" & sDepo & "'"
        End If
        Dim conn As New OleDb.OleDbConnection
        Dim cmd As New OleDb.OleDbCommand
        Dim adapter As New OleDb.OleDbDataAdapter
        conn.ConnectionString = connection
        adapter.SelectCommand = cmd
        'cmd.CommandText = sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT tbMarketKasaTeslimat.nTeslimatID, tbMarketKasaTeslimat.dteFisTarihi, tbMarketKasaTeslimat.sDepo, tbMarketKasaTeslimat.nKasaNo, tbMarketKasaTeslimat.sKasiyerRumuzu, tbMarketKasaTeslimat.sAciklama, tbMarketKasaTeslimat.lAcilis, tbMarketKasaTeslimat.lKapanis, tbMarketKasaTeslimat.lGonderilecek, tbMarketKasaTeslimat.lNakit, tbMarketKasaTeslimat.lKagit, tbMarketKasaTeslimat.lBozuk, tbMarketKasaTeslimat.lKredi, tbMarketKasaTeslimat.lOdeme, tbMarketKasaTeslimat.lZ, tbMarketKasaTeslimat.lFark, tbMarketKasaTeslimat.nIptalSayisi, tbMarketKasaTeslimat.lIptalTutari, tbMarketKasaTeslimat.dteKayitTarihi, tbMarketKasaTeslimat.sKullaniciAdi, tbKasiyer.sAdi, tbKasiyer.sSoyadi, tbDepo.sAciklama AS DepoAciklama, tbMarketKasaTeslimat.lNakit + tbMarketKasaTeslimat.lOdeme - tbMarketKasaTeslimat.lAcilis AS lKasayaGiren, tbPoslar.POS1, tbPoslar.POS2, tbPoslar.POS3, tbPoslar.POS4, tbPoslar.POS5,tbMarketKasaTeslimat.bKilitli,tbMarketKasaTeslimat.bEntegre FROM tbMarketKasaTeslimat LEFT OUTER JOIN (SELECT nTeslimatID , SUM(POS1) AS POS1 , SUM(POS2) AS POS2 , SUM(POS3) AS POS3 , SUM(POS4) AS POS4 , SUM(POS5) AS POS5 FROM (SELECT nTeslimatID , CASE WHEN sDovizCinsi = 'POS1 ' THEN SUM(lTutar) ELSE 0 END AS POS1 , CASE WHEN sDovizCinsi = 'POS2 ' THEN SUM(lTutar) ELSE 0 END AS POS2 , CASE WHEN sDovizCinsi = 'POS3 ' THEN SUM(lTutar) ELSE 0 END AS POS3 , CASE WHEN sDovizCinsi = 'POS4 ' THEN SUM(lTutar) ELSE 0 END AS POS4 , CASE WHEN sDovizCinsi = 'POS5 ' THEN SUM(lTutar) ELSE 0 END AS POS5 FROM tbMarketKasaTeslimatDetay WHERE  (nOdemeTipi = 2) GROUP BY nTeslimatID , sDovizCinsi) tbPosToplamlari GROUP BY nTeslimatID) tbPoslar ON tbMarketKasaTeslimat.nTeslimatID = tbPoslar.nTeslimatID LEFT OUTER JOIN tbKasiyer ON tbMarketKasaTeslimat.sKasiyerRumuzu = tbKasiyer.sKasiyerRumuzu LEFT OUTER JOIN tbDepo ON tbMarketKasaTeslimat.sDepo = tbDepo.sDepo Where tbMarketKasaTeslimat.dteFisTarihi between '" & tarih1 & "' and '" & tarih2 & "'  " & kriter & "")
        If sec_bTopla.Checked = False Then
            cmd.CommandText = sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT tbMarketKasaTeslimat.nTeslimatID, tbMarketKasaTeslimat.dteFisTarihi, tbMarketKasaTeslimat.sDepo, tbMarketKasaTeslimat.nKasaNo, tbMarketKasaTeslimat.sKasiyerRumuzu, tbMarketKasaTeslimat.sAciklama, tbMarketKasaTeslimat.lAcilis, tbMarketKasaTeslimat.lKapanis, tbMarketKasaTeslimat.lGonderilecek, tbMarketKasaTeslimat.lNakit, tbMarketKasaTeslimat.lKagit, tbMarketKasaTeslimat.lBozuk, tbMarketKasaTeslimat.lKredi, tbMarketKasaTeslimat.lOdeme, tbMarketKasaTeslimat.lZ, tbMarketKasaTeslimat.lFark, tbMarketKasaTeslimat.nIptalSayisi, tbMarketKasaTeslimat.lIptalTutari, tbMarketKasaTeslimat.dteKayitTarihi, tbMarketKasaTeslimat.sKullaniciAdi, tbKasiyer.sAdi, tbKasiyer.sSoyadi, tbDepo.sAciklama AS DepoAciklama, tbMarketKasaTeslimat.lNakit + tbMarketKasaTeslimat.lOdeme - tbMarketKasaTeslimat.lAcilis AS lKasayaGiren, tbPoslar.POS1, tbPoslar.POS2, tbPoslar.POS3, tbPoslar.POS4, tbPoslar.POS5,tbMarketKasaTeslimat.bKilitli,tbMarketKasaTeslimat.bEntegre,tbKdv.KDV1, tbKdv.KDV2, tbKdv.KDV3, tbKdv.KDV4, tbKdv.KDV5 FROM tbMarketKasaTeslimat LEFT OUTER JOIN (SELECT nTeslimatID , SUM(POS1) AS POS1 , SUM(POS2) AS POS2 , SUM(POS3) AS POS3 , SUM(POS4) AS POS4 , SUM(POS5) AS POS5 FROM (SELECT nTeslimatID , CASE WHEN sDovizCinsi = 'POS1 ' THEN SUM(lTutar) ELSE 0 END AS POS1 , CASE WHEN sDovizCinsi = 'POS2 ' THEN SUM(lTutar) ELSE 0 END AS POS2 , CASE WHEN sDovizCinsi = 'POS3 ' THEN SUM(lTutar) ELSE 0 END AS POS3 , CASE WHEN sDovizCinsi = 'POS4 ' THEN SUM(lTutar) ELSE 0 END AS POS4 , CASE WHEN sDovizCinsi = 'POS5 ' THEN SUM(lTutar) ELSE 0 END AS POS5 FROM tbMarketKasaTeslimatDetay WHERE  (nOdemeTipi = 2) GROUP BY nTeslimatID , sDovizCinsi) tbPosToplamlari GROUP BY nTeslimatID) tbPoslar ON tbMarketKasaTeslimat.nTeslimatID = tbPoslar.nTeslimatID LEFT OUTER JOIN tbKasiyer ON tbMarketKasaTeslimat.sKasiyerRumuzu = tbKasiyer.sKasiyerRumuzu LEFT OUTER JOIN tbDepo ON tbMarketKasaTeslimat.sDepo = tbDepo.sDepo LEFT OUTER JOIN (SELECT nTeslimatID , SUM(KDV1) AS KDV1 , SUM(KDV2) AS KDV2 , SUM(KDV3) AS KDV3 , SUM(KDV4) AS KDV4 , SUM(KDV5) AS KDV5 FROM (SELECT nTeslimatID , CASE WHEN sDovizCinsi = 'KDV1 ' THEN SUM(lTutar) ELSE 0 END AS KDV1 , CASE WHEN sDovizCinsi = 'KDV2 ' THEN SUM(lTutar) ELSE 0 END AS KDV2 , CASE WHEN sDovizCinsi = 'KDV3 ' THEN SUM(lTutar) ELSE 0 END AS KDV3 , CASE WHEN sDovizCinsi = 'KDV4 ' THEN SUM(lTutar) ELSE 0 END AS KDV4 , CASE WHEN sDovizCinsi = 'KDV5 ' THEN SUM(lTutar) ELSE 0 END AS KDV5 FROM tbMarketKasaTeslimatDetay WHERE (nOdemeTipi = 4) AND sDovizCinsi LIKE 'KDV%' GROUP BY nTeslimatID , sDovizCinsi) tbKdvToplamlari GROUP BY nTeslimatID) tbKdv ON tbMarketKasaTeslimat.nTeslimatID = tbKdv.nTeslimatID Where tbMarketKasaTeslimat.dteFisTarihi between '" & tarih1 & "' and '" & tarih2 & "'  " & kriter & "")
        ElseIf sec_bTopla.Checked = True Then
            If sec_sPeriod.Text = "" Then
                cmd.CommandText = sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT 0 AS nTeslimatID, '01/01/1900' AS dteFisTarihi, '' as sDepo, 0 AS nKasaNo, '' AS sKasiyerRumuzu, SUM(lAcilis) AS lAcilis, SUM(lKapanis) AS lKapanis, SUM(lGonderilecek) AS lGonderilecek, SUM(lNakit) AS lNakit, SUM(lKagit) AS lKagit, SUM(lBozuk) AS lBozuk, SUM(lKredi) AS lKredi, SUM(lOdeme) AS lOdeme, SUM(lZ) AS lZ, SUM(lFark) AS lFark, SUM(nIptalSayisi) AS nIptalSayisi, SUM(lIptalTutari) AS lIptalTutari, MAX(dteKayitTarihi) AS dteKayitTarihi, '' AS sKullaniciAdi, '' AS sAdi, '' AS sSoyadi, '' AS DepoAciklama, SUM(lKasayaGiren) AS lKasayaGiren, SUM(POS1) AS POS1, SUM(POS2) AS POS2, SUM(POS3) AS POS3, SUM(POS4) AS POS4, SUM(POS5) AS POS5, SUM(KDV1) AS KDV1, SUM(KDV2) AS KDV2, SUM(KDV3) AS KDV3, SUM(KDV4) AS KDV4, SUM(KDV5) AS KDV5 FROM (SELECT tbMarketKasaTeslimat.nTeslimatID, tbMarketKasaTeslimat.dteFisTarihi, tbMarketKasaTeslimat.sDepo, tbMarketKasaTeslimat.nKasaNo, tbMarketKasaTeslimat.sKasiyerRumuzu, tbMarketKasaTeslimat.sAciklama, tbMarketKasaTeslimat.lAcilis, tbMarketKasaTeslimat.lKapanis, tbMarketKasaTeslimat.lGonderilecek, tbMarketKasaTeslimat.lNakit, tbMarketKasaTeslimat.lKagit, tbMarketKasaTeslimat.lBozuk, tbMarketKasaTeslimat.lKredi, tbMarketKasaTeslimat.lOdeme, tbMarketKasaTeslimat.lZ, tbMarketKasaTeslimat.lFark, tbMarketKasaTeslimat.nIptalSayisi, tbMarketKasaTeslimat.lIptalTutari, tbMarketKasaTeslimat.dteKayitTarihi, tbMarketKasaTeslimat.sKullaniciAdi, tbKasiyer.sAdi, tbKasiyer.sSoyadi, tbDepo.sAciklama AS DepoAciklama, tbMarketKasaTeslimat.lNakit + tbMarketKasaTeslimat.lOdeme - tbMarketKasaTeslimat.lAcilis AS lKasayaGiren, tbPoslar.POS1, tbPoslar.POS2, tbPoslar.POS3, tbPoslar.POS4, tbPoslar.POS5,tbMarketKasaTeslimat.bKilitli,tbMarketKasaTeslimat.bEntegre,tbKdv.KDV1, tbKdv.KDV2, tbKdv.KDV3, tbKdv.KDV4, tbKdv.KDV5 FROM tbMarketKasaTeslimat LEFT OUTER JOIN (SELECT nTeslimatID , SUM(POS1) AS POS1 , SUM(POS2) AS POS2 , SUM(POS3) AS POS3 , SUM(POS4) AS POS4 , SUM(POS5) AS POS5 FROM (SELECT nTeslimatID , CASE WHEN sDovizCinsi = 'POS1 ' THEN SUM(lTutar) ELSE 0 END AS POS1 , CASE WHEN sDovizCinsi = 'POS2 ' THEN SUM(lTutar) ELSE 0 END AS POS2 , CASE WHEN sDovizCinsi = 'POS3 ' THEN SUM(lTutar) ELSE 0 END AS POS3 , CASE WHEN sDovizCinsi = 'POS4 ' THEN SUM(lTutar) ELSE 0 END AS POS4 , CASE WHEN sDovizCinsi = 'POS5 ' THEN SUM(lTutar) ELSE 0 END AS POS5 FROM tbMarketKasaTeslimatDetay WHERE  (nOdemeTipi = 2) GROUP BY nTeslimatID , sDovizCinsi) tbPosToplamlari GROUP BY nTeslimatID) tbPoslar ON tbMarketKasaTeslimat.nTeslimatID = tbPoslar.nTeslimatID LEFT OUTER JOIN tbKasiyer ON tbMarketKasaTeslimat.sKasiyerRumuzu = tbKasiyer.sKasiyerRumuzu LEFT OUTER JOIN tbDepo ON tbMarketKasaTeslimat.sDepo = tbDepo.sDepo LEFT OUTER JOIN (SELECT nTeslimatID , SUM(KDV1) AS KDV1 , SUM(KDV2) AS KDV2 , SUM(KDV3) AS KDV3 , SUM(KDV4) AS KDV4 , SUM(KDV5) AS KDV5 FROM (SELECT nTeslimatID , CASE WHEN sDovizCinsi = 'KDV1 ' THEN SUM(lTutar) ELSE 0 END AS KDV1 , CASE WHEN sDovizCinsi = 'KDV2 ' THEN SUM(lTutar) ELSE 0 END AS KDV2 , CASE WHEN sDovizCinsi = 'KDV3 ' THEN SUM(lTutar) ELSE 0 END AS KDV3 , CASE WHEN sDovizCinsi = 'KDV4 ' THEN SUM(lTutar) ELSE 0 END AS KDV4 , CASE WHEN sDovizCinsi = 'KDV5 ' THEN SUM(lTutar) ELSE 0 END AS KDV5 FROM tbMarketKasaTeslimatDetay WHERE (nOdemeTipi = 4) AND sDovizCinsi LIKE 'KDV%' GROUP BY nTeslimatID , sDovizCinsi) tbKdvToplamlari GROUP BY nTeslimatID) tbKdv ON tbMarketKasaTeslimat.nTeslimatID = tbKdv.nTeslimatID Where tbMarketKasaTeslimat.dteFisTarihi between '" & tarih1 & "' and '" & tarih2 & "'  " & kriter & ") tbTeslimat ")
            Else
                cmd.CommandText = sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT 0 AS nTeslimatID, '01/01/1900' AS dteFisTarihi, " & sec_sPeriod.Text & " as sDepo, 0 AS nKasaNo, '' AS sKasiyerRumuzu, SUM(lAcilis) AS lAcilis, SUM(lKapanis) AS lKapanis, SUM(lGonderilecek) AS lGonderilecek, SUM(lNakit) AS lNakit, SUM(lKagit) AS lKagit, SUM(lBozuk) AS lBozuk, SUM(lKredi) AS lKredi, SUM(lOdeme) AS lOdeme, SUM(lZ) AS lZ, SUM(lFark) AS lFark, SUM(nIptalSayisi) AS nIptalSayisi, SUM(lIptalTutari) AS lIptalTutari, MAX(dteKayitTarihi) AS dteKayitTarihi, '' AS sKullaniciAdi, '' AS sAdi, '' AS sSoyadi, '' AS DepoAciklama, SUM(lKasayaGiren) AS lKasayaGiren, SUM(POS1) AS POS1, SUM(POS2) AS POS2, SUM(POS3) AS POS3, SUM(POS4) AS POS4, SUM(POS5) AS POS5, SUM(KDV1) AS KDV1, SUM(KDV2) AS KDV2, SUM(KDV3) AS KDV3, SUM(KDV4) AS KDV4, SUM(KDV5) AS KDV5 FROM (SELECT tbMarketKasaTeslimat.nTeslimatID, tbMarketKasaTeslimat.dteFisTarihi, tbMarketKasaTeslimat.sDepo, tbMarketKasaTeslimat.nKasaNo, tbMarketKasaTeslimat.sKasiyerRumuzu, tbMarketKasaTeslimat.sAciklama, tbMarketKasaTeslimat.lAcilis, tbMarketKasaTeslimat.lKapanis, tbMarketKasaTeslimat.lGonderilecek, tbMarketKasaTeslimat.lNakit, tbMarketKasaTeslimat.lKagit, tbMarketKasaTeslimat.lBozuk, tbMarketKasaTeslimat.lKredi, tbMarketKasaTeslimat.lOdeme, tbMarketKasaTeslimat.lZ, tbMarketKasaTeslimat.lFark, tbMarketKasaTeslimat.nIptalSayisi, tbMarketKasaTeslimat.lIptalTutari, tbMarketKasaTeslimat.dteKayitTarihi, tbMarketKasaTeslimat.sKullaniciAdi, tbKasiyer.sAdi, tbKasiyer.sSoyadi, tbDepo.sAciklama AS DepoAciklama, tbMarketKasaTeslimat.lNakit + tbMarketKasaTeslimat.lOdeme - tbMarketKasaTeslimat.lAcilis AS lKasayaGiren, tbPoslar.POS1, tbPoslar.POS2, tbPoslar.POS3, tbPoslar.POS4, tbPoslar.POS5,tbMarketKasaTeslimat.bKilitli,tbMarketKasaTeslimat.bEntegre,tbKdv.KDV1, tbKdv.KDV2, tbKdv.KDV3, tbKdv.KDV4, tbKdv.KDV5 FROM tbMarketKasaTeslimat LEFT OUTER JOIN (SELECT nTeslimatID , SUM(POS1) AS POS1 , SUM(POS2) AS POS2 , SUM(POS3) AS POS3 , SUM(POS4) AS POS4 , SUM(POS5) AS POS5 FROM (SELECT nTeslimatID , CASE WHEN sDovizCinsi = 'POS1 ' THEN SUM(lTutar) ELSE 0 END AS POS1 , CASE WHEN sDovizCinsi = 'POS2 ' THEN SUM(lTutar) ELSE 0 END AS POS2 , CASE WHEN sDovizCinsi = 'POS3 ' THEN SUM(lTutar) ELSE 0 END AS POS3 , CASE WHEN sDovizCinsi = 'POS4 ' THEN SUM(lTutar) ELSE 0 END AS POS4 , CASE WHEN sDovizCinsi = 'POS5 ' THEN SUM(lTutar) ELSE 0 END AS POS5 FROM tbMarketKasaTeslimatDetay WHERE  (nOdemeTipi = 2) GROUP BY nTeslimatID , sDovizCinsi) tbPosToplamlari GROUP BY nTeslimatID) tbPoslar ON tbMarketKasaTeslimat.nTeslimatID = tbPoslar.nTeslimatID LEFT OUTER JOIN tbKasiyer ON tbMarketKasaTeslimat.sKasiyerRumuzu = tbKasiyer.sKasiyerRumuzu LEFT OUTER JOIN tbDepo ON tbMarketKasaTeslimat.sDepo = tbDepo.sDepo LEFT OUTER JOIN (SELECT nTeslimatID , SUM(KDV1) AS KDV1 , SUM(KDV2) AS KDV2 , SUM(KDV3) AS KDV3 , SUM(KDV4) AS KDV4 , SUM(KDV5) AS KDV5 FROM (SELECT nTeslimatID , CASE WHEN sDovizCinsi = 'KDV1 ' THEN SUM(lTutar) ELSE 0 END AS KDV1 , CASE WHEN sDovizCinsi = 'KDV2 ' THEN SUM(lTutar) ELSE 0 END AS KDV2 , CASE WHEN sDovizCinsi = 'KDV3 ' THEN SUM(lTutar) ELSE 0 END AS KDV3 , CASE WHEN sDovizCinsi = 'KDV4 ' THEN SUM(lTutar) ELSE 0 END AS KDV4 , CASE WHEN sDovizCinsi = 'KDV5 ' THEN SUM(lTutar) ELSE 0 END AS KDV5 FROM tbMarketKasaTeslimatDetay WHERE (nOdemeTipi = 4) AND sDovizCinsi LIKE 'KDV%' GROUP BY nTeslimatID , sDovizCinsi) tbKdvToplamlari GROUP BY nTeslimatID) tbKdv ON tbMarketKasaTeslimat.nTeslimatID = tbKdv.nTeslimatID Where tbMarketKasaTeslimat.dteFisTarihi between '" & tarih1 & "' and '" & tarih2 & "'  " & kriter & ") tbTeslimat Group by " & sec_sPeriod.Text & "")
            End If
            colDepoAciklama.Visible = False
            colnKasaNo.Visible = False
            colsKasiyerRumuzu.Visible = False
            colsAdi.Visible = False
            colbEntegre.Visible = False
        End If
        cmd.Connection = conn
        conn.Open()
        Dim ds1 As New DataSet
        Dim N As Integer = adapter.Fill(ds1, "Table1")
        conn.Close()
        Return ds1
    End Function
    Public Function Dataload_tbMarketKasaTeslimatDetay(ByVal nTeslimatID As Int64, Optional ByVal bTumu As Boolean = True) As DataSet
        Dim conn As New OleDb.OleDbConnection
        Dim cmd As New OleDb.OleDbCommand
        Dim adapter As New OleDb.OleDbDataAdapter
        conn.ConnectionString = connection
        adapter.SelectCommand = cmd
        Dim kriter As String = ""
        If bTumu = True Then
            kriter = " AND tbMarketKasaTeslimatDetay.nTeslimatID = " & nTeslimatID & ""
        Else
            kriter = " Where tbMarketKasaTeslimatDetay.nTeslimatID = " & nTeslimatID & " and tbParamSabit.nOdemeTipi IN(1,2,3,4,5)"
        End If
        'cmd.CommandText = sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT tbParamSabit.nOdemeTipi, tbParamSabit.sOdemeSekli, tbParamSabit.sDovizCinsi, tbParamSabit.nSabit, ISNULL(tbMarketKasaTeslimatDetay.lMiktar, 0) AS lMiktar, ISNULL(tbMarketKasaTeslimatDetay.lTutar, 0) AS lTutar, ISNULL(tbMarketKasaTeslimatDetay.nKayitID, 0) AS nKayitID, ISNULL(tbMarketKasaTeslimatDetay.nTeslimatID, 0) AS nTeslimatID, ISNULL(tbMarketKasaTeslimatDetay.lKur, 0) AS lKur, ISNULL(tbMarketKasaTeslimatDetay.sAciklama, '') AS sAciklama, ISNULL(tbMarketKasaTeslimatDetay.nFirmaID, 0) AS nFirmaID, ISNULL(tbMarketKasaTeslimatDetay.sFirmaKodu, '') sFirmaKodu, ISNULL(tbMarketKasaTeslimatDetay.sFirmaAciklama, '') AS sFirmaAciklama FROM (SELECT 1 AS nOdemeTipi , 'N' AS sOdemeSekli , '500' AS sDovizCinsi , 500 AS nSabit UNION ALL SELECT 1 AS nOdemeTipi , 'N' AS sOdemeSekli , '200 ' AS sDovizCinsi , 200 AS nSabit UNION ALL SELECT 1 AS nOdemeTipi , 'N' AS sOdemeSekli , '100 ' AS sOdemeSekli , 100 AS nSabit UNION ALL SELECT 1 AS nOdemeTipi , 'N' AS sOdemeSekli , '50  ' AS sDovizCinsi , 50 AS nSabit UNION ALL SELECT 1 AS nOdemeTipi , 'N' AS sOdemeSekli , '20  ' AS sDovizCinsi , 20 AS nSabit UNION ALL SELECT 1 AS nOdemeTipi , 'N' AS sOdemeSekli , '10  ' AS sDovizCinsi , 10 AS nSabit UNION ALL SELECT 1 AS nOdemeTipi , 'N' AS sOdemeSekli , '5' AS sDovizCinsi , 5 AS nSabit UNION ALL SELECT 1 AS nOdemeTipi , 'N' AS sOdemeSekli , '1   ' AS sDovizCinsi , 1 AS nSabit UNION ALL SELECT 1 AS nOdemeTipi , 'N' AS sOdemeSekli , '0.50' AS sDovizCinsi , .50 AS nSabit UNION ALL SELECT 1 AS nOdemeTipi , 'N' AS sOdemeSekli , '0.25' AS sDovizCinsi , .25 AS nSabit UNION ALL SELECT 1 AS nOdemeTipi , 'N' AS sOdemeSekli , '0.10' AS sDovizCinsi , .10 AS nSabit UNION ALL SELECT 1 AS nOdemeTipi , 'N' AS sOdemeSekli , '0.05' AS sDovizCinsi , .05 AS nSabit UNION ALL SELECT 1 AS nOdemeTipi , 'N' AS sOdemeSekli , 'USD ' AS sDovizCinsi , 1 AS nSabit UNION ALL SELECT 1 AS nOdemeTipi , 'N' AS sOdemeSekli , 'EUR ' AS sDovizCinsi , 1 AS nSabit UNION ALL SELECT 1 AS nOdemeTipi , 'N' AS sOdemeSekli , 'RYL ' AS sDovizCinsi , 1 AS nSabit UNION ALL SELECT 2 AS nOdemeTipi , '1' AS sOdemeSekli , 'POS1-" & sPos1 & "' AS sDovizCinsi , 1 AS nSabit UNION ALL SELECT 2 AS nOdemeTipi , '2' AS sOdemeSekli , 'POS2-" & sPos2 & "' AS sDovizCinsi , 1 AS nSabit UNION ALL SELECT 2 AS nOdemeTipi , '3' AS sOdemeSekli , 'POS3-" & sPos3 & "' AS sDovizCinsi , 1 AS nSabit UNION ALL SELECT 2 AS nOdemeTipi , '4' AS sOdemeSekli , 'POS4-" & sPos4 & "' AS sDovizCinsi , 1 AS nSabit UNION ALL SELECT 2 AS nOdemeTipi , '5' AS sOdemeSekli , 'POS5-" & sPos5 & "' AS sDovizCinsi , 1 AS nSabit UNION ALL SELECT 3 AS nOdemeTipi , 'OD' AS sOdemeSekli , 'OD01' AS sDovizCinsi , 1 AS nSabit UNION ALL SELECT 3 AS nOdemeTipi , 'OD' AS sOdemeSekli , 'OD02' AS sDovizCinsi , 1 AS nSabit UNION ALL SELECT 3 AS nOdemeTipi , 'OD' AS sOdemeSekli , 'OD03' AS sDovizCinsi , 1 AS nSabit UNION ALL SELECT 3 AS nOdemeTipi , 'OD' AS sOdemeSekli , 'OD04' AS sDovizCinsi , 1 AS nSabit UNION ALL SELECT 3 AS nOdemeTipi , 'OD' AS sOdemeSekli , 'OD05' AS sDovizCinsi , 1 AS nSabit UNION ALL SELECT 3 AS nOdemeTipi , 'OD' AS sOdemeSekli , 'OD06' AS sDovizCinsi , 1 AS nSabit UNION ALL SELECT 3 AS nOdemeTipi , 'OD' AS sOdemeSekli , 'OD07' AS sDovizCinsi , 1 AS nSabit UNION ALL SELECT 3 AS nOdemeTipi , 'OD' AS sOdemeSekli , 'OD08' AS sDovizCinsi , 1 AS nSabit UNION ALL SELECT 3 AS nOdemeTipi , 'OD' AS sOdemeSekli , 'OD09' AS sDovizCinsi , 1 AS nSabit UNION ALL SELECT 3 AS nOdemeTipi , 'OD' AS sOdemeSekli , 'OD10' AS sDovizCinsi , 1 AS  nSabit  UNION ALL SELECT 3 AS nOdemeTipi , 'OD' AS sOdemeSekli , 'OD11' AS sDovizCinsi , 1 AS  nSabit  UNION ALL SELECT 3 AS nOdemeTipi , 'OD' AS sOdemeSekli , 'OD12' AS sDovizCinsi , 1 AS  nSabit  UNION ALL SELECT 3 AS nOdemeTipi , 'OD' AS sOdemeSekli , 'OD13' AS sDovizCinsi , 1 AS  nSabit  UNION ALL SELECT 3 AS nOdemeTipi , 'OD' AS sOdemeSekli , 'OD14' AS sDovizCinsi , 1 AS  nSabit  UNION ALL SELECT 3 AS nOdemeTipi , 'OD' AS sOdemeSekli , 'OD15' AS sDovizCinsi , 1 AS  nSabit  UNION ALL SELECT 3 AS nOdemeTipi , 'OD' AS sOdemeSekli , 'OD16' AS sDovizCinsi , 1 AS  nSabit  UNION ALL SELECT 3 AS nOdemeTipi , 'OD' AS sOdemeSekli , 'OD17' AS sDovizCinsi , 1 AS  nSabit  UNION ALL SELECT 3 AS nOdemeTipi , 'OD' AS sOdemeSekli , 'OD18' AS sDovizCinsi , 1 AS  nSabit  UNION ALL SELECT 3 AS nOdemeTipi , 'OD' AS sOdemeSekli , 'OD19' AS sDovizCinsi , 1 AS  nSabit  UNION ALL SELECT 3 AS nOdemeTipi , 'OD' AS sOdemeSekli , 'OD20' AS sDovizCinsi , 1 AS  nSabit UNION ALL SELECT 4 AS nOdemeTipi , 'Z' AS sOdemeSekli , 'Z' AS sDovizCinsi , 1 AS nSabit UNION ALL SELECT 5 AS nOdemeTipi , 'ON' AS sOdemeSekli , 'ON' AS sDovizCinsi , 1 AS nSabit UNION ALL SELECT 6 AS nOdemeTipi , 'OFF' AS sOdemeSekli , 'OFF' AS sDovizCinsi , 1 AS nSabit UNION ALL SELECT 7 AS nOdemeTipi , 'IPS' AS sOdemeSekli , 'IPS' AS sDovizCinsi , 1 AS nSabit UNION ALL SELECT 8 AS nOdemeTipi , 'IPT' AS sOdemeSekli , 'IPT' AS sDovizCinsi , 1 AS nSabit) tbParamSabit LEFT OUTER JOIN tbMarketKasaTeslimatDetay ON tbParamSabit.sDovizCinsi = tbMarketKasaTeslimatDetay.sDovizCinsi " & kriter & " ")
        'cmd.CommandText = sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT tbParamSabit.nOdemeTipi, tbParamSabit.sOdemeSekli, tbParamSabit.sDovizCinsi, tbParamSabit.nSabit, ISNULL(tbMarketKasaTeslimatDetay.lMiktar, 0) AS lMiktar, ISNULL(tbMarketKasaTeslimatDetay.lTutar, 0) AS lTutar, ISNULL(tbMarketKasaTeslimatDetay.nKayitID, 0) AS nKayitID, ISNULL(tbMarketKasaTeslimatDetay.nTeslimatID, 0) AS nTeslimatID, ISNULL(tbMarketKasaTeslimatDetay.lKur, 0) AS lKur, ISNULL(tbMarketKasaTeslimatDetay.sAciklama, '') AS sAciklama, ISNULL(tbMarketKasaTeslimatDetay.nFirmaID, 0) AS nFirmaID, ISNULL(tbMarketKasaTeslimatDetay.sFirmaKodu, '') sFirmaKodu, ISNULL(tbMarketKasaTeslimatDetay.sFirmaAciklama, '') AS sFirmaAciklama FROM (SELECT 1 AS nOdemeTipi , 'N' AS sOdemeSekli , '500' AS sDovizCinsi , 500 AS nSabit UNION ALL SELECT 1 AS nOdemeTipi , 'N' AS sOdemeSekli , '200 ' AS sDovizCinsi , 200 AS nSabit UNION ALL SELECT 1 AS nOdemeTipi , 'N' AS sOdemeSekli , '100 ' AS sOdemeSekli , 100 AS nSabit UNION ALL SELECT 1 AS nOdemeTipi , 'N' AS sOdemeSekli , '50  ' AS sDovizCinsi , 50 AS nSabit UNION ALL SELECT 1 AS nOdemeTipi , 'N' AS sOdemeSekli , '20  ' AS sDovizCinsi , 20 AS nSabit UNION ALL SELECT 1 AS nOdemeTipi , 'N' AS sOdemeSekli , '10  ' AS sDovizCinsi , 10 AS nSabit UNION ALL SELECT 1 AS nOdemeTipi , 'N' AS sOdemeSekli , '5' AS sDovizCinsi , 5 AS nSabit UNION ALL SELECT 1 AS nOdemeTipi , 'N' AS sOdemeSekli , '1   ' AS sDovizCinsi , 1 AS nSabit UNION ALL SELECT 1 AS nOdemeTipi , 'N' AS sOdemeSekli , '0.50' AS sDovizCinsi , .50 AS nSabit UNION ALL SELECT 1 AS nOdemeTipi , 'N' AS sOdemeSekli , '0.25' AS sDovizCinsi , .25 AS nSabit UNION ALL SELECT 1 AS nOdemeTipi , 'N' AS sOdemeSekli , '0.10' AS sDovizCinsi , .10 AS nSabit UNION ALL SELECT 1 AS nOdemeTipi , 'N' AS sOdemeSekli , '0.05' AS sDovizCinsi , .05 AS nSabit UNION ALL SELECT 1 AS nOdemeTipi , 'N' AS sOdemeSekli , 'USD ' AS sDovizCinsi , 1 AS nSabit UNION ALL SELECT 1 AS nOdemeTipi , 'N' AS sOdemeSekli , 'EUR ' AS sDovizCinsi , 1 AS nSabit UNION ALL SELECT 1 AS nOdemeTipi , 'N' AS sOdemeSekli , 'RYL ' AS sDovizCinsi , 1 AS nSabit UNION ALL SELECT 2 AS nOdemeTipi , '1' AS sOdemeSekli , 'POS1' AS sDovizCinsi , 1 AS nSabit UNION ALL SELECT 2 AS nOdemeTipi , '2' AS sOdemeSekli , 'POS2' AS sDovizCinsi , 1 AS nSabit UNION ALL SELECT 2 AS nOdemeTipi , '3' AS sOdemeSekli , 'POS3' AS sDovizCinsi , 1 AS nSabit UNION ALL SELECT 2 AS nOdemeTipi , '4' AS sOdemeSekli , 'POS4' AS sDovizCinsi , 1 AS nSabit UNION ALL SELECT 2 AS nOdemeTipi , '5' AS sOdemeSekli , 'POS5' AS sDovizCinsi , 1 AS nSabit UNION ALL SELECT 3 AS nOdemeTipi , 'OD' AS sOdemeSekli , 'OD01' AS sDovizCinsi , 1 AS nSabit UNION ALL SELECT 3 AS nOdemeTipi , 'OD' AS sOdemeSekli , 'OD02' AS sDovizCinsi , 1 AS nSabit UNION ALL SELECT 3 AS nOdemeTipi , 'OD' AS sOdemeSekli , 'OD03' AS sDovizCinsi , 1 AS nSabit UNION ALL SELECT 3 AS nOdemeTipi , 'OD' AS sOdemeSekli , 'OD04' AS sDovizCinsi , 1 AS nSabit UNION ALL SELECT 3 AS nOdemeTipi , 'OD' AS sOdemeSekli , 'OD05' AS sDovizCinsi , 1 AS nSabit UNION ALL SELECT 3 AS nOdemeTipi , 'OD' AS sOdemeSekli , 'OD06' AS sDovizCinsi , 1 AS nSabit UNION ALL SELECT 3 AS nOdemeTipi , 'OD' AS sOdemeSekli , 'OD07' AS sDovizCinsi , 1 AS nSabit UNION ALL SELECT 3 AS nOdemeTipi , 'OD' AS sOdemeSekli , 'OD08' AS sDovizCinsi , 1 AS nSabit UNION ALL SELECT 3 AS nOdemeTipi , 'OD' AS sOdemeSekli , 'OD09' AS sDovizCinsi , 1 AS nSabit UNION ALL SELECT 3 AS nOdemeTipi , 'OD' AS sOdemeSekli , 'OD10' AS sDovizCinsi , 1 AS  nSabit  UNION ALL SELECT 3 AS nOdemeTipi , 'OD' AS sOdemeSekli , 'OD11' AS sDovizCinsi , 1 AS  nSabit  UNION ALL SELECT 3 AS nOdemeTipi , 'OD' AS sOdemeSekli , 'OD12' AS sDovizCinsi , 1 AS  nSabit  UNION ALL SELECT 3 AS nOdemeTipi , 'OD' AS sOdemeSekli , 'OD13' AS sDovizCinsi , 1 AS  nSabit  UNION ALL SELECT 3 AS nOdemeTipi , 'OD' AS sOdemeSekli , 'OD14' AS sDovizCinsi , 1 AS  nSabit  UNION ALL SELECT 3 AS nOdemeTipi , 'OD' AS sOdemeSekli , 'OD15' AS sDovizCinsi , 1 AS  nSabit  UNION ALL SELECT 3 AS nOdemeTipi , 'OD' AS sOdemeSekli , 'OD16' AS sDovizCinsi , 1 AS  nSabit  UNION ALL SELECT 3 AS nOdemeTipi , 'OD' AS sOdemeSekli , 'OD17' AS sDovizCinsi , 1 AS  nSabit  UNION ALL SELECT 3 AS nOdemeTipi , 'OD' AS sOdemeSekli , 'OD18' AS sDovizCinsi , 1 AS  nSabit  UNION ALL SELECT 3 AS nOdemeTipi , 'OD' AS sOdemeSekli , 'OD19' AS sDovizCinsi , 1 AS  nSabit  UNION ALL SELECT 3 AS nOdemeTipi , 'OD' AS sOdemeSekli , 'OD20' AS sDovizCinsi , 1 AS  nSabit UNION ALL SELECT 4 AS nOdemeTipi , 'Z' AS sOdemeSekli , 'Z' AS sDovizCinsi , 1 AS nSabit UNION ALL SELECT 5 AS nOdemeTipi , 'ON' AS sOdemeSekli , 'ON' AS sDovizCinsi , 1 AS nSabit UNION ALL SELECT 6 AS nOdemeTipi , 'OFF' AS sOdemeSekli , 'OFF' AS sDovizCinsi , 1 AS nSabit UNION ALL SELECT 7 AS nOdemeTipi , 'IPS' AS sOdemeSekli , 'IPS' AS sDovizCinsi , 1 AS nSabit UNION ALL SELECT 8 AS nOdemeTipi , 'IPT' AS sOdemeSekli , 'IPT' AS sDovizCinsi , 1 AS nSabit) tbParamSabit LEFT OUTER JOIN tbMarketKasaTeslimatDetay ON tbParamSabit.sDovizCinsi = tbMarketKasaTeslimatDetay.sDovizCinsi " & kriter & " ")
        cmd.CommandText = sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT tbParamSabit.nOdemeTipi, tbParamSabit.sOdemeSekli, tbParamSabit.sDovizCinsi, tbParamSabit.nSabit, ISNULL(tbMarketKasaTeslimatDetay.lMiktar, 0) AS lMiktar, ISNULL(tbMarketKasaTeslimatDetay.lTutar, 0) AS lTutar, ISNULL(tbMarketKasaTeslimatDetay.nKayitID, 0) AS nKayitID, ISNULL(tbMarketKasaTeslimatDetay.nTeslimatID, 0) AS nTeslimatID, ISNULL(tbMarketKasaTeslimatDetay.lKur, 0) AS lKur, ISNULL(tbMarketKasaTeslimatDetay.sAciklama, '') AS sAciklama, ISNULL(tbMarketKasaTeslimatDetay.nFirmaID, 0) AS nFirmaID, ISNULL(tbMarketKasaTeslimatDetay.sFirmaKodu, '') sFirmaKodu, ISNULL(tbMarketKasaTeslimatDetay.sFirmaAciklama, '') AS sFirmaAciklama FROM (SELECT 1 AS nOdemeTipi , 'N' AS sOdemeSekli , '500' AS sDovizCinsi , 500 AS nSabit UNION ALL SELECT 1 AS nOdemeTipi , 'N' AS sOdemeSekli , '200 ' AS sDovizCinsi , 200 AS nSabit UNION ALL SELECT 1 AS nOdemeTipi , 'N' AS sOdemeSekli , '100 ' AS sOdemeSekli , 100 AS nSabit UNION ALL SELECT 1 AS nOdemeTipi , 'N' AS sOdemeSekli , '50  ' AS sDovizCinsi , 50 AS nSabit UNION ALL SELECT 1 AS nOdemeTipi , 'N' AS sOdemeSekli , '20  ' AS sDovizCinsi , 20 AS nSabit UNION ALL SELECT 1 AS nOdemeTipi , 'N' AS sOdemeSekli , '10  ' AS sDovizCinsi , 10 AS nSabit UNION ALL SELECT 1 AS nOdemeTipi , 'N' AS sOdemeSekli , '5' AS sDovizCinsi , 5 AS nSabit UNION ALL SELECT 1 AS nOdemeTipi , 'N' AS sOdemeSekli , '1   ' AS sDovizCinsi , 1 AS nSabit UNION ALL SELECT 1 AS nOdemeTipi , 'N' AS sOdemeSekli , '0.50' AS sDovizCinsi , .50 AS nSabit UNION ALL SELECT 1 AS nOdemeTipi , 'N' AS sOdemeSekli , '0.25' AS sDovizCinsi , .25 AS nSabit UNION ALL SELECT 1 AS nOdemeTipi , 'N' AS sOdemeSekli , '0.10' AS sDovizCinsi , .10 AS nSabit UNION ALL SELECT 1 AS nOdemeTipi , 'N' AS sOdemeSekli , '0.05' AS sDovizCinsi , .05 AS nSabit UNION ALL SELECT 1 AS nOdemeTipi , 'N' AS sOdemeSekli , 'USD ' AS sDovizCinsi , 1 AS nSabit UNION ALL SELECT 1 AS nOdemeTipi , 'N' AS sOdemeSekli , 'EUR ' AS sDovizCinsi , 1 AS nSabit UNION ALL SELECT 1 AS nOdemeTipi , 'N' AS sOdemeSekli , 'RYL ' AS sDovizCinsi , 1 AS nSabit UNION ALL SELECT 2 AS nOdemeTipi , '1' AS sOdemeSekli , 'POS1' AS sDovizCinsi , 1 AS nSabit UNION ALL SELECT 2 AS nOdemeTipi , '2' AS sOdemeSekli , 'POS2' AS sDovizCinsi , 1 AS nSabit UNION ALL SELECT 2 AS nOdemeTipi , '3' AS sOdemeSekli , 'POS3' AS sDovizCinsi , 1 AS nSabit UNION ALL SELECT 2 AS nOdemeTipi , '4' AS sOdemeSekli , 'POS4' AS sDovizCinsi , 1 AS nSabit UNION ALL SELECT 2 AS nOdemeTipi , '5' AS sOdemeSekli , 'POS5' AS sDovizCinsi , 1 AS nSabit UNION ALL SELECT 4 AS nOdemeTipi, 'KDV1' AS sOdemeSekli, 'KDV1' AS sDovizCinsi, 1 AS nSabit UNION ALL SELECT 4 AS nOdemeTipi, 'KDV2' AS sOdemeSekli, 'KDV2' AS sDovizCinsi, 1 AS nSabit UNION ALL SELECT 4 AS nOdemeTipi, 'KDV3' AS sOdemeSekli, 'KDV3' AS sDovizCinsi, 1 AS nSabit UNION ALL SELECT 4 AS nOdemeTipi, 'KDV4' AS sOdemeSekli, 'KDV4' AS sDovizCinsi, 1 AS nSabit UNION ALL SELECT 4 AS nOdemeTipi, 'KDV5' AS sOdemeSekli, 'KDV5' AS sDovizCinsi, 1 AS nSabit UNION ALL SELECT 3 AS nOdemeTipi , 'OD' AS sOdemeSekli , 'OD01' AS sDovizCinsi , 1 AS nSabit UNION ALL SELECT 3 AS nOdemeTipi , 'OD' AS sOdemeSekli , 'OD02' AS sDovizCinsi , 1 AS nSabit UNION ALL SELECT 3 AS nOdemeTipi , 'OD' AS sOdemeSekli , 'OD03' AS sDovizCinsi , 1 AS nSabit UNION ALL SELECT 3 AS nOdemeTipi , 'OD' AS sOdemeSekli , 'OD04' AS sDovizCinsi , 1 AS nSabit UNION ALL SELECT 3 AS nOdemeTipi , 'OD' AS sOdemeSekli , 'OD05' AS sDovizCinsi , 1 AS nSabit UNION ALL SELECT 3 AS nOdemeTipi , 'OD' AS sOdemeSekli , 'OD06' AS sDovizCinsi , 1 AS nSabit UNION ALL SELECT 3 AS nOdemeTipi , 'OD' AS sOdemeSekli , 'OD07' AS sDovizCinsi , 1 AS nSabit UNION ALL SELECT 3 AS nOdemeTipi , 'OD' AS sOdemeSekli , 'OD08' AS sDovizCinsi , 1 AS nSabit UNION ALL SELECT 3 AS nOdemeTipi , 'OD' AS sOdemeSekli , 'OD09' AS sDovizCinsi , 1 AS nSabit UNION ALL SELECT 3 AS nOdemeTipi , 'OD' AS sOdemeSekli , 'OD10' AS sDovizCinsi , 1 AS  nSabit  UNION ALL SELECT 3 AS nOdemeTipi , 'OD' AS sOdemeSekli , 'OD11' AS sDovizCinsi , 1 AS  nSabit  UNION ALL SELECT 3 AS nOdemeTipi , 'OD' AS sOdemeSekli , 'OD12' AS sDovizCinsi , 1 AS  nSabit  UNION ALL SELECT 3 AS nOdemeTipi , 'OD' AS sOdemeSekli , 'OD13' AS sDovizCinsi , 1 AS  nSabit  UNION ALL SELECT 3 AS nOdemeTipi , 'OD' AS sOdemeSekli , 'OD14' AS sDovizCinsi , 1 AS  nSabit  UNION ALL SELECT 3 AS nOdemeTipi , 'OD' AS sOdemeSekli , 'OD15' AS sDovizCinsi , 1 AS  nSabit  UNION ALL SELECT 3 AS nOdemeTipi , 'OD' AS sOdemeSekli , 'OD16' AS sDovizCinsi , 1 AS  nSabit  UNION ALL SELECT 3 AS nOdemeTipi , 'OD' AS sOdemeSekli , 'OD17' AS sDovizCinsi , 1 AS  nSabit  UNION ALL SELECT 3 AS nOdemeTipi , 'OD' AS sOdemeSekli , 'OD18' AS sDovizCinsi , 1 AS  nSabit  UNION ALL SELECT 3 AS nOdemeTipi , 'OD' AS sOdemeSekli , 'OD19' AS sDovizCinsi , 1 AS  nSabit  UNION ALL SELECT 3 AS nOdemeTipi , 'OD' AS sOdemeSekli , 'OD20' AS sDovizCinsi , 1 AS  nSabit UNION ALL SELECT 4 AS nOdemeTipi , 'Z' AS sOdemeSekli , 'Z' AS sDovizCinsi , 1 AS nSabit UNION ALL SELECT 5 AS nOdemeTipi , 'ON' AS sOdemeSekli , 'ON' AS sDovizCinsi , 1 AS nSabit UNION ALL SELECT 6 AS nOdemeTipi , 'OFF' AS sOdemeSekli , 'OFF' AS sDovizCinsi , 1 AS nSabit UNION ALL SELECT 7 AS nOdemeTipi , 'IPS' AS sOdemeSekli , 'IPS' AS sDovizCinsi , 1 AS nSabit UNION ALL SELECT 8 AS nOdemeTipi , 'IPT' AS sOdemeSekli , 'IPT' AS sDovizCinsi , 1 AS nSabit) tbParamSabit LEFT OUTER JOIN tbMarketKasaTeslimatDetay ON tbParamSabit.sDovizCinsi = tbMarketKasaTeslimatDetay.sDovizCinsi " & kriter & " ")
        cmd.Connection = conn
        conn.Open()
        Dim ds1 As New DataSet
        Dim N As Integer = adapter.Fill(ds1, "HAREKET")
        conn.Close()
        Return ds1
    End Function
    Private Function tbMarketKasaTeslimat_kaydet_yeni(ByVal dteFisTarihi As DateTime, ByVal sDepo As String, ByVal nKasaNo As Int64, ByVal sKasiyerRumuzu As String, ByVal sAciklama As String, ByVal lAcilis As Decimal, ByVal lNakit As Decimal, ByVal lKagit As Decimal, ByVal lBozuk As Decimal, ByVal lKredi As Decimal, ByVal lOdeme As Decimal, ByVal lZ As Decimal, ByVal lFark As Decimal, ByVal nIptalSayisi As Integer, ByVal lIptalTutari As Decimal, ByVal dteKayitTarihi As DateTime, ByVal sKullaniciAdi As String) As Int64
        Dim cmd As New OleDb.OleDbCommand
        Dim con As New OleDb.OleDbConnection
        cmd.Connection = con
        con.ConnectionString = connection
        If con.State = ConnectionState.Closed = True Then
            con.Open()
        End If
        cmd.CommandText = sorgu_query("SET DATEFORMAT DMY SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED INSERT INTO tbMarketKasaTeslimat                       ( dteFisTarihi, sDepo, nKasaNo, sKasiyerRumuzu, sAciklama, lAcilis, lNakit, lKagit, lBozuk, lKredi, lOdeme, lZ, lFark,nIptalSayisi,lIptalTutari, dteKayitTarihi, sKullaniciAdi) VALUES     ( '" & dteFisTarihi & "', '" & sDepo & "', " & nKasaNo & ", '" & sKasiyerRumuzu & "', '" & sAciklama & "', " & lAcilis & ", " & lNakit & ", " & lKagit & ", " & lBozuk & ", " & lKredi & ", " & lOdeme & ", " & lZ & ", " & lFark & ", " & nIptalSayisi & "," & lIptalTutari & ",'" & dteKayitTarihi & "', '" & sKullaniciAdi & "')")
        cmd.ExecuteNonQuery()
        cmd.CommandText = "SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT @@identity"
        Dim kayitno As Int64 = sorgu_sayi(cmd.ExecuteScalar, 0)
        cmd = Nothing
        con = Nothing
        Return kayitno
    End Function
    Private Sub tbMarketKasaTeslimat_kaydet_duzelt(ByVal nTeslimatID As Int64, ByVal dteFisTarihi As DateTime, ByVal sDepo As String, ByVal nKasaNo As Int64, ByVal sKasiyerRumuzu As String, ByVal sAciklama As String, ByVal lAcilis As Decimal, ByVal lKapanis As Decimal, ByVal lGonderilecek As Decimal, ByVal lNakit As Decimal, ByVal lKagit As Decimal, ByVal lBozuk As Decimal, ByVal lKredi As Decimal, ByVal lOdeme As Decimal, ByVal lZ As Decimal, ByVal lFark As Decimal, ByVal nIptalSayisi As Integer, ByVal lIptalTutari As Decimal, ByVal dteKayitTarihi As DateTime, ByVal sKullaniciAdi As String, ByVal bKilitli As Byte, ByVal bEntegre As Byte)
        Dim cmd As New OleDb.OleDbCommand
        Dim con As New OleDb.OleDbConnection
        cmd.Connection = con
        con.ConnectionString = connection
        If con.State = ConnectionState.Closed = True Then
            con.Open()
        End If
        cmd.CommandText = sorgu_query("SET DATEFORMAT DMY SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED UPDATE    tbMarketKasaTeslimat SET              dteFisTarihi = '" & dteFisTarihi & "', sDepo = '" & sDepo & "', nKasaNo = '" & nKasaNo & "', sKasiyerRumuzu = '" & sKasiyerRumuzu & "', sAciklama = '" & sAciklama & "', lAcilis = " & lAcilis & ", lKapanis = " & lKapanis & " ,lGonderilecek = " & lGonderilecek & ",lNakit = " & lNakit & ", lKagit = " & lKagit & ", lBozuk = " & lBozuk & ", lKredi = " & lKredi & ", lOdeme = " & lOdeme & ", lZ = " & lZ & ", lFark = " & lFark & ",nIptalSayisi = " & nIptalSayisi & ",lIptalTutari = " & lIptalTutari & ",bKilitli = " & bKilitli & ",bEntegre = " & bEntegre & " Where nTeslimatID = " & nTeslimatID & "")
        cmd.ExecuteNonQuery()
        con.Close()
        cmd = Nothing
        con = Nothing
    End Sub
    Private Sub tbMarketKasaTeslimat_kaydet_sil(ByVal nTeslimatID As String)
        Dim cmd As New OleDb.OleDbCommand
        Dim con As New OleDb.OleDbConnection
        cmd.Connection = con
        con.ConnectionString = connection
        If con.State = ConnectionState.Closed = True Then
            con.Open()
        End If
        cmd.CommandText = sorgu_query("SET DATEFORMAT DMY SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED DELETE FROM    tbMarketKasaTeslimat  Where nTeslimatID = '" & nTeslimatID & "'")
        cmd.ExecuteNonQuery()
        con.Close()
        cmd = Nothing
        con = Nothing
    End Sub
    Private Function tbMarketKasaTeslimatDetay_kaydet_yeni(ByVal nTeslimatID As Int64, ByVal nOdemeTipi As Int64, ByVal sOdemeSekli As String, ByVal sAciklama As String, ByVal sDovizCinsi As String, ByVal lKur As Decimal, ByVal lMiktar As Decimal, ByVal lTutar As Decimal, ByVal nFirmaID As Int64, ByVal sFirmaKodu As String, ByVal sFirmaAciklama As String) As Int64
        Dim cmd As New OleDb.OleDbCommand
        Dim con As New OleDb.OleDbConnection
        cmd.Connection = con
        con.ConnectionString = connection
        If con.State = ConnectionState.Closed = True Then
            con.Open()
        End If
        cmd.CommandText = sorgu_query("SET DATEFORMAT DMY SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED INSERT INTO tbMarketKasaTeslimatDetay                       (nTeslimatID, nOdemeTipi, sOdemeSekli, sAciklama, sDovizCinsi, lKur, lMiktar, lTutar,nFirmaID,sFirmaKodu,sFirmaAciklama) VALUES     (" & nTeslimatID & ", " & nOdemeTipi & ", '" & sOdemeSekli & "', '" & sAciklama & "', '" & sDovizCinsi & "', " & lKur & ", " & lMiktar & ", " & lTutar & "," & nFirmaID & ",'" & sFirmaKodu & "','" & sFirmaAciklama & "')")
        cmd.ExecuteNonQuery()
        cmd.CommandText = "SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT @@identity"
        Dim kayitno As Int64 = sorgu_sayi(cmd.ExecuteScalar, 0)
        cmd = Nothing
        con = Nothing
        Return kayitno
    End Function
    Private Sub tbMarketKasaTeslimatDetay_kaydet_duzelt(ByVal nKayitID As Int64, ByVal nTeslimatID As Int64, ByVal nOdemeTipi As Int64, ByVal sOdemeSekli As String, ByVal sAciklama As String, ByVal sDovizCinsi As String, ByVal lKur As Decimal, ByVal lMiktar As Decimal, ByVal lTutar As Decimal, ByVal nFirmaID As Int64, ByVal sFirmaKodu As String, ByVal sFirmaAciklama As String)
        Dim cmd As New OleDb.OleDbCommand
        Dim con As New OleDb.OleDbConnection
        cmd.Connection = con
        con.ConnectionString = connection
        If con.State = ConnectionState.Closed = True Then
            con.Open()
        End If
        cmd.CommandText = sorgu_query("SET DATEFORMAT DMY SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED UPDATE    tbMarketKasaTeslimatDetay SET              nOdemeTipi = " & nOdemeTipi & ", sOdemeSekli = '" & sOdemeSekli & "', sAciklama = '" & sAciklama & "', sDovizCinsi = '" & sDovizCinsi & "', lKur = " & lKur & ", lMiktar = " & lMiktar & ",                       lTutar = " & lTutar & ",nFirmaID = " & nFirmaID & ",sFirmaKodu = '" & sFirmaKodu & "',sFirmaAciklama = '" & sFirmaAciklama & "' Where nTeslimatID = " & nTeslimatID & " and nKayitID = " & nKayitID & "")
        cmd.ExecuteNonQuery()
        con.Close()
        cmd = Nothing
        con = Nothing
    End Sub
    Private Sub tbMarketKasaTeslimatDetay_kaydet_sil(ByVal nTeslimatID As Int64, ByVal nKayitID As Int64)
        Dim cmd As New OleDb.OleDbCommand
        Dim con As New OleDb.OleDbConnection
        cmd.Connection = con
        con.ConnectionString = connection
        If con.State = ConnectionState.Closed = True Then
            con.Open()
        End If
        cmd.CommandText = sorgu_query("SET DATEFORMAT DMY SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED DELETE FROM    tbMarketKasaTeslimatDetay  Where nTeslimatID = '" & nTeslimatID & "' and nKayitID = '" & nKayitID & "'")
        cmd.ExecuteNonQuery()
        con.Close()
        cmd = Nothing
        con = Nothing
    End Sub
    Private Sub firma_sec(Optional ByVal islem As Integer = 0)
        Dim dr As DataRow
        dr = GridView2.GetDataRow(GridView2.FocusedRowHandle)

        Dim frm As New frm_firma_liste
        frm.firmano = firmano
        frm.donemno = donemno
        frm.connection = connection
        frm.islemstatus = True
        frm.kullanici = kullanici
        If islem = 2 Then
            frm.sModul = "Banka"
            frm.sec_konum.Text = "Kodu"
            frm.txt_ara.Text = " "
        End If
        If frm.ShowDialog(Me) = Windows.Forms.DialogResult.OK Then
            Dim dr1 As DataRow
            dr1 = frm.GridView1.GetDataRow(frm.GridView1.FocusedRowHandle)
            dr("nFirmaID") = dr1("nFirmaID")
            dr("sFirmaKodu") = dr1("sKodu")
            dr("sFirmaAciklama") = Trim(dr1("sAciklama").ToString)
            If Trim(dr("sAciklama").ToString) = "" Then
                dr("sAciklama") = Trim(dr1("sAciklama").ToString)
            End If
            dr1 = Nothing
        End If
    End Sub
    Private Sub kayit_ekle()
        XtraTabPage1.PageVisible = False
        XtraTabPage2.PageVisible = True
        DateEdit1.EditValue = dteSistemTarihi
        sec_sDepo.EditValue = sDepo
        sec_nKasaNo.EditValue = 1
        sec_sKasiyerRumuzu.EditValue = ""
        nTeslimatID = tbMarketKasaTeslimat_kaydet_yeni(dteSistemTarihi, sDepo, 1, "", "", 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, Now, kullaniciadi)
        lbl_nTeslimatID.Text = nTeslimatID
        ara_detay(nTeslimatID)
        sec_sDepo.Focus()
        lbl_Nakit.Text = FormatNumber(0, 2)
        lbl_Pos1.Text = FormatNumber(0, 2)
        lbl_Pos2.Text = FormatNumber(0, 2)
        lbl_Pos3.Text = FormatNumber(0, 2)
        lbl_Pos4.Text = FormatNumber(0, 2)
        lbl_Pos5.Text = FormatNumber(0, 2)
        lbl_Pos6.Text = FormatNumber(0, 2)
        lbl_Pos7.Text = FormatNumber(0, 2)
        lbl_PosT.Text = FormatNumber(0, 2)
        lbl_GenelToplam.Text = FormatNumber(0, 2)
        lbl_lDevir.Text = FormatNumber(0, 2)
        'txt_sDepoKodu.EditValue = ""
        'txt_sAciklama.EditValue = ""
        'sec_sDepoTipi.EditValue = ""
        'sec_tbFirma.Text = 0
        'sec_sSube.EditValue = ""
        'txt_sEmail.EditValue = ""
        'txt_nCalisanSayisi.EditValue = 1
        'txt_sMagazaMuduru.EditValue = ""
        'txt_nMagazaM2.EditValue = 0
        'txt_nDepoM2.EditValue = 0
        'txt_nKatSayisi.EditValue = 0
        'sec_sDovizCinsi.EditValue = ""
        'txt_lKiraBedeli.EditValue = 0
        'txt_dteAcilisTarihi.EditValue = "01/01/1900"
        'txt_dteDekorasyonTarihi.EditValue = "01/01/1900"
        'txt_sDepoKodu.Enabled = True
        'islem = "Ekle"
        'txt_sDepoKodu.Focus()
        'txt_sDepoKodu.Select()
    End Sub
    Private Sub kayit_duzelt()
        If GridView1.RowCount > 0 Then

            'satir = GridView1.FocusedRowHandle
            Dim dr As DataRow = GridView1.GetDataRow(GridView1.FocusedRowHandle)
            If dr("nTeslimatID") > 0 Then
                XtraTabPage1.PageVisible = False
                XtraTabPage2.PageVisible = True
                nTeslimatID = dr("nTeslimatID")
                lbl_nTeslimatID.Text = nTeslimatID
                DateEdit1.EditValue = dr("dteFisTarihi")
                sec_sDepo.EditValue = dr("sDepo")
                sec_sKasiyerRumuzu.EditValue = dr("sKasiyerRumuzu")
                sec_nKasaNo.EditValue = dr("nKasaNo")
                txt_sAciklama.EditValue = dr("sAciklama")
                sec_bKilitli.EditValue = dr("bKilitli")
                sec_bEntegre.Checked = dr("bEntegre")
                ara_detay(dr("nTeslimatID"))
                toplam_hesapla()
                satis_getir(DateEdit1.EditValue, sec_sDepo.EditValue, sec_nKasaNo.EditValue, sec_sKasiyerRumuzu.EditValue)
            End If
        End If
        'XtraTabPage1.PageVisible = False
        'XtraTabPage2.PageVisible = True
        ''satir = GridView1.FocusedRowHandle
        'Dim dr As DataRow = GridView1.GetDataRow(GridView1.FocusedRowHandle)
        ''txt_sDepoKodu.EditValue = dr("sDepo")
        ''txt_sAciklama.EditValue = dr("sAciklama")
        ''sec_sDepoTipi.EditValue = dr("sDepoTipi")
        ''sec_tbFirma.Text = dr("nFirmaID")
        ''sec_sSube.EditValue = dr("sSube")
        ''txt_sEmail.EditValue = dr("sEmail")
        ''txt_nCalisanSayisi.EditValue = dr("nPersonelAdeti")
        ''txt_sMagazaMuduru.EditValue = dr("sMudurAdiSoyadi")
        ''txt_nMagazaM2.EditValue = dr("nMagazaM2")
        ''txt_nDepoM2.EditValue = dr("nDepoM2")
        ''txt_nKatSayisi.EditValue = dr("nKatSayisi")
        ''sec_sDovizCinsi.EditValue = dr("sKiraDovizCinsi")
        ''txt_lKiraBedeli.EditValue = dr("lKiraBedeli")
        ''txt_dteAcilisTarihi.EditValue = dr("dteAcilisTarihi")
        ''txt_dteDekorasyonTarihi.EditValue = dr("dteSonDekorasyon")
        ''txt_sDepoKodu.Enabled = False
        ''islem = "Düzelt"
        ''dr = Nothing
        ''txt_sAciklama.Focus()
        ''txt_sAciklama.SelectAll()
    End Sub
    Private Sub kayit_sil()
        If GridView1.RowCount > 0 Then
            If XtraMessageBox.Show(Sorgu_sDil("Kaydı Silmek İstediğinize Emin misiniz...?", sDil), Sorgu_sDil("Dikkat", sDil), MessageBoxButtons.YesNo, MessageBoxIcon.Question) = MsgBoxResult.Yes Then
                Dim dr As DataRow = GridView1.GetDataRow(GridView1.FocusedRowHandle)
                tbMarketKasaTeslimat_kaydet_sil(dr("nTeslimatID"))
                ara()
            End If
        End If
    End Sub
    Private Sub kaydet()
        'If islem = "Ekle" Then
        '    tbDepo_kaydet_yeni(sec_sDepoKodu.EditValue, txt_sAciklama.EditValue, sec_tbFirma.Text, sec_sSube.EditValue, sec_sDepoTipi.EditValue, txt_sEmail.EditValue, txt_nKatSayisi.EditValue, txt_nMagazaM2.EditValue, txt_nDepoM2.EditValue, sec_sDovizCinsi.EditValue, txt_lKiraBedeli.EditValue, txt_dteAcilisTarihi.EditValue, txt_dteDekorasyonTarihi.EditValue, txt_sMagazaMuduru.EditValue, txt_nCalisanSayisi.EditValue)
        '    Dataload_tbDepo()
        '    GridView1.FocusedRowHandle = GridView1.RowCount - 1
        'ElseIf islem = "Düzelt" Then
        '    tbDepo_kaydet_duzelt(txt_sDepoKodu.EditValue, txt_sAciklama.EditValue, sec_tbFirma.Text, sec_sSube.EditValue, sec_sDepoTipi.EditValue, txt_sEmail.EditValue, txt_nKatSayisi.EditValue, txt_nMagazaM2.EditValue, txt_nDepoM2.EditValue, sec_sDovizCinsi.EditValue, txt_lKiraBedeli.EditValue, txt_dteAcilisTarihi.EditValue, txt_dteDekorasyonTarihi.EditValue, txt_sMagazaMuduru.EditValue, txt_nCalisanSayisi.EditValue)
        '    Dataload_tbDepo()
        '    GridView1.FocusedRowHandle = satir
        'End If
        XtraTabPage1.PageVisible = True
        XtraTabPage2.PageVisible = False
        GridControl1.Focus()
        GridControl1.Select()
    End Sub
    Private Sub tutar_hesapla()
        If GridView2.RowCount > 0 Then
            Dim dr As DataRow = GridView2.GetDataRow(GridView2.FocusedRowHandle)
            If dr("nKayitID") = 0 Then
                dr("lKur") = dr("nSabit")
            End If
            If dr("lKur") = 0 Then
                dr("lKur") = 1
            End If
            dr("lTutar") = dr("lMiktar") * dr("lKur")
            If dr("nOdemeTipi") = 4 And Microsoft.VisualBasic.Left(Trim(dr("sDovizCinsi")), 3) <> "KDV" Then
                dr("lTutar") = -Math.Abs(dr("lTutar"))
                If Trim(dr("sAciklama")) = "" Then
                    dr("sAciklama") = "Z Raporu"
                End If
            End If
            If dr("nOdemeTipi") = 4 And Microsoft.VisualBasic.Left(Trim(dr("sDovizCinsi")), 3) = "KDV" Then
                dr("lTutar") = Math.Abs(dr("lTutar"))
                If Trim(dr("sAciklama")) = "" Then
                    If Microsoft.VisualBasic.Right(dr("sDovizCinsi"), 1) = 1 Then
                        dr("sAciklama") = "%0"
                    ElseIf Microsoft.VisualBasic.Right(dr("sDovizCinsi"), 1) = 2 Then
                        dr("sAciklama") = "%1"
                    ElseIf Microsoft.VisualBasic.Right(dr("sDovizCinsi"), 1) = 3 Then
                        dr("sAciklama") = "%8"
                    ElseIf Microsoft.VisualBasic.Right(dr("sDovizCinsi"), 1) = 4 Then
                        dr("sAciklama") = "%18"
                    ElseIf Microsoft.VisualBasic.Right(dr("sDovizCinsi"), 1) = 5 Then
                        dr("sAciklama") = "%18"
                    End If
                End If
            End If
            If dr("nOdemeTipi") = 5 Then
                dr("lTutar") = -Math.Abs(dr("lTutar"))
                dr("sAciklama") = "Kasa Acilis"
            End If
            If dr("nOdemeTipi") = 6 Then
                dr("lTutar") = 0
                dr("sAciklama") = "Kasa Kapanis"
            End If
            If dr("nOdemeTipi") = 7 Then
                dr("lTutar") = 0
                If Trim(dr("sAciklama")) = "" Then
                    dr("sAciklama") = "IptalFisi"
                End If
            End If
            If dr("nOdemeTipi") = 8 Then
                dr("lTutar") = 0
                If Trim(dr("sAciklama")) = "" Then
                    dr("sAciklama") = "IptalTutari"
                End If
            End If
            If dr("lMiktar") <> 0 Then
                If dr("nOdemeTipi") = 2 Or dr("nOdemeTipi") = 3 Then
                    If dr("nFirmaID") = 0 Then
                        firma_sec(dr("nOdemeTipi"))
                    End If
                End If
                If sorgu_sDovizCinsi_kontrol(dr("sDovizCinsi"), lbl_nTeslimatID.Text) = False Then
                    tbMarketKasaTeslimatDetay_kaydet_duzelt(dr("nKayitID"), lbl_nTeslimatID.Text, dr("nOdemeTipi"), dr("sOdemeSekli"), dr("sAciklama"), dr("sDovizCinsi"), dr("lKur"), dr("lMiktar"), dr("lTutar"), dr("nFirmaID"), dr("sFirmaKodu"), dr("sFirmaAciklama"))
                Else
                    tbMarketKasaTeslimatDetay_kaydet_yeni(lbl_nTeslimatID.Text, dr("nOdemeTipi"), dr("sOdemeSekli"), dr("sAciklama"), dr("sDovizCinsi"), dr("lKur"), dr("lMiktar"), dr("lTutar"), dr("nFirmaID"), dr("sFirmaKodu"), dr("sFirmaAciklama"))
                End If
            Else
                dr("lKur") = 0
                If dr("nKayitID") > 0 Then
                    tbMarketKasaTeslimatDetay_kaydet_sil(lbl_nTeslimatID.Text, dr("nKayitID"))
                End If
            End If
            toplam_hesapla()
        End If
    End Sub
    Public Function sorgu_sDovizCinsi_kontrol(ByVal sDovizCinsi As String, ByVal nTeslimatID As Int64) As Boolean
        Dim kriter
        Dim pass As Boolean
        kriter = ""
        Dim conn As New OleDb.OleDbConnection
        Dim cmd As New OleDb.OleDbCommand
        Dim adapter As New OleDb.OleDbDataAdapter
        conn.ConnectionString = connection
        cmd.Connection = conn
        conn.Open()
        cmd.CommandText = sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT     COUNT(*) AS nKayit FROM         tbMarketKasaTeslimatDetay WHERE     (sDovizCinsi = '" & sDovizCinsi & "') AND (nTeslimatID = " & nTeslimatID & ")")
        Dim kayitsayisi = cmd.ExecuteScalar
        If kayitsayisi = 0 Then
            pass = True
        Else
            pass = False
        End If
        Return pass
    End Function
    Private Sub toplam_hesapla()
        Dim dr As DataRow
        Dim lKagitPara As Decimal = 0
        Dim lBozukPara As Decimal = 0
        Dim lNakitPara As Decimal = 0
        Dim lKasa As Decimal = 0
        Dim lOdemeler As Decimal = 0
        Dim lPoslar As Decimal = 0
        Dim lGenelKasa As Decimal = 0
        Dim lZToplam As Decimal = 0
        Dim lAcilis As Decimal = 0
        Dim lKapanis As Decimal = 0
        Dim lFark As Decimal = 0
        Dim nIptalSayisi As Decimal = 0
        Dim lIptalTutari As Decimal = 0
        Dim lGonderilecek As Decimal = 0
        For Each dr In ds_tbMarketKasaTeslimatDetay.Tables(0).Rows
            If dr("nOdemeTipi") = 1 Then
                lNakitPara += dr("lTutar")
                If Trim(dr("sDovizCinsi")) = "USD" Or Trim(dr("sDovizCinsi")) = "EUR" Or Trim(dr("sDovizCinsi")) = "RYL" Then
                Else
                    If dr("lKur") = 500 Then
                        lKagitPara += dr("lTutar")
                    ElseIf dr("lKur") = 200 Then
                        lKagitPara += dr("lTutar")
                    ElseIf dr("lKur") = 100 Then
                        lKagitPara += dr("lTutar")
                    ElseIf dr("lKur") = 50 Then
                        lKagitPara += dr("lTutar")
                    ElseIf dr("lKur") = 20 Then
                        lKagitPara += dr("lTutar")
                    ElseIf dr("lKur") = 10 Then
                        lKagitPara += dr("lTutar")
                    ElseIf dr("lKur") = 5 Then
                        lKagitPara += dr("lTutar")
                    ElseIf dr("lKur") = 1 Then
                        lBozukPara += dr("lTutar")
                    ElseIf dr("lKur") = 0.5 Then
                        lBozukPara += dr("lTutar")
                    ElseIf dr("lKur") = 0.25 Then
                        lBozukPara += dr("lTutar")
                    ElseIf dr("lKur") = 0.1 Then
                        lBozukPara += dr("lTutar")
                    ElseIf dr("lKur") = 0.05 Then
                        lBozukPara += dr("lTutar")
                    End If
                End If
            ElseIf dr("nOdemeTipi") = 2 Then
                lPoslar += dr("lTutar")
            ElseIf dr("nOdemeTipi") = 3 Then
                lOdemeler += dr("lTutar")
            ElseIf dr("nOdemeTipi") = 4 Then
                lZToplam += Math.Abs(dr("lTutar"))
            ElseIf dr("nOdemeTipi") = 5 Then
                lAcilis += Math.Abs(dr("lTutar"))
            ElseIf dr("nOdemeTipi") = 6 Then
                lKapanis += dr("lMiktar")
            ElseIf dr("nOdemeTipi") = 7 Then
                nIptalSayisi += dr("lMiktar")
            ElseIf dr("nOdemeTipi") = 8 Then
                lIptalTutari += dr("lMiktar")
            End If
        Next
        lKasa = lNakitPara + lOdemeler
        lGenelKasa = lKasa + lPoslar
        lFark = lGenelKasa - lZToplam - lAcilis
        lGonderilecek = lNakitPara - lKapanis
        lbl_lKagitPara.Text = Microsoft.VisualBasic.Format(lKagitPara, "#,0.00")
        lbl_lBozukPara.Text = Microsoft.VisualBasic.Format(lBozukPara, "#,0.00")
        lbl_lNakitPara.Text = Microsoft.VisualBasic.Format(lNakitPara, "#,0.00")
        lbl_lOdemeler.Text = Microsoft.VisualBasic.Format(lOdemeler, "#,0.00")
        lbl_lKasa.Text = Microsoft.VisualBasic.Format(lKasa, "#,0.00")
        lbl_lPoslar.Text = Microsoft.VisualBasic.Format(lPoslar, "#,0.00")
        lbl_lGenelKasa.Text = Microsoft.VisualBasic.Format(lGenelKasa, "#,0.00")
        lbl_lZToplam.Text = Microsoft.VisualBasic.Format(lZToplam, "#,0.00")
        lbl_lFark.Text = Microsoft.VisualBasic.Format(lFark, "#,0.00")
        tbMarketKasaTeslimat_kaydet_duzelt(lbl_nTeslimatID.Text, DateEdit1.EditValue, sec_sDepo.EditValue, sec_nKasaNo.EditValue, sec_sKasiyerRumuzu.EditValue, txt_sAciklama.Text, lAcilis, lKapanis, lGonderilecek, lNakitPara, lKagitPara, lBozukPara, lPoslar, lOdemeler, lZToplam, lFark, nIptalSayisi, lIptalTutari, Now, kullaniciadi, sec_bKilitli.Checked, sec_bEntegre.Checked)
    End Sub
    Private Sub raporla_Teslimat(ByVal rapor As Integer, ByVal nislem As Integer, ByVal nTeslimatID As Int64)
        Dim OpenFileDialog1 As New Windows.Forms.OpenFileDialog
        OpenFileDialog1.Title = "Rapor Seç..."
        OpenFileDialog1.Filter = "Rapor Dosyaları (KasaTeslim*.fr*) |KasaTeslim*.fr*"
        OpenFileDialog1.FileName = "c:\Formlar\Raporlar\NakitKasa\KasaTeslim" & sRaporUzanti & ""
        OpenFileDialog1.InitialDirectory = "c:\Formlar\Raporlar\NakitKasa"
        If OpenFileDialog1.ShowDialog = Windows.Forms.DialogResult.OK Then
            Dim sFile = OpenFileDialog1.FileName.ToString
            Dim dr As DataRow
            dr = GridView1.GetDataRow(GridView1.FocusedRowHandle)
            If Microsoft.VisualBasic.Right(sFile, 3) = "frx" Then
                Dim report As New FastReport.Report
                report.Load(sFile)
                report.RegisterData(ds_tbParamGenel)
                Dim ds_baslik As DataSet = sorgu(sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT      * FROM         tbMarketKasaTeslimat WHERE     (nTeslimatID = " & nTeslimatID & ")"), "BASLIK")
                Dim ds_hareket As DataSet = Dataload_tbMarketKasaTeslimatDetay(nTeslimatID, False)
                report.RegisterData(ds_baslik, "BASLIK")
                report.RegisterData(ds_hareket, "HAREKET")
                report.SetParameterValue("dteIslemTarihi", DateEdit1.EditValue)
                report.SetParameterValue("sMagaza", sec_sDepo.Text)
                report.SetParameterValue("nKasaNo", sec_nKasaNo.Text)
                report.SetParameterValue("sKasiyerRumuzu", sec_sKasiyerRumuzu.Text)
                report.SetParameterValue("sAciklama", txt_sAciklama.Text)
                report.ScriptLanguage = Language.Vb
                If nislem = 0 Then
                    report.Show()
                ElseIf nislem = 2 Then
                    report.Design()
                ElseIf nislem = 1 Then
                    report.Print()
                End If
                report.Dispose()
                report = Nothing
                'ElseIf Microsoft.VisualBasic.Right(sFile, 3) = "fr3" Then
                '    report_create_stok(sFile, " WHERE nKasaIslemID = " & dr("nKasaIslemID") & "", nislem, dr("lTahsilTutar"), dr("lTediyeTutar"))
            End If
        End If
    End Sub
    Private Sub raporla_excel()
        If XtraMessageBox.Show(Sorgu_sDil("Sonuçları Excel Dosyası Oluşturmak İstediğinize Emin misiniz...?", sDil), Sorgu_sDil("Dikkat", sDil), MessageBoxButtons.YesNo, MessageBoxIcon.Question) = MsgBoxResult.Yes Then
            Dim SaveFileDialog1 As New Windows.Forms.SaveFileDialog
            SaveFileDialog1.Filter = "Excel Dosyaları(*.xls) |*.xls"
            SaveFileDialog1.InitialDirectory = "c:\"
            SaveFileDialog1.FileName = "Rapor.xls"
            If SaveFileDialog1.ShowDialog = Windows.Forms.DialogResult.OK Then
                GridView1.ExportToXls(SaveFileDialog1.FileName.ToString)
                If XtraMessageBox.Show(Sorgu_sDil("Kaydı Açmak İster misiniz...?", sDil), Sorgu_sDil("Dikkat", sDil), MessageBoxButtons.YesNo, MessageBoxIcon.Question) = MsgBoxResult.Yes Then
                    Process.Start(SaveFileDialog1.FileName.ToString)
                End If
            End If
            SaveFileDialog1 = Nothing
        End If
    End Sub
    Private Sub raporla_text()
        If XtraMessageBox.Show(Sorgu_sDil("Sonuçları Text Dosyası Oluşturmak İstediğinize Emin misiniz...?", sDil), Sorgu_sDil("Dikkat", sDil), MessageBoxButtons.YesNo, MessageBoxIcon.Question) = MsgBoxResult.Yes Then
            Dim SaveFileDialog1 As New Windows.Forms.SaveFileDialog
            SaveFileDialog1.Filter = "Text Dosyaları(*.txt) |*.txt"
            SaveFileDialog1.InitialDirectory = "c:\"
            SaveFileDialog1.FileName = "Rapor.txt"
            If SaveFileDialog1.ShowDialog = Windows.Forms.DialogResult.OK Then
                GridView1.ExportToText(SaveFileDialog1.FileName.ToString)
                If XtraMessageBox.Show(Sorgu_sDil("Kaydı Açmak İster misiniz...?", sDil), Sorgu_sDil("Dikkat", sDil), MessageBoxButtons.YesNo, MessageBoxIcon.Question) = MsgBoxResult.Yes Then
                    Process.Start(SaveFileDialog1.FileName.ToString)
                End If
            End If
            SaveFileDialog1 = Nothing
        End If
    End Sub
    Private Sub raporla_pdf()
        If XtraMessageBox.Show(Sorgu_sDil("Sonuçları Metin Dosyası Oluşturmak İstediğinize Emin misiniz...?", sDil), Sorgu_sDil("Dikkat", sDil), MessageBoxButtons.YesNo, MessageBoxIcon.Question) = MsgBoxResult.Yes Then
            Dim SaveFileDialog1 As New Windows.Forms.SaveFileDialog
            SaveFileDialog1.Filter = "Metin Dosyaları(*.pdf) |*.pdf"
            SaveFileDialog1.InitialDirectory = "c:\"
            SaveFileDialog1.FileName = "Rapor.pdf"
            If SaveFileDialog1.ShowDialog = Windows.Forms.DialogResult.OK Then
                GridView1.ExportToPdf(SaveFileDialog1.FileName.ToString)
                If XtraMessageBox.Show(Sorgu_sDil("Kaydı Açmak İster misiniz...?", sDil), Sorgu_sDil("Dikkat", sDil), MessageBoxButtons.YesNo, MessageBoxIcon.Question) = MsgBoxResult.Yes Then
                    Process.Start(SaveFileDialog1.FileName.ToString)
                End If
            End If
            SaveFileDialog1 = Nothing
        End If
    End Sub
    Private Sub SimpleButton3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SimpleButton3.Click
        ara()
    End Sub
    Private Sub SimpleButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SimpleButton1.Click
        Me.Close()
    End Sub
    Private Sub SimpleButton2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SimpleButton2.Click
        Me.Close()
    End Sub
    Private Sub BarButtonItem1_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem1.ItemClick
        kayit_ekle()
    End Sub
    Private Sub BarButtonItem2_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem2.ItemClick
        kayit_duzelt()
    End Sub
    Private Sub BarButtonItem3_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem3.ItemClick
        kayit_sil()
    End Sub
    Private Sub SimpleButton4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SimpleButton4.Click
        toplam_hesapla()
        ara()
        XtraTabPage2.PageVisible = False
        XtraTabPage1.PageVisible = True
        GridControl1.Focus()
        GridControl1.Select()
    End Sub
    Private Sub GridView2_CellValueChanged(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs) Handles GridView2.CellValueChanged
        If GridView2.RowCount > 0 Then
            GridView2.PostEditor()
            Dim dr As DataRow
            dr = GridView2.GetDataRow(GridView2.FocusedRowHandle)
            dr.EndEdit()
            tutar_hesapla()
            Dim satir = GridView2.FocusedRowHandle
            ds_tbMarketKasaTeslimatDetay = Dataload_tbMarketKasaTeslimatDetay(lbl_nTeslimatID.Text)
            GridControl2.DataSource = ds_tbMarketKasaTeslimatDetay.Tables(0)
            GridControl2.DataMember = Nothing
            GridView2.FocusedRowHandle = satir
            satir = Nothing
        End If
    End Sub
    Private Sub GridView2_FocusedRowChanged(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs) Handles GridView2.FocusedRowChanged
        If GridView2.RowCount > 0 Then
            Dim dr As DataRow
            dr = GridView2.GetDataRow(GridView2.FocusedRowHandle)
            If dr("nOdemeTipi") = 1 Then
                colsAciklama.OptionsColumn.AllowEdit = False
                colsAciklama.OptionsColumn.AllowFocus = False
            ElseIf dr("nOdemeTipi") = 2 Then
                colsAciklama.OptionsColumn.AllowEdit = True
                colsAciklama.OptionsColumn.AllowFocus = True
            ElseIf dr("nOdemeTipi") = 3 Then
                colsAciklama.OptionsColumn.AllowEdit = True
                colsAciklama.OptionsColumn.AllowFocus = True
            ElseIf dr("nOdemeTipi") = 4 Then
                colsAciklama.OptionsColumn.AllowEdit = True
                colsAciklama.OptionsColumn.AllowFocus = True
            ElseIf dr("nOdemeTipi") = 5 Then
                colsAciklama.OptionsColumn.AllowEdit = False
                colsAciklama.OptionsColumn.AllowFocus = False
            ElseIf dr("nOdemeTipi") = 6 Then
                colsAciklama.OptionsColumn.AllowEdit = False
                colsAciklama.OptionsColumn.AllowFocus = False
            ElseIf dr("nOdemeTipi") = 7 Then
                colsAciklama.OptionsColumn.AllowEdit = True
                colsAciklama.OptionsColumn.AllowFocus = True
            ElseIf dr("nOdemeTipi") = 8 Then
                colsAciklama.OptionsColumn.AllowEdit = True
                colsAciklama.OptionsColumn.AllowFocus = True
            End If
        End If
    End Sub
    Private Sub SimpleButton5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        gorunum_yazdir_detay()
    End Sub
    Private Sub BarButtonItem8_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem8.ItemClick
        If XtraTabPage2.PageVisible = False Then
            If GridView2.RowCount > 0 Then
                Dim dr As DataRow = GridView2.GetDataRow(GridView2.FocusedRowHandle)
                raporla_Teslimat(0, 0, dr("nTeslimatID"))
            End If
        ElseIf XtraTabPage2.PageVisible = True Then
            raporla_Teslimat(0, 0, lbl_nTeslimatID.Text)
        End If
    End Sub
    Private Sub BarButtonItem9_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem9.ItemClick
        If XtraTabPage2.PageVisible = False Then
            If GridView2.RowCount > 0 Then
                Dim dr As DataRow = GridView2.GetDataRow(GridView2.FocusedRowHandle)
                raporla_Teslimat(0, 2, dr("nTeslimatID"))
            End If
        ElseIf XtraTabPage2.PageVisible = True Then
            raporla_Teslimat(0, 2, lbl_nTeslimatID.Text)
        End If
    End Sub
    Private Sub BarButtonItem10_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem10.ItemClick
        If XtraTabPage2.PageVisible = False Then
            If GridView2.RowCount > 0 Then
                Dim dr As DataRow = GridView2.GetDataRow(GridView2.FocusedRowHandle)
                raporla_Teslimat(0, 1, dr("nTeslimatID"))
            End If
        ElseIf XtraTabPage2.PageVisible = True Then
            raporla_Teslimat(0, 1, lbl_nTeslimatID.Text)
        End If
    End Sub
    Private Sub BarButtonItem4_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem4.ItemClick
        gorunum_yazdir()
    End Sub
    Private Sub BarButtonItem6_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem6.ItemClick
        raporla_excel()
    End Sub
    Private Sub BarButtonItem7_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem7.ItemClick
        raporla_pdf()
    End Sub
    Private Sub GridView1_CustomDrawRowIndicator(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Grid.RowIndicatorCustomDrawEventArgs) Handles GridView1.CustomDrawRowIndicator
        If e.RowHandle >= 0 Then
            e.Info.DisplayText = e.RowHandle + 1
        Else
            e.Info.DisplayText = ""
        End If
    End Sub
    Private Sub EkleToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EkleToolStripMenuItem.Click
        kayit_ekle()
    End Sub
    Private Sub DuzeltToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DuzeltToolStripMenuItem.Click
        kayit_duzelt()
    End Sub
    Private Sub SilToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SilToolStripMenuItem.Click
        kayit_sil()
    End Sub
    Private Sub GörünümüDüzenleToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GörünümüDüzenleToolStripMenuItem.Click
        GridView1.ColumnsCustomization()
    End Sub
    Private Sub GörünümüKaydetToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GörünümüKaydetToolStripMenuItem.Click
        gorunum_kaydet()
    End Sub
    Private Sub GörünümüYazdırToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GörünümüYazdırToolStripMenuItem.Click
        gorunum_yazdir()
    End Sub
    Private Sub HızlıFiltreToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles HızlıFiltreToolStripMenuItem.Click
        If HızlıFiltreToolStripMenuItem.Checked = False Then
            GridView1.OptionsCustomization.AllowFilter = True
            GridView1.OptionsView.ShowFilterPanelMode = DevExpress.XtraGrid.Views.Base.ShowFilterPanelMode.Default
            GridView1.OptionsView.ShowAutoFilterRow = True
            HızlıFiltreToolStripMenuItem.Checked = True
        ElseIf HızlıFiltreToolStripMenuItem.Checked = True Then
            GridView1.OptionsCustomization.AllowFilter = False
            GridView1.OptionsView.ShowFilterPanelMode = DevExpress.XtraGrid.Views.Base.ShowFilterPanelMode.Never
            GridView1.OptionsView.ShowAutoFilterRow = False
            HızlıFiltreToolStripMenuItem.Checked = False
        End If
    End Sub
    Private Sub MenuItem6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem6.Click
        If MenuItem6.Checked = False Then
            GridView1.OptionsCustomization.AllowFilter = True
            GridView1.OptionsView.ShowFilterPanelMode = DevExpress.XtraGrid.Views.Base.ShowFilterPanelMode.Default
            MenuItem6.Checked = True
        ElseIf MenuItem6.Checked = True Then
            GridView1.OptionsCustomization.AllowFilter = False
            GridView1.OptionsView.ShowFilterPanelMode = DevExpress.XtraGrid.Views.Base.ShowFilterPanelMode.Never
            MenuItem6.Checked = False
        End If
    End Sub
    Private Sub MenuItem7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem7.Click
        If MenuItem7.Checked = False Then
            GridView1.OptionsCustomization.AllowGroup = True
            GridView1.OptionsView.ShowGroupPanel = True
            MenuItem7.Checked = True
        ElseIf MenuItem7.Checked = True Then
            GridView1.OptionsCustomization.AllowGroup = False
            GridView1.OptionsView.ShowGroupPanel = False
            MenuItem7.Checked = False
        End If
    End Sub
    Private Sub MenuItem8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem8.Click
        GridView1.ExpandAllGroups()
    End Sub
    Private Sub MenuItem9_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem9.Click
        GridView1.CollapseAllGroups()
    End Sub
    Private Sub MenuItem10_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem10.Click
        If Me.WindowState = FormWindowState.Normal Then
            Me.WindowState = FormWindowState.Maximized
        ElseIf Me.WindowState = FormWindowState.Maximized Then
            Me.WindowState = FormWindowState.Normal
        End If
    End Sub
    Private Sub SimpleButton5_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SimpleButton5.Click
        satis_getir(DateEdit1.EditValue, sec_sDepo.EditValue, sec_nKasaNo.EditValue, sec_sKasiyerRumuzu.EditValue)
    End Sub
    Private Sub satis_getir(ByVal dteOdemeTarihi As DateTime, ByVal sMagaza As String, ByVal nKasa As Integer, ByVal sKasiyerRumuzu As String)
        Dim ds_tbOdeme As DataSet = sorgu(sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED Select sOdemeSekli,sum(lOdemeTutar) as lOdemeTutar from tbOdeme where sMagaza ='" & sMagaza & "' and nKasaNo = '" & nKasa & "' and dteOdemeTarihi between '" & dteOdemeTarihi & "' and '" & dteOdemeTarihi & "' Group by sOdemeSekli"))
        Dim lNakit As Decimal = 0
        Dim lPos1 As Decimal = 0
        Dim lPos2 As Decimal = 0
        Dim lPos3 As Decimal = 0
        Dim lPos4 As Decimal = 0
        Dim lPos5 As Decimal = 0
        Dim lPos6 As Decimal = 0
        Dim lPos7 As Decimal = 0
        Dim lPos8 As Decimal = 0
        Dim lPos9 As Decimal = 0
        Dim lPos10 As Decimal = 0
        Dim lZToplam As Decimal = 0
        Dim dr As DataRow
        lbl_Nakit.Text = FormatNumber(lNakit, 2)
        lbl_Pos1.Text = FormatNumber(lPos1, 2)
        lbl_Pos2.Text = FormatNumber(lPos2, 2)
        lbl_Pos3.Text = FormatNumber(lPos3, 2)
        lbl_Pos4.Text = FormatNumber(lPos4, 2)
        lbl_Pos5.Text = FormatNumber(lPos5, 2)
        lbl_Pos6.Text = FormatNumber(lPos6, 2)
        lbl_Pos7.Text = FormatNumber(lPos7, 2)
        lbl_PosT.Text = FormatNumber(0, 2)
        lbl_GenelToplam.Text = FormatNumber(lZToplam, 2)
        lbl_lDevir.Text = FormatNumber(sorgula_Decimal("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED  SELECT     TOP 1 ISNULL(tbMarketKasaTeslimatDetay.lMiktar,0) FROM         tbMarketKasaTeslimat INNER JOIN                       tbMarketKasaTeslimatDetay ON tbMarketKasaTeslimat.nTeslimatID = tbMarketKasaTeslimatDetay.nTeslimatID WHERE     (tbMarketKasaTeslimatDetay.sOdemeSekli = 'OFF') AND (tbMarketKasaTeslimat.dteFisTarihi < '" & dteOdemeTarihi & "') AND (tbMarketKasaTeslimat.sKasiyerRumuzu = '" & sKasiyerRumuzu & "') ORDER BY tbMarketKasaTeslimat.dteFisTarihi DESC"), 2)
        For Each dr In ds_tbOdeme.Tables(0).Rows
            If Trim(dr("sOdemeSekli")) = "N" Then
                lNakit = sorgu_sayi(dr("lOdemeTutar"), 0)
                lbl_Nakit.Text = FormatNumber(lNakit, 2)
            ElseIf Trim(dr("sOdemeSekli")) = "1" Then
                lPos1 = sorgu_sayi(dr("lOdemeTutar"), 0)
                lbl_Pos1.Text = FormatNumber(lPos1, 2)
            ElseIf Trim(dr("sOdemeSekli")) = "2" Then
                lPos2 = sorgu_sayi(dr("lOdemeTutar"), 0)
                lbl_Pos2.Text = FormatNumber(lPos2, 2)
            ElseIf Trim(dr("sOdemeSekli")) = "3" Then
                lPos3 = sorgu_sayi(dr("lOdemeTutar"), 0)
                lbl_Pos3.Text = FormatNumber(lPos3, 2)
            ElseIf Trim(dr("sOdemeSekli")) = "4" Then
                lPos4 = sorgu_sayi(dr("lOdemeTutar"), 0)
                lbl_Pos4.Text = FormatNumber(lPos4, 2)
            ElseIf Trim(dr("sOdemeSekli")) = "5" Then
                lPos5 = sorgu_sayi(dr("lOdemeTutar"), 0)
                lbl_Pos5.Text = FormatNumber(lPos5, 2)
            ElseIf Trim(dr("sOdemeSekli")) = "6" Then
                lPos6 = sorgu_sayi(dr("lOdemeTutar"), 0)
                lbl_Pos6.Text = FormatNumber(lPos6, 2)
            ElseIf Trim(dr("sOdemeSekli")) = "7" Then
                lPos7 = sorgu_sayi(dr("lOdemeTutar"), 0)
                lbl_Pos7.Text = FormatNumber(lPos7, 2)
            ElseIf Trim(dr("sOdemeSekli")) = "8" Then
                lPos8 = sorgu_sayi(dr("lOdemeTutar"), 0)
                'lbl_Pos8.Text = FormatNumber(lPos8, 2)
            ElseIf Trim(dr("sOdemeSekli")) = "9" Then
                lPos9 = sorgu_sayi(dr("lOdemeTutar"), 0)
                'lbl_Pos9.Text = FormatNumber(lPos9, 2)
            ElseIf Trim(dr("sOdemeSekli")) = "10" Then
                lPos10 = sorgu_sayi(dr("lOdemeTutar"), 0)
            End If
            lZToplam = lZToplam + sorgu_sayi(dr("lOdemeTutar"), 0)
        Next
        lbl_GenelToplam.Text = FormatNumber(lZToplam, 2)
        lbl_PosT.Text = FormatNumber(lPos1 + lPos2 + lPos3 + lPos4 + lPos5 + lPos6 + lPos7 + lPos8 + lPos9 + lPos10, 2)
    End Sub
    Private Sub GridControl1_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles GridControl1.DoubleClick
        kayit_duzelt()
    End Sub
    Private Sub KilitleToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles KilitleToolStripMenuItem.Click
        If kullanici < 3 Then
            If XtraMessageBox.Show(Sorgu_sDil("Seçili Fiş Kayıtlarını Kilitlemek İstediğinize Emin misiniz...?", sDil), Sorgu_sDil("Dikkat", sDil), MessageBoxButtons.YesNo, MessageBoxIcon.Question) Then
                satirlar_kilit(1)
            End If
        End If
    End Sub
    Private Sub KilitKaldırToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles KilitKaldırToolStripMenuItem.Click
        If kullanici < 3 Then
            If XtraMessageBox.Show(Sorgu_sDil("Seçili Fiş Kayıtlarının Kilitlerini Kaldırmak İstediğinize Emin misiniz...?", sDil), Sorgu_sDil("Dikkat", sDil), MessageBoxButtons.YesNo, MessageBoxIcon.Question) Then
                satirlar_kilit(0)
            End If
        End If
    End Sub
    Private Sub satirlar_kilit(ByVal bKilitli As Byte)
        Dim arr As Integer()
        Dim i As Integer
        Dim sayi As Integer = 0
        Dim nFirmaID As String = ""
        Dim s As String = ""
        Dim dr As DataRow
        arr = GridView1.GetSelectedRows()
        If arr Is Nothing Then
        Else
            Array.Sort(arr)
            For Each i In arr
                s = i.ToString
                dr = GridView1.GetDataRow(s)
                tbMarketKasaTeslimat_Kilit(dr("nTeslimatID"), bKilitli)
            Next
        End If
        ara()
        XtraMessageBox.Show(Sorgu_sDil("İşlem Başarıyla Tamamlandı", sDil), Sorgu_sDil("Dikkat", sDil), MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub
    Private Sub tbMarketKasaTeslimat_Kilit(ByVal nTeslimatID As String, ByVal bKilitli As Byte)
        Dim conn As New OleDb.OleDbConnection
        Dim cmd As New OleDb.OleDbCommand
        conn.ConnectionString = connection
        cmd.Connection = conn
        If conn.State = ConnectionState.Closed Then
            conn.Open()
        End If
        cmd.CommandText = sorgu_query("SET DATEFORMAT DMY SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED Update tbMarketKasaTeslimat set bKilitli = " & bKilitli & " where nTeslimatID  =" & nTeslimatID & "")
        cmd.ExecuteNonQuery()
        conn.Close()
        cmd = Nothing
    End Sub
    Private Sub sec_bEntegre_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles sec_bEntegre.CheckedChanged
        'GroupControl6.Visible = True
        txt_dteBordroTarihi.EditValue = DateEdit1.EditValue
        sec_sSubeMagaza.EditValue = Microsoft.VisualBasic.Right(sec_sDepo.EditValue, 3)
        sec_sSubeMagaza.Focus()
        sec_sSubeMagaza.Select()
    End Sub
    Private Sub entegre(ByVal sSubeMagaza As String, ByVal dteBordroTarihi As DateTime, ByVal sAciklama As String)
        If sec_bNakitler.Checked = True Then
            Entegre_Nakit(sSubeMagaza, dteBordroTarihi, sAciklama)
        End If
        If sec_bPoslar.Checked = True Or sec_bKesintiDus.Checked = True Then
            entegre_Pos(sSubeMagaza, dteBordroTarihi, sAciklama)
        End If
        toplam_hesapla()
    End Sub
    Private Sub Entegre_Nakit(ByVal sSubeMagaza As String, ByVal dteBordroTarihi As DateTime, ByVal sAciklama As String)
        ds_OdemeSekli = sorgu(sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT tbOdeme.sOdemeSekli, tbOdeme.nOdemeTipi,tbOdeme.sAciklama, tbOdeme.nFirmaID,tbFirma.nFirmaID AS nHesapID, tbFirma.nHesapID AS nKesintiHesapID FROM aEmirOdemeSekliFirma tbOdeme INNER JOIN tbFirma ON tbOdeme.KnFirmaID = tbFirma.nFirmaID")) '.Tables(0)
        Dim dr As DataRow
        Dim lNakit As Decimal = 0
        Dim lKredi As Decimal = 0
        Dim sOdemeSekli As String = ""
        Dim sFisTipi As String = "TCG"
        Dim nGirisCikis As Int64 = 1
        'Dim dteBordroTarihi As DateTime = Today
        Dim nBordroID As Int64 = 0
        Dim lBordroNo As Int64 = sorgu_lBordroNo()
        Dim nFirmaID As Int64 = 0
        sAciklama += sec_sDepo.EditValue & "\" & sec_sKasiyerRumuzu.Text & "\" & sec_nKasaNo.EditValue
        nBordroID = tbFirmaBordroMaster_kaydet_yeni(dteBordroTarihi, lBordroNo, sFisTipi, nGirisCikis, "", -1, sAciklama, "", "", "", "", "", Now, 0, sSubeMagaza, sHareketTipi)
        'For Each dr In ds_tbMarketKasaTeslimatDetay.Tables(0).Rows
        '    If dr("nOdemeTipi").ToString = "Ödemeler" Then
        '        If dr("IZAHAT").ToString = "N" Then
        lNakit = CDec(lbl_lNakitPara.Text) + CDec(lbl_lOdemeler.Text)
        nFirmaID = cari_kontrol("100-" & sec_sSubeMagaza.EditValue)
        tbFirmaBordroDetay_kaydet(nFirmaID, sFisTipi, "N", lNakit, nBordroID, dteBordroTarihi, lBordroNo, sAciklama, sec_sSubeMagaza.EditValue)
        '        End If
        '    End If
        'Next
        XtraMessageBox.Show(Sorgu_sDil("Kasa Entegre İşlemi Başarıyla Tamamlandı...!", sDil), Sorgu_sDil("Dikkat", sDil), MessageBoxButtons.OK, MessageBoxIcon.Information)
        analiz_fis(nBordroID, sFisTipi, nGirisCikis)
    End Sub
    Private Sub entegre_Pos(ByVal sSubeMagaza As String, ByVal dteBordroTarihi As DateTime, ByVal sAciklama As String)
        ds_OdemeSekli = sorgu(sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT tbOdeme.sOdemeSekli, tbOdeme.nOdemeTipi,tbOdeme.sAciklama, tbOdeme.nFirmaID,tbFirma.nFirmaID AS nHesapID, tbFirma.nHesapID AS nKesintiHesapID FROM aEmirOdemeSekliFirma tbOdeme INNER JOIN tbFirma ON tbOdeme.KnFirmaID = tbFirma.nFirmaID")) '.Tables(0)
        Dim dr As DataRow
        Dim lNakit As Decimal = 0
        Dim lKredi As Decimal = 0
        Dim sOdemeSekli As String = ""
        Dim sFisTipi As String = "TCC"
        Dim nGirisCikis As Int64 = 3
        'Dim dteBordroTarihi As DateTime = Today
        Dim nBordroID As Int64 = 0
        Dim lBordroNo As Int64 = sorgu_lBordroNo()
        Dim nFirmaID As Int64 = 0
        sAciklama += sec_sDepo.EditValue & "\" & sec_sKasiyerRumuzu.Text & "\" & sec_nKasaNo.EditValue
        nBordroID = tbFirmaBordroMaster_kaydet_yeni(dteBordroTarihi, lBordroNo, sFisTipi, nGirisCikis, "", -1, sAciklama, "", "", "", "", "", Now, 0, sSubeMagaza, sHareketTipi)
        For Each dr In ds_tbMarketKasaTeslimatDetay.Tables(0).Rows
            If dr("nOdemeTipi").ToString = "2" And dr("lMiktar") > 0 And dr("nFirmaID") > 0 Then
                If dr("sOdemeSekli").ToString = "N" Then
                ElseIf dr("sOdemeSekli").ToString = "" Then
                Else
                    nOdemeTipi = 0
                    sOdemeSekli = dr("sOdemeSekli").ToString
                    nKesintiHesaplari(dr("sOdemeSekli").ToString)
                    If nOdemeTipi = 2 Then
                        lKredi = sorgu_sayi(dr("lMiktar"), 0)
                        nFirmaID = dr("nFirmaID")
                        If sec_bKesintiDus.Checked = True Then
                            Dim lKesinti As Decimal = tbAVTaksitKart_Olustur(sOdemeSekli, lKredi, dteBordroTarihi)
                            If lKesinti = 0 Then
                                tbFirmaBordroDetay_kaydet(nFirmaID, sFisTipi, sOdemeSekli, dr("lMiktar"), nBordroID, dteBordroTarihi, lBordroNo, sAciklama, sec_sSubeMagaza.EditValue)
                            Else
                                nFirmaID = nBankaFirmaID
                                tbFirmaBordroDetay_kaydet(nFirmaID, sFisTipi, sOdemeSekli, lKredi - lKesinti, nBordroID, dteBordroTarihi, lBordroNo, sAciklama, sec_sSubeMagaza.EditValue)
                                nFirmaID = nKesintiFirmaID
                                tbFirmaBordroDetay_kaydet(nFirmaID, sFisTipi, sOdemeSekli, lKesinti, nBordroID, dteBordroTarihi, lBordroNo, sAciklama, sec_sSubeMagaza.EditValue)
                            End If
                        Else
                            tbFirmaBordroDetay_kaydet(nFirmaID, sFisTipi, sOdemeSekli, dr("lMiktar"), nBordroID, dteBordroTarihi, lBordroNo, sAciklama, sec_sSubeMagaza.EditValue)
                        End If
                    End If
                End If
            ElseIf dr("nOdemeTipi") = 3 And dr("lMiktar") > 0 And dr("nFirmaID") > 0 And sec_bOdemeler.Checked = True Then
                sOdemeSekli = "N"
                nFirmaID = dr("nFirmaID")
                sAciklama = Microsoft.VisualBasic.Left(sec_sDepo.EditValue & "\" & sec_sKasiyerRumuzu.Text & "\" & sec_nKasaNo.EditValue & "\" & dr("sAciklama"), 60)
                tbFirmaBordroDetay_kaydet(nFirmaID, sFisTipi, sOdemeSekli, dr("lMiktar"), nBordroID, dteBordroTarihi, lBordroNo, sAciklama, sec_sSubeMagaza.EditValue)
            End If
        Next
        XtraMessageBox.Show(Sorgu_sDil("Pos/Ödemeler Entegre İşlemi Başarıyla Tamamlandı...!", sDil), Sorgu_sDil("Dikkat", sDil), MessageBoxButtons.OK, MessageBoxIcon.Information)
        analiz_fis(nBordroID, sFisTipi, nGirisCikis)
    End Sub
    Private Sub analiz_fis(ByVal nBordroID As Int64, ByVal sFisTipi As String, ByVal nGirisCikis As Int64)
        Dim dr As DataRow = GridView1.GetDataRow(GridView1.FocusedRowHandle)
        Dim frm As New frm_tbFirmaBordro
        frm.firmano = firmano
        frm.donemno = donemno
        frm.connection = connection
        frm.kullanici = kullanici
        frm.sFisTipi = sFisTipi
        frm.nGirisCikis = nGirisCikis
        frm.nBordroID = nBordroID
        frm.sFisTipi = sFisTipi
        frm.nGirisCikis = nGirisCikis
        If yetki_kontrol(kullanici, frm.Name) = True Then
            frm.ShowDialog()
        End If
        frm.Close()
        frm.Dispose()
        frm = Nothing
    End Sub
    Private Sub tbFirmaBordroDetay_kaydet(ByVal nFirmaID As Int64, ByVal sFisTipi As String, ByVal sCariIslem As String, ByVal lTutar As Decimal, ByVal nBordroID As Int64, ByVal dteBordroTarihi As DateTime, ByVal lBordroNo As Int64, ByVal sAciklama As String, ByVal sSubeMagaza As String)
        Dim nHareketID As Int64 = sorgu_nCariHareketID()
        Dim nKasaIslemID As String = ""
        Dim nBordroSatirID As String = ""
        sAciklama = Microsoft.VisualBasic.Left(dteBordroTarihi & "\" & sAciklama, 59)
        Dim sEvrakNo As String = lBordroNo
        Dim nHesapID As Int64 = 0
        Try
            sorgula_nStokID("INSERT INTO tbCariIslem                       (sCariIslem, sAciklama) VALUES     ('" & sCariIslem & "', '')")
        Catch ex As Exception
        End Try
        If sCariIslem = "N" Then
            nKasaIslemID = sorgu_nKasaIslemID()
        Else
            nKasaIslemID = ""
        End If
        Dim lBorcTutar As Decimal = 0
        Dim lAlacakTutar As Decimal = 0
        If Trim(sFisTipi) = "TCG" Then
            lBorcTutar = 0
            lAlacakTutar = lTutar
        ElseIf Trim(sFisTipi) = "TCC" Then
            lBorcTutar = lTutar
            lAlacakTutar = 0
        End If
        tbFirmaBordroDetay_kaydet_yeni(0, nBordroID, nHareketID, nKasaIslemID, nBordroSatirID, nFirmaID, dteBordroTarihi, dteBordroTarihi, sCariIslem, sAciklama, lBorcTutar, lAlacakTutar, sEvrakNo, 0, sFisTipi, sHareketTipi, kullaniciadi, Now, "", 0, 0, "", 0, 0, kullaniciadi, Now)
        nHareketID = tbFirmaHareketi_kaydet_yeni(nHareketID, nFirmaID, dteBordroTarihi, dteBordroTarihi, sCariIslem, sAciklama, lBorcTutar, lAlacakTutar, sEvrakNo, 0, sFisTipi, sHareketTipi, kullaniciadi, Now, "", 0, 0, "", 0, 0, kullaniciadi, Now)
        nCariHareketID_degistir(nHareketID)
        If sCariIslem = "N" Then
            nKasaIslemID = tbNakitKasa_kaydet_yeni(nKasaIslemID, sSubeMagaza, dteBordroTarihi, lAlacakTutar, lBorcTutar, sAciklama, nHareketID, nFirmaID, nHesapID, sFisTipi, sHareketTipi, kullaniciadi, Now, 0, "", "", 0, 0, "", 0, 0, kullaniciadi, Now)
        Else
            nKasaIslemID = ""
        End If
    End Sub
    Private Sub nCariHareketID_degistir(ByVal nCariHareketID As String)
        Dim con As New OleDb.OleDbConnection
        Dim cmd As New OleDb.OleDbCommand
        Dim adapter As New OleDb.OleDbDataAdapter
        con.ConnectionString = connection
        cmd.Connection = con
        If con.State = ConnectionState.Closed Then
            con.Open()
        End If
        cmd.CommandText = sorgu_query("SET DATEFORMAT DMY SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED UPDATE    tbCariSiraNo SET              nSonID = '" & nCariHareketID & "' where nSiraIndex = 1")
        cmd.ExecuteNonQuery()
        con.Close()
    End Sub
    Public Function sorgu_nCariHareketID() As Int64
        Dim kriter As String = ""
        Dim con As New OleDb.OleDbConnection
        Dim cmd As New OleDb.OleDbCommand
        Dim adapter As New OleDb.OleDbDataAdapter
        con.ConnectionString = connection
        cmd.CommandTimeout = Nothing
        cmd.Connection = con
        con.Open()
        cmd.CommandText = sorgu_query("SET DATEFORMAT DMY SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT     ISNULL(MAX(nHareketID), 0) + 1 AS nCariHareketID FROM         tbFirmaHareketi")
        Dim kayitsayisi = cmd.ExecuteScalar
        Return kayitsayisi
        con.Dispose()
        cmd.Dispose()
        adapter.Dispose()
        cmd = Nothing
    End Function
    Public Function sorgu_lBordroNo() As Int64
        Dim kriter As String = ""
        'kriter = "WHERE (sKodu = '" & kod & "')  "
        Dim conn As New OleDb.OleDbConnection
        Dim cmd As New OleDb.OleDbCommand
        Dim adapter As New OleDb.OleDbDataAdapter
        'MsgBox(connection_resmi)
        conn.ConnectionString = connection
        cmd.Connection = conn
        conn.Open()
        cmd.CommandText = sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT TOP 1 ISNULL(lBordroNo + 1, 1) AS lBordroNo FROM tbCekSenetBordro ORDER BY lBordroNo DESC")
        Dim kayitsayisi = cmd.ExecuteScalar
        If kayitsayisi = 0 Then
            kayitsayisi = 1
        End If
        Return kayitsayisi
    End Function
    Public Function sorgu_nKasaIslemID() As Int64
        'Dim kriter As String = ""
        ''kriter = "WHERE (sKodu = '" & kod & "')  "
        'Dim conn As New OleDb.OleDbConnection
        'Dim cmd As New OleDb.OleDbCommand
        'Dim adapter As New OleDb.OleDbDataAdapter
        ''MsgBox(connection_resmi)
        'conn.ConnectionString = sConnection
        'cmd.Connection = conn
        'conn.Open()
        'cmd.CommandText = sorgu_query("SET DATEFORMAT DMY SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT      ISNULL(MAX(nKasaIslemID) + 1, 0) AS nKasaIslemID  FROM         tbNakitKasa ")
        'Dim kayitsayisi = cmd.ExecuteScalar
        ''cmd.CommandText = sorgu_query("SET DATEFORMAT DMY SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT     ISNULL(nSonID,0) + 1 AS nKasaIslemID FROM         tbCariSiraNo WHERE     (nSiraIndex = 2)")
        ''Dim kayitsayisi = cmd.ExecuteScalar
        'If kayitsayisi = 0 Then
        '    kayitsayisi = 1
        'End If
        'Return kayitsayisi
        Return 1
    End Function
    Private Sub nKesintiHesaplari(ByVal sOdemeSekli As String)
        Dim dr As DataRow
        For Each dr In ds_OdemeSekli.Tables(0).Rows
            If Trim(dr("sOdemeSekli")) = Trim(sOdemeSekli) Then
                nOdemeTipi = dr("nOdemeTipi")
                nBankaFirmaID = dr("nFirmaID")
                nKesintiFirmaID = dr("nHesapID")
                nKesintiHesapID = dr("nKesintiHesapID")
            End If
        Next
    End Sub
    Private Function cari_kontrol(ByVal sKodu As String) As Int64
        Dim cari_kayit_sayisi As Int64 = 0
        Dim nFirmaID As Int64 = 0
        cari_kayit_sayisi = sorgula_nStokID("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED Select ISNULL(nFirmaID,0) from tbFirma Where sKodu = '" & sKodu & "'")
        If cari_kayit_sayisi = 0 Then
            nFirmaID = firma_kaydet_yeni(sKodu, "Kasiyer Kasaları", 0, 0, "01/01/1900", 0, "", "", "", "", "", "", "", "", "", 0, "", kullanici, Now, "")
            firma_siniflari_kaydet_yeni(nFirmaID, "", "", "", "", "")
        Else
            nFirmaID = cari_kayit_sayisi
        End If
        Return nFirmaID
    End Function
    Private Function firma_kaydet_yeni(ByVal sKodu As String, ByVal sAciklama As String, ByVal nOzelIskontosu As Decimal, ByVal lKrediLimiti As Decimal, ByVal dteMutabakatTarihi As DateTime, ByVal nVadeGun As Int64, ByVal sHitap As String, ByVal sAdres1 As String, ByVal sAdres2 As String, ByVal sSemt As String, ByVal sIl As String, ByVal sUlke As String, ByVal sPostaKodu As String, ByVal sVergiDairesi As String, ByVal sVergiNo As String, ByVal nHesapID As Int64, ByVal sOzelNot As String, ByVal sKullaniciAdi As String, ByVal dteKayitTarihi As DateTime, ByVal sFiyatTipi As String, Optional ByVal sDatabase As String = "") As Int64
        Dim use As String = ""
        If sDatabase <> "" Then
            use = "USE " & sDatabase
        End If
        Dim cmd As New OleDb.OleDbCommand
        Dim con As New OleDb.OleDbConnection
        cmd.Connection = con
        con.ConnectionString = connection
        If con.State = ConnectionState.Closed = True Then
            con.Open()
        End If
        cmd.CommandText = sorgu_query("" & use & " SET DATEFORMAT DMY INSERT INTO tbFirma                       (sKodu, sAciklama, nOzelIskontosu, lKrediLimiti, dteMutabakatTarihi, nVadeGun, sHitap, sAdres1, sAdres2, sSemt, sIl, sUlke, sPostaKodu, sVergiDairesi, sVergiNo, nHesapID, sOzelNot, sKullaniciAdi, dteKayitTarihi, sFiyatTipi) VALUES     ('" & sKodu & "', N'" & sAciklama & "', " & nOzelIskontosu & ", " & lKrediLimiti & ", '" & dteMutabakatTarihi & "', " & nVadeGun & " , '" & sHitap & "', '" & sAdres1 & "', '" & sAdres2 & "', '" & sSemt & "', '" & sIl & "', '" & sUlke & "', '" & sPostaKodu & "',  '" & sVergiDairesi & "', '" & sVergiNo & "', " & nHesapID & " , '" & sOzelNot & "', '" & sKullaniciAdi & "', '" & dteKayitTarihi & "', '" & sFiyatTipi & "')")
        cmd.ExecuteNonQuery()
        cmd.CommandText = "SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT @@identity"
        Dim hareketno = cmd.ExecuteScalar
        con.Close()
        cmd = Nothing
        con = Nothing
        Return hareketno
        cmd = Nothing
        con = Nothing
    End Function
    Private Sub firma_siniflari_kaydet_yeni(ByVal nFirmaID As String, ByVal sSinifKodu1 As String, ByVal sSinifKodu2 As String, ByVal sSinifKodu3 As String, ByVal sSinifKodu4 As String, ByVal sSinifKodu5 As String, Optional ByVal sDatabase As String = "")
        Dim use As String = ""
        If sDatabase <> "" Then
            use = "USE " & sDatabase
        End If
        Dim cmd As New OleDb.OleDbCommand
        Dim con As New OleDb.OleDbConnection
        cmd.Connection = con
        con.ConnectionString = connection
        If con.State = ConnectionState.Closed = True Then
            con.Open()
        End If
        cmd.CommandText = sorgu_query("" & use & " INSERT INTO tbFirmaSinifi                       (nFirmaID, sSinifKodu1, sSinifKodu2, sSinifKodu3, sSinifKodu4, sSinifKodu5) VALUES     ('" & nFirmaID & "', '" & sSinifKodu1 & "', '" & sSinifKodu2 & "', '" & sSinifKodu3 & "', '" & sSinifKodu4 & "', '" & sSinifKodu5 & "')")
        cmd.ExecuteNonQuery()
        con.Close()
        cmd = Nothing
        con = Nothing
    End Sub
    Private Function tbFirmaBordroMaster_kaydet_yeni(ByVal dteBordroTarihi As DateTime, ByVal lBordroNo As Int64, ByVal sFisTipi As String, ByVal nGirisCikis As Integer, ByVal sSaticiRumuzu As String, ByVal nFirmaID As Integer, ByVal sAciklama1 As String, ByVal sAciklama2 As String, ByVal sAciklama3 As String, ByVal sAciklama4 As String, ByVal sAciklama5 As String, ByVal sKullanici As String, ByVal dteKayitTarihi As DateTime, ByVal bKilitli As Byte, ByVal sSubeMagaza As String, ByVal sHareketTipi As String)
        Dim con As New OleDb.OleDbConnection
        Dim cmd As New OleDb.OleDbCommand
        Dim nKayitNo As Integer = 0
        cmd.Connection = con
        con.ConnectionString = connection
        If con.State = ConnectionState.Closed = True Then
            con.Open()
        End If
        cmd.CommandText = sorgu_query("SET DATEFORMAT DMY SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED INSERT INTO tbFirmaBordroMaster (dteBordroTarihi, lBordroNo, sFisTipi, nGirisCikis, sSaticiRumuzu, nFirmaID, sAciklama1, sAciklama2, sAciklama3, sAciklama4, sAciklama5, sKullanici,  dteKayitTarihi,bKilitli,sSubeMagaza,sHareketTipi) VALUES     ('" & dteBordroTarihi & "', " & lBordroNo & ", '" & sFisTipi & "', " & nGirisCikis & ", '" & sSaticiRumuzu & "', " & nFirmaID & ", '" & sAciklama1 & "', '" & sAciklama2 & "', '" & sAciklama3 & "', '" & sAciklama4 & "', '" & sAciklama5 & "', '" & sKullanici & "', '" & dteKayitTarihi & "'," & bKilitli & ",'" & sSubeMagaza & "','" & sHareketTipi & "')")
        cmd.ExecuteNonQuery()
        cmd.CommandText = "SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT @@identity"
        nKayitNo = cmd.ExecuteScalar
        Return nKayitNo
        con.Close()
    End Function
    Private Function tbFirmaBordroDetay_kaydet_yeni(ByVal nKayitID As Int64, ByVal nBordroID As Int64, ByVal nHareketID As String, ByVal nKasaIslemID As String, ByVal nBordroSatirID As String, ByVal nFirmaID As Int64, ByVal dteIslemTarihi As DateTime, ByVal dteValorTarihi As DateTime, ByVal sCariIslem As String, ByVal sAciklama As String, ByVal lBorcTutar As Decimal, ByVal lAlacakTutar As Decimal, ByVal sEvrakNo As String, ByVal lVadeFarki As Decimal, ByVal sHangiUygulama As String, ByVal sHareketTipi As String, ByVal sKullaniciAdi As String, ByVal dteKayitTarihi As DateTime, ByVal sDovizCinsi1 As String, ByVal lDovizMiktari1 As Decimal, ByVal lDovizKuru1 As Decimal, ByVal sDovizCinsi2 As String, ByVal lDovizMiktari2 As Decimal, ByVal lDovizKuru2 As Decimal, ByVal sSonKullaniciAdi As String, ByVal dteSonUpdateTarihi As DateTime) As Int64
        Dim con As New OleDb.OleDbConnection
        Dim cmd As New OleDb.OleDbCommand
        Dim nKayitNo As Int64 = 0
        cmd.Connection = con
        con.ConnectionString = connection
        If con.State = ConnectionState.Closed = True Then
            con.Open()
        End If
        cmd.CommandText = sorgu_query("SET DATEFORMAT DMY  INSERT INTO tbFirmaBordroDetay                       (nBordroID,nHareketID,nKasaIslemID,nBordroSatirID,nFirmaID, dteIslemTarihi, dteValorTarihi, sCariIslem, sAciklama, lBorcTutar, lAlacakTutar, sEvrakNo, lVadeFarki, sHangiUygulama, sHareketTipi, sKullaniciAdi, dteKayitTarihi, sDovizCinsi1, lDovizMiktari1, lDovizKuru1, sDovizCinsi2, lDovizMiktari2, lDovizKuru2, sSonKullaniciAdi, dteSonUpdateTarihi) VALUES     (" & nBordroID & ",'" & nHareketID & "' ,'" & nKasaIslemID & "','" & nBordroSatirID & "','" & nFirmaID & "', '" & dteIslemTarihi & "', '" & dteValorTarihi & "', '" & sCariIslem & "', N'" & sAciklama & "', " & lBorcTutar & ", " & lAlacakTutar & " , '" & sEvrakNo & "', " & lVadeFarki & ", '" & sHangiUygulama & "', '" & sHareketTipi & "', '" & sKullaniciAdi & "', '" & dteKayitTarihi & "', '" & sDovizCinsi1 & "', " & lDovizMiktari1 & ", " & lDovizKuru1 & " , '" & sDovizCinsi2 & "', " & lDovizMiktari2 & ", " & lDovizKuru2 & " , '" & sSonKullaniciAdi & "', '" & dteSonUpdateTarihi & "')")
        cmd.ExecuteNonQuery()
        cmd.CommandText = "SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT @@identity"
        nKayitNo = cmd.ExecuteScalar
        con.Close()
        Return nKayitNo
    End Function
    Private Function tbNakitKasa_kaydet_yeni(ByVal nKasaIslemID As Int64, ByVal sSube As String, ByVal dteIslemTarihi As DateTime, ByVal lTahsilTutar As Decimal, ByVal lTediyeTutar As Decimal, ByVal sAciklama As String, ByVal nCariHareketID As String, ByVal nFirmaID As Int64, ByVal nHesapID As Int64, ByVal sHangiUygulama As String, ByVal sHareketTipi As String, ByVal sKullaniciAdi As String, ByVal dteKayitTarihi As DateTime, ByVal bMuhasebeyeIslendimi As Byte, ByVal sMasrafYontemi As String, ByVal sDovizCinsi1 As String, ByVal lDovizMiktari1 As Decimal, ByVal lDovizKuru1 As Decimal, ByVal sDovizCinsi2 As String, ByVal lDovizMiktari2 As Decimal, ByVal lDovizKuru2 As Decimal, ByVal sSonKullaniciAdi As String, ByVal dteSonUpdateTarihi As DateTime, Optional ByVal nCekSenetIslem As Integer = 1) As Int64
        Dim con As New OleDb.OleDbConnection
        Dim cmd As New OleDb.OleDbCommand
        cmd.Connection = con
        con.ConnectionString = sConnection
        If con.State = ConnectionState.Closed = True Then
            con.Open()
        End If
        If nCekSenetIslem = 11 Then
            nCariHareketID = "NULL"
        End If
        sAciklama = Microsoft.VisualBasic.Left(sAciklama, 59)
        cmd.CommandText = sorgu_query("SET DATEFORMAT DMY SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED INSERT INTO tbNakitKasa ( sSube, dteIslemTarihi, lTahsilTutar, lTediyeTutar, sAciklama, nCariHareketID, nFirmaID, nHesapID, sHangiUygulama, sHareketTipi, sKullaniciAdi, dteKayitTarihi, bMuhasebeyeIslendimi, sMasrafYontemi, sDovizCinsi1, lDovizMiktari1, lDovizKuru1, sDovizCinsi2, lDovizMiktari2, lDovizKuru2, sSonKullaniciAdi, dteSonUpdateTarihi) VALUES     ( '" & sSube & "', '" & dteIslemTarihi & "', " & lTahsilTutar & ", " & lTediyeTutar & ", N'" & sAciklama & "', " & nCariHareketID & ", " & nFirmaID & ", " & nHesapID & ", '" & sHangiUygulama & "', '" & sHareketTipi & "', '" & sKullaniciAdi & "', '" & dteKayitTarihi & "', " & bMuhasebeyeIslendimi & ", '" & sMasrafYontemi & "', '" & sDovizCinsi1 & "', " & lDovizMiktari1 & ", " & lDovizKuru1 & ", '" & sDovizCinsi2 & "', " & lDovizMiktari2 & ", " & lDovizKuru2 & ", '" & sSonKullaniciAdi & "', '" & dteSonUpdateTarihi & "')")
        cmd.ExecuteNonQuery()
        cmd.CommandText = "SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT @@identity"
        nKasaIslemID = cmd.ExecuteScalar
        Return nKasaIslemID
        con.Close()
        nKasaIslemID_degistir(nKasaIslemID)
    End Function
    Private Sub nKasaIslemID_degistir(ByVal nKasaIslemID As String)
        Dim con As New OleDb.OleDbConnection
        Dim cmd As New OleDb.OleDbCommand
        Dim adapter As New OleDb.OleDbDataAdapter
        con.ConnectionString = connection
        cmd.Connection = con
        If con.State = ConnectionState.Closed Then
            con.Open()
        End If
        cmd.CommandText = sorgu_query("SET DATEFORMAT DMY SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED UPDATE    tbCariSiraNo SET              nSonID = '" & nKasaIslemID & "' where nSiraIndex = 2")
        cmd.ExecuteNonQuery()
        con.Close()
    End Sub
    Private Function tbFirmaHareketi_kaydet_yeni(ByVal nHareketID As Int64, ByVal nFirmaID As Int64, ByVal dteIslemTarihi As DateTime, ByVal dteValorTarihi As DateTime, ByVal sCariIslem As String, ByVal sAciklama As String, ByVal lBorcTutar As Decimal, ByVal lAlacakTutar As Decimal, ByVal sEvrakNo As String, ByVal lVadeFarki As Decimal, ByVal sHangiUygulama As String, ByVal sHareketTipi As String, ByVal sKullaniciAdi As String, ByVal dteKayitTarihi As DateTime, ByVal sDovizCinsi1 As String, ByVal lDovizMiktari1 As Decimal, ByVal lDovizKuru1 As Decimal, ByVal sDovizCinsi2 As String, ByVal lDovizMiktari2 As Decimal, ByVal lDovizKuru2 As Decimal, ByVal sSonKullaniciAdi As String, ByVal dteSonUpdateTarihi As DateTime) As Int64
        Dim con As New OleDb.OleDbConnection
        Dim cmd As New OleDb.OleDbCommand
        cmd.Connection = con
        con.ConnectionString = connection
        If con.State = ConnectionState.Closed = True Then
            con.Open()
        End If
        'If Trim(sCariIslem) = "" Then
        '    sHangiUygulama = 'sFisTipi
        'End If
        If Trim(sDovizCinsi2) <> "" Then
            If lDovizKuru2 = 0 Then
                lDovizKuru2 = 1
            End If
            sDovizCinsi1 = sDovizCinsi2
            lDovizKuru1 = lDovizKuru2
            lDovizMiktari1 = lDovizMiktari2
        End If
        cmd.CommandText = sorgu_query("SET DATEFORMAT DMY  INSERT INTO tbFirmaHareketi                       (nFirmaID, dteIslemTarihi, dteValorTarihi, sCariIslem, sAciklama, lBorcTutar, lAlacakTutar, sEvrakNo, lVadeFarki, sHangiUygulama, sHareketTipi, sKullaniciAdi, dteKayitTarihi, sDovizCinsi1, lDovizMiktari1, lDovizKuru1, sDovizCinsi2, lDovizMiktari2, lDovizKuru2, sSonKullaniciAdi, dteSonUpdateTarihi) VALUES     ('" & nFirmaID & "', '" & dteIslemTarihi & "', '" & dteValorTarihi & "', '" & sCariIslem & "', N'" & sAciklama & "', " & lBorcTutar & ", " & lAlacakTutar & " , '" & sEvrakNo & "', " & lVadeFarki & ", '" & sHangiUygulama & "', '" & sHareketTipi & "', '" & sKullaniciAdi & "', '" & dteKayitTarihi & "', '" & sDovizCinsi1 & "', " & lDovizMiktari1 & ", " & lDovizKuru1 & " , '" & sDovizCinsi2 & "', " & lDovizMiktari2 & ", " & lDovizKuru2 & " , '" & sSonKullaniciAdi & "', '" & dteSonUpdateTarihi & "')")
        cmd.ExecuteNonQuery()
        cmd.CommandText = "SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT @@identity"
        nHareketID = cmd.ExecuteScalar
        Return nHareketID
        con.Close()
    End Function
    Private Function tbAVTaksitKart_Olustur(ByVal sOdemeSekli As String, ByVal lOdemeTutar As Decimal, ByVal dteFisTarihi As DateTime) As Decimal
        Label2.Text = Sorgu_sDil("Lütfen Bekleyiniz...", sDil)
        Label2.Refresh()
        Cursor.Current = Cursors.WaitCursor
        Cursor.Show()
        Dim ds_tbBankaOdemeSekli As DataSet = sorgu(sorgu_query("SET              DATEFIRST 1 SET DATEFORMAT DMY SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT     *,0 as nSatisGun FROM         tbBankaOdemeSekli Where sOdemeSekli = '" & sOdemeSekli & "'"))
        Dim dr As DataRow
        Dim lKesinti As Decimal = 0
        For Each dr In ds_tbBankaOdemeSekli.Tables(0).Rows
            Dim i As Integer
            Dim dteTarihi As DateTime
            Dim TaksitSayisi As Int64 = dr("nTaksitSayisi")
            Dim nTaksitID As String = ""
            Dim dteBaslangic As DateTime = dteFisTarihi
            Dim lTaksitTutari As Decimal = 0
            Dim lIadeTutari As Decimal = 0
            Dim lPuan As Decimal = 0
            Dim lPuanKdv As Decimal = 0
            Dim lServisBedeli As Decimal = 0
            Dim lKomisyonTutari As Decimal = 0
            Dim lKomisyonTutari2 As Decimal = 0
            Dim lKomisyon As Decimal = 0
            Dim lIadeTutar As Decimal = 0
            Dim lNetTutar As Decimal = 0
            Dim bEkle As Boolean = True
            Dim nEkle As Integer = 0
            If lOdemeTutar > 0 Then
                lTaksitTutari = lOdemeTutar / TaksitSayisi
                lIadeTutar = 0
            ElseIf lOdemeTutar < 0 Then
                lIadeTutari = lOdemeTutar / TaksitSayisi
                lTaksitTutari = 0
            End If
            dteTarihi = dteBaslangic
            dr("nSatisGun") = dteFisTarihi.Day
            'Satis Gunu Protokol Kontrolu
            'Cuma
            If dr("nSatisGun") = 5 Then
                If dr("bS_Cuma_Pazar") = False And dr("bs_Cuma_Pazartesi") = False Then
                    dteTarihi = dteBaslangic
                ElseIf dr("bS_Cuma_Pazar") = True And dr("bs_Cuma_Pazartesi") = True Then
                    dteTarihi = DateAdd(DateInterval.Day, 1, dteTarihi)
                    bEkle = False
                ElseIf dr("bS_Cuma_Pazar") = True And dr("bs_Cuma_Pazartesi") = False Then
                    dteTarihi = DateAdd(DateInterval.Day, 2, dteTarihi)
                    bEkle = False
                ElseIf dr("bS_Cuma_Pazar") = False And dr("bs_Cuma_Pazartesi") = True Then
                    dteTarihi = DateAdd(DateInterval.Day, 3, dteTarihi)
                    bEkle = False
                End If
                dteBaslangic = dteTarihi
                'Cumartesi
            ElseIf dr("nSatisGun") = 6 Then
                If dr("bS_Cumartesi_Pazar") = False And dr("bS_Cumartesi_Pazartesi") = False Then
                    dteTarihi = dteBaslangic
                ElseIf dr("bS_Cumartesi_Pazar") = True And dr("bS_Cumartesi_Pazartesi") = False Then
                    dteTarihi = DateAdd(DateInterval.Day, 1, dteTarihi)
                    bEkle = False
                ElseIf dr("bS_Cumartesi_Pazar") = False And dr("bS_Cumartesi_Pazartesi") = True Then
                    dteTarihi = DateAdd(DateInterval.Day, 2, dteTarihi)
                    bEkle = False
                End If
                dteBaslangic = dteTarihi
                'Pazar
            ElseIf dr("nSatisGun") = 7 Then
                If dr("bS_Pazar_Pazartesi") = False Then
                    dteTarihi = dteBaslangic
                ElseIf dr("bS_Pazar_Pazartesi") = True Then
                    dteTarihi = DateAdd(DateInterval.Day, 1, dteTarihi)
                    bEkle = False
                End If
                dteBaslangic = dteTarihi
            End If
            dteBaslangic = dteTarihi
            'Taksit Hesapla
            For i = 1 To TaksitSayisi
                'Bonus Hesapla
                If dr("nBonusOrani") <> 0 Then
                    lPuan = (lOdemeTutar * dr("nBonusOrani")) / 100
                    If dr("nBonus_KdvOrani") <> 0 Then
                        lPuanKdv = (lPuan * dr("nBonus_KdvOrani")) / 100
                    End If
                End If
                'Komisyon Hesapla
                If dr("nKomisyonOrani") <> 0 Then
                    lKomisyonTutari = (lTaksitTutari * dr("nKomisyonOrani")) / 100
                    If dr("nKomisyon_Kdv_Orani") <> 0 Then
                        lKomisyonTutari += (lKomisyonTutari * dr("nKomisyon_Kdv_Orani")) / 100
                    End If
                End If
                lKomisyon = lKomisyonTutari
                'Ek Komisyon Hesapla
                If dr("nKomisyonOrani_2") <> 0 Then
                    If dr("nKomisyonOrani_2_Aciklama") = 0 Then
                        lKomisyonTutari2 += (lOdemeTutar * dr("nKomisyonOrani_2")) / 100
                    ElseIf dr("nKomisyonOrani_2_Aciklama") = 1 Then
                    ElseIf dr("nKomisyonOrani_2_Aciklama") = 2 Then
                        lKomisyonTutari2 += ((lOdemeTutar - lKomisyonTutari) * dr("nKomisyonOrani_2")) / 100
                    End If
                End If
                'Taksit Protokol Kontrolu
                If i > 1 Then
                    If dr("nTaksit") = 2 Then
                        If dr("bTaksit_Satis") = 0 Then
                            If dr("nTaksit" & i & "") <> 0 Then
                                dteTarihi = DateAdd(DateInterval.Day, dr("nTaksit" & i & ""), dteTarihi)
                            Else
                                dteTarihi = DateAdd(DateInterval.Month, 1, dteTarihi)
                            End If
                        ElseIf dr("bTaksit_Satis") <> 0 Then
                            If dr("nTaksit" & i & "") <> 0 Then
                                dteTarihi = DateAdd(DateInterval.Month, 1, dteTarihi)
                            Else
                                dteTarihi = DateAdd(DateInterval.Month, i, dr("dteOdemeTarihi"))
                            End If
                        End If
                    Else
                        dteTarihi = DateAdd(DateInterval.Month, 1, dteTarihi)
                    End If
                    If dr("nBonus_Puan") = 0 Then
                        lPuan = 0
                        lPuanKdv = 0
                    ElseIf dr("nBonus_Puan") = 2 Then
                        lPuan = 0
                        lPuanKdv = 0
                    ElseIf dr("nBonus_Puan") = 3 Then
                        lPuan = 0
                        lPuanKdv = 0
                    End If
                    If dr("bKomisyon_IlkTaksit") = 1 Then
                        lKomisyonTutari = 0
                    End If
                    'ElseIf i = 2 Then
                    '    dteTarihi = DateAdd(DateInterval.Month, 1, dteTarihi)
                    '    'If bEkle = True Then
                    '    '    dteTarihi = DateAdd(DateInterval.Day, 1, dteTarihi)
                    '    'End If
                ElseIf i = 1 Then
                    'İlk Taksit
                    lKomisyonTutari += lKomisyonTutari2
                    If dr("nTaksit") = 0 Then
                        Dim gun As Integer = 0
                        Dim ay As Integer = 0
                        Dim yil As Integer = 0
                        gun = dteTarihi.Day
                        ay = dteTarihi.Month
                        yil = dteTarihi.Year
                        If gun > 0 And dteTarihi.Day <= dr("nAlisGun1") Then
                            If dr("bS_Bulundugu_Ay1") = 0 Then
                                dteTarihi = dr("nTaksitGun1").ToString + "." + (ay + 1).ToString + "." + yil.ToString
                            ElseIf dr("bS_Bulundugu_Ay1") = 1 Then
                                dteTarihi = dr("nTaksitGun1").ToString + "." + (ay).ToString + "." + yil.ToString
                            ElseIf dr("bS_Bulundugu_Ay1") = 2 Then
                                dteTarihi = dr("nTaksitGun1").ToString + "." + (ay + 2).ToString + "." + yil.ToString
                            End If
                        ElseIf gun >= dr("nAlisGun1") And gun <= dr("nAlisGun2") Then
                            If dr("bS_Bulundugu_Ay2") = 0 Then
                                dteTarihi = dr("nTaksitGun2").ToString + "." + (ay + 1).ToString + "." + yil.ToString
                            ElseIf dr("bS_Bulundugu_Ay2") = 1 Then
                                dteTarihi = dr("nTaksitGun2").ToString + "." + (ay).ToString + "." + yil.ToString
                            ElseIf dr("bS_Bulundugu_Ay2") = 2 Then
                                dteTarihi = dr("nTaksitGun2").ToString + "." + (ay + 2).ToString + "." + yil.ToString
                            End If
                        ElseIf gun >= dr("nAlisGun2") And gun <= dr("nAlisGun3") Then
                            If dr("bS_Bulundugu_Ay3") = 0 Then
                                dteTarihi = dr("nTaksitGun3").ToString + "." + (ay + 1).ToString + "." + yil.ToString
                            ElseIf dr("bS_Bulundugu_Ay3") = 1 Then
                                dteTarihi = dr("nTaksitGun3").ToString + "." + (ay).ToString + "." + yil.ToString
                            ElseIf dr("bS_Bulundugu_Ay3") = 2 Then
                                dteTarihi = dr("nTaksitGun3").ToString + "." + (ay + 2).ToString + "." + yil.ToString
                            End If
                        ElseIf gun >= dr("nAlisGun3") And gun <= dr("nAlisGun4") Then
                            If dr("bS_Bulundugu_Ay4") = 0 Then
                                dteTarihi = dr("nTaksitGun4").ToString + "." + (ay + 1).ToString + "." + yil.ToString
                            ElseIf dr("bS_Bulundugu_Ay4") = 1 Then
                                dteTarihi = dr("nTaksitGun4").ToString + "." + (ay).ToString + "." + yil.ToString
                            ElseIf dr("bS_Bulundugu_Ay4") = 2 Then
                                dteTarihi = dr("nTaksitGun4").ToString + "." + (ay + 2).ToString + "." + yil.ToString
                            End If
                        ElseIf gun >= dr("nAlisGun4") And gun <= dr("nAlisGun5") Then
                            If dr("bS_Bulundugu_Ay5") = 0 Then
                                dteTarihi = dr("nTaksitGun5").ToString + "." + (ay + 1).ToString + "." + yil.ToString
                            ElseIf dr("bS_Bulundugu_Ay5") = 1 Then
                                dteTarihi = dr("nTaksitGun5").ToString + "." + (ay).ToString + "." + yil.ToString
                            ElseIf dr("bS_Bulundugu_Ay5") = 2 Then
                                dteTarihi = dr("nTaksitGun5").ToString + "." + (ay + 2).ToString + "." + yil.ToString
                            End If
                        ElseIf gun >= dr("nAlisGun5") And gun <= dr("nAlisGun6") Then
                            If dr("bS_Bulundugu_Ay6") = 0 Then
                                dteTarihi = dr("nTaksitGun6").ToString + "." + (ay + 1).ToString + "." + yil.ToString
                            ElseIf dr("bS_Bulundugu_Ay6") = 1 Then
                                dteTarihi = dr("nTaksitGun6").ToString + "." + (ay).ToString + "." + yil.ToString
                            ElseIf dr("bS_Bulundugu_Ay6") = 2 Then
                                dteTarihi = dr("nTaksitGun6").ToString + "." + (ay + 2).ToString + "." + yil.ToString
                            End If
                        End If
                    ElseIf dr("nTaksit") = 1 Then
                        dteTarihi = DateAdd(DateInterval.Day, dr("nIlkTaksitSonra"), dteBaslangic)
                    ElseIf dr("nTaksit") = 2 Then
                        If dr("bTaksit_Satis") = 0 Then
                            'dteTarihi = DateAdd(DateInterval.Month, 1, dteTarihi)
                            dteTarihi = DateAdd(DateInterval.Day, dr("nTaksit1"), dteBaslangic)
                        ElseIf dr("bTaksit_Satis") = 1 Then
                            'MsgBox(dteBaslangic)
                            'If bEkle = True Then
                            If dr("nSatisGun") = 5 Then
                                dteTarihi = DateAdd(DateInterval.Day, 2, dr("dteOdemeTarihi"))
                                nEkle = 2
                            ElseIf dr("nSatisGun") = 6 Then
                                dteTarihi = DateAdd(DateInterval.Day, 1, dr("dteOdemeTarihi"))
                                nEkle = 1
                            ElseIf dr("nSatisGun") = 7 Then
                                dteTarihi = DateAdd(DateInterval.Day, 0, dr("dteOdemeTarihi"))
                                nEkle = 0
                            End If
                            'End If
                            dteTarihi = DateAdd(DateInterval.Day, dr("nTaksit1"), dteTarihi)
                        ElseIf dr("bTaksit_Satis") = 2 Then
                            dteTarihi = DateAdd(DateInterval.Day, dr("nTaksit1"), dr("dteOdemeTarihi"))
                        End If
                    ElseIf dr("nTaksit") = 3 Then
                        dteTarihi = DateAdd(DateInterval.Month, 1, dteTarihi)
                        dteTarihi = DateAdd(DateInterval.Day, 1, dteTarihi)
                    End If
                End If
                'Servis Bedeli Hesapla
                If dr("nBSMV") <> 0 Then
                    If dr("bServisAlisveristen") = 0 Then
                        lServisBedeli = (lKomisyon * dr("nBSMV")) / 1000
                    ElseIf dr("bServisAlisveristen") = 1 Then
                        lServisBedeli = (lKomisyonTutari * dr("nBSMV")) / 1000
                    ElseIf dr("bServisAlisveristen") = 2 Then
                        lServisBedeli = (lTaksitTutari * dr("nBSMV")) / 100
                    End If
                End If
                'Puan Protokol Kontrolu
                If dr("nBonus_Puan") = 2 Then
                    lPuan = 0
                    lPuanKdv = 0
                ElseIf dr("nBonus_Puan") = 3 Then
                    lPuan = 0
                    lPuanKdv = 0
                End If
                'Taksit Gunu Kontrolu
                If dteTarihi.DayOfWeek = DayOfWeek.Saturday Then
                    If dr("bT_Cumartesi_Pazartesi") = True Then
                        dteTarihi = DateAdd(DateInterval.Day, 2, dteTarihi)
                        nEkle = 2
                    End If
                ElseIf dteTarihi.DayOfWeek = DayOfWeek.Sunday Then
                    If dr("bT_Pazar_Pazartesi") = True Then
                        dteTarihi = DateAdd(DateInterval.Day, 1, dteTarihi)
                        nEkle = 1
                    End If
                End If
                'Ekle
                'tbAVTaksitKart_kaydet_ekle(dr("nOdemeID"), dr("sOdemeSekli"), dteTarihi, lTaksitTutari, lIadeTutari, lPuan, lPuanKdv, lServisBedeli, lKomisyonTutari, 0, kullanici, "01/01/1900", kullanici, Today)
                'If dr("nTaksit") <> 3 Then
                '    If nEkle > 0 Then
                '        dteTarihi = DateAdd(DateInterval.Day, -nEkle, dteTarihi)
                '        nEkle = 0
                '    End If
                'End If
                If dr("nTaksit") = 2 Then
                    If dr("bTaksit_Satis") = 1 Or dr("bTaksit_Satis") = 2 Then
                        If nEkle > 0 Then
                            dteTarihi = DateAdd(DateInterval.Day, -nEkle, dteTarihi)
                            nEkle = 0
                        End If
                    End If
                ElseIf dr("nTaksit") = 0 Then
                    If nEkle > 0 Then
                        dteTarihi = DateAdd(DateInterval.Day, -nEkle, dteTarihi)
                        nEkle = 0
                    End If
                End If
                'Taksit Protokol Kontrolu
                'If i = 1 Then
                '    If bEkle = True Then
                '        dteTarihi = DateAdd(DateInterval.Day, 1, dteTarihi)
                '    End If
                'ElseIf i = 2 Then
                '    If bEkle = True Then
                '        dteTarihi = DateAdd(DateInterval.Day, -1, dteTarihi)
                '    End If
                'End If
            Next
            'Bonus Hesapla
            If dr("nBonusOrani") <> 0 Then
                lPuan = (lOdemeTutar * dr("nBonusOrani")) / 100
                If dr("nBonus_KdvOrani") <> 0 Then
                    lPuanKdv = (lPuan * dr("nBonus_KdvOrani")) / 100
                End If
            End If
            If dr("nBonus_Puan") = 2 Then
                'tbAVTaksitKart_kaydet_ekle(dr("nOdemeID"), dr("sOdemeSekli"), dr("dteOdemeTarihi"), 0, 0, lPuan, lPuanKdv, 0, 0, 0, kullanici, "01/01/1900", kullanici, Today)
                'lbl_lPuan.Text = lPuan
                'lbl_lPuanKdv.Text = lPuanKdv
            ElseIf dr("nBonus_Puan") = 3 Then
                'tbAVTaksitKart_kaydet_ekle(dr("nOdemeID"), dr("sOdemeSekli"), DateAdd(DateInterval.Day, 1, dr("dteOdemeTarihi")), 0, 0, lPuan, lPuanKdv, 0, 0, 0, kullanici, "01/01/1900", kullanici, Today)
                'lbl_lPuan.Text = lPuan
                'lbl_lPuanKdv.Text = lPuanKdv
            End If
            'lbl_dteTarih.Text = dteTarihi
            'lbl_lTaksitTutari.Text = Format(lTaksitTutari, "#,0.00")
            'lbl_lIadeTutari.Text = Format(lIadeTutar, "#,0.00")
            'lbl_lPuan.Text = Format(lPuan, "#,0.00")
            'lbl_lPuanKdv.Text = Format(lPuanKdv, "#,0.00")
            'lbl_lServisBedeli.Text = Format(lServisBedeli, "#,0.00")
            'lbl_lKomisyonTutari.Text = Format(lKomisyonTutari, "#,0.00")
            lNetTutar = lOdemeTutar - (lPuan + lPuanKdv + lServisBedeli + lKomisyonTutari)
            lKesinti = lOdemeTutar - lNetTutar
            'lbl_lNetTutar.Text = Format(lNetTutar, "#,0.00##")
        Next
        Label2.Text = Sorgu_sDil("Tamamlandı...", sDil)
        Cursor.Current = Cursors.Default
        Cursor.Hide()
        Return lKesinti
    End Function
    Private Sub SimpleButton18_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SimpleButton18.Click
        If XtraMessageBox.Show(sec_sSubeMagaza.EditValue & " için Kasa Entegrasyonu İşlemine Başlamak İstediğinize Emin misiniz?", Sorgu_sDil("Dikkat", sDil), MessageBoxButtons.YesNo, MessageBoxIcon.Question) = MsgBoxResult.Yes Then
            'MsgBox("Hazır Değil", Sorgu_sDil("Dikkat", sDil), MessageBoxButtons.OK, MessageBoxIcon.Warning)
            GroupControl6.Visible = False
            GridControl1.Focus()
            GridControl1.Select()
            entegre(sec_sSubeMagaza.EditValue, txt_dteBordroTarihi.EditValue, txt_sAciklama.Text)
        End If
    End Sub
    Private Sub SimpleButton17_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SimpleButton17.Click
        GroupControl6.Visible = False
        GridControl1.Focus()
        GridControl1.Select()
    End Sub
    Private Sub SimpleButton6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SimpleButton6.Click
        GroupControl6.Visible = True
        txt_dteBordroTarihi.EditValue = DateEdit1.EditValue
        sec_sSubeMagaza.EditValue = Microsoft.VisualBasic.Right(sec_sDepo.EditValue, 3)
        sec_sSubeMagaza.Focus()
        sec_sSubeMagaza.Select()
    End Sub
End Class