Public Class Form1
    Const MIN As Integer = 1
    Const MAX As Integer = 50
    Private Sub Label1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblprompt.Click

    End Sub

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btncheckguess_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btncheckguess.Click

    End Sub

    Sub GiveHint(ByVal firstNum As Integer, ByVal secondNum As Integer)
        If firstNum > secondNum Then
            Me.lblmessage.Text = "Too low."
        Else
            Me.lblmessage.Text = "Too High."
        End If
    End Sub

End Class
