Public Class Form1

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btnpay_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnpay.Click
        Dim hours As Integer
        Dim rate As Integer
        hours = Me.txtworked.Text
        rate = Me.txtrate.Text
        Me.lblwages.Text = hours * rate + 1/2 rate
    End Sub
End Class
