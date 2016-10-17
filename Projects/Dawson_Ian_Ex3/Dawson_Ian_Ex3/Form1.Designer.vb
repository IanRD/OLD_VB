<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class BandInformation
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
        Me.grpBand = New System.Windows.Forms.GroupBox()
        Me.radJuliette = New System.Windows.Forms.RadioButton()
        Me.radQueen = New System.Windows.Forms.RadioButton()
        Me.radTheJam = New System.Windows.Forms.RadioButton()
        Me.lblband1 = New System.Windows.Forms.Label()
        Me.lblband2 = New System.Windows.Forms.Label()
        Me.lblband3 = New System.Windows.Forms.Label()
        Me.lblband4 = New System.Windows.Forms.Label()
        Me.grpBand.SuspendLayout()
        Me.SuspendLayout()
        '
        'grpBand
        '
        Me.grpBand.Controls.Add(Me.radJuliette)
        Me.grpBand.Controls.Add(Me.radQueen)
        Me.grpBand.Controls.Add(Me.radTheJam)
        Me.grpBand.Location = New System.Drawing.Point(1, 12)
        Me.grpBand.Name = "grpBand"
        Me.grpBand.Size = New System.Drawing.Size(164, 242)
        Me.grpBand.TabIndex = 0
        Me.grpBand.TabStop = False
        Me.grpBand.Text = "Select a band"
        '
        'radJuliette
        '
        Me.radJuliette.AutoSize = True
        Me.radJuliette.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.radJuliette.Location = New System.Drawing.Point(6, 202)
        Me.radJuliette.Name = "radJuliette"
        Me.radJuliette.Size = New System.Drawing.Size(155, 17)
        Me.radJuliette.TabIndex = 2
        Me.radJuliette.TabStop = True
        Me.radJuliette.Text = "Juliette Lewis and the Licks"
        Me.radJuliette.UseVisualStyleBackColor = True
        '
        'radQueen
        '
        Me.radQueen.AutoSize = True
        Me.radQueen.Location = New System.Drawing.Point(7, 117)
        Me.radQueen.Name = "radQueen"
        Me.radQueen.Size = New System.Drawing.Size(57, 17)
        Me.radQueen.TabIndex = 1
        Me.radQueen.TabStop = True
        Me.radQueen.Text = "Queen"
        Me.radQueen.UseVisualStyleBackColor = True
        '
        'radTheJam
        '
        Me.radTheJam.AutoSize = True
        Me.radTheJam.Location = New System.Drawing.Point(7, 33)
        Me.radTheJam.Name = "radTheJam"
        Me.radTheJam.Size = New System.Drawing.Size(66, 17)
        Me.radTheJam.TabIndex = 0
        Me.radTheJam.TabStop = True
        Me.radTheJam.Text = "The Jam"
        Me.radTheJam.UseVisualStyleBackColor = True
        '
        'lblband1
        '
        Me.lblband1.AutoSize = True
        Me.lblband1.Location = New System.Drawing.Point(174, 45)
        Me.lblband1.Name = "lblband1"
        Me.lblband1.Size = New System.Drawing.Size(0, 13)
        Me.lblband1.TabIndex = 1
        '
        'lblband2
        '
        Me.lblband2.AutoSize = True
        Me.lblband2.Location = New System.Drawing.Point(174, 99)
        Me.lblband2.Name = "lblband2"
        Me.lblband2.Size = New System.Drawing.Size(0, 13)
        Me.lblband2.TabIndex = 2
        '
        'lblband3
        '
        Me.lblband3.AutoSize = True
        Me.lblband3.Location = New System.Drawing.Point(174, 149)
        Me.lblband3.Name = "lblband3"
        Me.lblband3.Size = New System.Drawing.Size(0, 13)
        Me.lblband3.TabIndex = 3
        '
        'lblband4
        '
        Me.lblband4.AutoSize = True
        Me.lblband4.Location = New System.Drawing.Point(174, 202)
        Me.lblband4.Name = "lblband4"
        Me.lblband4.Size = New System.Drawing.Size(0, 13)
        Me.lblband4.TabIndex = 4
        '
        'BandInformation
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(566, 266)
        Me.Controls.Add(Me.lblband4)
        Me.Controls.Add(Me.lblband3)
        Me.Controls.Add(Me.lblband2)
        Me.Controls.Add(Me.lblband1)
        Me.Controls.Add(Me.grpBand)
        Me.Name = "BandInformation"
        Me.Text = "Band Information"
        Me.grpBand.ResumeLayout(False)
        Me.grpBand.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents grpBand As System.Windows.Forms.GroupBox
    Friend WithEvents radJuliette As System.Windows.Forms.RadioButton
    Friend WithEvents radQueen As System.Windows.Forms.RadioButton
    Friend WithEvents radTheJam As System.Windows.Forms.RadioButton
    Friend WithEvents lblband1 As System.Windows.Forms.Label
    Friend WithEvents lblband2 As System.Windows.Forms.Label
    Friend WithEvents lblband3 As System.Windows.Forms.Label
    Friend WithEvents lblband4 As System.Windows.Forms.Label

End Class
