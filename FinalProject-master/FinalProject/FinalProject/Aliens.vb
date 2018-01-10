Public Class Aliens
    Public AlienX, AlienY As Integer
    Public AlienGrounded As Boolean = False
    Public AlienGroundedLeft As Boolean = False
    Public AlienGroundedRight As Boolean = False
    Public AlienGroundedMiddle As Boolean = False

    Public Sub moveRight()
        AlienX += 8
    End Sub

    Public Sub moveLeft()
        AlienX -= 8
    End Sub





End Class
