Public Class AddQues
    Private listOfQuestions As List(Of Question) = New List(Of Question)
    Dim writer As New System.IO.StreamWriter("Quiz.txt", True)

    Dim key As Char
    Private Sub AddQues_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ComboBox1.Items.Add("Malayalam")
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If (Not (TextBox1.Text = "") Or Not (TextBox2.Text = "") Or Not (TextBox3.Text = "") Or (TextBox4.Text = "") Or Not (TextBox5.Text = "")) Then
            writer.WriteLine(TextBox1.Text)
            writer.WriteLine(TextBox2.Text)
            writer.WriteLine(TextBox3.Text)
            writer.WriteLine(TextBox4.Text)
            writer.WriteLine(TextBox5.Text)
            writer.WriteLine(key)
            writer.Close()
            Me.Close()
            Dashboard.Show()
        ElseIf (Not (RadioButton1.Checked) And Not (RadioButton2.Checked) And Not (RadioButton3.Checked) And Not (RadioButton4.Checked))
            MsgBox("Please Select an Answer Key")

        Else
            MsgBox("Please Enter all the fields")
        End If
    End Sub

    Private Sub RadioButton1_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton1.CheckedChanged
        key = "a"
    End Sub

    Private Sub RadioButton2_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton2.CheckedChanged
        key = "b"
    End Sub

    Private Sub RadioButton3_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton3.CheckedChanged
        key = "c"
    End Sub

    Private Sub RadioButton4_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton4.CheckedChanged
        key = "d"
    End Sub
End Class