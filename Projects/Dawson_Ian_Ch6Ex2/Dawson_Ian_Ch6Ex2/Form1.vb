Public Class Form1
    Dim quarters, dimes, pennies, nickels As Integer
    Private Sub Form1_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btnAddCoins_Click(sender As Object, e As System.EventArgs) Handles btnAddCoins.Click
        Me.lblMoney.Text = TotalDollars(quarters, dimes, nickels, pennies)
        dimes = Val(Me.txtDimes.Text)
        quarters = Val(Me.txtQuarters.Text)
        nickels = Val(Me.txtNickels.Text)
        pennies = Val(Me.txtPennies.Text)
    End Sub

    Function TotalDollars(ByVal quarters As Integer, ByVal dimes As Integer, ByVal nickels As Integer, ByVal pennies As Integer) As Double
        Return (quarters * 0.25) + (dimes * 0.1) + (nickels * 0.05) + (pennies * 0.01)


    End Function
End Class
