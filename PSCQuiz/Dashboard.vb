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
        Button7.Hide()
    End Sub

    Private Sub Panel2_Paint(sender As Object, e As PaintEventArgs) Handles Panel2.Paint

    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button7.Click
        AddQues.Show()
        Me.Hide()
    End Sub

    Private Sub Button6_Click_1(sender As Object, e As EventArgs) Handles Button6.Click
        Button7.Show()
    End Sub
End Class