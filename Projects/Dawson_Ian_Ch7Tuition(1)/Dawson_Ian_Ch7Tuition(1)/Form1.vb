Public Class Form1
    Private Sub lstCourseLevels_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles lstCourseLevels.SelectedIndexChanged
        Me.lblTuition.Text = Nothing
    End Sub

    Private Sub btnCalculate_Click(sender As Object, e As System.EventArgs) Handles btnCalculate.Click
        Const UNDERGRADUATE_PER_HOUR As Decimal = 75
        Const GRADUATE_PER_HOUR As Decimal = 145
        Const THESIS_PER_HOUR As Decimal = 160
        Dim tuition As Decimal



        Select Case Me.lstCourseLevels.SelectedItem
            Case "Undergraduate"
                tuition = UNDERGRADUATE_PER_HOUR
            Case "Graduate"
                tuition = GRADUATE_PER_HOUR
            Case "Thesis and Dissertation"
                tuition = THESIS_PER_HOUR
                
        End Select

        Me.lblTuition.Text = "Tuition is " & Format(tuition, "Currency") & _
        " per credit hour."

    End Sub
End Class
