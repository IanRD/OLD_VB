Public Class Form1

    Private Sub Form1_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btnExp_Click(sender As Object, e As System.EventArgs) Handles btnExp.Click
        Me.lblAnswer.Text = "e ^ " & Me.txtNumber.Text & " = " & Math.Exp(Me.txtNumber.Text)
    End Sub

    Private Sub btnLogarithm_Click(sender As Object, e As System.EventArgs) Handles btnLogarithm.Click
        Me.lblAnswer.Text = "In(" & Me.txtNumber.Text & ") = " & Math.Log(Me.txtNumber.Text)
    End Sub
End Class
