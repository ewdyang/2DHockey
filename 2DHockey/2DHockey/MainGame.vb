Public Class MainGame
    Dim puckXV, puckYV As Integer 'Puck's X and Y Velocity
    Dim playerXV, playerYV As Integer 'Player's X and Y Velocity
    Dim lUserGoalieYV As Integer = 2 'userGoalie's Y velocitiy
    Dim rUserGoalieYV As Integer = 2 'rUserGoalie's Y velocitiy
    Dim lUserPlayerAccelerating, rUserPlayerAccelerating As Boolean 'Whether the player is in the process of accelerating
    Dim heldByPlayer As Boolean 'Whether the puck is held by the player
    Dim heldByWhichTeam As String 'which team has possession of the puck
    Dim lUserScore, rUserScore As Integer 'the scores of the respective teams
    Dim Framenum As Integer = 0 'used in animation of the players
    Dim goalieMovementCounter As Integer 'counts the amount of ticks since the goalie last randomly switched directions
    Dim goalieMovementInterval As Integer = 30 ' amount of ticks before the goalie randomly switches directions

    Dim maxPlayerSpeed As Integer = 5 'max speed a player can accelerate to
    Dim playerAccelerationSpeed As Integer = 5 'increments the player accelerates by
    Dim lUserPlayerDirection As Integer '0: left, 1: right :used in animation/shooting
    Dim rUserPlayerDirection As Integer '0: left, 1: right :used in animation/shooting

    Dim puckResetPosition As New Point(382, 185) 'reset positions for all moving objects
    Dim lUserPlayerResetPosition As New Point(255, 165)
    Dim rUserPlayerResetPosition As New Point(478, 165)
    Dim lUserGoalieResetPosition As New Point(136, 167)
    Dim rUserGoalieResetPosition As New Point(599, 167)
    Dim countdown As Integer = 4
    Dim winshowtime As Integer = 2
    Dim buzzertimer As Integer
    Dim starttimer As Integer
    Dim ILOVEEDWARD As Boolean = False

    Private Sub Tick_Tick(sender As Object, e As EventArgs) Handles tick.Tick 'Calculates movement of all objects every tick (10 milliseconds)
        'followMouse(player) 'old controls of having player follow the mouse
        checkForGoal() 'checks if a goal has been made
        moveObject(lUserPlayer, playerXV, playerYV, lUserPlayerAccelerating) 'calculates movement of player
        moveGoalie(lUserGoalie, lUserGoalieYV) 'moves userGoalie
        moveGoalie(rUserGoalie, rUserGoalieYV) 'moves rUserGoalie
        If objectCollisionDetect(puck, lUserGoalie) Then 'deflects puck if touched by goalie
            heldByPlayer = False
            puckXV = 15
        ElseIf objectCollisionDetect(puck, rUserGoalie) Then
            heldByPlayer = False
            puckXV = -15
        End If

        If objectCollisionDetect(puck, lUserPlayer) Then 'checks if and which player is touching puck
            heldByWhichTeam = "lUser"
            heldByPlayer = True
        ElseIf objectCollisionDetect(puck, rUserPlayer) Then
            heldByWhichTeam = "rUser"
            heldByPlayer = True
        End If

        If heldByPlayer = True Then 'makes puck follow the appropriate player if held or normally if not held
            If heldByWhichTeam = "lUser" Then
                followPlayer(puck, lUserPlayer, lUserPlayerDirection) 'makes the puck follow the user player
            ElseIf heldByWhichTeam = "rUser" Then
                followPlayer(puck, rUserPlayer, rUserPlayerDirection) 'makes the puck follow the rUser player
            End If
        Else
            moveObject(puck, puckXV, puckYV) 'puck moves normally
        End If
    End Sub

    Private Sub arrowControls(sender As Object, e As KeyEventArgs) Handles Me.KeyDown 'Allows for control of player using arrow keys
        FrameTimer.Start()
        Select Case e.KeyCode
            Case Keys.Left 'left arrow key
                If playerXV > -maxPlayerSpeed Then 'caps player max speed
                    playerXV = playerXV - playerAccelerationSpeed 'sets speed
                End If
                lUserPlayerAccelerating = True 'player is accelerating
                e.Handled = True 'control has been handled
                animatePlayer(lUserPlayer, "left")
            Case Keys.Right 'right arrow key
                If playerXV < maxPlayerSpeed Then
                    playerXV = playerXV + playerAccelerationSpeed
                End If
                lUserPlayerAccelerating = True
                e.Handled = True
                animatePlayer(lUserPlayer, "right")
            Case Keys.Up 'up arrow key
                If playerYV > -maxPlayerSpeed Then
                    playerYV = playerYV - playerAccelerationSpeed
                End If
                lUserPlayerAccelerating = True
                e.Handled = True
                animatePlayer(lUserPlayer, "up")
            Case Keys.Down 'down arrow key
                If playerYV < maxPlayerSpeed Then
                    playerYV = playerYV + playerAccelerationSpeed
                End If
                lUserPlayerAccelerating = True
                e.Handled = True
                animatePlayer(lUserPlayer, "down")
            Case Keys.Space
                shoot(lUserPlayerDirection)
        End Select
    End Sub

    Private Sub Bouncing_KeyUp(sender As Object, e As KeyEventArgs) Handles Me.KeyUp 'resets playerAccelerating after key is unpressed
        FrameTimer.Stop()
        Framenum = 0
        Select Case e.KeyCode
            Case Keys.Left, Keys.Right, Keys.Up, Keys.Down
                lUserPlayerAccelerating = False

        End Select
    End Sub

    Private Sub MainGame_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Randomize()
        rUserNet.Image.RotateFlip(RotateFlipType.Rotate180FlipY)
        Select Case TeamSelection.lUser
            Case 0
                lUserPlayer.Image = blueAnimation.Images(0)
            Case 1
                lUserPlayer.Image = greenAnimation.Images(0)
            Case 2
                lUserPlayer.Image = orangeAnimation.Images(0)
            Case 3
                lUserPlayer.Image = redAnimation.Images(0)
            Case 4
                lUserPlayer.Image = whiteAnimation.Images(0)
        End Select
        Select Case TeamSelection.rUser
            Case 0
                rUserPlayer.Image = blueAnimation.Images(0)
            Case 1
                rUserPlayer.Image = greenAnimation.Images(0)
            Case 2
                rUserPlayer.Image = orangeAnimation.Images(0)
            Case 3
                rUserPlayer.Image = redAnimation.Images(0)
            Case 4
                rUserPlayer.Image = whiteAnimation.Images(0)
        End Select
        lUserGoalie.Image = goalieColours.Images(TeamSelection.lUser)
        rUserGoalie.Image = goalieColours.Images(TeamSelection.rUser)
        lUserPlayer.Image.RotateFlip(RotateFlipType.Rotate180FlipY)
        lUserGoalie.Image.RotateFlip(RotateFlipType.Rotate180FlipY)
        resumebtn.Font = CustomFont.GetInstance(15.75, FontStyle.Regular)
        Quitbtn.Font = CustomFont.GetInstance(15.75, FontStyle.Regular)
        If GlobalVariables.sounds = True Then
            My.Computer.Audio.Play(My.Resources.LETSAGO, _
    AudioPlayMode.Background)
        End If
        count.Start()
        Start.Start()

        puck.Visible = False
        Golbl.Visible = False
        Winlbl.Visible = False
    End Sub

    Sub moveObject(ByVal movingObject As PictureBox, ByRef objectXV As Integer, ByRef objectYV As Integer, Optional ByRef objectAccelerating As Boolean = False) 'Moves an object according to it's X and Y velocity
        Dim newLocation As Point
        edgeCollisionDetect(movingObject, objectXV, objectYV)
        newLocation.X = movingObject.Location.X + objectXV
        newLocation.Y = movingObject.Location.Y + objectYV
        If objectAccelerating = False Then
            If objectXV > 0 Then
                objectXV = objectXV - 1
            ElseIf objectXV < 0 Then
                objectXV = objectXV + 1
            End If
            If objectYV > 0 Then
                objectYV = objectYV - 1
            ElseIf objectYV < 0 Then
                objectYV = objectYV + 1
            End If
        End If
        movingObject.Location = newLocation
    End Sub

    Sub edgeCollisionDetect(ByVal bouncingObject, ByRef objectXV, ByRef objectYV) 'checks if an object is bouncing into the walls of the form, then changes its velocity to make it bounce
        If bouncingObject.Location.X < 50 Then
            objectXV = Math.Abs(objectXV)
        ElseIf bouncingObject.Location.X + bouncingObject.Width + 60 > Me.Width Then
            objectXV = -Math.Abs(objectXV)
        End If
        If bouncingObject.Location.Y < 50 Then
            objectYV = Math.Abs(objectYV)
        ElseIf bouncingObject.Location.Y + bouncingObject.Height + 200 > Me.Height Then
            objectYV = -Math.Abs(objectYV)
        End If
    End Sub

    Function objectCollisionDetect(ByVal object1, ByVal object2) As Boolean 'checks if two objects are touching
        If object1.Bounds.IntersectsWith(object2.Bounds) Then
            objectCollisionDetect = True
        Else
            objectCollisionDetect = False
        End If
    End Function

    Sub followMouse(ByVal followingObject) 'makes an object go to the mouse
        Dim newLocation As Point
        newLocation.X = MousePosition.X - followingObject.width / 2
        newLocation.Y = MousePosition.Y - followingObject.height / 2
        followingObject.location = PointToClient(newLocation)
    End Sub

    Sub followPlayer(ByVal followingPuck, ByVal followedPlayer, Optional ByVal side = 0) 'makes an object follow the player (used by the puck)
        Dim newlocation As Point
        Select Case side
            Case 0
                newlocation.X = followedPlayer.location.x - followingPuck.width + 10
                newlocation.Y = followedPlayer.location.y + followedPlayer.height + 4
            Case 1
                newlocation.X = followedPlayer.location.x + followedPlayer.width - 10
                newlocation.Y = followedPlayer.location.y + followedPlayer.height + 4
        End Select
        followingPuck.location = newlocation
    End Sub

    Private Sub shoot(ByVal playerDirection) 'makes the player shoot the puck, giving it a set forward velocity and random vertical velocity
        If heldByPlayer = True Then
            heldByPlayer = False
            puckYV = 10 - Rnd() * 20
            Select Case playerDirection
                Case 0
                    puckXV = -30
                Case 1
                    puckXV = 30
            End Select
        End If
    End Sub

    Sub moveGoalie(ByVal goalie, ByRef goalieYV)
        '110-210: Y value range where the goalies are allowed to move
        Dim newLocation As Point
        If goalieMovementCounter >= goalieMovementInterval Then
            If Int(Rnd() * 2) = 0 Then
                goalieYV = -goalieYV
            End If
            goalieMovementCounter = 0
        Else
            goalieMovementCounter += 1
        End If
        If goalie.Location.Y < 110 Then
            goalieYV = Math.Abs(goalieYV)
        ElseIf goalie.Location.Y > 210 Then
            goalieYV = -Math.Abs(goalieYV)
        End If
        newLocation.X = goalie.location.X
        newLocation.Y = goalie.Location.Y + goalieYV
        goalie.location = newLocation
    End Sub

    Sub checkForGoal()
        If objectCollisionDetect(puck, rUserNet) And puck.Location.X > lUserNet.Location.X + lUserNet.Width - 10 Then 'checks if puck is touching net and is past net
            If GlobalVariables.sounds = True Then
                My.Computer.Audio.Play(My.Resources.buzzer, _
            AudioPlayMode.Background)
            End If
            Buzzertime.Start()
            goalScored("lUser")

        ElseIf objectCollisionDetect(puck, lUserNet) And puck.Location.X + puck.Width < rUserNet.Location.X + 10 Then
            If GlobalVariables.sounds = True Then
                My.Computer.Audio.Play(My.Resources.buzzer, _
           AudioPlayMode.Background)
            End If
            Buzzertime.Start()
            goalScored("rUser")

            End If
    End Sub

    Private Sub Buzzertime_Tick(sender As Object, e As EventArgs) Handles Buzzertime.Tick
        buzzertimer = buzzertimer + 1
        If buzzertimer = 3 Then
            Buzzertime.Stop()
            If GlobalVariables.sounds = True Then
                My.Computer.Audio.Play(My.Resources.Main_Screen_Music_wav_file, _
    AudioPlayMode.BackgroundLoop)
            End If
            buzzertimer = 0
        End If
    End Sub

    Sub goalScored(ByVal scoringTeam As String) 'adds 1 to the score, then checks if any teams have at least 9 points, then triggers win if it's met
        If scoringTeam = "lUser" Then
            lUserScore += 1
            updateScoreBoard()
            resetGoal()

        ElseIf scoringTeam = "rUser" Then
            rUserScore += 1
            updateScoreBoard()
            resetGoal()
        End If
        If OptionsMenu.points5.Checked = True Then
            Buzzertime.Stop()
            buzzertimer = 0
            If lUserScore = 5 Then
                gameWin(scoringTeam)
            ElseIf rUserScore = 5 Then
                gameWin(scoringTeam)
            End If
        ElseIf OptionsMenu.points7.Checked = True Then
            Buzzertime.Stop()
            buzzertimer = 0
            If lUserScore = 7 Then
                gameWin(scoringTeam)
            ElseIf rUserScore = 7 Then
                gameWin(scoringTeam)
            End If
        ElseIf OptionsMenu.points9.Checked = True Then
            Buzzertime.Stop()
            buzzertimer = 0
            If lUserScore = 9 Then
                gameWin(scoringTeam)
            ElseIf rUserScore = 9 Then
                gameWin(scoringTeam)
            End If
        End If
    End Sub

    Sub gameWin(ByRef team As String) 'announces winner of the game and allows player to replay or return to main menu
        If team = "lUser" Then
            
            Winlbl.Text = "Team 1 wins!"
            Winlbl.Visible = True
            retire.Visible = True
            again.Visible = True
            If GlobalVariables.sounds = True Then
                My.Computer.Audio.Play(My.Resources.IHaveWonned, _
            AudioPlayMode.BackgroundLoop)
            End If
        ElseIf team = "rUser" Then

            Winlbl.Text = "Team 2 wins!"
            Winlbl.Visible = True
            retire.Visible = True
            again.Visible = True
            If GlobalVariables.sounds = True Then
                My.Computer.Audio.Play(My.Resources.IHaveWonned, _
           AudioPlayMode.BackgroundLoop)
            End If

        End If
            lUserScore = 0
            rUserScore = 0
            updateScoreBoard()
            resetGoal()
            tick.Stop()
            countdownlbl.Visible = True
            countdown = 4
            countdownlbl.Text = 3
    End Sub

    Sub updateScoreBoard() 'updates the scoreboard graphic to reflect the latest scores
        lUserScoreboard.Text = lUserScore
        rUserScoreboard.Text = rUserScore
    End Sub

    Sub resetGoal() 'resets the game after each goal
        tick.Stop()
        puckXV = 0
        puckYV = 0
        playerXV = 0
        playerYV = 0
        heldByPlayer = False
        puck.Location = puckResetPosition
        lUserPlayer.Location = lUserPlayerResetPosition
        rUserPlayer.Location = rUserPlayerResetPosition
        lUserGoalie.Location = lUserGoalieResetPosition
        rUserGoalie.Location = rUserGoalieResetPosition
        tick.Start()
    End Sub

    Sub resetGame() 'resets the game when it ends or is quit
        resetGoal()
        tick.Stop()
        lUserScore = 0
        rUserScore = 0
        updateScoreBoard()
        countdownlbl.Text = 3
    End Sub

    Sub animatePlayer(ByVal player As PictureBox, ByVal directionHeading As String)

        Select Case TeamSelection.lUser
            Case 0
                lUserPlayer.Image = blueAnimation.Images(Framenum)
            Case 1
                lUserPlayer.Image = greenAnimation.Images(Framenum)
            Case 2
                lUserPlayer.Image = orangeAnimation.Images(Framenum)
            Case 3
                lUserPlayer.Image = redAnimation.Images(Framenum)
            Case 4
                lUserPlayer.Image = whiteAnimation.Images(Framenum)
        End Select

        Select Case directionHeading
            Case "left"
                lUserPlayerDirection = 0
            Case "right"
                lUserPlayer.Image.RotateFlip(RotateFlipType.RotateNoneFlipX)
                lUserPlayerDirection = 1
            Case "up"
                If lUserPlayerDirection = 1 Then
                    lUserPlayer.Image.RotateFlip(RotateFlipType.RotateNoneFlipX)
                End If
            Case "down"
                If lUserPlayerDirection = 1 Then
                    lUserPlayer.Image.RotateFlip(RotateFlipType.RotateNoneFlipX)
                End If
        End Select
    End Sub

    Private Sub FrameTimer_Tick(sender As Object, e As EventArgs) Handles FrameTimer.Tick 'used for animating players
        Framenum = Framenum + 1
        If Framenum = 2 Then
            Framenum = 0
        End If
    End Sub

    Private Sub MainGame_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        TeamSelection.Close()
        tick.Stop()
    End Sub

    Sub pauseMenu()
        tick.Stop()
        pauseMenuPanel.Show()
    End Sub

    Private Sub Pausebutton_Click(sender As Object, e As EventArgs) Handles Pausebutton.Click
        pauseMenu()
    End Sub

    Private Sub resumebtn_Click(sender As Object, e As EventArgs) Handles resumebtn.Click
        pauseMenuPanel.Hide()
        tick.Start()
    End Sub

    Private Sub Quitbtn_Click(sender As Object, e As EventArgs) Handles Quitbtn.Click
        resetGame()
        pauseMenuPanel.Hide()
        TeamSelection.resetTeamSelectionForm()
        Me.Close()
        MainMenu.Visible = True
    End Sub

    Private Sub count_Tick(sender As Object, e As EventArgs) Handles count.Tick
        countdown = countdown - 1
        If countdown = 4 Then
            countdownlbl.Text = 3
        ElseIf countdown = 3 Then
            countdownlbl.Text = 2
        ElseIf countdown = 2 Then
            countdownlbl.Text = 1
        ElseIf countdown = 1 Then
            countdownlbl.Visible = False
            Golbl.Visible = True
        ElseIf countdown = 0 Then
            Golbl.Visible = False
            countdownpanel.Visible = False
            puck.Visible = True
            countdown = 4
            tick.Start()
            count.Stop()
        End If

    End Sub





    Private Sub Start_Tick(sender As Object, e As EventArgs) Handles Start.Tick
        starttimer = starttimer + 1
        If starttimer = 4 Then
            starttimer = 0
            Start.Stop()
            If GlobalVariables.sounds = True Then
                My.Computer.Audio.Play(My.Resources.Main_Screen_Music_wav_file, _
    AudioPlayMode.BackgroundLoop)
            End If
            tick.Start()
        End If
    End Sub

    Private Sub retire_Click(sender As Object, e As EventArgs) Handles retire.Click
        resetGame()
        pauseMenuPanel.Hide()
        TeamSelection.resetTeamSelectionForm()
        Me.Close()
        MainMenu.Visible = True
    End Sub

    Private Sub again_Click(sender As Object, e As EventArgs) Handles again.Click
        resetGame()
        retire.Visible = False
        again.Visible = False
        Winlbl.Visible = False
        countdownpanel.Visible = True
        count.Start()
        If GlobalVariables.sounds = True Then
            My.Computer.Audio.Play(My.Resources.LETSAGO, _
    AudioPlayMode.Background)
        End If
        Start.Start()
        lUserPlayer.Image.RotateFlip(RotateFlipType.Rotate180FlipY)
    End Sub

End Class
