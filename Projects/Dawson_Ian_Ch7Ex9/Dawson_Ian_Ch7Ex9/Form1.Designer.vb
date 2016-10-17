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
        Me.lblAngle = New System.Windows.Forms.Label()
        Me.cboAngle = New System.Windows.Forms.ComboBox()
        Me.grpConvert = New System.Windows.Forms.GroupBox()
        Me.radRadianstoDegrees = New System.Windows.Forms.RadioButton()
        Me.radDegreestoRadians = New System.Windows.Forms.RadioButton()
        Me.lblAnswer = New System.Windows.Forms.Label()
        Me.grpConvert.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblAngle
        '
        Me.lblAngle.AutoSize = True
        Me.lblAngle.Location = New System.Drawing.Point(13, 38)
        Me.lblAngle.Name = "lblAngle"
        Me.lblAngle.Size = New System.Drawing.Size(69, 13)
        Me.lblAngle.TabIndex = 0
        Me.lblAngle.Text = "Select angle:"
        '
        'cboAngle
        '
        Me.cboAngle.FormattingEnabled = True
        Me.cboAngle.Items.AddRange(New Object() {"30", "0.52", "45", "0.79", "60", "1.05"})
        Me.cboAngle.Location = New System.Drawing.Point(88, 35)
        Me.cboAngle.Name = "cboAngle"
        Me.cboAngle.Size = New System.Drawing.Size(53, 21)
        Me.cboAngle.TabIndex = 1
        '
        'grpConvert
        '
        Me.grpConvert.Controls.Add(Me.radRadianstoDegrees)
        Me.grpConvert.Controls.Add(Me.radDegreestoRadians)
        Me.grpConvert.Location = New System.Drawing.Point(16, 71)
        Me.grpConvert.Name = "grpConvert"
        Me.grpConvert.Size = New System.Drawing.Size(317, 57)
        Me.grpConvert.TabIndex = 2
        Me.grpConvert.TabStop = False
        Me.grpConvert.Text = "Convert"
        '
        'radRadianstoDegrees
        '
        Me.radRadianstoDegrees.AutoSize = True
        Me.radRadianstoDegrees.Location = New System.Drawing.Point(181, 23)
        Me.radRadianstoDegrees.Name = "radRadianstoDegrees"
        Me.radRadianstoDegrees.Size = New System.Drawing.Size(112, 17)
        Me.radRadianstoDegrees.TabIndex = 1
        Me.radRadianstoDegrees.TabStop = True
        Me.radRadianstoDegrees.Text = "radians to degrees"
        Me.radRadianstoDegrees.UseVisualStyleBackColor = True
        '
        'radDegreestoRadians
        '
        Me.radDegreestoRadians.Location = New System.Drawing.Point(21, 19)
        Me.radDegreestoRadians.Name = "radDegreestoRadians"
        Me.radDegreestoRadians.Size = New System.Drawing.Size(120, 24)
        Me.radDegreestoRadians.TabIndex = 0
        Me.radDegreestoRadians.TabStop = True
        Me.radDegreestoRadians.Text = "degrees to radians"
        Me.radDegreestoRadians.UseVisualStyleBackColor = True
        '
        'lblAnswer
        '
        Me.lblAnswer.AutoSize = True
        Me.lblAnswer.Location = New System.Drawing.Point(147, 149)
        Me.lblAnswer.Name = "lblAnswer"
        Me.lblAnswer.Size = New System.Drawing.Size(0, 13)
        Me.lblAnswer.TabIndex = 3
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(345, 171)
        Me.Controls.Add(Me.lblAnswer)
        Me.Controls.Add(Me.grpConvert)
        Me.Controls.Add(Me.cboAngle)
        Me.Controls.Add(Me.lblAngle)
        Me.Name = "Form1"
        Me.Text = "Angle Conversion"
        Me.grpConvert.ResumeLayout(False)
        Me.grpConvert.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblAngle As System.Windows.Forms.Label
    Friend WithEvents cboAngle As System.Windows.Forms.ComboBox
    Friend WithEvents grpConvert As System.Windows.Forms.GroupBox
    Friend WithEvents radRadianstoDegrees As System.Windows.Forms.RadioButton
    Friend WithEvents radDegreestoRadians As System.Windows.Forms.RadioButton
    Friend WithEvents lblAnswer As System.Windows.Forms.Label

End Class
