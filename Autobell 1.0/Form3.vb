Public Class Form3

    Private Sub turn_off_ab_cancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles turn_off_ab_cancel.Click
        Form1.Visible = True
        Me.Close()
    End Sub

    Private Sub turn_off_ab_ok_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles turn_off_ab_ok.Click
        If System.IO.File.Exists("D:\Autobell\config.abl") = True Then
            Dim strFile As String = "D:\Autobell\config.abl"
            Dim sr As New IO.StreamReader(strFile)
            If input_password.Text = sr.ReadLine() Then
                Form19.Visible = True
                sr.Close()
                Me.Close()
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
End Class