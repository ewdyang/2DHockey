<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MainGame
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MainGame))
        Me.tick = New System.Windows.Forms.Timer(Me.components)
        Me.userPlayer = New System.Windows.Forms.PictureBox()
        Me.puck = New System.Windows.Forms.PictureBox()
        Me.playerNet = New System.Windows.Forms.PictureBox()
        Me.compNet = New System.Windows.Forms.PictureBox()
        Me.PlayerAnimationList = New System.Windows.Forms.ImageList(Me.components)
        Me.FrameTimer = New System.Windows.Forms.Timer(Me.components)
        Me.compPlayer = New System.Windows.Forms.PictureBox()
        CType(Me.userPlayer, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.puck, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.playerNet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.compNet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.compPlayer, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'tick
        '
        Me.tick.Enabled = True
        Me.tick.Interval = 40
        '
        'userPlayer
        '
<<<<<<< HEAD
        Me.userPlayer.Location = New System.Drawing.Point(200, 150)
        Me.userPlayer.Name = "userPlayer"
        Me.userPlayer.Size = New System.Drawing.Size(50, 50)
        Me.userPlayer.TabIndex = 0
        Me.userPlayer.TabStop = False
        '
        'puck
        '
        Me.puck.Location = New System.Drawing.Point(350, 150)
=======
        Me.player.Location = New System.Drawing.Point(139, 199)
        Me.player.Name = "player"
        Me.player.Size = New System.Drawing.Size(50, 50)
        Me.player.TabIndex = 0
        Me.player.TabStop = False
        '
        'puck
        '
        Me.puck.Location = New System.Drawing.Point(651, 316)
>>>>>>> origin/master
        Me.puck.Name = "puck"
        Me.puck.Size = New System.Drawing.Size(50, 50)
        Me.puck.TabIndex = 1
        Me.puck.TabStop = False
        '
        'playerNet
        '
        Me.playerNet.Location = New System.Drawing.Point(12, 282)
        Me.playerNet.Name = "playerNet"
        Me.playerNet.Size = New System.Drawing.Size(50, 100)
        Me.playerNet.TabIndex = 2
        Me.playerNet.TabStop = False
        '
        'compNet
        '
        Me.compNet.Location = New System.Drawing.Point(707, 249)
        Me.compNet.Name = "compNet"
        Me.compNet.Size = New System.Drawing.Size(50, 100)
        Me.compNet.TabIndex = 3
        Me.compNet.TabStop = False
        '
        'PlayerAnimationList
        '
        Me.PlayerAnimationList.ImageStream = CType(resources.GetObject("PlayerAnimationList.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.PlayerAnimationList.TransparentColor = System.Drawing.Color.Transparent
        Me.PlayerAnimationList.Images.SetKeyName(0, "BluePlayer1.png")
        Me.PlayerAnimationList.Images.SetKeyName(1, "BluePlayer2.png")
        '
        'FrameTimer
        '
        Me.FrameTimer.Interval = 333
        '
        'compPlayer
        '
        Me.compPlayer.Location = New System.Drawing.Point(500, 150)
        Me.compPlayer.Name = "compPlayer"
        Me.compPlayer.Size = New System.Drawing.Size(50, 50)
        Me.compPlayer.TabIndex = 4
        Me.compPlayer.TabStop = False
        '
        'MainGame
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(784, 361)
        Me.Controls.Add(Me.compPlayer)
        Me.Controls.Add(Me.compNet)
        Me.Controls.Add(Me.playerNet)
        Me.Controls.Add(Me.puck)
        Me.Controls.Add(Me.userPlayer)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "MainGame"
        Me.Text = "2D Hockey"
        CType(Me.userPlayer, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.puck, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.playerNet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.compNet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.compPlayer, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents tick As System.Windows.Forms.Timer
    Friend WithEvents userPlayer As System.Windows.Forms.PictureBox
    Friend WithEvents puck As System.Windows.Forms.PictureBox
    Friend WithEvents playerNet As System.Windows.Forms.PictureBox
    Friend WithEvents compNet As System.Windows.Forms.PictureBox
    Friend WithEvents PlayerAnimationList As System.Windows.Forms.ImageList
    Friend WithEvents FrameTimer As System.Windows.Forms.Timer
    Friend WithEvents compPlayer As System.Windows.Forms.PictureBox

End Class
