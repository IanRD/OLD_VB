﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
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
        Me.btnRandomNumbers = New System.Windows.Forms.Button()
        Me.lblRandNum6 = New System.Windows.Forms.Label()
        Me.lblRandNum5 = New System.Windows.Forms.Label()
        Me.lblRandNum4 = New System.Windows.Forms.Label()
        Me.lblRandNum3 = New System.Windows.Forms.Label()
        Me.lblRandNum2 = New System.Windows.Forms.Label()
        Me.lblRandNum1 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'btnRandomNumbers
        '
        Me.btnRandomNumbers.Location = New System.Drawing.Point(58, 153)
        Me.btnRandomNumbers.Name = "btnRandomNumbers"
        Me.btnRandomNumbers.Size = New System.Drawing.Size(101, 26)
        Me.btnRandomNumbers.TabIndex = 13
        Me.btnRandomNumbers.Text = "Random Numbers"
        Me.btnRandomNumbers.UseVisualStyleBackColor = True
        '
        'lblRandNum6
        '
        Me.lblRandNum6.AutoSize = True
        Me.lblRandNum6.Location = New System.Drawing.Point(140, 101)
        Me.lblRandNum6.Name = "lblRandNum6"
        Me.lblRandNum6.Size = New System.Drawing.Size(0, 13)
        Me.lblRandNum6.TabIndex = 12
        '
        'lblRandNum5
        '
        Me.lblRandNum5.AutoSize = True
        Me.lblRandNum5.Location = New System.Drawing.Point(35, 101)
        Me.lblRandNum5.Name = "lblRandNum5"
        Me.lblRandNum5.Size = New System.Drawing.Size(0, 13)
        Me.lblRandNum5.TabIndex = 11
        '
        'lblRandNum4
        '
        Me.lblRandNum4.AutoSize = True
        Me.lblRandNum4.Location = New System.Drawing.Point(140, 68)
        Me.lblRandNum4.Name = "lblRandNum4"
        Me.lblRandNum4.Size = New System.Drawing.Size(0, 13)
        Me.lblRandNum4.TabIndex = 10
        '
        'lblRandNum3
        '
        Me.lblRandNum3.AutoSize = True
        Me.lblRandNum3.Location = New System.Drawing.Point(35, 68)
        Me.lblRandNum3.Name = "lblRandNum3"
        Me.lblRandNum3.Size = New System.Drawing.Size(0, 13)
        Me.lblRandNum3.TabIndex = 9
        '
        'lblRandNum2
        '
        Me.lblRandNum2.AutoSize = True
        Me.lblRandNum2.Location = New System.Drawing.Point(140, 39)
        Me.lblRandNum2.Name = "lblRandNum2"
        Me.lblRandNum2.Size = New System.Drawing.Size(0, 13)
        Me.lblRandNum2.TabIndex = 8
        '
        'lblRandNum1
        '
        Me.lblRandNum1.AutoSize = True
        Me.lblRandNum1.Location = New System.Drawing.Point(35, 39)
        Me.lblRandNum1.Name = "lblRandNum1"
        Me.lblRandNum1.Size = New System.Drawing.Size(0, 13)
        Me.lblRandNum1.TabIndex = 7
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(228, 191)
        Me.Controls.Add(Me.btnRandomNumbers)
        Me.Controls.Add(Me.lblRandNum6)
        Me.Controls.Add(Me.lblRandNum5)
        Me.Controls.Add(Me.lblRandNum4)
        Me.Controls.Add(Me.lblRandNum3)
        Me.Controls.Add(Me.lblRandNum2)
        Me.Controls.Add(Me.lblRandNum1)
        Me.Name = "Form1"
        Me.Text = "Random Numbers"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnRandomNumbers As System.Windows.Forms.Button
    Friend WithEvents lblRandNum6 As System.Windows.Forms.Label
    Friend WithEvents lblRandNum5 As System.Windows.Forms.Label
    Friend WithEvents lblRandNum4 As System.Windows.Forms.Label
    Friend WithEvents lblRandNum3 As System.Windows.Forms.Label
    Friend WithEvents lblRandNum2 As System.Windows.Forms.Label
    Friend WithEvents lblRandNum1 As System.Windows.Forms.Label

End Class
