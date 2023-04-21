Public Class Main
    Private subTotal As Int32
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Welcome.ShowDialog()
    End Sub

    Private Sub Button10_Click(sender As Object, e As EventArgs) Handles Button10.Click
        Condition.ShowDialog()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles coke.Click
        'Coke
        Dim coke As Int32
        Dim cokeStr As String

        coke = 25
        cokeStr = "Coke"
        listBox.Items.Add("")
        listBox.Items.Add(cokeStr)
        listBox.Items.Add("________________________________________________________________")
        Label5.Text = "Coke"
        Label7.Text = "25"
        subTotal += 25
    End Sub

    Private Sub icedTea_Click(sender As Object, e As EventArgs) Handles icedTea.Click
        ' Ice Tea
        Dim icedTea As Int32
        Dim icedTeaStr As String

        icedTea = 30
        icedTeaStr = "Ice Tea"
        listBox.Items.Add("")
        listBox.Items.Add(icedTeaStr)
        listBox.Items.Add("________________________________________________________________")
        Label5.Text = "Ice Tea"
        Label7.Text = "30"
        subTotal += 30
    End Sub

    Private Sub chicken_Click(sender As Object, e As EventArgs) Handles chicken.Click
        'Chicken
        Dim chicken As Int32
        Dim chickenStr As String

        chicken = 85
        chickenStr = "Chicken"
        listBox.Items.Add("")
        listBox.Items.Add(chickenStr)
        listBox.Items.Add("________________________________________________________________")
        Label5.Text = "Chicken"
        Label7.Text = "85"
        subTotal += 85
    End Sub

    Private Sub veggies_Click(sender As Object, e As EventArgs) Handles veggies.Click
        'Veggies
        Dim veggies As Int32
        Dim veggiesStr As String

        veggies = 45
        veggiesStr = "Veggies"
        listBox.Items.Add("")
        listBox.Items.Add(veggiesStr)
        listBox.Items.Add("________________________________________________________________")
        Label5.Text = "Veggies"
        Label7.Text = "45"
        subTotal += 45
    End Sub

    Private Sub pork_Click(sender As Object, e As EventArgs) Handles pork.Click
        'Pork
        Dim pork As Int32
        Dim porkStr As String

        pork = 85
        porkStr = "Pork"
        listBox.Items.Add("")
        listBox.Items.Add(porkStr)
        listBox.Items.Add("________________________________________________________________")
        Label5.Text = "Pork"
        Label7.Text = "85"
        subTotal += 85
    End Sub

    Private Sub sundae_Click(sender As Object, e As EventArgs) Handles sundae.Click
        'Sundae
        Dim sundae As Int32
        Dim sundaeStr As String

        sundae = 35
        sundaeStr = "Sundae"
        listBox.Items.Add("")
        listBox.Items.Add(sundaeStr)
        listBox.Items.Add("________________________________________________________________")
        Label5.Text = "Sundae"
        Label7.Text = "35"
        subTotal += 35
    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        'Clear button
        listBox.Items.Clear()
        listBox.Items.Add("________________________________________________________________")
        Label7.Text = "Sample Item"
        Label5.Text = "Sample Item"
        subTotal = 0
        Label3.Text = "00"

    End Sub

    Private Sub Label5_Click(sender As Object, e As EventArgs) Handles Label5.Click
    End Sub

    Private Sub Label7_Click(sender As Object, e As EventArgs) Handles Label7.Click
    End Sub

    Private Sub listBox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles listBox.SelectedIndexChanged
        'List Box
    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        ' Add button
        Try ' i use try catch function to handle errors if user input a letter in text box or etc..
            Label3.Text = subTotal * CInt(TextBox1.Text)
            If (Label3.Text = 0) Then
                Label3.Text = "00"
                MessageBox.Show("Please complete your order." & vbNewLine & vbNewLine & "Keep in mind that making mistakes is okay." & vbNewLine & "You've got this!")

                Label3.Text = "00"
            End If 'pogi ni sir
        Catch ex As Exception
            MessageBox.Show("Please complete your order." & vbNewLine & vbNewLine & "Keep in mind that making mistakes is okay." & vbNewLine & "You've got this!")
        End Try

    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged
        'Text Box

    End Sub

    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9.Click
        ' Payment button
        Payment.ShowDialog()
    End Sub
End Class
