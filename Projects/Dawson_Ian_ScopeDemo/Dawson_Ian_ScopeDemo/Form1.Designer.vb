<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ScopeDemo
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
        Me.lblxis = New System.Windows.Forms.Label()
        Me.lblanswer = New System.Windows.Forms.Label()
        Me.btnProc1 = New System.Windows.Forms.Button()
        Me.btnProc2 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lblxis
        '
        Me.lblxis.AutoSize = True
        Me.lblxis.Location = New System.Drawing.Point(76, 51)
        Me.lblxis.Name = "lblxis"
        Me.lblxis.Size = New System.Drawing.Size(24, 13)
        Me.lblxis.TabIndex = 0
        Me.lblxis.Text = "X is"
        '
        'lblanswer
        '
        Me.lblanswer.AutoSize = True
        Me.lblanswer.Location = New System.Drawing.Point(106, 51)
        Me.lblanswer.Name = "lblanswer"
        Me.lblanswer.Size = New System.Drawing.Size(0, 13)
        Me.lblanswer.TabIndex = 1
        '
        'btnProc1
        '
        Me.btnProc1.Location = New System.Drawing.Point(12, 107)
        Me.btnProc1.Name = "btnProc1"
        Me.btnProc1.Size = New System.Drawing.Size(75, 23)
        Me.btnProc1.TabIndex = 2
        Me.btnProc1.Text = "Procedure 1"
        Me.btnProc1.UseVisualStyleBackColor = True
        '
        'btnProc2
        '
        Me.btnProc2.Location = New System.Drawing.Point(135, 107)
        Me.btnProc2.Name = "btnProc2"
        Me.btnProc2.Size = New System.Drawing.Size(75, 23)
        Me.btnProc2.TabIndex = 3
        Me.btnProc2.Text = "Procedure 2"
        Me.btnProc2.UseVisualStyleBackColor = True
        '
        'ScopeDemo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(222, 155)
        Me.Controls.Add(Me.btnProc2)
        Me.Controls.Add(Me.btnProc1)
        Me.Controls.Add(Me.lblanswer)
        Me.Controls.Add(Me.lblxis)
        Me.Name = "ScopeDemo"
        Me.Text = "Scope Demo"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblxis As System.Windows.Forms.Label
    Friend WithEvents lblanswer As System.Windows.Forms.Label
    Friend WithEvents btnProc1 As System.Windows.Forms.Button
    Friend WithEvents btnProc2 As System.Windows.Forms.Button

End Class
