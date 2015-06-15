<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class OptionsMenu
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(OptionsMenu))
        Me.optionlbl = New System.Windows.Forms.Label()
        Me.Musicname = New System.Windows.Forms.Label()
        Me.backbutton = New System.Windows.Forms.Button()
        Me.Musicon = New System.Windows.Forms.RadioButton()
        Me.Musicoff = New System.Windows.Forms.RadioButton()
        Me.Pointsetter = New System.Windows.Forms.Label()
        Me.points5 = New System.Windows.Forms.RadioButton()
        Me.points7 = New System.Windows.Forms.RadioButton()
        Me.points9 = New System.Windows.Forms.RadioButton()
        Me.points = New System.Windows.Forms.GroupBox()
        Me.musiconoff = New System.Windows.Forms.GroupBox()
        Me.points.SuspendLayout()
        Me.musiconoff.SuspendLayout()
        Me.SuspendLayout()
        '
        'optionlbl
        '
        Me.optionlbl.AutoSize = True
        Me.optionlbl.BackColor = System.Drawing.Color.Transparent
        Me.optionlbl.Font = New System.Drawing.Font("Microsoft Sans Serif", 48.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.optionlbl.ForeColor = System.Drawing.Color.DarkRed
        Me.optionlbl.Location = New System.Drawing.Point(115, 39)
        Me.optionlbl.Name = "optionlbl"
        Me.optionlbl.Size = New System.Drawing.Size(321, 73)
        Me.optionlbl.TabIndex = 0
        Me.optionlbl.Text = "OPTIONS"
        '
        'Musicname
        '
        Me.Musicname.AutoSize = True
        Me.Musicname.BackColor = System.Drawing.Color.Transparent
        Me.Musicname.Font = New System.Drawing.Font("Microsoft Sans Serif", 27.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Musicname.ForeColor = System.Drawing.Color.DarkRed
        Me.Musicname.Location = New System.Drawing.Point(56, 127)
        Me.Musicname.Name = "Musicname"
        Me.Musicname.Size = New System.Drawing.Size(116, 42)
        Me.Musicname.TabIndex = 4
        Me.Musicname.Text = "Music"
        '
        'backbutton
        '
        Me.backbutton.BackColor = System.Drawing.Color.DarkBlue
        Me.backbutton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.backbutton.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.backbutton.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.backbutton.Location = New System.Drawing.Point(154, 451)
        Me.backbutton.Name = "backbutton"
        Me.backbutton.Size = New System.Drawing.Size(293, 39)
        Me.backbutton.TabIndex = 5
        Me.backbutton.Text = "Back"
        Me.backbutton.UseVisualStyleBackColor = False
        '
        'Musicon
        '
        Me.Musicon.AutoSize = True
        Me.Musicon.BackColor = System.Drawing.Color.Transparent
        Me.Musicon.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Musicon.ForeColor = System.Drawing.Color.DarkBlue
        Me.Musicon.Location = New System.Drawing.Point(6, 28)
        Me.Musicon.Name = "Musicon"
        Me.Musicon.Size = New System.Drawing.Size(68, 33)
        Me.Musicon.TabIndex = 6
        Me.Musicon.TabStop = True
        Me.Musicon.Text = "ON"
        Me.Musicon.UseVisualStyleBackColor = False
        '
        'Musicoff
        '
        Me.Musicoff.AutoSize = True
        Me.Musicoff.BackColor = System.Drawing.Color.Transparent
        Me.Musicoff.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Musicoff.ForeColor = System.Drawing.Color.DarkBlue
        Me.Musicoff.Location = New System.Drawing.Point(111, 28)
        Me.Musicoff.Name = "Musicoff"
        Me.Musicoff.Size = New System.Drawing.Size(80, 33)
        Me.Musicoff.TabIndex = 7
        Me.Musicoff.TabStop = True
        Me.Musicoff.Text = "OFF"
        Me.Musicoff.UseVisualStyleBackColor = False
        '
        'Pointsetter
        '
        Me.Pointsetter.AutoSize = True
        Me.Pointsetter.BackColor = System.Drawing.Color.Transparent
        Me.Pointsetter.Font = New System.Drawing.Font("Microsoft Sans Serif", 27.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Pointsetter.ForeColor = System.Drawing.Color.DarkRed
        Me.Pointsetter.Location = New System.Drawing.Point(56, 264)
        Me.Pointsetter.Name = "Pointsetter"
        Me.Pointsetter.Size = New System.Drawing.Size(237, 42)
        Me.Pointsetter.TabIndex = 8
        Me.Pointsetter.Text = "Points to Win"
        '
        'points5
        '
        Me.points5.AutoSize = True
        Me.points5.BackColor = System.Drawing.Color.Transparent
        Me.points5.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.points5.ForeColor = System.Drawing.Color.DarkBlue
        Me.points5.Location = New System.Drawing.Point(25, 43)
        Me.points5.Name = "points5"
        Me.points5.Size = New System.Drawing.Size(44, 33)
        Me.points5.TabIndex = 9
        Me.points5.TabStop = True
        Me.points5.Text = "5"
        Me.points5.UseVisualStyleBackColor = False
        '
        'points7
        '
        Me.points7.AutoSize = True
        Me.points7.BackColor = System.Drawing.Color.Transparent
        Me.points7.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.points7.ForeColor = System.Drawing.Color.DarkBlue
        Me.points7.Location = New System.Drawing.Point(116, 43)
        Me.points7.Name = "points7"
        Me.points7.Size = New System.Drawing.Size(44, 33)
        Me.points7.TabIndex = 10
        Me.points7.TabStop = True
        Me.points7.Text = "7"
        Me.points7.UseVisualStyleBackColor = False
        '
        'points9
        '
        Me.points9.AutoSize = True
        Me.points9.BackColor = System.Drawing.Color.Transparent
        Me.points9.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.points9.ForeColor = System.Drawing.Color.DarkBlue
        Me.points9.Location = New System.Drawing.Point(193, 43)
        Me.points9.Name = "points9"
        Me.points9.Size = New System.Drawing.Size(44, 33)
        Me.points9.TabIndex = 11
        Me.points9.TabStop = True
        Me.points9.Text = "9"
        Me.points9.UseVisualStyleBackColor = False
        '
        'points
        '
        Me.points.BackColor = System.Drawing.Color.Transparent
        Me.points.Controls.Add(Me.points9)
        Me.points.Controls.Add(Me.points5)
        Me.points.Controls.Add(Me.points7)
        Me.points.Location = New System.Drawing.Point(63, 315)
        Me.points.Name = "points"
        Me.points.Size = New System.Drawing.Size(256, 108)
        Me.points.TabIndex = 12
        Me.points.TabStop = False
        '
        'musiconoff
        '
        Me.musiconoff.BackColor = System.Drawing.Color.Transparent
        Me.musiconoff.Controls.Add(Me.Musicoff)
        Me.musiconoff.Controls.Add(Me.Musicon)
        Me.musiconoff.Location = New System.Drawing.Point(63, 178)
        Me.musiconoff.Name = "musiconoff"
        Me.musiconoff.Size = New System.Drawing.Size(200, 73)
        Me.musiconoff.TabIndex = 13
        Me.musiconoff.TabStop = False
        '
        'OptionsMenu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global._2DHockey.My.Resources.Resources.mainMenuBackground
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(885, 557)
        Me.Controls.Add(Me.musiconoff)
        Me.Controls.Add(Me.points)
        Me.Controls.Add(Me.Pointsetter)
        Me.Controls.Add(Me.backbutton)
        Me.Controls.Add(Me.Musicname)
        Me.Controls.Add(Me.optionlbl)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "OptionsMenu"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "OptionsMenu"
        Me.points.ResumeLayout(False)
        Me.points.PerformLayout()
        Me.musiconoff.ResumeLayout(False)
        Me.musiconoff.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents optionlbl As System.Windows.Forms.Label
    Friend WithEvents Musicname As System.Windows.Forms.Label
    Friend WithEvents backbutton As System.Windows.Forms.Button
    Friend WithEvents Musicon As System.Windows.Forms.RadioButton
    Friend WithEvents Musicoff As System.Windows.Forms.RadioButton
    Friend WithEvents Pointsetter As System.Windows.Forms.Label
    Friend WithEvents points5 As System.Windows.Forms.RadioButton
    Friend WithEvents points7 As System.Windows.Forms.RadioButton
    Friend WithEvents points9 As System.Windows.Forms.RadioButton
    Friend WithEvents points As System.Windows.Forms.GroupBox
    Friend WithEvents musiconoff As System.Windows.Forms.GroupBox
End Class
