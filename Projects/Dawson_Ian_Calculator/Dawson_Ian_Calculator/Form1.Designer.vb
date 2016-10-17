<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Calculator
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
        Me.lbl10p1prompt = New System.Windows.Forms.Label()
        Me.txt0perand1 = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txt0perand2 = New System.Windows.Forms.TextBox()
        Me.grp0perators = New System.Windows.Forms.GroupBox()
        Me.radExponentiation = New System.Windows.Forms.RadioButton()
        Me.radMultiplication = New System.Windows.Forms.RadioButton()
        Me.radDivision = New System.Windows.Forms.RadioButton()
        Me.radIntdivision = New System.Windows.Forms.RadioButton()
        Me.radModdivision = New System.Windows.Forms.RadioButton()
        Me.radAddition = New System.Windows.Forms.RadioButton()
        Me.radSubtraction = New System.Windows.Forms.RadioButton()
        Me.lblResult = New System.Windows.Forms.Label()
        Me.lblexpressionvalue = New System.Windows.Forms.Label()
        Me.grp0perators.SuspendLayout()
        Me.SuspendLayout()
        '
        'lbl10p1prompt
        '
        Me.lbl10p1prompt.AutoSize = True
        Me.lbl10p1prompt.Location = New System.Drawing.Point(12, 42)
        Me.lbl10p1prompt.Name = "lbl10p1prompt"
        Me.lbl10p1prompt.Size = New System.Drawing.Size(73, 13)
        Me.lbl10p1prompt.TabIndex = 0
        Me.lbl10p1prompt.Text = "First Operand:"
        '
        'txt0perand1
        '
        Me.txt0perand1.Location = New System.Drawing.Point(88, 39)
        Me.txt0perand1.Name = "txt0perand1"
        Me.txt0perand1.Size = New System.Drawing.Size(28, 20)
        Me.txt0perand1.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(187, 42)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(91, 13)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Second Operand:"
        '
        'txt0perand2
        '
        Me.txt0perand2.Location = New System.Drawing.Point(281, 39)
        Me.txt0perand2.Name = "txt0perand2"
        Me.txt0perand2.Size = New System.Drawing.Size(27, 20)
        Me.txt0perand2.TabIndex = 3
        '
        'grp0perators
        '
        Me.grp0perators.Controls.Add(Me.radSubtraction)
        Me.grp0perators.Controls.Add(Me.radAddition)
        Me.grp0perators.Controls.Add(Me.radModdivision)
        Me.grp0perators.Controls.Add(Me.radIntdivision)
        Me.grp0perators.Controls.Add(Me.radDivision)
        Me.grp0perators.Controls.Add(Me.radMultiplication)
        Me.grp0perators.Controls.Add(Me.radExponentiation)
        Me.grp0perators.Location = New System.Drawing.Point(8, 96)
        Me.grp0perators.Name = "grp0perators"
        Me.grp0perators.Size = New System.Drawing.Size(319, 64)
        Me.grp0perators.TabIndex = 4
        Me.grp0perators.TabStop = False
        Me.grp0perators.Text = "Select an Operator"
        '
        'radExponentiation
        '
        Me.radExponentiation.AutoSize = True
        Me.radExponentiation.Location = New System.Drawing.Point(28, 29)
        Me.radExponentiation.Name = "radExponentiation"
        Me.radExponentiation.Size = New System.Drawing.Size(31, 17)
        Me.radExponentiation.TabIndex = 0
        Me.radExponentiation.TabStop = True
        Me.radExponentiation.Text = "^"
        Me.radExponentiation.UseVisualStyleBackColor = True
        '
        'radMultiplication
        '
        Me.radMultiplication.AutoSize = True
        Me.radMultiplication.Location = New System.Drawing.Point(65, 29)
        Me.radMultiplication.Name = "radMultiplication"
        Me.radMultiplication.Size = New System.Drawing.Size(29, 17)
        Me.radMultiplication.TabIndex = 1
        Me.radMultiplication.TabStop = True
        Me.radMultiplication.Text = "*"
        Me.radMultiplication.UseVisualStyleBackColor = True
        '
        'radDivision
        '
        Me.radDivision.AutoSize = True
        Me.radDivision.Location = New System.Drawing.Point(100, 29)
        Me.radDivision.Name = "radDivision"
        Me.radDivision.Size = New System.Drawing.Size(30, 17)
        Me.radDivision.TabIndex = 2
        Me.radDivision.TabStop = True
        Me.radDivision.Text = "/"
        Me.radDivision.UseVisualStyleBackColor = True
        '
        'radIntdivision
        '
        Me.radIntdivision.AutoSize = True
        Me.radIntdivision.Location = New System.Drawing.Point(136, 29)
        Me.radIntdivision.Name = "radIntdivision"
        Me.radIntdivision.Size = New System.Drawing.Size(30, 17)
        Me.radIntdivision.TabIndex = 3
        Me.radIntdivision.TabStop = True
        Me.radIntdivision.Text = "\"
        Me.radIntdivision.UseVisualStyleBackColor = True
        '
        'radModdivision
        '
        Me.radModdivision.AutoSize = True
        Me.radModdivision.Location = New System.Drawing.Point(172, 29)
        Me.radModdivision.Name = "radModdivision"
        Me.radModdivision.Size = New System.Drawing.Size(46, 17)
        Me.radModdivision.TabIndex = 4
        Me.radModdivision.TabStop = True
        Me.radModdivision.Text = "Mod"
        Me.radModdivision.UseVisualStyleBackColor = True
        '
        'radAddition
        '
        Me.radAddition.AutoSize = True
        Me.radAddition.Location = New System.Drawing.Point(224, 29)
        Me.radAddition.Name = "radAddition"
        Me.radAddition.Size = New System.Drawing.Size(31, 17)
        Me.radAddition.TabIndex = 5
        Me.radAddition.TabStop = True
        Me.radAddition.Text = "+"
        Me.radAddition.UseVisualStyleBackColor = True
        '
        'radSubtraction
        '
        Me.radSubtraction.AutoSize = True
        Me.radSubtraction.Location = New System.Drawing.Point(261, 29)
        Me.radSubtraction.Name = "radSubtraction"
        Me.radSubtraction.Size = New System.Drawing.Size(28, 17)
        Me.radSubtraction.TabIndex = 6
        Me.radSubtraction.TabStop = True
        Me.radSubtraction.Text = "-"
        Me.radSubtraction.UseVisualStyleBackColor = True
        '
        'lblResult
        '
        Me.lblResult.AutoSize = True
        Me.lblResult.Location = New System.Drawing.Point(15, 201)
        Me.lblResult.Name = "lblResult"
        Me.lblResult.Size = New System.Drawing.Size(40, 13)
        Me.lblResult.TabIndex = 5
        Me.lblResult.Text = "Result:"
        '
        'lblexpressionvalue
        '
        Me.lblexpressionvalue.AutoSize = True
        Me.lblexpressionvalue.Location = New System.Drawing.Point(70, 201)
        Me.lblexpressionvalue.Name = "lblexpressionvalue"
        Me.lblexpressionvalue.Size = New System.Drawing.Size(0, 13)
        Me.lblexpressionvalue.TabIndex = 6
        '
        'Calculator
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(336, 247)
        Me.Controls.Add(Me.lblexpressionvalue)
        Me.Controls.Add(Me.lblResult)
        Me.Controls.Add(Me.grp0perators)
        Me.Controls.Add(Me.txt0perand2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txt0perand1)
        Me.Controls.Add(Me.lbl10p1prompt)
        Me.Name = "Calculator"
        Me.Text = "Calculator"
        Me.grp0perators.ResumeLayout(False)
        Me.grp0perators.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lbl10p1prompt As System.Windows.Forms.Label
    Friend WithEvents txt0perand1 As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txt0perand2 As System.Windows.Forms.TextBox
    Friend WithEvents grp0perators As System.Windows.Forms.GroupBox
    Friend WithEvents radSubtraction As System.Windows.Forms.RadioButton
    Friend WithEvents radAddition As System.Windows.Forms.RadioButton
    Friend WithEvents radModdivision As System.Windows.Forms.RadioButton
    Friend WithEvents radIntdivision As System.Windows.Forms.RadioButton
    Friend WithEvents radDivision As System.Windows.Forms.RadioButton
    Friend WithEvents radMultiplication As System.Windows.Forms.RadioButton
    Friend WithEvents radExponentiation As System.Windows.Forms.RadioButton
    Friend WithEvents lblResult As System.Windows.Forms.Label
    Friend WithEvents lblexpressionvalue As System.Windows.Forms.Label

End Class
