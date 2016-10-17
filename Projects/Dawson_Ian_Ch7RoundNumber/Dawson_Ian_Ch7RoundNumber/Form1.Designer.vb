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
        Me.lblNumber = New System.Windows.Forms.Label()
        Me.lblDecimals = New System.Windows.Forms.Label()
        Me.txtNumber = New System.Windows.Forms.TextBox()
        Me.txtDecimal = New System.Windows.Forms.TextBox()
        Me.btnRound = New System.Windows.Forms.Button()
        Me.lblRound = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'lblNumber
        '
        Me.lblNumber.AutoSize = True
        Me.lblNumber.Location = New System.Drawing.Point(24, 25)
        Me.lblNumber.Name = "lblNumber"
        Me.lblNumber.Size = New System.Drawing.Size(82, 13)
        Me.lblNumber.TabIndex = 0
        Me.lblNumber.Text = "Enter a number:"
        '
        'lblDecimals
        '
        Me.lblDecimals.AutoSize = True
        Me.lblDecimals.Location = New System.Drawing.Point(24, 87)
        Me.lblDecimals.Name = "lblDecimals"
        Me.lblDecimals.Size = New System.Drawing.Size(82, 13)
        Me.lblDecimals.TabIndex = 1
        Me.lblDecimals.Text = "Decimal places:"
        '
        'txtNumber
        '
        Me.txtNumber.Location = New System.Drawing.Point(126, 22)
        Me.txtNumber.Name = "txtNumber"
        Me.txtNumber.Size = New System.Drawing.Size(100, 20)
        Me.txtNumber.TabIndex = 2
        '
        'txtDecimal
        '
        Me.txtDecimal.Location = New System.Drawing.Point(126, 84)
        Me.txtDecimal.Name = "txtDecimal"
        Me.txtDecimal.Size = New System.Drawing.Size(100, 20)
        Me.txtDecimal.TabIndex = 3
        '
        'btnRound
        '
        Me.btnRound.Location = New System.Drawing.Point(288, 51)
        Me.btnRound.Name = "btnRound"
        Me.btnRound.Size = New System.Drawing.Size(75, 23)
        Me.btnRound.TabIndex = 4
        Me.btnRound.Text = "Round"
        Me.btnRound.UseVisualStyleBackColor = True
        '
        'lblRound
        '
        Me.lblRound.AutoSize = True
        Me.lblRound.Location = New System.Drawing.Point(288, 107)
        Me.lblRound.Name = "lblRound"
        Me.lblRound.Size = New System.Drawing.Size(0, 13)
        Me.lblRound.TabIndex = 5
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(397, 132)
        Me.Controls.Add(Me.lblRound)
        Me.Controls.Add(Me.btnRound)
        Me.Controls.Add(Me.txtDecimal)
        Me.Controls.Add(Me.txtNumber)
        Me.Controls.Add(Me.lblDecimals)
        Me.Controls.Add(Me.lblNumber)
        Me.Name = "Form1"
        Me.Text = "Round The Number"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblNumber As System.Windows.Forms.Label
    Friend WithEvents lblDecimals As System.Windows.Forms.Label
    Friend WithEvents txtNumber As System.Windows.Forms.TextBox
    Friend WithEvents txtDecimal As System.Windows.Forms.TextBox
    Friend WithEvents btnRound As System.Windows.Forms.Button
    Friend WithEvents lblRound As System.Windows.Forms.Label

End Class
