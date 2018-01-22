<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class TooMuchFreeTime
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(TooMuchFreeTime))
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Rocket = New System.Windows.Forms.PictureBox()
        Me.SpaceRock1 = New System.Windows.Forms.PictureBox()
        Me.SpaceRock2 = New System.Windows.Forms.PictureBox()
        Me.SpaceRock3 = New System.Windows.Forms.PictureBox()
        Me.SpaceRock4 = New System.Windows.Forms.PictureBox()
        Me.Laser = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Life1 = New System.Windows.Forms.Label()
        Me.Life2 = New System.Windows.Forms.Label()
        Me.Life3 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Laser2 = New System.Windows.Forms.PictureBox()
        Me.Laser3 = New System.Windows.Forms.PictureBox()
        CType(Me.Rocket, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SpaceRock1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SpaceRock2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SpaceRock3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SpaceRock4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Laser, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Laser2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Laser3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        Me.Timer1.Interval = 60
        '
        'Rocket
        '
        Me.Rocket.Image = CType(resources.GetObject("Rocket.Image"), System.Drawing.Image)
        Me.Rocket.InitialImage = CType(resources.GetObject("Rocket.InitialImage"), System.Drawing.Image)
        Me.Rocket.Location = New System.Drawing.Point(234, 457)
        Me.Rocket.Name = "Rocket"
        Me.Rocket.Size = New System.Drawing.Size(50, 50)
        Me.Rocket.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Rocket.TabIndex = 0
        Me.Rocket.TabStop = False
        '
        'SpaceRock1
        '
        Me.SpaceRock1.Image = CType(resources.GetObject("SpaceRock1.Image"), System.Drawing.Image)
        Me.SpaceRock1.InitialImage = CType(resources.GetObject("SpaceRock1.InitialImage"), System.Drawing.Image)
        Me.SpaceRock1.Location = New System.Drawing.Point(40, 53)
        Me.SpaceRock1.Name = "SpaceRock1"
        Me.SpaceRock1.Size = New System.Drawing.Size(56, 50)
        Me.SpaceRock1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.SpaceRock1.TabIndex = 1
        Me.SpaceRock1.TabStop = False
        '
        'SpaceRock2
        '
        Me.SpaceRock2.Image = CType(resources.GetObject("SpaceRock2.Image"), System.Drawing.Image)
        Me.SpaceRock2.InitialImage = CType(resources.GetObject("SpaceRock2.InitialImage"), System.Drawing.Image)
        Me.SpaceRock2.Location = New System.Drawing.Point(158, 53)
        Me.SpaceRock2.Name = "SpaceRock2"
        Me.SpaceRock2.Size = New System.Drawing.Size(56, 50)
        Me.SpaceRock2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.SpaceRock2.TabIndex = 2
        Me.SpaceRock2.TabStop = False
        '
        'SpaceRock3
        '
        Me.SpaceRock3.Image = CType(resources.GetObject("SpaceRock3.Image"), System.Drawing.Image)
        Me.SpaceRock3.InitialImage = CType(resources.GetObject("SpaceRock3.InitialImage"), System.Drawing.Image)
        Me.SpaceRock3.Location = New System.Drawing.Point(277, 53)
        Me.SpaceRock3.Name = "SpaceRock3"
        Me.SpaceRock3.Size = New System.Drawing.Size(56, 50)
        Me.SpaceRock3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.SpaceRock3.TabIndex = 3
        Me.SpaceRock3.TabStop = False
        '
        'SpaceRock4
        '
        Me.SpaceRock4.Image = CType(resources.GetObject("SpaceRock4.Image"), System.Drawing.Image)
        Me.SpaceRock4.InitialImage = CType(resources.GetObject("SpaceRock4.InitialImage"), System.Drawing.Image)
        Me.SpaceRock4.Location = New System.Drawing.Point(402, 53)
        Me.SpaceRock4.Name = "SpaceRock4"
        Me.SpaceRock4.Size = New System.Drawing.Size(56, 50)
        Me.SpaceRock4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.SpaceRock4.TabIndex = 4
        Me.SpaceRock4.TabStop = False
        '
        'Laser
        '
        Me.Laser.BackColor = System.Drawing.Color.Black
        Me.Laser.Location = New System.Drawing.Point(255, 401)
        Me.Laser.Name = "Laser"
        Me.Laser.Size = New System.Drawing.Size(12, 50)
        Me.Laser.TabIndex = 5
        Me.Laser.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Black
        Me.Label1.ForeColor = System.Drawing.Color.Yellow
        Me.Label1.Location = New System.Drawing.Point(399, 20)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(38, 13)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "Score:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Black
        Me.Label2.ForeColor = System.Drawing.Color.Yellow
        Me.Label2.Location = New System.Drawing.Point(443, 20)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(10, 13)
        Me.Label2.TabIndex = 7
        Me.Label2.Text = " "
        '
        'Life1
        '
        Me.Life1.AccessibleName = "Life1"
        Me.Life1.AutoSize = True
        Me.Life1.BackColor = System.Drawing.Color.Black
        Me.Life1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Life1.ForeColor = System.Drawing.Color.Red
        Me.Life1.Location = New System.Drawing.Point(12, 8)
        Me.Life1.Name = "Life1"
        Me.Life1.Size = New System.Drawing.Size(36, 25)
        Me.Life1.TabIndex = 8
        Me.Life1.Text = "(-)"
        '
        'Life2
        '
        Me.Life2.AccessibleName = "Life2"
        Me.Life2.AutoSize = True
        Me.Life2.BackColor = System.Drawing.Color.Black
        Me.Life2.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Life2.ForeColor = System.Drawing.Color.Red
        Me.Life2.Location = New System.Drawing.Point(54, 8)
        Me.Life2.Name = "Life2"
        Me.Life2.Size = New System.Drawing.Size(36, 25)
        Me.Life2.TabIndex = 9
        Me.Life2.Text = "(-)"
        '
        'Life3
        '
        Me.Life3.AccessibleName = "Life3"
        Me.Life3.AutoSize = True
        Me.Life3.BackColor = System.Drawing.Color.Black
        Me.Life3.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Life3.ForeColor = System.Drawing.Color.Red
        Me.Life3.Location = New System.Drawing.Point(96, 8)
        Me.Life3.Name = "Life3"
        Me.Life3.Size = New System.Drawing.Size(36, 25)
        Me.Life3.TabIndex = 10
        Me.Life3.Text = "(-)"
        '
        'Label3
        '
        Me.Label3.AccessibleName = "Life3"
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Black
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Lime
        Me.Label3.Location = New System.Drawing.Point(159, 13)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(108, 20)
        Me.Label3.TabIndex = 11
        Me.Label3.Text = "High Score: "
        '
        'Label4
        '
        Me.Label4.AccessibleName = "HighScore"
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Black
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(273, 15)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(39, 20)
        Me.Label4.TabIndex = 12
        Me.Label4.Text = "000"
        '
        'Laser2
        '
        Me.Laser2.BackColor = System.Drawing.Color.Black
        Me.Laser2.Location = New System.Drawing.Point(237, 401)
        Me.Laser2.Name = "Laser2"
        Me.Laser2.Size = New System.Drawing.Size(12, 50)
        Me.Laser2.TabIndex = 13
        Me.Laser2.TabStop = False
        '
        'Laser3
        '
        Me.Laser3.BackColor = System.Drawing.Color.Black
        Me.Laser3.Location = New System.Drawing.Point(273, 401)
        Me.Laser3.Name = "Laser3"
        Me.Laser3.Size = New System.Drawing.Size(12, 50)
        Me.Laser3.TabIndex = 14
        Me.Laser3.TabStop = False
        '
        'TooMuchFreeTime
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.ClientSize = New System.Drawing.Size(509, 519)
        Me.Controls.Add(Me.Laser3)
        Me.Controls.Add(Me.Laser2)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Life3)
        Me.Controls.Add(Me.Life2)
        Me.Controls.Add(Me.Life1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Laser)
        Me.Controls.Add(Me.SpaceRock4)
        Me.Controls.Add(Me.SpaceRock3)
        Me.Controls.Add(Me.SpaceRock2)
        Me.Controls.Add(Me.SpaceRock1)
        Me.Controls.Add(Me.Rocket)
        Me.Name = "TooMuchFreeTime"
        Me.Text = "TooMuchFreeTime"
        CType(Me.Rocket, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SpaceRock1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SpaceRock2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SpaceRock3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SpaceRock4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Laser, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Laser2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Laser3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Timer1 As Timer
    Friend WithEvents Rocket As PictureBox
    Friend WithEvents SpaceRock1 As PictureBox
    Friend WithEvents SpaceRock2 As PictureBox
    Friend WithEvents SpaceRock3 As PictureBox
    Friend WithEvents SpaceRock4 As PictureBox
    Friend WithEvents Laser As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Life1 As Label
    Friend WithEvents Life2 As Label
    Friend WithEvents Life3 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Laser2 As PictureBox
    Friend WithEvents Laser3 As PictureBox
End Class
