Public Class frmDogYearsApp

    Private Sub txtInput_TextChanged(sender As Object, e As EventArgs) Handles txtInput.TextChanged
        btnCalcCost.Enabled = True
        If txtInput.Text = "" Then
            btnClear.Enabled = False
        End If
    End Sub

    Private Sub btnCalcCost_Click(sender As Object, e As EventArgs) Handles btnCalcCost.Click
        Dim inVal As Double = Convert.ToDouble(txtInput.Text)
        If inVal < 30 And inVal > 0 Then
            Dim outVal As Double
            outVal = inVal * 7
            lblFinalCost.Text = "Your Dog Is " + CStr(inVal) + " In Dog Years" + vbNewLine + vbNewLine +
                "And " + CStr(outVal) + " In Human Years"
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
