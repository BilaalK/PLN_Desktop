<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Pembayaran
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Pembayaran))
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.biaya_admin = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.denda = New System.Windows.Forms.TextBox()
        Me.tgl = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.kdbayar = New System.Windows.Forms.TextBox()
        Me.idbayar = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.status = New System.Windows.Forms.ComboBox()
        Me.tagih = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.kdtagih = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.DGV = New System.Windows.Forms.DataGridView()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.PilihMenuToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TarifToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TagihanToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PelangganToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PemakaianToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PenggunaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LogoutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.SymbolBox1 = New DevComponents.DotNetBar.Controls.SymbolBox()
        Me.DataUserToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        CType(Me.DGV, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'TextBox3
        '
        Me.TextBox3.Location = New System.Drawing.Point(107, 233)
        Me.TextBox3.Margin = New System.Windows.Forms.Padding(2)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.ReadOnly = True
        Me.TextBox3.Size = New System.Drawing.Size(166, 20)
        Me.TextBox3.TabIndex = 88
        '
        'biaya_admin
        '
        Me.biaya_admin.Location = New System.Drawing.Point(427, 162)
        Me.biaya_admin.Margin = New System.Windows.Forms.Padding(2)
        Me.biaya_admin.Name = "biaya_admin"
        Me.biaya_admin.ReadOnly = True
        Me.biaya_admin.Size = New System.Drawing.Size(166, 20)
        Me.biaya_admin.TabIndex = 86
        Me.biaya_admin.Text = "2500"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(337, 162)
        Me.Label5.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(65, 13)
        Me.Label5.TabIndex = 85
        Me.Label5.Text = "Biaya Admin"
        '
        'denda
        '
        Me.denda.Location = New System.Drawing.Point(427, 122)
        Me.denda.Margin = New System.Windows.Forms.Padding(2)
        Me.denda.Name = "denda"
        Me.denda.ReadOnly = True
        Me.denda.Size = New System.Drawing.Size(166, 20)
        Me.denda.TabIndex = 84
        '
        'tgl
        '
        Me.tgl.Location = New System.Drawing.Point(107, 160)
        Me.tgl.Margin = New System.Windows.Forms.Padding(2)
        Me.tgl.Name = "tgl"
        Me.tgl.ReadOnly = True
        Me.tgl.Size = New System.Drawing.Size(164, 20)
        Me.tgl.TabIndex = 74
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(21, 160)
        Me.Label9.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(76, 13)
        Me.Label9.TabIndex = 73
        Me.Label9.Text = "Tanggal Bayar"
        '
        'kdbayar
        '
        Me.kdbayar.Location = New System.Drawing.Point(107, 120)
        Me.kdbayar.Margin = New System.Windows.Forms.Padding(2)
        Me.kdbayar.Name = "kdbayar"
        Me.kdbayar.ReadOnly = True
        Me.kdbayar.Size = New System.Drawing.Size(164, 20)
        Me.kdbayar.TabIndex = 72
        '
        'idbayar
        '
        Me.idbayar.Location = New System.Drawing.Point(107, 76)
        Me.idbayar.Margin = New System.Windows.Forms.Padding(2)
        Me.idbayar.Name = "idbayar"
        Me.idbayar.ReadOnly = True
        Me.idbayar.Size = New System.Drawing.Size(164, 20)
        Me.idbayar.TabIndex = 71
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(21, 120)
        Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(62, 13)
        Me.Label2.TabIndex = 70
        Me.Label2.Text = "Kode Bayar"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(21, 76)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(48, 13)
        Me.Label1.TabIndex = 69
        Me.Label1.Text = "ID Bayar"
        '
        'status
        '
        Me.status.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.status.FormattingEnabled = True
        Me.status.Items.AddRange(New Object() {"Lunas", "Belum Lunas"})
        Me.status.Location = New System.Drawing.Point(427, 201)
        Me.status.Margin = New System.Windows.Forms.Padding(2)
        Me.status.Name = "status"
        Me.status.Size = New System.Drawing.Size(166, 21)
        Me.status.TabIndex = 87
        '
        'tagih
        '
        Me.tagih.Location = New System.Drawing.Point(427, 81)
        Me.tagih.Margin = New System.Windows.Forms.Padding(2)
        Me.tagih.Name = "tagih"
        Me.tagih.ReadOnly = True
        Me.tagih.Size = New System.Drawing.Size(166, 20)
        Me.tagih.TabIndex = 82
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(21, 201)
        Me.Label10.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(74, 13)
        Me.Label10.TabIndex = 81
        Me.Label10.Text = "Kode Tagihan"
        '
        'kdtagih
        '
        Me.kdtagih.Location = New System.Drawing.Point(107, 199)
        Me.kdtagih.Margin = New System.Windows.Forms.Padding(2)
        Me.kdtagih.Multiline = True
        Me.kdtagih.Name = "kdtagih"
        Me.kdtagih.ReadOnly = True
        Me.kdtagih.Size = New System.Drawing.Size(128, 20)
        Me.kdtagih.TabIndex = 80
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(337, 122)
        Me.Label8.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(68, 13)
        Me.Label8.TabIndex = 79
        Me.Label8.Text = "Biaya Denda"
        '
        'DGV
        '
        Me.DGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGV.Location = New System.Drawing.Point(24, 269)
        Me.DGV.Margin = New System.Windows.Forms.Padding(2)
        Me.DGV.Name = "DGV"
        Me.DGV.RowTemplate.Height = 24
        Me.DGV.Size = New System.Drawing.Size(569, 183)
        Me.DGV.TabIndex = 78
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(337, 203)
        Me.Label3.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(37, 13)
        Me.Label3.TabIndex = 77
        Me.Label3.Text = "Status"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(337, 81)
        Me.Label4.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(82, 13)
        Me.Label4.TabIndex = 76
        Me.Label4.Text = "Jumlah Tagihan"
        '
        'MenuStrip1
        '
        Me.MenuStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.PilihMenuToolStripMenuItem, Me.PenggunaToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Padding = New System.Windows.Forms.Padding(4, 2, 0, 2)
        Me.MenuStrip1.Size = New System.Drawing.Size(636, 24)
        Me.MenuStrip1.TabIndex = 75
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'PilihMenuToolStripMenuItem
        '
        Me.PilihMenuToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.TarifToolStripMenuItem, Me.TagihanToolStripMenuItem, Me.PelangganToolStripMenuItem, Me.PemakaianToolStripMenuItem, Me.DataUserToolStripMenuItem})
        Me.PilihMenuToolStripMenuItem.Name = "PilihMenuToolStripMenuItem"
        Me.PilihMenuToolStripMenuItem.Size = New System.Drawing.Size(50, 20)
        Me.PilihMenuToolStripMenuItem.Text = "Menu"
        '
        'TarifToolStripMenuItem
        '
        Me.TarifToolStripMenuItem.Name = "TarifToolStripMenuItem"
        Me.TarifToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.TarifToolStripMenuItem.Text = "Tarif"
        '
        'TagihanToolStripMenuItem
        '
        Me.TagihanToolStripMenuItem.Name = "TagihanToolStripMenuItem"
        Me.TagihanToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.TagihanToolStripMenuItem.Text = "Tagihan"
        '
        'PelangganToolStripMenuItem
        '
        Me.PelangganToolStripMenuItem.Name = "PelangganToolStripMenuItem"
        Me.PelangganToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.PelangganToolStripMenuItem.Text = "Pelanggan"
        '
        'PemakaianToolStripMenuItem
        '
        Me.PemakaianToolStripMenuItem.Name = "PemakaianToolStripMenuItem"
        Me.PemakaianToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.PemakaianToolStripMenuItem.Text = "Pemakaian"
        '
        'PenggunaToolStripMenuItem
        '
        Me.PenggunaToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.LogoutToolStripMenuItem})
        Me.PenggunaToolStripMenuItem.Name = "PenggunaToolStripMenuItem"
        Me.PenggunaToolStripMenuItem.Size = New System.Drawing.Size(73, 20)
        Me.PenggunaToolStripMenuItem.Text = "Pengguna"
        '
        'LogoutToolStripMenuItem
        '
        Me.LogoutToolStripMenuItem.Name = "LogoutToolStripMenuItem"
        Me.LogoutToolStripMenuItem.Size = New System.Drawing.Size(112, 22)
        Me.LogoutToolStripMenuItem.Text = "Logout"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(237, 199)
        Me.Button1.Margin = New System.Windows.Forms.Padding(2)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(34, 20)
        Me.Button1.TabIndex = 83
        Me.Button1.Text = "V"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(24, 461)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(75, 23)
        Me.Button3.TabIndex = 90
        Me.Button3.Text = "Tambah"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(105, 461)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 23)
        Me.Button2.TabIndex = 91
        Me.Button2.Text = "Edit"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button4
        '
        Me.Button4.Location = New System.Drawing.Point(186, 461)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(75, 23)
        Me.Button4.TabIndex = 92
        Me.Button4.Text = "Refresh"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'Button5
        '
        Me.Button5.Location = New System.Drawing.Point(267, 461)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(75, 23)
        Me.Button5.TabIndex = 93
        Me.Button5.Text = "Hapus"
        Me.Button5.UseVisualStyleBackColor = True
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(21, 236)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(73, 13)
        Me.Label6.TabIndex = 94
        Me.Label6.Text = "Total Tagihan"
        '
        'SymbolBox1
        '
        Me.SymbolBox1.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        '
        '
        '
        Me.SymbolBox1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.SymbolBox1.Location = New System.Drawing.Point(24, 36)
        Me.SymbolBox1.Name = "SymbolBox1"
        Me.SymbolBox1.Size = New System.Drawing.Size(75, 23)
        Me.SymbolBox1.TabIndex = 95
        Me.SymbolBox1.Text = "SymbolBox1"
        '
        'DataUserToolStripMenuItem
        '
        Me.DataUserToolStripMenuItem.Name = "DataUserToolStripMenuItem"
        Me.DataUserToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.DataUserToolStripMenuItem.Text = "Data User"
        '
        'Pembayaran
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(636, 494)
        Me.Controls.Add(Me.SymbolBox1)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Button5)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.TextBox3)
        Me.Controls.Add(Me.biaya_admin)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.denda)
        Me.Controls.Add(Me.tgl)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.kdbayar)
        Me.Controls.Add(Me.idbayar)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.status)
        Me.Controls.Add(Me.tagih)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.kdtagih)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.DGV)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Controls.Add(Me.Button1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Pembayaran"
        Me.Text = "Pembayaran"
        CType(Me.DGV, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents biaya_admin As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents denda As TextBox
    Friend WithEvents tgl As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents kdbayar As TextBox
    Friend WithEvents idbayar As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents status As ComboBox
    Friend WithEvents tagih As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents kdtagih As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents DGV As DataGridView
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents Button1 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button4 As Button
    Friend WithEvents Button5 As Button
    Friend WithEvents PilihMenuToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents TarifToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents TagihanToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PelangganToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PenggunaToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents LogoutToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PemakaianToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Label6 As Label
    Friend WithEvents SymbolBox1 As DevComponents.DotNetBar.Controls.SymbolBox
    Friend WithEvents DataUserToolStripMenuItem As ToolStripMenuItem
End Class
