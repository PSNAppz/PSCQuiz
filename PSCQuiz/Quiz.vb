﻿Imports System.IO
Imports System.Runtime.InteropServices

Public Class Quiz
    <DllImport("user32.dll", SetLastError:=True, CharSet:=CharSet.Auto)> _
    Private Shared Function SendMessage(ByVal hWnd As IntPtr, ByVal Msg As UInteger, ByVal wParam As Integer, ByVal lParam As Integer) As IntPtr
    End Function
    Dim SCORE As Integer = 0
    Dim val As Integer = 30
    Dim QUES As Integer = 0
    Dim Line As Integer = 1
    Dim allLines As List(Of String) = New List(Of String)
    Dim TextFilePath As String = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Quiz.txt")

    Private Sub Quiz_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ProgressBar1.Minimum = 0
        ProgressBar1.Maximum = 30
        Timer1.Enabled = True
        Next_Prev_Ques(Line + QUES)


    End Sub
    Public Function Next_Prev_Ques(quesno As Integer) As Integer
        Line = quesno
        Using file As New System.IO.StreamReader(TextFilePath)

            Do While Not file.EndOfStream
                allLines.Add(file.ReadLine())
            Loop

        End Using
        QUES = ReadLine(Line, allLines)
        Label1.Text = ReadLine(Line + 1, allLines)
        RadioButton1.Text = ReadLine(Line + 2, allLines)
        RadioButton2.Text = ReadLine(Line + 3, allLines)
        RadioButton3.Text = ReadLine(Line + 4, allLines)
        RadioButton4.Text = ReadLine(Line + 5, allLines)
        Return Line
    End Function
    Public Function ReadLine(lineNumber As Integer, lines As List(Of String)) As String
        Return lines(lineNumber - 1)
    End Function

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        ProgressBar1.Value += 1
        val -= 1
        Label2.Text = val & " Sec"
        If ProgressBar1.Value = ProgressBar1.Maximum Then
            Timer1.Enabled = False
        End If
        If ProgressBar1.Value > 25 Then
            SendMessage(ProgressBar1.Handle, 1040, 2, 0)
        End If
    End Sub

    Private Sub Quiz_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        Form1.Close()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        MsgBox(Line + QUES + 5)
        Next_Prev_Ques(Line + QUES + 4)
        Me.Refresh()

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Next_Prev_Ques(Line + QUES + 5)
    End Sub
End Class