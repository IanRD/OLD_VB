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
        Me.grpThrows = New System.Windows.Forms.GroupBox()
        Me.radScissors = New System.Windows.Forms.RadioButton()
        Me.radPaper = New System.Windows.Forms.RadioButton()
        Me.radRock = New System.Windows.Forms.RadioButton()
        Me.btnGo = New System.Windows.Forms.Button()
        Me.lblwinner = New System.Windows.Forms.Label()
        Me.lbluser = New System.Windows.Forms.Label()
        Me.lblcomp = New System.Windows.Forms.Label()
        Me.lbldraws = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.grpThrows.SuspendLayout()
        Me.SuspendLayout()
        '
        'grpThrows
        '
        Me.grpThrows.Controls.Add(Me.radScissors)
        Me.grpThrows.Controls.Add(Me.radPaper)
        Me.grpThrows.Controls.Add(Me.radRock)
        Me.grpThrows.Location = New System.Drawing.Point(12, 35)
        Me.grpThrows.Name = "grpThrows"
        Me.grpThrows.Size = New System.Drawing.Size(268, 74)
        Me.grpThrows.TabIndex = 0
        Me.grpThrows.TabStop = False
        Me.grpThrows.Text = "Choose Your Throw"
        '
        'radScissors
        '
        Me.radScissors.AutoSize = True
        Me.radScissors.Location = New System.Drawing.Point(198, 33)
        Me.radScissors.Name = "radScissors"
        Me.radScissors.Size = New System.Drawing.Size(64, 17)
        Me.radScissors.TabIndex = 2
        Me.radScissors.TabStop = True
        Me.radScissors.Text = "Scissors"
        Me.radScissors.UseVisualStyleBackColor = True
        '
        'radPaper
        '
        Me.radPaper.AutoSize = True
        Me.radPaper.Location = New System.Drawing.Point(100, 33)
        Me.radPaper.Name = "radPaper"
        Me.radPaper.Size = New System.Drawing.Size(53, 17)
        Me.radPaper.TabIndex = 1
        Me.radPaper.TabStop = True
        Me.radPaper.Text = "Paper"
        Me.radPaper.UseVisualStyleBackColor = True
        '
        'radRock
        '
        Me.radRock.AutoSize = True
        Me.radRock.Location = New System.Drawing.Point(7, 33)
        Me.radRock.Name = "radRock"
        Me.radRock.Size = New System.Drawing.Size(51, 17)
        Me.radRock.TabIndex = 0
        Me.radRock.TabStop = True
        Me.radRock.Text = "Rock"
        Me.radRock.UseVisualStyleBackColor = True
        '
        'btnGo
        '
        Me.btnGo.Location = New System.Drawing.Point(95, 124)
        Me.btnGo.Name = "btnGo"
        Me.btnGo.Size = New System.Drawing.Size(89, 23)
        Me.btnGo.TabIndex = 1
        Me.btnGo.Text = "Go!"
        Me.btnGo.UseVisualStyleBackColor = True
        '
        'lblwinner
        '
        Me.lblwinner.AutoSize = True
        Me.lblwinner.Location = New System.Drawing.Point(45, 9)
        Me.lblwinner.Name = "lblwinner"
        Me.lblwinner.Size = New System.Drawing.Size(0, 13)
        Me.lblwinner.TabIndex = 2
        '
        'lbluser
        '
        Me.lbluser.AutoSize = True
        Me.lbluser.Location = New System.Drawing.Point(29, 186)
        Me.lbluser.Name = "lbluser"
        Me.lbluser.Size = New System.Drawing.Size(0, 13)
        Me.lbluser.TabIndex = 3
        '
        'lblcomp
        '
        Me.lblcomp.AutoSize = True
        Me.lblcomp.Location = New System.Drawing.Point(223, 186)
        Me.lblcomp.Name = "lblcomp"
        Me.lblcomp.Size = New System.Drawing.Size(0, 13)
        Me.lblcomp.TabIndex = 4
        '
        'lbldraws
        '
        Me.lbldraws.AutoSize = True
        Me.lbldraws.Location = New System.Drawing.Point(126, 186)
        Me.lbldraws.Name = "lbldraws"
        Me.lbldraws.Size = New System.Drawing.Size(0, 13)
        Me.lbldraws.TabIndex = 5
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(16, 159)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(56, 13)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "User Wins"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(126, 159)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(37, 13)
        Me.Label2.TabIndex = 7
        Me.Label2.Text = "Draws"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(201, 159)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(79, 13)
        Me.Label3.TabIndex = 8
        Me.Label3.Text = "Computer Wins"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(292, 204)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lbldraws)
        Me.Controls.Add(Me.lblcomp)
        Me.Controls.Add(Me.lbluser)
        Me.Controls.Add(Me.lblwinner)
        Me.Controls.Add(Me.btnGo)
        Me.Controls.Add(Me.grpThrows)
        Me.Name = "Form1"
        Me.Text = "Rock Paper Scissors"
        Me.grpThrows.ResumeLayout(False)
        Me.grpThrows.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents grpThrows As System.Windows.Forms.GroupBox
    Friend WithEvents radScissors As System.Windows.Forms.RadioButton
    Friend WithEvents radPaper As System.Windows.Forms.RadioButton
    Friend WithEvents radRock As System.Windows.Forms.RadioButton
    Friend WithEvents btnGo As System.Windows.Forms.Button
    Friend WithEvents lblwinner As System.Windows.Forms.Label
    Friend WithEvents lbluser As System.Windows.Forms.Label
    Friend WithEvents lblcomp As System.Windows.Forms.Label
    Friend WithEvents lbldraws As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label

End Class
