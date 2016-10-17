<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.lblInfo = New System.Windows.Forms.Label()
        Me.lblAmount = New System.Windows.Forms.Label()
        Me.lblRate = New System.Windows.Forms.Label()
        Me.lblLength = New System.Windows.Forms.Label()
        Me.lblMade = New System.Windows.Forms.Label()
        Me.txtLoan = New System.Windows.Forms.TextBox()
        Me.txtRate = New System.Windows.Forms.TextBox()
        Me.txtLength = New System.Windows.Forms.TextBox()
        Me.lstPayments = New System.Windows.Forms.ListBox()
        Me.btnPayment = New System.Windows.Forms.Button()
        Me.lblAnswer = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'lblInfo
        '
        Me.lblInfo.AutoSize = True
        Me.lblInfo.Location = New System.Drawing.Point(12, 28)
        Me.lblInfo.Name = "lblInfo"
        Me.lblInfo.Size = New System.Drawing.Size(117, 13)
        Me.lblInfo.TabIndex = 0
        Me.lblInfo.Text = "Enter Loan Information:"
        '
        'lblAmount
        '
        Me.lblAmount.AutoSize = True
        Me.lblAmount.Location = New System.Drawing.Point(43, 72)
        Me.lblAmount.Name = "lblAmount"
        Me.lblAmount.Size = New System.Drawing.Size(100, 13)
        Me.lblAmount.TabIndex = 1
        Me.lblAmount.Text = "Amount of Loan [$]:"
        '
        'lblRate
        '
        Me.lblRate.AutoSize = True
        Me.lblRate.Location = New System.Drawing.Point(43, 111)
        Me.lblRate.Name = "lblRate"
        Me.lblRate.Size = New System.Drawing.Size(124, 13)
        Me.lblRate.TabIndex = 2
        Me.lblRate.Text = "Annual Interest Rate [%]:"
        '
        'lblLength
        '
        Me.lblLength.AutoSize = True
        Me.lblLength.Location = New System.Drawing.Point(43, 148)
        Me.lblLength.Name = "lblLength"
        Me.lblLength.Size = New System.Drawing.Size(118, 13)
        Me.lblLength.TabIndex = 3
        Me.lblLength.Text = "Length of Loan [Years]:"
        '
        'lblMade
        '
        Me.lblMade.AutoSize = True
        Me.lblMade.Location = New System.Drawing.Point(43, 184)
        Me.lblMade.Name = "lblMade"
        Me.lblMade.Size = New System.Drawing.Size(104, 13)
        Me.lblMade.TabIndex = 4
        Me.lblMade.Text = "Payments are Made:"
        '
        'txtLoan
        '
        Me.txtLoan.Location = New System.Drawing.Point(184, 69)
        Me.txtLoan.Name = "txtLoan"
        Me.txtLoan.Size = New System.Drawing.Size(76, 20)
        Me.txtLoan.TabIndex = 5
        '
        'txtRate
        '
        Me.txtRate.Location = New System.Drawing.Point(184, 108)
        Me.txtRate.Name = "txtRate"
        Me.txtRate.Size = New System.Drawing.Size(76, 20)
        Me.txtRate.TabIndex = 6
        '
        'txtLength
        '
        Me.txtLength.Location = New System.Drawing.Point(184, 145)
        Me.txtLength.Name = "txtLength"
        Me.txtLength.Size = New System.Drawing.Size(76, 20)
        Me.txtLength.TabIndex = 7
        '
        'lstPayments
        '
        Me.lstPayments.FormattingEnabled = True
        Me.lstPayments.Items.AddRange(New Object() {"Daily", "Monthly", "Yearly"})
        Me.lstPayments.Location = New System.Drawing.Point(184, 184)
        Me.lstPayments.Name = "lstPayments"
        Me.lstPayments.Size = New System.Drawing.Size(76, 43)
        Me.lstPayments.TabIndex = 8
        '
        'btnPayment
        '
        Me.btnPayment.Location = New System.Drawing.Point(15, 232)
        Me.btnPayment.Name = "btnPayment"
        Me.btnPayment.Size = New System.Drawing.Size(75, 23)
        Me.btnPayment.TabIndex = 9
        Me.btnPayment.Text = "Payment"
        Me.btnPayment.UseVisualStyleBackColor = True
        '
        'lblAnswer
        '
        Me.lblAnswer.Location = New System.Drawing.Point(104, 232)
        Me.lblAnswer.Name = "lblAnswer"
        Me.lblAnswer.Size = New System.Drawing.Size(223, 49)
        Me.lblAnswer.TabIndex = 10
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(339, 308)
        Me.Controls.Add(Me.lblAnswer)
        Me.Controls.Add(Me.btnPayment)
        Me.Controls.Add(Me.lstPayments)
        Me.Controls.Add(Me.txtLength)
        Me.Controls.Add(Me.txtRate)
        Me.Controls.Add(Me.txtLoan)
        Me.Controls.Add(Me.lblMade)
        Me.Controls.Add(Me.lblLength)
        Me.Controls.Add(Me.lblRate)
        Me.Controls.Add(Me.lblAmount)
        Me.Controls.Add(Me.lblInfo)
        Me.Name = "Form1"
        Me.Text = "Payment Calculator"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblInfo As System.Windows.Forms.Label
    Friend WithEvents lblAmount As System.Windows.Forms.Label
    Friend WithEvents lblRate As System.Windows.Forms.Label
    Friend WithEvents lblLength As System.Windows.Forms.Label
    Friend WithEvents lblMade As System.Windows.Forms.Label
    Friend WithEvents txtLoan As System.Windows.Forms.TextBox
    Friend WithEvents txtRate As System.Windows.Forms.TextBox
    Friend WithEvents txtLength As System.Windows.Forms.TextBox
    Friend WithEvents lstPayments As System.Windows.Forms.ListBox
    Friend WithEvents btnPayment As System.Windows.Forms.Button
    Friend WithEvents lblAnswer As System.Windows.Forms.Label

End Class
