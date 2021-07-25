<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Home
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Home))
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.ToolStripButton1 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripDropDownButton2 = New System.Windows.Forms.ToolStripDropDownButton()
        Me.PenggunaToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.TarifToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.PemakaianToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.TagihanToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.PemakaianToolStripMenuItem2 = New System.Windows.Forms.ToolStripMenuItem()
        Me.DataUserToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripDropDownButton1 = New System.Windows.Forms.ToolStripDropDownButton()
        Me.PenggunaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TarifToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PemakaianToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TagihanToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PembayaranToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.SymbolBox1 = New DevComponents.DotNetBar.Controls.SymbolBox()
        Me.SymbolBox2 = New DevComponents.DotNetBar.Controls.SymbolBox()
        Me.SymbolBox3 = New DevComponents.DotNetBar.Controls.SymbolBox()
        Me.ToolStrip1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ToolStrip1
        '
        Me.ToolStrip1.BackColor = System.Drawing.Color.Yellow
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripDropDownButton2, Me.ToolStripButton1})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(470, 25)
        Me.ToolStrip1.TabIndex = 0
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'ToolStripButton1
        '
        Me.ToolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.ToolStripButton1.Image = CType(resources.GetObject("ToolStripButton1.Image"), System.Drawing.Image)
        Me.ToolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton1.Name = "ToolStripButton1"
        Me.ToolStripButton1.Size = New System.Drawing.Size(54, 22)
        Me.ToolStripButton1.Text = "Log Out"
        '
        'ToolStripDropDownButton2
        '
        Me.ToolStripDropDownButton2.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.PenggunaToolStripMenuItem1, Me.TarifToolStripMenuItem1, Me.PemakaianToolStripMenuItem1, Me.TagihanToolStripMenuItem1, Me.PemakaianToolStripMenuItem2, Me.DataUserToolStripMenuItem})
        Me.ToolStripDropDownButton2.ForeColor = System.Drawing.Color.Black
        Me.ToolStripDropDownButton2.Image = CType(resources.GetObject("ToolStripDropDownButton2.Image"), System.Drawing.Image)
        Me.ToolStripDropDownButton2.ImageTransparentColor = System.Drawing.Color.Yellow
        Me.ToolStripDropDownButton2.Name = "ToolStripDropDownButton2"
        Me.ToolStripDropDownButton2.Size = New System.Drawing.Size(67, 22)
        Me.ToolStripDropDownButton2.Text = "Menu"
        '
        'PenggunaToolStripMenuItem1
        '
        Me.PenggunaToolStripMenuItem1.Name = "PenggunaToolStripMenuItem1"
        Me.PenggunaToolStripMenuItem1.Size = New System.Drawing.Size(152, 22)
        Me.PenggunaToolStripMenuItem1.Text = "Pengguna"
        '
        'TarifToolStripMenuItem1
        '
        Me.TarifToolStripMenuItem1.Name = "TarifToolStripMenuItem1"
        Me.TarifToolStripMenuItem1.Size = New System.Drawing.Size(152, 22)
        Me.TarifToolStripMenuItem1.Text = "Tarif"
        '
        'PemakaianToolStripMenuItem1
        '
        Me.PemakaianToolStripMenuItem1.Name = "PemakaianToolStripMenuItem1"
        Me.PemakaianToolStripMenuItem1.Size = New System.Drawing.Size(152, 22)
        Me.PemakaianToolStripMenuItem1.Text = "Pemakaian"
        '
        'TagihanToolStripMenuItem1
        '
        Me.TagihanToolStripMenuItem1.Name = "TagihanToolStripMenuItem1"
        Me.TagihanToolStripMenuItem1.Size = New System.Drawing.Size(152, 22)
        Me.TagihanToolStripMenuItem1.Text = "Tagihan"
        '
        'PemakaianToolStripMenuItem2
        '
        Me.PemakaianToolStripMenuItem2.Name = "PemakaianToolStripMenuItem2"
        Me.PemakaianToolStripMenuItem2.Size = New System.Drawing.Size(152, 22)
        Me.PemakaianToolStripMenuItem2.Text = "Pembayaran"
        '
        'DataUserToolStripMenuItem
        '
        Me.DataUserToolStripMenuItem.Name = "DataUserToolStripMenuItem"
        Me.DataUserToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.DataUserToolStripMenuItem.Text = "Data User"
        '
        'ToolStripDropDownButton1
        '
        Me.ToolStripDropDownButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripDropDownButton1.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.PenggunaToolStripMenuItem, Me.TarifToolStripMenuItem, Me.PemakaianToolStripMenuItem, Me.TagihanToolStripMenuItem, Me.PembayaranToolStripMenuItem})
        Me.ToolStripDropDownButton1.Image = CType(resources.GetObject("ToolStripDropDownButton1.Image"), System.Drawing.Image)
        Me.ToolStripDropDownButton1.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripDropDownButton1.Name = "ToolStripDropDownButton1"
        Me.ToolStripDropDownButton1.Size = New System.Drawing.Size(29, 22)
        Me.ToolStripDropDownButton1.Text = "Menu"
        '
        'PenggunaToolStripMenuItem
        '
        Me.PenggunaToolStripMenuItem.Name = "PenggunaToolStripMenuItem"
        Me.PenggunaToolStripMenuItem.Size = New System.Drawing.Size(140, 22)
        Me.PenggunaToolStripMenuItem.Text = "Pengguna"
        '
        'TarifToolStripMenuItem
        '
        Me.TarifToolStripMenuItem.Name = "TarifToolStripMenuItem"
        Me.TarifToolStripMenuItem.Size = New System.Drawing.Size(140, 22)
        Me.TarifToolStripMenuItem.Text = "Tarif"
        '
        'PemakaianToolStripMenuItem
        '
        Me.PemakaianToolStripMenuItem.Name = "PemakaianToolStripMenuItem"
        Me.PemakaianToolStripMenuItem.Size = New System.Drawing.Size(140, 22)
        Me.PemakaianToolStripMenuItem.Text = "Pemakaian"
        '
        'TagihanToolStripMenuItem
        '
        Me.TagihanToolStripMenuItem.Name = "TagihanToolStripMenuItem"
        Me.TagihanToolStripMenuItem.Size = New System.Drawing.Size(140, 22)
        Me.TagihanToolStripMenuItem.Text = "Tagihan"
        '
        'PembayaranToolStripMenuItem
        '
        Me.PembayaranToolStripMenuItem.Name = "PembayaranToolStripMenuItem"
        Me.PembayaranToolStripMenuItem.Size = New System.Drawing.Size(140, 22)
        Me.PembayaranToolStripMenuItem.Text = "Pembayaran"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Cyan
        Me.Label1.Location = New System.Drawing.Point(36, 39)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(397, 25)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Aplikasi Pembayaran Listrik Pascabayar"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.PLN.My.Resources.Resources.Logo_PLN
        Me.PictureBox1.ImageLocation = ""
        Me.PictureBox1.Location = New System.Drawing.Point(12, 78)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(446, 400)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 2
        Me.PictureBox1.TabStop = False
        '
        'SymbolBox1
        '
        '
        '
        '
        Me.SymbolBox1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.SymbolBox1.Location = New System.Drawing.Point(12, 489)
        Me.SymbolBox1.Name = "SymbolBox1"
        Me.SymbolBox1.Size = New System.Drawing.Size(46, 32)
        Me.SymbolBox1.Symbol = ""
        Me.SymbolBox1.TabIndex = 3
        Me.SymbolBox1.Text = "SymbolBox1"
        '
        'SymbolBox2
        '
        '
        '
        '
        Me.SymbolBox2.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.SymbolBox2.Location = New System.Drawing.Point(64, 489)
        Me.SymbolBox2.Name = "SymbolBox2"
        Me.SymbolBox2.Size = New System.Drawing.Size(46, 32)
        Me.SymbolBox2.Symbol = ""
        Me.SymbolBox2.TabIndex = 4
        Me.SymbolBox2.Text = "SymbolBox2"
        '
        'SymbolBox3
        '
        '
        '
        '
        Me.SymbolBox3.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.SymbolBox3.Location = New System.Drawing.Point(116, 489)
        Me.SymbolBox3.Name = "SymbolBox3"
        Me.SymbolBox3.Size = New System.Drawing.Size(46, 32)
        Me.SymbolBox3.Symbol = ""
        Me.SymbolBox3.TabIndex = 5
        Me.SymbolBox3.Text = "SymbolBox3"
        '
        'Home
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(470, 547)
        Me.Controls.Add(Me.SymbolBox3)
        Me.Controls.Add(Me.SymbolBox2)
        Me.Controls.Add(Me.SymbolBox1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Home"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Home"
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ToolStrip1 As ToolStrip
    Friend WithEvents ToolStripDropDownButton1 As ToolStripDropDownButton
    Friend WithEvents PenggunaToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents TarifToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PemakaianToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents TagihanToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PembayaranToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Label1 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents ToolStripDropDownButton2 As ToolStripDropDownButton
    Friend WithEvents PenggunaToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents TarifToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents PemakaianToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents TagihanToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents PemakaianToolStripMenuItem2 As ToolStripMenuItem
    Friend WithEvents ToolStripButton1 As ToolStripButton
    Friend WithEvents SymbolBox1 As DevComponents.DotNetBar.Controls.SymbolBox
    Friend WithEvents SymbolBox2 As DevComponents.DotNetBar.Controls.SymbolBox
    Friend WithEvents SymbolBox3 As DevComponents.DotNetBar.Controls.SymbolBox
    Friend WithEvents DataUserToolStripMenuItem As ToolStripMenuItem
End Class
