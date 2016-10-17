Public Class Form1

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btndata_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btndata.Click
        Dim chicken As String
        Dim first As String
        Dim mid As String
        Dim last As String
        chicken = Me.txtword.Text
        first = Me.lblfirst.Text

        first = chicken.Remove(1, 9)
       
    End Sub
End Class
