Public Class BackDoorz
    Dim counter As Integer = 1

    Private Sub BackDoorz_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Timer1.Interval = 50
        Timer1.Start()
    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        If PictureBox1.Left > 0 - PictureBox1.Width Then
            PictureBox1.Left -= 1
        Else : PictureBox1.Left = Me.ClientSize.Width
        End If
        If PictureBox2.Left > 0 - PictureBox2.Width Then
            PictureBox2.Left -= 1
        Else : PictureBox2.Left = Me.ClientSize.Width
        End If
        If PictureBox3.Left > 0 - PictureBox3.Width Then
            PictureBox3.Left -= 1
        Else : PictureBox3.Left = Me.ClientSize.Width
        End If
    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        Panel1.Visible = True
        Button6.Visible = True
        Button5.Visible = False
    End Sub

    Private Sub Button6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button6.Click
        Panel1.Visible = False
        Button6.Visible = False
        Button5.Visible = True

    End Sub

    Private Sub Button8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button8.Click
        TypeRoom.ShowDialog()
    End Sub

    Private Sub Button9_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button9.Click
        Book_A_Room.ShowDialog()
    End Sub
End Class