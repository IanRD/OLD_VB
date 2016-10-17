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
        Me.lbltext = New System.Windows.Forms.Label()
        Me.txtword = New System.Windows.Forms.TextBox()
        Me.lblfirst = New System.Windows.Forms.Label()
        Me.lblmid = New System.Windows.Forms.Label()
        Me.lbllast = New System.Windows.Forms.Label()
        Me.btndata = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lbltext
        '
        Me.lbltext.AutoSize = True
        Me.lbltext.Location = New System.Drawing.Point(36, 44)
        Me.lbltext.Name = "lbltext"
        Me.lbltext.Size = New System.Drawing.Size(59, 13)
        Me.lbltext.TabIndex = 0
        Me.lbltext.Text = "Enter Text:"
        '
        'txtword
        '
        Me.txtword.Location = New System.Drawing.Point(101, 41)
        Me.txtword.Name = "txtword"
        Me.txtword.Size = New System.Drawing.Size(100, 20)
        Me.txtword.TabIndex = 1
        '
        'lblfirst
        '
        Me.lblfirst.AutoSize = True
        Me.lblfirst.Location = New System.Drawing.Point(39, 105)
        Me.lblfirst.Name = "lblfirst"
        Me.lblfirst.Size = New System.Drawing.Size(55, 13)
        Me.lblfirst.TabIndex = 2
        Me.lblfirst.Text = "First letter:"
        '
        'lblmid
        '
        Me.lblmid.AutoSize = True
        Me.lblmid.Location = New System.Drawing.Point(39, 143)
        Me.lblmid.Name = "lblmid"
        Me.lblmid.Size = New System.Drawing.Size(67, 13)
        Me.lblmid.TabIndex = 3
        Me.lblmid.Text = "Middle letter:"
        '
        'lbllast
        '
        Me.lbllast.AutoSize = True
        Me.lbllast.Location = New System.Drawing.Point(39, 175)
        Me.lbllast.Name = "lbllast"
        Me.lbllast.Size = New System.Drawing.Size(56, 13)
        Me.lbllast.TabIndex = 4
        Me.lbllast.Text = "Last letter:"
        '
        'btndata
        '
        Me.btndata.Location = New System.Drawing.Point(195, 165)
        Me.btndata.Name = "btndata"
        Me.btndata.Size = New System.Drawing.Size(75, 23)
        Me.btndata.TabIndex = 5
        Me.btndata.Text = "Display Data"
        Me.btndata.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(292, 213)
        Me.Controls.Add(Me.btndata)
        Me.Controls.Add(Me.lbllast)
        Me.Controls.Add(Me.lblmid)
        Me.Controls.Add(Me.lblfirst)
        Me.Controls.Add(Me.txtword)
        Me.Controls.Add(Me.lbltext)
        Me.Name = "Form1"
        Me.Text = "String Test"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lbltext As System.Windows.Forms.Label
    Friend WithEvents txtword As System.Windows.Forms.TextBox
    Friend WithEvents lblfirst As System.Windows.Forms.Label
    Friend WithEvents lblmid As System.Windows.Forms.Label
    Friend WithEvents lbllast As System.Windows.Forms.Label
    Friend WithEvents btndata As System.Windows.Forms.Button

End Class
