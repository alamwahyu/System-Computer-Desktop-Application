Public Class FormLogin
    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged
        If CheckBox1.Checked Then
            tb_pass.UseSystemPasswordChar = False
        Else
            tb_pass.UseSystemPasswordChar = True
        End If

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If tb_username.Text = "admin" And tb_pass.Text = "admin" Then
            MessageBox.Show("PASSWORD ANDA TEPAT SEKALI")
            Me.Hide()
            FormMenuMaster.Show()

        Else
            MessageBox.Show("PASSWORD ANDA SALAH")
            kosongtext()
        End If
    End Sub

    Private Sub kosongtext()
        tb_username.Clear()
        tb_pass.Clear()
    End Sub
End Class
