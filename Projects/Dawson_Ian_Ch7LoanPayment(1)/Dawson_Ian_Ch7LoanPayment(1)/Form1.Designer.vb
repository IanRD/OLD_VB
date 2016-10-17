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
        Me.lblRatePrompt = New System.Windows.Forms.Label()
        Me.lblTermPrompt = New System.Windows.Forms.Label()
        Me.lblPrincipalPrompt = New System.Windows.Forms.Label()
        Me.btnPayment = New System.Windows.Forms.Button()
        Me.txtRate = New System.Windows.Forms.TextBox()
        Me.txtTerm = New System.Windows.Forms.TextBox()
        Me.txtPrincipal = New System.Windows.Forms.TextBox()
        Me.lblMonthlyPayment = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'lblRatePrompt
        '
        Me.lblRatePrompt.AutoSize = True
        Me.lblRatePrompt.Location = New System.Drawing.Point(25, 31)
        Me.lblRatePrompt.Name = "lblRatePrompt"
        Me.lblRatePrompt.Size = New System.Drawing.Size(88, 13)
        Me.lblRatePrompt.TabIndex = 0
        Me.lblRatePrompt.Text = "Interest Rate: [%]"
        '
        'lblTermPrompt
        '
        Me.lblTermPrompt.AutoSize = True
        Me.lblTermPrompt.Location = New System.Drawing.Point(25, 74)
        Me.lblTermPrompt.Name = "lblTermPrompt"
        Me.lblTermPrompt.Size = New System.Drawing.Size(105, 13)
        Me.lblTermPrompt.TabIndex = 1
        Me.lblTermPrompt.Text = "Term of loan [Years]:"
        '
        'lblPrincipalPrompt
        '
        Me.lblPrincipalPrompt.AutoSize = True
        Me.lblPrincipalPrompt.Location = New System.Drawing.Point(25, 116)
        Me.lblPrincipalPrompt.Name = "lblPrincipalPrompt"
        Me.lblPrincipalPrompt.Size = New System.Drawing.Size(65, 13)
        Me.lblPrincipalPrompt.TabIndex = 2
        Me.lblPrincipalPrompt.Text = "Principal [$]:"
        '
        'btnPayment
        '
        Me.btnPayment.Location = New System.Drawing.Point(281, 111)
        Me.btnPayment.Name = "btnPayment"
        Me.btnPayment.Size = New System.Drawing.Size(75, 23)
        Me.btnPayment.TabIndex = 3
        Me.btnPayment.Text = "Payment"
        Me.btnPayment.UseVisualStyleBackColor = True
        '
        'txtRate
        '
        Me.txtRate.Location = New System.Drawing.Point(136, 24)
        Me.txtRate.Name = "txtRate"
        Me.txtRate.Size = New System.Drawing.Size(45, 20)
        Me.txtRate.TabIndex = 4
        '
        'txtTerm
        '
        Me.txtTerm.Location = New System.Drawing.Point(136, 71)
        Me.txtTerm.Name = "txtTerm"
        Me.txtTerm.Size = New System.Drawing.Size(45, 20)
        Me.txtTerm.TabIndex = 5
        '
        'txtPrincipal
        '
        Me.txtPrincipal.Location = New System.Drawing.Point(136, 113)
        Me.txtPrincipal.Name = "txtPrincipal"
        Me.txtPrincipal.Size = New System.Drawing.Size(45, 20)
        Me.txtPrincipal.TabIndex = 6
        '
        'lblMonthlyPayment
        '
        Me.lblMonthlyPayment.Location = New System.Drawing.Point(28, 143)
        Me.lblMonthlyPayment.Name = "lblMonthlyPayment"
        Me.lblMonthlyPayment.Size = New System.Drawing.Size(328, 39)
        Me.lblMonthlyPayment.TabIndex = 7
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(380, 191)
        Me.Controls.Add(Me.lblMonthlyPayment)
        Me.Controls.Add(Me.txtPrincipal)
        Me.Controls.Add(Me.txtTerm)
        Me.Controls.Add(Me.txtRate)
        Me.Controls.Add(Me.btnPayment)
        Me.Controls.Add(Me.lblPrincipalPrompt)
        Me.Controls.Add(Me.lblTermPrompt)
        Me.Controls.Add(Me.lblRatePrompt)
        Me.Name = "Form1"
        Me.Text = "Loan Payment"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblRatePrompt As System.Windows.Forms.Label
    Friend WithEvents lblTermPrompt As System.Windows.Forms.Label
    Friend WithEvents lblPrincipalPrompt As System.Windows.Forms.Label
    Friend WithEvents btnPayment As System.Windows.Forms.Button
    Friend WithEvents txtRate As System.Windows.Forms.TextBox
    Friend WithEvents txtTerm As System.Windows.Forms.TextBox
    Friend WithEvents txtPrincipal As System.Windows.Forms.TextBox
    Friend WithEvents lblMonthlyPayment As System.Windows.Forms.Label

End Class
