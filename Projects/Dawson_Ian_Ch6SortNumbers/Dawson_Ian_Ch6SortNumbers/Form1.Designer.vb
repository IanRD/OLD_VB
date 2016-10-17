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
        Me.lblFirst = New System.Windows.Forms.Label()
        Me.lblSecond = New System.Windows.Forms.Label()
        Me.txtFirst = New System.Windows.Forms.TextBox()
        Me.txtSecond = New System.Windows.Forms.TextBox()
        Me.btnSort = New System.Windows.Forms.Button()
        Me.lblOrder = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'lblFirst
        '
        Me.lblFirst.AutoSize = True
        Me.lblFirst.Location = New System.Drawing.Point(37, 52)
        Me.lblFirst.Name = "lblFirst"
        Me.lblFirst.Size = New System.Drawing.Size(92, 13)
        Me.lblFirst.TabIndex = 0
        Me.lblFirst.Text = "Enter first number:"
        '
        'lblSecond
        '
        Me.lblSecond.AutoSize = True
        Me.lblSecond.Location = New System.Drawing.Point(32, 86)
        Me.lblSecond.Name = "lblSecond"
        Me.lblSecond.Size = New System.Drawing.Size(111, 13)
        Me.lblSecond.TabIndex = 1
        Me.lblSecond.Text = "Enter second number:"
        '
        'txtFirst
        '
        Me.txtFirst.Location = New System.Drawing.Point(149, 49)
        Me.txtFirst.Name = "txtFirst"
        Me.txtFirst.Size = New System.Drawing.Size(54, 20)
        Me.txtFirst.TabIndex = 2
        '
        'txtSecond
        '
        Me.txtSecond.Location = New System.Drawing.Point(149, 83)
        Me.txtSecond.Name = "txtSecond"
        Me.txtSecond.Size = New System.Drawing.Size(54, 20)
        Me.txtSecond.TabIndex = 3
        '
        'btnSort
        '
        Me.btnSort.Location = New System.Drawing.Point(22, 152)
        Me.btnSort.Name = "btnSort"
        Me.btnSort.Size = New System.Drawing.Size(75, 23)
        Me.btnSort.TabIndex = 4
        Me.btnSort.Text = "Sort"
        Me.btnSort.UseVisualStyleBackColor = True
        '
        'lblOrder
        '
        Me.lblOrder.AutoSize = True
        Me.lblOrder.Location = New System.Drawing.Point(156, 157)
        Me.lblOrder.Name = "lblOrder"
        Me.lblOrder.Size = New System.Drawing.Size(0, 13)
        Me.lblOrder.TabIndex = 5
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(240, 197)
        Me.Controls.Add(Me.lblOrder)
        Me.Controls.Add(Me.btnSort)
        Me.Controls.Add(Me.txtSecond)
        Me.Controls.Add(Me.txtFirst)
        Me.Controls.Add(Me.lblSecond)
        Me.Controls.Add(Me.lblFirst)
        Me.Name = "Form1"
        Me.Text = "Sort Numbers"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblFirst As System.Windows.Forms.Label
    Friend WithEvents lblSecond As System.Windows.Forms.Label
    Friend WithEvents txtFirst As System.Windows.Forms.TextBox
    Friend WithEvents txtSecond As System.Windows.Forms.TextBox
    Friend WithEvents btnSort As System.Windows.Forms.Button
    Friend WithEvents lblOrder As System.Windows.Forms.Label

End Class
