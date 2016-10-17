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
        Me.btnAddCoins = New System.Windows.Forms.Button()
        Me.lblTotal = New System.Windows.Forms.Label()
        Me.lblMoney = New System.Windows.Forms.Label()
        Me.lblQuarters = New System.Windows.Forms.Label()
        Me.lblDimes = New System.Windows.Forms.Label()
        Me.lblNickels = New System.Windows.Forms.Label()
        Me.lblPennies = New System.Windows.Forms.Label()
        Me.txtQuarters = New System.Windows.Forms.TextBox()
        Me.txtDimes = New System.Windows.Forms.TextBox()
        Me.txtNickels = New System.Windows.Forms.TextBox()
        Me.txtPennies = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'btnAddCoins
        '
        Me.btnAddCoins.Location = New System.Drawing.Point(181, 31)
        Me.btnAddCoins.Name = "btnAddCoins"
        Me.btnAddCoins.Size = New System.Drawing.Size(75, 23)
        Me.btnAddCoins.TabIndex = 0
        Me.btnAddCoins.Text = "Add Coins"
        Me.btnAddCoins.UseVisualStyleBackColor = True
        '
        'lblTotal
        '
        Me.lblTotal.AutoSize = True
        Me.lblTotal.Location = New System.Drawing.Point(187, 116)
        Me.lblTotal.Name = "lblTotal"
        Me.lblTotal.Size = New System.Drawing.Size(43, 13)
        Me.lblTotal.TabIndex = 1
        Me.lblTotal.Text = "Total: $"
        '
        'lblMoney
        '
        Me.lblMoney.AutoSize = True
        Me.lblMoney.Location = New System.Drawing.Point(230, 116)
        Me.lblMoney.Name = "lblMoney"
        Me.lblMoney.Size = New System.Drawing.Size(0, 13)
        Me.lblMoney.TabIndex = 2
        '
        'lblQuarters
        '
        Me.lblQuarters.AutoSize = True
        Me.lblQuarters.Location = New System.Drawing.Point(5, 41)
        Me.lblQuarters.Name = "lblQuarters"
        Me.lblQuarters.Size = New System.Drawing.Size(50, 13)
        Me.lblQuarters.TabIndex = 3
        Me.lblQuarters.Text = "Quarters:"
        '
        'lblDimes
        '
        Me.lblDimes.AutoSize = True
        Me.lblDimes.Location = New System.Drawing.Point(5, 78)
        Me.lblDimes.Name = "lblDimes"
        Me.lblDimes.Size = New System.Drawing.Size(39, 13)
        Me.lblDimes.TabIndex = 4
        Me.lblDimes.Text = "Dimes:"
        '
        'lblNickels
        '
        Me.lblNickels.AutoSize = True
        Me.lblNickels.Location = New System.Drawing.Point(5, 116)
        Me.lblNickels.Name = "lblNickels"
        Me.lblNickels.Size = New System.Drawing.Size(45, 13)
        Me.lblNickels.TabIndex = 5
        Me.lblNickels.Text = "Nickels:"
        '
        'lblPennies
        '
        Me.lblPennies.AutoSize = True
        Me.lblPennies.Location = New System.Drawing.Point(5, 155)
        Me.lblPennies.Name = "lblPennies"
        Me.lblPennies.Size = New System.Drawing.Size(48, 13)
        Me.lblPennies.TabIndex = 6
        Me.lblPennies.Text = "Pennies:"
        '
        'txtQuarters
        '
        Me.txtQuarters.Location = New System.Drawing.Point(56, 38)
        Me.txtQuarters.Name = "txtQuarters"
        Me.txtQuarters.Size = New System.Drawing.Size(41, 20)
        Me.txtQuarters.TabIndex = 7
        '
        'txtDimes
        '
        Me.txtDimes.Location = New System.Drawing.Point(56, 75)
        Me.txtDimes.Name = "txtDimes"
        Me.txtDimes.Size = New System.Drawing.Size(41, 20)
        Me.txtDimes.TabIndex = 8
        '
        'txtNickels
        '
        Me.txtNickels.Location = New System.Drawing.Point(56, 113)
        Me.txtNickels.Name = "txtNickels"
        Me.txtNickels.Size = New System.Drawing.Size(41, 20)
        Me.txtNickels.TabIndex = 9
        '
        'txtPennies
        '
        Me.txtPennies.Location = New System.Drawing.Point(56, 152)
        Me.txtPennies.Name = "txtPennies"
        Me.txtPennies.Size = New System.Drawing.Size(41, 20)
        Me.txtPennies.TabIndex = 10
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(292, 200)
        Me.Controls.Add(Me.txtPennies)
        Me.Controls.Add(Me.txtNickels)
        Me.Controls.Add(Me.txtDimes)
        Me.Controls.Add(Me.txtQuarters)
        Me.Controls.Add(Me.lblPennies)
        Me.Controls.Add(Me.lblNickels)
        Me.Controls.Add(Me.lblDimes)
        Me.Controls.Add(Me.lblQuarters)
        Me.Controls.Add(Me.lblMoney)
        Me.Controls.Add(Me.lblTotal)
        Me.Controls.Add(Me.btnAddCoins)
        Me.Name = "Form1"
        Me.Text = "Add Coins"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnAddCoins As System.Windows.Forms.Button
    Friend WithEvents lblTotal As System.Windows.Forms.Label
    Friend WithEvents lblMoney As System.Windows.Forms.Label
    Friend WithEvents lblQuarters As System.Windows.Forms.Label
    Friend WithEvents lblDimes As System.Windows.Forms.Label
    Friend WithEvents lblNickels As System.Windows.Forms.Label
    Friend WithEvents lblPennies As System.Windows.Forms.Label
    Friend WithEvents txtQuarters As System.Windows.Forms.TextBox
    Friend WithEvents txtDimes As System.Windows.Forms.TextBox
    Friend WithEvents txtNickels As System.Windows.Forms.TextBox
    Friend WithEvents txtPennies As System.Windows.Forms.TextBox

End Class
