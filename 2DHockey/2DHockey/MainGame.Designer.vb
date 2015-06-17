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
        Me.rUserScoreboard = New System.Windows.Forms.Label()
        Me.lUserScoreboard = New System.Windows.Forms.Label()
        Me.count = New System.Windows.Forms.Timer(Me.components)
        Me.wintimer = New System.Windows.Forms.Timer(Me.components)
        Me.rUserPlayer = New System.Windows.Forms.PictureBox()
        Me.lUserPlayer = New System.Windows.Forms.PictureBox()
        Me.lUserGoalie = New System.Windows.Forms.PictureBox()
        Me.rUserGoalie = New System.Windows.Forms.PictureBox()
        Me.lUserNet = New System.Windows.Forms.PictureBox()
        Me.countdownlbl = New System.Windows.Forms.Label()
        Me.rUserNet = New System.Windows.Forms.PictureBox()
        Me.puck = New System.Windows.Forms.PictureBox()
        Me.pauseMenuPanel = New System.Windows.Forms.Panel()
        Me.resumebtn = New System.Windows.Forms.Button()
        Me.Quitbtn = New System.Windows.Forms.Button()
        Me.Golbl = New System.Windows.Forms.Label()
        Me.Winlbl = New System.Windows.Forms.Label()
        Me.hockeyrink = New System.Windows.Forms.PictureBox()
        Me.countdownpanel = New System.Windows.Forms.Panel()
        Me.Buzzertime = New System.Windows.Forms.Timer(Me.components)
        Me.Start = New System.Windows.Forms.Timer(Me.components)
        Me.again = New System.Windows.Forms.Button()
        Me.retire = New System.Windows.Forms.Button()
        Me.WinPlayer = New System.Windows.Forms.PictureBox()
        Me.WinPlayerImages = New System.Windows.Forms.ImageList(Me.components)
        Me.WinGoalie = New System.Windows.Forms.PictureBox()
        Me.WinGoalieImages = New System.Windows.Forms.ImageList(Me.components)
        CType(Me.Pausebutton, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.scoreboard, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.rUserPlayer, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lUserPlayer, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lUserGoalie, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.rUserGoalie, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lUserNet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.rUserNet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.puck, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pauseMenuPanel.SuspendLayout()
        CType(Me.hockeyrink, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.countdownpanel.SuspendLayout()
        CType(Me.WinPlayer, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.WinGoalie, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.Pausebutton.Location = New System.Drawing.Point(979, 15)
        Me.Pausebutton.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Pausebutton.Name = "Pausebutton"
        Me.Pausebutton.Size = New System.Drawing.Size(51, 49)
        Me.Pausebutton.TabIndex = 5
        Me.Pausebutton.TabStop = False
        '
        'scoreboard
        '
        Me.scoreboard.BackColor = System.Drawing.Color.Transparent
        Me.scoreboard.BackgroundImage = Global._2DHockey.My.Resources.Resources.Scoreboard
        Me.scoreboard.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.scoreboard.Location = New System.Drawing.Point(315, 454)
        Me.scoreboard.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.scoreboard.Name = "scoreboard"
        Me.scoreboard.Size = New System.Drawing.Size(416, 171)
        Me.scoreboard.TabIndex = 14
        Me.scoreboard.TabStop = False
        '
        'rUserScoreboard
        '
        Me.rUserScoreboard.AutoSize = True
        Me.rUserScoreboard.BackColor = System.Drawing.Color.Black
        Me.rUserScoreboard.Font = New System.Drawing.Font("Microsoft Sans Serif", 33.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rUserScoreboard.ForeColor = System.Drawing.Color.Gold
        Me.rUserScoreboard.Location = New System.Drawing.Point(595, 535)
        Me.rUserScoreboard.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.rUserScoreboard.Name = "rUserScoreboard"
        Me.rUserScoreboard.Size = New System.Drawing.Size(60, 65)
        Me.rUserScoreboard.TabIndex = 12
        Me.rUserScoreboard.Text = "0"
        '
        'lUserScoreboard
        '
        Me.lUserScoreboard.AutoSize = True
        Me.lUserScoreboard.BackColor = System.Drawing.Color.Black
        Me.lUserScoreboard.Font = New System.Drawing.Font("Microsoft Sans Serif", 33.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lUserScoreboard.ForeColor = System.Drawing.Color.Gold
        Me.lUserScoreboard.Location = New System.Drawing.Point(391, 535)
        Me.lUserScoreboard.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lUserScoreboard.Name = "lUserScoreboard"
        Me.lUserScoreboard.Size = New System.Drawing.Size(60, 65)
        Me.lUserScoreboard.TabIndex = 11
        Me.lUserScoreboard.Text = "0"
        '
        'count
        '
        Me.count.Interval = 1050
        '
        'wintimer
        '
        Me.wintimer.Interval = 1000
        '
        'rUserPlayer
        '
        Me.rUserPlayer.BackColor = System.Drawing.Color.WhiteSmoke
        Me.rUserPlayer.Image = Global._2DHockey.My.Resources.Resources.GreenPlayer1
        Me.rUserPlayer.Location = New System.Drawing.Point(637, 203)
        Me.rUserPlayer.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.rUserPlayer.Name = "rUserPlayer"
        Me.rUserPlayer.Size = New System.Drawing.Size(67, 62)
        Me.rUserPlayer.TabIndex = 4
        Me.rUserPlayer.TabStop = False
        '
        'lUserPlayer
        '
        Me.lUserPlayer.BackColor = System.Drawing.Color.WhiteSmoke
        Me.lUserPlayer.Image = Global._2DHockey.My.Resources.Resources.BluePlayer1
        Me.lUserPlayer.Location = New System.Drawing.Point(380, 202)
        Me.lUserPlayer.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.lUserPlayer.Name = "lUserPlayer"
        Me.lUserPlayer.Size = New System.Drawing.Size(67, 62)
        Me.lUserPlayer.TabIndex = 0
        Me.lUserPlayer.TabStop = False
        '
        'lUserGoalie
        '
        Me.lUserGoalie.BackColor = System.Drawing.Color.WhiteSmoke
        Me.lUserGoalie.Image = Global._2DHockey.My.Resources.Resources.Blue_Goalie1
        Me.lUserGoalie.Location = New System.Drawing.Point(183, 206)
        Me.lUserGoalie.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.lUserGoalie.Name = "lUserGoalie"
        Me.lUserGoalie.Size = New System.Drawing.Size(67, 58)
        Me.lUserGoalie.TabIndex = 9
        Me.lUserGoalie.TabStop = False
        '
        'rUserGoalie
        '
        Me.rUserGoalie.BackColor = System.Drawing.Color.WhiteSmoke
        Me.rUserGoalie.Image = Global._2DHockey.My.Resources.Resources.Green_Goalie1
        Me.rUserGoalie.Location = New System.Drawing.Point(791, 206)
        Me.rUserGoalie.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.rUserGoalie.Name = "rUserGoalie"
        Me.rUserGoalie.Size = New System.Drawing.Size(67, 58)
        Me.rUserGoalie.TabIndex = 10
        Me.rUserGoalie.TabStop = False
        '
        'lUserNet
        '
        Me.lUserNet.Image = Global._2DHockey.My.Resources.Resources.HockeyNet
        Me.lUserNet.Location = New System.Drawing.Point(135, 183)
        Me.lUserNet.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.lUserNet.Name = "lUserNet"
        Me.lUserNet.Size = New System.Drawing.Size(40, 98)
        Me.lUserNet.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.lUserNet.TabIndex = 2
        Me.lUserNet.TabStop = False
        '
        'countdownlbl
        '
        Me.countdownlbl.AutoSize = True
        Me.countdownlbl.BackColor = System.Drawing.Color.Transparent
        Me.countdownlbl.Font = New System.Drawing.Font("Microsoft Sans Serif", 48.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.countdownlbl.ForeColor = System.Drawing.SystemColors.ControlText
        Me.countdownlbl.Location = New System.Drawing.Point(29, 22)
        Me.countdownlbl.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.countdownlbl.Name = "countdownlbl"
        Me.countdownlbl.Size = New System.Drawing.Size(83, 91)
        Me.countdownlbl.TabIndex = 15
        Me.countdownlbl.Text = "3"
        '
        'rUserNet
        '
        Me.rUserNet.Image = Global._2DHockey.My.Resources.Resources.HockeyNet
        Me.rUserNet.Location = New System.Drawing.Point(865, 183)
        Me.rUserNet.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.rUserNet.Name = "rUserNet"
        Me.rUserNet.Size = New System.Drawing.Size(40, 98)
        Me.rUserNet.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.rUserNet.TabIndex = 3
        Me.rUserNet.TabStop = False
        '
        'puck
        '
        Me.puck.BackgroundImage = Global._2DHockey.My.Resources.Resources.Puck1
        Me.puck.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.puck.Location = New System.Drawing.Point(509, 234)
        Me.puck.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.puck.Name = "puck"
        Me.puck.Size = New System.Drawing.Size(24, 12)
        Me.puck.TabIndex = 1
        Me.puck.TabStop = False
        '
        'pauseMenuPanel
        '
        Me.pauseMenuPanel.Controls.Add(Me.resumebtn)
        Me.pauseMenuPanel.Controls.Add(Me.Quitbtn)
        Me.pauseMenuPanel.Location = New System.Drawing.Point(389, 139)
        Me.pauseMenuPanel.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.pauseMenuPanel.Name = "pauseMenuPanel"
        Me.pauseMenuPanel.Size = New System.Drawing.Size(267, 185)
        Me.pauseMenuPanel.TabIndex = 8
        Me.pauseMenuPanel.Visible = False
        '
        'resumebtn
        '
        Me.resumebtn.BackColor = System.Drawing.Color.DarkBlue
        Me.resumebtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.resumebtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.resumebtn.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.resumebtn.Location = New System.Drawing.Point(20, 23)
        Me.resumebtn.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.resumebtn.Name = "resumebtn"
        Me.resumebtn.Size = New System.Drawing.Size(227, 43)
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
        Me.Quitbtn.Location = New System.Drawing.Point(20, 113)
        Me.Quitbtn.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Quitbtn.Name = "Quitbtn"
        Me.Quitbtn.Size = New System.Drawing.Size(227, 43)
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
        Me.Golbl.Location = New System.Drawing.Point(9, 22)
        Me.Golbl.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Golbl.Name = "Golbl"
        Me.Golbl.Size = New System.Drawing.Size(145, 91)
        Me.Golbl.TabIndex = 16
        Me.Golbl.Text = "Go"
        '
        'Winlbl
        '
        Me.Winlbl.BackColor = System.Drawing.Color.White
        Me.Winlbl.Font = New System.Drawing.Font("Microsoft Sans Serif", 45.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Winlbl.ForeColor = System.Drawing.Color.DarkBlue
        Me.Winlbl.Location = New System.Drawing.Point(0, 161)
        Me.Winlbl.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Winlbl.Name = "Winlbl"
        Me.Winlbl.Size = New System.Drawing.Size(1045, 133)
        Me.Winlbl.TabIndex = 17
        Me.Winlbl.Text = "LEFT PLAYER WINS!"
        Me.Winlbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'hockeyrink
        '
        Me.hockeyrink.BackgroundImage = Global._2DHockey.My.Resources.Resources.Hockeyrink
        Me.hockeyrink.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.hockeyrink.Location = New System.Drawing.Point(-1, 1)
        Me.hockeyrink.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.hockeyrink.Name = "hockeyrink"
        Me.hockeyrink.Size = New System.Drawing.Size(1045, 444)
        Me.hockeyrink.TabIndex = 18
        Me.hockeyrink.TabStop = False
        '
        'countdownpanel
        '
        Me.countdownpanel.BackColor = System.Drawing.Color.White
        Me.countdownpanel.Controls.Add(Me.countdownlbl)
        Me.countdownpanel.Controls.Add(Me.Golbl)
        Me.countdownpanel.Location = New System.Drawing.Point(451, 170)
        Me.countdownpanel.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.countdownpanel.Name = "countdownpanel"
        Me.countdownpanel.Size = New System.Drawing.Size(144, 123)
        Me.countdownpanel.TabIndex = 19
        '
        'Buzzertime
        '
        Me.Buzzertime.Interval = 1000
        '
        'Start
        '
        Me.Start.Interval = 1050
        '
        'again
        '
        Me.again.BackColor = System.Drawing.Color.DarkBlue
        Me.again.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.again.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.again.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.again.Location = New System.Drawing.Point(539, 332)
        Me.again.Margin = New System.Windows.Forms.Padding(4)
        Me.again.Name = "again"
        Me.again.Size = New System.Drawing.Size(227, 43)
        Me.again.TabIndex = 8
        Me.again.Text = "Play Again?"
        Me.again.UseVisualStyleBackColor = False
        Me.again.Visible = False
        '
        'retire
        '
        Me.retire.BackColor = System.Drawing.Color.DarkBlue
        Me.retire.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.retire.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.retire.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.retire.Location = New System.Drawing.Point(273, 332)
        Me.retire.Margin = New System.Windows.Forms.Padding(4)
        Me.retire.Name = "retire"
        Me.retire.Size = New System.Drawing.Size(227, 43)
        Me.retire.TabIndex = 8
        Me.retire.Text = "Retire"
        Me.retire.UseVisualStyleBackColor = False
        Me.retire.Visible = False
        '
        'WinPlayer
        '
        Me.WinPlayer.Location = New System.Drawing.Point(87, 287)
        Me.WinPlayer.Name = "WinPlayer"
        Me.WinPlayer.Size = New System.Drawing.Size(200, 200)
        Me.WinPlayer.TabIndex = 20
        Me.WinPlayer.TabStop = False
        Me.WinPlayer.Visible = False
        '
        'WinPlayerImages
        '
        Me.WinPlayerImages.ImageStream = CType(resources.GetObject("WinPlayerImages.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.WinPlayerImages.TransparentColor = System.Drawing.Color.Transparent
        Me.WinPlayerImages.Images.SetKeyName(0, "BlueLarger1.png")
        Me.WinPlayerImages.Images.SetKeyName(1, "GreenLarger1.png")
        Me.WinPlayerImages.Images.SetKeyName(2, "OrangeLarger1.png")
        Me.WinPlayerImages.Images.SetKeyName(3, "Redlarger1.png")
        Me.WinPlayerImages.Images.SetKeyName(4, "Whitelarger1.png")
        '
        'WinGoalie
        '
        Me.WinGoalie.Location = New System.Drawing.Point(499, 292)
        Me.WinGoalie.Name = "WinGoalie"
        Me.WinGoalie.Size = New System.Drawing.Size(200, 188)
        Me.WinGoalie.TabIndex = 21
        Me.WinGoalie.TabStop = False
        Me.WinGoalie.Visible = False
        '
        'WinGoalieImages
        '
        Me.WinGoalieImages.ImageStream = CType(resources.GetObject("WinGoalieImages.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.WinGoalieImages.TransparentColor = System.Drawing.Color.Transparent
        Me.WinGoalieImages.Images.SetKeyName(0, "BlueGoalieLarger1.png")
        Me.WinGoalieImages.Images.SetKeyName(1, "GreenGoalieLarger1.png")
        Me.WinGoalieImages.Images.SetKeyName(2, "OrangeGoalielarger1.png")
        Me.WinGoalieImages.Images.SetKeyName(3, "RedGoalieLarger1.png")
        Me.WinGoalieImages.Images.SetKeyName(4, "WhiteGoalieLarger1.png")
        '
        'MainGame
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.BackgroundImage = Global._2DHockey.My.Resources.Resources.Background_2
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1045, 626)
        Me.ControlBox = False
        Me.Controls.Add(Me.again)
        Me.Controls.Add(Me.retire)
        Me.Controls.Add(Me.WinPlayer)
        Me.Controls.Add(Me.WinGoalie)
        Me.Controls.Add(Me.pauseMenuPanel)
        Me.Controls.Add(Me.countdownpanel)
        Me.Controls.Add(Me.Winlbl)
        Me.Controls.Add(Me.rUserNet)
        Me.Controls.Add(Me.puck)
        Me.Controls.Add(Me.rUserGoalie)
        Me.Controls.Add(Me.rUserPlayer)
        Me.Controls.Add(Me.rUserScoreboard)
        Me.Controls.Add(Me.lUserScoreboard)
        Me.Controls.Add(Me.Pausebutton)
        Me.Controls.Add(Me.scoreboard)
        Me.Controls.Add(Me.lUserNet)
        Me.Controls.Add(Me.lUserPlayer)
        Me.Controls.Add(Me.lUserGoalie)
        Me.Controls.Add(Me.hockeyrink)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "MainGame"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "2D Hockey"
        CType(Me.Pausebutton, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.scoreboard, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.rUserPlayer, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lUserPlayer, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lUserGoalie, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.rUserGoalie, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lUserNet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.rUserNet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.puck, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pauseMenuPanel.ResumeLayout(False)
        CType(Me.hockeyrink, System.ComponentModel.ISupportInitialize).EndInit()
        Me.countdownpanel.ResumeLayout(False)
        Me.countdownpanel.PerformLayout()
        CType(Me.WinPlayer, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.WinGoalie, System.ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents rUserScoreboard As System.Windows.Forms.Label
    Friend WithEvents lUserScoreboard As System.Windows.Forms.Label
    Friend WithEvents count As System.Windows.Forms.Timer
    Friend WithEvents wintimer As System.Windows.Forms.Timer
    Friend WithEvents rUserPlayer As System.Windows.Forms.PictureBox
    Friend WithEvents lUserPlayer As System.Windows.Forms.PictureBox
    Friend WithEvents lUserGoalie As System.Windows.Forms.PictureBox
    Friend WithEvents rUserGoalie As System.Windows.Forms.PictureBox
    Friend WithEvents lUserNet As System.Windows.Forms.PictureBox
    Friend WithEvents countdownlbl As System.Windows.Forms.Label
    Friend WithEvents rUserNet As System.Windows.Forms.PictureBox
    Friend WithEvents puck As System.Windows.Forms.PictureBox
    Friend WithEvents pauseMenuPanel As System.Windows.Forms.Panel
    Friend WithEvents resumebtn As System.Windows.Forms.Button
    Friend WithEvents Quitbtn As System.Windows.Forms.Button
    Friend WithEvents Golbl As System.Windows.Forms.Label
    Friend WithEvents Winlbl As System.Windows.Forms.Label
    Friend WithEvents hockeyrink As System.Windows.Forms.PictureBox
    Friend WithEvents countdownpanel As System.Windows.Forms.Panel
    Friend WithEvents Buzzertime As System.Windows.Forms.Timer
    Friend WithEvents Start As System.Windows.Forms.Timer
    Friend WithEvents again As System.Windows.Forms.Button
    Friend WithEvents retire As System.Windows.Forms.Button
    Friend WithEvents WinPlayer As System.Windows.Forms.PictureBox
    Friend WithEvents WinPlayerImages As System.Windows.Forms.ImageList
    Friend WithEvents WinGoalie As System.Windows.Forms.PictureBox
    Friend WithEvents WinGoalieImages As System.Windows.Forms.ImageList

End Class