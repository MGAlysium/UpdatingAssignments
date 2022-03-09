Public Class frmPizzaSelection

    Private Sub btnDeepDish_Click(sender As Object, e As EventArgs) Handles btnDeepDish.Click
        picDeepDish.Visible = True
        picThinCrust.Visible = False
        lblConfirm.Text = "Deep Dish Selected"
        btnSelect.Enabled = True
    End Sub

    Private Sub btnThinCrust_Click(sender As Object, e As EventArgs) Handles btnThinCrust.Click
        picDeepDish.Visible = False
        picThinCrust.Visible = True
        lblConfirm.Text = "Thin Crust Selected"
        btnSelect.Enabled = True
    End Sub

    Private Sub btnSelect_Click(sender As Object, e As EventArgs) Handles btnSelect.Click
        btnDeepDish.Enabled = False
        btnThinCrust.Enabled = False
        btnSelect.Enabled = False
        btnExit.Enabled = True
        lblInstruct.Visible = False
        lblConfirm.Visible = True
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Close()
    End Sub

End Class
