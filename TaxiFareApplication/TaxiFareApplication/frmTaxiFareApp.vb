Public Class frmTaxiFareApp

    Const price As Double = 2.75
    Const flat As Double = 2.25

    Private Sub frmTaxiFareApp_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lblTicketCost.Text = flat.ToString("C") + " Flat Plus " + price.ToString("C") + "/Mile"
    End Sub

    Private Sub txtInput_TextChanged(sender As Object, e As EventArgs) Handles txtInput.TextChanged
        btnCalcCost.Enabled = True
        If txtInput.Text = "" Then
            btnClear.Enabled = False
        End If
    End Sub

    Private Sub btnCalcCost_Click(sender As Object, e As EventArgs) Handles btnCalcCost.Click
        Dim inVal As Double = Convert.ToDouble(txtInput.Text)
        If inVal < 999 And inVal > 0 Then
            inVal = inVal * price + flat
            lblFinalCost.Text = inVal.ToString("C")
        Else
            lblFinalCost.Text = "Invalid"
        End If
        lblFinalCost.Visible = True
        btnClear.Enabled = True
        btnCalcCost.Enabled = False
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        lblFinalCost.Text = ""
        lblFinalCost.Visible = False
        txtInput.Text = ""
        btnClear.Enabled = False
        btnCalcCost.Enabled = True
        txtInput.Focus()
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Close()
    End Sub
End Class
