Public Class Form1

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btnRandomNumbers_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnRandomNumbers.Click
        Randomize()
        Me.lblRandNum1.Text = Int(21 * Rnd() + 10)
        Me.lblRandNum2.Text = Int(21 * Rnd() + 10)
        Me.lblRandNum3.Text = Int(21 * Rnd() + 10)
        Me.lblRandNum4.Text = Int(21 * Rnd() + 10)
        Me.lblRandNum5.Text = Int(21 * Rnd() + 10)
        Me.lblRandNum6.Text = Int(21 * Rnd() + 10)
    End Sub
End Class