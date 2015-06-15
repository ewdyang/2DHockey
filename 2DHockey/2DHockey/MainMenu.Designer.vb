<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MainMenu
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MainMenu))
        Me.playbutton = New System.Windows.Forms.Button()
        Me.Optionbutton = New System.Windows.Forms.Button()
        Me.Aboutbutton = New System.Windows.Forms.Button()
        Me.exitButton = New System.Windows.Forms.Button()
        Me.gamename = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'playbutton
        '
        Me.playbutton.BackColor = System.Drawing.Color.DarkBlue
        Me.playbutton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.playbutton.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.playbutton.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.playbutton.Location = New System.Drawing.Point(97, 168)
        Me.playbutton.Name = "playbutton"
        Me.playbutton.Size = New System.Drawing.Size(263, 38)
        Me.playbutton.TabIndex = 1
        Me.playbutton.Text = "Play"
        Me.playbutton.UseVisualStyleBackColor = False
        '
        'Optionbutton
        '
        Me.Optionbutton.BackColor = System.Drawing.Color.DarkBlue
        Me.Optionbutton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.Optionbutton.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Optionbutton.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Optionbutton.Location = New System.Drawing.Point(97, 243)
        Me.Optionbutton.Name = "Optionbutton"
        Me.Optionbutton.Size = New System.Drawing.Size(263, 38)
        Me.Optionbutton.TabIndex = 2
        Me.Optionbutton.Text = "Options"
        Me.Optionbutton.UseVisualStyleBackColor = False
        '
        'Aboutbutton
        '
        Me.Aboutbutton.BackColor = System.Drawing.Color.DarkBlue
        Me.Aboutbutton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.Aboutbutton.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Aboutbutton.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Aboutbutton.Location = New System.Drawing.Point(97, 330)
        Me.Aboutbutton.Name = "Aboutbutton"
        Me.Aboutbutton.Size = New System.Drawing.Size(263, 38)
        Me.Aboutbutton.TabIndex = 3
        Me.Aboutbutton.Text = "About"
        Me.Aboutbutton.UseVisualStyleBackColor = False
        '
        'exitButton
        '
        Me.exitButton.BackColor = System.Drawing.Color.DarkBlue
        Me.exitButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.exitButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.exitButton.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.exitButton.Location = New System.Drawing.Point(97, 418)
        Me.exitButton.Name = "exitButton"
        Me.exitButton.Size = New System.Drawing.Size(263, 38)
        Me.exitButton.TabIndex = 4
        Me.exitButton.Text = "Exit"
        Me.exitButton.UseVisualStyleBackColor = False
        '
        'gamename
        '
        Me.gamename.AutoSize = True
        Me.gamename.BackColor = System.Drawing.Color.Transparent
        Me.gamename.Font = New System.Drawing.Font("Aircruiser", 50.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gamename.ForeColor = System.Drawing.Color.DarkBlue
        Me.gamename.Location = New System.Drawing.Point(25, 48)
        Me.gamename.Name = "gamename"
        Me.gamename.Size = New System.Drawing.Size(462, 68)
        Me.gamename.TabIndex = 5
        Me.gamename.Text = "2D Hockey"
        '
        'MainMenu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global._2DHockey.My.Resources.Resources.mainMenuBackground
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(885, 557)
        Me.Controls.Add(Me.gamename)
        Me.Controls.Add(Me.exitButton)
        Me.Controls.Add(Me.Aboutbutton)
        Me.Controls.Add(Me.Optionbutton)
        Me.Controls.Add(Me.playbutton)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "MainMenu"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "MainMenu"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents playbutton As System.Windows.Forms.Button
    Friend WithEvents Optionbutton As System.Windows.Forms.Button
    Friend WithEvents Aboutbutton As System.Windows.Forms.Button
    Friend WithEvents exitButton As System.Windows.Forms.Button
    Friend WithEvents gamename As System.Windows.Forms.Label
End Class
