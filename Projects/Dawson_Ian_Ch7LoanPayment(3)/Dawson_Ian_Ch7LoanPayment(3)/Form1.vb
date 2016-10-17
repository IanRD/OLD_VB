Public Class Form1


    Private Sub Form1_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btnPayment_Click(sender As Object, e As System.EventArgs) Handles btnPayment.Click
        Dim rate As Double
        Dim principal As Decimal
        Dim term As Integer
        Dim payment As Decimal
        Dim validData As Boolean

        GetPercentAmount(Me.cboRate, rate, validData)
        If validData Then
            term = Val(Me.cboTerm.Text)
            If term <= 0 Then
                validData = False

            End If
        End If
        If validData Then
            GetDollarAmount(Me.txtPrincipal, principal, validData)

        End If
        If validData Then
            payment = Pmt(rate / 12, term * 12, -principal)
            Me.lblMonthlyPayment.Text = "The monthly payment for a loan of " & _
                Format(principal, "Currency") & " at " & Format(rate, "Percent") & _
                " for " & term & " years is " & Format(payment, "Currency")
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
    Sub GetPercentAmount(ByVal cboRate As ComboBox, _
                         ByRef percent As Double, ByRef isValid As Boolean)
        Dim testAmount As String
        isValid = False
        If cboRate.Text <> Nothing Then
            testAmount = cboRate.Text
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
    Private Sub NewDataEntered(ByVal sender As System.Object, _
ByVal e As System.EventArgs) Handles txtPrincipal.TextChanged, _
cboRate.SelectedIndexChanged, cboTerm.SelectedIndexChanged, _
cboRate.TextChanged, cboTerm.TextChanged
        Me.lblMonthlyPayment.Text = Nothing
        Me.btnPayment.Enabled = False
        If Me.cboRate.Text <> Nothing And Me.cboTerm.Text <> Nothing And _
        Me.txtPrincipal.Text <> Nothing Then
            Me.btnPayment.Enabled = True
        End If
    End Sub

End Class
