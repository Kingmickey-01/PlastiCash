<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Manage_Listings
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Manage_Listings))
        Panel1 = New Panel()
        lblTotalListings = New Label()
        Label3 = New Label()
        Label7 = New Label()
        Panel2 = New Panel()
        lblPending = New Label()
        Label1 = New Label()
        Label8 = New Label()
        Panel3 = New Panel()
        lblApproved = New Label()
        Label2 = New Label()
        Label9 = New Label()
        dgvManageListings = New DataGridView()
        btnViewDetails = New Button()
        btnRemove = New Button()
        btnFlag = New Button()
        btnReject = New Button()
        btnApprove = New Button()
        btnBack = New Button()
        btnRefresh = New Button()
        Panel4 = New Panel()
        Label12 = New Label()
        txtSearch = New TextBox()
        cmbPlasticFilter = New ComboBox()
        cmbStatusFilter = New ComboBox()
        Label11 = New Label()
        Label10 = New Label()
        lblTitle = New Label()
        Label14 = New Label()
        PictureBox1 = New PictureBox()
        btnViewImages = New Button()
        Panel1.SuspendLayout()
        Panel2.SuspendLayout()
        Panel3.SuspendLayout()
        CType(dgvManageListings, ComponentModel.ISupportInitialize).BeginInit()
        Panel4.SuspendLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Panel1
        ' 
        Panel1.Controls.Add(lblTotalListings)
        Panel1.Controls.Add(Label3)
        Panel1.Controls.Add(Label7)
        Panel1.Location = New Point(718, 57)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(257, 110)
        Panel1.TabIndex = 0
        ' 
        ' lblTotalListings
        ' 
        lblTotalListings.AutoSize = True
        lblTotalListings.Font = New Font("Segoe UI", 20.0F)
        lblTotalListings.Location = New Point(106, 48)
        lblTotalListings.Name = "lblTotalListings"
        lblTotalListings.Size = New Size(39, 54)
        lblTotalListings.TabIndex = 5
        lblTotalListings.Text = "-"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Segoe UI", 10.0F, FontStyle.Bold)
        Label3.Location = New Point(106, 23)
        Label3.Name = "Label3"
        Label3.Size = New Size(137, 28)
        Label3.TabIndex = 2
        Label3.Text = "Total Listings"
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.BackColor = Color.Transparent
        Label7.FlatStyle = FlatStyle.Flat
        Label7.Font = New Font("Segoe UI", 30.0F)
        Label7.ForeColor = Color.DarkGreen
        Label7.ImageAlign = ContentAlignment.MiddleLeft
        Label7.Location = New Point(3, 7)
        Label7.Name = "Label7"
        Label7.Size = New Size(117, 81)
        Label7.TabIndex = 5
        Label7.Text = "📜"
        ' 
        ' Panel2
        ' 
        Panel2.BackColor = Color.Moccasin
        Panel2.Controls.Add(lblPending)
        Panel2.Controls.Add(Label1)
        Panel2.Controls.Add(Label8)
        Panel2.Location = New Point(997, 56)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(261, 110)
        Panel2.TabIndex = 1
        ' 
        ' lblPending
        ' 
        lblPending.AutoSize = True
        lblPending.Font = New Font("Segoe UI", 20.0F)
        lblPending.Location = New Point(96, 51)
        lblPending.Name = "lblPending"
        lblPending.Size = New Size(39, 54)
        lblPending.TabIndex = 5
        lblPending.Text = "-"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 9.0F, FontStyle.Bold)
        Label1.Location = New Point(96, 26)
        Label1.Name = "Label1"
        Label1.Size = New Size(147, 25)
        Label1.TabIndex = 0
        Label1.Text = "Pending Review"
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.BackColor = Color.Transparent
        Label8.FlatStyle = FlatStyle.Flat
        Label8.Font = New Font("Segoe UI", 30.0F)
        Label8.ForeColor = Color.Black
        Label8.ImageAlign = ContentAlignment.MiddleLeft
        Label8.Location = New Point(1, 8)
        Label8.Name = "Label8"
        Label8.Size = New Size(117, 81)
        Label8.TabIndex = 6
        Label8.Text = "🕝"
        ' 
        ' Panel3
        ' 
        Panel3.BackColor = Color.LightGreen
        Panel3.Controls.Add(lblApproved)
        Panel3.Controls.Add(Label2)
        Panel3.Controls.Add(Label9)
        Panel3.Location = New Point(1285, 57)
        Panel3.Name = "Panel3"
        Panel3.Size = New Size(257, 110)
        Panel3.TabIndex = 2
        ' 
        ' lblApproved
        ' 
        lblApproved.AutoSize = True
        lblApproved.Font = New Font("Segoe UI", 20.0F)
        lblApproved.Location = New Point(101, 48)
        lblApproved.Name = "lblApproved"
        lblApproved.Size = New Size(39, 54)
        lblApproved.TabIndex = 5
        lblApproved.Text = "-"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI", 9.0F, FontStyle.Bold)
        Label2.Location = New Point(101, 23)
        Label2.Name = "Label2"
        Label2.Size = New Size(96, 25)
        Label2.TabIndex = 1
        Label2.Text = "Approved"
        ' 
        ' Label9
        ' 
        Label9.AutoSize = True
        Label9.BackColor = Color.Transparent
        Label9.FlatStyle = FlatStyle.Flat
        Label9.Font = New Font("Segoe UI", 30.0F)
        Label9.ForeColor = Color.DarkGreen
        Label9.ImageAlign = ContentAlignment.MiddleLeft
        Label9.Location = New Point(3, 3)
        Label9.Name = "Label9"
        Label9.Size = New Size(117, 81)
        Label9.TabIndex = 6
        Label9.Text = "✅"
        ' 
        ' dgvManageListings
        ' 
        dgvManageListings.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgvManageListings.Location = New Point(30, 265)
        dgvManageListings.Name = "dgvManageListings"
        dgvManageListings.RowHeadersWidth = 62
        dgvManageListings.Size = New Size(1509, 415)
        dgvManageListings.TabIndex = 8
        ' 
        ' btnViewDetails
        ' 
        btnViewDetails.BackColor = Color.DarkGreen
        btnViewDetails.FlatStyle = FlatStyle.Flat
        btnViewDetails.Font = New Font("Segoe UI", 9.0F, FontStyle.Bold)
        btnViewDetails.ForeColor = Color.White
        btnViewDetails.Location = New Point(30, 707)
        btnViewDetails.Name = "btnViewDetails"
        btnViewDetails.Size = New Size(275, 61)
        btnViewDetails.TabIndex = 9
        btnViewDetails.Text = "👁️View Details"
        btnViewDetails.UseVisualStyleBackColor = False
        ' 
        ' btnRemove
        ' 
        btnRemove.BackColor = Color.Red
        btnRemove.FlatStyle = FlatStyle.Flat
        btnRemove.Font = New Font("Segoe UI", 9.0F, FontStyle.Bold)
        btnRemove.ForeColor = Color.White
        btnRemove.Location = New Point(994, 707)
        btnRemove.Name = "btnRemove"
        btnRemove.Size = New Size(179, 61)
        btnRemove.TabIndex = 10
        btnRemove.Text = "🗑️Remove"
        btnRemove.UseVisualStyleBackColor = False
        ' 
        ' btnFlag
        ' 
        btnFlag.BackColor = Color.Orange
        btnFlag.FlatStyle = FlatStyle.Flat
        btnFlag.Font = New Font("Segoe UI", 9.0F, FontStyle.Bold)
        btnFlag.ForeColor = Color.White
        btnFlag.Location = New Point(693, 707)
        btnFlag.Name = "btnFlag"
        btnFlag.Size = New Size(295, 61)
        btnFlag.TabIndex = 11
        btnFlag.Text = "🚩Flag as Suspicious"
        btnFlag.UseVisualStyleBackColor = False
        ' 
        ' btnReject
        ' 
        btnReject.BackColor = Color.Red
        btnReject.FlatStyle = FlatStyle.Flat
        btnReject.Font = New Font("Segoe UI", 9.0F, FontStyle.Bold)
        btnReject.ForeColor = Color.White
        btnReject.Location = New Point(520, 707)
        btnReject.Name = "btnReject"
        btnReject.Size = New Size(166, 61)
        btnReject.TabIndex = 12
        btnReject.Text = "❌Reject"
        btnReject.UseVisualStyleBackColor = False
        ' 
        ' btnApprove
        ' 
        btnApprove.BackColor = Color.DarkGreen
        btnApprove.FlatStyle = FlatStyle.Flat
        btnApprove.Font = New Font("Segoe UI", 9.0F, FontStyle.Bold)
        btnApprove.ForeColor = Color.White
        btnApprove.Location = New Point(311, 707)
        btnApprove.Name = "btnApprove"
        btnApprove.Size = New Size(202, 61)
        btnApprove.TabIndex = 13
        btnApprove.Text = "Approve"
        btnApprove.UseVisualStyleBackColor = False
        ' 
        ' btnBack
        ' 
        btnBack.BackColor = SystemColors.ControlDark
        btnBack.FlatStyle = FlatStyle.Flat
        btnBack.Font = New Font("Segoe UI", 20.0F, FontStyle.Bold)
        btnBack.ForeColor = Color.Black
        btnBack.Location = New Point(1397, 707)
        btnBack.Name = "btnBack"
        btnBack.Size = New Size(145, 61)
        btnBack.TabIndex = 14
        btnBack.Text = "🔙"
        btnBack.UseVisualStyleBackColor = False
        ' 
        ' btnRefresh
        ' 
        btnRefresh.BackColor = Color.DarkGreen
        btnRefresh.FlatStyle = FlatStyle.Flat
        btnRefresh.Font = New Font("Segoe UI", 9.0F, FontStyle.Bold)
        btnRefresh.ForeColor = Color.White
        btnRefresh.Location = New Point(1180, 707)
        btnRefresh.Name = "btnRefresh"
        btnRefresh.Size = New Size(201, 61)
        btnRefresh.TabIndex = 15
        btnRefresh.Text = "🔄️Refresh"
        btnRefresh.UseVisualStyleBackColor = False
        ' 
        ' Panel4
        ' 
        Panel4.BackColor = Color.LightGreen
        Panel4.Controls.Add(btnViewImages)
        Panel4.Controls.Add(Label12)
        Panel4.Controls.Add(txtSearch)
        Panel4.Controls.Add(cmbPlasticFilter)
        Panel4.Controls.Add(cmbStatusFilter)
        Panel4.Controls.Add(Label11)
        Panel4.Controls.Add(Label10)
        Panel4.Location = New Point(30, 200)
        Panel4.Name = "Panel4"
        Panel4.Size = New Size(1512, 59)
        Panel4.TabIndex = 16
        ' 
        ' Label12
        ' 
        Label12.AutoSize = True
        Label12.Location = New Point(783, 22)
        Label12.Name = "Label12"
        Label12.Size = New Size(38, 25)
        Label12.TabIndex = 13
        Label12.Text = "🔍"
        ' 
        ' txtSearch
        ' 
        txtSearch.Location = New Point(821, 20)
        txtSearch.Name = "txtSearch"
        txtSearch.Size = New Size(430, 31)
        txtSearch.TabIndex = 12
        ' 
        ' cmbPlasticFilter
        ' 
        cmbPlasticFilter.FormattingEnabled = True
        cmbPlasticFilter.Location = New Point(548, 19)
        cmbPlasticFilter.Name = "cmbPlasticFilter"
        cmbPlasticFilter.Size = New Size(234, 33)
        cmbPlasticFilter.TabIndex = 10
        ' 
        ' cmbStatusFilter
        ' 
        cmbStatusFilter.FormattingEnabled = True
        cmbStatusFilter.Location = New Point(168, 18)
        cmbStatusFilter.Name = "cmbStatusFilter"
        cmbStatusFilter.Size = New Size(248, 33)
        cmbStatusFilter.TabIndex = 11
        ' 
        ' Label11
        ' 
        Label11.AutoSize = True
        Label11.Location = New Point(424, 22)
        Label11.Name = "Label11"
        Label11.Size = New Size(118, 25)
        Label11.TabIndex = 8
        Label11.Text = "Plastic Type:"
        ' 
        ' Label10
        ' 
        Label10.AutoSize = True
        Label10.Location = New Point(91, 21)
        Label10.Name = "Label10"
        Label10.Size = New Size(70, 25)
        Label10.TabIndex = 9
        Label10.Text = "Status:"
        ' 
        ' lblTitle
        ' 
        lblTitle.AutoSize = True
        lblTitle.Font = New Font("Segoe UI", 30.0F, FontStyle.Bold)
        lblTitle.Location = New Point(192, 35)
        lblTitle.Name = "lblTitle"
        lblTitle.Size = New Size(491, 81)
        lblTitle.TabIndex = 6
        lblTitle.Text = "Manage Listings"
        ' 
        ' Label14
        ' 
        Label14.AutoSize = True
        Label14.Font = New Font("Segoe UI", 10.0F)
        Label14.Location = New Point(210, 117)
        Label14.Name = "Label14"
        Label14.Size = New Size(276, 28)
        Label14.TabIndex = 17
        Label14.Text = "Review and manage all listings"
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), Image)
        PictureBox1.Location = New Point(2, 29)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(189, 148)
        PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox1.TabIndex = 18
        PictureBox1.TabStop = False
        ' 
        ' btnViewImages
        ' 
        btnViewImages.BackColor = Color.DarkGreen
        btnViewImages.FlatStyle = FlatStyle.Flat
        btnViewImages.Font = New Font("Segoe UI", 9.0F, FontStyle.Bold)
        btnViewImages.ForeColor = Color.White
        btnViewImages.Location = New Point(1272, 2)
        btnViewImages.Name = "btnViewImages"
        btnViewImages.Size = New Size(238, 56)
        btnViewImages.TabIndex = 14
        btnViewImages.Text = "View Images"
        btnViewImages.UseVisualStyleBackColor = False
        ' 
        ' Manage_Listings
        ' 
        AutoScaleDimensions = New SizeF(11.0F, 25.0F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1571, 794)
        Controls.Add(PictureBox1)
        Controls.Add(Label14)
        Controls.Add(Panel4)
        Controls.Add(btnRefresh)
        Controls.Add(btnBack)
        Controls.Add(btnApprove)
        Controls.Add(btnReject)
        Controls.Add(btnFlag)
        Controls.Add(btnRemove)
        Controls.Add(btnViewDetails)
        Controls.Add(dgvManageListings)
        Controls.Add(Panel3)
        Controls.Add(Panel2)
        Controls.Add(Panel1)
        Controls.Add(lblTitle)
        Font = New Font("Segoe UI", 9.0F, FontStyle.Bold)
        Name = "Manage_Listings"
        Text = "Manage_Listings"
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        Panel2.ResumeLayout(False)
        Panel2.PerformLayout()
        Panel3.ResumeLayout(False)
        Panel3.PerformLayout()
        CType(dgvManageListings, ComponentModel.ISupportInitialize).EndInit()
        Panel4.ResumeLayout(False)
        Panel4.PerformLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Label7 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents lblApproved As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents lblTotalListings As Label
    Friend WithEvents lblPending As Label
    Friend WithEvents dgvManageListings As DataGridView
    Friend WithEvents btnViewDetails As Button
    Friend WithEvents btnRemove As Button
    Friend WithEvents btnFlag As Button
    Friend WithEvents btnReject As Button
    Friend WithEvents btnApprove As Button
    Friend WithEvents btnBack As Button
    Friend WithEvents btnRefresh As Button
    Friend WithEvents Panel4 As Panel
    Friend WithEvents Label12 As Label
    Friend WithEvents txtSearch As TextBox
    Friend WithEvents cmbPlasticFilter As ComboBox
    Friend WithEvents cmbStatusFilter As ComboBox
    Friend WithEvents Label11 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents lblTitle As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents lblListingID As Label
    Friend WithEvents lblPlasticType As Label
    Friend WithEvents lblPrice As Label
    Friend WithEvents lblArea As Label
    Friend WithEvents lblListingStatus As Label
    Friend WithEvents lblQuantity As Label
    Friend WithEvents lblAdminStatus As Label
    Friend WithEvents lblTotalPrice As Label
    Friend WithEvents btnViewImages As Button
    Friend WithEvents lblDatePosted As Label
End Class
