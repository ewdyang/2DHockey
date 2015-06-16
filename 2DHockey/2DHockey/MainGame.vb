Public Class MainGame
    Dim puckXV, puckYV As Integer 'Puck's X and Y Velocity
    Dim playerXV, playerYV As Integer 'Player's X and Y Velocity
    Dim playerAccelerating As Boolean 'Whether the player is in the process of accelerating
    Dim heldByPlayer As Boolean 'Whether the puck is held by the player
    Dim heldByWhichTeam As String 'which team has possession of the puck
    Dim userScore, compScore As Integer 'the scores of the respective teams
    Dim Framenum As Integer = 0

    Dim maxPlayerSpeed As Integer = 8 'max speed a player can accelerate to
    Dim playerAccelerationSpeed As Integer = 2 'increments the player accelerates by
    Dim userPlayerDirection As Integer '0: left, 1: right
    Dim compPlayerDirection As Integer '0: left, 1: right

    Dim puckResetPosition As New Point(381, 185)
    Dim userPlayerResetPosition As New Point(255, 165)
    Dim compPlayerResetPosition As New Point(478, 165)

    Private Sub Tick_Tick(sender As Object, e As EventArgs) Handles tick.Tick 'Calculates movement of all objects every tick (10 milliseconds)
        'followMouse(player) 'old controls of having player follow the mouse
        If objectCollisionDetect(puck, playerNet) Then
            goalScored("user")
        ElseIf objectCollisionDetect(puck, compNet) Then
            goalScored("comp")
        End If
        moveObject(userPlayer, playerXV, playerYV, playerAccelerating) 'calculates movement of player
        If objectCollisionDetect(puck, userPlayer) Then 'checks if player is touching puck
            heldByWhichTeam = "user"
            heldByPlayer = True
        ElseIf objectCollisionDetect(puck, compPlayer) Then
            heldByWhichTeam = "comp"
            heldByPlayer = True
        End If
        If heldByPlayer = True Then
            If heldByWhichTeam = "user" Then
                followPlayer(puck, userPlayer, userPlayerDirection) 'makes the puck follow the user player
            ElseIf heldByWhichTeam = "comp" Then
                followPlayer(puck, compPlayer, compPlayerDirection) 'makes the puck follow the comp player
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
                playerAccelerating = True 'player is accelerating
                e.Handled = True 'control has been handled
                animatePlayer(userPlayer, "left")
            Case Keys.Right 'right arrow key
                If playerXV < maxPlayerSpeed Then
                    playerXV = playerXV + playerAccelerationSpeed
                End If
                playerAccelerating = True
                e.Handled = True
                animatePlayer(userPlayer, "right")
            Case Keys.Up 'up arrow key
                If playerYV > -maxPlayerSpeed Then
                    playerYV = playerYV - playerAccelerationSpeed
                End If
                playerAccelerating = True
                e.Handled = True
                animatePlayer(userPlayer, "up")
            Case Keys.Down 'down arrow key
                If playerYV < maxPlayerSpeed Then
                    playerYV = playerYV + playerAccelerationSpeed
                End If
                playerAccelerating = True
                e.Handled = True
                animatePlayer(userPlayer, "down")
            Case Keys.Space
                shoot(userPlayerDirection)
        End Select
    End Sub

    Private Sub Bouncing_KeyUp(sender As Object, e As KeyEventArgs) Handles Me.KeyUp 'resets playerAccelerating after key is unpressed
        FrameTimer.Stop()
        Framenum = 0
        Select Case e.KeyCode
            Case Keys.Left, Keys.Right, Keys.Up, Keys.Down
                playerAccelerating = False

        End Select
    End Sub

    Private Sub MainGame_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Randomize()
        compNet.Image.RotateFlip(RotateFlipType.Rotate180FlipY)
        Select Case TeamSelection.team1
            Case 0
                userPlayer.Image = PlayerAnimationList.Images(0)
            Case 1
                userPlayer.Image = GreenAnimation.Images(0)
            Case 2
                userPlayer.Image = OrangeAnimation.Images(0)
            Case 3
                userPlayer.Image = RedAnimation.Images(0)
            Case 4
                userPlayer.Image = WhiteAnimation.Images(0)
        End Select
        Select Case TeamSelection.team2
            Case 0
                compPlayer.Image = PlayerAnimationList.Images(0)
            Case 1
                compPlayer.Image = GreenAnimation.Images(0)
            Case 2
                compPlayer.Image = OrangeAnimation.Images(0)
            Case 3
                compPlayer.Image = RedAnimation.Images(0)
            Case 4
                compPlayer.Image = WhiteAnimation.Images(0)
        End Select
        userPlayer.Image.RotateFlip(RotateFlipType.Rotate180FlipY)
        resumebtn.Font = CustomFont.GetInstance(15.75, FontStyle.Regular)
        Quitbtn.Font = CustomFont.GetInstance(15.75, FontStyle.Regular)
    End Sub

    Sub moveObject(ByVal bouncingObject As PictureBox, ByRef objectXV As Integer, ByRef objectYV As Integer, Optional ByRef objectAccelerating As Boolean = False) 'Moves an object according to it's X and Y velocity
        Dim newLocation As Point
        edgeCollisionDetect(bouncingObject, objectXV, objectYV)
        newLocation.X = bouncingObject.Location.X + objectXV
        newLocation.Y = bouncingObject.Location.Y + objectYV
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
        bouncingObject.Location = newLocation
    End Sub

    Sub edgeCollisionDetect(ByVal bouncingObject, ByRef objectXV, ByRef objectYV) 'checks if an object is bouncing into the walls of the form, then changes its velocity to make it bounce
        If bouncingObject.Location.X < 50 Then
            objectXV = Math.Abs(objectXV)
        ElseIf bouncingObject.Location.X + bouncingObject.Width + 15 + 60 > Me.Width Then
            objectXV = -Math.Abs(objectXV)
        End If
        If bouncingObject.Location.Y < 50 Then
            objectYV = Math.Abs(objectYV)
        ElseIf bouncingObject.Location.Y + bouncingObject.Height + 42 + 25 > Me.Height Then
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

    Sub goalScored(ByVal team As String) 'adds 1 to the score, then checks if any teams have at least 9 points, then triggers win if it's met
        If team = "user" Then
            userScore += 1
            updateScoreBoard()
            resetGoal()
        ElseIf team = "comp" Then
            compScore += 1
            updateScoreBoard()
            resetGoal()
        End If
        If userScore >= OptionsMenu.optionPointsNeeded Then
            gameWin("user")
        ElseIf compScore >= OptionsMenu.optionPointsNeeded Then
            gameWin("comp")
        End If
    End Sub

    Sub gameWin(ByRef team As String) 'announces winner of the game and allows player to replay or return to main menu
        If team = "user" Then

        Else

        End If
    End Sub

    Sub updateScoreBoard() 'updates the scoreboard graphic to reflect the latest scores

    End Sub

    Sub resetGoal() 'resets the game after goals
        tick.Stop()
        puckXV = 0
        puckYV = 0
        playerXV = 0
        playerYV = 0
        heldByPlayer = False
        puck.Location = puckResetPosition
        userPlayer.Location = userPlayerResetPosition
        compPlayer.Location = compPlayerResetPosition
        tick.Start()
    End Sub

    Sub resetGame() 'resets the game when it ends or is quit
        resetGoal()
        tick.Stop()
        userScore = 0
        compScore = 0
        updateScoreBoard()
    End Sub

    Sub animatePlayer(ByVal player As PictureBox, ByVal directionHeading As String)

        Select Case TeamSelection.team1
            Case 0
                userPlayer.Image = PlayerAnimationList.Images(Framenum)
            Case 1
                userPlayer.Image = GreenAnimation.Images(Framenum)
            Case 2
                userPlayer.Image = OrangeAnimation.Images(Framenum)
            Case 3
                userPlayer.Image = RedAnimation.Images(Framenum)
            Case 4
                userPlayer.Image = WhiteAnimation.Images(Framenum)
        End Select

        Select Case directionHeading
            Case "left"
                userPlayerDirection = 0
            Case "right"
                userPlayer.Image.RotateFlip(RotateFlipType.RotateNoneFlipX)
                userPlayerDirection = 1
            Case "up"
                If userPlayerDirection = 1 Then
                    userPlayer.Image.RotateFlip(RotateFlipType.RotateNoneFlipX)
                End If
            Case "down"
                If userPlayerDirection = 1 Then
                    userPlayer.Image.RotateFlip(RotateFlipType.RotateNoneFlipX)
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

    Private Sub MainGame_Shown(sender As Object, e As EventArgs) Handles Me.Shown
        tick.Start()
    End Sub


End Class
