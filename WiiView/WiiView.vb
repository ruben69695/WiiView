Imports CefSharp
Imports CefSharp.WinForms

Public Class WiiView

    Public chromeBrowser As ChromiumWebBrowser

    Private Sub WiiView_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        InitializeChromium("https://www.google.es/maps")
    End Sub

    Private Sub WiiView_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        CefSharp.Cef.Shutdown()
    End Sub

    Private Sub InitializeChromium(url As String)
        Me.WindowState = WindowState.Maximized
        Dim settings As New CefSettings()
        CefSharp.Cef.Initialize(settings)
        chromeBrowser = New ChromiumWebBrowser(url)
        Me.Controls.Add(chromeBrowser)
        chromeBrowser.Dock = DockStyle.Fill
    End Sub

End Class
