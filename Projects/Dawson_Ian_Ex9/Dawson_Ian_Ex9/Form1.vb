Public Class Form1

    Private Sub RadioButton1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnmts.CheckedChanged

    End Sub

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btnmts_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnmts.Click
        Dim minutes As Integer
        Dim seconds As Integer
        minutes = Val(Me.txtminutes.Text)
        seconds = minutes * 60
        Me.lbl1.Text = seconds
    End Sub

    Private Sub btnmth_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnmth.Click
        Dim minutes As Integer
        Dim hours As Integer
        minutes = Val(Me.txtminutes.Text)
        hours = minutes / 60
        Me.lbl1.Text = hours
        Me.lbl15.Text = minutes - 60
    End Sub
End Class
