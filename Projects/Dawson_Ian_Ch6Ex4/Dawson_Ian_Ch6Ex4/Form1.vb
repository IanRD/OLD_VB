Public Class Form1

    Private Sub Form1_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
    End Sub

    Private Sub btnBreakUp_Click(sender As Object, e As System.EventArgs) Handles btnBreakUp.Click
        Dim onesDigit, hundredsDigit, tensDigit, num As Integer
        Dim build, rebuild As String

        num = 100
        build = ""

        Do Until num > 125
            Call TwoDigits(num, onesDigit, tensDigit)
            Call ThreeDigits(num, onesDigit, tensDigit, hundredsDigit)
            rebuild = onesDigit & tensDigit & hundredsDigit
            build &= num & Space(25) & onesDigit & "   " & tensDigit & "   " & hundredsDigit & Space(25) & num & vbCrLf
            num += 1

        Loop
        Me.lbl100.Text = build

    End Sub

    Sub TwoDigits(ByVal num As Integer, ByRef firstdigit As Integer, ByRef secondDigit As Integer)
        firstdigit = num \ 10
        secondDigit = num Mod 10
    End Sub

    Sub ThreeDigits(ByVal num As Integer, ByRef firstdigit As Integer, _
    ByRef SecondDigit As Integer, ByRef thirdDigit As Integer)
        firstdigit = num \ 100
        num = num Mod 100
        Call TwoDigits(num, SecondDigit, thirdDigit)
    End Sub
End Class