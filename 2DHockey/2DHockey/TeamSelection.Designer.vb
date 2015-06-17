<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class TeamSelection
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(TeamSelection))
        Me.playerSprites = New System.Windows.Forms.ImageList(Me.components)
        Me.lUserPlayerTeam = New System.Windows.Forms.PictureBox()
        Me.rUserPlayerTeam = New System.Windows.Forms.PictureBox()
        Me.llUsereft = New System.Windows.Forms.Button()
        Me.lUserRight = New System.Windows.Forms.Button()
        Me.rlUsereft = New System.Windows.Forms.Button()
        Me.rUserRight = New System.Windows.Forms.Button()
        Me.rUserConfirm = New System.Windows.Forms.Button()
        Me.lUserConfirm = New System.Windows.Forms.Button()
        Me.optionlbl = New System.Windows.Forms.Label()
        Me.backbutton = New System.Windows.Forms.Button()
        Me.llUserbl = New System.Windows.Forms.Label()
        Me.rlUserbl = New System.Windows.Forms.Label()
        CType(Me.lUserPlayerTeam, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.rUserPlayerTeam, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'playerSprites
        '
        Me.playerSprites.ImageStream = CType(resources.GetObject("playerSprites.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.playerSprites.TransparentColor = System.Drawing.Color.Transparent
        Me.playerSprites.Images.SetKeyName(0, "BluePlayer2.png")
        Me.playerSprites.Images.SetKeyName(1, "GreenPlayer2.png")
        Me.playerSprites.Images.SetKeyName(2, "OrangePlayer2.png")
        Me.playerSprites.Images.SetKeyName(3, "RedPlayer2.png")
        Me.playerSprites.Images.SetKeyName(4, "WhitePlayer2.png")
        '
        'lUserPlayerTeam
        '
        Me.lUserPlayerTeam.BackColor = System.Drawing.Color.Transparent
        Me.lUserPlayerTeam.Image = Global._2DHockey.My.Resources.Resources.BluePlayer2
        Me.lUserPlayerTeam.Location = New System.Drawing.Point(175, 173)
        Me.lUserPlayerTeam.Name = "lUserPlayerTeam"
        Me.lUserPlayerTeam.Size = New System.Drawing.Size(150, 150)
        Me.lUserPlayerTeam.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.lUserPlayerTeam.TabIndex = 0
        Me.lUserPlayerTeam.TabStop = False
        '
        'rUserPlayerTeam
        '
        Me.rUserPlayerTeam.BackColor = System.Drawing.Color.Transparent
        Me.rUserPlayerTeam.Image = Global._2DHockey.My.Resources.Resources.BluePlayer2
        Me.rUserPlayerTeam.InitialImage = Nothing
        Me.rUserPlayerTeam.Location = New System.Drawing.Point(560, 173)
        Me.rUserPlayerTeam.Name = "rUserPlayerTeam"
        Me.rUserPlayerTeam.Size = New System.Drawing.Size(150, 150)
        Me.rUserPlayerTeam.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.rUserPlayerTeam.TabIndex = 1
        Me.rUserPlayerTeam.TabStop = False
        '
        'llUsereft
        '
        Me.llUsereft.BackColor = System.Drawing.Color.DarkBlue
        Me.llUsereft.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.llUsereft.ForeColor = System.Drawing.Color.White
        Me.llUsereft.Location = New System.Drawing.Point(130, 351)
        Me.llUsereft.Name = "llUsereft"
        Me.llUsereft.Size = New System.Drawing.Size(90, 35)
        Me.llUsereft.TabIndex = 2
        Me.llUsereft.Text = "Left"
        Me.llUsereft.UseVisualStyleBackColor = False
        '
        'lUserRight
        '
        Me.lUserRight.BackColor = System.Drawing.Color.DarkBlue
        Me.lUserRight.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lUserRight.ForeColor = System.Drawing.Color.White
        Me.lUserRight.Location = New System.Drawing.Point(278, 351)
        Me.lUserRight.Name = "lUserRight"
        Me.lUserRight.Size = New System.Drawing.Size(90, 35)
        Me.lUserRight.TabIndex = 3
        Me.lUserRight.Text = "Right"
        Me.lUserRight.UseVisualStyleBackColor = False
        '
        'rlUsereft
        '
        Me.rlUsereft.BackColor = System.Drawing.Color.DarkBlue
        Me.rlUsereft.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rlUsereft.ForeColor = System.Drawing.Color.Transparent
        Me.rlUsereft.Location = New System.Drawing.Point(515, 351)
        Me.rlUsereft.Name = "rlUsereft"
        Me.rlUsereft.Size = New System.Drawing.Size(90, 35)
        Me.rlUsereft.TabIndex = 4
        Me.rlUsereft.Text = "Left"
        Me.rlUsereft.UseVisualStyleBackColor = False
        '
        'rUserRight
        '
        Me.rUserRight.BackColor = System.Drawing.Color.DarkBlue
        Me.rUserRight.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rUserRight.ForeColor = System.Drawing.Color.White
        Me.rUserRight.Location = New System.Drawing.Point(663, 351)
        Me.rUserRight.Name = "rUserRight"
        Me.rUserRight.Size = New System.Drawing.Size(90, 35)
        Me.rUserRight.TabIndex = 5
        Me.rUserRight.Text = "Right"
        Me.rUserRight.UseVisualStyleBackColor = False
        '
        'rUserConfirm
        '
        Me.rUserConfirm.BackColor = System.Drawing.Color.DarkBlue
        Me.rUserConfirm.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rUserConfirm.ForeColor = System.Drawing.Color.White
        Me.rUserConfirm.Location = New System.Drawing.Point(575, 407)
        Me.rUserConfirm.Name = "rUserConfirm"
        Me.rUserConfirm.Size = New System.Drawing.Size(120, 35)
        Me.rUserConfirm.TabIndex = 6
        Me.rUserConfirm.Text = "Confirm"
        Me.rUserConfirm.UseVisualStyleBackColor = False
        '
        'lUserConfirm
        '
        Me.lUserConfirm.BackColor = System.Drawing.Color.DarkBlue
        Me.lUserConfirm.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lUserConfirm.ForeColor = System.Drawing.Color.White
        Me.lUserConfirm.Location = New System.Drawing.Point(190, 407)
        Me.lUserConfirm.Name = "lUserConfirm"
        Me.lUserConfirm.Size = New System.Drawing.Size(120, 35)
        Me.lUserConfirm.TabIndex = 7
        Me.lUserConfirm.Text = "Confirm"
        Me.lUserConfirm.UseVisualStyleBackColor = False
        '
        'optionlbl
        '
        Me.optionlbl.AutoSize = True
        Me.optionlbl.BackColor = System.Drawing.Color.Transparent
        Me.optionlbl.Font = New System.Drawing.Font("Microsoft Sans Serif", 50.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.optionlbl.ForeColor = System.Drawing.Color.DarkBlue
        Me.optionlbl.Location = New System.Drawing.Point(104, 36)
        Me.optionlbl.Name = "optionlbl"
        Me.optionlbl.Size = New System.Drawing.Size(496, 76)
        Me.optionlbl.TabIndex = 8
        Me.optionlbl.Text = "Team Selection"
        '
        'backbutton
        '
        Me.backbutton.BackColor = System.Drawing.Color.DarkBlue
        Me.backbutton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.backbutton.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.backbutton.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.backbutton.Location = New System.Drawing.Point(296, 467)
        Me.backbutton.Name = "backbutton"
        Me.backbutton.Size = New System.Drawing.Size(293, 39)
        Me.backbutton.TabIndex = 9
        Me.backbutton.Text = "Back"
        Me.backbutton.UseVisualStyleBackColor = False
        '
        'llUserbl
        '
        Me.llUserbl.AutoSize = True
        Me.llUserbl.BackColor = System.Drawing.Color.Transparent
        Me.llUserbl.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.llUserbl.ForeColor = System.Drawing.Color.White
        Me.llUserbl.Location = New System.Drawing.Point(185, 123)
        Me.llUserbl.Name = "llUserbl"
        Me.llUserbl.Size = New System.Drawing.Size(114, 33)
        Me.llUserbl.TabIndex = 10
        Me.llUserbl.Text = "Team 1"
        '
        'rlUserbl
        '
        Me.rlUserbl.AutoSize = True
        Me.rlUserbl.BackColor = System.Drawing.Color.Transparent
        Me.rlUserbl.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rlUserbl.ForeColor = System.Drawing.Color.White
        Me.rlUserbl.Location = New System.Drawing.Point(570, 123)
        Me.rlUserbl.Name = "rlUserbl"
        Me.rlUserbl.Size = New System.Drawing.Size(114, 33)
        Me.rlUserbl.TabIndex = 11
        Me.rlUserbl.Text = "Team 2"
        '
        'TeamSelection
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global._2DHockey.My.Resources.Resources.teamSelectionBackground
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(885, 557)
        Me.Controls.Add(Me.rlUserbl)
        Me.Controls.Add(Me.llUserbl)
        Me.Controls.Add(Me.backbutton)
        Me.Controls.Add(Me.optionlbl)
        Me.Controls.Add(Me.lUserConfirm)
        Me.Controls.Add(Me.rUserConfirm)
        Me.Controls.Add(Me.rUserRight)
        Me.Controls.Add(Me.rlUsereft)
        Me.Controls.Add(Me.lUserRight)
        Me.Controls.Add(Me.llUsereft)
        Me.Controls.Add(Me.rUserPlayerTeam)
        Me.Controls.Add(Me.lUserPlayerTeam)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "TeamSelection"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "TeamSelection"
        CType(Me.lUserPlayerTeam, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.rUserPlayerTeam, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents playerSprites As System.Windows.Forms.ImageList
    Friend WithEvents lUserPlayerTeam As System.Windows.Forms.PictureBox
    Friend WithEvents rUserPlayerTeam As System.Windows.Forms.PictureBox
    Friend WithEvents llUsereft As System.Windows.Forms.Button
    Friend WithEvents lUserRight As System.Windows.Forms.Button
    Friend WithEvents rlUsereft As System.Windows.Forms.Button
    Friend WithEvents rUserRight As System.Windows.Forms.Button
    Friend WithEvents rUserConfirm As System.Windows.Forms.Button
    Friend WithEvents lUserConfirm As System.Windows.Forms.Button
    Friend WithEvents optionlbl As System.Windows.Forms.Label
    Friend WithEvents backbutton As System.Windows.Forms.Button
    Friend WithEvents llUserbl As System.Windows.Forms.Label
    Friend WithEvents rlUserbl As System.Windows.Forms.Label
End Class
