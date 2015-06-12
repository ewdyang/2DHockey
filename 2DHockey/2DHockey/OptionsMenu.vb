Public Class OptionsMenu
    Private Sub OptionsMenu_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Musicon.Checked = True
        If Musicoff.Checked = True Then  'makes sure that always one radio button is checked and turns on or off the music
            Musicon.Checked = False
        ElseIf Musicon.Checked = True Then
            Musicoff.Checked = False
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
        Me.Hide()
        MainMenu.Show()
    End Sub
End Class