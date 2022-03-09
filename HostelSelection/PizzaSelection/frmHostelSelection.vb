'Name:      Ethan Anderson
'App Title: Hostel Selection
'Date:      2/22/2022
'Purpose:   This app allows users to select either a London or Dublin Hostel

Public Class frmHostelSelection

    Private Sub btnSelect_Click(sender As Object, e As EventArgs) Handles btnSelect.Click
        lblConfirm.Visible = True
        lblInstruct.Visible = False
        btnDublin.Enabled = False
        btnLondon.Enabled = False
        btnSelect.Enabled = False
        btnExit.Enabled = True
    End Sub

    Private Sub btnLondon_Click(sender As Object, e As EventArgs) Handles btnLondon.Click
        picLondon.Visible = True
        picDublin.Visible = False
        lblConfirm.Text = "You Have Selected The London Hostel"
        btnSelect.Enabled = True
    End Sub

    Private Sub btnDublin_Click(sender As Object, e As EventArgs) Handles btnDublin.Click
        picLondon.Visible = False
        picDublin.Visible = True
        lblConfirm.Text = "You Have Selected The Dublin Hostel"
        btnSelect.Enabled = True
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Close()
    End Sub

End Class
