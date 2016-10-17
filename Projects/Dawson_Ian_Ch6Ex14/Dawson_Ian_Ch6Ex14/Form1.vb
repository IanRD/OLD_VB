Public Class Form1

    Private Sub Form1_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Label1_Click(sender As System.Object, e As System.EventArgs) Handles lblSentence.Click
        Dim verb, adjective, noun, lownum, highnum As Integer
        Dim sentence As String
        verb = Val(Me.txtVerb.Text)
        noun = Val(Me.txtNoun.Text)
        adjective = Val(Me.txtAdjective.Text)
        Call MakeSentence(verb, adjective, noun)
        sentence = RndInt(Me.lblSentence.Text)
        Me.lblSentence.Text = MakeSentence()

    End Sub
    Function RndInt(ByRef lownum As Integer, ByRef highnum As Integer)
        lownum = 1
        highnum = 5
        Randomize(lownum And highnum)
    End Function
    Sub MakeSentence(ByRef verb As Integer, ByRef adjective As Integer, ByRef noun As Integer)
        verb = Val(Me.txtVerb.Text)
        noun = Val(Me.txtNoun.Text)
        adjective = Val(Me.txtAdjective.Text)
        Me.lblSentence.Text = "A " & adjective & " " & noun & " " & verb & " too much chicken."
        Me.lblSentence.Text = "Many " & adjective & " " & noun & " " & verb & " people."
        Me.lblSentence.Text = "The " & adjective & " " & noun & " " & verb & " over the bridge."
        Me.lblSentence.Text = "Some " & adjective & " " & noun & " " & verb & " themselves into trouble."
        Me.lblSentence.Text = "The " & adjective & " " & noun & " " & verb & " himself drunk."



    End Sub
End Class
