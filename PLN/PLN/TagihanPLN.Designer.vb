<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class TagihanPLN
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
        Me.Button2 = New System.Windows.Forms.Button()
        Me.status = New System.Windows.Forms.ComboBox()
        Me.TextBox10 = New System.Windows.Forms.TextBox()
        Me.pemakaian = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.kdtarif = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.DGV = New System.Windows.Forms.DataGridView()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.bltagih = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.LogoutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PenggunaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.PelangganToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TarifToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PilihMenuToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PembayaranToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.kdtagih = New System.Windows.Forms.TextBox()
        Me.idtagih = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.thtagih = New System.Windows.Forms.TextBox()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.Button6 = New System.Windows.Forms.Button()
        CType(Me.DGV, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(521, 172)
        Me.Button2.Margin = New System.Windows.Forms.Padding(2)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(33, 20)
        Me.Button2.TabIndex = 63
        Me.Button2.Text = "V"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'status
        '
        Me.status.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.status.FormattingEnabled = True
        Me.status.Items.AddRange(New Object() {"Lunas", "Belum Lunas"})
        Me.status.Location = New System.Drawing.Point(389, 133)
        Me.status.Margin = New System.Windows.Forms.Padding(2)
        Me.status.Name = "status"
        Me.status.Size = New System.Drawing.Size(166, 21)
        Me.status.TabIndex = 61
        '
        'TextBox10
        '
        Me.TextBox10.Location = New System.Drawing.Point(389, 173)
        Me.TextBox10.Margin = New System.Windows.Forms.Padding(2)
        Me.TextBox10.Name = "TextBox10"
        Me.TextBox10.ReadOnly = True
        Me.TextBox10.Size = New System.Drawing.Size(128, 20)
        Me.TextBox10.TabIndex = 60
        '
        'pemakaian
        '
        Me.pemakaian.Location = New System.Drawing.Point(389, 93)
        Me.pemakaian.Margin = New System.Windows.Forms.Padding(2)
        Me.pemakaian.Name = "pemakaian"
        Me.pemakaian.ReadOnly = True
        Me.pemakaian.Size = New System.Drawing.Size(166, 20)
        Me.pemakaian.TabIndex = 59
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(299, 53)
        Me.Label10.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(56, 13)
        Me.Label10.TabIndex = 58
        Me.Label10.Text = "Kode Tarif"
        '
        'kdtarif
        '
        Me.kdtarif.Location = New System.Drawing.Point(389, 51)
        Me.kdtarif.Margin = New System.Windows.Forms.Padding(2)
        Me.kdtarif.Name = "kdtarif"
        Me.kdtarif.ReadOnly = True
        Me.kdtarif.Size = New System.Drawing.Size(128, 20)
        Me.kdtarif.TabIndex = 57
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(299, 133)
        Me.Label8.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(37, 13)
        Me.Label8.TabIndex = 56
        Me.Label8.Text = "Status"
        '
        'DGV
        '
        Me.DGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGV.Location = New System.Drawing.Point(18, 215)
        Me.DGV.Margin = New System.Windows.Forms.Padding(2)
        Me.DGV.Name = "DGV"
        Me.DGV.RowTemplate.Height = 24
        Me.DGV.Size = New System.Drawing.Size(597, 214)
        Me.DGV.TabIndex = 55
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(299, 173)
        Me.Label3.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(86, 13)
        Me.Label3.TabIndex = 54
        Me.Label3.Text = "Kode Pelanggan"
        '
        'bltagih
        '
        Me.bltagih.Location = New System.Drawing.Point(124, 173)
        Me.bltagih.Margin = New System.Windows.Forms.Padding(2)
        Me.bltagih.Name = "bltagih"
        Me.bltagih.ReadOnly = True
        Me.bltagih.Size = New System.Drawing.Size(144, 20)
        Me.bltagih.TabIndex = 53
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(299, 95)
        Me.Label4.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(60, 13)
        Me.Label4.TabIndex = 52
        Me.Label4.Text = "Pemakaian"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(38, 173)
        Me.Label5.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(50, 13)
        Me.Label5.TabIndex = 51
        Me.Label5.Text = "Bulan Ke"
        '
        'LogoutToolStripMenuItem
        '
        Me.LogoutToolStripMenuItem.Name = "LogoutToolStripMenuItem"
        Me.LogoutToolStripMenuItem.Size = New System.Drawing.Size(112, 22)
        Me.LogoutToolStripMenuItem.Text = "Logout"
        '
        'PenggunaToolStripMenuItem
        '
        Me.PenggunaToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.LogoutToolStripMenuItem})
        Me.PenggunaToolStripMenuItem.Name = "PenggunaToolStripMenuItem"
        Me.PenggunaToolStripMenuItem.Size = New System.Drawing.Size(73, 20)
        Me.PenggunaToolStripMenuItem.Text = "Pengguna"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(521, 51)
        Me.Button1.Margin = New System.Windows.Forms.Padding(2)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(33, 20)
        Me.Button1.TabIndex = 62
        Me.Button1.Text = "V"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'PelangganToolStripMenuItem
        '
        Me.PelangganToolStripMenuItem.Name = "PelangganToolStripMenuItem"
        Me.PelangganToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.PelangganToolStripMenuItem.Text = "Pelanggan"
        '
        'TarifToolStripMenuItem
        '
        Me.TarifToolStripMenuItem.Name = "TarifToolStripMenuItem"
        Me.TarifToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.TarifToolStripMenuItem.Text = "Tarif"
        '
        'PilihMenuToolStripMenuItem
        '
        Me.PilihMenuToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.TarifToolStripMenuItem, Me.PembayaranToolStripMenuItem, Me.PelangganToolStripMenuItem})
        Me.PilihMenuToolStripMenuItem.Name = "PilihMenuToolStripMenuItem"
        Me.PilihMenuToolStripMenuItem.Size = New System.Drawing.Size(76, 20)
        Me.PilihMenuToolStripMenuItem.Text = "Pilih Menu"
        '
        'PembayaranToolStripMenuItem
        '
        Me.PembayaranToolStripMenuItem.Name = "PembayaranToolStripMenuItem"
        Me.PembayaranToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.PembayaranToolStripMenuItem.Text = "Pembayaran"
        '
        'MenuStrip1
        '
        Me.MenuStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.PilihMenuToolStripMenuItem, Me.PenggunaToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Padding = New System.Windows.Forms.Padding(4, 2, 0, 2)
        Me.MenuStrip1.Size = New System.Drawing.Size(634, 24)
        Me.MenuStrip1.TabIndex = 50
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(38, 131)
        Me.Label9.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(68, 13)
        Me.Label9.TabIndex = 48
        Me.Label9.Text = "Tahun Tagih"
        '
        'kdtagih
        '
        Me.kdtagih.Location = New System.Drawing.Point(124, 95)
        Me.kdtagih.Margin = New System.Windows.Forms.Padding(2)
        Me.kdtagih.Name = "kdtagih"
        Me.kdtagih.ReadOnly = True
        Me.kdtagih.Size = New System.Drawing.Size(144, 20)
        Me.kdtagih.TabIndex = 47
        '
        'idtagih
        '
        Me.idtagih.Location = New System.Drawing.Point(124, 51)
        Me.idtagih.Margin = New System.Windows.Forms.Padding(2)
        Me.idtagih.Name = "idtagih"
        Me.idtagih.ReadOnly = True
        Me.idtagih.Size = New System.Drawing.Size(144, 20)
        Me.idtagih.TabIndex = 46
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(38, 95)
        Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(62, 13)
        Me.Label2.TabIndex = 45
        Me.Label2.Text = "Kode Tagih"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(38, 51)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(60, 13)
        Me.Label1.TabIndex = 44
        Me.Label1.Text = "ID Tagihan"
        '
        'thtagih
        '
        Me.thtagih.Location = New System.Drawing.Point(124, 131)
        Me.thtagih.Margin = New System.Windows.Forms.Padding(2)
        Me.thtagih.Name = "thtagih"
        Me.thtagih.ReadOnly = True
        Me.thtagih.Size = New System.Drawing.Size(144, 20)
        Me.thtagih.TabIndex = 49
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(18, 434)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(75, 23)
        Me.Button3.TabIndex = 64
        Me.Button3.Text = "Tambah"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button4
        '
        Me.Button4.Location = New System.Drawing.Point(99, 434)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(75, 23)
        Me.Button4.TabIndex = 65
        Me.Button4.Text = "Edit"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'Button5
        '
        Me.Button5.Location = New System.Drawing.Point(180, 434)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(75, 23)
        Me.Button5.TabIndex = 66
        Me.Button5.Text = "Refresh"
        Me.Button5.UseVisualStyleBackColor = True
        '
        'Button6
        '
        Me.Button6.Location = New System.Drawing.Point(261, 434)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(75, 23)
        Me.Button6.TabIndex = 67
        Me.Button6.Text = "Hapus"
        Me.Button6.UseVisualStyleBackColor = True
        '
        'TagihanPLN
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(634, 475)
        Me.Controls.Add(Me.Button6)
        Me.Controls.Add(Me.Button5)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.status)
        Me.Controls.Add(Me.TextBox10)
        Me.Controls.Add(Me.pemakaian)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.kdtarif)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.DGV)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.bltagih)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.kdtagih)
        Me.Controls.Add(Me.idtagih)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.thtagih)
        Me.Name = "TagihanPLN"
        Me.Text = "TagihanPLN"
        CType(Me.DGV, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Button2 As Button
    Friend WithEvents status As ComboBox
    Friend WithEvents TextBox10 As TextBox
    Friend WithEvents pemakaian As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents kdtarif As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents DGV As DataGridView
    Friend WithEvents Label3 As Label
    Friend WithEvents bltagih As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents LogoutToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PenggunaToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Button1 As Button
    Friend WithEvents PelangganToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents TarifToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PilihMenuToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PembayaranToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents Label9 As Label
    Friend WithEvents kdtagih As TextBox
    Friend WithEvents idtagih As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents thtagih As TextBox
    Friend WithEvents Button3 As Button
    Friend WithEvents Button4 As Button
    Friend WithEvents Button5 As Button
    Friend WithEvents Button6 As Button
End Class
