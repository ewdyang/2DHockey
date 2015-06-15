Public Class TeamSelection
    Public team1 As Integer                    'Used to display the current team that player 1 has selected 
    Public team2 As Integer                    'Used to display the current team that player 2 has selected

    Private Sub TeamSelection_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Player1.Image = ImageList1.Images(0)
        Player2.Image = ImageList1.Images(0)

        optionlbl.Font = CustomFont.GetInstance(50, FontStyle.Regular)
    End Sub

    Private Sub P1Left_Click(sender As Object, e As EventArgs) Handles P1Left.Click
        If team1 = 0 Then
            team1 = 4
        Else
            team1 = team1 - 1
        End If
        Player1.Image = ImageList1.Images(team1)            'Changes player 1's team
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles P1Right.Click
        If team1 = 4 Then
            team1 = 0
        Else
            team1 = team1 + 1
        End If
        Player1.Image = ImageList1.Images(team1)            'Changes player 1's team
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles P2Left.Click
        If team2 = 0 Then
            team2 = 4
        Else
            team2 = team2 - 1
        End If
        Player2.Image = ImageList1.Images(team2)            'Changes player 1's team
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles P2Right.Click
        If team2 = 4 Then
            team2 = 0
        Else
            team2 = team2 + 1
        End If
        Player2.Image = ImageList1.Images(team2)            'Changes player 1's team
    End Sub

    Private Sub P1Confirm_Click(sender As Object, e As EventArgs) Handles P1Confirm.Click
        If P1Left.Enabled = True Then
            P1Left.Enabled = False
            P1Right.Enabled = False
            P1Confirm.Text = "Cancel"
        Else
            P1Left.Enabled = True
            P1Right.Enabled = True
            P1Confirm.Text = "Confirm"
        End If

        If P2Confirm.Text = "Cancel" Then
            MainGame.Show()
            Me.Hide()
        End If
    End Sub

    Private Sub P2Confirm_Click(sender As Object, e As EventArgs) Handles P2Confirm.Click
        If P2Left.Enabled = True Then
            P2Left.Enabled = False
            P2Right.Enabled = False
            P2Confirm.Text = "Cancel"
        Else
            P2Left.Enabled = True
            P2Right.Enabled = True
            P2Confirm.Text = "Confirm"
        End If

        If P1Confirm.Text = "Cancel" Then
            MainGame.Show()
            Me.Hide()
        End If
    End Sub

    Private Sub backbutton_Click(sender As Object, e As EventArgs) Handles backbutton.Click
        Me.Hide()
        MainMenu.Show()
    End Sub
End Class