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
        Me.blueAnimation = New System.Windows.Forms.ImageList(Me.components)
        Me.FrameTimer = New System.Windows.Forms.Timer(Me.components)
        Me.redAnimation = New System.Windows.Forms.ImageList(Me.components)
        Me.greenAnimation = New System.Windows.Forms.ImageList(Me.components)
        Me.orangeAnimation = New System.Windows.Forms.ImageList(Me.components)
        Me.whiteAnimation = New System.Windows.Forms.ImageList(Me.components)
        Me.goalieColours = New System.Windows.Forms.ImageList(Me.components)
        Me.Pausebutton = New System.Windows.Forms.PictureBox()
        Me.scoreboard = New System.Windows.Forms.PictureBox()
        Me.team2score = New System.Windows.Forms.Label()
        Me.team1score = New System.Windows.Forms.Label()
        Me.count = New System.Windows.Forms.Timer(Me.components)
        Me.wintimer = New System.Windows.Forms.Timer(Me.components)
        Me.compPlayer = New System.Windows.Forms.PictureBox()
        Me.userPlayer = New System.Windows.Forms.PictureBox()
        Me.userGoalie = New System.Windows.Forms.PictureBox()
        Me.compGoalie = New System.Windows.Forms.PictureBox()
        Me.userNet = New System.Windows.Forms.PictureBox()
        Me.countdownlbl = New System.Windows.Forms.Label()
        Me.compNet = New System.Windows.Forms.PictureBox()
        Me.puck = New System.Windows.Forms.PictureBox()
        Me.pauseMenuPanel = New System.Windows.Forms.Panel()
        Me.resumebtn = New System.Windows.Forms.Button()
        Me.Quitbtn = New System.Windows.Forms.Button()
        Me.Golbl = New System.Windows.Forms.Label()
        Me.Winlbl = New System.Windows.Forms.Label()
        Me.hockeyrink = New System.Windows.Forms.PictureBox()
        Me.countdownpanel = New System.Windows.Forms.Panel()
        Me.Buzzertime = New System.Windows.Forms.Timer(Me.components)
        CType(Me.Pausebutton, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.scoreboard, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.compPlayer, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.userPlayer, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.userGoalie, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.compGoalie, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.userNet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.compNet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.puck, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pauseMenuPanel.SuspendLayout()
        CType(Me.hockeyrink, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.countdownpanel.SuspendLayout()
        Me.SuspendLayout()
        '
        'tick
        '
        Me.tick.Interval = 40
        '
        'blueAnimation
        '
        Me.blueAnimation.ImageStream = CType(resources.GetObject("blueAnimation.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.blueAnimation.TransparentColor = System.Drawing.Color.Transparent
        Me.blueAnimation.Images.SetKeyName(0, "BluePlayer1.png")
        Me.blueAnimation.Images.SetKeyName(1, "BluePlayer2.png")
        '
        'FrameTimer
        '
        Me.FrameTimer.Interval = 333
        '
        'redAnimation
        '
        Me.redAnimation.ImageStream = CType(resources.GetObject("redAnimation.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.redAnimation.TransparentColor = System.Drawing.Color.Transparent
        Me.redAnimation.Images.SetKeyName(0, "RedPlayer1.png")
        Me.redAnimation.Images.SetKeyName(1, "RedPlayer2.png")
        '
        'greenAnimation
        '
        Me.greenAnimation.ImageStream = CType(resources.GetObject("greenAnimation.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.greenAnimation.TransparentColor = System.Drawing.Color.Transparent
        Me.greenAnimation.Images.SetKeyName(0, "GreenPlayer1.png")
        Me.greenAnimation.Images.SetKeyName(1, "GreenPlayer2.png")
        '
        'orangeAnimation
        '
        Me.orangeAnimation.ImageStream = CType(resources.GetObject("orangeAnimation.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.orangeAnimation.TransparentColor = System.Drawing.Color.Transparent
        Me.orangeAnimation.Images.SetKeyName(0, "OrangePlayer1.png")
        Me.orangeAnimation.Images.SetKeyName(1, "OrangePlayer2.png")
        '
        'whiteAnimation
        '
        Me.whiteAnimation.ImageStream = CType(resources.GetObject("whiteAnimation.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.whiteAnimation.TransparentColor = System.Drawing.Color.Transparent
        Me.whiteAnimation.Images.SetKeyName(0, "WhitePlayer1.png")
        Me.whiteAnimation.Images.SetKeyName(1, "WhitePlayer2.png")
        '
        'goalieColours
        '
        Me.goalieColours.ImageStream = CType(resources.GetObject("goalieColours.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.goalieColours.TransparentColor = System.Drawing.Color.Transparent
        Me.goalieColours.Images.SetKeyName(0, "Blue Goalie1.png")
        Me.goalieColours.Images.SetKeyName(1, "Green Goalie1.png")
        Me.goalieColours.Images.SetKeyName(2, "Orange Goalie1.png")
        Me.goalieColours.Images.SetKeyName(3, "Red Goalie1.png")
        Me.goalieColours.Images.SetKeyName(4, "White Goalie1.png")
        '
        'Pausebutton
        '
        Me.Pausebutton.BackColor = System.Drawing.Color.DarkBlue
        Me.Pausebutton.BackgroundImage = Global._2DHockey.My.Resources.Resources.mainGamePauseButtonImage
        Me.Pausebutton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.Pausebutton.Location = New System.Drawing.Point(734, 12)
        Me.Pausebutton.Name = "Pausebutton"
        Me.Pausebutton.Size = New System.Drawing.Size(38, 40)
        Me.Pausebutton.TabIndex = 5
        Me.Pausebutton.TabStop = False
        '
        'scoreboard
        '
        Me.scoreboard.BackColor = System.Drawing.Color.Transparent
        Me.scoreboard.BackgroundImage = Global._2DHockey.My.Resources.Resources.Scoreboard
        Me.scoreboard.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.scoreboard.Location = New System.Drawing.Point(236, 369)
        Me.scoreboard.Name = "scoreboard"
        Me.scoreboard.Size = New System.Drawing.Size(312, 139)
        Me.scoreboard.TabIndex = 14
        Me.scoreboard.TabStop = False
        '
        'team2score
        '
        Me.team2score.AutoSize = True
        Me.team2score.BackColor = System.Drawing.Color.Black
        Me.team2score.Font = New System.Drawing.Font("Microsoft Sans Serif", 33.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.team2score.ForeColor = System.Drawing.Color.Gold
        Me.team2score.Location = New System.Drawing.Point(446, 435)
        Me.team2score.Name = "team2score"
        Me.team2score.Size = New System.Drawing.Size(48, 52)
        Me.team2score.TabIndex = 12
        Me.team2score.Text = "0"
        '
        'team1score
        '
        Me.team1score.AutoSize = True
        Me.team1score.BackColor = System.Drawing.Color.Black
        Me.team1score.Font = New System.Drawing.Font("Microsoft Sans Serif", 33.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.team1score.ForeColor = System.Drawing.Color.Gold
        Me.team1score.Location = New System.Drawing.Point(293, 435)
        Me.team1score.Name = "team1score"
        Me.team1score.Size = New System.Drawing.Size(48, 52)
        Me.team1score.TabIndex = 11
        Me.team1score.Text = "0"
        '
        'count
        '
        Me.count.Interval = 1000
        '
        'wintimer
        '
        Me.wintimer.Interval = 1000
        '
        'compPlayer
        '
        Me.compPlayer.BackColor = System.Drawing.Color.WhiteSmoke
        Me.compPlayer.Image = Global._2DHockey.My.Resources.Resources.GreenPlayer1
        Me.compPlayer.Location = New System.Drawing.Point(484, 167)
        Me.compPlayer.Name = "compPlayer"
        Me.compPlayer.Size = New System.Drawing.Size(50, 50)
        Me.compPlayer.TabIndex = 4
        Me.compPlayer.TabStop = False
        '
        'userPlayer
        '
        Me.userPlayer.BackColor = System.Drawing.Color.WhiteSmoke
        Me.userPlayer.Image = Global._2DHockey.My.Resources.Resources.BluePlayer1
        Me.userPlayer.Location = New System.Drawing.Point(285, 164)
        Me.userPlayer.Name = "userPlayer"
        Me.userPlayer.Size = New System.Drawing.Size(50, 50)
        Me.userPlayer.TabIndex = 0
        Me.userPlayer.TabStop = False
        '
        'userGoalie
        '
        Me.userGoalie.BackColor = System.Drawing.Color.WhiteSmoke
        Me.userGoalie.Image = Global._2DHockey.My.Resources.Resources.Blue_Goalie1
        Me.userGoalie.Location = New System.Drawing.Point(137, 167)
        Me.userGoalie.Name = "userGoalie"
        Me.userGoalie.Size = New System.Drawing.Size(50, 47)
        Me.userGoalie.TabIndex = 9
        Me.userGoalie.TabStop = False
        '
        'compGoalie
        '
        Me.compGoalie.BackColor = System.Drawing.Color.WhiteSmoke
        Me.compGoalie.Image = Global._2DHockey.My.Resources.Resources.Green_Goalie1
        Me.compGoalie.Location = New System.Drawing.Point(593, 167)
        Me.compGoalie.Name = "compGoalie"
        Me.compGoalie.Size = New System.Drawing.Size(50, 47)
        Me.compGoalie.TabIndex = 10
        Me.compGoalie.TabStop = False
        '
        'userNet
        '
        Me.userNet.Image = Global._2DHockey.My.Resources.Resources.HockeyNet
        Me.userNet.Location = New System.Drawing.Point(101, 149)
        Me.userNet.Name = "userNet"
        Me.userNet.Size = New System.Drawing.Size(30, 80)
        Me.userNet.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.userNet.TabIndex = 2
        Me.userNet.TabStop = False
        '
        'countdownlbl
        '
        Me.countdownlbl.AutoSize = True
        Me.countdownlbl.BackColor = System.Drawing.Color.Transparent
        Me.countdownlbl.Font = New System.Drawing.Font("Microsoft Sans Serif", 48.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.countdownlbl.ForeColor = System.Drawing.SystemColors.ControlText
        Me.countdownlbl.Location = New System.Drawing.Point(22, 18)
        Me.countdownlbl.Name = "countdownlbl"
        Me.countdownlbl.Size = New System.Drawing.Size(68, 73)
        Me.countdownlbl.TabIndex = 15
        Me.countdownlbl.Text = "3"
        '
        'compNet
        '
        Me.compNet.Image = Global._2DHockey.My.Resources.Resources.HockeyNet
        Me.compNet.Location = New System.Drawing.Point(649, 149)
        Me.compNet.Name = "compNet"
        Me.compNet.Size = New System.Drawing.Size(30, 80)
        Me.compNet.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.compNet.TabIndex = 3
        Me.compNet.TabStop = False
        '
        'puck
        '
        Me.puck.BackgroundImage = Global._2DHockey.My.Resources.Resources.Puck1
        Me.puck.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.puck.Location = New System.Drawing.Point(382, 190)
        Me.puck.Name = "puck"
        Me.puck.Size = New System.Drawing.Size(18, 10)
        Me.puck.TabIndex = 1
        Me.puck.TabStop = False
        '
        'pauseMenuPanel
        '
        Me.pauseMenuPanel.Controls.Add(Me.resumebtn)
        Me.pauseMenuPanel.Controls.Add(Me.Quitbtn)
        Me.pauseMenuPanel.Location = New System.Drawing.Point(292, 113)
        Me.pauseMenuPanel.Name = "pauseMenuPanel"
        Me.pauseMenuPanel.Size = New System.Drawing.Size(200, 150)
        Me.pauseMenuPanel.TabIndex = 8
        Me.pauseMenuPanel.Visible = False
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
        'Golbl
        '
        Me.Golbl.AutoSize = True
        Me.Golbl.BackColor = System.Drawing.Color.Transparent
        Me.Golbl.Font = New System.Drawing.Font("Microsoft Sans Serif", 48.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Golbl.ForeColor = System.Drawing.Color.DarkBlue
        Me.Golbl.Location = New System.Drawing.Point(7, 18)
        Me.Golbl.Name = "Golbl"
        Me.Golbl.Size = New System.Drawing.Size(118, 73)
        Me.Golbl.TabIndex = 16
        Me.Golbl.Text = "Go"
        '
        'Winlbl
        '
        Me.Winlbl.AutoSize = True
        Me.Winlbl.BackColor = System.Drawing.Color.White
        Me.Winlbl.Font = New System.Drawing.Font("Microsoft Sans Serif", 71.99999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Winlbl.ForeColor = System.Drawing.Color.DarkBlue
        Me.Winlbl.Location = New System.Drawing.Point(45, 131)
        Me.Winlbl.Name = "Winlbl"
        Me.Winlbl.Size = New System.Drawing.Size(695, 108)
        Me.Winlbl.TabIndex = 17
        Me.Winlbl.Text = "TEAM 1 WINS!"
        '
        'hockeyrink
        '
        Me.hockeyrink.BackgroundImage = Global._2DHockey.My.Resources.Resources.Hockeyrink
        Me.hockeyrink.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.hockeyrink.Location = New System.Drawing.Point(-1, 1)
        Me.hockeyrink.Name = "hockeyrink"
        Me.hockeyrink.Size = New System.Drawing.Size(784, 361)
        Me.hockeyrink.TabIndex = 18
        Me.hockeyrink.TabStop = False
        '
        'countdownpanel
        '
        Me.countdownpanel.BackColor = System.Drawing.Color.White
        Me.countdownpanel.Controls.Add(Me.countdownlbl)
        Me.countdownpanel.Controls.Add(Me.Golbl)
        Me.countdownpanel.Location = New System.Drawing.Point(338, 138)
        Me.countdownpanel.Name = "countdownpanel"
        Me.countdownpanel.Size = New System.Drawing.Size(108, 100)
        Me.countdownpanel.TabIndex = 19
        '
        'Buzzertime
        '
        Me.Buzzertime.Interval = 1000
        '
        'MainGame
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.BackgroundImage = Global._2DHockey.My.Resources.Resources.Background_2
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(784, 509)
        Me.ControlBox = False
        Me.Controls.Add(Me.pauseMenuPanel)
        Me.Controls.Add(Me.countdownpanel)
        Me.Controls.Add(Me.Winlbl)
        Me.Controls.Add(Me.compNet)
        Me.Controls.Add(Me.puck)
        Me.Controls.Add(Me.compGoalie)
        Me.Controls.Add(Me.compPlayer)
        Me.Controls.Add(Me.team2score)
        Me.Controls.Add(Me.team1score)
        Me.Controls.Add(Me.Pausebutton)
        Me.Controls.Add(Me.scoreboard)
        Me.Controls.Add(Me.userNet)
        Me.Controls.Add(Me.userPlayer)
        Me.Controls.Add(Me.userGoalie)
        Me.Controls.Add(Me.hockeyrink)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "MainGame"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "2D Hockey"
        CType(Me.Pausebutton, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.scoreboard, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.compPlayer, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.userPlayer, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.userGoalie, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.compGoalie, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.userNet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.compNet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.puck, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pauseMenuPanel.ResumeLayout(False)
        CType(Me.hockeyrink, System.ComponentModel.ISupportInitialize).EndInit()
        Me.countdownpanel.ResumeLayout(False)
        Me.countdownpanel.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents tick As System.Windows.Forms.Timer
    Friend WithEvents blueAnimation As System.Windows.Forms.ImageList
    Friend WithEvents FrameTimer As System.Windows.Forms.Timer
    Friend WithEvents redAnimation As System.Windows.Forms.ImageList
    Friend WithEvents greenAnimation As System.Windows.Forms.ImageList
    Friend WithEvents orangeAnimation As System.Windows.Forms.ImageList
    Friend WithEvents whiteAnimation As System.Windows.Forms.ImageList
    Friend WithEvents Pausebutton As System.Windows.Forms.PictureBox
    Friend WithEvents goalieColours As System.Windows.Forms.ImageList
    Friend WithEvents scoreboard As System.Windows.Forms.PictureBox
    Friend WithEvents team2score As System.Windows.Forms.Label
    Friend WithEvents team1score As System.Windows.Forms.Label
    Friend WithEvents count As System.Windows.Forms.Timer
    Friend WithEvents wintimer As System.Windows.Forms.Timer
    Friend WithEvents compPlayer As System.Windows.Forms.PictureBox
    Friend WithEvents userPlayer As System.Windows.Forms.PictureBox
    Friend WithEvents userGoalie As System.Windows.Forms.PictureBox
    Friend WithEvents compGoalie As System.Windows.Forms.PictureBox
    Friend WithEvents userNet As System.Windows.Forms.PictureBox
    Friend WithEvents countdownlbl As System.Windows.Forms.Label
    Friend WithEvents compNet As System.Windows.Forms.PictureBox
    Friend WithEvents puck As System.Windows.Forms.PictureBox
    Friend WithEvents pauseMenuPanel As System.Windows.Forms.Panel
    Friend WithEvents resumebtn As System.Windows.Forms.Button
    Friend WithEvents Quitbtn As System.Windows.Forms.Button
    Friend WithEvents Golbl As System.Windows.Forms.Label
    Friend WithEvents Winlbl As System.Windows.Forms.Label
    Friend WithEvents hockeyrink As System.Windows.Forms.PictureBox
    Friend WithEvents countdownpanel As System.Windows.Forms.Panel
    Friend WithEvents Buzzertime As System.Windows.Forms.Timer

End Class