Imports System.IO
Public Class Form19

    Private Sub PictureBox1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox1.Click
        Me.Visible = False
        Form17.Visible = True
    End Sub

    Private Sub PictureBox3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox3.Click
        Me.Visible = False
        Form18.Visible = True
    End Sub
    Public Function ReadLine(ByVal lineNumber As Integer, ByVal lines As List(Of String)) As String
        Return lines(lineNumber - 1)
    End Function
    Private Sub PictureBox2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox2.Click
    Dim filepath As String = "D:\Autobell\time.abl"
    Dim cufilepath As String = "D:\Autobell\time_cu.abl"
    Dim changefilepath As String = "D:\Autobell\act_sch.abl"
        If System.IO.File.Exists(filepath) And System.IO.File.Exists(cufilepath) Then
            If Not System.IO.File.Exists(changefilepath) Then
                System.IO.File.Create(changefilepath).Dispose()
                Dim objWriter As New System.IO.StreamWriter("D:\Autobell\act_sch.abl", False)
                objWriter.WriteLine("Default")
                objWriter.Close()
            Else
    Dim reader As New System.IO.StreamReader("D:\Autobell\act_sch.abl")
    Dim allLines As List(Of String) = New List(Of String)
                Do While Not reader.EndOfStream
                    allLines.Add(reader.ReadLine())
                Loop
                reader.Close()

                If ReadLine(1, allLines) = "Default" Then
                    Form1.s_song_timer.Enabled = True
                    Form1.PictureBox3.Visible = True
                    Form1.PictureBox2.Visible = False
                    Form1.autobell_timer.Enabled = False
                    Dim objWriter As New System.IO.StreamWriter("D:\Autobell\act_sch.abl", False)
                    objWriter.WriteLine("Custom")
                    objWriter.Close()

                    Me.Visible = False
                    Form1.Visible = True
                    MessageBox.Show("Custom Schedule activated!", "Success", _
                        MessageBoxButtons.OK)

                ElseIf ReadLine(1, allLines) = "Custom" Then
                    Form1.s_song_timer.Enabled = False
                    Form1.PictureBox3.Visible = False
                    Form1.PictureBox2.Visible = True
                    Form1.autobell_timer.Enabled = True
                    Dim objWriter As New System.IO.StreamWriter("D:\Autobell\act_sch.abl", False)
                    objWriter.WriteLine("Default")
                    objWriter.Close()

                    Me.Visible = False
                    Form1.Visible = True
                    MessageBox.Show("Default Schedule activated!", "Success", _
                        MessageBoxButtons.OK)

                End If


            End If
        Else
            MessageBox.Show("Please add tasks to both schedules before changing the schedules!", "Error", _
                        MessageBoxButtons.OK)
        End If



    End Sub

    Private Sub back_cmb_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles back_cmb.Click
        Me.Visible = False
        Form1.Visible = True
    End Sub

    Private Sub Form19_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
    End Sub

    Private Sub PictureBox4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox4.Click
        Me.Visible = False
        Form16.Visible = True
    End Sub

    Private Sub PictureBox5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox5.Click
        Dim changefilepath As String = "D:\Autobell\act_sch.abl"
        If System.IO.File.Exists(changefilepath) Then
            Me.Visible = False
            Form4.Visible = True
        Else
            MessageBox.Show("Please add tasks to Default schedule before edit Custom Schedule!", "Error", _
                        MessageBoxButtons.OK)
        End If




    End Sub

    Private Sub PictureBox6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox6.Click
        Dim dr As DialogResult = MessageBox.Show("Are you sure you want to reset Autobell?", "Reset confirmation", MessageBoxButtons.YesNo)
        If dr = DialogResult.Yes Then

            Dim act_sch As String
            Dim config As String
            Dim time As String
            Dim time_cu As String
            Dim track_config As String
            Dim audio_dir As String


            act_sch = "D:\Autobell\act_sch.abl"
            config = "D:\Autobell\config.abl"
            time = "D:\Autobell\time.abl"
            time_cu = "D:\Autobell\time_cu.abl"
            track_config = "D:\Autobell\track_config.abl"
            audio_dir = "D:\Autobell\Audio files"


            If System.IO.File.Exists(act_sch) = True Then
                System.IO.File.Delete(act_sch)
            End If
            If System.IO.File.Exists(config) = True Then
                System.IO.File.Delete(config)
            End If
            If System.IO.File.Exists(time) = True Then
                System.IO.File.Delete(time)
            End If
            If System.IO.File.Exists(time_cu) = True Then
                System.IO.File.Delete(time_cu)
            End If
            If System.IO.File.Exists(track_config) = True Then
                System.IO.File.Delete(track_config)
            End If
            If System.IO.File.Exists(audio_dir) = True Then
                My.Computer.FileSystem.DeleteDirectory("D:\Autobell\Audio files", _
                FileIO.DeleteDirectoryOption.DeleteAllContents)
            End If
            MessageBox.Show("Reset Complete. Autobell is restarting...", "Success", _
                        MessageBoxButtons.OK)
            Application.Restart()
        Else
            Me.Visible = True
        End If
    End Sub
End Class