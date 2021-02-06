Module Game

    Public your

    ' Funcion para elegir aleatoriamente el primer jugador
    Private Function ChooseFirstPlayer() As Integer

        Randomize()
        Return CInt(Int((2 * Rnd()) + 1))

    End Function

    ' Funcion para iniciar el juego
    Public Sub StartGame(ByRef player As Windows.Forms.Label, ByRef pc As Windows.Forms.Label)

        Dim start As Integer = ChooseFirstPlayer()

        Select Case start
            Case 1
                player.Text += " X"
                pc.Text += " O"
            Case Else
                player.Text += " O"
                pc.Text += " X"
        End Select

    End Sub

End Module
