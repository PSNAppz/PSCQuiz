Imports System.IO

Public Class Form1
    Dim spath As String = Path.GetFullPath(Application.StartupPath)
    Dim s As String = "C:\Users\User\documents\visual studio 2013\Projects\PSCQuiz\PSCQuiz\Quiz\Quiz.txt"
    Dim sr As New System.IO.StreamReader(s)
    Dim reader

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

       
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load



        If (Not System.IO.Directory.Exists(Path.Combine(spath, "\Quiz"))) Then
            System.IO.Directory.CreateDirectory(Path.Combine(spath, "Quiz"))
            If (Not System.IO.File.Exists(Path.Combine(spath, "\Quiz\Quiz.txt"))) Then
                System.IO.File.Create(Path.Combine(spath, "\Quiz\Quiz.txt"))
            End If
        End If

        Dim s As String = "C:\Users\User\documents\visual studio 2013\Projects\PSCQuiz\PSCQuiz\Quiz\Quiz.txt"
        MsgBox(spath)
        TextBox1.Text = sr.ReadLine()
    End Sub
End Class