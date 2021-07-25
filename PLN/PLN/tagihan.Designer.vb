<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Tagihan
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Tagihan))
        Me.pemakaian = New System.Windows.Forms.TextBox()
        Me.TextBox10 = New System.Windows.Forms.TextBox()
        Me.kdtarif = New System.Windows.Forms.TextBox()
        Me.daya = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.PilihMenuToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TarifToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TagihanToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PembayaranToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PelangganToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PenggunaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LogoutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.idtagih = New System.Windows.Forms.TextBox()
        Me.kdtagih = New System.Windows.Forms.TextBox()
        Me.thtagih = New System.Windows.Forms.TextBox()
        Me.bltagih = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.Button6 = New System.Windows.Forms.Button()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.status = New System.Windows.Forms.TextBox()
        Me.SymbolBox1 = New DevComponents.DotNetBar.Controls.SymbolBox()
        Me.DataUserToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStrip1.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'pemakaian
        '
        Me.pemakaian.Location = New System.Drawing.Point(313, 120)
        Me.pemakaian.Name = "pemakaian"
        Me.pemakaian.ReadOnly = True
        Me.pemakaian.Size = New System.Drawing.Size(45, 20)
        Me.pemakaian.TabIndex = 0
        '
        'TextBox10
        '
        Me.TextBox10.Location = New System.Drawing.Point(74, 199)
        Me.TextBox10.Name = "TextBox10"
        Me.TextBox10.Size = New System.Drawing.Size(100, 20)
        Me.TextBox10.TabIndex = 1
        '
        'kdtarif
        '
        Me.kdtarif.Location = New System.Drawing.Point(242, 119)
        Me.kdtarif.Name = "kdtarif"
        Me.kdtarif.ReadOnly = True
        Me.kdtarif.Size = New System.Drawing.Size(45, 20)
        Me.kdtarif.TabIndex = 2
        '
        'daya
        '
        Me.daya.Location = New System.Drawing.Point(242, 145)
        Me.daya.Name = "daya"
        Me.daya.ReadOnly = True
        Me.daya.Size = New System.Drawing.Size(45, 20)
        Me.daya.TabIndex = 3
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(231, 90)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(65, 23)
        Me.Button1.TabIndex = 7
        Me.Button1.Text = "Pilih Tarif"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.Location = New System.Drawing.Point(302, 91)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(65, 23)
        Me.Button2.TabIndex = 8
        Me.Button2.Text = "Pemakaian"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(314, 147)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(41, 18)
        Me.Label3.TabIndex = 9
        Me.Label3.Text = "Total"
        '
        'TextBox1
        '
        Me.TextBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox1.Location = New System.Drawing.Point(313, 169)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.ReadOnly = True
        Me.TextBox1.Size = New System.Drawing.Size(45, 22)
        Me.TextBox1.TabIndex = 10
        '
        'ToolStrip1
        '
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.PilihMenuToolStripMenuItem, Me.PenggunaToolStripMenuItem})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(459, 25)
        Me.ToolStrip1.TabIndex = 11
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'PilihMenuToolStripMenuItem
        '
        Me.PilihMenuToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.TarifToolStripMenuItem, Me.TagihanToolStripMenuItem, Me.PembayaranToolStripMenuItem, Me.PelangganToolStripMenuItem, Me.DataUserToolStripMenuItem})
        Me.PilihMenuToolStripMenuItem.Name = "PilihMenuToolStripMenuItem"
        Me.PilihMenuToolStripMenuItem.Size = New System.Drawing.Size(76, 25)
        Me.PilihMenuToolStripMenuItem.Text = "Pilih Menu"
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
        Me.TagihanToolStripMenuItem.Text = "Pemakaian"
        '
        'PembayaranToolStripMenuItem
        '
        Me.PembayaranToolStripMenuItem.Name = "PembayaranToolStripMenuItem"
        Me.PembayaranToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.PembayaranToolStripMenuItem.Text = "Pembayaran"
        '
        'PelangganToolStripMenuItem
        '
        Me.PelangganToolStripMenuItem.Name = "PelangganToolStripMenuItem"
        Me.PelangganToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.PelangganToolStripMenuItem.Text = "Pelanggan"
        '
        'PenggunaToolStripMenuItem
        '
        Me.PenggunaToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.LogoutToolStripMenuItem})
        Me.PenggunaToolStripMenuItem.Name = "PenggunaToolStripMenuItem"
        Me.PenggunaToolStripMenuItem.Size = New System.Drawing.Size(73, 25)
        Me.PenggunaToolStripMenuItem.Text = "Pengguna"
        '
        'LogoutToolStripMenuItem
        '
        Me.LogoutToolStripMenuItem.Name = "LogoutToolStripMenuItem"
        Me.LogoutToolStripMenuItem.Size = New System.Drawing.Size(112, 22)
        Me.LogoutToolStripMenuItem.Text = "Logout"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(182, 122)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(56, 13)
        Me.Label4.TabIndex = 12
        Me.Label4.Text = "Kode Tarif"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(204, 148)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(32, 13)
        Me.Label5.TabIndex = 13
        Me.Label5.Text = "Daya"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(9, 89)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(18, 13)
        Me.Label1.TabIndex = 14
        Me.Label1.Text = "ID"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(9, 121)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(32, 13)
        Me.Label2.TabIndex = 15
        Me.Label2.Text = "Kode"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(9, 149)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(38, 13)
        Me.Label6.TabIndex = 16
        Me.Label6.Text = "Tahun"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(9, 176)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(49, 13)
        Me.Label7.TabIndex = 17
        Me.Label7.Text = "Bulan ke"
        '
        'idtagih
        '
        Me.idtagih.Location = New System.Drawing.Point(74, 89)
        Me.idtagih.Name = "idtagih"
        Me.idtagih.Size = New System.Drawing.Size(100, 20)
        Me.idtagih.TabIndex = 18
        '
        'kdtagih
        '
        Me.kdtagih.Location = New System.Drawing.Point(74, 118)
        Me.kdtagih.Name = "kdtagih"
        Me.kdtagih.Size = New System.Drawing.Size(100, 20)
        Me.kdtagih.TabIndex = 19
        '
        'thtagih
        '
        Me.thtagih.Location = New System.Drawing.Point(74, 146)
        Me.thtagih.Name = "thtagih"
        Me.thtagih.Size = New System.Drawing.Size(100, 20)
        Me.thtagih.TabIndex = 20
        '
        'bltagih
        '
        Me.bltagih.Location = New System.Drawing.Point(74, 173)
        Me.bltagih.Name = "bltagih"
        Me.bltagih.Size = New System.Drawing.Size(100, 20)
        Me.bltagih.TabIndex = 21
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(9, 202)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(58, 13)
        Me.Label8.TabIndex = 22
        Me.Label8.Text = "Pelanggan"
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(12, 275)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(432, 163)
        Me.DataGridView1.TabIndex = 23
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(304, 80)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(26, 13)
        Me.Label9.TabIndex = 24
        Me.Label9.Text = "Pilih"
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(174, 197)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(41, 23)
        Me.Button3.TabIndex = 25
        Me.Button3.Text = "Pilih Pelanggan"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button4
        '
        Me.Button4.Location = New System.Drawing.Point(12, 445)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(75, 23)
        Me.Button4.TabIndex = 26
        Me.Button4.Text = "Add"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'Button5
        '
        Me.Button5.Location = New System.Drawing.Point(93, 444)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(75, 23)
        Me.Button5.TabIndex = 27
        Me.Button5.Text = "Refresh"
        Me.Button5.UseVisualStyleBackColor = True
        '
        'Button6
        '
        Me.Button6.Location = New System.Drawing.Point(174, 444)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(75, 23)
        Me.Button6.TabIndex = 28
        Me.Button6.Text = "Delete"
        Me.Button6.UseVisualStyleBackColor = True
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(12, 228)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(37, 13)
        Me.Label10.TabIndex = 29
        Me.Label10.Text = "Status"
        '
        'status
        '
        Me.status.Location = New System.Drawing.Point(74, 225)
        Me.status.Name = "status"
        Me.status.ReadOnly = True
        Me.status.Size = New System.Drawing.Size(100, 20)
        Me.status.TabIndex = 30
        Me.status.Text = "Belum Lunas"
        '
        'SymbolBox1
        '
        Me.SymbolBox1.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        '
        '
        '
        Me.SymbolBox1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.SymbolBox1.Location = New System.Drawing.Point(12, 34)
        Me.SymbolBox1.Name = "SymbolBox1"
        Me.SymbolBox1.Size = New System.Drawing.Size(75, 23)
        Me.SymbolBox1.TabIndex = 52
        Me.SymbolBox1.Text = "SymbolBox1"
        '
        'DataUserToolStripMenuItem
        '
        Me.DataUserToolStripMenuItem.Name = "DataUserToolStripMenuItem"
        Me.DataUserToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.DataUserToolStripMenuItem.Text = "Data User"
        '
        'Tagihan
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(459, 475)
        Me.Controls.Add(Me.SymbolBox1)
        Me.Controls.Add(Me.status)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Button6)
        Me.Controls.Add(Me.Button5)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.bltagih)
        Me.Controls.Add(Me.thtagih)
        Me.Controls.Add(Me.kdtagih)
        Me.Controls.Add(Me.idtagih)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.daya)
        Me.Controls.Add(Me.kdtarif)
        Me.Controls.Add(Me.TextBox10)
        Me.Controls.Add(Me.pemakaian)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Tagihan"
        Me.Text = "Tagihan"
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents pemakaian As TextBox
    Friend WithEvents TextBox10 As TextBox
    Friend WithEvents kdtarif As TextBox
    Friend WithEvents daya As TextBox
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents ToolStrip1 As ToolStrip
    Friend WithEvents PilihMenuToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents TarifToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents TagihanToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PembayaranToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PelangganToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PenggunaToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents LogoutToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents idtagih As TextBox
    Friend WithEvents kdtagih As TextBox
    Friend WithEvents thtagih As TextBox
    Friend WithEvents bltagih As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Label9 As Label
    Friend WithEvents Button3 As Button
    Friend WithEvents Button4 As Button
    Friend WithEvents Button5 As Button
    Friend WithEvents Button6 As Button
    Friend WithEvents Label10 As Label
    Friend WithEvents status As TextBox
    Friend WithEvents SymbolBox1 As DevComponents.DotNetBar.Controls.SymbolBox
    Friend WithEvents DataUserToolStripMenuItem As ToolStripMenuItem
End Class
