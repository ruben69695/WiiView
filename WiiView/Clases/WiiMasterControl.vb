Imports ClApi

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

    Public Sub CheckPowerClicked(currentState As Boolean)
        If currentState Then
            Power = True
            ' Función para minimizar la aplicación
            Power = False
        End If
    End Sub

    Protected Sub CheckACliked(currentState As Boolean)
        If A = True AndAlso currentState = False Then
            A = False
            ' Función Xavi LeftUp

        ElseIf A = False AndAlso currentState = True Then
            A = True
            ' Función Xavi LeftDown
        End If
    End Sub

    Protected Sub CheckBClicked(currentState As Boolean)
        If B = True AndAlso currentState = False Then
            B = False
            ' Función Xavi RightUp
        ElseIf B = False AndAlso currentState = True Then
            B = True
            ' Función Xavi RightDown
        End If
    End Sub
End Class
