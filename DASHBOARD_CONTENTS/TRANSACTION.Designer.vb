<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class TRANSACTION
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
        Lbl_transaction = New Label()
        Panel1 = New Panel()
        GroupBox3 = New GroupBox()
        BTN_Cbrefresh = New Button()
        Label11 = New Label()
        txt_Custname = New ComboBox()
        txt_custnumber = New TextBox()
        txt_custemail = New TextBox()
        txt_custaddress = New TextBox()
        Label6 = New Label()
        Label5 = New Label()
        Label4 = New Label()
        Label3 = New Label()
        GroupBox2 = New GroupBox()
        Label10 = New Label()
        txt_service_fee = New TextBox()
        txt_EmpID = New TextBox()
        Cb_employeeName = New ComboBox()
        Label8 = New Label()
        Label7 = New Label()
        GroupBox1 = New GroupBox()
        add_btn = New Button()
        CLEAR = New Label()
        clear_btn = New Button()
        lbl_stock = New Label()
        GroupBox4 = New GroupBox()
        Total_cost = New Label()
        Cb_warranty = New ComboBox()
        txt_price = New TextBox()
        txt_quantity = New TextBox()
        Cb_Products = New ComboBox()
        Label9 = New Label()
        Label2 = New Label()
        Label1 = New Label()
        lbl_name_sup = New Label()
        transaction_datagridview = New DataGridView()
        dt_id = New DataGridViewTextBoxColumn()
        dt_product_name = New DataGridViewTextBoxColumn()
        dt_quantity = New DataGridViewTextBoxColumn()
        dt_price = New DataGridViewTextBoxColumn()
        dt_warranty = New DataGridViewTextBoxColumn()
        dt_warranty_coverage = New DataGridViewTextBoxColumn()
        dt_total = New DataGridViewTextBoxColumn()
        Print_btn = New Button()
        History = New Button()
        Panel1.SuspendLayout()
        GroupBox3.SuspendLayout()
        GroupBox2.SuspendLayout()
        GroupBox1.SuspendLayout()
        GroupBox4.SuspendLayout()
        CType(transaction_datagridview, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Lbl_transaction
        ' 
        Lbl_transaction.AutoSize = True
        Lbl_transaction.BackColor = Color.Transparent
        Lbl_transaction.Font = New Font("Microsoft Sans Serif", 18F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Lbl_transaction.ForeColor = Color.White
        Lbl_transaction.Location = New Point(583, 15)
        Lbl_transaction.Name = "Lbl_transaction"
        Lbl_transaction.Size = New Size(186, 29)
        Lbl_transaction.TabIndex = 3
        Lbl_transaction.Text = "TRANSACTION"
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.FromArgb(CByte(30), CByte(39), CByte(46))
        Panel1.Controls.Add(GroupBox3)
        Panel1.Controls.Add(GroupBox2)
        Panel1.Controls.Add(GroupBox1)
        Panel1.Location = New Point(65, 48)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(1032, 612)
        Panel1.TabIndex = 4
        ' 
        ' GroupBox3
        ' 
        GroupBox3.Controls.Add(BTN_Cbrefresh)
        GroupBox3.Controls.Add(Label11)
        GroupBox3.Controls.Add(txt_Custname)
        GroupBox3.Controls.Add(txt_custnumber)
        GroupBox3.Controls.Add(txt_custemail)
        GroupBox3.Controls.Add(txt_custaddress)
        GroupBox3.Controls.Add(Label6)
        GroupBox3.Controls.Add(Label5)
        GroupBox3.Controls.Add(Label4)
        GroupBox3.Controls.Add(Label3)
        GroupBox3.Dock = DockStyle.Fill
        GroupBox3.ForeColor = Color.White
        GroupBox3.Location = New Point(0, 313)
        GroupBox3.Name = "GroupBox3"
        GroupBox3.Size = New Size(1032, 185)
        GroupBox3.TabIndex = 2
        GroupBox3.TabStop = False
        GroupBox3.Text = "CUSTOMER DETAILS"
        ' 
        ' BTN_Cbrefresh
        ' 
        BTN_Cbrefresh.BackgroundImage = My.Resources.Resources.loading_arrow
        BTN_Cbrefresh.BackgroundImageLayout = ImageLayout.Center
        BTN_Cbrefresh.FlatAppearance.BorderSize = 0
        BTN_Cbrefresh.FlatStyle = FlatStyle.Flat
        BTN_Cbrefresh.Location = New Point(418, 52)
        BTN_Cbrefresh.Name = "BTN_Cbrefresh"
        BTN_Cbrefresh.Size = New Size(37, 28)
        BTN_Cbrefresh.TabIndex = 35
        BTN_Cbrefresh.UseVisualStyleBackColor = True
        ' 
        ' Label11
        ' 
        Label11.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Right
        Label11.AutoSize = True
        Label11.BackColor = Color.White
        Label11.Font = New Font("Microsoft Sans Serif", 12.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label11.ForeColor = Color.Black
        Label11.Location = New Point(701, 95)
        Label11.Name = "Label11"
        Label11.Size = New Size(37, 20)
        Label11.TabIndex = 34
        Label11.Text = "+63"
        ' 
        ' txt_Custname
        ' 
        txt_Custname.AutoCompleteMode = AutoCompleteMode.Suggest
        txt_Custname.AutoCompleteSource = AutoCompleteSource.ListItems
        txt_Custname.FormattingEnabled = True
        txt_Custname.Location = New Point(191, 52)
        txt_Custname.Name = "txt_Custname"
        txt_Custname.Size = New Size(225, 23)
        txt_Custname.TabIndex = 33
        ' 
        ' txt_custnumber
        ' 
        txt_custnumber.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Right
        txt_custnumber.Location = New Point(741, 94)
        txt_custnumber.Name = "txt_custnumber"
        txt_custnumber.Size = New Size(184, 23)
        txt_custnumber.TabIndex = 32
        ' 
        ' txt_custemail
        ' 
        txt_custemail.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Right
        txt_custemail.Location = New Point(701, 49)
        txt_custemail.Name = "txt_custemail"
        txt_custemail.Size = New Size(224, 23)
        txt_custemail.TabIndex = 31
        ' 
        ' txt_custaddress
        ' 
        txt_custaddress.Location = New Point(192, 97)
        txt_custaddress.Name = "txt_custaddress"
        txt_custaddress.Size = New Size(224, 23)
        txt_custaddress.TabIndex = 30
        ' 
        ' Label6
        ' 
        Label6.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Right
        Label6.AutoSize = True
        Label6.BackColor = Color.Transparent
        Label6.Font = New Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label6.ForeColor = Color.White
        Label6.Location = New Point(538, 94)
        Label6.Name = "Label6"
        Label6.Size = New Size(157, 20)
        Label6.TabIndex = 29
        Label6.Text = "CONTACT NUMBER"
        ' 
        ' Label5
        ' 
        Label5.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Right
        Label5.AutoSize = True
        Label5.BackColor = Color.Transparent
        Label5.Font = New Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label5.ForeColor = Color.White
        Label5.Location = New Point(538, 52)
        Label5.Name = "Label5"
        Label5.Size = New Size(142, 20)
        Label5.TabIndex = 28
        Label5.Text = "EMAIL ADDRESS"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.BackColor = Color.Transparent
        Label4.Font = New Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label4.ForeColor = Color.White
        Label4.Location = New Point(48, 97)
        Label4.Name = "Label4"
        Label4.Size = New Size(89, 20)
        Label4.TabIndex = 27
        Label4.Text = "ADDRESS"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.BackColor = Color.Transparent
        Label3.Font = New Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label3.ForeColor = Color.White
        Label3.Location = New Point(48, 55)
        Label3.Name = "Label3"
        Label3.Size = New Size(55, 20)
        Label3.TabIndex = 26
        Label3.Text = "NAME"
        ' 
        ' GroupBox2
        ' 
        GroupBox2.Controls.Add(Label10)
        GroupBox2.Controls.Add(txt_service_fee)
        GroupBox2.Controls.Add(txt_EmpID)
        GroupBox2.Controls.Add(Cb_employeeName)
        GroupBox2.Controls.Add(Label8)
        GroupBox2.Controls.Add(Label7)
        GroupBox2.Dock = DockStyle.Bottom
        GroupBox2.ForeColor = Color.White
        GroupBox2.Location = New Point(0, 498)
        GroupBox2.Name = "GroupBox2"
        GroupBox2.Size = New Size(1032, 114)
        GroupBox2.TabIndex = 1
        GroupBox2.TabStop = False
        GroupBox2.Text = "EMPLOYEE DETAILS"
        ' 
        ' Label10
        ' 
        Label10.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        Label10.AutoSize = True
        Label10.Location = New Point(564, 75)
        Label10.Name = "Label10"
        Label10.Size = New Size(71, 15)
        Label10.TabIndex = 31
        Label10.Text = "SERVICE FEE"
        ' 
        ' txt_service_fee
        ' 
        txt_service_fee.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Right
        txt_service_fee.Location = New Point(699, 69)
        txt_service_fee.Name = "txt_service_fee"
        txt_service_fee.Size = New Size(230, 23)
        txt_service_fee.TabIndex = 30
        ' 
        ' txt_EmpID
        ' 
        txt_EmpID.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Right
        txt_EmpID.Location = New Point(699, 19)
        txt_EmpID.Name = "txt_EmpID"
        txt_EmpID.Size = New Size(224, 23)
        txt_EmpID.TabIndex = 29
        ' 
        ' Cb_employeeName
        ' 
        Cb_employeeName.AutoCompleteMode = AutoCompleteMode.Suggest
        Cb_employeeName.AutoCompleteSource = AutoCompleteSource.ListItems
        Cb_employeeName.FormattingEnabled = True
        Cb_employeeName.Location = New Point(191, 22)
        Cb_employeeName.Name = "Cb_employeeName"
        Cb_employeeName.Size = New Size(223, 23)
        Cb_employeeName.TabIndex = 28
        ' 
        ' Label8
        ' 
        Label8.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        Label8.AutoSize = True
        Label8.BackColor = Color.Transparent
        Label8.Font = New Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label8.ForeColor = Color.White
        Label8.Location = New Point(653, 25)
        Label8.Name = "Label8"
        Label8.Size = New Size(26, 20)
        Label8.TabIndex = 27
        Label8.Text = "ID"
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.BackColor = Color.Transparent
        Label7.Font = New Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label7.ForeColor = Color.White
        Label7.Location = New Point(46, 25)
        Label7.Name = "Label7"
        Label7.Size = New Size(55, 20)
        Label7.TabIndex = 26
        Label7.Text = "NAME"
        ' 
        ' GroupBox1
        ' 
        GroupBox1.Controls.Add(add_btn)
        GroupBox1.Controls.Add(CLEAR)
        GroupBox1.Controls.Add(clear_btn)
        GroupBox1.Controls.Add(lbl_stock)
        GroupBox1.Controls.Add(GroupBox4)
        GroupBox1.Controls.Add(Cb_warranty)
        GroupBox1.Controls.Add(txt_price)
        GroupBox1.Controls.Add(txt_quantity)
        GroupBox1.Controls.Add(Cb_Products)
        GroupBox1.Controls.Add(Label9)
        GroupBox1.Controls.Add(Label2)
        GroupBox1.Controls.Add(Label1)
        GroupBox1.Controls.Add(lbl_name_sup)
        GroupBox1.Controls.Add(transaction_datagridview)
        GroupBox1.Dock = DockStyle.Top
        GroupBox1.ForeColor = Color.White
        GroupBox1.Location = New Point(0, 0)
        GroupBox1.Name = "GroupBox1"
        GroupBox1.Size = New Size(1032, 313)
        GroupBox1.TabIndex = 0
        GroupBox1.TabStop = False
        GroupBox1.Text = "PRODUCT DETAILS"
        ' 
        ' add_btn
        ' 
        add_btn.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Right
        add_btn.AutoSize = True
        add_btn.BackColor = Color.White
        add_btn.BackgroundImageLayout = ImageLayout.Center
        add_btn.Location = New Point(992, 137)
        add_btn.Name = "add_btn"
        add_btn.Size = New Size(31, 27)
        add_btn.TabIndex = 35
        add_btn.UseVisualStyleBackColor = False
        ' 
        ' CLEAR
        ' 
        CLEAR.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Right
        CLEAR.AutoSize = True
        CLEAR.Font = New Font("Microsoft Sans Serif", 8.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        CLEAR.Location = New Point(989, 69)
        CLEAR.Name = "CLEAR"
        CLEAR.Size = New Size(42, 13)
        CLEAR.TabIndex = 34
        CLEAR.Text = "CLEAR"
        ' 
        ' clear_btn
        ' 
        clear_btn.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Right
        clear_btn.AutoSize = True
        clear_btn.BackColor = Color.White
        clear_btn.BackgroundImageLayout = ImageLayout.Center
        clear_btn.Location = New Point(992, 37)
        clear_btn.Name = "clear_btn"
        clear_btn.Size = New Size(32, 29)
        clear_btn.TabIndex = 33
        clear_btn.UseVisualStyleBackColor = False
        ' 
        ' lbl_stock
        ' 
        lbl_stock.AutoSize = True
        lbl_stock.Location = New Point(456, 256)
        lbl_stock.Name = "lbl_stock"
        lbl_stock.Size = New Size(48, 15)
        lbl_stock.TabIndex = 32
        lbl_stock.Text = "STOCKS"
        ' 
        ' GroupBox4
        ' 
        GroupBox4.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        GroupBox4.Controls.Add(Total_cost)
        GroupBox4.ForeColor = Color.White
        GroupBox4.Location = New Point(740, 211)
        GroupBox4.Name = "GroupBox4"
        GroupBox4.Size = New Size(200, 52)
        GroupBox4.TabIndex = 31
        GroupBox4.TabStop = False
        GroupBox4.Text = "TOTAL COST"
        ' 
        ' Total_cost
        ' 
        Total_cost.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        Total_cost.AutoSize = True
        Total_cost.Font = New Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Total_cost.Location = New Point(8, 22)
        Total_cost.Name = "Total_cost"
        Total_cost.Size = New Size(24, 20)
        Total_cost.TabIndex = 0
        Total_cost.Text = " 0"
        ' 
        ' Cb_warranty
        ' 
        Cb_warranty.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Right
        Cb_warranty.AutoCompleteMode = AutoCompleteMode.Suggest
        Cb_warranty.AutoCompleteSource = AutoCompleteSource.ListItems
        Cb_warranty.FormattingEnabled = True
        Cb_warranty.Location = New Point(742, 170)
        Cb_warranty.Name = "Cb_warranty"
        Cb_warranty.Size = New Size(223, 23)
        Cb_warranty.TabIndex = 30
        ' 
        ' txt_price
        ' 
        txt_price.Location = New Point(191, 253)
        txt_price.Name = "txt_price"
        txt_price.Size = New Size(224, 23)
        txt_price.TabIndex = 29
        ' 
        ' txt_quantity
        ' 
        txt_quantity.Location = New Point(190, 212)
        txt_quantity.Name = "txt_quantity"
        txt_quantity.Size = New Size(224, 23)
        txt_quantity.TabIndex = 28
        ' 
        ' Cb_Products
        ' 
        Cb_Products.AutoCompleteMode = AutoCompleteMode.Suggest
        Cb_Products.AutoCompleteSource = AutoCompleteSource.ListItems
        Cb_Products.FormattingEnabled = True
        Cb_Products.Location = New Point(191, 170)
        Cb_Products.Name = "Cb_Products"
        Cb_Products.Size = New Size(293, 23)
        Cb_Products.TabIndex = 27
        ' 
        ' Label9
        ' 
        Label9.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        Label9.AutoSize = True
        Label9.BackColor = Color.Transparent
        Label9.Font = New Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label9.ForeColor = Color.White
        Label9.Location = New Point(607, 170)
        Label9.Name = "Label9"
        Label9.Size = New Size(101, 20)
        Label9.TabIndex = 26
        Label9.Text = "WARRANTY"
        ' 
        ' Label2
        ' 
        Label2.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left
        Label2.AutoSize = True
        Label2.BackColor = Color.Transparent
        Label2.Font = New Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label2.ForeColor = Color.White
        Label2.Location = New Point(47, 256)
        Label2.Name = "Label2"
        Label2.Size = New Size(58, 20)
        Label2.TabIndex = 25
        Label2.Text = "PRICE"
        ' 
        ' Label1
        ' 
        Label1.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left
        Label1.AutoSize = True
        Label1.BackColor = Color.Transparent
        Label1.Font = New Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label1.ForeColor = Color.White
        Label1.Location = New Point(47, 212)
        Label1.Name = "Label1"
        Label1.Size = New Size(89, 20)
        Label1.TabIndex = 24
        Label1.Text = "QUANTITY"
        ' 
        ' lbl_name_sup
        ' 
        lbl_name_sup.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left
        lbl_name_sup.AutoSize = True
        lbl_name_sup.BackColor = Color.Transparent
        lbl_name_sup.Font = New Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lbl_name_sup.ForeColor = Color.White
        lbl_name_sup.Location = New Point(47, 170)
        lbl_name_sup.Name = "lbl_name_sup"
        lbl_name_sup.Size = New Size(137, 20)
        lbl_name_sup.TabIndex = 23
        lbl_name_sup.Text = "PRODUCT NAME"
        ' 
        ' transaction_datagridview
        ' 
        transaction_datagridview.AllowUserToAddRows = False
        transaction_datagridview.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        transaction_datagridview.BackgroundColor = Color.FromArgb(CByte(30), CByte(39), CByte(46))
        DataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle1.BackColor = Color.FromArgb(CByte(30), CByte(39), CByte(46))
        DataGridViewCellStyle1.Font = New Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        DataGridViewCellStyle1.ForeColor = Color.White
        DataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = DataGridViewTriState.True
        transaction_datagridview.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        transaction_datagridview.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        transaction_datagridview.Columns.AddRange(New DataGridViewColumn() {dt_id, dt_product_name, dt_quantity, dt_price, dt_warranty, dt_warranty_coverage, dt_total})
        DataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle2.BackColor = Color.FromArgb(CByte(30), CByte(39), CByte(46))
        DataGridViewCellStyle2.Font = New Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        DataGridViewCellStyle2.ForeColor = Color.White
        DataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = DataGridViewTriState.False
        transaction_datagridview.DefaultCellStyle = DataGridViewCellStyle2
        transaction_datagridview.GridColor = Color.White
        transaction_datagridview.Location = New Point(46, 37)
        transaction_datagridview.Name = "transaction_datagridview"
        transaction_datagridview.ReadOnly = True
        DataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle3.BackColor = Color.FromArgb(CByte(30), CByte(39), CByte(46))
        DataGridViewCellStyle3.Font = New Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        DataGridViewCellStyle3.ForeColor = Color.White
        DataGridViewCellStyle3.SelectionBackColor = SystemColors.Highlight
        DataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = DataGridViewTriState.True
        transaction_datagridview.RowHeadersDefaultCellStyle = DataGridViewCellStyle3
        transaction_datagridview.RowHeadersVisible = False
        transaction_datagridview.Size = New Size(940, 127)
        transaction_datagridview.TabIndex = 22
        ' 
        ' dt_id
        ' 
        dt_id.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
        dt_id.HeaderText = "ID"
        dt_id.Name = "dt_id"
        dt_id.ReadOnly = True
        dt_id.Width = 51
        ' 
        ' dt_product_name
        ' 
        dt_product_name.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
        dt_product_name.HeaderText = "PRODUCT NAME"
        dt_product_name.Name = "dt_product_name"
        dt_product_name.ReadOnly = True
        ' 
        ' dt_quantity
        ' 
        dt_quantity.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
        dt_quantity.HeaderText = "QUANTITY"
        dt_quantity.Name = "dt_quantity"
        dt_quantity.ReadOnly = True
        dt_quantity.Width = 114
        ' 
        ' dt_price
        ' 
        dt_price.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
        dt_price.HeaderText = "PRICE"
        dt_price.Name = "dt_price"
        dt_price.ReadOnly = True
        dt_price.Width = 83
        ' 
        ' dt_warranty
        ' 
        dt_warranty.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
        dt_warranty.HeaderText = "WARRANTY DURATION"
        dt_warranty.Name = "dt_warranty"
        dt_warranty.ReadOnly = True
        ' 
        ' dt_warranty_coverage
        ' 
        dt_warranty_coverage.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
        dt_warranty_coverage.HeaderText = "WARRANTY COVERAGE"
        dt_warranty_coverage.Name = "dt_warranty_coverage"
        dt_warranty_coverage.ReadOnly = True
        ' 
        ' dt_total
        ' 
        dt_total.HeaderText = "TOTAL"
        dt_total.Name = "dt_total"
        dt_total.ReadOnly = True
        ' 
        ' Print_btn
        ' 
        Print_btn.Anchor = AnchorStyles.Top
        Print_btn.BackColor = Color.FromArgb(CByte(30), CByte(39), CByte(46))
        Print_btn.FlatStyle = FlatStyle.Flat
        Print_btn.ForeColor = Color.White
        Print_btn.Location = New Point(552, 666)
        Print_btn.Name = "Print_btn"
        Print_btn.Size = New Size(111, 53)
        Print_btn.TabIndex = 12
        Print_btn.Text = "PRINT"
        Print_btn.UseVisualStyleBackColor = False
        ' 
        ' History
        ' 
        History.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        History.BackColor = Color.FromArgb(CByte(30), CByte(39), CByte(46))
        History.FlatStyle = FlatStyle.Popup
        History.Font = New Font("Microsoft Sans Serif", 14.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        History.ForeColor = Color.White
        History.Location = New Point(983, 9)
        History.Name = "History"
        History.Size = New Size(113, 35)
        History.TabIndex = 13
        History.Text = "HISTORY"
        History.UseVisualStyleBackColor = False
        ' 
        ' TRANSACTION
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackgroundImage = My.Resources.Resources.backgroud
        BackgroundImageLayout = ImageLayout.Center
        Controls.Add(History)
        Controls.Add(Print_btn)
        Controls.Add(Panel1)
        Controls.Add(Lbl_transaction)
        DoubleBuffered = True
        Name = "TRANSACTION"
        Size = New Size(1149, 788)
        Panel1.ResumeLayout(False)
        GroupBox3.ResumeLayout(False)
        GroupBox3.PerformLayout()
        GroupBox2.ResumeLayout(False)
        GroupBox2.PerformLayout()
        GroupBox1.ResumeLayout(False)
        GroupBox1.PerformLayout()
        GroupBox4.ResumeLayout(False)
        GroupBox4.PerformLayout()
        CType(transaction_datagridview, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Lbl_transaction As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents BTN_Cbrefresh As Button
    Friend WithEvents Label11 As Label
    Friend WithEvents txt_Custname As ComboBox
    Friend WithEvents txt_custnumber As TextBox
    Friend WithEvents txt_custemail As TextBox
    Friend WithEvents txt_custaddress As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents Label10 As Label
    Friend WithEvents txt_service_fee As TextBox
    Friend WithEvents txt_EmpID As TextBox
    Friend WithEvents Cb_employeeName As ComboBox
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents add_btn As Button
    Friend WithEvents CLEAR As Label
    Friend WithEvents clear_btn As Button
    Friend WithEvents lbl_stock As Label
    Friend WithEvents GroupBox4 As GroupBox
    Friend WithEvents Total_cost As Label
    Friend WithEvents Cb_warranty As ComboBox
    Friend WithEvents txt_price As TextBox
    Friend WithEvents txt_quantity As TextBox
    Friend WithEvents Cb_Products As ComboBox
    Friend WithEvents Label9 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents lbl_name_sup As Label
    Friend WithEvents transaction_datagridview As DataGridView
    Friend WithEvents dt_id As DataGridViewTextBoxColumn
    Friend WithEvents dt_product_name As DataGridViewTextBoxColumn
    Friend WithEvents dt_quantity As DataGridViewTextBoxColumn
    Friend WithEvents dt_price As DataGridViewTextBoxColumn
    Friend WithEvents dt_warranty As DataGridViewTextBoxColumn
    Friend WithEvents dt_warranty_coverage As DataGridViewTextBoxColumn
    Friend WithEvents dt_total As DataGridViewTextBoxColumn
    Friend WithEvents Print_btn As Button
    Friend WithEvents History As Button

End Class
