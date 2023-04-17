<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form4
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
        Panel15 = New Panel()
        Panel3 = New Panel()
        Label3 = New Label()
        DataGridView1 = New DataGridView()
        Column1 = New DataGridViewTextBoxColumn()
        Column2 = New DataGridViewTextBoxColumn()
        Column3 = New DataGridViewTextBoxColumn()
        Column4 = New DataGridViewTextBoxColumn()
        DateTimePicker1 = New DateTimePicker()
        Label2 = New Label()
        Button10 = New Button()
        Button9 = New Button()
        Button8 = New Button()
        Button7 = New Button()
        Panel2 = New Panel()
        Label1 = New Label()
        Panel1 = New Panel()
        Label15 = New Label()
        Button6 = New Button()
        Button5 = New Button()
        Button4 = New Button()
        Button3 = New Button()
        Button2 = New Button()
        Button1 = New Button()
        PictureBox2 = New PictureBox()
        Panel15.SuspendLayout()
        Panel3.SuspendLayout()
        CType(DataGridView1, ComponentModel.ISupportInitialize).BeginInit()
        Panel2.SuspendLayout()
        Panel1.SuspendLayout()
        CType(PictureBox2, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Panel15
        ' 
        Panel15.BackColor = Color.OliveDrab
        Panel15.Controls.Add(Panel3)
        Panel15.Controls.Add(Button10)
        Panel15.Controls.Add(Button9)
        Panel15.Controls.Add(Button8)
        Panel15.Controls.Add(Button7)
        Panel15.Dock = DockStyle.Fill
        Panel15.ForeColor = SystemColors.InfoText
        Panel15.Location = New Point(281, 151)
        Panel15.Name = "Panel15"
        Panel15.Size = New Size(836, 359)
        Panel15.TabIndex = 8
        ' 
        ' Panel3
        ' 
        Panel3.BackColor = Color.DarkKhaki
        Panel3.Controls.Add(Label3)
        Panel3.Controls.Add(DataGridView1)
        Panel3.Controls.Add(DateTimePicker1)
        Panel3.Controls.Add(Label2)
        Panel3.Font = New Font("Tahoma", 9F, FontStyle.Regular, GraphicsUnit.Point)
        Panel3.ForeColor = Color.FromArgb(CByte(64), CByte(64), CByte(64))
        Panel3.Location = New Point(22, 92)
        Panel3.Name = "Panel3"
        Panel3.Size = New Size(797, 255)
        Panel3.TabIndex = 21
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.BackColor = Color.Transparent
        Label3.Location = New Point(101, 180)
        Label3.Name = "Label3"
        Label3.Size = New Size(130, 22)
        Label3.TabIndex = 26
        Label3.Text = "Total Amount: "
        ' 
        ' DataGridView1
        ' 
        DataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridView1.Columns.AddRange(New DataGridViewColumn() {Column1, Column2, Column3, Column4})
        DataGridView1.Location = New Point(78, 59)
        DataGridView1.Name = "DataGridView1"
        DataGridView1.RowHeadersWidth = 62
        DataGridView1.RowTemplate.Height = 33
        DataGridView1.Size = New Size(663, 185)
        DataGridView1.TabIndex = 25
        ' 
        ' Column1
        ' 
        Column1.HeaderText = "Barcode"
        Column1.MinimumWidth = 8
        Column1.Name = "Column1"
        Column1.ToolTipText = "ssda"
        Column1.Width = 150
        ' 
        ' Column2
        ' 
        Column2.HeaderText = "Product"
        Column2.MinimumWidth = 8
        Column2.Name = "Column2"
        Column2.Width = 150
        ' 
        ' Column3
        ' 
        Column3.HeaderText = "Quantity"
        Column3.MinimumWidth = 8
        Column3.Name = "Column3"
        Column3.Width = 150
        ' 
        ' Column4
        ' 
        Column4.HeaderText = "Payment"
        Column4.MinimumWidth = 8
        Column4.Name = "Column4"
        Column4.Width = 150
        ' 
        ' DateTimePicker1
        ' 
        DateTimePicker1.Location = New Point(467, 24)
        DateTimePicker1.Name = "DateTimePicker1"
        DateTimePicker1.Size = New Size(300, 29)
        DateTimePicker1.TabIndex = 24
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(34, 24)
        Label2.Name = "Label2"
        Label2.Size = New Size(152, 22)
        Label2.TabIndex = 22
        Label2.Text = "Daily Sales Report"
        ' 
        ' Button10
        ' 
        Button10.BackColor = Color.YellowGreen
        Button10.Font = New Font("Tahoma", 9F, FontStyle.Regular, GraphicsUnit.Point)
        Button10.ForeColor = Color.FromArgb(CByte(64), CByte(64), CByte(64))
        Button10.Location = New Point(595, 22)
        Button10.Name = "Button10"
        Button10.Size = New Size(184, 50)
        Button10.TabIndex = 20
        Button10.Text = "Remaining Items"
        Button10.UseVisualStyleBackColor = False
        ' 
        ' Button9
        ' 
        Button9.BackColor = Color.YellowGreen
        Button9.Font = New Font("Tahoma", 9F, FontStyle.Regular, GraphicsUnit.Point)
        Button9.ForeColor = Color.FromArgb(CByte(64), CByte(64), CByte(64))
        Button9.Location = New Point(219, 22)
        Button9.Name = "Button9"
        Button9.Size = New Size(159, 50)
        Button9.TabIndex = 19
        Button9.Text = "Montly Sales"
        Button9.UseVisualStyleBackColor = False
        ' 
        ' Button8
        ' 
        Button8.BackColor = Color.YellowGreen
        Button8.Font = New Font("Tahoma", 9F, FontStyle.Regular, GraphicsUnit.Point)
        Button8.ForeColor = Color.FromArgb(CByte(64), CByte(64), CByte(64))
        Button8.Location = New Point(429, 22)
        Button8.Name = "Button8"
        Button8.Size = New Size(112, 50)
        Button8.TabIndex = 18
        Button8.Text = "Sold Items"
        Button8.UseVisualStyleBackColor = False
        ' 
        ' Button7
        ' 
        Button7.BackColor = Color.YellowGreen
        Button7.Font = New Font("Tahoma", 9F, FontStyle.Regular, GraphicsUnit.Point)
        Button7.ForeColor = Color.FromArgb(CByte(64), CByte(64), CByte(64))
        Button7.Location = New Point(56, 22)
        Button7.Name = "Button7"
        Button7.Size = New Size(112, 50)
        Button7.TabIndex = 17
        Button7.Text = "Daily Sales"
        Button7.UseVisualStyleBackColor = False
        ' 
        ' Panel2
        ' 
        Panel2.BackColor = Color.FromArgb(CByte(192), CByte(235), CByte(192))
        Panel2.Controls.Add(Label1)
        Panel2.Dock = DockStyle.Top
        Panel2.Location = New Point(281, 0)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(836, 151)
        Panel2.TabIndex = 7
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Tahoma", 24F, FontStyle.Bold, GraphicsUnit.Point)
        Label1.ForeColor = Color.FromArgb(CByte(64), CByte(64), CByte(64))
        Label1.Location = New Point(231, 50)
        Label1.Name = "Label1"
        Label1.Size = New Size(387, 58)
        Label1.TabIndex = 0
        Label1.Text = "SALES REPORT"
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.FromArgb(CByte(192), CByte(235), CByte(192))
        Panel1.Controls.Add(Label15)
        Panel1.Controls.Add(Button6)
        Panel1.Controls.Add(Button5)
        Panel1.Controls.Add(Button4)
        Panel1.Controls.Add(Button3)
        Panel1.Controls.Add(Button2)
        Panel1.Controls.Add(Button1)
        Panel1.Controls.Add(PictureBox2)
        Panel1.Dock = DockStyle.Left
        Panel1.Location = New Point(0, 0)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(281, 510)
        Panel1.TabIndex = 6
        ' 
        ' Label15
        ' 
        Label15.AutoSize = True
        Label15.Location = New Point(304, 309)
        Label15.Name = "Label15"
        Label15.Size = New Size(89, 25)
        Label15.TabIndex = 3
        Label15.Text = "Product 2"
        ' 
        ' Button6
        ' 
        Button6.BackColor = Color.YellowGreen
        Button6.FlatStyle = FlatStyle.Flat
        Button6.Font = New Font("Segoe UI Emoji", 9F, FontStyle.Bold, GraphicsUnit.Point)
        Button6.ForeColor = Color.Black
        Button6.Location = New Point(58, 411)
        Button6.Name = "Button6"
        Button6.Size = New Size(162, 34)
        Button6.TabIndex = 16
        Button6.Text = "Employees"
        Button6.UseVisualStyleBackColor = False
        ' 
        ' Button5
        ' 
        Button5.BackColor = Color.YellowGreen
        Button5.FlatStyle = FlatStyle.Flat
        Button5.Font = New Font("Segoe UI Emoji", 9F, FontStyle.Bold, GraphicsUnit.Point)
        Button5.ForeColor = Color.Black
        Button5.Location = New Point(58, 366)
        Button5.Name = "Button5"
        Button5.Size = New Size(162, 34)
        Button5.TabIndex = 15
        Button5.Text = "Vendors"
        Button5.UseVisualStyleBackColor = False
        ' 
        ' Button4
        ' 
        Button4.BackColor = Color.YellowGreen
        Button4.FlatStyle = FlatStyle.Flat
        Button4.Font = New Font("Segoe UI Emoji", 9F, FontStyle.Bold, GraphicsUnit.Point)
        Button4.ForeColor = Color.Black
        Button4.Location = New Point(58, 315)
        Button4.Name = "Button4"
        Button4.Size = New Size(162, 34)
        Button4.TabIndex = 14
        Button4.Text = "Clients"
        Button4.UseVisualStyleBackColor = False
        ' 
        ' Button3
        ' 
        Button3.BackColor = Color.YellowGreen
        Button3.FlatStyle = FlatStyle.Flat
        Button3.Font = New Font("Segoe UI Emoji", 9F, FontStyle.Bold, GraphicsUnit.Point)
        Button3.ForeColor = Color.Black
        Button3.Location = New Point(58, 267)
        Button3.Name = "Button3"
        Button3.Size = New Size(162, 34)
        Button3.TabIndex = 13
        Button3.Text = "Sales Report"
        Button3.UseVisualStyleBackColor = False
        ' 
        ' Button2
        ' 
        Button2.BackColor = Color.YellowGreen
        Button2.FlatStyle = FlatStyle.Flat
        Button2.Font = New Font("Segoe UI Emoji", 9F, FontStyle.Bold, GraphicsUnit.Point)
        Button2.ForeColor = Color.Black
        Button2.Location = New Point(58, 217)
        Button2.Name = "Button2"
        Button2.Size = New Size(162, 34)
        Button2.TabIndex = 12
        Button2.Text = "Products"
        Button2.UseVisualStyleBackColor = False
        ' 
        ' Button1
        ' 
        Button1.BackColor = Color.YellowGreen
        Button1.FlatStyle = FlatStyle.Flat
        Button1.Font = New Font("Segoe UI Emoji", 9F, FontStyle.Bold, GraphicsUnit.Point)
        Button1.ForeColor = Color.Black
        Button1.Location = New Point(58, 167)
        Button1.Name = "Button1"
        Button1.Size = New Size(162, 34)
        Button1.TabIndex = 11
        Button1.Text = "Dashboard"
        Button1.UseVisualStyleBackColor = False
        ' 
        ' PictureBox2
        ' 
        PictureBox2.BackColor = Color.OliveDrab
        PictureBox2.BackgroundImageLayout = ImageLayout.None
        PictureBox2.Dock = DockStyle.Top
        PictureBox2.Image = My.Resources.Resources._334893374_1284553268794967_3187038752484035069_n
        PictureBox2.Location = New Point(0, 0)
        PictureBox2.Margin = New Padding(0)
        PictureBox2.Name = "PictureBox2"
        PictureBox2.Size = New Size(281, 151)
        PictureBox2.SizeMode = PictureBoxSizeMode.Zoom
        PictureBox2.TabIndex = 10
        PictureBox2.TabStop = False
        ' 
        ' Form4
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1117, 510)
        Controls.Add(Panel15)
        Controls.Add(Panel2)
        Controls.Add(Panel1)
        Cursor = Cursors.SizeAll
        Name = "Form4"
        Text = "Form4"
        Panel15.ResumeLayout(False)
        Panel3.ResumeLayout(False)
        Panel3.PerformLayout()
        CType(DataGridView1, ComponentModel.ISupportInitialize).EndInit()
        Panel2.ResumeLayout(False)
        Panel2.PerformLayout()
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        CType(PictureBox2, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub

    Friend WithEvents Button1 As Button
    Friend WithEvents Panel15 As Panel
    Friend WithEvents Button9 As Button
    Friend WithEvents Button8 As Button
    Friend WithEvents Button7 As Button
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label15 As Label
    Friend WithEvents Button6 As Button
    Friend WithEvents Button5 As Button
    Friend WithEvents Button4 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents Button10 As Button
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Label2 As Label
    Friend WithEvents DateTimePicker1 As DateTimePicker
    Friend WithEvents Label3 As Label
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
    Friend WithEvents Column3 As DataGridViewTextBoxColumn
    Friend WithEvents Column4 As DataGridViewTextBoxColumn
End Class
