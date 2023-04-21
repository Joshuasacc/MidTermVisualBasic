Public Class Payment

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        Me.Close()
    End Sub

    Private Sub Label4_Click(sender As Object, e As EventArgs) Handles Label4.Click
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Label4.Text = Main.Label3.Text
        Dim labelnigga As Int32
        labelnigga = CInt(Label4.Text)
    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        TextBox1.Text = ""
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim totalAmount As Int32
        Dim yourMoney As Int32

        Try
            totalAmount = CInt(Label4.Text)
            yourMoney = CInt(TextBox1.Text)

            If totalAmount <= yourMoney Then
                MessageBox.Show("Your change: " & yourMoney - totalAmount)
                MessageBox.Show("Thank You for trusting my P.O.S!")
                MessageBox.Show("I hope you like it!")
                Byebye.ShowDialog()

            Else
                MessageBox.Show("Insufficient")
                MessageBox.Show("Please try again")
            End If
        Catch ex As Exception
            MessageBox.Show("Please type numbers.")
        End Try

    End Sub
End Class