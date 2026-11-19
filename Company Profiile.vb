Public Class Company_Profiile
    Private Sub btn_Overview_Click(sender As Object, e As EventArgs) Handles btn_Overview.Click
        Dashboard.Show()
        Me.Hide()
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Form1.Show()
        Me.Hide()
    End Sub

    Private Sub btnListing_Click(sender As Object, e As EventArgs) Handles btnListing.Click
        Manage_Listings.Show()
        Me.Show
    End Sub
End Class