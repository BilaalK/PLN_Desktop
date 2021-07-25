Public Class CariPakai
    Private Sub CariPakai_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        tampil()

    End Sub
    Private Sub DGV_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DGV.CellClick
        Tagihan.pemakaian.Text = DGV.Rows(e.RowIndex).Cells(5).Value.ToString
        Me.Close()
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
        DGV.Columns(4).Width = 150
        DGV.Columns(5).Width = 150

    End Sub

End Class