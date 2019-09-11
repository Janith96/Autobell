Imports System.IO

Public Class Form22

    Private Sub PictureBox6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox6.Click
        
        If TextBox1.Text.Any And TextBox2.Text.Any And TextBox3.Text.Any And TextBox4.Text.Any Then
                If TextBox1.Text = TextBox4.Text And TextBox2.Text = TextBox3.Text Then
                    If System.IO.File.Exists("D:\Autobell\config.abl") = False Then
                        Dim filepath As String = "D:\Autobell\config.abl"
                        System.IO.File.Create(filepath).Dispose()
                    End If
                    Dim objWriter As New System.IO.StreamWriter("D:\Autobell\config.abl", False)
                    objWriter.WriteLine(TextBox1.Text)
                    objWriter.WriteLine(TextBox2.Text)
                    objWriter.Close()
                MessageBox.Show("Passwords Created!", "Success", _
                        MessageBoxButtons.OK)
                    Form1.Visible = True
                    Me.Visible = False
                Else
                    MessageBox.Show("These passwords didn't match. Try again!", "Error", _
                        MessageBoxButtons.OK)

                End If

        Else
            MessageBox.Show("Please create Admin and User passwords to continue...", "Error", _
                    MessageBoxButtons.OK)
        End If
    End Sub

    Private Sub Form22_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.TopMost = True
    End Sub

End Class