Public Class Form1

    Private Sub Form1_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub lstFunctions_Click(sender As Object, e As System.EventArgs) Handles lstFunctions.Click
        Dim AngleRadians As Double
        Dim Angle As Integer
        Angle = Val(Me.txtDegrees.Text)
        AngleRadians = DegreesToRadians(Angle)

        If Me.lstFunctions.SelectedItem = "Sine" Then
            Me.lblAnswer.Text = Math.Sin(AngleRadians)
        End If
        If Me.lstFunctions.SelectedItem = "Cosine" Then
            Me.lblAnswer.Text = Math.Cos(AngleRadians)

        End If
        If Me.lstFunctions.SelectedItem = "Tangent" Then
            Me.lblAnswer.Text = Math.Tan(AngleRadians)
        End If



    End Sub
    Function DegreesToRadians(ByVal degrees As Double) As Double
        Return degrees * (Math.PI / 180)
    End Function
End Class
