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
        Me.lblBacteria = New System.Windows.Forms.Label()
        Me.txtInitial = New System.Windows.Forms.TextBox()
        Me.lblK = New System.Windows.Forms.Label()
        Me.txtK = New System.Windows.Forms.TextBox()
        Me.lblTime = New System.Windows.Forms.Label()
        Me.txtTime = New System.Windows.Forms.TextBox()
        Me.btnCalculate = New System.Windows.Forms.Button()
        Me.lblAnswer = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'lblBacteria
        '
        Me.lblBacteria.AutoSize = True
        Me.lblBacteria.Location = New System.Drawing.Point(12, 36)
        Me.lblBacteria.Name = "lblBacteria"
        Me.lblBacteria.Size = New System.Drawing.Size(115, 13)
        Me.lblBacteria.TabIndex = 0
        Me.lblBacteria.Text = "Initial Bacteria Amount:"
        '
        'txtInitial
        '
        Me.txtInitial.Location = New System.Drawing.Point(133, 33)
        Me.txtInitial.Name = "txtInitial"
        Me.txtInitial.Size = New System.Drawing.Size(51, 20)
        Me.txtInitial.TabIndex = 1
        '
        'lblK
        '
        Me.lblK.AutoSize = True
        Me.lblK.Location = New System.Drawing.Point(12, 64)
        Me.lblK.Name = "lblK"
        Me.lblK.Size = New System.Drawing.Size(16, 13)
        Me.lblK.TabIndex = 2
        Me.lblK.Text = "k:"
        '
        'txtK
        '
        Me.txtK.Location = New System.Drawing.Point(34, 61)
        Me.txtK.Name = "txtK"
        Me.txtK.Size = New System.Drawing.Size(51, 20)
        Me.txtK.TabIndex = 3
        '
        'lblTime
        '
        Me.lblTime.AutoSize = True
        Me.lblTime.Location = New System.Drawing.Point(12, 97)
        Me.lblTime.Name = "lblTime"
        Me.lblTime.Size = New System.Drawing.Size(33, 13)
        Me.lblTime.TabIndex = 4
        Me.lblTime.Text = "Time:"
        '
        'txtTime
        '
        Me.txtTime.Location = New System.Drawing.Point(51, 94)
        Me.txtTime.Name = "txtTime"
        Me.txtTime.Size = New System.Drawing.Size(51, 20)
        Me.txtTime.TabIndex = 5
        '
        'btnCalculate
        '
        Me.btnCalculate.Location = New System.Drawing.Point(192, 94)
        Me.btnCalculate.Name = "btnCalculate"
        Me.btnCalculate.Size = New System.Drawing.Size(75, 23)
        Me.btnCalculate.TabIndex = 6
        Me.btnCalculate.Text = "Calculate"
        Me.btnCalculate.UseVisualStyleBackColor = True
        '
        'lblAnswer
        '
        Me.lblAnswer.Location = New System.Drawing.Point(12, 164)
        Me.lblAnswer.Name = "lblAnswer"
        Me.lblAnswer.Size = New System.Drawing.Size(268, 65)
        Me.lblAnswer.TabIndex = 7
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(292, 238)
        Me.Controls.Add(Me.lblAnswer)
        Me.Controls.Add(Me.btnCalculate)
        Me.Controls.Add(Me.txtTime)
        Me.Controls.Add(Me.lblTime)
        Me.Controls.Add(Me.txtK)
        Me.Controls.Add(Me.lblK)
        Me.Controls.Add(Me.txtInitial)
        Me.Controls.Add(Me.lblBacteria)
        Me.Name = "Form1"
        Me.Text = "Bacteria Growth"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblBacteria As System.Windows.Forms.Label
    Friend WithEvents txtInitial As System.Windows.Forms.TextBox
    Friend WithEvents lblK As System.Windows.Forms.Label
    Friend WithEvents txtK As System.Windows.Forms.TextBox
    Friend WithEvents lblTime As System.Windows.Forms.Label
    Friend WithEvents txtTime As System.Windows.Forms.TextBox
    Friend WithEvents btnCalculate As System.Windows.Forms.Button
    Friend WithEvents lblAnswer As System.Windows.Forms.Label

End Class
