Public Class frmDogYearsApp

    Private Sub txtInput_TextChanged(sender As Object, e As EventArgs) Handles txtInput.TextChanged
        btnCalcCost.Enabled = True
        If txtInput.Text = "" Then
            btnClear.Enabled = False
        End If
    End Sub

    Private Sub btnCalcCost_Click(sender As Object, e As EventArgs) Handles btnCalcCost.Click
        Dim inVal As Double = 0
        If txtInput.Text <> "" Then
            inVal = Convert.ToDouble(txtInput.Text)
        End If
        If inVal < 30 And inVal > 0 Then
            Dim outVal As Double
            outVal = inVal * 7
            lblFinalCost.Text = "Your Dog Is " + CStr(inVal) + " Years Old" + vbNewLine + vbNewLine +
                "And " + CStr(outVal) + " In People Years"
        End If
        lblFinalCost.Visible = True
        btnClear.Enabled = True
        btnCalcCost.Enabled = False
        AcceptButton = btnClear
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        lblFinalCost.Text = ""
        lblFinalCost.Visible = False
        txtInput.Text = ""
        btnClear.Enabled = False
        btnCalcCost.Enabled = True
        txtInput.Focus()
        AcceptButton = btnCalcCost
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Close()
    End Sub
End Class
