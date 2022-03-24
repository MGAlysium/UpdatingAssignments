Public Class frmTaxiFareApp

    Const taxPerc As Double = 0.0875

    Private Sub frmTaxiFareApp_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btnCalcCost_Click(sender As Object, e As EventArgs) Handles btnCalcCost.Click
        Dim inVal As Double = 0
        If txtCost.Text <> "" Then
            inVal = Convert.ToDouble(txtCost.Text)
        End If
        If inVal < 999 And inVal > 0 Then
            Dim tax As Double = inVal * taxPerc
            Dim outVal As Double = inVal + tax
            lblFinalCost.Text = "Item: " + txtName.Text + "     Cost: " + inVal.ToString("C") + vbNewLine +
                "Tax: " + tax.ToString("C") + "     Final: " + outVal.ToString("C")
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
        txtName.Text = ""
        txtCost.Text = ""
        btnClear.Enabled = False
        btnCalcCost.Enabled = True
        txtName.Focus()
        AcceptButton = btnCalcCost
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Close()
    End Sub
End Class
