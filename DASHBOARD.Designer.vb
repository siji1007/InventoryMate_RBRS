<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class DASHBOARD
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
        Panel1 = New Panel()
        Btn_logout = New Button()
        Btn_transaction = New Button()
        Btn_employee = New Button()
        Btn_supplier = New Button()
        Btn_customer = New Button()
        Btn_warranty = New Button()
        Btn_product = New Button()
        Btn_home = New Button()
        PictureBox1 = New PictureBox()
        Panel2 = New Panel()
        Panel3 = New Panel()
        txt_name = New Label()
        Panel_Contents = New Panel()
        Panel1.SuspendLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        Panel3.SuspendLayout()
        SuspendLayout()
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = SystemColors.ButtonHighlight
        Panel1.Controls.Add(Btn_logout)
        Panel1.Controls.Add(Btn_transaction)
        Panel1.Controls.Add(Btn_employee)
        Panel1.Controls.Add(Btn_supplier)
        Panel1.Controls.Add(Btn_customer)
        Panel1.Controls.Add(Btn_warranty)
        Panel1.Controls.Add(Btn_product)
        Panel1.Controls.Add(Btn_home)
        Panel1.Controls.Add(PictureBox1)
        Panel1.Controls.Add(Panel2)
        Panel1.Dock = DockStyle.Left
        Panel1.Location = New Point(0, 0)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(226, 786)
        Panel1.TabIndex = 0
        ' 
        ' Btn_logout
        ' 
        Btn_logout.Anchor = AnchorStyles.Bottom Or AnchorStyles.Left
        Btn_logout.BackColor = Color.White
        Btn_logout.FlatAppearance.BorderSize = 0
        Btn_logout.FlatStyle = FlatStyle.Flat
        Btn_logout.Font = New Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Btn_logout.Image = My.Resources.Resources.leave
        Btn_logout.ImageAlign = ContentAlignment.MiddleLeft
        Btn_logout.Location = New Point(-1, 734)
        Btn_logout.Name = "Btn_logout"
        Btn_logout.Padding = New Padding(10, 0, 0, 0)
        Btn_logout.Size = New Size(227, 52)
        Btn_logout.TabIndex = 9
        Btn_logout.Text = "Log out"
        Btn_logout.TextAlign = ContentAlignment.MiddleLeft
        Btn_logout.TextImageRelation = TextImageRelation.ImageBeforeText
        Btn_logout.UseVisualStyleBackColor = False
        ' 
        ' Btn_transaction
        ' 
        Btn_transaction.BackColor = Color.White
        Btn_transaction.FlatAppearance.BorderSize = 0
        Btn_transaction.FlatStyle = FlatStyle.Flat
        Btn_transaction.Font = New Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Btn_transaction.Image = My.Resources.Resources.transaction
        Btn_transaction.ImageAlign = ContentAlignment.MiddleLeft
        Btn_transaction.Location = New Point(0, 590)
        Btn_transaction.Name = "Btn_transaction"
        Btn_transaction.Padding = New Padding(10, 0, 0, 0)
        Btn_transaction.Size = New Size(226, 55)
        Btn_transaction.TabIndex = 8
        Btn_transaction.Text = "Transaction"
        Btn_transaction.TextAlign = ContentAlignment.MiddleLeft
        Btn_transaction.TextImageRelation = TextImageRelation.ImageBeforeText
        Btn_transaction.UseVisualStyleBackColor = False
        ' 
        ' Btn_employee
        ' 
        Btn_employee.BackColor = Color.White
        Btn_employee.FlatAppearance.BorderSize = 0
        Btn_employee.FlatStyle = FlatStyle.Flat
        Btn_employee.Font = New Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Btn_employee.Image = My.Resources.Resources.business_people
        Btn_employee.ImageAlign = ContentAlignment.MiddleLeft
        Btn_employee.Location = New Point(0, 532)
        Btn_employee.Name = "Btn_employee"
        Btn_employee.Padding = New Padding(10, 0, 0, 0)
        Btn_employee.Size = New Size(226, 55)
        Btn_employee.TabIndex = 7
        Btn_employee.Text = "Employee"
        Btn_employee.TextAlign = ContentAlignment.MiddleLeft
        Btn_employee.TextImageRelation = TextImageRelation.ImageBeforeText
        Btn_employee.UseVisualStyleBackColor = False
        ' 
        ' Btn_supplier
        ' 
        Btn_supplier.BackColor = Color.White
        Btn_supplier.FlatAppearance.BorderSize = 0
        Btn_supplier.FlatStyle = FlatStyle.Flat
        Btn_supplier.Font = New Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Btn_supplier.Image = My.Resources.Resources.hotel_supplier
        Btn_supplier.ImageAlign = ContentAlignment.MiddleLeft
        Btn_supplier.Location = New Point(0, 474)
        Btn_supplier.Name = "Btn_supplier"
        Btn_supplier.Padding = New Padding(10, 0, 0, 0)
        Btn_supplier.Size = New Size(226, 55)
        Btn_supplier.TabIndex = 6
        Btn_supplier.Text = "Supplier"
        Btn_supplier.TextAlign = ContentAlignment.MiddleLeft
        Btn_supplier.TextImageRelation = TextImageRelation.ImageBeforeText
        Btn_supplier.UseVisualStyleBackColor = False
        ' 
        ' Btn_customer
        ' 
        Btn_customer.BackColor = Color.White
        Btn_customer.FlatAppearance.BorderSize = 0
        Btn_customer.FlatStyle = FlatStyle.Flat
        Btn_customer.Font = New Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Btn_customer.Image = My.Resources.Resources.customer
        Btn_customer.ImageAlign = ContentAlignment.MiddleLeft
        Btn_customer.Location = New Point(0, 416)
        Btn_customer.Name = "Btn_customer"
        Btn_customer.Padding = New Padding(10, 0, 0, 0)
        Btn_customer.Size = New Size(226, 55)
        Btn_customer.TabIndex = 5
        Btn_customer.Text = "Customer"
        Btn_customer.TextAlign = ContentAlignment.MiddleLeft
        Btn_customer.TextImageRelation = TextImageRelation.ImageBeforeText
        Btn_customer.UseVisualStyleBackColor = False
        ' 
        ' Btn_warranty
        ' 
        Btn_warranty.BackColor = Color.White
        Btn_warranty.FlatAppearance.BorderSize = 0
        Btn_warranty.FlatStyle = FlatStyle.Flat
        Btn_warranty.Font = New Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Btn_warranty.Image = My.Resources.Resources.guarantee
        Btn_warranty.ImageAlign = ContentAlignment.MiddleLeft
        Btn_warranty.Location = New Point(0, 358)
        Btn_warranty.Name = "Btn_warranty"
        Btn_warranty.Padding = New Padding(10, 0, 0, 0)
        Btn_warranty.Size = New Size(226, 55)
        Btn_warranty.TabIndex = 4
        Btn_warranty.Text = "Warranty"
        Btn_warranty.TextAlign = ContentAlignment.MiddleLeft
        Btn_warranty.TextImageRelation = TextImageRelation.ImageBeforeText
        Btn_warranty.UseVisualStyleBackColor = False
        ' 
        ' Btn_product
        ' 
        Btn_product.BackColor = Color.White
        Btn_product.FlatAppearance.BorderSize = 0
        Btn_product.FlatStyle = FlatStyle.Flat
        Btn_product.Font = New Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Btn_product.Image = My.Resources.Resources.order
        Btn_product.ImageAlign = ContentAlignment.MiddleLeft
        Btn_product.Location = New Point(-1, 300)
        Btn_product.Name = "Btn_product"
        Btn_product.Padding = New Padding(10, 0, 0, 0)
        Btn_product.Size = New Size(223, 55)
        Btn_product.TabIndex = 3
        Btn_product.Text = "Product"
        Btn_product.TextAlign = ContentAlignment.MiddleLeft
        Btn_product.TextImageRelation = TextImageRelation.ImageBeforeText
        Btn_product.UseVisualStyleBackColor = False
        ' 
        ' Btn_home
        ' 
        Btn_home.BackColor = Color.White
        Btn_home.FlatAppearance.BorderSize = 0
        Btn_home.FlatStyle = FlatStyle.Flat
        Btn_home.Font = New Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Btn_home.Image = My.Resources.Resources.home
        Btn_home.ImageAlign = ContentAlignment.MiddleLeft
        Btn_home.Location = New Point(-1, 242)
        Btn_home.Name = "Btn_home"
        Btn_home.Padding = New Padding(10, 0, 0, 0)
        Btn_home.Size = New Size(226, 55)
        Btn_home.TabIndex = 2
        Btn_home.Text = "Home"
        Btn_home.TextAlign = ContentAlignment.MiddleLeft
        Btn_home.TextImageRelation = TextImageRelation.ImageBeforeText
        Btn_home.UseVisualStyleBackColor = False
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Image = My.Resources.Resources.Slide_4_3___1
        PictureBox1.Location = New Point(0, 32)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(226, 159)
        PictureBox1.SizeMode = PictureBoxSizeMode.Zoom
        PictureBox1.TabIndex = 1
        PictureBox1.TabStop = False
        ' 
        ' Panel2
        ' 
        Panel2.BackColor = Color.FromArgb(CByte(30), CByte(39), CByte(46))
        Panel2.Dock = DockStyle.Top
        Panel2.Location = New Point(0, 0)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(226, 32)
        Panel2.TabIndex = 0
        ' 
        ' Panel3
        ' 
        Panel3.BackColor = Color.FromArgb(CByte(30), CByte(39), CByte(46))
        Panel3.Controls.Add(txt_name)
        Panel3.Dock = DockStyle.Top
        Panel3.Location = New Point(226, 0)
        Panel3.Name = "Panel3"
        Panel3.Size = New Size(586, 32)
        Panel3.TabIndex = 1
        ' 
        ' txt_name
        ' 
        txt_name.AutoSize = True
        txt_name.Dock = DockStyle.Right
        txt_name.Font = New Font("Microsoft Sans Serif", 14.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        txt_name.ForeColor = Color.White
        txt_name.Location = New Point(510, 0)
        txt_name.Name = "txt_name"
        txt_name.Padding = New Padding(5)
        txt_name.Size = New Size(76, 34)
        txt_name.TabIndex = 0
        txt_name.Text = "NAME"
        ' 
        ' Panel_Contents
        ' 
        Panel_Contents.Dock = DockStyle.Fill
        Panel_Contents.Location = New Point(226, 32)
        Panel_Contents.Name = "Panel_Contents"
        Panel_Contents.Size = New Size(586, 754)
        Panel_Contents.TabIndex = 2
        ' 
        ' DASHBOARD
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        Controls.Add(Panel_Contents)
        Controls.Add(Panel3)
        Controls.Add(Panel1)
        Name = "DASHBOARD"
        Size = New Size(812, 786)
        Panel1.ResumeLayout(False)
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        Panel3.ResumeLayout(False)
        Panel3.PerformLayout()
        ResumeLayout(False)
    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Panel_Contents As Panel
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Btn_home As Button
    Friend WithEvents Btn_transaction As Button
    Friend WithEvents Btn_employee As Button
    Friend WithEvents Btn_supplier As Button
    Friend WithEvents Btn_customer As Button
    Friend WithEvents Btn_warranty As Button
    Friend WithEvents Btn_product As Button
    Friend WithEvents Btn_logout As Button
    Friend WithEvents txt_name As Label

End Class
