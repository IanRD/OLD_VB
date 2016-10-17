Public Class Form1


    Private Sub Form1_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btnPayment_Click(sender As Object, e As System.EventArgs) Handles btnFutureValue.Click
        Dim rate As Double
        Dim principal As Decimal
        Dim term As Integer
        Dim payment As Decimal
        Dim validData As Boolean
        Dim totalpaid As Decimal

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
        Do
            totalpaid = PV(rate / 12, term, -principal)
        Loop While totalpaid < payment

        If validData Then
            payment = principal * (term * 12) + (totalpaid * 3.429465)
            Me.lblMonthlyPayment.Text = "Your investment will be worth " & _
                Format(payment, "Currency") & " if you plan on making monthly investments of " & _
             Format(principal, "Currency") & _
                " at " & Format(rate, "Percent") & " for " & term & " years."
        Else
            Me.lblMonthlyPayment.Text = "Enter valid data."
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
        Me.lblMonthlyPayment.Text = Nothing

    End Sub

End Class
