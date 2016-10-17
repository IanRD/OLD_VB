Public Class Form1

    Private Sub Form1_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load

    End Sub
    Private Sub radDegreestoRadians_Click(sender As Object, e As System.EventArgs) Handles radDegreestoRadians.Click
        If radDegreestoRadians.Checked = True Then
            Dim value As Double = Val(cboAngle.Text)
            Dim answer As Decimal = DegreesToRadians(value)
            Me.lblAnswer.Text = value & " degrees = " & Math.Round(answer, 2) & " radians"
        End If
    End Sub


    Function DegreesToRadians(ByVal degrees As Double) As Double
        Return degrees * (Math.PI / 180)
    End Function
    Function RadiansToDegrees(ByVal radians As Double) As Double
        Return radians * (180 / Math.PI)

    End Function

    Private Sub radRadianstoDegrees_Click(sender As Object, e As System.EventArgs) Handles radRadianstoDegrees.Click
        If radRadianstoDegrees.Checked = True Then
            Dim value As Double = Val(cboAngle.Text)
            Dim answer As Decimal = RadiansToDegrees(value)
            Me.lblAnswer.Text = value & " radians = " & Math.Round(answer, 2) & " degrees"
        End If
    End Sub
End Class
