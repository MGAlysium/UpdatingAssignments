'Name:      Ethan Anderson
'App Title: VB 2012 Terms App
'Date:      2/22/2022
'Purpose:   This app allows users to see the definitions for three VB terms

Public Class frmVB2012Terms

    Private Sub btnHardware_Click(sender As Object, e As EventArgs) Handles btnHardware.Click
        lblDefinition.Visible = True
        btnExit.Enabled = True
        lblDefinition.Text = "A person skilled in designing" + vbNewLine + "computer programs and" + vbNewLine +
            "implementing them in" + vbNewLine + "programming languages."
    End Sub

    Private Sub btnDeveloper_Click(sender As Object, e As EventArgs) Handles btnDeveloper.Click
        lblDefinition.Visible = True
        btnExit.Enabled = True
        lblDefinition.Text = "An individual or group" + vbNewLine + "that builds and" + vbNewLine +
            "creates software" + vbNewLine + "and applications."
    End Sub

    Private Sub btnRAD_Click(sender As Object, e As EventArgs) Handles btnRAD.Click
        lblDefinition.Visible = True
        btnExit.Enabled = True
        lblDefinition.Text = "A development model focused" + vbNewLine + "on quick prototyping and" +
            vbNewLine + "feedback over long-term" + vbNewLine + "development and testing."
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Close()
    End Sub

End Class
