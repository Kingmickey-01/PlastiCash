<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Transaction_History
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
        Panel1 = New Panel()
        Label1 = New Label()
        Panel3 = New Panel()
        Label9 = New Label()
        lblTotalPlascticSold = New Label()
        Label3 = New Label()
        Panel2 = New Panel()
        Label8 = New Label()
        lblTotalEarnings = New Label()
        Label4 = New Label()
        Panel4 = New Panel()
        Label7 = New Label()
        lblTotalTransactions = New Label()
        Label6 = New Label()
        txtSearch = New TextBox()
        Label10 = New Label()
        cmbStatus = New ComboBox()
        Label12 = New Label()
        Button1 = New Button()
        btnViewDetails = New Button()
        dgvTransactionHistory = New DataGridView()
        Button3 = New Button()
        Panel1.SuspendLayout()
        Panel3.SuspendLayout()
        Panel2.SuspendLayout()
        Panel4.SuspendLayout()
        CType(dgvTransactionHistory, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.DarkGreen
        Panel1.Controls.Add(Label1)
        Panel1.Location = New Point(478, 12)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(480, 66)
        Panel1.TabIndex = 0
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 15F, FontStyle.Bold)
        Label1.ForeColor = Color.White
        Label1.Location = New Point(77, 12)
        Label1.Name = "Label1"
        Label1.Size = New Size(316, 41)
        Label1.TabIndex = 1
        Label1.Text = "🕝Trasaction History"
        ' 
        ' Panel3
        ' 
        Panel3.BackColor = SystemColors.ButtonHighlight
        Panel3.Controls.Add(Label9)
        Panel3.Controls.Add(lblTotalPlascticSold)
        Panel3.Controls.Add(Label3)
        Panel3.Location = New Point(78, 93)
        Panel3.Name = "Panel3"
        Panel3.Size = New Size(422, 145)
        Panel3.TabIndex = 5
        ' 
        ' Label9
        ' 
        Label9.AutoSize = True
        Label9.Font = New Font("Segoe UI", 26F, FontStyle.Bold)
        Label9.Location = New Point(18, 30)
        Label9.Name = "Label9"
        Label9.Size = New Size(101, 70)
        Label9.TabIndex = 11
        Label9.Text = "🍶"
        ' 
        ' lblTotalPlascticSold
        ' 
        lblTotalPlascticSold.AutoSize = True
        lblTotalPlascticSold.Font = New Font("Segoe UI", 26F, FontStyle.Bold)
        lblTotalPlascticSold.Location = New Point(116, 37)
        lblTotalPlascticSold.Name = "lblTotalPlascticSold"
        lblTotalPlascticSold.Size = New Size(51, 70)
        lblTotalPlascticSold.TabIndex = 10
        lblTotalPlascticSold.Text = "-"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Segoe UI", 9F)
        Label3.Location = New Point(116, 12)
        Label3.Name = "Label3"
        Label3.Size = New Size(182, 25)
        Label3.TabIndex = 9
        Label3.Text = "TOTAL PLASTIC SOLD"
        ' 
        ' Panel2
        ' 
        Panel2.BackColor = SystemColors.ButtonHighlight
        Panel2.Controls.Add(Label8)
        Panel2.Controls.Add(lblTotalEarnings)
        Panel2.Controls.Add(Label4)
        Panel2.Location = New Point(506, 93)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(422, 145)
        Panel2.TabIndex = 6
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.Font = New Font("Segoe UI", 26F, FontStyle.Bold)
        Label8.Location = New Point(18, 26)
        Label8.Name = "Label8"
        Label8.Size = New Size(101, 70)
        Label8.TabIndex = 11
        Label8.Text = "💰"
        ' 
        ' lblTotalEarnings
        ' 
        lblTotalEarnings.AutoSize = True
        lblTotalEarnings.Font = New Font("Segoe UI", 26F, FontStyle.Bold)
        lblTotalEarnings.Location = New Point(108, 37)
        lblTotalEarnings.Name = "lblTotalEarnings"
        lblTotalEarnings.Size = New Size(171, 70)
        lblTotalEarnings.TabIndex = 10
        lblTotalEarnings.Text = "GHS -"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Segoe UI", 9F)
        Label4.Location = New Point(116, 12)
        Label4.Name = "Label4"
        Label4.Size = New Size(151, 25)
        Label4.TabIndex = 9
        Label4.Text = "TOTAL EARNINGS"
        ' 
        ' Panel4
        ' 
        Panel4.BackColor = SystemColors.ButtonHighlight
        Panel4.Controls.Add(Label7)
        Panel4.Controls.Add(lblTotalTransactions)
        Panel4.Controls.Add(Label6)
        Panel4.Location = New Point(934, 93)
        Panel4.Name = "Panel4"
        Panel4.Size = New Size(422, 145)
        Panel4.TabIndex = 11
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Font = New Font("Segoe UI", 26F, FontStyle.Bold)
        Label7.Location = New Point(14, 33)
        Label7.Name = "Label7"
        Label7.Size = New Size(101, 70)
        Label7.TabIndex = 11
        Label7.Text = ChrW(55358) & ChrW(56605)
        Label7.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' lblTotalTransactions
        ' 
        lblTotalTransactions.AutoSize = True
        lblTotalTransactions.Font = New Font("Segoe UI", 26F, FontStyle.Bold)
        lblTotalTransactions.Location = New Point(108, 37)
        lblTotalTransactions.Name = "lblTotalTransactions"
        lblTotalTransactions.Size = New Size(171, 70)
        lblTotalTransactions.TabIndex = 10
        lblTotalTransactions.Text = "GHS -"
        lblTotalTransactions.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Font = New Font("Segoe UI", 9F)
        Label6.Location = New Point(108, 12)
        Label6.Name = "Label6"
        Label6.Size = New Size(195, 25)
        Label6.TabIndex = 9
        Label6.Text = "TOTAL TRANSACTIONS"
        ' 
        ' txtSearch
        ' 
        txtSearch.Location = New Point(173, 254)
        txtSearch.Name = "txtSearch"
        txtSearch.Size = New Size(411, 31)
        txtSearch.TabIndex = 12
        ' 
        ' Label10
        ' 
        Label10.AutoSize = True
        Label10.BackColor = Color.DarkGreen
        Label10.Font = New Font("Segoe UI", 12F, FontStyle.Bold)
        Label10.ForeColor = Color.White
        Label10.Location = New Point(78, 253)
        Label10.Name = "Label10"
        Label10.Size = New Size(89, 32)
        Label10.TabIndex = 13
        Label10.Text = "Search"
        ' 
        ' cmbStatus
        ' 
        cmbStatus.FormattingEnabled = True
        cmbStatus.Location = New Point(720, 253)
        cmbStatus.Name = "cmbStatus"
        cmbStatus.Size = New Size(411, 33)
        cmbStatus.TabIndex = 15
        ' 
        ' Label12
        ' 
        Label12.AutoSize = True
        Label12.BackColor = Color.DarkGreen
        Label12.Font = New Font("Segoe UI", 12F, FontStyle.Bold)
        Label12.ForeColor = Color.White
        Label12.Location = New Point(631, 254)
        Label12.Name = "Label12"
        Label12.Size = New Size(83, 32)
        Label12.TabIndex = 16
        Label12.Text = "Status"
        ' 
        ' Button1
        ' 
        Button1.Location = New Point(585, 255)
        Button1.Name = "Button1"
        Button1.Size = New Size(40, 32)
        Button1.TabIndex = 17
        Button1.Text = "❌"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' btnViewDetails
        ' 
        btnViewDetails.BackColor = Color.DarkGreen
        btnViewDetails.Font = New Font("Segoe UI", 12F, FontStyle.Bold)
        btnViewDetails.ForeColor = Color.White
        btnViewDetails.Location = New Point(1137, 245)
        btnViewDetails.Name = "btnViewDetails"
        btnViewDetails.Size = New Size(219, 51)
        btnViewDetails.TabIndex = 18
        btnViewDetails.Text = "View Details"
        btnViewDetails.UseVisualStyleBackColor = False
        ' 
        ' dgvTransactionHistory
        ' 
        dgvTransactionHistory.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgvTransactionHistory.Location = New Point(79, 315)
        dgvTransactionHistory.Name = "dgvTransactionHistory"
        dgvTransactionHistory.RowHeadersWidth = 62
        dgvTransactionHistory.Size = New Size(1277, 404)
        dgvTransactionHistory.TabIndex = 19
        ' 
        ' Button3
        ' 
        Button3.BackColor = Color.DarkGreen
        Button3.Font = New Font("Segoe UI", 20F, FontStyle.Bold)
        Button3.ForeColor = Color.White
        Button3.Location = New Point(1137, 725)
        Button3.Name = "Button3"
        Button3.Size = New Size(219, 63)
        Button3.TabIndex = 20
        Button3.Text = "🔙"
        Button3.UseVisualStyleBackColor = False
        ' 
        ' Transaction_History
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1428, 794)
        Controls.Add(Button3)
        Controls.Add(dgvTransactionHistory)
        Controls.Add(btnViewDetails)
        Controls.Add(Button1)
        Controls.Add(Label12)
        Controls.Add(cmbStatus)
        Controls.Add(Label10)
        Controls.Add(txtSearch)
        Controls.Add(Panel4)
        Controls.Add(Panel2)
        Controls.Add(Panel3)
        Controls.Add(Panel1)
        Name = "Transaction_History"
        Text = "Transaction_History"
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        Panel3.ResumeLayout(False)
        Panel3.PerformLayout()
        Panel2.ResumeLayout(False)
        Panel2.PerformLayout()
        Panel4.ResumeLayout(False)
        Panel4.PerformLayout()
        CType(dgvTransactionHistory, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents Panel3 As Panel
    Friend WithEvents lblTotalPlascticSold As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents lblTotalEarnings As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Panel4 As Panel
    Friend WithEvents lblTotalTransactions As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents txtSearch As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents cmbStatus As ComboBox
    Friend WithEvents Label12 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents btnViewDetails As Button
    Friend WithEvents dgvTransactionHistory As DataGridView
    Friend WithEvents Button3 As Button
End Class
