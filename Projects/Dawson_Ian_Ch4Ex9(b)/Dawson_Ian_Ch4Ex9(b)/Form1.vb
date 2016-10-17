Public Class Form1

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub txtpassword_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtpassword.TextChanged
        Dim password As Integer
    End Sub

    Private Sub txtuserid_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtuserid.TextChanged
        Dim userid As Integer
    End Sub

    Private Sub btnCancel_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnCancel.Click
        Application.Exit()
    End Sub

    Private Sub btnOK_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnOK.Click
        Static attempts As Integer = 0
        If attempts = 3 Then
            MessageBox.Show("Sorry, access denied.")
            Application.Exit()
        End If
        If Me.txtuserid.Text = "Chicken" And Me.txtpassword.Text = "Pie" Then
            MessageBox.Show("Correct!")
            Application.Exit()
        ElseIf Me.txtuserid.Text <> "Chicken" And Me.txtpassword.Text <> "Pie" Then
            MessageBox.Show("Incorrect UserID and Password")
        ElseIf Me.txtuserid.Text <> "Chicken" Then
            MessageBox.Show("Incorrect UserID")
        ElseIf Me.txtpassword.Text <> "Pie" Then
            MessageBox.Show("Incorrect Password")

        End If
        If Me.txtuserid.Text <> "Chicken" And Me.txtpassword.Text <> "Pie" Then
            attempts += 1
        ElseIf Me.txtuserid.Text <> "Chicken" Then
            attempts += 1
        ElseIf Me.txtpassword.Text <> "Chicken" Then
            attempts += 1

        End If


      
        If Me.txtuserid.Text = "Nope" And Me.txtpassword.Text = "Yes" Then
            MessageBox.Show("Correct!")
            Application.Exit()

        End If
        If Me.txtuserid.Text <> "Nope" And Me.txtpassword.Text <> "Yes" Then
            attempts += 1
        ElseIf Me.txtuserid.Text <> "Nope" Then
            attempts += 1
        ElseIf Me.txtpassword.Text <> "Yes" Then
            attempts += 1

        End If

        If Me.txtuserid.Text = "aaa" And Me.txtpassword.Text = "bbb" Then
            MessageBox.Show("Correct!")
            Application.Exit()

        End If
        If Me.txtuserid.Text <> "aaa" And Me.txtpassword.Text <> "bbb" Then
            attempts += 1
        ElseIf Me.txtuserid.Text <> "aaa" Then
            attempts += 1
        ElseIf Me.txtpassword.Text <> "bbb" Then
            attempts += 1

        End If



    End Sub
End Class
