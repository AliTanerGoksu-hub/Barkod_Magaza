Imports FastReport
Imports Microsoft.Win32
Imports DevExpress.XtraEditors
Imports System.IO
Public Class frm_tbCekSenetBordro
    Public firmano
    Public donemno
    Public connection
    Public kullanici
    Public nFirmaId As Int64 = 0
    Public sKodu As String = ""
    Public sFirmaAciklama As String = ""
    Dim nBorcluFirmaID As Int64 = 0
    Dim sBorcluKodu As String = ""
    Dim sBorcluAciklama As String = ""
    Dim ds_tbCekSenetTipi As DataSet
    Dim ds_tbCekSenetIslem As DataSet
    Dim ds_tbDovizCinsi As DataSet
    Dim ds_tbHareketTipi As DataSet
    Dim ds_sCarisIslem As DataSet
    Dim ds_cari As DataSet
    Dim ds_tbBankaKodu As DataSet
    Dim ds_tbBankaSubeKodu As DataSet
    Dim ds_tbIl As DataSet
    Dim ds_tbCekSenetKodu As DataSet
    Dim ds_tbMasrafMerkezi As DataSet
    Dim ds_tbCariIslem As DataSet
    Dim ds_tbsube As DataSet
    Public yeni As Boolean = False
    Dim status As Boolean = False
    Public bDevir As Boolean = False
    Public sCekSenetTipi As String = "AC"
    Public nCekSenetIslem As Integer = 1
    Public sCekSenetIslem As String = ""
    Public sHT As String = ""
    Dim dr As DataRow
    Dim bLoaded As Boolean = False
    Dim bKilitli As Boolean = False
    Dim bKilitAcabilir As Boolean = False
    Private Sub frm_tbMuhasebeFisi_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        Try
            tbFisKilit_sil(txt_lBordroNo.EditValue, Trim(sec_sCekSenetTipi.EditValue) + "\" + Trim(sec_nCekSenetIslem.EditValue), kullanici)
            tbCekSenet_Bakim()
        Catch ex As Exception
        End Try
        'lFisNo_degistir()
        'If FormatNumber(sorgu_lBakiye(txt_dteBordroTarihi.EditValue, 3, txt_lFisNo.EditValue), 2) <> "0.00" Then
        '    e.Cancel = True
        '    XtraMessageBox.Show(Sorgu_sDil("Fiþ Borç Alacak Toplamýnýn Eþit Olmasý Gerekmektedir..!",sDil), MessageBoxIcon.Warning)
        'End If
    End Sub
    Private Sub frm_tbNakitKasa_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        dataload_tbCekSenetTipi(sCekSenetTipi)
        dataload_tbCekSenetIslem(sCekSenetTipi, nCekSenetIslem)
        dataload_tbDovizCinsi()
        dataload_tbHareketTipi()
        dataload_tbMasrafMerkezi()
        dataload_tbsCariIslem()
        dataload_tbIl()
        dataload_tbBankaKodu()
        dataload_tbBankaSubeKodu()
        dataload_tbCekSenetKodu()
        dataload_tbSube()
        If sCekSenetTipi <> "" Then
            'sec_sCekSenetTipi.EditValue = sCekSenetTipi
            sec_sCekSenetTipi.Properties.ReadOnly = True
        End If
        If nCekSenetIslem = 0 Then
            'ElseIf nCekSenetIslem = 6 Then
            '    sec_nCekSenetIslem.EditValue = nCekSenetIslem
            '    sec_nCekSenetIslem.Text = sCekSenetIslem
        Else
            sec_nCekSenetIslem.EditValue = nCekSenetIslem
            sec_nCekSenetIslem.Text = sCekSenetIslem
            sec_nCekSenetIslem.Properties.ReadOnly = True
        End If
        If txt_lBordroNo.EditValue > 0 Then
            Dataload_tbCekSenetBordro(sec_sCekSenetTipi.EditValue, sec_nCekSenetIslem.EditValue, nFirmaId, txt_dteBordroTarihi.EditValue, txt_lBordroNo.EditValue, txt_sHareketTipi.EditValue)
            GridControl1.Focus()
            GridControl1.Select()
        Else
            txt_lBordroNo.EditValue = sorgu_lBordroNo()
            txt_musteriNo.Focus()
            txt_musteriNo.Select()
            txt_sHareketTipi.ItemIndex = 1
            Try
                ds_tbCekSenet.Tables(0).Clear()
            Catch ex As Exception
            End Try
            yeni = True
            firma_sec()
            Try
                tbFisKilit_ekle(txt_lBordroNo.EditValue, Trim(sec_sCekSenetTipi.EditValue) + "\" + Trim(sec_nCekSenetIslem.EditValue), kullanici, Now)
            Catch ex As Exception
                bKilitli = False
            End Try
        End If
        If ds_tbCekSenet.Tables(0).Rows.Count > 0 Then
            sec_sCekSenetTipi.Enabled = False
            sec_nCekSenetIslem.Enabled = False
            txt_musteriNo.Enabled = False
            txt_lBordroNo.Enabled = False
            txt_dteBordroTarihi.Enabled = False
            txt_sHareketTipi.Enabled = False
            sec_sSubeMagaza.Enabled = False
            For Each dr In ds_tbCekSenet.Tables(0).Rows
                If bDevir = False Then
                    If dr("nCariHareketID") = -1 Then
                        bDevir = True
                    End If
                End If
            Next
            If sorgu_nKilit(txt_lBordroNo.EditValue, Trim(sec_sCekSenetTipi.EditValue) + "\" + Trim(sec_nCekSenetIslem.EditValue), kullanici) = 0 Then
                bKilitli = False
                Try
                    tbFisKilit_ekle(txt_lBordroNo.EditValue, Trim(sec_sCekSenetTipi.EditValue) + "\" + Trim(sec_nCekSenetIslem.EditValue), kullanici, Now)
                Catch ex As Exception
                    bKilitli = True
                End Try
            Else
                bKilitli = True
            End If
        Else
            'sec_sCekSenetTipi.Enabled = False
            'sec_nCekSenetIslem.Enabled = False
            'txt_musteriNo.Enabled = False
            txt_lBordroNo.Enabled = False
            txt_dteBordroTarihi.Enabled = True
            txt_sHareketTipi.Enabled = True
        End If
        sec_bKilitli.Checked = sorgu_bKilitli(sec_sCekSenetTipi.EditValue, sec_nCekSenetIslem.EditValue, nFirmaId, txt_dteBordroTarihi.EditValue, txt_lBordroNo.EditValue, txt_sHareketTipi.EditValue)
        bKilitli = yetki_kontrol(kullanici, Trim(sec_sCekSenetTipi.EditValue) + "\" + Trim(sec_nCekSenetIslem.Text) & "_IslemYapamaz", False, 0)
        If sec_bKilitli.Checked = True Or bKilitli = True Then
            GridView1.OptionsBehavior.Editable = False
            btn_SatirEkle.Enabled = False
            btn_DegerYay.Enabled = False
            btn_SatirSil.Enabled = False
            btn_FisSil.Enabled = False
            EkleToolStripMenuItem.Enabled = False
            SilToolStripMenuItem.Enabled = False
            FisSilToolStripMenuItem1.Enabled = False
            btn_AltFisSil.Enabled = False
            btn_AltSatirEkle.Enabled = False
            btn_AltSatirSil.Enabled = False
        Else
            If ds_tbCekSenet.Tables(0).Rows.Count = 0 Then
                Try
                    kayit_ekle()
                Catch ex As Exception
                End Try
            End If
        End If
        Try
            gorunum_yukle()
        Catch ex As Exception
        End Try
        bKilitAcabilir = yetki_kontrol(kullanici, Trim(sec_sCekSenetTipi.EditValue) + "\" + Trim(sec_nCekSenetIslem.Text) & "_KilitAcabilir", False, 0)
        If kullanici > 3 And bKilitAcabilir = False Then
            sec_bKilitli.Enabled = False
            sec_bKilitli.Properties.ReadOnly = True
        Else
            sec_bKilitli.Properties.ReadOnly = False
            sec_bKilitli.Enabled = True
        End If
        Me.Text = sec_sCekSenetTipi.Text
        Me.Text += " [" & sec_nCekSenetIslem.Text & "]"
        If bDevir = True Then
            Me.Text += " [Devir] "
        End If
        If bKilitli = True Then
            Me.Text += Sorgu_sDil(" (Belge Kullanýmda) ", sDil)
        End If
        bLoaded = True
    End Sub
    Private Sub dataload_tbCekSenetTipi(ByVal sCekSenetTipi As String)
        ds_tbCekSenetTipi = sorgu(sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT     sCekSenetTipi,sAciklama FROM         tbCekSenetTipi Where sCekSenetTipi ='" & sCekSenetTipi & "'"))
        sec_sCekSenetTipi.Properties.DataSource = ds_tbCekSenetTipi.Tables(0)
        sec_sCekSenetTipi.ItemIndex = 0
    End Sub
    Private Sub dataload_tbCekSenetIslem(Optional ByVal sCekSenetTipi As String = "AC", Optional ByVal nCekSenetIslem As Integer = 1 And 6)
        If sCekSenetTipi = "AC" Or sCekSenetTipi = "AS" Then
            ds_tbCekSenetIslem = sorgu(sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT     nCekSenetIslem,sAciklama FROM         tbCekSenetIslem Where nCekSenetIslem = " & nCekSenetIslem & ""))
        ElseIf sCekSenetTipi = "BC" Or sCekSenetTipi = "BS" Then
            ds_tbCekSenetIslem = sorgu(sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT     nCekSenetIslem,sAciklama FROM         tbCekSenetIslem Where nCekSenetIslem =" & nCekSenetIslem & ""))
        End If
        sec_nCekSenetIslem.Properties.DataSource = ds_tbCekSenetIslem.Tables(0)
        sec_nCekSenetIslem.ItemIndex = 0
    End Sub
    Private Sub dataload_tbDovizCinsi()
        ds_tbDovizCinsi = sorgu(sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT     sDovizCinsi,sAciklama FROM         tbDovizCinsi"))
        sec_sDovizCinsi.DataSource = ds_tbDovizCinsi.Tables(0)
    End Sub
    Private Sub dataload_tbHareketTipi()
        ds_tbHareketTipi = sorgu(sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT     CAST(sHareketTipi AS CHAR(4)) AS sHareketTipi, sAciklama FROM         tbHareketTipi where aktif = 1"))
        sec_sHareketTipi.DataSource = ds_tbHareketTipi.Tables(0)
        txt_sHareketTipi.Properties.DataSource = ds_tbHareketTipi.Tables(0)
        txt_sHareketTipi.ItemIndex = 1
        If Trim(sHT) = "" Then
            txt_sHareketTipi.Text = sHareketTipi
        Else
            txt_sHareketTipi.EditValue = sHT
        End If
    End Sub
    Private Sub dataload_tbMasrafMerkezi()
        ds_tbMasrafMerkezi = sorgu(sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT sMasrafYontemi,sAciklama FROM         tbMasrafMerkezi"))
        sec_sMasrafMerkezi.DataSource = ds_tbMasrafMerkezi.Tables(0)
    End Sub
    Private Sub dataload_tbIl()
        ds_tbIl = sorgu(sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT     sIl FROM         tbIl"))
        sec_sIl.DataSource = ds_tbIl.Tables(0)
    End Sub
    Private Sub dataload_tbBankaKodu()
        ds_tbBankaKodu = sorgu(sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT     sBankaKodu,sAciklama FROM         tbBanka"))
        sec_sBankaKodu.DataSource = ds_tbBankaKodu.Tables(0)
        sec_sBanka.DataSource = ds_tbBankaKodu.Tables(0)
    End Sub
    Private Sub dataload_tbBankaSubeKodu(Optional ByVal sBankaKodu As String = "")
        ds_tbBankaSubeKodu = sorgu(sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT '' sBankaKodu, '' sBankaSubeKodu, '' sAciklama UNION SELECT sBankaKodu, sBankaSubeKodu, sAciklama FROM tbBankaSubesi  Where sBankaKodu = '" & sBankaKodu & "'"))
        sec_sBankaSubeKodu.DataSource = ds_tbBankaSubeKodu.Tables(0)
        sec_sBankaSube.DataSource = ds_tbBankaSubeKodu.Tables(0)
    End Sub
    Private Sub dataload_tbCekSenetKodu()
        ds_tbCekSenetKodu = sorgu(sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT     sCekSenetKodu,sAciklama FROM         tbCekSenetKodu"))
        sec_sCekSenetKodu.DataSource = ds_tbCekSenetKodu.Tables(0)
    End Sub
    Private Sub dataload_tbsCariIslem()
        ds_tbCariIslem = sorgu(sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT     sCariIslem,sAciklama FROM         tbCariIslem"))
        sec_sCariIslem.DataSource = ds_tbCariIslem.Tables(0)
    End Sub
    Private Sub dataload_tbSube()
        ds_tbsube = sorgu(sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT     sSubeMagaza,sAciklama FROM         tbSubeMagaza"))
        sec_sSubeMagaza.Properties.DataSource = ds_tbsube.Tables(0)
        sec_sSubeMagaza.ItemIndex = 1
        sec_sSubeMagaza.EditValue = sSubeMagaza
        If Trim(sHT) = "" Then
            sec_sSubeMagaza.EditValue = sSubeMagaza
        Else
            sec_sSubeMagaza.EditValue = Trim(sHT)
            sec_sSubeMagaza.Text = Trim(sHT)
        End If
        If Trim(sSubeMagaza) = "001" Then
            sec_sSubeMagaza.Properties.ReadOnly = False
        ElseIf Trim(sSubeMagaza) = "" Then
            sec_sSubeMagaza.Properties.ReadOnly = False
        Else
            sec_sSubeMagaza.Properties.ReadOnly = True
        End If
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
        If Trim(sDil) = "TR" Or Trim(sDil) = "" Then
            GridView1.SaveLayoutToRegistry("SOFTWARE\BusinessSmart\VIEW\MAGAZA\" & Me.Name.ToString & "")
        Else
            GridView1.SaveLayoutToRegistry("SOFTWARE\BusinessSmart\VIEW\MAGAZA\" & sDil & "\" & Me.Name.ToString & "")
        End If
        XtraMessageBox.Show(Sorgu_sDil("Görünüm Kaydedildi", sDil), Sorgu_sDil("Dikkat", sDil), MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub
    Private Sub gorunum_yukle()
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
        Dim row As Object
        For Each row In VGrid_Fima.Rows
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
        For Each row In VGridControl1.Rows
            Try
                row.Properties.Caption = Sorgu_sDil(row.Properties.Caption, sDil)
            Catch ex As Exception
            End Try
        Next
        Dim itm
        For Each itm In kisayol.Items
            itm.text = Sorgu_sDil(itm.text, sDil)
        Next
        LabelControl1.Text = Sorgu_sDil(LabelControl1.Text, sDil)
        LabelControl2.Text = Sorgu_sDil(LabelControl2.Text, sDil)
        LabelControl3.Text = Sorgu_sDil(LabelControl3.Text, sDil)
        LabelControl4.Text = Sorgu_sDil(LabelControl4.Text, sDil)
        LabelControl5.Text = Sorgu_sDil(LabelControl5.Text, sDil)
        LabelControl6.Text = Sorgu_sDil(LabelControl6.Text, sDil)
        LabelControl7.Text = Sorgu_sDil(LabelControl7.Text, sDil)
        sec_bKilitli.Text = Sorgu_sDil(sec_bKilitli.Text, sDil)
        btn_Goster.Text = Sorgu_sDil(btn_Goster.Text, sDil)
        If Trim(sDil) = "TR" Or Trim(sDil) = "" Then
            GridView1.RestoreLayoutFromRegistry("SOFTWARE\BusinessSmart\VIEW\MAGAZA\" & Me.Name.ToString & "")
        Else
            GridView1.RestoreLayoutFromRegistry("SOFTWARE\BusinessSmart\VIEW\MAGAZA\" & sDil & "\" & Me.Name.ToString & "")
        End If
    End Sub
    Private Function sorgu_query(ByVal query As String) As String
        query = Replace(query, "*!F", "F0" + firmano.ToString)
        query = Replace(query, "!D", "D000" + donemno.ToString)
        Return query
    End Function
    Private Function sorgu(ByVal query As String) As DataSet
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
        Dim N As Integer = adapter.Fill(DS, "TABLE1")
        con.Close()
        Return DS
    End Function
    Public Function sorgu_nCariHareketID() As Int64
        'Dim kriter As String = ""
        ''kriter = "WHERE (sKodu = '" & kod & "')  "
        'Dim conn As New OleDb.OleDbConnection
        'Dim cmd As New OleDb.OleDbCommand
        'Dim adapter As New OleDb.OleDbDataAdapter
        ''MsgBox(connection_resmi)
        'conn.ConnectionString = connection
        'cmd.Connection = conn
        'conn.Open()
        'cmd.CommandText = sorgu_query("SET DATEFORMAT DMY SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT     TOP 1 ISNULL(nHareketID + 1, 0) AS nCariHareketID  FROM         tbFirmaHareketi " & kriter & " ORDER BY nHareketID DESC")
        'Dim kayitsayisi = cmd.ExecuteScalar
        'Return kayitsayisi
        Return 1
    End Function
    Public Function sorgu_nBordroSatirID() As Int64
        Dim kriter As String = ""
        'kriter = "WHERE (sKodu = '" & kod & "')  "
        Dim conn As New OleDb.OleDbConnection
        Dim cmd As New OleDb.OleDbCommand
        Dim adapter As New OleDb.OleDbDataAdapter
        'MsgBox(connection_resmi)
        conn.ConnectionString = connection
        cmd.Connection = conn
        conn.Open()
        cmd.CommandText = sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT TOP 1 ISNULL(nBordroSatirID + 1, 1) AS nBordroSatirID FROM tbCekSenetBordro ORDER BY nBordroSatirID DESC")
        Dim kayitsayisi = cmd.ExecuteScalar
        If kayitsayisi = 0 Then
            kayitsayisi = 1
        End If
        Return kayitsayisi
    End Function
    Public Function sorgu_nCekSenetID() As Int64
        Dim kriter As String = ""
        'kriter = "WHERE (sKodu = '" & kod & "')  "
        Dim conn As New OleDb.OleDbConnection
        Dim cmd As New OleDb.OleDbCommand
        Dim adapter As New OleDb.OleDbDataAdapter
        'MsgBox(connection_resmi)
        conn.ConnectionString = connection
        cmd.Connection = conn
        conn.Open()
        cmd.CommandText = sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT TOP 1 ISNULL(nCekSenetID + 1, 1) AS nCekSenetID FROM tbCekSenet ORDER BY nCekSenetID DESC")
        Dim kayitsayisi = cmd.ExecuteScalar
        If kayitsayisi = 0 Then
            kayitsayisi = 1
        End If
        Return kayitsayisi
    End Function
    Public Function sorgu_nKasaIslemID() As Int64
        Dim kriter As String = ""
        'kriter = "WHERE (sKodu = '" & kod & "')  "
        Dim conn As New OleDb.OleDbConnection
        Dim cmd As New OleDb.OleDbCommand
        Dim adapter As New OleDb.OleDbDataAdapter
        'MsgBox(connection_resmi)
        conn.ConnectionString = connection
        cmd.Connection = conn
        conn.Open()
        cmd.CommandText = sorgu_query("SET DATEFORMAT DMY SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT     ISNULL(nSonID,0) + 1 AS nKasaIslemID FROM         tbCariSiraNo WHERE     (nSiraIndex = 2)")
        Dim kayitsayisi = cmd.ExecuteScalar
        If kayitsayisi = 0 Then
            kayitsayisi = 1
        End If
        Return kayitsayisi
    End Function
    Public Function sorgu_lCekSenetNo(ByVal sCekSenetTipi As String) As Int64
        Dim kriter As String = ""
        'kriter = "WHERE (sKodu = '" & kod & "')  "
        Dim conn As New OleDb.OleDbConnection
        Dim cmd As New OleDb.OleDbCommand
        Dim adapter As New OleDb.OleDbDataAdapter
        'MsgBox(connection_resmi)
        conn.ConnectionString = connection
        cmd.Connection = conn
        conn.Open()
        cmd.CommandText = sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT TOP 1 ISNULL(lCekSenetNo + 1, 1) AS lCekSenetNo FROM tbCekSenet Where sCekSenetTipi = '" & sCekSenetTipi & "' ORDER BY lCekSenetNo DESC")
        Dim kayitsayisi = cmd.ExecuteScalar
        If kayitsayisi = 0 Then
            kayitsayisi = 1
        End If
        Return kayitsayisi
    End Function
    Public Function sorgu_lBordroNo() As Int64
        Dim kriter As String = ""
        'kriter = "WHERE (sKodu = '" & kod & "')  "
        Dim conn As New OleDb.OleDbConnection
        Dim cmd As New OleDb.OleDbCommand
        Dim adapter As New OleDb.OleDbDataAdapter
        'MsgBox(connection_resmi)
        conn.ConnectionString = connection
        cmd.Connection = conn
        conn.Open()
        'cmd.CommandText = sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT TOP 1 ISNULL(lBordroNo + 1, 1) AS lBordroNo FROM tbCekSenetBordro ORDER BY lBordroNo DESC")
        cmd.CommandText = sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT     ISNULL(MAX(lBordroNo + 1),1) AS lBordroNo FROM         tbCekSenetBordro")
        Dim kayitsayisi = cmd.ExecuteScalar
        If kayitsayisi = 0 Then
            kayitsayisi = 1
        End If
        Return kayitsayisi
    End Function
    Public Function sorgu_bKilitli(ByVal sCekSenetTipi As String, ByVal nCekSenetIslem As String, ByVal nFirmaID As String, ByVal dteBordroTarihi As DateTime, ByVal lBordroNo As Int64, ByVal sHareketTipi As String) As Byte
        Dim kriter As String = ""
        Dim conn As New OleDb.OleDbConnection
        Dim cmd As New OleDb.OleDbCommand
        conn.ConnectionString = connection
        cmd.Connection = conn
        conn.Open()
        'cmd.CommandText = sorgu_query("SET DATEFORMAT DMY SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT ISNULL(tbCekSenetBordro.bKilitli,0) FROM tbFirma INNER JOIN tbCekSenetBordro ON tbFirma.nFirmaID = tbCekSenetBordro.nFirmaID INNER JOIN tbCekSenet ON tbCekSenetBordro.nCekSenetID = tbCekSenet.nCekSenetID WHERE (tbCekSenet.sCekSenetTipi = '" & sCekSenetTipi & "') AND (tbCekSenetBordro.nCekSenetIslem = " & nCekSenetIslem & ") AND (tbCekSenetBordro.dteBordroTarihi = '" & dteBordroTarihi & "') AND (tbCekSenetBordro.lBordroNo = " & lBordroNo & ") AND (tbFirma.nFirmaID = " & nFirmaID & ")  AND (tbCekSenet.sHareketTipi = '" & sHareketTipi & "') GROUP BY tbFirma.sKodu, tbFirma.sAciklama, tbCekSenetBordro.lBordroNo, tbCekSenetBordro.dteBordroTarihi, tbCekSenet.sCekSenetTipi, tbCekSenetBordro.nCekSenetIslem, tbFirma.nFirmaID, tbCekSenetBordro.bKilitli ")
        cmd.CommandText = sorgu_query("SET DATEFORMAT DMY SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT ISNULL(tbCekSenetBordro.bKilitli,0) FROM tbFirma INNER JOIN tbCekSenetBordro ON tbFirma.nFirmaID = tbCekSenetBordro.nFirmaID INNER JOIN tbCekSenet ON tbCekSenetBordro.nCekSenetID = tbCekSenet.nCekSenetID WHERE (tbCekSenet.sCekSenetTipi = '" & sCekSenetTipi & "') AND (tbCekSenetBordro.nCekSenetIslem = " & nCekSenetIslem & ") AND (tbCekSenetBordro.dteBordroTarihi = '" & dteBordroTarihi & "') AND (tbCekSenetBordro.lBordroNo = " & lBordroNo & ") AND (tbFirma.nFirmaID = " & nFirmaID & ")   GROUP BY tbFirma.sKodu, tbFirma.sAciklama, tbCekSenetBordro.lBordroNo, tbCekSenetBordro.dteBordroTarihi, tbCekSenet.sCekSenetTipi, tbCekSenetBordro.nCekSenetIslem, tbFirma.nFirmaID, tbCekSenetBordro.bKilitli ")
        Dim kayitsayisi = cmd.ExecuteScalar
        Return kayitsayisi
    End Function
    Public Function sorgu_sBankaAdi(ByVal sBankaKodu As String) As String
        Dim dr As DataRow
        Dim sAciklama As String = ""
        For Each dr In ds_tbBankaKodu.Tables(0).Rows
            If Trim(dr("sBankaKodu")) = Trim(sBankaKodu) Then
                sAciklama = dr("sAciklama")
            End If
        Next
        Return sAciklama
    End Function
    Public Function sorgu_sCekSenetIslem(ByVal nCekSenetIslem As String) As String
        Dim dr As DataRow
        Dim sAciklama As String = ""
        For Each dr In ds_tbCekSenetIslem.Tables(0).Rows
            If Trim(dr("nCekSenetIslem")) = Trim(nCekSenetIslem) Then
                sAciklama = dr("sAciklama")
            End If
        Next
        Return sAciklama
    End Function
    Public Function sorgu_sCekSenetAciklama(ByVal sCekSenetTipi As String) As String
        Dim dr As DataRow
        Dim sAciklama As String = ""
        For Each dr In ds_tbCekSenetTipi.Tables(0).Rows
            If Trim(dr("sCekSenetTipi")) = Trim(sCekSenetTipi) Then
                sAciklama = dr("sAciklama")
            End If
        Next
        Return sAciklama
    End Function
    Public Sub Dataload_tbCekSenetBordro(ByVal sCekSenetTipi As String, ByVal nCekSenetIslem As String, ByVal nFirmaID As String, ByVal dteBordroTarihi As DateTime, ByVal lBordroNo As Int64, ByVal sHareketTipi As String)
        status = True
        Try
            ds_tbCekSenet.Tables(0).Clear()
        Catch ex As Exception
        End Try
        Dim conn As New OleDb.OleDbConnection
        Dim cmd As New OleDb.OleDbCommand
        Dim adapter As New OleDb.OleDbDataAdapter
        conn.ConnectionString = connection
        adapter.SelectCommand = cmd
        cmd.CommandText = sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT tbCekSenetBordro.nBordroSatirID, tbCekSenet.nCekSenetID, tbCekSenet.lCekSenetNo, tbCekSenet.lTutar, tbCekSenet.dteVadeTarihi, DATEDIFF(day, tbCekSenetBordro.dteBordroTarihi, tbCekSenet.dteVadeTarihi) AS nOpsiyon,tbCekSenet.sHareketTipi, tbCekSenet.sNot, tbCekSenet.sIl, tbCekSenet.sSemt, tbCekSenet.sKarsiTarafCekSenetNo, tbCekSenet.dteDuzenlemeTarihi, tbCekSenet.sBankaKodu, tbCekSenet.sBankaHesapNo, tbCekSenet.sBankaSubeNo, tbCekSenet.sOrjinalCekSenetNo, tbCekSenet.nVerenID, tbCekSenet.bKendineAit, tbCekSenet.sBorclusu, tbCekSenet.sBorcluVergiDairesi, tbCekSenet.sBorcluVergiNumarasi, tbCekSenet.nSonBordroSatirID, tbCekSenet.nSonCekSenetIslem, ISNULL(tbCekSenetBordro.nCariHareketID, 0) AS nCariHareketID, ISNULL(tbCekSenetBordro.nKasaIslemID, 0) AS nKasaIslemID, ISNULL(tbCekSenetBordro.nBorcluFirmaID, 0) AS nBorcluFirmaID, ISNULL(tbCekSenetBordro.nBorcluCariHareketID, 0) AS nBorcluCariHareketID, ISNULL(tbCekSenetBordro.nProtestoMasrafiFirmaID, 0) AS nProtestoMasrafiFirmaID, ISNULL(tbCekSenetBordro.nProtestoMasrafiCariHareketID, 0) AS nProtestoMasrafiCariHareketID, tbCekSenetBordro.lProtestoMasrafi, tbCekSenetBordro.nOncekiBordroSatirID, tbCekSenetBordro.nOncekiCekSenetIslem, tbCekSenetBordro.dteValorTarihi, tbCekSenetBordro.bMuhasebeyeIslendimi, tbCekSenet.sDovizCinsi1, tbCekSenet.lDovizMiktari1, tbCekSenet.lDovizKuru1, tbCekSenet.sDovizCinsi2, tbCekSenet.lDovizMiktari2, tbCekSenet.lDovizKuru2, tbCekSenet.sCekSenetKodu1, tbCekSenet.sCekSenetKodu2,tbCekSenetBordro.nFirmaID,tbCekSenet.sCekSenetTipi,tbCekSenetBordro.nCekSenetIslem,tbCekSenet.sKullaniciAdi, tbCekSenet.dteKayitTarihi,tbCekSenetBordro.dteBordroTarihi,tbCekSenetBordro.lBordroNo,tbFirma.sKodu as sFirmaKodu,tbCekSenetBordro.bKilitli,(SELECT ISNULL(sAciklama,'') FROM tbBanka WHERE sBankaKodu = tbCekSenet.sBankaKodu) AS sBankaAdi,(SELECT ISNULL(sAciklama,'') FROM tbBankaSubesi WHERE sBankaSubeKodu = tbCekSenet.sBankaSubeNo AND sBankaKodu = tbCekSenet.sBankaKodu) AS sBankaSubeAdi FROM tbCekSenetBordro INNER JOIN tbCekSenet ON tbCekSenetBordro.nCekSenetID = tbCekSenet.nCekSenetID LEFT OUTER JOIN tbFirma ON tbCekSenetBordro.nFirmaID = tbFirma.nFirmaID WHERE (tbCekSenet.sCekSenetTipi = '" & sCekSenetTipi & "') AND (tbCekSenetBordro.nCekSenetIslem = " & nCekSenetIslem & ") AND (tbCekSenetBordro.dteBordroTarihi = '" & dteBordroTarihi & "') AND (tbCekSenetBordro.lBordroNo = " & lBordroNo & ") AND (tbCekSenetBordro.nFirmaID = " & nFirmaID & ")")
        cmd.Connection = conn
        conn.Open()
        Dim N As Integer = adapter.Fill(ds_tbCekSenet, "Table1")
        conn.Close()
        Dataload_tbYekun("", sec_sCekSenetTipi.EditValue, sec_nCekSenetIslem.EditValue, nFirmaID, txt_dteBordroTarihi.EditValue, txt_lBordroNo.EditValue, txt_sHareketTipi.EditValue)
        If GridView1.RowCount > 0 Then
            GridView1.ClearSelection()
            GridView1.SelectRow(GridView1.RowCount - 1)
            PanelControl3.Focus()
            GridControl1.Focus()
        End If
        'If ds_tbMuhasebeFisi.Tables(0).Rows.Count > 0 Then
        '    If sorgu_sAciklama_kontrol(sec_sCekSenetTipi.EditValue, sec_nCekSenetIslem.EditValue, nFirmaID, txt_dteBordroTarihi.EditValue, txt_lBordroNo.EditValue, txt_sHareketTipi.EditValue) = True Then
        '        tbMuhasebeFisi_Aciklamasi_kaydet_yeni(txt_dteFisTarihi.EditValue, sec_sMuhFisTipi.SelectedIndex + 1, txt_lFisNo.EditValue, "", "", "", "", "")
        '    End If
        '    txt_sHareketTipi.EditValue = sorgu_sHareketTipi_kontrol(txt_dteFisTarihi.EditValue, sec_sMuhFisTipi.SelectedIndex + 1, txt_lFisNo.EditValue)
        'End If
        status = False
        satir_kontrol()
    End Sub
    Public Sub Dataload_tbYekun(ByVal sAciklama As String, ByVal sCekSenetTipi As String, ByVal nCekSenetIslem As String, ByVal nFirmaID As String, ByVal dteBordroTarihi As DateTime, ByVal lBordroNo As Int64, ByVal sHareketTipi As String)
        Try
            ds_tbCekSenetBordroToplam.Tables(0).Clear()
        Catch ex As Exception
        End Try
        Dim conn As New OleDb.OleDbConnection
        Dim cmd As New OleDb.OleDbCommand
        Dim adapter As New OleDb.OleDbDataAdapter
        conn.ConnectionString = connection
        adapter.SelectCommand = cmd
        If nCekSenetIslem = 11 Then
            cmd.CommandText = sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT '" & sAciklama & " ' AS sAciklama, COUNT(tbCekSenet.lCekSenetNo) AS nKayit, SUM(tbCekSenetBordro.lProtestoMasrafi) AS lTutar, CAST(ROUND(SUM(ISNULL(tbCekSenet.lTutar, 0) * CAST(tbCekSenet.dteVadeTarihi AS FLOAT)) / SUM(tbCekSenet.lTutar), 0) AS DATETIME) AS dteOrtVade FROM tbCekSenetBordro INNER JOIN tbCekSenet ON tbCekSenetBordro.nCekSenetID = tbCekSenet.nCekSenetID LEFT OUTER JOIN tbFirma ON tbCekSenetBordro.nFirmaID = tbFirma.nFirmaID WHERE (tbCekSenet.sCekSenetTipi = '" & sCekSenetTipi & "') AND (tbCekSenetBordro.nCekSenetIslem = " & nCekSenetIslem & ") AND (tbCekSenetBordro.dteBordroTarihi = '" & dteBordroTarihi & "') AND (tbCekSenetBordro.lBordroNo = " & lBordroNo & ") AND (tbCekSenetBordro.nFirmaID = " & nFirmaID & ") ")
        Else
            cmd.CommandText = sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT '" & sAciklama & " ' AS sAciklama, COUNT(tbCekSenet.lCekSenetNo) AS nKayit, SUM(tbCekSenet.lTutar) AS lTutar, CAST(ROUND(SUM(ISNULL(tbCekSenet.lTutar, 0) * CAST(tbCekSenet.dteVadeTarihi AS FLOAT)) / SUM(tbCekSenet.lTutar), 0) AS DATETIME) AS dteOrtVade FROM tbCekSenetBordro INNER JOIN tbCekSenet ON tbCekSenetBordro.nCekSenetID = tbCekSenet.nCekSenetID LEFT OUTER JOIN tbFirma ON tbCekSenetBordro.nFirmaID = tbFirma.nFirmaID WHERE (tbCekSenet.sCekSenetTipi = '" & sCekSenetTipi & "') AND (tbCekSenetBordro.nCekSenetIslem = " & nCekSenetIslem & ") AND (tbCekSenetBordro.dteBordroTarihi = '" & dteBordroTarihi & "') AND (tbCekSenetBordro.lBordroNo = " & lBordroNo & ") AND (tbCekSenetBordro.nFirmaID = " & nFirmaID & ") ")
        End If
        cmd.Connection = conn
        conn.Open()
        Dim N As Integer = adapter.Fill(ds_tbCekSenetBordroToplam, "Toplam")
        conn.Close()
        If GridView1.RowCount > 0 Then
            sec_sCekSenetTipi.Enabled = False
            sec_nCekSenetIslem.Enabled = False
            txt_musteriNo.Enabled = False
            txt_lBordroNo.Enabled = False
            txt_dteBordroTarihi.Enabled = False
            txt_sHareketTipi.Enabled = False
            sec_sSubeMagaza.Enabled = False
        Else
            'sec_sCekSenetTipi.Enabled = False
            'sec_nCekSenetIslem.Enabled = False
            'txt_musteriNo.Enabled = False
            txt_lBordroNo.Enabled = False
            txt_dteBordroTarihi.Enabled = True
            txt_sHareketTipi.Enabled = True
        End If
    End Sub
    Public Sub Dataload_tbFirma(ByVal nFirmaID As String)
        Try
            ds_tbFirma.Tables(0).Clear()
        Catch ex As Exception
        End Try
        Dim conn As New OleDb.OleDbConnection
        Dim cmd As New OleDb.OleDbCommand
        Dim adapter As New OleDb.OleDbDataAdapter
        conn.ConnectionString = connection
        adapter.SelectCommand = cmd
        'cmd.CommandText = sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT nFirmaID, sKodu, sAciklama, nOzelIskontosu, lKrediLimiti, nVadeGun, nHesapID, (SELECT ISNULL(SUM(lBorcTutar) , 0) AS lBorcTutar FROM tbFirmaHareketi WHERE nFirmaID = tbFirma.nFirmaID) AS lBorcTutar, (SELECT ISNULL(SUM(lAlacakTutar) , 0) AS lAlacakTutar FROM tbFirmaHareketi WHERE nFirmaID = tbFirma.nFirmaID) AS lAlacakTutar, (SELECT ISNULL(SUM(lBorcTutar - lAlacakTutar) , 0) AS lBakiye FROM tbFirmaHareketi WHERE nFirmaID = tbFirma.nFirmaID) AS lBakiye, (SELECT ISNULL(SUM(lTutar) , 0) AS Expr1 FROM tbCekSenet WHERE (nVerenID = tbFirma.nFirmaID) AND (sCekSenetTipi = 'AC' OR sCekSenetTipi = 'AS') AND (nSonCekSenetIslem <= 6) AND (nSonCekSenetIslem <> 2)) AS lRisk FROM tbFirma WHERE (nFirmaID = '" & sFirmaKodu & "') ")
        cmd.CommandText = sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT nFirmaID, sKodu, sAciklama, nOzelIskontosu, lKrediLimiti, nVadeGun, nHesapID, lBorcTutar = CASE WHEN tbFirma.sDovizCinsi = '   ' THEN (SELECT ISNULL(SUM(lBorcTutar ), 0) AS lBorcTutar FROM tbFirmaHareketi WHERE nFirmaID = tbFirma.nFirmaID) ELSE (SELECT ISNULL(SUM((lBorcTutar )/lDovizKuru1) , 0) AS lBorcTutar FROM tbFirmaHareketi WHERE nFirmaID = tbFirma.nFirmaID AND sDovizCinsi1 = tbFirma.sDovizCinsi) END, lAlacakTutar = CASE WHEN tbFirma.sDovizCinsi = '   ' THEN (SELECT ISNULL(SUM(lAlacakTutar), 0) AS lAlacakTutar FROM tbFirmaHareketi WHERE nFirmaID = tbFirma.nFirmaID) ELSE (SELECT ISNULL(SUM((lAlacakTutar)/lDovizKuru1) , 0) AS lAlacakTutar FROM tbFirmaHareketi WHERE nFirmaID = tbFirma.nFirmaID AND sDovizCinsi1 = tbFirma.sDovizCinsi) END, lBakiye = CASE WHEN tbFirma.sDovizCinsi = '   ' THEN (SELECT ISNULL(SUM(lBorcTutar - lAlacakTutar), 0) AS lBakiye FROM tbFirmaHareketi WHERE nFirmaID = tbFirma.nFirmaID) ELSE (SELECT ISNULL(SUM((lBorcTutar - lAlacakTutar)/lDovizKuru1) , 0) AS lBakiye FROM tbFirmaHareketi WHERE nFirmaID = tbFirma.nFirmaID AND sDovizCinsi1 = tbFirma.sDovizCinsi) END, (SELECT ISNULL(SUM(lTutar) , 0) AS Expr1 FROM tbCekSenet WHERE (nVerenID = tbFirma.nFirmaID) AND (sCekSenetTipi = 'AC' OR sCekSenetTipi = 'AS') AND (nSonCekSenetIslem <= 6) AND (nSonCekSenetIslem <> 2)) AS lRisk FROM tbFirma WHERE (nFirmaID = '" & nFirmaID & "') ")
        cmd.Connection = conn
        conn.Open()
        Dim N As Integer = adapter.Fill(ds_tbFirma, "Table1")
        conn.Close()
        VGrid_Fima.DataMember = Nothing
        VGrid_Fima.DataSource = ds_tbFirma.Tables(0)
    End Sub
    Public Sub Dataload_tbHesap(ByVal nHesapID As String)
        Try
            ds_tbHesapPlani.Tables(0).Clear()
        Catch ex As Exception
        End Try
        Dim conn As New OleDb.OleDbConnection
        Dim cmd As New OleDb.OleDbCommand
        Dim adapter As New OleDb.OleDbDataAdapter
        conn.ConnectionString = connection
        adapter.SelectCommand = cmd
        cmd.CommandText = sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT tbHesapPlani.nHesapID, tbHesapPlani.sKodu, tbHesapPlani.sAciklama, ISNULL(SUM(tbMuhasebeFisi.lBorcTutar), 0) AS lBorcTutar, ISNULL(SUM(tbMuhasebeFisi.lAlacakTutar), 0) AS lAlacakTutar, ISNULL(SUM(tbMuhasebeFisi.lBorcTutar - tbMuhasebeFisi.lAlacakTutar), 0) AS lBakiye, ISNULL(SUM(tbMuhasebeFisi.lGirenMiktar), 0) AS lGirenMiktar, ISNULL(SUM(tbMuhasebeFisi.lCikanMiktar), 0) AS lCikanMiktar, ISNULL(SUM(tbMuhasebeFisi.lGirenMiktar - tbMuhasebeFisi.lCikanMiktar), 0) AS lKalan FROM tbMuhasebeFisi WITH (INDEX (tbMuhasebeFisi_index2)) INNER JOIN tbHesapPlani ON tbMuhasebeFisi.nHesapID = tbHesapPlani.nHesapID WHERE (tbMuhasebeFisi.nHesapID = " & nHesapID & ") GROUP BY tbHesapPlani.nHesapID, tbHesapPlani.sKodu, tbHesapPlani.sAciklama ")
        cmd.Connection = conn
        conn.Open()
        Dim N As Integer = adapter.Fill(ds_tbHesapPlani, "Table1")
        conn.Close()
    End Sub
    Public Function sorgu_sAciklama_kontrol(ByVal dteFisTarihi As DateTime, ByVal sMuhFisTipi As String, ByVal lFisNo As Int64) As Boolean
        Dim kriter
        Dim pass As Boolean
        kriter = ""
        Dim conn As New OleDb.OleDbConnection
        Dim cmd As New OleDb.OleDbCommand
        Dim adapter As New OleDb.OleDbDataAdapter
        conn.ConnectionString = connection
        cmd.Connection = conn
        conn.Open()
        cmd.CommandText = sorgu_query("SET DATEFORMAT DMY SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT ISNULL(COUNT(*),0) AS nKayit FROM tbMuhasebeFisiAciklamasi WHERE (dteFisTarihi = '" & dteFisTarihi & "') AND (sMuhFisTipi = " & sMuhFisTipi & ") AND (lFisno = " & lFisNo & ")")
        Dim kayitsayisi = cmd.ExecuteScalar
        If kayitsayisi = 0 Then
            pass = True
        Else
            pass = False
        End If
        Return pass
    End Function
    Public Function sorgu_sHareketTipi_kontrol(ByVal dteFisTarihi As DateTime, ByVal sMuhFisTipi As String, ByVal lFisNo As Int64) As String
        Dim kriter
        kriter = ""
        Dim conn As New OleDb.OleDbConnection
        Dim cmd As New OleDb.OleDbCommand
        Dim adapter As New OleDb.OleDbDataAdapter
        conn.ConnectionString = connection
        cmd.Connection = conn
        conn.Open()
        cmd.CommandText = sorgu_query("SET DATEFORMAT DMY SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT DISTINCT ISNULL(sHareketTipi,'') as sHareketTipi FROM         tbMuhasebeFisi WHERE (dteFisTarihi = '" & dteFisTarihi & "') AND (sMuhFisTipi = " & sMuhFisTipi & ") AND (lFisno = " & lFisNo & ")")
        Dim kayitsayisi = cmd.ExecuteScalar
        Return kayitsayisi
    End Function
    Public Function sorgu_sSubeMagaza_kontrol(ByVal dteFisTarihi As DateTime, ByVal sMuhFisTipi As String, ByVal lFisNo As Int64) As String
        Dim kriter
        kriter = ""
        Dim conn As New OleDb.OleDbConnection
        Dim cmd As New OleDb.OleDbCommand
        Dim adapter As New OleDb.OleDbDataAdapter
        conn.ConnectionString = connection
        cmd.Connection = conn
        conn.Open()
        cmd.CommandText = sorgu_query("SET DATEFORMAT DMY SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT DISTINCT ISNULL(sSubeMagaza,'') as sSubeMagaza FROM         tbMuhasebeFisi WHERE (dteFisTarihi = '" & dteFisTarihi & "') AND (sMuhFisTipi = " & sMuhFisTipi & ") AND (lFisno = " & lFisNo & ")")
        Dim kayitsayisi = cmd.ExecuteScalar
        Return kayitsayisi
    End Function
    Private Function tbCekSenetBordro_kaydet_yeni(ByVal nBordroSatirID As Int64, ByVal nCekSenetIslem As Int64, ByVal nFirmaID As Int64, ByVal dteBordroTarihi As DateTime, ByVal lBordroNo As Int64, ByVal nCekSenetID As Int64, ByVal nOncekiBordroSatirID As Int64, ByVal nOncekiCekSenetIslem As Int64, ByVal nCariHareketID As Int64, ByVal nKasaIslemID As String, ByVal nBorcluFirmaID As Int64, ByVal nBorcluCariHareketID As String, ByVal nProtestoMasrafiFirmaID As Int64, ByVal nProtestoMasrafiCariHareketID As String, ByVal lProtestoMasrafi As Decimal, ByVal dteValorTarihi As DateTime, ByVal bMuhasebeyeIslendimi As Integer, ByVal sKullaniciAdi As String, ByVal dteKayitTarihi As DateTime) As Int64
        Dim con As New OleDb.OleDbConnection
        Dim cmd As New OleDb.OleDbCommand
        If nProtestoMasrafiCariHareketID = "" Then
            nProtestoMasrafiCariHareketID = "NULL"
        End If
        If nKasaIslemID = "" Then
            nKasaIslemID = "NULL"
        End If
        cmd.Connection = con
        con.ConnectionString = connection
        If con.State = ConnectionState.Closed = True Then
            con.Open()
        End If
        If nCekSenetIslem = 24 Then
            cmd.CommandText = sorgu_query("SET DATEFORMAT DMY SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED INSERT INTO tbCekSenetBordro ( nCekSenetIslem, nFirmaID, dteBordroTarihi, lBordroNo, nCekSenetID, nOncekiBordroSatirID, nOncekiCekSenetIslem, nCariHareketID, nBorcluFirmaID, nBorcluCariHareketID,nProtestoMasrafiFirmaID, lProtestoMasrafi, dteValorTarihi, bMuhasebeyeIslendimi, sKullaniciAdi, dteKayitTarihi) VALUES     ( " & nCekSenetIslem & ", " & nFirmaID & ", '" & dteBordroTarihi & "', " & lBordroNo & ", " & nCekSenetID & ", " & nOncekiBordroSatirID & ", " & nOncekiCekSenetIslem & ", NULL, " & nBorcluFirmaID & ", " & nBorcluCariHareketID & " ," & nProtestoMasrafiFirmaID & ", " & lProtestoMasrafi & ", '" & dteValorTarihi & "', " & bMuhasebeyeIslendimi & ", '" & sKullaniciAdi & "', '" & dteKayitTarihi & "')")
        Else
            cmd.CommandText = sorgu_query("SET DATEFORMAT DMY SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED INSERT INTO tbCekSenetBordro ( nCekSenetIslem, nFirmaID, dteBordroTarihi, lBordroNo, nCekSenetID, nOncekiBordroSatirID, nOncekiCekSenetIslem, nCariHareketID, nKasaIslemID,nBorcluFirmaID, nProtestoMasrafiFirmaID,nProtestoMasrafiCariHareketID, lProtestoMasrafi, dteValorTarihi, bMuhasebeyeIslendimi, sKullaniciAdi, dteKayitTarihi) VALUES     ( " & nCekSenetIslem & ", " & nFirmaID & ", '" & dteBordroTarihi & "', " & lBordroNo & ", " & nCekSenetID & ", " & nOncekiBordroSatirID & ", " & nOncekiCekSenetIslem & ", " & nCariHareketID & "," & nKasaIslemID & ", " & nBorcluFirmaID & ", " & nProtestoMasrafiFirmaID & ", " & nProtestoMasrafiCariHareketID & "," & lProtestoMasrafi & ", '" & dteValorTarihi & "', " & bMuhasebeyeIslendimi & ", '" & sKullaniciAdi & "', '" & dteKayitTarihi & "')")
        End If
        cmd.ExecuteNonQuery()
        cmd.CommandText = "SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT @@identity"
        nBordroSatirID = cmd.ExecuteScalar
        Return nBordroSatirID
        con.Close()
    End Function
    Private Sub tbCekSenetBordro_kaydet_duzelt(ByVal nBordroSatirID As Int64, ByVal nCekSenetIslem As Int64, ByVal nFirmaID As Int64, ByVal dteBordroTarihi As DateTime, ByVal lBordroNo As Int64, ByVal nCekSenetID As Int64, ByVal nOncekiBordroSatirID As Int64, ByVal nOncekiCekSenetIslem As Int64, ByVal nCariHareketID As Int64, ByVal nBorcluFirmaID As Int64, ByVal nProtestoMasrafiFirmaID As Int64, ByVal lProtestoMasrafi As Decimal, ByVal dteValorTarihi As DateTime, ByVal bMuhasebeyeIslendimi As Integer, ByVal sKullaniciAdi As String, ByVal dteKayitTarihi As DateTime, ByVal bKilitli As Byte)
        Dim con As New OleDb.OleDbConnection
        Dim cmd As New OleDb.OleDbCommand
        cmd.Connection = con
        con.ConnectionString = connection
        If con.State = ConnectionState.Closed = True Then
            con.Open()
        End If
        cmd.CommandText = sorgu_query("SET DATEFORMAT DMY SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED UPDATE    tbCekSenetBordro SET              nCekSenetIslem = " & nCekSenetIslem & ", nFirmaID = " & nFirmaID & ", dteBordroTarihi = '" & dteBordroTarihi & "', lBordroNo = " & lBordroNo & ", nCekSenetID = " & nCekSenetID & ", nOncekiBordroSatirID = " & nOncekiBordroSatirID & ", nOncekiCekSenetIslem = " & nOncekiCekSenetIslem & ", nCariHareketID = " & nCariHareketID & ", nBorcluFirmaID = " & nBorcluFirmaID & ", nProtestoMasrafiFirmaID = " & nProtestoMasrafiFirmaID & ", lProtestoMasrafi = " & lProtestoMasrafi & ", dteValorTarihi = '" & dteValorTarihi & "', bMuhasebeyeIslendimi = " & bMuhasebeyeIslendimi & ",bKilitli=" & bKilitli & " Where nBordroSatirID = '" & nBordroSatirID & "'")
        cmd.ExecuteNonQuery()
        con.Close()
    End Sub
    Private Function tbCekSenet_kaydet_yeni(ByVal nCekSenetID As Int64, ByVal sCekSenetTipi As String, ByVal lCekSenetNo As Int64, ByVal sBankaKodu As String, ByVal lTutar As Decimal, ByVal dteVadeTarihi As DateTime, ByVal dteDuzenlemeTarihi As DateTime, ByVal sIl As String, ByVal sSemt As String, ByVal sOrjinalCekSenetNo As String, ByVal sKarsiTarafCekSenetNo As String, ByVal nVerenID As Int64, ByVal bKendineAit As Integer, ByVal sBorclusu As String, ByVal sBorcluVergiDairesi As String, ByVal sBorcluVergiNumarasi As String, ByVal sBankaHesapNo As String, ByVal sBankaSubeNo As String, ByVal nSonBordroSatirID As Int64, ByVal nSonCekSenetIslem As Int64, ByVal sHareketTipi As String, ByVal sNot As String, ByVal sKullaniciAdi As String, ByVal dteKayitTarihi As DateTime, ByVal sDovizCinsi1 As String, ByVal lDovizMiktari1 As Decimal, ByVal lDovizKuru1 As Decimal, ByVal sDovizCinsi2 As String, ByVal lDovizMiktari2 As Decimal, ByVal lDovizKuru2 As Decimal, ByVal sSonKullaniciAdi As String, ByVal dteSonUpdateTarihi As DateTime, ByVal sCekSenetKodu1 As String, ByVal sCekSenetKodu2 As String) As Int64
        Dim con As New OleDb.OleDbConnection
        Dim cmd As New OleDb.OleDbCommand
        cmd.Connection = con
        con.ConnectionString = connection
        If con.State = ConnectionState.Closed = True Then
            con.Open()
        End If
        cmd.CommandText = sorgu_query("SET DATEFORMAT DMY SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED INSERT INTO tbCekSenet ( sCekSenetTipi, lCekSenetNo, sBankaKodu, lTutar, dteVadeTarihi, dteDuzenlemeTarihi, sIl, sSemt, sOrjinalCekSenetNo, sKarsiTarafCekSenetNo, nVerenID, bKendineAit, sBorclusu, sBorcluVergiDairesi, sBorcluVergiNumarasi, sBankaHesapNo, sBankaSubeNo, nSonBordroSatirID, nSonCekSenetIslem, sHareketTipi, sNot, sKullaniciAdi, dteKayitTarihi, sDovizCinsi1, lDovizMiktari1, lDovizKuru1, sDovizCinsi2, lDovizMiktari2, lDovizKuru2, sSonKullaniciAdi, dteSonUpdateTarihi, sCekSenetKodu1, sCekSenetKodu2) VALUES     ( '" & sCekSenetTipi & "', " & lCekSenetNo & ", '" & sBankaKodu & "', " & lTutar & ", '" & dteVadeTarihi & "', '" & dteDuzenlemeTarihi & "', '" & sIl & "', '" & sSemt & "', '" & sOrjinalCekSenetNo & "', '" & sKarsiTarafCekSenetNo & "', " & nVerenID & ", " & bKendineAit & ", '" & sBorclusu & "', '" & sBorcluVergiDairesi & "', '" & sBorcluVergiNumarasi & "', '" & sBankaHesapNo & "', '" & sBankaSubeNo & "', " & nSonBordroSatirID & ", " & nSonCekSenetIslem & ", '" & sHareketTipi & "', '" & sNot & "', '" & sKullaniciAdi & "', '" & dteKayitTarihi & "', '" & sDovizCinsi1 & "', " & lDovizMiktari1 & ", " & lDovizKuru1 & ", '" & sDovizCinsi2 & "', " & lDovizMiktari2 & ", " & lDovizKuru2 & ", '" & sSonKullaniciAdi & "', '" & dteSonUpdateTarihi & "', '" & sCekSenetKodu1 & "', '" & sCekSenetKodu2 & "')")
        cmd.ExecuteNonQuery()
        cmd.CommandText = "SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT @@identity"
        nCekSenetID = cmd.ExecuteScalar
        Return nCekSenetID
        con.Close()
    End Function
    Private Sub tbCekSenet_kaydet_duzelt(ByVal nCekSenetID As Int64, ByVal sCekSenetTipi As String, ByVal lCekSenetNo As Int64, ByVal sBankaKodu As String, ByVal lTutar As Decimal, ByVal dteVadeTarihi As DateTime, ByVal dteDuzenlemeTarihi As DateTime, ByVal sIl As String, ByVal sSemt As String, ByVal sOrjinalCekSenetNo As String, ByVal sKarsiTarafCekSenetNo As String, ByVal nVerenID As Int64, ByVal bKendineAit As Integer, ByVal sBorclusu As String, ByVal sBorcluVergiDairesi As String, ByVal sBorcluVergiNumarasi As String, ByVal sBankaHesapNo As String, ByVal sBankaSubeNo As String, ByVal nSonBordroSatirID As Int64, ByVal nSonCekSenetIslem As Int64, ByVal sHareketTipi As String, ByVal sNot As String, ByVal sKullaniciAdi As String, ByVal dteKayitTarihi As DateTime, ByVal sDovizCinsi1 As String, ByVal lDovizMiktari1 As Decimal, ByVal lDovizKuru1 As Decimal, ByVal sDovizCinsi2 As String, ByVal lDovizMiktari2 As Decimal, ByVal lDovizKuru2 As Decimal, ByVal sSonKullaniciAdi As String, ByVal dteSonUpdateTarihi As DateTime, ByVal sCekSenetKodu1 As String, ByVal sCekSenetKodu2 As String)
        Dim con As New OleDb.OleDbConnection
        Dim cmd As New OleDb.OleDbCommand
        cmd.Connection = con
        con.ConnectionString = connection
        If con.State = ConnectionState.Closed = True Then
            con.Open()
        End If
        cmd.CommandText = sorgu_query("SET DATEFORMAT DMY SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED UPDATE    tbCekSenet SET              lCekSenetNo = " & lCekSenetNo & ", sBankaKodu = '" & sBankaKodu & "', lTutar = " & lTutar & ", dteVadeTarihi = '" & dteVadeTarihi & "', dteDuzenlemeTarihi = '" & dteDuzenlemeTarihi & "', sIl = '" & sIl & "', sSemt = '" & sSemt & "', sOrjinalCekSenetNo = '" & sOrjinalCekSenetNo & "', sKarsiTarafCekSenetNo = '" & sKarsiTarafCekSenetNo & "', nVerenID = " & nVerenID & ", bKendineAit = " & bKendineAit & ", sBorclusu = '" & sBorclusu & "', sBorcluVergiDairesi = '" & sBorcluVergiDairesi & "', sBorcluVergiNumarasi = '" & sBorcluVergiNumarasi & "', sBankaHesapNo = '" & sBankaHesapNo & "', sBankaSubeNo = '" & sBankaSubeNo & "', nSonBordroSatirID = " & nSonBordroSatirID & ", nSonCekSenetIslem = " & nSonCekSenetIslem & ", sHareketTipi = '" & sHareketTipi & "', sNot = '" & sNot & "', sDovizCinsi1 = '" & sDovizCinsi1 & "', lDovizMiktari1 = " & lDovizMiktari1 & ", lDovizKuru1 = " & lDovizKuru1 & ", sDovizCinsi2 = '" & sDovizCinsi2 & "', lDovizMiktari2 = " & lDovizMiktari2 & ", lDovizKuru2 = " & lDovizKuru2 & ", sSonKullaniciAdi = '" & sSonKullaniciAdi & "', dteSonUpdateTarihi = '" & dteSonUpdateTarihi & "', sCekSenetKodu1 = '" & sCekSenetKodu1 & "', sCekSenetKodu2 = '" & sCekSenetKodu2 & "' Where nCekSenetID = " & nCekSenetID & "")
        cmd.ExecuteNonQuery()
        con.Close()
    End Sub
    Private Sub tbCekSenet_nSonCekSenetIslem_degistir(ByVal nCekSenetID As String)
        Dim con As New OleDb.OleDbConnection
        Dim cmd As New OleDb.OleDbCommand
        cmd.Connection = con
        con.ConnectionString = connection
        If con.State = ConnectionState.Closed = True Then
            con.Open()
        End If
        cmd.CommandText = sorgu_query("SET DATEFORMAT DMY SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED ")
        cmd.ExecuteNonQuery()
        'cmd.CommandText = sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED UPDATE tbCekSenet SET nSonCekSenetIslem = (SELECT TOP 1 nCekSenetIslem FROM tbCekSenetBordro WHERE nCekSenetID = tbCekSenet.nCekSenetID ORDER BY nBordroSatirID) WHERE (nCekSenetID = " & nCekSenetID & ")")
        'cmd.ExecuteNonQuery()
        cmd.CommandText = sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED UPDATE tbCekSenet SET nSonBordroSatirID = (SELECT TOP 1 ISNULL(nBordroSatirID,1) FROM tbCekSenetBordro WHERE nCekSenetID = tbCekSenet.nCekSenetID ORDER BY nBordroSatirID DESC),nSonCekSenetIslem = (SELECT TOP 1 ISNULL(nCekSenetIslem,1) FROM tbCekSenetBordro WHERE nCekSenetID = tbCekSenet.nCekSenetID ORDER BY nBordroSatirID DESC) WHERE (nCekSenetID = " & nCekSenetID & ") AND ((SELECT TOP 1 ISNULL(nCekSenetIslem , 0) FROM tbCekSenetBordro WHERE nCekSenetID = tbCekSenet.nCekSenetID ORDER BY nBordroSatirID DESC) <> 0)")
        cmd.ExecuteNonQuery()
        con.Close()
    End Sub
    Private Sub tbCekSenetBordro_kaydet_sil(ByVal nBordroSatirID As String, ByVal nCekSenetID As String, ByVal nCariHareketID As String)
        Dim con As New OleDb.OleDbConnection
        Dim cmd As New OleDb.OleDbCommand
        cmd.Connection = con
        con.ConnectionString = connection
        If con.State = ConnectionState.Closed = True Then
            con.Open()
        End If
        cmd.CommandText = sorgu_query("SET DATEFORMAT DMY SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED ")
        cmd.ExecuteNonQuery()
        cmd.CommandText = sorgu_query("set implicit_transactions on")
        cmd.ExecuteNonQuery()
        Try
            cmd.CommandText = sorgu_query("delete from tbCekSenetBordro where nBordroSatirID = " & nBordroSatirID & "")
            cmd.ExecuteNonQuery()
            'cmd.CommandText = sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED UPDATE tbCekSenet SET nSonCekSenetIslem = (SELECT TOP 1 nCekSenetIslem FROM tbCekSenetBordro WHERE nCekSenetID = tbCekSenet.nCekSenetID ORDER BY nBordroSatirID) WHERE (nCekSenetID = " & nCekSenetID & ")")
            'cmd.ExecuteNonQuery()
            cmd.CommandText = sorgu_query("delete from tbCekSenet where nCekSenetID = " & nCekSenetID & "")
            cmd.ExecuteNonQuery()
            If nCariHareketID > 0 Then
                cmd.CommandText = sorgu_query("delete from tbFirmaHareketi where nHareketID =" & nCariHareketID & "")
                cmd.ExecuteNonQuery()
            End If
            cmd.CommandText = sorgu_query("delete from tbFirmaBordroDetay where nHareketID =" & nCariHareketID & "")
            cmd.ExecuteNonQuery()
            cmd.CommandText = sorgu_query("IF @@TRANCOUNT > 0 COMMIT TRAN")
            cmd.ExecuteNonQuery()
        Catch ex As Exception
            cmd.CommandText = sorgu_query("IF @@TRANCOUNT > 0 COMMIT TRAN")
            cmd.ExecuteNonQuery()
            XtraMessageBox.Show(Sorgu_sDil("Ýþlem Hatasý Lütfen Tekrar Deneyiniz...!", sDil), Sorgu_sDil("Dikkat", sDil), MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End Try
        nBordroSatirID_degistir_otomatik()
        nCekSenetID_degistir_otomatik()
        con.Close()
    End Sub
    Private Sub tbCekSenetBordro_odeme_kaydet_sil(ByVal nBordroSatirID As String, ByVal nSonBordroSatirID As String, ByVal nCekSenetID As String, ByVal nCariHareketID As String)
        Dim con As New OleDb.OleDbConnection
        Dim cmd As New OleDb.OleDbCommand
        cmd.Connection = con
        con.ConnectionString = connection
        If con.State = ConnectionState.Closed = True Then
            con.Open()
        End If
        cmd.CommandText = sorgu_query("SET DATEFORMAT DMY SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED ")
        cmd.ExecuteNonQuery()
        cmd.CommandText = sorgu_query("set implicit_transactions on")
        cmd.ExecuteNonQuery()
        Try
            cmd.CommandText = sorgu_query("delete from tbCekSenetBordro where nBordroSatirID = " & nBordroSatirID & "")
            cmd.ExecuteNonQuery()
            cmd.CommandText = sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED UPDATE tbCekSenet SET nSonCekSenetIslem = (SELECT TOP 1 nCekSenetIslem FROM tbCekSenetBordro WHERE nCekSenetID = tbCekSenet.nCekSenetID ORDER BY nBordroSatirID DESC) WHERE (nCekSenetID = " & nCekSenetID & ") AND ((SELECT TOP 1 ISNULL(nCekSenetIslem , 0) FROM tbCekSenetBordro WHERE nCekSenetID = tbCekSenet.nCekSenetID ORDER BY nBordroSatirID DESC) <> 0)")
            cmd.ExecuteNonQuery()
            cmd.CommandText = sorgu_query("delete from tbFirmaHareketi where nHareketID =" & nCariHareketID & "")
            cmd.ExecuteNonQuery()
            cmd.CommandText = sorgu_query("delete from tbFirmaBordroDetay where nHareketID =" & nCariHareketID & "")
            cmd.ExecuteNonQuery()
            cmd.CommandText = sorgu_query("IF @@TRANCOUNT > 0 COMMIT TRAN")
            cmd.ExecuteNonQuery()
            nCekSenetID_Odeme_degistir(nCekSenetID, nSonBordroSatirID, 20)
        Catch ex As Exception
            cmd.CommandText = sorgu_query("IF @@TRANCOUNT > 0 COMMIT TRAN")
            cmd.ExecuteNonQuery()
            XtraMessageBox.Show(Sorgu_sDil("Ýþlem Hatasý Lütfen Tekrar Deneyiniz...!", sDil), Sorgu_sDil("Dikkat", sDil), MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End Try
        nBordroSatirID_degistir_otomatik()
        nCekSenetID_degistir_otomatik()
        con.Close()
    End Sub
    Private Sub tbCekSenetBordro_protesto_kaydet_sil(ByVal nBordroSatirID As String, ByVal nSonBordroSatirID As String, ByVal nCekSenetID As String, ByVal nCariHareketID As String)
        Dim con As New OleDb.OleDbConnection
        Dim cmd As New OleDb.OleDbCommand
        cmd.Connection = con
        con.ConnectionString = connection
        If con.State = ConnectionState.Closed = True Then
            con.Open()
        End If
        cmd.CommandText = sorgu_query("SET DATEFORMAT DMY SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED ")
        cmd.ExecuteNonQuery()
        cmd.CommandText = sorgu_query("set implicit_transactions on")
        cmd.ExecuteNonQuery()
        Try
            cmd.CommandText = sorgu_query("delete from tbCekSenetBordro where nBordroSatirID = " & nBordroSatirID & "")
            cmd.ExecuteNonQuery()
            cmd.CommandText = sorgu_query("delete from tbFirmaHareketi where nHareketID =" & nCariHareketID & "")
            cmd.ExecuteNonQuery()
            cmd.CommandText = sorgu_query("delete from tbFirmaBordroDetay where nHareketID =" & nCariHareketID & "")
            cmd.ExecuteNonQuery()
            cmd.CommandText = sorgu_query("IF @@TRANCOUNT > 0 COMMIT TRAN")
            cmd.ExecuteNonQuery()
            nCekSenetID_Odeme_degistir(nCekSenetID, nSonBordroSatirID, 1)
        Catch ex As Exception
            cmd.CommandText = sorgu_query("IF @@TRANCOUNT > 0 COMMIT TRAN")
            cmd.ExecuteNonQuery()
            XtraMessageBox.Show(Sorgu_sDil("Ýþlem Hatasý Lütfen Tekrar Deneyiniz...!", sDil), Sorgu_sDil("Dikkat", sDil), MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End Try
        nBordroSatirID_degistir_otomatik()
        nCekSenetID_degistir_otomatik()
        con.Close()
    End Sub
    Private Sub tbCekSenetBordro_bankadantahsil_kaydet_sil(ByVal nBordroSatirID As String, ByVal nSonBordroSatirID As String, ByVal nCekSenetID As String, ByVal nCariHareketID As String)
        Dim con As New OleDb.OleDbConnection
        Dim cmd As New OleDb.OleDbCommand
        cmd.Connection = con
        con.ConnectionString = connection
        If con.State = ConnectionState.Closed = True Then
            con.Open()
        End If
        cmd.CommandText = sorgu_query("SET DATEFORMAT DMY SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED ")
        cmd.ExecuteNonQuery()
        cmd.CommandText = sorgu_query("set implicit_transactions on")
        cmd.ExecuteNonQuery()
        Try
            cmd.CommandText = sorgu_query("delete from tbCekSenetBordro where nBordroSatirID = " & nBordroSatirID & "")
            cmd.ExecuteNonQuery()
            cmd.CommandText = sorgu_query("delete from tbFirmaHareketi where nHareketID =" & nCariHareketID & "")
            cmd.ExecuteNonQuery()
            cmd.CommandText = sorgu_query("delete from tbFirmaBordroDetay where nHareketID =" & nCariHareketID & "")
            cmd.ExecuteNonQuery()
            cmd.CommandText = sorgu_query("IF @@TRANCOUNT > 0 COMMIT TRAN")
            cmd.ExecuteNonQuery()
            nCekSenetID_Odeme_degistir(nCekSenetID, nSonBordroSatirID, 3)
        Catch ex As Exception
            cmd.CommandText = sorgu_query("IF @@TRANCOUNT > 0 COMMIT TRAN")
            cmd.ExecuteNonQuery()
            XtraMessageBox.Show(Sorgu_sDil("Ýþlem Hatasý Lütfen Tekrar Deneyiniz...!", sDil), Sorgu_sDil("Dikkat", sDil), MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End Try
        nBordroSatirID_degistir_otomatik()
        nCekSenetID_degistir_otomatik()
        con.Close()
    End Sub
    Private Sub tbCekSenetBordro_takas_kaydet_sil(ByVal nBordroSatirID As String, ByVal nSonBordroSatirID As String, ByVal nCekSenetID As String, ByVal nCariHareketID As String, ByVal nSonCekSenetIslem As Integer)
        Dim con As New OleDb.OleDbConnection
        Dim cmd As New OleDb.OleDbCommand
        cmd.Connection = con
        con.ConnectionString = connection
        If con.State = ConnectionState.Closed = True Then
            con.Open()
        End If
        cmd.CommandText = sorgu_query("SET DATEFORMAT DMY SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED ")
        cmd.ExecuteNonQuery()
        cmd.CommandText = sorgu_query("set implicit_transactions on")
        cmd.ExecuteNonQuery()
        Try
            cmd.CommandText = sorgu_query("delete from tbCekSenetBordro where nBordroSatirID = " & nBordroSatirID & "")
            cmd.ExecuteNonQuery()
            'cmd.CommandText = sorgu_query("delete from tbFirmaHareketi where nHareketID =" & nCariHareketID & "")
            'cmd.ExecuteNonQuery()
            cmd.CommandText = sorgu_query("IF @@TRANCOUNT > 0 COMMIT TRAN")
            cmd.ExecuteNonQuery()
            nCekSenetID_Odeme_degistir(nCekSenetID, nSonBordroSatirID, nSonCekSenetIslem)
        Catch ex As Exception
            cmd.CommandText = sorgu_query("IF @@TRANCOUNT > 0 COMMIT TRAN")
            cmd.ExecuteNonQuery()
            XtraMessageBox.Show(Sorgu_sDil("Ýþlem Hatasý Lütfen Tekrar Deneyiniz...!", sDil), Sorgu_sDil("Dikkat", sDil), MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End Try
        nBordroSatirID_degistir_otomatik()
        nCekSenetID_degistir_otomatik()
        con.Close()
    End Sub
    Private Sub tbCekSenetBordro_bankadanodeme_kaydet_sil(ByVal nBordroSatirID As String, ByVal nSonBordroSatirID As String, ByVal nCekSenetID As String, ByVal nCariHareketID As String)
        Dim con As New OleDb.OleDbConnection
        Dim cmd As New OleDb.OleDbCommand
        cmd.Connection = con
        con.ConnectionString = connection
        If con.State = ConnectionState.Closed = True Then
            con.Open()
        End If
        cmd.CommandText = sorgu_query("SET DATEFORMAT DMY SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED ")
        cmd.ExecuteNonQuery()
        cmd.CommandText = sorgu_query("set implicit_transactions on")
        cmd.ExecuteNonQuery()
        Try
            cmd.CommandText = sorgu_query("delete from tbCekSenetBordro where nBordroSatirID = " & nBordroSatirID & "")
            cmd.ExecuteNonQuery()
            cmd.CommandText = sorgu_query("delete from tbNakitKasa where nKasaIslemID =" & nCariHareketID & "")
            cmd.ExecuteNonQuery()
            cmd.CommandText = sorgu_query("IF @@TRANCOUNT > 0 COMMIT TRAN")
            cmd.ExecuteNonQuery()
            nCekSenetID_Odeme_degistir(nCekSenetID, nSonBordroSatirID, 1)
        Catch ex As Exception
            cmd.CommandText = sorgu_query("IF @@TRANCOUNT > 0 COMMIT TRAN")
            cmd.ExecuteNonQuery()
            XtraMessageBox.Show(Sorgu_sDil("Ýþlem Hatasý Lütfen Tekrar Deneyiniz...!", sDil), Sorgu_sDil("Dikkat", sDil), MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End Try
        nBordroSatirID_degistir_otomatik()
        nCekSenetID_degistir_otomatik()
        con.Close()
    End Sub
    Private Sub tbCekSenetBordro_cuzdandantahsil_kaydet_sil(ByVal nBordroSatirID As String, ByVal nSonBordroSatirID As String, ByVal nCekSenetID As String, ByVal nCariHareketID As String)
        Dim con As New OleDb.OleDbConnection
        Dim cmd As New OleDb.OleDbCommand
        cmd.Connection = con
        con.ConnectionString = connection
        If con.State = ConnectionState.Closed = True Then
            con.Open()
        End If
        cmd.CommandText = sorgu_query("SET DATEFORMAT DMY SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED ")
        cmd.ExecuteNonQuery()
        cmd.CommandText = sorgu_query("set implicit_transactions on")
        cmd.ExecuteNonQuery()
        Try
            cmd.CommandText = sorgu_query("delete from tbCekSenetBordro where nBordroSatirID = " & nBordroSatirID & "")
            cmd.ExecuteNonQuery()
            cmd.CommandText = sorgu_query("delete from tbNakitKasa where nKasaIslemID =" & nCariHareketID & "")
            cmd.ExecuteNonQuery()
            cmd.CommandText = sorgu_query("IF @@TRANCOUNT > 0 COMMIT TRAN")
            cmd.ExecuteNonQuery()
            nCekSenetID_Odeme_degistir(nCekSenetID, nSonBordroSatirID, 1)
        Catch ex As Exception
            cmd.CommandText = sorgu_query("IF @@TRANCOUNT > 0 COMMIT TRAN")
            cmd.ExecuteNonQuery()
            XtraMessageBox.Show(Sorgu_sDil("Ýþlem Hatasý Lütfen Tekrar Deneyiniz...!", sDil), Sorgu_sDil("Dikkat", sDil), MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End Try
        nBordroSatirID_degistir_otomatik()
        nCekSenetID_degistir_otomatik()
        con.Close()
    End Sub
    Private Sub tbCekSenetBordro_parcalitahsilat_kaydet_sil(ByVal nBordroSatirID As String, ByVal nSonBordroSatirID As String, ByVal nCekSenetID As String, ByVal nCariHareketID As String)
        Dim con As New OleDb.OleDbConnection
        Dim cmd As New OleDb.OleDbCommand
        cmd.Connection = con
        con.ConnectionString = connection
        If con.State = ConnectionState.Closed = True Then
            con.Open()
        End If
        cmd.CommandText = sorgu_query("SET DATEFORMAT DMY SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED ")
        cmd.ExecuteNonQuery()
        cmd.CommandText = sorgu_query("set implicit_transactions on")
        cmd.ExecuteNonQuery()
        Try
            cmd.CommandText = sorgu_query("delete from tbCekSenetBordro where nBordroSatirID = " & nBordroSatirID & "")
            cmd.ExecuteNonQuery()
            cmd.CommandText = sorgu_query("delete from tbNakitKasa where nKasaIslemID =" & nCariHareketID & "")
            cmd.ExecuteNonQuery()
            cmd.CommandText = sorgu_query("IF @@TRANCOUNT > 0 COMMIT TRAN")
            cmd.ExecuteNonQuery()
            nCekSenetID_Odeme_degistir(nCekSenetID, nSonBordroSatirID, 1)
        Catch ex As Exception
            cmd.CommandText = sorgu_query("IF @@TRANCOUNT > 0 COMMIT TRAN")
            cmd.ExecuteNonQuery()
            XtraMessageBox.Show(Sorgu_sDil("Ýþlem Hatasý Lütfen Tekrar Deneyiniz...!", sDil), Sorgu_sDil("Dikkat", sDil), MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End Try
        nBordroSatirID_degistir_otomatik()
        nCekSenetID_degistir_otomatik()
        con.Close()
    End Sub
    Private Sub tbCekSenetBordro_sil(ByVal sCekSenetTipi As String, ByVal nCekSenetIslem As String, ByVal nFirmaID As String, ByVal dteBordroTarihi As DateTime, ByVal lBordroNo As Int64, ByVal sHareketTipi As String)
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
            cmd.CommandText = sorgu_query("Delete tbFirmaHareketi where nHareketID in ( select nCariHareketID from tbCekSenetBordro , tbCekSenet where nCariHareketID is not null and tbCekSenet.nCekSenetID = tbCekSenetBordro.nCekSenetID and tbCekSenetBordro.nFirmaID = " & nFirmaID & " and tbCekSenetBordro.dteBordroTarihi = '" & dteBordroTarihi & "' and tbCekSenetBordro.lBordroNo = " & lBordroNo & " and tbCekSenetBordro.nCekSenetIslem = " & nCekSenetIslem & " and tbCekSenet.sCekSenetTipi = '" & sCekSenetTipi & "' )")
            cmd.ExecuteNonQuery()
            cmd.CommandText = sorgu_query("Delete tbFirmaHareketi where nHareketID in ( select nBorcluCariHareketID from tbCekSenetBordro , tbCekSenet where nBorcluCariHareketID is not null and tbCekSenet.nCekSenetID = tbCekSenetBordro.nCekSenetID and tbCekSenetBordro.nFirmaID = " & nFirmaID & " and tbCekSenetBordro.dteBordroTarihi = '" & dteBordroTarihi & "' and tbCekSenetBordro.lBordroNo = " & lBordroNo & " and tbCekSenetBordro.nCekSenetIslem = " & nCekSenetIslem & " and tbCekSenet.sCekSenetTipi = '" & sCekSenetTipi & "' )")
            cmd.ExecuteNonQuery()
            cmd.CommandText = sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED UPDATE tbCekSenet Set nSonCekSenetIslem = 99999 from tbCekSenetBordro , tbCekSenet where tbCekSenet.nCekSenetID = tbCekSenetBordro.nCekSenetID and tbCekSenetBordro.nFirmaID = " & nFirmaID & " and tbCekSenetBordro.dteBordroTarihi = '" & dteBordroTarihi & "' and tbCekSenetBordro.lBordroNo = " & lBordroNo & " and tbCekSenetBordro.nCekSenetIslem =" & nCekSenetIslem & " and tbCekSenet.sCekSenetTipi = '" & sCekSenetTipi & "'")
            cmd.ExecuteNonQuery()
            cmd.CommandText = sorgu_query("delete tbCekSenetBordro from tbCekSenetBordro , tbCekSenet where tbCekSenet.nCekSenetID = tbCekSenetBordro.nCekSenetID and tbCekSenetBordro.nFirmaID = " & nFirmaID & " and tbCekSenetBordro.dteBordroTarihi = '" & dteBordroTarihi & "' and tbCekSenetBordro.lBordroNo = " & lBordroNo & " and tbCekSenetBordro.nCekSenetIslem = " & nCekSenetIslem & " and tbCekSenet.sCekSenetTipi = '" & sCekSenetTipi & "' ")
            cmd.ExecuteNonQuery()
            cmd.CommandText = sorgu_query("delete tbCekSenet where nSonCekSenetIslem = 99999")
            cmd.ExecuteNonQuery()
            cmd.CommandText = sorgu_query("IF @@TRANCOUNT > 0 COMMIT TRAN")
            cmd.ExecuteNonQuery()
        Catch ex As Exception
            cmd.CommandText = sorgu_query("IF @@TRANCOUNT > 0 COMMIT TRAN")
            cmd.ExecuteNonQuery()
            XtraMessageBox.Show(Sorgu_sDil("Ýþlem Hatasý Lütfen Tekrar Deneyiniz...!", sDil), Sorgu_sDil("Dikkat", sDil), MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End Try
        con.Close()
        nBordroSatirID_degistir_otomatik()
        nCekSenetID_degistir_otomatik()
    End Sub
    Private Sub tbCekSenetBordro_Odeme_sil(ByVal sCekSenetTipi As String, ByVal nCekSenetIslem As String, ByVal nFirmaID As String, ByVal dteBordroTarihi As DateTime, ByVal lBordroNo As Int64, ByVal sHareketTipi As String, Optional ByVal nHareket As Boolean = False, Optional ByVal nKasaIslem As Boolean = False)
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
            If nHareket = True Then
                cmd.CommandText = sorgu_query("Delete tbFirmaHareketi where nHareketID in ( select nCariHareketID from tbCekSenetBordro , tbCekSenet where nCariHareketID is not null and tbCekSenet.nCekSenetID = tbCekSenetBordro.nCekSenetID and tbCekSenetBordro.nFirmaID = " & nFirmaID & " and tbCekSenetBordro.dteBordroTarihi = '" & dteBordroTarihi & "' and tbCekSenetBordro.lBordroNo = " & lBordroNo & " and tbCekSenetBordro.nCekSenetIslem = " & nCekSenetIslem & " and tbCekSenet.sCekSenetTipi = '" & sCekSenetTipi & "' )")
                cmd.ExecuteNonQuery()
                cmd.CommandText = sorgu_query("Delete tbFirmaBordroDetay where nHareketID in ( select nCariHareketID from tbCekSenetBordro , tbCekSenet where nCariHareketID is not null and tbCekSenet.nCekSenetID = tbCekSenetBordro.nCekSenetID and tbCekSenetBordro.nFirmaID = " & nFirmaID & " and tbCekSenetBordro.dteBordroTarihi = '" & dteBordroTarihi & "' and tbCekSenetBordro.lBordroNo = " & lBordroNo & " and tbCekSenetBordro.nCekSenetIslem = " & nCekSenetIslem & " and tbCekSenet.sCekSenetTipi = '" & sCekSenetTipi & "' )")
                cmd.ExecuteNonQuery()
            Else
                cmd.CommandText = sorgu_query("Delete tbFirmaHareketi where nHareketID in ( select nBorcluCariHareketID from tbCekSenetBordro , tbCekSenet where nBorcluCariHareketID is not null and tbCekSenet.nCekSenetID = tbCekSenetBordro.nCekSenetID and tbCekSenetBordro.nFirmaID = " & nFirmaID & " and tbCekSenetBordro.dteBordroTarihi = '" & dteBordroTarihi & "' and tbCekSenetBordro.lBordroNo = " & lBordroNo & " and tbCekSenetBordro.nCekSenetIslem = " & nCekSenetIslem & " and tbCekSenet.sCekSenetTipi = '" & sCekSenetTipi & "' )")
                cmd.ExecuteNonQuery()
                cmd.CommandText = sorgu_query("Delete tbFirmaBordroDetay where nHareketID in ( select nBorcluCariHareketID from tbCekSenetBordro , tbCekSenet where nBorcluCariHareketID is not null and tbCekSenet.nCekSenetID = tbCekSenetBordro.nCekSenetID and tbCekSenetBordro.nFirmaID = " & nFirmaID & " and tbCekSenetBordro.dteBordroTarihi = '" & dteBordroTarihi & "' and tbCekSenetBordro.lBordroNo = " & lBordroNo & " and tbCekSenetBordro.nCekSenetIslem = " & nCekSenetIslem & " and tbCekSenet.sCekSenetTipi = '" & sCekSenetTipi & "' )")
                cmd.ExecuteNonQuery()
            End If
            If nKasaIslem = True Then
                cmd.CommandText = sorgu_query("Delete tbNakitKasa where nKasaIslemID in ( select nKasaIslemID from tbCekSenetBordro , tbCekSenet where nKasaIslemID is not null and tbCekSenet.nCekSenetID = tbCekSenetBordro.nCekSenetID and tbCekSenetBordro.nFirmaID = " & nFirmaID & " and tbCekSenetBordro.dteBordroTarihi = '" & dteBordroTarihi & "' and tbCekSenetBordro.lBordroNo = " & lBordroNo & " and tbCekSenetBordro.nCekSenetIslem = " & nCekSenetIslem & " and tbCekSenet.sCekSenetTipi = '" & sCekSenetTipi & "' )")
                cmd.ExecuteNonQuery()
            End If
            cmd.CommandText = sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED UPDATE tbCekSenet Set nSonBordroSatirID=nOncekiBordroSatirID, nSonCekSenetIslem = nOncekiCekSenetIslem from tbCekSenetBordro , tbCekSenet where tbCekSenet.nCekSenetID = tbCekSenetBordro.nCekSenetID and tbCekSenetBordro.nFirmaID = " & nFirmaID & " and tbCekSenetBordro.dteBordroTarihi = '" & dteBordroTarihi & "' and tbCekSenetBordro.lBordroNo = " & lBordroNo & " and tbCekSenetBordro.nCekSenetIslem =" & nCekSenetIslem & " and tbCekSenet.sCekSenetTipi = '" & sCekSenetTipi & "'")
            cmd.ExecuteNonQuery()
            cmd.CommandText = sorgu_query("delete tbCekSenetBordro from tbCekSenetBordro , tbCekSenet where tbCekSenet.nCekSenetID = tbCekSenetBordro.nCekSenetID and tbCekSenetBordro.nFirmaID = " & nFirmaID & " and tbCekSenetBordro.dteBordroTarihi = '" & dteBordroTarihi & "' and tbCekSenetBordro.lBordroNo = " & lBordroNo & " and tbCekSenetBordro.nCekSenetIslem = " & nCekSenetIslem & " and tbCekSenet.sCekSenetTipi = '" & sCekSenetTipi & "' ")
            cmd.ExecuteNonQuery()
            cmd.CommandText = sorgu_query("IF @@TRANCOUNT > 0 COMMIT TRAN")
            cmd.ExecuteNonQuery()
        Catch ex As Exception
            cmd.CommandText = sorgu_query("IF @@TRANCOUNT > 0 COMMIT TRAN")
            cmd.ExecuteNonQuery()
            XtraMessageBox.Show(Sorgu_sDil("Ýþlem Hatasý Lütfen Tekrar Deneyiniz...!", sDil), Sorgu_sDil("Dikkat", sDil), MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End Try
        con.Close()
        nBordroSatirID_degistir_otomatik()
        nCekSenetID_degistir_otomatik()
    End Sub
    Private Sub tbMuhasebeFisi_Aciklamasi_kaydet_yeni(ByVal dteFisTarihi As DateTime, ByVal sMuhFisTipi As String, ByVal lFisno As Int64, ByVal sAciklama1 As String, ByVal sAciklama2 As String, ByVal sAciklama3 As String, ByVal sAciklama4 As String, ByVal sAciklama5 As String)
        Dim con As New OleDb.OleDbConnection
        Dim cmd As New OleDb.OleDbCommand
        cmd.Connection = con
        con.ConnectionString = connection
        If con.State = ConnectionState.Closed = True Then
            con.Open()
        End If
        cmd.CommandText = sorgu_query("SET DATEFORMAT DMY  INSERT INTO tbMuhasebeFisiAciklamasi (dteFisTarihi, sMuhFisTipi, lFisno, sAciklama1, sAciklama2, sAciklama3, sAciklama4, sAciklama5) VALUES     ('" & dteFisTarihi & "', '" & sMuhFisTipi & "', " & lFisno & ", '" & sAciklama1 & "', '" & sAciklama2 & "', '" & sAciklama3 & "', '" & sAciklama4 & "', '" & sAciklama5 & "')")
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
        'cmd.CommandText = sorgu_query("SET DATEFORMAT DMY  UPDATE    tbFirmaHareketi SET              nFirmaID = '" & nFirmaID & "', dteIslemTarihi = '" & dteIslemTarihi & "', dteValorTarihi = '" & dteValorTarihi & "', sCariIslem = '" & sCariIslem & "', sAciklama = N'" & sAciklama & "', lBorcTutar = " & lBorcTutar & ", lAlacakTutar = " & lAlacakTutar & ", sEvrakNo = '" & sEvrakNo & "', lVadeFarki = " & lVadeFarki & ", sHangiUygulama = '" & sHangiUygulama & "', sHareketTipi = '" & sHareketTipi & "', sDovizCinsi1 = '" & sDovizCinsi1 & "', lDovizMiktari1 = " & lDovizMiktari1 & ", lDovizKuru1 = " & lDovizKuru1 & ", sDovizCinsi2 = '" & sDovizCinsi2 & "', lDovizMiktari2 = " & lDovizMiktari2 & ", lDovizKuru2 = " & lDovizKuru2 & ", sSonKullaniciAdi = '" & sSonKullaniciAdi & "', dteSonUpdateTarihi = '" & dteSonUpdateTarihi & "'  WHERE     (nHareketID = " & nHareketID & ")")
        If Trim(sDovizCinsi2) <> "" Then
            If lDovizKuru2 = 0 Then
                lDovizKuru2 = 1
            End If
            sDovizCinsi1 = sDovizCinsi2
            lDovizKuru1 = lDovizKuru2
            lDovizMiktari1 = lDovizMiktari2
        End If
        cmd.CommandText = sorgu_query("SET DATEFORMAT DMY  UPDATE    tbFirmaHareketi SET              nFirmaID = '" & nFirmaID & "', dteIslemTarihi = '" & dteIslemTarihi & "', dteValorTarihi = '" & dteValorTarihi & "', sCariIslem = '" & sCariIslem & "', sAciklama = N'" & sAciklama & "', lBorcTutar = " & lBorcTutar & ", lAlacakTutar = " & lAlacakTutar & ", sEvrakNo = '" & sEvrakNo & "', lVadeFarki = " & lVadeFarki & ", sHareketTipi = '" & sHareketTipi & "', sDovizCinsi1 = '" & sDovizCinsi1 & "', lDovizMiktari1 = " & lDovizMiktari1 & ", lDovizKuru1 = " & lDovizKuru1 & ", sDovizCinsi2 = '" & sDovizCinsi2 & "', lDovizMiktari2 = " & lDovizMiktari2 & ", lDovizKuru2 = " & lDovizKuru2 & ", sSonKullaniciAdi = '" & sSonKullaniciAdi & "', dteSonUpdateTarihi = '" & dteSonUpdateTarihi & "'  WHERE     (nHareketID = " & nHareketID & ")")
        cmd.ExecuteNonQuery()
        cmd.CommandText = sorgu_query("SET DATEFORMAT DMY  UPDATE    tbFirmaBordroDetay SET              nFirmaID = '" & nFirmaID & "', dteIslemTarihi = '" & dteIslemTarihi & "', dteValorTarihi = '" & dteValorTarihi & "', sCariIslem = '" & sCariIslem & "', sAciklama = N'" & sAciklama & "', lBorcTutar = " & lBorcTutar & ", lAlacakTutar = " & lAlacakTutar & ", sEvrakNo = '" & sEvrakNo & "', lVadeFarki = " & lVadeFarki & ", sHareketTipi = '" & sHareketTipi & "', sDovizCinsi1 = '" & sDovizCinsi1 & "', lDovizMiktari1 = " & lDovizMiktari1 & ", lDovizKuru1 = " & lDovizKuru1 & ", sDovizCinsi2 = '" & sDovizCinsi2 & "', lDovizMiktari2 = " & lDovizMiktari2 & ", lDovizKuru2 = " & lDovizKuru2 & ", sSonKullaniciAdi = '" & sSonKullaniciAdi & "', dteSonUpdateTarihi = '" & dteSonUpdateTarihi & "'  WHERE     (nHareketID = " & nHareketID & ")")
        cmd.ExecuteNonQuery()
        con.Close()
    End Sub
    Private Sub tbFirmaHareketi_DovizCinsi_kaydet_duzelt(ByVal nCekSenetID As Int64, ByVal sDovizCinsi1 As String, ByVal lDovizMiktari1 As Decimal, ByVal lDovizKuru1 As Decimal, ByVal sDovizCinsi2 As String, ByVal lDovizMiktari2 As Decimal, ByVal lDovizKuru2 As Decimal, ByVal sSonKullaniciAdi As String, ByVal dteSonUpdateTarihi As DateTime)
        Dim con As New OleDb.OleDbConnection
        Dim cmd As New OleDb.OleDbCommand
        cmd.Connection = con
        con.ConnectionString = connection
        If con.State = ConnectionState.Closed = True Then
            con.Open()
        End If
        'cmd.CommandText = sorgu_query("SET DATEFORMAT DMY  UPDATE    tbFirmaHareketi SET              nFirmaID = '" & nFirmaID & "', dteIslemTarihi = '" & dteIslemTarihi & "', dteValorTarihi = '" & dteValorTarihi & "', sCariIslem = '" & sCariIslem & "', sAciklama = N'" & sAciklama & "', lBorcTutar = " & lBorcTutar & ", lAlacakTutar = " & lAlacakTutar & ", sEvrakNo = '" & sEvrakNo & "', lVadeFarki = " & lVadeFarki & ", sHangiUygulama = '" & sHangiUygulama & "', sHareketTipi = '" & sHareketTipi & "', sDovizCinsi1 = '" & sDovizCinsi1 & "', lDovizMiktari1 = " & lDovizMiktari1 & ", lDovizKuru1 = " & lDovizKuru1 & ", sDovizCinsi2 = '" & sDovizCinsi2 & "', lDovizMiktari2 = " & lDovizMiktari2 & ", lDovizKuru2 = " & lDovizKuru2 & ", sSonKullaniciAdi = '" & sSonKullaniciAdi & "', dteSonUpdateTarihi = '" & dteSonUpdateTarihi & "'  WHERE     (nHareketID = " & nHareketID & ")")
        If Trim(sDovizCinsi2) <> "" Then
            If lDovizKuru2 = 0 Then
                lDovizKuru2 = 1
            End If
            sDovizCinsi1 = sDovizCinsi2
            lDovizKuru1 = lDovizKuru2
            lDovizMiktari1 = lDovizMiktari2
        End If
        'cmd.CommandText = sorgu_query("SET DATEFORMAT DMY  UPDATE    tbFirmaHareketi SET              sDovizCinsi1 = '" & sDovizCinsi1 & "', lDovizMiktari1 = " & lDovizMiktari1 & ", lDovizKuru1 = " & lDovizKuru1 & ", sDovizCinsi2 = '" & sDovizCinsi2 & "', lDovizMiktari2 = " & lDovizMiktari2 & ", lDovizKuru2 = " & lDovizKuru2 & ", sSonKullaniciAdi = '" & sSonKullaniciAdi & "', dteSonUpdateTarihi = '" & dteSonUpdateTarihi & "'  WHERE     (nHareketID IN (SELECT     nCariHareketID FROM         tbCekSenetBordro WHERE     (nCekSenetID = " & nCekSenetID & ") AND (nCekSenetIslem IN (1, 5)) AND (nCariHareketID > 0)))")
        cmd.CommandText = sorgu_query("SET DATEFORMAT DMY  UPDATE    tbFirmaHareketi SET              sDovizCinsi1 = '" & sDovizCinsi1 & "', lDovizMiktari1 = " & lDovizMiktari1 & ", lDovizKuru1 = " & lDovizKuru1 & ", sDovizCinsi2 = '" & sDovizCinsi2 & "', lDovizMiktari2 = " & lDovizMiktari2 & ", lDovizKuru2 = " & lDovizKuru2 & ", sSonKullaniciAdi = '" & sSonKullaniciAdi & "', dteSonUpdateTarihi = '" & dteSonUpdateTarihi & "'  WHERE     (nHareketID IN (SELECT     nCariHareketID FROM         tbCekSenetBordro WHERE     (nCekSenetID = " & nCekSenetID & ") AND (nCekSenetIslem IN (5)) AND (nCariHareketID > 0)))")
        cmd.ExecuteNonQuery()
        'cmd.CommandText = sorgu_query("SET DATEFORMAT DMY  UPDATE    tbFirmaBordroDetay SET              sDovizCinsi1 = '" & sDovizCinsi1 & "', lDovizMiktari1 = " & lDovizMiktari1 & ", lDovizKuru1 = " & lDovizKuru1 & ", sDovizCinsi2 = '" & sDovizCinsi2 & "', lDovizMiktari2 = " & lDovizMiktari2 & ", lDovizKuru2 = " & lDovizKuru2 & ", sSonKullaniciAdi = '" & sSonKullaniciAdi & "', dteSonUpdateTarihi = '" & dteSonUpdateTarihi & "'  WHERE     (nHareketID IN (SELECT     nCariHareketID FROM         tbCekSenetBordro WHERE     (nCekSenetID = " & nCekSenetID & ") AND (nCekSenetIslem IN (1, 5)) AND (nCariHareketID > 0)))")
        cmd.CommandText = sorgu_query("SET DATEFORMAT DMY  UPDATE    tbFirmaBordroDetay SET              sDovizCinsi1 = '" & sDovizCinsi1 & "', lDovizMiktari1 = " & lDovizMiktari1 & ", lDovizKuru1 = " & lDovizKuru1 & ", sDovizCinsi2 = '" & sDovizCinsi2 & "', lDovizMiktari2 = " & lDovizMiktari2 & ", lDovizKuru2 = " & lDovizKuru2 & ", sSonKullaniciAdi = '" & sSonKullaniciAdi & "', dteSonUpdateTarihi = '" & dteSonUpdateTarihi & "'  WHERE     (nHareketID IN (SELECT     nCariHareketID FROM         tbCekSenetBordro WHERE     (nCekSenetID = " & nCekSenetID & ") AND (nCekSenetIslem IN (5)) AND (nCariHareketID > 0)))")
        cmd.ExecuteNonQuery()
        con.Close()
    End Sub
    Private Function tbNakitKasa_kaydet_yeni(ByVal nKasaIslemID As Int64, ByVal sSube As String, ByVal dteIslemTarihi As DateTime, ByVal lTahsilTutar As Decimal, ByVal lTediyeTutar As Decimal, ByVal sAciklama As String, ByVal nCariHareketID As String, ByVal nFirmaID As Int64, ByVal nHesapID As Int64, ByVal sHangiUygulama As String, ByVal sHareketTipi As String, ByVal sKullaniciAdi As String, ByVal dteKayitTarihi As DateTime, ByVal bMuhasebeyeIslendimi As Byte, ByVal sMasrafYontemi As String, ByVal sDovizCinsi1 As String, ByVal lDovizMiktari1 As Decimal, ByVal lDovizKuru1 As Decimal, ByVal sDovizCinsi2 As String, ByVal lDovizMiktari2 As Decimal, ByVal lDovizKuru2 As Decimal, ByVal sSonKullaniciAdi As String, ByVal dteSonUpdateTarihi As DateTime) As Int64
        Dim con As New OleDb.OleDbConnection
        Dim cmd As New OleDb.OleDbCommand
        cmd.Connection = con
        con.ConnectionString = connection
        If con.State = ConnectionState.Closed = True Then
            con.Open()
        End If
        nCariHareketID = "NULL"
        cmd.CommandText = sorgu_query("SET DATEFORMAT DMY SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED INSERT INTO tbNakitKasa ( sSube, dteIslemTarihi, lTahsilTutar, lTediyeTutar, sAciklama, nCariHareketID, nFirmaID, nHesapID, sHangiUygulama, sHareketTipi, sKullaniciAdi, dteKayitTarihi, bMuhasebeyeIslendimi, sMasrafYontemi, sDovizCinsi1, lDovizMiktari1, lDovizKuru1, sDovizCinsi2, lDovizMiktari2, lDovizKuru2, sSonKullaniciAdi, dteSonUpdateTarihi) VALUES     ( '" & sSube & "', '" & dteIslemTarihi & "', " & lTahsilTutar & ", " & lTediyeTutar & ", N'" & sAciklama & "', " & nCariHareketID & ", " & nFirmaID & ", " & nHesapID & ", '" & sHangiUygulama & "', '" & sHareketTipi & "', '" & sKullaniciAdi & "', '" & dteKayitTarihi & "', " & bMuhasebeyeIslendimi & ", '" & sMasrafYontemi & "', '" & sDovizCinsi1 & "', " & lDovizMiktari1 & ", " & lDovizKuru1 & ", '" & sDovizCinsi2 & "', " & lDovizMiktari2 & ", " & lDovizKuru2 & ", '" & sSonKullaniciAdi & "', '" & dteSonUpdateTarihi & "')")
        cmd.ExecuteNonQuery()
        cmd.CommandText = "SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT @@identity"
        nKasaIslemID = cmd.ExecuteScalar
        Return nKasaIslemID
        con.Close()
    End Function
    Private Sub tbNakitKasa_kaydet_duzelt(ByVal nKasaIslemID As Int64, ByVal sSube As String, ByVal dteIslemTarihi As DateTime, ByVal lTahsilTutar As Decimal, ByVal lTediyeTutar As Decimal, ByVal sAciklama As String, ByVal nCariHareketID As String, ByVal nFirmaID As Int64, ByVal nHesapID As Int64, ByVal sHangiUygulama As String, ByVal sHareketTipi As String, ByVal sKullaniciAdi As String, ByVal dteKayitTarihi As DateTime, ByVal bMuhasebeyeIslendimi As Byte, ByVal sMasrafYontemi As String, ByVal sDovizCinsi1 As String, ByVal lDovizMiktari1 As Decimal, ByVal lDovizKuru1 As Decimal, ByVal sDovizCinsi2 As String, ByVal lDovizMiktari2 As Decimal, ByVal lDovizKuru2 As Decimal, ByVal sSonKullaniciAdi As String, ByVal dteSonUpdateTarihi As DateTime)
        Dim con As New OleDb.OleDbConnection
        Dim cmd As New OleDb.OleDbCommand
        cmd.Connection = con
        con.ConnectionString = connection
        If con.State = ConnectionState.Closed = True Then
            con.Open()
        End If
        nCariHareketID = "NULL"
        cmd.CommandText = sorgu_query("SET DATEFORMAT DMY SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED UPDATE    tbNakitKasa SET              lTahsilTutar = " & lTahsilTutar & ", lTediyeTutar = " & lTediyeTutar & ", sAciklama = N'" & sAciklama & "', sHareketTipi = '" & sHareketTipi & "', bMuhasebeyeIslendimi = " & bMuhasebeyeIslendimi & ", sMasrafYontemi = '" & sMasrafYontemi & "', sDovizCinsi1 = '" & sDovizCinsi1 & "', lDovizMiktari1 = " & lDovizMiktari1 & ", lDovizKuru1 = " & lDovizKuru1 & ", sDovizCinsi2 = '" & sDovizCinsi2 & "', lDovizMiktari2 = " & lDovizMiktari2 & ", lDovizKuru2 = " & lDovizKuru2 & ", sSonKullaniciAdi = '" & sSonKullaniciAdi & "', dteSonUpdateTarihi = '" & dteSonUpdateTarihi & "' Where nKasaIslemID  ='" & nKasaIslemID & "'")
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
    Private Sub nBordroSatirID_degistir(ByVal nSonID As String)
        Dim con As New OleDb.OleDbConnection
        Dim cmd As New OleDb.OleDbCommand
        Dim adapter As New OleDb.OleDbDataAdapter
        con.ConnectionString = connection
        cmd.Connection = con
        If con.State = ConnectionState.Closed Then
            con.Open()
        End If
        cmd.CommandText = sorgu_query("SET DATEFORMAT DMY SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED UPDATE    tbCekSenetSiraNo SET              nSonID =" & nSonID & " WHERE     (nSiraIndex = 2)")
        cmd.ExecuteNonQuery()
        con.Close()
    End Sub
    Private Sub nBordroSatirID_degistir_otomatik()
        Dim con As New OleDb.OleDbConnection
        Dim cmd As New OleDb.OleDbCommand
        Dim adapter As New OleDb.OleDbDataAdapter
        con.ConnectionString = connection
        cmd.Connection = con
        If con.State = ConnectionState.Closed Then
            con.Open()
        End If
        cmd.CommandText = sorgu_query("SET DATEFORMAT DMY SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED UPDATE tbCekSenetSiraNo SET nSonID = ISNULL((SELECT TOP 1 ISNULL(nBordroSatirID + 1 , 1) AS nSonID FROM tbCekSenetBordro ORDER BY nBordroSatirID DESC), 1) WHERE (nSiraIndex = 2)")
        cmd.ExecuteNonQuery()
        con.Close()
    End Sub
    Private Sub nCekSenetID_degistir(ByVal nSonID As String)
        Dim con As New OleDb.OleDbConnection
        Dim cmd As New OleDb.OleDbCommand
        Dim adapter As New OleDb.OleDbDataAdapter
        con.ConnectionString = connection
        cmd.Connection = con
        If con.State = ConnectionState.Closed Then
            con.Open()
        End If
        cmd.CommandText = sorgu_query("SET DATEFORMAT DMY SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED UPDATE    tbCekSenetSiraNo SET              nSonID =" & nSonID & " WHERE     (nSiraIndex = 1)")
        cmd.ExecuteNonQuery()
        con.Close()
    End Sub
    Private Sub nCekSenetID_Odeme_degistir(ByVal nCekSenetID As String, ByVal nSonBordroSatirID As String, ByVal nSonCekSenetIslem As String)
        Dim con As New OleDb.OleDbConnection
        Dim cmd As New OleDb.OleDbCommand
        Dim adapter As New OleDb.OleDbDataAdapter
        con.ConnectionString = connection
        cmd.Connection = con
        If con.State = ConnectionState.Closed Then
            con.Open()
        End If
        cmd.CommandText = sorgu_query("SET DATEFORMAT DMY SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED UPDATE    tbCekSenet SET              nSonBordroSatirID = " & nSonBordroSatirID & ",nSonCekSenetIslem = " & nSonCekSenetIslem & " WHere nCekSenetID = " & nCekSenetID & " ")
        cmd.ExecuteNonQuery()
        con.Close()
    End Sub
    Private Sub nCekSenetID_degistir_otomatik()
        Dim con As New OleDb.OleDbConnection
        Dim cmd As New OleDb.OleDbCommand
        Dim adapter As New OleDb.OleDbDataAdapter
        con.ConnectionString = connection
        cmd.Connection = con
        If con.State = ConnectionState.Closed Then
            con.Open()
        End If
        cmd.CommandText = sorgu_query("SET DATEFORMAT DMY SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED UPDATE tbCekSenetSiraNo SET nSonID = ISNULL((SELECT TOP 1 ISNULL(nCekSenetID + 1 , 1) AS nSonID FROM tbCekSenet ORDER BY nCekSenetID DESC), 1) WHERE (nSiraIndex = 1)")
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
    Private Sub lFisNo_degistir()
        Dim con As New OleDb.OleDbConnection
        Dim cmd As New OleDb.OleDbCommand
        Dim adapter As New OleDb.OleDbDataAdapter
        con.ConnectionString = connection
        cmd.Connection = con
        If con.State = ConnectionState.Closed Then
            con.Open()
        End If
        cmd.CommandText = sorgu_query("SET DATEFORMAT DMY SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED UPDATE tbMuhasebeFisNo SET lSonMahsupNo1 = ISNULL((SELECT TOP 1 ISNULL(lFisno + 1 , 1) AS lFisNo FROM tbMuhasebeFisi WHERE (sMuhFisTipi = 3)),1)")
        cmd.ExecuteNonQuery()
        con.Close()
    End Sub
    Private Sub satir_ekle()
        If nFirmaId > 0 Then
            status = True
            Dim dr As DataRow
            Dim dr1 As DataRow
            Dim dteVadeTarihi As DateTime = txt_dteBordroTarihi.EditValue
            Dim sBankaKodu As String = ""
            Dim sBankaHesapNo As String = ""
            Dim sBankaSubeNo As String = ""
            Dim sBorclusu As String = ""
            Dim sBorcluVergiDairesi As String = ""
            Dim sBorcluVergiNumarasi As String = ""
            Dim sOrjinalCekSenetNo As String = ""
            If GridView1.RowCount = 0 Then
            Else
                dr1 = GridView1.GetDataRow(GridView1.FocusedRowHandle)
                dteVadeTarihi = DateAdd(DateInterval.Month, 1, dr1("dteVadeTarihi"))
                sBankaKodu = dr1("sBankaKodu")
                sBankaHesapNo = dr1("sBankaHesapNo")
                sBankaSubeNo = dr1("sBankaSubeNo")
                sBorclusu = dr1("sBorclusu")
                sBorcluVergiDairesi = dr1("sBorcluVergiDairesi")
                sBorcluVergiNumarasi = dr1("sBorcluVergiNumarasi")
                If IsNumeric(dr1("sOrjinalCekSenetNo")) = True Then
                    sOrjinalCekSenetNo = CLng(dr1("sOrjinalCekSenetNo")) + 1
                Else
                    sOrjinalCekSenetNo = ""
                End If
            End If
            dr = ds_tbCekSenet.Tables(0).NewRow
            Dim nBordroSatirID As Int64 = sorgu_nBordroSatirID()
            Dim nCariHareketID = sorgu_nCariHareketID()
            Dim nCekSenetID = sorgu_nCekSenetID()
            Dim lCekSenetNo = sorgu_lCekSenetNo(sec_sCekSenetTipi.EditValue)
            dr("nBordroSatirID") = nBordroSatirID
            dr("nCekSenetID") = nCekSenetID
            dr("lCekSenetNo") = lCekSenetNo
            dr("lTutar") = 0.01
            dr("dteVadeTarihi") = dteVadeTarihi
            dr("sHareketTipi") = txt_sHareketTipi.EditValue
            dr("sNot") = ""
            dr("sIl") = ""
            dr("sSemt") = ""
            dr("sKarsiTarafCekSenetNo") = ""
            dr("dteDuzenlemeTarihi") = txt_dteBordroTarihi.EditValue
            dr("sBankaKodu") = sBankaKodu
            dr("sBankaHesapNo") = sBankaHesapNo
            dr("sBankaSubeNo") = sBankaSubeNo
            dr("sOrjinalCekSenetNo") = sOrjinalCekSenetNo
            dr("nVerenID") = nFirmaId
            dr("bKendineAit") = 0
            dr("sBorclusu") = sBorclusu
            dr("sBorcluVergiDairesi") = sBorcluVergiDairesi
            dr("sBorcluVergiNumarasi") = sBorcluVergiNumarasi
            dr("nSonBordroSatirID") = nBordroSatirID
            dr("nSonCekSenetIslem") = sec_nCekSenetIslem.EditValue
            dr("nCariHareketID") = nCariHareketID
            dr("nKasaIslemID") = 0
            dr("nBorcluFirmaID") = 0
            dr("nBorcluCariHareketID") = 0
            dr("nProtestoMasrafiFirmaID") = 0
            dr("nProtestoMasrafiCariHareketID") = 0
            dr("lProtestoMasrafi") = 0
            dr("nOncekiBordroSatirID") = 0
            dr("nOncekiCekSenetIslem") = 0
            dr("dteValorTarihi") = dteVadeTarihi
            dr("bMuhasebeyeIslendimi") = 0
            dr("sDovizCinsi1") = ""
            dr("lDovizMiktari1") = 0
            dr("lDovizKuru1") = 0
            dr("sDovizCinsi2") = ""
            dr("lDovizMiktari2") = 0
            dr("lDovizKuru2") = 0
            dr("sCekSenetKodu1") = sec_sSubeMagaza.EditValue
            dr("sCekSenetKodu2") = ""
            dr("sCekSenetTipi") = sec_sCekSenetTipi.EditValue
            dr("nCekSenetIslem") = sec_nCekSenetIslem.EditValue
            dr("dteBordroTarihi") = txt_dteBordroTarihi.EditValue
            dr("lBordroNo") = txt_lBordroNo.EditValue
            dr("nFirmaID") = nFirmaId
            dr("sFirmaKodu") = sKodu
            dr("sKullaniciAdi") = kullaniciadi
            dr("dteKayitTarihi") = Now
            dr("bKilitli") = 0
            dr("nCariHareketID") = tbFirmaHareketi_kaydet_yeni(dr("nCariHareketID"), dr("nFirmaID"), dr("dteBordroTarihi"), dr("dteVadeTarihi"), dr("sCekSenetTipi"), "", dr("lTutar"), dr("lTutar"), dr("lCekSenetNo"), 0, dr("sCekSenetTipi"), dr("sHareketTipi"), dr("sKullaniciAdi"), dr("dteKayitTarihi"), "", 0, 0, "", 0, 0, kullaniciadi, Now)
            nCariHareketID_degistir(dr("nCariHareketID"))
            dr("nCekSenetID") = tbCekSenet_kaydet_yeni(dr("nCekSenetID"), dr("sCekSenetTipi"), dr("lCekSenetNo"), dr("sBankaKodu"), dr("lTutar"), dr("dteVadeTarihi"), dr("dteDuzenlemeTarihi"), dr("sIl"), dr("sSemt"), dr("sOrjinalCekSenetNo"), dr("sKarsiTarafCekSenetNo"), dr("nVerenID"), dr("bKendineAit"), dr("sBorclusu"), dr("sBorcluVergiDairesi"), dr("sBorcluVergiNumarasi"), dr("sBankaHesapNo"), dr("sBankaSubeNo"), dr("nSonBordroSatirID"), dr("nSonCekSenetIslem"), dr("sHareketTipi"), dr("sNot"), dr("sKullaniciAdi"), dr("dteKayitTarihi"), dr("sDovizCinsi1"), dr("lDovizMiktari1"), dr("lDovizKuru1"), dr("sDovizCinsi2"), dr("lDovizMiktari2"), dr("lDovizKuru2"), kullaniciadi, Now, dr("sCekSenetKodu1"), dr("sCekSenetKodu2"))
            dr("nBordroSatirID") = tbCekSenetBordro_kaydet_yeni(dr("nBordroSatirID"), dr("nCekSenetIslem"), dr("nFirmaID"), dr("dteBordroTarihi"), dr("lBordroNo"), dr("nCekSenetID"), dr("nOncekiBordroSatirID"), dr("nOncekiCekSenetIslem"), dr("nCariHareketID"), "", dr("nBorcluFirmaID"), dr("nBorcluCariHareketID"), dr("nProtestoMasrafiFirmaID"), "", dr("lProtestoMasrafi"), dr("dteValorTarihi"), dr("bMuhasebeyeIslendimi"), dr("sKullaniciAdi"), dr("dteKayitTarihi"))
            nCekSenetID_degistir(dr("nCekSenetID"))
            nBordroSatirID_degistir(dr("nBordroSatirID"))
            ds_tbCekSenet.Tables(0).Rows.Add(dr)
            status = False
            If GridView1.RowCount > 0 Then
                GridView1.FocusedRowHandle = GridView1.RowCount - 1
                GridView1.ClearSelection()
                GridView1.SelectRow(GridView1.RowCount - 1)
                PanelControl3.Focus()
                GridControl1.Focus()
            End If
            GridControl1.Focus()
            GridControl1.Select()
            GridView1.FocusedColumn = colsBankaKodu
            satir_kontrol()
        End If
    End Sub
    Private Sub satir_ekle_devir()
        If nFirmaId > 0 Then
            status = True
            Dim dr As DataRow
            dr = ds_tbCekSenet.Tables(0).NewRow
            Dim nBordroSatirID As Int64 = sorgu_nBordroSatirID()
            Dim nCariHareketID = -1 'sorgu_nCariHareketID()
            Dim nCekSenetID = sorgu_nCekSenetID()
            Dim lCekSenetNo = sorgu_lCekSenetNo(sec_sCekSenetTipi.EditValue)
            dr("nBordroSatirID") = nBordroSatirID
            dr("nCekSenetID") = nCekSenetID
            dr("lCekSenetNo") = lCekSenetNo
            dr("lTutar") = 0.01
            dr("dteVadeTarihi") = txt_dteBordroTarihi.EditValue
            dr("sHareketTipi") = txt_sHareketTipi.EditValue
            dr("sNot") = "Devir"
            dr("sIl") = ""
            dr("sSemt") = ""
            dr("sKarsiTarafCekSenetNo") = ""
            dr("dteDuzenlemeTarihi") = txt_dteBordroTarihi.EditValue
            dr("sBankaKodu") = ""
            dr("sBankaHesapNo") = ""
            dr("sBankaSubeNo") = ""
            dr("sOrjinalCekSenetNo") = ""
            dr("nVerenID") = nFirmaId
            dr("bKendineAit") = 0
            dr("sBorclusu") = ""
            dr("sBorcluVergiDairesi") = ""
            dr("sBorcluVergiNumarasi") = ""
            dr("nSonBordroSatirID") = nBordroSatirID
            dr("nSonCekSenetIslem") = sec_nCekSenetIslem.EditValue
            dr("nCariHareketID") = nCariHareketID
            dr("nKasaIslemID") = 0
            dr("nBorcluFirmaID") = 0
            dr("nBorcluCariHareketID") = 0
            dr("nProtestoMasrafiFirmaID") = 0
            dr("nProtestoMasrafiCariHareketID") = 0
            dr("lProtestoMasrafi") = 0
            dr("nOncekiBordroSatirID") = 0
            dr("nOncekiCekSenetIslem") = 0
            dr("dteValorTarihi") = txt_dteBordroTarihi.EditValue
            dr("bMuhasebeyeIslendimi") = 0
            dr("sDovizCinsi1") = ""
            dr("lDovizMiktari1") = 0
            dr("lDovizKuru1") = 0
            dr("sDovizCinsi2") = ""
            dr("lDovizMiktari2") = 0
            dr("lDovizKuru2") = 0
            dr("sCekSenetKodu1") = sec_sSubeMagaza.EditValue
            dr("sCekSenetKodu2") = ""
            dr("sCekSenetTipi") = sec_sCekSenetTipi.EditValue
            dr("nCekSenetIslem") = sec_nCekSenetIslem.EditValue
            dr("dteBordroTarihi") = txt_dteBordroTarihi.EditValue
            dr("lBordroNo") = txt_lBordroNo.EditValue
            dr("nFirmaID") = nFirmaId
            dr("sFirmaKodu") = sKodu
            dr("sKullaniciAdi") = kullaniciadi
            dr("dteKayitTarihi") = Now
            dr("bKilitli") = 0
            'tbFirmaHareketi_kaydet_yeni(dr("nCariHareketID"), dr("nFirmaID"), dr("dteBordroTarihi"), dr("dteVadeTarihi"), dr("sCekSenetTipi"), "", dr("lTutar"), dr("lTutar"), dr("lCekSenetNo"), 0, dr("sCekSenetTipi"), dr("sHareketTipi"), dr("sKullaniciAdi"), dr("dteKayitTarihi"), "", 0, 0, "", 0, 0, kullaniciadi, Now)
            'nCariHareketID_degistir(nCariHareketID)
            dr("nCekSenetID") = tbCekSenet_kaydet_yeni(dr("nCekSenetID"), dr("sCekSenetTipi"), dr("lCekSenetNo"), dr("sBankaKodu"), dr("lTutar"), dr("dteVadeTarihi"), dr("dteDuzenlemeTarihi"), dr("sIl"), dr("sSemt"), dr("sOrjinalCekSenetNo"), dr("sKarsiTarafCekSenetNo"), dr("nVerenID"), dr("bKendineAit"), dr("sBorclusu"), dr("sBorcluVergiDairesi"), dr("sBorcluVergiNumarasi"), dr("sBankaHesapNo"), dr("sBankaSubeNo"), dr("nSonBordroSatirID"), dr("nSonCekSenetIslem"), dr("sHareketTipi"), dr("sNot"), dr("sKullaniciAdi"), dr("dteKayitTarihi"), dr("sDovizCinsi1"), dr("lDovizMiktari1"), dr("lDovizKuru1"), dr("sDovizCinsi2"), dr("lDovizMiktari2"), dr("lDovizKuru2"), kullaniciadi, Now, dr("sCekSenetKodu1"), dr("sCekSenetKodu2"))
            dr("nBordroSatirID") = tbCekSenetBordro_kaydet_yeni(dr("nBordroSatirID"), dr("nCekSenetIslem"), dr("nFirmaID"), dr("dteBordroTarihi"), dr("lBordroNo"), dr("nCekSenetID"), dr("nOncekiBordroSatirID"), dr("nOncekiCekSenetIslem"), dr("nCariHareketID"), "", dr("nBorcluFirmaID"), dr("nBorcluCariHareketID"), dr("nProtestoMasrafiFirmaID"), "", dr("lProtestoMasrafi"), dr("dteValorTarihi"), dr("bMuhasebeyeIslendimi"), dr("sKullaniciAdi"), dr("dteKayitTarihi"))
            nCekSenetID_degistir(dr("nCekSenetID"))
            nBordroSatirID_degistir(dr("nBordroSatirID"))
            ds_tbCekSenet.Tables(0).Rows.Add(dr)
            status = False
            If GridView1.RowCount > 0 Then
                GridView1.FocusedRowHandle = GridView1.RowCount - 1
                GridView1.ClearSelection()
                GridView1.SelectRow(GridView1.RowCount - 1)
                PanelControl3.Focus()
                GridControl1.Focus()
            End If
            GridControl1.Focus()
            GridControl1.Select()
            GridView1.FocusedColumn = colsBankaKodu
            satir_kontrol()
        End If
    End Sub
    Private Sub satir_ekle_odeme()
        status = True
        Dim frm As New frm_tbCekSenet_liste
        frm.firmano = firmano
        frm.donemno = donemno
        frm.connection = connection
        frm.sCekSenetTipi = sec_sCekSenetTipi.EditValue
        frm.nCekSenetIslem = 20
        frm.txt_ara.Text = sKodu
        frm.sec_konum.Text = "Kodu"
        frm.txt_ara.Enabled = False
        frm.sec_konum.Enabled = False
        frm.islemstatus = True
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
                    dr1 = frm.GridView1.GetDataRow(s)
                    dr = ds_tbCekSenet.Tables(0).NewRow
                    Dim nBordroSatirID As Int64 = sorgu_nBordroSatirID()
                    'Dim nCariHareketID = sorgu_nCariHareketID()
                    Dim nCekSenetID = sorgu_nCekSenetID()
                    Dim lCekSenetNo = sorgu_lCekSenetNo(sec_sCekSenetTipi.EditValue)
                    Dim nKasaIslemID = sorgu_nKasaIslemID()
                    dr("nBordroSatirID") = nBordroSatirID
                    dr("nCekSenetID") = dr1("nCekSenetID")
                    dr("lCekSenetNo") = dr1("lCekSenetNo")
                    dr("lTutar") = dr1("lTutar")
                    dr("dteVadeTarihi") = dr1("dteVadeTarihi")
                    dr("sHareketTipi") = dr1("sHareketTipi")
                    dr("sNot") = ""
                    dr("sIl") = ""
                    dr("sSemt") = ""
                    dr("sKarsiTarafCekSenetNo") = ""
                    dr("dteDuzenlemeTarihi") = dr1("dteBordroTarihi")
                    dr("sBankaKodu") = dr1("sBankaKodu")
                    dr("sBankaHesapNo") = dr1("sBankaHesapNo")
                    dr("sBankaSubeNo") = ""
                    dr("sOrjinalCekSenetNo") = dr1("sOrjinalCekSenetNo")
                    dr("nVerenID") = dr1("nVerenID")
                    dr("bKendineAit") = 0
                    dr("sBorclusu") = ""
                    dr("sBorcluVergiDairesi") = ""
                    dr("sBorcluVergiNumarasi") = ""
                    dr("nSonBordroSatirID") = nBordroSatirID
                    dr("nSonCekSenetIslem") = sec_nCekSenetIslem.EditValue
                    dr("nCariHareketID") = 0
                    dr("nKasaIslemID") = nKasaIslemID
                    dr("nBorcluFirmaID") = nBorcluFirmaID
                    dr("nBorcluCariHareketID") = 0
                    dr("nProtestoMasrafiFirmaID") = 0
                    dr("nProtestoMasrafiCariHareketID") = 0
                    dr("lProtestoMasrafi") = 0
                    dr("nOncekiBordroSatirID") = dr1("nBordroSatirID")
                    dr("nOncekiCekSenetIslem") = 20
                    dr("dteValorTarihi") = dr1("dteVadeTarihi")
                    dr("bMuhasebeyeIslendimi") = 0
                    dr("sDovizCinsi1") = dr1("sDovizCinsi1")
                    dr("lDovizMiktari1") = dr1("lDovizMiktari1")
                    dr("lDovizKuru1") = dr1("lDovizKuru1")
                    dr("sDovizCinsi2") = ""
                    dr("lDovizMiktari2") = 0
                    dr("lDovizKuru2") = 0
                    dr("sCekSenetKodu1") = ""
                    dr("sCekSenetKodu2") = ""
                    dr("sCekSenetTipi") = sec_sCekSenetTipi.EditValue
                    dr("nCekSenetIslem") = sec_nCekSenetIslem.EditValue
                    dr("dteBordroTarihi") = txt_dteBordroTarihi.EditValue
                    dr("lBordroNo") = txt_lBordroNo.EditValue
                    dr("nFirmaID") = nFirmaId
                    dr("sFirmaKodu") = sBorcluKodu
                    dr("sKullaniciAdi") = kullaniciadi
                    dr("dteKayitTarihi") = Now
                    dr("bKilitli") = 0
                    Dim sAciklama As String = Microsoft.VisualBasic.Left(String.Format("B:{0}\({1})\Vade:{2}\E.N:{3}-{4}", Trim(dr("lBordroNo").ToString), sorgu_sBankaAdi(dr("sBankaKodu")), dr("dteVadeTarihi"), Trim(dr("sOrjinalCekSenetNo")), sorgu_sCekSenetIslem(dr("nCekSenetIslem"))), 60)
                    'Dim sAciklama As String = Microsoft.VisualBasic.Left("B:" + Trim(dr("lBordroNo").ToString) + "\(" + sorgu_sBankaAdi(dr("sBankaKodu")) + ")\Vade:" + dr("dteVadeTarihi") + "\E.N:" + Trim(dr("sOrjinalCekSenetNo")) + "-" + sorgu_sCekSenetIslem(dr("nCekSenetIslem")), 60)
                    nKasaIslemID = tbNakitKasa_kaydet_yeni(dr("nKasaIslemID"), sSubeMagaza, dr("dteBordroTarihi"), 0, dr("lTutar"), sAciklama, 0, dr("nFirmaID"), 0, sec_sCekSenetTipi.EditValue, dr("sHareketTipi"), kullaniciadi, dr("dteKayitTarihi"), 0, "", "", 0, 0, "", 0, 0, kullaniciadi, dr("dteKayitTarihi"))
                    dr("nKasaIslemID") = nKasaIslemID
                    nKasaIslemID_degistir(nKasaIslemID)
                    'tbFirmaHareketi_kaydet_yeni(dr("nBorcluCariHareketID"), dr("nBorcluFirmaID"), dr("dteBordroTarihi"), dr("dteVadeTarihi"), dr("sCekSenetTipi"), sAciklama, 0, dr("lTutar"), dr("lCekSenetNo"), 0, dr("sCekSenetTipi"), dr("sHareketTipi"), dr("sKullaniciAdi"), dr("dteKayitTarihi"), dr("sDovizCinsi1"), dr("lDovizMiktari1"), dr("lDovizKuru1"), "", 0, 0, kullaniciadi, Now)
                    'nCariHareketID_degistir(nCariHareketID)
                    'tbCekSenet_kaydet_yeni(dr("nCekSenetID"), dr("sCekSenetTipi"), dr("lCekSenetNo"), dr("sBankaKodu"), dr("lTutar"), dr("dteVadeTarihi"), dr("dteDuzenlemeTarihi"), dr("sIl"), dr("sSemt"), dr("sOrjinalCekSenetNo"), dr("sKarsiTarafCekSenetNo"), dr("nVerenID"), dr("bKendineAit"), dr("sBorclusu"), dr("sBorcluVergiDairesi"), dr("sBorcluVergiNumarasi"), dr("sBankaHesapNo"), dr("sBankaSubeNo"), dr("nSonBordroSatirID"), dr("nSonCekSenetIslem"), dr("sHareketTipi"), dr("sNot"), dr("sKullaniciAdi"), dr("dteKayitTarihi"), dr("sDovizCinsi1"), dr("lDovizMiktari1"), dr("lDovizKuru1"), dr("sDovizCinsi2"), dr("lDovizMiktari2"), dr("lDovizKuru2"), kullaniciadi, Now, dr("sCekSenetKodu1"), dr("sCekSenetKodu2"))
                    dr("nBordroSatirID") = tbCekSenetBordro_kaydet_yeni(dr("nBordroSatirID"), dr("nCekSenetIslem"), dr("nFirmaID"), dr("dteBordroTarihi"), dr("lBordroNo"), dr("nCekSenetID"), dr("nOncekiBordroSatirID"), dr("nOncekiCekSenetIslem"), dr("nCariHareketID"), dr("nKasaIslemID"), dr("nBorcluFirmaID"), dr("nBorcluCariHareketID"), dr("nProtestoMasrafiFirmaID"), "", dr("lProtestoMasrafi"), dr("dteValorTarihi"), dr("bMuhasebeyeIslendimi"), dr("sKullaniciAdi"), dr("dteKayitTarihi"))
                    'nCekSenetID_degistir(nCekSenetID)
                    nCekSenetID_Odeme_degistir(dr1("nCekSenetID"), dr("nBordroSatirID"), 21)
                    nBordroSatirID_degistir(dr("nBordroSatirID"))
                    ds_tbCekSenet.Tables(0).Rows.Add(dr)
                Next
            End If
            status = False
            If GridView1.RowCount > 0 Then
                GridView1.FocusedRowHandle = GridView1.RowCount - 1
                GridView1.ClearSelection()
                GridView1.SelectRow(GridView1.RowCount - 1)
                PanelControl3.Focus()
                GridControl1.Focus()
            End If
        End If
        GridView1.FocusedColumn = colsBankaKodu
        satir_kontrol()
    End Sub
    Private Sub satir_ekle_odeme_bankadan()
        status = True
        Dim frm As New frm_tbCekSenet_liste
        frm.firmano = firmano
        frm.donemno = donemno
        frm.connection = connection
        frm.sCekSenetTipi = sec_sCekSenetTipi.EditValue
        frm.nCekSenetIslem = 20
        frm.txt_ara.Text = sKodu
        frm.sec_konum.Text = "Kodu"
        frm.txt_ara.Enabled = False
        frm.sec_konum.Enabled = False
        frm.islemstatus = True
        If frm.ShowDialog(Me) = Windows.Forms.DialogResult.OK Then
            If borclufirma_sec() = True Then
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
                        dr1 = frm.GridView1.GetDataRow(s)
                        dr = ds_tbCekSenet.Tables(0).NewRow
                        Dim nBordroSatirID As Int64 = sorgu_nBordroSatirID()
                        Dim nCariHareketID = sorgu_nCariHareketID()
                        Dim nCekSenetID = sorgu_nCekSenetID()
                        Dim lCekSenetNo = sorgu_lCekSenetNo(sec_sCekSenetTipi.EditValue)
                        dr("nBordroSatirID") = nBordroSatirID
                        dr("nCekSenetID") = dr1("nCekSenetID")
                        dr("lCekSenetNo") = dr1("lCekSenetNo")
                        dr("lTutar") = dr1("lTutar")
                        dr("dteVadeTarihi") = dr1("dteVadeTarihi")
                        dr("sHareketTipi") = dr1("sHareketTipi")
                        dr("sNot") = ""
                        dr("sIl") = ""
                        dr("sSemt") = ""
                        dr("sKarsiTarafCekSenetNo") = ""
                        dr("dteDuzenlemeTarihi") = dr1("dteBordroTarihi")
                        dr("sBankaKodu") = dr1("sBankaKodu")
                        dr("sBankaHesapNo") = dr1("sBankaHesapNo")
                        dr("sBankaSubeNo") = ""
                        dr("sOrjinalCekSenetNo") = dr1("sOrjinalCekSenetNo")
                        dr("nVerenID") = dr1("nVerenID")
                        dr("bKendineAit") = 0
                        dr("sBorclusu") = ""
                        dr("sBorcluVergiDairesi") = ""
                        dr("sBorcluVergiNumarasi") = ""
                        dr("nSonBordroSatirID") = nBordroSatirID
                        dr("nSonCekSenetIslem") = sec_nCekSenetIslem.EditValue
                        dr("nCariHareketID") = 0
                        dr("nKasaIslemID") = 0
                        dr("nBorcluFirmaID") = nBorcluFirmaID
                        dr("nBorcluCariHareketID") = nCariHareketID
                        dr("nProtestoMasrafiFirmaID") = nBorcluFirmaID
                        dr("nProtestoMasrafiCariHareketID") = 0
                        dr("lProtestoMasrafi") = 0
                        dr("nOncekiBordroSatirID") = dr1("nBordroSatirID")
                        dr("nOncekiCekSenetIslem") = 20
                        dr("dteValorTarihi") = dr1("dteVadeTarihi")
                        dr("bMuhasebeyeIslendimi") = 0
                        dr("sDovizCinsi1") = dr1("sDovizCinsi1")
                        dr("lDovizMiktari1") = dr1("lDovizMiktari1")
                        dr("lDovizKuru1") = dr1("lDovizKuru1")
                        dr("sDovizCinsi2") = ""
                        dr("lDovizMiktari2") = 0
                        dr("lDovizKuru2") = 0
                        dr("sCekSenetKodu1") = ""
                        dr("sCekSenetKodu2") = ""
                        dr("sCekSenetTipi") = sec_sCekSenetTipi.EditValue
                        dr("nCekSenetIslem") = sec_nCekSenetIslem.EditValue
                        dr("dteBordroTarihi") = txt_dteBordroTarihi.EditValue
                        dr("lBordroNo") = txt_lBordroNo.EditValue
                        dr("nFirmaID") = nFirmaId
                        dr("sFirmaKodu") = sBorcluKodu
                        dr("sKullaniciAdi") = kullaniciadi
                        dr("dteKayitTarihi") = Now
                        dr("bKilitli") = 0
                        Dim sAciklama As String = Microsoft.VisualBasic.Left(String.Format("B:{0}\({1})\Vade:{2}\E.N:{3}-{4}", Trim(dr("lBordroNo").ToString), sorgu_sBankaAdi(dr("sBankaKodu")), dr("dteVadeTarihi"), Trim(dr("sOrjinalCekSenetNo")), sorgu_sCekSenetIslem(dr("nCekSenetIslem"))), 60)
                        dr("nBorcluCariHareketID") = tbFirmaHareketi_kaydet_yeni(dr("nBorcluCariHareketID"), dr("nBorcluFirmaID"), dr("dteBordroTarihi"), dr("dteVadeTarihi"), dr("sCekSenetTipi"), sAciklama, 0, dr("lTutar"), dr("lCekSenetNo"), 0, dr("sCekSenetTipi"), dr("sHareketTipi"), dr("sKullaniciAdi"), dr("dteKayitTarihi"), dr("sDovizCinsi1"), dr("lDovizMiktari1"), dr("lDovizKuru1"), "", 0, 0, kullaniciadi, Now)
                        nCariHareketID_degistir(dr("nBorcluCariHareketID"))
                        'tbCekSenet_kaydet_yeni(dr("nCekSenetID"), dr("sCekSenetTipi"), dr("lCekSenetNo"), dr("sBankaKodu"), dr("lTutar"), dr("dteVadeTarihi"), dr("dteDuzenlemeTarihi"), dr("sIl"), dr("sSemt"), dr("sOrjinalCekSenetNo"), dr("sKarsiTarafCekSenetNo"), dr("nVerenID"), dr("bKendineAit"), dr("sBorclusu"), dr("sBorcluVergiDairesi"), dr("sBorcluVergiNumarasi"), dr("sBankaHesapNo"), dr("sBankaSubeNo"), dr("nSonBordroSatirID"), dr("nSonCekSenetIslem"), dr("sHareketTipi"), dr("sNot"), dr("sKullaniciAdi"), dr("dteKayitTarihi"), dr("sDovizCinsi1"), dr("lDovizMiktari1"), dr("lDovizKuru1"), dr("sDovizCinsi2"), dr("lDovizMiktari2"), dr("lDovizKuru2"), kullaniciadi, Now, dr("sCekSenetKodu1"), dr("sCekSenetKodu2"))
                        dr("nBordroSatirID") = tbCekSenetBordro_kaydet_yeni(dr("nBordroSatirID"), dr("nCekSenetIslem"), dr("nFirmaID"), dr("dteBordroTarihi"), dr("lBordroNo"), dr("nCekSenetID"), dr("nOncekiBordroSatirID"), dr("nOncekiCekSenetIslem"), dr("nCariHareketID"), "", dr("nBorcluFirmaID"), dr("nBorcluCariHareketID"), dr("nProtestoMasrafiFirmaID"), "", dr("lProtestoMasrafi"), dr("dteValorTarihi"), dr("bMuhasebeyeIslendimi"), dr("sKullaniciAdi"), dr("dteKayitTarihi"))
                        'nCekSenetID_degistir(nCekSenetID)
                        nCekSenetID_Odeme_degistir(dr1("nCekSenetID"), dr("nBordroSatirID"), 24)
                        nBordroSatirID_degistir(dr("nBordroSatirID"))
                        ds_tbCekSenet.Tables(0).Rows.Add(dr)
                    Next
                End If
                status = False
                If GridView1.RowCount > 0 Then
                    GridView1.FocusedRowHandle = GridView1.RowCount - 1
                    GridView1.ClearSelection()
                    GridView1.SelectRow(GridView1.RowCount - 1)
                    PanelControl3.Focus()
                    GridControl1.Focus()
                End If
            End If
        End If
        GridView1.FocusedColumn = colsBankaKodu
        satir_kontrol()
    End Sub
    Private Sub satir_ekle_iptal()
        status = True
        Dim frm As New frm_tbCekSenet_liste
        frm.firmano = firmano
        frm.donemno = donemno
        frm.connection = connection
        frm.sCekSenetTipi = sec_sCekSenetTipi.EditValue
        frm.nCekSenetIslem = 20
        frm.txt_ara.Text = sKodu
        frm.sec_konum.Text = "Kodu"
        frm.txt_ara.Enabled = False
        frm.sec_konum.Enabled = False
        frm.islemstatus = True
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
                    dr1 = frm.GridView1.GetDataRow(s)
                    dr = ds_tbCekSenet.Tables(0).NewRow
                    Dim nBordroSatirID As Int64 = sorgu_nBordroSatirID()
                    Dim nCariHareketID = sorgu_nCariHareketID()
                    Dim nCekSenetID = sorgu_nCekSenetID()
                    Dim lCekSenetNo = sorgu_lCekSenetNo(sec_sCekSenetTipi.EditValue)
                    dr("nBordroSatirID") = nBordroSatirID
                    dr("nCekSenetID") = dr1("nCekSenetID")
                    dr("lCekSenetNo") = dr1("lCekSenetNo")
                    dr("lTutar") = dr1("lTutar")
                    dr("dteVadeTarihi") = dr1("dteVadeTarihi")
                    dr("sHareketTipi") = dr1("sHareketTipi")
                    dr("sNot") = ""
                    dr("sIl") = ""
                    dr("sSemt") = ""
                    dr("sKarsiTarafCekSenetNo") = ""
                    dr("dteDuzenlemeTarihi") = dr1("dteBordroTarihi")
                    dr("sBankaKodu") = dr1("sBankaKodu")
                    dr("sBankaHesapNo") = dr1("sBankaHesapNo")
                    dr("sBankaSubeNo") = ""
                    dr("sOrjinalCekSenetNo") = dr1("sOrjinalCekSenetNo")
                    dr("nVerenID") = dr1("nVerenID")
                    dr("bKendineAit") = 0
                    dr("sBorclusu") = ""
                    dr("sBorcluVergiDairesi") = ""
                    dr("sBorcluVergiNumarasi") = ""
                    dr("nSonBordroSatirID") = nBordroSatirID
                    dr("nSonCekSenetIslem") = sec_nCekSenetIslem.EditValue
                    dr("nCariHareketID") = nCariHareketID
                    dr("nKasaIslemID") = 0
                    dr("nBorcluFirmaID") = 0
                    dr("nBorcluCariHareketID") = 0
                    dr("nProtestoMasrafiFirmaID") = 0
                    dr("nProtestoMasrafiCariHareketID") = 0
                    dr("lProtestoMasrafi") = 0
                    dr("nOncekiBordroSatirID") = dr1("nBordroSatirID")
                    dr("nOncekiCekSenetIslem") = 20
                    dr("dteValorTarihi") = dr1("dteVadeTarihi")
                    dr("bMuhasebeyeIslendimi") = 0
                    dr("sDovizCinsi1") = dr1("sDovizCinsi1")
                    dr("lDovizMiktari1") = dr1("lDovizMiktari1")
                    dr("lDovizKuru1") = dr1("lDovizKuru1")
                    dr("sDovizCinsi2") = ""
                    dr("lDovizMiktari2") = 0
                    dr("lDovizKuru2") = 0
                    dr("sCekSenetKodu1") = ""
                    dr("sCekSenetKodu2") = ""
                    dr("sCekSenetTipi") = sec_sCekSenetTipi.EditValue
                    dr("nCekSenetIslem") = sec_nCekSenetIslem.EditValue
                    dr("dteBordroTarihi") = txt_dteBordroTarihi.EditValue
                    dr("lBordroNo") = txt_lBordroNo.EditValue
                    dr("nFirmaID") = nFirmaId
                    dr("sFirmaKodu") = sKodu
                    dr("sKullaniciAdi") = kullaniciadi
                    dr("dteKayitTarihi") = Now
                    dr("bKilitli") = 0
                    Dim sAciklama As String = Microsoft.VisualBasic.Left("B:" + Trim(dr("lBordroNo").ToString) + "\(" + sorgu_sBankaAdi(dr("sBankaKodu")) + ")\Vade:" + dr("dteVadeTarihi") + "\E.N:" + Trim(dr("sOrjinalCekSenetNo")) + "-" + sorgu_sCekSenetIslem(dr("nCekSenetIslem")), 60)
                    dr("nCariHareketID") = tbFirmaHareketi_kaydet_yeni(dr("nCariHareketID"), dr("nFirmaID"), dr("dteBordroTarihi"), dr("dteVadeTarihi"), dr("sCekSenetTipi"), sAciklama, 0, dr("lTutar"), dr("lCekSenetNo"), 0, dr("sCekSenetTipi"), dr("sHareketTipi"), dr("sKullaniciAdi"), dr("dteKayitTarihi"), "", 0, 0, "", 0, 0, kullaniciadi, Now)
                    nCariHareketID_degistir(dr("nCariHareketID"))
                    'tbCekSenet_kaydet_yeni(dr("nCekSenetID"), dr("sCekSenetTipi"), dr("lCekSenetNo"), dr("sBankaKodu"), dr("lTutar"), dr("dteVadeTarihi"), dr("dteDuzenlemeTarihi"), dr("sIl"), dr("sSemt"), dr("sOrjinalCekSenetNo"), dr("sKarsiTarafCekSenetNo"), dr("nVerenID"), dr("bKendineAit"), dr("sBorclusu"), dr("sBorcluVergiDairesi"), dr("sBorcluVergiNumarasi"), dr("sBankaHesapNo"), dr("sBankaSubeNo"), dr("nSonBordroSatirID"), dr("nSonCekSenetIslem"), dr("sHareketTipi"), dr("sNot"), dr("sKullaniciAdi"), dr("dteKayitTarihi"), dr("sDovizCinsi1"), dr("lDovizMiktari1"), dr("lDovizKuru1"), dr("sDovizCinsi2"), dr("lDovizMiktari2"), dr("lDovizKuru2"), kullaniciadi, Now, dr("sCekSenetKodu1"), dr("sCekSenetKodu2"))
                    dr("nBordroSatirID") = tbCekSenetBordro_kaydet_yeni(dr("nBordroSatirID"), dr("nCekSenetIslem"), dr("nFirmaID"), dr("dteBordroTarihi"), dr("lBordroNo"), dr("nCekSenetID"), dr("nOncekiBordroSatirID"), dr("nOncekiCekSenetIslem"), dr("nCariHareketID"), "", dr("nBorcluFirmaID"), dr("nBorcluCariHareketID"), dr("nProtestoMasrafiFirmaID"), "", dr("lProtestoMasrafi"), dr("dteValorTarihi"), dr("bMuhasebeyeIslendimi"), dr("sKullaniciAdi"), dr("dteKayitTarihi"))
                    'nCekSenetID_degistir(nCekSenetID)
                    nCekSenetID_Odeme_degistir(dr1("nCekSenetID"), dr("nBordroSatirID"), 22)
                    nBordroSatirID_degistir(dr("nBordroSatirID"))
                    ds_tbCekSenet.Tables(0).Rows.Add(dr)
                Next
                status = False
                If GridView1.RowCount > 0 Then
                    GridView1.FocusedRowHandle = GridView1.RowCount - 1
                    GridView1.ClearSelection()
                    GridView1.SelectRow(GridView1.RowCount - 1)
                    PanelControl3.Focus()
                    GridControl1.Focus()
                End If
            End If
        End If
        GridView1.FocusedColumn = colsBankaKodu
        satir_kontrol()
    End Sub
    Private Sub satir_ekle_iade()
        status = True
        Dim frm As New frm_tbCekSenet_liste
        frm.firmano = firmano
        frm.donemno = donemno
        frm.connection = connection
        frm.sCekSenetTipi = sec_sCekSenetTipi.EditValue
        frm.nCekSenetIslem = 1
        frm.sCekSenetIslem = "'1','6'"
        frm.txt_ara.Text = sKodu
        frm.sec_konum.Text = "Kodu"
        frm.txt_ara.Enabled = False
        frm.sec_konum.Enabled = False
        frm.bCekSenetIslemGoster = True
        frm.islemstatus = True
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
                    dr1 = frm.GridView1.GetDataRow(s)
                    dr = ds_tbCekSenet.Tables(0).NewRow
                    Dim nBordroSatirID As Int64 = sorgu_nBordroSatirID()
                    Dim nCariHareketID = sorgu_nCariHareketID()
                    Dim nCekSenetID = sorgu_nCekSenetID()
                    Dim lCekSenetNo = sorgu_lCekSenetNo(sec_sCekSenetTipi.EditValue)
                    dr("nBordroSatirID") = nBordroSatirID
                    dr("nCekSenetID") = dr1("nCekSenetID")
                    dr("lCekSenetNo") = dr1("lCekSenetNo")
                    dr("lTutar") = dr1("lTutar")
                    dr("dteVadeTarihi") = dr1("dteVadeTarihi")
                    dr("sHareketTipi") = dr1("sHareketTipi")
                    dr("sNot") = ""
                    dr("sIl") = dr1("sIl")
                    dr("sSemt") = dr1("sSemt")
                    dr("sKarsiTarafCekSenetNo") = ""
                    dr("dteDuzenlemeTarihi") = dr1("dteBordroTarihi")
                    dr("sBankaKodu") = dr1("sBankaKodu")
                    dr("sBankaHesapNo") = dr1("sBankaHesapNo")
                    dr("sBankaSubeNo") = ""
                    dr("sOrjinalCekSenetNo") = dr1("sOrjinalCekSenetNo")
                    dr("nVerenID") = dr1("nVerenID")
                    dr("bKendineAit") = 0
                    dr("sBorclusu") = ""
                    dr("sBorcluVergiDairesi") = ""
                    dr("sBorcluVergiNumarasi") = ""
                    dr("nSonBordroSatirID") = nBordroSatirID
                    dr("nSonCekSenetIslem") = sec_nCekSenetIslem.EditValue
                    dr("nCariHareketID") = nCariHareketID
                    dr("nKasaIslemID") = 0
                    dr("nBorcluFirmaID") = 0
                    dr("nBorcluCariHareketID") = 0
                    dr("nProtestoMasrafiFirmaID") = 0
                    dr("nProtestoMasrafiCariHareketID") = 0
                    dr("lProtestoMasrafi") = 0
                    dr("nOncekiBordroSatirID") = dr1("nBordroSatirID")
                    dr("nOncekiCekSenetIslem") = 1 'dr1("nSonCekSenetIslem")
                    dr("dteValorTarihi") = dr1("dteVadeTarihi")
                    dr("bMuhasebeyeIslendimi") = 0
                    dr("sDovizCinsi1") = dr1("sDovizCinsi1")
                    dr("lDovizMiktari1") = dr1("lDovizMiktari1")
                    dr("lDovizKuru1") = dr1("lDovizKuru1")
                    dr("sDovizCinsi2") = dr1("sDovizCinsi2")
                    dr("lDovizMiktari2") = dr1("lDovizMiktari2")
                    dr("lDovizKuru2") = dr1("lDovizKuru2")
                    dr("sCekSenetKodu1") = dr1("sCekSenetKodu1")
                    dr("sCekSenetKodu2") = dr1("sCekSenetKodu2")
                    dr("sCekSenetTipi") = sec_sCekSenetTipi.EditValue
                    dr("nCekSenetIslem") = sec_nCekSenetIslem.EditValue
                    dr("dteBordroTarihi") = txt_dteBordroTarihi.EditValue
                    dr("lBordroNo") = txt_lBordroNo.EditValue
                    dr("nFirmaID") = nFirmaId
                    dr("sFirmaKodu") = sKodu
                    dr("sKullaniciAdi") = kullaniciadi
                    dr("dteKayitTarihi") = Now
                    dr("bKilitli") = 0
                    Dim sAciklama As String = Microsoft.VisualBasic.Left("B:" + Trim(dr("lBordroNo").ToString) + "\(" + sorgu_sBankaAdi(dr("sBankaKodu")) + ")\Vade:" + dr("dteVadeTarihi") + "\E.N:" + Trim(dr("sOrjinalCekSenetNo")) + "-" + sorgu_sCekSenetIslem(dr("nCekSenetIslem")), 60)
                    dr("nCariHareketID") = tbFirmaHareketi_kaydet_yeni(dr("nCariHareketID"), dr("nFirmaID"), dr("dteBordroTarihi"), dr("dteVadeTarihi"), dr("sCekSenetTipi"), sAciklama, dr("lTutar"), 0, dr("lCekSenetNo"), 0, dr("sCekSenetTipi"), dr("sHareketTipi"), dr("sKullaniciAdi"), dr("dteKayitTarihi"), "", 0, 0, "", 0, 0, kullaniciadi, Now)
                    nCariHareketID_degistir(dr("nCariHareketID"))
                    'tbCekSenet_kaydet_yeni(dr("nCekSenetID"), dr("sCekSenetTipi"), dr("lCekSenetNo"), dr("sBankaKodu"), dr("lTutar"), dr("dteVadeTarihi"), dr("dteDuzenlemeTarihi"), dr("sIl"), dr("sSemt"), dr("sOrjinalCekSenetNo"), dr("sKarsiTarafCekSenetNo"), dr("nVerenID"), dr("bKendineAit"), dr("sBorclusu"), dr("sBorcluVergiDairesi"), dr("sBorcluVergiNumarasi"), dr("sBankaHesapNo"), dr("sBankaSubeNo"), dr("nSonBordroSatirID"), dr("nSonCekSenetIslem"), dr("sHareketTipi"), dr("sNot"), dr("sKullaniciAdi"), dr("dteKayitTarihi"), dr("sDovizCinsi1"), dr("lDovizMiktari1"), dr("lDovizKuru1"), dr("sDovizCinsi2"), dr("lDovizMiktari2"), dr("lDovizKuru2"), kullaniciadi, Now, dr("sCekSenetKodu1"), dr("sCekSenetKodu2"))
                    dr("nBordroSatirID") = tbCekSenetBordro_kaydet_yeni(dr("nBordroSatirID"), dr("nCekSenetIslem"), dr("nFirmaID"), dr("dteBordroTarihi"), dr("lBordroNo"), dr("nCekSenetID"), dr("nOncekiBordroSatirID"), dr("nOncekiCekSenetIslem"), dr("nCariHareketID"), "", dr("nBorcluFirmaID"), dr("nBorcluCariHareketID"), dr("nProtestoMasrafiFirmaID"), "", dr("lProtestoMasrafi"), dr("dteValorTarihi"), dr("bMuhasebeyeIslendimi"), dr("sKullaniciAdi"), dr("dteKayitTarihi"))
                    'nCekSenetID_degistir(nCekSenetID)
                    nCekSenetID_Odeme_degistir(dr1("nCekSenetID"), dr("nBordroSatirID"), 2)
                    nBordroSatirID_degistir(dr("nBordroSatirID"))
                    ds_tbCekSenet.Tables(0).Rows.Add(dr)
                Next
                status = False
                If GridView1.RowCount > 0 Then
                    GridView1.FocusedRowHandle = GridView1.RowCount - 1
                    GridView1.ClearSelection()
                    GridView1.SelectRow(GridView1.RowCount - 1)
                    PanelControl3.Focus()
                    GridControl1.Focus()
                End If
            End If
        End If
        GridView1.FocusedColumn = colsBankaKodu
        satir_kontrol()
    End Sub
    Private Sub satir_ekle_protesto()
        status = True
        Dim frm As New frm_tbCekSenet_liste
        frm.firmano = firmano
        frm.donemno = donemno
        frm.connection = connection
        frm.sCekSenetTipi = sec_sCekSenetTipi.EditValue
        frm.nCekSenetIslem = 1
        frm.sCekSenetIslem = "'1','3','4','6'"
        frm.txt_ara.Text = sKodu
        frm.sec_konum.Text = "Kodu"
        frm.txt_ara.Enabled = False
        frm.sec_konum.Enabled = False
        frm.bCekSenetIslemGoster = True
        frm.islemstatus = True
        If frm.ShowDialog(Me) = Windows.Forms.DialogResult.OK Then
            If borclufirma_sec() = True Then
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
                        dr1 = frm.GridView1.GetDataRow(s)
                        dr = ds_tbCekSenet.Tables(0).NewRow
                        Dim nBordroSatirID As Int64 = sorgu_nBordroSatirID()
                        Dim nCariHareketID = sorgu_nCariHareketID()
                        Dim nCekSenetID = sorgu_nCekSenetID()
                        Dim lCekSenetNo = sorgu_lCekSenetNo(sec_sCekSenetTipi.EditValue)
                        dr("nBordroSatirID") = nBordroSatirID
                        dr("nCekSenetID") = dr1("nCekSenetID")
                        dr("lCekSenetNo") = dr1("lCekSenetNo")
                        dr("lTutar") = dr1("lTutar")
                        dr("dteVadeTarihi") = dr1("dteVadeTarihi")
                        dr("sHareketTipi") = dr1("sHareketTipi")
                        dr("sNot") = ""
                        dr("sIl") = ""
                        dr("sSemt") = ""
                        dr("sKarsiTarafCekSenetNo") = ""
                        dr("dteDuzenlemeTarihi") = dr1("dteBordroTarihi")
                        dr("sBankaKodu") = dr1("sBankaKodu")
                        dr("sBankaHesapNo") = dr1("sBankaHesapNo")
                        dr("sBankaSubeNo") = ""
                        dr("sOrjinalCekSenetNo") = dr1("sOrjinalCekSenetNo")
                        dr("nVerenID") = dr1("nVerenID")
                        dr("bKendineAit") = 0
                        dr("sBorclusu") = ""
                        dr("sBorcluVergiDairesi") = ""
                        dr("sBorcluVergiNumarasi") = ""
                        dr("nSonBordroSatirID") = nBordroSatirID
                        dr("nSonCekSenetIslem") = sec_nCekSenetIslem.EditValue
                        dr("nCariHareketID") = nCariHareketID
                        dr("nKasaIslemID") = 0
                        dr("nBorcluFirmaID") = nBorcluFirmaID
                        dr("nBorcluCariHareketID") = nCariHareketID
                        dr("nProtestoMasrafiFirmaID") = 0
                        dr("nProtestoMasrafiCariHareketID") = 0
                        dr("lProtestoMasrafi") = 0
                        dr("nOncekiBordroSatirID") = dr1("nBordroSatirID")
                        dr("nOncekiCekSenetIslem") = 1 'dr1("nSonCekSenetIslem")
                        dr("dteValorTarihi") = dr1("dteVadeTarihi")
                        dr("bMuhasebeyeIslendimi") = 0
                        dr("sDovizCinsi1") = dr1("sDovizCinsi1")
                        dr("lDovizMiktari1") = dr1("lDovizMiktari1")
                        dr("lDovizKuru1") = dr1("lDovizKuru1")
                        dr("sDovizCinsi2") = ""
                        dr("lDovizMiktari2") = 0
                        dr("lDovizKuru2") = 0
                        dr("sCekSenetKodu1") = ""
                        dr("sCekSenetKodu2") = ""
                        dr("sCekSenetTipi") = sec_sCekSenetTipi.EditValue
                        dr("nCekSenetIslem") = sec_nCekSenetIslem.EditValue
                        dr("dteBordroTarihi") = txt_dteBordroTarihi.EditValue
                        dr("lBordroNo") = txt_lBordroNo.EditValue
                        dr("nFirmaID") = nFirmaId
                        dr("sFirmaKodu") = sKodu
                        dr("sKullaniciAdi") = kullaniciadi
                        dr("dteKayitTarihi") = Now
                        dr("bKilitli") = 0
                        Dim sAciklama As String = Microsoft.VisualBasic.Left("B:" + Trim(dr("lBordroNo").ToString) + "\(" + sorgu_sBankaAdi(dr("sBankaKodu")) + ")\Vade:" + dr("dteVadeTarihi") + "\E.N:" + Trim(dr("sOrjinalCekSenetNo")) + "-" + sorgu_sCekSenetIslem(dr("nCekSenetIslem")), 60)
                        dr("nBorcluCariHareketID") = tbFirmaHareketi_kaydet_yeni(dr("nBorcluCariHareketID"), dr("nBorcluFirmaID"), dr("dteBordroTarihi"), dr("dteVadeTarihi"), dr("sCekSenetTipi"), sAciklama, dr("lTutar"), 0, dr("lCekSenetNo"), 0, dr("sCekSenetTipi"), dr("sHareketTipi"), dr("sKullaniciAdi"), dr("dteKayitTarihi"), "", 0, 0, "", 0, 0, kullaniciadi, Now)
                        nCariHareketID_degistir(dr("nBorcluCariHareketID"))
                        'tbCekSenet_kaydet_yeni(dr("nCekSenetID"), dr("sCekSenetTipi"), dr("lCekSenetNo"), dr("sBankaKodu"), dr("lTutar"), dr("dteVadeTarihi"), dr("dteDuzenlemeTarihi"), dr("sIl"), dr("sSemt"), dr("sOrjinalCekSenetNo"), dr("sKarsiTarafCekSenetNo"), dr("nVerenID"), dr("bKendineAit"), dr("sBorclusu"), dr("sBorcluVergiDairesi"), dr("sBorcluVergiNumarasi"), dr("sBankaHesapNo"), dr("sBankaSubeNo"), dr("nSonBordroSatirID"), dr("nSonCekSenetIslem"), dr("sHareketTipi"), dr("sNot"), dr("sKullaniciAdi"), dr("dteKayitTarihi"), dr("sDovizCinsi1"), dr("lDovizMiktari1"), dr("lDovizKuru1"), dr("sDovizCinsi2"), dr("lDovizMiktari2"), dr("lDovizKuru2"), kullaniciadi, Now, dr("sCekSenetKodu1"), dr("sCekSenetKodu2"))
                        dr("nBordroSatirID") = tbCekSenetBordro_kaydet_yeni(dr("nBordroSatirID"), dr("nCekSenetIslem"), dr("nFirmaID"), dr("dteBordroTarihi"), dr("lBordroNo"), dr("nCekSenetID"), dr("nOncekiBordroSatirID"), dr("nOncekiCekSenetIslem"), dr("nCariHareketID"), "", dr("nBorcluFirmaID"), dr("nBorcluCariHareketID"), dr("nProtestoMasrafiFirmaID"), "", dr("lProtestoMasrafi"), dr("dteValorTarihi"), dr("bMuhasebeyeIslendimi"), dr("sKullaniciAdi"), dr("dteKayitTarihi"))
                        'nCekSenetID_degistir(nCekSenetID)
                        nCekSenetID_Odeme_degistir(dr1("nCekSenetID"), dr("nBordroSatirID"), 2)
                        nBordroSatirID_degistir(dr("nBordroSatirID"))
                        ds_tbCekSenet.Tables(0).Rows.Add(dr)
                    Next
                    status = False
                    If GridView1.RowCount > 0 Then
                        GridView1.FocusedRowHandle = GridView1.RowCount - 1
                        GridView1.ClearSelection()
                        GridView1.SelectRow(GridView1.RowCount - 1)
                        PanelControl3.Focus()
                        GridControl1.Focus()
                    End If
                End If
            End If
        End If
        GridView1.FocusedColumn = colsBankaKodu
        satir_kontrol()
    End Sub
    Private Sub satir_ekle_cuzdandantahsil()
        status = True
        Dim frm As New frm_tbCekSenet_liste
        frm.firmano = firmano
        frm.donemno = donemno
        frm.connection = connection
        frm.sCekSenetTipi = sec_sCekSenetTipi.EditValue
        frm.nCekSenetIslem = 1
        frm.txt_ara.Text = sKodu
        frm.sec_konum.Text = "Kodu"
        frm.txt_ara.Enabled = False
        frm.sec_konum.Enabled = False
        frm.islemstatus = True
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
                    dr1 = frm.GridView1.GetDataRow(s)
                    dr = ds_tbCekSenet.Tables(0).NewRow
                    Dim nBordroSatirID As Int64 = sorgu_nBordroSatirID()
                    Dim nCariHareketID = sorgu_nCariHareketID()
                    Dim nCekSenetID = sorgu_nCekSenetID()
                    Dim lCekSenetNo = sorgu_lCekSenetNo(sec_sCekSenetTipi.EditValue)
                    Dim nKasaIslemID = sorgu_nKasaIslemID()
                    dr("nBordroSatirID") = nBordroSatirID
                    dr("nCekSenetID") = dr1("nCekSenetID")
                    dr("lCekSenetNo") = dr1("lCekSenetNo")
                    dr("lTutar") = dr1("lTutar")
                    dr("dteVadeTarihi") = dr1("dteVadeTarihi")
                    dr("sHareketTipi") = dr1("sHareketTipi")
                    dr("sNot") = ""
                    dr("sIl") = ""
                    dr("sSemt") = ""
                    dr("sKarsiTarafCekSenetNo") = ""
                    dr("dteDuzenlemeTarihi") = dr1("dteBordroTarihi")
                    dr("sBankaKodu") = dr1("sBankaKodu")
                    dr("sBankaHesapNo") = dr1("sBankaHesapNo")
                    dr("sBankaSubeNo") = ""
                    dr("sOrjinalCekSenetNo") = dr1("sOrjinalCekSenetNo")
                    dr("nVerenID") = dr1("nVerenID")
                    dr("bKendineAit") = 0
                    dr("sBorclusu") = ""
                    dr("sBorcluVergiDairesi") = ""
                    dr("sBorcluVergiNumarasi") = ""
                    dr("nSonBordroSatirID") = nBordroSatirID
                    dr("nSonCekSenetIslem") = sec_nCekSenetIslem.EditValue
                    dr("nCariHareketID") = 0
                    dr("nKasaIslemID") = nKasaIslemID
                    dr("nBorcluFirmaID") = 0
                    dr("nBorcluCariHareketID") = 0
                    dr("nProtestoMasrafiFirmaID") = 0
                    dr("nProtestoMasrafiCariHareketID") = nKasaIslemID
                    dr("lProtestoMasrafi") = 0
                    dr("nOncekiBordroSatirID") = dr1("nBordroSatirID")
                    dr("nOncekiCekSenetIslem") = 1 'dr1("nSonCekSenetIslem")
                    dr("dteValorTarihi") = dr1("dteVadeTarihi")
                    dr("bMuhasebeyeIslendimi") = 0
                    dr("sDovizCinsi1") = dr1("sDovizCinsi1")
                    dr("lDovizMiktari1") = dr1("lDovizMiktari1")
                    dr("lDovizKuru1") = dr1("lDovizKuru1")
                    dr("sDovizCinsi2") = ""
                    dr("lDovizMiktari2") = 0
                    dr("lDovizKuru2") = 0
                    dr("sCekSenetKodu1") = ""
                    dr("sCekSenetKodu2") = ""
                    dr("sCekSenetTipi") = sec_sCekSenetTipi.EditValue
                    dr("nCekSenetIslem") = sec_nCekSenetIslem.EditValue
                    dr("dteBordroTarihi") = txt_dteBordroTarihi.EditValue
                    dr("lBordroNo") = txt_lBordroNo.EditValue
                    dr("nFirmaID") = nFirmaId
                    dr("sFirmaKodu") = sKodu
                    dr("sKullaniciAdi") = kullaniciadi
                    dr("dteKayitTarihi") = Now
                    dr("bKilitli") = 0
                    Dim sAciklama As String = Microsoft.VisualBasic.Left("B:" + Trim(dr("lBordroNo").ToString) + "\(" + sorgu_sBankaAdi(dr("sBankaKodu")) + ")\Vade:" + dr("dteVadeTarihi") + "\E.N:" + Trim(dr("sOrjinalCekSenetNo")) + "-" + sorgu_sCekSenetIslem(dr("nCekSenetIslem")), 60)
                    nKasaIslemID = tbNakitKasa_kaydet_yeni(dr("nKasaIslemID"), sSubeMagaza, dr("dteBordroTarihi"), dr("lTutar"), 0, sAciklama, 0, dr("nFirmaID"), 0, "AC", dr("sHareketTipi"), kullaniciadi, dr("dteKayitTarihi"), 0, "", "", 0, 0, "", 0, 0, kullaniciadi, dr("dteKayitTarihi"))
                    dr("nKasaIslemID") = nKasaIslemID
                    nKasaIslemID_degistir(nKasaIslemID)
                    'tbFirmaHareketi_kaydet_yeni(dr("nCariHareketID"), dr("nFirmaID"), dr("dteBordroTarihi"), dr("dteVadeTarihi"), dr("sCekSenetTipi"), sAciklama, dr("lTutar"), 0, dr("lCekSenetNo"), 0, dr("sCekSenetTipi"), dr("sHareketTipi"), dr("sKullaniciAdi"), dr("dteKayitTarihi"), "", 0, 0, "", 0, 0, kullaniciadi, Now)
                    'nCariHareketID_degistir(nCariHareketID)
                    'tbCekSenet_kaydet_yeni(dr("nCekSenetID"), dr("sCekSenetTipi"), dr("lCekSenetNo"), dr("sBankaKodu"), dr("lTutar"), dr("dteVadeTarihi"), dr("dteDuzenlemeTarihi"), dr("sIl"), dr("sSemt"), dr("sOrjinalCekSenetNo"), dr("sKarsiTarafCekSenetNo"), dr("nVerenID"), dr("bKendineAit"), dr("sBorclusu"), dr("sBorcluVergiDairesi"), dr("sBorcluVergiNumarasi"), dr("sBankaHesapNo"), dr("sBankaSubeNo"), dr("nSonBordroSatirID"), dr("nSonCekSenetIslem"), dr("sHareketTipi"), dr("sNot"), dr("sKullaniciAdi"), dr("dteKayitTarihi"), dr("sDovizCinsi1"), dr("lDovizMiktari1"), dr("lDovizKuru1"), dr("sDovizCinsi2"), dr("lDovizMiktari2"), dr("lDovizKuru2"), kullaniciadi, Now, dr("sCekSenetKodu1"), dr("sCekSenetKodu2"))
                    dr("nBordroSatirID") = tbCekSenetBordro_kaydet_yeni(dr("nBordroSatirID"), dr("nCekSenetIslem"), dr("nFirmaID"), dr("dteBordroTarihi"), dr("lBordroNo"), dr("nCekSenetID"), dr("nOncekiBordroSatirID"), dr("nOncekiCekSenetIslem"), dr("nCariHareketID"), dr("nKasaIslemID"), dr("nBorcluFirmaID"), dr("nBorcluCariHareketID"), dr("nProtestoMasrafiFirmaID"), "", dr("lProtestoMasrafi"), dr("dteValorTarihi"), dr("bMuhasebeyeIslendimi"), dr("sKullaniciAdi"), dr("dteKayitTarihi"))
                    'nCekSenetID_degistir(nCekSenetID)
                    nCekSenetID_Odeme_degistir(dr1("nCekSenetID"), dr("nBordroSatirID"), 8)
                    nBordroSatirID_degistir(dr("nBordroSatirID"))
                    ds_tbCekSenet.Tables(0).Rows.Add(dr)
                Next
                status = False
                If GridView1.RowCount > 0 Then
                    GridView1.FocusedRowHandle = GridView1.RowCount - 1
                    GridView1.ClearSelection()
                    GridView1.SelectRow(GridView1.RowCount - 1)
                    PanelControl3.Focus()
                    GridControl1.Focus()
                End If
            End If
        End If
        GridView1.FocusedColumn = colsBankaKodu
        satir_kontrol()
    End Sub
    Private Sub satir_ekle_ParcaliTahsilat()
        status = True
        Dim frm As New frm_tbCekSenet_liste
        frm.firmano = firmano
        frm.donemno = donemno
        frm.connection = connection
        frm.sCekSenetTipi = sec_sCekSenetTipi.EditValue
        frm.nCekSenetIslem = 1
        frm.sCekSenetIslem = "'1','11'"
        frm.txt_ara.Text = sKodu
        frm.sec_konum.Text = "Kodu"
        frm.txt_ara.Enabled = False
        frm.sec_konum.Enabled = False
        frm.islemstatus = True
        frm.bCekSenetIslemGoster = True
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
                    dr1 = frm.GridView1.GetDataRow(s)
                    dr = ds_tbCekSenet.Tables(0).NewRow
                    Dim nBordroSatirID As Int64 = sorgu_nBordroSatirID()
                    Dim nCariHareketID = sorgu_nCariHareketID()
                    Dim nCekSenetID = sorgu_nCekSenetID()
                    Dim lCekSenetNo = sorgu_lCekSenetNo(sec_sCekSenetTipi.EditValue)
                    Dim nKasaIslemID = sorgu_nKasaIslemID()
                    dr("nBordroSatirID") = nBordroSatirID
                    dr("nCekSenetID") = dr1("nCekSenetID")
                    dr("lCekSenetNo") = dr1("lCekSenetNo")
                    dr("lTutar") = dr1("lTutar")
                    dr("dteVadeTarihi") = dr1("dteVadeTarihi")
                    dr("sHareketTipi") = dr1("sHareketTipi")
                    dr("sNot") = ""
                    dr("sIl") = ""
                    dr("sSemt") = ""
                    dr("sKarsiTarafCekSenetNo") = ""
                    dr("dteDuzenlemeTarihi") = dr1("dteBordroTarihi")
                    dr("sBankaKodu") = dr1("sBankaKodu")
                    dr("sBankaHesapNo") = dr1("sBankaHesapNo")
                    dr("sBankaSubeNo") = ""
                    dr("sOrjinalCekSenetNo") = dr1("sOrjinalCekSenetNo")
                    dr("nVerenID") = dr1("nVerenID")
                    dr("bKendineAit") = 0
                    dr("sBorclusu") = ""
                    dr("sBorcluVergiDairesi") = ""
                    dr("sBorcluVergiNumarasi") = ""
                    dr("nSonBordroSatirID") = nBordroSatirID
                    dr("nSonCekSenetIslem") = sec_nCekSenetIslem.EditValue
                    dr("nCariHareketID") = 0
                    dr("nKasaIslemID") = nKasaIslemID
                    dr("nBorcluFirmaID") = 0
                    dr("nBorcluCariHareketID") = 0
                    dr("nProtestoMasrafiFirmaID") = 0
                    dr("nProtestoMasrafiCariHareketID") = 0
                    dr("lProtestoMasrafi") = dr1("lKalan")
                    dr("nOncekiBordroSatirID") = dr1("nBordroSatirID")
                    dr("nOncekiCekSenetIslem") = 1 'dr1("nSonCekSenetIslem")
                    dr("dteValorTarihi") = dr1("dteVadeTarihi")
                    dr("bMuhasebeyeIslendimi") = 0
                    dr("sDovizCinsi1") = dr1("sDovizCinsi1")
                    dr("lDovizMiktari1") = dr1("lDovizMiktari1")
                    dr("lDovizKuru1") = dr1("lDovizKuru1")
                    dr("sDovizCinsi2") = ""
                    dr("lDovizMiktari2") = 0
                    dr("lDovizKuru2") = 0
                    dr("sCekSenetKodu1") = ""
                    dr("sCekSenetKodu2") = ""
                    dr("sCekSenetTipi") = sec_sCekSenetTipi.EditValue
                    dr("nCekSenetIslem") = sec_nCekSenetIslem.EditValue
                    dr("dteBordroTarihi") = txt_dteBordroTarihi.EditValue
                    dr("lBordroNo") = txt_lBordroNo.EditValue
                    dr("nFirmaID") = nFirmaId
                    dr("sFirmaKodu") = sKodu
                    dr("sKullaniciAdi") = kullaniciadi
                    dr("dteKayitTarihi") = Now
                    dr("bKilitli") = 0
                    Dim sAciklama As String = Microsoft.VisualBasic.Left("B:" + Trim(dr("lBordroNo").ToString) + "\(" + sorgu_sBankaAdi(dr("sBankaKodu")) + ")\Vade:" + dr("dteVadeTarihi") + "\E.N:" + Trim(dr("sOrjinalCekSenetNo")) + "-" + sorgu_sCekSenetIslem(dr("nCekSenetIslem")), 60)
                    nKasaIslemID = tbNakitKasa_kaydet_yeni(dr("nKasaIslemID"), sSubeMagaza, dr("dteBordroTarihi"), dr1("lKalan"), 0, sAciklama, 0, dr("nFirmaID"), 0, "AC", dr("sHareketTipi"), kullaniciadi, dr("dteKayitTarihi"), 0, "", "", 0, 0, "", 0, 0, kullaniciadi, dr("dteKayitTarihi"))
                    dr("nKasaIslemID") = nKasaIslemID
                    nKasaIslemID_degistir(nKasaIslemID)
                    'tbFirmaHareketi_kaydet_yeni(dr("nCariHareketID"), dr("nFirmaID"), dr("dteBordroTarihi"), dr("dteVadeTarihi"), dr("sCekSenetTipi"), sAciklama, dr("lTutar"), 0, dr("lCekSenetNo"), 0, dr("sCekSenetTipi"), dr("sHareketTipi"), dr("sKullaniciAdi"), dr("dteKayitTarihi"), "", 0, 0, "", 0, 0, kullaniciadi, Now)
                    'nCariHareketID_degistir(nCariHareketID)
                    'tbCekSenet_kaydet_yeni(dr("nCekSenetID"), dr("sCekSenetTipi"), dr("lCekSenetNo"), dr("sBankaKodu"), dr("lTutar"), dr("dteVadeTarihi"), dr("dteDuzenlemeTarihi"), dr("sIl"), dr("sSemt"), dr("sOrjinalCekSenetNo"), dr("sKarsiTarafCekSenetNo"), dr("nVerenID"), dr("bKendineAit"), dr("sBorclusu"), dr("sBorcluVergiDairesi"), dr("sBorcluVergiNumarasi"), dr("sBankaHesapNo"), dr("sBankaSubeNo"), dr("nSonBordroSatirID"), dr("nSonCekSenetIslem"), dr("sHareketTipi"), dr("sNot"), dr("sKullaniciAdi"), dr("dteKayitTarihi"), dr("sDovizCinsi1"), dr("lDovizMiktari1"), dr("lDovizKuru1"), dr("sDovizCinsi2"), dr("lDovizMiktari2"), dr("lDovizKuru2"), kullaniciadi, Now, dr("sCekSenetKodu1"), dr("sCekSenetKodu2"))
                    dr("nBordroSatirID") = tbCekSenetBordro_kaydet_yeni(dr("nBordroSatirID"), dr("nCekSenetIslem"), dr("nFirmaID"), dr("dteBordroTarihi"), dr("lBordroNo"), dr("nCekSenetID"), dr("nOncekiBordroSatirID"), dr("nOncekiCekSenetIslem"), dr("nCariHareketID"), dr("nKasaIslemID"), dr("nBorcluFirmaID"), dr("nBorcluCariHareketID"), dr("nProtestoMasrafiFirmaID"), "", dr("lProtestoMasrafi"), dr("dteValorTarihi"), dr("bMuhasebeyeIslendimi"), dr("sKullaniciAdi"), dr("dteKayitTarihi"))
                    'nCekSenetID_degistir(nCekSenetID)
                    nCekSenetID_Odeme_degistir(dr1("nCekSenetID"), dr("nBordroSatirID"), 8)
                    nBordroSatirID_degistir(dr("nBordroSatirID"))
                    ds_tbCekSenet.Tables(0).Rows.Add(dr)
                Next
                status = False
                If GridView1.RowCount > 0 Then
                    GridView1.FocusedRowHandle = GridView1.RowCount - 1
                    GridView1.ClearSelection()
                    GridView1.SelectRow(GridView1.RowCount - 1)
                    PanelControl3.Focus()
                    GridControl1.Focus()
                End If
            End If
        End If
        GridView1.FocusedColumn = collProtestoMasrafi
        satir_kontrol()
    End Sub
    Private Sub satir_ekle_iade_giris()
        status = True
        Dim frm As New frm_tbCekSenet_liste
        frm.firmano = firmano
        frm.donemno = donemno
        frm.connection = connection
        frm.sCekSenetTipi = sec_sCekSenetTipi.EditValue
        frm.nCekSenetIslem = 5
        frm.sCekSenetIslem = "'3','4','5'"
        frm.txt_ara.Text = sKodu
        frm.sec_konum.Text = "Kodu"
        frm.txt_ara.Enabled = False
        frm.sec_konum.Enabled = False
        frm.bCekSenetIslemGoster = True
        frm.islemstatus = True
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
                    dr1 = frm.GridView1.GetDataRow(s)
                    dr = ds_tbCekSenet.Tables(0).NewRow
                    Dim nBordroSatirID As Int64 = sorgu_nBordroSatirID()
                    Dim nCariHareketID = sorgu_nCariHareketID()
                    Dim nCekSenetID = sorgu_nCekSenetID()
                    Dim lCekSenetNo = sorgu_lCekSenetNo(sec_sCekSenetTipi.EditValue)
                    dr("nBordroSatirID") = nBordroSatirID
                    dr("nCekSenetID") = dr1("nCekSenetID")
                    dr("lCekSenetNo") = dr1("lCekSenetNo")
                    dr("lTutar") = dr1("lTutar")
                    dr("dteVadeTarihi") = dr1("dteVadeTarihi")
                    dr("sHareketTipi") = dr1("sHareketTipi")
                    dr("sNot") = ""
                    dr("sIl") = ""
                    dr("sSemt") = ""
                    dr("sKarsiTarafCekSenetNo") = ""
                    dr("dteDuzenlemeTarihi") = dr1("dteBordroTarihi")
                    dr("sBankaKodu") = dr1("sBankaKodu")
                    dr("sBankaHesapNo") = dr1("sBankaHesapNo")
                    dr("sBankaSubeNo") = ""
                    dr("sOrjinalCekSenetNo") = dr1("sOrjinalCekSenetNo")
                    dr("nVerenID") = dr1("nVerenID")
                    dr("bKendineAit") = 0
                    dr("sBorclusu") = ""
                    dr("sBorcluVergiDairesi") = ""
                    dr("sBorcluVergiNumarasi") = ""
                    dr("nSonBordroSatirID") = nBordroSatirID
                    dr("nSonCekSenetIslem") = dr1("nSonCekSenetIslem")
                    dr("nKasaIslemID") = 0
                    dr("nBorcluFirmaID") = 0
                    dr("nBorcluCariHareketID") = 0
                    dr("nProtestoMasrafiFirmaID") = 0
                    dr("nProtestoMasrafiCariHareketID") = 0
                    dr("lProtestoMasrafi") = 0
                    dr("nOncekiBordroSatirID") = dr1("nBordroSatirID")
                    dr("nOncekiCekSenetIslem") = dr1("nSonCekSenetIslem") 'frm.sec_nCekSenetIslem.EditValue '("nSonCekSenetIslem")
                    dr("dteValorTarihi") = dr1("dteVadeTarihi")
                    dr("bMuhasebeyeIslendimi") = 0
                    dr("sDovizCinsi1") = dr1("sDovizCinsi1")
                    dr("lDovizMiktari1") = dr1("lDovizMiktari1")
                    dr("lDovizKuru1") = dr1("lDovizKuru1")
                    dr("sDovizCinsi2") = dr1("sDovizCinsi2")
                    dr("lDovizMiktari2") = dr1("lDovizMiktari2")
                    dr("lDovizKuru2") = dr1("lDovizKuru2")
                    dr("sCekSenetKodu1") = dr1("sCekSenetKodu1")
                    dr("sCekSenetKodu2") = dr1("sCekSenetKodu2")
                    dr("sCekSenetTipi") = sec_sCekSenetTipi.EditValue
                    dr("nCekSenetIslem") = sec_nCekSenetIslem.EditValue
                    dr("dteBordroTarihi") = txt_dteBordroTarihi.EditValue
                    dr("lBordroNo") = txt_lBordroNo.EditValue
                    dr("nFirmaID") = nFirmaId
                    dr("sFirmaKodu") = sKodu
                    dr("sKullaniciAdi") = kullaniciadi
                    dr("dteKayitTarihi") = Now
                    dr("bKilitli") = 0
                    If dr1("nSonCekSenetIslem") = 3 Or dr1("nSonCekSenetIslem") = 4 Then
                        dr("nCariHareketID") = -1
                    Else
                        dr("nCariHareketID") = nCariHareketID
                        Dim sAciklama As String = Microsoft.VisualBasic.Left(String.Format("B:{0}\({1})\Vade:{2}\E.N:{3}-{4}", Trim(dr("lBordroNo").ToString), sorgu_sBankaAdi(dr("sBankaKodu")), dr("dteVadeTarihi"), Trim(dr("sOrjinalCekSenetNo")), sorgu_sCekSenetIslem(dr("nCekSenetIslem"))), 60)
                        dr("nCariHareketID") = tbFirmaHareketi_kaydet_yeni(dr("nCariHareketID"), dr("nFirmaID"), dr("dteBordroTarihi"), dr("dteVadeTarihi"), dr("sCekSenetTipi"), sAciklama, 0, dr("lTutar"), dr("lCekSenetNo"), 0, dr("sCekSenetTipi"), dr("sHareketTipi"), dr("sKullaniciAdi"), dr("dteKayitTarihi"), "", 0, 0, "", 0, 0, kullaniciadi, Now)
                        nCariHareketID_degistir(dr("nCariHareketID"))
                    End If
                    'tbCekSenet_kaydet_yeni(dr("nCekSenetID"), dr("sCekSenetTipi"), dr("lCekSenetNo"), dr("sBankaKodu"), dr("lTutar"), dr("dteVadeTarihi"), dr("dteDuzenlemeTarihi"), dr("sIl"), dr("sSemt"), dr("sOrjinalCekSenetNo"), dr("sKarsiTarafCekSenetNo"), dr("nVerenID"), dr("bKendineAit"), dr("sBorclusu"), dr("sBorcluVergiDairesi"), dr("sBorcluVergiNumarasi"), dr("sBankaHesapNo"), dr("sBankaSubeNo"), dr("nSonBordroSatirID"), dr("nSonCekSenetIslem"), dr("sHareketTipi"), dr("sNot"), dr("sKullaniciAdi"), dr("dteKayitTarihi"), dr("sDovizCinsi1"), dr("lDovizMiktari1"), dr("lDovizKuru1"), dr("sDovizCinsi2"), dr("lDovizMiktari2"), dr("lDovizKuru2"), kullaniciadi, Now, dr("sCekSenetKodu1"), dr("sCekSenetKodu2"))
                    dr("nBordroSatirID") = tbCekSenetBordro_kaydet_yeni(dr("nBordroSatirID"), dr("nCekSenetIslem"), dr("nFirmaID"), dr("dteBordroTarihi"), dr("lBordroNo"), dr("nCekSenetID"), dr("nOncekiBordroSatirID"), dr("nOncekiCekSenetIslem"), dr("nCariHareketID"), "", dr("nBorcluFirmaID"), dr("nBorcluCariHareketID"), dr("nProtestoMasrafiFirmaID"), "", dr("lProtestoMasrafi"), dr("dteValorTarihi"), dr("bMuhasebeyeIslendimi"), dr("sKullaniciAdi"), dr("dteKayitTarihi"))
                    'nCekSenetID_degistir(nCekSenetID)
                    nCekSenetID_Odeme_degistir(dr1("nCekSenetID"), dr("nBordroSatirID"), 6)
                    nBordroSatirID_degistir(dr("nBordroSatirID"))
                    ds_tbCekSenet.Tables(0).Rows.Add(dr)
                Next
                status = False
                If GridView1.RowCount > 0 Then
                    GridView1.FocusedRowHandle = GridView1.RowCount - 1
                    GridView1.ClearSelection()
                    GridView1.SelectRow(GridView1.RowCount - 1)
                    PanelControl3.Focus()
                    GridControl1.Focus()
                End If
            End If
        End If
        GridView1.FocusedColumn = colsBankaKodu
        satir_kontrol()
    End Sub
    Private Sub satir_ekle_karsiliksiz()
        status = True
        Dim frm As New frm_tbCekSenet_liste
        frm.firmano = firmano
        frm.donemno = donemno
        frm.connection = connection
        frm.sCekSenetTipi = sec_sCekSenetTipi.EditValue
        frm.nCekSenetIslem = 20
        frm.txt_ara.Text = sKodu
        frm.sec_konum.Text = "Kodu"
        frm.txt_ara.Enabled = False
        frm.sec_konum.Enabled = False
        frm.islemstatus = True
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
                    dr1 = frm.GridView1.GetDataRow(s)
                    dr = ds_tbCekSenet.Tables(0).NewRow
                    Dim nBordroSatirID As Int64 = sorgu_nBordroSatirID()
                    Dim nCariHareketID = sorgu_nCariHareketID()
                    Dim nCekSenetID = sorgu_nCekSenetID()
                    Dim lCekSenetNo = sorgu_lCekSenetNo(sec_sCekSenetTipi.EditValue)
                    dr("nBordroSatirID") = nBordroSatirID
                    dr("nCekSenetID") = dr1("nCekSenetID")
                    dr("lCekSenetNo") = dr1("lCekSenetNo")
                    dr("lTutar") = dr1("lTutar")
                    dr("dteVadeTarihi") = dr1("dteVadeTarihi")
                    dr("sHareketTipi") = dr1("sHareketTipi")
                    dr("sNot") = ""
                    dr("sIl") = ""
                    dr("sSemt") = ""
                    dr("sKarsiTarafCekSenetNo") = ""
                    dr("dteDuzenlemeTarihi") = dr1("dteBordroTarihi")
                    dr("sBankaKodu") = dr1("sBankaKodu")
                    dr("sBankaHesapNo") = dr1("sBankaHesapNo")
                    dr("sBankaSubeNo") = ""
                    dr("sOrjinalCekSenetNo") = dr1("sOrjinalCekSenetNo")
                    dr("nVerenID") = dr1("nVerenID")
                    dr("bKendineAit") = 0
                    dr("sBorclusu") = ""
                    dr("sBorcluVergiDairesi") = ""
                    dr("sBorcluVergiNumarasi") = ""
                    dr("nSonBordroSatirID") = nBordroSatirID
                    dr("nSonCekSenetIslem") = sec_nCekSenetIslem.EditValue
                    dr("nCariHareketID") = nCariHareketID
                    dr("nKasaIslemID") = 0
                    dr("nBorcluFirmaID") = 0
                    dr("nBorcluCariHareketID") = 0
                    dr("nProtestoMasrafiFirmaID") = 0
                    dr("nProtestoMasrafiCariHareketID") = 0
                    dr("lProtestoMasrafi") = 0
                    dr("nOncekiBordroSatirID") = dr1("nBordroSatirID")
                    dr("nOncekiCekSenetIslem") = 20
                    dr("dteValorTarihi") = dr1("dteVadeTarihi")
                    dr("bMuhasebeyeIslendimi") = 0
                    dr("sDovizCinsi1") = dr1("sDovizCinsi1")
                    dr("lDovizMiktari1") = dr1("lDovizMiktari1")
                    dr("lDovizKuru1") = dr1("lDovizKuru1")
                    dr("sDovizCinsi2") = ""
                    dr("lDovizMiktari2") = 0
                    dr("lDovizKuru2") = 0
                    dr("sCekSenetKodu1") = ""
                    dr("sCekSenetKodu2") = ""
                    dr("sCekSenetTipi") = sec_sCekSenetTipi.EditValue
                    dr("nCekSenetIslem") = sec_nCekSenetIslem.EditValue
                    dr("dteBordroTarihi") = txt_dteBordroTarihi.EditValue
                    dr("lBordroNo") = txt_lBordroNo.EditValue
                    dr("nFirmaID") = nFirmaId
                    dr("sFirmaKodu") = sKodu
                    dr("sKullaniciAdi") = kullaniciadi
                    dr("dteKayitTarihi") = Now
                    dr("bKilitli") = 0
                    Dim sAciklama As String = Microsoft.VisualBasic.Left(String.Format("B:{0}\({1})\Vade:{2}\E.N:{3}-{4}", Trim(dr("lBordroNo").ToString), sorgu_sBankaAdi(dr("sBankaKodu")), dr("dteVadeTarihi"), Trim(dr("sOrjinalCekSenetNo")), sorgu_sCekSenetIslem(dr("nCekSenetIslem"))), 60)
                    dr("nCariHareketID") = tbFirmaHareketi_kaydet_yeni(dr("nCariHareketID"), dr("nFirmaID"), dr("dteBordroTarihi"), dr("dteVadeTarihi"), dr("sCekSenetTipi"), sAciklama, 0, dr("lTutar"), dr("lCekSenetNo"), 0, dr("sCekSenetTipi"), dr("sHareketTipi"), dr("sKullaniciAdi"), dr("dteKayitTarihi"), "", 0, 0, "", 0, 0, kullaniciadi, Now)
                    nCariHareketID_degistir(dr("nCariHareketID"))
                    'tbCekSenet_kaydet_yeni(dr("nCekSenetID"), dr("sCekSenetTipi"), dr("lCekSenetNo"), dr("sBankaKodu"), dr("lTutar"), dr("dteVadeTarihi"), dr("dteDuzenlemeTarihi"), dr("sIl"), dr("sSemt"), dr("sOrjinalCekSenetNo"), dr("sKarsiTarafCekSenetNo"), dr("nVerenID"), dr("bKendineAit"), dr("sBorclusu"), dr("sBorcluVergiDairesi"), dr("sBorcluVergiNumarasi"), dr("sBankaHesapNo"), dr("sBankaSubeNo"), dr("nSonBordroSatirID"), dr("nSonCekSenetIslem"), dr("sHareketTipi"), dr("sNot"), dr("sKullaniciAdi"), dr("dteKayitTarihi"), dr("sDovizCinsi1"), dr("lDovizMiktari1"), dr("lDovizKuru1"), dr("sDovizCinsi2"), dr("lDovizMiktari2"), dr("lDovizKuru2"), kullaniciadi, Now, dr("sCekSenetKodu1"), dr("sCekSenetKodu2"))
                    dr("nBordroSatirID") = tbCekSenetBordro_kaydet_yeni(dr("nBordroSatirID"), dr("nCekSenetIslem"), dr("nFirmaID"), dr("dteBordroTarihi"), dr("lBordroNo"), dr("nCekSenetID"), dr("nOncekiBordroSatirID"), dr("nOncekiCekSenetIslem"), dr("nCariHareketID"), "", dr("nBorcluFirmaID"), dr("nBorcluCariHareketID"), dr("nProtestoMasrafiFirmaID"), "", dr("lProtestoMasrafi"), dr("dteValorTarihi"), dr("bMuhasebeyeIslendimi"), dr("sKullaniciAdi"), dr("dteKayitTarihi"))
                    'nCekSenetID_degistir(nCekSenetID)
                    nCekSenetID_Odeme_degistir(dr1("nCekSenetID"), dr("nBordroSatirID"), 23)
                    nBordroSatirID_degistir(dr("nBordroSatirID"))
                    ds_tbCekSenet.Tables(0).Rows.Add(dr)
                Next
                status = False
                If GridView1.RowCount > 0 Then
                    GridView1.FocusedRowHandle = GridView1.RowCount - 1
                    GridView1.ClearSelection()
                    GridView1.SelectRow(GridView1.RowCount - 1)
                    PanelControl3.Focus()
                    GridControl1.Focus()
                End If
            End If
        End If
        GridView1.FocusedColumn = colsBankaKodu
        satir_kontrol()
    End Sub
    Private Sub satir_ekle_ciro()
        status = True
        Dim frm As New frm_tbCekSenet_liste
        frm.firmano = firmano
        frm.donemno = donemno
        frm.connection = connection
        frm.sCekSenetTipi = sec_sCekSenetTipi.EditValue
        frm.nCekSenetIslem = 1
        frm.sCekSenetIslem = "'1','6'"
        frm.txt_ara.Text = ""
        frm.sec_konum.Text = "Kodu"
        frm.txt_ara.Enabled = True
        frm.sec_konum.Enabled = False
        frm.bCekSenetIslemGoster = True
        frm.islemstatus = True
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
                    dr1 = frm.GridView1.GetDataRow(s)
                    dr = ds_tbCekSenet.Tables(0).NewRow
                    Dim nBordroSatirID As Int64 = sorgu_nBordroSatirID()
                    Dim nCariHareketID = sorgu_nCariHareketID()
                    Dim nCekSenetID = sorgu_nCekSenetID()
                    Dim lCekSenetNo = sorgu_lCekSenetNo(sec_sCekSenetTipi.EditValue)
                    dr("nBordroSatirID") = nBordroSatirID
                    dr("nCekSenetID") = dr1("nCekSenetID")
                    dr("lCekSenetNo") = dr1("lCekSenetNo")
                    dr("lTutar") = dr1("lTutar")
                    dr("dteVadeTarihi") = dr1("dteVadeTarihi")
                    dr("sHareketTipi") = dr1("sHareketTipi")
                    dr("sNot") = dr1("sNot")
                    dr("sIl") = dr1("sIl")
                    dr("sSemt") = dr1("sSemt")
                    dr("sKarsiTarafCekSenetNo") = ""
                    dr("dteDuzenlemeTarihi") = dr1("dteBordroTarihi")
                    dr("sBankaKodu") = dr1("sBankaKodu")
                    dr("sBankaHesapNo") = dr1("sBankaHesapNo")
                    dr("sBankaSubeNo") = ""
                    dr("sOrjinalCekSenetNo") = dr1("sOrjinalCekSenetNo")
                    dr("nVerenID") = dr1("nVerenID")
                    dr("bKendineAit") = 0
                    dr("sBorclusu") = dr1("sBorclusu")
                    dr("sBorcluVergiDairesi") = dr1("sBorcluVergiDairesi")
                    dr("sBorcluVergiNumarasi") = dr1("sBorcluVergiNumarasi")
                    dr("nSonBordroSatirID") = nBordroSatirID
                    dr("nSonCekSenetIslem") = sec_nCekSenetIslem.EditValue
                    dr("nCariHareketID") = nCariHareketID
                    dr("nKasaIslemID") = 0
                    dr("nBorcluFirmaID") = 0
                    dr("nBorcluCariHareketID") = 0
                    dr("nProtestoMasrafiFirmaID") = 0
                    dr("nProtestoMasrafiCariHareketID") = 0
                    dr("lProtestoMasrafi") = 0
                    dr("nOncekiBordroSatirID") = dr1("nBordroSatirID")
                    dr("nOncekiCekSenetIslem") = 1
                    dr("dteValorTarihi") = dr1("dteVadeTarihi")
                    dr("bMuhasebeyeIslendimi") = 0
                    dr("sDovizCinsi1") = dr1("sDovizCinsi1")
                    dr("lDovizMiktari1") = dr1("lDovizMiktari1")
                    dr("lDovizKuru1") = dr1("lDovizKuru1")
                    dr("sDovizCinsi2") = ""
                    dr("lDovizMiktari2") = 0
                    dr("lDovizKuru2") = 0
                    dr("sCekSenetKodu1") = ""
                    dr("sCekSenetKodu2") = ""
                    dr("sCekSenetTipi") = sec_sCekSenetTipi.EditValue
                    dr("nCekSenetIslem") = sec_nCekSenetIslem.EditValue
                    dr("dteBordroTarihi") = txt_dteBordroTarihi.EditValue
                    dr("lBordroNo") = txt_lBordroNo.EditValue
                    dr("nFirmaID") = nFirmaId
                    dr("sFirmaKodu") = sKodu
                    dr("sKullaniciAdi") = kullaniciadi
                    dr("dteKayitTarihi") = Now
                    dr("bKilitli") = 0
                    Dim sAciklama As String = Microsoft.VisualBasic.Left(String.Format("B:{0}\({1})\Vade:{2}\E.N:{3}-{4}", Trim(dr("lBordroNo").ToString), sorgu_sBankaAdi(dr("sBankaKodu")), dr("dteVadeTarihi"), Trim(dr("sOrjinalCekSenetNo")), sorgu_sCekSenetIslem(dr("nCekSenetIslem"))), 60)
                    dr("nCariHareketID") = tbFirmaHareketi_kaydet_yeni(dr("nCariHareketID"), dr("nFirmaID"), dr("dteBordroTarihi"), dr("dteVadeTarihi"), dr("sCekSenetTipi"), sAciklama, dr("lTutar"), 0, dr("lCekSenetNo"), 0, dr("sCekSenetTipi"), dr("sHareketTipi"), dr("sKullaniciAdi"), dr("dteKayitTarihi"), "", 0, 0, "", 0, 0, kullaniciadi, Now)
                    nCariHareketID_degistir(dr("nCariHareketID"))
                    'tbCekSenet_kaydet_yeni(dr("nCekSenetID"), dr("sCekSenetTipi"), dr("lCekSenetNo"), dr("sBankaKodu"), dr("lTutar"), dr("dteVadeTarihi"), dr("dteDuzenlemeTarihi"), dr("sIl"), dr("sSemt"), dr("sOrjinalCekSenetNo"), dr("sKarsiTarafCekSenetNo"), dr("nVerenID"), dr("bKendineAit"), dr("sBorclusu"), dr("sBorcluVergiDairesi"), dr("sBorcluVergiNumarasi"), dr("sBankaHesapNo"), dr("sBankaSubeNo"), dr("nSonBordroSatirID"), dr("nSonCekSenetIslem"), dr("sHareketTipi"), dr("sNot"), dr("sKullaniciAdi"), dr("dteKayitTarihi"), dr("sDovizCinsi1"), dr("lDovizMiktari1"), dr("lDovizKuru1"), dr("sDovizCinsi2"), dr("lDovizMiktari2"), dr("lDovizKuru2"), kullaniciadi, Now, dr("sCekSenetKodu1"), dr("sCekSenetKodu2"))
                    dr("nBordroSatirID") = tbCekSenetBordro_kaydet_yeni(dr("nBordroSatirID"), dr("nCekSenetIslem"), dr("nFirmaID"), dr("dteBordroTarihi"), dr("lBordroNo"), dr("nCekSenetID"), dr("nOncekiBordroSatirID"), dr("nOncekiCekSenetIslem"), dr("nCariHareketID"), "", dr("nBorcluFirmaID"), dr("nBorcluCariHareketID"), dr("nProtestoMasrafiFirmaID"), "", dr("lProtestoMasrafi"), dr("dteValorTarihi"), dr("bMuhasebeyeIslendimi"), dr("sKullaniciAdi"), dr("dteKayitTarihi"))
                    'nCekSenetID_degistir(nCekSenetID)
                    nCekSenetID_Odeme_degistir(dr1("nCekSenetID"), dr("nBordroSatirID"), sec_nCekSenetIslem.EditValue)
                    nBordroSatirID_degistir(dr("nBordroSatirID"))
                    ds_tbCekSenet.Tables(0).Rows.Add(dr)
                Next
                status = False
                If GridView1.RowCount > 0 Then
                    GridView1.FocusedRowHandle = GridView1.RowCount - 1
                    GridView1.ClearSelection()
                    GridView1.SelectRow(GridView1.RowCount - 1)
                    PanelControl3.Focus()
                    GridControl1.Focus()
                End If
            End If
        End If
        GridView1.FocusedColumn = colsBankaKodu
        satir_kontrol()
    End Sub
    Private Sub satir_ekle_bankadantahsil()
        status = True
        Dim frm As New frm_tbCekSenet_liste
        frm.firmano = firmano
        frm.donemno = donemno
        frm.connection = connection
        frm.sCekSenetTipi = sec_sCekSenetTipi.EditValue
        frm.nCekSenetIslem = 3
        frm.txt_ara.Text = sKodu
        frm.sec_konum.Text = "Kodu"
        frm.txt_ara.Enabled = False
        frm.sec_konum.Enabled = False
        frm.islemstatus = True
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
                    dr1 = frm.GridView1.GetDataRow(s)
                    dr = ds_tbCekSenet.Tables(0).NewRow
                    Dim nBordroSatirID As Int64 = sorgu_nBordroSatirID()
                    Dim nCariHareketID = sorgu_nCariHareketID()
                    Dim nCekSenetID = sorgu_nCekSenetID()
                    Dim lCekSenetNo = sorgu_lCekSenetNo(sec_sCekSenetTipi.EditValue)
                    dr("nBordroSatirID") = nBordroSatirID
                    dr("nCekSenetID") = dr1("nCekSenetID")
                    dr("lCekSenetNo") = dr1("lCekSenetNo")
                    dr("lTutar") = dr1("lTutar")
                    dr("dteVadeTarihi") = dr1("dteVadeTarihi")
                    dr("sHareketTipi") = dr1("sHareketTipi")
                    dr("sNot") = dr1("sNot")
                    dr("sIl") = dr1("sIl")
                    dr("sSemt") = dr1("sSemt")
                    dr("sKarsiTarafCekSenetNo") = ""
                    dr("dteDuzenlemeTarihi") = dr1("dteBordroTarihi")
                    dr("sBankaKodu") = dr1("sBankaKodu")
                    dr("sBankaHesapNo") = dr1("sBankaHesapNo")
                    dr("sBankaSubeNo") = ""
                    dr("sOrjinalCekSenetNo") = dr1("sOrjinalCekSenetNo")
                    dr("nVerenID") = dr1("nVerenID")
                    dr("bKendineAit") = 0
                    dr("sBorclusu") = dr1("sBorclusu")
                    dr("sBorcluVergiDairesi") = dr1("sBorcluVergiDairesi")
                    dr("sBorcluVergiNumarasi") = dr1("sBorcluVergiNumarasi")
                    dr("nSonBordroSatirID") = nBordroSatirID
                    dr("nSonCekSenetIslem") = sec_nCekSenetIslem.EditValue
                    dr("nCariHareketID") = nCariHareketID
                    dr("nKasaIslemID") = 0
                    dr("nBorcluFirmaID") = nFirmaId
                    dr("nBorcluCariHareketID") = 0
                    dr("nProtestoMasrafiFirmaID") = 0
                    dr("nProtestoMasrafiCariHareketID") = 0
                    dr("lProtestoMasrafi") = 0
                    dr("nOncekiBordroSatirID") = dr1("nBordroSatirID")
                    dr("nOncekiCekSenetIslem") = 3
                    dr("dteValorTarihi") = dr1("dteVadeTarihi")
                    dr("bMuhasebeyeIslendimi") = 0
                    dr("sDovizCinsi1") = dr1("sDovizCinsi1")
                    dr("lDovizMiktari1") = dr1("lDovizMiktari1")
                    dr("lDovizKuru1") = dr1("lDovizKuru1")
                    dr("sDovizCinsi2") = ""
                    dr("lDovizMiktari2") = 0
                    dr("lDovizKuru2") = 0
                    dr("sCekSenetKodu1") = ""
                    dr("sCekSenetKodu2") = ""
                    dr("sCekSenetTipi") = sec_sCekSenetTipi.EditValue
                    dr("nCekSenetIslem") = sec_nCekSenetIslem.EditValue
                    dr("dteBordroTarihi") = txt_dteBordroTarihi.EditValue
                    dr("lBordroNo") = txt_lBordroNo.EditValue
                    dr("nFirmaID") = nFirmaId
                    dr("sFirmaKodu") = sKodu
                    dr("sKullaniciAdi") = kullaniciadi
                    dr("dteKayitTarihi") = Now
                    dr("bKilitli") = 0
                    Dim sAciklama As String = Microsoft.VisualBasic.Left("B:" + Trim(dr("lBordroNo").ToString) + "\(" + sorgu_sBankaAdi(dr("sBankaKodu")) + ")\Vade:" + dr("dteVadeTarihi") + "\E.N:" + Trim(dr("sOrjinalCekSenetNo")) + "-" + sorgu_sCekSenetIslem(dr("nCekSenetIslem")), 60)
                    dr("nCariHareketID") = tbFirmaHareketi_kaydet_yeni(dr("nCariHareketID"), dr("nFirmaID"), dr("dteBordroTarihi"), dr("dteVadeTarihi"), dr("sCekSenetTipi"), sAciklama, dr("lTutar"), 0, dr("lCekSenetNo"), 0, dr("sCekSenetTipi"), dr("sHareketTipi"), dr("sKullaniciAdi"), dr("dteKayitTarihi"), "", 0, 0, "", 0, 0, kullaniciadi, Now)
                    nCariHareketID_degistir(dr("nCariHareketID"))
                    'tbCekSenet_kaydet_yeni(dr("nCekSenetID"), dr("sCekSenetTipi"), dr("lCekSenetNo"), dr("sBankaKodu"), dr("lTutar"), dr("dteVadeTarihi"), dr("dteDuzenlemeTarihi"), dr("sIl"), dr("sSemt"), dr("sOrjinalCekSenetNo"), dr("sKarsiTarafCekSenetNo"), dr("nVerenID"), dr("bKendineAit"), dr("sBorclusu"), dr("sBorcluVergiDairesi"), dr("sBorcluVergiNumarasi"), dr("sBankaHesapNo"), dr("sBankaSubeNo"), dr("nSonBordroSatirID"), dr("nSonCekSenetIslem"), dr("sHareketTipi"), dr("sNot"), dr("sKullaniciAdi"), dr("dteKayitTarihi"), dr("sDovizCinsi1"), dr("lDovizMiktari1"), dr("lDovizKuru1"), dr("sDovizCinsi2"), dr("lDovizMiktari2"), dr("lDovizKuru2"), kullaniciadi, Now, dr("sCekSenetKodu1"), dr("sCekSenetKodu2"))
                    dr("nBordroSatirID") = tbCekSenetBordro_kaydet_yeni(dr("nBordroSatirID"), dr("nCekSenetIslem"), dr("nFirmaID"), dr("dteBordroTarihi"), dr("lBordroNo"), dr("nCekSenetID"), dr("nOncekiBordroSatirID"), dr("nOncekiCekSenetIslem"), dr("nCariHareketID"), "", dr("nBorcluFirmaID"), dr("nBorcluCariHareketID"), dr("nProtestoMasrafiFirmaID"), "", dr("lProtestoMasrafi"), dr("dteValorTarihi"), dr("bMuhasebeyeIslendimi"), dr("sKullaniciAdi"), dr("dteKayitTarihi"))
                    'nCekSenetID_degistir(nCekSenetID)
                    nCekSenetID_Odeme_degistir(dr1("nCekSenetID"), dr("nBordroSatirID"), sec_nCekSenetIslem.EditValue)
                    nBordroSatirID_degistir(dr("nBordroSatirID"))
                    ds_tbCekSenet.Tables(0).Rows.Add(dr)
                Next
                status = False
                If GridView1.RowCount > 0 Then
                    GridView1.FocusedRowHandle = GridView1.RowCount - 1
                    GridView1.ClearSelection()
                    GridView1.SelectRow(GridView1.RowCount - 1)
                    PanelControl3.Focus()
                    GridControl1.Focus()
                End If
            End If
        End If
        GridView1.FocusedColumn = colsBankaKodu
        satir_kontrol()
    End Sub
    Private Sub satir_ekle_takas()
        status = True
        Dim frm As New frm_tbCekSenet_liste
        frm.firmano = firmano
        frm.donemno = donemno
        frm.connection = connection
        frm.sCekSenetTipi = sec_sCekSenetTipi.EditValue
        frm.sCekSenetIslem = "'1','6'"
        frm.nCekSenetIslem = 1
        frm.bCekSenetIslemGoster = True
        frm.islemstatus = True
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
                    dr1 = frm.GridView1.GetDataRow(s)
                    dr = ds_tbCekSenet.Tables(0).NewRow
                    Dim nBordroSatirID As Int64 = sorgu_nBordroSatirID()
                    Dim nCariHareketID = 0 'sorgu_nCariHareketID()
                    Dim nCekSenetID = sorgu_nCekSenetID()
                    Dim lCekSenetNo = sorgu_lCekSenetNo(sec_sCekSenetTipi.EditValue)
                    dr("nBordroSatirID") = nBordroSatirID
                    dr("nCekSenetID") = dr1("nCekSenetID")
                    dr("lCekSenetNo") = dr1("lCekSenetNo")
                    dr("lTutar") = dr1("lTutar")
                    dr("dteVadeTarihi") = dr1("dteVadeTarihi")
                    dr("sHareketTipi") = dr1("sHareketTipi")
                    dr("sNot") = dr1("sNot")
                    dr("sIl") = dr1("sIl")
                    dr("sSemt") = dr1("sSemt")
                    dr("sKarsiTarafCekSenetNo") = ""
                    dr("dteDuzenlemeTarihi") = dr1("dteBordroTarihi")
                    dr("sBankaKodu") = dr1("sBankaKodu")
                    dr("sBankaHesapNo") = dr1("sBankaHesapNo")
                    dr("sBankaSubeNo") = ""
                    dr("sOrjinalCekSenetNo") = dr1("sOrjinalCekSenetNo")
                    dr("nVerenID") = dr1("nVerenID")
                    dr("bKendineAit") = 0
                    dr("sBorclusu") = dr1("sBorclusu")
                    dr("sBorcluVergiDairesi") = dr1("sBorcluVergiDairesi")
                    dr("sBorcluVergiNumarasi") = dr1("sBorcluVergiNumarasi")
                    dr("nSonBordroSatirID") = nBordroSatirID
                    dr("nSonCekSenetIslem") = sec_nCekSenetIslem.EditValue
                    dr("nCariHareketID") = nCariHareketID
                    dr("nKasaIslemID") = 0
                    dr("nBorcluFirmaID") = 0
                    dr("nBorcluCariHareketID") = 0
                    dr("nProtestoMasrafiFirmaID") = 0
                    dr("nProtestoMasrafiCariHareketID") = 0
                    dr("lProtestoMasrafi") = 0
                    dr("nOncekiBordroSatirID") = dr1("nBordroSatirID")
                    dr("nOncekiCekSenetIslem") = 1
                    dr("dteValorTarihi") = dr1("dteVadeTarihi")
                    dr("bMuhasebeyeIslendimi") = 0
                    dr("sDovizCinsi1") = dr1("sDovizCinsi1")
                    dr("lDovizMiktari1") = dr1("lDovizMiktari1")
                    dr("lDovizKuru1") = dr1("lDovizKuru1")
                    dr("sDovizCinsi2") = ""
                    dr("lDovizMiktari2") = 0
                    dr("lDovizKuru2") = 0
                    dr("sCekSenetKodu1") = ""
                    dr("sCekSenetKodu2") = ""
                    dr("sCekSenetTipi") = sec_sCekSenetTipi.EditValue
                    dr("nCekSenetIslem") = sec_nCekSenetIslem.EditValue
                    dr("dteBordroTarihi") = txt_dteBordroTarihi.EditValue
                    dr("lBordroNo") = txt_lBordroNo.EditValue
                    dr("nFirmaID") = nFirmaId
                    dr("sFirmaKodu") = sKodu
                    dr("sKullaniciAdi") = kullaniciadi
                    dr("dteKayitTarihi") = Now
                    dr("bKilitli") = 0
                    Dim sAciklama As String = Microsoft.VisualBasic.Left("B:" + Trim(dr("lBordroNo").ToString) + "\(" + sorgu_sBankaAdi(dr("sBankaKodu")) + ")\Vade:" + dr("dteVadeTarihi") + "\E.N:" + Trim(dr("sOrjinalCekSenetNo")) + "-" + sorgu_sCekSenetIslem(dr("nCekSenetIslem")), 60)
                    'tbFirmaHareketi_kaydet_yeni(dr("nCariHareketID"), dr("nFirmaID"), dr("dteBordroTarihi"), dr("dteVadeTarihi"), dr("sCekSenetTipi"), sAciklama, dr("lTutar"), 0, dr("lCekSenetNo"), 0, dr("sCekSenetTipi"), dr("sHareketTipi"), dr("sKullaniciAdi"), dr("dteKayitTarihi"), "", 0, 0, "", 0, 0, kullaniciadi, Now)
                    'nCariHareketID_degistir(nCariHareketID)
                    'tbCekSenet_kaydet_yeni(dr("nCekSenetID"), dr("sCekSenetTipi"), dr("lCekSenetNo"), dr("sBankaKodu"), dr("lTutar"), dr("dteVadeTarihi"), dr("dteDuzenlemeTarihi"), dr("sIl"), dr("sSemt"), dr("sOrjinalCekSenetNo"), dr("sKarsiTarafCekSenetNo"), dr("nVerenID"), dr("bKendineAit"), dr("sBorclusu"), dr("sBorcluVergiDairesi"), dr("sBorcluVergiNumarasi"), dr("sBankaHesapNo"), dr("sBankaSubeNo"), dr("nSonBordroSatirID"), dr("nSonCekSenetIslem"), dr("sHareketTipi"), dr("sNot"), dr("sKullaniciAdi"), dr("dteKayitTarihi"), dr("sDovizCinsi1"), dr("lDovizMiktari1"), dr("lDovizKuru1"), dr("sDovizCinsi2"), dr("lDovizMiktari2"), dr("lDovizKuru2"), kullaniciadi, Now, dr("sCekSenetKodu1"), dr("sCekSenetKodu2"))
                    dr("nBordroSatirID") = tbCekSenetBordro_kaydet_yeni(dr("nBordroSatirID"), dr("nCekSenetIslem"), dr("nFirmaID"), dr("dteBordroTarihi"), dr("lBordroNo"), dr("nCekSenetID"), dr("nOncekiBordroSatirID"), dr("nOncekiCekSenetIslem"), dr("nCariHareketID"), "", dr("nBorcluFirmaID"), dr("nBorcluCariHareketID"), dr("nProtestoMasrafiFirmaID"), "", dr("lProtestoMasrafi"), dr("dteValorTarihi"), dr("bMuhasebeyeIslendimi"), dr("sKullaniciAdi"), dr("dteKayitTarihi"))
                    'nCekSenetID_degistir(nCekSenetID)
                    nCekSenetID_Odeme_degistir(dr1("nCekSenetID"), dr("nBordroSatirID"), sec_nCekSenetIslem.EditValue)
                    nBordroSatirID_degistir(dr("nBordroSatirID"))
                    ds_tbCekSenet.Tables(0).Rows.Add(dr)
                Next
                status = False
                If GridView1.RowCount > 0 Then
                    GridView1.FocusedRowHandle = GridView1.RowCount - 1
                    GridView1.ClearSelection()
                    GridView1.SelectRow(GridView1.RowCount - 1)
                    PanelControl3.Focus()
                    GridControl1.Focus()
                End If
            End If
        End If
        GridView1.FocusedColumn = colsBankaKodu
        satir_kontrol()
    End Sub
    Private Sub satir_ekle_sahistantahsil()
        status = True
        Dim frm As New frm_tbCekSenet_liste
        frm.firmano = firmano
        frm.donemno = donemno
        frm.connection = connection
        frm.sCekSenetTipi = sec_sCekSenetTipi.EditValue
        frm.nCekSenetIslem = 5
        frm.txt_ara.Text = sKodu
        frm.sec_konum.Text = "Kodu"
        frm.txt_ara.Enabled = False
        frm.sec_konum.Enabled = False
        frm.islemstatus = True
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
                    dr1 = frm.GridView1.GetDataRow(s)
                    dr = ds_tbCekSenet.Tables(0).NewRow
                    Dim nBordroSatirID As Int64 = sorgu_nBordroSatirID()
                    Dim nCariHareketID = 0 'sorgu_nCariHareketID()
                    Dim nCekSenetID = sorgu_nCekSenetID()
                    Dim lCekSenetNo = sorgu_lCekSenetNo(sec_sCekSenetTipi.EditValue)
                    dr("nBordroSatirID") = nBordroSatirID
                    dr("nCekSenetID") = dr1("nCekSenetID")
                    dr("lCekSenetNo") = dr1("lCekSenetNo")
                    dr("lTutar") = dr1("lTutar")
                    dr("dteVadeTarihi") = dr1("dteVadeTarihi")
                    dr("sHareketTipi") = dr1("sHareketTipi")
                    dr("sNot") = dr1("sNot")
                    dr("sIl") = dr1("sIl")
                    dr("sSemt") = dr1("sSemt")
                    dr("sKarsiTarafCekSenetNo") = ""
                    dr("dteDuzenlemeTarihi") = dr1("dteBordroTarihi")
                    dr("sBankaKodu") = dr1("sBankaKodu")
                    dr("sBankaHesapNo") = dr1("sBankaHesapNo")
                    dr("sBankaSubeNo") = ""
                    dr("sOrjinalCekSenetNo") = dr1("sOrjinalCekSenetNo")
                    dr("nVerenID") = dr1("nVerenID")
                    dr("bKendineAit") = 0
                    dr("sBorclusu") = dr1("sBorclusu")
                    dr("sBorcluVergiDairesi") = dr1("sBorcluVergiDairesi")
                    dr("sBorcluVergiNumarasi") = dr1("sBorcluVergiNumarasi")
                    dr("nSonBordroSatirID") = nBordroSatirID
                    dr("nSonCekSenetIslem") = sec_nCekSenetIslem.EditValue
                    dr("nCariHareketID") = nCariHareketID
                    dr("nKasaIslemID") = 0
                    dr("nBorcluFirmaID") = 0
                    dr("nBorcluCariHareketID") = 0
                    dr("nProtestoMasrafiFirmaID") = 0
                    dr("nProtestoMasrafiCariHareketID") = 0
                    dr("lProtestoMasrafi") = 0
                    dr("nOncekiBordroSatirID") = dr1("nBordroSatirID")
                    dr("nOncekiCekSenetIslem") = 1
                    dr("dteValorTarihi") = dr1("dteVadeTarihi")
                    dr("bMuhasebeyeIslendimi") = 0
                    dr("sDovizCinsi1") = dr1("sDovizCinsi1")
                    dr("lDovizMiktari1") = dr1("lDovizMiktari1")
                    dr("lDovizKuru1") = dr1("lDovizKuru1")
                    dr("sDovizCinsi2") = ""
                    dr("lDovizMiktari2") = 0
                    dr("lDovizKuru2") = 0
                    dr("sCekSenetKodu1") = ""
                    dr("sCekSenetKodu2") = ""
                    dr("sCekSenetTipi") = sec_sCekSenetTipi.EditValue
                    dr("nCekSenetIslem") = sec_nCekSenetIslem.EditValue
                    dr("dteBordroTarihi") = txt_dteBordroTarihi.EditValue
                    dr("lBordroNo") = txt_lBordroNo.EditValue
                    dr("nFirmaID") = nFirmaId
                    dr("sFirmaKodu") = sKodu
                    dr("sKullaniciAdi") = kullaniciadi
                    dr("dteKayitTarihi") = Now
                    dr("bKilitli") = 0
                    Dim sAciklama As String = Microsoft.VisualBasic.Left("B:" + Trim(dr("lBordroNo").ToString) + "\(" + sorgu_sBankaAdi(dr("sBankaKodu")) + ")\Vade:" + dr("dteVadeTarihi") + "\E.N:" + Trim(dr("sOrjinalCekSenetNo")) + "-" + sorgu_sCekSenetIslem(dr("nCekSenetIslem")), 60)
                    'tbFirmaHareketi_kaydet_yeni(dr("nCariHareketID"), dr("nFirmaID"), dr("dteBordroTarihi"), dr("dteVadeTarihi"), dr("sCekSenetTipi"), sAciklama, dr("lTutar"), 0, dr("lCekSenetNo"), 0, dr("sCekSenetTipi"), dr("sHareketTipi"), dr("sKullaniciAdi"), dr("dteKayitTarihi"), "", 0, 0, "", 0, 0, kullaniciadi, Now)
                    'nCariHareketID_degistir(nCariHareketID)
                    'tbCekSenet_kaydet_yeni(dr("nCekSenetID"), dr("sCekSenetTipi"), dr("lCekSenetNo"), dr("sBankaKodu"), dr("lTutar"), dr("dteVadeTarihi"), dr("dteDuzenlemeTarihi"), dr("sIl"), dr("sSemt"), dr("sOrjinalCekSenetNo"), dr("sKarsiTarafCekSenetNo"), dr("nVerenID"), dr("bKendineAit"), dr("sBorclusu"), dr("sBorcluVergiDairesi"), dr("sBorcluVergiNumarasi"), dr("sBankaHesapNo"), dr("sBankaSubeNo"), dr("nSonBordroSatirID"), dr("nSonCekSenetIslem"), dr("sHareketTipi"), dr("sNot"), dr("sKullaniciAdi"), dr("dteKayitTarihi"), dr("sDovizCinsi1"), dr("lDovizMiktari1"), dr("lDovizKuru1"), dr("sDovizCinsi2"), dr("lDovizMiktari2"), dr("lDovizKuru2"), kullaniciadi, Now, dr("sCekSenetKodu1"), dr("sCekSenetKodu2"))
                    dr("nBordroSatirID") = tbCekSenetBordro_kaydet_yeni(dr("nBordroSatirID"), dr("nCekSenetIslem"), dr("nFirmaID"), dr("dteBordroTarihi"), dr("lBordroNo"), dr("nCekSenetID"), dr("nOncekiBordroSatirID"), dr("nOncekiCekSenetIslem"), dr("nCariHareketID"), "", dr("nBorcluFirmaID"), dr("nBorcluCariHareketID"), dr("nProtestoMasrafiFirmaID"), "", dr("lProtestoMasrafi"), dr("dteValorTarihi"), dr("bMuhasebeyeIslendimi"), dr("sKullaniciAdi"), dr("dteKayitTarihi"))
                    'nCekSenetID_degistir(nCekSenetID)
                    nCekSenetID_Odeme_degistir(dr1("nCekSenetID"), dr("nBordroSatirID"), sec_nCekSenetIslem.EditValue)
                    nBordroSatirID_degistir(dr("nBordroSatirID"))
                    ds_tbCekSenet.Tables(0).Rows.Add(dr)
                Next
                status = False
                If GridView1.RowCount > 0 Then
                    GridView1.FocusedRowHandle = GridView1.RowCount - 1
                    GridView1.ClearSelection()
                    GridView1.SelectRow(GridView1.RowCount - 1)
                    PanelControl3.Focus()
                    GridControl1.Focus()
                End If
            End If
        End If
        GridView1.FocusedColumn = colsBankaKodu
        satir_kontrol()
    End Sub
    Private Sub satir_sil()
        If GridView1.RowCount > 0 Then
            If XtraMessageBox.Show(Sorgu_sDil("Satýrý Silmek Ýstediðinize Emin misiniz...?", sDil), Sorgu_sDil("Dikkat", sDil), MessageBoxButtons.YesNo, MessageBoxIcon.Question) = MsgBoxResult.Yes Then
                Dim dr As DataRow
                dr = GridView1.GetDataRow(GridView1.FocusedRowHandle)
                Dim dr1 As DataRow
                Dim ds_SonHareket As DataSet = sorgu(sorgu_query("SELECT     TOP 1 nCekSenetIslem, nBordroSatirID FROM         tbCekSenetBordro WHERE     (nCekSenetID = " & dr("nCekSenetID") & ") ORDER BY nBordroSatirID DESC"))
                For Each dr1 In ds_SonHareket.Tables(0).Rows
                    dr("nSonCekSenetIslem") = dr1("nCekSenetIslem")
                    dr("nSonBordroSatirID") = dr1("nBordroSatirID")
                Next
                tbCekSenet_nSonCekSenetIslem_degistir(dr("nCekSenetID"))
                If dr("nSonCekSenetIslem") = sec_nCekSenetIslem.EditValue Then
                    If sec_nCekSenetIslem.EditValue = 21 Then
                        'tbCekSenetBordro_odeme_kaydet_sil(dr("nBordroSatirID"), dr("nOncekiBordroSatirID"), dr("nCekSenetID"), dr("nBorcluCariHareketID"))
                        If sorgu_sayi(dr("nKasaIslemID"), 0) = 0 Then
                            tbCekSenetBordro_odeme_kaydet_sil(dr("nBordroSatirID"), dr("nOncekiBordroSatirID"), dr("nCekSenetID"), dr("nBorcluCariHareketID"))
                        Else
                            tbCekSenetBordro_bankadanodeme_kaydet_sil(dr("nBordroSatirID"), dr("nOncekiBordroSatirID"), dr("nCekSenetID"), dr("nKasaIslemID"))
                        End If
                    ElseIf sec_nCekSenetIslem.EditValue = 22 Then
                        tbCekSenetBordro_odeme_kaydet_sil(dr("nBordroSatirID"), dr("nOncekiBordroSatirID"), dr("nCekSenetID"), dr("nCariHareketID"))
                    ElseIf sec_nCekSenetIslem.EditValue = 23 Then
                        tbCekSenetBordro_odeme_kaydet_sil(dr("nBordroSatirID"), dr("nOncekiBordroSatirID"), dr("nCekSenetID"), dr("nCariHareketID"))
                    ElseIf sec_nCekSenetIslem.EditValue = 24 Then
                        If sorgu_sayi(dr("nKasaIslemID"), 0) = 0 Then
                            tbCekSenetBordro_odeme_kaydet_sil(dr("nBordroSatirID"), dr("nOncekiBordroSatirID"), dr("nCekSenetID"), dr("nBorcluCariHareketID"))
                        Else
                            tbCekSenetBordro_bankadanodeme_kaydet_sil(dr("nBordroSatirID"), dr("nOncekiBordroSatirID"), dr("nCekSenetID"), dr("nKasaIslemID"))
                        End If
                    ElseIf sec_nCekSenetIslem.EditValue = 2 Or sec_nCekSenetIslem.EditValue = 4 Or sec_nCekSenetIslem.EditValue = 5 Or sec_nCekSenetIslem.EditValue = 6 Then
                        tbCekSenetBordro_odeme_kaydet_sil(dr("nBordroSatirID"), dr("nOncekiBordroSatirID"), dr("nCekSenetID"), dr("nCariHareketID"))
                    ElseIf sec_nCekSenetIslem.EditValue = 3 Then
                        tbCekSenetBordro_takas_kaydet_sil(dr("nBordroSatirID"), dr("nOncekiBordroSatirID"), dr("nCekSenetID"), dr("nCariHareketID"), 1)
                    ElseIf sec_nCekSenetIslem.EditValue = 7 Then
                        tbCekSenetBordro_bankadantahsil_kaydet_sil(dr("nBordroSatirID"), dr("nOncekiBordroSatirID"), dr("nCekSenetID"), dr("nCariHareketID"))
                    ElseIf sec_nCekSenetIslem.EditValue = 8 Then
                        tbCekSenetBordro_cuzdandantahsil_kaydet_sil(dr("nBordroSatirID"), dr("nOncekiBordroSatirID"), dr("nCekSenetID"), dr("nKasaIslemID"))
                    ElseIf sec_nCekSenetIslem.EditValue = 11 Then
                        tbCekSenetBordro_parcalitahsilat_kaydet_sil(dr("nBordroSatirID"), dr("nOncekiBordroSatirID"), dr("nCekSenetID"), dr("nKasaIslemID"))
                    ElseIf sec_nCekSenetIslem.EditValue = 9 Then
                        tbCekSenetBordro_protesto_kaydet_sil(dr("nBordroSatirID"), dr("nOncekiBordroSatirID"), dr("nCekSenetID"), dr("nBorcluCariHareketID"))
                    ElseIf sec_nCekSenetIslem.EditValue = 10 Then
                        tbCekSenetBordro_takas_kaydet_sil(dr("nBordroSatirID"), dr("nOncekiBordroSatirID"), dr("nCekSenetID"), dr("nCariHareketID"), 5)
                    Else
                        tbCekSenetBordro_kaydet_sil(dr("nBordroSatirID"), dr("nCekSenetID"), dr("nCariHareketID"))
                    End If
                    tbCekSenet_nSonCekSenetIslem_degistir(dr("nCekSenetID"))
                    'GridView1.DeleteRow(GridView1.FocusedRowHandle)
                    Dim satir = GridView1.FocusedRowHandle
                    Dataload_tbCekSenetBordro(sec_sCekSenetTipi.EditValue, sec_nCekSenetIslem.EditValue, nFirmaId, txt_dteBordroTarihi.EditValue, txt_lBordroNo.EditValue, txt_sHareketTipi.EditValue)
                    If GridView1.RowCount > 0 Then
                        GridView1.ClearSelection()
                        GridView1.SelectRow(satir)
                        PanelControl3.Focus()
                        GridControl1.Focus()
                    End If
                    satir = Nothing
                Else
                    XtraMessageBox.Show(Sorgu_sDil("Satýr Silme Ýþlemine Uygun Deðil Lutfen Hareketlerini Kontrol Ediniz...!", sDil), Sorgu_sDil("Dikkat", sDil), MessageBoxButtons.OK, MessageBoxIcon.Warning)
                End If
            End If
        End If
    End Sub
    Private Sub satir_kontrol()
        If status = False Then
            If GridView1.RowCount > 0 Then
                Dim dr As DataRow = GridView1.GetDataRow(GridView1.FocusedRowHandle)
                If sec_nCekSenetIslem.EditValue = 21 Then
                    Dataload_tbFirma(dr("nBorcluFirmaID").ToString)
                    GridView1.OptionsBehavior.Editable = False
                ElseIf sec_nCekSenetIslem.EditValue = 22 Then
                    Dataload_tbFirma(dr("nFirmaID").ToString)
                    GridView1.OptionsBehavior.Editable = False
                ElseIf sec_nCekSenetIslem.EditValue = 23 Then
                    Dataload_tbFirma(dr("nFirmaID").ToString)
                    GridView1.OptionsBehavior.Editable = False
                ElseIf sec_nCekSenetIslem.EditValue = 2 Then
                    Dataload_tbFirma(dr("nFirmaID").ToString)
                    GridView1.OptionsBehavior.Editable = False
                ElseIf sec_nCekSenetIslem.EditValue = 3 Then
                    Dataload_tbFirma(dr("nFirmaID").ToString)
                    GridView1.OptionsBehavior.Editable = False
                    'ElseIf sec_nCekSenetIslem.EditValue = 5 Or sec_nCekSenetIslem.EditValue = 7 Or sec_nCekSenetIslem.EditValue = 8 Or sec_nCekSenetIslem.EditValue = 21 Then
                    '    Dataload_tbFirma(dr("nFirmaID").ToString)
                    '    GridView1.OptionsBehavior.Editable = True
                    '    colbKendineAit.OptionsColumn.AllowEdit = False
                    '    colbMuhasebeyeIslendimi.OptionsColumn.AllowEdit = False
                    '    coldteBordroTarihi.OptionsColumn.AllowEdit = False
                    '    coldteDuzenlemeTarihi.OptionsColumn.AllowEdit = False
                    '    coldteVadeTarihi.OptionsColumn.AllowEdit = False
                    '    coldteValorTarihi.OptionsColumn.AllowEdit = False
                    '    collBordroNo.OptionsColumn.AllowEdit = False
                    '    collCekSenetNo.OptionsColumn.AllowEdit = False
                    '    collDovizKuru1.OptionsColumn.AllowEdit = False
                    '    collDovizKuru2.OptionsColumn.AllowEdit = False
                    '    collDovizMiktari2.OptionsColumn.AllowEdit = False
                    '    collDovizMiktari1.OptionsColumn.AllowEdit = False
                    '    collTutar.Visible = False
                    '    colnBorcluCariHareketID.OptionsColumn.AllowEdit = False
                    '    colnBorcluFirmaID.OptionsColumn.AllowEdit = False
                    '    colnBordroSatirID.OptionsColumn.AllowEdit = False
                    '    colnCariHareketID.OptionsColumn.AllowEdit = False
                    '    colnCekSenetID.OptionsColumn.AllowEdit = False
                    '    colnCekSenetIslem.OptionsColumn.AllowEdit = False
                    '    colnFirmaID.OptionsColumn.AllowEdit = False
                    '    colnKasaIslemID.OptionsColumn.AllowEdit = False
                    '    colnOncekiBordroSatirID.OptionsColumn.AllowEdit = False
                    '    colnOncekiCekSenetIslem.OptionsColumn.AllowEdit = False
                    '    colnProtestoMasrafiCariHareketID.OptionsColumn.AllowEdit = False
                    '    colnProtestoMasrafiFirmaID.OptionsColumn.AllowEdit = False
                    '    colnSonBordroSatirID.OptionsColumn.AllowEdit = False
                    '    colnSonCekSenetIslem.OptionsColumn.AllowEdit = False
                    '    colnVerenID.OptionsColumn.AllowEdit = False
                    '    colsBankaHesapNo.OptionsColumn.AllowEdit = False
                    '    colsBankaKodu.OptionsColumn.AllowEdit = False
                    '    colsBankaSubeNo.OptionsColumn.AllowEdit = False
                    '    colsBorclusu.OptionsColumn.AllowEdit = False
                    '    colsBorcluVergiDairesi.OptionsColumn.AllowEdit = False
                    '    colsBorcluVergiNumarasi.OptionsColumn.AllowEdit = False
                    '    colsCekSenetKodu1.OptionsColumn.AllowEdit = False
                    '    colsCekSenetKodu2.OptionsColumn.AllowEdit = False
                    '    colsCekSenetTipi.OptionsColumn.AllowEdit = False
                    '    colsDovizCinsi1.OptionsColumn.AllowEdit = False
                    '    collDovizKuru1.OptionsColumn.AllowEdit = False
                    '    collDovizMiktari1.OptionsColumn.AllowEdit = False
                    '    colsDovizCinsi2.OptionsColumn.AllowEdit = True
                    '    collDovizKuru2.OptionsColumn.AllowEdit = True
                    '    collDovizMiktari2.OptionsColumn.AllowEdit = True
                    '    colsHareketTipi.OptionsColumn.AllowEdit = False
                    '    colsIl.OptionsColumn.AllowEdit = False
                    '    colsKarsiTarafCekSenetNo.OptionsColumn.AllowEdit = False
                    '    colsNot.OptionsColumn.AllowEdit = False
                    '    colsOrjinalCekSenetNo.OptionsColumn.AllowEdit = False
                    '    colsSemt.OptionsColumn.AllowEdit = False
                ElseIf sec_nCekSenetIslem.EditValue = 4 Then
                    Dataload_tbFirma(dr("nFirmaID").ToString)
                    GridView1.OptionsBehavior.Editable = False
                    'ElseIf sec_nCekSenetIslem.EditValue = 5 Then
                    '    Dataload_tbFirma(dr("nFirmaID").ToString)
                    '    GridView1.OptionsBehavior.Editable = False
                ElseIf sec_nCekSenetIslem.EditValue = 6 Then
                    Dataload_tbFirma(dr("nFirmaID").ToString)
                    GridView1.OptionsBehavior.Editable = False
                ElseIf sec_nCekSenetIslem.EditValue = 5 Or sec_nCekSenetIslem.EditValue = 7 Or sec_nCekSenetIslem.EditValue = 8 Or sec_nCekSenetIslem.EditValue = 10 Then
                    Dataload_tbFirma(dr("nFirmaID").ToString)
                    GridView1.OptionsBehavior.Editable = True
                    GridView1.OptionsBehavior.Editable = True
                    colbKendineAit.OptionsColumn.AllowEdit = False
                    colbMuhasebeyeIslendimi.OptionsColumn.AllowEdit = False
                    coldteBordroTarihi.OptionsColumn.AllowEdit = False
                    coldteDuzenlemeTarihi.OptionsColumn.AllowEdit = False
                    coldteVadeTarihi.OptionsColumn.AllowEdit = False
                    coldteValorTarihi.OptionsColumn.AllowEdit = False
                    collBordroNo.OptionsColumn.AllowEdit = False
                    collCekSenetNo.OptionsColumn.AllowEdit = False
                    collDovizKuru1.OptionsColumn.AllowEdit = True
                    collDovizKuru2.OptionsColumn.AllowEdit = True
                    collDovizMiktari2.OptionsColumn.AllowEdit = True
                    collDovizMiktari1.OptionsColumn.AllowEdit = True
                    If collProtestoMasrafi.Visible = False Then
                        'collProtestoMasrafi.Visible = True
                        'collProtestoMasrafi.OptionsColumn.AllowEdit = False
                        'collProtestoMasrafi.Caption = "Tahsilat"
                        'collProtestoMasrafi.VisibleIndex = collTutar.VisibleIndex
                        'collTutar.OptionsColumn.AllowEdit = False
                    End If
                    'collTutar.Visible = False
                    collTutar.OptionsColumn.AllowEdit = False
                    colnBorcluCariHareketID.OptionsColumn.AllowEdit = False
                    colnBorcluFirmaID.OptionsColumn.AllowEdit = False
                    colnBordroSatirID.OptionsColumn.AllowEdit = False
                    colnCariHareketID.OptionsColumn.AllowEdit = False
                    colnCekSenetID.OptionsColumn.AllowEdit = False
                    colnCekSenetIslem.OptionsColumn.AllowEdit = False
                    colnFirmaID.OptionsColumn.AllowEdit = False
                    colnKasaIslemID.OptionsColumn.AllowEdit = False
                    colnOncekiBordroSatirID.OptionsColumn.AllowEdit = False
                    colnOncekiCekSenetIslem.OptionsColumn.AllowEdit = False
                    colnProtestoMasrafiCariHareketID.OptionsColumn.AllowEdit = False
                    colnProtestoMasrafiFirmaID.OptionsColumn.AllowEdit = False
                    colnSonBordroSatirID.OptionsColumn.AllowEdit = False
                    colnSonCekSenetIslem.OptionsColumn.AllowEdit = False
                    colnVerenID.OptionsColumn.AllowEdit = False
                    colsBankaHesapNo.OptionsColumn.AllowEdit = False
                    colsBankaKodu.OptionsColumn.AllowEdit = False
                    colsBankaSubeNo.OptionsColumn.AllowEdit = False
                    colsBorclusu.OptionsColumn.AllowEdit = False
                    colsBorcluVergiDairesi.OptionsColumn.AllowEdit = False
                    colsBorcluVergiNumarasi.OptionsColumn.AllowEdit = False
                    colsCekSenetKodu1.OptionsColumn.AllowEdit = False
                    colsCekSenetKodu2.OptionsColumn.AllowEdit = False
                    colsCekSenetTipi.OptionsColumn.AllowEdit = False
                    colsDovizCinsi1.OptionsColumn.AllowEdit = True
                    colsDovizCinsi2.OptionsColumn.AllowEdit = True
                    colsHareketTipi.OptionsColumn.AllowEdit = False
                    colsIl.OptionsColumn.AllowEdit = False
                    colsKarsiTarafCekSenetNo.OptionsColumn.AllowEdit = False
                    colsNot.OptionsColumn.AllowEdit = True
                    colsOrjinalCekSenetNo.OptionsColumn.AllowEdit = False
                    colsSemt.OptionsColumn.AllowEdit = False
                ElseIf sec_nCekSenetIslem.EditValue = 11 Then
                    GridView1.OptionsBehavior.Editable = True
                    colbKendineAit.OptionsColumn.AllowEdit = False
                    colbMuhasebeyeIslendimi.OptionsColumn.AllowEdit = False
                    coldteBordroTarihi.OptionsColumn.AllowEdit = False
                    coldteDuzenlemeTarihi.OptionsColumn.AllowEdit = False
                    coldteVadeTarihi.OptionsColumn.AllowEdit = False
                    coldteValorTarihi.OptionsColumn.AllowEdit = False
                    collBordroNo.OptionsColumn.AllowEdit = False
                    collCekSenetNo.OptionsColumn.AllowEdit = False
                    collDovizKuru1.OptionsColumn.AllowEdit = False
                    collDovizKuru2.OptionsColumn.AllowEdit = False
                    collDovizMiktari2.OptionsColumn.AllowEdit = False
                    collDovizMiktari1.OptionsColumn.AllowEdit = False
                    If collProtestoMasrafi.Visible = False Then
                        collProtestoMasrafi.Visible = True
                        collProtestoMasrafi.OptionsColumn.AllowEdit = True
                        collProtestoMasrafi.Caption = "Tahsilat"
                        collProtestoMasrafi.VisibleIndex = collTutar.VisibleIndex
                        collTutar.OptionsColumn.AllowEdit = False
                    End If
                    collTutar.Visible = False
                    collTutar.OptionsColumn.AllowEdit = False
                    colnBorcluCariHareketID.OptionsColumn.AllowEdit = False
                    colnBorcluFirmaID.OptionsColumn.AllowEdit = False
                    colnBordroSatirID.OptionsColumn.AllowEdit = False
                    colnCariHareketID.OptionsColumn.AllowEdit = False
                    colnCekSenetID.OptionsColumn.AllowEdit = False
                    colnCekSenetIslem.OptionsColumn.AllowEdit = False
                    colnFirmaID.OptionsColumn.AllowEdit = False
                    colnKasaIslemID.OptionsColumn.AllowEdit = False
                    colnOncekiBordroSatirID.OptionsColumn.AllowEdit = False
                    colnOncekiCekSenetIslem.OptionsColumn.AllowEdit = False
                    colnProtestoMasrafiCariHareketID.OptionsColumn.AllowEdit = False
                    colnProtestoMasrafiFirmaID.OptionsColumn.AllowEdit = False
                    colnSonBordroSatirID.OptionsColumn.AllowEdit = False
                    colnSonCekSenetIslem.OptionsColumn.AllowEdit = False
                    colnVerenID.OptionsColumn.AllowEdit = False
                    colsBankaHesapNo.OptionsColumn.AllowEdit = False
                    colsBankaKodu.OptionsColumn.AllowEdit = False
                    colsBankaSubeNo.OptionsColumn.AllowEdit = False
                    colsBorclusu.OptionsColumn.AllowEdit = False
                    colsBorcluVergiDairesi.OptionsColumn.AllowEdit = False
                    colsBorcluVergiNumarasi.OptionsColumn.AllowEdit = False
                    colsCekSenetKodu1.OptionsColumn.AllowEdit = False
                    colsCekSenetKodu2.OptionsColumn.AllowEdit = False
                    colsCekSenetTipi.OptionsColumn.AllowEdit = False
                    colsDovizCinsi1.OptionsColumn.AllowEdit = False
                    colsDovizCinsi2.OptionsColumn.AllowEdit = False
                    colsHareketTipi.OptionsColumn.AllowEdit = False
                    colsIl.OptionsColumn.AllowEdit = False
                    colsKarsiTarafCekSenetNo.OptionsColumn.AllowEdit = False
                    colsNot.OptionsColumn.AllowEdit = False
                    colsOrjinalCekSenetNo.OptionsColumn.AllowEdit = False
                    colsSemt.OptionsColumn.AllowEdit = False
                Else
                    If dr("nSonCekSenetIslem") = 1 Or dr("nSonCekSenetIslem") = 20 Then
                        GridView1.OptionsBehavior.Editable = True
                    Else
                        GridView1.OptionsBehavior.Editable = False
                    End If
                    Dataload_tbFirma(dr("nFirmaID").ToString)
                End If
                dataload_tbBankaSubeKodu(dr("sBankaKodu").ToString)
                'Dataload_tbHesap(dr("nHesapID"))
                Try
                    Dim dr_toplam As DataRow = ds_tbCekSenetBordroToplam.Tables(0).Rows(0)
                    dr_toplam("sAciklama") = sorgu_sBankaAdi(dr("sBankaKodu"))
                    dr_toplam = Nothing
                Catch ex As Exception
                End Try
                If sec_bKilitli.Checked = True Or bKilitli = True Then
                    GridView1.OptionsBehavior.Editable = False
                End If
                dr = Nothing
            End If
        End If
    End Sub
    Private Sub fis_sil()
        If XtraMessageBox.Show(Sorgu_sDil("Fiþi Silmek Ýstediðinize Emin misiniz...?", sDil), Sorgu_sDil("Dikkat", sDil), MessageBoxButtons.YesNo, MessageBoxIcon.Question) = MsgBoxResult.Yes Then
            XtraMessageBox.Show(Sorgu_sDil("Toplu Fiþ Silemezsiniz... Satýrlarý Tek Tek Siliniz...!", sDil), Sorgu_sDil("Dikkat", sDil), MessageBoxButtons.OK, MessageBoxIcon.Warning)
            'If sec_nCekSenetIslem.EditValue = 21 Then
            '    tbCekSenetBordro_Odeme_sil(sec_sCekSenetTipi.EditValue, sec_nCekSenetIslem.EditValue, nFirmaId, txt_dteBordroTarihi.EditValue, txt_lBordroNo.EditValue, txt_sHareketTipi.EditValue)
            'ElseIf sec_nCekSenetIslem.EditValue = 22 Then
            '    tbCekSenetBordro_Odeme_sil(sec_sCekSenetTipi.EditValue, sec_nCekSenetIslem.EditValue, nFirmaId, txt_dteBordroTarihi.EditValue, txt_lBordroNo.EditValue, txt_sHareketTipi.EditValue, True)
            'ElseIf sec_nCekSenetIslem.EditValue = 23 Then
            '    tbCekSenetBordro_Odeme_sil(sec_sCekSenetTipi.EditValue, sec_nCekSenetIslem.EditValue, nFirmaId, txt_dteBordroTarihi.EditValue, txt_lBordroNo.EditValue, txt_sHareketTipi.EditValue, True)
            'ElseIf sec_nCekSenetIslem.EditValue = 2 Or sec_nCekSenetIslem.EditValue = 3 Or sec_nCekSenetIslem.EditValue = 4 Or sec_nCekSenetIslem.EditValue = 5 Or sec_nCekSenetIslem.EditValue = 6 Then
            '    tbCekSenetBordro_Odeme_sil(sec_sCekSenetTipi.EditValue, sec_nCekSenetIslem.EditValue, nFirmaId, txt_dteBordroTarihi.EditValue, txt_lBordroNo.EditValue, txt_sHareketTipi.EditValue, True)
            'ElseIf sec_nCekSenetIslem.EditValue = 3 Then
            '    tbCekSenetBordro_Odeme_sil(sec_sCekSenetTipi.EditValue, sec_nCekSenetIslem.EditValue, nFirmaId, txt_dteBordroTarihi.EditValue, txt_lBordroNo.EditValue, txt_sHareketTipi.EditValue, False)
            'ElseIf sec_nCekSenetIslem.EditValue = 7 Then
            '    tbCekSenetBordro_Odeme_sil(sec_sCekSenetTipi.EditValue, sec_nCekSenetIslem.EditValue, nFirmaId, txt_dteBordroTarihi.EditValue, txt_lBordroNo.EditValue, txt_sHareketTipi.EditValue, True)
            'ElseIf sec_nCekSenetIslem.EditValue = 8 Then
            '    tbCekSenetBordro_Odeme_sil(sec_sCekSenetTipi.EditValue, sec_nCekSenetIslem.EditValue, nFirmaId, txt_dteBordroTarihi.EditValue, txt_lBordroNo.EditValue, txt_sHareketTipi.EditValue, False, True)
            'ElseIf sec_nCekSenetIslem.EditValue = 11 Then
            '    tbCekSenetBordro_Odeme_sil(sec_sCekSenetTipi.EditValue, sec_nCekSenetIslem.EditValue, nFirmaId, txt_dteBordroTarihi.EditValue, txt_lBordroNo.EditValue, txt_sHareketTipi.EditValue, False, True)
            'ElseIf sec_nCekSenetIslem.EditValue = 9 Then
            '    tbCekSenetBordro_Odeme_sil(sec_sCekSenetTipi.EditValue, sec_nCekSenetIslem.EditValue, nFirmaId, txt_dteBordroTarihi.EditValue, txt_lBordroNo.EditValue, txt_sHareketTipi.EditValue, False)
            'ElseIf sec_nCekSenetIslem.EditValue = 10 Then
            '    tbCekSenetBordro_Odeme_sil(sec_sCekSenetTipi.EditValue, sec_nCekSenetIslem.EditValue, nFirmaId, txt_dteBordroTarihi.EditValue, txt_lBordroNo.EditValue, txt_sHareketTipi.EditValue, False)
            'Else
            '    tbCekSenetBordro_sil(sec_sCekSenetTipi.EditValue, sec_nCekSenetIslem.EditValue, nFirmaId, txt_dteBordroTarihi.EditValue, txt_lBordroNo.EditValue, txt_sHareketTipi.EditValue)
            'End If
            'Try
            '    ds_tbCekSenet.Tables(0).Clear()
            'Catch ex As Exception
            'End Try
            'txt_dteBordroTarihi.EditValue = dteSistemTarihi
            'txt_lBordroNo.EditValue = 0
            'Me.Close()
        End If
    End Sub
    Private Sub degeryay(ByVal columnkriter As String, Optional ByVal bSatirDegistir As Boolean = True)
        Dim durum
        Dim sayi = GridView1.RowCount
        Dim satir = GridView1.FocusedRowHandle
        Dim TOPLAM = sayi - GridView1.FocusedRowHandle
        Dim t As Int64
        Dim Ý As Integer
        Ý = 0
        dr = GridView1.GetDataRow(GridView1.FocusedRowHandle)
        durum = dr(String.Format("{0}", columnkriter))
        For Ý = 1 To TOPLAM
            If bSatirDegistir = True Then
                t += 1
                If columnkriter = "dteVadeTarihi" Then
                    GridView1.PostEditor()
                    dr = GridView1.GetDataRow(GridView1.FocusedRowHandle)
                    If t > 1 Then
                        durum = DateAdd(DateInterval.Month, 1, durum)
                    Else
                        durum = durum
                    End If
                    dr("" & columnkriter & "") = durum
                    dr.EndEdit()
                ElseIf columnkriter = "sOrjinalCekSenetNo" Then
                    GridView1.PostEditor()
                    dr = GridView1.GetDataRow(GridView1.FocusedRowHandle)
                    If t > 1 Then
                        durum = durum + 1
                    Else
                        durum = durum
                    End If
                    dr("" & columnkriter & "") = durum
                    dr.EndEdit()
                Else
                    dr = GridView1.GetDataRow(GridView1.FocusedRowHandle)
                    dr.BeginEdit()
                    dr(String.Format("{0}", columnkriter)) = durum
                    dr.EndEdit()
                End If
            End If
            tutar_hesapla()
            GridView1.FocusedRowHandle += 1
        Next
        GridView1.FocusedRowHandle = satir
        GridView1.GetDataRow(satir)
        durum = Nothing
        sayi = Nothing
        satir = Nothing
        Ý = Nothing
    End Sub
    Private Sub tutar_hesapla(Optional ByVal nSatir As Int64 = 0)
        If GridView1.RowCount > 0 Then
            Dim dr As DataRow
            If nSatir = 0 Then
                dr = GridView1.GetDataRow(GridView1.FocusedRowHandle)
            Else
                dr = GridView1.GetDataRow(nSatir)
            End If
            dr("lTutar") = sorgu_sayi(dr("lTutar"), 0.001)
            If dr("lTutar") = 0 Then
                dr("lTutar") = 0.001
            End If
            If Trim(dr("sDovizCinsi1")) = "" Then
                dr("lDovizKuru1") = 0
                dr("lDovizMiktari1") = 0
            End If
            If Trim(dr("sDovizCinsi2")) = "" Then
                dr("lDovizKuru2") = 0
                dr("lDovizMiktari2") = 0
            End If
            If GridView1.FocusedColumn.Name = colnOpsiyon.Name.ToString Then
                dr("dteVadeTarihi") = DateAdd(DateInterval.Day, dr("nOpsiyon"), dr("dteDuzenlemeTarihi"))
            Else 'If GridView1.FocusedColumn.Name = colnOpsiyon.Name.ToString Then
                dr("nOpsiyon") = DateDiff(DateInterval.Day, dr("dteDuzenlemeTarihi"), dr("dteVadeTarihi"))
            End If
            If GridView1.FocusedColumn.Name = collDovizMiktari1.Name.ToString Then
                If Trim(dr("sDovizCinsi1").ToString) <> "" Then
                    If dr("lDovizKuru1") = 0 Then
                        dr("lDovizKuru1") = 1
                    End If
                    dr("lTutar") = dr("lDovizMiktari1") * dr("lDovizKuru1")
                End If
            End If
            If Trim(dr("sDovizCinsi1").ToString) <> "" Then
                If dr("lDovizKuru1") = 0 Then
                    dr("lDovizKuru1") = 1
                End If
                dr("lDovizMiktari1") = Math.Abs(dr("lTutar")) / dr("lDovizKuru1")
            End If
            If Trim(dr("sDovizCinsi2").ToString) <> "" Then
                If dr("lDovizKuru2") = 0 Then
                    dr("lDovizKuru2") = 1
                End If
                dr("lDovizMiktari2") = Math.Abs(dr("lTutar")) / dr("lDovizKuru2")
            End If
            If dr("lTutar") = 0 Then
                dr("lTutar") = 0.001
            End If
            dr("sBankaAdi") = sorgu_sBankaAdi(dr("sBankaKodu").ToString)
            If Trim(sec_nCekSenetIslem.EditValue) = 3 Or Trim(sec_nCekSenetIslem.EditValue) = 4 Or Trim(sec_nCekSenetIslem.EditValue) = 5 Or Trim(sec_nCekSenetIslem.EditValue) = 7 Or Trim(sec_nCekSenetIslem.EditValue) = 8 Or Trim(sec_nCekSenetIslem.EditValue) = 21 Then
            Else
                tbCekSenet_kaydet_duzelt(dr("nCekSenetID"), dr("sCekSenetTipi"), dr("lCekSenetNo"), dr("sBankaKodu").ToString, dr("lTutar"), dr("dteVadeTarihi"), dr("dteDuzenlemeTarihi"), dr("sIl").ToString, dr("sSemt").ToString, dr("sOrjinalCekSenetNo").ToString, dr("sKarsiTarafCekSenetNo").ToString, dr("nVerenID"), dr("bKendineAit"), dr("sBorclusu").ToString, dr("sBorcluVergiDairesi").ToString, dr("sBorcluVergiNumarasi").ToString, dr("sBankaHesapNo").ToString, dr("sBankaSubeNo").ToString, dr("nSonBordroSatirID"), dr("nSonCekSenetIslem"), dr("sHareketTipi").ToString, dr("sNot").ToString, dr("sKullaniciAdi"), dr("dteKayitTarihi"), dr("sDovizCinsi1").ToString, dr("lDovizMiktari1"), dr("lDovizKuru1"), dr("sDovizCinsi2").ToString, dr("lDovizMiktari2"), dr("lDovizKuru2"), kullaniciadi, Now, dr("sCekSenetKodu1").ToString, dr("sCekSenetKodu2").ToString)
            End If
            Dim sAciklama As String = Microsoft.VisualBasic.Left("B:" + Trim(dr("lBordroNo").ToString) + "\(" + sorgu_sBankaAdi(dr("sBankaKodu")) + ")\Vade:" + dr("dteVadeTarihi") + "\E.N:" + Trim(dr("sOrjinalCekSenetNo")) + "-" + sorgu_sCekSenetIslem(dr("nCekSenetIslem")), 60)
            Dim lBorcTutar As Decimal = 0
            Dim lAlacakTutar As Decimal = 0
            If Trim(dr("sCekSenetTipi")) = "AC" Or Trim(dr("sCekSenetTipi")) = "AS" Then
                If Trim(sec_nCekSenetIslem.EditValue) = 2 Or Trim(sec_nCekSenetIslem.EditValue) = 3 Or Trim(sec_nCekSenetIslem.EditValue) = 4 Or Trim(sec_nCekSenetIslem.EditValue) = 5 Or Trim(sec_nCekSenetIslem.EditValue) = 7 Then
                    lBorcTutar = dr("lTutar")
                    lAlacakTutar = 0
                Else
                    lAlacakTutar = dr("lTutar")
                    lBorcTutar = 0
                End If
            ElseIf Trim(dr("sCekSenetTipi")) = "BC" Or Trim(dr("sCekSenetTipi")) = "BS" Then
                If Trim(sec_nCekSenetIslem.EditValue) = 21 Or Trim(sec_nCekSenetIslem.EditValue) = 22 Or Trim(sec_nCekSenetIslem.EditValue) = 23 Then
                    lAlacakTutar = dr("lTutar")
                    lBorcTutar = 0
                Else
                    lBorcTutar = dr("lTutar")
                    lAlacakTutar = 0
                End If
            End If
            If sec_nCekSenetIslem.EditValue = 11 Then
                tbCekSenetBordro_kaydet_duzelt(dr("nBordroSatirID"), dr("nCekSenetIslem"), dr("nFirmaID"), dr("dteBordroTarihi"), dr("lBordroNo"), dr("nCekSenetID"), dr("nOncekiBordroSatirID"), dr("nOncekiCekSenetIslem"), dr("nCariHareketID"), dr("nBorcluFirmaID"), dr("nProtestoMasrafiFirmaID"), dr("lProtestoMasrafi"), dr("dteValorTarihi"), dr("bMuhasebeyeIslendimi"), dr("sKullaniciAdi"), dr("dteKayitTarihi"), dr("bKilitli"))
                tbNakitKasa_kaydet_duzelt(dr("nKasaIslemID"), sSubeMagaza, dr("dteBordroTarihi"), dr("lProtestoMasrafi"), 0, sAciklama, 0, dr("nFirmaID"), 0, "AC", dr("sHareketTipi"), kullaniciadi, dr("dteKayitTarihi"), 0, "", "", 0, 0, "", 0, 0, kullaniciadi, dr("dteKayitTarihi"))
            Else
                collProtestoMasrafi.Visible = False
            End If
            If Trim(sec_nCekSenetIslem.EditValue) = 21 Then
                tbFirmaHareketi_kaydet_duzelt(dr("nBorcluCariHareketID"), dr("nFirmaID"), dr("dteBordroTarihi"), dr("dteVadeTarihi"), dr("sCekSenetTipi"), sAciklama, lBorcTutar, lAlacakTutar, dr("lCekSenetNo"), 0, dr("sCekSenetTipi"), dr("sHareketTipi").ToString, dr("sKullaniciAdi").ToString, dr("dteKayitTarihi"), dr("sDovizCinsi1"), dr("lDovizMiktari1"), dr("lDovizKuru1"), dr("sDovizCinsi2"), dr("lDovizMiktari2"), dr("lDovizKuru2"), kullaniciadi, Now)
            ElseIf Trim(sec_nCekSenetIslem.EditValue) = 8 Then
                tbFirmaHareketi_kaydet_duzelt(dr("nCariHareketID"), dr("nFirmaID"), dr("dteBordroTarihi"), dr("dteVadeTarihi"), dr("sCekSenetTipi"), sAciklama, lBorcTutar, lAlacakTutar, dr("lCekSenetNo"), 0, dr("sCekSenetTipi"), dr("sHareketTipi").ToString, dr("sKullaniciAdi").ToString, dr("dteKayitTarihi"), dr("sDovizCinsi1"), dr("lDovizMiktari1"), dr("lDovizKuru1"), dr("sDovizCinsi2"), dr("lDovizMiktari2"), dr("lDovizKuru2"), kullaniciadi, Now)
                'ElseIf Trim(sec_nCekSenetIslem.EditValue) = 7 Then
                '    tbFirmaHareketi_kaydet_duzelt(dr("nCariHareketID"), dr("nFirmaID"), dr("dteBordroTarihi"), dr("dteVadeTarihi"), dr("sCekSenetTipi"), sAciklama, lBorcTutar, lAlacakTutar, dr("lCekSenetNo"), 0, dr("sCekSenetTipi"), dr("sHareketTipi").ToString, dr("sKullaniciAdi").ToString, dr("dteKayitTarihi"), dr("sDovizCinsi1"), dr("lDovizMiktari1"), dr("lDovizKuru1"), dr("sDovizCinsi2"), dr("lDovizMiktari2"), dr("lDovizKuru2"), kullaniciadi, Now)
            ElseIf Trim(sec_nCekSenetIslem.EditValue) = 9 Then
            ElseIf Trim(sec_nCekSenetIslem.EditValue) = 7 Or Trim(sec_nCekSenetIslem.EditValue) = 8 Or Trim(sec_nCekSenetIslem.EditValue) = 10 Then
                tbCekSenet_kaydet_duzelt(dr("nCekSenetID"), dr("sCekSenetTipi"), dr("lCekSenetNo"), dr("sBankaKodu").ToString, dr("lTutar"), dr("dteVadeTarihi"), dr("dteDuzenlemeTarihi"), dr("sIl").ToString, dr("sSemt").ToString, dr("sOrjinalCekSenetNo").ToString, dr("sKarsiTarafCekSenetNo").ToString, dr("nVerenID"), dr("bKendineAit"), dr("sBorclusu").ToString, dr("sBorcluVergiDairesi").ToString, dr("sBorcluVergiNumarasi").ToString, dr("sBankaHesapNo").ToString, dr("sBankaSubeNo").ToString, dr("nSonBordroSatirID"), dr("nSonCekSenetIslem"), dr("sHareketTipi").ToString, dr("sNot").ToString, dr("sKullaniciAdi"), dr("dteKayitTarihi"), dr("sDovizCinsi1").ToString, dr("lDovizMiktari1"), dr("lDovizKuru1"), dr("sDovizCinsi2").ToString, dr("lDovizMiktari2"), dr("lDovizKuru2"), kullaniciadi, Now, dr("sCekSenetKodu1").ToString, dr("sCekSenetKodu2").ToString)
                tbFirmaHareketi_kaydet_duzelt(dr("nCariHareketID"), dr("nFirmaID"), dr("dteBordroTarihi"), dr("dteVadeTarihi"), dr("sCekSenetTipi"), sAciklama, lBorcTutar, lAlacakTutar, dr("lCekSenetNo"), 0, dr("sCekSenetTipi"), dr("sHareketTipi").ToString, dr("sKullaniciAdi").ToString, dr("dteKayitTarihi"), dr("sDovizCinsi1"), dr("lDovizMiktari1"), dr("lDovizKuru1"), dr("sDovizCinsi2"), dr("lDovizMiktari2"), dr("lDovizKuru2"), kullaniciadi, Now)
                If sec_nCekSenetIslem.EditValue = 10 Then
                    tbFirmaHareketi_DovizCinsi_kaydet_duzelt(dr("nCekSenetID"), dr("sDovizCinsi1"), dr("lDovizMiktari1"), dr("lDovizKuru1"), dr("sDovizCinsi2"), dr("lDovizMiktari2"), dr("lDovizKuru2"), kullaniciadi, Now)
                End If
            ElseIf Trim(sec_nCekSenetIslem.EditValue) = 11 Then
            ElseIf Trim(sec_nCekSenetIslem.EditValue) = 3 Then
                tbFirmaHareketi_kaydet_duzelt(dr("nCariHareketID"), dr("nFirmaID"), dr("dteBordroTarihi"), dr("dteVadeTarihi"), dr("sCekSenetTipi"), sAciklama, lBorcTutar, lAlacakTutar, dr("lCekSenetNo"), 0, dr("sCekSenetTipi"), dr("sHareketTipi").ToString, dr("sKullaniciAdi").ToString, dr("dteKayitTarihi"), dr("sDovizCinsi1"), dr("lDovizMiktari1"), dr("lDovizKuru1"), dr("sDovizCinsi2"), dr("lDovizMiktari2"), dr("lDovizKuru2"), kullaniciadi, Now)
            ElseIf Trim(sec_nCekSenetIslem.EditValue) = 5 Then
                tbFirmaHareketi_kaydet_duzelt(dr("nCariHareketID"), dr("nFirmaID"), dr("dteBordroTarihi"), dr("dteVadeTarihi"), dr("sCekSenetTipi"), sAciklama, lBorcTutar, lAlacakTutar, dr("lCekSenetNo"), 0, dr("sCekSenetTipi"), dr("sHareketTipi").ToString, dr("sKullaniciAdi").ToString, dr("dteKayitTarihi"), dr("sDovizCinsi1"), dr("lDovizMiktari1"), dr("lDovizKuru1"), dr("sDovizCinsi2"), dr("lDovizMiktari2"), dr("lDovizKuru2"), kullaniciadi, Now)
            Else
                If dr("nCariHareketID") = -1 Then
                Else
                    tbFirmaHareketi_kaydet_duzelt(dr("nCariHareketID"), dr("nFirmaID"), dr("dteBordroTarihi"), dr("dteVadeTarihi"), dr("sCekSenetTipi"), sAciklama, lBorcTutar, lAlacakTutar, dr("lCekSenetNo"), 0, dr("sCekSenetTipi"), dr("sHareketTipi").ToString, dr("sKullaniciAdi").ToString, dr("dteKayitTarihi"), dr("sDovizCinsi1"), dr("lDovizMiktari1"), dr("lDovizKuru1"), dr("sDovizCinsi2"), dr("lDovizMiktari2"), dr("lDovizKuru2"), kullaniciadi, Now)
                End If
            End If
            If Trim(sec_nCekSenetIslem.EditValue) = 1 Or Trim(sec_nCekSenetIslem.EditValue) = 20 And Trim(dr("sNot").ToString) <> "Devir" Then
                If Trim(dr("sNot").ToString) <> "" Then
                    If sorgula_nStokID("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT     COUNT(*) AS nSayi FROM         tbCekSenet WHERE     (nCekSenetID <> " & dr("nCekSenetID") & ") AND (sNot = '" & dr("sNot") & "') AND (sCekSenetTipi = '" & dr("sCekSenetTipi") & "')") <> 0 Then
                        If XtraMessageBox.Show(dr("sNot") & vbCrLf & Sorgu_sDil("Notu Daha Önce Kullanýlmýþ...! Kayýtlarý Listelemek Ýster misiniz...?", sDil), Sorgu_sDil("Dikkat", sDil), MessageBoxButtons.YesNo, MessageBoxIcon.Information) = Windows.Forms.DialogResult.Yes Then
                            Dim frm As New frm_tbCekSenet_liste
                            frm.connection = connection
                            frm.firmano = firmano
                            frm.donemno = donemno
                            frm.kullanici = kullanici
                            frm.sCekSenetTipi = dr("sCekSenetTipi")
                            frm.bHatirlatma = True
                            frm.txt_dteBordroTarihi1.EditValue = "01/01/1900"
                            frm.txt_dteBordroTarihi2.EditValue = "31/12/2078"
                            frm.txt_sNot.Text = Trim(dr("sNot").ToString)
                            If yetki_kontrol(kullanici, frm.Name) = True Then
                                frm.ShowDialog()
                            End If
                        End If
                    End If
                End If
            End If
            satir_kontrol()
            Dataload_tbYekun(sorgu_sBankaAdi(dr("sBankaKodu")), sec_sCekSenetTipi.EditValue, sec_nCekSenetIslem.EditValue, nFirmaId, txt_dteBordroTarihi.EditValue, txt_lBordroNo.EditValue, txt_sHareketTipi.EditValue)
            dr = Nothing
        End If
    End Sub
    Private Sub analiz_tbCekSenet_Hareket()
        If GridView1.RowCount > 0 Then
            Dim dr As DataRow = GridView1.GetDataRow(GridView1.FocusedRowHandle)
            Dim frm As New frm_tbCekSenet_Hareketleri
            frm.firmano = firmano
            frm.donemno = donemno
            frm.connection = connection
            frm.nCekSenetID = dr("nCekSenetID")
            frm.lCekSenetNo = dr("lCekSenetNo")
            frm.sCekSenetTipi = dr("sCekSenetTipi")
            frm.kullanici = kullanici
            If yetki_kontrol(kullanici, frm.Name) = True Then
                frm.ShowDialog()
            End If
            frm.Close()
            frm.Dispose()
            frm = Nothing
        End If
    End Sub
    Private Sub analiz_cari_hareket()
        If GridView1.RowCount > 0 Then
            Dim dr As DataRow = GridView1.GetDataRow(GridView1.FocusedRowHandle)
            Dim frm As New frm_cari_hareketler_ozet() With {.firmano = firmano, .donemno = donemno, .connection = connection, .musterino = dr("sFirmaKodu"), .kullanici = kullanici}
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
    Private Sub analiz_bakiye()
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
            frm.kullanici = kullanici
            If yetki_kontrol(kullanici, frm.Name) = True Then
                frm.ShowDialog()
            End If
            frm.Close()
            frm.Dispose()
            frm = Nothing
        End If
    End Sub
    Private Sub fis_sec()
        Dim frm As New frm_tbCekSenetBordro_liste
        frm.firmano = firmano
        frm.donemno = donemno
        frm.connection = connection
        frm.kullanici = kullanici
        frm.islemstatus = True
        If frm.ShowDialog(Me) = Windows.Forms.DialogResult.OK Then
            Dim dr1 As DataRow = frm.GridView1.GetDataRow(frm.GridView1.FocusedRowHandle)
            sec_sCekSenetTipi.EditValue = dr1("sCekSenetTipi")
            sec_nCekSenetIslem.EditValue = dr1("nCekSenetIslem")
            txt_dteBordroTarihi.EditValue = dr1("dteBordroTarihi")
            txt_lBordroNo.EditValue = dr1("lBordroNo")
            txt_sHareketTipi.EditValue = dr1("sHareketTipi")
            sec_sSubeMagaza.EditValue = dr1("sCekSenetKodu1")
            sKodu = dr1("sKodu")
            txt_musteriNo.EditValue = sKodu
            nFirmaId = dr1("nFirmaID")
            lbl_Firma.Text = dr1("sAciklama")
            dr1 = Nothing
            Dataload_tbCekSenetBordro(sec_sCekSenetTipi.EditValue, sec_nCekSenetIslem.EditValue, nFirmaId, txt_dteBordroTarihi.EditValue, txt_lBordroNo.EditValue, txt_sHareketTipi.EditValue)
        End If
        frm.Close()
        frm.Dispose()
        frm = Nothing
    End Sub
    Private Sub firma_sec(Optional ByVal islem As Integer = 0)
        Dim dr As DataRow
        dr = GridView1.GetDataRow(GridView1.FocusedRowHandle)
        Dim frm As New frm_firma_liste
        frm.firmano = firmano
        frm.donemno = donemno
        frm.connection = connection
        frm.islemstatus = True
        frm.kullanici = kullanici
        If nCekSenetIslem = 3 Or nCekSenetIslem = 4 Or nCekSenetIslem = 7 Then
            frm.sModul = "Banka"
        Else
            frm.sModul = "CekSenetBordroCari"
        End If
        'If sec_nCekSenetIslem.EditValue = 1 Or sec_nCekSenetIslem.EditValue = 2 Or sec_nCekSenetIslem.EditValue = 9 Or sec_nCekSenetIslem.EditValue = 11 Or sec_nCekSenetIslem.EditValue = 20 Or sec_nCekSenetIslem.EditValue = 21 Or sec_nCekSenetIslem.EditValue = 23 Then
        'frm.sModul = "CekSenetBordroCari"
        'Else
        '    frm.sModul = "Cari"
        'End If
        If frm.ShowDialog(Me) = Windows.Forms.DialogResult.OK Then
            Dim dr1 As DataRow
            dr1 = frm.GridView1.GetDataRow(frm.GridView1.FocusedRowHandle)
            nFirmaId = dr1("nFirmaID")
            sKodu = dr1("sKodu")
            lbl_Firma.Text = dr1("sAciklama")
            txt_musteriNo.EditValue = sKodu
            musteri_kontrol()
            dr1 = Nothing
        Else
            Me.Close()
        End If
    End Sub
    Private Function borclufirma_sec(Optional ByVal islem As Integer = 0) As Boolean
        Dim dr As DataRow
        dr = GridView1.GetDataRow(GridView1.FocusedRowHandle)
        Dim frm As New frm_firma_liste
        frm.firmano = firmano
        frm.donemno = donemno
        frm.connection = connection
        frm.islemstatus = True
        frm.kullanici = kullanici
        Dim pass As Boolean = False
        frm.sModul = "CekSenetBordroBanka"
        If frm.ShowDialog(Me) = Windows.Forms.DialogResult.OK Then
            Dim dr1 As DataRow
            dr1 = frm.GridView1.GetDataRow(frm.GridView1.FocusedRowHandle)
            nBorcluFirmaID = dr1("nFirmaID")
            sBorcluKodu = dr1("sKodu")
            sBorcluAciklama = dr1("sAciklama")
            dr1 = Nothing
            pass = True
        End If
        Return pass
    End Function
    Private Sub musteri_kontrol()
        If Trim(txt_musteriNo.EditValue).ToString <> "" Then
            Dim kontrol = sorgu_cari_kontrol(txt_musteriNo.EditValue)
            If kontrol = 0 Then
                XtraMessageBox.Show(Sorgu_sDil("Kayýt Bulunumadý...", sDil), Sorgu_sDil("Dikkat", sDil), MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            ElseIf kontrol = 1 Then
                dataload_cari(txt_musteriNo.EditValue)
                Dim dr As DataRow
                For Each dr In ds_cari.Tables(0).Rows
                    'txt_Musteri.EditValue = dr("MUSTERI")
                    sKodu = dr("sKodu")
                    nFirmaId = dr("nFirmaID")
                    lbl_Firma.Text = dr("sAciklama")
                Next
                dr = Nothing
            End If
        End If
    End Sub
    Public Function sorgu_cari_kontrol(ByVal kod As String) As Int64
        Dim kriter
        kriter = "WHERE (sKodu = '" & kod & "') "
        Dim conn As New OleDb.OleDbConnection
        Dim cmd As New OleDb.OleDbCommand
        Dim adapter As New OleDb.OleDbDataAdapter
        conn.ConnectionString = connection
        cmd.Connection = conn
        conn.Open()
        cmd.CommandText = sorgu_query("SET DATEFORMAT DMY SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT     ISNULL(COUNT(*), 0) AS KAYIT  FROM         tbFirma " & kriter & "")
        Dim kayitsayisi = cmd.ExecuteScalar
        Return kayitsayisi
    End Function
    Private Sub dataload_cari(ByVal kod As String)
        Dim kriter
        kriter = "WHERE (sKodu = '" & kod & "') "
        ds_cari = sorgu(sorgu_query("SELECT     nFirmaId,sKodu,sAciklama FROM         tbFirma " & kriter & ""))
    End Sub
    Private Sub analiz_Fis_Notu()
        'If GridView1.RowCount > 0 Then
        '    Dim frm As New frm_musteri_karti_aciklama
        '    frm.firmano = firmano
        '    frm.donemno = donemno
        '    frm.connection = connection
        '    frm.kullanici = kullanici
        '    frm.tbMuhasebeFisi = True
        '    frm.sMuhFisTipi = sec_sMuhFisTipi.SelectedIndex + 1
        '    frm.dteFisTarihi = txt_dteFisTarihi.EditValue
        '    frm.lFisNo = txt_lFisNo.EditValue
        '    frm.ShowDialog()
        '    frm.Close()
        '    frm.Dispose()
        '    frm = Nothing
        'End If
    End Sub
    Private Function tbSonKod(ByVal islem As String) As String
        Dim frm As New frm_tbSonKod
        frm.firmano = firmano
        frm.donemno = donemno
        frm.connection = connection
        frm.kullanici = kullanici
        frm.islem = islem
        Dim sKodu As String = ""
        If frm.ShowDialog(Me) = Windows.Forms.DialogResult.OK Then
            sKodu = frm.lbl_Kod.Text
            Dim dr As DataRow
            dr = GridView1.GetDataRow(GridView1.FocusedRowHandle)
            dr("sNot") = sKodu
            dr = Nothing
        End If
        frm.Close()
        frm = Nothing
        Return sKodu
    End Function
    Private Sub gorunum_kontrol()
        If Trim(sec_sCekSenetTipi.EditValue) = "AC" Then
            If Trim(sec_nCekSenetIslem.EditValue) = "1" Then
                collCekSenetNo.Visible = True
                colnBordroSatirID.Visible = False
                colnCekSenetID.Visible = False
                collCekSenetNo.Visible = True
                collTutar.Visible = True
                coldteVadeTarihi.Visible = True
                colsHareketTipi.Visible = False
                colsNot.Visible = True
                colsIl.Visible = True
                colsSemt.Visible = True
                colsKarsiTarafCekSenetNo.Visible = True
                coldteDuzenlemeTarihi.Visible = False
                colsBankaKodu.Visible = True
                colsBankaHesapNo.Visible = True
                colsBankaSubeNo.Visible = True
                colsOrjinalCekSenetNo.Visible = True
                colnVerenID.Visible = False
                colbKendineAit.Visible = True
                colsBorclusu.Visible = True
                colsBorcluVergiDairesi.Visible = True
                colsBorcluVergiNumarasi.Visible = True
                colnSonBordroSatirID.Visible = False
                colnSonCekSenetIslem.Visible = False
                colnCariHareketID.Visible = False
                colnKasaIslemID.Visible = False
                colnBorcluFirmaID.Visible = False
                colnBorcluCariHareketID.Visible = False
                colnProtestoMasrafiFirmaID.Visible = False
                colnProtestoMasrafiCariHareketID.Visible = False
                If sec_nCekSenetIslem.EditValue = 11 Then
                    collProtestoMasrafi.Visible = True
                Else
                    collProtestoMasrafi.Visible = False
                End If
                colnOncekiBordroSatirID.Visible = False
                colnOncekiCekSenetIslem.Visible = False
                coldteValorTarihi.Visible = False
                colbMuhasebeyeIslendimi.Visible = False
                colsDovizCinsi1.Visible = True
                collDovizMiktari1.Visible = True
                collDovizKuru1.Visible = True
                colsDovizCinsi2.Visible = False
                collDovizMiktari2.Visible = False
                collDovizKuru2.Visible = False
                colsCekSenetKodu1.Visible = True
                colsCekSenetKodu2.Visible = True
                colsCekSenetTipi.Visible = False
                colnCekSenetIslem.Visible = False
                coldteBordroTarihi.Visible = False
                collBordroNo.Visible = False
            End If
        ElseIf Trim(sec_sCekSenetTipi.EditValue) = "BC" Then
            If Trim(sec_nCekSenetIslem.EditValue) = "20" Then
                colnBordroSatirID.Visible = False
                colnCekSenetID.Visible = False
                collCekSenetNo.Visible = True
                collTutar.Visible = True
                coldteVadeTarihi.Visible = True
                colsHareketTipi.Visible = False
                colsNot.Visible = True
                colsIl.Visible = False
                colsSemt.Visible = False
                colsKarsiTarafCekSenetNo.Visible = False
                coldteDuzenlemeTarihi.Visible = False
                colsBankaKodu.Visible = True
                colsBankaHesapNo.Visible = True
                colsBankaSubeNo.Visible = False
                colsOrjinalCekSenetNo.Visible = True
                colnVerenID.Visible = False
                colbKendineAit.Visible = False
                colsBorclusu.Visible = False
                colsBorcluVergiDairesi.Visible = False
                colsBorcluVergiNumarasi.Visible = False
                colnSonBordroSatirID.Visible = False
                colnSonCekSenetIslem.Visible = False
                colnCariHareketID.Visible = False
                colnKasaIslemID.Visible = False
                colnBorcluFirmaID.Visible = False
                colnBorcluCariHareketID.Visible = False
                colnProtestoMasrafiFirmaID.Visible = False
                colnProtestoMasrafiCariHareketID.Visible = False
                collProtestoMasrafi.Visible = False
                colnOncekiBordroSatirID.Visible = False
                colnOncekiCekSenetIslem.Visible = False
                coldteValorTarihi.Visible = False
                colbMuhasebeyeIslendimi.Visible = False
                colsDovizCinsi1.Visible = True
                collDovizMiktari1.Visible = True
                collDovizKuru1.Visible = True
                colsDovizCinsi2.Visible = False
                collDovizMiktari2.Visible = False
                collDovizKuru2.Visible = False
                colsCekSenetKodu1.Visible = True
                colsCekSenetKodu2.Visible = True
                colsCekSenetTipi.Visible = False
                colnCekSenetIslem.Visible = False
                coldteBordroTarihi.Visible = False
                collBordroNo.Visible = False
            End If
        End If
    End Sub
    Private Sub raporla(ByVal nIslem As Integer)
        Dim OpenFileDialog1 As New Windows.Forms.OpenFileDialog
        OpenFileDialog1.Title = "Rapor Seç..."
        OpenFileDialog1.Filter = "Rapor Dosyalarý (Form*.frx) |Form*.frx"
        OpenFileDialog1.FileName = "c:\Formlar\Raporlar\CekSenet\Form.frx"
        OpenFileDialog1.InitialDirectory = "c:\Formlar\Raporlar\CekSenet"
        If OpenFileDialog1.ShowDialog = Windows.Forms.DialogResult.OK Then
            Dim sFile = OpenFileDialog1.FileName.ToString
            Dim report As New FastReport.Report
            report.Load(sFile)
            Dataload_tbCekSenetBordro(sec_sCekSenetTipi.EditValue, sec_nCekSenetIslem.EditValue, nFirmaId, txt_dteBordroTarihi.EditValue, txt_lBordroNo.EditValue, txt_sHareketTipi.EditValue)
            report.RegisterData(ds_tbCekSenet)
            report.RegisterData(ds_tbCekSenetBordroToplam)
            'report.RegisterData(ds_tbBankaKodu)
            report.RegisterData(ds_tbParamGenel)
            report.SetParameterValue("dteBordroTarihi", txt_dteBordroTarihi.EditValue)
            report.SetParameterValue("lBordroNo", txt_lBordroNo.EditValue)
            report.SetParameterValue("sCekSenetTipi", sec_sCekSenetTipi.Text)
            report.SetParameterValue("sCekSenetIslem", sec_nCekSenetIslem.Text)
            report.SetParameterValue("sFirmaKodu", txt_musteriNo.Text)
            report.SetParameterValue("sFirmaAciklama", lbl_Firma.Text)
            report.ScriptLanguage = Language.Vb
            If nIslem = 0 Then
                report.Show()
            ElseIf nIslem = 1 Then
                report.Design()
            ElseIf nIslem = 2 Then
                'report.Prepare()
                report.Print()
            End If
            report.Dispose()
            report = Nothing
        End If
    End Sub
    Private Sub raporla1(ByVal rapor As Integer, ByVal islem As Integer, ByVal sCekSenetTipi As String, ByVal nCekSenetIslem As String, ByVal nFirmaID As String, ByVal dteBordroTarihi As DateTime, ByVal lBordroNo As Int64, ByVal sHareketTipi As String)
        Dim file As String = ""
        Dim kriter As String
        Dim dr As DataRow
        dr = GridView1.GetDataRow(GridView1.FocusedRowHandle)
        kriter = " WHERE (tbCekSenet.sCekSenetTipi = '" & sCekSenetTipi & "') AND (tbCekSenetBordro.nCekSenetIslem = " & nCekSenetIslem & ") AND (tbCekSenetBordro.dteBordroTarihi = '" & dteBordroTarihi & "') AND (tbCekSenetBordro.lBordroNo = " & lBordroNo & ") AND (tbCekSenetBordro.nFirmaID = " & nFirmaID & ") "
        OpenFileDialog1.Title = "Rapor Seç..."
        OpenFileDialog1.Filter = "Rapor Dosyalarý (Form*.fr3) |Form*.fr3"
        OpenFileDialog1.FileName = "c:\Formlar\Raporlar\CekSenet\Form.fr3"
        OpenFileDialog1.InitialDirectory = "c:\Formlar\Raporlar\CekSenet"
        If OpenFileDialog1.ShowDialog = Windows.Forms.DialogResult.OK Then
            file = OpenFileDialog1.FileName.ToString
            report_create_stok(file, kriter, islem, sorgu_sCekSenetAciklama(sec_sCekSenetTipi.EditValue), sorgu_sCekSenetIslem(sec_nCekSenetIslem.EditValue))
        End If
        file = Nothing
        kriter = Nothing
        dr = Nothing
    End Sub
    Private Sub report_create_stok(ByVal dosya As String, ByVal kriter As String, ByVal status As Integer, ByVal sCekSenetAciklama As String, ByVal sCekSenetIslemAciklama As String)
        Dim stokno = 0
        Dim satir_line = "100"
        If IntPtr.Size = 4 Then
            '32 Bit
            Dim frx As New TfrxReportClass
            Dim ds1 As New TfrxUserDataSetClass
            Dim qr_hareket As New TfrxADOQuery
            Dim qr_baslik As New TfrxADOQuery
            frx.Resources.LoadLanguageResourcesFromFile("C:\Program Files\FastReports\FastReport Studio\bin\turkish.frc")
            frx.LoadReportFromFile(dosya)
            frx.SetVariable("FIRMANO", "" & firmano & "")
            frx.SetVariable("DONEMNO", "" & donemno & "")
            frx.SetVariable("STOKNO", "" & stokno & "")
            frx.SetVariable("SATIRLINE", "'" & satir_line & "'")
            frx.SetVariable("Belge", "'" & sCekSenetAciklama & "'")
            frx.SetVariable("Islem", "'" & sCekSenetIslemAciklama & "'")
            frx.SetVariable("BordroTarihi", "'" & txt_dteBordroTarihi.EditValue & "'")
            frx.SetVariable("BordroNo", "'" & txt_lBordroNo.EditValue & "'")
            frx.SetVariable("Firma", "'" & lbl_Firma.Text & "'")
            frx.SetVariable("HareketTipi", "'" & txt_sHareketTipi.EditValue & "'")
            'If sMuhFisTipi = 1 Then
            '    frx.SetVariable("IZAHAT", "'Tahsilat Fiþi'")
            'ElseIf sMuhFisTipi = 2 Then
            '    frx.SetVariable("IZAHAT", "'Tediye Fiþi'")
            'ElseIf sMuhFisTipi = 3 Then
            '    frx.SetVariable("IZAHAT", "'Mahsup Fiþi'")
            'End If
            qr_hareket = frx.FindObject("qr_hareket")
            qr_hareket.Query = sorgu_query("SELECT tbCekSenetBordro.nBordroSatirID, tbCekSenet.nCekSenetID, tbCekSenet.lCekSenetNo, tbCekSenet.lTutar, tbCekSenet.dteVadeTarihi, tbCekSenet.sHareketTipi, tbCekSenet.sNot, tbCekSenet.sIl, tbCekSenet.sSemt, tbCekSenet.sKarsiTarafCekSenetNo, tbCekSenet.dteDuzenlemeTarihi, tbCekSenet.sBankaKodu, tbCekSenet.sBankaHesapNo, tbCekSenet.sBankaSubeNo, tbCekSenet.sOrjinalCekSenetNo, tbCekSenet.nVerenID, tbCekSenet.bKendineAit, tbCekSenet.sBorclusu, tbCekSenet.sBorcluVergiDairesi, tbCekSenet.sBorcluVergiNumarasi, tbCekSenet.nSonBordroSatirID, tbCekSenet.nSonCekSenetIslem, ISNULL(tbCekSenetBordro.nCariHareketID, 0) AS nCariHareketID, ISNULL(tbCekSenetBordro.nKasaIslemID, 0) AS nKasaIslemID, ISNULL(tbCekSenetBordro.nBorcluFirmaID, 0) AS nBorcluFirmaID, ISNULL(tbCekSenetBordro.nBorcluCariHareketID, 0) AS nBorcluCariHareketID, ISNULL(tbCekSenetBordro.nProtestoMasrafiFirmaID, 0) AS nProtestoMasrafiFirmaID, ISNULL(tbCekSenetBordro.nProtestoMasrafiCariHareketID, 0) AS nProtestoMasrafiCariHareketID, tbCekSenetBordro.lProtestoMasrafi, tbCekSenetBordro.nOncekiBordroSatirID, tbCekSenetBordro.nOncekiCekSenetIslem, tbCekSenetBordro.dteValorTarihi, tbCekSenetBordro.bMuhasebeyeIslendimi, tbCekSenet.sDovizCinsi1, tbCekSenet.lDovizMiktari1, tbCekSenet.lDovizKuru1, tbCekSenet.sDovizCinsi2, tbCekSenet.lDovizMiktari2, tbCekSenet.lDovizKuru2, tbCekSenet.sCekSenetKodu1, tbCekSenet.sCekSenetKodu2, tbCekSenetBordro.nFirmaID, tbCekSenet.sCekSenetTipi, tbCekSenetBordro.nCekSenetIslem, tbCekSenet.sKullaniciAdi, tbCekSenet.dteKayitTarihi, tbCekSenetBordro.dteBordroTarihi, tbCekSenetBordro.lBordroNo, tbFirma.sKodu AS sFirmaKodu, tbFirma.sAciklama AS sFirmaAciklama, tbBanka.sAciklama AS sBankaAciklama, tbBankaSubesi.sAciklama AS sBankaSubesi FROM tbCekSenetBordro INNER JOIN tbCekSenet ON tbCekSenetBordro.nCekSenetID = tbCekSenet.nCekSenetID LEFT OUTER JOIN tbBankaSubesi ON tbCekSenet.sBankaKodu = tbBankaSubesi.sBankaKodu AND tbCekSenet.sBankaSubeNo = tbBankaSubesi.sBankaSubeKodu LEFT OUTER JOIN tbBanka ON tbCekSenet.sBankaKodu = tbBanka.sBankaKodu LEFT OUTER JOIN tbFirma ON tbCekSenetBordro.nFirmaID = tbFirma.nFirmaID " & kriter & " ")
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
        ElseIf IntPtr.Size = 8 Then
            '64 Bit
            Dim args(50) As String
            Dim processYol As String
            args(0) = "" & dosya & ""
            args(1) = "" & connection.ToString() & ""
            args(2) = "" & sorgu_query("SELECT tbCekSenetBordro.nBordroSatirID, tbCekSenet.nCekSenetID, tbCekSenet.lCekSenetNo, tbCekSenet.lTutar, tbCekSenet.dteVadeTarihi, tbCekSenet.sHareketTipi, tbCekSenet.sNot, tbCekSenet.sIl, tbCekSenet.sSemt, tbCekSenet.sKarsiTarafCekSenetNo, tbCekSenet.dteDuzenlemeTarihi, tbCekSenet.sBankaKodu, tbCekSenet.sBankaHesapNo, tbCekSenet.sBankaSubeNo, tbCekSenet.sOrjinalCekSenetNo, tbCekSenet.nVerenID, tbCekSenet.bKendineAit, tbCekSenet.sBorclusu, tbCekSenet.sBorcluVergiDairesi, tbCekSenet.sBorcluVergiNumarasi, tbCekSenet.nSonBordroSatirID, tbCekSenet.nSonCekSenetIslem, ISNULL(tbCekSenetBordro.nCariHareketID, 0) AS nCariHareketID, ISNULL(tbCekSenetBordro.nKasaIslemID, 0) AS nKasaIslemID, ISNULL(tbCekSenetBordro.nBorcluFirmaID, 0) AS nBorcluFirmaID, ISNULL(tbCekSenetBordro.nBorcluCariHareketID, 0) AS nBorcluCariHareketID, ISNULL(tbCekSenetBordro.nProtestoMasrafiFirmaID, 0) AS nProtestoMasrafiFirmaID, ISNULL(tbCekSenetBordro.nProtestoMasrafiCariHareketID, 0) AS nProtestoMasrafiCariHareketID, tbCekSenetBordro.lProtestoMasrafi, tbCekSenetBordro.nOncekiBordroSatirID, tbCekSenetBordro.nOncekiCekSenetIslem, tbCekSenetBordro.dteValorTarihi, tbCekSenetBordro.bMuhasebeyeIslendimi, tbCekSenet.sDovizCinsi1, tbCekSenet.lDovizMiktari1, tbCekSenet.lDovizKuru1, tbCekSenet.sDovizCinsi2, tbCekSenet.lDovizMiktari2, tbCekSenet.lDovizKuru2, tbCekSenet.sCekSenetKodu1, tbCekSenet.sCekSenetKodu2, tbCekSenetBordro.nFirmaID, tbCekSenet.sCekSenetTipi, tbCekSenetBordro.nCekSenetIslem, tbCekSenet.sKullaniciAdi, tbCekSenet.dteKayitTarihi, tbCekSenetBordro.dteBordroTarihi, tbCekSenetBordro.lBordroNo, tbFirma.sKodu AS sFirmaKodu, tbFirma.sAciklama AS sFirmaAciklama, tbBanka.sAciklama AS sBankaAciklama, tbBankaSubesi.sAciklama AS sBankaSubesi FROM tbCekSenetBordro INNER JOIN tbCekSenet ON tbCekSenetBordro.nCekSenetID = tbCekSenet.nCekSenetID LEFT OUTER JOIN tbBankaSubesi ON tbCekSenet.sBankaKodu = tbBankaSubesi.sBankaKodu AND tbCekSenet.sBankaSubeNo = tbBankaSubesi.sBankaSubeKodu LEFT OUTER JOIN tbBanka ON tbCekSenet.sBankaKodu = tbBanka.sBankaKodu LEFT OUTER JOIN tbFirma ON tbCekSenetBordro.nFirmaID = tbFirma.nFirmaID " & kriter & " ") & ""
            args(3) = "qr_hareket"
            args(4) = "" & status.ToString() & ""
            args(5) = "10"
            args(6) = "FIRMANO"
            args(7) = "" & firmano.ToString() & ""
            args(8) = "DONEMNO"
            args(9) = "" & donemno.ToString() & ""
            args(10) = "STOKNO"
            args(11) = "" & stokno.ToString() & ""
            args(12) = "SATIRLINE"
            args(13) = "'" & satir_line.ToString() & "'"
            args(14) = "Belge"
            args(15) = "'" & sCekSenetAciklama.ToString() & "'"
            args(16) = "Islem"
            args(17) = "'" & sCekSenetIslemAciklama.ToString() & "'"
            args(18) = "BordroTarihi"
            args(19) = "'" & txt_dteBordroTarihi.EditValue & "'"
            args(20) = "BordroNo"
            args(21) = "'" & txt_lBordroNo.EditValue & "'"
            args(22) = "Firma"
            args(23) = "'" & lbl_Firma.Text & "'"
            args(24) = "HareketTipi"
            args(25) = "'" & txt_sHareketTipi.EditValue & "'"
            processYol = args(0)
            For i As Integer = 1 To 25
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
        If btn_Goster.Text = Sorgu_sDil("&Göster", sDil) Then
            Dataload_tbCekSenetBordro(sec_sCekSenetTipi.EditValue, sec_nCekSenetIslem.EditValue, nFirmaId, txt_dteBordroTarihi.EditValue, txt_lBordroNo.EditValue, txt_sHareketTipi.EditValue)
        ElseIf btn_Goster.Text = Sorgu_sDil("&Yeni", sDil) Then
            txt_lBordroNo.EditValue = sorgu_lBordroNo()
            txt_sHareketTipi.Focus()
            txt_sHareketTipi.Select()
            txt_sHareketTipi.ItemIndex = 1
            Try
                ds_tbCekSenet.Tables(0).Clear()
            Catch ex As Exception
            End Try
            yeni = True
        End If
    End Sub
    Private Sub GörünümüDüzenleToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GörünümüDüzenleToolStripMenuItem.Click
        GridView1.ColumnsCustomization()
    End Sub
    Private Sub GörünümüKaydetToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GörünümüKaydetToolStripMenuItem.Click
        gorunum_kaydet()
    End Sub
    Private Sub GörünümüYazdýrToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GörünümüYazdýrToolStripMenuItem.Click
        Printlink1.CreateDocument(ps)
        ps.PreviewRibbonFormEx.Show()
    End Sub
    Private Sub HýzlýFiltreToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles HýzlýFiltreToolStripMenuItem.Click
        If HýzlýFiltreToolStripMenuItem.Checked = False Then
            GridView1.OptionsCustomization.AllowFilter = True
            GridView1.OptionsView.ShowFilterPanelMode = DevExpress.XtraGrid.Views.Base.ShowFilterPanelMode.Default
            GridView1.OptionsView.ShowAutoFilterRow = True
            HýzlýFiltreToolStripMenuItem.Checked = True
        ElseIf HýzlýFiltreToolStripMenuItem.Checked = True Then
            GridView1.OptionsCustomization.AllowFilter = False
            GridView1.OptionsView.ShowFilterPanelMode = DevExpress.XtraGrid.Views.Base.ShowFilterPanelMode.Never
            GridView1.OptionsView.ShowAutoFilterRow = False
            HýzlýFiltreToolStripMenuItem.Checked = False
        End If
    End Sub
    Private Sub MenuItem8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        GridView1.ExpandAllGroups()
    End Sub
    Private Sub MenuItem9_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        GridView1.CollapseAllGroups()
    End Sub
    Private Sub MenuItem10_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem10.Click
        If Me.WindowState = FormWindowState.Normal Then
            Me.WindowState = FormWindowState.Maximized
        ElseIf Me.WindowState = FormWindowState.Maximized Then
            Me.WindowState = FormWindowState.Normal
        End If
    End Sub
    Private Sub GridView1_CellValueChanged1(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs) Handles GridView1.CellValueChanged
        If GridView1.RowCount > 0 Then
            GridView1.PostEditor()
            dr = GridView1.GetDataRow(GridView1.FocusedRowHandle)
            dr.EndEdit()
            'Try
            tutar_hesapla()
            'Catch ex As Exception
            'End Try
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
        satir_kontrol()
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
    Private Sub EkleToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EkleToolStripMenuItem.Click
        'If Trim(sec_sCekSenetTipi.EditValue) = "BC" And Trim(sec_nCekSenetIslem.EditValue) = "21" Then
        '    satir_ekle_odeme()
        'ElseIf Trim(sec_sCekSenetTipi.EditValue) = "BC" And Trim(sec_nCekSenetIslem.EditValue) = "22" Then
        '    satir_ekle_iptal()
        'ElseIf Trim(sec_sCekSenetTipi.EditValue) = "BC" And Trim(sec_nCekSenetIslem.EditValue) = "23" Then
        '    satir_ekle_karsiliksiz()
        'ElseIf Trim(sec_sCekSenetTipi.EditValue) = "AC" And Trim(sec_nCekSenetIslem.EditValue) = 3 Then
        '    satir_ekle_ciro()
        'ElseIf Trim(sec_sCekSenetTipi.EditValue) = "AC" And Trim(sec_nCekSenetIslem.EditValue) = 4 Then
        '    satir_ekle_ciro()
        'ElseIf Trim(sec_sCekSenetTipi.EditValue) = "AC" And Trim(sec_nCekSenetIslem.EditValue) = 5 Then
        '    satir_ekle_ciro()
        'ElseIf Trim(sec_sCekSenetTipi.EditValue) = "AC" And Trim(sec_nCekSenetIslem.EditValue) = 2 Then
        '    satir_ekle_iade()
        'Else
        '    satir_ekle()
        'End If
        kayit_ekle()
    End Sub
    Private Sub kayit_ekle()
        If Trim(sec_nCekSenetIslem.EditValue) = "21" Then
            satir_ekle_odeme()
        ElseIf Trim(sec_nCekSenetIslem.EditValue) = "22" Then
            satir_ekle_iptal()
        ElseIf Trim(sec_nCekSenetIslem.EditValue) = "23" Then
            satir_ekle_karsiliksiz()
        ElseIf Trim(sec_nCekSenetIslem.EditValue) = "24" Then
            satir_ekle_odeme_bankadan()
        ElseIf Trim(sec_nCekSenetIslem.EditValue) = 3 Then
            satir_ekle_takas()
            'satir_ekle_ciro()
        ElseIf Trim(sec_nCekSenetIslem.EditValue) = 4 Then
            satir_ekle_ciro()
        ElseIf Trim(sec_nCekSenetIslem.EditValue) = 5 Then
            satir_ekle_ciro()
        ElseIf Trim(sec_nCekSenetIslem.EditValue) = 6 Then
            satir_ekle_iade_giris()
        ElseIf Trim(sec_nCekSenetIslem.EditValue) = 2 Then
            satir_ekle_iade()
        ElseIf Trim(sec_nCekSenetIslem.EditValue) = 7 Then
            satir_ekle_bankadantahsil()
        ElseIf Trim(sec_nCekSenetIslem.EditValue) = 8 Then
            satir_ekle_cuzdandantahsil()
        ElseIf Trim(sec_nCekSenetIslem.EditValue) = 9 Then
            satir_ekle_protesto()
        ElseIf Trim(sec_nCekSenetIslem.EditValue) = 10 Then
            satir_ekle_sahistantahsil()
        ElseIf Trim(sec_nCekSenetIslem.EditValue) = 11 Then
            satir_ekle_ParcaliTahsilat()
        Else
            If bDevir = False Then
                satir_ekle()
            ElseIf bDevir = True Then
                satir_ekle_devir()
            End If
        End If
        GridControl1.Focus()
        GridControl1.Select()
        satir_kontrol()
    End Sub
    Private Sub SilToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SilToolStripMenuItem.Click
        satir_sil()
    End Sub
    Private Sub FirmaHareketleriToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FirmaHareketleriToolStripMenuItem.Click
        analiz_cari_hareket()
    End Sub
    Private Sub FirmaKartýToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FirmaKartýToolStripMenuItem.Click
        analiz_Firma_karti()
    End Sub
    Private Sub ÖnizleToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ÖnizleToolStripMenuItem.Click
        raporla(0)
    End Sub
    Private Sub DizaynToolStripMenuItem_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles DizaynToolStripMenuItem.Click
        raporla(1)
    End Sub
    Private Sub YazdýrToolStripMenuItem_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles YazdýrToolStripMenuItem.Click
        raporla(2)
    End Sub
    Private Sub GridControl1_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles GridControl1.KeyDown
        If e.KeyCode = Keys.Escape Then
            If XtraMessageBox.Show(Sorgu_sDil("Çek/Senet Bordro Ekranýndan Çýkmak Ýstediðinize Emin misiniz...?", sDil), Sorgu_sDil("Dikkat", sDil), MessageBoxButtons.YesNo, MessageBoxIcon.Question) = MsgBoxResult.Yes Then
                Me.Close()
            End If
        End If
    End Sub
    Private Sub AraToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AraToolStripMenuItem.Click
        txt_dteBordroTarihi.Focus()
        txt_dteBordroTarihi.SelectAll()
    End Sub
    Private Sub sec_sMuhFisTipi_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs)
        If e.KeyCode = Keys.Enter Then
            txt_lBordroNo.Focus()
            txt_lBordroNo.SelectAll()
        End If
    End Sub
    Private Sub FisSecToolStripMenuItem_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles FisSecToolStripMenuItem.Click
        fis_sec()
    End Sub
    Private Sub FisNotuToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FisNotuToolStripMenuItem.Click
        analiz_Fis_Notu()
    End Sub
    Private Sub txt_lFisNo_EditValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles txt_lBordroNo.EditValueChanged, txt_lBordroNo.EditValueChanged
        If txt_lBordroNo.EditValue = 0 Then
            btn_Goster.Text = Sorgu_sDil("&Yeni", sDil)
        Else
            btn_Goster.Text = Sorgu_sDil("&Göster", sDil)
        End If
    End Sub
    Private Sub ToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FisSilToolStripMenuItem1.Click
        fis_sil()
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
    Private Sub txt_musteriNo_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles txt_musteriNo.Validating
        musteri_kontrol()
    End Sub
    Private Sub sec_sCekSenetTipi_EditValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles sec_sCekSenetTipi.EditValueChanged
        dataload_tbCekSenetIslem(Trim(sec_sCekSenetTipi.EditValue))
        gorunum_kontrol()
    End Sub
    Private Sub sec_nCekSenetIslem_EditValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles sec_nCekSenetIslem.EditValueChanged
        gorunum_kontrol()
    End Sub
    Private Sub BarButtonItem1_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btn_AltSatirEkle.ItemClick
        kayit_ekle()
    End Sub
    Private Sub BarButtonItem2_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btn_AltSatirSil.ItemClick
        satir_sil()
    End Sub
    Private Sub BarButtonItem3_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btn_AltFisSil.ItemClick
        fis_sil()
    End Sub
    Private Sub BarButtonItem4_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem4.ItemClick
        raporla(0)
    End Sub
    Private Sub BarButtonItem5_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem5.ItemClick
        fis_sec()
    End Sub
    Private Sub BarButtonItem6_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem6.ItemClick
        tbSonKod("tbCekSenet")
    End Sub
    Private Sub BarButtonItem7_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem7.ItemClick
        analiz_Firma_karti()
    End Sub
    Private Sub BarButtonItem8_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem8.ItemClick
        analiz_cari_hareket()
    End Sub
    Private Sub ÇekSenetHareketleriToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ÇekSenetHareketleriToolStripMenuItem.Click
        analiz_tbCekSenet_Hareket()
    End Sub
    Private Sub BarButtonItem9_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem9.ItemClick
        raporla(0)
    End Sub
    Private Sub BarButtonItem10_ItemClick(ByVal sender As Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem10.ItemClick
        raporla(1)
    End Sub
    Private Sub BarButtonItem11_ItemClick(ByVal sender As Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem11.ItemClick
        raporla(2)
    End Sub
    Private Sub BarButtonItem12_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btn_FisSil.ItemClick
        fis_sil()
    End Sub
    Private Sub BarButtonItem13_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem13.ItemClick
        If Me.WindowState = FormWindowState.Normal Then
            Me.WindowState = FormWindowState.Maximized
        ElseIf Me.WindowState = FormWindowState.Maximized Then
            Me.WindowState = FormWindowState.Normal
        End If
    End Sub
    Private Sub BarButtonItem14_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btn_SatirEkle.ItemClick
        kayit_ekle()
    End Sub
    Private Sub BarButtonItem16_ItemClick(ByVal sender As Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btn_SatirSil.ItemClick
        satir_sil()
    End Sub
    Private Sub BarButtonItem18_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem18.ItemClick
        analiz_Firma_karti()
    End Sub
    Private Sub BarButtonItem19_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem19.ItemClick
        analiz_tbCekSenet_Hareket()
    End Sub
    Private Sub BarButtonItem20_ItemClick(ByVal sender As Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem20.ItemClick
        analiz_cari_hareket()
    End Sub
    Private Sub BarButtonItem21_ItemClick(ByVal sender As Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem21.ItemClick
        analiz_bakiye()
    End Sub
    Private Sub BakiyeAnaliziToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BakiyeAnaliziToolStripMenuItem.Click
        analiz_bakiye()
    End Sub
    Private Sub BarButtonItem22_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem22.ItemClick
        GridView1.ColumnsCustomization()
    End Sub
    Private Sub BarButtonItem23_ItemClick(ByVal sender As Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem23.ItemClick
        gorunum_kaydet()
    End Sub
    Private Sub sec_bKilitli_CheckStateChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles sec_bKilitli.CheckStateChanged
        If bLoaded = True Then
            Dim dr As DataRow
            For Each dr In ds_tbCekSenet.Tables(0).Rows
                dr("bKilitli") = sec_bKilitli.Checked
                dr.EndEdit()
                tbCekSenetBordro_kaydet_duzelt(dr("nBordroSatirID"), dr("nCekSenetIslem"), dr("nFirmaID"), dr("dteBordroTarihi"), dr("lBordroNo"), dr("nCekSenetID"), dr("nOncekiBordroSatirID"), dr("nOncekiCekSenetIslem"), dr("nCariHareketID"), dr("nBorcluFirmaID"), dr("nProtestoMasrafiFirmaID"), dr("lProtestoMasrafi"), dr("dteValorTarihi"), dr("bMuhasebeyeIslendimi"), dr("sKullaniciAdi"), dr("dteKayitTarihi"), dr("bKilitli"))
            Next
        End If
    End Sub
    Private Sub sDoviz_Tek()
        Dim frm As New frm_tbDoviz
        Dim dr As DataRow
        Dim dr1 As DataRow
        dr = GridView1.GetDataRow(GridView1.FocusedRowHandle)
        frm.firmano = firmano
        frm.donemno = donemno
        frm.connection = connection
        frm.sText = "SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT     sDovizCinsi as sKod,sAciklama as sAciklama FROM         tbDovizCinsi"
        Dim ds_tbDovizHareketi As DataSet
        ds_tbDovizHareketi = sorgu(String.Format("SELECT     sDovizCinsi1, lDovizKuru1, lDovizMiktari1 FROM         tbFirmaHareketi WHERE     (nHareketID = {0} )", dr("nCariHareketID")))
        If ds_tbDovizHareketi.Tables(0).Rows.Count > 0 And dr("nCariHareketID") > 0 Then
            dr1 = ds_tbDovizHareketi.Tables(0).Rows(0)
            frm.sec_lDovizKuru.EditValue = sorgu_sayi(dr1("lDovizKuru1"), 0)
            frm.sDovizCinsi = dr1("sDovizCinsi1").ToString
            frm.txt_lTutar.EditValue = FormatNumber(sorgu_sayi(dr("lTutar"), 0), 2)
            If frm.ShowDialog() = Windows.Forms.DialogResult.OK Then
                If XtraMessageBox.Show(frm.sec_sDovizCinsi.EditValue & Sorgu_sDil(" Kodunu Dövize Atamak Ýstediðinize Emin misiniz...?", sDil), Sorgu_sDil("Dikkat", sDil), MessageBoxButtons.YesNo, MessageBoxIcon.Question) = MsgBoxResult.Yes Then
                    Dim sayi As Integer = 0
                    sayi = GridView1.FocusedRowHandle
                    dr = GridView1.GetDataRow(GridView1.FocusedRowHandle)
                    dr("sDovizCinsi2") = frm.sec_sDovizCinsi.EditValue.ToString
                    dr("lDovizKuru2") = sorgu_sayi(frm.sec_lDovizKuru.EditValue, 0)
                    If dr("lDovizKuru2") = 0 Then
                        dr("sDovizCinsi2") = ""
                    End If
                    If Trim(dr("sDovizCinsi2")) = "" Then
                        dr("lDovizKuru2") = 0
                        dr("lDovizMiktari2") = 0
                    End If
                    'Doviz Hesapla
                    If Trim(dr("sDovizCinsi2").ToString) <> "" Then
                        If dr("lDovizKuru2") = 0 Then
                            dr("lDovizKuru2") = 1
                        End If
                        dr("lDovizMiktari2") = Math.Abs(dr("lTutar")) / dr("lDovizKuru2")
                    End If
                    tutar_hesapla(sayi)
                    'If sec_nCekSenetIslem.EditValue = 10 Then
                    '    tbFirmaHareketi_DovizCinsi_kaydet_duzelt(dr("nCekSenetID"), dr("sDovizCinsi1"), dr("lDovizMiktari1"), dr("lDovizKuru1"), dr("sDovizCinsi2"), dr("lDovizMiktari2"), dr("lDovizKuru2"), kullaniciadi, Now)
                    'End If
                    'sayi += 1
                    XtraMessageBox.Show(Sorgu_sDil("Tamamlandý", sDil), Sorgu_sDil("Dikkat", sDil), MessageBoxButtons.OK, MessageBoxIcon.Information)
                End If
            End If
        End If
        dr = Nothing
        dr1 = Nothing
        frm.Close()
        frm = Nothing
    End Sub
    Private Sub sDoviz_toplu()
        Dim frm As New frm_tbDoviz
        Dim dr As DataRow
        Dim dr1 As DataRow
        dr = GridView1.GetDataRow(GridView1.FocusedRowHandle)
        frm.firmano = firmano
        frm.donemno = donemno
        frm.connection = connection
        frm.sText = "SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT     sDovizCinsi as sKod,sAciklama as sAciklama FROM         tbDovizCinsi"
        Dim ds_tbDovizHareketi As DataSet
        ds_tbDovizHareketi = sorgu("SELECT     sDovizCinsi1, lDovizKuru1, lDovizMiktari1 FROM         tbFirmaHareketi WHERE     (nHareketID = " & dr("nCariHareketID") & " )")
        If ds_tbDovizHareketi.Tables(0).Rows.Count > 0 And dr("nCariHareketID") > 0 Then
            dr1 = ds_tbDovizHareketi.Tables(0).Rows(0)
            frm.sec_lDovizKuru.EditValue = sorgu_sayi(dr1("lDovizKuru1"), 0)
            frm.sDovizCinsi = dr1("sDovizCinsi1").ToString
            frm.txt_lTutar.EditValue = FormatNumber(sorgu_sayi(dr("lTutar"), 0), 2)
            If frm.ShowDialog() = Windows.Forms.DialogResult.OK Then
                If XtraMessageBox.Show(frm.sec_sDovizCinsi.EditValue & Sorgu_sDil(" Kodunu Dövizlere Atamak Ýstediðinize Emin misiniz...?", sDil), Sorgu_sDil("Dikkat", sDil), MessageBoxButtons.YesNo, MessageBoxIcon.Question) = MsgBoxResult.Yes Then
                    Dim sayi As Integer = 0
                    For Each dr In ds_tbCekSenet.Tables(0).Rows
                        sayi = GridView1.FocusedRowHandle
                        dr("sDovizCinsi2") = frm.sec_sDovizCinsi.EditValue.ToString
                        dr("lDovizKuru2") = sorgu_sayi(frm.sec_lDovizKuru.EditValue, 0)
                        If dr("lDovizKuru2") = 0 Then
                            dr("sDovizCinsi2") = ""
                        End If
                        If Trim(dr("sDovizCinsi2")) = "" Then
                            dr("lDovizKuru2") = 0
                            dr("lDovizMiktari2") = 0
                        End If
                        'Doviz Hesapla
                        If Trim(dr("sDovizCinsi2").ToString) <> "" Then
                            If dr("lDovizKuru2") = 0 Then
                                dr("lDovizKuru2") = 1
                            End If
                            dr("lDovizMiktari2") = Math.Abs(dr("lTutar")) / dr("lDovizKuru2")
                        End If
                        tutar_hesapla(sayi)
                        'If sec_nCekSenetIslem.EditValue = 10 Then
                        '    tbFirmaHareketi_DovizCinsi_kaydet_duzelt(dr("nCekSenetID"), dr("sDovizCinsi1"), dr("lDovizMiktari1"), dr("lDovizKuru1"), dr("sDovizCinsi2"), dr("lDovizMiktari2"), dr("lDovizKuru2"), kullaniciadi, Now)
                        'End If
                        sayi += 1
                    Next
                    XtraMessageBox.Show(Sorgu_sDil("Tamamlandý", sDil), Sorgu_sDil("Dikkat", sDil), MessageBoxButtons.OK, MessageBoxIcon.Information)
                End If
            End If
        End If
        dr = Nothing
        dr1 = Nothing
        frm.Close()
        frm = Nothing
    End Sub
    Private Sub BarButtonItem1_ItemClick_1(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem1.ItemClick
        sDoviz_Tek()
    End Sub
    Private Sub btn_DegerYay_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btn_DegerYay.ItemClick
        If GridView1.RowCount > 0 Then
            If XtraMessageBox.Show(Sorgu_sDil("[" & GridView1.FocusedColumn().Caption & "] Kolonundaki verileri Aþaðý Doðru Yaymak istediðinize Emin misiniz...?", sDil), Sorgu_sDil("Dikkat", sDil), MessageBoxButtons.YesNo, MessageBoxIcon.Question) = MsgBoxResult.Yes Then
                degeryay(GridView1.FocusedColumn().FieldName, True)
            End If
        End If
    End Sub
    Private Sub BarButtonItem2_ItemClick_1(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem2.ItemClick
        sDoviz_toplu()
    End Sub
    Private Sub BarButtonItem3_ItemClick_1(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem3.ItemClick
        tbEditor("tbBanka")
        dataload_tbBankaKodu()
    End Sub
    Private Sub BarButtonItem12_ItemClick_1(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem12.ItemClick
        tbEditor("tbBankaSubesi")
        If GridView1.RowCount > 0 Then
            dataload_tbBankaSubeKodu(dr("sBankaKodu").ToString)
        End If
    End Sub
    Private Sub tbEditor(ByVal table As String, Optional ByVal form As String = "", Optional ByVal sKriter As String = "")
        Dim frm As New frm_Table_Edit
        frm.firmano = firmano
        frm.donemno = donemno
        frm.connection = SQLconnection
        frm.kullanici = kullanici
        frm.m_TableName = table
        form = "frm_" + table
        frm.sKriter = sKriter
        frm.Text = "Tablo Editörü-" + table
        'frm.MdiParent = Me
        If yetki_kontrol(kullanici, form) = True Then
            frm.ShowDialog()
        End If
    End Sub
End Class