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
        Me.lblSecretWord = New System.Windows.Forms.Label()
        Me.btnPlayGame = New System.Windows.Forms.Button()
        Me.lblScore = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'lblSecretWord
        '
        Me.lblSecretWord.AutoSize = True
        Me.lblSecretWord.Font = New System.Drawing.Font("Microsoft Sans Serif", 36.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSecretWord.Location = New System.Drawing.Point(12, 46)
        Me.lblSecretWord.Name = "lblSecretWord"
        Me.lblSecretWord.Size = New System.Drawing.Size(0, 55)
        Me.lblSecretWord.TabIndex = 0
        Me.lblSecretWord.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnPlayGame
        '
        Me.btnPlayGame.Location = New System.Drawing.Point(91, 184)
        Me.btnPlayGame.Name = "btnPlayGame"
        Me.btnPlayGame.Size = New System.Drawing.Size(106, 23)
        Me.btnPlayGame.TabIndex = 1
        Me.btnPlayGame.Text = "Play Game"
        Me.btnPlayGame.UseVisualStyleBackColor = True
        '
        'lblScore
        '
        Me.lblScore.AutoSize = True
        Me.lblScore.Location = New System.Drawing.Point(137, 9)
        Me.lblScore.Name = "lblScore"
        Me.lblScore.Size = New System.Drawing.Size(0, 13)
        Me.lblScore.TabIndex = 2
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(292, 219)
        Me.Controls.Add(Me.lblScore)
        Me.Controls.Add(Me.btnPlayGame)
        Me.Controls.Add(Me.lblSecretWord)
        Me.Name = "Form1"
        Me.Text = "Word Guess"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblSecretWord As System.Windows.Forms.Label
    Friend WithEvents btnPlayGame As System.Windows.Forms.Button
    Friend WithEvents lblScore As System.Windows.Forms.Label

End Class
