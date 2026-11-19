
Imports System.Data
Imports System.Drawing

Public Class My_listings

    '========================================
    ' SHARED LISTINGS DATA
    '========================================

    Private listingTable As DataTable
    Private listingView As DataView
    Private editingListingID As Integer = -1

    Private ReadOnly listingStatuses As String() = {
        "Available",
        "Reserved",
        "Collected",
        "Cancelled"
    }


    '========================================
    ' RECEIVE SHARED LISTINGS
    '========================================

    Public Sub LoadListings(data As DataTable)

        If data Is Nothing Then

            MessageBox.Show("No listing information was received.",
                            "Plasticash",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Warning)

            Return

        End If

        listingTable = data
        listingView = New DataView(listingTable)

        ExitEditMode()

        dgvListings.DataSource = listingView

        ConfigureDataGridView()
        ConfigureStatusControls()

        txtSearch.Clear()

        If dgvListings.Rows.Count > 0 Then

            dgvListings.ClearSelection()
            dgvListings.Rows(0).Selected = True
            dgvListings.CurrentCell = dgvListings.Rows(0).Cells("ListingID")

            DisplayListingDetails()

        Else

            ClearListingDetails()

        End If

    End Sub


    '========================================
    ' FORM LOAD
    '========================================

    Private Sub My_listings_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        ConfigureDataGridView()
        ConfigureStatusControls()

        ExitEditMode()
        ClearListingDetails()

    End Sub


    '========================================
    ' CONFIGURE STATUS CONTROLS
    '========================================

    Private Sub ConfigureStatusControls()

        cmbListingStatus.Items.Clear()

        cmbListingStatus.Items.AddRange(listingStatuses)

        cmbListingStatus.DropDownStyle =
            ComboBoxStyle.DropDownList

        cmbListingStatus.SelectedIndex = -1

        btnUpdateStatus.Enabled = False
        cmbListingStatus.Enabled = False

    End Sub


    '========================================
    ' CONFIGURE DATA GRID
    '========================================

    Private Sub ConfigureDataGridView()

        With dgvListings

            .ReadOnly = True
            .AllowUserToAddRows = False
            .AllowUserToDeleteRows = False

            .SelectionMode =
                DataGridViewSelectionMode.FullRowSelect

            .MultiSelect = False

            .AutoSizeColumnsMode =
                DataGridViewAutoSizeColumnsMode.Fill

            .RowHeadersVisible = False

            .EnableHeadersVisualStyles = False

            .ColumnHeadersDefaultCellStyle.BackColor =
                Color.DarkGreen

            .ColumnHeadersDefaultCellStyle.ForeColor =
                Color.White

            .ColumnHeadersDefaultCellStyle.Font =
                New Font("Segoe UI", 9, FontStyle.Bold)

            .DefaultCellStyle.Font =
                New Font("Segoe UI", 9, FontStyle.Regular)

            .AlternatingRowsDefaultCellStyle.BackColor =
                Color.FromArgb(240, 248, 240)

        End With


        If dgvListings.Columns.Contains("ListingID") Then
            dgvListings.Columns("ListingID").HeaderText = "Listing ID"
        End If

        If dgvListings.Columns.Contains("PlasticType") Then
            dgvListings.Columns("PlasticType").HeaderText = "Plastic Type"
        End If

        If dgvListings.Columns.Contains("Quantity") Then
            dgvListings.Columns("Quantity").HeaderText = "Quantity (kg)"
        End If

        If dgvListings.Columns.Contains("Area") Then
            dgvListings.Columns("Area").HeaderText = "Collection Area"
        End If

        If dgvListings.Columns.Contains("PricePerKg") Then
            dgvListings.Columns("PricePerKg").HeaderText = "Price per kg (GH₵)"
        End If

        If dgvListings.Columns.Contains("TotalPrice") Then
            dgvListings.Columns("TotalPrice").HeaderText = "Total Asking Price (GH₵)"
        End If

        If dgvListings.Columns.Contains("DatePosted") Then
            dgvListings.Columns("DatePosted").HeaderText = "Date Posted"
        End If

        If dgvListings.Columns.Contains("Status") Then
            dgvListings.Columns("Status").HeaderText = "Listing Status"
        End If


        ' Hide image storage columns

        If dgvListings.Columns.Contains("Image1") Then
            dgvListings.Columns("Image1").Visible = False
        End If

        If dgvListings.Columns.Contains("Image2") Then
            dgvListings.Columns("Image2").Visible = False
        End If

        If dgvListings.Columns.Contains("Image3") Then
            dgvListings.Columns("Image3").Visible = False
        End If

    End Sub


    '========================================
    ' SEARCH LISTINGS
    '========================================

    Private Sub txtSearch_TextChanged(
        sender As Object,
        e As EventArgs
    ) Handles txtSearch.TextChanged

        If listingView Is Nothing Then Return
        If editingListingID <> -1 Then Return

        Dim searchText As String = txtSearch.Text.Trim()

        If searchText = "" Then

            listingView.RowFilter = ""

        Else

            Dim safeSearch As String =
                searchText.Replace("'", "''").
                Replace("[", "[[]").
                Replace("%", "[%]").
                Replace("*", "[*]")

            listingView.RowFilter =
                "Convert(ListingID, 'System.String') LIKE '%" & safeSearch & "%'" &
                " OR PlasticType LIKE '%" & safeSearch & "%'" &
                " OR Area LIKE '%" & safeSearch & "%'" &
                " OR Status LIKE '%" & safeSearch & "%'"

        End If

        If dgvListings.Rows.Count > 0 Then

            dgvListings.ClearSelection()
            dgvListings.Rows(0).Selected = True
            dgvListings.CurrentCell = dgvListings.Rows(0).Cells("ListingID")

            DisplayListingDetails()

        Else

            ClearListingDetails()

        End If

    End Sub


    '========================================
    ' CLEAR SEARCH
    '========================================

    Private Sub btnClearSearch_Click(
        sender As Object,
        e As EventArgs
    ) Handles btnClearSearch.Click

        txtSearch.Clear()

        If listingView IsNot Nothing Then
            listingView.RowFilter = ""
        End If

        If dgvListings.Rows.Count > 0 Then

            dgvListings.ClearSelection()
            dgvListings.Rows(0).Selected = True
            dgvListings.CurrentCell = dgvListings.Rows(0).Cells("ListingID")

            DisplayListingDetails()

        Else

            ClearListingDetails()

        End If

        txtSearch.Focus()

    End Sub


    '========================================
    ' DISPLAY SELECTED LISTING
    '========================================

    Private Sub dgvListings_SelectionChanged(
        sender As Object,
        e As EventArgs
    ) Handles dgvListings.SelectionChanged

        If editingListingID <> -1 Then Return

        DisplayListingDetails()

    End Sub


    Private Sub DisplayListingDetails()

        If dgvListings.CurrentRow Is Nothing OrElse
           dgvListings.CurrentRow.IsNewRow Then

            ClearListingDetails()
            Return

        End If

        Dim row As DataGridViewRow = dgvListings.CurrentRow

        If row.Cells("ListingID").Value Is Nothing Then

            ClearListingDetails()
            Return

        End If

        lblDetailID.Text =
            row.Cells("ListingID").Value.ToString()

        lblDetailPlasticType.Text =
            row.Cells("PlasticType").Value.ToString()

        lblDetailQuantity.Text =
            Convert.ToDecimal(row.Cells("Quantity").Value).ToString("0.##") & " kg"

        lblDetailArea.Text =
            row.Cells("Area").Value.ToString()

        lblDetailPrice.Text =
            "GH₵ " & Convert.ToDecimal(row.Cells("PricePerKg").Value).ToString("N2")

        lblDetailTotal.Text =
            "GH₵ " & Convert.ToDecimal(row.Cells("TotalPrice").Value).ToString("N2")

        lblDetailDate.Text =
            Convert.ToDateTime(row.Cells("DatePosted").Value).ToString("dd MMM yyyy")

        Dim currentStatus As String =
            row.Cells("Status").Value.ToString()

        lblDetailStatus.Text = currentStatus

        cmbListingStatus.SelectedItem = currentStatus

        cmbListingStatus.Enabled = True
        btnUpdateStatus.Enabled = True

    End Sub


    '========================================
    ' CLEAR DETAILS
    '========================================

    Private Sub ClearListingDetails()

        lblDetailID.Text = "-"
        lblDetailPlasticType.Text = "-"
        lblDetailQuantity.Text = "-"
        lblDetailArea.Text = "-"
        lblDetailPrice.Text = "-"
        lblDetailTotal.Text = "-"
        lblDetailDate.Text = "-"
        lblDetailStatus.Text = "-"

        cmbListingStatus.SelectedIndex = -1

        cmbListingStatus.Enabled = False
        btnUpdateStatus.Enabled = False

    End Sub


    '========================================
    ' UPDATE LISTING STATUS
    '========================================

    Private Sub btnUpdateStatus_Click(
        sender As Object,
        e As EventArgs
    ) Handles btnUpdateStatus.Click

        If listingTable Is Nothing OrElse
           dgvListings.CurrentRow Is Nothing OrElse
           dgvListings.CurrentRow.IsNewRow Then

            MessageBox.Show("Please select a listing first.",
                            "Plasticash",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Warning)

            Return

        End If

        If cmbListingStatus.SelectedIndex = -1 Then

            MessageBox.Show("Please select a listing status.",
                            "Plasticash",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Warning)

            cmbListingStatus.Focus()
            Return

        End If

        Dim selectedID As Integer =
            Convert.ToInt32(dgvListings.CurrentRow.Cells("ListingID").Value)

        Dim newStatus As String =
            cmbListingStatus.SelectedItem.ToString()

        Dim foundRows() As DataRow =
            listingTable.Select("ListingID = " & selectedID)

        If foundRows.Length = 0 Then

            MessageBox.Show("The selected listing could not be found.")
            Return

        End If

        Dim selectedListing As DataRow = foundRows(0)

        Dim oldStatus As String =
            selectedListing("Status").ToString()

        If oldStatus = newStatus Then

            MessageBox.Show("This listing already has the selected status.",
                            "Plasticash",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Information)

            Return

        End If

        Dim result As DialogResult =
            MessageBox.Show(
                "Are you sure you want to change listing #" &
                selectedID & " from " & oldStatus &
                " to " & newStatus & "?",
                "Confirm Status Update",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            )

        If result <> DialogResult.Yes Then

            cmbListingStatus.SelectedItem = oldStatus
            Return

        End If


        ' Update the listing status

        selectedListing("Status") = newStatus


        '========================================
        ' AUTOMATICALLY RECORD TRANSACTION
        '========================================

        If newStatus = "Collected" Then

            User_dash.RecordTransaction(selectedListing)

        End If


        txtSearch.Clear()

        If listingView IsNot Nothing Then
            listingView.RowFilter = ""
        End If

        dgvListings.Refresh()

        SelectListingByID(selectedID)

        DisplayListingDetails()

        MessageBox.Show(
            "Listing #" & selectedID &
            " status has been updated successfully!" &
            vbCrLf & "New status: " & newStatus &
            If(newStatus = "Collected",
               vbCrLf & "Transaction has been recorded.",
               ""),
            "Plasticash",
            MessageBoxButtons.OK,
            MessageBoxIcon.Information
        )

    End Sub


    '========================================
    ' EDIT LISTING
    '========================================

    Private Sub btnEditListing_Click(
        sender As Object,
        e As EventArgs
    ) Handles btnEditListing.Click

        If dgvListings.CurrentRow Is Nothing OrElse
           dgvListings.CurrentRow.IsNewRow Then

            MessageBox.Show("Please select a listing to edit.",
                            "Plasticash",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Warning)

            Return

        End If

        Dim selectedRow = dgvListings.CurrentRow

        editingListingID =
            Convert.ToInt32(selectedRow.Cells("ListingID").Value)

        cmbEditPlasticType.Items.Clear()

        cmbEditPlasticType.Items.AddRange(
            New Object() {
                "PET Bottles",
                "HDPE",
                "LDPE",
                "PP Containers",
                "PVC",
                "Other Plastics"
            }
        )

        cmbEditPlasticType.Text =
            selectedRow.Cells("PlasticType").Value.ToString()

        txtEditQuantity.Text =
            selectedRow.Cells("Quantity").Value.ToString()

        txtEditArea.Text =
            selectedRow.Cells("Area").Value.ToString()

        txtEditPrice.Text =
            selectedRow.Cells("PricePerKg").Value.ToString()

        EnterEditMode()

    End Sub


    '========================================
    ' ENTER EDIT MODE
    '========================================

    Private Sub EnterEditMode()

        cmbEditPlasticType.Visible = True
        txtEditQuantity.Visible = True
        txtEditArea.Visible = True
        txtEditPrice.Visible = True

        btnSaveChanges.Visible = True
        btnCancelEdit.Visible = True

        btnEditListing.Visible = False
        btnDeleteListing.Visible = False

        cmbListingStatus.Enabled = False
        btnUpdateStatus.Enabled = False

    End Sub


    '========================================
    ' SAVE CHANGES
    '========================================

    Private Sub btnSaveChanges_Click(
        sender As Object,
        e As EventArgs
    ) Handles btnSaveChanges.Click

        If listingTable Is Nothing OrElse editingListingID = -1 Then Return

        If String.IsNullOrWhiteSpace(cmbEditPlasticType.Text) Then

            MessageBox.Show("Please select a plastic type.")
            cmbEditPlasticType.Focus()
            Return

        End If

        Dim quantity As Decimal

        If Not Decimal.TryParse(txtEditQuantity.Text, quantity) OrElse quantity <= 0 Then

            MessageBox.Show("Please enter a valid quantity.")
            txtEditQuantity.Focus()
            Return

        End If

        If String.IsNullOrWhiteSpace(txtEditArea.Text) Then

            MessageBox.Show("Please enter a collection area.")
            txtEditArea.Focus()
            Return

        End If

        Dim price As Decimal

        If Not Decimal.TryParse(txtEditPrice.Text, price) OrElse price < 0 Then

            MessageBox.Show("Please enter a valid price.")
            txtEditPrice.Focus()
            Return

        End If

        Dim foundRows() As DataRow =
            listingTable.Select("ListingID = " & editingListingID)

        If foundRows.Length = 0 Then

            MessageBox.Show("Listing could not be found.")

            ExitEditMode()
            Return

        End If

        Dim selectedListing As DataRow = foundRows(0)

        selectedListing("PlasticType") = cmbEditPlasticType.Text
        selectedListing("Quantity") = quantity
        selectedListing("Area") = txtEditArea.Text.Trim()
        selectedListing("PricePerKg") = price
        selectedListing("TotalPrice") = quantity * price

        Dim savedID As Integer = editingListingID

        ExitEditMode()

        If listingView IsNot Nothing Then
            listingView.RowFilter = ""
        End If

        txtSearch.Clear()

        dgvListings.Refresh()

        SelectListingByID(savedID)

        DisplayListingDetails()

        MessageBox.Show("Your listing has been updated successfully!",
                        "Plasticash",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information)

    End Sub


    '========================================
    ' CANCEL EDITING
    '========================================

    Private Sub btnCancelEdit_Click(
        sender As Object,
        e As EventArgs
    ) Handles btnCancelEdit.Click

        ExitEditMode()
        DisplayListingDetails()

    End Sub


    '========================================
    ' EXIT EDIT MODE
    '========================================

    Private Sub ExitEditMode()

        editingListingID = -1

        cmbEditPlasticType.Visible = False
        txtEditQuantity.Visible = False
        txtEditArea.Visible = False
        txtEditPrice.Visible = False

        btnSaveChanges.Visible = False
        btnCancelEdit.Visible = False

        btnEditListing.Visible = True
        btnDeleteListing.Visible = True

        cmbEditPlasticType.SelectedIndex = -1
        cmbEditPlasticType.Text = ""

        txtEditQuantity.Clear()
        txtEditArea.Clear()
        txtEditPrice.Clear()

    End Sub


    '========================================
    ' DELETE LISTING
    '========================================

    Private Sub btnDeleteListing_Click(
        sender As Object,
        e As EventArgs
    ) Handles btnDeleteListing.Click

        If listingTable Is Nothing OrElse
           dgvListings.CurrentRow Is Nothing OrElse
           dgvListings.CurrentRow.IsNewRow Then

            MessageBox.Show("Please select a listing to delete.")
            Return

        End If

        Dim selectedID As Integer =
            Convert.ToInt32(dgvListings.CurrentRow.Cells("ListingID").Value)

        Dim result As DialogResult =
            MessageBox.Show(
                "Are you sure you want to delete listing #" & selectedID & "?" &
                vbCrLf & "This action cannot be undone.",
                "Confirm Deletion",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning
            )

        If result <> DialogResult.Yes Then Return

        Dim foundRows() As DataRow =
            listingTable.Select("ListingID = " & selectedID)

        If foundRows.Length > 0 Then
            listingTable.Rows.Remove(foundRows(0))
        End If

        ExitEditMode()

        If dgvListings.Rows.Count > 0 Then

            dgvListings.ClearSelection()
            dgvListings.Rows(0).Selected = True
            dgvListings.CurrentCell = dgvListings.Rows(0).Cells("ListingID")

            DisplayListingDetails()

        Else

            ClearListingDetails()

        End If

        MessageBox.Show("Listing deleted successfully.",
                        "Plasticash",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information)

    End Sub


    '========================================
    ' SELECT LISTING BY ID
    '========================================

    Private Sub SelectListingByID(listingID As Integer)

        For Each row As DataGridViewRow In dgvListings.Rows

            If Not row.IsNewRow AndAlso
               Convert.ToInt32(row.Cells("ListingID").Value) = listingID Then

                dgvListings.ClearSelection()

                row.Selected = True

                dgvListings.CurrentCell = row.Cells("ListingID")

                Return

            End If

        Next

    End Sub


    '========================================
    ' OPEN LISTING IMAGES PAGE
    '========================================

    Private Sub btnImages_Click(
        sender As Object,
        e As EventArgs
    ) Handles btnImages.Click

        If listingTable Is Nothing OrElse listingTable.Rows.Count = 0 Then

            MessageBox.Show(
                "You need to create a listing before managing its images.",
                "Plasticash",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information
            )

            Return

        End If

        Listing_Images.LoadListings(listingTable)

        Listing_Images.Show()

        Me.Hide()

    End Sub


    '========================================
    ' RETURN TO DASHBOARD
    '========================================

    Private Sub btn_Overview_Click(
        sender As Object,
        e As EventArgs
    ) Handles btn_Overview.Click

        ExitEditMode()

        User_dash.Show()

        Me.Hide()

    End Sub


    '========================================
    ' OPEN TRANSACTION HISTORY
    '========================================

    Private Sub btnPayment_Click(
        sender As Object,
        e As EventArgs
    ) Handles btnPayment.Click

        Transaction_History.Show()

        Me.Hide()

    End Sub

End Class
