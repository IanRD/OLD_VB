Public Class Form1

    Private Sub Form1_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub picShell1_Click(ByVal sender As Object, ByVal e As System.EventArgs) _
    Handles picShell1.Click, picShell2.Click, picShell3.Click
        Dim picShellClicked As PictureBox = sender
        Dim shellClicked As Integer = Val(picShellClicked.Tag)
        Randomize()
        Dim shellwithPearl As Integer = Int(3 * Rnd()) + 1
        Select Case shellwithPearl
            Case 1
                Me.picPearl1.Visible = True
            Case 2
                Me.picPearl2.Visible = True
            Case 3
                Me.picPearl3.Visible = True
        End Select
        If shellClicked = shellwithPearl Then
            MessageBox.Show("You won!")
        Else
            MessageBox.Show("Sorry, you lose.")

        End If
        Select Case shellwithPearl
            Case 1 =
                Me.picPearl1.Visible = False
            Case 2
                Me.picPearl2.Visible = False
            Case 3
                Me.picPearl3.Visible = False
        End Select

    End Sub
End Class
