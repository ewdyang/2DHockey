Public Class OptionsMenu
    Private Sub OptionsMenu_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Musicon.Checked = True
        If Musicoff.Checked = True Then  'makes sure that always one radio button is checked and turns on or off the music
            Musicon.Checked = False
        ElseIf Musicon.Checked = True Then
            Musicoff.Checked = False
        End If
        points7.Checked = True
        If points7.Checked = True Then
            points5.Checked = False
            points9.Checked = False
        ElseIf points5.Checked = True Then
            points7.Checked = False
            points9.Checked = False
        Else
            points5.Checked = False
            points7.Checked = False
        End If
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
End Class