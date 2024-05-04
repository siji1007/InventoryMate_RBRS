<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PURCHASE
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
        Btn_back = New Button()
        GroupBox1 = New GroupBox()
        prod_id = New Label()
        war_type = New Label()
        lbl_stock = New Label()
        Cb_Products = New ComboBox()
        add_btn = New Button()
        CLEAR = New Label()
        clear_btn = New Button()
        show_id = New Label()
        Label4 = New Label()
        Cb_warranty = New ComboBox()
        txt_price = New TextBox()
        txt_stocks = New TextBox()
        txt_product_color = New TextBox()
        txt_product_model = New TextBox()
        Label2 = New Label()
        Label1 = New Label()
        product_color_label = New Label()
        product_model_label = New Label()
        prod_name_label = New Label()
        dt_purchase = New DataGridView()
        prodID = New DataGridViewTextBoxColumn()
        prodName = New DataGridViewTextBoxColumn()
        prodModel = New DataGridViewTextBoxColumn()
        prodColor = New DataGridViewTextBoxColumn()
        prodStock = New DataGridViewTextBoxColumn()
        prodPrice = New DataGridViewTextBoxColumn()
        GroupBox2 = New GroupBox()
        Sup_ID = New Label()
        Cb_supplier = New ComboBox()
        Label3 = New Label()
        Label5 = New Label()
        Lbl_address = New Label()
        Lbl_storename = New Label()
        lbl_name_sup = New Label()
        txt_sup_cnumber = New TextBox()
        txt_sup_email = New TextBox()
        txt_sup_address = New TextBox()
        txt_store_name = New TextBox()
        Lbl_purchase = New Label()
        Btn_purchase = New Button()
        NewSupplier = New RadioButton()
        GroupBox1.SuspendLayout()
        CType(dt_purchase, ComponentModel.ISupportInitialize).BeginInit()
        GroupBox2.SuspendLayout()
        SuspendLayout()
        ' 
        ' Btn_back
        ' 
        Btn_back.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        Btn_back.BackgroundImageLayout = ImageLayout.Zoom
        Btn_back.FlatStyle = FlatStyle.Flat
        Btn_back.Image = My.Resources.Resources.arrow
        Btn_back.Location = New Point(1092, 0)
        Btn_back.Name = "Btn_back"
        Btn_back.Size = New Size(57, 53)
        Btn_back.TabIndex = 0
        Btn_back.UseVisualStyleBackColor = True
        ' 
        ' GroupBox1
        ' 
        GroupBox1.BackColor = Color.FromArgb(CByte(30), CByte(39), CByte(46))
        GroupBox1.Controls.Add(prod_id)
        GroupBox1.Controls.Add(war_type)
        GroupBox1.Controls.Add(lbl_stock)
        GroupBox1.Controls.Add(Cb_Products)
        GroupBox1.Controls.Add(add_btn)
        GroupBox1.Controls.Add(CLEAR)
        GroupBox1.Controls.Add(clear_btn)
        GroupBox1.Controls.Add(show_id)
        GroupBox1.Controls.Add(Label4)
        GroupBox1.Controls.Add(Cb_warranty)
        GroupBox1.Controls.Add(txt_price)
        GroupBox1.Controls.Add(txt_stocks)
        GroupBox1.Controls.Add(txt_product_color)
        GroupBox1.Controls.Add(txt_product_model)
        GroupBox1.Controls.Add(Label2)
        GroupBox1.Controls.Add(Label1)
        GroupBox1.Controls.Add(product_color_label)
        GroupBox1.Controls.Add(product_model_label)
        GroupBox1.Controls.Add(prod_name_label)
        GroupBox1.Controls.Add(dt_purchase)
        GroupBox1.Font = New Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        GroupBox1.ForeColor = Color.White
        GroupBox1.Location = New Point(16, 74)
        GroupBox1.Name = "GroupBox1"
        GroupBox1.Size = New Size(1119, 346)
        GroupBox1.TabIndex = 1
        GroupBox1.TabStop = False
        GroupBox1.Text = "PRODUCT DETAILS"
        ' 
        ' prod_id
        ' 
        prod_id.AutoSize = True
        prod_id.Location = New Point(491, 187)
        prod_id.Name = "prod_id"
        prod_id.Size = New Size(26, 20)
        prod_id.TabIndex = 54
        prod_id.Text = "ID"
        ' 
        ' war_type
        ' 
        war_type.AutoSize = True
        war_type.Location = New Point(762, 309)
        war_type.Name = "war_type"
        war_type.Size = New Size(111, 20)
        war_type.TabIndex = 53
        war_type.Text = "Warranty Type"
        ' 
        ' lbl_stock
        ' 
        lbl_stock.AutoSize = True
        lbl_stock.Location = New Point(465, 268)
        lbl_stock.Name = "lbl_stock"
        lbl_stock.Size = New Size(73, 20)
        lbl_stock.TabIndex = 51
        lbl_stock.Text = "STOCKS"
        ' 
        ' Cb_Products
        ' 
        Cb_Products.AutoCompleteMode = AutoCompleteMode.Suggest
        Cb_Products.AutoCompleteSource = AutoCompleteSource.ListItems
        Cb_Products.FormattingEnabled = True
        Cb_Products.Location = New Point(192, 181)
        Cb_Products.Name = "Cb_Products"
        Cb_Products.Size = New Size(293, 28)
        Cb_Products.TabIndex = 50
        ' 
        ' add_btn
        ' 
        add_btn.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Right
        add_btn.AutoSize = True
        add_btn.BackColor = Color.White
        add_btn.BackgroundImageLayout = ImageLayout.Center
        add_btn.Image = My.Resources.Resources.add
        add_btn.Location = New Point(1033, 144)
        add_btn.Name = "add_btn"
        add_btn.Size = New Size(31, 31)
        add_btn.TabIndex = 49
        add_btn.UseVisualStyleBackColor = False
        ' 
        ' CLEAR
        ' 
        CLEAR.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Right
        CLEAR.AutoSize = True
        CLEAR.Font = New Font("Microsoft Sans Serif", 8.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        CLEAR.Location = New Point(1030, 82)
        CLEAR.Name = "CLEAR"
        CLEAR.Size = New Size(42, 13)
        CLEAR.TabIndex = 48
        CLEAR.Text = "CLEAR"
        ' 
        ' clear_btn
        ' 
        clear_btn.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Right
        clear_btn.AutoSize = True
        clear_btn.BackColor = Color.White
        clear_btn.BackgroundImageLayout = ImageLayout.Center
        clear_btn.Image = My.Resources.Resources.remove_from_cart
        clear_btn.Location = New Point(1033, 50)
        clear_btn.Name = "clear_btn"
        clear_btn.Size = New Size(32, 29)
        clear_btn.TabIndex = 47
        clear_btn.UseVisualStyleBackColor = False
        ' 
        ' show_id
        ' 
        show_id.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        show_id.AutoSize = True
        show_id.Font = New Font("Microsoft Sans Serif", 11.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        show_id.Location = New Point(1017, 273)
        show_id.Name = "show_id"
        show_id.Size = New Size(24, 18)
        show_id.TabIndex = 46
        show_id.Text = "ID"
        ' 
        ' Label4
        ' 
        Label4.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left
        Label4.AutoSize = True
        Label4.BackColor = Color.Transparent
        Label4.Font = New Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label4.ForeColor = Color.White
        Label4.Location = New Point(682, 271)
        Label4.Name = "Label4"
        Label4.Size = New Size(73, 20)
        Label4.TabIndex = 45
        Label4.Text = "Warranty"
        ' 
        ' Cb_warranty
        ' 
        Cb_warranty.FormattingEnabled = True
        Cb_warranty.Location = New Point(761, 268)
        Cb_warranty.Name = "Cb_warranty"
        Cb_warranty.Size = New Size(230, 28)
        Cb_warranty.TabIndex = 44
        ' 
        ' txt_price
        ' 
        txt_price.Location = New Point(761, 223)
        txt_price.Name = "txt_price"
        txt_price.Size = New Size(230, 26)
        txt_price.TabIndex = 43
        ' 
        ' txt_stocks
        ' 
        txt_stocks.Location = New Point(761, 181)
        txt_stocks.Name = "txt_stocks"
        txt_stocks.Size = New Size(230, 26)
        txt_stocks.TabIndex = 42
        ' 
        ' txt_product_color
        ' 
        txt_product_color.Location = New Point(192, 265)
        txt_product_color.Name = "txt_product_color"
        txt_product_color.Size = New Size(230, 26)
        txt_product_color.TabIndex = 41
        ' 
        ' txt_product_model
        ' 
        txt_product_model.Location = New Point(192, 223)
        txt_product_model.Name = "txt_product_model"
        txt_product_model.Size = New Size(230, 26)
        txt_product_model.TabIndex = 40
        ' 
        ' Label2
        ' 
        Label2.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left
        Label2.AutoSize = True
        Label2.BackColor = Color.Transparent
        Label2.Font = New Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label2.ForeColor = Color.White
        Label2.Location = New Point(697, 226)
        Label2.Name = "Label2"
        Label2.Size = New Size(44, 20)
        Label2.TabIndex = 38
        Label2.Text = "Price"
        ' 
        ' Label1
        ' 
        Label1.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left
        Label1.AutoSize = True
        Label1.BackColor = Color.Transparent
        Label1.Font = New Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label1.ForeColor = Color.White
        Label1.Location = New Point(692, 184)
        Label1.Name = "Label1"
        Label1.Size = New Size(68, 20)
        Label1.TabIndex = 37
        Label1.Text = "Quantity"
        ' 
        ' product_color_label
        ' 
        product_color_label.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left
        product_color_label.AutoSize = True
        product_color_label.BackColor = Color.Transparent
        product_color_label.Font = New Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        product_color_label.ForeColor = SystemColors.ControlLightLight
        product_color_label.Location = New Point(76, 268)
        product_color_label.Name = "product_color_label"
        product_color_label.Size = New Size(105, 20)
        product_color_label.TabIndex = 36
        product_color_label.Text = "Product Color"
        ' 
        ' product_model_label
        ' 
        product_model_label.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left
        product_model_label.AutoSize = True
        product_model_label.BackColor = Color.Transparent
        product_model_label.Font = New Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        product_model_label.ForeColor = SystemColors.ControlLightLight
        product_model_label.Location = New Point(76, 226)
        product_model_label.Name = "product_model_label"
        product_model_label.Size = New Size(111, 20)
        product_model_label.TabIndex = 35
        product_model_label.Text = "Product Model"
        ' 
        ' prod_name_label
        ' 
        prod_name_label.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left
        prod_name_label.AutoSize = True
        prod_name_label.BackColor = Color.Transparent
        prod_name_label.Font = New Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        prod_name_label.ForeColor = SystemColors.ControlLightLight
        prod_name_label.Location = New Point(76, 184)
        prod_name_label.Name = "prod_name_label"
        prod_name_label.Size = New Size(110, 20)
        prod_name_label.TabIndex = 34
        prod_name_label.Text = "Product Name"
        ' 
        ' dt_purchase
        ' 
        dt_purchase.AllowUserToAddRows = False
        dt_purchase.BackgroundColor = Color.FromArgb(CByte(30), CByte(39), CByte(46))
        DataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle1.BackColor = Color.FromArgb(CByte(30), CByte(39), CByte(46))
        DataGridViewCellStyle1.Font = New Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        DataGridViewCellStyle1.ForeColor = Color.White
        DataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = DataGridViewTriState.True
        dt_purchase.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        dt_purchase.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dt_purchase.Columns.AddRange(New DataGridViewColumn() {prodID, prodName, prodModel, prodColor, prodStock, prodPrice})
        DataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle2.BackColor = Color.FromArgb(CByte(30), CByte(39), CByte(46))
        DataGridViewCellStyle2.Font = New Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        DataGridViewCellStyle2.ForeColor = Color.White
        DataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = DataGridViewTriState.False
        dt_purchase.DefaultCellStyle = DataGridViewCellStyle2
        dt_purchase.GridColor = Color.White
        dt_purchase.Location = New Point(82, 25)
        dt_purchase.Name = "dt_purchase"
        DataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle3.BackColor = SystemColors.Control
        DataGridViewCellStyle3.Font = New Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        DataGridViewCellStyle3.ForeColor = SystemColors.WindowText
        DataGridViewCellStyle3.SelectionBackColor = SystemColors.Highlight
        DataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = DataGridViewTriState.True
        dt_purchase.RowHeadersDefaultCellStyle = DataGridViewCellStyle3
        dt_purchase.RowHeadersVisible = False
        dt_purchase.Size = New Size(935, 150)
        dt_purchase.TabIndex = 0
        ' 
        ' prodID
        ' 
        prodID.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
        prodID.HeaderText = "ID"
        prodID.Name = "prodID"
        prodID.Width = 51
        ' 
        ' prodName
        ' 
        prodName.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
        prodName.HeaderText = "PRODUCT NAME"
        prodName.Name = "prodName"
        ' 
        ' prodModel
        ' 
        prodModel.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
        prodModel.HeaderText = "MODEL"
        prodModel.Name = "prodModel"
        ' 
        ' prodColor
        ' 
        prodColor.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
        prodColor.HeaderText = "COLOR"
        prodColor.Name = "prodColor"
        ' 
        ' prodStock
        ' 
        prodStock.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
        prodStock.HeaderText = "QUANTITY"
        prodStock.Name = "prodStock"
        ' 
        ' prodPrice
        ' 
        prodPrice.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
        prodPrice.HeaderText = "PRICE"
        prodPrice.Name = "prodPrice"
        ' 
        ' GroupBox2
        ' 
        GroupBox2.BackColor = Color.FromArgb(CByte(30), CByte(39), CByte(46))
        GroupBox2.Controls.Add(NewSupplier)
        GroupBox2.Controls.Add(Sup_ID)
        GroupBox2.Controls.Add(Cb_supplier)
        GroupBox2.Controls.Add(Label3)
        GroupBox2.Controls.Add(Label5)
        GroupBox2.Controls.Add(Lbl_address)
        GroupBox2.Controls.Add(Lbl_storename)
        GroupBox2.Controls.Add(lbl_name_sup)
        GroupBox2.Controls.Add(txt_sup_cnumber)
        GroupBox2.Controls.Add(txt_sup_email)
        GroupBox2.Controls.Add(txt_sup_address)
        GroupBox2.Controls.Add(txt_store_name)
        GroupBox2.Font = New Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        GroupBox2.ForeColor = Color.White
        GroupBox2.Location = New Point(18, 419)
        GroupBox2.Name = "GroupBox2"
        GroupBox2.Size = New Size(1119, 186)
        GroupBox2.TabIndex = 2
        GroupBox2.TabStop = False
        GroupBox2.Text = "SUPPLIER DETAILS"
        ' 
        ' Sup_ID
        ' 
        Sup_ID.AutoSize = True
        Sup_ID.Location = New Point(495, 46)
        Sup_ID.Name = "Sup_ID"
        Sup_ID.Size = New Size(26, 20)
        Sup_ID.TabIndex = 54
        Sup_ID.Text = "ID"
        ' 
        ' Cb_supplier
        ' 
        Cb_supplier.AutoCompleteMode = AutoCompleteMode.Suggest
        Cb_supplier.AutoCompleteSource = AutoCompleteSource.ListItems
        Cb_supplier.FormattingEnabled = True
        Cb_supplier.Location = New Point(192, 41)
        Cb_supplier.Name = "Cb_supplier"
        Cb_supplier.Size = New Size(293, 28)
        Cb_supplier.TabIndex = 53
        ' 
        ' Label3
        ' 
        Label3.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left
        Label3.AutoSize = True
        Label3.BackColor = Color.Transparent
        Label3.Font = New Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label3.ForeColor = Color.White
        Label3.Location = New Point(672, 86)
        Label3.Name = "Label3"
        Label3.Size = New Size(83, 20)
        Label3.TabIndex = 35
        Label3.Text = "CONTACT"
        ' 
        ' Label5
        ' 
        Label5.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left
        Label5.AutoSize = True
        Label5.BackColor = Color.Transparent
        Label5.Font = New Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label5.ForeColor = Color.White
        Label5.Location = New Point(672, 44)
        Label5.Name = "Label5"
        Label5.Size = New Size(58, 20)
        Label5.TabIndex = 34
        Label5.Text = "EMAIL"
        ' 
        ' Lbl_address
        ' 
        Lbl_address.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left
        Lbl_address.AutoSize = True
        Lbl_address.BackColor = Color.Transparent
        Lbl_address.Font = New Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Lbl_address.ForeColor = Color.White
        Lbl_address.Location = New Point(47, 131)
        Lbl_address.Name = "Lbl_address"
        Lbl_address.Size = New Size(89, 20)
        Lbl_address.TabIndex = 33
        Lbl_address.Text = "ADDRESS"
        ' 
        ' Lbl_storename
        ' 
        Lbl_storename.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left
        Lbl_storename.AutoSize = True
        Lbl_storename.BackColor = Color.Transparent
        Lbl_storename.Font = New Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Lbl_storename.ForeColor = Color.White
        Lbl_storename.Location = New Point(47, 89)
        Lbl_storename.Name = "Lbl_storename"
        Lbl_storename.Size = New Size(114, 20)
        Lbl_storename.TabIndex = 32
        Lbl_storename.Text = "STORE NAME"
        ' 
        ' lbl_name_sup
        ' 
        lbl_name_sup.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left
        lbl_name_sup.AutoSize = True
        lbl_name_sup.BackColor = Color.Transparent
        lbl_name_sup.Font = New Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lbl_name_sup.ForeColor = Color.White
        lbl_name_sup.Location = New Point(47, 47)
        lbl_name_sup.Name = "lbl_name_sup"
        lbl_name_sup.Size = New Size(139, 20)
        lbl_name_sup.TabIndex = 31
        lbl_name_sup.Text = "SUPPLIER NAME"
        ' 
        ' txt_sup_cnumber
        ' 
        txt_sup_cnumber.Location = New Point(761, 83)
        txt_sup_cnumber.Name = "txt_sup_cnumber"
        txt_sup_cnumber.Size = New Size(230, 26)
        txt_sup_cnumber.TabIndex = 30
        txt_sup_cnumber.Text = "+63"
        ' 
        ' txt_sup_email
        ' 
        txt_sup_email.Location = New Point(761, 41)
        txt_sup_email.Name = "txt_sup_email"
        txt_sup_email.PlaceholderText = "ex. RBRS2@gmail.com"
        txt_sup_email.Size = New Size(230, 26)
        txt_sup_email.TabIndex = 29
        ' 
        ' txt_sup_address
        ' 
        txt_sup_address.Location = New Point(192, 128)
        txt_sup_address.Name = "txt_sup_address"
        txt_sup_address.PlaceholderText = "ex. SM City Daet"
        txt_sup_address.Size = New Size(230, 26)
        txt_sup_address.TabIndex = 28
        ' 
        ' txt_store_name
        ' 
        txt_store_name.Location = New Point(192, 86)
        txt_store_name.Name = "txt_store_name"
        txt_store_name.PlaceholderText = "ex. RBRS Gadget Store"
        txt_store_name.Size = New Size(230, 26)
        txt_store_name.TabIndex = 27
        ' 
        ' Lbl_purchase
        ' 
        Lbl_purchase.AutoSize = True
        Lbl_purchase.BackColor = Color.Transparent
        Lbl_purchase.Font = New Font("Microsoft Sans Serif", 18F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Lbl_purchase.ForeColor = Color.White
        Lbl_purchase.Location = New Point(339, 24)
        Lbl_purchase.Name = "Lbl_purchase"
        Lbl_purchase.Size = New Size(448, 29)
        Lbl_purchase.TabIndex = 3
        Lbl_purchase.Text = "PURCHASE PRODUCT TRANSACTION"
        ' 
        ' Btn_purchase
        ' 
        Btn_purchase.BackColor = Color.FromArgb(CByte(30), CByte(39), CByte(46))
        Btn_purchase.ForeColor = Color.White
        Btn_purchase.Location = New Point(546, 611)
        Btn_purchase.Name = "Btn_purchase"
        Btn_purchase.Size = New Size(115, 64)
        Btn_purchase.TabIndex = 4
        Btn_purchase.Text = "PURCHASE "
        Btn_purchase.UseVisualStyleBackColor = False
        ' 
        ' NewSupplier
        ' 
        NewSupplier.AutoSize = True
        NewSupplier.Location = New Point(760, 127)
        NewSupplier.Name = "NewSupplier"
        NewSupplier.Size = New Size(211, 24)
        NewSupplier.TabIndex = 55
        NewSupplier.TabStop = True
        NewSupplier.Text = "INSERT NEW SUPPLIER"
        NewSupplier.UseVisualStyleBackColor = True
        ' 
        ' PURCHASE
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.Transparent
        BackgroundImage = My.Resources.Resources.backgroud
        BackgroundImageLayout = ImageLayout.Center
        Controls.Add(Btn_purchase)
        Controls.Add(Lbl_purchase)
        Controls.Add(GroupBox2)
        Controls.Add(GroupBox1)
        Controls.Add(Btn_back)
        DoubleBuffered = True
        Name = "PURCHASE"
        Size = New Size(1149, 788)
        GroupBox1.ResumeLayout(False)
        GroupBox1.PerformLayout()
        CType(dt_purchase, ComponentModel.ISupportInitialize).EndInit()
        GroupBox2.ResumeLayout(False)
        GroupBox2.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Btn_back As Button
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents Lbl_purchase As Label
    Friend WithEvents dt_purchase As DataGridView
    Friend WithEvents show_id As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Cb_warranty As ComboBox
    Friend WithEvents txt_price As TextBox
    Friend WithEvents txt_stocks As TextBox
    Friend WithEvents txt_product_color As TextBox
    Friend WithEvents txt_product_model As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents product_color_label As Label
    Friend WithEvents product_model_label As Label
    Friend WithEvents prod_name_label As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Lbl_address As Label
    Friend WithEvents Lbl_storename As Label
    Friend WithEvents lbl_name_sup As Label
    Friend WithEvents txt_sup_cnumber As TextBox
    Friend WithEvents txt_sup_email As TextBox
    Friend WithEvents txt_sup_address As TextBox
    Friend WithEvents txt_store_name As TextBox
    Friend WithEvents Btn_purchase As Button
    Friend WithEvents add_btn As Button
    Friend WithEvents CLEAR As Label
    Friend WithEvents clear_btn As Button
    Friend WithEvents Cb_Products As ComboBox
    Friend WithEvents lbl_stock As Label
    Friend WithEvents Cb_supplier As ComboBox
    Friend WithEvents prodID As DataGridViewTextBoxColumn
    Friend WithEvents prodName As DataGridViewTextBoxColumn
    Friend WithEvents prodModel As DataGridViewTextBoxColumn
    Friend WithEvents prodColor As DataGridViewTextBoxColumn
    Friend WithEvents prodStock As DataGridViewTextBoxColumn
    Friend WithEvents prodPrice As DataGridViewTextBoxColumn
    Friend WithEvents war_type As Label
    Friend WithEvents Sup_ID As Label
    Friend WithEvents prod_id As Label
    Friend WithEvents NewSupplier As RadioButton

End Class
