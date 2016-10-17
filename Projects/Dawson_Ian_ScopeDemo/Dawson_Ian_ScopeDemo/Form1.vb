Public Class ScopeDemo

    Dim X As Integer = 10
    Private Sub ScopeDemo_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btnProc1_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnProc1.Click
        Dim x As Integer = 3
        Me.lblanswer.Text = x
    End Sub

    Private Sub btnProc2_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnProc2.Click
        Me.lblanswer.Text = x
    End Sub
End Class
