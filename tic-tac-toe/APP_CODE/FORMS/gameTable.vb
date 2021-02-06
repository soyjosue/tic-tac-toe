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
        Game.ResetGame({btn11, btn12, btn13, btn21, btn22, btn23, btn31, btn32, btn33})
    End Sub

    Private Sub btn11_Click(sender As Object, e As EventArgs) Handles btn11.Click

        clickButton({0, 0}, Me.btn11)

    End Sub

    Private Sub btn12_Click(sender As Object, e As EventArgs) Handles btn12.Click

        clickButton({0, 1}, Me.btn12)

    End Sub

    Private Sub btn13_Click(sender As Object, e As EventArgs) Handles btn13.Click

        clickButton({0, 2}, Me.btn13)

    End Sub

    Private Sub btn21_Click(sender As Object, e As EventArgs) Handles btn21.Click

        clickButton({1, 0}, Me.btn21)

    End Sub

    Private Sub btn22_Click(sender As Object, e As EventArgs) Handles btn22.Click

        clickButton({1, 1}, Me.btn22)

    End Sub

    Private Sub btn23_Click(sender As Object, e As EventArgs) Handles btn23.Click

        clickButton({1, 2}, Me.btn23)

    End Sub

    Private Sub btn31_Click(sender As Object, e As EventArgs) Handles btn31.Click

        clickButton({2, 0}, Me.btn31)

    End Sub

    Private Sub btn32_Click(sender As Object, e As EventArgs) Handles btn32.Click

        clickButton({2, 1}, Me.btn32)

    End Sub

    Private Sub btn33_Click(sender As Object, e As EventArgs) Handles btn33.Click

        clickButton({2, 2}, Me.btn33)

    End Sub
End Class