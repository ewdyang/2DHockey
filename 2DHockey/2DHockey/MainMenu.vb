Public Class MainMenu

    Private Sub MainMenu_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If OptionsMenu.Musicoff.Checked Then
            My.Computer.Audio.Stop()
        Else
            My.Computer.Audio.Play(My.Resources.Main_Screen_Music_wav_file, _
AudioPlayMode.BackgroundLoop)
        End If
       


    End Sub

    Private Sub playbutton_Click(sender As Object, e As EventArgs) Handles playbutton.Click
        TeamSelection.Show()
        Me.Hide()
    End Sub

    Private Sub exitButton_Click(sender As Object, e As EventArgs) Handles exitButton.Click
        End
    End Sub

    Private Sub Optionbutton_Click(sender As Object, e As EventArgs) Handles Optionbutton.Click
        OptionsMenu.Show()
        Me.Hide()
    End Sub
End Class