Public Class Form17

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        OpenFileDialog3.Filter = "MP3 Files | *.mp3"
        If OpenFileDialog3.ShowDialog = DialogResult.OK Then
            TextBox3.Text = OpenFileDialog3.FileName

        End If
    End Sub

    Private Sub PictureBox1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox1.Click
        OpenFileDialog1.Filter = "MP3 Files | *.mp3"
        If OpenFileDialog1.ShowDialog = DialogResult.OK Then
            TextBox1.Text = OpenFileDialog1.FileName

        End If
    End Sub

    Private Sub PictureBox2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox2.Click
        OpenFileDialog2.Filter = "MP3 Files | *.mp3"
        If OpenFileDialog2.ShowDialog = DialogResult.OK Then
            TextBox2.Text = OpenFileDialog2.FileName

        End If
    End Sub

    Private Sub PictureBox3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox3.Click
        OpenFileDialog3.Filter = "MP3 Files | *.mp3"
        If OpenFileDialog3.ShowDialog = DialogResult.OK Then
            TextBox3.Text = OpenFileDialog3.FileName

        End If
    End Sub

    Private Sub PictureBox4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox4.Click
        OpenFileDialog4.Filter = "MP3 Files | *.mp3"
        If OpenFileDialog4.ShowDialog = DialogResult.OK Then
            TextBox4.Text = OpenFileDialog4.FileName

        End If
    End Sub

    Private Sub PictureBox5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox5.Click
        OpenFileDialog5.Filter = "MP3 Files | *.mp3"
        If OpenFileDialog5.ShowDialog = DialogResult.OK Then
            TextBox5.Text = OpenFileDialog5.FileName

        End If
    End Sub
    Private Sub PictureBox8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox8.Click
        OpenFileDialog5.Filter = "MP3 Files | *.mp3"
        If OpenFileDialog5.ShowDialog = DialogResult.OK Then
            TextBox7.Text = OpenFileDialog5.FileName

        End If
    End Sub
    Private Sub PictureBox7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox7.Click
        OpenFileDialog5.Filter = "MP3 Files | *.mp3"
        If OpenFileDialog5.ShowDialog = DialogResult.OK Then
            TextBox6.Text = OpenFileDialog5.FileName

        End If
    End Sub
    Private Sub PictureBox9_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox9.Click
        OpenFileDialog5.Filter = "MP3 Files | *.mp3"
        If OpenFileDialog5.ShowDialog = DialogResult.OK Then
            TextBox8.Text = OpenFileDialog5.FileName

        End If
    End Sub


    Private Sub PictureBox6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox6.Click
        If System.IO.File.Exists("D:\Autobell\time.abl") = True Then
            Dim objWriter As New System.IO.StreamWriter("D:\Autobell\track_config.abl", False)
            objWriter.WriteLine("ok")
            objWriter.Close()
        Else
            Dim filepath As String = "D:\Autobell\track_config.abl"
            If Not System.IO.File.Exists(filepath) Then
                System.IO.File.Create(filepath).Dispose()
                Dim objWriter As New System.IO.StreamWriter("D:\Autobell\track_config.abl", False)
                objWriter.WriteLine("ok")
                objWriter.Close()
            End If
        End If
        If TextBox1.Text.Any Then
            My.Computer.FileSystem.CopyFile(
        TextBox1.Text,
        "D:\Autobell\Audio files\Bell.mp3",
        Microsoft.VisualBasic.FileIO.UIOption.AllDialogs,
        Microsoft.VisualBasic.FileIO.UICancelOption.DoNothing)
        End If

        If TextBox2.Text.Any Then
            My.Computer.FileSystem.CopyFile(
        TextBox2.Text,
        "D:\Autobell\Audio files\National_Anthem.mp3",
        Microsoft.VisualBasic.FileIO.UIOption.AllDialogs,
        Microsoft.VisualBasic.FileIO.UICancelOption.DoNothing)
        End If

        If TextBox3.Text.Any Then
            My.Computer.FileSystem.CopyFile(
        TextBox3.Text,
        "D:\Autobell\Audio files\School_Anthem.mp3",
        Microsoft.VisualBasic.FileIO.UIOption.AllDialogs,
        Microsoft.VisualBasic.FileIO.UICancelOption.DoNothing)
        End If

        If TextBox4.Text.Any Then
            My.Computer.FileSystem.CopyFile(
        TextBox4.Text,
        "D:\Autobell\Audio files\Stanza_ending.mp3",
        Microsoft.VisualBasic.FileIO.UIOption.AllDialogs,
        Microsoft.VisualBasic.FileIO.UICancelOption.DoNothing)
        End If

        If TextBox5.Text.Any Then
            My.Computer.FileSystem.CopyFile(
        TextBox5.Text,
        "D:\Autobell\Audio files\Stanza_beginning.mp3",
        Microsoft.VisualBasic.FileIO.UIOption.AllDialogs,
        Microsoft.VisualBasic.FileIO.UICancelOption.DoNothing)
        End If

        If TextBox7.Text.Any Then
            My.Computer.FileSystem.CopyFile(
        TextBox7.Text,
        "D:\Autobell\Audio files\Custom_track_1.mp3",
        Microsoft.VisualBasic.FileIO.UIOption.AllDialogs,
        Microsoft.VisualBasic.FileIO.UICancelOption.DoNothing)
        End If

        If TextBox6.Text.Any Then
            My.Computer.FileSystem.CopyFile(
        TextBox6.Text,
        "D:\Autobell\Audio files\Custom_track_2.mp3",
        Microsoft.VisualBasic.FileIO.UIOption.AllDialogs,
        Microsoft.VisualBasic.FileIO.UICancelOption.DoNothing)
        End If

        If TextBox8.Text.Any Then
            My.Computer.FileSystem.CopyFile(
        TextBox8.Text,
        "D:\Autobell\Audio files\Custom_track_3.mp3",
        Microsoft.VisualBasic.FileIO.UIOption.AllDialogs,
        Microsoft.VisualBasic.FileIO.UICancelOption.DoNothing)
        End If



        MessageBox.Show("Tracks Changed!", "Success", _
                MessageBoxButtons.OK)
        Form1.Visible = True
        Me.Visible = False
    End Sub

    Private Sub back_cmb_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles back_cmb.Click
        Me.Visible = False
        Form19.Visible=True 
    End Sub

    
End Class