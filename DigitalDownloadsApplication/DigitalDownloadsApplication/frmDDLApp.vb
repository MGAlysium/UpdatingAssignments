Public Class frmDDLApp

    Const price As Double = 3.5

    Private Sub frmDDLApp_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lbl99Cents.Text = price.ToString("C") + " per Download"
    End Sub

    Private Sub tbxInput_TextChanged(sender As Object, e As EventArgs) Handles tbxInput.TextChanged
        btnCalcCost.Enabled = True
        If tbxInput.Text = "" Then
            btnClear.Enabled = False
            AcceptButton = btnCalcCost
        End If
    End Sub

    Private Sub btnCalcCost_Click(sender As Object, e As EventArgs) Handles btnCalcCost.Click
        Dim inVal As Double = 0
        If tbxInput.Text <> "" Then
            inVal = Convert.ToDouble(tbxInput.Text)
        End If
        If inVal < 999 And inVal > 0 Then
            inVal = inVal * price
            lblFinalCost.Text = inVal.ToString("C")
        Else
            lblFinalCost.Text = "Invalid"
        End If
        lblFinalCost.Visible = True
        btnClear.Enabled = True
        btnCalcCost.Enabled = False
        AcceptButton = btnClear
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        lblFinalCost.Text = ""
        lblFinalCost.Visible = False
        tbxInput.Text = ""
        btnClear.Enabled = False
        btnCalcCost.Enabled = True
        tbxInput.Focus()
        AcceptButton = btnCalcCost
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Close()
    End Sub
End Class
