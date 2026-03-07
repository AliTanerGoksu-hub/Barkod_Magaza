Imports System.Threading
Imports FastReport
Imports DevExpress.XtraGrid
Imports DevExpress.XtraEditors
Imports DevExpress.XtraGrid.Columns
Imports Microsoft.Win32
Imports System.IO
Public Class frm_tbNakitKasa
    Public firmano
    Public donemno
    Public connection
    Public kullanici
    Dim ds_tbsube As DataSet
    Dim ds_tbDovizCinsi As DataSet
    Dim ds_tbHareketTipi As DataSet
    Dim ds_Firma As DataSet
    Dim ds_tbBanka As DataSet
    Dim ds_tbMasrafMerkezi As DataSet
    Dim ds_tbCekSenetBordro As DataSet
    Dim ds_tbCekSenet As DataSet
    'Dim qr_hareket As New TfrxADOQuery
    'Dim qr_baslik As New TfrxADOQuery
    Public islemstatus As Boolean = False
    Public nFirmaid As Integer = 0
    Public sFirmaKodu As String = ""
    Public nHareketID As Int64 = 0
    Dim mevcut As Decimal = 1
    Dim x As Integer = 0
    Dim okut As Boolean = False
    Dim bLoad As Boolean = False
    Dim bKasaIsle As Boolean = True
    Private _listBox As ListBox
    Private _searchCriteria As String
    Private _searching As Boolean
    Private _deferSearch As Boolean
    Private _searchThread As Thread
    Private _onSearchComplete As EventHandler
    Private Sub frm_tbNakitKasa_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        If sDatabaseGenel = "UGURLU" Then
            If GridView1.RowCount = 1 Then
                If Trim(GridView1.GetRowCellValue(0, "sHareketTipi")) = "" Then
                    e.Cancel = True
                    XtraMessageBox.Show(Sorgu_sDil("Lütfen bir hareket tipi seçiniz.", sDil), Sorgu_sDil("Dikkat", sDil), MessageBoxButtons.OK, MessageBoxIcon.Warning)
                End If
            ElseIf GridView1.RowCount <> 0 Then
                Dim hareketV As Integer = 0
                For i As Integer = 0 To GridView1.RowCount - 1
                    If Trim(GridView1.GetRowCellValue(i, "sHareketTipi")) = "" Then
                        hareketV = 1
                    End If
                Next
                If hareketV = 1 Then
                    e.Cancel = True
                    XtraMessageBox.Show(Sorgu_sDil("Lütfen bir hareket tipi seçiniz.", sDil), Sorgu_sDil("Dikkat", sDil), MessageBoxButtons.OK, MessageBoxIcon.Warning)
                End If
            End If
        End If
        Registry.CurrentUser.CreateSubKey("Software").CreateSubKey("BusinessSmart").CreateSubKey("VIEW").CreateSubKey("Perakende").CreateSubKey("NakitKasa").SetValue("Kriter", sec_kriter.Text)
    End Sub
    Private Sub frm_tbNakitKasa_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        GridView6.ClearColumnsFilter()
        GridView6.Columns("lBakiye").FilterInfo = New ColumnFilterInfo("[lBakiye] <> 0 ")
        Me.RichTextBox1.Text = Sorgu_sDil("Kasayý Tutan", sDil) & Global.Microsoft.VisualBasic.ChrW(9) & Global.Microsoft.VisualBasic.ChrW(9) & Global.Microsoft.VisualBasic.ChrW(9) & Sorgu_sDil("1.Kontrol", sDil) & Global.Microsoft.VisualBasic.ChrW(9) & Global.Microsoft.VisualBasic.ChrW(9) & Global.Microsoft.VisualBasic.ChrW(9) & Global.Microsoft.VisualBasic.ChrW(9) & Sorgu_sDil("2.Kontrol", sDil) & Global.Microsoft.VisualBasic.ChrW(10) & "---------------------" & Global.Microsoft.VisualBasic.ChrW(9) & Global.Microsoft.VisualBasic.ChrW(9) & Global.Microsoft.VisualBasic.ChrW(9) & "--------------" & Global.Microsoft.VisualBasic.ChrW(9) & Global.Microsoft.VisualBasic.ChrW(9) & Global.Microsoft.VisualBasic.ChrW(9) & "-------------"
        Try
            sec_kriter.Text = Registry.CurrentUser.OpenSubKey("Software").OpenSubKey("BusinessSmart").OpenSubKey("VIEW").OpenSubKey("Perakende").OpenSubKey("NakitKasa").GetValue("Kriter").ToString
        Catch ex As Exception
            sec_kriter.Text = "Baþlar"
        End Try
        If islemstatus = False Then
            txt_dteIslemTarihi1.EditValue = dteSistemTarihi
            txt_dteIslemTarihi2.EditValue = dteSistemTarihi
        End If
        bKasaIsle = yetki_kontrol(kullanici, "frm_tbNakitKasa_Isle", False, 1)
        If bKasaIsle = True Then
            Panel_Ara.Enabled = True
            btn_AltFirmaBakiyesi.Enabled = True
            btn_AltFirmaHareketleri.Enabled = True
            btn_AltFirmaKarti.Enabled = True
            btn_AltSatirEkle.Enabled = True
            btn_AltSatirSil.Enabled = True
            MenuItem1.Enabled = True
            MenuItem3.Enabled = True
        End If
        dataload_tbSube()
        dataload_tbDovizCinsi()
        dataload_tbHareketTipi()
        dataload_tbMasrafMerkezi()
        Try
            gorunum_yukle()
        Catch ex As Exception
        End Try
        If Trim(nHareketID) <> 0 Then
            sec_bTumu.Checked = True
            sec_sSubeMagaza.EditValue = ""
            Panel_Ara.Enabled = False
            btn_AltFirmaBakiyesi.Enabled = False
            btn_AltFirmaHareketleri.Enabled = False
            btn_AltFirmaKarti.Enabled = False
            btn_AltSatirEkle.Enabled = False
            btn_AltSatirSil.Enabled = False
            MenuItem1.Enabled = False
            MenuItem3.Enabled = False
        End If
        ara()
        If nHareketID > 0 Then
            'Dim dr2 As DataRow
            'Dim sayi As Integer = -1
            'For Each dr2 In ds_tbNakitKasa.Tables(0).Rows
            '    sayi += 1
            '    If dr2("nCariHareketID") = nHareketID Then
            '        GridView1.ClearSelection()
            '        GridView1.FocusedRowHandle = sayi
            '        GridView1.SelectRow(sayi)
            '    End If
            'Next
            'dr2 = Nothing
            'sayi = Nothing
            If Trim(nHareketID) <> 0 Then
                GridView1.Columns("nCariHareketID").FilterInfo = New ColumnFilterInfo("[nCariHareketID] LIKE '" & nHareketID & "%'")
            Else
                GridView1.ClearColumnsFilter()
            End If
        End If
        txt_dteIslemTarihi2.Properties.MinValue = dteSonNakitKasaTarihi
        VGrid_Firma.DataSource = ds_tbFirma.Tables(0)
    End Sub
    Private Sub dataload_tbSube()
        ds_tbsube = sorgu(sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT     sSubeMagaza,sAciklama FROM         tbSubeMagaza"))
        sec_sSubeMagaza.Properties.DataSource = ds_tbsube.Tables(0)
        sec_sSube.DataSource = ds_tbsube.Tables(0)
        sec_sSubeMagaza.ItemIndex = 1
        sec_sSubeMagaza.EditValue = sSubeMagaza
        If Trim(sSubeMagaza) = "001" Then
            sec_sSubeMagaza.Properties.ReadOnly = False
            sec_bTumu.Enabled = True
        ElseIf Trim(sSubeMagaza) = "" Then
            sec_sSubeMagaza.Properties.ReadOnly = False
            sec_bTumu.Enabled = True
        Else
            sec_sSubeMagaza.Properties.ReadOnly = True
            sec_bTumu.Enabled = False
        End If
    End Sub
    Private Sub dataload_tbDovizCinsi()
        ds_tbDovizCinsi = sorgu(sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT     sDovizCinsi,sAciklama FROM         tbDovizCinsi"))
        sec_sDovizCinsi.DataSource = ds_tbDovizCinsi.Tables(0)
    End Sub
    Private Sub dataload_tbHareketTipi()
        ds_tbHareketTipi = sorgu(sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT     CAST(sHareketTipi AS CHAR(4)) AS sHareketTipi, sAciklama FROM         tbHareketTipi where aktif = 1"))
        sec_sHareketTipi.DataSource = ds_tbHareketTipi.Tables(0)
    End Sub
    Private Sub dataload_tbMasrafMerkezi()
        ds_tbMasrafMerkezi = sorgu(sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT     sMasrafYontemi,sAciklama FROM         tbMasrafMerkezi"))
        sec_sMasrafMerkezi.DataSource = ds_tbMasrafMerkezi.Tables(0)
    End Sub
    Private Function sorgu_kriter_string(ByVal deger As String, ByVal kriter As String) As String
        Dim sorgu_kriter As String = ""
        If kriter = "Baþlar" Then
            sorgu_kriter = " LIKE '" & deger & "%' "
        ElseIf kriter = "Biter" Then
            sorgu_kriter = " LIKE '%" & deger & "' "
        ElseIf kriter = "Ýçerir" Then
            sorgu_kriter = " LIKE '%" & deger & "%' "
        ElseIf kriter = "Boþ" Then
            sorgu_kriter = " IS NULL "
        ElseIf kriter = "Dolu" Then
            sorgu_kriter = " <> '' "
        ElseIf kriter = "Farklý" Then
            sorgu_kriter = " <> '" & deger & "' "
        ElseIf kriter = "Büyük" Then
            sorgu_kriter = " >  '" & deger & "' "
        ElseIf kriter = "Küçük" Then
            sorgu_kriter = " < '" & deger & "' "
        ElseIf kriter = "Eþittir" Then
            sorgu_kriter = " = '" & deger & "' "
        End If
        Return sorgu_kriter
    End Function
    Private Sub gorunum_kaydet()
        GridView1.SaveLayoutToRegistry("SOFTWARE\BusinessSmart\VIEW\MAGAZA\" & Me.Name.ToString & "")
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
        For Each clmn As DevExpress.XtraGrid.Columns.GridColumn In GridView2.Columns
            clmn.Caption = Sorgu_sDil(clmn.Caption, sDil)
        Next
        For Each clmn As DevExpress.XtraGrid.Columns.GridColumn In GridView3.Columns
            clmn.Caption = Sorgu_sDil(clmn.Caption, sDil)
        Next
        For Each clmn As DevExpress.XtraGrid.Columns.GridColumn In GridView4.Columns
            clmn.Caption = Sorgu_sDil(clmn.Caption, sDil)
        Next
        For Each clmn As DevExpress.XtraGrid.Columns.GridColumn In GridView5.Columns
            clmn.Caption = Sorgu_sDil(clmn.Caption, sDil)
        Next
        Dim tab As Object
        For Each tab In XtraTabControl1.TabPages
            tab.text = Sorgu_sDil(tab.text, sDil)
        Next
        For Each tab In XtraTabControl2.TabPages
            tab.text = Sorgu_sDil(tab.text, sDil)
        Next
        Dim row
        For Each row In VGrid_Firma.Rows
            Try
                row.Properties.Caption = Sorgu_sDil(row.Properties.Caption, sDil)
            Catch ex As Exception
            End Try
        Next
        For Each row In VGrid_Muhasebe.Rows
            Try
                row.Properties.Caption = Sorgu_sDil(row.Properties.Caption, sDil)
            Catch ex As Exception
            End Try
        Next
        Dim itm
        For Each itm In ContextMenu1.MenuItems
            itm.text = Sorgu_sDil(itm.text, sDil)
        Next
        Label3.Text = Sorgu_sDil(Label3.Text, sDil)
        Label4.Text = Sorgu_sDil(Label4.Text, sDil)
        LabelControl1.Text = Sorgu_sDil(LabelControl1.Text, sDil)
        LabelControl2.Text = Sorgu_sDil(LabelControl2.Text, sDil)
        LabelControl3.Text = Sorgu_sDil(LabelControl3.Text, sDil)
        LabelControl4.Text = Sorgu_sDil(LabelControl4.Text, sDil)
        LabelControl5.Text = Sorgu_sDil(LabelControl5.Text, sDil)
        sec_bTumu.Text = Sorgu_sDil(sec_bTumu.Text, sDil)
        Group_CariHesap.Text = Sorgu_sDil(Group_CariHesap.Text, sDil)
        Group_Muhasebe.Text = Sorgu_sDil(Group_Muhasebe.Text, sDil)
        Group_Yekun.Text = Sorgu_sDil(Group_Yekun.Text, sDil)
        'SimpleButton1.Text = Sorgu_sDil(SimpleButton1.Text, sDil)
        btn_Goster.Text = Sorgu_sDil(btn_Goster.Text, sDil)
        btn_CekSenetListele.Text = Sorgu_sDil(btn_CekSenetListele.Text, sDil)
        GroupControl1.Text = Sorgu_sDil(GroupControl1.Text, sDil)
        GroupControl5.Text = Sorgu_sDil(GroupControl5.Text, sDil)
        GridView1.RestoreLayoutFromRegistry("SOFTWARE\BusinessSmart\VIEW\MAGAZA\" & Me.Name.ToString & "")
    End Sub
    Private Function sorgu_query(ByVal query As String) As String
        query = Replace(query, "*!F", "F0" + firmano.ToString)
        query = Replace(query, "!D", "D000" + donemno.ToString)
        Return query
    End Function
    Private Function KayitSiniri_kontrol(ByVal tbTable, ByVal kriter, ByVal nKayitSinir) As Boolean
        Dim pass As Boolean = False
        If nKayitSinir > 0 Then
            Dim yetki As Int64 = Sorgu_tbKayitSayisi(tbTable, kriter, nKayitSinir)
            If yetki = 0 Then
                XtraMessageBox.Show(Sorgu_sDil("Üzgünüm Kýsýtlý Kullaným.Maximum Kayýt Sýnýrýný Aþamazsýnýz...!" & vbCrLf & "Lütfen Yetkili Satýcýnýzla Görüþün...", sDil), Sorgu_sDil("Dikkat", sDil), MessageBoxButtons.OK, MessageBoxIcon.Information)
                pass = False
            ElseIf yetki = 1 Then
                pass = True
            End If
        Else
            pass = True
        End If
        Return pass
    End Function
    Private Function Sorgu_tbKayitSayisi(ByVal tbTable As String, ByVal kriter As String, ByVal nKayitSinir As Integer) As Int64
        Dim cmd As New OleDb.OleDbCommand
        Dim con As New OleDb.OleDbConnection
        cmd.Connection = con
        con.ConnectionString = connection
        If con.State = ConnectionState.Closed Then
            con.Open()
        End If
        Dim kayitsayisi As Int64 = 0
        Dim formkayitsayisi As Int64 = 0
        cmd.CommandText = sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT     ISNULL(COUNT(*), 0) AS Kayit FROM         " & tbTable & "  " & kriter & " ")
        formkayitsayisi = cmd.ExecuteScalar
        con.Close()
        If formkayitsayisi >= nKayitSinir Then
            kayitsayisi = 0
        Else
            kayitsayisi = 1
        End If
        Return kayitsayisi
        'kayitsayisi = Nothing
        formkayitsayisi = Nothing
        cmd = Nothing
        con = Nothing
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
    Public Function sorgu_nCariHareketID() As Int64
        Dim kriter As String = ""
        'kriter = "WHERE (sKodu = '" & kod & "')  "
        Dim conn As New OleDb.OleDbConnection
        Dim cmd As New OleDb.OleDbCommand
        Dim adapter As New OleDb.OleDbDataAdapter
        'MsgBox(connection_resmi)
        conn.ConnectionString = connection
        cmd.Connection = conn
        conn.Open()
        cmd.CommandText = sorgu_query("SET DATEFORMAT DMY SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT     TOP 1 ISNULL(nHareketID + 1, 0) AS nCariHareketID  FROM         tbFirmaHareketi " & kriter & " ORDER BY nHareketID DESC")
        Dim kayitsayisi = cmd.ExecuteScalar
        Return kayitsayisi
    End Function
    Public Function sorgu_lKalanBakiye(ByVal dteIslemTarihi1 As DateTime, ByVal sSubeMagaza As String) As Decimal
        Dim kriter As String = ""
        'kriter = "WHERE (sKodu = '" & kod & "')  "
        Dim conn As New OleDb.OleDbConnection
        Dim cmd As New OleDb.OleDbCommand
        Dim adapter As New OleDb.OleDbDataAdapter
        'MsgBox(connection_resmi)
        kriter = "Where dteIslemTarihi < '" & dteIslemTarihi1 & "' "
        If Trim(sSubeMagaza) <> "" Then
            kriter += " AND (sSube = '" & sSubeMagaza & "  ') "
        Else
            If sec_bTumu.Checked = True Then
            Else
                kriter += " AND (sSube = '" & sSubeMagaza & "  ') "
            End If
        End If
        conn.ConnectionString = connection
        cmd.Connection = conn
        conn.Open()
        cmd.CommandText = sorgu_query("SET DATEFORMAT DMY SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT     ISNULL(SUM(lTahsilTutar - lTediyeTutar),0) AS lBakiye FROM         tbNakitKasa " & kriter & "")
        Dim kayitsayisi = cmd.ExecuteScalar
        Return kayitsayisi
    End Function
    Public Function sorgu_nKasaIslemID() As Int64
        'Dim kriter As String = ""
        ''kriter = "WHERE (sKodu = '" & kod & "')  "
        'Dim conn As New OleDb.OleDbConnection
        'Dim cmd As New OleDb.OleDbCommand
        'Dim adapter As New OleDb.OleDbDataAdapter
        ''MsgBox(connection_resmi)
        'conn.ConnectionString = connection
        'cmd.Connection = conn
        'conn.Open()
        ''cmd.CommandText = sorgu_query("SET DATEFORMAT DMY SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT     TOP 1 ISNULL(nKasaIslemID + 1, 0) AS nKasaIslemID  FROM         tbNakitKasa " & kriter & " ORDER BY nKasaIslemID DESC")
        'cmd.CommandText = sorgu_query("SET DATEFORMAT DMY SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT     ISNULL(MAX(nKasaIslemID), 0) + 1 AS nKasaIslemID FROM         tbNakitKasa")
        'Dim kayitsayisi = cmd.ExecuteScalar
        'If kayitsayisi = 0 Then
        '    kayitsayisi = 1
        'End If
        'Return kayitsayisi
        Return 1
    End Function
    Public Sub Dataload_tbNakitKasa(ByVal sSubeMagaza As String, ByVal dteIslemTarihi1 As DateTime, ByVal dteIslemTarihi2 As DateTime)
        Try
            ds_tbNakitKasa.Tables(0).Clear()
        Catch ex As Exception
        End Try
        Dim conn As New OleDb.OleDbConnection
        Dim cmd As New OleDb.OleDbCommand
        Dim adapter As New OleDb.OleDbDataAdapter
        conn.ConnectionString = connection
        adapter.SelectCommand = cmd
        'cmd.CommandText = sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT tbNakitKasa.nKasaIslemID, tbNakitKasa.sSube, tbNakitKasa.dteIslemTarihi, tbNakitKasa.lTahsilTutar, tbNakitKasa.lTediyeTutar, tbNakitKasa.sAciklama, tbNakitKasa.nCariHareketID, tbNakitKasa.sHangiUygulama, tbNakitKasa.sHareketTipi, tbNakitKasa.bMuhasebeyeIslendimi, tbNakitKasa.nFirmaID, tbNakitKasa.nHesapID, tbFirma.sKodu AS sFirmaKodu, tbFirma.sAciklama AS sFirmaAciklama, tbHesapPlani.sKodu AS sHesapKodu, tbHesapPlani.sAciklama AS sHesapAciklama, tbNakitKasa.sMasrafYontemi, tbNakitKasa.sDovizCinsi1, tbNakitKasa.lDovizMiktari1, tbNakitKasa.lDovizKuru1, tbNakitKasa.sDovizCinsi2, tbNakitKasa.lDovizMiktari2, tbNakitKasa.lDovizKuru2,tbNakitKasa.dteKayitTarihi,tbNakitKasa.sKullaniciAdi FROM tbNakitKasa INNER JOIN tbFirma ON tbNakitKasa.nFirmaID = tbFirma.nFirmaID INNER JOIN tbHesapPlani ON tbNakitKasa.nHesapID = tbHesapPlani.nHesapID WHERE (tbNakitKasa.sSube = '" & sSubeMagaza & "') AND (tbNakitKasa.dteIslemTarihi BETWEEN '" & dteIslemTarihi & "' AND '" & dteIslemTarihi & "') ORDER BY tbNakitKasa.sSube, tbNakitKasa.nKasaIslemID ")
        Dim kriter As String = ""
        Dim dkriter As String = ""
        kriter = "WHERE (tbNakitKasa.dteIslemTarihi BETWEEN '" & dteIslemTarihi1 & "' AND '" & dteIslemTarihi2 & " ')"
        If Trim(sSubeMagaza) <> "" Then
            kriter += " AND (tbNakitKasa.sSube = '" & sSubeMagaza & "  ') "
            dkriter += " AND (sSube = '" & sSubeMagaza & "  ') "
        Else
            If sec_bTumu.Checked = True Then
            Else
                kriter += " AND (tbNakitKasa.sSube = '" & sSubeMagaza & "  ') "
                dkriter += " AND (sSube = '" & sSubeMagaza & "  ') "
            End If
        End If
        If sec_bDovizliBakiye.Checked = True Then
            cmd.CommandText = sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT tbNakitKasa.nKasaIslemID, tbNakitKasa.sSube, tbNakitKasa.dteIslemTarihi, tbNakitKasa.lTahsilTutar, tbNakitKasa.lTediyeTutar, (SELECT SUM(lBakiye) lBakiye FROM (SELECT sDovizCinsi1, lBakiye = CASE WHEN lTahsilTutar <> 0 AND sDovizCinsi1 <> '' AND lDovizKuru1 <> 0 THEN lDovizMiktari1 WHEN lTediyeTutar <> 0 AND sDovizCinsi1 <> '' THEN - 1 * lDovizMiktari1 WHEN sDovizCinsi1 = '' THEN lTahsilTutar - lTediyeTutar END FROM tbNakitKasa tbDevir WHERE (nKasaIslemID <= tbNakitKasa.nKasaIslemID) AND dteIslemTarihi <= tbNakitKasa.dteIslemTarihi AND sDovizCinsi1 = tbNakitKasa.sDovizCinsi1 " & dkriter & ") tbDevir GROUP BY sDovizCinsi1) AS lKalan ,tbNakitKasa.sAciklama, tbNakitKasa.nCariHareketID, tbNakitKasa.sHangiUygulama, tbNakitKasa.sHareketTipi, tbNakitKasa.bMuhasebeyeIslendimi, tbNakitKasa.nFirmaID, tbNakitKasa.nHesapID, tbFirma.sKodu AS sFirmaKodu, tbFirma.sAciklama AS sFirmaAciklama, tbHesapPlani.sKodu AS sHesapKodu, tbHesapPlani.sAciklama AS sHesapAciklama, tbNakitKasa.sMasrafYontemi, tbNakitKasa.sDovizCinsi1, tbNakitKasa.lDovizMiktari1, tbNakitKasa.lDovizKuru1, tbNakitKasa.sDovizCinsi2, tbNakitKasa.lDovizMiktari2, tbNakitKasa.lDovizKuru2, tbNakitKasa.dteKayitTarihi, tbNakitKasa.sKullaniciAdi, tbFirmaHareketi.sEvrakNo FROM tbNakitKasa INNER JOIN tbFirma ON tbNakitKasa.nFirmaID = tbFirma.nFirmaID INNER JOIN tbHesapPlani ON tbNakitKasa.nHesapID = tbHesapPlani.nHesapID LEFT OUTER JOIN tbFirmaHareketi ON tbNakitKasa.nCariHareketID = tbFirmaHareketi.nHareketID " & kriter & " ORDER BY tbNakitKasa.sSube, tbNakitKasa.nKasaIslemID ")
        Else
            cmd.CommandText = sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT tbNakitKasa.nKasaIslemID, tbNakitKasa.sSube, tbNakitKasa.dteIslemTarihi, tbNakitKasa.lTahsilTutar, tbNakitKasa.lTediyeTutar, (SELECT ISNULL(SUM(lTahsilTutar - lTediyeTutar) , 0) AS lBakiye FROM tbNakitKasa tbDevir WHERE nKasaIslemID <= tbNakitKasa.nKasaIslemID " & dkriter & ") AS lKalan ,tbNakitKasa.sAciklama, tbNakitKasa.nCariHareketID, tbNakitKasa.sHangiUygulama, tbNakitKasa.sHareketTipi, tbNakitKasa.bMuhasebeyeIslendimi, tbNakitKasa.nFirmaID, tbNakitKasa.nHesapID, tbFirma.sKodu AS sFirmaKodu, tbFirma.sAciklama AS sFirmaAciklama, tbHesapPlani.sKodu AS sHesapKodu, tbHesapPlani.sAciklama AS sHesapAciklama, tbNakitKasa.sMasrafYontemi, tbNakitKasa.sDovizCinsi1, tbNakitKasa.lDovizMiktari1, tbNakitKasa.lDovizKuru1, tbNakitKasa.sDovizCinsi2, tbNakitKasa.lDovizMiktari2, tbNakitKasa.lDovizKuru2, tbNakitKasa.dteKayitTarihi, tbNakitKasa.sKullaniciAdi, tbFirmaHareketi.sEvrakNo FROM tbNakitKasa INNER JOIN tbFirma ON tbNakitKasa.nFirmaID = tbFirma.nFirmaID INNER JOIN tbHesapPlani ON tbNakitKasa.nHesapID = tbHesapPlani.nHesapID LEFT OUTER JOIN tbFirmaHareketi ON tbNakitKasa.nCariHareketID = tbFirmaHareketi.nHareketID " & kriter & " ORDER BY tbNakitKasa.sSube, tbNakitKasa.nKasaIslemID ")
        End If

        cmd.Connection = conn
        conn.Open()
        Dim N As Integer = adapter.Fill(ds_tbNakitKasa, "tbNakitKasa")
        conn.Close()
        Dim lKalan As Decimal = 0
        lKalan = sorgu_lKalanBakiye(dteIslemTarihi1, sSubeMagaza)
        Dim dr1 As DataRow
        For Each dr1 In ds_tbNakitKasa.Tables(0).Rows
            'bakiye = bakiye + (dr("lTahsilTutar") - dr("lAlacakTutar"))
            'dr("Bakiye") = bakiye 'Math.Abs(Convert.ToDecimal(bakiye))
            If sec_bDovizliBakiye.Checked = False Then
                lKalan = lKalan + (dr1("lTahsilTutar") - dr1("lTediyeTutar"))
                dr1("lKalan") = lKalan
            End If

        Next
        Dataload_tbYekun(dteIslemTarihi2, sSubeMagaza)
        Dataload_tbDYekun(dteIslemTarihi2, sSubeMagaza)
        If GridView1.RowCount > 0 Then
            GridView1.ClearSelection()
            GridView1.SelectRow(GridView1.RowCount - 1)
            GridView1.FocusedRowHandle = GridView1.RowCount - 1
            PanelControl3.Focus()
            GridControl1.Focus()
        End If
    End Sub
    Public Sub Dataload_tbYekun(ByVal dteIslemTarihi As DateTime, ByVal sSubeMagaza As String)
        Try
            ds_tbNakitKasaToplam.Tables(0).Clear()
        Catch ex As Exception
        End Try
        Dim kriter_devir As String = ""
        Dim kriter_bugun As String = ""
        Dim kriter_genel As String = ""
        kriter_devir = "WHERE (dteIslemTarihi < '" & dteIslemTarihi & "') "
        kriter_bugun = "WHERE (dteIslemTarihi = '" & dteIslemTarihi & "') "
        kriter_genel = "WHERE (dteIslemTarihi <= '" & dteIslemTarihi & "') "
        If Trim(sSubeMagaza) <> "" Then
            kriter_devir += " AND (sSube = '" & sSubeMagaza & " ') "
            kriter_bugun += " AND (sSube = '" & sSubeMagaza & " ') "
            kriter_genel += " AND (sSube = '" & sSubeMagaza & " ') "
        Else
            If sec_bTumu.Checked = True Then
            Else
                kriter_devir += " AND (sSube = '" & sSubeMagaza & " ') "
                kriter_bugun += " AND (sSube = '" & sSubeMagaza & " ') "
                kriter_genel += " AND (sSube = '" & sSubeMagaza & " ') "
            End If
        End If
        Dim conn As New OleDb.OleDbConnection
        Dim cmd As New OleDb.OleDbCommand
        Dim adapter As New OleDb.OleDbDataAdapter
        conn.ConnectionString = connection
        adapter.SelectCommand = cmd
        'cmd.CommandText = sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT N'" & Sorgu_sDil("Devreden", sDil) & "' AS sAciklama, ISNULL(SUM(lTediyeTutar), 0) AS lTediyeTutar, ISNULL(SUM(lTahsilTutar), 0) AS lTahsilTutar, ISNULL(SUM(lTahsilTutar - lTediyeTutar), 0) AS lBakiye FROM tbNakitKasa WHERE (sSube = '" & sSubeMagaza & "') AND (dteIslemTarihi < '" & dteIslemTarihi & "') UNION ALL SELECT N'" & Sorgu_sDil("Bugün", sDil) & "' AS sAciklama, ISNULL(SUM(lTediyeTutar), 0) AS lTediyeTutar, ISNULL(SUM(lTahsilTutar), 0) AS lTahsilTutar, ISNULL(SUM(lTahsilTutar - lTediyeTutar), 0) AS lBakiye FROM tbNakitKasa WHERE (sSube = '" & sSubeMagaza & "') AND (dteIslemTarihi = '" & dteIslemTarihi & "') UNION ALL SELECT N'" & Sorgu_sDil("Genel", sDil) & "' AS sAciklama, ISNULL(SUM(lTediyeTutar), 0) AS lTediyeTutar, ISNULL(SUM(lTahsilTutar), 0) AS lTahsilTutar, ISNULL(SUM(lTahsilTutar - lTediyeTutar), 0) AS lBakiye FROM tbNakitKasa WHERE (sSube = '" & sSubeMagaza & "') AND (dteIslemTarihi <= '" & dteIslemTarihi & "') ")
        cmd.CommandText = sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT N'" & Sorgu_sDil("Devreden", sDil) & "' AS sAciklama, ISNULL(SUM(lTediyeTutar), 0) AS lTediyeTutar, ISNULL(SUM(lTahsilTutar), 0) AS lTahsilTutar, ISNULL(SUM(lTahsilTutar - lTediyeTutar), 0) AS lBakiye FROM tbNakitKasa " & kriter_devir & " UNION ALL SELECT N'" & Sorgu_sDil("Bugün", sDil) & "' AS sAciklama, ISNULL(SUM(lTediyeTutar), 0) AS lTediyeTutar, ISNULL(SUM(lTahsilTutar), 0) AS lTahsilTutar, ISNULL(SUM(lTahsilTutar - lTediyeTutar), 0) AS lBakiye FROM tbNakitKasa " & kriter_bugun & " UNION ALL SELECT N'" & Sorgu_sDil("Genel", sDil) & "' AS sAciklama, ISNULL(SUM(lTediyeTutar), 0) AS lTediyeTutar, ISNULL(SUM(lTahsilTutar), 0) AS lTahsilTutar, ISNULL(SUM(lTahsilTutar - lTediyeTutar), 0) AS lBakiye FROM tbNakitKasa " & kriter_genel & " ")
        cmd.Connection = conn
        conn.Open()
        Dim N As Integer = adapter.Fill(ds_tbNakitKasaToplam, "tbNakitKasaToplam")
        conn.Close()
    End Sub
    Public Sub Dataload_tbDYekun(ByVal dteIslemTarihi As DateTime, ByVal sSubeMagaza As String)
        Try
            ds_tbNakitKasaDToplam.Tables(0).Clear()
        Catch ex As Exception
        End Try
        Dim kriter_devir As String = ""
        Dim kriter_bugun As String = ""
        Dim kriter_genel As String = ""
        kriter_devir = "WHERE (dteIslemTarihi < '" & dteIslemTarihi & "') "
        kriter_bugun = "WHERE (dteIslemTarihi = '" & dteIslemTarihi & "') "
        kriter_genel = "WHERE (dteIslemTarihi <= '" & dteIslemTarihi & "') "
        If Trim(sSubeMagaza) <> "" Then
            kriter_devir += " AND (sSube = '" & sSubeMagaza & "  ') "
            kriter_bugun += " AND (sSube = '" & sSubeMagaza & "  ') "
            kriter_genel += " AND (sSube = '" & sSubeMagaza & "  ') "
        Else
            If sec_bTumu.Checked = True Then
            Else
                kriter_devir += " AND (sSube = '" & sSubeMagaza & "  ') "
                kriter_bugun += " AND (sSube = '" & sSubeMagaza & "  ') "
                kriter_genel += " AND (sSube = '" & sSubeMagaza & "  ') "
            End If
        End If
        Dim conn As New OleDb.OleDbConnection
        Dim cmd As New OleDb.OleDbCommand
        Dim adapter As New OleDb.OleDbDataAdapter
        conn.ConnectionString = connection
        adapter.SelectCommand = cmd
        'cmd.CommandText = sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT N'" & Sorgu_sDil("Devreden", sDil) & "' AS sAciklama, sDovizCinsi1, SUM(lTahsilTutar) lTahsilTutar, SUM(lTediyeTutar) lTediyeTutar, SUM(lBakiye) lBakiye FROM (SELECT sSube, dteIslemTarihi, sDovizCinsi1, lTahsilTutar = CASE WHEN lTahsilTutar > 0 AND sDovizCinsi1 <> '' AND lDovizKuru1 <> 0 THEN lTahsilTutar / lDovizKuru1 ELSE lTahsilTutar END, lTediyeTutar = CASE WHEN lTediyeTutar > 0 AND sDovizCinsi1 <> '' AND lDovizKuru1 <> 0 THEN lTediyeTutar / lDovizKuru1 ELSE lTediyeTutar END, lBakiye = CASE WHEN lTahsilTutar <> 0 AND sDovizCinsi1 <> '' AND lDovizKuru1 <> 0 THEN lDovizMiktari1 WHEN lTediyeTutar <> 0 AND sDovizCinsi1 <> '' THEN - 1 * lDovizMiktari1 WHEN sDovizCinsi1 = '' THEN lTahsilTutar - lTediyeTutar END FROM tbNakitKasa) AS tNakitKasa WHERE sSube = '" & sSubeMagaza & "' AND dteIslemTarihi < '" & dteIslemTarihi & "' GROUP BY sDovizCinsi1 UNION ALL SELECT N'" & Sorgu_sDil("Bugün", sDil) & "' AS sAciklama, sDovizCinsi1, SUM(lTahsilTutar) lTahsilTutar, SUM(lTediyeTutar) lTediyeTutar, SUM(lBakiye) lBakiye FROM (SELECT sSube, dteIslemTarihi, sDovizCinsi1, lTahsilTutar = CASE WHEN lTahsilTutar > 0 AND sDovizCinsi1 <> '' AND lDovizKuru1 <> 0 THEN lTahsilTutar / lDovizKuru1 ELSE lTahsilTutar END, lTediyeTutar = CASE WHEN lTediyeTutar > 0 AND sDovizCinsi1 <> '' AND lDovizKuru1 <> 0 THEN lTediyeTutar / lDovizKuru1 ELSE lTediyeTutar END, lBakiye = CASE WHEN lTahsilTutar <> 0 AND sDovizCinsi1 <> '' AND lDovizKuru1 <> 0 THEN lDovizMiktari1 WHEN lTediyeTutar <> 0 AND sDovizCinsi1 <> '' THEN - 1 * lDovizMiktari1 WHEN sDovizCinsi1 = '' THEN lTahsilTutar - lTediyeTutar END FROM tbNakitKasa) AS tNakitKasa WHERE sSube = '" & sSubeMagaza & "' AND dteIslemTarihi = '" & dteIslemTarihi & "' GROUP BY sDovizCinsi1 UNION ALL SELECT N'" & Sorgu_sDil("Genel", sDil) & "' AS sAciklama, sDovizCinsi1, SUM(lTahsilTutar) lTahsilTutar, SUM(lTediyeTutar) lTediyeTutar, SUM(lBakiye) lBakiye FROM (SELECT sSube, dteIslemTarihi, sDovizCinsi1, lTahsilTutar = CASE WHEN lTahsilTutar > 0 AND sDovizCinsi1 <> '' AND lDovizKuru1 <> 0 THEN lTahsilTutar / lDovizKuru1 ELSE lTahsilTutar END, lTediyeTutar = CASE WHEN lTediyeTutar > 0 AND sDovizCinsi1 <> '' AND lDovizKuru1 <> 0 THEN lTediyeTutar / lDovizKuru1 ELSE lTediyeTutar END, lBakiye = CASE WHEN lTahsilTutar <> 0 AND sDovizCinsi1 <> '' AND lDovizKuru1 <> 0 THEN lDovizMiktari1 WHEN lTediyeTutar <> 0 AND sDovizCinsi1 <> '' THEN - 1 * lDovizMiktari1 WHEN sDovizCinsi1 = '' THEN lTahsilTutar - lTediyeTutar END FROM tbNakitKasa) AS tNakitKasa WHERE sSube = '" & sSubeMagaza & "' AND dteIslemTarihi <= '" & dteIslemTarihi & "' GROUP BY sDovizCinsi1  ")
        cmd.CommandText = sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT N'" & Sorgu_sDil("Devreden", sDil) & "' AS sAciklama, sDovizCinsi1, SUM(lTahsilTutar) lTahsilTutar, SUM(lTediyeTutar) lTediyeTutar, SUM(lBakiye) lBakiye FROM (SELECT sSube, dteIslemTarihi, sDovizCinsi1, lTahsilTutar = CASE WHEN lTahsilTutar > 0 AND sDovizCinsi1 <> '' AND lDovizKuru1 <> 0 THEN lTahsilTutar / lDovizKuru1 ELSE lTahsilTutar END, lTediyeTutar = CASE WHEN lTediyeTutar > 0 AND sDovizCinsi1 <> '' AND lDovizKuru1 <> 0 THEN lTediyeTutar / lDovizKuru1 ELSE lTediyeTutar END, lBakiye = CASE WHEN lTahsilTutar <> 0 AND sDovizCinsi1 <> '' AND lDovizKuru1 <> 0 THEN lDovizMiktari1 WHEN lTediyeTutar <> 0 AND sDovizCinsi1 <> '' THEN - 1 * lDovizMiktari1 WHEN sDovizCinsi1 = '' THEN lTahsilTutar - lTediyeTutar END FROM tbNakitKasa) AS tNakitKasa " & kriter_devir & " GROUP BY sDovizCinsi1 UNION ALL SELECT N'" & Sorgu_sDil("Bugün", sDil) & "' AS sAciklama, sDovizCinsi1, SUM(lTahsilTutar) lTahsilTutar, SUM(lTediyeTutar) lTediyeTutar, SUM(lBakiye) lBakiye FROM (SELECT sSube, dteIslemTarihi, sDovizCinsi1, lTahsilTutar = CASE WHEN lTahsilTutar > 0 AND sDovizCinsi1 <> '' AND lDovizKuru1 <> 0 THEN lTahsilTutar / lDovizKuru1 ELSE lTahsilTutar END, lTediyeTutar = CASE WHEN lTediyeTutar > 0 AND sDovizCinsi1 <> '' AND lDovizKuru1 <> 0 THEN lTediyeTutar / lDovizKuru1 ELSE lTediyeTutar END, lBakiye = CASE WHEN lTahsilTutar <> 0 AND sDovizCinsi1 <> '' AND lDovizKuru1 <> 0 THEN lDovizMiktari1 WHEN lTediyeTutar <> 0 AND sDovizCinsi1 <> '' THEN - 1 * lDovizMiktari1 WHEN sDovizCinsi1 = '' THEN lTahsilTutar - lTediyeTutar END FROM tbNakitKasa) AS tNakitKasa " & kriter_bugun & " GROUP BY sDovizCinsi1 UNION ALL SELECT N'" & Sorgu_sDil("Genel", sDil) & "' AS sAciklama, sDovizCinsi1, SUM(lTahsilTutar) lTahsilTutar, SUM(lTediyeTutar) lTediyeTutar, SUM(lBakiye) lBakiye FROM (SELECT sSube, dteIslemTarihi, sDovizCinsi1, lTahsilTutar = CASE WHEN lTahsilTutar > 0 AND sDovizCinsi1 <> '' AND lDovizKuru1 <> 0 THEN lTahsilTutar / lDovizKuru1 ELSE lTahsilTutar END, lTediyeTutar = CASE WHEN lTediyeTutar > 0 AND sDovizCinsi1 <> '' AND lDovizKuru1 <> 0 THEN lTediyeTutar / lDovizKuru1 ELSE lTediyeTutar END, lBakiye = CASE WHEN lTahsilTutar <> 0 AND sDovizCinsi1 <> '' AND lDovizKuru1 <> 0 THEN lDovizMiktari1 WHEN lTediyeTutar <> 0 AND sDovizCinsi1 <> '' THEN - 1 * lDovizMiktari1 WHEN sDovizCinsi1 = '' THEN lTahsilTutar - lTediyeTutar END FROM tbNakitKasa) AS tNakitKasa " & kriter_genel & " GROUP BY sDovizCinsi1  ")
        cmd.Connection = conn
        conn.Open()
        Dim N As Integer = adapter.Fill(ds_tbNakitKasaDToplam, "tbNakitKasaDToplam")
        conn.Close()
    End Sub
    Public Sub BeginSearch(ByVal sKodu As String)
        sFirmaKodu = sKodu
        Dim MyThread As New Thread(AddressOf loading)
        Try
            MyThread.Start()
        Catch ex As Exception
        End Try
    End Sub
    Sub loading()
        Try
            Dataload_tbFirma(sFirmaKodu)
        Finally
            _searching = False
            BeginInvoke(_onSearchComplete, New Object() {Me, EventArgs.Empty})
        End Try
    End Sub
    Public Sub Dataload_tbFirma(ByVal sFirmaKodu As String)
        Try
            ds_tbFirma.Tables(0).Clear()
        Catch ex As Exception
        End Try
        Dim conn As New OleDb.OleDbConnection
        Dim cmd As New OleDb.OleDbCommand
        Dim adapter As New OleDb.OleDbDataAdapter
        conn.ConnectionString = connection
        adapter.SelectCommand = cmd
        'cmd.CommandText = sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT nFirmaID, sKodu, sAciklama, nOzelIskontosu, lKrediLimiti, nVadeGun, nHesapID, (SELECT ISNULL(SUM(lBorcTutar) , 0) AS lBorcTutar FROM tbFirmaHareketi WHERE nFirmaID = tbFirma.nFirmaID) AS lBorcTutar, (SELECT ISNULL(SUM(lAlacakTutar) , 0) AS lAlacakTutar FROM tbFirmaHareketi WHERE nFirmaID = tbFirma.nFirmaID) AS lAlacakTutar, (SELECT ISNULL(SUM(lBorcTutar - lAlacakTutar) , 0) AS lBakiye FROM tbFirmaHareketi WHERE nFirmaID = tbFirma.nFirmaID) AS lBakiye, (SELECT ISNULL(SUM(lTutar) , 0) AS Expr1 FROM tbCekSenet WHERE (nVerenID = tbFirma.nFirmaID) AND (sCekSenetTipi = 'AC' OR sCekSenetTipi = 'AS') AND (nSonCekSenetIslem <= 6) AND (nSonCekSenetIslem <> 2)) AS lRisk FROM tbFirma WHERE (sKodu = '" & sFirmaKodu & "') ")
        'cmd.CommandText = sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT nFirmaID, sKodu, sAciklama, nOzelIskontosu, lKrediLimiti, nVadeGun, nHesapID, sDovizCinsi,lBorcTutar = CASE WHEN tbFirma.sDovizCinsi = '   ' THEN (SELECT ISNULL(SUM(lBorcTutar ), 0) AS lBorcTutar FROM tbFirmaHareketi WHERE nFirmaID = tbFirma.nFirmaID) ELSE (SELECT ISNULL(SUM((lBorcTutar )/lDovizKuru1) , 0) AS lBorcTutar FROM tbFirmaHareketi WHERE nFirmaID = tbFirma.nFirmaID AND sDovizCinsi1 = tbFirma.sDovizCinsi) END, lAlacakTutar = CASE WHEN tbFirma.sDovizCinsi = '   ' THEN (SELECT ISNULL(SUM(lAlacakTutar), 0) AS lAlacakTutar FROM tbFirmaHareketi WHERE nFirmaID = tbFirma.nFirmaID) ELSE (SELECT ISNULL(SUM((lAlacakTutar)/lDovizKuru1) , 0) AS lAlacakTutar FROM tbFirmaHareketi WHERE nFirmaID = tbFirma.nFirmaID AND sDovizCinsi1 = tbFirma.sDovizCinsi) END, lBakiye = CASE WHEN tbFirma.sDovizCinsi = '   ' THEN (SELECT ISNULL(SUM(lBorcTutar - lAlacakTutar), 0) AS lBakiye FROM tbFirmaHareketi WHERE nFirmaID = tbFirma.nFirmaID) ELSE (SELECT ISNULL(SUM((lBorcTutar - lAlacakTutar)/lDovizKuru1) , 0) AS lBakiye FROM tbFirmaHareketi WHERE nFirmaID = tbFirma.nFirmaID AND sDovizCinsi1 = tbFirma.sDovizCinsi) END, (SELECT ISNULL(SUM(lTutar) , 0) AS Expr1 FROM tbCekSenet WHERE (nVerenID = tbFirma.nFirmaID) AND (sCekSenetTipi = 'AC' OR sCekSenetTipi = 'AS') AND (nSonCekSenetIslem <= 6) AND (nSonCekSenetIslem <> 2)) AS lRisk FROM tbFirma WHERE (sKodu = '" & Trim(sFirmaKodu) & "') ")
        cmd.CommandText = sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT nFirmaID, sKodu, sAciklama, nOzelIskontosu, lKrediLimiti, nVadeGun, nHesapID, sDovizCinsi,lBorcTutar = CASE WHEN tbFirma.sDovizCinsi = '   ' THEN (SELECT ISNULL(SUM(lBorcTutar ), 0) AS lBorcTutar FROM tbFirmaHareketi WHERE nFirmaID = tbFirma.nFirmaID) ELSE (SELECT ISNULL(SUM((lBorcTutar )/lDovizKuru1) , 0) AS lBorcTutar FROM tbFirmaHareketi WHERE nFirmaID = tbFirma.nFirmaID AND sDovizCinsi1 = tbFirma.sDovizCinsi) END, lAlacakTutar = CASE WHEN tbFirma.sDovizCinsi = '   ' THEN (SELECT ISNULL(SUM(lAlacakTutar), 0) AS lAlacakTutar FROM tbFirmaHareketi WHERE nFirmaID = tbFirma.nFirmaID) ELSE (SELECT ISNULL(SUM((lAlacakTutar)/lDovizKuru1) , 0) AS lAlacakTutar FROM tbFirmaHareketi WHERE nFirmaID = tbFirma.nFirmaID AND sDovizCinsi1 = tbFirma.sDovizCinsi) END, lBakiye = CASE WHEN tbFirma.sDovizCinsi = '   ' THEN (SELECT ISNULL(SUM(lBorcTutar - lAlacakTutar), 0) AS lBakiye FROM tbFirmaHareketi WHERE nFirmaID = tbFirma.nFirmaID) ELSE (SELECT ISNULL(SUM((lBorcTutar - lAlacakTutar)/lDovizKuru1) , 0) AS lBakiye FROM tbFirmaHareketi WHERE nFirmaID = tbFirma.nFirmaID AND sDovizCinsi1 = tbFirma.sDovizCinsi) END, (SELECT ISNULL(SUM(lTutar) , 0) AS Expr1 FROM tbCekSenet WHERE (nVerenID = tbFirma.nFirmaID) AND (sCekSenetTipi = 'AC' OR sCekSenetTipi = 'AS') AND (nSonCekSenetIslem <= 6) AND (nSonCekSenetIslem <> 2)) AS lRisk FROM tbFirma WHERE (sKodu = '" & sFirmaKodu & "') ")
        cmd.Connection = conn
        conn.Open()
        Dim N As Integer = adapter.Fill(ds_tbFirma, "Table1")
        'VGrid_Firma.DataMember = Nothing
        'VGrid_Firma.DataSource = ds_tbFirma.Tables(0)
        conn.Close()
    End Sub
    Public Function Dataload_tbCekSenetBordro(ByVal ara As String, ByVal konum As String, ByVal ara_kriter As String, ByVal sCekSenetTipi As String, ByVal nCekSenetIslem As String, ByVal nFirmaID As String, ByVal dteBordroTarihi1 As DateTime, ByVal dteBordroTarihi2 As DateTime, ByVal dteVadeTarihi1 As DateTime, ByVal dteVadeTarihi2 As DateTime, ByVal lBordroNo1 As Int64, ByVal lBordroNo2 As Int64, ByVal sEvrakNo1 As String, ByVal sEvrakNo2 As String, ByVal sBankaKodu As String, ByVal sHareketTipi As String, ByVal sCekSenetKodu As String) As DataSet
        Dim kriter As String = " WHERE tbCekSenet.nCekSenetID = tbCekSenetBordro.nCekSenetID AND tbCekSenet.sHareketTipi = tbHareketTipi.sHareketTipi AND tbFirma.nFirmaID = tbCekSenetBordro.nFirmaID AND tbCekSenet.sBankaKodu = tbBanka.sBankaKodu  AND tbCekSenetIslem.nCekSenetIslem = tbCekSenetBordro.nCekSenetIslem AND (tbCekSenet.sCekSenetTipi IN ('AC','AS','BC','BS'))"
        kriter += " AND tbCekSenetBordro.dteBordroTarihi between '" & dteBordroTarihi1 & "' and '" & dteBordroTarihi2 & "' "
        kriter += " AND tbCekSenet.dteVadeTarihi between '" & dteVadeTarihi1 & "' and '" & dteVadeTarihi2 & "' "
        kriter += " and tbCekSenet.lCekSenetNo between '" & lBordroNo1 & "' and '" & lBordroNo2 & "'"
        'kriter += " and tbCekSenet.sOrjinalCekSenetNo between '" & sEvrakNo1 & "' and '" & sEvrakNo2 & "'"
        If Trim(sBankaKodu) <> "" Then
            kriter += " And tbCekSenet.sBankaKodu = '" & sBankaKodu & "' "
        End If
        'If nCekSenetIslem > 0 Then
        '    kriter += " and tbCekSenetBordro.nCekSenetIslem =" & nCekSenetIslem & " "
        'End If
        'If CStr(Trim(ara.ToString)) <> "" Then
        '    If sec_konum.Text = "Kodu" Then
        '        kriter += " AND   (tbFirma_1.sKodu " & sorgu_kriter_string(ara, ara_kriter) & " )"
        '    ElseIf sec_konum.Text = "Adý" Then
        '        kriter += " AND  (tbFirma_1.sAciklama " & sorgu_kriter_string(ara, ara_kriter) & " )"
        '    End If
        'End If
        If nCekSenetIslem <> "[Tümü]" And nCekSenetIslem <> "" Then
            kriter += " and tbCekSenetBordro.nCekSenetIslem IN (" & nCekSenetIslem & ") "
        End If
        If Trim(sCekSenetKodu) <> "" Then
            If sec_bTumu.Checked = True Then
            Else
                kriter += " and tbCekSenet.sCekSenetKodu1 = '" & Trim(sCekSenetKodu) & "'"
            End If
        End If
        Dim conn As New OleDb.OleDbConnection
        Dim cmd As New OleDb.OleDbCommand
        Dim adapter As New OleDb.OleDbDataAdapter
        conn.ConnectionString = connection
        cmd.CommandTimeout = False
        adapter.SelectCommand = cmd
        'cmd.CommandText = sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT tbCekSenet.nCekSenetID, tbCekSenet.lCekSenetNo, tbCekSenet.lTutar, tbCekSenet.dteVadeTarihi, tbCekSenet.sBankaKodu, tbCekSenet.sBankaHesapNo,tbCekSenet.sIl, tbCekSenet.sSemt, tbCekSenet.sBorclusu, tbCekSenet.sBorcluVergiDairesi, tbCekSenet.sBorcluVergiNumarasi, tbCekSenet.sNot, tbCekSenet.sCekSenetKodu1, tbCekSenet.sCekSenetKodu2,tbBanka.sAciklama AS sBankaAciklama, tbCekSenet.sOrjinalCekSenetNo, VEREN.sKodu AS sVerenFirmaKodu, VEREN.sAciklama AS sVerenFirmaAciklama, tbCekSenet.nSonCekSenetIslem, tbCekSenetIslem.sAciklama AS sIslem, VEREN.sKodu AS sAlanFirmaKodu, VEREN.sAciklama AS sAlanFirmaAciklama, tbCekSenet.sHareketTipi, tbCekSenet.sDovizCinsi1, tbCekSenet.lDovizMiktari1, tbCekSenet.lDovizKuru1,tbCekSenetBordro.nBordroSatirID, tbCekSenetBordro.dteBordroTarihi FROM tbFirma VEREN INNER JOIN tbCekSenet ON VEREN.nFirmaID = tbCekSenet.nVerenID INNER JOIN tbBanka ON tbCekSenet.sBankaKodu = tbBanka.sBankaKodu INNER JOIN tbHareketTipi ON tbCekSenet.sHareketTipi = tbHareketTipi.sHareketTipi INNER JOIN tbFirma tbFirma_1 INNER JOIN tbCekSenetBordro ON tbFirma_1.nFirmaID = tbCekSenetBordro.nFirmaID ON tbCekSenet.nSonBordroSatirID = tbCekSenetBordro.nBordroSatirID INNER JOIN tbCekSenetIslem ON tbCekSenet.nSonCekSenetIslem = tbCekSenetIslem.nCekSenetIslem " & kriter & " ORDER BY tbCekSenet.dteVadeTarihi")
        cmd.CommandText = sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT tbCekSenet.sCekSenetTipi,tbCekSenetBordro.dteBordroTarihi,CONVERT(char(10), tbCekSenetBordro.dteBordroTarihi, 103) + ' ' + tbCekSenetIslem.sAciklama AS Status, tbCekSenetBordro.lBordroNo, tbFirma.sKodu, tbFirma.sAciklama, tbCekSenet.lCekSenetNo, tbBanka.sBankaKodu, tbBanka.sAciklama AS sBankaAciklama, tbCekSenet.sSemt, tbCekSenet.sIl, tbCekSenet.dteVadeTarihi, tbCekSenet.lTutar, lGiren = CASE WHEN tbCekSenetBordro.nCekSenetIslem = 1 OR tbCekSenetBordro.nCekSenetIslem = 6 OR tbCekSenetBordro.nCekSenetIslem = 22 THEN tbCekSenet.lTutar ELSE 0 END, lCikan = CASE WHEN tbCekSenetBordro.nCekSenetIslem = 2 OR tbCekSenetBordro.nCekSenetIslem = 3 OR tbCekSenetBordro.nCekSenetIslem = 4 OR tbCekSenetBordro.nCekSenetIslem = 5 OR tbCekSenetBordro.nCekSenetIslem = 20 THEN tbCekSenet.lTutar ELSE 0 END,(DateDiff(Day, tbCekSenetBordro.dteBordroTarihi, tbCekSenet.dteVadeTarihi) * tbCekSenet.lTutar) VadeGun, tbHareketTipi.sHareketTipi, tbHareketTipi.sAciklama AS sHareketAciklama, tbCekSenet.sOrjinalCekSenetNo, sCekSenetKodu1 + (CASE sCekSenetKodu1 WHEN '' THEN '' ELSE ' - ' END) + (SELECT sAciklama FROM tbCekSenetKodu WHERE tbCekSenetKodu.sCekSenetKodu = tbCekSenet.sCekSenetKodu1) AS Kod1, sCekSenetKodu2 + (CASE sCekSenetKodu2 WHEN '' THEN '' ELSE ' - ' END) + (SELECT sAciklama FROM tbCekSenetKodu WHERE tbCekSenetKodu.sCekSenetKodu = tbCekSenet.sCekSenetKodu2) AS Kod2,tbCekSenet.sNot FROM tbCekSenetIslem, tbCekSenetBordro, tbCekSenet, tbFirma, tbBanka, tbHareketTipi " & kriter & " ORDER BY tbCekSenetBordro.dteBordroTarihi, tbCekSenetBordro.lBordroNo, tbFirma.sKodu, tbCekSenet.dteVadeTarihi")
        cmd.Connection = conn
        conn.Open()
        Dim Datastoklar1 As New DataSet
        Dim N As Integer = adapter.Fill(Datastoklar1, "tbCekSenetBordro")
        conn.Close()
        Return Datastoklar1
    End Function
    Public Function dataload_tbCekSenet(ByVal ara As String, ByVal konum As String, ByVal ara_kriter As String, ByVal sCekSenetTipi As String, ByVal nCekSenetIslem As String, ByVal nFirmaID As String, ByVal dteBordroTarihi1 As DateTime, ByVal dteBordroTarihi2 As DateTime, ByVal lBordroNo1 As Int64, ByVal lBordroNo2 As Int64, ByVal sEvrakNo1 As String, ByVal sEvrakNo2 As String, ByVal sBankaKodu As String, ByVal sHareketTipi As String, ByVal sCekSenetKodu As String, ByVal sTarih As String) As DataSet
        Dim kriter As String = "WHERE (tbCekSenet.sCekSenetTipi = '" & sCekSenetTipi & "')"
        If sTarih = "Vade:" Then
            kriter += " AND tbCekSenet.dteVadeTarihi between '" & dteBordroTarihi1 & "' and '" & dteBordroTarihi2 & "' "
        ElseIf sTarih = "Tarih:" Then
            kriter += " AND tbCekSenetBordro.dteBordroTarihi between '" & dteBordroTarihi1 & "' and '" & dteBordroTarihi2 & "' "
        End If
        kriter += " and tbCekSenet.lCekSenetNo between '" & lBordroNo1 & "' and '" & lBordroNo2 & "'"
        'kriter += " and tbCekSenet.sOrjinalCekSenetNo between '" & sEvrakNo1 & "' and '" & sEvrakNo2 & "'"
        If Trim(sBankaKodu) <> "" Then
            kriter += " And tbCekSenet.sBankaKodu = '" & sBankaKodu & "' "
        End If
        'If nCekSenetIslem > 0 Then
        '    kriter += " and tbCekSenetBordro.nCekSenetIslem =" & nCekSenetIslem & " "
        'End If
        If nCekSenetIslem <> "[Tümü]" Then
            kriter += " and tbCekSenetBordro.nCekSenetIslem IN (" & nCekSenetIslem & ") "
        End If
        'If sCekSenetKodu <> "" Then
        '    kriter += " and tbCekSenet.sCekSenetKodu1 = '" & sCekSenetKodu & "'"
        'End If
        If Trim(sCekSenetKodu) <> "" Then
            If sec_bTumu.Checked = True Then
            Else
                kriter += " and tbCekSenet.sCekSenetKodu1 = '" & Trim(sCekSenetKodu) & "'"
            End If
        End If
        'If CStr(Trim(ara.ToString)) <> "" Then
        '    If sec_konum.Text = "Kodu" Then
        '        kriter += " AND   (tbFirma_1.sKodu " & sorgu_kriter_string(ara, ara_kriter) & " )"
        '    ElseIf sec_konum.Text = "Adý" Then
        '        kriter += " AND  (tbFirma_1.sAciklama " & sorgu_kriter_string(ara, ara_kriter) & " )"
        '    End If
        'End If
        'If nCekSenetIslem = "'1'" Or nCekSenetIslem = "'6'" Then
        '    If CStr(Trim(ara.ToString)) <> "" Then
        '        If sec_konum.Text = "Kodu" Then
        '            kriter += " AND   (Veren.sKodu " & sorgu_kriter_string(ara, ara_kriter) & " )"
        '        ElseIf sec_konum.Text = "Adý" Then
        '            kriter += " AND  (Veren.sAciklama " & sorgu_kriter_string(ara, ara_kriter) & " )"
        '        End If
        '    End If
        'Else
        '    If CStr(Trim(ara.ToString)) <> "" Then
        '        If sec_konum.Text = "Kodu" Then
        '            kriter += " AND   (tbFirma_1.sKodu " & sorgu_kriter_string(ara, ara_kriter) & " )"
        '        ElseIf sec_konum.Text = "Adý" Then
        '            kriter += " AND  (tbFirma_1.sAciklama " & sorgu_kriter_string(ara, ara_kriter) & " )"
        '        End If
        '    End If
        'End If
        Dim conn As New OleDb.OleDbConnection
        Dim cmd As New OleDb.OleDbCommand
        Dim adapter As New OleDb.OleDbDataAdapter
        conn.ConnectionString = connection
        cmd.CommandTimeout = False
        adapter.SelectCommand = cmd
        'cmd.CommandText = sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT tbCekSenet.nCekSenetID, tbCekSenet.lCekSenetNo, tbCekSenet.sCekSenetTipi,tbCekSenet.lTutar, tbCekSenet.dteVadeTarihi, tbCekSenet.sBankaKodu, tbCekSenet.sBankaHesapNo,tbCekSenet.sIl, tbCekSenet.sSemt, tbCekSenet.sBorclusu, tbCekSenet.sBorcluVergiDairesi, tbCekSenet.sBorcluVergiNumarasi, tbCekSenet.sNot, tbCekSenet.nVerenID,tbCekSenet.sCekSenetKodu1, tbCekSenet.sCekSenetKodu2,tbBanka.sAciklama AS sBankaAciklama, tbCekSenet.sOrjinalCekSenetNo, VEREN.sKodu AS sVerenFirmaKodu, VEREN.sAciklama AS sVerenFirmaAciklama, tbCekSenet.nSonCekSenetIslem, tbCekSenetIslem.sAciklama AS sIslem, VEREN.sKodu AS sAlanFirmaKodu, VEREN.sAciklama AS sAlanFirmaAciklama, tbCekSenet.sHareketTipi, tbCekSenet.sDovizCinsi1, tbCekSenet.lDovizMiktari1, tbCekSenet.lDovizKuru1,tbCekSenetBordro.nBordroSatirID, tbCekSenetBordro.dteBordroTarihi,(SELECT SUM(lProtestoMasrafi) FROM tbCekSenetBordro WHERE nCekSenetID = tbCekSenet.nCekSenetID) AS lTahsilat, tbCekSenet.lTutar - (SELECT SUM(lProtestoMasrafi) FROM tbCekSenetBordro WHERE nCekSenetID = tbCekSenet.nCekSenetID) AS lKalan,tbCekSenet.sKullaniciAdi,tbCekSenet.dteKayitTarihi FROM tbFirma VEREN INNER JOIN tbCekSenet ON VEREN.nFirmaID = tbCekSenet.nVerenID INNER JOIN tbBanka ON tbCekSenet.sBankaKodu = tbBanka.sBankaKodu INNER JOIN tbHareketTipi ON tbCekSenet.sHareketTipi = tbHareketTipi.sHareketTipi INNER JOIN tbFirma tbFirma_1 INNER JOIN tbCekSenetBordro ON tbFirma_1.nFirmaID = tbCekSenetBordro.nFirmaID ON tbCekSenet.nSonBordroSatirID = tbCekSenetBordro.nBordroSatirID INNER JOIN tbCekSenetIslem ON tbCekSenet.nSonCekSenetIslem = tbCekSenetIslem.nCekSenetIslem " & kriter & " ORDER BY tbCekSenet.dteVadeTarihi")
        cmd.CommandText = sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT tbCekSenet.nCekSenetID, tbCekSenet.lCekSenetNo, tbCekSenet.sCekSenetTipi,tbCekSenet.lTutar, tbCekSenet.dteVadeTarihi, tbCekSenet.sBankaKodu, tbCekSenet.sBankaHesapNo,tbCekSenet.sIl, tbCekSenet.sSemt, tbCekSenet.sBorclusu, tbCekSenet.sBorcluVergiDairesi, tbCekSenet.sBorcluVergiNumarasi, tbCekSenet.sNot, tbCekSenet.nVerenID,tbCekSenet.sCekSenetKodu1, tbCekSenet.sCekSenetKodu2,tbBanka.sAciklama AS sBankaAciklama, tbCekSenet.sOrjinalCekSenetNo, VEREN.sKodu AS sVerenFirmaKodu, VEREN.sAciklama AS sVerenFirmaAciklama, tbCekSenet.nSonCekSenetIslem, tbCekSenetIslem.sAciklama AS sIslem, tbFirma_1.sKodu AS sAlanFirmaKodu, tbFirma_1.sAciklama AS sAlanFirmaAciklama, tbCekSenet.sHareketTipi, tbCekSenet.sDovizCinsi1, tbCekSenet.lDovizMiktari1, tbCekSenet.lDovizKuru1,tbCekSenetBordro.nBordroSatirID, tbCekSenetBordro.dteBordroTarihi,(SELECT SUM(lProtestoMasrafi) FROM tbCekSenetBordro WHERE nCekSenetID = tbCekSenet.nCekSenetID) AS lTahsilat, tbCekSenet.lTutar - (SELECT SUM(lProtestoMasrafi) FROM tbCekSenetBordro WHERE nCekSenetID = tbCekSenet.nCekSenetID) AS lKalan,tbCekSenet.sKullaniciAdi,tbCekSenet.dteKayitTarihi FROM tbFirma VEREN INNER JOIN tbCekSenet ON VEREN.nFirmaID = tbCekSenet.nVerenID INNER JOIN tbBanka ON tbCekSenet.sBankaKodu = tbBanka.sBankaKodu INNER JOIN tbHareketTipi ON tbCekSenet.sHareketTipi = tbHareketTipi.sHareketTipi INNER JOIN tbFirma tbFirma_1 INNER JOIN tbCekSenetBordro ON tbFirma_1.nFirmaID = tbCekSenetBordro.nFirmaID ON tbCekSenet.nSonBordroSatirID = tbCekSenetBordro.nBordroSatirID INNER JOIN tbCekSenetIslem ON tbCekSenet.nSonCekSenetIslem = tbCekSenetIslem.nCekSenetIslem " & kriter & " ORDER BY tbCekSenet.dteVadeTarihi")
        cmd.Connection = conn
        conn.Open()
        Dim Datastoklar1 As New DataSet
        Dim N As Integer = adapter.Fill(Datastoklar1, "tbCekSenet")
        conn.Close()
        Return Datastoklar1
    End Function
    Private Function tbNakitKasa_kaydet_yeni(ByVal nKasaIslemID As Int64, ByVal sSube As String, ByVal dteIslemTarihi As DateTime, ByVal lTahsilTutar As Decimal, ByVal lTediyeTutar As Decimal, ByVal sAciklama As String, ByVal nCariHareketID As Int64, ByVal nFirmaID As Int64, ByVal nHesapID As Int64, ByVal sHangiUygulama As String, ByVal sHareketTipi As String, ByVal sKullaniciAdi As String, ByVal dteKayitTarihi As DateTime, ByVal bMuhasebeyeIslendimi As Byte, ByVal sMasrafYontemi As String, ByVal sDovizCinsi1 As String, ByVal lDovizMiktari1 As Decimal, ByVal lDovizKuru1 As Decimal, ByVal sDovizCinsi2 As String, ByVal lDovizMiktari2 As Decimal, ByVal lDovizKuru2 As Decimal, ByVal sSonKullaniciAdi As String, ByVal dteSonUpdateTarihi As DateTime) As Int64
        Dim con As New OleDb.OleDbConnection
        Dim cmd As New OleDb.OleDbCommand
        cmd.Connection = con
        con.ConnectionString = connection
        If con.State = ConnectionState.Closed = True Then
            con.Open()
        End If
        'cmd.CommandText = sorgu_query("SET DATEFORMAT DMY SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED INSERT INTO tbNakitKasa (nKasaIslemID, sSube, dteIslemTarihi, lTahsilTutar, lTediyeTutar, sAciklama, nCariHareketID, nFirmaID, nHesapID, sHangiUygulama, sHareketTipi, sKullaniciAdi, dteKayitTarihi, bMuhasebeyeIslendimi, sMasrafYontemi, sDovizCinsi1, lDovizMiktari1, lDovizKuru1, sDovizCinsi2, lDovizMiktari2, lDovizKuru2, sSonKullaniciAdi, dteSonUpdateTarihi) VALUES     (" & nKasaIslemID & ", '" & sSube & "', '" & dteIslemTarihi & "', " & lTahsilTutar & ", " & lTediyeTutar & ", N'" & sAciklama & "', " & nCariHareketID & ", " & nFirmaID & ", " & nHesapID & ", '" & sHangiUygulama & "', '" & sHareketTipi & "', '" & sKullaniciAdi & "', '" & dteKayitTarihi & "', " & bMuhasebeyeIslendimi & ", '" & sMasrafYontemi & "', '" & sDovizCinsi1 & "', " & lDovizMiktari1 & ", " & lDovizKuru1 & ", '" & sDovizCinsi2 & "', " & lDovizMiktari2 & ", " & lDovizKuru2 & ", '" & sSonKullaniciAdi & "', '" & dteSonUpdateTarihi & "')")
        cmd.CommandText = sorgu_query("SET DATEFORMAT DMY SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED INSERT INTO tbNakitKasa ( sSube, dteIslemTarihi, lTahsilTutar, lTediyeTutar, sAciklama, nCariHareketID, nFirmaID, nHesapID, sHangiUygulama, sHareketTipi, sKullaniciAdi, dteKayitTarihi, bMuhasebeyeIslendimi, sMasrafYontemi, sDovizCinsi1, lDovizMiktari1, lDovizKuru1, sDovizCinsi2, lDovizMiktari2, lDovizKuru2, sSonKullaniciAdi, dteSonUpdateTarihi) VALUES     ( '" & sSube & "', '" & dteIslemTarihi & "', " & lTahsilTutar & ", " & lTediyeTutar & ", N'" & sAciklama & "', " & nCariHareketID & ", " & nFirmaID & ", " & nHesapID & ", '" & sHangiUygulama & "', '" & sHareketTipi & "', '" & sKullaniciAdi & "', '" & dteKayitTarihi & "', " & bMuhasebeyeIslendimi & ", '" & sMasrafYontemi & "', '" & sDovizCinsi1 & "', " & lDovizMiktari1 & ", " & lDovizKuru1 & ", '" & sDovizCinsi2 & "', " & lDovizMiktari2 & ", " & lDovizKuru2 & ", '" & sSonKullaniciAdi & "', '" & dteSonUpdateTarihi & "')")
        cmd.ExecuteNonQuery()
        cmd.CommandText = "SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT @@identity"
        nKasaIslemID = cmd.ExecuteScalar
        
        ' BILDIRIM - Yuksek Tutarli Nakit Islem Kontrolu
        Try
            Dim lIslemTutar As Decimal = Math.Max(lTahsilTutar, lTediyeTutar)
            Dim lLimit As Decimal = 10000 ' Varsayilan limit
            Try
                Dim dtLimit As DataTable = BildirimServisi.SQLCalistir("SELECT sDeger FROM tbSistemAyar WHERE sAnahtar = 'YUKSEK_TUTAR_LIMITI'")
                If dtLimit.Rows.Count > 0 Then Decimal.TryParse(dtLimit.Rows(0)("sDeger").ToString(), lLimit)
            Catch
            End Try
            
            If lIslemTutar >= lLimit Then
                Dim sIslemTipi As String = If(lTahsilTutar > lTediyeTutar, "Tahsilat", "Tediye")
                BildirimServisi.YuksekNakitIslemBildirimiGonder(lIslemTutar, sIslemTipi, sKullaniciAdi)
            End If
        Catch bildirimEx As Exception
            Debug.WriteLine("Nakit bildirim hatasi: " & bildirimEx.Message)
        End Try
        
        Return nKasaIslemID
        con.Close()
    End Function
    Private Sub tbNakitKasa_kaydet_duzelt(ByVal nKasaIslemID As Int64, ByVal sSube As String, ByVal dteIslemTarihi As DateTime, ByVal lTahsilTutar As Decimal, ByVal lTediyeTutar As Decimal, ByVal sAciklama As String, ByVal nCariHareketID As Int64, ByVal nFirmaID As Int64, ByVal nHesapID As Int64, ByVal sHangiUygulama As String, ByVal sHareketTipi As String, ByVal sKullaniciAdi As String, ByVal dteKayitTarihi As DateTime, ByVal bMuhasebeyeIslendimi As Byte, ByVal sMasrafYontemi As String, ByVal sDovizCinsi1 As String, ByVal lDovizMiktari1 As Decimal, ByVal lDovizKuru1 As Decimal, ByVal sDovizCinsi2 As String, ByVal lDovizMiktari2 As Decimal, ByVal lDovizKuru2 As Decimal, ByVal sSonKullaniciAdi As String, ByVal dteSonUpdateTarihi As DateTime)
        Dim con As New OleDb.OleDbConnection
        Dim cmd As New OleDb.OleDbCommand
        cmd.Connection = con
        con.ConnectionString = connection
        If con.State = ConnectionState.Closed = True Then
            con.Open()
        End If
        cmd.CommandText = sorgu_query("SET DATEFORMAT DMY SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED UPDATE    tbNakitKasa SET              lTahsilTutar = " & lTahsilTutar & ", lTediyeTutar = " & lTediyeTutar & ", sAciklama = N'" & sAciklama & "', sHareketTipi = '" & sHareketTipi & "', bMuhasebeyeIslendimi = " & bMuhasebeyeIslendimi & ", sMasrafYontemi = '" & sMasrafYontemi & "', sDovizCinsi1 = '" & sDovizCinsi1 & "', lDovizMiktari1 = " & lDovizMiktari1 & ", lDovizKuru1 = " & lDovizKuru1 & ", sDovizCinsi2 = '" & sDovizCinsi2 & "', lDovizMiktari2 = " & lDovizMiktari2 & ", lDovizKuru2 = " & lDovizKuru2 & ", sSonKullaniciAdi = '" & sSonKullaniciAdi & "', dteSonUpdateTarihi = '" & dteSonUpdateTarihi & "' Where nKasaIslemID  ='" & nKasaIslemID & "'")
        cmd.ExecuteNonQuery()
        con.Close()
    End Sub
    Private Sub tbNakitKasa_kaydet_sil(ByVal nKasaIslemID As String, ByVal nCariHareketID As String, ByVal sHangiUygulama As String)
        Dim con As New OleDb.OleDbConnection
        Dim cmd As New OleDb.OleDbCommand
        cmd.Connection = con
        con.ConnectionString = connection
        If con.State = ConnectionState.Closed = True Then
            con.Open()
        End If
        cmd.CommandText = sorgu_query("set implicit_transactions on")
        cmd.ExecuteNonQuery()
        Try
            cmd.CommandText = sorgu_query("SET DATEFORMAT DMY SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED ")
            cmd.ExecuteNonQuery()
            cmd.CommandText = sorgu_query("DELETE FROM tbNakitKasa Where nKasaIslemID = '" & nKasaIslemID & "'")
            cmd.ExecuteNonQuery()
            cmd.CommandText = sorgu_query("DELETE FROM tbFirmaHareketi Where nHareketID = '" & nCariHareketID & "'")
            cmd.ExecuteNonQuery()
            If Trim(sHangiUygulama) = "CC" Or Trim(sHangiUygulama) = "CG" Or Trim(sHangiUygulama) = "TCC" Or Trim(sHangiUygulama) = "TCG" Then
                cmd.CommandText = sorgu_query("DELETE FROM tbFirmaBordroDetay Where nHareketID = '" & nCariHareketID & "' AND nKasaIslemID = '" & nKasaIslemID & "' ")
                cmd.ExecuteNonQuery()
            End If
            cmd.CommandText = sorgu_query("IF @@TRANCOUNT > 0 COMMIT TRAN")
            cmd.ExecuteNonQuery()
        Catch ex As Exception
            cmd.CommandText = sorgu_query("IF @@TRANCOUNT > 0 COMMIT TRAN")
            cmd.ExecuteNonQuery()
            XtraMessageBox.Show(Sorgu_sDil("Ýþlem Hatasý Lütfen Tekrar Deneyiniz...!", sDil), Sorgu_sDil("Dikkat", sDil), MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End Try
        cmd.CommandText = sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED UPDATE tbCariSiraNo SET nSonID = (SELECT TOP 1 ISNULL(nHareketID + 1 , 1) AS nSonID FROM tbFirmaHareketi ORDER BY nHareketID DESC) WHERE (nSiraIndex = 1)")
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
    Private Sub tbFirmaHareketi_kaydet_duzelt(ByVal nHareketID As Int64, ByVal nFirmaID As Int64, ByVal dteIslemTarihi As DateTime, ByVal dteValorTarihi As DateTime, ByVal sCariIslem As String, ByVal sAciklama As String, ByVal lBorcTutar As Decimal, ByVal lAlacakTutar As Decimal, ByVal sEvrakNo As String, ByVal lVadeFarki As Decimal, ByVal sHangiUygulama As String, ByVal sHareketTipi As String, ByVal sKullaniciAdi As String, ByVal dteKayitTarihi As DateTime, ByVal sDovizCinsi1 As String, ByVal lDovizMiktari1 As Decimal, ByVal lDovizKuru1 As Decimal, ByVal sDovizCinsi2 As String, ByVal lDovizMiktari2 As Decimal, ByVal lDovizKuru2 As Decimal, ByVal sSonKullaniciAdi As String, ByVal dteSonUpdateTarihi As DateTime)
        Dim con As New OleDb.OleDbConnection
        Dim cmd As New OleDb.OleDbCommand
        cmd.Connection = con
        con.ConnectionString = connection
        If con.State = ConnectionState.Closed = True Then
            con.Open()
        End If
        If Trim(sDovizCinsi2) <> "" Then
            If lDovizKuru2 = 0 Then
                lDovizKuru2 = 1
            End If
            sDovizCinsi1 = sDovizCinsi2
            lDovizKuru1 = lDovizKuru2
            lDovizMiktari1 = lDovizMiktari2
        End If
        cmd.CommandText = sorgu_query("SET DATEFORMAT DMY  UPDATE    tbFirmaHareketi SET              nFirmaID = '" & nFirmaID & "', dteIslemTarihi = '" & dteIslemTarihi & "', dteValorTarihi = '" & dteValorTarihi & "', sCariIslem = '" & sCariIslem & "', sAciklama = N'" & sAciklama & "', lBorcTutar = " & lBorcTutar & ", lAlacakTutar = " & lAlacakTutar & ", sEvrakNo = '" & sEvrakNo & "', lVadeFarki = " & lVadeFarki & ", sHangiUygulama = '" & sHangiUygulama & "', sHareketTipi = '" & sHareketTipi & "', sDovizCinsi1 = '" & sDovizCinsi1 & "', lDovizMiktari1 = " & lDovizMiktari1 & ", lDovizKuru1 = " & lDovizKuru1 & ", sDovizCinsi2 = '" & sDovizCinsi2 & "', lDovizMiktari2 = " & lDovizMiktari2 & ", lDovizKuru2 = " & lDovizKuru2 & ", sSonKullaniciAdi = '" & sSonKullaniciAdi & "', dteSonUpdateTarihi = '" & dteSonUpdateTarihi & "'  WHERE     (nHareketID = " & nHareketID & ")")
        cmd.ExecuteNonQuery()
        cmd.CommandText = sorgu_query("SET DATEFORMAT DMY  UPDATE    tbFirmaBordroDetay SET              nFirmaID = '" & nFirmaID & "', dteIslemTarihi = '" & dteIslemTarihi & "', dteValorTarihi = '" & dteValorTarihi & "', sCariIslem = '" & sCariIslem & "', sAciklama = N'" & sAciklama & "', lBorcTutar = " & lBorcTutar & ", lAlacakTutar = " & lAlacakTutar & ", sEvrakNo = '" & sEvrakNo & "', lVadeFarki = " & lVadeFarki & ", sHangiUygulama = '" & sHangiUygulama & "', sHareketTipi = '" & sHareketTipi & "', sDovizCinsi1 = '" & sDovizCinsi1 & "', lDovizMiktari1 = " & lDovizMiktari1 & ", lDovizKuru1 = " & lDovizKuru1 & ", sDovizCinsi2 = '" & sDovizCinsi2 & "', lDovizMiktari2 = " & lDovizMiktari2 & ", lDovizKuru2 = " & lDovizKuru2 & ", sSonKullaniciAdi = '" & sSonKullaniciAdi & "', dteSonUpdateTarihi = '" & dteSonUpdateTarihi & "'  WHERE     (nHareketID = " & nHareketID & ")")
        cmd.ExecuteNonQuery()
        con.Close()
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
    Private Sub satir_ekle(Optional ByVal sAra As String = "", Optional ByVal sKriter As String = "Baþlar")
        If KayitSiniri_kontrol("tbNakitKasa", "", nKayitSinir) = True Then
            Dim frm As New frm_firma_liste
            frm.islemstatus = True
            frm.connection = connection
            frm.firmano = firmano
            frm.donemno = donemno
            frm.islemstatus = True
            frm.kullanici = kullanici
            frm.sModul = "KasaBanka"
            If sAra <> "" Then
                frm.txt_ara.Text = sAra
                frm.sec_konum.Text = "Geliþmiþ"
                frm.sec_kriter.Text = sKriter
            End If
            If frm.ShowDialog(Me) = Windows.Forms.DialogResult.OK Then
                Dim s As String
                Dim arr As Integer()
                Dim i As Integer
                Dim dr As DataRow
                Dim dr1 As DataRow
                arr = frm.GridView1.GetSelectedRows()
                If arr Is Nothing Then
                Else
                    Array.Sort(arr)
                    For Each i In arr
                        s = i.ToString
                        dr = ds_tbNakitKasa.Tables(0).NewRow
                        dr1 = frm.GridView1.GetDataRow(s)
                        Dim nKasaIslemID As Int64 = sorgu_nKasaIslemID()
                        dr("nKasaISlemID") = nKasaIslemID
                        dr("sSube") = sec_sSubeMagaza.EditValue
                        dr("dteIslemTarihi") = txt_dteIslemTarihi2.EditValue
                        dr("lTahsilTutar") = 0
                        dr("lTediyeTutar") = 0
                        dr("sAciklama") = dr1("sAciklama")
                        Dim nCariHareketID = sorgu_nCariHareketID()
                        dr("nCariHareketID") = sorgu_nCariHareketID()
                        dr("nFirmaID") = dr1("nFirmaID")
                        dr("nHesapID") = 0
                        dr("sHangiUygulama") = "KASA"
                        dr("sHareketTipi") = sec_sSubeMagaza.EditValue
                        dr("sKullaniciAdi") = kullaniciadi
                        dr("dteKayitTarihi") = Now
                        dr("bMuhasebeyeIslendimi") = 0
                        dr("sMasrafYontemi") = ""
                        dr("sDovizCinsi1") = ""
                        dr("lDovizMiktari1") = 0
                        dr("lDovizKuru1") = 0
                        If Trim(dr1("sDovizCinsi")) <> "" Then
                            dr("sDovizCinsi2") = Trim(dr1("sDovizCinsi").ToString)
                            dr("lDovizKuru2") = sorgu_lDovizKuru(Trim(dr1("sDovizCinsi").ToString))
                            dr("lDovizMiktari2") = Math.Abs(dr("lTahsilTutar") - dr("lTediyeTutar")) / dr("lDovizKuru2")
                        Else
                            dr("sDovizCinsi2") = ""
                            dr("lDovizMiktari2") = 0
                            dr("lDovizKuru2") = 0
                        End If
                        dr("sSonKullaniciAdi") = kullaniciadi
                        dr("dteSonUpdateTarihi") = Now
                        dr("sFirmaKodu") = dr1("sKodu")
                        dr("sFirmaAciklama") = dr1("sAciklama")
                        dr("sEvrakNo") = ""
                        dr("nCariHareketID") = tbFirmaHareketi_kaydet_yeni(dr("nCariHareketID"), dr("nFirmaID"), dr("dteIslemTarihi"), dr("dteIslemTarihi"), "N", dr("sAciklama"), dr("lTahsilTutar"), dr("lTediyeTutar"), dr("sEvrakNo"), 0, dr("sHangiUygulama"), dr("sHareketTipi"), dr("sKullaniciAdi"), dr("dteKayitTarihi"), "", 0, 0, "", 0, 0, dr("sKullaniciAdi"), dr("dteSonUpdateTarihi"))
                        nCariHareketID_degistir(dr("nCariHareketID"))
                        dr("nKasaIslemID") = tbNakitKasa_kaydet_yeni(dr("nKasaIslemID"), dr("sSube"), dr("dteIslemTarihi"), dr("lTahsilTutar"), dr("lTediyeTutar"), dr("sAciklama"), dr("nCariHareketID"), dr("nFirmaID"), dr("nHesapID"), dr("sHangiUygulama"), dr("sHareketTipi"), dr("sKullaniciAdi"), dr("dteKayitTarihi"), dr("bMuhasebeyeIslendimi"), dr("sMasrafYontemi"), dr("sDovizCinsi1"), dr("lDovizMiktari1"), dr("lDovizKuru1"), dr("sDovizCinsi2"), dr("lDovizMiktari2"), dr("lDovizKuru2"), dr("sSonKullaniciAdi"), dr("dteSonUpdateTarihi"))
                        nKasaIslemID_degistir(dr("nKasaIslemID"))
                        ds_tbNakitKasa.Tables(0).Rows.Add(dr)
                    Next
                End If
            End If
            frm.Close()
            frm = Nothing
            If GridView1.RowCount > 0 Then
                GridView1.FocusedRowHandle = GridView1.RowCount - 1
                GridView1.ClearSelection()
                GridView1.SelectRow(GridView1.RowCount - 1)
                PanelControl3.Focus()
                GridControl1.Focus()
            End If
        End If
        GridView1.FocusedColumn = colsAciklama
        If GridView1.RowCount = 1 Then
            colsHareketTipi.View.SetRowCellValue(0, "sHareketTipi", "")
        Else
            colsHareketTipi.View.SetRowCellValue(GridView1.RowCount - 1, "sHareketTipi", "")
        End If
    End Sub
    Private Sub satir_ekle_firma_tek()
        If KayitSiniri_kontrol("tbNakitKasa", "", nKayitSinir) = True Then
            Dim dr As DataRow
            Dim dr1 As DataRow
            dr = ds_tbNakitKasa.Tables(0).NewRow
            dr1 = ds_Firma.Tables(0).Rows(0)
            Dim nKasaIslemID As Int64 = sorgu_nKasaIslemID()
            dr("nKasaISlemID") = nKasaIslemID
            dr("sSube") = sec_sSubeMagaza.EditValue
            dr("dteIslemTarihi") = txt_dteIslemTarihi2.EditValue
            dr("lTahsilTutar") = 0
            dr("lTediyeTutar") = 0
            dr("sAciklama") = dr1("sAciklama")
            Dim nCariHareketID = sorgu_nCariHareketID()
            dr("nCariHareketID") = sorgu_nCariHareketID()
            dr("nFirmaID") = dr1("nFirmaID")
            dr("nHesapID") = 0
            dr("sHangiUygulama") = "KASA"
            dr("sHareketTipi") = sec_sSubeMagaza.EditValue
            dr("sKullaniciAdi") = kullaniciadi
            dr("dteKayitTarihi") = Now
            dr("bMuhasebeyeIslendimi") = 0
            dr("sMasrafYontemi") = ""
            dr("sDovizCinsi1") = ""
            dr("lDovizMiktari1") = 0
            dr("lDovizKuru1") = 0
            If Trim(dr1("sDovizCinsi")) <> "" Then
                dr("sDovizCinsi2") = Trim(dr1("sDovizCinsi").ToString)
                dr("lDovizKuru2") = sorgu_lDovizKuru(Trim(dr1("sDovizCinsi").ToString))
                dr("lDovizMiktari2") = Math.Abs(dr("lTahsilTutar") - dr("lTediyeTutar")) / dr("lDovizKuru2")
            Else
                dr("sDovizCinsi2") = ""
                dr("lDovizMiktari2") = 0
                dr("lDovizKuru2") = 0
            End If
            dr("sSonKullaniciAdi") = kullaniciadi
            dr("dteSonUpdateTarihi") = Now
            dr("sFirmaKodu") = dr1("sKodu")
            dr("sFirmaAciklama") = dr1("sAciklama")
            dr("sEvrakNo") = ""
            dr("nCariHareketID") = tbFirmaHareketi_kaydet_yeni(dr("nCariHareketID"), dr("nFirmaID"), dr("dteIslemTarihi"), dr("dteIslemTarihi"), "N", dr("sAciklama"), dr("lTahsilTutar"), dr("lTediyeTutar"), dr("sEvrakNo"), 0, dr("sHangiUygulama"), dr("sHareketTipi"), dr("sKullaniciAdi"), dr("dteKayitTarihi"), "", 0, 0, "", 0, 0, dr("sKullaniciAdi"), dr("dteSonUpdateTarihi"))
            nCariHareketID_degistir(dr("nCariHareketID"))
            dr("nKasaIslemID") = tbNakitKasa_kaydet_yeni(dr("nKasaIslemID"), dr("sSube"), dr("dteIslemTarihi"), dr("lTahsilTutar"), dr("lTediyeTutar"), dr("sAciklama"), dr("nCariHareketID"), dr("nFirmaID"), dr("nHesapID"), dr("sHangiUygulama"), dr("sHareketTipi"), dr("sKullaniciAdi"), dr("dteKayitTarihi"), dr("bMuhasebeyeIslendimi"), dr("sMasrafYontemi"), dr("sDovizCinsi1"), dr("lDovizMiktari1"), dr("lDovizKuru1"), dr("sDovizCinsi2"), dr("lDovizMiktari2"), dr("lDovizKuru2"), dr("sSonKullaniciAdi"), dr("dteSonUpdateTarihi"))
            nKasaIslemID_degistir(dr("nKasaIslemID"))
            ds_tbNakitKasa.Tables(0).Rows.Add(dr)
            If GridView1.RowCount > 0 Then
                GridView1.FocusedRowHandle = GridView1.RowCount - 1
                GridView1.ClearSelection()
                GridView1.SelectRow(GridView1.RowCount - 1)
                PanelControl3.Focus()
                GridControl1.Focus()
                GridView1.FocusedColumn = colsAciklama
            End If
            GridView1.FocusedColumn = collTahsilTutar
            txt_ara.Text = ""
            txt_ara.Focus()
            txt_ara.SelectAll()
        End If
    End Sub
    Private Sub satir_sil()
        If GridView1.RowCount > 0 Then
            If XtraMessageBox.Show(Sorgu_sDil("Satýrý Silmek Ýstediðinize Emin misiniz...?", sDil), Sorgu_sDil("Dikkat", sDil), MessageBoxButtons.YesNo, MessageBoxIcon.Question) = MsgBoxResult.Yes Then
                Dim dr As DataRow
                dr = GridView1.GetDataRow(GridView1.FocusedRowHandle)
                tbNakitKasa_kaydet_sil(dr("nKasaIslemID"), dr("nCariHareketID"), dr("sHangiUygulama"))
                ds_tbNakitKasa.Tables(0).Rows.Remove(dr)
                GridControl1.Focus()
                GridControl1.Select()
                Dataload_tbYekun(txt_dteIslemTarihi2.EditValue, sec_sSubeMagaza.EditValue)
                Dataload_tbDYekun(txt_dteIslemTarihi2.EditValue, sec_sSubeMagaza.EditValue)
                If GridView1.RowCount > 0 Then
                    GridView1.SelectRow(GridView1.FocusedRowHandle)
                End If
            End If
        End If
    End Sub
    Private Sub tutar_hesapla()
        If GridView1.RowCount > 0 Then
            Dim dr As DataRow
            dr = GridView1.GetDataRow(GridView1.FocusedRowHandle)
            If Trim(dr("sDovizCinsi1")) = "" Then
                dr("lDovizKuru1") = 0
                dr("lDovizMiktari1") = 0
            End If
            If Trim(dr("sDovizCinsi2")) = "" Then
                dr("lDovizKuru2") = 0
                dr("lDovizMiktari2") = 0
            End If
            If dr("lTahsilTutar") > 0 Then
                dr("lTediyeTutar") = 0
            ElseIf dr("lTediyeTutar") > 0 Then
                dr("lTahsilTutar") = 0
            End If
            If GridView1.FocusedColumn.Name = collDovizMiktari1.Name.ToString Then
                If Trim(dr("sDovizCinsi1")) <> "" Then
                    If dr("lDovizKuru1") = 0 Then
                        dr("lDovizKuru1") = 1
                    End If
                    If dr("lTahsilTutar") = 0 Then
                        dr("lTediyeTutar") = dr("lDovizMiktari1") * dr("lDovizKuru1")
                    ElseIf dr("lTediyeTutar") = 0 Then
                        dr("lTahsilTutar") = dr("lDovizMiktari1") * dr("lDovizKuru1")
                    End If
                End If
            End If
            If GridView1.FocusedColumn.Name = collDovizMiktari2.Name.ToString Then
                If Trim(dr("sDovizCinsi2")) <> "" Then
                    If dr("lDovizKuru2") = 0 Then
                        dr("lDovizKuru2") = 1
                    End If
                    If dr("lTahsilTutar") = 0 Then
                        dr("lTediyeTutar") = dr("lDovizMiktari2") * dr("lDovizKuru2")
                    ElseIf dr("lTediyeTutar") = 0 Then
                        dr("lTahsilTutar") = dr("lDovizMiktari2") * dr("lDovizKuru2")
                    End If
                End If
            End If
            If Trim(dr("sDovizCinsi1")) <> "" Then
                If dr("lDovizKuru1") = 0 Then
                    dr("lDovizKuru1") = 1
                End If
                dr("lDovizMiktari1") = Math.Abs(dr("lTahsilTutar") - dr("lTediyeTutar")) / dr("lDovizKuru1")
            End If
            If Trim(dr("sDovizCinsi2")) <> "" Then
                If dr("lDovizKuru2") = 0 Then
                    dr("lDovizKuru2") = 1
                End If
                dr("lDovizMiktari2") = Math.Abs(dr("lTahsilTutar") - dr("lTediyeTutar")) / dr("lDovizKuru2")
            End If
            tbNakitKasa_kaydet_duzelt(dr("nKasaIslemID"), dr("sSube").ToString, dr("dteIslemTarihi"), dr("lTahsilTutar"), dr("lTediyeTutar"), dr("sAciklama").ToString, dr("nCariHareketID"), dr("nFirmaID"), dr("nHesapID"), dr("sHangiUygulama").ToString, dr("sHareketTipi").ToString, dr("sKullaniciAdi").ToString, dr("dteKayitTarihi"), dr("bMuhasebeyeIslendimi"), dr("sMasrafYontemi").ToString, dr("sDovizCinsi1").ToString, dr("lDovizMiktari1"), dr("lDovizKuru1"), dr("sDovizCinsi2").ToString, dr("lDovizMiktari2"), dr("lDovizKuru2"), kullaniciadi, Now)
            tbFirmaHareketi_kaydet_duzelt(dr("nCariHareketID"), dr("nFirmaID"), dr("dteIslemTarihi"), dr("dteIslemTarihi"), "N", dr("sAciklama").ToString, dr("lTediyeTutar"), dr("lTahsilTutar"), dr("sEvrakNo"), 0, dr("sHangiUygulama").ToString, dr("sHareketTipi").ToString, dr("sKullaniciAdi").ToString, dr("dteKayitTarihi"), dr("sDovizCinsi1"), dr("lDovizMiktari1"), dr("lDovizKuru1"), dr("sDovizCinsi2"), dr("lDovizMiktari2"), dr("lDovizKuru2"), kullaniciadi, Now)
            Dataload_tbFirma(dr("sFirmaKodu"))
            'Dataload_tbYekun(txt_dteIslemTarihi.EditValue, sec_sSubeMagaza.EditValue)
            'Dataload_tbDYekun(txt_dteIslemTarihi.EditValue, sec_sSubeMagaza.EditValue)
            dr = Nothing
        End If
    End Sub
    Private Sub analiz_cari_hareket(Optional ByVal Modul As String = "Cari")
        Dim bDevam As Boolean = True
        If Modul = "Cari" Then
            If GridView1.RowCount = 0 Then
                bDevam = False
            End If
        ElseIf Modul = "Banka" Then
            If GridView6.RowCount = 0 Then
                bDevam = False
            End If
        End If
        If bDevam = True Then
            Dim dr As DataRow
            Dim frm As New frm_cari_hareketler_ozet
            frm.firmano = firmano
            frm.donemno = donemno
            frm.connection = connection
            If Modul = "Cari" Then
                dr = GridView1.GetDataRow(GridView1.FocusedRowHandle)
                frm.musterino = dr("sFirmaKodu")
            ElseIf Modul = "Banka" Then
                dr = GridView6.GetDataRow(GridView6.FocusedRowHandle)
                frm.musterino = dr("sKodu")
            End If
            frm.kullanici = kullanici
            If yetki_kontrol(kullanici, frm.Name) = True Then
                If yetki_kontrol(kullanici, "frm_firma_liste_hesapTuru_" & Trim(CariHesapTuruSorgula(frm.musterino))) = True Then
                    frm.ShowDialog()
                End If
            End If
            frm.Close()
            frm.Dispose()
            frm = Nothing
        End If
    End Sub
    Private Sub analiz_cari_bakiye()
        If GridView1.RowCount > 0 Then
            Dim dr As DataRow = GridView1.GetDataRow(GridView1.FocusedRowHandle)
            Dim frm As New frm_Firma_bakiye
            frm.firmano = firmano
            frm.donemno = donemno
            frm.connection = connection
            frm.sKodu = dr("sFirmaKodu")
            frm.txt_musteriNo.EditValue = dr("sFirmaKodu")
            frm.kullanici = kullanici
            If yetki_kontrol(kullanici, frm.Name) = True Then
                If yetki_kontrol(kullanici, "frm_firma_liste_hesapTuru_" & Trim(CariHesapTuruSorgula(frm.sKodu))) = True Then
                    frm.ShowDialog()
                End If
            End If
            frm.Close()
            frm.Dispose()
            frm = Nothing
        End If
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
            If yetki_kontrol(kullanici, frm.Name) = True Then
                frm.ShowDialog()
            End If
            frm.Close()
            frm.Dispose()
            frm = Nothing
        End If
    End Sub
    Private Sub rpt_Cari_hareketler(Optional ByVal sModul As String = "Cari")
        Dim frm As New frm_firma_hareketler
        frm.firmano = firmano
        frm.donemno = donemno
        frm.connection = connection
        frm.kullanici = kullanici
        frm.sModul = sModul
        frm.DateEdit1.EditValue = txt_dteIslemTarihi1.EditValue
        frm.DateEdit2.EditValue = txt_dteIslemTarihi2.EditValue
        frm.bRapor = True
        If yetki_kontrol(kullanici, frm.Name) = True Then
            frm.Show()
        End If
    End Sub
    Private Sub analiz_toplam(ByVal sIslem As String, ByVal tarih1 As DateTime, ByVal sKriter As String)
        Dim dr As DataRow = GridView1.GetDataRow(GridView1.FocusedRowHandle)
        Dim frm As New frm_tbToplam
        frm.firmano = firmano
        frm.donemno = donemno
        frm.connection = connection
        frm.sIslem = sIslem
        frm.nGirisCikis = 3
        frm.tarih1 = "01/01/1900"
        frm.tarih2 = tarih1
        frm.sKriter = sKriter
        frm.kullanici = kullanici
        frm.ShowDialog()
        frm.Close()
        frm.Dispose()
        frm = Nothing
    End Sub
    Private Sub raporla(ByVal rapor As Integer, ByVal nislem As Integer, Optional ByVal bTumu As Boolean = False)
        Dim OpenFileDialog1 As New Windows.Forms.OpenFileDialog
        OpenFileDialog1.Title = "Rapor Seç..."
        OpenFileDialog1.Filter = "Rapor Dosyalarý (Form*.fr*) |Form*.fr*"
        OpenFileDialog1.FileName = "c:\Formlar\Raporlar\NakitKasa\Form" & sRaporUzanti & ""
        OpenFileDialog1.InitialDirectory = "c:\Formlar\Raporlar\NakitKasa"
        If OpenFileDialog1.ShowDialog = Windows.Forms.DialogResult.OK Then
            Dim sFile = OpenFileDialog1.FileName.ToString
            Dim dr As DataRow
            dr = GridView1.GetDataRow(GridView1.FocusedRowHandle)
            If Microsoft.VisualBasic.Right(sFile, 3) = "frx" Then
                Dim report As New FastReport.Report
                report.Load(sFile)
                Dim ds_table1 As DataSet
                Dim kriter As String = ""
                kriter = " WHERE nKasaIslemID = " & dr("nKasaIslemID") & ""
                ds_table1 = sorgu(sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT tbNakitKasa.nKasaIslemID, tbNakitKasa.sSube, tbNakitKasa.dteIslemTarihi, tbNakitKasa.lTahsilTutar, tbNakitKasa.lTediyeTutar, tbNakitKasa.sAciklama, tbNakitKasa.nCariHareketID, tbNakitKasa.sHangiUygulama, tbNakitKasa.sHareketTipi, tbNakitKasa.bMuhasebeyeIslendimi, tbNakitKasa.nFirmaID, tbNakitKasa.nHesapID, tbFirma.sKodu AS sFirmaKodu, tbFirma.sAciklama AS sFirmaAciklama, tbHesapPlani.sKodu AS sHesapKodu, tbHesapPlani.sAciklama AS sHesapAciklama, tbNakitKasa.sMasrafYontemi, tbNakitKasa.sDovizCinsi1, tbNakitKasa.lDovizMiktari1, tbNakitKasa.lDovizKuru1, tbNakitKasa.sDovizCinsi2, tbNakitKasa.lDovizMiktari2, tbNakitKasa.lDovizKuru2,tbNakitKasa.dteKayitTarihi,tbNakitKasa.sKullaniciAdi,(SELECT ISNULL(SUM(lBorcTutar) , 0) AS lBorcTutar FROM tbFirmaHareketi WHERE nFirmaID = tbFirma.nFirmaID) AS lBorcTutar, (SELECT ISNULL(SUM(lAlacakTutar) , 0) AS lAlacakTutar FROM tbFirmaHareketi WHERE nFirmaID = tbFirma.nFirmaID) AS lAlacakTutar, (SELECT ISNULL(SUM(lBorcTutar - lAlacakTutar) , 0) AS lBakiye FROM tbFirmaHareketi WHERE nFirmaID = tbFirma.nFirmaID) AS lBakiye, (SELECT ISNULL(SUM(lTutar) , 0) AS Expr1 FROM tbCekSenet WHERE (nVerenID = tbFirma.nFirmaID) AND (sCekSenetTipi = 'AC' OR sCekSenetTipi = 'AS') AND (nSonCekSenetIslem <= 6) AND (nSonCekSenetIslem <> 2)) AS lRisk FROM tbNakitKasa INNER JOIN tbFirma ON tbNakitKasa.nFirmaID = tbFirma.nFirmaID INNER JOIN tbHesapPlani ON tbNakitKasa.nHesapID = tbHesapPlani.nHesapID " & kriter & " ORDER BY tbNakitKasa.sSube, tbNakitKasa.nKasaIslemID"), "NakitKasa")
                report.RegisterData(ds_table1)
                report.RegisterData(ds_tbParamGenel)
                If bTumu = True Then
                    report.RegisterData(ds_tbNakitKasa)
                    report.RegisterData(ds_tbNakitKasaToplam)
                    report.RegisterData(ds_tbNakitKasaDToplam)
                End If
                report.SetParameterValue("dteIslemTarihi1", txt_dteIslemTarihi1.EditValue)
                report.SetParameterValue("dteIslemTarihi", txt_dteIslemTarihi2.EditValue)
                report.SetParameterValue("sSubeMagaza", sec_sSubeMagaza.Text)
                If dr("lTahsilTutar") = 0 Then
                    report.SetParameterValue("sFisTipi", "Tediye Makbuzu")
                    report.SetParameterValue("sYaziIle", ygeneltoplam(dr("lTediyeTutar")))
                    report.SetParameterValue("lTutar", dr("lTediyeTutar"))
                ElseIf dr("lTediyeTutar") = 0 Then
                    report.SetParameterValue("sFisTipi", "Tahsilat Makbuzu")
                    report.SetParameterValue("sYaziIle", ygeneltoplam(dr("lTahsilTutar")))
                    report.SetParameterValue("lTutar", dr("lTahsilTutar"))
                End If
                report.ScriptLanguage = Language.Vb
                If nislem = 0 Then
                    report.Show()
                ElseIf nislem = 2 Then
                    report.Design()
                ElseIf nislem = 1 Then
                    report.Print()
                End If
                ds_table1 = Nothing
                report.Dispose()
                report = Nothing
            ElseIf Microsoft.VisualBasic.Right(sFile, 3) = "fr3" Then
                report_create_stok(sFile, " WHERE nKasaIslemID = " & dr("nKasaIslemID") & "", nislem, dr("lTahsilTutar"), dr("lTediyeTutar"))
            End If
        End If
    End Sub
    Private Sub raporla_faaliyet(ByVal rapor As Integer, ByVal nislem As Integer, Optional ByVal bTumu As Boolean = False)
        Dim OpenFileDialog1 As New Windows.Forms.OpenFileDialog
        OpenFileDialog1.Title = "Rapor Seç..."
        OpenFileDialog1.Filter = "Rapor Dosyalarý (FormFaaliyet*.fr*) |FormFaaliyet*.fr*"
        OpenFileDialog1.FileName = "c:\Formlar\Raporlar\NakitKasa\FormFaaliyet" & sRaporUzanti & ""
        OpenFileDialog1.InitialDirectory = "c:\Formlar\Raporlar\NakitKasa"
        If OpenFileDialog1.ShowDialog = Windows.Forms.DialogResult.OK Then
            Dim sFile = OpenFileDialog1.FileName.ToString
            Dim dr As DataRow
            dr = GridView1.GetDataRow(GridView1.FocusedRowHandle)
            If Microsoft.VisualBasic.Right(sFile, 3) = "frx" Then
                ara()
                ara_Banka()
                ara_CekSenetIslem()
                ara_cekSenetListesi()
                Dim report As New FastReport.Report
                report.Load(sFile)
                report.RegisterData(ds_tbParamGenel)
                report.RegisterData(ds_tbNakitKasa)
                report.RegisterData(ds_tbNakitKasaToplam)
                report.RegisterData(ds_tbNakitKasaDToplam)
                report.RegisterData(ds_tbCekSenetBordro)
                report.RegisterData(ds_tbCekSenet)
                report.RegisterData(ds_tbBanka)
                report.SetParameterValue("dteIslemTarihi1", txt_dteIslemTarihi1.EditValue)
                report.SetParameterValue("dteIslemTarihi", txt_dteIslemTarihi2.EditValue)
                report.SetParameterValue("sSubeMagaza", sec_sSubeMagaza.Text)
                'If dr("lTahsilTutar") = 0 Then
                '    report.SetParameterValue("sFisTipi", "Tediye Makbuzu")
                '    report.SetParameterValue("sYaziIle", ygeneltoplam(dr("lTediyeTutar")))
                '    report.SetParameterValue("lTutar", dr("lTediyeTutar"))
                'ElseIf dr("lTediyeTutar") = 0 Then
                '    report.SetParameterValue("sFisTipi", "Tahsilat Makbuzu")
                '    report.SetParameterValue("sYaziIle", ygeneltoplam(dr("lTahsilTutar")))
                '    report.SetParameterValue("lTutar", dr("lTahsilTutar"))
                'End If
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
    Private Sub raporla1(ByVal rapor As Integer, ByVal islem As Integer)
        If GridView1.RowCount > 0 Then
            Dim file As String = ""
            Dim kriter As String
            Dim dr As DataRow
            dr = GridView1.GetDataRow(GridView1.FocusedRowHandle)
            kriter = " WHERE nKasaIslemID = " & dr("nKasaIslemID") & ""
            OpenFileDialog1.Title = "Rapor Seç..."
            OpenFileDialog1.Filter = "Rapor Dosyalarý (Form*.fr3) |Form*.fr3"
            OpenFileDialog1.FileName = "c:\Formlar\Raporlar\NakitKasa\Form.fr3"
            OpenFileDialog1.InitialDirectory = "c:\Formlar\Raporlar\NakitKasa"
            If OpenFileDialog1.ShowDialog = Windows.Forms.DialogResult.OK Then
                file = OpenFileDialog1.FileName.ToString
                report_create_stok(file, kriter, islem, dr("lTahsilTutar"), dr("lTediyeTutar"))
            End If
            file = Nothing
            kriter = Nothing
            dr = Nothing
        End If
    End Sub
    Private Sub report_create_stok(ByVal dosya As String, ByVal kriter As String, ByVal status As Integer, ByVal lTahsilTutar As Decimal, ByVal lTediyeTutar As Decimal)
        Dim stokno = 0
        Dim satir_line = "100"
        If IntPtr.Size = 4 Then
            '32 Bit
            Dim frx As New TfrxReportClass
            Dim qr_hareket As New TfrxADOQuery
            Dim qr_baslik As New TfrxADOQuery
            frx.Resources.LoadLanguageResourcesFromFile("C:\Program Files\FastReports\FastReport Studio\bin\turkish.frc")
            frx.LoadReportFromFile(dosya)
            frx.SetVariable("FIRMANO", "" & firmano & "")
            frx.SetVariable("DONEMNO", "" & donemno & "")
            frx.SetVariable("STOKNO", "" & stokno & "")
            frx.SetVariable("SATIRLINE", "'" & satir_line & "'")
            If lTahsilTutar = 0 Then
                frx.SetVariable("IZAHAT", "'Tediye Makbuzu'")
            ElseIf lTediyeTutar = 0 Then
                frx.SetVariable("IZAHAT", "'Tahsilat Makbuzu'")
            End If
            qr_hareket = frx.FindObject("qr_hareket")
            qr_hareket.Query = sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT tbNakitKasa.nKasaIslemID, tbNakitKasa.sSube, tbNakitKasa.dteIslemTarihi, tbNakitKasa.lTahsilTutar, tbNakitKasa.lTediyeTutar, tbNakitKasa.sAciklama, tbNakitKasa.nCariHareketID, tbNakitKasa.sHangiUygulama, tbNakitKasa.sHareketTipi, tbNakitKasa.bMuhasebeyeIslendimi, tbNakitKasa.nFirmaID, tbNakitKasa.nHesapID, tbFirma.sKodu AS sFirmaKodu, tbFirma.sAciklama AS sFirmaAciklama, tbHesapPlani.sKodu AS sHesapKodu, tbHesapPlani.sAciklama AS sHesapAciklama, tbNakitKasa.sMasrafYontemi, tbNakitKasa.sDovizCinsi1, tbNakitKasa.lDovizMiktari1, tbNakitKasa.lDovizKuru1, tbNakitKasa.sDovizCinsi2, tbNakitKasa.lDovizMiktari2, tbNakitKasa.lDovizKuru2,tbNakitKasa.dteKayitTarihi,tbNakitKasa.sKullaniciAdi,(SELECT ISNULL(SUM(lBorcTutar) , 0) AS lBorcTutar FROM tbFirmaHareketi WHERE nFirmaID = tbFirma.nFirmaID) AS lBorcTutar, (SELECT ISNULL(SUM(lAlacakTutar) , 0) AS lAlacakTutar FROM tbFirmaHareketi WHERE nFirmaID = tbFirma.nFirmaID) AS lAlacakTutar, (SELECT ISNULL(SUM(lBorcTutar - lAlacakTutar) , 0) AS lBakiye FROM tbFirmaHareketi WHERE nFirmaID = tbFirma.nFirmaID) AS lBakiye, (SELECT ISNULL(SUM(lTutar) , 0) AS Expr1 FROM tbCekSenet WHERE (nVerenID = tbFirma.nFirmaID) AND (sCekSenetTipi = 'AC' OR sCekSenetTipi = 'AS') AND (nSonCekSenetIslem <= 6) AND (nSonCekSenetIslem <> 2)) AS lRisk FROM tbNakitKasa INNER JOIN tbFirma ON tbNakitKasa.nFirmaID = tbFirma.nFirmaID INNER JOIN tbHesapPlani ON tbNakitKasa.nHesapID = tbHesapPlani.nHesapID " & kriter & " ORDER BY tbNakitKasa.sSube, tbNakitKasa.nKasaIslemID")
            Dim qr_connection As New TfrxADODatabase
            qr_connection.ConnectionString = connection.ToString
            qr_connection.LoginPrompt = False
            qr_connection.CommandTimeout = Nothing
            qr_connection.Connected = True
            qr_baslik.DataBase = qr_connection
            qr_hareket.DataBase = qr_connection
            If status = 0 Then
                'frx.PrepareReport(True)
                frx.PreviewOptions.ZoomMode = frxZoomMode.zm_PageWidth
                frx.OldStyleProgress = True
                frx.ShowReport()
            ElseIf status = 1 Then
                frx.PrepareReport(True)
                frx.PrintOptions.Collate = False
                frx.PrintOptions.Copies = 1
                frx.PrintReport()
            ElseIf status = 2 Then
                frx.PrepareReport(True)
                frx.DesignReport()
            ElseIf status = 3 Then
                frx.PrepareReport(True)
                frx.PrintOptions.Collate = False
                frx.PrintOptions.Copies = 1
                frx.PrintOptions.ShowDialog = False
                frx.PrintReport()
            End If
            qr_hareket = Nothing
            qr_connection = Nothing
            frx = Nothing
        ElseIf IntPtr.Size = 8 Then
            '64 Bit
            Dim args(50) As String
            Dim processYol As String
            args(0) = "" & dosya & ""
            args(1) = "" & connection.ToString() & ""
            args(2) = "" & sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT tbNakitKasa.nKasaIslemID, tbNakitKasa.sSube, tbNakitKasa.dteIslemTarihi, tbNakitKasa.lTahsilTutar, tbNakitKasa.lTediyeTutar, tbNakitKasa.sAciklama, tbNakitKasa.nCariHareketID, tbNakitKasa.sHangiUygulama, tbNakitKasa.sHareketTipi, tbNakitKasa.bMuhasebeyeIslendimi, tbNakitKasa.nFirmaID, tbNakitKasa.nHesapID, tbFirma.sKodu AS sFirmaKodu, tbFirma.sAciklama AS sFirmaAciklama, tbHesapPlani.sKodu AS sHesapKodu, tbHesapPlani.sAciklama AS sHesapAciklama, tbNakitKasa.sMasrafYontemi, tbNakitKasa.sDovizCinsi1, tbNakitKasa.lDovizMiktari1, tbNakitKasa.lDovizKuru1, tbNakitKasa.sDovizCinsi2, tbNakitKasa.lDovizMiktari2, tbNakitKasa.lDovizKuru2,tbNakitKasa.dteKayitTarihi,tbNakitKasa.sKullaniciAdi,(SELECT ISNULL(SUM(lBorcTutar) , 0) AS lBorcTutar FROM tbFirmaHareketi WHERE nFirmaID = tbFirma.nFirmaID) AS lBorcTutar, (SELECT ISNULL(SUM(lAlacakTutar) , 0) AS lAlacakTutar FROM tbFirmaHareketi WHERE nFirmaID = tbFirma.nFirmaID) AS lAlacakTutar, (SELECT ISNULL(SUM(lBorcTutar - lAlacakTutar) , 0) AS lBakiye FROM tbFirmaHareketi WHERE nFirmaID = tbFirma.nFirmaID) AS lBakiye, (SELECT ISNULL(SUM(lTutar) , 0) AS Expr1 FROM tbCekSenet WHERE (nVerenID = tbFirma.nFirmaID) AND (sCekSenetTipi = 'AC' OR sCekSenetTipi = 'AS') AND (nSonCekSenetIslem <= 6) AND (nSonCekSenetIslem <> 2)) AS lRisk FROM tbNakitKasa INNER JOIN tbFirma ON tbNakitKasa.nFirmaID = tbFirma.nFirmaID INNER JOIN tbHesapPlani ON tbNakitKasa.nHesapID = tbHesapPlani.nHesapID " & kriter & " ORDER BY tbNakitKasa.sSube, tbNakitKasa.nKasaIslemID") & ""
            args(3) = "qr_hareket"
            args(4) = "" & status.ToString() & ""
            args(5) = "5"
            args(6) = "FIRMANO"
            args(7) = "" & firmano.ToString() & ""
            args(8) = "DONEMNO"
            args(9) = "" & donemno.ToString() & ""
            args(10) = "STOKNO"
            args(11) = "" & stokno.ToString() & ""
            args(12) = "SATIRLINE"
            args(13) = "'" & satir_line.ToString() & "'"
            If lTahsilTutar = 0 Then
                args(14) = "IZAHAT"
                args(15) = "'Tediye Makbuzu'"
            ElseIf lTediyeTutar = 0 Then
                args(14) = "IZAHAT"
                args(15) = "'Tahsilat Makbuzu'"
            End If
            processYol = args(0)
            For i As Integer = 1 To 15
                processYol += "|" & args(i)
            Next
            Dim objReader As StreamWriter
            Dim yeniYol As String
            Dim Generator As System.Random = New System.Random()
            Try
                yeniYol = Directory.GetCurrentDirectory() & "\" & Generator.Next().ToString() & "_veriler.txt"
                objReader = New StreamWriter(yeniYol)
                objReader.Write(processYol)
                objReader.Close()
            Catch Ex As Exception
                MessageBox.Show("Raporlama Ýþlemi Ýçin LOG Oluþturulumadý!")
            End Try
            If File.Exists(Directory.GetCurrentDirectory() & "\RaporServis.exe") = True Then
                Dim sInfo As New ProcessStartInfo(Directory.GetCurrentDirectory() & "\RaporServis.exe ", """" & yeniYol & """")
                Process.Start(sInfo)
            Else
                MessageBox.Show("Lütfen 'RaporServis.exe' eklentisini uygulama dizinine kopyalayýn.")
            End If
        End If
        stokno = Nothing
        satir_line = Nothing
    End Sub
    Private Sub btn_Goster_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Goster.Click
        ara()
    End Sub
    Private Sub ara()
        Cursor.Current = Cursors.WaitCursor
        Cursor.Show()
        bLoad = False
        Dataload_tbNakitKasa(sec_sSubeMagaza.EditValue, txt_dteIslemTarihi1.EditValue, txt_dteIslemTarihi2.EditValue)
        GridControl1.Focus()
        GridControl1.Select()
        bLoad = True
        satir_info_firma()
        Cursor.Current = Cursors.Default
        Cursor.Hide()
    End Sub
    Private Sub ara_Banka()
        ds_tbBanka = sorgu(sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT tbFirma.nFirmaID, tbFirma.sKodu, tbFirma.sAciklama, tbFirma.sOzelNot,tbFirma.sSaticiRumuzu,tbFirma.nOzelIskontosu,tbFirma.nOzelIskontosu2,tbFirma.nOzelIskontosu3,tbFirma.nOzelIskontosu4,tbFirma.sFiyatTipi, tbFirma.lKrediLimiti, tbFirma.sSemt,tbFirma.sIl,tbFirma.sUlke,tbFirma.sPostaKodu,tbFirma.nVadeGun,tbFirma.sAdres1,tbFirma.sAdres2,tbFirma.sAdres1 + ' ' + tbFirma.sAdres2 + ' ' + tbFirma.sSemt + ' ' + tbFirma.sIl + ' ' + tbFirma.sUlke + ' ' + tbFirma.sPostaKodu AS Adres, tbFirma.sVergiDairesi, tbFirma.sVergiNo, tbFirmaAciklamasi.sAciklama1 + ' ' + tbFirmaAciklamasi.sAciklama2 + ' ' + tbFirmaAciklamasi.sAciklama3 + ' ' + tbFirmaAciklamasi.sAciklama4 + ' ' + tbFirmaAciklamasi.sAciklama5 AS ISTIHBARAT, tbFSinif1.sAciklama AS SINIF1, tbFSinif2.sAciklama AS SINIF2, tbFSinif3.sAciklama AS SINIF3, tbFSinif4.sAciklama AS SINIF4, tbFSinif5.sAciklama AS SINIF5, lBakiye = CASE WHEN tbFirma.sDovizCinsi = '   ' THEN (SELECT ISNULL(SUM(lBorcTutar - lAlacakTutar), 0) AS lBakiye FROM tbFirmaHareketi WHERE nFirmaID = tbFirma.nFirmaID) ELSE (SELECT ISNULL(SUM(ISNULL((lBorcTutar - lAlacakTutar),0.01)/lDovizKuru1) , 0) AS lBakiye FROM tbFirmaHareketi WHERE nFirmaID = tbFirma.nFirmaID AND sDovizCinsi1 = tbFirma.sDovizCinsi) END, tbFirma.sDovizCinsi, tbHesapPlani.nHesapID, tbHesapPlani.sKodu AS sHesapKodu, tbHesapPlani.sAciklama AS sHesapAciklama,(SELECT     TOP 1 sIletisimAdresi FROM          tbFirmaIletisimi WHERE      nFirmaId = tbFirma.nFirmaID AND sIletisimAraci = 'E-Mail') AS [E-Mail],(SELECT     TOP 1 sIletisimAdresi FROM          tbFirmaIletisimi WHERE      nFirmaId = tbFirma.nFirmaID AND sIletisimAraci = 'Fax') AS [Fax],(SELECT     TOP 1 sIletisimAdresi FROM          tbFirmaIletisimi WHERE      nFirmaId = tbFirma.nFirmaID AND sIletisimAraci = 'Gsm') AS [Gsm],(SELECT     TOP 1 sIletisimAdresi FROM          tbFirmaIletisimi WHERE      nFirmaId = tbFirma.nFirmaID AND sIletisimAraci = 'Telefon') AS [Telefon],(SELECT     TOP 1 sIletisimAdresi FROM          tbFirmaIletisimi WHERE      nFirmaId = tbFirma.nFirmaID AND sIletisimAraci = 'Web') AS [Web],(SELECT     TOP 1 sIletisimAdresi FROM          tbFirmaIletisimi WHERE      nFirmaId = tbFirma.nFirmaID AND sIletisimAraci = 'Yetkili') AS [Yetkili],tbFirma.bSatisYapilamaz,tbFirma.bTahsilatYapilamaz,bAnaHesap = CASE WHEN RIGHT(tbFirma.sAciklama, 1) = '+' THEN 1 ELSE 0 END FROM tbFirmaAciklamasi RIGHT OUTER JOIN tbFirma INNER JOIN tbHesapPlani ON tbFirma.nHesapID = tbHesapPlani.nHesapID ON tbFirmaAciklamasi.nFirmaID = tbFirma.nFirmaID LEFT OUTER JOIN tbFSinif1 INNER JOIN tbFirmaSinifi ON tbFSinif1.sSinifKodu = tbFirmaSinifi.sSinifKodu1 INNER JOIN tbFSinif2 ON tbFirmaSinifi.sSinifKodu2 = tbFSinif2.sSinifKodu INNER JOIN tbFSinif3 ON tbFirmaSinifi.sSinifKodu3 = tbFSinif3.sSinifKodu INNER JOIN tbFSinif4 ON tbFirmaSinifi.sSinifKodu4 = tbFSinif4.sSinifKodu INNER JOIN tbFSinif5 ON tbFirmaSinifi.sSinifKodu5 = tbFSinif5.sSinifKodu ON tbFirma.nFirmaID = tbFirmaSinifi.nFirmaID Where tbFirma.sKodu like '102%' and tbFirma.bAktif =1 ORDER BY tbFirma.sKodu"))
        GridControl6.DataSource = ds_tbBanka.Tables(0)
        GridControl6.DataMember = Nothing
    End Sub
    Private Sub ara_CekSenetIslem()
        ds_tbCekSenetBordro = Dataload_tbCekSenetBordro("", "Kodu", "Baþlar", "AC", "[Tümü]", 0, txt_dteIslemTarihi1.EditValue, txt_dteIslemTarihi2.EditValue, "01/01/1900", "31/12/2078", 0, 9999999, 0, 9999999, "", "", sec_sSubeMagaza.EditValue)
        GridControl4.DataSource = ds_tbCekSenetBordro.Tables(0)
        GridControl4.DataMember = Nothing
    End Sub
    Private Sub ara_cekSenetListesi()
        Cursor.Current = Cursors.WaitCursor
        Cursor.Show()
        'Dataload_tbNakitKasa(sec_sSubeMagaza.EditValue, txt_dteIslemTarihi1.EditValue, txt_dteIslemTarihi2.EditValue)
        If sec_sEvrakTipi.SelectedIndex = 0 Then
            ds_tbCekSenet = dataload_tbCekSenet("", "Kodu", "Baþlar", "AC", "'1'", 0, "01/01/1900", "31/12/2078", 0, 9999999, 0, 9999999, "", "", sec_sSubeMagaza.EditValue, "Vade:")
            GridControl5.DataSource = ds_tbCekSenet.Tables(0)
            GridControl5.DataMember = Nothing
        ElseIf sec_sEvrakTipi.SelectedIndex = 1 Then
            ds_tbCekSenet = dataload_tbCekSenet("", "Kodu", "Baþlar", "BC", "'20'", 0, "01/01/1900", "31/12/2078", 0, 9999999, 0, 9999999, "", "", sec_sSubeMagaza.EditValue, "Vade:")
            GridControl5.DataSource = ds_tbCekSenet.Tables(0)
            GridControl5.DataMember = Nothing
        ElseIf sec_sEvrakTipi.SelectedIndex = 2 Then
            ds_tbCekSenet = dataload_tbCekSenet("", "Kodu", "Baþlar", "AS", "'1'", 0, "01/01/1900", "31/12/2078", 0, 9999999, 0, 9999999, "", "", sec_sSubeMagaza.EditValue, "Vade:")
            GridControl5.DataSource = ds_tbCekSenet.Tables(0)
            GridControl5.DataMember = Nothing
        ElseIf sec_sEvrakTipi.SelectedIndex = 3 Then
            ds_tbCekSenet = dataload_tbCekSenet("", "Kodu", "Baþlar", "BS", "'20'", 0, "01/01/1900", "31/12/2078", 0, 9999999, 0, 9999999, "", "", sec_sSubeMagaza.EditValue, "Vade:")
            GridControl5.DataSource = ds_tbCekSenet.Tables(0)
            GridControl5.DataMember = Nothing
        End If
        GridControl1.Focus()
        GridControl1.Select()
        Cursor.Current = Cursors.Default
        Cursor.Hide()
    End Sub
    Private Sub GörünümüDüzenleToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        GridView1.ColumnsCustomization()
    End Sub
    Private Sub GörünümüKaydetToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        gorunum_kaydet()
    End Sub
    Private Sub GörünümüYazdýrToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        gorunum_yazdir()
    End Sub
    Private Sub gorunum_yazdir()
        Dim kriter As String = ""
        Dim kriter_CekSenetBordro = ""
        Dim kriter_CekSenetPorfoy = ""
        Dim kriter_banka As String = txt_dteIslemTarihi2.EditValue.ToLongDateString & " Tarihli Banka Bakiyeleri" & vbCrLf
        kriter += txt_dteIslemTarihi1.EditValue.ToLongDateString & " ve " & txt_dteIslemTarihi2.EditValue.ToLongDateString & " Tarihleri Arasýndaki Kasa Islemleri" & vbCrLf
        kriter_CekSenetBordro += txt_dteIslemTarihi1.EditValue.ToLongDateString & " ve " & txt_dteIslemTarihi2.EditValue.ToLongDateString & " Tarihleri Arasýndaki Cek Islemleri" & vbCrLf
        kriter_CekSenetPorfoy += txt_dteIslemTarihi2.EditValue.ToLongDateString & " Tarihindeki Cek Portfoy Tablosu" & vbCrLf
        kriter += "SubeMagaza: " & sec_sSubeMagaza.Text
        kriter_CekSenetBordro += "SubeMagaza: " & sec_sSubeMagaza.Text
        kriter_CekSenetPorfoy += "SubeMagaza: " & sec_sSubeMagaza.Text
        If XtraTabControl2.SelectedTabPageIndex = 0 Then
            CompositeLink1.PageHeaderFooter = New DevExpress.XtraPrinting.PageHeaderFooter(New DevExpress.XtraPrinting.PageHeaderArea(New String() {"[User Name]", kriter, "[Date Printed][Time Printed]"}, New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte)), DevExpress.XtraPrinting.BrickAlignment.Far), New DevExpress.XtraPrinting.PageFooterArea(New String() {"Powered by www.barkodyazilimevi.com", "Finans Yönetimi-Financial Managment", "[Page # of Pages #]"}, New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte)), DevExpress.XtraPrinting.BrickAlignment.Near))
            CompositeLink1.CreateDocument(ps)
            ps.PreviewRibbonFormEx.Show()
        ElseIf XtraTabControl2.SelectedTabPageIndex = 1 Then
            printlink4.PageHeaderFooter = New DevExpress.XtraPrinting.PageHeaderFooter(New DevExpress.XtraPrinting.PageHeaderArea(New String() {"[User Name]", kriter_CekSenetBordro, "[Date Printed][Time Printed]"}, New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte)), DevExpress.XtraPrinting.BrickAlignment.Far), New DevExpress.XtraPrinting.PageFooterArea(New String() {"Powered by www.barkodyazilimevi.com", "Finans Yönetimi-Financial Managment", "[Page # of Pages #]"}, New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte)), DevExpress.XtraPrinting.BrickAlignment.Near))
            printlink4.CreateDocument(ps)
            ps.PreviewRibbonFormEx.Show()
        ElseIf XtraTabControl2.SelectedTabPageIndex = 2 Then
            printlink5.PageHeaderFooter = New DevExpress.XtraPrinting.PageHeaderFooter(New DevExpress.XtraPrinting.PageHeaderArea(New String() {"[User Name]", kriter_CekSenetPorfoy, "[Date Printed][Time Printed]"}, New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte)), DevExpress.XtraPrinting.BrickAlignment.Far), New DevExpress.XtraPrinting.PageFooterArea(New String() {"Powered by www.barkodyazilimevi.com", "Finans Yönetimi-Financial Managment", "[Page # of Pages #]"}, New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte)), DevExpress.XtraPrinting.BrickAlignment.Near))
            printlink5.CreateDocument(ps)
            ps.PreviewRibbonFormEx.Show()
        ElseIf XtraTabControl2.SelectedTabPageIndex = 4 Then
            printlink6.PageHeaderFooter = New DevExpress.XtraPrinting.PageHeaderFooter(New DevExpress.XtraPrinting.PageHeaderArea(New String() {"[User Name]", kriter_banka, "[Date Printed][Time Printed]"}, New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte)), DevExpress.XtraPrinting.BrickAlignment.Far), New DevExpress.XtraPrinting.PageFooterArea(New String() {"Powered by www.barkodyazilimevi.com", "Finans Yönetimi-Financial Managment", "[Page # of Pages #]"}, New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte)), DevExpress.XtraPrinting.BrickAlignment.Near))
            printlink6.CreateDocument(ps)
            ps.PreviewRibbonFormEx.Show()
        End If
    End Sub
    Private Sub GridView1_CellValueChanged1(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs) Handles GridView1.CellValueChanged
        If GridView1.RowCount > 0 Then
            GridView1.PostEditor()
            Dim dr As DataRow
            dr = GridView1.GetDataRow(GridView1.FocusedRowHandle)
            dr.EndEdit()
            Try
                tutar_hesapla()
            Catch ex As Exception
            End Try
            Dataload_tbYekun(txt_dteIslemTarihi2.EditValue, sec_sSubeMagaza.EditValue)
            Dataload_tbDYekun(txt_dteIslemTarihi2.EditValue, sec_sSubeMagaza.EditValue)
        End If
    End Sub
    Private Sub GridView1_CustomDrawRowIndicator(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Grid.RowIndicatorCustomDrawEventArgs) Handles GridView1.CustomDrawRowIndicator
        If e.RowHandle >= 0 Then
            e.Info.DisplayText = e.RowHandle + 1
        Else
            e.Info.DisplayText = ""
        End If
    End Sub
    Private Sub GridView1_FocusedRowChanged(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs) Handles GridView1.FocusedRowChanged
        Try
            If GridView1.RowCount > 0 Then
                Dim dr As DataRow = GridView1.GetDataRow(GridView1.FocusedRowHandle)
                If Trim(dr("sHangiUygulama")) = "KASA" Then
                    GridView1.OptionsBehavior.Editable = True
                    MenuItem3.Enabled = True
                Else
                    GridView1.OptionsBehavior.Editable = False
                    If kullanici > 3 Then
                        MenuItem3.Enabled = False
                    Else
                        MenuItem3.Enabled = True
                    End If
                End If
            End If
            satir_info_firma()
        Catch ex As Exception
        End Try
    End Sub
    Private Sub satir_info_firma()
        Try
            If bLoad = True Then
                If GridView1.RowCount > 0 Then
                    Dim dr As DataRow = GridView1.GetDataRow(GridView1.FocusedRowHandle)
                    'BeginSearch(dr("sFirmaKodu"))
                    Dataload_tbFirma(dr("sFirmaKodu"))
                    dr = Nothing
                End If
            End If
        Catch ex As Exception
        End Try
    End Sub
    Private Sub GridView1_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles GridView1.KeyDown
        If e.KeyCode = Keys.Down Then
            If GridView1.FocusedRowHandle = GridView1.RowCount - 1 Then
                txt_ara.Focus()
                txt_ara.SelectAll()
            ElseIf GridView1.RowCount = 0 Then
                txt_ara.Focus()
                txt_ara.SelectAll()
            End If
        End If
    End Sub
    Private Sub GridView1_SelectionChanged(ByVal sender As Object, ByVal e As DevExpress.Data.SelectionChangedEventArgs) Handles GridView1.SelectionChanged
        If GridView1.SelectedRowsCount > 1 Then
            label2.Text = Sorgu_sDil("Kayýt Sayýsý :", sDil) & GridView1.RowCount & " / " & Sorgu_sDil("Satýr :", sDil) & GridView1.FocusedRowHandle + 1 & " / " & Sorgu_sDil("Seçili :", sDil) & GridView1.SelectedRowsCount
        ElseIf GridView1.SelectedRowsCount = 1 Then
            label2.Text = Sorgu_sDil("Kayýt Sayýsý :", sDil) & GridView1.RowCount & " / " & Sorgu_sDil("Satýr :", sDil) & GridView1.FocusedRowHandle + 1
        Else
            label2.Text = ""
        End If
    End Sub
    Private Sub EkleToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        satir_ekle()
    End Sub
    Private Sub SilToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        satir_sil()
    End Sub
    Private Sub FirmaHareketleriToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        analiz_cari_hareket()
    End Sub
    Private Sub FirmaKartýToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        analiz_Firma_karti()
    End Sub
    Private Sub ÖnizleToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        raporla(0, 0)
    End Sub
    Private Sub DizaynToolStripMenuItem_Click(ByVal sender As Object, ByVal e As System.EventArgs)
        raporla(0, 2)
    End Sub
    Private Sub YazdýrToolStripMenuItem_Click(ByVal sender As Object, ByVal e As System.EventArgs)
        raporla(0, 1)
    End Sub
    Private Sub GridControl1_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles GridControl1.KeyDown
        If e.KeyCode = Keys.Escape Then
            If XtraMessageBox.Show(Sorgu_sDil("Nakit Kasa Ýþlemleri Ekranýndan Çýkmak Ýstediðinize Emin misiniz...?", sDil), Sorgu_sDil("Dikkat", sDil), MessageBoxButtons.YesNo, MessageBoxIcon.Question) = MsgBoxResult.Yes Then
                Me.Close()
            End If
        End If
    End Sub
    Private Sub AraToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        txt_dteIslemTarihi1.Focus()
        txt_dteIslemTarihi1.SelectAll()
    End Sub
    Private Sub BarButtonItem1_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btn_AltSatirEkle.ItemClick
        satir_ekle()
    End Sub
    Private Sub BarButtonItem2_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btn_AltSatirSil.ItemClick
        satir_sil()
    End Sub
    Private Sub BarButtonItem3_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem3.ItemClick
        raporla(0, 0)
    End Sub
    Private Sub BarButtonItem4_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btn_AltGorunumYazdir.ItemClick
        gorunum_yazdir()
    End Sub
    Private Sub BarButtonItem5_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btn_AltFirmaKarti.ItemClick
        analiz_Firma_karti()
    End Sub
    Private Sub BarButtonItem6_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btn_AltFirmaHareketleri.ItemClick
        analiz_cari_hareket()
    End Sub
    Private Sub BarButtonItem7_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btn_AltFirmaBakiyesi.ItemClick
        analiz_cari_bakiye()
    End Sub
    Private Sub BakiyeAnaliziToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        analiz_cari_bakiye()
    End Sub
    Private Sub txt_ara_EditValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles txt_ara.EditValueChanged
        If Len(txt_ara.EditValue.ToString) <> 0 Then
            lbl_ara.Text = Len(txt_ara.EditValue.ToString)
        Else
            lbl_ara.Text = "*"
        End If
    End Sub
    Private Sub txt_ara_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txt_ara.KeyDown
        If e.KeyCode = Keys.Enter Then
            If txt_ara.Text = "" Then
                satir_ekle()
            Else
                firma_ara()
            End If
        ElseIf e.KeyCode = Keys.Up Then
            GridView1.Focus()
            GridView1.FocusedColumn = colsAciklama1
        ElseIf e.KeyCode = Keys.Escape Then
            If XtraMessageBox.Show(Sorgu_sDil("Nakit Kasa Ekranýný Kapatmak Ýstediðinize Emin misiniz...?", sDil), Sorgu_sDil("Dikkat", sDil), MessageBoxButtons.YesNo, MessageBoxIcon.Question) = MsgBoxResult.Yes Then
                Me.Close()
            End If
        End If
    End Sub
    Private Sub firma_ara()
        mevcut = 1
        If Trim(txt_ara.Text) <> "" Then
            Label4.Text = "Barkod Standardý Kontrol Ediliyor..."
            Label4.Refresh()
            If IsNumeric(Trim(txt_ara.Text)) = True Then
                If Len(Trim(txt_ara.Text).ToString) < 2 Then
                    txt_ara.Text = Trim(txt_ara.Text) + "  "
                End If
                If Trim((Trim(txt_ara.Text)).Substring(0, 2)) = sBarcodeStd Then
                    Dim deger = Trim(Trim(txt_ara.Text))
                    If IsNumeric(deger) = True Then
                        mevcut = CType((deger.substring(7, sBarcodeStd_KG) + "." + deger.substring(7 + sBarcodeStd_KG, sBarcodeStd_GR)), Decimal)
                        txt_ara.Text = deger.substring(2, 5)
                    End If
                Else
                    mevcut = 1
                End If
            Else
                If CStr(Trim(txt_ara.Text).ToString) <> "" Then
                    x = (Trim(txt_ara.Text)).IndexOf("*", 1, (Trim(txt_ara.Text)).Length - 1)
                    If x = -1 Then
                        mevcut = 1
                    Else
                        mevcut = (Trim(txt_ara.Text)).Substring(0, x)
                        txt_ara.Text = (Trim(txt_ara.Text)).Substring((x + 1), (Trim(txt_ara.Text)).Length - (x + 1))
                        If IsNumeric(Trim(txt_ara.Text)) Then
                        Else
                        End If
                    End If
                End If
            End If
            Label4.Text = "Barkod Standardý Kontrolü Tamamlandý..."
            Label4.Refresh()
            firma_kontrol()
        End If
    End Sub
    Private Sub firma_kontrol()
        If IsNumeric(Trim(txt_ara.Text)) = True Then
            okut = True
        Else
            okut = False
        End If
        Label4.Text = "Firma Kartý Kontrolü Yapýlýyor..."
        Label4.Refresh()
        Dim kontrol = sorgu_Firma_kontrol(txt_ara.EditValue, sec_kriter.Text)
        If kontrol = 0 Then
            Label4.Text = "Firma Kaydý Bulunamadý!!!.Tekrar Deneyiniz..."
            Label4.Refresh()
            txt_ara.Focus()
            txt_ara.SelectAll()
            'If XtraMessageBox.Show(Sorgu_sDil("Kayýt Bulunumadý..." & vbCrLf & "Yeni Kayýt Eklemek Ýster misiniz...?",sDil), MessageBoxButtons.YesNo + MessageBoxIcon.Warning) = MsgBoxResult.Yes Then
            '    stok_yeni(txt_ara.Text)
            'End If
        ElseIf kontrol = 1 Then
            Label4.Text = "Belge Firma Kaydý Kontrol Ediliyor... "
            Label4.Refresh()
            'MsgBox(Sorgu_sDil("Kayýt Tek...")
            Dataload_tbFirma(Trim(txt_ara.Text), sec_kriter.Text)
            Label4.Text = "Firma Bilgisi Yükleniyor... "
            Label4.Refresh()
            satir_ekle_firma_tek()
            Label4.Text = "Yeni Hesap Girin..."
        ElseIf kontrol > 1 Then
            satir_ekle(Trim(txt_ara.Text), sec_kriter.Text)
            Label4.Text = "Firma Hesabý Satýra Ýþlendi...Yeni Ürün Okutun..."
            Label4.Refresh()
            txt_ara.Text = ""
            txt_ara.Focus()
            txt_ara.SelectAll()
        End If
    End Sub
    Public Function sorgu_Firma_kontrol(ByVal ara As String, ByVal ara_kriter As String) As Int64
        Dim kriter
        kriter = "WHERE (tbFirma.sKodu  " & sorgu_kriter_string(ara, ara_kriter) & ") or (tbFirma.sAciklama " & sorgu_kriter_string(ara, ara_kriter) & ") "
        Dim conn As New OleDb.OleDbConnection
        Dim cmd As New OleDb.OleDbCommand
        Dim adapter As New OleDb.OleDbDataAdapter
        conn.ConnectionString = connection
        cmd.Connection = conn
        conn.Open()
        cmd.CommandText = sorgu_query("SET DATEFORMAT DMY SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT     ISNULL(COUNT(*), 0) AS KAYIT FROM         tbFirma " & kriter & "")
        Dim kayitsayisi = cmd.ExecuteScalar
        Return kayitsayisi
        conn.Dispose()
        cmd.Dispose()
        adapter.Dispose()
        cmd = Nothing
        adapter = Nothing
    End Function
    Private Sub dataload_tbFirma(ByVal ara As String, ByVal ara_kriter As String)
        Dim kriter
        kriter = "WHERE (tbFirma.sKodu  " & sorgu_kriter_string(ara, ara_kriter) & ") or (tbFirma.sAciklama " & sorgu_kriter_string(ara, ara_kriter) & ") "
        ds_Firma = sorgu(sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT tbFirma.nFirmaID, tbFirma.sKodu, tbFirma.sAciklama, tbFirma.sSaticiRumuzu,tbFirma.nOzelIskontosu,tbFirma.nOzelIskontosu2,tbFirma.nOzelIskontosu3,tbFirma.nOzelIskontosu4,tbFirma.sFiyatTipi, tbFirma.sDovizCinsi,tbFirma.lKrediLimiti, tbFirma.sSemt,tbFirma.sIl,tbFirma.sUlke,tbFirma.sPostaKodu,tbFirma.nVadeGun,tbFirma.sAdres1,tbFirma.sAdres2,tbFirma.sAdres1 + ' ' + tbFirma.sAdres2 + ' ' + tbFirma.sSemt + ' ' + tbFirma.sIl + ' ' + tbFirma.sUlke + ' ' + tbFirma.sPostaKodu AS Adres, tbFirma.sVergiDairesi, tbFirma.sVergiNo, tbFirmaAciklamasi.sAciklama1 + ' ' + tbFirmaAciklamasi.sAciklama2 + ' ' + tbFirmaAciklamasi.sAciklama3 + ' ' + tbFirmaAciklamasi.sAciklama4 + ' ' + tbFirmaAciklamasi.sAciklama5 AS ISTIHBARAT, tbFSinif1.sAciklama AS SINIF1, tbFSinif2.sAciklama AS SINIF2, tbFSinif3.sAciklama AS SINIF3, tbFSinif4.sAciklama AS SINIF4, tbFSinif5.sAciklama AS SINIF5, (SELECT ISNULL(SUM(lBorcTutar - lAlacakTutar) , 0) AS lBakiye FROM tbFirmaHareketi WHERE nFirmaID = tbFirma.nFirmaID) AS lBakiye, tbHesapPlani.nHesapID, tbHesapPlani.sKodu AS sHesapKodu, tbHesapPlani.sAciklama AS sHesapAciklama,(SELECT     TOP 1 sIletisimAdresi FROM          tbFirmaIletisimi WHERE      nFirmaId = tbFirma.nFirmaID AND sIletisimAraci = 'E-Mail') AS [E-Mail],(SELECT     TOP 1 sIletisimAdresi FROM          tbFirmaIletisimi WHERE      nFirmaId = tbFirma.nFirmaID AND sIletisimAraci = 'Fax') AS [Fax],(SELECT     TOP 1 sIletisimAdresi FROM          tbFirmaIletisimi WHERE      nFirmaId = tbFirma.nFirmaID AND sIletisimAraci = 'Gsm') AS [Gsm],(SELECT     TOP 1 sIletisimAdresi FROM          tbFirmaIletisimi WHERE      nFirmaId = tbFirma.nFirmaID AND sIletisimAraci = 'Telefon') AS [Telefon],(SELECT     TOP 1 sIletisimAdresi FROM          tbFirmaIletisimi WHERE      nFirmaId = tbFirma.nFirmaID AND sIletisimAraci = 'Web') AS [Web],(SELECT     TOP 1 sIletisimAdresi FROM          tbFirmaIletisimi WHERE      nFirmaId = tbFirma.nFirmaID AND sIletisimAraci = 'Yetkili') AS [Yetkili] FROM tbFirmaAciklamasi RIGHT OUTER JOIN tbFirma INNER JOIN tbHesapPlani ON tbFirma.nHesapID = tbHesapPlani.nHesapID ON tbFirmaAciklamasi.nFirmaID = tbFirma.nFirmaID LEFT OUTER JOIN tbFSinif1 INNER JOIN tbFirmaSinifi ON tbFSinif1.sSinifKodu = tbFirmaSinifi.sSinifKodu1 INNER JOIN tbFSinif2 ON tbFirmaSinifi.sSinifKodu2 = tbFSinif2.sSinifKodu INNER JOIN tbFSinif3 ON tbFirmaSinifi.sSinifKodu3 = tbFSinif3.sSinifKodu INNER JOIN tbFSinif4 ON tbFirmaSinifi.sSinifKodu4 = tbFSinif4.sSinifKodu INNER JOIN tbFSinif5 ON tbFirmaSinifi.sSinifKodu5 = tbFSinif5.sSinifKodu ON tbFirma.nFirmaID = tbFirmaSinifi.nFirmaID " & kriter & " ORDER BY tbFirma.sKodu"))
    End Sub
    Private Sub raporla_excel()
        If XtraMessageBox.Show(Sorgu_sDil("Sonuçlarý Excel Dosyasý Oluþturmak Ýstediðinize Emin misiniz...?", sDil), Sorgu_sDil("Dikkat", sDil), MessageBoxButtons.YesNo, MessageBoxIcon.Question) = MsgBoxResult.Yes Then
            Dim SaveFileDialog1 As New Windows.Forms.SaveFileDialog
            SaveFileDialog1.Filter = "Excel Dosyalarý(*.xls) |*.xls"
            SaveFileDialog1.InitialDirectory = "c:\"
            SaveFileDialog1.FileName = "NakitKasa.xls"
            If SaveFileDialog1.ShowDialog = Windows.Forms.DialogResult.OK Then
                GridView1.ExportToXls(SaveFileDialog1.FileName.ToString)
                If XtraMessageBox.Show(Sorgu_sDil("Kaydý Açmak Ýster misiniz...?", sDil), Sorgu_sDil("Dikkat", sDil), MessageBoxButtons.YesNo, MessageBoxIcon.Question) = MsgBoxResult.Yes Then
                    Process.Start(SaveFileDialog1.FileName.ToString)
                End If
            End If
            SaveFileDialog1 = Nothing
        End If
    End Sub
    Private Sub raporla_text()
        If XtraMessageBox.Show(Sorgu_sDil("Sonuçlarý Text Dosyasý Oluþturmak Ýstediðinize Emin misiniz...?", sDil), Sorgu_sDil("Dikkat", sDil), MessageBoxButtons.YesNo, MessageBoxIcon.Question) = MsgBoxResult.Yes Then
            Dim SaveFileDialog1 As New Windows.Forms.SaveFileDialog
            SaveFileDialog1.Filter = "Text Dosyalarý(*.txt) |*.txt"
            SaveFileDialog1.InitialDirectory = "c:\"
            SaveFileDialog1.FileName = "Rapor.txt"
            If SaveFileDialog1.ShowDialog = Windows.Forms.DialogResult.OK Then
                GridView1.ExportToText(SaveFileDialog1.FileName.ToString)
                If XtraMessageBox.Show(Sorgu_sDil("Kaydý Açmak Ýster misiniz...?", sDil), Sorgu_sDil("Dikkat", sDil), MessageBoxButtons.YesNo, MessageBoxIcon.Question) = MsgBoxResult.Yes Then
                    Process.Start(SaveFileDialog1.FileName.ToString)
                End If
            End If
            SaveFileDialog1 = Nothing
        End If
    End Sub
    Private Sub raporla_pdf()
        If XtraMessageBox.Show(Sorgu_sDil("Sonuçlarý Metin Dosyasý Oluþturmak Ýstediðinize Emin misiniz...?", sDil), Sorgu_sDil("Dikkat", sDil), MessageBoxButtons.YesNo, MessageBoxIcon.Question) = MsgBoxResult.Yes Then
            Dim SaveFileDialog1 As New Windows.Forms.SaveFileDialog
            SaveFileDialog1.Filter = "Metin Dosyalarý(*.pdf) |*.pdf"
            SaveFileDialog1.InitialDirectory = "c:\"
            SaveFileDialog1.FileName = "Rapor.pdf"
            If SaveFileDialog1.ShowDialog = Windows.Forms.DialogResult.OK Then
                GridView1.ExportToPdf(SaveFileDialog1.FileName.ToString)
                If XtraMessageBox.Show(Sorgu_sDil("Kaydý Açmak Ýster misiniz...?", sDil), Sorgu_sDil("Dikkat", sDil), MessageBoxButtons.YesNo, MessageBoxIcon.Question) = MsgBoxResult.Yes Then
                    Process.Start(SaveFileDialog1.FileName.ToString)
                End If
            End If
            SaveFileDialog1 = Nothing
        End If
    End Sub
    Private Sub RichTextBox1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RichTextBox1.TextChanged
    End Sub
    Private Sub BarButtonItem8_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btn_AltExcel.ItemClick
        raporla_excel()
    End Sub
    Private Sub btn_CekSenetListele_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_CekSenetListele.Click
        ara_cekSenetListesi()
    End Sub
    Private Sub SimpleButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        raporla_faaliyet(0, 0)
    End Sub
    Private Sub BarButtonItem9_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem9.ItemClick
        raporla_faaliyet(0, 0)
    End Sub
    Private Sub BarButtonItem10_ItemClick(ByVal sender As Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem10.ItemClick
        raporla_faaliyet(0, 2)
    End Sub
    Private Sub BarButtonItem11_ItemClick(ByVal sender As Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem11.ItemClick
        raporla_faaliyet(0, 1)
    End Sub
    Private Sub XtraTabControl2_SelectedPageChanged(ByVal sender As Object, ByVal e As DevExpress.XtraTab.TabPageChangedEventArgs) Handles XtraTabControl2.SelectedPageChanged
        If XtraTabControl2.SelectedTabPageIndex = 0 Then
            ara()
            GridControl1.Focus()
            GridControl1.Select()
            If sec_bTumu.Checked = False And bKasaIsle = True Then
                Panel_Ara.Enabled = True
                btn_AltFirmaBakiyesi.Enabled = True
                btn_AltFirmaHareketleri.Enabled = True
                btn_AltFirmaKarti.Enabled = True
                btn_AltSatirEkle.Enabled = True
                btn_AltSatirSil.Enabled = True
                MenuItem1.Enabled = True
                MenuItem3.Enabled = True
            ElseIf sec_bTumu.Checked = True Then
                Panel_Ara.Enabled = False
                btn_AltFirmaBakiyesi.Enabled = False
                btn_AltFirmaHareketleri.Enabled = False
                btn_AltFirmaKarti.Enabled = False
                btn_AltSatirEkle.Enabled = False
                btn_AltSatirSil.Enabled = False
                MenuItem1.Enabled = False
                MenuItem3.Enabled = False
            End If
        ElseIf XtraTabControl2.SelectedTabPageIndex = 1 Then
            Cursor.Current = Cursors.WaitCursor
            Cursor.Show()
            ara_CekSenetIslem()
            GridControl4.Focus()
            GridControl4.Select()
            Panel_Ara.Enabled = False
            btn_AltFirmaBakiyesi.Enabled = False
            btn_AltFirmaHareketleri.Enabled = False
            btn_AltFirmaKarti.Enabled = False
            btn_AltSatirEkle.Enabled = False
            btn_AltSatirSil.Enabled = False
            MenuItem1.Enabled = False
            MenuItem3.Enabled = False
            Cursor.Current = Cursors.Default
            Cursor.Hide()
        ElseIf XtraTabControl2.SelectedTabPageIndex = 2 Then
            Cursor.Current = Cursors.WaitCursor
            Cursor.Show()
            ara_cekSenetListesi()
            GridControl5.Focus()
            GridControl5.Select()
            Panel_Ara.Enabled = False
            btn_AltFirmaBakiyesi.Enabled = False
            btn_AltFirmaHareketleri.Enabled = False
            btn_AltFirmaKarti.Enabled = False
            btn_AltSatirEkle.Enabled = False
            btn_AltSatirSil.Enabled = False
            MenuItem1.Enabled = False
            MenuItem3.Enabled = False
            Cursor.Current = Cursors.Default
            Cursor.Hide()
        ElseIf XtraTabControl2.SelectedTabPageIndex = 4 Then
            Cursor.Current = Cursors.WaitCursor
            Cursor.Show()
            ara_Banka()
            GridControl6.Focus()
            GridControl6.Select()
            Panel_Ara.Enabled = False
            btn_AltFirmaBakiyesi.Enabled = False
            btn_AltFirmaHareketleri.Enabled = False
            btn_AltFirmaKarti.Enabled = False
            btn_AltSatirEkle.Enabled = False
            btn_AltSatirSil.Enabled = False
            MenuItem1.Enabled = False
            MenuItem3.Enabled = False
            Cursor.Current = Cursors.Default
            Cursor.Hide()
        End If
    End Sub
    Private Sub sec_bTumu_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles sec_bTumu.CheckedChanged
        If sec_bTumu.Checked = True Then
            sec_sSubeMagaza.EditValue = ""
            Panel_Ara.Enabled = False
            btn_AltFirmaBakiyesi.Enabled = False
            btn_AltFirmaHareketleri.Enabled = False
            btn_AltFirmaKarti.Enabled = False
            btn_AltSatirEkle.Enabled = False
            btn_AltSatirSil.Enabled = False
            MenuItem1.Enabled = False
            MenuItem3.Enabled = False
        ElseIf sec_bTumu.Checked = False Then
            Panel_Ara.Enabled = True
            btn_AltFirmaBakiyesi.Enabled = True
            btn_AltFirmaHareketleri.Enabled = True
            btn_AltFirmaKarti.Enabled = True
            btn_AltSatirEkle.Enabled = True
            btn_AltSatirSil.Enabled = True
            MenuItem1.Enabled = True
            MenuItem3.Enabled = True
        End If
    End Sub
    Private Sub GridView4_CustomDrawRowIndicator(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Grid.RowIndicatorCustomDrawEventArgs) Handles GridView4.CustomDrawRowIndicator
        If e.RowHandle >= 0 Then
            e.Info.DisplayText = e.RowHandle + 1
        Else
            e.Info.DisplayText = ""
        End If
    End Sub
    Private Sub GridView4_SelectionChanged(ByVal sender As Object, ByVal e As DevExpress.Data.SelectionChangedEventArgs) Handles GridView4.SelectionChanged
        If GridView4.SelectedRowsCount > 1 Then
            label2.Text = Sorgu_sDil("Kayýt Sayýsý :", sDil) & GridView4.RowCount & " / " & Sorgu_sDil("Satýr :", sDil) & GridView4.FocusedRowHandle + 1 & " / " & Sorgu_sDil("Seçili :", sDil) & GridView4.SelectedRowsCount
        ElseIf GridView4.SelectedRowsCount = 1 Then
            label2.Text = Sorgu_sDil("Kayýt Sayýsý :", sDil) & GridView4.RowCount & " / " & Sorgu_sDil("Satýr :", sDil) & GridView4.FocusedRowHandle + 1
        Else
            label2.Text = ""
        End If
    End Sub
    Private Sub GridView5_CustomDrawRowIndicator(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Grid.RowIndicatorCustomDrawEventArgs) Handles GridView5.CustomDrawRowIndicator
        If e.RowHandle >= 0 Then
            e.Info.DisplayText = e.RowHandle + 1
        Else
            e.Info.DisplayText = ""
        End If
    End Sub
    Private Sub GridView5_SelectionChanged(ByVal sender As Object, ByVal e As DevExpress.Data.SelectionChangedEventArgs) Handles GridView5.SelectionChanged
        If GridView5.SelectedRowsCount > 1 Then
            label2.Text = Sorgu_sDil("Kayýt Sayýsý :", sDil) & GridView5.RowCount & " / " & Sorgu_sDil("Satýr :", sDil) & GridView5.FocusedRowHandle + 1 & " / " & Sorgu_sDil("Seçili :", sDil) & GridView5.SelectedRowsCount
        ElseIf GridView5.SelectedRowsCount = 1 Then
            label2.Text = Sorgu_sDil("Kayýt Sayýsý :", sDil) & GridView5.RowCount & " / " & Sorgu_sDil("Satýr :", sDil) & GridView5.FocusedRowHandle + 1
        Else
            label2.Text = ""
        End If
    End Sub
    Private Sub SimpleButton2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SimpleButton2.Click
        rpt_Cari_hareketler("Banka")
    End Sub
    Private Sub GridView6_CustomDrawRowIndicator(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Grid.RowIndicatorCustomDrawEventArgs) Handles GridView6.CustomDrawRowIndicator
        If e.RowHandle >= 0 Then
            e.Info.DisplayText = e.RowHandle + 1
        Else
            e.Info.DisplayText = ""
        End If
    End Sub
    Private Sub MenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem1.Click
        satir_ekle()
    End Sub
    Private Sub MenuItem3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem3.Click
        satir_sil()
    End Sub
    Private Sub MenuItem15_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem15.Click
        txt_dteIslemTarihi1.Focus()
        txt_dteIslemTarihi1.SelectAll()
    End Sub
    Private Sub MenuItem4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem4.Click
        analiz_Firma_karti()
    End Sub
    Private Sub MenuItem21_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem21.Click
        analiz_cari_hareket()
    End Sub
    Private Sub MenuItem19_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem19.Click
        analiz_cari_bakiye()
    End Sub
    Private Sub MenuItem22_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem22.Click
        raporla(0, 0)
    End Sub
    Private Sub MenuItem23_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem23.Click
        raporla(0, 2)
    End Sub
    Private Sub MenuItem24_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem24.Click
        raporla(0, 1)
    End Sub
    Private Sub MenuItem14_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem14.Click
        GridView1.ColumnsCustomization()
    End Sub
    Private Sub MenuItem17_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem17.Click
        gorunum_kaydet()
    End Sub
    Private Sub MenuItem18_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem18.Click
        gorunum_yazdir()
    End Sub
    Private Sub MenuItem26_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem26.Click
        If MenuItem26.Checked = False Then
            GridView1.OptionsCustomization.AllowFilter = True
            GridView1.OptionsView.ShowFilterPanelMode = DevExpress.XtraGrid.Views.Base.ShowFilterPanelMode.Default
            GridView1.OptionsView.ShowAutoFilterRow = True
            MenuItem26.Checked = True
        ElseIf MenuItem26.Checked = True Then
            GridView1.OptionsCustomization.AllowFilter = False
            GridView1.OptionsView.ShowFilterPanelMode = DevExpress.XtraGrid.Views.Base.ShowFilterPanelMode.Never
            GridView1.OptionsView.ShowAutoFilterRow = False
            MenuItem26.Checked = False
        End If
    End Sub
    Private Sub MenuItem27_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem27.Click
        If MenuItem27.Checked = False Then
            GridView1.OptionsCustomization.AllowFilter = True
            GridView1.OptionsView.ShowFilterPanelMode = DevExpress.XtraGrid.Views.Base.ShowFilterPanelMode.Default
            MenuItem27.Checked = True
        ElseIf MenuItem27.Checked = True Then
            GridView1.OptionsCustomization.AllowFilter = False
            GridView1.OptionsView.ShowFilterPanelMode = DevExpress.XtraGrid.Views.Base.ShowFilterPanelMode.Never
            MenuItem27.Checked = False
        End If
    End Sub
    Private Sub MenuItem28_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem28.Click
        If MenuItem28.Checked = False Then
            GridView1.OptionsCustomization.AllowGroup = True
            GridView1.OptionsView.ShowGroupPanel = True
            MenuItem28.Checked = True
        ElseIf MenuItem28.Checked = True Then
            GridView1.OptionsCustomization.AllowGroup = False
            GridView1.OptionsView.ShowGroupPanel = False
            MenuItem28.Checked = False
        End If
    End Sub
    Private Sub MenuItem5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem5.Click
        GridView1.ExpandAllGroups()
    End Sub
    Private Sub MenuItem11_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem11.Click
        GridView1.CollapseAllGroups()
    End Sub
    Private Sub MenuItem30_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem30.Click
        If Me.WindowState = FormWindowState.Normal Then
            Me.WindowState = FormWindowState.Maximized
        ElseIf Me.WindowState = FormWindowState.Maximized Then
            Me.WindowState = FormWindowState.Normal
        End If
    End Sub
    Private Sub SimpleButton1_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SimpleButton1.Click
        analiz_cari_hareket("Banka")
    End Sub
    Private Sub GridView6_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles GridView6.KeyDown
        If e.KeyCode = Keys.F7 Then
            analiz_cari_hareket("Banka")
        End If
    End Sub
    Private Sub BarButtonItem1_ItemClick_1(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem1.ItemClick
        analiz_toplam("NakitKasaToplamlari", txt_dteIslemTarihi2.EditValue, "")
    End Sub
    Private Sub GridView2_CustomDrawRowIndicator(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Grid.RowIndicatorCustomDrawEventArgs) Handles GridView2.CustomDrawRowIndicator
        If e.RowHandle >= 0 Then
            e.Info.DisplayText = e.RowHandle + 1
        Else
            e.Info.DisplayText = ""
        End If
    End Sub
    Private Sub GridView3_CustomDrawRowIndicator(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Grid.RowIndicatorCustomDrawEventArgs) Handles GridView3.CustomDrawRowIndicator
        If e.RowHandle >= 0 Then
            e.Info.DisplayText = e.RowHandle + 1
        Else
            e.Info.DisplayText = ""
        End If
    End Sub
    Private Sub BarButtonItem2_ItemClick_1(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem2.ItemClick
        Dim frm As New frm_ParaTeslim
        frm.Show()
    End Sub
    Private Sub MenuItem6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem6.Click
        calculator()
    End Sub
End Class