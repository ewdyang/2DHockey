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
        Me.SuspendLayout()
        '
        'optionlbl
        '
        Me.optionlbl.AutoSize = True
        Me.optionlbl.BackColor = System.Drawing.Color.Transparent
        Me.optionlbl.Font = New System.Drawing.Font("Aircruiser", 48.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.optionlbl.ForeColor = System.Drawing.Color.DarkRed
        Me.optionlbl.Location = New System.Drawing.Point(79, 46)
        Me.optionlbl.Name = "optionlbl"
        Me.optionlbl.Size = New System.Drawing.Size(354, 64)
        Me.optionlbl.TabIndex = 0
        Me.optionlbl.Text = "OPTIONS"
        '
        'Musicname
        '
        Me.Musicname.AutoSize = True
        Me.Musicname.BackColor = System.Drawing.Color.Transparent
        Me.Musicname.Font = New System.Drawing.Font("Aircruiser", 27.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Musicname.ForeColor = System.Drawing.Color.DarkRed
        Me.Musicname.Location = New System.Drawing.Point(83, 139)
        Me.Musicname.Name = "Musicname"
        Me.Musicname.Size = New System.Drawing.Size(146, 38)
        Me.Musicname.TabIndex = 4
        Me.Musicname.Text = "Music"
        '
        'backbutton
        '
        Me.backbutton.BackColor = System.Drawing.Color.DarkBlue
        Me.backbutton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.backbutton.Font = New System.Drawing.Font("Aircruiser", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.backbutton.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.backbutton.Location = New System.Drawing.Point(108, 455)
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
        Me.Musicon.Font = New System.Drawing.Font("Aircruiser", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Musicon.ForeColor = System.Drawing.Color.DarkBlue
        Me.Musicon.Location = New System.Drawing.Point(108, 210)
        Me.Musicon.Name = "Musicon"
        Me.Musicon.Size = New System.Drawing.Size(68, 29)
        Me.Musicon.TabIndex = 6
        Me.Musicon.TabStop = True
        Me.Musicon.Text = "ON"
        Me.Musicon.UseVisualStyleBackColor = False
        '
        'Musicoff
        '
        Me.Musicoff.AutoSize = True
        Me.Musicoff.BackColor = System.Drawing.Color.Transparent
        Me.Musicoff.Font = New System.Drawing.Font("Aircruiser", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Musicoff.ForeColor = System.Drawing.Color.DarkBlue
        Me.Musicoff.Location = New System.Drawing.Point(182, 210)
        Me.Musicoff.Name = "Musicoff"
        Me.Musicoff.Size = New System.Drawing.Size(83, 29)
        Me.Musicoff.TabIndex = 7
        Me.Musicoff.TabStop = True
        Me.Musicoff.Text = "OFF"
        Me.Musicoff.UseVisualStyleBackColor = False
        '
        'OptionsMenu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global._2DHockey.My.Resources.Resources.main_menu
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(885, 557)
        Me.Controls.Add(Me.Musicoff)
        Me.Controls.Add(Me.Musicon)
        Me.Controls.Add(Me.backbutton)
        Me.Controls.Add(Me.Musicname)
        Me.Controls.Add(Me.optionlbl)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "OptionsMenu"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "OptionsMenu"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents optionlbl As System.Windows.Forms.Label
    Friend WithEvents Musicname As System.Windows.Forms.Label
    Friend WithEvents backbutton As System.Windows.Forms.Button
    Friend WithEvents Musicon As System.Windows.Forms.RadioButton
    Friend WithEvents Musicoff As System.Windows.Forms.RadioButton
End Class
