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
        Me.lblEnter = New System.Windows.Forms.Label()
        Me.txtNumber = New System.Windows.Forms.TextBox()
        Me.btnLogarithm = New System.Windows.Forms.Button()
        Me.lblAnswer = New System.Windows.Forms.Label()
        Me.btnExp = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lblEnter
        '
        Me.lblEnter.AutoSize = True
        Me.lblEnter.Location = New System.Drawing.Point(23, 37)
        Me.lblEnter.Name = "lblEnter"
        Me.lblEnter.Size = New System.Drawing.Size(82, 13)
        Me.lblEnter.TabIndex = 0
        Me.lblEnter.Text = "Enter a number:"
        '
        'txtNumber
        '
        Me.txtNumber.Location = New System.Drawing.Point(111, 34)
        Me.txtNumber.Name = "txtNumber"
        Me.txtNumber.Size = New System.Drawing.Size(100, 20)
        Me.txtNumber.TabIndex = 1
        '
        'btnLogarithm
        '
        Me.btnLogarithm.Location = New System.Drawing.Point(253, 32)
        Me.btnLogarithm.Name = "btnLogarithm"
        Me.btnLogarithm.Size = New System.Drawing.Size(105, 23)
        Me.btnLogarithm.TabIndex = 2
        Me.btnLogarithm.Text = "Natural Logarithm"
        Me.btnLogarithm.UseVisualStyleBackColor = True
        '
        'lblAnswer
        '
        Me.lblAnswer.AutoSize = True
        Me.lblAnswer.Location = New System.Drawing.Point(108, 107)
        Me.lblAnswer.Name = "lblAnswer"
        Me.lblAnswer.Size = New System.Drawing.Size(0, 13)
        Me.lblAnswer.TabIndex = 3
        '
        'btnExp
        '
        Me.btnExp.Location = New System.Drawing.Point(253, 62)
        Me.btnExp.Name = "btnExp"
        Me.btnExp.Size = New System.Drawing.Size(105, 23)
        Me.btnExp.TabIndex = 4
        Me.btnExp.Text = "e ^ x"
        Me.btnExp.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(379, 155)
        Me.Controls.Add(Me.btnExp)
        Me.Controls.Add(Me.lblAnswer)
        Me.Controls.Add(Me.btnLogarithm)
        Me.Controls.Add(Me.txtNumber)
        Me.Controls.Add(Me.lblEnter)
        Me.Name = "Form1"
        Me.Text = "Log and Exp Functions"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblEnter As System.Windows.Forms.Label
    Friend WithEvents txtNumber As System.Windows.Forms.TextBox
    Friend WithEvents btnLogarithm As System.Windows.Forms.Button
    Friend WithEvents lblAnswer As System.Windows.Forms.Label
    Friend WithEvents btnExp As System.Windows.Forms.Button

End Class
