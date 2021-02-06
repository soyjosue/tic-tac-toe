Module Game

    Private _table(,) As Integer = {{0, 0, 0}, {0, 0, 0}, {0, 0, 0}}
    Private _playerNum As Integer

    ' Funcion para elegir aleatoriamente el primer jugador
    Private Function ChooseFirstPlayer() As Integer

        Randomize()
        Return CInt(Int((2 * Rnd()) + 1))

    End Function

    ' Funcion para iniciar el juego
    Public Sub StartGame(ByRef player As Windows.Forms.Label, ByRef pc As Windows.Forms.Label)

        Dim start As Integer = ChooseFirstPlayer()
        _playerNum = start

        Select Case start
            Case 1
                player.Text += " X"
                pc.Text += " O"
            Case Else
                player.Text += " O"
                pc.Text += " X"
        End Select

    End Sub

    ' Funcion para cuando el player de click en un boton
    Public Sub clickButton(ByVal cord() As Integer, ByRef btn As Windows.Forms.Button)

        ' Valida si ya se ha jugado en esa casilla.
        If _table(cord(0), cord(1)) <> 0 Then
            Return
        End If

        ' Guarda en el vector que posicion esta jugando el usuario.
        _table(cord(0), cord(1)) = _playerNum

        ' Dependiendo en que posicion salio el jugador cuando da click pone X o O.
        Select Case _playerNum
            Case 1
                btn.Text = "X"
            Case Else
                btn.Text = "O"
        End Select

    End Sub

    ' Funcion para reiniciar juego
    Public Sub ResetGame(ByRef btnArray() As Windows.Forms.Button)

        ' Elimina el texto de todos los btn
        For i = 0 To btnArray.Length - 1
            btnArray(i).Text = ""
        Next

        ' Reinicia el tablero
        _table = {{0, 0, 0}, {0, 0, 0}, {0, 0, 0}}

    End Sub

End Module
