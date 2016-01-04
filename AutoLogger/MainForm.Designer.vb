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
        Me.ConfirmButton = New System.Windows.Forms.Button()
        Me.QuitButton = New System.Windows.Forms.Button()
        Me.ExitAfterLoginCheckbox = New System.Windows.Forms.CheckBox()
        Me.SiteLoginsCheckbox = New System.Windows.Forms.CheckedListBox()
        Me.AddSiteButton = New System.Windows.Forms.Button()
        Me.LoadInfoButton = New System.Windows.Forms.Button()
        Me.FileSearcher = New System.Windows.Forms.OpenFileDialog()
        Me.SuspendLayout()
        '
        'ConfirmButton
        '
        Me.ConfirmButton.Location = New System.Drawing.Point(29, 321)
        Me.ConfirmButton.Name = "ConfirmButton"
        Me.ConfirmButton.Size = New System.Drawing.Size(102, 32)
        Me.ConfirmButton.TabIndex = 6
        Me.ConfirmButton.Text = "Login"
        Me.ConfirmButton.UseVisualStyleBackColor = True
        '
        'QuitButton
        '
        Me.QuitButton.Location = New System.Drawing.Point(363, 321)
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
        Me.ExitAfterLoginCheckbox.Location = New System.Drawing.Point(137, 321)
        Me.ExitAfterLoginCheckbox.Name = "ExitAfterLoginCheckbox"
        Me.ExitAfterLoginCheckbox.Size = New System.Drawing.Size(102, 17)
        Me.ExitAfterLoginCheckbox.TabIndex = 8
        Me.ExitAfterLoginCheckbox.Text = "Exit after Login?"
        Me.ExitAfterLoginCheckbox.UseVisualStyleBackColor = True
        '
        'SiteLoginsCheckbox
        '
        Me.SiteLoginsCheckbox.FormattingEnabled = True
        Me.SiteLoginsCheckbox.Location = New System.Drawing.Point(29, 12)
        Me.SiteLoginsCheckbox.Name = "SiteLoginsCheckbox"
        Me.SiteLoginsCheckbox.Size = New System.Drawing.Size(318, 289)
        Me.SiteLoginsCheckbox.TabIndex = 9
        '
        'AddSiteButton
        '
        Me.AddSiteButton.Location = New System.Drawing.Point(363, 12)
        Me.AddSiteButton.Name = "AddSiteButton"
        Me.AddSiteButton.Size = New System.Drawing.Size(102, 34)
        Me.AddSiteButton.TabIndex = 10
        Me.AddSiteButton.Text = "Add Website"
        Me.AddSiteButton.UseVisualStyleBackColor = True
        '
        'LoadInfoButton
        '
        Me.LoadInfoButton.Location = New System.Drawing.Point(363, 151)
        Me.LoadInfoButton.Name = "LoadInfoButton"
        Me.LoadInfoButton.Size = New System.Drawing.Size(102, 34)
        Me.LoadInfoButton.TabIndex = 11
        Me.LoadInfoButton.Text = "Load Website File"
        Me.LoadInfoButton.UseVisualStyleBackColor = True
        '
        'FileSearcher
        '
        Me.FileSearcher.FileName = "FileSearcher"
        Me.FileSearcher.Filter = "Autologger files (*.AL)|*.AL"
        '
        'Autologger
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(512, 369)
        Me.Controls.Add(Me.LoadInfoButton)
        Me.Controls.Add(Me.AddSiteButton)
        Me.Controls.Add(Me.SiteLoginsCheckbox)
        Me.Controls.Add(Me.ExitAfterLoginCheckbox)
        Me.Controls.Add(Me.QuitButton)
        Me.Controls.Add(Me.ConfirmButton)
        Me.Name = "Autologger"
        Me.Text = "AutoLogger"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ConfirmButton As System.Windows.Forms.Button
    Friend WithEvents QuitButton As System.Windows.Forms.Button
    Friend WithEvents ExitAfterLoginCheckbox As System.Windows.Forms.CheckBox
    Friend WithEvents SiteLoginsCheckbox As System.Windows.Forms.CheckedListBox
    Friend WithEvents AddSiteButton As System.Windows.Forms.Button
    Friend WithEvents LoadInfoButton As System.Windows.Forms.Button
    Friend WithEvents FileSearcher As System.Windows.Forms.OpenFileDialog

End Class
