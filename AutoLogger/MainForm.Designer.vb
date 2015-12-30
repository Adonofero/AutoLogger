<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Autologger
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
        Me.WebsiteEntryTextbox = New System.Windows.Forms.TextBox()
        Me.WebsiteEntryLabel = New System.Windows.Forms.Label()
        Me.UserLoginLabel = New System.Windows.Forms.Label()
        Me.UserNameTextbox = New System.Windows.Forms.TextBox()
        Me.PasswordEntryLabel = New System.Windows.Forms.Label()
        Me.PasswordEntryTextbox = New System.Windows.Forms.TextBox()
        Me.ConfirmButton = New System.Windows.Forms.Button()
        Me.QuitButton = New System.Windows.Forms.Button()
        Me.ExitAfterLoginCheckbox = New System.Windows.Forms.CheckBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.LoginSubmitIDTextbox = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.PasswordEntryIDTextbox = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.UserEntryIDTextbox = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'WebsiteEntryTextbox
        '
        Me.WebsiteEntryTextbox.Location = New System.Drawing.Point(29, 54)
        Me.WebsiteEntryTextbox.Name = "WebsiteEntryTextbox"
        Me.WebsiteEntryTextbox.Size = New System.Drawing.Size(180, 20)
        Me.WebsiteEntryTextbox.TabIndex = 0
        '
        'WebsiteEntryLabel
        '
        Me.WebsiteEntryLabel.AutoSize = True
        Me.WebsiteEntryLabel.Location = New System.Drawing.Point(26, 38)
        Me.WebsiteEntryLabel.Name = "WebsiteEntryLabel"
        Me.WebsiteEntryLabel.Size = New System.Drawing.Size(175, 13)
        Me.WebsiteEntryLabel.TabIndex = 1
        Me.WebsiteEntryLabel.Text = "Please enter the website to login to:"
        '
        'UserLoginLabel
        '
        Me.UserLoginLabel.AutoSize = True
        Me.UserLoginLabel.Location = New System.Drawing.Point(26, 109)
        Me.UserLoginLabel.Name = "UserLoginLabel"
        Me.UserLoginLabel.Size = New System.Drawing.Size(198, 13)
        Me.UserLoginLabel.TabIndex = 3
        Me.UserLoginLabel.Text = "Please enter the user name to login with:"
        '
        'UserNameTextbox
        '
        Me.UserNameTextbox.Location = New System.Drawing.Point(29, 125)
        Me.UserNameTextbox.Name = "UserNameTextbox"
        Me.UserNameTextbox.Size = New System.Drawing.Size(180, 20)
        Me.UserNameTextbox.TabIndex = 2
        '
        'PasswordEntryLabel
        '
        Me.PasswordEntryLabel.AutoSize = True
        Me.PasswordEntryLabel.Location = New System.Drawing.Point(26, 170)
        Me.PasswordEntryLabel.Name = "PasswordEntryLabel"
        Me.PasswordEntryLabel.Size = New System.Drawing.Size(140, 13)
        Me.PasswordEntryLabel.TabIndex = 5
        Me.PasswordEntryLabel.Text = "Please enter your password:"
        '
        'PasswordEntryTextbox
        '
        Me.PasswordEntryTextbox.Location = New System.Drawing.Point(29, 186)
        Me.PasswordEntryTextbox.Name = "PasswordEntryTextbox"
        Me.PasswordEntryTextbox.Size = New System.Drawing.Size(180, 20)
        Me.PasswordEntryTextbox.TabIndex = 4
        '
        'ConfirmButton
        '
        Me.ConfirmButton.Location = New System.Drawing.Point(29, 241)
        Me.ConfirmButton.Name = "ConfirmButton"
        Me.ConfirmButton.Size = New System.Drawing.Size(102, 32)
        Me.ConfirmButton.TabIndex = 6
        Me.ConfirmButton.Text = "Login"
        Me.ConfirmButton.UseVisualStyleBackColor = True
        '
        'QuitButton
        '
        Me.QuitButton.Location = New System.Drawing.Point(257, 241)
        Me.QuitButton.Name = "QuitButton"
        Me.QuitButton.Size = New System.Drawing.Size(102, 36)
        Me.QuitButton.TabIndex = 7
        Me.QuitButton.Text = "Quit"
        Me.QuitButton.UseVisualStyleBackColor = True
        '
        'ExitAfterLoginCheckbox
        '
        Me.ExitAfterLoginCheckbox.AutoSize = True
        Me.ExitAfterLoginCheckbox.Checked = True
        Me.ExitAfterLoginCheckbox.CheckState = System.Windows.Forms.CheckState.Checked
        Me.ExitAfterLoginCheckbox.Location = New System.Drawing.Point(137, 241)
        Me.ExitAfterLoginCheckbox.Name = "ExitAfterLoginCheckbox"
        Me.ExitAfterLoginCheckbox.Size = New System.Drawing.Size(102, 17)
        Me.ExitAfterLoginCheckbox.TabIndex = 8
        Me.ExitAfterLoginCheckbox.Text = "Exit after Login?"
        Me.ExitAfterLoginCheckbox.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(407, 170)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(262, 13)
        Me.Label1.TabIndex = 14
        Me.Label1.Text = "Please enter the element id for the login submit button:"
        '
        'LoginSubmitIDTextbox
        '
        Me.LoginSubmitIDTextbox.ForeColor = System.Drawing.SystemColors.WindowText
        Me.LoginSubmitIDTextbox.Location = New System.Drawing.Point(410, 186)
        Me.LoginSubmitIDTextbox.Name = "LoginSubmitIDTextbox"
        Me.LoginSubmitIDTextbox.Size = New System.Drawing.Size(180, 20)
        Me.LoginSubmitIDTextbox.TabIndex = 13
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(407, 109)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(241, 13)
        Me.Label2.TabIndex = 12
        Me.Label2.Text = "Please enter the element id for the password field:"
        '
        'PasswordEntryIDTextbox
        '
        Me.PasswordEntryIDTextbox.Location = New System.Drawing.Point(410, 125)
        Me.PasswordEntryIDTextbox.Name = "PasswordEntryIDTextbox"
        Me.PasswordEntryIDTextbox.Size = New System.Drawing.Size(180, 20)
        Me.PasswordEntryIDTextbox.TabIndex = 11
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(407, 38)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(242, 13)
        Me.Label3.TabIndex = 10
        Me.Label3.Text = "Please enter the element id for the user entry field:"
        '
        'UserEntryIDTextbox
        '
        Me.UserEntryIDTextbox.Location = New System.Drawing.Point(410, 54)
        Me.UserEntryIDTextbox.Name = "UserEntryIDTextbox"
        Me.UserEntryIDTextbox.Size = New System.Drawing.Size(180, 20)
        Me.UserEntryIDTextbox.TabIndex = 9
        '
        'Autologger
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(673, 355)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.LoginSubmitIDTextbox)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.PasswordEntryIDTextbox)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.UserEntryIDTextbox)
        Me.Controls.Add(Me.ExitAfterLoginCheckbox)
        Me.Controls.Add(Me.QuitButton)
        Me.Controls.Add(Me.ConfirmButton)
        Me.Controls.Add(Me.PasswordEntryLabel)
        Me.Controls.Add(Me.PasswordEntryTextbox)
        Me.Controls.Add(Me.UserLoginLabel)
        Me.Controls.Add(Me.UserNameTextbox)
        Me.Controls.Add(Me.WebsiteEntryLabel)
        Me.Controls.Add(Me.WebsiteEntryTextbox)
        Me.Name = "Autologger"
        Me.Text = "AutoLogger"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents WebsiteEntryTextbox As System.Windows.Forms.TextBox
    Friend WithEvents WebsiteEntryLabel As System.Windows.Forms.Label
    Friend WithEvents UserLoginLabel As System.Windows.Forms.Label
    Friend WithEvents UserNameTextbox As System.Windows.Forms.TextBox
    Friend WithEvents PasswordEntryLabel As System.Windows.Forms.Label
    Friend WithEvents PasswordEntryTextbox As System.Windows.Forms.TextBox
    Friend WithEvents ConfirmButton As System.Windows.Forms.Button
    Friend WithEvents QuitButton As System.Windows.Forms.Button
    Friend WithEvents ExitAfterLoginCheckbox As System.Windows.Forms.CheckBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents LoginSubmitIDTextbox As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents PasswordEntryIDTextbox As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents UserEntryIDTextbox As System.Windows.Forms.TextBox

End Class
