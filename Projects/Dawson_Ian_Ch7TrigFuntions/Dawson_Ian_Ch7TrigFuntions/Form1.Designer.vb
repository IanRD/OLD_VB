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
        Me.txtDegrees = New System.Windows.Forms.TextBox()
        Me.lblFunction = New System.Windows.Forms.Label()
        Me.lstFunctions = New System.Windows.Forms.ListBox()
        Me.lblAnswer = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'lblAngle
        '
        Me.lblAngle.AutoSize = True
        Me.lblAngle.Location = New System.Drawing.Point(32, 36)
        Me.lblAngle.Name = "lblAngle"
        Me.lblAngle.Size = New System.Drawing.Size(131, 13)
        Me.lblAngle.TabIndex = 0
        Me.lblAngle.Text = "Enter an angle in degrees:"
        '
        'txtDegrees
        '
        Me.txtDegrees.Location = New System.Drawing.Point(178, 33)
        Me.txtDegrees.Name = "txtDegrees"
        Me.txtDegrees.Size = New System.Drawing.Size(100, 20)
        Me.txtDegrees.TabIndex = 1
        '
        'lblFunction
        '
        Me.lblFunction.AutoSize = True
        Me.lblFunction.Location = New System.Drawing.Point(32, 78)
        Me.lblFunction.Name = "lblFunction"
        Me.lblFunction.Size = New System.Drawing.Size(90, 13)
        Me.lblFunction.TabIndex = 2
        Me.lblFunction.Text = "Select a function:"
        '
        'lstFunctions
        '
        Me.lstFunctions.FormattingEnabled = True
        Me.lstFunctions.Items.AddRange(New Object() {"Sine", "Cosine", "Tangent"})
        Me.lstFunctions.Location = New System.Drawing.Point(158, 74)
        Me.lstFunctions.Name = "lstFunctions"
        Me.lstFunctions.Size = New System.Drawing.Size(120, 43)
        Me.lstFunctions.TabIndex = 3
        '
        'lblAnswer
        '
        Me.lblAnswer.AutoSize = True
        Me.lblAnswer.Location = New System.Drawing.Point(99, 158)
        Me.lblAnswer.Name = "lblAnswer"
        Me.lblAnswer.Size = New System.Drawing.Size(0, 13)
        Me.lblAnswer.TabIndex = 4
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(315, 199)
        Me.Controls.Add(Me.lblAnswer)
        Me.Controls.Add(Me.lstFunctions)
        Me.Controls.Add(Me.lblFunction)
        Me.Controls.Add(Me.txtDegrees)
        Me.Controls.Add(Me.lblAngle)
        Me.Name = "Form1"
        Me.Text = "Trigonometric Funtions"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblAngle As System.Windows.Forms.Label
    Friend WithEvents txtDegrees As System.Windows.Forms.TextBox
    Friend WithEvents lblFunction As System.Windows.Forms.Label
    Friend WithEvents lstFunctions As System.Windows.Forms.ListBox
    Friend WithEvents lblAnswer As System.Windows.Forms.Label

End Class
