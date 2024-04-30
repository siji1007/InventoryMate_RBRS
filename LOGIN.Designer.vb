<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class LOGIN
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        logo = New PictureBox()
        GroupBox1 = New GroupBox()
        Pass_show = New Button()
        txt_password = New TextBox()
        txt_username = New TextBox()
        Btn_SignUp = New Button()
        Btn_SignIn = New Button()
        Label1 = New Label()
        USERNAME = New Label()
        CType(logo, ComponentModel.ISupportInitialize).BeginInit()
        GroupBox1.SuspendLayout()
        SuspendLayout()
        ' 
        ' logo
        ' 
        logo.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        logo.Image = My.Resources.Resources.Slide_4_3___1
        logo.Location = New Point(0, 0)
        logo.Name = "logo"
        logo.Size = New Size(443, 466)
        logo.SizeMode = PictureBoxSizeMode.StretchImage
        logo.TabIndex = 0
        logo.TabStop = False
        ' 
        ' GroupBox1
        ' 
        GroupBox1.BackColor = Color.FromArgb(CByte(30), CByte(39), CByte(46))
        GroupBox1.Controls.Add(Pass_show)
        GroupBox1.Controls.Add(txt_password)
        GroupBox1.Controls.Add(txt_username)
        GroupBox1.Controls.Add(Btn_SignUp)
        GroupBox1.Controls.Add(Btn_SignIn)
        GroupBox1.Controls.Add(Label1)
        GroupBox1.Controls.Add(USERNAME)
        GroupBox1.Dock = DockStyle.Right
        GroupBox1.Font = New Font("Microsoft Sans Serif", 14.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        GroupBox1.ForeColor = SystemColors.Window
        GroupBox1.Location = New Point(348, 0)
        GroupBox1.Name = "GroupBox1"
        GroupBox1.Size = New Size(468, 466)
        GroupBox1.TabIndex = 1
        GroupBox1.TabStop = False
        GroupBox1.Text = "LOGIN"
        ' 
        ' Pass_show
        ' 
        Pass_show.Anchor = AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        Pass_show.BackColor = Color.Transparent
        Pass_show.BackgroundImageLayout = ImageLayout.Zoom
        Pass_show.FlatStyle = FlatStyle.Popup
        Pass_show.Image = My.Resources.Resources.view
        Pass_show.Location = New Point(366, 275)
        Pass_show.Name = "Pass_show"
        Pass_show.Size = New Size(34, 24)
        Pass_show.TabIndex = 9
        Pass_show.UseVisualStyleBackColor = False
        ' 
        ' txt_password
        ' 
        txt_password.Anchor = AnchorStyles.Bottom Or AnchorStyles.Right
        txt_password.BackColor = Color.FromArgb(CByte(30), CByte(39), CByte(46))
        txt_password.ForeColor = SystemColors.Window
        txt_password.Location = New Point(153, 275)
        txt_password.Name = "txt_password"
        txt_password.PasswordChar = "*"c
        txt_password.Size = New Size(207, 29)
        txt_password.TabIndex = 5
        ' 
        ' txt_username
        ' 
        txt_username.Anchor = AnchorStyles.Bottom Or AnchorStyles.Right
        txt_username.BackColor = Color.FromArgb(CByte(30), CByte(39), CByte(46))
        txt_username.ForeColor = Color.White
        txt_username.Location = New Point(153, 224)
        txt_username.Name = "txt_username"
        txt_username.Size = New Size(207, 29)
        txt_username.TabIndex = 4
        ' 
        ' Btn_SignUp
        ' 
        Btn_SignUp.Anchor = AnchorStyles.Bottom Or AnchorStyles.Right
        Btn_SignUp.BackColor = Color.FromArgb(CByte(30), CByte(39), CByte(46))
        Btn_SignUp.BackgroundImageLayout = ImageLayout.None
        Btn_SignUp.FlatStyle = FlatStyle.Flat
        Btn_SignUp.ForeColor = Color.White
        Btn_SignUp.Location = New Point(303, 325)
        Btn_SignUp.Name = "Btn_SignUp"
        Btn_SignUp.Size = New Size(86, 35)
        Btn_SignUp.TabIndex = 3
        Btn_SignUp.Text = "SIGN UP"
        Btn_SignUp.UseVisualStyleBackColor = False
        ' 
        ' Btn_SignIn
        ' 
        Btn_SignIn.Anchor = AnchorStyles.Bottom Or AnchorStyles.Left
        Btn_SignIn.BackColor = Color.FromArgb(CByte(30), CByte(39), CByte(46))
        Btn_SignIn.BackgroundImageLayout = ImageLayout.None
        Btn_SignIn.FlatStyle = FlatStyle.Flat
        Btn_SignIn.ForeColor = Color.White
        Btn_SignIn.Location = New Point(101, 325)
        Btn_SignIn.Name = "Btn_SignIn"
        Btn_SignIn.Size = New Size(86, 35)
        Btn_SignIn.TabIndex = 2
        Btn_SignIn.Text = "SIGN IN"
        Btn_SignIn.UseVisualStyleBackColor = False
        ' 
        ' Label1
        ' 
        Label1.Anchor = AnchorStyles.Bottom Or AnchorStyles.Left
        Label1.AutoSize = True
        Label1.Font = New Font("Microsoft Sans Serif", 11.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(48, 275)
        Label1.Name = "Label1"
        Label1.Size = New Size(96, 18)
        Label1.TabIndex = 1
        Label1.Text = "PASSWORD"
        ' 
        ' USERNAME
        ' 
        USERNAME.Anchor = AnchorStyles.Bottom Or AnchorStyles.Left
        USERNAME.AutoSize = True
        USERNAME.Font = New Font("Microsoft Sans Serif", 11.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        USERNAME.Location = New Point(48, 225)
        USERNAME.Name = "USERNAME"
        USERNAME.Size = New Size(93, 18)
        USERNAME.TabIndex = 0
        USERNAME.Text = "USERNAME"
        ' 
        ' LOGIN
        ' 
        Controls.Add(GroupBox1)
        Controls.Add(logo)
        Name = "LOGIN"
        Size = New Size(816, 466)
        CType(logo, ComponentModel.ISupportInitialize).EndInit()
        GroupBox1.ResumeLayout(False)
        GroupBox1.PerformLayout()
        ResumeLayout(False)
        ' 

        ' LOGIN
        ' 

    End Sub

    Friend WithEvents logo As PictureBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents USERNAME As Label
    Friend WithEvents Btn_SignIn As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents txt_password As TextBox
    Friend WithEvents txt_username As TextBox
    Friend WithEvents Btn_SignUp As Button
    Friend WithEvents Pass_show As Button



End Class
