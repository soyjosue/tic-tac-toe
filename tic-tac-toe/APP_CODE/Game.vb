Module Game

    Public your

    ' Funcion para elegir aleatoriamente el primer jugador
    Private Function ChooseFirstPlayer() As Integer

        Randomize()
        Return CInt(Int((2 * Rnd()) + 1))

    End Function

    ' Funcion para iniciar el juego
    Public Sub StartGame()

        Dim start As Integer = ChooseFirstPlayer()


    End Sub

End Module
