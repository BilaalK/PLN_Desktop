Imports System.Data.Odbc

Public Class CariTarif
    Private Sub CariTarif_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        koneksi.Connect()
        tampil("")



    End Sub

    Sub tampil(cari)
        dataadapter = New OdbcDataAdapter("select * from tarif where kdTarif like '%" & cari & "%'", connection)
        dataset = New DataSet
        dataset.Clear()
        dataadapter.Fill(dataset, "tarif")
        DGV.DataSource = (dataset.Tables("tarif"))
        DGV.ReadOnly = True
        DGV.Columns(0).Width = 150
        DGV.Columns(1).Width = 150
        DGV.Columns(2).Width = 150



    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged
        tampil(TextBox1.Text)
    End Sub

    Private Sub DGV_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DGV.CellClick
        Form1.TextBox4.Text = DGV.Rows(e.RowIndex).Cells(0).Value.ToString
        Form1.TextBox5.Text = DGV.Rows(e.RowIndex).Cells(1).Value.ToString
        Form1.TextBox6.Text = DGV.Rows(e.RowIndex).Cells(2).Value.ToString
        Form1.TextBox7.Text = DGV.Rows(e.RowIndex).Cells(0).Value.ToString
        Tagihan.kdtarif.Text = DGV.Rows(e.RowIndex).Cells(0).Value.ToString
        Tagihan.daya.Text = DGV.Rows(e.RowIndex).Cells(1).Value.ToString

        Me.Close()
    End Sub

    Private Sub DGV_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DGV.CellContentClick

    End Sub
End Class