<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SIGNUP
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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
        GroupBox1 = New GroupBox()
        Sign_up = New Button()
        GroupBox3 = New GroupBox()
        txt_passCheck = New TextBox()
        Label6 = New Label()
        txt_password = New TextBox()
        txt_username = New TextBox()
        Label5 = New Label()
        Label4 = New Label()
        GroupBox2 = New GroupBox()
        cb_position = New ComboBox()
        birthdate = New DateTimePicker()
        Label3 = New Label()
        txt_address = New TextBox()
        txt_contact = New TextBox()
        Label2 = New Label()
        Label1 = New Label()
        txt_name = New TextBox()
        prod_name_label = New Label()
        Label7 = New Label()
        GroupBox1.SuspendLayout()
        GroupBox3.SuspendLayout()
        GroupBox2.SuspendLayout()
        SuspendLayout()
        ' 
        ' GroupBox1
        ' 
        GroupBox1.BackColor = Color.FromArgb(CByte(30), CByte(39), CByte(46))
        GroupBox1.Controls.Add(Sign_up)
        GroupBox1.Controls.Add(GroupBox3)
        GroupBox1.Controls.Add(GroupBox2)
        GroupBox1.Dock = DockStyle.Fill
        GroupBox1.Font = New Font("Microsoft Sans Serif", 14.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        GroupBox1.ForeColor = Color.White
        GroupBox1.Location = New Point(10, 0)
        GroupBox1.Name = "GroupBox1"
        GroupBox1.Size = New Size(704, 611)
        GroupBox1.TabIndex = 0
        GroupBox1.TabStop = False
        GroupBox1.Text = "SIGN UP"
        ' 
        ' Sign_up
        ' 
        Sign_up.Anchor = AnchorStyles.Bottom
        Sign_up.BackColor = Color.FromArgb(CByte(30), CByte(39), CByte(46))
        Sign_up.FlatStyle = FlatStyle.Flat
        Sign_up.ForeColor = Color.White
        Sign_up.Location = New Point(287, 548)
        Sign_up.Name = "Sign_up"
        Sign_up.Size = New Size(110, 48)
        Sign_up.TabIndex = 2
        Sign_up.Text = "SIGN UP"
        Sign_up.UseVisualStyleBackColor = False
        ' 
        ' GroupBox3
        ' 
        GroupBox3.Anchor = AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        GroupBox3.Controls.Add(txt_passCheck)
        GroupBox3.Controls.Add(Label6)
        GroupBox3.Controls.Add(txt_password)
        GroupBox3.Controls.Add(txt_username)
        GroupBox3.Controls.Add(Label5)
        GroupBox3.Controls.Add(Label4)
        GroupBox3.Font = New Font("Microsoft Sans Serif", 11.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        GroupBox3.ForeColor = Color.White
        GroupBox3.Location = New Point(26, 329)
        GroupBox3.Name = "GroupBox3"
        GroupBox3.Size = New Size(634, 202)
        GroupBox3.TabIndex = 1
        GroupBox3.TabStop = False
        GroupBox3.Text = "CREATE ACCOUNT"
        ' 
        ' txt_passCheck
        ' 
        txt_passCheck.Font = New Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        txt_passCheck.Location = New Point(159, 141)
        txt_passCheck.Name = "txt_passCheck"
        txt_passCheck.Size = New Size(195, 22)
        txt_passCheck.TabIndex = 15
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.BackColor = Color.Transparent
        Label6.Font = New Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label6.ForeColor = SystemColors.ControlLightLight
        Label6.Location = New Point(19, 141)
        Label6.Name = "Label6"
        Label6.Size = New Size(142, 20)
        Label6.TabIndex = 14
        Label6.Text = "Re-Type Password"
        ' 
        ' txt_password
        ' 
        txt_password.Font = New Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        txt_password.Location = New Point(159, 96)
        txt_password.Name = "txt_password"
        txt_password.Size = New Size(195, 22)
        txt_password.TabIndex = 13
        ' 
        ' txt_username
        ' 
        txt_username.Font = New Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        txt_username.Location = New Point(159, 50)
        txt_username.Name = "txt_username"
        txt_username.Size = New Size(195, 22)
        txt_username.TabIndex = 11
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.BackColor = Color.Transparent
        Label5.Font = New Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label5.ForeColor = SystemColors.ControlLightLight
        Label5.Location = New Point(19, 96)
        Label5.Name = "Label5"
        Label5.Size = New Size(78, 20)
        Label5.TabIndex = 12
        Label5.Text = "Password"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.BackColor = Color.Transparent
        Label4.Font = New Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label4.ForeColor = SystemColors.ControlLightLight
        Label4.Location = New Point(19, 50)
        Label4.Name = "Label4"
        Label4.Size = New Size(83, 20)
        Label4.TabIndex = 11
        Label4.Text = "Username"
        ' 
        ' GroupBox2
        ' 
        GroupBox2.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        GroupBox2.AutoSizeMode = AutoSizeMode.GrowAndShrink
        GroupBox2.Controls.Add(Label7)
        GroupBox2.Controls.Add(cb_position)
        GroupBox2.Controls.Add(birthdate)
        GroupBox2.Controls.Add(Label3)
        GroupBox2.Controls.Add(txt_address)
        GroupBox2.Controls.Add(txt_contact)
        GroupBox2.Controls.Add(Label2)
        GroupBox2.Controls.Add(Label1)
        GroupBox2.Controls.Add(txt_name)
        GroupBox2.Controls.Add(prod_name_label)
        GroupBox2.Font = New Font("Microsoft Sans Serif", 11.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        GroupBox2.ForeColor = Color.White
        GroupBox2.Location = New Point(26, 74)
        GroupBox2.Name = "GroupBox2"
        GroupBox2.Size = New Size(634, 225)
        GroupBox2.TabIndex = 0
        GroupBox2.TabStop = False
        GroupBox2.Text = "PERSONAL DETAILS"
        ' 
        ' cb_position
        ' 
        cb_position.FormattingEnabled = True
        cb_position.Items.AddRange(New Object() {"ADMIN", "EMPLOYEE", "OWNER"})
        cb_position.Location = New Point(402, 123)
        cb_position.Name = "cb_position"
        cb_position.Size = New Size(226, 26)
        cb_position.TabIndex = 15
        cb_position.Text = "Position Applied For"
        ' 
        ' birthdate
        ' 
        birthdate.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        birthdate.Font = New Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        birthdate.Format = DateTimePickerFormat.Short
        birthdate.Location = New Point(466, 33)
        birthdate.Name = "birthdate"
        birthdate.Size = New Size(162, 22)
        birthdate.TabIndex = 10
        birthdate.Value = New Date(2024, 4, 25, 0, 0, 0, 0)
        ' 
        ' Label3
        ' 
        Label3.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        Label3.AutoSize = True
        Label3.BackColor = Color.Transparent
        Label3.Font = New Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label3.ForeColor = SystemColors.ControlLightLight
        Label3.Location = New Point(386, 37)
        Label3.Name = "Label3"
        Label3.Size = New Size(74, 20)
        Label3.TabIndex = 9
        Label3.Text = "Birthdate"
        ' 
        ' txt_address
        ' 
        txt_address.Font = New Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        txt_address.Location = New Point(159, 92)
        txt_address.Name = "txt_address"
        txt_address.Size = New Size(195, 22)
        txt_address.TabIndex = 8
        ' 
        ' txt_contact
        ' 
        txt_contact.Font = New Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        txt_contact.Location = New Point(186, 145)
        txt_contact.Name = "txt_contact"
        txt_contact.Size = New Size(168, 22)
        txt_contact.TabIndex = 7
        ' 
        ' Label2
        ' 
        Label2.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left
        Label2.AutoSize = True
        Label2.BackColor = Color.Transparent
        Label2.Font = New Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label2.ForeColor = SystemColors.ControlLightLight
        Label2.Location = New Point(19, 147)
        Label2.Name = "Label2"
        Label2.Size = New Size(125, 20)
        Label2.TabIndex = 6
        Label2.Text = "Contact Number"
        ' 
        ' Label1
        ' 
        Label1.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left
        Label1.AutoSize = True
        Label1.BackColor = Color.Transparent
        Label1.Font = New Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label1.ForeColor = SystemColors.ControlLightLight
        Label1.Location = New Point(19, 94)
        Label1.Name = "Label1"
        Label1.Size = New Size(68, 20)
        Label1.TabIndex = 5
        Label1.Text = "Address"
        ' 
        ' txt_name
        ' 
        txt_name.Font = New Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        txt_name.Location = New Point(159, 35)
        txt_name.Name = "txt_name"
        txt_name.Size = New Size(195, 22)
        txt_name.TabIndex = 4
        ' 
        ' prod_name_label
        ' 
        prod_name_label.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left
        prod_name_label.AutoSize = True
        prod_name_label.BackColor = Color.Transparent
        prod_name_label.Font = New Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        prod_name_label.ForeColor = SystemColors.ControlLightLight
        prod_name_label.Location = New Point(19, 37)
        prod_name_label.Name = "prod_name_label"
        prod_name_label.Size = New Size(51, 20)
        prod_name_label.TabIndex = 3
        prod_name_label.Text = "Name"
        ' 
        ' Label7
        ' 
        Label7.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left
        Label7.AutoSize = True
        Label7.BackColor = Color.Transparent
        Label7.Font = New Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label7.ForeColor = SystemColors.ControlLightLight
        Label7.Location = New Point(150, 147)
        Label7.Name = "Label7"
        Label7.Size = New Size(36, 20)
        Label7.TabIndex = 16
        Label7.Text = "+63"
        ' 
        ' SIGNUP
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        AutoSizeMode = AutoSizeMode.GrowAndShrink
        ClientSize = New Size(724, 611)
        Controls.Add(GroupBox1)
        ForeColor = Color.Cornsilk
        MaximizeBox = False
        MinimizeBox = False
        Name = "SIGNUP"
        Padding = New Padding(10, 0, 10, 0)
        StartPosition = FormStartPosition.CenterScreen
        Text = "SIGNUP"
        GroupBox1.ResumeLayout(False)
        GroupBox3.ResumeLayout(False)
        GroupBox3.PerformLayout()
        GroupBox2.ResumeLayout(False)
        GroupBox2.PerformLayout()
        ResumeLayout(False)
    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents Sign_up As Button
    Friend WithEvents prod_name_label As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents txt_name As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents txt_address As TextBox
    Friend WithEvents txt_contact As TextBox
    Friend WithEvents birthdate As DateTimePicker
    Friend WithEvents Label4 As Label
    Friend WithEvents txt_password As TextBox
    Friend WithEvents txt_username As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents cb_position As ComboBox
    Friend WithEvents Decrypt As Button
    Friend WithEvents txt_passCheck As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
End Class
