<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(disposing As Boolean)
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        SplitContainer1 = New SplitContainer()
        PictureBox1 = New PictureBox()
        Label3 = New Label()
        Label2 = New Label()
        Label1 = New Label()
        lblGreet = New Label()
        GroupBox1 = New GroupBox()
        LinkLabel1 = New LinkLabel()
        btnlogin = New Button()
        Label7 = New Label()
        txtpass = New TextBox()
        txtname = New TextBox()
        Label6 = New Label()
        Label4 = New Label()
        Label5 = New Label()
        CType(SplitContainer1, ComponentModel.ISupportInitialize).BeginInit()
        SplitContainer1.Panel1.SuspendLayout()
        SplitContainer1.Panel2.SuspendLayout()
        SplitContainer1.SuspendLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        GroupBox1.SuspendLayout()
        SuspendLayout()
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
        SplitContainer1.Panel1.Controls.Add(Label3)
        SplitContainer1.Panel1.Controls.Add(Label2)
        SplitContainer1.Panel1.Controls.Add(Label1)
        SplitContainer1.Panel1.Controls.Add(lblGreet)
        ' 
        ' SplitContainer1.Panel2
        ' 
        SplitContainer1.Panel2.Controls.Add(GroupBox1)
        SplitContainer1.Size = New Size(1428, 784)
        SplitContainer1.SplitterDistance = 699
        SplitContainer1.TabIndex = 3
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), Image)
        PictureBox1.Location = New Point(12, 23)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(600, 212)
        PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox1.TabIndex = 14
        PictureBox1.TabStop = False
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.ForeColor = Color.White
        Label3.Location = New Point(24, 462)
        Label3.Name = "Label3"
        Label3.Size = New Size(279, 25)
        Label3.TabIndex = 13
        Label3.Text = "3. They collect it and you get paid"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.ForeColor = Color.White
        Label2.Location = New Point(24, 414)
        Label2.Name = "Label2"
        Label2.Size = New Size(265, 25)
        Label2.TabIndex = 12
        Label2.Text = "2. A recycling company claims it"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.ForeColor = Color.White
        Label1.Location = New Point(24, 367)
        Label1.Name = "Label1"
        Label1.Size = New Size(277, 25)
        Label1.TabIndex = 11
        Label1.Text = "1. Post the plastic waste you have"
        ' 
        ' lblGreet
        ' 
        lblGreet.AutoSize = True
        lblGreet.Font = New Font("Segoe UI", 20F, FontStyle.Bold)
        lblGreet.ForeColor = Color.White
        lblGreet.Location = New Point(24, 277)
        lblGreet.Name = "lblGreet"
        lblGreet.Size = New Size(629, 54)
        lblGreet.TabIndex = 10
        lblGreet.Text = "Your plastic waste has real value"
        ' 
        ' GroupBox1
        ' 
        GroupBox1.Controls.Add(LinkLabel1)
        GroupBox1.Controls.Add(btnlogin)
        GroupBox1.Controls.Add(Label7)
        GroupBox1.Controls.Add(txtpass)
        GroupBox1.Controls.Add(txtname)
        GroupBox1.Controls.Add(Label6)
        GroupBox1.Controls.Add(Label4)
        GroupBox1.Controls.Add(Label5)
        GroupBox1.Font = New Font("Segoe UI", 16F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        GroupBox1.Location = New Point(144, 180)
        GroupBox1.Name = "GroupBox1"
        GroupBox1.Size = New Size(480, 517)
        GroupBox1.TabIndex = 16
        GroupBox1.TabStop = False
        GroupBox1.Text = "Welcome Back"
        ' 
        ' LinkLabel1
        ' 
        LinkLabel1.AutoSize = True
        LinkLabel1.Font = New Font("Segoe UI", 9F)
        LinkLabel1.Location = New Point(274, 446)
        LinkLabel1.Name = "LinkLabel1"
        LinkLabel1.Size = New Size(100, 25)
        LinkLabel1.TabIndex = 22
        LinkLabel1.TabStop = True
        LinkLabel1.Text = "Create One"
        ' 
        ' btnlogin
        ' 
        btnlogin.BackColor = Color.DarkGreen
        btnlogin.FlatAppearance.BorderColor = Color.DarkGreen
        btnlogin.ForeColor = Color.White
        btnlogin.Location = New Point(21, 382)
        btnlogin.Name = "btnlogin"
        btnlogin.Size = New Size(444, 61)
        btnlogin.TabIndex = 21
        btnlogin.Text = "Login"
        btnlogin.UseVisualStyleBackColor = False
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Font = New Font("Segoe UI", 9F)
        Label7.ForeColor = Color.Black
        Label7.Location = New Point(138, 447)
        Label7.Name = "Label7"
        Label7.Size = New Size(140, 25)
        Label7.TabIndex = 20
        Label7.Text = "No account yet?"
        ' 
        ' txtpass
        ' 
        txtpass.Location = New Point(21, 260)
        txtpass.Name = "txtpass"
        txtpass.PasswordChar = "*"c
        txtpass.Size = New Size(444, 50)
        txtpass.TabIndex = 19
        ' 
        ' txtname
        ' 
        txtname.Location = New Point(17, 154)
        txtname.Name = "txtname"
        txtname.Size = New Size(444, 50)
        txtname.TabIndex = 18
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Font = New Font("Segoe UI", 9F)
        Label6.ForeColor = Color.Black
        Label6.Location = New Point(17, 226)
        Label6.Name = "Label6"
        Label6.Size = New Size(87, 25)
        Label6.TabIndex = 17
        Label6.Text = "Password"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Segoe UI", 9F)
        Label4.ForeColor = Color.Black
        Label4.Location = New Point(17, 117)
        Label4.Name = "Label4"
        Label4.Size = New Size(91, 25)
        Label4.TabIndex = 16
        Label4.Text = "Username"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Segoe UI", 9F)
        Label5.ForeColor = Color.Black
        Label5.Location = New Point(17, 46)
        Label5.Name = "Label5"
        Label5.Size = New Size(289, 25)
        Label5.TabIndex = 15
        Label5.Text = "Login in to your PlastiCash account"
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1428, 784)
        Controls.Add(SplitContainer1)
        Name = "Form1"
        Text = "Form1"
        SplitContainer1.Panel1.ResumeLayout(False)
        SplitContainer1.Panel1.PerformLayout()
        SplitContainer1.Panel2.ResumeLayout(False)
        CType(SplitContainer1, ComponentModel.ISupportInitialize).EndInit()
        SplitContainer1.ResumeLayout(False)
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        GroupBox1.ResumeLayout(False)
        GroupBox1.PerformLayout()
        ResumeLayout(False)
    End Sub

    Friend WithEvents SplitContainer1 As SplitContainer
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents lblGreet As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents LinkLabel1 As LinkLabel
    Friend WithEvents btnlogin As Button
    Friend WithEvents Label7 As Label
    Friend WithEvents txtpass As TextBox
    Friend WithEvents txtname As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label

End Class
