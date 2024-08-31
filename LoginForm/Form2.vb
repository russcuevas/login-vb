Public Class Form2

    Private Sub btnAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAdd.Click
        Dim Operand1 As Double
        Dim Operand2 As Double
        Dim Result As Double

        Operand1 = Double.Parse(txtOperand1.Text)
        Operand2 = Double.Parse(txtOperand2.Text)
        Result = Operand1 + Operand2

        lblOperator.Text = "+"
        lblDisplay.Text = "₱" + Result.ToString("N")
    End Sub

    Private Sub btnClear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClear.Click
        txtOperand1.Clear()
        txtOperand2.Clear()
        lblOperator.Text = ""
        lblDisplay.Text = ""

        txtOperand1.Focus()
    End Sub

    Private Sub btnExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExit.Click
        Close()
    End Sub
End Class