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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtNumerator = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtDenominator = New System.Windows.Forms.TextBox()
        Me.btnReduce = New System.Windows.Forms.Button()
        Me.lblReduced = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(13, 23)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(85, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Enter numerator:"
        '
        'txtNumerator
        '
        Me.txtNumerator.Location = New System.Drawing.Point(104, 20)
        Me.txtNumerator.Name = "txtNumerator"
        Me.txtNumerator.Size = New System.Drawing.Size(54, 20)
        Me.txtNumerator.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(13, 60)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(96, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Enter denominator:"
        '
        'txtDenominator
        '
        Me.txtDenominator.Location = New System.Drawing.Point(115, 57)
        Me.txtDenominator.Name = "txtDenominator"
        Me.txtDenominator.Size = New System.Drawing.Size(57, 20)
        Me.txtDenominator.TabIndex = 3
        '
        'btnReduce
        '
        Me.btnReduce.Location = New System.Drawing.Point(26, 100)
        Me.btnReduce.Name = "btnReduce"
        Me.btnReduce.Size = New System.Drawing.Size(75, 23)
        Me.btnReduce.TabIndex = 4
        Me.btnReduce.Text = "Reduce"
        Me.btnReduce.UseVisualStyleBackColor = True
        '
        'lblReduced
        '
        Me.lblReduced.AutoSize = True
        Me.lblReduced.Location = New System.Drawing.Point(133, 105)
        Me.lblReduced.Name = "lblReduced"
        Me.lblReduced.Size = New System.Drawing.Size(0, 13)
        Me.lblReduced.TabIndex = 5
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(276, 140)
        Me.Controls.Add(Me.lblReduced)
        Me.Controls.Add(Me.btnReduce)
        Me.Controls.Add(Me.txtDenominator)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtNumerator)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form1"
        Me.Text = "Reduce Fraction"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtNumerator As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtDenominator As System.Windows.Forms.TextBox
    Friend WithEvents btnReduce As System.Windows.Forms.Button
    Friend WithEvents lblReduced As System.Windows.Forms.Label

End Class
