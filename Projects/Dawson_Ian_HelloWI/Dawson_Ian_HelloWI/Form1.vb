Public Class Form1

    Private Sub Label1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblGreeting.Click

    End Sub

    Private Sub radEnglish_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles radEnglish.Click
        Me.lblGreeting.Text = "Hello, World!"

    End Sub

    Private Sub radSpanish_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles radSpanish.Click
        Me.lblGreeting.Text = "Hola, mundo!"
    End Sub

    Private Sub radFrench_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles radFrench.Click
        Me.lblGreeting.Text = "Bonjour le monde!"
    End Sub

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub
End Class
