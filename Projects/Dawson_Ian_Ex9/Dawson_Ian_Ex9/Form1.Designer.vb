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
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.btnmts = New System.Windows.Forms.RadioButton()
        Me.btnmth = New System.Windows.Forms.RadioButton()
        Me.lblminutes = New System.Windows.Forms.Label()
        Me.txtminutes = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lbl1 = New System.Windows.Forms.Label()
        Me.lbl15 = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.btnmth)
        Me.GroupBox1.Controls.Add(Me.btnmts)
        Me.GroupBox1.Location = New System.Drawing.Point(2, 66)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(285, 72)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Select time conversion"
        '
        'btnmts
        '
        Me.btnmts.AutoSize = True
        Me.btnmts.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnmts.Location = New System.Drawing.Point(6, 34)
        Me.btnmts.Name = "btnmts"
        Me.btnmts.Size = New System.Drawing.Size(104, 16)
        Me.btnmts.TabIndex = 0
        Me.btnmts.TabStop = True
        Me.btnmts.Text = "Minutes to seconds"
        Me.btnmts.UseVisualStyleBackColor = True
        '
        'btnmth
        '
        Me.btnmth.AutoSize = True
        Me.btnmth.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnmth.Location = New System.Drawing.Point(131, 34)
        Me.btnmth.Name = "btnmth"
        Me.btnmth.Size = New System.Drawing.Size(147, 16)
        Me.btnmth.TabIndex = 1
        Me.btnmth.TabStop = True
        Me.btnmth.Text = "Minutes to hour:minute format"
        Me.btnmth.UseVisualStyleBackColor = True
        '
        'lblminutes
        '
        Me.lblminutes.AutoSize = True
        Me.lblminutes.Location = New System.Drawing.Point(12, 30)
        Me.lblminutes.Name = "lblminutes"
        Me.lblminutes.Size = New System.Drawing.Size(125, 13)
        Me.lblminutes.TabIndex = 1
        Me.lblminutes.Text = "Enter the time in minutes:"
        '
        'txtminutes
        '
        Me.txtminutes.Location = New System.Drawing.Point(152, 27)
        Me.txtminutes.Name = "txtminutes"
        Me.txtminutes.Size = New System.Drawing.Size(100, 20)
        Me.txtminutes.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 173)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(162, 13)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "The time in hour:minute format is:"
        '
        'lbl1
        '
        Me.lbl1.AutoSize = True
        Me.lbl1.Location = New System.Drawing.Point(180, 173)
        Me.lbl1.Name = "lbl1"
        Me.lbl1.Size = New System.Drawing.Size(0, 13)
        Me.lbl1.TabIndex = 4
        '
        'lbl15
        '
        Me.lbl15.AutoSize = True
        Me.lbl15.Location = New System.Drawing.Point(225, 173)
        Me.lbl15.Name = "lbl15"
        Me.lbl15.Size = New System.Drawing.Size(0, 13)
        Me.lbl15.TabIndex = 5
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(292, 212)
        Me.Controls.Add(Me.lbl15)
        Me.Controls.Add(Me.lbl1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtminutes)
        Me.Controls.Add(Me.lblminutes)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "Form1"
        Me.Text = "Time Conversion"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents btnmts As System.Windows.Forms.RadioButton
    Friend WithEvents btnmth As System.Windows.Forms.RadioButton
    Friend WithEvents lblminutes As System.Windows.Forms.Label
    Friend WithEvents txtminutes As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents lbl1 As System.Windows.Forms.Label
    Friend WithEvents lbl15 As System.Windows.Forms.Label

End Class
