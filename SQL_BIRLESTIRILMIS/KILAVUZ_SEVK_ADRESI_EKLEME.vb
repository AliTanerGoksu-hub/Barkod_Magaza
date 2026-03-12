' ============================================================================
' SEVK ADRESİ EKLEME KILAVUZU - frm_fatura.vb
' ============================================================================
' Tarih: 2025-01-28
' Açıklama: Belge yazdır/önizle kısmına sevk adresi ekleme talimatları
' ============================================================================

' ============================================================================
' ADIM 1: Değişken Tanımlama (Satır ~7225 civarı)
' ============================================================================
' Mevcut:
'     Dim sorgu_txt_kesinti As String = ""
'
' Sonrasına ekle:
'     Dim sorgu_txt_adres As String = ""

' ============================================================================
' ADIM 2: Adres Sorgulama Fonksiyonu Ekle (Herhangi bir yere)
' ============================================================================
' Yeni fonksiyon ekle:

    Private Function sorgu_tbStokFisiPesinAdres(ByVal nStokFisiID As Integer) As DataSet
        Dim cmd As New OleDb.OleDbCommand
        Dim con As New OleDb.OleDbConnection
        Dim adapter As New OleDb.OleDbDataAdapter
        con.ConnectionString = connection
        cmd.CommandTimeout = Nothing
        adapter.SelectCommand = cmd
        cmd.CommandText = sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT * FROM tbStokFisiPesinAdres WHERE nStokFisiID = " & nStokFisiID & " ")
        sorgu_txt_adres = cmd.CommandText
        cmd.Connection = con
        con.Open()
        Dim DS As New DataSet
        Dim N As Integer = adapter.Fill(DS, "tbStokFisiAdres")
        con.Close()
        con.Dispose()
        cmd.Dispose()
        con = Nothing
        cmd = Nothing
        Return DS
    End Function

' ============================================================================
' ADIM 3: report_create_stok Fonksiyonunda qr_adres Ekle (32-bit kısmı)
' ============================================================================
' Satır ~19733 civarında, mevcut:
'     Dim qr_toplam As New TfrxADOQuery
'
' Sonrasına ekle:
'     Dim qr_adres As New TfrxADOQuery

' ============================================================================
' ADIM 4: qr_adres Query Ataması (32-bit kısmı)
' ============================================================================
' qr_toplam.Query = sorgu_txt_toplam satırından SONRA ekle:
'
'     Try
'         qr_adres = frx.FindObject("qr_adres")
'         qr_adres.Query = sorgu_txt_adres
'     Catch ex As Exception
'     End Try

' ============================================================================
' ADIM 5: qr_adres DataBase Bağlantısı (32-bit kısmı)
' ============================================================================
' qr_toplam.DataBase = qr_connection satırından SONRA ekle:
'
'     Try
'         qr_adres.DataBase = qr_connection
'     Catch ex As Exception
'     End Try

' ============================================================================
' ADIM 6: 64-bit kısmında query string'e adres ekle
' ============================================================================
' args(3) satırını güncelle:
' Mevcut:
'     args(3) = "qr_baslikéqr_hareketéqr_hareket_modeléqr_toplam"
'
' Yeni:
'     args(3) = "qr_baslikéqr_hareketéqr_hareket_modeléqr_toplaméqr_adres"

' ============================================================================
' ADIM 7: 64-bit kısmında sorgu string'e adres sorgusu ekle
' ============================================================================
' args(2) satırını güncelle - sonuna adres sorgusunu ekle:
' 
' Mevcut args(2) sonuna "é" & sorgu_txt_adres ekle

' ============================================================================
' ADIM 8: Belge yazdırmadan önce adres sorgusunu çağır
' ============================================================================
' report_create_stok çağrılmadan önce, belge_ac_stok veya benzeri fonksiyonda
' sorgu_tbStokFisiPesinAdres(nStokFisiID) fonksiyonunu çağır

' Örnek:
'     Dim ds_adres As DataSet = sorgu_tbStokFisiPesinAdres(nStokFisiID)
'     report_create_stok(dosya, kriter, status)

' ============================================================================
' FASTREPOR'TA YAPILACAKLAR
' ============================================================================
' 1. FastReport Designer'da rapor dosyasını aç (.frx veya .fr3)
' 2. Yeni bir TfrxADOQuery komponenti ekle, adını "qr_adres" yap
' 3. Bu query'ye bağlı alanları rapora ekle:
'    - sAciklama (Alıcı Adı)
'    - sAdres1 (Adres Satır 1)
'    - sAdres2 (Adres Satır 2)
'    - sSemt (Semt)
'    - sIl (İl)
'    - sPostaKodu (Posta Kodu)
'    - sTelefon (Telefon)
'    - sVergiDairesi
'    - sVergiNo

' ============================================================================
' tbStokFisiPesinAdres TABLO YAPISI
' ============================================================================
' nStokFisiID    - Stok Fişi ID (Foreign Key)
' sAciklama      - Alıcı/Firma Adı
' sAdres1        - Adres Satır 1
' sAdres2        - Adres Satır 2
' sSemt          - Semt/İlçe
' sIl            - Şehir
' sUlke          - Ülke
' sPostaKodu     - Posta Kodu
' sVergiDairesi  - Vergi Dairesi
' sVergiNo       - Vergi/TC No
' sTelefon       - Telefon
' sSubeMagaza    - Şube/Mağaza

' ============================================================================
' ÖRNEK SQL SORGUSU
' ============================================================================
' SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED 
' SELECT * FROM tbStokFisiPesinAdres WHERE nStokFisiID = 12345

' ============================================================================
' NOT: frm_tbSiparis.vb'de tbSiparisPesinAdres tablosu kullanılıyor
'      frm_fatura.vb'de tbStokFisiPesinAdres tablosu kullanılmalı
'      (Sipariş ve Fatura farklı tablolar kullanıyor)
' ============================================================================
