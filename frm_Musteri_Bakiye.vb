Imports System
Imports System.Drawing
Imports System.Collections
Imports System.Windows.Forms
Imports System.Data
Imports System.Data.SqlClient
Public Class frm_Musteri_Bakiye
    Public sConnection As String = ""
    Public FirmaNo As Integer
    Public DonemNo As Integer
    Public sKullanici As String = ""
    Public sKodu As String = ""
    Public nAlisVerisID As String = ""
    Dim dataset1 As DataSet
    Dim dataset2 As DataSet
    Dim loaded As Boolean = False
    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Me.Close()
    End Sub
    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Me.Close()
    End Sub
    Private Sub ara(ByVal nMusteriID As String, Optional ByVal bAylik As Boolean = False)
        Dim kriter As String = ""
        Dim kriter2 As String = ""
        Dim query As String = ""
        Dim query2 As String = ""
        If bAylik = False Then
            query = ("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT * FROM (SELECT tbMusteri.nMusteriID AS FIRMANO , tbMusteri.lKodu AS FIRMAKODU , ISNULL(SUM(tbTaksit.lTutari) , 0) AS TUTAR , ISNULL(SUM(tbOdeme.odeme) , 0) AS TAHSILAT , ISNULL(ISNULL(SUM(tbTaksit.lTutari) , 0) - ISNULL(SUM(tbOdeme.odeme) , 0) , 0) AS KALAN , YEAR(tbTaksit.dteTarihi) as sYil,tbTaksit.dteTarihi, ROUND(CAST(GETDATE() - (CAST(tbTaksit.dteTarihi AS INT) + 1) AS FLOAT), 0) AS GECIKME FROM (SELECT isnull(SUM(lOdemeTutar) , 0) AS odeme , nTaksitId FROM tbOdeme GROUP BY nTaksitId) tbOdeme RIGHT OUTER JOIN tbTaksit INNER JOIN tbAlisVeris ON tbTaksit.nAlisverisID = tbAlisVeris.nAlisverisID INNER JOIN tbMusteri ON tbAlisVeris.nMusteriID = tbMusteri.nMusteriID ON tbOdeme.nTaksitId = tbTaksit.nTaksitID WHERE (tbMusteri.nMusteriID = " & nMusteriID & " and tbTaksit.nAlisVerisID <> '" & nAlisVerisID & "') GROUP BY tbMusteri.nMusteriID , tbMusteri.lKodu , tbTaksit.dteTarihi) DERIVEDTBL WHERE (KALAN <> 0) ORDER BY dteTarihi")
        ElseIf bAylik = True Then
            'query = ("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT * FROM (SELECT tbMusteri.nMusteriID AS FIRMANO , tbMusteri.lKodu AS FIRMAKODU , ISNULL(SUM(tbTaksit.lTutari) , 0) AS TUTAR , ISNULL(SUM(tbOdeme.odeme) , 0) AS TAHSILAT , ISNULL(ISNULL(SUM(tbTaksit.lTutari) , 0) - ISNULL(SUM(tbOdeme.odeme) , 0) , 0) AS KALAN , MONTH(tbTaksit.dteTarihi) dteTarihi, ROUND(CAST(GETDATE() - (CAST(tbTaksit.dteTarihi AS INT) + 1) AS FLOAT), 0) AS GECIKME FROM (SELECT isnull(SUM(lOdemeTutar) , 0) AS odeme , nTaksitId FROM tbOdeme GROUP BY nTaksitId) tbOdeme RIGHT OUTER JOIN tbTaksit INNER JOIN tbAlisVeris ON tbTaksit.nAlisverisID = tbAlisVeris.nAlisverisID INNER JOIN tbMusteri ON tbAlisVeris.nMusteriID = tbMusteri.nMusteriID ON tbOdeme.nTaksitId = tbTaksit.nTaksitID WHERE (tbMusteri.nMusteriID = " & nMusteriID & ") GROUP BY tbMusteri.nMusteriID , tbMusteri.lKodu , MONTH(tbTaksit.dteTarihi)) DERIVEDTBL WHERE (KALAN <> 0) ORDER BY MONTH(tbTaksit.dteTarihi)")
            query = ("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT * FROM (SELECT tbMusteri.nMusteriID AS FIRMANO , tbMusteri.lKodu AS FIRMAKODU , ISNULL(SUM(tbTaksit.lTutari) , 0) AS TUTAR , ISNULL(SUM(tbOdeme.odeme) , 0) AS TAHSILAT , ISNULL(ISNULL(SUM(tbTaksit.lTutari) , 0) - ISNULL(SUM(tbOdeme.odeme) , 0) , 0) AS KALAN , YEAR(tbTaksit.dteTarihi) sYil,MONTH(tbTaksit.dteTarihi) dteTarihi, 0 AS GECIKME FROM (SELECT isnull(SUM(lOdemeTutar) , 0) AS odeme , nTaksitId FROM tbOdeme GROUP BY nTaksitId) tbOdeme RIGHT OUTER JOIN tbTaksit INNER JOIN tbAlisVeris ON tbTaksit.nAlisverisID = tbAlisVeris.nAlisverisID INNER JOIN tbMusteri ON tbAlisVeris.nMusteriID = tbMusteri.nMusteriID ON tbOdeme.nTaksitId = tbTaksit.nTaksitID WHERE (tbMusteri.nMusteriID = " & nMusteriID & ") and tbTaksit.nAlisVerisID <> '" & nAlisVerisID & "' GROUP BY tbMusteri.nMusteriID , tbMusteri.lKodu , YEAR(tbTaksit.dteTarihi),MONTH(tbTaksit.dteTarihi)) DERIVEDTBL WHERE (KALAN <> 0) ORDER BY sYil,dteTarihi")
        End If
        'query2 = ("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT dateadd(day, CASE SUM(lBorcTutar) WHEN 0 THEN 0 ELSE round(SUM(Datediff(day, tbTempMinTarih.MinTarih, dteValorTarihi) * tbFirmaHareketi.lBorcTutar) / SUM(lBorcTutar), 0) END, MIN(dteValorTarihi)) AS dteVadeBorc, dateadd(day, CASE SUM(lAlacakTutar) WHEN 0 THEN 0 ELSE round(SUM(Datediff(day, tbTempMinTarih.MinTarih, dteValorTarihi) * tbFirmaHareketi.lAlacakTutar) / SUM(lAlacakTutar), 0) END, MIN(dteValorTarihi)) AS dteVadeAlacak, datediff(day, dateadd(day, CASE SUM(lBorctutar) WHEN 0 THEN 0 ELSE round(SUM(Datediff(day, tbTempMinTarih.MinTarih, dteValorTarihi) * tbFirmaHareketi.lBorcTutar) / SUM(lBorcTutar), 0) END, MIN(dteValorTarihi)), dateadd(day, CASE SUM(lAlacakTutar) WHEN 0 THEN 0 ELSE round(SUM(Datediff(day, tbTempMinTarih.MinTarih, dteValorTarihi) * tbFirmaHareketi.lAlacakTutar) / SUM(lAlacakTutar), 0) END, MIN(dteValorTarihi))) AS nGun, MAX(tbFirma.nVadeGun) AS nValor FROM tbFirma, tbFirmaHareketi FULL JOIN (SELECT MIN(dteValorTarihi) AS MinTarih, tbFirmaHareketi.nFirmaID FROM tbFirmaHareketi GROUP BY tbFirmaHareketi.nFirmaID) AS tbTempMinTarih ON tbFirmaHareketi.nFirmaID = tbTempMinTarih.nFirmaID WHERE tbFirma.sKodu = '" & sKodu & "' AND tbFirma.nFirmaID = tbFirmaHareketi.nFirmaID")
        dataset1 = sorgu(query)
        'dataset2 = sorgu(query2)
        Try
            Dim dr As DataRow
            Dim lBakiye As Decimal = 0
            Dim lGeciken As Decimal = 0
            Dim gecikmistaksitsayisi As Integer = 0
            Dim sayi As Integer = 0
            For Each dr In dataset1.Tables(0).Rows
                sayi += 1
                lBakiye += dr("KALAN")
                If bAylik = False Then
                    If dr("dteTarihi") < Today Then
                        gecikmistaksitsayisi += 1
                        lGeciken += dr("KALAN")
                    End If
                ElseIf bAylik = True Then
                    If dr("dteTarihi") < Now.Month Then
                        gecikmistaksitsayisi += 1
                        lGeciken += dr("KALAN")
                    End If
                End If
            Next
            lbl_Geciken.Text = lGeciken
            lbl_Bakiye.Text = lBakiye
            If lGeciken > 0 Then
                lbl_Geciken_Taksit.Text = gecikmistaksitsayisi
                lbl_Geciken_Tutar.Text = Format(sayi, "#,0.##")
                'BarButtonItem21.Caption = "Geciken Taksit: " & gecikmistaksitsayisi & " Geciken Tutar: " & FormatNumber(lGeciken, 2)
            Else
                lbl_Geciken_Taksit.Text = 0
                lbl_Geciken_Tutar.Text = 0
                'BarButtonItem21.Caption = ""
            End If
            lBakiye = Nothing
            lGeciken = Nothing
            gecikmistaksitsayisi = Nothing
        Catch ex As Exception
        End Try
        dg.DataSource = dataset1.Tables(0)
    End Sub
    Private Function sorgu(ByVal query As String) As DataSet
        Dim cmd As New OleDb.OleDbCommand
        Dim adapter As New OleDb.OleDbDataAdapter
        'Dim conn As SqlConnection = New SqlConnection("Data Source=192.168.2.6,1433;Initial Catalog=BUSINESS;User ID=sa")
        Dim conn As New OleDb.OleDbConnection
        conn.ConnectionString = connection
        adapter.SelectCommand = cmd
        cmd.CommandText = query
        cmd.Connection = conn
        cmd.CommandTimeout = False
        If conn.State = ConnectionState.Closed Then
            conn.Open()
        End If
        Dim DS As New DataSet
        Dim N As Integer = adapter.Fill(DS, "TABLE1")
        conn.Close()
        Return DS
        cmd = Nothing
        conn = Nothing
        adapter = Nothing
    End Function
    Private Sub frm_Cari_Bakiye_Closing(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles MyBase.Closing
        Timer1.Enabled = False
        Timer1.Dispose()
    End Sub
    Private Sub frm_Cari_Bakiye_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
        ara(sKodu, False)
        loaded = True
    End Sub
    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        lbl_Saat.Text = Now.ToLongTimeString
        lbl_baslik.Text = "Müşteri Bakiye Analizi"
    End Sub
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        If Button1.Text = "Aylık" Then
            ara(sKodu, True)
            Button1.Text = "Yıllık"
        ElseIf Button1.Text = "Yıllık" Then
            ara(sKodu, True)
            Button1.Text = "Günlük"
        ElseIf Button1.Text = "Günlük" Then
            ara(sKodu, False)
            Button1.Text = "Aylık"
        End If
    End Sub
End Class