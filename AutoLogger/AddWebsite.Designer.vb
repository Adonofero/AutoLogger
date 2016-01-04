<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AddWebsite
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.LoginSubmitIDTextbox = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.PasswordEntryIDTextbox = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.UserEntryIDTextbox = New System.Windows.Forms.TextBox()
        Me.PasswordEntryLabel = New System.Windows.Forms.Label()
        Me.PasswordEntryTextbox = New System.Windows.Forms.TextBox()
        Me.UserLoginLabel = New System.Windows.Forms.Label()
        Me.UserNameTextbox = New System.Windows.Forms.TextBox()
        Me.WebsiteEntryLabel = New System.Windows.Forms.Label()
        Me.WebsiteEntryTextbox = New System.Windows.Forms.TextBox()
        Me.ConfirmButton = New System.Windows.Forms.Button()
        Me.CancelButton = New System.Windows.Forms.Button()
        Me.NewFileSaveDialog = New System.Windows.Forms.SaveFileDialog()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.WebsiteAliasTextbox = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(390, 160)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(262, 13)
        Me.Label1.TabIndex = 26
        Me.Label1.Text = "Please enter the element id for the login submit button:"
        '
        'LoginSubmitIDTextbox
        '
        Me.LoginSubmitIDTextbox.ForeColor = System.Drawing.SystemColors.WindowText
        Me.LoginSubmitIDTextbox.Location = New System.Drawing.Point(393, 176)
        Me.LoginSubmitIDTextbox.Name = "LoginSubmitIDTextbox"
        Me.LoginSubmitIDTextbox.Size = New System.Drawing.Size(180, 20)
        Me.LoginSubmitIDTextbox.TabIndex = 25
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(390, 99)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(241, 13)
        Me.Label2.TabIndex = 24
        Me.Label2.Text = "Please enter the element id for the password field:"
        '
        'PasswordEntryIDTextbox
        '
        Me.PasswordEntryIDTextbox.Location = New System.Drawing.Point(393, 115)
        Me.PasswordEntryIDTextbox.Name = "PasswordEntryIDTextbox"
        Me.PasswordEntryIDTextbox.Size = New System.Drawing.Size(180, 20)
        Me.PasswordEntryIDTextbox.TabIndex = 23
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(390, 28)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(242, 13)
        Me.Label3.TabIndex = 22
        Me.Label3.Text = "Please enter the element id for the user entry field:"
        '
        'UserEntryIDTextbox
        '
        Me.UserEntryIDTextbox.Location = New System.Drawing.Point(393, 44)
        Me.UserEntryIDTextbox.Name = "UserEntryIDTextbox"
        Me.UserEntryIDTextbox.Size = New System.Drawing.Size(180, 20)
        Me.UserEntryIDTextbox.TabIndex = 21
        '
        'PasswordEntryLabel
        '
        Me.PasswordEntryLabel.AutoSize = True
        Me.PasswordEntryLabel.Location = New System.Drawing.Point(9, 160)
        Me.PasswordEntryLabel.Name = "PasswordEntryLabel"
        Me.PasswordEntryLabel.Size = New System.Drawing.Size(140, 13)
        Me.PasswordEntryLabel.TabIndex = 20
        Me.PasswordEntryLabel.Text = "Please enter your password:"
        '
        'PasswordEntryTextbox
        '
        Me.PasswordEntryTextbox.Location = New System.Drawing.Point(12, 176)
        Me.PasswordEntryTextbox.Name = "PasswordEntryTextbox"
        Me.PasswordEntryTextbox.Size = New System.Drawing.Size(180, 20)
        Me.PasswordEntryTextbox.TabIndex = 19
        '
        'UserLoginLabel
        '
        Me.UserLoginLabel.AutoSize = True
        Me.UserLoginLabel.Location = New System.Drawing.Point(9, 99)
        Me.UserLoginLabel.Name = "UserLoginLabel"
        Me.UserLoginLabel.Size = New System.Drawing.Size(198, 13)
        Me.UserLoginLabel.TabIndex = 18
        Me.UserLoginLabel.Text = "Please enter the user name to login with:"
        '
        'UserNameTextbox
        '
        Me.UserNameTextbox.Location = New System.Drawing.Point(12, 115)
        Me.UserNameTextbox.Name = "UserNameTextbox"
        Me.UserNameTextbox.Size = New System.Drawing.Size(180, 20)
        Me.UserNameTextbox.TabIndex = 17
        '
        'WebsiteEntryLabel
        '
        Me.WebsiteEntryLabel.AutoSize = True
        Me.WebsiteEntryLabel.Location = New System.Drawing.Point(9, 28)
        Me.WebsiteEntryLabel.Name = "WebsiteEntryLabel"
        Me.WebsiteEntryLabel.Size = New System.Drawing.Size(175, 13)
        Me.WebsiteEntryLabel.TabIndex = 16
        Me.WebsiteEntryLabel.Text = "Please enter the website to login to:"
        '
        'WebsiteEntryTextbox
        '
        Me.WebsiteEntryTextbox.Location = New System.Drawing.Point(12, 44)
        Me.WebsiteEntryTextbox.Name = "WebsiteEntryTextbox"
        Me.WebsiteEntryTextbox.Size = New System.Drawing.Size(180, 20)
        Me.WebsiteEntryTextbox.TabIndex = 15
        '
        'ConfirmButton
        '
        Me.ConfirmButton.Location = New System.Drawing.Point(272, 222)
        Me.ConfirmButton.Name = "ConfirmButton"
        Me.ConfirmButton.Size = New System.Drawing.Size(114, 34)
        Me.ConfirmButton.TabIndex = 27
        Me.ConfirmButton.Text = "Confirm"
        Me.ConfirmButton.UseVisualStyleBackColor = True
        '
        'CancelButton
        '
        Me.CancelButton.Location = New System.Drawing.Point(459, 222)
        Me.CancelButton.Name = "CancelButton"
        Me.CancelButton.Size = New System.Drawing.Size(114, 34)
        Me.CancelButton.TabIndex = 28
        Me.CancelButton.Text = "Cancel"
        Me.CancelButton.UseVisualStyleBackColor = True
        '
        'NewFileSaveDialog
        '
        Me.NewFileSaveDialog.Filter = "Autologger Filer (*.AL)|*.AL"
        Me.NewFileSaveDialog.Title = "Create New File"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(9, 220)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(150, 13)
        Me.Label4.TabIndex = 30
        Me.Label4.Text = "Please enter the website alias:"
        '
        'WebsiteAliasTextbox
        '
        Me.WebsiteAliasTextbox.ForeColor = System.Drawing.SystemColors.WindowText
        Me.WebsiteAliasTextbox.Location = New System.Drawing.Point(12, 236)
        Me.WebsiteAliasTextbox.Name = "WebsiteAliasTextbox"
        Me.WebsiteAliasTextbox.Size = New System.Drawing.Size(180, 20)
        Me.WebsiteAliasTextbox.TabIndex = 29
        '
        'AddWebsite
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(655, 294)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.WebsiteAliasTextbox)
        Me.Controls.Add(Me.CancelButton)
        Me.Controls.Add(Me.ConfirmButton)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.LoginSubmitIDTextbox)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.PasswordEntryIDTextbox)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.UserEntryIDTextbox)
        Me.Controls.Add(Me.PasswordEntryLabel)
        Me.Controls.Add(Me.PasswordEntryTextbox)
        Me.Controls.Add(Me.UserLoginLabel)
        Me.Controls.Add(Me.UserNameTextbox)
        Me.Controls.Add(Me.WebsiteEntryLabel)
        Me.Controls.Add(Me.WebsiteEntryTextbox)
        Me.Name = "AddWebsite"
        Me.Text = "AddWebsite"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents LoginSubmitIDTextbox As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents PasswordEntryIDTextbox As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents UserEntryIDTextbox As System.Windows.Forms.TextBox
    Friend WithEvents PasswordEntryLabel As System.Windows.Forms.Label
    Friend WithEvents PasswordEntryTextbox As System.Windows.Forms.TextBox
    Friend WithEvents UserLoginLabel As System.Windows.Forms.Label
    Friend WithEvents UserNameTextbox As System.Windows.Forms.TextBox
    Friend WithEvents WebsiteEntryLabel As System.Windows.Forms.Label
    Friend WithEvents WebsiteEntryTextbox As System.Windows.Forms.TextBox
    Friend WithEvents ConfirmButton As System.Windows.Forms.Button
    Friend WithEvents CancelButton As System.Windows.Forms.Button
    Friend WithEvents NewFileSaveDialog As System.Windows.Forms.SaveFileDialog
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents WebsiteAliasTextbox As System.Windows.Forms.TextBox
End Class
