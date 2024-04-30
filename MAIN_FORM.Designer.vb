<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class MAIN_FORM
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        mainPanel = New Panel()
        SuspendLayout()
        ' 
        ' mainPanel
        ' 
        mainPanel.Dock = DockStyle.Fill
        mainPanel.Location = New Point(0, 0)
        mainPanel.Name = "mainPanel"
        mainPanel.Size = New Size(894, 552)
        mainPanel.TabIndex = 0
        ' 
        ' MAIN_FORM
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(894, 552)
        Controls.Add(mainPanel)
        DoubleBuffered = True
        FormBorderStyle = FormBorderStyle.FixedToolWindow
        MaximizeBox = False
        MinimizeBox = False
        Name = "MAIN_FORM"
        StartPosition = FormStartPosition.CenterScreen
        Text = "MAIN"
        ResumeLayout(False)
    End Sub

    Friend WithEvents mainPanel As Panel

End Class
