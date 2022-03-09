'Name:      Ethan Anderson
'App Title: Student Picnic App
'Date:      2/22/2022
'Purpose:   This app allows users to see the date and location of a student picnic

Public Class frmStudentPicnicApp

    Private Sub btnStudentInfo_Click(sender As Object, e As EventArgs) Handles btnStudentInfo.Click
        lblInfo.Visible = True
        btnStudentInfo.Enabled = False
        btnExit.Enabled = True
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Close()
    End Sub

End Class
