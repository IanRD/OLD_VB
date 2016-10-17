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
        Me.lblValue = New System.Windows.Forms.Label()
        Me.txtValue = New System.Windows.Forms.TextBox()
        Me.btnArcSine = New System.Windows.Forms.Button()
        Me.btnArcCosine = New System.Windows.Forms.Button()
        Me.btnArcTangent = New System.Windows.Forms.Button()
        Me.lblAnswer = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'lblValue
        '
        Me.lblValue.AutoSize = True
        Me.lblValue.Location = New System.Drawing.Point(21, 27)
        Me.lblValue.Name = "lblValue"
        Me.lblValue.Size = New System.Drawing.Size(73, 13)
        Me.lblValue.TabIndex = 0
        Me.lblValue.Text = "Enter a value:"
        '
        'txtValue
        '
        Me.txtValue.Location = New System.Drawing.Point(100, 24)
        Me.txtValue.Name = "txtValue"
        Me.txtValue.Size = New System.Drawing.Size(100, 20)
        Me.txtValue.TabIndex = 1
        '
        'btnArcSine
        '
        Me.btnArcSine.Location = New System.Drawing.Point(251, 22)
        Me.btnArcSine.Name = "btnArcSine"
        Me.btnArcSine.Size = New System.Drawing.Size(75, 23)
        Me.btnArcSine.TabIndex = 2
        Me.btnArcSine.Text = "Arcsine"
        Me.btnArcSine.UseVisualStyleBackColor = True
        '
        'btnArcCosine
        '
        Me.btnArcCosine.Location = New System.Drawing.Point(251, 68)
        Me.btnArcCosine.Name = "btnArcCosine"
        Me.btnArcCosine.Size = New System.Drawing.Size(75, 23)
        Me.btnArcCosine.TabIndex = 3
        Me.btnArcCosine.Text = "Arccosine"
        Me.btnArcCosine.UseVisualStyleBackColor = True
        '
        'btnArcTangent
        '
        Me.btnArcTangent.Location = New System.Drawing.Point(251, 114)
        Me.btnArcTangent.Name = "btnArcTangent"
        Me.btnArcTangent.Size = New System.Drawing.Size(75, 23)
        Me.btnArcTangent.TabIndex = 4
        Me.btnArcTangent.Text = "Arctangent"
        Me.btnArcTangent.UseVisualStyleBackColor = True
        '
        'lblAnswer
        '
        Me.lblAnswer.Location = New System.Drawing.Point(21, 86)
        Me.lblAnswer.Name = "lblAnswer"
        Me.lblAnswer.Size = New System.Drawing.Size(179, 51)
        Me.lblAnswer.TabIndex = 5
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(352, 165)
        Me.Controls.Add(Me.lblAnswer)
        Me.Controls.Add(Me.btnArcTangent)
        Me.Controls.Add(Me.btnArcCosine)
        Me.Controls.Add(Me.btnArcSine)
        Me.Controls.Add(Me.txtValue)
        Me.Controls.Add(Me.lblValue)
        Me.Name = "Form1"
        Me.Text = "Inverse Trigonometric Functions"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblValue As System.Windows.Forms.Label
    Friend WithEvents txtValue As System.Windows.Forms.TextBox
    Friend WithEvents btnArcSine As System.Windows.Forms.Button
    Friend WithEvents btnArcCosine As System.Windows.Forms.Button
    Friend WithEvents btnArcTangent As System.Windows.Forms.Button
    Friend WithEvents lblAnswer As System.Windows.Forms.Label

End Class
