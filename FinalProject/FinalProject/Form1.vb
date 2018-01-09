Public Class Form1

    Dim canvas As Bitmap
    Dim counter As Integer = 0
    Dim canvasPen, formPen As Graphics
    Dim playerX, playerY, bulletX, bulletY, AlienX, AlienY As Integer
    Dim grounded As Boolean = False
    Dim AlienGrounded As Boolean = False
    Dim AlienGroundedLeft As Boolean = False
    Dim AlienGroundedRight As Boolean = False
    Dim AlienGroundedMiddle As Boolean = False
    Dim counter2 As Integer
    Dim ShootCounter As Integer = 75
    'Alien Decision Variables
    Dim Rand As New Random
    Dim MakeDecision As Integer
    Dim DecisionMade As Boolean
    'Direction Variables
    Dim left, right, up, shoot As Boolean
    Dim facingRight As Boolean = True
    Dim lastFacing As Boolean = False
    Dim Negation As Integer = 1
    'His life
    Dim lives As Integer = 3
    Dim lifeTaken = False

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        formPen = Me.CreateGraphics
        canvas = New Bitmap(Me.Width, Me.Height)
        canvasPen = Graphics.FromImage(canvas)
        playerX = 200
        playerY = 200
        AlienX = 200
        AlienY = 0
        Timer1.Start()




    End Sub


    Private Sub ShootTimer_Tick(sender As Object, e As EventArgs) Handles ShootTimer.Tick
        If bulletX < -20 Or bulletX > Me.Width Then
            ShootCounter = 75
        End If
        'Make sure that the bullet is off the screen
        If ShootCounter = 75 Then
            facingRight = Not lastFacing
        End If

        If ShootCounter < 75 Then
            If facingRight = True Then
                bulletX += 15
                Negation = 1
            Else
                Negation = -1
                bulletX -= 15
            End If
            ShootCounter += 1
        End If
    End Sub

    Dim jumpDown As Boolean
    'Testing Variables
    Dim PastPos As Integer

    Private Sub Timer2_Tick(sender As Object, e As EventArgs) Handles Timer2.Tick



        If counter2 <= 15 Then
            playerY -= 5
        Else
            counter2 = 0
            Timer2.Stop()

        End If




        counter2 += 1
    End Sub


    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        'Draws the Background
        canvasPen.DrawImage(My.Resources.realistic_blue_sky_background_1048_6707, 0, 0)

        If up = True And grounded = True Then
            grounded = False
            Timer2.Start()
        End If

        AlienY += 5

        If playerX <> -12 And playerX <> Me.Width Then
            If Timer2.Enabled = False Then
                playerY += 5
            End If
            If right = True Then
                playerX += 5
            End If
            If left = True Then
                playerX -= 5
            End If
        End If

        If AlienY <= 0 Then
            AlienGrounded = False
            lifeTaken = False
        End If
        'Draw Heart
        If lives = 3 Then
            canvasPen.DrawImage(My.Resources.Heart, 0, 0)
            canvasPen.DrawImage(My.Resources.Heart, My.Resources.Heart.Width + 5, 0)
            canvasPen.DrawImage(My.Resources.Heart, 2 * (My.Resources.Heart.Width + 5), 0)
        ElseIf lives = 2 Then
            canvasPen.DrawImage(My.Resources.Heart, 0, 0)
            canvasPen.DrawImage(My.Resources.Heart, My.Resources.Heart.Width + 5, 0)
        ElseIf lives = 1 Then
            canvasPen.DrawImage(My.Resources.Heart, 0, 0)
        Else

        End If


        'Draw Alien
        canvasPen.DrawImage(My.Resources.Alien, AlienX, AlienY)

        'Obstacle\

        'Bottom
        canvasPen.DrawRectangle(Pens.Red, 0, 400, Me.Width, 50)

        'Left Platform
        canvasPen.DrawRectangle(Pens.Red, 0, 320, 100, 5)

        'Right Platform
        canvasPen.DrawRectangle(Pens.Red, Me.Width - 117, 320, 100, 5)
        'Middle Platform
        canvasPen.DrawRectangle(Pens.Red, (Me.Width \ 4), Me.Height - 200, Me.Width \ 2, 5)

        If shoot = True Then
            canvasPen.DrawImage(My.Resources.Bullet, bulletX, bulletY, Negation * 50, 50)

        End If


        'Draws the player
        If right = True Then
            canvasPen.DrawImage(My.Resources.New_Piskel, playerX + 55, playerY + 15, 50, 70)
            If counter > 6 Then
                canvasPen.DrawImage(My.Resources.egg3, playerX, playerY)
                If counter >= 8 Then
                    counter = 0
                End If
            ElseIf counter > 4 And counter <= 6 Then
                canvasPen.DrawImage(My.Resources.egg1, playerX, playerY)
            Else
                canvasPen.DrawImage(My.Resources.egg2, playerX, playerY)
            End If
        ElseIf left = True Then
            canvasPen.DrawImage(My.Resources.New_Piskel, playerX + 55, playerY + 15, -50, 70)
            If counter > 6 Then
                canvasPen.DrawImage(My.Resources.egg3, playerX + 100, playerY, -(My.Resources.egg3.Width), My.Resources.egg3.Height)
                If counter >= 8 Then
                    counter = 0
                End If
            ElseIf counter > 4 And counter <= 6 Then
                canvasPen.DrawImage(My.Resources.egg1, playerX + 100, playerY, -(My.Resources.egg1.Width), My.Resources.egg1.Height)
            Else
                canvasPen.DrawImage(My.Resources.egg2, playerX + 100, playerY, -(My.Resources.egg2.Width), My.Resources.egg2.Height)
            End If
        Else
            If lastFacing = False Then
                canvasPen.DrawImage(My.Resources.New_Piskel, playerX + 55, playerY + 15, 50, 70)
                canvasPen.DrawImage(My.Resources.egg3, playerX, playerY)

            Else
                canvasPen.DrawImage(My.Resources.New_Piskel, playerX + 55, playerY + 15, -50, 70)
                canvasPen.DrawImage(My.Resources.egg3, playerX + 100, playerY, -(My.Resources.egg3.Width), My.Resources.egg3.Height)
            End If

        End If

        'Draws bazooka
        'canvasPen.DrawImage(My.Resources.New_Piskel, playerX + 55, playerY + 15, 50, 70)

        'Check for ground collision
        Dim eggRec As New Rectangle(playerX + 20, playerY + 90, My.Resources.egg3.Width - 45, 5)
        Dim bottomRec As New Rectangle(0, 400, Me.Width, 50)
        Dim leftRec As New Rectangle(0, 320, 100, 5)
        Dim RightRec As New Rectangle(Me.Width - 117, 320, 100, 5)
        Dim middleRec As New Rectangle((Me.Width \ 4), Me.Height - 200, Me.Width \ 2, 5)
        Dim AlienRec As New Rectangle(AlienX, AlienY + 15, My.Resources.Alien.Width, My.Resources.Alien.Height - 30)
        Dim bulletRec As New Rectangle(bulletX, bulletY, My.Resources.Bullet.Width, My.Resources.Bullet.Height)
        'canvasPen.DrawRectangle(Pens.Red, bulletX, bulletY + 15, My.Resources.Bullet.Width, My.Resources.Bullet.Height - 15)


        'Alien Movements
        If DecisionMade = False Then
            MakeDecision = Rand.Next(1, 5)
            DecisionMade = True
        End If
        If AlienGroundedMiddle = True Then
            If MakeDecision > 2 Then
                AlienX += 8
            Else
                AlienX -= 8
            End If
        ElseIf AlienGroundedLeft = True Then
            AlienX += 8
        ElseIf AlienGroundedRight = True Then
            AlienX -= 8
        ElseIf AlienGrounded = True Then
            If AlienX <= 225 Then
                AlienX += 8
            ElseIf AlienX >= 250 Then
                AlienX -= 8
            Else
                AlienY = -40
                DecisionMade = False
                If lifeTaken = False Then
                    lives -= 1

                    lifeTaken = True
                End If

            End If
        End If






        Dim r As New Random

        'Alien ----> Object Interactions
        If bulletRec.IntersectsWith(AlienRec) Then
            AlienY = -40
            AlienX = r.Next(0, 256)
            DecisionMade = False
        End If

        If AlienRec.IntersectsWith(bottomRec) Then
            AlienY -= 5
            AlienGrounded = True
        ElseIf AlienRec.IntersectsWith(leftRec) Then
            AlienY -= 5
            AlienGroundedLeft = True
        ElseIf AlienRec.IntersectsWith(RightRec) Then
            AlienY -= 5
            AlienGroundedRight = True
        ElseIf AlienRec.IntersectsWith(middleRec) Then
            AlienY -= 5
            AlienGroundedMiddle = True
        Else
            AlienGrounded = False
            AlienGroundedLeft = False
            AlienGroundedRight = False
            AlienGroundedMiddle = False

        End If


        'Player ----> Object Interactions
        If eggRec.IntersectsWith(bottomRec) Then
            playerY -= 5
            grounded = True
        ElseIf eggRec.IntersectsWith(leftRec) Then
            playerY -= 5
            grounded = True
        ElseIf eggRec.IntersectsWith(RightRec) Then
            playerY -= 5
            grounded = True
        ElseIf eggRec.IntersectsWith(middleRec) Then
            playerY -= 5
            grounded = True
        Else
            grounded = False
        End If



        'Puts the image on the screen
        formPen.DrawImage(canvas, 0, 0)


        counter = counter + 1
        PastPos = playerX
    End Sub

    Private Sub Form1_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        If e.KeyValue = Keys.Space Then
            'facingRight = Not lastFacing
            If ShootCounter = 75 Then
                ShootCounter = 0
                bulletX = playerX + 25
                bulletY = playerY + 25
                shoot = True
                ShootTimer.Enabled = True
                canvasPen.DrawImage(My.Resources.Bullet, playerX + 55 + My.Resources.New_Piskel.Width, playerY + 20, 50, 50)
            End If
        End If
        If e.KeyValue = Keys.Right Then
            right = True
            If ShootCounter = 75 Or ShootCounter = 0 Then
                facingRight = True
            End If
            lastFacing = False
        End If
        If e.KeyValue = Keys.Left Then
            left = True
            If ShootCounter = 75 Or ShootCounter = 0 Then
                facingRight = False
            End If
            lastFacing = True
        End If
        If e.KeyValue = Keys.Up And grounded = True And jumpDown = False Then
            up = True
            jumpDown = True

        Else
            up = False
            jumpDown = False

        End If

    End Sub

    Private Sub Form1_KeyUp(sender As Object, e As KeyEventArgs) Handles Me.KeyUp
        If e.KeyValue = Keys.Right Then
            right = False
        End If
        If e.KeyValue = Keys.Left Then
            left = False
        End If
        If e.KeyValue = Keys.Up Then
            up = False
        End If
    End Sub
End Class