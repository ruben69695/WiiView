Imports CefSharp
Imports CefSharp.WinForms
Imports WiimoteLib

Public Class WiiView

    Public chromeBrowser As ChromiumWebBrowser
    Private mWC As WiimoteCollection
    Private controllerConnected As Boolean = False
    Private prevControllerConnected As Boolean = True

    Private Sub WiiView_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        CefSharp.Cef.Shutdown()
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
        Else

        End If

        prevControllerConnected = controllerConnected
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
