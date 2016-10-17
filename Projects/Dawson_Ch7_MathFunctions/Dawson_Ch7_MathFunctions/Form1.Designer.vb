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
        Me.lblSTUFF = New System.Windows.Forms.Label()
        Me.btnAbsoluteValue = New System.Windows.Forms.Button()
        Me.btnSquareRoot = New System.Windows.Forms.Button()
        Me.btnSign = New System.Windows.Forms.Button()
        Me.txtNumber = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'lblNumber
        '
        Me.lblNumber.AutoSize = True
        Me.lblNumber.Location = New System.Drawing.Point(37, 26)
        Me.lblNumber.Name = "lblNumber"
        Me.lblNumber.Size = New System.Drawing.Size(82, 13)
        Me.lblNumber.TabIndex = 0
        Me.lblNumber.Text = "Enter a number:"
        '
        'lblSTUFF
        '
        Me.lblSTUFF.AutoSize = True
        Me.lblSTUFF.Location = New System.Drawing.Point(37, 79)
        Me.lblSTUFF.Name = "lblSTUFF"
        Me.lblSTUFF.Size = New System.Drawing.Size(0, 13)
        Me.lblSTUFF.TabIndex = 1
        '
        'btnAbsoluteValue
        '
        Me.btnAbsoluteValue.Location = New System.Drawing.Point(288, 22)
        Me.btnAbsoluteValue.Name = "btnAbsoluteValue"
        Me.btnAbsoluteValue.Size = New System.Drawing.Size(91, 23)
        Me.btnAbsoluteValue.TabIndex = 2
        Me.btnAbsoluteValue.Text = "Absolute Value"
        Me.btnAbsoluteValue.UseVisualStyleBackColor = True
        '
        'btnSquareRoot
        '
        Me.btnSquareRoot.Location = New System.Drawing.Point(288, 51)
        Me.btnSquareRoot.Name = "btnSquareRoot"
        Me.btnSquareRoot.Size = New System.Drawing.Size(75, 23)
        Me.btnSquareRoot.TabIndex = 3
        Me.btnSquareRoot.Text = "Square Root"
        Me.btnSquareRoot.UseVisualStyleBackColor = True
        '
        'btnSign
        '
        Me.btnSign.Location = New System.Drawing.Point(288, 80)
        Me.btnSign.Name = "btnSign"
        Me.btnSign.Size = New System.Drawing.Size(75, 23)
        Me.btnSign.TabIndex = 4
        Me.btnSign.Text = "Sign"
        Me.btnSign.UseVisualStyleBackColor = True
        '
        'txtNumber
        '
        Me.txtNumber.Location = New System.Drawing.Point(125, 23)
        Me.txtNumber.Name = "txtNumber"
        Me.txtNumber.Size = New System.Drawing.Size(37, 20)
        Me.txtNumber.TabIndex = 5
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(391, 115)
        Me.Controls.Add(Me.txtNumber)
        Me.Controls.Add(Me.btnSign)
        Me.Controls.Add(Me.btnSquareRoot)
        Me.Controls.Add(Me.btnAbsoluteValue)
        Me.Controls.Add(Me.lblSTUFF)
        Me.Controls.Add(Me.lblNumber)
        Me.Name = "Form1"
        Me.Text = "Mathematical Functions"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblNumber As System.Windows.Forms.Label
    Friend WithEvents lblSTUFF As System.Windows.Forms.Label
    Friend WithEvents btnAbsoluteValue As System.Windows.Forms.Button
    Friend WithEvents btnSquareRoot As System.Windows.Forms.Button
    Friend WithEvents btnSign As System.Windows.Forms.Button
    Friend WithEvents txtNumber As System.Windows.Forms.TextBox

End Class
