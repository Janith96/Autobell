Public Class Form20

    Private Sub emg_ok_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles emg_ok.Click
        If System.IO.File.Exists("D:\Autobell\config.abl") = True Then
            Dim strFile As String = "D:\Autobell\config.abl"
            Dim sr As New IO.StreamReader(strFile)
            If input_password.Text = sr.ReadLine() Then
                Form19.Visible = True
                Me.Visible = False
                sr.Close()
            Else
                MessageBox.Show("Password Incorrect!", "Error", _
                MessageBoxButtons.OK)
            End If
        Else
            MessageBox.Show("Please set-up password from settings menu to continue", "Error", _
              MessageBoxButtons.OK)
        End If
    End Sub
End Class