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
        Me.lblmessage = New System.Windows.Forms.Label()
        Me.txtplayerguess = New System.Windows.Forms.TextBox()
        Me.lblprompt = New System.Windows.Forms.Label()
        Me.btncheckguess = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lblmessage
        '
        Me.lblmessage.AutoSize = True
        Me.lblmessage.Location = New System.Drawing.Point(76, 72)
        Me.lblmessage.Name = "lblmessage"
        Me.lblmessage.Size = New System.Drawing.Size(0, 13)
        Me.lblmessage.TabIndex = 11
        '
        'txtplayerguess
        '
        Me.txtplayerguess.Location = New System.Drawing.Point(193, 29)
        Me.txtplayerguess.Name = "txtplayerguess"
        Me.txtplayerguess.Size = New System.Drawing.Size(56, 20)
        Me.txtplayerguess.TabIndex = 10
        '
        'lblprompt
        '
        Me.lblprompt.AutoSize = True
        Me.lblprompt.Location = New System.Drawing.Point(23, 32)
        Me.lblprompt.Name = "lblprompt"
        Me.lblprompt.Size = New System.Drawing.Size(164, 13)
        Me.lblprompt.TabIndex = 9
        Me.lblprompt.Text = "Enter a guess between 1 and 50:"
        '
        'btncheckguess
        '
        Me.btncheckguess.Location = New System.Drawing.Point(79, 101)
        Me.btncheckguess.Name = "btncheckguess"
        Me.btncheckguess.Size = New System.Drawing.Size(118, 23)
        Me.btncheckguess.TabIndex = 8
        Me.btncheckguess.Text = "Check Guess"
        Me.btncheckguess.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(278, 153)
        Me.Controls.Add(Me.lblmessage)
        Me.Controls.Add(Me.txtplayerguess)
        Me.Controls.Add(Me.lblprompt)
        Me.Controls.Add(Me.btncheckguess)
        Me.Name = "Form1"
        Me.Text = "Guessing Game"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblmessage As System.Windows.Forms.Label
    Friend WithEvents txtplayerguess As System.Windows.Forms.TextBox
    Friend WithEvents lblprompt As System.Windows.Forms.Label
    Friend WithEvents btncheckguess As System.Windows.Forms.Button

End Class
