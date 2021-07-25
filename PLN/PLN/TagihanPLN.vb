Imports System.Data.Odbc


Public Class TagihanPLN

    Sub tampil()
        dataadapter = New OdbcDataAdapter("select * from tagihan", connection)
        dataset = New DataSet
        dataset.Clear()
        dataadapter.Fill(dataset, "tagihan")
        DGV.DataSource = (dataset.Tables("tagihan"))
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

    Private Sub TagihanPLN_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Connect()
        tampil()
        tanggal()
        buka()
        nomorotomatis()





    End Sub

    Sub tanggal()

        thtagih.Text = Date.Today.Year
        bltagih.Text = Date.Today.Month

    End Sub

    Sub nomorotomatis()
        Dim strsementara As String = ""
        Dim strisi As String = ""

        command = New OdbcCommand("select * from tagihan order by id_tagihan desc", connection)
        read = command.ExecuteReader()
        If read.Read Then
            strsementara =
    read.Item(0)
            strisi = Val(strsementara) + 1
            idtagih.Text = strisi
        Else
            idtagih.Text = "1"
        End If
    End Sub

    Sub buka() '  koneksi di module


        command = New OdbcCommand("select * from tagihan order by id_tagihan desc", connection)
        read = command.ExecuteReader
        read.Read()
        If Not read.HasRows Then
            kdtagih.Text = "TG" + "0001"
        Else
            kdtagih.Text = Val(Microsoft.VisualBasic.Mid(read.Item("kdTagih").ToString, 4, 3)) + 1
            If Len(kdtagih.Text) = 1 Then
                kdtagih.Text = "TG000" & kdtagih.Text & ""
            ElseIf Len(kdtagih.Text) = 2 Then
                kdtagih.Text = "TG00" & kdtagih.Text & ""
            ElseIf Len(kdtagih.Text) = 3 Then
                kdtagih.Text = "TG0" & kdtagih.Text & ""
            End If
        End If

    End Sub





    Sub Reset()
        idtagih.Text = ""
        kdtagih.Text = ""
        thtagih.Text = ""
        bltagih.Text = ""
        kdtarif.Text = ""
        pemakaian.Text = ""
        status.Text = ""
        TextBox10.Text = ""


        Call nomorotomatis()
        Call buka()
        Call tanggal()

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        CariTarif.ShowDialog()
        kdtarif.Text = kodeTarif
        pemakaian.Text = pemakaianTarif


    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        CariPelanggan.ShowDialog()
        TextBox10.Text = kdPelanggan


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

    Private Sub TambahToolStripMenuItem_Click(sender As Object, e As EventArgs)
        Try

            If MessageBox.Show(" Tambah Data?", "", MessageBoxButtons.YesNo) = MsgBoxResult.Yes Then

                Dim sqltambah As String = "insert into tagihan values('" & idtagih.Text & "','" & kdtagih.Text & "', '" & thtagih.Text & "', '" & bltagih.Text & "', '" & kdtarif.Text & "', '" & pemakaian.Text & "','" & status.Text & "','" & TextBox10.Text & "')"
                command = New OdbcCommand(sqltambah, connection)
                command.ExecuteNonQuery()
                Call tampil()
                Call Reset()
                Call nomorotomatis()
                Call buka()
                Call tanggal()


            End If

        Catch ex As Exception

            MessageBox.Show("Pilih aksi yang sesuai", "", MessageBoxButtons.OK)
            Reset()


        End Try
    End Sub



    Private Sub DGV_CellMouseClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles DGV.CellMouseClick
        idtagih.Text = DGV.CurrentRow.Cells(0).Value
        kdtagih.Text = DGV.CurrentRow.Cells(1).Value
        thtagih.Text = DGV.CurrentRow.Cells(2).Value
        bltagih.Text = DGV.CurrentRow.Cells(3).Value
        kdtarif.Text = DGV.CurrentRow.Cells(4).Value
        pemakaian.Text = DGV.CurrentRow.Cells(5).Value
        status.Text = DGV.CurrentRow.Cells(6).Value
        TextBox10.Text = DGV.CurrentRow.Cells(7).Value
    End Sub

    Private Sub EditToolStripMenuItem_Click(sender As Object, e As EventArgs)
        If MessageBox.Show(" Edit Data?", "", MessageBoxButtons.YesNo) = MsgBoxResult.Yes Then
            Dim sqledit As String = "update tagihan set kdtagih = '" & kdtagih.Text & "' , thtagih = '" & thtagih.Text & "', blntagih = '" & bltagih.Text & "' , kdTarif = '" & kdtarif.Text & "', pemakaian = '" & pemakaian.Text & "' , status = '" & status.Text & "', status = '" & status.Text & "' where id_tagihan = '" & idtagih.Text & "' "
            command = New OdbcCommand(sqledit, connection)
            command.ExecuteNonQuery()
            Call tampil()
            Call Reset()
            Call nomorotomatis()
            Call buka()
        End If
    End Sub

    Private Sub HapusToolStripMenuItem_Click(sender As Object, e As EventArgs)
        If MessageBox.Show(" Delete Data?", "", MessageBoxButtons.YesNo) = MsgBoxResult.Yes Then
            command = New OdbcCommand("Delete From tagihan where id_tagihan='" & idtagih.Text & "'", connection)
            command.ExecuteNonQuery()
            Call tampil()
            Call Reset()
            Call nomorotomatis()
            Call buka()
        End If
    End Sub

    Private Sub ResetToolStripMenuItem_Click(sender As Object, e As EventArgs)
        Reset()

    End Sub

    Private Sub TextBox10_TextChanged(sender As Object, e As EventArgs) Handles TextBox10.TextChanged

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Try

            If MessageBox.Show(" Tambah Data?", "", MessageBoxButtons.YesNo) = MsgBoxResult.Yes Then

                Dim sqltambah As String = "insert into tagihan values('" & idtagih.Text & "','" & kdtagih.Text & "', '" & thtagih.Text & "', '" & bltagih.Text & "', '" & kdtarif.Text & "', '" & pemakaian.Text & "','" & status.Text & "','" & TextBox10.Text & "')"
                command = New OdbcCommand(sqltambah, connection)
                command.ExecuteNonQuery()
                Call tampil()
                Call Reset()
                Call nomorotomatis()
                Call buka()
                Call tanggal()


            End If

        Catch ex As Exception

            MessageBox.Show("Pilih aksi yang sesuai", "", MessageBoxButtons.OK)
            Reset()


        End Try
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        If MessageBox.Show(" Edit Data?", "", MessageBoxButtons.YesNo) = MsgBoxResult.Yes Then
            Dim sqledit As String = "update tagihan set kdtagih = '" & kdtagih.Text & "' , thtagih = '" & thtagih.Text & "', blntagih = '" & bltagih.Text & "' , kdTarif = '" & kdtarif.Text & "', pemakaian = '" & pemakaian.Text & "' , status = '" & status.Text & "', status = '" & status.Text & "' where id_tagihan = '" & idtagih.Text & "' "
            command = New OdbcCommand(sqledit, connection)
            command.ExecuteNonQuery()
            Call tampil()
            Call Reset()
            Call nomorotomatis()
            Call buka()
        End If
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Reset()
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        If MessageBox.Show(" Delete Data?", "", MessageBoxButtons.YesNo) = MsgBoxResult.Yes Then
            command = New OdbcCommand("Delete From tagihan where id_tagihan='" & idtagih.Text & "'", connection)
            command.ExecuteNonQuery()
            Call tampil()
            Call Reset()
            Call nomorotomatis()
            Call buka()
        End If
    End Sub

    Private Sub PembayaranToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PembayaranToolStripMenuItem.Click
        Pembayaran.Show()
        Reset()
        Me.Hide()
    End Sub
End Class