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
        Lbl_customer = New Label()
        SuspendLayout()
        ' 
        ' Lbl_customer
        ' 
        Lbl_customer.AutoSize = True
        Lbl_customer.BackColor = Color.Transparent
        Lbl_customer.Font = New Font("Microsoft Sans Serif", 18F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Lbl_customer.ForeColor = Color.White
        Lbl_customer.Location = New Point(595, 38)
        Lbl_customer.Name = "Lbl_customer"
        Lbl_customer.Size = New Size(151, 29)
        Lbl_customer.TabIndex = 2
        Lbl_customer.Text = "CUSTOMER"
        ' 
        ' CUSTOMER
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackgroundImage = My.Resources.Resources.backgroud
        BackgroundImageLayout = ImageLayout.Center
        Controls.Add(Lbl_customer)
        DoubleBuffered = True
        Name = "CUSTOMER"
        Size = New Size(1149, 788)
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Lbl_customer As Label

End Class
