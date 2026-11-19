
Imports System.Data
Imports System.Drawing

Public Class Manage_Listings

    Private listingsTable As DataTable
    Private listingsView As DataView

    '========================================
    ' FORM LOAD
    '========================================

    Private Sub Manage_Listings_Load(
        sender As Object,
        e As EventArgs
    ) Handles MyBase.Load

        listingsTable = User_dash.Listings

        EnsureAdminColumns()
        ConfigureFilters()
        ConfigureGrid()
        LoadListings()

    End Sub

    '========================================
    ' ENSURE ADMIN COLUMNS EXIST
    '========================================

    Private Sub EnsureAdminColumns()

        If listingsTable Is Nothing Then Return

        If Not listingsTable.Columns.Contains("AdminStatus") Then
            listingsTable.Columns.Add("AdminStatus", GetType(String))
        End If

        If Not listingsTable.Columns.Contains("AdminNote") Then
            listingsTable.Columns.Add("AdminNote", GetType(String))
        End If

        If Not listingsTable.Columns.Contains("ReviewedOn") Then
            listingsTable.Columns.Add("ReviewedOn", GetType(DateTime))
        End If

        For Each row As DataRow In listingsTable.Rows

            If row.RowState <> DataRowState.Deleted Then

                If IsDBNull(row("AdminStatus")) OrElse
                   String.IsNullOrWhiteSpace(Convert.ToString(row("AdminStatus"))) Then

                    row("AdminStatus") = "Pending Review"

                End If

                If IsDBNull(row("AdminNote")) Then
                    row("AdminNote") = ""
                End If

            End If

        Next

    End Sub

    '========================================
    ' CONFIGURE FILTERS
    '========================================

    Private Sub ConfigureFilters()

        cmbStatusFilter.Items.Clear()

        cmbStatusFilter.Items.Add("All")
        cmbStatusFilter.Items.Add("Pending Review")
        cmbStatusFilter.Items.Add("Approved")
        cmbStatusFilter.Items.Add("Rejected")
        cmbStatusFilter.Items.Add("Flagged")

        cmbStatusFilter.SelectedIndex = 0

        cmbPlasticFilter.Items.Clear()
        cmbPlasticFilter.Items.Add("All")

        For Each row As DataRow In listingsTable.Rows

            If row.RowState <> DataRowState.Deleted Then

                Dim plastic As String =
                    Convert.ToString(row("PlasticType"))

                If plastic <> "" AndAlso
                   Not cmbPlasticFilter.Items.Contains(plastic) Then

                    cmbPlasticFilter.Items.Add(plastic)

                End If

            End If

        Next

        cmbPlasticFilter.SelectedIndex = 0

    End Sub

    '========================================
    ' CONFIGURE GRID
    '========================================

    Private Sub ConfigureGrid()

        With dgvManageListings

            .AutoGenerateColumns = True
            .ReadOnly = True
            .AllowUserToAddRows = False
            .AllowUserToDeleteRows = False
            .SelectionMode = DataGridViewSelectionMode.FullRowSelect
            .MultiSelect = False
            .RowHeadersVisible = False
            .AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
            .BackgroundColor = Color.White
            .BorderStyle = BorderStyle.None
            .EnableHeadersVisualStyles = False

            .ColumnHeadersDefaultCellStyle.BackColor =
                Color.FromArgb(20, 83, 45)

            .ColumnHeadersDefaultCellStyle.ForeColor = Color.White

            .ColumnHeadersDefaultCellStyle.Font =
                New Font("Segoe UI", 9, FontStyle.Bold)

            .DefaultCellStyle.Font =
                New Font("Segoe UI", 9)

            .DefaultCellStyle.SelectionBackColor =
                Color.FromArgb(220, 252, 231)

            .DefaultCellStyle.SelectionForeColor = Color.Black

        End With

    End Sub

    '========================================
    ' LOAD LISTINGS
    '========================================

    Private Sub LoadListings()

        If listingsTable Is Nothing Then Return

        listingsView = New DataView(listingsTable)

        dgvManageListings.DataSource = listingsView

        StyleGrid()
        ApplyFilters()
        UpdateSummary()

    End Sub

    '========================================
    ' STYLE GRID
    '========================================

    Private Sub StyleGrid()

        If dgvManageListings.Columns.Count = 0 Then Return

        If dgvManageListings.Columns.Contains("ListingID") Then
            dgvManageListings.Columns("ListingID").HeaderText = "Listing ID"
        End If

        If dgvManageListings.Columns.Contains("PlasticType") Then
            dgvManageListings.Columns("PlasticType").HeaderText = "Plastic Type"
        End If

        If dgvManageListings.Columns.Contains("Quantity") Then
            dgvManageListings.Columns("Quantity").HeaderText = "Quantity (Kg)"
        End If

        If dgvManageListings.Columns.Contains("Area") Then
            dgvManageListings.Columns("Area").HeaderText = "Location"
        End If

        If dgvManageListings.Columns.Contains("PricePerKg") Then
            dgvManageListings.Columns("PricePerKg").HeaderText = "Price/Kg"
        End If

        If dgvManageListings.Columns.Contains("TotalPrice") Then
            dgvManageListings.Columns("TotalPrice").HeaderText = "Total Price"
        End If

        If dgvManageListings.Columns.Contains("DatePosted") Then
            dgvManageListings.Columns("DatePosted").HeaderText = "Date Posted"
        End If

        If dgvManageListings.Columns.Contains("Status") Then
            dgvManageListings.Columns("Status").HeaderText = "Listing Status"
        End If

        If dgvManageListings.Columns.Contains("AdminStatus") Then
            dgvManageListings.Columns("AdminStatus").HeaderText = "Admin Review"
        End If

        If dgvManageListings.Columns.Contains("Image1") Then
            dgvManageListings.Columns("Image1").Visible = False
        End If

        If dgvManageListings.Columns.Contains("Image2") Then
            dgvManageListings.Columns("Image2").Visible = False
        End If

        If dgvManageListings.Columns.Contains("Image3") Then
            dgvManageListings.Columns("Image3").Visible = False
        End If

        If dgvManageListings.Columns.Contains("AdminNote") Then
            dgvManageListings.Columns("AdminNote").Visible = False
        End If

        If dgvManageListings.Columns.Contains("ReviewedOn") Then
            dgvManageListings.Columns("ReviewedOn").Visible = False
        End If

    End Sub

    '========================================
    ' APPLY FILTERS AND SEARCH AS YOU TYPE
    '========================================

    Private Sub ApplyFilters()

        If listingsView Is Nothing Then Return

        Dim filters As New List(Of String)

        If cmbStatusFilter.Text <> "" AndAlso
           cmbStatusFilter.Text <> "All" Then

            filters.Add(
                "AdminStatus = '" &
                EscapeSearchValue(cmbStatusFilter.Text) & "'"
            )

        End If

        If cmbPlasticFilter.Text <> "" AndAlso
           cmbPlasticFilter.Text <> "All" Then

            filters.Add(
                "PlasticType = '" &
                EscapeSearchValue(cmbPlasticFilter.Text) & "'"
            )

        End If

        Dim searchText As String = txtSearch.Text.Trim()

        If searchText <> "" Then

            Dim safeSearch As String =
                EscapeSearchValue(searchText)

            Dim searchFilters As New List(Of String)

            searchFilters.Add(
                "Convert(ListingID, 'System.String') LIKE '%" &
                safeSearch & "%'"
            )

            searchFilters.Add(
                "PlasticType LIKE '%" & safeSearch & "%'"
            )

            searchFilters.Add(
                "Area LIKE '%" & safeSearch & "%'"
            )

            searchFilters.Add(
                "Status LIKE '%" & safeSearch & "%'"
            )

            searchFilters.Add(
                "AdminStatus LIKE '%" & safeSearch & "%'"
            )

            searchFilters.Add(
                "AdminNote LIKE '%" & safeSearch & "%'"
            )

            filters.Add("(" & String.Join(" OR ", searchFilters) & ")")

        End If

        listingsView.RowFilter = String.Join(" AND ", filters)

        UpdateSummary()

    End Sub

    Private Function EscapeSearchValue(value As String) As String

        Return value.Replace("'", "''").
                     Replace("[", "[[]").
                     Replace("%", "[%]").
                     Replace("*", "[*]")

    End Function

    Private Sub txtSearch_TextChanged(
        sender As Object,
        e As EventArgs
    ) Handles txtSearch.TextChanged

        ApplyFilters()

    End Sub

    Private Sub cmbStatusFilter_SelectedIndexChanged(
        sender As Object,
        e As EventArgs
    ) Handles cmbStatusFilter.SelectedIndexChanged

        ApplyFilters()

    End Sub

    Private Sub cmbPlasticFilter_SelectedIndexChanged(
        sender As Object,
        e As EventArgs
    ) Handles cmbPlasticFilter.SelectedIndexChanged

        ApplyFilters()

    End Sub

    '========================================
    ' UPDATE SUMMARY
    '========================================

    Private Sub UpdateSummary()

        Dim total As Integer = 0
        Dim pending As Integer = 0
        Dim approved As Integer = 0

        If listingsTable Is Nothing Then Return

        For Each row As DataRow In listingsTable.Rows

            If row.RowState = DataRowState.Deleted Then Continue For

            total += 1

            Dim reviewStatus As String =
                Convert.ToString(row("AdminStatus"))

            If reviewStatus = "Pending Review" Then
                pending += 1

            ElseIf reviewStatus = "Approved" Then
                approved += 1

            End If

        Next

        lblTotalListings.Text = total.ToString()
        lblPending.Text = pending.ToString()
        lblApproved.Text = approved.ToString()

    End Sub

    '========================================
    ' GET SELECTED LISTING
    '========================================

    Private Function GetSelectedListing() As DataRow

        If dgvManageListings.CurrentRow Is Nothing Then
            Return Nothing
        End If

        Dim selectedView As DataRowView =
            TryCast(
                dgvManageListings.CurrentRow.DataBoundItem,
                DataRowView
            )

        If selectedView Is Nothing Then Return Nothing

        If selectedView.Row Is Nothing Then Return Nothing

        If selectedView.Row.RowState = DataRowState.Deleted Then
            Return Nothing
        End If

        Return selectedView.Row

    End Function

    '========================================
    ' APPROVE LISTING
    '========================================

    Private Sub btnApprove_Click(
        sender As Object,
        e As EventArgs
    ) Handles btnApprove.Click

        Dim listing As DataRow = GetSelectedListing()

        If listing Is Nothing Then
            MessageBox.Show("Please select a listing first.")
            Return
        End If

        listing("AdminStatus") = "Approved"
        listing("AdminNote") = "Listing approved."
        listing("ReviewedOn") = DateTime.Now

        LoadListings()

        MessageBox.Show("Listing approved successfully.")

    End Sub

    '========================================
    ' REJECT LISTING
    '========================================

    Private Sub btnReject_Click(
        sender As Object,
        e As EventArgs
    ) Handles btnReject.Click

        Dim listing As DataRow = GetSelectedListing()

        If listing Is Nothing Then
            MessageBox.Show("Please select a listing first.")
            Return
        End If

        listing("AdminStatus") = "Rejected"
        listing("AdminNote") = "Listing rejected."
        listing("ReviewedOn") = DateTime.Now

        LoadListings()

        MessageBox.Show("Listing rejected.")

    End Sub

    '========================================
    ' FLAG LISTING
    '========================================

    Private Sub btnFlag_Click(
        sender As Object,
        e As EventArgs
    ) Handles btnFlag.Click

        Dim listing As DataRow = GetSelectedListing()

        If listing Is Nothing Then
            MessageBox.Show("Please select a listing first.")
            Return
        End If

        listing("AdminStatus") = "Flagged"
        listing("AdminNote") = "Listing flagged for further review."
        listing("ReviewedOn") = DateTime.Now

        LoadListings()

        MessageBox.Show("Listing flagged successfully.")

    End Sub

    '========================================
    ' REMOVE LISTING
    '========================================

    Private Sub btnRemove_Click(
        sender As Object,
        e As EventArgs
    ) Handles btnRemove.Click

        Dim listing As DataRow = GetSelectedListing()

        If listing Is Nothing Then
            MessageBox.Show("Please select a listing first.")
            Return
        End If

        Dim answer As DialogResult =
            MessageBox.Show(
                "Are you sure you want to remove this listing?",
                "Confirm Removal",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning
            )

        If answer = DialogResult.Yes Then

            listing.Delete()
            LoadListings()

            MessageBox.Show("Listing removed successfully.")

        End If

    End Sub

    '========================================
    ' VIEW SELECTED LISTING IMAGES
    '========================================

    Private Sub btnViewImages_Click(
        sender As Object,
        e As EventArgs
    ) Handles btnViewImages.Click

        Dim listing As DataRow = GetSelectedListing()

        If listing Is Nothing Then

            MessageBox.Show("Please select a listing first.")
            Return

        End If

        ' Pass the shared listings table to the image form
        Listing_Images.LoadListings(listingsTable)

        ' Open the existing image form
        Listing_Images.Show(Me)

        ' Pass the selected listing after the form has loaded
        Listing_Images.LoadSelectedListing(listing)

        Listing_Images.BringToFront()

    End Sub

    '========================================
    ' REFRESH
    '========================================

    Private Sub btnRefresh_Click(
        sender As Object,
        e As EventArgs
    ) Handles btnRefresh.Click

        listingsTable = User_dash.Listings

        EnsureAdminColumns()
        ConfigureFilters()

        txtSearch.Clear()

        LoadListings()

    End Sub

    '========================================
    ' BACK TO DASHBOARD
    '========================================

    Private Sub btnBack_Click(
        sender As Object,
        e As EventArgs
    ) Handles btnBack.Click

        Dashboard.Show()
        Dashboard.BringToFront()

        Me.Hide()

    End Sub

End Class
