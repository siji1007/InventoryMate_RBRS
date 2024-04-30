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
        Lbl_transaction = New Label()
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
        ' TRANSACTION
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackgroundImage = My.Resources.Resources.backgroud
        BackgroundImageLayout = ImageLayout.Center
        Controls.Add(Lbl_transaction)
        DoubleBuffered = True
        Name = "TRANSACTION"
        Size = New Size(1149, 788)
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Lbl_transaction As Label

End Class
