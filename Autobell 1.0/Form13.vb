Public Class Form13

    Private Sub turn_off_ab_ok_Click(sender As Object, e As EventArgs) Handles turn_on_ab_ok.Click
        If System.IO.File.Exists("D:\Autobell\config.abl") = True Then
            Dim strFile As String = "D:\Autobell\config.abl"
            Dim sr As New IO.StreamReader(strFile)
            If input_password.Text = sr.ReadLine() Then
                Form1.main_player.settings.mute = False
                Form1.ab_off_notf_ico.Visible = False
                Form1.Turn_on_cmb_blue.Visible = False
                Form1.Turn_off_cmb_blue.Visible = True
                Form1.ab_on_text.Visible = True
                Form1.ab_on_ico.Visible = True
                Form1.time_display.ForeColor = Color.YellowGreen
                MessageBox.Show("Autobell is turned on...", "Success", _
                MessageBoxButtons.OK)
                Form1.Visible = True
                Me.Close()
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

    Private Sub turn_off_ab_cancel_Click(sender As Object, e As EventArgs) Handles turn_on_ab_cancel.Click
        Form1.Visible = True
        Me.Close()
    End Sub
End Class