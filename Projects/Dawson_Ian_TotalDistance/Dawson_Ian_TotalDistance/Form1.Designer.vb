<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class TotalDistance
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
        Me.txtlength1 = New System.Windows.Forms.TextBox()
        Me.txtlength2 = New System.Windows.Forms.TextBox()
        Me.txtlength3 = New System.Windows.Forms.TextBox()
        Me.lbldistance = New System.Windows.Forms.Label()
        Me.btndistance = New System.Windows.Forms.Button()
        Me.lbldistance2 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 24)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(306, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Please enter the lengths for each of the 3 segments in the race:"
        '
        'txtlength1
        '
        Me.txtlength1.Location = New System.Drawing.Point(15, 74)
        Me.txtlength1.Name = "txtlength1"
        Me.txtlength1.Size = New System.Drawing.Size(67, 20)
        Me.txtlength1.TabIndex = 1
        '
        'txtlength2
        '
        Me.txtlength2.Location = New System.Drawing.Point(135, 74)
        Me.txtlength2.Name = "txtlength2"
        Me.txtlength2.Size = New System.Drawing.Size(69, 20)
        Me.txtlength2.TabIndex = 2
        '
        'txtlength3
        '
        Me.txtlength3.Location = New System.Drawing.Point(252, 74)
        Me.txtlength3.Name = "txtlength3"
        Me.txtlength3.Size = New System.Drawing.Size(71, 20)
        Me.txtlength3.TabIndex = 3
        '
        'lbldistance
        '
        Me.lbldistance.AutoSize = True
        Me.lbldistance.Location = New System.Drawing.Point(12, 142)
        Me.lbldistance.Name = "lbldistance"
        Me.lbldistance.Size = New System.Drawing.Size(58, 13)
        Me.lbldistance.TabIndex = 4
        Me.lbldistance.Text = "Distance ="
        '
        'btndistance
        '
        Me.btndistance.Location = New System.Drawing.Point(218, 131)
        Me.btndistance.Name = "btndistance"
        Me.btndistance.Size = New System.Drawing.Size(105, 34)
        Me.btndistance.TabIndex = 5
        Me.btndistance.Text = "Distance"
        Me.btndistance.UseVisualStyleBackColor = True
        '
        'lbldistance2
        '
        Me.lbldistance2.AutoSize = True
        Me.lbldistance2.Location = New System.Drawing.Point(76, 142)
        Me.lbldistance2.Name = "lbldistance2"
        Me.lbldistance2.Size = New System.Drawing.Size(0, 13)
        Me.lbldistance2.TabIndex = 6
        '
        'TotalDistance
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(339, 183)
        Me.Controls.Add(Me.lbldistance2)
        Me.Controls.Add(Me.btndistance)
        Me.Controls.Add(Me.lbldistance)
        Me.Controls.Add(Me.txtlength3)
        Me.Controls.Add(Me.txtlength2)
        Me.Controls.Add(Me.txtlength1)
        Me.Controls.Add(Me.Label1)
        Me.Name = "TotalDistance"
        Me.Text = "Total Distance"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtlength1 As System.Windows.Forms.TextBox
    Friend WithEvents txtlength2 As System.Windows.Forms.TextBox
    Friend WithEvents txtlength3 As System.Windows.Forms.TextBox
    Friend WithEvents lbldistance As System.Windows.Forms.Label
    Friend WithEvents btndistance As System.Windows.Forms.Button
    Friend WithEvents lbldistance2 As System.Windows.Forms.Label

End Class
