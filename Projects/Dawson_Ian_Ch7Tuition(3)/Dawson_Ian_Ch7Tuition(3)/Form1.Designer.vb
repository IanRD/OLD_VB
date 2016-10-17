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
        Me.lblCredit = New System.Windows.Forms.Label()
        Me.cboCreditHours = New System.Windows.Forms.ComboBox()
        Me.lblTuition = New System.Windows.Forms.Label()
        Me.btnCalculate = New System.Windows.Forms.Button()
        Me.lstCourseLevels = New System.Windows.Forms.ListBox()
        Me.lblCourseLevelList = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'lblCredit
        '
        Me.lblCredit.AutoSize = True
        Me.lblCredit.Location = New System.Drawing.Point(280, 26)
        Me.lblCredit.Name = "lblCredit"
        Me.lblCredit.Size = New System.Drawing.Size(68, 13)
        Me.lblCredit.TabIndex = 3
        Me.lblCredit.Text = "C&redit Hours:"
        '
        'cboCreditHours
        '
        Me.cboCreditHours.FormattingEnabled = True
        Me.cboCreditHours.Items.AddRange(New Object() {"3", "6", "9", "12", "15"})
        Me.cboCreditHours.Location = New System.Drawing.Point(283, 51)
        Me.cboCreditHours.Name = "cboCreditHours"
        Me.cboCreditHours.Size = New System.Drawing.Size(47, 21)
        Me.cboCreditHours.TabIndex = 4
        '
        'lblTuition
        '
        Me.lblTuition.Location = New System.Drawing.Point(39, 152)
        Me.lblTuition.Name = "lblTuition"
        Me.lblTuition.Size = New System.Drawing.Size(319, 40)
        Me.lblTuition.TabIndex = 5
        '
        'btnCalculate
        '
        Me.btnCalculate.Enabled = False
        Me.btnCalculate.Location = New System.Drawing.Point(283, 96)
        Me.btnCalculate.Name = "btnCalculate"
        Me.btnCalculate.Size = New System.Drawing.Size(75, 23)
        Me.btnCalculate.TabIndex = 6
        Me.btnCalculate.Text = "C&alculate"
        Me.btnCalculate.UseVisualStyleBackColor = True
        '
        'lstCourseLevels
        '
        Me.lstCourseLevels.FormattingEnabled = True
        Me.lstCourseLevels.Items.AddRange(New Object() {"Undergraduate", "Graduate", "Thesis and Dissertation"})
        Me.lstCourseLevels.Location = New System.Drawing.Point(39, 51)
        Me.lstCourseLevels.Name = "lstCourseLevels"
        Me.lstCourseLevels.Size = New System.Drawing.Size(158, 69)
        Me.lstCourseLevels.TabIndex = 1
        '
        'lblCourseLevelList
        '
        Me.lblCourseLevelList.AutoSize = True
        Me.lblCourseLevelList.Location = New System.Drawing.Point(36, 26)
        Me.lblCourseLevelList.Name = "lblCourseLevelList"
        Me.lblCourseLevelList.Size = New System.Drawing.Size(72, 13)
        Me.lblCourseLevelList.TabIndex = 0
        Me.lblCourseLevelList.Text = "&Course Level:"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(394, 219)
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
    Friend WithEvents lblCredit As System.Windows.Forms.Label
    Friend WithEvents cboCreditHours As System.Windows.Forms.ComboBox
    Friend WithEvents lblTuition As System.Windows.Forms.Label
    Friend WithEvents btnCalculate As System.Windows.Forms.Button
    Friend WithEvents lstCourseLevels As System.Windows.Forms.ListBox
    Friend WithEvents lblCourseLevelList As System.Windows.Forms.Label

End Class
