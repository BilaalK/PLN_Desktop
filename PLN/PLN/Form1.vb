Imports System.Data.Odbc

Public Class Form1


    Sub tampil()
        dataadapter = New OdbcDataAdapter("select * from pelanggan", connection)
        dataset = New DataSet
        dataset.Clear()
        dataadapter.Fill(dataset, "pelanggan")
        DGV.DataSource = (dataset.Tables("pelanggan"))
        DGV.ReadOnly = True
        DGV.Columns(0).Width = 200
        DGV.Columns(1).Width = 200
        DGV.Columns(2).Width = 200
        DGV.Columns(3).Width = 200
    End Sub

    Sub kodeotomatis()
        Dim strsementara As String = ""
        Dim strisi As String = ""

        command = New OdbcCommand("select * from pelanggan order by idPelanggan desc", connection)
        read = command.ExecuteReader()
        If read.Read Then
            strsementara = read.Item(0)
            strisi = Val(strsementara) + 1
            TextBox1.Text = strisi
        Else
            TextBox1.Text = 1
        End If
    End Sub


    Private Sub TarifToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles TarifToolStripMenuItem.Click
        Tarif.Show()
        Me.Hide()
        reset()


    End Sub

    Private Sub MenuStrip1_ItemClicked(sender As Object, e As ToolStripItemClickedEventArgs) Handles MenuStrip1.ItemClicked

    End Sub

    Private Sub Pelanggan_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call Connect()
        Call tampil()
        Call kodeotomatis()
        Call buka()



    End Sub


    Private Sub DGV_CellMouseClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles DGV.CellMouseClick
        TextBox1.Text = DGV.CurrentRow.Cells(0).Value
        TextBox2.Text = DGV.CurrentRow.Cells(1).Value
        TextBox8.Text = DGV.CurrentRow.Cells(2).Value
        TextBox3.Text = DGV.CurrentRow.Cells(3).Value
        TextBox7.Text = DGV.CurrentRow.Cells(4).Value

    End Sub

    Sub buka()


        command = New OdbcCommand("select * from pelanggan order by idPelanggan desc", connection)
        read = command.ExecuteReader
        read.Read()
        If Not read.HasRows Then
            TextBox2.Text = "PL" + "0001"
        Else
            TextBox2.Text = Val(Microsoft.VisualBasic.Mid(read.Item("kdPelanggan").ToString, 4, 3)) + 1
            If Len(TextBox2.Text) = 1 Then
                TextBox2.Text = "PL000" & TextBox2.Text & ""
            ElseIf Len(TextBox2.Text) = 2 Then
                TextBox2.Text = "PL00" & TextBox2.Text & ""
            ElseIf Len(TextBox2.Text) = 3 Then
                TextBox2.Text = "PL0" & TextBox2.Text & ""
            End If
        End If

    End Sub

    'Sub tampiltarif()
    '   command = New OdbcCommand(" Select * From tarif ", connection)
    '  read = command.ExecuteReader
    ' TextBox7.Items.Clear()
    'Do While read.Read
    '       TextBox7.Items.Add(read.Item(1))
    'Loop
    'End Sub

    Private Sub ResetToolStripMenuItem_Click(sender As Object, e As EventArgs)

        reset()

    End Sub

    Sub reset()

        TextBox1.Text = ""
        TextBox2.Text = ""
        TextBox3.Text = ""
        TextBox4.Text = ""
        TextBox5.Text = ""
        TextBox6.Text = ""
        TextBox8.Text = ""
        TextBox7.Text = ""

        Call kodeotomatis()
        Call buka()


    End Sub

    Private Sub TambahToolStripMenuItem_Click(sender As Object, e As EventArgs)
        Try

            Dim sqltambah As String = "insert into pelanggan values('" & TextBox1.Text & "','" & TextBox2.Text & "', '" & TextBox8.Text & "', '" & TextBox3.Text & "','" & TextBox7.Text & "')"
            command = New OdbcCommand(sqltambah, connection)
            command.ExecuteNonQuery()
            Call tampil()
            Call reset()
            Call kodeotomatis()
            Call buka()


        Catch ex As Exception

            MessageBox.Show("Pilih aksi yang sesuai", "", MessageBoxButtons.OK)
            reset()


        End Try


    End Sub

    Private Sub EditToolStripMenuItem_Click(sender As Object, e As EventArgs)
        Dim sqledit As String = "update pelanggan set kdPelanggan ='" & TextBox2.Text & "', nama = '" & TextBox8.Text & "', alamat = '" & TextBox3.Text & "' , kdtarif = '" & TextBox7.Text & "' where idPelanggan = '" & TextBox1.Text & "' "
        command = New OdbcCommand(sqledit, connection)
        command.ExecuteNonQuery()
        Call tampil()
        Call reset()
        Call kodeotomatis()
        Call buka()


    End Sub

    Private Sub HapusToolStripMenuItem_Click(sender As Object, e As EventArgs)
        If MessageBox.Show(" Delete Data?", "", MessageBoxButtons.YesNo) = MsgBoxResult.Yes Then
            command = New OdbcCommand("Delete From pelanggan where idPelanggan='" & TextBox1.Text & "'", connection)
            command.ExecuteNonQuery()
            Call tampil()
            Call reset()

        End If

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Try

            If TextBox1.Text = "" Or TextBox2.Text = "" Or TextBox3.Text = "" Then
                MessageBox.Show("Data Belum Lengkap")
                TextBox2.Focus()
                Exit Sub
            Else
                command = New OdbcCommand("Select * from tarif where kdTarif='" & TextBox2.Text & "'", connection)
                read = command.ExecuteReader
                read.Read()

                If Not read.HasRows Then


                    Dim sqltambah As String = "insert into pelanggan values('" & TextBox1.Text & "','" & TextBox2.Text & "', '" & TextBox8.Text & "', '" & TextBox3.Text & "','" & TextBox7.Text & "')"
                    command = New OdbcCommand(sqltambah, connection)
                    command.ExecuteNonQuery()
                    Call tampil()
                    Call reset()
                    Call kodeotomatis()
                    Call buka()

                End If
            End If


        Catch ex As Exception

            MessageBox.Show("Pilih aksi yang sesuai", "", MessageBoxButtons.OK)
            reset()


        End Try

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim sqledit As String = "update pelanggan set kdPelanggan ='" & TextBox2.Text & "', nama = '" & TextBox8.Text & "', alamat = '" & TextBox3.Text & "' , kdtarif = '" & TextBox7.Text & "' where idPelanggan = '" & TextBox1.Text & "' "
        command = New OdbcCommand(sqledit, connection)
        command.ExecuteNonQuery()
        Call tampil()
        Call reset()
        Call kodeotomatis()
        Call buka()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        If MessageBox.Show(" Delete Data?", "", MessageBoxButtons.YesNo) = MsgBoxResult.Yes Then
            command = New OdbcCommand("Delete From pelanggan where idPelanggan='" & TextBox1.Text & "'", connection)
            command.ExecuteNonQuery()
            Call tampil()
            Call reset()
            kodeotomatis()

        End If
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        reset()
        kodeotomatis()
    End Sub

    Private Sub TagihanToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles TagihanToolStripMenuItem.Click
        Tagihan.Show()
        reset()
        Me.Hide()
    End Sub

    Private Sub PembayaranToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PembayaranToolStripMenuItem.Click
        Pembayaran.Show()
        reset()
        Me.Hide()
    End Sub

    Private Sub DGV_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DGV.CellContentClick

    End Sub

    Private Sub TextBox4_TextChanged(sender As Object, e As EventArgs) Handles TextBox4.TextChanged

    End Sub

    Private Sub GroupBox1_Enter(sender As Object, e As EventArgs) Handles GroupBox1.Enter

    End Sub

    Private Sub TextBox5_TextChanged(sender As Object, e As EventArgs) Handles TextBox5.TextChanged

    End Sub

    Private Sub PemakaianToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PemakaianToolStripMenuItem.Click
        pemakaian.Show()
        Me.Hide()
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        CariTarif.Show()
    End Sub

    Private Sub TextBox7_TextChanged(sender As Object, e As EventArgs) Handles TextBox7.TextChanged

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
