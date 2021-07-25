Public Class Home
    Private Sub ToolStripComboBox1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub PenggunaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PenggunaToolStripMenuItem.Click
        Form1.Show()
        Me.Hide()
    End Sub

    Private Sub TarifToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles TarifToolStripMenuItem.Click
        Tarif.Show()
        Me.Hide()
    End Sub

    Private Sub PemakaianToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PemakaianToolStripMenuItem.Click
        pemakaian.Show()
        Me.Hide()
    End Sub

    Private Sub TagihanToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles TagihanToolStripMenuItem.Click
        Tagihan.Show()
        Me.Hide()
    End Sub

    Private Sub PembayaranToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PembayaranToolStripMenuItem.Click
        Pembayaran.Show()
        Me.Hide()
    End Sub

    Private Sub LabelX1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub ToolStripDropDownButton1_Click(sender As Object, e As EventArgs) Handles ToolStripDropDownButton1.Click

    End Sub

    Private Sub ToolStripButton1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub ToolStripButton1_Click_1(sender As Object, e As EventArgs)

    End Sub

    Private Sub ToolStrip1_ItemClicked(sender As Object, e As ToolStripItemClickedEventArgs) Handles ToolStrip1.ItemClicked

    End Sub

    Private Sub Home_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub PenggunaToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles PenggunaToolStripMenuItem1.Click
        Form1.Show()
        Me.Hide()
    End Sub

    Private Sub TarifToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles TarifToolStripMenuItem1.Click
        Tarif.Show()
        Me.Hide()
    End Sub

    Private Sub PemakaianToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles PemakaianToolStripMenuItem1.Click
        pemakaian.Show()
        Me.Hide()
    End Sub

    Private Sub TagihanToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles TagihanToolStripMenuItem1.Click
        Tagihan.Show()
        Me.Hide()
    End Sub

    Private Sub PemakaianToolStripMenuItem2_Click(sender As Object, e As EventArgs) Handles PemakaianToolStripMenuItem2.Click
        Pembayaran.Show()
        Me.Hide()
    End Sub

    Private Sub ToolStripDropDownButton2_Click(sender As Object, e As EventArgs) Handles ToolStripDropDownButton2.Click

    End Sub

    Private Sub DataUserToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DataUserToolStripMenuItem.Click
        DataUser.Button2.Visible = True
        DataUser.Button4.Visible = True
        DataUser.RadioButton1.Visible = True
        DataUser.RadioButton2.Visible = True
        DataUser.RadioButton4.Visible = True
        DataUser.HomeToolStripMenuItem.Visible = True
        DataUser.LogoutToolStripMenuItem.Text = "Log Out"
        DataUser.Show()
        Me.Hide()
    End Sub

    Private Sub ToolStripButton1_Click_2(sender As Object, e As EventArgs) Handles ToolStripButton1.Click
        If MessageBox.Show("Yakin Ingin Log Out?", "",
                               MessageBoxButtons.YesNo) = MsgBoxResult.Yes Then
            Login.Show()
            Me.Hide()
        End If
    End Sub
End Class