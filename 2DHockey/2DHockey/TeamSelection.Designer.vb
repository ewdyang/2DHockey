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
        Me.ImageList1 = New System.Windows.Forms.ImageList(Me.components)
        Me.Player1 = New System.Windows.Forms.PictureBox()
        Me.Player2 = New System.Windows.Forms.PictureBox()
        Me.P1Left = New System.Windows.Forms.Button()
        Me.P1Right = New System.Windows.Forms.Button()
        Me.P2Left = New System.Windows.Forms.Button()
        Me.P2Right = New System.Windows.Forms.Button()
        Me.P2Confirm = New System.Windows.Forms.Button()
        Me.P1Confirm = New System.Windows.Forms.Button()
        CType(Me.Player1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Player2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ImageList1
        '
        Me.ImageList1.ImageStream = CType(resources.GetObject("ImageList1.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.ImageList1.TransparentColor = System.Drawing.Color.Transparent
        Me.ImageList1.Images.SetKeyName(0, "BluePlayer2.png")
        Me.ImageList1.Images.SetKeyName(1, "GreenPlayer2.png")
        Me.ImageList1.Images.SetKeyName(2, "OrangePlayer2.png")
        Me.ImageList1.Images.SetKeyName(3, "RedPlayer2.png")
        Me.ImageList1.Images.SetKeyName(4, "WhitePlayer2.png")
        '
        'Player1
        '
        Me.Player1.BackColor = System.Drawing.Color.Transparent
        Me.Player1.Image = Global._2DHockey.My.Resources.Resources.BluePlayer2
        Me.Player1.Location = New System.Drawing.Point(107, 120)
        Me.Player1.Name = "Player1"
        Me.Player1.Size = New System.Drawing.Size(150, 150)
        Me.Player1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Player1.TabIndex = 0
        Me.Player1.TabStop = False
        '
        'Player2
        '
        Me.Player2.BackColor = System.Drawing.Color.Transparent
        Me.Player2.Image = Global._2DHockey.My.Resources.Resources.BluePlayer2
        Me.Player2.InitialImage = Nothing
        Me.Player2.Location = New System.Drawing.Point(361, 120)
        Me.Player2.Name = "Player2"
        Me.Player2.Size = New System.Drawing.Size(150, 150)
        Me.Player2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Player2.TabIndex = 1
        Me.Player2.TabStop = False
        '
        'P1Left
        '
        Me.P1Left.Location = New System.Drawing.Point(107, 335)
        Me.P1Left.Name = "P1Left"
        Me.P1Left.Size = New System.Drawing.Size(59, 23)
        Me.P1Left.TabIndex = 2
        Me.P1Left.Text = "Left"
        Me.P1Left.UseVisualStyleBackColor = True
        '
        'P1Right
        '
        Me.P1Right.Location = New System.Drawing.Point(198, 335)
        Me.P1Right.Name = "P1Right"
        Me.P1Right.Size = New System.Drawing.Size(59, 23)
        Me.P1Right.TabIndex = 3
        Me.P1Right.Text = "Right"
        Me.P1Right.UseVisualStyleBackColor = True
        '
        'P2Left
        '
        Me.P2Left.Location = New System.Drawing.Point(361, 335)
        Me.P2Left.Name = "P2Left"
        Me.P2Left.Size = New System.Drawing.Size(59, 23)
        Me.P2Left.TabIndex = 4
        Me.P2Left.Text = "Left"
        Me.P2Left.UseVisualStyleBackColor = True
        '
        'P2Right
        '
        Me.P2Right.Location = New System.Drawing.Point(452, 335)
        Me.P2Right.Name = "P2Right"
        Me.P2Right.Size = New System.Drawing.Size(59, 23)
        Me.P2Right.TabIndex = 5
        Me.P2Right.Text = "Right"
        Me.P2Right.UseVisualStyleBackColor = True
        '
        'P2Confirm
        '
        Me.P2Confirm.Location = New System.Drawing.Point(403, 388)
        Me.P2Confirm.Name = "P2Confirm"
        Me.P2Confirm.Size = New System.Drawing.Size(75, 23)
        Me.P2Confirm.TabIndex = 6
        Me.P2Confirm.Text = "Confirm"
        Me.P2Confirm.UseVisualStyleBackColor = True
        '
        'P1Confirm
        '
        Me.P1Confirm.Location = New System.Drawing.Point(142, 388)
        Me.P1Confirm.Name = "P1Confirm"
        Me.P1Confirm.Size = New System.Drawing.Size(75, 23)
        Me.P1Confirm.TabIndex = 7
        Me.P1Confirm.Text = "Confirm"
        Me.P1Confirm.UseVisualStyleBackColor = True
        '
        'TeamSelection
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global._2DHockey.My.Resources.Resources.Background
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.ClientSize = New System.Drawing.Size(606, 455)
        Me.Controls.Add(Me.P1Confirm)
        Me.Controls.Add(Me.P2Confirm)
        Me.Controls.Add(Me.P2Right)
        Me.Controls.Add(Me.P2Left)
        Me.Controls.Add(Me.P1Right)
        Me.Controls.Add(Me.P1Left)
        Me.Controls.Add(Me.Player2)
        Me.Controls.Add(Me.Player1)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "TeamSelection"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "TeamSelection"
        CType(Me.Player1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Player2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents ImageList1 As System.Windows.Forms.ImageList
    Friend WithEvents Player1 As System.Windows.Forms.PictureBox
    Friend WithEvents Player2 As System.Windows.Forms.PictureBox
    Friend WithEvents P1Left As System.Windows.Forms.Button
    Friend WithEvents P1Right As System.Windows.Forms.Button
    Friend WithEvents P2Left As System.Windows.Forms.Button
    Friend WithEvents P2Right As System.Windows.Forms.Button
    Friend WithEvents P2Confirm As System.Windows.Forms.Button
    Friend WithEvents P1Confirm As System.Windows.Forms.Button
End Class
