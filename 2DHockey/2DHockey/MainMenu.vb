Public Class MainMenu

    Private Sub MainMenu_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub playbutton_Click(sender As Object, e As EventArgs) Handles playbutton.Click
        TeamSelection.Show()
        Me.Hide()
    End Sub
End Class