Public Class OptionsMenu

    Private Sub OptionsMenu_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Musicon.Checked = True
        If Musicoff.Checked = True Then  'makes sure that always one radio button is checked and turns on or off the music
            Musicon.Checked = False
        ElseIf Musicon.Checked = True Then
            Musicoff.Checked = False
        End If

        optionlbl.Font = CustomFont.GetInstance(48, FontStyle.Regular)              'Changes the font to the custom font in resources
        Musicname.Font = CustomFont.GetInstance(27.25, FontStyle.Regular)
        Pointsetter.Font = CustomFont.GetInstance(27.25, FontStyle.Regular)
    End Sub

    Private Sub Musicoff_CheckedChanged(sender As Object, e As EventArgs) Handles Musicoff.CheckedChanged
        'code that toggles the sounds on/off
        My.Computer.Audio.Stop()
        GlobalVariables.sounds = False
        If Musicoff.Checked = False Then
            My.Computer.Audio.Play(My.Resources.Main_Screen_Music_wav_file, _
   AudioPlayMode.BackgroundLoop)
            GlobalVariables.sounds = True
        End If
    End Sub

    Private Sub backbutton_Click(sender As Object, e As EventArgs) Handles backbutton.Click
        Me.Hide()
        MainMenu.Show()
    End Sub


End Class

Public Class GlobalVariables
    Public Shared sounds As Boolean = True
End Class

