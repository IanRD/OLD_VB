<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class LongJumpAverage
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
        Me.lblquestion = New System.Windows.Forms.Label()
        Me.btnanswer = New System.Windows.Forms.Button()
        Me.lblAverage = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'lblquestion
        '
        Me.lblquestion.AutoSize = True
        Me.lblquestion.Location = New System.Drawing.Point(12, 24)
        Me.lblquestion.Name = "lblquestion"
        Me.lblquestion.Size = New System.Drawing.Size(447, 13)
        Me.lblquestion.TabIndex = 0
        Me.lblquestion.Text = "What is the average jump length of a long-jumper whose jumps were 3.3m, 3.5m, 4.0" & _
            "m, 3.0m?"
        '
        'btnanswer
        '
        Me.btnanswer.Location = New System.Drawing.Point(324, 64)
        Me.btnanswer.Name = "btnanswer"
        Me.btnanswer.Size = New System.Drawing.Size(125, 34)
        Me.btnanswer.TabIndex = 1
        Me.btnanswer.Text = "Answer"
        Me.btnanswer.UseVisualStyleBackColor = True
        '
        'lblAverage
        '
        Me.lblAverage.AutoSize = True
        Me.lblAverage.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAverage.Location = New System.Drawing.Point(43, 64)
        Me.lblAverage.Name = "lblAverage"
        Me.lblAverage.Size = New System.Drawing.Size(0, 24)
        Me.lblAverage.TabIndex = 2
        '
        'LongJumpAverage
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(496, 126)
        Me.Controls.Add(Me.lblAverage)
        Me.Controls.Add(Me.btnanswer)
        Me.Controls.Add(Me.lblquestion)
        Me.Name = "LongJumpAverage"
        Me.Text = "Long Jump Average"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblquestion As System.Windows.Forms.Label
    Friend WithEvents btnanswer As System.Windows.Forms.Button
    Friend WithEvents lblAverage As System.Windows.Forms.Label

End Class
