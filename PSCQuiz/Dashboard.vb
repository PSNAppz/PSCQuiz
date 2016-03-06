Public Class Dashboard
    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Form1.Close()
        Me.Close()
    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Hide()
        Quiz.Reset_all()
        Quiz.Show()
    End Sub

    Private Sub Dashboard_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Label2.Text = "Hello, " & My.Settings.User
        Label4.Text += " " + Form1.TextBox1.Text
        Button7.Hide()
        Button4.Hide()
    End Sub
    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        AddQues.Show()
        Me.Hide()
    End Sub

    Private Sub Button6_Click_1(sender As Object, e As EventArgs) Handles Button6.Click
        Button7.Show()
        Button4.Show()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        MsgBox("Not supported in Demo Version")
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        MsgBox("Scoreboard features are not supported in Demo Version")

    End Sub

End Class