Public Class Calculator

    Private Sub lblResult_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub txt0perand1_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles txt0perand1.TextChanged
        Me.radAddition.Checked = False
        Me.radDivision.Checked = False
        Me.radExponentiation.Checked = False
        Me.radIntdivision.Checked = False
        Me.radModdivision.Checked = False
        Me.radMultiplication.Checked = False
        Me.radSubtraction.Checked = False
        Me.lblexpressionvalue.Text = Nothing
    End Sub

    Private Sub txt0perand2_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles txt0perand2.TextChanged
        Me.radAddition.Checked = False
        Me.radDivision.Checked = False
        Me.radExponentiation.Checked = False
        Me.radIntdivision.Checked = False
        Me.radModdivision.Checked = False
        Me.radMultiplication.Checked = False
        Me.radSubtraction.Checked = False
        Me.lblexpressionvalue.Text = Nothing
    End Sub

    Private Sub radAddition_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles radAddition.Click
        Dim Answer As Double
        Answer = Val(Me.txt0perand1.Text) + Val(Me.txt0perand2.Text)
        Me.lblexpressionvalue.Text = Answer
    End Sub

    Private Sub radDivision_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles radDivision.Click
        Dim Answer As Double
        Answer = Val(Me.txt0perand1.Text) / Val(Me.txt0perand2.Text)
        Me.lblexpressionvalue.Text = Answer
    End Sub

    Private Sub radExponentiation_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles radExponentiation.Click
        Dim Answer As Double
        Answer = Val(Me.txt0perand1.Text) ^ Val(Me.txt0perand2.Text)
        Me.lblexpressionvalue.Text = Answer
    End Sub

    Private Sub radIntdivision_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles radIntdivision.Click
        Dim Answer As Double
        Answer = Val(Me.txt0perand1.Text) \ Val(Me.txt0perand2.Text)
        Me.lblexpressionvalue.Text = Answer
    End Sub

    Private Sub radModdivision_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles radModdivision.Click
        Dim Answer As Double
        Answer = Val(Me.txt0perand1.Text) Mod Val(Me.txt0perand2.Text)
        Me.lblexpressionvalue.Text = Answer
    End Sub

    Private Sub radMultiplication_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles radMultiplication.Click
        Dim Answer As Double
        Answer = Val(Me.txt0perand1.Text) * Val(Me.txt0perand2.Text)
        Me.lblexpressionvalue.Text = Answer
    End Sub

    Private Sub radSubtraction_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles radSubtraction.Click
        Dim Answer As Double
        Answer = Val(Me.txt0perand1.Text) - Val(Me.txt0perand2.Text)
        Me.lblexpressionvalue.Text = Answer
    End Sub
End Class
