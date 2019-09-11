Public Class Form15

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        If System.IO.File.Exists("D:\Autobell\config.abl") = False Then
            Form1.Visible = False
        Else
            Form1.Visible = True
        End If
        Me.Close()
    End Sub
End Class