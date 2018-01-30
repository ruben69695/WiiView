Imports CefSharp
Imports CefSharp.WinForms

Public Class WiiView

    Public chromeBrowser As ChromiumWebBrowser

    Private Sub WiiView_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

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

End Class
