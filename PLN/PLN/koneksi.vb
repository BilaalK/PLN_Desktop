Imports System.Data.Odbc
Module koneksi
    Public connection As OdbcConnection
    Public dataadapter As OdbcDataAdapter
    Public dataset As New DataSet
    Public command As New OdbcCommand
    Public read As OdbcDataReader
    Public str As String
    Public kodeTarif As String
    Public pemakaianTarif As String
    Public kodePelanggan As String
    Public kodeTagihan As String
    Public pemakaianTagihan As String
    Public tarifprkwh As String
    Public dayadaya As String
    Public tarifdaya As String
    Public tarifpengguna As String
    Public kd_pemakai As String
    Public kd_pelanggan As String
    Public pemakaiandaya As String
    Public jumlah_pemakaian As String
    Public tarif_pengguna As String

    Public Sub Connect()
        str = "Driver={MYSQL ODBC 5.3 ANSI Driver}; database=bilaal_pln; server=localhost;uid=root"
        connection = New OdbcConnection(str)
        If connection.State = ConnectionState.Closed Then
            connection.Open()
        End If
    End Sub



End Module
