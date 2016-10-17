<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SkyhookInternational
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
        Me.lblnum = New System.Windows.Forms.Label()
        Me.txt26 = New System.Windows.Forms.TextBox()
        Me.btnship = New System.Windows.Forms.Button()
        Me.lbl8 = New System.Windows.Forms.Label()
        Me.lbl2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'lblnum
        '
        Me.lblnum.AutoSize = True
        Me.lblnum.Location = New System.Drawing.Point(22, 61)
        Me.lblnum.Name = "lblnum"
        Me.lblnum.Size = New System.Drawing.Size(148, 13)
        Me.lblnum.TabIndex = 0
        Me.lblnum.Text = "Number of Skyhooks ordered:"
        '
        'txt26
        '
        Me.txt26.Location = New System.Drawing.Point(176, 58)
        Me.txt26.Name = "txt26"
        Me.txt26.Size = New System.Drawing.Size(59, 20)
        Me.txt26.TabIndex = 1
        '
        'btnship
        '
        Me.btnship.Location = New System.Drawing.Point(37, 99)
        Me.btnship.Name = "btnship"
        Me.btnship.Size = New System.Drawing.Size(75, 23)
        Me.btnship.TabIndex = 2
        Me.btnship.Text = "Ship"
        Me.btnship.UseVisualStyleBackColor = True
        '
        'lbl8
        '
        Me.lbl8.AutoSize = True
        Me.lbl8.Location = New System.Drawing.Point(72, 137)
        Me.lbl8.Name = "lbl8"
        Me.lbl8.Size = New System.Drawing.Size(36, 13)
        Me.lbl8.TabIndex = 3
        Me.lbl8.Text = "Boxes"
        '
        'lbl2
        '
        Me.lbl2.AutoSize = True
        Me.lbl2.Location = New System.Drawing.Point(72, 162)
        Me.lbl2.Name = "lbl2"
        Me.lbl2.Size = New System.Drawing.Size(57, 13)
        Me.lbl2.TabIndex = 4
        Me.lbl2.Text = "Envelopes"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(55, 137)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(0, 13)
        Me.Label1.TabIndex = 5
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(55, 162)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(0, 13)
        Me.Label2.TabIndex = 6
        '
        'SkyhookInternational
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(292, 203)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lbl2)
        Me.Controls.Add(Me.lbl8)
        Me.Controls.Add(Me.btnship)
        Me.Controls.Add(Me.txt26)
        Me.Controls.Add(Me.lblnum)
        Me.Name = "SkyhookInternational"
        Me.Text = "Skyhook Internatioal"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblnum As System.Windows.Forms.Label
    Friend WithEvents txt26 As System.Windows.Forms.TextBox
    Friend WithEvents btnship As System.Windows.Forms.Button
    Friend WithEvents lbl8 As System.Windows.Forms.Label
    Friend WithEvents lbl2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label

End Class
