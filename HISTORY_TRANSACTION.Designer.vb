<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class HISTORY_TRANSACTION
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim DataGridViewCellStyle1 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As DataGridViewCellStyle = New DataGridViewCellStyle()
        GroupBox1 = New GroupBox()
        BtnRefreshCb = New Button()
        Search_history = New TextBox()
        Cb_FilterMonth = New ComboBox()
        ShowReceipt = New Button()
        History_Dt = New DataGridView()
        Trans_ID = New DataGridViewTextBoxColumn()
        CustName = New DataGridViewTextBoxColumn()
        TransDate = New DataGridViewTextBoxColumn()
        GroupBox1.SuspendLayout()
        CType(History_Dt, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' GroupBox1
        ' 
        GroupBox1.BackColor = Color.FromArgb(CByte(30), CByte(39), CByte(46))
        GroupBox1.Controls.Add(BtnRefreshCb)
        GroupBox1.Controls.Add(Search_history)
        GroupBox1.Controls.Add(Cb_FilterMonth)
        GroupBox1.Controls.Add(ShowReceipt)
        GroupBox1.Controls.Add(History_Dt)
        GroupBox1.Font = New Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        GroupBox1.ForeColor = Color.White
        GroupBox1.Location = New Point(25, 27)
        GroupBox1.Name = "GroupBox1"
        GroupBox1.Size = New Size(676, 572)
        GroupBox1.TabIndex = 0
        GroupBox1.TabStop = False
        GroupBox1.Text = "SEARCH HISTORY OF TRANSACTION"
        ' 
        ' BtnRefreshCb
        ' 
        BtnRefreshCb.BackColor = Color.Transparent
        BtnRefreshCb.BackgroundImage = My.Resources.Resources.loading_arrow
        BtnRefreshCb.BackgroundImageLayout = ImageLayout.Center
        BtnRefreshCb.FlatAppearance.BorderSize = 0
        BtnRefreshCb.FlatStyle = FlatStyle.Flat
        BtnRefreshCb.Location = New Point(192, 43)
        BtnRefreshCb.Name = "BtnRefreshCb"
        BtnRefreshCb.Size = New Size(32, 29)
        BtnRefreshCb.TabIndex = 32
        BtnRefreshCb.UseVisualStyleBackColor = False
        ' 
        ' Search_history
        ' 
        Search_history.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        Search_history.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Search_history.Location = New Point(457, 43)
        Search_history.Name = "Search_history"
        Search_history.PlaceholderText = "Search "
        Search_history.Size = New Size(213, 29)
        Search_history.TabIndex = 31
        ' 
        ' Cb_FilterMonth
        ' 
        Cb_FilterMonth.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Cb_FilterMonth.FormattingEnabled = True
        Cb_FilterMonth.Items.AddRange(New Object() {"January", "February", "March", "April", "May", "June", "July ", "August", "September", "November", "December"})
        Cb_FilterMonth.Location = New Point(6, 43)
        Cb_FilterMonth.Name = "Cb_FilterMonth"
        Cb_FilterMonth.Size = New Size(180, 29)
        Cb_FilterMonth.TabIndex = 2
        Cb_FilterMonth.Text = "Filter by month"
        ' 
        ' ShowReceipt
        ' 
        ShowReceipt.BackColor = Color.FromArgb(CByte(30), CByte(39), CByte(46))
        ShowReceipt.BackgroundImageLayout = ImageLayout.Center
        ShowReceipt.Location = New Point(281, 502)
        ShowReceipt.Name = "ShowReceipt"
        ShowReceipt.Size = New Size(162, 52)
        ShowReceipt.TabIndex = 1
        ShowReceipt.Text = "SHOW RECEIPT"
        ShowReceipt.UseVisualStyleBackColor = False
        ' 
        ' History_Dt
        ' 
        History_Dt.AllowUserToAddRows = False
        DataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle1.BackColor = Color.FromArgb(CByte(30), CByte(39), CByte(46))
        DataGridViewCellStyle1.ForeColor = Color.White
        DataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = Color.White
        History_Dt.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        History_Dt.BackgroundColor = Color.FromArgb(CByte(30), CByte(39), CByte(46))
        DataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle2.BackColor = Color.FromArgb(CByte(30), CByte(39), CByte(46))
        DataGridViewCellStyle2.Font = New Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        DataGridViewCellStyle2.ForeColor = Color.White
        DataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = DataGridViewTriState.True
        History_Dt.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        History_Dt.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        History_Dt.Columns.AddRange(New DataGridViewColumn() {Trans_ID, CustName, TransDate})
        DataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle3.BackColor = Color.FromArgb(CByte(30), CByte(39), CByte(46))
        DataGridViewCellStyle3.Font = New Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        DataGridViewCellStyle3.ForeColor = Color.White
        DataGridViewCellStyle3.SelectionBackColor = SystemColors.Highlight
        DataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = DataGridViewTriState.False
        History_Dt.DefaultCellStyle = DataGridViewCellStyle3
        History_Dt.Location = New Point(0, 78)
        History_Dt.Name = "History_Dt"
        History_Dt.ReadOnly = True
        History_Dt.RowHeadersVisible = False
        History_Dt.Size = New Size(676, 418)
        History_Dt.TabIndex = 0
        ' 
        ' Trans_ID
        ' 
        Trans_ID.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
        Trans_ID.HeaderText = "ID"
        Trans_ID.Name = "Trans_ID"
        Trans_ID.ReadOnly = True
        Trans_ID.Width = 55
        ' 
        ' CustName
        ' 
        CustName.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
        CustName.HeaderText = "CUSTOMER NAME"
        CustName.Name = "CustName"
        CustName.ReadOnly = True
        ' 
        ' TransDate
        ' 
        TransDate.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
        TransDate.HeaderText = "TRANSACTION DATE"
        TransDate.Name = "TransDate"
        TransDate.ReadOnly = True
        ' 
        ' HISTORY_TRANSACTION
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(30), CByte(39), CByte(46))
        BackgroundImageLayout = ImageLayout.Center
        ClientSize = New Size(724, 611)
        Controls.Add(GroupBox1)
        MaximizeBox = False
        MinimizeBox = False
        Name = "HISTORY_TRANSACTION"
        StartPosition = FormStartPosition.CenterScreen
        Text = "HISTORY"
        GroupBox1.ResumeLayout(False)
        GroupBox1.PerformLayout()
        CType(History_Dt, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents History_Dt As DataGridView
    Friend WithEvents Trans_ID As DataGridViewTextBoxColumn
    Friend WithEvents CustName As DataGridViewTextBoxColumn
    Friend WithEvents TransDate As DataGridViewTextBoxColumn
    Friend WithEvents Cb_FilterMonth As ComboBox
    Friend WithEvents ShowReceipt As Button
    Friend WithEvents Search_history As TextBox
    Friend WithEvents BtnRefreshCb As Button
End Class
