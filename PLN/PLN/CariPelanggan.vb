Imports System.Data.Odbc

Public Class CariPelanggan
    Private Sub CariPelanggan_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        koneksi.Connect()
        tampil("")
    End Sub

    Sub tampil(cari)
        dataadapter = New Odbc.OdbcDataAdapter("select * from pelanggan where kdPelanggan like '%" & cari & "%'", connection)
        dataset = New DataSet
        dataset.Clear()
        dataadapter.Fill(dataset, "pelanggan")
        DGV.DataSource = (dataset.Tables("pelanggan"))
        DGV.ReadOnly = True
        DGV.Columns(0).Width = 150
        DGV.Columns(1).Width = 150
        DGV.Columns(2).Width = 150
        DGV.Columns(3).Width = 150

    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged
        tampil(TextBox1.Text)
    End Sub

    Private Sub DGV_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DGV.CellClick

        Tagihan.TextBox10.Text = DGV.Rows(e.RowIndex).Cells(1).Value.ToString
        pemakaian.kdpelanggan.Text = DGV.Rows(e.RowIndex).Cells(1).Value.ToString

        Me.Close()
    End Sub

    Private Sub DGV_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DGV.CellContentClick

    End Sub
End Class