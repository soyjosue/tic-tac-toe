Module Game

    Private _table(,) As Integer = {{0, 0, 0}, {0, 0, 0}, {0, 0, 0}}
    Private _playerNum As Integer
    Private _pcNum As Integer
    Private _btns(,) As Windows.Forms.Button
    Private _amountPlays As Integer = 0

    ' Funcion para elegir aleatoriamente el primer jugador
    Private Function RamdonNumber(ByVal max As Integer, ByVal min As Integer) As Integer

        Randomize()
        Return CInt(Int((max * Rnd()) + min))

    End Function

    ' Funcion que genera aleatoriamente quien comenzara de primero. 
    Public Sub PlayerPosition(ByRef player As Windows.Forms.Label, ByRef pc As Windows.Forms.Label)
        Dim start As Integer = RamdonNumber(2, 1)
        _playerNum = start

        Select Case start
            Case 1
                player.Text += " X"
                pc.Text += " O"
                _pcNum = 2
            Case Else
                player.Text += " O"
                pc.Text += " X"
                _pcNum = 1
        End Select
    End Sub

    ' Funcion para iniciar el juego
    Public Sub StartGame(ByRef player As Windows.Forms.Label, ByRef pc As Windows.Forms.Label, ByRef btnArray(,) As Windows.Forms.Button)

        ' Guarda la referencias de los botones
        _btns = btnArray

        ' Aleatoriamente elige quien comenzara primero
        PlayerPosition(player, pc)

    End Sub

    Private Sub MaquineGame()

        If _amountPlays = 1 Then

            While True
                Dim x As Integer = RamdonNumber(3, 0)
                Dim y As Integer = RamdonNumber(3, 0)

                If _table(x, y) = 0 Then
                    _table(x, y) = _pcNum
                    If _pcNum = 1 Then
                        _btns(x, y).Text = "X"
                    Else
                        _btns(x, y).Text = "O"
                    End If
                    Exit While
                End If

            End While

        End If

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

        _amountPlays += 1
        MaquineGame()

    End Sub

    ' Funcion para reiniciar juego
    Public Sub ResetGame(ByRef player As Windows.Forms.Label, ByRef pc As Windows.Forms.Label)

        ' Elimina el texto de todos los btn
        For i = 0 To 2
            For y = 0 To 2
                _btns(i, y).Text = ""
            Next
        Next

        PlayerPosition(player, pc)

        ' Reinicia el tablero
        _table = {{0, 0, 0}, {0, 0, 0}, {0, 0, 0}}

        _amountPlays = 0

    End Sub

End Module
