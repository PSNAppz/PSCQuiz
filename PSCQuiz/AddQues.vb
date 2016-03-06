Imports System
Imports System.IO
Public Class AddQues
    Public writer As System.IO.StreamWriter = File.AppendText("Quiz.txt")

    Dim key As Char
    Private Sub AddQues_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ComboBox1.Items.Add("Malayalam")
        ComboBox1.Items.Add("English")
        ComboBox1.SelectedValue = "English"
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If (ComboBox1.SelectedItem = "Malayalam") Then
            MsgBox("Malayalam Not Available in Demo Version")
        End If
        If ((TextBox1.Text = "") Or (TextBox2.Text = "") Or (TextBox3.Text = "") Or (TextBox4.Text = "") Or (TextBox5.Text = "")) Then

            MsgBox("Please Enter all the fields")

        ElseIf (Not (RadioButton1.Checked) And Not (RadioButton2.Checked) And Not (RadioButton3.Checked) And Not (RadioButton4.Checked))
            MsgBox("Please Select an Answer Key")

        Else
            Try
                writer.WriteLine()
                writer.WriteLine(TextBox1.Text)
                writer.WriteLine(TextBox2.Text)
                writer.WriteLine(TextBox3.Text)
                writer.WriteLine(TextBox4.Text)
                writer.WriteLine(TextBox5.Text)
                writer.WriteLine(key)
                writer.Close()
                Me.Close()
                Dashboard.Show()
            Catch ex As Exception
            End Try
        End If
    End Sub

    Private Sub RadioButton1_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton1.CheckedChanged
        key = "1"
    End Sub

    Private Sub RadioButton2_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton2.CheckedChanged
        key = "2"
    End Sub

    Private Sub RadioButton3_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton3.CheckedChanged
        key = "3"
    End Sub

    Private Sub RadioButton4_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton4.CheckedChanged
        key = "4"
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Close()
        Dashboard.Show()
    End Sub
End Class