Public Class Form1
    Const MIN As Integer = 1
    Const MAX As Integer = 50
    Private Sub Label1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblprompt.Click

    End Sub

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btncheckguess_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btncheckguess.Click
        Randomize()
        Static secretNumber As Integer = Int((MAX - MIN + 1) * Rnd() + MIN)
        Dim guess As Integer
        guess = Val(Me.txtplayerguess.Text)
        If guess < MIN Or guess > MAX Then
            MessageBox.Show("Guess out of range.")
        ElseIf guess = secretNumber Then
            Me.lblmessage.Text = "You guessed it!"
        Else
            Call GiveHint(secretNumber, guess)
        End If
    End Sub

    Sub GiveHint(ByVal firstNum As Integer, ByVal secondNum As Integer)
        If firstNum > secondNum Then
            MessageBox.Show("Too low.")
        Else
            MessageBox.Show("Too high.")
        End If
    End Sub

End Class
