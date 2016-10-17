Public Class Form1

    Private Sub Form1_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btnGetInfo_Click(sender As Object, e As System.EventArgs) Handles btnGetInfo.Click
        Dim CharacterName As String
        CharacterName = Me.txtCharacterName.Text

        'Show friend info
        Select Case CharacterName.ToUpper
            Case "NIGEL"
                Call NIGELInfo()
            Case "GRYZ"
                Call GRYZInfo()
            Case "ALYS"
                Call ALYSInfo()
            Case "RED"
                Call REDInfo()
            Case "SONIC"
                Call SONICInfo()
            Case "JUSTIN"
                Call JUSTINInfo()
            Case "SUE"
                Call SUEInfo()
            Case Else
                MessageBox.Show("Sorry, no information available.")
        End Select
    End Sub

    Sub NIGELInfo()
        Me.picGameCharacter.Image = My.Resources.nigel
        Me.lblCharacterInfo.Text = "Nigel is a treasure hunter from the game 'Landstalker,'" & _
        " and he is a heroic elf."
    End Sub

    Sub GRYZInfo()
        Me.picGameCharacter.Image = My.Resources.gryz
        Me.lblCharacterInfo.Text = "Gryz is an unknown creature from the game 'Phantasy Star IV,'" & _
        " and he specializes in melee attacks, and powerful special abilities."
    End Sub

    Sub ALYSInfo()
        Me.picGameCharacter.Image = My.Resources.alys
        Me.lblCharacterInfo.Text = "Alys is a stubborn, but heroic character from the game 'Phantasy Star IV,'" & _
        " and she uses boomerang-like weapons to her defense."
    End Sub

    Sub REDInfo()
        Me.picGameCharacter.Image = My.Resources.red1
        Me.lblCharacterInfo.Text = "Red is a female character that looks like a guy in the game 'Gunstar Super Heroes,'" & _
        " and she specializes in using he force weapon to defeat her foes."
    End Sub

    Sub SONICInfo()
        Me.picGameCharacter.Image = My.Resources.Sonic
        Me.lblCharacterInfo.Text = "He's the blue hedgehog we all know and love, he's Sonic from" & _
        " the Sonic the Hedgehog franchise! He can travel at the speed of sound."
    End Sub

    Sub JUSTINInfo()
        Me.picGameCharacter.Image = My.Resources.Justin
        Me.lblCharacterInfo.Text = "Justin is a very childish and immatured adventurer from 'Grandia,'" & _
        " and he is an adventurer and fighter, despite being 14 years old."
    End Sub

    Sub SUEInfo()
        Me.picGameCharacter.Image = My.Resources.Sue
        Me.lblCharacterInfo.Text = "Sue is adventurer Justin's best friend from the game 'Grandia,'" & _
        " and she uses a mace, black magic, and white magic to assist Justin on his adventure!"
    End Sub


End Class
