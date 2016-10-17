Public Class Form1
    

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btnGo_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnGo.Click
        Const ROCK As Integer = 1
        Const PAPER As Integer = 2
        Const SCISSORS As Integer = 3
        Dim computerThrow As Integer
        Static UserWins As Integer
        Static ComputerWins As Integer
        Static Draws As Integer
        Me.lbluser.Text = UserWins
        Me.lblcomp.Text = ComputerWins
        Me.lbldraws.Text = Draws

        'Generate computer throw
        Randomize()
        computerThrow = Int(3 * Rnd() + 1)
        If Me.radRock.Checked And computerThrow = ROCK Then
            Me.lblwinner.Text = "Computer throws rock. It's a draw!"
            Draws += 1
        ElseIf Me.radRock.Checked And computerThrow = PAPER Then
            Me.lblwinner.Text = "Computer throws paper. Computer wins!"
            ComputerWins += 1
        ElseIf Me.radRock.Checked And computerThrow = SCISSORS Then
            Me.lblwinner.Text = "Computer throws scissors. You win!"
            UserWins += 1
        End If

        If Me.radPaper.Checked And computerThrow = ROCK Then
            Me.lblwinner.Text = "Computer throws rock. You win!"
            UserWins += 1
        ElseIf Me.radPaper.Checked And computerThrow = PAPER Then
            Me.lblwinner.Text = "Computer throws paper. It's a draw!"
            Draws += 1
        ElseIf Me.radPaper.Checked And computerThrow = SCISSORS Then
            Me.lblwinner.Text = "Computer throws scissors. Computer wins!"
            ComputerWins += 1
        End If
        If Me.radScissors.Checked And computerThrow = ROCK Then
            Me.lblwinner.Text = "Computer throws rock. Computer wins!"
            ComputerWins += 1
        ElseIf Me.radScissors.Checked And computerThrow = PAPER Then
            Me.lblwinner.Text = "Computer throws paper. You win!"
            UserWins += 1
        ElseIf Me.radScissors.Checked And computerThrow = SCISSORS Then
            Me.lblwinner.Text = "Computer throws scissors. It's a draw!"
            Draws += 1


        End If
    End Sub
End Class
