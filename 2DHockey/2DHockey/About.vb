Public Class About

    Private Sub backbutton_Click(sender As Object, e As EventArgs) Handles backbutton.Click
        Me.Close()                  'Hides the about page
        MainMenu.Show()             'Shows the main menu
    End Sub
End Class