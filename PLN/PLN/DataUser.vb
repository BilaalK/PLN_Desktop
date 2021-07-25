Imports System.Data.Odbc
Public Class DataUser
    Dim s As String
    Private Sub DataUser_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Connect()
        tampil()
    End Sub
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If RadioButton1.Checked = True Then
            s = "1"
        ElseIf RadioButton2.Checked = True Then
            s = "2"
        ElseIf RadioButton3.Checked = True Then
            s = "3"
        ElseIf RadioButton4.Checked = True Then
            s = "4"
        End If
        Dim edit As String = "UPDATE user SET password = md5('" & TextBox2.Text & "'),nama = '" & TextBox3.Text & "',alamat = '" & TextBox4.Text & "',level = '" & s & "' WHERE username = '" & TextBox1.Text & "'"
        command = New OdbcCommand(edit, connection)
        command.ExecuteNonQuery()
        MsgBox("update data data berhasil")
        Call tampil()
        Call kosongkan()
        Button1.Enabled = True
    End Sub

    Private Sub DataGridView1_CellMouseClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick
        TextBox1.Text = DataGridView1.CurrentRow.Cells(0).Value
        TextBox2.Text = DataGridView1.CurrentRow.Cells(1).Value
        TextBox3.Text = DataGridView1.CurrentRow.Cells(2).Value
        TextBox4.Text = DataGridView1.CurrentRow.Cells(3).Value
        If s = "1" Then
            RadioButton1.Checked = True
            RadioButton2.Checked = False
        ElseIf s = "2" Then
            RadioButton1.Checked = False
            RadioButton2.Checked = True
        ElseIf s = "3" Then
            RadioButton1.Checked = False
            RadioButton2.Checked = True
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        If RadioButton1.Checked = True Then
            s = "1"
        ElseIf RadioButton2.Checked = True Then
            s = "2"
        ElseIf RadioButton3.Checked = True Then
            s = "3"
        ElseIf RadioButton4.Checked = True Then
            s = "4"
        End If

        If TextBox1.Text = "" Or TextBox2.Text = "" Or TextBox3.Text = "" Or TextBox4.Text = "" Then
            MsgBox("Masukan inputan dengan benar.")
        Else
            command = New OdbcCommand("select * from user where username='" & TextBox1.Text & "'", connection)
            read = command.ExecuteReader
            read.Read()
            If Not read.HasRows Then

                Dim simpan As String = "INSERT INTO user VALUES('" & (TextBox1.Text) & "',md5('" & TextBox2.Text & "'),'" & TextBox3.Text & "', '" & TextBox4.Text & "','" & s & "')"
                command = New OdbcCommand(simpan, connection)
                command.ExecuteNonQuery()
                MsgBox("Input Data Berhasil")
                kosongkan()
                tampil()

            Else
                MsgBox("Username Telah Digunakan")
                tampil()

            End If
        End If
    End Sub

    Sub kosongkan()
        TextBox1.Clear()
        TextBox2.Clear()
        TextBox3.Clear()
        TextBox4.Clear()
        RadioButton1.Checked = False
        RadioButton2.Checked = False
        RadioButton3.Checked = False
        RadioButton4.Checked = False
        RadioButton1.Enabled = True
        RadioButton2.Enabled = True
        RadioButton3.Enabled = True
        RadioButton4.Enabled = True
    End Sub
    Sub tampil()
        dataadapter = New OdbcDataAdapter("Select * from user", connection)
        dataset = New DataSet
        dataset.Clear()
        dataadapter.Fill(dataset, "user")
        DataGridView1.DataSource = (dataset.Tables("user"))
        DataGridView1.ReadOnly = True
        DataGridView1.Columns(0).Width = 75
        DataGridView1.Columns(1).Width = 100
        DataGridView1.Columns(2).Width = 100
        DataGridView1.Columns(3).Width = 75
        DataGridView1.Columns(4).Width = 75
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        If MessageBox.Show("Yakin akan dihapus?", "",
                               MessageBoxButtons.YesNo) = MsgBoxResult.Yes Then
            command = New OdbcCommand("Delete from user where username = '" & TextBox1.Text & "'", connection)
            command.ExecuteNonQuery()
            Call kosongkan()
            Call tampil()
        Else
            Call kosongkan()
        End If

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        kosongkan()
    End Sub

    Private Sub LogoutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LogoutToolStripMenuItem.Click

            Login.Show()
            Me.Hide()

    End Sub

    Private Sub HomeToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles HomeToolStripMenuItem.Click
        If MessageBox.Show("Yakin Ingin Kembali ke Home?", "",
                               MessageBoxButtons.YesNo) = MsgBoxResult.Yes Then
            Home.Show()
            Me.Hide()
        End If
    End Sub
End Class