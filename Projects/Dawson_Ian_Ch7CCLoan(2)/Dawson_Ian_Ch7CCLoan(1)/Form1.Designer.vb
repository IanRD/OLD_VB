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
        Me.lblPayments = New System.Windows.Forms.Label()
        Me.txtPrincipal = New System.Windows.Forms.TextBox()
        Me.txtTerm = New System.Windows.Forms.TextBox()
        Me.txtRate = New System.Windows.Forms.TextBox()
        Me.btnPayments = New System.Windows.Forms.Button()
        Me.lblPaymentPrompt = New System.Windows.Forms.Label()
        Me.lblChargedPrompt = New System.Windows.Forms.Label()
        Me.lblRatePrompt = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'lblPayments
        '
        Me.lblPayments.Location = New System.Drawing.Point(12, 146)
        Me.lblPayments.Name = "lblPayments"
        Me.lblPayments.Size = New System.Drawing.Size(420, 94)
        Me.lblPayments.TabIndex = 6
        '
        'txtPrincipal
        '
        Me.txtPrincipal.Location = New System.Drawing.Point(148, 107)
        Me.txtPrincipal.Name = "txtPrincipal"
        Me.txtPrincipal.Size = New System.Drawing.Size(76, 20)
        Me.txtPrincipal.TabIndex = 5
        '
        'txtTerm
        '
        Me.txtTerm.Location = New System.Drawing.Point(148, 65)
        Me.txtTerm.Name = "txtTerm"
        Me.txtTerm.Size = New System.Drawing.Size(75, 20)
        Me.txtTerm.TabIndex = 3
        '
        'txtRate
        '
        Me.txtRate.Location = New System.Drawing.Point(148, 22)
        Me.txtRate.Name = "txtRate"
        Me.txtRate.Size = New System.Drawing.Size(76, 20)
        Me.txtRate.TabIndex = 1
        '
        'btnPayments
        '
        Me.btnPayments.Location = New System.Drawing.Point(295, 105)
        Me.btnPayments.Name = "btnPayments"
        Me.btnPayments.Size = New System.Drawing.Size(117, 23)
        Me.btnPayments.TabIndex = 7
        Me.btnPayments.Text = "&Number of Payments"
        Me.btnPayments.UseVisualStyleBackColor = True
        '
        'lblPaymentPrompt
        '
        Me.lblPaymentPrompt.AutoSize = True
        Me.lblPaymentPrompt.Location = New System.Drawing.Point(12, 110)
        Me.lblPaymentPrompt.Name = "lblPaymentPrompt"
        Me.lblPaymentPrompt.Size = New System.Drawing.Size(106, 13)
        Me.lblPaymentPrompt.TabIndex = 4
        Me.lblPaymentPrompt.Text = "&Monthly Payment [$]:"
        '
        'lblChargedPrompt
        '
        Me.lblChargedPrompt.AutoSize = True
        Me.lblChargedPrompt.Location = New System.Drawing.Point(12, 68)
        Me.lblChargedPrompt.Name = "lblChargedPrompt"
        Me.lblChargedPrompt.Size = New System.Drawing.Size(131, 13)
        Me.lblChargedPrompt.TabIndex = 2
        Me.lblChargedPrompt.Text = "&Total Amount Charged [$]:"
        '
        'lblRatePrompt
        '
        Me.lblRatePrompt.AutoSize = True
        Me.lblRatePrompt.Location = New System.Drawing.Point(12, 25)
        Me.lblRatePrompt.Name = "lblRatePrompt"
        Me.lblRatePrompt.Size = New System.Drawing.Size(88, 13)
        Me.lblRatePrompt.TabIndex = 0
        Me.lblRatePrompt.Text = "&Interest Rate: [%]"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(444, 249)
        Me.Controls.Add(Me.lblPayments)
        Me.Controls.Add(Me.txtPrincipal)
        Me.Controls.Add(Me.txtTerm)
        Me.Controls.Add(Me.txtRate)
        Me.Controls.Add(Me.btnPayments)
        Me.Controls.Add(Me.lblPaymentPrompt)
        Me.Controls.Add(Me.lblChargedPrompt)
        Me.Controls.Add(Me.lblRatePrompt)
        Me.Name = "Form1"
        Me.Text = "Credit Card Loan"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblPayments As System.Windows.Forms.Label
    Friend WithEvents txtPrincipal As System.Windows.Forms.TextBox
    Friend WithEvents txtTerm As System.Windows.Forms.TextBox
    Friend WithEvents txtRate As System.Windows.Forms.TextBox
    Friend WithEvents btnPayments As System.Windows.Forms.Button
    Friend WithEvents lblPaymentPrompt As System.Windows.Forms.Label
    Friend WithEvents lblChargedPrompt As System.Windows.Forms.Label
    Friend WithEvents lblRatePrompt As System.Windows.Forms.Label

End Class
