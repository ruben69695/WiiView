Imports CefSharp
Imports CefSharp.WinForms
Imports WiimoteLib

Public Class WiiView

    Public chromeBrowser As ChromiumWebBrowser
    Private mWC As WiimoteCollection
    Private controllerConnected As Boolean = False
    Private controllerConfigured As Boolean = False
    Private prevControllerConnected As Boolean = True
    Private Delegate Sub UpdateWiimoteStateDelegate(ByVal args As WiimoteChangedEventArgs)
    Private masterController As New WiiMasterControl()

    Private Sub WiiView_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        CefSharp.Cef.Shutdown()
    End Sub

    Public Sub UpdateState(ByVal args As WiimoteChangedEventArgs)
        BeginInvoke(New UpdateWiimoteStateDelegate(AddressOf UpdateWiimoteChanged), args)
    End Sub

    Private Sub UpdateWiimoteChanged(args As WiimoteChangedEventArgs)


    End Sub

    Private Sub InitializeChromium(url As String)
        pbGuessr.Visible = False
        pbMaps.Visible = False

        Me.WindowState = WindowState.Maximized

        Dim settings As New CefSettings()
        CefSharp.Cef.Initialize(settings)
        chromeBrowser = New ChromiumWebBrowser(url)
        Me.Controls.Add(chromeBrowser)
        chromeBrowser.Dock = DockStyle.Fill
    End Sub

    Private Sub pbMaps_Click(sender As Object, e As EventArgs) Handles pbMaps.Click
        InitializeChromium("https://www.google.es/maps")
    End Sub

    Private Sub pbGuessr_Click(sender As Object, e As EventArgs) Handles pbGuessr.Click
        InitializeChromium("https://geoguessr.com/")
    End Sub

    Private Sub trayIcon_DoubleClick(sender As Object, e As EventArgs) Handles trayIcon.DoubleClick
        If WindowState = WindowState.Minimized Then
            WindowState = WindowState.Normal
        Else
            WindowState = WindowState.Minimized
        End If
    End Sub

    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        Close()
    End Sub

    Private Sub WiiView_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CheckControllers()
    End Sub

    Private Sub CheckControllers()
        controllerConnected = IsControllerConnected()

        If Not controllerConnected Then
            If Not prevControllerConnected = controllerConnected Then
                trayIcon.BalloonTipTitle = "WiiView"
                trayIcon.BalloonTipText = "No controllers connected"
                trayIcon.ShowBalloonTip(3000)
            End If
        ElseIf Not controllerConfigured Then
            For Each wm As Wiimote In mWC
                AddHandler wm.WiimoteChanged, AddressOf wm_WiimoteChanged
                wm.Connect()
            Next
            controllerConfigured = True
        End If

        prevControllerConnected = controllerConnected
    End Sub

    Private Sub wm_WiimoteChanged(sender As Object, e As WiimoteChangedEventArgs)
        Dim ws As WiimoteState = e.WiimoteState

        Console.WriteLine(ws.ToString())
        If ws.ButtonState.A OrElse Not ws.ButtonState.A Then
            masterController.CheckACliked(ws.ButtonState.A)
        End If
        If ws.ButtonState.B OrElse Not ws.ButtonState.B Then
            masterController.CheckBClicked(ws.ButtonState.B)
        End If
        If ws.ButtonState.Home OrElse Not ws.ButtonState.Home Then
            masterController.CheckHomeClicked(ws.ButtonState.Home)
        End If
        If ws.ButtonState.Down OrElse Not ws.ButtonState.Down Then
            masterController.CheckDownClicked(ws.ButtonState.Down)
        End If
        If ws.ButtonState.Up OrElse Not ws.ButtonState.Up Then
            masterController.CheckUpClicked(ws.ButtonState.Up)
        End If
        If ws.ButtonState.Left OrElse Not ws.ButtonState.Left Then
            masterController.CheckLeftClicked(ws.ButtonState.Left)
        End If
        If ws.ButtonState.Right OrElse Not ws.ButtonState.Right Then
            masterController.CheckRightClicked(ws.ButtonState.Right)
        End If
        If ws.ButtonState.Plus OrElse Not ws.ButtonState.Plus Then
            masterController.CheckPlusClicked(ws.ButtonState.Plus)
        End If
        If ws.ButtonState.Minus OrElse Not ws.ButtonState.Minus Then
            masterController.CheckDashClicked(ws.ButtonState.Minus)
        End If
        If ws.ButtonState.One OrElse Not ws.ButtonState.One Then
            masterController.CheckOneClicked(ws.ButtonState.One)
        End If
        If ws.ButtonState.Two OrElse Not ws.ButtonState.Two Then
            masterController.CheckTwoClicked(ws.ButtonState.Two)
        End If
    End Sub

    Private Function IsControllerConnected() As Boolean
        mWC = New WiimoteCollection()
        Dim index As Integer = 1

        Try
            mWC.FindAllWiimotes()
            Return True
        Catch ex As Exception
            Return False
        End Try
    End Function

    Private Sub tmCheckController_Tick(sender As Object, e As EventArgs) Handles tmCheckController.Tick
        CheckControllers()
    End Sub

End Class
