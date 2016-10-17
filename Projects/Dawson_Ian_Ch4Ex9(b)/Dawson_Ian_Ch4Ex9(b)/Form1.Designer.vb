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
        Me.lbluserid = New System.Windows.Forms.Label()
        Me.lblpassword = New System.Windows.Forms.Label()
        Me.txtuserid = New System.Windows.Forms.TextBox()
        Me.txtpassword = New System.Windows.Forms.TextBox()
        Me.btnOK = New System.Windows.Forms.Button()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lblenter
        '
        Me.lblenter.AutoSize = True
        Me.lblenter.Location = New System.Drawing.Point(32, 39)
        Me.lblenter.Name = "lblenter"
        Me.lblenter.Size = New System.Drawing.Size(271, 13)
        Me.lblenter.TabIndex = 0
        Me.lblenter.Text = "Enter a user ID and password to log on to the computer:"
        '
        'lbluserid
        '
        Me.lbluserid.AutoSize = True
        Me.lbluserid.Location = New System.Drawing.Point(65, 80)
        Me.lbluserid.Name = "lbluserid"
        Me.lbluserid.Size = New System.Drawing.Size(46, 13)
        Me.lbluserid.TabIndex = 1
        Me.lbluserid.Text = "User ID:"
        '
        'lblpassword
        '
        Me.lblpassword.AutoSize = True
        Me.lblpassword.Location = New System.Drawing.Point(65, 128)
        Me.lblpassword.Name = "lblpassword"
        Me.lblpassword.Size = New System.Drawing.Size(56, 13)
        Me.lblpassword.TabIndex = 2
        Me.lblpassword.Text = "Password:"
        '
        'txtuserid
        '
        Me.txtuserid.Location = New System.Drawing.Point(127, 77)
        Me.txtuserid.Name = "txtuserid"
        Me.txtuserid.Size = New System.Drawing.Size(124, 20)
        Me.txtuserid.TabIndex = 3
        '
        'txtpassword
        '
        Me.txtpassword.DataBindings.Add(New System.Windows.Forms.Binding("PasswordChar", Global.WindowsApplication1.My.MySettings.Default, "Asterick", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.txtpassword.Location = New System.Drawing.Point(127, 125)
        Me.txtpassword.Name = "txtpassword"
        Me.txtpassword.PasswordChar = Global.WindowsApplication1.My.MySettings.Default.Asterick
        Me.txtpassword.Size = New System.Drawing.Size(124, 20)
        Me.txtpassword.TabIndex = 4
        '
        'btnOK
        '
        Me.btnOK.Location = New System.Drawing.Point(339, 75)
        Me.btnOK.Name = "btnOK"
        Me.btnOK.Size = New System.Drawing.Size(75, 23)
        Me.btnOK.TabIndex = 5
        Me.btnOK.Text = "OK"
        Me.btnOK.UseVisualStyleBackColor = True
        '
        'btnCancel
        '
        Me.btnCancel.Location = New System.Drawing.Point(339, 123)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(75, 23)
        Me.btnCancel.TabIndex = 6
        Me.btnCancel.Text = "Cancel"
        Me.btnCancel.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(493, 186)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.btnOK)
        Me.Controls.Add(Me.txtpassword)
        Me.Controls.Add(Me.txtuserid)
        Me.Controls.Add(Me.lblpassword)
        Me.Controls.Add(Me.lbluserid)
        Me.Controls.Add(Me.lblenter)
        Me.Name = "Form1"
        Me.Text = "Welcome"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblenter As System.Windows.Forms.Label
    Friend WithEvents lbluserid As System.Windows.Forms.Label
    Friend WithEvents lblpassword As System.Windows.Forms.Label
    Friend WithEvents txtuserid As System.Windows.Forms.TextBox
    Friend WithEvents txtpassword As System.Windows.Forms.TextBox
    Friend WithEvents btnOK As System.Windows.Forms.Button
    Friend WithEvents btnCancel As System.Windows.Forms.Button

End Class
