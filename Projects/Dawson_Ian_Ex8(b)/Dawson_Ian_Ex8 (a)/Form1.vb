Public Class Form1

    Private Sub btndigits_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btndigits.Click
        Dim digit1 As Integer
        Dim digit2 As Integer
        Dim number As Integer
        number = Val(Me.txtnumb.Text)
        digit1 = number / 10
        digit2 = number / 16
        Me.lbldigit1.Text = digit1 / 1
        Me.lbldigit2.Text = digit2 / 1
    End Sub

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub DigitsToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DigitsToolStripMenuItem.Click
        Dim digit1 As Integer
        Dim digit2 As Integer
        Dim number As Integer
        number = Val(Me.txtnumb.Text)
        digit1 = number / 10
        digit2 = number / 16
        Me.lbldigit1.Text = digit1 / 1
        Me.lbldigit2.Text = digit2 / 1
    End Sub
End Class


