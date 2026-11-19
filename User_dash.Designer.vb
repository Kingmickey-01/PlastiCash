<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class User_dash
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(User_dash))
        Label6 = New Label()
        txtArea = New TextBox()
        lblType = New Label()
        txtQuantity = New TextBox()
        lblArea = New Label()
        lblQuantity = New Label()
        Panel5 = New Panel()
        lblTotalEarned = New Label()
        Label5 = New Label()
        Label1 = New Label()
        lblPerKG = New Label()
        Panel4 = New Panel()
        lblTotalPlastic = New Label()
        Label4 = New Label()
        btnPostListings = New Button()
        txtPricePerKg = New TextBox()
        Panel3 = New Panel()
        lblActiveCount = New Label()
        Label3 = New Label()
        cmbPlasticType = New ComboBox()
        lstListings = New ListBox()
        Label2 = New Label()
        lblGreet = New Label()
        Panel2 = New Panel()
        PictureBox1 = New PictureBox()
        btnPayment = New Button()
        btnImages = New Button()
        btnListing = New Button()
        btn_Overview = New Button()
        Panel1 = New Panel()
        SplitContainer1 = New SplitContainer()
        btnExit = New Button()
        Panel5.SuspendLayout()
        Panel4.SuspendLayout()
        Panel3.SuspendLayout()
        Panel2.SuspendLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        Panel1.SuspendLayout()
        CType(SplitContainer1, ComponentModel.ISupportInitialize).BeginInit()
        SplitContainer1.Panel1.SuspendLayout()
        SplitContainer1.Panel2.SuspendLayout()
        SplitContainer1.SuspendLayout()
        SuspendLayout()
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Font = New Font("Segoe UI", 9F)
        Label6.Location = New Point(257, 20)
        Label6.Name = "Label6"
        Label6.Size = New Size(115, 25)
        Label6.TabIndex = 10
        Label6.Text = "MY LISTINGS"
        ' 
        ' txtArea
        ' 
        txtArea.Location = New Point(13, 255)
        txtArea.Name = "txtArea"
        txtArea.Size = New Size(354, 31)
        txtArea.TabIndex = 7
        ' 
        ' lblType
        ' 
        lblType.AutoSize = True
        lblType.Font = New Font("Segoe UI", 9F)
        lblType.Location = New Point(13, 67)
        lblType.Name = "lblType"
        lblType.Size = New Size(101, 25)
        lblType.TabIndex = 1
        lblType.Text = "Plastic type"
        ' 
        ' txtQuantity
        ' 
        txtQuantity.Location = New Point(13, 174)
        txtQuantity.Name = "txtQuantity"
        txtQuantity.Size = New Size(354, 31)
        txtQuantity.TabIndex = 6
        ' 
        ' lblArea
        ' 
        lblArea.AutoSize = True
        lblArea.Font = New Font("Segoe UI", 9F)
        lblArea.Location = New Point(13, 218)
        lblArea.Name = "lblArea"
        lblArea.Size = New Size(48, 25)
        lblArea.TabIndex = 2
        lblArea.Text = "Area"
        ' 
        ' lblQuantity
        ' 
        lblQuantity.AutoSize = True
        lblQuantity.Font = New Font("Segoe UI", 9F)
        lblQuantity.Location = New Point(13, 146)
        lblQuantity.Name = "lblQuantity"
        lblQuantity.Size = New Size(80, 25)
        lblQuantity.TabIndex = 4
        lblQuantity.Text = "Quantity"
        ' 
        ' Panel5
        ' 
        Panel5.BackColor = SystemColors.ButtonHighlight
        Panel5.Controls.Add(lblTotalEarned)
        Panel5.Controls.Add(Label5)
        Panel5.Location = New Point(726, 128)
        Panel5.Name = "Panel5"
        Panel5.Size = New Size(324, 126)
        Panel5.TabIndex = 6
        ' 
        ' lblTotalEarned
        ' 
        lblTotalEarned.AutoSize = True
        lblTotalEarned.Font = New Font("Segoe UI", 20F, FontStyle.Bold)
        lblTotalEarned.Location = New Point(18, 49)
        lblTotalEarned.Name = "lblTotalEarned"
        lblTotalEarned.Size = New Size(131, 54)
        lblTotalEarned.TabIndex = 11
        lblTotalEarned.Text = "GHS -"
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
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(13, 20)
        Label1.Name = "Label1"
        Label1.Size = New Size(232, 28)
        Label1.TabIndex = 0
        Label1.Text = "Post plastics for pickup"
        ' 
        ' lblPerKG
        ' 
        lblPerKG.AutoSize = True
        lblPerKG.Font = New Font("Segoe UI", 9F)
        lblPerKG.Location = New Point(13, 300)
        lblPerKG.Name = "lblPerKG"
        lblPerKG.Size = New Size(105, 25)
        lblPerKG.TabIndex = 3
        lblPerKG.Text = "Price per kg"
        ' 
        ' Panel4
        ' 
        Panel4.BackColor = SystemColors.ButtonHighlight
        Panel4.Controls.Add(lblTotalPlastic)
        Panel4.Controls.Add(Label4)
        Panel4.Location = New Point(377, 128)
        Panel4.Name = "Panel4"
        Panel4.Size = New Size(324, 126)
        Panel4.TabIndex = 5
        ' 
        ' lblTotalPlastic
        ' 
        lblTotalPlastic.AutoSize = True
        lblTotalPlastic.Font = New Font("Segoe UI", 20F, FontStyle.Bold)
        lblTotalPlastic.Location = New Point(24, 49)
        lblTotalPlastic.Name = "lblTotalPlastic"
        lblTotalPlastic.Size = New Size(39, 54)
        lblTotalPlastic.TabIndex = 11
        lblTotalPlastic.Text = "-"
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
        ' btnPostListings
        ' 
        btnPostListings.BackColor = Color.DarkGreen
        btnPostListings.FlatAppearance.BorderColor = Color.DarkGreen
        btnPostListings.FlatStyle = FlatStyle.Flat
        btnPostListings.Font = New Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnPostListings.ForeColor = Color.White
        btnPostListings.Location = New Point(72, 409)
        btnPostListings.Name = "btnPostListings"
        btnPostListings.Size = New Size(258, 44)
        btnPostListings.TabIndex = 5
        btnPostListings.Text = "Post listings"
        btnPostListings.UseVisualStyleBackColor = False
        ' 
        ' txtPricePerKg
        ' 
        txtPricePerKg.Location = New Point(13, 328)
        txtPricePerKg.Name = "txtPricePerKg"
        txtPricePerKg.Size = New Size(354, 31)
        txtPricePerKg.TabIndex = 8
        ' 
        ' Panel3
        ' 
        Panel3.BackColor = SystemColors.ButtonHighlight
        Panel3.Controls.Add(lblActiveCount)
        Panel3.Controls.Add(Label3)
        Panel3.Location = New Point(29, 128)
        Panel3.Name = "Panel3"
        Panel3.Size = New Size(324, 126)
        Panel3.TabIndex = 4
        ' 
        ' lblActiveCount
        ' 
        lblActiveCount.AutoSize = True
        lblActiveCount.Font = New Font("Segoe UI", 20F, FontStyle.Bold)
        lblActiveCount.Location = New Point(11, 49)
        lblActiveCount.Name = "lblActiveCount"
        lblActiveCount.Size = New Size(39, 54)
        lblActiveCount.TabIndex = 10
        lblActiveCount.Text = "-"
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
        ' cmbPlasticType
        ' 
        cmbPlasticType.FormattingEnabled = True
        cmbPlasticType.Items.AddRange(New Object() {"PET bottles - Water bottles, soft drink bottles", "HDPE - Detergent bottles, shampoo containers", "LDPE  - Plastic bags, wrapping films", "PP - Food containers, bottle caps, buckets", "PVC - Plastic pipes, cable insulation", "PS - Disposable cups, foam packaging", "Other Plastics - Enter the plastic type"})
        cmbPlasticType.Location = New Point(16, 103)
        cmbPlasticType.Name = "cmbPlasticType"
        cmbPlasticType.Size = New Size(351, 33)
        cmbPlasticType.TabIndex = 9
        ' 
        ' lstListings
        ' 
        lstListings.FormattingEnabled = True
        lstListings.Location = New Point(8, 60)
        lstListings.Name = "lstListings"
        lstListings.Size = New Size(588, 404)
        lstListings.TabIndex = 11
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI", 12F)
        Label2.Location = New Point(38, 79)
        Label2.Name = "Label2"
        Label2.Size = New Size(449, 32)
        Label2.TabIndex = 10
        Label2.Text = "Here's the plastics you have listed so far "
        ' 
        ' lblGreet
        ' 
        lblGreet.AutoSize = True
        lblGreet.Font = New Font("Segoe UI", 26F, FontStyle.Bold)
        lblGreet.Location = New Point(29, 9)
        lblGreet.Name = "lblGreet"
        lblGreet.Size = New Size(428, 70)
        lblGreet.TabIndex = 9
        lblGreet.Text = "Welcome back..."
        ' 
        ' Panel2
        ' 
        Panel2.BackColor = SystemColors.ButtonHighlight
        Panel2.Controls.Add(cmbPlasticType)
        Panel2.Controls.Add(btnPostListings)
        Panel2.Controls.Add(txtPricePerKg)
        Panel2.Controls.Add(Label1)
        Panel2.Controls.Add(lblPerKG)
        Panel2.Controls.Add(txtArea)
        Panel2.Controls.Add(lblType)
        Panel2.Controls.Add(txtQuantity)
        Panel2.Controls.Add(lblArea)
        Panel2.Controls.Add(lblQuantity)
        Panel2.Location = New Point(672, 274)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(378, 472)
        Panel2.TabIndex = 4
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
        btnPayment.Location = New Point(26, 422)
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
        btnImages.Location = New Point(26, 344)
        btnImages.Name = "btnImages"
        btnImages.Size = New Size(289, 72)
        btnImages.TabIndex = 2
        btnImages.Text = "Add Images"
        btnImages.UseVisualStyleBackColor = True
        ' 
        ' btnListing
        ' 
        btnListing.FlatAppearance.BorderColor = Color.DarkGreen
        btnListing.FlatStyle = FlatStyle.Flat
        btnListing.Font = New Font("Segoe UI", 10F)
        btnListing.ForeColor = SystemColors.ButtonHighlight
        btnListing.Location = New Point(26, 270)
        btnListing.Name = "btnListing"
        btnListing.Size = New Size(289, 72)
        btnListing.TabIndex = 1
        btnListing.Text = "My listings"
        btnListing.UseVisualStyleBackColor = True
        ' 
        ' btn_Overview
        ' 
        btn_Overview.BackColor = Color.YellowGreen
        btn_Overview.FlatAppearance.BorderColor = Color.DarkGreen
        btn_Overview.FlatStyle = FlatStyle.Flat
        btn_Overview.Font = New Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btn_Overview.Location = New Point(26, 195)
        btn_Overview.Name = "btn_Overview"
        btn_Overview.Size = New Size(289, 72)
        btn_Overview.TabIndex = 0
        btn_Overview.Text = "Overview"
        btn_Overview.UseVisualStyleBackColor = False
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = SystemColors.ButtonHighlight
        Panel1.Controls.Add(lstListings)
        Panel1.Controls.Add(Label6)
        Panel1.Location = New Point(29, 274)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(612, 472)
        Panel1.TabIndex = 3
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
        SplitContainer1.Panel1.Controls.Add(btnPayment)
        SplitContainer1.Panel1.Controls.Add(btnImages)
        SplitContainer1.Panel1.Controls.Add(btnListing)
        SplitContainer1.Panel1.Controls.Add(btn_Overview)
        ' 
        ' SplitContainer1.Panel2
        ' 
        SplitContainer1.Panel2.Controls.Add(Panel5)
        SplitContainer1.Panel2.Controls.Add(Panel4)
        SplitContainer1.Panel2.Controls.Add(Panel3)
        SplitContainer1.Panel2.Controls.Add(Label2)
        SplitContainer1.Panel2.Controls.Add(lblGreet)
        SplitContainer1.Panel2.Controls.Add(Panel2)
        SplitContainer1.Panel2.Controls.Add(Panel1)
        SplitContainer1.Size = New Size(1428, 794)
        SplitContainer1.SplitterDistance = 349
        SplitContainer1.TabIndex = 1
        ' 
        ' btnExit
        ' 
        btnExit.FlatAppearance.BorderColor = Color.DarkGreen
        btnExit.FlatStyle = FlatStyle.Flat
        btnExit.Font = New Font("Segoe UI", 10F)
        btnExit.ForeColor = SystemColors.ButtonHighlight
        btnExit.Location = New Point(26, 722)
        btnExit.Name = "btnExit"
        btnExit.Size = New Size(289, 72)
        btnExit.TabIndex = 6
        btnExit.Text = "Logout🚪"
        btnExit.UseVisualStyleBackColor = True
        ' 
        ' User_dash
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1428, 794)
        Controls.Add(SplitContainer1)
        Name = "User_dash"
        Text = "User_dash"
        Panel5.ResumeLayout(False)
        Panel5.PerformLayout()
        Panel4.ResumeLayout(False)
        Panel4.PerformLayout()
        Panel3.ResumeLayout(False)
        Panel3.PerformLayout()
        Panel2.ResumeLayout(False)
        Panel2.PerformLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        SplitContainer1.Panel1.ResumeLayout(False)
        SplitContainer1.Panel2.ResumeLayout(False)
        SplitContainer1.Panel2.PerformLayout()
        CType(SplitContainer1, ComponentModel.ISupportInitialize).EndInit()
        SplitContainer1.ResumeLayout(False)
        ResumeLayout(False)
    End Sub

    Friend WithEvents Label6 As Label
    Friend WithEvents txtArea As TextBox
    Friend WithEvents lblType As Label
    Friend WithEvents txtQuantity As TextBox
    Friend WithEvents lblArea As Label
    Friend WithEvents lblQuantity As Label
    Friend WithEvents Panel5 As Panel
    Friend WithEvents lblTotalEarned As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents lblPerKG As Label
    Friend WithEvents Panel4 As Panel
    Friend WithEvents lblTotalPlastic As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents btnPostListings As Button
    Friend WithEvents txtPricePerKg As TextBox
    Friend WithEvents Panel3 As Panel
    Friend WithEvents lblActiveCount As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents cmbPlasticType As ComboBox
    Friend WithEvents lstListings As ListBox
    Friend WithEvents Label2 As Label
    Friend WithEvents lblGreet As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents btnPayment As Button
    Friend WithEvents btnImages As Button
    Friend WithEvents btnListing As Button
    Friend WithEvents btn_Overview As Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents SplitContainer1 As SplitContainer
    Friend WithEvents btnExit As Button
End Class
