<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class RectangleAreaandPerimeter
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
        Me.lblArea = New System.Windows.Forms.Label()
        Me.lblPerimeter = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.btnAnswer = New System.Windows.Forms.Button()
        Me.lblarea2 = New System.Windows.Forms.Label()
        Me.lblperimeter2 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'lblArea
        '
        Me.lblArea.AutoSize = True
        Me.lblArea.Location = New System.Drawing.Point(77, 129)
        Me.lblArea.Name = "lblArea"
        Me.lblArea.Size = New System.Drawing.Size(38, 13)
        Me.lblArea.TabIndex = 0
        Me.lblArea.Text = "Area ="
        '
        'lblPerimeter
        '
        Me.lblPerimeter.AutoSize = True
        Me.lblPerimeter.Location = New System.Drawing.Point(55, 160)
        Me.lblPerimeter.Name = "lblPerimeter"
        Me.lblPerimeter.Size = New System.Drawing.Size(60, 13)
        Me.lblPerimeter.TabIndex = 1
        Me.lblPerimeter.Text = "Perimeter ="
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(43, 48)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(347, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "What is the area and perimeter of a rectangle with length 5 and width 3?"
        '
        'btnAnswer
        '
        Me.btnAnswer.Location = New System.Drawing.Point(345, 140)
        Me.btnAnswer.Name = "btnAnswer"
        Me.btnAnswer.Size = New System.Drawing.Size(75, 23)
        Me.btnAnswer.TabIndex = 3
        Me.btnAnswer.Text = "Answer"
        Me.btnAnswer.UseVisualStyleBackColor = True
        '
        'lblarea2
        '
        Me.lblarea2.AutoSize = True
        Me.lblarea2.Location = New System.Drawing.Point(151, 129)
        Me.lblarea2.Name = "lblarea2"
        Me.lblarea2.Size = New System.Drawing.Size(0, 13)
        Me.lblarea2.TabIndex = 4
        '
        'lblperimeter2
        '
        Me.lblperimeter2.AutoSize = True
        Me.lblperimeter2.Location = New System.Drawing.Point(151, 160)
        Me.lblperimeter2.Name = "lblperimeter2"
        Me.lblperimeter2.Size = New System.Drawing.Size(0, 13)
        Me.lblperimeter2.TabIndex = 5
        '
        'RectangleAreaandPerimeter
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(441, 211)
        Me.Controls.Add(Me.lblperimeter2)
        Me.Controls.Add(Me.lblarea2)
        Me.Controls.Add(Me.btnAnswer)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.lblPerimeter)
        Me.Controls.Add(Me.lblArea)
        Me.Name = "RectangleAreaandPerimeter"
        Me.Text = "Rectangle Area and Perimeter"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblArea As System.Windows.Forms.Label
    Friend WithEvents lblPerimeter As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents btnAnswer As System.Windows.Forms.Button
    Friend WithEvents lblarea2 As System.Windows.Forms.Label
    Friend WithEvents lblperimeter2 As System.Windows.Forms.Label

End Class
