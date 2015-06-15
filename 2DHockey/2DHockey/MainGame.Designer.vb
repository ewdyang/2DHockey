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
        Me.RedAnimation = New System.Windows.Forms.ImageList(Me.components)
        Me.GreenAnimation = New System.Windows.Forms.ImageList(Me.components)
        Me.OrangeAnimation = New System.Windows.Forms.ImageList(Me.components)
        Me.WhiteAnimation = New System.Windows.Forms.ImageList(Me.components)
        Me.Pausebutton = New System.Windows.Forms.PictureBox()
        Me.resumebtn = New System.Windows.Forms.Button()
        Me.Quitbtn = New System.Windows.Forms.Button()
        Me.pauseMenuPanel = New System.Windows.Forms.Panel()
        CType(Me.userPlayer, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.puck, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.playerNet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.compNet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.compPlayer, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Pausebutton, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pauseMenuPanel.SuspendLayout()
        Me.SuspendLayout()
        '
        'tick
        '
        Me.tick.Interval = 40
        '
        'userPlayer
        '
        Me.userPlayer.BackColor = System.Drawing.Color.Transparent
        Me.userPlayer.Image = Global._2DHockey.My.Resources.Resources.BluePlayer1
        Me.userPlayer.Location = New System.Drawing.Point(255, 165)
        Me.userPlayer.Name = "userPlayer"
        Me.userPlayer.Size = New System.Drawing.Size(50, 50)
        Me.userPlayer.TabIndex = 0
        Me.userPlayer.TabStop = False
        '
        'puck
        '
        Me.puck.BackgroundImage = Global._2DHockey.My.Resources.Resources.Puck1
        Me.puck.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.puck.Location = New System.Drawing.Point(381, 185)
        Me.puck.Name = "puck"
        Me.puck.Size = New System.Drawing.Size(18, 10)
        Me.puck.TabIndex = 1
        Me.puck.TabStop = False
        '
        'playerNet
        '
        Me.playerNet.Image = Global._2DHockey.My.Resources.Resources.HockeyNet
        Me.playerNet.Location = New System.Drawing.Point(105, 148)
        Me.playerNet.Name = "playerNet"
        Me.playerNet.Size = New System.Drawing.Size(30, 80)
        Me.playerNet.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.playerNet.TabIndex = 2
        Me.playerNet.TabStop = False
        '
        'compNet
        '
        Me.compNet.Image = Global._2DHockey.My.Resources.Resources.HockeyNet
        Me.compNet.Location = New System.Drawing.Point(650, 148)
        Me.compNet.Name = "compNet"
        Me.compNet.Size = New System.Drawing.Size(30, 80)
        Me.compNet.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
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
        Me.compPlayer.BackColor = System.Drawing.Color.Transparent
        Me.compPlayer.Image = Global._2DHockey.My.Resources.Resources.GreenPlayer1
        Me.compPlayer.Location = New System.Drawing.Point(478, 165)
        Me.compPlayer.Name = "compPlayer"
        Me.compPlayer.Size = New System.Drawing.Size(50, 50)
        Me.compPlayer.TabIndex = 4
        Me.compPlayer.TabStop = False
        '
        'RedAnimation
        '
        Me.RedAnimation.ImageStream = CType(resources.GetObject("RedAnimation.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.RedAnimation.TransparentColor = System.Drawing.Color.Transparent
        Me.RedAnimation.Images.SetKeyName(0, "RedPlayer1.png")
        Me.RedAnimation.Images.SetKeyName(1, "RedPlayer2.png")
        '
        'GreenAnimation
        '
        Me.GreenAnimation.ImageStream = CType(resources.GetObject("GreenAnimation.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.GreenAnimation.TransparentColor = System.Drawing.Color.Transparent
        Me.GreenAnimation.Images.SetKeyName(0, "GreenPlayer1.png")
        Me.GreenAnimation.Images.SetKeyName(1, "GreenPlayer2.png")
        '
        'OrangeAnimation
        '
        Me.OrangeAnimation.ImageStream = CType(resources.GetObject("OrangeAnimation.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.OrangeAnimation.TransparentColor = System.Drawing.Color.Transparent
        Me.OrangeAnimation.Images.SetKeyName(0, "OrangePlayer1.png")
        Me.OrangeAnimation.Images.SetKeyName(1, "OrangePlayer2.png")
        '
        'WhiteAnimation
        '
        Me.WhiteAnimation.ImageStream = CType(resources.GetObject("WhiteAnimation.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.WhiteAnimation.TransparentColor = System.Drawing.Color.Transparent
        Me.WhiteAnimation.Images.SetKeyName(0, "WhitePlayer1.png")
        Me.WhiteAnimation.Images.SetKeyName(1, "WhitePlayer2.png")
        '
        'Pausebutton
        '
        Me.Pausebutton.BackColor = System.Drawing.Color.DarkBlue
        Me.Pausebutton.BackgroundImage = Global._2DHockey.My.Resources.Resources.mainGamePauseButtonImage
        Me.Pausebutton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.Pausebutton.Location = New System.Drawing.Point(738, 12)
        Me.Pausebutton.Name = "Pausebutton"
        Me.Pausebutton.Size = New System.Drawing.Size(38, 40)
        Me.Pausebutton.TabIndex = 5
        Me.Pausebutton.TabStop = False
        '
        'resumebtn
        '
        Me.resumebtn.BackColor = System.Drawing.Color.DarkBlue
        Me.resumebtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.resumebtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.resumebtn.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.resumebtn.Location = New System.Drawing.Point(15, 19)
        Me.resumebtn.Name = "resumebtn"
        Me.resumebtn.Size = New System.Drawing.Size(170, 35)
        Me.resumebtn.TabIndex = 6
        Me.resumebtn.Text = "Resume"
        Me.resumebtn.UseVisualStyleBackColor = False
        '
        'Quitbtn
        '
        Me.Quitbtn.BackColor = System.Drawing.Color.DarkBlue
        Me.Quitbtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.Quitbtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Quitbtn.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Quitbtn.Location = New System.Drawing.Point(15, 92)
        Me.Quitbtn.Name = "Quitbtn"
        Me.Quitbtn.Size = New System.Drawing.Size(170, 35)
        Me.Quitbtn.TabIndex = 7
        Me.Quitbtn.Text = "Quit"
        Me.Quitbtn.UseVisualStyleBackColor = False
        '
        'pauseMenuPanel
        '
        Me.pauseMenuPanel.Controls.Add(Me.resumebtn)
        Me.pauseMenuPanel.Controls.Add(Me.Quitbtn)
        Me.pauseMenuPanel.Location = New System.Drawing.Point(292, 105)
        Me.pauseMenuPanel.Name = "pauseMenuPanel"
        Me.pauseMenuPanel.Size = New System.Drawing.Size(200, 150)
        Me.pauseMenuPanel.TabIndex = 8
        Me.pauseMenuPanel.Visible = False
        '
        'MainGame
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global._2DHockey.My.Resources.Resources.Hockeyrink
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(784, 361)
        Me.ControlBox = False
        Me.Controls.Add(Me.pauseMenuPanel)
        Me.Controls.Add(Me.Pausebutton)
        Me.Controls.Add(Me.compPlayer)
        Me.Controls.Add(Me.compNet)
        Me.Controls.Add(Me.playerNet)
        Me.Controls.Add(Me.puck)
        Me.Controls.Add(Me.userPlayer)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "MainGame"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "2D Hockey"
        CType(Me.userPlayer, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.puck, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.playerNet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.compNet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.compPlayer, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Pausebutton, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pauseMenuPanel.ResumeLayout(False)
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
    Friend WithEvents RedAnimation As System.Windows.Forms.ImageList
    Friend WithEvents GreenAnimation As System.Windows.Forms.ImageList
    Friend WithEvents OrangeAnimation As System.Windows.Forms.ImageList
    Friend WithEvents WhiteAnimation As System.Windows.Forms.ImageList
    Friend WithEvents Pausebutton As System.Windows.Forms.PictureBox
    Friend WithEvents resumebtn As System.Windows.Forms.Button
    Friend WithEvents Quitbtn As System.Windows.Forms.Button
    Friend WithEvents pauseMenuPanel As System.Windows.Forms.Panel

End Class
