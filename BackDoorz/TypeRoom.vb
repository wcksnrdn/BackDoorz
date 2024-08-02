Public Class TypeRoom


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
        Panel2.Visible = True
        Button7.Visible = True
        Button8.Visible = False
    End Sub

    Private Sub Button7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button7.Click
        Panel2.Visible = False
        Button7.Visible = False
        Button8.Visible = True

    End Sub

    Private Sub Button10_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button10.Click
        Panel3.Visible = True
        Button9.Visible = True
        Button10.Visible = False
    End Sub

    Private Sub Button9_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button9.Click
        Panel3.Visible = False
        Button10.Visible = True
        Button9.Visible = False
    End Sub
End Class