Public Class Form1

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btnTest_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnTest.Click
        'Get number from user
        Dim testNum As Integer = Val(Me.txtInteger.Text)

        'Test Number
        Dim divisor As Integer = 1
        If testNum <= 1 Then
            Me.lblPrimeResult.Text = "Not a prime number."
        Else
            Do
                divisor += 1
            Loop While testNum Mod divisor <> 0
            If divisor = testNum Then
                Me.lblPrimeResult.Text = "Prime number."
            Else
                Me.lblPrimeResult.Text = "Not a prime number."

            End If
        End If
    End Sub

    Private Sub txtInteger_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtInteger.TextChanged
        'Clear the previous test result
        Me.lblPrimeResult.Text = Nothing
    End Sub
End Class
