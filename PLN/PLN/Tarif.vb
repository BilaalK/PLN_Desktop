Imports System.Data.Odbc

Public Class Tarif


    Sub tampil()
        dataadapter = New OdbcDataAdapter("select * from tarif", connection)
        dataset = New DataSet
        dataset.Clear()
        dataadapter.Fill(dataset, "tarif")
        DGV.DataSource = (dataset.Tables("tarif"))
        DGV.ReadOnly = True
        DGV.Columns(0).Width = 150
        DGV.Columns(1).Width = 150
        DGV.Columns(2).Width = 150



    End Sub

    Sub nomorotomatis()
        Dim strsementara As String = ""
        Dim strisi As String = ""

        command = New OdbcCommand("select * from tarif order by kdTarif desc", connection)
        read = command.ExecuteReader()
        If read.Read Then
            strsementara =
    read.Item(0)
            strisi = Val(strsementara) + 1
            TextBox1.Text = strisi
        Else
            TextBox1.Text = "1"
        End If
    End Sub



    Sub buka() ' Memang koneksi di module


        command = New OdbcCommand("select * from tarif order by kdtarif desc", connection)
        read = command.ExecuteReader
        read.Read()

    End Sub


    Private Sub PelangganToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PelangganToolStripMenuItem.Click
        Form1.Show()
        reset()
        Me.Hide()

    End Sub

    Private Sub Tarif_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call Connect()
        tampil()
        nomorotomatis()
        buka()




    End Sub
    Private Sub DGV_CellClick(sender As Object, e As DataGridViewCellMouseEventArgs)





    End Sub


    Private Sub TambahToolStripMenuItem_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub EditToolStripMenuItem_Click(sender As Object, e As EventArgs)
        Dim sqledit As String = "update pelanggan set kdTarif = '" & TextBox2.Text & "', daya = '" & TextBox3.Text & "'"
        command = New OdbcCommand(sqledit, connection)
        command.ExecuteNonQuery()
        Call tampil()
        Call reset()
        Call nomorotomatis()
        Call buka()


    End Sub

    Sub reset()
        TextBox1.Text = ""
        TextBox2.Text = ""
        TextBox3.Text = ""

        Call nomorotomatis()
        Call buka()


    End Sub

    Private Sub ResetToolStripMenuItem_Click(sender As Object, e As EventArgs)
        reset()

    End Sub

    Private Sub HapusToolStripMenuItem_Click(sender As Object, e As EventArgs)

    End Sub


    Private Sub TagihanToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles TagihanToolStripMenuItem.Click
        Tagihan.Show()
        reset()
        Me.Hide()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If TextBox1.Text = "" Or TextBox2.Text = "" Or TextBox3.Text = "" Then
            MessageBox.Show("Data Belum Lengkap")
            TextBox2.Focus()
            Exit Sub
        Else
            command = New OdbcCommand("Select * from tarif where kdTarif='" & TextBox1.Text & "'", connection)
            read = command.ExecuteReader
            read.Read()

            If Not read.HasRows Then


                Dim sqltambah As String = "insert into tarif values('" & TextBox1.Text & "','" & TextBox2.Text & "','" & TextBox3.Text & "')"
                command = New OdbcCommand(sqltambah, connection)
                command.ExecuteNonQuery()
                Call tampil()
                Call reset()
                Call nomorotomatis()
                Call buka()

            End If
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) 
        Dim sqledit As String = "update tarif set daya = '" & TextBox2.Text & "', tarif_perkwh = '" & TextBox3.Text & "'"
        command = New OdbcCommand(sqledit, connection)
        command.ExecuteNonQuery()
        Call tampil()
        Call reset()
        Call nomorotomatis()
        Call buka()


    End Sub


    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        reset()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        If MessageBox.Show(" Delete Data?", "", MessageBoxButtons.YesNo) = MsgBoxResult.Yes Then
            command = New OdbcCommand("Delete From tarif where kdTarif='" & TextBox1.Text & "'", connection)
            command.ExecuteNonQuery()
            Call tampil()
            Call reset()

        End If

    End Sub


    Private Sub DGV_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DGV.CellContentClick

    End Sub

    Private Sub MenuStrip1_ItemClicked(sender As Object, e As ToolStripItemClickedEventArgs) Handles MenuStrip1.ItemClicked

    End Sub

    Private Sub Tarif_Load_1(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub


    Private Sub beban_TextChanged(sender As Object, e As EventArgs)

    End Sub


    Private Sub PembayaranToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PembayaranToolStripMenuItem.Click
        Pembayaran.Show()
        reset()
        Me.Hide()
    End Sub


    Private Sub DGV_CellMouseClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles DGV.CellMouseClick
        TextBox1.Text = DGV.CurrentRow.Cells(0).Value
        TextBox2.Text = DGV.CurrentRow.Cells(1).Value
        TextBox3.Text = DGV.CurrentRow.Cells(2).Value

    End Sub

    Private Sub TextBox2_TextChanged(sender As Object, e As EventArgs) Handles TextBox2.TextChanged

    End Sub

    Private Sub PemakaianToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PemakaianToolStripMenuItem.Click
        pemakaian.Show()
        Me.Hide()
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click

        Dim sqledit As String = "update tarif set daya = '" & TextBox2.Text & "' , tarif_perkwh = '" & TextBox3.Text & "'where kdtarif = '" & TextBox1.Text & "' "
        command = New OdbcCommand(sqledit, connection)
        command.ExecuteNonQuery()
        Call tampil()
        Call reset()
        Call nomorotomatis()
        Call buka()

    End Sub

    Private Sub SymbolBox1_Click(sender As Object, e As EventArgs) Handles SymbolBox1.Click
        If MessageBox.Show("Yakin Ingin Kembali ke Home?", "",
                               MessageBoxButtons.YesNo) = MsgBoxResult.Yes Then
            Home.Show()
            Me.Hide()
        End If
    End Sub

    Private Sub LogoutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LogoutToolStripMenuItem.Click
        If MessageBox.Show("Yakin Ingin Log Out?", "",
                               MessageBoxButtons.YesNo) = MsgBoxResult.Yes Then
            Login.Show()
            Me.Hide()
        End If
    End Sub

    Private Sub DataUserToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DataUserToolStripMenuItem.Click
        DataUser.Show()
        Me.Hide()
    End Sub
End Class
