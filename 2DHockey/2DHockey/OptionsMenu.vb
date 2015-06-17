Public Class OptionsMenu

    Private Sub OptionsMenu_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Musicon.Checked = True
        If Musicoff.Checked = True Then  'makes sure that always one radio button is checked and turns on or off the music
            Musicon.Checked = False
        ElseIf Musicon.Checked = True Then
            Musicoff.Checked = False
        End If

        ChangeFonts()
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

    Private Sub ChangeFonts()
        'Changes the fonts to the custom fonts in the resources

        optionlbl.Font = Aircruiser.GetInstance(48, FontStyle.Regular)
        Musicname.Font = Aircruiser.GetInstance(27.25, FontStyle.Regular)
        Pointsetter.Font = Aircruiser.GetInstance(27.25, FontStyle.Regular)
        Musicon.Font = Aircruiser.GetInstance(18, FontStyle.Regular)
        Musicoff.Font = Aircruiser.GetInstance(18, FontStyle.Regular)
        points5.Font = Aircruiser.GetInstance(18, FontStyle.Regular)
        points7.Font = Aircruiser.GetInstance(18, FontStyle.Regular)
        points9.Font = Aircruiser.GetInstance(18, FontStyle.Regular)
    End Sub

End Class

Public Class GlobalVariables
    Public Shared sounds As Boolean = True
End Class

