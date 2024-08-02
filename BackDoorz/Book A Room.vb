Public Class Book_A_Room
    Sub isicombo1()
        With Me
            ComboBox1.Items.Add("First Class (VVIP)")
            ComboBox1.Items.Add("Second Class (Deluxe)")
            ComboBox1.Items.Add("Third Class (Basic)")
        End With
    End Sub

    Private Sub Book_A_Room_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Call isicombo1()
    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        If IsNumeric(TextBox4.Text) Then
            Dim currentnumber As Integer = Convert.ToInt32(TextBox4.Text)
            currentnumber -= 1
            TextBox4.Text = currentnumber.ToString()
        Else
            TextBox4.Text = "-1"
        End If
    End Sub

    Private Sub Button6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button6.Click
        If IsNumeric(TextBox4.Text) Then
            Dim currentnumber As Integer = Convert.ToInt32(TextBox4.Text)
            currentnumber += 1
            TextBox4.Text = currentnumber.ToString()
        Else
            TextBox4.Text = "1"
        End If
    End Sub

    Private Sub TextBox4_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox4.TextChanged
        TextBox4.TextAlign = HorizontalAlignment.Center
    End Sub

    Private Sub Button7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button7.Click
        If Me.TextBox1.Text = "" Then
            MsgBox("Your first name must be filled in", MsgBoxStyle.Exclamation, "BackDoorz")
        End If
        If Me.TextBox2.Text = "" Then
            MsgBox("Your last name must be filled in", MsgBoxStyle.Exclamation, "BackDoorz")
        End If
        If Me.TextBox3.Text = "" Then
            MsgBox("Your E-mail must be filled in", MsgBoxStyle.Exclamation, "BackDoorz")
        End If
        If Me.TextBox4.Text = "" Then
            MsgBox("Number Of Guests must be filled in", MsgBoxStyle.Exclamation, "BackDoorz")
        End If
        If Me.TextBox5.Text = "" Then
            MsgBox("Your Phone Number must be filled in", MsgBoxStyle.Exclamation, "BackDoorz")
        End If
        If Me.ComboBox1.Text = "" Then
            MsgBox("The Room Type must be filled in", MsgBoxStyle.Exclamation, "BackDoorz")
        Else
            Button7.Enabled = False
            MsgBox("Your Booking being Proccesed", MsgBoxStyle.Information, "BackDoorz")
        End If
        Me.Close()
    End Sub
End Class