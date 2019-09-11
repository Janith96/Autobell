Imports System
Imports System.Runtime.InteropServices

Public Class Form2
    'player command list started....

    Dim mci As Object

    Private Sub bell_cmb_Click(ByVal sender As Object, ByVal e As EventArgs) Handles psb_cmb.Click
        If System.IO.File.Exists("D:\Autobell\Audio files\Bell.mp3") = True Then
            player12.URL = "D:\Autobell\Audio files\Bell.mp3"
        Else
            MessageBox.Show("Please add Bell track from settings menu to play", "Error", _
                MessageBoxButtons.OK)
        End If
    End Sub

    Private Sub pag_cmb_Click(ByVal sender As Object, ByVal e As EventArgs) Handles pag_cmb.Click


        If System.IO.File.Exists("D:\Autobell\Audio files\Stanza_ending.mp3") = True Then
            player12.URL = "D:\Autobell\Audio files\Stanza_ending.mp3"
        Else
            MessageBox.Show("Please add Stanza-Ending track from settings menu to play", "Error", _
                MessageBoxButtons.OK)
        End If
    End Sub

    Private Sub psa_cmb_Click(ByVal sender As Object, ByVal e As EventArgs) Handles psa_cmb.Click
        If System.IO.File.Exists("D:\Autobell\Audio files\School_Anthem.mp3") = True Then
            player12.URL = "D:\Autobell\Audio files\School_Anthem.mp3"
        Else
            MessageBox.Show("Please add School Anthem track from settings menu to play", "Error", _
                MessageBoxButtons.OK)
        End If
    End Sub

    Private Sub pp_cmb_Click(ByVal sender As Object, ByVal e As EventArgs) Handles pp_cmb.Click
        If System.IO.File.Exists("D:\Autobell\Audio files\Stanza_beginning.mp3") = True Then
            player12.URL = "D:\Autobell\Audio files\Stanza_beginning.mp3"
        Else
            MessageBox.Show("Please add Stanza-Beginning track from settings menu to play", "Error", _
                MessageBoxButtons.OK)
        End If
    End Sub

    Private Sub pna_cmb_Click(ByVal sender As Object, ByVal e As EventArgs) Handles pna_cmb.Click
        If System.IO.File.Exists("D:\Autobell\Audio files\National_Anthem.mp3") = True Then
            player12.URL = "D:\Autobell\Audio files\National_Anthem.mp3"
        Else
            MessageBox.Show("Please add National Anthem track from settings menu to play", "Error", _
                MessageBoxButtons.OK)
        End If
    End Sub

    'player command list ended.....
    '-----------------------------------------------------------------

    'back and turn off computer button code started...

    Private Sub PictureBox7_Click(ByVal sender As Object, ByVal e As EventArgs) Handles back_cmb.Click
        Me.Visible = False
        Dim msg As String
        Dim title As String
        Dim style As MsgBoxStyle
        Dim response As MsgBoxResult
        msg = "Are you sure do you want to exit from Custom mode?"   ' Define message.
        style = MsgBoxStyle.YesNo
        title = "Exit confirmation"   ' Define title.
        ' Display message.
        response = MsgBox(msg, style, title)
        If response = MsgBoxResult.Yes Then   ' User chose Yes.
            Form1.Visible = True
            Form1.main_player.settings.mute = False
            Me.Close()
        Else
            Me.Visible = True
        End If
    End Sub

    Private Sub PictureBox6_Click(ByVal sender As Object, ByVal e As EventArgs) Handles toc_cmb.Click
        Me.Visible = False
        Dim msg As String
        Dim title As String
        Dim style As MsgBoxStyle
        Dim response As MsgBoxResult
        msg = "Are you sure do you want to Turn Off the computer?"   ' Define message.
        style = MsgBoxStyle.YesNo
        title = "Turn Off confirmation"   ' Define title.
        ' Display message.
        response = MsgBox(msg, style, title)
        If response = MsgBoxResult.Yes Then
            Call Shell("Shutdown /s")
        Else
            Me.Visible = True
        End If
        ' User chose Yes.
    End Sub

    'back and turn off computer button code ended...

    '----------------------------------------------------


    Private Sub PictureBox1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox1.Click
        If System.IO.File.Exists("D:\Autobell\Audio files\Custom_track_1.mp3") = True Then
            player12.URL = "D:\Autobell\Audio files\Custom_track_1.mp3"
        Else
            MessageBox.Show("Please add Custom track 1 from settings menu to play", "Error", _
                MessageBoxButtons.OK)
        End If
    End Sub

    Private Sub PictureBox2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox2.Click
        If System.IO.File.Exists("D:\Autobell\Audio files\Custom_track_2.mp3") = True Then
            player12.URL = "D:\Autobell\Audio files\Custom_track_2.mp3"
        Else
            MessageBox.Show("Please add Custom track 2 from settings menu to play", "Error", _
                MessageBoxButtons.OK)
        End If
    End Sub

    Private Sub PictureBox3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox3.Click
        If System.IO.File.Exists("D:\Autobell\Audio files\Custom_track_3.mp3") = True Then
            player12.URL = "D:\Autobell\Audio files\Custom_track_3.mp3"
        Else
            MessageBox.Show("Please add Custom track 3 from settings menu to play", "Error", _
                MessageBoxButtons.OK)
        End If
    End Sub

    
End Class