Public Class Form1
    Dim operand1 As Double = 0
    Dim operand2 As Double = 0
    Dim op As String = Nothing
    Dim newOperand As Boolean = True


    Private Sub Number_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles _
    btnDot.Click, btn0.Click, btn1.Click, btn2.Click, btn3.Click, btn4.Click, btn5.Click, _
    btn6.Click, btn7.Click, btn8.Click, btn9.Click
        Dim btnNumberClicked As Button = sender
        If newOperand Then
            Me.txtDisplay.Text = btnNumberClicked.Tag
            newOperand = False
        Else
            Me.txtDisplay.Text &= btnNumberClicked.Tag
        End If
    End Sub

    Private Sub btnClear_click(ByVal sender As Object, ByVal e As System.EventArgs) _
    Handles btnClear.Click
        Me.txtDisplay.Text = "0"
        operand1 = 0
        operand2 = 0
        newOperand = True
        op = Nothing
    End Sub

    Private Sub btnoff_click(ByVal sender As Object, ByVal e As System.EventArgs) _
    Handles btnOff.Click
        Application.Exit()
    End Sub

    Private Sub btnOperator_Click(ByVal sender As Object, ByVal e As System.EventArgs) _
    Handles btnPlus.Click, btnMinus.Click, btnTimes.Click, btnDivide.Click, btnEqual.Click, btnIntDivide.Click
        Dim operatorSelected As Button = sender
        If (operand1 = 0 And op = Nothing) Or op = "=" Then
            operand1 = Val(Me.txtDisplay.Text)
        Else
            operand2 = Val(Me.txtDisplay.Text)
            operand1 = Calculate(operand1, operand2, op)
            Me.txtDisplay.Text = operand1
        End If
        op = operatorSelected.Tag
        newOperand = True
    End Sub

    Function Calculate(ByVal firstOperand As Double, ByVal secondOperand As Double, _
    ByVal op As String) As Double
        Select Case op
            Case "+"
                Return (firstOperand + secondOperand)
            Case "-"
                Return (firstOperand - secondOperand)
            Case "X"
                Return (firstOperand * secondOperand)
            Case "/"
                Return (firstOperand / secondOperand)
            Case "\"
                Return (firstOperand \ secondOperand)
        End Select
    End Function

    Private Sub Form1_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load

    End Sub
End Class
