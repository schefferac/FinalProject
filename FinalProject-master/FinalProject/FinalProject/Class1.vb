Public Class Alien
    Public alienX, AlienY As Integer
    Public Grounded As Boolean = False
    Public GroundedLeft As Boolean = False
    Public GroundedRight As Boolean = False
    Public GroundedMiddle As Boolean = False

    Public MakeDecision As Integer
    Public DecisionMade As Boolean

    Public AlienRec As New Rectangle(alienX, AlienY + 15, My.Resources.Alien.Width, My.Resources.Alien.Height - 30)

    'His life

    Public Rand As New Random
    '------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------


    Public Sub moveRight()
        alienX += 8
    End Sub
    Public Sub moveLeft()
        alienX -= 8
    End Sub
    Public Sub gravity()
        AlienY += 5
    End Sub
    Public Sub alienMove()
        'Alien Movements


        If DecisionMade = False Then
                MakeDecision = Rand.Next(1, 5)
                DecisionMade = True
            End If
            If GroundedMiddle = True Then
                If MakeDecision > 2 Then
                    alienX += 8
                Else
                    alienX -= 8
                End If
            ElseIf GroundedLeft = True Then
                alienX += 8
            ElseIf GroundedRight = True Then
                alienX -= 8
            ElseIf Grounded = True Then
                If alienX <= 225 Then
                    alienX += 8
                ElseIf alienX >= 250 Then
                    alienX -= 8
                Else
                    AlienY = -40
                    DecisionMade = False
                If Form1.lifeTaken = False Then
                    Form1.lives -= 1

                    Form1.lifeTaken = True
                End If

            End If
            End If



    End Sub
End Class
