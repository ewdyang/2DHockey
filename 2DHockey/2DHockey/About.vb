Public Class About

    Private Sub backbutton_Click(sender As Object, e As EventArgs) Handles backbutton.Click
        Me.Close()                  'Hides the about page
        MainMenu.Show()             'Shows the main menu
    End Sub

    Private Sub About_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ChangeFonts()
    End Sub

    Private Sub ChangeFonts()
        'Changes the fonts to the custom fonts in the resources
        Title.Font = Aircruiser.GetInstance(60, FontStyle.Regular)          'Changes the title to aircruiser
        Description.Font = Aircruiser.GetInstance(18, FontStyle.Regular)          'Changes the title to aircruiser
        Devs.Font = Aircruiser.GetInstance(21.75, FontStyle.Regular)          'Changes the title to aircruiser
    End Sub
End Class