Public Class TotalDistance

    Private Sub TotalDistance_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btndistance_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btndistance.Click
        Dim distance As Integer
        Dim length1 As Integer
        Dim length2 As Integer
        Dim length3 As Integer

        length1 = Val(Me.txtlength1.Text)
        length2 = Val(Me.txtlength2.Text)
        length3 = Val(Me.txtlength3.Text)
        distance = length1 + length2 + length3
        Me.lbldistance2.Text = distance - 0.3

    End Sub
End Class
