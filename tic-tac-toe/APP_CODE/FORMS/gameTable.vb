Public Class GameTable

    Private _labels(2) As String

    Private Sub gameTable_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Guarda los textos de los labels por default
        _labels = {LabelPlayer.Text, LabelBot.Text}
        ' Inicia el juego
        Game.StartGame(LabelPlayer, LabelBot)
    End Sub

    Private Sub ResetBtn_Click(sender As Object, e As EventArgs) Handles ResetBtn.Click
        ' - Se coloca el Text por default de los label -
        LabelPlayer.Text = _labels(0)
        LabelBot.Text = _labels(1)
        ' Se reinicia el juego
        Game.StartGame(LabelPlayer, LabelBot)
    End Sub
End Class