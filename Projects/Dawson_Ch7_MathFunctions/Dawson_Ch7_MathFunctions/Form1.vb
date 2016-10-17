Public Class Form1

    Private Sub Form1_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btnAbsoluteValue_Click(sender As Object, e As System.EventArgs) Handles btnAbsoluteValue.Click
        Dim number As Double = Val(txtNumber.Text)
        Me.lblSTUFF.Text = "The absolute value of " & Me.txtNumber.Text & " is " & Math.Abs(number)

    End Sub

    Private Sub btnSign_Click(sender As Object, e As System.EventArgs) Handles btnSign.Click
        Dim number As Double = Val(txtNumber.Text)
        Me.lblSTUFF.Text = "The sign root of " & Me.txtNumber.Text & " is " & Math.Sign(number)
    End Sub

    Private Sub btnSquareRoot_Click(sender As Object, e As System.EventArgs) Handles btnSquareRoot.Click
        Dim number As Double = Val(txtNumber.Text)
        Me.lblSTUFF.Text = "The square root of " & Me.txtNumber.Text & " is " & Math.Sqrt(number)
    End Sub
End Class
