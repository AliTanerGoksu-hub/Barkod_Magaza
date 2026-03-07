Imports DevExpress.XtraEditors
''' <summary>
''' OLD
''' </summary>
Public Class frm_Table_Edit
    Private Const m_RemoveChars As String = " ()"
    Private m_Password As String
    Public m_TableName As String = ""
    Public sKriter As String = ""
    Public firmano
    Public donemno
    Public connection
    Public kullanici
    Public sqlSorguTableEditor As String = ""
    Public FazlaTeslimat As Boolean = False
    Private WithEvents mySQL As SQLConnector
    Private da As SqlClient.SqlDataAdapter
    Private ds As DataSet
    Private dv As DataView
    Private sFilterField As String
    Private sFilterOperator As String
    Private sFilterValue As String
    Private bFilterIsNumeric As Boolean
    Private status As Boolean = False
    Private settings As New ApplicationSettings(UserStorageOption.File)
    Private Sub frm_Table_Edit_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        Dispose()
    End Sub
    Private Sub frm_Table_Edit_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        If FazlaTeslimat = True Then
            sqlSorguTableEditor = "set dateformat dmy SELECT * FROM (SELECT tbMusteri.lKodu as lKodu, tbStokFisiDetayi.dteFisTarihi as dteFisTarihi, tbMusteri.sAdi as sAdi, tbMusteri.sSoyadi as sSoyadi, tbStokFisiDetayi.nIslemID as nIslemID, tbStok.sKodu as sKodu, tbStok.sAciklama as sAciklama, tbAlisverisSiparis.nSiparisID as nSiparisID FROM tbStokFisiDetayi INNER JOIN tbMusteri ON tbStokFisiDetayi.nMusteriID = tbMusteri.nMusteriID INNER JOIN tbStok ON tbStokFisiDetayi.nStokID = tbStok.nStokID LEFT OUTER JOIN tbAlisverisSiparis ON tbStokFisiDetayi.nIslemID = tbAlisverisSiparis.nStokIslemID WHERE (tbStokFisiDetayi.sFisTipi = 'PF')) tbTeslimatlar WHERE (nSiparisID IS NULL) AND (dteFisTarihi between '" & tarihSec1.EditValue & "' and '" & tarihSec2.EditValue & "') ORDER BY dteFisTarihi, lKodu, sKodu"
            tarihSec1.EditValue = dteSistemTarihi
            tarihSec2.EditValue = dteSistemTarihi
            Panel1.Visible = True
        End If
        If Not (mySQL Is Nothing) Then
            If mySQL.IsDatabaseStarted Then mySQL.StopDatabase()
            mySQL.Dispose()
        End If
        mySQL = New SQLConnector("(LOCAL)", "BUSINESS", "SA", "", connection, True)
        If mySQL.IsDatabaseStarted Then
            'dcMain.Text = "Business"
            'BuildTreeView()
            dataload()
        End If
        If m_TableName = sDatabaseGenel + ".dbo." & "tbOdemeSekli" Then
            btn_AltTopluEkle.Enabled = True
        Else
            btn_AltTopluEkle.Enabled = False
        End If
    End Sub
    Private Function GetExceptionMessage(ByRef ex As System.Exception) As String
        Dim m_Message As String = ""
        If Not (ex Is Nothing) Then
            m_Message = GetExceptionMessage(ex.InnerException)
            If m_Message.Equals("") Then
                GetExceptionMessage = ex.Message
            Else
                GetExceptionMessage = ex.Message & vbCrLf & m_Message
            End If
        Else
            GetExceptionMessage = m_Message
        End If
    End Function
    Private Sub dataload()
        status = True
        'SaveTable()
        'ResetFilter()
        If Not m_TableName.ToString.Substring(0, 1).Equals("#") Then
            If Not (dv Is Nothing) Then
                dv.Dispose()
            End If
            If Not (ds Is Nothing) Then
                ds.Dispose()
            End If
            If Not (da Is Nothing) Then
                da.Dispose()
            End If
            SetupBindings(m_TableName, CommandType.TableDirect)
        Else
            'tbFilter.Enabled = False
        End If
        status = False
    End Sub
    Private Sub SetupBindings(ByVal sSQL As String, Optional ByVal SQLType As System.Data.CommandType = CommandType.Text)
        Dim sScript As String
        If SQLType = CommandType.TableDirect Then
            If sSQL = "tbBilancoGelirTablosuHesaplari" Then
                'sScript = "SELECT  sHesapSirasi, sHesap1, sHesap2, sHesap3, sAciklamaTR, sAciklamaEN, sAciklamaAR FROM [" & sSQL & "] " & sKriter & " "
                sScript = "SELECT  * FROM " & sSQL & " " & sKriter & " "
            Else
                If sqlSorguTableEditor <> "" Then
                    GridView1.OptionsBehavior.Editable = False
                    sScript = sqlSorguTableEditor
                Else
                    GridView1.OptionsBehavior.Editable = True
                    sScript = "SELECT * FROM " & sSQL & " " & sKriter & " "
                End If
            End If
            SQLType = CommandType.Text
        Else
            sScript = sSQL
        End If
        da = mySQL.GetDataAdapter(sScript, SQLType)
        da.MissingSchemaAction = MissingSchemaAction.AddWithKey
        ds = New DataSet(m_TableName)
        da.FillSchema(ds, SchemaType.Source, m_TableName)
        da.Fill(ds, m_TableName)
        'grdMain.CaptionText = "Table - " & sSQL
        If ds.Tables(m_TableName).PrimaryKey().Length <> 0 Then
            'If a primary key column exists
            Dim cb As SqlClient.SqlCommandBuilder = New SqlClient.SqlCommandBuilder(da)
            cb.QuotePrefix = "["
            cb.QuoteSuffix = "]"
        Else
            'else
            Me.BuildInsertCommand(da, sSQL)
            Me.BuildUpdateCommand(da, sSQL)
            Me.BuildDeleteCommand(da, sSQL)
        End If
        dv = New DataView(ds.Tables(m_TableName))
        'grdMain.SetDataBinding(ds, m_TableName)
        grdMain.DataSource = Nothing
        GridView1.Columns.Clear()
        grdMain.DataSource = dv
        GridView1.BestFitColumns()
        'grdMain.TableStyles.Clear()
        Dim dgStyle As New DataGridTableStyle
        With dgStyle
            .AlternatingBackColor = Color.LightSkyBlue
            .BackColor = Color.WhiteSmoke
            .ForeColor = Color.MidnightBlue
            .GridLineColor = Color.Honeydew
            .GridLineStyle = System.Windows.Forms.DataGridLineStyle.Solid
            .HeaderBackColor = Color.MidnightBlue
            .HeaderFont = New Font("Tahoma", 8.0!, FontStyle.Bold)
            .HeaderForeColor = Color.White
            .LinkColor = Color.Teal
            .MappingName = ds.Tables(m_TableName).TableName
            .SelectionBackColor = Color.Yellow
            .SelectionForeColor = Color.DarkMagenta
        End With
        'Dim parm As SqlClient.SqlParameter
        'For Each parm In da.InsertCommand.Parameters
        '   Dim grd As New DataGridTextBoxColumn
        '   With grd
        '      .HeaderText = parm.SourceColumn
        '      .MappingName = parm.SourceColumn
        '   End With
        '   dgStyle.GridColumnStyles.AddRange(New DataGridColumnStyle() {grd})
        'Next
        'grdMain.TableStyles.Add(dgStyle)
        'tbFilter.Enabled = True
        For Each dc As DataColumn In dv.Table.Columns
            'tbcbiField.Items.Add(dc.ColumnName)
        Next
    End Sub
    Private Sub BuildInsertCommand(ByRef dataAdapter As System.Data.SqlClient.SqlDataAdapter, ByVal tableName As String)
        Dim t_dt As DataTable = GetTableColumnInfo(dataAdapter.SelectCommand.Connection, tableName)
        Dim dv As New DataView(t_dt)
        Dim cmd As SqlClient.SqlCommand
        Dim dt As New DataTable
        Dim dca() As DataColumn
        Dim dc As DataColumn
        Dim sFilterFieldnames() As String
        Dim sParamNames() As String
        Dim sSQL As String
        Dim sTmp As String
        Dim sSQLDataType As String
        Dim lPrecision As Byte
        Dim lSize As Integer
        Dim lScale As Byte
        'Get the schema for the table to be read.
        dataAdapter.FillSchema(dt, SchemaType.Source)
        ReDim sFilterFieldnames(dt.Columns.Count - 1)
        ReDim sParamNames(dt.Columns.Count - 1)
        For Each dc In dt.Columns
            'Read & save the column names
            sFilterFieldnames(dc.Ordinal) = dc.ColumnName
            'Read the column names and generate parameter names.
            sParamNames(dc.Ordinal) = "@" + RemoveIllegalChars(dc.ColumnName, m_RemoveChars)
        Next
        'Clean up
        dc.Dispose()
        dca = dt.PrimaryKey()
        'Insert Command ***********************************
        sSQL = "INSERT INTO [" + tableName + "] ("
        '   Fields
        For i As Integer = sFilterFieldnames.GetLowerBound(0) To sFilterFieldnames.GetUpperBound(0)
            sSQL = sSQL & "[" & sFilterFieldnames(i) & "]"
            If i <> sFilterFieldnames.GetUpperBound(0) Then
                sSQL = sSQL + ", "
            Else
                sSQL = sSQL + ")"
            End If
        Next
        '   Parameters
        sSQL = sSQL + " VALUES ("
        For i As Integer = sParamNames.GetLowerBound(0) To sParamNames.GetUpperBound(0)
            sSQL = sSQL + sParamNames(i)
            If i <> sParamNames.GetUpperBound(0) Then
                sSQL = sSQL + ", "
            Else
                sSQL = sSQL + "); "
            End If
        Next
        '   Do a SELECT again
        sSQL = sSQL + "SELECT "
        For i As Integer = sFilterFieldnames.GetLowerBound(0) To sFilterFieldnames.GetUpperBound(0)
            sSQL = sSQL + "[" + sFilterFieldnames(i) + "]"
            If i <> sFilterFieldnames.GetUpperBound(0) Then
                sSQL = sSQL + ", "
            End If
        Next
        sSQL = sSQL + " FROM [" + tableName + "] WHERE ("
        '   WHERE Clause
        If dca.GetLength(0) > 0 Then
            'If the table contains a primary key, use that to find the record.
            For i As Integer = dca.GetLowerBound(0) To dca.GetUpperBound(0)
                dv.RowFilter = "COLUMN_NAME = '" & dca(i).ColumnName & "'"
                sSQLDataType = dv(0)("TYPE_NAME").ToString()
                If sSQLDataType.Equals("text") Or
                   sSQLDataType.Equals("ntext") Or
                   sSQLDataType.Equals("image") Then
                    sTmp = "[" + dca(i).ColumnName + "] LIKE @" + RemoveIllegalChars(dca(i).ColumnName, m_RemoveChars)
                Else
                    sTmp = "[" + dca(i).ColumnName + "] = @" + RemoveIllegalChars(dca(i).ColumnName, m_RemoveChars)
                End If
                If dca.GetLength(0) > 1 Then
                    sSQL = sSQL + "(" + sTmp + ")"
                Else
                    sSQL = sSQL + sTmp
                End If
                If i <> dca.GetUpperBound(0) Then sSQL = sSQL + " AND "
            Next
        Else
            'otherwise use a combination of the fields.
            For i As Integer = sFilterFieldnames.GetLowerBound(0) To sFilterFieldnames.GetUpperBound(0)
                dv.RowFilter = "COLUMN_NAME = '" & sFilterFieldnames(i) & "'"
                Try
                    sSQLDataType = dv(0)("TYPE_NAME").ToString()
                    If sSQLDataType <> Nothing Then
                        If sSQLDataType.Equals("text") Or
                       sSQLDataType.Equals("ntext") Or
                       sSQLDataType.Equals("image") Then
                            sTmp = "[" + sFilterFieldnames(i) + "] LIKE " + sParamNames(i)
                        Else
                            sTmp = "[" + sFilterFieldnames(i) + "] = " + sParamNames(i)
                        End If
                    End If
                Catch ex As Exception
                End Try
                If sFilterFieldnames.GetLength(0) > 1 Then
                    sSQL = sSQL + "(" + sTmp + ")"
                Else
                    sSQL = sSQL + sTmp
                End If
                If i <> sFilterFieldnames.GetUpperBound(0) Then sSQL = sSQL + " AND "
            Next
        End If
        sSQL = sSQL + ")"
        'Create a new command object
        cmd = New SqlClient.SqlCommand(sSQL)
        'Set it's connection from the Select cammand in the DataAdapter
        cmd.Connection = dataAdapter.SelectCommand.Connection()
        '   Add Parameters
        For i As Integer = sFilterFieldnames.GetLowerBound(0) To sFilterFieldnames.GetUpperBound(0)
            dv.RowFilter = "COLUMN_NAME = '" & sFilterFieldnames(i) & "'"
            Try
                sSQLDataType = dv(0)("TYPE_NAME").ToString()
            Catch ex As Exception
            End Try
            Try
                lPrecision = CType(dv(0)("PRECISION").ToString, Byte)
            Catch ex As Exception
                lPrecision = 38
            End Try
            If lPrecision > 38 Then lPrecision = 38
            Try
                lSize = CType(dv(0)("LENGTH").ToString, Integer)
                lScale = CType(IIf(dv(0)("SCALE").ToString.Equals(""), 0, dv(0)("SCALE").ToString), Byte)
            Catch ex As Exception
            End Try
            cmd.Parameters.Add(New SqlClient.SqlParameter(sParamNames(i), GetSQLType(sSQLDataType), lSize, ParameterDirection.Input, dt.Columns(sFilterFieldnames(i)).AllowDBNull, lPrecision, lScale, sFilterFieldnames(i), DataRowVersion.Current, Nothing))
        Next
        'Clean up
        dv.Dispose()
        t_dt.Dispose()
        dt.Dispose()
        'Set the command object
        dataAdapter.InsertCommand = cmd
    End Sub
    Private Sub BuildUpdateCommand(ByRef dataAdapter As System.Data.SqlClient.SqlDataAdapter, ByVal tableName As String)
        Dim t_dt As DataTable = GetTableColumnInfo(dataAdapter.SelectCommand.Connection, tableName)
        Dim dv As New DataView(t_dt)
        Dim cmd As SqlClient.SqlCommand
        Dim dt As New DataTable
        Dim dca() As DataColumn
        Dim dc As DataColumn
        Dim sFilterFieldnames() As String
        Dim sParamNames() As String
        Dim sOrigParamNames() As String
        Dim sSQL As String
        Dim sTmp As String
        Dim sSQLDataType As String
        Dim lPrecision As Byte
        Dim lSize As Integer
        Dim lScale As Byte
        'Get the schema for the table to be read.
        dataAdapter.FillSchema(dt, SchemaType.Source)
        ReDim sFilterFieldnames(dt.Columns.Count - 1)
        ReDim sParamNames(dt.Columns.Count - 1)
        ReDim sOrigParamNames(dt.Columns.Count - 1)
        For Each dc In dt.Columns
            'Read & save the column names
            sFilterFieldnames(dc.Ordinal) = dc.ColumnName
            'Read the column names and generate parameter names.
            sParamNames(dc.Ordinal) = "@" + RemoveIllegalChars(dc.ColumnName, m_RemoveChars)
            'Read the column names and generate Original parameter names.
            sOrigParamNames(dc.Ordinal) = "@Original_" + RemoveIllegalChars(dc.ColumnName, m_RemoveChars)
        Next
        'Clean up
        dc.Dispose()
        dca = dt.PrimaryKey()
        'Update Command ***********************************
        sSQL = "UPDATE [" & tableName & "] SET "
        '   Fields
        For i As Integer = sFilterFieldnames.GetLowerBound(0) To sFilterFieldnames.GetUpperBound(0)
            sSQL = sSQL + "[" + sFilterFieldnames(i) + "] = " + sParamNames(i)
            If i <> sFilterFieldnames.GetUpperBound(0) Then
                sSQL = sSQL + ", "
            Else
                sSQL = sSQL + " "
            End If
        Next
        '   Parameters
        sSQL = sSQL + " WHERE "
        If dca.GetLength(0) > 0 Then
            'If the table contains a primary key, use that to find the record.
            For i As Integer = dca.GetLowerBound(0) To dca.GetUpperBound(0)
                sTmp = "[" + dca(i).ColumnName + "]"
                dv.RowFilter = "COLUMN_NAME = '" & dca(i).ColumnName & "'"
                sSQLDataType = dv(0)("TYPE_NAME").ToString()
                If sSQLDataType.Equals("text") Or
                   sSQLDataType.Equals("ntext") Or
                   sSQLDataType.Equals("image") Then
                    sSQL = sSQL + "(" + sTmp + " LIKE @Original_" + RemoveIllegalChars(dca(i).ColumnName, m_RemoveChars)
                Else
                    sSQL = sSQL + "(" + sTmp + " = @Original_" + RemoveIllegalChars(dca(i).ColumnName, m_RemoveChars)
                End If
                If i <> dca.GetUpperBound(0) Then
                    sSQL = sSQL + " AND "
                Else
                    sSQL = sSQL + "; "
                End If
            Next
        Else
            'otherwise use a combination of the fields.
            For i As Integer = sFilterFieldnames.GetLowerBound(0) To sFilterFieldnames.GetUpperBound(0)
                sTmp = "[" + sFilterFieldnames(i) + "]"
                dv.RowFilter = "COLUMN_NAME = '" & sFilterFieldnames(i) & "'"
                Try
                    sSQLDataType = dv(0)("TYPE_NAME").ToString()
                    If sSQLDataType.Equals("text") Or
                       sSQLDataType.Equals("ntext") Or
                       sSQLDataType.Equals("image") Then
                        If dt.Columns(sFilterFieldnames(i)).AllowDBNull Then
                            sSQL = sSQL + "((" + sTmp + " LIKE " + sOrigParamNames(i) + ") OR (" + sTmp + " IS NULL AND " + sOrigParamNames(i) + " IS NULL))"
                        Else
                            sSQL = sSQL + "(" + sTmp + " LIKE " + sOrigParamNames(i) + ")"
                        End If
                    Else
                        If dt.Columns(sFilterFieldnames(i)).AllowDBNull Then
                            sSQL = sSQL + "((" + sTmp + " = " + sOrigParamNames(i) + ") OR (" + sTmp + " IS NULL AND " + sOrigParamNames(i) + " IS NULL))"
                        Else
                            sSQL = sSQL + "(" + sTmp + " = " + sOrigParamNames(i) + ")"
                        End If
                    End If
                Catch ex As Exception
                End Try
                If i <> sFilterFieldnames.GetUpperBound(0) Then
                    sSQL = sSQL + " AND "
                Else
                    sSQL = sSQL + "; "
                End If
            Next
        End If
        '   Do a SELECT again
        sSQL = sSQL + "SELECT "
        For i As Integer = sFilterFieldnames.GetLowerBound(0) To sFilterFieldnames.GetUpperBound(0)
            sSQL = sSQL + "[" + sFilterFieldnames(i) + "]"
            If i <> sFilterFieldnames.GetUpperBound(0) Then
                sSQL = sSQL + ", "
            End If
        Next
        sSQL = sSQL + " FROM [" + tableName + "] WHERE ("
        '   WHERE Clause
        If dca.GetLength(0) > 0 Then
            'If the table contains a primary key, use that to find the record.
            For i As Integer = dca.GetLowerBound(0) To dca.GetUpperBound(0)
                dv.RowFilter = "COLUMN_NAME = '" & dca(i).ColumnName & "'"
                sSQLDataType = dv(0)("TYPE_NAME").ToString()
                If sSQLDataType.Equals("text") Or
                   sSQLDataType.Equals("ntext") Or
                   sSQLDataType.Equals("image") Then
                    sTmp = "[" + dca(i).ColumnName + "] LIKE @" + RemoveIllegalChars(dca(i).ColumnName, m_RemoveChars)
                Else
                    sTmp = "[" + dca(i).ColumnName + "] = @" + RemoveIllegalChars(dca(i).ColumnName, m_RemoveChars)
                End If
                If dca.GetLength(0) > 1 Then
                    sSQL = sSQL + "(" + sTmp + ")"
                Else
                    sSQL = sSQL + sTmp
                End If
                If i <> dca.GetUpperBound(0) Then sSQL = sSQL + " AND "
            Next
        Else
            'otherwise use a combination of the fields.
            For i As Integer = sFilterFieldnames.GetLowerBound(0) To sFilterFieldnames.GetUpperBound(0)
                dv.RowFilter = "COLUMN_NAME = '" & sFilterFieldnames(i) & "'"
                Try
                    sSQLDataType = dv(0)("TYPE_NAME").ToString()
                    If sSQLDataType.Equals("text") Or
                       sSQLDataType.Equals("ntext") Or
                       sSQLDataType.Equals("image") Then
                        sTmp = "[" + sFilterFieldnames(i) + "] LIKE " + sParamNames(i)
                    Else
                        sTmp = "[" + sFilterFieldnames(i) + "] = " + sParamNames(i)
                    End If
                Catch ex As Exception
                End Try
                If sFilterFieldnames.GetLength(0) > 1 Then
                    sSQL = sSQL + "(" + sTmp + ")"
                Else
                    sSQL = sSQL + sTmp
                End If
                If i <> sFilterFieldnames.GetUpperBound(0) Then sSQL = sSQL + " AND "
            Next
        End If
        sSQL = sSQL + ")"
        'Create a new command object
        cmd = New SqlClient.SqlCommand(sSQL)
        'Set it's connection from the Select cammand in the DataAdapter
        cmd.Connection = dataAdapter.SelectCommand.Connection()
        '   Add Parameters
        For i As Integer = sFilterFieldnames.GetLowerBound(0) To sFilterFieldnames.GetUpperBound(0)
            dv.RowFilter = "COLUMN_NAME = '" & sFilterFieldnames(i) & "'"
            Try
                sSQLDataType = dv(0)("TYPE_NAME").ToString()
            Catch ex As Exception
            End Try
            Try
                lPrecision = CType(dv(0)("PRECISION").ToString, Byte)
            Catch ex As Exception
                lPrecision = 38
            End Try
            If lPrecision > 38 Then lPrecision = 38
            Try
                lSize = CType(dv(0)("LENGTH").ToString, Integer)
                lScale = CType(IIf(dv(0)("SCALE").ToString.Equals(""), 0, dv(0)("SCALE").ToString), Byte)
            Catch ex As Exception
            End Try
            cmd.Parameters.Add(New SqlClient.SqlParameter(sParamNames(i), GetSQLType(sSQLDataType), lSize, ParameterDirection.Input, dt.Columns(sFilterFieldnames(i)).AllowDBNull, lPrecision, lScale, sFilterFieldnames(i), DataRowVersion.Current, Nothing))
            cmd.Parameters.Add(New SqlClient.SqlParameter(sOrigParamNames(i), GetSQLType(sSQLDataType), lSize, ParameterDirection.Input, dt.Columns(sFilterFieldnames(i)).AllowDBNull, lPrecision, lScale, sFilterFieldnames(i), DataRowVersion.Original, Nothing))
        Next
        'Clean up
        dv.Dispose()
        t_dt.Dispose()
        dt.Dispose()
        'Set the command object
        dataAdapter.UpdateCommand = cmd
    End Sub
    Private Sub BuildDeleteCommand(ByRef dataAdapter As System.Data.SqlClient.SqlDataAdapter, ByVal tableName As String)
        Dim t_dt As DataTable = GetTableColumnInfo(dataAdapter.SelectCommand.Connection, tableName)
        Dim dv As New DataView(t_dt)
        Dim cmd As SqlClient.SqlCommand
        Dim dt As New DataTable
        Dim dca() As DataColumn
        Dim dc As DataColumn
        Dim sFilterFieldnames() As String
        Dim sOrigParamNames() As String
        Dim sSQL As String
        Dim sTmp As String
        Dim sSQLDataType As String
        Dim lPrecision As Byte
        Dim lSize As Integer
        Dim lScale As Byte
        'Get the schema for the table to be read.
        dataAdapter.FillSchema(dt, SchemaType.Source)
        ReDim sFilterFieldnames(dt.Columns.Count - 1)
        ReDim sOrigParamNames(dt.Columns.Count - 1)
        For Each dc In dt.Columns
            'Read & save the column names
            sFilterFieldnames(dc.Ordinal) = dc.ColumnName
            'Read the column names and generate Original parameter names.
            sOrigParamNames(dc.Ordinal) = "@Original_" + RemoveIllegalChars(dc.ColumnName, m_RemoveChars)
        Next
        'Clean up
        dc.Dispose()
        dca = dt.PrimaryKey()
        'Delete Command ***********************************
        sSQL = "DELETE FROM [" & tableName & "] WHERE "
        '   Parameters
        If dca.GetLength(0) > 0 Then
            'If the table contains a primary key, use that to find the record.
            For i As Integer = dca.GetLowerBound(0) To dca.GetUpperBound(0)
                sTmp = "[" + dca(i).ColumnName + "]"
                dv.RowFilter = "COLUMN_NAME = '" & dca(i).ColumnName & "'"
                sSQLDataType = dv(0)("TYPE_NAME").ToString()
                If sSQLDataType.Equals("text") Or
                   sSQLDataType.Equals("ntext") Or
                   sSQLDataType.Equals("image") Then
                    sSQL = sSQL + "(" + sTmp + " LIKE @Original_" + RemoveIllegalChars(dca(i).ColumnName, m_RemoveChars) + ")"
                Else
                    sSQL = sSQL + "(" + sTmp + " = @Original_" + RemoveIllegalChars(dca(i).ColumnName, m_RemoveChars) + ")"
                End If
                If i <> dca.GetUpperBound(0) Then
                    sSQL = sSQL + " AND "
                End If
            Next
        Else
            'otherwise use a combination of the fields.
            For i As Integer = sFilterFieldnames.GetLowerBound(0) To sFilterFieldnames.GetUpperBound(0)
                sTmp = "[" + sFilterFieldnames(i) + "]"
                dv.RowFilter = "COLUMN_NAME = '" & sFilterFieldnames(i) & "'"
                Try
                    sSQLDataType = dv(0)("TYPE_NAME").ToString()
                    If sSQLDataType.Equals("text") Or
                       sSQLDataType.Equals("ntext") Or
                       sSQLDataType.Equals("image") Then
                        If dt.Columns(sFilterFieldnames(i)).AllowDBNull Then
                            sSQL = sSQL + "((" + sTmp + " LIKE " + sOrigParamNames(i) + ") OR (" + sTmp + " IS NULL AND " + sOrigParamNames(i) + " IS NULL))"
                        Else
                            sSQL = sSQL + "(" + sTmp + " LIKE " + sOrigParamNames(i) + ")"
                        End If
                    Else
                        If dt.Columns(sFilterFieldnames(i)).AllowDBNull Then
                            sSQL = sSQL + "((" + sTmp + " = " + sOrigParamNames(i) + ") OR (" + sTmp + " IS NULL AND " + sOrigParamNames(i) + " IS NULL))"
                        Else
                            sSQL = sSQL + "(" + sTmp + " = " + sOrigParamNames(i) + ")"
                        End If
                    End If
                Catch ex As Exception
                End Try
                If i <> sFilterFieldnames.GetUpperBound(0) Then
                    sSQL = sSQL + " AND "
                End If
            Next
        End If
        'Create a new command object
        cmd = New SqlClient.SqlCommand(sSQL)
        'Set it's connection from the Select cammand in the DataAdapter
        cmd.Connection = dataAdapter.SelectCommand.Connection()
        '   Add Parameters
        For i As Integer = sFilterFieldnames.GetLowerBound(0) To sFilterFieldnames.GetUpperBound(0)
            dv.RowFilter = "COLUMN_NAME = '" & sFilterFieldnames(i) & "'"
            Try
                sSQLDataType = dv(0)("TYPE_NAME").ToString()
            Catch ex As Exception
            End Try
            Try
                lPrecision = CType(dv(0)("PRECISION").ToString, Byte)
            Catch ex As Exception
                lPrecision = 38
            End Try
            If lPrecision > 38 Then lPrecision = 38
            Try
                lSize = CType(dv(0)("LENGTH").ToString, Integer)
                lScale = CType(IIf(dv(0)("SCALE").ToString.Equals(""), 0, dv(0)("SCALE").ToString), Byte)
            Catch ex As Exception
            End Try
            cmd.Parameters.Add(New SqlClient.SqlParameter(sOrigParamNames(i), GetSQLType(sSQLDataType), lSize, ParameterDirection.Input, dt.Columns(sFilterFieldnames(i)).AllowDBNull, lPrecision, lScale, sFilterFieldnames(i), DataRowVersion.Original, Nothing))
        Next
        'Clean up
        dv.Dispose()
        t_dt.Dispose()
        dt.Dispose()
        'Set the command object
        dataAdapter.DeleteCommand = cmd
    End Sub
    'Returns the SqlDbType from the SQL Data Type name string. The string comes from the
    'GetTableColumnInfo function.
    Private Function GetSQLType(ByVal sSQLTypeName As String) As System.Data.SqlDbType
        If sSQLTypeName <> Nothing Then
            Select Case sSQLTypeName.ToLower()
                Case "bigint"
                    GetSQLType = SqlDbType.BigInt
                Case "binary"
                    GetSQLType = SqlDbType.Binary
                Case "bit"
                    GetSQLType = SqlDbType.Bit
                Case "char"
                    GetSQLType = SqlDbType.Char
                Case "datetime"
                    GetSQLType = SqlDbType.DateTime
                Case "decimal"
                    GetSQLType = SqlDbType.Decimal
                Case "float"
                    GetSQLType = SqlDbType.Float
                Case "image"
                    GetSQLType = SqlDbType.Image
                Case "int"
                    GetSQLType = SqlDbType.Int
                Case "money"
                    GetSQLType = SqlDbType.Money
                Case "nchar"
                    GetSQLType = SqlDbType.NChar
                Case "ntext"
                    GetSQLType = SqlDbType.NText
                Case "nvarchar"
                    GetSQLType = SqlDbType.NVarChar
                Case "real"
                    GetSQLType = SqlDbType.Real
                Case "smalldatetime"
                    GetSQLType = SqlDbType.SmallDateTime
                Case "smallint"
                    GetSQLType = SqlDbType.SmallInt
                Case "smallmoney"
                    GetSQLType = SqlDbType.SmallMoney
                Case "sql_variant"
                    GetSQLType = SqlDbType.Variant
                Case "text"
                    GetSQLType = SqlDbType.Text
                Case "timestamp"
                    GetSQLType = SqlDbType.Timestamp
                Case "tinyint"
                    GetSQLType = SqlDbType.TinyInt
                Case "uniqueidentifier"
                    GetSQLType = SqlDbType.UniqueIdentifier
                Case "varbinary"
                    GetSQLType = SqlDbType.VarBinary
                Case "varchar"
                    GetSQLType = SqlDbType.VarChar
                Case Else
                    GetSQLType = SqlDbType.Variant
            End Select
        End If
    End Function
    'This function gets column related info from the SQL server using the sp_columns stored proc.
    Private Function GetTableColumnInfo(ByRef connection As System.Data.SqlClient.SqlConnection,
                                        ByVal tableName As String) _
                                        As System.Data.DataTable
        Dim t_cmd As New SqlClient.SqlCommand("sp_columns")
        t_cmd.CommandType = CommandType.StoredProcedure
        t_cmd.Connection = connection
        t_cmd.Parameters.Add("@table_name", SqlDbType.NVarChar, 384).Value = tableName
        Dim t_da As New SqlClient.SqlDataAdapter(t_cmd)
        Dim t_dt As New DataTable
        Try
            t_da.Fill(t_dt)
            GetTableColumnInfo = t_dt
        Catch ex As Exception
            GetTableColumnInfo = Nothing
        End Try
        t_cmd.Dispose()
        t_da.Dispose()
    End Function
    Private Function RemoveIllegalChars(ByVal value As String, ByVal chars As String) As String
        Dim i As Integer
        For i = 0 To chars.Length - 1
            value = value.Replace(chars.Substring(i, 1), "")
        Next
        Return value
    End Function
    Private Sub SaveTable()
        If Not m_TableName.Equals("") Then
            If Not m_TableName.Substring(0, 1).Equals("#") Then
                'ToDo: Display the number of rows modified
                'Try
                If Trim(m_TableName) = "UGURLU.dbo.tbParamCari" Then
                    Dim dr As DataRow
                    For Each dr In ds.Tables(0).Rows
                        sorguCalistir("SET DATEFORMAT DMY SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED UPDATE tbParamCari Set nHesapUzunlugu = " & dr(0) & ", nKebirUzunlugu = " & dr(1) & ", nGrupUzunlugu = " & dr(2) & ", nDetayUzunlugu = " & dr(3) & ", dteBaslangicTarih = '" & dr(4) & "', dteBitisTarih = '" & dr(5) & "', bEntegreDegistirilsin = " & Math.Abs(sorgu_sayi(dr(6), 0)) & ", bMuhasebeHesapPlaniAyni = " & Math.Abs(sorgu_sayi(dr(7), 0)) & ", bMuhasebeIleEntegre = " & Math.Abs(sorgu_sayi(dr(8), 0)) & ", sSinifTipi01 = '" & dr(9) & "', sSinifTipi02 = '" & dr(10) & "', sSinifTipi03 = '" & dr(11) & "', sSinifTipi04 = '" & dr(12) & "', sSinifTipi05 = '" & dr(13) & "', sCariDekontFormu1 = '" & dr(14) & "', sCariDekontFormu2 = '" & dr(15) & "', sNakitDekontFormu1 = '" & dr(16) & "', sNakitDekontFormu2 = '" & dr(17) & "', bKrdLimDolanaSevkYapma = " & Math.Abs(sorgu_sayi(dr(18), 0)) & ", sDefaultHareketTipi = '" & dr(19) & "', bDovizliGirisVar = " & Math.Abs(sorgu_sayi(dr(20), 0)) & ", bEkSoru1 = " & Math.Abs(sorgu_sayi(dr(21), 0)) & ", bEkSoru2 = " & Math.Abs(sorgu_sayi(dr(22), 0)) & ", nParametre1 = " & dr(23) & ", nParametre2 = " & dr(24) & ", bAciklamaZorunlumu = " & Math.Abs(sorgu_sayi(dr(25), 0)) & ", bAdres1Zorunlumu = " & Math.Abs(sorgu_sayi(dr(26), 0)) & ", bAdres2Zorunlumu = " & Math.Abs(sorgu_sayi(dr(27), 0)) & ", bSemtZorunlumu = " & Math.Abs(sorgu_sayi(dr(28), 0)) & ", bPostaKoduZorunlumu = " & Math.Abs(sorgu_sayi(dr(29), 0)) & ", bIlZorunlumu = " & Math.Abs(sorgu_sayi(dr(30), 0)) & ", bUlkeZorunlumu = " & Math.Abs(sorgu_sayi(dr(31), 0)) & ", bDepoZorunlumu = " & Math.Abs(sorgu_sayi(dr(32), 0)) & ", bVergiDairesiZorunlumu = " & Math.Abs(sorgu_sayi(dr(33), 0)) & ", bVergiNoZorunlumu = " & Math.Abs(sorgu_sayi(dr(34), 0)) & ", bOzelNotZorunlumu = " & Math.Abs(sorgu_sayi(dr(35), 0)) & ", bSaticiZorunlumu = " & Math.Abs(sorgu_sayi(dr(36), 0)) & ", bYetkiliZorunlumu = " & Math.Abs(sorgu_sayi(dr(37), 0)) & ", bIletisimZorunlumu = " & Math.Abs(sorgu_sayi(dr(38), 0)) & ", bSinifKodu1Zorunlumu = " & Math.Abs(sorgu_sayi(dr(39), 0)) & ", bSinifKodu2Zorunlumu = " & Math.Abs(sorgu_sayi(dr(40), 0)) & ", bSinifKodu3Zorunlumu = " & Math.Abs(sorgu_sayi(dr(41), 0)) & ", bSinifKodu4Zorunlumu = " & Math.Abs(sorgu_sayi(dr(42), 0)) & ", bSinifKodu5Zorunlumu = " & Math.Abs(sorgu_sayi(dr(43), 0)) & ", bCariTCZorunlumu = " & Math.Abs(sorgu_sayi(dr(44), 0)) & " ")
                    Next
                Else
                    da.Update(ds.Tables(m_TableName))
                End If
                '
                'Catch ex As Exception
                '    HandledExceptionManager.ShowDialog("An error has occured while updating the database.", _
                '                                       "None of the changes made will be saved to the database.", _
                '                                       "Select OK to continue.", _
                '                                       ex, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                'End Try
            End If
        End If
    End Sub
    Private Sub grdMain_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles grdMain.KeyDown
        If e.KeyCode = Keys.Delete Then
            'If XtraMessageBox.Show(Sorgu_sDil("Satýrý Silmek Ýstediðinize Emin misiniz...?",sDil), MessageBoxButtons.YesNo, MessageBoxIcon.Question, sorgu_sDil("Dikkat",sDil)) = MsgBoxResult.Yes Then
            '    GridView1.DeleteSelectedRows()
            '    grdMain.Update()
            '    SaveTable()
            'End If
        ElseIf e.KeyCode = Keys.Escape Then
            If XtraMessageBox.Show(Sorgu_sDil("Editör Ekranýný Kapatmak Ýstediðinize Emin misiniz...?", sDil), Sorgu_sDil("Dikkat", sDil), MessageBoxButtons.YesNo, MessageBoxIcon.Question) = MsgBoxResult.Yes Then
                grdMain.Update()
                SaveTable()
                Me.Close()
            End If
        End If
    End Sub
    Private Sub GridView1_CellValueChanged(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs) Handles GridView1.CellValueChanged
        GridView1.BestFitColumns()
    End Sub
    Private Sub GridView1_CustomDrawRowIndicator(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Grid.RowIndicatorCustomDrawEventArgs) Handles GridView1.CustomDrawRowIndicator
        If e.RowHandle >= 0 Then
            e.Info.DisplayText = e.RowHandle + 1
        Else
            e.Info.DisplayText = ""
        End If
    End Sub
    Private Sub GridView1_FocusedRowChanged(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs) Handles GridView1.FocusedRowChanged
        If status = False Then
            SaveTable()
        End If
    End Sub
    Private Sub GridView1_SelectionChanged(ByVal sender As Object, ByVal e As DevExpress.Data.SelectionChangedEventArgs) Handles GridView1.SelectionChanged
        If GridView1.SelectedRowsCount > 1 Then
            Label2.Text = Sorgu_sDil("Kayýt Sayýsý :", sDil) & GridView1.RowCount - 1 & " / " & Sorgu_sDil("Satýr :", sDil) & GridView1.FocusedRowHandle + 1 & " / " & Sorgu_sDil("Seçili :", sDil) & GridView1.SelectedRowsCount
        ElseIf GridView1.SelectedRowsCount = 1 Then
            Label2.Text = Sorgu_sDil("Kayýt Sayýsý :", sDil) & GridView1.RowCount - 1 & " / " & Sorgu_sDil("Satýr :", sDil) & GridView1.FocusedRowHandle + 1
        Else
            Label2.Text = ""
        End If
    End Sub
    Private Sub GörünümüYazdýrToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GörünümüYazdýrToolStripMenuItem.Click
        gorunum_yazdir()
    End Sub
    Private Sub gorunum_yazdir()
        printlink1.CreateDocument(ps)
        ps.PreviewRibbonFormEx.Show()
    End Sub
    Private Sub raporla_excel()
        If XtraMessageBox.Show(Sorgu_sDil("Sonuçlarý Excel Dosyasý Oluþturmak Ýstediðinize Emin misiniz...?", sDil), Sorgu_sDil("Dikkat", sDil), MessageBoxButtons.YesNo, MessageBoxIcon.Question) = MsgBoxResult.Yes Then
            Dim SaveFileDialog1 As New Windows.Forms.SaveFileDialog
            SaveFileDialog1.Filter = "Excel Dosyalarý(*.xls) |*.xls"
            SaveFileDialog1.InitialDirectory = "c:\"
            SaveFileDialog1.FileName = "Ekstre.xls"
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
            SaveFileDialog1.FileName = "Ekstre.txt"
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
            SaveFileDialog1.FileName = "Ekstre.pdf"
            If SaveFileDialog1.ShowDialog = Windows.Forms.DialogResult.OK Then
                GridView1.ExportToPdf(SaveFileDialog1.FileName.ToString)
                If XtraMessageBox.Show(Sorgu_sDil("Kaydý Açmak Ýster misiniz...?", sDil), Sorgu_sDil("Dikkat", sDil), MessageBoxButtons.YesNo, MessageBoxIcon.Question) = MsgBoxResult.Yes Then
                    Process.Start(SaveFileDialog1.FileName.ToString)
                End If
            End If
            SaveFileDialog1 = Nothing
        End If
    End Sub
    Private Sub SilToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SilToolStripMenuItem.Click
        If XtraMessageBox.Show(Sorgu_sDil("Satýrý Silmek Ýstediðinize Emin misiniz...?", sDil), Sorgu_sDil("Dikkat", sDil), MessageBoxButtons.YesNo, MessageBoxIcon.Question) = MsgBoxResult.Yes Then
            GridView1.DeleteSelectedRows()
            grdMain.Update()
            SaveTable()
        End If
    End Sub
    Private Sub MenuItem10_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem10.Click
        If Me.WindowState = FormWindowState.Normal Then
            Me.WindowState = FormWindowState.Maximized
        ElseIf Me.WindowState = FormWindowState.Maximized Then
            Me.WindowState = FormWindowState.Normal
        End If
    End Sub
    Private Sub GörünümüDüzenleToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GörünümüDüzenleToolStripMenuItem.Click
        GridView1.ColumnsCustomization()
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
    Private Sub MenuItem6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem6.Click
        If MenuItem6.Checked = False Then
            GridView1.OptionsCustomization.AllowFilter = True
            GridView1.OptionsView.ShowFilterPanelMode = DevExpress.XtraGrid.Views.Base.ShowFilterPanelMode.Default
            MenuItem6.Checked = True
        ElseIf MenuItem6.Checked = True Then
            GridView1.OptionsCustomization.AllowFilter = False
            GridView1.OptionsView.ShowFilterPanelMode = DevExpress.XtraGrid.Views.Base.ShowFilterPanelMode.Never
            MenuItem6.Checked = False
        End If
    End Sub
    Private Sub MenuItem7_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles MenuItem7.Click
        If MenuItem7.Checked = False Then
            GridView1.OptionsCustomization.AllowGroup = True
            GridView1.OptionsView.ShowGroupPanel = True
            MenuItem7.Checked = True
        ElseIf MenuItem7.Checked = True Then
            GridView1.OptionsCustomization.AllowGroup = False
            GridView1.OptionsView.ShowGroupPanel = False
            MenuItem7.Checked = False
        End If
    End Sub
    Private Sub MenuItem8_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles MenuItem8.Click
        GridView1.ExpandAllGroups()
    End Sub
    Private Sub MenuItem9_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles MenuItem9.Click
    End Sub
    Private Sub SimpleButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SimpleButton1.Click
        Me.Close()
    End Sub
    Private Sub SimpleButton2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SimpleButton2.Click
        Me.Close()
    End Sub
    Private Sub BarButtonItem1_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem1.ItemClick
        gorunum_yazdir()
    End Sub
    Private Sub BarButtonItem2_ItemClick(ByVal sender As Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem2.ItemClick
        raporla_excel()
    End Sub
    Private Sub BarButtonItem3_ItemClick(ByVal sender As Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem3.ItemClick
        raporla_text()
    End Sub
    Private Sub BarButtonItem4_ItemClick(ByVal sender As Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem4.ItemClick
        raporla_pdf()
    End Sub
    Private Sub SimpleButton4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SimpleButton4.Click
        Group_Toplu.Visible = False
    End Sub
    Private Sub BarButtonItem5_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btn_AltTopluEkle.ItemClick
        Group_Toplu.Visible = True
        txt_sOdemeSekli.Focus()
        txt_sOdemeSekli.SelectAll()
    End Sub
    Private Sub SimpleButton3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SimpleButton3.Click
        tbOdemeSekli_Ekle_Toplu()
        Group_Toplu.Visible = False
        dataload()
        grdMain.Focus()
        grdMain.Select()
    End Sub
    Private Sub tbOdemeSekli_Ekle_Toplu()
        If XtraMessageBox.Show(Sorgu_sDil("Ödeme Þekillerini Toplu Olarak Atamak Ýstediðinize Emin misiniz...?", sDil), Sorgu_sDil("Dikkat", sDil), MessageBoxButtons.YesNo, MessageBoxIcon.Question) = MsgBoxResult.Yes Then
            Dim i As Integer = 0
            Dim sOdemeSekli As String = ""
            Dim sAciklama As String = ""
            Dim nOdemeTipi As Integer = 2
            For i = 1 To txt_nTaksitSayisi.EditValue
                sOdemeSekli = txt_sOdemeSekli.Text
                sOdemeSekli += i.ToString
                sAciklama = txt_sAciklama.Text
                sAciklama += " " & i & " Taksit"
                tbOdemeSekli_kaydet_yeni(sOdemeSekli, sAciklama, nOdemeTipi)
            Next
            If sec_bVisa.Checked = True Then
                sOdemeSekli = txt_sOdemeSekli.Text
                sOdemeSekli += "V"
                sAciklama = txt_sAciklama.Text
                sAciklama += " Visa"
                tbOdemeSekli_kaydet_yeni(sOdemeSekli, sAciklama, nOdemeTipi)
            End If
            If sec_bPuan.Checked = True Then
                sOdemeSekli = txt_sOdemeSekli.Text
                sOdemeSekli += "P"
                sAciklama = txt_sAciklama.Text
                sAciklama += " Puan"
                tbOdemeSekli_kaydet_yeni(sOdemeSekli, sAciklama, nOdemeTipi)
            End If
            If sec_bYabanci.Checked = True Then
                sOdemeSekli = txt_sOdemeSekli.Text
                sOdemeSekli += "Y"
                sAciklama = txt_sAciklama.Text
                sAciklama += " Yabancý Kart"
                tbOdemeSekli_kaydet_yeni(sOdemeSekli, sAciklama, nOdemeTipi)
            End If
        End If
    End Sub
    Private Sub tbOdemeSekli_kaydet_yeni(ByVal sOdemeSekli As String, ByVal sAciklama As String, ByVal nOdemeTipi As Integer)
        Dim cmd = New SqlClient.SqlCommand
        Dim con As New SqlClient.SqlConnection
        cmd.Connection = con
        con.ConnectionString = connection
        cmd.CommandTimeout = Nothing
        If con.State = ConnectionState.Closed = True Then
            con.Open()
        End If
        cmd.CommandText = sorgu_query("SET DATEFORMAT DMY SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED INSERT INTO tbOdemeSekli (sOdemeSekli, sAciklama, nOdemeTipi) VALUES     ('" & sOdemeSekli & "', N'" & sAciklama & "', '" & nOdemeTipi & "')")
        Try
            cmd.ExecuteNonQuery()
        Catch ex As Exception
        End Try
        con.Close()
    End Sub
    Private Sub TopluEkleToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TopluEkleToolStripMenuItem.Click
        Group_Toplu.Visible = True
        txt_sOdemeSekli.Focus()
        txt_sOdemeSekli.SelectAll()
    End Sub
    Private Sub SimpleButton5_Click(sender As System.Object, e As System.EventArgs) Handles SimpleButton5.Click
        sqlSorguTableEditor = "set dateformat dmy SELECT * FROM (SELECT tbMusteri.lKodu as lKodu, tbStokFisiDetayi.dteFisTarihi as dteFisTarihi, tbMusteri.sAdi as sAdi, tbMusteri.sSoyadi as sSoyadi, tbStokFisiDetayi.nIslemID as nIslemID, tbStok.sKodu as sKodu, tbStok.sAciklama as sAciklama, tbAlisverisSiparis.nSiparisID as nSiparisID FROM tbStokFisiDetayi INNER JOIN tbMusteri ON tbStokFisiDetayi.nMusteriID = tbMusteri.nMusteriID INNER JOIN tbStok ON tbStokFisiDetayi.nStokID = tbStok.nStokID LEFT OUTER JOIN tbAlisverisSiparis ON tbStokFisiDetayi.nIslemID = tbAlisverisSiparis.nStokIslemID WHERE (tbStokFisiDetayi.sFisTipi = 'PF')) tbTeslimatlar WHERE (nSiparisID IS NULL) AND (dteFisTarihi between '" & tarihSec1.EditValue & "' and '" & tarihSec2.EditValue & "') ORDER BY dteFisTarihi, lKodu, sKodu"
        dataload()
    End Sub
End Class