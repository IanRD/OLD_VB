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
        Me.lblcents = New System.Windows.Forms.Label()
        Me.txtcents = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.lblquarters = New System.Windows.Forms.Label()
        Me.lbldimes = New System.Windows.Forms.Label()
        Me.lblnickels = New System.Windows.Forms.Label()
        Me.lblpennies = New System.Windows.Forms.Label()
        Me.btncoins = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lblcents
        '
        Me.lblcents.AutoSize = True
        Me.lblcents.Location = New System.Drawing.Point(3, 20)
        Me.lblcents.Name = "lblcents"
        Me.lblcents.Size = New System.Drawing.Size(132, 13)
        Me.lblcents.TabIndex = 0
        Me.lblcents.Text = "Enter the change in cents:"
        '
        'txtcents
        '
        Me.txtcents.Location = New System.Drawing.Point(147, 17)
        Me.txtcents.Name = "txtcents"
        Me.txtcents.Size = New System.Drawing.Size(44, 20)
        Me.txtcents.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(13, 46)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(50, 13)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Quarters:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(13, 72)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(39, 13)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Dimes:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(13, 99)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(45, 13)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Nickels:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(13, 126)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(48, 13)
        Me.Label4.TabIndex = 5
        Me.Label4.Text = "Pennies:"
        '
        'lblquarters
        '
        Me.lblquarters.AutoSize = True
        Me.lblquarters.Location = New System.Drawing.Point(69, 46)
        Me.lblquarters.Name = "lblquarters"
        Me.lblquarters.Size = New System.Drawing.Size(0, 13)
        Me.lblquarters.TabIndex = 6
        '
        'lbldimes
        '
        Me.lbldimes.AutoSize = True
        Me.lbldimes.Location = New System.Drawing.Point(69, 72)
        Me.lbldimes.Name = "lbldimes"
        Me.lbldimes.Size = New System.Drawing.Size(0, 13)
        Me.lbldimes.TabIndex = 7
        '
        'lblnickels
        '
        Me.lblnickels.AutoSize = True
        Me.lblnickels.Location = New System.Drawing.Point(69, 99)
        Me.lblnickels.Name = "lblnickels"
        Me.lblnickels.Size = New System.Drawing.Size(0, 13)
        Me.lblnickels.TabIndex = 8
        '
        'lblpennies
        '
        Me.lblpennies.AutoSize = True
        Me.lblpennies.Location = New System.Drawing.Point(69, 126)
        Me.lblpennies.Name = "lblpennies"
        Me.lblpennies.Size = New System.Drawing.Size(0, 13)
        Me.lblpennies.TabIndex = 9
        '
        'btncoins
        '
        Me.btncoins.Location = New System.Drawing.Point(130, 126)
        Me.btncoins.Name = "btncoins"
        Me.btncoins.Size = New System.Drawing.Size(61, 23)
        Me.btncoins.TabIndex = 10
        Me.btncoins.Text = "Coins"
        Me.btncoins.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(203, 152)
        Me.Controls.Add(Me.btncoins)
        Me.Controls.Add(Me.lblpennies)
        Me.Controls.Add(Me.lblnickels)
        Me.Controls.Add(Me.lbldimes)
        Me.Controls.Add(Me.lblquarters)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtcents)
        Me.Controls.Add(Me.lblcents)
        Me.Name = "Form1"
        Me.Text = "Change"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblcents As System.Windows.Forms.Label
    Friend WithEvents txtcents As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents lblquarters As System.Windows.Forms.Label
    Friend WithEvents lbldimes As System.Windows.Forms.Label
    Friend WithEvents lblnickels As System.Windows.Forms.Label
    Friend WithEvents lblpennies As System.Windows.Forms.Label
    Friend WithEvents btncoins As System.Windows.Forms.Button

End Class
