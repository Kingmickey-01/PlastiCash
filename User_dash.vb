Imports System.Data

Public Class User_dash

    '========================================
    ' SHARED LISTINGS TABLE
    '========================================

    Private listingTable As New DataTable()

    Public ReadOnly Property Listings As DataTable
        Get
            InitializeListingsTable()
            Return listingTable
        End Get
    End Property


    '========================================
    ' INITIALIZE LISTINGS TABLE
    '========================================

    Private Sub InitializeListingsTable()

        If Not listingTable.Columns.Contains("ListingID") Then

            Dim idColumn As DataColumn =
                listingTable.Columns.Add("ListingID", GetType(Integer))

            idColumn.AutoIncrement = True
            idColumn.AutoIncrementSeed = 1001
            idColumn.AutoIncrementStep = 1

        End If

        If Not listingTable.Columns.Contains("PlasticType") Then
            listingTable.Columns.Add("PlasticType", GetType(String))
        End If

        If Not listingTable.Columns.Contains("Quantity") Then
            listingTable.Columns.Add("Quantity", GetType(Decimal))
        End If

        If Not listingTable.Columns.Contains("Area") Then
            listingTable.Columns.Add("Area", GetType(String))
        End If

        If Not listingTable.Columns.Contains("PricePerKg") Then
            listingTable.Columns.Add("PricePerKg", GetType(Decimal))
        End If

        If Not listingTable.Columns.Contains("TotalPrice") Then
            listingTable.Columns.Add("TotalPrice", GetType(Decimal))
        End If

        If Not listingTable.Columns.Contains("DatePosted") Then
            listingTable.Columns.Add("DatePosted", GetType(DateTime))
        End If

        If Not listingTable.Columns.Contains("Status") Then
            listingTable.Columns.Add("Status", GetType(String))
        End If

        ' Image storage columns

        If Not listingTable.Columns.Contains("Image1") Then
            listingTable.Columns.Add("Image1", GetType(Byte()))
        End If

        If Not listingTable.Columns.Contains("Image2") Then
            listingTable.Columns.Add("Image2", GetType(Byte()))
        End If

        If Not listingTable.Columns.Contains("Image3") Then
            listingTable.Columns.Add("Image3", GetType(Byte()))
        End If

    End Sub


    '========================================
    ' USER DASHBOARD LOAD
    '========================================

    Private Sub User_dash_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        InitializeListingsTable()

        RefreshDashboardSummary()
        RefreshDashboardStats()

    End Sub


    '========================================
    ' REFRESH LISTING SUMMARY
    '========================================

    Private Sub RefreshDashboardSummary()

        InitializeListingsTable()

        lstListings.Items.Clear()

        If listingTable.Rows.Count = 0 Then

            lstListings.Items.Add("You haven't posted any plastics yet.")
            Return

        End If

        For Each listing As DataRow In listingTable.Rows

            Dim plasticType As String =
                If(IsDBNull(listing("PlasticType")), "", listing("PlasticType").ToString())

            Dim quantity As Decimal = 0D

            If Not IsDBNull(listing("Quantity")) Then
                quantity = Convert.ToDecimal(listing("Quantity"))
            End If

            Dim area As String =
                If(IsDBNull(listing("Area")), "", listing("Area").ToString())

            Dim totalPrice As Decimal = 0D

            If Not IsDBNull(listing("TotalPrice")) Then
                totalPrice = Convert.ToDecimal(listing("TotalPrice"))
            End If

            Dim status As String =
                If(IsDBNull(listing("Status")), "", listing("Status").ToString())

            Dim summary As String =
                "#" & listing("ListingID").ToString() &
                " | " & plasticType &
                " | " & quantity.ToString("0.##") & " kg" &
                " | " & area &
                " | GH₵ " & totalPrice.ToString("N2") &
                " | " & status

            lstListings.Items.Add(summary)

        Next

    End Sub


    '========================================
    ' REFRESH DASHBOARD STATISTICS
    '========================================

    Private Sub RefreshDashboardStats()

        InitializeListingsTable()

        Dim activeCount As Integer = 0
        Dim totalPlastic As Decimal = 0D
        Dim totalEarned As Decimal = 0D

        For Each listing As DataRow In listingTable.Rows

            Dim status As String =
                If(IsDBNull(listing("Status")), "", listing("Status").ToString())

            If status = "Available" Then
                activeCount += 1
            End If

            If Not IsDBNull(listing("Quantity")) Then
                totalPlastic += Convert.ToDecimal(listing("Quantity"))
            End If

            If status = "Collected" AndAlso
               Not IsDBNull(listing("TotalPrice")) Then

                totalEarned += Convert.ToDecimal(listing("TotalPrice"))

            End If

        Next

        lblActiveCount.Text = activeCount.ToString()
        lblTotalPlastic.Text = totalPlastic.ToString("N2") & " kg"
        lblTotalEarned.Text = "GH₵ " & totalEarned.ToString("N2")

    End Sub


    '========================================
    ' POST PLASTIC LISTING
    '========================================

    Private Sub PostListings_Click(sender As Object, e As EventArgs) Handles btnPostListings.Click

        InitializeListingsTable()

        ' Validate plastic type

        If cmbPlasticType.SelectedIndex = -1 Then

            MessageBox.Show(
                "Please select a plastic type.",
                "Plasticash",
                MessageBoxButtons.OK,
                MessageBoxIcon.Warning
            )

            cmbPlasticType.Focus()
            Return

        End If


        ' Validate quantity

        Dim quantity As Decimal

        If Not Decimal.TryParse(txtQuantity.Text, quantity) OrElse quantity <= 0 Then

            MessageBox.Show(
                "Please enter a valid quantity in kg.",
                "Plasticash",
                MessageBoxButtons.OK,
                MessageBoxIcon.Warning
            )

            txtQuantity.Focus()
            Return

        End If


        ' Validate collection area

        If String.IsNullOrWhiteSpace(txtArea.Text) Then

            MessageBox.Show(
                "Please enter your collection area.",
                "Plasticash",
                MessageBoxButtons.OK,
                MessageBoxIcon.Warning
            )

            txtArea.Focus()
            Return

        End If


        ' Validate price per kg

        Dim price As Decimal

        If Not Decimal.TryParse(txtPricePerKg.Text, price) OrElse price < 0 Then

            MessageBox.Show(
                "Please enter a valid price per kg.",
                "Plasticash",
                MessageBoxButtons.OK,
                MessageBoxIcon.Warning
            )

            txtPricePerKg.Focus()
            Return

        End If


        ' Calculate total asking price

        Dim totalPrice As Decimal = quantity * price


        ' Create new listing

        Dim newListing As DataRow = listingTable.NewRow()

        newListing("PlasticType") = cmbPlasticType.Text.Trim()
        newListing("Quantity") = quantity
        newListing("Area") = txtArea.Text.Trim()
        newListing("PricePerKg") = price
        newListing("TotalPrice") = totalPrice
        newListing("DatePosted") = DateTime.Now
        newListing("Status") = "Available"

        listingTable.Rows.Add(newListing)


        ' Refresh dashboard information

        RefreshDashboardSummary()
        RefreshDashboardStats()


        ' Display confirmation

        MessageBox.Show(
            "Your plastic listing has been posted successfully!" &
            vbCrLf & vbCrLf &
            "Listing ID: " & newListing("ListingID").ToString() &
            vbCrLf &
            "Total asking price: GH₵ " & totalPrice.ToString("N2"),
            "Plasticash",
            MessageBoxButtons.OK,
            MessageBoxIcon.Information
        )


        ' Clear input fields

        cmbPlasticType.SelectedIndex = -1
        txtQuantity.Clear()
        txtArea.Clear()
        txtPricePerKg.Clear()

        cmbPlasticType.Focus()

    End Sub


    '========================================
    ' OPEN MY LISTINGS PAGE
    '========================================

    Private Sub btnListing_Click(sender As Object, e As EventArgs) Handles btnListing.Click

        My_listings.LoadListings(Me.Listings)

        My_listings.Show()
        My_listings.BringToFront()

        Me.Hide()

    End Sub


    '========================================
    ' REFRESH WHEN RETURNING TO DASHBOARD
    '========================================

    Private Sub User_dash_Activated(sender As Object, e As EventArgs) Handles MyBase.Activated

        RefreshDashboardSummary()
        RefreshDashboardStats()

    End Sub


    '========================================
    ' LOGOUT
    '========================================

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click

        Dim result As DialogResult =
            MessageBox.Show(
                "Are you sure you want to log out?",
                "Confirm Logout",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            )

        If result = DialogResult.Yes Then

            Form1.Show()
            Me.Hide()

        End If

    End Sub


    '========================================
    ' OPEN LISTING IMAGES
    '========================================

    Private Sub btnImages_Click(sender As Object, e As EventArgs) Handles btnImages.Click

        Listing_Images.LoadListings(Me.Listings)

        Listing_Images.Show()
        Listing_Images.BringToFront()

        Me.Hide()

    End Sub


    '========================================
    ' OPEN TRANSACTION HISTORY
    '========================================

    Private Sub btnPayment_Click(sender As Object, e As EventArgs) Handles btnPayment.Click

        Transaction_History.Show()
        Transaction_History.BringToFront()

        Me.Hide()

    End Sub


    '========================================
    ' SHARED TRANSACTION DATA
    '========================================

    Private transactionTable As DataTable

    Public ReadOnly Property Transactions As DataTable
        Get

            If transactionTable Is Nothing Then

                transactionTable = New DataTable()

                transactionTable.Columns.Add("TransactionID", GetType(String))
                transactionTable.Columns.Add("ListingID", GetType(Integer))
                transactionTable.Columns.Add("PlasticType", GetType(String))
                transactionTable.Columns.Add("WeightKg", GetType(Decimal))
                transactionTable.Columns.Add("EarningsGHS", GetType(Decimal))
                transactionTable.Columns.Add("Status", GetType(String))
                transactionTable.Columns.Add("DatePosted", GetType(DateTime))

            End If

            Return transactionTable

        End Get
    End Property


    '========================================
    ' RECORD A COMPLETED TRANSACTION
    '========================================

    Public Sub RecordTransaction(listing As DataRow)

        If listing Is Nothing Then Return

        InitializeListingsTable()

        Dim transactionsData As DataTable = Me.Transactions

        Dim listingID As Integer =
            Convert.ToInt32(listing("ListingID"))

        ' Prevent duplicate transactions

        Dim existingRows() As DataRow =
            transactionsData.Select("ListingID = " & listingID)

        If existingRows.Length > 0 Then Return


        ' Create transaction

        Dim newTransaction As DataRow =
            transactionsData.NewRow()

        newTransaction("TransactionID") = "TXN-" & listingID.ToString()
        newTransaction("ListingID") = listingID
        newTransaction("PlasticType") = listing("PlasticType").ToString()
        newTransaction("WeightKg") = Convert.ToDecimal(listing("Quantity"))
        newTransaction("EarningsGHS") = Convert.ToDecimal(listing("TotalPrice"))
        newTransaction("Status") = "Completed"
        newTransaction("DatePosted") = DateTime.Now

        transactionsData.Rows.Add(newTransaction)

    End Sub

    Private Sub lblTotalPlastic_Click(sender As Object, e As EventArgs) Handles lblTotalPlastic.Click

    End Sub
End Class