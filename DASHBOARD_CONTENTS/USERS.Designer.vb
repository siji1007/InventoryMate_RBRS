﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
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
        Dim DataGridViewCellStyle5 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle7 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle8 As DataGridViewCellStyle = New DataGridViewCellStyle()
        GroupBox1 = New GroupBox()
        Btn_promote = New Button()
        Cb_Jobpos = New ComboBox()
        Btn_Fired = New Button()
        Btn_Hired = New Button()
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
        GroupBox1.Controls.Add(Btn_promote)
        GroupBox1.Controls.Add(Cb_Jobpos)
        GroupBox1.Controls.Add(Btn_Fired)
        GroupBox1.Controls.Add(Btn_Hired)
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
        ' Btn_promote
        ' 
        Btn_promote.FlatStyle = FlatStyle.Flat
        Btn_promote.Location = New Point(37, 318)
        Btn_promote.Name = "Btn_promote"
        Btn_promote.Size = New Size(106, 31)
        Btn_promote.TabIndex = 4
        Btn_promote.Text = "PROMOTE"
        Btn_promote.UseVisualStyleBackColor = True
        ' 
        ' Cb_Jobpos
        ' 
        Cb_Jobpos.FormattingEnabled = True
        Cb_Jobpos.Items.AddRange(New Object() {"ADMIN", "EMPLOYEE", "OWNER"})
        Cb_Jobpos.Location = New Point(35, 282)
        Cb_Jobpos.Name = "Cb_Jobpos"
        Cb_Jobpos.Size = New Size(162, 26)
        Cb_Jobpos.TabIndex = 3
        Cb_Jobpos.Text = "POSITION"
        ' 
        ' Btn_Fired
        ' 
        Btn_Fired.FlatAppearance.BorderSize = 2
        Btn_Fired.FlatStyle = FlatStyle.Flat
        Btn_Fired.ForeColor = Color.Red
        Btn_Fired.Location = New Point(451, 282)
        Btn_Fired.Name = "Btn_Fired"
        Btn_Fired.Size = New Size(119, 36)
        Btn_Fired.TabIndex = 2
        Btn_Fired.Text = "FIRED"
        Btn_Fired.UseVisualStyleBackColor = True
        ' 
        ' Btn_Hired
        ' 
        Btn_Hired.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        Btn_Hired.FlatAppearance.BorderSize = 2
        Btn_Hired.FlatStyle = FlatStyle.Flat
        Btn_Hired.ForeColor = Color.FromArgb(CByte(0), CByte(192), CByte(0))
        Btn_Hired.Location = New Point(587, 282)
        Btn_Hired.Name = "Btn_Hired"
        Btn_Hired.Size = New Size(119, 36)
        Btn_Hired.TabIndex = 1
        Btn_Hired.Text = "HIRED"
        Btn_Hired.UseVisualStyleBackColor = True
        ' 
        ' usersDt
        ' 
        usersDt.AllowUserToAddRows = False
        DataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle5.BackColor = Color.FromArgb(CByte(30), CByte(39), CByte(46))
        DataGridViewCellStyle5.ForeColor = Color.White
        DataGridViewCellStyle5.SelectionBackColor = SystemColors.Highlight
        DataGridViewCellStyle5.SelectionForeColor = Color.White
        usersDt.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle5
        usersDt.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        usersDt.BackgroundColor = Color.FromArgb(CByte(30), CByte(39), CByte(46))
        DataGridViewCellStyle6.Alignment = DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle6.BackColor = Color.FromArgb(CByte(30), CByte(39), CByte(46))
        DataGridViewCellStyle6.Font = New Font("Microsoft Sans Serif", 11.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        DataGridViewCellStyle6.ForeColor = Color.White
        DataGridViewCellStyle6.SelectionBackColor = SystemColors.Highlight
        DataGridViewCellStyle6.SelectionForeColor = SystemColors.HighlightText
        DataGridViewCellStyle6.WrapMode = DataGridViewTriState.True
        usersDt.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle6
        usersDt.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        usersDt.Columns.AddRange(New DataGridViewColumn() {userID, EmpName, jobpos, status})
        DataGridViewCellStyle7.Alignment = DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle7.BackColor = Color.FromArgb(CByte(30), CByte(39), CByte(46))
        DataGridViewCellStyle7.Font = New Font("Microsoft Sans Serif", 11.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        DataGridViewCellStyle7.ForeColor = Color.White
        DataGridViewCellStyle7.SelectionBackColor = SystemColors.Highlight
        DataGridViewCellStyle7.SelectionForeColor = SystemColors.HighlightText
        DataGridViewCellStyle7.WrapMode = DataGridViewTriState.False
        usersDt.DefaultCellStyle = DataGridViewCellStyle7
        usersDt.GridColor = Color.White
        usersDt.Location = New Point(35, 61)
        usersDt.Name = "usersDt"
        usersDt.ReadOnly = True
        DataGridViewCellStyle8.Alignment = DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle8.BackColor = Color.FromArgb(CByte(30), CByte(39), CByte(46))
        DataGridViewCellStyle8.Font = New Font("Microsoft Sans Serif", 11.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        DataGridViewCellStyle8.ForeColor = Color.White
        DataGridViewCellStyle8.SelectionBackColor = SystemColors.Highlight
        DataGridViewCellStyle8.SelectionForeColor = SystemColors.HighlightText
        DataGridViewCellStyle8.WrapMode = DataGridViewTriState.True
        usersDt.RowHeadersDefaultCellStyle = DataGridViewCellStyle8
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
    Friend WithEvents Btn_Fired As Button
    Friend WithEvents Btn_Hired As Button
    Friend WithEvents usersDt As DataGridView
    Friend WithEvents userID As DataGridViewTextBoxColumn
    Friend WithEvents EmpName As DataGridViewTextBoxColumn
    Friend WithEvents jobpos As DataGridViewTextBoxColumn
    Friend WithEvents status As DataGridViewTextBoxColumn
    Friend WithEvents Btn_promote As Button
    Friend WithEvents Cb_Jobpos As ComboBox

End Class
