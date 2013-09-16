Option Strict On

Public Class Form1

    Private Sub btnFirstName_Click(sender As System.Object, e As System.EventArgs) Handles btnFirstName.Click
        Dim fullname As String
        'read the input from the user
        fullname = txtFullName.Text

        'remove any extra spaces from the name by Trimming
        Dim fullnameTrimmed As String
        fullnameTrimmed = fullname.Trim()

        'Finds the index of the first space
        Dim idxSpace As Integer
        idxSpace = fullnameTrimmed.IndexOf(" ")

        'stores the first name as a result
        Dim firstName As String

        'extract the first name of the user by starting at character 0 and stopping at the space
        firstName = fullnameTrimmed.Substring(0, idxSpace)


        'display the result to the user
        txtFirstName.Text = firstName


    End Sub

    Private Sub TextBox1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtFirstName.TextChanged

    End Sub
End Class
