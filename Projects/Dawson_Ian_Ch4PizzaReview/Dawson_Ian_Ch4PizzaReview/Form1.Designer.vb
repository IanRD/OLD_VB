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
        Me.lblPizzaPrice = New System.Windows.Forms.Label()
        Me.lblPrice = New System.Windows.Forms.Label()
        Me.lblordernumber = New System.Windows.Forms.Label()
        Me.lblOrder = New System.Windows.Forms.Label()
        Me.btnNewOrder = New System.Windows.Forms.Button()
        Me.btnPlaceOrder = New System.Windows.Forms.Button()
        Me.grpToppings = New System.Windows.Forms.GroupBox()
        Me.chkHotPeppers = New System.Windows.Forms.CheckBox()
        Me.chkMushrooms = New System.Windows.Forms.CheckBox()
        Me.chkOnions = New System.Windows.Forms.CheckBox()
        Me.chkPepperoni = New System.Windows.Forms.CheckBox()
        Me.grpPizzaSize = New System.Windows.Forms.GroupBox()
        Me.radLarge = New System.Windows.Forms.RadioButton()
        Me.radRegular = New System.Windows.Forms.RadioButton()
        Me.grpPD = New System.Windows.Forms.GroupBox()
        Me.radPickup = New System.Windows.Forms.RadioButton()
        Me.radDelivery = New System.Windows.Forms.RadioButton()
        Me.grpToppings.SuspendLayout()
        Me.grpPizzaSize.SuspendLayout()
        Me.grpPD.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblPizzaPrice
        '
        Me.lblPizzaPrice.AutoSize = True
        Me.lblPizzaPrice.Location = New System.Drawing.Point(170, 264)
        Me.lblPizzaPrice.Name = "lblPizzaPrice"
        Me.lblPizzaPrice.Size = New System.Drawing.Size(0, 13)
        Me.lblPizzaPrice.TabIndex = 15
        '
        'lblPrice
        '
        Me.lblPrice.AutoSize = True
        Me.lblPrice.Location = New System.Drawing.Point(106, 264)
        Me.lblPrice.Name = "lblPrice"
        Me.lblPrice.Size = New System.Drawing.Size(0, 13)
        Me.lblPrice.TabIndex = 14
        '
        'lblordernumber
        '
        Me.lblordernumber.AutoSize = True
        Me.lblordernumber.Location = New System.Drawing.Point(193, 233)
        Me.lblordernumber.Name = "lblordernumber"
        Me.lblordernumber.Size = New System.Drawing.Size(0, 13)
        Me.lblordernumber.TabIndex = 13
        '
        'lblOrder
        '
        Me.lblOrder.AutoSize = True
        Me.lblOrder.Location = New System.Drawing.Point(106, 233)
        Me.lblOrder.Name = "lblOrder"
        Me.lblOrder.Size = New System.Drawing.Size(0, 13)
        Me.lblOrder.TabIndex = 12
        '
        'btnNewOrder
        '
        Me.btnNewOrder.Location = New System.Drawing.Point(12, 259)
        Me.btnNewOrder.Name = "btnNewOrder"
        Me.btnNewOrder.Size = New System.Drawing.Size(75, 23)
        Me.btnNewOrder.TabIndex = 11
        Me.btnNewOrder.Text = "New Order"
        Me.btnNewOrder.UseVisualStyleBackColor = True
        '
        'btnPlaceOrder
        '
        Me.btnPlaceOrder.Location = New System.Drawing.Point(12, 228)
        Me.btnPlaceOrder.Name = "btnPlaceOrder"
        Me.btnPlaceOrder.Size = New System.Drawing.Size(75, 23)
        Me.btnPlaceOrder.TabIndex = 10
        Me.btnPlaceOrder.Text = "Place Order"
        Me.btnPlaceOrder.UseVisualStyleBackColor = True
        '
        'grpToppings
        '
        Me.grpToppings.Controls.Add(Me.chkHotPeppers)
        Me.grpToppings.Controls.Add(Me.chkMushrooms)
        Me.grpToppings.Controls.Add(Me.chkOnions)
        Me.grpToppings.Controls.Add(Me.chkPepperoni)
        Me.grpToppings.Location = New System.Drawing.Point(24, 57)
        Me.grpToppings.Name = "grpToppings"
        Me.grpToppings.Size = New System.Drawing.Size(200, 99)
        Me.grpToppings.TabIndex = 9
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
        'grpPizzaSize
        '
        Me.grpPizzaSize.Controls.Add(Me.radLarge)
        Me.grpPizzaSize.Controls.Add(Me.radRegular)
        Me.grpPizzaSize.Location = New System.Drawing.Point(24, 2)
        Me.grpPizzaSize.Name = "grpPizzaSize"
        Me.grpPizzaSize.Size = New System.Drawing.Size(200, 49)
        Me.grpPizzaSize.TabIndex = 8
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
        'grpPD
        '
        Me.grpPD.Controls.Add(Me.radDelivery)
        Me.grpPD.Controls.Add(Me.radPickup)
        Me.grpPD.Location = New System.Drawing.Point(24, 157)
        Me.grpPD.Name = "grpPD"
        Me.grpPD.Size = New System.Drawing.Size(200, 65)
        Me.grpPD.TabIndex = 16
        Me.grpPD.TabStop = False
        Me.grpPD.Text = "Pickup or Delivery?"
        '
        'radPickup
        '
        Me.radPickup.AutoSize = True
        Me.radPickup.Location = New System.Drawing.Point(7, 29)
        Me.radPickup.Name = "radPickup"
        Me.radPickup.Size = New System.Drawing.Size(58, 17)
        Me.radPickup.TabIndex = 0
        Me.radPickup.TabStop = True
        Me.radPickup.Text = "Pickup"
        Me.radPickup.UseVisualStyleBackColor = True
        '
        'radDelivery
        '
        Me.radDelivery.AutoSize = True
        Me.radDelivery.Location = New System.Drawing.Point(120, 29)
        Me.radDelivery.Name = "radDelivery"
        Me.radDelivery.Size = New System.Drawing.Size(63, 17)
        Me.radDelivery.TabIndex = 1
        Me.radDelivery.TabStop = True
        Me.radDelivery.Text = "Delivery"
        Me.radDelivery.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(252, 290)
        Me.Controls.Add(Me.grpPD)
        Me.Controls.Add(Me.lblPizzaPrice)
        Me.Controls.Add(Me.lblPrice)
        Me.Controls.Add(Me.grpToppings)
        Me.Controls.Add(Me.lblordernumber)
        Me.Controls.Add(Me.lblOrder)
        Me.Controls.Add(Me.btnNewOrder)
        Me.Controls.Add(Me.btnPlaceOrder)
        Me.Controls.Add(Me.grpPizzaSize)
        Me.Name = "Form1"
        Me.Text = "Pizza Order Review"
        Me.grpToppings.ResumeLayout(False)
        Me.grpToppings.PerformLayout()
        Me.grpPizzaSize.ResumeLayout(False)
        Me.grpPizzaSize.PerformLayout()
        Me.grpPD.ResumeLayout(False)
        Me.grpPD.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblPizzaPrice As System.Windows.Forms.Label
    Friend WithEvents lblPrice As System.Windows.Forms.Label
    Friend WithEvents lblordernumber As System.Windows.Forms.Label
    Friend WithEvents lblOrder As System.Windows.Forms.Label
    Friend WithEvents btnNewOrder As System.Windows.Forms.Button
    Friend WithEvents btnPlaceOrder As System.Windows.Forms.Button
    Friend WithEvents grpToppings As System.Windows.Forms.GroupBox
    Friend WithEvents chkHotPeppers As System.Windows.Forms.CheckBox
    Friend WithEvents chkMushrooms As System.Windows.Forms.CheckBox
    Friend WithEvents chkOnions As System.Windows.Forms.CheckBox
    Friend WithEvents chkPepperoni As System.Windows.Forms.CheckBox
    Friend WithEvents grpPizzaSize As System.Windows.Forms.GroupBox
    Friend WithEvents radLarge As System.Windows.Forms.RadioButton
    Friend WithEvents radRegular As System.Windows.Forms.RadioButton
    Friend WithEvents grpPD As System.Windows.Forms.GroupBox
    Friend WithEvents radDelivery As System.Windows.Forms.RadioButton
    Friend WithEvents radPickup As System.Windows.Forms.RadioButton

End Class
