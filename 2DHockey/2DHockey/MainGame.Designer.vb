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
        Me.resumebtn = New System.Windows.Forms.Button()
        Me.Quitbtn = New System.Windows.Forms.Button()
        Me.pauseMenuPanel = New System.Windows.Forms.Panel()
        Me.goalieColours = New System.Windows.Forms.ImageList(Me.components)
        Me.compGoalie = New System.Windows.Forms.PictureBox()
        Me.userGoalie = New System.Windows.Forms.PictureBox()
        Me.Pausebutton = New System.Windows.Forms.PictureBox()
        Me.compPlayer = New System.Windows.Forms.PictureBox()
        Me.compNet = New System.Windows.Forms.PictureBox()
        Me.userNet = New System.Windows.Forms.PictureBox()
        Me.puck = New System.Windows.Forms.PictureBox()
        Me.userPlayer = New System.Windows.Forms.PictureBox()
        Me.HockeyRink = New System.Windows.Forms.PictureBox()
        Me.scoreboard = New System.Windows.Forms.PictureBox()
        Me.team2score = New System.Windows.Forms.Label()
        Me.team1score = New System.Windows.Forms.Label()
        Me.Buzzertime = New System.Windows.Forms.Timer(Me.components)
        Me.pauseMenuPanel.SuspendLayout()
        CType(Me.compGoalie, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.userGoalie, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Pausebutton, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.compPlayer, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.compNet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.userNet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.puck, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.userPlayer, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.HockeyRink, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.scoreboard, System.ComponentModel.ISupportInitialize).BeginInit()
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
        'pauseMenuPanel
        '
        Me.pauseMenuPanel.Controls.Add(Me.resumebtn)
        Me.pauseMenuPanel.Controls.Add(Me.Quitbtn)
        Me.pauseMenuPanel.Location = New System.Drawing.Point(389, 165)
        Me.pauseMenuPanel.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.pauseMenuPanel.Name = "pauseMenuPanel"
        Me.pauseMenuPanel.Size = New System.Drawing.Size(267, 185)
        Me.pauseMenuPanel.TabIndex = 8
        Me.pauseMenuPanel.Visible = False
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
        'compGoalie
        '
        Me.compGoalie.BackColor = System.Drawing.Color.White
        Me.compGoalie.Image = Global._2DHockey.My.Resources.Resources.Green_Goalie1
        Me.compGoalie.Location = New System.Drawing.Point(799, 206)
        Me.compGoalie.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.compGoalie.Name = "compGoalie"
        Me.compGoalie.Size = New System.Drawing.Size(67, 58)
        Me.compGoalie.TabIndex = 10
        Me.compGoalie.TabStop = False
        '
        'userGoalie
        '
        Me.userGoalie.Image = Global._2DHockey.My.Resources.Resources.Blue_Goalie1
        Me.userGoalie.Location = New System.Drawing.Point(181, 206)
        Me.userGoalie.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.userGoalie.Name = "userGoalie"
        Me.userGoalie.Size = New System.Drawing.Size(67, 58)
        Me.userGoalie.TabIndex = 9
        Me.userGoalie.TabStop = False
        '
        'Pausebutton
        '
        Me.Pausebutton.BackColor = System.Drawing.Color.DarkBlue
        Me.Pausebutton.BackgroundImage = Global._2DHockey.My.Resources.Resources.mainGamePauseButtonImage
        Me.Pausebutton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.Pausebutton.Location = New System.Drawing.Point(984, 15)
        Me.Pausebutton.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Pausebutton.Name = "Pausebutton"
        Me.Pausebutton.Size = New System.Drawing.Size(51, 49)
        Me.Pausebutton.TabIndex = 5
        Me.Pausebutton.TabStop = False
        '
        'compPlayer
        '
        Me.compPlayer.BackColor = System.Drawing.Color.White
        Me.compPlayer.Image = Global._2DHockey.My.Resources.Resources.GreenPlayer1
        Me.compPlayer.Location = New System.Drawing.Point(664, 202)
        Me.compPlayer.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.compPlayer.Name = "compPlayer"
        Me.compPlayer.Size = New System.Drawing.Size(67, 62)
        Me.compPlayer.TabIndex = 4
        Me.compPlayer.TabStop = False
        '
        'compNet
        '
        Me.compNet.Image = Global._2DHockey.My.Resources.Resources.HockeyNet
        Me.compNet.Location = New System.Drawing.Point(867, 182)
        Me.compNet.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.compNet.Name = "compNet"
        Me.compNet.Size = New System.Drawing.Size(40, 98)
        Me.compNet.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.compNet.TabIndex = 3
        Me.compNet.TabStop = False
        '
        'userNet
        '
        Me.userNet.Image = Global._2DHockey.My.Resources.Resources.HockeyNet
        Me.userNet.Location = New System.Drawing.Point(140, 182)
        Me.userNet.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.userNet.Name = "userNet"
        Me.userNet.Size = New System.Drawing.Size(40, 98)
        Me.userNet.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.userNet.TabIndex = 2
        Me.userNet.TabStop = False
        '
        'puck
        '
        Me.puck.BackgroundImage = Global._2DHockey.My.Resources.Resources.Puck1
        Me.puck.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.puck.Location = New System.Drawing.Point(509, 228)
        Me.puck.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.puck.Name = "puck"
        Me.puck.Size = New System.Drawing.Size(24, 12)
        Me.puck.TabIndex = 1
        Me.puck.TabStop = False
        '
        'userPlayer
        '
        Me.userPlayer.BackColor = System.Drawing.Color.White
        Me.userPlayer.Image = Global._2DHockey.My.Resources.Resources.BluePlayer1
        Me.userPlayer.Location = New System.Drawing.Point(340, 203)
        Me.userPlayer.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.userPlayer.Name = "userPlayer"
        Me.userPlayer.Size = New System.Drawing.Size(67, 62)
        Me.userPlayer.TabIndex = 0
        Me.userPlayer.TabStop = False
        '
        'HockeyRink
        '
        Me.HockeyRink.BackColor = System.Drawing.Color.Transparent
        Me.HockeyRink.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.HockeyRink.Image = Global._2DHockey.My.Resources.Resources.Hockeyrink
        Me.HockeyRink.Location = New System.Drawing.Point(1, 2)
        Me.HockeyRink.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.HockeyRink.Name = "HockeyRink"
        Me.HockeyRink.Size = New System.Drawing.Size(1045, 444)
        Me.HockeyRink.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.HockeyRink.TabIndex = 13
        Me.HockeyRink.TabStop = False
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
        'team2score
        '
        Me.team2score.AutoSize = True
        Me.team2score.BackColor = System.Drawing.Color.Black
        Me.team2score.Font = New System.Drawing.Font("Microsoft Sans Serif", 33.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.team2score.ForeColor = System.Drawing.Color.Gold
        Me.team2score.Location = New System.Drawing.Point(595, 537)
        Me.team2score.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.team2score.Name = "team2score"
        Me.team2score.Size = New System.Drawing.Size(60, 65)
        Me.team2score.TabIndex = 12
        Me.team2score.Text = "0"
        '
        'team1score
        '
        Me.team1score.AutoSize = True
        Me.team1score.BackColor = System.Drawing.Color.Black
        Me.team1score.Font = New System.Drawing.Font("Microsoft Sans Serif", 33.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.team1score.ForeColor = System.Drawing.Color.Gold
        Me.team1score.Location = New System.Drawing.Point(397, 537)
        Me.team1score.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.team1score.Name = "team1score"
        Me.team1score.Size = New System.Drawing.Size(60, 65)
        Me.team1score.TabIndex = 11
        Me.team1score.Text = "0"
        '
        'Buzzertime
        '
        Me.Buzzertime.Interval = 1000
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
        Me.Controls.Add(Me.team2score)
        Me.Controls.Add(Me.team1score)
        Me.Controls.Add(Me.compGoalie)
        Me.Controls.Add(Me.userGoalie)
        Me.Controls.Add(Me.pauseMenuPanel)
        Me.Controls.Add(Me.Pausebutton)
        Me.Controls.Add(Me.compPlayer)
        Me.Controls.Add(Me.compNet)
        Me.Controls.Add(Me.userNet)
        Me.Controls.Add(Me.puck)
        Me.Controls.Add(Me.userPlayer)
        Me.Controls.Add(Me.scoreboard)
        Me.Controls.Add(Me.HockeyRink)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "MainGame"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "2D Hockey"
        Me.pauseMenuPanel.ResumeLayout(False)
        CType(Me.compGoalie, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.userGoalie, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Pausebutton, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.compPlayer, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.compNet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.userNet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.puck, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.userPlayer, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.HockeyRink, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.scoreboard, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents tick As System.Windows.Forms.Timer
    Friend WithEvents userPlayer As System.Windows.Forms.PictureBox
    Friend WithEvents puck As System.Windows.Forms.PictureBox
    Friend WithEvents userNet As System.Windows.Forms.PictureBox
    Friend WithEvents compNet As System.Windows.Forms.PictureBox
    Friend WithEvents blueAnimation As System.Windows.Forms.ImageList
    Friend WithEvents FrameTimer As System.Windows.Forms.Timer
    Friend WithEvents compPlayer As System.Windows.Forms.PictureBox
    Friend WithEvents redAnimation As System.Windows.Forms.ImageList
    Friend WithEvents greenAnimation As System.Windows.Forms.ImageList
    Friend WithEvents orangeAnimation As System.Windows.Forms.ImageList
    Friend WithEvents whiteAnimation As System.Windows.Forms.ImageList
    Friend WithEvents Pausebutton As System.Windows.Forms.PictureBox
    Friend WithEvents resumebtn As System.Windows.Forms.Button
    Friend WithEvents Quitbtn As System.Windows.Forms.Button
    Friend WithEvents pauseMenuPanel As System.Windows.Forms.Panel
    Friend WithEvents userGoalie As System.Windows.Forms.PictureBox
    Friend WithEvents compGoalie As System.Windows.Forms.PictureBox
    Friend WithEvents goalieColours As System.Windows.Forms.ImageList
    Friend WithEvents HockeyRink As System.Windows.Forms.PictureBox
    Friend WithEvents scoreboard As System.Windows.Forms.PictureBox
    Friend WithEvents team2score As System.Windows.Forms.Label
    Friend WithEvents team1score As System.Windows.Forms.Label
    Friend WithEvents Buzzertime As System.Windows.Forms.Timer

End Class
