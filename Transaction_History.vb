
Imports System.Data
Imports System.Drawing
Imports System.Globalization

Public Class Transaction_History

    Private transactionTable As DataTable
    Private transactionView As DataView


    '========================================
    ' FORM LOAD
    '========================================

    Private Sub Transaction_History_Load(
        sender As Object,
        e As EventArgs
    ) Handles MyBase.Load

        ConfigureStatusFilter()
        ConfigureGrid()
        LoadTransactionData()

    End Sub


    '========================================
    ' CONFIGURE STATUS FILTER
    '========================================

    Private Sub ConfigureStatusFilter()

        cmbStatus.Items.Clear()

        cmbStatus.Items.AddRange(
            New Object() {
                "All",
                "Completed",
                "Pending",
                "Cancelled"
            }
        )

        cmbStatus.DropDownStyle = ComboBoxStyle.DropDownList
        cmbStatus.SelectedIndex = 0

    End Sub


    '========================================
    ' CONFIGURE TRANSACTION GRID
    '========================================

    Private Sub ConfigureGrid()

        With dgvTransactionHistory

            .ReadOnly = True
            .AllowUserToAddRows = False
            .AllowUserToDeleteRows = False
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
    ' LOAD TRANSACTION DATA
    '========================================

    Private Sub LoadTransactionData()

        transactionTable = User_dash.Transactions

        transactionView = New DataView(transactionTable)

        dgvTransactionHistory.DataSource = transactionView

        StyleGrid()

        ApplyFilters()

    End Sub


    '========================================
    ' STYLE GRID COLUMNS
    '========================================

    Private Sub StyleGrid()

        If dgvTransactionHistory.Columns.Count = 0 Then Return

        With dgvTransactionHistory.Columns

            If .Contains("TransactionID") Then
                .Item("TransactionID").HeaderText = "Transaction ID"
            End If

            If .Contains("ListingID") Then
                .Item("ListingID").HeaderText = "Listing ID"
            End If

            If .Contains("PlasticType") Then
                .Item("PlasticType").HeaderText = "Plastic Type"
            End If

            If .Contains("WeightKg") Then
                .Item("WeightKg").HeaderText = "Weight (kg)"
                .Item("WeightKg").DefaultCellStyle.Format = "N2"
            End If

            If .Contains("EarningsGHS") Then
                .Item("EarningsGHS").HeaderText = "Earnings (GH₵)"
                .Item("EarningsGHS").DefaultCellStyle.Format = "N2"
            End If

            If .Contains("Status") Then
                .Item("Status").HeaderText = "Status"
            End If

            If .Contains("DatePosted") Then
                .Item("DatePosted").HeaderText = "Transaction Date"
                .Item("DatePosted").DefaultCellStyle.Format = "dd MMM yyyy"
            End If

        End With

    End Sub


    '========================================
    ' SEARCH TRANSACTIONS
    '========================================

    Private Sub txtSearch_TextChanged(
        sender As Object,
        e As EventArgs
    ) Handles txtSearch.TextChanged

        ApplyFilters()

    End Sub


    '========================================
    ' FILTER BY STATUS
    '========================================

    Private Sub cmbStatus_SelectedIndexChanged(
        sender As Object,
        e As EventArgs
    ) Handles cmbStatus.SelectedIndexChanged

        ApplyFilters()

    End Sub


    '========================================
    ' APPLY SEARCH AND STATUS FILTERS
    '========================================

    Private Sub ApplyFilters()

        If transactionTable Is Nothing OrElse
           transactionView Is Nothing Then Return

        Dim searchText As String =
            txtSearch.Text.Trim()

        Dim selectedStatus As String =
            If(cmbStatus.SelectedItem Is Nothing,
               "All",
               cmbStatus.SelectedItem.ToString())

        Dim filterParts As New List(Of String)


        '========================================
        ' SEARCH ALL TRANSACTION COLUMNS
        '========================================

        If searchText <> "" Then

            Dim safeSearch As String =
                searchText.Replace("'", "''").
                Replace("[", "[[]").
                Replace("%", "[%]").
                Replace("*", "[*]")

            Dim searchConditions As New List(Of String)

            ' Transaction ID

            searchConditions.Add(
                "TransactionID LIKE '%" & safeSearch & "%'"
            )


            ' Listing ID

            searchConditions.Add(
                "Convert(ListingID, 'System.String') LIKE '%" &
                safeSearch & "%'"
            )


            ' Plastic Type

            searchConditions.Add(
                "PlasticType LIKE '%" & safeSearch & "%'"
            )


            ' Weight

            searchConditions.Add(
                "Convert(WeightKg, 'System.String') LIKE '%" &
                safeSearch & "%'"
            )


            ' Earnings

            searchConditions.Add(
                "Convert(EarningsGHS, 'System.String') LIKE '%" &
                safeSearch & "%'"
            )


            ' Status

            searchConditions.Add(
                "Status LIKE '%" & safeSearch & "%'"
            )


            ' Transaction Date

            Dim dateSearch As String =
                searchText.ToLowerInvariant()

            Dim matchingDates As New List(Of String)

            For Each row As DataRow In transactionTable.Rows

                If row.RowState = DataRowState.Deleted Then Continue For
                If IsDBNull(row("DatePosted")) Then Continue For

                Dim transactionDate As DateTime =
                    Convert.ToDateTime(row("DatePosted"))

                Dim formattedDate As String() = {
                    transactionDate.ToString("dd MMM yyyy"),
                    transactionDate.ToString("dd/MM/yyyy"),
                    transactionDate.ToString("MM/dd/yyyy"),
                    transactionDate.ToString("yyyy-MM-dd"),
                    transactionDate.ToString("dd MMMM yyyy")
                }

                For Each dateFormat As String In formattedDate

                    If dateFormat.ToLowerInvariant().Contains(dateSearch) Then

                        Dim dateValue As String =
                            transactionDate.ToString(
                                "yyyy-MM-dd",
                                CultureInfo.InvariantCulture
                            )

                        If Not matchingDates.Contains(dateValue) Then
                            matchingDates.Add(dateValue)
                        End If

                        Exit For

                    End If

                Next

            Next


            If matchingDates.Count > 0 Then

                Dim dateConditions As New List(Of String)

                For Each dateValue As String In matchingDates

                    dateConditions.Add(
                        "DatePosted = #" & dateValue & "#"
                    )

                Next

                searchConditions.Add(
                    "(" & String.Join(" OR ", dateConditions) & ")"
                )

            End If


            ' Combine all search conditions

            filterParts.Add(
                "(" & String.Join(" OR ", searchConditions) & ")"
            )

        End If


        '========================================
        ' APPLY STATUS FILTER
        '========================================

        If selectedStatus <> "All" Then

            filterParts.Add(
                "Status = '" & selectedStatus.Replace("'", "''") & "'"
            )

        End If


        '========================================
        ' APPLY FINAL FILTER
        '========================================

        transactionView.RowFilter =
            String.Join(" AND ", filterParts)

        CalculateMetrics(transactionView.ToTable())

    End Sub


    '========================================
    ' CALCULATE SUMMARY METRICS
    '========================================

    Private Sub CalculateMetrics(dt As DataTable)

        Dim totalKg As Decimal = 0D
        Dim totalEarnings As Decimal = 0D
        Dim totalTransactions As Integer = 0

        If dt IsNot Nothing Then

            totalTransactions = dt.Rows.Count

            For Each row As DataRow In dt.Rows

                If Not IsDBNull(row("WeightKg")) Then

                    totalKg += Convert.ToDecimal(row("WeightKg"))

                End If

                If Not IsDBNull(row("EarningsGHS")) Then

                    totalEarnings += Convert.ToDecimal(row("EarningsGHS"))

                End If

            Next

        End If

        lblTotalPlascticSold.Text =
            totalKg.ToString("N2") & " kg"

        lblTotalEarnings.Text =
            "GH₵ " & totalEarnings.ToString("N2")

        lblTotalTransactions.Text =
            totalTransactions.ToString()

    End Sub


    '========================================
    ' VIEW TRANSACTION DETAILS
    '========================================

    Private Sub btnViewDetails_Click(
        sender As Object,
        e As EventArgs
    ) Handles btnViewDetails.Click

        If dgvTransactionHistory.SelectedRows.Count = 0 Then

            MessageBox.Show(
                "Please select a transaction first.",
                "Plasticash",
                MessageBoxButtons.OK,
                MessageBoxIcon.Warning
            )

            Return

        End If

        Dim selectedRow As DataGridViewRow =
            dgvTransactionHistory.SelectedRows(0)

        Dim details As String =
            "TRANSACTION DETAILS" & vbCrLf & vbCrLf &
            "Transaction ID: " &
            selectedRow.Cells("TransactionID").Value.ToString() & vbCrLf &
            "Listing ID: " &
            selectedRow.Cells("ListingID").Value.ToString() & vbCrLf &
            "Plastic Type: " &
            selectedRow.Cells("PlasticType").Value.ToString() & vbCrLf &
            "Quantity: " &
            Convert.ToDecimal(selectedRow.Cells("WeightKg").Value).ToString("N2") &
            " kg" & vbCrLf &
            "Earnings: GH₵ " &
            Convert.ToDecimal(selectedRow.Cells("EarningsGHS").Value).ToString("N2") &
            vbCrLf &
            "Status: " &
            selectedRow.Cells("Status").Value.ToString() & vbCrLf &
            "Date: " &
            Convert.ToDateTime(selectedRow.Cells("DatePosted").Value).ToString("dd MMMM yyyy")

        MessageBox.Show(
            details,
            "Plasticash - Transaction Details",
            MessageBoxButtons.OK,
            MessageBoxIcon.Information
        )

    End Sub


    '========================================
    ' REFRESH WHEN FORM BECOMES ACTIVE
    '========================================

    Private Sub Transaction_History_Activated(
        sender As Object,
        e As EventArgs
    ) Handles MyBase.Activated

        If transactionTable Is Nothing Then Return

        ApplyFilters()

    End Sub


    '========================================
    ' RETURN TO MY LISTINGS
    '========================================

    Private Sub Button3_Click(
        sender As Object,
        e As EventArgs
    ) Handles Button3.Click

        My_listings.Show()

        Me.Hide()

    End Sub

End Class
