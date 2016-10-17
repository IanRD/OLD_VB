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
        Me.lblTuition = New System.Windows.Forms.Label()
        Me.btnCalculate = New System.Windows.Forms.Button()
        Me.lstCourseLevels = New System.Windows.Forms.ListBox()
        Me.lblCourseLevelList = New System.Windows.Forms.Label()
        Me.cboCreditHours = New System.Windows.Forms.ComboBox()
        Me.lblCredit = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'lblTuition
        '
        Me.lblTuition.Location = New System.Drawing.Point(42, 160)
        Me.lblTuition.Name = "lblTuition"
        Me.lblTuition.Size = New System.Drawing.Size(319, 40)
        Me.lblTuition.TabIndex = 7
        '
        'btnCalculate
        '
        Me.btnCalculate.Location = New System.Drawing.Point(286, 104)
        Me.btnCalculate.Name = "btnCalculate"
        Me.btnCalculate.Size = New System.Drawing.Size(75, 23)
        Me.btnCalculate.TabIndex = 6
        Me.btnCalculate.Text = "Calculate"
        Me.btnCalculate.UseVisualStyleBackColor = True
        '
        'lstCourseLevels
        '
        Me.lstCourseLevels.FormattingEnabled = True
        Me.lstCourseLevels.Items.AddRange(New Object() {"Undergraduate", "Graduate", "Thesis and Dissertation"})
        Me.lstCourseLevels.Location = New System.Drawing.Point(42, 59)
        Me.lstCourseLevels.Name = "lstCourseLevels"
        Me.lstCourseLevels.Size = New System.Drawing.Size(158, 69)
        Me.lstCourseLevels.TabIndex = 5
        '
        'lblCourseLevelList
        '
        Me.lblCourseLevelList.AutoSize = True
        Me.lblCourseLevelList.Location = New System.Drawing.Point(39, 34)
        Me.lblCourseLevelList.Name = "lblCourseLevelList"
        Me.lblCourseLevelList.Size = New System.Drawing.Size(72, 13)
        Me.lblCourseLevelList.TabIndex = 4
        Me.lblCourseLevelList.Text = "Course Level:"
        '
        'cboCreditHours
        '
        Me.cboCreditHours.FormattingEnabled = True
        Me.cboCreditHours.Items.AddRange(New Object() {"3", "6", "9", "12", "15"})
        Me.cboCreditHours.Location = New System.Drawing.Point(286, 59)
        Me.cboCreditHours.Name = "cboCreditHours"
        Me.cboCreditHours.Size = New System.Drawing.Size(47, 21)
        Me.cboCreditHours.TabIndex = 8
        '
        'lblCredit
        '
        Me.lblCredit.AutoSize = True
        Me.lblCredit.Location = New System.Drawing.Point(283, 34)
        Me.lblCredit.Name = "lblCredit"
        Me.lblCredit.Size = New System.Drawing.Size(68, 13)
        Me.lblCredit.TabIndex = 9
        Me.lblCredit.Text = "Credit Hours:"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(401, 234)
        Me.Controls.Add(Me.lblCredit)
        Me.Controls.Add(Me.cboCreditHours)
        Me.Controls.Add(Me.lblTuition)
        Me.Controls.Add(Me.btnCalculate)
        Me.Controls.Add(Me.lstCourseLevels)
        Me.Controls.Add(Me.lblCourseLevelList)
        Me.Name = "Form1"
        Me.Text = "Tuition Calculator"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblTuition As System.Windows.Forms.Label
    Friend WithEvents btnCalculate As System.Windows.Forms.Button
    Friend WithEvents lstCourseLevels As System.Windows.Forms.ListBox
    Friend WithEvents lblCourseLevelList As System.Windows.Forms.Label
    Friend WithEvents cboCreditHours As System.Windows.Forms.ComboBox
    Friend WithEvents lblCredit As System.Windows.Forms.Label

End Class
