<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Dashboard
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Dashboard))
        txtArea = New TextBox()
        lblArea = New Label()
        Panel2 = New Panel()
        cmbPlasticType = New ComboBox()
        lblType = New Label()
        PictureBox1 = New PictureBox()
        SplitContainer1 = New SplitContainer()
        btnExit = New Button()
        btnPost = New Button()
        btnListing = New Button()
        btn_Overview = New Button()
        Panel5 = New Panel()
        lblEarnedSoFar = New Label()
        Label5 = New Label()
        Panel4 = New Panel()
        lblPlasticsListed = New Label()
        Label4 = New Label()
        Panel3 = New Panel()
        lblActiveListings = New Label()
        Label3 = New Label()
        lblGreet = New Label()
        Panel1 = New Panel()
        dgvlists = New DataGridView()
        Panel2.SuspendLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        CType(SplitContainer1, ComponentModel.ISupportInitialize).BeginInit()
        SplitContainer1.Panel1.SuspendLayout()
        SplitContainer1.Panel2.SuspendLayout()
        SplitContainer1.SuspendLayout()
        Panel5.SuspendLayout()
        Panel4.SuspendLayout()
        Panel3.SuspendLayout()
        Panel1.SuspendLayout()
        CType(dgvlists, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' txtArea
        ' 
        txtArea.BorderStyle = BorderStyle.FixedSingle
        txtArea.Location = New Point(91, 33)
        txtArea.Name = "txtArea"
        txtArea.Size = New Size(312, 31)
        txtArea.TabIndex = 2
        ' 
        ' lblArea
        ' 
        lblArea.AutoSize = True
        lblArea.Font = New Font("Segoe UI", 12F, FontStyle.Bold)
        lblArea.Location = New Point(18, 34)
        lblArea.Name = "lblArea"
        lblArea.Size = New Size(67, 32)
        lblArea.TabIndex = 0
        lblArea.Text = "Area"
        ' 
        ' Panel2
        ' 
        Panel2.BackColor = Color.LightGreen
        Panel2.Controls.Add(cmbPlasticType)
        Panel2.Controls.Add(txtArea)
        Panel2.Controls.Add(lblType)
        Panel2.Controls.Add(lblArea)
        Panel2.Location = New Point(29, 264)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(1021, 81)
        Panel2.TabIndex = 4
        ' 
        ' cmbPlasticType
        ' 
        cmbPlasticType.FormattingEnabled = True
        cmbPlasticType.Items.AddRange(New Object() {"PET bottles - Water bottles, soft drink bottles", "HDPE - Detergent bottles, shampoo containers", "LDPE  - Plastic bags, wrapping films", "PP - Food containers, bottle caps, buckets", "PVC - Plastic pipes, cable insulation", "PS - Disposable cups, foam packaging", "Other Plastics - Enter the plastic type"})
        cmbPlasticType.Location = New Point(596, 32)
        cmbPlasticType.Name = "cmbPlasticType"
        cmbPlasticType.Size = New Size(413, 33)
        cmbPlasticType.TabIndex = 0
        ' 
        ' lblType
        ' 
        lblType.AutoSize = True
        lblType.Font = New Font("Segoe UI", 12F, FontStyle.Bold)
        lblType.Location = New Point(441, 32)
        lblType.Name = "lblType"
        lblType.Size = New Size(149, 32)
        lblType.TabIndex = 1
        lblType.Text = "Plastic Type"
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
        SplitContainer1.Panel2.Controls.Add(Panel5)
        SplitContainer1.Panel2.Controls.Add(Panel4)
        SplitContainer1.Panel2.Controls.Add(Panel3)
        SplitContainer1.Panel2.Controls.Add(lblGreet)
        SplitContainer1.Panel2.Controls.Add(Panel2)
        SplitContainer1.Panel2.Controls.Add(Panel1)
        SplitContainer1.Size = New Size(1428, 784)
        SplitContainer1.SplitterDistance = 349
        SplitContainer1.TabIndex = 2
        ' 
        ' btnExit
        ' 
        btnExit.FlatAppearance.BorderColor = Color.DarkGreen
        btnExit.FlatStyle = FlatStyle.Flat
        btnExit.Font = New Font("Segoe UI", 10F)
        btnExit.ForeColor = SystemColors.ButtonHighlight
        btnExit.Location = New Point(29, 709)
        btnExit.Name = "btnExit"
        btnExit.Size = New Size(289, 72)
        btnExit.TabIndex = 7
        btnExit.Text = "Logout🚪"
        btnExit.UseVisualStyleBackColor = True
        ' 
        ' btnPost
        ' 
        btnPost.FlatAppearance.BorderColor = Color.DarkGreen
        btnPost.FlatStyle = FlatStyle.Flat
        btnPost.Font = New Font("Segoe UI", 10F)
        btnPost.ForeColor = SystemColors.ButtonHighlight
        btnPost.ImageAlign = ContentAlignment.MiddleLeft
        btnPost.Location = New Point(29, 351)
        btnPost.Name = "btnPost"
        btnPost.Size = New Size(289, 72)
        btnPost.TabIndex = 2
        btnPost.Text = "Company profile"
        btnPost.UseVisualStyleBackColor = True
        ' 
        ' btnListing
        ' 
        btnListing.FlatAppearance.BorderColor = Color.DarkGreen
        btnListing.FlatStyle = FlatStyle.Flat
        btnListing.Font = New Font("Segoe UI", 10F)
        btnListing.ForeColor = SystemColors.ButtonHighlight
        btnListing.ImageAlign = ContentAlignment.MiddleLeft
        btnListing.Location = New Point(29, 273)
        btnListing.Name = "btnListing"
        btnListing.Size = New Size(289, 72)
        btnListing.TabIndex = 1
        btnListing.Text = "Manage Listings"
        btnListing.UseVisualStyleBackColor = True
        ' 
        ' btn_Overview
        ' 
        btn_Overview.BackColor = Color.YellowGreen
        btn_Overview.FlatAppearance.BorderColor = Color.DarkGreen
        btn_Overview.FlatStyle = FlatStyle.Flat
        btn_Overview.Font = New Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btn_Overview.Location = New Point(29, 195)
        btn_Overview.Name = "btn_Overview"
        btn_Overview.Size = New Size(289, 72)
        btn_Overview.TabIndex = 0
        btn_Overview.Text = "Dashboard"
        btn_Overview.UseVisualStyleBackColor = False
        ' 
        ' Panel5
        ' 
        Panel5.BackColor = SystemColors.ButtonHighlight
        Panel5.Controls.Add(lblEarnedSoFar)
        Panel5.Controls.Add(Label5)
        Panel5.Location = New Point(726, 128)
        Panel5.Name = "Panel5"
        Panel5.Size = New Size(324, 126)
        Panel5.TabIndex = 6
        ' 
        ' lblEarnedSoFar
        ' 
        lblEarnedSoFar.AutoSize = True
        lblEarnedSoFar.Font = New Font("Segoe UI", 26F, FontStyle.Bold)
        lblEarnedSoFar.Location = New Point(18, 49)
        lblEarnedSoFar.Name = "lblEarnedSoFar"
        lblEarnedSoFar.Size = New Size(157, 70)
        lblEarnedSoFar.TabIndex = 12
        lblEarnedSoFar.Text = "GHS-"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Segoe UI", 9F)
        Label5.Location = New Point(18, 12)
        Label5.Name = "Label5"
        Label5.Size = New Size(144, 25)
        Label5.TabIndex = 11
        Label5.Text = "EARNED SO FAR"
        ' 
        ' Panel4
        ' 
        Panel4.BackColor = SystemColors.ButtonHighlight
        Panel4.Controls.Add(lblPlasticsListed)
        Panel4.Controls.Add(Label4)
        Panel4.Location = New Point(379, 128)
        Panel4.Name = "Panel4"
        Panel4.Size = New Size(324, 126)
        Panel4.TabIndex = 5
        ' 
        ' lblPlasticsListed
        ' 
        lblPlasticsListed.AutoSize = True
        lblPlasticsListed.Font = New Font("Segoe UI", 26F, FontStyle.Bold)
        lblPlasticsListed.Location = New Point(24, 49)
        lblPlasticsListed.Name = "lblPlasticsListed"
        lblPlasticsListed.Size = New Size(51, 70)
        lblPlasticsListed.TabIndex = 11
        lblPlasticsListed.Text = "-"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Segoe UI", 9F)
        Label4.Location = New Point(24, 12)
        Label4.Name = "Label4"
        Label4.Size = New Size(147, 25)
        Label4.TabIndex = 10
        Label4.Text = "PLASTICS LISTED"
        ' 
        ' Panel3
        ' 
        Panel3.BackColor = SystemColors.ButtonHighlight
        Panel3.Controls.Add(lblActiveListings)
        Panel3.Controls.Add(Label3)
        Panel3.Location = New Point(29, 128)
        Panel3.Name = "Panel3"
        Panel3.Size = New Size(324, 126)
        Panel3.TabIndex = 4
        ' 
        ' lblActiveListings
        ' 
        lblActiveListings.AutoSize = True
        lblActiveListings.Font = New Font("Segoe UI", 26F, FontStyle.Bold)
        lblActiveListings.Location = New Point(18, 49)
        lblActiveListings.Name = "lblActiveListings"
        lblActiveListings.Size = New Size(51, 70)
        lblActiveListings.TabIndex = 11
        lblActiveListings.Text = "-"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Segoe UI", 9F)
        Label3.Location = New Point(11, 12)
        Label3.Name = "Label3"
        Label3.Size = New Size(146, 25)
        Label3.TabIndex = 9
        Label3.Text = "ACTIVE LISTINGS"
        ' 
        ' lblGreet
        ' 
        lblGreet.AutoSize = True
        lblGreet.Font = New Font("Segoe UI", 26F, FontStyle.Bold)
        lblGreet.Location = New Point(29, 9)
        lblGreet.Name = "lblGreet"
        lblGreet.Size = New Size(627, 70)
        lblGreet.TabIndex = 9
        lblGreet.Text = "Plastics ready for pickup"
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = SystemColors.ButtonHighlight
        Panel1.Controls.Add(dgvlists)
        Panel1.Location = New Point(29, 354)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(1021, 392)
        Panel1.TabIndex = 3
        ' 
        ' dgvlists
        ' 
        dgvlists.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgvlists.Location = New Point(3, 3)
        dgvlists.Name = "dgvlists"
        dgvlists.RowHeadersWidth = 62
        dgvlists.Size = New Size(1015, 386)
        dgvlists.TabIndex = 0
        ' 
        ' Dashboard
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1428, 784)
        Controls.Add(SplitContainer1)
        Name = "Dashboard"
        Text = "Dashboard"
        Panel2.ResumeLayout(False)
        Panel2.PerformLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        SplitContainer1.Panel1.ResumeLayout(False)
        SplitContainer1.Panel2.ResumeLayout(False)
        SplitContainer1.Panel2.PerformLayout()
        CType(SplitContainer1, ComponentModel.ISupportInitialize).EndInit()
        SplitContainer1.ResumeLayout(False)
        Panel5.ResumeLayout(False)
        Panel5.PerformLayout()
        Panel4.ResumeLayout(False)
        Panel4.PerformLayout()
        Panel3.ResumeLayout(False)
        Panel3.PerformLayout()
        Panel1.ResumeLayout(False)
        CType(dgvlists, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub
    Friend WithEvents txtArea As TextBox
    Friend WithEvents lblArea As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents lblType As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents SplitContainer1 As SplitContainer
    Friend WithEvents btnPost As Button
    Friend WithEvents btnListing As Button
    Friend WithEvents btn_Overview As Button
    Friend WithEvents Panel5 As Panel
    Friend WithEvents lblEarnedSoFar As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Panel4 As Panel
    Friend WithEvents lblPlasticsListed As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Panel3 As Panel
    Friend WithEvents lblActiveListings As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents lblGreet As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents btnExit As Button
    Friend WithEvents cmbPlasticType As ComboBox
    Friend WithEvents dgvlists As DataGridView
End Class
