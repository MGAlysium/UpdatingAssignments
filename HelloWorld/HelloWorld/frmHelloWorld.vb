Public Class frmHelloWorld
    Private Sub EnterButton_Click(sender As Object, e As EventArgs) Handles btnEnter.Click
        Dim name As String = Me.tbxInput.Text
        Dim firstLetter As String = name.Substring(0, 1)
        Dim restOfName As String = name.Substring(1, name.Length - 1)
        name = firstLetter.ToUpper() & restOfName.ToLower()
        Me.lblNameOut.Text = ">> Hello " & name & "!"
    End Sub
End Class
