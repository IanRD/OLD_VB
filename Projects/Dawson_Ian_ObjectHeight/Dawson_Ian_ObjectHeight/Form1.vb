Public Class Form1

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btnheight_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnheight.Click
        Dim h As Integer
        Dim t As Integer
        t = Val(Me.txtSeconds.Text)
        h = 100 - 4.9 * t ^ 2
        Me.lblheight.Text = h + 0.4
    End Sub
End Class
