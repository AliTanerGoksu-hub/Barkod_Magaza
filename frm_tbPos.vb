Imports DevExpress.XtraEditors
Public Class frm_tbPos
    Public firmano = 100
    Public donemno = 1
    Public connection
    Public islem As String
    Public sKasaIletisim As String = ""
    Dim loaded As Boolean = False
    Private Sub frm_tbPos_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        'Try
        '    DataSet1.WriteXml("c:\Formlar\Pos\Pos.xml")
        'Catch ex As Exception
        'End Try
        'loaded = True
    End Sub
    Private Sub frm_tbPos_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            dataload()
        Catch ex As Exception
        End Try
        dataload_depo()
        DateEdit1.EditValue = dteSistemTarihi
        loaded = True
        Me.Name = Name.ToString + islem
        Try
            gorunum_yukle()
        Catch ex As Exception
        End Try
        Me.Text = Me.Text.ToString + islem
    End Sub
    Private Sub dataload()
        Dim s As String = "c:\Formlar\Pos\Pos.xml"
        Dim dosya As New IO.FileInfo(s)
        If dosya.Exists Then
            DataSet1.Clear()
            DataSet1.ReadXml(s)
        End If
    End Sub
    Private Sub dataload_depo()
        sec_depo.DataSource = sorgu(sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT     sDepo, sAciklama FROM         tbDepo Where sDepo <> '' ")).Tables(0)
    End Sub
    Private Sub dataload_sFiyatTipi()
        sec_sFiyatTipi.DataSource = sorgu(sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT     sFiyatTipi, sAciklama FROM         tbFiyatTipi WHERE     (sFiyatTipi <> '') and (aktif = 1) and (aktifDepo like '%" & Trim(sDepo) & "%') ")).Tables(0)
    End Sub
    Private Function sorgu(ByVal query As String) As DataSet
        Dim con As New OleDb.OleDbConnection
        Dim cmd As New OleDb.OleDbCommand
        Dim adapter As New OleDb.OleDbDataAdapter
        con.ConnectionString = connection
        adapter.SelectCommand = cmd
        cmd.CommandText = query
        cmd.Connection = con
        con.Open()
        Dim DS As New DataSet
        Dim N As Integer = adapter.Fill(DS, "TABLE1")
        con.Close()
        Return DS
    End Function
    Private Function sorgu_query(ByVal query As String) As String
        query = Replace(query, "*!F", "F0" + firmano.ToString)
        query = Replace(query, "!D", "D000" + donemno.ToString)
        Return query
    End Function
    Private Sub sorgu()
        If GridView1.RowCount > 0 Then
            Dim dr As DataRow = GridView1.GetDataRow(GridView1.FocusedRowHandle)
            If GroupControl1.Visible = False Then
                GroupControl1.Visible = True
                sec_islem.SelectedIndex = 0
                sec_islem.Focus()
                sec_islem.Select()
            ElseIf GroupControl1.Visible = True Then
                If dr("sCihaz") = "InterPos2000" Or dr("sCihaz") = "InterPos2001" Or dr("sCihaz") = "EscortPos3000" Or dr("sCihaz") = "EscortPos4000" Or dr("sCihaz") = "SiemensPos-1" Or dr("sCihaz") = "SiemensPos-2" Or dr("sCihaz") = "SiemensPos-3" Or dr("sCihaz") = "IbmPos" Or dr("sCihaz") = "HuginPos" Then
                    GroupControl3.Visible = True
                    GroupControl3.BringToFront()
                    SpinEdit1.EditValue = dr("lNo")
                    SpinEdit2.EditValue = dr("lSonNo")
                    DateEdit1.EditValue = dteSistemTarihi
                    If sec_islem.SelectedValue <> "Stoklarý Oku" And islem = "Entegrasyon" Then
                        lbl_Tarih.Visible = True
                        DateEdit1.Visible = True
                        DateEdit1.Focus()
                        DateEdit1.SelectAll()
                    Else
                        lbl_Tarih.Visible = False
                        DateEdit1.Visible = False
                        SpinEdit1.Focus()
                        SpinEdit1.SelectAll()
                    End If
                Else
                    Me.DialogResult = Windows.Forms.DialogResult.OK
                End If
            Else
                Me.Close()
            End If
        End If
    End Sub
    Private Sub satir_kontrol()
        'SharpErA495
        'IbmEntry01
        'InterPos2000
        'InterPos2001
        'EscortPos3000
        'EscortPos4000
        'IbmPos
        'NcrPos
        'SiemensPos
        'EpsonPos
        'DigiSm80
        'Bizerba
        'Ishida
        'Epelsa
        'CasLp15
        'CasLp1
        'CasLp2
        'OlivettiLp15
        'Formula7400
        'PscFalcon
        Dim dr As DataRow = GridView1.GetDataRow(GridView1.FocusedRowHandle)
        If islem = "Entegrasyon" Then
            If dr("sCihaz") = "SharpErA495" Then
                sec_islem.Items.Clear()
                sec_islem.Items.AddRange(New Object() {"Stok Kayýtlarýný Oku", "Satislari Oku/EAN", "Satislari Oku/PLU", "Gun Sonu Islemi", "Satislari Aktar", "Satislari Sil/EAN", "Satislari Sil/PLU", "Genel Ciro Raporu", "Kasiyer Ciro Raporu", "Departman Ciro Raporu", "Saatlik Ciro Raporu"})
                sec_islem.SelectedIndex = 0
            ElseIf dr("sCihaz") = "HuginYazarkasa" Then
                sec_islem.Items.Clear()
                sec_islem.Items.AddRange(New Object() {"Stok Kayýtlarýný Oku", "Satislari Oku/EAN", "Satislari Oku/PLU", "Gun Sonu Islemi", "Satislari Aktar", "Satislari Sil/EAN", "Satislari Sil/PLU", "Genel Ciro Raporu", "Kasiyer Ciro Raporu", "Departman Ciro Raporu", "Saatlik Ciro Raporu"})
                sec_islem.SelectedIndex = 0
            ElseIf dr("sCihaz") = "Hugin425TX" Then
                sec_islem.Items.Clear()
                sec_islem.Items.AddRange(New Object() {"Stok Kayýtlarýný Oku", "Satislari Oku/EAN", "Satislari Oku/PLU", "Gun Sonu Islemi", "Satislari Aktar", "Satislari Sil/EAN", "Satislari Sil/PLU", "Genel Ciro Raporu", "Kasiyer Ciro Raporu", "Departman Ciro Raporu", "Saatlik Ciro Raporu"})
                'sec_islem.Items.AddRange(New Object() {"Satislari Oku", "Satislari Aktar", "Genel Ciro Raporu", "Departman Ciro Raporu"})
                sec_islem.SelectedIndex = 0
            ElseIf dr("sCihaz") = "IbmEntry01-1" Then
                sec_islem.Items.Clear()
                sec_islem.Items.AddRange(New Object() {"Satislari Oku", "Satislari Aktar", "Genel Ciro Raporu", "Departman Ciro Raporu"})
                sec_islem.SelectedIndex = 0
            ElseIf dr("sCihaz") = "IbmEntry01-2" Then
                sec_islem.Items.Clear()
                sec_islem.Items.AddRange(New Object() {"Satislari Oku", "Satislari Aktar", "Genel Ciro Raporu", "Departman Ciro Raporu"})
                sec_islem.SelectedIndex = 0
            ElseIf dr("sCihaz") = "IbmEntry01-3" Then
                sec_islem.Items.Clear()
                sec_islem.Items.AddRange(New Object() {"Satislari Oku", "Satislari Aktar", "Genel Ciro Raporu", "Departman Ciro Raporu"})
                sec_islem.SelectedIndex = 0
            ElseIf dr("sCihaz") = "InterPos2000" Then
                sec_islem.Items.Clear()
                sec_islem.Items.AddRange(New Object() {"Stoklarý Oku", "Satislari Oku", "Satislari Aktar", "Genel Ciro Raporu", "Departman Ciro Raporu", "Saatlik Ciro", "Kasiyer Cirosu", "Kasa Cirosu", "Satýþ Raporu"})
                sec_islem.SelectedIndex = 0
            ElseIf dr("sCihaz") = "InterPos2001" Then
                sec_islem.Items.Clear()
                sec_islem.Items.AddRange(New Object() {"Stoklarý Oku", "Satislari Oku", "Satislari Aktar", "Genel Ciro Raporu", "Departman Ciro Raporu", "Saatlik Ciro", "Kasiyer Cirosu", "Kasa Cirosu", "Satýþ Raporu"})
                sec_islem.SelectedIndex = 0
            ElseIf dr("sCihaz") = "HuginPos" Then
                sec_islem.Items.Clear()
                sec_islem.Items.AddRange(New Object() {"Stoklarý Oku", "Satislari Oku", "Satislari Aktar", "Genel Ciro Raporu", "Departman Ciro Raporu", "Saatlik Ciro", "Kasiyer Cirosu", "Kasa Cirosu", "Satýþ Raporu"})
                sec_islem.SelectedIndex = 0
            ElseIf dr("sCihaz") = "EscortPos3000" Then
                sec_islem.Items.Clear()
                sec_islem.Items.AddRange(New Object() {"Stoklarý Oku", "Satislari Oku", "Satislari Aktar", "Genel Ciro Raporu", "Departman Ciro Raporu", "Saatlik Ciro", "Kasiyer Cirosu", "Kasa Cirosu", "Satýþ Raporu"})
                sec_islem.SelectedIndex = 0
            ElseIf dr("sCihaz") = "EscortPos4000" Then
                sec_islem.Items.Clear()
                sec_islem.Items.AddRange(New Object() {"Stoklarý Oku", "Satislari Oku", "Satislari Aktar", "Genel Ciro Raporu", "Departman Ciro Raporu", "Saatlik Ciro", "Kasiyer Cirosu", "Kasa Cirosu", "Satýþ Raporu"})
                sec_islem.SelectedIndex = 0
            ElseIf dr("sCihaz") = "IbmPos" Then
                sec_islem.Items.Clear()
                sec_islem.Items.AddRange(New Object() {"Stoklarý Oku", "Satislari Oku", "Satislari Aktar", "Genel Ciro Raporu", "Departman Ciro Raporu", "Saatlik Ciro", "Kasiyer Cirosu", "Kasa Cirosu"})
                sec_islem.SelectedIndex = 0
            ElseIf dr("sCihaz") = "NcrPos" Then
                sec_islem.Items.Clear()
                sec_islem.Items.AddRange(New Object() {"Satislari Oku", "Satislari Aktar", "Genel Ciro Raporu", "Departman Ciro Raporu", "Saatlik Ciro", "Kasiyer Cirosu"})
                sec_islem.SelectedIndex = 0
            ElseIf dr("sCihaz") = "SiemensPos-1" Then
                sec_islem.Items.Clear()
                sec_islem.Items.AddRange(New Object() {"Stoklarý Oku", "Satislari Oku", "Satislari Aktar", "Genel Ciro Raporu", "Departman Ciro Raporu", "Saatlik Ciro", "Kasiyer Cirosu"})
                sec_islem.SelectedIndex = 0
            ElseIf dr("sCihaz") = "SiemensPos-2" Then
                sec_islem.Items.Clear()
                sec_islem.Items.AddRange(New Object() {"Stoklarý Oku", "Satislari Oku", "Satislari Aktar", "Genel Ciro Raporu", "Departman Ciro Raporu", "Saatlik Ciro", "Kasiyer Cirosu"})
                sec_islem.SelectedIndex = 0
            ElseIf dr("sCihaz") = "SiemensPos-3" Then
                sec_islem.Items.Clear()
                sec_islem.Items.AddRange(New Object() {"Stoklarý Oku", "Satislari Oku", "Satislari Aktar", "Genel Ciro Raporu", "Departman Ciro Raporu", "Saatlik Ciro", "Kasiyer Cirosu"})
                sec_islem.SelectedIndex = 0
            ElseIf dr("sCihaz") = "EpsonPos" Then
                sec_islem.Items.Clear()
                sec_islem.Items.AddRange(New Object() {"Satislari Oku", "Satislari Aktar", "Genel Ciro Raporu", "Departman Ciro Raporu", "Saatlik Ciro", "Kasiyer Cirosu"})
                sec_islem.SelectedIndex = 0
            ElseIf dr("sCihaz") = "DigiSm80" Then
                sec_islem.Items.Clear()
                sec_islem.Items.AddRange(New Object() {"Stoklari Oku"})
                sec_islem.SelectedIndex = 0
            ElseIf dr("sCihaz") = "Bizerba" Then
                sec_islem.Items.Clear()
                sec_islem.Items.AddRange(New Object() {"Stoklari Oku"})
                sec_islem.SelectedIndex = 0
            ElseIf dr("sCihaz") = "Toledo" Then
                sec_islem.Items.Clear()
                sec_islem.Items.AddRange(New Object() {"Stoklari Oku"})
                sec_islem.SelectedIndex = 0
            ElseIf dr("sCihaz") = "AveryBarkel" Then
                sec_islem.Items.Clear()
                sec_islem.Items.AddRange(New Object() {"Stoklari Oku"})
                sec_islem.SelectedIndex = 0
            ElseIf dr("sCihaz") = "Ishida" Then
                sec_islem.Items.Clear()
                sec_islem.Items.AddRange(New Object() {"Stoklari Oku"})
                sec_islem.SelectedIndex = 0
            ElseIf dr("sCihaz") = "Epelsa" Then
                sec_islem.Items.Clear()
                sec_islem.Items.AddRange(New Object() {"Stoklari Oku"})
                sec_islem.SelectedIndex = 0
            ElseIf dr("sCihaz") = "CasLp15" Then
                sec_islem.Items.Clear()
                sec_islem.Items.AddRange(New Object() {"Stoklari Oku"})
                sec_islem.SelectedIndex = 0
            ElseIf dr("sCihaz") = "CasLp1" Then
                sec_islem.Items.Clear()
                sec_islem.Items.AddRange(New Object() {"Stoklari Oku"})
                sec_islem.SelectedIndex = 0
            ElseIf dr("sCihaz") = "CasLp1-1" Then
                sec_islem.Items.Clear()
                sec_islem.Items.AddRange(New Object() {"Stoklari Oku"})
                sec_islem.SelectedIndex = 0
            ElseIf dr("sCihaz") = "CasLp2" Then
                sec_islem.Items.Clear()
                sec_islem.Items.AddRange(New Object() {"Stoklari Oku"})
                sec_islem.SelectedIndex = 0
            ElseIf dr("sCihaz") = "Dibal" Then
                sec_islem.Items.Clear()
                sec_islem.Items.AddRange(New Object() {"Stoklari Oku"})
                sec_islem.SelectedIndex = 0
            ElseIf dr("sCihaz") = "Densi" Then
                sec_islem.Items.Clear()
                sec_islem.Items.AddRange(New Object() {"Stoklari Oku"})
                sec_islem.SelectedIndex = 0
            ElseIf dr("sCihaz") = "OlivettiLp15" Then
                sec_islem.Items.Clear()
                sec_islem.Items.AddRange(New Object() {"Stoklari Oku"})
                sec_islem.SelectedIndex = 0
            ElseIf dr("sCihaz") = "Formula7400" Then
                sec_islem.Items.Clear()
                sec_islem.Items.AddRange(New Object() {"Stoklari Oku"})
                sec_islem.SelectedIndex = 0
            ElseIf dr("sCihaz") = "PscFalcon" Then
                sec_islem.Items.Clear()
                sec_islem.Items.AddRange(New Object() {"Stoklari Oku"})
                sec_islem.SelectedIndex = 0
            End If
        ElseIf islem = "Transfer" Then
            If dr("sCihaz") = "SharpErA495" Then
                sec_islem.Items.Clear()
                sec_islem.Items.AddRange(New Object() {"Yeni Açýlan Stoklar", "Satýþ Fiyatý Deðiþenler", "Plu+Tartýlý Stoklar"})
                sec_islem.SelectedIndex = 0
            ElseIf dr("sCihaz") = "HuginYazarkasa" Then
                sec_islem.Items.Clear()
                sec_islem.Items.AddRange(New Object() {"Yeni Açýlan Stoklar", "Satýþ Fiyatý Deðiþenler", "Plu+Tartýlý Stoklar"})
                sec_islem.SelectedIndex = 0
            ElseIf dr("sCihaz") = "Hugin425TX" Then
                sec_islem.Items.Clear()
                sec_islem.Items.AddRange(New Object() {"Secili Stoklar", "Tüm Stoklar"})
                sec_islem.SelectedIndex = 0
            ElseIf dr("sCihaz") = "IbmEntry01-1" Then
                sec_islem.Items.Clear()
                sec_islem.Items.AddRange(New Object() {"Tüm Stoklar", "Secili Stoklar"})
                sec_islem.SelectedIndex = 0
            ElseIf dr("sCihaz") = "IbmEntry01-2" Then
                sec_islem.Items.Clear()
                sec_islem.Items.AddRange(New Object() {"Tüm Stoklar", "Secili Stoklar"})
                sec_islem.SelectedIndex = 0
            ElseIf dr("sCihaz") = "IbmEntry01-3" Then
                sec_islem.Items.Clear()
                sec_islem.Items.AddRange(New Object() {"Tüm Stoklar", "Secili Stoklar"})
                sec_islem.SelectedIndex = 0
            ElseIf dr("sCihaz") = "InterPos2000" Then
                sec_islem.Items.Clear()
                sec_islem.Items.AddRange(New Object() {"Tüm Stoklar", "Seçili Stoklar", "Deðiþen Stoklar", "Cariler", "Cariler2", "Promosyonlar", "Programlar", "Taksitli Fiyatlar"})
                sec_islem.SelectedIndex = 0
            ElseIf dr("sCihaz") = "InterPos2001" Then
                sec_islem.Items.Clear()
                sec_islem.Items.AddRange(New Object() {"Tüm Stoklar", "Seçili Stoklar", "Deðiþen Stoklar", "Cariler", "Cariler2", "Promosyonlar", "Programlar", "Taksitli Fiyatlar", "Toptan Fiyatlar"})
                sec_islem.SelectedIndex = 0
            ElseIf dr("sCihaz") = "HuginPos" Then
                sec_islem.Items.Clear()
                sec_islem.Items.AddRange(New Object() {"Tüm Stoklar", "Seçili Stoklar", "Deðiþen Stoklar", "Cariler", "Cariler2", "Promosyonlar", "Programlar"})
                sec_islem.SelectedIndex = 0
            ElseIf dr("sCihaz") = "EscortPos3000" Then
                sec_islem.Items.Clear()
                sec_islem.Items.AddRange(New Object() {"Tüm Stoklar", "Seçili Stoklar", "Deðiþen Stoklar", "Cariler", "Promosyonlar", "Programlar"})
                sec_islem.SelectedIndex = 0
            ElseIf dr("sCihaz") = "EscortPos4000" Then
                sec_islem.Items.Clear()
                sec_islem.Items.AddRange(New Object() {"Tüm Stoklar", "Seçili Stoklar", "Deðiþen Stoklar", "Cariler", "Promosyonlar", "Programlar"})
                sec_islem.SelectedIndex = 0
            ElseIf dr("sCihaz") = "IbmPos" Then
                sec_islem.Items.Clear()
                sec_islem.Items.AddRange(New Object() {"Tüm Stoklar", "Deðiþen Stoklar", "Seçili Stoklar"})
                sec_islem.SelectedIndex = 0
            ElseIf dr("sCihaz") = "NcrPos" Then
                sec_islem.Items.Clear()
                sec_islem.Items.AddRange(New Object() {"Tüm Stoklar", "Seçili Stoklar"})
                sec_islem.SelectedIndex = 0
            ElseIf dr("sCihaz") = "SiemensPos-1" Then
                sec_islem.Items.Clear()
                sec_islem.Items.AddRange(New Object() {"Tüm Stoklar", "Seçili Stoklar", "Müþteriler"})
                sec_islem.SelectedIndex = 0
            ElseIf dr("sCihaz") = "SiemensPos-2" Then
                sec_islem.Items.Clear()
                sec_islem.Items.AddRange(New Object() {"Tüm Stoklar", "Seçili Stoklar"})
                sec_islem.SelectedIndex = 0
            ElseIf dr("sCihaz") = "SiemensPos-3" Then
                sec_islem.Items.Clear()
                sec_islem.Items.AddRange(New Object() {"Tüm Stoklar", "Seçili Stoklar"})
                sec_islem.SelectedIndex = 0
            ElseIf dr("sCihaz") = "EpsonPos" Then
                sec_islem.Items.Clear()
                sec_islem.Items.AddRange(New Object() {"Tüm Stoklar", "Seçili Stoklar"})
                sec_islem.SelectedIndex = 0
            ElseIf dr("sCihaz") = "DigiSm80" Then
                sec_islem.Items.Clear()
                sec_islem.Items.AddRange(New Object() {"Seçili Stoklar", "Tartýlý Stoklar"})
                sec_islem.SelectedIndex = 0
            ElseIf dr("sCihaz") = "Bizerba" Then
                sec_islem.Items.Clear()
                sec_islem.Items.AddRange(New Object() {"Seçili Stoklar", "Tartýlý Stoklar"})
                sec_islem.SelectedIndex = 0
            ElseIf dr("sCihaz") = "AveryBarkel" Then
                sec_islem.Items.Clear()
                sec_islem.Items.AddRange(New Object() {"Seçili Stoklar", "Tartýlý Stoklar"})
                sec_islem.SelectedIndex = 0
            ElseIf dr("sCihaz") = "Ishida" Then
                sec_islem.Items.Clear()
                sec_islem.Items.AddRange(New Object() {"Seçili Stoklar", "Tartýlý Stoklar"})
                sec_islem.SelectedIndex = 0
            ElseIf dr("sCihaz") = "Toledo" Then
                sec_islem.Items.Clear()
                sec_islem.Items.AddRange(New Object() {"Seçili Stoklar", "Tartýlý Stoklar"})
                sec_islem.SelectedIndex = 0
            ElseIf dr("sCihaz") = "Epelsa" Then
                sec_islem.Items.Clear()
                sec_islem.Items.AddRange(New Object() {"Seçili Stoklar", "Tartýlý Stoklar"})
                sec_islem.SelectedIndex = 0
            ElseIf dr("sCihaz") = "CasLp15" Then
                sec_islem.Items.Clear()
                sec_islem.Items.AddRange(New Object() {"Seçili Stoklar", "Tartýlý Stoklar"})
                sec_islem.SelectedIndex = 0
            ElseIf dr("sCihaz") = "CasLp1" Then
                sec_islem.Items.Clear()
                sec_islem.Items.AddRange(New Object() {"Seçili Stoklar", "Tartýlý Stoklar"})
                sec_islem.SelectedIndex = 0
            ElseIf dr("sCihaz") = "CasLp1-1" Then
                sec_islem.Items.Clear()
                sec_islem.Items.AddRange(New Object() {"Seçili Stoklar", "Tartýlý Stoklar"})
                sec_islem.SelectedIndex = 0
            ElseIf dr("sCihaz") = "CasLp2" Then
                sec_islem.Items.Clear()
                sec_islem.Items.AddRange(New Object() {"Seçili Stoklar", "Tartýlý Stoklar"})
                sec_islem.SelectedIndex = 0
            ElseIf dr("sCihaz") = "Dibal" Then
                sec_islem.Items.Clear()
                sec_islem.Items.AddRange(New Object() {"Seçili Stoklar", "Tartýlý Stoklar"})
                sec_islem.SelectedIndex = 0
            ElseIf dr("sCihaz") = "Densi" Then
                sec_islem.Items.Clear()
                sec_islem.Items.AddRange(New Object() {"Seçili Stoklar", "Tartýlý Stoklar"})
                sec_islem.SelectedIndex = 0
            ElseIf dr("sCihaz") = "OlivettiLp15" Then
                sec_islem.Items.Clear()
                sec_islem.Items.AddRange(New Object() {"Seçili Stoklar", "Tartýlý Stoklar"})
                sec_islem.SelectedIndex = 0
            ElseIf dr("sCihaz") = "Formula7400" Then
                sec_islem.Items.Clear()
                sec_islem.Items.AddRange(New Object() {"Seçili Stoklar"})
                sec_islem.SelectedIndex = 0
            ElseIf dr("sCihaz") = "PscFalcon" Then
                sec_islem.Items.Clear()
                sec_islem.Items.AddRange(New Object() {"Seçili Stoklar"})
                sec_islem.SelectedIndex = 0
            End If
        End If
    End Sub
    Private Sub gorunum_yazdir()
        printlink1.CreateDocument(ps)
        ps.PreviewRibbonFormEx.Show()
    End Sub
    Private Sub gorunum_kaydet()
        GridView1.SaveLayoutToRegistry("SOFTWARE\BusinessSmart\VIEW\MAGAZA\POS\" & Me.Name.ToString & "")
        XtraMessageBox.Show(Sorgu_sDil("Görünüm Kaydedildi", sDil), Sorgu_sDil("Dikkat", sDil), MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub
    Private Sub gorunum_yukle()
        For Each btn As DevExpress.XtraBars.BarItem In BarManager1.Items
            btn.Caption = Sorgu_sDil(btn.Caption, sDil)
        Next
        For Each clmn As DevExpress.XtraGrid.Columns.GridColumn In GridView1.Columns
            clmn.Caption = Sorgu_sDil(clmn.Caption, sDil)
        Next
        SimpleButton1.Text = Sorgu_sDil(SimpleButton1.Text, sDil)
        SimpleButton2.Text = Sorgu_sDil(SimpleButton2.Text, sDil)
        SimpleButton3.Text = Sorgu_sDil(SimpleButton3.Text, sDil)
        GridView1.RestoreLayoutFromRegistry("SOFTWARE\BusinessSmart\VIEW\MAGAZA\POS\" & Me.Name.ToString & "")
    End Sub
    Private Sub satir_sil()
        If XtraMessageBox.Show(Sorgu_sDil("Satýrý Silmek Ýstediðinize Emin misiniz...?", sDil), Sorgu_sDil("Dikkat", sDil), MessageBoxButtons.YesNo, MessageBoxIcon.Question) = MsgBoxResult.Yes Then
            Dim dr As DataRow
            dr = GridView1.GetDataRow(GridView1.FocusedRowHandle)
            dr.Delete()
            GridControl1.EndUpdate()
            DataSet1.EndInit()
        End If
    End Sub
    Private Sub satir_ekle()
        Dim dr As DataRow = DataSet1.Tables(0).NewRow
        If sKasaIletisim = "Ofline" Or sKasaIletisim = "Ofline+Online" Then
            dr("sCihaz") = "SharpErA495"
            dr("lNo") = 1
            dr("lSonNo") = 1
            dr("sPath") = "C"
            dr("sFile") = "\Persis\"
            dr("sPort") = "COM1"
            dr("sAciklama") = ""
            dr("sFiyatTipi") = 1
            dr("sRun") = ""
            dr("sGramaj") = "27"
            dr("sAdetli") = "28"
            dr("nSinif") = 1
            dr("sSinif") = ""
        ElseIf sKasaIletisim = "Online" Or sKasaIletisim = "Ofline+Online" Then
            dr("sCihaz") = "InterPos2001"
            dr("lNo") = 1
            dr("lSonNo") = 1
            dr("sPath") = "C"
            dr("sFile") = "\POSFENEL\"
            dr("sPort") = "TCP/IP"
            dr("sAciklama") = ""
            dr("sFiyatTipi") = 1
            dr("sRun") = ""
            dr("sGramaj") = "27"
            dr("sAdetli") = "28"
            dr("nSinif") = 1
            dr("sSinif") = ""
        End If
        DataSet1.Tables(0).Rows.Add(dr)
    End Sub
    Private Sub MenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        satir_ekle()
    End Sub
    Private Sub GridControl1_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles GridControl1.DoubleClick
        sorgu()
    End Sub
    Private Sub GridControl1_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles GridControl1.KeyDown
        If e.KeyCode = Keys.Enter Then
            sorgu()
        ElseIf e.KeyCode = Keys.Escape Then
            Me.Close()
        End If
    End Sub
    Private Sub MenuItem3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        satir_sil()
    End Sub
    Private Sub MenuItem2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        GridView1.OptionsBehavior.Editable = True
    End Sub
    Private Sub EkleToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EkleToolStripMenuItem.Click
        satir_ekle()
    End Sub
    Private Sub DüzeltToolStripMenuItem_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles DüzeltToolStripMenuItem.Click
        GridView1.OptionsBehavior.Editable = True
    End Sub
    Private Sub SilToolStripMenuItem_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles SilToolStripMenuItem.Click
        satir_sil()
    End Sub
    Private Sub SimpleButton2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SimpleButton2.Click
        Me.Close()
    End Sub
    Private Sub SimpleButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SimpleButton1.Click
        sorgu()
    End Sub
    Private Sub GörünümüDüzenleToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GörünümüDüzenleToolStripMenuItem.Click
        GridView1.ColumnsCustomization()
    End Sub
    Private Sub GörünümüKaydetToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GörünümüKaydetToolStripMenuItem.Click
        gorunum_kaydet()
    End Sub
    Private Sub GörünümüYazdýrToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GörünümüYazdýrToolStripMenuItem.Click
        gorunum_yazdir()
    End Sub
    Private Sub GridView1_CustomDrawRowIndicator(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Grid.RowIndicatorCustomDrawEventArgs) Handles GridView1.CustomDrawRowIndicator
        If e.RowHandle >= 0 Then
            e.Info.DisplayText = e.RowHandle + 1
        Else
            e.Info.DisplayText = ""
        End If
    End Sub
    Private Sub GridView1_FocusedRowChanged(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs) Handles GridView1.FocusedRowChanged
        If loaded = True Then
            Try
                satir_kontrol()
            Catch ex As Exception
                GroupControl3.Visible = False
                GroupControl1.Visible = False
            End Try
        End If
    End Sub
    Private Sub SimpleButton3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SimpleButton3.Click
        Dim dr As DataRow = GridView1.GetDataRow(GridView1.FocusedRowHandle)
        GridView1.PostEditor()
        dr("lNo") = SpinEdit1.EditValue
        dr("lSonNo") = SpinEdit2.EditValue
        dr("dteTarih") = DateEdit1.EditValue
        dr.EndEdit()
        Me.DialogResult = Windows.Forms.DialogResult.OK
    End Sub
    Private Sub SpinEdit2_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles SpinEdit2.KeyDown
        If e.KeyCode = Keys.Escape Then
            menu_goster()
        End If
    End Sub
    Private Sub SpinEdit2_Validated(ByVal sender As Object, ByVal e As System.EventArgs) Handles SpinEdit2.Validated
        If SpinEdit2.EditValue < SpinEdit1.EditValue Then
            SpinEdit2.EditValue = SpinEdit1.EditValue
        End If
    End Sub
    Private Sub SpinEdit1_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles SpinEdit1.KeyDown
        If e.KeyCode = Keys.Escape Then
            menu_goster()
        End If
    End Sub
    Private Sub SpinEdit1_Validated(ByVal sender As Object, ByVal e As System.EventArgs) Handles SpinEdit1.Validated
        If SpinEdit1.EditValue > SpinEdit2.EditValue Then
            SpinEdit1.EditValue = SpinEdit2.EditValue
        End If
    End Sub
    Private Sub SimpleButton4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SimpleButton4.Click
        menu_goster()
    End Sub
    Private Sub menu_goster()
        GroupControl3.Visible = False
        GroupControl1.Focus()
        GroupControl1.Select()
        sec_islem.Focus()
        sec_islem.Select()
    End Sub
    Private Sub SimpleButton5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SimpleButton5.Click
        GroupControl1.Visible = False
        GridControl1.Focus()
        GridControl1.Select()
    End Sub
    Private Sub SimpleButton6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SimpleButton6.Click
        sorgu()
    End Sub
    Private Sub sec_islem_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles sec_islem.DoubleClick
        sorgu()
    End Sub
    Private Sub sec_islem_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles sec_islem.KeyDown
        If e.KeyCode = Keys.Enter Then
            sorgu()
        ElseIf e.KeyCode = Keys.Escape Then
            GroupControl1.Visible = False
            GridControl1.Focus()
            GridControl1.Select()
        ElseIf e.KeyCode = Keys.Up Then
            If sec_islem.SelectedIndex = 0 Then
                e.Handled = True
                sec_islem.SelectedIndex = sec_islem.Items.Count + 1
                sec_islem.SelectedIndex = sec_islem.Items.Count
            End If
        ElseIf e.KeyCode = Keys.Down Then
            Dim sayi = sec_islem.Items.Count
            If sec_islem.SelectedIndex = sec_islem.Items.Count - 1 Then
                e.Handled = True
                sec_islem.SelectedIndex = 0
            End If
        End If
    End Sub
    Private Sub raporla_excel()
        If XtraMessageBox.Show(Sorgu_sDil("Sonuçlarý Excel Dosyasý Oluþturmak Ýstediðinize Emin misiniz...?", sDil), Sorgu_sDil("Dikkat", sDil), MessageBoxButtons.YesNo, MessageBoxIcon.Question) = MsgBoxResult.Yes Then
            Dim SaveFileDialog1 As New Windows.Forms.SaveFileDialog
            SaveFileDialog1.Filter = "Excel Dosyalarý(*.xls) |*.xls"
            SaveFileDialog1.InitialDirectory = "c:\"
            SaveFileDialog1.FileName = "Rapor.xls"
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
    Private Sub KaydetToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles KaydetToolStripMenuItem.Click
        Try
            DataSet1.WriteXml("c:\Formlar\Pos\Pos.xml")
            GridView1.OptionsBehavior.Editable = False
        Catch ex As Exception
        End Try
        loaded = True
    End Sub
    Private Sub BarButtonItem1_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem1.ItemClick
        satir_ekle()
    End Sub
    Private Sub BarButtonItem2_ItemClick(ByVal sender As Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem2.ItemClick
        GridView1.OptionsBehavior.Editable = True
    End Sub
    Private Sub BarButtonItem3_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem3.ItemClick
        satir_sil()
    End Sub
    Private Sub BarButtonItem4_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem4.ItemClick
        gorunum_yazdir()
    End Sub
    Private Sub BarButtonItem5_ItemClick(ByVal sender As Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem5.ItemClick
        raporla_excel()
    End Sub
    Private Sub BarButtonItem6_ItemClick(ByVal sender As Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem6.ItemClick
        raporla_text()
    End Sub
    Private Sub BarButtonItem7_ItemClick(ByVal sender As Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem7.ItemClick
        raporla_pdf()
    End Sub
    Private Sub sec_exe_ButtonClick(ByVal sender As Object, ByVal e As DevExpress.XtraEditors.Controls.ButtonPressedEventArgs) Handles sec_exe.ButtonClick
        Dim OpenFileDialog1 As New Windows.Forms.OpenFileDialog
        OpenFileDialog1.Title = "Exe Seç..."
        OpenFileDialog1.Filter = "Rapor Dosyalarý (*.exe) |*.exe"
        'OpenFileDialog1.FileName = "c:\"
        OpenFileDialog1.InitialDirectory = "c:\"
        If OpenFileDialog1.ShowDialog = Windows.Forms.DialogResult.OK Then
            Dim dr As DataRow
            dr = GridView1.GetDataRow(GridView1.FocusedRowHandle)
            dr("sRun") = OpenFileDialog1.FileName.ToString
            dr.EndEdit()
        End If
    End Sub
    Private Sub sec_file_ButtonClick(ByVal sender As Object, ByVal e As DevExpress.XtraEditors.Controls.ButtonPressedEventArgs) Handles sec_file.ButtonClick
        Dim SaveFileDialog1 As New Windows.Forms.SaveFileDialog
        SaveFileDialog1.Filter = "Cihaz Dosyalarý(*.*) |*.*"
        SaveFileDialog1.InitialDirectory = "c:\"
        SaveFileDialog1.FileName = ""
        If SaveFileDialog1.ShowDialog = Windows.Forms.DialogResult.OK Then
            Dim dr As DataRow
            dr = GridView1.GetDataRow(GridView1.FocusedRowHandle)
            dr("sFile") = Microsoft.VisualBasic.Right(SaveFileDialog1.FileName.ToString, Len(SaveFileDialog1.FileName.ToString) - 3)
            dr.EndEdit()
        End If
        SaveFileDialog1 = Nothing
    End Sub
    Private Sub HýzlýFiltreleToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles HýzlýFiltreleToolStripMenuItem.Click
        If HýzlýFiltreleToolStripMenuItem.Checked = False Then
            GridView1.OptionsView.ShowAutoFilterRow = True
            GridView1.OptionsView.ShowFilterPanelMode = DevExpress.XtraGrid.Views.Base.ShowFilterPanelMode.Default
            GridView1.OptionsCustomization.AllowFilter = True
            HýzlýFiltreleToolStripMenuItem.Checked = True
        ElseIf HýzlýFiltreleToolStripMenuItem.Checked = True Then
            GridView1.OptionsView.ShowAutoFilterRow = False
            GridView1.OptionsView.ShowFilterPanelMode = DevExpress.XtraGrid.Views.Base.ShowFilterPanelMode.Never
            GridView1.OptionsCustomization.AllowFilter = False
            HýzlýFiltreleToolStripMenuItem.Checked = False
        End If
    End Sub
    Private Sub GridView1_SelectionChanged(ByVal sender As Object, ByVal e As DevExpress.Data.SelectionChangedEventArgs) Handles GridView1.SelectionChanged
        If GridView1.SelectedRowsCount > 1 Then
            Label2.Text = Sorgu_sDil("Kayýt Sayýsý :", sDil) & GridView1.RowCount & " / " & Sorgu_sDil("Satýr :", sDil) & GridView1.FocusedRowHandle + 1 & " / " & Sorgu_sDil("Seçili :", sDil) & GridView1.SelectedRowsCount
        ElseIf GridView1.SelectedRowsCount = 1 Then
            Label2.Text = Sorgu_sDil("Kayýt Sayýsý :", sDil) & GridView1.RowCount & " / " & Sorgu_sDil("Satýr :", sDil) & GridView1.FocusedRowHandle + 1
        Else
            Label2.Text = ""
        End If
    End Sub
End Class