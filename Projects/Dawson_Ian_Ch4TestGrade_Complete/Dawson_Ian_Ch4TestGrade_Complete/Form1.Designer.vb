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
        Me.btnscore = New System.Windows.Forms.Button()
        Me.lblscore = New System.Windows.Forms.Label()
        Me.TXTSCORE = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'btnscore
        '
        Me.btnscore.Location = New System.Drawing.Point(98, 144)
        Me.btnscore.Name = "btnscore"
        Me.btnscore.Size = New System.Drawing.Size(79, 23)
        Me.btnscore.TabIndex = 11
        Me.btnscore.Text = "Check Grade"
        Me.btnscore.UseVisualStyleBackColor = True
        '
        'lblscore
        '
        Me.lblscore.AutoSize = True
        Me.lblscore.Location = New System.Drawing.Point(128, 109)
        Me.lblscore.Name = "lblscore"
        Me.lblscore.Size = New System.Drawing.Size(0, 13)
        Me.lblscore.TabIndex = 10
        '
        'TXTSCORE
        '
        Me.TXTSCORE.Location = New System.Drawing.Point(153, 60)
        Me.TXTSCORE.Name = "TXTSCORE"
        Me.TXTSCORE.Size = New System.Drawing.Size(67, 20)
        Me.TXTSCORE.TabIndex = 9
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(54, 63)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(93, 13)
        Me.Label1.TabIndex = 8
        Me.Label1.Text = "Enter a test score:"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(292, 200)
        Me.Controls.Add(Me.btnscore)
        Me.Controls.Add(Me.lblscore)
        Me.Controls.Add(Me.TXTSCORE)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form1"
        Me.Text = "Test Grade - Complete"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnscore As System.Windows.Forms.Button
    Friend WithEvents lblscore As System.Windows.Forms.Label
    Friend WithEvents TXTSCORE As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label

End Class
