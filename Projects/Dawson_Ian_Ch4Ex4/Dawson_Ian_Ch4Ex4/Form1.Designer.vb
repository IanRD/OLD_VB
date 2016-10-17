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
        Me.lblpackage = New System.Windows.Forms.Label()
        Me.lblweight = New System.Windows.Forms.Label()
        Me.lbllength = New System.Windows.Forms.Label()
        Me.lblwidth = New System.Windows.Forms.Label()
        Me.lblheight = New System.Windows.Forms.Label()
        Me.txtweight = New System.Windows.Forms.TextBox()
        Me.txtlength = New System.Windows.Forms.TextBox()
        Me.txtwidth = New System.Windows.Forms.TextBox()
        Me.txtheight = New System.Windows.Forms.TextBox()
        Me.lblrejected = New System.Windows.Forms.Label()
        Me.btnpackage = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lblpackage
        '
        Me.lblpackage.AutoSize = True
        Me.lblpackage.Location = New System.Drawing.Point(28, 35)
        Me.lblpackage.Name = "lblpackage"
        Me.lblpackage.Size = New System.Drawing.Size(129, 13)
        Me.lblpackage.TabIndex = 0
        Me.lblpackage.Text = "Enter the package's data:"
        '
        'lblweight
        '
        Me.lblweight.AutoSize = True
        Me.lblweight.Location = New System.Drawing.Point(47, 77)
        Me.lblweight.Name = "lblweight"
        Me.lblweight.Size = New System.Drawing.Size(99, 13)
        Me.lblweight.TabIndex = 1
        Me.lblweight.Text = "weight in kilograms:"
        '
        'lbllength
        '
        Me.lbllength.AutoSize = True
        Me.lbllength.Location = New System.Drawing.Point(47, 103)
        Me.lbllength.Name = "lbllength"
        Me.lbllength.Size = New System.Drawing.Size(107, 13)
        Me.lbllength.TabIndex = 2
        Me.lbllength.Text = "length in centimeters:"
        '
        'lblwidth
        '
        Me.lblwidth.AutoSize = True
        Me.lblwidth.Location = New System.Drawing.Point(47, 130)
        Me.lblwidth.Name = "lblwidth"
        Me.lblwidth.Size = New System.Drawing.Size(103, 13)
        Me.lblwidth.TabIndex = 3
        Me.lblwidth.Text = "width in centimeters:"
        '
        'lblheight
        '
        Me.lblheight.AutoSize = True
        Me.lblheight.Location = New System.Drawing.Point(47, 158)
        Me.lblheight.Name = "lblheight"
        Me.lblheight.Size = New System.Drawing.Size(107, 13)
        Me.lblheight.TabIndex = 4
        Me.lblheight.Text = "height in centimeters:"
        '
        'txtweight
        '
        Me.txtweight.Location = New System.Drawing.Point(169, 74)
        Me.txtweight.Name = "txtweight"
        Me.txtweight.Size = New System.Drawing.Size(41, 20)
        Me.txtweight.TabIndex = 5
        '
        'txtlength
        '
        Me.txtlength.Location = New System.Drawing.Point(169, 100)
        Me.txtlength.Name = "txtlength"
        Me.txtlength.Size = New System.Drawing.Size(41, 20)
        Me.txtlength.TabIndex = 6
        '
        'txtwidth
        '
        Me.txtwidth.Location = New System.Drawing.Point(169, 127)
        Me.txtwidth.Name = "txtwidth"
        Me.txtwidth.Size = New System.Drawing.Size(41, 20)
        Me.txtwidth.TabIndex = 7
        '
        'txtheight
        '
        Me.txtheight.Location = New System.Drawing.Point(169, 153)
        Me.txtheight.Name = "txtheight"
        Me.txtheight.Size = New System.Drawing.Size(41, 20)
        Me.txtheight.TabIndex = 8
        '
        'lblrejected
        '
        Me.lblrejected.AutoSize = True
        Me.lblrejected.Location = New System.Drawing.Point(31, 229)
        Me.lblrejected.Name = "lblrejected"
        Me.lblrejected.Size = New System.Drawing.Size(0, 13)
        Me.lblrejected.TabIndex = 9
        '
        'btnpackage
        '
        Me.btnpackage.Location = New System.Drawing.Point(156, 247)
        Me.btnpackage.Name = "btnpackage"
        Me.btnpackage.Size = New System.Drawing.Size(75, 23)
        Me.btnpackage.TabIndex = 10
        Me.btnpackage.Text = "Check Package"
        Me.btnpackage.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(255, 295)
        Me.Controls.Add(Me.btnpackage)
        Me.Controls.Add(Me.lblrejected)
        Me.Controls.Add(Me.txtheight)
        Me.Controls.Add(Me.txtwidth)
        Me.Controls.Add(Me.txtlength)
        Me.Controls.Add(Me.txtweight)
        Me.Controls.Add(Me.lblheight)
        Me.Controls.Add(Me.lblwidth)
        Me.Controls.Add(Me.lbllength)
        Me.Controls.Add(Me.lblweight)
        Me.Controls.Add(Me.lblpackage)
        Me.Name = "Form1"
        Me.Text = "Package Check"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblpackage As System.Windows.Forms.Label
    Friend WithEvents lblweight As System.Windows.Forms.Label
    Friend WithEvents lbllength As System.Windows.Forms.Label
    Friend WithEvents lblwidth As System.Windows.Forms.Label
    Friend WithEvents lblheight As System.Windows.Forms.Label
    Friend WithEvents txtweight As System.Windows.Forms.TextBox
    Friend WithEvents txtlength As System.Windows.Forms.TextBox
    Friend WithEvents txtwidth As System.Windows.Forms.TextBox
    Friend WithEvents txtheight As System.Windows.Forms.TextBox
    Friend WithEvents lblrejected As System.Windows.Forms.Label
    Friend WithEvents btnpackage As System.Windows.Forms.Button

End Class
