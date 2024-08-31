Public Class Form1

    Dim userName As String
    Dim password As String
    Dim retry As Integer = 0
    Dim process As Boolean
    Dim MaxAttempts As Integer = 5

    Private Sub LoginButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LoginButton.Click

        userName = TextBox1.Text
        password = TextBox2.Text

        process = True
        retry = retry + 1

        While process = True
            If userName = "Russel" And password = "hello" Then
                lblmessage.Text = "Welcome " & userName
                process = False
                retry = 0
                MsgAttempt.Text = ""
                Dim form2 As New Form2
                form2.Show()
                Me.Hide()
            Else
                MsgBox("Wrong Information, Please Try Again")
                MsgAttempt.Text = "Attempts: " & (MaxAttempts - retry) & " attempts remaining"
                process = False
            End If

            If retry = MaxAttempts Then
                LoginButton.Enabled = False
                MsgBox("Sorry your account is locked out")
                MsgAttempt.Text = "Sorry, your account is locked out"
            End If

        End While
    End Sub
End Class