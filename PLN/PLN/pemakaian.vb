Imports System.Data.Odbc

Public Class pemakaian
    Sub nomorotomatis()
        Dim strsementara As String = ""
        Dim strisi As String = ""

        command = New OdbcCommand("select * from pemakaian order by id_pemakai desc", connection)
        read = command.ExecuteReader()
        If read.Read Then
            strsementara =
    read.Item(0)
            strisi = Val(strsementara) + 1
            idpemakai.Text = strisi
        Else
            idpemakai.Text = "1"
        End If

    End Sub

    Private Sub Label4_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        CariPelanggan.Show()
        kdpelanggan.Text = kodePelanggan

    End Sub

    Private Sub TextBox6_TextChanged(sender As Object, e As EventArgs) Handles meteranawal.TextChanged

    End Sub

    Private Sub TextBox5_TextChanged(sender As Object, e As EventArgs) Handles meteranakhir.TextChanged
        Try
            pemakai.Text = meteranakhir.Text - meteranawal.Text

        Catch ex As Exception

        End Try
    End Sub

    Private Sub TextBox4_TextChanged(sender As Object, e As EventArgs) Handles pemakai.TextChanged

    End Sub

    Private Sub TextBox3_TextChanged(sender As Object, e As EventArgs) Handles kdpelanggan.TextChanged

    End Sub

    Private Sub hari_TextChanged(sender As Object, e As EventArgs) Handles kdpemakai.TextChanged

    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles idpemakai.TextChanged

    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DGV.CellContentClick


    End Sub

    Sub tampil()

        dataadapter = New Odbc.OdbcDataAdapter("select * from pemakaian", connection)
        dataset = New DataSet
        dataset.Clear()
        dataadapter.Fill(dataset, "pemakaian")
        DGV.DataSource = (dataset.Tables("pemakaian"))
        DGV.ReadOnly = True
        DGV.Columns(0).Width = 150
        DGV.Columns(1).Width = 150
        DGV.Columns(2).Width = 150
        DGV.Columns(3).Width = 150
        DGV.Columns(4).Width = 175
        DGV.Columns(5).Width = 175


    End Sub

    Sub buka() ' Memanggil koneksi di module

        command = New Odbc.OdbcCommand("select * from pemakaian order by id_pemakai desc", connection)
        read = command.ExecuteReader
        read.Read()
        If Not read.HasRows Then
            kdpemakai.Text = "PK" + "0001"
        Else
            kdpemakai.Text = Val(Microsoft.VisualBasic.Mid(read.Item("kd_pemakai").ToString, 4, 3)) + 1
            If Len(kdpemakai.Text) = 1 Then
                kdpemakai.Text = "PK000" & kdpemakai.Text & ""
            ElseIf Len(kdpemakai.Text) = 2 Then
                kdpemakai.Text = "PK00" & kdpemakai.Text & ""
            ElseIf Len(kdpemakai.Text) = 3 Then
                kdpemakai.Text = "PK0" & kdpemakai.Text & ""

            End If
        End If
    End Sub

    Sub kodeotomatis()
        Dim strsementara As String = ""
        Dim strisi As String = ""

        command = New Odbc.OdbcCommand("select * from pemakaian order by id_pemakai desc", connection)
        read = command.ExecuteReader()
        If read.Read Then
            strsementara = read.Item(0)
            strisi = Val(strsementara) + 1
            idpemakai.Text = strisi
        Else
            idpemakai.Text = "1"
        End If
    End Sub



    Private Sub pemakaian_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Connect()
        buka()
        kodeotomatis()
        tampil()

    End Sub



    Private Sub PembayaranToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PembayaranToolStripMenuItem.Click
        Pembayaran.Show()
        Me.Hide()

    End Sub

    Private Sub PelangganToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PelangganToolStripMenuItem.Click

    End Sub

    Private Sub TarifToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles TarifToolStripMenuItem.Click
        Tagihan.Show()
        Me.Hide()

    End Sub

    Private Sub add_Click(sender As Object, e As EventArgs) Handles add.Click
        Try
            If MessageBox.Show("Tambah Data?", "", MessageBoxButtons.YesNo) = MsgBoxResult.Yes Then

                Dim sqltambah As String = "insert into pemakaian values('" & idpemakai.Text & "','" & kdpemakai.Text & "','" & kdpelanggan.Text & "','" & meteranawal.Text & "','" & meteranakhir.Text & "','" & pemakai.Text & "')"
                command = New Odbc.OdbcCommand(sqltambah, connection)
                command.ExecuteNonQuery()
                Call Reset()
                Call tampil()
                Call kodeotomatis()
                Call buka()

            End If

        Catch ex As Exception

            MessageBox.Show("pilih aksi yang sesuai", "", MessageBoxButtons.OK)
            Reset()


        End Try
    End Sub

    Sub reset()
        kdpelanggan.Text = ""
        meteranawal.Text = ""
        meteranakhir.Text = ""
        pemakai.Text = ""

        Call nomorotomatis()
        Call buka()


    End Sub

    Private Sub Refresh_Click(sender As Object, e As EventArgs) Handles Refresh.Click
        Reset()
    End Sub

    Private Sub Edit_Click(sender As Object, e As EventArgs) Handles Edit.Click
        Dim sqledit As String = "update pemakaian set kd_pemakai ='" & kdpemakai.Text & "', kdpelanggan = '" & kdpelanggan.Text & "' , meter_awal = '" & meteranawal.Text & "', meter_akhir = '" & meteranakhir.Text & "', pemakaian = '" & pemakai.Text & "' where id_Pemakai = '" & idpemakai.Text & "' "
        command = New OdbcCommand(sqledit, connection)
        command.ExecuteNonQuery()
        Call tampil()
        Call Reset()
        Call kodeotomatis()
        Call buka()
    End Sub

    Private Sub DGV_CellMouseClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles DGV.CellMouseClick
        idpemakai.Text = DGV.CurrentRow.Cells(0).Value
        kdpemakai.Text = DGV.CurrentRow.Cells(1).Value
        kdpelanggan.Text = DGV.CurrentRow.Cells(2).Value
        meteranawal.Text = DGV.CurrentRow.Cells(3).Value
        meteranakhir.Text = DGV.CurrentRow.Cells(4).Value
        pemakai.Text = DGV.CurrentRow.Cells(5).Value
    End Sub

    Private Sub Delete_Click(sender As Object, e As EventArgs) Handles Delete.Click
        If MessageBox.Show(" Delete Data?", "", MessageBoxButtons.YesNo) = MsgBoxResult.Yes Then
            command = New OdbcCommand("Delete From pemakaian where id_pemakai='" & idpemakai.Text & "'", connection)
            command.ExecuteNonQuery()
            Call tampil()
            Call Reset()

        End If
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

    Private Sub TagihanToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles TagihanToolStripMenuItem.Click
        Tagihan.Show()
        Me.Hide()
    End Sub
End Class