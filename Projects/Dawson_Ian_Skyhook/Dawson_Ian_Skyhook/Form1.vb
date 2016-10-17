Public Class SkyhookInternational

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub


    Private Sub btnship_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnship.Click
        Dim number As Integer
        Dim ship As Integer
        Dim ship2 As Integer
        number = Val(Me.txt26.Text)
        ship = number - 18
        ship2 = number - 24
        Me.Label1.Text = ship
        Me.Label2.Text = ship2

    End Sub
End Class
