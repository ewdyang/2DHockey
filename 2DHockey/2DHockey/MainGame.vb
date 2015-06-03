﻿Public Class MainGame
    Dim puckXV, puckYV As Integer 'Puck's X and Y Velocity
    Dim playerXV, playerYV As Integer 'Player's X and Y Velocity
    Dim playerAccelerating As Boolean 'Whether the player is in the process of accelerating
    Dim heldByPlayer As Boolean 'Whether the puck is held by the player
    Dim playerScore, compScore As Integer 'the scores of the respective teams
    Dim Framenum As Integer = 0

    Dim maxPlayerSpeed As Integer = 7 'max speed a player can accelerate to
    Dim playerAccelerationSpeed As Integer = 3 'increments the player accelerates by
	Dim Direction as Integer

    Dim puckResetPosition As New Point(381, 185)
    Dim userPlayerResetPosition As New Point(188, 165)
    Dim compPlayerResetPosition As New Point(544, 165)

    Private Sub Tick_Tick(sender As Object, e As EventArgs) Handles tick.Tick 'Calculates movement of all objects every tick (10 milliseconds)
        'followMouse(player) 'old controls of having player follow the mouse
        If objectCollisionDetect(puck, playerNet) Then
            goalScored("user")
        ElseIf objectCollisionDetect(puck, compNet) Then
            goalScored("comp")
        End If
        moveObject(userPlayer, playerXV, playerYV, playerAccelerating) 'calculates movement of player
        If objectCollisionDetect(puck, userPlayer) Then 'checks if player is touching puck
            heldByPlayer = True
        End If
        If heldByPlayer = True Then
            followPlayer(puck, userPlayer) 'makes the puck follow the player
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
                userPlayer.Image = PlayerAnimationList.Images(Framenum)
                Direction = 0
            Case Keys.Right 'right arrow key
                If playerXV < maxPlayerSpeed Then
                    playerXV = playerXV + playerAccelerationSpeed
                End If
                playerAccelerating = True
                e.Handled = True
                userPlayer.Image = PlayerAnimationList.Images(Framenum)
                userPlayer.Image.RotateFlip(RotateFlipType.RotateNoneFlipX)
				Direction = 1
            Case Keys.Up 'up arrow key
                If playerYV > -maxPlayerSpeed Then
                    playerYV = playerYV - playerAccelerationSpeed
                End If
                playerAccelerating = True
                e.Handled = True
				If Direction = 0 Then
                    userPlayer.Image = PlayerAnimationList.Images(Framenum)
                ElseIf Direction = 1 Then
                    userPlayer.Image = PlayerAnimationList.Images(Framenum)
                    userPlayer.Image.RotateFlip(RotateFlipType.RotateNoneFlipX)
                End If
            Case Keys.Down 'down arrow key
                If playerYV < maxPlayerSpeed Then
                    playerYV = playerYV + playerAccelerationSpeed
                End If
                playerAccelerating = True
                e.Handled = True
				If Direction = 0 Then
                    userPlayer.Image = PlayerAnimationList.Images(Framenum)
                ElseIf Direction = 1 Then
                    userPlayer.Image = PlayerAnimationList.Images(Framenum)
                    userPlayer.Image.RotateFlip(RotateFlipType.RotateNoneFlipX)
                End If
            Case Keys.Space
                shoot()
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

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Randomize()
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
        If bouncingObject.Location.X < 0 Then
            objectXV = Math.Abs(objectXV)
        ElseIf bouncingObject.Location.X + bouncingObject.Width + 15 > Me.Width Then
            objectXV = -Math.Abs(objectXV)
        End If
        If bouncingObject.Location.Y < 0 Then
            objectYV = Math.Abs(objectYV)
        ElseIf bouncingObject.Location.Y + bouncingObject.Height + 42 > Me.Height Then
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

    Sub followPlayer(ByVal followingPuck, ByVal followedPlayer) 'makes an object follow the player (used by the puck)
        Dim newlocation As Point
        newlocation.X = followedPlayer.location.x - 10
        newlocation.Y = followedPlayer.location.y + followedPlayer.height + 4
        followingPuck.location = newlocation
    End Sub

    Private Sub shoot() 'makes the player shoot the puck, giving it a set forward velocity and random vertical velocity
        If heldByPlayer = True Then
            heldByPlayer = False
            puckXV = -20
            puckYV = 10 - Rnd() * 20
        End If
    End Sub

    Sub goalScored(ByVal team As String) 'adds 1 to the score, then checks if any teams have at least 9 points, then triggers win if it's met
        If team = "user" Then
            playerScore += 1
            updateScoreBoard()
            resetGoal()
        ElseIf team = "comp" Then
            compScore += 1
            updateScoreBoard()
            resetGoal()
        End If
        If playerScore >= 7 Then
            gameWin("user")
        ElseIf compScore >= 7 Then
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
        puck.Location = puckResetPosition
        userPlayer.Location = userPlayerResetPosition
        compPlayer.Location = compPlayerResetPosition
        tick.Start()
    End Sub

    Private Sub FrameTimer_Tick(sender As Object, e As EventArgs) Handles FrameTimer.Tick 'used for animating players
        Framenum = Framenum + 1
        If Framenum = 2 Then
            Framenum = 0
        End If
    End Sub
End Class
