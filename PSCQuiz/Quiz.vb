Imports System.IO

Public Class Quiz
    Dim SCORE As Integer = 0
    Dim val As Integer = 30
    Private Sub Quiz_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim TextFilePath As String = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Quiz.txt")


        ProgressBar1.Minimum = 0
        ProgressBar1.Maximum = 30
        Timer1.Enabled = True
        Using file As New System.IO.StreamReader(TextFilePath)

            Dim QUES As Integer = file.ReadLine()
            Label1.Text = file.ReadLine()
            RadioButton1.Text = file.ReadLine()
            RadioButton2.Text = file.ReadLine()
            RadioButton3.Text = file.ReadLine()
            RadioButton4.Text = file.ReadLine()
        End Using


    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        ProgressBar1.Value += 1
        Label2.Text = val & " Sec"
        val -= 1
        If ProgressBar1.Value = ProgressBar1.Maximum Then
            Timer1.Enabled = False
        End If
    End Sub

    Private Sub Quiz_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        Form1.Close()
    End Sub
End Class