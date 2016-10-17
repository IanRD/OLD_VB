Public Class Form1


    Private Sub Form1_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btnPayments_Click(sender As Object, e As System.EventArgs) Handles btnPayments.Click
        Dim rate As Double
        Dim principal As Decimal
        Dim term As Integer = 0
        Dim payment As Decimal
        Dim validData As Boolean
        Dim totalpaid As Decimal
        Dim totalAmount As Decimal

        GetPercentAmount(Me.txtRate, rate, validData)
        If validData Then
            term = Val(Me.txtTerm.Text)
            If term <= 0 Then
                validData = False

            End If
        End If
        If validData Then
            GetDollarAmount(Me.txtPrincipal, principal, validData)

        End If
        If validData Then
            Do
                term = term + 1
                totalpaid = PV(rate / 12, term, payment)

            Loop While totalpaid < totalAmount
            Dim numPayments As Integer = term
            totalpaid = numPayments
            Dim amtPaidInterest As Decimal
        End If

        If validData Then
            payment = principal * (term * 12) + (totalpaid)
            Me.lblPayments.Text = "The number of payments required to pay off the credit loan of " & _
            Format(totalAmount, "Currency") & " at " & Format(rate, "Percent") & " when " & _
                Format(payment, "Currency") & " is paid monthly is " & Format(term, "Integer") & " The total amount that will be paid is" & _
                Format(totalAmount, "Currency") & " The amount paid to interest is " & term * rate
        Else
            Me.lblPayments.Text = "Enter valid data."
        End If
    End Sub
    Sub GetDollarAmount(ByVal txtPrincipal As TextBox, _
                        ByRef dollars As Decimal, ByRef isValid As Boolean)
        Dim testAmount As String
        isValid = False
        If txtPrincipal.Text <> Nothing Then
            testAmount = Me.txtPrincipal.Text
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
    Sub NewDataEntered(sender As Object, e As System.EventArgs) Handles txtPrincipal.TextChanged, txtRate.TextChanged, txtTerm.TextChanged
        Me.lblPayments.Text = Nothing
        Me.btnPayments.Enabled = False

        If Me.txtRate.Text <> Nothing And Me.txtPrincipal.Text <> Nothing And _
            Me.txtTerm.Text <> Nothing Then
            Me.btnPayments.Enabled = True

        End If

    End Sub

End Class
