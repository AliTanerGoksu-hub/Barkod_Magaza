Imports System.IO
Imports business_smart.brkdutil
Imports DevExpress.XtraEditors
Imports System.Xml
Public Class frm_tbKarpin_Aktarim
    Public firmano
    Public donemno
    Public connection
    Public kullanici
    Dim ds4 As DataSet 'hareket
    Dim ds5 As DataSet 'stoklar
    Dim ds6 As DataSet 'cariler
    Dim ds7 As DataSet 'vega_stoklar
    Dim ds8 As DataSet 'uyum satislar
    Dim ds_alislar_kdv As DataSet 'KdvSat˝rlar˝
    Private Sub SimpleButton3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SimpleButton3.Click
        'satis_oku_vega_DOS_direkt()
        Dim SaveFileDialog1 As New Windows.Forms.OpenFileDialog
        SaveFileDialog1.Filter = "XML Dosyalar˝(*.XML) |*.XML"
        SaveFileDialog1.InitialDirectory = "D:\Basis\"
        SaveFileDialog1.FileName = "SATIS.XML"
        If SaveFileDialog1.ShowDialog = Windows.Forms.DialogResult.OK Then
            Try
                xml_oku(SaveFileDialog1.FileName.ToString)
            Catch ex As Exception
                XtraMessageBox.Show("Dosya Format˝ Uygun Deil...!" & vbCrLf & ex.Message.ToString, "Dikkat")
            End Try
        End If
        DataSet2 = query_FAT_BASLIK("SATFAT")
        GridControl1.DataSource = DataSet2.Tables(0)
        GridView1.ExpandAllGroups()
        GridView2.ExpandAllGroups()
    End Sub
    Private Sub xml_oku(ByVal sFile As String)
        Dim reader As XmlTextReader = New XmlTextReader(sFile)
        Dim s As String = ""
        Dim sSatir As String = ""
        Dim nDeger As String = ""
        Dim dr As DataRow
        Dim lIskontoTutari As Decimal = 0
        Dim nIskontoYuzdesi As Decimal = 0
        Dim dteFisTarihi As DateTime = Today
        Dim lFisNo As String = ""
        Dim sFisTipi As String = ""
        Dim nGirisCikis As Integer = 3
        Dim sFirmaKodu As String = ""
        Dim sFirmaAdi As String = ""
        Dim sVergiDairesi As String = ""
        Dim sVergiNo As String = ""
        Dim lNetTutar As Decimal = 0
        Dim lKdvTutari As Decimal = 0
        Dim sDepoKodu As String = ""
        Dim sUrunKodu As String = "999999"
        Dim sUrunAciklama As String = "Hizmet Bedeli"
        Dim sSaticiRumuzu As String = ""
        Dim cmd As New OleDb.OleDbCommand
        Dim con As New OleDb.OleDbConnection
        con.ConnectionString = connection
        con.Open()
        cmd.Connection = con
        cmd.CommandText = "TRUNCATE TABLE BTBLSATIS"
        cmd.ExecuteNonQuery()
        con.Close()
        Dim sayi As Integer = 10000
        Bar1.Position = 0
        Bar1.Properties.Maximum = sayi
        Bar1.Refresh()
        Dim dlg As New WaitDlgFrm("Toplam Sat˝r :" & sayi)
        Do While (reader.Read())
            Select Case reader.NodeType
                Case XmlNodeType.Element 'Display beginning of element.
                    'Console.Write("<" + reader.Name)
                    If reader.HasAttributes Then 'If attributes exist
                        While reader.MoveToNextAttribute()
                            'Display attribute name and value.
                            'Console.Write(" {0}='{1}'", reader.Name, reader.Value)
                        End While
                    End If
                    'Console.WriteLine(">")
                    sSatir = reader.Name
                    If reader.Name = "FIS" Or reader.Name = "FATURA" Then
                        dr = DataSet1.Tables(0).NewRow
                    End If
                Case XmlNodeType.Text 'Display the text in each element.
                    'Console.WriteLine(reader.Value)
                    nDeger = reader.Value
                    'Listview1.Items.Add(sSatir & "=" & nDeger)
                    If nDeger = "FISTIPI" Then
                    End If
                    If sSatir = "FISTIPI" Then
                        If nDeger = "ALIS" Then
                            dr("FISTIPI") = "FA"
                            sFisTipi = "FA"
                            dr("GIRISCIKIS") = 1
                            nGirisCikis = 1
                        ElseIf nDeger = "SATIS" Then
                            dr("FISTIPI") = "FS"
                            sFisTipi = "FS"
                            dr("GIRISCIKIS") = 3
                            nGirisCikis = 3
                        ElseIf nDeger = "ALIS IADE" Then
                            dr("FISTIPI") = "FS"
                            sFisTipi = "FS"
                            dr("GIRISCIKIS") = 4
                            nGirisCikis = 4
                        End If
                    End If
                    If sSatir = "TUR" Then
                        If nDeger = "ALIS IADE" Then
                            dr("FISTIPI") = "HA"
                            sFisTipi = "HA"
                            dr("GIRISCIKIS") = 1
                            nGirisCikis = 1
                        End If
                    End If
                    If sSatir = "FISNO" Then
                        If sFisTipi = "FS" Then
                            dr("BELGENO") = Microsoft.VisualBasic.Right(nDeger, 9)
                            lFisNo = Microsoft.VisualBasic.Right(nDeger, 9)
                        ElseIf sFisTipi = "FA" Then
                            dr("BELGENO") = Microsoft.VisualBasic.Right(nDeger, 8)
                            lFisNo = Microsoft.VisualBasic.Right(nDeger, 8)
                        ElseIf sFisTipi = "HA" Then
                            dr("BELGENO") = Microsoft.VisualBasic.Right(nDeger, 8)
                            lFisNo = Microsoft.VisualBasic.Right(nDeger, 8)
                        End If

                    End If
                    If sSatir = "FATURANO" Then
                        dr("BELGENO") = Microsoft.VisualBasic.Right(nDeger, 8)
                        lFisNo = Microsoft.VisualBasic.Right(nDeger, 8)
                    End If
                    If sSatir = "TARIH" Then
                        dr("TARIH") = nDeger
                        dteFisTarihi = nDeger
                    End If
                    If sSatir = "MUSKODU" Then
                        dr("FIRMAKODU") = nDeger
                        sFirmaKodu = nDeger
                    End If
                    If sSatir = "CARIKODU" Then
                        dr("FIRMAKODU") = nDeger
                        sFirmaKodu = nDeger
                    End If
                    If sSatir = "MUSADI" Then
                        nDeger = Replace(nDeger, "'", " ")
                        nDeger = Replace(nDeger, ",", " ")
                        dr("FIRMAADI") = nDeger
                        sFirmaAdi = nDeger
                    End If
                    If sSatir = "VERGIDAIRESI" Then
                        dr("VERGIDAIRESI") = nDeger
                        sVergiDairesi = nDeger
                    End If
                    If sSatir = "VERGINO" Then
                        dr("VERGINO") = nDeger
                        sVergiNo = nDeger
                    End If
                    If sSatir = "DEPOKODU" Then
                        dr("DEPOKODU") = nDeger
                        sDepoKodu = nDeger
                    End If
                    If sSatir = "TOPLAMKDV" Then
                        dr("KDVTUTAR") = nDeger
                        lKdvTutari = nDeger
                    End If
                    If sSatir = "STKODU" Then
                        dr("KOD") = "00" & nDeger
                        sSaticiRumuzu = "00" & nDeger
                    End If
                    If sSatir = "URUNKODU" Then
                        dr("STOKKODU") = nDeger
                        sUrunKodu = nDeger
                    End If
                    If sSatir = "URUNADI" Then
                        nDeger = Replace(nDeger, "'", " ")
                        nDeger = Replace(nDeger, ",", " ")
                        dr("STOKADI") = nDeger
                        sUrunAciklama = nDeger
                    End If
                    If sSatir = "BIRIM" Then
                        dr("BIRIM") = nDeger
                    End If
                    If sSatir = "MIKTAR" Then
                        If nGirisCikis = 2 Or nGirisCikis = 4 Then
                            dr("MIKTAR") = -nDeger
                            dr("KOLIICI") = 1
                            dr("TOPLAMMIKTAR") = -nDeger
                        ElseIf nGirisCikis = 1 Or nGirisCikis = 3 Then
                            dr("MIKTAR") = nDeger
                            dr("KOLIICI") = 1
                            dr("TOPLAMMIKTAR") = nDeger
                        End If

                    End If
                    If sSatir = "BIRIMFIYAT" Then
                        dr("FIYAT") = nDeger
                    End If
                    If sSatir = "FIYAT" Then
                        If nGirisCikis = 2 Or nGirisCikis = 4 Then
                            dr("TUTAR") = -nDeger
                        ElseIf nGirisCikis = 1 Or nGirisCikis = 3 Then
                            dr("TUTAR") = nDeger
                        End If
                    End If
                    If sSatir = "KDV" Then
                        dr("KDV") = nDeger
                    End If
                    If sSatir = "TUTAR" Then
                        dr("ISKONTOTUTAR") += nDeger
                    End If
                    If sSatir = "TOPLAMNET" Then
                        If nGirisCikis = 1 Or nGirisCikis = 3 Then
                            dr("GENELTOPLAM") = nDeger
                            lNetTutar = nDeger
                        ElseIf nGirisCikis = 2 Or nGirisCikis = 4 Then
                            dr("GENELTOPLAM") = -nDeger
                            lNetTutar = -nDeger
                        End If

                    End If
                Case XmlNodeType.EndElement 'Display end of element.
                    'Console.Write("</" + reader.Name)
                    'Listview1.Items.Add(reader.Name & "=" & reader.Value)
                    'Console.WriteLine(">")
                    If reader.Name = "KALEM" Then
                        'simge
                        sFirmaKodu = sFirmaKodu.Replace("7488926", "7482082")
                        sFirmaKodu = sFirmaKodu.Replace("7488927", "7482082")
                        sFirmaKodu = sFirmaKodu.Replace("7489218", "7482082")
                        sFirmaKodu = sFirmaKodu.Replace("7483812", "7482082")
                        sFirmaKodu = sFirmaKodu.Replace("7484646", "7482082")
                        sFirmaKodu = sFirmaKodu.Replace("7484718", "7482082")
                        sFirmaKodu = sFirmaKodu.Replace("7484797", "7482082")
                        'Hatay Birlik
                        sFirmaKodu = sFirmaKodu.Replace("7488983", "7483357")
                        sFirmaKodu = sFirmaKodu.Replace("7488103", "7483357")
                        sFirmaKodu = sFirmaKodu.Replace("7483787", "7483357")
                        sFirmaKodu = sFirmaKodu.Replace("7484701", "7483357")
                        sFirmaKodu = sFirmaKodu.Replace("7488874", "7483357")
                        sFirmaKodu = sFirmaKodu.Replace("7488875", "7483357")
                        sFirmaKodu = sFirmaKodu.Replace("7488876", "7483357")
                        sFirmaKodu = sFirmaKodu.Replace("7488872", "7483357")
                        sFirmaKodu = sFirmaKodu.Replace("7488877", "7483357")
                        '˛ok
                        sFirmaKodu = sFirmaKodu.Replace("8031465", "320-01-0000")
                        sFirmaKodu = sFirmaKodu.Replace("7484600", "320-01-0000")
                        sFirmaKodu = sFirmaKodu.Replace("8031168", "320-01-0000")
                        sFirmaKodu = sFirmaKodu.Replace("8031299", "320-01-0000")
                        sFirmaKodu = sFirmaKodu.Replace("78824", "320-01-0000")
                        sFirmaKodu = sFirmaKodu.Replace("78257", "320-01-0000")
                        sFirmaKodu = sFirmaKodu.Replace("8031283", "320-01-0000")
                        sFirmaKodu = sFirmaKodu.Replace("78256", "320-01-0000")
                        sFirmaKodu = sFirmaKodu.Replace("7484519", "320-01-0000")
                        sFirmaKodu = sFirmaKodu.Replace("78255", "320-01-0000")
                        sFirmaKodu = sFirmaKodu.Replace("76668", "320-01-0000")
                        sFirmaKodu = sFirmaKodu.Replace("76922", "320-01-0000")
                        sFirmaKodu = sFirmaKodu.Replace("79020", "320-01-0000")
                        sFirmaKodu = sFirmaKodu.Replace("7484747", "320-01-0000")
                        dr("TARIH") = dteFisTarihi
                        If nGirisCikis = 4 Then
                            lFisNo = sFirmaKodu
                        End If
                        dr("BELGENO") = lFisNo
                        dr("FISTIPI") = sFisTipi
                        dr("GIRISCIKIS") = nGirisCikis
                        dr("FIRMAKODU") = sFirmaKodu
                        dr("FIRMAADI") = sFirmaAdi
                        dr("VERGIDAIRESI") = sVergiDairesi
                        dr("VERGINO") = sVergiNo
                        dr("KOD") = sSaticiRumuzu
                        dr("DEPONO") = 1
                        dr("DEPOKODU") = sDepoKodu
                        dr("GENELTOPLAM") = lNetTutar
                        dr("KDVTUTAR") = lKdvTutari
                        dr("KDVTUTAR") = ((sorgu_sayi(Math.Abs(dr("TUTAR")), 0) - sorgu_sayi(dr("ISKONTOTUTAR"), 0)) * dr("KDV")) / 100
                        If nGirisCikis = 2 Or nGirisCikis = 4 Then
                            dr("KDVTUTAR") = -dr("KDVTUTAR")
                        End If
                        dr("PARABIRIMI") = "TL"
                        dr("ADRES") = ""
                        dr("TELEFON") = ""
                        dr("ISKONTO") = sorgu_sayi(dr("ISKONTO"), 0)
                        dr("ISKONTOTUTAR") = sorgu_sayi(dr("ISKONTOTUTAR"), 0)
                        If nGirisCikis = 2 Or nGirisCikis = 4 Then
                            dr("ISKONTOTUTAR") = -dr("ISKONTOTUTAR")
                        End If
                        dr("STOKKODU") = sUrunKodu
                        dr("STOKADI") = sUrunAciklama
                        Try
                            dr("ISKONTO") = Format((dr("ISKONTOTUTAR") / dr("TUTAR")) * 100, "#,0.00#")
                        Catch ex As Exception
                            dr("ISKONTO") = 0
                        End Try
                        dr("GENELTOPLAM") = (dr("TUTAR") - dr("ISKONTOTUTAR")) + dr("KDVTUTAR")
                        DataSet1.Tables(0).Rows.Add(dr)
                        aktar_veritabani(dr("TARIH"), dr("FIRMAKODU").ToString, dr("FIRMAADI").ToString, dr("FISTIPI").ToString, sorgu_sayi(dr("GIRISCIKIS"), 3), dr("BELGENO").ToString, dr("STOKKODU").ToString, dr("STOKADI").ToString, "KL", dr("MIKTAR"), dr("KOLIICI"), dr("TOPLAMMIKTAR"), dr("FIYAT"), dr("TUTAR"), dr("KDV"), dr("ISKONTO"), dr("ISKONTOTUTAR"), dr("KDVTUTAR"), dr("GENELTOPLAM"), dr("KOD").ToString, dr("VERGIDAIRESI"), dr("VERGINO").ToString, "", "")
                        dr = DataSet1.Tables(0).NewRow
                        Bar1.Position += 1
                        bar1_text.Text = "S " + (Bar1.Position).ToString
                        Bar1.Refresh()
                        bar1_text.Refresh()
                    End If
            End Select
        Loop
        Bar1.Position = 0
        Bar1.Refresh()
        dlg.Close()
        reader.Close()
        reader = Nothing
        SimpleButton5.Enabled = True
        'Console.ReadLine()
    End Sub
    Private Sub xml_tahsilat_oku(ByVal sFile As String)
        Dim reader As XmlTextReader = New XmlTextReader(sFile)
        Dim s As String = ""
        Dim sSatir As String = ""
        Dim nDeger As String = ""
        Dim dr As DataRow
        Dim lIskontoTutari As Decimal = 0
        Dim nIskontoYuzdesi As Decimal = 0
        Dim dteFisTarihi As DateTime = Today
        Dim lFisNo As String = ""
        Dim sFisTipi As String = ""
        Dim nGirisCikis As Integer = 3
        Dim sFirmaKodu As String = ""
        Dim sFirmaAdi As String = ""
        Dim sVergiDairesi As String = ""
        Dim sVergiNo As String = ""
        Dim lNetTutar As Decimal = 0
        Dim lKdvTutari As Decimal = 0
        Dim sDepoKodu As String = ""
        Dim sUrunKodu As String = "999999"
        Dim sUrunAciklama As String = "Hizmet Bedeli"
        Dim sSaticiRumuzu As String = ""
        Dim cmd As New OleDb.OleDbCommand
        Dim con As New OleDb.OleDbConnection
        con.ConnectionString = connection
        con.Open()
        cmd.Connection = con
        cmd.CommandText = "TRUNCATE TABLE BTBLSATIS"
        cmd.ExecuteNonQuery()
        con.Close()
        Dim sayi As Integer = 10000
        Bar1.Position = 0
        Bar1.Properties.Maximum = sayi
        Bar1.Refresh()
        Dim dlg As New WaitDlgFrm("Toplam Sat˝r :" & sayi)
        Do While (reader.Read())
            Select Case reader.NodeType
                Case XmlNodeType.Element 'Display beginning of element.
                    'Console.Write("<" + reader.Name)
                    If reader.HasAttributes Then 'If attributes exist
                        While reader.MoveToNextAttribute()
                            'Display attribute name and value.
                            'Console.Write(" {0}='{1}'", reader.Name, reader.Value)
                        End While
                    End If
                    'Console.WriteLine(">")
                    sSatir = reader.Name
                    If reader.Name = "NAKITTAHSILATLAR" Or reader.Name = "BANKAHAVALELERI" Or reader.Name = "KREDIKARTLARI" Or reader.Name = "CEKSENET" Then
                        dr = ds_Tahsilat.Tables(0).NewRow
                    End If
                    If reader.Name = "NAKITTAHSILATLAR" Then
                        dr("FISTIPI") = "N"
                        sFisTipi = "N"
                    ElseIf reader.Name = "BANKAHAVALELERI" Then
                        dr("FISTIPI") = "HVL"
                        sFisTipi = "HVL"
                    ElseIf reader.Name = "KREDIKARTLARI" Then
                        dr("FISTIPI") = "KK"
                        sFisTipi = "KK"
                    ElseIf reader.Name = "CEKSENET" Then
                        dr("FISTIPI") = "AC"
                        sFisTipi = "AC"
                    End If
                Case XmlNodeType.Text 'Display the text in each element.
                    'Console.WriteLine(reader.Value)
                    nDeger = reader.Value
                    'Listview1.Items.Add(sSatir & "=" & nDeger)
                    If nDeger = "FISTIPI" Then
                    End If

                    If sSatir = "TUR" Then
                        If nDeger = "CEK" Then
                            dr("FISTIPI") = "AC"
                            sFisTipi = "AC"
                        ElseIf nDeger = "SENET" Then
                            dr("FISTIPI") = "AS"
                            sFisTipi = "AS"
                        End If
                    End If


                    If sSatir = "TARIH" Then
                        dr("TARIH") = nDeger
                        dteFisTarihi = nDeger
                    End If
                    If sSatir = "CARIKODU" Then
                        dr("FIRMAKODU") = nDeger
                        sFirmaKodu = nDeger
                    End If
                    If sSatir = "STKODU" Then
                        dr("SATICI") = "00" & nDeger
                        sSaticiRumuzu = "00" & nDeger
                    End If
                    If sSatir = "ACIKLAMA" Then
                        dr("ACIKLAMA") = nDeger
                    End If
                    If sSatir = "BANKA" Then
                        dr("BANKA") = nDeger
                    End If
                    If sSatir = "SUBE" Then
                        dr("SUBE") = nDeger
                    End If
                    If sSatir = "BORCLU" Then
                        dr("BORCLU") = nDeger
                    End If
                    If sSatir = "VALORTARIHI" Or sSatir = "VADETARIHI" Then
                        dr("VALORTARIHI") = nDeger
                    End If
                    If sSatir = "TUTAR" Then
                        dr("TUTAR") = nDeger
                    End If
                    If sSatir = "NO" Then
                        dr("ACIKLAMA") = nDeger
                    End If
                    If sSatir = "HESAPNO" Then
                        dr("HESAPNO") = nDeger
                    End If

                Case XmlNodeType.EndElement 'Display end of element.
                    'Console.Write("</" + reader.Name)
                    'Listview1.Items.Add(reader.Name & "=" & reader.Value)
                    'Console.WriteLine(">")
                    If reader.Name = "KREDIKARTI" Or reader.Name = "NAKITTAHSILAT" Or reader.Name = "BANKAHAVALE" Or reader.Name = "CEKSENET" Then
                        'simge
                        sFirmaKodu = sFirmaKodu.Replace("7488926", "7482082")
                        sFirmaKodu = sFirmaKodu.Replace("7488927", "7482082")
                        sFirmaKodu = sFirmaKodu.Replace("7489218", "7482082")
                        sFirmaKodu = sFirmaKodu.Replace("7483812", "7482082")
                        sFirmaKodu = sFirmaKodu.Replace("7484646", "7482082")
                        sFirmaKodu = sFirmaKodu.Replace("7484718", "7482082")
                        sFirmaKodu = sFirmaKodu.Replace("7484797", "7482082")
                        'Hatay Birlik
                        sFirmaKodu = sFirmaKodu.Replace("7488983", "7483357")
                        sFirmaKodu = sFirmaKodu.Replace("7488103", "7483357")
                        sFirmaKodu = sFirmaKodu.Replace("7483787", "7483357")
                        sFirmaKodu = sFirmaKodu.Replace("7484701", "7483357")
                        sFirmaKodu = sFirmaKodu.Replace("7488874", "7483357")
                        sFirmaKodu = sFirmaKodu.Replace("7488875", "7483357")
                        sFirmaKodu = sFirmaKodu.Replace("7488876", "7483357")
                        sFirmaKodu = sFirmaKodu.Replace("7488872", "7483357")
                        sFirmaKodu = sFirmaKodu.Replace("7488877", "7483357")
                        '˛ok
                        sFirmaKodu = sFirmaKodu.Replace("8031465", "320-01-0000")
                        sFirmaKodu = sFirmaKodu.Replace("7484600", "320-01-0000")
                        sFirmaKodu = sFirmaKodu.Replace("8031168", "320-01-0000")
                        sFirmaKodu = sFirmaKodu.Replace("8031299", "320-01-0000")
                        sFirmaKodu = sFirmaKodu.Replace("78824", "320-01-0000")
                        sFirmaKodu = sFirmaKodu.Replace("78257", "320-01-0000")
                        sFirmaKodu = sFirmaKodu.Replace("8031283", "320-01-0000")
                        sFirmaKodu = sFirmaKodu.Replace("78256", "320-01-0000")
                        sFirmaKodu = sFirmaKodu.Replace("7484519", "320-01-0000")
                        sFirmaKodu = sFirmaKodu.Replace("78255", "320-01-0000")
                        sFirmaKodu = sFirmaKodu.Replace("76668", "320-01-0000")
                        sFirmaKodu = sFirmaKodu.Replace("76922", "320-01-0000")
                        sFirmaKodu = sFirmaKodu.Replace("79020", "320-01-0000")
                        sFirmaKodu = sFirmaKodu.Replace("7484747", "320-01-0000")
                        dr("TARIH") = dteFisTarihi
                        dr("BELGENO") = dteFisTarihi.Day
                        dr("FISTIPI") = sFisTipi
                        dr("FIRMAKODU") = sFirmaKodu
                        dr("FIRMAADI") = sorgula_String("SET DATEFORMAT DMY SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT     ISNULL(sAciklama,'') FROM         tbFirma WHERE     (sKodu = '" & sFirmaKodu & "')")
                        dr("SATICI") = sSaticiRumuzu
                        dr("DEPO") = sDepo
                        If sFisTipi = "AC" Or sFisTipi = "AS" Then
                            dr("ACIKLAMA") = Microsoft.VisualBasic.Left(dr("BANKA").ToString & "\" & dr("SUBE").ToString & "\" & dr("VALORTARIHI") & "\" & dr("ACIKLAMA"), 60)
                        ElseIf sFisTipi = "HVL" Then
                            dr("ACIKLAMA") = Microsoft.VisualBasic.Left(dr("BANKA").ToString & "\" & dr("SUBE").ToString & "\" & dr("HESAPNO") & "\" & dr("ACIKLAMA"), 60)
                        End If
                        Dim nFirmaID As Int64 = sorgula_nStokID("SET DATEFORMAT DMY SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT     ISNULL(nFirmaID,0) FROM         tbFirma WHERE     (sKodu = '" & sFirmaKodu & "')")
                        If nFirmaID = 0 Then
                            Dim nHesapID As Int64 = 0
                            nHesapID = tbHesapPlani_kaydet_yeni(Microsoft.VisualBasic.Left(dr("FIRMAKODU").ToString, 20), sorgu_telefon(Microsoft.VisualBasic.Left(dr("FIRMAADI").ToString, 60), ""), "", 0, "", 0, "", "", 0, kullaniciadi, Now)
                            nFirmaID = tbFirma_kaydet_yeni(nFirmaID, Microsoft.VisualBasic.Left(dr("FIRMAKODU").ToString, 20), sorgu_telefon(Microsoft.VisualBasic.Left(dr("FIRMAADI").ToString, 60), ""), 0, 0, "01/01/1900", 14, "", "", "", "", "", "", "", "", "", nHesapID, "", kullaniciadi, sorgu_tarih(Now, Now), "", 0, 0, 0, dr("SATICI"), 1, 0, 0).ToString
                            Dim sSinifKodu1 = "" 'sorgu_Sinif_uret("", dr("KOD1").ToString, 1, "F")
                            Dim sSinifKodu2 = "" 'sorgu_Sinif_uret("", dr("KOD2").ToString, 2, "F")
                            Dim sSinifKodu3 = "" 'sorgu_Sinif_uret("", dr("KOD3").ToString, 3, "F")
                            Dim sSinifKodu4 = "" ' sorgu_Sinif_uret("", dr("KOD4").ToString, 4, "F")
                            Dim sSinifKodu5 = "" ' sorgu_Sinif_uret("", dr("KOD5").ToString, 5, "F")
                            tbFirmaSinifi_kaydet_yeni(nFirmaID, sSinifKodu1, sSinifKodu2, sSinifKodu3, sSinifKodu4, sSinifKodu5)
                            tbFirmaAciklamasi_kaydet_yeni(nFirmaID, "", "", "", "", "")
                        End If
                        Dim nKarpinID = sorgula_nStokID("SET DATEFORMAT DMY SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT     ISNULL(nKarpinID,0) FROM         tbKarpin WHERE     (dteFisTarihi = '" & dteFisTarihi & "') AND (sSatici = '" & sSaticiRumuzu & "')")
                        If nKarpinID = 0 Then
                            nKarpinID = tbKarpin_kaydet_yeni(0, dteFisTarihi, sSaticiRumuzu, sSaticiRumuzu, sDepo, 0, 0, 0, "KarpinAktarim", "", "", "", "", Now)
                        End If
                        dr("nFirmaID") = nFirmaID
                        dr("nKarpinID") = nKarpinID
                        Dim nKayitID As Int64 = sorgula_nStokID("SET DATEFORMAT DMY SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED  SELECT     ISNULL(nKayitID,0) FROM         tbKarpinTahsilat WHERE     (nKarpinID = " & dr("nKarpinID") & ") AND (nFirmaID = " & dr("nFirmaID") & ") AND (lTutar = " & dr("TUTAR") & ") AND (sOdemeSekli = '" & dr("FISTIPI") & "') AND (sFisTipi = 1) AND (sAciklama = '" & dr("ACIKLAMA") & "')")
                        If nKayitID = 0 Then
                            dr("nKayitID") = tbKarpin_Tahsilat_kaydet_yeni(0, dr("nKarpinID"), dr("TARIH"), dr("SATICI").ToString, dr("DEPO").ToString, 4, dr("nFirmaID"), dr("FIRMAKODU").ToString, dr("FIRMAADI").ToString, dr("ACIKLAMA").ToString, dr("TUTAR"), dr("FISTIPI").ToString, Now, 0)
                            dr("nKayitID") = tbKarpin_Tahsilat_kaydet_yeni(0, dr("nKarpinID"), dr("TARIH"), dr("SATICI").ToString, dr("DEPO").ToString, 1, dr("nFirmaID"), dr("FIRMAKODU").ToString, dr("FIRMAADI").ToString, dr("ACIKLAMA").ToString, dr("TUTAR"), dr("FISTIPI").ToString, Now, 0)
                        Else
                            dr("nKayitID") = nKayitID
                        End If
                        ds_Tahsilat.Tables(0).Rows.Add(dr)
                        'aktar_veritabani(dr("TARIH"), dr("FIRMAKODU").ToString, dr("FIRMAADI").ToString, dr("FISTIPI").ToString, sorgu_sayi(dr("GIRISCIKIS"), 3), dr("BELGENO").ToString, dr("STOKKODU").ToString, dr("STOKADI").ToString, "KL", dr("MIKTAR"), dr("KOLIICI"), dr("TOPLAMMIKTAR"), dr("FIYAT"), dr("TUTAR"), dr("KDV"), dr("ISKONTO"), dr("ISKONTOTUTAR"), dr("KDVTUTAR"), dr("GENELTOPLAM"), dr("KOD").ToString, dr("VERGIDAIRESI"), dr("VERGINO").ToString, "", "")
                        dr = ds_Tahsilat.Tables(0).NewRow
                        Bar1.Position += 1
                        bar1_text.Text = "S " + (Bar1.Position).ToString
                        Bar1.Refresh()
                        bar1_text.Refresh()
                    End If
            End Select
        Loop
        Bar1.Position = 0
        Bar1.Refresh()
        dlg.Close()
        reader.Close()
        reader = Nothing
        SimpleButton5.Enabled = False
        XtraMessageBox.Show("Okuma ›˛lemi Ba˛ar˝yla Tamamland...!", "Dikkat")
        'Console.ReadLine()
    End Sub
    Private Function tbKarpin_kaydet_yeni(ByVal nKarpinID As Integer, ByVal dteFisTarihi As DateTime, ByVal sSaticiAciklama As String, ByVal sSatici As String, ByVal sDepo As String, ByVal nKmBaslangic As Int64, ByVal nKmBitis As Int64, ByVal nKmFark As Int64, ByVal sAciklama1 As String, ByVal sAciklama2 As String, ByVal sAciklama3 As String, ByVal sAciklama4 As String, ByVal sAciklama5 As String, ByVal dteKayitTarihi As DateTime) As Int64
        Dim con As New OleDb.OleDbConnection
        Dim cmd As New OleDb.OleDbCommand
        cmd.Connection = con
        con.ConnectionString = connection
        If con.State = ConnectionState.Closed = True Then
            con.Open()
        End If
        cmd.CommandText = sorgu_query("SET DATEFORMAT DMY SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED INSERT INTO tbKarpin (dteFisTarihi, sSaticiAciklama, sSatici, sDepo, nKmBaslangic, nKmBitis, nKmFark, sAciklama1, sAciklama2, sAciklama3, sAciklama4, sAciklama5, dteKayitTarihi) VALUES     ('" & dteFisTarihi & "', '" & sSaticiAciklama & "', '" & sSatici & "', '" & sDepo & "', " & nKmBaslangic & ", " & nKmBitis & ", " & nKmFark & ", '" & sAciklama1 & "', '" & sAciklama2 & "', '" & sAciklama3 & "', '" & sAciklama4 & "', '" & sAciklama5 & "', '" & dteKayitTarihi & "')")
        cmd.ExecuteNonQuery()
        cmd.CommandText = "SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT @@identity"
        Dim kayitno = cmd.ExecuteScalar
        con.Close()
        Return kayitno
    End Function
    Private Function tbKarpin_Tahsilat_kaydet_yeni(ByVal nKayitID As Int64, ByVal nKarpinID As Int64, ByVal dteFisTarihi As DateTime, ByVal sSatici As String, ByVal sDepo As String, ByVal sFisTipi As String, ByVal nFirmaID As Integer, ByVal sFirmaKodu As String, ByVal sFirmaAciklama As String, ByVal sAciklama As String, ByVal lTutar As Decimal, ByVal sOdemeSekli As String, ByVal dteKayitTarihi As DateTime, ByVal nBordroKayitID As Int64) As Int64
        Dim con As New OleDb.OleDbConnection
        Dim cmd As New OleDb.OleDbCommand
        Dim kayitno As Integer
        con.ConnectionString = Connection
        con.Open()
        cmd.Connection = con
        cmd.CommandText = "SET DATEFORMAT DMY INSERT INTO tbKarpinTahsilat (nKarpinID, dteFisTarihi, sSatici, sDepo, sFisTipi, nFirmaID, sFirmaKodu, sFirmaAciklama, sAciklama, lTutar, sOdemeSekli, dteKayitTarihi,nBordroKayitID) VALUES     ( " & nKarpinID & ", '" & dteFisTarihi & "', '" & sSatici & "', '" & sDepo & "', '" & sFisTipi & "', " & nFirmaID & ", '" & sFirmaKodu & "', '" & sFirmaAciklama & "', N'" & sAciklama & "', " & lTutar & ", '" & sOdemeSekli & "', '" & dteKayitTarihi & "'," & nBordroKayitID & ")"
        cmd.ExecuteNonQuery()
        cmd.CommandText = "SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT @@identity"
        kayitno = cmd.ExecuteScalar
        con.Close()
        Return kayitno
    End Function
    Public Sub satis_oku_vega_DOS_direkt()
        DataSet1.Tables(0).Clear()
        'dataset1.Tables("TOPLUSTOK").Clear()
        Dim dosya As String = "D:\basis\vega.txt"
        Dim z = (dosya)
        'Dim sr As StreamReader = File.OpenText(z)
        Dim sk As StreamReader = File.OpenText(z)
        Dim s As String
        Dim satir As String
        Dim satis
        Dim kriter1 As String
        Dim firmakodu As String
        Dim firmaadi As String
        Dim belgeno As String
        Dim stokkodu As String
        Dim stokadi As String
        Dim kdv As Integer
        Dim fiyat
        Dim tutar
        Dim miktar As Decimal = 0
        Dim koliici
        Dim iskonto
        Dim iskontotutar
        Dim tarih
        Dim kod
        Dim gun
        Dim ay
        Dim yil
        Dim log As String = ""
        Dim iskonto1 As Decimal
        Dim iskonto2 As Decimal
        Dim iskonto3 As Decimal
        Dim iskonto4 As Decimal
        Dim iskontotoplami As Decimal = 0
        Dim gercektoplam
        Dim isk1
        Dim isk2
        Dim isk3
        Dim isk4
        Dim isksatir As String = ""
        Dim isksatirtutar As String = ""
        Dim isknegatif As Boolean = False
        Dim sayi As Integer
        sayi = 0
        Do While sk.Peek() > -1
            satir = sk.ReadLine
            'firmakodu = Trim(satir.Substring(47, 7))
            sayi += 1
        Loop
        Bar1.Position = 0
        Bar1.Properties.Maximum = sayi
        Bar1.Refresh()
        Dim dlg As New WaitDlgFrm("Toplam Sat˝r :" & sayi)
        sayi = 0
        sk.Close()
        'Dim cmd As New OleDb.OleDbCommand
        'Dim con As New OleDb.OleDbConnection
        'con.ConnectionString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\DATABASE\barkoddb.mdb;Persist Security Info=False"
        'cmd.Connection = con
        'con.Open()
        'cmd.CommandText = "DELETE FROM PLU"
        'cmd.ExecuteNonQuery()
        Dim cmd As New OleDb.OleDbCommand
        Dim con As New OleDb.OleDbConnection
        con.ConnectionString = connection
        con.Open()
        cmd.Connection = con
        cmd.CommandText = "TRUNCATE TABLE BTBLSATIS"
        cmd.ExecuteNonQuery()
        con.Close()
        FileOpen(1, dosya, OpenMode.Input)
        Dim oku() As Byte
        Do Until EOF(1)
            s = LineInput(1)
            oku = System.Text.Encoding.UTF7.GetBytes(s)
            s = System.Text.Encoding.UTF7.GetString(oku)
            'b¸y¸k harf
            s = Replace(s, "Ä", "«")
            s = Replace(s, "¶", "–")
            s = Replace(s, "ò", "›")
            s = Replace(s, "û", "ﬁ")
            s = Replace(s, "ö", "‹")
            s = Replace(s, "ô", "÷")
            'k¸Á¸k harf
            s = Replace(s, "á", "Á")
            s = Replace(s, "ß", "")
            s = Replace(s, "i", "i")
            s = Replace(s, "ü", "˛")
            s = Replace(s, "Å", "¸")
            If s.Length = 210 Then
                firmakodu = Trim(s.Substring(25, 7))
                firmaadi = Trim(s.Substring(32, 30))
                firmaadi = firmaadi.Replace(",", " ")
                firmaadi = firmaadi.Replace("'", " ")
                belgeno = Trim(s.Substring(65, 8))
                stokkodu = Trim(s.Substring(81, 6))
                stokadi = Trim(s.Substring(87, 30))
                stokadi = stokadi.Replace(",", " ")
                stokadi = stokadi.Replace("'", " ")
                fiyat = Trim(s.Substring(124, 10))
                fiyat = fiyat.Replace(",", ".")
                tutar = Trim(s.Substring(149, 10))
                tutar = tutar.Replace(",", ".")
                isksatir = Trim(s.Substring(164, 3))
                isksatirtutar = Trim(s.Substring(177, 10))
                isksatirtutar = isksatirtutar.Replace(",", ".")
                miktar = Trim(s.Substring(134, 9))
                'simge
                firmakodu = firmakodu.Replace("7488926", "7482082")
                firmakodu = firmakodu.Replace("7488927", "7482082")
                firmakodu = firmakodu.Replace("7489218", "7482082")
                firmakodu = firmakodu.Replace("7483812", "7482082")
                firmakodu = firmakodu.Replace("7484646", "7482082")
                firmakodu = firmakodu.Replace("7484718", "7482082")
                firmakodu = firmakodu.Replace("7484797", "7482082")
                'Hatay Birlik
                firmakodu = firmakodu.Replace("7488983", "7483357")
                firmakodu = firmakodu.Replace("7488103", "7483357")
                firmakodu = firmakodu.Replace("7483787", "7483357")
                firmakodu = firmakodu.Replace("7484701", "7483357")
                firmakodu = firmakodu.Replace("7488874", "7483357")
                firmakodu = firmakodu.Replace("7488875", "7483357")
                firmakodu = firmakodu.Replace("7488876", "7483357")
                firmakodu = firmakodu.Replace("7488872", "7483357")
                firmakodu = firmakodu.Replace("7488877", "7483357")
                '˛ok
                firmakodu = firmakodu.Replace("8031465", "320-01-0000")
                firmakodu = firmakodu.Replace("7484600", "320-01-0000")
                firmakodu = firmakodu.Replace("8031168", "320-01-0000")
                firmakodu = firmakodu.Replace("8031299", "320-01-0000")
                firmakodu = firmakodu.Replace("78824", "320-01-0000")
                firmakodu = firmakodu.Replace("78257", "320-01-0000")
                firmakodu = firmakodu.Replace("8031283", "320-01-0000")
                firmakodu = firmakodu.Replace("78256", "320-01-0000")
                firmakodu = firmakodu.Replace("7484519", "320-01-0000")
                firmakodu = firmakodu.Replace("78255", "320-01-0000")
                firmakodu = firmakodu.Replace("76668", "320-01-0000")
                firmakodu = firmakodu.Replace("76922", "320-01-0000")
                firmakodu = firmakodu.Replace("79020", "320-01-0000")
                firmakodu = firmakodu.Replace("7484747", "320-01-0000")
                'Migros
                'firmakodu = firmakodu.Replace("78256", "320-01-0000")
                'If Microsoft.VisualBasic.Left(stokkodu, 2) = "98" Then
                '    fiyat = Trim(s.Substring(178, 10))
                '    fiyat = fiyat.Replace(",", ".")
                '    'fiyat = Math.Abs(CType(fiyat, Decimal))
                '    tutar = Trim(s.Substring(187, 19))
                '    tutar = tutar.Replace(",", ".")
                '    'iskonto = 
                '    iskontotutar = Math.Abs(CType(tutar, Decimal))
                '    'fiyat = 0
                '    'tutar = 0
                '    fiyat = (CType(fiyat, Decimal))
                '    tutar = (CType(tutar, Decimal))
                'Else
                If Microsoft.VisualBasic.Left(stokkodu, 2) = "98" Or Microsoft.VisualBasic.Left(stokkodu, 2) = "99" Then
                    'fiyat = Trim(s.Substring(178, 10))
                    'fiyat = fiyat.Replace(",", ".")
                    'miktar = Trim(s.Substring(134, 9))
                    'tutar = Trim(s.Substring(187, 19))
                    'tutar = tutar.Replace(",", ".")
                    'fiyat = CType(tutar, Decimal) / CType(miktar, Decimal)
                    'iskonto = 0
                    'iskontotutar = 0
                    If isksatir = 900 Then
                        isksatirtutar = (CType(isksatirtutar, Decimal))
                        If isksatirtutar < 0 Then
                            isknegatif = True
                            isksatirtutar = Math.Abs((CType(isksatirtutar, Decimal)))
                        End If
                        isk1 = 25
                        iskonto = isk1
                        fiyat = (isksatirtutar) - (iskonto)
                        If isknegatif = True Then
                            fiyat = -fiyat
                        End If
                        tutar = fiyat * miktar
                        iskontotutar = (tutar * iskonto) / 100
                    ElseIf isksatir = 904 Then
                        isksatirtutar = (CType(isksatirtutar, Decimal))
                        If isksatirtutar < 0 Then
                            isknegatif = True
                            isksatirtutar = Math.Abs((CType(isksatirtutar, Decimal)))
                        End If
                        isk1 = 50
                        iskonto = isk1
                        fiyat = (isksatirtutar) - (isk1)
                        If isknegatif = True Then
                            fiyat = -fiyat
                        End If
                        tutar = fiyat * miktar
                        iskontotutar = (tutar * iskonto) / 100
                    ElseIf isksatir = 907 Then
                        isksatirtutar = (CType(isksatirtutar, Decimal))
                        If isksatirtutar < 0 Then
                            isknegatif = True
                            isksatirtutar = Math.Abs((CType(isksatirtutar, Decimal)))
                        End If
                        isk1 = 75
                        iskonto = isk1
                        fiyat = (isksatirtutar) - (isk1)
                        If isknegatif = True Then
                            fiyat = -fiyat
                        End If
                        tutar = fiyat * miktar
                        iskontotutar = (tutar * iskonto) / 100
                    Else
                        fiyat = Trim(s.Substring(178, 10))
                        fiyat = fiyat.Replace(",", ".")
                        miktar = Trim(s.Substring(134, 9))
                        tutar = Trim(s.Substring(187, 19))
                        tutar = tutar.Replace(",", ".")
                        fiyat = CType(tutar, Decimal) / CType(miktar, Decimal)
                        iskonto = 0
                        iskontotutar = 0
                    End If
                Else
                    iskonto = Trim(s.Substring(179, 9))
                    iskonto = iskonto.Replace(",", ".")
                    iskontotutar = Trim(s.Substring(187, 19))
                    iskontotutar = iskontotutar.Replace(",", ".")
                End If
                'If fiyat = ".00" Then
                '    fiyat = ".01"
                'End If
                'tutar = Trim(s.Substring(149, 10))
                'tutar = tutar.Replace(",", ".")
                'If fiyat = ".00" Then
                '    fiyat = ".01"
                'End If
                'miktar = Trim(s.Substring(134, 9))
                koliici = Trim(s.Substring(119, 3))
                kdv = Trim(Microsoft.VisualBasic.Right(s, 2))
                'iskonto = Trim(s.Substring(179, 9))
                'iskonto = iskonto.Replace(",", ".")
                'iskontotutar = Trim(s.Substring(187, 19))
                'iskontotutar = iskontotutar.Replace(",", ".")
                gun = Trim(s.Substring(12, 2))
                ay = Trim(s.Substring(10, 2))
                yil = "20" + Trim(s.Substring(8, 2))
                kod = Trim(s.Substring(14, 4))
                Dim dr As DataRow = DataSet1.Tables(0).NewRow
                dr("FIRMAKODU") = firmakodu
                dr("FIRMAADI") = firmaadi
                dr("BELGENO") = belgeno
                dr("STOKKODU") = stokkodu
                dr("STOKADI") = stokadi
                dr("FIYAT") = CType(fiyat, Decimal)
                dr("TUTAR") = CType(tutar, Decimal)
                dr("MIKTAR") = CType(miktar, Integer)
                dr("KOLIICI") = CType(koliici, Integer)
                dr("KDV") = kdv
                'dr("ISKONTO") = Math.Abs(CType(iskonto, Decimal))
                'dr("ISKONTOTUTAR") = Math.Abs(CType(iskontotutar, Decimal))
                If dr("TUTAR") < 0 Then
                    dr("ISKONTOTUTAR") = CType(iskontotutar, Decimal)
                Else
                    dr("ISKONTOTUTAR") = Math.Abs(CType(iskontotutar, Decimal))
                End If
                '
                If dr("TUTAR") = 0 Then
                    dr("ISKONTO") = 100
                Else
                    dr("ISKONTO") = Math.Abs(CType(FormatNumber((dr("ISKONTOTUTAR") / dr("TUTAR")) * 100, 2), Decimal))
                End If
                If Microsoft.VisualBasic.Left(stokkodu, 2) = 99 Then
                    'dr("ISKONTO") = Math.Abs(dr("ISKONTO"))
                ElseIf Microsoft.VisualBasic.Left(stokkodu, 2) = 98 Then
                    'dr("ISKONTO") = 0
                End If
                'dr("KDVTUTAR") = (dr("TUTAR") * dr("KDV")) / 100
                dr("TOPLAMMIKTAR") = miktar * koliici
                dr("TARIH") = gun + "." + ay + "." + yil
                dr("KOD") = kod
                If dr("TUTAR") = dr("ISKONTOTUTAR") Then
                    dr("GENELTOPLAM") = 0
                Else
                    dr("GENELTOPLAM") = (dr("TUTAR") - (dr("TUTAR") * dr("ISKONTO") / 100)) * ((dr("KDV") + 100) / 100) '* ((100 + kdv)) / 100
                End If
                If iskontotoplami = 0 Then
                    If dr("ISKONTOTUTAR") <> 0 Then
                        If dr("MIKTAR") * dr("FIYAT") = dr("ISKONTOTUTAR") Then
                            isk1 = 100
                        End If
                    End If
                End If
                isk1 = CType(dr("ISKONTO"), Decimal)
                'MsgBox(isksatir & vbTab & isksatirtutar)
                'If isksatir = "900" Then
                '    isk1 = 25
                '    fiyat = isksatirtutar - isk1
                '    tutar = fiyat * miktar
                'ElseIf isksatir = "904" Then
                '    isk1 = 50
                '    fiyat = isksatirtutar - isk1
                '    tutar = fiyat * miktar
                'ElseIf isksatir = "907" Then
                '    isk1 = 75
                '    fiyat = isksatirtutar - isk1
                '    tutar = fiyat * miktar
                'End If
                isk2 = 0
                isk3 = 0
                isk4 = 0
                'gercektoplam = dr("TOPLAM")
                Try
                    iskonto1 = dr("FIYAT") * ((100 - isk1) / 100)
                Catch ex As Exception
                    iskonto1 = 0
                End Try
                'iskonto1 = dr("FIYATI") * ((100 - isk1) / 100)
                iskonto2 = iskonto1 * ((100 - isk2) / 100)
                iskonto3 = iskonto2 * ((100 - isk3) / 100)
                iskonto4 = iskonto3 * ((100 - isk4) / 100)
                gercektoplam = iskonto4 * miktar
                dr("GENELTOPLAM") = gercektoplam
                dr("KDVTUTAR") = (dr("GENELTOPLAM") * dr("KDV")) / 100
                'dr("GENELTOPLAM") = (dr("TUTAR") - (dr("TUTAR") * dr("ISKONTO") / 100)) * ((dr("KDV") + 100) / 100) '* ((100 + kdv)) / 100
                aktar_veritabani(dr("TARIH"), dr("FIRMAKODU"), dr("FIRMAADI"), "FS", 3, dr("BELGENO"), dr("STOKKODU"), dr("STOKADI"), "KL", dr("MIKTAR"), dr("KOLIICI"), dr("TOPLAMMIKTAR"), dr("FIYAT"), dr("TUTAR"), dr("KDV"), dr("ISKONTO"), dr("ISKONTOTUTAR"), dr("KDVTUTAR"), dr("GENELTOPLAM"), dr("KOD"), "", "", "", "")
                DataSet1.Tables(0).Rows.Add(dr)
                Bar1.Position += 1
                bar1_text.Text = "S " + (Bar1.Position).ToString
                Bar1.Refresh()
                bar1_text.Refresh()
            ElseIf s.Length > 1 And s.Length < 210 Then
                'MsgBox(Sorgu_sDil("T¸rkÁe Karakterler Kullan˝lm˝˛",sDil), Sorgu_sDil("Dikkat", sDil), MessageBoxButtons.OK, MessageBoxIcon.Information)
                log += "Hatal˝ Sat˝r :" & vbTab & Bar1.Position.ToString & vbTab & s & vbCrLf
            End If
        Loop
        FileClose(1)
        'Dim stoklistesi As String = "SELECT     PLU.IND, PLU.PLUNO AS TAKIPNO, PLU.BARCODE, PLU.STOKADI, PLU.SATISFIYATI, PLU.BIRIM, PLU.DEPARTMAN, PLU.REYON, PLU.STATUS,  DEPARTMAN.KDV, DEPARTMAN.ACIKLAMA FROM         (PLU INNER JOIN DEPARTMAN ON PLU.DEPARTMAN = DEPARTMAN.DEPARTMAN)"
        'con.Close()
        Bar1.Position = 0
        Bar1.Refresh()
        dlg.Close()
        If log.Length <> 0 Then
            SimpleButton5.Enabled = False
            XtraMessageBox.Show(Sorgu_sDil("Mevcut Dosyada T¸rkÁe Karakterler Kullan˝lm˝˛...!", sDil) & vbCrLf & Sorgu_sDil("L¸tfen Log Sayfas˝ndan Sat˝rlar˝ Kontrol Ediniz", sDil), Sorgu_sDil("Dikkat", sDil), MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else
            SimpleButton5.Enabled = True
        End If
        s = Nothing
        satir = Nothing
        satis = Nothing
        kriter1 = Nothing
        firmakodu = Nothing
        firmaadi = Nothing
        belgeno = Nothing
        stokkodu = Nothing
        stokadi = Nothing
        kdv = Nothing
        fiyat = Nothing
        tutar = Nothing
        miktar = Nothing
        koliici = Nothing
        iskonto = Nothing
        iskontotutar = Nothing
        tarih = Nothing
        kod = Nothing
        gun = Nothing
        ay = Nothing
        yil = Nothing
        log = Nothing
        sayi = Nothing
        cmd = Nothing
        con = Nothing
    End Sub
    Private Sub aktar_veritabani(ByVal tarih As DateTime, ByVal firmakodu As String, ByVal firmaadi As String, ByVal FISTIPI As String, ByVal GIRISCIKIS As Integer, ByVal belgeno As String, ByVal stokkodu As String, ByVal stokadi As String, ByVal birim As String, ByVal miktar As Decimal, ByVal koliici As Decimal, ByVal toplammiktar As Decimal, ByVal fiyat As Decimal, ByVal tutar As Decimal, ByVal kdv As Decimal, ByVal iskonto As Decimal, ByVal iskontotutar As Decimal, ByVal kdvtutar As Decimal, ByVal geneltoplam As Decimal, ByVal kod As String, ByVal sVergiDairesi As String, ByVal sVergiNo As String, ByVal sAdres As String, ByVal sTelefon As String)
        Dim con As New OleDb.OleDbConnection
        Dim cmd As New OleDb.OleDbCommand
        con.ConnectionString = connection
        con.Open()
        cmd.Connection = con
        cmd.CommandText = "SET DATEFORMAT DMY INSERT INTO BTBLSATIS                      (TARIH,FIRMAKODU, FIRMAADI, FISTIPI,GIRISCIKIS,BELGENO, STOKKODU, STOKADI, BIRIM, MIKTAR, KOLIICI, TOPLAMMIKTAR, FIYAT, TUTAR, KDV, ISKONTO, ISKONTOTUTAR, KDVTUTAR, GENELTOPLAM, KOD,VERGIDAIRESI,VERGINO,ADRES,TELEFON)" & _
        "VALUES('" & tarih & "','" & firmakodu & "','" & firmaadi & "' ,'" & FISTIPI & "'," & GIRISCIKIS & ",'" & belgeno & "' ,'" & stokkodu & "' ,'" & stokadi & "' ,'" & birim & "' ," & miktar & " ," & koliici & " ," & toplammiktar & " ," & fiyat & " ," & tutar & " ," & kdv & " ," & iskonto & " ," & iskontotutar & " ," & kdvtutar & " ," & geneltoplam & " ,'" & kod & "' ,'" & sVergiDairesi & "','" & sVergiNo & "','" & sAdres & "','" & sTelefon & "')"
        cmd.ExecuteNonQuery()
        con.Close()
        con = Nothing
        cmd = Nothing
    End Sub
    Public Function query_FAT_BASLIK(ByVal sFisTipi As String) As DataSet
        Dim conn As New OleDb.OleDbConnection
        Dim cmd As New OleDb.OleDbCommand
        Dim adapter As New OleDb.OleDbDataAdapter
        conn.ConnectionString = connection
        adapter.SelectCommand = cmd
        'cmd.CommandText = sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT     TARIH,FISTIPI,BELGENO,KOD, ISNULL(SUM(MIKTAR), 0) AS TOPLAMMIKTAR, ISNULL(SUM(TUTAR), 0) AS ARATOPLAM, FIRMAKODU, FIRMAADI, ISNULL(SUM(GENELTOPLAM), 0) AS GENELTOPLAM, ISNULL(SUM(KDVTUTAR), 0) AS TOPLAMKDV, ISNULL(SUM(ISKONTOTUTAR), 0)  AS TOPLAMISKONTO,'1' AS STATUS,(SELECT nFirmaID FROM tbFirma WHERE sKodu=BTBLSATIS.FIRMAKODU ) AS CARINO,(SELECT ISNULL(nVadeGun,0) FROM tbFirma WHERE sKodu=BTBLSATIS.FIRMAKODU ) AS OPSIYON  FROM         BTBLSATIS WHERE (BELGENO NOT IN (SELECT lFisNo FROM tbStokFisiMaster where sFisTipi ='FS' and nGirisCikis =3)) GROUP BY TARIH,BELGENO,KOD, FIRMAKODU, FIRMAADI")
        cmd.CommandText = sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT     TARIH,FISTIPI,GIRISCIKIS,BELGENO,KOD, ISNULL(SUM(MIKTAR), 0) AS TOPLAMMIKTAR, ISNULL(SUM(TUTAR), 0) AS ARATOPLAM, FIRMAKODU, FIRMAADI, ISNULL(SUM(GENELTOPLAM), 0) AS GENELTOPLAM, ISNULL(SUM(KDVTUTAR), 0) AS TOPLAMKDV, ISNULL(SUM(ISKONTOTUTAR), 0)  AS TOPLAMISKONTO,'1' AS STATUS,(SELECT nFirmaID FROM tbFirma WHERE sKodu=BTBLSATIS.FIRMAKODU ) AS CARINO,(SELECT ISNULL(nVadeGun,0) FROM tbFirma WHERE sKodu=BTBLSATIS.FIRMAKODU ) AS OPSIYON  FROM         BTBLSATIS WHERE (BELGENO NOT IN (SELECT lFisNo FROM tbStokFisiMaster where sFisTipi =BTBLSATIS.FISTIPI and nGirisCikis =BTBLSATIS.GIRISCIKIS)) GROUP BY TARIH,FISTIPI,GIRISCIKIS,BELGENO,KOD, FIRMAKODU, FIRMAADI")
        cmd.Connection = conn
        conn.Open()
        Dim ds As New DataSet
        Dim N As Integer = adapter.Fill(ds, "FAT_BASLIK")
        conn.Close()
        Return ds
    End Function
    Public Function query_FAT_HAREKET(ByVal evn As String, ByVal firmano As Integer, ByVal TARIH As DateTime) As DataSet
        Dim conn As New OleDb.OleDbConnection
        Dim cmd As New OleDb.OleDbCommand
        Dim adapter As New OleDb.OleDbDataAdapter
        Dim kriter As String
        kriter = " "
        kriter += " WHERE BELGENO ='" & evn & "' "
        kriter += " AND TARIH ='" & TARIH & "'"
        kriter += " AND MIKTAR <> 0"
        conn.ConnectionString = connection
        adapter.SelectCommand = cmd
        cmd.CommandText = sorgu_query("SET DATEFORMAT DMY SELECT STOKKODU, STOKADI, BIRIM, ISNULL(KDV, 0) AS KDV, ISNULL(MIKTAR, 1) AS MIKTAR, ISNULL(FIYAT, 0) AS FIYAT, ISNULL(ISKONTO, 0) AS ISK1, 0 AS ISK2, 0 AS ISK3, 0 AS ISK4, ISNULL(ISKONTOTUTAR, 0) AS ISKTUTAR, ISNULL(KDVTUTAR, 0) AS KDVTUTAR, ISNULL(TUTAR, 0) AS TOPLAM, ISNULL(GENELTOPLAM, 0) AS GENELTOPLAM,ISNULL(DEPONO,1) AS DEPONO, (SELECT  ISNULL(nStokID,0) FROM tbStok WHERE sKodu = BSATIS.STOKKODU) AS STOKNO, 1 AS BIRIMEX FROM BTBLSATIS  BSATIS " & kriter & "  ORDER BY TARIH, BELGENO")
        cmd.Connection = conn
        conn.Open()
        Dim ds As New DataSet
        Dim N As Integer = adapter.Fill(ds, "FAT_HAREKET")
        conn.Close()
        Return ds
    End Function
    Private Sub aktar_business_satis()
        If XtraMessageBox.Show(Sorgu_sDil("Faturalar˝ Sisteme Aktarmak ›stediinize Eminmisiniz...?", sDil), Sorgu_sDil("Dikkat", sDil), MessageBoxButtons.YesNo, MessageBoxIcon.Question) = MsgBoxResult.Yes Then
            ds5 = query_cariler("BTBLSATIS")
            ds6 = query_stoklar()
            If ds5.Tables(0).Rows.Count > 0 Then
                ekle_stok(20)
                ekle_cari()
                DataSet2 = query_FAT_BASLIK("FS")
                GridControl2.DataSource = DataSet2.Tables(0)
                ekle_fatura(Today, "FS", 1)
            ElseIf ds6.Tables(0).Rows.Count > 0 Then
                ekle_stok(20)
                ekle_cari()
                DataSet2 = query_FAT_BASLIK("FS")
                GridControl2.DataSource = DataSet2.Tables(0)
                ekle_fatura(Today, "FS", 1)
            Else
                ekle_stok(20)
                ekle_cari()
                DataSet2 = query_FAT_BASLIK("FS")
                GridControl2.DataSource = DataSet2.Tables(0)
                ekle_fatura(Today, "FS", 1)
            End If
        End If
    End Sub
    Private Sub ekle_stok(ByVal nUzunluk As Integer)
        Dim nStokID = 0
        Dim nKayit = 0
        Dim sSinifKodu1 As String = ""
        Dim sSinifKodu2 As String = ""
        Dim sSinifKodu3 As String = ""
        Dim sSinifKodu4 As String = ""
        Dim sSinifKodu5 As String = ""
        Dim sSinifKodu6 As String = ""
        Dim sSinifKodu7 As String = ""
        Dim sSinifKodu8 As String = ""
        Dim sSinifKodu9 As String = ""
        Dim sSinifKodu10 As String = ""
        Dim sRenk As String = ""
        Dim sBeden As String = ""
        Dim sModel As String = ""
        Dim sBirimCinsi1 As String = ""
        Dim sKdvTipi As String = ""
        Dim dr As DataRow
        Bar1.Position = 0
        Bar1.Properties.Maximum = ds6.Tables(0).Rows.Count
        For Each dr In ds6.Tables(0).Rows
            nKayit = sorgu_nStokID(Microsoft.VisualBasic.Left(sorgu_telefon(dr("STOKKODU").ToString, ""), nUzunluk))
            If nKayit = 0 Then
                sModel = Microsoft.VisualBasic.Left(sorgu_telefon(dr("STOKKODU").ToString, ""), nUzunluk)
                If Trim(dr("BIRIM").ToString) <> "" Then
                    sBirimCinsi1 = sorgu_sBirimCinsi1_kontrol(Microsoft.VisualBasic.Left(Trim(dr("BIRIM")), 3), Trim(dr("BIRIM")))
                    If Trim(sBirimCinsi1) = "" Then
                        sBirimCinsi1 = Microsoft.VisualBasic.Left(Trim(dr("BIRIM").ToString), 3)
                        Try
                            tbBirimCinsi_kaydet_yeni(sBirimCinsi1, dr("BIRIM").ToString, 3)
                        Catch ex As Exception
                            sBirimCinsi1 = ""
                        End Try
                    End If
                Else
                    sBirimCinsi1 = ""
                End If
                dr("KDV") = sorgu_sayi(dr("KDV"), 0)
                If Trim(dr("KDV").ToString) <> "" Then
                    sKdvTipi = sorgu_sKdvTipi_kontrol(dr("KDV"))
                    If Trim(sKdvTipi) = "" Then
                        sKdvTipi = columnuzunlukinteger_sifir(sorgu_sKdvTipi_kontrol_kayit(dr("KDV")), 2)
                        tbKdv_kaydet_yeni(sKdvTipi, dr("KDV"))
                    End If
                Else
                    sKdvTipi = ""
                End If
                nStokID = tbStok_kaydet_yeni(Microsoft.VisualBasic.Left(sorgu_telefon(dr("STOKKODU").ToString, ""), nUzunluk), Microsoft.VisualBasic.Left(sorgu_telefon(dr("STOKADI"), ""), 60), "", 0, "", "", "", "", "", sBirimCinsi1, "", 0, sKdvTipi, 0, 0, 0, "", 0, sModel, kullanici, Now, 1, "", 0, 0, "", 0, 0, 0)
                sSinifKodu1 = ""
                sSinifKodu2 = ""
                sSinifKodu3 = ""
                sSinifKodu4 = ""
                sSinifKodu5 = ""
                sSinifKodu6 = ""
                sSinifKodu7 = ""
                sSinifKodu8 = ""
                sSinifKodu9 = ""
                sSinifKodu10 = ""
                tbStokSinifi_kaydet_yeni(nStokID, sSinifKodu1, sSinifKodu2, sSinifKodu3, sSinifKodu4, sSinifKodu5, sSinifKodu6, sSinifKodu7, sSinifKodu8, sSinifKodu9, sSinifKodu10, "", "", "", "", "")
                dr("FIYAT") = sorgu_sayi(dr("FIYAT"), 0)
                'dr("SATISFIYATI2") = sorgu_sayi(dr("SATISFIYATI2"), 0)
                'dr("SATISFIYATI3") = sorgu_sayi(dr("SATISFIYATI3"), 0)
                'dr("ALISFIYATI") = sorgu_sayi(dr("ALISFIYATI"), 0)
                'dr("MALIYET") = sorgu_sayi(dr("MALIYET"), 0)
                If dr("FIYAT") > 0 Then
                    tbStokFiyati_ekle_yeni(0, sorgu_telefon(dr("STOKKODU").ToString, ""), "", "", sFiyat1, dr("FIYAT"), sorgu_tarih(Today, Today), kullaniciadi)
                End If
                Try
                    If Trim(dr("STOKKODU").ToString) <> "" Then
                        tbStokBarkodu_kaydet_yeni(nStokID, Trim(dr("STOKKODU").ToString), 0, 0, "", "")
                    End If
                Catch ex As Exception
                End Try
            End If
            Bar1.Position += 1
            Bar1.Refresh()
            bar1_text.Text = Bar1.Position
            bar1_text.Refresh()
        Next
        ds6.Clear()
        Bar1.Position = 0
        Bar1.Refresh()
        'MsgBox(Sorgu_sDil("Tamamland˝",sDil), MessageBoxIcon.Information, "SonuÁ")
    End Sub
    Private Function columnuzunlukinteger_sifir(ByVal deger As String, ByVal uzunluk As Integer) As String
        Dim stringhedef = Trim(deger)
        Dim hedefuzunluk = Len(stringhedef)
        If Len(stringhedef) < uzunluk Then
            Dim fark = uzunluk - hedefuzunluk
            Dim i As Integer
            For i = 1 To fark
                stringhedef = stringhedef.Insert(0, "0")
            Next
            fark = Nothing
            i = Nothing
        Else
            stringhedef = Microsoft.VisualBasic.Left(stringhedef, uzunluk)
        End If
        Return stringhedef
    End Function
    Private Function sorgu_sayi(ByVal deger As Object, ByVal sonuc As Int64) As Decimal
        If deger.ToString = "" Then
            deger = sonuc
        End If
        Return deger
    End Function
    Private Function sorgu_sayi_alfabe(ByVal deger As String, ByVal sonuc As Int64) As Decimal
        'b¸y¸k harf
        If deger.ToString = "" Then
            deger = ""
        End If
        deger = Replace(deger.ToString, "Ä", "")
        deger = Replace(deger.ToString, "¶", "")
        deger = Replace(deger.ToString, "ò", "")
        deger = Replace(deger.ToString, "û", "")
        deger = Replace(deger.ToString, "ö", "")
        deger = Replace(deger.ToString, "ô", "")
        'k¸Á¸k harf
        deger = Replace(deger.ToString, "á", "")
        deger = Replace(deger.ToString, "ß", "")
        deger = Replace(deger.ToString, "i", "")
        deger = Replace(deger.ToString, "ü", "")
        deger = Replace(deger.ToString, "Å", "")
        deger = Replace(UCase(deger.ToString), "A", "")
        deger = Replace(UCase(deger.ToString), "B", "")
        deger = Replace(UCase(deger.ToString), "C", "")
        deger = Replace(UCase(deger.ToString), "«", "")
        deger = Replace(UCase(deger.ToString), "D", "")
        deger = Replace(UCase(deger.ToString), "E", "")
        deger = Replace(UCase(deger.ToString), "F", "")
        deger = Replace(UCase(deger.ToString), "G", "")
        deger = Replace(UCase(deger.ToString), "H", "")
        deger = Replace(UCase(deger.ToString), "I", "")
        deger = Replace(UCase(deger.ToString), "›", "")
        deger = Replace(UCase(deger.ToString), "J", "")
        deger = Replace(UCase(deger.ToString), "K", "")
        deger = Replace(UCase(deger.ToString), "L", "")
        deger = Replace(UCase(deger.ToString), "M", "")
        deger = Replace(UCase(deger.ToString), "N", "")
        deger = Replace(UCase(deger.ToString), "O", "")
        deger = Replace(UCase(deger.ToString), "÷", "")
        deger = Replace(UCase(deger.ToString), "P", "")
        deger = Replace(UCase(deger.ToString), "R", "")
        deger = Replace(UCase(deger.ToString), "S", "")
        deger = Replace(UCase(deger.ToString), "ﬁ", "")
        deger = Replace(UCase(deger.ToString), "T", "")
        deger = Replace(UCase(deger.ToString), "U", "")
        deger = Replace(UCase(deger.ToString), "‹", "")
        deger = Replace(UCase(deger.ToString), "V", "")
        deger = Replace(UCase(deger.ToString), "Y", "")
        deger = Replace(UCase(deger.ToString), "Z", "")
        deger = Replace(UCase(deger.ToString), "X", "")
        deger = Replace(UCase(deger.ToString), "W", "")
        If deger.ToString = "" Then
            deger = sonuc
        End If
        Return deger
    End Function
    Private Function sorgu_tarih(ByVal deger As Object, ByVal sonuc As DateTime) As DateTime
        If deger.ToString = "" Then
            deger = sonuc
        End If
        Return deger
    End Function
    Private Function sorgu_telefon(ByVal deger As Object, ByVal sonuc As String) As String
        If deger.ToString = "" Then
            deger = sonuc
        End If
        deger = deger.Replace("(", "")
        deger = deger.Replace(")", "")
        deger = deger.Replace("_", "")
        deger = deger.Replace(";", "")
        deger = deger.Replace("'", "")
        deger = deger.Replace(",", "")
        'deger = deger.Replace(".", "")
        Return deger
    End Function
    Private Sub ekle_cari()
        Dim nHesapID = 0
        Dim nFirmaID = 0
        Dim nKayit = 0
        Dim sSinifKodu1 As String = ""
        Dim sSinifKodu2 As String = ""
        Dim sSinifKodu3 As String = ""
        Dim sSinifKodu4 As String = ""
        Dim sSinifKodu5 As String = ""
        Dim dr As DataRow
        Bar1.Position = 0
        Bar1.Properties.Maximum = ds5.Tables(0).Rows.Count
        For Each dr In ds5.Tables(0).Rows
            nKayit = sorgu_firma_kontrol(Microsoft.VisualBasic.Left(dr("FIRMAKODU").ToString, 20))
            If nKayit = 0 Then
                nHesapID = tbHesapPlani_kaydet_yeni(Microsoft.VisualBasic.Left(dr("FIRMAKODU").ToString, 20), sorgu_telefon(Microsoft.VisualBasic.Left(dr("FIRMAADI").ToString, 60), ""), "", 0, "", 0, "", "", 0, kullaniciadi, Now)
                nFirmaID = tbFirma_kaydet_yeni(nFirmaID, Microsoft.VisualBasic.Left(dr("FIRMAKODU").ToString, 20), sorgu_telefon(Microsoft.VisualBasic.Left(dr("FIRMAADI").ToString, 60), ""), 0, 0, "01/01/1900", 14, "", "", "", "", "", "", "", Microsoft.VisualBasic.Left(sorgu_telefon(dr("VERGIDAIRESI").ToString, ""), 60), Microsoft.VisualBasic.Left(dr("VERGINO").ToString, 60), nHesapID, "", kullaniciadi, sorgu_tarih(Now, Now), "", 0, 0, 0, dr("KOD"), 1, 0, 0).ToString
                sSinifKodu1 = "" 'sorgu_Sinif_uret("", dr("KOD1").ToString, 1, "F")
                sSinifKodu2 = "" 'sorgu_Sinif_uret("", dr("KOD2").ToString, 2, "F")
                sSinifKodu3 = "" 'sorgu_Sinif_uret("", dr("KOD3").ToString, 3, "F")
                sSinifKodu4 = "" ' sorgu_Sinif_uret("", dr("KOD4").ToString, 4, "F")
                sSinifKodu5 = "" ' sorgu_Sinif_uret("", dr("KOD5").ToString, 5, "F")
                tbFirmaSinifi_kaydet_yeni(nFirmaID, sSinifKodu1, sSinifKodu2, sSinifKodu3, sSinifKodu4, sSinifKodu5)
                tbFirmaAciklamasi_kaydet_yeni(nFirmaID, "", "", "", "", "")
            End If
            Bar1.Position += 1
            Bar1.Refresh()
            bar1_text.Text = Bar1.Position
            bar1_text.Refresh()
        Next
        Bar1.Position = 0
        Bar1.Refresh()
        ds5.Clear()
        'MsgBox(Sorgu_sDil("Tamamland˝",sDil), MessageBoxIcon.Information, "SonuÁ")
    End Sub
#Region " Cari "
    Public Function sorgu_firma_kontrol(ByVal kod As String) As Int64
        Dim kriter
        kriter = "WHERE (sKodu = '" & kod & "')  "
        Dim conn As New OleDb.OleDbConnection
        Dim cmd As New OleDb.OleDbCommand
        Dim adapter As New OleDb.OleDbDataAdapter
        'MsgBox(connection_resmi)
        conn.ConnectionString = connection
        cmd.Connection = conn
        conn.Open()
        cmd.CommandText = sorgu_query("SET DATEFORMAT DMY SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT     ISNULL(COUNT(*), 0) AS KAYIT FROM         tbFirma " & kriter & "")
        Dim kayitsayisi = cmd.ExecuteScalar
        Return kayitsayisi
        cmd = Nothing
        conn = Nothing
    End Function
    Public Function sorgu_TBfirma_kontrol(ByVal kod As String, Optional ByVal sDatabase As String = "") As Int64
        Dim use As String = ""
        If sDatabase <> "" Then
            use = "USE " & sDatabase
        End If
        Dim kriter
        kriter = "WHERE (sKodu = '" & kod & "')  "
        Dim conn As New OleDb.OleDbConnection
        Dim cmd As New OleDb.OleDbCommand
        Dim adapter As New OleDb.OleDbDataAdapter
        'MsgBox(connection_resmi)
        conn.ConnectionString = connection
        cmd.Connection = conn
        conn.Open()
        cmd.CommandText = sorgu_query("" & use & " SET DATEFORMAT DMY SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT     ISNULL(nFirmaID, 0) AS KAYIT FROM         tbFirma " & kriter & "")
        Dim kayitsayisi = cmd.ExecuteScalar
        conn.Close()
        cmd = Nothing
        conn = Nothing
        adapter = Nothing
        Return kayitsayisi
        cmd = Nothing
        conn = Nothing
    End Function
    Private Function tbFirma_kaydet_yeni(ByVal nFirmaID As String, ByVal sKodu As String, ByVal sAciklama As String, ByVal nOzelIskontosu As Int64, ByVal lKrediLimiti As Decimal, ByVal dteMutabakatTarihi As DateTime, ByVal nVadeGun As Int64, ByVal sHitap As String, ByVal sAdres1 As String, ByVal sAdres2 As String, ByVal sSemt As String, ByVal sIl As String, ByVal sUlke As String, ByVal sPostaKodu As String, ByVal sVergiDairesi As String, ByVal sVergiNo As String, ByVal nHesapID As Int64, ByVal sOzelNot As String, ByVal sKullaniciAdi As String, ByVal dteKayitTarihi As DateTime, ByVal sFiyatTipi As String, ByVal nOzelIskontosu2 As Decimal, ByVal nOzelIskontosu3 As Decimal, ByVal nOzelIskontosu4 As Decimal, ByVal sSaticiRumuzu As String, ByVal bAktif As Integer, ByVal bSatisYapilamaz As Byte, ByVal bTahsilatYapilamaz As Byte, Optional ByVal sDatabase As String = "") As Int64
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
        bAktif = Math.Abs(bAktif)
        cmd.CommandText = sorgu_query("" & use & " SET DATEFORMAT DMY SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED INSERT INTO tbFirma (sKodu, sAciklama, nOzelIskontosu, lKrediLimiti, dteMutabakatTarihi, nVadeGun, sHitap, sAdres1, sAdres2, sSemt, sIl, sUlke, sPostaKodu, sVergiDairesi, sVergiNo, nHesapID, sOzelNot, sKullaniciAdi, dteKayitTarihi, sFiyatTipi,nOzelIskontosu2,nOzelIskontosu3,nOzelIskontosu4,sSaticiRumuzu,bAktif) VALUES     ('" & sKodu & "', N'" & sAciklama & "', " & nOzelIskontosu & ", " & lKrediLimiti & ", '" & dteMutabakatTarihi & "', " & nVadeGun & ", '" & sHitap & "', '" & sAdres1 & "', '" & sAdres2 & "', '" & sSemt & "', '" & sIl & "', '" & sUlke & "', '" & sPostaKodu & "', '" & sVergiDairesi & "', '" & sVergiNo & "', " & nHesapID & ", '" & sOzelNot & "', '" & sKullaniciAdi & "','" & dteKayitTarihi & "', '" & sFiyatTipi & "'," & nOzelIskontosu2 & "," & nOzelIskontosu3 & "," & nOzelIskontosu4 & ",'" & sSaticiRumuzu & "'," & bAktif & ")")
        cmd.ExecuteNonQuery()
        cmd.CommandText = "SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT @@identity"
        Dim kayitno = cmd.ExecuteScalar
        con.Close()
        Return kayitno
    End Function
    Private Function tbHesapPlani_kaydet_yeni(ByVal sKodu As String, ByVal sAciklama As String, ByVal sAlterneAciklama As String, ByVal lBilancoSatiri As Decimal, ByVal sAktifPasif As String, ByVal lKarZararSatiri As Decimal, ByVal sKarZararGelirGider As String, ByVal sMasrafYontemi As String, ByVal bMiktarVar As Integer, ByVal sKullaniciAdi As String, ByVal dteKayitTarihi As DateTime, Optional ByVal sDatabase As String = "") As Int64
        Dim use As String = ""
        If sDatabase <> "" Then
            use = "USE " & sDatabase
        End If
        Dim con As New OleDb.OleDbConnection
        Dim cmd As New OleDb.OleDbCommand
        cmd.Connection = con
        con.ConnectionString = connection
        If con.State = ConnectionState.Closed = True Then
            con.Open()
        End If
        cmd.CommandText = sorgu_query("" & use & " SET DATEFORMAT DMY SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT     ISNULL(nHesapID, 0) AS nHesapID  FROM         tbHesapPlani Where sKodu = '" & sKodu & "' ")
        Dim kayitno = cmd.ExecuteScalar
        If Trim(kayitno) = "0" Or Trim(kayitno) = "" Then
            cmd.CommandText = sorgu_query("" & use & " SET DATEFORMAT DMY SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED INSERT INTO tbHesapPlani (sKodu, sAciklama, sAlterneAciklama, lBilancoSatiri, sAktifPasif, lKarZararSatiri, sKarZararGelirGider, sMasrafYontemi, bMiktarVar, sKullaniciAdi, dteKayitTarihi) VALUES     ('" & sKodu & "', N'" & sAciklama & "', '" & sAlterneAciklama & "', " & lBilancoSatiri & ", '" & sAktifPasif & "', " & lKarZararSatiri & ", '" & sKarZararGelirGider & "', '" & sMasrafYontemi & "', " & bMiktarVar & ", '" & sKullaniciAdi & "', '" & dteKayitTarihi & "')")
            cmd.ExecuteNonQuery()
            cmd.CommandText = "SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT @@identity"
            kayitno = cmd.ExecuteScalar
        End If
        con.Close()
        Return kayitno
        cmd = Nothing
        con = Nothing
    End Function
    Private Sub tbFirmaSinifi_kaydet_yeni(ByVal nFirmaID As String, ByVal sSinifKodu1 As String, ByVal sSinifKodu2 As String, ByVal sSinifKodu3 As String, ByVal sSinifKodu4 As String, ByVal sSinifKodu5 As String, Optional ByVal sDatabase As String = "")
        Dim use As String = ""
        If sDatabase <> "" Then
            use = "USE " & sDatabase
        End If
        Dim con As New OleDb.OleDbConnection
        Dim cmd As New OleDb.OleDbCommand
        cmd.Connection = con
        con.ConnectionString = connection
        If con.State = ConnectionState.Closed = True Then
            con.Open()
        End If
        cmd.CommandText = sorgu_query("" & use & " SET DATEFORMAT DMY SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED INSERT INTO tbFirmaSinifi (nFirmaID, sSinifKodu1, sSinifKodu2, sSinifKodu3, sSinifKodu4, sSinifKodu5) VALUES     (" & nFirmaID & ", '" & sSinifKodu1 & "', '" & sSinifKodu2 & "', '" & sSinifKodu3 & "', '" & sSinifKodu4 & "', '" & sSinifKodu5 & "')")
        cmd.ExecuteNonQuery()
        con.Close()
        cmd = Nothing
        con = Nothing
    End Sub
    Private Sub tbFirmaAciklamasi_kaydet_yeni(ByVal nFirmaID As String, ByVal sAciklama1 As String, ByVal sAciklama2 As String, ByVal sAciklama3 As String, ByVal sAciklama4 As String, ByVal sAciklama5 As String, Optional ByVal sDatabase As String = "")
        Dim use As String = ""
        If sDatabase <> "" Then
            use = "USE " & sDatabase
        End If
        Dim con As New OleDb.OleDbConnection
        Dim cmd As New OleDb.OleDbCommand
        cmd.Connection = con
        con.ConnectionString = connection
        If con.State = ConnectionState.Closed = True Then
            con.Open()
        End If
        cmd.CommandText = sorgu_query("" & use & " SET DATEFORMAT DMY SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED INSERT INTO tbFirmaAciklamasi (nFirmaID, sAciklama1, sAciklama2, sAciklama3, sAciklama4, sAciklama5) VALUES     ('" & nFirmaID & "', '" & sAciklama1 & "', '" & sAciklama2 & "', '" & sAciklama3 & "', '" & sAciklama4 & "', '" & sAciklama5 & "')")
        cmd.ExecuteNonQuery()
        con.Close()
        cmd = Nothing
        con = Nothing
    End Sub
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
#End Region
    Public Function query_cariler(ByVal tablo As String) As DataSet
        Dim conn As New OleDb.OleDbConnection
        Dim cmd As New OleDb.OleDbCommand
        Dim adapter As New OleDb.OleDbDataAdapter
        conn.ConnectionString = connection
        adapter.SelectCommand = cmd
        cmd.CommandText = sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT DISTINCT FIRMAKODU, FIRMAADI,ADRES,TELEFON,VERGIDAIRESI,VERGINO,KOD FROM BTBLSATIS WHERE (FIRMAKODU NOT IN (SELECT sKodu FROM tbFirma)) GROUP BY FIRMAKODU, FIRMAADI, ADRES, TELEFON, VERGIDAIRESI, VERGINO,KOD ORDER BY FIRMAKODU, FIRMAADI")
        cmd.Connection = conn
        conn.Open()
        Dim ds As New DataSet
        Dim N As Integer = adapter.Fill(ds, "CARILER")
        conn.Close()
        Return ds
    End Function
    Public Function query_stoklar() As DataSet
        Dim conn As New OleDb.OleDbConnection
        Dim cmd As New OleDb.OleDbCommand
        Dim adapter As New OleDb.OleDbDataAdapter
        conn.ConnectionString = connection
        adapter.SelectCommand = cmd
        cmd.CommandText = sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT DISTINCT STOKKODU, STOKADI, BIRIM,FIYAT,KDV FROM BTBLSATIS WHERE (STOKKODU NOT IN (SELECT sKodu FROM tbStok)) GROUP BY STOKKODU, STOKADI, BIRIM,FIYAT,KDV ORDER BY STOKKODU, STOKADI")
        cmd.Connection = conn
        conn.Open()
        Dim ds As New DataSet
        Dim N As Integer = adapter.Fill(ds, "STOKLAR")
        conn.Close()
        Return ds
    End Function
    Private Sub fatura_kayit()
        Dim dr As DataRow
        Dim dr1 As DataRow
        Dim firmakodu
        Dim firmaadi
        Dim stokkodu
        Dim stokadi
        Dim geneltoplam
        Dim aratoplam
        Dim carino
        Dim opsiyon = 0
        Dim personel
        Dim belgeno As String
        Dim tarih
        Dim odemetarihi
        Dim stokno
        Dim birimno
        Dim barkod
        Dim miktar
        Dim birim
        Dim kdv
        Dim isk1 = 0
        Dim isk2 = 0
        Dim isk3 = 0
        Dim isk4 = 0
        Dim iskonto1 = 0
        Dim iskonto2 = 0
        Dim iskonto3 = 0
        Dim iskonto4 = 0
        Dim alisfiyati = 0
        Dim fiyati = 0
        Dim gercektoplam = 0
        Dim iskontotoplami = 0
        Dim depono = 1
        Bar1.Properties.Maximum = DataSet2.Tables(0).Rows.Count
        Bar1.Position = 0
        For Each dr In DataSet2.Tables(0).Rows
            firmakodu = dr("FIRMAKODU")
            firmaadi = Microsoft.VisualBasic.Left(dr("FIRMAADI"), 20)
            firmakodu = firmakodu.Replace("'", " ")
            firmakodu = firmakodu.Replace(",", " ")
            firmakodu = firmakodu.Replace(".", " ")
            firmaadi = firmaadi.Replace("'", " ")
            firmaadi = firmaadi.Replace(",", " ")
            firmaadi = firmaadi.Replace(".", " ")
            geneltoplam = dr("GENELTOPLAM") + dr("TOPLAMKDV")
            'geneltoplam = (dr("GENELTOPLAM") - dr("TOPLAMISKONTO")) + dr("TOPLAMKDV")
            aratoplam = dr("ARATOPLAM")
            carino = dr("CARINO") 'query_carino(dr("FIRMAKODU"), dr("FIRMAADI"))
            opsiyon = dr("OPSIYON") 'query_opsiyon(dr("FIRMAKODU"), dr("FIRMAADI"))
            personel = dr("KOD") 'query_personel(dr("FIRMAKODU"), dr("FIRMAADI"))
            belgeno = dr("BELGENO") 'Microsoft.VisualBasic.Right(dr("BELGENO"), 8)
            tarih = dr("TARIH")
            odemetarihi = DateAdd(DateInterval.Day, opsiyon, tarih)
            'baslik(sorgu_query("*!F!DTBLSATFATBASLIK"), geneltoplam, belgeno, 0, 0, odemetarihi, tarih, 0, carino, "TL", 1, aratoplam, 21, "", dr("KOD"), "", 1, 0, firmaadi, 0)
            ds4 = query_FAT_HAREKET(belgeno, carino, tarih)
            For Each dr1 In ds4.Tables(0).Rows
                stokkodu = dr1("STOKKODU").ToString
                stokkodu = stokkodu.Replace("'", " ")
                stokkodu = stokkodu.Replace(",", " ")
                'stokkodu = stokkodu.Replace(".", " ")
                stokadi = dr1("STOKADI")
                stokadi = stokadi.Replace("'", " ")
                stokadi = stokadi.Replace(",", " ")
                stokadi = stokadi.Replace(".", " ")
                stokno = dr1("STOKNO")
                birimno = dr1("BIRIMEX") 'query_birimno(stokno) 'stokno 'dr1("BIRIMEX")
                barkod = stokkodu
                miktar = dr1("MIKTAR")
                birim = dr1("BIRIM")
                kdv = dr1("KDV")
                isk1 = CType(dr1("ISK1"), Decimal)
                isk2 = CType(dr1("ISK2"), Decimal)
                isk3 = CType(dr1("ISK3"), Decimal)
                isk4 = CType(dr1("ISK4"), Decimal)
                fiyati = CType(dr1("FIYAT"), Decimal)
                alisfiyati = fiyati
                iskontotoplami = isk1 + isk2 + isk3 + isk4
                If iskontotoplami = 0 Then
                    If dr1("ISKTUTAR") <> 0 Then
                        If miktar * fiyati = dr1("ISKTUTAR") Then
                            isk1 = 100
                        End If
                    End If
                End If
                'gercektoplam = dr("TOPLAM")
                iskonto1 = fiyati * ((100 - isk1) / 100)
                iskonto2 = iskonto1 * ((100 - isk2) / 100)
                iskonto3 = iskonto2 * ((100 - isk3) / 100)
                iskonto4 = iskonto3 * ((100 - isk4) / 100)
                If isk1 = 100 Then
                    gercektoplam = 0
                Else
                    gercektoplam = iskonto4 * miktar
                End If
                depono = dr1("DEPONO").ToString
                'hareket(1, sorgu_query("*!F!DTBLSATFATHAREKET"), 21, tarih, belgeno.ToString, carino, stokno, birimno, stokkodu.ToString, stokadi.ToString, barkod, 0, miktar, miktar, birim, kdv, isk1, isk2, isk3, isk4, alisfiyati, fiyati, gercektoplam, opsiyon, "TL", 1, 1, personel, 0, "")
            Next
            'toplam(1, tarih, carino, 21, geneltoplam, belgeno, "TL", 1, odemetarihi)
            Bar1.Position += 1
            Bar1.Refresh()
        Next
        XtraMessageBox.Show(Sorgu_sDil("Fatura Aktar˝m ›˛lemi Tamamland˝", sDil), Sorgu_sDil("Dikkat", sDil), MessageBoxButtons.OK, MessageBoxIcon.Information)
        Bar1.Position = 0
        Bar1.Refresh()
    End Sub
#Region "Fatura"
    Private Sub ekle_fatura(ByVal dteFisTarihi As DateTime, ByVal sFisTipi As String, ByVal sFiyatTipi As String)
        Dim nCariHareketID = 0
        Dim nStokFisiID As String = ""
        Dim sHareketTipi As String = ""
        Dim nGirisCikis As Integer = 1
        Dim lFisNo = 1
        Dim nFirmaID = 0
        Dim nStokID = 0
        Dim nIslemID = 0
        Dim nKayit = 0
        Dim sDepo As String = ""
        Dim sSaticiRumuzu As String = ""
        Dim nVadeGun As Integer = 0
        Dim cari_kayit_sayisi As Integer = 0
        Dim fis_kayit_sayisi As Integer = 0
        Dim lNetTutar As Decimal = 0
        Dim lGirisFiyat As Decimal = 0
        Dim lGirisTutar As Decimal = 0
        Dim lCikisFiyat As Decimal = 0
        Dim lCikisTutar As Decimal = 0
        Dim lGirisMiktar1 As Decimal = 0
        Dim lCikisMiktar1 As Decimal = 0
        Dim lBrutFiyat As Decimal = 0
        Dim lBrutTutar As Decimal = 0
        Dim lIskontoTutari As Decimal = 0
        Dim nIskontoYuzdesi As Decimal = 0
        Dim nKdvOrani As Decimal = 0
        Dim sAciklama As String = "Isk1:00.00 Isk2:00.00 Isk3:00.00 Isk4:00.00"
        Dim dr As DataRow
        Dim dr1 As DataRow
        If sFisTipi = "FA" Then
            nGirisCikis = 1
        ElseIf sFisTipi = "FS" Then
            nGirisCikis = 3
        End If
        Dim miktar As Decimal
        Dim isk1 As Decimal = 0
        Dim isk2 As Decimal = 0
        Dim isk3 As Decimal = 0
        Dim isk4 As Decimal = 0
        Dim iskonto1 As Decimal = 0
        Dim iskonto2 As Decimal = 0
        Dim iskonto3 As Decimal = 0
        Dim iskonto4 As Decimal = 0
        Dim alisfiyati = 0
        Dim fiyati = 0
        Dim gercektoplam = 0
        Dim iskontotoplami = 0
        Dim depono = 1
        Bar1.Position = 0
        Bar1.Properties.Maximum = DataSet2.Tables(0).Rows.Count
        For Each dr In DataSet2.Tables(0).Rows
            nFirmaID = sorgu_sayi(dr("CARINO"), 0)
            dteFisTarihi = dr("TARIH")
            lFisNo = dr("BELGENO")
            sSaticiRumuzu = sorgu_string(dr("KOD"), "")
            nVadeGun = sorgu_sayi(dr("OPSIYON"), 0)
            sFisTipi = Trim(dr("FISTIPI"))
            nGirisCikis = dr("GIRISCIKIS")
            fis_kayit_sayisi = sorgu_fis_kontrol(sFisTipi, nGirisCikis, dteFisTarihi, lFisNo, nFirmaID)
            If fis_kayit_sayisi = 0 Then
                If nStokFisiID = "" Then
                    'nStokFisiID = sorgu_nStokFisiID()
                    lFisNo = dr("BELGENO") 'sorgu_lFisNo(nFirmaID, sFisTipi)
                    sHareketTipi = ""
                    nStokFisiID = tbStokFisiMaster_kaydet_yeni(nStokFisiID, sFisTipi, dteFisTarihi, nGirisCikis, lFisNo, nFirmaID, "", Today, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, "", "", "", "", "", sHareketTipi, 0, 0, 0, "", "", 0, kullaniciadi, Now, "", 0, 0, 0, 0, 0, 0)
                    tbStokFisiAciklamasi_kaydet_yeni(nStokFisiID, "", "", "", "", "")
                    'tbStokFisiMaster_lFisno_degistir(nStokFisiID)
                End If
                Dim kayitsayisi = sorgu_tbAlisVerisAdres_kontrol(nStokFisiID)
                If kayitsayisi = 0 Then
                    tbAlisVerisAdres_kaydet_yeni(nStokFisiID, "", "", "", "", "", "", "", "", "", "")
                Else
                End If
            Else
                nStokFisiID = fis_kayit_sayisi.ToString
            End If
            ds4 = query_FAT_HAREKET(dr("BELGENO"), dr("CARINO"), dr("TARIH"))
            For Each dr1 In ds4.Tables(0).Rows
                nStokID = dr1("STOKNO")
                sDepo = "D001" 'dr1("sDepo")
                dr1("ISK1") = sorgu_sayi(dr1("ISK1"), 0)
                dr1("ISK2") = sorgu_sayi(dr1("ISK2"), 0)
                dr1("ISK3") = sorgu_sayi(dr1("ISK3"), 0)
                dr1("ISK4") = sorgu_sayi(dr1("ISK4"), 0)
                If dr1("ISK1") > 100 Then
                    dr1("ISK1") = 99.99
                ElseIf dr1("ISK1") = 100 Then
                    dr1("ISK1") = 99.99
                ElseIf dr1("ISK1") < 0 Then
                    dr1("ISK1") = 0
                End If
                If dr1("ISK2") > 100 Then
                    dr1("ISK2") = 99.99
                ElseIf dr1("ISK2") = 100 Then
                    dr1("ISK2") = 99.99
                ElseIf dr1("ISK2") < 0 Then
                    dr1("ISK2") = 0
                End If
                If dr1("ISK3") > 100 Then
                    dr1("ISK3") = 99.99
                ElseIf dr1("ISK3") = 100 Then
                    dr1("ISK3") = 99.99
                ElseIf dr1("ISK3") < 0 Then
                    dr1("ISK3") = 0
                End If
                If dr1("ISK4") > 100 Then
                    dr1("ISK4") = 99.99
                ElseIf dr1("ISK4") = 100 Then
                    dr1("ISK4") = 99.99
                ElseIf dr1("ISK4") < 0 Then
                    dr1("ISK4") = 0
                End If
                miktar = dr1("MIKTAR")
                isk1 = CType(dr1("ISK1"), Decimal)
                isk2 = CType(dr1("ISK2"), Decimal)
                isk3 = CType(dr1("ISK3"), Decimal)
                isk4 = CType(dr1("ISK4"), Decimal)
                fiyati = CType(dr1("FIYAT"), Decimal)
                alisfiyati = fiyati
                iskontotoplami = isk1 + isk2 + isk3 + isk4
                lIskontoTutari = sorgu_sayi(dr1("ISKTUTAR"), 0)
                If iskontotoplami = 0 Then
                    If dr1("ISKTUTAR") <> 0 Then
                        If miktar * fiyati = dr1("ISKTUTAR") Then
                            isk1 = 100
                        End If
                    End If
                End If
                'gercektoplam = dr("TOPLAM")
                iskonto1 = fiyati * ((100 - isk1) / 100)
                iskonto2 = iskonto1 * ((100 - isk2) / 100)
                iskonto3 = iskonto2 * ((100 - isk3) / 100)
                iskonto4 = iskonto3 * ((100 - isk4) / 100)
                If isk1 = 100 Then
                    gercektoplam = 0
                Else
                    gercektoplam = iskonto4 * miktar
                End If
                If sFisTipi = "FA" Or sFisTipi = "HA" Then
                    lGirisMiktar1 = sorgu_sayi(dr1("MIKTAR"), 0)
                    lGirisFiyat = gercektoplam
                    lGirisTutar = gercektoplam * miktar
                    lCikisMiktar1 = 0
                    lCikisFiyat = 0
                    lCikisTutar = 0
                    lBrutFiyat = sorgu_sayi(dr1("FIYAT"), 0)
                    lBrutTutar = sorgu_sayi(dr1("TOPLAM"), 0)
                ElseIf sFisTipi = "FS" Then
                    lGirisMiktar1 = 0
                    lGirisFiyat = 0
                    lGirisTutar = 0
                    lCikisMiktar1 = sorgu_sayi(dr1("MIKTAR"), 0)
                    lCikisFiyat = gercektoplam
                    lCikisTutar = gercektoplam * miktar
                    lBrutFiyat = sorgu_sayi(dr1("FIYAT"), 0)
                    lBrutTutar = sorgu_sayi(dr1("TOPLAM"), 0)
                End If
                Try
                    nIskontoYuzdesi = ((lBrutFiyat - iskonto4) / lBrutFiyat) * 100
                Catch ex As Exception
                    nIskontoYuzdesi = 0
                End Try
                nKdvOrani = sorgu_sayi(dr1("KDV"), 0)
                nIslemID = sorgu_nStokIslemID()
                sAciklama = "Isk1:" & uzunluk_tamamla(FormatNumber(dr1("ISK1"), 2), 5) & " Isk2:" & uzunluk_tamamla(FormatNumber(dr1("ISK2"), 2), 5) & " Isk3:" & uzunluk_tamamla(FormatNumber(dr1("ISK3"), 2), 5) & " Isk4:" & uzunluk_tamamla(FormatNumber(dr1("ISK4"), 2), 5)
                Try
                    tbStokFisidetay_fatura_kaydet_yeni(nIslemID, nStokID, dteFisTarihi, nFirmaID, 0, sFisTipi, dteFisTarihi, lFisNo, nGirisCikis, sDepo, 0, "", "", sSaticiRumuzu, "", dteFisTarihi, 0, lGirisMiktar1, 0, lGirisFiyat, lGirisTutar, lCikisMiktar1, "", 1, 0, lCikisFiyat, lCikisTutar, sFiyatTipi, lBrutFiyat, lBrutTutar, 0, 0, 0, nIskontoYuzdesi, lIskontoTutari, "", 0, "", 0, "", "", nKdvOrani, 0, sAciklama, sHareketTipi, 0, kullaniciadi, dteFisTarihi, "", 0, 0, "", 0, 0, 0, "", "", nStokFisiID, "", "", "", 0, 0, 0, 0, kullaniciadi, Now)
                    fis_detay_fisno_degistir(nIslemID)
                Catch ex As Exception
                    XtraMessageBox.Show(dr1("STOKKODU").ToString & Sorgu_sDil(" Aktar˝lamad˝", sDil), Sorgu_sDil("Dikkat", sDil), MessageBoxButtons.OK, MessageBoxIcon.Information)
                End Try
                Bar1.Position += 1
                Bar1.Refresh()
                bar1_text.Text = Bar1.Position
                bar1_text.Refresh()
            Next
            toplam_hesapla(nStokFisiID, sFisTipi, nGirisCikis, lFisNo, nFirmaID, dteFisTarihi, DateAdd(DateInterval.Day, nVadeGun, dteFisTarihi))
            nStokFisiID = ""
        Next
        Bar1.Position = 0
        Bar1.Refresh()
        XtraMessageBox.Show(Sorgu_sDil("Tamamland˝", sDil), Sorgu_sDil("Dikkat", sDil), MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub
    Private Sub toplam_hesapla(ByVal nStokFisiID As String, ByVal sFisTipi As String, ByVal nGirisCikis As Integer, ByVal lFisNo As Integer, ByVal nFirmaID As Integer, ByVal dteFisTarihi As DateTime, ByVal dteValorTarihi As DateTime)
        Dim dr As DataRow
        Dim dr_toplam As DataRow
        Dim lMiktar As Decimal
        Dim lMalbedeli As Decimal
        Dim lMalIskontoTutari As Decimal
        Dim nDipIskontoYuzdesi As Decimal
        Dim lDipIskontoTutari As Decimal
        Dim lPesinat As Decimal
        Dim lNetTutar As Decimal
        ds_toplam = sorgu_toplam(nStokFisiID)
        dr_toplam = ds_toplam.Tables(0).Rows(0)
        Dim sDovizCinsi1 As String = ""
        Dim lDovizKuru1 As Integer = 0
        Dim lDovizMiktari1 As Decimal = 0
        For Each dr In ds4.Tables(0).Rows
            If nGirisCikis = 1 Or nGirisCikis = 2 Then
                lMiktar += dr("MIKTAR")
            ElseIf nGirisCikis = 3 Or nGirisCikis = 4 Then
                lMiktar += dr("MIKTAR")
            End If
            lMalbedeli += sorgu_sayi(dr("TOPLAM"), 0)
            lMalIskontoTutari += sorgu_sayi(dr("ISKTUTAR"), 0) 'dr("lBrutTutar") * (dr("nIskontoYuzdesi") / 100)
        Next
        dr_toplam("lToplamMiktar") = lMiktar
        dr_toplam("lMalBedeli") = lMalbedeli
        dr_toplam("lMalIskontoTutari") = lMalIskontoTutari
        Try
            dr_toplam("nMalIskontoYuzdesi") = lMalIskontoTutari / lMalbedeli
        Catch ex As Exception
            dr_toplam("nMalIskontoYuzdesi") = 0
        End Try
        If dr_toplam("nDipIskontoYuzdesi1") > 0 Then
            dr_toplam("lDipIskontoTutari1") = (lMalbedeli - lMalIskontoTutari) * (dr_toplam("nDipIskontoYuzdesi1") / 100)
        Else
            dr_toplam("lDipIskontoTutari1") = 0
        End If
        If dr_toplam("nDipIskontoYuzdesi2") > 0 Then
            dr_toplam("lDipIskontoTutari2") = (lMalbedeli - lMalIskontoTutari - dr_toplam("lDipIskontoTutari1")) * (dr_toplam("nDipIskontoYuzdesi2") / 100)
        Else
            dr_toplam("lDipIskontoTutari2") = 0
        End If
        If dr_toplam("lDipIskontoTutari3") > 0 Then
            dr_toplam("nDipIskontoYuzdesi3") = dr_toplam("lDipIskontoTutari3") / (lMalbedeli - lMalIskontoTutari - dr_toplam("lDipIskontoTutari1") - dr_toplam("lDipIskontoTutari2")) * 100
        Else
            dr_toplam("nDipIskontoYuzdesi3") = 0
        End If
        dr_toplam("lDipIskontoTutari") = dr_toplam("lDipIskontoTutari1") + dr_toplam("lDipIskontoTutari2") + dr_toplam("lDipIskontoTutari3")
        Try
            dr_toplam("nDipIskontoYuzdesi") = dr_toplam("lDipIskontoTutari") / (lMalbedeli - lMalIskontoTutari)
        Catch ex As Exception
            dr_toplam("nDipIskontoYuzdesi") = 0
        End Try
        dr_toplam("lEkmaliyet") = dr_toplam("lEkmaliyet1") + dr_toplam("lEkmaliyet2") + dr_toplam("lEkmaliyet3")
        If dr_toplam("lEkmaliyet") > 0 Then
            dr_toplam("nEkmaliyetYuzdesi") = CType(dr_toplam("lEkmaliyet"), Decimal) / CType((lMalbedeli - lMalIskontoTutari - dr_toplam("lDipIskontoTutari")), Decimal)
        Else
            dr_toplam("nEkmaliyetYuzdesi") = 0
        End If
        'dr_toplam("lEkmaliyet2") = 0
        'dr_toplam("lEkmaliyet3") = 0
        Dim dr1 As DataRow
        If Trim(sFisTipi) <> "MM" Then
            dr_toplam("nKdvOrani1") = 0
            dr_toplam("lKdvMatrahi1") = 0
            dr_toplam("lKdv1") = 0
            dr_toplam("nKdvOrani2") = 0
            dr_toplam("lKdvMatrahi2") = 0
            dr_toplam("lKdv2") = 0
            dr_toplam("nKdvOrani3") = 0
            dr_toplam("lKdvMatrahi3") = 0
            dr_toplam("lKdv3") = 0
            dr_toplam("nKdvOrani4") = 0
            dr_toplam("lKdvMatrahi4") = 0
            dr_toplam("lKdv4") = 0
            dr_toplam("nKdvOrani5") = 0
            dr_toplam("lKdvMatrahi5") = 0
            dr_toplam("lKdv5") = 0
            dr_toplam("nTevkifatKdvOrani") = 0
            dr_toplam("lTevkifatKdvMatrahi") = 0
            dr_toplam("lTevkifatKdv") = 0
            dr_toplam("nOTVOrani1") = 0
            dr_toplam("lOTVMatrahi1") = 0
            dr_toplam("lOTV1") = 0
            dr_toplam("nOTVOrani2") = 0
            dr_toplam("lOTVMatrahi2") = 0
            'dr_toplam("lOTV2") = 
            ds_alislar_kdv = sorgu(sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT TOP 5 nKdvOrani, ISNULL(ROUND(SUM(lBrutTutar - lIskontoTutari), 2), 0) AS lKdvMatrahi, ISNULL(ROUND(SUM(lBrutTutar - lIskontoTutari) * nKdvOrani / 100, 2), 0) AS lKdv, ISNULL(ROUND(SUM(lBrutTutar), 2), 0) AS lNetTutar FROM tbStokFisiDetayi WHERE (nStokFisiID = '" & nStokFisiID & "') GROUP BY nKdvOrani ORDER BY nKdvOrani"))
            Dim sayi As Decimal = 0
            For Each dr1 In ds_alislar_kdv.Tables(0).Rows
                sayi += 1
                dr_toplam("nKdvOrani" & sayi & "") = dr1("nKdvOrani")
                dr_toplam("lKdvMatrahi" & sayi & "") = dr1("lKdvMatrahi")
                dr_toplam("lKdv" & sayi & "") = dr1("lKdv")
            Next
        Else
            'kesinti_hesapla()
            'dr_toplam("nKdvOrani1") = dr_kesinti("nKdvOrani1")
            'dr_toplam("lKdvMatrahi1") = dr_kesinti("lKdvMatrahi1")
            'dr_toplam("lKdv1") = dr_kesinti("lKdv1")
            'dr_toplam("nKdvOrani2") = dr_kesinti("nKdvOrani2")
            'dr_toplam("lKdvMatrahi2") = dr_kesinti("lKdvMatrahi2")
            'dr_toplam("lKdv2") = dr_kesinti("lKdv2")
            'dr_toplam("nKdvOrani3") = dr_kesinti("nKdvOrani3")
            'dr_toplam("lKdvMatrahi3") = dr_kesinti("lKdvMatrahi3")
            'dr_toplam("lKdv3") = dr_kesinti("lKdv3")
            'dr_toplam("nKdvOrani4") = dr_kesinti("nKdvOrani4")
            'dr_toplam("lKdvMatrahi4") = dr_kesinti("lKdvMatrahi4")
            'dr_toplam("lKdv4") = dr_kesinti("lKdv4")
            'dr_toplam("nKdvOrani5") = dr_kesinti("nKdvOrani5")
            'dr_toplam("lKdvMatrahi5") = dr_kesinti("lKdvMatrahi5")
            'dr_toplam("lKdv5") = dr_kesinti("lKdv5")
        End If
        dr1 = Nothing
        dr_toplam("lKdv") = dr_toplam("lKdv1") + dr_toplam("lKdv2") + dr_toplam("lKdv3") + dr_toplam("lKdv4") + dr_toplam("lKdv5")
        'lNetTutar = (lMalbedeli - lMalIskontoTutari - dr_toplam("lDipIskontoTutari1") - dr_toplam("lDipIskontoTutari2") - dr_toplam("lDipIskontoTutari3")) + (dr_toplam("lEkMaliyet1") + dr_toplam("lEkMaliyet2") + dr_toplam("lEkMaliyet3") + dr_toplam("lKdv"))
        If Trim(sFisTipi) <> "MM" Then
            lNetTutar = (lMalbedeli - lMalIskontoTutari - dr_toplam("lDipIskontoTutari1") - dr_toplam("lDipIskontoTutari2") - dr_toplam("lDipIskontoTutari3")) + (dr_toplam("lEkMaliyet1") + dr_toplam("lEkMaliyet2") + dr_toplam("lKdv"))
        Else
            lNetTutar = (lMalbedeli - lMalIskontoTutari - dr_toplam("lDipIskontoTutari1") - dr_toplam("lDipIskontoTutari2") - dr_toplam("lDipIskontoTutari3")) + (dr_toplam("lEkMaliyet1") + dr_toplam("lEkMaliyet2") - dr_toplam("lKdv"))
        End If
        dr_toplam("lTutar") = (lMalbedeli - lMalIskontoTutari - dr_toplam("lDipIskontoTutari1") - dr_toplam("lDipIskontoTutari2") - dr_toplam("lDipIskontoTutari3"))
        dr_toplam("lNetTutar") = lNetTutar
        dr_toplam("sYaziIle") = ygeneltoplam(Math.Abs(lNetTutar))
        tbStokFisiMaster_toplam_kaydet_degistir(nStokFisiID, dr_toplam("lToplamMiktar"), dr_toplam("lMalBedeli"), dr_toplam("lMalIskontoTutari"), dr_toplam("nDipIskontoYuzdesi1"), dr_toplam("lDipIskontoTutari1"), dr_toplam("nDipIskontoYuzdesi2"), dr_toplam("lDipIskontoTutari2"), dr_toplam("lDipIskontoTutari3"), dr_toplam("lEkmaliyet1"), dr_toplam("lEkmaliyet2"), dr_toplam("lEkmaliyet3"), dr_toplam("nKdvOrani1"), dr_toplam("lKdvMatrahi1"), dr_toplam("lKdv1"), dr_toplam("nKdvOrani2"), dr_toplam("lKdvMatrahi2"), dr_toplam("lKdv2"), dr_toplam("nKdvOrani3"), dr_toplam("lKdvMatrahi3"), dr_toplam("lKdv3"), dr_toplam("nKdvOrani4"), dr_toplam("lKdvMatrahi4"), dr_toplam("lKdv4"), dr_toplam("nKdvOrani5"), dr_toplam("lKdvMatrahi5"), dr_toplam("lKdv5"), dr_toplam("lNetTutar"), dr_toplam("nTevkifatKdvOrani"), dr_toplam("lTevkifatKdvMatrahi"), dr_toplam("lTevkifatKdv"), dr_toplam("nOTVOrani1"), dr_toplam("lOTVMatrahi1"), dr_toplam("lOTV1"), dr_toplam("nOTVOrani2"), dr_toplam("lOTVMatrahi2"), dr_toplam("lOTV2"), dr_toplam("sYaziIle"))
        'tbStokFisiOdemePlani_kaydet_duzelt(nStokFisiID, dr_baslik("dteValorTarihi"), dr_toplam("lNetTutar"), dr_baslik("sFisTipi"), "0")
        Dim lBorcTutar = 0
        Dim lAlacakTutar = 0
        Dim lDovizMiktar1 As Decimal = 0
        If nGirisCikis = 1 Then
            lBorcTutar = 0
            lAlacakTutar = Math.Abs(lNetTutar)
        ElseIf nGirisCikis = 2 Then
            lBorcTutar = Math.Abs(lNetTutar)
            lAlacakTutar = 0
        ElseIf nGirisCikis = 3 Then
            lBorcTutar = Math.Abs(lNetTutar)
            lAlacakTutar = 0
        ElseIf nGirisCikis = 4 Then
            lBorcTutar = 0
            lAlacakTutar = Math.Abs(lNetTutar)
        End If
        If sorgu_tbStokFisiTablo_kontrol(nStokFisiID, "tbStokFisiOdemePlani") = 0 Then
            Dim nHareketID As Int64
            nHareketID = sorgu_nCariHareketID()
            nHareketID = tbFirmaHareketi_kaydet_yeni(nHareketID, nFirmaID, dteFisTarihi, dteValorTarihi, sFisTipi, "Evrak No: " & lFisNo, lBorcTutar, lAlacakTutar, lFisNo, 0, sFisTipi, "", kullanici, Now, "", 0, 0, "", 0, 0, kullanici, Now)
            tbStokFisiOdemePlani_kaydet_yeni(nStokFisiID, dteFisTarihi, lNetTutar, sFisTipi, nHareketID)
            tbFirmaHareketi_nCariHareketID_degistir(nHareketID)
        End If
        'If Trim(sFisTipi) = "IA" Or Trim(sFisTipi) = "IS" Then
        '    'If dr_baslik("bFaturayaDonustumu") = False Then
        '    '    tbFirmaHareketi_kaydet_duzelt(nStokFisiID, dr_baslik("nFirmaID"), dr_baslik("dteFisTarihi"), dr_baslik("dteValorTarihi"), dr_baslik("sFisTipi"), "", lBorcTutar, lAlacakTutar, dr_baslik("lFisNo"), 0, dr_baslik("sFisTipi"), dr_baslik("sHareketTipi"), kullanici, Today, "", 0, 0, "", 0, 0, kullanici, Now)
        '    'End If
        'Else
        '    'tbStokFisiOdemePlani_kaydet_duzelt(nStokFisiID, dr_baslik("dteValorTarihi"), dr_toplam("lNetTutar"), dr_baslik("sFisTipi"), "0")
        '    tbFirmaHareketi_kaydet_duzelt(nStokFisiID, nFirmaID, dteFisTarihi, dteValorTarihi, sFisTipi, "", lBorcTutar, lAlacakTutar, lFisNo, 0, sFisTipi, "", kullanici, Today, sDovizCinsi1, lDovizMiktar1, lDovizKuru1, "", 0, 0, kullanici, Now, False)
        '    'tbFirmaHareketi_kaydet_yeni(nHareketID, nFirmaID, dr_baslik("dteFisTarihi"), dr_baslik("dteValorTarihi"), dr_baslik("sFisTipi"), "Evrak No: " & dr_baslik("lFisNo"), 0, 0, dr_baslik("lFisNo"), 0, dr_baslik("sFisTipi"), dr_baslik("sHareketTipi"), dr_baslik("sKullaniciAdi"), dr_baslik("dteKayitTarihi"), "", 0, 0, "", 0, 0, kullanici, Now, False, 0)
        '    tbStokFisiOdemePlani_kaydet_duzelt(nStokFisiID, dteValorTarihi, dr_toplam("lNetTutar"), sFisTipi, "0")
        'End If
        dr = Nothing
        dr1 = Nothing
        lMiktar = Nothing
        lMalbedeli = Nothing
        lMalIskontoTutari = Nothing
        nDipIskontoYuzdesi = Nothing
        lDipIskontoTutari = Nothing
        lPesinat = Nothing
        lNetTutar = Nothing
        lBorcTutar = Nothing
        lAlacakTutar = Nothing
    End Sub
    Public Function sorgu_tbStokFisiTablo_kontrol(ByVal nStokFisiID As String, ByVal Tablo As String) As Int64
        Dim kriter
        kriter = "WHERE (nStokFisiID = '" & nStokFisiID & "') "
        Dim con As New OleDb.OleDbConnection
        Dim cmd As New OleDb.OleDbCommand
        Dim adapter As New OleDb.OleDbDataAdapter
        con.ConnectionString = connection
        cmd.Connection = con
        con.Open()
        cmd.CommandText = sorgu_query("SET DATEFORMAT DMY SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT     ISNULL(COUNT(*), 0) AS KAYIT  FROM         " & Tablo & "  " & kriter & "")
        Dim kayitsayisi = cmd.ExecuteScalar
        Return kayitsayisi
        con.Dispose()
        cmd.Dispose()
        adapter.Dispose()
        cmd = Nothing
        adapter = Nothing
    End Function
    Public Function sorgu_nCariHareketID() As Int64
        Dim kriter As String = ""
        Dim con As New OleDb.OleDbConnection
        Dim cmd As New OleDb.OleDbCommand
        Dim adapter As New OleDb.OleDbDataAdapter
        con.ConnectionString = connection
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
    Private Sub tbFirmaHareketi_nCariHareketID_degistir(ByVal nCariHareketID As String)
        Dim con As New OleDb.OleDbConnection
        Dim cmd As New OleDb.OleDbCommand
        con.ConnectionString = connection
        cmd.Connection = con
        If con.State = ConnectionState.Closed Then
            con.Open()
        End If
        cmd.CommandText = sorgu_query("SET DATEFORMAT DMY SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED UPDATE    tbCariSiraNo SET              nSonID = '" & nCariHareketID & "' where nSiraIndex = 1")
        cmd.ExecuteNonQuery()
        con.Close()
        con.Dispose()
        cmd.Dispose()
        cmd = Nothing
    End Sub
    Private Sub tbStokFisiMaster_toplam_kaydet_degistir(ByVal nStokFisiID As String, ByVal lToplamMiktar As Decimal, ByVal lMalBedeli As Decimal, ByVal lMalIskontoTutari As Decimal, ByVal nDipIskontoYuzdesi1 As Decimal, ByVal lDipIskontoTutari1 As Decimal, ByVal nDipIskontoYuzdesi2 As Decimal, ByVal lDipIskontoTutari2 As Decimal, ByVal lDipIskontoTutari3 As Decimal, ByVal lEkmaliyet1 As Decimal, ByVal lEkmaliyet2 As Decimal, ByVal lEkmaliyet3 As Decimal, ByVal nKdvOrani1 As Decimal, ByVal lKdvMatrahi1 As Decimal, ByVal lKdv1 As Decimal, ByVal nKdvOrani2 As Decimal, ByVal lKdvMatrahi2 As Decimal, ByVal lKdv2 As Decimal, ByVal nKdvOrani3 As Decimal, ByVal lKdvMatrahi3 As Decimal, ByVal lKdv3 As Decimal, ByVal nKdvOrani4 As Decimal, ByVal lKdvMatrahi4 As Decimal, ByVal lKdv4 As Decimal, ByVal nKdvOrani5 As Decimal, ByVal lKdvMatrahi5 As Decimal, ByVal lKdv5 As Decimal, ByVal lNetTutar As Decimal, ByVal nTevkifatKdvOrani As Decimal, ByVal lTevkifatKdvMatrahi As Decimal, ByVal lTevkifatKdv As Decimal, ByVal nOTVOrani1 As Decimal, ByVal lOTVMatrahi1 As Decimal, ByVal lOTV1 As Decimal, ByVal nOTVOrani2 As Decimal, ByVal lOTVMatrahi2 As Decimal, ByVal lOTV2 As Decimal, ByVal sYaziIle As String)
        Dim cmd As New OleDb.OleDbCommand
        Dim con As New OleDb.OleDbConnection
        cmd.Connection = con
        con.ConnectionString = connection
        If con.State = ConnectionState.Closed = True Then
            con.Open()
        End If
        cmd.CommandText = sorgu_query("SET DATEFORMAT DMY SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED UPDATE    tbStokFisiMaster SET              lToplamMiktar = " & lToplamMiktar & ", lMalBedeli = " & lMalBedeli & ", lMalIskontoTutari = " & lMalIskontoTutari & ", nDipIskontoYuzdesi1 = " & nDipIskontoYuzdesi1 & ", lDipIskontoTutari1 = " & lDipIskontoTutari1 & ", nDipIskontoYuzdesi2 = " & nDipIskontoYuzdesi2 & ", lDipIskontoTutari2 = " & lDipIskontoTutari2 & ", lDipIskontoTutari3 = " & lDipIskontoTutari3 & ", lEkmaliyet1 = " & lEkmaliyet1 & ", lEkmaliyet2 = " & lEkmaliyet2 & ", lEkmaliyet3 = " & lEkmaliyet3 & ", nKdvOrani1 = " & nKdvOrani1 & ", lKdvMatrahi1 = " & lKdvMatrahi1 & ", lKdv1 = " & lKdv1 & ", nKdvOrani2 = " & nKdvOrani2 & ", lKdvMatrahi2 = " & lKdvMatrahi2 & ", lKdv2 = " & lKdv2 & ", nKdvOrani3 = " & nKdvOrani3 & ", lKdvMatrahi3 = " & lKdvMatrahi3 & ", lKdv3 = " & lKdv3 & ", nKdvOrani4 = " & nKdvOrani4 & ", lKdvMatrahi4 = " & lKdvMatrahi4 & ", lKdv4 = " & lKdv4 & ", nKdvOrani5 = " & nKdvOrani5 & ", lKdvMatrahi5 = " & lKdvMatrahi5 & ", lKdv5 = " & lKdv5 & ", lNetTutar = " & lNetTutar & ", nTevkifatKdvOrani = " & nTevkifatKdvOrani & ", lTevkifatKdvMatrahi = " & lTevkifatKdvMatrahi & ", lTevkifatKdv = " & lTevkifatKdv & ", nOTVOrani1 = " & nOTVOrani1 & ", lOTVMatrahi1 = " & lOTVMatrahi1 & ", lOTV1 = " & lOTV1 & ", nOTVOrani2 = " & nOTVOrani2 & ",lOTVMatrahi2 = " & lOTVMatrahi2 & ", lOTV2 = " & lOTV2 & ",sYaziIle= '" & sYaziIle & "',bFisTamamlandimi=1  WHERE nStokFisiID = '" & nStokFisiID & "'")
        cmd.ExecuteNonQuery()
        con.Close()
        con.Dispose()
        cmd.Dispose()
        con = Nothing
        cmd = Nothing
    End Sub
    Private Sub tbFirmaHareketi_kaydet_duzelt(ByVal nHareketID As Int64, ByVal nFirmaID As Int64, ByVal dteIslemTarihi As DateTime, ByVal dteValorTarihi As DateTime, ByVal sCariIslem As String, ByVal sAciklama As String, ByVal lBorcTutar As Decimal, ByVal lAlacakTutar As Decimal, ByVal sEvrakNo As String, ByVal lVadeFarki As Decimal, ByVal sHangiUygulama As String, ByVal sHareketTipi As String, ByVal sKullaniciAdi As String, ByVal dteKayitTarihi As DateTime, ByVal sDovizCinsi1 As String, ByVal lDovizMiktari1 As Decimal, ByVal lDovizKuru1 As Decimal, ByVal sDovizCinsi2 As String, ByVal lDovizMiktari2 As Decimal, ByVal lDovizKuru2 As Decimal, ByVal sSonKullaniciAdi As String, ByVal dteSonUpdateTarihi As DateTime, ByVal bPesinmi As Boolean, Optional ByVal nKasaIslemID As String = "0")
        Dim cmd As New OleDb.OleDbCommand
        Dim con As New OleDb.OleDbConnection
        cmd.Connection = con
        con.ConnectionString = connection
        If con.State = ConnectionState.Closed = True Then
            con.Open()
        End If
        cmd.CommandText = sorgu_query("SET DATEFORMAT DMY  UPDATE    tbFirmaHareketi SET              nFirmaID = '" & nFirmaID & "', dteIslemTarihi = '" & dteIslemTarihi & "', dteValorTarihi = '" & dteValorTarihi & "', sCariIslem = '" & sCariIslem & "', sAciklama = 'Evrak No: " & sEvrakNo & "', lBorcTutar = " & lBorcTutar & ", lAlacakTutar = " & lAlacakTutar & ", sEvrakNo = '" & sEvrakNo & "', lVadeFarki = " & lVadeFarki & ", sHangiUygulama = '" & sHangiUygulama & "', sHareketTipi = '" & sHareketTipi & "', sDovizCinsi1 = '" & sDovizCinsi1 & "', lDovizMiktari1 = " & lDovizMiktari1 & ", lDovizKuru1 = " & lDovizKuru1 & ", sDovizCinsi2 = '" & sDovizCinsi2 & "', lDovizMiktari2 = " & lDovizMiktari2 & ", lDovizKuru2 = " & lDovizKuru2 & ", sSonKullaniciAdi = '" & sSonKullaniciAdi & "', dteSonUpdateTarihi = '" & dteSonUpdateTarihi & "'  WHERE     (nHareketID IN  (SELECT     nCariHareketID FROM          tbStokFisiOdemePlani WHERE      (nStokFisiID = '" & nHareketID & "' )))")
        cmd.ExecuteNonQuery()
        'If bPesinmi = True Then
        '    If nKasaIslemID <> "" Then
        '        tbNakitKasa_kaydet_duzelt(nKasaIslemID, "001", dteIslemTarihi, lBorcTutar, lAlacakTutar, "Pesin Fatura No :" & sEvrakNo & " - " & Microsoft.VisualBasic.Left(Trim(dr_baslik("sAciklama").ToString), 20), nHareketID, nFirmaID, 0, sHangiUygulama, sHareketTipi, kullanici, dr_baslik("dteKayitTarihi"), 0, "", sDovizCinsi1, lDovizMiktari1, lDovizKuru1, sDovizCinsi2, lDovizMiktari2, lDovizKuru2, kullanici, Now)
        '        cmd.CommandText = sorgu_query("SET DATEFORMAT DMY  UPDATE    tbFirmaHareketi SET              nFirmaID = '" & nFirmaID & "', dteIslemTarihi = '" & dteIslemTarihi & "', dteValorTarihi = '" & dteValorTarihi & "', sCariIslem = 'N', sAciklama = '" & "Pesin Fatura No :" & sEvrakNo & " - " & Microsoft.VisualBasic.Left(Trim(dr_baslik("sAciklama").ToString), 20) & "', lBorcTutar = " & lAlacakTutar & ", lAlacakTutar = " & lBorcTutar & ", sEvrakNo = '', lVadeFarki = " & lVadeFarki & ", sHangiUygulama = 'KASA', sHareketTipi = '" & sHareketTipi & "', sDovizCinsi1 = '" & sDovizCinsi1 & "', lDovizMiktari1 = " & lDovizMiktari1 & ", lDovizKuru1 = " & lDovizKuru1 & ", sDovizCinsi2 = '" & sDovizCinsi2 & "', lDovizMiktari2 = " & lDovizMiktari2 & ", lDovizKuru2 = " & lDovizKuru2 & ", sSonKullaniciAdi = '" & sSonKullaniciAdi & "', dteSonUpdateTarihi = '" & dteSonUpdateTarihi & "'  WHERE     (nHareketID IN  (SELECT     nCariHareketID FROM          tbNakitKasa WHERE      (nKasaIslemID = '" & nKasaIslemID & "' )))")
        '        cmd.ExecuteNonQuery()
        '    End If
        'End If
        con.Close()
        con.Dispose()
        cmd.Dispose()
        con = Nothing
        cmd = Nothing
    End Sub
    Private Function tbFirmaHareketi_kaydet_yeni(ByVal nHareketID As Int64, ByVal nFirmaID As Int64, ByVal dteIslemTarihi As DateTime, ByVal dteValorTarihi As DateTime, ByVal sCariIslem As String, ByVal sAciklama As String, ByVal lBorcTutar As Decimal, ByVal lAlacakTutar As Decimal, ByVal sEvrakNo As String, ByVal lVadeFarki As Decimal, ByVal sHangiUygulama As String, ByVal sHareketTipi As String, ByVal sKullaniciAdi As String, ByVal dteKayitTarihi As DateTime, ByVal sDovizCinsi1 As String, ByVal lDovizMiktari1 As Decimal, ByVal lDovizKuru1 As Decimal, ByVal sDovizCinsi2 As String, ByVal lDovizMiktari2 As Decimal, ByVal lDovizKuru2 As Decimal, ByVal sSonKullaniciAdi As String, ByVal dteSonUpdateTarihi As DateTime, Optional ByVal sDatabase As String = "") As Int64
        Dim use As String = ""
        If sDatabase <> "" Then
            use = "USE " & sDatabase
        End If
        Dim con As New OleDb.OleDbConnection
        Dim cmd As New OleDb.OleDbCommand
        cmd.Connection = con
        con.ConnectionString = connection
        If con.State = ConnectionState.Closed = True Then
            con.Open()
        End If
        cmd.CommandText = sorgu_query("" & use & " SET DATEFORMAT DMY  INSERT INTO tbFirmaHareketi                       (nFirmaID, dteIslemTarihi, dteValorTarihi, sCariIslem, sAciklama, lBorcTutar, lAlacakTutar, sEvrakNo, lVadeFarki, sHangiUygulama, sHareketTipi, sKullaniciAdi, dteKayitTarihi, sDovizCinsi1, lDovizMiktari1, lDovizKuru1, sDovizCinsi2, lDovizMiktari2, lDovizKuru2, sSonKullaniciAdi, dteSonUpdateTarihi) VALUES     ('" & nFirmaID & "', '" & dteIslemTarihi & "', '" & dteValorTarihi & "', '" & sCariIslem & "', N'" & sAciklama & "', " & lBorcTutar & ", " & lAlacakTutar & " , '" & sEvrakNo & "', " & lVadeFarki & ", '" & sHangiUygulama & "', '" & sHareketTipi & "', '" & sKullaniciAdi & "', '" & dteKayitTarihi & "', '" & sDovizCinsi1 & "', " & lDovizMiktari1 & ", " & lDovizKuru1 & " , '" & sDovizCinsi2 & "', " & lDovizMiktari2 & ", " & lDovizKuru2 & " , '" & sSonKullaniciAdi & "', '" & dteSonUpdateTarihi & "')")
        cmd.ExecuteNonQuery()
        cmd.CommandText = "SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT @@identity"
        nHareketID = cmd.ExecuteScalar
        Return nHareketID
        con.Close()
        cmd = Nothing
        con = Nothing
    End Function
    Private Sub tbStokFisiOdemePlani_kaydet_yeni(ByVal nStokFisiID As String, ByVal dteVadeTarihi As DateTime, ByVal lTutari As Decimal, ByVal sCariIslem As String, ByVal nCariHareketID As String)
        Dim cmd As New OleDb.OleDbCommand
        Dim con As New OleDb.OleDbConnection
        cmd.Connection = con
        con.ConnectionString = connection
        If con.State = ConnectionState.Closed = True Then
            con.Open()
        End If
        cmd.CommandText = sorgu_query("SET DATEFORMAT DMY  INSERT INTO tbStokFisiOdemePlani                       (nStokFisiID, dteVadeTarihi, lTutari, sCariIslem, nCariHareketID) VALUES     ('" & nStokFisiID & "', '" & dteVadeTarihi & "', " & lTutari & ", '" & sCariIslem & "', '" & nCariHareketID & "')")
        cmd.ExecuteNonQuery()
        con.Close()
        con.Dispose()
        cmd.Dispose()
        con = Nothing
        cmd = Nothing
    End Sub
    Private Sub tbStokFisiOdemePlani_kaydet_duzelt(ByVal nStokFisiID As String, ByVal dteVadeTarihi As DateTime, ByVal lTutari As Decimal, ByVal sCariIslem As String, ByVal nCariHareketID As String)
        Dim cmd As New OleDb.OleDbCommand
        Dim con As New OleDb.OleDbConnection
        cmd.Connection = con
        con.ConnectionString = connection
        If con.State = ConnectionState.Closed = True Then
            con.Open()
        End If
        cmd.CommandText = sorgu_query("SET DATEFORMAT DMY  UPDATE    tbStokFisiOdemePlani SET              dteVadeTarihi = '" & dteVadeTarihi & "', lTutari = '" & lTutari & "', sCariIslem = '" & sCariIslem & "' WHERE     (nStokFisiID = '" & nStokFisiID & "') ")
        cmd.ExecuteNonQuery()
        con.Close()
        con.Dispose()
        cmd.Dispose()
        con = Nothing
        cmd = Nothing
    End Sub
    Private Function sorgu_toplam(ByVal nStokFisiID As String) As DataSet
        Dim cmd As New OleDb.OleDbCommand
        Dim con As New OleDb.OleDbConnection
        Dim adapter As New OleDb.OleDbDataAdapter
        con.ConnectionString = connection
        adapter.SelectCommand = cmd
        Dim sorgu_txt_toplam As String = ""
        'cmd.CommandText = sorgu_query("SET DATEFORMAT DMY SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT nStokFisiID, lToplamMiktar, lMalBedeli, lMalIskontoTutari,CAST(0 AS money) AS nMalIskontoYuzdesi, nDipIskontoYuzdesi1, lDipIskontoTutari1, nDipIskontoYuzdesi2, lDipIskontoTutari2, lDipIskontoTutari3, CAST(0 AS money) AS nDipIskontoYuzdesi3, lDipIskontoTutari1+lDipIskontoTutari2+lDipIskontoTutari3 as lDipIskontoTutari,CAST(0 AS money) AS nDipIskontoYuzdesi,lEkmaliyet1, lEkmaliyet2, lEkmaliyet3,lEkmaliyet1+lEkmaliyet2+lEkmaliyet3 as lEkmaliyet,CAST(0 AS money) AS nEkmaliyetYuzdesi, nKdvOrani1, lKdvMatrahi1, lKdv1, nKdvOrani2, lKdvMatrahi2, lKdv2, nKdvOrani3, lKdvMatrahi3, lKdv3, nKdvOrani4, lKdvMatrahi4, lKdv4, nKdvOrani5, lKdvMatrahi5, lKdv5, lNetTutar, nTevkifatKdvOrani, lTevkifatKdvMatrahi, lTevkifatKdv, sYaziIle, nOTVOrani1, lOTVMatrahi1, lOTV1, nOTVOrani2, lOTVMatrahi2, lOTV2, lKdv1 + lKdv2 + lKdv3 + lKdv4 + lKdv5 AS lKdv FROM tbStokFisiMaster WHERE (nStokFisiID =  '" & nStokFisiID & "')")
        cmd.CommandText = sorgu_query("SET DATEFORMAT DMY SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT nStokFisiID, lToplamMiktar, lMalBedeli, lMalIskontoTutari,CAST(0 AS money) AS nMalIskontoYuzdesi, nDipIskontoYuzdesi1, lDipIskontoTutari1, nDipIskontoYuzdesi2, lDipIskontoTutari2, lDipIskontoTutari3, CAST(0 AS money) AS nDipIskontoYuzdesi3, lDipIskontoTutari1+lDipIskontoTutari2+lDipIskontoTutari3 as lDipIskontoTutari,CAST(0 AS money) AS nDipIskontoYuzdesi,lEkmaliyet1, lEkmaliyet2, lEkmaliyet3,lEkmaliyet1+lEkmaliyet2+lEkmaliyet3 as lEkmaliyet,(SELECT ISNULL(SUM(lTutar) , 0) FROM tbStokFisiEkMaliyet WHERE nStokFisiID = tbStokFisiMaster.nStokFisiID and nIslemID =0) AS lEkMaliyet4,(SELECT ISNULL(SUM(lTutar) , 0) FROM tbStokFisiEkMaliyet WHERE nStokFisiID = tbStokFisiMaster.nStokFisiID and nIslemID > 0) AS lEkMaliyet5, CAST(0 AS money) AS nEkmaliyetYuzdesi, nKdvOrani1, lKdvMatrahi1, lKdv1, nKdvOrani2, lKdvMatrahi2, lKdv2, nKdvOrani3, lKdvMatrahi3, lKdv3, nKdvOrani4, lKdvMatrahi4, lKdv4, nKdvOrani5, lKdvMatrahi5, lKdv5, lNetTutar, nTevkifatKdvOrani, lTevkifatKdvMatrahi, lTevkifatKdv, sYaziIle, nOTVOrani1, lOTVMatrahi1, lOTV1, nOTVOrani2, lOTVMatrahi2, lOTV2, lKdv1 + lKdv2 + lKdv3 + lKdv4 + lKdv5 AS lKdv,(lMalBedeli) - (lMalIskontoTutari + lDipIskontoTutari1 + lDipIskontoTutari2 + lDipIskontoTutari3) AS lTutar FROM tbStokFisiMaster WHERE (nStokFisiID =  '" & nStokFisiID & "')")
        sorgu_txt_toplam = cmd.CommandText
        cmd.Connection = con
        con.Open()
        Dim DS As New DataSet
        Dim N As Integer = adapter.Fill(DS, "TOPLAM")
        con.Close()
        con.Dispose()
        cmd.Dispose()
        con = Nothing
        cmd = Nothing
        Return DS
    End Function
    Private Function uzunluk_tamamla(ByVal deger As String, ByVal uzunluk As Int64, Optional ByVal simge As String = "0") As String
        'deger = FormatNumber(deger, 2)
        If Len(deger) < uzunluk Then
            Dim fark As Integer = uzunluk - Len(deger)
            Dim i As Integer
            For i = 1 To fark
                deger = deger.Insert(0, simge)
            Next
        End If
        Return deger
    End Function
    Public Function sorgu_fis_kontrol(ByVal sFistipi As String, ByVal nGirisCikis As String, ByVal dteFisTarihi As DateTime, ByVal lFisno As String, ByVal nFirmaID As String, Optional ByVal resmi As Boolean = True, Optional ByVal sDatabase As String = "") As Int64
        Dim use As String = ""
        If sDatabase <> "" Then
            use = "USE " & sDatabase
        End If
        Dim kriter
        kriter = "WHERE (sFisTipi = '" & sFistipi & "') and (dteFisTarihi = '" & dteFisTarihi & "') and (lFisNo = '" & lFisno & "') and (nFirmaID= '" & nFirmaID & "') and (nGirisCikis = '" & nGirisCikis & "')  "
        Dim conn As New OleDb.OleDbConnection
        Dim cmd As New OleDb.OleDbCommand
        Dim adapter As New OleDb.OleDbDataAdapter
        'MsgBox(connection_resmi)
        If resmi = True Then
            conn.ConnectionString = connection
        ElseIf resmi = False Then
            conn.ConnectionString = connection
        End If
        cmd.Connection = conn
        conn.Open()
        cmd.CommandText = sorgu_query("" & use & " SET DATEFORMAT DMY SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT     ISNULL(nStokFisiID, 0) AS KAYIT FROM         tbStokFisiMaster " & kriter & "")
        Dim kayitsayisi = cmd.ExecuteScalar
        conn.Close()
        cmd = Nothing
        conn = Nothing
        adapter = Nothing
        Return kayitsayisi
        cmd = Nothing
        conn = Nothing
    End Function
    Public Function sorgu_nStokFisiID(Optional ByVal sDatabase As String = "") As Int64
        Dim use As String = ""
        If sDatabase <> "" Then
            use = "USE " & sDatabase
        End If
        Dim kriter As String = ""
        Dim conn As New OleDb.OleDbConnection
        Dim cmd As New OleDb.OleDbCommand
        Dim adapter As New OleDb.OleDbDataAdapter
        conn.ConnectionString = connection
        cmd.Connection = conn
        conn.Open()
        cmd.CommandText = sorgu_query("" & use & " SET DATEFORMAT DMY SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT     ISNULL(MAX(nStokFisiID), 1) + 1 AS nStokFisiID FROM         tbStokFisiMaster")
        Dim kayitsayisi = cmd.ExecuteScalar
        Return kayitsayisi
        cmd = Nothing
        conn = Nothing
        adapter = Nothing
    End Function
    Public Function sorgu_nStokIslemID(Optional ByVal sDatabase As String = "") As Int64
        Dim use As String = ""
        If sDatabase <> "" Then
            use = "USE " & sDatabase
        End If
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
        cmd.CommandText = sorgu_query("" & use & " SET DATEFORMAT DMY SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT     ISNULL(MAX(nIslemID), 0) + 1 AS nStokIslemID FROM         tbStokFisiDetayi")
        Dim kayitsayisi = cmd.ExecuteScalar
        If kayitsayisi = 0 Then
            kayitsayisi = 1
        End If
        Return kayitsayisi
        conn = Nothing
        cmd = Nothing
        adapter = Nothing
    End Function
    Private Function tbStokFisiMaster_kaydet_yeni(ByVal nStokFisiID As Int64, ByVal sFisTipi As String, ByVal dteFisTarihi As DateTime, ByVal nGirisCikis As Int64, ByVal lFisNo As Int64, ByVal nFirmaID As Int64, ByVal sDepo As String, ByVal dteValorTarihi As DateTime, ByVal bPesinmi As Byte, ByVal bListelendimi As Byte, ByVal bHizmetFaturasimi As Byte, ByVal lToplamMiktar As Decimal, ByVal lMalBedeli As Decimal, ByVal lMalIskontoTutari As Decimal, ByVal nDipIskontoYuzdesi1 As Decimal, ByVal lDipIskontoTutari1 As Decimal, ByVal nDipIskontoYuzdesi2 As Decimal, ByVal lDipIskontoTutari2 As Decimal, ByVal lDipIskontoTutari3 As Decimal, ByVal lEkmaliyet1 As Decimal, ByVal lEkmaliyet2 As Decimal, ByVal lEkmaliyet3 As Decimal, ByVal nKdvOrani1 As Decimal, ByVal lKdvMatrahi1 As Decimal, ByVal lKdv1 As Decimal, ByVal nKdvOrani2 As Decimal, ByVal lKdvMatrahi2 As Decimal, ByVal lKdv2 As Decimal, ByVal nKdvOrani3 As Decimal, ByVal lKdvMatrahi3 As Decimal, ByVal lKdv3 As Decimal, ByVal nKdvOrani4 As Decimal, ByVal lKdvMatrahi4 As Decimal, ByVal lKdv4 As Decimal, ByVal nKdvOrani5 As Decimal, ByVal lKdvMatrahi5 As Decimal, ByVal lKdv5 As Decimal, ByVal lNetTutar As Decimal, ByVal nTevkifatKdvOrani As Decimal, ByVal lTevkifatKdvMatrahi As Decimal, ByVal lTevkifatKdv As Decimal, ByVal sCariIslem As String, ByVal nCariHareketID As String, ByVal nKasaIslemID As String, ByVal sCariKdvIslem As String, ByVal nCariKdvHareketID As String, ByVal sHareketTipi As String, ByVal bMuhasebeyeIslendimi As Byte, ByVal bFisTamamlandimi As Byte, ByVal lTransferFisiID As String, ByVal nTransferFirmaID As String, ByVal sTransferDepo As String, ByVal bFaturayaDonustumu As Byte, ByVal sKullaniciAdi As String, ByVal dteKayitTarihi As DateTime, ByVal sYaziIle As String, ByVal nOTVOrani1 As Decimal, ByVal lOTVMatrahi1 As Decimal, ByVal lOTV1 As Decimal, ByVal nOTVOrani2 As Decimal, ByVal lOTVMatrahi2 As Decimal, ByVal lOTV2 As Decimal, Optional ByVal sDatabase As String = "") As Int64
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
        'cmd.CommandText = sorgu_query("SET DATEFORMAT DMY INSERT INTO tbStokFisiMaster (sFisTipi, dteFisTarihi, nGirisCikis, lFisNo, nFirmaID, sDepo, dteValorTarihi, bPesinmi, bListelendimi, bHizmetFaturasimi, lToplamMiktar, lMalBedeli, lMalIskontoTutari, nDipIskontoYuzdesi1, lDipIskontoTutari1, nDipIskontoYuzdesi2, lDipIskontoTutari2, lDipIskontoTutari3, lEkmaliyet1, lEkmaliyet2, lEkmaliyet3, nKdvOrani1, lKdvMatrahi1, lKdv1, nKdvOrani2, lKdvMatrahi2, lKdv2, nKdvOrani3, lKdvMatrahi3, lKdv3, nKdvOrani4, lKdvMatrahi4, lKdv4, nKdvOrani5, lKdvMatrahi5, lKdv5, lNetTutar, nTevkifatKdvOrani, lTevkifatKdvMatrahi, lTevkifatKdv, sCariIslem, nCariHareketID, nKasaIslemID, sCariKdvIslem, nCariKdvHareketID, sHareketTipi, bMuhasebeyeIslendimi, bFisTamamlandimi, lTransferFisiID, nTransferFirmaID, sTransferDepo, bFaturayaDonustumu, sKullaniciAdi, dteKayitTarihi, sYaziIle, nOTVOrani1, lOTVMatrahi1, lOTV1, nOTVOrani2, lOTVMatrahi2, lOTV2) VALUES     ('" & sFisTipi & "', '" & dteFisTarihi & "', " & nGirisCikis & " , '" & lFisNo & "', " & nFirmaID & ", '" & sDepo & "', '" & dteValorTarihi & "', " & bPesinmi & " , " & bListelendimi & " , " & bHizmetFaturasimi & " , " & lToplamMiktar & " , " & lMalBedeli & ", " & lMalIskontoTutari & " , " & nDipIskontoYuzdesi1 & " , " & lDipIskontoTutari1 & " , " & nDipIskontoYuzdesi2 & " , " & lDipIskontoTutari2 & " , " & lDipIskontoTutari3 & " , " & lEkmaliyet1 & " , " & lEkmaliyet2 & " , " & lEkmaliyet3 & " , " & nKdvOrani1 & " , " & lKdvMatrahi1 & ", " & lKdv1 & " , " & nKdvOrani2 & ", " & lKdvMatrahi2 & " , " & lKdv2 & ", " & nKdvOrani3 & " , " & lKdvMatrahi3 & ", " & lKdv3 & " , " & nKdvOrani4 & ", " & lKdvMatrahi4 & " , " & lKdv4 & " , " & nKdvOrani5 & " , " & lKdvMatrahi5 & " , " & lKdv5 & " , " & lNetTutar & " , " & nTevkifatKdvOrani & " , " & lTevkifatKdvMatrahi & ", " & lTevkifatKdv & " , '" & sCariIslem & "', '" & nCariHareketID & "', '" & nKasaIslemID & "', '" & sCariKdvIslem & "', '" & nCariKdvHareketID & "', '" & sHareketTipi & "', " & bMuhasebeyeIslendimi & ", " & bFisTamamlandimi & ", '" & lTransferFisiID & "', '" & nTransferFirmaID & "', '" & sTransferDepo & "', " & bFaturayaDonustumu & " , '" & sKullaniciAdi & "', '" & dteKayitTarihi & "', '" & sYaziIle & "', " & nOTVOrani1 & ", " & lOTVMatrahi1 & ", " & lOTV1 & ", " & nOTVOrani2 & " , " & lOTVMatrahi2 & ", " & lOTV2 & ")")
        cmd.CommandText = sorgu_query("" & use & " SET DATEFORMAT DMY INSERT INTO tbStokFisiMaster (sFisTipi, dteFisTarihi, nGirisCikis, lFisNo, nFirmaID, sDepo, dteValorTarihi, bPesinmi, bListelendimi, bHizmetFaturasimi, lToplamMiktar, lMalBedeli, lMalIskontoTutari, nDipIskontoYuzdesi1, lDipIskontoTutari1, nDipIskontoYuzdesi2, lDipIskontoTutari2, lDipIskontoTutari3, lEkmaliyet1, lEkmaliyet2, lEkmaliyet3, nKdvOrani1, lKdvMatrahi1, lKdv1, nKdvOrani2, lKdvMatrahi2, lKdv2, nKdvOrani3, lKdvMatrahi3, lKdv3, nKdvOrani4, lKdvMatrahi4, lKdv4, nKdvOrani5, lKdvMatrahi5, lKdv5, lNetTutar, nTevkifatKdvOrani, lTevkifatKdvMatrahi, lTevkifatKdv, sHareketTipi, bMuhasebeyeIslendimi, bFisTamamlandimi, lTransferFisiID,  sTransferDepo, bFaturayaDonustumu, sKullaniciAdi, dteKayitTarihi, sYaziIle, nOTVOrani1, lOTVMatrahi1, lOTV1, nOTVOrani2, lOTVMatrahi2, lOTV2) VALUES     ('" & sFisTipi & "', '" & dteFisTarihi & "', " & nGirisCikis & " , '" & lFisNo & "', " & nFirmaID & ", '" & sDepo & "', '" & dteValorTarihi & "', " & bPesinmi & " , " & bListelendimi & " , " & bHizmetFaturasimi & " , " & lToplamMiktar & " , " & lMalBedeli & ", " & lMalIskontoTutari & " , " & nDipIskontoYuzdesi1 & " , " & lDipIskontoTutari1 & " , " & nDipIskontoYuzdesi2 & " , " & lDipIskontoTutari2 & " , " & lDipIskontoTutari3 & " , " & lEkmaliyet1 & " , " & lEkmaliyet2 & " , " & lEkmaliyet3 & " , " & nKdvOrani1 & " , " & lKdvMatrahi1 & ", " & lKdv1 & " , " & nKdvOrani2 & ", " & lKdvMatrahi2 & " , " & lKdv2 & ", " & nKdvOrani3 & " , " & lKdvMatrahi3 & ", " & lKdv3 & " , " & nKdvOrani4 & ", " & lKdvMatrahi4 & " , " & lKdv4 & " , " & nKdvOrani5 & " , " & lKdvMatrahi5 & " , " & lKdv5 & " , " & lNetTutar & " , " & nTevkifatKdvOrani & " , " & lTevkifatKdvMatrahi & ", " & lTevkifatKdv & " ,  '" & sHareketTipi & "', " & bMuhasebeyeIslendimi & ", " & bFisTamamlandimi & ", '" & lTransferFisiID & "',  '" & sTransferDepo & "', " & bFaturayaDonustumu & " , '" & sKullaniciAdi & "', '" & dteKayitTarihi & "', '" & sYaziIle & "', " & nOTVOrani1 & ", " & lOTVMatrahi1 & ", " & lOTV1 & ", " & nOTVOrani2 & " , " & lOTVMatrahi2 & ", " & lOTV2 & ")")
        cmd.ExecuteNonQuery()
        cmd.CommandText = "SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT @@identity"
        nStokFisiID = cmd.ExecuteScalar
        Return nStokFisiID
        con.Close()
        cmd = Nothing
        con = Nothing
    End Function
    Private Sub tbStokFisiAciklamasi_kaydet_yeni(ByVal nStokFisiID As String, ByVal sAciklama1 As String, ByVal sAciklama2 As String, ByVal sAciklama3 As String, ByVal sAciklama4 As String, ByVal sAciklama5 As String, Optional ByVal sDatabase As String = "")
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
        cmd.CommandText = sorgu_query("" & use & " SET DATEFORMAT DMY INSERT INTO tbStokFisiAciklamasi                       (nStokFisiID, sAciklama1, sAciklama2, sAciklama3, sAciklama4, sAciklama5) VALUES     ('" & nStokFisiID & "', '" & sAciklama1 & "', '" & sAciklama2 & "', '" & sAciklama3 & "', '" & sAciklama4 & "', '" & sAciklama5 & "')")
        cmd.ExecuteNonQuery()
        con.Close()
        cmd = Nothing
        con = Nothing
    End Sub
    Private Sub tbStokFisiMaster_lFisno_degistir(ByVal nstokFisiID As String, Optional ByVal sDatabase As String = "")
        Dim use As String = ""
        If sDatabase <> "" Then
            use = "USE " & sDatabase
        End If
        Dim cmd As New OleDb.OleDbCommand
        Dim con As New OleDb.OleDbConnection
        con.ConnectionString = connection
        cmd.Connection = con
        If con.State = ConnectionState.Closed Then
            con.Open()
        End If
        cmd.CommandText = sorgu_query("" & use & " SET DATEFORMAT DMY SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED UPDATE    tbStokSiraNo SET              nSonID = '" & nstokFisiID & "' where nSiraIndex = 2")
        cmd.ExecuteNonQuery()
        con.Close()
        cmd = Nothing
        con = Nothing
    End Sub
    Public Function sorgu_tbAlisVerisAdres_kontrol(ByVal nAlisVerisID As String, Optional ByVal sDatabase As String = "") As Int64
        Dim use As String = ""
        If sDatabase <> "" Then
            use = "USE " & sDatabase
        End If
        Dim kriter
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
        cmd.CommandText = sorgu_query("" & use & " SET DATEFORMAT DMY SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT     ISNULL(COUNT(*), 0) AS KAYIT FROM         tbAlisVerisAdres " & kriter & "")
        Dim kayitsayisi = cmd.ExecuteScalar
        Return kayitsayisi
        conn = Nothing
        cmd = Nothing
        adapter = Nothing
    End Function
    Private Sub tbAlisVerisAdres_kaydet_yeni(ByVal nAlisVerisID As String, ByVal sAciklama As String, ByVal sAdres1 As String, ByVal sAdres2 As String, ByVal sSemt As String, ByVal sIl As String, ByVal sUlke As String, ByVal sPostaKodu As String, ByVal sVergiDairesi As String, ByVal sVergiNo As String, ByVal sSubeMagaza As String, Optional ByVal sDatabase As String = "")
        Dim use As String = ""
        If sDatabase <> "" Then
            use = "USE " & sDatabase
        End If
        Dim con As New OleDb.OleDbConnection
        Dim cmd As New OleDb.OleDbCommand
        cmd.Connection = con
        con.ConnectionString = connection
        If con.State = ConnectionState.Closed = True Then
            con.Open()
        End If
        cmd.CommandText = sorgu_query("" & use & " SET DATEFORMAT DMY SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED INSERT INTO tbAlisVerisAdres (nAlisVerisID, sAciklama, sAdres1, sAdres2, sSemt, sIl, sUlke, sPostaKodu, sVergiDairesi, sVergiNo, sSubeMagaza) VALUES     ('" & nAlisVerisID & "', N'" & sAciklama & "', '" & sAdres1 & "', '" & sAdres2 & "', '" & sSemt & "', '" & sIl & "', '" & sUlke & "', '" & sPostaKodu & "', '" & sVergiDairesi & "', '" & sVergiNo & "', '" & sSubeMagaza & "')")
        cmd.ExecuteNonQuery()
        con.Close()
        cmd = Nothing
        con = Nothing
    End Sub
    Private Function tbStokFisidetay_kaydet_yeni(ByVal nIslemID As Int64, ByVal nStokID As Int64, ByVal dteIslemTarihi As DateTime, ByVal nFirmaID As Int64, ByVal nMusteriID As Int64, ByVal sFisTipi As String, ByVal dteFisTarihi As DateTime, ByVal lFisNo As String, ByVal nGirisCikis As Int64, ByVal sDepo As String, ByVal lReyonFisNo As String, ByVal sStokIslem As String, ByVal sKasiyerRumuzu As String, ByVal sSaticiRumuzu As String, ByVal sOdemeKodu As String, ByVal dteIrsaliyeTarihi As DateTime, ByVal lIrsaliyeNo As String, ByVal lGirisMiktar1 As Decimal, ByVal lGirisMiktar2 As Decimal, ByVal lGirisFiyat As Decimal, ByVal lGirisTutar As Decimal, ByVal lCikisMiktar1 As Decimal, ByVal lCikisMiktar2 As Decimal, ByVal lCikisFiyat As Decimal, ByVal lCikisTutar As Decimal, ByVal sFiyatTipi As String, ByVal lBrutFiyat As Decimal, ByVal lBrutTutar As Decimal, ByVal lMaliyetFiyat As Decimal, ByVal lMaliyetTutar As Decimal, ByVal lIlaveMaliyetTutar As Decimal, ByVal nIskontoYuzdesi As Decimal, ByVal lIskontoTutari As Decimal, ByVal sDovizCinsi As String, ByVal lDovizFiyat As Decimal, ByVal nSiparisID As String, ByVal nReceteNo As String, ByVal nTransferID As String, ByVal sTransferDepo As String, ByVal nKdvOrani As Decimal, ByVal nHesapID As Int64, ByVal sAciklama As String, ByVal sHareketTipi As String, ByVal bMuhasebeyeIslendimi As Byte, ByVal sKullaniciAdi As String, ByVal dteKayitTarihi As DateTime, ByVal sDovizCinsi1 As String, ByVal lDovizMiktari1 As Decimal, ByVal lDovizKuru1 As Decimal, ByVal sDovizCinsi2 As String, ByVal lDovizMiktari2 As Decimal, ByVal lDovizKuru2 As Decimal, ByVal nOTVOrani As Decimal, ByVal nTransferFirmaID As String, ByVal nAlisverisID As String, ByVal nStokFisiID As Int64, ByVal nIrsaliyeFisiID As String, ByVal sMasrafYontemi As String, ByVal sHangiUygulama As String, ByVal nEkSaha1 As Int64, ByVal nEkSaha2 As Int64, ByVal bEkSoru1 As Int64, ByVal bEkSoru2 As Int64, ByVal sSonKullaniciAdi As String, ByVal dteSonUpdateTarihi As DateTime, Optional ByVal sDatabase As String = "") As Int64
        Dim use As String = ""
        If sDatabase <> "" Then
            use = "USE " & sDatabase
        End If
        Dim con As New OleDb.OleDbConnection
        Dim cmd As New OleDb.OleDbCommand
        cmd.Connection = con
        con.ConnectionString = connection
        If con.State = ConnectionState.Closed = True Then
            con.Open()
        End If
        cmd.CommandText = sorgu_query("" & use & " SET DATEFORMAT DMY SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED INSERT INTO tbStokFisiDetayi                       (nStokID, dteIslemTarihi, nFirmaID, nMusteriID, sFisTipi, dteFisTarihi, lFisNo, nGirisCikis, sDepo, lReyonFisNo, sStokIslem, sKasiyerRumuzu, sSaticiRumuzu, sOdemeKodu, dteIrsaliyeTarihi, lIrsaliyeNo, lGirisMiktar1, lGirisMiktar2, lGirisFiyat, lGirisTutar, lCikisMiktar1, lCikisMiktar2, lCikisFiyat, lCikisTutar, sFiyatTipi, lBrutFiyat, lBrutTutar, lMaliyetFiyat, lMaliyetTutar, lIlaveMaliyetTutar, nIskontoYuzdesi, lIskontoTutari, sDovizCinsi, lDovizFiyat, nSiparisID, nReceteNo, nTransferID, sTransferDepo, nKdvOrani, nHesapID, sAciklama, sHareketTipi, bMuhasebeyeIslendimi, sKullaniciAdi, dteKayitTarihi, sDovizCinsi1, lDovizMiktari1, lDovizKuru1, sDovizCinsi2, lDovizMiktari2, lDovizKuru2, nOTVOrani, nTransferFirmaID, nAlisverisID, nStokFisiID, nIrsaliyeFisiID, sMasrafYontemi, sHangiUygulama, nEkSaha1, nEkSaha2, bEkSoru1, bEkSoru2, sSonKullaniciAdi, dteSonUpdateTarihi) VALUES     ('" & nStokID & "', '" & dteIslemTarihi & "', '" & nFirmaID & "', '" & nMusteriID & "', '" & sFisTipi & "', '" & dteFisTarihi & "', '" & lFisNo & "', " & nGirisCikis & ", '" & sDepo & "', '" & lReyonFisNo & "', '" & sStokIslem & "', '" & sKasiyerRumuzu & "', '" & sSaticiRumuzu & "', '" & sOdemeKodu & "', '" & dteIrsaliyeTarihi & "', '" & lIrsaliyeNo & "', " & lGirisMiktar1 & ", " & lGirisMiktar2 & ", " & lGirisFiyat & ", " & lGirisTutar & ", " & lCikisMiktar1 & ", " & lCikisMiktar2 & " , " & lCikisFiyat & ", " & lCikisTutar & " , '" & sFiyatTipi & "' , " & lBrutFiyat & ", " & lBrutTutar & " , " & lMaliyetFiyat & ", " & lMaliyetTutar & ", " & lIlaveMaliyetTutar & ", " & nIskontoYuzdesi & ", " & lIskontoTutari & ", '" & sDovizCinsi & "', " & lDovizFiyat & ", NULL, '" & nReceteNo & "', NULL, NULL, " & nKdvOrani & ", '" & nHesapID & "', N'" & sAciklama & "', '" & sHareketTipi & "'," & bMuhasebeyeIslendimi & ", '" & sKullaniciAdi & "', '" & dteKayitTarihi & "', '" & sDovizCinsi1 & "', " & lDovizMiktari1 & ", " & lDovizKuru1 & ", '" & sDovizCinsi2 & "', " & lDovizMiktari2 & " , " & lDovizKuru2 & ", " & nOTVOrani & ", NULL,  '" & nAlisverisID & "', NULL, NULL, '" & sMasrafYontemi & "', '" & sHangiUygulama & "', " & nEkSaha1 & ", " & nEkSaha2 & ", " & bEkSoru1 & " , " & bEkSoru2 & ", '" & sSonKullaniciAdi & "', '" & dteSonUpdateTarihi & "')")
        cmd.ExecuteNonQuery()
        cmd.CommandText = "SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT @@identity"
        nIslemID = cmd.ExecuteScalar
        Return nIslemID
        con.Close()
        cmd = Nothing
        con = Nothing
    End Function
    Private Sub tbStokFisidetay_fatura_kaydet_yeni(ByVal nIslemID As Int64, ByVal nStokID As Int64, ByVal dteIslemTarihi As DateTime, ByVal nFirmaID As Int64, ByVal nMusteriID As Int64, ByVal sFisTipi As String, ByVal dteFisTarihi As DateTime, ByVal lFisNo As String, ByVal nGirisCikis As Int64, ByVal sDepo As String, ByVal lReyonFisNo As String, ByVal sStokIslem As String, ByVal sKasiyerRumuzu As String, ByVal sSaticiRumuzu As String, ByVal sOdemeKodu As String, ByVal dteIrsaliyeTarihi As DateTime, ByVal lIrsaliyeNo As String, ByVal lGirisMiktar1 As Decimal, ByVal lGirisMiktar2 As Decimal, ByVal lGirisFiyat As Decimal, ByVal lGirisTutar As Decimal, ByVal lCikisMiktar1 As Decimal, ByVal sBirimCinsi As String, ByVal lBirimMiktar As Decimal, ByVal lCikisMiktar2 As Decimal, ByVal lCikisFiyat As Decimal, ByVal lCikisTutar As Decimal, ByVal sFiyatTipi As String, ByVal lBrutFiyat As Decimal, ByVal lBrutTutar As Decimal, ByVal lMaliyetFiyat As Decimal, ByVal lMaliyetTutar As Decimal, ByVal lIlaveMaliyetTutar As Decimal, ByVal nIskontoYuzdesi As Decimal, ByVal lIskontoTutari As Decimal, ByVal sDovizCinsi As String, ByVal lDovizFiyat As Decimal, ByVal nSiparisID As String, ByVal nReceteNo As String, ByVal nTransferID As String, ByVal sTransferDepo As String, ByVal nKdvOrani As Decimal, ByVal nHesapID As Int64, ByVal sAciklama As String, ByVal sHareketTipi As String, ByVal bMuhasebeyeIslendimi As Byte, ByVal sKullaniciAdi As String, ByVal dteKayitTarihi As DateTime, ByVal sDovizCinsi1 As String, ByVal lDovizMiktari1 As Decimal, ByVal lDovizKuru1 As Decimal, ByVal sDovizCinsi2 As String, ByVal lDovizMiktari2 As Decimal, ByVal lDovizKuru2 As Decimal, ByVal nOTVOrani As Decimal, ByVal nTransferFirmaID As String, ByVal nAlisverisID As String, ByVal nStokFisiID As Int64, ByVal nIrsaliyeFisiID As String, ByVal sMasrafYontemi As String, ByVal sHangiUygulama As String, ByVal nEkSaha1 As Int64, ByVal nEkSaha2 As Int64, ByVal bEkSoru1 As Int64, ByVal bEkSoru2 As Int64, ByVal sSonKullaniciAdi As String, ByVal dteSonUpdateTarihi As DateTime, Optional ByVal sDatabase As String = "")
        Dim use As String = ""
        If sDatabase <> "" Then
            use = "USE " & sDatabase
        End If
        Dim con As New OleDb.OleDbConnection
        Dim cmd As New OleDb.OleDbCommand
        cmd.Connection = con
        con.ConnectionString = connection
        If con.State = ConnectionState.Closed = True Then
            con.Open()
        End If
        cmd.CommandText = sorgu_query("" & use & " SET DATEFORMAT DMY SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED INSERT INTO tbStokFisiDetayi                       (nIslemID,nStokID, dteIslemTarihi, nFirmaID, nMusteriID, sFisTipi, dteFisTarihi, lFisNo, nGirisCikis, sDepo, lReyonFisNo, sStokIslem, sKasiyerRumuzu, sSaticiRumuzu, sOdemeKodu, dteIrsaliyeTarihi, lIrsaliyeNo, lGirisMiktar1, lGirisMiktar2, lGirisFiyat, lGirisTutar, lCikisMiktar1, lCikisMiktar2, lCikisFiyat, lCikisTutar, sFiyatTipi, lBrutFiyat, lBrutTutar, lMaliyetFiyat, lMaliyetTutar, lIlaveMaliyetTutar, nIskontoYuzdesi, lIskontoTutari, sDovizCinsi, lDovizFiyat, nSiparisID, nReceteNo, nTransferID, sTransferDepo, nKdvOrani, nHesapID, sAciklama, sHareketTipi, bMuhasebeyeIslendimi, sKullaniciAdi, dteKayitTarihi, sDovizCinsi1, lDovizMiktari1, lDovizKuru1, sDovizCinsi2, lDovizMiktari2, lDovizKuru2, nOTVOrani, nTransferFirmaID, nAlisverisID, nStokFisiID, nIrsaliyeFisiID, sMasrafYontemi, sHangiUygulama, nEkSaha1, nEkSaha2, bEkSoru1, bEkSoru2, sSonKullaniciAdi, dteSonUpdateTarihi) VALUES     (" & nIslemID & " ,'" & nStokID & "', '" & dteIslemTarihi & "', '" & nFirmaID & "', '" & nMusteriID & "', '" & sFisTipi & "', '" & dteFisTarihi & "', '" & lFisNo & "', " & nGirisCikis & ", '" & sDepo & "', '" & lReyonFisNo & "', '" & sStokIslem & "', '" & sKasiyerRumuzu & "', '" & sSaticiRumuzu & "', '" & sOdemeKodu & "', '" & dteIrsaliyeTarihi & "', '" & lIrsaliyeNo & "', " & lGirisMiktar1 & ", " & lGirisMiktar2 & ", " & lGirisFiyat & ", " & lGirisTutar & ", " & lCikisMiktar1 & ", " & lCikisMiktar2 & " , " & lCikisFiyat & ", " & lCikisTutar & " , '" & sFiyatTipi & "' , " & lBrutFiyat & ", " & lBrutTutar & " , " & lMaliyetFiyat & ", " & lMaliyetTutar & ", " & lIlaveMaliyetTutar & ", " & nIskontoYuzdesi & ", " & lIskontoTutari & ", '" & sDovizCinsi & "', " & lDovizFiyat & ", NULL, '" & nReceteNo & "', NULL, NULL, " & nKdvOrani & ", '" & nHesapID & "', N'" & sAciklama & "', '" & sHareketTipi & "'," & bMuhasebeyeIslendimi & ", '" & sKullaniciAdi & "', '" & dteKayitTarihi & "', '" & sDovizCinsi1 & "', " & lDovizMiktari1 & ", " & lDovizKuru1 & ", '" & sDovizCinsi2 & "', " & lDovizMiktari2 & " , " & lDovizKuru2 & ", " & nOTVOrani & ", NULL,  NULL, '" & nStokFisiID & "', NULL, '" & sMasrafYontemi & "', '" & sHangiUygulama & "', " & nEkSaha1 & ", " & nEkSaha2 & ", " & bEkSoru1 & " , " & bEkSoru2 & ", '" & sSonKullaniciAdi & "', '" & dteSonUpdateTarihi & "')")
        cmd.ExecuteNonQuery()
        con.Close()
        con = Nothing
        cmd = Nothing
    End Sub
    Private Sub fis_detay_fisno_degistir(ByVal nstokIslemID As String, Optional ByVal sDatabase As String = "")
        Dim use As String = ""
        If sDatabase <> "" Then
            use = "USE " & sDatabase
        End If
        Dim conn As New OleDb.OleDbConnection
        Dim cmd As New OleDb.OleDbCommand
        Dim adapter As New OleDb.OleDbDataAdapter
        conn.ConnectionString = connection
        cmd.Connection = conn
        If conn.State = ConnectionState.Closed Then
            conn.Open()
        End If
        cmd.CommandText = sorgu_query("" & use & " SET DATEFORMAT DMY SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED UPDATE    tbStokSiraNo SET              nSonID = '" & nstokIslemID & "' where nSiraIndex = 1")
        cmd.ExecuteNonQuery()
        conn.Close()
        conn = Nothing
        cmd = Nothing
    End Sub
#End Region
#Region " Stok "
    Public Function sorgu_sBirimCinsi1_kontrol(ByVal sBirimCinsi As String, ByVal sAciklama As String, Optional ByVal sDatabase As String = "") As String
        Dim use As String = ""
        If sDatabase <> "" Then
            use = "USE " & sDatabase
        End If
        Dim kriter
        kriter = ""
        Dim conn As New OleDb.OleDbConnection
        Dim cmd As New OleDb.OleDbCommand
        Dim adapter As New OleDb.OleDbDataAdapter
        conn.ConnectionString = connection
        cmd.Connection = conn
        conn.Open()
        cmd.CommandText = sorgu_query("" & use & " SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT     ISNULL(sBirimCinsi, '') AS sBirimCinsi FROM         tbBirimCinsi WHERE     (sBirimCinsi = '" & sBirimCinsi & "' ) AND (sAciklama = '" & sAciklama & "') ")
        Dim kayitsayisi = cmd.ExecuteScalar
        Return kayitsayisi
        cmd = Nothing
        conn = Nothing
    End Function
    Private Sub tbBirimCinsi_kaydet_yeni(ByVal sBirimCinsi As String, ByVal sAciklama As String, ByVal nOndalik As Int64, Optional ByVal sDatabase As String = "")
        Dim use As String = ""
        If sDatabase <> "" Then
            use = "USE " & sDatabase
        End If
        Dim con As New OleDb.OleDbConnection
        Dim cmd As New OleDb.OleDbCommand
        cmd.Connection = con
        con.ConnectionString = connection
        If con.State = ConnectionState.Closed = True Then
            con.Open()
        End If
        cmd.CommandText = sorgu_query("" & use & " SET DATEFORMAT DMY SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED INSERT INTO tbBirimCinsi (sBirimCinsi, sAciklama, nOndalik) VALUES     ('" & sBirimCinsi & "', N'" & sAciklama & "', " & nOndalik & ")")
        cmd.ExecuteNonQuery()
        con.Close()
        cmd = Nothing
        con = Nothing
    End Sub
    Public Function sorgu_sKdvTipi_kontrol(ByVal nKdvOrani As String) As String
        Dim kriter
        kriter = ""
        Dim conn As New OleDb.OleDbConnection
        Dim cmd As New OleDb.OleDbCommand
        Dim adapter As New OleDb.OleDbDataAdapter
        conn.ConnectionString = connection
        cmd.Connection = conn
        conn.Open()
        cmd.CommandText = sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT     sKdvTipi FROM         tbKdv WHERE     (nKdvOrani = " & nKdvOrani & ") AND (sKdvTipi <> '') ")
        Dim kayitsayisi = cmd.ExecuteScalar
        Return kayitsayisi
        cmd = Nothing
        conn = Nothing
    End Function
    Public Function sorgu_sKdvTipi_kontrol_kayit(ByVal nKdvOrani As String) As String
        Dim kriter
        kriter = ""
        Dim conn As New OleDb.OleDbConnection
        Dim cmd As New OleDb.OleDbCommand
        Dim adapter As New OleDb.OleDbDataAdapter
        conn.ConnectionString = connection
        cmd.Connection = conn
        conn.Open()
        cmd.CommandText = sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT     COUNT(sKdvTipi) + 1 AS nKayit FROM         tbKdv WHERE     (sKdvTipi <> '') ")
        Dim kayitsayisi = cmd.ExecuteScalar
        If kayitsayisi = 0 Then
            kayitsayisi = 1
        End If
        Return kayitsayisi
        cmd = Nothing
        conn = Nothing
    End Function
    Private Sub tbKdv_kaydet_yeni(ByVal sKdvTipi As String, ByVal nKdvOrani As Int64)
        Dim cmd As New OleDb.OleDbCommand
        Dim con As New OleDb.OleDbConnection
        cmd.Connection = con
        con.ConnectionString = connection
        If con.State = ConnectionState.Closed = True Then
            con.Open()
        End If
        cmd.CommandText = sorgu_query("SET DATEFORMAT DMY SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED INSERT INTO tbKdv (sKdvTipi, nKdvOrani) VALUES     ('" & sKdvTipi & "', " & nKdvOrani & ")")
        cmd.ExecuteNonQuery()
        con.Close()
        cmd = Nothing
        con = Nothing
    End Sub
    Private Function tbStok_kaydet_yeni(ByVal sKodu As String, ByVal sAciklama As String, ByVal sKisaAdi As String, ByVal nStokTipi As Int64, ByVal sBedenTipi As String, ByVal sKavalaTipi As String, ByVal sRenk As String, ByVal sBeden As String, ByVal sKavala As String, ByVal sBirimCinsi1 As String, ByVal sBirimCinsi2 As String, ByVal nIskontoYuzdesi As Decimal, ByVal sKdvTipi As String, ByVal nTeminSuresi As Decimal, ByVal lAsgariMiktar As Decimal, ByVal lAzamiMiktar As Decimal, ByVal sOzelNot As String, ByVal nFiyatlandirma As Int64, ByVal sModel As String, ByVal sKullaniciAdi As String, ByVal dteKayitTarihi As DateTime, ByVal bEksiyeDusulebilirmi As Byte, ByVal sDefaultAsortiTipi As String, ByVal bEksideUyarsinmi As Byte, ByVal bOTVVar As Byte, ByVal sOTVTipi As String, ByVal nIskontoYuzdesiAV As Decimal, ByVal bEk1 As Byte, ByVal nEk2 As String, Optional ByVal sDatabase As String = "") As Decimal
        Dim use As String = ""
        If sDatabase <> "" Then
            use = "USE " & sDatabase
        End If
        Dim con As New OleDb.OleDbConnection
        Dim cmd As New OleDb.OleDbCommand
        cmd.Connection = con
        con.ConnectionString = connection
        If con.State = ConnectionState.Closed = True Then
            con.Open()
        End If
        cmd.CommandText = sorgu_query("" & use & " SET DATEFORMAT DMY SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED INSERT INTO tbStok (sKodu, sAciklama, sKisaAdi, nStokTipi, sBedenTipi, sKavalaTipi, sRenk, sBeden, sKavala, sBirimCinsi1, sBirimCinsi2, nIskontoYuzdesi, sKdvTipi, nTeminSuresi, lAsgariMiktar, lAzamiMiktar, sOzelNot, nFiyatlandirma, sModel, sKullaniciAdi, dteKayitTarihi, bEksiyeDusulebilirmi, sDefaultAsortiTipi, bEksideUyarsinmi, bOTVVar, sOTVTipi, nIskontoYuzdesiAV, bEk1, nEk2) VALUES     ('" & sKodu & "', N'" & sAciklama & "', '" & sKisaAdi & "', " & nStokTipi & ", '" & sBedenTipi & "', '" & sKavalaTipi & "', '" & sRenk & "', '" & sBeden & "', '" & sKavala & "', '" & sBirimCinsi1 & "', '" & sBirimCinsi1 & "', " & nIskontoYuzdesi & ", '" & sKdvTipi & "', " & nTeminSuresi & ", " & lAsgariMiktar & ", " & lAzamiMiktar & ", '" & sOzelNot & "', " & nFiyatlandirma & ", '" & sModel & "', '" & sKullaniciAdi & "', '" & dteKayitTarihi & "', " & bEksiyeDusulebilirmi & ", '" & sDefaultAsortiTipi & "', " & bEksideUyarsinmi & ", " & bOTVVar & ", '" & sOTVTipi & "', " & nIskontoYuzdesiAV & ", " & bEk1 & ", " & nEk2 & ")")
        cmd.ExecuteNonQuery()
        cmd.CommandText = "SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT @@identity"
        Dim kayitno = cmd.ExecuteScalar
        con.Close()
        Return kayitno
        cmd = Nothing
        con = Nothing
    End Function
    Private Sub tbStokSinifi_kaydet_yeni(ByVal nStokID As String, ByVal sSinifKodu1 As String, ByVal sSinifKodu2 As String, ByVal sSinifKodu3 As String, ByVal sSinifKodu4 As String, ByVal sSinifKodu5 As String, ByVal sSinifKodu6 As String, ByVal sSinifKodu7 As String, ByVal sSinifKodu8 As String, ByVal sSinifKodu9 As String, ByVal sSinifKodu10 As String, ByVal sSinifKodu11 As String, ByVal sSinifKodu12 As String, ByVal sSinifKodu13 As String, ByVal sSinifKodu14 As String, ByVal sSinifKodu15 As String, Optional ByVal sDatabase As String = "")
        Dim use As String = ""
        If sDatabase <> "" Then
            use = "USE " & sDatabase
        End If
        Dim con As New OleDb.OleDbConnection
        Dim cmd As New OleDb.OleDbCommand
        cmd.Connection = con
        con.ConnectionString = connection
        If con.State = ConnectionState.Closed = True Then
            con.Open()
        End If
        cmd.CommandText = sorgu_query("" & use & " SET DATEFORMAT DMY SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED INSERT INTO tbStokSinifi (nStokID, sSinifKodu1, sSinifKodu2, sSinifKodu3, sSinifKodu4, sSinifKodu5, sSinifKodu6, sSinifKodu7, sSinifKodu8, sSinifKodu9, sSinifKodu10, sSinifKodu11, sSinifKodu12, sSinifKodu13, sSinifKodu14, sSinifKodu15) VALUES     (" & nStokID & ", '" & sSinifKodu1 & "', '" & sSinifKodu2 & "', '" & sSinifKodu3 & "', '" & sSinifKodu4 & "', '" & sSinifKodu5 & "', '" & sSinifKodu6 & "', '" & sSinifKodu7 & "', '" & sSinifKodu8 & "', '" & sSinifKodu9 & "', '" & sSinifKodu10 & "',  '" & sSinifKodu11 & "', '" & sSinifKodu12 & "', '" & sSinifKodu13 & "', '" & sSinifKodu14 & "', '" & sSinifKodu15 & "')")
        cmd.ExecuteNonQuery()
        con.Close()
        cmd = Nothing
        con = Nothing
    End Sub
    Private Sub tbStokBarkodu_kaydet_yeni(ByVal nStokID As Int64, ByVal sBarkod As String, ByVal nKisim As Integer, ByVal nFirmaID As Integer, ByVal sKarsiStokKodu As String, ByVal sKarsiStokAciklama As String, Optional ByVal sDatabase As String = "")
        Dim use As String = ""
        If sDatabase <> "" Then
            use = "USE " & sDatabase
        End If
        Dim con As New OleDb.OleDbConnection
        Dim cmd As New OleDb.OleDbCommand
        cmd.Connection = con
        con.ConnectionString = connection
        If con.State = ConnectionState.Closed = True Then
            con.Open()
        End If
        cmd.CommandText = sorgu_query("" & use & " SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED INSERT INTO tbStokBarkodu (nStokID, sBarkod, nKisim, nFirmaID, sKarsiStokKodu, sKarsiStokAciklama) VALUES     (" & nStokID & ", '" & sBarkod & "', " & nKisim & ", " & nFirmaID & ", '" & sKarsiStokKodu & "', '" & sKarsiStokAciklama & "')")
        Try
            cmd.ExecuteNonQuery()
        Catch ex As Exception
            XtraMessageBox.Show(sBarkod & Sorgu_sDil(" Barkod Sisteme Kaydedilemedi... Ayn˝ Kay˝ttan Var", sDil), Sorgu_sDil("Dikkat", sDil), MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End Try
        con.Close()
        cmd = Nothing
        con = Nothing
    End Sub
    Private Sub tbStokAciklama_kaydet_yeni(ByVal nStokID As String, ByVal sAciklama1 As String, ByVal sAciklama2 As String, ByVal sAciklama3 As String, ByVal sAciklama4 As String, ByVal sAciklama5 As String, ByVal sAciklama6 As String, ByVal sAciklama7 As String, ByVal sAciklama8 As String, ByVal sAciklama9 As String, ByVal sAciklama10 As String, Optional ByVal sDatabase As String = "")
        Dim use As String = ""
        If sDatabase <> "" Then
            use = "USE " & sDatabase
        End If
        Dim con As New OleDb.OleDbConnection
        Dim cmd As New OleDb.OleDbCommand
        cmd.Connection = con
        con.ConnectionString = connection
        If con.State = ConnectionState.Closed = True Then
            con.Open()
        End If
        cmd.CommandText = sorgu_query("" & use & " SET DATEFORMAT DMY SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED INSERT INTO tbStokAciklama (nStokID, sAciklama1, sAciklama2, sAciklama3, sAciklama4, sAciklama5,sAciklama6,sAciklama7,sAciklama8,sAciklama9,sAciklama10) VALUES     ('" & nStokID & "', '" & sAciklama1 & "', '" & sAciklama2 & "', '" & sAciklama3 & "', '" & sAciklama4 & "', '" & sAciklama5 & "','" & sAciklama6 & "','" & sAciklama7 & "','" & sAciklama8 & "','" & sAciklama9 & "','" & sAciklama10 & "')")
        cmd.ExecuteNonQuery()
        con.Close()
        cmd = Nothing
        con = Nothing
    End Sub
    Private Sub tbStokUzunNot_kaydet_yeni(ByVal sModel As String, ByVal sUzunNot As String, ByVal sSonKullaniciAdi As String, ByVal dteSonUpdateTarihi As DateTime, Optional ByVal sDatabase As String = "")
        Dim use As String = ""
        If sDatabase <> "" Then
            use = "USE " & sDatabase
        End If
        Dim con As New OleDb.OleDbConnection
        Dim cmd As New OleDb.OleDbCommand
        cmd.Connection = con
        con.ConnectionString = connection
        If con.State = ConnectionState.Closed = True Then
            con.Open()
        End If
        cmd.CommandText = sorgu_query("" & use & " SET DATEFORMAT DMY SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED INSERT INTO tbStokUzunNot                       (sModel, sUzunNot, sSonKullaniciAdi, dteSonUpdateTarihi) VALUES     ('" & sModel & "', '" & sUzunNot & "', '" & sSonKullaniciAdi & "', '" & dteSonUpdateTarihi & "')")
        cmd.ExecuteNonQuery()
        con.Close()
        cmd = Nothing
        con = Nothing
    End Sub
    Private Sub tbStokFiyati_ekle_yeni(ByVal nFiyatlandirma As Int64, ByVal sModel As String, ByVal sRenk As String, ByVal sBeden As String, ByVal sFiyatTipi As String, ByVal lFiyat As Decimal, ByVal dteFiyatTespitTarihi As DateTime, ByVal sKullaniciAdi As String, Optional ByVal sDatabase As String = "")
        Dim use As String = ""
        If sDatabase <> "" Then
            use = "USE " & sDatabase
        End If
        Dim cmd As New OleDb.OleDbCommand
        Dim con As New OleDb.OleDbConnection
        con.ConnectionString = connection
        cmd.Connection = con
        If con.State = ConnectionState.Closed Then
            con.Open()
        End If
        cmd.CommandText = "" & use & " set implicit_transactions on "
        cmd.ExecuteNonQuery()
        If nFiyatlandirma = 0 Then
            cmd.CommandText = "" & use & " SET DATEFORMAT DMY SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED insert tbStokFiyati   select nStokID , '" & sFiyatTipi & "' , " & lFiyat & " , '" & dteFiyatTespitTarihi & "' , '" & sKullaniciAdi & "' , getdate ()  from tbStok where sModel = '" & sModel & "'"
        ElseIf nFiyatlandirma = 1 Then
            cmd.CommandText = "" & use & " SET DATEFORMAT DMY SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED insert tbStokFiyati   select nStokID , '" & sFiyatTipi & "' , " & lFiyat & " , '" & dteFiyatTespitTarihi & "' , '" & sKullaniciAdi & "' , getdate ()  from tbStok where sModel = '" & sModel & "' and sRenk ='" & sRenk & "'"
        ElseIf nFiyatlandirma = 2 Then
            cmd.CommandText = "" & use & " SET DATEFORMAT DMY SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED insert tbStokFiyati   select nStokID , '" & sFiyatTipi & "' , " & lFiyat & " , '" & dteFiyatTespitTarihi & "' , '" & sKullaniciAdi & "' , getdate ()  from tbStok where sModel = '" & sModel & "' and sRenk ='" & sRenk & "' and sBeden ='" & sBeden & "'"
        End If
        cmd.ExecuteNonQuery()
        cmd.CommandText = "" & use & " IF @@TRANCOUNT > 0 COMMIT TRAN"
        cmd.ExecuteNonQuery()
        cmd.CommandText = "" & use & " set implicit_transactions off "
        cmd.ExecuteNonQuery()
        con.Close()
        cmd = Nothing
        con = Nothing
    End Sub
    Private Sub tbStokFiyati_kaydet_yeni(ByVal nStokID As Int64, ByVal sFiyatTipi As String, ByVal lFiyat As Decimal, ByVal dteFiyatTespitTarihi As DateTime, ByVal sKullaniciAdi As String, ByVal dteKayitTarihi As DateTime, Optional ByVal sDatabase As String = "")
        Dim use As String = ""
        If sDatabase <> "" Then
            use = "USE " & sDatabase
        End If
        Dim cmd As New OleDb.OleDbCommand
        Dim con As New OleDb.OleDbConnection
        con.ConnectionString = connection
        cmd.Connection = con
        If con.State = ConnectionState.Closed Then
            con.Open()
        End If
        cmd.CommandText = "" & use & " INSERT INTO tbStokFiyati                       (nStokID, sFiyatTipi, lFiyat, dteFiyatTespitTarihi, sKullaniciAdi, dteKayitTarihi) VALUES     (" & nStokID & ", '" & sFiyatTipi & "', " & lFiyat & ", '" & dteFiyatTespitTarihi & "', '" & sKullaniciAdi & "', '" & dteKayitTarihi & "') "
        cmd.ExecuteNonQuery()
        con.Close()
        cmd = Nothing
        con = Nothing
    End Sub
    Private Sub tbStokFiyati_sModel_ekle_yeni(ByVal nFiyatlandirma As Int64, ByVal sModel As String, ByVal sRenk As String, ByVal sBeden As String, ByVal sFiyatTipi As String, ByVal lFiyat As Decimal, ByVal dteFiyatTespitTarihi As DateTime, ByVal kullanici As String)
        Dim cmd As New OleDb.OleDbCommand
        Dim con As New OleDb.OleDbConnection
        con.ConnectionString = connection
        cmd.Connection = con
        If con.State = ConnectionState.Closed Then
            con.Open()
        End If
        cmd.CommandText = "set implicit_transactions on "
        cmd.ExecuteNonQuery()
        cmd.CommandText = sorgu_query("set transaction isolation level read uncommitted")
        cmd.ExecuteNonQuery()
        Try
            If nFiyatlandirma = 0 Then
                cmd.CommandText = sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED INSERT INTO tbStokFiyati SELECT tbStok.nStokID, Fiyatlar.sFiyatTipi, Fiyatlar.lFiyat, Fiyatlar.dteFiyatTespitTarihi, '" & kullanici & "' AS Expr1, GETDATE() AS Expr2 FROM (SELECT DISTINCT sModel , (sFiyatTipi) AS sFiyatTipi , lFiyat , dteFiyatTespitTarihi FROM tbStokFiyati , tbStok WHERE tbStokFiyati.nStokID = tbStok.nStokID AND tbStok.sModel = '" & sModel & "') Fiyatlar INNER JOIN tbStok ON Fiyatlar.sModel = tbStok.sModel WHERE (NOT EXISTS (SELECT * FROM tbstokfiyati WHERE nStokID = tbStok.nStokID AND sFiyatTipi = Fiyatlar.sFiyatTipi))")
                cmd.ExecuteNonQuery()
                cmd.CommandText = sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED UPDATE tbStokFiyati set dteKayitTarihi = getdate() where nStokID in ( select nStokID from tbStok where sModel = '" & sModel & "' )")
                cmd.ExecuteNonQuery()
            ElseIf nFiyatlandirma = 1 Then
                cmd.CommandText = sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED INSERT INTO tbStokFiyati SELECT tbStok.nStokID, Fiyatlar.sFiyatTipi, Fiyatlar.lFiyat, Fiyatlar.dteFiyatTespitTarihi, '" & kullanici & "' AS Expr1, GETDATE() AS Expr2 FROM (SELECT DISTINCT sModel , (sFiyatTipi) AS sFiyatTipi , lFiyat , dteFiyatTespitTarihi FROM tbStokFiyati , tbStok WHERE tbStokFiyati.nStokID = tbStok.nStokID AND tbStok.sModel = '" & sModel & "' and tbStok.sRenk = '" & sRenk & "' ) Fiyatlar INNER JOIN tbStok ON Fiyatlar.sModel = tbStok.sModel WHERE (NOT EXISTS (SELECT * FROM tbstokfiyati WHERE nStokID = tbStok.nStokID AND sFiyatTipi = Fiyatlar.sFiyatTipi))")
                cmd.ExecuteNonQuery()
                cmd.CommandText = sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED UPDATE tbStokFiyati set dteKayitTarihi = getdate() where nStokID in ( select nStokID from tbStok where sModel = '" & sModel & "' and sRenk = '" & sRenk & "' )")
                cmd.ExecuteNonQuery()
            ElseIf nFiyatlandirma = 2 Then
            End If
        Catch ex As Exception
        End Try
        cmd.CommandText = "IF @@TRANCOUNT > 0 COMMIT TRAN"
        cmd.ExecuteNonQuery()
        cmd.CommandText = "set implicit_transactions off "
        cmd.ExecuteNonQuery()
        con.Close()
        cmd = Nothing
        con = Nothing
    End Sub
    Private Sub tbStokBirimCevrimi_kaydet_yeni(ByVal sBirimCinsi As String, ByVal lOran As Decimal, ByVal sModel As String, Optional ByVal sDatabase As String = "")
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
        cmd.CommandText = sorgu_query("SET DATEFORMAT DMY SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED insert tbStokBirimCevrimi select nStokID , '" & sBirimCinsi & "' , " & lOran & ", 0 from tbStok where sModel = '" & sModel & "' ")
        cmd.ExecuteNonQuery()
        con.Close()
    End Sub
#End Region
    Private Sub SimpleButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SimpleButton1.Click
        Me.Close()
    End Sub
    Private Sub SimpleButton2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SimpleButton2.Click
        Me.Close()
    End Sub
    Private Sub SimpleButton5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SimpleButton5.Click
        aktar_business_satis()
        DataSet2 = query_FAT_BASLIK("SATFAT")
        GridControl1.DataSource = DataSet2.Tables(0)
        GridView1.ExpandAllGroups()
        GridView2.ExpandAllGroups()
    End Sub
    Private Sub SimpleButton4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SimpleButton4.Click
        'Dim objProcess As System.Diagnostics.Process
        'objProcess = New System.Diagnostics.Process()
        'objProcess.StartInfo.WindowStyle = ProcessWindowStyle.Normal
        'Dim sRun As String = ""
        'Try
        '    sRun = "D:\Basis\VEGA.TXT"
        '    objProcess.StartInfo.FileName = Trim(sRun)
        '    objProcess.StartInfo.Arguments = ""
        '    objProcess.Start()
        'Catch ex As Exception
        '    DevExpress.XtraEditors.XtraMessageBox.Show("Islem Baslatilamiyor " & objProcess.StartInfo.FileName.ToString)
        'End Try
        Dim SaveFileDialog1 As New Windows.Forms.OpenFileDialog
        SaveFileDialog1.Filter = "XML Dosyalar˝(*.XML) |*.XML"
        SaveFileDialog1.InitialDirectory = "D:\Basis\"
        SaveFileDialog1.FileName = "SATIS.XML"
        If SaveFileDialog1.ShowDialog = Windows.Forms.DialogResult.OK Then
        End If
    End Sub
    Private Sub frm_tbKarpin_Aktarim_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
    End Sub
    Private Sub GridView1_CustomDrawRowIndicator(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Grid.RowIndicatorCustomDrawEventArgs) Handles GridView1.CustomDrawRowIndicator
        If e.RowHandle >= 0 Then
            e.Info.DisplayText = e.RowHandle + 1
        Else
            e.Info.DisplayText = ""
        End If
    End Sub
    Private Sub GridView2_CustomDrawRowIndicator(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Grid.RowIndicatorCustomDrawEventArgs) Handles GridView2.CustomDrawRowIndicator
        If e.RowHandle >= 0 Then
            e.Info.DisplayText = e.RowHandle + 1
        Else
            e.Info.DisplayText = ""
        End If
    End Sub
    Private Sub BarButtonItem1_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem1.ItemClick
        If XtraTabControl1.SelectedTabPageIndex = 0 Then
            printlink1.CreateDocument(ps)
            ps.PreviewRibbonFormEx.Show()
        ElseIf XtraTabControl1.SelectedTabPageIndex = 1 Then
            printlink1.CreateDocument(ps)
            ps.PreviewRibbonFormEx.Show()
        End If

    End Sub
    Private Sub raporla_excel()
        If XtraMessageBox.Show(Sorgu_sDil("SonuÁlar˝ Excel Dosyas˝ Olu˛turmak ›stediinize Emin misiniz...?", sDil), Sorgu_sDil("Dikkat", sDil), MessageBoxButtons.YesNo, MessageBoxIcon.Question) = MsgBoxResult.Yes Then
            Dim SaveFileDialog1 As New Windows.Forms.SaveFileDialog
            SaveFileDialog1.Filter = "Excel Dosyalar˝(*.xls) |*.xls"
            SaveFileDialog1.InitialDirectory = "c:\"
            SaveFileDialog1.FileName = "KarpinAktarim.xls"
            If SaveFileDialog1.ShowDialog = Windows.Forms.DialogResult.OK Then
                If XtraTabControl1.SelectedTabPageIndex = 0 Then
                    GridView1.ExportToXls(SaveFileDialog1.FileName.ToString)
                ElseIf XtraTabControl1.SelectedTabPageIndex = 1 Then
                    GridView2.ExportToXls(SaveFileDialog1.FileName.ToString)
                End If
                If XtraMessageBox.Show(Sorgu_sDil("Kayd˝ AÁmak ›ster misiniz...?", sDil), Sorgu_sDil("Dikkat", sDil), MessageBoxButtons.YesNo, MessageBoxIcon.Question) = MsgBoxResult.Yes Then
                    Process.Start(SaveFileDialog1.FileName.ToString)
                End If
            End If
            SaveFileDialog1 = Nothing
        End If
    End Sub
    Private Sub BarButtonItem2_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem2.ItemClick
        raporla_excel()
    End Sub
    Private Sub SimpleButton6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SimpleButton6.Click
        'satis_oku_vega_DOS_direkt()
        ds_Tahsilat.Tables(0).Clear()
        Dim SaveFileDialog1 As New Windows.Forms.OpenFileDialog
        SaveFileDialog1.Filter = "XML Dosyalar˝(*.XML) |*.XML"
        SaveFileDialog1.InitialDirectory = "D:\Basis\"
        SaveFileDialog1.FileName = "NAKIT.XML"
        If SaveFileDialog1.ShowDialog = Windows.Forms.DialogResult.OK Then
            Try
                xml_tahsilat_oku(SaveFileDialog1.FileName.ToString)
                XtraTabControl1.SelectedTabPageIndex = 2
                GridControl3.Focus()
                GridControl3.Select()
            Catch ex As Exception
                XtraMessageBox.Show("Dosya Format˝ Uygun Deil...!", "Dikkat")
            End Try
        End If
    End Sub
End Class