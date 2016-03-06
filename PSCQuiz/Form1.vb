Imports System.IO
Public Class Form1

    Dim spath As String = Path.GetFullPath(Application.StartupPath)

    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        Registeration.Show()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If ((TextBox2.Text = "demo") And Not (TextBox1.Text = "")) Then
            Me.Hide()
            Dashboard.Show()
        Else
            MsgBox("Please Enter a name and demo as password")
        End If
    End Sub

End Class

