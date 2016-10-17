Public Class Form1

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btnstart_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnstart.Click
        Dim guess As String
        Dim first As String
        Dim second As String
        Dim asd As String
        Dim label As String
        first = "Ian"
        second = "Dawson"




        guess = InputBox("Enter Name:")
        If guess = first Then
            InputBox("Enter last name:")
            Dim asd As String = InputBox("Enter last name:")
        End If
        If asd = second Then
            label = first & Space(1) & second
        End If


    End Sub
End Class
