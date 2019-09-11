<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.Timer7 = New System.Windows.Forms.Timer(Me.components)
        Me.autobell_timer = New System.Windows.Forms.Timer(Me.components)
        Me.monthly_test_timer = New System.Windows.Forms.Timer(Me.components)
        Me.clock_timer = New System.Windows.Forms.Timer(Me.components)
        Me.s_song_timer = New System.Windows.Forms.Timer(Me.components)
        Me.Timer5 = New System.Windows.Forms.Timer(Me.components)
        Me.Timer6 = New System.Windows.Forms.Timer(Me.components)
        Me.anno_warning_ico = New System.Windows.Forms.PictureBox()
        Me.exit_blue = New System.Windows.Forms.PictureBox()
        Me.ab_on_text = New System.Windows.Forms.Label()
        Me.ab_off_text = New System.Windows.Forms.Label()
        Me.ab_off_ico = New System.Windows.Forms.PictureBox()
        Me.anno_mode_blue = New System.Windows.Forms.PictureBox()
        Me.Turn_off_cmb_blue = New System.Windows.Forms.PictureBox()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.ab_off_notf_ico = New System.Windows.Forms.PictureBox()
        Me.time_display = New System.Windows.Forms.Label()
        Me.Em_mode_blue = New System.Windows.Forms.PictureBox()
        Me.Turn_on_cmb_blue = New System.Windows.Forms.PictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.Timer8 = New System.Windows.Forms.Timer(Me.components)
        Me.mtm_notf_ico = New System.Windows.Forms.PictureBox()
        Me.mtm_notf_text = New System.Windows.Forms.Label()
        Me.ab_on_ico = New System.Windows.Forms.PictureBox()
        Me.main_player = New AxWMPLib.AxWindowsMediaPlayer()
        Me.Bell_only_for_announce = New AxWMPLib.AxWindowsMediaPlayer()
        CType(Me.anno_warning_ico, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.exit_blue, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ab_off_ico, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.anno_mode_blue, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Turn_off_cmb_blue, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ab_off_notf_ico, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Em_mode_blue, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Turn_on_cmb_blue, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.mtm_notf_ico, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ab_on_ico, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.main_player, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Bell_only_for_announce, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'autobell_timer
        '
        Me.autobell_timer.Interval = 1
        '
        'monthly_test_timer
        '
        Me.monthly_test_timer.Interval = 1
        '
        'clock_timer
        '
        Me.clock_timer.Enabled = True
        Me.clock_timer.Interval = 1
        '
        's_song_timer
        '
        Me.s_song_timer.Interval = 1
        '
        'Timer6
        '
        Me.Timer6.Interval = 1
        '
        'anno_warning_ico
        '
        Me.anno_warning_ico.Image = CType(resources.GetObject("anno_warning_ico.Image"), System.Drawing.Image)
        Me.anno_warning_ico.Location = New System.Drawing.Point(535, 166)
        Me.anno_warning_ico.Name = "anno_warning_ico"
        Me.anno_warning_ico.Size = New System.Drawing.Size(35, 34)
        Me.anno_warning_ico.TabIndex = 117
        Me.anno_warning_ico.TabStop = False
        Me.ToolTip1.SetToolTip(Me.anno_warning_ico, "Announce mode is on! " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Turn off announce mode after announcing...")
        Me.anno_warning_ico.Visible = False
        '
        'exit_blue
        '
        Me.exit_blue.Cursor = System.Windows.Forms.Cursors.Hand
        Me.exit_blue.Image = CType(resources.GetObject("exit_blue.Image"), System.Drawing.Image)
        Me.exit_blue.Location = New System.Drawing.Point(449, 268)
        Me.exit_blue.Name = "exit_blue"
        Me.exit_blue.Size = New System.Drawing.Size(121, 33)
        Me.exit_blue.TabIndex = 112
        Me.exit_blue.TabStop = False
        Me.ToolTip1.SetToolTip(Me.exit_blue, "Exit")
        '
        'ab_on_text
        '
        Me.ab_on_text.AutoSize = True
        Me.ab_on_text.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ab_on_text.ForeColor = System.Drawing.Color.White
        Me.ab_on_text.Location = New System.Drawing.Point(52, 13)
        Me.ab_on_text.Name = "ab_on_text"
        Me.ab_on_text.Size = New System.Drawing.Size(149, 20)
        Me.ab_on_text.TabIndex = 103
        Me.ab_on_text.Text = "Autobell mode is ON"
        '
        'ab_off_text
        '
        Me.ab_off_text.AutoSize = True
        Me.ab_off_text.Font = New System.Drawing.Font("Segoe UI Symbol", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ab_off_text.ForeColor = System.Drawing.Color.White
        Me.ab_off_text.Location = New System.Drawing.Point(52, 13)
        Me.ab_off_text.Name = "ab_off_text"
        Me.ab_off_text.Size = New System.Drawing.Size(152, 20)
        Me.ab_off_text.TabIndex = 104
        Me.ab_off_text.Text = "Autobell mode is OFF"
        '
        'ab_off_ico
        '
        Me.ab_off_ico.Image = CType(resources.GetObject("ab_off_ico.Image"), System.Drawing.Image)
        Me.ab_off_ico.Location = New System.Drawing.Point(10, 9)
        Me.ab_off_ico.Name = "ab_off_ico"
        Me.ab_off_ico.Size = New System.Drawing.Size(39, 36)
        Me.ab_off_ico.TabIndex = 106
        Me.ab_off_ico.TabStop = False
        '
        'anno_mode_blue
        '
        Me.anno_mode_blue.Cursor = System.Windows.Forms.Cursors.Hand
        Me.anno_mode_blue.Image = CType(resources.GetObject("anno_mode_blue.Image"), System.Drawing.Image)
        Me.anno_mode_blue.Location = New System.Drawing.Point(10, 268)
        Me.anno_mode_blue.Name = "anno_mode_blue"
        Me.anno_mode_blue.Size = New System.Drawing.Size(121, 33)
        Me.anno_mode_blue.TabIndex = 110
        Me.anno_mode_blue.TabStop = False
        Me.ToolTip1.SetToolTip(Me.anno_mode_blue, "Announce Mode")
        '
        'Turn_off_cmb_blue
        '
        Me.Turn_off_cmb_blue.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Turn_off_cmb_blue.Image = CType(resources.GetObject("Turn_off_cmb_blue.Image"), System.Drawing.Image)
        Me.Turn_off_cmb_blue.Location = New System.Drawing.Point(227, 268)
        Me.Turn_off_cmb_blue.Name = "Turn_off_cmb_blue"
        Me.Turn_off_cmb_blue.Size = New System.Drawing.Size(121, 33)
        Me.Turn_off_cmb_blue.TabIndex = 107
        Me.Turn_off_cmb_blue.TabStop = False
        Me.ToolTip1.SetToolTip(Me.Turn_off_cmb_blue, "Turn OFF bell")
        '
        'ab_off_notf_ico
        '
        Me.ab_off_notf_ico.Image = CType(resources.GetObject("ab_off_notf_ico.Image"), System.Drawing.Image)
        Me.ab_off_notf_ico.Location = New System.Drawing.Point(535, 126)
        Me.ab_off_notf_ico.Name = "ab_off_notf_ico"
        Me.ab_off_notf_ico.Size = New System.Drawing.Size(35, 34)
        Me.ab_off_notf_ico.TabIndex = 122
        Me.ab_off_notf_ico.TabStop = False
        Me.ToolTip1.SetToolTip(Me.ab_off_notf_ico, "Autobell mode is turned off!")
        Me.ab_off_notf_ico.Visible = False
        '
        'time_display
        '
        Me.time_display.AutoSize = True
        Me.time_display.Font = New System.Drawing.Font("Segoe UI Symbol", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.time_display.ForeColor = System.Drawing.Color.GreenYellow
        Me.time_display.Location = New System.Drawing.Point(431, 12)
        Me.time_display.Name = "time_display"
        Me.time_display.Size = New System.Drawing.Size(88, 21)
        Me.time_display.TabIndex = 113
        Me.time_display.Text = "8:00:00 PM"
        Me.ToolTip1.SetToolTip(Me.time_display, "Current system time")
        '
        'Em_mode_blue
        '
        Me.Em_mode_blue.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Em_mode_blue.Image = CType(resources.GetObject("Em_mode_blue.Image"), System.Drawing.Image)
        Me.Em_mode_blue.Location = New System.Drawing.Point(10, 217)
        Me.Em_mode_blue.Name = "Em_mode_blue"
        Me.Em_mode_blue.Size = New System.Drawing.Size(121, 33)
        Me.Em_mode_blue.TabIndex = 109
        Me.Em_mode_blue.TabStop = False
        Me.ToolTip1.SetToolTip(Me.Em_mode_blue, "Custom Mode")
        '
        'Turn_on_cmb_blue
        '
        Me.Turn_on_cmb_blue.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Turn_on_cmb_blue.Image = CType(resources.GetObject("Turn_on_cmb_blue.Image"), System.Drawing.Image)
        Me.Turn_on_cmb_blue.Location = New System.Drawing.Point(227, 268)
        Me.Turn_on_cmb_blue.Name = "Turn_on_cmb_blue"
        Me.Turn_on_cmb_blue.Size = New System.Drawing.Size(121, 33)
        Me.Turn_on_cmb_blue.TabIndex = 108
        Me.Turn_on_cmb_blue.TabStop = False
        Me.ToolTip1.SetToolTip(Me.Turn_on_cmb_blue, "Turn ON bell")
        '
        'PictureBox1
        '
        Me.PictureBox1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(534, 9)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(34, 32)
        Me.PictureBox1.TabIndex = 123
        Me.PictureBox1.TabStop = False
        Me.ToolTip1.SetToolTip(Me.PictureBox1, "Settings")
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(535, 86)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(35, 34)
        Me.PictureBox2.TabIndex = 124
        Me.PictureBox2.TabStop = False
        Me.ToolTip1.SetToolTip(Me.PictureBox2, "Running on " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "default schedule!")
        Me.PictureBox2.Visible = False
        '
        'PictureBox3
        '
        Me.PictureBox3.Image = CType(resources.GetObject("PictureBox3.Image"), System.Drawing.Image)
        Me.PictureBox3.Location = New System.Drawing.Point(535, 86)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(35, 34)
        Me.PictureBox3.TabIndex = 125
        Me.PictureBox3.TabStop = False
        Me.ToolTip1.SetToolTip(Me.PictureBox3, "Running on " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "custom schedule!")
        Me.PictureBox3.Visible = False
        '
        'mtm_notf_ico
        '
        Me.mtm_notf_ico.Image = CType(resources.GetObject("mtm_notf_ico.Image"), System.Drawing.Image)
        Me.mtm_notf_ico.Location = New System.Drawing.Point(10, 72)
        Me.mtm_notf_ico.Name = "mtm_notf_ico"
        Me.mtm_notf_ico.Size = New System.Drawing.Size(36, 36)
        Me.mtm_notf_ico.TabIndex = 116
        Me.mtm_notf_ico.TabStop = False
        Me.mtm_notf_ico.Visible = False
        '
        'mtm_notf_text
        '
        Me.mtm_notf_text.AutoSize = True
        Me.mtm_notf_text.Font = New System.Drawing.Font("Segoe UI Symbol", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.mtm_notf_text.ForeColor = System.Drawing.Color.White
        Me.mtm_notf_text.Location = New System.Drawing.Point(52, 74)
        Me.mtm_notf_text.Name = "mtm_notf_text"
        Me.mtm_notf_text.Size = New System.Drawing.Size(326, 21)
        Me.mtm_notf_text.TabIndex = 115
        Me.mtm_notf_text.Text = "Please insert Tracks and Task times to begin... "
        Me.mtm_notf_text.Visible = False
        '
        'ab_on_ico
        '
        Me.ab_on_ico.Image = CType(resources.GetObject("ab_on_ico.Image"), System.Drawing.Image)
        Me.ab_on_ico.Location = New System.Drawing.Point(10, 9)
        Me.ab_on_ico.Name = "ab_on_ico"
        Me.ab_on_ico.Size = New System.Drawing.Size(36, 36)
        Me.ab_on_ico.TabIndex = 105
        Me.ab_on_ico.TabStop = False
        '
        'main_player
        '
        Me.main_player.Enabled = True
        Me.main_player.Location = New System.Drawing.Point(360, 126)
        Me.main_player.Name = "main_player"
        Me.main_player.OcxState = CType(resources.GetObject("main_player.OcxState"), System.Windows.Forms.AxHost.State)
        Me.main_player.Size = New System.Drawing.Size(75, 23)
        Me.main_player.TabIndex = 120
        Me.main_player.Visible = False
        '
        'Bell_only_for_announce
        '
        Me.Bell_only_for_announce.Enabled = True
        Me.Bell_only_for_announce.Location = New System.Drawing.Point(360, 170)
        Me.Bell_only_for_announce.Name = "Bell_only_for_announce"
        Me.Bell_only_for_announce.OcxState = CType(resources.GetObject("Bell_only_for_announce.OcxState"), System.Windows.Forms.AxHost.State)
        Me.Bell_only_for_announce.Size = New System.Drawing.Size(75, 23)
        Me.Bell_only_for_announce.TabIndex = 121
        Me.Bell_only_for_announce.Visible = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(37, Byte), Integer), CType(CType(37, Byte), Integer), CType(CType(38, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(580, 310)
        Me.ControlBox = False
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.ab_off_notf_ico)
        Me.Controls.Add(Me.Bell_only_for_announce)
        Me.Controls.Add(Me.main_player)
        Me.Controls.Add(Me.anno_warning_ico)
        Me.Controls.Add(Me.exit_blue)
        Me.Controls.Add(Me.ab_on_text)
        Me.Controls.Add(Me.ab_off_text)
        Me.Controls.Add(Me.anno_mode_blue)
        Me.Controls.Add(Me.time_display)
        Me.Controls.Add(Me.mtm_notf_ico)
        Me.Controls.Add(Me.mtm_notf_text)
        Me.Controls.Add(Me.ab_on_ico)
        Me.Controls.Add(Me.Em_mode_blue)
        Me.Controls.Add(Me.ab_off_ico)
        Me.Controls.Add(Me.Turn_off_cmb_blue)
        Me.Controls.Add(Me.Turn_on_cmb_blue)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.PictureBox3)
        Me.Font = New System.Drawing.Font("Segoe UI Symbol", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximumSize = New System.Drawing.Size(590, 352)
        Me.MinimizeBox = False
        Me.Name = "Form1"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Autobell"
        CType(Me.anno_warning_ico, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.exit_blue, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ab_off_ico, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.anno_mode_blue, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Turn_off_cmb_blue, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ab_off_notf_ico, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Em_mode_blue, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Turn_on_cmb_blue, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.mtm_notf_ico, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ab_on_ico, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.main_player, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Bell_only_for_announce, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Timer7 As System.Windows.Forms.Timer
    Friend WithEvents autobell_timer As System.Windows.Forms.Timer
    Friend WithEvents monthly_test_timer As System.Windows.Forms.Timer
    Friend WithEvents clock_timer As System.Windows.Forms.Timer
    Friend WithEvents s_song_timer As System.Windows.Forms.Timer
    Friend WithEvents Timer5 As System.Windows.Forms.Timer
    Friend WithEvents Timer6 As System.Windows.Forms.Timer
    Friend WithEvents anno_warning_ico As System.Windows.Forms.PictureBox
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
    Friend WithEvents exit_blue As System.Windows.Forms.PictureBox
    Friend WithEvents ab_on_text As System.Windows.Forms.Label
    Friend WithEvents ab_off_text As System.Windows.Forms.Label
    Friend WithEvents ab_off_ico As System.Windows.Forms.PictureBox
    Friend WithEvents anno_mode_blue As System.Windows.Forms.PictureBox
    Friend WithEvents Turn_off_cmb_blue As System.Windows.Forms.PictureBox
    Friend WithEvents time_display As System.Windows.Forms.Label
    Friend WithEvents Timer8 As System.Windows.Forms.Timer
    Friend WithEvents mtm_notf_ico As System.Windows.Forms.PictureBox
    Friend WithEvents mtm_notf_text As System.Windows.Forms.Label
    Friend WithEvents ab_on_ico As System.Windows.Forms.PictureBox
    Friend WithEvents Em_mode_blue As System.Windows.Forms.PictureBox
    Friend WithEvents Turn_on_cmb_blue As System.Windows.Forms.PictureBox
    Friend WithEvents main_player As AxWMPLib.AxWindowsMediaPlayer
    Friend WithEvents Bell_only_for_announce As AxWMPLib.AxWindowsMediaPlayer
    Friend WithEvents ab_off_notf_ico As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox3 As System.Windows.Forms.PictureBox

End Class
