' ============================================
' TRENDYOL ENTEGRASYON FORMU
' Dosya: frm_TrendyolEntegrasyon.vb
' Tarih: 2026-01-30
' Açıklama: Trendyol'a fiyat/stok senkronizasyonu
' ============================================

Imports System.Collections.Generic
Imports System.Threading.Tasks
Imports System.Windows.Forms
Imports DevExpress.XtraEditors
Imports DevExpress.XtraGrid.Views.Grid

Public Class frm_TrendyolEntegrasyon

    Public connection As String = ""
    Private _dtUrunler As DataTable

#Region "Form Events"

    Private Sub frm_TrendyolEntegrasyon_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Text = "Trendyol Fiyat/Stok Senkronizasyonu"
        InitializeGrid()
        LoadApiSettings()
    End Sub

#End Region

#Region "Initialization"

    Private Sub InitializeGrid()
        _dtUrunler = New DataTable()
        _dtUrunler.Columns.Add("Sec", GetType(Boolean))
        _dtUrunler.Columns.Add("nStokID", GetType(Integer))
        _dtUrunler.Columns.Add("sKodu", GetType(String))
        _dtUrunler.Columns.Add("sAciklama", GetType(String))
        _dtUrunler.Columns.Add("sBarkod", GetType(String))
        _dtUrunler.Columns.Add("TrendyolBarkod", GetType(String))
        _dtUrunler.Columns.Add("Stok", GetType(Integer))
        _dtUrunler.Columns.Add("SatisFiyati", GetType(Decimal))
        _dtUrunler.Columns.Add("ListeFiyati", GetType(Decimal))
        _dtUrunler.Columns.Add("SonSenkron", GetType(DateTime))
        _dtUrunler.Columns.Add("Durum", GetType(String))
        
        grd_Urunler.DataSource = _dtUrunler
        
        Dim view = TryCast(grd_Urunler.MainView, GridView)
        If view IsNot Nothing Then
            view.OptionsBehavior.Editable = True
            view.Columns("Sec").Width = 40
            view.Columns("nStokID").Visible = False
            view.Columns("sKodu").Caption = "Stok Kodu"
            view.Columns("sKodu").Width = 100
            view.Columns("sAciklama").Caption = "Ürün Adı"
            view.Columns("sAciklama").Width = 200
            view.Columns("sBarkod").Caption = "Barkod"
            view.Columns("sBarkod").Width = 120
            view.Columns("TrendyolBarkod").Caption = "Trendyol Barkod"
            view.Columns("TrendyolBarkod").Width = 120
            view.Columns("Stok").Caption = "Stok"
            view.Columns("Stok").Width = 60
            view.Columns("SatisFiyati").Caption = "Satış Fiyatı"
            view.Columns("SatisFiyati").Width = 80
            view.Columns("ListeFiyati").Caption = "Liste Fiyatı"
            view.Columns("ListeFiyati").Width = 80
            view.Columns("SonSenkron").Caption = "Son Senkron"
            view.Columns("SonSenkron").Width = 120
            view.Columns("Durum").Caption = "Durum"
            view.Columns("Durum").Width = 100
        End If
    End Sub

    Private Sub LoadApiSettings()
        Try
            Using con As New OleDb.OleDbConnection(connection)
                con.Open()
                Using cmd As New OleDb.OleDbCommand()
                    cmd.Connection = con
                    cmd.CommandText = "SELECT TOP 1 * FROM tbTrendyolAyar WHERE bAktif = 1"
                    
                    Using reader = cmd.ExecuteReader()
                        If reader.Read() Then
                            TrendyolAPI.Instance.Configure(
                                reader("sSupplierId").ToString(),
                                reader("sApiKey").ToString(),
                                reader("sApiSecret").ToString(),
                                If(IsDBNull(reader("sBaseUrl")), Nothing, reader("sBaseUrl").ToString())
                            )
                            lbl_Status.Text = "API bağlantısı hazır"
                            lbl_Status.ForeColor = Color.Green
                        Else
                            lbl_Status.Text = "API ayarları bulunamadı!"
                            lbl_Status.ForeColor = Color.Red
                        End If
                    End Using
                End Using
            End Using
        Catch ex As Exception
            lbl_Status.Text = "Hata: " & ex.Message
            lbl_Status.ForeColor = Color.Red
        End Try
    End Sub

#End Region

#Region "Load Products"

    Private Sub LoadProducts()
        _dtUrunler.Clear()
        
        Try
            Using con As New OleDb.OleDbConnection(connection)
                con.Open()
                
                ' Sadece eşleşmiş ürünleri getir
                ' tbStok'ta sBarkod yok - tbStokBarkodu'dan alınıyor, bPasif yok nStokTipi kullanılıyor
                Dim sql = "SELECT s.nStokID, s.sKodu, s.sAciklama, b.sBarkod, " &
                          "e.sTrendyolBarkod, " &
                          "ISNULL((SELECT SUM(d.lGirisMiktar1 - d.lCikisMiktar1) FROM tbStokFisiDetayi d WHERE d.nStokID = s.nStokID), 0) as Stok, " &
                          "ISNULL((SELECT TOP 1 f.lFiyat FROM tbStokFiyati f WHERE f.nStokID = s.nStokID ORDER BY f.dteFiyatTespitTarihi DESC), 0) as SatisFiyati, " &
                          "ISNULL((SELECT TOP 1 f.lFiyat FROM tbStokFiyati f WHERE f.nStokID = s.nStokID ORDER BY f.dteFiyatTespitTarihi DESC), 0) as ListeFiyati, " &
                          "e.dteSonSenkron, e.sSonHata " &
                          "FROM tbStok s " &
                          "INNER JOIN tbStokBarkodu b ON s.nStokID = b.nStokID " &
                          "INNER JOIN tbTrendyolUrunEsleme e ON s.nStokID = e.nStokID " &
                          "WHERE e.nEslesmeDurumu = 1 AND e.bAktif = 1 AND s.nStokTipi < 5 "
                
                If chk_SadeceDegisen.Checked Then
                    sql &= " AND (e.dteSonSenkron IS NULL OR e.dteSonSenkron < DATEADD(HOUR, -1, GETDATE()))"
                End If
                
                sql &= " ORDER BY s.sKodu"
                
                Using cmd As New OleDb.OleDbCommand(sql, con)
                    Using reader As OleDb.OleDbDataReader = cmd.ExecuteReader()
                        While reader.Read()
                            Dim row As DataRow = _dtUrunler.NewRow()
                            row("Sec") = False
                            row("nStokID") = CInt(reader("nStokID"))
                            row("sKodu") = reader("sKodu").ToString()
                            row("sAciklama") = reader("sAciklama").ToString()
                            row("sBarkod") = reader("sBarkod").ToString()
                            row("TrendyolBarkod") = reader("sTrendyolBarkod").ToString()
                            
                            If IsDBNull(reader("Stok")) Then
                                row("Stok") = 0
                            Else
                                row("Stok") = CInt(reader("Stok"))
                            End If
                            
                            If IsDBNull(reader("SatisFiyati")) Then
                                row("SatisFiyati") = 0D
                            Else
                                row("SatisFiyati") = CDec(reader("SatisFiyati"))
                            End If
                            
                            If IsDBNull(reader("ListeFiyati")) Then
                                row("ListeFiyati") = 0D
                            Else
                                row("ListeFiyati") = CDec(reader("ListeFiyati"))
                            End If
                            
                            If IsDBNull(reader("dteSonSenkron")) Then
                                row("SonSenkron") = DBNull.Value
                            Else
                                row("SonSenkron") = reader("dteSonSenkron")
                            End If
                            
                            If IsDBNull(reader("sSonHata")) Then
                                row("Durum") = "Bekliyor"
                            Else
                                row("Durum") = reader("sSonHata").ToString()
                            End If
                            
                            _dtUrunler.Rows.Add(row)
                        End While
                    End Using
                End Using
            End Using
            
            lbl_Status.Text = _dtUrunler.Rows.Count.ToString() & " eşleşmiş ürün listelendi"
            lbl_Status.ForeColor = Color.Green
            
        Catch ex As Exception
            lbl_Status.Text = "Hata: " & ex.Message
            lbl_Status.ForeColor = Color.Red
            MessageBox.Show("Ürünler yüklenirken hata: " & ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

#End Region

#Region "Synchronization"

    Private Async Sub SyncSelectedProducts()
        If Not TrendyolAPI.Instance.IsConfigured Then
            MessageBox.Show("API yapılandırılmamış!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If
        
        Dim selectedRows = _dtUrunler.Select("Sec = True")
        If selectedRows.Length = 0 Then
            MessageBox.Show("Lütfen senkronize edilecek ürünleri seçin.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If
        
        ' Fiyat/Stok listesi oluştur
        Dim items As New List(Of PriceStockItem)
        
        For Each row As DataRow In selectedRows
            Dim trendyolBarkod = row("TrendyolBarkod").ToString()
            If String.IsNullOrEmpty(trendyolBarkod) Then Continue For
            
            Dim satisFiyati = CDec(row("SatisFiyati"))
            Dim listeFiyati = CDec(row("ListeFiyati"))
            
            ' Liste fiyatı satış fiyatından küçükse düzelt
            If listeFiyati < satisFiyati Then
                listeFiyati = satisFiyati * 1.2D
            End If
            
            items.Add(New PriceStockItem With {
                .Barcode = trendyolBarkod,
                .Quantity = CInt(row("Stok")),
                .SalePrice = satisFiyati,
                .ListPrice = listeFiyati
            })
        Next
        
        If items.Count = 0 Then
            MessageBox.Show("Gönderilebilecek ürün bulunamadı.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If
        
        btn_Senkronize.Enabled = False
        Me.Cursor = Cursors.WaitCursor
        progressBar.Visible = True
        lbl_Status.Text = items.Count.ToString() & " ürün Trendyol'a gönderiliyor..."
        lbl_Status.ForeColor = Color.Blue
        
        Try
            ' API'ye gönder
            Dim result = Await TrendyolAPI.Instance.UpdatePriceAndInventoryAsync(items)
            
            If result.Success Then
                lbl_Status.Text = "Gönderildi! Batch ID: " & result.BatchRequestId
                lbl_Status.ForeColor = Color.Green
                
                ' Log kaydet
                LogSyncOperation("FIYAT_STOK_GUNCELLE", result.BatchRequestId, items.Count, items.Count, 0, "")
                
                ' Batch durumunu kontrol et (5 saniye bekle)
                lbl_Status.Text = "Batch durumu kontrol ediliyor..."
                Await Task.Delay(5000)
                
                Dim statusResult = Await TrendyolAPI.Instance.GetBatchStatusAsync(result.BatchRequestId)
                
                If statusResult.Success Then
                    Dim basarili = statusResult.Data.ItemCount - statusResult.Data.FailedItemCount
                    Dim basarisiz = statusResult.Data.FailedItemCount
                    
                    lbl_Status.Text = "Tamamlandı. Başarılı: " & basarili.ToString() & ", Başarısız: " & basarisiz.ToString()
                    lbl_Status.ForeColor = If(basarisiz = 0, Color.Green, Color.Orange)
                    
                    ' Senkronizasyon tarihlerini güncelle
                    UpdateSyncDates(selectedRows, result.BatchRequestId)
                    
                    MessageBox.Show("Senkronizasyon tamamlandı." & vbCrLf & "Başarılı: " & basarili.ToString() & vbCrLf & "Başarısız: " & basarisiz.ToString(), "Sonuç", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Else
                    lbl_Status.Text = "Batch durumu alınamadı: " & statusResult.ErrorMessage
                    lbl_Status.ForeColor = Color.Orange
                End If
            Else
                lbl_Status.Text = "Hata: " & result.ErrorMessage
                lbl_Status.ForeColor = Color.Red
                MessageBox.Show("Gönderim hatası: " & result.ErrorMessage, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
            
        Catch ex As Exception
            lbl_Status.Text = "Hata: " & ex.Message
            lbl_Status.ForeColor = Color.Red
            MessageBox.Show("Senkronizasyon hatası: " & ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            btn_Senkronize.Enabled = True
            Me.Cursor = Cursors.Default
            progressBar.Visible = False
        End Try
    End Sub

    Private Sub UpdateSyncDates(rows() As DataRow, batchId As String)
        Try
            Using con As New OleDb.OleDbConnection(connection)
                con.Open()
                For Each row As DataRow In rows
                    Using cmd As New OleDb.OleDbCommand()
                        cmd.Connection = con
                        cmd.CommandText = "UPDATE tbTrendyolUrunEsleme SET dteSonSenkron=?, sSonBatchId=?, " &
                                          "nSonFiyat=?, nSonStok=?, dteGuncelleme=? WHERE nStokID=?"
                        cmd.Parameters.AddWithValue("@p1", DateTime.Now)
                        cmd.Parameters.AddWithValue("@p2", batchId)
                        cmd.Parameters.AddWithValue("@p3", row("SatisFiyati"))
                        cmd.Parameters.AddWithValue("@p4", row("Stok"))
                        cmd.Parameters.AddWithValue("@p5", DateTime.Now)
                        cmd.Parameters.AddWithValue("@p6", row("nStokID"))
                        cmd.ExecuteNonQuery()
                    End Using
                    
                    row("SonSenkron") = DateTime.Now
                    row("Durum") = "Senkronize ✓"
                Next
            End Using
        Catch ex As Exception
            Debug.WriteLine("UpdateSyncDates hatası: " & ex.Message)
        End Try
    End Sub

    Private Sub LogSyncOperation(islemTipi As String, batchId As String, toplam As Integer, basarili As Integer, basarisiz As Integer, detay As String)
        Try
            Using con As New OleDb.OleDbConnection(connection)
                con.Open()
                Using cmd As New OleDb.OleDbCommand()
                    cmd.Connection = con
                    cmd.CommandText = "INSERT INTO tbTrendyolLog (sIslemTipi, sBatchRequestId, nToplamUrun, nBasarili, nBasarisiz, sDetay, sKullanici, dteIslem) " &
                                      "VALUES (?, ?, ?, ?, ?, ?, ?, ?)"
                    cmd.Parameters.AddWithValue("@p1", islemTipi)
                    cmd.Parameters.AddWithValue("@p2", batchId)
                    cmd.Parameters.AddWithValue("@p3", toplam)
                    cmd.Parameters.AddWithValue("@p4", basarili)
                    cmd.Parameters.AddWithValue("@p5", basarisiz)
                    cmd.Parameters.AddWithValue("@p6", detay)
                    cmd.Parameters.AddWithValue("@p7", Environment.UserName)
                    cmd.Parameters.AddWithValue("@p8", DateTime.Now)
                    cmd.ExecuteNonQuery()
                End Using
            End Using
        Catch ex As Exception
            Debug.WriteLine("LogSyncOperation hatası: " & ex.Message)
        End Try
    End Sub

#End Region

#Region "Button Events"

    Private Sub btn_Yukle_Click(sender As Object, e As EventArgs) Handles btn_Yukle.Click
        LoadProducts()
    End Sub

    Private Sub btn_Senkronize_Click(sender As Object, e As EventArgs) Handles btn_Senkronize.Click
        SyncSelectedProducts()
    End Sub

    Private Sub btn_TumunuSec_Click(sender As Object, e As EventArgs) Handles btn_TumunuSec.Click
        For Each row As DataRow In _dtUrunler.Rows
            row("Sec") = True
        Next
        grd_Urunler.RefreshDataSource()
    End Sub

    Private Sub btn_SecimTemizle_Click(sender As Object, e As EventArgs) Handles btn_SecimTemizle.Click
        For Each row As DataRow In _dtUrunler.Rows
            row("Sec") = False
        Next
        grd_Urunler.RefreshDataSource()
    End Sub

    Private Sub btn_Kapat_Click(sender As Object, e As EventArgs) Handles btn_Kapat.Click
        Me.Close()
    End Sub

#End Region

End Class
