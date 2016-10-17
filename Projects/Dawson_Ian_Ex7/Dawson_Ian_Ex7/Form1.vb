Public Class Form1

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btncoins_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btncoins.Click
        Dim pennies As Integer
        Dim nickels As Integer
        Dim dimes As Integer
        Dim quarters As Integer
        Dim cents As Integer
        cents = Val(Me.txtcents.Text)
        pennies = 1
        nickels = 5
        dimes = 10
        quarters = 25
        Me.lbldimes.Text = (cents Mod dimes) / 2
        Me.lblpennies.Text = cents Mod nickels / pennies
        Me.lblquarters.Text = cents \ quarters
        Me.lblnickels.Text = (cents Mod nickels) / 2


    End Sub
End Class
