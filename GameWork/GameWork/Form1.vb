Public Class TooMuchFreeTime
    Dim ScoreB As Integer
    Dim Rate As Double
    Dim Life As Integer
    Dim HighScore As Integer
    Dim RocketSpeed As Double
    Dim DoubleClicked As Boolean
    Private Sub Form1_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyDown
        ' Sets Handled to true to prevent other controls from 
        ' receiving the key if an arrow key was pressed
        Dim bHandled As Boolean = False
        If ScoreB < 1 Then
            ScoreB = 0
        End If
        Laser.Top = Rocket.Top - 56
        Laser.Left = Rocket.Left + 20
        Laser2.Top = Rocket.Top - 56
        Laser2.Left = Rocket.Left + 6
        Laser3.Top = Rocket.Top - 56
        Laser3.Left = Rocket.Left + 34
        Select Case e.KeyCode
            Case Keys.Right
                Rocket.Left = Rocket.Left + RocketSpeed
                e.Handled = True
            Case Keys.Left
                Rocket.Left = Rocket.Left - RocketSpeed
                e.Handled = True
            Case Keys.Up
                While Laser.Top > -500
                    Laser.Top = Laser.Top - 0.9
                    If DoubleClicked = True Then
                        Laser2.Top = Laser2.Top - 0.9
                        Laser3.Top = Laser3.Top - 0.9
                    End If
                End While
                e.Handled = True
            Case Keys.Down
                'do more stuff
                e.Handled = True
            Case Keys.R
                SpaceRock1.Top = 53
                SpaceRock2.Top = 53
                SpaceRock3.Top = 53
                SpaceRock4.Top = 53
                Laser.BackColor = Color.Black
                Laser2.BackColor = Color.Black
                Laser3.BackColor = Color.Black
                ScoreB = 0
                Rate = 2
                RocketSpeed = 9
                Life = 3
                e.Handled = True
        End Select
        If (SpaceRock1.Left - 6) < Laser.Left And Laser.Left < (SpaceRock1.Left + 67) And Laser.Top <= SpaceRock1.Top Then
            SpaceRock1.Image = Nothing
            If SpaceRock1.Top > 150 Then
                ScoreB = ScoreB + 1
            End If

            SpaceRock1.Top = 53
        End If
        If (SpaceRock2.Left - 6) < Laser.Left And Laser.Left < (SpaceRock2.Left + 67) And Laser.Top <= SpaceRock2.Top Then
            SpaceRock2.Image = Nothing
            If SpaceRock2.Top > 150 Then
                ScoreB = ScoreB + 1
            End If

            SpaceRock2.Top = 53
        End If
        If (SpaceRock3.Left - 6) < Laser.Left And Laser.Left < (SpaceRock3.Left + 67) And Laser.Top <= SpaceRock3.Top Then
            SpaceRock3.Image = Nothing
            If SpaceRock3.Top > 150 Then
                ScoreB = ScoreB + 1
            End If

            SpaceRock3.Top = 53
        End If
        If (SpaceRock4.Left - 6) < Laser.Left And Laser.Left < (SpaceRock4.Left + 67) And Laser.Top <= SpaceRock4.Top Then
            SpaceRock4.Image = Nothing
            If SpaceRock4.Top > 150 Then
                ScoreB = ScoreB + 1
            End If
            SpaceRock4.Top = 53
        End If
        If (SpaceRock1.Left - 6) < Laser2.Left And Laser2.Left < (SpaceRock1.Left + 67) And Laser2.Top <= SpaceRock1.Top Then
            SpaceRock1.Image = Nothing
            If SpaceRock1.Top > 150 Then
                ScoreB = ScoreB + 1
            End If

            SpaceRock1.Top = 53
        End If
        If (SpaceRock2.Left - 6) < Laser2.Left And Laser2.Left < (SpaceRock2.Left + 67) And Laser2.Top <= SpaceRock2.Top Then
            SpaceRock2.Image = Nothing
            If SpaceRock2.Top > 150 Then
                ScoreB = ScoreB + 1
            End If

            SpaceRock2.Top = 53
        End If
        If (SpaceRock3.Left - 6) < Laser2.Left And Laser2.Left < (SpaceRock3.Left + 67) And Laser2.Top <= SpaceRock3.Top Then
            SpaceRock3.Image = Nothing
            If SpaceRock3.Top > 150 Then
                ScoreB = ScoreB + 1
            End If

            SpaceRock3.Top = 53
        End If
        If (SpaceRock4.Left - 6) < Laser2.Left And Laser2.Left < (SpaceRock4.Left + 67) And Laser2.Top <= SpaceRock4.Top Then
            SpaceRock4.Image = Nothing
            If SpaceRock4.Top > 150 Then
                ScoreB = ScoreB + 1
            End If
            SpaceRock4.Top = 53
        End If
        If (SpaceRock1.Left - 6) < Laser3.Left And Laser3.Left < (SpaceRock1.Left + 67) And Laser3.Top <= SpaceRock1.Top Then
            SpaceRock1.Image = Nothing
            If SpaceRock1.Top > 150 Then
                ScoreB = ScoreB + 1
            End If

            SpaceRock1.Top = 53
        End If
        If (SpaceRock2.Left - 6) < Laser3.Left And Laser3.Left < (SpaceRock2.Left + 67) And Laser3.Top <= SpaceRock2.Top Then
            SpaceRock2.Image = Nothing
            If SpaceRock2.Top > 150 Then
                ScoreB = ScoreB + 1
            End If

            SpaceRock2.Top = 53
        End If
        If (SpaceRock3.Left - 6) < Laser3.Left And Laser3.Left < (SpaceRock3.Left + 67) And Laser3.Top <= SpaceRock3.Top Then
            SpaceRock3.Image = Nothing
            If SpaceRock3.Top > 150 Then
                ScoreB = ScoreB + 1
            End If

            SpaceRock3.Top = 53
        End If
        If (SpaceRock4.Left - 6) < Laser3.Left And Laser3.Left < (SpaceRock4.Left + 67) And Laser3.Top <= SpaceRock4.Top Then
            SpaceRock4.Image = Nothing
            If SpaceRock4.Top > 150 Then
                ScoreB = ScoreB + 1
            End If
            SpaceRock4.Top = 53
        End If
        If SpaceRock1.Top = 53 Then
            SpaceRock1.Image = SpaceRock1.InitialImage
        End If
        If SpaceRock2.Top = 53 Then
            SpaceRock2.Image = SpaceRock2.InitialImage
        End If
        If SpaceRock3.Top = 53 Then
            SpaceRock3.Image = SpaceRock3.InitialImage
        End If
        If SpaceRock4.Top = 53 Then
            SpaceRock4.Image = SpaceRock4.InitialImage
        End If
        If SpaceRock1.Top >= 400 Then
            SpaceRock1.Top = 53
            Life = Life - 1
        ElseIf SpaceRock2.Top >= 400 Then
            SpaceRock2.Top = 53
            Life = Life - 1
        ElseIf SpaceRock3.Top >= 400 Then
            SpaceRock3.Top = 53
            Life = Life - 1
        ElseIf SpaceRock4.Top >= 400 Then
            SpaceRock4.Top = 53
            Life = Life - 1
        End If
        If Life <= 0 Then
            MsgBox("You Lose")
            Life3.ForeColor = Color.Black
        ElseIf Life = 1 Then
            Life2.ForeColor = Color.Black
        ElseIf Life = 2 Then
            Life1.ForeColor = Color.Black
        Else
            Life1.ForeColor = Color.Red
            Life2.ForeColor = Color.Red
            Life3.ForeColor = Color.Red
        End If
        If ScoreB >= 10 And ScoreB <= 19 Then
            Laser.BackColor = Color.Red
            If DoubleClicked = True Then
                Laser2.BackColor = Color.Red
                Laser3.BackColor = Color.Red
            End If

            Rate = Rate + 0.007
        ElseIf ScoreB >= 20 And ScoreB <= 29 Then
            Laser.BackColor = Color.Orange
            If DoubleClicked = True Then
                Laser2.BackColor = Color.Orange
                Laser3.BackColor = Color.Orange
            End If
            Rate = Rate + 0.007
            ElseIf ScoreB >= 30 And ScoreB <= 39 Then
                Laser.BackColor = Color.Yellow
            If DoubleClicked = True Then
                Laser2.BackColor = Color.Yellow
                Laser3.BackColor = Color.Yellow
            End If
            Rate = Rate + 0.007
            ElseIf ScoreB >= 40 And ScoreB <= 49 Then
            Laser.BackColor = Color.Green
            If DoubleClicked = True Then
                Laser2.BackColor = Color.Green
                Laser3.BackColor = Color.Green
            End If
            Rate = Rate + 0.007
            ElseIf ScoreB >= 50 And ScoreB <= 59 Then
            Laser.BackColor = Color.Blue
            If DoubleClicked = True Then
                Laser2.BackColor = Color.Blue
                Laser3.BackColor = Color.Blue
            End If
            Rate = Rate + 0.007
            ElseIf ScoreB >= 60 And ScoreB <= 69 Then
            Laser.BackColor = Color.Indigo
            If DoubleClicked = True Then
                Laser2.BackColor = Color.Indigo
                Laser3.BackColor = Color.Indigo
            End If
            Rate = Rate + 0.007
            ElseIf ScoreB >= 60 And ScoreB <= 69 Then
            Laser.BackColor = Color.Violet
            If DoubleClicked = True Then
                Laser2.BackColor = Color.Violet
                Laser3.BackColor = Color.Violet
            End If
            Rate = Rate + 0.007
            ElseIf ScoreB >= 60 And ScoreB <= 69 Then
            Laser.BackColor = Color.White
            If DoubleClicked = True Then
                Laser2.BackColor = Color.White
                Laser3.BackColor = Color.White
            End If
            Rate = Rate + 0.007
            End If
    End Sub
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        SpaceRock1.Top = SpaceRock1.Top + Rate

        SpaceRock2.Top = SpaceRock2.Top + Rate

        SpaceRock3.Top = SpaceRock3.Top + Rate

        SpaceRock4.Top = SpaceRock4.Top + Rate
        Label2.Text = ScoreB
        Label4.Text = HighScore
        If ScoreB > HighScore Then
            HighScore = ScoreB
        End If
    End Sub
    Private Sub TooMuchFreeTime_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Timer1.Start()
        ScoreB = 0
        Rate = 2
        Life = 3
        HighScore = 0
        RocketSpeed = 9
    End Sub
    Private Sub TooMuchFreeTime_KeyUp(sender As Object, e As KeyEventArgs) Handles Me.KeyUp
        If Life <= 0 Then
            MsgBox("You Lose")
            Life3.ForeColor = Color.Black
        ElseIf Life = 1 Then
            Life2.ForeColor = Color.Black
        ElseIf Life = 2 Then
            Life1.ForeColor = Color.Black
        Else
            Life1.ForeColor = Color.Red
            Life2.ForeColor = Color.Red
            Life3.ForeColor = Color.Red
        End If
    End Sub
    Private Sub Rocket_DoubleClick(sender As Object, e As EventArgs) Handles Rocket.DoubleClick
        RocketSpeed = 14
        DoubleClicked = True
    End Sub

    Private Sub SpaceRock1_Click(sender As Object, e As EventArgs) Handles SpaceRock1.Click

    End Sub
End Class
