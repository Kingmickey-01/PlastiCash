
Imports System.Data
Imports System.Drawing

Public Class Dashboard

    '========================================
    ' SHARED LISTINGS DATA
    '========================================

    Private listingsTable As DataTable
    Private listingsView As DataView

    '========================================
    ' DASHBOARD LOAD
    '========================================

    Private Sub Dashboard_Load(
        sender As Object,
        e As EventArgs
    ) Handles MyBase.Load

        ConfigurePlasticTypeFilter()
        ConfigureGrid()
        LoadDashboardData()

    End Sub

    '========================================
    ' CONFIGURE PLASTIC TYPE FILTER
    '========================================

    Private Sub ConfigurePlasticTypeFilter()

        cmbPlasticType.Items.Clear()

        cmbPlasticType.Items.AddRange(
            New Object() {
                "All",
                "PET bottles - Water bottles, soft drink bottles",
                "HDPE - Detergent bottles, shampoo containers",
                "LDPE - Plastic bags, wrapping films",
                "PP - Food containers, bottle caps, buckets",
                "PVC - Plastic pipes, cable insulation",
                "PS - Disposable cups, foam packaging",
                "Other Plastics - Enter the plastic type"
            }
        )

        cmbPlasticType.DropDownStyle =
            ComboBoxStyle.DropDownList

        cmbPlasticType.SelectedIndex = 0

    End Sub

    '========================================
    ' CONFIGURE DATA GRID
    '========================================

    Private Sub ConfigureGrid()

        With dgvlists

            .DataSource = Nothing

            .ReadOnly = True
            .AllowUserToAddRows = False
            .AllowUserToDeleteRows = False
            .AllowUserToResizeRows = False

            .MultiSelect = False

            .SelectionMode =
                DataGridViewSelectionMode.FullRowSelect

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

    End Sub

    '========================================
    ' LOAD SHARED LISTINGS
    '========================================

    Private Sub LoadDashboardData()

        listingsTable = User_dash.Listings

        If listingsTable Is Nothing Then

            MessageBox.Show(
                "Unable to access the shared listings table.",
                "Plasticash",
                MessageBoxButtons.OK,
                MessageBoxIcon.Error)

            Return

        End If

        ' Check required columns

        If Not listingsTable.Columns.Contains("ListingID") OrElse
           Not listingsTable.Columns.Contains("PlasticType") OrElse
           Not listingsTable.Columns.Contains("Quantity") OrElse
           Not listingsTable.Columns.Contains("Area") OrElse
           Not listingsTable.Columns.Contains("PricePerKg") OrElse
           Not listingsTable.Columns.Contains("TotalPrice") OrElse
           Not listingsTable.Columns.Contains("DatePosted") OrElse
           Not listingsTable.Columns.Contains("Status") Then

            MessageBox.Show(
                "The listings table is missing required columns. " &
                "Please check the User_dash table initialization.",
                "Plasticash",
                MessageBoxButtons.OK,
                MessageBoxIcon.Error)

            Return

        End If

        ' Create shared data view

        listingsView = New DataView(listingsTable)

        dgvlists.DataSource = listingsView

        StyleGrid()

        ApplyFilters()

    End Sub

    '========================================
    ' FORMAT DATA GRID COLUMNS
    '========================================

    Private Sub StyleGrid()

        If dgvlists.Columns.Count = 0 Then Return

        With dgvlists.Columns

            If .Contains("ListingID") Then
                .Item("ListingID").HeaderText = "Listing ID"
            End If

            If .Contains("PlasticType") Then
                .Item("PlasticType").HeaderText = "Plastic Type"
            End If

            If .Contains("Quantity") Then

                .Item("Quantity").HeaderText = "Quantity (kg)"
                .Item("Quantity").DefaultCellStyle.Format = "N2"

            End If

            If .Contains("Area") Then
                .Item("Area").HeaderText = "Collection Area"
            End If

            If .Contains("PricePerKg") Then

                .Item("PricePerKg").HeaderText = "Price/kg (GH₵)"
                .Item("PricePerKg").DefaultCellStyle.Format = "N2"

            End If

            If .Contains("TotalPrice") Then

                .Item("TotalPrice").HeaderText =
                    "Total Asking Price (GH₵)"

                .Item("TotalPrice").DefaultCellStyle.Format = "N2"

            End If

            If .Contains("DatePosted") Then

                .Item("DatePosted").HeaderText = "Date Posted"

                .Item("DatePosted").DefaultCellStyle.Format =
                    "dd MMM yyyy"

            End If

            If .Contains("Status") Then
                .Item("Status").HeaderText = "Listing Status"
            End If

            ' Hide image columns

            If .Contains("Image1") Then
                .Item("Image1").Visible = False
            End If

            If .Contains("Image2") Then
                .Item("Image2").Visible = False
            End If

            If .Contains("Image3") Then
                .Item("Image3").Visible = False
            End If

        End With

    End Sub

    '========================================
    ' SEARCH BUTTON
    '========================================



    '========================================
    ' PLASTIC TYPE SELECTION
    '========================================

    Private Sub cmbPlasticType_SelectedIndexChanged(
        sender As Object,
        e As EventArgs
    ) Handles cmbPlasticType.SelectedIndexChanged

        ApplyFilters()

    End Sub

    '========================================
    ' APPLY PLASTIC TYPE FILTER
    '========================================

    Private Sub ApplyFilters()

        If listingsTable Is Nothing OrElse
           listingsView Is Nothing Then

            Return

        End If

        If Not listingsView.Table.Columns.Contains("PlasticType") Then
            Return
        End If

        Dim selectedItem As String =
            If(
                cmbPlasticType.SelectedItem Is Nothing,
                "All",
                cmbPlasticType.SelectedItem.ToString()
            )

        If selectedItem = "All" Then

            listingsView.RowFilter = ""

        Else

            ' Extract category keyword

            Dim keyword As String =
                selectedItem.Split("-"c)(0).Trim()

            keyword = keyword.Replace("'", "''")
            keyword = keyword.Replace("[", "[[]")
            keyword = keyword.Replace("%", "[%]")
            keyword = keyword.Replace("*", "[*]")

            listingsView.RowFilter =
                "PlasticType LIKE '%" & keyword & "%'"

        End If

        dgvlists.Refresh()

        CalculateMetrics(listingsView.ToTable())

    End Sub

    '========================================
    ' CALCULATE DASHBOARD STATISTICS
    '========================================

    Private Sub CalculateMetrics(dt As DataTable)

        Dim activeListings As Integer = 0
        Dim totalKg As Decimal = 0D
        Dim totalEarnings As Decimal = 0D

        If dt Is Nothing Then Return

        For Each row As DataRow In dt.Rows

            Dim status As String =
                If(
                    IsDBNull(row("Status")),
                    "",
                    Convert.ToString(row("Status"))
                )

            ' Count available listings

            If status = "Available" Then
                activeListings += 1
            End If

            ' Calculate total plastic quantity

            If Not IsDBNull(row("Quantity")) Then

                totalKg += Convert.ToDecimal(row("Quantity"))

            End If

            ' Calculate earnings from collected listings

            If status = "Collected" AndAlso
               Not IsDBNull(row("TotalPrice")) Then

                totalEarnings +=
                    Convert.ToDecimal(row("TotalPrice"))

            End If

        Next

        ' Update dashboard cards

        lblActiveListings.Text =
            activeListings.ToString()

        lblPlasticsListed.Text =
            totalKg.ToString("N2") & " kg"

        lblEarnedSoFar.Text =
            "GH₵ " & totalEarnings.ToString("N2")

    End Sub

    '========================================
    ' REFRESH WHEN RETURNING TO DASHBOARD
    '========================================

    Private Sub Dashboard_Activated(
        sender As Object,
        e As EventArgs
    ) Handles MyBase.Activated

        If listingsTable Is Nothing OrElse listingsView Is Nothing Then

            LoadDashboardData()

        Else

            listingsTable = User_dash.Listings

            If listingsTable IsNot Nothing Then

                listingsView = New DataView(listingsTable)

                dgvlists.DataSource = listingsView

                StyleGrid()
                ApplyFilters()

            End If

        End If

    End Sub

    '========================================
    ' EXIT / LOGOUT
    '========================================

    Private Sub btnExit_Click(
        sender As Object,
        e As EventArgs
    ) Handles btnExit.Click

        Form1.Show()
        Form1.BringToFront()

        Me.Hide()

    End Sub

    '========================================
    ' MANAGE LISTINGS
    '========================================

    Private Sub btnListing_Click(
        sender As Object,
        e As EventArgs
    ) Handles btnListing.Click

        Manage_Listings.Show()


        Me.Hide()

    End Sub

    '========================================
    ' COMPANY PROFILE
    '========================================

    Private Sub btnPost_Click(
        sender As Object,
        e As EventArgs
    ) Handles btnPost.Click

        Company_Profiile.Show()
        Company_Profiile.BringToFront()

        Me.Hide()

    End Sub

End Class
