Public Class TeamSelection
    Public lUser As Integer                    'Used to display the current team that player 1 has selected 
    Public rUser As Integer                    'Used to display the current team that player 2 has selected

    Private Sub TeamSelection_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lUserPlayerTeam.Image = playerSprites.Images(0)
        rUserPlayerTeam.Image = playerSprites.Images(0)
        optionlbl.Font = CustomFont.GetInstance(50, FontStyle.Regular)
    End Sub

    Private Sub P1Left_Click(sender As Object, e As EventArgs) Handles llUsereft.Click
        If lUser = 0 Then
            lUser = 4
        Else
            lUser = lUser - 1
        End If
        lUserPlayerTeam.Image = playerSprites.Images(lUser)            'Changes player 1's team
    End Sub

    Private Sub P1Right_Click(sender As Object, e As EventArgs) Handles lUserRight.Click
        If lUser = 4 Then
            lUser = 0
        Else
            lUser = lUser + 1
        End If
        lUserPlayerTeam.Image = playerSprites.Images(lUser)            'Changes player 1's team
    End Sub

    Private Sub P2Left_Click(sender As Object, e As EventArgs) Handles rlUsereft.Click
        If rUser = 0 Then
            rUser = 4
        Else
            rUser = rUser - 1
        End If
        rUserPlayerTeam.Image = playerSprites.Images(rUser)            'Changes player 1's team
    End Sub

    Private Sub P2Right_Click(sender As Object, e As EventArgs) Handles rUserRight.Click
        If rUser = 4 Then
            rUser = 0
        Else
            rUser = rUser + 1
        End If
        rUserPlayerTeam.Image = playerSprites.Images(rUser)            'Changes player 1's team
    End Sub

    Private Sub P1Confirm_Click(sender As Object, e As EventArgs) Handles lUserConfirm.Click
        If llUsereft.Enabled = True Then
            llUsereft.Enabled = False
            lUserRight.Enabled = False
            lUserConfirm.Text = "Cancel"
        Else
            llUsereft.Enabled = True
            lUserRight.Enabled = True
            lUserConfirm.Text = "Confirm"
        End If

        If rUserConfirm.Text = "Cancel" Then
            MainGame.Show()
            Me.Hide()
        End If
    End Sub

    Private Sub P2Confirm_Click(sender As Object, e As EventArgs) Handles rUserConfirm.Click
        If rlUsereft.Enabled = True Then
            rlUsereft.Enabled = False
            rUserRight.Enabled = False
            rUserConfirm.Text = "Cancel"
        Else
            rlUsereft.Enabled = True
            rUserRight.Enabled = True
            rUserConfirm.Text = "Confirm"
        End If

        If lUserConfirm.Text = "Cancel" Then
            MainGame.Show()
            Me.Hide()
        End If
    End Sub

    Private Sub backbutton_Click(sender As Object, e As EventArgs) Handles backbutton.Click
        Me.Hide()
        MainMenu.Show()
    End Sub

    Public Sub resetTeamSelectionForm()
        lUser = 0
        rUser = 0
        lUserPlayerTeam.Image = playerSprites.Images(lUser)
        rUserPlayerTeam.Image = playerSprites.Images(rUser)
    End Sub
End Class