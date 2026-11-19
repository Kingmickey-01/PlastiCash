<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Company_Profiile
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Company_Profiile))
        btnListing = New Button()
        btn_Overview = New Button()
        btnExit = New Button()
        SplitContainer1 = New SplitContainer()
        PictureBox1 = New PictureBox()
        btnPost = New Button()
        Label12 = New Label()
        Label11 = New Label()
        btnSaveChanges = New Button()
        btnCancel = New Button()
        btnBack = New Button()
        btnEditProfile = New Button()
        Label7 = New Label()
        Label8 = New Label()
        Label9 = New Label()
        Label10 = New Label()
        lblAdminRole = New TextBox()
        txtAdminEmail = New TextBox()
        txtAdminUsername = New TextBox()
        txtAdminName = New TextBox()
        Label6 = New Label()
        Label5 = New Label()
        Label4 = New Label()
        Label3 = New Label()
        Label2 = New Label()
        Label1 = New Label()
        txtCompanyDescription = New TextBox()
        txtCompanyWebsite = New TextBox()
        txtCompanyAddress = New TextBox()
        txtCompanyPhone = New TextBox()
        txtCompanyEmail = New TextBox()
        txtCompanyName = New TextBox()
        btnRemoveLogo = New Button()
        btnUploadLogo = New Button()
        picCompanyLogo = New PictureBox()
        CType(SplitContainer1, ComponentModel.ISupportInitialize).BeginInit()
        SplitContainer1.Panel1.SuspendLayout()
        SplitContainer1.Panel2.SuspendLayout()
        SplitContainer1.SuspendLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        CType(picCompanyLogo, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' btnListing
        ' 
        btnListing.BackColor = Color.DarkGreen
        btnListing.FlatAppearance.BorderColor = Color.DarkGreen
        btnListing.FlatStyle = FlatStyle.Flat
        btnListing.Font = New Font("Segoe UI", 10F)
        btnListing.ForeColor = Color.White
        btnListing.Location = New Point(29, 273)
        btnListing.Name = "btnListing"
        btnListing.Size = New Size(289, 72)
        btnListing.TabIndex = 1
        btnListing.Text = "Manage Listings"
        btnListing.TextAlign = ContentAlignment.MiddleLeft
        btnListing.UseVisualStyleBackColor = False
        ' 
        ' btn_Overview
        ' 
        btn_Overview.BackColor = Color.DarkGreen
        btn_Overview.FlatAppearance.BorderColor = Color.DarkGreen
        btn_Overview.FlatStyle = FlatStyle.Flat
        btn_Overview.Font = New Font("Segoe UI", 10F)
        btn_Overview.ForeColor = Color.White
        btn_Overview.Location = New Point(29, 195)
        btn_Overview.Name = "btn_Overview"
        btn_Overview.Size = New Size(289, 72)
        btn_Overview.TabIndex = 0
        btn_Overview.Text = "Dashboard"
        btn_Overview.TextAlign = ContentAlignment.MiddleLeft
        btn_Overview.UseVisualStyleBackColor = False
        ' 
        ' btnExit
        ' 
        btnExit.FlatAppearance.BorderColor = Color.DarkGreen
        btnExit.FlatStyle = FlatStyle.Flat
        btnExit.Font = New Font("Segoe UI", 10F)
        btnExit.ForeColor = SystemColors.ButtonHighlight
        btnExit.ImageAlign = ContentAlignment.MiddleLeft
        btnExit.Location = New Point(29, 709)
        btnExit.Name = "btnExit"
        btnExit.Size = New Size(289, 72)
        btnExit.TabIndex = 7
        btnExit.Text = "Logout🚪"
        btnExit.UseVisualStyleBackColor = True
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
        SplitContainer1.Panel1.Controls.Add(btnExit)
        SplitContainer1.Panel1.Controls.Add(PictureBox1)
        SplitContainer1.Panel1.Controls.Add(btnPost)
        SplitContainer1.Panel1.Controls.Add(btnListing)
        SplitContainer1.Panel1.Controls.Add(btn_Overview)
        ' 
        ' SplitContainer1.Panel2
        ' 
        SplitContainer1.Panel2.Controls.Add(Label12)
        SplitContainer1.Panel2.Controls.Add(Label11)
        SplitContainer1.Panel2.Controls.Add(btnSaveChanges)
        SplitContainer1.Panel2.Controls.Add(btnCancel)
        SplitContainer1.Panel2.Controls.Add(btnBack)
        SplitContainer1.Panel2.Controls.Add(btnEditProfile)
        SplitContainer1.Panel2.Controls.Add(Label7)
        SplitContainer1.Panel2.Controls.Add(Label8)
        SplitContainer1.Panel2.Controls.Add(Label9)
        SplitContainer1.Panel2.Controls.Add(Label10)
        SplitContainer1.Panel2.Controls.Add(lblAdminRole)
        SplitContainer1.Panel2.Controls.Add(txtAdminEmail)
        SplitContainer1.Panel2.Controls.Add(txtAdminUsername)
        SplitContainer1.Panel2.Controls.Add(txtAdminName)
        SplitContainer1.Panel2.Controls.Add(Label6)
        SplitContainer1.Panel2.Controls.Add(Label5)
        SplitContainer1.Panel2.Controls.Add(Label4)
        SplitContainer1.Panel2.Controls.Add(Label3)
        SplitContainer1.Panel2.Controls.Add(Label2)
        SplitContainer1.Panel2.Controls.Add(Label1)
        SplitContainer1.Panel2.Controls.Add(txtCompanyDescription)
        SplitContainer1.Panel2.Controls.Add(txtCompanyWebsite)
        SplitContainer1.Panel2.Controls.Add(txtCompanyAddress)
        SplitContainer1.Panel2.Controls.Add(txtCompanyPhone)
        SplitContainer1.Panel2.Controls.Add(txtCompanyEmail)
        SplitContainer1.Panel2.Controls.Add(txtCompanyName)
        SplitContainer1.Panel2.Controls.Add(btnRemoveLogo)
        SplitContainer1.Panel2.Controls.Add(btnUploadLogo)
        SplitContainer1.Panel2.Controls.Add(picCompanyLogo)
        SplitContainer1.Size = New Size(1428, 794)
        SplitContainer1.SplitterDistance = 349
        SplitContainer1.TabIndex = 3
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), Image)
        PictureBox1.Location = New Point(29, 12)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(289, 177)
        PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox1.TabIndex = 6
        PictureBox1.TabStop = False
        ' 
        ' btnPost
        ' 
        btnPost.BackColor = Color.YellowGreen
        btnPost.FlatAppearance.BorderColor = Color.DarkGreen
        btnPost.FlatStyle = FlatStyle.Flat
        btnPost.Font = New Font("Segoe UI", 10F, FontStyle.Bold)
        btnPost.ForeColor = Color.Black
        btnPost.Location = New Point(29, 351)
        btnPost.Name = "btnPost"
        btnPost.Size = New Size(289, 72)
        btnPost.TabIndex = 2
        btnPost.Text = "Company profile"
        btnPost.TextAlign = ContentAlignment.MiddleLeft
        btnPost.UseVisualStyleBackColor = False
        ' 
        ' Label12
        ' 
        Label12.AutoSize = True
        Label12.Font = New Font("Segoe UI", 10F)
        Label12.Location = New Point(25, 84)
        Label12.Name = "Label12"
        Label12.Size = New Size(450, 28)
        Label12.TabIndex = 36
        Label12.Text = "Enter and update your company information here!"
        ' 
        ' Label11
        ' 
        Label11.AutoSize = True
        Label11.Font = New Font("Segoe UI", 25F, FontStyle.Bold)
        Label11.Location = New Point(16, 17)
        Label11.Name = "Label11"
        Label11.Size = New Size(672, 67)
        Label11.TabIndex = 35
        Label11.Text = "PlastiCash Company Profile"
        ' 
        ' btnSaveChanges
        ' 
        btnSaveChanges.BackColor = Color.DarkGreen
        btnSaveChanges.FlatStyle = FlatStyle.Flat
        btnSaveChanges.Font = New Font("Segoe UI", 10F, FontStyle.Bold)
        btnSaveChanges.ForeColor = Color.White
        btnSaveChanges.Location = New Point(646, 630)
        btnSaveChanges.Name = "btnSaveChanges"
        btnSaveChanges.Size = New Size(395, 72)
        btnSaveChanges.TabIndex = 34
        btnSaveChanges.Text = "Save Changes"
        btnSaveChanges.UseVisualStyleBackColor = False
        ' 
        ' btnCancel
        ' 
        btnCancel.BackColor = Color.DarkGreen
        btnCancel.FlatStyle = FlatStyle.Flat
        btnCancel.Font = New Font("Segoe UI", 10F, FontStyle.Bold)
        btnCancel.ForeColor = Color.White
        btnCancel.Location = New Point(235, 708)
        btnCancel.Name = "btnCancel"
        btnCancel.Size = New Size(395, 72)
        btnCancel.TabIndex = 33
        btnCancel.Text = "Cancel"
        btnCancel.UseVisualStyleBackColor = False
        ' 
        ' btnBack
        ' 
        btnBack.BackColor = Color.DarkGreen
        btnBack.FlatStyle = FlatStyle.Flat
        btnBack.Font = New Font("Segoe UI", 10F, FontStyle.Bold)
        btnBack.ForeColor = Color.White
        btnBack.Location = New Point(646, 710)
        btnBack.Name = "btnBack"
        btnBack.Size = New Size(395, 72)
        btnBack.TabIndex = 32
        btnBack.Text = "Back"
        btnBack.UseVisualStyleBackColor = False
        ' 
        ' btnEditProfile
        ' 
        btnEditProfile.BackColor = Color.DarkGreen
        btnEditProfile.FlatStyle = FlatStyle.Flat
        btnEditProfile.Font = New Font("Segoe UI", 10F, FontStyle.Bold)
        btnEditProfile.ForeColor = Color.White
        btnEditProfile.Location = New Point(235, 630)
        btnEditProfile.Name = "btnEditProfile"
        btnEditProfile.Size = New Size(395, 72)
        btnEditProfile.TabIndex = 31
        btnEditProfile.Text = "Edit Profile"
        btnEditProfile.UseVisualStyleBackColor = False
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Font = New Font("Segoe UI", 10F, FontStyle.Bold)
        Label7.Location = New Point(291, 278)
        Label7.Name = "Label7"
        Label7.Size = New Size(122, 28)
        Label7.TabIndex = 30
        Label7.Text = "Admin Role"
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.Font = New Font("Segoe UI", 10F, FontStyle.Bold)
        Label8.Location = New Point(291, 238)
        Label8.Name = "Label8"
        Label8.Size = New Size(137, 28)
        Label8.TabIndex = 29
        Label8.Text = "Admin Email:"
        ' 
        ' Label9
        ' 
        Label9.AutoSize = True
        Label9.Font = New Font("Segoe UI", 10F, FontStyle.Bold)
        Label9.Location = New Point(291, 201)
        Label9.Name = "Label9"
        Label9.Size = New Size(179, 28)
        Label9.TabIndex = 28
        Label9.Text = "Admin Username:"
        ' 
        ' Label10
        ' 
        Label10.AutoSize = True
        Label10.Font = New Font("Segoe UI", 10F, FontStyle.Bold)
        Label10.Location = New Point(291, 161)
        Label10.Name = "Label10"
        Label10.Size = New Size(141, 28)
        Label10.TabIndex = 27
        Label10.Text = "Admin Name:"
        ' 
        ' lblAdminRole
        ' 
        lblAdminRole.Location = New Point(473, 272)
        lblAdminRole.Name = "lblAdminRole"
        lblAdminRole.Size = New Size(567, 31)
        lblAdminRole.TabIndex = 26
        ' 
        ' txtAdminEmail
        ' 
        txtAdminEmail.Location = New Point(473, 235)
        txtAdminEmail.Name = "txtAdminEmail"
        txtAdminEmail.Size = New Size(567, 31)
        txtAdminEmail.TabIndex = 25
        ' 
        ' txtAdminUsername
        ' 
        txtAdminUsername.Location = New Point(473, 198)
        txtAdminUsername.Name = "txtAdminUsername"
        txtAdminUsername.Size = New Size(567, 31)
        txtAdminUsername.TabIndex = 24
        ' 
        ' txtAdminName
        ' 
        txtAdminName.Location = New Point(473, 161)
        txtAdminName.Name = "txtAdminName"
        txtAdminName.Size = New Size(567, 31)
        txtAdminName.TabIndex = 23
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Font = New Font("Segoe UI", 10F, FontStyle.Bold)
        Label6.Location = New Point(16, 514)
        Label6.Name = "Label6"
        Label6.Size = New Size(220, 28)
        Label6.TabIndex = 22
        Label6.Text = "Company Description:"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Segoe UI", 10F, FontStyle.Bold)
        Label5.Location = New Point(16, 483)
        Label5.Name = "Label5"
        Label5.Size = New Size(187, 28)
        Label5.TabIndex = 21
        Label5.Text = "Company Website:"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Segoe UI", 10F, FontStyle.Bold)
        Label4.Location = New Point(16, 446)
        Label4.Name = "Label4"
        Label4.Size = New Size(186, 28)
        Label4.TabIndex = 20
        Label4.Text = "Company Address:"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Segoe UI", 10F, FontStyle.Bold)
        Label3.Location = New Point(16, 406)
        Label3.Name = "Label3"
        Label3.Size = New Size(170, 28)
        Label3.TabIndex = 19
        Label3.Text = "Company Phone:"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI", 10F, FontStyle.Bold)
        Label2.Location = New Point(16, 369)
        Label2.Name = "Label2"
        Label2.Size = New Size(163, 28)
        Label2.TabIndex = 18
        Label2.Text = "Company Email:"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 10F, FontStyle.Bold)
        Label1.Location = New Point(16, 329)
        Label1.Name = "Label1"
        Label1.Size = New Size(167, 28)
        Label1.TabIndex = 17
        Label1.Text = "Company Name:"
        ' 
        ' txtCompanyDescription
        ' 
        txtCompanyDescription.Location = New Point(235, 511)
        txtCompanyDescription.Multiline = True
        txtCompanyDescription.Name = "txtCompanyDescription"
        txtCompanyDescription.Size = New Size(806, 113)
        txtCompanyDescription.TabIndex = 16
        ' 
        ' txtCompanyWebsite
        ' 
        txtCompanyWebsite.Location = New Point(235, 474)
        txtCompanyWebsite.Name = "txtCompanyWebsite"
        txtCompanyWebsite.Size = New Size(806, 31)
        txtCompanyWebsite.TabIndex = 15
        ' 
        ' txtCompanyAddress
        ' 
        txtCompanyAddress.Location = New Point(235, 437)
        txtCompanyAddress.Name = "txtCompanyAddress"
        txtCompanyAddress.Size = New Size(806, 31)
        txtCompanyAddress.TabIndex = 14
        ' 
        ' txtCompanyPhone
        ' 
        txtCompanyPhone.Location = New Point(235, 400)
        txtCompanyPhone.Name = "txtCompanyPhone"
        txtCompanyPhone.Size = New Size(806, 31)
        txtCompanyPhone.TabIndex = 13
        ' 
        ' txtCompanyEmail
        ' 
        txtCompanyEmail.Location = New Point(235, 363)
        txtCompanyEmail.Name = "txtCompanyEmail"
        txtCompanyEmail.Size = New Size(806, 31)
        txtCompanyEmail.TabIndex = 12
        ' 
        ' txtCompanyName
        ' 
        txtCompanyName.Location = New Point(235, 326)
        txtCompanyName.Name = "txtCompanyName"
        txtCompanyName.Size = New Size(806, 31)
        txtCompanyName.TabIndex = 11
        ' 
        ' btnRemoveLogo
        ' 
        btnRemoveLogo.BackColor = Color.DarkGreen
        btnRemoveLogo.FlatStyle = FlatStyle.Flat
        btnRemoveLogo.ForeColor = Color.White
        btnRemoveLogo.Location = New Point(130, 284)
        btnRemoveLogo.Name = "btnRemoveLogo"
        btnRemoveLogo.Size = New Size(112, 34)
        btnRemoveLogo.TabIndex = 10
        btnRemoveLogo.Text = "Remove"
        btnRemoveLogo.UseVisualStyleBackColor = False
        ' 
        ' btnUploadLogo
        ' 
        btnUploadLogo.BackColor = Color.DarkGreen
        btnUploadLogo.FlatStyle = FlatStyle.Flat
        btnUploadLogo.ForeColor = Color.White
        btnUploadLogo.Location = New Point(12, 284)
        btnUploadLogo.Name = "btnUploadLogo"
        btnUploadLogo.Size = New Size(112, 34)
        btnUploadLogo.TabIndex = 9
        btnUploadLogo.Text = "Upload "
        btnUploadLogo.UseVisualStyleBackColor = False
        ' 
        ' picCompanyLogo
        ' 
        picCompanyLogo.Location = New Point(10, 126)
        picCompanyLogo.Name = "picCompanyLogo"
        picCompanyLogo.Size = New Size(226, 131)
        picCompanyLogo.SizeMode = PictureBoxSizeMode.Zoom
        picCompanyLogo.TabIndex = 8
        picCompanyLogo.TabStop = False
        ' 
        ' Company_Profiile
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1428, 794)
        Controls.Add(SplitContainer1)
        Name = "Company_Profiile"
        Text = "Company_Profiile"
        SplitContainer1.Panel1.ResumeLayout(False)
        SplitContainer1.Panel2.ResumeLayout(False)
        SplitContainer1.Panel2.PerformLayout()
        CType(SplitContainer1, ComponentModel.ISupportInitialize).EndInit()
        SplitContainer1.ResumeLayout(False)
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        CType(picCompanyLogo, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub

    Friend WithEvents btnListing As Button
    Friend WithEvents btn_Overview As Button
    Friend WithEvents btnExit As Button
    Friend WithEvents SplitContainer1 As SplitContainer
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents btnPost As Button
    Friend WithEvents txtCompanyEmail As TextBox
    Friend WithEvents txtCompanyName As TextBox
    Friend WithEvents btnRemoveLogo As Button
    Friend WithEvents btnUploadLogo As Button
    Friend WithEvents picCompanyLogo As PictureBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents txtCompanyDescription As TextBox
    Friend WithEvents txtCompanyWebsite As TextBox
    Friend WithEvents txtCompanyAddress As TextBox
    Friend WithEvents txtCompanyPhone As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents lblAdminRole As TextBox
    Friend WithEvents txtAdminEmail As TextBox
    Friend WithEvents txtAdminUsername As TextBox
    Friend WithEvents txtAdminName As TextBox
    Friend WithEvents btnSaveChanges As Button
    Friend WithEvents btnCancel As Button
    Friend WithEvents btnBack As Button
    Friend WithEvents btnEditProfile As Button
    Friend WithEvents Label12 As Label
    Friend WithEvents Label11 As Label
End Class
