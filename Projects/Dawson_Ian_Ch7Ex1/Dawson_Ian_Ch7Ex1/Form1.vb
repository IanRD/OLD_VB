Public Class Form1

    Private Sub Form1_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btnSquare_Click(sender As Object, e As System.EventArgs) Handles btnSquare.Click
        Dim value As Integer = Val(Me.txtNumber.Text)
        Dim PerfectSquare As Boolean = False
        Dim SquareRoot As Decimal = Math.Sqrt(value)
        If SquareRoot = Int(SquareRoot) Then
            PerfectSquare = True
        End If
        If PerfectSquare = True Then
            Me.lblAnswer.Text = Space(14) & value & " is a perfect square!"
        End If
        If PerfectSquare = False Then
            Me.lblAnswer.Text = "THAT IS NOT A PERFECT SQUARE!"
        End If

    End Sub
End Class
