Public Class Form1

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.radPickup.Checked = True
    End Sub

    Private Sub btnPlaceOrder_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnPlaceOrder.Click
        Const REGULAR As Decimal = 6
        Const LARGE As Decimal = 10
        Const DELIVERY As Decimal = 1.5
        Const ONE_TOPPING As Decimal = 1
        Const TWO_TOPPINGS As Decimal = 1.75
        Const THREE_TOPPINGS As Decimal = 2.5
        Const FOUR_TOPPINGS As Decimal = 3.25
        Static orderNumber As Integer = 0
        Dim numToppings As Integer = 0
        Dim toppingsPrice As Decimal = 0
        Dim pizzaPrice As Decimal = 0
        'Increment order number
        orderNumber += 1
        'Count selected toppings
        If Me.chkHotPeppers.Checked = True Then
            numToppings += 1
        End If
        If Me.chkMushrooms.Checked = True Then
            numToppings += 1
        End If
        If Me.chkOnions.Checked = True Then
            numToppings += 1
        End If
        If Me.chkPepperoni.Checked = True Then
            numToppings += 1
        End If
        'Determine toppings price
        Select Case numToppings
            Case 1
                toppingsPrice = ONE_TOPPING
            Case 2
                toppingsPrice = TWO_TOPPINGS
            Case 3
                toppingsPrice = THREE_TOPPINGS
            Case 4
                toppingsPrice = FOUR_TOPPINGS
        End Select
        'Determine pizza price
        If Me.radLarge.Checked Then
            pizzaPrice = LARGE + toppingsPrice
        Else
            pizzaPrice = REGULAR + toppingsPrice
        End If
        If Me.radDelivery.Checked Then
            pizzaPrice = DELIVERY + toppingsPrice

        End If
        'Display order number and pizza price
        Me.lblOrder.Text = "Order Number:"
        Me.lblordernumber.Text = orderNumber
        Me.lblPrice.Text = "Price: $"
        Me.lblPizzaPrice.Text = pizzaPrice
    End Sub

    Private Sub btnNewOrder_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnNewOrder.Click
        Me.radLarge.Checked = False
        Me.radRegular.Checked = True
        Me.chkHotPeppers.Checked = False
        Me.chkMushrooms.Checked = False
        Me.chkOnions.Checked = False
        Me.chkPepperoni.Checked = False
        Me.lblOrder = Nothing
        Me.lblordernumber = Nothing
        Me.lblPrice = Nothing
        Me.lblPizzaPrice = Nothing
        Me.radPickup.Checked = True

    End Sub
End Class