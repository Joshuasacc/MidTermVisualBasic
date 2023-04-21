Public Class Byebye
    Private Sub Byebye_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub icedTea_Click(sender As Object, e As EventArgs) Handles icedTea.Click
        If MessageBox.Show("Are you sure you want to exit?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) = vbYes Then
            Application.Exit()
        End If
    End Sub

    Private Sub veggies_Click(sender As Object, e As EventArgs) Handles veggies.Click
        Me.Close()
    End Sub
End Class