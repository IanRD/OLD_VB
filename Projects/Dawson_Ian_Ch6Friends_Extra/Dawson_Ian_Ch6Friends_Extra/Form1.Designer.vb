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
        Me.lblCharacterInfo = New System.Windows.Forms.Label()
        Me.btnGetInfo = New System.Windows.Forms.Button()
        Me.txtCharacterName = New System.Windows.Forms.TextBox()
        Me.lblCharacter = New System.Windows.Forms.Label()
        Me.picGameCharacter = New System.Windows.Forms.PictureBox()
        CType(Me.picGameCharacter, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblCharacterInfo
        '
        Me.lblCharacterInfo.Location = New System.Drawing.Point(226, 41)
        Me.lblCharacterInfo.Name = "lblCharacterInfo"
        Me.lblCharacterInfo.Size = New System.Drawing.Size(146, 170)
        Me.lblCharacterInfo.TabIndex = 10
        '
        'btnGetInfo
        '
        Me.btnGetInfo.Location = New System.Drawing.Point(259, 10)
        Me.btnGetInfo.Name = "btnGetInfo"
        Me.btnGetInfo.Size = New System.Drawing.Size(105, 23)
        Me.btnGetInfo.TabIndex = 9
        Me.btnGetInfo.Text = "Get Info"
        Me.btnGetInfo.UseVisualStyleBackColor = True
        '
        'txtCharacterName
        '
        Me.txtCharacterName.Location = New System.Drawing.Point(142, 12)
        Me.txtCharacterName.Name = "txtCharacterName"
        Me.txtCharacterName.Size = New System.Drawing.Size(100, 20)
        Me.txtCharacterName.TabIndex = 8
        '
        'lblCharacter
        '
        Me.lblCharacter.AutoSize = True
        Me.lblCharacter.Location = New System.Drawing.Point(22, 15)
        Me.lblCharacter.Name = "lblCharacter"
        Me.lblCharacter.Size = New System.Drawing.Size(103, 13)
        Me.lblCharacter.TabIndex = 7
        Me.lblCharacter.Text = "Choose a character:"
        '
        'picGameCharacter
        '
        Me.picGameCharacter.Location = New System.Drawing.Point(0, 41)
        Me.picGameCharacter.Name = "picGameCharacter"
        Me.picGameCharacter.Size = New System.Drawing.Size(199, 180)
        Me.picGameCharacter.TabIndex = 11
        Me.picGameCharacter.TabStop = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(384, 220)
        Me.Controls.Add(Me.picGameCharacter)
        Me.Controls.Add(Me.lblCharacterInfo)
        Me.Controls.Add(Me.btnGetInfo)
        Me.Controls.Add(Me.txtCharacterName)
        Me.Controls.Add(Me.lblCharacter)
        Me.Name = "Form1"
        Me.Text = "Characters"
        CType(Me.picGameCharacter, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents picGameCharacter As System.Windows.Forms.PictureBox
    Friend WithEvents lblCharacterInfo As System.Windows.Forms.Label
    Friend WithEvents btnGetInfo As System.Windows.Forms.Button
    Friend WithEvents txtCharacterName As System.Windows.Forms.TextBox
    Friend WithEvents lblCharacter As System.Windows.Forms.Label

End Class
