Public Class BandInformation

    Private Sub RadioButton3_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles radJuliette.CheckedChanged

    End Sub

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub radQueen_Click1(ByVal sender As Object, ByVal e As System.EventArgs) Handles radQueen.Click
        Me.lblband1.Text = "Brian May – lead guitar, keyboards, piano, vocals"
        Me.lblband2.Text = "Roger Taylor – drums, rhythm guitar, percussion, vocals, tambourine"
        Me.lblband3.Text = "Freddie Mercury – lead vocals, piano, rhythm guitar, tambourine"
        Me.lblband4.Text = "John Deacon – bass guitar, rhythm guitar, keyboard, backing vocals, triangle"

    End Sub

    Private Sub radJuliette_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles radJuliette.Click
        Me.lblband1.Text = "Juliette Lewis – lead vocals, production"
        Me.lblband2.Text = "Emilio Cueto – guitar"
        Me.lblband3.Text = "Jason Womack – bass"
        Me.lblband4.Text = "Ed Davis – drums"

    End Sub

    Private Sub radTheJam_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles radTheJam.Click
        Me.lblband1.Text = "Paul Weller – lead vocals, guitar"
        Me.lblband2.Text = "Bruce Foxton – bass guitar, backing vocals"
        Me.lblband3.Text = "Rick Buckler – drums, percussion"
        Me.lblband4.Text = "Steve Brookes – guitar (left group prior to their recording career)"
    End Sub
End Class
