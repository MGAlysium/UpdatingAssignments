'Name:      Ethan Anderson
'App Title: Online Store Specials App
'Date:      2/22/2022
'Purpose:   This app allows users to select from three online store specials

Public Class frmOnlineSpecials

    Dim selectedSpecial As Integer = 0

    Private Sub btnDaily_Click(sender As Object, e As EventArgs) Handles btnDaily.Click
        btnCart.Enabled = True

        selectedSpecial = 1

        btnDaily.Enabled = False
        btnWeekly.Enabled = True
        btnHoliday.Enabled = True

        picDaily.Visible = True
        picWeekly.Visible = False
        picHoliday.Visible = False

        lblDaily.Visible = True
        lblWeekly.Visible = False
        lblHoliday.Visible = False
    End Sub

    Private Sub btnWeekly_Click(sender As Object, e As EventArgs) Handles btnWeekly.Click
        btnCart.Enabled = True

        selectedSpecial = 2

        btnDaily.Enabled = True
        btnWeekly.Enabled = False
        btnHoliday.Enabled = True

        picDaily.Visible = False
        picWeekly.Visible = True
        picHoliday.Visible = False

        lblDaily.Visible = False
        lblWeekly.Visible = True
        lblHoliday.Visible = False
    End Sub

    Private Sub btnHoliday_Click(sender As Object, e As EventArgs) Handles btnHoliday.Click
        btnCart.Enabled = True

        selectedSpecial = 3

        btnDaily.Enabled = True
        btnWeekly.Enabled = True
        btnHoliday.Enabled = False

        picDaily.Visible = False
        picWeekly.Visible = False
        picHoliday.Visible = True

        lblDaily.Visible = False
        lblWeekly.Visible = False
        lblHoliday.Visible = True
    End Sub

    Private Sub btnCart_Click(sender As Object, e As EventArgs) Handles btnCart.Click
        btnDaily.Enabled = False
        btnWeekly.Enabled = False
        btnHoliday.Enabled = False
        btnCart.Enabled = False
        btnExit.Enabled = True

        lblDaily.Visible = False
        lblWeekly.Visible = False
        lblHoliday.Visible = False

        Select Case selectedSpecial
            Case 1
                lblDailySelect.Visible = True
            Case 2
                lblWeeklySelect.Visible = True
            Case 3
                lblHolidaySelect.Visible = True
        End Select
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Close()
    End Sub

End Class
