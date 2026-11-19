
Imports System.Data
Imports System.Drawing
Imports System.IO

Public Class Listing_Images

    '========================================
    ' SHARED LISTINGS DATA
    '========================================

    Private listingTable As DataTable
    Private loadingListings As Boolean = False

    '========================================
    ' RECEIVE LISTINGS
    '========================================

    Public Sub LoadListings(data As DataTable)

        If data Is Nothing Then

            MessageBox.Show(
                "No listing information was received.",
                "Plasticash",
                MessageBoxButtons.OK,
                MessageBoxIcon.Warning
            )

            Return

        End If

        listingTable = data

        EnsureImageColumns()

        PopulateListings()

    End Sub

    '========================================
    ' RECEIVE ONE SELECTED LISTING
    '========================================

    Public Sub LoadSelectedListing(listing As DataRow)

        If listing Is Nothing Then Return

        listingTable = listing.Table

        EnsureImageColumns()

        PopulateListings()

        Dim selectedID As Integer =
            Convert.ToInt32(listing("ListingID"))

        cmbSelectListing.SelectedValue = selectedID

        DisplayListingImages()

    End Sub

    '========================================
    ' ENSURE IMAGE COLUMNS EXIST
    '========================================

    Private Sub EnsureImageColumns()

        If listingTable Is Nothing Then Return

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
    ' FORM LOAD
    '========================================

    Private Sub Listing_Images_Load(
        sender As Object,
        e As EventArgs
    ) Handles MyBase.Load

        ConfigurePictureBoxes()

        If listingTable Is Nothing Then
            listingTable = User_dash.Listings
        End If

        EnsureImageColumns()

        PopulateListings()

    End Sub

    '========================================
    ' CONFIGURE IMAGE PREVIEWS
    '========================================

    Private Sub ConfigurePictureBoxes()

        picImage1.SizeMode = PictureBoxSizeMode.Zoom
        picImage2.SizeMode = PictureBoxSizeMode.Zoom
        picImage3.SizeMode = PictureBoxSizeMode.Zoom

        ClearPictureBoxes()

    End Sub

    '========================================
    ' POPULATE LISTING DROPDOWN
    '========================================

    Private Sub PopulateListings()

        loadingListings = True

        Try

            cmbSelectListing.DataSource = Nothing
            cmbSelectListing.Items.Clear()

            If listingTable Is Nothing OrElse listingTable.Rows.Count = 0 Then

                ClearPictureBoxes()

                Return

            End If

            EnsureImageColumns()

            Dim displayTable As New DataTable()

            displayTable.Columns.Add("ListingID", GetType(Integer))
            displayTable.Columns.Add("DisplayText", GetType(String))

            For Each listing As DataRow In listingTable.Rows

                If listing.RowState = DataRowState.Deleted Then Continue For

                displayTable.Rows.Add(
                    Convert.ToInt32(listing("ListingID")),
                    "#" & listing("ListingID").ToString() &
                    " - " & listing("PlasticType").ToString() &
                    " (" & listing("Area").ToString() & ")"
                )

            Next

            cmbSelectListing.DisplayMember = "DisplayText"
            cmbSelectListing.ValueMember = "ListingID"
            cmbSelectListing.DataSource = displayTable

            cmbSelectListing.SelectedIndex = -1

            ClearPictureBoxes()

        Catch ex As Exception

            MessageBox.Show(
                "Unable to load your listings." &
                vbCrLf & vbCrLf & ex.Message,
                "Plasticash",
                MessageBoxButtons.OK,
                MessageBoxIcon.Error
            )

        Finally

            loadingListings = False

        End Try

    End Sub

    '========================================
    ' LISTING SELECTION CHANGED
    '========================================

    Private Sub cmbSelectListing_SelectedIndexChanged(
        sender As Object,
        e As EventArgs
    ) Handles cmbSelectListing.SelectedIndexChanged

        If loadingListings Then Return

        If cmbSelectListing.SelectedIndex = -1 Then

            ClearPictureBoxes()

            Return

        End If

        DisplayListingImages()

    End Sub

    '========================================
    ' GET SELECTED LISTING
    '========================================

    Private Function GetSelectedListing() As DataRow

        If listingTable Is Nothing Then Return Nothing

        If cmbSelectListing.SelectedIndex = -1 Then Return Nothing

        If cmbSelectListing.SelectedValue Is Nothing Then Return Nothing

        Dim selectedID As Integer

        If Not Integer.TryParse(
            cmbSelectListing.SelectedValue.ToString(),
            selectedID
        ) Then

            Return Nothing

        End If

        For Each listing As DataRow In listingTable.Rows

            If listing.RowState = DataRowState.Deleted Then Continue For

            If Convert.ToInt32(listing("ListingID")) = selectedID Then

                Return listing

            End If

        Next

        Return Nothing

    End Function

    '========================================
    ' DISPLAY SELECTED LISTING IMAGES
    '========================================

    Private Sub DisplayListingImages()

        Dim selectedListing As DataRow = GetSelectedListing()

        If selectedListing Is Nothing Then

            ClearPictureBoxes()

            Return

        End If

        EnsureImageColumns()

        DisplayImage(selectedListing, "Image1", picImage1)
        DisplayImage(selectedListing, "Image2", picImage2)
        DisplayImage(selectedListing, "Image3", picImage3)

    End Sub

    '========================================
    ' DISPLAY ONE IMAGE
    '========================================

    Private Sub DisplayImage(
        listing As DataRow,
        columnName As String,
        picture As PictureBox
    )

        Try

            If picture.Image IsNot Nothing Then

                picture.Image.Dispose()
                picture.Image = Nothing

            End If

            If Not listing.Table.Columns.Contains(columnName) Then Return

            If listing.IsNull(columnName) Then Return

            Dim imageBytes As Byte() =
                DirectCast(listing(columnName), Byte())

            If imageBytes Is Nothing OrElse imageBytes.Length = 0 Then Return

            Using stream As New MemoryStream(imageBytes)

                Using originalImage As Image = Image.FromStream(stream)

                    picture.Image = New Bitmap(originalImage)

                End Using

            End Using

        Catch ex As Exception

            MessageBox.Show(
                "Unable to display " & columnName & "." &
                vbCrLf & vbCrLf & ex.Message,
                "Plasticash",
                MessageBoxButtons.OK,
                MessageBoxIcon.Error
            )

        End Try

    End Sub

    '========================================
    ' UPLOAD IMAGE 1
    '========================================

    Private Sub btnUpload1_Click(
        sender As Object,
        e As EventArgs
    ) Handles btnUpload1.Click

        UploadImage("Image1", picImage1)

    End Sub

    '========================================
    ' UPLOAD IMAGE 2
    '========================================

    Private Sub btnUpload2_Click(
        sender As Object,
        e As EventArgs
    ) Handles btnUpload2.Click

        UploadImage("Image2", picImage2)

    End Sub

    '========================================
    ' UPLOAD IMAGE 3
    '========================================

    Private Sub btnUpload3_Click(
        sender As Object,
        e As EventArgs
    ) Handles btnUpload3.Click

        UploadImage("Image3", picImage3)

    End Sub

    '========================================
    ' GENERAL IMAGE UPLOAD FUNCTION
    '========================================

    Private Sub UploadImage(
        columnName As String,
        picture As PictureBox
    )

        If listingTable Is Nothing Then

            MessageBox.Show(
                "Listing information is unavailable. Please return to the dashboard and try again.",
                "Plasticash",
                MessageBoxButtons.OK,
                MessageBoxIcon.Warning
            )

            Return

        End If

        EnsureImageColumns()

        Dim selectedListing As DataRow = GetSelectedListing()

        If selectedListing Is Nothing Then

            MessageBox.Show(
                "Please select a listing first.",
                "Plasticash",
                MessageBoxButtons.OK,
                MessageBoxIcon.Warning
            )

            Return

        End If

        Using openFile As New OpenFileDialog()

            openFile.Title = "Select Listing Image"
            openFile.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp;*.gif"
            openFile.Multiselect = False

            If openFile.ShowDialog() <> DialogResult.OK Then Return

            Try

                Dim imageBytes As Byte() =
                    File.ReadAllBytes(openFile.FileName)

                If imageBytes.Length > 5 * 1024 * 1024 Then

                    MessageBox.Show(
                        "The image is too large. Please select an image below 5 MB.",
                        "Plasticash",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning
                    )

                    Return

                End If

                Using stream As New MemoryStream(imageBytes)

                    Using testImage As Image = Image.FromStream(stream)

                        ' Validate image file

                    End Using

                End Using

                selectedListing(columnName) = imageBytes

                DisplayImage(selectedListing, columnName, picture)

                MessageBox.Show(
                    "Image uploaded successfully.",
                    "Plasticash",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information
                )

            Catch ex As Exception

                MessageBox.Show(
                    "Unable to upload this image." &
                    vbCrLf & vbCrLf & ex.Message,
                    "Plasticash",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                )

            End Try

        End Using

    End Sub

    '========================================
    ' REMOVE IMAGE 1
    '========================================

    Private Sub btnRemove1_Click(
        sender As Object,
        e As EventArgs
    ) Handles btnRemove1.Click

        RemoveImage("Image1", picImage1)

    End Sub

    '========================================
    ' REMOVE IMAGE 2
    '========================================

    Private Sub btnRemove2_Click(
        sender As Object,
        e As EventArgs
    ) Handles btnRemove2.Click

        RemoveImage("Image2", picImage2)

    End Sub

    '========================================
    ' REMOVE IMAGE 3
    '========================================

    Private Sub btnRemove3_Click(
        sender As Object,
        e As EventArgs
    ) Handles btnRemove3.Click

        RemoveImage("Image3", picImage3)

    End Sub

    '========================================
    ' GENERAL IMAGE REMOVE FUNCTION
    '========================================

    Private Sub RemoveImage(
        columnName As String,
        picture As PictureBox
    )

        Dim selectedListing As DataRow = GetSelectedListing()

        If selectedListing Is Nothing Then

            MessageBox.Show(
                "Please select a listing first.",
                "Plasticash",
                MessageBoxButtons.OK,
                MessageBoxIcon.Warning
            )

            Return

        End If

        If selectedListing.IsNull(columnName) Then

            MessageBox.Show(
                "There is no image to remove from this slot.",
                "Plasticash",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information
            )

            Return

        End If

        Dim result As DialogResult = MessageBox.Show(
            "Are you sure you want to remove this image?",
            "Remove Image",
            MessageBoxButtons.YesNo,
            MessageBoxIcon.Question
        )

        If result = DialogResult.Yes Then

            selectedListing(columnName) = DBNull.Value

            If picture.Image IsNot Nothing Then

                picture.Image.Dispose()
                picture.Image = Nothing

            End If

            MessageBox.Show(
                "Image removed successfully.",
                "Plasticash",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information
            )

        End If

    End Sub

    '========================================
    ' CLEAR ALL IMAGE PREVIEWS
    '========================================

    Private Sub ClearPictureBoxes()

        If picImage1.Image IsNot Nothing Then

            picImage1.Image.Dispose()
            picImage1.Image = Nothing

        End If

        If picImage2.Image IsNot Nothing Then

            picImage2.Image.Dispose()
            picImage2.Image = Nothing

        End If

        If picImage3.Image IsNot Nothing Then

            picImage3.Image.Dispose()
            picImage3.Image = Nothing

        End If

    End Sub

    '========================================
    ' BACK BUTTON
    '========================================

    Private Sub btnBack_Click(
        sender As Object,
        e As EventArgs
    ) Handles btnBack.Click

        If TypeOf Me.Owner Is Manage_Listings Then

            Dim adminForm As Manage_Listings =
                DirectCast(Me.Owner, Manage_Listings)

            Me.Hide()

            adminForm.Show()
            adminForm.BringToFront()

        Else

            User_dash.Show()
            User_dash.BringToFront()

            Me.Hide()

        End If

    End Sub

End Class
