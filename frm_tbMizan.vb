Imports DevExpress.XtraEditors
Public Class frm_tbMizan
    Public firmano
    Public donemno
    Public connection
    Public nFirmaID
    Dim nHesapID
    Public sKodu
    Public kullanici
    Dim conn As New OleDb.OleDbConnection
    Dim con As New OleDb.OleDbConnection
    Dim cmd As New OleDb.OleDbCommand
    Dim adapter As New OleDb.OleDbDataAdapter
    Dim DS As New DataSet
    Dim ds_cari As DataSet
    Public yeni As Boolean = False
    Public bBakiye As Boolean = False
    Dim ds_tbKasa As DataSet
    Dim ds_tbCekAlinan As DataSet
    Dim ds_tbCekVerilen As DataSet
    Dim ds_tbTicariMallar As DataSet
    Dim mevcut_tutar As Decimal = 0
    Dim mevcut As Decimal = 1
    Dim x As Integer = 0

    Private Sub SimpleButton3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SimpleButton3.Click
        dataload(txt_ara.Text, DateEdit1.EditValue, DateEdit2.EditValue)
        GridControl1.Focus()
        GridControl1.Select()
    End Sub
    Private Sub txt_ara_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txt_ara.KeyDown
        If e.KeyCode = Keys.Enter Then
            If IsNumeric(Trim(txt_ara.Text)) = True Then
                If Len(Trim(txt_ara.Text).ToString) < 2 Then
                    txt_ara.Text = Trim(txt_ara.Text) + "  "
                End If

                PanelControl3.Focus()
                PanelControl3.Select()
            End If
        End If
        If e.KeyCode = Keys.Escape Then
            Me.Close()
        End If
    End Sub
    Private Function sorgu_kriter_string(ByVal deger As String, ByVal kriter As String) As String
        Dim sorgu_kriter As String = ""
        If kriter = "Başlar" Then
            sorgu_kriter = " LIKE '" & deger & "%' "
        ElseIf kriter = "Biter" Then
            sorgu_kriter = " LIKE '%" & deger & "' "
        ElseIf kriter = "İçerir" Then
            sorgu_kriter = " LIKE '%" & deger & "%' "
        ElseIf kriter = "Boş" Then
            sorgu_kriter = " IS NULL "
        ElseIf kriter = "Dolu" Then
            sorgu_kriter = " <> '' "
        ElseIf kriter = "Farklı" Then
            sorgu_kriter = " <> '" & deger & "' "
        ElseIf kriter = "Büyük" Then
            sorgu_kriter = " >  '" & deger & "' "
        ElseIf kriter = "Küçük" Then
            sorgu_kriter = " < '" & deger & "' "
        ElseIf kriter = "Eşittir" Then
            sorgu_kriter = " = '" & deger & "' "
        End If
        Return sorgu_kriter
    End Function
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
    Private Sub dataload(ByVal txt_ara As String, ByVal tarih1 As DateTime, ByVal tarih2 As DateTime)
        mevcut_tutar = dataload_mevcut_mal(tarih1, tarih2)
        Dataload_tbAktif(txt_ara, tarih1, tarih2)
        'ToplamlariKirilimlaraUygula(ds_tbAktif.Tables(0))
        'Dataload_tbPasif(tarih1, tarih2)
    End Sub
    Public Sub Dataload_tbAktif(ByVal txt_ara As String, ByVal tarih1 As DateTime, ByVal tarih2 As DateTime)
        Dim kriter As String = ""
        Dim kriter2 As String = ""
        Try
            ds_tbAktif.Tables(0).Clear()
        Catch ex As Exception
        End Try
        If sec_bakiye.Text = "Tümü" Then
            kriter = ""
            kriter2 = ""

        ElseIf sec_bakiye.Text = "Bakiyesi Olanlar" Then
            kriter += "  AND ISNULL(tempBilancoAktif.Simdiki, 0) <> 0"
            kriter2 = " Where ISNULL(Simdiki, 0) <> 0"
        End If
        Dim conn As New OleDb.OleDbConnection
        Dim cmd As New OleDb.OleDbCommand
        Dim adapter As New OleDb.OleDbDataAdapter
        conn.ConnectionString = connection
        adapter.SelectCommand = cmd
        If sec_detay.Text = "Ozet" Then
            cmd.CommandText = sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED 
SELECT 
    tbBilancoGelirTablosuHesaplari.sHesap2, 
    tbBilancoGelirTablosuHesaplari.sHesap3, 
    tbBilancoGelirTablosuHesaplari.sAciklamaTR, 
    tbBilancoGelirTablosuHesaplari.sAciklamaEN, 
    tbBilancoGelirTablosuHesaplari.sAciklamaAR, 
    ISNULL(tempBilancoOnceki.Onceki, 0) AS Onceki, 
    ISNULL(tempBilancoSimdiki.lBorcTutar, 0) AS lBorcTutar, 
    ISNULL(tempBilancoSimdiki.lAlacakTutar, 0) AS lAlacakTutar, 
    CASE WHEN ISNULL(tempBilancoSimdiki.Simdiki, 0) < 0 THEN ABS(tempBilancoSimdiki.Simdiki) ELSE 0 END AS lAlacakBakiye, 
    CASE WHEN ISNULL(tempBilancoSimdiki.Simdiki, 0) > 0 THEN ABS(tempBilancoSimdiki.Simdiki) ELSE 0 END AS lBorcBakiye, 
    ISNULL(tempBilancoSimdiki.Simdiki, 0) AS Simdiki, 
    tbBilancoGelirTablosuHesaplari.bFormulMu, 
    tbBilancoGelirTablosuHesaplari.sHesapSirasi, 
    tbBilancoGelirTablosuHesaplari.nDurum 
FROM 
    tbBilancoGelirTablosuHesaplari 
LEFT OUTER JOIN (
    SELECT 
        HesapKodu, 
        SUM(lBorcTutar) AS lBorcTutar, 
        SUM(lAlacakTutar) AS lAlacakTutar, 
        SUM(Simdiki) AS Simdiki 
    FROM (
        SELECT substring(tbFirma.sKodu, 1, 2) AS HesapKodu, 
               SUM(CASE WHEN tbFirmaHareketi.dteIslemTarihi BETWEEN '" & tarih1 & "' AND '" & tarih2 & "' THEN tbFirmaHareketi.lBorcTutar ELSE 0 END) AS lBorcTutar,
               SUM(CASE WHEN tbFirmaHareketi.dteIslemTarihi BETWEEN '" & tarih1 & "' AND '" & tarih2 & "' THEN tbFirmaHareketi.lAlacakTutar ELSE 0 END) AS lAlacakTutar,
               SUM(tbFirmaHareketi.lBorcTutar - tbFirmaHareketi.lAlacakTutar) AS Simdiki 
        FROM tbFirma, tbFirmaHareketi 
        WHERE tbFirma.nFirmaID = tbFirmaHareketi.nFirmaID AND tbFirmaHareketi.dteIslemTarihi <= '" & tarih2 & "' 
        GROUP BY substring(tbFirma.sKodu, 1, 2) 
        UNION 
        SELECT substring(tbFirma.sKodu, 1, 3) AS HesapKodu, 
               SUM(CASE WHEN tbFirmaHareketi.dteIslemTarihi BETWEEN '" & tarih1 & "' AND '" & tarih2 & "' THEN tbFirmaHareketi.lBorcTutar ELSE 0 END) AS lBorcTutar,
               SUM(CASE WHEN tbFirmaHareketi.dteIslemTarihi BETWEEN '" & tarih1 & "' AND '" & tarih2 & "' THEN tbFirmaHareketi.lAlacakTutar ELSE 0 END) AS lAlacakTutar,
               SUM(tbFirmaHareketi.lBorcTutar - tbFirmaHareketi.lAlacakTutar) AS Simdiki 
        FROM tbFirma, tbFirmaHareketi 
        WHERE tbFirma.nFirmaID = tbFirmaHareketi.nFirmaID AND tbFirmaHareketi.dteIslemTarihi <= '" & tarih2 & "' 
        GROUP BY substring(tbFirma.sKodu, 1, 3) 
        UNION 
        SELECT substring(tbFirma.sKodu, 1, 6) AS HesapKodu, 
               SUM(CASE WHEN tbFirmaHareketi.dteIslemTarihi BETWEEN '" & tarih1 & "' AND '" & tarih2 & "' THEN tbFirmaHareketi.lBorcTutar ELSE 0 END) AS lBorcTutar,
               SUM(CASE WHEN tbFirmaHareketi.dteIslemTarihi BETWEEN '" & tarih1 & "' AND '" & tarih2 & "' THEN tbFirmaHareketi.lAlacakTutar ELSE 0 END) AS lAlacakTutar,
               SUM(tbFirmaHareketi.lBorcTutar - tbFirmaHareketi.lAlacakTutar) AS Simdiki 
        FROM tbFirma, tbFirmaHareketi 
        WHERE tbFirma.nFirmaID = tbFirmaHareketi.nFirmaID AND tbFirmaHareketi.dteIslemTarihi <= '" & tarih2 & "' 
        GROUP BY substring(tbFirma.sKodu, 1, 6) 
        UNION 
        SELECT substring(tbFirma.sKodu, 1, 1) AS HesapKodu, 
               SUM(CASE WHEN tbFirmaHareketi.dteIslemTarihi BETWEEN '" & tarih1 & "' AND '" & tarih2 & "' THEN tbFirmaHareketi.lBorcTutar ELSE 0 END) AS lBorcTutar,
               SUM(CASE WHEN tbFirmaHareketi.dteIslemTarihi BETWEEN '" & tarih1 & "' AND '" & tarih2 & "' THEN tbFirmaHareketi.lAlacakTutar ELSE 0 END) AS lAlacakTutar,
               SUM(tbFirmaHareketi.lBorcTutar - tbFirmaHareketi.lAlacakTutar) AS Simdiki 
        FROM tbFirma, tbFirmaHareketi 
        WHERE tbFirma.nFirmaID = tbFirmaHareketi.nFirmaID AND tbFirmaHareketi.dteIslemTarihi <= '" & tarih2 & "' 
        GROUP BY substring(tbFirma.sKodu, 1, 1)
    ) AS tempBilancoSimdikiGroup 
    GROUP BY HesapKodu
) tempBilancoSimdiki ON tempBilancoSimdiki.HesapKodu = tbBilancoGelirTablosuHesaplari.sHesap3 
LEFT OUTER JOIN (
    SELECT 
        HesapKodu, 
        SUM(Onceki) AS Onceki 
    FROM (
        SELECT substring(tbFirma.sKodu, 1, 2) AS HesapKodu, SUM(tbFirmaHareketi.lBorcTutar - tbFirmaHareketi.lAlacakTutar) AS Onceki 
        FROM tbFirma, tbFirmaHareketi 
        WHERE tbFirma.nFirmaID = tbFirmaHareketi.nFirmaID AND tbFirmaHareketi.dteIslemTarihi < '" & tarih1 & "' 
        GROUP BY substring(tbFirma.sKodu, 1, 2) 
        UNION 
        SELECT substring(tbFirma.sKodu, 1, 3) AS HesapKodu, SUM(tbFirmaHareketi.lBorcTutar - tbFirmaHareketi.lAlacakTutar) AS Onceki 
        FROM tbFirma, tbFirmaHareketi 
        WHERE tbFirma.nFirmaID = tbFirmaHareketi.nFirmaID AND tbFirmaHareketi.dteIslemTarihi < '" & tarih1 & "' 
        GROUP BY substring(tbFirma.sKodu, 1, 3) 
        UNION 
        SELECT substring(tbFirma.sKodu, 1, 6) AS HesapKodu, SUM(tbFirmaHareketi.lBorcTutar - tbFirmaHareketi.lAlacakTutar) AS Onceki 
        FROM tbFirma, tbFirmaHareketi 
        WHERE tbFirma.nFirmaID = tbFirmaHareketi.nFirmaID AND tbFirmaHareketi.dteIslemTarihi < '" & tarih1 & "' 
        GROUP BY substring(tbFirma.sKodu, 1, 6) 
        UNION 
        SELECT substring(tbFirma.sKodu, 1, 1) AS HesapKodu, SUM(tbFirmaHareketi.lBorcTutar - tbFirmaHareketi.lAlacakTutar) AS Onceki 
        FROM tbFirma, tbFirmaHareketi 
        WHERE tbFirma.nFirmaID = tbFirmaHareketi.nFirmaID AND tbFirmaHareketi.dteIslemTarihi < '" & tarih1 & "' 
        GROUP BY substring(tbFirma.sKodu, 1, 1)
    ) AS tempBilancoOncekiGroup 
    GROUP BY HesapKodu
) tempBilancoOnceki ON tempBilancoOnceki.HesapKodu = tbBilancoGelirTablosuHesaplari.sHesap3 
WHERE tbBilancoGelirTablosuHesaplari.nDurum IN (0,1,2,3,4) " & kriter & " ORDER BY tbBilancoGelirTablosuHesaplari.sHesapSirasi")
        ElseIf sec_detay.Text = "Detayli" Then
            cmd.CommandText = sorgu_query(" SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED;
WITH leaf_simdiki AS (
SELECT
tbFirma.sKodu AS HesapKodu,
SUM(CASE WHEN tbFirmaHareketi.dteIslemTarihi BETWEEN '" & tarih1 & "' AND '" & tarih2 & "' THEN tbFirmaHareketi.lBorcTutar ELSE 0 END) AS lBorcTutar,
SUM(CASE WHEN tbFirmaHareketi.dteIslemTarihi BETWEEN '" & tarih1 & "' AND '" & tarih2 & "' THEN tbFirmaHareketi.lAlacakTutar ELSE 0 END) AS lAlacakTutar,
SUM(CASE WHEN tbFirmaHareketi.dteIslemTarihi BETWEEN '" & tarih1 & "' AND '" & tarih2 & "' THEN tbFirmaHareketi.lBorcTutar - tbFirmaHareketi.lAlacakTutar ELSE 0 END) AS Simdiki
FROM tbFirma INNER JOIN tbFirmaHareketi ON tbFirma.nFirmaID = tbFirmaHareketi.nFirmaID
WHERE tbFirmaHareketi.dteIslemTarihi BETWEEN '" & tarih1 & "' AND '" & tarih2 & "'
GROUP BY tbFirma.sKodu
),
leaf_bakiye AS (
SELECT
HesapKodu,
lBorcTutar,
lAlacakTutar,
Simdiki,
CASE WHEN Simdiki > 0 THEN ABS(Simdiki) ELSE 0 END AS lAlacakBakiye,
CASE WHEN Simdiki < 0 THEN ABS(Simdiki) ELSE 0 END AS lBorcBakiye
FROM leaf_simdiki
),
leaf_onceki AS (
SELECT
tbFirma.sKodu AS HesapKodu,
SUM(tbFirmaHareketi.lBorcTutar - tbFirmaHareketi.lAlacakTutar) AS Onceki
FROM tbFirma INNER JOIN tbFirmaHareketi ON tbFirma.nFirmaID = tbFirmaHareketi.nFirmaID
WHERE tbFirmaHareketi.dteIslemTarihi < '" & tarih1 & "'
GROUP BY tbFirma.sKodu
)
SELECT * FROM (
SELECT
tbBilancoGelirTablosuHesaplari.sHesap2,
tbBilancoGelirTablosuHesaplari.sHesap3,
tbBilancoGelirTablosuHesaplari.sAciklamaTR,
tbBilancoGelirTablosuHesaplari.sAciklamaEN,
tbBilancoGelirTablosuHesaplari.sAciklamaAR,
ISNULL(tempBilancoOnceki.Onceki, 0) AS Onceki,
ISNULL(tempBilancoSimdiki.lBorcTutar, 0) AS lBorcTutar,
ISNULL(tempBilancoSimdiki.lAlacakTutar, 0) AS lAlacakTutar,
ISNULL(tempBilancoSimdiki.lAlacakBakiye, 0) AS lAlacakBakiye,
ISNULL(tempBilancoSimdiki.lBorcBakiye, 0) AS lBorcBakiye,
ISNULL(tempBilancoSimdiki.Simdiki, 0) AS Simdiki,
tbBilancoGelirTablosuHesaplari.bFormulMu,
tbBilancoGelirTablosuHesaplari.sHesapSirasi,
tbBilancoGelirTablosuHesaplari.nDurum
FROM
tbBilancoGelirTablosuHesaplari
LEFT OUTER JOIN (
SELECT
HesapKodu,
SUM(lBorcTutar) AS lBorcTutar,
SUM(lAlacakTutar) AS lAlacakTutar,
SUM(Simdiki) AS Simdiki,
SUM(lAlacakBakiye) AS lAlacakBakiye,
SUM(lBorcBakiye) AS lBorcBakiye
FROM (
SELECT SUBSTRING(HesapKodu, 1, 1) AS HesapKodu, lBorcTutar, lAlacakTutar, Simdiki, lAlacakBakiye, lBorcBakiye FROM leaf_bakiye
UNION ALL
SELECT SUBSTRING(HesapKodu, 1, 2) AS HesapKodu, lBorcTutar, lAlacakTutar, Simdiki, lAlacakBakiye, lBorcBakiye FROM leaf_bakiye
UNION ALL
SELECT SUBSTRING(HesapKodu, 1, 3) AS HesapKodu, lBorcTutar, lAlacakTutar, Simdiki, lAlacakBakiye, lBorcBakiye FROM leaf_bakiye
UNION ALL
SELECT SUBSTRING(HesapKodu, 1, 6) AS HesapKodu, lBorcTutar, lAlacakTutar, Simdiki, lAlacakBakiye, lBorcBakiye FROM leaf_bakiye
UNION ALL
SELECT SUBSTRING(HesapKodu, 1, 9) AS HesapKodu, lBorcTutar, lAlacakTutar, Simdiki, lAlacakBakiye, lBorcBakiye FROM leaf_bakiye
) AS tempBilancoSimdikiGroup
GROUP BY HesapKodu
) tempBilancoSimdiki ON tempBilancoSimdiki.HesapKodu = tbBilancoGelirTablosuHesaplari.sHesap3
LEFT OUTER JOIN (
SELECT
HesapKodu,
SUM(Onceki) AS Onceki
FROM (
SELECT SUBSTRING(HesapKodu, 1, 1) AS HesapKodu, Onceki FROM leaf_onceki
UNION ALL
SELECT SUBSTRING(HesapKodu, 1, 2) AS HesapKodu, Onceki FROM leaf_onceki
UNION ALL
SELECT SUBSTRING(HesapKodu, 1, 3) AS HesapKodu, Onceki FROM leaf_onceki
UNION ALL
SELECT SUBSTRING(HesapKodu, 1, 6) AS HesapKodu, Onceki FROM leaf_onceki
UNION ALL
SELECT SUBSTRING(HesapKodu, 1, 9) AS HesapKodu, Onceki FROM leaf_onceki
) AS tempBilancoOncekiGroup
GROUP BY HesapKodu
) tempBilancoOnceki ON tempBilancoOnceki.HesapKodu = tbBilancoGelirTablosuHesaplari.sHesap3
WHERE tbBilancoGelirTablosuHesaplari.nDurum IN (0,1,2,3,4)

UNION ALL

SELECT
SUBSTRING(tbFirma.sKodu, 1, 2) AS sHesap2,
SUBSTRING(tbFirma.sKodu, 1, 20) AS sHesap3,
tbFirma.sAciklama AS sAciklamaTR,
'' AS sAciklamaEN,
tbFirma.sOzelNot AS sAciklamaAR,
ISNULL(SUM(CASE WHEN tbFirmaHareketi.dteIslemTarihi < '" & tarih1 & "' THEN tbFirmaHareketi.lBorcTutar - tbFirmaHareketi.lAlacakTutar ELSE 0 END), 0) AS Onceki,
SUM(CASE WHEN tbFirmaHareketi.dteIslemTarihi BETWEEN '" & tarih1 & "' AND '" & tarih2 & "' THEN tbFirmaHareketi.lBorcTutar ELSE 0 END) AS lBorcTutar,
SUM(CASE WHEN tbFirmaHareketi.dteIslemTarihi BETWEEN '" & tarih1 & "' AND '" & tarih2 & "' THEN tbFirmaHareketi.lAlacakTutar ELSE 0 END) AS lAlacakTutar,
CASE WHEN ISNULL(SUM(CASE WHEN tbFirmaHareketi.dteIslemTarihi BETWEEN '" & tarih1 & "' AND '" & tarih2 & "' THEN tbFirmaHareketi.lBorcTutar - tbFirmaHareketi.lAlacakTutar ELSE 0 END), 0) > 0 THEN ABS(SUM(CASE WHEN tbFirmaHareketi.dteIslemTarihi BETWEEN '" & tarih1 & "' AND '" & tarih2 & "' THEN tbFirmaHareketi.lBorcTutar - tbFirmaHareketi.lAlacakTutar ELSE 0 END)) ELSE 0 END AS lBorcBakiye,
CASE WHEN ISNULL(SUM(CASE WHEN tbFirmaHareketi.dteIslemTarihi BETWEEN '" & tarih1 & "' AND '" & tarih2 & "' THEN tbFirmaHareketi.lBorcTutar - tbFirmaHareketi.lAlacakTutar ELSE 0 END), 0) < 0 THEN ABS(SUM(CASE WHEN tbFirmaHareketi.dteIslemTarihi BETWEEN '" & tarih1 & "' AND '" & tarih2 & "' THEN tbFirmaHareketi.lBorcTutar - tbFirmaHareketi.lAlacakTutar ELSE 0 END)) ELSE 0 END AS lAlacakBakiye,
ISNULL(SUM(CASE WHEN tbFirmaHareketi.dteIslemTarihi BETWEEN '" & tarih1 & "' AND '" & tarih2 & "' THEN tbFirmaHareketi.lBorcTutar - tbFirmaHareketi.lAlacakTutar ELSE 0 END), 0) AS Simdiki,
0 AS bFormulMu,
tbFirma.sKodu AS sHesapSirasi,
3 AS nDurum
FROM
tbFirma
INNER JOIN
tbFirmaHareketi ON tbFirma.nFirmaID = tbFirmaHareketi.nFirmaID
WHERE
SUBSTRING(tbFirma.sKodu, 1, 1) < '9'
AND tbFirmaHareketi.dteIslemTarihi <= '" & tarih2 & "'
AND tbFirma.sKodu <> ''
GROUP BY
tbFirma.sKodu, tbFirma.sAciklama, tbFirma.sOzelNot
) TempBilanco ORDER BY sHesapSirasi")
            'cmd.CommandText = sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED;
            'WITH leaf_simdiki AS (
            '    SELECT 
            '        tbFirma.sKodu AS HesapKodu,
            '        SUM(CASE WHEN tbFirmaHareketi.dteIslemTarihi BETWEEN '" & tarih1 & "' AND '" & tarih2 & "' THEN tbFirmaHareketi.lBorcTutar ELSE 0 END) AS lBorcTutar,
            '        SUM(CASE WHEN tbFirmaHareketi.dteIslemTarihi BETWEEN '" & tarih1 & "' AND '" & tarih2 & "' THEN tbFirmaHareketi.lAlacakTutar ELSE 0 END) AS lAlacakTutar,
            '        SUM(CASE WHEN tbFirmaHareketi.dteIslemTarihi BETWEEN '" & tarih1 & "' AND '" & tarih2 & "' THEN tbFirmaHareketi.lBorcTutar - tbFirmaHareketi.lAlacakTutar ELSE 0 END) AS Simdiki
            '    FROM tbFirma INNER JOIN tbFirmaHareketi ON tbFirma.nFirmaID = tbFirmaHareketi.nFirmaID 
            '    WHERE tbFirmaHareketi.dteIslemTarihi BETWEEN '" & tarih1 & "' AND '" & tarih2 & "'
            '    GROUP BY tbFirma.sKodu
            '),
            'leaf_bakiye AS (
            '    SELECT 
            '        HesapKodu,
            '        lBorcTutar,
            '        lAlacakTutar,
            '        Simdiki,
            '        CASE WHEN Simdiki > 0 THEN ABS(Simdiki) ELSE 0 END AS lAlacakBakiye,
            '        CASE WHEN Simdiki < 0 THEN ABS(Simdiki) ELSE 0 END AS lBorcBakiye
            '    FROM leaf_simdiki
            ')
            'SELECT * FROM (
            '    SELECT 
            '        tbBilancoGelirTablosuHesaplari.sHesap2, 
            '        tbBilancoGelirTablosuHesaplari.sHesap3, 
            '        tbBilancoGelirTablosuHesaplari.sAciklamaTR, 
            '        tbBilancoGelirTablosuHesaplari.sAciklamaEN, 
            '        tbBilancoGelirTablosuHesaplari.sAciklamaAR, 
            '        ISNULL(tempBilancoOnceki.Onceki, 0) AS Onceki, 
            '        ISNULL(tempBilancoSimdiki.lBorcTutar, 0) AS lBorcTutar, 
            '        ISNULL(tempBilancoSimdiki.lAlacakTutar, 0) AS lAlacakTutar, 
            '        ISNULL(tempBilancoSimdiki.lAlacakBakiye, 0) AS lAlacakBakiye, 
            '        ISNULL(tempBilancoSimdiki.lBorcBakiye, 0) AS lBorcBakiye, 
            '        ISNULL(tempBilancoSimdiki.Simdiki, 0) AS Simdiki, 
            '        tbBilancoGelirTablosuHesaplari.bFormulMu, 
            '        tbBilancoGelirTablosuHesaplari.sHesapSirasi, 
            '        tbBilancoGelirTablosuHesaplari.nDurum 
            '    FROM 
            '        tbBilancoGelirTablosuHesaplari 
            '    LEFT OUTER JOIN (
            '        SELECT 
            '            HesapKodu, 
            '            SUM(lBorcTutar) AS lBorcTutar, 
            '            SUM(lAlacakTutar) AS lAlacakTutar, 
            '            SUM(Simdiki) AS Simdiki, 
            '            SUM(lAlacakBakiye) AS lAlacakBakiye, 
            '            SUM(lBorcBakiye) AS lBorcBakiye 
            '        FROM (
            '            SELECT SUBSTRING(HesapKodu, 1, 1) AS HesapKodu, lBorcTutar, lAlacakTutar, Simdiki, lAlacakBakiye, lBorcBakiye FROM leaf_bakiye 
            '            UNION ALL 
            '            SELECT SUBSTRING(HesapKodu, 1, 2) AS HesapKodu, lBorcTutar, lAlacakTutar, Simdiki, lAlacakBakiye, lBorcBakiye FROM leaf_bakiye 
            '            UNION ALL 
            '            SELECT SUBSTRING(HesapKodu, 1, 3) AS HesapKodu, lBorcTutar, lAlacakTutar, Simdiki, lAlacakBakiye, lBorcBakiye FROM leaf_bakiye 
            '            UNION ALL 
            '            SELECT SUBSTRING(HesapKodu, 1, 6) AS HesapKodu, lBorcTutar, lAlacakTutar, Simdiki, lAlacakBakiye, lBorcBakiye FROM leaf_bakiye 
            '            UNION ALL 
            '            SELECT SUBSTRING(HesapKodu, 1, 9) AS HesapKodu, lBorcTutar, lAlacakTutar, Simdiki, lAlacakBakiye, lBorcBakiye FROM leaf_bakiye 
            '        ) AS tempBilancoSimdikiGroup 
            '        GROUP BY HesapKodu
            '    ) tempBilancoSimdiki ON tempBilancoSimdiki.HesapKodu = tbBilancoGelirTablosuHesaplari.sHesap3 
            '    LEFT OUTER JOIN (
            '        SELECT 
            '            HesapKodu, 
            '            SUM(Onceki) AS Onceki 
            '        FROM (
            '            SELECT substring(tbFirma.sKodu, 1, 1) AS HesapKodu, SUM(tbFirmaHareketi.lBorcTutar - tbFirmaHareketi.lAlacakTutar) AS Onceki 
            '            FROM tbFirma, tbFirmaHareketi 
            '            WHERE tbFirma.nFirmaID = tbFirmaHareketi.nFirmaID AND tbFirmaHareketi.dteIslemTarihi < '" & tarih1 & "'
            '            GROUP BY substring(tbFirma.sKodu, 1, 1) 
            '            UNION ALL 
            '            SELECT substring(tbFirma.sKodu, 1, 2) AS HesapKodu, SUM(tbFirmaHareketi.lBorcTutar - tbFirmaHareketi.lAlacakTutar) AS Onceki 
            '            FROM tbFirma, tbFirmaHareketi 
            '            WHERE tbFirma.nFirmaID = tbFirmaHareketi.nFirmaID AND tbFirmaHareketi.dteIslemTarihi < '" & tarih1 & "'
            '            GROUP BY substring(tbFirma.sKodu, 1, 2) 
            '            UNION ALL 
            '            SELECT substring(tbFirma.sKodu, 1, 3) AS HesapKodu, SUM(tbFirmaHareketi.lBorcTutar - tbFirmaHareketi.lAlacakTutar) AS Onceki 
            '            FROM tbFirma, tbFirmaHareketi 
            '            WHERE tbFirma.nFirmaID = tbFirmaHareketi.nFirmaID AND tbFirmaHareketi.dteIslemTarihi < '" & tarih1 & "'
            '            GROUP BY substring(tbFirma.sKodu, 1, 3) 
            '            UNION ALL 
            '            SELECT substring(tbFirma.sKodu, 1, 6) AS HesapKodu, SUM(tbFirmaHareketi.lBorcTutar - tbFirmaHareketi.lAlacakTutar) AS Onceki 
            '            FROM tbFirma, tbFirmaHareketi 
            '            WHERE tbFirma.nFirmaID = tbFirmaHareketi.nFirmaID AND tbFirmaHareketi.dteIslemTarihi < '" & tarih1 & "'
            '            GROUP BY substring(tbFirma.sKodu, 1, 6) 
            '            UNION ALL 
            '            SELECT substring(tbFirma.sKodu, 1, 9) AS HesapKodu, SUM(tbFirmaHareketi.lBorcTutar - tbFirmaHareketi.lAlacakTutar) AS Onceki 
            '            FROM tbFirma, tbFirmaHareketi 
            '            WHERE tbFirma.nFirmaID = tbFirmaHareketi.nFirmaID AND tbFirmaHareketi.dteIslemTarihi < '" & tarih1 & "'
            '            GROUP BY substring(tbFirma.sKodu, 1, 9) 
            '        ) AS tempBilancoOncekiGroup 
            '        GROUP BY HesapKodu
            '    ) tempBilancoOnceki ON tempBilancoOnceki.HesapKodu = tbBilancoGelirTablosuHesaplari.sHesap3 
            '    WHERE tbBilancoGelirTablosuHesaplari.nDurum IN (0,1,2,3,4)

            '    UNION ALL 

            '    SELECT 
            '        SUBSTRING(tbFirma.sKodu, 1, 2) AS sHesap2, 
            '        SUBSTRING(tbFirma.sKodu, 1, 20) AS sHesap3, 
            '        tbFirma.sAciklama AS sAciklamaTR, 
            '        '' AS sAciklamaEN, 
            '        tbFirma.sOzelNot AS sAciklamaAR, 
            '        ISNULL(SUM(CASE WHEN tbFirmaHareketi.dteIslemTarihi < '" & tarih1 & "' THEN tbFirmaHareketi.lBorcTutar - tbFirmaHareketi.lAlacakTutar ELSE 0 END), 0) AS Onceki, 
            '        SUM(CASE WHEN tbFirmaHareketi.dteIslemTarihi BETWEEN '" & tarih1 & "' AND '" & tarih2 & "' THEN tbFirmaHareketi.lBorcTutar ELSE 0 END) AS lBorcTutar, 
            '        SUM(CASE WHEN tbFirmaHareketi.dteIslemTarihi BETWEEN '" & tarih1 & "' AND '" & tarih2 & "' THEN tbFirmaHareketi.lAlacakTutar ELSE 0 END) AS lAlacakTutar, 
            '        CASE WHEN ISNULL(SUM(CASE WHEN tbFirmaHareketi.dteIslemTarihi BETWEEN '" & tarih1 & "' AND '" & tarih2 & "' THEN tbFirmaHareketi.lBorcTutar - tbFirmaHareketi.lAlacakTutar ELSE 0 END), 0) > 0 THEN ABS(SUM(CASE WHEN tbFirmaHareketi.dteIslemTarihi BETWEEN '" & tarih1 & "' AND '" & tarih2 & "' THEN tbFirmaHareketi.lBorcTutar - tbFirmaHareketi.lAlacakTutar ELSE 0 END)) ELSE 0 END AS lAlacakBakiye, 
            '        CASE WHEN ISNULL(SUM(CASE WHEN tbFirmaHareketi.dteIslemTarihi BETWEEN '" & tarih1 & "' AND '" & tarih2 & "' THEN tbFirmaHareketi.lBorcTutar - tbFirmaHareketi.lAlacakTutar ELSE 0 END), 0) < 0 THEN ABS(SUM(CASE WHEN tbFirmaHareketi.dteIslemTarihi BETWEEN '" & tarih1 & "' AND '" & tarih2 & "' THEN tbFirmaHareketi.lBorcTutar - tbFirmaHareketi.lAlacakTutar ELSE 0 END)) ELSE 0 END AS lBorcBakiye, 
            '        ISNULL(SUM(CASE WHEN tbFirmaHareketi.dteIslemTarihi BETWEEN '" & tarih1 & "' AND '" & tarih2 & "' THEN tbFirmaHareketi.lBorcTutar - tbFirmaHareketi.lAlacakTutar ELSE 0 END), 0) AS Simdiki, 
            '        0 AS bFormulMu, 
            '        tbFirma.sKodu AS sHesapSirasi, 
            '        3 AS nDurum 
            '    FROM 
            '        tbFirma 
            '    INNER JOIN 
            '        tbFirmaHareketi ON tbFirma.nFirmaID = tbFirmaHareketi.nFirmaID 
            '    WHERE 
            '        SUBSTRING(tbFirma.sKodu, 1, 1) < '9' 
            '        AND tbFirmaHareketi.dteIslemTarihi BETWEEN '" & tarih1 & "' AND '" & tarih2 & "'
            '        AND tbFirma.sKodu <> '' 
            '    GROUP BY 
            '        tbFirma.sKodu, tbFirma.sAciklama, tbFirma.sOzelNot
            ') TempBilanco  ORDER BY sHesapSirasi")

        End If
        cmd.Connection = conn
        conn.Open()
        Dim N As Integer = adapter.Fill(ds_tbAktif, "Table1")
        conn.Close()
        Dim dr As DataRow
        Dim s0 As String = ""
        Dim s1 As String = ""
        Dim s2 As Integer = 0
        Dim s4 As String = ""
        Dim lBorc As Decimal = 0
        Dim lAlacak As Decimal = 0
        Dim lBorcBakiye As Decimal = 0
        Dim lAlacakBakiye As Decimal = 0
        Dim lBakiye As Decimal = 0
        Dim sKod As String = ""
        Dim sAciklama As String = ""
        Dim sAciklamaTR As String = ""

        'sKod = "100"
        'sAciklama = Sorgu_sDil("Kasa", sDil)
        'sAciklamaTR = "Kasa"
        'ds_tbKasa = sorgu(sorgu_query("SET dateformat dmy SELECT '" & sKod & "' AS sHesap,'" & sKod & "' AS sKodu, N'" & sAciklamaTR & "'  sAciklamaTR,N'" & sAciklama & "'  sAciklama, ISNULL (SUM(tbNakitKasa.lTahsilTutar),0) AS lBorcTutar, ISNULL (SUM(tbNakitKasa.lTediyeTutar),0) AS lAlacakTutar, SUM(ISNULL(tbNakitKasa.lTahsilTutar, 0) - ISNULL(tbNakitKasa.lTediyeTutar, 0)) AS lBakiye, ISNULL(SUM(tbNakitKasa.lTahsilTutar - tbNakitKasa.lTediyeTutar),0) AS lTutar, 1 AS nDurum FROM tbNakitKasa INNER JOIN tbSubeMagaza ON tbNakitKasa.sSube = tbSubeMagaza.sSubeMagaza WHERE tbNakitKasa.dteIslemTarihi BETWEEN '" & tarih1 & "' AND '" & tarih2 & "' "))
        'sKod = "100.01"
        'sAciklama = Sorgu_sDil("Mağaza Kasa", sDil)
        'sAciklamaTR = "Mağaza Kasa"
        'ds_tbKasa = sorgu(sorgu_query("SET dateformat dmy SELECT '" & sKod & "' AS sHesap,'" & sKod & "' AS sKodu, N'" & sAciklamaTR & "'  sAciklamaTR,N'" & sAciklama & "'  sAciklama, ISNULL (SUM(tbNakitKasa.lTahsilTutar),0) AS lBorcTutar, ISNULL (SUM(tbNakitKasa.lTediyeTutar),0) AS lAlacakTutar, SUM(ISNULL(tbNakitKasa.lTahsilTutar, 0) - ISNULL(tbNakitKasa.lTediyeTutar, 0)) AS lBakiye, ISNULL (SUM(tbNakitKasa.lTahsilTutar - tbNakitKasa.lTediyeTutar),0) AS lTutar, 1 AS nDurum FROM tbNakitKasa INNER JOIN tbSubeMagaza ON tbNakitKasa.sSube = tbSubeMagaza.sSubeMagaza WHERE tbNakitKasa.dteIslemTarihi BETWEEN '" & tarih1 & "' AND '" & tarih2 & "' And sSube = '001'"))
        'sKod = "100.02"
        'sAciklama = Sorgu_sDil("İnşaat Kasa", sDil)
        'sAciklamaTR = "İnşaat Kasa"
        'ds_tbKasa = sorgu(sorgu_query("SET dateformat dmy SELECT '" & sKod & "' AS sHesap,'" & sKod & "' AS sKodu, N'" & sAciklamaTR & "'  sAciklamaTR,N'" & sAciklama & "'  sAciklama, SUM(tbNakitKasa.lTahsilTutar) AS lBorcTutar, SUM(tbNakitKasa.lTediyeTutar) AS lAlacakTutar, SUM(ISNULL(tbNakitKasa.lTahsilTutar, 0) - ISNULL(tbNakitKasa.lTediyeTutar, 0)) AS lBakiye, SUM(tbNakitKasa.lTahsilTutar - tbNakitKasa.lTediyeTutar) AS lTutar, 1 AS nDurum FROM tbNakitKasa INNER JOIN tbSubeMagaza ON tbNakitKasa.sSube = tbSubeMagaza.sSubeMagaza WHERE tbNakitKasa.dteIslemTarihi BETWEEN '" & tarih1 & "' AND '" & tarih2 & "' And sSube = '002'"))

        Dim sqlKasa As String = "
SET DATEFORMAT dmy

SELECT '100' AS sHesap, '100' AS sKodu, N'Kasa' AS sAciklamaTR, N'Kasa' AS sAciklama,
ISNULL(SUM(lTahsilTutar), 0) AS lBorcTutar,
ISNULL(SUM(lTediyeTutar), 0) AS lAlacakTutar,
ISNULL(SUM(lTahsilTutar - lTediyeTutar), 0) AS lBakiye,
ISNULL(SUM(lTahsilTutar - lTediyeTutar), 0) AS lTutar,
1 AS nDurum
FROM tbNakitKasa
WHERE dteIslemTarihi BETWEEN '" & tarih1 & "' AND '" & tarih2 & "' AND RTRIM(sSube) = '001'

UNION ALL

SELECT '100.01' AS sHesap, '100.01' AS sKodu, N'Mağaza Kasa' AS sAciklamaTR, N'Mağaza Kasa' AS sAciklama,
ISNULL(SUM(lTahsilTutar), 0),
ISNULL(SUM(lTediyeTutar), 0),
ISNULL(SUM(lTahsilTutar - lTediyeTutar), 0),
ISNULL(SUM(lTahsilTutar - lTediyeTutar), 0),
1
FROM tbNakitKasa
WHERE dteIslemTarihi BETWEEN '" & tarih1 & "' AND '" & tarih2 & "' AND RTRIM(sSube) = '002'

UNION ALL

SELECT '100.02' AS sHesap, '100.02' AS sKodu, N'İnşaat Kasa' AS sAciklamaTR, N'İnşaat Kasa' AS sAciklama,
ISNULL(SUM(lTahsilTutar), 0),
ISNULL(SUM(lTediyeTutar), 0),
ISNULL(SUM(lTahsilTutar - lTediyeTutar), 0),
ISNULL(SUM(lTahsilTutar - lTediyeTutar), 0),
1
FROM tbNakitKasa
WHERE dteIslemTarihi BETWEEN '" & tarih1 & "' AND '" & tarih2 & "' AND RTRIM(sSube) = '003'
"


        Dim ds_tbKasa As DataSet = sorgu(sorgu_query(sqlKasa))

        For Each drAktif As DataRow In ds_tbAktif.Tables(0).Rows
            Dim sKodu As String = drAktif("sHesap3").ToString

            For Each drKasa As DataRow In ds_tbKasa.Tables(0).Rows
                If drKasa("sHesap").ToString = sKodu Then
                    drAktif("lBorcTutar") = sorgu_sayi(drKasa("lBorcTutar"), 0)
                    drAktif("lAlacakTutar") = sorgu_sayi(drKasa("lAlacakTutar"), 0)

                    If sorgu_sayi(drKasa("lBakiye"), 0) >= 0 Then
                        drAktif("lBorcBakiye") = Math.Abs(sorgu_sayi(drKasa("lBakiye"), 0))
                        drAktif("lAlacakBakiye") = 0
                    Else
                        drAktif("lAlacakBakiye") = Math.Abs(sorgu_sayi(drKasa("lBakiye"), 0))
                        drAktif("lBorcBakiye") = 0
                    End If
                End If
            Next
        Next


        lBorc = 0
        lAlacak = 0
        lBorcBakiye = 0
        lAlacakBakiye = 0


        sKod = "101"
        sAciklama = Sorgu_sDil("Alınan Çekler", sDil)
        sAciklamaTR = "Alınan Çekler"
        ds_tbCekAlinan = sorgu(sorgu_query("SELECT '" & sKod & "' sHesap, '" & sKod & "' as sKodu, N'" & sAciklamaTR & "'  sAciklamaTR,N'" & sAciklama & "'  sAciklama, 0 AS lBorcTutar, ISNULL (SUM(tbCekSenet.lTutar),0) AS lAlacakTutar, 0 AS lBakiye, ISNULL(SUM(tbCekSenet.lTutar),0) AS lTutar,1 AS nDurum FROM tbFirma VEREN INNER JOIN tbCekSenet ON VEREN.nFirmaID = tbCekSenet.nVerenID INNER JOIN tbBanka ON tbCekSenet.sBankaKodu = tbBanka.sBankaKodu INNER JOIN tbHareketTipi ON tbCekSenet.sHareketTipi = tbHareketTipi.sHareketTipi INNER JOIN tbFirma tbFirma_1 INNER JOIN tbCekSenetBordro ON tbFirma_1.nFirmaID = tbCekSenetBordro.nFirmaID ON tbCekSenet.nSonBordroSatirID = tbCekSenetBordro.nBordroSatirID INNER JOIN tbCekSenetIslem ON tbCekSenet.nSonCekSenetIslem = tbCekSenetIslem.nCekSenetIslem WHERE (tbCekSenet.sCekSenetTipi = 'AC') AND (tbCekSenet.dteVadeTarihi BETWEEN '" & tarih1 & "' AND '" & tarih2 & "') AND (tbCekSenet.lCekSenetNo BETWEEN '0' AND '999999999') AND (tbCekSenet.sOrjinalCekSenetNo BETWEEN '' AND 'zzzzzzzzz') AND (tbCekSenetBordro.nCekSenetIslem IN (1,6)) "))
        sKod = "103"
        sAciklama = Sorgu_sDil("Verilen Çekler", sDil)
        sAciklamaTR = "Verilen Çekler"
        ds_tbCekVerilen = sorgu(sorgu_query("SELECT '" & sKod & "' sHesap, '" & sKod & "' as sKodu, N'" & sAciklamaTR & "'  sAciklamaTR,N'" & sAciklama & "'  sAciklama, 0 AS lBorcTutar,ISNULL (SUM(tbCekSenet.lTutar),0) AS lAlacakTutar, 0 AS lBakiye, ISNULL (SUM(tbCekSenet.lTutar),0) AS lTutar,1 AS nDurum FROM tbFirma VEREN INNER JOIN tbCekSenet ON VEREN.nFirmaID = tbCekSenet.nVerenID INNER JOIN tbBanka ON tbCekSenet.sBankaKodu = tbBanka.sBankaKodu INNER JOIN tbHareketTipi ON tbCekSenet.sHareketTipi = tbHareketTipi.sHareketTipi INNER JOIN tbFirma tbFirma_1 INNER JOIN tbCekSenetBordro ON tbFirma_1.nFirmaID = tbCekSenetBordro.nFirmaID ON tbCekSenet.nSonBordroSatirID = tbCekSenetBordro.nBordroSatirID INNER JOIN tbCekSenetIslem ON tbCekSenet.nSonCekSenetIslem = tbCekSenetIslem.nCekSenetIslem WHERE (tbCekSenet.sCekSenetTipi = 'BC') AND (tbCekSenet.dteVadeTarihi BETWEEN '" & tarih1 & "' AND '" & tarih2 & "') AND (tbCekSenet.lCekSenetNo BETWEEN '0' AND '999999999') AND (tbCekSenet.sOrjinalCekSenetNo BETWEEN '' AND 'zzzzzzzzz') AND (tbCekSenetBordro.nCekSenetIslem IN (20)) UNION ALL SELECT '" & sKod & "' sHesap, VEREN.sKodu, VEREN.sAciklama as sAciklamaTR, VEREN.sOzelNOT sAciklama, 0 AS lBorcTutar, SUM(tbCekSenet.lTutar) AS lAlacakTutar, SUM(tbCekSenet.lTutar) AS lBakiye, 0 as lTutar,2 AS nDurum FROM tbFirma VEREN INNER JOIN tbCekSenet ON VEREN.nFirmaID = tbCekSenet.nVerenID INNER JOIN tbBanka ON tbCekSenet.sBankaKodu = tbBanka.sBankaKodu INNER JOIN tbHareketTipi ON tbCekSenet.sHareketTipi = tbHareketTipi.sHareketTipi INNER JOIN tbFirma tbFirma_1 INNER JOIN tbCekSenetBordro ON tbFirma_1.nFirmaID = tbCekSenetBordro.nFirmaID ON tbCekSenet.nSonBordroSatirID = tbCekSenetBordro.nBordroSatirID INNER JOIN tbCekSenetIslem ON tbCekSenet.nSonCekSenetIslem = tbCekSenetIslem.nCekSenetIslem WHERE (tbCekSenet.sCekSenetTipi = 'BC') AND (tbCekSenet.dteVadeTarihi BETWEEN '" & tarih1 & "' AND '" & tarih2 & "') AND (tbCekSenet.lCekSenetNo BETWEEN '0' AND '999999999') AND (tbCekSenet.sOrjinalCekSenetNo BETWEEN '' AND 'zzzzzzzzz') AND (tbCekSenetBordro.nCekSenetIslem IN (20)) GROUP BY VEREN.sKodu, VEREN.sAciklama,VEREN.sOzelNot"))
        'sKod = "153"
        'sAciklama = Sorgu_sDil("Mağaza Ticari Mallar", sDil)
        'sAciklamaTR = "Ticari Mallar"
        'ds_tbTicariMallar = sorgu(sorgu_query("SELECT '" & sKod & "' AS sHesap, '" & sKod & "' AS sKodu, N'" & sAciklamaTR & "'  sAciklamaTR,N'" & sAciklama & "'  sAciklama, ISNULL (SUM(lMevcut),0) AS lBorcTutar, ISNULL(SUM(lMevcut * Maliyet),0) AS lAlacakTutar, 0 as lBakiye,ISNULL (SUM(lMevcut * Maliyet),0) AS lTutar,1 as nDurum FROM (SELECT tbStok.*, tbStokBarkodu.sBarkod AS sBarkod, tbSSinif1.sAciklama AS Sinif1, ((SELECT isnull(lfiyat, 0) FROM tbstokfiyati WHERE nStokId = tbStok.NstokId AND sFiyatTipi = '" & sFiyatM & "')) AS Maliyet, TempMevcut.lMevcut AS lMevcut FROM tbStok INNER JOIN tbStokBarkodu ON tbStok.nStokID = tbStokBarkodu.nStokID AND tbStokBarkodu.nKisim = 0 INNER JOIN tbStokSinifi ON tbStok.nStokID = tbStokSinifi.nStokID INNER JOIN tbSSinif1 ON tbStokSinifi.sSinifKodu1 = tbSSinif1.sSinifKodu LEFT OUTER JOIN (SELECT nStokID, isnull(SUM(tbStokFisiDetayi.lGirisMiktar1 - tbStokFisiDetayi.lCikisMiktar1), 0) AS lMevcut FROM tbStokFisiDetayi WHERE tbStokFisiDetayi.dteIslemTarihi <= '" & tarih2 & "'  GROUP BY nStokID) TempMevcut ON tbStok.nStokID = TempMevcut.nStokID WHERE tbStok.sKodu <> '' AND tbStokSinifi.sSinifKodu1 = '01' AND tbStok.nStokTipi < 5  AND (TempMevcut.lMevcut > 0)) tbStoklar "))
        'sKod = "150"
        'sAciklama = Sorgu_sDil("İnşaat Ticari Mallar", sDil)
        'sAciklamaTR = "Ticari Mallar"
        'ds_tbTicariMallar = sorgu(sorgu_query("SELECT '" & sKod & "' AS sHesap, '" & sKod & "' AS sKodu, N'" & sAciklamaTR & "'  sAciklamaTR,N'" & sAciklama & "'  sAciklama, ISNULL (SUM(lMevcut),0) AS lBorcTutar, ISNULL (SUM(lMevcut * Maliyet),0) AS lAlacakTutar, 0 as lBakiye,ISNULL (SUM(lMevcut * Maliyet),0) AS lTutar,1 as nDurum FROM (SELECT tbStok.*, tbStokBarkodu.sBarkod AS sBarkod, tbSSinif1.sAciklama AS Sinif1, ((SELECT isnull(lfiyat, 0) FROM tbstokfiyati WHERE nStokId = tbStok.NstokId AND sFiyatTipi = '" & sFiyatM & "')) AS Maliyet, TempMevcut.lMevcut AS lMevcut FROM tbStok INNER JOIN tbStokBarkodu ON tbStok.nStokID = tbStokBarkodu.nStokID AND tbStokBarkodu.nKisim = 0 INNER JOIN tbStokSinifi ON tbStok.nStokID = tbStokSinifi.nStokID INNER JOIN tbSSinif1 ON tbStokSinifi.sSinifKodu1 = tbSSinif1.sSinifKodu LEFT OUTER JOIN (SELECT nStokID, isnull(SUM(tbStokFisiDetayi.lGirisMiktar1 - tbStokFisiDetayi.lCikisMiktar1), 0) AS lMevcut FROM tbStokFisiDetayi WHERE tbStokFisiDetayi.dteIslemTarihi <= '" & tarih2 & "'  GROUP BY nStokID) TempMevcut ON tbStok.nStokID = TempMevcut.nStokID WHERE tbStok.sKodu <> '' AND tbStokSinifi.sSinifKodu1 = '02' AND tbStok.nStokTipi < 5  AND (TempMevcut.lMevcut > 0)) tbStoklar "))

        Dim dr1 As DataRow
        lBorc = 0
        lAlacak = 0
        lBorcBakiye = 0
        lAlacakBakiye = 0

        'For Each dr In ds_tbAktif.Tables(0).Rows
        '    If dr("sHesap2") = "10" And Len(dr("sHesap3")) >= 3 Then
        '        'MsgBox(dr("sHesap3").ToString.Substring(0, 3))
        '        If dr("sHesap3").ToString.Substring(0, 3) = 100 Then
        '            dr("lBorcTutar") = lBorc
        '            dr("lAlacakTutar") = lAlacak
        '            dr("lBorcBakiye") = lBorcBakiye
        '            dr("lAlacakBakiye") = lAlacakBakiye
        '        End If
        '    End If

        'Next
        For Each dr In ds_tbAktif.Tables(0).Rows
            'If dr("sHesap3") = "1" Or dr("sHesap3") = "10" Or dr("sHesap3") = "100" Then
            '    For Each dr1 In ds_tbKasa.Tables(0).Rows
            '        dr("lBorcTutar") = dr("lBorcTutar") + sorgu_sayi(dr1("lBorcTutar"), 0)
            '        dr("lAlacakTutar") = dr("lAlacakTutar") + sorgu_sayi(dr1("lAlacakTutar"), 0)
            '        If Not IsDBNull(dr1("lBakiye")) AndAlso dr1("lBakiye") > 0 Then
            '            dr("lBorcBakiye") = Math.Abs(sorgu_sayi(dr1("lBakiye"), 0))
            '        Else
            '            dr("lAlacakBakiye") = Math.Abs(sorgu_sayi(dr1("lBakiye"), 0))
            '        End If
            '    Next
            If dr("sHesap3") = "1" Or dr("sHesap3") = "10" Or dr("sHesap3") = "101" Then
                For Each dr1 In ds_tbCekAlinan.Tables(0).Rows
                    dr("lBorcTutar") = dr("lBorcTutar") + sorgu_sayi(dr1("lBorcTutar"), 0)
                    dr("lAlacakTutar") = dr("lAlacakTutar") + sorgu_sayi(dr1("lAlacakTutar"), 0)
                    If dr1("lTutar") > 0 Then
                        dr("lBorcBakiye") = Math.Abs(sorgu_sayi(dr1("lTutar"), 0))
                    Else
                        dr("lAlacakBakiye") = Math.Abs(sorgu_sayi(dr1("lTutar"), 0))
                    End If
                Next

            ElseIf dr("sHesap3") = "1" Or dr("sHesap3") = "10" Or dr("sHesap3") = "103" Then
                For Each dr1 In ds_tbCekVerilen.Tables(0).Rows
                    dr("lBorcTutar") = dr("lBorcTutar") + sorgu_sayi(dr1("lBorcTutar"), 0)
                    dr("lAlacakTutar") = dr("lAlacakTutar") + sorgu_sayi(dr1("lAlacakTutar"), 0)
                    If dr1("lBakiye") > 0 Then
                        dr("lBorcBakiye") = Math.Abs(sorgu_sayi(dr1("lTutar"), 0))
                    Else
                        dr("lAlacakBakiye") = Math.Abs(sorgu_sayi(dr1("lTutar"), 0))
                    End If
                Next
            ElseIf dr("sHesap3") = "1" Or dr("sHesap3") = "15" Or dr("sHesap3") = "150" Then
                sKod = "150"
                sAciklama = Sorgu_sDil("İnşaat Ticari Mallar", sDil)
                sAciklamaTR = "Ticari Mallar"
                ds_tbTicariMallar = sorgu(sorgu_query("SELECT '" & sKod & "' AS sHesap, '" & sKod & "' AS sKodu, N'" & sAciklamaTR & "'  sAciklamaTR,N'" & sAciklama & "'  sAciklama, SUM(lMevcut) AS lBorcTutar, SUM(lMevcut * Maliyet) AS lAlacakTutar, 0 as lBakiye,SUM(lMevcut * Maliyet) AS lTutar,1 as nDurum FROM (SELECT tbStok.*, tbStokBarkodu.sBarkod AS sBarkod, tbSSinif1.sAciklama AS Sinif1, ((SELECT isnull(lfiyat, 0) FROM tbstokfiyati WHERE nStokId = tbStok.NstokId AND sFiyatTipi = '" & sFiyatM & "')) AS Maliyet, TempMevcut.lMevcut AS lMevcut FROM tbStok INNER JOIN tbStokBarkodu ON tbStok.nStokID = tbStokBarkodu.nStokID AND tbStokBarkodu.nKisim = 0 INNER JOIN tbStokSinifi ON tbStok.nStokID = tbStokSinifi.nStokID INNER JOIN tbSSinif1 ON tbStokSinifi.sSinifKodu1 = tbSSinif1.sSinifKodu LEFT OUTER JOIN (SELECT nStokID, isnull(SUM(tbStokFisiDetayi.lGirisMiktar1 - tbStokFisiDetayi.lCikisMiktar1), 0) AS lMevcut FROM tbStokFisiDetayi WHERE tbStokFisiDetayi.dteIslemTarihi <= '" & tarih2 & "'  GROUP BY nStokID) TempMevcut ON tbStok.nStokID = TempMevcut.nStokID WHERE tbStok.sKodu <> '' AND tbStokSinifi.sSinifKodu1 = '02' AND tbStok.nStokTipi < 5  AND (TempMevcut.lMevcut > 0)) tbStoklar "))

                For Each dr1 In ds_tbTicariMallar.Tables(0).Rows
                    sKod = "153"
                    sAciklama = Sorgu_sDil("Mağaza Ticari Mallar", sDil)
                    sAciklamaTR = "Ticari Mallar"
                    ds_tbTicariMallar = sorgu(sorgu_query("SELECT '" & sKod & "' AS sHesap, '" & sKod & "' AS sKodu, N'" & sAciklamaTR & "'  sAciklamaTR,N'" & sAciklama & "'  sAciklama, SUM(lMevcut) AS lBorcTutar, SUM(lMevcut * Maliyet) AS lAlacakTutar, 0 as lBakiye,SUM(lMevcut * Maliyet) AS lTutar,1 as nDurum FROM (SELECT tbStok.*, tbStokBarkodu.sBarkod AS sBarkod, tbSSinif1.sAciklama AS Sinif1, ((SELECT isnull(lfiyat, 0) FROM tbstokfiyati WHERE nStokId = tbStok.NstokId AND sFiyatTipi = '" & sFiyatM & "')) AS Maliyet, TempMevcut.lMevcut AS lMevcut FROM tbStok INNER JOIN tbStokBarkodu ON tbStok.nStokID = tbStokBarkodu.nStokID AND tbStokBarkodu.nKisim = 0 INNER JOIN tbStokSinifi ON tbStok.nStokID = tbStokSinifi.nStokID INNER JOIN tbSSinif1 ON tbStokSinifi.sSinifKodu1 = tbSSinif1.sSinifKodu LEFT OUTER JOIN (SELECT nStokID, isnull(SUM(tbStokFisiDetayi.lGirisMiktar1 - tbStokFisiDetayi.lCikisMiktar1), 0) AS lMevcut FROM tbStokFisiDetayi WHERE tbStokFisiDetayi.dteIslemTarihi <= '" & tarih2 & "'  GROUP BY nStokID) TempMevcut ON tbStok.nStokID = TempMevcut.nStokID WHERE tbStok.sKodu <> '' AND tbStokSinifi.sSinifKodu1 = '01' AND tbStok.nStokTipi < 5  AND (TempMevcut.lMevcut > 0)) tbStoklar "))

                    dr("lBorcTutar") = dr("lBorcTutar") + sorgu_sayi(dr1("lBorcTutar"), 0)
                    dr("lAlacakTutar") = dr("lAlacakTutar") + sorgu_sayi(dr1("lAlacakTutar"), 0)
                    If dr1("lBakiye") > 0 Then
                        dr("lBorcBakiye") = dr("lBorcBakiye") + dr1("lBakiye")
                    Else
                        dr("lAlacakBakiye") = dr("lAlacakBakiye") + dr1("lBakiye")
                    End If
                Next

            ElseIf dr("sHesap3") = "1" Or dr("sHesap3") = "15" Or dr("sHesap3") = "153" Then
                For Each dr1 In ds_tbTicariMallar.Tables(0).Rows
                    dr("lBorcTutar") = dr("lBorcTutar") + sorgu_sayi(dr1("lBorcTutar"), 0)
                    dr("lAlacakTutar") = dr("lAlacakTutar") + sorgu_sayi(dr1("lAlacakTutar"), 0)
                    If dr1("lBakiye") > 0 Then
                        dr("lBorcBakiye") = dr("lBorcBakiye") + dr1("lBakiye")
                    Else
                        dr("lAlacakBakiye") = dr("lAlacakBakiye") + dr1("lBakiye")
                    End If
                Next
            End If
        Next
        For Each dr In ds_tbAktif.Tables(0).Rows
            If Trim(dr("sHesap2")) = "10" And Len(dr("sHesap3")) = 3 Then
                lBorc = lBorc + dr("lBorcTutar")
                lAlacak = lAlacak + dr("lAlacakTutar")
                lBorcBakiye = lBorcBakiye + dr("lBorcBakiye")
                lAlacakBakiye = lAlacakBakiye + dr("lAlacakBakiye")
            End If

        Next
        For Each dr In ds_tbAktif.Tables(0).Rows
            If dr("sHesap3") = "10" Then
                dr("lBorcTutar") = lBorc
                dr("lAlacakTutar") = lAlacak
                dr("lBorcBakiye") = lBorcBakiye
                dr("lAlacakBakiye") = lAlacakBakiye
            End If
        Next
        lBorc = 0
        lAlacak = 0
        lBorcBakiye = 0
        lAlacakBakiye = 0

        For Each dr In ds_tbAktif.Tables(0).Rows
            If Trim(dr("sHesap2")) = "13" And Len(dr("sHesap3")) = 3 Then
                lBorc = lBorc + dr("lBorcTutar")
                lAlacak = lAlacak + dr("lAlacakTutar")
                lBorcBakiye = lBorcBakiye + dr("lBorcBakiye")
                lAlacakBakiye = lAlacakBakiye + dr("lAlacakBakiye")
            End If
        Next
        For Each dr In ds_tbAktif.Tables(0).Rows
            If dr("sHesap3") = "13" Then
                dr("lBorcTutar") = lBorc
                dr("lAlacakTutar") = lAlacak
                dr("lBorcBakiye") = lBorcBakiye
                dr("lAlacakBakiye") = lAlacakBakiye
            End If
        Next
        lBorc = 0
        lAlacak = 0
        lBorcBakiye = 0
        lAlacakBakiye = 0
        For Each dr In ds_tbAktif.Tables(0).Rows
            If dr("sHesap3") = "10" Or dr("sHesap3") = "11" Or dr("sHesap3") = "12" Or dr("sHesap3") = "13" Or dr("sHesap3") = "14" Or dr("sHesap3") = "15" Or dr("sHesap3") = "16" Or dr("sHesap3") = "17" Or dr("sHesap3") = "18" Or dr("sHesap3") = "19" Then
                lBorc = lBorc + dr("lBorcTutar")
                lAlacak = lAlacak + dr("lAlacakTutar")
                lBorcBakiye = lBorcBakiye + dr("lBorcBakiye")
                lAlacakBakiye = lAlacakBakiye + dr("lAlacakBakiye")
            End If
        Next
        For Each dr In ds_tbAktif.Tables(0).Rows
            If dr("sHesap3") = "1" Then
                dr("lBorcTutar") = lBorc
                dr("lAlacakTutar") = lAlacak
                dr("lBorcBakiye") = lBorcBakiye
                dr("lAlacakBakiye") = lAlacakBakiye
            End If
        Next
        For Each dr In ds_tbAktif.Tables(0).Rows
            'If dr("sHesap3") = "1" Or dr("sHesap3") = "15" Or dr("sHesap3") = "153" Then
            '    dr("Simdiki") = mevcut_tutar + dr("Simdiki")
            'End If
            If dr("nDurum") = 0 Then
                If s0 = "" Then
                    s0 = "I"
                ElseIf s0 = "I" Then
                    s0 = "II"
                ElseIf s0 = "II" Then
                    s0 = "III"
                ElseIf s0 = "III" Then
                    s0 = "IV"
                ElseIf s0 = "IV" Then
                    s0 = "V"
                ElseIf s0 = "V" Then
                    s0 = "VI"
                ElseIf s0 = "VI" Then
                    s0 = "VII"
                End If
                dr("sAciklamaTR") = s0 & " - " & dr("sAciklamaTR")
                dr("sAciklamaEN") = s0 & " - " & dr("sAciklamaEN")
            ElseIf dr("nDurum") = 1 Then
                If s1 = "" Then
                    s1 = "A"
                ElseIf s1 = "A" Then
                    s1 = "B"
                ElseIf s1 = "B" Then
                    s1 = "C"
                ElseIf s1 = "C" Then
                    s1 = "D"
                ElseIf s1 = "D" Then
                    s1 = "E"
                ElseIf s1 = "E" Then
                    s1 = "F"
                ElseIf s1 = "F" Then
                    s1 = "G"
                ElseIf s1 = "G" Then
                    s1 = "H"
                ElseIf s1 = "H" Then
                    s1 = "I"
                ElseIf s1 = "I" Then
                    s1 = "J"
                ElseIf s1 = "J" Then
                    s1 = "K"
                ElseIf s1 = "K" Then
                    s1 = "L"
                ElseIf s1 = "L" Then
                    s1 = "M"
                ElseIf s1 = "M" Then
                    s1 = "N"
                ElseIf s1 = "N" Then
                    s1 = "O"
                ElseIf s1 = "O" Then
                    s1 = "P"
                ElseIf s1 = "P" Then
                    s1 = "R"
                ElseIf s1 = "R" Then
                    s1 = "S"
                ElseIf s1 = "S" Then
                    s1 = "T"
                ElseIf s1 = "T" Then
                    s1 = "U"
                ElseIf s1 = "U" Then
                    s1 = "V"
                ElseIf s1 = "V" Then
                    s1 = "Y"
                ElseIf s1 = "Y" Then
                    s1 = "Z"
                End If
                s2 = 0
                dr("sAciklamaTR") = vbTab & s1.ToString & "-" & dr("sAciklamaTR")
                'dr("sAciklamaEN") = vbTab & s1.ToString & "-" & dr("sAciklamaEN")
            ElseIf dr("nDurum") = 2 Then
                lBorc = lBorc + sorgu_sayi(dr("lBorcTutar"), 0)
                lAlacak = lAlacak + sorgu_sayi(dr("lAlacakTutar"), 0)
                lBorcBakiye = lBorcBakiye + sorgu_sayi(dr("lBorcBakiye"), 0)
                lAlacakBakiye = lAlacakBakiye + sorgu_sayi(dr("lAlacakBakiye"), 0)
                s2 += 1
                dr("sAciklamaTR") = vbTab & vbTab & s2.ToString & "-" & dr("sAciklamaTR")
                'dr("sAciklamaEN") = vbTab & vbTab & s2.ToString & "-" & dr("sAciklamaEN")
            End If
        Next
        collBorc.SummaryItem.DisplayFormat = "" & FormatNumber(Math.Abs(lBorc), 2).ToString '& "(" & bakiye_status & ")"
        collAlacak.SummaryItem.DisplayFormat = "" & FormatNumber(Math.Abs(lAlacak), 2).ToString '& "(" & bakiye_status & ")"
        collBorcBakiye.SummaryItem.DisplayFormat = "" & FormatNumber(Math.Abs(lBorcBakiye), 2).ToString '& "(" & bakiye_status & ")"
        collAlacakBakiye.SummaryItem.DisplayFormat = "" & FormatNumber(Math.Abs(lAlacakBakiye), 2).ToString '& "(" & bakiye_status & ")"
        s0 = Nothing
        s1 = Nothing
        s2 = Nothing
        s4 = Nothing
    End Sub
    Public Sub Dataload_tbPasif(ByVal tarih1 As DateTime, ByVal tarih2 As DateTime)
        Try
            ds_tbPasif.Tables(0).Clear()
        Catch ex As Exception
        End Try
        Dim conn As New OleDb.OleDbConnection
        Dim cmd As New OleDb.OleDbCommand
        Dim adapter As New OleDb.OleDbDataAdapter
        conn.ConnectionString = connection
        adapter.SelectCommand = cmd
        If sec_detay.Text = "Ozet" Then
            cmd.CommandText = sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT tbBilancoGelirTablosuHesaplari.sHesap2, tbBilancoGelirTablosuHesaplari.sHesap3, tbBilancoGelirTablosuHesaplari.sAciklamaTR, tbBilancoGelirTablosuHesaplari.sAciklamaEN, ISNULL(tempBilancoAktif.Onceki, 0) AS Onceki, ISNULL(tempBilancoAktif.Simdiki, 0) AS Simdiki, tbBilancoGelirTablosuHesaplari.bFormulMu, tbBilancoGelirTablosuHesaplari.sHesapSirasi, tbBilancoGelirTablosuHesaplari.nDurum FROM tbBilancoGelirTablosuHesaplari LEFT OUTER JOIN (SELECT HesapKodu , SUM(Simdiki) AS Simdiki , SUM(Onceki) AS Onceki FROM (SELECT substring(tbFirma.sKodu , 1 , 2) AS HesapKodu , SUM((tbFirmaHareketi.lAlacakTutar - tbFirmaHareketi.lBorcTutar)) AS Simdiki , 0 AS Onceki FROM tbFirma , tbFirmaHareketi WHERE tbFirma.nFirmaID = tbFirmaHareketi.nFirmaID AND tbFirmaHareketi.dteIslemTarihi BETWEEN '" & tarih1 & "' AND '" & tarih2 & "' GROUP BY substring(tbFirma.sKodu , 1 , 2) UNION SELECT substring(tbFirma.sKodu , 1 , 3) AS HesapKodu , SUM((tbFirmaHareketi.lAlacakTutar - tbFirmaHareketi.lBorcTutar)) AS Simdiki , 0 AS Onceki FROM tbFirma , tbFirmaHareketi WHERE tbFirma.nFirmaID = tbFirmaHareketi.nFirmaID AND tbFirmaHareketi.dteIslemTarihi BETWEEN '" & tarih1 & "' AND '" & tarih2 & "' GROUP BY substring(tbFirma.sKodu , 1 , 3) UNION SELECT substring(tbFirma.sKodu , 1 , 1) AS HesapKodu , SUM((tbFirmaHareketi.lAlacakTutar - tbFirmaHareketi.lBorcTutar)) AS Simdiki , 0 AS Onceki FROM tbFirma , tbFirmaHareketi WHERE tbFirma.nFirmaID = tbFirmaHareketi.nFirmaID AND tbFirmaHareketi.dteIslemTarihi BETWEEN '" & tarih1 & "' AND '" & tarih2 & "' GROUP BY substring(tbFirma.sKodu , 1 , 1)) AS tempBilanco GROUP BY HesapKodu) tempBilancoAktif ON tempBilancoAktif.HesapKodu = tbBilancoGelirTablosuHesaplari.sHesap3 WHERE (tbBilancoGelirTablosuHesaplari.nRaporTipi = 1) AND (tbBilancoGelirTablosuHesaplari.bAktifMi = 0) ORDER BY tbBilancoGelirTablosuHesaplari.sHesapSirasi")
        ElseIf sec_detay.Text = "Detayli" Then
            cmd.CommandText = sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT * FROM (SELECT tbBilancoGelirTablosuHesaplari.sHesap2 , tbBilancoGelirTablosuHesaplari.sHesap3 , tbBilancoGelirTablosuHesaplari.sAciklamaTR , ISNULL(tempBilancoAktif.Onceki , 0) AS Onceki , ISNULL(tempBilancoAktif.Simdiki , 0) AS Simdiki , tbBilancoGelirTablosuHesaplari.bFormulMu , tbBilancoGelirTablosuHesaplari.sHesapSirasi , tbBilancoGelirTablosuHesaplari.nDurum FROM tbBilancoGelirTablosuHesaplari LEFT OUTER JOIN (SELECT HesapKodu , SUM(Simdiki) AS Simdiki , SUM(Onceki) AS Onceki FROM (SELECT substring(tbFirma.sKodu , 1 , 2) AS HesapKodu , SUM((tbFirmaHareketi.lAlacakTutar - tbFirmaHareketi.lBorcTutar)) AS Simdiki , 0 AS Onceki FROM tbFirma , tbFirmaHareketi WHERE tbFirma.nFirmaID = tbFirmaHareketi.nFirmaID AND tbFirmaHareketi.dteIslemTarihi BETWEEN '" & tarih1 & "' AND '" & tarih2 & "' GROUP BY substring(tbFirma.sKodu , 1 , 2) UNION SELECT substring(tbFirma.sKodu , 1 , 3) AS HesapKodu , SUM((tbFirmaHareketi.lAlacakTutar - tbFirmaHareketi.lBorcTutar)) AS Simdiki , 0 AS Onceki FROM tbFirma , tbFirmaHareketi WHERE tbFirma.nFirmaID = tbFirmaHareketi.nFirmaID AND tbFirmaHareketi.dteIslemTarihi BETWEEN '" & tarih1 & "' AND '" & tarih2 & "' GROUP BY substring(tbFirma.sKodu , 1 , 3) UNION SELECT substring(tbFirma.sKodu , 1 , 1) AS HesapKodu , SUM((tbFirmaHareketi.lAlacakTutar - tbFirmaHareketi.lBorcTutar)) AS Simdiki , 0 AS Onceki FROM tbFirma , tbFirmaHareketi WHERE tbFirma.nFirmaID = tbFirmaHareketi.nFirmaID AND tbFirmaHareketi.dteIslemTarihi BETWEEN '" & tarih1 & "' AND '" & tarih2 & "' GROUP BY substring(tbFirma.sKodu , 1 , 1)) AS tempBilanco GROUP BY HesapKodu) tempBilancoAktif ON tempBilancoAktif.HesapKodu = tbBilancoGelirTablosuHesaplari.sHesap3 WHERE (tbBilancoGelirTablosuHesaplari.nRaporTipi = 1) AND (tbBilancoGelirTablosuHesaplari.bAktifMi = 0) UNION ALL SELECT SUBSTRING(tbFirma.sKodu , 1 , 2) AS sHesap2 , SUBSTRING(tbFirma.sKodu , 1 , 20) AS sHesap3 , tbFirma.sAciklama AS sAciklamaTR ,  SUM(tbFirmaHareketi.lAlacakTutar - tbFirmaHareketi.lBorcTutar) AS Onceki , 0 AS Simdiki , 0 AS bFormulMu , tbFirma.sKodu AS sHesapSirasi , 3 AS nDurum FROM tbFirma INNER JOIN tbFirmaHareketi ON tbFirma.nFirmaID = tbFirmaHareketi.nFirmaID WHERE (SUBSTRING(tbFirma.sKodu , 1 , 1) BETWEEN '3' AND '6') AND tbFirmaHareketi.dteIslemTarihi BETWEEN '" & tarih1 & "' AND '" & tarih2 & "' GROUP BY tbFirma.sKodu , tbFirma.sAciklama) TempBilanco ORDER BY sHesapSirasi")
        End If
        'cmd.CommandText = sorgu_query("SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT tbBilancoGelirTablosuHesaplari.sHesap2, tbBilancoGelirTablosuHesaplari.sHesap3, tbBilancoGelirTablosuHesaplari.sAciklamaTR, tbBilancoGelirTablosuHesaplari.sAciklamaEN, ISNULL(tempBilancoAktif.Onceki, 0) AS Onceki, ISNULL(tempBilancoAktif.Simdiki, 0) AS Simdiki, tbBilancoGelirTablosuHesaplari.bFormulMu, tbBilancoGelirTablosuHesaplari.sHesapSirasi, tbBilancoGelirTablosuHesaplari.nDurum FROM tbBilancoGelirTablosuHesaplari LEFT OUTER JOIN (SELECT HesapKodu , SUM(Simdiki) AS Simdiki , SUM(Onceki) AS Onceki FROM (SELECT substring(tbFirma.sKodu , 1 , 2) AS HesapKodu , SUM((tbFirmaHareketi.lAlacakTutar - tbFirmaHareketi.lBorcTutar)) AS Simdiki , 0 AS Onceki FROM tbFirma , tbFirmaHareketi WHERE tbFirma.nFirmaID = tbFirmaHareketi.nFirmaID AND tbFirmaHareketi.dteIslemTarihi BETWEEN '" & tarih1 & "' AND '" & tarih2 & "' GROUP BY substring(tbFirma.sKodu , 1 , 2) UNION SELECT substring(tbFirma.sKodu , 1 , 3) AS HesapKodu , SUM((tbFirmaHareketi.lAlacakTutar - tbFirmaHareketi.lBorcTutar)) AS Simdiki , 0 AS Onceki FROM tbFirma , tbFirmaHareketi WHERE tbFirma.nFirmaID = tbFirmaHareketi.nFirmaID AND tbFirmaHareketi.dteIslemTarihi BETWEEN '" & tarih1 & "' AND '" & tarih2 & "' GROUP BY substring(tbFirma.sKodu , 1 , 3) UNION SELECT substring(tbFirma.sKodu , 1 , 1) AS HesapKodu , SUM((tbFirmaHareketi.lAlacakTutar - tbFirmaHareketi.lBorcTutar)) AS Simdiki , 0 AS Onceki FROM tbFirma , tbFirmaHareketi WHERE tbFirma.nFirmaID = tbFirmaHareketi.nFirmaID AND tbFirmaHareketi.dteIslemTarihi BETWEEN '" & tarih1 & "' AND '" & tarih2 & "' GROUP BY substring(tbFirma.sKodu , 1 , 1)) AS tempBilanco GROUP BY HesapKodu) tempBilancoAktif ON tempBilancoAktif.HesapKodu = tbBilancoGelirTablosuHesaplari.sHesap3 WHERE (tbBilancoGelirTablosuHesaplari.nRaporTipi = 1) AND (tbBilancoGelirTablosuHesaplari.bAktifMi = 0) ORDER BY tbBilancoGelirTablosuHesaplari.sHesapSirasi")
        cmd.Connection = conn
        conn.Open()
        Dim N As Integer = adapter.Fill(ds_tbPasif, "Table1")
        conn.Close()
        Dim dr As DataRow
        Dim s0 As String = ""
        Dim s1 As String = ""
        Dim s2 As Integer = 0
        Dim s4 As String = ""
        For Each dr In ds_tbPasif.Tables(0).Rows
            If dr("nDurum") = 0 Then
                If s0 = "" Then
                    s0 = "I"
                ElseIf s0 = "I" Then
                    s0 = "II"
                ElseIf s0 = "II" Then
                    s0 = "III"
                ElseIf s0 = "III" Then
                    s0 = "IV"
                ElseIf s0 = "IV" Then
                    s0 = "V"
                ElseIf s0 = "V" Then
                    s0 = "VI"
                ElseIf s0 = "VI" Then
                    s0 = "VII"
                End If
                dr("sAciklamaTR") = s0 & " - " & dr("sAciklamaTR")
                dr("sAciklamaEN") = s0 & " - " & dr("sAciklamaEN")
            ElseIf dr("nDurum") = 1 Then
                If s1 = "" Then
                    s1 = "A"
                ElseIf s1 = "A" Then
                    s1 = "B"
                ElseIf s1 = "B" Then
                    s1 = "C"
                ElseIf s1 = "C" Then
                    s1 = "D"
                ElseIf s1 = "D" Then
                    s1 = "E"
                ElseIf s1 = "E" Then
                    s1 = "F"
                ElseIf s1 = "F" Then
                    s1 = "G"
                ElseIf s1 = "G" Then
                    s1 = "H"
                ElseIf s1 = "H" Then
                    s1 = "I"
                ElseIf s1 = "I" Then
                    s1 = "J"
                ElseIf s1 = "J" Then
                    s1 = "K"
                ElseIf s1 = "K" Then
                    s1 = "L"
                ElseIf s1 = "L" Then
                    s1 = "M"
                ElseIf s1 = "M" Then
                    s1 = "N"
                ElseIf s1 = "N" Then
                    s1 = "O"
                ElseIf s1 = "O" Then
                    s1 = "P"
                ElseIf s1 = "P" Then
                    s1 = "R"
                ElseIf s1 = "R" Then
                    s1 = "S"
                ElseIf s1 = "S" Then
                    s1 = "T"
                ElseIf s1 = "T" Then
                    s1 = "U"
                ElseIf s1 = "U" Then
                    s1 = "V"
                ElseIf s1 = "V" Then
                    s1 = "Y"
                ElseIf s1 = "Y" Then
                    s1 = "Z"
                End If
                s2 = 0
                dr("sAciklamaTR") = vbTab & s1.ToString & "-" & dr("sAciklamaTR")
                dr("sAciklamaEN") = vbTab & s1.ToString & "-" & dr("sAciklamaEN")
            ElseIf dr("nDurum") = 2 Then
                s2 += 1
                dr("sAciklamaTR") = vbTab & vbTab & s2.ToString & "-" & dr("sAciklamaTR")
                dr("sAciklamaEN") = vbTab & vbTab & s2.ToString & "-" & dr("sAciklamaEN")
            End If
        Next
        s0 = Nothing
        s1 = Nothing
        s2 = Nothing
        s4 = Nothing
    End Sub
    Private Sub frm_tbBilanco_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Try
            gorunum_yukle()
        Catch ex As Exception
        End Try
        'DateEdit1.EditValue = dteSistemTarihi
        'DateEdit2.EditValue = dteSistemTarihi
        PanelControl1.Focus()
        GroupControl1.Focus()
        GroupControl1.Select()
        txt_ara.EditValue = ""
        txt_ara.Focus()
        txt_ara.Select()
        DateEdit1.Focus()
        DateEdit1.Select()
    End Sub
    Private Function dataload_mevcut_mal(ByVal tarih1 As DateTime, ByVal tarih2 As DateTime) As Decimal
        Dim ds1 As DataSet
        Dim tutar As Decimal = 0
        ds1 = sorgu(sorgu_query("set dateformat dmy SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED SELECT '0' AS IND, 'Envanter' AS Baslik, 'Mevcut Mal Tutarı' AS Aciklama, COUNT(DISTINCT nStokID) AS Sayi, SUM(Mevcut) AS Miktar, SUM(Mevcut * Maliyet) AS Tutar FROM (SELECT Stok.nStokID , (SELECT isnull(SUM(tbStokFisiDetayi.lGirisMiktar1 - tbStokFisiDetayi.lCikisMiktar1) , 0) FROM tbStokFisiDetayi WHERE Stok.nStokID = tbStokFisiDetayi.nStokID AND tbStokFisiDetayi.dteIslemTarihi <= '" & tarih2 & "') AS Mevcut , ((SELECT isnull(lfiyat , 0) FROM tbstokfiyati WHERE nStokId = stok.NstokId AND sFiyatTipi = '" & sFiyatM & "')) AS Maliyet FROM tbStok stok INNER JOIN tbStokBarkodu barkod ON stok.nStokID = barkod.nStokID INNER JOIN tbRenk ON stok.sRenk = tbRenk.sRenk WHERE (SELECT isnull(SUM(tbStokFisiDetayi.lGirisMiktar1 - tbStokFisiDetayi.lCikisMiktar1) , 0) FROM tbStokFisiDetayi WHERE Stok.nStokID = tbStokFisiDetayi.nStokID AND tbStokFisiDetayi.dteIslemTarihi <= '" & tarih2 & "') > 0) t"))
        Dim dr1 As DataRow
        For Each dr1 In ds1.Tables(0).Rows
            'dr = DataSet1.Tables(0).NewRow
            'dr("Baslik") = Sorgu_sDil(dr1("Baslik"), sDil)
            'dr("Aciklama") = Sorgu_sDil(dr1("Aciklama"), sDil)
            'dr("Miktar") = sorgu_sayi(dr1("Miktar"), 0)
            'dr("Sayi") = sorgu_sayi(dr1("Sayi"), 0)
            'dr("Tutar") = sorgu_sayi(dr1("Tutar"), 0)
            tutar = sorgu_sayi(dr1("Tutar"), 0)
            'DataSet1.Tables(0).Rows.Add(dr)
        Next
        Return tutar
    End Function
    Private Sub SimpleButton5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        raporla_excel()
    End Sub
    Private Sub raporla_excel()
        If XtraTabControl1.SelectedTabPageIndex = 0 Then
            If XtraMessageBox.Show(Sorgu_sDil("Bilanço Aktiflerine Excel Dosyası Oluşturmak İstediğinize Emin misiniz...?", sDil), Sorgu_sDil("Dikkat", sDil), MessageBoxButtons.YesNo, MessageBoxIcon.Question) = MsgBoxResult.Yes Then
                SaveFileDialog1.Filter = "Excel Dosyaları(*.xls) |*.xls"
                SaveFileDialog1.InitialDirectory = "c:\"
                SaveFileDialog1.FileName = "BilançoAktif.xls"
                If SaveFileDialog1.ShowDialog = Windows.Forms.DialogResult.OK Then
                    GridView1.ExportToXls(SaveFileDialog1.FileName.ToString)
                End If
            End If
        ElseIf XtraTabControl1.SelectedTabPageIndex = 1 Then
            If XtraMessageBox.Show(Sorgu_sDil("Bilanço Pasiflerine Excel Dosyası Oluşturmak İstediğinize Emin misiniz...?", sDil), Sorgu_sDil("Dikkat", sDil), MessageBoxButtons.YesNo, MessageBoxIcon.Question) = MsgBoxResult.Yes Then
                SaveFileDialog1.Filter = "Excel Dosyaları(*.xls) |*.xls"
                SaveFileDialog1.InitialDirectory = "c:\"
                SaveFileDialog1.FileName = "BilançoPasif.xls"
                If SaveFileDialog1.ShowDialog = Windows.Forms.DialogResult.OK Then
                    GridView1.ExportToXls(SaveFileDialog1.FileName.ToString)
                End If
            End If
        End If
    End Sub
    Private Sub raporla_text()
        If XtraTabControl1.SelectedTabPageIndex = 0 Then
            If XtraMessageBox.Show(Sorgu_sDil("Sonuçları Text Dosyası Oluşturmak İstediğinize Emin misiniz...?", sDil), Sorgu_sDil("Dikkat", sDil), MessageBoxButtons.YesNo, MessageBoxIcon.Question) = MsgBoxResult.Yes Then
                Dim SaveFileDialog1 As New Windows.Forms.SaveFileDialog
                SaveFileDialog1.Filter = "Text Dosyaları(*.txt) |*.txt"
                SaveFileDialog1.InitialDirectory = "c:\"
                SaveFileDialog1.FileName = "Rapor.txt"
                If SaveFileDialog1.ShowDialog = Windows.Forms.DialogResult.OK Then
                    GridView1.ExportToText(SaveFileDialog1.FileName.ToString)
                    If XtraMessageBox.Show(Sorgu_sDil("Kaydı Açmak İster misiniz...?", sDil), Sorgu_sDil("Dikkat", sDil), MessageBoxButtons.YesNo, MessageBoxIcon.Question) = MsgBoxResult.Yes Then
                        Process.Start(SaveFileDialog1.FileName.ToString)
                    End If
                End If
                SaveFileDialog1 = Nothing
            End If
        ElseIf XtraTabControl1.SelectedTabPageIndex = 1 Then
            If XtraMessageBox.Show(Sorgu_sDil("Sonuçları Text Dosyası Oluşturmak İstediğinize Emin misiniz...?", sDil), Sorgu_sDil("Dikkat", sDil), MessageBoxButtons.YesNo, MessageBoxIcon.Question) = MsgBoxResult.Yes Then
                Dim SaveFileDialog1 As New Windows.Forms.SaveFileDialog
                SaveFileDialog1.Filter = "Text Dosyaları(*.txt) |*.txt"
                SaveFileDialog1.InitialDirectory = "c:\"
                SaveFileDialog1.FileName = "Rapor.txt"
                If SaveFileDialog1.ShowDialog = Windows.Forms.DialogResult.OK Then
                    GridView2.ExportToText(SaveFileDialog1.FileName.ToString)
                    If XtraMessageBox.Show(Sorgu_sDil("Kaydı Açmak İster misiniz...?", sDil), Sorgu_sDil("Dikkat", sDil), MessageBoxButtons.YesNo, MessageBoxIcon.Question) = MsgBoxResult.Yes Then
                        Process.Start(SaveFileDialog1.FileName.ToString)
                    End If
                End If
                SaveFileDialog1 = Nothing
            End If
        End If
    End Sub
    Private Sub raporla_pdf()
        If XtraTabControl1.SelectedTabPageIndex = 0 Then
            If XtraMessageBox.Show(Sorgu_sDil("Sonuçları Metin Dosyası Oluşturmak İstediğinize Emin misiniz...?", sDil), Sorgu_sDil("Dikkat", sDil), MessageBoxButtons.YesNo, MessageBoxIcon.Question) = MsgBoxResult.Yes Then
                Dim SaveFileDialog1 As New Windows.Forms.SaveFileDialog
                SaveFileDialog1.Filter = "Metin Dosyaları(*.pdf) |*.pdf"
                SaveFileDialog1.InitialDirectory = "c:\"
                SaveFileDialog1.FileName = "Rapor.pdf"
                If SaveFileDialog1.ShowDialog = Windows.Forms.DialogResult.OK Then
                    GridView1.ExportToPdf(SaveFileDialog1.FileName.ToString)
                    If XtraMessageBox.Show(Sorgu_sDil("Kaydı Açmak İster misiniz...?", sDil), Sorgu_sDil("Dikkat", sDil), MessageBoxButtons.YesNo, MessageBoxIcon.Question) = MsgBoxResult.Yes Then
                        Process.Start(SaveFileDialog1.FileName.ToString)
                    End If
                End If
                SaveFileDialog1 = Nothing
            End If
        ElseIf XtraTabControl1.SelectedTabPageIndex = 0 Then
            If XtraMessageBox.Show(Sorgu_sDil("Sonuçları Metin Dosyası Oluşturmak İstediğinize Emin misiniz...?", sDil), Sorgu_sDil("Dikkat", sDil), MessageBoxButtons.YesNo, MessageBoxIcon.Question) = MsgBoxResult.Yes Then
                Dim SaveFileDialog1 As New Windows.Forms.SaveFileDialog
                SaveFileDialog1.Filter = "Metin Dosyaları(*.pdf) |*.pdf"
                SaveFileDialog1.InitialDirectory = "c:\"
                SaveFileDialog1.FileName = "Rapor.pdf"
                If SaveFileDialog1.ShowDialog = Windows.Forms.DialogResult.OK Then
                    GridView2.ExportToPdf(SaveFileDialog1.FileName.ToString)
                    If XtraMessageBox.Show(Sorgu_sDil("Kaydı Açmak İster misiniz...?", sDil), Sorgu_sDil("Dikkat", sDil), MessageBoxButtons.YesNo, MessageBoxIcon.Question) = MsgBoxResult.Yes Then
                        Process.Start(SaveFileDialog1.FileName.ToString)
                    End If
                End If
                SaveFileDialog1 = Nothing
            End If
        End If
    End Sub
    Private Sub SimpleButton4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        gorunum_yazdir()
    End Sub
    Private Sub gorunum_kaydet()
        GridView1.SaveLayoutToRegistry("SOFTWARE\BusinessSmart\VIEW\MAGAZA\" & Me.Name.ToString & "")
        XtraMessageBox.Show(Sorgu_sDil("Görünüm Kaydedildi", sDil), Sorgu_sDil("Dikkat", sDil), MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub
    Private Sub gorunum_yukle()
        For Each btn As DevExpress.XtraBars.BarItem In BarManager1.Items
            btn.Caption = Sorgu_sDil(btn.Caption, sDil)
        Next
        For Each clmn As DevExpress.XtraGrid.Columns.GridColumn In GridView1.Columns
            clmn.Caption = Sorgu_sDil(clmn.Caption, sDil)
        Next
        For Each clmn As DevExpress.XtraGrid.Columns.GridColumn In GridView2.Columns
            clmn.Caption = Sorgu_sDil(clmn.Caption, sDil)
        Next
        SimpleButton1.Text = Sorgu_sDil(SimpleButton1.Text, sDil)
        SimpleButton2.Text = Sorgu_sDil(SimpleButton2.Text, sDil)
        SimpleButton3.Text = Sorgu_sDil(SimpleButton3.Text, sDil)
        LabelControl1.Text = Sorgu_sDil(LabelControl1.Text, sDil)
        LabelControl2.Text = Sorgu_sDil(LabelControl2.Text, sDil)
        LabelControl3.Text = Sorgu_sDil(LabelControl3.Text, sDil)
        LabelControl4.Text = Sorgu_sDil(LabelControl4.Text, sDil)
        LabelControl5.Text = Sorgu_sDil(LabelControl5.Text, sDil)
        GridView1.RestoreLayoutFromRegistry("SOFTWARE\BusinessSmart\VIEW\MAGAZA\" & Me.Name.ToString & "")
    End Sub
    Private Sub gorunum_yazdir()
        If XtraTabControl1.SelectedTabPageIndex = 0 Then
            printlink1.CreateDocument(ps)
            ps.PreviewRibbonFormEx.Show()
        ElseIf XtraTabControl1.SelectedTabPageIndex = 1 Then
            printlink2.CreateDocument(ps)
            ps.PreviewRibbonFormEx.Show()
        End If
    End Sub
    Private Sub XtraTabControl1_SelectedPageChanged(ByVal sender As Object, ByVal e As DevExpress.XtraTab.TabPageChangedEventArgs) Handles XtraTabControl1.SelectedPageChanged
        If XtraTabControl1.SelectedTabPageIndex = 0 Then
            GridControl1.Focus()
            GridControl1.Select()
        ElseIf XtraTabControl1.SelectedTabPageIndex = 1 Then
            GridControl2.Focus()
            GridControl2.Select()
        End If
    End Sub
    Private Sub SimpleButton2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SimpleButton2.Click
        Me.Close()
    End Sub
    Private Sub BarButtonItem1_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem1.ItemClick
        gorunum_yazdir()
    End Sub
    Private Sub BarButtonItem2_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem2.ItemClick
        raporla_excel()
    End Sub
    Private Sub BarButtonItem3_ItemClick(ByVal sender As Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem3.ItemClick
        raporla_text()
    End Sub
    Private Sub BarButtonItem4_ItemClick(ByVal sender As Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem4.ItemClick
        raporla_pdf()
    End Sub
    Private Sub BarButtonItem5_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem5.ItemClick
        If Me.WindowState = FormWindowState.Normal Then
            Me.WindowState = FormWindowState.Maximized
        ElseIf Me.WindowState = FormWindowState.Maximized Then
            Me.WindowState = FormWindowState.Normal
        End If
    End Sub

    Private Sub MenuItem23_Click(sender As Object, e As EventArgs) Handles MenuItem23.Click
        If MenuItem23.Checked = False Then
            GridView1.OptionsView.ShowAutoFilterRow = True
            GridView1.OptionsView.ShowFilterPanelMode = DevExpress.XtraGrid.Views.Base.ShowFilterPanelMode.Default
            GridView1.OptionsCustomization.AllowFilter = True
            MenuItem23.Checked = True
        ElseIf MenuItem23.Checked = True Then
            GridView1.OptionsView.ShowAutoFilterRow = False
            GridView1.OptionsView.ShowFilterPanelMode = DevExpress.XtraGrid.Views.Base.ShowFilterPanelMode.Never
            GridView1.OptionsCustomization.AllowFilter = False
            MenuItem23.Checked = True
        End If
    End Sub
End Class