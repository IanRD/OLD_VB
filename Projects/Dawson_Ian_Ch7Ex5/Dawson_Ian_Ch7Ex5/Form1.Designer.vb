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
        Me.lstPyth = New System.Windows.Forms.ListBox()
        Me.btnCompute = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lstPyth
        '
        Me.lstPyth.FormattingEnabled = True
        Me.lstPyth.Items.AddRange(New Object() {"A                    B                    C"})
        Me.lstPyth.Location = New System.Drawing.Point(12, 12)
        Me.lstPyth.Name = "lstPyth"
        Me.lstPyth.Size = New System.Drawing.Size(213, 277)
        Me.lstPyth.TabIndex = 0
        '
        'btnCompute
        '
        Me.btnCompute.Location = New System.Drawing.Point(80, 301)
        Me.btnCompute.Name = "btnCompute"
        Me.btnCompute.Size = New System.Drawing.Size(75, 23)
        Me.btnCompute.TabIndex = 1
        Me.btnCompute.Text = "Compute"
        Me.btnCompute.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(237, 336)
        Me.Controls.Add(Me.btnCompute)
        Me.Controls.Add(Me.lstPyth)
        Me.Name = "Form1"
        Me.Text = "Pythagorean Triples"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents lstPyth As System.Windows.Forms.ListBox
    Friend WithEvents btnCompute As System.Windows.Forms.Button

End Class
