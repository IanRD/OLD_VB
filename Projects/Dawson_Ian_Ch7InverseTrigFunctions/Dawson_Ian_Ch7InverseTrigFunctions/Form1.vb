Public Class Form1
    
    Private Sub Form1_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load

    End Sub
    Private Sub btnArcCosine_Click(sender As Object, e As System.EventArgs) Handles btnArcCosine.Click
        Dim value As Decimal = Me.txtValue.Text
        Dim answer As Double = Math.Acos(value)

        Me.lblAnswer.Text = "An angle with cosine " & value & " is " & Math.Round(RadiansToDegrees(answer), 2) & " degrees."
    End Sub

    Function RadiansToDegrees(ByVal radians As Double) As Double
        Return radians * (180 / Math.PI)

    End Function

    Private Sub btnArcSine_Click(sender As Object, e As System.EventArgs) Handles btnArcSine.Click
        Dim value As Decimal = Me.txtValue.Text
        Dim answer As Double = Math.Asin(value)
        Me.lblAnswer.Text = "An angle with sine " & value & " is " & Math.Round(RadiansToDegrees(answer), 2) & " degrees."
    End Sub

    Private Sub btnArcTangent_Click(sender As Object, e As System.EventArgs) Handles btnArcTangent.Click
        Dim value As Decimal = Me.txtValue.Text
        Dim answer As Double = Math.Atan(value)
        Me.lblAnswer.Text = "An angle with tangent " & value & " is " & Math.Round(RadiansToDegrees(answer), 2) & " degrees."
    End Sub
End Class
