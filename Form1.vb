Public Class Form1

    Private Sub Form1_Load(
    sender As Object,
    e As EventArgs
) Handles MyBase.Load

        If DatabaseConnection.TestConnection() Then

            MessageBox.Show(
            "Plasticash connected to PostgreSQL successfully!",
            "Connection Successful",
            MessageBoxButtons.OK,
            MessageBoxIcon.Information
        )

        End If

    End Sub




    Private Sub btnlogin_Click(sender As Object, e As EventArgs) Handles btnlogin.Click
        'Check username
        If txtname.Text.Trim() = "" Then
            MessageBox.Show("Please enter your username")
            txtname.Focus()
            Exit Sub
        End If

        'Check password
        If txtpass.Text.Trim() = "" Then
            MessageBox.Show("Please enter your password")
            txtpass.Focus()
            Exit Sub
        End If

        'Check login details
        If txtname.Text = "User1" And txtpass.Text = "password" Then


            User_dash.Show()
            Me.Hide()


        ElseIf txtname.Text = "Admin" And txtpass.Text = "password" Then

            Dashboard.Show()
            Me.Hide()

        Else

            MessageBox.Show("Invalid username or password. Please try again.",
                        "Login Failed",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error)

            txtpass.Clear()
            txtpass.Focus()

        End If



    End Sub

    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        Create_account.Show()
        Me.Hide()
    End Sub

End Class
