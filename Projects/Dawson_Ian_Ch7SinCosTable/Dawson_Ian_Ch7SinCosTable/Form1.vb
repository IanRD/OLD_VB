Public Class Form1

    Private Sub Form1_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btnDisplayTable_Click(sender As Object, e As System.EventArgs) Handles btnDisplayTable.Click
        Me.lstSineCosine.Items.Add("Angle" & vbTab & "Sin" & vbTab & "Cos")
        Dim AngleRadians As Double
        Dim Sin As Double
        Dim Cos As Double
        Dim Angle As Integer
        For Angle = 0 To 360 Step 15
            AngleRadians = DegreesToRadians(Angle)
            Sin = Math.Round(Math.Sin(AngleRadians), 2)
            Cos = Math.Round(Math.Cos(AngleRadians), 2)
            Me.lstSineCosine.Items.Add(Angle & vbTab & Sin & vbTab & Cos)
        Next Angle
    End Sub
    Function DegreesToRadians(ByVal degrees As Double) As Double
        Return degrees * (Math.PI / 180)



    End Function
End Class
