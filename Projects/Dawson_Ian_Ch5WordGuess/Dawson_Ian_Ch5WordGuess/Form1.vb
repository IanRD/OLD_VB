Public Class Form1
    'SCORE CHANGES WHEN PLAY GAME BUTTON IS CLICKED
    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
    End Sub

    Private Sub btnPlayGame_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnPlayGame.Click
        Const SECRET_WORD As String = "NOODLE"
        Const FLAG As Char = "!"
        Const GUESS_PROMPT As String = "Enter a letter or " & FLAG & " to guess word:"
        Dim numGuesses As Integer = 0
        Dim letterGuess As Char
        Dim wordGuess As String
        Dim tempWord As String
        Dim endGame As Boolean
        Static score As Integer = 100
        Me.lblScore.Text = score
        'Set number of dashes as letters in SECRET_WORD
        Dim wordGuessedSoFar As String = ""
        Dim length As Integer = SECRET_WORD.Length
        wordGuessedSoFar = wordGuessedSoFar.PadLeft(length, "-")
        Me.lblSecretWord.Text = wordGuessedSoFar

        'Get first guess
        Dim tempLetterGuess = InputBox(GUESS_PROMPT, Me.Text)
        'Test data entered
        If tempLetterGuess = Nothing Then
            endGame = True
        End If

        Do While letterGuess <> FLAG And wordGuessedSoFar <> SECRET_WORD _
        And Not endGame
            numGuesses += 1
            If letterGuess <> SECRET_WORD Then
                score -= 10

            End If
            For letterPos As Integer = 0 To SECRET_WORD.Length - 1
                If SECRET_WORD.Chars(letterPos) = Char.ToUpper(letterGuess) Then
                    'Remove dash at position of letter guessed.
                    tempWord = wordGuessedSoFar.Remove(letterPos, 1)
                    'Insert guessed letter
                    wordGuessedSoFar = tempWord.Insert(letterPos, Char.ToUpper(letterGuess))
                    'Update interface
                    Me.lblSecretWord.Text = wordGuessedSoFar
                End If
            Next letterPos
            'Get next letter if word hasn't been guessed.
            If wordGuessedSoFar <> SECRET_WORD Then
                'Get user guess
                tempLetterGuess = InputBox(GUESS_PROMPT, Me.Text)
                'Test data entered
                If tempLetterGuess = Nothing Then
                    endGame = True
                Else
                    letterGuess = tempLetterGuess
                End If
            End If
        Loop

        If wordGuessedSoFar = SECRET_WORD Then
            MessageBox.Show("You guessed it in " & numGuesses & " guesses!")
        ElseIf letterGuess = FLAG Then
            wordGuess = InputBox("Enter a word: ", Me.Text)
            If wordGuess.ToUpper = SECRET_WORD Then
                MessageBox.Show("You guessed it in " & numGuesses & " guesses!")
                Me.lblSecretWord.Text = SECRET_WORD
            Else
                MessageBox.Show("Sorry you lose.")
            End If
        Else
            MessageBox.Show("Game over.")
        End If
    End Sub
End Class
