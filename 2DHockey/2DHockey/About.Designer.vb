<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class About
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
        Me.Title = New System.Windows.Forms.Label()
        Me.Description = New System.Windows.Forms.Label()
        Me.Devs = New System.Windows.Forms.Label()
        Me.backbutton = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Title
        '
        Me.Title.AutoSize = True
        Me.Title.BackColor = System.Drawing.Color.Transparent
        Me.Title.Font = New System.Drawing.Font("Aircruiser", 60.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Title.ForeColor = System.Drawing.Color.DarkBlue
        Me.Title.Location = New System.Drawing.Point(269, 46)
        Me.Title.Name = "Title"
        Me.Title.Size = New System.Drawing.Size(346, 80)
        Me.Title.TabIndex = 9
        Me.Title.Text = "About"
        '
        'Description
        '
        Me.Description.BackColor = System.Drawing.Color.Transparent
        Me.Description.Font = New System.Drawing.Font("Aircruiser", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Description.ForeColor = System.Drawing.Color.White
        Me.Description.Location = New System.Drawing.Point(68, 168)
        Me.Description.Name = "Description"
        Me.Description.Size = New System.Drawing.Size(353, 245)
        Me.Description.TabIndex = 11
        Me.Description.Text = "This is a 2 dimensional hockey game made by Grade 10 students for Mrs. Kutschke's" & _
    "" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "ICS2O summative. The game was designed in collaboration with grade 5 students " & _
    "" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Ethan and Ayman." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'Devs
        '
        Me.Devs.BackColor = System.Drawing.Color.Transparent
        Me.Devs.Font = New System.Drawing.Font("Aircruiser", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Devs.ForeColor = System.Drawing.Color.White
        Me.Devs.Location = New System.Drawing.Point(528, 200)
        Me.Devs.Name = "Devs"
        Me.Devs.Size = New System.Drawing.Size(281, 162)
        Me.Devs.TabIndex = 12
        Me.Devs.Text = "Developpers:" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Edward Yang" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Ryan Shi" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Derek Xu" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Kevin Zhu" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'backbutton
        '
        Me.backbutton.BackColor = System.Drawing.Color.DarkBlue
        Me.backbutton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.backbutton.Font = New System.Drawing.Font("Aircruiser", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.backbutton.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.backbutton.Location = New System.Drawing.Point(282, 453)
        Me.backbutton.Name = "backbutton"
        Me.backbutton.Size = New System.Drawing.Size(293, 39)
        Me.backbutton.TabIndex = 13
        Me.backbutton.Text = "Back"
        Me.backbutton.UseVisualStyleBackColor = False
        '
        'About
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global._2DHockey.My.Resources.Resources.teamSelectionBackground
        Me.ClientSize = New System.Drawing.Size(869, 519)
        Me.Controls.Add(Me.backbutton)
        Me.Controls.Add(Me.Devs)
        Me.Controls.Add(Me.Description)
        Me.Controls.Add(Me.Title)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "About"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "About"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Title As System.Windows.Forms.Label
    Friend WithEvents Description As System.Windows.Forms.Label
    Friend WithEvents Devs As System.Windows.Forms.Label
    Friend WithEvents backbutton As System.Windows.Forms.Button
End Class
