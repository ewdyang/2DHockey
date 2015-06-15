Public Class About

    Private Sub backbutton_Click(sender As Object, e As EventArgs) Handles backbutton.Click
        Me.Close()                  'Hides the about page
        MainMenu.Show()             'Shows the main menu
    End Sub

    Private Sub About_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Title.Font = CustomFont.GetInstance(60, FontStyle.Regular)          'Changes the title to aircruiser
    End Sub
End Class