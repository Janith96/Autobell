Imports System.IO

Public Class Form18

    Private Sub PictureBox6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox6.Click

        If TextBox1.Text = TextBox4.Text And TextBox2.Text = TextBox3.Text Then
            Dim objWriter As New System.IO.StreamWriter("D:\Autobell\config.abl", False)
            objWriter.WriteLine(TextBox1.Text)
            objWriter.WriteLine(TextBox2.Text)
            objWriter.Close()
            MessageBox.Show("Password Changed!", "Success", _
                MessageBoxButtons.OK)
        Else
            MessageBox.Show("These passwords don't match. Try again!", "Error", _
                MessageBoxButtons.OK)

        End If
    End Sub

    Private Sub Form18_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        If System.IO.File.Exists("D:\Autobell\config.abl") = False Then
            Dim filepath As String = "D:\Autobell\config.abl"
            If Not System.IO.File.Exists(filepath) Then
                System.IO.File.Create(filepath).Dispose()
            End If
        End If
    End Sub

    Private Sub back_cmb_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles back_cmb.Click
        Me.Visible = False
        Form19.Visible = True
    End Sub
End Class