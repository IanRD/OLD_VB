Public Class Form1
    Sub DataChanged(sender As System.Object, e As System.EventArgs) Handles lstCourseLevels.SelectedIndexChanged, cboCreditHours.SelectedIndexChanged, cboCreditHours.TextChanged
        Me.lblTuition.Text = Nothing
    End Sub

    Private Sub btnCalculate_Click(sender As Object, e As System.EventArgs) Handles btnCalculate.Click
        Const UNDERGRADUATE_PER_HOUR As Decimal = 75
        Const GRADUATE_PER_HOUR As Decimal = 145
        Const THESIS_PER_HOUR As Decimal = 160
        Dim tuition As Decimal
        Dim creditHours As Integer

        If Me.cboCreditHours.SelectedIndex >= 0 Then
            creditHours = Val(Me.cboCreditHours.SelectedItem)
        Else
            creditHours = Val(Me.cboCreditHours.Text)
        End If


        Select Case Me.lstCourseLevels.SelectedItem
            Case "Undergraduate"
                tuition = UNDERGRADUATE_PER_HOUR * creditHours
            Case "Graduate"
                tuition = GRADUATE_PER_HOUR * creditHours
            Case "Thesis and Dissertation"
                tuition = THESIS_PER_HOUR * creditHours

        End Select

        Me.lblTuition.Text = "Tuition is " & Format(tuition, "Currency")

    End Sub
End Class
