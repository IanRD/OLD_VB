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
        Me.lblinstructions = New System.Windows.Forms.Label()
        Me.btnEnterScores = New System.Windows.Forms.Button()
        Me.btnAverageScore = New System.Windows.Forms.Button()
        Me.lblAverageMessage = New System.Windows.Forms.Label()
        Me.lblScoresMessage = New System.Windows.Forms.Label()
        Me.lblNumberofScores = New System.Windows.Forms.Label()
        Me.lblAverage = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'lblinstructions
        '
        Me.lblinstructions.AutoSize = True
        Me.lblinstructions.Location = New System.Drawing.Point(2, 9)
        Me.lblinstructions.Name = "lblinstructions"
        Me.lblinstructions.Size = New System.Drawing.Size(499, 13)
        Me.lblinstructions.TabIndex = 0
        Me.lblinstructions.Text = "Select Enter Scores to enter test scores. Select Average Score to display the ave" & _
            "rage of scores entered." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        Me.lblinstructions.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnEnterScores
        '
        Me.btnEnterScores.Location = New System.Drawing.Point(36, 45)
        Me.btnEnterScores.Name = "btnEnterScores"
        Me.btnEnterScores.Size = New System.Drawing.Size(82, 23)
        Me.btnEnterScores.TabIndex = 1
        Me.btnEnterScores.Text = "Enter Scores"
        Me.btnEnterScores.UseVisualStyleBackColor = True
        '
        'btnAverageScore
        '
        Me.btnAverageScore.Location = New System.Drawing.Point(36, 94)
        Me.btnAverageScore.Name = "btnAverageScore"
        Me.btnAverageScore.Size = New System.Drawing.Size(92, 23)
        Me.btnAverageScore.TabIndex = 2
        Me.btnAverageScore.Text = "Average Score"
        Me.btnAverageScore.UseVisualStyleBackColor = True
        '
        'lblAverageMessage
        '
        Me.lblAverageMessage.AutoSize = True
        Me.lblAverageMessage.Location = New System.Drawing.Point(155, 99)
        Me.lblAverageMessage.Name = "lblAverageMessage"
        Me.lblAverageMessage.Size = New System.Drawing.Size(0, 13)
        Me.lblAverageMessage.TabIndex = 3
        '
        'lblScoresMessage
        '
        Me.lblScoresMessage.AutoSize = True
        Me.lblScoresMessage.Location = New System.Drawing.Point(155, 50)
        Me.lblScoresMessage.Name = "lblScoresMessage"
        Me.lblScoresMessage.Size = New System.Drawing.Size(0, 13)
        Me.lblScoresMessage.TabIndex = 4
        '
        'lblNumberofScores
        '
        Me.lblNumberofScores.AutoSize = True
        Me.lblNumberofScores.Location = New System.Drawing.Point(319, 50)
        Me.lblNumberofScores.Name = "lblNumberofScores"
        Me.lblNumberofScores.Size = New System.Drawing.Size(0, 13)
        Me.lblNumberofScores.TabIndex = 5
        '
        'lblAverage
        '
        Me.lblAverage.AutoSize = True
        Me.lblAverage.Location = New System.Drawing.Point(319, 99)
        Me.lblAverage.Name = "lblAverage"
        Me.lblAverage.Size = New System.Drawing.Size(0, 13)
        Me.lblAverage.TabIndex = 6
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(502, 138)
        Me.Controls.Add(Me.lblAverage)
        Me.Controls.Add(Me.lblNumberofScores)
        Me.Controls.Add(Me.lblScoresMessage)
        Me.Controls.Add(Me.lblAverageMessage)
        Me.Controls.Add(Me.btnAverageScore)
        Me.Controls.Add(Me.btnEnterScores)
        Me.Controls.Add(Me.lblinstructions)
        Me.Name = "Form1"
        Me.Text = "Average Score"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblinstructions As System.Windows.Forms.Label
    Friend WithEvents btnEnterScores As System.Windows.Forms.Button
    Friend WithEvents btnAverageScore As System.Windows.Forms.Button
    Friend WithEvents lblAverageMessage As System.Windows.Forms.Label
    Friend WithEvents lblScoresMessage As System.Windows.Forms.Label
    Friend WithEvents lblNumberofScores As System.Windows.Forms.Label
    Friend WithEvents lblAverage As System.Windows.Forms.Label

End Class
