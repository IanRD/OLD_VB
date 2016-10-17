Public Class Form1

    Private Sub lstPyth_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles lstPyth.SelectedIndexChanged

    End Sub

    Private Sub btnCompute_Click(sender As Object, e As System.EventArgs) Handles btnCompute.Click
        Dim PerfectSquare As Boolean = False
        Dim A As Integer
        Dim B As Integer
        Dim C As Double
        For A = 1 To 99
            For B = A To 99
                C = Math.Sqrt(A ^ 2 + B ^ 2)
                If C = Int(C) Then

                    PerfectSquare = True
                    If PerfectSquare = True Then
                        Me.lstPyth.Items.Add(A & Space(20) & B & Space(20) & C)
                    End If
                End If
            Next B
        Next A


    End Sub
End Class
