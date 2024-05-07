<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class USERS
    Inherits System.Windows.Forms.UserControl

    'UserControl overrides dispose to clean up the component list.
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
        Dim DataGridViewCellStyle4 As DataGridViewCellStyle = New DataGridViewCellStyle()
        GroupBox1 = New GroupBox()
        Button2 = New Button()
        Button1 = New Button()
        usersDt = New DataGridView()
        userID = New DataGridViewTextBoxColumn()
        EmpName = New DataGridViewTextBoxColumn()
        jobpos = New DataGridViewTextBoxColumn()
        status = New DataGridViewTextBoxColumn()
        GroupBox1.SuspendLayout()
        CType(usersDt, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' GroupBox1
        ' 
        GroupBox1.BackColor = Color.FromArgb(CByte(30), CByte(39), CByte(46))
        GroupBox1.Controls.Add(Button2)
        GroupBox1.Controls.Add(Button1)
        GroupBox1.Controls.Add(usersDt)
        GroupBox1.Dock = DockStyle.Fill
        GroupBox1.FlatStyle = FlatStyle.Flat
        GroupBox1.Font = New Font("Microsoft Sans Serif", 11.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        GroupBox1.ForeColor = Color.White
        GroupBox1.Location = New Point(0, 0)
        GroupBox1.Name = "GroupBox1"
        GroupBox1.Size = New Size(740, 650)
        GroupBox1.TabIndex = 0
        GroupBox1.TabStop = False
        GroupBox1.Text = "USERS ACCOUNTS"
        ' 
        ' Button2
        ' 
        Button2.FlatAppearance.BorderSize = 2
        Button2.FlatStyle = FlatStyle.Flat
        Button2.ForeColor = Color.Red
        Button2.Location = New Point(35, 282)
        Button2.Name = "Button2"
        Button2.Size = New Size(119, 36)
        Button2.TabIndex = 2
        Button2.Text = "FIRED"
        Button2.UseVisualStyleBackColor = True
        ' 
        ' Button1
        ' 
        Button1.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        Button1.FlatAppearance.BorderSize = 2
        Button1.FlatStyle = FlatStyle.Flat
        Button1.ForeColor = Color.FromArgb(CByte(0), CByte(192), CByte(0))
        Button1.Location = New Point(587, 282)
        Button1.Name = "Button1"
        Button1.Size = New Size(119, 36)
        Button1.TabIndex = 1
        Button1.Text = "HIRED"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' usersDt
        ' 
        usersDt.AllowUserToAddRows = False
        DataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle1.BackColor = Color.FromArgb(CByte(30), CByte(39), CByte(46))
        DataGridViewCellStyle1.ForeColor = Color.White
        DataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = Color.White
        usersDt.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        usersDt.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        usersDt.BackgroundColor = Color.FromArgb(CByte(30), CByte(39), CByte(46))
        DataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle2.BackColor = Color.FromArgb(CByte(30), CByte(39), CByte(46))
        DataGridViewCellStyle2.Font = New Font("Microsoft Sans Serif", 11.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        DataGridViewCellStyle2.ForeColor = Color.White
        DataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = DataGridViewTriState.True
        usersDt.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        usersDt.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        usersDt.Columns.AddRange(New DataGridViewColumn() {userID, EmpName, jobpos, status})
        DataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle3.BackColor = Color.FromArgb(CByte(30), CByte(39), CByte(46))
        DataGridViewCellStyle3.Font = New Font("Microsoft Sans Serif", 11.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        DataGridViewCellStyle3.ForeColor = Color.White
        DataGridViewCellStyle3.SelectionBackColor = SystemColors.Highlight
        DataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = DataGridViewTriState.False
        usersDt.DefaultCellStyle = DataGridViewCellStyle3
        usersDt.GridColor = Color.White
        usersDt.Location = New Point(35, 61)
        usersDt.Name = "usersDt"
        usersDt.ReadOnly = True
        DataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle4.BackColor = Color.FromArgb(CByte(30), CByte(39), CByte(46))
        DataGridViewCellStyle4.Font = New Font("Microsoft Sans Serif", 11.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        DataGridViewCellStyle4.ForeColor = Color.White
        DataGridViewCellStyle4.SelectionBackColor = SystemColors.Highlight
        DataGridViewCellStyle4.SelectionForeColor = SystemColors.HighlightText
        DataGridViewCellStyle4.WrapMode = DataGridViewTriState.True
        usersDt.RowHeadersDefaultCellStyle = DataGridViewCellStyle4
        usersDt.RowHeadersVisible = False
        usersDt.Size = New Size(671, 204)
        usersDt.TabIndex = 0
        ' 
        ' userID
        ' 
        userID.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
        userID.HeaderText = "ID"
        userID.Name = "userID"
        userID.ReadOnly = True
        userID.Width = 47
        ' 
        ' EmpName
        ' 
        EmpName.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
        EmpName.HeaderText = "NAME"
        EmpName.Name = "EmpName"
        EmpName.ReadOnly = True
        ' 
        ' jobpos
        ' 
        jobpos.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
        jobpos.HeaderText = "JOB POSITION"
        jobpos.Name = "jobpos"
        jobpos.ReadOnly = True
        ' 
        ' status
        ' 
        status.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
        status.HeaderText = "STATUS"
        status.Name = "status"
        status.ReadOnly = True
        ' 
        ' USERS
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackgroundImage = My.Resources.Resources.backgroud
        Controls.Add(GroupBox1)
        Name = "USERS"
        Size = New Size(740, 650)
        GroupBox1.ResumeLayout(False)
        CType(usersDt, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Button2 As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents usersDt As DataGridView
    Friend WithEvents userID As DataGridViewTextBoxColumn
    Friend WithEvents EmpName As DataGridViewTextBoxColumn
    Friend WithEvents jobpos As DataGridViewTextBoxColumn
    Friend WithEvents status As DataGridViewTextBoxColumn

End Class
