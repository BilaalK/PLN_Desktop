Imports System.Data.Odbc

Public Class Pembayaran
    Private Sub Pembayaran_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Connect()
        tampil()
        tanggal()
        kodeotomatis()
        buka()



    End Sub

    Sub tanggal()

        tgl.Text = DateTime.Now


    End Sub

    Sub kodeotomatis()
        Dim strsementara As String = ""
        Dim strisi As String = ""

        command = New OdbcCommand("select * from pembayaran order by id_bayar desc", connection)
        read = command.ExecuteReader()
        If read.Read Then
            strsementara =
    read.Item(0)
            strisi = Val(strsementara) + 1
            idbayar.Text = strisi
        Else
            idbayar.Text = "1"
        End If
    End Sub

    Sub buka() ' Memanggil koneksi di module


        command = New OdbcCommand("select * from pembayaran order by id_bayar desc", connection)
        read = command.ExecuteReader
        read.Read()
        If Not read.HasRows Then
            kdbayar.Text = "BY" + "0001"
        Else
            kdbayar.Text = Val(Microsoft.VisualBasic.Mid(read.Item("kd_bayar").ToString, 4, 3)) + 1
            If Len(kdbayar.Text) = 1 Then
                kdbayar.Text = "BY000" & kdbayar.Text & ""
            ElseIf Len(kdbayar.Text) = 2 Then
                kdbayar.Text = "BY00" & kdbayar.Text & ""
            ElseIf Len(kdbayar.Text) = 3 Then
                kdbayar.Text = "BY0" & kdbayar.Text & ""
            End If
        End If

    End Sub

    Sub tampil()
        dataadapter = New OdbcDataAdapter("select * from pembayaran", connection)
        dataset = New DataSet
        dataset.Clear()
        dataadapter.Fill(dataset, "pembayaran")
        DGV.DataSource = (dataset.Tables("pembayaran"))
        DGV.ReadOnly = True
        DGV.Columns(0).Width = 150
        DGV.Columns(1).Width = 150
        DGV.Columns(2).Width = 150
        DGV.Columns(3).Width = 150
        DGV.Columns(4).Width = 150
        DGV.Columns(5).Width = 150
        DGV.Columns(6).Width = 150
        DGV.Columns(7).Width = 150



    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        CariTagihan.ShowDialog()
    End Sub

    Private Sub denda_TextChanged(sender As Object, e As EventArgs) Handles denda.TextChanged
    End Sub

    Private Sub TextBox3_TextChanged(sender As Object, e As EventArgs) Handles TextBox3.TextChanged
        denda.Text = Val(TextBox3.Text) * 5 / 100
        tagih.Text = Val(denda.Text) + Val(biaya_admin.Text) + Val(TextBox3.Text)


    End Sub

    Private Sub TambahToolStripMenuItem_Click(sender As Object, e As EventArgs)

        Try

            If MessageBox.Show(" Tambah Data?", "", MessageBoxButtons.YesNo) = MsgBoxResult.Yes Then

                Dim sqltambah As String = "insert into pembayaran values('" & idbayar.Text & "','" & kdbayar.Text & "', '" & tgl.Text & "', '" & kdtagih.Text & "','" & tagih.Text & "','" & denda.Text & "','" & biaya_admin.Text & "','" & status.Text & "')"
                command = New OdbcCommand(sqltambah, connection)
                command.ExecuteNonQuery()

                Call tampil()
                Call Reset()
                Call kodeotomatis()
                Call buka()

            End If

        Catch ex As Exception

            MessageBox.Show("Pilih aksi yang sesuai", "", MessageBoxButtons.OK)
            Reset()


        End Try

    End Sub

    Private Sub ResetToolStripMenuItem_Click(sender As Object, e As EventArgs)
        Reset()

    End Sub

    Sub Reset()
        idbayar.Text = ""
        kdbayar.Text = ""
        tgl.Text = ""
        kdtagih.Text = ""
        tagih.Text = ""
        denda.Text = ""
        biaya_admin.Text = "2500"
        status.Text = ""



        Call kodeotomatis()
        Call buka()
        Call tanggal()

    End Sub

    Private Sub HapusToolStripMenuItem_Click(sender As Object, e As EventArgs)
        If MessageBox.Show(" Delete Data?", "", MessageBoxButtons.YesNo) = MsgBoxResult.Yes Then
            command = New OdbcCommand("Delete From pembayaran where id_bayar='" & idbayar.Text & "'", connection)
            command.ExecuteNonQuery()
            Call tampil()
            Call Reset()
            Call kodeotomatis()
            Call buka()
        End If
    End Sub

    Private Sub EditToolStripMenuItem_Click(sender As Object, e As EventArgs)
        If MessageBox.Show(" Edit Data?", "", MessageBoxButtons.YesNo) = MsgBoxResult.Yes Then
            Dim sqledit As String = "update pembayaran set kd_bayar = '" & kdbayar.Text & "' , tgl_bayar = '" & tgl.Text & "', kdTagih = '" & kdtagih.Text & "' , jumlah_tagihan = '" & tagih.Text & "', biaya_denda = '" & denda.Text & "' , biaya_admin = '" & biaya_admin.Text & "', status = '" & status.Text & "' where id_bayar = '" & idbayar.Text & "' "
            command = New OdbcCommand(sqledit, connection)
            command.ExecuteNonQuery()
            Call tampil()
            Call Reset()
            Call kodeotomatis()
            Call buka()
        End If
    End Sub


    Private Sub DGV_CellMouseClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles DGV.CellMouseClick
        idbayar.Text = DGV.CurrentRow.Cells(0).Value
        kdbayar.Text = DGV.CurrentRow.Cells(1).Value
        tgl.Text = DGV.CurrentRow.Cells(2).Value
        kdtagih.Text = DGV.CurrentRow.Cells(3).Value
        tagih.Text = DGV.CurrentRow.Cells(4).Value
        denda.Text = DGV.CurrentRow.Cells(5).Value
        biaya_admin.Text = DGV.CurrentRow.Cells(6).Value
        status.Text = DGV.CurrentRow.Cells(7).Value
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        If kdtagih.Text = "" Or status.Text = "" Then
            MessageBox.Show("Data Belum Lengkap")
            Exit Sub
        Else
            command = New OdbcCommand("Select * from pembayaran where kd_bayar='" & kdbayar.Text & "'", connection)
            read = command.ExecuteReader
            read.Read()

            If Not read.HasRows Then


                Dim sqltambah As String = "insert into pembayaran values('" & idbayar.Text & "','" & kdbayar.Text & "', '" & tgl.Text & "', '" & kdtagih.Text & "','" & tagih.Text & "','" & denda.Text & "','" & biaya_admin.Text & "','" & status.Text & "')"
                command = New OdbcCommand(sqltambah, connection)
                command.ExecuteNonQuery()

                Call tampil()
                Call Reset()
                Call kodeotomatis()
                Call buka()
            End If
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If MessageBox.Show(" Edit Data?", "", MessageBoxButtons.YesNo) = MsgBoxResult.Yes Then
            Dim sqledit As String = "update pembayaran set kd_bayar = '" & kdbayar.Text & "' , tgl_bayar = '" & tgl.Text & "', kdTagih = '" & kdtagih.Text & "' , jumlah_tagihan = '" & tagih.Text & "', biaya_denda = '" & denda.Text & "' , biaya_admin = '" & biaya_admin.Text & "', status = '" & status.Text & "' where id_bayar = '" & idbayar.Text & "' "
            command = New OdbcCommand(sqledit, connection)
            command.ExecuteNonQuery()
            Call tampil()
            Call Reset()
            Call kodeotomatis()
            Call buka()
        End If
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Reset()
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        If MessageBox.Show(" Delete Data?", "", MessageBoxButtons.YesNo) = MsgBoxResult.Yes Then
            command = New OdbcCommand("Delete From pembayaran where id_bayar='" & idbayar.Text & "'", connection)
            command.ExecuteNonQuery()
            Call tampil()
            Call Reset()
            Call kodeotomatis()
            Call buka()
        End If
    End Sub

    Private Sub TarifToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles TarifToolStripMenuItem.Click
        Tarif.Show()
        Reset()
        Me.Hide()
    End Sub

    Private Sub PelangganToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PelangganToolStripMenuItem.Click
        Form1.Show()
        Reset()
        Me.Hide()

    End Sub

    Private Sub LogoutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LogoutToolStripMenuItem.Click
        If MessageBox.Show("Yakin Ingin Log Out?", "",
                               MessageBoxButtons.YesNo) = MsgBoxResult.Yes Then
            Login.Show()
            Me.Hide()
        End If
    End Sub

    Private Sub TagihanToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles TagihanToolStripMenuItem.Click
        Tagihan.Show()
        Me.Hide()
    End Sub

    Private Sub PemakaianToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PemakaianToolStripMenuItem.Click
        pemakaian.Show()
        Me.Hide()
    End Sub

    Private Sub DGV_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DGV.CellContentClick

    End Sub

    Private Sub tagih_TextChanged(sender As Object, e As EventArgs) Handles tagih.TextChanged

    End Sub

    Private Sub kdtagih_TextChanged(sender As Object, e As EventArgs) Handles kdtagih.TextChanged

    End Sub

    Private Sub SymbolBox1_Click(sender As Object, e As EventArgs) Handles SymbolBox1.Click
        If MessageBox.Show("Yakin Ingin Kembali ke Home?", "",
                               MessageBoxButtons.YesNo) = MsgBoxResult.Yes Then
            Home.Show()
            Me.Hide()
        End If
    End Sub

    Private Sub DataUserToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DataUserToolStripMenuItem.Click
        DataUser.Show()
        Me.Hide()
    End Sub
End Class
