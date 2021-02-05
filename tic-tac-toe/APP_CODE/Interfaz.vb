Module Interfaz

    ' Funcion que oculta elementos
    Private Sub HideComponent(ByRef element)

        element.Hide()

    End Sub

    ' Funciones que muestran Forms
    Public Sub ShowHomePage()

        HomePage.TopLevel = False
        HomePage.Size = New Size(Form1.PanelHome.Width, Form1.PanelHome.Height)
        HomePage.Show()

        Form1.PanelHome.Controls.Add(HomePage)

    End Sub

    Public Sub ShowGameTable()

        GameTable.TopLevel = False
        GameTable.Size = New Size(Form1.PanelHome.Width, Form1.PanelHome.Height)
        GameTable.Show()

        Form1.PanelHome.Controls.Add(GameTable)

    End Sub

    ' Funcion que ocultan Forms
    Public Sub HideHomePage()

        HomePage.Close()

    End Sub




End Module
