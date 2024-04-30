<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SUPPLIER
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(SUPPLIER))
        Lbl_supplier = New Label()
        sup_datagridview = New DataGridView()
        supp_id = New DataGridViewTextBoxColumn()
        supp_name = New DataGridViewTextBoxColumn()
        supp_store = New DataGridViewTextBoxColumn()
        supp_address = New DataGridViewTextBoxColumn()
        supp_email = New DataGridViewTextBoxColumn()
        supp_cnumber = New DataGridViewTextBoxColumn()
        Btn_clear = New Button()
        Btn_delete = New Button()
        Btn_update = New Button()
        Btn_create = New Button()
        Label2 = New Label()
        Label1 = New Label()
        Lbl_address = New Label()
        Lbl_storename = New Label()
        lbl_name_sup = New Label()
        txt_sup_cnumber = New TextBox()
        txt_sup_email = New TextBox()
        txt_sup_address = New TextBox()
        txt_store_name = New TextBox()
        txt_sup_name = New TextBox()
        Label5 = New Label()
        Search_supplier = New TextBox()
        CType(sup_datagridview, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Lbl_supplier
        ' 
        Lbl_supplier.AutoSize = True
        Lbl_supplier.BackColor = Color.Transparent
        Lbl_supplier.Font = New Font("Microsoft Sans Serif", 18F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Lbl_supplier.ForeColor = Color.White
        Lbl_supplier.Location = New Point(601, 26)
        Lbl_supplier.Name = "Lbl_supplier"
        Lbl_supplier.Size = New Size(130, 29)
        Lbl_supplier.TabIndex = 2
        Lbl_supplier.Text = "SUPPLIER"
        ' 
        ' sup_datagridview
        ' 
        sup_datagridview.AllowUserToAddRows = False
        sup_datagridview.AllowUserToResizeRows = False
        sup_datagridview.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        sup_datagridview.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.ColumnHeader
        sup_datagridview.BackgroundColor = Color.FromArgb(CByte(30), CByte(39), CByte(46))
        sup_datagridview.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single
        DataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle1.BackColor = Color.FromArgb(CByte(30), CByte(39), CByte(46))
        DataGridViewCellStyle1.Font = New Font("Microsoft Sans Serif", 14.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        DataGridViewCellStyle1.ForeColor = Color.White
        DataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = DataGridViewTriState.True
        sup_datagridview.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        sup_datagridview.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        sup_datagridview.Columns.AddRange(New DataGridViewColumn() {supp_id, supp_name, supp_store, supp_address, supp_email, supp_cnumber})
        DataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle2.BackColor = Color.FromArgb(CByte(30), CByte(39), CByte(46))
        DataGridViewCellStyle2.Font = New Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        DataGridViewCellStyle2.ForeColor = Color.White
        DataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = DataGridViewTriState.False
        sup_datagridview.DefaultCellStyle = DataGridViewCellStyle2
        sup_datagridview.GridColor = Color.White
        sup_datagridview.Location = New Point(12, 127)
        sup_datagridview.Name = "sup_datagridview"
        sup_datagridview.ReadOnly = True
        sup_datagridview.RightToLeft = RightToLeft.No
        sup_datagridview.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single
        sup_datagridview.RowHeadersVisible = False
        sup_datagridview.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing
        DataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle3.SelectionBackColor = SystemColors.Highlight
        DataGridViewCellStyle3.SelectionForeColor = Color.White
        sup_datagridview.RowsDefaultCellStyle = DataGridViewCellStyle3
        sup_datagridview.ScrollBars = ScrollBars.Vertical
        sup_datagridview.Size = New Size(1109, 301)
        sup_datagridview.StandardTab = True
        sup_datagridview.TabIndex = 3
        ' 
        ' supp_id
        ' 
        supp_id.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
        supp_id.HeaderText = "ID"
        supp_id.Name = "supp_id"
        supp_id.ReadOnly = True
        supp_id.Width = 52
        ' 
        ' supp_name
        ' 
        supp_name.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
        supp_name.HeaderText = "NAME"
        supp_name.Name = "supp_name"
        supp_name.ReadOnly = True
        ' 
        ' supp_store
        ' 
        supp_store.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
        supp_store.HeaderText = "STORE NAME"
        supp_store.Name = "supp_store"
        supp_store.ReadOnly = True
        ' 
        ' supp_address
        ' 
        supp_address.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
        supp_address.HeaderText = "ADDRESS"
        supp_address.Name = "supp_address"
        supp_address.ReadOnly = True
        ' 
        ' supp_email
        ' 
        supp_email.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
        supp_email.HeaderText = "EMAIL"
        supp_email.Name = "supp_email"
        supp_email.ReadOnly = True
        ' 
        ' supp_cnumber
        ' 
        supp_cnumber.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
        supp_cnumber.HeaderText = "CONTACT NUMBER"
        supp_cnumber.Name = "supp_cnumber"
        supp_cnumber.ReadOnly = True
        ' 
        ' Btn_clear
        ' 
        Btn_clear.Anchor = AnchorStyles.Bottom Or AnchorStyles.Right
        Btn_clear.Location = New Point(1011, 709)
        Btn_clear.Name = "Btn_clear"
        Btn_clear.Size = New Size(111, 53)
        Btn_clear.TabIndex = 29
        Btn_clear.Text = "CLEAR"
        Btn_clear.UseVisualStyleBackColor = True
        ' 
        ' Btn_delete
        ' 
        Btn_delete.Anchor = AnchorStyles.Bottom Or AnchorStyles.Right
        Btn_delete.Location = New Point(788, 709)
        Btn_delete.Name = "Btn_delete"
        Btn_delete.Size = New Size(111, 53)
        Btn_delete.TabIndex = 28
        Btn_delete.Text = "DELETE"
        Btn_delete.UseVisualStyleBackColor = True
        ' 
        ' Btn_update
        ' 
        Btn_update.Anchor = AnchorStyles.Bottom Or AnchorStyles.Left
        Btn_update.Location = New Point(265, 709)
        Btn_update.Name = "Btn_update"
        Btn_update.Size = New Size(111, 53)
        Btn_update.TabIndex = 27
        Btn_update.Text = "UPDATE"
        Btn_update.UseVisualStyleBackColor = True
        ' 
        ' Btn_create
        ' 
        Btn_create.Anchor = AnchorStyles.Bottom Or AnchorStyles.Left
        Btn_create.Location = New Point(26, 709)
        Btn_create.Name = "Btn_create"
        Btn_create.Size = New Size(111, 53)
        Btn_create.TabIndex = 26
        Btn_create.Text = "CREATE"
        Btn_create.UseVisualStyleBackColor = True
        ' 
        ' Label2
        ' 
        Label2.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left
        Label2.AutoSize = True
        Label2.BackColor = Color.Transparent
        Label2.Font = New Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label2.ForeColor = Color.Black
        Label2.Location = New Point(641, 508)
        Label2.Name = "Label2"
        Label2.Size = New Size(83, 20)
        Label2.TabIndex = 25
        Label2.Text = "CONTACT"
        ' 
        ' Label1
        ' 
        Label1.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left
        Label1.AutoSize = True
        Label1.BackColor = Color.Transparent
        Label1.Font = New Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label1.ForeColor = Color.Black
        Label1.Location = New Point(641, 466)
        Label1.Name = "Label1"
        Label1.Size = New Size(58, 20)
        Label1.TabIndex = 24
        Label1.Text = "EMAIL"
        ' 
        ' Lbl_address
        ' 
        Lbl_address.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left
        Lbl_address.AutoSize = True
        Lbl_address.BackColor = Color.Transparent
        Lbl_address.Font = New Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Lbl_address.ForeColor = Color.White
        Lbl_address.Location = New Point(16, 550)
        Lbl_address.Name = "Lbl_address"
        Lbl_address.Size = New Size(89, 20)
        Lbl_address.TabIndex = 23
        Lbl_address.Text = "ADDRESS"
        ' 
        ' Lbl_storename
        ' 
        Lbl_storename.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left
        Lbl_storename.AutoSize = True
        Lbl_storename.BackColor = Color.Transparent
        Lbl_storename.Font = New Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Lbl_storename.ForeColor = Color.White
        Lbl_storename.Location = New Point(16, 508)
        Lbl_storename.Name = "Lbl_storename"
        Lbl_storename.Size = New Size(114, 20)
        Lbl_storename.TabIndex = 22
        Lbl_storename.Text = "STORE NAME"
        ' 
        ' lbl_name_sup
        ' 
        lbl_name_sup.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left
        lbl_name_sup.AutoSize = True
        lbl_name_sup.BackColor = Color.Transparent
        lbl_name_sup.Font = New Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lbl_name_sup.ForeColor = Color.White
        lbl_name_sup.Location = New Point(16, 466)
        lbl_name_sup.Name = "lbl_name_sup"
        lbl_name_sup.Size = New Size(120, 20)
        lbl_name_sup.TabIndex = 21
        lbl_name_sup.Text = "OWNER NAME"
        ' 
        ' txt_sup_cnumber
        ' 
        txt_sup_cnumber.Location = New Point(730, 505)
        txt_sup_cnumber.Name = "txt_sup_cnumber"
        txt_sup_cnumber.Size = New Size(230, 23)
        txt_sup_cnumber.TabIndex = 20
        txt_sup_cnumber.Text = "+63"
        ' 
        ' txt_sup_email
        ' 
        txt_sup_email.Location = New Point(730, 463)
        txt_sup_email.Name = "txt_sup_email"
        txt_sup_email.PlaceholderText = "ex. RBRS2@gmail.com"
        txt_sup_email.Size = New Size(230, 23)
        txt_sup_email.TabIndex = 19
        ' 
        ' txt_sup_address
        ' 
        txt_sup_address.Location = New Point(142, 547)
        txt_sup_address.Name = "txt_sup_address"
        txt_sup_address.PlaceholderText = "ex. SM City Daet"
        txt_sup_address.Size = New Size(230, 23)
        txt_sup_address.TabIndex = 18
        ' 
        ' txt_store_name
        ' 
        txt_store_name.Location = New Point(142, 505)
        txt_store_name.Name = "txt_store_name"
        txt_store_name.PlaceholderText = "ex. RBRS Gadget Store"
        txt_store_name.Size = New Size(230, 23)
        txt_store_name.TabIndex = 17
        ' 
        ' txt_sup_name
        ' 
        txt_sup_name.Location = New Point(142, 463)
        txt_sup_name.Name = "txt_sup_name"
        txt_sup_name.PlaceholderText = "ex. Christian John Ibanez"
        txt_sup_name.Size = New Size(230, 23)
        txt_sup_name.TabIndex = 16
        ' 
        ' Label5
        ' 
        Label5.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        Label5.AutoSize = True
        Label5.BackColor = Color.Transparent
        Label5.Image = My.Resources.Resources.search
        Label5.Location = New Point(880, 102)
        Label5.Name = "Label5"
        Label5.Size = New Size(28, 15)
        Label5.TabIndex = 31
        Label5.Text = "       "
        ' 
        ' Search_supplier
        ' 
        Search_supplier.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        Search_supplier.Location = New Point(909, 98)
        Search_supplier.Name = "Search_supplier"
        Search_supplier.PlaceholderText = "Search"
        Search_supplier.Size = New Size(213, 23)
        Search_supplier.TabIndex = 30
        ' 
        ' SUPPLIER
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), Image)
        BackgroundImageLayout = ImageLayout.Center
        Controls.Add(Label5)
        Controls.Add(Search_supplier)
        Controls.Add(Btn_clear)
        Controls.Add(Btn_delete)
        Controls.Add(Btn_update)
        Controls.Add(Btn_create)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(Lbl_address)
        Controls.Add(Lbl_storename)
        Controls.Add(lbl_name_sup)
        Controls.Add(txt_sup_cnumber)
        Controls.Add(txt_sup_email)
        Controls.Add(txt_sup_address)
        Controls.Add(txt_store_name)
        Controls.Add(txt_sup_name)
        Controls.Add(sup_datagridview)
        Controls.Add(Lbl_supplier)
        DoubleBuffered = True
        Name = "SUPPLIER"
        Size = New Size(1149, 788)
        CType(sup_datagridview, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Lbl_supplier As Label
    Friend WithEvents sup_datagridview As DataGridView
    Friend WithEvents supp_id As DataGridViewTextBoxColumn
    Friend WithEvents supp_name As DataGridViewTextBoxColumn
    Friend WithEvents supp_store As DataGridViewTextBoxColumn
    Friend WithEvents supp_address As DataGridViewTextBoxColumn
    Friend WithEvents supp_email As DataGridViewTextBoxColumn
    Friend WithEvents supp_cnumber As DataGridViewTextBoxColumn
    Friend WithEvents Btn_clear As Button
    Friend WithEvents Btn_delete As Button
    Friend WithEvents Btn_update As Button
    Friend WithEvents Btn_create As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Lbl_address As Label
    Friend WithEvents Lbl_storename As Label
    Friend WithEvents lbl_name_sup As Label
    Friend WithEvents txt_sup_cnumber As TextBox
    Friend WithEvents txt_sup_email As TextBox
    Friend WithEvents txt_sup_address As TextBox
    Friend WithEvents txt_store_name As TextBox
    Friend WithEvents txt_sup_name As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Search_supplier As TextBox

End Class
