Public Class Form7

    Private Sub emg_ok_Click(sender As Object, e As EventArgs) Handles emg_ok.Click
        If System.IO.File.Exists("D:\Autobell\config.abl") = True Then
            Dim strFile As String = "D:\Autobell\config.abl"
            Dim sr As New IO.StreamReader(strFile)
            If input_password.Text = sr.ReadLine() Then
                Form2.player12.settings.mute = False
            Form1.main_player.settings.mute = True
            Me.Close()
            Form2.Visible = True
                MessageBox.Show("Custom mode is activated...", "Success", _
                MessageBoxButtons.OK)
                sr.Close()
            Else
                MessageBox.Show("Wrong password...", "Error", _
                MessageBoxButtons.OK)
                sr.Close()
            End If
        Else
            MessageBox.Show("Please set-up password from settings menu to continue", "Error", _
               MessageBoxButtons.OK)
        End If
    End Sub

    Private Sub emg_cancel_Click(sender As Object, e As EventArgs) Handles emg_cancel.Click
        Me.Close()
        Form1.Visible = True
    End Sub
End Class