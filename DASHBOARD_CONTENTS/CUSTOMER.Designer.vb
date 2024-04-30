<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CUSTOMER
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
        Lbl_customer = New Label()
        customer_datagridview = New DataGridView()
        cl_ID = New DataGridViewTextBoxColumn()
        CL_NAME = New DataGridViewTextBoxColumn()
        CL_ADDRESS = New DataGridViewTextBoxColumn()
        CL_EMAIL = New DataGridViewTextBoxColumn()
        CL_CNUMBER = New DataGridViewTextBoxColumn()
        Label5 = New Label()
        Cust_search = New TextBox()
        Clear_cust_btn = New Button()
        Delete_cust_btn = New Button()
        Update_cust_btn = New Button()
        Add_cust_btn = New Button()
        Label4 = New Label()
        Label3 = New Label()
        Label2 = New Label()
        Label1 = New Label()
        txt_cnumber = New TextBox()
        txt_cemail = New TextBox()
        txt_caddress = New TextBox()
        txt_cname = New TextBox()
        CType(customer_datagridview, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Lbl_customer
        ' 
        Lbl_customer.AutoSize = True
        Lbl_customer.BackColor = Color.Transparent
        Lbl_customer.Font = New Font("Microsoft Sans Serif", 18F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Lbl_customer.ForeColor = Color.White
        Lbl_customer.Location = New Point(601, 31)
        Lbl_customer.Name = "Lbl_customer"
        Lbl_customer.Size = New Size(151, 29)
        Lbl_customer.TabIndex = 2
        Lbl_customer.Text = "CUSTOMER"
        ' 
        ' customer_datagridview
        ' 
        customer_datagridview.AllowUserToAddRows = False
        customer_datagridview.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        customer_datagridview.BackgroundColor = Color.FromArgb(CByte(30), CByte(39), CByte(46))
        DataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle1.BackColor = Color.FromArgb(CByte(30), CByte(39), CByte(46))
        DataGridViewCellStyle1.Font = New Font("Microsoft Sans Serif", 14.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        DataGridViewCellStyle1.ForeColor = Color.White
        DataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = DataGridViewTriState.True
        customer_datagridview.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        customer_datagridview.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        customer_datagridview.Columns.AddRange(New DataGridViewColumn() {cl_ID, CL_NAME, CL_ADDRESS, CL_EMAIL, CL_CNUMBER})
        DataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle2.BackColor = Color.FromArgb(CByte(30), CByte(39), CByte(46))
        DataGridViewCellStyle2.Font = New Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        DataGridViewCellStyle2.ForeColor = Color.White
        DataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = DataGridViewTriState.False
        customer_datagridview.DefaultCellStyle = DataGridViewCellStyle2
        customer_datagridview.GridColor = SystemColors.Window
        customer_datagridview.Location = New Point(12, 127)
        customer_datagridview.Name = "customer_datagridview"
        customer_datagridview.ReadOnly = True
        DataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle3.BackColor = Color.FromArgb(CByte(30), CByte(39), CByte(46))
        DataGridViewCellStyle3.Font = New Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        DataGridViewCellStyle3.ForeColor = SystemColors.WindowText
        DataGridViewCellStyle3.SelectionBackColor = SystemColors.Highlight
        DataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = DataGridViewTriState.True
        customer_datagridview.RowHeadersDefaultCellStyle = DataGridViewCellStyle3
        customer_datagridview.RowHeadersVisible = False
        customer_datagridview.ScrollBars = ScrollBars.Vertical
        customer_datagridview.Size = New Size(1109, 301)
        customer_datagridview.TabIndex = 3
        ' 
        ' cl_ID
        ' 
        cl_ID.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
        cl_ID.HeaderText = "ID"
        cl_ID.Name = "cl_ID"
        cl_ID.ReadOnly = True
        cl_ID.Width = 52
        ' 
        ' CL_NAME
        ' 
        CL_NAME.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
        CL_NAME.HeaderText = "NAME"
        CL_NAME.Name = "CL_NAME"
        CL_NAME.ReadOnly = True
        ' 
        ' CL_ADDRESS
        ' 
        CL_ADDRESS.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
        CL_ADDRESS.HeaderText = "ADDRESS"
        CL_ADDRESS.Name = "CL_ADDRESS"
        CL_ADDRESS.ReadOnly = True
        ' 
        ' CL_EMAIL
        ' 
        CL_EMAIL.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
        CL_EMAIL.HeaderText = "EMAIL"
        CL_EMAIL.Name = "CL_EMAIL"
        CL_EMAIL.ReadOnly = True
        ' 
        ' CL_CNUMBER
        ' 
        CL_CNUMBER.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
        CL_CNUMBER.HeaderText = "CONTACT NUMBER"
        CL_CNUMBER.Name = "CL_CNUMBER"
        CL_CNUMBER.ReadOnly = True
        ' 
        ' Label5
        ' 
        Label5.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        Label5.AutoSize = True
        Label5.BackColor = Color.Transparent
        Label5.Image = My.Resources.Resources.search
        Label5.Location = New Point(876, 103)
        Label5.Name = "Label5"
        Label5.Size = New Size(28, 15)
        Label5.TabIndex = 35
        Label5.Text = "       "
        ' 
        ' Cust_search
        ' 
        Cust_search.Location = New Point(910, 98)
        Cust_search.Name = "Cust_search"
        Cust_search.PlaceholderText = "Search"
        Cust_search.Size = New Size(213, 23)
        Cust_search.TabIndex = 34
        ' 
        ' Clear_cust_btn
        ' 
        Clear_cust_btn.Anchor = AnchorStyles.Bottom Or AnchorStyles.Right
        Clear_cust_btn.Location = New Point(1012, 706)
        Clear_cust_btn.Name = "Clear_cust_btn"
        Clear_cust_btn.Size = New Size(111, 53)
        Clear_cust_btn.TabIndex = 33
        Clear_cust_btn.Text = "CLEAR"
        Clear_cust_btn.UseVisualStyleBackColor = True
        ' 
        ' Delete_cust_btn
        ' 
        Delete_cust_btn.Anchor = AnchorStyles.Bottom Or AnchorStyles.Right
        Delete_cust_btn.Location = New Point(789, 706)
        Delete_cust_btn.Name = "Delete_cust_btn"
        Delete_cust_btn.Size = New Size(111, 53)
        Delete_cust_btn.TabIndex = 32
        Delete_cust_btn.Text = "DELETE"
        Delete_cust_btn.UseVisualStyleBackColor = True
        ' 
        ' Update_cust_btn
        ' 
        Update_cust_btn.Anchor = AnchorStyles.Bottom Or AnchorStyles.Left
        Update_cust_btn.Location = New Point(266, 706)
        Update_cust_btn.Name = "Update_cust_btn"
        Update_cust_btn.Size = New Size(111, 53)
        Update_cust_btn.TabIndex = 31
        Update_cust_btn.Text = "UPDATE"
        Update_cust_btn.UseVisualStyleBackColor = True
        ' 
        ' Add_cust_btn
        ' 
        Add_cust_btn.Anchor = AnchorStyles.Bottom Or AnchorStyles.Left
        Add_cust_btn.Location = New Point(27, 706)
        Add_cust_btn.Name = "Add_cust_btn"
        Add_cust_btn.Size = New Size(111, 53)
        Add_cust_btn.TabIndex = 30
        Add_cust_btn.Text = "CREATE"
        Add_cust_btn.UseVisualStyleBackColor = True
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.BackColor = Color.Transparent
        Label4.Font = New Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label4.ForeColor = Color.Black
        Label4.Location = New Point(646, 463)
        Label4.Name = "Label4"
        Label4.Size = New Size(79, 20)
        Label4.TabIndex = 29
        Label4.Text = "NUMBER"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.BackColor = Color.Transparent
        Label3.Font = New Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label3.ForeColor = Color.White
        Label3.Location = New Point(17, 547)
        Label3.Name = "Label3"
        Label3.Size = New Size(58, 20)
        Label3.TabIndex = 28
        Label3.Text = "EMAIL"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.BackColor = Color.Transparent
        Label2.Font = New Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label2.ForeColor = Color.White
        Label2.Location = New Point(17, 505)
        Label2.Name = "Label2"
        Label2.Size = New Size(89, 20)
        Label2.TabIndex = 27
        Label2.Text = "ADDRESS"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.BackColor = Color.Transparent
        Label1.Font = New Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label1.ForeColor = Color.White
        Label1.Location = New Point(17, 463)
        Label1.Name = "Label1"
        Label1.Size = New Size(55, 20)
        Label1.TabIndex = 26
        Label1.Text = "NAME"
        ' 
        ' txt_cnumber
        ' 
        txt_cnumber.Location = New Point(731, 460)
        txt_cnumber.Name = "txt_cnumber"
        txt_cnumber.Size = New Size(230, 23)
        txt_cnumber.TabIndex = 25
        txt_cnumber.Text = "+63"
        ' 
        ' txt_cemail
        ' 
        txt_cemail.Location = New Point(143, 544)
        txt_cemail.Name = "txt_cemail"
        txt_cemail.PlaceholderText = " ex. cj@gmail.com"
        txt_cemail.Size = New Size(230, 23)
        txt_cemail.TabIndex = 24
        ' 
        ' txt_caddress
        ' 
        txt_caddress.Location = New Point(143, 502)
        txt_caddress.Name = "txt_caddress"
        txt_caddress.PlaceholderText = " ex. Poblacion, Talisay Camarines Norte"
        txt_caddress.Size = New Size(230, 23)
        txt_caddress.TabIndex = 23
        ' 
        ' txt_cname
        ' 
        txt_cname.Location = New Point(143, 460)
        txt_cname.Name = "txt_cname"
        txt_cname.PlaceholderText = " ex. Christian John D. Ibanez"
        txt_cname.Size = New Size(230, 23)
        txt_cname.TabIndex = 22
        ' 
        ' CUSTOMER
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackgroundImage = My.Resources.Resources.backgroud
        BackgroundImageLayout = ImageLayout.Center
        Controls.Add(Label5)
        Controls.Add(Cust_search)
        Controls.Add(Clear_cust_btn)
        Controls.Add(Delete_cust_btn)
        Controls.Add(Update_cust_btn)
        Controls.Add(Add_cust_btn)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(txt_cnumber)
        Controls.Add(txt_cemail)
        Controls.Add(txt_caddress)
        Controls.Add(txt_cname)
        Controls.Add(customer_datagridview)
        Controls.Add(Lbl_customer)
        DoubleBuffered = True
        Name = "CUSTOMER"
        Size = New Size(1149, 788)
        CType(customer_datagridview, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Lbl_customer As Label
    Friend WithEvents customer_datagridview As DataGridView
    Friend WithEvents cl_ID As DataGridViewTextBoxColumn
    Friend WithEvents CL_NAME As DataGridViewTextBoxColumn
    Friend WithEvents CL_ADDRESS As DataGridViewTextBoxColumn
    Friend WithEvents CL_EMAIL As DataGridViewTextBoxColumn
    Friend WithEvents CL_CNUMBER As DataGridViewTextBoxColumn
    Friend WithEvents Label5 As Label
    Friend WithEvents Cust_search As TextBox
    Friend WithEvents Clear_cust_btn As Button
    Friend WithEvents Delete_cust_btn As Button
    Friend WithEvents Update_cust_btn As Button
    Friend WithEvents Add_cust_btn As Button
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents txt_cnumber As TextBox
    Friend WithEvents txt_cemail As TextBox
    Friend WithEvents txt_caddress As TextBox
    Friend WithEvents txt_cname As TextBox

End Class
