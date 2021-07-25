Imports System.Data.Odbc

Public Class CariTagihan
    Private Sub CariTagihan_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        koneksi.Connect()
        tampil("")
    End Sub

    Sub tampil(cari)
        dataadapter = New Odbc.OdbcDataAdapter("select * from tagihan where kdTagih like '%" & cari & "%'", connection)
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

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged
        tampil(TextBox1.Text)
    End Sub

    Private Sub DGV_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DGV.CellClick
        kodeTagihan = DGV.Rows(e.RowIndex).Cells(1).Value.ToString
        pemakaianTagihan = DGV.Rows(e.RowIndex).Cells(5).Value.ToString
        Pembayaran.kdtagih.Text = DGV.Rows(e.RowIndex).Cells(1).Value.ToString
        Pembayaran.TextBox3.Text = DGV.Rows(e.RowIndex).Cells(8).Value.ToString


        Me.Close()
    End Sub

    Private Sub DGV_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DGV.CellContentClick

    End Sub
End Class