Public Class OptionsMenu
    Public optionPointsNeeded As Integer = 7

    Private Sub OptionsMenu_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Musicon.Checked = True
        If Musicoff.Checked = True Then  'makes sure that always one radio button is checked and turns on or off the music
            Musicon.Checked = False
        ElseIf Musicon.Checked = True Then
            Musicoff.Checked = False
        End If
        points7.Checked = True
        optionlbl.Font = CustomFont.GetInstance(48, FontStyle.Regular)              'Changes the font to the custom font in resources
        Musicname.Font = CustomFont.GetInstance(27.25, FontStyle.Regular)
        Pointsetter.Font = CustomFont.GetInstance(27.25, FontStyle.Regular)
    End Sub

    Private Sub Musicoff_CheckedChanged(sender As Object, e As EventArgs) Handles Musicoff.CheckedChanged
        My.Computer.Audio.Stop()
        If Musicoff.Checked = False Then
            My.Computer.Audio.Play(My.Resources.Main_Screen_Music_wav_file, _
   AudioPlayMode.BackgroundLoop)
        End If
    End Sub

    Private Sub backbutton_Click(sender As Object, e As EventArgs) Handles backbutton.Click
        Me.Visible = False
        MainMenu.Visible = True
    End Sub
    Private Sub points5_CheckedChanged(sender As Object, e As EventArgs) Handles points5.CheckedChanged
        optionPointsNeeded = 5
    End Sub

    Private Sub points7_CheckedChanged(sender As Object, e As EventArgs) Handles points7.CheckedChanged
        optionPointsNeeded = 7
    End Sub

    Private Sub points9_CheckedChanged(sender As Object, e As EventArgs) Handles points9.CheckedChanged
        optionPointsNeeded = 9
    End Sub
End Class