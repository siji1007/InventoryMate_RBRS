﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
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
        Lbl_product = New Label()
        SuspendLayout()
        ' 
        ' Lbl_product
        ' 
        Lbl_product.AutoSize = True
        Lbl_product.BackColor = Color.Transparent
        Lbl_product.Font = New Font("Microsoft Sans Serif", 18.0F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Lbl_product.Location = New Point(595, 38)
        Lbl_product.Name = "Lbl_product"
        Lbl_product.Size = New Size(151, 29)
        Lbl_product.TabIndex = 2
        Lbl_product.Text = "CUSTOMER"
        ' 
        ' CUSTOMER
        ' 
        AutoScaleDimensions = New SizeF(7.0F, 15.0F)
        AutoScaleMode = AutoScaleMode.Font
        BackgroundImage = My.Resources.Resources.backgroud
        BackgroundImageLayout = ImageLayout.Stretch
        Controls.Add(Lbl_product)
        DoubleBuffered = True
        Name = "CUSTOMER"
        Size = New Size(1149, 788)
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Lbl_product As Label

End Class
