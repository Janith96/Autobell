Public Class Form8

    Private Sub exit_ok_Click(sender As Object, e As EventArgs) Handles exit_ok.Click
        If System.IO.File.Exists("D:\Autobell\config.abl") = True Then
            Dim strFile As String = "D:\Autobell\config.abl"
            Dim sr As New IO.StreamReader(strFile)
            If input_password.Text = sr.ReadLine() Then
                Dim dr As DialogResult = MessageBox.Show("Are you sure you want to exit from autobell?", "Exit confirmation", MessageBoxButtons.YesNo)
                If dr = DialogResult.Yes Then
                    End
                    sr.Close()
                Else
                    Form1.Visible = True
                    Me.Close()
                    sr.Close()
                End If
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

    Private Sub exit_cancel_Click(sender As Object, e As EventArgs) Handles exit_cancel.Click
        Form1.Visible = True
        Me.Close()
    End Sub
End Class