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
        Me.lblGreeting = New System.Windows.Forms.Label()
        Me.gprLanguage = New System.Windows.Forms.GroupBox()
        Me.radFrench = New System.Windows.Forms.RadioButton()
        Me.radSpanish = New System.Windows.Forms.RadioButton()
        Me.radEnglish = New System.Windows.Forms.RadioButton()
        Me.gprLanguage.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblGreeting
        '
        Me.lblGreeting.AutoSize = True
        Me.lblGreeting.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblGreeting.Location = New System.Drawing.Point(31, 47)
        Me.lblGreeting.Name = "lblGreeting"
        Me.lblGreeting.Size = New System.Drawing.Size(182, 31)
        Me.lblGreeting.TabIndex = 0
        Me.lblGreeting.Text = "Hello, World!"
        Me.lblGreeting.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'gprLanguage
        '
        Me.gprLanguage.Controls.Add(Me.radFrench)
        Me.gprLanguage.Controls.Add(Me.radSpanish)
        Me.gprLanguage.Controls.Add(Me.radEnglish)
        Me.gprLanguage.Location = New System.Drawing.Point(31, 125)
        Me.gprLanguage.Name = "gprLanguage"
        Me.gprLanguage.Size = New System.Drawing.Size(227, 100)
        Me.gprLanguage.TabIndex = 1
        Me.gprLanguage.TabStop = False
        Me.gprLanguage.Text = "Select a language"
        '
        'radFrench
        '
        Me.radFrench.AutoSize = True
        Me.radFrench.Location = New System.Drawing.Point(6, 67)
        Me.radFrench.Name = "radFrench"
        Me.radFrench.Size = New System.Drawing.Size(58, 17)
        Me.radFrench.TabIndex = 2
        Me.radFrench.TabStop = True
        Me.radFrench.Text = "French"
        Me.radFrench.UseVisualStyleBackColor = True
        '
        'radSpanish
        '
        Me.radSpanish.AutoSize = True
        Me.radSpanish.Location = New System.Drawing.Point(6, 43)
        Me.radSpanish.Name = "radSpanish"
        Me.radSpanish.Size = New System.Drawing.Size(63, 17)
        Me.radSpanish.TabIndex = 1
        Me.radSpanish.TabStop = True
        Me.radSpanish.Text = "Spanish"
        Me.radSpanish.UseVisualStyleBackColor = True
        '
        'radEnglish
        '
        Me.radEnglish.AutoSize = True
        Me.radEnglish.Location = New System.Drawing.Point(6, 19)
        Me.radEnglish.Name = "radEnglish"
        Me.radEnglish.Size = New System.Drawing.Size(59, 17)
        Me.radEnglish.TabIndex = 0
        Me.radEnglish.TabStop = True
        Me.radEnglish.Text = "English"
        Me.radEnglish.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(292, 266)
        Me.Controls.Add(Me.gprLanguage)
        Me.Controls.Add(Me.lblGreeting)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.gprLanguage.ResumeLayout(False)
        Me.gprLanguage.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblGreeting As System.Windows.Forms.Label
    Friend WithEvents gprLanguage As System.Windows.Forms.GroupBox
    Friend WithEvents radFrench As System.Windows.Forms.RadioButton
    Friend WithEvents radSpanish As System.Windows.Forms.RadioButton
    Friend WithEvents radEnglish As System.Windows.Forms.RadioButton

End Class
