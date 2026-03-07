' ============================================================================
' TRENDYOL EXCEL MATCHER - VB.NET
' ============================================================================
' Excel dosyasından barkod ile kategori eşleştirme
' ============================================================================

Imports System.Collections.Generic
Imports System.Data
Imports System.IO
Imports NPOI.SS.UserModel
Imports NPOI.XSSF.UserModel
Imports NPOI.HSSF.UserModel

Public Class TrendyolExcelMatcher
    
    Private _excelData As DataTable = Nothing
    Private _dosyaYolu As String = ""
    Private _barkodSutunIndex As Integer = -1
    Private _urunKoduSutunIndex As Integer = -1  ' URUNKODU sütunu için
    Private _markaSutunIndex As Integer = -1     ' YENİ: Marka sütunu
    
    ' Kategori sütun indeksleri (sıralı liste olarak)
    Private _kategoriSutunIndeksleri As List(Of Integer) = New List(Of Integer)()
    Private _kategoriSutunIsimleri As List(Of String) = New List(Of String)()  ' YENİ: Kategori sütun isimleri
    Private _sabitAnaKategori As String = ""
    
    ' Eski indeksler (geriye uyumluluk için)
    Private _anaKategoriIndex As Integer = -1
    Private _altKategori1Index As Integer = -1
    Private _altKategori2Index As Integer = -1
    Private _altKategori3Index As Integer = -1
    Private _altKategori4Index As Integer = -1
    Private _altKategori5Index As Integer = -1
    
    ' Trendyol_KategoriYolu sütunu (tek sütunda tüm kategoriler "/" ile ayrılmış)
    Private _trendyolKategoriYoluIndex As Integer = -1
    
    ' Debug loglama
    Private _yuklemeLog As List(Of String) = New List(Of String)()
    Private _aramaLog As List(Of String) = New List(Of String)()
    
    ''' <summary>
    ''' Excel'de marka sütunu seçildi mi?
    ''' </summary>
    Public ReadOnly Property MarkaSecildi As Boolean
        Get
            Return _markaSutunIndex >= 0
        End Get
    End Property
    
    ''' <summary>
    ''' Excel dosyasını yükler
    ''' </summary>
    Public Function DosyaYukle(dosyaYolu As String) As Boolean
        Try
            _dosyaYolu = dosyaYolu
            _excelData = New DataTable()
            _yuklemeLog = New List(Of String)()
            
            _yuklemeLog.Add($"Dosya açılıyor: {dosyaYolu}")
            
            Using fs As New FileStream(dosyaYolu, FileMode.Open, FileAccess.Read, FileShare.ReadWrite)
                Dim workbook As IWorkbook
                
                ' Dosya uzantısına göre workbook oluştur
                If Path.GetExtension(dosyaYolu).ToLower() = ".xlsx" Then
                    workbook = New XSSFWorkbook(fs)
                Else
                    workbook = New HSSFWorkbook(fs)
                End If
                
                Dim sheet As ISheet = workbook.GetSheetAt(0)
                _yuklemeLog.Add($"Sayfa adı: {sheet.SheetName}, Satır sayısı: {sheet.LastRowNum}")
                
                ' Başlık satırı
                Dim headerRow As IRow = sheet.GetRow(0)
                If headerRow Is Nothing Then
                    _yuklemeLog.Add("HATA: Başlık satırı boş!")
                    Return False
                End If
                
                _yuklemeLog.Add($"Başlık sütun sayısı: {headerRow.LastCellNum}")
                
                ' Sütunları ekle ve indeksleri bul
                For i As Integer = 0 To headerRow.LastCellNum - 1
                    Dim cell As ICell = headerRow.GetCell(i)
                    Dim columnName As String = If(cell IsNot Nothing, GetCellValue(cell).Trim(), $"Column{i}")
                    _excelData.Columns.Add(columnName)
                    
                    ' Sütun indekslerini bul - Türkçe karakter düzeltmesi ile
                    Dim colNameLower As String = columnName.ToLower().Replace("_", "").Replace(" ", "")
                    ' Türkçe i/ı ve İ/I sorununu çöz
                    colNameLower = colNameLower.Replace("ı", "i").Replace("İ", "i").Replace("ğ", "g").Replace("ü", "u").Replace("ş", "s").Replace("ö", "o").Replace("ç", "c")
                    
                    _yuklemeLog.Add($"  [{i}] '{columnName}' -> normalized: '{colNameLower}'")
                    
                    ' Sütun eşleştirme - Contains ile daha esnek
                    If colNameLower.Contains("barkod") Then
                        _barkodSutunIndex = i
                        _yuklemeLog.Add($"    -> BARKOD sütunu bulundu: {i}")
                    ElseIf colNameLower.Contains("urunkodu") OrElse colNameLower.Contains("stokcode") OrElse colNameLower.Contains("stokkodu") OrElse colNameLower.Contains("modelkodu") Then
                        _urunKoduSutunIndex = i
                        _yuklemeLog.Add($"    -> URUNKODU sütunu bulundu: {i}")
                    ElseIf colNameLower.Contains("kategoriyolu") Then
                        _trendyolKategoriYoluIndex = i
                        _yuklemeLog.Add($"    -> TRENDYOL_KATEGORIYOLU sütunu bulundu: {i}")
                    ElseIf colNameLower.Contains("anakategori") OrElse (colNameLower.Contains("kategori") AndAlso Not colNameLower.Contains("alt") AndAlso colNameLower.Contains("ismi")) Then
                        _anaKategoriIndex = i
                        _yuklemeLog.Add($"    -> ANA_KATEGORI sütunu bulundu: {i}")
                    ElseIf colNameLower.Contains("altkategori1") OrElse colNameLower.Contains("cinsiyet") Then
                        _altKategori1Index = i
                        _yuklemeLog.Add($"    -> ALT_KATEGORI_1 sütunu bulundu: {i}")
                    ElseIf colNameLower.Contains("altkategori2") Then
                        _altKategori2Index = i
                        _yuklemeLog.Add($"    -> ALT_KATEGORI_2 sütunu bulundu: {i}")
                    ElseIf colNameLower.Contains("altkategori3") Then
                        _altKategori3Index = i
                        _yuklemeLog.Add($"    -> ALT_KATEGORI_3 sütunu bulundu: {i}")
                    ElseIf colNameLower.Contains("altkategori4") Then
                        _altKategori4Index = i
                        _yuklemeLog.Add($"    -> ALT_KATEGORI_4 sütunu bulundu: {i}")
                    ElseIf colNameLower.Contains("altkategori5") Then
                        _altKategori5Index = i
                        _yuklemeLog.Add($"    -> ALT_KATEGORI_5 sütunu bulundu: {i}")
                    End If
                Next
                
                _yuklemeLog.Add($"Bulunan indeksler: Barkod={_barkodSutunIndex}, TrendyolKatYolu={_trendyolKategoriYoluIndex}, AnaKat={_anaKategoriIndex}, " &
                              $"Alt1={_altKategori1Index}, Alt2={_altKategori2Index}, Alt3={_altKategori3Index}")
                
                ' UYARI: Kategori sütunları bulunamadıysa bildir
                If _anaKategoriIndex < 0 AndAlso _trendyolKategoriYoluIndex < 0 Then
                    _yuklemeLog.Add("⚠️ UYARI: Hiçbir kategori sütunu bulunamadı!")
                    _yuklemeLog.Add("Beklenen sütunlar: ANA_KATEGORI, ALT_KATEGORI_1, ... veya Trendyol_KategoriYolu")
                End If
                
                ' Veri satırlarını oku
                For rowIndex As Integer = 1 To sheet.LastRowNum
                    Dim row As IRow = sheet.GetRow(rowIndex)
                    If row Is Nothing Then Continue For
                    
                    Dim dataRow As DataRow = _excelData.NewRow()
                    For colIndex As Integer = 0 To headerRow.LastCellNum - 1
                        Dim cell As ICell = row.GetCell(colIndex)
                        dataRow(colIndex) = If(cell IsNot Nothing, GetCellValue(cell), "")
                    Next
                    _excelData.Rows.Add(dataRow)
                Next
                
                _yuklemeLog.Add($"Toplam {_excelData.Rows.Count} satır yüklendi")
                
                ' İlk 3 satırı logla (debug için)
                If _excelData.Rows.Count > 0 AndAlso _barkodSutunIndex >= 0 Then
                    _yuklemeLog.Add("İlk 3 barkod:")
                    For i As Integer = 0 To Math.Min(2, _excelData.Rows.Count - 1)
                        Dim barkodVal As String = _excelData.Rows(i)(_barkodSutunIndex).ToString()
                        _yuklemeLog.Add($"  [{i}] '{barkodVal}'")
                    Next
                End If
                
                workbook.Close()
            End Using
            
            Return _barkodSutunIndex >= 0 OrElse _urunKoduSutunIndex >= 0
            
        Catch ex As Exception
            _yuklemeLog.Add($"HATA: {ex.Message}")
            Return False
        End Try
    End Function
    
    ''' <summary>
    ''' Excel dosyasını manuel seçilen sütunlarla yükler
    ''' </summary>
    Public Function DosyaYukleManuel(dosyaYolu As String, barkodCol As Integer, modelKoduCol As Integer, kategoriCols As List(Of Integer), Optional sabitAnaKategori As String = "", Optional markaCol As Integer = -1, Optional kategoriSutunIsimleri As List(Of String) = Nothing) As Boolean
        Try
            _dosyaYolu = dosyaYolu
            _excelData = New DataTable()
            _yuklemeLog = New List(Of String)()
            
            ' Manuel sütun indekslerini ata
            _barkodSutunIndex = barkodCol
            _urunKoduSutunIndex = modelKoduCol
            _markaSutunIndex = markaCol
            _sabitAnaKategori = If(sabitAnaKategori, "")
            
            ' Kategori sütun isimlerini sakla
            _kategoriSutunIsimleri = New List(Of String)()
            If kategoriSutunIsimleri IsNot Nothing Then
                _kategoriSutunIsimleri.AddRange(kategoriSutunIsimleri)
            End If
            
            ' Kategori sütunlarını SIRASIYLA sakla (sıra önemli!)
            _kategoriSutunIndeksleri = New List(Of Integer)()
            If kategoriCols IsNot Nothing Then
                _kategoriSutunIndeksleri.AddRange(kategoriCols)
            End If
            
            ' Geriye uyumluluk için eski indekslere de ata
            If _kategoriSutunIndeksleri.Count > 0 Then _anaKategoriIndex = _kategoriSutunIndeksleri(0)
            If _kategoriSutunIndeksleri.Count > 1 Then _altKategori1Index = _kategoriSutunIndeksleri(1)
            If _kategoriSutunIndeksleri.Count > 2 Then _altKategori2Index = _kategoriSutunIndeksleri(2)
            If _kategoriSutunIndeksleri.Count > 3 Then _altKategori3Index = _kategoriSutunIndeksleri(3)
            If _kategoriSutunIndeksleri.Count > 4 Then _altKategori4Index = _kategoriSutunIndeksleri(4)
            If _kategoriSutunIndeksleri.Count > 5 Then _altKategori5Index = _kategoriSutunIndeksleri(5)
            
            _yuklemeLog.Add($"Manuel sütun atama: Barkod={_barkodSutunIndex}, ModelKodu={_urunKoduSutunIndex}, Marka={_markaSutunIndex}")
            _yuklemeLog.Add($"Sabit Ana Kategori: '{_sabitAnaKategori}'")
            _yuklemeLog.Add($"Kategori sütunları (sıralı): {String.Join(", ", _kategoriSutunIndeksleri)}")
            _yuklemeLog.Add($"Kategori sütun isimleri: {String.Join(", ", _kategoriSutunIsimleri)}")
            
            Using fs As New FileStream(dosyaYolu, FileMode.Open, FileAccess.Read, FileShare.ReadWrite)
                Dim workbook As IWorkbook
                
                If Path.GetExtension(dosyaYolu).ToLower() = ".xlsx" Then
                    workbook = New XSSFWorkbook(fs)
                Else
                    workbook = New HSSFWorkbook(fs)
                End If
                
                Dim sheet As ISheet = workbook.GetSheetAt(0)
                Dim headerRow As IRow = sheet.GetRow(0)
                
                If headerRow Is Nothing Then
                    _yuklemeLog.Add("HATA: Başlık satırı boş!")
                    Return False
                End If
                
                ' Sütunları ekle
                For i As Integer = 0 To headerRow.LastCellNum - 1
                    Dim cell As ICell = headerRow.GetCell(i)
                    Dim columnName As String = If(cell IsNot Nothing, GetCellValue(cell).Trim(), $"Column{i}")
                    _excelData.Columns.Add(columnName)
                Next
                
                ' Veri satırlarını oku
                For rowIndex As Integer = 1 To sheet.LastRowNum
                    Dim row As IRow = sheet.GetRow(rowIndex)
                    If row Is Nothing Then Continue For
                    
                    Dim dataRow As DataRow = _excelData.NewRow()
                    For colIndex As Integer = 0 To headerRow.LastCellNum - 1
                        Dim cell As ICell = row.GetCell(colIndex)
                        dataRow(colIndex) = If(cell IsNot Nothing, GetCellValue(cell), "")
                    Next
                    _excelData.Rows.Add(dataRow)
                Next
                
                _yuklemeLog.Add($"Toplam {_excelData.Rows.Count} satır yüklendi")
                workbook.Close()
            End Using
            
            Return True
            
        Catch ex As Exception
            _yuklemeLog.Add($"HATA: {ex.Message}")
            Return False
        End Try
    End Function
    
    ''' <summary>
    ''' Hücre değerini string olarak alır
    ''' </summary>
    Private Function GetCellValue(cell As ICell) As String
        If cell Is Nothing Then Return ""
        
        Select Case cell.CellType
            Case CellType.String
                Return cell.StringCellValue
            Case CellType.Numeric
                ' Barkod için tam sayı formatı
                If Math.Floor(cell.NumericCellValue) = cell.NumericCellValue Then
                    Return CLng(cell.NumericCellValue).ToString()
                Else
                    Return cell.NumericCellValue.ToString()
                End If
            Case CellType.Boolean
                Return cell.BooleanCellValue.ToString()
            Case CellType.Formula
                Try
                    Return cell.StringCellValue
                Catch
                    Try
                        Return cell.NumericCellValue.ToString()
                    Catch
                        Return ""
                    End Try
                End Try
            Case Else
                Return ""
        End Select
    End Function
    
    ''' <summary>
    ''' Barkod ile kategori arar
    ''' </summary>
    Public Function BarkodIleAra(barkod As String) As TrendyolScraperSonuc
        Dim sonuc As New TrendyolScraperSonuc()
        sonuc.Barkod = barkod
        sonuc.Basarili = False
        
        _aramaLog = New List(Of String)()
        _aramaLog.Add($"Aranan barkod: '{barkod}'")
        
        Try
            If _excelData Is Nothing OrElse _excelData.Rows.Count = 0 Then
                sonuc.HataMesaji = "Excel dosyası yüklenmemiş"
                _aramaLog.Add($"HATA: {sonuc.HataMesaji}")
                Return sonuc
            End If
            
            If _barkodSutunIndex < 0 Then
                sonuc.HataMesaji = "Barkod sütunu bulunamadı"
                _aramaLog.Add($"HATA: {sonuc.HataMesaji}")
                Return sonuc
            End If
            
            ' Kategori sütunları kontrolü
            _aramaLog.Add($"Sütun indeksleri: Barkod={_barkodSutunIndex}, Marka={_markaSutunIndex}, Kategori sütunları={String.Join(",", _kategoriSutunIndeksleri)}")
            _aramaLog.Add($"Sabit Ana Kategori: '{_sabitAnaKategori}'")
            _aramaLog.Add($"Kategori sütun isimleri: {String.Join(", ", _kategoriSutunIsimleri)}")
            
            ' Barkodu normalize et
            Dim normalizedBarkod As String = NormalizeBarkod(barkod)
            _aramaLog.Add($"Normalized barkod: '{normalizedBarkod}'")
            _aramaLog.Add($"Excel'de {_excelData.Rows.Count} satır taranacak...")
            
            Dim tarananSatir As Integer = 0
            
            ' Excel'de ara
            For Each row As DataRow In _excelData.Rows
                Dim excelBarkod As String = NormalizeBarkod(row(_barkodSutunIndex).ToString())
                tarananSatir += 1
                
                ' İlk 5 satırı logla (debug için)
                If tarananSatir <= 5 Then
                    _aramaLog.Add($"  Satır {tarananSatir}: Excel='{excelBarkod}' vs Aranan='{normalizedBarkod}'")
                End If
                
                If excelBarkod = normalizedBarkod Then
                    _aramaLog.Add($"EŞLEŞME BULUNDU! Satır: {tarananSatir}")
                    
                    ' Eşleşme bulundu - kategorileri al
                    Dim kategoriler As New List(Of String)
                    
                    ' YENİ: Sabit ana kategori kontrolü - seçilen sütunlarda zaten var mı?
                    Dim sabitKategoriEklenecek As Boolean = False
                    If Not String.IsNullOrEmpty(_sabitAnaKategori) Then
                        sabitKategoriEklenecek = True
                        ' Kategori sütun isimlerinde sabit kategori var mı kontrol et
                        For Each katIsim As String In _kategoriSutunIsimleri
                            If katIsim.Trim().ToLowerInvariant() = _sabitAnaKategori.ToLowerInvariant() Then
                                sabitKategoriEklenecek = False
                                _aramaLog.Add($"  Sabit kategori '{_sabitAnaKategori}' sütunlarda zaten var, eklenmeyecek")
                                Exit For
                            End If
                        Next
                        
                        If sabitKategoriEklenecek Then
                            kategoriler.Add(_sabitAnaKategori)
                            _aramaLog.Add($"  Sabit Ana Kategori eklendi: '{_sabitAnaKategori}'")
                        End If
                    End If
                    
                    ' SONRA: Trendyol_KategoriYolu sütununu kontrol et (tek sütunda "/" ile ayrılmış)
                    If _trendyolKategoriYoluIndex >= 0 Then
                        Dim kategoriYolu As String = row(_trendyolKategoriYoluIndex).ToString().Trim()
                        _aramaLog.Add($"  Trendyol_KategoriYolu: '{kategoriYolu}'")
                        
                        If Not String.IsNullOrEmpty(kategoriYolu) Then
                            ' "/" veya " > " ile ayrılmış kategorileri parse et
                            Dim ayirac As String() = {" / ", "/", " > ", ">"}
                            Dim parcalar As String() = kategoriYolu.Split(ayirac, StringSplitOptions.RemoveEmptyEntries)
                            For Each parca As String In parcalar
                                Dim temizParca As String = parca.Trim()
                                ' TEKRAR KONTROLÜ: Aynı kategori zaten eklenmişse atla
                                If Not String.IsNullOrEmpty(temizParca) AndAlso Not kategoriler.Contains(temizParca) Then
                                    kategoriler.Add(temizParca)
                                End If
                            Next
                            _aramaLog.Add($"  Parse edilen kategori sayısı: {kategoriler.Count}")
                        End If
                    End If
                    
                    ' SONRA: Manuel seçilen kategori sütunlarını SIRASIYLA al
                    If kategoriler.Count <= 1 AndAlso _kategoriSutunIndeksleri.Count > 0 Then
                        ' Sıralı kategori sütunlarını ekle
                        For Each colIdx As Integer In _kategoriSutunIndeksleri
                            If colIdx >= 0 AndAlso colIdx < _excelData.Columns.Count Then
                                Dim deger As String = row(colIdx).ToString().Trim()
                                ' TEKRAR KONTROLÜ: Aynı kategori zaten eklenmişse atla
                                If Not String.IsNullOrEmpty(deger) AndAlso Not kategoriler.Contains(deger) Then
                                    kategoriler.Add(deger)
                                    _aramaLog.Add($"  Kategori sütunu [{colIdx}]: '{deger}'")
                                End If
                            End If
                        Next
                    End If
                    
                    ' Eski yöntemle de dene (geriye uyumluluk)
                    If kategoriler.Count <= 1 Then
                        If _anaKategoriIndex >= 0 AndAlso Not String.IsNullOrEmpty(row(_anaKategoriIndex).ToString().Trim()) Then
                            Dim deger As String = row(_anaKategoriIndex).ToString().Trim()
                            If Not kategoriler.Contains(deger) Then
                                kategoriler.Add(deger)
                                _aramaLog.Add($"  AnaKategori: '{deger}'")
                            End If
                        End If
                        
                        If _altKategori1Index >= 0 AndAlso Not String.IsNullOrEmpty(row(_altKategori1Index).ToString().Trim()) Then
                            kategoriler.Add(row(_altKategori1Index).ToString().Trim())
                        End If
                        
                        If _altKategori2Index >= 0 AndAlso Not String.IsNullOrEmpty(row(_altKategori2Index).ToString().Trim()) Then
                            kategoriler.Add(row(_altKategori2Index).ToString().Trim())
                        End If
                        
                        If _altKategori3Index >= 0 AndAlso Not String.IsNullOrEmpty(row(_altKategori3Index).ToString().Trim()) Then
                            kategoriler.Add(row(_altKategori3Index).ToString().Trim())
                        End If
                        
                        If _altKategori4Index >= 0 AndAlso Not String.IsNullOrEmpty(row(_altKategori4Index).ToString().Trim()) Then
                            kategoriler.Add(row(_altKategori4Index).ToString().Trim())
                        End If
                        
                        If _altKategori5Index >= 0 AndAlso Not String.IsNullOrEmpty(row(_altKategori5Index).ToString().Trim()) Then
                            kategoriler.Add(row(_altKategori5Index).ToString().Trim())
                        End If
                    End If
                    
                    _aramaLog.Add($"Toplam {kategoriler.Count} kategori bulundu")
                    
                    ' YENİ: Marka sütununu al (varsa)
                    Dim marka As String = ""
                    If _markaSutunIndex >= 0 AndAlso _markaSutunIndex < _excelData.Columns.Count Then
                        marka = row(_markaSutunIndex).ToString().Trim()
                        _aramaLog.Add($"  Marka sütunundan alındı: '{marka}'")
                    End If
                    
                    If kategoriler.Count > 0 Then
                        sonuc.Basarili = True
                        sonuc.Kategoriler = kategoriler
                        sonuc.KategoriYolu = String.Join(" / ", kategoriler)
                        sonuc.Skor = 1.0
                        sonuc.Not_ = "Excel eşleşmesi (barkod)"
                        
                        ' YENİ: Marka bilgisini sonuca ekle
                        If Not String.IsNullOrEmpty(marka) Then
                            sonuc.Not_ &= $", Marka: {marka}"
                        End If
                        
                        Return sonuc
                    Else
                        _aramaLog.Add("UYARI: Eşleşme bulundu ama kategori sütunları boş!")
                    End If
                End If
            Next
            
            _aramaLog.Add($"Toplam {tarananSatir} satır tarandı, eşleşme bulunamadı")
            sonuc.HataMesaji = "Excel'de barkod bulunamadı"
            
        Catch ex As Exception
            sonuc.HataMesaji = "Excel okuma hatası: " & ex.Message
            _aramaLog.Add($"HATA: {ex.Message}")
        End Try
        
        Return sonuc
    End Function
    
    ''' <summary>
    ''' Model kodu ile kategori arar (URUNKODU sütununda LIKE araması)
    ''' sModel = "USB2342" ise, URUNKODU "USB2342%" ile başlayan satırları bulur
    ''' </summary>
    Public Function ModelKoduIleAra(sModel As String) As TrendyolScraperSonuc
        Dim sonuc As New TrendyolScraperSonuc()
        sonuc.Barkod = sModel
        sonuc.Basarili = False
        
        _aramaLog = New List(Of String)()
        _aramaLog.Add($"Model kodu ile aranıyor: '{sModel}'")
        
        Try
            If _excelData Is Nothing OrElse _excelData.Rows.Count = 0 Then
                sonuc.HataMesaji = "Excel dosyası yüklenmemiş"
                _aramaLog.Add($"HATA: {sonuc.HataMesaji}")
                Return sonuc
            End If
            
            If _urunKoduSutunIndex < 0 Then
                sonuc.HataMesaji = "URUNKODU sütunu bulunamadı"
                _aramaLog.Add($"HATA: {sonuc.HataMesaji}")
                Return sonuc
            End If
            
            ' Model kodunu normalize et
            Dim normalizedModel As String = sModel.Trim().ToUpper()
            _aramaLog.Add($"Normalized model: '{normalizedModel}'")
            _aramaLog.Add($"URUNKODU sütun index: {_urunKoduSutunIndex}")
            _aramaLog.Add($"Marka sütun index: {_markaSutunIndex}")
            _aramaLog.Add($"Sabit Ana Kategori: '{_sabitAnaKategori}'")
            _aramaLog.Add($"Kategori sütun isimleri: {String.Join(", ", _kategoriSutunIsimleri)}")
            
            Dim tarananSatir As Integer = 0
            
            ' Excel'de ara - URUNKODU sütununda model kodu ile başlayan satırları bul
            For Each row As DataRow In _excelData.Rows
                Dim excelUrunKodu As String = row(_urunKoduSutunIndex).ToString().Trim().ToUpper()
                tarananSatir += 1
                
                ' Model kodu ile başlıyor mu? (LIKE 'USB2342%' gibi)
                If excelUrunKodu.StartsWith(normalizedModel) Then
                    _aramaLog.Add($"MODEL EŞLEŞME BULUNDU! Satır: {tarananSatir}, URUNKODU: {excelUrunKodu}")
                    
                    ' Eşleşme bulundu - kategorileri al
                    Dim kategoriler As New List(Of String)
                    
                    ' YENİ: Sabit ana kategori kontrolü - seçilen sütunlarda zaten var mı?
                    Dim sabitKategoriEklenecek As Boolean = False
                    If Not String.IsNullOrEmpty(_sabitAnaKategori) Then
                        sabitKategoriEklenecek = True
                        ' Kategori sütun isimlerinde sabit kategori var mı kontrol et
                        For Each katIsim As String In _kategoriSutunIsimleri
                            If katIsim.Trim().ToLowerInvariant() = _sabitAnaKategori.ToLowerInvariant() Then
                                sabitKategoriEklenecek = False
                                _aramaLog.Add($"  Sabit kategori '{_sabitAnaKategori}' sütunlarda zaten var, eklenmeyecek")
                                Exit For
                            End If
                        Next
                        
                        If sabitKategoriEklenecek Then
                            kategoriler.Add(_sabitAnaKategori)
                            _aramaLog.Add($"  Sabit Ana Kategori eklendi: '{_sabitAnaKategori}'")
                        End If
                    End If
                    
                    ' SONRA: Trendyol_KategoriYolu sütununu kontrol et
                    If _trendyolKategoriYoluIndex >= 0 Then
                        Dim kategoriYolu As String = row(_trendyolKategoriYoluIndex).ToString().Trim()
                        _aramaLog.Add($"  Trendyol_KategoriYolu: '{kategoriYolu}'")
                        
                        If Not String.IsNullOrEmpty(kategoriYolu) Then
                            Dim ayirac As String() = {" / ", "/", " > ", ">"}
                            Dim parcalar As String() = kategoriYolu.Split(ayirac, StringSplitOptions.RemoveEmptyEntries)
                            For Each parca As String In parcalar
                                Dim temizParca As String = parca.Trim()
                                ' TEKRAR KONTROLÜ: Aynı kategori zaten eklenmişse atla
                                If Not String.IsNullOrEmpty(temizParca) AndAlso Not kategoriler.Contains(temizParca) Then
                                    kategoriler.Add(temizParca)
                                End If
                            Next
                        End If
                    End If
                    
                    ' SONRA: Manuel seçilen kategori sütunlarını SIRASIYLA al
                    If kategoriler.Count <= 1 AndAlso _kategoriSutunIndeksleri.Count > 0 Then
                        For Each colIdx As Integer In _kategoriSutunIndeksleri
                            If colIdx >= 0 AndAlso colIdx < _excelData.Columns.Count Then
                                Dim deger As String = row(colIdx).ToString().Trim()
                                ' TEKRAR KONTROLÜ: Aynı kategori zaten eklenmişse atla
                                If Not String.IsNullOrEmpty(deger) AndAlso Not kategoriler.Contains(deger) Then
                                    kategoriler.Add(deger)
                                    _aramaLog.Add($"  Kategori sütunu [{colIdx}]: '{deger}'")
                                End If
                            End If
                        Next
                    End If
                    
                    ' Eski yöntemle de dene (geriye uyumluluk)
                    If kategoriler.Count <= 1 Then
                        If _anaKategoriIndex >= 0 AndAlso Not String.IsNullOrEmpty(row(_anaKategoriIndex).ToString().Trim()) Then
                            Dim deger As String = row(_anaKategoriIndex).ToString().Trim()
                            If Not kategoriler.Contains(deger) Then
                                kategoriler.Add(deger)
                            End If
                        End If
                        
                        If _altKategori1Index >= 0 AndAlso Not String.IsNullOrEmpty(row(_altKategori1Index).ToString().Trim()) Then
                            Dim deger As String = row(_altKategori1Index).ToString().Trim()
                            If Not kategoriler.Contains(deger) Then kategoriler.Add(deger)
                        End If
                        
                        If _altKategori2Index >= 0 AndAlso Not String.IsNullOrEmpty(row(_altKategori2Index).ToString().Trim()) Then
                            Dim deger As String = row(_altKategori2Index).ToString().Trim()
                            If Not kategoriler.Contains(deger) Then kategoriler.Add(deger)
                        End If
                        
                        If _altKategori3Index >= 0 AndAlso Not String.IsNullOrEmpty(row(_altKategori3Index).ToString().Trim()) Then
                            Dim deger As String = row(_altKategori3Index).ToString().Trim()
                            If Not kategoriler.Contains(deger) Then kategoriler.Add(deger)
                        End If
                        
                        If _altKategori4Index >= 0 AndAlso Not String.IsNullOrEmpty(row(_altKategori4Index).ToString().Trim()) Then
                            Dim deger As String = row(_altKategori4Index).ToString().Trim()
                            If Not kategoriler.Contains(deger) Then kategoriler.Add(deger)
                        End If
                        
                        If _altKategori5Index >= 0 AndAlso Not String.IsNullOrEmpty(row(_altKategori5Index).ToString().Trim()) Then
                            Dim deger As String = row(_altKategori5Index).ToString().Trim()
                            If Not kategoriler.Contains(deger) Then kategoriler.Add(deger)
                        End If
                    End If
                    
                    _aramaLog.Add($"Toplam {kategoriler.Count} kategori bulundu")
                    
                    ' YENİ: Marka sütununu al (varsa)
                    Dim marka As String = ""
                    If _markaSutunIndex >= 0 AndAlso _markaSutunIndex < _excelData.Columns.Count Then
                        marka = row(_markaSutunIndex).ToString().Trim()
                        _aramaLog.Add($"  Marka sütunundan alındı: '{marka}'")
                    End If
                    
                    If kategoriler.Count > 0 Then
                        sonuc.Basarili = True
                        sonuc.Kategoriler = kategoriler
                        sonuc.KategoriYolu = String.Join(" / ", kategoriler)
                        sonuc.Skor = 0.9  ' Model eşleşmesi için biraz düşük skor
                        sonuc.Not_ = $"Excel model eşleşmesi (URUNKODU: {excelUrunKodu})"
                        
                        ' YENİ: Marka bilgisini sonuca ekle
                        If Not String.IsNullOrEmpty(marka) Then
                            sonuc.Not_ &= $", Marka: {marka}"
                        End If
                        
                        Return sonuc
                    Else
                        _aramaLog.Add("UYARI: Eşleşme bulundu ama kategori sütunları boş!")
                    End If
                End If
            Next
            
            _aramaLog.Add($"Toplam {tarananSatir} satır tarandı, model eşleşmesi bulunamadı")
            sonuc.HataMesaji = "Excel'de model kodu bulunamadı"
            
        Catch ex As Exception
            sonuc.HataMesaji = "Excel okuma hatası: " & ex.Message
            _aramaLog.Add($"HATA: {ex.Message}")
        End Try
        
        Return sonuc
    End Function
    
    ''' <summary>
    ''' Barkodu normalize eder
    ''' </summary>
    Private Function NormalizeBarkod(barkod As String) As String
        If String.IsNullOrEmpty(barkod) Then Return ""
        barkod = barkod.Trim().Replace(" ", "")
        ' .0 ile bitiyorsa kaldır (Excel bazen sayıları böyle gösterir)
        If barkod.EndsWith(".0") Then
            barkod = barkod.Substring(0, barkod.Length - 2)
        End If
        Return barkod
    End Function
    
    ''' <summary>
    ''' Yüklü kayıt sayısını döndürür
    ''' </summary>
    Public ReadOnly Property KayitSayisi As Integer
        Get
            If _excelData Is Nothing Then Return 0
            Return _excelData.Rows.Count
        End Get
    End Property
    
    ''' <summary>
    ''' Dosya yolunu döndürür
    ''' </summary>
    Public ReadOnly Property DosyaYolu As String
        Get
            Return _dosyaYolu
        End Get
    End Property
    
    ''' <summary>
    ''' Yükleme loglarını döndürür
    ''' </summary>
    Public ReadOnly Property YuklemeLog As List(Of String)
        Get
            Return _yuklemeLog
        End Get
    End Property
    
    ''' <summary>
    ''' Arama loglarını döndürür
    ''' </summary>
    Public ReadOnly Property AramaLog As List(Of String)
        Get
            Return _aramaLog
        End Get
    End Property
    
End Class
