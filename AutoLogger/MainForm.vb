Imports System.IO

Public Class Autologger

    Public Structure WebsiteInformation
        Dim websiteAlias As String
        Dim websiteName As String
        Dim userName As String
        Dim password As String
        Dim userEID As String
        Dim passwordEID As String
        Dim submitButtomEID As String
    End Structure

    Private AllLoginInformation(20) As WebsiteInformation
    Private loginIndex As Integer = 0
    Private currentLoadedFile As String

    Public Function getLoadedFile() As String
        Return currentLoadedFile
    End Function

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub QuitButton_Click(sender As Object, e As EventArgs) Handles QuitButton.Click
        Application.Exit()
    End Sub

    Private Sub ConfirmButton_Click(sender As Object, e As EventArgs) Handles ConfirmButton.Click
        'For each website checked in the checkbox
        Dim checkedItems As New List(Of String)
        For i = 0 To (SiteLoginsCheckbox.CheckedItems.Count - 1)
            checkedItems.Add(SiteLoginsCheckbox.CheckedItems(i).ToString)
        Next

        'Attempt login
        For Each website As WebsiteInformation In AllLoginInformation
            If (website.websiteAlias Is Nothing) Then
                Continue For
            End If
            For Each item As String In checkedItems
                If (String.Equals(website.websiteAlias, item)) Then
                    Attempt_Login(website)
                    Exit For
                End If
            Next
        Next

        If (ExitAfterLoginCheckbox.Checked) Then
            Application.Exit()
        End If

    End Sub

    Private Function Decrypt(toDecrypt As String) As String
        Dim decrypted As String = ""
        For i As Integer = 0 To (toDecrypt.Length - 1)
            Dim ourChar = toDecrypt.Chars(i)
            Dim ourInt = Convert.ToInt32(ourChar)
            ourInt = ourInt * 2
            ourInt = ourInt - 5
            ourInt = Math.Sqrt(ourInt)
            ourChar = Convert.ToChar(ourInt)
            decrypted = String.Concat(decrypted, ourChar)
        Next
        Return decrypted
    End Function

    'Sub: Attempt_Login(String, String, String) will naviagate to a website and attempt to login using the given url, user name, and password
    Private Sub Attempt_Login(websiteInfo As WebsiteInformation)
        Dim IEInstance As Object
        IEInstance = CreateObject("InternetExplorer.Application")

        ' Navigate to the webpage
        With IEInstance
            .Navigate(websiteInfo.websiteName)
            .Visible = True
            While .Busy Or .readyState <> 4 ' Busy wait until the webpage is fully loaded
                Dim i As Integer = 1
            End While
        End With

        ' Find the login and password and input them
        Dim HTMLDoc As Object = IEInstance.Document
        Dim WebsiteUserNameEntry As Object = HTMLDoc.getelementbyid(websiteInfo.userEID)
        Dim WebsitePasswordEntry As Object = HTMLDoc.getelementbyid(websiteInfo.passwordEID)
        Dim SubmitEntry As Object = HTMLDoc.getelementbyid(websiteInfo.submitButtomEID)
        If (WebsiteUserNameEntry Is DBNull.Value Or WebsitePasswordEntry Is DBNull.Value Or SubmitEntry Is DBNull.Value) Then
            MsgBox("One or more of the EIDs is incorrect!", , "ERROR:")
            Exit Sub
        End If
        WebsiteUserNameEntry.Value = websiteInfo.userName
        WebsitePasswordEntry.Value = websiteInfo.password
        SubmitEntry.Click()

        ' Wait until the entry information is complete
        With IEInstance
            While .Busy Or .readyState <> 4 ' Busy wait until the webpage is fully loaded
                Dim i As Integer = 1
            End While
        End With

    End Sub

    'Sub: loadFile() will load a file and parse it for site information to use as logins
    Public Sub loadFile(fileName As String)
        'Check file existance
        If (Not File.Exists(fileName)) Then
            MsgBox("File does not exist!", , "Error:")
            Exit Sub
        End If

        'Read the file in and use it to populate our structs
        Dim fileReader As StreamReader = File.OpenText(fileName)
        Dim fileLines(7) As String
        Dim lineCounter As Integer = 0
        loginIndex = 0
        Do Until fileReader.Peek = -1
            fileLines(lineCounter) = Decrypt(fileReader.ReadLine)
            lineCounter += 1
            If (lineCounter = 7) Then
                lineCounter = 0
                Dim newWebsiteInfo As WebsiteInformation
                newWebsiteInfo.websiteAlias = fileLines(0)
                newWebsiteInfo.websiteName = fileLines(1)
                newWebsiteInfo.userName = fileLines(2)
                newWebsiteInfo.password = fileLines(3)
                newWebsiteInfo.userEID = fileLines(4)
                newWebsiteInfo.passwordEID = fileLines(5)
                newWebsiteInfo.submitButtomEID = fileLines(6)
                AllLoginInformation(loginIndex) = newWebsiteInfo
                loginIndex += 1
            End If
        Loop
        fileReader.Close()

        'Display our structs in the checkbox menu
        updateCheckboxes()

        currentLoadedFile = fileName
    End Sub

    Private Sub AddSiteButton_Click(sender As Object, e As EventArgs) Handles AddSiteButton.Click
        Dim AddWebsiteForm As New AddWebsite
        AddWebsiteForm.ShowDialog()
    End Sub

    Private Sub LoadInfoButton_Click(sender As Object, e As EventArgs) Handles LoadInfoButton.Click
        'Get the file name specified by the user
        If (FileSearcher.ShowDialog() = Windows.Forms.DialogResult.Cancel) Then
            Exit Sub
        End If

        'Check the file for existance
        loadFile(FileSearcher.FileName)
    End Sub

    Private Sub updateCheckboxes()
        SiteLoginsCheckbox.Items.Clear()
        For Each website As WebsiteInformation In AllLoginInformation
            If (String.IsNullOrEmpty(website.websiteAlias)) Then
                Continue For
            End If
            Dim ourItem As Object
            ourItem = website.websiteAlias
            SiteLoginsCheckbox.Items.Add(ourItem, False)
        Next
    End Sub

End Class
