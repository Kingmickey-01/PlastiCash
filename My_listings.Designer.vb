<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class My_listings
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(My_listings))
        Label2 = New Label()
        lblGreet = New Label()
        PictureBox1 = New PictureBox()
        btnPayment = New Button()
        btnImages = New Button()
        btnListing = New Button()
        btn_Overview = New Button()
        Panel1 = New Panel()
        btnUpdateStatus = New Button()
        cmbListingStatus = New ComboBox()
        btnClearSearch = New Label()
        lblSearch = New Label()
        txtSearch = New TextBox()
        btnCancelEdit = New Button()
        btnSaveChanges = New Button()
        txtEditPrice = New TextBox()
        txtEditArea = New TextBox()
        txtEditQuantity = New TextBox()
        cmbEditPlasticType = New ComboBox()
        btnDeleteListing = New Button()
        btnEditListing = New Button()
        lblDetailStatus = New Label()
        lblDetailDate = New Label()
        lblDetailTotal = New Label()
        lblDetailPrice = New Label()
        lblDetailArea = New Label()
        lblDetailPlasticType = New Label()
        lblDetailQuantity = New Label()
        lblDetailID = New Label()
        dgvListings = New DataGridView()
        SplitContainer1 = New SplitContainer()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        Panel1.SuspendLayout()
        CType(dgvListings, ComponentModel.ISupportInitialize).BeginInit()
        CType(SplitContainer1, ComponentModel.ISupportInitialize).BeginInit()
        SplitContainer1.Panel1.SuspendLayout()
        SplitContainer1.Panel2.SuspendLayout()
        SplitContainer1.SuspendLayout()
        SuspendLayout()
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI", 12F)
        Label2.Location = New Point(38, 79)
        Label2.Name = "Label2"
        Label2.Size = New Size(373, 32)
        Label2.TabIndex = 10
        Label2.Text = "You can find all your listings here."
        ' 
        ' lblGreet
        ' 
        lblGreet.AutoSize = True
        lblGreet.Font = New Font("Segoe UI", 26F, FontStyle.Bold)
        lblGreet.Location = New Point(29, 9)
        lblGreet.Name = "lblGreet"
        lblGreet.Size = New Size(244, 70)
        lblGreet.TabIndex = 9
        lblGreet.Text = "Hi there!"
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), Image)
        PictureBox1.Location = New Point(26, 12)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(289, 177)
        PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox1.TabIndex = 5
        PictureBox1.TabStop = False
        ' 
        ' btnPayment
        ' 
        btnPayment.FlatAppearance.BorderColor = Color.DarkGreen
        btnPayment.FlatStyle = FlatStyle.Flat
        btnPayment.Font = New Font("Segoe UI", 10F)
        btnPayment.ForeColor = SystemColors.ButtonHighlight
        btnPayment.Location = New Point(26, 415)
        btnPayment.Name = "btnPayment"
        btnPayment.Size = New Size(289, 72)
        btnPayment.TabIndex = 3
        btnPayment.Text = "Transactions"
        btnPayment.UseVisualStyleBackColor = True
        ' 
        ' btnImages
        ' 
        btnImages.FlatAppearance.BorderColor = Color.DarkGreen
        btnImages.FlatStyle = FlatStyle.Flat
        btnImages.Font = New Font("Segoe UI", 10F)
        btnImages.ForeColor = SystemColors.ButtonHighlight
        btnImages.Location = New Point(26, 346)
        btnImages.Name = "btnImages"
        btnImages.Size = New Size(289, 72)
        btnImages.TabIndex = 2
        btnImages.Text = "Add Images"
        btnImages.UseVisualStyleBackColor = True
        ' 
        ' btnListing
        ' 
        btnListing.BackColor = Color.YellowGreen
        btnListing.FlatAppearance.BorderColor = Color.DarkGreen
        btnListing.FlatStyle = FlatStyle.Flat
        btnListing.Font = New Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnListing.ForeColor = SystemColors.ButtonHighlight
        btnListing.Location = New Point(26, 273)
        btnListing.Name = "btnListing"
        btnListing.Size = New Size(289, 72)
        btnListing.TabIndex = 1
        btnListing.Text = "My listings"
        btnListing.UseVisualStyleBackColor = False
        ' 
        ' btn_Overview
        ' 
        btn_Overview.BackColor = Color.Transparent
        btn_Overview.FlatAppearance.BorderColor = Color.DarkGreen
        btn_Overview.FlatStyle = FlatStyle.Flat
        btn_Overview.Font = New Font("Segoe UI", 10F)
        btn_Overview.ForeColor = Color.White
        btn_Overview.Location = New Point(26, 195)
        btn_Overview.Name = "btn_Overview"
        btn_Overview.Size = New Size(289, 72)
        btn_Overview.TabIndex = 0
        btn_Overview.Text = "Overview"
        btn_Overview.UseVisualStyleBackColor = False
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.White
        Panel1.Controls.Add(btnUpdateStatus)
        Panel1.Controls.Add(cmbListingStatus)
        Panel1.Controls.Add(btnClearSearch)
        Panel1.Controls.Add(lblSearch)
        Panel1.Controls.Add(txtSearch)
        Panel1.Controls.Add(btnCancelEdit)
        Panel1.Controls.Add(btnSaveChanges)
        Panel1.Controls.Add(txtEditPrice)
        Panel1.Controls.Add(txtEditArea)
        Panel1.Controls.Add(txtEditQuantity)
        Panel1.Controls.Add(cmbEditPlasticType)
        Panel1.Controls.Add(btnDeleteListing)
        Panel1.Controls.Add(btnEditListing)
        Panel1.Controls.Add(lblDetailStatus)
        Panel1.Controls.Add(lblDetailDate)
        Panel1.Controls.Add(lblDetailTotal)
        Panel1.Controls.Add(lblDetailPrice)
        Panel1.Controls.Add(lblDetailArea)
        Panel1.Controls.Add(lblDetailPlasticType)
        Panel1.Controls.Add(lblDetailQuantity)
        Panel1.Controls.Add(lblDetailID)
        Panel1.Controls.Add(dgvListings)
        Panel1.Location = New Point(3, 146)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(1060, 645)
        Panel1.TabIndex = 3
        ' 
        ' btnUpdateStatus
        ' 
        btnUpdateStatus.Font = New Font("Segoe UI", 9F, FontStyle.Bold)
        btnUpdateStatus.Location = New Point(858, 40)
        btnUpdateStatus.Name = "btnUpdateStatus"
        btnUpdateStatus.Size = New Size(163, 34)
        btnUpdateStatus.TabIndex = 21
        btnUpdateStatus.Text = "Update Status"
        btnUpdateStatus.UseVisualStyleBackColor = True
        ' 
        ' cmbListingStatus
        ' 
        cmbListingStatus.FormattingEnabled = True
        cmbListingStatus.Items.AddRange(New Object() {"Available", "Reserved", "Collected", "Cancelled."})
        cmbListingStatus.Location = New Point(670, 41)
        cmbListingStatus.Name = "cmbListingStatus"
        cmbListingStatus.Size = New Size(182, 33)
        cmbListingStatus.TabIndex = 20
        ' 
        ' btnClearSearch
        ' 
        btnClearSearch.AutoSize = True
        btnClearSearch.Location = New Point(503, 52)
        btnClearSearch.Name = "btnClearSearch"
        btnClearSearch.Size = New Size(37, 25)
        btnClearSearch.TabIndex = 19
        btnClearSearch.Text = "❌"
        ' 
        ' lblSearch
        ' 
        lblSearch.AutoSize = True
        lblSearch.Location = New Point(44, 49)
        lblSearch.Name = "lblSearch"
        lblSearch.Size = New Size(37, 25)
        lblSearch.TabIndex = 18
        lblSearch.Text = "🔎"
        ' 
        ' txtSearch
        ' 
        txtSearch.BackColor = SystemColors.ControlDark
        txtSearch.Location = New Point(87, 46)
        txtSearch.Name = "txtSearch"
        txtSearch.Size = New Size(410, 31)
        txtSearch.TabIndex = 17
        ' 
        ' btnCancelEdit
        ' 
        btnCancelEdit.Location = New Point(913, 563)
        btnCancelEdit.Name = "btnCancelEdit"
        btnCancelEdit.Size = New Size(112, 34)
        btnCancelEdit.TabIndex = 16
        btnCancelEdit.Text = "Cancel"
        btnCancelEdit.UseVisualStyleBackColor = True
        ' 
        ' btnSaveChanges
        ' 
        btnSaveChanges.Location = New Point(795, 563)
        btnSaveChanges.Name = "btnSaveChanges"
        btnSaveChanges.Size = New Size(112, 34)
        btnSaveChanges.TabIndex = 15
        btnSaveChanges.Text = "Save "
        btnSaveChanges.UseVisualStyleBackColor = True
        ' 
        ' txtEditPrice
        ' 
        txtEditPrice.Location = New Point(442, 563)
        txtEditPrice.Name = "txtEditPrice"
        txtEditPrice.Size = New Size(347, 31)
        txtEditPrice.TabIndex = 14
        ' 
        ' txtEditArea
        ' 
        txtEditArea.Location = New Point(26, 563)
        txtEditArea.Name = "txtEditArea"
        txtEditArea.Size = New Size(410, 31)
        txtEditArea.TabIndex = 13
        ' 
        ' txtEditQuantity
        ' 
        txtEditQuantity.Location = New Point(442, 521)
        txtEditQuantity.Name = "txtEditQuantity"
        txtEditQuantity.Size = New Size(347, 31)
        txtEditQuantity.TabIndex = 12
        ' 
        ' cmbEditPlasticType
        ' 
        cmbEditPlasticType.FormattingEnabled = True
        cmbEditPlasticType.Location = New Point(26, 519)
        cmbEditPlasticType.Name = "cmbEditPlasticType"
        cmbEditPlasticType.Size = New Size(410, 33)
        cmbEditPlasticType.TabIndex = 11
        ' 
        ' btnDeleteListing
        ' 
        btnDeleteListing.Location = New Point(913, 521)
        btnDeleteListing.Name = "btnDeleteListing"
        btnDeleteListing.Size = New Size(112, 34)
        btnDeleteListing.TabIndex = 10
        btnDeleteListing.Text = "Delete❌"
        btnDeleteListing.UseVisualStyleBackColor = True
        ' 
        ' btnEditListing
        ' 
        btnEditListing.Location = New Point(795, 521)
        btnEditListing.Name = "btnEditListing"
        btnEditListing.Size = New Size(112, 34)
        btnEditListing.TabIndex = 9
        btnEditListing.Text = "Edit🖋️"
        btnEditListing.UseVisualStyleBackColor = True
        ' 
        ' lblDetailStatus
        ' 
        lblDetailStatus.AutoSize = True
        lblDetailStatus.ForeColor = Color.White
        lblDetailStatus.Location = New Point(823, 9)
        lblDetailStatus.Name = "lblDetailStatus"
        lblDetailStatus.Size = New Size(115, 25)
        lblDetailStatus.TabIndex = 8
        lblDetailStatus.Text = "Listing status"
        ' 
        ' lblDetailDate
        ' 
        lblDetailDate.AutoSize = True
        lblDetailDate.ForeColor = Color.White
        lblDetailDate.Location = New Point(707, 9)
        lblDetailDate.Name = "lblDetailDate"
        lblDetailDate.Size = New Size(110, 25)
        lblDetailDate.TabIndex = 7
        lblDetailDate.Text = "Date posted"
        ' 
        ' lblDetailTotal
        ' 
        lblDetailTotal.AutoSize = True
        lblDetailTotal.ForeColor = Color.White
        lblDetailTotal.Location = New Point(553, 9)
        lblDetailTotal.Name = "lblDetailTotal"
        lblDetailTotal.Size = New Size(148, 25)
        lblDetailTotal.TabIndex = 6
        lblDetailTotal.Text = "Total asking price"
        ' 
        ' lblDetailPrice
        ' 
        lblDetailPrice.AutoSize = True
        lblDetailPrice.ForeColor = Color.White
        lblDetailPrice.Location = New Point(442, 9)
        lblDetailPrice.Name = "lblDetailPrice"
        lblDetailPrice.Size = New Size(105, 25)
        lblDetailPrice.TabIndex = 5
        lblDetailPrice.Text = "Price per kg"
        ' 
        ' lblDetailArea
        ' 
        lblDetailArea.AutoSize = True
        lblDetailArea.ForeColor = Color.White
        lblDetailArea.Location = New Point(308, 9)
        lblDetailArea.Name = "lblDetailArea"
        lblDetailArea.Size = New Size(128, 25)
        lblDetailArea.TabIndex = 4
        lblDetailArea.Text = "Collection area"
        ' 
        ' lblDetailPlasticType
        ' 
        lblDetailPlasticType.AutoSize = True
        lblDetailPlasticType.ForeColor = Color.White
        lblDetailPlasticType.Location = New Point(118, 9)
        lblDetailPlasticType.Name = "lblDetailPlasticType"
        lblDetailPlasticType.Size = New Size(101, 25)
        lblDetailPlasticType.TabIndex = 3
        lblDetailPlasticType.Text = "Plastic type"
        ' 
        ' lblDetailQuantity
        ' 
        lblDetailQuantity.AutoSize = True
        lblDetailQuantity.ForeColor = Color.White
        lblDetailQuantity.Location = New Point(222, 9)
        lblDetailQuantity.Name = "lblDetailQuantity"
        lblDetailQuantity.Size = New Size(80, 25)
        lblDetailQuantity.TabIndex = 2
        lblDetailQuantity.Text = "Quantity"
        ' 
        ' lblDetailID
        ' 
        lblDetailID.AutoSize = True
        lblDetailID.ForeColor = Color.White
        lblDetailID.Location = New Point(26, 9)
        lblDetailID.Name = "lblDetailID"
        lblDetailID.Size = New Size(86, 25)
        lblDetailID.TabIndex = 1
        lblDetailID.Text = "Listing ID"
        ' 
        ' dgvListings
        ' 
        dgvListings.AllowUserToAddRows = False
        dgvListings.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        dgvListings.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgvListings.Location = New Point(17, 80)
        dgvListings.MultiSelect = False
        dgvListings.Name = "dgvListings"
        dgvListings.ReadOnly = True
        dgvListings.RowHeadersWidth = 62
        dgvListings.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        dgvListings.Size = New Size(1023, 525)
        dgvListings.TabIndex = 0
        ' 
        ' SplitContainer1
        ' 
        SplitContainer1.Dock = DockStyle.Fill
        SplitContainer1.Location = New Point(0, 0)
        SplitContainer1.Name = "SplitContainer1"
        ' 
        ' SplitContainer1.Panel1
        ' 
        SplitContainer1.Panel1.BackColor = Color.DarkGreen
        SplitContainer1.Panel1.Controls.Add(PictureBox1)
        SplitContainer1.Panel1.Controls.Add(btnPayment)
        SplitContainer1.Panel1.Controls.Add(btnImages)
        SplitContainer1.Panel1.Controls.Add(btnListing)
        SplitContainer1.Panel1.Controls.Add(btn_Overview)
        ' 
        ' SplitContainer1.Panel2
        ' 
        SplitContainer1.Panel2.Controls.Add(Label2)
        SplitContainer1.Panel2.Controls.Add(lblGreet)
        SplitContainer1.Panel2.Controls.Add(Panel1)
        SplitContainer1.Size = New Size(1428, 794)
        SplitContainer1.SplitterDistance = 349
        SplitContainer1.TabIndex = 2
        ' 
        ' My_listings
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1428, 794)
        Controls.Add(SplitContainer1)
        Name = "My_listings"
        Text = "My_listings"
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        CType(dgvListings, ComponentModel.ISupportInitialize).EndInit()
        SplitContainer1.Panel1.ResumeLayout(False)
        SplitContainer1.Panel2.ResumeLayout(False)
        SplitContainer1.Panel2.PerformLayout()
        CType(SplitContainer1, ComponentModel.ISupportInitialize).EndInit()
        SplitContainer1.ResumeLayout(False)
        ResumeLayout(False)
    End Sub
    Friend WithEvents Label2 As Label
    Friend WithEvents lblGreet As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents btnPayment As Button
    Friend WithEvents btnImages As Button
    Friend WithEvents btnListing As Button
    Friend WithEvents btn_Overview As Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents SplitContainer1 As SplitContainer
    Friend WithEvents dgvListings As DataGridView
    Friend WithEvents btnEditListing As Button
    Friend WithEvents btnDeleteListing As Button
    Friend WithEvents cmbEditPlasticType As ComboBox
    Friend WithEvents btnCancelEdit As Button
    Friend WithEvents btnSaveChanges As Button
    Friend WithEvents txtEditPrice As TextBox
    Friend WithEvents txtEditArea As TextBox
    Friend WithEvents txtEditQuantity As TextBox
    Friend WithEvents txtSearch As TextBox
    Friend WithEvents lblDetailStatus As Label
    Friend WithEvents lblDetailDate As Label
    Friend WithEvents lblDetailTotal As Label
    Friend WithEvents lblDetailPrice As Label
    Friend WithEvents lblDetailArea As Label
    Friend WithEvents lblDetailPlasticType As Label
    Friend WithEvents lblDetailQuantity As Label
    Friend WithEvents lblDetailID As Label
    Friend WithEvents lblSearch As Label
    Friend WithEvents btnClearSearch As Label
    Friend WithEvents btnUpdateStatus As Button
    Friend WithEvents cmbListingStatus As ComboBox
End Class
