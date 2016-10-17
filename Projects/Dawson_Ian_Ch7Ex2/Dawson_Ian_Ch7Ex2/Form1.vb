Public Class Form1

    Private Sub Form1_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btnPayment_Click(sender As Object, e As System.EventArgs) Handles btnPayment.Click
        Dim rate As Double
        Dim loan As Decimal
        Dim term As Decimal
        Dim payment As Decimal
        Dim validData As Boolean

        GetPercentAmount(Me.txtRate, rate, validData)
        If validData Then
            term = Val(Me.txtLength.Text)
            If term <= 0 Then
                validData = False

            End If
        End If
        If validData Then
            GetDollarAmount(Me.txtLoan, loan, validData)

        End If
        Dim totalAmount As Decimal = Format((loan * rate) * 30)
        Dim totalInterest As Decimal = Format(((loan * rate) * 30) - loan)

        If Me.lstPayments.SelectedItem = "Daily" Then
            payment = ((loan * rate) * term) / (360 * term) & _
            totalAmount = (((loan * rate) * 30) / 360)
            totalInterest = ((((loan * rate) * 30) / 360) - loan)
        End If

        If Me.lstPayments.SelectedItem = "Monthly" Then
            payment = ((loan * rate) * term) / (30 * term) & _
            totalAmount = (((loan * rate) * 30) / 30) & _
            totalInterest = ((((loan * rate) * 30) / 30) - loan)
        End If

        If Me.lstPayments.SelectedItem = "Yearly" Then
            payment = ((loan * rate) * term) / term
        End If

        

        If validData Then
            Me.lblAnswer.Text = "The " & Me.lstPayments.SelectedItem & " payment is " & Format(payment, "Currency") & _
                vbCrLf & "The total amount paid is " & Format(totalAmount, "Currency") & vbCrLf _
                & Format(totalInterest, "Currency")
        Else
            Me.lblAnswer.Text = "Enter valid data."
        End If
    End Sub
    Sub GetDollarAmount(ByVal txtLoan As TextBox, _
                        ByRef dollars As Decimal, ByRef isValid As Boolean)
        Dim testAmount As String
        isValid = False
        If txtLoan.Text <> Nothing Then
            testAmount = Me.txtLoan.Text
            testAmount = testAmount.Replace("$", "")
            testAmount = testAmount.Replace(",", "")
            If IsNumeric(testAmount) Then
                dollars = Val(testAmount)
                isValid = True
            End If
        End If
    End Sub
    Sub GetPercentAmount(ByVal txtRate As TextBox, _
                         ByRef percent As Double, ByRef isValid As Boolean)
        Dim testAmount As String
        isValid = False
        If txtRate.Text <> Nothing Then
            testAmount = txtRate.Text
            testAmount = testAmount.TrimEnd("%")
            If IsNumeric(testAmount) Then
                If Val(testAmount) >= 1 Then
                    percent = Val(testAmount) / 100
                Else
                    percent = Val(testAmount)
                End If
                isValid = True
            End If

        End If
    End Sub

    Private Sub lblAnswer_Click(sender As System.Object, e As System.EventArgs) Handles lblAnswer.Click

    End Sub
End Class
