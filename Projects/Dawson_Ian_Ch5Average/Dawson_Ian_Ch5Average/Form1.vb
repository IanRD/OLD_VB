Public Class Form1
    Dim numberOfScores As Integer = 0
    Dim sumOfScores As Integer = 0
    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim numberOfScores As Integer = 0
        Dim sumOfScores As Integer = 0
    End Sub

    Private Sub btnEnterScores_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnEnterScores.Click
        Const TITLE As String = "Scores"
        Const PROMPT As String = "Enter a score (-1 to stop):"
        Const FLAG As Integer = -1
        Dim tempScore As String
        Dim newScore As Integer
        numberOfScores = 0
        sumOfScores = 0

        'Clear labels
        Me.lblAverageMessage.Text = Nothing
        Me.lblAverage.Text = Nothing
        Me.lblScoresMessage.Text = Nothing
        Me.lblNumberofScores.Text = Nothing

        'Get scores
        tempScore = InputBox(PROMPT, TITLE)
        Do While tempScore <> Nothing And Val(tempScore) <> FLAG
            newScore = Val(tempScore)
            numberOfScores += 1
            sumOfScores += newScore
            tempScore = InputBox(PROMPT, TITLE)
        Loop
        Me.lblScoresMessage.Text = "Scores entered:"
        Me.lblNumberofScores.Text = numberOfScores
    End Sub

    Private Sub btnAverageScore_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnAverageScore.Click
        Dim average As Double
        Me.lblAverageMessage.Text = "Average Score:"
        If numberOfScores > 0 Then
            average = sumOfScores / numberOfScores
            Me.lblAverage.Text = average
        Else
            Me.lblAverage.Text = 0

        End If
    End Sub
End Class
