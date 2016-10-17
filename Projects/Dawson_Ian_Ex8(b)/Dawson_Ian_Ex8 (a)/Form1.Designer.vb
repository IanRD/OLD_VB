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
        Me.lblenter = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtnumb = New System.Windows.Forms.TextBox()
        Me.lbldigit1 = New System.Windows.Forms.Label()
        Me.lbldigit2 = New System.Windows.Forms.Label()
        Me.btndigits = New System.Windows.Forms.Button()
        Me.ProgramToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DigitsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblenter
        '
        Me.lblenter.AutoSize = True
        Me.lblenter.Location = New System.Drawing.Point(12, 20)
        Me.lblenter.Name = "lblenter"
        Me.lblenter.Size = New System.Drawing.Size(124, 13)
        Me.lblenter.TabIndex = 0
        Me.lblenter.Text = "Enter a two-digit number:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(54, 59)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(80, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "The first digit is:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(35, 88)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(99, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "The second digit is:"
        '
        'txtnumb
        '
        Me.txtnumb.Location = New System.Drawing.Point(142, 17)
        Me.txtnumb.Name = "txtnumb"
        Me.txtnumb.Size = New System.Drawing.Size(51, 20)
        Me.txtnumb.TabIndex = 3
        '
        'lbldigit1
        '
        Me.lbldigit1.AutoSize = True
        Me.lbldigit1.Location = New System.Drawing.Point(142, 59)
        Me.lbldigit1.Name = "lbldigit1"
        Me.lbldigit1.Size = New System.Drawing.Size(0, 13)
        Me.lbldigit1.TabIndex = 4
        '
        'lbldigit2
        '
        Me.lbldigit2.AutoSize = True
        Me.lbldigit2.Location = New System.Drawing.Point(139, 88)
        Me.lbldigit2.Name = "lbldigit2"
        Me.lbldigit2.Size = New System.Drawing.Size(0, 13)
        Me.lbldigit2.TabIndex = 5
        '
        'btndigits
        '
        Me.btndigits.Location = New System.Drawing.Point(89, 115)
        Me.btndigits.Name = "btndigits"
        Me.btndigits.Size = New System.Drawing.Size(75, 23)
        Me.btndigits.TabIndex = 6
        Me.btndigits.Text = "Digits"
        Me.btndigits.UseVisualStyleBackColor = True
        '
        'ProgramToolStripMenuItem
        '
        Me.ProgramToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.DigitsToolStripMenuItem})
        Me.ProgramToolStripMenuItem.Name = "ProgramToolStripMenuItem"
        Me.ProgramToolStripMenuItem.Size = New System.Drawing.Size(59, 20)
        Me.ProgramToolStripMenuItem.Text = "Program"
        '
        'DigitsToolStripMenuItem
        '
        Me.DigitsToolStripMenuItem.Name = "DigitsToolStripMenuItem"
        Me.DigitsToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.DigitsToolStripMenuItem.Text = "Digits"
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ProgramToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(258, 24)
        Me.MenuStrip1.TabIndex = 7
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(258, 141)
        Me.Controls.Add(Me.btndigits)
        Me.Controls.Add(Me.lbldigit2)
        Me.Controls.Add(Me.lbldigit1)
        Me.Controls.Add(Me.txtnumb)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lblenter)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "Form1"
        Me.Text = "Digits of a Number"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblenter As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtnumb As System.Windows.Forms.TextBox
    Friend WithEvents lbldigit1 As System.Windows.Forms.Label
    Friend WithEvents lbldigit2 As System.Windows.Forms.Label
    Friend WithEvents btndigits As System.Windows.Forms.Button
    Friend WithEvents ProgramToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents DigitsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip

End Class
