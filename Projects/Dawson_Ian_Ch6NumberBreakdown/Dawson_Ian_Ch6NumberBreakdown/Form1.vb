Public Class Form1

    Private Sub Label1_Click(sender As System.Object, e As System.EventArgs) Handles lblPrompt.Click

    End Sub

    Private Sub Form1_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btnBreakdown_Click(sender As Object, e As System.EventArgs) Handles btnBreakdown.Click
        Dim numberEntered As Integer
        Dim onesDigit As Integer
        Dim tensDigit As Integer
        Dim hundredsDigit As Integer

        numberEntered = Val(Me.txtNumber.Text)
        If numberEntered < 10 Then
            Me.lblDigits.Text = "The first digit is: " & numberEntered
        ElseIf numberEntered < 100 Then
            Call TwoDigits(numberEntered, tensDigit, onesDigit)
            Me.lblDigits.Text = "The first digit is: " & tensDigit & _
                vbCrLf & "The second digit is: " & onesDigit

        ElseIf numberEntered < 1000 Then
            Call ThreeDigits(numberEntered, hundredsDigit, tensDigit, onesDigit)
            Me.lblDigits.Text = "The first digit is: " & hundredsDigit & _
                vbCrLf & "The second digit is: " & tensDigit & _
                vbCrLf & "The third digit is: " & onesDigit
        Else
            Me.lblDigits.Text = "Invalid Entry"


        End If

    End Sub
    Sub TwoDigits(ByVal num As Integer, ByRef firstDigit As Integer, _
    ByRef secondDigit As Integer)
        firstDigit = num \ 10
        secondDigit = num Mod 10
    End Sub

    Sub ThreeDigits(ByVal num As Integer, ByRef firstDigit As Integer, _
    ByRef SecondDigit As Integer, ByRef thirdDigit As Integer)
        firstDigit = num \ 100
        num = num Mod 100
        Call TwoDigits(num, SecondDigit, thirdDigit)
    End Sub

    Private Sub txtNumber_TextChanged(sender As Object, e As System.EventArgs) Handles txtNumber.TextChanged

    End Sub
End Class
