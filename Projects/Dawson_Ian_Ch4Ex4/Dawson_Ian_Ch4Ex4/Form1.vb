Public Class Form1

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btnpackage_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnpackage.Click
        Dim weight As Integer
        Dim height As Integer
        Dim width As Integer
        Dim length As Integer
        weight = Val(Me.txtweight.Text)
        height = Val(Me.txtheight.Text)
        length = Val(Me.txtlength.Text)
        width = Val(Me.txtwidth.Text)

        If weight > 27 Then
            Me.lblrejected.Text = "Rejected: Too heavy"
        ElseIf Me.lblrejected.Text = "" Then
        End If
        If height + width + length >= 100000 Then
            Me.lblrejected.Text = "Rejected: Too big"
        ElseIf Me.lblrejected.Text = "" Then
        End If
        If weight > 27 And height + width + length >= 100000 Then
            Me.lblrejected.Text = "Rejected: Too big and heavy"
        End If
        If height + width + length <= 100000 And weight < 28 And height + width + length > 0 Then
            Me.lblrejected.Text = "Conglaturation - A Winner is You!"
        End If
    End Sub
End Class
