Public Class Form1

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub MiddleCenterToolStripMenuItem_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles MiddleCenterToolStripMenuItem.Click
        lblhere.ImageAlign = ContentAlignment.MiddleCenter
    End Sub

    Private Sub ExitToolStripMenuItem_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles ExitToolStripMenuItem.Click
        Application.Exit()
    End Sub

End Class