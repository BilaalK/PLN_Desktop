Imports System.Data.Odbc
Public Class Tagihan
    Sub tampil()
        dataadapter = New OdbcDataAdapter("select * from tagihan", connection)
        dataset = New DataSet
        dataset.Clear()
        dataadapter.Fill(dataset, "tagihan")
        DataGridView1.DataSource = (dataset.Tables("tagihan"))
        DataGridView1.ReadOnly = True
        DataGridView1.Columns(0).Width = 70
        DataGridView1.Columns(1).Width = 100
        DataGridView1.Columns(2).Width = 50
        DataGridView1.Columns(3).Width = 50
        DataGridView1.Columns(4).Width = 100
        DataGridView1.Columns(5).Width = 100
        DataGridView1.Columns(6).Width = 100
        DataGridView1.Columns(7).Width = 100
        DataGridView1.Columns(8).Width = 100




    End Sub
    Sub hitungbulan()

        Dim MyDate As Date = Now
        Dim DaysInMonth As Integer = Date.DaysInMonth(MyDate.Year, MyDate.Month)
        'MsgBox(DaysInMonth)



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
    Sub buka()


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
        pemakaian.Text = ""
        TextBox10.Text = ""

        kdtarif.Text = ""
        daya.Text = ""
        TextBox1.Text = ""

        Call nomorotomatis()
        Call buka()
        Call tanggal()

    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        CariTarif.Show()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        CariPakai.Show()
    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged

    End Sub

    Private Sub pemakaian_TextChanged(sender As Object, e As EventArgs) Handles pemakaian.TextChanged
        TextBox1.Text = Val(daya.Text) * Val(pemakaian.Text)
    End Sub

    Private Sub PembayaranToolStripMenuItem_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub ToolTip1_Popup(sender As Object, e As PopupEventArgs)

    End Sub

    Private Sub TarifToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles TarifToolStripMenuItem.Click
        Tarif.Show()
        Me.Hide()
    End Sub


    Private Sub PembayaranToolStripMenuItem_Click_1(sender As Object, e As EventArgs) Handles PembayaranToolStripMenuItem.Click
        Pembayaran.Show()
        Me.Hide()
    End Sub

    Private Sub PelangganToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PelangganToolStripMenuItem.Click
        Form1.Show()
        Me.Hide()
    End Sub

    Private Sub Label4_Click(sender As Object, e As EventArgs) Handles Label4.Click

    End Sub

    Private Sub Label8_Click(sender As Object, e As EventArgs) Handles Label8.Click

    End Sub

    Private Sub Tagihan_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Connect()
        tampil()
        tanggal()
        buka()
        nomorotomatis()

        hitungbulan()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        CariPelanggan.Show()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Try

            If MessageBox.Show(" Tambah Data?", "", MessageBoxButtons.YesNo) = MsgBoxResult.Yes Then
                Dim sqltambah As String = "insert into tagihan values('" & idtagih.Text & "','" & kdtagih.Text & "', '" & thtagih.Text & "', '" & bltagih.Text & "', '" & kdtarif.Text & "', '" & pemakaian.Text & "', '" & status.Text & "','" & TextBox10.Text & "','" & TextBox1.Text & "')"
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

    Private Sub DGV_CellMouseClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles DataGridView1.CellMouseClick


        idtagih.Text = DataGridView1.CurrentRow.Cells(0).Value
        kdtagih.Text = DataGridView1.CurrentRow.Cells(1).Value
        thtagih.Text = DataGridView1.CurrentRow.Cells(2).Value
        bltagih.Text = DataGridView1.CurrentRow.Cells(3).Value
        kdtarif.Text = DataGridView1.CurrentRow.Cells(4).Value
        pemakaian.Text = DataGridView1.CurrentRow.Cells(5).Value
        status.Text = DataGridView1.CurrentRow.Cells(6).Value
        TextBox10.Text = DataGridView1.CurrentRow.Cells(7).Value
        TextBox1.Text = DataGridView1.CurrentRow.Cells(8).Value



    End Sub

    Private Sub SymbolBox1_Click(sender As Object, e As EventArgs) Handles SymbolBox1.Click
        If MessageBox.Show("Yakin Ingin Kembali ke Home?", "",
                               MessageBoxButtons.YesNo) = MsgBoxResult.Yes Then
            Home.Show()
            Me.Hide()
        End If
    End Sub

    Private Sub PenggunaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PenggunaToolStripMenuItem.Click

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