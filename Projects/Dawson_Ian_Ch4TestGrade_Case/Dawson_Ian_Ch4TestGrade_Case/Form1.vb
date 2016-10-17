Public Class Form1

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btnscore_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnscore.Click
        Dim score As Integer
        score = Val(TXTSCORE.Text)
        Select Case score
            Case Is > 90
                Me.lblscore.Text = "A"
            Case Is >= 80
                Me.lblscore.Text = "B"
            Case Is >= 70
                Me.lblscore.Text = "C"
            Case Is >= 60
                Me.lblscore.Text = "D"
            Case Is < 60
                Me.lblscore.Text = "F"

        End Select
    End Sub
End Class
