Imports System.IO
Imports System.Runtime.InteropServices

Public Class Quiz
    Public ques As Integer = 1
    Dim numbers(100) As Integer 'Added an array to store the viewed question index
    Dim i As Integer = 0

    Dim r As New Random
    Dim Shuffle As Integer = 0
    Public SCORE As Integer = 0
    Dim val As Integer = 30
    Public anskey As String
    Private currentQuestion As Integer
    Private listOfQuestions As List(Of Question) = New List(Of Question)
    <DllImport("user32.dll", SetLastError:=True, CharSet:=CharSet.Auto)>
    Private Shared Function SendMessage(ByVal hWnd As IntPtr, ByVal Msg As UInteger, ByVal wParam As Integer, ByVal lParam As Integer) As IntPtr
    End Function
    Public Sub Reset_all()
        val = 30
        SCORE = 0
        ProgressBar1.Value = 0
        Button3.Hide()
        ProgressBar1.Minimum = 0
        ProgressBar1.Maximum = 30
        Timer1.Enabled = True
        Using reader = New System.IO.StreamReader("Quiz.txt")
            Dim line = reader.ReadLine()
            While (Not String.IsNullOrWhiteSpace(line))
                Dim question = New Question
                question.Question = line
                question.Choice1 = reader.ReadLine()
                question.Choice2 = reader.ReadLine()
                question.Choice3 = reader.ReadLine()
                question.Choice4 = reader.ReadLine()
                question.Answer = reader.ReadLine()
                listOfQuestions.Add(question)
                line = reader.ReadLine()
            End While
        End Using

        If listOfQuestions.Count > 0 Then
            LoadQuestion(0)
            i = 0
        End If
    End Sub

    Private Sub Form1_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Reset_all()
    End Sub

    Sub LoadQuestion(questionIndex As Integer)

        Dim question = listOfQuestions(questionIndex)
        currentQuestion = questionIndex
        If listOfQuestions.Count - 1 = currentQuestion Then

        End If
        With question
            Label3.Text = ques
            Label1.Text = .Question
            RadioButton1.Text = .Choice1
            RadioButton2.Text = .Choice2
            RadioButton3.Text = .Choice3
            RadioButton4.Text = .Choice4
            anskey = .Answer
        End With
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If (SCORE > 0) Then
            SCORE -= 1
        End If
        If (currentQuestion > 0) Then
            If (ques > 1) Then
                i -= 1
                numbers(0) = 0
                ques -= 1
                LoadQuestion(numbers(i))
            End If
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim a As Integer = r.Next(0, listOfQuestions.Count - 1)
        Shuffle = a
        MsgBox(RadioButton1.Checked.ToString)
        MsgBox(anskey)
        If (anskey = "1" And RadioButton1.Checked = True Or anskey = "2" And RadioButton2.Checked = True Or anskey = "3" And RadioButton3.Checked = True Or anskey = "4" And RadioButton4.Checked = True) Then
            SCORE += 1
            MsgBox(RadioButton1.Checked.ToString)
        End If

        If (currentQuestion < listOfQuestions.Count - 1) Then
            If (ques <= 99) Then
                i += 1
                numbers(i) = Shuffle
                ques += 1
                LoadQuestion(numbers(i))
            End If
        End If
    End Sub
    Private Sub Quiz_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        Dashboard.Show()
        Me.Hide()
    End Sub
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        ProgressBar1.Value += 1
        val -= 1
        Label2.Text = val & " Sec"
        If ProgressBar1.Value = ProgressBar1.Maximum Then
            Timer1.Enabled = False

        End If
        If ProgressBar1.Value > 23 Then
            SendMessage(ProgressBar1.Handle, 1040, 2, 0)
            Button3.Show()

        End If
        If ProgressBar1.Value = 30 Then

        End If
    End Sub

    Private Sub SubmitResult()
        MsgBox("You have Scored " + SCORE.ToString + " Out of 100")
    End Sub
    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim Re As Integer = MsgBox("Are you sure you want to submit?",
    vbYesNo, "Submit")
        If (Re = 6) Then
            SubmitResult()
            Try
                Dashboard.DashBoard_Update()
                Me.Close()
                Dashboard.Show()
            Catch ex As Exception
            End Try
        End If
    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub
End Class
Public Class Question

    Public Property Question As String
    Public Property Choice1 As String
    Public Property Choice2 As String
    Public Property Choice3 As String
    Public Property Choice4 As String
    Public Property Answer As String

End Class
