Public Class Condition
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        'Yes button
        Application.Exit()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        'No button
        Me.Close()
    End Sub
End Class