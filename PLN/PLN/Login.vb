Imports System.Data.Odbc

Public Class Login
    Public akun As String
    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub Login_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        TextBox1.Focus()
        Connect()

    End Sub
    Sub kosongkan()
        TextBox1.Text = ""
        TextBox2.Text = ""
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Try

            If TextBox1.Text = "" Then
                MsgBox("Isi username anda")
            ElseIf TextBox2.Text = "" Then
                MsgBox("Isi password anda")
            Else

                Connect()
                Dim cmd As OdbcCommand = New OdbcCommand("Select * from user where username = '" & TextBox1.Text & "' and password = md5('" & TextBox2.Text & "')", connection)
                Dim rd As OdbcDataReader = cmd.ExecuteReader
                rd.Read()

                If rd.HasRows Then

                    If rd.Item("level") = "1" Then
                        Home.Show()
                        Home.TarifToolStripMenuItem1.Enabled = True
                        Home.PenggunaToolStripMenuItem1.Enabled = True
                        Home.TagihanToolStripMenuItem1.Enabled = True
                        Home.PemakaianToolStripMenuItem1.Enabled = True
                        Home.PemakaianToolStripMenuItem2.Enabled = True
                        Home.DataUserToolStripMenuItem.Enabled = True
                        akun = rd.Item(0)
                        Me.Hide()

                    ElseIf rd.Item("level") = "2" Then
                        Home.Show()
                        Home.TarifToolStripMenuItem1.Enabled = False
                        Home.PenggunaToolStripMenuItem1.Enabled = False
                        Home.TagihanToolStripMenuItem1.Enabled = False
                        Home.PemakaianToolStripMenuItem1.Enabled = False
                        Home.PemakaianToolStripMenuItem2.Enabled = True
                        Home.DataUserToolStripMenuItem.Enabled = False
                        akun = rd.Item(0)
                        Me.Hide()

                    ElseIf rd.Item("level") = "3" Then
                        Home.Show()
                        Home.TarifToolStripMenuItem1.Enabled = False
                        Home.PenggunaToolStripMenuItem1.Enabled = False
                        Home.TagihanToolStripMenuItem1.Enabled = True
                        Home.PemakaianToolStripMenuItem1.Enabled = False
                        Home.PemakaianToolStripMenuItem2.Enabled = False
                        Home.DataUserToolStripMenuItem.Enabled = False
                        akun = rd.Item(0)
                        Me.Hide()

                    End If

                Else

                    MsgBox("Username dan Password tidak valid")
                    TextBox1.Focus()

                End If
            End If

        Catch ex As Exception

            MsgBox(ex.ToString, MsgBoxStyle.Exclamation, "Terjadi Kesalahan")

        End Try

        kosongkan()
        TextBox1.Focus()

    End Sub
    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked

        DataUser.Show()
        Me.Hide()
        DataUser.Button2.Visible = False
        DataUser.Button4.Visible = False
        DataUser.RadioButton1.Visible = False
        DataUser.RadioButton2.Visible = False
        DataUser.RadioButton4.Visible = False
        DataUser.HomeToolStripMenuItem.Visible = False
        DataUser.LogoutToolStripMenuItem.Text = "Back"

    End Sub
End Class