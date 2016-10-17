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
        Me.lstSineCosine = New System.Windows.Forms.ListBox()
        Me.btnDisplayTable = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lstSineCosine
        '
        Me.lstSineCosine.FormattingEnabled = True
        Me.lstSineCosine.Location = New System.Drawing.Point(21, 22)
        Me.lstSineCosine.Name = "lstSineCosine"
        Me.lstSineCosine.Size = New System.Drawing.Size(182, 147)
        Me.lstSineCosine.TabIndex = 0
        '
        'btnDisplayTable
        '
        Me.btnDisplayTable.Location = New System.Drawing.Point(227, 77)
        Me.btnDisplayTable.Name = "btnDisplayTable"
        Me.btnDisplayTable.Size = New System.Drawing.Size(80, 23)
        Me.btnDisplayTable.TabIndex = 1
        Me.btnDisplayTable.Text = "Display Table"
        Me.btnDisplayTable.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(340, 201)
        Me.Controls.Add(Me.btnDisplayTable)
        Me.Controls.Add(Me.lstSineCosine)
        Me.Name = "Form1"
        Me.Text = "Sine Cosine Table"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents lstSineCosine As System.Windows.Forms.ListBox
    Friend WithEvents btnDisplayTable As System.Windows.Forms.Button

End Class
