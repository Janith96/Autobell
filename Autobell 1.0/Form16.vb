Imports System.IO

Public Class Form16

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub Form16_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Form1.Close()
        If System.IO.File.Exists("D:\Autobell\time.abl") = True Then

            Dim strFile As String = "D:\Autobell\time.abl"
            Dim sr As New IO.StreamReader(strFile)

            'Task2
            TextBox2.Text = sr.ReadLine()
            ComboBox2.SelectedItem = sr.ReadLine()
            ComboBox15.SelectedItem = sr.ReadLine()

            'Task 3
            TextBox3.Text = sr.ReadLine()
            ComboBox4.SelectedItem = sr.ReadLine()
            ComboBox14.SelectedItem = sr.ReadLine()

            'Task 4
            TextBox4.Text = sr.ReadLine()
            ComboBox3.SelectedItem = sr.ReadLine()
            ComboBox13.SelectedItem = sr.ReadLine()

            'Task 5
            TextBox8.Text = sr.ReadLine()
            ComboBox8.SelectedItem = sr.ReadLine()
            ComboBox12.SelectedItem = sr.ReadLine()

            'Task 6
            TextBox7.Text = sr.ReadLine()
            ComboBox7.SelectedItem = sr.ReadLine()
            ComboBox11.SelectedItem = sr.ReadLine()

            'Task 7
            TextBox6.Text = sr.ReadLine()
            ComboBox6.SelectedItem = sr.ReadLine()
            ComboBox10.SelectedItem = sr.ReadLine()

            'Task 8
            TextBox5.Text = sr.ReadLine()
            ComboBox5.SelectedItem = sr.ReadLine()
            ComboBox9.SelectedItem = sr.ReadLine()

            'Task 9
            TextBox12.Text = sr.ReadLine()
            ComboBox24.SelectedItem = sr.ReadLine()
            ComboBox20.SelectedItem = sr.ReadLine()

            'Task 10
            TextBox11.Text = sr.ReadLine()
            ComboBox23.SelectedItem = sr.ReadLine()
            ComboBox19.SelectedItem = sr.ReadLine()

            'Task 11
            TextBox10.Text = sr.ReadLine()
            ComboBox22.SelectedItem = sr.ReadLine()
            ComboBox18.SelectedItem = sr.ReadLine()

            'Task 12
            TextBox9.Text = sr.ReadLine()
            ComboBox21.SelectedItem = sr.ReadLine()
            ComboBox17.SelectedItem = sr.ReadLine()

            'Task 13
            TextBox14.Text = sr.ReadLine()
            ComboBox28.SelectedItem = sr.ReadLine()
            ComboBox26.SelectedItem = sr.ReadLine()

            'Task 14
            TextBox13.Text = sr.ReadLine()
            ComboBox27.SelectedItem = sr.ReadLine()
            ComboBox25.SelectedItem = sr.ReadLine()

            'Task 15
            TextBox16.Text = sr.ReadLine()
            ComboBox32.SelectedItem = sr.ReadLine()
            ComboBox30.SelectedItem = sr.ReadLine()

            'Task 16
            TextBox1.Text = sr.ReadLine()
            ComboBox16.SelectedItem = sr.ReadLine()
            ComboBox1.SelectedItem = sr.ReadLine()

            'Task 17
            TextBox15.Text = sr.ReadLine()
            ComboBox31.SelectedItem = sr.ReadLine()
            ComboBox29.SelectedItem = sr.ReadLine()


            sr.Close()

        End If
    End Sub    

    Private Sub PictureBox6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox6.Click

        Dim changefilepath As String = "D:\Autobell\act_sch.abl"
        If Not System.IO.File.Exists(changefilepath) Then
            System.IO.File.Create(changefilepath).Dispose()
            Dim objWriter As New System.IO.StreamWriter("D:\Autobell\act_sch.abl", False)
            objWriter.WriteLine("Default")
            objWriter.Close()
        End If


        Dim filepath As String = "D:\Autobell\time.abl"
        If Not System.IO.File.Exists(filepath) Then
            System.IO.File.Create(filepath).Dispose()
            
        Else
            Dim objWriter As New System.IO.StreamWriter("D:\Autobell\time.abl", False)


            'Task 2
            objWriter.WriteLine(TextBox2.Text)
            objWriter.WriteLine(ComboBox2.SelectedItem)
            objWriter.WriteLine(ComboBox15.SelectedItem)


            'Task 3

            objWriter.WriteLine(TextBox3.Text)
            objWriter.WriteLine(ComboBox4.SelectedItem)
            objWriter.WriteLine(ComboBox14.SelectedItem)


            'Task 4 

            objWriter.WriteLine(TextBox4.Text)
            objWriter.WriteLine(ComboBox3.SelectedItem)
            objWriter.WriteLine(ComboBox13.SelectedItem)


            'Task 5

            objWriter.WriteLine(TextBox8.Text)
            objWriter.WriteLine(ComboBox8.SelectedItem)
            objWriter.WriteLine(ComboBox12.SelectedItem)


            'Task 6

            objWriter.WriteLine(TextBox7.Text)
            objWriter.WriteLine(ComboBox7.SelectedItem)
            objWriter.WriteLine(ComboBox11.SelectedItem)


            'Task 7

            objWriter.WriteLine(TextBox6.Text)
            objWriter.WriteLine(ComboBox6.SelectedItem)
            objWriter.WriteLine(ComboBox10.SelectedItem)

            'Task 8

            objWriter.WriteLine(TextBox5.Text)
            objWriter.WriteLine(ComboBox5.SelectedItem)
            objWriter.WriteLine(ComboBox9.SelectedItem)


            'Task 9

            objWriter.WriteLine(TextBox12.Text)
            objWriter.WriteLine(ComboBox24.SelectedItem)
            objWriter.WriteLine(ComboBox20.SelectedItem)


            'Task 10

            objWriter.WriteLine(TextBox11.Text)
            objWriter.WriteLine(ComboBox23.SelectedItem)
            objWriter.WriteLine(ComboBox19.SelectedItem)


            'Task 11

            objWriter.WriteLine(TextBox10.Text)
            objWriter.WriteLine(ComboBox22.SelectedItem)
            objWriter.WriteLine(ComboBox18.SelectedItem)


            'Task 12

            objWriter.WriteLine(TextBox9.Text)
            objWriter.WriteLine(ComboBox21.SelectedItem)
            objWriter.WriteLine(ComboBox17.SelectedItem)


            'Task 13

            objWriter.WriteLine(TextBox14.Text)
            objWriter.WriteLine(ComboBox28.SelectedItem)
            objWriter.WriteLine(ComboBox26.SelectedItem)


            'Task 14

            objWriter.WriteLine(TextBox13.Text)
            objWriter.WriteLine(ComboBox27.SelectedItem)
            objWriter.WriteLine(ComboBox25.SelectedItem)

            'Task 15

            objWriter.WriteLine(TextBox16.Text)
            objWriter.WriteLine(ComboBox32.SelectedItem)
            objWriter.WriteLine(ComboBox30.SelectedItem)


            'Task 16

            objWriter.WriteLine(TextBox1.Text)
            objWriter.WriteLine(ComboBox16.SelectedItem)
            objWriter.WriteLine(ComboBox1.SelectedItem)


            'Task 17

            objWriter.WriteLine(TextBox15.Text)
            objWriter.WriteLine(ComboBox31.SelectedItem)
            objWriter.WriteLine(ComboBox29.SelectedItem)



            objWriter.Close()
            MessageBox.Show("Tasks Changed! Autobell is restarting...", "Success", _
                    MessageBoxButtons.OK)
            Application.Restart()
        End If
    End Sub

   
  
    Private Sub back_cmb_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles back_cmb.Click
        Me.Visible = False
        Form19.Visible = True
    End Sub


    Private Sub ComboBox9_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBox9.SelectedIndexChanged

    End Sub
End Class