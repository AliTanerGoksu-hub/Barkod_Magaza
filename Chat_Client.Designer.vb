<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Chat_Client
    Inherits DevExpress.XtraEditors.XtraForm
    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub
    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer
    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim StyleFormatCondition1 As DevExpress.XtraGrid.StyleFormatCondition = New DevExpress.XtraGrid.StyleFormatCondition
        Dim StyleFormatCondition2 As DevExpress.XtraGrid.StyleFormatCondition = New DevExpress.XtraGrid.StyleFormatCondition
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Chat_Client))
        Me.colbGelen = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.GridControl1 = New DevExpress.XtraGrid.GridControl
        Me.ds_tbMessage = New System.Data.DataSet
        Me.DataTable1 = New System.Data.DataTable
        Me.DataColumn1 = New System.Data.DataColumn
        Me.DataColumn2 = New System.Data.DataColumn
        Me.DataColumn3 = New System.Data.DataColumn
        Me.DataColumn4 = New System.Data.DataColumn
        Me.DataColumn5 = New System.Data.DataColumn
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.coldteTarih = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colnBoyut = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colsString = New DevExpress.XtraGrid.Columns.GridColumn
        Me.RepositoryItemMemoEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemMemoEdit
        Me.colsKimden = New DevExpress.XtraGrid.Columns.GridColumn
        Me.RepositoryItemRichTextEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemRichTextEdit
        Me.GridView2 = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.txtClientLog = New System.Windows.Forms.TextBox
        Me.cmdClientConnect = New DevExpress.XtraEditors.SimpleButton
        Me.txtClientSend = New System.Windows.Forms.TextBox
        Me.cmdClientClose = New DevExpress.XtraEditors.SimpleButton
        Me.cmdClientSendFile = New DevExpress.XtraEditors.SimpleButton
        Me.cmdClientSend = New DevExpress.XtraEditors.SimpleButton
        Me.lblClientState = New DevExpress.XtraEditors.LabelControl
        Me.pbClient = New System.Windows.Forms.ProgressBar
        Me.wskClient = New Winsock2007.Winsock
        Me.dlgOpen = New System.Windows.Forms.OpenFileDialog
        Me.dlgSave = New System.Windows.Forms.SaveFileDialog
        Me.GroupBox2.SuspendLayout()
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ds_tbMessage, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataTable1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemMemoEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemRichTextEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'colbGelen
        '
        Me.colbGelen.Caption = "Geldi"
        Me.colbGelen.FieldName = "bGelen"
        Me.colbGelen.Name = "colbGelen"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.GridControl1)
        Me.GroupBox2.Controls.Add(Me.txtClientLog)
        Me.GroupBox2.Controls.Add(Me.cmdClientConnect)
        Me.GroupBox2.Controls.Add(Me.txtClientSend)
        Me.GroupBox2.Controls.Add(Me.cmdClientClose)
        Me.GroupBox2.Controls.Add(Me.cmdClientSendFile)
        Me.GroupBox2.Controls.Add(Me.cmdClientSend)
        Me.GroupBox2.Controls.Add(Me.lblClientState)
        Me.GroupBox2.Controls.Add(Me.pbClient)
        Me.GroupBox2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupBox2.Location = New System.Drawing.Point(0, 0)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(317, 467)
        Me.GroupBox2.TabIndex = 2
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Client (wskClient)"
        '
        'GridControl1
        '
        Me.GridControl1.DataMember = "Table1"
        Me.GridControl1.DataSource = Me.ds_tbMessage
        Me.GridControl1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.GridControl1.Location = New System.Drawing.Point(3, 163)
        Me.GridControl1.MainView = Me.GridView1
        Me.GridControl1.Name = "GridControl1"
        Me.GridControl1.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.RepositoryItemMemoEdit1, Me.RepositoryItemRichTextEdit1})
        Me.GridControl1.Size = New System.Drawing.Size(311, 287)
        Me.GridControl1.TabIndex = 17
        Me.GridControl1.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView1, Me.GridView2})
        '
        'ds_tbMessage
        '
        Me.ds_tbMessage.DataSetName = "NewDataSet"
        Me.ds_tbMessage.Tables.AddRange(New System.Data.DataTable() {Me.DataTable1})
        '
        'DataTable1
        '
        Me.DataTable1.Columns.AddRange(New System.Data.DataColumn() {Me.DataColumn1, Me.DataColumn2, Me.DataColumn3, Me.DataColumn4, Me.DataColumn5})
        Me.DataTable1.TableName = "Table1"
        '
        'DataColumn1
        '
        Me.DataColumn1.ColumnName = "bGelen"
        Me.DataColumn1.DataType = GetType(Boolean)
        '
        'DataColumn2
        '
        Me.DataColumn2.ColumnName = "dteTarih"
        Me.DataColumn2.DataType = GetType(Date)
        '
        'DataColumn3
        '
        Me.DataColumn3.ColumnName = "nBoyut"
        '
        'DataColumn4
        '
        Me.DataColumn4.ColumnName = "sString"
        '
        'DataColumn5
        '
        Me.DataColumn5.ColumnName = "sKimden"
        '
        'GridView1
        '
        Me.GridView1.Appearance.Empty.BackColor = System.Drawing.Color.Transparent
        Me.GridView1.Appearance.Empty.Options.UseBackColor = True
        Me.GridView1.Appearance.FocusedRow.BackColor = System.Drawing.Color.Transparent
        Me.GridView1.Appearance.FocusedRow.Options.UseBackColor = True
        Me.GridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colbGelen, Me.coldteTarih, Me.colnBoyut, Me.colsString, Me.colsKimden})
        StyleFormatCondition1.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        StyleFormatCondition1.Appearance.Options.HighPriority = True
        StyleFormatCondition1.Appearance.Options.UseBackColor = True
        StyleFormatCondition1.Appearance.Options.UseTextOptions = True
        StyleFormatCondition1.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        StyleFormatCondition1.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        StyleFormatCondition1.ApplyToRow = True
        StyleFormatCondition1.Column = Me.colbGelen
        StyleFormatCondition1.Condition = DevExpress.XtraGrid.FormatConditionEnum.Equal
        StyleFormatCondition1.Value1 = False
        StyleFormatCondition2.Appearance.BackColor = System.Drawing.Color.LightGray
        StyleFormatCondition2.Appearance.Options.UseBackColor = True
        StyleFormatCondition2.ApplyToRow = True
        StyleFormatCondition2.Column = Me.colbGelen
        StyleFormatCondition2.Condition = DevExpress.XtraGrid.FormatConditionEnum.Equal
        StyleFormatCondition2.Value1 = "True"
        Me.GridView1.FormatConditions.AddRange(New DevExpress.XtraGrid.StyleFormatCondition() {StyleFormatCondition1, StyleFormatCondition2})
        Me.GridView1.GridControl = Me.GridControl1
        Me.GridView1.Name = "GridView1"
        Me.GridView1.OptionsBehavior.Editable = False
        Me.GridView1.OptionsBehavior.EditorShowMode = DevExpress.Utils.EditorShowMode.Click
        Me.GridView1.OptionsCustomization.AllowFilter = False
        Me.GridView1.OptionsCustomization.AllowGroup = False
        Me.GridView1.OptionsCustomization.AllowSort = False
        Me.GridView1.OptionsNavigation.AutoFocusNewRow = True
        Me.GridView1.OptionsNavigation.EnterMoveNextColumn = True
        Me.GridView1.OptionsView.AutoCalcPreviewLineCount = True
        Me.GridView1.OptionsView.RowAutoHeight = True
        Me.GridView1.OptionsView.ShowFilterPanelMode = DevExpress.XtraGrid.Views.Base.ShowFilterPanelMode.Never
        Me.GridView1.OptionsView.ShowGroupPanel = False
        Me.GridView1.OptionsView.ShowHorizontalLines = DevExpress.Utils.DefaultBoolean.[False]
        Me.GridView1.OptionsView.ShowVerticalLines = DevExpress.Utils.DefaultBoolean.[False]
        '
        'coldteTarih
        '
        Me.coldteTarih.Caption = "Tarih"
        Me.coldteTarih.DisplayFormat.FormatString = "dd/MM/yy HH:mm:ss"
        Me.coldteTarih.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.coldteTarih.FieldName = "dteTarih"
        Me.coldteTarih.Name = "coldteTarih"
        Me.coldteTarih.Width = 468
        '
        'colnBoyut
        '
        Me.colnBoyut.Caption = "Boyut"
        Me.colnBoyut.FieldName = "nBoyut"
        Me.colnBoyut.Name = "colnBoyut"
        '
        'colsString
        '
        Me.colsString.Caption = "Mesaj"
        Me.colsString.ColumnEdit = Me.RepositoryItemMemoEdit1
        Me.colsString.FieldName = "sString"
        Me.colsString.Name = "colsString"
        Me.colsString.Visible = True
        Me.colsString.VisibleIndex = 0
        Me.colsString.Width = 1252
        '
        'RepositoryItemMemoEdit1
        '
        Me.RepositoryItemMemoEdit1.Name = "RepositoryItemMemoEdit1"
        '
        'colsKimden
        '
        Me.colsKimden.Caption = "Kimden"
        Me.colsKimden.FieldName = "sKimden"
        Me.colsKimden.Name = "colsKimden"
        Me.colsKimden.Width = 802
        '
        'RepositoryItemRichTextEdit1
        '
        Me.RepositoryItemRichTextEdit1.Name = "RepositoryItemRichTextEdit1"
        Me.RepositoryItemRichTextEdit1.ShowCaretInReadOnly = False
        '
        'GridView2
        '
        Me.GridView2.GridControl = Me.GridControl1
        Me.GridView2.Name = "GridView2"
        '
        'txtClientLog
        '
        Me.txtClientLog.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtClientLog.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtClientLog.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtClientLog.ForeColor = System.Drawing.Color.Navy
        Me.txtClientLog.Location = New System.Drawing.Point(6, 115)
        Me.txtClientLog.Multiline = True
        Me.txtClientLog.Name = "txtClientLog"
        Me.txtClientLog.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtClientLog.Size = New System.Drawing.Size(305, 42)
        Me.txtClientLog.TabIndex = 15
        '
        'cmdClientConnect
        '
        Me.cmdClientConnect.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmdClientConnect.Location = New System.Drawing.Point(230, 19)
        Me.cmdClientConnect.Name = "cmdClientConnect"
        Me.cmdClientConnect.Size = New System.Drawing.Size(75, 20)
        Me.cmdClientConnect.TabIndex = 14
        Me.cmdClientConnect.Text = "Baðlan"
        '
        'txtClientSend
        '
        Me.txtClientSend.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtClientSend.Location = New System.Drawing.Point(6, 62)
        Me.txtClientSend.Multiline = True
        Me.txtClientSend.Name = "txtClientSend"
        Me.txtClientSend.Size = New System.Drawing.Size(210, 47)
        Me.txtClientSend.TabIndex = 13
        '
        'cmdClientClose
        '
        Me.cmdClientClose.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmdClientClose.Location = New System.Drawing.Point(155, 19)
        Me.cmdClientClose.Name = "cmdClientClose"
        Me.cmdClientClose.Size = New System.Drawing.Size(75, 20)
        Me.cmdClientClose.TabIndex = 12
        Me.cmdClientClose.Text = "Kapat"
        Me.cmdClientClose.Visible = False
        '
        'cmdClientSendFile
        '
        Me.cmdClientSendFile.Location = New System.Drawing.Point(223, 85)
        Me.cmdClientSendFile.Name = "cmdClientSendFile"
        Me.cmdClientSendFile.Size = New System.Drawing.Size(89, 18)
        Me.cmdClientSendFile.TabIndex = 11
        Me.cmdClientSendFile.Text = "&Dosya Gönder"
        '
        'cmdClientSend
        '
        Me.cmdClientSend.Location = New System.Drawing.Point(223, 62)
        Me.cmdClientSend.Name = "cmdClientSend"
        Me.cmdClientSend.Size = New System.Drawing.Size(89, 18)
        Me.cmdClientSend.TabIndex = 10
        Me.cmdClientSend.Text = "&Mesaj Gönder"
        '
        'lblClientState
        '
        Me.lblClientState.Location = New System.Drawing.Point(6, 24)
        Me.lblClientState.Name = "lblClientState"
        Me.lblClientState.Size = New System.Drawing.Size(117, 13)
        Me.lblClientState.TabIndex = 0
        Me.lblClientState.Text = "Baðlantý Durumu: Closed"
        '
        'pbClient
        '
        Me.pbClient.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.pbClient.Location = New System.Drawing.Point(3, 450)
        Me.pbClient.Name = "pbClient"
        Me.pbClient.Size = New System.Drawing.Size(311, 14)
        Me.pbClient.TabIndex = 16
        '
        'wskClient
        '
        Me.wskClient.BufferSize = 8192
        Me.wskClient.LegacySupport = False
        Me.wskClient.LocalPort = 8080
        Me.wskClient.MaxPendingConnections = 1
        Me.wskClient.Protocol = Winsock2007.WinsockProtocols.Tcp
        Me.wskClient.RemoteHost = "localhost"
        Me.wskClient.RemotePort = 8080
        '
        'Chat_Client
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(317, 467)
        Me.Controls.Add(Me.GroupBox2)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "Chat_Client"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Chat Ýstemci"
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ds_tbMessage, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataTable1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemMemoEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemRichTextEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
    End Sub
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents pbClient As System.Windows.Forms.ProgressBar
    Friend WithEvents txtClientLog As System.Windows.Forms.TextBox
    Friend WithEvents cmdClientConnect As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents txtClientSend As System.Windows.Forms.TextBox
    Friend WithEvents cmdClientClose As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cmdClientSendFile As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cmdClientSend As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents lblClientState As DevExpress.XtraEditors.LabelControl
    Friend WithEvents wskClient As Winsock2007.Winsock
    Friend WithEvents wskListen As Winsock2007.Winsock
    Friend WithEvents wskServer As Winsock2007.Winsock
    Friend WithEvents dlgOpen As System.Windows.Forms.OpenFileDialog
    Friend WithEvents dlgSave As System.Windows.Forms.SaveFileDialog
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents GridControl1 As DevExpress.XtraGrid.GridControl
    Friend WithEvents ds_tbMessage As System.Data.DataSet
    Friend WithEvents DataTable1 As System.Data.DataTable
    Friend WithEvents DataColumn1 As System.Data.DataColumn
    Friend WithEvents DataColumn2 As System.Data.DataColumn
    Friend WithEvents DataColumn3 As System.Data.DataColumn
    Friend WithEvents DataColumn4 As System.Data.DataColumn
    Friend WithEvents DataColumn5 As System.Data.DataColumn
    Friend WithEvents GridView2 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents RepositoryItemMemoEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemMemoEdit
    Friend WithEvents RepositoryItemRichTextEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemRichTextEdit
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colbGelen As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents coldteTarih As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colnBoyut As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colsString As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colsKimden As DevExpress.XtraGrid.Columns.GridColumn
End Class
