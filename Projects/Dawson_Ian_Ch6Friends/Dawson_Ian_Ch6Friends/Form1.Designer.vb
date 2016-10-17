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
        Me.lblPrompt = New System.Windows.Forms.Label()
        Me.txtFriendName = New System.Windows.Forms.TextBox()
        Me.btnGetInfo = New System.Windows.Forms.Button()
        Me.lblFriendInfo = New System.Windows.Forms.Label()
        Me.picFriendPhoto = New System.Windows.Forms.PictureBox()
        CType(Me.picFriendPhoto, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblPrompt
        '
        Me.lblPrompt.AutoSize = True
        Me.lblPrompt.Location = New System.Drawing.Point(1, 9)
        Me.lblPrompt.Name = "lblPrompt"
        Me.lblPrompt.Size = New System.Drawing.Size(142, 13)
        Me.lblPrompt.TabIndex = 0
        Me.lblPrompt.Text = "Enter the first name of friend:"
        '
        'txtFriendName
        '
        Me.txtFriendName.Location = New System.Drawing.Point(159, 5)
        Me.txtFriendName.Name = "txtFriendName"
        Me.txtFriendName.Size = New System.Drawing.Size(100, 20)
        Me.txtFriendName.TabIndex = 1
        '
        'btnGetInfo
        '
        Me.btnGetInfo.Location = New System.Drawing.Point(280, 3)
        Me.btnGetInfo.Name = "btnGetInfo"
        Me.btnGetInfo.Size = New System.Drawing.Size(105, 23)
        Me.btnGetInfo.TabIndex = 2
        Me.btnGetInfo.Text = "Get Info"
        Me.btnGetInfo.UseVisualStyleBackColor = True
        '
        'lblFriendInfo
        '
        Me.lblFriendInfo.Location = New System.Drawing.Point(227, 43)
        Me.lblFriendInfo.Name = "lblFriendInfo"
        Me.lblFriendInfo.Size = New System.Drawing.Size(146, 157)
        Me.lblFriendInfo.TabIndex = 5
        '
        'picFriendPhoto
        '
        Me.picFriendPhoto.Location = New System.Drawing.Point(3, 31)
        Me.picFriendPhoto.Name = "picFriendPhoto"
        Me.picFriendPhoto.Size = New System.Drawing.Size(197, 180)
        Me.picFriendPhoto.TabIndex = 6
        Me.picFriendPhoto.TabStop = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(397, 212)
        Me.Controls.Add(Me.picFriendPhoto)
        Me.Controls.Add(Me.lblFriendInfo)
        Me.Controls.Add(Me.btnGetInfo)
        Me.Controls.Add(Me.txtFriendName)
        Me.Controls.Add(Me.lblPrompt)
        Me.Name = "Form1"
        Me.Text = "Friends"
        CType(Me.picFriendPhoto, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblPrompt As System.Windows.Forms.Label
    Friend WithEvents txtFriendName As System.Windows.Forms.TextBox
    Friend WithEvents btnGetInfo As System.Windows.Forms.Button
    Friend WithEvents lblFriendInfo As System.Windows.Forms.Label
    Friend WithEvents picFriendPhoto As System.Windows.Forms.PictureBox

End Class
