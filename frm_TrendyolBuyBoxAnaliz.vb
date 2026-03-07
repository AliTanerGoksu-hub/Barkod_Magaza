' ============================================
' TRENDYOL BUYBOX ANALİZ FORMU
' Dosya: frm_TrendyolBuyBoxAnaliz.vb
' Tarih: 2026-01-30
' Açıklama: Ürünlerin BuyBox durumunu analiz ve eşleştirme
' ============================================

Imports System.Collections.Generic
Imports System.Threading.Tasks
Imports System.Windows.Forms
Imports DevExpress.XtraEditors
Imports DevExpress.XtraGrid.Views.Grid

Public Class frm_TrendyolBuyBoxAnaliz

    Public connection As String = ""
    Private _isLoading As Boolean = False
    Private _dtUrunler As DataTable

#Region "Form Events"

    Private Sub frm_TrendyolBuyBoxAnaliz_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Text = "Trendyol BuyBox Analiz"
        InitializeGrid()
        LoadApiSettings()
    End Sub

#End Region

#Region "Initialization"

    ''' <summary>
    ''' Grid'i hazırla
    ''' </summary>
    Private Sub InitializeGrid()
        _dtUrunler = New DataTable()
        _dtUrunler.Columns.Add("Sec", GetType(Boolean))
        _dtUrunler.Columns.Add("nStokID", GetType(Integer))
        _dtUrunler.Columns.Add("sKodu", GetType(String))
        _dtUrunler.Columns.Add("sAciklama", GetType(String))
        _dtUrunler.Columns.Add("sModel", GetType(String))
        _dtUrunler.Columns.Add("sBarkod", GetType(String))
        _dtUrunler.Columns.Add("TrendyolBarkod", GetType(String))
        _dtUrunler.Columns.Add("EslesmeDurumu", GetType(String))
        _dtUrunler.Columns.Add("BuyBoxDurumu", GetType(String))
        _dtUrunler.Columns.Add("BuyBoxFiyat", GetType(Decimal))
        _dtUrunler.Columns.Add("SaticiSayisi", GetType(Integer))
        _dtUrunler.Columns.Add("TrendyolKategori", GetType(String))
        _dtUrunler.Columns.Add("KategoriUyarisi", GetType(String))
        _dtUrunler.Columns.Add("DogruKategoriId", GetType(String))
        _dtUrunler.Columns.Add("SonHata", GetType(String))
        
        grd_Urunler.DataSource = _dtUrunler
        
        ' Grid görünümü ayarla
        Dim view As GridView = TryCast(grd_Urunler.MainView, GridView)
        If view IsNot Nothing Then
            view.OptionsBehavior.Editable = True
            view.Columns("Sec").Width = 40
            view.Columns("nStokID").Visible = False
            view.Columns("sKodu").Caption = "Stok Kodu"
            view.Columns("sKodu").Width = 80
            view.Columns("sAciklama").Caption = "Urun Adi"
            view.Columns("sAciklama").Width = 150
            view.Columns("sModel").Caption = "Model"
            view.Columns("sModel").Width = 80
            view.Columns("sBarkod").Caption = "Barkod"
            view.Columns("sBarkod").Width = 100
            view.Columns("TrendyolBarkod").Caption = "T.Barkod"
            view.Columns("TrendyolBarkod").Width = 100
            view.Columns("EslesmeDurumu").Caption = "Eslesme"
            view.Columns("EslesmeDurumu").Width = 70
            view.Columns("BuyBoxDurumu").Caption = "BuyBox"
            view.Columns("BuyBoxDurumu").Width = 70
            view.Columns("BuyBoxFiyat").Caption = "BB Fiyat"
            view.Columns("BuyBoxFiyat").Width = 60
            view.Columns("SaticiSayisi").Caption = "Satici"
            view.Columns("SaticiSayisi").Width = 40
            view.Columns("TrendyolKategori").Caption = "Trendyol Kategorisi"
            view.Columns("TrendyolKategori").Width = 180
            view.Columns("KategoriUyarisi").Caption = "Kategori Uyarisi"
            view.Columns("KategoriUyarisi").Width = 150
            view.Columns("DogruKategoriId").Caption = "Dogru Kat.ID"
            view.Columns("DogruKategoriId").Width = 80
            view.Columns("SonHata").Caption = "Hata/Not"
            view.Columns("SonHata").Width = 120
        End If
    End Sub

    ''' <summary>
    ''' API ayarlarını yükle
    ''' </summary>
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
                            lbl_Status.Text = "API ayarları bulunamadı! Önce Ayarlar'dan API bilgilerini girin."
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

    ''' <summary>
    ''' Ürünleri yükle
    ''' </summary>
    Private Sub LoadProducts()
        _dtUrunler.Clear()
        
        Try
            Using con As New OleDb.OleDbConnection(connection)
                con.Open()
                
                ' tbStok'ta sBarkod yok, tbStokBarkodu'dan alınıyor
                ' bPasif yok, nStokTipi < 5 kullanılıyor
                ' sModel eklendi - barkod eslesme bulunamazsa model koduyla arama yapilacak
                Dim sql As String = "SELECT s.nStokID, s.sKodu, s.sAciklama, s.sModel, b.sBarkod, " &
                          "e.sTrendyolBarkod, e.nEslesmeDurumu, e.nBuyBoxDurumu, e.lBuyBoxFiyat, e.nSaticiSayisi, " &
                          "e.sTrendyolCategoryId, e.sSonHata " &
                          "FROM tbStok s " &
                          "INNER JOIN tbStokBarkodu b ON s.nStokID = b.nStokID " &
                          "LEFT JOIN tbTrendyolUrunEsleme e ON s.nStokID = e.nStokID " &
                          "WHERE s.nStokTipi < 5 "
                
                ' Filtreler
                If Not String.IsNullOrWhiteSpace(txt_Barkod.Text) Then
                    sql = sql & " AND b.sBarkod LIKE '%" & txt_Barkod.Text.Trim() & "%'"
                End If
                
                If Not String.IsNullOrWhiteSpace(txt_StokKodu.Text) Then
                    sql = sql & " AND s.sKodu LIKE '%" & txt_StokKodu.Text.Trim() & "%'"
                End If
                
                If chk_SadeceEslesmeyen.Checked Then
                    sql = sql & " AND (e.nEslesmeDurumu IS NULL OR e.nEslesmeDurumu = 0 OR e.nEslesmeDurumu = 2)"
                End If
                
                sql = sql & " ORDER BY s.sKodu"
                
                Using cmd As New OleDb.OleDbCommand(sql, con)
                    Using reader As OleDb.OleDbDataReader = cmd.ExecuteReader()
                        While reader.Read()
                            Dim row As DataRow = _dtUrunler.NewRow()
                            row("Sec") = False
                            row("nStokID") = CInt(reader("nStokID"))
                            row("sKodu") = reader("sKodu").ToString()
                            row("sAciklama") = reader("sAciklama").ToString()
                            
                            ' Model kodu
                            If IsDBNull(reader("sModel")) Then
                                row("sModel") = ""
                            Else
                                row("sModel") = reader("sModel").ToString()
                            End If
                            
                            row("sBarkod") = reader("sBarkod").ToString()
                            
                            If IsDBNull(reader("sTrendyolBarkod")) Then
                                row("TrendyolBarkod") = ""
                            Else
                                row("TrendyolBarkod") = reader("sTrendyolBarkod").ToString()
                            End If
                            
                            Dim eslesmeDurumu As Integer = 0
                            If Not IsDBNull(reader("nEslesmeDurumu")) Then
                                eslesmeDurumu = CInt(reader("nEslesmeDurumu"))
                            End If
                            row("EslesmeDurumu") = GetEslesmeDurumuText(eslesmeDurumu)
                            
                            Dim buyboxDurumu As Integer = 0
                            If Not IsDBNull(reader("nBuyBoxDurumu")) Then
                                buyboxDurumu = CInt(reader("nBuyBoxDurumu"))
                            End If
                            row("BuyBoxDurumu") = GetBuyBoxDurumuText(buyboxDurumu)
                            
                            If IsDBNull(reader("lBuyBoxFiyat")) Then
                                row("BuyBoxFiyat") = 0D
                            Else
                                row("BuyBoxFiyat") = CDec(reader("lBuyBoxFiyat"))
                            End If
                            
                            If IsDBNull(reader("nSaticiSayisi")) Then
                                row("SaticiSayisi") = 0
                            Else
                                row("SaticiSayisi") = CInt(reader("nSaticiSayisi"))
                            End If
                            
                            If IsDBNull(reader("sSonHata")) Then
                                row("SonHata") = ""
                            Else
                                row("SonHata") = reader("sSonHata").ToString()
                            End If
                            
                            ' Kategori bilgisi
                            If IsDBNull(reader("sTrendyolCategoryId")) Then
                                row("TrendyolKategori") = ""
                                row("KategoriUyarisi") = ""
                                row("DogruKategoriId") = ""
                            Else
                                row("TrendyolKategori") = reader("sTrendyolCategoryId").ToString()
                                row("KategoriUyarisi") = ""
                                row("DogruKategoriId") = ""
                            End If
                            
                            _dtUrunler.Rows.Add(row)
                        End While
                    End Using
                End Using
            End Using
            
            lbl_Status.Text = _dtUrunler.Rows.Count.ToString() & " ürün listelendi"
            lbl_Status.ForeColor = Color.Green
            
        Catch ex As Exception
            lbl_Status.Text = "Hata: " & ex.Message
            lbl_Status.ForeColor = Color.Red
            MessageBox.Show("Ürünler yüklenirken hata: " & ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Function GetEslesmeDurumuText(durum As Integer) As String
        Select Case durum
            Case 0 : Return "Bekliyor"
            Case 1 : Return "Eslesti"
            Case 2 : Return "Eslesemedi"
            Case 3 : Return "Manuel"
            Case Else : Return "?"
        End Select
    End Function

    Private Function GetBuyBoxDurumuText(durum As Integer) As String
        Select Case durum
            Case 0 : Return "?"
            Case 1 : Return "BuyBox'ta"
            Case 2 : Return "BuyBox disi"
            Case 3 : Return "Tek satici"
            Case Else : Return "?"
        End Select
    End Function
    
    ''' <summary>
    ''' OTOMATIK KATEGORI ESLESTIRME
    ''' Urun adindan Trendyol kategori ID ve adini bulur
    ''' Barkod aramasina GUVENMEZ - sabit eslestirme tablosu kullanir
    ''' </summary>
    Private Function UrunAdindanKategoriBul(urunAdi As String) As Tuple(Of String, String)
        Dim urunUpper As String = urunAdi.ToUpper()
        
        ' === BEBEK KATEGORILERI ===
        If urunUpper.Contains("BEBEK") Then
            If urunUpper.Contains("MONT") OrElse urunUpper.Contains("KABAN") Then
                Return New Tuple(Of String, String)("535", "Bebek Mont")
            ElseIf urunUpper.Contains("TAKIM") OrElse urunUpper.Contains("SET") Then
                Return New Tuple(Of String, String)("947", "Bebek Takimi")
            ElseIf urunUpper.Contains("ELBISE") Then
                Return New Tuple(Of String, String)("948", "Bebek Elbise")
            ElseIf urunUpper.Contains("BODY") OrElse urunUpper.Contains("ZIBINBODY") Then
                Return New Tuple(Of String, String)("946", "Bebek Body")
            ElseIf urunUpper.Contains("TULUM") Then
                Return New Tuple(Of String, String)("949", "Bebek Tulum")
            ElseIf urunUpper.Contains("PIJAMA") Then
                Return New Tuple(Of String, String)("951", "Bebek Pijama")
            Else
                Return New Tuple(Of String, String)("947", "Bebek Takimi")
            End If
        End If
        
        ' === COCUK KATEGORILERI ===
        If urunUpper.Contains("COCUK") OrElse urunUpper.Contains("ÇOCUK") Then
            If urunUpper.Contains("MONT") OrElse urunUpper.Contains("KABAN") Then
                Return New Tuple(Of String, String)("535", "Cocuk Mont")
            ElseIf urunUpper.Contains("ELBISE") Then
                Return New Tuple(Of String, String)("1182", "Cocuk Elbise")
            ElseIf urunUpper.Contains("TAKIM") Then
                Return New Tuple(Of String, String)("601", "Cocuk Takim")
            ElseIf urunUpper.Contains("SORT") OrElse urunUpper.Contains("BERMUDA") Then
                Return New Tuple(Of String, String)("530", "Cocuk Sort")
            ElseIf urunUpper.Contains("PANTOLON") Then
                Return New Tuple(Of String, String)("529", "Cocuk Pantolon")
            ElseIf urunUpper.Contains("TISORT") OrElse urunUpper.Contains("TSHIRT") Then
                Return New Tuple(Of String, String)("604", "Cocuk Tisort")
            End If
        End If
        
        ' === DIS GIYIM (MONT, KABAN, CEKET) ===
        If urunUpper.Contains("MONT") Then
            If urunUpper.Contains("KADIN") OrElse urunUpper.Contains("BAYAN") Then
                Return New Tuple(Of String, String)("535", "Kadin Mont")
            Else
                Return New Tuple(Of String, String)("535", "Erkek Mont")
            End If
        End If
        
        If urunUpper.Contains("KABAN") Then
            If urunUpper.Contains("KADIN") OrElse urunUpper.Contains("BAYAN") Then
                Return New Tuple(Of String, String)("533", "Kadin Kaban")
            Else
                Return New Tuple(Of String, String)("533", "Erkek Kaban")
            End If
        End If
        
        If urunUpper.Contains("CEKET") Then
            If urunUpper.Contains("KADIN") OrElse urunUpper.Contains("BAYAN") Then
                Return New Tuple(Of String, String)("594", "Kadin Ceket")
            Else
                Return New Tuple(Of String, String)("594", "Erkek Ceket")
            End If
        End If
        
        ' === BERMUDA / SORT ===
        If urunUpper.Contains("BERMUDA") OrElse urunUpper.Contains("SORT") Then
            Return New Tuple(Of String, String)("530", "Sort & Bermuda")
        End If
        
        ' === TAKIM ===
        If urunUpper.Contains("PIJAMA") AndAlso urunUpper.Contains("TAKIM") Then
            Return New Tuple(Of String, String)("563", "Pijama Takimi")
        End If
        
        If urunUpper.Contains("ESOFMAN") OrElse (urunUpper.Contains("TAKIM") AndAlso urunUpper.Contains("SPOR")) Then
            Return New Tuple(Of String, String)("598", "Esofman Takimi")
        End If
        
        If urunUpper.Contains("TAKIM") Then
            If urunUpper.Contains("KADIN") OrElse urunUpper.Contains("BAYAN") Then
                Return New Tuple(Of String, String)("601", "Kadin Takim")
            Else
                Return New Tuple(Of String, String)("601", "Erkek Takim")
            End If
        End If
        
        ' === UST GIYIM ===
        If urunUpper.Contains("TISORT") OrElse urunUpper.Contains("TSHIRT") OrElse urunUpper.Contains("T-SHIRT") Then
            Return New Tuple(Of String, String)("604", "T-Shirt")
        End If
        
        If urunUpper.Contains("GOMLEK") OrElse urunUpper.Contains("GÖMLEK") Then
            Return New Tuple(Of String, String)("600", "Gomlek")
        End If
        
        If urunUpper.Contains("SWEAT") OrElse urunUpper.Contains("HOODIE") Then
            Return New Tuple(Of String, String)("593", "Sweatshirt")
        End If
        
        If urunUpper.Contains("KAZAK") OrElse urunUpper.Contains("TRIKO") Then
            Return New Tuple(Of String, String)("532", "Kazak")
        End If
        
        If urunUpper.Contains("HIRKA") Then
            Return New Tuple(Of String, String)("531", "Hirka")
        End If
        
        If urunUpper.Contains("YELEK") Then
            Return New Tuple(Of String, String)("596", "Yelek")
        End If
        
        ' === ALT GIYIM ===
        If urunUpper.Contains("PANTOLON") Then
            Return New Tuple(Of String, String)("529", "Pantolon")
        End If
        
        If urunUpper.Contains("JEAN") OrElse urunUpper.Contains("KOT") Then
            Return New Tuple(Of String, String)("528", "Jean")
        End If
        
        ' === KADIN ===
        If urunUpper.Contains("ELBISE") Then
            Return New Tuple(Of String, String)("1182", "Elbise")
        End If
        
        If urunUpper.Contains("ETEK") Then
            Return New Tuple(Of String, String)("597", "Etek")
        End If
        
        If urunUpper.Contains("BLUZ") Then
            Return New Tuple(Of String, String)("599", "Bluz")
        End If
        
        ' === PIJAMA ===
        If urunUpper.Contains("PIJAMA") Then
            Return New Tuple(Of String, String)("563", "Pijama Takimi")
        End If
        
        ' Eslestirme bulunamadi
        Return Nothing
    End Function
    
    ''' <summary>
    ''' Urun adindan Trendyol aramasi icin anahtar kelime cikarir
    ''' Ornek: "U.S.POLO ASSN ERKEK BEBEK MONT" -> "u.s.polo mont erkek bebek"
    ''' </summary>
    Private Function UrunAdindanAnahtarKelimeCikar(urunAdi As String) As String
        Dim kelimeler As New List(Of String)()
        Dim urunUpper As String = urunAdi.ToUpper()
        
        ' MARKA anahtar kelimeleri
        If urunUpper.Contains("U.S.POLO") OrElse urunUpper.Contains("US POLO") OrElse urunUpper.Contains("USPOLO") Then
            kelimeler.Add("u.s.polo")
        ElseIf urunUpper.Contains("DEFACTO") Then
            kelimeler.Add("defacto")
        ElseIf urunUpper.Contains("LC WAIKIKI") OrElse urunUpper.Contains("LCWAIKIKI") Then
            kelimeler.Add("lc waikiki")
        ElseIf urunUpper.Contains("KOTON") Then
            kelimeler.Add("koton")
        ElseIf urunUpper.Contains("MAVI") Then
            kelimeler.Add("mavi")
        ElseIf urunUpper.Contains("COLIN") Then
            kelimeler.Add("colins")
        ElseIf urunUpper.Contains("NIKE") Then
            kelimeler.Add("nike")
        ElseIf urunUpper.Contains("ADIDAS") Then
            kelimeler.Add("adidas")
        ElseIf urunUpper.Contains("PUMA") Then
            kelimeler.Add("puma")
        ElseIf urunUpper.Contains("ZARA") Then
            kelimeler.Add("zara")
        ElseIf urunUpper.Contains("H&M") OrElse urunUpper.Contains("HM ") Then
            kelimeler.Add("h&m")
        ElseIf urunUpper.Contains("TOMMY") Then
            kelimeler.Add("tommy hilfiger")
        ElseIf urunUpper.Contains("LACOSTE") Then
            kelimeler.Add("lacoste")
        ElseIf urunUpper.Contains("POLO") Then
            kelimeler.Add("polo")
        End If
        
        ' Urun tipi anahtar kelimeleri
        If urunUpper.Contains("MONT") Then
            kelimeler.Add("mont")
        End If
        
        If urunUpper.Contains("KABAN") Then
            kelimeler.Add("kaban")
        End If
        
        If urunUpper.Contains("BERMUDA") Then
            kelimeler.Add("bermuda")
        End If
        
        If urunUpper.Contains("TAKIM") Then
            kelimeler.Add("takim")
        End If
        
        If urunUpper.Contains("SORT") AndAlso Not urunUpper.Contains("TISORT") Then
            kelimeler.Add("sort")
        End If
        
        If urunUpper.Contains("TISORT") OrElse urunUpper.Contains("TSHIRT") Then
            kelimeler.Add("tisort")
        End If
        
        If urunUpper.Contains("PIJAMA") Then
            kelimeler.Add("pijama")
        End If
        
        If urunUpper.Contains("ELBISE") Then
            kelimeler.Add("elbise")
        End If
        
        If urunUpper.Contains("PANTOLON") Then
            kelimeler.Add("pantolon")
        End If
        
        If urunUpper.Contains("GOMLEK") OrElse urunUpper.Contains("GÖMLEK") Then
            kelimeler.Add("gomlek")
        End If
        
        If urunUpper.Contains("CEKET") Then
            kelimeler.Add("ceket")
        End If
        
        If urunUpper.Contains("YELEK") Then
            kelimeler.Add("yelek")
        End If
        
        If urunUpper.Contains("HIRKA") Then
            kelimeler.Add("hirka")
        End If
        
        If urunUpper.Contains("ESOFMAN") Then
            kelimeler.Add("esofman")
        End If
        
        If urunUpper.Contains("SWEAT") Then
            kelimeler.Add("sweatshirt")
        End If
        
        If urunUpper.Contains("KAZAK") Then
            kelimeler.Add("kazak")
        End If
        
        If urunUpper.Contains("TRIKO") Then
            kelimeler.Add("triko")
        End If
        
        ' Cinsiyet/Hedef kitle ekle
        If urunUpper.Contains("ERKEK") AndAlso urunUpper.Contains("BEBEK") Then
            kelimeler.Add("erkek bebek")
        ElseIf urunUpper.Contains("KIZ") AndAlso urunUpper.Contains("BEBEK") Then
            kelimeler.Add("kiz bebek")
        ElseIf urunUpper.Contains("BEBEK") Then
            kelimeler.Add("bebek")
        ElseIf urunUpper.Contains("ERKEK") AndAlso urunUpper.Contains("COCUK") Then
            kelimeler.Add("erkek cocuk")
        ElseIf urunUpper.Contains("KIZ") AndAlso urunUpper.Contains("COCUK") Then
            kelimeler.Add("kiz cocuk")
        ElseIf urunUpper.Contains("COCUK") OrElse urunUpper.Contains("ÇOCUK") Then
            kelimeler.Add("cocuk")
        ElseIf urunUpper.Contains("ERKEK") Then
            kelimeler.Add("erkek")
        ElseIf urunUpper.Contains("KADIN") OrElse urunUpper.Contains("BAYAN") Then
            kelimeler.Add("kadin")
        ElseIf urunUpper.Contains("BABA") AndAlso urunUpper.Contains("OGUL") Then
            kelimeler.Add("erkek")
        ElseIf urunUpper.Contains("ANNE") AndAlso urunUpper.Contains("KIZ") Then
            kelimeler.Add("kadin")
        End If
        
        If kelimeler.Count > 0 Then
            Return String.Join(" ", kelimeler.ToArray())
        Else
            Return ""
        End If
    End Function

#End Region

#Region "BuyBox Analysis"

    ''' <summary>
    ''' Seçili ürünleri analiz et
    ''' DOGRU YONTEM: Urun adini Trendyol'da arayip, 
    ''' diger saticilarin kullandigi kategoriyi bul
    ''' </summary>
    Private Async Sub AnalyzeSelectedProducts()
        If Not TrendyolAPI.Instance.IsConfigured Then
            MessageBox.Show("API yapilandirilmamis! Once Ayarlar'dan API bilgilerini girin.", "Uyari", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If
        
        Dim selectedRows = _dtUrunler.Select("Sec = True")
        If selectedRows.Length = 0 Then
            MessageBox.Show("Lutfen analiz edilecek urunleri secin.", "Uyari", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If
        
        btn_Analiz.Enabled = False
        Me.Cursor = Cursors.WaitCursor
        progressBar.Visible = True
        progressBar.Maximum = selectedRows.Length
        progressBar.Value = 0
        
        Dim basarili As Integer = 0
        Dim basarisiz As Integer = 0
        
        Try
            For Each row As DataRow In selectedRows
                Dim barkod As String = row("sBarkod").ToString()
                Dim stokId As Integer = CInt(row("nStokID"))
                Dim urunAdi As String = row("sAciklama").ToString()
                
                lbl_Status.Text = "Trendyol'da araniyor: " & urunAdi.Substring(0, Math.Min(30, urunAdi.Length)) & "..."
                Application.DoEvents()
                
                ' ========================================
                ' DOGRU YONTEM: Urun adini Trendyol'da ara
                ' Diger saticilarin kullandigi kategoriyi bul
                ' ========================================
                Dim kategoriSonuc As Tuple(Of String, String, String, String) = Await TrendyoldaUrunAraVeKategoriBul(urunAdi)
                
                If kategoriSonuc IsNot Nothing AndAlso Not String.IsNullOrEmpty(kategoriSonuc.Item1) Then
                    ' Kategori bulundu!
                    Dim bulunanKategoriId As String = kategoriSonuc.Item1
                    Dim bulunanKategoriAd As String = kategoriSonuc.Item2
                    Dim aramaKelimesi As String = kategoriSonuc.Item3
                    Dim ornekUrunler As String = kategoriSonuc.Item4
                    
                    row("TrendyolKategori") = bulunanKategoriAd & " (ID:" & bulunanKategoriId & ")"
                    row("EslesmeDurumu") = "Trendyol'da Bulundu"
                    row("KategoriUyarisi") = "Arama: " & aramaKelimesi
                    row("DogruKategoriId") = bulunanKategoriId
                    row("SonHata") = "Ornekler: " & ornekUrunler
                    
                    basarili += 1
                Else
                    ' Kategori bulunamadi
                    row("TrendyolKategori") = ""
                    row("EslesmeDurumu") = "Bulunamadi"
                    row("KategoriUyarisi") = "MANUEL SEC"
                    row("DogruKategoriId") = ""
                    row("SonHata") = "Trendyol'da benzer urun bulunamadi"
                    
                    basarisiz += 1
                End If
                
                progressBar.Value += 1
                Application.DoEvents()
                
                ' Rate limit - Trendyol'u yorma
                Await Task.Delay(500)
            Next
            
            grd_Urunler.RefreshDataSource()
            
            lbl_Status.Text = basarili.ToString() & " eslesti, " & basarisiz.ToString() & " manuel secim gerekli"
            If basarisiz = 0 Then
                lbl_Status.ForeColor = Color.Green
            Else
                lbl_Status.ForeColor = Color.Orange
            End If
            
            ' Sonuç mesajı
            Dim uyariMesaji As String = "TRENDYOL KATEGORI ESLESTIRME TAMAMLANDI" & vbCrLf & vbCrLf & _
                                        "Trendyol'dan bulunan: " & basarili.ToString() & vbCrLf & _
                                        "Manuel secim gerekli: " & basarisiz.ToString()
            
            If basarili > 0 Then
                uyariMesaji = uyariMesaji & vbCrLf & vbCrLf & _
                              "Simdi 'Tek Tikla Otomatik Duzelt' butonuna tiklayarak" & vbCrLf & _
                              "tum urunlerin kategorilerini Trendyol'a gonderebilirsiniz!"
            End If
            
            MessageBox.Show(uyariMesaji, "Analiz Sonucu", MessageBoxButtons.OK, MessageBoxIcon.Information)
            
        Catch ex As Exception
            lbl_Status.Text = "Hata: " & ex.Message
            lbl_Status.ForeColor = Color.Red
            MessageBox.Show("Analiz sirasinda hata: " & ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            btn_Analiz.Enabled = True
            Me.Cursor = Cursors.Default
            progressBar.Visible = False
        End Try
    End Sub
    
    ''' <summary>
    ''' Trendyol'da urun adini arar ve en cok kullanilan kategoriyi bulur
    ''' Ayni zamanda bulunan ornek urunleri de dondurur
    ''' </summary>
    Private Async Function TrendyoldaUrunAraVeKategoriBul(urunAdi As String) As Task(Of Tuple(Of String, String, String, String))
        ' Tuple: (KategoriId, KategoriAd, AramaKelimesi, OrnekUrunler)
        Try
            ' Urun adindan arama kelimesi olustur
            Dim aramaKelimesi As String = UrunAdindanAramaKelimesiOlustur(urunAdi)
            
            If String.IsNullOrEmpty(aramaKelimesi) Then
                Return Nothing
            End If
            
            ' Trendyol Public API ile ara
            Dim publicClient As New System.Net.Http.HttpClient()
            publicClient.DefaultRequestHeaders.Add("User-Agent", "Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36")
            publicClient.DefaultRequestHeaders.Add("Accept", "application/json")
            
            Dim encodedQuery As String = System.Uri.EscapeDataString(aramaKelimesi)
            Dim apiUrl As String = "https://apigw.trendyol.com/discovery-web-searchgw-service/v2/api/infinite-scroll/sr?q=" & encodedQuery
            
            Dim response As System.Net.Http.HttpResponseMessage = Await publicClient.GetAsync(apiUrl)
            
            If response.StatusCode <> System.Net.HttpStatusCode.OK Then
                Return Nothing
            End If
            
            Dim content As String = Await response.Content.ReadAsStringAsync()
            
            ' JSON parse et ve en cok kullanilan kategoriyi bul
            Dim kategoriSayac As New Dictionary(Of String, Integer)()
            Dim kategoriAdlari As New Dictionary(Of String, String)()
            Dim ornekUrunler As New List(Of String)()
            
            ' Urun adlarini ve kategorilerini cek
            Dim namePattern As String = """name"":""([^""]{1,50})"
            Dim idPattern As String = """categoryId"":(\d+)"
            Dim hierPattern As String = """categoryHierarchy"":""([^""]*)"""
            
            Dim nameMatches As System.Text.RegularExpressions.MatchCollection = System.Text.RegularExpressions.Regex.Matches(content, namePattern)
            Dim idMatches As System.Text.RegularExpressions.MatchCollection = System.Text.RegularExpressions.Regex.Matches(content, idPattern)
            Dim hierMatches As System.Text.RegularExpressions.MatchCollection = System.Text.RegularExpressions.Regex.Matches(content, hierPattern)
            
            Dim i As Integer = 0
            For Each idMatch As System.Text.RegularExpressions.Match In idMatches
                Dim catId As String = idMatch.Groups(1).Value
                Dim catHier As String = ""
                Dim urunAdiTrendyol As String = ""
                
                If i < hierMatches.Count Then
                    catHier = hierMatches(i).Groups(1).Value
                End If
                
                If i < nameMatches.Count Then
                    urunAdiTrendyol = nameMatches(i).Groups(1).Value
                End If
                
                ' Alakasiz kategorileri filtrele
                If catHier.ToUpper().Contains("KAPORTA") OrElse _
                   catHier.ToUpper().Contains("OTOMOBIL") OrElse _
                   catHier.ToUpper().Contains("HIRDAVAT") OrElse _
                   catHier.ToUpper().Contains("LEVHA") Then
                    i += 1
                    Continue For
                End If
                
                ' Ornek urun ekle (ilk 3 tane)
                If ornekUrunler.Count < 3 AndAlso Not String.IsNullOrEmpty(urunAdiTrendyol) Then
                    ornekUrunler.Add(urunAdiTrendyol)
                End If
                
                If Not kategoriSayac.ContainsKey(catId) Then
                    kategoriSayac.Add(catId, 1)
                    kategoriAdlari.Add(catId, catHier)
                Else
                    kategoriSayac(catId) += 1
                End If
                
                i += 1
                
                ' Ilk 20 sonucu incele
                If i >= 20 Then Exit For
            Next
            
            ' En cok kullanilan kategoriyi bul
            If kategoriSayac.Count > 0 Then
                Dim enCokKategoriId As String = ""
                Dim enCokSayi As Integer = 0
                
                For Each kvp As KeyValuePair(Of String, Integer) In kategoriSayac
                    If kvp.Value > enCokSayi Then
                        enCokSayi = kvp.Value
                        enCokKategoriId = kvp.Key
                    End If
                Next
                
                Dim kategoriAd As String = ""
                If kategoriAdlari.ContainsKey(enCokKategoriId) Then
                    kategoriAd = kategoriAdlari(enCokKategoriId)
                End If
                
                Dim orneklerStr As String = ""
                If ornekUrunler.Count > 0 Then
                    orneklerStr = String.Join(" | ", ornekUrunler.ToArray())
                End If
                
                Return New Tuple(Of String, String, String, String)(enCokKategoriId, kategoriAd, aramaKelimesi, orneklerStr)
            End If
            
            Return Nothing
            
        Catch ex As Exception
            System.Diagnostics.Debug.WriteLine("Trendyol arama hatasi: " & ex.Message)
            Return Nothing
        End Try
    End Function
    
    ''' <summary>
    ''' Urun adindan Trendyol aramasi icin kelime olusturur
    ''' Marka + Hedef Kitle + Urun Tipi
    ''' Ornek: "U.S.POLO ASSN ERKEK BEBEK MONT LACIVERT 3-6 AY" -> "us polo erkek bebek mont"
    ''' </summary>
    Private Function UrunAdindanAramaKelimesiOlustur(urunAdi As String) As String
        Dim kelimeler As New List(Of String)()
        Dim urunUpper As String = urunAdi.ToUpper()
        
        ' MARKA - normalize edilmis hali (noktasiz, bosluksuz)
        Dim marka As String = MarkaCikar(urunUpper)
        If Not String.IsNullOrEmpty(marka) Then
            kelimeler.Add(marka)
        End If
        
        ' Hedef kitle
        If urunUpper.Contains("BABA") AndAlso (urunUpper.Contains("OGUL") OrElse urunUpper.Contains("OĞUL")) Then
            kelimeler.Add("baba ogul")
        ElseIf urunUpper.Contains("ANNE") AndAlso urunUpper.Contains("KIZ") Then
            kelimeler.Add("anne kiz")
        ElseIf urunUpper.Contains("ERKEK") AndAlso urunUpper.Contains("BEBEK") Then
            kelimeler.Add("erkek bebek")
        ElseIf urunUpper.Contains("KIZ") AndAlso urunUpper.Contains("BEBEK") Then
            kelimeler.Add("kiz bebek")
        ElseIf urunUpper.Contains("BEBEK") Then
            kelimeler.Add("bebek")
        ElseIf urunUpper.Contains("ERKEK") AndAlso (urunUpper.Contains("COCUK") OrElse urunUpper.Contains("ÇOCUK")) Then
            kelimeler.Add("erkek cocuk")
        ElseIf urunUpper.Contains("KIZ") AndAlso (urunUpper.Contains("COCUK") OrElse urunUpper.Contains("ÇOCUK")) Then
            kelimeler.Add("kiz cocuk")
        ElseIf urunUpper.Contains("COCUK") OrElse urunUpper.Contains("ÇOCUK") Then
            kelimeler.Add("cocuk")
        ElseIf urunUpper.Contains("ERKEK") Then
            kelimeler.Add("erkek")
        ElseIf urunUpper.Contains("KADIN") OrElse urunUpper.Contains("BAYAN") Then
            kelimeler.Add("kadin")
        End If
        
        ' Urun tipi
        If urunUpper.Contains("BERMUDA") Then
            kelimeler.Add("bermuda")
        End If
        If urunUpper.Contains("TAKIM") OrElse urunUpper.Contains("SET") Then
            kelimeler.Add("takim")
        End If
        If urunUpper.Contains("MONT") Then
            kelimeler.Add("mont")
        End If
        If urunUpper.Contains("KABAN") Then
            kelimeler.Add("kaban")
        End If
        If urunUpper.Contains("CEKET") Then
            kelimeler.Add("ceket")
        End If
        If urunUpper.Contains("SORT") AndAlso Not urunUpper.Contains("TISORT") Then
            kelimeler.Add("sort")
        End If
        If urunUpper.Contains("TISORT") OrElse urunUpper.Contains("TSHIRT") OrElse urunUpper.Contains("T-SHIRT") Then
            kelimeler.Add("tisort")
        End If
        If urunUpper.Contains("PIJAMA") Then
            kelimeler.Add("pijama")
        End If
        If urunUpper.Contains("ELBISE") Then
            kelimeler.Add("elbise")
        End If
        If urunUpper.Contains("PANTOLON") Then
            kelimeler.Add("pantolon")
        End If
        If urunUpper.Contains("GOMLEK") OrElse urunUpper.Contains("GÖMLEK") Then
            kelimeler.Add("gomlek")
        End If
        If urunUpper.Contains("SWEAT") Then
            kelimeler.Add("sweatshirt")
        End If
        If urunUpper.Contains("ESOFMAN") OrElse urunUpper.Contains("EŞOFMAN") Then
            kelimeler.Add("esofman")
        End If
        If urunUpper.Contains("YELEK") Then
            kelimeler.Add("yelek")
        End If
        If urunUpper.Contains("HIRKA") OrElse urunUpper.Contains("HIRKA") Then
            kelimeler.Add("hirka")
        End If
        If urunUpper.Contains("KAZAK") Then
            kelimeler.Add("kazak")
        End If
        If urunUpper.Contains("BODY") Then
            kelimeler.Add("body")
        End If
        If urunUpper.Contains("TULUM") Then
            kelimeler.Add("tulum")
        End If
        
        If kelimeler.Count > 0 Then
            Return String.Join(" ", kelimeler.ToArray())
        Else
            ' Hic anahtar kelime bulunamadiysa ilk 3 kelimeyi kullan
            Dim parcalar() As String = urunAdi.Split(New Char() {" "c}, StringSplitOptions.RemoveEmptyEntries)
            If parcalar.Length >= 2 Then
                Return parcalar(0) & " " & parcalar(1)
            ElseIf parcalar.Length >= 1 Then
                Return parcalar(0)
            End If
            Return ""
        End If
    End Function
    
    ''' <summary>
    ''' Urun adindan markayi cikarir ve normalize eder
    ''' U.S.POLO ASSN -> us polo
    ''' LC WAIKIKI -> lc waikiki
    ''' </summary>
    Private Function MarkaCikar(urunUpper As String) As String
        ' Markalari kontrol et - normalize edilmis arama kelimesi dondur
        
        ' U.S. POLO ASSN varyasyonlari
        If urunUpper.Contains("U.S.POLO") OrElse urunUpper.Contains("U.S. POLO") OrElse _
           urunUpper.Contains("US POLO") OrElse urunUpper.Contains("USPOLO") OrElse _
           urunUpper.Contains("U S POLO") Then
            Return "us polo"
        End If
        
        ' LC WAIKIKI varyasyonlari
        If urunUpper.Contains("LC WAIKIKI") OrElse urunUpper.Contains("LCWAIKIKI") OrElse _
           urunUpper.Contains("LC.WAIKIKI") OrElse urunUpper.Contains("L.C. WAIKIKI") Then
            Return "lc waikiki"
        End If
        
        ' DEFACTO
        If urunUpper.Contains("DEFACTO") OrElse urunUpper.Contains("DE FACTO") Then
            Return "defacto"
        End If
        
        ' KOTON
        If urunUpper.Contains("KOTON") Then
            Return "koton"
        End If
        
        ' MAVI
        If urunUpper.Contains("MAVI JEANS") OrElse (urunUpper.Contains("MAVI") AndAlso (urunUpper.Contains("JEAN") OrElse urunUpper.Contains("PANTOLON"))) Then
            Return "mavi"
        End If
        
        ' COLIN'S
        If urunUpper.Contains("COLINS") OrElse urunUpper.Contains("COLIN'S") OrElse urunUpper.Contains("COLIN S") Then
            Return "colins"
        End If
        
        ' NIKE
        If urunUpper.Contains("NIKE") Then
            Return "nike"
        End If
        
        ' ADIDAS
        If urunUpper.Contains("ADIDAS") Then
            Return "adidas"
        End If
        
        ' PUMA
        If urunUpper.Contains("PUMA") Then
            Return "puma"
        End If
        
        ' TOMMY HILFIGER
        If urunUpper.Contains("TOMMY HILFIGER") OrElse urunUpper.Contains("TOMMY") Then
            Return "tommy hilfiger"
        End If
        
        ' LACOSTE
        If urunUpper.Contains("LACOSTE") Then
            Return "lacoste"
        End If
        
        ' ZARA
        If urunUpper.Contains("ZARA") Then
            Return "zara"
        End If
        
        ' H&M
        If urunUpper.Contains("H&M") OrElse urunUpper.Contains("H & M") OrElse urunUpper.Contains("HM ") Then
            Return "hm"
        End If
        
        ' MANGO
        If urunUpper.Contains("MANGO") Then
            Return "mango"
        End If
        
        ' VAKKO
        If urunUpper.Contains("VAKKO") Then
            Return "vakko"
        End If
        
        ' NETWORK
        If urunUpper.Contains("NETWORK") Then
            Return "network"
        End If
        
        ' BEYMEN
        If urunUpper.Contains("BEYMEN") Then
            Return "beymen"
        End If
        
        ' PIERRE CARDIN
        If urunUpper.Contains("PIERRE CARDIN") OrElse urunUpper.Contains("PIERRECARDIN") Then
            Return "pierre cardin"
        End If
        
        ' KIGILI
        If urunUpper.Contains("KIGILI") OrElse urunUpper.Contains("KIĞILI") Then
            Return "kigili"
        End If
        
        ' DAMAT
        If urunUpper.Contains("DAMAT") Then
            Return "damat"
        End If
        
        ' TWEEN
        If urunUpper.Contains("TWEEN") Then
            Return "tween"
        End If
        
        ' DS DAMAT
        If urunUpper.Contains("DS DAMAT") OrElse urunUpper.Contains("D'S DAMAT") Then
            Return "ds damat"
        End If
        
        ' AVVA
        If urunUpper.Contains("AVVA") Then
            Return "avva"
        End If
        
        ' ALTINYILDIZ
        If urunUpper.Contains("ALTINYILDIZ") OrElse urunUpper.Contains("ALTIN YILDIZ") Then
            Return "altinyildiz"
        End If
        
        ' Marka bulunamadi
        Return ""
    End Function

    ''' <summary>
    ''' Eşleşme sonucunu veritabanına kaydet
    ''' </summary>
    Private Sub SaveMatchResult(stokId As Integer, bizimBarkod As String, trendyolProduct As TrendyolProduct, eslesmeDurumu As Integer, hata As String)
        Try
            Using con As New OleDb.OleDbConnection(connection)
                con.Open()
                Using cmd As New OleDb.OleDbCommand()
                    cmd.Connection = con
                    
                    ' Önce mevcut kaydı kontrol et
                    cmd.CommandText = "SELECT COUNT(*) FROM tbTrendyolUrunEsleme WHERE nStokID = ?"
                    cmd.Parameters.Clear()
                    cmd.Parameters.AddWithValue("@p1", stokId)
                    Dim count As Integer = CInt(cmd.ExecuteScalar())
                    
                    If count > 0 Then
                        ' Güncelle
                        cmd.CommandText = "UPDATE tbTrendyolUrunEsleme SET " &
                                          "sBizimBarkod=?, sTrendyolBarkod=?, sTrendyolProductId=?, " &
                                          "sTrendyolTitle=?, sTrendyolCategoryId=?, sTrendyolBrand=?, " &
                                          "nEslesmeDurumu=?, sSonHata=?, dteGuncelleme=?, bAktif=1 " &
                                          "WHERE nStokID=?"
                    Else
                        ' Ekle
                        cmd.CommandText = "INSERT INTO tbTrendyolUrunEsleme " &
                                          "(nStokID, sBizimBarkod, sTrendyolBarkod, sTrendyolProductId, " &
                                          "sTrendyolTitle, sTrendyolCategoryId, sTrendyolBrand, " &
                                          "nEslesmeDurumu, sSonHata, dteOlusturma, bAktif) " &
                                          "VALUES (?, ?, ?, ?, ?, ?, ?, ?, ?, ?, 1)"
                    End If
                    
                    cmd.Parameters.Clear()
                    
                    If count > 0 Then
                        cmd.Parameters.AddWithValue("@p1", bizimBarkod)
                        If trendyolProduct IsNot Nothing Then
                            cmd.Parameters.AddWithValue("@p2", trendyolProduct.Barcode)
                            cmd.Parameters.AddWithValue("@p3", trendyolProduct.Id)
                            cmd.Parameters.AddWithValue("@p4", trendyolProduct.Title)
                            cmd.Parameters.AddWithValue("@p5", trendyolProduct.CategoryId)
                            cmd.Parameters.AddWithValue("@p6", trendyolProduct.BrandName)
                        Else
                            cmd.Parameters.AddWithValue("@p2", DBNull.Value)
                            cmd.Parameters.AddWithValue("@p3", DBNull.Value)
                            cmd.Parameters.AddWithValue("@p4", DBNull.Value)
                            cmd.Parameters.AddWithValue("@p5", DBNull.Value)
                            cmd.Parameters.AddWithValue("@p6", DBNull.Value)
                        End If
                        cmd.Parameters.AddWithValue("@p7", eslesmeDurumu)
                        If String.IsNullOrEmpty(hata) Then
                            cmd.Parameters.AddWithValue("@p8", DBNull.Value)
                        Else
                            cmd.Parameters.AddWithValue("@p8", hata)
                        End If
                        cmd.Parameters.AddWithValue("@p9", DateTime.Now)
                        cmd.Parameters.AddWithValue("@p10", stokId)
                    Else
                        cmd.Parameters.AddWithValue("@p1", stokId)
                        cmd.Parameters.AddWithValue("@p2", bizimBarkod)
                        If trendyolProduct IsNot Nothing Then
                            cmd.Parameters.AddWithValue("@p3", trendyolProduct.Barcode)
                            cmd.Parameters.AddWithValue("@p4", trendyolProduct.Id)
                            cmd.Parameters.AddWithValue("@p5", trendyolProduct.Title)
                            cmd.Parameters.AddWithValue("@p6", trendyolProduct.CategoryId)
                            cmd.Parameters.AddWithValue("@p7", trendyolProduct.BrandName)
                        Else
                            cmd.Parameters.AddWithValue("@p3", DBNull.Value)
                            cmd.Parameters.AddWithValue("@p4", DBNull.Value)
                            cmd.Parameters.AddWithValue("@p5", DBNull.Value)
                            cmd.Parameters.AddWithValue("@p6", DBNull.Value)
                            cmd.Parameters.AddWithValue("@p7", DBNull.Value)
                        End If
                        cmd.Parameters.AddWithValue("@p8", eslesmeDurumu)
                        If String.IsNullOrEmpty(hata) Then
                            cmd.Parameters.AddWithValue("@p9", DBNull.Value)
                        Else
                            cmd.Parameters.AddWithValue("@p9", hata)
                        End If
                        cmd.Parameters.AddWithValue("@p10", DateTime.Now)
                    End If
                    
                    cmd.ExecuteNonQuery()
                End Using
            End Using
        Catch ex As Exception
            ' Hata mesajı göster
            MessageBox.Show("Kayıt hatası: " & ex.Message, "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End Try
    End Sub

#End Region

#Region "Button Events"

    Private Sub btn_Yukle_Click(sender As Object, e As EventArgs) Handles btn_Yukle.Click
        LoadProducts()
    End Sub

    Private Sub btn_Analiz_Click(sender As Object, e As EventArgs) Handles btn_Analiz.Click
        AnalyzeSelectedProducts()
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
    
    Private Sub btn_KategoriDegistir_Click(sender As Object, e As EventArgs) Handles btn_KategoriDegistir.Click
        ' Seçili ürünleri kontrol et
        Dim selectedRows As DataRow() = _dtUrunler.Select("Sec = True")
        
        If selectedRows.Length = 0 Then
            MessageBox.Show("Lütfen kategori değiştirilecek ürünleri seçin.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If
        
        ' Kategori seçim formu aç
        Using frm As New frm_TrendyolKategoriSec()
            frm.connection = connection
            If frm.ShowDialog() = DialogResult.OK Then
                Dim yeniKategoriId As String = frm.SecilenKategoriId
                Dim yeniKategoriAd As String = frm.SecilenKategoriAd
                
                If Not String.IsNullOrEmpty(yeniKategoriId) Then
                    ' Seçili ürünler için kategori güncelle
                    UpdateCategoriesForSelectedProducts(selectedRows, yeniKategoriId, yeniKategoriAd)
                End If
            End If
        End Using
    End Sub
    
    Private Async Sub UpdateCategoriesForSelectedProducts(selectedRows As DataRow(), yeniKategoriId As String, yeniKategoriAd As String)
        If Not TrendyolAPI.Instance.IsConfigured Then
            MessageBox.Show("API yapılandırılmamış!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If
        
        Dim basarili As Integer = 0
        Dim basarisiz As Integer = 0
        
        progressBar.Visible = True
        progressBar.Minimum = 0
        progressBar.Maximum = selectedRows.Length
        progressBar.Value = 0
        
        For Each row As DataRow In selectedRows
            Dim barkod As String = row("sBarkod").ToString()
            
            lbl_Status.Text = "Kategori güncelleniyor: " & barkod & "..."
            Application.DoEvents()
            
            Try
                Dim result As ApiResult(Of String) = Await TrendyolAPI.Instance.UpdateProductCategoryAsync(barkod, yeniKategoriId)
                
                If result.Success Then
                    row("TrendyolKategori") = yeniKategoriAd
                    row("KategoriUyarisi") = "Guncellendi"
                    row("SonHata") = "Batch: " & result.Data
                    row("DogruKategoriId") = ""
                    
                    ' VERITABANINA KAYDET - tbTrendyolUrunEsleme tablosunu guncelle
                    Dim stokId As Integer = CInt(row("nStokID"))
                    SaveCategoryToDatabase(stokId, barkod, yeniKategoriId, yeniKategoriAd)
                    
                    basarili += 1
                Else
                    row("KategoriUyarisi") = "Hata"
                    row("SonHata") = result.ErrorMessage
                    basarisiz += 1
                End If
            Catch ex As Exception
                row("KategoriUyarisi") = "Hata"
                row("SonHata") = ex.Message
                basarisiz += 1
            End Try
            
            progressBar.Value += 1
            Application.DoEvents()
            
            ' Rate limit için bekle
            Await Task.Delay(500)
        Next
        
        progressBar.Visible = False
        grd_Urunler.RefreshDataSource()
        
        lbl_Status.Text = "Kategori güncelleme tamamlandı. Başarılı: " & basarili.ToString() & ", Başarısız: " & basarisiz.ToString()
        If basarisiz = 0 Then
            lbl_Status.ForeColor = Color.Green
        Else
            lbl_Status.ForeColor = Color.Orange
        End If
        
        MessageBox.Show("Kategori güncelleme tamamlandı." & vbCrLf & _
                        "Başarılı: " & basarili.ToString() & vbCrLf & _
                        "Başarısız: " & basarisiz.ToString() & vbCrLf & vbCrLf & _
                        "NOT: Trendyol'un değişiklikleri işlemesi birkaç dakika sürebilir.", _
                        "Sonuç", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub
    
    ''' <summary>
    ''' Kategori değişikliğini veritabanına kaydet
    ''' 1. tbSSinif4'e yeni kategori ekler (yoksa)
    ''' 2. tbStokSinifi.sSinifKodu4 alanını günceller
    ''' 3. tbTrendyolUrunEsleme.nTrendyolCategoryId günceller
    ''' </summary>
    Private Sub SaveCategoryToDatabase(stokId As Integer, barkod As String, kategoriId As String, kategoriAd As String)
        Dim sinifKodu As String = "TY" & kategoriId  ' TY530 gibi
        Dim kategoriIdInt As Integer = 0
        Integer.TryParse(kategoriId, kategoriIdInt)
        
        Try
            Using con As New OleDb.OleDbConnection(connection)
                con.Open()
                
                ' 1. tbSSinif4'e kategori ekle (yoksa)
                Try
                    Using cmd As New OleDb.OleDbCommand()
                        cmd.Connection = con
                        cmd.CommandText = "SELECT COUNT(*) FROM tbSSinif4 WHERE sSinifKodu = ?"
                        cmd.Parameters.AddWithValue("@p1", sinifKodu)
                        Dim sinifVar As Integer = CInt(cmd.ExecuteScalar())
                        
                        If sinifVar = 0 Then
                            cmd.CommandText = "INSERT INTO tbSSinif4 (sSinifKodu, sAciklama) VALUES (?, ?)"
                            cmd.Parameters.Clear()
                            cmd.Parameters.AddWithValue("@p1", sinifKodu)
                            cmd.Parameters.AddWithValue("@p2", kategoriAd)
                            cmd.ExecuteNonQuery()
                        End If
                    End Using
                Catch ex As Exception
                    MessageBox.Show("tbSSinif4 kayit hatasi: " & ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End Try
                
                ' 2. tbStokSinifi.sSinifKodu4 guncelle
                Try
                    Using cmd As New OleDb.OleDbCommand()
                        cmd.Connection = con
                        cmd.CommandText = "SELECT COUNT(*) FROM tbStokSinifi WHERE nStokID = ?"
                        cmd.Parameters.AddWithValue("@p1", stokId)
                        Dim stokSinifiVar As Integer = CInt(cmd.ExecuteScalar())
                        
                        If stokSinifiVar > 0 Then
                            cmd.CommandText = "UPDATE tbStokSinifi SET sSinifKodu4 = ? WHERE nStokID = ?"
                            cmd.Parameters.Clear()
                            cmd.Parameters.AddWithValue("@p1", sinifKodu)
                            cmd.Parameters.AddWithValue("@p2", stokId)
                        Else
                            cmd.CommandText = "INSERT INTO tbStokSinifi (nStokID, sSinifKodu4) VALUES (?, ?)"
                            cmd.Parameters.Clear()
                            cmd.Parameters.AddWithValue("@p1", stokId)
                            cmd.Parameters.AddWithValue("@p2", sinifKodu)
                        End If
                        cmd.ExecuteNonQuery()
                    End Using
                Catch ex As Exception
                    MessageBox.Show("tbStokSinifi kayit hatasi: " & ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End Try
                
                ' 3. tbTrendyolUrunEsleme.sTrendyolCategoryId güncelle (STRING olarak)
                Try
                    Using cmd As New OleDb.OleDbCommand()
                        cmd.Connection = con
                        
                        ' Önce kayıt var mı kontrol et
                        cmd.CommandText = "SELECT COUNT(*) FROM tbTrendyolUrunEsleme WHERE nStokID = ?"
                        cmd.Parameters.AddWithValue("@p1", stokId)
                        Dim eslemeVar As Integer = CInt(cmd.ExecuteScalar())
                        
                        If eslemeVar > 0 Then
                            ' UPDATE - sTrendyolCategoryId STRING tipinde
                            cmd.CommandText = "UPDATE tbTrendyolUrunEsleme SET sTrendyolCategoryId = ?, dteGuncelleme = ? WHERE nStokID = ?"
                            cmd.Parameters.Clear()
                            cmd.Parameters.AddWithValue("@p1", kategoriId)
                            cmd.Parameters.AddWithValue("@p2", DateTime.Now)
                            cmd.Parameters.AddWithValue("@p3", stokId)
                        Else
                            ' INSERT - yeni kayit
                            cmd.CommandText = "INSERT INTO tbTrendyolUrunEsleme (nStokID, sBizimBarkod, sTrendyolCategoryId, nEslesmeDurumu, bAktif, dteOlusturma) VALUES (?, ?, ?, 1, 1, ?)"
                            cmd.Parameters.Clear()
                            cmd.Parameters.AddWithValue("@p1", stokId)
                            cmd.Parameters.AddWithValue("@p2", barkod)
                            cmd.Parameters.AddWithValue("@p3", kategoriId)
                            cmd.Parameters.AddWithValue("@p4", DateTime.Now)
                        End If
                        cmd.ExecuteNonQuery()
                    End Using
                Catch ex As Exception
                    MessageBox.Show("tbTrendyolUrunEsleme kayit hatasi: " & ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End Try
                
            End Using
            
            ' Basarili mesaji
            System.Diagnostics.Debug.WriteLine("Kategori kaydedildi: StokID=" & stokId.ToString() & ", Sinif=" & sinifKodu & ", KategoriID=" & kategoriIdInt.ToString())
            
        Catch ex As Exception
            MessageBox.Show("Veritabani baglanti hatasi: " & ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
    
    ''' <summary>
    ''' Tek Tıkla Otomatik Düzelt - Analiz sonucundaki doğru kategoriyi otomatik uygula
    ''' </summary>
    Private Sub btn_OtomatikDuzelt_Click(sender As Object, e As EventArgs) Handles btn_OtomatikDuzelt.Click
        ' Düzeltilecek ürünleri bul (DogruKategoriId dolu olanlar)
        Dim duzeltilecekler As New List(Of DataRow)()
        
        For Each row As DataRow In _dtUrunler.Rows
            Dim dogruKategori As String = ""
            If Not IsDBNull(row("DogruKategoriId")) Then
                dogruKategori = row("DogruKategoriId").ToString()
            End If
            
            If Not String.IsNullOrEmpty(dogruKategori) Then
                duzeltilecekler.Add(row)
            End If
        Next
        
        If duzeltilecekler.Count = 0 Then
            MessageBox.Show("Duzeltilecek urun bulunamadi!" & vbCrLf & vbCrLf & _
                            "Once urunleri secip 'Secilenleri Analiz Et' butonuna tiklayin." & vbCrLf & _
                            "Analiz sonucunda kategori uyumsuzlugu tespit edilen urunler otomatik duzeltilecektir.", _
                            "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Return
        End If
        
        ' Onay iste
        Dim onay As DialogResult = MessageBox.Show( _
            duzeltilecekler.Count.ToString() & " urun icin kategori duzeltmesi yapilacak." & vbCrLf & vbCrLf & _
            "Bu islem urunlerinizin Trendyol'daki kategorisini BuyBox kategorisiyle eslestirecek." & vbCrLf & _
            "Boylece urunleriniz diger saticilarla ayni listede gozukecek ve BuyBox'a girebilecek." & vbCrLf & vbCrLf & _
            "Devam etmek istiyor musunuz?", _
            "Otomatik Kategori Duzeltme", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        
        If onay = DialogResult.Yes Then
            OtomatikKategoriDuzelt(duzeltilecekler)
        End If
    End Sub
    
    ''' <summary>
    ''' Otomatik kategori düzeltme işlemini gerçekleştir
    ''' </summary>
    Private Async Sub OtomatikKategoriDuzelt(urunler As List(Of DataRow))
        If Not TrendyolAPI.Instance.IsConfigured Then
            MessageBox.Show("API yapilandirilmamis!", "Uyari", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If
        
        btn_OtomatikDuzelt.Enabled = False
        btn_Analiz.Enabled = False
        btn_KategoriDegistir.Enabled = False
        Me.Cursor = Cursors.WaitCursor
        
        progressBar.Visible = True
        progressBar.Minimum = 0
        progressBar.Maximum = urunler.Count
        progressBar.Value = 0
        
        Dim basarili As Integer = 0
        Dim basarisiz As Integer = 0
        
        Try
            For Each row As DataRow In urunler
                Dim barkod As String = row("sBarkod").ToString()
                Dim dogruKategoriId As String = row("DogruKategoriId").ToString()
                Dim stokId As Integer = CInt(row("nStokID"))
                
                ' sModel'i de al - barkod bulunamazsa stockCode olarak kullanilacak
                Dim modelKodu As String = ""
                If Not IsDBNull(row("sModel")) Then
                    modelKodu = row("sModel").ToString()
                End If
                
                lbl_Status.Text = "Duzeltiliyor: " & barkod & " (Model:" & modelKodu & ") -> Kategori: " & dogruKategoriId
                lbl_Status.ForeColor = Color.Blue
                Application.DoEvents()
                
                Try
                    ' Hem barkod hem de model kodu gonder - API once barkod, sonra model ile arar
                    Dim result As ApiResult(Of String) = Await TrendyolAPI.Instance.UpdateProductCategoryAsync(barkod, dogruKategoriId, modelKodu)
                    
                    ' ONCE VERITABANINA KAYDET (API basarili olsa da olmasa da)
                    ' Boylece Stok Kart'ta kategori gorunur
                    Dim kategoriAciklama As String = ""
                    If Not IsDBNull(row("TrendyolKategori")) Then
                        kategoriAciklama = row("TrendyolKategori").ToString()
                    End If
                    If String.IsNullOrEmpty(kategoriAciklama) Then
                        kategoriAciklama = "Trendyol Kategori " & dogruKategoriId
                    End If
                    SaveCategoryToDatabase(stokId, barkod, dogruKategoriId, kategoriAciklama)
                    
                    If result.Success Then
                        row("KategoriUyarisi") = "DUZELTILDI"
                        row("TrendyolKategori") = dogruKategoriId
                        row("DogruKategoriId") = ""
                        row("SonHata") = "Batch: " & result.Data
                        basarili += 1
                    Else
                        row("KategoriUyarisi") = "DB OK, API HATA"
                        row("SonHata") = result.ErrorMessage
                        basarisiz += 1
                    End If
                Catch ex As Exception
                    row("KategoriUyarisi") = "HATA"
                    row("SonHata") = ex.Message
                    basarisiz += 1
                End Try
                
                progressBar.Value += 1
                Application.DoEvents()
                
                ' Rate limit icin bekle
                Await Task.Delay(500)
            Next
            
            grd_Urunler.RefreshDataSource()
            
            ' Sonuc mesaji
            Dim sonucMesaji As String = "OTOMATIK KATEGORI DUZELTME TAMAMLANDI" & vbCrLf & vbCrLf & _
                                         "Basarili: " & basarili.ToString() & vbCrLf & _
                                         "Basarisiz: " & basarisiz.ToString()
            
            If basarili > 0 Then
                sonucMesaji = sonucMesaji & vbCrLf & vbCrLf & _
                              "ONEMLI: Trendyol'un degisiklikleri islemesi 5-15 dakika surebilir." & vbCrLf & _
                              "Islem tamamlandiktan sonra urunleriniz BuyBox'a girebilecek."
            End If
            
            If basarisiz > 0 Then
                sonucMesaji = sonucMesaji & vbCrLf & vbCrLf & _
                              "Hatali urunler icin 'SonHata' sutununu kontrol edin."
            End If
            
            lbl_Status.Text = "Otomatik duzeltme tamamlandi. Basarili: " & basarili.ToString() & ", Basarisiz: " & basarisiz.ToString()
            If basarisiz = 0 Then
                lbl_Status.ForeColor = Color.Green
            Else
                lbl_Status.ForeColor = Color.Orange
            End If
            
            MessageBox.Show(sonucMesaji, "Sonuc", MessageBoxButtons.OK, MessageBoxIcon.Information)
            
        Catch ex As Exception
            lbl_Status.Text = "Hata: " & ex.Message
            lbl_Status.ForeColor = Color.Red
            MessageBox.Show("Islem hatasi: " & ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            btn_OtomatikDuzelt.Enabled = True
            btn_Analiz.Enabled = True
            btn_KategoriDegistir.Enabled = True
            Me.Cursor = Cursors.Default
            progressBar.Visible = False
        End Try
    End Sub

#End Region

End Class
