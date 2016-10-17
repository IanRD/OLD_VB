Public Class Form1

    Private Sub Form1_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btnCalculate_Click(sender As Object, e As System.EventArgs) Handles btnCalculate.Click
        Dim Initial As Decimal = Me.txtInitial.Text
        Dim Constant As Decimal = Me.txtK.Text
        Dim Time As Decimal = Me.txtTime.Text
        Dim Answer As Decimal

        answer = (Math.E ^ (Constant * time)) * Initial

        lblAnswer.Text = Math.Round(Answer, 2) & " bacteria will be present after " _
            & Time & " hours if there were initially " & Initial & "  bacteria  and k " _
            & "is " & Constant
    End Sub
End Class
