﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
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
        Me.grpPizzaSize = New System.Windows.Forms.GroupBox()
        Me.radLarge = New System.Windows.Forms.RadioButton()
        Me.radRegular = New System.Windows.Forms.RadioButton()
        Me.grpToppings = New System.Windows.Forms.GroupBox()
        Me.chkHotPeppers = New System.Windows.Forms.CheckBox()
        Me.chkMushrooms = New System.Windows.Forms.CheckBox()
        Me.chkOnions = New System.Windows.Forms.CheckBox()
        Me.chkPepperoni = New System.Windows.Forms.CheckBox()
        Me.btnPlaceOrder = New System.Windows.Forms.Button()
        Me.btnNewOrder = New System.Windows.Forms.Button()
        Me.lblOrder = New System.Windows.Forms.Label()
        Me.lblordernumber = New System.Windows.Forms.Label()
        Me.lblPrice = New System.Windows.Forms.Label()
        Me.lblPizzaPrice = New System.Windows.Forms.Label()
        Me.grpPizzaSize.SuspendLayout()
        Me.grpToppings.SuspendLayout()
        Me.SuspendLayout()
        '
        'grpPizzaSize
        '
        Me.grpPizzaSize.Controls.Add(Me.radLarge)
        Me.grpPizzaSize.Controls.Add(Me.radRegular)
        Me.grpPizzaSize.Location = New System.Drawing.Point(33, 12)
        Me.grpPizzaSize.Name = "grpPizzaSize"
        Me.grpPizzaSize.Size = New System.Drawing.Size(200, 49)
        Me.grpPizzaSize.TabIndex = 0
        Me.grpPizzaSize.TabStop = False
        Me.grpPizzaSize.Text = "Select pizza size"
        '
        'radLarge
        '
        Me.radLarge.AutoSize = True
        Me.radLarge.Location = New System.Drawing.Point(120, 19)
        Me.radLarge.Name = "radLarge"
        Me.radLarge.Size = New System.Drawing.Size(52, 17)
        Me.radLarge.TabIndex = 1
        Me.radLarge.TabStop = True
        Me.radLarge.Text = "Large"
        Me.radLarge.UseVisualStyleBackColor = True
        '
        'radRegular
        '
        Me.radRegular.AutoSize = True
        Me.radRegular.Location = New System.Drawing.Point(20, 19)
        Me.radRegular.Name = "radRegular"
        Me.radRegular.Size = New System.Drawing.Size(62, 17)
        Me.radRegular.TabIndex = 0
        Me.radRegular.TabStop = True
        Me.radRegular.Text = "Regular"
        Me.radRegular.UseVisualStyleBackColor = True
        '
        'grpToppings
        '
        Me.grpToppings.Controls.Add(Me.chkHotPeppers)
        Me.grpToppings.Controls.Add(Me.chkMushrooms)
        Me.grpToppings.Controls.Add(Me.chkOnions)
        Me.grpToppings.Controls.Add(Me.chkPepperoni)
        Me.grpToppings.Location = New System.Drawing.Point(33, 78)
        Me.grpToppings.Name = "grpToppings"
        Me.grpToppings.Size = New System.Drawing.Size(200, 100)
        Me.grpToppings.TabIndex = 1
        Me.grpToppings.TabStop = False
        Me.grpToppings.Text = "Select toppings"
        '
        'chkHotPeppers
        '
        Me.chkHotPeppers.AutoSize = True
        Me.chkHotPeppers.Location = New System.Drawing.Point(109, 68)
        Me.chkHotPeppers.Name = "chkHotPeppers"
        Me.chkHotPeppers.Size = New System.Drawing.Size(85, 17)
        Me.chkHotPeppers.TabIndex = 3
        Me.chkHotPeppers.Text = "Hot Peppers"
        Me.chkHotPeppers.UseVisualStyleBackColor = True
        '
        'chkMushrooms
        '
        Me.chkMushrooms.AutoSize = True
        Me.chkMushrooms.Location = New System.Drawing.Point(14, 68)
        Me.chkMushrooms.Name = "chkMushrooms"
        Me.chkMushrooms.Size = New System.Drawing.Size(80, 17)
        Me.chkMushrooms.TabIndex = 2
        Me.chkMushrooms.Text = "Mushrooms"
        Me.chkMushrooms.UseVisualStyleBackColor = True
        '
        'chkOnions
        '
        Me.chkOnions.AutoSize = True
        Me.chkOnions.Location = New System.Drawing.Point(120, 29)
        Me.chkOnions.Name = "chkOnions"
        Me.chkOnions.Size = New System.Drawing.Size(59, 17)
        Me.chkOnions.TabIndex = 1
        Me.chkOnions.Text = "Onions"
        Me.chkOnions.UseVisualStyleBackColor = True
        '
        'chkPepperoni
        '
        Me.chkPepperoni.AutoSize = True
        Me.chkPepperoni.Location = New System.Drawing.Point(20, 29)
        Me.chkPepperoni.Name = "chkPepperoni"
        Me.chkPepperoni.Size = New System.Drawing.Size(74, 17)
        Me.chkPepperoni.TabIndex = 0
        Me.chkPepperoni.Text = "Pepperoni"
        Me.chkPepperoni.UseVisualStyleBackColor = True
        '
        'btnPlaceOrder
        '
        Me.btnPlaceOrder.Location = New System.Drawing.Point(24, 200)
        Me.btnPlaceOrder.Name = "btnPlaceOrder"
        Me.btnPlaceOrder.Size = New System.Drawing.Size(75, 23)
        Me.btnPlaceOrder.TabIndex = 2
        Me.btnPlaceOrder.Text = "Place Order"
        Me.btnPlaceOrder.UseVisualStyleBackColor = True
        '
        'btnNewOrder
        '
        Me.btnNewOrder.Location = New System.Drawing.Point(24, 231)
        Me.btnNewOrder.Name = "btnNewOrder"
        Me.btnNewOrder.Size = New System.Drawing.Size(75, 23)
        Me.btnNewOrder.TabIndex = 3
        Me.btnNewOrder.Text = "New Order"
        Me.btnNewOrder.UseVisualStyleBackColor = True
        '
        'lblOrder
        '
        Me.lblOrder.AutoSize = True
        Me.lblOrder.Location = New System.Drawing.Point(118, 205)
        Me.lblOrder.Name = "lblOrder"
        Me.lblOrder.Size = New System.Drawing.Size(0, 13)
        Me.lblOrder.TabIndex = 4
        '
        'lblordernumber
        '
        Me.lblordernumber.AutoSize = True
        Me.lblordernumber.Location = New System.Drawing.Point(205, 205)
        Me.lblordernumber.Name = "lblordernumber"
        Me.lblordernumber.Size = New System.Drawing.Size(0, 13)
        Me.lblordernumber.TabIndex = 5
        '
        'lblPrice
        '
        Me.lblPrice.AutoSize = True
        Me.lblPrice.Location = New System.Drawing.Point(118, 236)
        Me.lblPrice.Name = "lblPrice"
        Me.lblPrice.Size = New System.Drawing.Size(0, 13)
        Me.lblPrice.TabIndex = 6
        '
        'lblPizzaPrice
        '
        Me.lblPizzaPrice.AutoSize = True
        Me.lblPizzaPrice.Location = New System.Drawing.Point(182, 236)
        Me.lblPizzaPrice.Name = "lblPizzaPrice"
        Me.lblPizzaPrice.Size = New System.Drawing.Size(0, 13)
        Me.lblPizzaPrice.TabIndex = 7
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(270, 266)
        Me.Controls.Add(Me.lblPizzaPrice)
        Me.Controls.Add(Me.lblPrice)
        Me.Controls.Add(Me.lblordernumber)
        Me.Controls.Add(Me.lblOrder)
        Me.Controls.Add(Me.btnNewOrder)
        Me.Controls.Add(Me.btnPlaceOrder)
        Me.Controls.Add(Me.grpToppings)
        Me.Controls.Add(Me.grpPizzaSize)
        Me.Name = "Form1"
        Me.Text = "Pizza Order"
        Me.grpPizzaSize.ResumeLayout(False)
        Me.grpPizzaSize.PerformLayout()
        Me.grpToppings.ResumeLayout(False)
        Me.grpToppings.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents grpPizzaSize As System.Windows.Forms.GroupBox
    Friend WithEvents radLarge As System.Windows.Forms.RadioButton
    Friend WithEvents radRegular As System.Windows.Forms.RadioButton
    Friend WithEvents grpToppings As System.Windows.Forms.GroupBox
    Friend WithEvents chkHotPeppers As System.Windows.Forms.CheckBox
    Friend WithEvents chkMushrooms As System.Windows.Forms.CheckBox
    Friend WithEvents chkOnions As System.Windows.Forms.CheckBox
    Friend WithEvents chkPepperoni As System.Windows.Forms.CheckBox
    Friend WithEvents btnPlaceOrder As System.Windows.Forms.Button
    Friend WithEvents btnNewOrder As System.Windows.Forms.Button
    Friend WithEvents lblOrder As System.Windows.Forms.Label
    Friend WithEvents lblordernumber As System.Windows.Forms.Label
    Friend WithEvents lblPrice As System.Windows.Forms.Label
    Friend WithEvents lblPizzaPrice As System.Windows.Forms.Label

End Class
