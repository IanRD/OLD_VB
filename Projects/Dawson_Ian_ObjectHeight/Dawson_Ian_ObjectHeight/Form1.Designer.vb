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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtSeconds = New System.Windows.Forms.TextBox()
        Me.lblis = New System.Windows.Forms.Label()
        Me.lblheight = New System.Windows.Forms.Label()
        Me.btnheight = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 26)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(172, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Enter a time less than 4.5 seconds:"
        '
        'txtSeconds
        '
        Me.txtSeconds.Location = New System.Drawing.Point(187, 23)
        Me.txtSeconds.Name = "txtSeconds"
        Me.txtSeconds.Size = New System.Drawing.Size(46, 20)
        Me.txtSeconds.TabIndex = 1
        '
        'lblis
        '
        Me.lblis.AutoSize = True
        Me.lblis.Location = New System.Drawing.Point(12, 83)
        Me.lblis.Name = "lblis"
        Me.lblis.Size = New System.Drawing.Size(133, 13)
        Me.lblis.TabIndex = 2
        Me.lblis.Text = "The height of the object is:"
        '
        'lblheight
        '
        Me.lblheight.AutoSize = True
        Me.lblheight.Location = New System.Drawing.Point(166, 83)
        Me.lblheight.Name = "lblheight"
        Me.lblheight.Size = New System.Drawing.Size(0, 13)
        Me.lblheight.TabIndex = 3
        '
        'btnheight
        '
        Me.btnheight.Location = New System.Drawing.Point(187, 115)
        Me.btnheight.Name = "btnheight"
        Me.btnheight.Size = New System.Drawing.Size(75, 23)
        Me.btnheight.TabIndex = 4
        Me.btnheight.Text = "Height"
        Me.btnheight.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(292, 150)
        Me.Controls.Add(Me.btnheight)
        Me.Controls.Add(Me.lblheight)
        Me.Controls.Add(Me.lblis)
        Me.Controls.Add(Me.txtSeconds)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form1"
        Me.Text = "Object Height"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtSeconds As System.Windows.Forms.TextBox
    Friend WithEvents lblis As System.Windows.Forms.Label
    Friend WithEvents lblheight As System.Windows.Forms.Label
    Friend WithEvents btnheight As System.Windows.Forms.Button

End Class
