<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class HOME
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(HOME))
        Lbl_home = New Label()
        GroupBox1 = New GroupBox()
        Total_cost = New Label()
        Label3 = New Label()
        Top_sale = New Label()
        Label2 = New Label()
        daily_datagridview = New DataGridView()
        ProdName = New DataGridViewTextBoxColumn()
        Quantity = New DataGridViewTextBoxColumn()
        CustName = New DataGridViewTextBoxColumn()
        War_exp = New DataGridViewTextBoxColumn()
        GroupBox1.SuspendLayout()
        CType(daily_datagridview, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Lbl_home
        ' 
        Lbl_home.AutoSize = True
        Lbl_home.BackColor = Color.Transparent
        Lbl_home.Font = New Font("Microsoft Sans Serif", 18F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Lbl_home.ForeColor = Color.White
        Lbl_home.Location = New Point(601, 31)
        Lbl_home.Name = "Lbl_home"
        Lbl_home.Size = New Size(85, 29)
        Lbl_home.TabIndex = 0
        Lbl_home.Text = "HOME"
        ' 
        ' GroupBox1
        ' 
        GroupBox1.BackColor = Color.FromArgb(CByte(30), CByte(39), CByte(46))
        GroupBox1.Controls.Add(Total_cost)
        GroupBox1.Controls.Add(Label3)
        GroupBox1.Controls.Add(Top_sale)
        GroupBox1.Controls.Add(Label2)
        GroupBox1.Controls.Add(daily_datagridview)
        GroupBox1.Font = New Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        GroupBox1.ForeColor = Color.White
        GroupBox1.Location = New Point(44, 99)
        GroupBox1.Name = "GroupBox1"
        GroupBox1.Size = New Size(727, 439)
        GroupBox1.TabIndex = 4
        GroupBox1.TabStop = False
        GroupBox1.Text = "DAILY TRANSACTION"
        ' 
        ' Total_cost
        ' 
        Total_cost.Anchor = AnchorStyles.Bottom Or AnchorStyles.Right
        Total_cost.AutoSize = True
        Total_cost.Location = New Point(604, 384)
        Total_cost.Name = "Total_cost"
        Total_cost.Size = New Size(59, 20)
        Total_cost.TabIndex = 6
        Total_cost.Text = "TOTAL"
        ' 
        ' Label3
        ' 
        Label3.Anchor = AnchorStyles.Bottom Or AnchorStyles.Right
        Label3.AutoSize = True
        Label3.Location = New Point(526, 384)
        Label3.Name = "Label3"
        Label3.Size = New Size(63, 20)
        Label3.TabIndex = 5
        Label3.Text = "TOTAL:"
        ' 
        ' Top_sale
        ' 
        Top_sale.AutoSize = True
        Top_sale.FlatStyle = FlatStyle.Flat
        Top_sale.Font = New Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Top_sale.Location = New Point(199, 384)
        Top_sale.Name = "Top_sale"
        Top_sale.Size = New Size(71, 20)
        Top_sale.TabIndex = 4
        Top_sale.Text = "Product"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(21, 384)
        Label2.Name = "Label2"
        Label2.Size = New Size(172, 20)
        Label2.TabIndex = 3
        Label2.Text = "TOP SALE PRODUCT:"
        ' 
        ' daily_datagridview
        ' 
        daily_datagridview.AllowUserToAddRows = False
        DataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter
        daily_datagridview.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        daily_datagridview.BackgroundColor = Color.FromArgb(CByte(30), CByte(39), CByte(46))
        DataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle2.BackColor = Color.FromArgb(CByte(30), CByte(39), CByte(46))
        DataGridViewCellStyle2.Font = New Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        DataGridViewCellStyle2.ForeColor = Color.White
        DataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = DataGridViewTriState.True
        daily_datagridview.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        daily_datagridview.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        daily_datagridview.Columns.AddRange(New DataGridViewColumn() {ProdName, Quantity, CustName, War_exp})
        DataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle3.BackColor = Color.FromArgb(CByte(30), CByte(39), CByte(46))
        DataGridViewCellStyle3.Font = New Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        DataGridViewCellStyle3.ForeColor = Color.White
        DataGridViewCellStyle3.SelectionBackColor = SystemColors.Highlight
        DataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = DataGridViewTriState.False
        daily_datagridview.DefaultCellStyle = DataGridViewCellStyle3
        daily_datagridview.GridColor = Color.White
        daily_datagridview.Location = New Point(0, 45)
        daily_datagridview.Name = "daily_datagridview"
        daily_datagridview.ReadOnly = True
        daily_datagridview.RowHeadersVisible = False
        daily_datagridview.Size = New Size(727, 318)
        daily_datagridview.TabIndex = 0
        ' 
        ' ProdName
        ' 
        ProdName.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
        ProdName.HeaderText = "PRODUCT NAME"
        ProdName.Name = "ProdName"
        ProdName.ReadOnly = True
        ' 
        ' Quantity
        ' 
        Quantity.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
        Quantity.HeaderText = "QUANTITY"
        Quantity.Name = "Quantity"
        Quantity.ReadOnly = True
        ' 
        ' CustName
        ' 
        CustName.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
        CustName.HeaderText = "CUSTOMER NAME"
        CustName.Name = "CustName"
        CustName.ReadOnly = True
        ' 
        ' War_exp
        ' 
        War_exp.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
        War_exp.HeaderText = "WARRANTY EXPIRATION"
        War_exp.Name = "War_exp"
        War_exp.ReadOnly = True
        ' 
        ' HOME
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), Image)
        BackgroundImageLayout = ImageLayout.Center
        Controls.Add(GroupBox1)
        Controls.Add(Lbl_home)
        DoubleBuffered = True
        Name = "HOME"
        Size = New Size(1149, 788)
        GroupBox1.ResumeLayout(False)
        GroupBox1.PerformLayout()
        CType(daily_datagridview, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Lbl_home As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Total_cost As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Top_sale As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents daily_datagridview As DataGridView
    Friend WithEvents ProdName As DataGridViewTextBoxColumn
    Friend WithEvents Quantity As DataGridViewTextBoxColumn
    Friend WithEvents CustName As DataGridViewTextBoxColumn
    Friend WithEvents War_exp As DataGridViewTextBoxColumn

End Class
