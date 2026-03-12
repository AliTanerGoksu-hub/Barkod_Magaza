<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Chat_Server
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Chat_Server))
        Me.colbGelen = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
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
        Me.pbServer = New System.Windows.Forms.ProgressBar
        Me.txtServerLog = New System.Windows.Forms.TextBox
        Me.txtServerSend = New System.Windows.Forms.TextBox
        Me.cmdServerClose = New DevExpress.XtraEditors.SimpleButton
        Me.cmdServerSendFile = New DevExpress.XtraEditors.SimpleButton
        Me.cmdServerSend = New DevExpress.XtraEditors.SimpleButton
        Me.GroupBox3 = New System.Windows.Forms.GroupBox
        Me.cmdListenerClose = New DevExpress.XtraEditors.SimpleButton
        Me.cmdListenerListen = New DevExpress.XtraEditors.SimpleButton
        Me.lblLSState = New DevExpress.XtraEditors.LabelControl
        Me.lblServerState = New DevExpress.XtraEditors.LabelControl
        Me.wskServer = New Winsock2007.Winsock
        Me.dlgSave = New System.Windows.Forms.SaveFileDialog
        Me.dlgOpen = New System.Windows.Forms.OpenFileDialog
        Me.wskListen = New Winsock2007.Winsock
        Me.GroupBox1.SuspendLayout()
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ds_tbMessage, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataTable1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemMemoEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemRichTextEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox3.SuspendLayout()
        Me.SuspendLayout()
        '
        'colbGelen
        '
        Me.colbGelen.Caption = "Geldi"
        Me.colbGelen.FieldName = "bGelen"
        Me.colbGelen.Name = "colbGelen"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.GridControl1)
        Me.GroupBox1.Controls.Add(Me.pbServer)
        Me.GroupBox1.Controls.Add(Me.txtServerLog)
        Me.GroupBox1.Controls.Add(Me.txtServerSend)
        Me.GroupBox1.Controls.Add(Me.cmdServerClose)
        Me.GroupBox1.Controls.Add(Me.cmdServerSendFile)
        Me.GroupBox1.Controls.Add(Me.cmdServerSend)
        Me.GroupBox1.Controls.Add(Me.GroupBox3)
        Me.GroupBox1.Controls.Add(Me.lblServerState)
        Me.GroupBox1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupBox1.Location = New System.Drawing.Point(0, 0)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(317, 467)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Server (wskServer)"
        '
        'GridControl1
        '
        Me.GridControl1.DataMember = "Table1"
        Me.GridControl1.DataSource = Me.ds_tbMessage
        Me.GridControl1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.GridControl1.Location = New System.Drawing.Point(3, 174)
        Me.GridControl1.MainView = Me.GridView1
        Me.GridControl1.Name = "GridControl1"
        Me.GridControl1.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.RepositoryItemMemoEdit1, Me.RepositoryItemRichTextEdit1})
        Me.GridControl1.Size = New System.Drawing.Size(311, 276)
        Me.GridControl1.TabIndex = 18
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
        'pbServer
        '
        Me.pbServer.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.pbServer.Location = New System.Drawing.Point(3, 450)
        Me.pbServer.Name = "pbServer"
        Me.pbServer.Size = New System.Drawing.Size(311, 14)
        Me.pbServer.TabIndex = 10
        '
        'txtServerLog
        '
        Me.txtServerLog.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtServerLog.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtServerLog.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.txtServerLog.ForeColor = System.Drawing.Color.Navy
        Me.txtServerLog.Location = New System.Drawing.Point(6, 126)
        Me.txtServerLog.Multiline = True
        Me.txtServerLog.Name = "txtServerLog"
        Me.txtServerLog.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtServerLog.Size = New System.Drawing.Size(305, 42)
        Me.txtServerLog.TabIndex = 9
        Me.txtServerLog.UseWaitCursor = True
        '
        'txtServerSend
        '
        Me.txtServerSend.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtServerSend.Location = New System.Drawing.Point(6, 73)
        Me.txtServerSend.Multiline = True
        Me.txtServerSend.Name = "txtServerSend"
        Me.txtServerSend.Size = New System.Drawing.Size(213, 47)
        Me.txtServerSend.TabIndex = 8
        '
        'cmdServerClose
        '
        Me.cmdServerClose.Location = New System.Drawing.Point(6, 39)
        Me.cmdServerClose.Name = "cmdServerClose"
        Me.cmdServerClose.Size = New System.Drawing.Size(75, 20)
        Me.cmdServerClose.TabIndex = 7
        Me.cmdServerClose.Text = "Kapat"
        Me.cmdServerClose.Visible = False
        '
        'cmdServerSendFile
        '
        Me.cmdServerSendFile.Location = New System.Drawing.Point(223, 96)
        Me.cmdServerSendFile.Name = "cmdServerSendFile"
        Me.cmdServerSendFile.Size = New System.Drawing.Size(86, 20)
        Me.cmdServerSendFile.TabIndex = 6
        Me.cmdServerSendFile.Text = "Dosya Gönder"
        '
        'cmdServerSend
        '
        Me.cmdServerSend.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmdServerSend.Location = New System.Drawing.Point(225, 73)
        Me.cmdServerSend.Name = "cmdServerSend"
        Me.cmdServerSend.Size = New System.Drawing.Size(86, 20)
        Me.cmdServerSend.TabIndex = 5
        Me.cmdServerSend.Text = "Mesaj Gönder"
        '
        'GroupBox3
        '
        Me.GroupBox3.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox3.Controls.Add(Me.cmdListenerClose)
        Me.GroupBox3.Controls.Add(Me.cmdListenerListen)
        Me.GroupBox3.Controls.Add(Me.lblLSState)
        Me.GroupBox3.Location = New System.Drawing.Point(128, 6)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(190, 61)
        Me.GroupBox3.TabIndex = 4
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Listener (wskListen)"
        Me.GroupBox3.Visible = False
        '
        'cmdListenerClose
        '
        Me.cmdListenerClose.Location = New System.Drawing.Point(9, 32)
        Me.cmdListenerClose.Name = "cmdListenerClose"
        Me.cmdListenerClose.Size = New System.Drawing.Size(75, 20)
        Me.cmdListenerClose.TabIndex = 3
        Me.cmdListenerClose.Text = "Kapat"
        '
        'cmdListenerListen
        '
        Me.cmdListenerListen.Location = New System.Drawing.Point(104, 32)
        Me.cmdListenerListen.Name = "cmdListenerListen"
        Me.cmdListenerListen.Size = New System.Drawing.Size(75, 20)
        Me.cmdListenerListen.TabIndex = 2
        Me.cmdListenerListen.Text = "Dinle"
        '
        'lblLSState
        '
        Me.lblLSState.Location = New System.Drawing.Point(6, 16)
        Me.lblLSState.Name = "lblLSState"
        Me.lblLSState.Size = New System.Drawing.Size(106, 13)
        Me.lblLSState.TabIndex = 0
        Me.lblLSState.Text = "Listener State: Closed"
        '
        'lblServerState
        '
        Me.lblServerState.Location = New System.Drawing.Point(3, 17)
        Me.lblServerState.Name = "lblServerState"
        Me.lblServerState.Size = New System.Drawing.Size(117, 13)
        Me.lblServerState.TabIndex = 1
        Me.lblServerState.Text = "Baðlantý Durumu: Closed"
        '
        'wskServer
        '
        Me.wskServer.BufferSize = 8192
        Me.wskServer.LegacySupport = False
        Me.wskServer.LocalPort = 8080
        Me.wskServer.MaxPendingConnections = 1
        Me.wskServer.Protocol = Winsock2007.WinsockProtocols.Tcp
        Me.wskServer.RemoteHost = "localhost"
        Me.wskServer.RemotePort = 8080
        '
        'wskListen
        '
        Me.wskListen.BufferSize = 8192
        Me.wskListen.LegacySupport = False
        Me.wskListen.LocalPort = 8080
        Me.wskListen.MaxPendingConnections = 1
        Me.wskListen.Protocol = Winsock2007.WinsockProtocols.Tcp
        Me.wskListen.RemoteHost = "localhost"
        Me.wskListen.RemotePort = 8080
        '
        'Chat_Server
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(317, 467)
        Me.Controls.Add(Me.GroupBox1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "Chat_Server"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Chat Server"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ds_tbMessage, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataTable1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemMemoEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemRichTextEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.ResumeLayout(False)
    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents pbServer As System.Windows.Forms.ProgressBar
    Friend WithEvents txtServerLog As System.Windows.Forms.TextBox
    Friend WithEvents txtServerSend As System.Windows.Forms.TextBox
    Friend WithEvents cmdServerClose As New DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cmdServerSendFile As New DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cmdServerSend As New DevExpress.XtraEditors.SimpleButton
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents cmdListenerClose As New DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cmdListenerListen As New DevExpress.XtraEditors.SimpleButton
    Friend WithEvents lblLSState As DevExpress.XtraEditors.LabelControl
    Friend WithEvents lblServerState As DevExpress.XtraEditors.LabelControl
    Friend WithEvents wskServer As Winsock2007.Winsock
    Friend WithEvents dlgSave As System.Windows.Forms.SaveFileDialog
    Friend WithEvents dlgOpen As System.Windows.Forms.OpenFileDialog
    Friend WithEvents wskListen As Winsock2007.Winsock
    Friend WithEvents wskClient As Winsock2007.Winsock
    Friend WithEvents GridControl1 As DevExpress.XtraGrid.GridControl
    Friend WithEvents ds_tbMessage As System.Data.DataSet
    Friend WithEvents DataTable1 As System.Data.DataTable
    Friend WithEvents DataColumn1 As System.Data.DataColumn
    Friend WithEvents DataColumn2 As System.Data.DataColumn
    Friend WithEvents DataColumn3 As System.Data.DataColumn
    Friend WithEvents DataColumn4 As System.Data.DataColumn
    Friend WithEvents DataColumn5 As System.Data.DataColumn
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colbGelen As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents coldteTarih As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colnBoyut As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colsString As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents RepositoryItemMemoEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemMemoEdit
    Friend WithEvents colsKimden As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents RepositoryItemRichTextEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemRichTextEdit
    Friend WithEvents GridView2 As DevExpress.XtraGrid.Views.Grid.GridView
End Class
