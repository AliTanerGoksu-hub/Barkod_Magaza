Imports System.Data.SqlClient
Imports System.Collections.Generic
Imports DevExpress.XtraGrid.Views.Grid
Imports DevExpress.XtraEditors
Imports Microsoft.Win32

''' <summary>
''' Cari Stok Listesi Raporu
''' Firmadan alınan ürünlerin alış/satış/stok durumunu ve borç hesaplamasını gösterir
''' Sonradan teslimli ürünleri hesapla seçeneği ile bekleyen siparişleri de dahil eder
''' </summary>
Public Class frm_CariStokListesi

    Public connection As String = ""
    Private dtRapor As DataTable
    Private dtFirmaOzet As DataTable

    ''' <summary>
    ''' Connection string'den Provider parametresini kaldırır (SqlConnection uyumluluğu için)
    ''' </summary>
    Private Function GetSqlConnectionString() As String
        Dim connStr As String = connection
        ' Provider parametresini kaldır
        If connStr.ToLower().Contains("provider=") Then
            Dim parts As String() = connStr.Split(";"c)
            Dim cleanParts As New List(Of String)
            For Each part As String In parts
                If Not part.Trim().ToLower().StartsWith("provider=") Then
                    If part.Trim().Length > 0 Then
                        cleanParts.Add(part.Trim())
                    End If
                End If
            Next
            connStr = String.Join(";", cleanParts.ToArray())
        End If
        Return connStr
    End Function

#Region "Form Events"

    Private Sub frm_CariStokListesi_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            ' Firma listesini yükle
            YukleFirmaListesi()

            ' Tarih aralığını ayarla (varsayılan: bu yıl)
            dtBaslangic.DateTime = New DateTime(DateTime.Now.Year, 1, 1)
            dtBitis.DateTime = DateTime.Now

            ' Kaydedilmiş görünümü yükle
            GorunumYukle()

        Catch ex As Exception
            MsgBox("Form yüklenirken hata: " & ex.Message, MsgBoxStyle.Critical)
        End Try
    End Sub

    Private Sub btnRaporla_Click(sender As Object, e As EventArgs) Handles btnRaporla.Click
        Try
            If cmbFirma.EditValue Is Nothing OrElse cmbFirma.EditValue.ToString() = "" Then
                MsgBox("Lütfen bir firma seçin!", MsgBoxStyle.Exclamation)
                Return
            End If

            Me.Cursor = Cursors.WaitCursor
            lblDurum.Text = "Rapor hazırlanıyor..."
            Application.DoEvents()

            Dim nFirmaID As Integer = Convert.ToInt32(cmbFirma.EditValue)
            Dim sonradanTeslimliHesapla As Boolean = chkSonradanTeslimli.Checked
            Dim ozetMod As Boolean = (Convert.ToInt32(rgGorunumTipi.EditValue) = 1)

            ' Raporu oluştur
            If ozetMod Then
                OlusturOzetRapor(nFirmaID, sonradanTeslimliHesapla)
            Else
                OlusturRapor(nFirmaID, sonradanTeslimliHesapla)
            End If

            lblDurum.Text = "Rapor hazır."
            Me.Cursor = Cursors.Default

        Catch ex As Exception
            Me.Cursor = Cursors.Default
            lblDurum.Text = "Hata!"
            MsgBox("Rapor oluşturulurken hata: " & ex.Message, MsgBoxStyle.Critical)
        End Try
    End Sub

    Private Sub chkSonradanTeslimli_CheckedChanged(sender As Object, e As EventArgs) Handles chkSonradanTeslimli.CheckedChanged
        ' Checkbox değiştiğinde sütunları göster/gizle
        If gridViewRapor IsNot Nothing Then
            Dim colBekleyenSiparis As DevExpress.XtraGrid.Columns.GridColumn = gridViewRapor.Columns.ColumnByFieldName("BekleyenSiparis")
            Dim colBekleyenTutar As DevExpress.XtraGrid.Columns.GridColumn = gridViewRapor.Columns.ColumnByFieldName("BekleyenTutar")
            Dim colNetStok As DevExpress.XtraGrid.Columns.GridColumn = gridViewRapor.Columns.ColumnByFieldName("NetStok")

            If colBekleyenSiparis IsNot Nothing Then colBekleyenSiparis.Visible = chkSonradanTeslimli.Checked
            If colBekleyenTutar IsNot Nothing Then colBekleyenTutar.Visible = chkSonradanTeslimli.Checked
            If colNetStok IsNot Nothing Then colNetStok.Visible = chkSonradanTeslimli.Checked
        End If
    End Sub

    Private Sub btnExcel_Click(sender As Object, e As EventArgs) Handles btnExcel.Click
        Try
            If dtRapor Is Nothing OrElse dtRapor.Rows.Count = 0 Then
                MsgBox("Önce rapor oluşturun!", MsgBoxStyle.Exclamation)
                Return
            End If

            Dim saveDialog As New SaveFileDialog()
            saveDialog.Filter = "Excel Dosyası (*.xlsx)|*.xlsx"
            saveDialog.FileName = "CariStokListesi_" & DateTime.Now.ToString("yyyyMMdd_HHmmss")

            If saveDialog.ShowDialog() = DialogResult.OK Then
                gridControlRapor.ExportToXlsx(saveDialog.FileName)
                MsgBox("Excel dosyası kaydedildi: " & saveDialog.FileName, MsgBoxStyle.Information)
            End If
        Catch ex As Exception
            MsgBox("Excel export hatası: " & ex.Message, MsgBoxStyle.Critical)
        End Try
    End Sub

    Private Sub btnGorunumDuzenle_Click(sender As Object, e As EventArgs) Handles btnGorunumDuzenle.Click
        Try
            ' GridView sütun özelleştirme penceresi aç
            gridViewRapor.ColumnsCustomization()
        Catch ex As Exception
            MsgBox("Görünüm düzenleme hatası: " & ex.Message, MsgBoxStyle.Critical)
        End Try
    End Sub

    Private Sub btnGorunumKaydet_Click(sender As Object, e As EventArgs) Handles btnGorunumKaydet.Click
        Try
            GorunumKaydet()
        Catch ex As Exception
            MsgBox("Görünüm kaydetme hatası: " & ex.Message, MsgBoxStyle.Critical)
        End Try
    End Sub

    Private Sub btnYazdir_Click(sender As Object, e As EventArgs) Handles btnYazdir.Click
        Try
            If dtRapor Is Nothing OrElse dtRapor.Rows.Count = 0 Then
                MsgBox("Önce rapor oluşturun!", MsgBoxStyle.Exclamation)
                Return
            End If

            ' Yazdırma önizleme penceresini aç
            gridControlRapor.ShowPrintPreview()
        Catch ex As Exception
            MsgBox("Yazdırma hatası: " & ex.Message, MsgBoxStyle.Critical)
        End Try
    End Sub

    Private Sub GorunumKaydet()
        Try
            gridViewRapor.SaveLayoutToRegistry("SOFTWARE\BusinessSmart\VIEW\MAGAZA\CariStokListesi\" & Me.Name.ToString & "")
            MsgBox("Görünüm kaydedildi!", MsgBoxStyle.Information, "Bilgi")
        Catch ex As Exception
            MsgBox("Görünüm kaydedilemedi: " & ex.Message, MsgBoxStyle.Critical)
        End Try
    End Sub

    Private Sub GorunumYukle()
        Try
            gridViewRapor.RestoreLayoutFromRegistry("SOFTWARE\BusinessSmart\VIEW\MAGAZA\CariStokListesi\" & Me.Name.ToString & "")
        Catch ex As Exception
            ' İlk açılışta kayıt olmayabilir, hata vermesin
        End Try
    End Sub

#End Region

#Region "Data Methods"

    Private Sub YukleFirmaListesi()
        Try
            Using conn As New SqlConnection(GetSqlConnectionString())
                conn.Open()
                ' Sadece sKodu 320 ile başlayan firmaları getir
                Dim query As String = "SELECT nFirmaID, sKodu + ' - ' + sAciklama AS FirmaAdi FROM tbFirma WHERE sKodu LIKE '320%' ORDER BY sKodu"
                Dim dt As New DataTable()
                Dim adapter As New SqlDataAdapter(query, conn)
                adapter.Fill(dt)

                ' Tüm Firmalar seçeneği ekle (320% ile başlayanlar)
                Dim tumFirmalarRow As DataRow = dt.NewRow()
                tumFirmalarRow("nFirmaID") = -1
                tumFirmalarRow("FirmaAdi") = "*** TÜM FİRMALAR (320%) ***"
                dt.Rows.InsertAt(tumFirmalarRow, 0)

                cmbFirma.Properties.DataSource = dt
                cmbFirma.Properties.DisplayMember = "FirmaAdi"
                cmbFirma.Properties.ValueMember = "nFirmaID"
            End Using
        Catch ex As Exception
            MsgBox("Firma listesi yüklenirken hata: " & ex.Message, MsgBoxStyle.Critical)
        End Try
    End Sub

    Private Sub OlusturRapor(nFirmaID As Integer, sonradanTeslimliHesapla As Boolean)
        Try
            Using conn As New SqlConnection(GetSqlConnectionString())
                conn.Open()

                Dim tarihBaslangic As String = dtBaslangic.DateTime.ToString("yyyy-MM-dd")
                Dim tarihBitis As String = dtBitis.DateTime.ToString("yyyy-MM-dd")

                ' Firma filtresi - Tüm Firmalar seçiliyse sKodu LIKE '320%'
                Dim firmaKosulu As String = ""
                If nFirmaID = -1 Then
                    firmaKosulu = "f.sKodu LIKE '320%'"
                Else
                    firmaKosulu = "d.nFirmaID = @nFirmaID"
                End If

                ' Ana rapor sorgusu (DETAY)
                ' Firma bazlı ürün alış/satış/stok durumu + bekleyen siparişler
                ' NOT: tbAlisVeris'de nFirmaID yok, tbStokFisiDetayi üzerinden nFirmaID kullanılıyor
                ' Maliyet: Satış anındaki alış fiyatı üzerinden hesaplanıyor (lGirisFiyat alanından)
                
                Dim query As String = "
                    SET DATEFORMAT YMD
                    SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED
                    
                    SELECT 
                        f.sKodu AS FirmaKodu,
                        f.sAciklama AS FirmaAdi,
                        st.sKodu AS UrunKodu,
                        st.sAciklama AS UrunAdi,
                        ISNULL((SELECT TOP 1 sBarkod FROM tbStokBarkodu WHERE nStokID = st.nStokID), '') AS Barkod,
                        ISNULL(SUM(d.lGirisMiktar1), 0) AS AlisMiktari,
                        ISNULL((SELECT SUM(lCikisMiktar1) FROM tbStokFisiDetayi WHERE nStokID = d.nStokID AND sFisTipi IN ('FS', 'PF') AND dteFisTarihi BETWEEN @tarihBaslangic AND @tarihBitis), 0) AS SatisMiktari,
                        ISNULL(SUM(d.lGirisMiktar1), 0) - ISNULL((SELECT SUM(lCikisMiktar1) FROM tbStokFisiDetayi WHERE nStokID = d.nStokID AND sFisTipi IN ('FS', 'PF') AND dteFisTarihi BETWEEN @tarihBaslangic AND @tarihBitis), 0) AS KalanStok,
                        ISNULL((SELECT SUM(s.lGCMiktar) FROM tbAlisVerisSiparis s WHERE s.nStokID = d.nStokID AND s.bTeslimEdildi = 0), 0) AS BekleyenSiparis,
                        ISNULL(SUM(d.lGirisMiktar1), 0) - ISNULL((SELECT SUM(lCikisMiktar1) FROM tbStokFisiDetayi WHERE nStokID = d.nStokID AND sFisTipi IN ('FS', 'PF') AND dteFisTarihi BETWEEN @tarihBaslangic AND @tarihBitis), 0) - ISNULL((SELECT SUM(s.lGCMiktar) FROM tbAlisVerisSiparis s WHERE s.nStokID = d.nStokID AND s.bTeslimEdildi = 0), 0) AS NetStok,
                        ISNULL(SUM(d.lGirisTutar - d.lIskontoTutari), 0) AS AlisTutari,
                        ISNULL((SELECT SUM(lCikisTutar - lIskontoTutari) FROM tbStokFisiDetayi WHERE nStokID = d.nStokID AND sFisTipi IN ('FS', 'PF') AND dteFisTarihi BETWEEN @tarihBaslangic AND @tarihBitis), 0) AS SatisTutari,
                        ISNULL((SELECT SUM(s.lBrutTutar - s.lIskontoTutari) FROM tbAlisVerisSiparis s WHERE s.nStokID = d.nStokID AND s.bTeslimEdildi = 0), 0) AS BekleyenTutar,
                        ISNULL(SUM(d.lIskontoTutari), 0) AS AlisIskontoTutari,
                        ISNULL((SELECT SUM(lIskontoTutari) FROM tbStokFisiDetayi WHERE nStokID = d.nStokID AND sFisTipi IN ('FS', 'PF') AND dteFisTarihi BETWEEN @tarihBaslangic AND @tarihBitis), 0) AS SatisIskontoTutari,
                        ISNULL(AVG(d.lGirisFiyat), 0) AS AlisFiyati,
                        ISNULL((SELECT AVG(lCikisFiyat) FROM tbStokFisiDetayi WHERE nStokID = d.nStokID AND sFisTipi IN ('FS', 'PF') AND dteFisTarihi BETWEEN @tarihBaslangic AND @tarihBitis), 0) AS SatisFiyati,
                        -- Maliyet: Satış Miktarı × Ortalama Alış Fiyatı
                        ISNULL((SELECT SUM(lCikisMiktar1) FROM tbStokFisiDetayi WHERE nStokID = d.nStokID AND sFisTipi IN ('FS', 'PF') AND dteFisTarihi BETWEEN @tarihBaslangic AND @tarihBitis), 0) * ISNULL(AVG(d.lGirisFiyat), 0) AS SatisMaliyeti,
                        -- Kar: Net Satış Tutarı - Maliyet
                        ISNULL((SELECT SUM(lCikisTutar - lIskontoTutari) FROM tbStokFisiDetayi WHERE nStokID = d.nStokID AND sFisTipi IN ('FS', 'PF') AND dteFisTarihi BETWEEN @tarihBaslangic AND @tarihBitis), 0) 
                        - (ISNULL((SELECT SUM(lCikisMiktar1) FROM tbStokFisiDetayi WHERE nStokID = d.nStokID AND sFisTipi IN ('FS', 'PF') AND dteFisTarihi BETWEEN @tarihBaslangic AND @tarihBitis), 0) * ISNULL(AVG(d.lGirisFiyat), 0)) AS Kar,
                        -- Karlılık %: (Kar / Maliyet) * 100
                        CASE 
                            WHEN (ISNULL((SELECT SUM(lCikisMiktar1) FROM tbStokFisiDetayi WHERE nStokID = d.nStokID AND sFisTipi IN ('FS', 'PF') AND dteFisTarihi BETWEEN @tarihBaslangic AND @tarihBitis), 0) * ISNULL(AVG(d.lGirisFiyat), 0)) > 0 
                            THEN (
                                (ISNULL((SELECT SUM(lCikisTutar - lIskontoTutari) FROM tbStokFisiDetayi WHERE nStokID = d.nStokID AND sFisTipi IN ('FS', 'PF') AND dteFisTarihi BETWEEN @tarihBaslangic AND @tarihBitis), 0) 
                                - (ISNULL((SELECT SUM(lCikisMiktar1) FROM tbStokFisiDetayi WHERE nStokID = d.nStokID AND sFisTipi IN ('FS', 'PF') AND dteFisTarihi BETWEEN @tarihBaslangic AND @tarihBitis), 0) * ISNULL(AVG(d.lGirisFiyat), 0)))
                                / NULLIF((ISNULL((SELECT SUM(lCikisMiktar1) FROM tbStokFisiDetayi WHERE nStokID = d.nStokID AND sFisTipi IN ('FS', 'PF') AND dteFisTarihi BETWEEN @tarihBaslangic AND @tarihBitis), 0) * ISNULL(AVG(d.lGirisFiyat), 0)), 0)
                            ) * 100
                            ELSE 0
                        END AS Karlilik
                    FROM tbStokFisiDetayi d
                    INNER JOIN tbFirma f ON d.nFirmaID = f.nFirmaID
                    INNER JOIN tbStok st ON d.nStokID = st.nStokID
                    WHERE d.sFisTipi = 'FA'
                        AND " & firmaKosulu & "
                        AND d.dteFisTarihi BETWEEN @tarihBaslangic AND @tarihBitis
                    GROUP BY f.sKodu, f.sAciklama, st.sKodu, st.sAciklama, st.nStokID, d.nStokID
                    HAVING SUM(d.lGirisMiktar1) > 0
                    ORDER BY f.sKodu, st.sKodu
                "

                dtRapor = New DataTable()
                Using cmd As New SqlCommand(query, conn)
                    If nFirmaID <> -1 Then
                        cmd.Parameters.AddWithValue("@nFirmaID", nFirmaID)
                    End If
                    cmd.Parameters.AddWithValue("@tarihBaslangic", tarihBaslangic)
                    cmd.Parameters.AddWithValue("@tarihBitis", tarihBitis)
                    cmd.CommandTimeout = 120

                    Using adapter As New SqlDataAdapter(cmd)
                        adapter.Fill(dtRapor)
                    End Using
                End Using

                ' Grid'e bağla
                gridControlRapor.DataSource = dtRapor
                AyarlaGridSutunlari(sonradanTeslimliHesapla)

                ' Firma özet bilgisini hesapla
                HesaplaFirmaOzet(conn, nFirmaID, tarihBaslangic, tarihBitis, sonradanTeslimliHesapla)

            End Using
        Catch ex As Exception
            Throw New Exception("Rapor oluşturma hatası: " & ex.Message)
        End Try
    End Sub

    ''' <summary>
    ''' Özet rapor - Firma bazlı toplamlar (ürün detayı yok)
    ''' </summary>
    Private Sub OlusturOzetRapor(nFirmaID As Integer, sonradanTeslimliHesapla As Boolean)
        Try
            Using conn As New SqlConnection(GetSqlConnectionString())
                conn.Open()

                Dim tarihBaslangic As String = dtBaslangic.DateTime.ToString("yyyy-MM-dd")
                Dim tarihBitis As String = dtBitis.DateTime.ToString("yyyy-MM-dd")

                ' Firma filtresi - Tüm Firmalar seçiliyse sKodu LIKE '320%'
                Dim firmaKosulu As String = ""
                If nFirmaID = -1 Then
                    firmaKosulu = "f.sKodu LIKE '320%'"
                Else
                    firmaKosulu = "d.nFirmaID = @nFirmaID"
                End If

                ' ÖZET rapor sorgusu - Firma bazlı toplamlar
                ' CTE için firma koşulu (f.sKodu yerine d.nFirmaID kullanılır)
                Dim cteFirmaKosulu As String = ""
                If nFirmaID = -1 Then
                    cteFirmaKosulu = "d.nFirmaID IN (SELECT nFirmaID FROM tbFirma WHERE sKodu LIKE '320%')"
                Else
                    cteFirmaKosulu = "d.nFirmaID = @nFirmaID"
                End If

                Dim query As String = "
                    SET DATEFORMAT YMD
                    SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED
                    
                    ;WITH FirmaUrunleri AS (
                        SELECT DISTINCT d.nFirmaID, d.nStokID
                        FROM tbStokFisiDetayi d
                        WHERE d.sFisTipi = 'FA'
                        AND " & cteFirmaKosulu & "
                        AND d.dteFisTarihi BETWEEN @tarihBaslangic AND @tarihBitis
                    ),
                    UrunMaliyetleri AS (
                        SELECT 
                            fu.nFirmaID,
                            fu.nStokID,
                            ISNULL((SELECT AVG(alis.lGirisFiyat) FROM tbStokFisiDetayi alis WHERE alis.nStokID = fu.nStokID AND alis.sFisTipi = 'FA'), 0) AS OrtAlisFiyati
                        FROM FirmaUrunleri fu
                    ),
                    SatisVerileri AS (
                        SELECT 
                            um.nFirmaID,
                            SUM(satis.lCikisMiktar1) AS SatisMiktari,
                            SUM(satis.lCikisTutar - satis.lIskontoTutari) AS SatisTutari,
                            SUM(satis.lCikisMiktar1 * um.OrtAlisFiyati) AS Maliyet
                        FROM tbStokFisiDetayi satis
                        INNER JOIN UrunMaliyetleri um ON satis.nStokID = um.nStokID
                        WHERE satis.sFisTipi IN ('FS', 'PF')
                        AND satis.dteFisTarihi BETWEEN @tarihBaslangic AND @tarihBitis
                        GROUP BY um.nFirmaID
                    )
                    SELECT 
                        f.sKodu AS FirmaKodu,
                        f.sAciklama AS FirmaAdi,
                        (SELECT COUNT(DISTINCT fu.nStokID) FROM FirmaUrunleri fu WHERE fu.nFirmaID = f.nFirmaID) AS UrunCesidi,
                        ISNULL(SUM(d.lGirisMiktar1), 0) AS ToplamAlisMiktari,
                        ISNULL((SELECT sv.SatisMiktari FROM SatisVerileri sv WHERE sv.nFirmaID = f.nFirmaID), 0) AS ToplamSatisMiktari,
                        ISNULL(SUM(d.lGirisTutar - d.lIskontoTutari), 0) AS ToplamAlisTutari,
                        ISNULL((SELECT sv.SatisTutari FROM SatisVerileri sv WHERE sv.nFirmaID = f.nFirmaID), 0) AS ToplamSatisTutari,
                        ISNULL((SELECT sv.Maliyet FROM SatisVerileri sv WHERE sv.nFirmaID = f.nFirmaID), 0) AS ToplamMaliyet,
                        ISNULL((SELECT sv.SatisTutari FROM SatisVerileri sv WHERE sv.nFirmaID = f.nFirmaID), 0) 
                        - ISNULL((SELECT sv.Maliyet FROM SatisVerileri sv WHERE sv.nFirmaID = f.nFirmaID), 0) AS ToplamKar,
                        ISNULL((
                            SELECT SUM(s.lGCMiktar) 
                            FROM tbAlisVerisSiparis s 
                            WHERE s.bTeslimEdildi = 0
                            AND s.nStokID IN (SELECT fu.nStokID FROM FirmaUrunleri fu WHERE fu.nFirmaID = f.nFirmaID)
                        ), 0) AS BekleyenSiparis,
                        ISNULL((
                            SELECT SUM(s.lBrutTutar - s.lIskontoTutari) 
                            FROM tbAlisVerisSiparis s 
                            WHERE s.bTeslimEdildi = 0
                            AND s.nStokID IN (SELECT fu.nStokID FROM FirmaUrunleri fu WHERE fu.nFirmaID = f.nFirmaID)
                        ), 0) AS BekleyenTutar
                    FROM tbStokFisiDetayi d
                    INNER JOIN tbFirma f ON d.nFirmaID = f.nFirmaID
                    WHERE d.sFisTipi = 'FA'
                        AND " & firmaKosulu & "
                        AND d.dteFisTarihi BETWEEN @tarihBaslangic AND @tarihBitis
                    GROUP BY f.sKodu, f.sAciklama, f.nFirmaID
                    ORDER BY f.sKodu
                "

                dtRapor = New DataTable()
                Using cmd As New SqlCommand(query, conn)
                    If nFirmaID <> -1 Then
                        cmd.Parameters.AddWithValue("@nFirmaID", nFirmaID)
                    End If
                    cmd.Parameters.AddWithValue("@tarihBaslangic", tarihBaslangic)
                    cmd.Parameters.AddWithValue("@tarihBitis", tarihBitis)
                    cmd.CommandTimeout = 120

                    Using adapter As New SqlDataAdapter(cmd)
                        adapter.Fill(dtRapor)
                    End Using
                End Using

                ' Grid'e bağla
                gridControlRapor.DataSource = dtRapor
                AyarlaOzetGridSutunlari()

                ' Firma özet bilgisini hesapla
                HesaplaFirmaOzet(conn, nFirmaID, tarihBaslangic, tarihBitis, sonradanTeslimliHesapla)

            End Using
        Catch ex As Exception
            Throw New Exception("Özet rapor oluşturma hatası: " & ex.Message)
        End Try
    End Sub

    ''' <summary>
    ''' Özet rapor için grid sütunlarını ayarla
    ''' </summary>
    Private Sub AyarlaOzetGridSutunlari()
        Try
            With gridViewRapor
                ' Gruplamayı kaldır (özet modunda gruplama yok)
                .GroupSummary.Clear()
                .Columns.Clear()
                gridControlRapor.DataSource = dtRapor
                .PopulateColumns()
                
                ' Sütun başlıkları
                .Columns("FirmaKodu").Caption = "Firma Kodu"
                .Columns("FirmaAdi").Caption = "Firma Adı"
                .Columns("UrunCesidi").Caption = "Ürün Çeşidi"
                .Columns("ToplamAlisMiktari").Caption = "Alış Mikt."
                .Columns("ToplamSatisMiktari").Caption = "Satış Mikt."
                .Columns("ToplamAlisTutari").Caption = "Alış Tutarı"
                .Columns("ToplamSatisTutari").Caption = "Satış Tutarı"
                .Columns("ToplamMaliyet").Caption = "Maliyet"
                .Columns("ToplamKar").Caption = "Kar"
                
                ' Bekleyen sipariş sütunları
                If .Columns.ColumnByFieldName("BekleyenSiparis") IsNot Nothing Then
                    .Columns("BekleyenSiparis").Caption = "Bekleyen Mikt."
                End If
                If .Columns.ColumnByFieldName("BekleyenTutar") IsNot Nothing Then
                    .Columns("BekleyenTutar").Caption = "Bekleyen Tutar"
                End If

                ' Format ayarları
                .Columns("ToplamAlisTutari").DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
                .Columns("ToplamAlisTutari").DisplayFormat.FormatString = "N2"
                .Columns("ToplamSatisTutari").DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
                .Columns("ToplamSatisTutari").DisplayFormat.FormatString = "N2"
                .Columns("ToplamMaliyet").DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
                .Columns("ToplamMaliyet").DisplayFormat.FormatString = "N2"
                .Columns("ToplamKar").DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
                .Columns("ToplamKar").DisplayFormat.FormatString = "N2"
                
                ' Bekleyen sipariş format ayarları
                If .Columns.ColumnByFieldName("BekleyenSiparis") IsNot Nothing Then
                    .Columns("BekleyenSiparis").DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
                    .Columns("BekleyenSiparis").DisplayFormat.FormatString = "N0"
                End If
                If .Columns.ColumnByFieldName("BekleyenTutar") IsNot Nothing Then
                    .Columns("BekleyenTutar").DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
                    .Columns("BekleyenTutar").DisplayFormat.FormatString = "N2"
                End If

                ' Grup altında toplam göster
                .OptionsView.ShowFooter = True
                .OptionsView.ShowGroupPanel = False
                
                .Columns("UrunCesidi").SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum
                .Columns("UrunCesidi").SummaryItem.DisplayFormat = "Toplam: {0:N0}"
                .Columns("ToplamAlisMiktari").SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum
                .Columns("ToplamAlisMiktari").SummaryItem.DisplayFormat = "Toplam: {0:N0}"
                .Columns("ToplamSatisMiktari").SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum
                .Columns("ToplamSatisMiktari").SummaryItem.DisplayFormat = "Toplam: {0:N0}"
                .Columns("ToplamAlisTutari").SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum
                .Columns("ToplamAlisTutari").SummaryItem.DisplayFormat = "Toplam: {0:N2}"
                .Columns("ToplamSatisTutari").SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum
                .Columns("ToplamSatisTutari").SummaryItem.DisplayFormat = "Toplam: {0:N2}"
                .Columns("ToplamMaliyet").SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum
                .Columns("ToplamMaliyet").SummaryItem.DisplayFormat = "Toplam: {0:N2}"
                .Columns("ToplamKar").SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum
                .Columns("ToplamKar").SummaryItem.DisplayFormat = "Toplam: {0:N2}"
                
                ' Bekleyen sipariş summary ayarları
                If .Columns.ColumnByFieldName("BekleyenSiparis") IsNot Nothing Then
                    .Columns("BekleyenSiparis").SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum
                    .Columns("BekleyenSiparis").SummaryItem.DisplayFormat = "Toplam: {0:N0}"
                End If
                If .Columns.ColumnByFieldName("BekleyenTutar") IsNot Nothing Then
                    .Columns("BekleyenTutar").SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum
                    .Columns("BekleyenTutar").SummaryItem.DisplayFormat = "Toplam: {0:N2}"
                End If

                ' Genişlik ayarları
                .Columns("FirmaKodu").Width = 100
                .Columns("FirmaAdi").Width = 250
                .Columns("UrunCesidi").Width = 100
                .Columns("ToplamAlisMiktari").Width = 100
                .Columns("ToplamSatisMiktari").Width = 100
                .Columns("ToplamAlisTutari").Width = 120
                .Columns("ToplamSatisTutari").Width = 120
                .Columns("ToplamMaliyet").Width = 120
                .Columns("ToplamKar").Width = 120
                
                ' Bekleyen sipariş genişlik ayarları
                If .Columns.ColumnByFieldName("BekleyenSiparis") IsNot Nothing Then
                    .Columns("BekleyenSiparis").Width = 100
                End If
                If .Columns.ColumnByFieldName("BekleyenTutar") IsNot Nothing Then
                    .Columns("BekleyenTutar").Width = 120
                End If
                
                ' Sonradan teslimli checkbox'a göre görünürlük
                Dim sonradanTeslimliGoster As Boolean = chkSonradanTeslimli.Checked
                If .Columns.ColumnByFieldName("BekleyenSiparis") IsNot Nothing Then
                    .Columns("BekleyenSiparis").Visible = sonradanTeslimliGoster
                End If
                If .Columns.ColumnByFieldName("BekleyenTutar") IsNot Nothing Then
                    .Columns("BekleyenTutar").Visible = sonradanTeslimliGoster
                End If

                .BestFitColumns()
            End With
        Catch ex As Exception
            ' Sütun ayarlama hatası - devam et
        End Try
    End Sub

    Private Sub HesaplaFirmaOzet(conn As SqlConnection, nFirmaID As Integer, tarihBaslangic As String, tarihBitis As String, sonradanTeslimliHesapla As Boolean)
        Try
            ' Firma bakiyesi (borç durumu)
            Dim queryBakiye As String = "
                SELECT 
                    ISNULL(SUM(lBorcTutar), 0) AS ToplamBorc,
                    ISNULL(SUM(lAlacakTutar), 0) AS ToplamAlacak,
                    ISNULL(SUM(lBorcTutar), 0) - ISNULL(SUM(lAlacakTutar), 0) AS Bakiye
                FROM tbFirmaHareketi
                WHERE nFirmaID = @nFirmaID
            "
            Dim toplamBorc As Decimal = 0
            Dim toplamAlacak As Decimal = 0
            Dim bakiye As Decimal = 0

            Using cmd As New SqlCommand(queryBakiye, conn)
                cmd.Parameters.AddWithValue("@nFirmaID", nFirmaID)
                Using reader As SqlDataReader = cmd.ExecuteReader()
                    If reader.Read() Then
                        toplamBorc = Convert.ToDecimal(reader("ToplamBorc"))
                        toplamAlacak = Convert.ToDecimal(reader("ToplamAlacak"))
                        bakiye = Convert.ToDecimal(reader("Bakiye"))
                    End If
                End Using
            End Using

            ' Rapor verilerinden hesaplamalar
            Dim toplamAlisTutari As Decimal = 0
            Dim toplamSatisTutari As Decimal = 0
            Dim toplamBekleyenTutar As Decimal = 0

            If dtRapor IsNot Nothing AndAlso dtRapor.Rows.Count > 0 Then
                ' Özet/Detay moduna göre sütun adlarını belirle
                Dim alisTutariCol As String = If(dtRapor.Columns.Contains("AlisTutari"), "AlisTutari", "ToplamAlisTutari")
                Dim satisTutariCol As String = If(dtRapor.Columns.Contains("SatisTutari"), "SatisTutari", "ToplamSatisTutari")
                
                For Each row As DataRow In dtRapor.Rows
                    If dtRapor.Columns.Contains(alisTutariCol) Then
                        toplamAlisTutari += Convert.ToDecimal(row(alisTutariCol))
                    End If
                    If dtRapor.Columns.Contains(satisTutariCol) Then
                        toplamSatisTutari += Convert.ToDecimal(row(satisTutariCol))
                    End If
                    If sonradanTeslimliHesapla AndAlso dtRapor.Columns.Contains("BekleyenTutar") Then
                        toplamBekleyenTutar += Convert.ToDecimal(row("BekleyenTutar"))
                    End If
                Next
            End If

            ' Satılan ürünlerin alış tutarı (kar hesabı için)
            Dim satilanUrunAlisiTutari As Decimal = 0
            If dtRapor IsNot Nothing AndAlso dtRapor.Rows.Count > 0 Then
                ' Özet modunda ToplamMaliyet sütunu var, Detay modunda SatisMiktari ve AlisFiyati var
                If dtRapor.Columns.Contains("ToplamMaliyet") Then
                    ' Özet modu
                    For Each row As DataRow In dtRapor.Rows
                        satilanUrunAlisiTutari += Convert.ToDecimal(row("ToplamMaliyet"))
                    Next
                ElseIf dtRapor.Columns.Contains("SatisMiktari") AndAlso dtRapor.Columns.Contains("AlisFiyati") Then
                    ' Detay modu
                    For Each row As DataRow In dtRapor.Rows
                        Dim satisMiktari As Decimal = Convert.ToDecimal(row("SatisMiktari"))
                        Dim alisFiyati As Decimal = Convert.ToDecimal(row("AlisFiyati"))
                        satilanUrunAlisiTutari += satisMiktari * alisFiyati
                    Next
                End If
            End If

            ' Gerçek borç hesabı
            ' Bakiye - Satılan ürün tutarı (alış fiyatıyla) - Bekleyen sipariş tutarı (alış fiyatıyla)
            Dim gercekBorc As Decimal = bakiye - satilanUrunAlisiTutari
            If sonradanTeslimliHesapla Then
                gercekBorc -= toplamBekleyenTutar
            End If

            ' Özet bilgileri label'lara yaz
            lblFirmaBakiye.Text = String.Format("Firma Bakiyesi: {0:N2} ₺", bakiye)
            lblToplamAlis.Text = String.Format("Toplam Alış: {0:N2} ₺", toplamAlisTutari)
            lblSatilanTutar.Text = String.Format("Satılan (Alış Fiyatıyla): {0:N2} ₺", satilanUrunAlisiTutari)

            If sonradanTeslimliHesapla Then
                lblBekleyenTutar.Text = String.Format("Bekleyen Sipariş Tutarı: {0:N2} ₺", toplamBekleyenTutar)
                lblBekleyenTutar.Visible = True
            Else
                lblBekleyenTutar.Visible = False
            End If

            lblGercekBorc.Text = String.Format("GERÇEK BORÇ: {0:N2} ₺", gercekBorc)

            ' Açıklama
            Dim aciklama As String = "Hesaplama: Firma Bakiyesi"
            If satilanUrunAlisiTutari > 0 Then
                aciklama &= String.Format(" - Satılan ({0:N2}₺)", satilanUrunAlisiTutari)
            End If
            If sonradanTeslimliHesapla AndAlso toplamBekleyenTutar > 0 Then
                aciklama &= String.Format(" - Bekleyen ({0:N2}₺)", toplamBekleyenTutar)
            End If
            aciklama &= String.Format(" = {0:N2} ₺", gercekBorc)
            lblAciklama.Text = aciklama

        Catch ex As Exception
            MsgBox("Firma özet hesaplama hatası: " & ex.Message, MsgBoxStyle.Exclamation)
        End Try
    End Sub

    Private Sub AyarlaGridSutunlari(sonradanTeslimliGoster As Boolean)
        Try
            With gridViewRapor
                ' Gruplama için firma alanı
                .Columns("FirmaKodu").GroupIndex = 0
                .Columns("FirmaAdi").Visible = False

                ' Sütun başlıkları
                .Columns("UrunKodu").Caption = "Ürün Kodu"
                .Columns("UrunAdi").Caption = "Ürün Adı"
                .Columns("Barkod").Caption = "Barkod"
                .Columns("AlisMiktari").Caption = "Alış Mikt."
                .Columns("SatisMiktari").Caption = "Satış Mikt."
                .Columns("KalanStok").Caption = "Kalan Stok"
                .Columns("BekleyenSiparis").Caption = "Bekleyen Sip."
                .Columns("NetStok").Caption = "Net Stok"
                .Columns("AlisFiyati").Caption = "Alış Fiyatı"
                .Columns("SatisFiyati").Caption = "Satış Fiyatı"
                .Columns("AlisTutari").Caption = "Alış Tutarı"
                .Columns("SatisTutari").Caption = "Satış Tutarı"
                .Columns("BekleyenTutar").Caption = "Bekleyen Tutar"
                .Columns("AlisIskontoTutari").Caption = "Alış İsk."
                .Columns("SatisIskontoTutari").Caption = "Satış İsk."
                .Columns("SatisMaliyeti").Caption = "Maliyet"
                .Columns("Kar").Caption = "Kar"
                .Columns("Karlilik").Caption = "Karlılık %"

                ' Bekleyen sipariş sütunlarını checkbox durumuna göre göster/gizle
                .Columns("BekleyenSiparis").Visible = sonradanTeslimliGoster
                .Columns("BekleyenTutar").Visible = sonradanTeslimliGoster
                .Columns("NetStok").Visible = sonradanTeslimliGoster

                ' Format ayarları
                .Columns("AlisFiyati").DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
                .Columns("AlisFiyati").DisplayFormat.FormatString = "N2"
                .Columns("SatisFiyati").DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
                .Columns("SatisFiyati").DisplayFormat.FormatString = "N2"
                .Columns("AlisTutari").DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
                .Columns("AlisTutari").DisplayFormat.FormatString = "N2"
                .Columns("SatisTutari").DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
                .Columns("SatisTutari").DisplayFormat.FormatString = "N2"
                .Columns("BekleyenTutar").DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
                .Columns("BekleyenTutar").DisplayFormat.FormatString = "N2"
                .Columns("AlisIskontoTutari").DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
                .Columns("AlisIskontoTutari").DisplayFormat.FormatString = "N2"
                .Columns("SatisIskontoTutari").DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
                .Columns("SatisIskontoTutari").DisplayFormat.FormatString = "N2"
                .Columns("SatisMaliyeti").DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
                .Columns("SatisMaliyeti").DisplayFormat.FormatString = "N2"
                .Columns("Kar").DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
                .Columns("Kar").DisplayFormat.FormatString = "N2"
                .Columns("Karlilik").DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
                .Columns("Karlilik").DisplayFormat.FormatString = "N2"

                ' Grup altında toplam göster
                .OptionsView.ShowFooter = True
                .Columns("AlisMiktari").SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum
                .Columns("AlisMiktari").SummaryItem.DisplayFormat = "Toplam: {0:N0}"
                .Columns("SatisMiktari").SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum
                .Columns("SatisMiktari").SummaryItem.DisplayFormat = "Toplam: {0:N0}"
                .Columns("KalanStok").SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum
                .Columns("KalanStok").SummaryItem.DisplayFormat = "Toplam: {0:N0}"
                .Columns("BekleyenSiparis").SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum
                .Columns("BekleyenSiparis").SummaryItem.DisplayFormat = "Toplam: {0:N0}"
                .Columns("NetStok").SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum
                .Columns("NetStok").SummaryItem.DisplayFormat = "Toplam: {0:N0}"
                .Columns("AlisTutari").SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum
                .Columns("AlisTutari").SummaryItem.DisplayFormat = "Toplam: {0:N2}"
                .Columns("SatisTutari").SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum
                .Columns("SatisTutari").SummaryItem.DisplayFormat = "Toplam: {0:N2}"
                .Columns("BekleyenTutar").SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum
                .Columns("BekleyenTutar").SummaryItem.DisplayFormat = "Toplam: {0:N2}"
                .Columns("AlisIskontoTutari").SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum
                .Columns("AlisIskontoTutari").SummaryItem.DisplayFormat = "Toplam: {0:N2}"
                .Columns("SatisIskontoTutari").SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum
                .Columns("SatisIskontoTutari").SummaryItem.DisplayFormat = "Toplam: {0:N2}"
                .Columns("SatisMaliyeti").SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum
                .Columns("SatisMaliyeti").SummaryItem.DisplayFormat = "Toplam: {0:N2}"
                .Columns("Kar").SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum
                .Columns("Kar").SummaryItem.DisplayFormat = "Toplam: {0:N2}"
                .Columns("Karlilik").SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Average
                .Columns("Karlilik").SummaryItem.DisplayFormat = "Ort: %{0:N2}"

                ' Grup toplamları
                .GroupSummary.Add(DevExpress.Data.SummaryItemType.Sum, "AlisMiktari", .Columns("AlisMiktari"), "Alış: {0:N0}")
                .GroupSummary.Add(DevExpress.Data.SummaryItemType.Sum, "SatisMiktari", .Columns("SatisMiktari"), "Satış: {0:N0}")
                .GroupSummary.Add(DevExpress.Data.SummaryItemType.Sum, "KalanStok", .Columns("KalanStok"), "Kalan: {0:N0}")
                .GroupSummary.Add(DevExpress.Data.SummaryItemType.Sum, "AlisTutari", .Columns("AlisTutari"), "Alış Tutarı: {0:N2} ₺")
                .GroupSummary.Add(DevExpress.Data.SummaryItemType.Sum, "BekleyenTutar", .Columns("BekleyenTutar"), "Bekleyen: {0:N2} ₺")
                .GroupSummary.Add(DevExpress.Data.SummaryItemType.Sum, "SatisMaliyeti", .Columns("SatisMaliyeti"), "Maliyet: {0:N2} ₺")
                .GroupSummary.Add(DevExpress.Data.SummaryItemType.Sum, "Kar", .Columns("Kar"), "Kar: {0:N2} ₺")

                ' Genişlik ayarları
                .Columns("UrunKodu").Width = 100
                .Columns("UrunAdi").Width = 200
                .Columns("Barkod").Width = 120
                .Columns("AlisMiktari").Width = 80
                .Columns("SatisMiktari").Width = 80
                .Columns("KalanStok").Width = 80
                .Columns("BekleyenSiparis").Width = 80
                .Columns("NetStok").Width = 80
                .Columns("AlisFiyati").Width = 90
                .Columns("SatisFiyati").Width = 90
                .Columns("BekleyenTutar").Width = 90
                .Columns("AlisIskontoTutari").Width = 80
                .Columns("SatisIskontoTutari").Width = 80
                .Columns("SatisMaliyeti").Width = 90
                .Columns("Kar").Width = 90
                .Columns("Karlilik").Width = 80

                ' Grupları genişlet
                .ExpandAllGroups()
            End With
        Catch ex As Exception
            ' Sütun ayarlama hatası - devam et
        End Try
    End Sub

#End Region

End Class
