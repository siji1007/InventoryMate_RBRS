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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(HOME))
        Lbl_home = New Label()
        SuspendLayout()
        ' 
        ' Lbl_home
        ' 
        Lbl_home.AutoSize = True
        Lbl_home.BackColor = Color.Transparent
        Lbl_home.Font = New Font("Microsoft Sans Serif", 18F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Lbl_home.Location = New Point(574, 23)
        Lbl_home.Name = "Lbl_home"
        Lbl_home.Size = New Size(85, 29)
        Lbl_home.TabIndex = 0
        Lbl_home.Text = "HOME"
        ' 
        ' HOME
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), Image)
        BackgroundImageLayout = ImageLayout.Stretch
        Controls.Add(Lbl_home)
        DoubleBuffered = True
        Name = "HOME"
        Size = New Size(1149, 788)
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Lbl_home As Label

End Class
