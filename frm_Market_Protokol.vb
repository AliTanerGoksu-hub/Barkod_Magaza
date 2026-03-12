Imports Microsoft.Win32
Imports DevExpress.XtraEditors
Public Class frm_Market_Protokol
    Public firmano
    Public donemno
    Public kullanici
    Public connection
    Public nFirmaID As Int64 = 0
    Public nStokID As Int64 = 0
    Public sFirmaKodu As String
    Public sFirmaAciklama As String
    Dim cmd As New OleDb.OleDbCommand
    Dim con As New OleDb.OleDbConnection
    Dim dr As DataRow
    Dim ds_tbStokTedarikcisi As DataSet
    Public bFirma As Boolean = False
    Private Sub frm_tbStokTedarik_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        txt_musteriNo.Focus()
        txt_musteriNo.SelectAll()
        Try
            gorunum_yukle()
        Catch ex As Exception
        End Try
        dataload_DovizCinsi()
        If bFirma = False Then
            'colsFirmaKodu.Visible = False
            'colsFirmaAciklama.Visible = False
        Else
            colsKodu.Visible = False
            colsStokAciklama.Visible = False
            colnStokID.Visible = False
            colsModel.Visible = False
            colsRenk.Visible = False
            colsBeden.Visible = False
            colsRenkAdi.Visible = False
            colsFirmaKodu.Visible = True
            colsFirmaAciklama.Visible = True
        End If
        'If bFirma = True And nFirmaID = 0 Then
        '    firma_sec()
        'ElseIf bFirma = False And nStokID = 0 Then
        '    stok_sec()
        'End If
        'If nFirmaID <> 0 Then
        '    ara()
        'ElseIf nStokID <> 0 Then
        '    ara()
        'End If
        sorgu_tbProtokolMarket_kontrol(0)
        ara()
    End Sub
    Public Function sorgu_tbProtokolMarket_kontrol(ByVal nFirmaID As Int64) As Int64
        Dim kriter
        Dim lHediyeCeki As Decimal = 0
        kriter = ""
        Dim conn As New OleDb.OleDbConnection
        Dim cmd As New OleDb.OleDbCommand
        Dim adapter As New OleDb.OleDbDataAdapter
        conn.ConnectionString = connection
        cmd.Connection = conn
        conn.Open()
        cmd.CommandText = sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT ISNULL(COUNT(nStokID),0) AS nKayit FROM tbProtokolMarket ")
        Try
            lHediyeCeki = cmd.ExecuteScalar
        Catch ex As Exception
            cmd.CommandText = "CREATE TABLE [tbProtokolMarket] ([nKayitID] [int] IDENTITY (1, 1) NOT NULL ,[nFirmaID] [int] NOT NULL CONSTRAINT [DF_tbProtokolMarket_nFirmaID] DEFAULT (0),[nIslem] [int] NOT NULL CONSTRAINT [DF_tbProtokolMarket_nIslem] DEFAULT (0),[nStokID] [int] NOT NULL CONSTRAINT [DF_tbProtokolMarket_nStokID] DEFAULT (0),[sDepo] [Depo] NOT NULL CONSTRAINT [DF_tbProtokolMarket_sDepo] DEFAULT (''),[lMiktar] [Miktar] NOT NULL CONSTRAINT [DF_tbProtokolMarket_lMiktar] DEFAULT (0),[nOran] [Yuzde] NOT NULL CONSTRAINT [DF_tbProtokolMarket_nOran] DEFAULT (0),[lMaliyet] [Miktar] NOT NULL CONSTRAINT [DF_tbProtokolMarket_lMaliyet] DEFAULT (0),[lFiyat] [Miktar] NOT NULL CONSTRAINT [DF_tbProtokolMarket_lFiyat] DEFAULT (0),[dteTarih1] [datetime] NOT NULL CONSTRAINT [DF_tbProtokolMarket_dteTarih1] DEFAULT (0),[dteTarih2] [datetime] NOT NULL CONSTRAINT [DF_tbProtokolMarket_dteTarih2] DEFAULT (0),[sAciklama] [varcharUzun] NOT NULL CONSTRAINT [DF_tbProtokolMarket_sAciklama] DEFAULT (''),[sKullaniciAdi] [varcharUzun] NOT NULL CONSTRAINT [DF_tbProtokolMarket_sKullaniciAdi] DEFAULT (0),[dteKayitTarihi] [datetime] NOT NULL CONSTRAINT [DF_tbProtokolMarket_dteKayitTarihi] DEFAULT (0),[bAktif] [bit] NOT NULL CONSTRAINT [DF_tbProtokolMarket_bAktif] DEFAULT (0),CONSTRAINT [PK_tbProtokolMarket] PRIMARY KEY  CLUSTERED (	[nKayitID])  ON [PRIMARY] ,CONSTRAINT [FK_tbProtokolMarket_tbDepo] FOREIGN KEY (	[sDepo]) REFERENCES [tbDepo] (	[sDepo]),CONSTRAINT [FK_tbProtokolMarket_tbFirma] FOREIGN KEY (	[nFirmaID]) REFERENCES [tbFirma] ([nFirmaID]),CONSTRAINT [FK_tbProtokolMarket_tbStok] FOREIGN KEY (	[nStokID]) REFERENCES [tbStok] ([nStokID])) ON [PRIMARY]"""
            cmd.ExecuteNonQuery()
        End Try
        Return lHediyeCeki
    End Function
    Private Sub ara()
        Label2.Text = Sorgu_sDil("Lütfen Bekleyiniz...", sDil)
        Label2.Refresh()
        dataload_tbProtokolMarket(nFirmaID, "", "Kodu", "Başlar")
        GridControl1.Focus()
        GridControl1.Select()
        Label2.Text = Sorgu_sDil("Tamamlandı...", sDil)
    End Sub
    Private Sub gorunum_kaydet()
        GridView1.SaveLayoutToRegistry("SOFTWARE\BusinessSmart\VIEW\MAGAZA\" & Me.Name.ToString & "\" & sec_nIslem.SelectedIndex & " ")
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
                'VGrid_Baslik.Appearance.RecordValue.Font = New System.Drawing.Font("Tahoma", sayi, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
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
        SimpleButton1.Text = Sorgu_sDil(SimpleButton1.Text, sDil)
        SimpleButton2.Text = Sorgu_sDil(SimpleButton2.Text, sDil)
        SimpleButton3.Text = Sorgu_sDil(SimpleButton3.Text, sDil)
        GridView1.RestoreLayoutFromRegistry("SOFTWARE\BusinessSmart\VIEW\MAGAZA\" & Me.Name.ToString & "\" & sec_nIslem.SelectedIndex & " ")
    End Sub
    Private Sub dataload_DovizCinsi()
        sec_sDovizCinsi.DataSource = sorgu(sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT sDovizCinsi, sAciklama FROM tbDovizCinsi ORDER BY sDovizCinsi")).Tables(0) 'DataSet2.Tables(0)
        sec_sFiyatTipi.DataSource = sorgu(sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT sFiyatTipi, sAciklama FROM tbFiyatTipi where (aktif = 1) and (aktifDepo like '%" & Trim(sDepo) & "%') ORDER BY sFiyatTipi")).Tables(0) 'DataSet2.Tables(0)
    End Sub
    Private Sub dataload_tbProtokolMarket(ByVal nFirmaID As String, ByVal ara As String, ByVal konum As String, ByVal ara_kriter As String)
        Dim kriter = " Where (tbStok.sKodu <> '') "
        If bFirma = False And nFirmaID <> 0 Then
            kriter += " and tbFirma.nFirmaID = " & nFirmaID & ""
        End If
        If Trim(ara).ToString <> "" Then
            If konum = "Kod" Then
                kriter += " AND( tbStok.sKodu " & sorgu_kriter_string(ara, ara_kriter) & " )"
            ElseIf konum = "Ad" Then
                kriter += " AND ( tbStok.sAciklama " & sorgu_kriter_string(ara, ara_kriter) & " )"
            ElseIf konum = "Barkod" Then
                kriter += " AND ( tbStokBarkodu.sBarkod " & sorgu_kriter_string(ara, ara_kriter) & " )"
            ElseIf konum = "Sınıf1" Then
                kriter += " AND ( tbSSinif1.sAciklama " & sorgu_kriter_string(ara, ara_kriter) & " )"
            ElseIf konum = "Sınıf2" Then
                kriter += " AND ( tbSSinif2.sAciklama " & sorgu_kriter_string(ara, ara_kriter) & " )"
            ElseIf konum = "Sınıf3" Then
                kriter += " AND ( tbSSinif3.sAciklama " & sorgu_kriter_string(ara, ara_kriter) & " )"
            ElseIf konum = "Sınıf4" Then
                kriter += " AND ( tbSSinif4.sAciklama " & sorgu_kriter_string(ara, ara_kriter) & " )"
            ElseIf konum = "Sınıf5" Then
                kriter += " AND ( tbSSinif5.sAciklama " & sorgu_kriter_string(ara, ara_kriter) & " )"
            ElseIf konum = "Sınıf6" Then
                kriter += " AND ( tbSSinif6.sAciklama " & sorgu_kriter_string(ara, ara_kriter) & " )"
            ElseIf konum = "Sınıf7" Then
                kriter += " AND ( tbSSinif7.sAciklama " & sorgu_kriter_string(ara, ara_kriter) & " )"
            ElseIf konum = "Sınıf8" Then
                kriter += " AND ( tbSSinif8.sAciklama " & sorgu_kriter_string(ara, ara_kriter) & " )"
            ElseIf konum = "Sınıf9" Then
                kriter += " AND ( tbSSinif9.sAciklama " & sorgu_kriter_string(ara, ara_kriter) & " )"
            ElseIf konum = "Sınıf10" Then
                kriter += " AND ( tbSSinif10.sAciklama " & sorgu_kriter_string(ara, ara_kriter) & " )"
            ElseIf konum = "Sınıf11" Then
                kriter += " AND ( tbSSinif11.sAciklama " & sorgu_kriter_string(ara, ara_kriter) & " )"
            ElseIf konum = "Sınıf12" Then
                kriter += " AND ( tbSSinif12.sAciklama " & sorgu_kriter_string(ara, ara_kriter) & " )"
            ElseIf konum = "Sınıf13" Then
                kriter += " AND ( tbSSinif13.sAciklama " & sorgu_kriter_string(ara, ara_kriter) & " )"
            ElseIf konum = "Sınıf14" Then
                kriter += " AND ( tbSSinif14.sAciklama " & sorgu_kriter_string(ara, ara_kriter) & " )"
            ElseIf konum = "Sınıf15" Then
                kriter += " AND ( tbSSinif15.sAciklama " & sorgu_kriter_string(ara, ara_kriter) & " )"
            End If
        End If
        If sec_bAktif.Checked = True Then
            kriter += " AND (tbProtokolMarket.bAktif = 1)"
        Else
            kriter += " AND (tbProtokolMarket.bAktif = 0)"
        End If
        kriter += " AND tbProtokolMarket.nIslem = " & sec_nIslem.SelectedIndex & ""
        ds_tbStokTedarikcisi = sorgu(sorgu_query("SET DATEFORMAT DMY SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT tbProtokolMarket.nKayitID, tbProtokolMarket.nFirmaID, tbProtokolMarket.nIslem, tbProtokolMarket.nStokID, tbProtokolMarket.sDepo, tbProtokolMarket.lMiktar, tbProtokolMarket.nOran,tbProtokolMarket.nIskontoYuzdesi1,tbProtokolMarket.nIskontoYuzdesi2,tbProtokolMarket.nIskontoYuzdesi3,tbProtokolMarket.nIskontoYuzdesi4, tbProtokolMarket.lAlisFiyati,tbProtokolMarket.lMaliyet, tbProtokolMarket.lFiyat, tbProtokolMarket.dteTarih1, tbProtokolMarket.dteTarih2, tbProtokolMarket.sAciklama, tbProtokolMarket.sKullaniciAdi, tbProtokolMarket.dteKayitTarihi, tbProtokolMarket.bAktif, tbFirma.sKodu AS sFirmaKodu, tbFirma.sAciklama AS sFirmaAciklama, tbStok.sKodu AS sStokKodu, tbStok.sAciklama AS sStokAciklama, tbStok.sModel,tbStok.sRenk, tbRenk.sRenkAdi, tbStok.sBeden, tbStok.sKavala,(SELECT isnull(SUM(tbStokFisiDetayi.lGirisMiktar1 - tbStokFisiDetayi.lCikisMiktar1) , 0) FROM tbStokFisiDetayi WHERE tbStok.nStokID = tbStokFisiDetayi.nStokID ) AS lMevcut,ISNULL((SELECT isnull(lfiyat , 0) FROM tbstokfiyati WHERE nStokId = tbStok.nStokID AND sFiyatTipi = '" & sFiyat1 & "'),0) AS PESIN, ISNULL((SELECT isnull(lfiyat , 0) FROM tbstokfiyati WHERE nStokId = tbStok.nStokID AND sFiyatTipi = '" & sFiyat3 & "'),0) AS ONAY, ISNULL((SELECT isnull(lfiyat , 0) FROM tbstokfiyati WHERE nStokId = tbStok.nStokID AND sFiyatTipi = '" & sFiyat2 & "'),0) AS ALTIAY,ISNULL((SELECT isnull(lfiyat , 0) FROM tbstokfiyati WHERE nStokId = tbStok.nStokID AND sFiyatTipi = '" & sFiyat4 & "'),0) AS ONBESAY,(SELECT isnull(lfiyat , 0) FROM tbstokfiyati WHERE nStokId = tbStok.NstokId AND sFiyatTipi = '" & sFiyatA & "') AS ALISFIYATI,(SELECT isnull(lfiyat , 0) FROM tbstokfiyati WHERE nStokId = tbStok.NstokId AND sFiyatTipi = '" & sFiyatA & "') AS MALIYET FROM tbRenk INNER JOIN tbStok ON tbRenk.sRenk = tbStok.sRenk INNER JOIN tbProtokolMarket INNER JOIN tbFirma ON tbProtokolMarket.nFirmaID = tbFirma.nFirmaID ON tbStok.nStokID = tbProtokolMarket.nStokID  " & kriter & " "))
        GridControl1.DataMember = Nothing
        GridControl1.DataSource = ds_tbStokTedarikcisi.Tables(0)
    End Sub
    Private Sub dataload_tbStokHareketleri(ByVal nKayitID As String, ByVal nFirmaID As Int64, ByVal sFisTipi As String, ByVal nGirisCikis As Int64, ByVal dteTarih1 As DateTime, ByVal dteTarih2 As DateTime)
        'Dim kriter = " Where (tbStok.sKodu <> '') "
        Dim ds_tbStokHareket As DataSet
        ds_tbStokHareket = sorgu(sorgu_query("SET DATEFORMAT DMY SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT tbStokFisiDetayi.sFisTipi, tbStokFisiDetayi.dteFisTarihi, tbStokFisiDetayi.lFisNo, tbStokFisiDetayi.nGirisCikis, tbStokFisiDetayi.sDepo, tbStokFisiDetayi.lGirisMiktar1 - tbStokFisiDetayi.lCikisMiktar1 AS lGCMiktar, tbStokFisiDetayi.lBrutFiyat, tbStokFisiDetayi.lBrutTutar, tbStokFisiDetayi.lGirisFiyat, tbStokFisiDetayi.lGirisTutar, tbStokFisiDetayi.lCikisFiyat, tbStokFisiDetayi.lCikisTutar, tbStokFisiDetayi.nIskontoYuzdesi, tbStokFisiDetayi.lIskontoTutari, tbStokFisiDetayi.lIlaveMaliyetTutar, tbStokFisiDetayi.lIlaveMaliyetTutar,(SELECT ISNULL(SUM(lTutar) , 0) FROM tbStokFisiEkMaliyet WHERE nStokFisiID = tbStokFisiDetayi.nStokFisiID AND nIslemID = tbStokFisiDetayi.nIslemID) AS lEkIlaveMaliyetTutar,tbStokFisiDetayi.nKdvOrani, CAST(0 AS MONEY) AS GERCEKFIYAT, CAST(0 AS MONEY) AS GERCEKTOPLAM, CAST(0 AS MONEY) AS EKMASRAF, CAST(0 AS MONEY) AS ONCEKIMALIYET, '01/01/1900' AS ONCEKIALISTARIHI, CAST(0 AS MONEY) AS TOPLAMMALIYET, CAST(0 AS MONEY) AS ORAN, CAST(0 AS MONEY) AS ORAN1, CAST(0 AS MONEY) AS ORAN2, CAST(0 AS MONEY) AS ORAN3, CAST(0 AS MONEY) AS ORAN4, CAST(0 AS MONEY) AS ORAN5, tbStokFisiMaster.lEkmaliyet1, tbStokFisiMaster.lEkmaliyet3, 0 AS lEkMaliyet4, CAST(0 AS MONEY) AS KAR, CAST(0 AS MONEY) AS KAR1, CAST(0 AS MONEY) AS KAR2, CAST(0 AS MONEY) AS KAR3, CAST(0 AS MONEY) AS KAR4, CAST(0 AS MONEY) AS KAR5, CAST(0 AS MONEY) AS PESINTUTAR, CAST(0 AS MONEY) AS ONAYTUTAR, CAST(0 AS MONEY) AS ALTIAYTUTAR, CAST(0 AS MONEY) AS FIYATTUTAR4, CAST(0 AS MONEY) AS FIYATTUTAR5,CAST(0 AS MONEY) AS ISKTUTAR1,CAST(0 AS MONEY) AS ISKTUTAR2,CAST(0 AS MONEY) AS ISKTUTAR3,CAST(0 AS MONEY) AS ISKTUTAR4, CAST(0 AS MONEY) AS lFark,CAST(0 AS MONEY) AS lFarkTutar, CAST(0 AS MONEY) AS nFarkOran, 'Normal' AS sDurum, tbStokFisiMaster.lMalBedeli, tbStokFisiMaster.lNetTutar, tbStokFisiMaster.lMalIskontoTutari, tbStok.nStokID, tbStok.sKodu as sStokKodu, tbStok.sAciklama as sStokAciklama, tbStok.sKisaAdi, tbStok.sRenk, tbRenk.sRenkAdi, tbStok.sBeden, tbStok.sKavala, (SELECT nKdvOrani FROM tbKdv WHERE sKdvTipi = tbStok.sKdvTipi) AS nStokKdvOrani,(SELECT isnull(lfiyat , 0) FROM tbstokfiyati WHERE nStokId = tbstok.NstokId AND sFiyatTipi = '" & sFiyatM & "') AS MALIYET,tbProtokolMarket.lMaliyet, tbProtokolMarket.dteTarih1, tbProtokolMarket.dteTarih2, tbProtokolMarket.sAciklama,tbProtokolMarket.nIskontoYuzdesi1,tbProtokolMarket.nIskontoYuzdesi2,tbProtokolMarket.nIskontoYuzdesi3,tbProtokolMarket.nIskontoYuzdesi4 FROM tbStokFisiDetayi INNER JOIN tbStokFisiMaster ON tbStokFisiDetayi.nStokFisiID = tbStokFisiMaster.nStokFisiID INNER JOIN tbStok ON tbStokFisiDetayi.nStokID = tbStok.nStokID INNER JOIN tbProtokolMarket ON tbStok.nStokID = tbProtokolMarket.nStokID INNER JOIN tbRenk ON tbStok.sRenk = tbRenk.sRenk WHERE (tbStokFisiDetayi.nFirmaID = tbProtokolMarket.nFirmaID) AND (tbStokFisiDetayi.nGirisCikis = " & nGirisCikis & ") AND (tbStokFisiDetayi.dteFisTarihi BETWEEN tbProtokolMarket.dteTarih1 AND tbProtokolMarket.dteTarih2) AND (tbStokFisiDetayi.sFisTipi IN (" & sFisTipi & ")) AND (tbProtokolMarket.nKayitID IN " & nKayitID & ")"))
        GridControl2.DataMember = Nothing
        GridControl2.DataSource = ds_tbStokHareket.Tables(0)
        Dim oranekmaliyet As Decimal = 0
        Dim dr As DataRow
        Dim lMiktar As Decimal = 0
        Dim maliyet As Decimal = 0
        For Each dr In ds_tbStokHareket.Tables(0).Rows
            If nGirisCikis = 1 Or nGirisCikis = 2 Then
                maliyet = (dr("lGirisTutar")) / dr("lGCMiktar")
                If dr("nKdvOrani") <> dr("nStokKdvOrani") Then
                    If bKdvKontrolluMaliyet = True Then
                        maliyet = maliyet * ((dr("nStokKdvOrani") + 100) / 100)
                    Else
                        maliyet = maliyet * ((dr("nKdvOrani") + 100) / 100)
                    End If
                Else
                    maliyet = maliyet * ((dr("nKdvOrani") + 100) / 100)
                End If
                maliyet = (maliyet) - (Math.Abs((dr("lIlaveMaliyetTutar") + dr("lEkIlaveMaliyetTutar")) / dr("lGCMiktar")))
                dr("GERCEKFIYAT") = maliyet
            ElseIf nGirisCikis = 3 Or nGirisCikis = 4 Then
                dr("GERCEKFIYAT") = dr("lCikisFiyat") * ((dr("nKdvOrani") + 100) / 100)
            End If
            'MsgBox(dr_toplam("lNetTutar"))
            Try
                If CType(dr("lEkmaliyet1") + dr("lEkMaliyet3") + dr("lEkMaliyet4"), Decimal) <> 0 Then
                    oranekmaliyet = CType(dr("lEkmaliyet1") + dr("lEkmaliyet3") + dr("lEkMaliyet4"), Decimal) / CType(dr("lNetTutar") - (dr("lEkmaliyet1")), Decimal)
                    dr("EKMASRAF") = oranekmaliyet
                    dr("GERCEKFIYAT") = dr("GERCEKFIYAT") + (dr("GERCEKFIYAT") * (((oranekmaliyet * 100)) / 100))
                End If
            Catch ex As Exception
            End Try
            dr("MALIYET") = sorgu_sayi(dr("MALIYET"), 0)
            If nGirisCikis = 1 Or nGirisCikis = 2 Then
                dr("GERCEKTOPLAM") = dr("GERCEKFIYAT") * dr("lGCMiktar")
                dr("TOPLAMMALIYET") = sorgu_sayi(dr("MALIYET"), 0) * sorgu_sayi(dr("lGCMiktar"), 0)
                lMiktar = dr("lGCMiktar")
            ElseIf nGirisCikis = 3 Or nGirisCikis = 4 Then
                dr("GERCEKTOPLAM") = dr("GERCEKFIYAT") * dr("lCikisMiktar1")
                dr("TOPLAMMALIYET") = sorgu_sayi(dr("MALIYET"), 0) * sorgu_sayi(dr("lCikisMiktar1"), 0)
                lMiktar = dr("lCikisMiktar1")
            End If
            oranekmaliyet = 0
            'dr("GERCEKTOPLAM") = dr("GERCEKFIYAT") * dr("lGCMiktar")
            'If nGirisCikis = 1 Or nGirisCikis = 2 Then
            '    Dim dr1 As DataRow
            '    ds_alislar = sorgu_alislar(dr("dteFisTarihi"), dr("lFisNo"), dr("sKodu"))
            '    Dim sayi As Integer = 0
            '    For Each dr1 In ds_alislar.Tables(0).Rows
            '        sayi += 1
            '        dr1("ORANEKMALIYET") = 0
            '        dr1("NETMALIYET") = dr1("KDVLITUTAR") * ((100 + (dr1("ORANEKMALIYET") * 100)) / 100)
            '        If sayi = 1 Then
            '            dr("ONCEKIMALIYET") = dr1("NETMALIYET")
            '            dr("ONCEKIALISTARIHI") = dr1("TARIH")
            '        ElseIf sayi = 2 Then
            '        End If
            '    Next
            'End If
            Try
                If dr("TOPLAMMALIYET") <> 0 Then
                    dr("ORAN") = ((dr("GERCEKTOPLAM") - dr("TOPLAMMALIYET")) / dr("TOPLAMMALIYET"))
                    dr("KAR") = dr("GERCEKTOPLAM") - dr("TOPLAMMALIYET")
                Else
                End If
            Catch ex As Exception
            End Try
            dr("ISKTUTAR1") = dr("GERCEKTOPLAM") * dr("nIskontoYuzdesi1") / 100
            dr("ISKTUTAR2") = (dr("GERCEKTOPLAM") - dr("ISKTUTAR1")) * dr("nIskontoYuzdesi2") / 100
            dr("ISKTUTAR3") = (dr("lBrutTutar") * ((dr("nKdvOrani") + 100) / 100)) * dr("nIskontoYuzdesi3") / 100
            dr("ISKTUTAR4") = (dr("lBrutTutar") * ((dr("nKdvOrani") + 100) / 100)) * dr("nIskontoYuzdesi4") / 100
            'Try
            '    If dr("PESIN") <> 0 Then
            '        dr("ORAN1") = ((dr("PESIN") - dr("GERCEKFIYAT")) / dr("GERCEKFIYAT")) * 100
            '        dr("PESINTUTAR") = dr("PESIN") * lMiktar
            '        dr("KAR1") = dr("PESINTUTAR") - dr("GERCEKTOPLAM")
            '    Else
            '        dr("PESINTUTAR") = 0
            '    End If
            'Catch ex As Exception
            'End Try
            'Try
            '    If dr("ALTIAY") <> 0 Then
            '        dr("ORAN2") = ((dr("ALTIAY") - dr("GERCEKFIYAT")) / dr("GERCEKFIYAT")) * 100
            '        dr("ALTIAYTUTAR") = dr("ALTIAY") * lMiktar
            '        dr("KAR2") = dr("ALTIAYTUTAR") - dr("GERCEKTOPLAM")
            '    Else
            '        dr("ALTIAYTUTAR") = 0
            '    End If
            'Catch ex As Exception
            'End Try
            'Try
            '    If dr("ONAY") <> 0 Then
            '        dr("ORAN3") = ((dr("ONAY") - dr("GERCEKFIYAT")) / dr("GERCEKFIYAT")) * 100
            '        dr("ONAYTUTAR") = dr("ONAY") * lMiktar
            '        dr("KAR3") = dr("ONAYTUTAR") - dr("GERCEKTOPLAM")
            '    Else
            '        dr("ONAYTUTAR") = 0
            '    End If
            'Catch ex As Exception
            'End Try
            'Try
            '    If dr("lFiyat4") <> 0 Then
            '        dr("ORAN4") = ((dr("lFiyat4") - dr("GERCEKFIYAT")) / dr("GERCEKFIYAT")) * 100
            '        dr("FIYATTUTAR4") = dr("lFiyat4") * lMiktar
            '        dr("KAR4") = dr("FIYATTUTAR4") - dr("GERCEKTOPLAM")
            '    Else
            '        dr("FIYATTUTAR4") = 0
            '    End If
            'Catch ex As Exception
            'End Try
            'Try
            '    If dr("lFiyat5") <> 0 Then
            '        dr("ORAN5") = ((dr("lFiyat5") - dr("GERCEKFIYAT")) / dr("GERCEKFIYAT")) * 100
            '        dr("FIYATTUTAR5") = dr("lFiyat5") * lMiktar
            '        dr("KAR5") = dr("FIYATTUTAR4") - dr("GERCEKTOPLAM")
            '    Else
            '        dr("FIYATTUTAR4") = 0
            '    End If
            'Catch ex As Exception
            'End Try
            'Try
            '    If dr("lOzelFiyat") <> 0 Then
            '        dr("ORAN6") = ((dr("lOzelFiyat") - dr("GERCEKFIYAT")) / dr("GERCEKFIYAT")) * 100
            '        dr("FIYATTUTAR6") = dr("lOzelFiyat") * lMiktar
            '        dr("KAR6") = dr("FIYATTUTAR6") - dr("GERCEKTOPLAM")
            '    Else
            '        dr("FIYATTUTAR6") = 0
            '    End If
            'Catch ex As Exception
            'End Try
            dr("lGCMiktar") = lMiktar
            If Math.Abs(dr("GERCEKFIYAT")) >= dr("lMaliyet") Then
                dr("lFark") = FormatNumber((Math.Abs(dr("GERCEKFIYAT"))) - (Math.Abs(dr("lMaliyet"))), 2)
                dr("lFarkTutar") = dr("lFark") * dr("lGCMiktar")
            End If
            Try
                dr("nFarkOran") = dr("lFark") / dr("lMaliyet")
            Catch ex As Exception
                dr("nFarkOran") = 0
            End Try
            If dr("lFark") > 0 Then
                If dr("ONCEKIMALIYET") = 0 Then
                    If dr("GERCEKFIYAT") = 0 Then
                        dr("sDurum") = "Bedelsiz"
                    Else
                        dr("sDurum") = "Pahalı"
                    End If
                Else
                    dr("sDurum") = "Pahalı"
                End If
            ElseIf dr("lFark") < 0 Then
                dr("sDurum") = "Ucuz"
            ElseIf dr("lFark") = 0 Then
                'dr("Durum") = "Normal"
            End If
        Next
        lMiktar = Nothing
        maliyet = Nothing
        If ds_tbStokHareket.Tables(0).Rows.Count > 0 Then
            XtraTabControl1.SelectedTabPageIndex = 1
            GridControl2.Focus()
            GridControl2.Select()
        End If
    End Sub
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
    Private Function sorgu_query(ByVal query As String) As String
        query = Replace(query, "*!F", "F0" + firmano.ToString)
        query = Replace(query, "!D", "D000" + donemno.ToString)
        Return query
    End Function
    Private Sub firma_sec(Optional ByVal islem As Integer = 0)
        Dim dr As DataRow
        dr = GridView1.GetDataRow(GridView1.FocusedRowHandle)
        Dim frm As New frm_firma_liste
        frm.firmano = firmano
        frm.donemno = donemno
        frm.connection = connection
        frm.islemstatus = True
        frm.kullanici = kullanici
        If frm.ShowDialog(Me) = Windows.Forms.DialogResult.OK Then
            Dim dr1 As DataRow
            dr1 = frm.GridView1.GetDataRow(frm.GridView1.FocusedRowHandle)
            nFirmaID = dr1("nFirmaID")
            sFirmaKodu = dr1("sKodu")
            lbl_Firma.Text = Trim(dr1("sAciklama").ToString)
            sFirmaAciklama = Trim(dr1("sAciklama").ToString)
            txt_musteriNo.EditValue = sFirmaKodu
            dr1 = Nothing
        End If
    End Sub
    Private Sub stok_sec(Optional ByVal islem As Integer = 0)
        Dim dr As DataRow
        dr = GridView1.GetDataRow(GridView1.FocusedRowHandle)
        Dim frm As New frm_stok
        frm.firmano = firmano
        frm.donemno = donemno
        frm.connection = connection
        frm.islemstatus = True
        frm.kullanici = kullanici
        If frm.ShowDialog(Me) = Windows.Forms.DialogResult.OK Then
            Dim dr1 As DataRow
            dr1 = frm.GridView1.GetDataRow(frm.GridView1.FocusedRowHandle)
            nStokID = dr1("nStokID")
            sFirmaKodu = dr1("sKodu")
            lbl_Firma.Text = Trim(dr1("sAciklama").ToString)
            sFirmaAciklama = Trim(dr1("sAciklama").ToString)
            txt_musteriNo.EditValue = sFirmaKodu
            dr1 = Nothing
        End If
    End Sub
    Private Sub tbStokTedarikcisi_kaydet_yeni(ByVal nFirmaID As Int64, ByVal nIslem As Integer, ByVal nStokID As Int64, ByVal sDepo As String, ByVal lMiktar As Decimal, ByVal nOran As Decimal, ByVal nIskontoYuzdesi1 As Decimal, ByVal nIskontoYuzdesi2 As Decimal, ByVal nIskontoYuzdesi3 As Decimal, ByVal nIskontoYuzdesi4 As Decimal, ByVal lAlisFiyati As Decimal, ByVal lMaliyet As Decimal, ByVal lFiyat As Decimal, ByVal dteTarih1 As DateTime, ByVal dteTarih2 As DateTime, ByVal sAciklama As String, ByVal sKullaniciAdi As String, ByVal dteKayitTarihi As DateTime, ByVal bAktif As Integer)
        Dim cmd As New OleDb.OleDbCommand
        Dim con As New OleDb.OleDbConnection
        cmd.Connection = con
        con.ConnectionString = connection
        cmd.CommandTimeout = Nothing
        If con.State = ConnectionState.Closed = True Then
            con.Open()
        End If
        cmd.CommandText = sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED INSERT INTO tbProtokolMarket                       (nFirmaID, nIslem, nStokID, sDepo, lMiktar, nOran, nIskontoYuzdesi1,nIskontoYuzdesi2,nIskontoYuzdesi3,nIskontoYuzdesi4,lAlisFiyati,lMaliyet, lFiyat, dteTarih1, dteTarih2, sAciklama, sKullaniciAdi, dteKayitTarihi, bAktif) VALUES     (" & nFirmaID & ", " & nIslem & ", " & nStokID & ", '" & sDepo & "', " & lMiktar & ", " & nOran & ", " & nIskontoYuzdesi1 & "," & nIskontoYuzdesi2 & "," & nIskontoYuzdesi3 & "," & nIskontoYuzdesi4 & "," & lAlisFiyati & "," & lMaliyet & ", " & lFiyat & ", '" & dteTarih1 & "', '" & dteTarih2 & "', '" & sAciklama & "', '" & sKullaniciAdi & "', '" & dteKayitTarihi & "', " & bAktif & ")")
        cmd.ExecuteNonQuery()
        con.Close()
    End Sub
    Private Sub tbStokTedarikcisi_kaydet_kopyala(ByVal nFirmaID As Int64, ByVal nYeniFirmaID As Int64, Optional ByVal bFirma As Boolean = True)
        Dim cmd As New OleDb.OleDbCommand
        Dim con As New OleDb.OleDbConnection
        cmd.Connection = con
        con.ConnectionString = connection
        cmd.CommandTimeout = Nothing
        If con.State = ConnectionState.Closed = True Then
            con.Open()
        End If
        If bFirma = True Then
            cmd.CommandText = sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED INSERT INTO tbProtokol SELECT " & nYeniFirmaID & " AS nFirmaID, nMusteriID, nStokID, sFiyatTipi, sDovizCinsi, sHangiKur, nKdvOrani, lFiyat, nIskontoYuzdesi1, nIskontoYuzdesi2, nIskontoYuzdesi3, nIskontoYuzdesi4 FROM tbProtokol WHERE (nFirmaID = " & nFirmaID & ") and nStokID NOT IN (Select nStokID from tbProtokol where nFirmaID = " & nYeniFirmaID & ")")
            cmd.ExecuteNonQuery()
        Else
            cmd.CommandText = sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED INSERT INTO tbProtokol SELECT nFirmaID, nMusteriID, " & nYeniFirmaID & ", sFiyatTipi, sDovizCinsi, sHangiKur, nKdvOrani, lFiyat, nIskontoYuzdesi1, nIskontoYuzdesi2, nIskontoYuzdesi3, nIskontoYuzdesi4 FROM tbProtokol WHERE (nStokID = " & nFirmaID & ") and nFirmaID NOT IN (Select nFirmaID from tbProtokol where nStokID = " & nYeniFirmaID & ")")
            cmd.ExecuteNonQuery()
        End If
        con.Close()
    End Sub
    Private Sub tbStokTedarikcisi_kaydet_degistir(ByVal nKayitID As Int64, ByVal nFirmaID As Int64, ByVal nIslem As Integer, ByVal nStokID As Int64, ByVal sDepo As String, ByVal lMiktar As Decimal, ByVal nOran As Decimal, ByVal nIskontoYuzdesi1 As Decimal, ByVal nIskontoYuzdesi2 As Decimal, ByVal nIskontoYuzdesi3 As Decimal, ByVal nIskontoYuzdesi4 As Decimal, ByVal lAlisFiyati As Decimal, ByVal lMaliyet As Decimal, ByVal lFiyat As Decimal, ByVal dteTarih1 As DateTime, ByVal dteTarih2 As DateTime, ByVal sAciklama As String, ByVal sKullaniciAdi As String, ByVal dteKayitTarihi As DateTime, ByVal bAktif As Integer)
        Dim cmd As New OleDb.OleDbCommand
        Dim con As New OleDb.OleDbConnection
        cmd.Connection = con
        con.ConnectionString = connection
        cmd.CommandTimeout = Nothing
        If con.State = ConnectionState.Closed = True Then
            con.Open()
        End If
        cmd.CommandText = sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED UPDATE    tbProtokolMarket SET              nFirmaID = " & nFirmaID & ", nIslem = " & nIslem & ", nStokID = " & nStokID & ", sDepo = '" & sDepo & "', lMiktar = " & lMiktar & ", nOran = " & nOran & ", nIskontoYuzdesi1 = " & nIskontoYuzdesi1 & ",nIskontoYuzdesi2 = " & nIskontoYuzdesi2 & ",nIskontoYuzdesi3 = " & nIskontoYuzdesi3 & ",nIskontoYuzdesi4 = " & nIskontoYuzdesi4 & ",lAlisFiyati = " & lAlisFiyati & ",lMaliyet = " & lMaliyet & ", lFiyat = " & lFiyat & ", dteTarih1 = '" & dteTarih1 & "',                        dteTarih2 = '" & dteTarih2 & "', sAciklama = '" & sAciklama & "', sKullaniciAdi = '" & sKullaniciAdi & "', dteKayitTarihi = '" & dteKayitTarihi & "', bAktif = " & bAktif & " Where  nKayitID = '" & nKayitID & "' ")
        cmd.ExecuteNonQuery()
        con.Close()
    End Sub
    Private Sub tbStokTedarikcisi_kaydet_sil(ByVal nKayitID As Int64)
        Dim cmd As New OleDb.OleDbCommand
        Dim con As New OleDb.OleDbConnection
        cmd.Connection = con
        con.ConnectionString = connection
        cmd.CommandTimeout = Nothing
        If con.State = ConnectionState.Closed = True Then
            con.Open()
        End If
        cmd.CommandText = sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED DELETE FROM tbProtokolMarket Where nKayitID = " & nKayitID & "  ")
        cmd.ExecuteNonQuery()
        con.Close()
    End Sub
    Public Function sorgu_ntbStokTedarikcisi(ByVal nFirmaID As String, ByVal nStokID As String) As Int64
        'kriter = "WHERE (sKodu = '" & kod & "')  "
        Dim conn As New OleDb.OleDbConnection
        Dim cmd As New OleDb.OleDbCommand
        Dim adapter As New OleDb.OleDbDataAdapter
        'MsgBox(connection_resmi)
        conn.ConnectionString = connection
        cmd.Connection = conn
        conn.Open()
        cmd.CommandText = sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT     COUNT(*) AS nKayit FROM         tbProtokol WHERE     (nFirmaID = " & nFirmaID & ") AND (nStokID = " & nStokID & ")")
        Dim kayitsayisi = cmd.ExecuteScalar
        Return kayitsayisi
    End Function
    Private Sub satir_ekle_stok()
        Dim frm As New frm_stok
        frm.islemstatus = True
        frm.connection = connection
        frm.firmano = firmano
        frm.donemno = donemno
        frm.islemstatus = True
        frm.kullanici = kullanici
        If frm.ShowDialog(Me) = Windows.Forms.DialogResult.OK Then
            Dim s As String
            Dim arr As Integer()
            Dim i As Integer
            Dim dr1 As DataRow
            Dim dr As DataRow
            arr = frm.GridView1.GetSelectedRows()
            If arr Is Nothing Then
            Else
                Array.Sort(arr)
                For Each i In arr
                    s = i.ToString
                    dr1 = frm.GridView1.GetDataRow(s)
                    'If sorgu_ntbStokTedarikcisi(nFirmaID, dr1("nStokID")) = 0 Then
                    dr = ds_tbStokTedarikcisi.Tables(0).NewRow
                    dr("nFirmaID") = nFirmaID
                    dr("nStokID") = dr1("nStokID")
                    dr("nIslem") = sec_nIslem.SelectedIndex
                    dr("sDepo") = ""
                    If sec_nIslem.SelectedIndex = 1 Then
                        dr("lMiktar") = dr1("Mevcut")
                    Else
                        dr("lMiktar") = 1
                    End If
                    dr("lFiyat") = 0
                    dr("nOran") = 0
                    dr("nIskontoYuzdesi1") = 0
                    dr("nIskontoYuzdesi2") = 0
                    dr("nIskontoYuzdesi3") = 0
                    dr("nIskontoYuzdesi4") = 0
                    dr("lAlisFiyati") = dr1("MALIYET")
                    dr("lMaliyet") = dr1("MALIYET")
                    dr("lFiyat") = dr1("PESIN")
                    dr("dteTarih1") = Today
                    dr("dteTarih2") = Today
                    dr("sKullaniciAdi") = kullaniciadi
                    dr("dteKayitTarihi") = Now
                    dr("sAciklama") = ""
                    dr("bAktif") = True
                    tbStokTedarikcisi_kaydet_yeni(dr("nFirmaID"), dr("nIslem"), dr("nStokID"), dr("sDepo"), dr("lMiktar"), dr("nOran"), dr("nIskontoYuzdesi1"), dr("nIskontoYuzdesi2"), dr("nIskontoYuzdesi3"), dr("nIskontoYuzdesi4"), dr("lAlisFiyati"), dr("lMaliyet"), dr("lFiyat"), dr("dteTarih1"), dr("dteTarih2"), dr("sAciklama"), dr("sKullaniciAdi"), dr("dteKayitTarihi"), dr("bAktif"))
                    ds_tbStokTedarikcisi.Tables(0).Rows.Add(dr)
                    'End If
                Next
            End If
            ara()
        End If
    End Sub
    Private Sub satir_ekle_stok_kopyala()
        Dim frm As New frm_stok
        frm.islemstatus = True
        frm.connection = connection
        frm.firmano = firmano
        frm.donemno = donemno
        frm.islemstatus = True
        frm.kullanici = kullanici
        If frm.ShowDialog(Me) = Windows.Forms.DialogResult.OK Then
            Dim s As String
            Dim arr As Integer()
            Dim i As Integer
            Dim dr1 As DataRow
            arr = frm.GridView1.GetSelectedRows()
            If arr Is Nothing Then
            Else
                Array.Sort(arr)
                For Each i In arr
                    s = i.ToString
                    dr1 = frm.GridView1.GetDataRow(s)
                    tbStokTedarikcisi_kaydet_kopyala(nStokID, dr1("nStokID"), False)
                Next
            End If
            dr1 = frm.GridView1.GetDataRow(frm.GridView1.FocusedRowHandle)
            nStokID = dr1("nStokID")
            sFirmaKodu = dr1("sKodu")
            lbl_Firma.Text = Trim(dr1("sAciklama").ToString)
            sFirmaAciklama = Trim(dr1("sAciklama").ToString)
            txt_musteriNo.EditValue = sFirmaKodu
            ara()
        End If
    End Sub
    Private Sub satir_ekle_firma()
        Dim frm As New frm_firma_liste
        frm.islemstatus = True
        frm.connection = connection
        frm.firmano = firmano
        frm.donemno = donemno
        frm.islemstatus = True
        frm.kullanici = kullanici
        If frm.ShowDialog(Me) = Windows.Forms.DialogResult.OK Then
            Dim s As String
            Dim arr As Integer()
            Dim i As Integer
            Dim dr1 As DataRow
            arr = frm.GridView1.GetSelectedRows()
            If arr Is Nothing Then
            Else
                Array.Sort(arr)
                For Each i In arr
                    s = i.ToString
                    dr1 = frm.GridView1.GetDataRow(s)
                    If sorgu_ntbStokTedarikcisi(dr1("nFirmaID"), nStokID) = 0 Then
                        dr = ds_tbStokTedarikcisi.Tables(0).NewRow
                        dr("nFirmaID") = dr1("nFirmaID")
                        dr("nStokID") = nStokID
                        dr("nIslem") = sec_nIslem.SelectedIndex
                        dr("sDepo") = ""
                        dr("lMiktar") = 1
                        dr("lFiyat") = 0
                        dr("nOran") = 0
                        dr("nIskontoYuzdesi1") = 0
                        dr("nIskontoYuzdesi2") = 0
                        dr("nIskontoYuzdesi3") = 0
                        dr("nIskontoYuzdesi4") = 0
                        dr("lAlisFiyati") = dr1("MALIYET")
                        dr("lMaliyet") = dr1("MALIYET")
                        dr("lFiyat") = dr1("PESIN")
                        dr("dteTarih1") = Today
                        dr("dteTarih2") = Today
                        dr("sKullaniciAdi") = kullaniciadi
                        dr("dteKayitTarihi") = Now
                        dr("sAciklama") = ""
                        dr("bAktif") = True
                        tbStokTedarikcisi_kaydet_yeni(dr("nFirmaID"), dr("nIslem"), dr("nStokID"), dr("sDepo"), dr("lMiktar"), dr("nOran"), dr("nIskontoYuzdesi1"), dr("nIskontoYuzdesi2"), dr("nIskontoYuzdesi3"), dr("nIskontoYuzdesi4"), dr("lAlisFiyati"), dr("lMaliyet"), dr("lFiyat"), dr("dteTarih1"), dr("dteTarih2"), dr("sAciklama"), dr("sKullaniciAdi"), dr("dteKayitTarihi"), dr("bAktif"))
                        ds_tbStokTedarikcisi.Tables(0).Rows.Add(dr)
                    End If
                Next
            End If
            ara()
        End If
    End Sub
    Private Sub satir_ekle_firma_kopyala()
        Dim frm As New frm_firma_liste
        frm.islemstatus = True
        frm.connection = connection
        frm.firmano = firmano
        frm.donemno = donemno
        frm.islemstatus = True
        frm.kullanici = kullanici
        If frm.ShowDialog(Me) = Windows.Forms.DialogResult.OK Then
            Dim s As String
            Dim arr As Integer()
            Dim i As Integer
            Dim dr1 As DataRow
            arr = frm.GridView1.GetSelectedRows()
            If arr Is Nothing Then
            Else
                Array.Sort(arr)
                For Each i In arr
                    s = i.ToString
                    dr1 = frm.GridView1.GetDataRow(s)
                    tbStokTedarikcisi_kaydet_kopyala(nFirmaID, dr1("nFirmaID"))
                Next
            End If
            dr1 = frm.GridView1.GetDataRow(frm.GridView1.FocusedRowHandle)
            nFirmaID = dr1("nFirmaID")
            sFirmaKodu = dr1("sKodu")
            lbl_Firma.Text = Trim(dr1("sAciklama").ToString)
            sFirmaAciklama = Trim(dr1("sAciklama").ToString)
            txt_musteriNo.EditValue = sFirmaKodu
            ara()
        End If
    End Sub
    Private Sub stok_sil()
        If XtraMessageBox.Show(Sorgu_sDil("Seçili Kayıtları Silmek İstediğinize Emin misiniz...?", sDil), Sorgu_sDil("Dikkat", sDil), MessageBoxButtons.YesNo, MessageBoxIcon.Question) = MsgBoxResult.Yes Then
            Dim s As String
            Dim arr As Integer()
            Dim i As Integer
            Dim dr1 As DataRow
            Dim satir As String = GridView1.FocusedRowHandle
            arr = GridView1.GetSelectedRows()
            If arr Is Nothing Then
            Else
                Array.Sort(arr)
                For Each i In arr
                    s = i.ToString
                    dr1 = GridView1.GetDataRow(s)
                    tbStokTedarikcisi_kaydet_sil(dr1("nKayitID"))
                Next
            End If
            s = Nothing
            arr = Nothing
            i = Nothing
            dr1 = Nothing
            'MsgBox(Sorgu_sDil("İşlem Tamamlandı...", sDil), Sorgu_sDil("Dikkat", sDil), MessageBoxButtons.OK, MessageBoxIcon.Information)
            ara()
            GridView1.FocusedRowHandle = satir
            satir = Nothing
        End If
    End Sub
    Private Sub degeryay(ByVal columnkriter As String)
        Dim durum
        Dim sayi = GridView1.RowCount  'kl.Count
        Dim satir = GridView1.FocusedRowHandle 'kl.Position
        Dim TOPLAM = sayi - GridView1.FocusedRowHandle 'kl.Position
        Dim t As Int64
        Dim İ As Integer
        İ = 0
        Dim dr_hareket As DataRow
        Dim dr As DataRow
        dr_hareket = GridView1.GetDataRow(GridView1.FocusedRowHandle)
        durum = dr_hareket("" & columnkriter & "")
        For İ = 1 To TOPLAM
            'dr_hareket = GridView2.GetDataRow(GridView2.FocusedRowHandle)
            'dr_hareket.BeginEdit()
            'dr_hareket("" & columnkriter & "") = durum
            'dr_hareket.EndEdit()
            t += 1
            GridView1.PostEditor()
            dr = GridView1.GetDataRow(GridView1.FocusedRowHandle)
            dr("" & columnkriter & "") = durum
            dr.EndEdit()
            tbStokTedarik_hesapla()
            'toplam_hesapla()
            GridView1.FocusedRowHandle += 1
        Next
        GridView1.FocusedRowHandle = satir
        GridView1.GetDataRow(satir)
        durum = Nothing
        sayi = Nothing
        satir = Nothing
        İ = Nothing
    End Sub
    Private Sub tbStokTedarik_hesapla()
        If GridView1.RowCount > 0 Then
            GridView1.PostEditor()
            Dim dr As DataRow
            dr = GridView1.GetDataRow(GridView1.FocusedRowHandle)
            dr.EndEdit()
            If dr("nOran") = 0 Then
            Else
                'dr("lMaliyet") = dr("lFiyat") / (100 + dr("nOran")) / 100
                dr("lMaliyet") = dr("lFiyat") / ((100 + dr("nOran")) / 100)
            End If
            tbStokTedarikcisi_kaydet_degistir(dr("nKayitID"), dr("nFirmaID"), dr("nIslem"), dr("nStokID"), dr("sDepo"), dr("lMiktar"), dr("nOran"), dr("nIskontoYuzdesi1"), dr("nIskontoYuzdesi2"), dr("nIskontoYuzdesi3"), dr("nIskontoYuzdesi4"), dr("lAlisFiyati"), dr("lMaliyet"), dr("lFiyat"), dr("dteTarih1"), dr("dteTarih2"), dr("sAciklama"), dr("sKullaniciAdi"), dr("dteKayitTarihi"), dr("bAktif"))
        End If
    End Sub
    Private Sub stok_duzelt()
        If GridView1.RowCount > 0 Then
            dr = GridView1.GetDataRow(GridView1.FocusedRowHandle)
            Dim frm As New frm_stok_kart
            frm.firmano = firmano
            frm.donemno = donemno
            frm.connection = connection
            frm.nStokID = dr("nStokID")
            frm.sKodu = dr("sStokKodu")
            frm.sModel = dr("sModel")
            frm.kullanici = kullanici
            If yetki_kontrol(kullanici, frm.Name) = True Then
                frm.ShowDialog()
            End If
            Dim satir = GridView1.FocusedRowHandle
            ara()
            GridView1.FocusedRowHandle = satir
            satir = Nothing
            frm.Close()
            frm.Dispose()
            frm = Nothing
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
            frm.stokno = dr("nStokId")
            frm.stokkodu = dr("sStokKodu")
            frm.kullanici = kullanici
            If yetki_kontrol(kullanici, frm.Name) = True Then
                frm.ShowDialog()
            End If
            frm.Close()
            frm.Dispose()
            frm = Nothing
        End If
    End Sub
    Private Sub analiz_hareket_transfer()
        If GridView1.RowCount > 0 Then
            Dim dr As DataRow
            dr = GridView1.GetDataRow(GridView1.FocusedRowHandle)
            Dim frm As New frm_stok_hareketleri_transfer
            frm.firmano = firmano
            frm.donemno = donemno
            frm.connection = connection
            'frm.stokno = dr("nStokId")
            frm.stokkodu = dr("sStokKodu")
            frm.kullanici = kullanici
            If yetki_kontrol(kullanici, frm.Name) = True Then
                frm.ShowDialog()
            End If
            frm.Close()
            frm.Dispose()
            frm = Nothing
        End If
    End Sub
    Private Sub analiz_stok_hareket()
        If GridView1.RowCount > 0 Then
            Dim dr As DataRow = GridView1.GetDataRow(GridView1.FocusedRowHandle)
            Dim frm As New frm_stok_hareketleri
            frm.firmano = firmano
            frm.donemno = donemno
            frm.connection = connection
            frm.musterino = dr("sStokKodu")
            frm.nFirmaID = dr("nFirmaID")
            If sec_nIslem.SelectedIndex = 0 Then
                frm.sec_firma.Checked = True
                frm.sec_giris.Text = "Girişler"
            ElseIf sec_nIslem.SelectedIndex = 1 Then
                frm.sec_giris.Text = "Girişler"
            Else
                frm.sec_giris.Text = "Çıkışlar"
            End If
            frm.DateEdit1.EditValue = dr("dteTarih1")
            frm.DateEdit2.EditValue = dr("dteTarih2")
            frm.bRapor = True
            'frm.collGirisFiyat.Visible = False
            'frm.collGirisFiyat.OptionsColumn.ShowInCustomizationForm = False
            'frm.collCikisFiyat.Visible = False
            'frm.collCikisFiyat.OptionsColumn.ShowInCustomizationForm = False
            'frm.collBrutFiyat.Visible = False
            'frm.collBrutFiyat.OptionsColumn.ShowInCustomizationForm = False
            'frm.collBrutTutar.Visible = False
            'frm.collBrutTutar.OptionsColumn.ShowInCustomizationForm = False
            'frm.colnKdvOrani.Visible = False
            'frm.colnKdvOrani.OptionsColumn.ShowInCustomizationForm = False
            'frm.collIskontoTutari.Visible = False
            'frm.collIskontoTutari.OptionsColumn.ShowInCustomizationForm = False
            'frm.colnGirisCikis.Visible = False
            frm.MenuItem16.Enabled = False
            frm.MenuItem17.Enabled = False
            frm.MenuItem20.Enabled = False
            frm.Label1.Text = dr("sStokAciklama") & vbCrLf & frm.Label1.Text
            frm.kullanici = kullanici
            If yetki_kontrol(kullanici, frm.Name) = True Then
                frm.ShowDialog()
            End If
            frm.Close()
            frm.Dispose()
            frm = Nothing
        End If
    End Sub
    Private Sub analiz_envanter_model()
        If GridView1.RowCount > 0 Then
            Dim dr As DataRow
            dr = GridView1.GetDataRow(GridView1.FocusedRowHandle)
            Dim frm As New frm_stok_envanter_model
            frm.firmano = firmano
            frm.donemno = donemno
            frm.connection = connection
            frm.modelno = dr("sModel")
            frm.kullanici = kullanici
            If yetki_kontrol(kullanici, frm.Name) = True Then
                frm.ShowDialog()
            End If
            frm.Close()
            frm.Dispose()
            frm = Nothing
        End If
    End Sub
    Private Sub analiz_hareket()
        Dim dr As DataRow
        dr = GridView1.GetDataRow(GridView1.FocusedRowHandle)
        'stkdll.firmano = firmano
        'stkdll.donemno = donemno
        'stkdll.connection = connection
        'stkdll.stokno = dr("IND")
        'stkdll.rptfiyatanalizi(dr("IND"), 100, dr("MALINCINSI"), 2)
    End Sub
    Private Sub stok_fiyat()
        If GridView1.RowCount > 0 Then
            Dim dr As DataRow
            dr = GridView1.GetDataRow(GridView1.FocusedRowHandle)
            Dim frm As New frm_stok_fiyatlandir
            frm.firmano = firmano
            frm.donemno = donemno
            frm.connection = connection
            frm.nStokID = dr("nStokId")
            frm.sModel = dr("sModel")
            frm.sKodu = dr("sStokKodu")
            frm.sRenk = dr("sRenk")
            frm.sBeden = dr("sBeden")
            frm.txt_musteriNo.Text = dr("sModel")
            frm.kullanici = kullanici
            If yetki_kontrol(kullanici, frm.Name) = True Then
                frm.ShowDialog()
            End If
            frm.Close()
            frm.Dispose()
            frm = Nothing
            Dim satir = GridView1.FocusedRowHandle
            ara()
            GridView1.FocusedRowHandle = satir
            satir = Nothing
        End If
    End Sub
    Private Sub stok_satis_detay()
        If GridView1.RowCount > 0 Then
            Dim frm As New frm_stok_cari_satis
            Dim dr As DataRow
            dr = GridView1.GetDataRow(GridView1.FocusedRowHandle)
            frm.status = True
            frm.firmano = 100
            frm.donemno = 1
            frm.connection = connection
            frm.islemstatus = True
            frm.stokno = dr("nAlisverisID")
            frm.fistipi = Trim(dr("sFisTipi").ToString)
            frm.kullanici = kullanici
            If yetki_kontrol(kullanici, frm.Name) = True Then
                frm.ShowDialog()
            End If
            frm.Close()
            dr = Nothing
        End If
    End Sub
    Private Sub analiz_musteri_karti()
        If GridView1.RowCount > 0 Then
            Dim dr As DataRow = GridView1.GetDataRow(GridView1.FocusedRowHandle)
            Dim frm As New frm_musteri_karti
            frm.firmano = firmano
            frm.donemno = donemno
            frm.connection = connection
            frm.musterino = dr("lKodu")
            frm.musteriID = dr("nMusteriID")
            frm.kullanici = kullanici
            If yetki_kontrol(kullanici, frm.Name) = True Then
                frm.ShowDialog()
            End If
            frm.Close()
            frm.Dispose()
            frm = Nothing
        End If
    End Sub
    Private Sub analiz_acik_faturalar_analiz()
        If GridView1.RowCount > 0 Then
            Dim dr As DataRow = GridView1.GetDataRow(GridView1.FocusedRowHandle)
            Dim frm As New frm_cari_faturalar_acik_analiz
            frm.firmano = firmano
            frm.donemno = donemno
            frm.connection = connection
            frm.musterino = dr("nMusteriID")
            frm.kullanici = kullanici
            If yetki_kontrol(kullanici, frm.Name) = True Then
                frm.ShowDialog()
            End If
            frm.Close()
            frm.Dispose()
            frm = Nothing
        End If
    End Sub
    Private Sub analiz_acik_faturalar()
        If GridView1.RowCount > 0 Then
            Dim dr As DataRow = GridView1.GetDataRow(GridView1.FocusedRowHandle)
            Dim frm As New frm_cari_faturalar_acik
            frm.firmano = firmano
            frm.donemno = donemno
            frm.connection = connection
            frm.musterino = dr("nMusteriID")
            frm.kullanici = kullanici
            If yetki_kontrol(kullanici, frm.Name) = True Then
                frm.ShowDialog()
            End If
            frm.Close()
            frm.Dispose()
            frm = Nothing
        End If
    End Sub
    Private Sub analiz_iletisim()
        If GridView1.RowCount > 0 Then
            Dim dr As DataRow = GridView1.GetDataRow(GridView1.FocusedRowHandle)
            Dim frm As New frm_firma_iletisim
            frm.firmano = firmano
            frm.donemno = donemno
            frm.connection = connection
            frm.musterino = dr("nFirmaID")
            frm.kullanici = kullanici
            If yetki_kontrol(kullanici, frm.Name) = True Then
                frm.ShowDialog()
            End If
            frm.Close()
            frm.Dispose()
            frm = Nothing
        End If
    End Sub
    Private Sub analiz_musteri_satislar()
        If GridView1.RowCount > 0 Then
            Dim dr As DataRow = GridView1.GetDataRow(GridView1.FocusedRowHandle)
            Dim frm As New frm_cari_faturalar_kapatma
            frm.firmano = firmano
            frm.donemno = donemno
            frm.connection = connection
            frm.musterino = dr("lKodu")
            frm.musteriID = dr("nMusteriID")
            frm.kullanici = kullanici
            If yetki_kontrol(kullanici, frm.Name) = True Then
                frm.ShowDialog()
            End If
            frm.Close()
            frm.Dispose()
            frm = Nothing
        End If
    End Sub
    Private Sub analiz_musteri_hareket_ekstre()
        If GridView1.RowCount > 0 Then
            Dim dr As DataRow = GridView1.GetDataRow(GridView1.FocusedRowHandle)
            Dim frm As New frm_cari_ekstre
            frm.firmano = firmano
            frm.donemno = donemno
            frm.connection = connection
            frm.musterino = dr("lKodu")
            frm.musteriID = dr("nMusteriID")
            frm.kullanici = kullanici
            If yetki_kontrol(kullanici, frm.Name) = True Then
                frm.ShowDialog()
            End If
            frm.Close()
            frm.Dispose()
            frm = Nothing
        End If
    End Sub
    Private Sub txt_musteriNo_ButtonClick(ByVal sender As Object, ByVal e As DevExpress.XtraEditors.Controls.ButtonPressedEventArgs) Handles txt_musteriNo.ButtonClick
        firma_sec()
    End Sub
    Private Sub txt_musteriNo_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txt_musteriNo.KeyDown
        If e.KeyCode = Keys.Space Then
            firma_sec()
        ElseIf e.KeyCode = Keys.Enter Then
            If Trim(txt_musteriNo.Text) = "" Then
                firma_sec()
            End If
        End If
    End Sub
    Private Sub GridControl1_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles GridControl1.DoubleClick
        dataload_hareket()
    End Sub
    Private Sub dataload_hareket()
        If GridView1.RowCount > 0 Then
            GridView1.PostEditor()
            dr = GridView1.GetDataRow(GridView1.FocusedRowHandle)
            dr.EndEdit()
            Dim sFisTipi As String = "FA"
            Dim nGirisCikis As Integer = 1
            If sec_nIslem.SelectedIndex = 0 Then
                sFisTipi = "'FA'"
                nGirisCikis = 1
            ElseIf sec_nIslem.SelectedIndex = 1 Then
                sFisTipi = "'FA'"
                nGirisCikis = 1
            ElseIf sec_nIslem.SelectedIndex = 2 Then
                sFisTipi = "'FS','K','P','PF'"
                nGirisCikis = 3
            End If
            dataload_tbStokHareketleri(satir_kontrol(), dr("nFirmaID"), sFisTipi, nGirisCikis, dr("dteTarih1"), dr("dteTarih2"))
        End If
    End Sub
    Private Function satir_kontrol()
        Dim satir As String = "(" '"WHERE stok.nStokId IN ("
        Dim s As String
        Dim arr As Integer()
        Dim i As Integer
        Dim toplamsayi = GridView1.SelectedRowsCount
        Dim sayi = 0
        arr = GridView1.GetSelectedRows()
        Dim dr1 As DataRow
        If arr Is Nothing Then
        Else
            Array.Sort(arr)
            For Each i In arr
                s = i.ToString
                dr1 = GridView1.GetDataRow(s)
                satir += dr1("nKayitID").ToString
                sayi += 1
                If sayi < toplamsayi Then
                    satir += ","
                ElseIf sayi = toplamsayi Then
                    satir += ")"
                End If
            Next
        End If
        Return satir
    End Function
    Private Sub GridControl1_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles GridControl1.KeyDown
        If e.KeyCode = Keys.Escape Then
            If XtraMessageBox.Show(Sorgu_sDil("Ekranı Kapatmak İstediğinize Emin misiniz...?", sDil), Sorgu_sDil("Dikkat", sDil), MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
                Me.Close()
            End If
        End If
    End Sub
    Private Sub MenuItem17_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        txt_musteriNo.EditValue = ""
        txt_musteriNo.Focus()
        txt_musteriNo.SelectAll()
    End Sub
    Private Sub MenuItem16_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        satir_ekle_stok()
    End Sub
    Private Sub GridView1_CellValueChanged(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs) Handles GridView1.CellValueChanged
        If GridView1.RowCount > 0 Then
            GridView1.PostEditor()
            dr = GridView1.GetDataRow(GridView1.FocusedRowHandle)
            dr.EndEdit()
            tbStokTedarik_hesapla()
        End If
    End Sub
    Private Sub SimpleButton2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SimpleButton2.Click
        Me.Close()
    End Sub
    Private Sub SimpleButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SimpleButton1.Click
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
            Label2.Text = Sorgu_sDil("Kayıt Sayısı :", sDil) & GridView1.RowCount & " / " & Sorgu_sDil("Satır :", sDil) & GridView1.FocusedRowHandle + 1 & " / " & Sorgu_sDil("Seçili :", sDil) & GridView1.SelectedRowsCount
        ElseIf GridView1.SelectedRowsCount = 1 Then
            Label2.Text = Sorgu_sDil("Kayıt Sayısı :", sDil) & GridView1.RowCount & " / " & Sorgu_sDil("Satır :", sDil) & GridView1.FocusedRowHandle + 1
        Else
            Label2.Text = ""
        End If
    End Sub
    Private Sub MenuItem24_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem24.Click

        satir_ekle_stok()
    End Sub
    Private Sub MenuItem27_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem27.Click
        txt_musteriNo.EditValue = ""
        txt_musteriNo.Focus()
        txt_musteriNo.SelectAll()
    End Sub
    Private Sub SimpleButton6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        ara()
    End Sub
    Private Sub MenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem1.Click
        If XtraTabControl1.SelectedTabPageIndex = 0 Then
            GridView1.ColumnsCustomization()
        ElseIf XtraTabControl1.SelectedTabPageIndex = 1 Then
            GridView2.ColumnsCustomization()
        ElseIf XtraTabControl1.SelectedTabPageIndex = 2 Then
            GridView3.ColumnsCustomization()
        End If
    End Sub
    Private Sub MenuItem23_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem23.Click
        If MenuItem23.Checked = False Then
            GridView1.OptionsView.ShowAutoFilterRow = True
            GridView1.OptionsView.ShowFilterPanelMode = DevExpress.XtraGrid.Views.Base.ShowFilterPanelMode.Default
            GridView1.OptionsCustomization.AllowFilter = True
            MenuItem23.Checked = True
        ElseIf MenuItem23.Checked = True Then
            GridView1.OptionsView.ShowAutoFilterRow = False
            GridView1.OptionsView.ShowFilterPanelMode = DevExpress.XtraGrid.Views.Base.ShowFilterPanelMode.Never
            GridView1.OptionsCustomization.AllowFilter = False
            MenuItem23.Checked = True
        End If
    End Sub
    Private Sub MenuItem16_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem16.Click
        analiz_envanter()
    End Sub
    Private Sub MenuItem17_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem17.Click
        stok_duzelt()
    End Sub
    Private Sub MenuItem18_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem18.Click
        analiz_stok_hareket()
    End Sub
    Private Sub MenuItem21_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem21.Click
        analiz_hareket_transfer()
    End Sub
    Private Sub MenuItem22_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem22.Click
        stok_fiyat()
    End Sub
    Private Sub MenuItem3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem3.Click
        gorunum_kaydet()
    End Sub
    Private Sub MenuItem5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem5.Click
        GridView1.OptionsView.ShowFilterPanelMode = DevExpress.XtraGrid.Views.Base.ShowFilterPanelMode.Default
        GridView1.OptionsCustomization.AllowFilter = True
    End Sub
    Private Sub MenuItem6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem6.Click
        GridView1.OptionsView.ShowGroupPanel = True
        GridView1.OptionsCustomization.AllowGroup = True
    End Sub
    Private Sub MenuItem7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem7.Click
        GridView1.ExpandAllGroups()
    End Sub
    Private Sub MenuItem8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem8.Click
        GridView1.CollapseAllGroups()
    End Sub
    Private Sub MenuItem9_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem9.Click
        If Me.WindowState = FormWindowState.Normal Then
            Me.WindowState = FormWindowState.Maximized
        ElseIf Me.WindowState = FormWindowState.Maximized Then
            Me.WindowState = FormWindowState.Normal
        End If
    End Sub
    Private Sub MenuItem26_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem26.Click
        stok_sil()
    End Sub
    Private Sub MenuItem4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem4.Click
        If XtraTabControl1.SelectedTabPageIndex = 0 Then
            printlink1.CreateDocument(ps)
            ps.PreviewRibbonFormEx.Show()
        ElseIf XtraTabControl1.SelectedTabPageIndex = 1 Then
            printlink2.CreateDocument(ps)
            ps.PreviewRibbonFormEx.Show()
        ElseIf XtraTabControl1.SelectedTabPageIndex = 2 Then
            printlink3.CreateDocument(ps)
            ps.PreviewRibbonFormEx.Show()
        End If
    End Sub
    Private Sub SimpleButton3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SimpleButton3.Click
        ara()
    End Sub
    Private Sub BarButtonItem1_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnAra.ItemClick
        ara()
    End Sub
    Private Sub BarButtonItem2_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem2.ItemClick

        satir_ekle_stok()
    End Sub
    Private Sub BarButtonItem4_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem4.ItemClick
        stok_duzelt()
    End Sub
    Private Sub BarButtonItem3_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem3.ItemClick
        stok_sil()
    End Sub
    Private Sub BarButtonItem5_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem5.ItemClick
        analiz_envanter()
    End Sub
    Private Sub BarButtonItem6_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem6.ItemClick
        analiz_stok_hareket()
    End Sub
    Private Sub BarButtonItem7_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem7.ItemClick
        analiz_hareket_transfer()
    End Sub
    Private Sub BarButtonItem8_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem8.ItemClick
        stok_fiyat()
    End Sub
    Private Sub BarButtonItem9_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem9.ItemClick
        tbSiparisVer(2)
    End Sub
    Private Sub tbSiparisVer(ByVal nSiparisTipi As Integer)
        Dim dr As DataRow
        Dim dr1 As DataRow
        dr = GridView1.GetDataRow(GridView1.FocusedRowHandle)
        Dim frm As New frm_firma_liste
        frm.firmano = firmano
        frm.donemno = donemno
        frm.connection = connection
        frm.islemstatus = True
        frm.kullanici = kullanici
        Dim nFirmaID As Int64
        Dim sKodu As String = ""
        Dim lSiparisNo As Int64 = 0
        Dim sSatirAciklama As String = ""
        If frm.ShowDialog(Me) = Windows.Forms.DialogResult.OK Then
            dr1 = frm.GridView1.GetDataRow(frm.GridView1.FocusedRowHandle)
            nFirmaID = dr1("nFirmaID")
            sKodu = dr1("sKodu")
            lSiparisNo = sorgu_lSiparisNo(nSiparisTipi)
            'lbl_Firma.Text = dr1("sAciklama")
            'txt_musteriNo.EditValue = sKodu
            dr1 = Nothing
            Dim sayi As Integer = 0
            For Each dr In ds_tbStokTedarikcisi.Tables(0).Rows
                If dr("lIhtiyac") <> 0 Then
                    Dim nSiparisID As Int64 = sorgu_nSiparisID()
                    sSatirAciklama = "Isk1:" & uzunluk_tamamla(FormatNumber(0, 2), 5) & " Isk2:" & uzunluk_tamamla(FormatNumber(0, 2), 5) & " Isk3:" & uzunluk_tamamla(FormatNumber(0, 2), 5) & " Isk4:" & uzunluk_tamamla(FormatNumber(0, 2), 5)
                    tbSiparis_kaydet_yeni(nSiparisID, nSiparisTipi, lSiparisNo, nFirmaID, dr("nStokID"), Today, Today, "", 0, "", "", 1, dr("lIhtiyac"), 0.01, dr("lIhtiyac") * 0.01, "", 0, dr("nKdvOrani"), 0, dr("lIhtiyac") * 0.01, "SA", Now, 0, 0, "", 0, sSatirAciklama, 0, "", 0, 0, "")
                    sayi += 1
                End If
            Next
            If sayi > 0 Then
                Dim frm1 As New frm_tbSiparis
                frm1.firmano = firmano
                frm1.donemno = donemno
                frm1.connection = connection
                frm1.dteSiparisTarihi = Today
                frm1.lSiparisNo = lSiparisNo
                frm1.nFirmaID = nFirmaID
                'frm.txt_musteriNo.EditValue = dr("sFirmaKodu")
                frm1.sSiparisiAlan = ""
                frm1.sSiparisiVeren = ""
                frm1.nSiparisTipi = nSiparisTipi
                frm1.kullanici = kullanici
                frm1.islemstatus = True
                If yetki_kontrol(kullanici, frm1.Name) = True Then
                    frm1.ShowDialog()
                End If
                frm1.Close()
                frm1.Dispose()
                frm1 = Nothing
            End If
        End If
    End Sub
    Private Function uzunluk_tamamla(ByVal deger As String, ByVal uzunluk As Int64, Optional ByVal simge As String = "0") As String
        deger = FormatNumber(deger, 2)
        If Len(deger) < uzunluk Then
            Dim fark As Integer = uzunluk - Len(deger)
            Dim i As Integer
            For i = 1 To fark
                deger = deger.Insert(0, simge)
            Next
        End If
        Return deger
    End Function
    Public Function sorgu_nSiparisID() As Int64
        Dim kriter As String = ""
        'kriter = "WHERE (sKodu = '" & kod & "')  "
        Dim conn As New OleDb.OleDbConnection
        Dim cmd As New OleDb.OleDbCommand
        Dim adapter As New OleDb.OleDbDataAdapter
        'MsgBox(connection_resmi)
        conn.ConnectionString = connection
        cmd.Connection = conn
        conn.Open()
        cmd.CommandText = sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT     TOP 1 ISNULL(nSiparisID + 1, 1) AS nSiparisID FROM         tbSiparis ORDER BY nSiparisID DESC")
        Dim kayitsayisi = cmd.ExecuteScalar
        Return kayitsayisi
    End Function
    Public Function sorgu_lSiparisNo(ByVal nSiparisTipi As Integer) As Int64
        Dim kriter As String = ""
        'kriter = "WHERE (sKodu = '" & kod & "')  "
        Dim conn As New OleDb.OleDbConnection
        Dim cmd As New OleDb.OleDbCommand
        Dim adapter As New OleDb.OleDbDataAdapter
        'MsgBox(connection_resmi)
        conn.ConnectionString = connection
        cmd.Connection = conn
        conn.Open()
        If nSiparisTipi = 1 Then
            cmd.CommandText = sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT     ISNULL(lSonSiparisNo,1) as lSiparisNo FROM         tbParamAlSiparis")
        ElseIf nSiparisTipi = 2 Then
            cmd.CommandText = sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT     ISNULL(lSonSiparisNo,1) as lSiparisNo FROM         tbParamVerSiparis")
        ElseIf nSiparisTipi = 3 Then
            cmd.CommandText = sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT     ISNULL(lSonSiparisNo,1) as lSiparisNo FROM         tbParamVerSiparis")
        ElseIf nSiparisTipi = 4 Then
            cmd.CommandText = sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT     ISNULL(lSonSiparisNo,1) as lSiparisNo FROM         tbParamVerSiparis")
        Else
            cmd.CommandText = sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT     ISNULL(lSonSiparisNo,1) as lSiparisNo FROM         tbParamVerSiparis")
        End If
        Dim kayitsayisi = cmd.ExecuteScalar
        If kayitsayisi = 0 Then
            kayitsayisi = 1
        End If
        Return kayitsayisi
    End Function
    Private Sub tbSiparis_kaydet_yeni(ByVal nSiparisID As Int64, ByVal nSiparisTipi As Int64, ByVal lSiparisNo As Int64, ByVal nFirmaID As Int64, ByVal nStokID As Int64, ByVal dteSiparisTarihi As DateTime, ByVal dteTeslimTarihi As DateTime, ByVal sSiparisIslem As String, ByVal nReceteNo As Int64, ByVal sSiparisiAlan As String, ByVal sSiparisiVeren As String, ByVal sFiyatTipi As String, ByVal lMiktari As Decimal, ByVal lFiyati As Decimal, ByVal lTutari As Decimal, ByVal sAsortiTipi As String, ByVal sAsortiMiktari As String, ByVal nKdvOrani As Int64, ByVal nIskontoYuzdesi As Int64, ByVal lIskontosuzTutari As Decimal, ByVal sKullaniciAdi As String, ByVal dteKayitTarihi As DateTime, ByVal bKapandimi As Integer, ByVal lReserveMiktari As Decimal, ByVal sHangiUygulama As String, ByVal nPartiID As Int64, ByVal sSatirAciklama As String, ByVal nValorGun As Int64, ByVal sDovizCinsi As String, ByVal lDovizFiyati As Decimal, ByVal lDovizKuru As Decimal, ByVal sSaticiRumuzu As String)
        Dim con As New OleDb.OleDbConnection
        Dim cmd As New OleDb.OleDbCommand
        cmd.Connection = con
        con.ConnectionString = connection
        If con.State = ConnectionState.Closed = True Then
            con.Open()
        End If
        'sSiparisiAlan = degeruzunlukkontrol(sSiparisiAlan, 30).ToString + degeruzunlukkontrol(sSiparisiVeren, 30).ToString
        'cmd.CommandText = sorgu_query("SET DATEFORMAT DMY SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED INSERT INTO tbSiparis (nSiparisID, nSiparisTipi, lSiparisNo, nFirmaID, nStokID, dteSiparisTarihi, dteTeslimTarihi, sSiparisIslem, nReceteNo, sSiparisiAlan, sSiparisiVeren, sFiyatTipi, lMiktari, lFiyati, lTutari, sAsortiTipi, sAsortiMiktari, nKdvOrani, nIskontoYuzdesi, lIskontosuzTutari, sKullaniciAdi, dteKayitTarihi, bKapandimi, lReserveMiktari, sHangiUygulama, nPartiID, sSatirAciklama, nValorGun, sDovizCinsi, lDovizFiyati, lDovizKuru,sSaticiRumuzu) VALUES (" & nSiparisID & ", " & nSiparisTipi & ", " & lSiparisNo & ", " & nFirmaID & ", " & nStokID & ", '" & dteSiparisTarihi & "', '" & dteTeslimTarihi & "', '" & sSiparisIslem & "', " & nReceteNo & ", '" & sSiparisiAlan & "', '" & sSiparisiVeren & "', '" & sFiyatTipi & "', " & lMiktari & ", " & lFiyati & ", " & lTutari & ", '" & sAsortiTipi & "', " & sAsortiMiktari & ", " & nKdvOrani & ", " & nIskontoYuzdesi & ", " & lIskontosuzTutari & ", '" & sKullaniciAdi & "', '" & dteKayitTarihi & "', " & bKapandimi & ", " & lReserveMiktari & ", '" & sHangiUygulama & "', " & nPartiID & ", '" & sSatirAciklama & "', " & nValorGun & ", '" & sDovizCinsi & "', " & lDovizFiyati & ", " & lDovizKuru & ",'" & sSaticiRumuzu & "')")
        cmd.CommandText = sorgu_query("SET DATEFORMAT DMY SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED INSERT INTO tbSiparis (nSiparisTipi, lSiparisNo, nFirmaID, nStokID, dteSiparisTarihi, dteTeslimTarihi, sSiparisIslem, nReceteNo, sSiparisiAlan, sSiparisiVeren, sFiyatTipi, lMiktari, lFiyati, lTutari, sAsortiTipi, sAsortiMiktari, nKdvOrani, nIskontoYuzdesi, lIskontosuzTutari, sKullaniciAdi, dteKayitTarihi, bKapandimi, lReserveMiktari, sHangiUygulama, nPartiID, sSatirAciklama, nValorGun, sDovizCinsi, lDovizFiyati, lDovizKuru,sSaticiRumuzu) VALUES (" & nSiparisTipi & ", " & lSiparisNo & ", " & nFirmaID & ", " & nStokID & ", '" & dteSiparisTarihi & "', '" & dteTeslimTarihi & "', '" & sSiparisIslem & "', " & nReceteNo & ", '" & sSiparisiAlan & "', '" & sSiparisiVeren & "', '" & sFiyatTipi & "', " & lMiktari & ", " & lFiyati & ", " & lTutari & ", '" & sAsortiTipi & "', " & sAsortiMiktari & ", " & nKdvOrani & ", " & nIskontoYuzdesi & ", " & lIskontosuzTutari & ", '" & sKullaniciAdi & "', '" & dteKayitTarihi & "', " & bKapandimi & ", " & lReserveMiktari & ", '" & sHangiUygulama & "', " & nPartiID & ", '" & sSatirAciklama & "', " & nValorGun & ", '" & sDovizCinsi & "', " & lDovizFiyati & ", " & lDovizKuru & ",'" & sSaticiRumuzu & "')")
        cmd.ExecuteNonQuery()
        con.Close()
        cmd = Nothing
        con = Nothing
    End Sub
    Private Sub BarButtonItem10_ItemClick(ByVal sender As Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem10.ItemClick
        tbSiparisVer(1)
    End Sub
    Private Sub analiz_Firma_karti()
        If GridView1.RowCount > 0 Then
            Dim dr As DataRow = GridView1.GetDataRow(GridView1.FocusedRowHandle)
            Dim frm As New frm_firma_kart
            frm.firmano = firmano
            frm.donemno = donemno
            frm.connection = connection
            frm.sKodu = dr("sFirmaKodu")
            frm.nFirmaID = dr("nFirmaID")
            frm.kullanici = kullanici
            frm.sModul = "Cari"
            If yetki_kontrol(kullanici, frm.Name) = True Then
                frm.ShowDialog()
                Dim satir = GridView1.FocusedRowHandle
                ara()
                GridView1.FocusedRowHandle = satir
                satir = Nothing
            End If
            frm.Close()
            frm.Dispose()
            frm = Nothing
        End If
    End Sub
    Private Sub analiz_cari_hareket()
        If GridView1.RowCount > 0 Then
            Dim dr As DataRow = GridView1.GetDataRow(GridView1.FocusedRowHandle)
            Dim frm As New frm_cari_hareketler_ozet
            frm.firmano = firmano
            frm.donemno = donemno
            frm.connection = connection
            frm.musterino = dr("sFirmaKodu")
            frm.kullanici = kullanici
            'frm.sDovizCinsi = dr("sDovizCinsi")
            If yetki_kontrol(kullanici, frm.Name) = True Then
                If yetki_kontrol(kullanici, "frm_firma_liste_hesapTuru_" & Trim(CariHesapTuruSorgula(dr("sFirmaKodu")))) = True Then
                    frm.ShowDialog()
                End If
            End If
            frm.Close()
            frm.Dispose()
            frm = Nothing
        End If
    End Sub
    Private Sub MenuItem19_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem19.Click
        analiz_Firma_karti()
    End Sub
    Private Sub MenuItem13_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem13.Click
        analiz_cari_hareket()
    End Sub
    Private Sub MenuItem14_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem14.Click
        If GridView1.RowCount > 0 Then
            If XtraMessageBox.Show(Sorgu_sDil("[" & GridView1.FocusedColumn().Caption & "] Kolonundaki verileri Aşağı Doğru Yaymak istediğinize Emin misiniz...?", sDil), Sorgu_sDil("Dikkat", sDil), MessageBoxButtons.YesNo, MessageBoxIcon.Question) = MsgBoxResult.Yes Then
                'info = False
                Cursor.Current = Cursors.WaitCursor
                Cursor.Show()
                degeryay(GridView1.FocusedColumn().FieldName)
                'info = True
                Cursor.Current = Cursors.Default
                Cursor.Hide()
            End If
        End If
    End Sub
    Public Sub calc()
        Dim frm As New frm_calc
        If frm.ShowDialog = DialogResult.OK Then
            Dim dr As DataRow = GridView1.GetDataRow(GridView1.FocusedRowHandle)
            If GridView1.FocusedColumn.OptionsColumn.AllowEdit = True Then
                dr(GridView1.FocusedColumn().FieldName) = frm.CalcEdit1.EditValue
                tbStokTedarik_hesapla()
            End If
        End If
        frm.Close()
        frm = Nothing
    End Sub
    Private Sub MenuItem25_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem25.Click
        calc()
    End Sub
    Private Sub MenuItem29_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem29.Click
        If bFirma = True Then
            satir_ekle_firma_kopyala()
        Else
            satir_ekle_stok_kopyala()
        End If
    End Sub
    Private Sub BarButtonItem1_ItemClick_1(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem1.ItemClick
        tbFirma_sec()
    End Sub
    Private Sub tbFirma_sec()
        Dim frm As New frm_firma_liste
        frm.islemstatus = True
        frm.connection = connection
        frm.firmano = firmano
        frm.donemno = donemno
        frm.islemstatus = True
        frm.kullanici = kullanici
        If frm.ShowDialog(Me) = Windows.Forms.DialogResult.OK Then
            Dim s As String
            Dim arr As Integer()
            Dim i As Integer
            Dim dr As DataRow
            Dim dr1 As DataRow = frm.GridView1.GetDataRow(frm.GridView1.FocusedRowHandle)
            arr = GridView1.GetSelectedRows()
            If arr Is Nothing Then
            Else
                Array.Sort(arr)
                For Each i In arr
                    s = i.ToString
                    dr = GridView1.GetDataRow(s)
                    dr("nFirmaID") = dr1("nFirmaID")
                    dr("sFirmaKodu") = dr1("sKodu")
                    dr("sFirmaAciklama") = dr1("sAciklama")
                    tbStokTedarikcisi_kaydet_degistir(dr("nKayitID"), dr("nFirmaID"), dr("nIslem"), dr("nStokID"), dr("sDepo"), dr("lMiktar"), dr("nOran"), dr("nIskontoYuzdesi1"), dr("nIskontoYuzdesi2"), dr("nIskontoYuzdesi3"), dr("nIskontoYuzdesi4"), dr("lAlisFiyati"), dr("lMaliyet"), dr("lFiyat"), dr("dteTarih1"), dr("dteTarih2"), dr("sAciklama"), dr("sKullaniciAdi"), dr("dteKayitTarihi"), dr("bAktif"))
                Next
            End If
            ara()
        End If
    End Sub
    Private Sub MenuItem30_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem30.Click
        tbFirma_sec()
    End Sub
    Private Sub sec_nIslem_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles sec_nIslem.SelectedIndexChanged
        If sec_nIslem.SelectedIndex = 0 Then
            collMiktar.Visible = False
            collFiyat.Visible = False
            colnOran.Visible = False
            collMaliyet.Visible = True
            collAlisFiyati.Visible = True
            colnIskontoYuzdesi1.Visible = True
            colnIskontoYuzdesi2.Visible = True
            collFiyatFarki.Visible = False
            collFiyatFarkiTutari.Visible = False
            collFiyatFarkiOrani.Visible = False
            collFiyatFarki.UnboundExpression = "([lAlisFiyati]-[lMaliyet])"
            collFiyatFarkiTutari.UnboundExpression = "([lAlisFiyati]-[lMaliyet])*[lMiktar]"
            collFiyatFarkiOrani.UnboundExpression = "([lAlisFiyati]-[lMaliyet])/[lAlisFiyati]"
            XtraTabPage2.PageVisible = True
        ElseIf sec_nIslem.SelectedIndex = 1 Then
            collMiktar.Visible = True
            collFiyat.Visible = True
            colnOran.Visible = True
            collMaliyet.Visible = True
            collAlisFiyati.Visible = True
            colnIskontoYuzdesi1.Visible = False
            colnIskontoYuzdesi2.Visible = False
            collFiyatFarki.Visible = True
            collFiyatFarkiTutari.Visible = True
            collFiyatFarkiOrani.Visible = True
            collFiyatFarki.UnboundExpression = "([lAlisFiyati]-[lMaliyet])"
            collFiyatFarkiTutari.UnboundExpression = "([lAlisFiyati]-[lMaliyet])*[lMiktar]"
            collFiyatFarkiOrani.UnboundExpression = "([lAlisFiyati]-[lMaliyet])/[lAlisFiyati]"
            XtraTabPage2.PageVisible = False
        ElseIf sec_nIslem.SelectedIndex = 2 Then
            collMiktar.Visible = False
            collFiyat.Visible = True
            colnOran.Visible = True
            collAlisFiyati.Visible = True
            collMaliyet.Visible = True
            colnIskontoYuzdesi1.Visible = False
            colnIskontoYuzdesi2.Visible = False
            collFiyatFarki.Visible = True
            collFiyatFarkiTutari.Visible = True
            collFiyatFarkiOrani.Visible = True
            collFiyatFarki.UnboundExpression = "([lFiyat]-[lMaliyet])+([lAlisFiyati]-[lFiyat])"
            collFiyatFarkiTutari.UnboundExpression = "(([lFiyat]-[lMaliyet])+([lAlisFiyati]-[lFiyat]))*[lMiktar]"
            collFiyatFarkiOrani.UnboundExpression = "(([lFiyat]-[lMaliyet])+([lAlisFiyati]-[lFiyat])) / [lAlisFiyati]"
            XtraTabPage2.PageVisible = True
        End If
        GridView1.RestoreLayoutFromRegistry("SOFTWARE\BusinessSmart\VIEW\MAGAZA\" & Me.Name.ToString & "\" & sec_nIslem.SelectedIndex & " ")
        ara()
    End Sub
    Private Sub XtraTabControl1_SelectedPageChanged(ByVal sender As Object, ByVal e As DevExpress.XtraTab.TabPageChangedEventArgs) Handles XtraTabControl1.SelectedPageChanged
        If XtraTabControl1.SelectedTabPageIndex = 0 Then
        ElseIf XtraTabControl1.SelectedTabPageIndex = 1 Then
            dataload_hareket()
        End If
    End Sub
    Private Sub tbFis_ekle(ByVal sFisTipi As String, ByVal nGirisCikis As Integer)
        If KayitSiniri_kontrol("tbStokFisiMaster", "Where sFisTipi = '" & sFisTipi & "'", nKayitSinir) = True Then
            If yetki_kontrol(kullanici, sFisTipi) = True And yetki_kontrol(kullanici, Trim(sFisTipi) & "_IslemYapamaz", False, 0) = False Then
                Dim frm_firma As New frm_firma_liste
                frm_firma.firmano = firmano
                frm_firma.donemno = donemno
                frm_firma.connection = connection
                frm_firma.islemstatus = True
                frm_firma.kullanici = kullanici
                frm_firma.nGirisCikis = nGirisCikis
                frm_firma.bFis = True
                frm_firma.sModul = "Fatura"
                If frm_firma.ShowDialog(Me) = Windows.Forms.DialogResult.OK Then
                    Dim dr1 As DataRow
                    dr1 = frm_firma.GridView1.GetDataRow(frm_firma.GridView1.FocusedRowHandle)
                    'If nGirisCikis <> 3 Then
                    '    dr1("bSatisYapilamaz") = True
                    'End If
                    If dr1("bSatisYapilamaz") = False Then
                        Dim frm As New frm_fatura
                        frm.firmano = firmano
                        frm.donemno = donemno
                        frm.connection = connection
                        frm.kullanici = kullanici
                        frm.nStokFisiID = ""
                        frm.nFirmaID = dr1("nFirmaID")
                        frm.nOpsiyon = sorgu_sayi(dr1("nVadeGun"), 0)
                        If Trim(dr1("sDovizCinsi")) <> "" Then
                            frm.sDovizCinsi1 = Trim(dr1("sDovizCinsi").ToString)
                            frm.lDovizKuru1 = sorgu_lDovizKuru(Trim(dr1("sDovizCinsi").ToString))
                        End If
                        frm.sFisTipi = sFisTipi
                        If sFisTipi = "HS " Or sFisTipi = "HA " Then
                            frm.bHizmetFaturasimi = True
                        End If
                        frm.nGirisCikis = nGirisCikis
                        frm.dteFisTarihi = dteSistemTarihi
                        'frm.MdiParent = Me
                        If yetki_kontrol(kullanici, frm.Name) = True Then
                            frm.Show()
                        End If
                    Else
                        XtraMessageBox.Show(Sorgu_sDil("Seçtiğiniz Hesabın Satış Yetkisi Yok, Lütfen Kontrol Ediniz...!", sDil), Sorgu_sDil("Dikkat", sDil), MessageBoxButtons.OK, MessageBoxIcon.Warning)
                    End If
                    'frm.Close()
                    'frm.Dispose()
                    'frm = Nothing
                End If
            End If
        End If
    End Sub
    Private Sub MenuItem31_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem31.Click
        tbFis_ekle("HS ", 3)
    End Sub
    Private Sub MenuItem33_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem33.Click
        If XtraMessageBox.Show(Sorgu_sDil("Seçili Satırları Fiyat Değişim Föyüne Aktarmak İstediğinize Emin misiniz...?", sDil), Sorgu_sDil("Dikkat", sDil), MessageBoxButtons.YesNo, MessageBoxIcon.Question) = MsgBoxResult.Yes Then
            Dim evrakno As Int64 = fiyatDegisim_baslik_kaydet_yeni(Today, Now.Day, "Aktarım", sec_nIslem.Text, "", "", "", "", "Bekliyor...", 0)
            Dim s As String
            Dim arr As Integer()
            Dim i As Integer
            Dim dr1 As DataRow
            arr = GridView1.GetSelectedRows()
            If arr Is Nothing Then
            Else
                Array.Sort(arr)
                For Each i In arr
                    s = i.ToString
                    dr1 = GridView1.GetDataRow(s)
                    Dim oran1 As Decimal = 0
                    Dim oran2 As Decimal = 0
                    Dim oran3 As Decimal = 0
                    Dim oran4 As Decimal = 0
                    dr1("PESIN") = sorgu_sayi(dr1("PESIN"), 0)
                    dr1("ALTIAY") = sorgu_sayi(dr1("ALTIAY"), 0)
                    dr1("ONAY") = sorgu_sayi(dr1("ONAY"), 0)
                    dr1("ONBESAY") = sorgu_sayi(dr1("ONBESAY"), 0)
                    Try
                        If dr1("PESIN") <> 0 Then
                            oran1 = ((dr1("PESIN") - dr1("MALIYET")) / dr1("MALIYET")) * 100
                        Else
                            oran1 = 0
                        End If
                    Catch ex As Exception
                    End Try
                    Try
                        If dr1("ALTIAY") <> 0 Then
                            oran2 = ((dr1("ALTIAY") - dr1("MALIYET")) / dr1("MALIYET")) * 100
                        Else
                            oran2 = 0
                        End If
                    Catch ex As Exception
                    End Try
                    Try
                        If dr1("ONAY") <> 0 Then
                            oran3 = ((dr1("ONAY") - dr1("MALIYET")) / dr1("MALIYET")) * 100
                        Else
                            oran3 = 0
                        End If
                    Catch ex As Exception
                    End Try
                    Try
                        If dr1("ONBESAY") <> 0 Then
                            oran4 = ((dr1("ONBESAY") - dr1("MALIYET")) / dr1("MALIYET")) * 100
                        Else
                            oran4 = 0
                        End If
                    Catch ex As Exception
                    End Try
                    fiyatDegisim_hareket_kaydet_yeni(evrakno, Today, Today, Now.Day, "", "", dr1("nStokID"), dr1("sStokKodu").ToString, dr1("sStokAciklama").ToString, sorgu_sayi(dr1("lMiktar"), 0), sorgu_sayi(dr1("lAlisFiyati"), 0), sorgu_sayi(dr1("lFiyat"), 0), 0, 0, sorgu_sayi(dr1("lFiyat"), 0), sorgu_sayi(dr1("lMiktar"), 0), sorgu_sayi(dr1("lFiyat"), 0), 0, dr1("sRenkAdi").ToString, sorgu_sayi(dr1("PESIN"), 0), sorgu_sayi(dr1("ONAY"), 0), sorgu_sayi(dr1("ALTIAY"), 0), 0, oran1, oran2, oran3, sorgu_sayi(dr1("lMaliyet"), 0), 0, "01/01/1900", "01/01/1900", sorgu_sayi(dr1("lMaliyet"), 0), 0, "", sorgu_sayi(dr1("PESIN"), 0), sorgu_sayi(dr1("ALTIAY"), 0), sorgu_sayi(dr1("ONAY"), 0), sorgu_sayi(dr1("MALIYET"), 0), sorgu_sayi(dr1("ONBESAY"), 0), oran4, sorgu_sayi(dr1("ONBESAY"), 0))
                    'stok_islemleri.kart_sil(dr1("IND"), False)
                    'If stok_islemleri.sil = True Then
                    '    'dr1.Delete()
                    '    'dr1.AcceptChanges()
                    'End If
                Next
            End If
            s = Nothing
            arr = Nothing
            i = Nothing
            dr1 = Nothing
            XtraMessageBox.Show(Sorgu_sDil("İşlem Tamamlandı...", sDil), Sorgu_sDil("Dikkat", sDil), MessageBoxButtons.OK, MessageBoxIcon.Information)
            Dim frm As New frm_stok_fiyat_degisim
            frm.connection = connection
            frm.firmano = firmano
            frm.donemno = donemno
            frm.belgeind = evrakno
            frm.status = True
            frm.kullanici = kullanici
            If yetki_kontrol(kullanici, frm.Name) = True Then
                frm.ShowDialog()
            End If
            frm.Close()
            frm.Dispose()
            frm = Nothing
        End If
    End Sub
    Private Function fiyatDegisim_baslik_kaydet_yeni(ByVal TARIH As DateTime, ByVal BELGENO As String, ByVal ACIKLAMA As String, ByVal KOD1 As String, ByVal KOD2 As String, ByVal KOD3 As String, ByVal KOD4 As String, ByVal KOD5 As String, ByVal SONUC As String, ByVal bKilitli As Byte) As Int64
        Dim cmd As New OleDb.OleDbCommand
        Dim con As New OleDb.OleDbConnection
        cmd.Connection = con
        con.ConnectionString = connection
        If con.State = ConnectionState.Closed = True Then
            con.Open()
        End If
        cmd.CommandText = sorgu_query("SET DATEFORMAT DMY INSERT INTO ASTOKFIYATDEGISIMBASLIK                       (TARIH, BELGENO, ACIKLAMA, KOD1, KOD2, KOD3, KOD4, KOD5, SONUC,bKilitli) VALUES     ('" & TARIH & "', '" & BELGENO & "', '" & ACIKLAMA & "', '" & KOD1 & "', '" & KOD2 & "', '" & KOD3 & "', '" & KOD4 & "', '" & KOD5 & "', '" & SONUC & "'," & bKilitli & ")")
        cmd.ExecuteNonQuery()
        cmd.CommandText = "SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT @@identity"
        Dim hareketno = cmd.ExecuteScalar
        con.Close()
        Return hareketno
        cmd.Dispose()
        con.Dispose()
        cmd = Nothing
        con = Nothing
    End Function
    Private Function fiyatDegisim_hareket_kaydet_yeni(ByVal EVRAKNO As Int64, ByVal TARIH As DateTime, ByVal FISTARIHI As DateTime, ByVal FISNO As String, ByVal FIRMAKODU As String, ByVal FIRMAADI As String, ByVal STOKNO As Int64, ByVal STOKKODU As String, ByVal STOKADI As String, ByVal MIKTAR As Decimal, ByVal BIRIMMALIYET As Decimal, ByVal BIRIMFIYAT As Decimal, ByVal ISKONTO As Decimal, ByVal KDV As Decimal, ByVal KDVLITUTAR As Decimal, ByVal FATURAMIKTARI As Decimal, ByVal FATURATUTARI As Decimal, ByVal EKMALIYET As Decimal, ByVal RENK As String, ByVal PESIN As Decimal, ByVal ONAY As Decimal, ByVal ALTIAY As Decimal, ByVal ORANEKMALIYET As Decimal, ByVal ORAN1 As Decimal, ByVal ORAN2 As Decimal, ByVal ORAN3 As Decimal, ByVal SONALISMALIYETI As Decimal, ByVal ONCEKIALISMALIYETI As Decimal, ByVal ONCEKIALISTARIHI As DateTime, ByVal SONALISTARIHI As DateTime, ByVal NETMALIYET As Decimal, ByVal STATUS As Integer, ByVal SONUC As String, ByVal FIYAT1 As Decimal, ByVal FIYAT2 As Decimal, ByVal FIYAT3 As Decimal, ByVal MALIYET As Decimal, ByVal ONBESAY As Decimal, ByVal ORAN4 As Decimal, ByVal FIYAT4 As Decimal) As Int64
        Dim cmd As New OleDb.OleDbCommand
        Dim con As New OleDb.OleDbConnection
        cmd.Connection = con
        con.ConnectionString = connection
        If con.State = ConnectionState.Closed = True Then
            con.Open()
        End If
        cmd.CommandText = sorgu_query("SET DATEFORMAT DMY INSERT INTO ASTOKFIYATDEGISIMDETAY                       (EVRAKNO, TARIH, FISTARIHI, FISNO, FIRMAKODU, FIRMAADI, STOKNO, STOKKODU, STOKADI, MIKTAR, BIRIMMALIYET, BIRIMFIYAT, ISKONTO, KDV,  KDVLITUTAR, FATURAMIKTARI, FATURATUTARI, EKMALIYET, RENK, PESIN, ONAY, ALTIAY, ORANEKMALIYET, ORAN1, ORAN2, ORAN3, SONALISMALIYETI, ONCEKIALISMALIYETI, ONCEKIALISTARIHI, SONALISTARIHI, NETMALIYET, STATUS, SONUC,FIYAT1,FIYAT2,FIYAT3,MALIYET,ONBESAY,ORAN4,FIYAT4) VALUES     (" & EVRAKNO & ", '" & TARIH & "', '" & FISTARIHI & "', '" & FISNO & "', '" & FIRMAKODU & "', '" & FIRMAADI & "', " & STOKNO & ", '" & STOKKODU & "', '" & STOKADI & "', " & MIKTAR & " , " & BIRIMMALIYET & " , " & BIRIMFIYAT & " , " & ISKONTO & ", " & KDV & ", " & KDVLITUTAR & ", " & FATURAMIKTARI & " , " & FATURATUTARI & " , " & EKMALIYET & " , '" & RENK & "', " & PESIN & " , " & ONAY & " , " & ALTIAY & " , " & ORANEKMALIYET & " , " & ORAN1 & " , " & ORAN2 & " , " & ORAN3 & " , " & SONALISMALIYETI & " , " & ONCEKIALISMALIYETI & " , '" & ONCEKIALISTARIHI & "', '" & SONALISTARIHI & "' , " & NETMALIYET & ", " & STATUS & ", '" & SONUC & "'," & FIYAT1 & "," & FIYAT2 & "," & FIYAT3 & "," & MALIYET & "," & ONBESAY & "," & ORAN4 & "," & FIYAT4 & ")")
        cmd.ExecuteNonQuery()
        cmd.CommandText = "SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT @@identity"
        Dim hareketno = cmd.ExecuteScalar
        con.Close()
        Return hareketno
        cmd.Dispose()
        con.Dispose()
        cmd = Nothing
        con = Nothing
    End Function
End Class