<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class WiiView
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(WiiView))
        Me.trayIcon = New System.Windows.Forms.NotifyIcon(Me.components)
        Me.pbMaps = New System.Windows.Forms.PictureBox()
        Me.pbGuessr = New System.Windows.Forms.PictureBox()
        Me.trayMenu = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        CType(Me.pbMaps, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbGuessr, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.trayMenu.SuspendLayout()
        Me.SuspendLayout()
        '
        'trayIcon
        '
        Me.trayIcon.ContextMenuStrip = Me.trayMenu
        Me.trayIcon.Icon = CType(resources.GetObject("trayIcon.Icon"), System.Drawing.Icon)
        Me.trayIcon.Text = "trayIcon"
        Me.trayIcon.Visible = True
        '
        'pbMaps
        '
        Me.pbMaps.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.pbMaps.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.pbMaps.Image = CType(resources.GetObject("pbMaps.Image"), System.Drawing.Image)
        Me.pbMaps.Location = New System.Drawing.Point(52, 0)
        Me.pbMaps.Name = "pbMaps"
        Me.pbMaps.Size = New System.Drawing.Size(320, 500)
        Me.pbMaps.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pbMaps.TabIndex = 0
        Me.pbMaps.TabStop = False
        '
        'pbGuessr
        '
        Me.pbGuessr.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.pbGuessr.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.pbGuessr.Image = CType(resources.GetObject("pbGuessr.Image"), System.Drawing.Image)
        Me.pbGuessr.Location = New System.Drawing.Point(433, 0)
        Me.pbGuessr.Name = "pbGuessr"
        Me.pbGuessr.Size = New System.Drawing.Size(320, 500)
        Me.pbGuessr.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pbGuessr.TabIndex = 1
        Me.pbGuessr.TabStop = False
        '
        'trayMenu
        '
        Me.trayMenu.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ExitToolStripMenuItem})
        Me.trayMenu.Name = "trayMenu"
        Me.trayMenu.Size = New System.Drawing.Size(93, 26)
        '
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(92, 22)
        Me.ExitToolStripMenuItem.Text = "Exit"
        '
        'WiiView
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.PaleTurquoise
        Me.ClientSize = New System.Drawing.Size(800, 500)
        Me.Controls.Add(Me.pbGuessr)
        Me.Controls.Add(Me.pbMaps)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "WiiView"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "WiiView"
        Me.WindowState = System.Windows.Forms.FormWindowState.Minimized
        CType(Me.pbMaps, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbGuessr, System.ComponentModel.ISupportInitialize).EndInit()
        Me.trayMenu.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents trayIcon As NotifyIcon
    Friend WithEvents pbMaps As PictureBox
    Friend WithEvents pbGuessr As PictureBox
    Friend WithEvents trayMenu As ContextMenuStrip
    Friend WithEvents ExitToolStripMenuItem As ToolStripMenuItem
End Class
