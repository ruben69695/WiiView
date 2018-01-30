Imports System.Runtime.InteropServices

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

    <Flags()>
    Enum MouseEventFlag As UInteger
        Move = 1
        LeftDown = 2
        LeftUp = 4
        RightDown = 8
        RightUp = 16
        MiddleDown = 32
        MiddleUp = 64
        XDown = 128
        XUp = 256
        Wheel = 2048
        VirtualDesk = 16384
        Absolute = 32768
    End Enum

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

    <DllImport("user32.dll")>
    Public Shared Function SetCursorPos(ByVal X As Integer, ByVal Y As Integer) As Boolean
    End Function

    <DllImport("user32.dll")>
    Private Shared Sub mouse_event(ByVal flags As MouseEventFlag, ByVal dx As Integer, ByVal dy As Integer, ByVal data As UInteger, ByVal extraInfo As UIntPtr)
    End Sub

    Public Shared Sub MouseLeftDown()
        mouse_event(MouseEventFlag.LeftDown, 0, 0, 0, UIntPtr.Zero)
    End Sub
End Class
