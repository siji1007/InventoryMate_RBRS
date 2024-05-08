<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class EMPLOYEE
    Inherits System.Windows.Forms.UserControl


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
        components = New ComponentModel.Container()
        Dim DataGridViewCellStyle7 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle8 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle9 As DataGridViewCellStyle = New DataGridViewCellStyle()
        lbl_employee = New Label()
        status_menu = New ContextMenuStrip(components)
        ACTIVE = New ToolStripMenuItem()
        OFFLINE = New ToolStripMenuItem()
        emp_datagridview = New DataGridView()
        Emp_ID = New DataGridViewTextBoxColumn()
        Emp_name = New DataGridViewTextBoxColumn()
        Emp_address = New DataGridViewTextBoxColumn()
        Emp_cnumber = New DataGridViewTextBoxColumn()
        Emp_bdate = New DataGridViewTextBoxColumn()
        Emp_status = New DataGridViewTextBoxColumn()
        txt_emp_name = New TextBox()
        txt_emp_cnumber = New TextBox()
        emp_birthdate = New DateTimePicker()
        Button1 = New Button()
        lbl_name_sup = New Label()
        Label1 = New Label()
        Label2 = New Label()
        Label3 = New Label()
        Btn_add = New Button()
        Btn_update = New Button()
        Btn_delete = New Button()
        Btn_clear = New Button()
        txt_emp_address = New TextBox()
        Label4 = New Label()
        txt_search = New TextBox()
        Label5 = New Label()
        GeneRate = New Button()
        Label6 = New Label()
        status_menu.SuspendLayout()
        CType(emp_datagridview, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' lbl_employee
        ' 
        lbl_employee.AutoSize = True
        lbl_employee.BackColor = Color.Transparent
        lbl_employee.ContextMenuStrip = status_menu
        lbl_employee.Font = New Font("Microsoft Sans Serif", 21.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lbl_employee.ForeColor = Color.White
        lbl_employee.Location = New Point(601, 26)
        lbl_employee.Name = "lbl_employee"
        lbl_employee.Size = New Size(174, 33)
        lbl_employee.TabIndex = 0
        lbl_employee.Text = "EMPLOYEE"
        ' 
        ' status_menu
        ' 
        status_menu.Items.AddRange(New ToolStripItem() {ACTIVE, OFFLINE})
        status_menu.Name = "status_menu"
        status_menu.Size = New Size(120, 48)
        ' 
        ' ACTIVE
        ' 
        ACTIVE.Name = "ACTIVE"
        ACTIVE.Size = New Size(119, 22)
        ACTIVE.Text = "ACTIVE"
        ' 
        ' OFFLINE
        ' 
        OFFLINE.Name = "OFFLINE"
        OFFLINE.Size = New Size(119, 22)
        OFFLINE.Text = "OFFLINE"
        ' 
        ' emp_datagridview
        ' 
        emp_datagridview.AllowUserToAddRows = False
        emp_datagridview.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        emp_datagridview.BackgroundColor = Color.FromArgb(CByte(30), CByte(39), CByte(46))
        DataGridViewCellStyle7.Alignment = DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle7.BackColor = Color.FromArgb(CByte(30), CByte(39), CByte(46))
        DataGridViewCellStyle7.Font = New Font("Microsoft Sans Serif", 14.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        DataGridViewCellStyle7.ForeColor = SystemColors.Window
        DataGridViewCellStyle7.SelectionBackColor = SystemColors.Highlight
        DataGridViewCellStyle7.SelectionForeColor = SystemColors.HighlightText
        DataGridViewCellStyle7.WrapMode = DataGridViewTriState.True
        emp_datagridview.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle7
        emp_datagridview.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        emp_datagridview.Columns.AddRange(New DataGridViewColumn() {Emp_ID, Emp_name, Emp_address, Emp_cnumber, Emp_bdate, Emp_status})
        DataGridViewCellStyle8.Alignment = DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle8.BackColor = Color.FromArgb(CByte(30), CByte(39), CByte(46))
        DataGridViewCellStyle8.Font = New Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        DataGridViewCellStyle8.ForeColor = Color.White
        DataGridViewCellStyle8.SelectionBackColor = SystemColors.Highlight
        DataGridViewCellStyle8.SelectionForeColor = SystemColors.HighlightText
        DataGridViewCellStyle8.WrapMode = DataGridViewTriState.False
        emp_datagridview.DefaultCellStyle = DataGridViewCellStyle8
        emp_datagridview.GridColor = SystemColors.Window
        emp_datagridview.Location = New Point(12, 127)
        emp_datagridview.Name = "emp_datagridview"
        emp_datagridview.ReadOnly = True
        DataGridViewCellStyle9.Alignment = DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle9.BackColor = Color.FromArgb(CByte(30), CByte(39), CByte(46))
        DataGridViewCellStyle9.Font = New Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        DataGridViewCellStyle9.ForeColor = Color.White
        DataGridViewCellStyle9.SelectionBackColor = SystemColors.Highlight
        DataGridViewCellStyle9.SelectionForeColor = SystemColors.HighlightText
        DataGridViewCellStyle9.WrapMode = DataGridViewTriState.True
        emp_datagridview.RowHeadersDefaultCellStyle = DataGridViewCellStyle9
        emp_datagridview.RowHeadersVisible = False
        emp_datagridview.Size = New Size(1109, 301)
        emp_datagridview.TabIndex = 1
        ' 
        ' Emp_ID
        ' 
        Emp_ID.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
        Emp_ID.HeaderText = "ID"
        Emp_ID.Name = "Emp_ID"
        Emp_ID.ReadOnly = True
        Emp_ID.Width = 52
        ' 
        ' Emp_name
        ' 
        Emp_name.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
        Emp_name.HeaderText = "NAME"
        Emp_name.Name = "Emp_name"
        Emp_name.ReadOnly = True
        ' 
        ' Emp_address
        ' 
        Emp_address.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
        Emp_address.HeaderText = "ADDRESS"
        Emp_address.Name = "Emp_address"
        Emp_address.ReadOnly = True
        ' 
        ' Emp_cnumber
        ' 
        Emp_cnumber.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
        Emp_cnumber.HeaderText = "CONTACT NUMBER"
        Emp_cnumber.Name = "Emp_cnumber"
        Emp_cnumber.ReadOnly = True
        ' 
        ' Emp_bdate
        ' 
        Emp_bdate.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
        Emp_bdate.HeaderText = "BIRTHDATE"
        Emp_bdate.Name = "Emp_bdate"
        Emp_bdate.ReadOnly = True
        ' 
        ' Emp_status
        ' 
        Emp_status.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
        Emp_status.HeaderText = "ID STATUS"
        Emp_status.Name = "Emp_status"
        Emp_status.ReadOnly = True
        Emp_status.Width = 120
        ' 
        ' txt_emp_name
        ' 
        txt_emp_name.Location = New Point(143, 450)
        txt_emp_name.Name = "txt_emp_name"
        txt_emp_name.PlaceholderText = " ex. Christan John Ibanez"
        txt_emp_name.Size = New Size(230, 23)
        txt_emp_name.TabIndex = 2
        ' 
        ' txt_emp_cnumber
        ' 
        txt_emp_cnumber.Location = New Point(168, 535)
        txt_emp_cnumber.Name = "txt_emp_cnumber"
        txt_emp_cnumber.Size = New Size(205, 23)
        txt_emp_cnumber.TabIndex = 4
        ' 
        ' emp_birthdate
        ' 
        emp_birthdate.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        emp_birthdate.Location = New Point(770, 450)
        emp_birthdate.Name = "emp_birthdate"
        emp_birthdate.ShowCheckBox = True
        emp_birthdate.Size = New Size(230, 23)
        emp_birthdate.TabIndex = 5
        ' 
        ' Button1
        ' 
        Button1.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        Button1.Location = New Point(770, 482)
        Button1.Name = "Button1"
        Button1.Size = New Size(102, 31)
        Button1.TabIndex = 6
        Button1.Text = ">>"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' lbl_name_sup
        ' 
        lbl_name_sup.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left
        lbl_name_sup.AutoSize = True
        lbl_name_sup.BackColor = Color.Transparent
        lbl_name_sup.Font = New Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lbl_name_sup.ForeColor = Color.White
        lbl_name_sup.Location = New Point(22, 454)
        lbl_name_sup.Name = "lbl_name_sup"
        lbl_name_sup.Size = New Size(55, 20)
        lbl_name_sup.TabIndex = 8
        lbl_name_sup.Text = "NAME"
        ' 
        ' Label1
        ' 
        Label1.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left
        Label1.AutoSize = True
        Label1.BackColor = Color.Transparent
        Label1.Font = New Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label1.ForeColor = Color.White
        Label1.Location = New Point(22, 537)
        Label1.Name = "Label1"
        Label1.Size = New Size(83, 20)
        Label1.TabIndex = 9
        Label1.Text = "CONTACT"
        ' 
        ' Label2
        ' 
        Label2.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        Label2.AutoSize = True
        Label2.BackColor = Color.Transparent
        Label2.Font = New Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label2.ForeColor = Color.Black
        Label2.Location = New Point(649, 453)
        Label2.Name = "Label2"
        Label2.Size = New Size(101, 20)
        Label2.TabIndex = 10
        Label2.Text = "BIRTHDATE"
        ' 
        ' Label3
        ' 
        Label3.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        Label3.AutoSize = True
        Label3.BackColor = Color.Transparent
        Label3.Font = New Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label3.ForeColor = Color.Black
        Label3.Location = New Point(648, 493)
        Label3.Name = "Label3"
        Label3.Size = New Size(93, 20)
        Label3.TabIndex = 11
        Label3.Text = "ID STATUS"
        ' 
        ' Btn_add
        ' 
        Btn_add.Anchor = AnchorStyles.Bottom Or AnchorStyles.Left
        Btn_add.Location = New Point(27, 696)
        Btn_add.Name = "Btn_add"
        Btn_add.Size = New Size(111, 53)
        Btn_add.TabIndex = 12
        Btn_add.Text = "CREATE"
        Btn_add.UseVisualStyleBackColor = True
        ' 
        ' Btn_update
        ' 
        Btn_update.Anchor = AnchorStyles.Bottom Or AnchorStyles.Left
        Btn_update.Location = New Point(266, 696)
        Btn_update.Name = "Btn_update"
        Btn_update.Size = New Size(111, 53)
        Btn_update.TabIndex = 13
        Btn_update.Text = "UPDATE"
        Btn_update.UseVisualStyleBackColor = True
        ' 
        ' Btn_delete
        ' 
        Btn_delete.Anchor = AnchorStyles.Bottom Or AnchorStyles.Right
        Btn_delete.Location = New Point(789, 696)
        Btn_delete.Name = "Btn_delete"
        Btn_delete.Size = New Size(111, 53)
        Btn_delete.TabIndex = 14
        Btn_delete.Text = "DELETE"
        Btn_delete.UseVisualStyleBackColor = True
        ' 
        ' Btn_clear
        ' 
        Btn_clear.Anchor = AnchorStyles.Bottom Or AnchorStyles.Right
        Btn_clear.Location = New Point(1012, 696)
        Btn_clear.Name = "Btn_clear"
        Btn_clear.Size = New Size(111, 53)
        Btn_clear.TabIndex = 15
        Btn_clear.Text = "CLEAR"
        Btn_clear.UseVisualStyleBackColor = True
        ' 
        ' txt_emp_address
        ' 
        txt_emp_address.Location = New Point(143, 490)
        txt_emp_address.Name = "txt_emp_address"
        txt_emp_address.PlaceholderText = " ex. Talisay, Camarines Norte"
        txt_emp_address.Size = New Size(230, 23)
        txt_emp_address.TabIndex = 3
        ' 
        ' Label4
        ' 
        Label4.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left
        Label4.AutoSize = True
        Label4.BackColor = Color.Transparent
        Label4.Font = New Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label4.ForeColor = Color.White
        Label4.Location = New Point(22, 493)
        Label4.Name = "Label4"
        Label4.Size = New Size(89, 20)
        Label4.TabIndex = 17
        Label4.Text = "ADDRESS"
        ' 
        ' txt_search
        ' 
        txt_search.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        txt_search.Location = New Point(910, 98)
        txt_search.Name = "txt_search"
        txt_search.PlaceholderText = "Search"
        txt_search.Size = New Size(213, 23)
        txt_search.TabIndex = 18
        ' 
        ' Label5
        ' 
        Label5.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        Label5.AutoSize = True
        Label5.BackColor = Color.Transparent
        Label5.Image = My.Resources.Resources.search
        Label5.Location = New Point(879, 101)
        Label5.Name = "Label5"
        Label5.Size = New Size(28, 15)
        Label5.TabIndex = 40
        Label5.Text = "       "
        ' 
        ' GeneRate
        ' 
        GeneRate.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        GeneRate.BackColor = Color.FromArgb(CByte(0), CByte(192), CByte(0))
        GeneRate.FlatStyle = FlatStyle.Flat
        GeneRate.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        GeneRate.Location = New Point(1001, 3)
        GeneRate.Name = "GeneRate"
        GeneRate.Size = New Size(129, 30)
        GeneRate.TabIndex = 41
        GeneRate.Text = "GENERATE REPORT"
        GeneRate.UseVisualStyleBackColor = False
        ' 
        ' Label6
        ' 
        Label6.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left
        Label6.AutoSize = True
        Label6.BackColor = Color.Transparent
        Label6.Font = New Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label6.ForeColor = Color.White
        Label6.Location = New Point(129, 537)
        Label6.Name = "Label6"
        Label6.Size = New Size(36, 20)
        Label6.TabIndex = 42
        Label6.Text = "+63"
        ' 
        ' EMPLOYEE
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackgroundImage = My.Resources.Resources.backgroud
        BackgroundImageLayout = ImageLayout.Center
        Controls.Add(Label6)
        Controls.Add(GeneRate)
        Controls.Add(Label5)
        Controls.Add(txt_search)
        Controls.Add(Label4)
        Controls.Add(txt_emp_address)
        Controls.Add(Btn_clear)
        Controls.Add(Btn_delete)
        Controls.Add(Btn_update)
        Controls.Add(Btn_add)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(lbl_name_sup)
        Controls.Add(Button1)
        Controls.Add(emp_birthdate)
        Controls.Add(txt_emp_cnumber)
        Controls.Add(txt_emp_name)
        Controls.Add(emp_datagridview)
        Controls.Add(lbl_employee)
        DoubleBuffered = True
        Name = "EMPLOYEE"
        Size = New Size(1133, 772)
        status_menu.ResumeLayout(False)
        CType(emp_datagridview, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents lbl_employee As Label
    Friend WithEvents emp_datagridview As DataGridView
    Friend WithEvents txt_emp_name As TextBox
    Friend WithEvents txt_emp_cnumber As TextBox
    Friend WithEvents emp_birthdate As DateTimePicker
    Friend WithEvents Button1 As Button
    Friend WithEvents lbl_name_sup As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents status_menu As ContextMenuStrip
    Friend WithEvents ACTIVE As ToolStripMenuItem
    Friend WithEvents OFFLINE As ToolStripMenuItem
    Friend WithEvents Btn_add As Button
    Friend WithEvents Btn_update As Button
    Friend WithEvents Btn_delete As Button
    Friend WithEvents Btn_clear As Button
    Friend WithEvents Emp_ID As DataGridViewTextBoxColumn
    Friend WithEvents Emp_name As DataGridViewTextBoxColumn
    Friend WithEvents Emp_address As DataGridViewTextBoxColumn
    Friend WithEvents Emp_cnumber As DataGridViewTextBoxColumn
    Friend WithEvents Emp_bdate As DataGridViewTextBoxColumn
    Friend WithEvents Emp_status As DataGridViewTextBoxColumn
    Friend WithEvents txt_emp_address As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents txt_search As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents GeneRate As Button
    Friend WithEvents Label6 As Label
End Class
