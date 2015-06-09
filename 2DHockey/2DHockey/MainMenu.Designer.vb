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
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.playbutton = New System.Windows.Forms.Button()
        Me.Optionbutton = New System.Windows.Forms.Button()
        Me.Aboutbutton = New System.Windows.Forms.Button()
        Me.exitButton = New System.Windows.Forms.Button()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(59, 34)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(355, 102)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'playbutton
        '
        Me.playbutton.BackColor = System.Drawing.Color.DarkBlue
        Me.playbutton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.playbutton.Font = New System.Drawing.Font("Aircruiser", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.playbutton.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.playbutton.Location = New System.Drawing.Point(92, 168)
        Me.playbutton.Name = "playbutton"
        Me.playbutton.Size = New System.Drawing.Size(263, 31)
        Me.playbutton.TabIndex = 1
        Me.playbutton.Text = "Play"
        Me.playbutton.UseVisualStyleBackColor = False
        '
        'Optionbutton
        '
        Me.Optionbutton.BackColor = System.Drawing.Color.DarkBlue
        Me.Optionbutton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.Optionbutton.Font = New System.Drawing.Font("Aircruiser", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Optionbutton.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Optionbutton.Location = New System.Drawing.Point(92, 243)
        Me.Optionbutton.Name = "Optionbutton"
        Me.Optionbutton.Size = New System.Drawing.Size(263, 31)
        Me.Optionbutton.TabIndex = 2
        Me.Optionbutton.Text = "Options"
        Me.Optionbutton.UseVisualStyleBackColor = False
        '
        'Aboutbutton
        '
        Me.Aboutbutton.BackColor = System.Drawing.Color.DarkBlue
        Me.Aboutbutton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.Aboutbutton.Font = New System.Drawing.Font("Aircruiser", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Aboutbutton.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Aboutbutton.Location = New System.Drawing.Point(92, 330)
        Me.Aboutbutton.Name = "Aboutbutton"
        Me.Aboutbutton.Size = New System.Drawing.Size(263, 31)
        Me.Aboutbutton.TabIndex = 3
        Me.Aboutbutton.Text = "About"
        Me.Aboutbutton.UseVisualStyleBackColor = False
        '
        'exitButton
        '
        Me.exitButton.BackColor = System.Drawing.Color.DarkBlue
        Me.exitButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.exitButton.Font = New System.Drawing.Font("Aircruiser", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.exitButton.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.exitButton.Location = New System.Drawing.Point(92, 418)
        Me.exitButton.Name = "exitButton"
        Me.exitButton.Size = New System.Drawing.Size(263, 31)
        Me.exitButton.TabIndex = 4
        Me.exitButton.Text = "Exit"
        Me.exitButton.UseVisualStyleBackColor = False
        '
        'MainMenu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(885, 557)
        Me.Controls.Add(Me.exitButton)
        Me.Controls.Add(Me.Aboutbutton)
        Me.Controls.Add(Me.Optionbutton)
        Me.Controls.Add(Me.playbutton)
        Me.Controls.Add(Me.PictureBox1)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "MainMenu"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "MainMenu"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents playbutton As System.Windows.Forms.Button
    Friend WithEvents Optionbutton As System.Windows.Forms.Button
    Friend WithEvents Aboutbutton As System.Windows.Forms.Button
    Friend WithEvents exitButton As System.Windows.Forms.Button
End Class
