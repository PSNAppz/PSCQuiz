Public Class Registeration

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If (Not (TextBox1.Text = "") And Not (TextBox2.Text = "")) Then
            My.Settings.User = TextBox1.Text
            My.Settings.Pass = TextBox2.Text
            If (TextBox3.Text = "") Then
                My.Settings.Save()
                MsgBox("Registered Succesfully")
                Me.Close()
            End If
        End If

    End Sub
End Class
