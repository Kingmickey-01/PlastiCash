Public Class Create_account
    Private Sub Create_account_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub


    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        company_account.Show()
        Me.Hide()
    End Sub

    Private Sub btnlogin_Click(sender As Object, e As EventArgs) Handles btnlogin.Click
        ' Check full name
        If txtname.Text.Trim() = "" Then
            MessageBox.Show("Please enter your full name")
            txtname.Focus()
            Exit Sub
        End If

        ' Check email
        If txtEmail.Text.Trim() = "" Then
            MessageBox.Show("Please enter your email address")
            txtEmail.Focus()
            Exit Sub
        End If

        ' Check phone
        If txtphone.Text.Trim() = "" Then
            MessageBox.Show("Please enter your phone number")
            txtphone.Focus()
            Exit Sub
        End If

        ' Check password
        If txtpass.Text.Trim() = "" Then
            MessageBox.Show("Please enter your password")
            txtpass.Focus()
            Exit Sub
        End If

    End Sub

    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        Form1.Show()
        Me.Hide()
    End Sub
End Class