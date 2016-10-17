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
        Me.lblworked = New System.Windows.Forms.Label()
        Me.lblrate = New System.Windows.Forms.Label()
        Me.txtworked = New System.Windows.Forms.TextBox()
        Me.txtrate = New System.Windows.Forms.TextBox()
        Me.lblgross = New System.Windows.Forms.Label()
        Me.lblwages = New System.Windows.Forms.Label()
        Me.btnpay = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lblworked
        '
        Me.lblworked.AutoSize = True
        Me.lblworked.Location = New System.Drawing.Point(12, 26)
        Me.lblworked.Name = "lblworked"
        Me.lblworked.Size = New System.Drawing.Size(102, 13)
        Me.lblworked.TabIndex = 0
        Me.lblworked.Text = "Enter hours worked:"
        '
        'lblrate
        '
        Me.lblrate.AutoSize = True
        Me.lblrate.Location = New System.Drawing.Point(12, 70)
        Me.lblrate.Name = "lblrate"
        Me.lblrate.Size = New System.Drawing.Size(87, 13)
        Me.lblrate.TabIndex = 1
        Me.lblrate.Text = "Enter hourly rate:"
        '
        'txtworked
        '
        Me.txtworked.Location = New System.Drawing.Point(120, 23)
        Me.txtworked.Name = "txtworked"
        Me.txtworked.Size = New System.Drawing.Size(69, 20)
        Me.txtworked.TabIndex = 2
        '
        'txtrate
        '
        Me.txtrate.Location = New System.Drawing.Point(120, 67)
        Me.txtrate.Name = "txtrate"
        Me.txtrate.Size = New System.Drawing.Size(69, 20)
        Me.txtrate.TabIndex = 3
        '
        'lblgross
        '
        Me.lblgross.AutoSize = True
        Me.lblgross.Location = New System.Drawing.Point(16, 140)
        Me.lblgross.Name = "lblgross"
        Me.lblgross.Size = New System.Drawing.Size(86, 13)
        Me.lblgross.TabIndex = 4
        Me.lblgross.Text = "Gross wages = $"
        '
        'lblwages
        '
        Me.lblwages.AutoSize = True
        Me.lblwages.Location = New System.Drawing.Point(108, 140)
        Me.lblwages.Name = "lblwages"
        Me.lblwages.Size = New System.Drawing.Size(0, 13)
        Me.lblwages.TabIndex = 5
        '
        'btnpay
        '
        Me.btnpay.Location = New System.Drawing.Point(193, 146)
        Me.btnpay.Name = "btnpay"
        Me.btnpay.Size = New System.Drawing.Size(75, 23)
        Me.btnpay.TabIndex = 6
        Me.btnpay.Text = "Pay"
        Me.btnpay.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(293, 172)
        Me.Controls.Add(Me.btnpay)
        Me.Controls.Add(Me.lblwages)
        Me.Controls.Add(Me.lblgross)
        Me.Controls.Add(Me.txtrate)
        Me.Controls.Add(Me.txtworked)
        Me.Controls.Add(Me.lblrate)
        Me.Controls.Add(Me.lblworked)
        Me.Name = "Form1"
        Me.Text = "Payroll"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblworked As System.Windows.Forms.Label
    Friend WithEvents lblrate As System.Windows.Forms.Label
    Friend WithEvents txtworked As System.Windows.Forms.TextBox
    Friend WithEvents txtrate As System.Windows.Forms.TextBox
    Friend WithEvents lblgross As System.Windows.Forms.Label
    Friend WithEvents lblwages As System.Windows.Forms.Label
    Friend WithEvents btnpay As System.Windows.Forms.Button

End Class
