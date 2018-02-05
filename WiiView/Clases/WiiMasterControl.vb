Public Class WiiMasterControl
    Protected A As Boolean = False
    Protected B As Boolean = False
    Protected Left As Boolean = False
    Protected Right As Boolean = False
    Protected Up As Boolean = False
    Protected Down As Boolean = False
    Protected Plus As Boolean = False
    Protected Dash As Boolean = False
    Protected Home As Boolean = False
    Protected Power As Boolean = False
    Protected One As Boolean = False
    Protected Two As Boolean = False

    Protected Perfil As String = "P1"

    Public Sub CheckPowerClicked(currentState As Boolean)
        If currentState Then
            Power = True
            'TODO Función para minimizar la aplicación
            Power = False
        End If
    End Sub

    Public Sub CheckACliked(currentState As Boolean)
        If A = True AndAlso currentState = False Then
            A = False
            ' Función Xavi LeftUp
            ClApiDll2.ClApi.MouseLeftUp()
        ElseIf A = False AndAlso currentState = True Then
            A = True
            ' Función Xavi LeftDown
            ClApiDll2.ClApi.MouseLeftDown()
        End If
    End Sub

    Public Sub CheckBClicked(currentState As Boolean)
        If B = True AndAlso currentState = False Then
            B = False
            ' Función Xavi RightUp
            ' Como el click derecho nunca se mantiene presionado no hace falta hacer el keyUp/keyDown, solo haciendo DoRightClick() funciona
        ElseIf B = False AndAlso currentState = True Then
            B = True
            ' Función Xavi RightDown
            ClApiDll2.ClApi.DoRightClick()
        End If
    End Sub

    Public Sub CheckLeftClicked(currentState As Boolean)
        If Left = True AndAlso currentState = False Then
            Left = False
        ElseIf Left = False AndAlso currentState = True Then
            Left = True
            ' Función Xavi KeyLeft
            ClApiDll2.ClApi.ClickKeyLeft()
        End If
    End Sub

    Public Sub CheckRightClicked(currentState As Boolean)
        If Right = True AndAlso currentState = False Then
            Right = False
        ElseIf Right = False AndAlso currentState = True Then
            Right = True
            ' Función Xavi KeyRight
            ClApiDll2.ClApi.ClickKeyRight()
        End If
    End Sub

    Public Sub CheckUpClicked(currentState As Boolean)
        If Up = True AndAlso currentState = False Then
            Up = False
        ElseIf Up = False AndAlso currentState = True Then
            ' Función Xavi KeyUp
            Up = True
            ClApiDll2.ClApi.ClickKeyUp()
        End If
    End Sub

    Public Sub CheckDownClicked(currentState As Boolean)
        If Down = True AndAlso currentState = False Then
            Down = False
        ElseIf Down = False AndAlso currentState = True Then
            ' Función Xavi KeyDown
            Down = True
            ClApiDll2.ClApi.ClickKeyDown()
        End If
    End Sub

    Public Sub CheckPlusClicked(currentState As Boolean)
        If Perfil.Equals("P1") Then
            If Plus = True AndAlso currentState = False Then
                Plus = False
            ElseIf Plus = False AndAlso currentState = True Then
                ' Función Xavi KeyPlus
                Plus = True
                ClApiDll2.ClApi.ClickKeyAdd()
            End If
        Else
            'TODO Llamar a función para modificar la sensibilidad
        End If

    End Sub

    Public Sub CheckDashClicked(currentState As Boolean)
        If Perfil.Equals("P1") Then
            If Dash = True AndAlso currentState = False Then
                Dash = False
            ElseIf Dash = False AndAlso currentState = True Then
                ' Función Xavi KeyDash
                Dash = True
                ClApiDll2.ClApi.ClickKeySubtract()
            End If
        Else
            'TODO Llamar a función para modificar la sensibilidad
        End If
    End Sub

    Public Sub CheckHomeClicked(currentState As Boolean)
        If Perfil.Equals("P1") Then
            If Home = True AndAlso currentState = False Then
                Home = False
            ElseIf Home = False AndAlso currentState = True Then
                ' Función Xavi KeyHome
                Home = True
                'TODO Función WheelClick en la dll
                ClApiDll2.ClApi.DoWheelClick()
            End If
        Else
            'TODO Llamar a función para abrir el FrmMain y que nos permita seeleccionar Street o Geo
        End If
    End Sub

    Public Sub CheckOneClicked(currentState As Boolean)
        If currentState Then
            Perfil = "P1"
        End If
    End Sub

    Public Sub CheckTwoClicked(currentState As Boolean)
        If currentState Then
            Perfil = "P2"
        End If
    End Sub

End Class
