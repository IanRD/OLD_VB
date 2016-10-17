Public Class Form1

    Private Sub Form1_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btnRound_Click(sender As Object, e As System.EventArgs) Handles btnRound.Click
        Dim number As Double = Val(txtNumber.Text)
        Dim decimals As Integer = Val(txtDecimal.Text)
        Me.lblRound.Text = Math.Round(number, decimals)
    End Sub
End Class
