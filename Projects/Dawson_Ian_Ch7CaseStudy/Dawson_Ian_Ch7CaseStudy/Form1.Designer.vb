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
        Me.picAuto = New System.Windows.Forms.PictureBox()
        Me.picHome = New System.Windows.Forms.PictureBox()
        Me.grpWhatToKnow = New System.Windows.Forms.GroupBox()
        Me.radPaymentSize = New System.Windows.Forms.RadioButton()
        Me.radHowMuch = New System.Windows.Forms.RadioButton()
        Me.lblTermPrompt = New System.Windows.Forms.Label()
        Me.txtPrincipalOrPayment = New System.Windows.Forms.TextBox()
        Me.lblPrincipalOrPaymentPrompt = New System.Windows.Forms.Label()
        Me.lblRatePrompt = New System.Windows.Forms.Label()
        Me.cboRate = New System.Windows.Forms.ComboBox()
        Me.lstTerm = New System.Windows.Forms.ListBox()
        Me.btnNewLoan = New System.Windows.Forms.Button()
        Me.btnCalculate = New System.Windows.Forms.Button()
        Me.lblResult = New System.Windows.Forms.Label()
        CType(Me.picAuto, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picHome, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpWhatToKnow.SuspendLayout()
        Me.SuspendLayout()
        '
        'picAuto
        '
        Me.picAuto.Image = Global.WindowsApplication1.My.Resources.Resources._auto
        Me.picAuto.Location = New System.Drawing.Point(23, 33)
        Me.picAuto.Name = "picAuto"
        Me.picAuto.Size = New System.Drawing.Size(124, 75)
        Me.picAuto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.picAuto.TabIndex = 0
        Me.picAuto.TabStop = False
        Me.picAuto.Tag = "auto"
        '
        'picHome
        '
        Me.picHome.Image = Global.WindowsApplication1.My.Resources.Resources.home
        Me.picHome.Location = New System.Drawing.Point(166, 12)
        Me.picHome.Name = "picHome"
        Me.picHome.Size = New System.Drawing.Size(100, 124)
        Me.picHome.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.picHome.TabIndex = 1
        Me.picHome.TabStop = False
        Me.picHome.Tag = "home"
        '
        'grpWhatToKnow
        '
        Me.grpWhatToKnow.Controls.Add(Me.radPaymentSize)
        Me.grpWhatToKnow.Controls.Add(Me.radHowMuch)
        Me.grpWhatToKnow.Location = New System.Drawing.Point(12, 157)
        Me.grpWhatToKnow.Name = "grpWhatToKnow"
        Me.grpWhatToKnow.Size = New System.Drawing.Size(116, 142)
        Me.grpWhatToKnow.TabIndex = 0
        Me.grpWhatToKnow.TabStop = False
        Me.grpWhatToKnow.Text = "What do you want to know?"
        Me.grpWhatToKnow.Visible = False
        '
        'radPaymentSize
        '
        Me.radPaymentSize.Location = New System.Drawing.Point(6, 77)
        Me.radPaymentSize.Name = "radPaymentSize"
        Me.radPaymentSize.Size = New System.Drawing.Size(104, 47)
        Me.radPaymentSize.TabIndex = 2
        Me.radPaymentSize.TabStop = True
        Me.radPaymentSize.Tag = "payment size"
        Me.radPaymentSize.Text = "&What will be the size of my payment?"
        Me.radPaymentSize.UseVisualStyleBackColor = True
        '
        'radHowMuch
        '
        Me.radHowMuch.Location = New System.Drawing.Point(6, 34)
        Me.radHowMuch.Name = "radHowMuch"
        Me.radHowMuch.Size = New System.Drawing.Size(104, 37)
        Me.radHowMuch.TabIndex = 1
        Me.radHowMuch.TabStop = True
        Me.radHowMuch.Tag = "how much"
        Me.radHowMuch.Text = "&How much can I borrow?"
        Me.radHowMuch.UseVisualStyleBackColor = True
        '
        'lblTermPrompt
        '
        Me.lblTermPrompt.AutoSize = True
        Me.lblTermPrompt.Location = New System.Drawing.Point(163, 157)
        Me.lblTermPrompt.Name = "lblTermPrompt"
        Me.lblTermPrompt.Size = New System.Drawing.Size(67, 13)
        Me.lblTermPrompt.TabIndex = 4
        Me.lblTermPrompt.Text = "Select &Term:"
        Me.lblTermPrompt.Visible = False
        '
        'txtPrincipalOrPayment
        '
        Me.txtPrincipalOrPayment.Location = New System.Drawing.Point(215, 234)
        Me.txtPrincipalOrPayment.Name = "txtPrincipalOrPayment"
        Me.txtPrincipalOrPayment.Size = New System.Drawing.Size(51, 20)
        Me.txtPrincipalOrPayment.TabIndex = 7
        Me.txtPrincipalOrPayment.Visible = False
        '
        'lblPrincipalOrPaymentPrompt
        '
        Me.lblPrincipalOrPaymentPrompt.Location = New System.Drawing.Point(152, 225)
        Me.lblPrincipalOrPaymentPrompt.Name = "lblPrincipalOrPaymentPrompt"
        Me.lblPrincipalOrPaymentPrompt.Size = New System.Drawing.Size(57, 38)
        Me.lblPrincipalOrPaymentPrompt.TabIndex = 6
        Me.lblPrincipalOrPaymentPrompt.Visible = False
        '
        'lblRatePrompt
        '
        Me.lblRatePrompt.AutoSize = True
        Me.lblRatePrompt.Location = New System.Drawing.Point(155, 267)
        Me.lblRatePrompt.Name = "lblRatePrompt"
        Me.lblRatePrompt.Size = New System.Drawing.Size(71, 13)
        Me.lblRatePrompt.TabIndex = 8
        Me.lblRatePrompt.Text = "Interest &Rate:"
        Me.lblRatePrompt.Visible = False
        '
        'cboRate
        '
        Me.cboRate.FormattingEnabled = True
        Me.cboRate.Items.AddRange(New Object() {"5", "5.5", "6", "6.5", "7", "7.5", "8", "8.5", "9", "9.5", "10", "10.5", "11", "11.5", "12"})
        Me.cboRate.Location = New System.Drawing.Point(231, 264)
        Me.cboRate.Name = "cboRate"
        Me.cboRate.Size = New System.Drawing.Size(35, 21)
        Me.cboRate.TabIndex = 9
        Me.cboRate.Visible = False
        '
        'lstTerm
        '
        Me.lstTerm.FormattingEnabled = True
        Me.lstTerm.Location = New System.Drawing.Point(166, 173)
        Me.lstTerm.Name = "lstTerm"
        Me.lstTerm.Size = New System.Drawing.Size(100, 43)
        Me.lstTerm.TabIndex = 5
        Me.lstTerm.Visible = False
        '
        'btnNewLoan
        '
        Me.btnNewLoan.Location = New System.Drawing.Point(12, 306)
        Me.btnNewLoan.Name = "btnNewLoan"
        Me.btnNewLoan.Size = New System.Drawing.Size(75, 23)
        Me.btnNewLoan.TabIndex = 3
        Me.btnNewLoan.Text = "&New Loan"
        Me.btnNewLoan.UseVisualStyleBackColor = True
        Me.btnNewLoan.Visible = False
        '
        'btnCalculate
        '
        Me.btnCalculate.Enabled = False
        Me.btnCalculate.Location = New System.Drawing.Point(93, 306)
        Me.btnCalculate.Name = "btnCalculate"
        Me.btnCalculate.Size = New System.Drawing.Size(75, 23)
        Me.btnCalculate.TabIndex = 10
        Me.btnCalculate.Text = "&Calculate"
        Me.btnCalculate.UseVisualStyleBackColor = True
        Me.btnCalculate.Visible = False
        '
        'lblResult
        '
        Me.lblResult.Location = New System.Drawing.Point(174, 296)
        Me.lblResult.Name = "lblResult"
        Me.lblResult.Size = New System.Drawing.Size(103, 34)
        Me.lblResult.TabIndex = 11
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(289, 339)
        Me.Controls.Add(Me.lblResult)
        Me.Controls.Add(Me.btnCalculate)
        Me.Controls.Add(Me.btnNewLoan)
        Me.Controls.Add(Me.lstTerm)
        Me.Controls.Add(Me.cboRate)
        Me.Controls.Add(Me.lblRatePrompt)
        Me.Controls.Add(Me.lblPrincipalOrPaymentPrompt)
        Me.Controls.Add(Me.txtPrincipalOrPayment)
        Me.Controls.Add(Me.lblTermPrompt)
        Me.Controls.Add(Me.grpWhatToKnow)
        Me.Controls.Add(Me.picHome)
        Me.Controls.Add(Me.picAuto)
        Me.Name = "Form1"
        Me.Text = "Loan Analyzer"
        CType(Me.picAuto, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picHome, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpWhatToKnow.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents picAuto As System.Windows.Forms.PictureBox
    Friend WithEvents picHome As System.Windows.Forms.PictureBox
    Friend WithEvents grpWhatToKnow As System.Windows.Forms.GroupBox
    Friend WithEvents radPaymentSize As System.Windows.Forms.RadioButton
    Friend WithEvents radHowMuch As System.Windows.Forms.RadioButton
    Friend WithEvents lblTermPrompt As System.Windows.Forms.Label
    Friend WithEvents txtPrincipalOrPayment As System.Windows.Forms.TextBox
    Friend WithEvents lblPrincipalOrPaymentPrompt As System.Windows.Forms.Label
    Friend WithEvents lblRatePrompt As System.Windows.Forms.Label
    Friend WithEvents cboRate As System.Windows.Forms.ComboBox
    Friend WithEvents lstTerm As System.Windows.Forms.ListBox
    Friend WithEvents btnNewLoan As System.Windows.Forms.Button
    Friend WithEvents btnCalculate As System.Windows.Forms.Button
    Friend WithEvents lblResult As System.Windows.Forms.Label

End Class
