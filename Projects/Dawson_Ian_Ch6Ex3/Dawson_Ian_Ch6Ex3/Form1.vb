Public Class Form1

    Private Sub btnReduce_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnReduce.Click
        Dim num, denom, common As Integer
        Dim answer As String

        num = ReduceNum(num, denom, common)
        denom = ReduceDenom(num, denom, common)
        answer = (Val(Me.txtNumerator.Text) & "/" & Val(Me.txtDenominator.Text) & " is reduced to " & num & "/" & denom)
        If Val(Me.txtnumerator.Text) = num And Val(Me.txtdenominator.Text) = denom Then
            answer = "Reduced already"
        End If
        Me.lblReduced.Text = answer

    End Sub

    Function ReduceNum(ByVal num As Integer, ByVal denom As Integer, ByVal common As Integer) As Integer
        num = Val(Me.txtnumerator.Text)
        denom = Val(Me.txtdenominator.Text)
        common = Reduce(num, denom, common)
        num = num / common
        denom = denom / common
        Return num

    End Function

    Function ReduceDenom(ByVal num As Integer, ByVal denom As Integer, ByVal common As Integer) As Integer

        common = Reduce(num, denom, common)
        num = Val(Me.txtnumerator.Text)
        denom = Val(Me.txtdenominator.Text)

        num = num / common
        denom = denom / common
        Return denom
    End Function

    Function Reduce(ByVal num As Integer, ByVal denom As Integer, ByVal common As Integer) As Integer
        Dim MaxNum As Integer
        If num > denom Then
            MaxNum = denom
        Else
            MaxNum = num
        End If

        num = Val(Me.txtNumerator.Text)
        denom = Val(Me.txtDenominator.Text)
        If num Mod denom = 0 Then
            common = denom
        ElseIf denom Mod num = 0 Then
            common = num
        Else
            Do While common Mod num <> 0 And common Mod denom <> 0
                common = MaxNum - 1
            Loop
        End If
        Return common
    End Function



End Class

