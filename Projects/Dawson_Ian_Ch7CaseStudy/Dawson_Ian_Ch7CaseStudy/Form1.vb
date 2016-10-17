Public Class Form1

    Private Sub Image_Click(ByVal sender As Object, ByVal e As System.EventArgs) _
    Handles picAuto.Click, picHome.Click

        Me.grpWhatToKnow.Visible = True
        Me.btnNewLoan.Visible = True
        Me.btnCalculate.Visible = True
        Me.btnCalculate.Enabled = False
        Me.lstTerm.Items.Clear()
        Dim picImageClicked As PictureBox = sender
        Select Case picImageClicked.Tag
            Case "auto"
                Me.lstTerm.Items.Add("2 years")
                Me.lstTerm.Items.Add("3 years")
                Me.lstTerm.Items.Add("5 years")
                Me.lstTerm.Items.Add("7 years")
            Case "home"
                Me.lstTerm.Items.Add("10 years")
                Me.lstTerm.Items.Add("15 years")
                Me.lstTerm.Items.Add("30 years")
        End Select
    End Sub
 
    Private Sub btnNewLoan_Click(ByVal sender As System.Object, _
    ByVal e As System.EventArgs) Handles btnNewLoan.Click
        Me.grpWhatToKnow.Visible = False
        Me.radHowMuch.Checked = False
        Me.radPaymentSize.Checked = False
        Me.lblTermPrompt.Visible = False
        Me.lstTerm.Visible = False
        Me.lblPrincipalOrPaymentPrompt.Visible = False
        Me.txtPrincipalOrPayment.Visible = False
        Me.lblRatePrompt.Visible = False
        Me.cboRate.Visible = False
        Me.btnNewLoan.Visible = False
        Me.btnCalculate.Visible = False
        Me.lblResult.Text = Nothing
    End Sub
    Private Sub WhatDoYouWantToKnow_Click(ByVal sender As Object, _
ByVal e As System.EventArgs) Handles radHowMuch.Click, radPaymentSize.Click


        Me.lblTermPrompt.Visible = True
        Me.lstTerm.Visible = True

        Dim radOptionClicked As RadioButton = sender
        Select Case radOptionClicked.Tag
            Case "how much"
                Me.lblPrincipalOrPaymentPrompt.Text = "Desired payment:"
            Case "payment size"
                Me.lblPrincipalOrPaymentPrompt.Text = "Loan Amount:"
        End Select
        Me.lblPrincipalOrPaymentPrompt.Visible = True
        Me.txtPrincipalOrPayment.Visible = True
        Me.txtPrincipalOrPayment.Text = Nothing
        Me.lblRatePrompt.Visible = True
        Me.cboRate.Visible = True
        Me.cboRate.Text = Nothing
    End Sub

    Private Sub InfoEntered(ByVal sender As Object, ByVal e As System.EventArgs) Handles cboRate.SelectedIndexChanged, cboRate.TextChanged
        Me.lblResult.Text = Nothing
        Me.btnCalculate.Enabled = False
        If Me.txtPrincipalOrPayment.Text <> Nothing And _
        Me.cboRate.Text <> Nothing Then
            Me.btnCalculate.Enabled = True
        End If
    End Sub
    Private Sub btnCalculate_Click(ByVal sender As Object, ByVal e As System.EventArgs) _
Handles btnCalculate.Click
        Dim intTerm As Integer
        Dim PrincipalOrPayment, Rate As Single
        Dim Result As Single
        Dim ValidData As Boolean

        intTerm = Val(Me.lstTerm.SelectedItem)

        GetDollarAmount(Me.txtPrincipalOrPayment, PrincipalOrPayment, ValidData)

        If ValidData Then
            GetPercentAmount(Me.cboRate, Rate, ValidData)
        End If

        If ValidData Then
            If Me.radHowMuch.Checked Then
                Result = PV(Rate / 12, intTerm * 12, -PrincipalOrPayment)
                Me.lblResult.Text = "Loan amount: " & Format(Result, "Currency")
            Else
                Result = Pmt(Rate / 12, intTerm * 12, -PrincipalOrPayment)
                Me.lblResult.Text = "Payment amount: " & Format(Result, "Currency")
            End If
        Else
            Me.lblResult.Text = "Data not valid."
        End If
    End Sub

    Sub GetDollarAmount(ByVal txtUserData As TextBox, ByRef decDollars As Decimal, _
    ByRef isValid As Boolean)
        Dim TestAmount As String
        isValid = False
        If txtUserData.Text <> Nothing Then
            TestAmount = txtUserData.Text
            TestAmount = TestAmount.Replace("$", "")
            TestAmount = TestAmount.Replace(",", "")
            If IsNumeric(TestAmount) Then
                decDollars = Val(TestAmount)
                isValid = True
            End If
        End If
    End Sub

    Sub GetPercentAmount(ByVal cboUserData As ComboBox, ByRef sngPercent As Single, _
    ByRef isValid As Boolean)
        Dim TestAmount As String
        isValid = False
        If cboUserData.Text <> Nothing Then
            TestAmount = cboUserData.Text
            TestAmount = TestAmount.TrimEnd("%")
        End If
        If IsNumeric(TestAmount) Then
            If Val(TestAmount) > 1 Then
                sngPercent = Val(TestAmount) / 100
            Else
                sngPercent = Val(TestAmount)
            End If
            isValid = True
        End If
    End Sub
End Class
