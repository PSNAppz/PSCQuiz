Public Class SplashScreen
    Private Sub SplashScreen_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        ProgressBar1.Value = 0
        ProgressBar1.Maximum = 10
        ProgressBar1.Value += 1

    End Sub
End Class