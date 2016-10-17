Public Class Form1

    Private Sub Form1_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btnGetInfo_Click(sender As Object, e As System.EventArgs) Handles btnGetInfo.Click
        Dim friendName As String
        friendName = Me.txtFriendName.Text

        'Show friend info
        Select Case friendName.ToUpper
            Case "SHANA"
                Call SHANAInfo()
            Case "LUIZ"
                Call LUIZInfo()
            Case "CRIS"
                Call CRISInfo()
            Case Else
                MessageBox.Show("Sorry, no information available.")
        End Select
    End Sub

    Sub SHANAInfo()
        Me.picFriendPhoto.Image = My.Resources.shana
        Me.lblFriendInfo.Text = "Shana's birthday is June 24. Her favorite animal" & _
        " is the turtle, her favorite color is blue, and she likes to play tennis."
    End Sub

    Sub LUIZInfo()
        Me.picFriendPhoto.Image = My.Resources.luiz
        Me.lblFriendInfo.Text = "Luiz's birthday is August 21. His favorite animal" & _
        " is the tiger, his favorite color is green, and he likes to do gymnastics."
    End Sub

    Sub CRISInfo()
        Me.picFriendPhoto.Image = My.Resources.cris
        Me.lblFriendInfo.Text = "Cris' birthday is September 20. His favorite animal" & _
        " is any kind of bird, his favorite color is red, and he likes to play the guitar."
    End Sub
End Class
