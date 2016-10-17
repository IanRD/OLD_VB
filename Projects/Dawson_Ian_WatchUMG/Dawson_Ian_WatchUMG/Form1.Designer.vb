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
        Me.lblMonthlyPayment = New System.Windows.Forms.Label()
        Me.txtPrincipal = New System.Windows.Forms.TextBox()
        Me.txtTerm = New System.Windows.Forms.TextBox()
        Me.txtRate = New System.Windows.Forms.TextBox()
        Me.btnFutureValue = New System.Windows.Forms.Button()
        Me.lblInvestmentPrompt = New System.Windows.Forms.Label()
        Me.lblTermPrompt = New System.Windows.Forms.Label()
        Me.lblRatePrompt = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'lblMonthlyPayment
        '
        Me.lblMonthlyPayment.Location = New System.Drawing.Point(12, 160)
        Me.lblMonthlyPayment.Name = "lblMonthlyPayment"
        Me.lblMonthlyPayment.Size = New System.Drawing.Size(419, 72)
        Me.lblMonthlyPayment.TabIndex = 15
        '
        'txtPrincipal
        '
        Me.txtPrincipal.Location = New System.Drawing.Point(146, 121)
        Me.txtPrincipal.Name = "txtPrincipal"
        Me.txtPrincipal.Size = New System.Drawing.Size(78, 20)
        Me.txtPrincipal.TabIndex = 14
        '
        'txtTerm
        '
        Me.txtTerm.Location = New System.Drawing.Point(146, 79)
        Me.txtTerm.Name = "txtTerm"
        Me.txtTerm.Size = New System.Drawing.Size(78, 20)
        Me.txtTerm.TabIndex = 13
        '
        'txtRate
        '
        Me.txtRate.Location = New System.Drawing.Point(146, 32)
        Me.txtRate.Name = "txtRate"
        Me.txtRate.Size = New System.Drawing.Size(78, 20)
        Me.txtRate.TabIndex = 12
        '
        'btnFutureValue
        '
        Me.btnFutureValue.Location = New System.Drawing.Point(315, 111)
        Me.btnFutureValue.Name = "btnFutureValue"
        Me.btnFutureValue.Size = New System.Drawing.Size(108, 30)
        Me.btnFutureValue.TabIndex = 11
        Me.btnFutureValue.Text = "Future Value"
        Me.btnFutureValue.UseVisualStyleBackColor = True
        '
        'lblInvestmentPrompt
        '
        Me.lblInvestmentPrompt.AutoSize = True
        Me.lblInvestmentPrompt.Location = New System.Drawing.Point(23, 124)
        Me.lblInvestmentPrompt.Name = "lblInvestmentPrompt"
        Me.lblInvestmentPrompt.Size = New System.Drawing.Size(117, 13)
        Me.lblInvestmentPrompt.TabIndex = 10
        Me.lblInvestmentPrompt.Text = "Monthly Investment [$]:"
        '
        'lblTermPrompt
        '
        Me.lblTermPrompt.AutoSize = True
        Me.lblTermPrompt.Location = New System.Drawing.Point(23, 82)
        Me.lblTermPrompt.Name = "lblTermPrompt"
        Me.lblTermPrompt.Size = New System.Drawing.Size(70, 13)
        Me.lblTermPrompt.TabIndex = 9
        Me.lblTermPrompt.Text = "Term [Years]:"
        '
        'lblRatePrompt
        '
        Me.lblRatePrompt.AutoSize = True
        Me.lblRatePrompt.Location = New System.Drawing.Point(23, 39)
        Me.lblRatePrompt.Name = "lblRatePrompt"
        Me.lblRatePrompt.Size = New System.Drawing.Size(88, 13)
        Me.lblRatePrompt.TabIndex = 8
        Me.lblRatePrompt.Text = "Interest Rate: [%]"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(443, 241)
        Me.Controls.Add(Me.lblMonthlyPayment)
        Me.Controls.Add(Me.txtPrincipal)
        Me.Controls.Add(Me.txtTerm)
        Me.Controls.Add(Me.txtRate)
        Me.Controls.Add(Me.btnFutureValue)
        Me.Controls.Add(Me.lblInvestmentPrompt)
        Me.Controls.Add(Me.lblTermPrompt)
        Me.Controls.Add(Me.lblRatePrompt)
        Me.Name = "Form1"
        Me.Text = "Watch Your Money Grow"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblMonthlyPayment As System.Windows.Forms.Label
    Friend WithEvents txtPrincipal As System.Windows.Forms.TextBox
    Friend WithEvents txtTerm As System.Windows.Forms.TextBox
    Friend WithEvents txtRate As System.Windows.Forms.TextBox
    Friend WithEvents btnFutureValue As System.Windows.Forms.Button
    Friend WithEvents lblInvestmentPrompt As System.Windows.Forms.Label
    Friend WithEvents lblTermPrompt As System.Windows.Forms.Label
    Friend WithEvents lblRatePrompt As System.Windows.Forms.Label

End Class
