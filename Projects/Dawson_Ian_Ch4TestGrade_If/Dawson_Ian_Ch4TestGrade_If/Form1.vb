Public Class Form1

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button1_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnscore.Click
        Dim guess As Integer
        guess = Val(TXTSCORE.Text)
        If guess >= 90 Then
            Me.lblscore.Text = "Great!"
        ElseIf guess >= 70 Then
            Me.lblscore.Text = "Good Job!"
        Else
            Me.lblscore.Text = "Study More."
        End If

    End Sub
End Class
