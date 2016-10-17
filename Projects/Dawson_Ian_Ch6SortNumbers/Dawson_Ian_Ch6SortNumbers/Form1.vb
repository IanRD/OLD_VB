Public Class Form1

    Private Sub Form1_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btnSort_Click(sender As Object, e As System.EventArgs) Handles btnSort.Click
        Dim value As Integer
        Dim value2 As Integer
        value = Val(Me.txtFirst.Text)
        value2 = Val(Me.txtSecond.Text)
        Call LowestToHighest(value, value2)
        Me.lblOrder.Text = value & ", " & value2

        Me.lblOrder.Text = value & ", " & value2
        If value > value2 Then
            Me.lblOrder.Text = value2 & ", " & value
        ElseIf value2 > value Then
            Me.lblOrder.Text = value & ", " & value2
        End If



    End Sub
    Sub LowestToHighest(ByRef lowest As Integer, ByRef highest As Integer)
        lowest = Val(Me.txtFirst.Text)
        highest = Val(Me.txtSecond.Text)

    End Sub
End Class
