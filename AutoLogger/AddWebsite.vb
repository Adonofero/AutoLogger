Imports System.IO
Public Class AddWebsite

    Private Sub CancelButton_Click(sender As Object, e As EventArgs) Handles CancelButton.Click
        Me.Close()
    End Sub

    Private Sub ConfirmButton_Click(sender As Object, e As EventArgs) Handles ConfirmButton.Click
        If (Chk_entry_vals()) Then
            Exit Sub
        End If

        Dim ourParent As Autologger = My.Forms.Autologger
        Dim fileCreated As Boolean = True
        Dim ourFile As String
        If (String.IsNullOrEmpty(ourParent.getLoadedFile)) Then
            If (NewFileSaveDialog.ShowDialog() = Windows.Forms.DialogResult.OK) Then
                ourFile = NewFileSaveDialog.FileName
                fileCreated = False
            Else
                MsgBox("File must be created or loaded to add information!", , "ERROR:")
                Exit Sub
            End If
        Else
            ourFile = ourParent.getLoadedFile
        End If
        AddEntryToFile(ourFile, fileCreated)
        ourParent.loadFile(ourFile)
        Me.Close()
    End Sub

    'Function: AddEntryToFile(WebsiteInformation) will add the given website's entry to the file
    'Note: may use fileCreated later as part of the encryption process when a new .AL file is created
    Private Sub AddEntryToFile(fileName As String, fileCreated As Boolean)
        If ((Not File.Exists(fileName)) And fileCreated) Then
            MsgBox("Loaded File does not exist!", , "ERROR:")
            Exit Sub
        End If

        Dim ALFile As StreamWriter
        If (fileCreated) Then
            Debug.Print(fileName)
            ALFile = File.AppendText(fileName)
        Else
            ALFile = File.CreateText(fileName)
        End If

        Dim textBoxes As System.Windows.Forms.TextBox()
        textBoxes = getTextboxes()
        For Each ourTextBox As System.Windows.Forms.TextBox In textBoxes
            ALFile.WriteLine(encrypt(ourTextBox.Text))
        Next
        ALFile.Close()

    End Sub

    'Function: chk_entry_vals() will verify that all the fields for the login are not empty.
    Private Function Chk_entry_vals() As Boolean
        Dim msg As String
        msg = ""
        Dim ErrorFound As Boolean = False

        ' Check for empty fields
        Dim errorMessage = New String() {"website alias", "website name", "user name", "password", "user EID", "password EID", "login EID"}
        Dim errorIndex As Integer = 0
        Dim textBoxes As System.Windows.Forms.TextBox()
        textBoxes = getTextboxes()
        For Each ourTextBox As System.Windows.Forms.TextBox In textBoxes

            If (String.IsNullOrEmpty(ourTextBox.Text)) Then
                msg = msg & "The " & errorMessage(errorIndex) & " has not been specified!" & vbCrLf
            End If
            errorIndex = errorIndex + 1
        Next

        'Display error message, if any exist
        If (Not String.Equals(msg, "")) Then
            MsgBox(msg, , "Error: No entry detected")
            ErrorFound = True
        End If

        Return ErrorFound
    End Function

    Private Function getTextboxes() As System.Windows.Forms.TextBox()
        Return New System.Windows.Forms.TextBox() {WebsiteAliasTextbox, WebsiteEntryTextbox, UserNameTextbox, PasswordEntryTextbox, UserEntryIDTextbox, PasswordEntryIDTextbox, LoginSubmitIDTextbox}
    End Function

    Private Function encrypt(toEncrypt As String) As String
        Dim encrypted As String = ""
        For i As Integer = 0 To (toEncrypt.Length - 1)
            Dim ourChar = toEncrypt.Chars(i)
            Dim ourInt = Convert.ToInt32(ourChar)
            ourInt = ourInt * ourInt
            ourInt = ourInt + 5
            ourInt = ourInt / 2
            ourChar = Convert.ToChar(ourInt)
            encrypted = String.Concat(encrypted, ourChar)
        Next
        Return encrypted
    End Function

End Class