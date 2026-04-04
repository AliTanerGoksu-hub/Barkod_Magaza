' ============================================================================
' RISK BILDIRIM MODULU
' ============================================================================
' Tum satis/siparis/odeme formlarindan cagrilabilir
' Sessiz bildirim - tiklaninca detay gosterir
' ============================================================================

Imports System.Windows.Forms
Imports System.Drawing

Public Module RiskBildirimModulu

    ''' <summary>
    ''' Firma bazli risk kontrolu yapar, sessiz bildirim paneli ekler
    ''' </summary>
    ''' <param name="frm">Panel eklenecek form</param>
    ''' <param name="connectionString">DB connection string</param>
    ''' <param name="nFirmaID">Firma numeric ID (toptan icin)</param>
    ''' <param name="nMusteriID">Musteri numeric ID (perakende icin)</param>
    ''' <param name="sorguQueryFunc">sorgu_query fonksiyonu delegesi</param>
    Public Sub RiskKontrolEkle(frm As Form, connectionString As String, nFirmaID As Long, nMusteriID As Long, sorguQueryFunc As Func(Of String, String))
        Try
            If nFirmaID <= 0 AndAlso nMusteriID <= 0 Then Exit Sub

            ' Ayar kontrolu
            Dim sRiskAktif As String = "0"
            Try
                Dim conA As New OleDb.OleDbConnection
                conA.ConnectionString = connectionString
                conA.Open()
                Dim cmdA As New OleDb.OleDbCommand
                cmdA.Connection = conA
                If nFirmaID > 0 Then
                    cmdA.CommandText = sorguQueryFunc("SELECT ISNULL(sAyarDeger,'0') FROM tbSistemAyar WHERE sAyarKodu='RISK_SKORU_AKTIF'")
                Else
                    cmdA.CommandText = sorguQueryFunc("SELECT ISNULL(sAyarDeger,'0') FROM tbSistemAyar WHERE sAyarKodu='PERAKENDE_RISK_AKTIF'")
                End If
                Try : sRiskAktif = cmdA.ExecuteScalar().ToString() : Catch : End Try
                conA.Close()
            Catch : End Try
            If sRiskAktif <> "1" Then Exit Sub

            Dim skor As Integer = 100
            Dim detayMetin As String = ""

            If nFirmaID > 0 Then
                ' === TOPTAN RISK KONTROLU ===
                Dim con As New OleDb.OleDbConnection
                con.ConnectionString = connectionString
                con.Open()
                Dim cmd As New OleDb.OleDbCommand
                cmd.Connection = con

                cmd.CommandText = sorguQueryFunc("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT " &
                    "ISNULL(SUM(lBorcTutar - lAlacakTutar), 0) AS Bakiye, " &
                    "ISNULL(SUM(CASE WHEN lBorcTutar > 0 AND dteValorTarihi < GETDATE() THEN lBorcTutar - lAlacakTutar ELSE 0 END), 0) AS VadesiGecmis, " &
                    "ISNULL(MAX(CASE WHEN lBorcTutar > 0 AND dteValorTarihi < GETDATE() THEN DATEDIFF(DAY, dteValorTarihi, GETDATE()) ELSE 0 END), 0) AS MaxGecikmeGun " &
                    "FROM tbFirmaHareketi WHERE nFirmaID=" & nFirmaID)
                Dim dr As OleDb.OleDbDataReader = cmd.ExecuteReader()
                Dim bakiye As Decimal = 0, vadesiGecmis As Decimal = 0, maxGecikme As Integer = 0
                If dr.Read() Then
                    bakiye = CDec(dr("Bakiye"))
                    vadesiGecmis = CDec(dr("VadesiGecmis"))
                    maxGecikme = CInt(dr("MaxGecikmeGun"))
                End If
                dr.Close()
                ' Vadesi gecmis, toplam bakiyeyi asamaz (odemeler dusulur)
                If bakiye > 0 AndAlso vadesiGecmis > bakiye Then vadesiGecmis = bakiye

                cmd.CommandText = sorguQueryFunc("SELECT ISNULL(lKrediLimiti,0) FROM tbFirma WHERE nFirmaID=" & nFirmaID)
                Dim krediLimiti As Decimal = 0
                Try : krediLimiti = CDec(cmd.ExecuteScalar()) : Catch : End Try

                cmd.CommandText = sorguQueryFunc("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED " &
                    "SELECT ISNULL(COUNT(DISTINCT lSiparisNo),0) AS Adet, ISNULL(SUM(lTutari),0) AS Tutar " &
                    "FROM tbSiparis WHERE nFirmaID=" & nFirmaID & " AND ISNULL(bKapandimi,0)=0")
                Dim drSip As OleDb.OleDbDataReader = cmd.ExecuteReader()
                Dim bekAdet As Integer = 0, bekTutar As Decimal = 0
                If drSip.Read() Then
                    bekAdet = CInt(drSip("Adet")) : bekTutar = CDec(drSip("Tutar"))
                End If
                drSip.Close()

                ' Ortalama vade hesabi
                Dim anlasmaVade As Integer = 0
                Dim fiiliOrtVade As Decimal = 0
                Try
                    cmd.CommandText = sorguQueryFunc("SELECT ISNULL(nVadeGun, 0) FROM tbFirma WHERE nFirmaID = " & nFirmaID)
                    anlasmaVade = CInt(cmd.ExecuteScalar())
                Catch : End Try
                Try
                    cmd.CommandText = sorguQueryFunc("SELECT ISNULL(AVG(DATEDIFF('d', dteIslemTarihi, dteValorTarihi)), 0) FROM tbFirmaHareketi WHERE nFirmaID = " & nFirmaID & " AND lBorcTutar > 0 AND dteIslemTarihi >= DATEADD('m', -12, Now())")
                    fiiliOrtVade = CDec(cmd.ExecuteScalar())
                Catch : End Try

                ' Cek/Senet riski
                Dim cekVadesiGecmis As Decimal = 0
                Dim cekKarsilisiksiz As Decimal = 0
                Dim cekKarsilisiksizAdet As Integer = 0
                Try
                    cmd.CommandText = sorguQueryFunc("SELECT " &
                        "ISNULL(SUM(IIF(c.nSonCekSenetIslem IN (1,2) AND c.dteVadeTarihi < Now(), c.lTutar, 0)), 0) AS VadesiGecmisCek, " &
                        "ISNULL(SUM(IIF(c.nSonCekSenetIslem = 6, c.lTutar, 0)), 0) AS KarsilisiksizTutar, " &
                        "ISNULL(SUM(IIF(c.nSonCekSenetIslem = 6, 1, 0)), 0) AS KarsilisiksizAdet " &
                        "FROM tbCekSenet c INNER JOIN tbCekSenetBordro b ON c.nCekSenetID = b.nCekSenetID " &
                        "WHERE b.nFirmaID = " & nFirmaID & " AND c.sCekSenetTipi IN ('AC','AS') AND b.nBordroSatirID = c.nSonBordroSatirID")
                    Dim drCek As OleDb.OleDbDataReader = cmd.ExecuteReader()
                    If drCek.Read() Then
                        cekVadesiGecmis = CDec(drCek("VadesiGecmisCek"))
                        cekKarsilisiksiz = CDec(drCek("KarsilisiksizTutar"))
                        cekKarsilisiksizAdet = CInt(drCek("KarsilisiksizAdet"))
                    End If
                    drCek.Close()
                Catch : End Try
                con.Close()

                ' Skor hesapla
                If maxGecikme > 90 Then
                    skor -= 40
                ElseIf maxGecikme > 60 Then
                    skor -= 30
                ElseIf maxGecikme > 30 Then
                    skor -= 20
                ElseIf maxGecikme > 0 Then
                    skor -= 10
                End If
                ' Ortalama vade skor etkisi
                If anlasmaVade > 0 AndAlso fiiliOrtVade > anlasmaVade * 1.5 Then
                    skor -= 15
                ElseIf anlasmaVade > 0 AndAlso fiiliOrtVade > anlasmaVade Then
                    skor -= 10
                End If
                ' Cek/Senet skor etkisi
                If cekKarsilisiksizAdet > 0 Then skor -= 25
                If cekVadesiGecmis > 0 Then skor -= 15
                If bakiye > 0 AndAlso vadesiGecmis > 0 Then
                    If vadesiGecmis / bakiye > 0.5D Then skor -= 15
                End If
                If krediLimiti > 0 Then
                    Dim topYuk As Decimal = bakiye + bekTutar
                    If topYuk > krediLimiti Then
                        skor -= 20
                    ElseIf topYuk / krediLimiti > 0.9D Then
                        skor -= 15
                    End If
                End If
                skor = Math.Max(0, Math.Min(100, skor))

                detayMetin = "Risk: " & skor & "/100" & vbCrLf
                detayMetin &= "Bakiye: " & bakiye.ToString("N2") & " TL" & vbCrLf
                If vadesiGecmis > 0 Then detayMetin &= "Vadesi Gecmis: " & vadesiGecmis.ToString("N2") & " TL (" & maxGecikme & " gun)" & vbCrLf
                If krediLimiti > 0 Then detayMetin &= "Limit Kullanim: %" & Math.Round(bakiye / krediLimiti * 100, 0) & vbCrLf
                If bekAdet > 0 Then detayMetin &= "Bekleyen Siparis: " & bekAdet & " adet" & vbCrLf
                detayMetin &= "Ort. Vade: " & CInt(fiiliOrtVade) & " gun (Anlasma: " & anlasmaVade & " gun)" & vbCrLf
                If cekVadesiGecmis > 0 Then detayMetin &= "Vadesi Gecmis Cek/Senet: " & cekVadesiGecmis.ToString("N2") & " TL" & vbCrLf
                If cekKarsilisiksizAdet > 0 Then detayMetin &= "KARSILIKIZSIZ CEK: " & cekKarsilisiksiz.ToString("N2") & " TL (" & cekKarsilisiksizAdet & " adet)" & vbCrLf

            ElseIf nMusteriID > 0 Then
                ' === PERAKENDE RISK KONTROLU ===
                Dim con As New OleDb.OleDbConnection
                con.ConnectionString = connectionString
                con.Open()
                Dim cmd As New OleDb.OleDbCommand
                cmd.Connection = con

                cmd.CommandText = sorguQueryFunc("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED " &
                    "SELECT ISNULL(k.lKrediLimiti,0) AS KrediLimiti, " &
                    "ISNULL((SELECT SUM(t.lTutari - ISNULL(o.Odenen,0)) FROM tbTaksit t " &
                    "INNER JOIN tbAlisVeris a ON t.nAlisverisID = a.nAlisverisID " &
                    "LEFT JOIN (SELECT nTaksitId, SUM(lOdemeTutar) AS Odenen FROM tbOdeme GROUP BY nTaksitId) o ON t.nTaksitID = o.nTaksitId " &
                    "WHERE a.nMusteriID=" & nMusteriID & " AND (t.lTutari - ISNULL(o.Odenen,0)) > 0),0) AS ToplamBorc, " &
                    "ISNULL((SELECT SUM(t.lTutari - ISNULL(o.Odenen,0)) FROM tbTaksit t " &
                    "INNER JOIN tbAlisVeris a ON t.nAlisverisID = a.nAlisverisID " &
                    "LEFT JOIN (SELECT nTaksitId, SUM(lOdemeTutar) AS Odenen FROM tbOdeme GROUP BY nTaksitId) o ON t.nTaksitID = o.nTaksitId " &
                    "WHERE a.nMusteriID=" & nMusteriID & " AND t.dteTarihi < GETDATE() AND (t.lTutari - ISNULL(o.Odenen,0)) > 0),0) AS VadesiGecmis, " &
                    "ISNULL((SELECT MAX(DATEDIFF(DAY, t.dteTarihi, GETDATE())) FROM tbTaksit t " &
                    "INNER JOIN tbAlisVeris a ON t.nAlisverisID = a.nAlisverisID " &
                    "LEFT JOIN (SELECT nTaksitId, SUM(lOdemeTutar) AS Odenen FROM tbOdeme GROUP BY nTaksitId) o ON t.nTaksitID = o.nTaksitId " &
                    "WHERE a.nMusteriID=" & nMusteriID & " AND t.dteTarihi < GETDATE() AND (t.lTutari - ISNULL(o.Odenen,0)) > 0),0) AS MaxGecikme " &
                    "FROM tbMusteriKredisi k WHERE k.nMusteriID=" & nMusteriID)
                Dim drP As OleDb.OleDbDataReader = cmd.ExecuteReader()
                Dim pKrediLimiti As Decimal = 0, pToplamBorc As Decimal = 0
                Dim pVadesiGecmis As Decimal = 0, pMaxGecikme As Integer = 0
                If drP.Read() Then
                    pKrediLimiti = CDec(drP("KrediLimiti"))
                    pToplamBorc = CDec(drP("ToplamBorc"))
                    pVadesiGecmis = CDec(drP("VadesiGecmis"))
                    pMaxGecikme = CInt(drP("MaxGecikme"))
                End If
                drP.Close()
                con.Close()
                ' Vadesi gecmis, toplam borcu asamaz
                If pToplamBorc > 0 AndAlso pVadesiGecmis > pToplamBorc Then pVadesiGecmis = pToplamBorc

                If pMaxGecikme > 90 Then
                    skor -= 40
                ElseIf pMaxGecikme > 60 Then
                    skor -= 30
                ElseIf pMaxGecikme > 30 Then
                    skor -= 20
                ElseIf pMaxGecikme > 0 Then
                    skor -= 10
                End If
                If pKrediLimiti > 0 AndAlso pToplamBorc > pKrediLimiti Then skor -= 20
                skor = Math.Max(0, Math.Min(100, skor))

                detayMetin = "Risk: " & skor & "/100" & vbCrLf
                detayMetin &= "Toplam Borc: " & pToplamBorc.ToString("N2") & " TL" & vbCrLf
                If pVadesiGecmis > 0 Then detayMetin &= "Vadesi Gecmis: " & pVadesiGecmis.ToString("N2") & " TL (" & pMaxGecikme & " gun)" & vbCrLf
                If pKrediLimiti > 0 Then detayMetin &= "Kredi Limiti: " & pKrediLimiti.ToString("N2") & " TL"
            End If

            If skor >= 70 Then Exit Sub ' Guvenli - gosterme

            ' Panel olustur
            Dim seviye As String = If(skor >= 40, "DIKKAT", "KRITIK")
            Dim renk As Color = If(skor >= 40, Color.FromArgb(243, 156, 18), Color.FromArgb(231, 76, 60))
            Dim panelMetin As String = If(seviye = "KRITIK", "Onemli bilgi (tikla)", "Bilgi mevcut (tikla)")

            Dim pnl As New Panel()
            pnl.Dock = DockStyle.Bottom
            pnl.Height = 22
            pnl.BackColor = renk
            pnl.Padding = New Padding(6, 2, 6, 2)
            pnl.Cursor = Cursors.Hand

            Dim lbl As New Label()
            lbl.AutoSize = True
            lbl.Font = New Font("Segoe UI", 8, FontStyle.Regular)
            lbl.ForeColor = Color.White
            lbl.Location = New Point(6, 3)
            lbl.Text = panelMetin
            lbl.Cursor = Cursors.Hand

            Dim capturedDetay As String = detayMetin
            AddHandler pnl.Click, Sub()
                                      MessageBox.Show(capturedDetay, "Risk Detayi", MessageBoxButtons.OK, MessageBoxIcon.Information)
                                  End Sub
            AddHandler lbl.Click, Sub()
                                      MessageBox.Show(capturedDetay, "Risk Detayi", MessageBoxButtons.OK, MessageBoxIcon.Information)
                                  End Sub

            pnl.Controls.Add(lbl)
            frm.Controls.Add(pnl)
            pnl.BringToFront()

        Catch ex As Exception
            ' Risk kontrolu basarisiz olsa bile formu engelleme
        End Try
    End Sub
End Module
