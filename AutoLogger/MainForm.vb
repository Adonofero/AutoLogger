Public Class Autologger

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub QuitButton_Click(sender As Object, e As EventArgs) Handles QuitButton.Click
        Application.Exit()
    End Sub

    Private Sub ConfirmButton_Click(sender As Object, e As EventArgs) Handles ConfirmButton.Click
        If (Chk_entry_vals()) Then
            Exit Sub
        End If

        Attempt_Login(WebsiteEntryTextbox.Text, UserNameTextbox.Text, PasswordEntryTextbox.Text, UserEntryIDTextbox.Text, PasswordEntryIDTextbox.Text, LoginSubmitIDTextbox.Text)

        If (ExitAfterLoginCheckbox.Checked) Then
            Application.Exit()
        End If

    End Sub

    'Sub: Attempt_Login(String, String, String) will naviagate to a website and attempt to login using the given url, user name, and password
    Private Sub Attempt_Login(URL As String, UserName As String, Password As String, NameEID As String, PasswordEID As String, LoginButtonEID As String)
        Dim IEInstance As Object
        IEInstance = CreateObject("InternetExplorer.Application")

        ' Navigate to the webpage
        With IEInstance
            .Navigate(URL)
            .Visible = True
            While .Busy Or .readyState <> 4 ' Busy wait until the webpage is fully loaded
                Dim i As Integer = 1
            End While
        End With

        ' Find the login and password and input them
        Dim HTMLDoc As Object = IEInstance.Document
        Dim WebsiteUserNameEntry As Object = HTMLDoc.getelementbyid(NameEID)
        Dim WebsitePasswordEntry As Object = HTMLDoc.getelementbyid(PasswordEID)
        Dim SubmitEntry As Object = HTMLDoc.getelementbyid(LoginButtonEID)
        WebsiteUserNameEntry.Value = UserName
        WebsitePasswordEntry.Value = Password
        SubmitEntry.Click()

        ' Wait until the entry information is complete
        With IEInstance
            While .Busy Or .readyState <> 4 ' Busy wait until the webpage is fully loaded
                Dim i As Integer = 1
            End While
        End With

    End Sub

    'Function: chk_entry_vals() will verify that all the fields for the login are not empty.
    Private Function Chk_entry_vals() As Boolean
        Dim msg As String
        msg = ""
        Dim ErrorFound As Boolean = False

        ' Check for empty fields
        Dim textBoxes = New System.Windows.Forms.TextBox() {WebsiteEntryTextbox, UserNameTextbox,  PasswordEntryTextbox, UserEntryIDTextbox, PasswordEntryIDTextbox, LoginSubmitIDTextbox}
        Dim errorMessage = New String() {"website name", "user name", "password", "user EID", "password EID", "login EID"}
        Dim errorIndex As Integer = 0
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
End Class
